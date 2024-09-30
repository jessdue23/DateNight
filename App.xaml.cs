using DateNight.Models;
namespace DateNight;

public partial class App : Application
{
    //bring model into this page
    public static DateCalculator dateCalc;
    
    public App()
    {
        InitializeComponent();
        dateCalc = new DateCalculator();
        
        MainPage = new AppShell();
    }
}