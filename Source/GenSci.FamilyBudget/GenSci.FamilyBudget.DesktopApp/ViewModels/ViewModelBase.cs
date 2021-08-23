using GenSci.FamilyBudget.DesktopApp.Service.Contracts.Models;
using GenSci.FamilyBudget.DesktopApp.ViewModels.ControlViewModels;
using ReactiveUI;
using System.Collections.Generic;

namespace GenSci.FamilyBudget.DesktopApp.ViewModels
{
    public abstract class ViewModelBase : ReactiveObject, IBudgetControl
    {
        protected IEnumerable<SpendingModel> _spendingModels;
        protected IEnumerable<IncomeModel> _incomeModels;

        public IEnumerable<SpendingModel> SpendingModels => _spendingModels;
        public IEnumerable<IncomeModel> IncomeModels => _incomeModels;

        public void BindCollections(IEnumerable<SpendingModel> spendingModels, IEnumerable<IncomeModel> incomeModels)
        {
            _spendingModels = spendingModels;
            _incomeModels = incomeModels;
        }
    }
}
