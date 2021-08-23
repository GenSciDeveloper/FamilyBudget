using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSci.FamilyBudget.DesktopApp.ViewModels
{
    public class SummaryControlViewModel : ViewModelBase
    {
        private ObservableCollection<string> _years;

        public SummaryControlViewModel()
        {
            _years = new ObservableCollection<string>();
            fillAllCollections();
        }
        public IReadOnlyList<string> Months => DateTimeFormatInfo.CurrentInfo.MonthNames;

        public ObservableCollection<string> Years => _years;

        public string CurrentMonth => DateTime.Now.ToString("MMMM");

        public string CurrentYear => DateTime.Now.ToString("yyyy");

        private void fillAllCollections()
        {
            fillYearsCollection();
        }

        private void fillYearsCollection()
        {
            _years.Add("2020");
            _years.Add("2021");
        }
    }
}
