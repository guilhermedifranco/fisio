using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace HamburgerMenu.ExtensionMarkup
{
    class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrEmpty(ResourceId))
                return null;


            return ImageSource.FromResource(ResourceId);
        }
    }
}
