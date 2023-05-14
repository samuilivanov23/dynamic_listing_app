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
    /// Interaction logic for SingleObjectSessionAnalysisSelectionView.xaml
    /// </summary>
    public partial class SingleObjectSessionAnalysisSelectionView : UserControl
    {
        private Dictionary<string, string> propertyNameToHeaderMapping;
        public SingleObjectSessionAnalysisSelectionView()
        {
            InitializeComponent();
            propertyNameToHeaderMapping = new Dictionary<string, string>()
            {
                { "Id", "Id" },
                { "HeartRateMin", "Heart Rate (min)" },
                { "HeartRateMax", "Heart Rate (max)" },
                { "HeartRateAvg", "Heart Rate (avg)" },
                { "PowerAvg", "Power (Avg)" }
            };
        }

        private void OnAutoGeneratingColumn(Object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
            e.Column.Header = this.propertyNameToHeaderMapping[propertyDescriptor.DisplayName];
            var viewModel = (SingleObjectSessionAnalysisListingViewModel)this.DataContext;

            if (!viewModel.SelectedAttributes.Any(x => x.AttributeName == propertyDescriptor.DisplayName))
            {
                e.Cancel = true;
            }
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var sessionAnalysisRow = e.Source as DataGridRow;

            SessionAnalysisObjectFullDetails segmentObjectFullDetailsWindow = new SessionAnalysisObjectFullDetails(sessionAnalysisRow.Item);
            segmentObjectFullDetailsWindow.Show();
        }
    }
}
