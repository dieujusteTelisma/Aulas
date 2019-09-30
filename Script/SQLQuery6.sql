
insert into Usuarios --informamos a tabela que vamos registrar o valor 
(Nome) --as colunas que vamos carregar as informacoes 
values --informamos que os valores estarao logo a seguir 
('Felipe') --nossas informacoes na ordem das colunas 

GO -- igual a ;

select * from Usuarios 

GO

insert into Usuarios
(Nome , Login , Senha )

values 
('Rosbervaldo' , 'pulsao' , '123654')
Go
select * from Usuarios 