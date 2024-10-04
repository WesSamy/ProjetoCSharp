/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 03/09/2024
 * Hora: 22:19
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Receba_Palavras
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
			
		
		}
		void Button1Click(object sender, EventArgs e)
		{
			string p = textBox1.Text;
			label1.Text = p[0].ToString() + p[2] + p[4] + p[6] + p[8];
		}
	}
}
