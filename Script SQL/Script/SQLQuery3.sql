

select  Genero , COUNT(Artista) from PlayList
group by Genero

select Artista ,COUNT(Nome) from PlayList
group by Artista

select distinct Genero from PlayList

select * from PlayList