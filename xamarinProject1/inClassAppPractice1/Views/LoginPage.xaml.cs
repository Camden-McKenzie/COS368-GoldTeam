using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace inClassAppPractice1.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();


        }

        async void loginButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ManorPage());
        }
    }
}
