using AutoMapper;
using CodeSnippets.Database.Interfaces;
using CodeSnippets.Entities.Entities;
using CodeSnippets.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets.Services
{
    public class UserService : IUserService
    {
        IMapper _mapper;
        IUserContext _userContext;
        public UserService(IMapper mapper , IUserContext userContext)
        {
            _mapper = mapper;
            _userContext = userContext;
        }
        public async Task<string> GetTestString()
        {
            var user = new User()
            {
                Username = "TestUser",
                Password = "qwerty123",
                RegistrationDate = DateTime.Now
            };
            _userContext.Add(user);
            await _userContext.CommitAsync();
            var newUser = await _userContext.Query().SingleAsync(x => x.Username == user.Username);
            return newUser.Id.ToString();

            //var asd1 = new View1() { Obj1 = "Response! " };
            //await Task.Delay(100);



            //return _mapper.Map<View1, View2>(asd1).Obj1;
        }
    }
}
