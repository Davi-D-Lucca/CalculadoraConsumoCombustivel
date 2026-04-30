using CalculadoraConsumoCombustivel.DTO;
using CalculadoraConsumoCombustivel.Infra.Entidades;
using CalculadoraConsumoCombustivel.Infra.Interface;
using CalculadoraConsumoCombustivel.Infra.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsumoCombustivel.Service
{
    public class MediaConsumoCombustivelService
    {
        private readonly IMediaConsumoCombustivelRepositorio _repositorio;

        public MediaConsumoCombustivelService()
        {
            _repositorio = new MediaConsumoCombustivelRepositorio();
        }

        public void adicionarNovoRegistro(DadosFormCombustivelDTO form)
        {
            MediaConsumoCombustivel media = new MediaConsumoCombustivel();
            media.Combustivel = form.Combustivel;
            media.ConsumoMedio = form.ConsumoMedio;
            media.DistanciaPercorrida = form.DistanciaPercorrida;
            media.Veiculo = form.Veiculo;
            _repositorio.Adicionar(media);
        }

        public void 


    }
}
