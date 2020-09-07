namespace RPNames.EventHandlers
{
    using Exiled.API.Features;
    using Exiled.Events.EventArgs;
    using System;
    using System.Collections.Generic;

    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        Random random = new Random();
        public void OnPlayerChangeRole(ChangingRoleEventArgs ev)
        {
            if (plugin.Config.ClassTitles.ContainsKey(ev.NewRole.ToString()))
            {
                Random random = new Random();
                int RandomNameNumber = random.Next(1, plugin.Config.HumanNames.Count-1);
                ev.Player.DisplayNickname = plugin.Config.ClassTitles[ev.NewRole.ToString()] + plugin.Config.HumanNames[(RandomNameNumber)];
            }
            if (plugin.Config.SCPSetting )
            {
                if (plugin.Config.SCPNames.ContainsKey(ev.NewRole.ToString()))
                {
                    ev.Player.DisplayNickname = plugin.Config.SCPNames[ev.NewRole.ToString()];
                }
            }
            else
            {
                if (!plugin.Config.DboisSetting)
                {
                    int RandomNameNumber = random.Next(1, plugin.Config.HumanNames.Count - 1);
                    ev.Player.DisplayNickname = plugin.Config.ClassTitles[ev.NewRole.ToString()] + plugin.Config.HumanNames[RandomNameNumber];
                }
                else
                {
                    int DclassNumber = random.Next(1000, 9999);
                    ev.Player.DisplayNickname = ("D-" + DclassNumber.ToString());
                }
            }
            if (ev.NewRole == RoleType.ClassD)
            {
                if (plugin.Config.DboisSetting)
                {
                    int DclassNumber = random.Next(1000, 9999);
                    ev.Player.DisplayNickname = ("D-" + DclassNumber.ToString());
                }
                
            }
            if (ev.NewRole == RoleType.Tutorial)
            {
                if (plugin.Config.TutorialNick)
                {
                    ev.Player.DisplayNickname = null;
                }
            }
        }
        public void OnPlayerDeath(DiedEventArgs ev)
        {
            if (plugin.Config.DeathReset == true)
            {
                ev.Target.DisplayNickname = null;
            }
        }
    }
}
