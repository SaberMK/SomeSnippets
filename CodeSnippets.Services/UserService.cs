using AutoMapper;
using CodeSnippets.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets.Services
{
    public class UserService : IUserService
    {
        IMapper _mapper;
        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<string> GetTestString()
        {
            var asd1 = new View1() { Obj1 = "Response! " };
            await Task.Delay(100);
            return _mapper.Map<View1, View2>(asd1).Obj1;
        }
    }
}
