using AutoMapper;
using CodeSnippets.Entities.Entities;
using CodeSnippets.ViewModels.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSnippets.Mappings
{
    public class ViewModelsMapping : Profile
    {
        public ViewModelsMapping()
        {
            CreateMap<User, UserTokenViewModel>();



            ///DELET THIS
            //.ForMember(dest => dest.Obj1, opt => opt.MapFrom(dest => dest.Obj1 + dest.Obj1));
        }
    }
}
