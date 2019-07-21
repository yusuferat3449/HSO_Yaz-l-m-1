-- Filmlerin t�rlerini �ek.
SELECT Filmler.FilmAd, Turler.TurAd FROM Filmler
INNER JOIN Turler ON Filmler.FilmTur_ID=Turler.ID

SELECT * FROM Yayinlar
--T�m filmlere ait ad,salon, yay�n zaman� bilgisini �ek.
SELECT Filmler.FilmAd, Salonlar.SalonAd, Yayinlar.Zaman
FROM Yayinlar INNER JOIN Filmler ON Yayinlar.Film_ID=Filmler.ID
INNER JOIN Salonlar ON Yayinlar.Salon_ID=Salonlar.ID;




-- ID'si 4 olan film ile ilgili bilgileri �ek.
SELECT Filmler.FilmAd, Turler.TurAd, Yayinlar.Zaman, 
Salonlar.SalonAd, Salonlar.SalonAdres
FROM Filmler 
INNER JOIN Turler ON Turler.ID = Filmler.FilmTur_ID
INNER JOIN Yayinlar ON Yayinlar.Film_ID=Filmler.ID
INNER JOIN Salonlar ON Salonlar.ID=Yayinlar.Salon_ID
WHERE Filmler.ID=4;

-- Nautilus AVM Salon 2 'de yay�nlanan filmlerin ad�n� ve zaman�n� listeleyen
-- sorgu

SELECT Filmler.FilmAd, Yayinlar.Zaman FROM Yayinlar 
INNER JOIN Filmler ON Filmler.ID=Yayinlar.Film_ID
INNER JOIN Salonlar ON Salonlar.ID = Yayinlar.Salon_ID
WHERE Salonlar.SalonAd='Nautilus AVM Salon 2';
--WHERE Salonlar.ID=5;

SELECT * FROM Salonlar

-- Hababam S�n�f� hangi salonlarda ve zamanlarda yay�nlanmaktad�r?

SELECT Salonlar.SalonAd,Yayinlar.Zaman FROM Salonlar
INNER JOIN Yayinlar ON Salonlar.ID = Yayinlar.Salon_ID
INNER JOIN Filmler ON Filmler.ID = Yayinlar.Film_ID
WHERE Filmler.ID = 1 ORDER BY SalonAd;

SELECT * FROM Filmler

