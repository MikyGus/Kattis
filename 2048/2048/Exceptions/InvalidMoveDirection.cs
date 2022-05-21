using System;

namespace _2048.Exceptions
{
    public class InvalidMoveDirection : Exception
    {
        public InvalidMoveDirection()
        {
        }

        public InvalidMoveDirection(int moveDirection)
            : base($"MoveDirection [{moveDirection}] is invalid.")
        {
        }

        public InvalidMoveDirection(int moveDirection, Exception innerException)
            : base($"MoveDirection [{moveDirection}] is invalid.", innerException)
        {
        }

        public InvalidMoveDirection(string errorMessage)
            : base(errorMessage)
        {
        }

        public InvalidMoveDirection(string errorMessage, Exception innerException)
            : base(errorMessage, innerException)
        {
        }
    }
}
