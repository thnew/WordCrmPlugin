namespace WordCrmPlugin
{
    partial class KnowledgeBaseSearch
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
            this.wpfHost = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // wpfHost
            // 
            this.wpfHost.BackColor = System.Drawing.Color.Transparent;
            this.wpfHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpfHost.Location = new System.Drawing.Point(0, 0);
            this.wpfHost.Name = "wpfHost";
            this.wpfHost.Size = new System.Drawing.Size(203, 532);
            this.wpfHost.TabIndex = 5;
            this.wpfHost.Text = "elementHost1";
            this.wpfHost.Child = null;
            // 
            // KnowledgeBaseSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.wpfHost);
            this.MaximumSize = new System.Drawing.Size(0, 2000);
            this.MinimumSize = new System.Drawing.Size(0, 308);
            this.Name = "KnowledgeBaseSearch";
            this.Size = new System.Drawing.Size(203, 532);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Integration.ElementHost wpfHost;
    }
}
