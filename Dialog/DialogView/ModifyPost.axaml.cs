using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Input;
using PayApp.Dialog.DialogViewModel;

namespace PayApp.Dialog.DialogView;

public partial class ModifyPost : Window
{
    public ModifyPost() //constructor du window
    {
        InitializeComponent();
    }
    
    public ModifyPost( Dictionary<string, object?> postInfo) // constructeur personnalisé
    {
        InitializeComponent();
        var vm = new PostViewModel();
        DataContext = vm;
        ( DataContext as PostViewModel )?.PostInfoCommand.Execute(postInfo!);
        vm.ThisWindow = this;
    }
    
    private void InputElementClose_OnPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        Close();
    }
}