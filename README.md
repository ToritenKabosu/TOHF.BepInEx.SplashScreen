# TOHF.BepInEx.SplashScreen
[BepInEx.SplashScreen](https://github.com/BepInEx/BepInEx.SplashScreen)をベースに、TownOfHost-Fun用に多言語対応したものです。<br/>
以下に、フォーク元リポジトリのREADMEを翻訳し、一部変更して掲載します。
## BepInEx 読み込み進捗 SplashScreen
現在読み込まれているPatcherやプラグインの情報を表示する、ゲーム起動時にロード画面を表示する BepInEx Patcherです。<br/>
Patcherやプラグインの初期化に時間がかかるゲームに特に適しています。<br/>

このPatcherは主に Mod パックに含めることを想定しており、多数のModを導入したゲーム起動直後にエンドユーザーへ即時フィードバックを提供します。<br/>
特に低スペック環境では、ゲームウィンドウが表示されたり操作可能になるまでに時間がかかることがあり、ユーザーに「ゲームがクラッシュした」と誤解される場合があります。<br/>

このPatcherおよび GUIアプリは、古いバージョンの`risk-of-thunder/BepInEx.GUI`を元に発展しましたが、現在ではコードの大部分が書き直されており、あらゆるゲームで動作します。<br/>
ただし、RiskOfRain2をModしている場合は、より良い体験のために risk-of-thunder/BepInEx.GUI の使用をおすすめします。<br/>

### 使い方
[BepInEx](https://github.com/BepInEx/BepInEx) v5.4.11 以降、またはv6.0.0-be.674以降をインストールしてください(mono と IL2CPP の両方に対応)。<br/>
使用している BepInEx のバージョンに対応した最新リリースをダウンロードします。<br/>
展開し、Patcherファイルが BepInEx\patchers フォルダ内に入るように配置します。<br/>
BepInEx が正しく設定されていれば、ゲーム起動時にSplashScreenが表示されます。<br/>

## SplashScreenが表示されない場合
- BepInEx.SplashScreen.GUI.exe と BepInEx.SplashScreen.Patcher.dll の両方が BepInEx\patchers フォルダ内に存在することを確認してください。
- BepInEx\config\BepInEx.cfg でSplashScreenが無効化されていないか確認してください。このファイルや SplashScreen Enable 設定が見当たらない場合、BepInEx が正しく設定されていないか、このPatcherの起動に失敗している可能性があります。
- BepInEx 5 を最新バージョンへ更新し、正しく起動していることを確認してください。
- それでも表示されない場合は、ゲームログにエラーや例外がないか確認してください。

## ビルド方法
リポジトリをクローンし、Visual Studio 2022(.NET デスクトップ開発および .NET 3.5 開発ツールをインストール済み)でソリューションを開いてください。
`Build Solution`を実行すればビルドできます。