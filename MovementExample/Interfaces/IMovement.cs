using System;
namespace MovementExample.Interfaces
{
    public interface IMovement
    {
        string MoveName { get; }
        MoveDirection MoveDirection { get; }
        string Move();
    }
}
