using Core.Entity.Base;

namespace Core.Entity;
public class Contact : BaseEntity
{
    public required string Name { get; set; }
    public required string Phone { get; set; }
    public required string Email { get; set; }
    public required int DddId { get; set; }

    public virtual DirectDistanceDialing? Ddd { get; set; }
}
