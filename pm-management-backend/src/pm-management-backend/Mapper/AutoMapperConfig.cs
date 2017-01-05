using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using pm_management_backend.Models;
using pm_management_backend.ViewModel;

namespace pm_management_backend.Mapper
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.Initialize(a =>
            {
                a.AddProfile<ProductViewModelProfile>();
              
            });

        }

        internal class ProductViewModelProfile : Profile
        {
            public ProductViewModelProfile()
            {
                base.CreateMap<Product, ProductViewModel>().ReverseMap();
            }

        }
    }
}
