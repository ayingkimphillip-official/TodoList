using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using TodoList.Services;
using TodoList.Models;

namespace TodoList.Pages
{
	public class TodoViewModel : ComponentBase
	{
		[Inject]
		protected AppStateService AppStateService { get; set; }

		protected IList<TodoItem> List = new List<TodoItem>();

		protected string NewItem { get; set; } = string.Empty;

		protected override void OnInitialized()
        {
			base.OnInitialized();
        }

		protected override async Task OnAfterRenderAsync(bool firstRender)
        {
			if (firstRender)
				AppStateService.PropertyChanged += OnAppStatePropertyChanged;
			await base.OnAfterRenderAsync(firstRender);
        }

		protected async void OnAppStatePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
			await InvokeAsync(StateHasChanged);
        }

		protected void AddItem()
		{
			NewItem = AppStateService.TodoItem;
			if (!string.IsNullOrWhiteSpace(NewItem))
			{
				List.Add(new TodoItem { Title = NewItem });
				NewItem = string.Empty;
			}
		}

		public void Dispose()
        {
			AppStateService.PropertyChanged -= OnAppStatePropertyChanged;
		}
	}
}