using System;
using System.Diagnostics;

namespace what_watch_today
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как тебя зовут?");
            String name = Console.ReadLine();

            Console.WriteLine("\nПривет, " + name + "! Я помогу выбрать тебе мультик на вечер!");
            
            Console.WriteLine("\nКакой мультик ты хочешь посмотреть весёлый, добрый, музыкальный, поучительный или сказку?");
            
            String genre = Console.ReadLine();
            genre = genre.ToLower();
            
           
            if (genre == "весёлый")
            {
                Console.WriteLine("Тогда посоветую вот такие:");
                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ну, погоди!");
                Console.WriteLine("Простоквашино.");
                Console.WriteLine("Бобик в гостях у Барбоса.");

                //searchFilm = "Простоквашино"; //переделать на выбранный фильм
            }
            
            else if (genre == "добрый")
            {
                Console.WriteLine("Тогда посоветую вот такие:");
                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Девочка и спички."); 
                Console.WriteLine("Дюймовочка.");
            }
            
            else if (genre == "музыкальный")
            {
                Console.WriteLine("Тогда посоветую вот такие:");
                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Бременские музыканты.");
                Console.WriteLine("Летучий корабль.");
            } 
            
            else if (genre == "поучительный")
            {
                Console.WriteLine("Тогда посоветую вот такие:");
                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Тётушка Сова.");
                Console.WriteLine("Фиксики.");
                Console.WriteLine("Смешарики. Пин-код.");
            }
           
            else         
            {
                //Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Тогда посоветую вот такие:");
                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Аленький цветочек.");
                Console.WriteLine("Гора самоцветов.");
                Console.WriteLine("Конёк-горбунок.");    
            }
            
            Console.ResetColor();
            
            Console.WriteLine("\nКакой из этих мультфильмов тебе найти?");
            
            var searchFilm = Console.ReadLine();
            searchFilm = searchFilm.ToLower();
            
            Process.Start("open", $"https://www.google.com/search?q=\"{searchFilm}\""); //интерполяция строк
            
            Console.ReadLine();
        }
    }
}