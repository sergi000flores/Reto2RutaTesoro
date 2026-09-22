using System;
using System.Collections.Generic;

namespace Reto2RutaTesoro
{
  /// <summary>
  /// Lista simplemente enlazada construida completamente desde cero.
  /// No utiliza List&lt;T&gt;, LinkedList&lt;T&gt;, arreglos ni ninguna colección del framework
  /// como mecanismo de almacenamiento; toda la información vive únicamente en los objetos Nodo.
  /// </summary>
  internal class ListaSimple
  {
    public Nodo? Inicio { get; set; }

    public ListaSimple()
    {
      Inicio = null;
    }

    /// <summary>
    /// Inserta un nuevo nodo en la lista, ordenado de forma ascendente por Id.
    /// Si ya existe un nodo con ese Id, no se realiza ninguna acción.
    /// </summary>
    public bool Insertar(Nodo nuevoNodo)
    {
      if (Existe(nuevoNodo.Id))
      {
        return false;
      }

      // Lista vacía: el nuevo nodo se convierte en el inicio
      if (Inicio == null)
      {
        Inicio = nuevoNodo;
        return true;
      }

      // Insertar antes del inicio actual
      if (nuevoNodo.Id < Inicio.Id)
      {
        nuevoNodo.Next = Inicio;
        Inicio = nuevoNodo;
        return true;
      }

      // Buscar la posición correcta para mantener el orden por Id
      Nodo actual = Inicio;
      while (actual.Next != null && actual.Next.Id < nuevoNodo.Id)
      {
        actual = actual.Next;
      }

      nuevoNodo.Next = actual.Next;
      actual.Next = nuevoNodo;
      return true;
    }

    /// <summary>
    /// Elimina el nodo cuyo Id coincide con el proporcionado.
    /// </summary>
    public bool Eliminar(int id)
    {
      if (Inicio == null || !Existe(id))
      {
        return false;
      }

      // El nodo a eliminar es el inicio de la ruta
      if (Inicio.Id == id)
      {
        Inicio = Inicio.Next;
        return true;
      }

      Nodo actual = Inicio;
      while (actual.Next != null && actual.Next.Id != id)
      {
        actual = actual.Next;
      }

      if (actual.Next != null && actual.Next.Id == id)
      {
        actual.Next = actual.Next.Next;
        return true;
      }

      return false;
    }

    /// <summary>
    /// Indica si existe un nodo con el Id proporcionado.
    /// </summary>
    public bool Existe(int id)
    {
      return Buscar(id) != null;
    }

    /// <summary>
    /// Busca y devuelve el nodo (referencia real dentro de la lista) con el Id indicado.
    /// </summary>
    public Nodo? Buscar(int id)
    {
      Nodo? actual = Inicio;
      while (actual != null)
      {
        if (actual.Id == id)
        {
          return actual;
        }
        actual = actual.Next;
      }
      return null;
    }

    /// <summary>
    /// Modifica los datos (Nombre, Pista, NivelPeligro) del nodo que tenga el Id indicado.
    /// El Id de un nodo no se modifica: si se requiere cambiar el Id, debe eliminarse
    /// e insertarse de nuevo.
    /// </summary>
    public bool Modificar(int id, string nombre, string pista, int nivelPeligro)
    {
      Nodo? nodo = Buscar(id);
      if (nodo == null)
      {
        return false;
      }

      nodo.Nombre = nombre;
      nodo.Pista = pista;
      nodo.NivelPeligro = nivelPeligro;
      return true;
    }

    /// <summary>
    /// Cuenta cuántos nodos existen actualmente en la ruta.
    /// </summary>
    public int Contar()
    {
      int contador = 0;
      Nodo? actual = Inicio;
      while (actual != null)
      {
        contador++;
        actual = actual.Next;
      }
      return contador;
    }

    /// <summary>
    /// Recorre la lista enlazada desde Inicio hasta NULL y devuelve
    /// los nodos en una secuencia lista para ser mostrada (por ejemplo en un DataGridView).
    /// Esta lista devuelta es solo una instantánea de lectura; el almacenamiento real
    /// sigue siendo la lista enlazada.
    /// </summary>
    public List<Nodo> Recorrer()
    {
      List<Nodo> resultado = new List<Nodo>();
      Nodo? actual = Inicio;
      while (actual != null)
      {
        resultado.Add(actual);
        actual = actual.Next;
      }
      return resultado;
    }

    public override string ToString()
    {
      string resultado = "";
      Nodo? actual = Inicio;
      while (actual != null)
      {
        resultado += actual.ToString() + "\n";
        actual = actual.Next;
      }
      return resultado;
    }
  }
}
