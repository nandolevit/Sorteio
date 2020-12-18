namespace Sorteio
{
    partial class FormConcorrente
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
            this.groupBoxNum = new System.Windows.Forms.GroupBox();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxNome = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxSorteio = new System.Windows.Forms.GroupBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.textBoxIdSort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDescricaoSort = new System.Windows.Forms.TextBox();
            this.groupBoxVendedor = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxNome.SuspendLayout();
            this.groupBoxSorteio.SuspendLayout();
            this.groupBoxVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxNum);
            this.groupBox1.Controls.Add(this.groupBoxNome);
            this.groupBox1.Controls.Add(this.groupBoxSorteio);
            this.groupBox1.Controls.Add(this.groupBoxVendedor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concorrente:";
            // 
            // groupBoxNum
            // 
            this.groupBoxNum.Controls.Add(this.buttonSelecionar);
            this.groupBoxNum.Controls.Add(this.numericUpDown1);
            this.groupBoxNum.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxNum.Enabled = false;
            this.groupBoxNum.Location = new System.Drawing.Point(6, 156);
            this.groupBoxNum.Name = "groupBoxNum";
            this.groupBoxNum.Size = new System.Drawing.Size(953, 373);
            this.groupBoxNum.TabIndex = 12;
            this.groupBoxNum.TabStop = false;
            this.groupBoxNum.Text = "Número de bilhetes:";
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Enabled = false;
            this.buttonSelecionar.Location = new System.Drawing.Point(845, 13);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSelecionar.TabIndex = 14;
            this.buttonSelecionar.Text = "Selecione";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(790, 16);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(944, 323);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxNome
            // 
            this.groupBoxNome.Controls.Add(this.buttonSave);
            this.groupBoxNome.Controls.Add(this.button3);
            this.groupBoxNome.Controls.Add(this.maskedTextBoxCpf);
            this.groupBoxNome.Controls.Add(this.label1);
            this.groupBoxNome.Controls.Add(this.textBoxNome);
            this.groupBoxNome.Controls.Add(this.label5);
            this.groupBoxNome.Controls.Add(this.label2);
            this.groupBoxNome.Controls.Add(this.maskedTextBoxTel);
            this.groupBoxNome.Controls.Add(this.textBoxEmail);
            this.groupBoxNome.Controls.Add(this.label3);
            this.groupBoxNome.Location = new System.Drawing.Point(6, 19);
            this.groupBoxNome.Name = "groupBoxNome";
            this.groupBoxNome.Size = new System.Drawing.Size(953, 62);
            this.groupBoxNome.TabIndex = 10;
            this.groupBoxNome.TabStop = false;
            this.groupBoxNome.Text = "Comprador:";
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImage = global::Sorteio.Properties.Resources.icons8_Save_32;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(920, 32);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(25, 23);
            this.buttonSave.TabIndex = 5;
            this.toolTip1.SetToolTip(this.buttonSave, "Consultar Vendedor...");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Sorteio.Properties.Resources.lupa_blue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(112, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button3, "Consultar Vendedor...");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(6, 35);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCpf.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(143, 36);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(291, 20);
            this.textBoxNome.TabIndex = 3;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(814, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Celular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(814, 35);
            this.maskedTextBoxTel.Mask = "(00) 0 0000 0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTel.TabIndex = 7;
            this.maskedTextBoxTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(440, 35);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(369, 20);
            this.textBoxEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-mail:";
            // 
            // groupBoxSorteio
            // 
            this.groupBoxSorteio.Controls.Add(this.buttonSort);
            this.groupBoxSorteio.Controls.Add(this.textBoxIdSort);
            this.groupBoxSorteio.Controls.Add(this.label7);
            this.groupBoxSorteio.Controls.Add(this.label8);
            this.groupBoxSorteio.Controls.Add(this.textBoxDescricaoSort);
            this.groupBoxSorteio.Enabled = false;
            this.groupBoxSorteio.Location = new System.Drawing.Point(477, 87);
            this.groupBoxSorteio.Name = "groupBoxSorteio";
            this.groupBoxSorteio.Size = new System.Drawing.Size(482, 63);
            this.groupBoxSorteio.TabIndex = 9;
            this.groupBoxSorteio.TabStop = false;
            this.groupBoxSorteio.Text = "Sorteio:";
            // 
            // buttonSort
            // 
            this.buttonSort.BackgroundImage = global::Sorteio.Properties.Resources.lupa_blue;
            this.buttonSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSort.FlatAppearance.BorderSize = 0;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.Location = new System.Drawing.Point(440, 32);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(25, 23);
            this.buttonSort.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buttonSort, "Consultar Vendedor...");
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // textBoxIdSort
            // 
            this.textBoxIdSort.Location = new System.Drawing.Point(6, 35);
            this.textBoxIdSort.Name = "textBoxIdSort";
            this.textBoxIdSort.Size = new System.Drawing.Size(58, 20);
            this.textBoxIdSort.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Descrição:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Código:";
            // 
            // textBoxDescricaoSort
            // 
            this.textBoxDescricaoSort.Enabled = false;
            this.textBoxDescricaoSort.Location = new System.Drawing.Point(70, 35);
            this.textBoxDescricaoSort.Name = "textBoxDescricaoSort";
            this.textBoxDescricaoSort.Size = new System.Drawing.Size(364, 20);
            this.textBoxDescricaoSort.TabIndex = 3;
            // 
            // groupBoxVendedor
            // 
            this.groupBoxVendedor.Controls.Add(this.button2);
            this.groupBoxVendedor.Controls.Add(this.button1);
            this.groupBoxVendedor.Controls.Add(this.textBox4);
            this.groupBoxVendedor.Controls.Add(this.label6);
            this.groupBoxVendedor.Controls.Add(this.label4);
            this.groupBoxVendedor.Controls.Add(this.textBox1);
            this.groupBoxVendedor.Enabled = false;
            this.groupBoxVendedor.Location = new System.Drawing.Point(6, 87);
            this.groupBoxVendedor.Name = "groupBoxVendedor";
            this.groupBoxVendedor.Size = new System.Drawing.Size(465, 63);
            this.groupBoxVendedor.TabIndex = 8;
            this.groupBoxVendedor.TabStop = false;
            this.groupBoxVendedor.Text = "Vendendor:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Sorteio.Properties.Resources.add_32;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(434, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button2, "Cadastrar Novo Vendedor...");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Sorteio.Properties.Resources.lupa_blue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(403, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button1, "Consultar Vendedor...");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 35);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(58, 20);
            this.textBox4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(70, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 20);
            this.textBox1.TabIndex = 3;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(892, 555);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 1;
            this.buttonFechar.Text = "button3";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(805, 555);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "button4";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // FormConcorrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 607);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormConcorrente";
            this.Load += new System.EventHandler(this.FormConcorrente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxNum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxNome.ResumeLayout(false);
            this.groupBoxNome.PerformLayout();
            this.groupBoxSorteio.ResumeLayout(false);
            this.groupBoxSorteio.PerformLayout();
            this.groupBoxVendedor.ResumeLayout(false);
            this.groupBoxVendedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxVendedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.GroupBox groupBoxSorteio;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.TextBox textBoxIdSort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDescricaoSort;
        private System.Windows.Forms.GroupBox groupBoxNome;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBoxNum;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonSave;
    }
}