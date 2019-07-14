--Ders2
-- ORDER BY: Sýralama. Varsayýlan olarak artan yani ASC çalýþýr.
SELECT * FROM Ogrenci ORDER BY Sinif

SELECT * FROM Ogrenci ORDER BY Sinif ASC
-- Numaraya göre azalan sýralama: DESC
SELECT * FROM Ogrenci ORDER BY Sinif DESC
--Harfe göre sýralama
SELECT * FROM Ogrenci ORDER BY Soyad

-- Harfe göre tersten sýralama
SELECT * FROM Ogrenci ORDER BY Soyad DESC



--Ýlk 3 kaydý getir. ID'sýralamasýna göre
SELECT TOP 3 * FROM Araba ORDER BY ID ASC

--son 3 kaydý getir. ID'sýralamasýna göre
SELECT TOP 3 * FROM Araba ORDER BY ID DESC

SELECT MAX(ID) AS EnBüyük FROM Araba

SELECT MIN(ID) AS EnKüçük FROM Araba

SELECT AVG(ID) AS Ortadaki FROM Araba

SELECT COUNT(ID) AS KayýtSayýsý FROM Araba

SELECT SUM(ID) AS IDtoplamý FROM Araba

--INSERT INTO: Tabloya kayýt ekleme

INSERT INTO Ogrenci (Numara,Ad,Soyad,Adres,Sinif)
VALUES              (666,'Ayþe','KÝRAZ','Kayseri',101);

INSERT INTO Ogrenci VALUES(777,'Salih','MAHMUT','Cihangir',303);

INSERT INTO Ogrenci VALUES(888,'Selin','HABER','',202);

--Adresi NULL olanlarý getir.
SELECT * FROM Ogrenci WHERE Adres IS NULL;

-- ADdresi NULL olmayanlarý getir.
SELECT * FROM Ogrenci WHERE Adres IS NOT NULL;

--UPDATE: Varolan veriyi güncelleme
-- Adresi boþluk olanlarý NULL olarak deðiþtir.
UPDATE Ogrenci SET Adres=NULL WHERE Adres='';
,
UPDATE Ogrenci SET Adres='TANIMSIZ' WHERE Adres IS NULL;

UPDATE Ogrenci SET Numara=45, Ad='Sevgi', Soyad='KÖMÜR',Adres='Sivas',Sinif=404 WHERE Numara=777;



-- DELETE: Tablodan veri silme.
--numarasý 888 olanlarý sil.
DELETE FROM Ogrenci WHERE Numara=888;

-- Soyadýnda 'BULUT' geçenleri sil.
DELETE FROM Ogrenci WHERE Soyad LIKE '%BULUT%';
SELECT *from Ogrenci

-- Numara otomatik artacak.
INSERT INTO Ogrenci VALUES('Salih','MAHMUT','Cihangir',303);
SELECT * FROM Araba


-- GO Bloklarý arasýndaki komutlarý 10 kez tekrar et.
GO
INSERT INTO Araba VALUES('Mercedes','CLS350','Siyah','Almanya',5,4,1995)
INSERT INTO Araba VALUES('Tofaþ','Kartal','Gri','Türkiye',5,4,1999)
INSERT INTO Araba VALUES('Tofaþ','Karga','Beyaz','Türkiye',5,4,1997)
INSERT INTO Araba VALUES('Tofaþ','Kartal','Kýrmýzý','Türkiye',5,4,1997)
INSERT INTO Araba VALUES('Tofaþ','Doðan','Beyaz','Türkiye',5,4,1997)
INSERT INTO Araba VALUES('Tofaþ','Doðan','Kýrmýzý','Türkiye',5,4,1998)
INSERT INTO Araba VALUES('Porsche','911','Bordo','Almanya',5,4,1993)
INSERT INTO Araba VALUES('BMW','Serçe','Beyaz','Almanya',5,4,1997)
GO 500
-- TRUNCATE ile silinen tabloda ID sýfýrlanýr.
TRUNCATE TABLE Araba

--DELETE ile silinen tabloda ID sýfýrlanmaz.
DELETE FROM Araba



SELECT * FROM Araba WHERE ID= (SELECT MAX(ID) FROM Araba);



--SORU: Model Yýlý 1995'ten yüksek olanlarý listele Yýla göre artan.
SELECT * FROM Araba WHERE UretimYili>1995 ORDER BY UretimYili ASC

--SORU: Rengi kýrmýzý olanlarýn ID'si en büyük olanýný getir.
SELECT * FROM Araba WHERE ID=
(SELECT MAX(ID) FROM Araba WHERE renk='Kýrmýzý')

--SORU: Menþei Almanya olan arabalarýn Marka ve Model bilgileirin listele.
SELECT Marka,Model FROM Araba WHERE mensei='Almanya'

-- SORU: Rengi Kýrmýzý veya Beyaz olan tüm Türkiye üretimi araçlarý listele.
SELECT * FROM Araba WHERE mensei='Türkiye' AND (Renk='Kýrmýzý' OR Renk= 'Beyaz')
SELECT * FROM Araba WHERE mensei='Türkiye' AND Renk IN ('Beyaz','Kýrmýzý')

-- SORU: Mensei Almanya olmayan ve Üretim Yýlý 1999 olan tüm arabalarý listele.
SELECT * FROM Araba WHERE NOT mensei='Almanya' AND UretimYili=1999



--Model adý Kar ile baðlayanlarý listele
SELECT * FROM Araba WHERE Model LIKE 'Kar%'

--Model adý Kar ile baðlayýp sonrasýnda 3 harf içerenleri listele.
SELECT * FROM Araba WHERE Model LIKE 'Kar___'



-- Model adý Kar ile baþlayýp, 5. harfi a olan toplam 5 harfli leri listele.
SELECT * FROM Araba WHERE Model LIKE 'Kar_a'

-- Model adý Kar ile baþlayýp, 5. harfi a olanlarý listele.
SELECT * FROM Araba WHERE Model LIKE 'Kar_a%'

-- Renginde r olanlarý listele.

SELECT * FROM Araba WHERE Renk LIKE '%r%'

-- SORU: Marka adýnda o harfi içerip o'dan sonra 3 harf olanlarý listele.
SELECT * FROM Araba WHERE Marka LIKE '%o___'


--Markasýnýn Ýlk harfi B veya M olanlarý listele
SELECT * FROM Araba WHERE Marka LIKE '[BM]%'

--SORU: Renginin son harfi i,z veya h olup renk adý enaz 4 harfli olanlarý listele.
SELECT * FROM Araba WHERE Renk LIKE '%___[izh]'
