using System;
using MovementExample.Interfaces;

namespace MovementExample
{
    public class MoveCombo : IMovement
    {
        public MoveCombo()
        {
        }

        public string MoveName => "Up Up Down Down Combo Move";

        public MoveDirection MoveDirection => MoveDirection.Combo;
        
        public string Move()
        {
            return MoveName;
        }
    }
}
