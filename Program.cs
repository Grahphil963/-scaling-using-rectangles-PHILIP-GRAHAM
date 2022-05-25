using System;

namespace Lesson_2_scaling_using_rectangles_PHILIP_GRAHAM
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
                game.Run();
        }
    }
}
