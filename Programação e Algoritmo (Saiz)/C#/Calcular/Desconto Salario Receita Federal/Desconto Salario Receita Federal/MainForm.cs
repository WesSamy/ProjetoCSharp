/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 17/09/2024
 * Hora: 21:11
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Desconto_Salario_Receita_Federal
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
			
		
		}
		void Button1Click(object sender, EventArgs e)
		{
			//Entrada
			double salB = double.Parse (textBox1.Text);
			double salL=0, desc=0;
		
			
			//Processo
			if (salB <= 1500){
				salL=salB;
				//Saida
				textBox2.Text = salL.ToString("C");
				label2.Text = "Isento de Imposto (%)";
				pictureBox1.Load ("homerFeliz.png");
//--------------------------------------------------------------------				
			//Processo
			}else{
				if (salB > 1500 && salB <= 5000){
				desc = salB * 0.1;
				salL=salB - desc;
				//Saida
				textBox2.Text = salL.ToString("C");
				label4.Text = desc.ToString("C");
				label2.Text = "10% de imposto";
				pictureBox1.Load ("homer2.png");
//--------------------------------------------------------------------				
			//Processo	
			}else if( salB > 5000 && salB <= 12000){
				
				desc= salB *0.15;
				salL=salB - desc;
				//Saida
				textBox2.Text = salL.ToString("C");
				label4.Text = desc.ToString("C");
				label2.Text = "15% de imposto";
				pictureBox1.Load ("homer4.png");
//--------------------------------------------------------------------
			//Processo
			}else if (salB > 12000 && salB <= 20000){
				desc= salB *0.20;
				salL=salB - desc;
				//Saida
				textBox2.Text = salL.ToString("C");
				label4.Text = desc.ToString("C");
				label2.Text = "20% de imposto";
				pictureBox1.Load ("homer3.png");
//--------------------------------------------------------------------
			//Processo
			} else {
				desc = salB * 0.25;
				salL=salB - desc;
				//Saida
				textBox2.Text = salL.ToString("C");
				label4.Text = desc.ToString("C");
				label2.Text = "25% de imposto";
				pictureBox1.Load ("homer5.png");

			 	}
					
			}
		}
			
	}
}
