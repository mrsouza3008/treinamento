using AutoMapper;
using MInhaPrimeiraAPI.Models;
using MInhaPrimeiraAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MInhaPrimeiraAPI
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Produto, ProdutoAdicionarViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoEditarViewModel>().ReverseMap();

        }

    }

}
