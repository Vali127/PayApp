using System.Collections.Generic;
using PayApp.ViewModels;

namespace PayApp.Data;

public class Pages
{
    public static Dictionary<string, ViewModelBase> GetPages()
    {
        var pages = new Dictionary<string, ViewModelBase>
        {
            { "Empty", new EmptyPageViewModel() },
            { "Home", new HomePageViewModel() },
            { "Org", new OrgPageViewModel() },
            {"Employee",new EmployeePageViewModel()},
            { "Payment", new PaymentPageViewModel() },
            { "Setting", new SettingPageViewModel() }
        };
        
        return pages;
    }
}