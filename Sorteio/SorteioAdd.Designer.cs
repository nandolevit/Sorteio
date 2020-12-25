namespace Sorteio
{
    partial class SorteioAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPict = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescricaoSort = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.labelTotalQuant = new System.Windows.Forms.Label();
            this.labelTotalValorProd = new System.Windows.Forms.Label();
            this.labelTotalValorBilhete = new System.Windows.Forms.Label();
            this.flowLayoutPanelProd = new System.Windows.Forms.FlowLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPict);
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
            this.groupBox1.Size = new System.Drawing.Size(824, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorteio:";
            // 
            // buttonPict
            // 
            this.buttonPict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPict.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPict.Image = global::Sorteio.Properties.Resources.icons8_Electrical_16;
            this.buttonPict.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPict.Location = new System.Drawing.Point(720, 58);
            this.buttonPict.Name = "buttonPict";
            this.buttonPict.Size = new System.Drawing.Size(98, 23);
            this.buttonPict.TabIndex = 9;
            this.buttonPict.Text = "Add Prêmio";
            this.buttonPict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonPict, "Adicionar prêmios...");
            this.buttonPict.UseVisualStyleBackColor = true;
            this.buttonPict.Click += new System.EventHandler(this.buttonPict_Click);
            this.buttonPict.MouseEnter += new System.EventHandler(this.buttonPict_MouseEnter);
            this.buttonPict.MouseLeave += new System.EventHandler(this.buttonPict_MouseLeave);
            // 
            // buttonSort
            // 
            this.buttonSort.BackgroundImage = global::Sorteio.Properties.Resources.lupa_blue;
            this.buttonSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.Location = new System.Drawing.Point(794, 31);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(24, 23);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
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
            this.toolTip1.SetToolTip(this.label6, "Quantidade de bilhetes...");
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
            this.numericUpDown1.Location = new System.Drawing.Point(83, 58);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.numericUpDown1, "Quantidade de bilhetes que serão vendidos...");
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(224, 58);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(72, 20);
            this.textBoxValor.TabIndex = 6;
            this.textBoxValor.Text = "5,00";
            this.toolTip1.SetToolTip(this.textBoxValor, "Informe o valor dos bilhestes...");
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged_1);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(341, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.toolTip1.SetToolTip(this.dateTimePicker1, "Data que será realizado o sorteio...");
            // 
            // textBoxDescricaoSort
            // 
            this.textBoxDescricaoSort.Location = new System.Drawing.Point(10, 32);
            this.textBoxDescricaoSort.Name = "textBoxDescricaoSort";
            this.textBoxDescricaoSort.Size = new System.Drawing.Size(778, 20);
            this.textBoxDescricaoSort.TabIndex = 1;
            // 
            // buttonRemover
            // 
            this.buttonRemover.BackgroundImage = global::Sorteio.Properties.Resources.icons8_Close_Window_32;
            this.buttonRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRemover.Enabled = false;
            this.buttonRemover.FlatAppearance.BorderSize = 0;
            this.buttonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemover.Location = new System.Drawing.Point(13, 510);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(30, 29);
            this.buttonRemover.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonRemover, "Clique no item que deseja remover antes de clicar...");
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.Location = new System.Drawing.Point(1128, 507);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "button4";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(1215, 507);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 4;
            this.buttonFechar.Text = "button3";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // labelTotalQuant
            // 
            this.labelTotalQuant.AutoSize = true;
            this.labelTotalQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalQuant.ForeColor = System.Drawing.Color.Maroon;
            this.labelTotalQuant.Location = new System.Drawing.Point(164, 507);
            this.labelTotalQuant.Name = "labelTotalQuant";
            this.labelTotalQuant.Size = new System.Drawing.Size(106, 13);
            this.labelTotalQuant.TabIndex = 5;
            this.labelTotalQuant.Text = "Total de Prêmios:";
            // 
            // labelTotalValorProd
            // 
            this.labelTotalValorProd.AutoSize = true;
            this.labelTotalValorProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalValorProd.ForeColor = System.Drawing.Color.Maroon;
            this.labelTotalValorProd.Location = new System.Drawing.Point(329, 507);
            this.labelTotalValorProd.Name = "labelTotalValorProd";
            this.labelTotalValorProd.Size = new System.Drawing.Size(139, 13);
            this.labelTotalValorProd.TabIndex = 6;
            this.labelTotalValorProd.Text = "Valor Total de Prêmios:";
            // 
            // labelTotalValorBilhete
            // 
            this.labelTotalValorBilhete.AutoSize = true;
            this.labelTotalValorBilhete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalValorBilhete.ForeColor = System.Drawing.Color.Maroon;
            this.labelTotalValorBilhete.Location = new System.Drawing.Point(584, 507);
            this.labelTotalValorBilhete.Name = "labelTotalValorBilhete";
            this.labelTotalValorBilhete.Size = new System.Drawing.Size(144, 13);
            this.labelTotalValorBilhete.TabIndex = 7;
            this.labelTotalValorBilhete.Text = "Valor Total de Bilhetes: ";
            // 
            // flowLayoutPanelProd
            // 
            this.flowLayoutPanelProd.AutoScroll = true;
            this.flowLayoutPanelProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelProd.Location = new System.Drawing.Point(12, 99);
            this.flowLayoutPanelProd.Name = "flowLayoutPanelProd";
            this.flowLayoutPanelProd.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelProd.Size = new System.Drawing.Size(926, 402);
            this.flowLayoutPanelProd.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 16);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(353, 470);
            this.treeView1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Location = new System.Drawing.Point(944, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 489);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Vendedores:";
            // 
            // SorteioAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flowLayoutPanelProd);
            this.Controls.Add(this.labelTotalValorBilhete);
            this.Controls.Add(this.labelTotalValorProd);
            this.Controls.Add(this.labelTotalQuant);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.groupBox1);
            this.Name = "SorteioAdd";
            this.Text = "Lançamento";
            this.Load += new System.EventHandler(this.SorteioAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxDescricaoSort;
        private System.Windows.Forms.Button buttonPict;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label labelTotalQuant;
        private System.Windows.Forms.Label labelTotalValorProd;
        private System.Windows.Forms.Label labelTotalValorBilhete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProd;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}