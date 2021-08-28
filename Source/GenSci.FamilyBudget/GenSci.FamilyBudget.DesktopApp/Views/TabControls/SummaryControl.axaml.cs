using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GenSci.FamilyBudget.DesktopApp.UIHelpers;

namespace GenSci.FamilyBudget.DesktopApp.Views.Controls
{
    [TabControl("Статистика за месяц", 0)]
    public partial class SummaryControl : UserControl
    {
        public SummaryControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
