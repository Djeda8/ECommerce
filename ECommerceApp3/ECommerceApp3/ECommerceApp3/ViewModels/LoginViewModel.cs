using ECommerceApp3.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ECommerceApp3.ViewModels
{
    public class LoginViewModel
    {
        #region Attributes
        private NavigationService navigationServices;
        private DialogService dialogtionServices;
        #endregion

        #region Properties
        public string User { get; set; }

        public string Password { get; set; }

        public bool IsRemembered { get; set; }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            navigationServices = new NavigationService();
            dialogtionServices = new DialogService();
            IsRemembered = true;
        } 
        #endregion

        #region Commands
        public ICommand LoginCommand { get { return new RelayCommand(Login); } }

        private async void Login()
        {
            if (string.IsNullOrEmpty(User))
            {
                await dialogtionServices.ShowMessage("Error", "Debes ingresar un usuario");
                return;
            }
            if (string.IsNullOrEmpty(Password))
            {
                await dialogtionServices.ShowMessage("Error", "Debes ingresar una contraseña");
                return;
            }

            navigationServices.SetMainPage();
        } 
        #endregion
    }
}
