#pragma checksum "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97d6c481d0034d49f3772abd1d255ece5e0e55ee"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WSDTChat.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using WSDTChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using WSDTChat.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
using WSDTChat.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
using WSDTChat.Hubs.HubEvent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
using WSDTChat.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
using WSDT.EmojiFilePicker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
using Markdig;

#line default
#line hidden
#nullable disable
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
       
    [CascadingParameter] Task<AuthenticationState> AuthenticationStateTask { get; set; }

    private void AddToMsg(string msg) => ChatService.ChatForm.MessageInput += msg;

    public void AddFiles(List<string> imgUris)
    {
        foreach (string imgUri in imgUris) AddToMsg($"<img src='{imgUri}' alt='Image' class='resizedImg' />");

        ChatService.Send();
        StateHasChanged();
    }

    protected override async Task OnInitializedAsync()
    {
        ChatService.HubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri(ICommonRoutes.CHAT_HUB))
            .Build();


        ChatService.HubConnection.On<string, MsgPriority>(IPublic.SYSTEM_MSG, (message, priority) =>
        {
            var lastMessage = ChatService.AllMessages.LastOrDefault();
            if (lastMessage != null && lastMessage.User.Equals(ChatSystemMsg.SystemUser))
            {
                lastMessage.Messages.Add(message);
            }
            else
            {
                ChatService.AllMessages.Add(new ChatSystemMsg(new List<string> { message }, priority));
            }
        });

        ChatService.HubConnection.On<string, string>(IPublic.RECEIVE_MSG, (user, message) =>
        {
            var chatUser = JsonSerializer.Deserialize<ChatUser>(user);
            var lastMessage = ChatService.AllMessages.LastOrDefault();
            if (lastMessage != null && lastMessage.User.Equals(chatUser))
            {
                // If last message has been written by the same user, add it to the last chatMsg-obj
                lastMessage.Messages.Add(message);
            }
            else
            {
                // other user typed msg
                ChatService.AllMessages.Add(
                            new ChatMsg(chatUser, new List<string> { message })
                        );
            }

            StateHasChanged();
        });

        await ChatService.HubConnection.StartAsync();
        await SetUsernameIfLoggedIn();
        await ChatService.Join(); // notify other chat members about new chatter
    }

    public async Task SetUsernameIfLoggedIn()
    {
        var authState = await AuthenticationStateTask;
        var user = authState.User;
        if (user.Identity.IsAuthenticated)
        {
            ChatService.ChatForm.CurrentUser.EMail = user.Identity.Name;
        }
        ChatService.ChatForm.CurrentUser.IsGuest = !user.Identity.IsAuthenticated;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WSDTChat.Services.IChatService ChatService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
