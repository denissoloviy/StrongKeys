namespace StrongKeys.DesktopRunner
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileButton = new System.Windows.Forms.Button();
            this.originalPicture = new System.Windows.Forms.PictureBox();
            this.encryptedPicture = new System.Windows.Forms.PictureBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveKeyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyLengthTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.generateKeyButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.initButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.nextStepButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.startGAButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryptedPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "Images (*.png)|*.png";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(3, 3);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "OpenFile";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // originalPicture
            // 
            this.originalPicture.Location = new System.Drawing.Point(3, 32);
            this.originalPicture.Name = "originalPicture";
            this.originalPicture.Size = new System.Drawing.Size(250, 250);
            this.originalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalPicture.TabIndex = 1;
            this.originalPicture.TabStop = false;
            // 
            // encryptedPicture
            // 
            this.encryptedPicture.Location = new System.Drawing.Point(3, 32);
            this.encryptedPicture.Name = "encryptedPicture";
            this.encryptedPicture.Size = new System.Drawing.Size(250, 250);
            this.encryptedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.encryptedPicture.TabIndex = 2;
            this.encryptedPicture.TabStop = false;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(3, 3);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.originalPicture);
            this.panel1.Controls.Add(this.openFileButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 285);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.encryptButton);
            this.panel2.Controls.Add(this.encryptedPicture);
            this.panel2.Location = new System.Drawing.Point(537, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 285);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.saveKeyButton);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.keyLengthTextBox);
            this.panel3.Controls.Add(this.keyTextBox);
            this.panel3.Controls.Add(this.generateKeyButton);
            this.panel3.Location = new System.Drawing.Point(275, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 285);
            this.panel3.TabIndex = 6;
            // 
            // saveKeyButton
            // 
            this.saveKeyButton.Location = new System.Drawing.Point(178, 259);
            this.saveKeyButton.Name = "saveKeyButton";
            this.saveKeyButton.Size = new System.Drawing.Size(75, 23);
            this.saveKeyButton.TabIndex = 4;
            this.saveKeyButton.Text = "Save Key";
            this.saveKeyButton.UseVisualStyleBackColor = true;
            this.saveKeyButton.Click += new System.EventHandler(this.SaveKeyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key length";
            // 
            // keyLengthTextBox
            // 
            this.keyLengthTextBox.Location = new System.Drawing.Point(3, 48);
            this.keyLengthTextBox.Name = "keyLengthTextBox";
            this.keyLengthTextBox.Size = new System.Drawing.Size(250, 20);
            this.keyLengthTextBox.TabIndex = 2;
            this.keyLengthTextBox.Text = "16";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(3, 74);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(250, 208);
            this.keyTextBox.TabIndex = 1;
            // 
            // generateKeyButton
            // 
            this.generateKeyButton.Location = new System.Drawing.Point(3, 3);
            this.generateKeyButton.Name = "generateKeyButton";
            this.generateKeyButton.Size = new System.Drawing.Size(250, 23);
            this.generateKeyButton.TabIndex = 0;
            this.generateKeyButton.Text = "Generate Key";
            this.generateKeyButton.UseVisualStyleBackColor = true;
            this.generateKeyButton.Click += new System.EventHandler(this.GenerateKeyButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.initButton);
            this.panel4.Controls.Add(this.continueButton);
            this.panel4.Controls.Add(this.nextStepButton);
            this.panel4.Controls.Add(this.pauseButton);
            this.panel4.Controls.Add(this.startGAButton);
            this.panel4.Location = new System.Drawing.Point(12, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(782, 158);
            this.panel4.TabIndex = 7;
            // 
            // initButton
            // 
            this.initButton.Location = new System.Drawing.Point(84, 3);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(75, 23);
            this.initButton.TabIndex = 4;
            this.initButton.Text = "Init";
            this.initButton.UseVisualStyleBackColor = true;
            this.initButton.Click += new System.EventHandler(this.InitButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(3, 32);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 3;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Visible = false;
            this.continueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // nextStepButton
            // 
            this.nextStepButton.Location = new System.Drawing.Point(84, 32);
            this.nextStepButton.Name = "nextStepButton";
            this.nextStepButton.Size = new System.Drawing.Size(75, 23);
            this.nextStepButton.TabIndex = 2;
            this.nextStepButton.Text = "Next Step";
            this.nextStepButton.UseVisualStyleBackColor = true;
            this.nextStepButton.Click += new System.EventHandler(this.NextStepButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(3, 32);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // startGAButton
            // 
            this.startGAButton.Location = new System.Drawing.Point(3, 3);
            this.startGAButton.Name = "startGAButton";
            this.startGAButton.Size = new System.Drawing.Size(75, 23);
            this.startGAButton.TabIndex = 0;
            this.startGAButton.Text = "Start GA";
            this.startGAButton.UseVisualStyleBackColor = true;
            this.startGAButton.Click += new System.EventHandler(this.StartGAButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 473);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "Strong Keys Generator";
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryptedPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.PictureBox originalPicture;
        private System.Windows.Forms.PictureBox encryptedPicture;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyLengthTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button generateKeyButton;
        private System.Windows.Forms.Button saveKeyButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button startGAButton;
        private System.Windows.Forms.Button nextStepButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button initButton;
    }
}

