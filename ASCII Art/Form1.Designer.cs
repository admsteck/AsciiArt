namespace BBIS.ASCIIArt
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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelFile = new System.Windows.Forms.Label();
            this.labelScale = new System.Windows.Forms.Label();
            this.numericUpDownScale = new System.Windows.Forms.NumericUpDown();
            this.labelPreview = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxPath.Location = new System.Drawing.Point(3, 35);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(468, 22);
            this.textBoxPath.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBrowse.Location = new System.Drawing.Point(477, 34);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(30, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGenerate.Location = new System.Drawing.Point(567, 34);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(84, 23);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // webBrowser1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.webBrowser1, 5);
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 93);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(728, 462);
            this.webBrowser1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxPath, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonBrowse, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonGenerate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelScale, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownScale, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPreview, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 558);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // labelFile
            // 
            this.labelFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(3, 13);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(30, 17);
            this.labelFile.TabIndex = 4;
            this.labelFile.Text = "File";
            // 
            // labelScale
            // 
            this.labelScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(517, 13);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(43, 17);
            this.labelScale.TabIndex = 5;
            this.labelScale.Text = "Scale";
            // 
            // numericUpDownScale
            // 
            this.numericUpDownScale.Location = new System.Drawing.Point(517, 33);
            this.numericUpDownScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScale.Name = "numericUpDownScale";
            this.numericUpDownScale.Size = new System.Drawing.Size(44, 22);
            this.numericUpDownScale.TabIndex = 6;
            this.numericUpDownScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPreview
            // 
            this.labelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPreview.AutoSize = true;
            this.labelPreview.Location = new System.Drawing.Point(3, 73);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(57, 17);
            this.labelPreview.TabIndex = 7;
            this.labelPreview.Text = "Preview";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(657, 33);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(74, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Select a file to open.";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "html";
            this.saveFileDialog1.Filter = "Web page (*.html)|*.html";
            this.saveFileDialog1.Title = "Select a location to save";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 558);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "ASCII Art Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.NumericUpDown numericUpDownScale;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelPreview;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

