﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CopyDirectorySan.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CopyDirectorySan.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Bitmap Balloon {
            get {
                object obj = ResourceManager.GetObject("Balloon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Bitmap Holi {
            get {
                object obj = ResourceManager.GetObject("Holi", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   (アイコン) に類似した型 System.Drawing.Icon のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Icon iconHoli {
            get {
                object obj = ResourceManager.GetObject("iconHoli", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Bitmap Kittypool {
            get {
                object obj = ResourceManager.GetObject("Kittypool", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   現在選択されているテンプレートが削除されます。
        ///この処理は元に戻せません。
        ///現在のテンプレートを削除しますか？ に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_DeleteTemplateWarning {
            get {
                return ResourceManager.GetString("String_DeleteTemplateWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   保存先フォルダ内に作ろうとした名前のフォルダが既に存在し、
        ///かつ上書きが許可されていません。
        ///既にコピー済みの可能性があります。
        ///
        ///このエラーを回避するためには、（上書きを許可するのではなく）
        ///別の保存先フォルダを指定することが推奨されます。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Error_ExistsDest {
            get {
                return ResourceManager.GetString("String_Error_ExistsDest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   指定した「保存先フォルダ」が見つかりませんでした。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Error_NotExists_TextBoxDest {
            get {
                return ResourceManager.GetString("String_Error_NotExists_TextBoxDest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   指定した「コピーするフォルダ」が見つかりませんでした。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Error_NotExists_TextBoxSource {
            get {
                return ResourceManager.GetString("String_Error_NotExists_TextBoxSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   保存先フォルダが選択されていません。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Error_Null_TextBoxDest {
            get {
                return ResourceManager.GetString("String_Error_Null_TextBoxDest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   コピーするフォルダが選択されていません。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Error_Null_TextBoxSource {
            get {
                return ResourceManager.GetString("String_Error_Null_TextBoxSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   コピーするフォルダの親フォルダが保存先に指定され、
        ///かつ「そのままコピーする」が選ばれています。
        ///つまり元ファイルに同ファイルを上書きするかたちになります。
        ///恐いのでやめてください。そんなことは。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Error_SameName {
            get {
                return ResourceManager.GetString("String_Error_SameName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   コピーするフォルダと保存先フォルダに同じパスを指定すると
        ///予期せぬ問題が起きかねません。
        ///恐いのでやめてください。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Error_SamePath {
            get {
                return ResourceManager.GetString("String_Error_SamePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   はい？ に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Holi1 {
            get {
                return ResourceManager.GetString("String_Holi1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   …わかりました。
        ///私の名前はホリィ。ナイピン・ケン市役所マモノ課の部長職として、
        ///マモノ研究所の所長を兼任しています。
        ///基本的に研究所の宿舎に寝泊まりしているので家にはたまにしか帰りません。
        ///目のことは言いたくないのできかないでください。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Holi10 {
            get {
                return ResourceManager.GetString("String_Holi10", resourceCulture);
            }
        }
        
        /// <summary>
        ///   このスーツは対マモノ用軽戦闘スーツです。
        ///私が念じれば、いまあなたに向けられている胸の穴からビームを撃てます。
        ///私は常にチャージ状態にしているのでいますぐにでも撃てます。
        ///ビームを。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Holi11 {
            get {
                return ResourceManager.GetString("String_Holi11", resourceCulture);
            }
        }
        
        /// <summary>
        ///   あの、コピーしないなら通常業務に戻ってもいいですか？ に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Holi12 {
            get {
                return ResourceManager.GetString("String_Holi12", resourceCulture);
            }
        }
        
        /// <summary>
        ///   …帰りますからね。お疲れ様でした。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Holi13 {
            get {
                return ResourceManager.GetString("String_Holi13", resourceCulture);
            }
        }
        
        /// <summary>
        ///   なんですか？ に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Holi2 {
            get {
                return ResourceManager.GetString("String_Holi2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   私ですか？　私はホリィです。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Holi3 {
            get {
                return ResourceManager.GetString("String_Holi3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   あ、このソフトの安全性について知りたいんですね。
        ///
        ///このソフトは開発者が毎日行っているデータのバックアップ作業を
        ///効率化するためだけに作成されたものです。
        ///インターネット接続を行わず、exeファイルとconfigファイルのみで
        ///処理が完結するよう設計されていて、安心してお使いいただけます。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Holi4 {
            get {
                return ResourceManager.GetString("String_Holi4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   コピーによって実行される処理は
        ///1．コピーするフォルダを保存先フォルダにコピーする。
        ///2．exeファイルと同じ場所にあるconfigファイルにテンプレート情報を保存する。
        ///というものです。
        ///
        ///安全性を高めるために余計な機能は追加しませんでした。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Holi5 {
            get {
                return ResourceManager.GetString("String_Holi5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   しないんですか？
        ///コピー。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Holi6 {
            get {
                return ResourceManager.GetString("String_Holi6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   私に話しかけてますか？ に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Holi7 {
            get {
                return ResourceManager.GetString("String_Holi7", resourceCulture);
            }
        }
        
        /// <summary>
        ///   えーと、私はただこのソフトの使い方を説明しているだけです。
        ///私自身のことは気にしないでください。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Holi8 {
            get {
                return ResourceManager.GetString("String_Holi8", resourceCulture);
            }
        }
        
        /// <summary>
        ///   私のことを知りたいなら、右上のKITTYPOOLのアイコンをクリックして、
        ///このソフトの開発者のYouTubeチャンネルを見てください。
        ///
        ///…ほんと、なんなんだろ。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Holi9 {
            get {
                return ResourceManager.GetString("String_Holi9", resourceCulture);
            }
        }
        
        /// <summary>
        ///   「フォルダ名の先頭にコピーした【年月日】を付与する」を選ぶと、
        ///コピー後のフォルダ名が
        ///
        ///　yyyyMMdd_元のフォルダ名
        ///
        ///になります。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_MouseEnter_CopyStyle1 {
            get {
                return ResourceManager.GetString("String_MouseEnter_CopyStyle1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   「フォルダ名の先頭にコピーした【年月日時分秒】を付与する」を選ぶと、
        ///コピー後のフォルダ名が
        ///
        ///　yyyyMMddHHmmss_元のフォルダ名
        ///
        ///になります。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_MouseEnter_CopyStyle2 {
            get {
                return ResourceManager.GetString("String_MouseEnter_CopyStyle2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   「【年月日】フォルダを作成してそのなかにコピーする」を選ぶと、
        ///保存先フォルダ内に
        ///
        ///yyyyMMdd
        ///
        ///という名前のフォルダを作り、そのなかにコピーします。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_MouseEnter_CopyStyle3 {
            get {
                return ResourceManager.GetString("String_MouseEnter_CopyStyle3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   「【年月日時分秒】フォルダを作成してそのなかにコピーする」を選ぶと、
        ///保存先フォルダ内に
        ///
        ///yyyyMMddHHmmss
        ///
        ///という名前のフォルダを作り、そのなかにコピーします。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_MouseEnter_CopyStyle4 {
            get {
                return ResourceManager.GetString("String_MouseEnter_CopyStyle4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   「そのままコピーする」を選ぶと、
        ///コピーするフォルダがそのまま保存先フォルダに保存されます。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_MouseEnter_CopyStyle5 {
            get {
                return ResourceManager.GetString("String_MouseEnter_CopyStyle5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   開発者は「KITTYPOOL」です。
        ///クリックするとKITTYPOOLのYouTubeチャンネルが開きます。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_MouseEnter_Credit {
            get {
                return ResourceManager.GetString("String_MouseEnter_Credit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   フォルダコピーさんは、指定したフォルダをコピーするだけのソフトです。
        ///コピーしたいフォルダと保存先フォルダを指定して「コピーする」を押してください。
        ///パスは直接入力できますが、パスが存在しなければ実行時にエラーになります。
        ///
        ///コピーすると、現在選択されているテンプレートにパスが保存されます。
        ///テンプレートは次回起動時に自動的にロードされます。
        ///
        ///インターネット接続やconfigファイル以外への書き込みを行わない安心設計です。
        ///わからない機能があれば説明するのでカーソルを合わせてください。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_MouseEnter_Holi {
            get {
                return ResourceManager.GetString("String_MouseEnter_Holi", resourceCulture);
            }
        }
        
        /// <summary>
        ///   「完了後に保存先フォルダを開く」にチェックすると…
        ///…そうなります。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_MouseEnter_OpenDestDirAfterComp {
            get {
                return ResourceManager.GetString("String_MouseEnter_OpenDestDirAfterComp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   チェックを外すと、作成しようとしたフォルダと同名のフォルダが
        ///既に保存先にある場合にコピーが実行されなくなります。
        ///よくわからなければチェックを外しておくことをオススメします。
        ///
        ///チェックを入れると、
        ///同名フォルダが存在していてもコピーを実行して上書き保存します。
        ///末尾に(1)を付与して別に保存する…といったよくある機能ではなく、
        ///完全に上書きされるので注意してください。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_MouseEnter_Overwrite {
            get {
                return ResourceManager.GetString("String_MouseEnter_Overwrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   「参照」ボタンでフォルダを指定するとパスが表示されます。
        ///パスの直接入力、フォルダのドラッグ＆ドロップも可能です。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_MouseEnter_Path {
            get {
                return ResourceManager.GetString("String_MouseEnter_Path", resourceCulture);
            }
        }
        
        /// <summary>
        ///   コピーを実行すると進捗が可視化されるバーです。
        ///これを「プログレスバー」と言います。言えるとかっこいいので覚えておいてください。
        ///「プログレスバー」。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_MouseEnter_ProgressBar {
            get {
                return ResourceManager.GetString("String_MouseEnter_ProgressBar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   「テンプレート」には、コピーした際にフォルダパスと設定が自動保存されます。
        ///不要なら気にする必要のない機能です。
        ///
        ///もしあなたがテンプレート機能を活用するなら、
        ///「テンプレートはコピーを実行するたびに上書きされる」
        ///という点に注意してください。
        ///コピーする前に「どのテンプレートを選んでいるか」を確認しましょう。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_MouseEnter_Template {
            get {
                return ResourceManager.GetString("String_MouseEnter_Template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   コピーが正常に完了しました。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Progress_Comp {
            get {
                return ResourceManager.GetString("String_Progress_Comp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ファイルをコピー中です。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_Progress_Copying {
            get {
                return ResourceManager.GetString("String_Progress_Copying", resourceCulture);
            }
        }
        
        /// <summary>
        ///   コピー完了 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_RunCopy_Comp {
            get {
                return ResourceManager.GetString("String_RunCopy_Comp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   コピー中... に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_RunCopy_Copying {
            get {
                return ResourceManager.GetString("String_RunCopy_Copying", resourceCulture);
            }
        }
        
        /// <summary>
        ///   コピーする に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_RunCopy_Run {
            get {
                return ResourceManager.GetString("String_RunCopy_Run", resourceCulture);
            }
        }
        
        /// <summary>
        ///   コピーできます に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string String_RunCopy_Standby {
            get {
                return ResourceManager.GetString("String_RunCopy_Standby", resourceCulture);
            }
        }
    }
}
