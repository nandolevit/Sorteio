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
            this.buttonSortear = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBilhete
            // 
            this.flowLayoutPanelBilhete.AutoScroll = true;
            this.flowLayoutPanelBilhete.Location = new System.Drawing.Point(21, 9);
            this.flowLayoutPanelBilhete.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelBilhete.Name = "flowLayoutPanelBilhete";
            this.flowLayoutPanelBilhete.Size = new System.Drawing.Size(1214, 667);
            this.flowLayoutPanelBilhete.TabIndex = 3;
            // 
            // buttonSortear
            // 
            this.buttonSortear.BackColor = System.Drawing.Color.Maroon;
            this.buttonSortear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortear.ForeColor = System.Drawing.Color.White;
            this.buttonSortear.Location = new System.Drawing.Point(1238, 56);
            this.buttonSortear.Name = "buttonSortear";
            this.buttonSortear.Size = new System.Drawing.Size(75, 23);
            this.buttonSortear.TabIndex = 0;
            this.buttonSortear.Text = "Sortear";
            this.buttonSortear.UseVisualStyleBackColor = false;
            this.buttonSortear.Click += new System.EventHandler(this.buttonSortear_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(1238, 12);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 5;
            this.buttonFechar.Text = "button3";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormNumSorteio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 681);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.flowLayoutPanelBilhete);
            this.Controls.Add(this.buttonSortear);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNumSorteio";
            this.Text = "FormNumSorteio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNumSorteio_FormClosing);
            this.Load += new System.EventHandler(this.FormNumSorteio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBilhete;
        private System.Windows.Forms.Button buttonSortear;
        private System.Windows.Forms.Button buttonFechar;
    }
}