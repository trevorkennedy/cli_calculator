using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_Interfaces;

namespace Logic
{
    public class Calculator
    {
        private IBinaryOperation pending_operation = null;
        private double lhs = 0.0;
        private double rhs = 0.0;

        public string Equals()
        {
            if (pending_operation != null)
            {
                lhs = pending_operation.Perform_binary_calculation(lhs, rhs);
                pending_operation = null;
            }
            return lhs.ToString();
        }

        public string Number_entered(double value)
        {
            if (pending_operation == null)
                lhs = value;
            else
                rhs = value;
            return value.ToString();
        }

        public string Addition_entered()
        {
            this.pending_operation = new Addition();
            return lhs.ToString();
        }

        public string Subtraction_entered()
        {
            this.pending_operation = new Subtraction();
            return lhs.ToString();
        }

        public string Multiplication_entered()
        {
            this.pending_operation = new Multiplication();
            return lhs.ToString();
        }

        public string Division_entered()
        {
            this.pending_operation = new Division();
            return lhs.ToString();
        }

        public string Reciprocal_entered()
        {
            this.pending_operation = new Reciprocal();
            return lhs.ToString();
        }

        public string Square_root_entered()
        {
            this.pending_operation = new Square_Root();
            return lhs.ToString();
        }
    }

    public class Reciprocal : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return 1 / lhs;
        }
    }

    public class Square_Root : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return Math.Sqrt(lhs);
        }
    }

    public class Addition : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return lhs + rhs;
        }
    }

    public class Subtraction : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return lhs - rhs;
        }
    }

    public class Multiplication : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return lhs * rhs;
        }
    }

    public class Division : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return lhs / rhs;
        }
    }
}