using Avalonia.Controls;
using GenSci.FamilyBudget.DesktopApp.UIHelpers;
using GenSci.FamilyBudget.DesktopApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GenSci.FamilyBudget.DesktopApp.Views
{
    public class MainWindowRegister
    {
        private static List<TabItemViewModel> _tabItemViewModels;
        private static TabControlCollection _tabControlCollection = new TabControlCollection();

        public static List<TabItemViewModel> TabItemViewModels => _tabItemViewModels;

        public static void Register()
        {
            IEnumerable<Type>? tabControls  = getControlsForTabs();

            foreach (Type type in tabControls)
            {
                object[] attrs = type.GetCustomAttributes(typeof(TabControlAttribute), false);
                
                foreach (TabControlAttribute attr in attrs)
                {
                    _tabControlCollection.AddTab(attr.TabName, attr.TabIndex, type);
                }
            }

            _tabItemViewModels = _tabControlCollection.GetTabs();
        }

        private static IEnumerable<Type> getControlsForTabs()
        {
            Assembly? assembly = Assembly.GetExecutingAssembly();
            return assembly.GetTypes().Where(t => Attribute.IsDefined(t, typeof(TabControlAttribute)));
        }
    }
}