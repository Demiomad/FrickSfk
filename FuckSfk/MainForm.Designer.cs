namespace FuckSfk
{
    partial class MainForm
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
            this.dirLbl = new System.Windows.Forms.Label();
            this.dirBox = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.delSfkChk = new System.Windows.Forms.CheckBox();
            this.delSfapChk = new System.Windows.Forms.CheckBox();
            this.delBakChk = new System.Windows.Forms.CheckBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.incSubdirs = new System.Windows.Forms.CheckBox();
            this.clearLogBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dirLbl
            // 
            this.dirLbl.AutoSize = true;
            this.dirLbl.Location = new System.Drawing.Point(12, 9);
            this.dirLbl.Name = "dirLbl";
            this.dirLbl.Size = new System.Drawing.Size(75, 13);
            this.dirLbl.TabIndex = 0;
            this.dirLbl.Text = "Target folder:";
            // 
            // dirBox
            // 
            this.dirBox.Location = new System.Drawing.Point(93, 6);
            this.dirBox.Name = "dirBox";
            this.dirBox.Size = new System.Drawing.Size(449, 22);
            this.dirBox.TabIndex = 1;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(548, 6);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // delSfkChk
            // 
            this.delSfkChk.AutoSize = true;
            this.delSfkChk.Checked = true;
            this.delSfkChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.delSfkChk.Location = new System.Drawing.Point(15, 34);
            this.delSfkChk.Name = "delSfkChk";
            this.delSfkChk.Size = new System.Drawing.Size(104, 17);
            this.delSfkChk.TabIndex = 3;
            this.delSfkChk.Text = "Delete .sfk files";
            this.delSfkChk.UseVisualStyleBackColor = true;
            // 
            // delSfapChk
            // 
            this.delSfapChk.AutoSize = true;
            this.delSfapChk.Checked = true;
            this.delSfapChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.delSfapChk.Location = new System.Drawing.Point(15, 57);
            this.delSfapChk.Name = "delSfapChk";
            this.delSfapChk.Size = new System.Drawing.Size(117, 17);
            this.delSfapChk.TabIndex = 4;
            this.delSfapChk.Text = "Delete .sfap0 files";
            this.delSfapChk.UseVisualStyleBackColor = true;
            // 
            // delBakChk
            // 
            this.delBakChk.AutoSize = true;
            this.delBakChk.Location = new System.Drawing.Point(15, 80);
            this.delBakChk.Name = "delBakChk";
            this.delBakChk.Size = new System.Drawing.Size(248, 17);
            this.delBakChk.TabIndex = 5;
            this.delBakChk.Text = "Delete .veg.bak files (NOT RECOMMENDED)";
            this.delBakChk.UseVisualStyleBackColor = true;
            this.delBakChk.CheckedChanged += new System.EventHandler(this.delBakChk_CheckedChanged);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(15, 188);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(608, 156);
            this.logBox.TabIndex = 6;
            this.logBox.Text = "";
            this.logBox.TextChanged += new System.EventHandler(this.logBox_TextChanged);
            // 
            // cleanBtn
            // 
            this.cleanBtn.Location = new System.Drawing.Point(548, 159);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(75, 23);
            this.cleanBtn.TabIndex = 7;
            this.cleanBtn.Text = "Clean";
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // incSubdirs
            // 
            this.incSubdirs.AutoSize = true;
            this.incSubdirs.Location = new System.Drawing.Point(15, 103);
            this.incSubdirs.Name = "incSubdirs";
            this.incSubdirs.Size = new System.Drawing.Size(140, 17);
            this.incSubdirs.TabIndex = 8;
            this.incSubdirs.Text = "Include subdirectories";
            this.incSubdirs.UseVisualStyleBackColor = true;
            // 
            // clearLogBtn
            // 
            this.clearLogBtn.Location = new System.Drawing.Point(15, 159);
            this.clearLogBtn.Name = "clearLogBtn";
            this.clearLogBtn.Size = new System.Drawing.Size(75, 23);
            this.clearLogBtn.TabIndex = 9;
            this.clearLogBtn.Text = "Clear log";
            this.clearLogBtn.UseVisualStyleBackColor = true;
            this.clearLogBtn.Click += new System.EventHandler(this.clearLogBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(96, 159);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(75, 23);
            this.copyBtn.TabIndex = 10;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(467, 159);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 11;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 356);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.clearLogBtn);
            this.Controls.Add(this.incSubdirs);
            this.Controls.Add(this.cleanBtn);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.delBakChk);
            this.Controls.Add(this.delSfapChk);
            this.Controls.Add(this.delSfkChk);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.dirBox);
            this.Controls.Add(this.dirLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F**k SFK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dirLbl;
        private System.Windows.Forms.TextBox dirBox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.CheckBox delSfkChk;
        private System.Windows.Forms.CheckBox delSfapChk;
        private System.Windows.Forms.CheckBox delBakChk;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.CheckBox incSubdirs;
        private System.Windows.Forms.Button clearLogBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button stopBtn;
    }
}

