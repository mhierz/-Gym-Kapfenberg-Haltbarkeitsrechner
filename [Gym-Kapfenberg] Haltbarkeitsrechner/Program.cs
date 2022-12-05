namespace _Gym_Kapfenberg__Haltbarkeitsrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Aufgabenstellung:
             * Ein bestimmtes Arzneimittel verliert jeden Monat seinen Wirkstoffgehalt um einen bestimmten Prozentwert.
             * Wenn sein Wirkstoffgehalt unter 50% fällt, muss es ausgemustert werden.
             * Wir schreiben ein Programm, das berechnet wie viele Monate eine Arznei gelagert werden kann.
             */

            double decrease = 0.0;
            double actualContent = 100;
            int month = 0;
            

            Console.Write("Wieviel Wirkstoffverlust hat das Medikament pro Monat [in Prozent]: ");
            decrease = Convert.ToDouble(Console.ReadLine());

            // Füge hier die Berechnung des Wirkstoffgehalts mithilfe einer While-Schleife ein
            // Verwende zur Ausgabe diese Anweisung: 
            // Console.WriteLine("Monat: " + month + "\tWirkstoffgehalt: " + actualContent);

            
            //=================================================================================

            Console.WriteLine("ABGELAUFEN");
        }
    }
}