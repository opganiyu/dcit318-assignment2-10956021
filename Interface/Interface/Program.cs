
using Interface;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Move();

        Bicycle bicycle = new Bicycle();
        bicycle.Move();
    }
}