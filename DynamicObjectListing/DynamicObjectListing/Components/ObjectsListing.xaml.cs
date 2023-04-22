using DynamicObjectListing.InstantiationManager;
using DynamicObjectListing.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for ObjectsListing.xaml
    /// </summary>
    public partial class ObjectsListing : UserControl
    {
        public ObjectsListing()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(objectListToDisplay.SelectedItem);

            var types = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass && t.Namespace == "DynamicObjectListing.InstantiationManager")
                .ToList();

            var typeToTest = "segments";

            foreach(var type in types) 
            {
                if (type.GetInterfaces().Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(ICreator<>))) 
                {
                    var newInstance = Activator.CreateInstance(type);

                    var canHandleMethod = type.GetMethod(nameof(AthleteCreator.CanHandle));

                    bool canHandleResult = (bool)canHandleMethod.Invoke(newInstance, new object[] { typeToTest });

                    if (canHandleResult) 
                    {
                        Console.WriteLine($"Found class that can handle type \"{typeToTest}\": {newInstance.GetType().FullName}");

                        var createMethod = type.GetMethod(nameof(AthleteCreator.Create));
                        var objectToDisplay = createMethod.Invoke(newInstance, new object[] { });

                        break;
                    }
                }
            }
        }
    }
}
