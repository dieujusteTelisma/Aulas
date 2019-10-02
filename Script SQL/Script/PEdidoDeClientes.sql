select * from clientes;
select * from Pedidos;

select cli.* from Clientes cli
		inner join Pedidos ped on cli.id = ped.ClienteId
where ped.Numero in ('N000000001','N000000005','N000000009')

select * from Pedidos ped
where ped.ClienteId in (select cli.Id from Clientes cli
		inner join Pedidos ped on cli.id = ped.ClienteId
where ped.Numero in ('N000000001','N000000005','N000000009'))


select * from Pedidos ped
where ped.ClienteId in (select cli.Id from Clientes cli
		inner join Pedidos ped on cli.id = ped.ClienteId
where ped.Numero in ('N000000001','N000000005','N000000009'))
order by ped.Valor desc