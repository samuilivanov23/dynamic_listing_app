using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace DynamicObjectListing.CustomWindow
{
    /// <summary>
    /// Interaction logic for SegmentObjectFullDetails.xaml
    /// </summary>
    public partial class SegmentObjectFullDetails : Window
    {
        public SegmentObjectFullDetails(object segment)
        {
            InitializeComponent();

            DataContext = segment;
        }
    }
}
