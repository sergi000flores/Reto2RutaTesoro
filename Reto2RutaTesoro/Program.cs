using System;
using System.Windows.Forms;

namespace TreasureRoute
{
  internal static class Program
  {
    /// <summary>
    /// Main entry point of the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      ApplicationConfiguration.Initialize();
      Application.Run(new TreasureRouteForm());
    }
  }
}
