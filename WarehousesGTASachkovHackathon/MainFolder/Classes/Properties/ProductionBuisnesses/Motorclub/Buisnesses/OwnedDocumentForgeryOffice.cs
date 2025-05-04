using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub.Buisnesses
{
    class OwnedDocumentForgeryOffice : OwnedMCProductionBuisness
    {
        private Player player;

        public OwnedDocumentForgeryOffice(DocumentForgeryOffice documentForgeryOffice, Player owner) 
            : base(documentForgeryOffice, owner)
        {
        }

        public OwnedDocumentForgeryOffice(string name, int price, Player owner)
            : base(name, price, MCBuisnessType.DocumentForgeryOffice, owner)
        {
        }

        public OwnedDocumentForgeryOffice(string name, int price, Player owner, MCProductionUpgrades upgrades) 
            : base(name, price, owner, upgrades)
        {
        }
    }
}