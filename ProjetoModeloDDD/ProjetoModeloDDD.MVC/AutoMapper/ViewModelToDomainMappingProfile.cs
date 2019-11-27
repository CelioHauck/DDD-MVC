using ProjetoModeloDDD.Domainn.Entities;
using ProjetoModeloDDD.MVC.ViewModels;
using AutoMapper;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile() {
            CreateMap<Produto, ProdutoViewModel>();
            CreateMap<Cliente, ClienteViewModel>();
        }
    }
}