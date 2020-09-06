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

        [Description("Should Class-D be D-#### (true) or should it follow the other names with Title + Name (false)?")]
        public bool DboisSetting { get; set; } = true;

        [Description("Should SCPs have their SCP as a name (true) or should they be hidden as a D-Class (false)?")]
        public bool SCPSetting { get; set; } = true;

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

        //[Description("A dictionary with classes and a list of all the names they can have")]
        //public Array HumanNames { get; set; } = new string[] { "Hyde", "Hood", "Hull", "Hogan", "Hitchens", "Higgins", "Hodder", "Huxx", "Hester", "King", "Kubiak", "Koker", "Kerrigan", "Kumara", "Knox", "Koufax", "Keagan", "Kestrel", "Future", "Fitzpatrick", "Fontana", "Fenner", "Furyk", "Finch", "Fullbright", "Fassbinder", "Flood", "Fong", "E.Gold", "Fleetwood", "Fugger", "Frost", "Fsik", "Fawcett", "Fishman", "Freeze", "Fissolo", "Foley", "Fairchild", "Freeman", "Decker", "Dobermann", "Dunlop", "Dumont", "Dandridge", "Diamond", "Cyrus", "Craggs", "Crisper", "Cotheran", "Curry", "Conard", "Cutler", "Coggins", "Cates", "Crisp", "Curio", "Murray", "Morrison", "McKay", "Merchant", "Murillo", "Mooney", "Murdock", "Matisse", "Massey", "McGee", "Minter", "Munson", "Oswald", "Ortega", "Ogle", "Orr", "Ogden", "Onassis", "Olson", "Ollenrenshaw", "Silver", "Small", "Stoneking", "Sweeney", "Surrett", "Swiatek", "Sloane", "Stapleton", "Seibert", "Stroud", "Strode", "Stockton", "Bright", "Miller", "Simarded", "Whix", "Tombstone", "Cimmerian", "Conwell", "Clef", "Gears", "Kiryu", "Heiden", "Lloyd", "Marlowe", "Sorts", "Xyank", "Anborough", "LaFerrier", "Iceberg", "Kondraki", "Eskobar", "Anderson", "Ambrose", "Baudin", "Belitrov", "Chao", "Blackwood", "Fitzroy", "Silberescher", "Aktus", "Diaghilev", "Winchell", "Winters", "Walsh", "Whalen", "Watson", "Wooster", "Woodson", "Winthrop", "Wall", "Wight", "Webb", "Woodard", "Wixx", "Wong", "Whesker", "Wolfenstein", "Winchester", "Wire", "Wolf", "Wheeler", "Warrick", "Walcott", "Wilde", "Wexler", "Wells", "Weeks", "Wainright", "Wallace", "Weaver", "Wagner", "Wadd", "Withers", "Whitby", "Woodland", "Woody", "Warren", "Race", "Rooney", "Russo", "Rude", "Roland", "Reader", "Renshaw", "Rossi", "Riddle", "Ripa", "Richter", "Rosenberg", "Romo", "Ramirez", "Reagan", "Rainwater", "Romirez", "Riker", "Riggs", "Redman", "Reinhart", "Redgrave", "Rafferty", "Rigby", "Roman", "Reece", "Abawi", "Allard", "Adara", "Abbott", "Acampora", "Ackerman", "Ackroyd", "Abbington", "Axworthy", "Ainge", "Abernathy", "Atkinson", "Abner", "Abella", "Agholor", "Allred", "Asola", "Abrams", "Acker", "Abrell", "Acuff", "Archer", "Asterio", "Adair", "Albright", "Adelson", "Atwood", "Aguillar", "Adler", "Arrowood", "Arora" };
    }
}