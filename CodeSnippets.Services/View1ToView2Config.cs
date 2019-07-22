using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSnippets.Services
{
    public class View1ToView2Config : Profile
    {
        public View1ToView2Config()
        {
            CreateMap<View1, View2>()
                .ForMember(dest => dest.Obj1, opt => opt.MapFrom(dest => dest.Obj1 + dest.Obj1));
        }
    }
}
