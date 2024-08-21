using System;



namespace MauiHamburgerTest
{
    public partial class AboutPage : ContentPage
    { 
        public AboutPage()
        {
            InitializeComponent();
            
            this.BindingContext = this;

            lbVersion.Text = "Version: ";
        }

    }
}
