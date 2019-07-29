namespace The_Googler
{
    partial class Main
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
            this.btnGoogle = new System.Windows.Forms.Button();
            this.cbxActuallySearch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGoogle
            // 
            this.btnGoogle.Location = new System.Drawing.Point(12, 12);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(178, 26);
            this.btnGoogle.TabIndex = 0;
            this.btnGoogle.Text = "Press Here";
            this.btnGoogle.UseVisualStyleBackColor = true;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // cbxActuallySearch
            // 
            this.cbxActuallySearch.AutoSize = true;
            this.cbxActuallySearch.Location = new System.Drawing.Point(12, 44);
            this.cbxActuallySearch.Name = "cbxActuallySearch";
            this.cbxActuallySearch.Size = new System.Drawing.Size(98, 17);
            this.cbxActuallySearch.TabIndex = 1;
            this.cbxActuallySearch.Text = "Actually google";
            this.cbxActuallySearch.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 67);
            this.Controls.Add(this.cbxActuallySearch);
            this.Controls.Add(this.btnGoogle);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "The Googler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.CheckBox cbxActuallySearch;
    }
}

