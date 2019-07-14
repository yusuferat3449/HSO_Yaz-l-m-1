--Ders2
-- ORDER BY: S�ralama. Varsay�lan olarak artan yani ASC �al���r.
SELECT * FROM Ogrenci ORDER BY Sinif

SELECT * FROM Ogrenci ORDER BY Sinif ASC
-- Numaraya g�re azalan s�ralama: DESC
SELECT * FROM Ogrenci ORDER BY Sinif DESC
--Harfe g�re s�ralama
SELECT * FROM Ogrenci ORDER BY Soyad

-- Harfe g�re tersten s�ralama
SELECT * FROM Ogrenci ORDER BY Soyad DESC



--�lk 3 kayd� getir. ID's�ralamas�na g�re
SELECT TOP 3 * FROM Araba ORDER BY ID ASC

--son 3 kayd� getir. ID's�ralamas�na g�re
SELECT TOP 3 * FROM Araba ORDER BY ID DESC

SELECT MAX(ID) AS EnB�y�k FROM Araba

SELECT MIN(ID) AS EnK���k FROM Araba

SELECT AVG(ID) AS Ortadaki FROM Araba

SELECT COUNT(ID) AS Kay�tSay�s� FROM Araba

SELECT SUM(ID) AS IDtoplam� FROM Araba

--INSERT INTO: Tabloya kay�t ekleme

INSERT INTO Ogrenci (Numara,Ad,Soyad,Adres,Sinif)
VALUES              (666,'Ay�e','K�RAZ','Kayseri',101);

INSERT INTO Ogrenci VALUES(777,'Salih','MAHMUT','Cihangir',303);

INSERT INTO Ogrenci VALUES(888,'Selin','HABER','',202);

--Adresi NULL olanlar� getir.
SELECT * FROM Ogrenci WHERE Adres IS NULL;

-- ADdresi NULL olmayanlar� getir.
SELECT * FROM Ogrenci WHERE Adres IS NOT NULL;

--UPDATE: Varolan veriyi g�ncelleme
-- Adresi bo�luk olanlar� NULL olarak de�i�tir.
UPDATE Ogrenci SET Adres=NULL WHERE Adres='';
,
UPDATE Ogrenci SET Adres='TANIMSIZ' WHERE Adres IS NULL;

UPDATE Ogrenci SET Numara=45, Ad='Sevgi', Soyad='K�M�R',Adres='Sivas',Sinif=404 WHERE Numara=777;



-- DELETE: Tablodan veri silme.
--numaras� 888 olanlar� sil.
DELETE FROM Ogrenci WHERE Numara=888;

-- Soyad�nda 'BULUT' ge�enleri sil.
DELETE FROM Ogrenci WHERE Soyad LIKE '%BULUT%';
SELECT *from Ogrenci

-- Numara otomatik artacak.
INSERT INTO Ogrenci VALUES('Salih','MAHMUT','Cihangir',303);
SELECT * FROM Araba


-- GO Bloklar� aras�ndaki komutlar� 10 kez tekrar et.
GO
INSERT INTO Araba VALUES('Mercedes','CLS350','Siyah','Almanya',5,4,1995)
INSERT INTO Araba VALUES('Tofa�','Kartal','Gri','T�rkiye',5,4,1999)
INSERT INTO Araba VALUES('Tofa�','Karga','Beyaz','T�rkiye',5,4,1997)
INSERT INTO Araba VALUES('Tofa�','Kartal','K�rm�z�','T�rkiye',5,4,1997)
INSERT INTO Araba VALUES('Tofa�','Do�an','Beyaz','T�rkiye',5,4,1997)
INSERT INTO Araba VALUES('Tofa�','Do�an','K�rm�z�','T�rkiye',5,4,1998)
INSERT INTO Araba VALUES('Porsche','911','Bordo','Almanya',5,4,1993)
INSERT INTO Araba VALUES('BMW','Ser�e','Beyaz','Almanya',5,4,1997)
GO 500
-- TRUNCATE ile silinen tabloda ID s�f�rlan�r.
TRUNCATE TABLE Araba

--DELETE ile silinen tabloda ID s�f�rlanmaz.
DELETE FROM Araba



SELECT * FROM Araba WHERE ID= (SELECT MAX(ID) FROM Araba);



--SORU: Model Y�l� 1995'ten y�ksek olanlar� listele Y�la g�re artan.
SELECT * FROM Araba WHERE UretimYili>1995 ORDER BY UretimYili ASC

--SORU: Rengi k�rm�z� olanlar�n ID'si en b�y�k olan�n� getir.
SELECT * FROM Araba WHERE ID=
(SELECT MAX(ID) FROM Araba WHERE renk='K�rm�z�')

--SORU: Men�ei Almanya olan arabalar�n Marka ve Model bilgileirin listele.
SELECT Marka,Model FROM Araba WHERE mensei='Almanya'

-- SORU: Rengi K�rm�z� veya Beyaz olan t�m T�rkiye �retimi ara�lar� listele.
SELECT * FROM Araba WHERE mensei='T�rkiye' AND (Renk='K�rm�z�' OR Renk= 'Beyaz')
SELECT * FROM Araba WHERE mensei='T�rkiye' AND Renk IN ('Beyaz','K�rm�z�')

-- SORU: Mensei Almanya olmayan ve �retim Y�l� 1999 olan t�m arabalar� listele.
SELECT * FROM Araba WHERE NOT mensei='Almanya' AND UretimYili=1999



--Model ad� Kar ile ba�layanlar� listele
SELECT * FROM Araba WHERE Model LIKE 'Kar%'

--Model ad� Kar ile ba�lay�p sonras�nda 3 harf i�erenleri listele.
SELECT * FROM Araba WHERE Model LIKE 'Kar___'



-- Model ad� Kar ile ba�lay�p, 5. harfi a olan toplam 5 harfli leri listele.
SELECT * FROM Araba WHERE Model LIKE 'Kar_a'

-- Model ad� Kar ile ba�lay�p, 5. harfi a olanlar� listele.
SELECT * FROM Araba WHERE Model LIKE 'Kar_a%'

-- Renginde r olanlar� listele.

SELECT * FROM Araba WHERE Renk LIKE '%r%'

-- SORU: Marka ad�nda o harfi i�erip o'dan sonra 3 harf olanlar� listele.
SELECT * FROM Araba WHERE Marka LIKE '%o___'


--Markas�n�n �lk harfi B veya M olanlar� listele
SELECT * FROM Araba WHERE Marka LIKE '[BM]%'

--SORU: Renginin son harfi i,z veya h olup renk ad� enaz 4 harfli olanlar� listele.
SELECT * FROM Araba WHERE Renk LIKE '%___[izh]'
