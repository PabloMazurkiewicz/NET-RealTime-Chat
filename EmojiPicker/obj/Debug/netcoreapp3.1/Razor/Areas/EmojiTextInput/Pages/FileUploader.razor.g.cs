#pragma checksum "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "331784395b4ddad6581dd356eff30fce1497db93"
// <auto-generated/>
#pragma warning disable 1591
namespace EmojiPicker.Areas.EmojiTextInput.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    public partial class FileUploader : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "style");
            __builder.AddMarkupContent(1, "\r\n    .");
            __builder.AddContent(2, 
#nullable restore
#line 10 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor"
      dropTargetClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, " {\r\n        display: block;\r\n        padding: 20px;\r\n        margin-bottom: 10px;\r\n        border: 1px dashed black;\r\n        border-radius: 5px;\r\n        position: relative;\r\n    }\r\n    .");
            __builder.AddContent(4, 
#nullable restore
#line 18 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor"
      dropTargetDragClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, @" {
        border-color: orangered;
        font-weight: bold;
    }
    input.clickable {
        position: absolute;
        width: 100%;
        height: 100%;
        opacity: 0;
        margin-top: -20px;
        margin-left: -20px;
        cursor: pointer;
    }
");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", 
#nullable restore
#line 33 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor"
             IpDropClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "file");
            __builder.AddAttribute(12, "class", "clickable");
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor"
                      OnInputChange

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ondragenter", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor"
                        OnIpDragEnter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ondragleave", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor"
                        OnIpDragLeave

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "multiple", true);
            __builder.AddElementReferenceCapture(17, (__value) => {
#nullable restore
#line 36 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor"
                dropTargetInput = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    Drop Files here or click me.\r\n\r\n");
#nullable restore
#line 43 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor"
     foreach (var fileInfo in IpFileList)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "        <br>");
            __builder.AddContent(20, 
#nullable restore
#line 45 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor"
               fileInfo.Name

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 45 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor"
                            
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\FileUploader.razor"
       
    [Parameter] public string FileUploadRoute { get; set; }
    [Parameter] public Action<List<string>> AddImages { get; set; }

    ElementReference dropTargetInput;
    IFileReaderRef ipReference;

    const string dropTargetDragClass = "droptarget-drag";
    const string dropTargetClass = "droptarget";

    private List<string> _ipdropClasses = new List<string>() { dropTargetClass };

    string IpDropClass => string.Join(" ", _ipdropClasses);

    List<IFileInfo> IpFileList { get; } = new List<IFileInfo>();

    protected override void OnAfterRender(bool isFirstRender)
    {
        if (isFirstRender)
        {
            ipReference = fileReaderService.CreateReference(dropTargetInput);
        }
    }

    public void OnIpDragEnter(EventArgs e)
    {
        _ipdropClasses.Add(dropTargetDragClass);
    }

    public void OnIpDragLeave(EventArgs e)
    {
        _ipdropClasses.Remove(dropTargetDragClass);
    }

    public async Task OnInputChange(EventArgs e)
    {
        _ipdropClasses.Remove(dropTargetDragClass);
        this.StateHasChanged();
        await this.RefreshIpFileList();
    }

    private Task RefreshIpFileList()
    {
        return RefreshFileList(ipReference, IpFileList);
    }

    private async Task RefreshFileList(IFileReaderRef reader, List<IFileInfo> list)
    {
        list.Clear();
        foreach (var file in await reader.EnumerateFilesAsync())
        {
            var fileInfo = await file.ReadFileInfoAsync();
            list.Add(fileInfo);
        }
        // this.StateHasChanged();
        await ReadFile(ipReference);
    }

    public async Task ReadFile(IFileReaderRef list)
    {
        this.StateHasChanged();
        var nl = Environment.NewLine;
        var fileList = await list.EnumerateFilesAsync();
        var imgUriList = new List<string>();

        foreach (var file in fileList)
        {
            var fileInfo = await file.ReadFileInfoAsync();
            this.StateHasChanged();

            using (var fs = await file.OpenReadAsync())
            {
                var bufferSize = fs.Length; // 20480
                var buffer = new byte[bufferSize];
                int count;
                while ((count = await fs.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    imgUriList.Add(await UploadFile(buffer));

                    this.StateHasChanged();
                }
            }
            this.StateHasChanged();
        }

        this.AddImages(imgUriList);
    }

    private async Task<string> UploadFile(byte[] img)
    {
        Console.WriteLine("Post to: " + FileUploadRoute);

        var resp = await Http.PostAsync(FileUploadRoute, new ByteArrayContent(img));
        var fileName = await resp.Content.ReadAsStringAsync();
        return fileName;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReaderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
