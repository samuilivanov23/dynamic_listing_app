using DynamicObjectListing.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.Store
{
    public class NavigationStore
    {
        private BaseViewModel? _currentViewModel;
        public BaseViewModel CurrentViewModel 
        {
            get => _currentViewModel;
            set 
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        private List<string> _objectToDisplayAllAttributes;

        public List<string> ObjectToDisplayAllAttributes;

        public NavigationStore() 
        {
            ObjectToDisplayAllAttributes = new List<string>();
        }

        public event Action CurrentViewModelChanged;
        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
