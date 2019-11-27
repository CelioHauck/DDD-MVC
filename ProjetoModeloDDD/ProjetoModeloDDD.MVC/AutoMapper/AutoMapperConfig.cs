using AutoMapper;
using ProjetoModeloDDD.Domainn.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class AutoMapperConfig: Profile
    {
        public static void RegisterMappings()
        {
           Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}