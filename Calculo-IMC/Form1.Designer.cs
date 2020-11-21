namespace CalculoImc
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblCalculoImc = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnVerificar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.txtPeso = new System.Windows.Forms.TextBox();
			this.txtAltura = new System.Windows.Forms.TextBox();
			this.txtimc = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblCalculoImc
			// 
			this.lblCalculoImc.AutoSize = true;
			this.lblCalculoImc.Location = new System.Drawing.Point(149, 37);
			this.lblCalculoImc.Name = "lblCalculoImc";
			this.lblCalculoImc.Size = new System.Drawing.Size(78, 13);
			this.lblCalculoImc.TabIndex = 0;
			this.lblCalculoImc.Text = "CÁLCULO IMC";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "DIGITE SEU PESO :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "DIGITE SUA ALTURA :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(93, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "SEU IMC É :";
			// 
			// btnVerificar
			// 
			this.btnVerificar.Location = new System.Drawing.Point(96, 252);
			this.btnVerificar.Name = "btnVerificar";
			this.btnVerificar.Size = new System.Drawing.Size(75, 41);
			this.btnVerificar.TabIndex = 7;
			this.btnVerificar.Text = "VERIFICAR";
			this.btnVerificar.UseVisualStyleBackColor = true;
			this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(224, 252);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(78, 41);
			this.btnLimpar.TabIndex = 8;
			this.btnLimpar.Text = "LIMPAR";
			this.btnLimpar.UseVisualStyleBackColor = true;
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(152, 317);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(100, 44);
			this.btnSair.TabIndex = 9;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			// 
			// txtPeso
			// 
			this.txtPeso.Location = new System.Drawing.Point(152, 112);
			this.txtPeso.Multiline = true;
			this.txtPeso.Name = "txtPeso";
			this.txtPeso.Size = new System.Drawing.Size(139, 21);
			this.txtPeso.TabIndex = 10;
			// 
			// txtAltura
			// 
			this.txtAltura.Location = new System.Drawing.Point(166, 150);
			this.txtAltura.Multiline = true;
			this.txtAltura.Name = "txtAltura";
			this.txtAltura.Size = new System.Drawing.Size(125, 21);
			this.txtAltura.TabIndex = 11;
			// 
			// txtimc
			// 
			this.txtimc.Location = new System.Drawing.Point(166, 182);
			this.txtimc.Multiline = true;
			this.txtimc.Name = "txtimc";
			this.txtimc.Size = new System.Drawing.Size(125, 21);
			this.txtimc.TabIndex = 12;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(388, 373);
			this.Controls.Add(this.txtimc);
			this.Controls.Add(this.txtAltura);
			this.Controls.Add(this.txtPeso);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnVerificar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblCalculoImc);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCalculoImc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnVerificar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.TextBox txtPeso;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.TextBox txtimc;
	}
}

