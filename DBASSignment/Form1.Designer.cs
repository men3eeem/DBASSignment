namespace DBASSignment
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
            this.button1 = new System.Windows.Forms.Button();
            this.hoverPanel = new System.Windows.Forms.Panel();
            this.hoverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 34);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // hoverPanel
            // 
            this.hoverPanel.BackColor = System.Drawing.Color.Transparent;
            this.hoverPanel.Controls.Add(this.button1);
            this.hoverPanel.Location = new System.Drawing.Point(405, 391);
            this.hoverPanel.Name = "hoverPanel";
            this.hoverPanel.Size = new System.Drawing.Size(176, 43);
            this.hoverPanel.TabIndex = 1;
            this.hoverPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.hoverPanel_Paint);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::DBASSignment.Properties.Resources.Worker_Matching;
            this.ClientSize = new System.Drawing.Size(970, 559);
            this.Controls.Add(this.hoverPanel);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hoverPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_open_con;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel hoverPanel;
    }
}

