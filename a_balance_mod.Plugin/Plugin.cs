using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using TrainworksReloaded.Core;
using TrainworksReloaded.Core.Extensions;

namespace a_balance_mod.Plugin
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        internal static new ManualLogSource Logger = new(MyPluginInfo.PLUGIN_GUID);
        
        // Plugin startup logic. This function is automatically called when your plugin initializes
        public void Awake()
        {
            Logger = base.Logger;

            var builder = Railhead.GetBuilder();
            builder.Configure(
                MyPluginInfo.PLUGIN_GUID,
                c =>
                {
                    // Be sure to include any new json files if you add more.
                    c.AddMergedJsonFile(
                        "json/global.json",
                        //"json/units/greeddragon.json",
                        "json/units/monstereelgorgon.json",
                        "json/spells/hallowedhalls.json",
                        "json/spells/hoarfrosteffigy.json",
                        "json/spells/dantesinferno.json",
                        "json/spells/iceandpyre.json",
                        "json/spells/rootseeds.json",
                        "json/units/shadowsiege.json",
                        "json/units/monstershadowsiege.json",
                        "json/units/monstermorselmaster.json",
                        "json/units/draff.json",
                        "json/units/guardoftheunnamed.json",
                        "json/units/monsteranimusofwill.json",
                        "json/champions/wyldentenstranglertwo.json",
                        "json/champions/wyldentenstranglerthree.json"
                    );
                }
            );

            Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

            // Uncomment if you need Harmony Patch support.
            //var harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
            //harmony.PatchAll();

        }
    }
}
