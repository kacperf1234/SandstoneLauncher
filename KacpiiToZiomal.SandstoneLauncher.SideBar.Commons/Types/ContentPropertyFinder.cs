using System;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types
{
    public class ContentPropertyFinder : IContentPropertyFinder
    {
        public IContentPropertyNameGenerator NameGenerator;
        public IContentPropertyValidator Validator;

        public ContentPropertyFinder(IContentPropertyNameGenerator nameGenerator, IContentPropertyValidator validator)
        {
            NameGenerator = nameGenerator;
            Validator = validator;
        }

        public PropertyInfo FindAndThrowIfDontValid(Type type)
        {
            string name = NameGenerator.GenerateName();
            PropertyInfo propertyInfo = type.GetProperty(name);
            
            if (!Validator.Validate(propertyInfo))
            {
                throw new InvalidOperationException();
            }

            return propertyInfo;
        }
    }
}