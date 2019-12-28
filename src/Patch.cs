using Harmony;
using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace randomMatchboxes
{

    [HarmonyPatch(typeof(GearItem), "Awake", null)]
    public class GearItem_Awake
    {
        private static void Postfix(GearItem __instance)
        {

            var setting = randomMatchboxesSettings.Instance;
            string text = __instance.name;
            text = text.ToLower();
            if (text.Contains("matches"))
            {
                if (UnityEngine.Random.Range(0f, 1f) < setting.ChanceFull) __instance.m_StackableItem.m_Units = (int)(setting.SizeFull* __instance.m_StackableItem.m_Units);
                else __instance.m_StackableItem.m_Units = (int)(UnityEngine.Random.Range(0f, setting.SizeOpen) * __instance.m_StackableItem.m_Units);
            }
        }
    }

}
