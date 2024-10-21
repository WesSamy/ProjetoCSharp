/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 12/08/2024
 * Hora: 19:12
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora_02
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();

		}
		int n1,n2,n3,soma;
		void Button1Click(object sender, EventArgs e)
		{	n1= int.Parse(textBox2.Text);
			n2= int.Parse(textBox3.Text)*30;
			n3= int.Parse(textBox4.Text)*365;
			soma= n1+n2+n3;
			textBox1.Text= soma.ToString();
			
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
