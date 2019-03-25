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
            String text = ("Привет," + name + " Я помогу выбрать тебе мультик на вечер!");
            Console.WriteLine("Привет, " + name + "! Я помогу выбрать тебе мультик на вечер!");
            
            Console.WriteLine("Какой мультик ты хочешь посмотреть весёлый, добрый, музыкальный, поучительный или сказку?");
            
            String genre = Console.ReadLine();
             
            if (genre == "весёлый")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Тогда посоветую вот такие:");
                Console.WriteLine("Ну, погоди!");
                Console.WriteLine("Простоквашино.");
                Console.WriteLine("Бобик в гостях у Барбоса.");

                //searchFilm = "Простоквашино"; //переделать на выбранный фильм
            }
            
            else if (genre == "добрый")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Тогда посоветую вот такие:");
                Console.WriteLine("Девочка и спички"); 
                Console.WriteLine("Дюймовочка");
            }
            
            else if (genre == "музыкальный")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Тогда посоветую вот такие:");
                Console.WriteLine("Бременские музыканты.");
                Console.WriteLine("Летучий корабль.");
            } 
            
            else if (genre == "поучительный")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Тогда посоветую вот такие:");
                Console.WriteLine("Тётушка Сова.");
                Console.WriteLine("Фиксики.");
                Console.WriteLine("Смешарики. Пин-код.");
            }
           
            else         
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Аленький цветочек.");
                Console.WriteLine("Гора самоцветов.");
                Console.WriteLine("Конёк-горбунок.");    
            }
                                              
            Console.WriteLine("Какой из этих мультфильмов тебе найти?");
            var searchFilm = Console.ReadLine();         
            Process.Start("open", $"https://www.google.com/search?q={searchFilm}"); //интерполяция строк
                
            
            Console.ReadLine();
        }
    }
}