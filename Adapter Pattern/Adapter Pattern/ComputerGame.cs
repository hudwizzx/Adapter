﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdPattern
{

    public class ComputerGame
    {
        private string name;
        private PegiAgeRating pegiAgeRating;
        private double budgetInMillionsOfDollars;
        private int minimumGpuMemoryInMegabytes;
        private int diskSpaceNeededInGB;
        private int ramNeededInGb;
        private int coresNeeded;
        private double coreSpeedInGhz;

        public ComputerGame(string name,
                            PegiAgeRating pegiAgeRating,
                            double budgetInMillionsOfDollars,
                            int minimumGpuMemoryInMegabytes,
                            int diskSpaceNeededInGB,
                            int ramNeededInGb,
                            int coresNeeded,
                            double coreSpeedInGhz)
        {
            this.name = name;
            this.pegiAgeRating = pegiAgeRating;
            this.budgetInMillionsOfDollars = budgetInMillionsOfDollars;
            this.minimumGpuMemoryInMegabytes = minimumGpuMemoryInMegabytes;
            this.diskSpaceNeededInGB = diskSpaceNeededInGB;
            this.ramNeededInGb = ramNeededInGb;
            this.coresNeeded = coresNeeded;
            this.coreSpeedInGhz = coreSpeedInGhz;
        }

        public string getName()
        {
            return name;
        }

        public PegiAgeRating getPegiAgeRating()
        {
            return pegiAgeRating;
        }

        public double getBudgetInMillionsOfDollars()
        {
            return budgetInMillionsOfDollars;
        }

        public int getMinimumGpuMemoryInMegabytes()
        {
            return minimumGpuMemoryInMegabytes;
        }

        public int getDiskSpaceNeededInGB()
        {
            return diskSpaceNeededInGB;
        }

        public int getRamNeededInGb()
        {
            return ramNeededInGb;
        }

        public int getCoresNeeded()
        {
            return coresNeeded;
        }

        public double getCoreSpeedInGhz()
        {
            return coreSpeedInGhz;
        }
    }

    // Определим перечисление PegiAgeRating
    public enum PegiAgeRating
    {
        P3, P7, P12, P16, P18
    }

    // Определим класс Requirements
    public class Requirements
    {
        private int gpuGb;
        private int HDDGb;
        private int RAMGb;
        private double cpuGhz;
        private int coresNum;

        public Requirements(int gpuGb,
                            int HDDGb,
                            int RAMGb,
                            double cpuGhz,
                            int coresNum)
        {
            this.gpuGb = gpuGb;
            this.HDDGb = HDDGb;
            this.RAMGb = RAMGb;
            this.cpuGhz = cpuGhz;
            this.coresNum = coresNum;
        }

        public int getGpuGb()
        {
            return gpuGb;
        }

        public int getHDDGb()
        {
            return HDDGb;
        }

        public int getRAMGb()
        {
            return RAMGb;
        }

        public double getCpuGhz()
        {
            return cpuGhz;
        }

        public int getCoresNum()
        {
            return coresNum;
        }
    }

    // Определим интерфейс PCGame
    public interface PCGame
    {
        string getTitle();
        int getPegiAllowedAge();
        bool isTripleAGame();
        Requirements getRequirements();
    }

}
