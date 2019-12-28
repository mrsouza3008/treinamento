using MRS.Business.Interfaces;
using MRS.Business.Model;
using MRS.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, Business.Interfaces.IProdutoRepository
    {
        public ProdutoRepository(Context.ApiContext apiContext) 
            : base(apiContext)
        {

        }
    }
}
