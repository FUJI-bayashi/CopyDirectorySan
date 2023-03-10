

# フォルダコピーさん (CopyDirectorySan.exe)
指定されたフォルダをコピーし、その設定を保存できるWindows用デスクトップアプリです。

エラーを回避するため、可能な限りシンプルな実装を心掛けました。


![MainWindow](https://user-images.githubusercontent.com/85349449/219228161-7a4550f0-c016-491b-9df1-f3c07e9f4a2d.png?raw=true)

---

+ [起動方法、インストールについて](#起動方法インストールについて)
+ [使用方法、処理内容](#使用方法処理内容)
+ [システム要件、動作確認](#システム要件動作確認)
+ [アプリケーションの安全性](#アプリケーションの安全性)
+ [ライセンス](#ライセンス)
+ [開発者](#開発者)
+ [リリースノート](#リリースノート)
+ [よくある質問](#よくある質問)

---

# 起動方法、インストールについて
exeファイルを起動するのみで動作し、インストール不要です。

# 使用方法、処理内容
1. わからない部分にカーソルを合わせると、ホリィさんが説明してくれます。
2. コピーしたいフォルダと保存先フォルダを指定してください。ドラッグ＆ドロップ可。
3. 「保存先フォルダ名のスタイル」「上書きの可否」「完了後に保存先フォルダを開くか」を選択してください。
4. 「コピーする」ボタンを押してください。
   + 押した瞬間に、なにか問題がないか確認されます。
     + 例えば「フォルダが指定されていない」「フォルダが存在しない」など。
   + 問題があると、コピー処理は一切行われません。
5. 問題がなければコピーが開始されます。
   + 開始から完了までの間、全てのボタンが押せなくなります。
   + この処理は止まりません。止まっているように見えるなら、単一の大きなファイルのコピーに時間が掛かっているだけで止まっていない、または下記のいずれかの理由で止まっています。
     + ファイルへのアクセスが許可されていない
     + ファイルに問題が発生している
     + OSに問題が発生していて、ファイルに問題はないもののアクセス不能になっている
     + コピー処理に使用している一般的なメソッド「System.IO.File.Copy」の仕様上処理不能なファイルである（可能性の低いケースです）
   + 以上のような理由で止まってしまった場合は、**アプリケーションを強制終了してください。その後、作成されたコピー済みフォルダを全て削除したうえで、手作業でコピーし直してください。**
6. コピーが正常に完了すると、次のような合図があります。
   + 全てのボタンが押せるようになります。
   + プログレスバーが緑色で埋まります。
   + 「コピーする」ボタンに「コピー完了 / コピーできます」と表示されます。
   + ホリィが「コピーが正常に完了しました。」と言います（これは別の項目にマウスカーソルを合わせた瞬間に消えてしまうので気が付きにくいかもしれません）。
7. コピー完了と同時に、フォルダパスを含めた全ての設定内容が、選択されている番号のテンプレートに保存されます。
    + 内部的には、exeファイルと同じ場所にあるconfigファイルに保存されています。

# システム要件、動作確認
Windows 10 32bit及び64bit で（**ゲームエンジン「UNITY」のプロジェクトファイルをドライブをまたいで丸ごとコピーする**という処理において）正常に動作することを確認済みです。

# アプリケーションの安全性
このアプリケーションはexeファイル及びconfigファイルのみで動作し、（保存先フォルダへのコピー処理を除けば）それ以外の領域に一切の影響を及ぼしません。インターネットへの接続も行われていません。

ご不安な場合はGithubでソースコードをご確認ください。

+ [プロジェクトのルートフォルダ](https://github.com/FUJI-bayashi/CopyDirectorySan/tree/master/CopyDirectorySan) / [主な処理が記述されたcsファイル](https://github.com/FUJI-bayashi/CopyDirectorySan/blob/master/CopyDirectorySan/Form1.cs)

# ライセンス
一般的に個人開発の無料アプリケーションに採用されることが多いとされる「MITライセンス」を採用しました。
内容はLICENSE.txtに記載のあるとおりですが、要約するとMIT Licenseとは次のようなライセンスです。
1.  このソフトウェアを誰でも無償で無制限に扱って良い。ただし、著作権表示および本許諾表示をソフトウェアのすべての複製または重要な部分に記載しなければならない。
2.  作者または著作権者は、ソフトウェアに関してなんら責任を負わない。

要するに報告不要で使用も改変も自由だけど二次頒布するときはクレジット表記してねという意味だと認識しています。

# 開発者
*KITTYPOOL*

*https://www.youtube.com/@kittypool*

# リリースノート
2023.2.16 - 1.0.0 公開

# よくある質問
1. **どうやってコピーしてるの？**
   + [*System.IO.File.Copy*](https://learn.microsoft.com/ja-jp/dotnet/api/system.io.file.copy?view=net-7.0)というメソッドを使ってコピーしています。これはMicrosoft社が作ったプログラミングの道具みたいなもので、Windowsのデスクトップアプリでファイルをコピーするための最も一般的な方法として知られています。
2. **ちゃんとコピーされてる？**
   + コピー前とコピー後のファイルが完全に同一となることは、外部ツール[*Winmerge*](https://www.google.com/search?q=Winmerge&sourceid=chrome&ie=UTF-8)により確認済みです。
3. **よくある「コピー数 :100 / エラーファイル: 0」みたいに教えてくれないの？**
   + それを実装しようとすると、<コピー前に全てのファイルを検索してファイル数を数える>という処理が必要となりますが、エラー回避のため余計な機能は可能な限り排除しました。また、処理上、エラーが発生するとアプリケーションが停止しますので、**コピーが完了した＝エラーは起きなかった**とご認識ください。
4. **心配だから、テキストファイルでログを吐いてほしい。**
   + <テキストファイルを作る>という処理を実装しようとすると、
     + テキストファイルをどこに保存する？
     + ファイルはその都度作る？一つにまとめる？
     + 一つにまとめるならファイルの最大サイズをどうしたい？
     + 中身の体裁は？
     + ログのファイル名は？
     + 拡張子はどうしたい？
    + など設定項目が膨大になり、複雑な動きをする（＝エラーが起きやすい）ソフトになってしまいます。さらに、<テキストファイルを作る>という処理自体にエラーが発生して**コピーは正常に完了したけどログを吐けませんでした**みたいな事態になると、もう何のためのアプリケーションなのかわからなくなってしまいますよね！！　…すみません。取り乱しました。
5. **「現在のテンプレートを削除する」ボタンを押すとどうなる？**
   + その横のラジオボタンで選ばれている番号のテンプレートが初期化されます。そのほかのテンプレートに影響はありません。つまりconfigファイルの中身が元に戻るだけですが、**初期化**と書くとわかりにくいかなと思って**削除**という表現にしました。
6. **このアプリケーションはなんのために作ったの？**
   + 私が毎日手作業で行っていたUNITYプロジェクトのバックアップ作業を半自動化するために開発したものですが、せっかくなので皆様に共有できるようなつくりにしてみました。あと、Githubの勉強も兼ねてます。
8. **この親切な女性はだれ？**
   + 私が作っているゲーム『***Mamono Manager and holy memories***』に登場する**ホリィ**さんというかたです。ゲームは2023年中にSteamでリリース予定です。
9. **開発者はだれ？**
   + 私です。**KITTYPOOL**という名前で活動し、ひとりでゲーム開発している様子をYouTubeで配信している*FUJIBA*という者です。KITTYPOOL（ひとり）の、FUJIBA（ひとり）です。
