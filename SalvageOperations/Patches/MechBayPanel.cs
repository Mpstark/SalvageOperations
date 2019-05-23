using BattleTech.UI;
using Harmony;
using UnityEngine;

namespace SalvageOperations.Patches
{
    [HarmonyPatch(typeof(MechBayPanel), "ViewMechStorage")]
    public class MechBayPanel_ViewMechStorage_Patch
    {
        public static bool Prefix()
        {
            // if Storage is shift-clicked, force assembly checking
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                Main.GlobalBuild();
                return false;
            }

            return true;
        }
    } 
}