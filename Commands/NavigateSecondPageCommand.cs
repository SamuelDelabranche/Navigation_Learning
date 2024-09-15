using Navigation.MVVM.ViewModels;
using Navigation.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation.Commands
{
    public class NavigateSecondPageCommand : RelayCommand
    {
        private readonly NavigationStore _navigationStore;

        public NavigateSecondPageCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new SecondViewModel(_navigationStore);
        }
    }
}
