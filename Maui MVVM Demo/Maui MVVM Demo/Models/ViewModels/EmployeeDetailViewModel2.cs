using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_MVVM_Demo.Models.ViewModels
{
    internal partial class EmployeeDetailViewModel2 : ObservableObject
    {
        [ObservableProperty]
        private Employee employeee; 
    }
}
