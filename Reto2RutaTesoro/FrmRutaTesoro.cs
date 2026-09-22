using System;
using System.Windows.Forms;

namespace TreasureRoute
{
  public partial class TreasureRouteForm : Form
  {
    // Single instance of the data structure. All real route data
    // lives here, never in the form controls.
    private readonly ListaSimple _ruta;

    // Currently selected Id in the DataGridView (null if none).
    private int? _idSeleccionado;

    public TreasureRouteForm()
    {
      InitializeComponent();
      _ruta = new ListaSimple();
      LoadSampleData();
      UpdateGrid();
    }

    /// <summary>
    /// Loads some sample locations so the challenge can be tried immediately.
    /// </summary>
    private void LoadSampleData()
    {
      _ruta.Insertar(new Nodo(1, "Shipwreck Beach", "Where the sun kisses the broken sand", 5, null));
      _ruta.Insertar(new Nodo(2, "Kraken Cave", "Listen for the echo before entering", 9, null));
      _ruta.Insertar(new Nodo(3, "Skull Island", "Two empty eyes gaze to the north", 7, null));
      _ruta.Insertar(new Nodo(4, "Lost Temple", "Gold sleeps beneath the last stone", 8, null));
    }

    // --------------------------------------------------------------
    // Botón Agregar -> ListaSimple.Insertar(id) -> Actualizar DataGridView
    // --------------------------------------------------------------
    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (!ValidateInput(out int id, out string nombre, out string pista, out int peligro))
      {
        return;
      }

      Nodo nuevoNodo = new Nodo(id, nombre, pista, peligro, null);
      bool agregado = _ruta.Insertar(nuevoNodo);

      if (!agregado)
      {
        MessageBox.Show($"A location with ID {id} already exists. Use another ID or modify the existing one.",
          "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      UpdateGrid();
      ClearFields();
      MessageBox.Show("Location added to the treasure route.", "Success",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // --------------------------------------------------------------
    // Botón Buscar -> ListaSimple.Buscar(id) -> Mostrar resultado
    // --------------------------------------------------------------
    private void btnSearch_Click(object sender, EventArgs e)
    {
      int id = (int)nudId.Value;
      Nodo? nodo = _ruta.Buscar(id);

      if (nodo == null)
      {
        MessageBox.Show($"No location with ID {id} exists.", "Not found",
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      txtNombre.Text = nodo.Nombre;
      txtPista.Text = nodo.Pista;
      nudPeligro.Value = nodo.NivelPeligro;
      _idSeleccionado = nodo.Id;

      MessageBox.Show(nodo.ToString(), "Location found",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // --------------------------------------------------------------
    // Botón Modificar -> ListaSimple.Modificar(id) -> Actualizar DataGridView
    // --------------------------------------------------------------
    private void btnModify_Click(object sender, EventArgs e)
    {
      if (!ValidateInput(out int id, out string nombre, out string pista, out int peligro))
      {
        return;
      }

      bool modificado = _ruta.Modificar(id, nombre, pista, peligro);

      if (!modificado)
      {
        MessageBox.Show($"No location with ID {id} exists to modify.",
          "Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      UpdateGrid();
      ClearFields();
      MessageBox.Show("Location successfully modified.", "Success",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // --------------------------------------------------------------
    // Botón Eliminar -> ListaSimple.Eliminar(id) -> Actualizar DataGridView
    // --------------------------------------------------------------
    private void btnDelete_Click(object sender, EventArgs e)
    {
      int id = (int)nudId.Value;

      DialogResult confirmacion = MessageBox.Show(
        $"Are you sure you want to delete the location with ID {id} from the route?",
        "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (confirmacion != DialogResult.Yes)
      {
        return;
      }

      bool eliminado = _ruta.Eliminar(id);

      if (!eliminado)
      {
        MessageBox.Show($"No location with ID {id} exists to delete.",
          "Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      UpdateGrid();
      ClearFields();
      MessageBox.Show("Location removed from the route.", "Success",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // --------------------------------------------------------------
    // Botón Limpiar -> Solo limpia los campos de captura (no la lista)
    // --------------------------------------------------------------
    private void btnClear_Click(object sender, EventArgs e)
    {
      ClearFields();
    }

    // --------------------------------------------------------------
    // Selección de fila en el DataGridView -> carga los datos en los campos
    // --------------------------------------------------------------
    private void dgvRoute_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
      {
        return;
      }

      DataGridViewRow fila = dgvRuta.Rows[e.RowIndex];
      int id = Convert.ToInt32(fila.Cells[colId.Index].Value);

      Nodo? nodo = _ruta.Buscar(id);
      if (nodo == null)
      {
        return;
      }

      nudId.Value = nodo.Id;
      txtNombre.Text = nodo.Nombre;
      txtPista.Text = nodo.Pista;
      nudPeligro.Value = nodo.NivelPeligro;
      _idSeleccionado = nodo.Id;
    }

    // --------------------------------------------------------------
    // Métodos de apoyo
    // --------------------------------------------------------------

    /// <summary>
    /// Recorre la lista enlazada desde Inicio hasta NULL y redibuja el DataGridView.
    /// El grid es solo una vista; jamás se usa como almacenamiento.
    /// </summary>
    private void UpdateGrid()
    {
      dgvRuta.Rows.Clear();

      foreach (Nodo nodo in _ruta.Recorrer())
      {
        dgvRuta.Rows.Add(nodo.Id, nodo.Nombre, nodo.Pista, nodo.NivelPeligro);
      }

      lblContador.Text = $"Nodes in route: {_ruta.Contar()}";
    }

    private void ClearFields()
    {
      nudId.Value = nudId.Minimum;
      txtNombre.Clear();
      txtPista.Clear();
      nudPeligro.Value = nudPeligro.Minimum;
      _idSeleccionado = null;
      txtNombre.Focus();
    }

    /// <summary>
    /// Valida los campos capturados en el formulario antes de enviarlos a ListaSimple.
    /// </summary>
    private bool ValidateInput(out int id, out string nombre, out string pista, out int peligro)
    {
      id = (int)nudId.Value;
      nombre = txtNombre.Text.Trim();
      pista = txtPista.Text.Trim();
      peligro = (int)nudPeligro.Value;

      if (string.IsNullOrWhiteSpace(nombre))
      {
        MessageBox.Show("Location name is required.", "Incomplete data",
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtNombre.Focus();
        return false;
      }

      if (string.IsNullOrWhiteSpace(pista))
      {
        MessageBox.Show("Location hint is required.", "Incomplete data",
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtPista.Focus();
        return false;
      }

      if (peligro < 1 || peligro > 10)
      {
        MessageBox.Show("Danger level must be between 1 and 10.", "Incomplete data",
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        nudPeligro.Focus();
        return false;
      }

      return true;
    }
  }
}
