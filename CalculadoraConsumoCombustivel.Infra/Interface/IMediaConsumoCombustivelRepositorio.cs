using CalculadoraConsumoCombustivel.Infra.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsumoCombustivel.Infra.Interface
{
    public interface IMediaConsumoCombustivelRepositorio
    {
        void Adicionar(MediaConsumoCombustivel entidade);
        void Atualizar(MediaConsumoCombustivel entidade);
        void Remover(int id);
        MediaConsumoCombustivel ObterPorId(int id);
        List<MediaConsumoCombustivel> Listar();
    }
}
