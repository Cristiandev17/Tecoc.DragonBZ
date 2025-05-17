using System.Reflection;
using System.Resources;

namespace Tecoc.DragonBZ.Helpers
{
   [ContentProperty("Text")]
    public class TextFieldHelper : IMarkupExtension
    {
        private const string ResourceId = "Tecoc.DragonBZ.Resources.AppResource";

        private static readonly Lazy<ResourceManager> resmgr = new (() => new (ResourceId, typeof(TextFieldHelper).GetTypeInfo().Assembly));

        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return default(string);

            var translation = resmgr.Value.GetString(Text, AppResources.Culture);

            if (translation == null)
            {
                translation = Text;
            }

            return translation;
        }

        public static string Get(string key)
        {
            return AppResources.ResourceManager.GetString(key);
        }
    }
}