using AutoMapper;
using CodeSnippets.Database.Interfaces;
using CodeSnippets.Database.Repositories.Interfaces;
using CodeSnippets.Entities.Entities;
using CodeSnippets.Services.Interfaces;
using CodeSnippets.Utils.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets.Services
{
    public class UserService : IUserService
    {
        readonly IMapper _mapper;
        readonly IUserRepository _userContext;
        readonly IUserPasswordEncoder _encoder;
        public UserService(IMapper mapper, IUserRepository userContext , IUserPasswordEncoder encoder )
        {
            _mapper = mapper;
            _encoder = encoder;
            _userContext = userContext;
        }
        public async Task<bool> IsUserExists(string username)
        {
            var user = await _userContext.Query().SingleOrDefaultAsync(x => x.Username == username);
            return user != null;   
        }

        public async Task<User> AuthUser(string username, string password)
        {
            try
            {
                return await _userContext.Query().SingleAsync(x => x.Username == username && x.Password == _encoder.EncodeUserPassword(password));
            }
            catch //TODO
            {
                return null;
            }
        }

        public async Task<User> RegisterUser(string username, string password)
        {
            try
            {
                await _userContext.AddAsync(new User()
                {
                    Username = username,
                    Password = _encoder.EncodeUserPassword(password),
                    RegistrationDate = DateTime.Now
                });
                await _userContext.CommitAsync();

                return await _userContext.Query().SingleAsync(x => x.Username == username);
            }
            catch //TODO
            {
                return null;
            }
        }

        public async Task<string> GetTestString()
        {
            var user = new User()
            {
                Username = "TestUser",
                Password = "qwerty123",
                RegistrationDate = DateTime.Now
            };
            await _userContext.AddAsync(user);
            await _userContext.CommitAsync();
            var newUser = await _userContext.Query().SingleAsync(x => x.Username == user.Username);
            return newUser.Id.ToString();

            //var asd1 = new View1() { Obj1 = "Response! " };
            //await Task.Delay(100);



            //return _mapper.Map<View1, View2>(asd1).Obj1;
        }
    }
}
