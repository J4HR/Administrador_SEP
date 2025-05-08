namespace CExcels
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPageInf = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Inf = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxF_Fin = new System.Windows.Forms.GroupBox();
            this.comboBoxQ_Fin = new System.Windows.Forms.ComboBox();
            this.comboBoxYear_Fin = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBoxF_Ini = new System.Windows.Forms.GroupBox();
            this.comboBoxQ_Ini = new System.Windows.Forms.ComboBox();
            this.comboBoxYear_Ini = new System.Windows.Forms.ComboBox();
            this.groupBox_Dat = new System.Windows.Forms.GroupBox();
            this.textBox_Acaddemico = new System.Windows.Forms.TextBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.textBoxSexo = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelAcaddemico = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.textBox_nss = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.textBox_cp = new System.Windows.Forms.TextBox();
            this.textBox_municipo = new System.Windows.Forms.TextBox();
            this.textBox_colonia = new System.Windows.Forms.TextBox();
            this.textBox_domicilio = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_curp = new System.Windows.Forms.TextBox();
            this.textBox_rfc = new System.Windows.Forms.TextBox();
            this.label_nss = new System.Windows.Forms.Label();
            this.label_tel = new System.Windows.Forms.Label();
            this.label_cp = new System.Windows.Forms.Label();
            this.label_municipio = new System.Windows.Forms.Label();
            this.label_colonia = new System.Windows.Forms.Label();
            this.label_domicilio = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_curp = new System.Windows.Forms.Label();
            this.label_rfc = new System.Windows.Forms.Label();
            this.comboBoxOP = new System.Windows.Forms.ComboBox();
            this.comboBoxMov = new System.Windows.Forms.ComboBox();
            this.groupBoxPlazas = new System.Windows.Forms.GroupBox();
            this.textBox_PLAZA = new System.Windows.Forms.TextBox();
            this.textBox_HRS = new System.Windows.Forms.TextBox();
            this.textBox_SUB = new System.Windows.Forms.TextBox();
            this.textBox_UN = new System.Windows.Forms.TextBox();
            this.textBox_PDA = new System.Windows.Forms.TextBox();
            this.label_PLAZA = new System.Windows.Forms.Label();
            this.label_HRS = new System.Windows.Forms.Label();
            this.label_CAT = new System.Windows.Forms.Label();
            this.label_SUB = new System.Windows.Forms.Label();
            this.label_UN = new System.Windows.Forms.Label();
            this.label_PDA = new System.Windows.Forms.Label();
            this.button_addPlaza = new System.Windows.Forms.Button();
            this.textBox_CAT = new System.Windows.Forms.TextBox();
            this.dataGridViewPlazas = new System.Windows.Forms.DataGridView();
            this.buttonAddLote = new System.Windows.Forms.Button();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLot = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Lot = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabPageInf.SuspendLayout();
            this.tableLayoutPanel_Inf.SuspendLayout();
            this.groupBoxF_Fin.SuspendLayout();
            this.groupBoxF_Ini.SuspendLayout();
            this.groupBox_Dat.SuspendLayout();
            this.groupBoxPlazas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlazas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageLot.SuspendLayout();
            this.tableLayoutPanel_Lot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Enabled = false;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.clickAbrirLote);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.clickSaveLote);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPageInf
            // 
            this.tabPageInf.Controls.Add(this.tableLayoutPanel_Inf);
            this.tabPageInf.Location = new System.Drawing.Point(4, 22);
            this.tabPageInf.Name = "tabPageInf";
            this.tabPageInf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInf.Size = new System.Drawing.Size(559, 485);
            this.tabPageInf.TabIndex = 0;
            this.tabPageInf.Text = "Datos";
            this.tabPageInf.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Inf
            // 
            this.tableLayoutPanel_Inf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Inf.AutoSize = true;
            this.tableLayoutPanel_Inf.ColumnCount = 4;
            this.tableLayoutPanel_Inf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.99046F));
            this.tableLayoutPanel_Inf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.77106F));
            this.tableLayoutPanel_Inf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Inf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel_Inf.Controls.Add(this.groupBoxF_Fin, 2, 1);
            this.tableLayoutPanel_Inf.Controls.Add(this.groupBoxF_Ini, 0, 1);
            this.tableLayoutPanel_Inf.Controls.Add(this.groupBox_Dat, 0, 2);
            this.tableLayoutPanel_Inf.Controls.Add(this.comboBoxOP, 1, 0);
            this.tableLayoutPanel_Inf.Controls.Add(this.comboBoxMov, 0, 0);
            this.tableLayoutPanel_Inf.Controls.Add(this.groupBoxPlazas, 0, 3);
            this.tableLayoutPanel_Inf.Controls.Add(this.buttonAddLote, 0, 4);
            this.tableLayoutPanel_Inf.Controls.Add(this.comboBoxTip, 2, 0);
            this.tableLayoutPanel_Inf.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Inf.Name = "tableLayoutPanel_Inf";
            this.tableLayoutPanel_Inf.RowCount = 5;
            this.tableLayoutPanel_Inf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Inf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_Inf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel_Inf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Inf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel_Inf.Size = new System.Drawing.Size(553, 479);
            this.tableLayoutPanel_Inf.TabIndex = 1;
            // 
            // groupBoxF_Fin
            // 
            this.groupBoxF_Fin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Inf.SetColumnSpan(this.groupBoxF_Fin, 2);
            this.groupBoxF_Fin.Controls.Add(this.comboBoxQ_Fin);
            this.groupBoxF_Fin.Controls.Add(this.comboBoxYear_Fin);
            this.groupBoxF_Fin.Controls.Add(this.comboBox5);
            this.groupBoxF_Fin.Controls.Add(this.comboBox4);
            this.groupBoxF_Fin.Location = new System.Drawing.Point(278, 43);
            this.groupBoxF_Fin.Name = "groupBoxF_Fin";
            this.groupBoxF_Fin.Size = new System.Drawing.Size(272, 44);
            this.groupBoxF_Fin.TabIndex = 0;
            this.groupBoxF_Fin.TabStop = false;
            this.groupBoxF_Fin.Text = "Fecha de Efecto Final";
            // 
            // comboBoxQ_Fin
            // 
            this.comboBoxQ_Fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxQ_Fin.FormattingEnabled = true;
            this.comboBoxQ_Fin.Location = new System.Drawing.Point(89, 17);
            this.comboBoxQ_Fin.Name = "comboBoxQ_Fin";
            this.comboBoxQ_Fin.Size = new System.Drawing.Size(177, 21);
            this.comboBoxQ_Fin.TabIndex = 5;
            this.comboBoxQ_Fin.Text = "Quincena";
            // 
            // comboBoxYear_Fin
            // 
            this.comboBoxYear_Fin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxYear_Fin.FormattingEnabled = true;
            this.comboBoxYear_Fin.Location = new System.Drawing.Point(7, 17);
            this.comboBoxYear_Fin.Name = "comboBoxYear_Fin";
            this.comboBoxYear_Fin.Size = new System.Drawing.Size(77, 21);
            this.comboBoxYear_Fin.TabIndex = 4;
            this.comboBoxYear_Fin.Text = "Año";
            this.comboBoxYear_Fin.SelectedIndexChanged += new System.EventHandler(this.newIndexCB_YearFin);
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(89, -135);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(193, 21);
            this.comboBox5.TabIndex = 1;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(6, -135);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(136, 21);
            this.comboBox4.TabIndex = 0;
            this.comboBox4.Text = "Año";
            // 
            // groupBoxF_Ini
            // 
            this.groupBoxF_Ini.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Inf.SetColumnSpan(this.groupBoxF_Ini, 2);
            this.groupBoxF_Ini.Controls.Add(this.comboBoxQ_Ini);
            this.groupBoxF_Ini.Controls.Add(this.comboBoxYear_Ini);
            this.groupBoxF_Ini.Location = new System.Drawing.Point(3, 43);
            this.groupBoxF_Ini.Name = "groupBoxF_Ini";
            this.groupBoxF_Ini.Size = new System.Drawing.Size(269, 44);
            this.groupBoxF_Ini.TabIndex = 1;
            this.groupBoxF_Ini.TabStop = false;
            this.groupBoxF_Ini.Text = "Fecha de Efecto Inicial";
            // 
            // comboBoxQ_Ini
            // 
            this.comboBoxQ_Ini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxQ_Ini.DropDownWidth = 120;
            this.comboBoxQ_Ini.FormattingEnabled = true;
            this.comboBoxQ_Ini.Location = new System.Drawing.Point(88, 17);
            this.comboBoxQ_Ini.Name = "comboBoxQ_Ini";
            this.comboBoxQ_Ini.Size = new System.Drawing.Size(175, 21);
            this.comboBoxQ_Ini.TabIndex = 3;
            this.comboBoxQ_Ini.Text = "Quincena";
            this.comboBoxQ_Ini.SelectedIndexChanged += new System.EventHandler(this.newIndexCB_Q);
            // 
            // comboBoxYear_Ini
            // 
            this.comboBoxYear_Ini.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxYear_Ini.FormattingEnabled = true;
            this.comboBoxYear_Ini.Location = new System.Drawing.Point(7, 17);
            this.comboBoxYear_Ini.Name = "comboBoxYear_Ini";
            this.comboBoxYear_Ini.Size = new System.Drawing.Size(77, 21);
            this.comboBoxYear_Ini.TabIndex = 2;
            this.comboBoxYear_Ini.Text = "Año";
            this.comboBoxYear_Ini.SelectedIndexChanged += new System.EventHandler(this.newIndexCB_Year);
            // 
            // groupBox_Dat
            // 
            this.groupBox_Dat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Inf.SetColumnSpan(this.groupBox_Dat, 4);
            this.groupBox_Dat.Controls.Add(this.textBox_Acaddemico);
            this.groupBox_Dat.Controls.Add(this.textBoxEstado);
            this.groupBox_Dat.Controls.Add(this.textBoxSexo);
            this.groupBox_Dat.Controls.Add(this.labelEstado);
            this.groupBox_Dat.Controls.Add(this.labelAcaddemico);
            this.groupBox_Dat.Controls.Add(this.labelSexo);
            this.groupBox_Dat.Controls.Add(this.textBox_nss);
            this.groupBox_Dat.Controls.Add(this.textBox_tel);
            this.groupBox_Dat.Controls.Add(this.textBox_cp);
            this.groupBox_Dat.Controls.Add(this.textBox_municipo);
            this.groupBox_Dat.Controls.Add(this.textBox_colonia);
            this.groupBox_Dat.Controls.Add(this.textBox_domicilio);
            this.groupBox_Dat.Controls.Add(this.textBox_name);
            this.groupBox_Dat.Controls.Add(this.textBox_curp);
            this.groupBox_Dat.Controls.Add(this.textBox_rfc);
            this.groupBox_Dat.Controls.Add(this.label_nss);
            this.groupBox_Dat.Controls.Add(this.label_tel);
            this.groupBox_Dat.Controls.Add(this.label_cp);
            this.groupBox_Dat.Controls.Add(this.label_municipio);
            this.groupBox_Dat.Controls.Add(this.label_colonia);
            this.groupBox_Dat.Controls.Add(this.label_domicilio);
            this.groupBox_Dat.Controls.Add(this.label_name);
            this.groupBox_Dat.Controls.Add(this.label_curp);
            this.groupBox_Dat.Controls.Add(this.label_rfc);
            this.groupBox_Dat.Location = new System.Drawing.Point(3, 93);
            this.groupBox_Dat.Name = "groupBox_Dat";
            this.groupBox_Dat.Size = new System.Drawing.Size(547, 145);
            this.groupBox_Dat.TabIndex = 2;
            this.groupBox_Dat.TabStop = false;
            this.groupBox_Dat.Text = "Datos";
            // 
            // textBox_Acaddemico
            // 
            this.textBox_Acaddemico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Acaddemico.Location = new System.Drawing.Point(474, 116);
            this.textBox_Acaddemico.Name = "textBox_Acaddemico";
            this.textBox_Acaddemico.Size = new System.Drawing.Size(67, 20);
            this.textBox_Acaddemico.TabIndex = 23;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEstado.Location = new System.Drawing.Point(493, 39);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(48, 20);
            this.textBoxEstado.TabIndex = 22;
            // 
            // textBoxSexo
            // 
            this.textBoxSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSexo.Location = new System.Drawing.Point(493, 13);
            this.textBoxSexo.Name = "textBoxSexo";
            this.textBoxSexo.Size = new System.Drawing.Size(48, 20);
            this.textBoxSexo.TabIndex = 21;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(444, 45);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(43, 13);
            this.labelEstado.TabIndex = 20;
            this.labelEstado.Text = "Estado:";
            // 
            // labelAcaddemico
            // 
            this.labelAcaddemico.AutoSize = true;
            this.labelAcaddemico.Location = new System.Drawing.Point(410, 123);
            this.labelAcaddemico.Name = "labelAcaddemico";
            this.labelAcaddemico.Size = new System.Drawing.Size(63, 13);
            this.labelAcaddemico.TabIndex = 19;
            this.labelAcaddemico.Text = "Academico:";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(453, 16);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(34, 13);
            this.labelSexo.TabIndex = 18;
            this.labelSexo.Text = "Sexo:";
            // 
            // textBox_nss
            // 
            this.textBox_nss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_nss.Location = new System.Drawing.Point(263, 116);
            this.textBox_nss.MaximumSize = new System.Drawing.Size(141, 20);
            this.textBox_nss.Name = "textBox_nss";
            this.textBox_nss.Size = new System.Drawing.Size(141, 20);
            this.textBox_nss.TabIndex = 17;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(126, 116);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(100, 20);
            this.textBox_tel.TabIndex = 16;
            // 
            // textBox_cp
            // 
            this.textBox_cp.Location = new System.Drawing.Point(43, 116);
            this.textBox_cp.Name = "textBox_cp";
            this.textBox_cp.Size = new System.Drawing.Size(51, 20);
            this.textBox_cp.TabIndex = 15;
            // 
            // textBox_municipo
            // 
            this.textBox_municipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_municipo.Location = new System.Drawing.Point(232, 90);
            this.textBox_municipo.Name = "textBox_municipo";
            this.textBox_municipo.Size = new System.Drawing.Size(309, 20);
            this.textBox_municipo.TabIndex = 14;
            // 
            // textBox_colonia
            // 
            this.textBox_colonia.Location = new System.Drawing.Point(59, 90);
            this.textBox_colonia.Name = "textBox_colonia";
            this.textBox_colonia.Size = new System.Drawing.Size(106, 20);
            this.textBox_colonia.TabIndex = 13;
            // 
            // textBox_domicilio
            // 
            this.textBox_domicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_domicilio.Location = new System.Drawing.Point(59, 64);
            this.textBox_domicilio.Name = "textBox_domicilio";
            this.textBox_domicilio.Size = new System.Drawing.Size(482, 20);
            this.textBox_domicilio.TabIndex = 12;
            this.textBox_domicilio.Text = "Calle,Numero";
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name.Location = new System.Drawing.Point(59, 38);
            this.textBox_name.MaximumSize = new System.Drawing.Size(379, 20);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(379, 20);
            this.textBox_name.TabIndex = 11;
            // 
            // textBox_curp
            // 
            this.textBox_curp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_curp.Location = new System.Drawing.Point(217, 13);
            this.textBox_curp.MaximumSize = new System.Drawing.Size(230, 20);
            this.textBox_curp.Name = "textBox_curp";
            this.textBox_curp.Size = new System.Drawing.Size(230, 20);
            this.textBox_curp.TabIndex = 10;
            // 
            // textBox_rfc
            // 
            this.textBox_rfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_rfc.Location = new System.Drawing.Point(43, 13);
            this.textBox_rfc.MaxLength = 13;
            this.textBox_rfc.Name = "textBox_rfc";
            this.textBox_rfc.Size = new System.Drawing.Size(125, 20);
            this.textBox_rfc.TabIndex = 9;
            this.textBox_rfc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownRFC);
            // 
            // label_nss
            // 
            this.label_nss.AutoSize = true;
            this.label_nss.Location = new System.Drawing.Point(232, 123);
            this.label_nss.Name = "label_nss";
            this.label_nss.Size = new System.Drawing.Size(32, 13);
            this.label_nss.TabIndex = 8;
            this.label_nss.Text = "NSS:";
            // 
            // label_tel
            // 
            this.label_tel.AutoSize = true;
            this.label_tel.Location = new System.Drawing.Point(100, 123);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(28, 13);
            this.label_tel.TabIndex = 7;
            this.label_tel.Text = "Tel.:";
            // 
            // label_cp
            // 
            this.label_cp.AutoSize = true;
            this.label_cp.Location = new System.Drawing.Point(6, 123);
            this.label_cp.Name = "label_cp";
            this.label_cp.Size = new System.Drawing.Size(27, 13);
            this.label_cp.TabIndex = 6;
            this.label_cp.Text = "C.P.";
            // 
            // label_municipio
            // 
            this.label_municipio.AutoSize = true;
            this.label_municipio.Location = new System.Drawing.Point(171, 97);
            this.label_municipio.Name = "label_municipio";
            this.label_municipio.Size = new System.Drawing.Size(55, 13);
            this.label_municipio.TabIndex = 5;
            this.label_municipio.Text = "Municipio:";
            // 
            // label_colonia
            // 
            this.label_colonia.AutoSize = true;
            this.label_colonia.Location = new System.Drawing.Point(6, 97);
            this.label_colonia.Name = "label_colonia";
            this.label_colonia.Size = new System.Drawing.Size(45, 13);
            this.label_colonia.TabIndex = 4;
            this.label_colonia.Text = "Colonia:";
            // 
            // label_domicilio
            // 
            this.label_domicilio.AutoSize = true;
            this.label_domicilio.Location = new System.Drawing.Point(6, 71);
            this.label_domicilio.Name = "label_domicilio";
            this.label_domicilio.Size = new System.Drawing.Size(52, 13);
            this.label_domicilio.TabIndex = 3;
            this.label_domicilio.Text = "Domicilio:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(6, 45);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(47, 13);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Nombre:";
            // 
            // label_curp
            // 
            this.label_curp.AutoSize = true;
            this.label_curp.Location = new System.Drawing.Point(171, 16);
            this.label_curp.Name = "label_curp";
            this.label_curp.Size = new System.Drawing.Size(40, 13);
            this.label_curp.TabIndex = 1;
            this.label_curp.Text = "CURP:";
            // 
            // label_rfc
            // 
            this.label_rfc.AutoSize = true;
            this.label_rfc.Location = new System.Drawing.Point(6, 16);
            this.label_rfc.Name = "label_rfc";
            this.label_rfc.Size = new System.Drawing.Size(31, 13);
            this.label_rfc.TabIndex = 0;
            this.label_rfc.Text = "RFC:";
            // 
            // comboBoxOP
            // 
            this.comboBoxOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOP.FormattingEnabled = true;
            this.comboBoxOP.Location = new System.Drawing.Point(80, 9);
            this.comboBoxOP.Name = "comboBoxOP";
            this.comboBoxOP.Size = new System.Drawing.Size(192, 21);
            this.comboBoxOP.TabIndex = 4;
            this.comboBoxOP.Text = "Opcciones";
            this.comboBoxOP.SelectedIndexChanged += new System.EventHandler(this.newIndexCB_OP);
            // 
            // comboBoxMov
            // 
            this.comboBoxMov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMov.Enabled = false;
            this.comboBoxMov.FormattingEnabled = true;
            this.comboBoxMov.Location = new System.Drawing.Point(3, 9);
            this.comboBoxMov.Name = "comboBoxMov";
            this.comboBoxMov.Size = new System.Drawing.Size(71, 21);
            this.comboBoxMov.TabIndex = 5;
            this.comboBoxMov.Text = "Movimiento";
            this.comboBoxMov.SelectedIndexChanged += new System.EventHandler(this.newIndexCB_Mov);
            // 
            // groupBoxPlazas
            // 
            this.groupBoxPlazas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Inf.SetColumnSpan(this.groupBoxPlazas, 4);
            this.groupBoxPlazas.Controls.Add(this.textBox_PLAZA);
            this.groupBoxPlazas.Controls.Add(this.textBox_HRS);
            this.groupBoxPlazas.Controls.Add(this.textBox_SUB);
            this.groupBoxPlazas.Controls.Add(this.textBox_UN);
            this.groupBoxPlazas.Controls.Add(this.textBox_PDA);
            this.groupBoxPlazas.Controls.Add(this.label_PLAZA);
            this.groupBoxPlazas.Controls.Add(this.label_HRS);
            this.groupBoxPlazas.Controls.Add(this.label_CAT);
            this.groupBoxPlazas.Controls.Add(this.label_SUB);
            this.groupBoxPlazas.Controls.Add(this.label_UN);
            this.groupBoxPlazas.Controls.Add(this.label_PDA);
            this.groupBoxPlazas.Controls.Add(this.button_addPlaza);
            this.groupBoxPlazas.Controls.Add(this.textBox_CAT);
            this.groupBoxPlazas.Controls.Add(this.dataGridViewPlazas);
            this.groupBoxPlazas.Location = new System.Drawing.Point(3, 244);
            this.groupBoxPlazas.Name = "groupBoxPlazas";
            this.groupBoxPlazas.Size = new System.Drawing.Size(547, 203);
            this.groupBoxPlazas.TabIndex = 6;
            this.groupBoxPlazas.TabStop = false;
            this.groupBoxPlazas.Text = "Plazas";
            // 
            // textBox_PLAZA
            // 
            this.textBox_PLAZA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_PLAZA.Location = new System.Drawing.Point(438, 13);
            this.textBox_PLAZA.MaxLength = 6;
            this.textBox_PLAZA.Name = "textBox_PLAZA";
            this.textBox_PLAZA.Size = new System.Drawing.Size(55, 20);
            this.textBox_PLAZA.TabIndex = 28;
            // 
            // textBox_HRS
            // 
            this.textBox_HRS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_HRS.Location = new System.Drawing.Point(349, 13);
            this.textBox_HRS.MaxLength = 2;
            this.textBox_HRS.Name = "textBox_HRS";
            this.textBox_HRS.Size = new System.Drawing.Size(37, 20);
            this.textBox_HRS.TabIndex = 27;
            // 
            // textBox_SUB
            // 
            this.textBox_SUB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_SUB.Location = new System.Drawing.Point(192, 13);
            this.textBox_SUB.MaxLength = 2;
            this.textBox_SUB.Name = "textBox_SUB";
            this.textBox_SUB.Size = new System.Drawing.Size(40, 20);
            this.textBox_SUB.TabIndex = 26;
            // 
            // textBox_UN
            // 
            this.textBox_UN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_UN.Location = new System.Drawing.Point(116, 13);
            this.textBox_UN.MaxLength = 2;
            this.textBox_UN.Name = "textBox_UN";
            this.textBox_UN.Size = new System.Drawing.Size(39, 20);
            this.textBox_UN.TabIndex = 25;
            // 
            // textBox_PDA
            // 
            this.textBox_PDA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_PDA.Location = new System.Drawing.Point(39, 13);
            this.textBox_PDA.MaxLength = 2;
            this.textBox_PDA.Name = "textBox_PDA";
            this.textBox_PDA.Size = new System.Drawing.Size(42, 20);
            this.textBox_PDA.TabIndex = 24;
            // 
            // label_PLAZA
            // 
            this.label_PLAZA.AutoSize = true;
            this.label_PLAZA.Location = new System.Drawing.Point(390, 16);
            this.label_PLAZA.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label_PLAZA.Name = "label_PLAZA";
            this.label_PLAZA.Size = new System.Drawing.Size(44, 13);
            this.label_PLAZA.TabIndex = 23;
            this.label_PLAZA.Text = "PLAZA:";
            // 
            // label_HRS
            // 
            this.label_HRS.AutoSize = true;
            this.label_HRS.Location = new System.Drawing.Point(312, 15);
            this.label_HRS.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label_HRS.Name = "label_HRS";
            this.label_HRS.Size = new System.Drawing.Size(33, 13);
            this.label_HRS.TabIndex = 22;
            this.label_HRS.Text = "HRS:";
            // 
            // label_CAT
            // 
            this.label_CAT.AutoSize = true;
            this.label_CAT.Location = new System.Drawing.Point(236, 16);
            this.label_CAT.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label_CAT.Name = "label_CAT";
            this.label_CAT.Size = new System.Drawing.Size(31, 13);
            this.label_CAT.TabIndex = 21;
            this.label_CAT.Text = "CAT:";
            // 
            // label_SUB
            // 
            this.label_SUB.AutoSize = true;
            this.label_SUB.Location = new System.Drawing.Point(159, 17);
            this.label_SUB.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label_SUB.Name = "label_SUB";
            this.label_SUB.Size = new System.Drawing.Size(32, 13);
            this.label_SUB.TabIndex = 20;
            this.label_SUB.Text = "SUB:";
            // 
            // label_UN
            // 
            this.label_UN.AutoSize = true;
            this.label_UN.Location = new System.Drawing.Point(86, 17);
            this.label_UN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UN.Name = "label_UN";
            this.label_UN.Size = new System.Drawing.Size(26, 13);
            this.label_UN.TabIndex = 19;
            this.label_UN.Text = "UN:";
            // 
            // label_PDA
            // 
            this.label_PDA.AutoSize = true;
            this.label_PDA.Location = new System.Drawing.Point(6, 16);
            this.label_PDA.Name = "label_PDA";
            this.label_PDA.Size = new System.Drawing.Size(32, 13);
            this.label_PDA.TabIndex = 18;
            this.label_PDA.Text = "PDA:";
            // 
            // button_addPlaza
            // 
            this.button_addPlaza.Enabled = false;
            this.button_addPlaza.Location = new System.Drawing.Point(499, 13);
            this.button_addPlaza.Name = "button_addPlaza";
            this.button_addPlaza.Size = new System.Drawing.Size(42, 21);
            this.button_addPlaza.TabIndex = 7;
            this.button_addPlaza.Text = "Add";
            this.button_addPlaza.UseVisualStyleBackColor = true;
            this.button_addPlaza.Click += new System.EventHandler(this.click_AddPlaza);
            // 
            // textBox_CAT
            // 
            this.textBox_CAT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_CAT.Location = new System.Drawing.Point(268, 13);
            this.textBox_CAT.MaxLength = 7;
            this.textBox_CAT.Name = "textBox_CAT";
            this.textBox_CAT.Size = new System.Drawing.Size(41, 20);
            this.textBox_CAT.TabIndex = 4;
            // 
            // dataGridViewPlazas
            // 
            this.dataGridViewPlazas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPlazas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlazas.Location = new System.Drawing.Point(7, 40);
            this.dataGridViewPlazas.Name = "dataGridViewPlazas";
            this.dataGridViewPlazas.Size = new System.Drawing.Size(534, 158);
            this.dataGridViewPlazas.TabIndex = 0;
            // 
            // buttonAddLote
            // 
            this.buttonAddLote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Inf.SetColumnSpan(this.buttonAddLote, 4);
            this.buttonAddLote.Location = new System.Drawing.Point(3, 453);
            this.buttonAddLote.Name = "buttonAddLote";
            this.buttonAddLote.Size = new System.Drawing.Size(547, 23);
            this.buttonAddLote.TabIndex = 7;
            this.buttonAddLote.Text = "Agregar al Lote";
            this.buttonAddLote.UseVisualStyleBackColor = true;
            this.buttonAddLote.Click += new System.EventHandler(this.click_AddLote);
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Inf.SetColumnSpan(this.comboBoxTip, 2);
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Location = new System.Drawing.Point(278, 9);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(272, 21);
            this.comboBoxTip.TabIndex = 3;
            this.comboBoxTip.Text = "Tipo";
            this.comboBoxTip.SelectedIndexChanged += new System.EventHandler(this.newIndexCB_Tip);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageInf);
            this.tabControl1.Controls.Add(this.tabPageLot);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 511);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Click += new System.EventHandler(this.clickPestLote);
            // 
            // tabPageLot
            // 
            this.tabPageLot.Controls.Add(this.tableLayoutPanel_Lot);
            this.tabPageLot.Location = new System.Drawing.Point(4, 22);
            this.tabPageLot.Name = "tabPageLot";
            this.tabPageLot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLot.Size = new System.Drawing.Size(559, 485);
            this.tabPageLot.TabIndex = 2;
            this.tabPageLot.Text = "Lote";
            this.tabPageLot.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Lot
            // 
            this.tableLayoutPanel_Lot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Lot.ColumnCount = 2;
            this.tableLayoutPanel_Lot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.70309F));
            this.tableLayoutPanel_Lot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel_Lot.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel_Lot.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel_Lot.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel_Lot.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Lot.Name = "tableLayoutPanel_Lot";
            this.tableLayoutPanel_Lot.RowCount = 2;
            this.tableLayoutPanel_Lot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.79105F));
            this.tableLayoutPanel_Lot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.208955F));
            this.tableLayoutPanel_Lot.Size = new System.Drawing.Size(553, 479);
            this.tableLayoutPanel_Lot.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(272, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Borrar seleccion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel_Lot.SetColumnSpan(this.dataGridView2, 2);
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Size = new System.Drawing.Size(547, 433);
            this.dataGridView2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Copiar seleccion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 539);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(583, 578);
            this.Name = "Form1";
            this.Text = "Secundarias Generales Estatales y Federales";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageInf.ResumeLayout(false);
            this.tabPageInf.PerformLayout();
            this.tableLayoutPanel_Inf.ResumeLayout(false);
            this.groupBoxF_Fin.ResumeLayout(false);
            this.groupBoxF_Ini.ResumeLayout(false);
            this.groupBox_Dat.ResumeLayout(false);
            this.groupBox_Dat.PerformLayout();
            this.groupBoxPlazas.ResumeLayout(false);
            this.groupBoxPlazas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlazas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLot.ResumeLayout(false);
            this.tableLayoutPanel_Lot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tabPageInf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Inf;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Lot;
        private System.Windows.Forms.GroupBox groupBoxF_Ini;
        private System.Windows.Forms.GroupBox groupBox_Dat;
        private System.Windows.Forms.GroupBox groupBoxF_Fin;
        private System.Windows.Forms.ComboBox comboBoxQ_Fin;
        private System.Windows.Forms.ComboBox comboBoxYear_Fin;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBoxQ_Ini;
        private System.Windows.Forms.ComboBox comboBoxYear_Ini;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.ComboBox comboBoxOP;
        private System.Windows.Forms.ComboBox comboBoxMov;
        private System.Windows.Forms.GroupBox groupBoxPlazas;
        private System.Windows.Forms.DataGridView dataGridViewPlazas;
        private System.Windows.Forms.Label label_nss;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.Label label_cp;
        private System.Windows.Forms.Label label_municipio;
        private System.Windows.Forms.Label label_colonia;
        private System.Windows.Forms.Label label_domicilio;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_curp;
        private System.Windows.Forms.Label label_rfc;
        private System.Windows.Forms.TextBox textBox_nss;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.TextBox textBox_cp;
        private System.Windows.Forms.TextBox textBox_municipo;
        private System.Windows.Forms.TextBox textBox_colonia;
        private System.Windows.Forms.TextBox textBox_domicilio;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_curp;
        private System.Windows.Forms.TextBox textBox_rfc;
        private System.Windows.Forms.Button button_addPlaza;
        private System.Windows.Forms.Button buttonAddLote;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_PLAZA;
        private System.Windows.Forms.Label label_HRS;
        private System.Windows.Forms.Label label_CAT;
        private System.Windows.Forms.Label label_SUB;
        private System.Windows.Forms.Label label_UN;
        private System.Windows.Forms.Label label_PDA;
        private System.Windows.Forms.TextBox textBox_Acaddemico;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.TextBox textBoxSexo;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelAcaddemico;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.TextBox textBox_PLAZA;
        private System.Windows.Forms.TextBox textBox_HRS;
        private System.Windows.Forms.TextBox textBox_SUB;
        private System.Windows.Forms.TextBox textBox_UN;
        private System.Windows.Forms.TextBox textBox_PDA;
        private System.Windows.Forms.TextBox textBox_CAT;
    }
}

