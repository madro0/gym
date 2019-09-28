select * from Suscripcion where not Id in (select Suscripcion from CompraSuscripcion)

Select * from Suscripcion where Suscripcion.id not in (select CompraSuscripcion.Suscripcion from CompraSuscripcion)

SELECT d.* FROM Suscripcion d 
LEFT JOIN CompraSuscripcion t
ON d.Id = t.Suscripcion 
WHERE t.Suscripcion IS NULL 

select * from Suscripcion
