# Uçak Rezervasyon Otomasyon Sistemi

Bu proje, C# Windows Forms App ve MySQL veritabanı kullanılarak geliştirilmiş bir uçak bileti rezervasyon otomasyonudur. Kullanıcıların sefer aramasına, koltuk seçmesine ve rezervasyon yapmasına olanak tanırken; admin paneli üzerinden sefer ve kullanıcı yönetimi imkanı sunar.

## 🚀 Özellikler
- **Kullanıcı Sistemi:** Giriş yapma, yeni üyelik oluşturma ve profil güncelleme.
- **Sefer Yönetimi:** Şehirler arası uçuş arama ve listeleme.
- **Koltuk Seçimi:** Dinamik koltuk haritası üzerinden (A1-F8) boş/dolu takibi.
- **Admin Paneli:** Yeni sefer oluşturma, yolcu deneyimlerini görüntüleme ve kullanıcı silme.
- **Singleton Design Pattern:** Veritabanı bağlantısı yönetimi için optimize edilmiş yapı.

## 🛠️ Kurulum ve Çalıştırma

1. **Veritabanı Kurulumu:**
   - XAMPP Control Panel'i açın ve `Apache` ile `MySQL` servislerini başlatın.
   - Tarayıcıdan `localhost/phpmyadmin` adresine gidin.
   - `ucakotomasyondb` adında yeni bir veritabanı oluşturun.
   - Proje klasöründeki `ucakotomasyondb.sql` dosyasını bu veritabanına **İçe Aktar (Import)** yapın.

2. **Projeyi Çalıştırma:**
   - Visual Studio'da `UcakRezervasyonOtomasyon.sln` dosyasını açın.
   - Eğer MySQL kütüphanesi eksikse NuGet üzerinden `MySql.Data` paketini güncelleyin.
   - `F5` tuşuna basarak projeyi başlatın.

## 📝 Notlar
- Veritabanı bağlantı ayarları `Veritabanı.cs` dosyası içerisinden kontrol edilebilir.
- Varsayılan MySQL kullanıcı adı: `root`, şifre: `boş` olarak ayarlanmıştır.
