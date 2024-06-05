using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект класса ComputerGame
            ComputerGame computerGame = new ComputerGame(
                "Title",
                PegiAgeRating.P18,
                60, 
                2048, 
                50, 
                16, 
                8, 
                3.5 
            );

            // Создаем адаптер и приводим объект ComputerGame к интерфейсу PCGame
            PCGame gameAdapter = new Adapter(computerGame);

            // Используем методы интерфейса PCGame
            Console.WriteLine("Title: " + gameAdapter.getTitle());
            Console.WriteLine("Pegi Allowed Age: " + gameAdapter.getPegiAllowedAge());
            Console.WriteLine("Triple A Game: " + gameAdapter.isTripleAGame());
            Requirements requirements = gameAdapter.getRequirements();
            Console.WriteLine("Requirements: ");
            Console.WriteLine("- GPU Memory: " + requirements.getGpuGb() + " GB");
            Console.WriteLine("- HDD Space: " + requirements.getHDDGb() + " GB");
            Console.WriteLine("- RAM: " + requirements.getRAMGb() + " GB");
            Console.WriteLine("- CPU Speed: " + requirements.getCpuGhz() + " GHz");
            Console.WriteLine("- Cores: " + requirements.getCoresNum());

            Console.ReadLine();
        }
    }

}
