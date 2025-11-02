'use client';

import { useState, useMemo } from 'react';
import { Search, MapPin, Phone, Stethoscope, DollarSign, Shield, Languages, Filter } from 'lucide-react';
import Header from '@/components/Header';
import Footer from '@/components/Footer';
import { Locale } from '@/types';
import { t } from '@/lib/translations';
import { doctors } from '@/data/doctors';

export default function DoctorsPage() {
  const [locale, setLocale] = useState<Locale>('ar');
  const [searchQuery, setSearchQuery] = useState('');
  const [selectedSpecialty, setSelectedSpecialty] = useState('all');
  const [selectedNeighborhood, setSelectedNeighborhood] = useState('all');
  const [showAvailableOnly, setShowAvailableOnly] = useState(false);

  // Get unique specialties and neighborhoods
  const specialties = useMemo(() => {
    const unique = new Set(doctors.map((d) => d.specialty));
    return Array.from(unique);
  }, []);

  const neighborhoods = useMemo(() => {
    const unique = new Set(doctors.map((d) => d.location.neighborhood));
    return Array.from(unique);
  }, []);

  // Filter doctors
  const filteredDoctors = useMemo(() => {
    return doctors.filter((doctor) => {
      const matchesSearch =
        searchQuery === '' ||
        doctor.name.toLowerCase().includes(searchQuery.toLowerCase()) ||
        doctor.specialty.toLowerCase().includes(searchQuery.toLowerCase()) ||
        doctor.location.address.toLowerCase().includes(searchQuery.toLowerCase());

      const matchesSpecialty =
        selectedSpecialty === 'all' || doctor.specialty === selectedSpecialty;

      const matchesNeighborhood =
        selectedNeighborhood === 'all' ||
        doctor.location.neighborhood === selectedNeighborhood;

      const matchesAvailability = !showAvailableOnly || doctor.isAvailableNow;

      return matchesSearch && matchesSpecialty && matchesNeighborhood && matchesAvailability;
    });
  }, [searchQuery, selectedSpecialty, selectedNeighborhood, showAvailableOnly]);

  const availableCount = doctors.filter((d) => d.isAvailableNow).length;

  return (
    <div className="min-h-screen flex flex-col" dir={locale === 'ar' ? 'rtl' : 'ltr'}>
      <Header locale={locale} onLocaleChange={setLocale} />

      <main className="flex-1 bg-gray-50">
        {/* Page Header */}
        <section className="bg-gradient-to-br from-blue-500 via-blue-600 to-blue-700 text-white py-12">
          <div className="container mx-auto px-4">
            <div className="max-w-4xl mx-auto">
              <h1 className="text-4xl font-bold mb-4 flex items-center gap-3">
                <Stethoscope className="w-10 h-10" />
                {t('doctors.title', locale)}
              </h1>
              <p className="text-xl text-blue-50">
                {locale === 'ar'
                  ? `${availableCount} طبيب متاح الآن`
                  : `${availableCount} médecins disponibles maintenant`}
              </p>
            </div>
          </div>
        </section>

        {/* Search and Filters */}
        <section className="bg-white shadow-md sticky top-16 z-40">
          <div className="container mx-auto px-4 py-4">
            <div className="max-w-4xl mx-auto">
              <div className="grid grid-cols-1 md:grid-cols-12 gap-4">
                {/* Search Input */}
                <div className="md:col-span-4 relative">
                  <Search className="absolute right-3 top-1/2 -translate-y-1/2 w-5 h-5 text-gray-400" />
                  <input
                    type="text"
                    placeholder={
                      locale === 'ar' ? 'ابحث عن طبيب...' : 'Rechercher un médecin...'
                    }
                    value={searchQuery}
                    onChange={(e) => setSearchQuery(e.target.value)}
                    className="input pr-10"
                    dir={locale === 'ar' ? 'rtl' : 'ltr'}
                  />
                </div>

                {/* Specialty Filter */}
                <div className="md:col-span-3">
                  <select
                    value={selectedSpecialty}
                    onChange={(e) => setSelectedSpecialty(e.target.value)}
                    className="input"
                    dir={locale === 'ar' ? 'rtl' : 'ltr'}
                  >
                    <option value="all">{t('search.allSpecialties', locale)}</option>
                    {specialties.map((specialty) => (
                      <option key={specialty} value={specialty}>
                        {specialty}
                      </option>
                    ))}
                  </select>
                </div>

                {/* Neighborhood Filter */}
                <div className="md:col-span-3">
                  <select
                    value={selectedNeighborhood}
                    onChange={(e) => setSelectedNeighborhood(e.target.value)}
                    className="input"
                    dir={locale === 'ar' ? 'rtl' : 'ltr'}
                  >
                    <option value="all">{t('search.allNeighborhoods', locale)}</option>
                    {neighborhoods.map((neighborhood) => (
                      <option key={neighborhood} value={neighborhood}>
                        {neighborhood}
                      </option>
                    ))}
                  </select>
                </div>

                {/* Available Only Toggle */}
                <div className="md:col-span-2">
                  <button
                    onClick={() => setShowAvailableOnly(!showAvailableOnly)}
                    className={`w-full h-full px-4 py-2 rounded-lg font-medium transition-all flex items-center justify-center gap-2 ${
                      showAvailableOnly
                        ? 'bg-blue-500 text-white'
                        : 'bg-gray-200 text-gray-700 hover:bg-gray-300'
                    }`}
                  >
                    <Filter className="w-4 h-4" />
                    {t('search.availableOnly', locale)}
                  </button>
                </div>
              </div>

              {/* Results Count */}
              <p className="mt-4 text-sm text-gray-600">
                {filteredDoctors.length} {t('search.resultsFound', locale)}
              </p>
            </div>
          </div>
        </section>

        {/* Doctors List */}
        <section className="py-8">
          <div className="container mx-auto px-4">
            <div className="max-w-4xl mx-auto">
              {filteredDoctors.length === 0 ? (
                <div className="text-center py-12">
                  <Stethoscope className="w-16 h-16 text-gray-300 mx-auto mb-4" />
                  <p className="text-xl text-gray-600">{t('search.noResults', locale)}</p>
                </div>
              ) : (
                <div className="space-y-6">
                  {filteredDoctors.map((doctor) => (
                    <div
                      key={doctor.id}
                      className={`bg-white rounded-xl shadow-lg p-6 card-hover ${
                        doctor.isAvailableNow ? 'border-2 border-blue-500' : ''
                      }`}
                    >
                      <div className="flex flex-col md:flex-row md:items-start md:justify-between gap-4">
                        {/* Doctor Info */}
                        <div className="flex-1">
                          <div className="flex items-start gap-3 mb-3">
                            <div className="w-12 h-12 bg-blue-100 rounded-lg flex items-center justify-center flex-shrink-0">
                              <Stethoscope className="w-6 h-6 text-blue-600" />
                            </div>
                            <div>
                              <h3 className="text-2xl font-bold text-gray-800 mb-2">
                                {doctor.name}
                              </h3>
                              <div className="flex flex-wrap gap-2">
                                {doctor.isAvailableNow && (
                                  <span className="badge badge-success">
                                    {t('doctors.availableNow', locale)}
                                  </span>
                                )}
                                <span className="badge badge-info">{doctor.specialty}</span>
                                <span className="badge badge-warning">
                                  {doctor.location.neighborhood}
                                </span>
                              </div>
                            </div>
                          </div>

                          {/* Contact Info */}
                          <div className="space-y-2 mb-4">
                            <div className="flex items-start gap-2 text-gray-600">
                              <MapPin className="w-5 h-5 flex-shrink-0 mt-0.5" />
                              <span>{doctor.location.address}</span>
                            </div>
                            <div className="flex items-center gap-2 text-gray-600">
                              <Phone className="w-5 h-5 flex-shrink-0" />
                              <a
                                href={`tel:${doctor.contact.phone}`}
                                className="text-primary-600 hover:underline font-medium"
                              >
                                {doctor.contact.phone}
                              </a>
                            </div>
                          </div>

                          {/* Additional Info */}
                          <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
                            {/* Languages */}
                            {doctor.languages && doctor.languages.length > 0 && (
                              <div className="flex items-start gap-2">
                                <Languages className="w-5 h-5 text-gray-400 flex-shrink-0" />
                                <div>
                                  <p className="text-sm font-medium text-gray-700">
                                    {t('doctors.languages', locale)}:
                                  </p>
                                  <p className="text-sm text-gray-600">
                                    {doctor.languages.join(', ')}
                                  </p>
                                </div>
                              </div>
                            )}

                            {/* Insurance */}
                            {doctor.acceptsInsurance && (
                              <div className="flex items-center gap-2">
                                <Shield className="w-5 h-5 text-green-500 flex-shrink-0" />
                                <span className="text-sm text-gray-700">
                                  {t('doctors.acceptsInsurance', locale)}
                                </span>
                              </div>
                            )}

                            {/* Consultation Fee */}
                            {doctor.consultationFee && (
                              <div className="flex items-center gap-2">
                                <DollarSign className="w-5 h-5 text-gray-400 flex-shrink-0" />
                                <div>
                                  <p className="text-sm font-medium text-gray-700">
                                    {t('doctors.consultationFee', locale)}:
                                  </p>
                                  <p className="text-lg font-bold text-primary-600">
                                    {doctor.consultationFee} {locale === 'ar' ? 'درهم' : 'DH'}
                                  </p>
                                </div>
                              </div>
                            )}
                          </div>

                          {/* Working Hours Preview */}
                          {doctor.isAvailableNow && (
                            <div className="bg-blue-50 border border-blue-200 rounded-lg p-3 mt-4">
                              <p className="text-sm font-medium text-blue-800">
                                {locale === 'ar'
                                  ? '✓ متاح للاستشارات الآن'
                                  : '✓ Disponible pour consultations maintenant'}
                              </p>
                            </div>
                          )}
                        </div>

                        {/* Action Buttons */}
                        <div className="flex md:flex-col gap-2 w-full md:w-auto">
                          <a
                            href={`tel:${doctor.contact.phone}`}
                            className="btn btn-primary flex-1 md:flex-initial flex items-center justify-center gap-2"
                          >
                            <Phone className="w-4 h-4" />
                            {t('actions.call', locale)}
                          </a>
                          {doctor.contact.whatsapp && (
                            <a
                              href={`https://wa.me/${doctor.contact.whatsapp.replace(/\+/g, '')}`}
                              target="_blank"
                              rel="noopener noreferrer"
                              className="btn btn-outline flex-1 md:flex-initial flex items-center justify-center gap-2"
                            >
                              <Phone className="w-4 h-4" />
                              {t('actions.whatsapp', locale)}
                            </a>
                          )}
                          <a
                            href={`https://www.google.com/maps/search/?api=1&query=${doctor.location.lat},${doctor.location.lng}`}
                            target="_blank"
                            rel="noopener noreferrer"
                            className="btn btn-secondary flex-1 md:flex-initial flex items-center justify-center gap-2"
                          >
                            <MapPin className="w-4 h-4" />
                            {t('pharmacies.getDirections', locale)}
                          </a>
                        </div>
                      </div>
                    </div>
                  ))}
                </div>
              )}
            </div>
          </div>
        </section>
      </main>

      <Footer locale={locale} />
    </div>
  );
}
