using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_INSS
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			/*var form1 = new Form1();
			this.Hide();
    		form1.Show();*/
			
			this.Hide();
   			 var form1 = new Form1();
   			 form1.Closed += (s, args) => this.Close(); 
  			  form1.Show();
    		
    		//TO DO: voltar aqui e mudar de 'Ocultar' para 'Fechar'
    		
		}
		
		//TO DO: configurar login baseado no dia e mês
		//TO DO: configurar senha baseada na hora e minuto atual
		
		
		
	}
}
