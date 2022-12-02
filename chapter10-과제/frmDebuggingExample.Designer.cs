namespace chapter10_과제
{
    partial class _15
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnPerformDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(88, 112);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(120, 21);
            this.txtInput.TabIndex = 0;
            // 
            // btnPerformDivision
            // 
            this.btnPerformDivision.Location = new System.Drawing.Point(96, 144);
            this.btnPerformDivision.Name = "btnPerformDivision";
            this.btnPerformDivision.Size = new System.Drawing.Size(104, 23);
            this.btnPerformDivision.TabIndex = 1;
            this.btnPerformDivision.Text = "나누기 실행";
            this.btnPerformDivision.UseVisualStyleBackColor = true;
            this.btnPerformDivision.Click += new System.EventHandler(this.btnPerformDivision_Click);
            // 
            // _15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 280);
            this.Controls.Add(this.btnPerformDivision);
            this.Controls.Add(this.txtInput);
            this.Name = "_15";
            this.Text = "Debugging Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnPerformDivision;
    }
}