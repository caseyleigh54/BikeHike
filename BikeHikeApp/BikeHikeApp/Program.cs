//
// Windows Form App to allow bike rentals via BikeHike database.
//
// Prof. Joe Hummel
// U. of Illinois, Chicago
// CS480, Summer 2018
// Project #2: Solution
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeHikeApp
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }
  }
}
