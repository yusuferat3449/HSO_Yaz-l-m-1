-- Hangi kategoriden  ka� farkl� �r�n var?
SELECT COUNT(Urunler.UrunID) , 
Urunler.KategoriID
From Urunler
GROUP BY urunler.KategoriID;

-- Hangi kategoride toplam ne kadar stok var?
SELECT SUM(Urunler.HedefStokDuzeyi) AS ToplamStok, Urunler.KategoriID
FROM Urunler GROUP BY Urunler.KategoriID

-- Hangi kategoride toplam ne kadar stok var? Kategori isimleri ile listele
SELECT SUM(Urunler.HedefStokDuzeyi), Urunler.KategoriID, 
Kategoriler.KategoriAdi FROM Urunler
INNER JOIN Kategoriler ON Urunler.KategoriID=Kategoriler.KategoriID
GROUP BY Urunler.KategoriID, Kategoriler.KategoriAdi;

-- Toplam Stok
SELECT SUM(Urunler.HedefStokDuzeyi) AS ToplamSTOK FROM Urunler


-- Hangi �lkeden ka� m��teri var?
SELECT COUNT(Musteriler.MusteriID) AS M��teriAdedi,
Musteriler.Ulke From Musteriler
GROUP BY Musteriler.Ulke
