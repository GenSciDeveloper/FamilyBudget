using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GenSci.FamilyBudget.DesktopApp.Views.Controls
{
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
