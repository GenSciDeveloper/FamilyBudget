using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GenSci.FamilyBudget.DesktopApp.Views.Controls
{
    public partial class FinanceBannerControl : UserControl
    {
        public FinanceBannerControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
