namespace TextTool
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxTools = new System.Windows.Forms.ComboBox();
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonSearchInput = new System.Windows.Forms.RadioButton();
            this.radioButtonDir = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDirName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFileExt = new System.Windows.Forms.TextBox();
            this.buttonSelectDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // comboBoxTools
            // 
            this.comboBoxTools.FormattingEnabled = true;
            this.comboBoxTools.Location = new System.Drawing.Point(79, 12);
            this.comboBoxTools.Name = "comboBoxTools";
            this.comboBoxTools.Size = new System.Drawing.Size(274, 21);
            this.comboBoxTools.TabIndex = 0;
            this.comboBoxTools.SelectedValueChanged += new System.EventHandler(this.comboBoxTools_SelectedValueChanged);
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.Location = new System.Drawing.Point(435, 13);
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(237, 20);
            this.textBoxRegex.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reg Ex:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.Location = new System.Drawing.Point(15, 68);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInput.Size = new System.Drawing.Size(517, 318);
            this.textBoxInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Location = new System.Drawing.Point(548, 68);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(239, 407);
            this.textBoxResult.TabIndex = 6;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(696, 11);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(92, 23);
            this.buttonRun.TabIndex = 7;
            this.buttonRun.Text = "Search";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Predefined:";
            // 
            // radioButtonSearchInput
            // 
            this.radioButtonSearchInput.AutoSize = true;
            this.radioButtonSearchInput.Checked = true;
            this.radioButtonSearchInput.Location = new System.Drawing.Point(15, 45);
            this.radioButtonSearchInput.Name = "radioButtonSearchInput";
            this.radioButtonSearchInput.Size = new System.Drawing.Size(97, 17);
            this.radioButtonSearchInput.TabIndex = 9;
            this.radioButtonSearchInput.TabStop = true;
            this.radioButtonSearchInput.Text = "Search in Text:";
            this.radioButtonSearchInput.UseVisualStyleBackColor = true;
            // 
            // radioButtonDir
            // 
            this.radioButtonDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonDir.AutoSize = true;
            this.radioButtonDir.Location = new System.Drawing.Point(15, 406);
            this.radioButtonDir.Name = "radioButtonDir";
            this.radioButtonDir.Size = new System.Drawing.Size(118, 17);
            this.radioButtonDir.TabIndex = 10;
            this.radioButtonDir.Text = "Search in Directory:";
            this.radioButtonDir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Directory:";
            // 
            // textBoxDirName
            // 
            this.textBoxDirName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxDirName.Location = new System.Drawing.Point(91, 429);
            this.textBoxDirName.Name = "textBoxDirName";
            this.textBoxDirName.Size = new System.Drawing.Size(237, 20);
            this.textBoxDirName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "File ext:";
            // 
            // textBoxFileExt
            // 
            this.textBoxFileExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFileExt.Location = new System.Drawing.Point(91, 455);
            this.textBoxFileExt.Name = "textBoxFileExt";
            this.textBoxFileExt.Size = new System.Drawing.Size(237, 20);
            this.textBoxFileExt.TabIndex = 13;
            this.textBoxFileExt.Text = "*.cs";
            // 
            // buttonSelectDir
            // 
            this.buttonSelectDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSelectDir.Location = new System.Drawing.Point(334, 427);
            this.buttonSelectDir.Name = "buttonSelectDir";
            this.buttonSelectDir.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectDir.TabIndex = 15;
            this.buttonSelectDir.Text = "Select...";
            this.buttonSelectDir.UseVisualStyleBackColor = true;
            this.buttonSelectDir.Click += new System.EventHandler(this.buttonSelectDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 487);
            this.Controls.Add(this.buttonSelectDir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFileExt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDirName);
            this.Controls.Add(this.radioButtonDir);
            this.Controls.Add(this.radioButtonSearchInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRegex);
            this.Controls.Add(this.comboBoxTools);
            this.MinimumSize = new System.Drawing.Size(815, 526);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTools;
        private System.Windows.Forms.TextBox textBoxRegex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonSearchInput;
        private System.Windows.Forms.RadioButton radioButtonDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDirName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFileExt;
        private System.Windows.Forms.Button buttonSelectDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

