namespace GetFilesInFolder
{
    partial class GetMediaList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            BooksRadioButton = new RadioButton();
            AudioBooksRadioButton = new RadioButton();
            TvShowsRadioButton = new RadioButton();
            MovieRadioButton = new RadioButton();
            MusicRadioButton = new RadioButton();
            DirectoryTextBox = new TextBox();
            ChooseDirectoryButton = new Button();
            CreateButton = new Button();
            ResultRichTextBox = new RichTextBox();
            label1 = new Label();
            IncludeSubDirCheckBox = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BooksRadioButton);
            groupBox1.Controls.Add(AudioBooksRadioButton);
            groupBox1.Controls.Add(TvShowsRadioButton);
            groupBox1.Controls.Add(MovieRadioButton);
            groupBox1.Controls.Add(MusicRadioButton);
            groupBox1.Location = new Point(23, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(138, 201);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Media Type";
            // 
            // BooksRadioButton
            // 
            BooksRadioButton.AutoSize = true;
            BooksRadioButton.Location = new Point(24, 165);
            BooksRadioButton.Name = "BooksRadioButton";
            BooksRadioButton.Size = new Size(57, 19);
            BooksRadioButton.TabIndex = 4;
            BooksRadioButton.TabStop = true;
            BooksRadioButton.Text = "Books";
            BooksRadioButton.UseVisualStyleBackColor = true;
            // 
            // AudioBooksRadioButton
            // 
            AudioBooksRadioButton.AutoSize = true;
            AudioBooksRadioButton.Location = new Point(24, 131);
            AudioBooksRadioButton.Name = "AudioBooksRadioButton";
            AudioBooksRadioButton.Size = new Size(92, 19);
            AudioBooksRadioButton.TabIndex = 3;
            AudioBooksRadioButton.TabStop = true;
            AudioBooksRadioButton.Text = "Audio Books";
            AudioBooksRadioButton.UseVisualStyleBackColor = true;
            // 
            // TvShowsRadioButton
            // 
            TvShowsRadioButton.AutoSize = true;
            TvShowsRadioButton.Location = new Point(24, 97);
            TvShowsRadioButton.Name = "TvShowsRadioButton";
            TvShowsRadioButton.Size = new Size(75, 19);
            TvShowsRadioButton.TabIndex = 2;
            TvShowsRadioButton.TabStop = true;
            TvShowsRadioButton.Text = "TV Shows";
            TvShowsRadioButton.UseVisualStyleBackColor = true;
            // 
            // MovieRadioButton
            // 
            MovieRadioButton.AutoSize = true;
            MovieRadioButton.Location = new Point(24, 64);
            MovieRadioButton.Name = "MovieRadioButton";
            MovieRadioButton.Size = new Size(58, 19);
            MovieRadioButton.TabIndex = 1;
            MovieRadioButton.TabStop = true;
            MovieRadioButton.Text = "Movie";
            MovieRadioButton.UseVisualStyleBackColor = true;
            // 
            // MusicRadioButton
            // 
            MusicRadioButton.AutoSize = true;
            MusicRadioButton.Checked = true;
            MusicRadioButton.Location = new Point(24, 30);
            MusicRadioButton.Name = "MusicRadioButton";
            MusicRadioButton.Size = new Size(57, 19);
            MusicRadioButton.TabIndex = 0;
            MusicRadioButton.TabStop = true;
            MusicRadioButton.Text = "Music";
            MusicRadioButton.UseVisualStyleBackColor = true;
            // 
            // DirectoryTextBox
            // 
            DirectoryTextBox.Location = new Point(236, 27);
            DirectoryTextBox.Name = "DirectoryTextBox";
            DirectoryTextBox.Size = new Size(956, 23);
            DirectoryTextBox.TabIndex = 1;
            // 
            // ChooseDirectoryButton
            // 
            ChooseDirectoryButton.Location = new Point(1208, 27);
            ChooseDirectoryButton.Name = "ChooseDirectoryButton";
            ChooseDirectoryButton.Size = new Size(33, 23);
            ChooseDirectoryButton.TabIndex = 2;
            ChooseDirectoryButton.Text = "· · ·";
            ChooseDirectoryButton.UseVisualStyleBackColor = true;
            ChooseDirectoryButton.Click += ChooseDirectoryButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(1166, 195);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(75, 23);
            CreateButton.TabIndex = 3;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // ResultRichTextBox
            // 
            ResultRichTextBox.Location = new Point(23, 224);
            ResultRichTextBox.Name = "ResultRichTextBox";
            ResultRichTextBox.Size = new Size(1221, 559);
            ResultRichTextBox.TabIndex = 4;
            ResultRichTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 5;
            label1.Text = "Directory:";
            // 
            // IncludeSubDirCheckBox
            // 
            IncludeSubDirCheckBox.AutoSize = true;
            IncludeSubDirCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            IncludeSubDirCheckBox.Location = new Point(1094, 170);
            IncludeSubDirCheckBox.Name = "IncludeSubDirCheckBox";
            IncludeSubDirCheckBox.Size = new Size(147, 19);
            IncludeSubDirCheckBox.TabIndex = 6;
            IncludeSubDirCheckBox.Text = "Include Sub Directories";
            IncludeSubDirCheckBox.UseVisualStyleBackColor = true;
            // 
            // GetMediaList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 804);
            Controls.Add(IncludeSubDirCheckBox);
            Controls.Add(label1);
            Controls.Add(ResultRichTextBox);
            Controls.Add(CreateButton);
            Controls.Add(ChooseDirectoryButton);
            Controls.Add(DirectoryTextBox);
            Controls.Add(groupBox1);
            Name = "GetMediaList";
            Text = "Get Media List";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton MusicRadioButton;
        private RadioButton TvShowsRadioButton;
        private RadioButton MovieRadioButton;
        private RadioButton AudioBooksRadioButton;
        private RadioButton BooksRadioButton;
        private TextBox DirectoryTextBox;
        private Button ChooseDirectoryButton;
        private Button CreateButton;
        private RichTextBox ResultRichTextBox;
        private Label label1;
        private CheckBox IncludeSubDirCheckBox;
    }
}
