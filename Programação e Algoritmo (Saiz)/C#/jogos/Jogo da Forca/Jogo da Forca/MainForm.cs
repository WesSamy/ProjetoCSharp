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
		
		int erros = 0;
		
		void Button1Click(object sender, EventArgs e)
		{
			// recebe e oculta a palavra secreta
			button1.Visible = false;
			textBox1.Visible = false;
			button2.Enabled = true;
			button3.Enabled = true;
			label1.Visible = true;
			label1.Text = "A palavra tem " + textBox1.Text.Length + "Letras";
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//botão verificar ocorrência
			string palavra = textBox1.Text;
			char letra = textBox2.Text[0];
			
			//verificar quantas vezes a letra aparece na palavra
			int i = 0, cont = 0;
			while (i < palavra.Length)
			{
				if (letra == palavra[1])
				{
					cont++;
				}
				i++; // <== NÂO ESQUEÇA!
			}
		
		// informe o resultado da verificação
		if (cont == 0)
		{
			erros++;
			listBox1.Items.Add( letra + ": não aparece. Erros: "+ erros);
		}
		else
		{
			listBox1.Items.Add(letra + ": aparece "+ cont + " vezes");
		}
		
		// verificando se excedeu o limite de erros
		if (erros == 6)
		{
			MessageBox.Show("Atenção!!!\n" +
			                "Ultrapassouo limite de chutes errados. \n" +
			                "Você deve informar a palavra");
			button2.Enabled = false;
			textBox2.Enabled = false;
		}
		textBox2.Clear();
		textBox2.Focus();
	}
		void Button3Click(object sender, EventArgs e)
		{
		// exibe o resultado final
		if (textBox3.Text == textBox1.Text)
		{
			label2.ForeColor = Color.Green;
			label2.Text = "Resultado: Acertou";
		}
		else
		{
			label2.ForeColor = Color.Red;
			label2.Text = "Resultado: Errou";
		}
		
		}
	}	
}
