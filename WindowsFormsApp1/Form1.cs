using CalculadoraConsumoCombustivel.Application;
using CalculadoraConsumoCombustivel.Interfaces;
using CalculadoraConsumoCombustivel.Service;
using DevExpress.Xpf.Grid.LookUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            PostosCombustiveis();
            TipoCombustivel();
            InicializarForm();
        }

        private void InicializarForm()
        {
            lcg_cliente.Enabled = false;
            resultDiesel.Text = " ";
            resultEtanol.Text = " ";
            resultGasolina.Text = " ";
        }

        private void TipoCombustivel()
        {
            drdw_combustivel.Properties.NullText = "";
            var combustivel = new List<string>();
            combustivel.Add("Gasolina");
            combustivel.Add("Etanol");
            combustivel.Add("Diesel");
            drdw_combustivel.Properties.DataSource = combustivel;
        }

        private async void PostosCombustiveis()
        {
            drdw_postos.Properties.NullText = "";
            var dados = await resultNomePostos();
            drdw_postos.Properties.DataSource = dados;
            drdw_postos.Properties.DisplayMember = "RazaoSocial";
        }

        private async Task<List<PostoAgrupadoDTO>> resultNomePostos()
        {
            var aplication = new ConsultaListaPosto();
            var diesel = await aplication.ConsultaPostosDiesel();
            var etanol = await aplication.ConsultaPostosEtanol();
            var gasolina = await aplication.ConsultaPostosGasolina();
            IAggregateStrategy strategy = new AggregateStrategy(diesel, etanol, gasolina);
            var result = strategy.Start();
            return result;
        }

        private void drdw_postos_EditValueChanged(object sender, EventArgs e)
        {

            var lookup = sender as DevExpress.XtraEditors.LookUpEdit;
            if (lookup == null) return;

            var lista = lookup.Properties.DataSource as List<PostoAgrupadoDTO>;
            if (lista == null) return;

            var valorSelecionado = lookup.EditValue;
            var posto = lookup.GetSelectedDataRow() as PostoAgrupadoDTO;

            var gasolina = posto?.Combustiveis.FirstOrDefault(c => c.Combustivel == "Gasolina");
            var etanol = posto?.Combustiveis.FirstOrDefault(c => c.Combustivel == "Etanol");
            var diesel = posto?.Combustiveis.FirstOrDefault(c => c.Combustivel == "Diesel");

            tratarPreco(resultGasolina, gasolina?.Preco.ToString("F2"));
            tratarPreco(resultEtanol, etanol?.Preco.ToString("F2"));
            tratarPreco(resultDiesel, diesel?.Preco.ToString("F2"));

            lcg_cliente.Enabled = true;
            btn_calcular.Enabled = false;

        }

        private void tratarPreco(SimpleLabelItem label, string combustivel)
        {
            if (!string.IsNullOrEmpty(combustivel))
                label.Text = combustivel;
            else
                label.Text = "0,00";
        }

        private void btn_calcular_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
