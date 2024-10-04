/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 02/09/2024
 * Hora: 19:27
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calcular_Ceramicas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			//Entrada
			double lC,comC,vC,pl1,pa1,pl2,pa2;
			double qtdC,vtC,vMQ,vtM,vtS;
			
			
			//Processo
			lC = double.Parse(textBox1.Text);
			comC = double.Parse(textBox2.Text);
			vC	= double.Parse(textBox3.Text);
			pa1 = double.Parse (textBox4.Text);
			pl1 = double.Parse(textBox5.Text);
			pa2 = double.Parse(textBox6.Text);
			pl2 = double.Parse(textBox7.Text);
			
			
			//Calculando
			pa1 = Math.Ceiling((pa1/60));
			pl1= Math.Ceiling((pl1/60));
			pa2= Math.Ceiling((pa2/60));
			pl2= Math.Ceiling((pl2/60));
			qtdC= Math.Ceiling((pa1 * pl1)*2 + (pa2 * pl2)*2);
			qtdC= Math.Ceiling(qtdC*1.15d);
			vMQ = (5*2.84)*2 + (3.50*2.84)*2;
			
			textBox8.Text = qtdC.ToString();
			vtC = qtdC*vC;
			textBox9.Text = vtC.ToString("C");
			vtM = vMQ*60;
			textBox10.Text = vtM.ToString("C");
			vtS = vtC + vtM;
			textBox11.Text = vtS.ToString("C");
		}	
	}
}
