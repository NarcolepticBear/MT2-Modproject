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
                        "json/units/monstereelgorgon.json",
                        "json/spells/hallowedhalls.json",
                        "json/spells/hoarfrosteffigy.json",
                        "json/spells/iceandpyre.json",
                        "json/spells/rootseeds.json",
                        "json/spells/drain.json",
                        "json/spells/awokencycleoflife.json",
                        "json/spells/voidbinding.json",
                        "json/spells/titansgratitude.json",
                        "json/spells/cavein.json",
                        "json/units/shadowsiege.json",
                        "json/units/monstershadowsiege.json",
                        "json/units/draff.json",
                        "json/units/guardoftheunnamed.json",
                        "json/units/monsteranimusofwill.json",
                        "json/units/monstershadoweater.json",
                        "json/units/monstercuttlehex.json",
                        "json/units/monsterpyreblooded.json",
                        "json/units/monsterovergorger.json",
                        "json/units/monsterbattledancer.json",
                        "json/units/monsterbountystalker.json",
                        "json/units/scrivenerability.json",
                        "json/units/trufflesability.json",
                        "json/units/pyrebloodedability.json",
                        "json/units/monstermoltingimp.json",
                        "json/units/consumerofcrownsability.json",
                        "json/champions/wyldentenstranglertwo.json",
                        "json/champions/wyldentenstranglerthree.json",
                        "json/champions/queenrally2.json",
                        "json/champions/queenrally3.json",
                        "json/champions/penumbratrample1.json",
                        "json/champions/penumbratramble2.json",
                        "json/champions/penumbratramble3.json",
                        "json/champions/flickerburnout2.json",
                        "json/champions/flickerburnout3.json",
                        "json/champions/flickerharvesttrigger1.json",
                        "json/champions/flickerharvesttrigger2.json",
                        "json/champions/flickerharvesttrigger3.json",
                        "json/champions/arduhnhammer1.json",
                        "json/champions/arduhnhammer2.json",
                        "json/champions/solgardfrostbite1.json",
                        "json/champions/solgardfrostbite2.json",
                        "json/champions/solgardfrostbite3.json",
                        "json/champions/boletetrample2.json",
                        "json/champions/penumbraarchitect1.json",
                        "json/champions/penumbraarchitect2.json",
                        "json/champions/penumbraarchitect3.json",
                        "json/equipment/spikyskin.json",
                        "json/rooms/electricitychamber.json",
                        "json/rooms/electricitychamberupgrade.json",
                        "json/relics/combinedrelic.json",
                        "json/relics/traitorsquill.json",
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
