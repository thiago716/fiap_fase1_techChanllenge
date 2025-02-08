using Infraestructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace UnitTest.Infraestructure.Configuration;
public static class InMemoryDbOptionsFactory
{
    public static DbContextOptions<DataContext> CreateUniqueInMemoryOptions()
    {
        // Use an in-memory database for testing
        return new DbContextOptionsBuilder<DataContext>()
        .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()) // Unique database per test
        .Options;
    }
}
