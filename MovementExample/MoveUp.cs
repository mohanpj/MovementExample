using System;
using MovementExample.Interfaces;

namespace MovementExample
{
    public class MoveUp : IMovement
    {
        public MoveUp()
        {
        }

        public string MoveName => "Basic Up Move";

        public MoveDirection MoveDirection => MoveDirection.Up;
        
        public string Move()
        {
            return MoveName;
        }
    }
}
