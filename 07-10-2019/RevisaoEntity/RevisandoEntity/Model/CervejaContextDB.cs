using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    public class CervejaContextDB : DbContext  //usando tambem o : using System.Data.Entity;
                                               //DbContext herdamos nossa classe Dbcontext que faz toda parte do banco de dados 


    {
         //Definimos nossa tabela dentro do banco de dados 
        public DbSet<Cerveja> Cervejas { get; set; }
        //ot Dbset permite que esses codigos viraram uma tabela 
    }



}

//depois de escrever DBCOntext podemos ir no toll nuget excole manage nuget ou seja escole package 
//manager console e procura no google escreventdo nuget command to install entity framework
//para copiar "Install-Package EntityFramework -Version 6.3.0" para colocar no package manager console 

