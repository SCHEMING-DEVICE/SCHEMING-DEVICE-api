using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Scheming.Device.Data;

namespace Scheming.Device.Data;

public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
{
    public StoreContext CreatedContext(string[] args)
    (
        var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();
        optionsBuilder.UseSqlite("Data Sources=../Registrar.sqlite");

        return new StoreContext(OptionsBuilder.Options);
    ) 
}
