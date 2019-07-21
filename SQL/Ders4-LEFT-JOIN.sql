SELECT * FROM Filmler
LEFT JOIN Turler ON 
Filmler.FilmTur_ID=Turler.ID

SELECT * FROM Filmler
RIGHT JOIN Turler ON 
Filmler.FilmTur_ID=Turler.ID

-- Left: Fromdan sonraki tablo
-- Right JOIN'den sonraki tablo

SELECT * FROM Filmler
FULL OUTER JOIN Turler
ON Filmler.FilmTur_ID=Turler.ID