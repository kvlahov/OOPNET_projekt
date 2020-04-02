namespace WinForms.View.UserControls
{
    partial class PlayerListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // PnContainer
            // 
            this.PnContainer.AutoScroll = true;
            this.PnContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnContainer.Location = new System.Drawing.Point(0, 0);
            this.PnContainer.Name = "PnContainer";
            this.PnContainer.Size = new System.Drawing.Size(506, 417);
            this.PnContainer.TabIndex = 0;
            this.PnContainer.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PnContainer_ControlAdded);
            this.PnContainer.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.PnContainer_ControlRemoved);
            this.PnContainer.DragDrop += new System.Windows.Forms.DragEventHandler(this.PnContainer_DragDrop);
            this.PnContainer.DragEnter += new System.Windows.Forms.DragEventHandler(this.PnContainer_DragEnter);
            // 
            // PlayerListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnContainer);
            this.Name = "PlayerListControl";
            this.Size = new System.Drawing.Size(506, 417);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PnContainer;
    }
}
