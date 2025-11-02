// أنواع البيانات الأساسية للمنصة

export interface Location {
  lat: number;
  lng: number;
  address: string;
  neighborhood: string; // الحي
}

export interface ContactInfo {
  phone: string;
  whatsapp?: string;
  email?: string;
}

export interface WorkingHours {
  day: string;
  openTime: string;
  closeTime: string;
  isClosed: boolean;
}

// الصيدليات
export interface Pharmacy {
  id: string;
  name: string;
  location: Location;
  contact: ContactInfo;
  workingHours: WorkingHours[];
  onDuty: boolean; // مناوبة
  dutySchedule?: {
    startDate: string;
    endDate: string;
  };
  services: string[]; // خدمات إضافية
  imageUrl?: string;
}

// الأطباء
export interface Doctor {
  id: string;
  name: string;
  specialty: string; // التخصص
  location: Location;
  contact: ContactInfo;
  workingHours: WorkingHours[];
  isAvailableNow: boolean;
  languages: string[]; // العربية، الفرنسية، الأمازيغية
  acceptsInsurance: boolean; // يقبل التأمين
  consultationFee?: number;
  imageUrl?: string;
}

// العيادات
export interface Clinic {
  id: string;
  name: string;
  type: string; // نوع العيادة
  location: Location;
  contact: ContactInfo;
  workingHours: WorkingHours[];
  specialties: string[];
  doctors: string[]; // IDs of doctors
  services: string[];
  imageUrl?: string;
}

// المستشفيات
export interface Hospital {
  id: string;
  name: string;
  type: 'public' | 'private';
  location: Location;
  contact: ContactInfo;
  hasEmergency: boolean;
  departments: string[];
  services: string[];
  imageUrl?: string;
}

// المختبرات
export interface Laboratory {
  id: string;
  name: string;
  location: Location;
  contact: ContactInfo;
  workingHours: WorkingHours[];
  services: string[];
  hasHomeService: boolean; // خدمة منزلية
  imageUrl?: string;
}

// مراكز الترويض
export interface PhysiotherapyCenter {
  id: string;
  name: string;
  location: Location;
  contact: ContactInfo;
  workingHours: WorkingHours[];
  services: string[];
  hasHomeService: boolean;
  imageUrl?: string;
}

// مرشحات البحث
export interface SearchFilters {
  query?: string;
  neighborhood?: string;
  specialty?: string;
  date?: string;
  isAvailableNow?: boolean;
  hasEmergency?: boolean;
}

// اللغات المدعومة
export type Locale = 'ar' | 'fr';

export interface Translation {
  ar: string;
  fr: string;
}
