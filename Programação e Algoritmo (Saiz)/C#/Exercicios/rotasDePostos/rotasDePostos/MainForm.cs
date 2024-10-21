/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 13/08/2024
 * Hora: 20:13
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace rotasDePostos
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
	
			InitializeComponent();
			
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			float kM1 = float.Parse(textBox1.Text);
			float kM2 = float.Parse(textBox2.Text);
			float p1 = kM1+(kM2-kM1)/4;
			float p2 = p1+(kM2-kM1)/4;
			float p3 = p2+(kM2-kM1)/4;
			textBox3.Text=p1.ToString();
			textBox4.Text=p2.ToString();
			textBox5.Text=p3.ToString();
			
		}
		void PictureBox3Click(object sender, EventArgs e)
		{
	
		}
}	
	}
