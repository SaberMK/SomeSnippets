using CodeSnippets.Utils.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSnippets.Utils.ResponseCreators
{
    public class ResponseCreator<T> : IResponseCreator<T> where T: class
    {
        public string Create(T viewModel, int error)
        {
            var response = new ResponseCreatorModel(error, JsonConvert.SerializeObject(viewModel));
            return JsonConvert.SerializeObject(response);
        }

        public class ResponseCreatorModel
        {
            public ResponseCreatorModel(int error, string response)
            {
                Error = error;
                Response = response;
            }
            public int Error { get; set; }
            public string Response { get; set; }
        }
    }
}
