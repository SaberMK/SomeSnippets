using AutoMapper;
using CodeSnippets.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSnippets.Services
{
    public class UserService : IUserService
    {
        IMapper _mapper;
        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public string GetTestString()
        {
            var asd1 = new View1() { Obj1 = "Response! " };

            return _mapper.Map<View1, View2>(asd1).Obj1;
        }
    }
}
