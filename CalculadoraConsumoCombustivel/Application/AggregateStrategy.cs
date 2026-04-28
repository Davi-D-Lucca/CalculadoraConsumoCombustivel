using CalculadoraConsumoCombustivel.DTO;
using CalculadoraConsumoCombustivel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsumoCombustivel.Application
{
    public class AggregateStrategy : IAggregateStrategy
    {

        //Com _
        private readonly PostosResponseDTO _diesel;
        private readonly PostosResponseDTO _etanol;
        private readonly PostosResponseDTO _gasolina;
        //readonly nunca vai mudar, vai diminuir o peso cognitivo do desenvolvedor
        //Do inicio ao fim, não vai modificar a variavel

        public AggregateStrategy(PostosResponseDTO diesel, PostosResponseDTO etanol, PostosResponseDTO gasolina)
        {
            _diesel = diesel;
            _etanol = etanol;
            _gasolina = gasolina;
        }


        //public List<PostoDTO> Start(){
        //if (_diesel?.Postos != null)
        //    todosPostos.AddRange(_diesel.Postos.Select(p => new PostoDTO { RazaoSocial = p.RazaoSocial }));

        //if (_etanol?.Postos != null)
        //    todosPostos.AddRange(_etanol.Postos.Select(p => new PostoDTO { RazaoSocial = p.RazaoSocial }));

        //if (_gasolina?.Postos != null)
        //    todosPostos.AddRange(_gasolina.Postos.Select(p => new PostoDTO { RazaoSocial = p.RazaoSocial }));
        //    }


        //public List<string> Start() 
        //{
        //    var todosPostos = new List<string>();

        //    if (_diesel?.Postos != null)
        //        todosPostos.AddRange(_diesel.Postos.Select(p => p.RazaoSocial));

        //    if (_etanol?.Postos != null)
        //        todosPostos.AddRange(_etanol.Postos.Select(p => p.RazaoSocial));

        //    if (_gasolina?.Postos != null)
        //        todosPostos.AddRange(_gasolina.Postos.Select(p => p.RazaoSocial));

        //    return todosPostos;

        //    //Ou estou corrigindo
        //    //Inclementando
        //    //OU refaturando para ser mais facil de ser lido
        //}

        public List<PostoAgrupadoDTO> Start()
        {
            var lista = new List<PostoResultadoDTO>();

            if (_diesel?.Postos != null)
            {
                lista.AddRange(_diesel.Postos.Select(p => new PostoResultadoDTO
                {
                    RazaoSocial = p.RazaoSocial,
                    Preco = p.PrecoVenda,
                    Combustivel = "Diesel"
                }));
            }

            if (_etanol?.Postos != null)
            {
                lista.AddRange(_etanol.Postos.Select(p => new PostoResultadoDTO
                {
                    RazaoSocial = p.RazaoSocial,
                    Preco = p.PrecoVenda,
                    Combustivel = "Etanol"
                }));
            }

            if (_gasolina?.Postos != null)
            {
                lista.AddRange(_gasolina.Postos.Select(p => new PostoResultadoDTO
                {
                    RazaoSocial = p.RazaoSocial,
                    Preco = p.PrecoVenda,
                    Combustivel = "Gasolina"
                }));
            }

            return lista
                .GroupBy(p => p.RazaoSocial)
                .Select(g => new PostoAgrupadoDTO
                {
                    RazaoSocial = g.Key,
                    Combustiveis = g.ToList()
                })
                .ToList();
        }

        //public List<PostoAgrupadoDTO> AgruparPorPosto()
        //{
        //    var lista = Start();

        //    return lista
        //        .GroupBy(p => p.RazaoSocial)
        //        .Select(g => new PostoAgrupadoDTO
        //        {
        //            RazaoSocial = g.Key,
        //            Combustiveis = g.ToList()
        //        })
        //        .ToList();
        //}
    }

}
