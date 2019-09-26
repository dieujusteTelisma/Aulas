using ListagemDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Controller
{
    class CarroController
    {
        SistemaCarrosContext sistemCarrosContext = new SistemaCarrosContext();

        public List<Carro> GetCarros()
        {
            return sistemCarrosContext.ListaCarrosPublica;
        }

        
    }
}
