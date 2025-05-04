using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes.Organizations
{
    class Motoclub : IOrganization
    {
        public string Name { get; } = "Motoclub";
        public bool IsActive { get; private set; } = false;
        public int NumberOfEmployees { get; private set; }
        public void Activate()
        {
            IsActive = true;
            NumberOfEmployees = 1;
        }
        public void Deactivate()
        {
            IsActive = false;
            NumberOfEmployees = 0;
        }
    }
}
