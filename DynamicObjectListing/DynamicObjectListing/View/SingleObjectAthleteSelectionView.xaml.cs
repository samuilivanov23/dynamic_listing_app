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
        private Dictionary<string, string> propertyNameToHeaderMapping;
        public SingleObjectAthleteSelectionView()
        {
            InitializeComponent();
            propertyNameToHeaderMapping = new Dictionary<string, string>()
            {
                { "Id", "Id" },
                { "FirstName", "First Name" },
                { "MiddleName", "Middle Name" },
                { "LastName", "Last Name" },
                { "ActivitiesCount", "Activities Count" },
                { "Following", "Following (count)" },
                { "Followers", "Followers (count)" }
            };
        }

        private void OnAutoGeneratingColumn(Object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
            e.Column.Header = this.propertyNameToHeaderMapping[propertyDescriptor.DisplayName];
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
