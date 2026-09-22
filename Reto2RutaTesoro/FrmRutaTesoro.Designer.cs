namespace TreasureRoute
{
  partial class TreasureRouteForm                   
  {
    /// <summary>
    /// Designer required variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén utilizando.
    /// </summary>
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
      this.pnlTitulo = new System.Windows.Forms.Panel();
      this.lblTitulo = new System.Windows.Forms.Label();
      this.lblSubtitulo = new System.Windows.Forms.Label();
      this.pnlEntrada = new System.Windows.Forms.Panel();
      this.lblId = new System.Windows.Forms.Label();
      this.nudId = new System.Windows.Forms.NumericUpDown();
      this.lblNombre = new System.Windows.Forms.Label();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.lblPista = new System.Windows.Forms.Label();
      this.txtPista = new System.Windows.Forms.TextBox();
      this.lblPeligro = new System.Windows.Forms.Label();
      this.nudPeligro = new System.Windows.Forms.NumericUpDown();
      this.btnAgregar = new System.Windows.Forms.Button();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.btnModificar = new System.Windows.Forms.Button();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.btnLimpiar = new System.Windows.Forms.Button();
      this.dgvRuta = new System.Windows.Forms.DataGridView();
      this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colPista = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colPeligro = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pnlPie = new System.Windows.Forms.Panel();
      this.lblContador = new System.Windows.Forms.Label();
      this.pnlTitulo.SuspendLayout();
      this.pnlEntrada.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudPeligro)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvRuta)).BeginInit();
      this.pnlPie.SuspendLayout();
      this.SuspendLayout();
      //
      // pnlTitulo
      //
      this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
      this.pnlTitulo.Controls.Add(this.lblSubtitulo);
      this.pnlTitulo.Controls.Add(this.lblTitulo);
      this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
      this.pnlTitulo.Name = "pnlTitulo";
      this.pnlTitulo.Size = new System.Drawing.Size(940, 70);
      this.pnlTitulo.TabIndex = 0;
      //
      // lblTitulo
      //
      this.lblTitulo.AutoSize = true;
      this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
      this.lblTitulo.ForeColor = System.Drawing.Color.Gold;
      this.lblTitulo.Location = new System.Drawing.Point(20, 10);
      this.lblTitulo.Name = "lblTitulo";
      this.lblTitulo.Size = new System.Drawing.Size(300, 30);
      this.lblTitulo.TabIndex = 0;
      this.lblTitulo.Text = "🗺️ The Lost Treasure Route";
      //
      // lblSubtitulo
      //
      this.lblSubtitulo.AutoSize = true;
      this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
      this.lblSubtitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.lblSubtitulo.Location = new System.Drawing.Point(23, 44);
      this.lblSubtitulo.Name = "lblSubtitulo";
      this.lblSubtitulo.Size = new System.Drawing.Size(260, 15);
      this.lblSubtitulo.TabIndex = 1;
      this.lblSubtitulo.Text = "Singly linked list built from scratch";
      //
      // pnlEntrada
      //
      this.pnlEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
      this.pnlEntrada.Controls.Add(this.lblId);
      this.pnlEntrada.Controls.Add(this.nudId);
      this.pnlEntrada.Controls.Add(this.lblNombre);
      this.pnlEntrada.Controls.Add(this.txtNombre);
      this.pnlEntrada.Controls.Add(this.lblPista);
      this.pnlEntrada.Controls.Add(this.txtPista);
      this.pnlEntrada.Controls.Add(this.lblPeligro);
      this.pnlEntrada.Controls.Add(this.nudPeligro);
      this.pnlEntrada.Controls.Add(this.btnAgregar);
      this.pnlEntrada.Controls.Add(this.btnBuscar);
      this.pnlEntrada.Controls.Add(this.btnModificar);
      this.pnlEntrada.Controls.Add(this.btnEliminar);
      this.pnlEntrada.Controls.Add(this.btnLimpiar);
      this.pnlEntrada.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlEntrada.Location = new System.Drawing.Point(0, 70);
      this.pnlEntrada.Name = "pnlEntrada";
      this.pnlEntrada.Padding = new System.Windows.Forms.Padding(15);
      this.pnlEntrada.Size = new System.Drawing.Size(940, 175);
      this.pnlEntrada.TabIndex = 1;
      //
      // lblId
      //
      this.lblId.AutoSize = true;
      this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.lblId.Location = new System.Drawing.Point(18, 20);
      this.lblId.Name = "lblId";
      this.lblId.Size = new System.Drawing.Size(84, 15);
      this.lblId.TabIndex = 0;
      this.lblId.Text = "Location ID:";
      //
      // nudId
      //
      this.nudId.Location = new System.Drawing.Point(21, 38);
      this.nudId.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
      this.nudId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
      this.nudId.Name = "nudId";
      this.nudId.Size = new System.Drawing.Size(110, 23);
      this.nudId.TabIndex = 1;
      this.nudId.Value = new decimal(new int[] { 1, 0, 0, 0 });
      //
      // lblNombre
      //
      this.lblNombre.AutoSize = true;
      this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.lblNombre.Location = new System.Drawing.Point(150, 20);
      this.lblNombre.Name = "lblNombre";
      this.lblNombre.Size = new System.Drawing.Size(112, 15);
      this.lblNombre.TabIndex = 2;
      this.lblNombre.Text = "Location Name:";
      //
      // txtNombre
      //
      this.txtNombre.Location = new System.Drawing.Point(153, 38);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(220, 23);
      this.txtNombre.TabIndex = 3;
      //
      // lblPista
      //
      this.lblPista.AutoSize = true;
      this.lblPista.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.lblPista.Location = new System.Drawing.Point(390, 20);
      this.lblPista.Name = "lblPista";
      this.lblPista.Size = new System.Drawing.Size(37, 15);
      this.lblPista.TabIndex = 4;
      this.lblPista.Text = "Hint:";
      //
      // txtPista
      //
      this.txtPista.Location = new System.Drawing.Point(393, 38);
      this.txtPista.Name = "txtPista";
      this.txtPista.Size = new System.Drawing.Size(340, 23);
      this.txtPista.TabIndex = 5;
      //
      // lblPeligro
      //
      this.lblPeligro.AutoSize = true;
      this.lblPeligro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.lblPeligro.Location = new System.Drawing.Point(750, 20);
      this.lblPeligro.Name = "lblPeligro";
      this.lblPeligro.Size = new System.Drawing.Size(107, 15);
      this.lblPeligro.TabIndex = 6;
      this.lblPeligro.Text = "Danger (1-10):";
      //
      // nudPeligro
      //
      this.nudPeligro.Location = new System.Drawing.Point(753, 38);
      this.nudPeligro.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
      this.nudPeligro.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
      this.nudPeligro.Name = "nudPeligro";
      this.nudPeligro.Size = new System.Drawing.Size(110, 23);
      this.nudPeligro.TabIndex = 7;
      this.nudPeligro.Value = new decimal(new int[] { 1, 0, 0, 0 });
      //
      // btnAgregar
      //
      this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
      this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAgregar.ForeColor = System.Drawing.Color.White;
      this.btnAgregar.Location = new System.Drawing.Point(21, 85);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(140, 32);
      this.btnAgregar.TabIndex = 8;
      this.btnAgregar.Text = "➕ Add";
      this.btnAgregar.UseVisualStyleBackColor = false;
      this.btnAgregar.Click += new System.EventHandler(this.btnAdd_Click);
      //
      // btnBuscar
      //
      this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
      this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBuscar.ForeColor = System.Drawing.Color.White;
      this.btnBuscar.Location = new System.Drawing.Point(171, 85);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(140, 32);
      this.btnBuscar.TabIndex = 9;
      this.btnBuscar.Text = "🔍 Search";
      this.btnBuscar.UseVisualStyleBackColor = false;
      this.btnBuscar.Click += new System.EventHandler(this.btnSearch_Click);
      //
      // btnModificar
      //
      this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
      this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnModificar.ForeColor = System.Drawing.Color.White;
      this.btnModificar.Location = new System.Drawing.Point(321, 85);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new System.Drawing.Size(140, 32);
      this.btnModificar.TabIndex = 10;
      this.btnModificar.Text = "✏️ Modify";
      this.btnModificar.UseVisualStyleBackColor = false;
      this.btnModificar.Click += new System.EventHandler(this.btnModify_Click);
      //
      // btnEliminar
      //
      this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEliminar.ForeColor = System.Drawing.Color.White;
      this.btnEliminar.Location = new System.Drawing.Point(471, 85);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(140, 32);
      this.btnEliminar.TabIndex = 11;
      this.btnEliminar.Text = "🗑️ Delete";
      this.btnEliminar.UseVisualStyleBackColor = false;
      this.btnEliminar.Click += new System.EventHandler(this.btnDelete_Click);
      //
      // btnLimpiar
      //
      this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
      this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLimpiar.ForeColor = System.Drawing.Color.White;
      this.btnLimpiar.Location = new System.Drawing.Point(621, 85);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new System.Drawing.Size(140, 32);
      this.btnLimpiar.TabIndex = 12;
      this.btnLimpiar.Text = "🧹 Clear";
      this.btnLimpiar.UseVisualStyleBackColor = false;
      this.btnLimpiar.Click += new System.EventHandler(this.btnClear_Click);
      //
      // dgvRuta
      //
      this.dgvRuta.AllowUserToAddRows = false;
      this.dgvRuta.AllowUserToDeleteRows = false;
      this.dgvRuta.AllowUserToOrderColumns = false;
      this.dgvRuta.BackgroundColor = System.Drawing.Color.White;
      this.dgvRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvRuta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.colId,
        this.colNombre,
        this.colPista,
        this.colPeligro});
      this.dgvRuta.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvRuta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.dgvRuta.Location = new System.Drawing.Point(0, 245);
      this.dgvRuta.MultiSelect = false;
      this.dgvRuta.Name = "dgvRuta";
      this.dgvRuta.ReadOnly = true;
      this.dgvRuta.RowHeadersWidth = 25;
      this.dgvRuta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvRuta.Size = new System.Drawing.Size(940, 315);
      this.dgvRuta.TabIndex = 2;
      this.dgvRuta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoute_CellClick);
      //
      // colId
      //
      this.colId.HeaderText = "ID";
      this.colId.Name = "colId";
      this.colId.ReadOnly = true;
      this.colId.Width = 60;
      //
      // colNombre
      //
      this.colNombre.HeaderText = "Location";
      this.colNombre.Name = "colNombre";
      this.colNombre.ReadOnly = true;
      this.colNombre.Width = 220;
      //
      // colPista
      //
      this.colPista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colPista.HeaderText = "Hint";
      this.colPista.Name = "colPista";
      this.colPista.ReadOnly = true;
      //
      // colPeligro
      //
      this.colPeligro.HeaderText = "Danger";
      this.colPeligro.Name = "colPeligro";
      this.colPeligro.ReadOnly = true;
      this.colPeligro.Width = 80;
      //
      // pnlPie
      //
      this.pnlPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
      this.pnlPie.Controls.Add(this.lblContador);
      this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlPie.Location = new System.Drawing.Point(0, 560);
      this.pnlPie.Name = "pnlPie";
      this.pnlPie.Size = new System.Drawing.Size(940, 32);
      this.pnlPie.TabIndex = 3;
      //
      // lblContador
      //
      this.lblContador.AutoSize = true;
      this.lblContador.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.lblContador.Location = new System.Drawing.Point(15, 8);
      this.lblContador.Name = "lblContador";
      this.lblContador.Size = new System.Drawing.Size(140, 15);
      this.lblContador.TabIndex = 0;
      this.lblContador.Text = "Nodes in route: 0";
      //
      // FrmRutaTesoro
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(940, 592);
      this.Controls.Add(this.dgvRuta);
      this.Controls.Add(this.pnlEntrada);
      this.Controls.Add(this.pnlPie);
      this.Controls.Add(this.pnlTitulo);
      this.MinimumSize = new System.Drawing.Size(880, 500);
      this.Name = "FrmRutaTesoro";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Challenge 2 - The Lost Treasure Route";
      this.pnlTitulo.ResumeLayout(false);
      this.pnlTitulo.PerformLayout();
      this.pnlEntrada.ResumeLayout(false);
      this.pnlEntrada.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudPeligro)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvRuta)).EndInit();
      this.pnlPie.ResumeLayout(false);
      this.pnlPie.PerformLayout();
      this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlTitulo;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblSubtitulo;
    private System.Windows.Forms.Panel pnlEntrada;
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.NumericUpDown nudId;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label lblPista;
    private System.Windows.Forms.TextBox txtPista;
    private System.Windows.Forms.Label lblPeligro;
    private System.Windows.Forms.NumericUpDown nudPeligro;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.Button btnModificar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.DataGridView dgvRuta;
    private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPista;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPeligro;
    private System.Windows.Forms.Panel pnlPie;
    private System.Windows.Forms.Label lblContador;
  }
}
