using MyCalculatorApp;

class Program
{
    static void MyCal()
    {
        Calclulator calclulator = new Calclulator();
        console.WriteLine("Add.(int, int): " + calculator.Add(3,4));
        console.WriteLine("Add(int, int int): " + calculator.Add(4, 7, 12));
        console.WriteLine("Add(double, double): " + calculator.Add(3.7, 5.9));
    }
}