--Trazer somente as marcas que Felipe cadastrou

update marcas 

set UsuInc = 1 
where UsuInc  = 0

select * from Usuarios 
select * from Marcas
select * from Vendas

select mar.* from Marcas mar
   inner join Usuarios usu on mar.UsuInc = usu.Id
   where usu.Id = 1

--3 -Trazer somente as marcas que Giomar cadastrou

select mar.* from Marcas mar
   inner join Usuarios usu on mar.UsuInc = usu.Id
   where usu.Id = 2

-- Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor "colocar o order by desc   no final do select só isso "

SELECT COUNT(Nome) as 'Marcas comprados por felipe'
FROM Marcas
WHERE UsuInc = 1;

--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior

SELECT COUNT(Nome) as 'Marcas comprados por Giomar'
FROM Marcas
WHERE UsuInc = 2;

--trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 

SELECT COUNT(Nome) as 'Marcas comprados por Felipe e Giomar'
FROM Marcas
GROUP BY UsuInc


--Trazer somente os carros que Felipe cadastrou

select car.* from Carros car
   inner join Usuarios usu on car.UsuInc = usu.Id
   where usu.Id = 1

--Trazer somente os carros que Giomar cadastrou

select car.* from Carros car
   inner join Usuarios usu on car.UsuInc = usu.Id
   where usu.Id = 2

--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor

SELECT COUNT(Modelo) as 'Carros comprados por Giomar'
FROM Carros
WHERE UsuInc = 1 order by COUNT(Modelo) desc 

--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior

SELECT COUNT(Modelo) as 'Carros comprados por Giomar'
FROM Carros
WHERE UsuInc = 2 order by COUNT(Modelo) asc

--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 

SELECT COUNT(Modelo) as 'quantidade de carros que Felipe e Giomar cadastraram '
FROM Carros
GROUP BY UsuInc

--Trazer somente os carros das marcas que Felipe cadastrou


select usu.Usuario , car.Modelo
from Carros car
    inner join Marcas mar on car.Marca = mar.Id
    inner join Usuarios usu  on mar.UsuInc = usu.Id
   where usu.Usuario = 'Felipe'
 
 --Trazer o valor total de vendas 2019 isolado

   select SUM(ven.Valor) from Vendas ven 
   where ven.DatInc >= '2019-01-01' and ven.DatInc <= '2019-12-31'

   --Trazer a quantidade total de vendas 2019 isolado

select SUM(ven.Quantidade) from Vendas ven 
   where ven.DatInc >= '2019-01-01' and ven.DatInc <= '2019-12-31'

   --Trazer o valor total de vendas em cada ano e ordenar do maior para o menor	

   Select SUM(ven.Quantidade) from Vendas ven 
  group by year(DatInc)       
   order by year(DatInc) desc

 --Trazer o mês de cada ano que retornou a maior quantidade de vendas
select Top 3 MONTH (Vendas.DatInc)
From
Vendas
GROUP BY YEAR (Vendas.DatInc), MONTH (Vendas.DatInc)
ORDER BY SUM(Vendas.Quantidade * Vendas.Valor) DESC

--Trazer o valor total de vendas que Felipe realizou
Select SUM(ven.Quantidade * Valor ) from Vendas ven 
  where UsuInc = 1
   
--Trazer o valor total de vendas que Giomar realizou
Select SUM(ven.Quantidade * Valor ) from Vendas ven 
  where UsuInc = 2

--Trazer a quantidade total de vendas que Felipe realizou
Select SUM(ven.Quantidade ) from Vendas ven 
  where UsuInc = 1

--Trazer a quantidade de vendas que Giomar realizou

Select SUM(ven.Quantidade ) from Vendas ven 
  where UsuInc = 2

--Trazer a quantidade total de vendas que Felipe e Giomar realizaram
--ordenando do maior para menor
Select SUM(ven.Quantidade ) as 'Quantidade total de vendas de F e G' from Vendas ven 
GROUP BY UsuInc 
order by SUM(ven.Quantidade ) desc

--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
Select SUM(ven.Quantidade * Valor ) from Vendas ven 
 Group by UsuInc 

 --Trazer a marca mais vendida de todos os anos


select  Top 1 ven.*
From
Vendas ven  
 inner join Marcas mar on ven .UsuInc = mar.Id
 inner join Usuarios usu  on mar.Id = usu.Id
group by year (Vendas.DatInc) 
order by Valor desc




--where usu.Id = 1

group by UsuInc
  order by Valor desc


select car.* from Carros car
   inner join Usuarios usu on car.UsuInc = usu.Id
   where usu.Id = 1


GROUP BY YEAR (Vendas.DatInc), MONTH (Vendas.DatInc)
ORDER BY SUM(Vendas.Quantidade * Vendas.Valor) DESC

select * from Vendas
select * from Carros
select * from Marcas

SELECT column_name(s) FROM table2;


select ven.* from Vendas ven
   inner join Usuarios usu on ven.UsuInc = usu.Id
   where usu.Id = 1 order by ven.Valor desc 
 