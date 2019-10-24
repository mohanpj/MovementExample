using System;
using MovementExample.Interfaces;

namespace MovementExample
{
    public class MoveLeft : IMovement
    {
        public MoveLeft()
        {
        }

        public string MoveName => "Basic Left Move";

        public MoveDirection MoveDirection => MoveDirection.Left;
        
        public string Move()
        {
            return MoveName;
        }
    }
}
