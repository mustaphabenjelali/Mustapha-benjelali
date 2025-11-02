# صحّتي في ناظور | Ma Santé à Nador

![Version](https://img.shields.io/badge/version-1.0.0-blue.svg)
![Next.js](https://img.shields.io/badge/Next.js-14.2-black.svg)
![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)
![License](https://img.shields.io/badge/license-MIT-green.svg)

## 📋 نظرة عامة | Aperçu

**صحّتي في ناظور** هي منصة إلكترونية عصرية ومجانية تهدف إلى تمكين سكان مدينة الناظور من الوصول الفوري والدقيق إلى المعلومة الصحية.

**Ma Santé à Nador** est une plateforme numérique moderne et gratuite visant à permettre aux habitants de Nador d'accéder instantanément et précisément aux informations de santé.

## ✨ المميزات | Fonctionnalités

- 🏥 **الصيدليات المناوبة** - عرض الصيدليات المناوبة حسب اليوم والساعة والموقع
- 👨‍⚕️ **الأطباء المتاحون** - قائمة الأطباء المتاحين مع التخصص والعنوان وساعات العمل
- 🗺️ **خريطة تفاعلية** - خريطة تفاعلية لجميع المرافق الصحية بالمدينة
- 🔍 **بحث ومرشحات متقدمة** - بحث سريع مع مرشحات حسب الحي والتخصص والتاريخ
- 🌐 **متعدد اللغات** - دعم اللغة العربية والفرنسية
- 📱 **متجاوب** - تصميم متجاوب يعمل على الهواتف والحواسيب
- 🎨 **واجهة عصرية** - تصميم حديث وسهل الاستخدام

## 🚀 التقنيات المستخدمة | Technologies

- **Next.js 14** - React framework
- **TypeScript** - Type safety
- **Tailwind CSS** - Styling
- **Leaflet** - Interactive maps
- **Lucide React** - Icons
- **Cairo Font** - Arabic typography

## 📦 التثبيت | Installation

### المتطلبات | Prérequis
- Node.js 18+
- npm أو yarn

### الخطوات | Étapes

```bash
# 1. تثبيت المكتبات | Installer les dépendances
npm install

# 2. تشغيل الخادم المحلي | Lancer le serveur de développement
npm run dev

# 3. فتح المتصفح | Ouvrir le navigateur
# http://localhost:3000
```

## 📁 هيكل المشروع | Structure du Projet

```
sahti-nador/
├── app/                    # صفحات التطبيق | Pages
│   ├── page.tsx           # الصفحة الرئيسية | Page d'accueil
│   ├── pharmacies/        # صفحة الصيدليات | Page pharmacies
│   ├── doctors/           # صفحة الأطباء | Page médecins
│   └── map/               # صفحة الخريطة | Page carte
├── components/            # المكونات | Composants
│   ├── Header.tsx         # الترويسة | En-tête
│   ├── Footer.tsx         # التذييل | Pied de page
│   └── MapComponent.tsx   # الخريطة | Carte
├── data/                  # البيانات | Données
│   ├── pharmacies.ts      # بيانات الصيدليات | Données pharmacies
│   └── doctors.ts         # بيانات الأطباء | Données médecins
├── lib/                   # المكتبات | Bibliothèques
│   └── translations.ts    # الترجمات | Traductions
└── types/                 # الأنواع | Types
    └── index.ts           # أنواع TypeScript
```

## 🎯 الاستخدام | Utilisation

### إضافة صيدلية جديدة | Ajouter une Pharmacie

افتح ملف `data/pharmacies.ts` وأضف:

```typescript
{
  id: 'ph5',
  name: 'صيدلية الجديدة',
  location: {
    lat: 35.1689,
    lng: -2.9312,
    address: 'شارع محمد الخامس',
    neighborhood: 'وسط المدينة',
  },
  contact: {
    phone: '+212536123456',
    whatsapp: '+212636123456',
  },
  workingHours: [...],
  onDuty: true,
  services: ['أدوية', 'مستلزمات طبية'],
}
```

## 🌐 النشر | Déploiement

### Vercel (موصى به | Recommandé)

```bash
# تثبيت Vercel CLI
npm i -g vercel

# نشر المشروع
vercel
```

## 📧 الاتصال | Contact

- **Email**: contact@sahtinador.ma
- **Website**: https://sahtinador.ma
- **Emergency**: 141

---

**صُنع بـ ❤️ في الناظور | Fait avec ❤️ à Nador**

© 2025 صحّتي في ناظور. جميع الحقوق محفوظة.
