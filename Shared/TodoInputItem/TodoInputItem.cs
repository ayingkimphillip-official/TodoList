using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TodoList.Models;
using TodoList.Services;


namespace TodoList.Shared
{
    public class TodoInputItemViewModel : ComponentBase
    {
        [Inject]
        protected AppStateService AppStateService { get; set; }
        [Parameter]
        public string Placeholder { get; set; }

        [Parameter]
        public string Value { get; set; }

        [Parameter]
        public EventCallback<string> ValueChanged { get; set; }

        [Parameter]
        public string Type { get; set; } = "text";

        [Parameter]
        public string Label { get; set; }

        protected void OnFocusedOut(FocusEventArgs e)
        {
            AppStateService.TodoItem = Value;
            StateHasChanged();
            Value = string.Empty;
        }
    }
}