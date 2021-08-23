using Avalonia.Controls;
using GenSci.FamilyBudget.DesktopApp.UIHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GenSci.FamilyBudget.DesktopApp.Views
{
    public class MainWindowRegister
    {

        public static void Register(MainWindow mainWindow)
        {
            IEnumerable<Type>? tabControls  = getControlsForTabs();

            //mainWindow.MainTabControl
        }

        private static IEnumerable<Type> getControlsForTabs()
        {
            Assembly? assembly = Assembly.GetExecutingAssembly();
            return assembly.GetTypes().Where(t => Attribute.IsDefined(t, typeof(TabControlAttribute)));
        }
    }
}