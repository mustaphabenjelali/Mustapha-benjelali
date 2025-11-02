'use client';

import { useState } from 'react';
import dynamic from 'next/dynamic';
import { MapPin, Heart, Stethoscope } from 'lucide-react';
import Header from '@/components/Header';
import Footer from '@/components/Footer';
import { Locale } from '@/types';
import { t } from '@/lib/translations';
import { pharmacies } from '@/data/pharmacies';
import { doctors } from '@/data/doctors';

// Dynamically import MapComponent to avoid SSR issues with Leaflet
const MapComponent = dynamic(() => import('@/components/MapComponent'), {
  ssr: false,
  loading: () => (
    <div className="w-full h-full flex items-center justify-center bg-gray-100 rounded-lg">
      <div className="text-center">
        <div className="spinner mb-4"></div>
        <p className="text-gray-600">جاري تحميل الخريطة...</p>
      </div>
    </div>
  ),
});

export default function MapPage() {
  const [locale, setLocale] = useState<Locale>('ar');
  const [showPharmacies, setShowPharmacies] = useState(true);
  const [showDoctors, setShowDoctors] = useState(true);

  const filteredPharmacies = showPharmacies ? pharmacies : [];
  const filteredDoctors = showDoctors ? doctors : [];

  return (
    <div className="min-h-screen flex flex-col" dir={locale === 'ar' ? 'rtl' : 'ltr'}>
      <Header locale={locale} onLocaleChange={setLocale} />

      <main className="flex-1 bg-gray-50">
        {/* Page Header */}
        <section className="bg-gradient-to-br from-purple-500 via-purple-600 to-purple-700 text-white py-12">
          <div className="container mx-auto px-4">
            <div className="max-w-4xl mx-auto">
              <h1 className="text-4xl font-bold mb-4 flex items-center gap-3">
                <MapPin className="w-10 h-10" />
                {t('nav.map', locale)}
              </h1>
              <p className="text-xl text-purple-50">
                {locale === 'ar'
                  ? 'استكشف جميع المرافق الصحية في الناظور على الخريطة'
                  : 'Explorez tous les établissements de santé à Nador sur la carte'}
              </p>
            </div>
          </div>
        </section>

        {/* Map Controls */}
        <section className="bg-white shadow-md sticky top-16 z-40">
          <div className="container mx-auto px-4 py-4">
            <div className="max-w-4xl mx-auto">
              <div className="flex flex-wrap items-center gap-4">
                <p className="font-medium text-gray-700">
                  {locale === 'ar' ? 'إظهار:' : 'Afficher:'}
                </p>
                <button
                  onClick={() => setShowPharmacies(!showPharmacies)}
                  className={`flex items-center gap-2 px-4 py-2 rounded-lg font-medium transition-all ${
                    showPharmacies
                      ? 'bg-green-500 text-white'
                      : 'bg-gray-200 text-gray-700 hover:bg-gray-300'
                  }`}
                >
                  <Heart className="w-4 h-4" />
                  {t('nav.pharmacies', locale)} ({pharmacies.length})
                </button>
                <button
                  onClick={() => setShowDoctors(!showDoctors)}
                  className={`flex items-center gap-2 px-4 py-2 rounded-lg font-medium transition-all ${
                    showDoctors
                      ? 'bg-blue-500 text-white'
                      : 'bg-gray-200 text-gray-700 hover:bg-gray-300'
                  }`}
                >
                  <Stethoscope className="w-4 h-4" />
                  {t('nav.doctors', locale)} ({doctors.length})
                </button>
              </div>
            </div>
          </div>
        </section>

        {/* Map */}
        <section className="py-8">
          <div className="container mx-auto px-4">
            <div className="max-w-6xl mx-auto">
              <div className="bg-white rounded-xl shadow-lg overflow-hidden">
                <div style={{ height: '600px' }}>
                  <MapComponent
                    pharmacies={filteredPharmacies}
                    doctors={filteredDoctors}
                    locale={locale}
                  />
                </div>
              </div>

              {/* Legend */}
              <div className="mt-6 bg-white rounded-xl shadow-lg p-6">
                <h3 className="font-bold text-lg mb-4 text-gray-800">
                  {locale === 'ar' ? 'مفتاح الخريطة' : 'Légende'}
                </h3>
                <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
                  <div className="flex items-center gap-3">
                    <div className="w-8 h-8 bg-green-500 rounded-full flex items-center justify-center">
                      <Heart className="w-4 h-4 text-white" fill="currentColor" />
                    </div>
                    <div>
                      <p className="font-medium text-gray-800">
                        {t('nav.pharmacies', locale)}
                      </p>
                      <p className="text-sm text-gray-600">
                        {locale === 'ar'
                          ? 'العلامات الخضراء تمثل الصيدليات'
                          : 'Les marqueurs verts représentent les pharmacies'}
                      </p>
                    </div>
                  </div>
                  <div className="flex items-center gap-3">
                    <div className="w-8 h-8 bg-blue-500 rounded-full flex items-center justify-center">
                      <Stethoscope className="w-4 h-4 text-white" />
                    </div>
                    <div>
                      <p className="font-medium text-gray-800">{t('nav.doctors', locale)}</p>
                      <p className="text-sm text-gray-600">
                        {locale === 'ar'
                          ? 'العلامات الزرقاء تمثل الأطباء'
                          : 'Les marqueurs bleus représentent les médecins'}
                      </p>
                    </div>
                  </div>
                </div>

                <div className="mt-6 p-4 bg-primary-50 rounded-lg">
                  <p className="text-sm text-gray-700">
                    {locale === 'ar'
                      ? '💡 انقر على أي علامة على الخريطة للحصول على المزيد من المعلومات والاتجاهات'
                      : '💡 Cliquez sur n\'importe quel marqueur sur la carte pour plus d\'informations et l\'itinéraire'}
                  </p>
                </div>
              </div>
            </div>
          </div>
        </section>
      </main>

      <Footer locale={locale} />
    </div>
  );
}
