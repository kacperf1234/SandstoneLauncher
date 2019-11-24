using System.Windows.Controls;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types
{
    public class UserControlContentProvider : IUserControlContentProvider
    {
        public IUserControlActivator Activator;
        public IUserControlContentDestroyer ContentDestroyer;
        public IUserControlContentExtractor Extractor;
        public IUserControlInitializer Initializer;

        public UserControlContentProvider(IUserControlContentExtractor extractor, IUserControlActivator activator,
            IUserControlInitializer initializer, IUserControlContentDestroyer contentDestroyer)
        {
            Extractor = extractor;
            Activator = activator;
            Initializer = initializer;
            ContentDestroyer = contentDestroyer;
        }

        public object ProvideContent<T>() where T : UserControl
        {
            UserControl userControl = Activator.Activate<T>();
            Initializer.Initialize(userControl);
            object content = Extractor.ExtractContent(userControl);
            ContentDestroyer.Destroy(userControl);

            return content;
        }
    }
}