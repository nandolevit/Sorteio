namespace Sorteio
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sorteioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concorrenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lancarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarSorteioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoSortearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorteioToolStripMenuItem,
            this.realizarSorteioToolStripMenuItem,
            this.bancoSortearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sorteioToolStripMenuItem
            // 
            this.sorteioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.lancarToolStripMenuItem});
            this.sorteioToolStripMenuItem.Name = "sorteioToolStripMenuItem";
            this.sorteioToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sorteioToolStripMenuItem.Text = "Sorteio";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.concorrenteToolStripMenuItem,
            this.vendedorToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // concorrenteToolStripMenuItem
            // 
            this.concorrenteToolStripMenuItem.Name = "concorrenteToolStripMenuItem";
            this.concorrenteToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.concorrenteToolStripMenuItem.Text = "Concorrente";
            this.concorrenteToolStripMenuItem.Click += new System.EventHandler(this.concorrenteToolStripMenuItem_Click);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            this.vendedorToolStripMenuItem.Click += new System.EventHandler(this.vendedorToolStripMenuItem_Click);
            // 
            // lancarToolStripMenuItem
            // 
            this.lancarToolStripMenuItem.Name = "lancarToolStripMenuItem";
            this.lancarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.lancarToolStripMenuItem.Text = "Lançar Sorteio";
            this.lancarToolStripMenuItem.Click += new System.EventHandler(this.lancarToolStripMenuItem_Click);
            // 
            // realizarSorteioToolStripMenuItem
            // 
            this.realizarSorteioToolStripMenuItem.Name = "realizarSorteioToolStripMenuItem";
            this.realizarSorteioToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.realizarSorteioToolStripMenuItem.Text = "Realizar Sorteio";
            this.realizarSorteioToolStripMenuItem.Click += new System.EventHandler(this.realizarSorteioToolStripMenuItem_Click);
            // 
            // bancoSortearToolStripMenuItem
            // 
            this.bancoSortearToolStripMenuItem.Name = "bancoSortearToolStripMenuItem";
            this.bancoSortearToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.bancoSortearToolStripMenuItem.Text = "BancoSortear";
            this.bancoSortearToolStripMenuItem.Visible = false;
            this.bancoSortearToolStripMenuItem.Click += new System.EventHandler(this.bancoSortearToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sorteioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lancarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concorrenteToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem bancoSortearToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem realizarSorteioToolStripMenuItem;
    }
}

