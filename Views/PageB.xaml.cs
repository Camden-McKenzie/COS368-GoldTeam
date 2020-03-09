using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace inClassAppPractice1.Views
{
    public partial class PageB : ContentPage
    {
        public PageB()
        {
            InitializeComponent();
        }

        void slider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            textLabel.Rotation = value;

            box.BackgroundColor = Color.FromRgb(0, (value/360), 0);
        }


    }
}
