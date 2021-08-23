using GenSci.FamilyBudget.DesktopApp.Service.Contracts.Models;
using System.Collections.Generic;

namespace GenSci.FamilyBudget.DesktopApp.ViewModels.ControlViewModels
{
    public interface IBudgetControl
    {
        IEnumerable<SpendingModel> SpendingModels { get; }
        IEnumerable<IncomeModel> IncomeModels { get; }

        void BindCollections(IEnumerable<SpendingModel> spendingModels, IEnumerable<IncomeModel> incomeModels);
    }
}
