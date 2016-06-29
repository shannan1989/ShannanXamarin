using System;
using CodingHard.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

//[assembly: ResolutionGroupName("Shannan")]
[assembly: ExportEffect(typeof(BackgroundColorEffect), "BackgroundColorEffect")]
namespace CodingHard.iOS
{
	public class BackgroundColorEffect : PlatformEffect
	{

		protected override void OnAttached()
		{
			try
			{
				//Control.BackgroundColor = new UIColor.FromRGB(204, 153, 255);
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

