#pragma checksum "C:\Users\User\Desktop\testovoe\TestTask\TestTask\Shared\Modal\AddAssignmentModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08a725db0b09e2ac1f376a4e7c51be6159004489"
// <auto-generated/>
#pragma warning disable 1591
namespace TestTask.Shared.Modal
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
#line 1 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\Shared\Modal\AddAssignmentModal.razor"
using TestTask.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\Shared\Modal\AddAssignmentModal.razor"
using TestTask.Enums;

#line default
#line hidden
#nullable disable
    public partial class AddAssignmentModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "customModal");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-group");
            __builder.AddMarkupContent(4, "<label for=\"formGroupExampleInput1\">Название</label>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "id", "formGroupExampleInput1");
            __builder.AddAttribute(9, "placeholder", "Введите название");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\Shared\Modal\AddAssignmentModal.razor"
                                                             Assignment.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Assignment.Title = __value, Assignment.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "<label for=\"formGroupExampleInput2\">Описание</label>\r\n        ");
            __builder.OpenElement(16, "textarea");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "id", "formGroupExampleInput2");
            __builder.AddAttribute(19, "style", "resize: none;");
            __builder.AddAttribute(20, "placeholder", "Опишите задачу");
            __builder.AddAttribute(21, "rows", "3");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\Shared\Modal\AddAssignmentModal.razor"
                                                                                 Assignment.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Assignment.Description = __value, Assignment.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "submit");
            __builder.AddAttribute(27, "class", "btn btn-primary");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\Shared\Modal\AddAssignmentModal.razor"
                                                            AddNewAssignment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "Добавить");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\Shared\Modal\AddAssignmentModal.razor"
       
    [Parameter]
    public EventCallback<AssignmentModel> AddAssignment { get; set; }

    [Parameter]
    public AssignmentStatus Status { get; set; }

    [CascadingParameter]
    BlazoredModalInstance ModalInstance { get; set; }

    AssignmentModel Assignment;

    protected override void OnInitialized()
    {
        Assignment = new AssignmentModel() { Id = Guid.NewGuid(), Status = this.Status };
    }

    public async Task AddNewAssignment()
    {
        await AddAssignment.InvokeAsync(Assignment);
        await ModalInstance.CloseAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591