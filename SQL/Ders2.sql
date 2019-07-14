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