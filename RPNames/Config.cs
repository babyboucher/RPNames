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

        [Description("A dictionary with non SCP classes and their title")]
        public Dictionary<string, string> ClassTitles { get; set; } = new Dictionary<string, string>
        {
            {
                "ClassD", "D-"
            },
            {
                "Scientist", "Dr."
            },
            {
                "FacilityGuard", "Security Officer "
            },
            {
                "NtfCommander", "Commander "
            },
            {
                "NtfCadet", "Cadet "
            },
            {
                "NtfLieutenant", "Lieutenant "
            },
            {
                "NtfScientist", "Field Agent "
            },
            {
                "ChaosInsurgency", "Agent of Chaos "
            },
        };

        [Description("A dictionary with SCPs and their title")]
        public Dictionary<string, string> SCPNames { get; set; } = new Dictionary<string, string>
        {
            {
                "Scp049", "SCP-049"
            },
            {
                "Scp0492", "SCP-049-2"
            },
            {
                "Scp079", "SCP-079 "
            },
            {
                "Scp096", "SCP-096"
            },
            {
                "Scp106", "SCP-106"
            },
            {
                "Scp173", "SCP-173"
            },
            {
                "Scp93953", "SCP-939-53 "
            },
            {
                "Scp93989", "SCP-939-89"
            },
        };
        [Description("The list of names to be given. (Leave empty for default, if you want to make your own list, look at readme) ")]
        public List<string> HumanNames { get; set; } = new List<string> { };
    }
}