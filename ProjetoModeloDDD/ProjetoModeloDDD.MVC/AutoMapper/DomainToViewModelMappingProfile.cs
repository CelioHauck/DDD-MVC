

using AutoMapper;
using ProjetoModeloDDD.Domainn.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProdutoViewModel, Produto>();
            CreateMap<ClienteViewModel, Cliente>();
        }
    }
}