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
    /// Interaction logic for SingleObjectAthleteSelectionView.xaml
    /// </summary>
    public partial class SingleObjectAthleteSelectionView : UserControl
    {
        public SingleObjectAthleteSelectionView()
        {
            InitializeComponent();
        }

        private void OnAutoGeneratingColumn(Object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
            e.Column.Header = propertyDescriptor.DisplayName;
            var viewModel = (SingleObjectAthleteListingViewModel)this.DataContext;

            if (!viewModel.SelectedAttributes.Any(x => x.AttributeName == propertyDescriptor.DisplayName))
            {
                e.Cancel = true;
            }
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var athleteRow = e.Source as DataGridRow;

            AthleteObjectFullDetails athleteObjectFullDetailsWindow = new AthleteObjectFullDetails(athleteRow.Item);
            athleteObjectFullDetailsWindow.Show();
        }
    }
}
