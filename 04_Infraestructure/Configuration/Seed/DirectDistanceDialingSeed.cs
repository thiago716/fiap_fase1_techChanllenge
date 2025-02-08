using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Configuration.Seed;
public static class DirectDistanceDialingSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DirectDistanceDialing>().HasData(

            // São Paulo
            new DirectDistanceDialing { Id = 11, Region = "São Paulo" },
            new DirectDistanceDialing { Id = 12, Region = "São Paulo" },
            new DirectDistanceDialing { Id = 13, Region = "São Paulo" },
            new DirectDistanceDialing { Id = 14, Region = "São Paulo" },
            new DirectDistanceDialing { Id = 15, Region = "São Paulo" },
            new DirectDistanceDialing { Id = 16, Region = "São Paulo" },
            new DirectDistanceDialing { Id = 17, Region = "São Paulo" },
            new DirectDistanceDialing { Id = 18, Region = "São Paulo" },
            new DirectDistanceDialing { Id = 19, Region = "São Paulo" },

            // Rio de Janeiro
            new DirectDistanceDialing { Id = 21, Region = "Rio de Janeiro" },
            new DirectDistanceDialing { Id = 22, Region = "Rio de Janeiro" },
            new DirectDistanceDialing { Id = 24, Region = "Rio de Janeiro" },

            // Espírito Santo
            new DirectDistanceDialing { Id = 27, Region = "Espírito Santo" },
            new DirectDistanceDialing { Id = 28, Region = "Espírito Santo" },

            // Minas Gerais
            new DirectDistanceDialing { Id = 31, Region = "Minas Gerais" },
            new DirectDistanceDialing { Id = 32, Region = "Minas Gerais" },
            new DirectDistanceDialing { Id = 33, Region = "Minas Gerais" },
            new DirectDistanceDialing { Id = 34, Region = "Minas Gerais" },
            new DirectDistanceDialing { Id = 35, Region = "Minas Gerais" },
            new DirectDistanceDialing { Id = 37, Region = "Minas Gerais" },
            new DirectDistanceDialing { Id = 38, Region = "Minas Gerais" },

            // Paraná
            new DirectDistanceDialing { Id = 41, Region = "Paraná" },
            new DirectDistanceDialing { Id = 42, Region = "Paraná" },
            new DirectDistanceDialing { Id = 43, Region = "Paraná" },
            new DirectDistanceDialing { Id = 44, Region = "Paraná" },
            new DirectDistanceDialing { Id = 45, Region = "Paraná" },
            new DirectDistanceDialing { Id = 46, Region = "Paraná" },

            // Santa Catarina
            new DirectDistanceDialing { Id = 47, Region = "Santa Catarina" },
            new DirectDistanceDialing { Id = 48, Region = "Santa Catarina" },
            new DirectDistanceDialing { Id = 49, Region = "Santa Catarina" },

            // Rio Grande do Sul
            new DirectDistanceDialing { Id = 51, Region = "Rio Grande do Sul" },
            new DirectDistanceDialing { Id = 53, Region = "Rio Grande do Sul" },
            new DirectDistanceDialing { Id = 54, Region = "Rio Grande do Sul" },
            new DirectDistanceDialing { Id = 55, Region = "Rio Grande do Sul" },

            // Distrito Federal
            new DirectDistanceDialing { Id = 61, Region = "Distrito Federal" },

            // Goiás
            new DirectDistanceDialing { Id = 62, Region = "Goiás" },
            new DirectDistanceDialing { Id = 64, Region = "Goiás" },

            // Mato Grosso
            new DirectDistanceDialing { Id = 65, Region = "Mato Grosso" },
            new DirectDistanceDialing { Id = 66, Region = "Mato Grosso" },

            // Mato Grosso do Sul
            new DirectDistanceDialing { Id = 67, Region = "Mato Grosso do Sul" },

            // Alagoas
            new DirectDistanceDialing { Id = 82, Region = "Alagoas" },

            // Bahia
            new DirectDistanceDialing { Id = 71, Region = "Bahia" },
            new DirectDistanceDialing { Id = 73, Region = "Bahia" },
            new DirectDistanceDialing { Id = 74, Region = "Bahia" },
            new DirectDistanceDialing { Id = 75, Region = "Bahia" },
            new DirectDistanceDialing { Id = 77, Region = "Bahia" },

            // Ceará
            new DirectDistanceDialing { Id = 85, Region = "Ceará" },
            new DirectDistanceDialing { Id = 88, Region = "Ceará" },

            // Maranhão
            new DirectDistanceDialing { Id = 98, Region = "Maranhão" },
            new DirectDistanceDialing { Id = 99, Region = "Maranhão" },

            // Paraíba
            new DirectDistanceDialing { Id = 83, Region = "Paraíba" },

            // Pernambuco
            new DirectDistanceDialing { Id = 81, Region = "Pernambuco" },
            new DirectDistanceDialing { Id = 87, Region = "Pernambuco" },

            // Piauí
            new DirectDistanceDialing { Id = 86, Region = "Piauí" },
            new DirectDistanceDialing { Id = 89, Region = "Piauí" },

            // Rio Grande do Norte
            new DirectDistanceDialing { Id = 84, Region = "Rio Grande do Norte" },

            // Sergipe
            new DirectDistanceDialing { Id = 79, Region = "Sergipe" }
        );
    }
}