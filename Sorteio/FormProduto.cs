using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Object;
using Business;

namespace Sorteio
{
    public partial class FormProduto : Form
    {
        public int Quant { get; set; }
        SorteioNegocio negSort;
        ProdutoInfo infoProd;
        public FormProduto()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.FormBorderStyle = FormBorderStyle.None;
            //this.buttonFechar.ForeColor = Color.White;
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            PreencherLista();
        }
        
        public void PreencherLista()
        {
            negSort = new SorteioNegocio();
            ProdutoColecao colProd = (ProdutoColecao)negSort.ExecutarProduto(enumCRUD.select);
            flowLayoutPanel1.Controls.Clear();

            if (colProd != null)
            {
                foreach (var item in colProd)
                {
                    UserControlProdDescricao prod = new UserControlProdDescricao
                    {
                        Prod = item
                    };

                    flowLayoutPanel1.Controls.Add(prod);
                }
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using(FormProdutoAdd formProdutoAdd = new FormProdutoAdd())
            {
                formProdutoAdd.ShowDialog(this);
            }
        }
    }
}
