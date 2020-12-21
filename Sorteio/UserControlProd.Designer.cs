namespace Sorteio
{
    partial class UserControlProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlProd));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelQuant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.UserControlProd_Click);
            // 
            // labelDescricao
            // 
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(3, 111);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(145, 39);
            this.labelDescricao.TabIndex = 1;
            this.labelDescricao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDescricao.Click += new System.EventHandler(this.UserControlProd_Click);
            // 
            // labelQuant
            // 
            this.labelQuant.AutoSize = true;
            this.labelQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuant.Location = new System.Drawing.Point(3, 8);
            this.labelQuant.Name = "labelQuant";
            this.labelQuant.Size = new System.Drawing.Size(41, 13);
            this.labelQuant.TabIndex = 2;
            this.labelQuant.Text = "label1";
            this.labelQuant.Click += new System.EventHandler(this.UserControlProd_Click);
            // 
            // UserControlProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelQuant);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlProd";
            this.Size = new System.Drawing.Size(148, 150);
            this.Load += new System.EventHandler(this.UserControlProd_Load);
            this.Click += new System.EventHandler(this.UserControlProd_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelQuant;
    }
}
