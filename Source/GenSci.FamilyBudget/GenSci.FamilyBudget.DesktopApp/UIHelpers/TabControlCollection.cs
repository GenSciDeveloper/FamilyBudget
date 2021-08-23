using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSci.FamilyBudget.DesktopApp.UIHelpers
{
    public class TabControlCollection
    {
        private List<TabItem> _tabItems = new List<TabItem>();

        public void AddTab(TabItem tabItem)
        {
            _tabItems.Add(tabItem);
        }

        public IEnumerable<TabItem> GetTabs()
        {
            return _tabItems;
        }
    }
}
