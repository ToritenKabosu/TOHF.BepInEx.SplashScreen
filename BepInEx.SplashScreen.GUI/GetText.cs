using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace BepInEx.SplashScreen
{
    public static class GetText
    {
        enum SupportedLanguage
        {
            English,
            Chinese,
            Japanese
        }
        private static SupportedLanguage DetectLanguage()
        {
            var lang = CultureInfo.InstalledUICulture.TwoLetterISOLanguageName;
            switch (lang)
            {
                case "zh":
                    return SupportedLanguage.Chinese;
                case "ja":
                    return SupportedLanguage.Japanese;
                default:
                    return SupportedLanguage.English;
            }
        }
        public static string GetManualLaunchWarningMessage()
        {
            switch (DetectLanguage())
            {
                case SupportedLanguage.Chinese:
                    return
@"这是一个在使用 BepInEx 补丁的游戏加载时显示加载进度的启动画面。
它会被自动启动，并由 “BepInEx.SplashScreen.Patcher.dll” 进行更新，无法手动打开。

如果在游戏启动时没有看到启动画面：

1 - 请确认 “BepInEx.SplashScreen.GUI.exe” 和
“BepInEx.SplashScreen.Patcher.dll”
都存在于 “BepInEx\patchers” 文件夹中。

2 - 请检查 “BepInEx\config\BepInEx.SplashScreen.cfg” 中是否禁用了启动画面。

3 - 请将 BepInEx5 更新到最新版本，并确认其正在运行。

4 - 如果启动画面仍未显示，请检查游戏日志中是否有任何错误或异常。

是否要打开 TOHF.BepInEx.SplashScreen 的 GitHub 仓库页面？";
                case SupportedLanguage.Japanese:
                    return
@"これは、BepInExでパッチされたゲームの読み込み中に進行状況を表示するスプラッシュスクリーンです。
このプログラムは自動的に起動されるもので、手動で開くことはできません。

ゲーム起動時にスプラッシュスクリーンが表示されない場合：

1 - 「BepInEx\patchers」フォルダ内に
    「BepInEx.SplashScreen.GUI.exe」と
    「BepInEx.SplashScreen.Patcher.dll」が両方存在するか確認してください。

2 - 「BepInEx\config\BepInEx.SplashScreen.cfg」で
    スプラッシュスクリーンが無効化されていないか確認してください。

3 - BepInEx5を最新バージョンに更新し、
    正常に動作していることを確認してください。

4 - それでも表示されない場合は、
    ゲームログにエラーや例外がないか確認してください。

TOHF.BepInEx.SplashScreenのGitHubリポジトリを開きますか？";
                default:
                    return
@"This is a splash screen that shows loading progress when a game patched with BepInEx is loading. It is automatically started and then updated by 'BepInEx.SplashScreen.Patcher.dll' and can't be opened manually.
If you can't see a splash screen when the game is starting:
1 - Make sure that 'BepInEx.SplashScreen.GUI.exe' and 'BepInEx.SplashScreen.Patcher.dll' are both present inside the 'BepInEx\patchers' folder.
2 - Check if the splash screen isn't disabled in 'BepInEx\config\BepInEx.SplashScreen.cfg'.
3 - Update BepInEx5 to latest version and make sure that it is running.
4 - If the splash screen still does not appear, check the game log for any errors or exceptions.
Do you want to open the GitHub repository page of TOHF.BepInEx.SplashScreen?";
            }
        }
        public static string GetLoadingText(string progressname)
        {
            switch (DetectLanguage())
            {
                case SupportedLanguage.Chinese:
                    return $@"正在加载 {progressname}...";
                case SupportedLanguage.Japanese:
                    return $@"{progressname}をロード中...";
                default:
                    return $@"{progressname} is loading...";
            }
        }
        public static string GetOpenGameFolderText()
        {
            switch (DetectLanguage())
            {
                case SupportedLanguage.Chinese:
                    return @"打开游戏文件夹";
                case SupportedLanguage.Japanese:
                    return @"ゲームフォルダを開く";
                default:
                    return @"Open game folder";
            }
        }
        public static string[] GetCheckboxTextArray()
        {
            switch (DetectLanguage())
            {
                case SupportedLanguage.Chinese:
                    return new string[]
                    {
                        "初始化环境和 BepInEx",
                        "加载并应用补丁程序",
                        "加载并应用插件",
                        "启动游戏"
                    };
                case SupportedLanguage.Japanese:
                    return new string[]
                    {
                        "環境とBepInExの初期化",
                        "Patcherのロードと適用",
                        "プラグインのロードと適用",
                        "ゲームの起動"
                    };
                default:
                    return new string[]
                    {
                        "Initialize environment and BepInEx",
                        "Load and apply patchers",
                        "Load and apply plugins",
                        "Start the game"
                    };
            }
        }
        public static string GetDoneText()
        {
            switch (DetectLanguage())
            {
                case SupportedLanguage.Chinese:
                    return "完成";
                case SupportedLanguage.Japanese:
                    return "完了";
                default:
                    return "Done";
            }
        }
        public static string GetBepInExInitializingText()
        {
            switch (DetectLanguage())
            {
                case SupportedLanguage.Chinese:
                    return "正在初始化 BepInEx...";
                case SupportedLanguage.Japanese:
                    return "BepInExを初期化中...";
                default:
                    return "BepInEx is initializing...";
            }
        }
        public static string GetEnvironmentBeingSetupText()
        {
            switch (DetectLanguage())
            {
                case SupportedLanguage.Chinese:
                    return "环境正在设置中";
                case SupportedLanguage.Japanese:
                    return "環境が整いつつあります";
                default:
                    return "The environment is being set up";
            }
        }
        public static string GetGameLoadingText()
        {
            switch (DetectLanguage())
            {
                case SupportedLanguage.Chinese:
                    return "游戏正在加载...";
                case SupportedLanguage.Japanese:
                    return "ゲームのロード中...";
                default:
                    return "The game is loading...";
            }
        }
        public static string GetPatchersBeingAppliedText()
        {
            switch (DetectLanguage())
            {
                case SupportedLanguage.Chinese:
                    return "正在应用 BepInEx 补丁程序...";
                case SupportedLanguage.Japanese:
                    return "BepInEx パッチが適用されています...";
                default:
                    return "BepInEx patchers are being applied...";
            }
        }
        public static string GetFinishedApplyingPatchersText()
        {
            switch (DetectLanguage())
            {
                case SupportedLanguage.Chinese:
                    return "补丁程序应用完成。";
                case SupportedLanguage.Japanese:
                    return "パッチの適用が完了しました";
                default:
                    return "Finished applying patchers.";
            }
        }
        public static string GetPluginsStartLoadingSoonText()
        {
            switch (DetectLanguage())
            {
                case SupportedLanguage.Chinese:
                    return "插件即将开始加载。\n如果加载卡住，请检查你的入口点。";
                case SupportedLanguage.Japanese:
                    return "まもなくプラグインをロード開始します\n読み込みが停止した場合、エントリポイントを確認してください";
                default:
                    return "Plugins should start loading soon.\nIn case loading is stuck, check your entry point.";
            }
        }
        public static string GetPluginsBeingLoadedText()
        {
            switch (DetectLanguage())
            {
                case SupportedLanguage.Chinese:
                    return "正在加载 BepInEx 插件...";
                case SupportedLanguage.Japanese:
                    return "BepInEx プラグインをロードしています...";
                default:
                    return "BepInEx plugins are being loaded...";
            }
        }
        public static string GetFinishedLoadingPluginsText()
        {
            switch (DetectLanguage())
            {
                case SupportedLanguage.Chinese:
                    return "插件加载完成。";
                case SupportedLanguage.Japanese:
                    return "プラグインのロードが完了しました";
                default:
                    return "Finished loading plugins.";
            }
        }
        public static string GetWaitingForGameToStartText()
        {
            switch (DetectLanguage())
            {
                case SupportedLanguage.Chinese:
                    return "正在等待游戏启动...\n有些插件可能需要更多时间来完成加载。";
                case SupportedLanguage.Japanese:
                    return "ゲームの起動を待っています...\n一部のプラグインはロード完了までにさらに時間がかかる場合があります";
                default:
                    return "Waiting for the game to start...\nSome plugins might need more time to finish loading..";
            }
        }
    }
}
