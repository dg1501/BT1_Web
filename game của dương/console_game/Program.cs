using System;
using Game;   // namespace DLL

namespace console_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng từ DLL (Class1 chính là engine game)
            Class1 engine = new Class1();

            Console.WriteLine("=== Typing Attack Console Test ===");

            while (true)
            {
                Console.Write("Nhập từ (hoặc exit để thoát): ");
                string word = Console.ReadLine();

                if (word.ToLower() == "exit")
                    break;

                GameState state = engine.GetState(word);

                Console.WriteLine("Điểm: " + state.Score);
                Console.WriteLine("Kẻ địch: " + string.Join(", ", state.Enemies));
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
