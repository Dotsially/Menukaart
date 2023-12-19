using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Menukaart.DataManagement.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menukaart.ViewModel
{
    public partial class SessionInfoPageViewModel
    {
        
        public SessionInfoPageViewModel() 
        {
            
        }

        [RelayCommand]
        Task Back() => Shell.Current.GoToAsync("..");
    }
}
