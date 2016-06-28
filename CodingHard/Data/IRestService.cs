using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingHard
{
	public interface IRestService
	{
		Task<List<TodoItem>> RefreshDataAsync();

		Task SaveTodoItemAsync(TodoItem item, bool isNewItem);

		Task DeleteTodoItemAsync(string id);
	}
}

