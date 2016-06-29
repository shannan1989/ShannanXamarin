using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CodingHard
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();


		}

		async void SignUp_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SignUpPage());
		}

		async void Login_Clicked(object sender, EventArgs e)
		{
			var user = new User()
			{
				Username = username.Text.Trim(),
				Password = password.Text.Trim()
			};


		}
	}
}

