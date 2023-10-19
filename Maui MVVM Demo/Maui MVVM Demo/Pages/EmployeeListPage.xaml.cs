using Maui_MVVM_Demo.Models;
using Maui_MVVM_Demo.Models.ViewModels;

namespace Maui_MVVM_Demo.Pages;

public partial class EmployeeListPage : ContentPage
{
	public EmployeeListPage()
	{
		InitializeComponent();

		BindingContext = new EmployeesViewModel();
	}

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		var employee = (Employee)e.Item;
		var employeeDetailViewModel2 = new EmployeeDetailViewModel2 { Employeee = employee };
		var employeeDetailPage = new EmployeeDetailPage();
		employeeDetailPage.BindingContext = employeeDetailViewModel2;

		Navigation.PushAsync(employeeDetailPage);

    }
}