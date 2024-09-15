using Navigation.Commands;
using Navigation.Core;
using Navigation.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation.MVVM.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public RelayCommand NavigateSecondPageCommand { get; }

        public HomeViewModel(NavigationStore navigationStore) 
        {
            NavigateSecondPageCommand = new NavigateCommand<SecondViewModel>(navigationStore, () => new SecondViewModel(navigationStore));
        }
    }
}
