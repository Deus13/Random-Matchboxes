
using System;
using System.IO;
using System.Reflection;
using JsonModSettings;
using ModSettings;

namespace randomMatchboxes
{
    internal class randomMatchboxesSettings : JsonModSettingsBase<randomMatchboxesSettings>
    {

        
        [Name("Chance for full Matchbox")]
        [Description("The chance to find a full Matchbox.")]
        [Slider(0, 1f)]
        public float ChanceFull = 0.5f;


        
        [Name("Size of full Matchbox")]
        [Description("How much Matches are in a full Box. (1=Vanilla) ")]
        [Slider(0, 3f)]
        public float SizeFull = 2f;


        [Name("Max size of a open Matchbox")]
        [Description("How much Matches are in a full Box. (1=Vanilla) ")]
        [Slider(0, 3f)]
        public float SizeOpen = 2f;






        public static void OnLoad()
        {
            Instance = JsonModSettingsLoader.Load<randomMatchboxesSettings>();
        }
    }
}
