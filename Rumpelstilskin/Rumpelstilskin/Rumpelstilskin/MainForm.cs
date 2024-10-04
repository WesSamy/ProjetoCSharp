/*
 * Criado por SharpDevelop.
 * Usuário: U.Das Camisetas
 * Data: 25/09/2024
 * Hora: 09:01
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Rumpelstilskin
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
			double mF = double.Parse (textBox1.Text);
			double mA = double.Parse (textBox2.Text);
			double mG = double.Parse (textBox3.Text);
			
			//Calcular Quantidade
			double qtde = mA + mF + mG;
			label10.Text = qtde.ToString();
			
			//Declarar valores
			double vMF = mF*1000;
			double vMA = mA *1000;
			double vMG = mG *1500;
			
			
			//Calculo do Mafagafo Filhote
			if (mF > 7000){
				MessageBox.Show ("Quantidade Excedida");
				}
				else if (mF > 14 && mF <= 7000) {
					label4.Text = vMF.ToString("C");
					double dMF = vMF - (vMF * 0.93);
					label5.Text = dMF.ToString("C");
					label6.Text = vMA.ToString("C");
					label8.Text = vMG.ToString("C");
					double vT = (vMF - dMF) + vMA + vMG;
					label12.Text = vT.ToString("C");
		
					}
					else{
						label4.Text = vMF.ToString("C");
						label6.Text = vMA.ToString("C");
						label8.Text = vMG.ToString("C");
						double vT1 = vMA + vMF + vMG;
						label12.Text = vT1.ToString("C");
						}
			
			//Calculo do Mafagafo Adulto
			if(mA > 12000){
				MessageBox.Show("Quantidade Excedida");
				}
				else if (mA > 7 && mA <= 12000){
					label4.Text = vMF.ToString("C");
					label6.Text = vMA.ToString("C");
					double dMA = vMA - (vMA * 0.93);
					label7.Text = dMA.ToString("C");
					label8.Text = vMG.ToString("C");
					double vT = (vMA - dMA) + vMF + vMG;
					label12.Text = vT.ToString("C");
					}
					else {
						label4.Text = vMF.ToString("C");
						label6.Text = vMA.ToString("C");
						label8.Text = vMG.ToString("C");
						double vT1 = vMA + vMF + vMG;
						label12.Text = vT1.ToString("C");
						}
						
			
			//Calculo se Qtde de Mafagafos Filhote e Adulto forem maiores.
				
				 if (mF > 14 && mA > 7){
					label4.Text = vMF.ToString("C");
					double dMF = vMF - (vMF * 0.93);
					label5.Text = dMF.ToString("C");
					label6.Text = vMA.ToString("C");
					double dMA = vMA - (vMA * 0.93);
					label7.Text = dMA.ToString("C");
					label8.Text = vMG.ToString("C");
					double vT = (vMA - dMA) + (vMF -dMA) + vMG;
					label12.Text = vT.ToString("C");
					}
			
		}
		
	}
}
