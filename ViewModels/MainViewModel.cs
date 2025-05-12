using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PayApp.PersonalLibrary;

namespace PayApp.ViewModels;


public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(ToggleIcon))]
    private bool _sideMenuExpanded = true;
    public string ToggleIcon => SideMenuExpanded ? "\uE138" : "\uE13A";
    
    [ObservableProperty] 
    [NotifyPropertyChangedFor(nameof(HomePageIsActive))]
    [NotifyPropertyChangedFor(nameof(OrgPageIsActive))]
    private ViewModelBase _currentPage;
   
    // Allez dans MainVmLib pour introduire des nouvelles pages
    private readonly Dictionary<string, ViewModelBase> _pages = MainPageLib.GetPages();
    
    public bool HomePageIsActive => CurrentPage == _pages["Home"];
    public bool OrgPageIsActive => CurrentPage == _pages["Org"];
    
    
    public MainViewModel()
    {
        CurrentPage = _pages["Home"]; //par défaut 
    }
    //Actions pour les boutons
    [RelayCommand]  private void ToggleSideMenu() => SideMenuExpanded = !SideMenuExpanded;
    [RelayCommand]  private void GoToHome() => CurrentPage = _pages["Home"];
    [RelayCommand]  private void GoToOrgPage() => CurrentPage = _pages["Org"];
    [RelayCommand]  private void EmptyPage() => CurrentPage = _pages["Empty"]; //pour les pages en cours de development
}