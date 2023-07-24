using Foundation;
using MessageAutoRead.Customrenderer;
using MessageAutoRead.iOS.Customrenderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AutoFillControl), typeof(AutoFillRenderer))]
namespace MessageAutoRead.iOS.Customrenderer
{
    public class AutoFillRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                Control.TextContentType = UITextContentType.OneTimeCode;
            }
        }
    }
}