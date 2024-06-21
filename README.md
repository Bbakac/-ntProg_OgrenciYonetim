OgrenciYonetim dosyası içine projeyi kurun.

dotnet build

dotnet run

ardından local host'a gidin.
örnek localhost: http://localhost:5112



projeye dair:
vscode için:
Görselini eklediğim model örneğini Ogrenciler ismini verdiğiniz class dosyasında oluşturunuz. 5 adet öğrenci örneklemesi yapınız.
-Listeleme
-Yeni Kayıt
-Detay görüntüleme
-Güncelleme
-Silme
işlemlerini sorunsuz bir şekilde yapmasını sağlayınız.

modelörnegi.jpg içindeki görsel içeriği:
OgrenciNo	
Ad	
Soyad	
Sınıf	
Ders Tanımı	(Mat-1, Fiz-2 gibi)
Kredi	
SınavTarihi	
Vize Notu	
Final Notu	
Ortalama	
Harf Karşılığı	(AA, BA gibi)
Geçme Durumu	Mantıksal veri tipiyle ilişkili olacak
Aşağıdaki tabloya göre projeyi yap:
OgrenciNo	Ad	Soyad	Sınıf	Ders Tanımı	Kredi	Sınav Tarihi	Vize Notu	Final Notu	Ortalama	Harf Karşılığı	Geçme Durumu
1	Ali	Yılmaz	3	Matematik (Mat-1)	3	10.06.2023	85	90	87	AA	True
2	Ayşe	Demir	2	Fizik (Fiz-2)	4	21.05.2023	78	82	80	BB	True
3	Mehmet	Çelik	1	Kimya (Kim-1)	2	15.04.2023	88	79	82	BA	True
4	Fatma	Kara	4	Biyoloji (Biy-1)	3	05.06.2023	92	85	88	AA	True
5	Can	Öztürk	3	Edebiyat (Ede-1)	2	30.03.2023	55	65	61	DD	True

proje oluşturma(ASP.NET Core MVC ):
dotnet new mvc -n OgrenciYonetim
cd OgrenciYonetim
code .
