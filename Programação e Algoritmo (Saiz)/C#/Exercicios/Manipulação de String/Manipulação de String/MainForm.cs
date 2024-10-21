/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 03/09/2024
 * Hora: 21:23
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Manipulação_de_String
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			// Misturar Palavras
			
			/*string s = "cavalo";
			string t = "feliz";
			label1.Text = s[0].ToString() + s[0] + t[0] + s[1] + t[1] + s[2] + t[2] + s[3] + t [3] + s[4] + t [4] + s[5]; */
//-------------------------------------------------------------------------------------------------------------
			
		
			 //Exercicio 11 -Pinçar os números pares da string
			
			/*string s = textBox1.Text;
			int n1 = int.Parse(s[0].ToString());
			int n2 = int.Parse(s[1].ToString());
			int n3 = int.Parse(s[2].ToString());
			int n4 = int.Parse(s[3].ToString());
			int n5 = int.Parse(s[4].ToString());
			int soma = n1 + n2 + n3 + n4 + n5;
			
			textBox2.Text = soma.ToString();*/
			// ------------------------------------------------------------------------------------------------------------
			
			//Exercicio 12 -Pinçar os números pares da string
			
			//string s = textBox1.Text;
			//textBox2.Text = s[0].ToString() + s[2] + s[4] + s[6] + s[8];
			
			// ------------------------------------------------------------------------------------------------------------
			
			// Exercicio 13 - Código verificador
			
			/*string s = textBox1.Text;
			
			int n1 = int.Parse(s[0].ToString());
			int n2 = int.Parse(s[1].ToString());
			int n3 = int.Parse(s[2].ToString());
			int n4 = int.Parse(s[3].ToString());
			int n5 = int.Parse(s[4].ToString());
			
			int Vl = (n1*1) + (n2*2) + (n3*3) + (n4*4) + (n5*5);
			string pV = Vl.ToString();
			
			textBox2.Text = s + "-"+ pV[0];
			*/
			
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}
