using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_KarinaContini
{
    internal class Calculator
    {
        //private fields
        private decimal currentValue; //A decimal that stores the result currently displayed by the calculator
        private decimal operand1; //A decimal that stores the value of the first operand.
        private decimal operand2; //A decimal that stores the value of the second operand.
        private string op; //A string type that stores the value of the operator

        //Properties
        public decimal CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }



        public Calculator()
        { }  //Creates a Calculator object with default values. The default value for the op field is Null.

        ////Sets the operand1 and currentValue fields to the value that’s passed to it and sets the op field to "+".
        public void Add(decimal displayValue)
        {
            operand1 = displayValue;
            CurrentValue = displayValue;
            op = "+";
        }

        //Sets the operand1 and currentValue fields to the value that’s passed to it and sets the op field to "-".
        public void Subtract(decimal displayValue)
        {
            operand1 = displayValue;
            CurrentValue = displayValue;
            op = "-";

        }

        //Sets the operand1 and currentValue fields to the value that’s passed to it and sets the op field to "*".
        public void Multiply(decimal displayValue)
        {
            operand1 = displayValue;
            CurrentValue = displayValue;
            op = "*";
        }

        //Sets the operand1 and currentValue fields to the value that’s passed to it and sets the op field to "/".
        public void Divide(decimal displayValue)
        {
            operand1 = displayValue;
            CurrentValue = displayValue;
            op = "/";
        }

        public void Signal(decimal displayValue)
        {
            //operand1 = displayValue * (-1);
            CurrentValue = displayValue * (-1);
        }

        //Performs the operation specified by the op field on the operand1 and operand2 fields, and stores the result in the operand1 field.
        public void Equals()
        {
            operand1 = CurrentValue;
            if (op == "+")
            {
                CurrentValue = operand1 + operand2;
            }
            else if (op == "-")
            {
                CurrentValue = operand1 - operand2;
            }
            else if (op == "*")
            {
                CurrentValue = operand1 * operand2;
            }
            else if (op == "/" && operand2 != 0)
            {
                CurrentValue = operand1 / operand2;
            }
            else if (op == "/" && operand2 == 0)
            {
                MessageBox.Show("Cannot divide by zero.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sets the operand2 field to the value that’s passed to it.Then, performs the operation specified by the op field on the operand1 and operand2 fields, and stores the result in the operand1 field.
        public void Equals(decimal displayValue)
        {
            operand2 = displayValue;
            if (op == "+")
            {
                CurrentValue = operand1 + operand2;
            }
            else if (op == "-")
            {
                CurrentValue = operand1 - operand2;
            }
            else if (op == "*")
            {
                CurrentValue = operand1 * operand2;
            }
            else if (op == "/" && operand2 != 0)
            {
                CurrentValue = operand1 / operand2;
            }
            else if (op == "/" && operand2 == 0)
            {
                MessageBox.Show("Cannot divide by zero.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sets the private fields to their default values.
        public void Clear()
        {
            operand1 = 0;
            operand2 = 0;
            CurrentValue = 0;
            op = "";
        }
    
    }
}
