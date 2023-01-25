namespace FileReader_MunaShabab
{
    partial class Form1
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
            this.fileNameDesLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.readButton = new System.Windows.Forms.Button();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.browseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileNameDesLabel
            // 
            this.fileNameDesLabel.AutoSize = true;
            this.fileNameDesLabel.Location = new System.Drawing.Point(95, 19);
            this.fileNameDesLabel.Name = "fileNameDesLabel";
            this.fileNameDesLabel.Size = new System.Drawing.Size(202, 13);
            this.fileNameDesLabel.TabIndex = 0;
            this.fileNameDesLabel.Text = "Please Enter A File Path And a File Name";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(98, 49);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(199, 20);
            this.fileNameTextBox.TabIndex = 1;
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(127, 88);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(146, 23);
            this.readButton.TabIndex = 2;
            this.readButton.Text = "Read The File";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.Location = new System.Drawing.Point(43, 144);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(318, 134);
            this.displayListBox.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(303, 46);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 314);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.fileNameDesLabel);
            this.Name = "Form1";
            this.Text = "File Reader Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileNameDesLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browseButton;
    }
}

