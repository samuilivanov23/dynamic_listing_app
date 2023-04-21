using DynamicObjectListing.Store;
using DynamicObjectListing.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DynamicObjectListing
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;

        public App() 
        {
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new ObjectsAttributesSelectionViewModel(_navigationStore);
            //_navigationStore.CurrentViewModel = new AttributesSelectionViewModel(_navigationStore);

            MainWindow = new MainWindow()
            {
                //DataContext = new ObjectsAttributesSelectionViewModel(_navigationStore)
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
