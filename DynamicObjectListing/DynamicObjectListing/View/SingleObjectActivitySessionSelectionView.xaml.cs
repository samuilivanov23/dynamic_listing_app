using DynamicObjectListing.CustomWindow;
using DynamicObjectListing.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DynamicObjectListing.View
{
    /// <summary>
    /// Interaction logic for SingleObjectActivitySessionSelectionView.xaml
    /// </summary>
    public partial class SingleObjectActivitySessionSelectionView : UserControl
    {
        public SingleObjectActivitySessionSelectionView()
        {
            InitializeComponent();
        }

        private void OnAutoGeneratingColumn(Object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
            e.Column.Header = propertyDescriptor.DisplayName;
            var viewModel = (SingleObjectActivitySessionListingViewModel)this.DataContext;

            if (!viewModel.SelectedAttributes.Any(x => x.AttributeName == propertyDescriptor.DisplayName))
            {
                e.Cancel = true;
            }
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var activitySessionRow = e.Source as DataGridRow;

            ActivitySessionObjectFullData activitySessionObjectFullDetailsWindow = new ActivitySessionObjectFullData(activitySessionRow.Item);
            activitySessionObjectFullDetailsWindow.Show();
        }
    }
}
