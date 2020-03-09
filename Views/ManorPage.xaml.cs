using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace inClassAppPractice1.Views
{
    public partial class ManorPage : ContentPage
    {
        public ManorPage()
        {
            InitializeComponent();
        }

        async void logoutButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());

        }

        async void aButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PageA());

        }

        async void bButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PageB());

        }

        async void cButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PageC());

        }

        async void dButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PageD());

        }
    }
}
