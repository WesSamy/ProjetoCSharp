/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 20/08/2024
 * Hora: 19:31
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Loja_De_Brinquedos_1
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
	
			InitializeComponent();

		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
		void Label9Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			//Entrada de Dados
			float p1, p2, p3, p4, p5, p6;
			int qi1, qi2, qi3, qi4, qi5, qi6;
			int qf1, qf2, qf3, qf4, qf5, qf6;
			int qv1, qv2, qv3, qv4, qv5, qv6;
			float tv1, tv2, tv3, tv4, tv5, tv6;
			float tvg;
			
			//processo
			p1 = float.Parse (textBox7.Text);
			p2 = float.Parse (textBox8.Text);
			p3 = float.Parse (textBox9.Text);
			p4 = float.Parse (textBox10.Text);
			p5 = float.Parse (textBox11.Text);
			p6 = float.Parse (textBox12.Text);
			
			qi1 = int.Parse (textBox13.Text);
			qi2 = int.Parse (textBox14.Text);
			qi3 = int.Parse (textBox15.Text);
			qi4 = int.Parse (textBox16.Text);
			qi5 = int.Parse(textBox17.Text);
			qi6 = int.Parse (textBox18.Text);
			
			qf1 = int.Parse (textBox19.Text);
			qf2 = int.Parse (textBox20.Text);
			qf3 = int.Parse (textBox21.Text);
			qf4 = int.Parse (textBox22.Text);
			qf5 = int.Parse (textBox23.Text);
			qf6 = int.Parse (textBox24.Text);
			
			
			
			//saida de dados
			
			qv1 = qi1-qf1;
			textBox25.Text = qv1.ToString();
			
			qv2 = qi2 - qf2;
			textBox26.Text = qv2.ToString();
			
			qv3 = qi3 - qf3;
			textBox27.Text = qv3.ToString();
			
			qv4 = qi4 - qf4;
			textBox28.Text = qv4.ToString();
			
			qv5 = qi5 - qf5;
			textBox29.Text = qv5.ToString();
			
			qv6 = qi6 - qf6;
			textBox30.Text = qv6.ToString();
			
			
			tv1 = p1 * qv1;
			textBox31.Text = tv1.ToString("C");
			
			tv2 = p2 * qv2;
			textBox32.Text = tv2.ToString("C");
			
			tv3 = p3 * qv3;
			textBox33.Text = tv3.ToString("C");
			
			tv4 = p4 * qv4;
			textBox34.Text = tv4.ToString("C");
			
			tv5 = p5 * qv5;
			textBox35.Text = tv5.ToString("C");
			
			tv6 = p6 * qv6;
			textBox36.Text = tv6.ToString("C");
			
			tvg = tv1 + tv2 + tv3 + tv4 + tv5 + tv6;
			textBox37.Text = tvg.ToString("C");
			
					
		}
		void Label10Click(object sender, EventArgs e)
		{
	
		}
		void TextBox28TextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
