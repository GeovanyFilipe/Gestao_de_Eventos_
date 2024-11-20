using Gestao_de_Eventos_.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Eventos_.Repository
{
    internal class RepositorioGenerico<T> : Icadastro<T>
     {
        private List<T> entidades = new List<T>();

        public void Adicionar(T entidade)
        {
            entidades.Add(entidade);
        }

        public void Remover(T entidade)
        {
            entidades.Remove(entidade);
        }

        public List<T> Listar()
        {
            return entidades;
        }
    }


}

