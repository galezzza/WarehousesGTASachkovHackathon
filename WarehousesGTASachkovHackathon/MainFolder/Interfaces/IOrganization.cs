namespace WarehousesGTASachkovHackathon.MainFolder.Interfaces
{
    public interface IOrganization
    {
        string Name { get; }
        bool IsActive { get; }
        void Activate();
        void Deactivate();
    }
}