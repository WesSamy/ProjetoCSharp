/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 01/10/2024
 * Hora: 21:26
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo_da_Forca
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			// coleta de dados
			string palavra = textBox1.Text;
			char letra = textBox2.Text[0];
			int cont = 0;
			
			// pesquisa
			for(int i=0; i < palavra.Length; i++)
			{	
				if(palavra[i] == letra)
				{
					listBox1.Items.Add("a letra " + letra + " aparece na posição "+ (i+1));
					cont++;
				}
				
			}
			listBox1.Items.Add("");
			listBox1.Items.Add("A letra " + letra + " aparece " + cont + " vez(es)");
		}
	}
}
