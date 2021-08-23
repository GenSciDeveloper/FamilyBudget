using Avalonia.Controls;
using Avalonia.Media.Imaging;

namespace GenSci.FamilyBudget.DesktopApp.ViewModels
{
    public class TabItemViewModel
    {
        public string Header { get; set; }
        public UserControl TabControl { get; set; }
        public IBitmap Image { get; set; }
        public bool IsEnabled { get; set; } = true;
    }
}
