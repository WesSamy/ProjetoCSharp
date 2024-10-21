/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 13/08/2024
 * Hora: 19:53
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace salarioLiquidoDouble
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
	
			InitializeComponent();
			double sal,inss,salarioLiquido;
			int descontoFaltas,faltas;
		}
		void Button1Click(object sender, EventArgs e)
		{
			double sal = double.Parse(textBox1.Text);
			int faltas = int.Parse(textBox2.Text);
			double inss = sal * 0.12;
			textBox3.Text= inss.ToString();
			double descontoFaltas = (sal/30) * faltas;
			textBox4.Text = descontoFaltas.ToString();
			double SalarioLiquido = sal - descontoFaltas - inss;
			textBox5.Text = SalarioLiquido.ToString();
		}
	}
}
