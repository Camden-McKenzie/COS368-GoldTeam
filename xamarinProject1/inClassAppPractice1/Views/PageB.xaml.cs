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

            
        }

        void slider_DragStarted(System.Object sender, System.EventArgs e)
        {
            Color color = box.BackgroundColor;
            color = color.Equals(Color.DodgerBlue) ? Color.Firebrick : Color.DodgerBlue;

            box.BackgroundColor = color;
        }
    }
}
