using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Livros
{
    public class Livro
    {
        public Guid Id { get;  set; }
        public String Titulo { get; set; }
        public String Autor { get;  set; }
        public DateTime DataLancamento { get; set; }
        public int NumeroPaginas { get;  set; }
    }
}
