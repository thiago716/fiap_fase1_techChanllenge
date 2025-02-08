using Application.Service;
using Core.Entity;
using Core.Repository.Interface;
using Moq;

namespace UnitTest.Application.Service;
public class DirectDistanceDialingServiceTests
{
    private readonly Mock<IDirectDistanceDialingRepository> _mockDddRepository;
    private readonly DirectDistanceDialingService _directDistanceDialingService;

    public DirectDistanceDialingServiceTests()
    {
        _mockDddRepository = new Mock<IDirectDistanceDialingRepository>();
        _directDistanceDialingService = new DirectDistanceDialingService(_mockDddRepository.Object);
    }

    [Fact]
    public async Task GetAllAsync_ReturnsAllDirectDistanceDialing()
    {
        // Arrange
        var ddds = new List<DirectDistanceDialing>
        {
            new() { Id = 11, Region = "São Paulo", CreatedOn = DateTime.Now },
            new() { Id = 21, Region = "Rio de Janeiro", CreatedOn = DateTime.Now },
            new() { Id = 51, Region = "Rio Grande do Sul", CreatedOn = DateTime.Now },
        };

        _mockDddRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(ddds);

        // Act
        var result = await _directDistanceDialingService.GetAllAsync();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(3, result.Count);
    }

    [Fact]
    public async Task GetByIdAsync_ExistingId_ReturnsDirectDistanceDialing()
    {
        // Arrange
        int dddId = 11;
        var ddd = new DirectDistanceDialing { Id = 11, Region = "São Paulo", CreatedOn = DateTime.Now };

        _mockDddRepository.Setup(repo => repo.GetByIdAsync(dddId)).ReturnsAsync(ddd);

        // Act
        var result = await _directDistanceDialingService.GetByIdAsync(dddId);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(dddId, result.Id);
    }

    [Fact]
    public async Task GetByIdAsync_NonExistingId_ReturnsNull()
    {
        // Arrange
        int dddId = 999;

        _mockDddRepository.Setup(repo => repo.GetByIdAsync(dddId)).ReturnsAsync(value: null);

        // Act
        var result = await _directDistanceDialingService.GetByIdAsync(dddId);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public async Task CreateAsync_ValidEntity_CallsRepositoryCreate()
    {
        // Arrange
        var newDdd = new DirectDistanceDialing { Id = 21, Region = "Rio de Janeiro", CreatedOn = DateTime.Now };

        _mockDddRepository.Setup(repo => repo.CreateAsync(newDdd)).Returns(Task.CompletedTask);

        // Act
        await _directDistanceDialingService.CreateAsync(newDdd);

        // Assert
        _mockDddRepository.Verify(repo => repo.CreateAsync(newDdd), Times.Once);
    }

    [Fact]
    public async Task EditAsync_ValidEntity_CallsRepositoryEdit()
    {
        // Arrange
        var existingDdd = new DirectDistanceDialing { Id = 51, Region = "Rio Grande do Sul", CreatedOn = DateTime.Now };
        _mockDddRepository.Setup(repo => repo.EditAsync(existingDdd)).Returns(Task.CompletedTask);

        // Act
        await _directDistanceDialingService.EditAsync(existingDdd);

        // Assert
        _mockDddRepository.Verify(repo => repo.EditAsync(existingDdd), Times.Once);
    }

    [Fact]
    public async Task DeleteAsync_ValidEntity_CallsRepositoryDelete()
    {
        // Arrange
        var dddToDelete = new DirectDistanceDialing { Id = 51, Region = "Rio Grande do Sul", CreatedOn = DateTime.Now };
        _mockDddRepository.Setup(repo => repo.DeleteAsync(dddToDelete)).Returns(Task.CompletedTask);

        // Act
        await _directDistanceDialingService.DeleteAsync(dddToDelete);

        // Assert
        _mockDddRepository.Verify(repo => repo.DeleteAsync(dddToDelete), Times.Once);
    }
}
