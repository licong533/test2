using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SafePart.src;

namespace SafePart {
  static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ClientRSA client = new ClientRSA();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new main());
    }
  }
}
