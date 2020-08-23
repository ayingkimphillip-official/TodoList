using System;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components.Web;

namespace TodoList.Shared.Todo
{
	public class OngoingListViewModel : ComponentBase
	{
		protected bool Complete { get; set; } = false;

		protected bool Delete { get; set; } = false;

		[Parameter]
		public string NewItem { get; set; }

		protected List<string> ItemList = new List<string>();

		protected int Count { get; set; } = 0;



	}
}