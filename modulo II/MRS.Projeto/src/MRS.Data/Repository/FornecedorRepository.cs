using Microsoft.EntityFrameworkCore;
using MRS.Business.Interfaces;
using MRS.Business.Model;
using MRS.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository 
    {
        public FornecedorRepository(Context.ApiContext apiContext)
             : base(apiContext)
        {

        }
    }
}
