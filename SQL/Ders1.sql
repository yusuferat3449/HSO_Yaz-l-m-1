--Sorgu yap�lacak veritaban�n� se�
use HSO_OGLE

-- Tablodaki t�m kay�tlar� listele
SELECT * FROM Ogrenci

--Tablodaki t�m kay�tlar�n Ad,Soyad bilgisini getir.
SELECT Ad,Soyad FROM Ogrenci

--Tabloda ismi Bar�� olanlar�n numaras�n� getir.
SELECT Numara FROM Ogrenci WHERE Ad='Bar��'




--�smi Bar�� Soyad� SEV�N� olan kay�tlar� listele
SELECT * FROM Ogrenci WHERE Ad='Bar��' AND Soyad='SEV�N�'

-- Ad� Bedirhan veya Halil olanlar� listeler.
SELECT * FROM Ogrenci WHERE Ad='Halil' OR Ad='Bedirhan';

-- Bar�� isminde ka� kay�t var?
SELECT COUNT(Ad) FROM Ogrenci WHERE Ad='Bar��'

-- Numaras� 300 den k���k olanlar� getir.
SELECT * FROM Ogrenci WHERE Numara<300;

-- Numaras� 200 ile 400 aras�nda olanlar� getir.
SELECT * FROM Ogrenci WHERE Numara BETWEEN 200 AND 400;

-- �smi Bedirhan, Halil, Mehmet'den biri olanlar� getir.
SELECT * FROM Ogrenci WHERE Ad IN('Bedirhan','Halil','Mehmet');

-- Ad� Halil olmayanlar� getir.
SELECT * FROM Ogrenci WHERE NOT Ad='Halil';


-- Numaras� 444 olmayan ve Ad� Bar�� olanlar� getir.
SELECT * FROM Ogrenci WHERE Numara<>444 AND Ad='Bar��'