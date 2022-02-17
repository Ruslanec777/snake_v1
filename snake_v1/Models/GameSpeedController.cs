using snake_v1.Enums;
using System.Threading;
using static snake_v1.Models.Direction;

namespace snake_v1.Models
{
    static class GameSpeedController
    {
        /// <summary>
        /// коэфициент замедления при вертикальном движении , задается подбором
        /// </summary>
        static public float correctionFactor = 3f;

        /// <summary>
        /// Пауза с коррекцией замедления вертикального движения
        /// </summary>
        /// <param name="pause"></param>
        /// <returns></returns>
        public static int ControlledPause(int pause = 150)
        {
            switch (currentDirection)
            {
                case MoveDirection.Up:
                    pause = (int)(pause * correctionFactor);
                    break;

                case MoveDirection.Down:
                    pause = (int)(pause * correctionFactor);
                    break;

                default:
                    break;
            }

            Thread.Sleep(pause);
            return pause;
        }

    }

}
