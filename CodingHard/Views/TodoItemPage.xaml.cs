using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CodingHard
{
	public partial class TodoItemPage : ContentPage
	{
		bool _isNew;

		public TodoItemPage(bool isNew = false)
		{
			InitializeComponent();
			_isNew = isNew;
		}
	}
}

