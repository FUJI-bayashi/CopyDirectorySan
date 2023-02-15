using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyDirectorySan
{
    public partial class Form1 : Form
    {
        string quotes;
        int counter;
        int holiCounter;
        int quoteSpeed = 10;

        //ホリィセリフ
        List<string> holiQuotes;
        bool standByToQuitApp;

        //進捗バー
        int totalFileCount = 0;
        int copiedFileCount = 0;

        //ボタンリスト
        List<RadioButton> li_RadioButton_Style;
        List<RadioButton> li_RadioButton_Template;

        //configファイルに保存するリスト（全てstringに変換して保存する）
        string[] ar_config_PathSource = new string[10];
        string[] ar_config_PathDest = new string[10];
        int[] ar_config_StyleIndex;
        bool[] ar_config_OpenDirAfterCompChecked;
        bool[] ar_config_Overwrite;

        //configファイル保存用区切り文字璽
        char userConfigSplitChar = ',';

        public Form1()
        {
            //初期化処理------------------------------------

            //コンポーネント初期化
            InitializeComponent();

            //フォルダ参照機能を初期化
            Initialize_FolderBrowserDialog();

            //タイマー初期化
            InitializeTimer();

            //配列とリスト初期化
            InitializeArrayAndList();

            //ユーザーコンフィグをロード
            LoadUserConfig();

            //セリフラベルの親を吹き出しにする
            SetQuoteLabelParent();

            //コピー実行ボタン初期化
            InitializeRunButton();

            //ホリィのセリフを初期化
            InitializeHoliQuotes();

            //イベントハンドラー追加
            AddEventHandler();

            //アイコン設定
            this.Icon = Properties.Resources.iconHoli;

            //起動時の状態を設定----------------------------

            //初期セリフを設定
            ResetTypewriting(Properties.Resources.String_MouseEnter_Holi);

            //最初のテンプレートを選択する
            li_RadioButton_Template[0].Checked = true;
        }

        /// <summary>
        /// フォルダ参照機能を初期化
        /// </summary>
        void Initialize_FolderBrowserDialog()
        {
            //上部に表示する説明テキストを指定する
            folderBrowserDialog1.Description = "コピーしたいフォルダを指定してください。";
            folderBrowserDialog2.Description = "コピーを保存したいフォルダを指定してください。";

            //ルートフォルダを指定する
            //デフォルトでDesktop
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog2.RootFolder = Environment.SpecialFolder.Desktop;

            //最初に選択するフォルダを指定する
            //RootFolder以下にあるフォルダである必要がある
            folderBrowserDialog1.SelectedPath = @"I:\UNITY\SOZAI\03.FinalJunky";
            folderBrowserDialog2.SelectedPath = @"I:\UNITY\SOZAI";

            //ユーザーが新しいフォルダを作成できるようにする
            //デフォルトでTrue
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog2.ShowNewFolderButton = true;
        }

        /// <summary>
        /// タイマー初期化
        /// </summary>
        void InitializeTimer()
        {
            timer1.Enabled = true;
            timer1.Interval = quoteSpeed;
            standByToQuitApp = false;
        }

        /// <summary>
        /// 配列とリスト初期化
        /// </summary>
        void InitializeArrayAndList()
        {
            li_RadioButton_Template = new List<RadioButton>(10);
            li_RadioButton_Template.Add(radioButton_Template1);
            li_RadioButton_Template.Add(radioButton_Template2);
            li_RadioButton_Template.Add(radioButton_Template3);
            li_RadioButton_Template.Add(radioButton_Template4);
            li_RadioButton_Template.Add(radioButton_Template5);
            li_RadioButton_Template.Add(radioButton_Template6);
            li_RadioButton_Template.Add(radioButton_Template7);
            li_RadioButton_Template.Add(radioButton_Template8);
            li_RadioButton_Template.Add(radioButton_Template9);
            li_RadioButton_Template.Add(radioButton_Template10);

            li_RadioButton_Style = new List<RadioButton>(5);
            li_RadioButton_Style.Add(radioButton_Style1);
            li_RadioButton_Style.Add(radioButton_Style2);
            li_RadioButton_Style.Add(radioButton_Style3);
            li_RadioButton_Style.Add(radioButton_Style4);
            li_RadioButton_Style.Add(radioButton_Style5);

            ar_config_StyleIndex = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            ar_config_OpenDirAfterCompChecked = new bool[10] { true, true, true, true, true, true, true, true, true, true };
            ar_config_Overwrite = new bool[10] { false, false, false, false, false, false, false, false, false, false };
        }

        /// <summary>
        /// セリフラベルの親を吹き出しにする
        /// </summary>
        void SetQuoteLabelParent()
        {
            pictureBox_Balloon.Controls.Add(label_Quote);
            label_Quote.Top = label_Quote.Top - pictureBox_Balloon.Top;
            label_Quote.Left = label_Quote.Left - pictureBox_Balloon.Left;
        }

        void InitializeRunButton()
        {
            button_RunCopy.Text = Properties.Resources.String_RunCopy_Run + "\n\n( " + Properties.Resources.String_RunCopy_Standby + " )";
        }

        /// <summary>
        /// ホリィのセリフを初期化
        /// </summary>
        void InitializeHoliQuotes()
        {
            holiCounter = 0;
            holiQuotes = new List<string>();
            holiQuotes.Add(Properties.Resources.String_Holi1);
            holiQuotes.Add(Properties.Resources.String_Holi2);
            holiQuotes.Add(Properties.Resources.String_Holi3);
            holiQuotes.Add(Properties.Resources.String_Holi4);
            holiQuotes.Add(Properties.Resources.String_Holi5);
            holiQuotes.Add(Properties.Resources.String_Holi6);
            holiQuotes.Add(Properties.Resources.String_Holi7);
            holiQuotes.Add(Properties.Resources.String_Holi8);
            holiQuotes.Add(Properties.Resources.String_Holi9);
            holiQuotes.Add(Properties.Resources.String_Holi10);
            holiQuotes.Add(Properties.Resources.String_Holi11);
            holiQuotes.Add(Properties.Resources.String_Holi12);
            holiQuotes.Add(Properties.Resources.String_Holi13);
        }

        void Form1_Load(object sender, EventArgs e)
        {

        }

        //Template------------------------------------------------------------------------------

        /// <summary>
        /// テンプレート選択
        /// </summary>
        void SelectTemplate(int _index)
        {
            textBox_Path_Source.Text                                   = ar_config_PathSource[_index];
            textBox_Path_Dest.Text                                     = ar_config_PathDest[_index];
            li_RadioButton_Style[ar_config_StyleIndex[_index]].Checked = true;
            checkBox_OpenDestDirAfterComp.Checked                      = ar_config_OpenDirAfterCompChecked[_index];
            checkBox_Overwrite.Checked                                 = ar_config_Overwrite[_index];
        }

        /// <summary>
        /// ユーザーコンフィグをロード
        /// </summary>
        void LoadUserConfig()
        {

            if (Properties.Settings.Default.li_PathSource.Length > 0)
                ar_config_PathSource              = LoadUserConfigStringToArray<string>(Properties.Settings.Default.li_PathSource);

            if(Properties.Settings.Default.li_PathDest.Length > 0)
                ar_config_PathDest                = LoadUserConfigStringToArray<string>(Properties.Settings.Default.li_PathDest);

            if(Properties.Settings.Default.li_CopyStyle.Length > 0)
                ar_config_StyleIndex              = LoadUserConfigStringToArray<int>   (Properties.Settings.Default.li_CopyStyle);

            if (Properties.Settings.Default.li_Overwrite.Length > 0)
                ar_config_Overwrite               = LoadUserConfigStringToArray<bool>  (Properties.Settings.Default.li_Overwrite);

            if (Properties.Settings.Default.li_OpenDirAfterComp.Length > 0)
                ar_config_OpenDirAfterCompChecked = LoadUserConfigStringToArray<bool>  (Properties.Settings.Default.li_OpenDirAfterComp);
        }

        /// <summary>
        /// ユーザーコンフィグをセーブ
        /// </summary>
        void SaveUserConfig()
        {
            ar_config_PathSource[GetSelectedTemplateIndex()] = textBox_Path_Source.Text;
            ar_config_PathDest[GetSelectedTemplateIndex()] = textBox_Path_Dest.Text;
            ar_config_StyleIndex[GetSelectedTemplateIndex()] = GetCheckedStyleButtonIndex();
            ar_config_Overwrite[GetSelectedTemplateIndex()] = checkBox_Overwrite.Checked;
            ar_config_OpenDirAfterCompChecked[GetSelectedTemplateIndex()] = checkBox_OpenDestDirAfterComp.Checked;

            Properties.Settings.Default.li_PathSource       = SaveUserConfigStringFromArray<string>(ar_config_PathSource);
            Properties.Settings.Default.li_PathDest         = SaveUserConfigStringFromArray<string>(ar_config_PathDest);
            Properties.Settings.Default.li_CopyStyle        = SaveUserConfigStringFromArray<int>   (ar_config_StyleIndex);
            Properties.Settings.Default.li_Overwrite = SaveUserConfigStringFromArray<bool>(ar_config_Overwrite);
            Properties.Settings.Default.li_OpenDirAfterComp = SaveUserConfigStringFromArray<bool>  (ar_config_OpenDirAfterCompChecked);
            Properties.Settings.Default.Save();
        }

        void DeleteCurrentUserConfig()
        {
            ar_config_PathSource[GetSelectedTemplateIndex()] = "";
            ar_config_PathDest[GetSelectedTemplateIndex()] = "";
            ar_config_StyleIndex[GetSelectedTemplateIndex()] = 0;
            ar_config_Overwrite[GetSelectedTemplateIndex()] = false;
            ar_config_OpenDirAfterCompChecked[GetSelectedTemplateIndex()] = true;
            textBox_Path_Source.Text = "";
            textBox_Path_Dest.Text = "";
            radioButton_Style1.Checked = true;
            checkBox_Overwrite.Checked = false;
            checkBox_OpenDestDirAfterComp.Checked = true;

            Properties.Settings.Default.li_PathSource = SaveUserConfigStringFromArray<string>(ar_config_PathSource);
            Properties.Settings.Default.li_PathDest = SaveUserConfigStringFromArray<string>(ar_config_PathDest);
            Properties.Settings.Default.li_CopyStyle = SaveUserConfigStringFromArray<int>(ar_config_StyleIndex);
            Properties.Settings.Default.li_Overwrite = SaveUserConfigStringFromArray<bool>(ar_config_Overwrite);
            Properties.Settings.Default.li_OpenDirAfterComp = SaveUserConfigStringFromArray<bool>(ar_config_OpenDirAfterCompChecked);
            Properties.Settings.Default.Save();
        }

        int GetSelectedTemplateIndex()
        {
            for (int i = 0; i < li_RadioButton_Template.Count; i++)
            {
                if (li_RadioButton_Template[i].Checked)
                    return i;
            }

            return li_RadioButton_Template.Count - 1;
        }

        //EventHandler--------------------------------------------------------------------------

        /// <summary>
        /// EventHandlerを追加
        /// </summary>
        void AddEventHandler()
        {
            SetEventHandler(true);

            textBox_Path_Source.Enabled = true;
            textBox_Path_Dest.Enabled = true;
            button_Browse_Source.Enabled = true;
            button_Browse_Dest.Enabled = true;
            button_OpenDirSource.Enabled = true;
            button_OpenDirDest.Enabled = true;
            button_DeleteCurrentTemplate.Enabled = true;
            foreach (var item in li_RadioButton_Style)
            {
                item.Enabled = true;
            }
            checkBox_OpenDestDirAfterComp.Enabled = true;
            checkBox_Overwrite.Enabled = true;

            foreach (var item in li_RadioButton_Template)
            {
                item.Enabled = true;
            }
            button_RunCopy.Enabled = true;
        }

        /// <summary>
        /// EventHandlerを削除
        /// </summary>
        void RemoveEventHandler()
        {
            SetEventHandler(false);

            textBox_Path_Source.Enabled = false;
            textBox_Path_Dest.Enabled = false;
            button_Browse_Source.Enabled = false;
            button_Browse_Dest.Enabled = false;
            button_OpenDirSource.Enabled = false;
            button_OpenDirDest.Enabled = false;
            button_DeleteCurrentTemplate.Enabled = false;
            foreach (var item in li_RadioButton_Style)
            {
                item.Enabled = false;
            }
            checkBox_OpenDestDirAfterComp.Enabled = false;
            checkBox_Overwrite.Enabled = false;

            foreach (var item in li_RadioButton_Template)
            {
                item.Enabled = false;
            }
            button_RunCopy.Enabled = false;
        }

        /// <summary>
        /// イベントハンドラーをセット
        /// </summary>
        void SetEventHandler(bool _add)
        {
            if (_add)
            {
                pictureBox_Holi.MouseEnter += pictureBox_Holi_MouseEnter;
                pictureBox_Holi.MouseClick += pictureBox_Holi_MouseClick;

                textBox_Path_Source.MouseEnter += TextBox_MouseEnter;
                textBox_Path_Dest.MouseEnter += TextBox_MouseEnter;
                textBox_Path_Source.DragDrop += textBoxPath_DragDrop;
                textBox_Path_Dest.DragDrop += textBoxPath_DragDrop;
                textBox_Path_Source.DragEnter += textBoxPath_DragEnter;
                textBox_Path_Dest.DragEnter += textBoxPath_DragEnter;
                button_Browse_Source.Click += button_Browse1_Click;
                button_Browse_Dest.Click += button_Browse2_Click;
                button_OpenDirSource.Click += button_Open1_Click;
                button_OpenDirDest.Click += button_Open2_Click;

                radioButton_Style1.MouseEnter += radioButton1_MouseEnter;
                radioButton_Style2.MouseEnter += radioButton2_MouseEnter;
                radioButton_Style3.MouseEnter += radioButton3_MouseEnter;
                radioButton_Style4.MouseEnter += radioButton4_MouseEnter;
                radioButton_Style5.MouseEnter += radioButton5_MouseEnter;
                checkBox_OpenDestDirAfterComp.MouseEnter += checkBox_OpenDestDirAfterComp_MouseEnter;
                checkBox_Overwrite.MouseEnter += checkBox_Overwrite_MouseEnter;

                label_TemplateTitle.MouseEnter += Template_MouseEnter;
                foreach (var item in li_RadioButton_Template)
                {
                    item.MouseEnter += Template_MouseEnter;
                    item.CheckedChanged += RadioButton_Template_CheckedChanged;
                }
                button_DeleteCurrentTemplate.MouseEnter += Template_MouseEnter;
                button_DeleteCurrentTemplate.Click += button_DeleteTemplateButton_Click;

                progressBar1.MouseEnter += progressBar_MouseEnter;

                label_Credit.MouseEnter += credit_MouseEnter;
                label_Credit.Click += credit_Click;
                pictureBox_Credit.MouseEnter += credit_MouseEnter;
                pictureBox_Credit.Click += credit_Click;

                button_RunCopy.Click += button_RunCopy_Click;
            }
            else
            {
                pictureBox_Holi.MouseEnter -= pictureBox_Holi_MouseEnter;
                pictureBox_Holi.MouseClick -= pictureBox_Holi_MouseClick;

                textBox_Path_Source.MouseEnter -= TextBox_MouseEnter;
                textBox_Path_Dest.MouseEnter -= TextBox_MouseEnter;
                textBox_Path_Source.DragDrop -= textBoxPath_DragDrop;
                textBox_Path_Dest.DragDrop -= textBoxPath_DragDrop;
                textBox_Path_Source.DragEnter += textBoxPath_DragEnter;
                textBox_Path_Dest.DragEnter += textBoxPath_DragEnter;
                button_Browse_Source.Click -= button_Browse1_Click;
                button_Browse_Dest.Click -= button_Browse2_Click;
                button_OpenDirSource.Click -= button_Open1_Click;
                button_OpenDirDest.Click -= button_Open2_Click;

                radioButton_Style1.MouseEnter -= radioButton1_MouseEnter;
                radioButton_Style2.MouseEnter -= radioButton2_MouseEnter;
                radioButton_Style3.MouseEnter -= radioButton3_MouseEnter;
                radioButton_Style4.MouseEnter -= radioButton4_MouseEnter;
                radioButton_Style5.MouseEnter -= radioButton5_MouseEnter;
                checkBox_OpenDestDirAfterComp.MouseEnter -= checkBox_OpenDestDirAfterComp_MouseEnter;
                checkBox_Overwrite.MouseEnter -= checkBox_Overwrite_MouseEnter;

                label_TemplateTitle.MouseEnter -= Template_MouseEnter;
                foreach (var item in li_RadioButton_Template)
                {
                    item.MouseEnter -= Template_MouseEnter;
                    item.CheckedChanged -= RadioButton_Template_CheckedChanged;
                }
                button_DeleteCurrentTemplate.MouseEnter -= Template_MouseEnter;
                button_DeleteCurrentTemplate.Click -= button_DeleteTemplateButton_Click;

                progressBar1.MouseEnter -= progressBar_MouseEnter;

                label_Credit.MouseEnter -= credit_MouseEnter;
                label_Credit.Click -= credit_Click;
                pictureBox_Credit.MouseEnter -= credit_MouseEnter;
                pictureBox_Credit.Click -= credit_Click;

                button_RunCopy.Click -= button_RunCopy_Click;
            }
        }

        void pictureBox_Holi_MouseEnter(object sender, EventArgs e)
        {
            ResetTypewriting(Properties.Resources.String_MouseEnter_Holi);
        }
        void TextBox_MouseEnter(object sender, EventArgs e)
        {
            ResetTypewriting(Properties.Resources.String_MouseEnter_Path);
        }
        void radioButton1_MouseEnter(object sender, EventArgs e)
        {
            ResetTypewriting(Properties.Resources.String_MouseEnter_CopyStyle1);
        }
        void radioButton2_MouseEnter(object sender, EventArgs e)
        {
            ResetTypewriting(Properties.Resources.String_MouseEnter_CopyStyle2);
        }
        void radioButton3_MouseEnter(object sender, EventArgs e)
        {
            ResetTypewriting(Properties.Resources.String_MouseEnter_CopyStyle3);
        }
        void radioButton4_MouseEnter(object sender, EventArgs e)
        {
            ResetTypewriting(Properties.Resources.String_MouseEnter_CopyStyle4);
        }
        void radioButton5_MouseEnter(object sender, EventArgs e)
        {
            ResetTypewriting(Properties.Resources.String_MouseEnter_CopyStyle5);
        }
        void checkBox_OpenDestDirAfterComp_MouseEnter(object sender, EventArgs e)
        {
            ResetTypewriting(Properties.Resources.String_MouseEnter_OpenDestDirAfterComp);
        }
        void checkBox_Overwrite_MouseEnter(object sender, EventArgs e)
        {
            ResetTypewriting(Properties.Resources.String_MouseEnter_Overwrite);
        }
        void Template_MouseEnter(object sender, EventArgs e)
        {
            ResetTypewriting(Properties.Resources.String_MouseEnter_Template);
        }
        void progressBar_MouseEnter(object sender, EventArgs e)
        {
            ResetTypewriting(Properties.Resources.String_MouseEnter_ProgressBar);
        }
        void credit_MouseEnter(object sender, EventArgs e)
        {
            ResetTypewriting(Properties.Resources.String_MouseEnter_Credit);
        }

        void textBoxPath_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            string[] dragFilePathArr = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            TextBox textBox = (TextBox)sender;
            textBox.Text = dragFilePathArr[0];

        }

        void textBoxPath_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        async void button_RunCopy_Click(object sender, EventArgs e)
        {
            //エラー文字列
            string errorMsg = "";

            //コピー元と保存先がnullでなく、いずれのフォルダも存在している
            if (!String.IsNullOrEmpty(textBox_Path_Source.Text)
                && !String.IsNullOrEmpty(textBox_Path_Dest.Text)
                && System.IO.Directory.Exists(textBox_Path_Source.Text)
                && System.IO.Directory.Exists(textBox_Path_Dest.Text))
            {
                //両方同じパス。危険なので停止。
                if (textBox_Path_Source.Text == textBox_Path_Dest.Text)
                {
                    SetErrorMessage(Properties.Resources.String_Error_SamePath);
                    return;
                }

                //「そのままコピー」が選ばれている
                if (radioButton_Style5.Checked)
                {
                    DirectoryInfo sourceDI = new DirectoryInfo(textBox_Path_Source.Text);
                    string sourceParent = sourceDI.Parent.FullName;

                    //「コピーするフォルダ」が「保存先フォルダ」にある。
                    //つまり元ファイルに同ファイルを上書きするかたちになる。危険なので停止。
                    if (sourceParent == textBox_Path_Dest.Text)
                    {
                        SetErrorMessage(Properties.Resources.String_Error_SameName);
                        return;
                    }
                }
            }

            //パスがnull
            if (String.IsNullOrEmpty(textBox_Path_Source.Text))
            {
                errorMsg +=
                    Properties.Resources.String_Error_Null_TextBoxSource;
            }
            else if (!System.IO.Directory.Exists(textBox_Path_Source.Text))
            {
                if (!String.IsNullOrEmpty(errorMsg))
                    errorMsg += "\n\n";

                errorMsg +=
                    Properties.Resources.String_Error_NotExists_TextBoxSource
                    + "\n→" + textBox_Path_Source.Text;
            }

            //フォルダが存在しない
            if (String.IsNullOrEmpty(textBox_Path_Dest.Text))
            {
                if (!String.IsNullOrEmpty(errorMsg))
                    errorMsg += "\n\n";

                errorMsg +=
                    Properties.Resources.String_Error_Null_TextBoxDest;
            }
            else if (!System.IO.Directory.Exists(textBox_Path_Dest.Text))
            {
                if (!String.IsNullOrEmpty(errorMsg))
                    errorMsg += "\n\n";

                errorMsg +=
                    Properties.Resources.String_Error_NotExists_TextBoxDest
                    + "\n→" + textBox_Path_Dest.Text;
            }

            //エラーがあるなら停止
            if (!String.IsNullOrEmpty(errorMsg))
            {
                SetErrorMessage(errorMsg);

                return;
            }

            //コピー実行
            else
            {
                RemoveTypewriting();

                label_Quote.ForeColor = Color.Black;
                label_Quote.TextAlign = ContentAlignment.TopLeft;

                button_RunCopy.Text = Properties.Resources.String_RunCopy_Run + "\n\n( " + Properties.Resources.String_RunCopy_Copying + " )";

                //CopyDirectory(textBox_Path_Source.Text, textBox_Path_Dest.Text, false);
                await CopyDirectory(textBox_Path_Source.Text, textBox_Path_Dest.Text, false);

                button_RunCopy.Text = Properties.Resources.String_RunCopy_Run + "\n\n( " + Properties.Resources.String_RunCopy_Comp + " / " + Properties.Resources.String_RunCopy_Standby + " )";

                label_Quote.TextAlign = ContentAlignment.MiddleLeft;

                SaveUserConfig();

                foreach (var item in ar_config_PathSource)
                {
                    //Console.WriteLine("元フォルダ=" + item);
                }
                foreach (var item in ar_config_OpenDirAfterCompChecked)
                {
                    //Console.WriteLine("完了後にフォルダを開く="+item);
                }
            }
        }
        void RadioButton_Template_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            Debug.WriteLine(radioButton.Name + "/" + nameof(radioButton_Template1));

            if (radioButton.Name == nameof(radioButton_Template1)) SelectTemplate(0);
            else if (radioButton.Name == nameof(radioButton_Template2)) SelectTemplate(1);
            else if (radioButton.Name == nameof(radioButton_Template3)) SelectTemplate(2);
            else if (radioButton.Name == nameof(radioButton_Template4)) SelectTemplate(3);
            else if (radioButton.Name == nameof(radioButton_Template5)) SelectTemplate(4);
            else if (radioButton.Name == nameof(radioButton_Template6)) SelectTemplate(5);
            else if (radioButton.Name == nameof(radioButton_Template7)) SelectTemplate(6);
            else if (radioButton.Name == nameof(radioButton_Template8)) SelectTemplate(7);
            else if (radioButton.Name == nameof(radioButton_Template9)) SelectTemplate(8);
            else if (radioButton.Name == nameof(radioButton_Template10)) SelectTemplate(9);
        }
        void button_Browse1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                //選択されたフォルダを表示する
                textBox_Path_Source.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        void button_Browse2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog(this) == DialogResult.OK)
            {
                //選択されたフォルダを表示する
                textBox_Path_Dest.Text = folderBrowserDialog2.SelectedPath;
            }
        }
        void button_Open1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Path_Source.Text)
                && System.IO.Directory.Exists(textBox_Path_Source.Text))
            {
                System.Diagnostics.Process.Start(textBox_Path_Source.Text);
            }
            else
            {
                SetErrorMessage(Properties.Resources.String_Error_Null_TextBoxSource);
            }
        }
        void button_Open2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Path_Dest.Text)
                && System.IO.Directory.Exists(textBox_Path_Dest.Text))
            {
                System.Diagnostics.Process.Start(textBox_Path_Dest.Text);
            }
            else
            {
                SetErrorMessage(Properties.Resources.String_Error_Null_TextBoxDest);
            }
        }
        void button_DeleteTemplateButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                Properties.Resources.String_DeleteTemplateWarning,
                "現在のテンプレートを削除する",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.OK)
            {
                //現在のテンプレート削除
                DeleteCurrentUserConfig();
            }
        }
        void credit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@kittypool");
        }
        void pictureBox_Holi_MouseClick(object sender, EventArgs e)
        {
            ResetTypewriting(holiQuotes[holiCounter]);
            holiCounter++;

            //最後のセリフを言った
            if (holiCounter >= holiQuotes.Count)
            {
                //カウンターリセット
                holiCounter = 0;
                counter = 0;

                //イベントハンドラーを全削除して操作不能にする
                RemoveEventHandler();

                //2秒後にアプリケーション終了
                standByToQuitApp = true;
            }
        }

        //Copy----------------------------------------------------------------------------------

        async Task CopyDirectory(string sourceDirPath, string destDirPath, bool _isRecursion)
        {
            //コピー済フォルダパスを生成する
            string dest;
            int style = GetCheckedStyleButtonIndex();

            if (!_isRecursion)
            {
                //再帰処理でない場合

                //パスを結合するメソッド「System.IO.Path.Combine」の
                //＜第2引数が絶対パスの場合、それ以前のパスを無視して、差分以降のパスを結合した結果を返す＞
                //という難解すぎる仕様を使う
                switch (style)
                {
                    case 0:
                    case 1:
                        dest = System.IO.Path.Combine(destDirPath, GetDateTime(style) + System.IO.Path.GetFileName(sourceDirPath));
                        break;
                    case 2:
                    case 3:
                        dest = System.IO.Path.Combine(destDirPath, GetDateTime(style));
                        dest = System.IO.Path.Combine(dest, System.IO.Path.GetFileName(sourceDirPath));
                        break;
                    default:
                        dest = System.IO.Path.Combine(destDirPath, System.IO.Path.GetFileName(sourceDirPath));
                        break;
                }
            }
            else
            {
                //再帰処理の場合

                //サブフォルダには日時を付与しないので、そのまま元のパスを結合する。
                dest = System.IO.Path.Combine(destDirPath, System.IO.Path.GetFileName(sourceDirPath));
            }

            //コピー済フォルダが既に存在し、かつ上書きが許可されていなければエラー停止
            if (System.IO.Directory.Exists(dest) && !checkBox_Overwrite.Checked)
            {
                SetErrorMessage(Properties.Resources.String_Error_ExistsDest);
                return;
            }

            // コピー済フォルダを作成
            else if (!System.IO.Directory.Exists(dest))
            {
                System.IO.Directory.CreateDirectory(dest);

                //属性もコピー
                System.IO.File.SetAttributes(dest, System.IO.File.GetAttributes(dest));
            }

            //イベントハンドラーを一時削除
            RemoveEventHandler();

            //コピー元のフォルダ内のファイル数をカウント
            totalFileCount += System.IO.Directory.GetFiles(sourceDirPath).Length;

            //コピー元のフォルダ内のファイルをコピー
            foreach (string file in System.IO.Directory.GetFiles(sourceDirPath))
            {
                //System.IO.File.Copy(file, System.IO.Path.Combine(dest, System.IO.Path.GetFileName(file)), true);
                await Task.Run(() => System.IO.File.Copy(file, System.IO.Path.Combine(dest, System.IO.Path.GetFileName(file)), true));

                //プログレスバー進行
                copiedFileCount++;
                progressBar1.Value = (int)((double)copiedFileCount / totalFileCount * 100);
                label_Quote.Text = Properties.Resources.String_Progress_Copying + "\n\n→" + file;
                button_RunCopy.Text = Properties.Resources.String_RunCopy_Copying + "\n\n" + copiedFileCount + " / " + totalFileCount;
            }

            //サブフォルダを再帰的に呼び出す
            foreach (string dir in System.IO.Directory.GetDirectories(sourceDirPath))
            {
                //再帰処理フラグをtrueにして実行
                await CopyDirectory(dir, dest, _isRecursion: true);
            }

            if (_isRecursion)
                return;

            //全て終わった------------

            //保存先フォルダを開く
            if (checkBox_OpenDestDirAfterComp.Checked)
            {
                System.Diagnostics.Process.Start(destDirPath);
            }

            //削除していたイベントハンドラーを元に戻す
            AddEventHandler();

            //セリフで完了通知
            ResetTypewriting(Properties.Resources.String_Progress_Comp, Color.Green);
        }


        /// <summary>
        /// 選択されたスタイルボタンIndexを取得
        /// </summary>
        int GetCheckedStyleButtonIndex()
        {
            for (int i = 0; i < li_RadioButton_Style.Count; i++)
                if (li_RadioButton_Style[i].Checked)
                    return i;

            return 3;
        }

        /// <summary>
        /// スタイルごとの日時文字列を取得
        /// </summary>
        string GetDateTime(int _styleIndex)
        {
            if (_styleIndex > 3)
                return "";

            DateTime dt = DateTime.Now;

            string result =
                dt.Year.ToString("0000") +
                dt.Month.ToString("00") +
                dt.Day.ToString("00");

            if (_styleIndex == 1 || _styleIndex == 3)
            {
                result +=
                    dt.Hour.ToString("00") +
                    dt.Minute.ToString("00") +
                    dt.Second.ToString("00");
            }

            if (_styleIndex == 0 || _styleIndex == 1)
            {
                result += "_";
            }

            return result;
        }

        //TypeWriting--------------------------------------------------------------------------

        void SetErrorMessage(string _str)
        {
            ResetTypewriting(_str, Color.Red);

            progressBar1.Value = 0;
        }

        /// <summary>
        /// タイプライター文章をセット
        /// </summary>
        void ResetTypewriting(string _str, Color _color = default(Color))
        {
            if (quotes == _str || standByToQuitApp)
                return;

            label_Quote.ForeColor = _color;
            label_Quote.Text = null;
            counter = 0;
            quotes = _str;
            //words = quotes.Split(new char[] { ' ' });
        }

        void RemoveTypewriting()
        {
            counter = 0;
            quotes = null;
            label_Quote.Text = null;
            label_Quote.ForeColor = Color.Black;
        }

        /// <summary>
        /// タイプライタータイマー常時進行
        /// </summary>
        void timer1_Tick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(quotes))
                return;

            if (counter < quotes.Length)
            {
                label_Quote.Text += quotes[counter].ToString();
                counter++;
            }

            if (standByToQuitApp && counter >= quotes.Length)
            {
                counter++;

                if(counter > 200)
                    Application.Exit();
            }
        }

        //SaveLoad-----------------------------------------------------------------------------

        /// <summary>
        /// 配列を文字列に変換
        /// </summary>
        string SaveUserConfigStringFromArray<T>(T[] _saveArray)
        {
            return string.Join(userConfigSplitChar.ToString(), _saveArray);
        }

        /// <summary>
        /// user.configプロパティを配列に読み込む
        /// </summary>
        //T[] LoadUserConfigToArray<T>(string _propertie)
        //{
        //    T[] arr = _propertie.Split(userConfigSplitChar).Cast<T>().ToArray();
        //    T[] result = new T[10];
        //    Array.Copy(arr, result, Math.Min(arr.Length, 10));

        //    var type = typeof(T);
        //    if (type == typeof(int))
        //    {
        //        return _propertie.Split(userConfigSplitChar).Select(int.Parse).Cast<T>().ToArray();
        //    }
        //    else if (type == typeof(string))
        //    {
        //        return _propertie.Split(userConfigSplitChar).Cast<T>().ToArray();
        //    }
        //    else if (type == typeof(bool))
        //    {
        //        return _propertie.Split(userConfigSplitChar).Select(bool.Parse).Cast<T>().ToArray();
        //    }
        //    else
        //    {
        //        throw new InvalidOperationException("Unsupported type");
        //    }
        //}

        /// <summary>
        /// user.configプロパティを配列に読み込む
        /// </summary>
        T[] LoadUserConfigStringToArray<T>(string _propertie)
        {
            var type = typeof(T);
            if (type == typeof(int))
            {
                var propertieArray = _propertie.Split(userConfigSplitChar);
                int[] intArray = new int[10];
                for (int i = 0; i < propertieArray.Length && i < 10; i++)
                {
                    if (int.TryParse(propertieArray[i], out int value))
                    {
                        intArray[i] = value;
                    }
                    else
                    {
                        // 文字列が数値に変換できない場合の処理
                        return null;
                    }
                }
                T[] resultArray = new T[10];
                Array.Copy(
                    sourceArray: intArray,
                    destinationArray: resultArray,
                    length: Math.Min(intArray.Length, 10));
                return resultArray;

            }
            else if (type == typeof(string))
            {
                var propertieArray = _propertie.Split(userConfigSplitChar);
                T[] resultArray = new T[10];
                Array.Copy(
                    sourceArray: propertieArray,
                    destinationArray: resultArray,
                    length: Math.Min(propertieArray.Length, 10));
                return resultArray;
            }
            else if (type == typeof(bool))
            {
                var propertieArray = _propertie.Split(userConfigSplitChar);
                bool[] boolArray = new bool[10];
                for (int i = 0; i < propertieArray.Length && i < 10; i++)
                {
                    if (bool.TryParse(propertieArray[i], out bool value))
                    {
                        boolArray[i] = value;
                    }
                    else
                    {
                        // 文字列がブール値に変換できない場合の処理
                        return null;
                    }
                }
                T[] resultArray = new T[10];
                Array.Copy(
                    sourceArray: boolArray,
                    destinationArray: resultArray,
                    length: Math.Min(boolArray.Length, 10));
                return resultArray;

            }
            else
            {
                throw new InvalidOperationException("Unsupported type");
            }
        }
    }
}
