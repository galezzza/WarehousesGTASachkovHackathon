using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Properties.ProductionBuisnesses.Motorclub.Buisnesses
{
    class DocumentForgeryOffice : MCProductionBuisness
    {
        public DocumentForgeryOffice(string name, int price) 
            : base(name, price, MCBuisnessType.DocumentForgeryOffice)
        {
        }

        public override IOwnedProperty AddOwner(Player player)
        {
            return new OwnedDocumentForgeryOffice(this, player);
        }
    }
}
