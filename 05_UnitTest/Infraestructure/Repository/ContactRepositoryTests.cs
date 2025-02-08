using Core.Entity;
using Infraestructure.Configuration;
using Infraestructure.Repository;
using Microsoft.EntityFrameworkCore;
using UnitTest.Infraestructure.Configuration;

namespace UnitTest.Infraestructure.Repository;
public class ContactRepositoryTests
{
    private readonly DbContextOptions<DataContext> _options;

    public ContactRepositoryTests()
    {
        // Use an in-memory database for testing
        _options = InMemoryDbOptionsFactory.CreateUniqueInMemoryOptions();
    }

    [Fact]
    public async Task GetAllByDddAsync_ValidDddId_ReturnsContacts()
    {
        // Arrange
        using (var context = new DataContext(_options))
        {
            // Seed data
            var ddd = new DirectDistanceDialing { Id = 11, Region = "São Paulo", CreatedOn = DateTime.Now };
            context.DirectDistanceDialings.Add(ddd);

            var contact1 = new Contact { Id = 1, Name = "Test User 1", Phone = "99983-1617", Email = "testUser1@gmail.com", DddId = ddd.Id };
            var contact2 = new Contact { Id = 2, Name = "Test User 2", Phone = "99983-1618", Email = "testUser2@gmail.com", DddId = ddd.Id };
            var unrelatedContact = new Contact { Id = 3, Name = "Test User 3", Phone = "99983-1618", Email = "testUser3@gmail.com", DddId = 21 };

            context.Contacts.AddRange(contact1, contact2, unrelatedContact);
            await context.SaveChangesAsync();

            var repository = new ContactRepository(context);

            // Act
            var result = await repository.GetAllByDddAsync(11);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Contains(result, c => c.Name == "Test User 1");
            Assert.Contains(result, c => c.Name == "Test User 2");
        }              
    }

    [Fact]
    public async Task GetAllByDddAsync_InvalidDddId_ReturnsEmptyList()
    {
        // Arrange
        using (var context = new DataContext(_options))
        {
            // Seed data
            var ddd = new DirectDistanceDialing { Id = 12, Region = "São Paulo", CreatedOn = DateTime.Now };
            context.DirectDistanceDialings.Add(ddd);

            var contact = new Contact { Id = 1, Name = "Test User 1", Phone = "99983-1617", Email = "testUser1@gmail.com", DddId = ddd.Id };
            context.Contacts.Add(contact);
            await context.SaveChangesAsync();

            var invalidDddId = 999;
            var repository = new ContactRepository(context);

            // Act
            var result = await repository.GetAllByDddAsync(invalidDddId);

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }        
    }
}
