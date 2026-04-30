using CalculadoraConsumoCombustivel.Infra.Entidades;
using CalculadoraConsumoCombustivel.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsumoCombustivel.Infra.Repositorio
{
    public class MediaConsumoCombustivelRepositorio : IMediaConsumoCombustivelRepositorio
    {
            public void Adicionar(MediaConsumoCombustivel entidade)
            {
                using (var db = new AppDbContext())
                {
                    entidade.CriadoEm = System.DateTime.Now;

                    db.MediasConsumo.Add(entidade);

                    db.SaveChanges();
                }
            }

            public void Atualizar(MediaConsumoCombustivel entidade)
            {
                using (var db = new AppDbContext())
                {
                    entidade.ModificadoEm = System.DateTime.Now;

                    db.Entry(entidade).State =
                        System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();
                }
            }

            public void Remover(int id)
            {
                using (var db = new AppDbContext())
                {
                    var entidade =
                        db.MediasConsumo.FirstOrDefault(x => x.Id == id);

                    if (entidade == null)
                        return;

                    db.MediasConsumo.Remove(entidade);

                    db.SaveChanges();
                }
            }

            public MediaConsumoCombustivel ObterPorId(int id)
            {
                using (var db = new AppDbContext())
                {
                    return db.MediasConsumo
                        .FirstOrDefault(x => x.Id == id);
                }
            }

            public List<MediaConsumoCombustivel> Listar()
            {
                using (var db = new AppDbContext())
                {
                    return db.MediasConsumo.ToList();
                }
           }
       }
 }
