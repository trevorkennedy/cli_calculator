using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_Interfaces;

namespace Command_Line_UI
{
  class Program
  {

    static void Main(string[] args)
    {
      Command_line_ui command_line_ui = new Command_line_ui();
      command_line_ui.UI();
    }
  }
}
