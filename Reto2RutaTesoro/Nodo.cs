using System;

namespace Reto2RutaTesoro
{
  /// <summary>
  /// Representa una ubicación del mapa dentro de la ruta del tesoro.
  /// Cada nodo conoce únicamente al siguiente nodo de la ruta (lista simplemente enlazada).
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
