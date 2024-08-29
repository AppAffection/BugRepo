using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace MauiTabbedPageText
{
    public partial class MenuPage : FlyoutPage
    {
        public class FlyoutPageItem
        {
            public string Title { get; set; }
            public string IconSource { get; set; }
            public Type TargetType { get; set; }
        }

        public MenuPage()
        {
            InitializeComponent();

            flyoutMenuPage.ListView.SelectionChanged += OnSelectionChanged;
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var item = e.CurrentSelection.FirstOrDefault() as MenuDetails.MasterPageItem;

                //WHY IS THIS NOT WORKING?!?!?! 
                ((CollectionView)sender).SelectedItem = null;
                flyoutMenuPage.ClearSelectedItem();

                if (item != null)
                {
                    flyoutMenuPage.ListView.SelectedItem = null;

                    if (item.Title == " Home")
                    {
                        NavigationPage np = new NavigationPage(new MainPage());
                        Detail = np;
                        Title = item.Title;
                        IsPresented = false;
                    }
                    else if (item.Title == " TabbedPage")
                    {
                        NavigationPage np = (NavigationPage)this.Detail;
                        await np.PushAsync(new TabPage());
                        IsPresented = false;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
