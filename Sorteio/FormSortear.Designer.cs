namespace Sorteio
{
    partial class FormSortear
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescricaoSort = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelProd = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxNum = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelBilhete = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTotalValorBilhete = new System.Windows.Forms.Label();
            this.labelTotalValorProd = new System.Windows.Forms.Label();
            this.labelTotalQuant = new System.Windows.Forms.Label();
            this.labelBilheteContar = new System.Windows.Forms.Label();
            this.buttonSortear = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBoxValor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBoxDescricaoSort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorteio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Qt. Bilhetes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor Bilhete:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(83, 58);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Enabled = false;
            this.textBoxValor.Location = new System.Drawing.Point(224, 58);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(72, 20);
            this.textBoxValor.TabIndex = 6;
            this.textBoxValor.Text = "0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(341, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textBoxDescricaoSort
            // 
            this.textBoxDescricaoSort.Location = new System.Drawing.Point(10, 32);
            this.textBoxDescricaoSort.Name = "textBoxDescricaoSort";
            this.textBoxDescricaoSort.Size = new System.Drawing.Size(605, 20);
            this.textBoxDescricaoSort.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanelProd);
            this.groupBox2.Location = new System.Drawing.Point(13, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 429);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Prêmios:";
            // 
            // flowLayoutPanelProd
            // 
            this.flowLayoutPanelProd.AutoScroll = true;
            this.flowLayoutPanelProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProd.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelProd.Name = "flowLayoutPanelProd";
            this.flowLayoutPanelProd.Size = new System.Drawing.Size(647, 410);
            this.flowLayoutPanelProd.TabIndex = 0;
            // 
            // groupBoxNum
            // 
            this.groupBoxNum.Controls.Add(this.flowLayoutPanelBilhete);
            this.groupBoxNum.Location = new System.Drawing.Point(675, 12);
            this.groupBoxNum.Name = "groupBoxNum";
            this.groupBoxNum.Size = new System.Drawing.Size(572, 522);
            this.groupBoxNum.TabIndex = 4;
            this.groupBoxNum.TabStop = false;
            this.groupBoxNum.Text = "Número de bilhetes:";
            // 
            // flowLayoutPanelBilhete
            // 
            this.flowLayoutPanelBilhete.AutoScroll = true;
            this.flowLayoutPanelBilhete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBilhete.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelBilhete.Name = "flowLayoutPanelBilhete";
            this.flowLayoutPanelBilhete.Size = new System.Drawing.Size(566, 503);
            this.flowLayoutPanelBilhete.TabIndex = 2;
            // 
            // labelTotalValorBilhete
            // 
            this.labelTotalValorBilhete.AutoSize = true;
            this.labelTotalValorBilhete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalValorBilhete.ForeColor = System.Drawing.Color.Maroon;
            this.labelTotalValorBilhete.Location = new System.Drawing.Point(433, 537);
            this.labelTotalValorBilhete.Name = "labelTotalValorBilhete";
            this.labelTotalValorBilhete.Size = new System.Drawing.Size(144, 13);
            this.labelTotalValorBilhete.TabIndex = 10;
            this.labelTotalValorBilhete.Text = "Valor Total de Bilhetes: ";
            // 
            // labelTotalValorProd
            // 
            this.labelTotalValorProd.AutoSize = true;
            this.labelTotalValorProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalValorProd.ForeColor = System.Drawing.Color.Maroon;
            this.labelTotalValorProd.Location = new System.Drawing.Point(178, 537);
            this.labelTotalValorProd.Name = "labelTotalValorProd";
            this.labelTotalValorProd.Size = new System.Drawing.Size(139, 13);
            this.labelTotalValorProd.TabIndex = 9;
            this.labelTotalValorProd.Text = "Valor Total de Prêmios:";
            // 
            // labelTotalQuant
            // 
            this.labelTotalQuant.AutoSize = true;
            this.labelTotalQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalQuant.ForeColor = System.Drawing.Color.Maroon;
            this.labelTotalQuant.Location = new System.Drawing.Point(13, 537);
            this.labelTotalQuant.Name = "labelTotalQuant";
            this.labelTotalQuant.Size = new System.Drawing.Size(106, 13);
            this.labelTotalQuant.TabIndex = 8;
            this.labelTotalQuant.Text = "Total de Prêmios:";
            // 
            // labelBilheteContar
            // 
            this.labelBilheteContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBilheteContar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelBilheteContar.Location = new System.Drawing.Point(672, 537);
            this.labelBilheteContar.Name = "labelBilheteContar";
            this.labelBilheteContar.Size = new System.Drawing.Size(575, 13);
            this.labelBilheteContar.TabIndex = 11;
            this.labelBilheteContar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonSortear
            // 
            this.buttonSortear.BackColor = System.Drawing.Color.Green;
            this.buttonSortear.Enabled = false;
            this.buttonSortear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortear.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortear.ForeColor = System.Drawing.Color.White;
            this.buttonSortear.Image = global::Sorteio.Properties.Resources.icons8_Best_Seller_32;
            this.buttonSortear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSortear.Location = new System.Drawing.Point(1122, 553);
            this.buttonSortear.Name = "buttonSortear";
            this.buttonSortear.Size = new System.Drawing.Size(122, 45);
            this.buttonSortear.TabIndex = 12;
            this.buttonSortear.Text = "Sortear";
            this.buttonSortear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSortear.UseVisualStyleBackColor = false;
            this.buttonSortear.Click += new System.EventHandler(this.buttonSortear_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.BackgroundImage = global::Sorteio.Properties.Resources.lupa_blue;
            this.buttonSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.Location = new System.Drawing.Point(621, 29);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(24, 23);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormSortear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 610);
            this.Controls.Add(this.buttonSortear);
            this.Controls.Add(this.labelBilheteContar);
            this.Controls.Add(this.labelTotalValorBilhete);
            this.Controls.Add(this.labelTotalValorProd);
            this.Controls.Add(this.labelTotalQuant);
            this.Controls.Add(this.groupBoxNum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSortear";
            this.Text = "Sortear";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxNum.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxDescricaoSort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProd;
        private System.Windows.Forms.GroupBox groupBoxNum;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBilhete;
        private System.Windows.Forms.Label labelTotalValorBilhete;
        private System.Windows.Forms.Label labelTotalValorProd;
        private System.Windows.Forms.Label labelTotalQuant;
        private System.Windows.Forms.Label labelBilheteContar;
        private System.Windows.Forms.Button buttonSortear;
    }
}