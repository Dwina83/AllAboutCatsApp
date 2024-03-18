using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutCatsApp.Contract
{
    internal interface IAuthentication
    {
         bool IsAuthenticated(string username, string password);
    }
}
