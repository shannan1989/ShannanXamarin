using Xamarin.Forms;

namespace CodingHard
{
	public partial class EffectsPage : ContentPage
	{
		public EffectsPage()
		{
			InitializeComponent();

			entry.Effects.Add(Effect.Resolve("Xamarin.BackgroundColorEffect"));
		}
	}
}

