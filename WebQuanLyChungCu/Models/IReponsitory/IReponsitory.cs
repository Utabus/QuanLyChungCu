namespace WebQuanLyChungCu.Models.IReponsitory
{
    public interface IReponsitory
    {
        IQueryable<Account> Accounts { get; }
        IQueryable<Address> Addresses { get; }
        IQueryable<Apartment> Apartments { get; }
        IQueryable<ApartmentService> ApartmentServices { get; }
        IQueryable<Building> Buildings { get; }
        IQueryable<Contract> Contracts { get; }
        IQueryable<ElectricMeter> ElectricMeters { get; }
        IQueryable<History> Histories { get; }
        IQueryable<InFo> InFos { get; }
        IQueryable<News> News { get; }
        IQueryable<Relationship> Relationships { get; }
        IQueryable<ResidentsRequired> ResidentsRequireds { get; }
        IQueryable<Revenue> Revenues { get; }
        IQueryable<Role> Roles { get; }
        IQueryable<Service> Services { get; }
        IQueryable<WaterMeter> WaterMeters { get; }
    }
}
