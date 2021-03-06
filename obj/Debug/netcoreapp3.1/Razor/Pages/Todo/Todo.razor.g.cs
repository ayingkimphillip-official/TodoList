#pragma checksum "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Pages\Todo\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b90397de10140a7345d43b9006b04cc2a6f4a558"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoList.Pages.Todo
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\_Imports.razor"
using TodoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\_Imports.razor"
using TodoList.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\_Imports.razor"
using TodoList.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Pages\Todo\Todo.razor"
using TodoList.Shared.TodoInputItem;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : TodoViewModel
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "To Do List! (");
            __builder.AddContent(2, 
#nullable restore
#line 7 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Pages\Todo\Todo.razor"
                  List.Count(item => item.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<TodoList.Shared.TodoInputItem.TodoInputItem>(5);
            __builder.AddAttribute(6, "Placeholder", "Add things to do...");
            __builder.AddAttribute(7, "Label", "Enter Todo Item here");
            __builder.AddAttribute(8, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Pages\Todo\Todo.razor"
                                                                                      NewItem

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Pages\Todo\Todo.razor"
                  AddItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Add item");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "ul");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 12 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Pages\Todo\Todo.razor"
     foreach(var item in List)
	{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "\t\t");
            __builder.OpenElement(17, "li");
            __builder.AddMarkupContent(18, "\r\n\t\t\t");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "checkbox");
            __builder.AddAttribute(21, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Pages\Todo\Todo.razor"
                                           item.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.IsDone = __value, item.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\t\t\t");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Pages\Todo\Todo.razor"
                           item.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.Title = __value, item.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 18 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Pages\Todo\Todo.razor"
	}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
