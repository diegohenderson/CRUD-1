namespace CRUD
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.txtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.txtStock = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreProd = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.lblPrecio = new MetroFramework.Controls.MetroLabel();
            this.lblStock = new MetroFramework.Controls.MetroLabel();
            this.lblNombreProd = new MetroFramework.Controls.MetroLabel();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.btBrowser = new MetroFramework.Controls.MetroButton();
            this.FotoProducto = new System.Windows.Forms.PictureBox();
            this.btAgregar = new MetroFramework.Controls.MetroButton();
            this.btEditar = new MetroFramework.Controls.MetroButton();
            this.BtBorrar = new MetroFramework.Controls.MetroButton();
            this.btCancel = new MetroFramework.Controls.MetroButton();
            this.btGuardar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.metroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.Coral;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.productoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(9, 71);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(691, 559);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MetroGrid1_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CRUD.Clases.Producto);
            // 
            // metroPanel
            // 
            this.metroPanel.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel.Controls.Add(this.txtDescripcion);
            this.metroPanel.Controls.Add(this.lblDescripcion);
            this.metroPanel.Controls.Add(this.txtPrecio);
            this.metroPanel.Controls.Add(this.txtStock);
            this.metroPanel.Controls.Add(this.txtNombreProd);
            this.metroPanel.Controls.Add(this.FotoProducto);
            this.metroPanel.Controls.Add(this.txtID);
            this.metroPanel.Controls.Add(this.lblPrecio);
            this.metroPanel.Controls.Add(this.lblStock);
            this.metroPanel.Controls.Add(this.lblNombreProd);
            this.metroPanel.Controls.Add(this.lblID);
            this.metroPanel.Controls.Add(this.btBrowser);
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(709, 71);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(402, 240);
            this.metroPanel.TabIndex = 1;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.CustomButton.Image = null;
            this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(59, 2);
            this.txtDescripcion.CustomButton.Name = "";
            this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(47, 47);
            this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcion.CustomButton.TabIndex = 1;
            this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcion.CustomButton.UseSelectable = true;
            this.txtDescripcion.CustomButton.Visible = false;
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(278, 124);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(109, 52);
            this.txtDescripcion.TabIndex = 14;
            this.txtDescripcion.UseSelectable = true;
            this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(176, 136);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 20);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtPrecio
            // 
            // 
            // 
            // 
            this.txtPrecio.CustomButton.Image = null;
            this.txtPrecio.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.txtPrecio.CustomButton.Name = "";
            this.txtPrecio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecio.CustomButton.TabIndex = 1;
            this.txtPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecio.CustomButton.UseSelectable = true;
            this.txtPrecio.CustomButton.Visible = false;
            this.txtPrecio.Lines = new string[0];
            this.txtPrecio.Location = new System.Drawing.Point(278, 95);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.ShortcutsEnabled = true;
            this.txtPrecio.Size = new System.Drawing.Size(109, 23);
            this.txtPrecio.TabIndex = 12;
            this.txtPrecio.UseSelectable = true;
            this.txtPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStock
            // 
            // 
            // 
            // 
            this.txtStock.CustomButton.Image = null;
            this.txtStock.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.txtStock.CustomButton.Name = "";
            this.txtStock.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStock.CustomButton.TabIndex = 1;
            this.txtStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStock.CustomButton.UseSelectable = true;
            this.txtStock.CustomButton.Visible = false;
            this.txtStock.Lines = new string[0];
            this.txtStock.Location = new System.Drawing.Point(278, 67);
            this.txtStock.MaxLength = 32767;
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStock.SelectedText = "";
            this.txtStock.SelectionLength = 0;
            this.txtStock.SelectionStart = 0;
            this.txtStock.ShortcutsEnabled = true;
            this.txtStock.Size = new System.Drawing.Size(109, 23);
            this.txtStock.TabIndex = 11;
            this.txtStock.UseSelectable = true;
            this.txtStock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombreProd
            // 
            // 
            // 
            // 
            this.txtNombreProd.CustomButton.Image = null;
            this.txtNombreProd.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.txtNombreProd.CustomButton.Name = "";
            this.txtNombreProd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreProd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreProd.CustomButton.TabIndex = 1;
            this.txtNombreProd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreProd.CustomButton.UseSelectable = true;
            this.txtNombreProd.CustomButton.Visible = false;
            this.txtNombreProd.Lines = new string[0];
            this.txtNombreProd.Location = new System.Drawing.Point(278, 38);
            this.txtNombreProd.MaxLength = 32767;
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.PasswordChar = '\0';
            this.txtNombreProd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreProd.SelectedText = "";
            this.txtNombreProd.SelectionLength = 0;
            this.txtNombreProd.SelectionStart = 0;
            this.txtNombreProd.ShortcutsEnabled = true;
            this.txtNombreProd.Size = new System.Drawing.Size(109, 23);
            this.txtNombreProd.TabIndex = 10;
            this.txtNombreProd.UseSelectable = true;
            this.txtNombreProd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreProd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "ID", true));
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(278, 9);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(109, 23);
            this.txtID.TabIndex = 9;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(176, 98);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 20);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(176, 70);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(42, 20);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stock";
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Location = new System.Drawing.Point(176, 38);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(61, 20);
            this.lblNombreProd.TabIndex = 6;
            this.lblNombreProd.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(176, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 20);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID";
            // 
            // btBrowser
            // 
            this.btBrowser.Location = new System.Drawing.Point(18, 162);
            this.btBrowser.Name = "btBrowser";
            this.btBrowser.Size = new System.Drawing.Size(75, 23);
            this.btBrowser.TabIndex = 3;
            this.btBrowser.Text = "Browser";
            this.btBrowser.UseSelectable = true;
            this.btBrowser.Click += new System.EventHandler(this.BtBrowser_Click);
            // 
            // FotoProducto
            // 
            this.FotoProducto.Location = new System.Drawing.Point(7, 9);
            this.FotoProducto.Name = "FotoProducto";
            this.FotoProducto.Size = new System.Drawing.Size(152, 139);
            this.FotoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoProducto.TabIndex = 2;
            this.FotoProducto.TabStop = false;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btAgregar.Location = new System.Drawing.Point(706, 340);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 2;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseSelectable = true;
            this.btAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(793, 340);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 3;
            this.btEditar.Text = "Editar";
            this.btEditar.UseSelectable = true;
            this.btEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // BtBorrar
            // 
            this.BtBorrar.Location = new System.Drawing.Point(976, 340);
            this.BtBorrar.Name = "BtBorrar";
            this.BtBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtBorrar.TabIndex = 4;
            this.BtBorrar.Text = "Borrar";
            this.BtBorrar.UseSelectable = true;
            this.BtBorrar.Click += new System.EventHandler(this.BtBorrar_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(1057, 340);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(71, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseSelectable = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(881, 340);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "guardar";
            this.btGuardar.UseSelectable = true;
            this.btGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 631);
            this.Controls.Add(this.metroPanel);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.BtBorrar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.metroGrid1);
            this.Name = "Form1";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.metroPanel.ResumeLayout(false);
            this.metroPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroPanel metroPanel;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroTextBox txtPrecio;
        private MetroFramework.Controls.MetroTextBox txtStock;
        private MetroFramework.Controls.MetroTextBox txtNombreProd;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroLabel lblPrecio;
        private MetroFramework.Controls.MetroLabel lblStock;
        private MetroFramework.Controls.MetroLabel lblNombreProd;
        private MetroFramework.Controls.MetroLabel lblID;
        private MetroFramework.Controls.MetroButton btBrowser;
        private System.Windows.Forms.PictureBox FotoProducto;
        private MetroFramework.Controls.MetroButton btAgregar;
        private MetroFramework.Controls.MetroButton btEditar;
        private MetroFramework.Controls.MetroButton BtBorrar;
        private MetroFramework.Controls.MetroButton btCancel;
        private MetroFramework.Controls.MetroButton btGuardar;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}

