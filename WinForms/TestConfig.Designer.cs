namespace WinForms
{
    partial class TestConfig
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
            this.tbResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbResults
            // 
            this.tbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResults.Location = new System.Drawing.Point(12, 12);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.Size = new System.Drawing.Size(553, 315);
            this.tbResults.TabIndex = 0;
            // 
            // TestConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 339);
            this.Controls.Add(this.tbResults);
            this.Name = "TestConfig";
            this.Text = "TestConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResults;
    }
}