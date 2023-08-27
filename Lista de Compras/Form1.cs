using Lista_de_Compras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Compras
{
    public partial class Form1 : Form
    {
        private bool isCompradosSelected = false;

        public Form1()
        {
            InitializeComponent();
        }


        private List<Lista_Compras_Item> lista_Compras = new List<Lista_Compras_Item>();

        private void button1_Click(object sender, EventArgs e)
        {
            string adc_Produto = tb_produto.Text;
            int novaQuantidade = Convert.ToInt32(tb_Quantidade.Text);

            if (!string.IsNullOrWhiteSpace(adc_Produto))
            {
                Lista_Compras_Item novoItem = new Lista_Compras_Item
                {
                    Descricao = adc_Produto,
                    Quantidade = novaQuantidade,
                    Comprado = false
                };
                lista_Compras.Add(novoItem);
                AtualizarListBox();
                LimparCampos();
            }
            
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {

            foreach (var selectedItem in lb_Pendentes.SelectedItems)
            {
                if (selectedItem is string selectedString)
                {
                    var selectedItemInfo = selectedString.Split(new string[] { " - " }, StringSplitOptions.None);
                    string descricao = selectedItemInfo[0];
                    int quantidade = int.Parse(selectedItemInfo[1]);

                    var matchingItem = lista_Compras.FirstOrDefault(item => item.Descricao == descricao && item.Quantidade == quantidade);

                    if (matchingItem != null)
                    {
                        if (!matchingItem.Comprado)
                        {
                            matchingItem.Comprado = true;
                            lb_Comprados.Items.Add($"{matchingItem.Descricao} - {matchingItem.Quantidade}");
                        }
                        else
                        {
                            MessageBox.Show("Este produto já foi comprado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado na lista.");
                    }
                }
            }

            AtualizarListBox();
        }
    


        private void btn_Remover_Click(object sender, EventArgs e)
        {
            List<Lista_Compras_Item> itensARemover = new List<Lista_Compras_Item>();

            foreach (var selectedItem in lb_Comprados.SelectedItems)
            {
                if (selectedItem is string selectedString)
                {
                    var selectedItemInfo = selectedString.Split(new string[] { " - " }, StringSplitOptions.None);
                    string descricao = selectedItemInfo[0];
                    int quantidade = int.Parse(selectedItemInfo[1]);

                    var matchingItem = lista_Compras.FirstOrDefault(item => item.Descricao == descricao && item.Quantidade == quantidade);

                    if (matchingItem != null)
                    {
                        itensARemover.Add(matchingItem);
                    }
                }
            }

            foreach (var itemToRemove in itensARemover)
            {
                lb_Comprados.Items.Remove($"{itemToRemove.Descricao} - {itemToRemove.Quantidade}");
                lista_Compras.Remove(itemToRemove);
            }

            AtualizarListBox();
        }
        private void AtualizarListBox()
            {
            lb_Pendentes.Items.Clear();
            lb_Comprados.Items.Clear();

            foreach (var item in lista_Compras)
            {
                string status = $"{item.Descricao} - {item.Quantidade}";


                if (item.Comprado)
                {
                    lb_Comprados.Items.Add(status);
                }
                else
                {
                    lb_Pendentes.Items.Add(status);
                }
            }
          
        }
        private void LimparCampos()
        {
            tb_produto.Clear();
            tb_Quantidade.Clear();
        }

        private void lb_Pendentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            isCompradosSelected = false;

        }

        private void lb_Comprados_SelectedIndexChanged(object sender, EventArgs e)
        {
            isCompradosSelected = true;
        }
    }

}
