using Exiled.Events.EventArgs.Player;
using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myplugin.EventHandlers
{
    public static class deathbroad
    {
        public static void OnPlayerDeath(DyingEventArgs ev)
        {
            if (ev.Player.IsHuman)
            {
                // powiadomienie gdy człowiek umrze
                Map.Broadcast(3, $"{ev.Player.Nickname} has died!");
            }
            else
            {
                // powiadomienie gdy nie człowiek umrze
                Map.Broadcast(3, $"A non-human entity has died!");
            }
        }
    }
}
