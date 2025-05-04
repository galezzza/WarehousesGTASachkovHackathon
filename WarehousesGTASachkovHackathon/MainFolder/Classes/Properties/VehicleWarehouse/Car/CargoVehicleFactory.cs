using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Warehouses;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.VehicleWarehouse.Car
{
    class CargoVehicleFactory
    {
        public static CargoCar CreateByName(string name)
        {
            return name switch
            {
                "ZType1" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "B1GMON3Y"),
                "ZType2" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "K1NGP1N"),
                "ZType3" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "CEO"),

                "ETR1_1" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "B1GMON3Y"),
                "ETR1_2" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "K1NGP1N"),
                "ETR1_3" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "CEO"),

                "811_1" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "B1GMON3Y"),
                "811_2" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "K1NGP1N"),
                "811_3" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "CEO"),

                "Osiris_1" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "B1GMON3Y"),
                "Osiris_2" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "K1NGP1N"),
                "Osiris_3" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "CEO"),

                "Reaper_1" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "B1GMON3Y"),
                "Reaper_2" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "K1NGP1N"),
                "Reaper_3" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "CEO"),

                "Mamba_1" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "B1GMON3Y"),
                "Mamba_2" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "K1NGP1N"),
                "Mamba_3" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "CEO"),

                "FMJ_1" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "B1GMON3Y"),
                "FMJ_2" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "K1NGP1N"),
                "FMJ_3" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "CEO"),

                "StirlingGT_1" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "B1GMON3Y"),
                "StirlingGT_2" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "K1NGP1N"),
                "StirlingGT_3" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "CEO"),

                "X80_1" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "B1GMON3Y"),
                "X80_2" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "K1NGP1N"),
                "X80_3" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "CEO"),

                "Tyrus_1" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "B1GMON3Y"),
                "Tyrus_2" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "K1NGP1N"),
                "Tyrus_3" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "CEO"),

                "T20_1" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "B1GMON3Y"),
                "T20_2" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "K1NGP1N"),
                "T20_3" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "CEO"),

                "RoosveltValor_1" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "B1GMON3Y"),
                "RoosveltValor_2" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "K1NGP1N"),
                "RoosveltValor_3" => new CargoCar(CargoCarType.Top, "Truffade", "Z-Type", "CEO"),

                "CoquetteClassic_1" => new CargoCar(CargoCarType.Mid, "Truffade", "CoquetteClassic", "B1GMON3Y"),
                "CoquetteClassic_2" => new CargoCar(CargoCarType.Mid, "Truffade", "CoquetteClassic", "K1NGP1N"),
                "CoquetteClassic_3" => new CargoCar(CargoCarType.Mid, "Truffade", "CoquetteClassic", "CEO"),

                "Verlierer_1" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "B1GMON3Y"),
                "Verlierer_2" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "K1NGP1N"),
                "Verlierer_3" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "CEO"),

                "Zentorno_1" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "B1GMON3Y"),
                "Zentorno_2" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "K1NGP1N"),
                "Zentorno_3" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "CEO"),

                "TroposRallye_1" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "B1GMON3Y"),
                "TroposRallye_2" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "K1NGP1N"),
                "TroposRallye_3" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "CEO"),

                "SultanRS_1" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "B1GMON3Y"),
                "SultanRS_2" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "K1NGP1N"),
                "SultanRS_3" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "CEO"),

                "Cheetah_1" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "B1GMON3Y"),
                "Cheetah_2" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "K1NGP1N"),
                "Cheetah_3" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "CEO"),

                "Seven70_1" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "B1GMON3Y"),
                "Seven70_2" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "K1NGP1N"),
                "Seven70_3" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "CEO"),

                "Omnis_1" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "B1GMON3Y"),
                "Omnis_2" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "K1NGP1N"),
                "Omnis_3" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "CEO"),

                "EntityXF_1" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "B1GMON3Y"),
                "EntityXF_2" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "K1NGP1N"),
                "EntityXF_3" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "CEO"),

                "CoquetteBlackFin_1" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "B1GMON3Y"),
                "CoquetteBlackFin_2" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "K1NGP1N"),
                "CoquetteBlackFin_3" => new CargoCar(CargoCarType.Mid, "Truffade", "Z-Type", "CEO"),

                "TurismoR_1" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "B1GMON3Y"),
                "TurismoR_2" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "K1NGP1N"),
                "TurismoR_3" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "CEO"),

                "Tampa_1" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "B1GMON3Y"),
                "Tampa_2" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "K1NGP1N"),
                "Tampa_3" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "CEO"),

                "SabreTurnoCustom_1" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "B1GMON3Y"),
                "SabreTurnoCustom_2" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "K1NGP1N"),
                "SabreTurnoCustom_3" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "CEO"),

                "Nightshade_1" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "B1GMON3Y"),
                "Nightshade_2" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "K1NGP1N"),
                "Nightshade_3" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "CEO"),

                "Massacro_1" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "B1GMON3Y"),
                "Massacro_2" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "K1NGP1N"),
                "Massacro_3" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "CEO"),

                "Jester_1" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "B1GMON3Y"),
                "Jester_2" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "K1NGP1N"),
                "Jester_3" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "CEO"),

                "Feltzer_1" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "B1GMON3Y"),
                "Feltzer_2" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "K1NGP1N"),
                "Feltzer_3" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "CEO"),

                "BestiaGTS_1" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "B1GMON3Y"),
                "BestiaGTS_2" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "K1NGP1N"),
                "BestiaGTS_3" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "CEO"),

                "Alpha_1" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "B1GMON3Y"),
                "Alpha_2" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "K1NGP1N"),
                "Alpha_3" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "CEO"),

                "Banshee900R_1" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "B1GMON3Y"),
                "Banshee900R_2" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "K1NGP1N"),
                "Banshee900R_3" => new CargoCar(CargoCarType.Low, "Truffade", "Z-Type", "CEO"),

                _ => throw new ArgumentException("Unknown warehouse name.", nameof(name))
            };
        }

        private static readonly Random Random = new();
        public static readonly string[] TopLevelCarNames = new[]
        {
            "ZType1", "ZType2", "ZType3",
            "ETR1_1", "ETR1_2", "ETR1_3",
            "811_1", "811_2", "811_3",
            "Osiris_1", "Osiris_2", "Osiris_3",
            "Reaper_1", "Reaper_2", "Reaper_3",
            "Mamba_1", "Mamba_2", "Mamba_3",
            "FMJ_1", "FMJ_2", "FMJ_3",
            "StirlingGT_1", "StirlingGT_2", "StirlingGT_3",
            "X80_1", "X80_2", "X80_3",
            "Tyrus_1", "Tyrus_2", "Tyrus_3",
            "T20_1", "T20_2", "T20_3",
            "RoosveltValor_1", "RoosveltValor_2", "RoosveltValor_3"
        };

        public static readonly string[] MidLevelCarNames = new[]
        {
            "CoquetteClassic_1", "CoquetteClassic_2", "CoquetteClassic_3",
            "Verlierer_1", "Verlierer_2", "Verlierer_3",
            "Zentorno_1", "Zentorno_2", "Zentorno_3",
            "TroposRallye_1", "TroposRallye_2", "TroposRallye_3",
            "SultanRS_1", "SultanRS_2", "SultanRS_3",
            "Cheetah_1", "Cheetah_2", "Cheetah_3",
            "Seven70_1", "Seven70_2", "Seven70_3",
            "Omnis_1", "Omnis_2", "Omnis_3",
            "EntityXF_1", "EntityXF_2", "EntityXF_3",
            "CoquetteBlackFin_1", "CoquetteBlackFin_2", "CoquetteBlackFin_3"
        };

        private static readonly string[] LowTierNames = new[]
        {
            "TurismoR_1", "TurismoR_2", "TurismoR_3",
            "Tampa_1", "Tampa_2", "Tampa_3",
            "SabreTurnoCustom_1", "SabreTurnoCustom_2", "SabreTurnoCustom_3",
            "Nightshade_1", "Nightshade_2", "Nightshade_3",
            "Massacro_1", "Massacro_2", "Massacro_3",
            "Jester_1", "Jester_2", "Jester_3",
            "Feltzer_1", "Feltzer_2", "Feltzer_3",
            "Bestia_1", "Bestia_2", "Bestia_3",
            "Alpha_1", "Alpha_2", "Alpha_3",
            "Banshee900R_1", "Banshee900R_2", "Banshee900R_3"
        };

        public static CargoCar GetRandomTopTierCar()
        {
            string randomName = TopLevelCarNames[Random.Next(TopLevelCarNames.Length)];
            return CreateByName(randomName);
        }
        public static CargoCar GetRandomMidTierCar()
        {
            string randomName = MidLevelCarNames[Random.Next(MidLevelCarNames.Length)];
            return CreateByName(randomName);
        }
        public static CargoCar GetRandomLowTierCar()
        {
            string randomName = LowTierNames[Random.Next(LowTierNames.Length)];
            return CreateByName(randomName);
        }
    }
}
