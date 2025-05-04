using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub.Buisnesses.CashFactory;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.Motorclub.Buisnesses
{
    class OwnedDocumentForgeryOffice : OwnedMCProductionBuisness
    {
        private Player player;

        public OwnedDocumentForgeryOffice(DocumentForgeryOffice documentForgeryOffice, Player owner) 
            : base(documentForgeryOffice, owner)
        {
        }

        public OwnedDocumentForgeryOffice(string name, int price, Player owner)
            : base(name, price, MCBuisnessesType.DocumentForgeryOffice, owner)
        {
        }

        public OwnedDocumentForgeryOffice(string name, int price, Player owner, ProductionUpgrades upgrades) 
            : base(name, price, owner, upgrades)
        {
        }
    }
}