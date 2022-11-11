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
            // Задача 66: Задайте значения M и N.
            Console.Write( "\nЗадача 66: Задайте значения M и N. " );
            // Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            Console.WriteLine( "Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\n" );


            // Рекурсивная сумма от до с шагом == 1
            int NumbersSum( int min_number, int max_number ) {
                if ( min_number == max_number )
                    return min_number;
                else
                    return min_number + NumbersSum( ++min_number, max_number );
            }


            int M = ConsoleInputInt32( min_value: 1, message: "Введите положительное целое число = " );
            int N = ConsoleInputInt32( min_value: 1, message: "Введите положительное целое число = " );

            Console.Write( "\nСумму натуральных целых чисел в промежутке от M до N включительно " );
            Console.WriteLine( $"M = {M}; N = {N} -> { NumbersSum( Math.Min(M, N), Math.Max(M, N) ) }\n" );
        }
    }
}