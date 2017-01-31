-- M��teri Kategori tablosu

CREATE TABLE Musteri_kategori
(
	Kategori_id int primary key identity(1,1) not null,
	Kategori_adi varchar(150)
)

-- M��teriler tablosu

CREATE TABLE Musteriler
(
	Musteri_id int primary key identity(1,1) not null,
	Musteri_adi varchar(50),
	Musteri_soyadi varchar(50),
	Musteri_adres varchar(350),
	Musteri_telefon char(11),
	Musteri_kayitTarihi datetime,
	Musteri_kategori int constraint FK_MusteriKategori foreign key references Musteri_kategori(Kategori_id),
	Musteri_bakiye float default 0.00
)

-- �r�n kategori tablosu

CREATE TABLE Urun_kategori
(
	Kategori_id int primary key not null identity(1,1),
	Kategori_adi varchar(100)
)

-- �r�nler tablosu

CREATE TABLE Urunler
(
	Urun_id int primary key identity(1,1) not null,
	Urun_barkodNo bigint default null,
	Urun_adi varchar(150),
	Urun_fiyat float default 0.00,
	Urun_alisFiyat float default 0.00,
	Urun_kategori int constraint FK_UrunKategori foreign key references Urun_kategori(Kategori_id),
	Urun_eklenmeTarih datetime,
)

-- Sat�� tablosu

CREATE TABLE Satis
(
	Satis_id int primary key identity(1,1) not null,
	Satis_urun int constraint FK_SatisUrun foreign key references Urunler(Urun_id),
	Satis_musteri int constraint FK_SatisMusteri foreign key references Musteriler(Musteri_id),
	Satis_tarih datetime,
	Satis_not varchar(500)
)

-- Teknik taip tablosu

CREATE TABLE Teknik_Takip
(
	Takip_id int primary key identity(1,1) not null,
	Takip_no varchar(50),
	Takip_musteri int constraint FK_TakipMusteri foreign key references Musteriler(Musteri_id),
	Takip_marka varchar(150), -- Makina bilgisi
	Takip_model varchar(150),
	Takip_imei char(15),
	Takip_serino varchar(100),
	Takip_kisibilgi varchar(100), -- M��teri de�ilse
	Takip_kisiTel varchar(100),
	Takip_girisTarih datetime,
	Takip_kapanisTarih datetime,
	Takip_durum tinyint
)

-- Takip G�ncelleme

CREATE TABLE TeknikTakipIslemler
(
	Tk_id int primary key identity(1,1) not null,
	Takip_id int constraint FK_TkTakip foreign key references TeknikTakip(Takip_id),
	Takip_bilgi text
)

-- Rapor tablosu

CREATE TABLE Rapor
(
	rapor_id int primary key identity(1,1) not null,
	rapor_satisId int,
	rapor_satisKt int,
	rapor_sayac int,
	rapor_tarih datetime
)

-- Manuel sat�� tablosu

CREATE TABLE ManuelSatis
(
	satis_id int primary key identity(1,1) not null,
	satis_urunadi varchar(100),
	satis_musteri int,
	satis_alisFiyat float default 0.00,
	satis_fiyat float default 0.00,
	satis_tarih datetime
	satis_not varchar(500)
)