using WarehousesGTASachkovHackathon.MainFolder.Classes.Organizations;
using WarehousesGTASachkovHackathon.MainFolder.Classes.Properties;
using WarehousesGTASachkovHackathon.MainFolder.Interfaces;

namespace WarehousesGTASachkovHackathon.MainFolder.Classes
{
    public class Player
    {   
        public string Nickname { get; }
        public WalletAccount Money { get; } = new WalletAccount();

        private readonly List<IOrganization> _organizations;
        public IReadOnlyList<IOrganization> Organizations => _organizations.AsReadOnly();

        private PlayerProperties Properties { get; } = new PlayerProperties();

        public IOwnedProperty BuyNewProperty(IProperty property)
        {
            var owndedProperty = property.AddOwner(this);
            try
            {
                Properties.AddProperty(owndedProperty);
                Money.SubtractMoney(property.Price);
            }
            catch
            {
                owndedProperty = null;
            }
            return owndedProperty;
        }

        public IOrganization GetActiveOrganization()
        {
            var activeOrganization = _organizations.FirstOrDefault(o => o.IsActive);
            if (activeOrganization == null)
                throw new InvalidOperationException("No active organization found!");
            return activeOrganization;
        }
        public void ActivateOrganization<T>() where T : IOrganization
        {
            var target = _organizations.OfType<T>().FirstOrDefault();
            if (target == null)
                throw new InvalidOperationException("Organization not found!");

            foreach (var org in _organizations)
                if ((org.IsActive) && !(org is T) )
                { 
                    throw new InvalidOperationException("Another organization is already active!");
                }

            Console.WriteLine(_organizations.OfType<T>);  

            target.Activate();
        }

        public void AddOrganization(IOrganization organization)
        {
            if (_organizations.Any(o => o.GetType() == organization.GetType()))
                throw new InvalidOperationException("Organization is already added!");

            _organizations.Add(organization);
        }

        public void DeactivateOrganization<T>() where T : IOrganization
        {
            var target = _organizations.OfType<T>().FirstOrDefault();
            if (target == null)
                throw new InvalidOperationException("Organization not found!");

            foreach (var org in _organizations)
                if ((org.IsActive) && (org is T))
                {
                    target.Deactivate();
                }
        }

        public Player(string nickname)
        {
            Nickname = nickname;
            _organizations = new List<IOrganization>();
        }
        public Player(string nickname, int money)
        {
            Nickname = nickname;
            Money.AddMoney(money);
            _organizations = new List<IOrganization>();
        }
    }
}