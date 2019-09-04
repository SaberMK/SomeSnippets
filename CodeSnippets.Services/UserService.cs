using AutoMapper;
using CodeSnippets.Database.Interfaces;
using CodeSnippets.Database.Repositories.Interfaces;
using CodeSnippets.Database.Repositories.M2MMappings.Interfaces;
using CodeSnippets.Entities.Entities;
using CodeSnippets.Entities.Entities.M2MMappings;
using CodeSnippets.Services.Interfaces;
using CodeSnippets.Utils;
using CodeSnippets.Utils.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets.Services
{
    [DependencyInjection(typeof(IUserService), DependencyInjectionScope.Scoped)]
    public class UserService : IUserService
    {
        readonly IMapper _mapper;
        readonly IUserRepository _userRepository;
        readonly IUserPasswordEncoder _encoder;

        ISnippetRepository _snippetRepository;
        ILanguageRepository _languageRepository;
        ISnippetTagRepository _snippetTagRepository;
        ITagRepository _tagRepository;
        public UserService(IMapper mapper, IUserRepository userContext, IUserPasswordEncoder encoder
            , ISnippetRepository snippetRepository, ILanguageRepository languageRepository,
        ISnippetTagRepository snippetTagRepository, ITagRepository tagRepository)
        {
            _mapper = mapper;
            _encoder = encoder;
            _userRepository = userContext;

            _snippetRepository = snippetRepository;
            _languageRepository = languageRepository;
            _snippetRepository = snippetRepository;
            _snippetTagRepository = snippetTagRepository;
            _tagRepository = tagRepository;
        }
        public async Task<bool> IsUserExists(string username)
        {
            var user = await _userRepository.Query().SingleOrDefaultAsync(x => x.Username == username);
            return user != null;   
        }

        public async Task<User> AuthUser(string username, string password)
        {
            try
            {
                return await _userRepository.Query().SingleAsync(x => x.Username == username && x.Password == _encoder.EncodeUserPassword(password));
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
                await _userRepository.AddAsync(new User()
                {
                    Username = username,
                    Password = _encoder.EncodeUserPassword(password),
                    RegistrationDate = DateTime.Now
                });
                await _userRepository.CommitAsync();

                return await _userRepository.Query().SingleAsync(x => x.Username == username);
            }
            catch //TODO
            {
                return null;
            }
        }

        public async Task<string> GetTestString()
        {
            //await _snippetTagRepository.AddAsync(new SnippetTag()
            //{
            // Snippet = _snippetRepository.GetById(2),
            // Tag = _tagRepository.GetById(3)
            //});
            //await _snippetTagRepository.AddAsync(new SnippetTag()
            //{
            //    Snippet = _snippetRepository.GetById(2),
            //    Tag = _tagRepository.GetById(4)
            //});
            //await _snippetTagRepository.CommitAsync();


//            _snippetRepository.Add(new Snippet()
//            {
//                Name = "Hello World on C#",
//             Language = _languageRepository.GetById(1),
//             Author = _userRepository.GetById(1),
//             Description = "A simple hello world application via C#",
//                Code = @"
//// A Hello World! program in C#.
//using System;
//namespace HelloWorld
//{
//    class Hello 
//    {
//        static void Main() 
//        {
//            Console.WriteLine(""Hello World!"");

//            // Keep the console window open in debug mode.
//                Console.WriteLine(""Press any key to exit."");
//            Console.ReadKey();
//        }
//    }
//}
//"
//            });
//            await _snippetRepository.CommitAsync();
            //var user = new User()
            //{
            //    Username = "TestUser",
            //    Password = "qwerty123",
            //    RegistrationDate = DateTime.Now
            //};
            //await _userContext.AddAsync(user);
            //await _userContext.CommitAsync();
            //var newUser = await _userContext.Query().SingleAsync(x => x.Username == user.Username);
            //return newUser.Id.ToString();

            //var asd1 = new View1() { Obj1 = "Response! " };
            //await Task.Delay(100);


            return "))";
            //return _mapper.Map<View1, View2>(asd1).Obj1;
        }
    }
}
