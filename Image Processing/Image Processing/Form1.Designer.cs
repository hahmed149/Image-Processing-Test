namespace Image_Processing
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
            this.uxSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.uxOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.uxOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxSave
            // 
            this.uxSave.Location = new System.Drawing.Point(197, 26);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(75, 23);
            this.uxSave.TabIndex = 0;
            this.uxSave.Text = "Process";
            this.uxSave.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Image Process";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // uxOpenFile
            // 
            this.uxOpenFile.FileName = "uxOpenFile";
            // 
            // uxOpen
            // 
            this.uxOpen.Location = new System.Drawing.Point(12, 26);
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(75, 23);
            this.uxOpen.TabIndex = 2;
            this.uxOpen.Text = "Open";
            this.uxOpen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 58);
            this.Controls.Add(this.uxOpen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uxSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog uxOpenFile;
        private System.Windows.Forms.SaveFileDialog uxSaveFile;
        private System.Windows.Forms.Button uxOpen;
    }
}

