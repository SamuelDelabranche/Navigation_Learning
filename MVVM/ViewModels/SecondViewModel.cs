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
    public class SecondViewModel : ViewModelBase
    {
        public RelayCommand NavigateHomePageCommand { get; }

        public SecondViewModel(NavigationStore navigationStore)
        {
            NavigateHomePageCommand = new NavigateHomePageCommand(navigationStore);
        }
    }
}
