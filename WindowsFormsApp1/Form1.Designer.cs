
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_calcular = new DevExpress.XtraEditors.SimpleButton();
            this.txt_quantidade = new DevExpress.XtraEditors.TextEdit();
            this.txt_combustivel = new DevExpress.XtraEditors.TextEdit();
            this.txt_veiculo = new DevExpress.XtraEditors.TextEdit();
            this.txt_distancia = new DevExpress.XtraEditors.TextEdit();
            this.txt_consumo = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem3 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lb_valor_gasolina = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lb_valor_etanol = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lb_valor_diesel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_combustivel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_veiculo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_distancia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_consumo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_valor_gasolina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_valor_etanol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_valor_diesel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.btn_calcular);
            this.layoutControl1.Controls.Add(this.txt_quantidade);
            this.layoutControl1.Controls.Add(this.txt_combustivel);
            this.layoutControl1.Controls.Add(this.txt_veiculo);
            this.layoutControl1.Controls.Add(this.txt_distancia);
            this.layoutControl1.Controls.Add(this.txt_consumo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1111, 189, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 158);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 280);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(12, 132);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(404, 22);
            this.btn_calcular.StyleController = this.layoutControl1;
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(116, 60);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Properties.Mask.EditMask = "n";
            this.txt_quantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_quantidade.Size = new System.Drawing.Size(300, 20);
            this.txt_quantidade.StyleController = this.layoutControl1;
            this.txt_quantidade.TabIndex = 3;
            // 
            // txt_combustivel
            // 
            this.txt_combustivel.Location = new System.Drawing.Point(116, 36);
            this.txt_combustivel.Name = "txt_combustivel";
            this.txt_combustivel.Size = new System.Drawing.Size(300, 20);
            this.txt_combustivel.StyleController = this.layoutControl1;
            this.txt_combustivel.TabIndex = 2;
            // 
            // txt_veiculo
            // 
            this.txt_veiculo.Location = new System.Drawing.Point(116, 12);
            this.txt_veiculo.Name = "txt_veiculo";
            this.txt_veiculo.Size = new System.Drawing.Size(300, 20);
            this.txt_veiculo.StyleController = this.layoutControl1;
            this.txt_veiculo.TabIndex = 0;
            // 
            // txt_distancia
            // 
            this.txt_distancia.Location = new System.Drawing.Point(116, 84);
            this.txt_distancia.Name = "txt_distancia";
            this.txt_distancia.Properties.Mask.EditMask = "n";
            this.txt_distancia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_distancia.Size = new System.Drawing.Size(300, 20);
            this.txt_distancia.StyleController = this.layoutControl1;
            this.txt_distancia.TabIndex = 6;
            // 
            // txt_consumo
            // 
            this.txt_consumo.Location = new System.Drawing.Point(116, 108);
            this.txt_consumo.Name = "txt_consumo";
            this.txt_consumo.Size = new System.Drawing.Size(300, 20);
            this.txt_consumo.StyleController = this.layoutControl1;
            this.txt_consumo.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.simpleLabelItem1,
            this.simpleLabelItem2,
            this.simpleLabelItem3,
            this.lb_valor_gasolina,
            this.lb_valor_etanol,
            this.lb_valor_diesel,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btn_calcular;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(408, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 146);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 284);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txt_veiculo;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(408, 24);
            this.layoutControlItem5.Text = "Veiculo";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txt_combustivel;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(408, 24);
            this.layoutControlItem4.Text = "Combustivel";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_quantidade;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(408, 24);
            this.layoutControlItem3.Text = "Quantidade";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(101, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(408, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(194, 146);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(602, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(178, 17);
            this.simpleLabelItem1.Text = "Gasolina";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(101, 13);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.Location = new System.Drawing.Point(602, 47);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Size = new System.Drawing.Size(178, 17);
            this.simpleLabelItem2.Text = "Etanol";
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(101, 13);
            // 
            // simpleLabelItem3
            // 
            this.simpleLabelItem3.AllowHotTrack = false;
            this.simpleLabelItem3.Location = new System.Drawing.Point(602, 112);
            this.simpleLabelItem3.Name = "simpleLabelItem3";
            this.simpleLabelItem3.Size = new System.Drawing.Size(178, 17);
            this.simpleLabelItem3.Text = "Diesel";
            this.simpleLabelItem3.TextSize = new System.Drawing.Size(101, 13);
            // 
            // lb_valor_gasolina
            // 
            this.lb_valor_gasolina.AllowHotTrack = false;
            this.lb_valor_gasolina.Location = new System.Drawing.Point(602, 17);
            this.lb_valor_gasolina.Name = "lb_valor_gasolina";
            this.lb_valor_gasolina.Size = new System.Drawing.Size(178, 17);
            this.lb_valor_gasolina.Text = " ";
            this.lb_valor_gasolina.TextSize = new System.Drawing.Size(101, 13);
            // 
            // lb_valor_etanol
            // 
            this.lb_valor_etanol.AllowHotTrack = false;
            this.lb_valor_etanol.Location = new System.Drawing.Point(602, 64);
            this.lb_valor_etanol.Name = "lb_valor_etanol";
            this.lb_valor_etanol.Size = new System.Drawing.Size(178, 17);
            this.lb_valor_etanol.Text = " ";
            this.lb_valor_etanol.TextSize = new System.Drawing.Size(101, 13);
            // 
            // lb_valor_diesel
            // 
            this.lb_valor_diesel.AllowHotTrack = false;
            this.lb_valor_diesel.CustomizationFormText = " ";
            this.lb_valor_diesel.Location = new System.Drawing.Point(602, 129);
            this.lb_valor_diesel.Name = "lb_valor_diesel";
            this.lb_valor_diesel.Size = new System.Drawing.Size(178, 17);
            this.lb_valor_diesel.Text = " ";
            this.lb_valor_diesel.TextSize = new System.Drawing.Size(101, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(602, 34);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(178, 13);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(602, 81);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(178, 31);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txt_distancia;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(408, 24);
            this.layoutControlItem6.Text = "Distancia percorrida";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txt_consumo;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(408, 24);
            this.layoutControlItem7.Text = "Consumo médio Km/L";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(101, 13);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_combustivel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_veiculo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_distancia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_consumo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_valor_gasolina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_valor_etanol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_valor_diesel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_calcular;
        private DevExpress.XtraEditors.TextEdit txt_quantidade;
        private DevExpress.XtraEditors.TextEdit txt_combustivel;
        private DevExpress.XtraEditors.TextEdit txt_veiculo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem3;
        private DevExpress.XtraLayout.SimpleLabelItem lb_valor_gasolina;
        private DevExpress.XtraLayout.SimpleLabelItem lb_valor_etanol;
        private DevExpress.XtraLayout.SimpleLabelItem lb_valor_diesel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.TextEdit txt_distancia;
        private DevExpress.XtraEditors.TextEdit txt_consumo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}

