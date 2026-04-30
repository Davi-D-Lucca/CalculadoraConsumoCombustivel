using CalculadoraConsumoCombustivel.Application;
using CalculadoraConsumoCombustivel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using CalculadoraConsumoCombustivel.DTO;
using CalculadoraConsumoCombustivel.Service;
using System.Text.Json;

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
            listarRegistros();
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
            try
            {
                var aplication = new ConsultaListaPosto();
                var diesel = await aplication.ConsultaPostosDiesel();
                var etanol = await aplication.ConsultaPostosEtanol();
                var gasolina = await aplication.ConsultaPostosGasolina();
                IAggregateStrategy strategy = new AggregateStrategy(diesel, etanol, gasolina);
                var result = strategy.Start();
                return result;

            }catch(Exception ex)
            {
                return null;
            }
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
            MediaConsumoCombustivelService service = new MediaConsumoCombustivelService();
            service.adicionarNovoRegistro(getForm());
        }

        private void Campos_EditValueChanged(object sender, EventArgs e)
        {
           bool res = DadosFormCombustivelDTO.validarForms(drdw_postos.EditValue, drdw_combustivel.EditValue,
                                    txt_veiculo.Text, txt_quantidade.Text, txt_consumo.Text, txt_distancia.Text);
            btn_calcular.Enabled = res;
        }


        private DadosFormCombustivelDTO getForm()
        {
            var veiculo = txt_veiculo.Text;
            var distancia = txt_distancia.Text;
            var consumo = txt_consumo.Text;
            var quantidade = txt_quantidade.Text;
            var combustivel = drdw_combustivel.Text;
            DadosFormCombustivelDTO res = new DadosFormCombustivelDTO(veiculo, combustivel, quantidade, consumo, distancia);
            return res;
        }

        public void listarRegistros()
        {
            MediaConsumoCombustivelService service = new MediaConsumoCombustivelService();
            var res = service.listarRegistros();

            //DataTable dt = new DataTable()
            //dt = 

            gridControl1.DataSource = res;
        }

        //Metodo para capturar os dados desses campos.
    }
}
