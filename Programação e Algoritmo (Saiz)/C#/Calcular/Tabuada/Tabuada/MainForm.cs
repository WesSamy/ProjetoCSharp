/*
 * Criado por SharpDevelop.
 * Usuário: Samuel
 * Data: 01/10/2024
 * Hora: 06:12
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tabuada
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			// entrada 
			int n = int.Parse (textBox1.Text);
			
			
			//limpar o ListBox após a conta
			listBox1.Items.Clear();
			
			//Processo
			for (int i=1; i <=10; i++)
			{
					
				listBox1.Items.Add(n + " X " + i + " = " + (n * i));
				
			}
		}
		
	}
}
