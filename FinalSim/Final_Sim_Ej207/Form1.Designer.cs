namespace Final_Sim_Ej267
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
            this.lbl_CantSim = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_CantSim = new System.Windows.Forms.TextBox();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.dtgvTabla = new System.Windows.Forms.DataGridView();
            this.NroFila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpoEntreLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_ServirCerveza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpoServirCerveza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finServirCerveza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpoLavado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finLavadoVaso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_VasosARecoger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vasosARecoger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpoRecogida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finRecogidaVasos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_TomarCerveza1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_TomarCerveza2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpoTomarCerveza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finTomarCerveza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finTomarCervezaDefinitivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finEsperaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCantinero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaCantinero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vasosLimpios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vasosSucios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vasosRecoger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vasosUtilizados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantClientesRetirados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantClientesEsperandoRetirados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantTotalClientesRetirados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esperaMaxTomar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantClientesTomaron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEsperaCerveza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promEsperaTomar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.lbl_clientesRetiradosSinConsumir1 = new System.Windows.Forms.Label();
            this.txt_ClientesRetiradosSinConsumir = new System.Windows.Forms.TextBox();
            this.gbx_rango = new System.Windows.Forms.GroupBox();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.gbx_Estadisticas = new System.Windows.Forms.GroupBox();
            this.lbl_PromEsperaCerveza2 = new System.Windows.Forms.Label();
            this.lbl_PromEsperaCerveza1 = new System.Windows.Forms.Label();
            this.lbl_EsperaMaxCerveza = new System.Windows.Forms.Label();
            this.txt_PromEsperaCerveza = new System.Windows.Forms.TextBox();
            this.txt_EsperaMaxCerveza = new System.Windows.Forms.TextBox();
            this.lbl_clientesEsperaSinConsumir1 = new System.Windows.Forms.Label();
            this.txt_ClientesEsperaSinConsumir = new System.Windows.Forms.TextBox();
            this.lbl_clientesEsperaSinConsumir2 = new System.Windows.Forms.Label();
            this.lbl_clientesRetiradosSinConsumir2 = new System.Windows.Forms.Label();
            this.gbx_Clientes = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).BeginInit();
            this.gbx_rango.SuspendLayout();
            this.gbx_Estadisticas.SuspendLayout();
            this.gbx_Clientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CantSim
            // 
            this.lbl_CantSim.AutoSize = true;
            this.lbl_CantSim.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_CantSim.Location = new System.Drawing.Point(3, 39);
            this.lbl_CantSim.Name = "lbl_CantSim";
            this.lbl_CantSim.Size = new System.Drawing.Size(165, 17);
            this.lbl_CantSim.TabIndex = 1;
            this.lbl_CantSim.Text = "Cantidad de Simulaciones: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // txt_CantSim
            // 
            this.txt_CantSim.Location = new System.Drawing.Point(165, 37);
            this.txt_CantSim.Name = "txt_CantSim";
            this.txt_CantSim.Size = new System.Drawing.Size(96, 25);
            this.txt_CantSim.TabIndex = 3;
            this.txt_CantSim.TextChanged += new System.EventHandler(this.txt_CantSim_TextChanged);
            this.txt_CantSim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clientes_KeyPress_1);
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(74, 39);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(100, 25);
            this.txt_desde.TabIndex = 4;
            this.txt_desde.TextChanged += new System.EventHandler(this.txt_desde_TextChanged);
            this.txt_desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_desde_KeyPress);
            // 
            // dtgvTabla
            // 
            this.dtgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroFila,
            this.evento,
            this.reloj,
            this.rnd_cliente,
            this.tpoEntreLlegada,
            this.proxLlegada,
            this.rnd_ServirCerveza,
            this.tpoServirCerveza,
            this.finServirCerveza,
            this.tpoLavado,
            this.finLavadoVaso,
            this.rnd_VasosARecoger,
            this.vasosARecoger,
            this.tpoRecogida,
            this.finRecogidaVasos,
            this.rnd_TomarCerveza1,
            this.rnd_TomarCerveza2,
            this.tpoTomarCerveza,
            this.finTomarCerveza,
            this.finTomarCervezaDefinitivo,
            this.finEsperaCliente,
            this.estadoCantinero,
            this.colaCantinero,
            this.vasosLimpios,
            this.vasosSucios,
            this.vasosRecoger,
            this.vasosUtilizados,
            this.cantClientesRetirados,
            this.cantClientesEsperandoRetirados,
            this.cantTotalClientesRetirados,
            this.esperaMaxTomar,
            this.cantClientesTomaron,
            this.totalEsperaCerveza,
            this.promEsperaTomar});
            this.dtgvTabla.Location = new System.Drawing.Point(15, 147);
            this.dtgvTabla.Name = "dtgvTabla";
            this.dtgvTabla.Size = new System.Drawing.Size(993, 390);
            this.dtgvTabla.TabIndex = 5;
            // 
            // NroFila
            // 
            this.NroFila.HeaderText = "Numero Fila";
            this.NroFila.Name = "NroFila";
            // 
            // evento
            // 
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            // 
            // reloj
            // 
            this.reloj.HeaderText = "Reloj (minutos)";
            this.reloj.Name = "reloj";
            // 
            // rnd_cliente
            // 
            this.rnd_cliente.HeaderText = "RND Llegada cliente";
            this.rnd_cliente.Name = "rnd_cliente";
            // 
            // tpoEntreLlegada
            // 
            this.tpoEntreLlegada.HeaderText = "Tiempo entre llegadas";
            this.tpoEntreLlegada.Name = "tpoEntreLlegada";
            // 
            // proxLlegada
            // 
            this.proxLlegada.HeaderText = "Próxima llegada";
            this.proxLlegada.Name = "proxLlegada";
            // 
            // rnd_ServirCerveza
            // 
            this.rnd_ServirCerveza.HeaderText = "RND Servir Cerveza";
            this.rnd_ServirCerveza.Name = "rnd_ServirCerveza";
            // 
            // tpoServirCerveza
            // 
            this.tpoServirCerveza.HeaderText = "Tiempo para servir";
            this.tpoServirCerveza.Name = "tpoServirCerveza";
            // 
            // finServirCerveza
            // 
            this.finServirCerveza.HeaderText = "Fin servir cerveza";
            this.finServirCerveza.Name = "finServirCerveza";
            // 
            // tpoLavado
            // 
            this.tpoLavado.HeaderText = "Tiempo de lavado";
            this.tpoLavado.Name = "tpoLavado";
            // 
            // finLavadoVaso
            // 
            this.finLavadoVaso.HeaderText = "Fin Lavado vaso";
            this.finLavadoVaso.Name = "finLavadoVaso";
            // 
            // rnd_VasosARecoger
            // 
            this.rnd_VasosARecoger.HeaderText = "RND Vasos a recoger";
            this.rnd_VasosARecoger.Name = "rnd_VasosARecoger";
            // 
            // vasosARecoger
            // 
            this.vasosARecoger.HeaderText = "Vasos A Recoger";
            this.vasosARecoger.Name = "vasosARecoger";
            // 
            // tpoRecogida
            // 
            this.tpoRecogida.HeaderText = "Tiempo recogida vasos";
            this.tpoRecogida.Name = "tpoRecogida";
            // 
            // finRecogidaVasos
            // 
            this.finRecogidaVasos.HeaderText = "Fin Recogida vasos";
            this.finRecogidaVasos.Name = "finRecogidaVasos";
            // 
            // rnd_TomarCerveza1
            // 
            this.rnd_TomarCerveza1.HeaderText = "RND1 Tomar cerveza";
            this.rnd_TomarCerveza1.Name = "rnd_TomarCerveza1";
            // 
            // rnd_TomarCerveza2
            // 
            this.rnd_TomarCerveza2.HeaderText = "RND2 Tomar Cerveza";
            this.rnd_TomarCerveza2.Name = "rnd_TomarCerveza2";
            // 
            // tpoTomarCerveza
            // 
            this.tpoTomarCerveza.HeaderText = "Tiempo tomar cerveza";
            this.tpoTomarCerveza.Name = "tpoTomarCerveza";
            // 
            // finTomarCerveza
            // 
            this.finTomarCerveza.HeaderText = "Fin Tomar cerveza";
            this.finTomarCerveza.Name = "finTomarCerveza";
            // 
            // finTomarCervezaDefinitivo
            // 
            this.finTomarCervezaDefinitivo.HeaderText = "Fin Tomar Cerveza Definitivo";
            this.finTomarCervezaDefinitivo.Name = "finTomarCervezaDefinitivo";
            // 
            // finEsperaCliente
            // 
            this.finEsperaCliente.HeaderText = "Fin Retiro por Espera";
            this.finEsperaCliente.Name = "finEsperaCliente";
            // 
            // estadoCantinero
            // 
            this.estadoCantinero.HeaderText = "Estado Cantinero";
            this.estadoCantinero.Name = "estadoCantinero";
            // 
            // colaCantinero
            // 
            this.colaCantinero.HeaderText = "Cola Cervecería";
            this.colaCantinero.Name = "colaCantinero";
            // 
            // vasosLimpios
            // 
            this.vasosLimpios.HeaderText = "Vasos Limpios";
            this.vasosLimpios.Name = "vasosLimpios";
            // 
            // vasosSucios
            // 
            this.vasosSucios.HeaderText = "Vasos Sucios";
            this.vasosSucios.Name = "vasosSucios";
            // 
            // vasosRecoger
            // 
            this.vasosRecoger.HeaderText = "Vasos a Recoger";
            this.vasosRecoger.Name = "vasosRecoger";
            // 
            // vasosUtilizados
            // 
            this.vasosUtilizados.HeaderText = "Vasos siendo Utilizados";
            this.vasosUtilizados.Name = "vasosUtilizados";
            // 
            // cantClientesRetirados
            // 
            this.cantClientesRetirados.HeaderText = "Cant. clientes retirados";
            this.cantClientesRetirados.Name = "cantClientesRetirados";
            // 
            // cantClientesEsperandoRetirados
            // 
            this.cantClientesEsperandoRetirados.HeaderText = "Cant. clientes esperando y retirados s/c";
            this.cantClientesEsperandoRetirados.Name = "cantClientesEsperandoRetirados";
            // 
            // cantTotalClientesRetirados
            // 
            this.cantTotalClientesRetirados.HeaderText = "Cant. clientes retirados s/c";
            this.cantTotalClientesRetirados.Name = "cantTotalClientesRetirados";
            // 
            // esperaMaxTomar
            // 
            this.esperaMaxTomar.HeaderText = "Espera máxima para tomar";
            this.esperaMaxTomar.Name = "esperaMaxTomar";
            // 
            // cantClientesTomaron
            // 
            this.cantClientesTomaron.HeaderText = "Cant. clientes que tomaron";
            this.cantClientesTomaron.Name = "cantClientesTomaron";
            // 
            // totalEsperaCerveza
            // 
            this.totalEsperaCerveza.HeaderText = "Total espera para tomar";
            this.totalEsperaCerveza.Name = "totalEsperaCerveza";
            // 
            // promEsperaTomar
            // 
            this.promEsperaTomar.HeaderText = "Prom. espera para tomar";
            this.promEsperaTomar.Name = "promEsperaTomar";
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.Location = new System.Drawing.Point(40, 70);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(187, 38);
            this.btn_Inicio.TabIndex = 6;
            this.btn_Inicio.Text = "Iniciar Simulación";
            this.btn_Inicio.UseVisualStyleBackColor = true;
            this.btn_Inicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lbl_clientesRetiradosSinConsumir1
            // 
            this.lbl_clientesRetiradosSinConsumir1.AutoSize = true;
            this.lbl_clientesRetiradosSinConsumir1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_clientesRetiradosSinConsumir1.Location = new System.Drawing.Point(759, 53);
            this.lbl_clientesRetiradosSinConsumir1.Name = "lbl_clientesRetiradosSinConsumir1";
            this.lbl_clientesRetiradosSinConsumir1.Size = new System.Drawing.Size(160, 17);
            this.lbl_clientesRetiradosSinConsumir1.TabIndex = 7;
            this.lbl_clientesRetiradosSinConsumir1.Text = "Cant. de clientes retirados";
            this.lbl_clientesRetiradosSinConsumir1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_ClientesRetiradosSinConsumir
            // 
            this.txt_ClientesRetiradosSinConsumir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_ClientesRetiradosSinConsumir.Location = new System.Drawing.Point(956, 52);
            this.txt_ClientesRetiradosSinConsumir.Name = "txt_ClientesRetiradosSinConsumir";
            this.txt_ClientesRetiradosSinConsumir.Size = new System.Drawing.Size(46, 25);
            this.txt_ClientesRetiradosSinConsumir.TabIndex = 8;
            // 
            // gbx_rango
            // 
            this.gbx_rango.Controls.Add(this.lbl_hasta);
            this.gbx_rango.Controls.Add(this.lbl_desde);
            this.gbx_rango.Controls.Add(this.txt_hasta);
            this.gbx_rango.Controls.Add(this.txt_desde);
            this.gbx_rango.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbx_rango.Location = new System.Drawing.Point(15, 27);
            this.gbx_rango.Name = "gbx_rango";
            this.gbx_rango.Size = new System.Drawing.Size(187, 114);
            this.gbx_rango.TabIndex = 11;
            this.gbx_rango.TabStop = false;
            this.gbx_rango.Text = "Rango a mostrar";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_hasta.Location = new System.Drawing.Point(14, 73);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(44, 17);
            this.lbl_hasta.TabIndex = 14;
            this.lbl_hasta.Text = "Hasta:";
            this.lbl_hasta.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_desde.Location = new System.Drawing.Point(10, 39);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(48, 17);
            this.lbl_desde.TabIndex = 12;
            this.lbl_desde.Text = "Desde:";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(74, 70);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(100, 25);
            this.txt_hasta.TabIndex = 13;
            this.txt_hasta.TextChanged += new System.EventHandler(this.txt_hasta_TextChanged);
            this.txt_hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hasta_KeyPress);
            // 
            // gbx_Estadisticas
            // 
            this.gbx_Estadisticas.Controls.Add(this.lbl_PromEsperaCerveza2);
            this.gbx_Estadisticas.Controls.Add(this.lbl_PromEsperaCerveza1);
            this.gbx_Estadisticas.Controls.Add(this.lbl_EsperaMaxCerveza);
            this.gbx_Estadisticas.Controls.Add(this.txt_PromEsperaCerveza);
            this.gbx_Estadisticas.Controls.Add(this.txt_EsperaMaxCerveza);
            this.gbx_Estadisticas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbx_Estadisticas.Location = new System.Drawing.Point(500, 27);
            this.gbx_Estadisticas.Name = "gbx_Estadisticas";
            this.gbx_Estadisticas.Size = new System.Drawing.Size(506, 114);
            this.gbx_Estadisticas.TabIndex = 15;
            this.gbx_Estadisticas.TabStop = false;
            this.gbx_Estadisticas.Text = "Estadísticas";
            // 
            // lbl_PromEsperaCerveza2
            // 
            this.lbl_PromEsperaCerveza2.AutoSize = true;
            this.lbl_PromEsperaCerveza2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_PromEsperaCerveza2.Location = new System.Drawing.Point(6, 83);
            this.lbl_PromEsperaCerveza2.Name = "lbl_PromEsperaCerveza2";
            this.lbl_PromEsperaCerveza2.Size = new System.Drawing.Size(52, 17);
            this.lbl_PromEsperaCerveza2.TabIndex = 19;
            this.lbl_PromEsperaCerveza2.Text = "cerveza";
            // 
            // lbl_PromEsperaCerveza1
            // 
            this.lbl_PromEsperaCerveza1.AutoSize = true;
            this.lbl_PromEsperaCerveza1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_PromEsperaCerveza1.Location = new System.Drawing.Point(6, 66);
            this.lbl_PromEsperaCerveza1.Name = "lbl_PromEsperaCerveza1";
            this.lbl_PromEsperaCerveza1.Size = new System.Drawing.Size(156, 17);
            this.lbl_PromEsperaCerveza1.TabIndex = 18;
            this.lbl_PromEsperaCerveza1.Text = "Prom. espera para tomar\r\n";
            // 
            // lbl_EsperaMaxCerveza
            // 
            this.lbl_EsperaMaxCerveza.AutoSize = true;
            this.lbl_EsperaMaxCerveza.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_EsperaMaxCerveza.Location = new System.Drawing.Point(6, 28);
            this.lbl_EsperaMaxCerveza.Name = "lbl_EsperaMaxCerveza";
            this.lbl_EsperaMaxCerveza.Size = new System.Drawing.Size(167, 17);
            this.lbl_EsperaMaxCerveza.TabIndex = 16;
            this.lbl_EsperaMaxCerveza.Text = "Espera máxima para tomar";
            // 
            // txt_PromEsperaCerveza
            // 
            this.txt_PromEsperaCerveza.Location = new System.Drawing.Point(189, 70);
            this.txt_PromEsperaCerveza.Name = "txt_PromEsperaCerveza";
            this.txt_PromEsperaCerveza.Size = new System.Drawing.Size(46, 25);
            this.txt_PromEsperaCerveza.TabIndex = 17;
            // 
            // txt_EsperaMaxCerveza
            // 
            this.txt_EsperaMaxCerveza.Location = new System.Drawing.Point(189, 28);
            this.txt_EsperaMaxCerveza.Name = "txt_EsperaMaxCerveza";
            this.txt_EsperaMaxCerveza.Size = new System.Drawing.Size(46, 25);
            this.txt_EsperaMaxCerveza.TabIndex = 16;
            // 
            // lbl_clientesEsperaSinConsumir1
            // 
            this.lbl_clientesEsperaSinConsumir1.AutoSize = true;
            this.lbl_clientesEsperaSinConsumir1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_clientesEsperaSinConsumir1.Location = new System.Drawing.Point(759, 91);
            this.lbl_clientesEsperaSinConsumir1.Name = "lbl_clientesEsperaSinConsumir1";
            this.lbl_clientesEsperaSinConsumir1.Size = new System.Drawing.Size(193, 17);
            this.lbl_clientesEsperaSinConsumir1.TabIndex = 9;
            this.lbl_clientesEsperaSinConsumir1.Text = "Cant. de clientes que esperaron";
            this.lbl_clientesEsperaSinConsumir1.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_ClientesEsperaSinConsumir
            // 
            this.txt_ClientesEsperaSinConsumir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_ClientesEsperaSinConsumir.Location = new System.Drawing.Point(956, 93);
            this.txt_ClientesEsperaSinConsumir.Name = "txt_ClientesEsperaSinConsumir";
            this.txt_ClientesEsperaSinConsumir.Size = new System.Drawing.Size(46, 25);
            this.txt_ClientesEsperaSinConsumir.TabIndex = 10;
            // 
            // lbl_clientesEsperaSinConsumir2
            // 
            this.lbl_clientesEsperaSinConsumir2.AutoSize = true;
            this.lbl_clientesEsperaSinConsumir2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_clientesEsperaSinConsumir2.Location = new System.Drawing.Point(759, 108);
            this.lbl_clientesEsperaSinConsumir2.Name = "lbl_clientesEsperaSinConsumir2";
            this.lbl_clientesEsperaSinConsumir2.Size = new System.Drawing.Size(150, 17);
            this.lbl_clientesEsperaSinConsumir2.TabIndex = 12;
            this.lbl_clientesEsperaSinConsumir2.Text = "y se fueron sin consumir";
            // 
            // lbl_clientesRetiradosSinConsumir2
            // 
            this.lbl_clientesRetiradosSinConsumir2.AutoSize = true;
            this.lbl_clientesRetiradosSinConsumir2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_clientesRetiradosSinConsumir2.Location = new System.Drawing.Point(756, 68);
            this.lbl_clientesRetiradosSinConsumir2.Name = "lbl_clientesRetiradosSinConsumir2";
            this.lbl_clientesRetiradosSinConsumir2.Size = new System.Drawing.Size(85, 17);
            this.lbl_clientesRetiradosSinConsumir2.TabIndex = 13;
            this.lbl_clientesRetiradosSinConsumir2.Text = " sin consumir";
            // 
            // gbx_Clientes
            // 
            this.gbx_Clientes.Controls.Add(this.txt_CantSim);
            this.gbx_Clientes.Controls.Add(this.lbl_CantSim);
            this.gbx_Clientes.Controls.Add(this.btn_Inicio);
            this.gbx_Clientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Clientes.Location = new System.Drawing.Point(217, 27);
            this.gbx_Clientes.Name = "gbx_Clientes";
            this.gbx_Clientes.Size = new System.Drawing.Size(267, 114);
            this.gbx_Clientes.TabIndex = 52;
            this.gbx_Clientes.TabStop = false;
            this.gbx_Clientes.Text = "Clientes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1020, 560);
            this.Controls.Add(this.lbl_clientesRetiradosSinConsumir2);
            this.Controls.Add(this.lbl_clientesEsperaSinConsumir2);
            this.Controls.Add(this.txt_ClientesEsperaSinConsumir);
            this.Controls.Add(this.lbl_clientesEsperaSinConsumir1);
            this.Controls.Add(this.txt_ClientesRetiradosSinConsumir);
            this.Controls.Add(this.lbl_clientesRetiradosSinConsumir1);
            this.Controls.Add(this.dtgvTabla);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbx_rango);
            this.Controls.Add(this.gbx_Estadisticas);
            this.Controls.Add(this.gbx_Clientes);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Final Simulación Ej. 267";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).EndInit();
            this.gbx_rango.ResumeLayout(false);
            this.gbx_rango.PerformLayout();
            this.gbx_Estadisticas.ResumeLayout(false);
            this.gbx_Estadisticas.PerformLayout();
            this.gbx_Clientes.ResumeLayout(false);
            this.gbx_Clientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCantidadSimulaciones;
        private System.Windows.Forms.Label lbl_CantSim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_CantSim;
        private System.Windows.Forms.TextBox txt_desde;
        private System.Windows.Forms.DataGridView dtgvTabla;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Label lbl_clientesRetiradosSinConsumir1;
        private System.Windows.Forms.TextBox txt_ClientesRetiradosSinConsumir;
        private System.Windows.Forms.GroupBox gbx_rango;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.GroupBox gbx_Estadisticas;
        private System.Windows.Forms.TextBox txt_PromEsperaCerveza;
        private System.Windows.Forms.TextBox txt_EsperaMaxCerveza;
        private System.Windows.Forms.Label lbl_PromEsperaCerveza1;
        private System.Windows.Forms.Label lbl_EsperaMaxCerveza;
        private System.Windows.Forms.Label lbl_clientesEsperaSinConsumir1;
        private System.Windows.Forms.TextBox txt_ClientesEsperaSinConsumir;
        private System.Windows.Forms.Label lbl_clientesEsperaSinConsumir2;
        private System.Windows.Forms.Label lbl_clientesRetiradosSinConsumir2;
        private System.Windows.Forms.GroupBox gbx_Clientes;
        private System.Windows.Forms.Label lbl_PromEsperaCerveza2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroFila;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpoEntreLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_ServirCerveza;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpoServirCerveza;
        private System.Windows.Forms.DataGridViewTextBoxColumn finServirCerveza;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpoLavado;
        private System.Windows.Forms.DataGridViewTextBoxColumn finLavadoVaso;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_VasosARecoger;
        private System.Windows.Forms.DataGridViewTextBoxColumn vasosARecoger;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpoRecogida;
        private System.Windows.Forms.DataGridViewTextBoxColumn finRecogidaVasos;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_TomarCerveza1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_TomarCerveza2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpoTomarCerveza;
        private System.Windows.Forms.DataGridViewTextBoxColumn finTomarCerveza;
        private System.Windows.Forms.DataGridViewTextBoxColumn finTomarCervezaDefinitivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn finEsperaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCantinero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaCantinero;
        private System.Windows.Forms.DataGridViewTextBoxColumn vasosLimpios;
        private System.Windows.Forms.DataGridViewTextBoxColumn vasosSucios;
        private System.Windows.Forms.DataGridViewTextBoxColumn vasosRecoger;
        private System.Windows.Forms.DataGridViewTextBoxColumn vasosUtilizados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantClientesRetirados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantClientesEsperandoRetirados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantTotalClientesRetirados;
        private System.Windows.Forms.DataGridViewTextBoxColumn esperaMaxTomar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantClientesTomaron;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEsperaCerveza;
        private System.Windows.Forms.DataGridViewTextBoxColumn promEsperaTomar;
    }
}

