import { Pharmacy } from '@/types';

export const pharmacies: Pharmacy[] = [
  {
    id: 'ph1',
    name: 'صيدلية الأمل',
    location: {
      lat: 35.1689,
      lng: -2.9312,
      address: 'شارع محمد الخامس، الناظور',
      neighborhood: 'وسط المدينة',
    },
    contact: {
      phone: '+212536123456',
      whatsapp: '+212636123456',
    },
    workingHours: [
      { day: 'الإثنين', openTime: '08:00', closeTime: '22:00', isClosed: false },
      { day: 'الثلاثاء', openTime: '08:00', closeTime: '22:00', isClosed: false },
      { day: 'الأربعاء', openTime: '08:00', closeTime: '22:00', isClosed: false },
      { day: 'الخميس', openTime: '08:00', closeTime: '22:00', isClosed: false },
      { day: 'الجمعة', openTime: '08:00', closeTime: '22:00', isClosed: false },
      { day: 'السبت', openTime: '08:00', closeTime: '22:00', isClosed: false },
      { day: 'الأحد', openTime: '09:00', closeTime: '13:00', isClosed: false },
    ],
    onDuty: true,
    dutySchedule: {
      startDate: '2025-11-01',
      endDate: '2025-11-07',
    },
    services: ['أدوية', 'مستلزمات طبية', 'قياس الضغط', 'قياس السكر'],
  },
  {
    id: 'ph2',
    name: 'صيدلية النجاح',
    location: {
      lat: 35.1723,
      lng: -2.9280,
      address: 'حي الزهور، الناظور',
      neighborhood: 'حي الزهور',
    },
    contact: {
      phone: '+212536234567',
      whatsapp: '+212636234567',
    },
    workingHours: [
      { day: 'الإثنين', openTime: '08:30', closeTime: '21:00', isClosed: false },
      { day: 'الثلاثاء', openTime: '08:30', closeTime: '21:00', isClosed: false },
      { day: 'الأربعاء', openTime: '08:30', closeTime: '21:00', isClosed: false },
      { day: 'الخميس', openTime: '08:30', closeTime: '21:00', isClosed: false },
      { day: 'الجمعة', openTime: '08:30', closeTime: '21:00', isClosed: false },
      { day: 'السبت', openTime: '08:30', closeTime: '21:00', isClosed: false },
      { day: 'الأحد', openTime: '09:00', closeTime: '13:00', isClosed: false },
    ],
    onDuty: false,
    services: ['أدوية', 'مستحضرات تجميل', 'منتجات الأطفال'],
  },
  {
    id: 'ph3',
    name: 'صيدلية السلام',
    location: {
      lat: 35.1650,
      lng: -2.9350,
      address: 'شارع الحسن الثاني، الناظور',
      neighborhood: 'حي السلام',
    },
    contact: {
      phone: '+212536345678',
      whatsapp: '+212636345678',
    },
    workingHours: [
      { day: 'الإثنين', openTime: '08:00', closeTime: '22:30', isClosed: false },
      { day: 'الثلاثاء', openTime: '08:00', closeTime: '22:30', isClosed: false },
      { day: 'الأربعاء', openTime: '08:00', closeTime: '22:30', isClosed: false },
      { day: 'الخميس', openTime: '08:00', closeTime: '22:30', isClosed: false },
      { day: 'الجمعة', openTime: '08:00', closeTime: '22:30', isClosed: false },
      { day: 'السبت', openTime: '08:00', closeTime: '22:30', isClosed: false },
      { day: 'الأحد', openTime: '09:00', closeTime: '14:00', isClosed: false },
    ],
    onDuty: false,
    services: ['أدوية', 'مستلزمات طبية', 'خدمة التوصيل'],
  },
  {
    id: 'ph4',
    name: 'Pharmacie Al-Widad',
    location: {
      lat: 35.1700,
      lng: -2.9400,
      address: 'Avenue du Prince Héritier, Nador',
      neighborhood: 'Centre Ville',
    },
    contact: {
      phone: '+212536456789',
      whatsapp: '+212636456789',
    },
    workingHours: [
      { day: 'الإثنين', openTime: '08:00', closeTime: '20:00', isClosed: false },
      { day: 'الثلاثاء', openTime: '08:00', closeTime: '20:00', isClosed: false },
      { day: 'الأربعاء', openTime: '08:00', closeTime: '20:00', isClosed: false },
      { day: 'الخميس', openTime: '08:00', closeTime: '20:00', isClosed: false },
      { day: 'الجمعة', openTime: '08:00', closeTime: '20:00', isClosed: false },
      { day: 'السبت', openTime: '08:00', closeTime: '20:00', isClosed: false },
      { day: 'الأحد', openTime: '00:00', closeTime: '00:00', isClosed: true },
    ],
    onDuty: true,
    dutySchedule: {
      startDate: '2025-11-08',
      endDate: '2025-11-14',
    },
    services: ['Médicaments', 'Parapharmacie', 'Orthopédie'],
  },
];
