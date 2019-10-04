select gen.Nome as 'Genero', 
art.Nome as 'Artista',
can.Nome as 'Cancão'
from Genero gen
inner join Artistas art on gen.Id = Art.GeneroId
inner join Cancoes can on art.Id = can.ArtistaId
 
 select gen.Nome as 'Genero',
   COUNT(art.Nome) as 'Quantidade Artistas'
   from Genero gen 
   inner join Artistas art on gen.Id =art.GeneroId
   Group by gen.Nome

   select gen.Nome as 'Genero',
   COUNT(art.Nome) as 'Quantidade de cancoes'
   from Genero gen 
   inner join Artistas art on gen.Id =art.GeneroId -- cancoe nao tem realtion com genero por isso que deixe inner join artista 
   inner join Cancoes can on art.Id = can.ArtistaId
   Group by gen.Nome