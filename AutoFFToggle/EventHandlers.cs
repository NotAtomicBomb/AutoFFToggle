using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Events.Extensions;

namespace AutoFFToggle
{
    public class EventHandlers
    { 
        public void onRoundStart()
        {
            Server.FriendlyFire = false;           
        }

        public void onRoundEnd(EndingRoundEventArgs ev)
        {
            Server.FriendlyFire = true;

        }
    }
}
