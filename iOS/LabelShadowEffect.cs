using System;
using CodingHard.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("Shannan")]
[assembly: ExportEffect(typeof(LabelShadowEffect), "LabelShadowEffect")]
namespace CodingHard.iOS
{
	public class LabelShadowEffect : PlatformEffect
	{
		protected override void OnAttached()
		{
			try
			{
				Control.Layer.CornerRadius = 5;
				Control.Layer.ShadowColor = Color.Blue.ToCGColor();
				Control.Layer.ShadowOffset = new CoreGraphics.CGSize(5, 5);
				Control.Layer.ShadowOpacity = 1.0f;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Cannot set property on attached control. Error: {0}", ex.Message);
			}
		}

		protected override void OnDetached()
		{

		}
	}
}

