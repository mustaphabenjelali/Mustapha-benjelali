'use client';

import { Heart, Mail, Phone, MapPin } from 'lucide-react';
import { Locale } from '@/types';
import { t } from '@/lib/translations';

interface FooterProps {
  locale: Locale;
}

export default function Footer({ locale }: FooterProps) {
  return (
    <footer className="bg-gray-900 text-gray-300 mt-16">
      <div className="container mx-auto px-4 py-12">
        <div className="grid grid-cols-1 md:grid-cols-3 gap-8">
          {/* About */}
          <div>
            <div className="flex items-center gap-2 mb-4">
              <div className="w-10 h-10 bg-primary-500 rounded-lg flex items-center justify-center">
                <Heart className="w-6 h-6 text-white" fill="currentColor" />
              </div>
              <span className="font-bold text-lg text-white">
                {locale === 'ar' ? 'صحّتي في ناظور' : 'Ma Santé à Nador'}
              </span>
            </div>
            <p className="text-sm leading-relaxed">
              {t('siteDescription', locale)}
            </p>
          </div>

          {/* Quick Links */}
          <div>
            <h3 className="font-bold text-white mb-4">
              {locale === 'ar' ? 'روابط سريعة' : 'Liens Rapides'}
            </h3>
            <ul className="space-y-2 text-sm">
              <li>
                <a href="/" className="hover:text-primary-400 transition-colors">
                  {t('nav.home', locale)}
                </a>
              </li>
              <li>
                <a href="/pharmacies" className="hover:text-primary-400 transition-colors">
                  {t('nav.pharmacies', locale)}
                </a>
              </li>
              <li>
                <a href="/doctors" className="hover:text-primary-400 transition-colors">
                  {t('nav.doctors', locale)}
                </a>
              </li>
              <li>
                <a href="/map" className="hover:text-primary-400 transition-colors">
                  {t('nav.map', locale)}
                </a>
              </li>
            </ul>
          </div>

          {/* Contact */}
          <div>
            <h3 className="font-bold text-white mb-4">
              {t('footer.contact', locale)}
            </h3>
            <ul className="space-y-3 text-sm">
              <li className="flex items-center gap-2">
                <MapPin className="w-4 h-4 text-primary-400" />
                <span>{locale === 'ar' ? 'الناظور، المغرب' : 'Nador, Maroc'}</span>
              </li>
              <li className="flex items-center gap-2">
                <Phone className="w-4 h-4 text-primary-400" />
                <a href="tel:141" className="hover:text-primary-400 transition-colors">
                  {locale === 'ar' ? 'طوارئ: 141' : 'Urgences: 141'}
                </a>
              </li>
              <li className="flex items-center gap-2">
                <Mail className="w-4 h-4 text-primary-400" />
                <a href="mailto:contact@sahtinador.ma" className="hover:text-primary-400 transition-colors">
                  contact@sahtinador.ma
                </a>
              </li>
            </ul>
          </div>
        </div>

        <div className="border-t border-gray-800 mt-8 pt-8 text-center text-sm">
          <p>{t('footer.copyright', locale)}</p>
          <p className="mt-2 text-gray-500">
            {locale === 'ar'
              ? 'مبادرة مواطنية ذكية لخدمة المجتمع'
              : 'Initiative citoyenne intelligente au service de la communauté'}
          </p>
        </div>
      </div>
    </footer>
  );
}
