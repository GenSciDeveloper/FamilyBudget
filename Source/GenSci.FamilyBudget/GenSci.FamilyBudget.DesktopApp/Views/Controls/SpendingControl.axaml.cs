using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GenSci.FamilyBudget.DesktopApp.Views.Controls
{
    public partial class SpendingControl : UserControl
    {
        public SpendingControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
