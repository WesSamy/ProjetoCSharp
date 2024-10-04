/*
 * Criado por SharpDevelop.
 * Usuário: Samuel
 * Data: 13/08/2024
 * Hora: 06:42
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Salário_INSS
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			
			float sal,inss,salarioLiquido;
			int descontoFaltas,faltas;
		}
		void Button1Click(object sender, EventArgs e)
		
		{
			float sal = float.Parse(textBox1.Text);
			int faltas = int.Parse(textBox2.Text);
			float inss = sal * 0.12f;
			textBox3.Text= inss.ToString();
			float descontoFaltas = (sal/30) * faltas;
			textBox4.Text = descontoFaltas.ToString();
			float SalarioLiquido = sal - descontoFaltas - inss;
			textBox5.Text = SalarioLiquido.ToString();
			
			
		}
	}
}
