namespace WinForms
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
            this.btnImportData = new System.Windows.Forms.Button();
            this.LvData = new System.Windows.Forms.ListView();
            this.cbEnable = new System.Windows.Forms.CheckBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(31, 25);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(126, 41);
            this.btnImportData.TabIndex = 0;
            this.btnImportData.Text = "Import data";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.BtnImportData_ClickAsync);
            // 
            // LvData
            // 
            this.LvData.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.LvData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvData.FullRowSelect = true;
            this.LvData.GridLines = true;
            this.LvData.HideSelection = false;
            this.LvData.HoverSelection = true;
            this.LvData.Location = new System.Drawing.Point(31, 86);
            this.LvData.Name = "LvData";
            this.LvData.Size = new System.Drawing.Size(470, 285);
            this.LvData.TabIndex = 1;
            this.LvData.UseCompatibleStateImageBehavior = false;
            // 
            // cbEnable
            // 
            this.cbEnable.AutoSize = true;
            this.cbEnable.Location = new System.Drawing.Point(177, 41);
            this.cbEnable.Name = "cbEnable";
            this.cbEnable.Size = new System.Drawing.Size(59, 17);
            this.cbEnable.TabIndex = 2;
            this.cbEnable.Text = "Enable";
            this.cbEnable.UseVisualStyleBackColor = true;
            this.cbEnable.CheckStateChanged += new System.EventHandler(this.CbEnable_CheckStateChanged);
            // 
            // tbUrl
            // 
            this.tbUrl.Enabled = false;
            this.tbUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUrl.Location = new System.Drawing.Point(242, 35);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(259, 31);
            this.tbUrl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 400);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.cbEnable);
            this.Controls.Add(this.LvData);
            this.Controls.Add(this.btnImportData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.ListView LvData;
        private System.Windows.Forms.CheckBox cbEnable;
        private System.Windows.Forms.TextBox tbUrl;
    }
}

