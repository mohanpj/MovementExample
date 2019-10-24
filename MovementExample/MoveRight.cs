using System;
using MovementExample.Interfaces;

namespace MovementExample
{
    public class MoveRight : IMovement
    {
        public MoveRight()
        {
        }

        public string MoveName => "Basic Right Move";

        public MoveDirection MoveDirection => MoveDirection.Right;
        
        public string Move()
        {
            return MoveName;
        }
    }
}
