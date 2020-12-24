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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNum
            // 
            this.labelNum.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.ForeColor = System.Drawing.Color.Maroon;
            this.labelNum.Location = new System.Drawing.Point(149, 282);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(274, 88);
            this.labelNum.TabIndex = 1;
            this.labelNum.Text = "1000";
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(132, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 80);
            this.label2.TabIndex = 2;
            this.label2.Text = "nº";
            // 
            // labelConc
            // 
            this.labelConc.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConc.ForeColor = System.Drawing.Color.Green;
            this.labelConc.Location = new System.Drawing.Point(10, 370);
            this.labelConc.Name = "labelConc";
            this.labelConc.Size = new System.Drawing.Size(552, 60);
            this.labelConc.TabIndex = 3;
            this.labelConc.Text = "LUIZ FERNANDO SILVA";
            this.labelConc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelProd
            // 
            this.labelProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProd.Location = new System.Drawing.Point(16, 201);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(541, 66);
            this.labelProd.TabIndex = 5;
            this.labelProd.Text = "label4";
            this.labelProd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(196, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelVend
            // 
            this.labelVend.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVend.ForeColor = System.Drawing.Color.Black;
            this.labelVend.Location = new System.Drawing.Point(0, 430);
            this.labelVend.Name = "labelVend";
            this.labelVend.Size = new System.Drawing.Size(572, 46);
            this.labelVend.TabIndex = 7;
            this.labelVend.Text = "LUIZ FERNANDO SILVA";
            this.labelVend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPremio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(576, 509);
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
    }
}