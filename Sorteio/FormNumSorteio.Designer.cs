namespace Sorteio
{
    partial class FormNumSorteio
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
            this.flowLayoutPanelBilhete = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSortear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBilhete
            // 
            this.flowLayoutPanelBilhete.AutoScroll = true;
            this.flowLayoutPanelBilhete.Location = new System.Drawing.Point(133, 41);
            this.flowLayoutPanelBilhete.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelBilhete.Name = "flowLayoutPanelBilhete";
            this.flowLayoutPanelBilhete.Size = new System.Drawing.Size(1225, 666);
            this.flowLayoutPanelBilhete.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSortear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 749);
            this.panel1.TabIndex = 4;
            // 
            // buttonSortear
            // 
            this.buttonSortear.Location = new System.Drawing.Point(1282, 711);
            this.buttonSortear.Name = "buttonSortear";
            this.buttonSortear.Size = new System.Drawing.Size(75, 23);
            this.buttonSortear.TabIndex = 0;
            this.buttonSortear.Text = "button1";
            this.buttonSortear.UseVisualStyleBackColor = true;
            this.buttonSortear.Click += new System.EventHandler(this.buttonSortear_Click);
            // 
            // FormNumSorteio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 749);
            this.Controls.Add(this.flowLayoutPanelBilhete);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNumSorteio";
            this.Text = "FormNumSorteio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNumSorteio_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBilhete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSortear;
    }
}