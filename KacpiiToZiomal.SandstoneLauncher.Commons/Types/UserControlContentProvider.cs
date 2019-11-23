using System.Windows.Controls;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class UserControlContentProvider : IUserControlContentProvider
    {
        public IUserControlContentExtractor Extractor;
        public IUserControlActivator Activator;
        public IUserControlInitializer Initializer;
        public IUserControlContentDestroyer ContentDestroyer;

        public UserControlContentProvider(IUserControlContentExtractor extractor, IUserControlActivator activator, IUserControlInitializer initializer, IUserControlContentDestroyer contentDestroyer)
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
            object content = Extractor.ExtractContent();
            ContentDestroyer.Destroy(userControl);
            
            return content;
        }
    }
}