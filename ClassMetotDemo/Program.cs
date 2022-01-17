//Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id,Ad,Soyad....)
//MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.

ClassMetotDemo.Musteri musteri1 = new ClassMetotDemo.Musteri();
musteri1.AdSoyad = "Mazlum Altan";
musteri1.Yas = 20;
musteri1.Id = 185;

ClassMetotDemo.Musteri musteri2 = new ClassMetotDemo.Musteri();
musteri2.AdSoyad = "Şükrü Arap";
musteri2.Yas = 45;
musteri2.Id = 201;

ClassMetotDemo.Musteri musteri3 = new ClassMetotDemo.Musteri();
musteri3.AdSoyad = "Ateş Aycı";
musteri3.Yas = 27;
musteri3.Id = 312;

ClassMetotDemo.Musteri musteri4 = new ClassMetotDemo.Musteri();
musteri4.AdSoyad = "Ali İsmail Babacan";
musteri4.Yas = 35;
musteri4.Id = 145;

ClassMetotDemo.Musteri[] müsteriler = new ClassMetotDemo.Musteri[] {musteri1, musteri2, musteri4,};

ClassMetotDemo.MusteriManager musteriManager = new ClassMetotDemo.MusteriManager();
musteriManager.Ekleme(musteri4);

Console.WriteLine("-");

ClassMetotDemo.MusteriManager musteriManager2 = new ClassMetotDemo.MusteriManager();
musteriManager2.Silme(musteri2);

Console.WriteLine("-----Müşteri Listesi:------");

ClassMetotDemo.MusteriManager musteriManager3 = new ClassMetotDemo.MusteriManager();
musteriManager3.Listeleme(müsteriler);



