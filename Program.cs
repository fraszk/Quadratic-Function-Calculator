namespace Quadratic_Function_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputClass inputClass = new InputClass();

            Console.WriteLine(
                "Kalkulator własności funkcji kwadratowej" +
                "\n\nDodatkowe informacje:" +
                "\n1. Wpisanie znaku zamiast liczby zostanie zinterpretowane jako wartość 0" +
                "\n2. Liczbę zmiennoprzecinkową należy zapisać z przecinkiem(,) a nie kropką!\n");

            while (true)
            {
                inputClass.Input();
                Console.WriteLine("Aby kontynuować wpisz con lub wciśnij ENTER, aby zamknąć program wpisz quit");
                string answer = Console.ReadLine();

                if (answer == "con")
                {
                    Console.Clear();
                    continue;
                }
                else if (answer == "quit")
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();
            }
        }
    }
}