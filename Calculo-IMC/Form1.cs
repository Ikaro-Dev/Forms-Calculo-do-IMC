using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoImc
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnVerificar_Click(object sender, EventArgs e)
		{
			//declaraçao de variaveis
			double peso, altura, imc;

			//variavel recebendo conteudo do textbox
			peso = Convert.ToDouble(txtPeso.Text);
			altura = Convert.ToDouble(txtAltura.Text);
			imc = peso / (altura * altura);

			/*textbox recebe conteudo da variavel imc = resultado do calculo
			 * definicao de ultilizacao  de 2 casas decimais*/
			txtimc.Text = imc.ToString("0.00");

			//condicao do imc usando o IF
			if(imc < 18.49)
				MessageBox.Show("SITUAÇÃO: Voce esta abaixo do Peso", "Calculo de IMC", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			else if (imc < 24.99)
						MessageBox.Show("SITUAÇÃO: Voce esta com o Peso dentro da normalidade", "Calculo de IMC", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			else if (imc < 29.99)
						MessageBox.Show("SITUAÇÃO: Voce esta abaixo do Peso", "Calculo de IMC", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			else if (imc < 34.99)
				MessageBox.Show("ATENÇÃO: Voce esta com Obesidade grau I", "Calculo de IMC", MessageBoxButtons.OK,
					MessageBoxIcon.Stop);
			else if (imc < 39.99)
				MessageBox.Show("ATENÇÃO: Voce esta com Obesidade grau II ", "Calculo de IMC", MessageBoxButtons.OK,
					MessageBoxIcon.Stop);
			else
				MessageBox.Show("ATENÇÃO: Voce esta com Obesidade grau III ", "Calculo de IMC", MessageBoxButtons.OK,
					MessageBoxIcon.Stop);

		}

	}

		}
	

