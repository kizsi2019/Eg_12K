using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WinSCP;

namespace Delegate2
{
    public class Calculator
    {
        //Delegate definíciója, amely egy két egész számot váró függvényre mutat
        public delegate int MathOperation(int a, int b);

        //Esemény definiciója, amelyet a műveletet végrehajtásakor tűzünk ki
        public event EventHandler<OperationEventArgs> OperationPerfomed;

        //Metódus, amels elvégzi a műveletet a két egész számon
        public int PerformOperation(int x, int y, MathOperation operation)
        {
            int result = operation(x, y);
            //Esemény kiváltása, hogy jelentsük, hogy művelet végrehajtódott
            OnOperationPerformed(new OperationEventArgs(x, y, operation.Method.Name, result));
            return result;
        }
        protected virtual void OnOperationPerformed(OperationEventArgs e)
        {
            OperationPerfomed?.Invoke(this, e);
        }

        //Esemény argument osztály
        public class OperationEventArgs : EventArgs
        {
            public int Operand1 { get; }
            public int Operand2 { get; }
            public int OperationName { get; }
            public int Result { get; }

            public OperationEventArgs(int operand1, int operand2, int operationName, int result)
            {
                Operand1 = operand1;
                Operand2 = operand2;
                OperationName = operationName;
                Result = result;
            }
        }

        //Feliratkozó osztály az események kezelésére
        public class EventSubscriber
        {
            //Konstruktor, amely feliratkozik az eseméynre
            public EventSubscriber(Calculator calculator)
            {
                calculator.OperationPerfomed += OnOperationPerformed;
            }

            //Eseménykezelő
            private void Calculator_OperationPerfomed(object sender, OperationEventArgs e)
            {
                Console.WriteLine($"Operation perfomed:{e.OperationName}({e.Operand1},{e.Operand2}) = {e.Result}");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                //Calculator objektum létrehozáda
                Calculator calculator = new Calculator();

                //Eventsubscriber objektum létrehozása és feloiratkozás az eseményre
                EventSubscriber subscriber = new EventSubscriber(calculator);

                //Összeadás művelet delegált létrehozása
                Calculator.MathOperation addition = (a,b) => a + b;

                //Kivonás művelet delegált létrehozása
                Calculator.MathOperation substraction = (a, b) => a - b;

                //Szorzás művelet delegált létrehozása
                Calculator.MathOperation multiplication = (a, b) => a * b;

                //Műveletek végrehajtása és eredmények kiírása
                int result1 = calculator.PerformOperation(5, 3, addition);
                int result2 = calculator.PerformOperation(8, 4, substraction);
                int result3 = calculator.PerformOperation(5, 3, multiplication);

                Console.ReadKey();
            }


        }
        
    }
}
