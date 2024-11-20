using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Eventos_.Interface
{
    public interface Icadastro<T>
    {
        void Adicionar(T entidade);
        void Remover(T entidade);
        List<T> Listar();

    }
}
