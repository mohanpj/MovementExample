using System;
using MovementExample.Interfaces;

namespace MovementExample
{
    public class MoveDown : IMovement
    {
        public MoveDown()
        {
        }

        public string MoveName => "Basic Down Move";

        public MoveDirection MoveDirection => MoveDirection.Down;
        
        public string Move()
        {
            return MoveName;
        }
    }
}
