using System;
using System.Collections.Generic;
using MovementExample.Interfaces;

namespace MovementExample
{
    public class MovementHandler
    {
        private readonly IDictionary<MoveDirection, IMovement> _movementMapper;

        public MovementHandler()
        {
            _movementMapper = new Dictionary<MoveDirection, IMovement>
            {
                { MoveDirection.Up, new MoveUp() },
                { MoveDirection.Down, new MoveDown() },
                { MoveDirection.Left, new MoveLeft() },
                { MoveDirection.Right, new MoveRight() },
                { MoveDirection.Combo, new MoveCombo() },
            };
        }

        public string Move(MoveDirection moveDirection)
        {
            return _movementMapper[moveDirection].Move();
        }
    }
}
