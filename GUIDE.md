# دليل التشغيل السريع | Guide de Démarrage Rapide

## 🚀 كيفية تشغيل المشروع | Comment Lancer le Projet

### الخطوة 1: تثبيت المكتبات | Étape 1: Installation des Dépendances

```bash
npm install
```

### الخطوة 2: تشغيل الخادم | Étape 2: Lancer le Serveur

```bash
npm run dev
```

سيعمل الموقع على: `http://localhost:3000`

### الخطوة 3: فتح المتصفح | Étape 3: Ouvrir le Navigateur

افتح المتصفح وانتقل إلى: `http://localhost:3000`

---

## 📄 الصفحات المتاحة | Pages Disponibles

### 1. الصفحة الرئيسية | Page d'Accueil
**URL**: `/`

المميزات:
- عرض سريع للصيدليات المناوبة
- عرض سريع للأطباء المتاحين
- بحث عام
- بطاقات وصول سريع

### 2. صفحة الصيدليات | Page Pharmacies
**URL**: `/pharmacies`

المميزات:
- قائمة كاملة بالصيدليات
- مرشحات حسب الحي
- تصفية الصيدليات المناوبة فقط
- عرض معلومات الاتصال والموقع
- روابط للاتصال وWhatsApp وخرائط Google

### 3. صفحة الأطباء | Page Médecins
**URL**: `/doctors`

المميزات:
- قائمة كاملة بالأطباء
- مرشحات حسب التخصص
- مرشحات حسب الحي
- تصفية الأطباء المتاحين فقط
- عرض أسعار الاستشارة واللغات المتحدثة

### 4. صفحة الخريطة | Page Carte
**URL**: `/map`

المميزات:
- خريطة تفاعلية تعرض جميع المرافق
- علامات للصيدليات (خضراء) والأطباء (زرقاء)
- إمكانية إخفاء/إظهار كل نوع
- نوافذ منبثقة بمعلومات مفصلة
- روابط للحصول على الاتجاهات

---

## 🎨 التخصيص | Personnalisation

### تغيير الألوان | Modifier les Couleurs

افتح ملف `tailwind.config.js`:

```javascript
colors: {
  primary: {
    500: '#00a88c',  // اللون الرئيسي
    600: '#008670',
    700: '#006554',
  },
}
```

### إضافة بيانات جديدة | Ajouter de Nouvelles Données

#### إضافة صيدلية | Ajouter une Pharmacie

افتح `data/pharmacies.ts`:

```typescript
{
  id: 'ph5',
  name: 'اسم الصيدلية',
  location: {
    lat: 35.1689,
    lng: -2.9312,
    address: 'العنوان الكامل',
    neighborhood: 'اسم الحي',
  },
  contact: {
    phone: '+212536xxxxxx',
    whatsapp: '+212636xxxxxx',
  },
  workingHours: [
    { day: 'الإثنين', openTime: '08:00', closeTime: '20:00', isClosed: false },
    // ... باقي الأيام
  ],
  onDuty: false,  // true إذا كانت مناوبة
  services: ['أدوية', 'مستلزمات طبية'],
}
```

#### إضافة طبيب | Ajouter un Médecin

افتح `data/doctors.ts`:

```typescript
{
  id: 'doc6',
  name: 'د. الاسم الكامل',
  specialty: 'التخصص',
  location: {
    lat: 35.1689,
    lng: -2.9312,
    address: 'العنوان الكامل',
    neighborhood: 'اسم الحي',
  },
  contact: {
    phone: '+212536xxxxxx',
    whatsapp: '+212636xxxxxx',
  },
  workingHours: [...],
  isAvailableNow: true,
  languages: ['العربية', 'الفرنسية'],
  acceptsInsurance: true,
  consultationFee: 200,
}
```

---

## 🌐 النشر | Déploiement

### Vercel (مجاني | Gratuit)

1. أنشئ حساب على [Vercel](https://vercel.com)
2. اربط مستودع GitHub الخاص بك
3. اضغط على "Deploy"
4. سيتم نشر الموقع تلقائياً!

أو استخدم CLI:

```bash
npm i -g vercel
vercel
```

### Netlify

1. أنشئ حساب على [Netlify](https://netlify.com)
2. اربط مستودع GitHub
3. أضف الإعدادات:
   - Build command: `npm run build`
   - Publish directory: `.next`
4. اضغط على "Deploy"

---

## 🔧 التطوير المستقبلي | Développement Futur

### مميزات مقترحة:

1. **قاعدة بيانات حقيقية**
   - استخدم PostgreSQL أو MongoDB
   - أنشئ API في `app/api/`

2. **لوحة تحكم للإدارة**
   - إضافة/تعديل/حذف البيانات
   - جدولة المناوبات تلقائياً

3. **حجز المواعيد**
   - نظام حجز أون لاين
   - تذكيرات عبر WhatsApp

4. **التقييمات والمراجعات**
   - تقييم الصيدليات والأطباء
   - تعليقات المستخدمين

5. **الإشعارات**
   - تنبيهات المناوبات
   - إشعارات push

6. **دعم الأمازيغية**
   - إضافة اللغة الأمازيغية
   - واجهة متعددة اللغات كاملة

7. **تطبيق موبايل**
   - React Native
   - Flutter

---

## ❓ الأسئلة الشائعة | FAQ

### كيف أضيف مدينة أخرى؟

1. أنشئ ملفات بيانات جديدة في مجلد `data/`
2. عدّل الإحداثيات في `MapComponent.tsx`
3. أضف مرشحات للمدن

### كيف أغير اللغة الافتراضية؟

افتح `app/page.tsx` وغيّر:

```typescript
const [locale, setLocale] = useState<Locale>('fr'); // من 'ar' إلى 'fr'
```

### كيف أضيف Google Analytics؟

أنشئ ملف `app/layout.tsx` وأضف:

```typescript
<Script src={`https://www.googletagmanager.com/gtag/js?id=GA_ID`} />
```

### كيف أحمي لوحة الإدارة؟

استخدم:
- NextAuth.js للمصادقة
- Middleware للحماية
- أدوار المستخدمين (Admin, Editor, Viewer)

---

## 📞 الدعم | Support

إذا واجهت أي مشكلة:

1. راجع الأخطاء في Console
2. تحقق من تثبيت المكتبات: `npm install`
3. احذف `node_modules` و `.next` ثم أعد التثبيت
4. افتح issue على GitHub

---

## 🎉 نصائح إضافية | Conseils Supplémentaires

### الأداء | Performance

- استخدم `next/image` للصور
- فعّل Caching
- استخدم CDN للملفات الثابتة

### SEO

- أضف meta tags في `app/layout.tsx`
- استخدم sitemap.xml
- أضف structured data

### الأمان | Sécurité

- لا تضع API keys في الكود
- استخدم متغيرات البيئة (.env)
- فعّل HTTPS
- نظف المدخلات من المستخدمين

---

**بالتوفيق! | Bonne Chance!** 🎯
