using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConversorMoeda
{
    public partial class Form1 : Form
    {
        // Dicion�rio de taxas de c�mbio fixas
        private Dictionary<string, double> taxasDeCambio = new Dictionary<string, double>()
        {
            { "USD-BRL", 5.30 },  // D�lar para Real
            { "EUR-BRL", 5.90 },  // Euro para Real
            { "BRL-USD", 0.19 },  // Real para D�lar
            { "BRL-EUR", 0.17 },  // Real para Euro
            { "USD-EUR", 0.85 },  // D�lar para Euro
            { "EUR-USD", 1.18 }   // Euro para D�lar
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (comboBoxOrigem.SelectedItem != null && comboBoxDestino.SelectedItem != null)
            {
                string moedaOrigem = comboBoxOrigem.SelectedItem?.ToString() ?? string.Empty;
                string moedaDestino = comboBoxDestino.SelectedItem?.ToString() ?? string.Empty;
                double valor;

                // Verifica se o valor inserido � um n�mero v�lido
                if (double.TryParse(txtValor.Text, out valor))
                {
                    try
                    {
                        double resultado = ConverterMoeda(moedaOrigem, moedaDestino, valor);
                        txtResultado.Text = resultado.ToString("F2");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Insira um valor v�lido.");
                }
            }
            else
            {
                MessageBox.Show("Selecione as moedas de origem e destino.");
            }
        }

        private double ConverterMoeda(string? moedaOrigem, string? moedaDestino, double valor)
        {
            // Cria a chave para buscar a taxa de c�mbio no dicion�rio
            string chave = moedaOrigem + "-" + moedaDestino;

            // Verifica se a chave existe no dicion�rio
            if (taxasDeCambio.ContainsKey(chave))
            {
                // Se a chave existir, retorna o valor convertido
                return valor * taxasDeCambio[chave];
            }
            else
            {
                // Se a chave n�o existir, lan�a uma exce��o indicando que a convers�o n�o foi implementada
                throw new Exception("A convers�o entre essas moedas n�o est� implementada.");
            }
        }
        private void comboBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
