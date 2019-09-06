using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeSnippets.Entities.Entities;
using CodeSnippets.Services;
using CodeSnippets.Services.Interfaces;
using CodeSnippets.Utils.Interfaces;
using CodeSnippets.Utils.ResponseCreators;
using CodeSnippets.ViewModels.Request.Snippet;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CodeSnippets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("hah")]
    public class SnippetController : ControllerBase
    {
        readonly IUserService _userService;
        readonly IUserTokenCreator _tokenCreator;
        readonly IResponseCreator _responseCreator;
        readonly ITagService _tagService;
        readonly ISnippetService _snippetService;
        readonly ILanguageService _languageService;

        public SnippetController(IUserService userService, IUserTokenCreator tokenCreator,
            IResponseCreator responseCreator, ITagService tagService,
            ISnippetService snippetService, ILanguageService languageService)
        {
            _userService = userService;
            _tokenCreator = tokenCreator;
            _responseCreator = responseCreator;
            _tagService = tagService;
            _snippetService = snippetService;
            _languageService = languageService;
        }

        [HttpPost]
        [Route("addSnippet")]
        public async Task<ResponseViewModel> AddSnippet([FromBody]AddSnippetViewModel addSnippetViewModel)
        {
            var user = JsonConvert.DeserializeObject<User>(_tokenCreator.DecodeToken(addSnippetViewModel.Token));
            if (user == null)
                return _responseCreator.CreateFailure("Bad user token!");

            var tags = await _tagService.AddOrUpdateTags(addSnippetViewModel.Tags);
            var language = _languageService.GetLanguageByContent(addSnippetViewModel.Language);
            var snippet = await _snippetService.AddSnippet(addSnippetViewModel.Name, addSnippetViewModel.Description,
                                            user, language, tags);
            //await Task.CompletedTask;
            return _responseCreator.CreateSuccess(snippet);
            //return _responseCreator.CreateSuccess("");
        }
    }
}