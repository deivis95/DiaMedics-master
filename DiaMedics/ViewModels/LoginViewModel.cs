using System;
using System.ComponentModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using DiaMedics.Views;
using Xamarin.Forms;

namespace DiaMedics.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Attributes
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion
        #region Properties
        public String Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        public String Passwd
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }
        public bool IsRemembered
        {
            get;
            set;
        }
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion
        #region Commands
        public ICommand LoginCommand
        {
            get 
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Debes introducir un email.", "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.Passwd))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Debes introducir una contraseña", "Aceptar");
                return;
            }
            this.IsRunning = true;
            this.IsEnabled = false;
            if (this.Email != "user" || this.Passwd != "1234")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert("Error", "Usuario o contraseña incorrecta", "Aceptar");
                this.Passwd = string.Empty;
                return;
            }
            this.IsRunning = false;
            this.IsEnabled = true;

            this.Email = string.Empty;
            this.Passwd = string.Empty;

            //MenuViewModel.GetInstance( = new MenuViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.isEnabled = true;

        }
        #endregion 
    }
}
