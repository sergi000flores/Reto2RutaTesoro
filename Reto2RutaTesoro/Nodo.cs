using System;

namespace TreasureRoute
{
    /// <summary>
    /// Represents a map location within the treasure route.
    /// Each node only knows the next node in the route (singly linked list).
    /// </summary>
  internal class Nodo
  {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Pista { get; set; }
    public int NivelPeligro { get; set; }
    public Nodo? Next { get; set; }

    public Nodo()
    {
      Id = 0;
      Nombre = "";
      Pista = "";
      NivelPeligro = 1;
      Next = null;
    }

    public Nodo(int id, string nombre, string pista, int nivelPeligro, Nodo? next)
    {
      Id = id;
      Nombre = nombre;
      Pista = pista;
      NivelPeligro = nivelPeligro;
      Next = next;
    }

    public override string ToString()
    {
      return $"Id: {Id}, Ubicación: {Nombre}, Pista: {Pista}, Peligro: {NivelPeligro}";
    }
  }
}
