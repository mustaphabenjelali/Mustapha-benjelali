'use client';

import { useState } from 'react';
import { Search, Heart, Stethoscope, MapPin, Phone, Clock } from 'lucide-react';
import Header from '@/components/Header';
import Footer from '@/components/Footer';
import { Locale } from '@/types';
import { t } from '@/lib/translations';
import { pharmacies } from '@/data/pharmacies';
import { doctors } from '@/data/doctors';

export default function Home() {
  const [locale, setLocale] = useState<Locale>('ar');
  const [searchQuery, setSearchQuery] = useState('');

  const onDutyPharmacies = pharmacies.filter((p) => p.onDuty);
  const availableDoctors = doctors.filter((d) => d.isAvailableNow);

  const quickAccessCards = [
    {
      title: t('home.quickAccess.onDutyPharmacies', locale),
      count: onDutyPharmacies.length,
      icon: Heart,
      color: 'bg-green-500',
      href: '/pharmacies',
    },
    {
      title: t('home.quickAccess.availableDoctors', locale),
      count: availableDoctors.length,
      icon: Stethoscope,
      color: 'bg-blue-500',
      href: '/doctors',
    },
    {
      title: t('home.quickAccess.viewMap', locale),
      icon: MapPin,
      color: 'bg-purple-500',
      href: '/map',
    },
    {
      title: t('home.quickAccess.emergencyServices', locale),
      icon: Phone,
      color: 'bg-red-500',
      href: 'tel:141',
    },
  ];

  return (
    <div className="min-h-screen flex flex-col" dir={locale === 'ar' ? 'rtl' : 'ltr'}>
      <Header locale={locale} onLocaleChange={setLocale} />

      <main className="flex-1">
        {/* Hero Section */}
        <section className="bg-gradient-to-br from-primary-500 via-primary-600 to-primary-700 text-white py-20">
          <div className="container mx-auto px-4">
            <div className="max-w-3xl mx-auto text-center">
              <h1 className="text-4xl md:text-5xl font-bold mb-6 animate-fade-in">
                {t('home.hero.title', locale)}
              </h1>
              <p className="text-xl md:text-2xl mb-8 text-primary-50 animate-fade-in">
                {t('home.hero.subtitle', locale)}
              </p>

              {/* Search Bar */}
              <div className="bg-white rounded-xl shadow-2xl p-2 flex items-center gap-2 animate-fade-in">
                <Search className="w-6 h-6 text-gray-400 mr-2" />
                <input
                  type="text"
                  placeholder={t('home.hero.searchPlaceholder', locale)}
                  value={searchQuery}
                  onChange={(e) => setSearchQuery(e.target.value)}
                  className="flex-1 px-4 py-3 text-gray-800 outline-none"
                  dir={locale === 'ar' ? 'rtl' : 'ltr'}
                />
                <button className="btn btn-primary px-8">
                  {t('search.search', locale)}
                </button>
              </div>
            </div>
          </div>
        </section>

        {/* Quick Access Cards */}
        <section className="py-12 bg-gray-50">
          <div className="container mx-auto px-4">
            <h2 className="text-3xl font-bold text-center mb-8 text-gray-800">
              {t('home.quickAccess.title', locale)}
            </h2>

            <div className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-4 gap-6">
              {quickAccessCards.map((card, index) => (
                <a
                  key={index}
                  href={card.href}
                  className="bg-white rounded-xl shadow-lg p-6 card-hover cursor-pointer animate-fade-in"
                  style={{ animationDelay: `${index * 0.1}s` }}
                >
                  <div className={`w-14 h-14 ${card.color} rounded-lg flex items-center justify-center mb-4`}>
                    <card.icon className="w-8 h-8 text-white" />
                  </div>
                  <h3 className="font-bold text-lg mb-2 text-gray-800">
                    {card.title}
                  </h3>
                  {card.count !== undefined && (
                    <p className="text-3xl font-bold text-primary-600">
                      {card.count}
                    </p>
                  )}
                </a>
              ))}
            </div>
          </div>
        </section>

        {/* On Duty Pharmacies Today */}
        <section className="py-12 bg-white">
          <div className="container mx-auto px-4">
            <div className="flex items-center justify-between mb-8">
              <h2 className="text-3xl font-bold text-gray-800">
                {t('pharmacies.onDutyNow', locale)}
              </h2>
              <a
                href="/pharmacies"
                className="text-primary-600 hover:text-primary-700 font-medium"
              >
                {locale === 'ar' ? 'عرض الكل ←' : 'Voir tout →'}
              </a>
            </div>

            <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
              {onDutyPharmacies.slice(0, 3).map((pharmacy) => (
                <div
                  key={pharmacy.id}
                  className="bg-white border-2 border-green-500 rounded-xl p-6 card-hover"
                >
                  <div className="flex items-start justify-between mb-4">
                    <div>
                      <h3 className="font-bold text-xl text-gray-800 mb-2">
                        {pharmacy.name}
                      </h3>
                      <span className="badge badge-success">
                        {t('pharmacies.onDutyNow', locale)}
                      </span>
                    </div>
                    <Heart className="w-8 h-8 text-green-500" fill="currentColor" />
                  </div>

                  <div className="space-y-2 text-sm text-gray-600">
                    <div className="flex items-center gap-2">
                      <MapPin className="w-4 h-4" />
                      <span>{pharmacy.location.neighborhood}</span>
                    </div>
                    <div className="flex items-center gap-2">
                      <Phone className="w-4 h-4" />
                      <a
                        href={`tel:${pharmacy.contact.phone}`}
                        className="text-primary-600 hover:underline"
                      >
                        {pharmacy.contact.phone}
                      </a>
                    </div>
                    {pharmacy.dutySchedule && (
                      <div className="flex items-center gap-2">
                        <Clock className="w-4 h-4" />
                        <span>
                          {new Date(pharmacy.dutySchedule.startDate).toLocaleDateString(locale)} -{' '}
                          {new Date(pharmacy.dutySchedule.endDate).toLocaleDateString(locale)}
                        </span>
                      </div>
                    )}
                  </div>

                  <button className="btn btn-primary w-full mt-4">
                    {t('actions.viewDetails', locale)}
                  </button>
                </div>
              ))}
            </div>
          </div>
        </section>

        {/* Available Doctors */}
        <section className="py-12 bg-gray-50">
          <div className="container mx-auto px-4">
            <div className="flex items-center justify-between mb-8">
              <h2 className="text-3xl font-bold text-gray-800">
                {t('doctors.availableNow', locale)}
              </h2>
              <a
                href="/doctors"
                className="text-primary-600 hover:text-primary-700 font-medium"
              >
                {locale === 'ar' ? 'عرض الكل ←' : 'Voir tout →'}
              </a>
            </div>

            <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
              {availableDoctors.slice(0, 3).map((doctor) => (
                <div
                  key={doctor.id}
                  className="bg-white rounded-xl p-6 shadow-lg card-hover"
                >
                  <div className="flex items-start justify-between mb-4">
                    <div>
                      <h3 className="font-bold text-xl text-gray-800 mb-2">
                        {doctor.name}
                      </h3>
                      <span className="badge badge-info">{doctor.specialty}</span>
                    </div>
                    <Stethoscope className="w-8 h-8 text-blue-500" />
                  </div>

                  <div className="space-y-2 text-sm text-gray-600 mb-4">
                    <div className="flex items-center gap-2">
                      <MapPin className="w-4 h-4" />
                      <span>{doctor.location.neighborhood}</span>
                    </div>
                    <div className="flex items-center gap-2">
                      <Phone className="w-4 h-4" />
                      <a
                        href={`tel:${doctor.contact.phone}`}
                        className="text-primary-600 hover:underline"
                      >
                        {doctor.contact.phone}
                      </a>
                    </div>
                  </div>

                  {doctor.consultationFee && (
                    <p className="text-lg font-bold text-primary-600 mb-4">
                      {doctor.consultationFee} {locale === 'ar' ? 'درهم' : 'DH'}
                    </p>
                  )}

                  <button className="btn btn-outline w-full">
                    {t('doctors.bookAppointment', locale)}
                  </button>
                </div>
              ))}
            </div>
          </div>
        </section>

        {/* Info Section */}
        <section className="py-12 bg-primary-50">
          <div className="container mx-auto px-4 text-center">
            <h2 className="text-3xl font-bold text-gray-800 mb-4">
              {locale === 'ar'
                ? 'مبادرة مواطنية ذكية لخدمة المجتمع'
                : 'Initiative citoyenne intelligente au service de la communauté'}
            </h2>
            <p className="text-lg text-gray-600 max-w-3xl mx-auto">
              {locale === 'ar'
                ? 'نسعى لتوفير معلومات صحية دقيقة ومحدثة لسكان الناظور، مع التركيز على سهولة الوصول والاستخدام'
                : 'Nous nous efforçons de fournir des informations de santé précises et à jour aux habitants de Nador, en mettant l\'accent sur l\'accessibilité et la facilité d\'utilisation'}
            </p>
          </div>
        </section>
      </main>

      <Footer locale={locale} />
    </div>
  );
}
