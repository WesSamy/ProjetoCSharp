/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 10/09/2024
 * Hora: 21:20
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Exercicio_2__Operadores_Logicos_
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Label10Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Label6Click(object sender, EventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			int n1,n2,n3;
			
			n1= int.Parse(textBox1.Text);
			n2= int.Parse(textBox2.Text);
			n3= int.Parse(textBox3.Text);
			
			if(n1==n2 || n2== n3 || n1==n3)
			{
			textBox4.Text = "n1 é o maior";
				
			}
			else if(n2>n1 && n2>n3) {
			textBox4.Text = "n2 é o maior";
			}
			else
			textBox4.Text= "n3 é o maior";
		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
