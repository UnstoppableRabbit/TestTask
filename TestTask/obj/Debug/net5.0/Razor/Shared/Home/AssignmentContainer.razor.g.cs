#pragma checksum "C:\Users\User\Desktop\testovoe\TestTask\TestTask\Shared\Home\AssignmentContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f844279f9d7d23bcfd20cd9f139d3dc4b95059f2"
// <auto-generated/>
#pragma warning disable 1591
namespace TestTask.Shared.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\_Imports.razor"
using TestTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\_Imports.razor"
using TestTask.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\Shared\Home\AssignmentContainer.razor"
using TestTask.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\Shared\Home\AssignmentContainer.razor"
using TestTask.Enums;

#line default
#line hidden
#nullable disable
    public partial class AssignmentContainer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jobs-container");
            __Blazor.TestTask.Shared.Home.AssignmentContainer.TypeInference.CreateCascadingValue_0(__builder, 2, 3, 
#nullable restore
#line 5 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\Shared\Home\AssignmentContainer.razor"
                           this

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __builder2.AddContent(5, 
#nullable restore
#line 6 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\Shared\Home\AssignmentContainer.razor"
         ChildContent

#line default
#line hidden
#nullable disable
                );
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\Shared\Home\AssignmentContainer.razor"
       
    [Parameter]
    public List<AssignmentModel> Assignments { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public EventCallback<AssignmentModel> OnStatusUpdated { get; set; }

    public Model.AssignmentModel CurrentAssignment { get; set; }

    public async Task UpdateAssignmentAsync(AssignmentStatus status)
    {
        var task = Assignments.FirstOrDefault(_ => _.Id.Equals(CurrentAssignment.Id));
        if (task != null)
        {
            task.Status = status;
            await OnStatusUpdated.InvokeAsync(CurrentAssignment);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.TestTask.Shared.Home.AssignmentContainer
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591