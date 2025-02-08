using Microsoft.EntityFrameworkCore;
using Infraestructure.Configuration.Seed;

namespace Infraestructure.Configuration.Extension;
public static class ModelBuilderExtension
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        DirectDistanceDialingSeed.Seed(modelBuilder);
    }
}
