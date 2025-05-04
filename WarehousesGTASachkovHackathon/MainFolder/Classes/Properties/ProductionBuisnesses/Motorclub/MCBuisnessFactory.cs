using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub.Buisnesses;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub
{
    class MCBuisnessFactory
    {
        static private MCProductionBuisness[][] TableOfBuissnesses =
        {
            [
                new CocaineLockup($"Cocaine Lockup in {MCBuisnessLocations.Country}", 975000),
                new CocaineLockup($"Cocaine Lockup in {MCBuisnessLocations.PaletoBay}", 1098000),
                new CocaineLockup($"Cocaine Lockup in {MCBuisnessLocations.ElysianIsland}", 1462500),
                new CocaineLockup($"Cocaine Lockup in {MCBuisnessLocations.City}", 1235000),
            ],
            [
                new CounterfeitCashFactory($"Counterfeit Cash Factory in {MCBuisnessLocations.Country}", 845000),
                new CounterfeitCashFactory($"Counterfeit Cash Factory in {MCBuisnessLocations.PaletoBay}", 951600),
                new CounterfeitCashFactory($"Counterfeit Cash Factory in {MCBuisnessLocations.ElysianIsland}", 1267500),
                new CounterfeitCashFactory($"Counterfeit Cash Factory in {MCBuisnessLocations.City}", 1605000),
            ],
            [
                new DocumentForgeryOffice($"Document Forgery Office in {MCBuisnessLocations.Country}", 650000),
                new DocumentForgeryOffice($"Document Forgery Office in {MCBuisnessLocations.PaletoBay}", 732000),
                new DocumentForgeryOffice($"Document Forgery Office in {MCBuisnessLocations.ElysianIsland}", 975000),
                new DocumentForgeryOffice($"Document Forgery Office in {MCBuisnessLocations.City}", 1235000),
            ],
            [
                new MethamphetamineLab($"Methamphetamine Lab in {MCBuisnessLocations.Country}", 910000),
                new MethamphetamineLab($"Methamphetamine Lab in {MCBuisnessLocations.PaletoBay}", 1024800),
                new MethamphetamineLab($"Methamphetamine Lab in {MCBuisnessLocations.ElysianIsland}", 1365000),
                new MethamphetamineLab($"Methamphetamine Lab in {MCBuisnessLocations.City}", 1729000),
            ],
            [
                new WeedFarm($"Weed Farm in {MCBuisnessLocations.Country}", 715000),
                new WeedFarm($"Weed Farm in {MCBuisnessLocations.PaletoBay}", 802200),
                new WeedFarm($"Weed Farm in {MCBuisnessLocations.ElysianIsland}", 1072500),
                new WeedFarm($"Weed Farm in {MCBuisnessLocations.City}", 1358500),
            ]
        };

        public static MCProductionBuisness CreateByTypeAndLocation(MCBuisnessLocations locations, MCBuisnessType type)
        {
            var firstIndex = (int)type;
            var secondIndex = (int)locations;
            var result = TableOfBuissnesses[(int)type][(int)locations];
            return result;
        }
    }
    public enum MCBuisnessLocations
    {
        Country = 0,
        PaletoBay = 1,
        ElysianIsland = 2,
        City = 3
    }
}
