/*
 * Criado por SharpDevelop.
 * Usuário: U.Das Camisetas
 * Data: 19/08/2024
 * Hora: 16:54
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HorasExtras
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
	
			InitializeComponent();
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			float salLiquid = float.Parse (textBox1.Text);
			int horasEx = int.Parse (textBox3.Text);
			int cargaH = int.Parse (textBox2.Text);
			float salPdia = salLiquid / 30;
			textBox4.Text= salPdia.ToString();
			float salPhr = salPdia / cargaH;
			textBox5.Text = salPhr.ToString();
			float salLqd_hrsEx = salLiquid + salPhr * horasEx;
			textBox6.Text = salLqd_hrsEx.ToString();
			
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
		
		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
