using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
//using WinSCP;

namespace delegate2 // Note: actual namespace depends on the project name.
{
    public class Calculator
    {
        //Delegate definiciója
        public delegate int MathOperation(int a, int b);

        //Esemény definiciója
        public event EventHandler<OperationEventArgs> OperationPerformed;

        public int PerformOperation(int x, int y, MathOperation operation)
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
            Console.WriteLine($"Operation performed: {e.OperationName}({e.Operand1}, {e.Operand2}) = {e.Result}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            EventSubscriber subscriber = new EventSubscriber(calculator);
            Calculator.MathOperation addition = (a, b) => a + b;
            Calculator.MathOperation subtraction = (a, b) => a - b;
            Calculator.MathOperation multiplication = (a, b) => a * b;

            int result1 = calculator.PerformOperation(5, 3, addition);
            int result2 = calculator.PerformOperation(8, 4, subtraction);
            int result3 = calculator.PerformOperation(6, 7, multiplication);
            Console.ReadKey();
        }
    }
    public void Test_NoiVersenyzoRovidTavon_CountsCorrectly()
    {
        // Arrange
        var versenyzok = A.CollectionOfFake<Versenyzo>(5);
        foreach (var v in versenyzok)
        {
            v.NoiVersenyzo = true;
            v.Tav = "Rövid";
        }
        // Adding a male competitor to verify that it's not counted
        versenyzok[3].NoiVersenyzo = false;

        var expectedCount = 3; // Changed from 4 to 3

        // Act
        int noiVersenyzoRovidTavon = 0;
        foreach (var v in versenyzok)
        {
            if (v.NoiVersenyzo && v.Tav == "Rövid")
            {
                noiVersenyzoRovidTavon++;
            }
        }

        // Assert
        noiVersenyzoRovidTavon.Should().Be(expectedCount);
    }
    public class Versenyzo
{
    public bool NoiVersenyzo { get; set; }
    public string Tav { get; set; }
}
