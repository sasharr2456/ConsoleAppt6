using Buider_Pattern;
using Buider_Pattern.Сomponents;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {

        var cpu = new CPU("Intel Core i9", 8);
        var motherboard = new Motherboard("ASUS ROG Strix scar|||", "ATX");
        var ram = new RAM("Corsair Vengeance", 32);
        var storage = new Storage("SSD", 4000);
        var gpu = new GPU("NVIDIA GeForce RTX 4090", 24);


        var computerBuilder = new ComputerBuilder();
        Computer computer = computerBuilder
            .SetCPU(cpu)
            .SetMotherboard(motherboard)
            .SetRAM(ram)
            .SetStorage(storage)
            .SetGPU(gpu)
            .Build();


        Console.WriteLine(computer);
    }
}