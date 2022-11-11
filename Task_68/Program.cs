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
            // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
            Console.WriteLine( "\nЗадача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.\n" );


            // Функция Вильгельма Аккермана
            long Ackermann( long m, long n) {
                if ( m == 0 )
                    return n + 1;
                else if ( m > 0  && n == 0 )
                    return Ackermann( m - 1, 1 );
                else if ( m > 0 && n > 0 )
                    return Ackermann( m - 1, Ackermann( m, n - 1 ) );
                else
                    return n + 1;
            }

            Console.WriteLine( "Первое число укажите, желательно, не больше 3... если что, вас предупредили)))" );

            int M = ConsoleInputInt32( min_value: 0, max_value: 9, message: "Введите положительное целое число = " );
            int N = ConsoleInputInt32( min_value: 0, message: "Введите положительное целое число = " );

            Console.WriteLine( $"\nРезультат выполнения функции M = {M}, N = {N} -> A(m,n) = { Ackermann( M, N ) }\n" );
        }
    }
}