using Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.MakeSound();

        Dog dog = new Dog();
        dog.MakeSound();

        Cat cat = new Cat();
        cat.MakeSound();
    }
}