using System;

namespace GenSci.FamilyBudget.DesktopApp.UIHelpers
{
    public class TabControlAttribute : Attribute
    {
        private readonly string _tabName;
        private readonly int _tabIndex;

        public TabControlAttribute(string tabName, int tabIndex)
        {
            if (tabName is null)
                throw new ArgumentNullException(nameof(tabName));

            _tabName = tabName;
            _tabIndex = tabIndex;
        }

        public string TabName => _tabName;
        public int TabIndex => _tabIndex;
    }
}
