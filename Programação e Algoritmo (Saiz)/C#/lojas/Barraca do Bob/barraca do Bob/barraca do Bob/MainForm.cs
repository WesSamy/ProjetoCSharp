/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 26/08/2024
 * Hora: 20:21
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace barraca_do_Bob
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
	
			InitializeComponent();
			
		
		}
		void Button1Click(object sender, EventArgs e)
		{
			//Entrada de Dados
			float c1, c2, c3;
			int qi1, qi2, qi3;
			int qf1, qf2, qf3;
			int qv1, qv2, qv3;
			float m1,m2,m3;
			float vb1, vb2, vb3;
			float pc1, pc2,pc3;
			float vl1,vl2,vl3;
			float brutT;
			float custoT,liquidoF;
			
		
		
			//Processo
			c1 = float.Parse(textBox1.Text);
			c2 = float.Parse (textBox2.Text);
			c3 = float.Parse(textBox3.Text);
			
			qi1= int.Parse(textBox4.Text);
			qi2= int.Parse(textBox5.Text);
			qi3= int.Parse(textBox6.Text);
			
			qf1= int.Parse(textBox7.Text);
			qf2= int.Parse(textBox8.Text);
			qf3= int.Parse(textBox9.Text);
			
			
		
			//Saida de dados
			
			//Miçangas
			m1= (0.15f * 15) + 2.40f;
			m2= (0.15f * 20) + 2.40f;
			m3= (0.15f * 35) + 2.40f;
			
			qv1= qi1- qf1;
			textBox10.Text = qv1.ToString();
			
			qv2= qi2- qf2;
			textBox11.Text = qv2.ToString();
			
			qv3= qi3- qf3;
			textBox12.Text = qv3.ToString();
			
			//Calculando o valor Bruto.
			vb1= (c1* qv1);
			textBox13.Text = vb1.ToString("C");
			
			vb2= (c2 * qv2);
			textBox14.Text = vb2.ToString("C");
			
			vb3= (c3 * qv3);
			textBox15.Text = vb3.ToString("C");
			
			//Calculando preço de Custo.
			pc1= m1 * qv1;
			textBox16.Text = pc1.ToString("C");
			
			pc2= m2 * qv2;
			textBox17.Text= pc2.ToString("C");
			
			pc3= m3* qv3;
			textBox18.Text= pc3.ToString("C");
			
			
			//Calculando valor Liquido.
			vl1= vb1 - pc1;
			textBox19.Text= vl1.ToString("C");
			
			vl2= vb2 - pc2;
			textBox20.Text= vl2.ToString("C");
			
			vl3= vb3 - pc3;
			textBox21.Text= vl3.ToString("C");
			
			brutT=vb1+vb2+vb3;
			textBox22.Text=brutT.ToString("C");
			                               
			
			custoT=pc1+pc2+pc3;
			textBox23.Text= custoT.ToString("C");
			
			liquidoF=vl1+vl2+vl3;
			textBox24.Text=liquidoF.ToString("C");
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}
