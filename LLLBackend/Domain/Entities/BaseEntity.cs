using System.ComponentModel.DataAnnotations;

namespace HoteLLLBackend.Domain.Entities;

public abstract class BaseEntity<TKeyType>
{
    protected BaseEntity(TKeyType id = default)
    {
        
        Id = id;
    }

    [Key]
    public TKeyType Id { get; }
}