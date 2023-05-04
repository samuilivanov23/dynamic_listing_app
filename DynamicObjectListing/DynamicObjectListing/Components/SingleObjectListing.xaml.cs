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

namespace DynamicObjectListing.Components
{
    /// <summary>
    /// Interaction logic for SingleObjectListing.xaml
    /// </summary>
    public partial class SingleObjectListing : UserControl
    {
        public SingleObjectListing()
        {
            InitializeComponent();
            //Console.WriteLine(SingleObjectListingGrid);
            //Console.WriteLine((SingleObjectListingViewModel)this.DataContext);

            //var viewModel = (SingleObjectListingViewModel)this.DataContext;
            //int x = 0;
            //foreach (var signleObjectItem in viewModel.SelectedAttributes) 
            //{
            //    SingleObjectListingGrid.Columns.Add(new DataGridTextColumn() { Header = "Activity", Binding = new Binding("SelectedAttributes["+x+ "].AttributeName") });
            //    x++;
            //}
        }

        //private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e) 
        //{
        //    //Console.WriteLine(SingleObjectListingGrid);
        //    //Console.WriteLine((SingleObjectListingViewModel)this.DataContext);

        //    //var viewModel = (SingleObjectListingViewModel)this.DataContext;
        //    //int x = 0;
        //    //foreach (var signleObjectItem in viewModel.SelectedAttributes)
        //    //{
        //    //    SingleObjectListingGrid.Columns.Add(new DataGridTextColumn() { Header = "Activity", Binding = new Binding("SelectedAttributes[" + x + "].AttributeName") });
        //    //    x++;
        //    //}

        //    PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
        //    e.Column.Header = propertyDescriptor.DisplayName;
        //}
    }
}
