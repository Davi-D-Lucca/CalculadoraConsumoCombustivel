using CalculadoraConsumoCombustivel.DTO;
using CalculadoraConsumoCombustivel.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsumoCombustivel.Application
{
    public class ConsultaListaPosto
    {
        public ConsultaListaPosto()
        {
            Consulta = new ConsultaApi();
        }

        public ConsultaApi Consulta { get; set; }

        //Task - Concorrencia e Paralismo
        //Executa ao mesmo tempo, mas sincronizado

        public async Task<PostosResponseDTO> ConsultaPostosDiesel()
        {
           // Consulta na API
            //Tem que esperar a resposta, por isso o "await"
            var result = await Consulta.GetAsync<PostosResponseDTO>("https://petroinfo.tec.br/postos/dados_postos/?cidade_selecionada=MARILIA&combustivel_selecionado=OD");
            return result;
        }

    }
}
