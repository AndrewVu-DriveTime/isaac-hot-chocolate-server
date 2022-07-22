using Models;

namespace Resolvers;

public class Subscription
{
    [Topic]
    [Subscribe]
    public Event SubscribeEvent([EventMessage] Event @event)
    {
        return @event;
    }
}