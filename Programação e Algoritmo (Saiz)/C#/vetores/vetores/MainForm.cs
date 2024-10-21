/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 08/10/2024
 * Hora: 21:51
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace vetores
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
			
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{	
			int[] v = new int[10];
			//valores dos vetores
			
			// outra forma de fazer:
			// int[] v= {5,0,2,7,10,3,-1,-10,1,4};
			
			v[0]=5; v[1]=0; v[2]=2; v[3]=7; v[4]=10; v[5]=3;
			v[6]=-1; v[7]=-10; v[8]=1; v[9]=4;
			
			label1.Text = v[0].ToString();
			label2.Text = v[1].ToString();
			label3.Text = v[2].ToString();
			label4.Text = v[3].ToString();
			label5.Text = v[4].ToString();
			label6.Text = v[5].ToString();
			label7.Text = v[6].ToString();
			label8.Text = v[7].ToString();
			label9.Text = v[8].ToString();
			label10.Text = v[9].ToString();
			
			                         
		}
		void Button2Click(object sender, EventArgs e)
		{
			int[] v= {5,0,2,7,10,3,-1,-10,1,4};
			
			textBox1.Text=v[7].ToString();
			textBox2.Text=v[4].ToString();
		}
	}
}
