namespace Sorteio
{
    partial class FormConsultar_Cod_Descricao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewConsultar = new System.Windows.Forms.DataGridView();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.labelRegistro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultar)).BeginInit();
            this.groupBoxBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewConsultar
            // 
            this.dataGridViewConsultar.AllowUserToAddRows = false;
            this.dataGridViewConsultar.AllowUserToDeleteRows = false;
            this.dataGridViewConsultar.AllowUserToResizeColumns = false;
            this.dataGridViewConsultar.AllowUserToResizeRows = false;
            this.dataGridViewConsultar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colDescricao});
            this.dataGridViewConsultar.Location = new System.Drawing.Point(6, 46);
            this.dataGridViewConsultar.MultiSelect = false;
            this.dataGridViewConsultar.Name = "dataGridViewConsultar";
            this.dataGridViewConsultar.ReadOnly = true;
            this.dataGridViewConsultar.RowHeadersWidth = 10;
            this.dataGridViewConsultar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewConsultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConsultar.ShowCellErrors = false;
            this.dataGridViewConsultar.ShowCellToolTips = false;
            this.dataGridViewConsultar.ShowEditingIcon = false;
            this.dataGridViewConsultar.ShowRowErrors = false;
            this.dataGridViewConsultar.Size = new System.Drawing.Size(530, 357);
            this.dataGridViewConsultar.TabIndex = 1;
            this.dataGridViewConsultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewConsultar_CellContentClick);
            this.dataGridViewConsultar.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewConsultar_RowPostPaint);
            // 
            // colCod
            // 
            this.colCod.DataPropertyName = "Cod";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCod.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCod.HeaderText = "Código";
            this.colCod.Name = "colCod";
            this.colCod.ReadOnly = true;
            this.colCod.Width = 50;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colDescricao.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDescricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDescricao.Width = 450;
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Controls.Add(this.textBoxDescricao);
            this.groupBoxBuscar.Controls.Add(this.dataGridViewConsultar);
            this.groupBoxBuscar.Location = new System.Drawing.Point(12, 13);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(542, 409);
            this.groupBoxBuscar.TabIndex = 0;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Buscar:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(7, 20);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(529, 20);
            this.textBoxDescricao.TabIndex = 0;
            this.textBoxDescricao.TextChanged += new System.EventHandler(this.textBoxDescricao_TextChanged);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::Sorteio.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(464, 428);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(90, 40);
            this.buttonFechar.TabIndex = 2;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.ForeColor = System.Drawing.Color.Maroon;
            this.labelRegistro.Location = new System.Drawing.Point(15, 428);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(0, 13);
            this.labelRegistro.TabIndex = 3;
            // 
            // FormConsultar_Cod_Descricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 480);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.groupBoxBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FormConsultar_Cod_Descricao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.FormConsultar_Cod_Descricao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultar_Cod_Descricao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultar)).EndInit();
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewConsultar;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewLinkColumn colDescricao;
        private System.Windows.Forms.Label labelRegistro;
    }
}