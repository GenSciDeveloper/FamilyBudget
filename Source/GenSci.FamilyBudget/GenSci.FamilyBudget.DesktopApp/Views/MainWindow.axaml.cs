using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GenSci.FamilyBudget.DesktopApp.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        public TabControl MainTabControl => this.FindControl<TabControl>("mainTabControl");

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            MainWindowRegister.Register(this);
        }
    }
}
