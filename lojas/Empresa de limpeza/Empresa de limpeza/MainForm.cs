﻿/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 27/08/2024
 * Hora: 20:05
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Empresa_de_limpeza
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
			//cada metro cubico é de 49.99 + 250,00 (dispesas gerais)
			//Capa - Nome, nome do trabalho, nome da materia, nome professor, data.
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Label9Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			//entrada
			float aP,lP,cP;
			float vT,vF;
			
				//processo
				aP = float.Parse (textBox1.Text);
				lP = float.Parse (textBox2.Text);
				cP = float.Parse (textBox3.Text);
			
					//volume total
					vT = aP * lP * cP;
					textBox4.Text = vT.ToString();
			
					//valor final cobrado
					vF = (vT*49.99f) + 250f;
					textBox5.Text = vF.ToString("C");
		}
		void TextBox7TextChanged(object sender, EventArgs e)
		{
	
		}
		void Label8Click(object sender, EventArgs e)
		{
	
		}
	}
}