using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace HybridAnimalsMod;

[BepInAutoPlugin]
public partial class HybridAnimalsTemplatePlugin : BasePlugin
{
    public Harmony Harmony { get; } = new(Id);


    public override void Load()
    {
        Harmony.PatchAll();
    }
}