using System;

namespace MovementExample.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var movementHandler = new MovementHandler();
            var result = movementHandler.Move(MoveDirection.Up);
            Console.WriteLine(result);

            Console.WriteLine(movementHandler.Move(MoveDirection.Down));
            Console.WriteLine(movementHandler.Move(MoveDirection.Left));
            Console.WriteLine(movementHandler.Move(MoveDirection.Right));
            Console.WriteLine(movementHandler.Move(MoveDirection.Combo));
            Console.ReadKey();
        }
    }
}
