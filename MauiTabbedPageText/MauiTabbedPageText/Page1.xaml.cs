using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiTabbedPageText
{
    public partial class Page1 : ContentPage
    {
        public class Data : INotifyPropertyChanged
        {
            private string _Text;
            public string Text
            {
                get { return _Text; }
                set { _Text = value; OnPropertyChanged(); }
            }
            private string _Detail;
            public string Detail
            {
                get { return _Detail; }
                set { _Detail = value; OnPropertyChanged(); }
            }

            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged([CallerMemberName] string propName = null)
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private ObservableCollection<Data> _MyData;
        public ObservableCollection<Data> MyData
        {
            get { return _MyData; }
            set { _MyData = value; OnPropertyChanged(); }
        }

        public Page1()
        {
            InitializeComponent();

            this.BindingContext = this;
            this.Appearing += (s, ea) => { PageAppearing(); };
        }

        private void PageAppearing()
        {
            LoadPageData();
        }

        public void LoadPageData()
        {
            var data = new ObservableCollection<Data>();
            data.Add(new Data() { Text = "Name", Detail = "Unknown" });
            data.Add(new Data() { Text = "Address", Detail = "Unknown" });
            data.Add(new Data() { Text = "Home Phone", Detail = "Unknown" });

            MyData = data;
        }
    }
}