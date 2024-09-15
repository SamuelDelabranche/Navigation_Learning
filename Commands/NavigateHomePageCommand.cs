using Navigation.MVVM.ViewModels;
using Navigation.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation.Commands
{
    public class NavigateHomePageCommand : RelayCommand
    {
        private readonly NavigationStore _navigationStore;

        public NavigateHomePageCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new HomeViewModel(_navigationStore);
        }
    }
}
