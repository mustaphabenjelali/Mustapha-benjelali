'use client';

import { useEffect, useRef } from 'react';
import L from 'leaflet';
import { Pharmacy, Doctor, Locale } from '@/types';

interface MapComponentProps {
  pharmacies: Pharmacy[];
  doctors: Doctor[];
  locale: Locale;
}

export default function MapComponent({ pharmacies, doctors, locale }: MapComponentProps) {
  const mapRef = useRef<HTMLDivElement>(null);
  const mapInstanceRef = useRef<L.Map | null>(null);

  useEffect(() => {
    if (!mapRef.current || mapInstanceRef.current) return;

    // Initialize map centered on Nador
    const map = L.map(mapRef.current).setView([35.1689, -2.9312], 13);

    // Add OpenStreetMap tiles
    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
      attribution:
        '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors',
    }).addTo(map);

    // Custom icons
    const pharmacyIcon = L.divIcon({
      html: `
        <div style="background-color: #10b981; width: 32px; height: 32px; border-radius: 50%; display: flex; align-items: center; justify-content: center; border: 3px solid white; box-shadow: 0 2px 8px rgba(0,0,0,0.3);">
          <svg xmlns="http://www.w3.org/2000/svg" width="18" height="18" viewBox="0 0 24 24" fill="white" stroke="white" stroke-width="2">
            <path d="M20.84 4.61a5.5 5.5 0 0 0-7.78 0L12 5.67l-1.06-1.06a5.5 5.5 0 0 0-7.78 7.78l1.06 1.06L12 21.23l7.78-7.78 1.06-1.06a5.5 5.5 0 0 0 0-7.78z"></path>
          </svg>
        </div>
      `,
      className: '',
      iconSize: [32, 32],
      iconAnchor: [16, 16],
      popupAnchor: [0, -16],
    });

    const doctorIcon = L.divIcon({
      html: `
        <div style="background-color: #3b82f6; width: 32px; height: 32px; border-radius: 50%; display: flex; align-items: center; justify-content: center; border: 3px solid white; box-shadow: 0 2px 8px rgba(0,0,0,0.3);">
          <svg xmlns="http://www.w3.org/2000/svg" width="18" height="18" viewBox="0 0 24 24" fill="none" stroke="white" stroke-width="2">
            <path d="M4.8 2.3A.3.3 0 1 0 5 2H4a2 2 0 0 0-2 2v5a6 6 0 0 0 6 6v0a6 6 0 0 0 6-6V4a2 2 0 0 0-2-2h-1a.2.2 0 1 0 .3.3"></path>
            <path d="M8 15v1a6 6 0 0 0 6 6v0a6 6 0 0 0 6-6v-4"></path>
            <circle cx="20" cy="10" r="2"></circle>
          </svg>
        </div>
      `,
      className: '',
      iconSize: [32, 32],
      iconAnchor: [16, 16],
      popupAnchor: [0, -16],
    });

    // Add pharmacy markers
    pharmacies.forEach((pharmacy) => {
      const marker = L.marker([pharmacy.location.lat, pharmacy.location.lng], {
        icon: pharmacyIcon,
      }).addTo(map);

      const popupContent = `
        <div style="direction: ${locale === 'ar' ? 'rtl' : 'ltr'}; text-align: ${locale === 'ar' ? 'right' : 'left'}; min-width: 200px;">
          <h3 style="font-weight: bold; margin-bottom: 8px; font-size: 16px;">${pharmacy.name}</h3>
          ${pharmacy.onDuty ? `<span style="background-color: #10b981; color: white; padding: 2px 8px; border-radius: 12px; font-size: 12px; display: inline-block; margin-bottom: 8px;">${locale === 'ar' ? 'مناوبة' : 'De Garde'}</span>` : ''}
          <p style="margin: 4px 0; font-size: 14px;">📍 ${pharmacy.location.address}</p>
          <p style="margin: 4px 0; font-size: 14px;">📞 <a href="tel:${pharmacy.contact.phone}" style="color: #00a88c;">${pharmacy.contact.phone}</a></p>
          ${pharmacy.contact.whatsapp ? `<p style="margin: 4px 0; font-size: 14px;">💬 <a href="https://wa.me/${pharmacy.contact.whatsapp.replace(/\+/g, '')}" target="_blank" style="color: #25D366;">WhatsApp</a></p>` : ''}
          <a href="https://www.google.com/maps/search/?api=1&query=${pharmacy.location.lat},${pharmacy.location.lng}" target="_blank" style="display: inline-block; margin-top: 8px; padding: 6px 12px; background-color: #00a88c; color: white; text-decoration: none; border-radius: 6px; font-size: 12px;">${locale === 'ar' ? 'احصل على الاتجاهات' : 'Obtenir l\'itinéraire'}</a>
        </div>
      `;

      marker.bindPopup(popupContent);
    });

    // Add doctor markers
    doctors.forEach((doctor) => {
      const marker = L.marker([doctor.location.lat, doctor.location.lng], {
        icon: doctorIcon,
      }).addTo(map);

      const popupContent = `
        <div style="direction: ${locale === 'ar' ? 'rtl' : 'ltr'}; text-align: ${locale === 'ar' ? 'right' : 'left'}; min-width: 200px;">
          <h3 style="font-weight: bold; margin-bottom: 8px; font-size: 16px;">${doctor.name}</h3>
          <span style="background-color: #3b82f6; color: white; padding: 2px 8px; border-radius: 12px; font-size: 12px; display: inline-block; margin-bottom: 8px;">${doctor.specialty}</span>
          ${doctor.isAvailableNow ? `<span style="background-color: #10b981; color: white; padding: 2px 8px; border-radius: 12px; font-size: 12px; display: inline-block; margin-bottom: 8px; margin-right: 4px;">${locale === 'ar' ? 'متاح' : 'Disponible'}</span>` : ''}
          <p style="margin: 4px 0; font-size: 14px;">📍 ${doctor.location.address}</p>
          <p style="margin: 4px 0; font-size: 14px;">📞 <a href="tel:${doctor.contact.phone}" style="color: #3b82f6;">${doctor.contact.phone}</a></p>
          ${doctor.consultationFee ? `<p style="margin: 4px 0; font-size: 14px; font-weight: bold; color: #00a88c;">💰 ${doctor.consultationFee} ${locale === 'ar' ? 'درهم' : 'DH'}</p>` : ''}
          <a href="https://www.google.com/maps/search/?api=1&query=${doctor.location.lat},${doctor.location.lng}" target="_blank" style="display: inline-block; margin-top: 8px; padding: 6px 12px; background-color: #3b82f6; color: white; text-decoration: none; border-radius: 6px; font-size: 12px;">${locale === 'ar' ? 'احصل على الاتجاهات' : 'Obtenir l\'itinéraire'}</a>
        </div>
      `;

      marker.bindPopup(popupContent);
    });

    mapInstanceRef.current = map;

    return () => {
      if (mapInstanceRef.current) {
        mapInstanceRef.current.remove();
        mapInstanceRef.current = null;
      }
    };
  }, [pharmacies, doctors, locale]);

  return <div ref={mapRef} className="w-full h-full rounded-lg shadow-lg" />;
}
