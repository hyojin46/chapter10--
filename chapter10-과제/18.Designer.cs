namespace chapter10_과제
{
    partial class _18
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
            this.SuspendLayout();
            // 
            // _18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Name = "_18";
            this.Text = "Paint with the Mouse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._18_FormClosed);
            this.Load += new System.EventHandler(this._18_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this._18_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}