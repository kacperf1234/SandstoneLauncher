using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Tests
{
    public class propertyvalueremover_remove_tests
    {
        class SampleClass
        {
            public string Content { get; set; } = string.Empty;
        }
        
        object execute(object instance, object val = null, string propname = "Content")
        {
            PropertyInfo prop = instance.GetType().GetProperty(propname);
            
            PropertyValueRemover remover = new PropertyValueRemover();
            remover.Remove(prop, instance, val);

            return prop.GetValue(instance);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(new SampleClass()));
        }

        [Test]
        public void returns_null()
        {
            Assert.IsNull(execute(new SampleClass()));
        }

        [Test]
        public void returns_setted_new_value()
        {
            const string @new = "Hello World!";
            Assert.AreEqual(@new, execute(new SampleClass(), @new));
        }
    }
}