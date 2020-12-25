namespace Sorteio
{
    partial class UserControlProdDescricao
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
            this.components = new System.ComponentModel.Container();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.ForeColor = System.Drawing.Color.White;
            this.labelValor.Location = new System.Drawing.Point(113, 91);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(44, 13);
            this.labelValor.TabIndex = 4;
            this.labelValor.Text = "Valor: ";
            this.labelValor.Click += new System.EventHandler(this.UserControlProdDescricao_Click);
            this.labelValor.MouseEnter += new System.EventHandler(this.UserControlProdDescricao_MouseEnter);
            // 
            // labelDescricao
            // 
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.ForeColor = System.Drawing.Color.White;
            this.labelDescricao.Location = new System.Drawing.Point(113, 7);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(132, 84);
            this.labelDescricao.TabIndex = 0;
            this.labelDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDescricao.Click += new System.EventHandler(this.UserControlProdDescricao_Click);
            this.labelDescricao.MouseEnter += new System.EventHandler(this.UserControlProdDescricao_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelValor);
            this.panel1.Controls.Add(this.labelDescricao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 119);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.UserControlProdDescricao_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.UserControlProdDescricao_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.UserControlProdDescricao_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.UserControlProdDescricao_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.UserControlProdDescricao_MouseEnter);
            // 
            // UserControlProdDescricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlProdDescricao";
            this.Size = new System.Drawing.Size(258, 119);
            this.Load += new System.EventHandler(this.UserControlProdDescricao_Load);
            this.Click += new System.EventHandler(this.UserControlProdDescricao_Click);
            this.MouseEnter += new System.EventHandler(this.UserControlProdDescricao_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControlProdDescricao_MouseLeave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
