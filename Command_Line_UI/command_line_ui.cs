using System;
using Logic;

namespace Command_Line_UI
{
  public class Command_line_ui
  {
    public Calculator calculator;
    public Command_line_ui()
    {
      calculator = new Calculator();
    }

    public void UI()
    {
      Console.WriteLine("System: 0");
      for (; ; )
      {
        Console.Write("User: ");
        string input = Console.ReadLine();
        string new_display = "oops";
        if (double.TryParse(input, out double value))
        {
          new_display = calculator.Number_entered(value);
        } else
        {
          switch (input.ToLower())
          {
            case "=": new_display = calculator.Equals(); break;
            case "+": new_display = calculator.Addition_entered(); break;
            case "-": new_display = calculator.Subtraction_entered(); break;
            case "*": new_display = calculator.Multiplication_entered(); break;
            case "/": new_display = calculator.Division_entered(); break;
            case "reciprocal": new_display = calculator.Reciprocal_entered(); break;
            case "square_root": new_display = calculator.Square_root_entered(); break;
            default: new_display = "Illegal entry.  Must be a number or [+|-|*|/|reciprocal|square_root]"; break;
          }
        }
        Console.WriteLine($"System: {new_display}");
      }
    }
  }
}