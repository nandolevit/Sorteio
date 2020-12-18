using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Sorteio
{
	public static class FormMessage
	{
		static public void ShowMessageFalha()
		{
			MessageBox.Show("Falha ao salvar!", "FALHA", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		static public void ShowMessageSave()
		{
			MessageBox.Show("Salvo com sucesso!", "SALVO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		public static void ShowMessegeInfo(string mensagem)
		{
			MessageBox.Show(mensagem, "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static void ShowMessegeWarning(string mensagem)
		{
			MessageBox.Show(mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		public static DialogResult ShowMessegeQuestion(string mensagem)
		{
			return MessageBox.Show(mensagem, "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}
	}
}

