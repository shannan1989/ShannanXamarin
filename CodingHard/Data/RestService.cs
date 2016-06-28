using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace CodingHard
{
	public class RestService : IRestService
	{
		HttpClient client;
		public List<TodoItem> Items
		{
			get;
			private set;
		}

		public RestService()
		{
			var authData = string.Format("{0}:{1}", Constants.Username, Constants.Password);
			var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));

			client = new HttpClient();
			client.MaxResponseContentBufferSize = 256000;
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
		}

		public async Task<List<TodoItem>> RefreshDataAsync()
		{
			Items = new List<TodoItem>();

			try
			{
				var uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
				var response = await client.GetAsync(uri);
				if (response.IsSuccessStatusCode)
				{
					var content = await response.Content.ReadAsStringAsync();
					Items = JsonConvert.DeserializeObject<List<TodoItem>>(content);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Error {0}", ex.Message);
			}

			return Items;
		}

		public async Task SaveTodoItemAsync(TodoItem item, bool isNewItem = false)
		{
			try
			{
				var uri = new Uri(string.Format(Constants.RestUrl, item.Id));
				var json = JsonConvert.SerializeObject(item);
				var content = new StringContent(json, Encoding.UTF8, "application/json");

				HttpResponseMessage response = null;
				if (isNewItem)
				{
					response = await client.PostAsync(uri, content);
				}
				else {
					response = await client.PutAsync(uri, content);
				}

				if (response.IsSuccessStatusCode)
				{
					Debug.WriteLine("TodoItem saved");
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Error {0}", ex.Message);
			}
		}

		public async Task DeleteTodoItemAsync(string id)
		{
			try
			{
				var uri = new Uri(string.Format(Constants.RestUrl, id));
				var response = await client.DeleteAsync(uri);

				if (response.IsSuccessStatusCode)
				{
					Debug.WriteLine("TodoItem deleted");
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Error {0}", ex.Message);
			}
		}
	}
}

