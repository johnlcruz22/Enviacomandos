using System;

namespace enviacomandos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        public void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxretorno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxporta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxip = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxParam = new System.Windows.Forms.ListBox();
            this.textBoxParam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.labelesn = new System.Windows.Forms.Label();
            this.textBoxplaca = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(258, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENVIA COMANDOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(322, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selecione o comando";
            // 
            // textBoxretorno
            // 
            this.textBoxretorno.Location = new System.Drawing.Point(302, 170);
            this.textBoxretorno.Multiline = true;
            this.textBoxretorno.Name = "textBoxretorno";
            this.textBoxretorno.Size = new System.Drawing.Size(322, 231);
            this.textBoxretorno.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enviar Comando";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxporta
            // 
            this.textBoxporta.Location = new System.Drawing.Point(477, 127);
            this.textBoxporta.Name = "textBoxporta";
            this.textBoxporta.Size = new System.Drawing.Size(100, 20);
            this.textBoxporta.TabIndex = 7;
            this.textBoxporta.Text = "22224";
            this.textBoxporta.TextChanged += new System.EventHandler(this.textBoxporta_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ip de envio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Porta";
            // 
            // textBoxip
            // 
            this.textBoxip.Location = new System.Drawing.Point(477, 83);
            this.textBoxip.Name = "textBoxip";
            this.textBoxip.Size = new System.Drawing.Size(147, 20);
            this.textBoxip.TabIndex = 10;
            this.textBoxip.Text = "10.1.110.20";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Adiciona Parametro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxParam
            // 
            this.listBoxParam.FormattingEnabled = true;
            this.listBoxParam.Location = new System.Drawing.Point(10, 170);
            this.listBoxParam.Name = "listBoxParam";
            this.listBoxParam.Size = new System.Drawing.Size(155, 160);
            this.listBoxParam.TabIndex = 13;
            // 
            // textBoxParam
            // 
            this.textBoxParam.Location = new System.Drawing.Point(10, 121);
            this.textBoxParam.Name = "textBoxParam";
            this.textBoxParam.Size = new System.Drawing.Size(322, 20);
            this.textBoxParam.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lista de Parametros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Retorno do comano";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Limpar Parametros";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelesn
            // 
            this.labelesn.AutoSize = true;
            this.labelesn.Location = new System.Drawing.Point(335, 43);
            this.labelesn.Name = "labelesn";
            this.labelesn.Size = new System.Drawing.Size(73, 13);
            this.labelesn.TabIndex = 18;
            this.labelesn.Text = "99999999999";
            // 
            // textBoxplaca
            // 
            this.textBoxplaca.Location = new System.Drawing.Point(10, 43);
            this.textBoxplaca.Name = "textBoxplaca";
            this.textBoxplaca.Size = new System.Drawing.Size(100, 20);
            this.textBoxplaca.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(126, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 20);
            this.button4.TabIndex = 20;
            this.button4.Text = "Buscar Esn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Digite a placa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Digite  os parametros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 421);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxplaca);
            this.Controls.Add(this.labelesn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxParam);
            this.Controls.Add(this.listBoxParam);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxporta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxretorno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ENVIA COMANDOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBoxporta_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxretorno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxporta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxip;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxParam;
        private System.Windows.Forms.TextBox textBoxParam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelesn;
        private System.Windows.Forms.TextBox textBoxplaca;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

