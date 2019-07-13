--Sorgu yapýlacak veritabanýný seç
use HSO_OGLE

-- Tablodaki tüm kayýtlarý listele
SELECT * FROM Ogrenci

--Tablodaki tüm kayýtlarýn Ad,Soyad bilgisini getir.
SELECT Ad,Soyad FROM Ogrenci

--Tabloda ismi Barýþ olanlarýn numarasýný getir.
SELECT Numara FROM Ogrenci WHERE Ad='Barýþ'




--Ýsmi Barýþ Soyadý SEVÝNÇ olan kayýtlarý listele
SELECT * FROM Ogrenci WHERE Ad='Barýþ' AND Soyad='SEVÝNÇ'

-- Adý Bedirhan veya Halil olanlarý listeler.
SELECT * FROM Ogrenci WHERE Ad='Halil' OR Ad='Bedirhan';

-- Barýþ isminde kaç kayýt var?
SELECT COUNT(Ad) FROM Ogrenci WHERE Ad='Barýþ'

-- Numarasý 300 den küçük olanlarý getir.
SELECT * FROM Ogrenci WHERE Numara<300;

-- Numarasý 200 ile 400 arasýnda olanlarý getir.
SELECT * FROM Ogrenci WHERE Numara BETWEEN 200 AND 400;

-- Ýsmi Bedirhan, Halil, Mehmet'den biri olanlarý getir.
SELECT * FROM Ogrenci WHERE Ad IN('Bedirhan','Halil','Mehmet');

-- Adý Halil olmayanlarý getir.
SELECT * FROM Ogrenci WHERE NOT Ad='Halil';


-- Numarasý 444 olmayan ve Adý Barýþ olanlarý getir.
SELECT * FROM Ogrenci WHERE Numara<>444 AND Ad='Barýþ'