namespace WebQuanLyChungCu.Models.IReponsitory
{
    public class EFReponsitory : IReponsitory
    {
        private QUANLYCHUNGCUContext _context;
        public EFReponsitory(QUANLYCHUNGCUContext ctx)
        {
            _context = ctx;
        }
        public IQueryable<Account> Accounts => _context.Accounts;
        public IQueryable<Address> Addresses => _context.Addresses;
        public IQueryable<Apartment> Apartments => _context.Apartments;
        public IQueryable<ApartmentService> ApartmentServices => _context.ApartmentServices;
        public IQueryable<Building> Buildings => _context.Buildings;
        public IQueryable<Contract> Contracts => _context.Contracts;
        public IQueryable<ElectricMeter> ElectricMeters => _context.ElectricMeters;
        public IQueryable<History> Histories => _context.Histories;
        public IQueryable<InFo> InFos => _context.InFos;
        public IQueryable<News> News => _context.News;
        public IQueryable<Relationship> Relationships => _context.Relationships;
        public IQueryable<ResidentsRequired> ResidentsRequireds => _context.ResidentsRequireds;
        public IQueryable<Revenue> Revenues => _context.Revenues;
        public IQueryable<Role> Roles => _context.Roles;
        public IQueryable<Service> Services => _context.Services;
        public IQueryable<WaterMeter> WaterMeters => _context.WaterMeters;
    }
}
