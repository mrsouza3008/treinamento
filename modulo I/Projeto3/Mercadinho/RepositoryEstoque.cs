using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadinho
{
    public class RepositoryEstoque
    {
        //public RepositoryCompra repository = new RepositoryCompra();

        public MercadinhoContext Context { get; set; }

        public RepositoryEstoque()
        {
            Context = new MercadinhoContext();
        }

        public void Inserir(ClassEstoque estoque)
        {
            Context.Estoques_DB.Add(estoque);
            Context.SaveChanges();
        }

        public ClassEstoque Obter(int id)
        {
            return Context.Estoques_DB.Include("Produto").Where(a => a.Id == id).FirstOrDefault();
        }

        public IEnumerable<ClassEstoque> Obter() // Lista
        {
            return Context.Estoques_DB.Include("Produto").ToList();
        }

        public void Editar(ClassEstoque estoque)
        {
            ClassEstoque EstoqueNoDB = Obter(estoque.Id);

            if (EstoqueNoDB != null)
            {
                Context.Entry(EstoqueNoDB).CurrentValues.SetValues(estoque);
                Context.SaveChanges();
            }
        }

        public void Apagar(int id)
        {
            ClassEstoque EstoqueNoDB = Obter(id);

            if (EstoqueNoDB != null)
            {
                Context.Estoques_DB.Remove(EstoqueNoDB);
                Context.SaveChanges();
            }
        }

        public void Recebimento(ClassEstoque estoque, ClassCompra comprado)
        {

            if (estoque == null)
            {
                estoque = new ClassEstoque();
                estoque.Id = comprado.ProdutoId;
                estoque.QtdeEstoque = comprado.QtdeDeCompra;
                if (estoque.QtdeEstoque < 4) { estoque.QtdeMinimoEstoque = 1; }
                else { estoque.QtdeMinimoEstoque = comprado.QtdeDeCompra - 3; }
                
                Inserir(estoque);
              
                               
            }
            else
            {
                estoque.Id = comprado.ProdutoId;
                estoque.QtdeEstoque = estoque.QtdeEstoque + comprado.QtdeDeCompra;
                estoque.QtdeMinimoEstoque = estoque.QtdeEstoque - 3;
                if (estoque.QtdeMinimoEstoque <= 0) { estoque.QtdeMinimoEstoque = 1; }
                Editar(estoque);

            }
            
        }

        public void RealizarVenda(ClassEstoque estoque, ClassVenda vendido)
        {
            if (estoque.QtdeEstoque < vendido.QtdeVendida)
            {
                MessageBox.Show("Estoque Insuficiente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                estoque.QtdeEstoque = estoque.QtdeEstoque - vendido.QtdeVendida;
                Editar(estoque);
            }
        }

    }
}
