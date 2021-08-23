using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GenSci.FamilyBudget.DesktopApp.UIHelpers;

namespace GenSci.FamilyBudget.DesktopApp.Views.Controls
{
    [TabControl("Расходы", 2)]
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
