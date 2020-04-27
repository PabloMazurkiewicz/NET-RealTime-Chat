#pragma checksum "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\WSDTChat\WSDTChat\Pages\Chat\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c856caa08bf094fcf540a8d0789770c2ad990604"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WSDTChat.Pages.Chat
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\WSDTChat\WSDTChat\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\WSDTChat\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\WSDTChat\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\WSDTChat\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\WSDTChat\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\WSDTChat\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\WSDTChat\WSDTChat\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\WSDTChat\WSDTChat\_Imports.razor"
using WSDTChat.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\WSDTChat\WSDTChat\Pages\Chat\Chat.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\WSDTChat\WSDTChat\Pages\Chat\Chat.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\WSDTChat\WSDTChat\Pages\Chat\Chat.razor"
using WSDTChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\WSDTChat\WSDTChat\Pages\Chat\Chat.razor"
using WSDTChat.Hubs.HubEvent;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\WSDTChat\WSDTChat\Pages\Chat\Chat.razor"
       
    private HubConnection _hubConnection;
    private List<string> _messages = new List<string>();
    private string _userInput;
    private string _messageInput;

    protected override async Task OnInitializedAsync()
    {
        _hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri(ICommonRoutes.CHAT_HUB))
            .Build();

        _hubConnection.On<string, string>(IPublic.RECEIVE_MSG, (user, message) =>
        {
            var encodedMsg = $"{user}: {message}";
            _messages.Add(encodedMsg);
            StateHasChanged();
        });

        await _hubConnection.StartAsync();
    }

    Task Send() =>
        _hubConnection.SendAsync("SendMessage", _userInput, _messageInput);

    public bool IsConnected =>
        _hubConnection.State == HubConnectionState.Connected;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
