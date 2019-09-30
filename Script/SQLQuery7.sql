update Usuarios 
set Login = 'não informado' 
where Login is null 
GO
select * from Usuarios
insert into Usuarios --informamos a tabela que vamos registrar o valor 
(Nome) --as colunas que vamos carregar as informacoes 
values --informamos que os valores estarao logo a seguir 
('Felipe') --nossas informacoes na ordem das colunas 

GO -- igual a ;