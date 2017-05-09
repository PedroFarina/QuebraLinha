using System;
using System.IO;
using System.Windows.Forms;

namespace QuebraLinha
{
    public partial class frmPrincipal : Form
    {
        string Caminho, Nome;
        int QuantLinhas;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtQuant.Text, out QuantLinhas) == true)
            {
                dlgAbrir.ShowDialog();
                if(dlgAbrir.FileName != "")
                {
                    string[] cut = dlgAbrir.FileName.Split('\\');
                    foreach (string Item in cut)
                    {
                        if (Item != cut[cut.Length - 1])
                        {
                            Caminho += Item + @"\";
                        }                       
                    }
                    Nome = cut[cut.Length - 1].Split('.')[0];
                    Caminho += @"Quebrados";
                    if (!Directory.Exists(Caminho))
                    {
                        Directory.CreateDirectory(Caminho);
                    }
                    Caminho += @"\";
                    Quebrar();
                }
            }
            else
            {
                MessageBox.Show("Quantidade de linhas deve ser um número.", "Oops!");
            }
        }

        private void Quebrar()
        {
            int i = 1, Contalinha = 0;
            StreamWriter sw = new StreamWriter(Caminho + Nome + "(" + Convert.ToString(i) + ").txt", false);
            foreach (string Linha in File.ReadLines(dlgAbrir.FileName, System.Text.Encoding.UTF8))
            {

                Contalinha += 1;
                if ((Contalinha % QuantLinhas) == 0)
                {
                    sw.Write(Linha);
                    sw.Close();
                    i += 1;
                    sw = new StreamWriter(Caminho + Nome + "(" + Convert.ToString(i) + ").txt", false);
                }
                else
                {
                    sw.WriteLine(Linha);
                }
            }
            sw.Close();
            MessageBox.Show("O arquivo foi quebrado.", "Sucesso!");
            System.Diagnostics.Process.Start(Caminho);
            Caminho = null;
        }
    }
}
