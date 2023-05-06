using DynamicObjectListing.InstantiationManager;
using DynamicObjectListing.Store;
using DynamicObjectListing.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.Command
{
    public class ReturnToObjectSelectionCommand : BaseCommand
    {
        private readonly NavigationStore _navigationStore;

        public ReturnToObjectSelectionCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new ObjectsAttributesSelectionViewModel(_navigationStore);
        }
    }
}
