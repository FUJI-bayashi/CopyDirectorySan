
namespace CopyDirectorySan
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_CopySource = new System.Windows.Forms.Label();
            this.label_CopyDest = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox_Path_Source = new System.Windows.Forms.TextBox();
            this.button_Browse_Source = new System.Windows.Forms.Button();
            this.textBox_Path_Dest = new System.Windows.Forms.TextBox();
            this.button_Browse_Dest = new System.Windows.Forms.Button();
            this.radioButton_Style1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Style3 = new System.Windows.Forms.RadioButton();
            this.label_Settings = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_TemplateTitle = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_Quote = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button_RunCopy = new System.Windows.Forms.Button();
            this.radioButton_Style5 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_Holi = new System.Windows.Forms.PictureBox();
            this.pictureBox_Balloon = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.radioButton_Template1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Template2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Template3 = new System.Windows.Forms.RadioButton();
            this.radioButton_Template4 = new System.Windows.Forms.RadioButton();
            this.radioButton_Template5 = new System.Windows.Forms.RadioButton();
            this.radioButton_Template10 = new System.Windows.Forms.RadioButton();
            this.radioButton_Template9 = new System.Windows.Forms.RadioButton();
            this.radioButton_Template8 = new System.Windows.Forms.RadioButton();
            this.radioButton_Template7 = new System.Windows.Forms.RadioButton();
            this.radioButton_Template6 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_Style2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Style4 = new System.Windows.Forms.RadioButton();
            this.checkBox_OpenDestDirAfterComp = new System.Windows.Forms.CheckBox();
            this.label_Credit = new System.Windows.Forms.Label();
            this.pictureBox_Credit = new System.Windows.Forms.PictureBox();
            this.checkBox_Overwrite = new System.Windows.Forms.CheckBox();
            this.button_OpenDirSource = new System.Windows.Forms.Button();
            this.button_OpenDirDest = new System.Windows.Forms.Button();
            this.button_DeleteCurrentTemplate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Holi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Balloon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Credit)).BeginInit();
            this.SuspendLayout();
            // 
            // label_CopySource
            // 
            this.label_CopySource.AutoSize = true;
            this.label_CopySource.Location = new System.Drawing.Point(14, 64);
            this.label_CopySource.Name = "label_CopySource";
            this.label_CopySource.Size = new System.Drawing.Size(86, 12);
            this.label_CopySource.TabIndex = 0;
            this.label_CopySource.Text = "コピーするフォルダ";
            this.label_CopySource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CopyDest
            // 
            this.label_CopyDest.AutoSize = true;
            this.label_CopyDest.Location = new System.Drawing.Point(360, 64);
            this.label_CopyDest.Name = "label_CopyDest";
            this.label_CopyDest.Size = new System.Drawing.Size(76, 12);
            this.label_CopyDest.TabIndex = 2;
            this.label_CopyDest.Text = "保存先フォルダ";
            this.label_CopyDest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Path_Source
            // 
            this.textBox_Path_Source.AllowDrop = true;
            this.textBox_Path_Source.Location = new System.Drawing.Point(12, 79);
            this.textBox_Path_Source.Multiline = true;
            this.textBox_Path_Source.Name = "textBox_Path_Source";
            this.textBox_Path_Source.Size = new System.Drawing.Size(263, 50);
            this.textBox_Path_Source.TabIndex = 3;
            // 
            // button_Browse_Source
            // 
            this.button_Browse_Source.AutoSize = true;
            this.button_Browse_Source.Location = new System.Drawing.Point(283, 79);
            this.button_Browse_Source.Name = "button_Browse_Source";
            this.button_Browse_Source.Size = new System.Drawing.Size(50, 25);
            this.button_Browse_Source.TabIndex = 4;
            this.button_Browse_Source.Text = "参照";
            this.button_Browse_Source.UseVisualStyleBackColor = true;
            // 
            // textBox_Path_Dest
            // 
            this.textBox_Path_Dest.AllowDrop = true;
            this.textBox_Path_Dest.Location = new System.Drawing.Point(362, 79);
            this.textBox_Path_Dest.Multiline = true;
            this.textBox_Path_Dest.Name = "textBox_Path_Dest";
            this.textBox_Path_Dest.Size = new System.Drawing.Size(263, 50);
            this.textBox_Path_Dest.TabIndex = 5;
            // 
            // button_Browse_Dest
            // 
            this.button_Browse_Dest.AutoSize = true;
            this.button_Browse_Dest.Location = new System.Drawing.Point(633, 79);
            this.button_Browse_Dest.Name = "button_Browse_Dest";
            this.button_Browse_Dest.Size = new System.Drawing.Size(50, 25);
            this.button_Browse_Dest.TabIndex = 6;
            this.button_Browse_Dest.Text = "参照";
            this.button_Browse_Dest.UseVisualStyleBackColor = true;
            // 
            // radioButton_Style1
            // 
            this.radioButton_Style1.AutoSize = true;
            this.radioButton_Style1.Location = new System.Drawing.Point(12, 172);
            this.radioButton_Style1.Name = "radioButton_Style1";
            this.radioButton_Style1.Size = new System.Drawing.Size(258, 16);
            this.radioButton_Style1.TabIndex = 9;
            this.radioButton_Style1.TabStop = true;
            this.radioButton_Style1.Text = "フォルダ名の先頭にコピーした【年月日】を付与する";
            this.radioButton_Style1.UseVisualStyleBackColor = true;
            // 
            // radioButton_Style3
            // 
            this.radioButton_Style3.AutoSize = true;
            this.radioButton_Style3.Location = new System.Drawing.Point(12, 214);
            this.radioButton_Style3.Name = "radioButton_Style3";
            this.radioButton_Style3.Size = new System.Drawing.Size(263, 16);
            this.radioButton_Style3.TabIndex = 10;
            this.radioButton_Style3.TabStop = true;
            this.radioButton_Style3.Text = "【年月日】名フォルダを作成してそのなかにコピーする";
            this.radioButton_Style3.UseVisualStyleBackColor = true;
            // 
            // label_Settings
            // 
            this.label_Settings.AutoSize = true;
            this.label_Settings.Location = new System.Drawing.Point(14, 148);
            this.label_Settings.Name = "label_Settings";
            this.label_Settings.Size = new System.Drawing.Size(29, 12);
            this.label_Settings.TabIndex = 11;
            this.label_Settings.Text = "設定";
            this.label_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 31;
            // 
            // label_TemplateTitle
            // 
            this.label_TemplateTitle.AutoSize = true;
            this.label_TemplateTitle.Location = new System.Drawing.Point(12, 23);
            this.label_TemplateTitle.Name = "label_TemplateTitle";
            this.label_TemplateTitle.Size = new System.Drawing.Size(59, 12);
            this.label_TemplateTitle.TabIndex = 15;
            this.label_TemplateTitle.Text = "テンプレート";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 466);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(669, 23);
            this.progressBar1.TabIndex = 25;
            // 
            // label_Quote
            // 
            this.label_Quote.BackColor = System.Drawing.Color.Transparent;
            this.label_Quote.Location = new System.Drawing.Point(37, 337);
            this.label_Quote.Name = "label_Quote";
            this.label_Quote.Size = new System.Drawing.Size(416, 108);
            this.label_Quote.TabIndex = 28;
            this.label_Quote.Text = "これは指定したフォルダをボタン一つでコピーするだけのソフトです。\r\n\r\n参照ボタンでコピー元、コピー先のフォルダを指定してください。\r\nパスは直接入力できますが、" +
    "誤ったパスでコピーしようとするとエラーになります。\r\n\r\nコピーすると、現在選択されているテンプレートにパスが保存されます。\r\nテンプレートは次回起動時に自動的" +
    "に復元されます。\r\n\r\nわからない機能があればカーソルを合わせてください。";
            this.label_Quote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button_RunCopy
            // 
            this.button_RunCopy.Location = new System.Drawing.Point(466, 148);
            this.button_RunCopy.Name = "button_RunCopy";
            this.button_RunCopy.Size = new System.Drawing.Size(217, 56);
            this.button_RunCopy.TabIndex = 29;
            this.button_RunCopy.Text = "コピーする";
            this.button_RunCopy.UseVisualStyleBackColor = true;
            // 
            // radioButton_Style5
            // 
            this.radioButton_Style5.AutoSize = true;
            this.radioButton_Style5.Location = new System.Drawing.Point(12, 256);
            this.radioButton_Style5.Name = "radioButton_Style5";
            this.radioButton_Style5.Size = new System.Drawing.Size(106, 16);
            this.radioButton_Style5.TabIndex = 30;
            this.radioButton_Style5.TabStop = true;
            this.radioButton_Style5.Text = "そのままコピーする";
            this.radioButton_Style5.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox_Holi
            // 
            this.pictureBox_Holi.BackgroundImage = global::CopyDirectorySan.Properties.Resources.Holi;
            this.pictureBox_Holi.Location = new System.Drawing.Point(466, 216);
            this.pictureBox_Holi.Name = "pictureBox_Holi";
            this.pictureBox_Holi.Size = new System.Drawing.Size(217, 239);
            this.pictureBox_Holi.TabIndex = 26;
            this.pictureBox_Holi.TabStop = false;
            // 
            // pictureBox_Balloon
            // 
            this.pictureBox_Balloon.BackgroundImage = global::CopyDirectorySan.Properties.Resources.Balloon;
            this.pictureBox_Balloon.Location = new System.Drawing.Point(12, 327);
            this.pictureBox_Balloon.Name = "pictureBox_Balloon";
            this.pictureBox_Balloon.Size = new System.Drawing.Size(441, 128);
            this.pictureBox_Balloon.TabIndex = 31;
            this.pictureBox_Balloon.TabStop = false;
            // 
            // radioButton_Template1
            // 
            this.radioButton_Template1.AutoSize = true;
            this.radioButton_Template1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_Template1.Location = new System.Drawing.Point(10, 12);
            this.radioButton_Template1.Name = "radioButton_Template1";
            this.radioButton_Template1.Size = new System.Drawing.Size(15, 29);
            this.radioButton_Template1.TabIndex = 34;
            this.radioButton_Template1.TabStop = true;
            this.radioButton_Template1.Text = "1";
            this.radioButton_Template1.UseVisualStyleBackColor = true;
            // 
            // radioButton_Template2
            // 
            this.radioButton_Template2.AutoSize = true;
            this.radioButton_Template2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_Template2.Location = new System.Drawing.Point(35, 12);
            this.radioButton_Template2.Name = "radioButton_Template2";
            this.radioButton_Template2.Size = new System.Drawing.Size(15, 29);
            this.radioButton_Template2.TabIndex = 35;
            this.radioButton_Template2.TabStop = true;
            this.radioButton_Template2.Text = "2";
            this.radioButton_Template2.UseVisualStyleBackColor = true;
            // 
            // radioButton_Template3
            // 
            this.radioButton_Template3.AutoSize = true;
            this.radioButton_Template3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_Template3.Location = new System.Drawing.Point(60, 12);
            this.radioButton_Template3.Name = "radioButton_Template3";
            this.radioButton_Template3.Size = new System.Drawing.Size(15, 29);
            this.radioButton_Template3.TabIndex = 36;
            this.radioButton_Template3.TabStop = true;
            this.radioButton_Template3.Text = "3";
            this.radioButton_Template3.UseVisualStyleBackColor = true;
            // 
            // radioButton_Template4
            // 
            this.radioButton_Template4.AutoSize = true;
            this.radioButton_Template4.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_Template4.Location = new System.Drawing.Point(85, 12);
            this.radioButton_Template4.Name = "radioButton_Template4";
            this.radioButton_Template4.Size = new System.Drawing.Size(15, 29);
            this.radioButton_Template4.TabIndex = 37;
            this.radioButton_Template4.TabStop = true;
            this.radioButton_Template4.Text = "4";
            this.radioButton_Template4.UseVisualStyleBackColor = true;
            // 
            // radioButton_Template5
            // 
            this.radioButton_Template5.AutoSize = true;
            this.radioButton_Template5.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_Template5.Location = new System.Drawing.Point(110, 12);
            this.radioButton_Template5.Name = "radioButton_Template5";
            this.radioButton_Template5.Size = new System.Drawing.Size(15, 29);
            this.radioButton_Template5.TabIndex = 38;
            this.radioButton_Template5.TabStop = true;
            this.radioButton_Template5.Text = "5";
            this.radioButton_Template5.UseVisualStyleBackColor = true;
            // 
            // radioButton_Template10
            // 
            this.radioButton_Template10.AutoSize = true;
            this.radioButton_Template10.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_Template10.Location = new System.Drawing.Point(235, 12);
            this.radioButton_Template10.Name = "radioButton_Template10";
            this.radioButton_Template10.Size = new System.Drawing.Size(21, 29);
            this.radioButton_Template10.TabIndex = 43;
            this.radioButton_Template10.TabStop = true;
            this.radioButton_Template10.Text = "10";
            this.radioButton_Template10.UseVisualStyleBackColor = true;
            // 
            // radioButton_Template9
            // 
            this.radioButton_Template9.AutoSize = true;
            this.radioButton_Template9.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_Template9.Location = new System.Drawing.Point(210, 12);
            this.radioButton_Template9.Name = "radioButton_Template9";
            this.radioButton_Template9.Size = new System.Drawing.Size(15, 29);
            this.radioButton_Template9.TabIndex = 42;
            this.radioButton_Template9.TabStop = true;
            this.radioButton_Template9.Text = "9";
            this.radioButton_Template9.UseVisualStyleBackColor = true;
            // 
            // radioButton_Template8
            // 
            this.radioButton_Template8.AutoSize = true;
            this.radioButton_Template8.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_Template8.Location = new System.Drawing.Point(185, 12);
            this.radioButton_Template8.Name = "radioButton_Template8";
            this.radioButton_Template8.Size = new System.Drawing.Size(15, 29);
            this.radioButton_Template8.TabIndex = 41;
            this.radioButton_Template8.TabStop = true;
            this.radioButton_Template8.Text = "8";
            this.radioButton_Template8.UseVisualStyleBackColor = true;
            // 
            // radioButton_Template7
            // 
            this.radioButton_Template7.AutoSize = true;
            this.radioButton_Template7.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_Template7.Location = new System.Drawing.Point(160, 12);
            this.radioButton_Template7.Name = "radioButton_Template7";
            this.radioButton_Template7.Size = new System.Drawing.Size(15, 29);
            this.radioButton_Template7.TabIndex = 40;
            this.radioButton_Template7.TabStop = true;
            this.radioButton_Template7.Text = "7";
            this.radioButton_Template7.UseVisualStyleBackColor = true;
            // 
            // radioButton_Template6
            // 
            this.radioButton_Template6.AutoSize = true;
            this.radioButton_Template6.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton_Template6.Location = new System.Drawing.Point(135, 12);
            this.radioButton_Template6.Name = "radioButton_Template6";
            this.radioButton_Template6.Size = new System.Drawing.Size(15, 29);
            this.radioButton_Template6.TabIndex = 39;
            this.radioButton_Template6.TabStop = true;
            this.radioButton_Template6.Text = "6";
            this.radioButton_Template6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_Template10);
            this.panel1.Controls.Add(this.radioButton_Template1);
            this.panel1.Controls.Add(this.radioButton_Template9);
            this.panel1.Controls.Add(this.radioButton_Template2);
            this.panel1.Controls.Add(this.radioButton_Template8);
            this.panel1.Controls.Add(this.radioButton_Template3);
            this.panel1.Controls.Add(this.radioButton_Template7);
            this.panel1.Controls.Add(this.radioButton_Template4);
            this.panel1.Controls.Add(this.radioButton_Template6);
            this.panel1.Controls.Add(this.radioButton_Template5);
            this.panel1.Location = new System.Drawing.Point(75, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 50);
            this.panel1.TabIndex = 36;
            // 
            // radioButton_Style2
            // 
            this.radioButton_Style2.AutoSize = true;
            this.radioButton_Style2.Location = new System.Drawing.Point(12, 193);
            this.radioButton_Style2.Name = "radioButton_Style2";
            this.radioButton_Style2.Size = new System.Drawing.Size(294, 16);
            this.radioButton_Style2.TabIndex = 37;
            this.radioButton_Style2.TabStop = true;
            this.radioButton_Style2.Text = "フォルダ名の先頭にコピーした【年月日時分秒】を付与する";
            this.radioButton_Style2.UseVisualStyleBackColor = true;
            // 
            // radioButton_Style4
            // 
            this.radioButton_Style4.AutoSize = true;
            this.radioButton_Style4.Location = new System.Drawing.Point(12, 235);
            this.radioButton_Style4.Name = "radioButton_Style4";
            this.radioButton_Style4.Size = new System.Drawing.Size(299, 16);
            this.radioButton_Style4.TabIndex = 38;
            this.radioButton_Style4.TabStop = true;
            this.radioButton_Style4.Text = "【年月日時分秒】名フォルダを作成してそのなかにコピーする";
            this.radioButton_Style4.UseVisualStyleBackColor = true;
            // 
            // checkBox_OpenDestDirAfterComp
            // 
            this.checkBox_OpenDestDirAfterComp.AutoSize = true;
            this.checkBox_OpenDestDirAfterComp.Location = new System.Drawing.Point(12, 305);
            this.checkBox_OpenDestDirAfterComp.Name = "checkBox_OpenDestDirAfterComp";
            this.checkBox_OpenDestDirAfterComp.Size = new System.Drawing.Size(167, 16);
            this.checkBox_OpenDestDirAfterComp.TabIndex = 39;
            this.checkBox_OpenDestDirAfterComp.Text = "完了後に保存先フォルダを開く";
            this.checkBox_OpenDestDirAfterComp.UseVisualStyleBackColor = true;
            // 
            // label_Credit
            // 
            this.label_Credit.AutoSize = true;
            this.label_Credit.Location = new System.Drawing.Point(557, 25);
            this.label_Credit.Name = "label_Credit";
            this.label_Credit.Size = new System.Drawing.Size(74, 12);
            this.label_Credit.TabIndex = 40;
            this.label_Credit.Text = "Developed by";
            // 
            // pictureBox_Credit
            // 
            this.pictureBox_Credit.BackgroundImage = global::CopyDirectorySan.Properties.Resources.Kittypool;
            this.pictureBox_Credit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Credit.Location = new System.Drawing.Point(633, 5);
            this.pictureBox_Credit.Name = "pictureBox_Credit";
            this.pictureBox_Credit.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Credit.TabIndex = 41;
            this.pictureBox_Credit.TabStop = false;
            // 
            // checkBox_Overwrite
            // 
            this.checkBox_Overwrite.AutoSize = true;
            this.checkBox_Overwrite.Location = new System.Drawing.Point(12, 282);
            this.checkBox_Overwrite.Name = "checkBox_Overwrite";
            this.checkBox_Overwrite.Size = new System.Drawing.Size(375, 16);
            this.checkBox_Overwrite.TabIndex = 43;
            this.checkBox_Overwrite.Text = "コピー時、既に保存先フォルダが存在していた場合、上書き保存を許可する";
            this.checkBox_Overwrite.UseVisualStyleBackColor = true;
            // 
            // button_OpenDirSource
            // 
            this.button_OpenDirSource.AutoSize = true;
            this.button_OpenDirSource.Location = new System.Drawing.Point(283, 104);
            this.button_OpenDirSource.Name = "button_OpenDirSource";
            this.button_OpenDirSource.Size = new System.Drawing.Size(50, 25);
            this.button_OpenDirSource.TabIndex = 44;
            this.button_OpenDirSource.Text = "開く";
            this.button_OpenDirSource.UseVisualStyleBackColor = true;
            // 
            // button_OpenDirDest
            // 
            this.button_OpenDirDest.AutoSize = true;
            this.button_OpenDirDest.Location = new System.Drawing.Point(633, 104);
            this.button_OpenDirDest.Name = "button_OpenDirDest";
            this.button_OpenDirDest.Size = new System.Drawing.Size(50, 25);
            this.button_OpenDirDest.TabIndex = 45;
            this.button_OpenDirDest.Text = "開く";
            this.button_OpenDirDest.UseVisualStyleBackColor = true;
            // 
            // button_DeleteCurrentTemplate
            // 
            this.button_DeleteCurrentTemplate.Location = new System.Drawing.Point(362, 9);
            this.button_DeleteCurrentTemplate.Name = "button_DeleteCurrentTemplate";
            this.button_DeleteCurrentTemplate.Size = new System.Drawing.Size(129, 35);
            this.button_DeleteCurrentTemplate.TabIndex = 46;
            this.button_DeleteCurrentTemplate.Text = "現在のテンプレートを\r\n削除する";
            this.button_DeleteCurrentTemplate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 494);
            this.Controls.Add(this.button_DeleteCurrentTemplate);
            this.Controls.Add(this.button_OpenDirSource);
            this.Controls.Add(this.button_OpenDirDest);
            this.Controls.Add(this.checkBox_Overwrite);
            this.Controls.Add(this.pictureBox_Credit);
            this.Controls.Add(this.label_Credit);
            this.Controls.Add(this.checkBox_OpenDestDirAfterComp);
            this.Controls.Add(this.radioButton_Style4);
            this.Controls.Add(this.radioButton_Style2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton_Style5);
            this.Controls.Add(this.button_RunCopy);
            this.Controls.Add(this.label_Quote);
            this.Controls.Add(this.pictureBox_Holi);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_TemplateTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_Settings);
            this.Controls.Add(this.label_CopySource);
            this.Controls.Add(this.label_CopyDest);
            this.Controls.Add(this.radioButton_Style1);
            this.Controls.Add(this.radioButton_Style3);
            this.Controls.Add(this.button_Browse_Source);
            this.Controls.Add(this.button_Browse_Dest);
            this.Controls.Add(this.textBox_Path_Source);
            this.Controls.Add(this.textBox_Path_Dest);
            this.Controls.Add(this.pictureBox_Balloon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "フォルダコピーさん";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Holi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Balloon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Credit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label_CopySource;
        private System.Windows.Forms.Label label_CopyDest;
        private System.Windows.Forms.TextBox textBox_Path_Source;
        private System.Windows.Forms.Button button_Browse_Source;
        private System.Windows.Forms.TextBox textBox_Path_Dest;
        private System.Windows.Forms.Button button_Browse_Dest;
        private System.Windows.Forms.RadioButton radioButton_Style1;
        private System.Windows.Forms.RadioButton radioButton_Style3;
        private System.Windows.Forms.Label label_Settings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_TemplateTitle;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox_Holi;
        private System.Windows.Forms.Label label_Quote;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RadioButton radioButton_Style5;
        private System.Windows.Forms.Button button_RunCopy;
        private System.Windows.Forms.PictureBox pictureBox_Balloon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.RadioButton radioButton_Template10;
        private System.Windows.Forms.RadioButton radioButton_Template9;
        private System.Windows.Forms.RadioButton radioButton_Template8;
        private System.Windows.Forms.RadioButton radioButton_Template7;
        private System.Windows.Forms.RadioButton radioButton_Template6;
        private System.Windows.Forms.RadioButton radioButton_Template5;
        private System.Windows.Forms.RadioButton radioButton_Template4;
        private System.Windows.Forms.RadioButton radioButton_Template3;
        private System.Windows.Forms.RadioButton radioButton_Template2;
        private System.Windows.Forms.RadioButton radioButton_Template1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_OpenDestDirAfterComp;
        private System.Windows.Forms.RadioButton radioButton_Style4;
        private System.Windows.Forms.RadioButton radioButton_Style2;
        private System.Windows.Forms.PictureBox pictureBox_Credit;
        private System.Windows.Forms.Label label_Credit;
        private System.Windows.Forms.CheckBox checkBox_Overwrite;
        private System.Windows.Forms.Button button_OpenDirSource;
        private System.Windows.Forms.Button button_OpenDirDest;
        private System.Windows.Forms.Button button_DeleteCurrentTemplate;
    }
}

