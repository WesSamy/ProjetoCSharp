/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 21/10/2024
 * Hora: 19:18
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Vetores__Lista_de_Nomes_
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
		
		}
		void Button1Click(object sender, EventArgs e)
		{
			string [] nomes= {"rodrigo","marcos","luana","Isabela","Vitória","Davi","Ana","Wesley",
								"Lucas","Pedro","Paulo","João","Matheus","Felipe","José", "Fabiana",
								"Maria", "Raul", "Samuel", "Jesus"};
			double[] salario = {8500,3500,2400,1412,8739,6897,8917,1385,1584,7856,5745,16741,11781,5648,
								5371,5781,2461,8554,6573,99999999};
			for (int i=0; i<20; i++)
			{
				listBox1.Items.Add((i+1)+ " - " + nomes[i] + "  =  " + salario[i].ToString("C"));
				label2.Text = "O maior salario é de " + nomes[19];
				label3. Text = "Valor do salario é " + salario[19].ToString("C");
				label4.Text = "O menor salario é de " + nomes[7];
				label5. Text = "Valor do salario é " + salario[7].ToString("C");
			}
		}
	}
}