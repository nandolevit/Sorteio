namespace Sorteio
{
    partial class FormVendedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxNome = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxNome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxNome
            // 
            this.groupBoxNome.Controls.Add(this.buttonSave);
            this.groupBoxNome.Controls.Add(this.maskedTextBoxCpf);
            this.groupBoxNome.Controls.Add(this.label1);
            this.groupBoxNome.Controls.Add(this.textBoxNome);
            this.groupBoxNome.Controls.Add(this.label5);
            this.groupBoxNome.Controls.Add(this.label2);
            this.groupBoxNome.Controls.Add(this.maskedTextBoxTel);
            this.groupBoxNome.Controls.Add(this.textBoxEmail);
            this.groupBoxNome.Controls.Add(this.label3);
            this.groupBoxNome.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNome.Name = "groupBoxNome";
            this.groupBoxNome.Size = new System.Drawing.Size(953, 62);
            this.groupBoxNome.TabIndex = 1;
            this.groupBoxNome.TabStop = false;
            this.groupBoxNome.Text = "Vendedor:";
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
            this.buttonSave.TabIndex = 9;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.textBoxNome.Location = new System.Drawing.Point(112, 35);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(322, 20);
            this.textBoxNome.TabIndex = 4;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(814, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Celular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(814, 35);
            this.maskedTextBoxTel.Mask = "(00) 0 0000 0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTel.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(440, 35);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(369, 20);
            this.textBoxEmail.TabIndex = 6;
            this.textBoxEmail.Text = "sem@email.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 417);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colCpf,
            this.colNome,
            this.colEmail,
            this.colTel});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(947, 398);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colCod
            // 
            this.colCod.DataPropertyName = "concorrenteid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "00000";
            this.colCod.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCod.HeaderText = "Cod.:";
            this.colCod.Name = "colCod";
            this.colCod.Width = 50;
            // 
            // colCpf
            // 
            this.colCpf.DataPropertyName = "concorrentecpf";
            this.colCpf.HeaderText = "CPF:";
            this.colCpf.Name = "colCpf";
            this.colCpf.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "concorrentenome";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colNome.DefaultCellStyle = dataGridViewCellStyle4;
            this.colNome.HeaderText = "Nome:";
            this.colNome.LinkColor = System.Drawing.Color.Blue;
            this.colNome.Name = "colNome";
            this.colNome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colNome.Width = 300;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "concorrenteemail";
            this.colEmail.HeaderText = "E-mail:";
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 300;
            // 
            // colTel
            // 
            this.colTel.DataPropertyName = "concorrentetelefone";
            this.colTel.HeaderText = "Tel.:";
            this.colTel.Name = "colTel";
            // 
            // FormVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxNome);
            this.Name = "FormVendedor";
            this.Text = "FormVendedor";
            this.Load += new System.EventHandler(this.FormVendedor_Load);
            this.groupBoxNome.ResumeLayout(false);
            this.groupBoxNome.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNome;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewLinkColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
    }
}