/*
 * Criado por SharpDevelop.
 * Usuário: Samuel
 * Data: 22/09/2024
 * Hora: 15:04
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_Temperatura
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
			float temp = float.Parse (textBox1.Text);
			
			if (temp < 0) {
			    label2.Text = "Sensação térmica: " + "Frio Congelante";
			    this.BackColor = Color.Navy;
			    pictureBox1.Load("frioCong.jpg");
			}
			else
				if (temp >= 0 && temp <= 10){
				label2.Text = "Sensação térmica: " + "Muito Frio";
				this.BackColor = Color.RoyalBlue;
				pictureBox1.Load("MuitoF.gif");
			}
			else
				if (temp > 10 && temp <= 18){
				label2.Text = "Sensação térmica: " + "Frio";
				this.BackColor = Color.Aquamarine;
				pictureBox1.Load("Frio.gif");
			}
			else
				if (temp > 18 && temp <= 24){
				label2.Text = "Sensação térmica: " + "agradável";
				this.BackColor = Color.DarkKhaki;
				pictureBox1.Load("normal.gif");
			}
			else
				if (temp > 24 && temp <= 32){
				label2.Text = "Sensação térmica: " + "calor";
				this.BackColor = Color.DarkOrange;
				pictureBox1.Load("calor.gif");
			}
			else
				if (temp > 32 && temp <= 38){
				label2.Text = "Sensação térmica: " + "Muito Calor";
				this.BackColor = Color.OrangeRed;
				pictureBox1.Load("muitoC.gif");
			}
			else{
				label2.Text = "Sensação térmica: " + "Calor Escaldante";
				this.BackColor = Color.Red;
				pictureBox1.Load("CalorEscal.gif");
			}
				
			
		}
	}
}
