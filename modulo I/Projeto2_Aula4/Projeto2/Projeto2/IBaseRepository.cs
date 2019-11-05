using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    interface IBaseRepository<T>
    {
        //interface não te código, só tfe as assinaturas dos métodos (cabecalho de funcao)
        void Inserir(T entidadea);
        void Editar(T entidade);
        void Apagar(int id);
        T Obter(int id);

    }
}
