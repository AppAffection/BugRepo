
using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;
using System.Windows.Input;

namespace MauiHamburgerTest
{
    public partial class MenuPage : FlyoutPage //, INotifyPropertyChanged
    {

        public Boolean bShowMessages = true;

        public MenuPage()
        {
            InitializeComponent();
            flyoutMenuPage.ListView.SelectionChanged += OnSelectionChanged;
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = e.CurrentSelection.FirstOrDefault() as MenuDetails.MasterPageItem;
            if (item != null)
            {
                flyoutMenuPage.ListView.SelectedItem = null;
                if (item.Title == " About")
                {
                    NavigationPage np = (NavigationPage)this.Detail;
                    await np.PushAsync(new AboutPage());
                    IsPresented = false;
                }
            }
        }

        public class FlyoutPageItem
        {
            public string Title { get; set; }
            public string IconSource { get; set; }
            public Type TargetType { get; set; }
        }
    }
}
