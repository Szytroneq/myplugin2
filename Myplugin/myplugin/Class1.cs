using Exiled.API.Features;
using Exiled.Loader;
using player = Exiled.Events.Handlers.Player;

namespace myplugin
{
    public class Class1 : Plugin<Config>
    {
        public static Class1 Instance;
        public override void OnEnabled()
        {
            Instance = this;
            player.Dying += EventHandlers.deathbroad.OnPlayerDeath;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Instance = null;
            player.Dying -= EventHandlers.deathbroad.OnPlayerDeath;
            base.OnDisabled();
        }
    }
}
