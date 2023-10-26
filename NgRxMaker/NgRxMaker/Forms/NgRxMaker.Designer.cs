namespace NgRxMaker
{
    partial class NgRxMaker
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.BrowseFolderBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EntityTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BrowseFolderBtn
            // 
            this.BrowseFolderBtn.Location = new System.Drawing.Point(12, 73);
            this.BrowseFolderBtn.Name = "BrowseFolderBtn";
            this.BrowseFolderBtn.Size = new System.Drawing.Size(280, 26);
            this.BrowseFolderBtn.TabIndex = 1;
            this.BrowseFolderBtn.Text = "Create Feature";
            this.BrowseFolderBtn.UseVisualStyleBackColor = true;
            this.BrowseFolderBtn.Click += new System.EventHandler(this.BrowseFolderBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(12, 115);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(280, 23);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entity";
            // 
            // EntityTxt
            // 
            this.EntityTxt.Location = new System.Drawing.Point(12, 32);
            this.EntityTxt.Name = "EntityTxt";
            this.EntityTxt.Size = new System.Drawing.Size(280, 22);
            this.EntityTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "@Galileu Frez Veloso";
            // 
            // NgRxMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 179);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EntityTxt);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.BrowseFolderBtn);
            this.Name = "NgRxMaker";
            this.Text = "NgRxMaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button BrowseFolderBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EntityTxt;
        private System.Windows.Forms.Label label2;
    }
}

