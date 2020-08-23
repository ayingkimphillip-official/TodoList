using System;
using Microsoft.AspNetCore.Components;

namespace TodoList.Pages.Todo
{
	public class TodoViewModel : ComponentBase
	{
		protected string TodoItem { get; set; } = string.Empty;

		protected string NewItem { get; set; }

		public void AddTodoItem()
		{
			if (!string.IsNullOrWhiteSpace(TodoItem))
			{
				NewItem = TodoItem;
				TodoItem = string.Empty;
			}
		}
	}
}