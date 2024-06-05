using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdPattern
{
    // Определим адаптер Adapter
    public class Adapter : PCGame
    {
        private ComputerGame computerGame;

        // Конструктор, принимающий объект класса ComputerGame
        public Adapter(ComputerGame computerGame)
        {
            this.computerGame = computerGame;
        }

        // Реализация методов интерфейса PCGame
        public string getTitle()
        {
            return computerGame.getName();
        }

        public int getPegiAllowedAge()
        {
            // Преобразуем PegiAgeRating в соответствующий возраст
            switch (computerGame.getPegiAgeRating())
            {
                case PegiAgeRating.P3:
                    return 3;
                case PegiAgeRating.P7:
                    return 7;
                case PegiAgeRating.P12:
                    return 12;
                case PegiAgeRating.P16:
                    return 16;
                case PegiAgeRating.P18:
                    return 18;
                default:
                    return 0; // По умолчанию возвращаем 0, если рейтинг неопределен
            }
        }

        public bool isTripleAGame()
        {
            // Проверяем, превышает ли бюджет игры 50 миллионов долларов
            return computerGame.getBudgetInMillionsOfDollars() > 50;
        }

        public Requirements getRequirements()
        {
            // Создаем объект класса Requirements, используя данные из ComputerGame
            Requirements requirements = new Requirements(
                computerGame.getMinimumGpuMemoryInMegabytes(),
                computerGame.getDiskSpaceNeededInGB(),
                computerGame.getRamNeededInGb(),
                computerGame.getCoreSpeedInGhz(),
                computerGame.getCoresNeeded()
            );
            return requirements;
        }
    }

}
