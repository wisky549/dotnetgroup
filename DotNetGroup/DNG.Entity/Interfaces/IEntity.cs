using System;

namespace DNG.Entity.Interfaces
{
    public interface IEntity
    {
        int Id { get; set; }

        DateTime Created { get; set; }
    }
}
