using HotChocolate.Subscriptions;
using Microsoft.AspNetCore.Mvc;
using Models;
using Resolvers;

namespace dotnet_test.Controllers;

[ApiController]
public class WebhookController: ControllerBase
{
    private ITopicEventSender _sender;
    public WebhookController(ITopicEventSender sender)
    {
        this._sender = sender;
    }
    
    [Route("docusign")]
    [HttpPost]
    public async Task<string> docusignWebHook(string data)
    {
         await _sender.SendAsync(nameof(Subscription.SubscribeEvent), new Event() {Message = data});
        return data;
    }
}