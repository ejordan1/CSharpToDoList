#pragma checksum "/Users/Guest/Desktop/ToDoList-CSharp/ToDoList/Views/Items/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b0ad53d36cb6ea220b500dc90625a110f9faf65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Index.cshtml", typeof(AspNetCore.Views_Items_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/Guest/Desktop/ToDoList-CSharp/ToDoList/Views/Items/Index.cshtml"
using ToDoList.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b0ad53d36cb6ea220b500dc90625a110f9faf65", @"/Views/Items/Index.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 27, true);
            WriteLiteral("\n<h1>To Do List</h1>\n<ul>\n\n");
            EndContext();
#line 6 "/Users/Guest/Desktop/ToDoList-CSharp/ToDoList/Views/Items/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(76, 47, true);
            WriteLiteral("  <p>You have no items in your to do list!</p>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/ToDoList-CSharp/ToDoList/Views/Items/Index.cshtml"
}

#line default
#line hidden
#line 10 "/Users/Guest/Desktop/ToDoList-CSharp/ToDoList/Views/Items/Index.cshtml"
 if(Model.Count != 0)
{
  

#line default
#line hidden
#line 12 "/Users/Guest/Desktop/ToDoList-CSharp/ToDoList/Views/Items/Index.cshtml"
   foreach (Parcel parcel in Model)
  {

#line default
#line hidden
            BeginContext(189, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(198, 13, false);
#line 14 "/Users/Guest/Desktop/ToDoList-CSharp/ToDoList/Views/Items/Index.cshtml"
   Write(parcel.Volume);

#line default
#line hidden
            EndContext();
            BeginContext(211, 27, true);
            WriteLiteral(" meters cubed</li>\n    <li>");
            EndContext();
            BeginContext(239, 13, false);
#line 15 "/Users/Guest/Desktop/ToDoList-CSharp/ToDoList/Views/Items/Index.cshtml"
   Write(parcel.Weight);

#line default
#line hidden
            EndContext();
            BeginContext(252, 25, true);
            WriteLiteral(" kilograms</li>\n    <li>$");
            EndContext();
            BeginContext(278, 11, false);
#line 16 "/Users/Guest/Desktop/ToDoList-CSharp/ToDoList/Views/Items/Index.cshtml"
    Write(parcel.Cost);

#line default
#line hidden
            EndContext();
            BeginContext(289, 29, true);
            WriteLiteral(" money dollars</li>\n    <br>\n");
            EndContext();
#line 18 "/Users/Guest/Desktop/ToDoList-CSharp/ToDoList/Views/Items/Index.cshtml"
  }

#line default
#line hidden
#line 18 "/Users/Guest/Desktop/ToDoList-CSharp/ToDoList/Views/Items/Index.cshtml"
   
}

#line default
#line hidden
            BeginContext(324, 163, true);
            WriteLiteral("\n</ul>\n<a href=\"/items/new\">Add a new item.</a>\n\n<form action=\"/items/delete\" method=\"post\">\n  <button type=\"submit\" name=\"button\">Clear All Items</button>\n</form>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
