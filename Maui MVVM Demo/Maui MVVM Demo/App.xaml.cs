using Maui_MVVM_Demo.Pages;

namespace Maui_MVVM_Demo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           var navigationPage = new NavigationPage(new EmployeeListPage());
           navigationPage.BarBackgroundColor = Color.FromRgba("#000000");
           MainPage = navigationPage;
        }
    }
}