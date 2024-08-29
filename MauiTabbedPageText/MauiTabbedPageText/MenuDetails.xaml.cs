using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MauiTabbedPageText.MenuDetails;

namespace MauiTabbedPageText
{
    public partial class MenuDetails : ContentPage
    {

        public class MasterPageItem
        {
            public string IconSource { get; set; }
            public Type TargetType { get; set; }
            public string DetailText { get; set; }
            public string Title { get; set; }
        }

        public CollectionView ListView { get { return collectionView; } }

        public MenuDetails()
        {
            InitializeComponent();

            collectionView.ItemsSource = GetItemSource();

            this.BindingContext = this;
        }

        public void ClearSelectedItem()
        {
            collectionView.SelectedItem = null;
        }

        private List<MasterPageItem> GetItemSource()
        {
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = " Home",
                DetailText = " Go Home.",
                TargetType = typeof(MainPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = " TabbedPage",
                DetailText = " View Tabbed Page.",
                TargetType = typeof(TabPage)
            });

            return masterPageItems;
        }
    }
}
