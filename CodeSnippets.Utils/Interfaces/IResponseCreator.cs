using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSnippets.Utils.Interfaces
{
    public interface IResponseCreator<T> where T : class
    {
        string Create(T viewModel, int error);
    }
}
