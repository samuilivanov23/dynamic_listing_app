using DynamicObjectListing.InstantiationManager;
using DynamicObjectListing.Model;
using DynamicObjectListing.Store;
using DynamicObjectListing.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.Command
{
    public class ReturnToAttributesSelectionCommand : BaseCommand
    {
        private readonly NavigationStore _navigationStore;
        private readonly IBaseModel _currentModelUsed;

        public ReturnToAttributesSelectionCommand(NavigationStore navigationStore, IBaseModel currentModelUsed)
        {
            _navigationStore = navigationStore;
            _currentModelUsed = currentModelUsed;
        }

        public override void Execute(object? parameter)
        {
            var objectToDisplayModel = _currentModelUsed;
            var objectToDisplayAllAttributes = this._currentModelUsed.GetType().GetProperties().Select(property => property.Name).ToList();

            _navigationStore.CurrentViewModel = new AttributesSelectionViewModel(_navigationStore, objectToDisplayAllAttributes, objectToDisplayModel);
        }
    }
}
