using Core.Entity;
using Infraestructure.Configuration;
using Infraestructure.Repository;
using Microsoft.EntityFrameworkCore;
using UnitTest.Infraestructure.Configuration;

namespace UnitTest.Infraestructure.Repository;
public class DirectDistanceDialingRepositoryTests
{
    private readonly DbContextOptions<DataContext> _options;

    public DirectDistanceDialingRepositoryTests()
    {
        // Use an in-memory database for testing
        _options = InMemoryDbOptionsFactory.CreateUniqueInMemoryOptions();
    }

    [Fact]
    public async Task GetAllAsync_ReturnsDirectDistanceDialings()
    {
        //Arrange
        using (var context = new DataContext(_options))
        {
            // Seed data
            var ddd1 = new DirectDistanceDialing { Id = 11, Region = "São Paulo", CreatedOn = DateTime.Now };
            var ddd2 = new DirectDistanceDialing { Id = 12, Region = "São Paulo", CreatedOn = DateTime.Now };
            var ddd3 = new DirectDistanceDialing { Id = 13, Region = "São Paulo", CreatedOn = DateTime.Now };
            context.DirectDistanceDialings.AddRange(ddd1, ddd2, ddd3);

            await context.SaveChangesAsync();

            var repository = new DirectDistanceDialingRepository(context);

            // Act
            var result = await repository.GetAllAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
            Assert.Contains(result, c => c.Id == 11);
            Assert.Contains(result, c => c.Id == 12);
            Assert.Contains(result, c => c.Id == 13);
        }
    }

    [Fact]
    public async Task GetByIdAsync_ExistingId_ReturnsDirectDistanceDialing()
    {
        using (var context = new DataContext(_options))
        {
            //Arrange
            var ddd1 = new DirectDistanceDialing { Id = 11, Region = "São Paulo", CreatedOn = DateTime.Now };
            context.DirectDistanceDialings.Add(ddd1);

            await context.SaveChangesAsync();

            var repository = new DirectDistanceDialingRepository(context);

            // Act
            var dddId = 11;
            var result = await repository.GetByIdAsync(dddId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(dddId, result.Id);
        }
    }

    [Fact]
    public async Task GetByIdAsync_NonExistingId_ReturnsNull()
    {
        using (var context = new DataContext(_options))
        {
            //Arrange
            var ddd1 = new DirectDistanceDialing { Id = 11, Region = "São Paulo", CreatedOn = DateTime.Now };
            context.DirectDistanceDialings.Add(ddd1);

            await context.SaveChangesAsync();

            var repository = new DirectDistanceDialingRepository(context);

            // Act
            var dddId = 999;
            var result = await repository.GetByIdAsync(dddId);

            // Assert
            Assert.Null(result);
        }
    }

    [Fact]
    public async Task CreateAsync_ValidEntity_AddsEntity()
    {
        using (var context = new DataContext(_options))
        {
            // Arrange
            var repository = new DirectDistanceDialingRepository(context);
            var ddd = new DirectDistanceDialing { Id = 11, Region = "São Paulo", CreatedOn = DateTime.Now };

            // Act
            await repository.CreateAsync(ddd);

            // Assert
            var result = await context.Set<DirectDistanceDialing>().FirstOrDefaultAsync(e => e.Id == 11);
            Assert.NotNull(result);
            Assert.Equal(11, result.Id);
        }
    }

    [Fact]
    public async Task EditAsync_ExistingEntity_UpdatesEntity()
    {
        using (var context = new DataContext(_options))
        {
            // Arrange
            var ddd = new DirectDistanceDialing { Id = 11, Region = "São Paulo", CreatedOn = DateTime.Now };
            context.Add(ddd);
            await context.SaveChangesAsync();

            var repository = new DirectDistanceDialingRepository(context);

            // Act
            ddd.Region = "São Paulo Upated";
            await repository.EditAsync(ddd);

            // Assert
            var result = await context.Set<DirectDistanceDialing>().FirstOrDefaultAsync(e => e.Id == 11);
            Assert.NotNull(result);
            Assert.Equal("São Paulo Upated", result.Region);
        }
    }

    [Fact]
    public async Task DeleteAsync_ExistingEntity_RemovesEntity()
    {
        using (var context = new DataContext(_options))
        {
            // Arrange
            var ddd = new DirectDistanceDialing { Id = 11, Region = "São Paulo", CreatedOn = DateTime.Now };
            context.Add(ddd);
            await context.SaveChangesAsync();

            var repository = new DirectDistanceDialingRepository(context);

            // Act
            await repository.DeleteAsync(ddd);

            // Assert
            var result = await context.Set<DirectDistanceDialing>().FirstOrDefaultAsync(e => e.Id == 11);
            Assert.Null(result);
        }
    }
}
