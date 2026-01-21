using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBusProject
{
    public enum WeatherType {Sunny, Rainy}
    public class EnergySystem
    {
        public bool OpenRoof { get; set; }
        public bool AcOpen { get; set; }
        public WeatherType Weather { get; set; }
        public int EnergyLevel { get; private set; }
        public int SolarPanelProduction { get; set; }
        public int TotalEnergyConsumption {  get; set; }
        public int AcEnergyConsumption { get; set; }

        public int BusScreenConsumption = 15;
        public int BusEngineConsumption = 35;

        public bool LowEnergyAlert { get; private set; }

        private Random random = new Random();
        private int weatherChangeCounter = 0;

        private const int MaxEnergy = 3000;
        private const int MinEnergy = 0;

        public EnergySystem()
        {
            EnergyLevel = 1500;
            OpenRoof = false;
            AcOpen = false;
            Weather = WeatherType.Sunny;
        }

        public void UpdateEnergy()
        {
            UpdateWeather();

            EnergyProduction();
            EnergyConsumption();

            TotalEnergyConsumption = AcEnergyConsumption + BusScreenConsumption + BusEngineConsumption;

            int addEnergy = SolarPanelProduction - TotalEnergyConsumption;
            EnergyLevel += addEnergy;

            if (EnergyLevel > MaxEnergy)
            {
                EnergyLevel = MaxEnergy;
            }
            else if (EnergyLevel < MinEnergy)
            {
                EnergyLevel = MinEnergy;
            }

            if (EnergyLevel < 300 && AcOpen)
            {
                AcOpen = false;
            }
        }

        public void UpdateWeather()
        {
            weatherChangeCounter++;

            if (weatherChangeCounter >= 10)
            {
                weatherChangeCounter = 0;

                Weather = random.Next(0, 100) <70 ? WeatherType.Sunny : WeatherType.Rainy;

                if (Weather == WeatherType.Rainy)
                {
                    OpenRoof = false;
                }
            }
        }

        public void EnergyProduction()
        {
            if (OpenRoof && Weather == WeatherType.Sunny)
            {
                SolarPanelProduction = 120;
            }
            else
            {
                SolarPanelProduction = 0;
            }
        }

        public void EnergyConsumption()
        {
            if (AcOpen)
            {
                AcEnergyConsumption = 20;
            }
            else
            {
                AcEnergyConsumption = 0;
            }
        }
    }
}
