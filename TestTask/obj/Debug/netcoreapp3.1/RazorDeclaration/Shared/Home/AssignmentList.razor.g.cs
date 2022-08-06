// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\Shared\Home\AssignmentList.razor"
using TestTask.Enums;

#line default
#line hidden
#nullable disable
    public partial class AssignmentList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\User\Desktop\testovoe\TestTask\TestTask\Shared\Home\AssignmentList.razor"
       
    [CascadingParameter]
    AssignmentContainer Container { get; set; }

    [Parameter]
    public AssignmentStatus Status { get; set; }

    [Parameter]
    public AssignmentStatus[] AllowedStatuses { get; set; }

    List<TestTask.Model.Assignment> Assignments = new List<TestTask.Model.Assignment>();

    string dropClass = string.Empty;

    protected override void OnParametersSet()
    {
        Assignments.Clear();
        Assignments.AddRange(Container.Assignments.Where(_ => _.Status.Equals(Status)));
    }

    private void HandleDragEnter()
    {
        if (Status == Container.CurrentAssignment.Status) return;

        if (AllowedStatuses != null && !AllowedStatuses.Contains(Container.CurrentAssignment.Status))
            dropClass = "no-drop";
        else
            dropClass = "can-drop";
    }

    private async Task HandleDrop()
    {
        dropClass = string.Empty;

        if (AllowedStatuses != null && !AllowedStatuses.Contains(Container.CurrentAssignment.Status))
            return;

        await Container.UpdateAssignmentAsync(Status);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
