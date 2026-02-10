using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using BepInEx.Configuration;
using HarmonyLib;
using Mono.Cecil;

//[assembly: AssemblyTitle("BepInEx.SplashScreen.Patcher")]

namespace BepInEx.SplashScreen
{
    public static class BepInExSplashScreenPatcher
    {
        public const string Version = Metadata.Version;

        static BepInExSplashScreenPatcher()
        {
            // できるだけ早く実行するために様々な手段を使って初期化を試みる
            // Use whatever gets us to run faster, or at all
            Init();
        }

        public static IEnumerable<string> TargetDLLs
        {
            get
            {
                // できるだけ早く実行するために様々な手段を使って初期化を試みる
                // Use whatever gets us to run faster, or at all
                Init();
                return Enumerable.Empty<string>();
            }
        }

        public static void Patch(AssemblyDefinition _)
        {
            // できるだけ早く実行するために様々な手段を使って初期化を試みる
            // Use whatever gets us to run faster, or at all
            Init();
        }

        private static int _initialized;
        public static void Init()
        {
            // 実行は1度のみ許可
            // Only allow to run once
            if (Interlocked.Exchange(ref _initialized, 1) == 1) return;

            var configPath = System.IO.Path.Combine(BepInEx.Paths.ConfigPath, "BepInEx.SplashScreen.cfg");
            var metadata = new BepInPlugin("BepInEx.SplashScreen.Patcher", "BepInEx.SplashScreen", Version);
            var config = new ConfigFile(configPath, false, metadata);
            var coreConfig = (ConfigFile)AccessTools.Property(typeof(ConfigFile), "CoreConfig").GetValue(null, null);
            SplashScreenController.SpawnSplash(config, coreConfig);
        }
    }
}
