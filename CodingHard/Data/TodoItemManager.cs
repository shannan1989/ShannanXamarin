using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingHard
{
	public class TodoItemManager
	{
		IRestService _restService;

		public TodoItemManager(IRestService service)
		{
			_restService = service;
		}

		public Task<List<TodoItem>> GetTasksAsync()
		{
			return _restService.RefreshDataAsync();
		}

		public Task SaveTaskAsync(TodoItem item, bool isNewItem = false)
		{
			return _restService.SaveTodoItemAsync(item, isNewItem);
		}

		public Task DeleteTaskAsync(TodoItem item)
		{
			return _restService.DeleteTodoItemAsync(item.Id);
		}

	}
}

