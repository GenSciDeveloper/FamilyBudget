using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using GenSci.FamilyBudget.DesktopApp.ViewModels;
using GenSci.FamilyBudget.DesktopApp.Views;
using GenSci.FamilyBudget.DesktopApp.Views.Controls;

namespace GenSci.FamilyBudget.DesktopApp
{
    public class App : Application
    {
        MainWindowRegister _mainWindowRegister = new MainWindowRegister();

        public override void Initialize()
        {
            MainWindowRegister.Register();
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(MainWindowRegister.TabItemViewModels)
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
