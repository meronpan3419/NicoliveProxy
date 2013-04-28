NicoLiveProxy 3

配布者：    meronpan
ツイッター： @meronpan3419
コミュ：   http://nico.ms/co274186
配布先：   http://nicolive_wakusu.b72.in/nicolive_kai_plus/のアップローダー


■概要
NicoLiveProxyはニコニコ生放送のhttp://live.nicovideo.jp/api/getpublishstatusの遅延問題（2012/12）で、旧配信コンソールを利用した配信ソフトが使いにくなってるのを回避する　上　級　者　向　け　プロクシソフト。


■免責
本ソフトウェアを使用した事により発生した損害について、一切の責任を負いかねますので。


■動作環境
-.net framework3.0以降でいいはず
-OS Windows XP SP3以降

■インストール
インストールは不要。NicoLiveProxy.exeを起動させるだけ。


■アンインストール
解凍したファイルを削除するだけ。


■配布内容
- NicoLiveProxy.exe	プロクシ本体
- nl_proxy.pac	IEのプロクシ自動構成ファイルの例
- readme.txt	このテキストファイル
- src	ソースコードC#


■使用方法
IEのプロクシ設定でHTTPのプロクシに127.0.0.1:8080を指定する。
8080はデフォルトのポート番号。
HTTPSには対応してないのでHTTPだけプロクシとして指定する。
（e.g. IE8→ツール→インターネットオプション→接続→LANの設定→LANにプロｒｙ→詳細設定→HTTP）
環境によっては、付属の自動構成ファイルを利用してもいいかも。
IEのプロクシに指定したら、NicoLiveProxy.exeを起動させてないとブラウザ見れないので注意。


■動作原理
NicoLiveProxy.exeは単純なプロクシで、http://live.nicovideo.jp/api/getpublishstatus?v=lv123456789に対するリクエストのv=lv123456789を削除するだけ。getpublishstatusにlvつけてなくても情報取れるし、つけると遅延してるので。


■その他
8080はデフォルトのプロクシのポート番号。
コマンドライン引数でポート番号を変更できる（8081番ポートに変更する例： \NicoLiveProxy.exe 8081）
ポート番号を変更した場合はIEのプロクシも変更する。
IEのプロクシ設定してるのは、C#とかの配信ツールのフラッシュがIEのクッキーを利用するため。

■更新履歴
-3 2012/12/25 NicoLive.exe修正（TrotiNet使用） 自動構成スクリプト修正
-2 2012/12/20 自動構成スクリプト修正
-1 2012/12/19 初版

