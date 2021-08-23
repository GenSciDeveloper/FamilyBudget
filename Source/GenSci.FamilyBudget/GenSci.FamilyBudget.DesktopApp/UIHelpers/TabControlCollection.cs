using System;
using System.Collections.Generic;
using Avalonia.Controls;
using GenSci.FamilyBudget.DesktopApp.ViewModels;

namespace GenSci.FamilyBudget.DesktopApp.UIHelpers
{
    public class TabControlCollection
    {
        private List<TabItemViewModel> _tabItems = new List<TabItemViewModel>();

        public List<TabItemViewModel> GetTabs()
        {
            return _tabItems;
        }

        public void AddTab(string tabName, int tabIndex, Type type)
        {
            TabItemViewModel itemViewModel = getItemViewModeL(tabName, tabIndex, type);
            _tabItems.Add(itemViewModel);
        }

        private TabItemViewModel getItemViewModeL(string tabName, int tabIndex, Type type)
        {
            return new TabItemViewModel
            {
                Header = tabName,
                TabControl = getControlInstance(type)
            };
        }

        private UserControl getControlInstance(Type type)
        {
            UserControl control = (UserControl)Activator.CreateInstance(type)!;
            control.DataContext = getControlViewModel(type);
            return control;
        }

        private ViewModelBase getControlViewModel(Type type)
        {
            string? name = type.FullName!.Replace("Views.Controls", "ViewModels") + "ViewModel";
            Type? viewModelType = Type.GetType(name);

            if (viewModelType == null)
                throw new InvalidOperationException($"Отсутствует модель представления для {type.FullName}");

            return (ViewModelBase)Activator.CreateInstance(viewModelType)!;
        }
    }
}
