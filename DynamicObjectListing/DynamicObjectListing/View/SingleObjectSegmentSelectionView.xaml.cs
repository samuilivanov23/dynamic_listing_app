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
    /// Interaction logic for SingleObjectSegmentSelectionView.xaml
    /// </summary>
    public partial class SingleObjectSegmentSelectionView : UserControl
    {
        private Dictionary<string, string> propertyNameToHeaderMapping;
        public SingleObjectSegmentSelectionView()
        {
            InitializeComponent();
            propertyNameToHeaderMapping = new Dictionary<string, string>()
            {
                { "Id", "Id" },
                { "Length", "Length of the Segment (m)" },
                { "BestEffortTimeMinutes", "Best Effor Time (min)" },
                { "StartLocation", "Start Location Name" },
                { "EndLocation", "End Location Name" }
            };
        }

        private void OnAutoGeneratingColumn(Object sender, DataGridAutoGeneratingColumnEventArgs e) 
        {
            PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
            e.Column.Header = this.propertyNameToHeaderMapping[propertyDescriptor.DisplayName];
            var viewModel = (SingleObjectSegmentListingViewModel)this.DataContext;

            if (!viewModel.SelectedAttributes.Any(x => x.AttributeName == propertyDescriptor.DisplayName)) 
            {
                e.Cancel = true;
            }
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e) 
        {
            var segmentRow = e.Source as DataGridRow;

            SegmentObjectFullDetails segmentObjectFullDetailsWindow = new SegmentObjectFullDetails(segmentRow.Item);
            segmentObjectFullDetailsWindow.Show();
        }
    }
}
