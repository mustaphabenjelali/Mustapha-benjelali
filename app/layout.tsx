import type { Metadata } from 'next';
import './globals.css';

export const metadata: Metadata = {
  title: 'صحّتي في ناظور | Ma Santé à Nador',
  description: 'منصة إلكترونية عصرية ومجانية للوصول إلى المعلومة الصحية في الناظور',
  keywords: 'صحة، ناظور، صيدليات، أطباء، مناوبة، Nador, santé, pharmacies',
};

export default function RootLayout({
  children,
}: {
  children: React.ReactNode;
}) {
  return (
    <html lang="ar" dir="rtl">
      <head>
        <link
          rel="stylesheet"
          href="https://unpkg.com/leaflet@1.9.4/dist/leaflet.css"
          integrity="sha256-p4NxAoJBhIIN+hmNHrzRCf9tD/miZyoHS5obTRR9BMY="
          crossOrigin=""
        />
      </head>
      <body className="antialiased bg-gray-50">
        {children}
      </body>
    </html>
  );
}
