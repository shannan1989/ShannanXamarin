using Xamarin.Forms;

namespace CodingHard
{
	public static class NumericValidationBehavior
	{
		public static readonly BindableProperty ValidationProperty = BindableProperty.CreateAttached("Validation", typeof(bool), typeof(NumericValidationBehavior), false, propertyChanged: OnValidationChanged);

		public static bool GetValidation(BindableObject bindable)
		{
			return (bool)bindable.GetValue(ValidationProperty);
		}

		public static void SetValidation(BindableObject bindable, bool value)
		{
			bindable.SetValue(ValidationProperty, value);
		}

		static void OnValidationChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var entry = bindable as Entry;
			if (entry == null)
			{
				return;
			}

			bool validation = (bool)newValue;
			if (validation)
			{
				entry.TextChanged += OnEntryTextChanged;
			}
			else {
				entry.TextChanged -= OnEntryTextChanged;
			}
		}

		static void OnEntryTextChanged(object sender, TextChangedEventArgs e)
		{
			double result;
			bool isValid = double.TryParse(e.NewTextValue, out result);
			(sender as Entry).TextColor = isValid ? Color.Default : Color.Red;
		}
	}
}

