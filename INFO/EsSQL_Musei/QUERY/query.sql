/* 15 */
SELECT o.nomeM, a.nazionalita, COUNT(*) as numeroOpere FROM ARTISTI a, OPERE o WHERE a.nomeA = o.nomeA GROUP BY o.nomeM, a.nazionalita;

/* 14 */
SELECT * FROM MUSEI m WHERE m.citta = 'Ancona' AND not exists(SELECT * FROM OPERE o, ARTISTI a WHERE a.nomeA = o.nomeA AND m.nomeM = o.nomeM AND a.nazionalita = 'Italiana' AND a.nomeA <> 'Barbero');

/* 13 */
SELECT * FROM OPERE o, ARTISTI a WHERE a.nazionalita = 'Italiana' AND o.nomeA = a.nomeA AND not exists(SELECT * FROM Personaggi p WHERE p.codice = o.codice);

/* 12 */
SELECT * FROM OPERE o, ARTISTI a WHERE a.nomeA = o.nomeA AND a.nazionalita = 'Italiana' GROUP BY o.nomeM HAVING COUNT(*)>=2;

/* 11 */
SELECT o.NomeA, count(*) AS NumeroOpere FROM Opere o
WHERE o.NomeM = 'Fenice' 
GROUP BY o.NomeA;

/* 10 */
SELECT * FROM Musei m
WHERE m.Citta = 'Ancona'
AND NOT EXISTS (SELECT * FROM Opere o WHERE o.NomeM = m.NomeM AND o.NomeA <> 'Barbero');

/* 10bis */
SELECT m.nomeM FROM Musei m
WHERE m.Citta = 'Ancona'
AND 'Barbero' = ALL(SELECT o.nomeA FROM OPERE o WHERE o.nomeM = m.nomeM);
