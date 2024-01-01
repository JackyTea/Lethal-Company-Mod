using GameNetcodeStuff;
using HarmonyLib;

namespace Mod.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void mod(ref float ___sprintMeter, ref float ___movementSpeed, ref float ___sprintMultiplier, ref float ___jumpForce, ref float ___health)
        {
            ___movementSpeed = 10f;
            ___sprintMeter = 1f;
            ___sprintMultiplier = 3f;
            ___jumpForce = 25f;
            ___health = 9000f;
        }
    }
}
