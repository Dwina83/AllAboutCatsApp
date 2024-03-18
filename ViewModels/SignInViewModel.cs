using AllAboutCatsApp.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutCatsApp.ViewModels
{
    internal class SignInViewModel
    {
        private readonly IAlert _alertService;
        private readonly IAuthentication _authenticationService;

        public SignInViewModel(IAlert alertService, IAuthentication authenticationService)
        {
            _alertService = alertService;
            _authenticationService = authenticationService;
        }

        public Command SignInCommand => new Command(async () => await OnClickedSignIn());

        private async Task OnClickedSignIn()
        { 
             
        }
    }
}
