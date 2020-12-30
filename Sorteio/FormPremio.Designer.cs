namespace Sorteio
{
    partial class FormPremio
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
            this.labelNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelConc = new System.Windows.Forms.Label();
            this.labelProd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelVend = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNum
            // 
            this.labelNum.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.ForeColor = System.Drawing.Color.Maroon;
            this.labelNum.Location = new System.Drawing.Point(68, 1);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(134, 88);
            this.labelNum.TabIndex = 1;
            this.labelNum.Text = "0000";
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 80);
            this.label2.TabIndex = 2;
            this.label2.Text = "nº";
            // 
            // labelConc
            // 
            this.labelConc.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConc.ForeColor = System.Drawing.Color.Green;
            this.labelConc.Location = new System.Drawing.Point(10, 309);
            this.labelConc.Name = "labelConc";
            this.labelConc.Size = new System.Drawing.Size(589, 78);
            this.labelConc.TabIndex = 3;
            this.labelConc.Text = "SORTEADO";
            this.labelConc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelProd
            // 
            this.labelProd.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProd.Location = new System.Drawing.Point(12, 201);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(587, 105);
            this.labelProd.TabIndex = 5;
            this.labelProd.Text = "PRÊMIO";
            this.labelProd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(216, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelVend
            // 
            this.labelVend.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVend.ForeColor = System.Drawing.Color.Black;
            this.labelVend.Location = new System.Drawing.Point(12, 395);
            this.labelVend.Name = "labelVend";
            this.labelVend.Size = new System.Drawing.Size(587, 38);
            this.labelVend.TabIndex = 7;
            this.labelVend.Text = "VENDEDOR";
            this.labelVend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFechar
            // 
            this.buttonFechar.FlatAppearance.BorderSize = 0;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Location = new System.Drawing.Point(500, 475);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 8;
            this.buttonFechar.Text = "button3";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormPremio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(611, 532);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.labelVend);
            this.Controls.Add(this.labelProd);
            this.Controls.Add(this.labelConc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPremio";
            this.Text = "FormPremio";
            this.Load += new System.EventHandler(this.FormPremio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelConc;
        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.Label labelVend;
        private System.Windows.Forms.Button buttonFechar;
    }
}