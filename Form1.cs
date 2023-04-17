using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaProva1
{
    public partial class Form1 : Form
    {
        Onibus[] o1 = new Onibus[30];
        int i = 0;

        Caminhao[] c1 = new Caminhao[30];
        int j = 0;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.branco;
            //maskedTextBoxPlaca.Mask = "000-0000";
            GerarGradelistViewVeiculo();
        }

        private void buttonCadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            if(radioButtonCaminhao.Checked == true && maskedTextBoxPlaca.Text == "")
            {
                MessageBox.Show("Você deve preencher o campo: Placa!");
            }
            else if (radioButtonCaminhao.Checked == true && textBoxAno.Text == "")
            {
                MessageBox.Show("Você deve preencher o campo: Ano!");
            }
            else if (radioButtonCaminhao.Checked == true && textBoxAssenEix.Text == "")
            {
                MessageBox.Show("Você deve preencher o campo: Eixos!");
            }
            if (radioButtonOnibus.Checked == true && maskedTextBoxPlaca.Text == "")
            {
                MessageBox.Show("Você deve preencher o campo: Placa!");
            }
            else if (radioButtonOnibus.Checked == true && textBoxAno.Text == "")
            {
                MessageBox.Show("Você deve preencher o campo: Ano!");
            }
            else if (radioButtonOnibus.Checked == true && textBoxAssenEix.Text == "")
            {
                MessageBox.Show("Você deve preencher o campo: Assentos!");
            }
            else if (radioButtonCaminhao.Checked == true)
            {
                Caminhao m = new Caminhao(maskedTextBoxPlaca.Text, Convert.ToInt32(textBoxAno.Text), Convert.ToInt32(textBoxAssenEix.Text));
                c1[i] = m;

                string[] caminhaum = new string[5];
                caminhaum[0] = m.Placa;
                caminhaum[1] = Convert.ToString(m.Ano);
                caminhaum[3] = Convert.ToString(m.Eixos);
                caminhaum[4] = "R$ " + Convert.ToString(m.alugar());

                listViewVeiculo.Items.Add(new ListViewItem(caminhaum));

                MessageBox.Show("Aluguel diário = " + Convert.ToString(m.alugar()));
            }
            else if(radioButtonOnibus.Checked == true)
            {
                Onibus o = new Onibus(maskedTextBoxPlaca.Text, Convert.ToInt32(textBoxAno.Text), Convert.ToInt32(textBoxAssenEix.Text));
                o1[i] = o;

                string[] onibuss = new string[5];
                onibuss[0] = o.Placa;
                onibuss[1] = Convert.ToString(o.Ano);
                onibuss[2] = Convert.ToString(o.Assentos);
                onibuss[4] = "R$ " + Convert.ToString(o.alugar());

                listViewVeiculo.Items.Add(new ListViewItem(onibuss));

                MessageBox.Show("Aluguel diário = " + Convert.ToString(o.alugar()));
            }
           
        }

        private void radioButtonOnibus_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.onibus;
            labelAssenEix.Text = "Qtd Assentos";
            //maskedTextBoxPlaca.Mask = "000-0000";
        }

        private void radioButtonCaminhao_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.caminhao;
            labelAssenEix.Text = "Qtd Eixos";
            //maskedTextBoxPlaca.Mask = "000-0000";
        }

        private void buttonLimpar_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxPlaca.Text = "";
            textBoxAno.Text = "";
            textBoxAssenEix.Text = "";
        }

        public void GerarGradelistViewVeiculo()
        {
            listViewVeiculo.Columns.Add("Placa", 120).TextAlign = HorizontalAlignment.Center;
            listViewVeiculo.Columns.Add("Ano", 60).TextAlign = HorizontalAlignment.Center;
            listViewVeiculo.Columns.Add("Assentos", 70).TextAlign = HorizontalAlignment.Center;
            listViewVeiculo.Columns.Add("Eixos", 60).TextAlign = HorizontalAlignment.Center;
            listViewVeiculo.Columns.Add("Diaria", 120).TextAlign = HorizontalAlignment.Center;
            listViewVeiculo.View = View.Details;
        }
    }
}
