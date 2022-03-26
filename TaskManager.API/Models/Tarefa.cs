using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.API.Models
{
    public class Tarefa
    {
        public string Id { get; private set; }
        public string Nome { get; private set; }
        public string Detalhes { get; private set; }
        public bool Concluido { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime? DataConclusao { get; private set; }

        public Tarefa(string nome, string detalhes)
        {
            Id = Guid.NewGuid().ToString(); //Gerar um código hash e converter para string para guardar no mongo
            Nome = nome;
            Detalhes = detalhes;
            Concluido = false;
            DataCadastro = DateTime.Now;
            DataConclusao = null;
        }

        public void AtualizarTarefa(string nome, string detalhes, bool? concluido)
        {
            Nome = nome;
            Detalhes = detalhes;

            //Concluido = concluido.HasValue ? concluido.Value : false;
            Concluido = concluido ?? false;

            //if (Concluido)
            //    DataConclusao = DateTime.Now;
            DataConclusao = Concluido ? DateTime.Now : null;
        }
    }
}
