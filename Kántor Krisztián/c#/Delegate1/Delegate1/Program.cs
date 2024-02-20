using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WinSCP;

namespace Delegate1
{
    public class Calculator
    {
        public delegate int MathOperation(int a, int b);
        public event EventHandler<OperationEventArgs>OperationPerformed;
        
        public int PreformOperation(int x, int y,MathOperation operation)
        {
            int result = operation(x, y);
            OnOperationPerformed(new OperationEventArgs(x, y, operation.Method.Name, result));
            return result;
        }

        protected virtual void OnOperationPerformed(OperationEventArgs e)
        {
            OperationPerformed?.Invoke(this, e);
        }
    }

    public class OperationEventArgs : EventArgs
    {
        public int Operand1 { get; }
        public int Operand2 { get; }
        public string OperationName { get; }
        public int Result { get; }
        public OperationEventArgs(int operand1, int operand2, string operationName, int result)
        {
            Operand1 = operand1;
            Operand2 = operand2;
            OperationName = operationName;
            Result = result;
        }
    }
    public class EventSubscriber
    {
        public EventSubscriber(Calculator calculator)
        {
            calculator.OperationPerformed += Calculator_OperationPerformed;
        }

        private void Calculator_OperationPerformed(object sender, OperationEventArgs e)
        {
            Console.WriteLine($"Operation performed:{e.OperationName}({e.Operand1},{e.Operand2})={e.Result}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            EventSubscriber subscriber = new EventSubscriber(calculator);
            Calculator.MathOperation addition = (a, b) => a + b;
            Calculator.MathOperation substraction= (a, b) => a - b;
            Calculator.MathOperation multiply = (a, b) => a * b;

            int result1 = calculator.PreformOperation(5, 3, addition);
            int result2= calculator.PreformOperation(5, 3, substraction);
            int result3 = calculator.PreformOperation(5, 3, multiply);

            Console.ReadKey();

        }
    }
}
