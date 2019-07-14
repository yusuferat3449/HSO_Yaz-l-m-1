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