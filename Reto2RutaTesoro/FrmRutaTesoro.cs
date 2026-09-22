using System;
using System.Windows.Forms;

namespace Reto2RutaTesoro
{
  public partial class FrmRutaTesoro : Form
  {
    // Única instancia de la estructura de datos. Toda la información real
    // de la ruta del tesoro vive aquí, nunca en los controles del formulario.
    private readonly ListaSimple _ruta;

    // Id actualmente seleccionado en el DataGridView (null si no hay selección).
    private int? _idSeleccionado;

    public FrmRutaTesoro()
    {
      InitializeComponent();
      _ruta = new ListaSimple();
      CargarDatosDemo();
      ActualizarGrid();
    }

    /// <summary>
    /// Carga algunas ubicaciones de ejemplo para que el reto se pueda probar de inmediato.
    /// </summary>
    private void CargarDatosDemo()
    {
      _ruta.Insertar(new Nodo(1, "Playa del Naufragio", "Donde el sol besa la arena rota", 5, null));
      _ruta.Insertar(new Nodo(2, "Cueva del Kraken", "Escucha el eco antes de entrar", 9, null));
      _ruta.Insertar(new Nodo(3, "Isla Calavera", "Dos ojos vacíos miran al norte", 7, null));
      _ruta.Insertar(new Nodo(4, "Templo Perdido", "El oro duerme bajo la última piedra", 8, null));
    }

    // --------------------------------------------------------------
    // Botón Agregar -> ListaSimple.Insertar(id) -> Actualizar DataGridView
    // --------------------------------------------------------------
    private void btnAgregar_Click(object sender, EventArgs e)
    {
      if (!ValidarEntrada(out int id, out string nombre, out string pista, out int peligro))
      {
        return;
      }

      Nodo nuevoNodo = new Nodo(id, nombre, pista, peligro, null);
      bool agregado = _ruta.Insertar(nuevoNodo);

      if (!agregado)
      {
        MessageBox.Show($"Ya existe una ubicación con el ID {id}. Usa otro ID o modifica la existente.",
          "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      ActualizarGrid();
      LimpiarCampos();
      MessageBox.Show("Ubicación agregada a la ruta del tesoro.", "Éxito",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // --------------------------------------------------------------
    // Botón Buscar -> ListaSimple.Buscar(id) -> Mostrar resultado
    // --------------------------------------------------------------
    private void btnBuscar_Click(object sender, EventArgs e)
    {
      int id = (int)nudId.Value;
      Nodo? nodo = _ruta.Buscar(id);

      if (nodo == null)
      {
        MessageBox.Show($"No existe ninguna ubicación con el ID {id}.", "No encontrado",
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      txtNombre.Text = nodo.Nombre;
      txtPista.Text = nodo.Pista;
      nudPeligro.Value = nodo.NivelPeligro;
      _idSeleccionado = nodo.Id;

      MessageBox.Show(nodo.ToString(), "Ubicación encontrada",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // --------------------------------------------------------------
    // Botón Modificar -> ListaSimple.Modificar(id) -> Actualizar DataGridView
    // --------------------------------------------------------------
    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (!ValidarEntrada(out int id, out string nombre, out string pista, out int peligro))
      {
        return;
      }

      bool modificado = _ruta.Modificar(id, nombre, pista, peligro);

      if (!modificado)
      {
        MessageBox.Show($"No existe ninguna ubicación con el ID {id} para modificar.",
          "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      ActualizarGrid();
      LimpiarCampos();
      MessageBox.Show("Ubicación modificada correctamente.", "Éxito",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // --------------------------------------------------------------
    // Botón Eliminar -> ListaSimple.Eliminar(id) -> Actualizar DataGridView
    // --------------------------------------------------------------
    private void btnEliminar_Click(object sender, EventArgs e)
    {
      int id = (int)nudId.Value;

      DialogResult confirmacion = MessageBox.Show(
        $"¿Seguro que deseas eliminar la ubicación con ID {id} de la ruta?",
        "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (confirmacion != DialogResult.Yes)
      {
        return;
      }

      bool eliminado = _ruta.Eliminar(id);

      if (!eliminado)
      {
        MessageBox.Show($"No existe ninguna ubicación con el ID {id} para eliminar.",
          "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      ActualizarGrid();
      LimpiarCampos();
      MessageBox.Show("Ubicación eliminada de la ruta.", "Éxito",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // --------------------------------------------------------------
    // Botón Limpiar -> Solo limpia los campos de captura (no la lista)
    // --------------------------------------------------------------
    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      LimpiarCampos();
    }

    // --------------------------------------------------------------
    // Selección de fila en el DataGridView -> carga los datos en los campos
    // --------------------------------------------------------------
    private void dgvRuta_CellClick(object sender, DataGridViewCellEventArgs e)
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
    private void ActualizarGrid()
    {
      dgvRuta.Rows.Clear();

      foreach (Nodo nodo in _ruta.Recorrer())
      {
        dgvRuta.Rows.Add(nodo.Id, nodo.Nombre, nodo.Pista, nodo.NivelPeligro);
      }

      lblContador.Text = $"Nodos en la ruta: {_ruta.Contar()}";
    }

    private void LimpiarCampos()
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
    private bool ValidarEntrada(out int id, out string nombre, out string pista, out int peligro)
    {
      id = (int)nudId.Value;
      nombre = txtNombre.Text.Trim();
      pista = txtPista.Text.Trim();
      peligro = (int)nudPeligro.Value;

      if (string.IsNullOrWhiteSpace(nombre))
      {
        MessageBox.Show("El nombre de la ubicación es obligatorio.", "Datos incompletos",
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtNombre.Focus();
        return false;
      }

      if (string.IsNullOrWhiteSpace(pista))
      {
        MessageBox.Show("La pista de la ubicación es obligatoria.", "Datos incompletos",
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtPista.Focus();
        return false;
      }

      if (peligro < 1 || peligro > 10)
      {
        MessageBox.Show("El nivel de peligro debe estar entre 1 y 10.", "Datos incompletos",
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        nudPeligro.Focus();
        return false;
      }

      return true;
    }
  }
}
