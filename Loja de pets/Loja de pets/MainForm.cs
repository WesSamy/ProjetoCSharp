/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 19/09/2024
 * Hora: 19:49
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Loja_de_pets
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
			float mF,mA,mG,Qtde;
			float vMF,vMA,vMG,vT;
			float dTMF, dTMA,dTM, dMF,dMA;
			
			mF= float.Parse (textBox1.Text);
			mA= float.Parse (textBox2.Text);
			mG= float.Parse (textBox3.Text);
			
			//Declarar Quantidade
			Qtde = mF + mA + mG;
			textBox4.Text = Qtde.ToString();
			
			//Declarar Valores
			vMF = mF *1000;
			vMA = mA *1000;
			vMG = mG *1500;
			vT= vMF + vMA + vMG;
			textBox5.Text= vT.ToString("C");
			
			//Valores com Desconto
			
			//Caso a quantidade for excedida
			  
			if(mA > 12000){
			    MessageBox.Show("Quantidade excedida");
			}
			else if (mA > 7){
				dTMA = vMF + (vMA *0.93f) + vMG;
				dMA = vMA - (vMA*0.93f);
			
				textBox5.Text= dTMA.ToString("C");
				label6.Text= vMF.ToString("C");
				label8.Text= vMA.ToString("C");
				label9.Text= dMA.ToString("C");
				label10.Text= vMG.ToString("C");
				}
				else{
					vT= vMF + vMA + vMG;
					}
			
				if(mF <=7000){
					vT= vMF + vMA + vMG;
				}
				else if(mF > 14){
					dTMF = vMA + (vMF *0.93f) + vMG;
					dMF = vMF - (vMF*0.93f);
					textBox5.Text= dTMF.ToString("C");
					label6.Text= vMF.ToString("C");
					label7.Text= dMF.ToString("C");
					label8.Text= vMA.ToString("C");
					label10.Text= vMG.ToString("C");
					}
					else{
					MessageBox.Show("Quantidade excedida");
					}
			
					if(mG <= 5000){
						vT= vMF + vMA + vMG;
					
					}
					else if(mA > 7 && mF > 14){
						dTM	 = (vMF*0.93f) + (vMA*0.93f) + vMG;
						dMA = vMA - (vMA*0.93f);
						dMF = vMF - (vMF*0.93f);
						textBox5.Text=dTM.ToString("C");
						label6.Text= vMF.ToString("C");
						label7.Text= dMF.ToString("C");
						label8.Text= vMA.ToString("C");
						label9.Text= dMA.ToString("C");
						label10.Text= vMG.ToString("C");	
					}
					else{
					MessageBox.Show("Quantidade excedida");
					}
				
		}
	}
}
