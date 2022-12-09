using System.Reflection;

namespace _Gym_Kapfenberg__Haltbarkeitsrechner
{
    internal class Program

    /* Aufgabenstellung 1:
     * Ein bestimmtes Arzneimittel verliert jeden Monat seinen Wirkstoffgehalt um einen bestimmten Prozentwert.
     * Wenn sein Wirkstoffgehalt unter 50% fällt, muss es ausgemustert werden.
     * Wir schreiben ein Programm, das berechnet wie viele Monate eine Arznei gelagert werden kann.
     */

    /* Aufgabenstellung 2:
     * Erweitere das Programm so, dass am Ende (nach der Berechnung)
     * der Benutzer gefragt wird, ob das Programm neustarten soll.
     * Sollte mit (Ja || j || J || ja) geantwortet werden, wiederhole das Programm.
     */

    /* Task 1:
     * A certain medidicine loses its potency by a certain percentage every month.
     * If its potency drops below 50%, it must be discarded.
     * Write a program that calculates how many months a medicine can be stored.
     */

    /* Aufgabenstellung 2:
     * Extend the program in such a way that at the end (after the calculation)
     * the user gets asked whether the program should be restarted.
     * If the answer is (yes || y || Y || Yes), repeat the program.
     */

    /* Syntax of a head driven while loop
     * while (condition)
     * {
     *  //Here the code which gets looped
     * }
     */

    /* Syntax of a foot controlled do-while loop
     * do
     * {
     *  //Here the code which gets looped
     * } while (condition)
     */

    // Formel zur Berechnung des neuen Wirkstoffgehalts: Wirkstoffgehalt = Wirkstoffgehalt * (1 - (Wirkstoffverlust / 100))
    // Formular for calculation of the new potency: Potency = Potency * (1 - (Decrease / 100))

    {
        static void Main(string[] args)
        {
            string? input = string.Empty; //Variable zum Einlesen eines Inputs
            double decrease = 0.0; //Diese Variable beinhaltet den Prozentwert (in Prozent), welcher angibt, wieviel Prozent des Wirkstoffs pro Monat verloren geht
            double actualContent = 100; //Diese Variable beinhaltet den aktuellen Wirkstoffgehalt der Arznei (in Prozent)
            int month = 0; //Diese Variable beinhaltet den aktuellen Monat der Berechnung
            

            Console.Write("Wieviel Wirkstoffverlust hat das Medikament pro Monat [in Prozent]: "); //Mit Console.Write() wird Text auf der Konso le ausgegeben
            input = Console.ReadLine(); //Mit Console.ReadLine() wird der eingebene Text eingelesen und im string input gespeichert
            decrease = Convert.ToDouble(input); //Der in der Variable input gespeicherte Text wird in ein double konvertiert


            //Write here your code for task 1

            Console.WriteLine("ABGELAUFEN");
        }
    }
}