using Avalonia.Controls;
using Avalonia.Controls.Templates;
using GenSci.FamilyBudget.DesktopApp.ViewModels;
using System;

namespace GenSci.FamilyBudget.DesktopApp
{
    public class ViewLocator : IDataTemplate
    {
        public bool SupportsRecycling => false;

        public IControl Build(object data)
        {
            string? name = data.GetType().FullName!.Replace("ViewModel", string.Empty);
            Type? type = Type.GetType(name);

            if (type != null)
            {
                return (Control)Activator.CreateInstance(type)!;
            }
            else
            {
                return new TextBlock { Text = "Not Found: " + name };
            }
        }

        public bool Match(object data)
        {
            return data is ViewModelBase;
        }
    }
}
