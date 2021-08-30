using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using Scp914;

namespace RPNames
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Should people lose nick when made into a tutorial?")]
        public bool TutorialNick { get; set; } = true;

        [Description("Should Class-D be D-#### (true) or should it follow the other names with Title + Name (false)?")]
        public bool DboisSetting { get; set; } = true;

        [Description("Should SCPs have their SCP as a name (true) or should they be hidden as a D-Class (false)?")]
        public bool SCPSetting { get; set; } = true;

        [Description("Should nicknames reset on death?")]
        public bool DeathReset { get; set; } = false;

        [Description("Should a player be told their nickname?")]
        public bool ShowNick { get; set; } = true;

        [Description("Should a player have there real name after their nickname?")]
        public bool ShowRealName { get; set; } = false;

        [Description("A dictionary with classes and their title")]
        public Dictionary<RoleType, string> ClassTitles { get; set; } = new Dictionary<RoleType, string>
        {
            {
                RoleType.ClassD, "D-"
            },
            {
                RoleType.Scientist, "Dr."
            },
            {
                RoleType.FacilityGuard, "Security Officer "
            },
            {
                RoleType.NtfCaptain, "Commander "
            },
            {
                RoleType.NtfPrivate, "Cadet "
            },
            {
                RoleType.NtfSergeant, "Lieutenant "
            },
            {
                RoleType.NtfSpecialist, "Field Agent "
            },
            {
                RoleType.ChaosConscript, "Agent of Chaos "
            },
            {
                RoleType.Scp049, "SCP-049 "
            },
            {
                RoleType.Scp0492, "SCP-049-2 "
            },
            {
                RoleType.Scp079, "SCP-079 "
            },
            {
                RoleType.Scp096, "SCP-096 "
            },
            {
                RoleType.Scp106, "SCP-106 "
            },
            {
                RoleType.Scp173, "SCP-173 "
            },
            {
                RoleType.Scp93953, "SCP-939-53 "
            },
            {
                RoleType.Scp93989, "SCP-939-89 "
            },
        };

        [Description("The list of names to be given. (Leave empty for default, if you want to make your own list, look at readme) ")]
        public List<string> HumanNames { get; set; } = new List<string> { };
    }
}