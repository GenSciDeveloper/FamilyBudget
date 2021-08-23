using GenSci.FamilyBudget.DesktopApp.Service.Contracts.Models;
using GenSci.FamilyBudget.DesktopApp.ViewModels.ControlViewModels;
using ReactiveUI;
using System.Collections.Generic;

namespace GenSci.FamilyBudget.DesktopApp.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        public List<TabItemViewModel> Tabs { get; private set; }

        public MainWindowViewModel(List<TabItemViewModel> tabItemViewModels)
        {
            Tabs = tabItemViewModels;

            bindAllControls();
        }

        private void bindAllControls()
        {
            var spendingModels = new List<SpendingModel>();
            var incomeModels = new List<IncomeModel>();

            foreach (TabItemViewModel itemViewModel in Tabs)
            {
                IBudgetControl? budgetControl = (IBudgetControl)itemViewModel.TabControl.DataContext!;
                budgetControl.BindCollections(spendingModels, incomeModels);
            }
        }
    }
}
