/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 12/08/2024
 * Hora: 20:14
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Retangulo
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			

		}
		float n1,n2,soma;
		void Button1Click(object sender, EventArgs e)
		{
			n1= float.Parse(textBox1.Text);
			n2= float.Parse(textBox2.Text);
			soma=n1*n2;
			textBox3.Text=soma.ToString();
		}
	}
}
