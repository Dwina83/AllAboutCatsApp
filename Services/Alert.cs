﻿using AllAboutCatsApp.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutCatsApp.Services
{
    public class Alert : IAlert
    {


        public Task ShowAlertAsync(string title, string message, string cancel = "OK")
        {
            return Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        public Task<bool> ShowConfirmationAsync(string title, string message,string accept = "Yes",  string cancel = "No")
        {
            return (Task<bool>)Application.Current.MainPage.DisplayAlert(title, accept, cancel);
        }

        public void ShowAlert(string title, string message, string cancel = "OK")
        {
            Application.Current.MainPage.Dispatcher.Dispatch(async () => await ShowAlertAsync(title, message, cancel));
        }

        public void ShowConfirmation(string title, string message, Action<bool> callback, string accept = "Yes", string cancel = "No")
        {
            Application.Current.MainPage.Dispatcher.Dispatch(async () =>
            {
                bool answer = await ShowConfirmationAsync(title, message, accept, cancel);
                callback(answer);
            });

        }

    }
}
