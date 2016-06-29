using System;
using CodingHard.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

//[assembly: ResolutionGroupName("Shannan")]
[assembly: ExportEffect(typeof(BackgroundColorEffect), "BackgroundColorEffect")]
namespace CodingHard.Droid
{
	public class BackgroundColorEffect : PlatformEffect
	{
		protected override void OnAttached()
		{
			try
			{
				Control.SetBackgroundColor(Android.Graphics.Color.LightGreen);
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

