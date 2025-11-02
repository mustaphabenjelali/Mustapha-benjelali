import { Locale } from '@/types';

export const translations = {
  // العنوان والشعار
  siteTitle: {
    ar: 'صحّتي في ناظور',
    fr: 'Ma Santé à Nador',
  },
  siteDescription: {
    ar: 'منصة إلكترونية عصرية ومجانية للوصول إلى المعلومة الصحية في الناظور',
    fr: 'Plateforme numérique moderne et gratuite pour accéder aux informations de santé à Nador',
  },

  // القائمة الرئيسية
  nav: {
    home: { ar: 'الرئيسية', fr: 'Accueil' },
    pharmacies: { ar: 'الصيدليات المناوبة', fr: 'Pharmacies de Garde' },
    doctors: { ar: 'الأطباء المتاحون', fr: 'Médecins Disponibles' },
    clinics: { ar: 'العيادات', fr: 'Cliniques' },
    hospitals: { ar: 'المستشفيات', fr: 'Hôpitaux' },
    laboratories: { ar: 'المختبرات', fr: 'Laboratoires' },
    physiotherapy: { ar: 'مراكز الترويض', fr: 'Centres de Kinésithérapie' },
    map: { ar: 'الخريطة', fr: 'Carte' },
  },

  // الصفحة الرئيسية
  home: {
    hero: {
      title: {
        ar: 'صحتك في متناول يدك',
        fr: 'Votre santé à portée de main',
      },
      subtitle: {
        ar: 'اعثر على أقرب صيدلية مناوبة، طبيب متاح، أو مرفق صحي في الناظور',
        fr: 'Trouvez la pharmacie de garde la plus proche, un médecin disponible ou un établissement de santé à Nador',
      },
      searchPlaceholder: {
        ar: 'ابحث عن صيدلية، طبيب، أو تخصص...',
        fr: 'Rechercher une pharmacie, un médecin ou une spécialité...',
      },
    },
    quickAccess: {
      title: { ar: 'الوصول السريع', fr: 'Accès Rapide' },
      onDutyPharmacies: {
        ar: 'الصيدليات المناوبة الآن',
        fr: 'Pharmacies de Garde Maintenant',
      },
      availableDoctors: {
        ar: 'الأطباء المتاحون الآن',
        fr: 'Médecins Disponibles Maintenant',
      },
      emergencyServices: {
        ar: 'خدمات الطوارئ',
        fr: 'Services d\'Urgence',
      },
      viewMap: {
        ar: 'عرض الخريطة',
        fr: 'Voir la Carte',
      },
    },
  },

  // الصيدليات
  pharmacies: {
    title: { ar: 'الصيدليات المناوبة', fr: 'Pharmacies de Garde' },
    onDutyNow: { ar: 'مناوبة الآن', fr: 'De Garde Maintenant' },
    openNow: { ar: 'مفتوحة الآن', fr: 'Ouvert Maintenant' },
    closed: { ar: 'مغلقة', fr: 'Fermé' },
    phone: { ar: 'الهاتف', fr: 'Téléphone' },
    address: { ar: 'العنوان', fr: 'Adresse' },
    neighborhood: { ar: 'الحي', fr: 'Quartier' },
    workingHours: { ar: 'ساعات العمل', fr: 'Horaires d\'Ouverture' },
    services: { ar: 'الخدمات', fr: 'Services' },
    dutyPeriod: { ar: 'فترة المناوبة', fr: 'Période de Garde' },
    getDirections: { ar: 'احصل على الاتجاهات', fr: 'Obtenir l\'itinéraire' },
  },

  // الأطباء
  doctors: {
    title: { ar: 'الأطباء المتاحون', fr: 'Médecins Disponibles' },
    availableNow: { ar: 'متاح الآن', fr: 'Disponible Maintenant' },
    notAvailable: { ar: 'غير متاح', fr: 'Non Disponible' },
    specialty: { ar: 'التخصص', fr: 'Spécialité' },
    languages: { ar: 'اللغات', fr: 'Langues' },
    consultationFee: { ar: 'أجرة الاستشارة', fr: 'Tarif de Consultation' },
    acceptsInsurance: { ar: 'يقبل التأمين', fr: 'Accepte les Assurances' },
    bookAppointment: { ar: 'حجز موعد', fr: 'Prendre Rendez-vous' },
  },

  // البحث والمرشحات
  search: {
    search: { ar: 'بحث', fr: 'Rechercher' },
    filters: { ar: 'المرشحات', fr: 'Filtres' },
    allNeighborhoods: { ar: 'كل الأحياء', fr: 'Tous les Quartiers' },
    allSpecialties: { ar: 'كل التخصصات', fr: 'Toutes les Spécialités' },
    availableOnly: { ar: 'المتاحون فقط', fr: 'Disponibles Uniquement' },
    onDutyOnly: { ar: 'المناوبة فقط', fr: 'De Garde Uniquement' },
    clear: { ar: 'مسح', fr: 'Effacer' },
    noResults: { ar: 'لا توجد نتائج', fr: 'Aucun Résultat' },
    resultsFound: { ar: 'نتيجة', fr: 'Résultat(s)' },
  },

  // الأيام
  days: {
    monday: { ar: 'الإثنين', fr: 'Lundi' },
    tuesday: { ar: 'الثلاثاء', fr: 'Mardi' },
    wednesday: { ar: 'الأربعاء', fr: 'Mercredi' },
    thursday: { ar: 'الخميس', fr: 'Jeudi' },
    friday: { ar: 'الجمعة', fr: 'Vendredi' },
    saturday: { ar: 'السبت', fr: 'Samedi' },
    sunday: { ar: 'الأحد', fr: 'Dimanche' },
  },

  // الأزرار والإجراءات
  actions: {
    call: { ar: 'اتصل', fr: 'Appeler' },
    whatsapp: { ar: 'واتساب', fr: 'WhatsApp' },
    email: { ar: 'بريد إلكتروني', fr: 'Email' },
    viewDetails: { ar: 'عرض التفاصيل', fr: 'Voir les Détails' },
    close: { ar: 'إغلاق', fr: 'Fermer' },
    back: { ar: 'رجوع', fr: 'Retour' },
  },

  // الأقسام
  footer: {
    about: { ar: 'حول المنصة', fr: 'À Propos' },
    contact: { ar: 'اتصل بنا', fr: 'Nous Contacter' },
    privacy: { ar: 'سياسة الخصوصية', fr: 'Politique de Confidentialité' },
    terms: { ar: 'شروط الاستخدام', fr: 'Conditions d\'Utilisation' },
    copyright: {
      ar: '© 2025 صحّتي في ناظور. جميع الحقوق محفوظة.',
      fr: '© 2025 Ma Santé à Nador. Tous droits réservés.',
    },
  },
};

export function t(key: string, locale: Locale): string {
  const keys = key.split('.');
  let value: any = translations;

  for (const k of keys) {
    value = value?.[k];
  }

  if (typeof value === 'object' && value !== null) {
    return value[locale] || value.ar || '';
  }

  return value || key;
}
