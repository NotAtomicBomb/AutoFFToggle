using System;
using Exiled.API.Features;
using Exiled.Events;
using Exiled.API.Extensions;

namespace AutoFFToggle
{
    public class AutoFFToggle : Plugin<Configs>
    {
        public EventHandlers eh;
        public override string Name => "AutoFFToggle by Kognity";

        public override void OnDisabled()
        {
			if (!Config.IsEnabled)
			{
				return;
			}


			Exiled.Events.Handlers.Server.RoundStarted -= eh.onRoundStart;
           Exiled.Events.Handlers.Server.RoundEnded -= eh.onRoundEnd;
            eh = null;
        }

        public override void OnEnabled()
        {
		

			if (!Config.IsEnabled)
			{
				Log.Info("AutoFFToggle Disabled");
				return;
			}

			eh = new EventHandlers();
            Exiled.Events.Handlers.Server.RoundStarted += eh.onRoundStart;
            Exiled.Events.Handlers.Server.EndingRound += eh.onRoundEnd;
            Log.Info("AutoFFToggle enabled");
		}

        public override void OnReloaded()
        {
            
        }
    }
}
