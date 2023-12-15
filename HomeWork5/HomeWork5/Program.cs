using System;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            /*1.	შეამოწმეთ იყოფა თუ არა რიცხვი 5ზე უნაშთოდ. რიცხვი უნდა მიიღოთ კონსოლიდან.*/
            Console.WriteLine("TASK1");
            Console.Write("Enter Number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());


            if (inputNumber % 5 == 0)
            {
                Console.WriteLine("has not remainder ");
                Console.WriteLine($"{inputNumber} % 5 = {inputNumber % 5}");
            }
            else
            {
                Console.WriteLine("has remainder");
                Console.WriteLine($"{inputNumber} % 5 = {inputNumber % 5}");
            }

            #endregion


            #region Task2
            /*2.	დაწერეთ ისეთი პროგრამა, რომელიც შეასრულებს ჯამის, სხვაობის,
             * ნამრავლის და გაყოფის მოქმედებები შენიშვნა 
                    i.	გაყოფის და გამოკლების დროს აარჩიეთ უდიდესი და მას გამოაკელით უმცირესი
                    ii.	თუ უმცირესი რიცხვი იქნება 0 პროგრამამ უნდა გამოიტანოს შეცდომა  0 გაყოფა არ შეიძლება .
            */
            Console.WriteLine("\nTASK2");

            Console.WriteLine("We need two numbers for input");
            Console.Write("Enter fisrt number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            var resultOfSum = firstNumber + secondNumber;
            var resultOfSubtraction = Math.Max(firstNumber, secondNumber) - Math.Min(firstNumber, secondNumber);
            var resultOfMultiply = firstNumber * secondNumber;
            double resultOfDivision = Math.Max(firstNumber, secondNumber) / Math.Min(firstNumber, secondNumber);


            if (Math.Min(firstNumber, secondNumber) != 0)
            {

                Console.WriteLine($"Sum is: {resultOfSum}");
                Console.WriteLine($"Subtraction is {resultOfSubtraction}");
                Console.WriteLine($"Multiply is {resultOfMultiply}");
                Console.WriteLine($"Division is {resultOfDivision}");
            }
            else
            {
                Console.WriteLine($"Sum is: {resultOfSum}");
                Console.WriteLine($"Subtraction is {resultOfSubtraction}");
                Console.WriteLine($"Multiply is {resultOfMultiply}");
                Console.WriteLine("Not Allowed To Divide By Zero");
            }


            #endregion


            #region Task3
            /*3.	გაუცვალეთ ორ ცვლადს შორის მნიშვნელობები */
            //input x=5 , y=12
            //output x=12 y=5
            Console.WriteLine("\nTASK3");

            Console.Write("Enter number x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            var exchangeNums = x;
            x = y;
            y = exchangeNums;

            Console.WriteLine($"result of an exchange: x={x} and y={y}");

            #endregion



            #region Task4
            /*4.	დაწერეთ პროგრამა რომელიც მიიღებს კონსოლიდან 1 რიცხვს და დაბეჭდავს გამრავლების ტაბულას ამ რიცხვისთვის    
            a.	შენიშვნა : გამოიყენეთ ციკლი.
            */

            Console.WriteLine("\nTASK4");

            Console.Write("enter num: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiply Table");

            for (int i = 1; i < 10; i++)
            {
                int result = a * i;
                Console.WriteLine($"{a} * {i} = {result}");
            }

            #endregion


            #region Task5
            /*5.	დაწერეთ პროგრამა რომელიც იპოვის ყველა ლუწ რიცხვს 1 დან n - მდე და დაბეჭდავს მათ კვადრატებს .*/

            Console.WriteLine("\nTASK5");

            Console.Write("enter number n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < n; i += 2)
            {
                Console.Write(Math.Pow(i, 2) + "\n");
            }



            #endregion


            Console.ReadKey();
        }
    }
}
