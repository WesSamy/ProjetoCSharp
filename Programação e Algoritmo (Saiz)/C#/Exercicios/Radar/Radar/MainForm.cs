﻿/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 16/09/2024
 * Hora: 20:02
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Radar
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
	
			InitializeComponent();
			
		
		}
		void Button1Click(object sender, EventArgs e)
		{
			double p1 = double.Parse(textBox1.Text);
			double t =	double.Parse(textBox2.Text);
			double p2 = double.Parse(textBox3.Text);
			double vm;
			
			vm = (p2-p1)/(t);
			label4.Text = "Velocidade média: " + vm;
			
			if (vm > 80){
				label5.Text ="Pego no Radar";
				pictureBox5.Load ("dançou.gif");
				
			}else{
				if (vm <= 80)
			
				label5.Text="vai com Deus";
				pictureBox5.Load ("sucesso.gif");
			}
		}
	}
}
