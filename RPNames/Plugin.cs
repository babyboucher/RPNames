using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNames
{
    using System;
    using System.Collections.Generic;
    using MEC;
    using Player = Exiled.Events.Handlers.Player;

    public class Plugin : Exiled.API.Features.Plugin<Config>
    {
        public override string Name { get; } = "Rp Names";
        public override string Author { get; } = "Babyboucher20";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(1, 0, 0);
        public override string Prefix { get; } = "RP Names";

        public EventHandlers.EventHandlers PlayerHandlers;

        public override void OnEnabled()
        {
            PlayerHandlers = new EventHandlers.EventHandlers(this);

            Player.ChangingRole +=  PlayerHandlers.OnPlayerChangeRole;


            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.ChangingRole -= PlayerHandlers.OnPlayerChangeRole;

            base.OnDisabled();
        }
    }
}
