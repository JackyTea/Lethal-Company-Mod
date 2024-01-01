using BepInEx;
using Mod.Patches;
using HarmonyLib;

namespace Mod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class ModBase : BaseUnityPlugin
    {
        private const string modGUID = "Mod";

        private const string modName = "Mod";

        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static ModBase instance;

        void Awake() 
        {
            if(instance == null)
            {
                instance = this;
            }

            harmony.PatchAll(typeof(ModBase));
            harmony.PatchAll(typeof(PlayerControllerBPatch));
        }
    }
}
