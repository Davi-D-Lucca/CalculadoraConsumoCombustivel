using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsumoCombustivel.Infra.Entidades.Base
{
    class Entidade
    {
        //Travado em inteiro o projeto inteiro
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime? ModificadoEm { get; set; }
    }
}
