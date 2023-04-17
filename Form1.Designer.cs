namespace wfaProva1
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
        private void InitializeComponent()
        {
            this.radioButtonOnibus = new System.Windows.Forms.RadioButton();
            this.radioButtonCaminhao = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAssenEix = new System.Windows.Forms.Label();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.textBoxAssenEix = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.listViewVeiculo = new System.Windows.Forms.ListView();
            this.maskedTextBoxPlaca = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonOnibus
            // 
            this.radioButtonOnibus.AutoSize = true;
            this.radioButtonOnibus.Location = new System.Drawing.Point(43, 30);
            this.radioButtonOnibus.Name = "radioButtonOnibus";
            this.radioButtonOnibus.Size = new System.Drawing.Size(58, 17);
            this.radioButtonOnibus.TabIndex = 0;
            this.radioButtonOnibus.Text = "Ônibus";
            this.radioButtonOnibus.UseVisualStyleBackColor = true;
            this.radioButtonOnibus.CheckedChanged += new System.EventHandler(this.radioButtonOnibus_CheckedChanged);
            // 
            // radioButtonCaminhao
            // 
            this.radioButtonCaminhao.AutoSize = true;
            this.radioButtonCaminhao.Location = new System.Drawing.Point(154, 30);
            this.radioButtonCaminhao.Name = "radioButtonCaminhao";
            this.radioButtonCaminhao.Size = new System.Drawing.Size(72, 17);
            this.radioButtonCaminhao.TabIndex = 1;
            this.radioButtonCaminhao.Text = "Caminhão";
            this.radioButtonCaminhao.UseVisualStyleBackColor = true;
            this.radioButtonCaminhao.CheckedChanged += new System.EventHandler(this.radioButtonCaminhao_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wfaProva1.Properties.Resources.branco;
            this.pictureBox1.Location = new System.Drawing.Point(507, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ano";
            // 
            // labelAssenEix
            // 
            this.labelAssenEix.AutoSize = true;
            this.labelAssenEix.Location = new System.Drawing.Point(43, 136);
            this.labelAssenEix.Name = "labelAssenEix";
            this.labelAssenEix.Size = new System.Drawing.Size(70, 13);
            this.labelAssenEix.TabIndex = 5;
            this.labelAssenEix.Text = "Qtd Assentos";
            // 
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(119, 96);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(100, 20);
            this.textBoxAno.TabIndex = 7;
            // 
            // textBoxAssenEix
            // 
            this.textBoxAssenEix.Location = new System.Drawing.Point(119, 133);
            this.textBoxAssenEix.Name = "textBoxAssenEix";
            this.textBoxAssenEix.Size = new System.Drawing.Size(100, 20);
            this.textBoxAssenEix.TabIndex = 8;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(274, 130);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 9;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCadastrar_MouseClick);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(382, 130);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 10;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLimpar_MouseClick);
            // 
            // listViewVeiculo
            // 
            this.listViewVeiculo.HideSelection = false;
            this.listViewVeiculo.Location = new System.Drawing.Point(43, 184);
            this.listViewVeiculo.Name = "listViewVeiculo";
            this.listViewVeiculo.Size = new System.Drawing.Size(654, 132);
            this.listViewVeiculo.TabIndex = 11;
            this.listViewVeiculo.UseCompatibleStateImageBehavior = false;
            // 
            // maskedTextBoxPlaca
            // 
            this.maskedTextBoxPlaca.Location = new System.Drawing.Point(119, 60);
            this.maskedTextBoxPlaca.Name = "maskedTextBoxPlaca";
            this.maskedTextBoxPlaca.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPlaca.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBoxPlaca);
            this.Controls.Add(this.listViewVeiculo);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.textBoxAssenEix);
            this.Controls.Add(this.textBoxAno);
            this.Controls.Add(this.labelAssenEix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButtonCaminhao);
            this.Controls.Add(this.radioButtonOnibus);
            this.Name = "Form1";
            this.Text = "Cadastro de Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonOnibus;
        private System.Windows.Forms.RadioButton radioButtonCaminhao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAssenEix;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.TextBox textBoxAssenEix;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.ListView listViewVeiculo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaca;
    }
}

