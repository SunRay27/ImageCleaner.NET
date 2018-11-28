namespace ImageCleaner
{
    partial class Window
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.fileList = new System.Windows.Forms.ListView();
            this.filesButton = new System.Windows.Forms.Button();
            this.templateButton = new System.Windows.Forms.Button();
            this.templateImage = new System.Windows.Forms.PictureBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.colorButton = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.percentLabel = new System.Windows.Forms.Label();
            this.templateList = new System.Windows.Forms.ListView();
            this.fileImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.templateImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.916231F);
            this.startButton.Location = new System.Drawing.Point(1005, 813);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(440, 81);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Process selected image(s)";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 859);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(815, 35);
            this.progressBar.TabIndex = 1;
            // 
            // fileList
            // 
            this.fileList.GridLines = true;
            this.fileList.Location = new System.Drawing.Point(12, 12);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(394, 759);
            this.fileList.TabIndex = 2;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.View = System.Windows.Forms.View.List;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged);
            // 
            // filesButton
            // 
            this.filesButton.Location = new System.Drawing.Point(12, 786);
            this.filesButton.Name = "filesButton";
            this.filesButton.Size = new System.Drawing.Size(394, 48);
            this.filesButton.TabIndex = 3;
            this.filesButton.Text = "Select image(s)...";
            this.filesButton.UseVisualStyleBackColor = true;
            this.filesButton.Click += new System.EventHandler(this.filesButton_Click);
            // 
            // templateButton
            // 
            this.templateButton.Location = new System.Drawing.Point(433, 786);
            this.templateButton.Name = "templateButton";
            this.templateButton.Size = new System.Drawing.Size(394, 48);
            this.templateButton.TabIndex = 4;
            this.templateButton.Text = "Select template image(s)...";
            this.templateButton.UseVisualStyleBackColor = true;
            this.templateButton.Click += new System.EventHandler(this.templateButton_Click);
            // 
            // templateImage
            // 
            this.templateImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.templateImage.Location = new System.Drawing.Point(1000, 12);
            this.templateImage.Name = "templateImage";
            this.templateImage.Size = new System.Drawing.Size(317, 139);
            this.templateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.templateImage.TabIndex = 5;
            this.templateImage.TabStop = false;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathLabel.Location = new System.Drawing.Point(1104, 517);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(196, 26);
            this.pathLabel.TabIndex = 6;
            this.pathLabel.Text = "PATH IS NOT SET";
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(1135, 562);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(182, 46);
            this.pathButton.TabIndex = 7;
            this.pathButton.Text = "Set output path";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(517, 798);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 26);
            this.errorLabel.TabIndex = 8;
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(855, 562);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(106, 46);
            this.colorButton.TabIndex = 9;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(855, 506);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(106, 50);
            this.colorPanel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(861, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Match";
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(969, 669);
            this.trackBar.Maximum = 100;
            this.trackBar.Minimum = 75;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(429, 90);
            this.trackBar.TabIndex = 13;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar.Value = 90;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(868, 702);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(56, 26);
            this.percentLabel.TabIndex = 14;
            this.percentLabel.Text = "90%";
            // 
            // templateList
            // 
            this.templateList.GridLines = true;
            this.templateList.Location = new System.Drawing.Point(433, 12);
            this.templateList.Name = "templateList";
            this.templateList.Size = new System.Drawing.Size(394, 759);
            this.templateList.TabIndex = 15;
            this.templateList.UseCompatibleStateImageBehavior = false;
            this.templateList.View = System.Windows.Forms.View.List;
            this.templateList.SelectedIndexChanged += new System.EventHandler(this.templateList_SelectedIndexChanged);
            // 
            // fileImage
            // 
            this.fileImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileImage.Location = new System.Drawing.Point(855, 176);
            this.fileImage.Name = "fileImage";
            this.fileImage.Size = new System.Drawing.Size(602, 311);
            this.fileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileImage.TabIndex = 16;
            this.fileImage.TabStop = false;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(191F, 191F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1550, 976);
            this.Controls.Add(this.fileImage);
            this.Controls.Add(this.templateList);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.templateImage);
            this.Controls.Add(this.templateButton);
            this.Controls.Add(this.filesButton);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Cleaner v0.12";
            ((System.ComponentModel.ISupportInitialize)(this.templateImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListView fileList;
        private System.Windows.Forms.Button filesButton;
        private System.Windows.Forms.Button templateButton;
        private System.Windows.Forms.PictureBox templateImage;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.ListView templateList;
        private System.Windows.Forms.PictureBox fileImage;
    }
}

