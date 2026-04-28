
namespace WindowsFormsApp1
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.drdw_combustivel = new DevExpress.XtraEditors.LookUpEdit();
            this.drdw_postos = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_quantidade = new DevExpress.XtraEditors.TextEdit();
            this.txt_veiculo = new DevExpress.XtraEditors.TextEdit();
            this.txt_distancia = new DevExpress.XtraEditors.TextEdit();
            this.txt_consumo = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem3 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.resultGasolina = new DevExpress.XtraLayout.SimpleLabelItem();
            this.resultEtanol = new DevExpress.XtraLayout.SimpleLabelItem();
            this.resultDiesel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lcg_posto = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btn_calcular = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcg_cliente = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drdw_combustivel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drdw_postos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_veiculo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_distancia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_consumo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGasolina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultEtanol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDiesel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg_posto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.drdw_combustivel);
            this.layoutControl1.Controls.Add(this.drdw_postos);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txt_quantidade);
            this.layoutControl1.Controls.Add(this.txt_veiculo);
            this.layoutControl1.Controls.Add(this.txt_distancia);
            this.layoutControl1.Controls.Add(this.txt_consumo);
            this.layoutControl1.Controls.Add(this.btn_calcular);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1111, 189, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // drdw_combustivel
            // 
            this.drdw_combustivel.Location = new System.Drawing.Point(522, 66);
            this.drdw_combustivel.Name = "drdw_combustivel";
            this.drdw_combustivel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drdw_combustivel.Size = new System.Drawing.Size(254, 20);
            this.drdw_combustivel.StyleController = this.layoutControl1;
            this.drdw_combustivel.TabIndex = 15;
            // 
            // drdw_postos
            // 
            this.drdw_postos.Location = new System.Drawing.Point(179, 42);
            this.drdw_postos.Name = "drdw_postos";
            this.drdw_postos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drdw_postos.Size = new System.Drawing.Size(160, 20);
            this.drdw_postos.StyleController = this.layoutControl1;
            this.drdw_postos.TabIndex = 13;
            this.drdw_postos.EditValueChanged += new System.EventHandler(this.drdw_postos_EditValueChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 200);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 238);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(522, 90);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Properties.Mask.EditMask = "f0";
            this.txt_quantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_quantidade.Size = new System.Drawing.Size(254, 20);
            this.txt_quantidade.StyleController = this.layoutControl1;
            this.txt_quantidade.TabIndex = 3;
            // 
            // txt_veiculo
            // 
            this.txt_veiculo.Location = new System.Drawing.Point(522, 42);
            this.txt_veiculo.Name = "txt_veiculo";
            this.txt_veiculo.Size = new System.Drawing.Size(254, 20);
            this.txt_veiculo.StyleController = this.layoutControl1;
            this.txt_veiculo.TabIndex = 0;
            // 
            // txt_distancia
            // 
            this.txt_distancia.Location = new System.Drawing.Point(522, 138);
            this.txt_distancia.Name = "txt_distancia";
            this.txt_distancia.Properties.Mask.EditMask = "f0";
            this.txt_distancia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_distancia.Size = new System.Drawing.Size(254, 20);
            this.txt_distancia.StyleController = this.layoutControl1;
            this.txt_distancia.TabIndex = 6;
            // 
            // txt_consumo
            // 
            this.txt_consumo.Location = new System.Drawing.Point(522, 114);
            this.txt_consumo.Name = "txt_consumo";
            this.txt_consumo.Properties.Mask.EditMask = "f0";
            this.txt_consumo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_consumo.Size = new System.Drawing.Size(254, 20);
            this.txt_consumo.StyleController = this.layoutControl1;
            this.txt_consumo.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.lcg_posto,
            this.lcg_cliente});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 188);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 242);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txt_veiculo;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(413, 24);
            this.layoutControlItem5.Text = "Veiculo";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(152, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_quantidade;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(413, 24);
            this.layoutControlItem3.Text = "Quantidade";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(152, 13);
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 24);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(156, 17);
            this.simpleLabelItem1.Text = "Gasolina";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(152, 13);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.Location = new System.Drawing.Point(0, 59);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Size = new System.Drawing.Size(156, 17);
            this.simpleLabelItem2.Text = "Etanol";
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(152, 13);
            // 
            // simpleLabelItem3
            // 
            this.simpleLabelItem3.AllowHotTrack = false;
            this.simpleLabelItem3.Location = new System.Drawing.Point(0, 91);
            this.simpleLabelItem3.Name = "simpleLabelItem3";
            this.simpleLabelItem3.Size = new System.Drawing.Size(156, 17);
            this.simpleLabelItem3.Text = "Diesel";
            this.simpleLabelItem3.TextSize = new System.Drawing.Size(152, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txt_distancia;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(413, 24);
            this.layoutControlItem6.Text = "Distancia percorrida";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(152, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txt_consumo;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(413, 24);
            this.layoutControlItem7.Text = "Consumo médio do veiculo Km/L";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(152, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.drdw_postos;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(319, 24);
            this.layoutControlItem8.Text = "Postos";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(152, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.drdw_combustivel;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(413, 24);
            this.layoutControlItem9.Text = "Combustivel";
            this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(152, 13);
            // 
            // resultGasolina
            // 
            this.resultGasolina.AllowHotTrack = false;
            this.resultGasolina.Location = new System.Drawing.Point(156, 24);
            this.resultGasolina.Name = "resultGasolina";
            this.resultGasolina.Size = new System.Drawing.Size(163, 17);
            this.resultGasolina.Text = " ";
            this.resultGasolina.TextSize = new System.Drawing.Size(152, 13);
            // 
            // resultEtanol
            // 
            this.resultEtanol.AllowHotTrack = false;
            this.resultEtanol.Location = new System.Drawing.Point(156, 59);
            this.resultEtanol.Name = "resultEtanol";
            this.resultEtanol.Size = new System.Drawing.Size(163, 17);
            this.resultEtanol.Text = " ";
            this.resultEtanol.TextSize = new System.Drawing.Size(152, 13);
            // 
            // resultDiesel
            // 
            this.resultDiesel.AllowHotTrack = false;
            this.resultDiesel.Location = new System.Drawing.Point(156, 91);
            this.resultDiesel.Name = "resultDiesel";
            this.resultDiesel.Size = new System.Drawing.Size(163, 17);
            this.resultDiesel.Text = " ";
            this.resultDiesel.TextSize = new System.Drawing.Size(152, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 41);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(319, 18);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 76);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(319, 15);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 127);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(319, 19);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lcg_posto
            // 
            this.lcg_posto.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.emptySpaceItem5,
            this.resultDiesel,
            this.simpleLabelItem3,
            this.emptySpaceItem3,
            this.simpleLabelItem2,
            this.resultEtanol,
            this.emptySpaceItem2,
            this.resultGasolina,
            this.simpleLabelItem1,
            this.emptySpaceItem4});
            this.lcg_posto.Location = new System.Drawing.Point(0, 0);
            this.lcg_posto.Name = "lcg_posto";
            this.lcg_posto.Size = new System.Drawing.Size(343, 188);
            this.lcg_posto.Text = "Dados do posto";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(367, 162);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(409, 22);
            this.btn_calcular.StyleController = this.layoutControl1;
            this.btn_calcular.TabIndex = 16;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click_1);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_calcular;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(413, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // lcg_cliente
            // 
            this.lcg_cliente.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem3,
            this.layoutControlItem9,
            this.layoutControlItem5,
            this.layoutControlItem4});
            this.lcg_cliente.Location = new System.Drawing.Point(343, 0);
            this.lcg_cliente.Name = "lcg_cliente";
            this.lcg_cliente.Size = new System.Drawing.Size(437, 188);
            this.lcg_cliente.Text = "Dados do cliente";
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 108);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(319, 19);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Calculadora Combustivel";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drdw_combustivel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drdw_postos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_veiculo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_distancia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_consumo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGasolina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultEtanol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDiesel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg_posto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txt_quantidade;
        private DevExpress.XtraEditors.TextEdit txt_veiculo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem3;
        private DevExpress.XtraEditors.TextEdit txt_distancia;
        private DevExpress.XtraEditors.TextEdit txt_consumo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LookUpEdit drdw_postos;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.LookUpEdit drdw_combustivel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.SimpleLabelItem resultGasolina;
        private DevExpress.XtraLayout.SimpleLabelItem resultEtanol;
        private DevExpress.XtraLayout.SimpleLabelItem resultDiesel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup lcg_posto;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SimpleButton btn_calcular;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlGroup lcg_cliente;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}

