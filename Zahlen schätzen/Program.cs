using System;

namespace Zahlen_schätzen
{
    class Program
    {
        static void Main(string[] args)
        {
            int Zahl, Eingabe;
            // Erzeugt ein Objekt in der Klasse Random, die von C# zur Verfügung gestellt wird
            // Alle in der Klasse Random definierten Methoden können jetzt für das Objekt Zufall genutzt werden
            Random Zufall = new Random();
           
            // Die Methode Next aus der Klasse Random wird mit
            // dem Parameter 1000 durch das Objekt Zufall ausgeführt
            // Das Ergebnis wird der Variablen Zahl zugewiesen.
            // Bei einer Zuweisung steht immer links eine Variable
            // gefolgt von einem Gleichheitszeichen als Zuweisungsoperator.
            // Rechts steht entweder ein Wert oder etwas Komplizierteres.
            // Das kann ein Formel aus mehreren Variablen oder ein Methode sein.
            Zahl = Zufall.Next(1000)+1;

            // Die Methode WriteLine aus der Klasse Console wird ausgeführt.
            // Sie gibt keinen Wert zurück und wird daher auch als Prozedur bezeichnet
            Console.WriteLine("Ich denke mir eine Zahl zwischen 1 und 1000");

            // do - while ist eine Kontrollfunktion, die auch als
            // Schleife bezeichnet wird. Sie wird so lange ausgeführt, wie die
            // Bedingung erfüllt ist. Die Bedingung steht am Ende der Schleife
            // hinter While.
            do
            {
                Console.WriteLine("Rate Mal:");
                // Der Variable Eingabe wird die eingegebene Zahl zugewiesen.
                // Console.ReadLine() gibt immer einen String zurück.
                // int = string geht nicht. Daher muss konvertiert werden.
                // ToInt32 ist eine Methode aus der Klasse Convert.
                // Da sie einen Wert zurückgibt ist sie - ebenso wie ReadLine - eine Funktion
                // Funktionen und Prozeduren sind beides Methoden
                Eingabe = Convert.ToInt32 (Console.ReadLine());
                // if ist ebenfalls eine Kontrollstrukturen, aber eine Verzweigung.
                // Ist die Bedingung in der Klammer erfüllt, wird die 
                // nachfolgende Methode ausgeführt... hier WriteLine()
                if (Eingabe < Zahl)
                    Console.WriteLine("Zu klein!");
                if (Eingabe > Zahl)
                    Console.WriteLine("Zu groß!");
            } while (Eingabe != Zahl);

            // Wenn die Zahl richtig ist, ist die Bedingung für While nicht mehr erfüllt
            // und das Programm verlässt die do-while-Schleife. Logischerweise ist
            // dann die folgende Bedingung erfüllt und das Wort "Richtig" erscheint.
            if (Eingabe == Zahl)
                Console.WriteLine("Super... das war richtig!");

            // Diese Zeile bewirkt, dass das Programm anhält, bis eine Taste gedrückt wird.
            // Erst dann wird das Programm beendet und das Console-Fenster geschlossen.
            Console.ReadKey();

        }
    }
}