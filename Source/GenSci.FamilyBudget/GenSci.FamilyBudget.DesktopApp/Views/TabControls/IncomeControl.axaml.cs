using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GenSci.FamilyBudget.DesktopApp.UIHelpers;

namespace GenSci.FamilyBudget.DesktopApp.Views.Controls
{
    [TabControl("Доходы", 1)]
    public partial class IncomeControl : UserControl
    {
        public IncomeControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
