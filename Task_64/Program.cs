namespace Console_Program
{
    class Project
    {
        /// <summary>Выводит сообщение в консоль, проверяет и преобразует пользовательский ввод.</summary>
        /// <param name="min_value">Нижняя граница диапозона чисел</param>
        /// <param name="max_value">Верхняя граница диапозона чисел</param>
        /// <param name="message">Выводимое в консоль сообщение</param>
        /// <returns>Число типа Int32</returns>
        public static int ConsoleInputInt32( int min_value=-1000000, int max_value=1000000, string message="Введите целое число: " ) {
            int result = 0; 

            while ( true ) {
                Console.Write( message );

                if ( int.TryParse( Console.ReadLine() ?? "", out result ) )
                    if ( result >= min_value && result <= max_value )
                        break;

                Console.WriteLine( "[!] Вы ввели не верные данные!\n" );
            }
            return result; 
        }


        private static void Main( string[] args ) {
            // Задача 64: Задайте значение N.
            Console.Write( "\nЗадача 64: Задайте значение N. " );
            // Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
            Console.WriteLine( "Напишите программу, которая выведет все натуральные числа в промежутке от N до 1, с помощью рекурсии.\n" );


            // Функция вывода в консоль с вызовом самой себя...
            void ConsoleSeparateWrite( int some_number ) {
                if ( some_number == 1 )
                    Console.Write( some_number );
                else {
                    Console.Write( $"{ some_number }, " );
                    ConsoleSeparateWrite( --some_number );
                }
            }


            int N = ConsoleInputInt32( min_value: 2, message: "Введите положительное целое число = " );

            Console.Write( $"\nN = { N } -> \"" );
            ConsoleSeparateWrite( N );
            Console.WriteLine( "\"\n" );
        }
    }
}
