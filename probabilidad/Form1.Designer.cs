namespace probabilidad
{
    partial class form1
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
            this.dgw = new System.Windows.Forms.DataGridView();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xixfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xi2xfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnN = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtcuadrado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.Modatxt = new System.Windows.Forms.TextBox();
            this.Medianatxt = new System.Windows.Forms.TextBox();
            this.Mediatxt = new System.Windows.Forms.TextBox();
            this.Moda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btcalcular = new System.Windows.Forms.Button();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.ListaNumeros = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvarianza = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtvarianzaM = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtTipica = new System.Windows.Forms.TextBox();
            this.btnPercentil = new System.Windows.Forms.Button();
            this.txtPercentilMuestra = new System.Windows.Forms.TextBox();
            this.txtPercentil = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblProbCruz = new System.Windows.Forms.Label();
            this.CbVeces = new System.Windows.Forms.ComboBox();
            this.BtComenzar = new System.Windows.Forms.Button();
            this.LblProbCara = new System.Windows.Forms.Label();
            this.LblCruz = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCaras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw
            // 
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xi,
            this.fi,
            this.Xixfi,
            this.xfi,
            this.xi2xfi});
            this.dgw.Location = new System.Drawing.Point(19, 41);
            this.dgw.Margin = new System.Windows.Forms.Padding(2);
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 62;
            this.dgw.RowTemplate.Height = 28;
            this.dgw.Size = new System.Drawing.Size(814, 124);
            this.dgw.TabIndex = 0;
            this.dgw.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellEndEdit_1);
            // 
            // Xi
            // 
            this.Xi.HeaderText = "Xi";
            this.Xi.MinimumWidth = 8;
            this.Xi.Name = "Xi";
            this.Xi.Width = 150;
            // 
            // fi
            // 
            this.fi.HeaderText = "fi";
            this.fi.MinimumWidth = 8;
            this.fi.Name = "fi";
            this.fi.Width = 150;
            // 
            // Xixfi
            // 
            this.Xixfi.HeaderText = "Xi * fi";
            this.Xixfi.MinimumWidth = 8;
            this.Xixfi.Name = "Xixfi";
            this.Xixfi.Width = 150;
            // 
            // xfi
            // 
            this.xfi.HeaderText = "* fi";
            this.xfi.MinimumWidth = 8;
            this.xfi.Name = "xfi";
            this.xfi.Width = 150;
            // 
            // xi2xfi
            // 
            this.xi2xfi.HeaderText = "xi2 *fi";
            this.xi2xfi.MinimumWidth = 8;
            this.xi2xfi.Name = "xi2xfi";
            this.xi2xfi.Width = 150;
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(86, 187);
            this.btnN.Margin = new System.Windows.Forms.Padding(2);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(32, 29);
            this.btnN.TabIndex = 1;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(122, 187);
            this.txtN.Margin = new System.Windows.Forms.Padding(2);
            this.txtN.Multiline = true;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(37, 29);
            this.txtN.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xi * fi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(443, 187);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtproducto.Multiline = true;
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(40, 29);
            this.txtproducto.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 187);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xi² * fi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtcuadrado
            // 
            this.txtcuadrado.Location = new System.Drawing.Point(744, 186);
            this.txtcuadrado.Margin = new System.Windows.Forms.Padding(2);
            this.txtcuadrado.Multiline = true;
            this.txtcuadrado.Name = "txtcuadrado";
            this.txtcuadrado.Size = new System.Drawing.Size(40, 30);
            this.txtcuadrado.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDatos);
            this.panel1.Controls.Add(this.Modatxt);
            this.panel1.Controls.Add(this.Medianatxt);
            this.panel1.Controls.Add(this.Mediatxt);
            this.panel1.Controls.Add(this.Moda);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Btcalcular);
            this.panel1.Controls.Add(this.BtAgregar);
            this.panel1.Controls.Add(this.ListaNumeros);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 224);
            this.panel1.TabIndex = 8;
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(20, 61);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(100, 20);
            this.txtDatos.TabIndex = 31;
            // 
            // Modatxt
            // 
            this.Modatxt.Location = new System.Drawing.Point(658, 157);
            this.Modatxt.Name = "Modatxt";
            this.Modatxt.Size = new System.Drawing.Size(100, 20);
            this.Modatxt.TabIndex = 30;
            // 
            // Medianatxt
            // 
            this.Medianatxt.Location = new System.Drawing.Point(658, 116);
            this.Medianatxt.Name = "Medianatxt";
            this.Medianatxt.Size = new System.Drawing.Size(100, 20);
            this.Medianatxt.TabIndex = 29;
            // 
            // Mediatxt
            // 
            this.Mediatxt.Location = new System.Drawing.Point(658, 75);
            this.Mediatxt.Name = "Mediatxt";
            this.Mediatxt.Size = new System.Drawing.Size(100, 20);
            this.Mediatxt.TabIndex = 28;
            // 
            // Moda
            // 
            this.Moda.AutoSize = true;
            this.Moda.Location = new System.Drawing.Point(537, 157);
            this.Moda.Name = "Moda";
            this.Moda.Size = new System.Drawing.Size(34, 13);
            this.Moda.TabIndex = 27;
            this.Moda.Text = "Moda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mediana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Media";
            // 
            // Btcalcular
            // 
            this.Btcalcular.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btcalcular.Location = new System.Drawing.Point(411, 111);
            this.Btcalcular.Name = "Btcalcular";
            this.Btcalcular.Size = new System.Drawing.Size(75, 23);
            this.Btcalcular.TabIndex = 24;
            this.Btcalcular.Text = "Calcular";
            this.Btcalcular.UseVisualStyleBackColor = true;
            this.Btcalcular.Click += new System.EventHandler(this.Btcalcular_Click);
            // 
            // BtAgregar
            // 
            this.BtAgregar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAgregar.Location = new System.Drawing.Point(147, 58);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtAgregar.TabIndex = 16;
            this.BtAgregar.Text = "Agregar";
            this.BtAgregar.UseVisualStyleBackColor = true;
            this.BtAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // ListaNumeros
            // 
            this.ListaNumeros.FormattingEnabled = true;
            this.ListaNumeros.Location = new System.Drawing.Point(20, 106);
            this.ListaNumeros.Name = "ListaNumeros";
            this.ListaNumeros.Size = new System.Drawing.Size(99, 108);
            this.ListaNumeros.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingrese los datos de los cuales desea calcular: Media - Mediana - Moda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "frecuencias absolutas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "media";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor absoluto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(684, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "desviacion tipica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Datos";
            // 
            // txtvarianza
            // 
            this.txtvarianza.Location = new System.Drawing.Point(936, 176);
            this.txtvarianza.Margin = new System.Windows.Forms.Padding(2);
            this.txtvarianza.Multiline = true;
            this.txtvarianza.Name = "txtvarianza";
            this.txtvarianza.Size = new System.Drawing.Size(68, 30);
            this.txtvarianza.TabIndex = 7;
            this.txtvarianza.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(83, 248);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 29);
            this.button3.TabIndex = 18;
            this.button3.Text = "varianza";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 20;
            // 
            // txtvarianzaM
            // 
            this.txtvarianzaM.Location = new System.Drawing.Point(176, 248);
            this.txtvarianzaM.Margin = new System.Windows.Forms.Padding(2);
            this.txtvarianzaM.Multiline = true;
            this.txtvarianzaM.Name = "txtvarianzaM";
            this.txtvarianzaM.Size = new System.Drawing.Size(58, 29);
            this.txtvarianzaM.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(392, 248);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 29);
            this.button4.TabIndex = 22;
            this.button4.Text = "Dsv Tipica";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtTipica
            // 
            this.txtTipica.Location = new System.Drawing.Point(485, 248);
            this.txtTipica.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipica.Multiline = true;
            this.txtTipica.Name = "txtTipica";
            this.txtTipica.Size = new System.Drawing.Size(58, 29);
            this.txtTipica.TabIndex = 23;
            // 
            // btnPercentil
            // 
            this.btnPercentil.Location = new System.Drawing.Point(932, 132);
            this.btnPercentil.Margin = new System.Windows.Forms.Padding(2);
            this.btnPercentil.Name = "btnPercentil";
            this.btnPercentil.Size = new System.Drawing.Size(76, 29);
            this.btnPercentil.TabIndex = 24;
            this.btnPercentil.Text = "Percentil";
            this.btnPercentil.UseVisualStyleBackColor = true;
            this.btnPercentil.Visible = false;
            this.btnPercentil.Click += new System.EventHandler(this.btnPercentil_Click_1);
            // 
            // txtPercentilMuestra
            // 
            this.txtPercentilMuestra.Location = new System.Drawing.Point(1025, 132);
            this.txtPercentilMuestra.Margin = new System.Windows.Forms.Padding(2);
            this.txtPercentilMuestra.Multiline = true;
            this.txtPercentilMuestra.Name = "txtPercentilMuestra";
            this.txtPercentilMuestra.Size = new System.Drawing.Size(58, 29);
            this.txtPercentilMuestra.TabIndex = 25;
            this.txtPercentilMuestra.Visible = false;
            // 
            // txtPercentil
            // 
            this.txtPercentil.Location = new System.Drawing.Point(1025, 176);
            this.txtPercentil.Margin = new System.Windows.Forms.Padding(2);
            this.txtPercentil.Multiline = true;
            this.txtPercentil.Name = "txtPercentil";
            this.txtPercentil.Size = new System.Drawing.Size(34, 30);
            this.txtPercentil.TabIndex = 27;
            this.txtPercentil.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblProbCruz);
            this.groupBox2.Controls.Add(this.CbVeces);
            this.groupBox2.Controls.Add(this.BtComenzar);
            this.groupBox2.Controls.Add(this.LblProbCara);
            this.groupBox2.Controls.Add(this.LblCruz);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblCaras);
            this.groupBox2.Location = new System.Drawing.Point(19, 548);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 224);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(619, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Probabilida de cruz";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(404, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Probabilidad de caras";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Cruz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Caras";
            // 
            // lblProbCruz
            // 
            this.lblProbCruz.AutoSize = true;
            this.lblProbCruz.Location = new System.Drawing.Point(619, 154);
            this.lblProbCruz.Name = "lblProbCruz";
            this.lblProbCruz.Size = new System.Drawing.Size(97, 13);
            this.lblProbCruz.TabIndex = 13;
            this.lblProbCruz.Text = "Probabilida de cruz";
            // 
            // CbVeces
            // 
            this.CbVeces.FormattingEnabled = true;
            this.CbVeces.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CbVeces.Location = new System.Drawing.Point(508, 58);
            this.CbVeces.Name = "CbVeces";
            this.CbVeces.Size = new System.Drawing.Size(65, 21);
            this.CbVeces.TabIndex = 8;
            // 
            // BtComenzar
            // 
            this.BtComenzar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtComenzar.Location = new System.Drawing.Point(629, 56);
            this.BtComenzar.Name = "BtComenzar";
            this.BtComenzar.Size = new System.Drawing.Size(87, 23);
            this.BtComenzar.TabIndex = 9;
            this.BtComenzar.Text = "Comenzar";
            this.BtComenzar.UseVisualStyleBackColor = true;
            this.BtComenzar.Click += new System.EventHandler(this.BtComenzar_Click);
            // 
            // LblProbCara
            // 
            this.LblProbCara.AutoSize = true;
            this.LblProbCara.Location = new System.Drawing.Point(404, 154);
            this.LblProbCara.Name = "LblProbCara";
            this.LblProbCara.Size = new System.Drawing.Size(109, 13);
            this.LblProbCara.TabIndex = 12;
            this.LblProbCara.Text = "Probabilidad de caras";
            // 
            // LblCruz
            // 
            this.LblCruz.AutoSize = true;
            this.LblCruz.Location = new System.Drawing.Point(259, 154);
            this.LblCruz.Name = "LblCruz";
            this.LblCruz.Size = new System.Drawing.Size(28, 13);
            this.LblCruz.TabIndex = 11;
            this.LblCruz.Text = "Cruz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(409, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Seleccionar la cantidad de veces que desea que se tire la moneda";
            // 
            // lblCaras
            // 
            this.lblCaras.AutoSize = true;
            this.lblCaras.Location = new System.Drawing.Point(131, 154);
            this.lblCaras.Name = "lblCaras";
            this.lblCaras.Size = new System.Drawing.Size(34, 13);
            this.lblCaras.TabIndex = 10;
            this.lblCaras.Text = "Caras";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(923, 794);
            this.Controls.Add(this.txtPercentil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPercentilMuestra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtvarianza);
            this.Controls.Add(this.btnPercentil);
            this.Controls.Add(this.dgw);
            this.Controls.Add(this.txtTipica);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtvarianzaM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtcuadrado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.label4);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "IEFI MATEMÁTICA";
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xixfi;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfi;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi2xfi;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtcuadrado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Modatxt;
        private System.Windows.Forms.TextBox Medianatxt;
        private System.Windows.Forms.TextBox Mediatxt;
        private System.Windows.Forms.Label Moda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btcalcular;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.ListBox ListaNumeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvarianza;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtvarianzaM;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtTipica;
        private System.Windows.Forms.Button btnPercentil;
        private System.Windows.Forms.TextBox txtPercentilMuestra;
        private System.Windows.Forms.TextBox txtPercentil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblProbCruz;
        private System.Windows.Forms.ComboBox CbVeces;
        private System.Windows.Forms.Button BtComenzar;
        private System.Windows.Forms.Label LblProbCara;
        private System.Windows.Forms.Label LblCruz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCaras;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

