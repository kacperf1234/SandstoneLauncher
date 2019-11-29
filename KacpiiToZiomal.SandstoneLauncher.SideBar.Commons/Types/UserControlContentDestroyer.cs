using System;
using System.Reflection;
using System.Windows.Controls;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types
{
    public class UserControlContentDestroyer : IUserControlContentDestroyer
    {
        public IContentPropertyFinder PropertyFinder;
        public IPropertyValueRemover ValueRemover;

        public UserControlContentDestroyer(IContentPropertyFinder propertyFinder, IPropertyValueRemover valueRemover, IContentPropertyValidator validator)
        {
            PropertyFinder = propertyFinder;
            ValueRemover = valueRemover;
        }

        public UserControlContentDestroyer()
        {
            
        }

        public void Destroy(UserControl userControl)
        {
            userControl.Content = null;
        }

        public void Destroy(Type type, object o)
        {
            PropertyInfo propertyInfo = PropertyFinder.FindAndThrowIfDontValid(type);
            ValueRemover.Remove(propertyInfo, o);
        }
    }
}