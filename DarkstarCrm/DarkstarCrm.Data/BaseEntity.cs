using DarkstarCrm.Repository.Interfaces;

namespace DarkstarCrm.Data
{
    public abstract class BaseEntity : IBaseEntity
    {
       public virtual int Id { get; set; }
    }
}