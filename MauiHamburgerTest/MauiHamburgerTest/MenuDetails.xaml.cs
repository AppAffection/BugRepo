using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHamburgerTest
{
    public partial class MenuDetails : ContentPage
    {

        public CollectionView ListView { get { return collectionView; } }

        public MenuDetails()
        {
            InitializeComponent();

            collectionView.ItemsSource = GetItemSource();

            this.BindingContext = this;
        }

        private List<MasterPageItem> GetItemSource()
        {
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = " Home",
                IconSource = "Home.png",
                DetailText = "Your Home Page"
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = " Schedule",
                IconSource = "Schedule.png",
                DetailText = "Your Schedule"
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = " Settings",
                IconSource = "Settings.png",
                DetailText = "Set theme and data preferences."
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = " About",
                IconSource = "Help.png",
                DetailText = "About Us",
                TargetType = typeof(AboutPage)
            });

            return masterPageItems;
        }

        public class MasterPageItem
        {
            public string IconSource { get; set; }
            public Type TargetType { get; set; }
            public string DetailText { get; set; }
            public string Title { get; set; }
        }

    }
}
