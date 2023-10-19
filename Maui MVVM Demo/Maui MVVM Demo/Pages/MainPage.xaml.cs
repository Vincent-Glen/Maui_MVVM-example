using Maui_MVVM_Demo.Models.ViewModels;

namespace Maui_MVVM_Demo.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void employeeButton1_Clicked(object sender, EventArgs e)
    {
        //var employeeDetailviewmodel = new EmployeeDetailViewModel2
        //{
            //EmployeeId = "1001",
            //EmployeeName = "Joe Mama",
            //Email = "joemama@gmail.com",
            //IsPartTimer = true
        //};
        //var employeeDetailPage = new EmployeeDetailPage();
        //employeeDetailPage.BindingContext = employeeDetailviewmodel;
        //Navigation.PushAsync(employeeDetailPage);
    }

    private void employeeButton2_Clicked(object sender, EventArgs e)
    {
       // var employeeDetailviewmodel = new EmployeeDetailViewModel2
        //{
           // EmployeeId = "1002",
           // EmployeeName = "Ben Dover",
           // Email = "BenDover@gmail.com",
           // IsPartTimer = false
        //};
        //var employeeDetailPage = new EmployeeDetailPage();
        //employeeDetailPage.BindingContext = employeeDetailviewmodel;
        //Navigation.PushAsync(employeeDetailPage);
    }

    private void employeeButton3_Clicked(object sender, EventArgs e)
    {
        //var employeeDetailviewmodel = new EmployeeDetailViewModel2
       // {
         //   EmployeeId = "1003",
          //  EmployeeName = "Mike Hunt",
          //  Email = "MikeHunta@gmail.com",
          //  IsPartTimer = true
        //};
        //var employeeDetailPage = new EmployeeDetailPage();
        //employeeDetailPage.BindingContext = employeeDetailviewmodel;
        //Navigation.PushAsync(employeeDetailPage);
    }
}