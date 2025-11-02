'use client';

import { useState } from 'react';
import Link from 'next/link';
import { Menu, X, Heart, Phone, MapPin, Globe } from 'lucide-react';
import { Locale } from '@/types';
import { t } from '@/lib/translations';

interface HeaderProps {
  locale: Locale;
  onLocaleChange: (locale: Locale) => void;
}

export default function Header({ locale, onLocaleChange }: HeaderProps) {
  const [isMenuOpen, setIsMenuOpen] = useState(false);

  const navItems = [
    { href: '/', label: t('nav.home', locale), icon: Heart },
    { href: '/pharmacies', label: t('nav.pharmacies', locale), icon: Heart },
    { href: '/doctors', label: t('nav.doctors', locale), icon: Heart },
    { href: '/map', label: t('nav.map', locale), icon: MapPin },
  ];

  return (
    <header className="bg-white shadow-md sticky top-0 z-50">
      <div className="container mx-auto px-4">
        <div className="flex items-center justify-between h-16">
          {/* Logo */}
          <Link href="/" className="flex items-center gap-2">
            <div className="w-10 h-10 bg-primary-500 rounded-lg flex items-center justify-center">
              <Heart className="w-6 h-6 text-white" fill="currentColor" />
            </div>
            <div className="flex flex-col">
              <span className="font-bold text-lg text-primary-600">
                {locale === 'ar' ? 'صحّتي في ناظور' : 'Ma Santé à Nador'}
              </span>
            </div>
          </Link>

          {/* Desktop Navigation */}
          <nav className="hidden md:flex items-center gap-6">
            {navItems.map((item) => (
              <Link
                key={item.href}
                href={item.href}
                className="text-gray-700 hover:text-primary-500 transition-colors font-medium"
              >
                {item.label}
              </Link>
            ))}
          </nav>

          {/* Language Toggle & Emergency */}
          <div className="flex items-center gap-3">
            <button
              onClick={() => onLocaleChange(locale === 'ar' ? 'fr' : 'ar')}
              className="hidden sm:flex items-center gap-2 px-3 py-2 rounded-lg bg-gray-100 hover:bg-gray-200 transition-colors"
              aria-label="تغيير اللغة"
            >
              <Globe className="w-4 h-4" />
              <span className="text-sm font-medium">
                {locale === 'ar' ? 'FR' : 'عربي'}
              </span>
            </button>

            <a
              href="tel:141"
              className="hidden sm:flex items-center gap-2 px-4 py-2 bg-red-500 text-white rounded-lg hover:bg-red-600 transition-colors"
            >
              <Phone className="w-4 h-4" />
              <span className="font-medium">141</span>
            </a>

            {/* Mobile Menu Button */}
            <button
              onClick={() => setIsMenuOpen(!isMenuOpen)}
              className="md:hidden p-2"
              aria-label="القائمة"
            >
              {isMenuOpen ? (
                <X className="w-6 h-6" />
              ) : (
                <Menu className="w-6 h-6" />
              )}
            </button>
          </div>
        </div>

        {/* Mobile Menu */}
        {isMenuOpen && (
          <div className="md:hidden py-4 border-t animate-fade-in">
            <nav className="flex flex-col gap-3">
              {navItems.map((item) => (
                <Link
                  key={item.href}
                  href={item.href}
                  className="px-4 py-3 text-gray-700 hover:bg-primary-50 hover:text-primary-600 rounded-lg transition-colors"
                  onClick={() => setIsMenuOpen(false)}
                >
                  {item.label}
                </Link>
              ))}
              <button
                onClick={() => {
                  onLocaleChange(locale === 'ar' ? 'fr' : 'ar');
                  setIsMenuOpen(false);
                }}
                className="flex items-center gap-2 px-4 py-3 text-gray-700 hover:bg-gray-50 rounded-lg transition-colors"
              >
                <Globe className="w-4 h-4" />
                <span>{locale === 'ar' ? 'Français' : 'العربية'}</span>
              </button>
              <a
                href="tel:141"
                className="flex items-center gap-2 px-4 py-3 bg-red-500 text-white rounded-lg hover:bg-red-600 transition-colors"
              >
                <Phone className="w-4 h-4" />
                <span className="font-medium">
                  {locale === 'ar' ? 'طوارئ: 141' : 'Urgences: 141'}
                </span>
              </a>
            </nav>
          </div>
        )}
      </div>
    </header>
  );
}
