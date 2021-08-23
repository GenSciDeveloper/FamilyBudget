using GenSci.FamilyBudget.DesktopApp.Service.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenSci.FamilyBudget.DesktopApp.Service.Contracts
{
    public interface ISpendingDataService
    {
        List<SpendingModel> GetAllSpendingModels();

        void InsertSpending(SpendingModel spendingModel);
        void UpdateSpending(SpendingModel spendingModel);


    }
}
