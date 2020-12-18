using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

using System.Windows.Forms;
using System.Reflection;

namespace Sorteio
{
    public class FormFormat
    {
        ////criação de delegates de mensagem
        ////mensagem de confirmação tipo sim/não
        //private delegate DialogResult DelMessageQuestion(string mensagem);
        //private static DelMessageQuestion DelQ = new DelMessageQuestion(FormMessage.ShowMessegeQuestion);
        ////mensagem de aviso
        //private delegate void DelMessgeWarning(string mensagem);
        //private static DelMessgeWarning DelW = new DelMessgeWarning(FormMessage.ShowMessegeWarning);
        ////messagem de informação
        //private delegate void DelMessageInfo(string mensagem);
        //private static DelMessageInfo DelI = new DelMessageInfo(FormMessage.ShowMessegeInfo);


        private static DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        private static string txt = string.Empty;


        static Form frm = new Form();
        static Button ButtonSalvar;
        //é para saber se o texto foi colado ou digitado, pois se for digitado o número de digítos será maior ou igual ao tamanho do texto
        //private static int contarDigitos = 0;

        public FormFormat(Form f)
        {
            frm = f;
        }

        public void formatar(bool caixa = false)
        {
            Executar();
        }

        public void formatar(Button b)
        {
            ButtonSalvar = b;
            Executar();
            frm.FormClosing += new FormClosingEventHandler(Form_Fechando);
        }

        private void Executar()
        {
            frm.KeyPreview = true;
            frm.KeyDown += new KeyEventHandler(AoApertar_KeyDown);

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.ShowInTaskbar = false;
            frm.ShowIcon = false;
            frm.MinimizeBox = false;
            frm.MaximizeBox = false;
            SelectTextBox();
        }

        private static void GridFormat(DataGridView grid)
        {
            //desativa a função de ordenar pelas colunas
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                grid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                //modo exibição das células
                grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            }

            //formata o grid para receber propriedade dentro de propriedade
            //grid.CellFormatting += new DataGridViewCellFormattingEventHandler(DataGridView_CellFormatting);

            //desativa a alteração pelas linhas
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;

            //ativa cor de linhas alternadas
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            //desativa a multi seleção
            grid.MultiSelect = false;
            //somente leitura
            grid.ReadOnly = true;
            //desativa o cabeçalho de linha
            grid.RowHeadersVisible = true;
            grid.RowHeadersWidth = 10;
            //ativa o modo de seleção de linha inteira
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //desativa o modo de gerar colunas automáticamente
            grid.AutoGenerateColumns = false;
            //desativa a tabulação
            grid.TabStop = false;
            //desativa o redimencionamento de cabeçalho de linha
            grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private static void FormatTextBox_AoPerderFoco(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            if (!FormTextoFormat.ValidaEmail(box.Text))
            {
                FormMessage.ShowMessegeWarning("E-mail inválido, campo será definico como \" sem@email.com\"");
                box.Text = "sem@email.com";
            }
        }

        private static void EventoComboBox(ComboBox combo)
        {
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private static void EventoMaskTextBox(MaskedTextBox mask)
        {
            mask.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mask.Click += new EventHandler(FormatMaskedTextBox_AoClicar);

            if (mask.Mask == "(00) 0 0000 0000")
                mask.TextChanged += new EventHandler(FormatMaskedTelefone_TextChange);
        }

        private static void FormatTextBox_AoAlterar(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;

            if (!string.IsNullOrEmpty(box.Text))
                FormTextoFormat.NovoTextoUpper(box);
        }


        private static void AoApertar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Form frm = sender as Form;
                    frm.Close();
                    break;
                default:
                    break;
            }
        }

        private static void FormatMaskedTextBox_AoClicar(object sender, EventArgs e)
        {
            MaskedTextBox mask = sender as MaskedTextBox;
            if (string.IsNullOrEmpty(mask.Text))
                mask.Select(0, 0);
        }

        private static void FormatMaskedTelefone_TextChange(object sender, EventArgs e)
        {
            MaskedTextBox mask = sender as MaskedTextBox;

            if (mask.Text.Length > 0)
            {

                if (mask.Text[0] == '0')
                {
                    if (mask.Text.Length > 10)
                        mask.Mask = "0000 000 0000";
                }
                else
                {
                    if (mask.Text.Length > 2)
                    {
                        char n = mask.Text[2];

                        if (n == '9')
                            mask.Mask = "(00) 0 0000 0000";
                        else
                            mask.Mask = "(00) 0000 0000";
                    }
                }
            }
        }

        private static void SelectTextBox()
        {
            foreach (Control item in frm.Controls)
            {
                if (item.GetType() == typeof(GroupBox))
                {
                    GroupBox groupBox = (GroupBox)item;
                    TestGroupBox(groupBox);
                }
                else if (item.GetType() == typeof(TabControl))
                {
                    TabControl tabControl = (TabControl)item;
                    TestTabControl(tabControl);
                }
                else if (item.GetType() == typeof(Panel))
                {
                    Panel panel = (Panel)item;
                    TestPanel(panel);
                }
                else
                    EditBox(item);
            }
        }

        private static void TestGroupBox(GroupBox g)
        {
            foreach (Control gru in g.Controls)
            {
                if (gru.GetType() == typeof(TextBox))
                {
                    TextBox box = (TextBox)gru;
                    EditBox(box);
                }
                else if (gru.GetType() == typeof(GroupBox))
                {
                    GroupBox groupBox = (GroupBox)gru;
                    TestGroupBox(groupBox);
                }
                else if (gru.GetType() == typeof(TabControl))
                {
                    TabControl tabControl = (TabControl)gru;
                    TestTabControl(tabControl);
                }
                else if (gru.GetType() == typeof(Panel))
                {
                    Panel panel = (Panel)gru;
                    TestPanel(panel);
                }
                else
                    EditBox(gru);
            }
        }

        private static void TestTabControl(TabControl ta)
        {
            foreach (Control tab in ta.Controls)
            {
                foreach (Control t in tab.Controls)
                {
                    if (t.GetType() == typeof(TabControl))
                    {
                        TabControl tabControl = (TabControl)t;
                        TestTabControl(tabControl);
                    }
                    else if (t.GetType() == typeof(GroupBox))
                    {
                        GroupBox groupBox = (GroupBox)t;
                        TestGroupBox(groupBox);
                    }
                    else if (t.GetType() == typeof(Panel))
                    {
                        Panel panel = (Panel)t;
                        TestPanel(panel);
                    }
                    else
                        EditBox(t);
                }
            }
        }

        private static void TestPanel(Panel p)
        {
            foreach (Control pan in p.Controls)
            {
                if (pan.GetType() == typeof(Panel))
                {
                    Panel panel = (Panel)pan;
                    TestPanel(panel);
                }
                else if (pan.GetType() == typeof(TabControl))
                {
                    TabControl tabControl = (TabControl)pan;
                    TestTabControl(tabControl);
                }
                else if (pan.GetType() == typeof(GroupBox))
                {
                    GroupBox groupBox = (GroupBox)pan;
                    TestGroupBox(groupBox);
                }
                else
                    EditBox(pan);
            }
        }

        private static void EditBox(Control c)
        {
            if (c.GetType() == typeof(TextBox))
            {
                TextBox box = (TextBox)c;

                if (box.Name != "textBoxSenha")
                {
                    box.TextChanged += new EventHandler(FormatTextBox_AoAlterar);
                    box.CharacterCasing = CharacterCasing.Upper; //converte para maiúsculo
                }

                if (box.Name == "textBoxEmail")
                {
                    box.CharacterCasing = CharacterCasing.Lower;
                    box.LostFocus += new EventHandler(FormatTextBox_AoPerderFoco);
                }

                box.MaxLength = 255;

                if (ButtonSalvar != null)
                    box.TextChanged += new EventHandler(TextBox_AoEditar);
            }
            else if (c.GetType() == typeof(ComboBox))
            {
                ComboBox comb = (ComboBox)c;
                EventoComboBox(comb);

                if (ButtonSalvar != null)
                    comb.SelectedIndexChanged += new EventHandler(TextBox_AoEditar);
            }
            else if (c.GetType() == typeof(RadioButton))
            {
                RadioButton r = (RadioButton)c;
                if (ButtonSalvar != null)
                    r.CheckedChanged += new EventHandler(TextBox_AoEditar);
            }
            else if (c.GetType() == typeof(MaskedTextBox))
            {
                MaskedTextBox mask = (MaskedTextBox)c;
                EventoMaskTextBox(mask);

                if (ButtonSalvar != null)
                    mask.TextChanged += new EventHandler(TextBox_AoEditar);
            }
            else if (c.GetType() == typeof(DataGridView))
            {
                DataGridView grid = (DataGridView)c;
                GridFormat(grid);
            }
            else if (c.GetType() == typeof(Button))
            {
                Button but = (Button)c;
                ButtonFormat(but);
            }
        }

        private static void TextBox_AoEditar(object sender, EventArgs e)
        {
            if (ButtonSalvar.Enabled == false)
                ButtonSalvar.Enabled = true;
        }

        private static void Form_Fechando(object sender, FormClosingEventArgs e)
        {
            if (ButtonSalvar.Enabled)
                if (FormMessage.ShowMessegeQuestion("Deseja descartar as alterações?") == DialogResult.No)
                    e.Cancel = true;
        }

        private static void ButtonFormat(Button b)
        {

            if (b.Name == "buttonSalvar" || b.Name == "buttonFechar")
            {
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                b.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
                b.Size = new System.Drawing.Size(85, 40);
                b.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                b.UseVisualStyleBackColor = true;

                if (b.Name == "buttonSalvar")
                {
                    b.ForeColor = System.Drawing.Color.Green;
                    b.Image = global::Sorteio.Properties.Resources.save_green;
                    b.Text = "&Salvar";
                }
                else
                {
                    b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    b.Image = global::Sorteio.Properties.Resources.exit_red;
                    b.Text = "&Fechar";
                }
            }
        }
    }
}
