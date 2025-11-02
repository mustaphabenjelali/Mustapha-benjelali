'use client';

import { useState, useMemo } from 'react';
import { Search, MapPin, Phone, Clock, Heart, Filter } from 'lucide-react';
import Header from '@/components/Header';
import Footer from '@/components/Footer';
import { Locale } from '@/types';
import { t } from '@/lib/translations';
import { pharmacies } from '@/data/pharmacies';

export default function PharmaciesPage() {
  const [locale, setLocale] = useState<Locale>('ar');
  const [searchQuery, setSearchQuery] = useState('');
  const [selectedNeighborhood, setSelectedNeighborhood] = useState('all');
  const [showOnDutyOnly, setShowOnDutyOnly] = useState(false);

  // Get unique neighborhoods
  const neighborhoods = useMemo(() => {
    const unique = new Set(pharmacies.map((p) => p.location.neighborhood));
    return Array.from(unique);
  }, []);

  // Filter pharmacies
  const filteredPharmacies = useMemo(() => {
    return pharmacies.filter((pharmacy) => {
      const matchesSearch =
        searchQuery === '' ||
        pharmacy.name.toLowerCase().includes(searchQuery.toLowerCase()) ||
        pharmacy.location.address.toLowerCase().includes(searchQuery.toLowerCase()) ||
        pharmacy.location.neighborhood.toLowerCase().includes(searchQuery.toLowerCase());

      const matchesNeighborhood =
        selectedNeighborhood === 'all' ||
        pharmacy.location.neighborhood === selectedNeighborhood;

      const matchesOnDuty = !showOnDutyOnly || pharmacy.onDuty;

      return matchesSearch && matchesNeighborhood && matchesOnDuty;
    });
  }, [searchQuery, selectedNeighborhood, showOnDutyOnly]);

  const onDutyCount = pharmacies.filter((p) => p.onDuty).length;

  return (
    <div className="min-h-screen flex flex-col" dir={locale === 'ar' ? 'rtl' : 'ltr'}>
      <Header locale={locale} onLocaleChange={setLocale} />

      <main className="flex-1 bg-gray-50">
        {/* Page Header */}
        <section className="bg-gradient-to-br from-green-500 via-green-600 to-green-700 text-white py-12">
          <div className="container mx-auto px-4">
            <div className="max-w-4xl mx-auto">
              <h1 className="text-4xl font-bold mb-4 flex items-center gap-3">
                <Heart className="w-10 h-10" fill="currentColor" />
                {t('pharmacies.title', locale)}
              </h1>
              <p className="text-xl text-green-50">
                {locale === 'ar'
                  ? `${onDutyCount} صيدلية مناوبة متاحة الآن`
                  : `${onDutyCount} pharmacies de garde disponibles maintenant`}
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
                <div className="md:col-span-5 relative">
                  <Search className="absolute right-3 top-1/2 -translate-y-1/2 w-5 h-5 text-gray-400" />
                  <input
                    type="text"
                    placeholder={
                      locale === 'ar'
                        ? 'ابحث عن صيدلية...'
                        : 'Rechercher une pharmacie...'
                    }
                    value={searchQuery}
                    onChange={(e) => setSearchQuery(e.target.value)}
                    className="input pr-10"
                    dir={locale === 'ar' ? 'rtl' : 'ltr'}
                  />
                </div>

                {/* Neighborhood Filter */}
                <div className="md:col-span-4">
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

                {/* On Duty Only Toggle */}
                <div className="md:col-span-3">
                  <button
                    onClick={() => setShowOnDutyOnly(!showOnDutyOnly)}
                    className={`w-full h-full px-4 py-2 rounded-lg font-medium transition-all flex items-center justify-center gap-2 ${
                      showOnDutyOnly
                        ? 'bg-green-500 text-white'
                        : 'bg-gray-200 text-gray-700 hover:bg-gray-300'
                    }`}
                  >
                    <Filter className="w-4 h-4" />
                    {t('search.onDutyOnly', locale)}
                  </button>
                </div>
              </div>

              {/* Results Count */}
              <p className="mt-4 text-sm text-gray-600">
                {filteredPharmacies.length} {t('search.resultsFound', locale)}
              </p>
            </div>
          </div>
        </section>

        {/* Pharmacies List */}
        <section className="py-8">
          <div className="container mx-auto px-4">
            <div className="max-w-4xl mx-auto">
              {filteredPharmacies.length === 0 ? (
                <div className="text-center py-12">
                  <Heart className="w-16 h-16 text-gray-300 mx-auto mb-4" />
                  <p className="text-xl text-gray-600">{t('search.noResults', locale)}</p>
                </div>
              ) : (
                <div className="space-y-6">
                  {filteredPharmacies.map((pharmacy) => (
                    <div
                      key={pharmacy.id}
                      className={`bg-white rounded-xl shadow-lg p-6 card-hover ${
                        pharmacy.onDuty ? 'border-2 border-green-500' : ''
                      }`}
                    >
                      <div className="flex flex-col md:flex-row md:items-start md:justify-between gap-4">
                        {/* Pharmacy Info */}
                        <div className="flex-1">
                          <div className="flex items-start gap-3 mb-3">
                            <div className="w-12 h-12 bg-green-100 rounded-lg flex items-center justify-center flex-shrink-0">
                              <Heart className="w-6 h-6 text-green-600" fill="currentColor" />
                            </div>
                            <div>
                              <h3 className="text-2xl font-bold text-gray-800 mb-2">
                                {pharmacy.name}
                              </h3>
                              <div className="flex flex-wrap gap-2">
                                {pharmacy.onDuty && (
                                  <span className="badge badge-success">
                                    {t('pharmacies.onDutyNow', locale)}
                                  </span>
                                )}
                                <span className="badge badge-info">
                                  {pharmacy.location.neighborhood}
                                </span>
                              </div>
                            </div>
                          </div>

                          {/* Contact Info */}
                          <div className="space-y-2 mb-4">
                            <div className="flex items-start gap-2 text-gray-600">
                              <MapPin className="w-5 h-5 flex-shrink-0 mt-0.5" />
                              <span>{pharmacy.location.address}</span>
                            </div>
                            <div className="flex items-center gap-2 text-gray-600">
                              <Phone className="w-5 h-5 flex-shrink-0" />
                              <a
                                href={`tel:${pharmacy.contact.phone}`}
                                className="text-primary-600 hover:underline font-medium"
                              >
                                {pharmacy.contact.phone}
                              </a>
                            </div>
                          </div>

                          {/* Services */}
                          {pharmacy.services && pharmacy.services.length > 0 && (
                            <div className="mb-4">
                              <p className="text-sm font-medium text-gray-700 mb-2">
                                {t('pharmacies.services', locale)}:
                              </p>
                              <div className="flex flex-wrap gap-2">
                                {pharmacy.services.map((service, index) => (
                                  <span
                                    key={index}
                                    className="px-3 py-1 bg-gray-100 text-gray-700 rounded-full text-sm"
                                  >
                                    {service}
                                  </span>
                                ))}
                              </div>
                            </div>
                          )}

                          {/* Duty Schedule */}
                          {pharmacy.onDuty && pharmacy.dutySchedule && (
                            <div className="bg-green-50 border border-green-200 rounded-lg p-3">
                              <div className="flex items-center gap-2 text-green-800">
                                <Clock className="w-5 h-5" />
                                <span className="font-medium">
                                  {t('pharmacies.dutyPeriod', locale)}:
                                </span>
                              </div>
                              <p className="text-sm text-green-700 mt-1 mr-7">
                                {new Date(
                                  pharmacy.dutySchedule.startDate
                                ).toLocaleDateString(locale, {
                                  year: 'numeric',
                                  month: 'long',
                                  day: 'numeric',
                                })}{' '}
                                -{' '}
                                {new Date(pharmacy.dutySchedule.endDate).toLocaleDateString(
                                  locale,
                                  {
                                    year: 'numeric',
                                    month: 'long',
                                    day: 'numeric',
                                  }
                                )}
                              </p>
                            </div>
                          )}
                        </div>

                        {/* Action Buttons */}
                        <div className="flex md:flex-col gap-2 w-full md:w-auto">
                          <a
                            href={`tel:${pharmacy.contact.phone}`}
                            className="btn btn-primary flex-1 md:flex-initial flex items-center justify-center gap-2"
                          >
                            <Phone className="w-4 h-4" />
                            {t('actions.call', locale)}
                          </a>
                          {pharmacy.contact.whatsapp && (
                            <a
                              href={`https://wa.me/${pharmacy.contact.whatsapp.replace(/\+/g, '')}`}
                              target="_blank"
                              rel="noopener noreferrer"
                              className="btn btn-outline flex-1 md:flex-initial flex items-center justify-center gap-2"
                            >
                              <Phone className="w-4 h-4" />
                              {t('actions.whatsapp', locale)}
                            </a>
                          )}
                          <a
                            href={`https://www.google.com/maps/search/?api=1&query=${pharmacy.location.lat},${pharmacy.location.lng}`}
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
