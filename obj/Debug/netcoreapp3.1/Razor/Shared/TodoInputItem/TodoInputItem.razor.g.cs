#pragma checksum "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Shared\TodoInputItem\TodoInputItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1abdd254e0d2c7a33b906f5ff366057f088252a5"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoList.Shared.TodoInputItem
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
    public partial class TodoInputItem : TodoInputItemViewModel
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.TodoList.Shared.TodoInputItem.TodoInputItem.TypeInference.CreateMatTextField_0(__builder, 0, 1, 
#nullable restore
#line 4 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Shared\TodoInputItem\TodoInputItem.razor"
                  Placeholder

#line default
#line hidden
#nullable disable
            , 2, 
#nullable restore
#line 6 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Shared\TodoInputItem\TodoInputItem.razor"
           Type

#line default
#line hidden
#nullable disable
            , 3, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Shared\TodoInputItem\TodoInputItem.razor"
                OnFocusedOut

#line default
#line hidden
#nullable disable
            ), 4, 
#nullable restore
#line 8 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Shared\TodoInputItem\TodoInputItem.razor"
            Label

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 9 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Shared\TodoInputItem\TodoInputItem.razor"
              true

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 5 "C:\Users\KimPhillipAying\Documents\Projects\TodoList\Shared\TodoInputItem\TodoInputItem.razor"
                  Value

#line default
#line hidden
#nullable disable
            , 7, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Value = __value, Value)), 8, () => Value);
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.TodoList.Shared.TodoInputItem.TodoInputItem
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.FocusEventArgs> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "PlaceHolder", __arg0);
        __builder.AddAttribute(__seq1, "Type", __arg1);
        __builder.AddAttribute(__seq2, "OnFocusOut", __arg2);
        __builder.AddAttribute(__seq3, "Label", __arg3);
        __builder.AddAttribute(__seq4, "TextArea", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
