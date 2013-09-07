namespace Terminator
{
    partial class Controller
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
            this.SuspendLayout();
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "View";
            this.Size = new System.Drawing.Size(640, 480);
            this.MouseLeave += new System.EventHandler(this.View_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.View_MouseMove);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.View_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.View_MouseDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.View_KeyPress);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.View_MouseUp);
            this.MouseEnter += new System.EventHandler(this.View_MouseEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.View_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
