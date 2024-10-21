/*
 * Criado por SharpDevelop.
 * Usuário: Samuel
 * Data: 16/09/2024
 * Hora: 06:31
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calcular_maior_número
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
			
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			//entrada
			int n1, n2, n3;
			
			//processo
			n1 = int.Parse(textBox1.Text);
			n2 = int.Parse(textBox2.Text);
			n3 = int.Parse(textBox3.Text);
			
			// Saida 
			if(n1==n2 || n2==n3 || n1==n3){
				label4.Text = "Insira valores diferentes";
			} else {
				if (n1>n2 && n1>n3) {
					label4.Text = "O maior número é:" + n1;
				} else if (n2>n3 && n2>n1){
					label4.Text = "O maior número é:" + n2;
				} else{
					label4.Text = "O maior número é:" + n3;
				}
			}
		}
		

	}
}
