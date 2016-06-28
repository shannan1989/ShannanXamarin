using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CodingHard
{
	public partial class TodoListPage : ContentPage
	{
		public TodoListPage()
		{
			InitializeComponent();
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();

			listView.ItemsSource = await App.TaskManager.GetTasksAsync();
		}

		void AddItem_Clicked(object sender, EventArgs e)
		{
			var todoItem = new TodoItem() { Id = Guid.NewGuid().ToString() };
			var todoPage = new TodoItemPage(true);
			todoPage.BindingContext = todoItem;
			Navigation.PushAsync(todoPage);
		}

		void Tasks_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var todoItem = e.SelectedItem as TodoItem;
			var todoPage = new TodoItemPage();
			todoPage.BindingContext = todoItem;
			Navigation.PushAsync(todoPage);
		}
	}
}

