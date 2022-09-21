using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhArrayListDemos
{
    internal class Application
    {

        public void Run()
        {

            //HANGMAN

            Console.WriteLine("Välj ett ord! Den som spelar tittar bort!");
            Console.Write("Skriv in ordet: ");
            var secretWord = Console.ReadLine().ToUpper();

            var guessTheWord = secretWord.Replace(secretWord,"_");

            Console.Clear();

            Console.WriteLine($"Ord:{guessTheWord}");

















            //LIST 7


            //var userValue = 0.0m;
            //var smallestValue = 0.0m;
            //var biggestValue = 0.0m;
            //var avgValue = 0.0m;
            //var arrayItems = 0;
            //var platsCounter = 0;
            //var temperaturer = new List<decimal>();
            //var temperaturPlats = new List<string>();

            //Console.WriteLine("Hur många temperaturmätningar ska registreras?");

            //var numberOfTemps = Convert.ToInt32(Console.ReadLine());

            

            //for (int i = 0; i < numberOfTemps; i++)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Skriv in temperatur i °C:");
            //    userValue = Convert.ToDecimal(Console.ReadLine());
            //    temperaturer.Add(userValue);

            //    Console.Clear();
            //    Console.WriteLine("Skriv in mätplats:");
            //    temperaturPlats.Add(Console.ReadLine());
            //}



            //Console.Clear();
            //smallestValue = temperaturer[0];
            //biggestValue = temperaturer[0];
            //foreach (decimal temp in temperaturer)
            //{
            //    if (temp < smallestValue)
            //        smallestValue = temp;

            //    if (temp > biggestValue)
            //        biggestValue = temp;

            //    avgValue += temp;
                
            //    Console.WriteLine($"{temp}°C {temperaturPlats[0 + platsCounter]} ");
            //    platsCounter++;
            //    arrayItems++;
            //}



            //Console.WriteLine(" ");
            //Console.WriteLine($"Min:{smallestValue}°C Max:{biggestValue}°C Medelvärde: {avgValue / arrayItems}°C ");



























            //ARRAY 6

            //Console.WriteLine("Hur många temperaturmätningar ska registreras?");

            //decimal[] temperaturer = new decimal[Convert.ToInt32(Console.ReadLine())];

            //Console.WriteLine("Skriv in temperaturerna:");

            //var userValue = 0.0m;
            //var smallestValue = 0.0m;
            //var biggestValue = 0.0m;
            //var avgValue = 0.0m;
            //var arrayItems = 0;

            //for (int i = 0; i < temperaturer.Length; i++)
            //{
            //    userValue = Convert.ToDecimal(Console.ReadLine());
            //    temperaturer[i] = userValue;
            //}


            //Console.Clear();
            //smallestValue = temperaturer[0];
            //biggestValue = temperaturer[0];
            //foreach (decimal temp in temperaturer)
            //{
            //    if (temp < smallestValue)
            //        smallestValue = temp;


            //    if (temp > biggestValue)
            //        biggestValue = temp;

            //    avgValue += temp;
            //    arrayItems++;
            //    Console.WriteLine($"{temp}");

            //}


            //Console.WriteLine($"Min:{smallestValue} Max:{biggestValue} Medel: {avgValue / arrayItems} ");


            //LIST 5

            //var numberList = new List<int>() { 23, 1, 5, 10, 7, 333, 500, 3, 23, 5 };
            //var counter = 0;

            //for (int i = 0; i < numberList.Count; i++)
            //{
            //    if (counter % 2 == 0)
            //        numberList[i] = 0;

            //    counter++;
            //    Console.WriteLine($"{numberList[i]}");

            //}






            //LIST 4

            //var allaTal = new List<int>();
            //var antalTal = 0;
            //var sum = 0;
            //var avgValue = 0.0m;
            //var smallestValue = 0;
            //var biggestValue = 0;

            //while (true)
            //{
            //    Console.WriteLine("Mata in ett tal - sktiv N för att avsluta:");
            //    var inmatning = Console.ReadLine();

            //    if (inmatning.ToLower() == "n")
            //    {
            //        smallestValue = allaTal[0];
            //        biggestValue = allaTal[0];
            //        foreach (var number in allaTal)
            //        {
            //            sum += number;
            //            if (number < smallestValue)
            //                smallestValue = number;

            //            if (number > biggestValue)
            //                biggestValue = number;

            //        }
            //        avgValue = Convert.ToDecimal(sum) / antalTal;

            //        Console.WriteLine($"Du matade in {antalTal} tal");
            //        Console.WriteLine($"Summan är {sum}");
            //        Console.WriteLine($"Medelvärdet är {avgValue}");
            //        Console.WriteLine($"Min:{smallestValue} Max:{biggestValue}");

            //        break;

            //    }


            //    int talet = Convert.ToInt32(inmatning);

            //    allaTal.Add(talet);
            //    antalTal++;

            //}


            //HOCKEYPROGRAM


            //var allLegendaryPlayers = new List<string>();


            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("1. Lista alla spelare");
            //    Console.WriteLine("2. Skapa nya spelare");
            //    Console.WriteLine("3. Ta bort spelare");
            //    Console.WriteLine("4. Ändra spelare");
            //    Console.WriteLine("5. Exit");
            //    Console.WriteLine("Ange val");
            //    var selection = Console.ReadLine();

            //    if (selection == "1")
            //    {
            //        foreach (string namn in allLegendaryPlayers)
            //        {

            //            Console.WriteLine(namn);

            //        }
            //        Console.ReadKey();
            //    }

            //    if (selection == "2")
            //    {
            //        Console.WriteLine("Ange namn på nya spelare:");
            //        var namn = Console.ReadLine();
            //        allLegendaryPlayers.Add(namn);

            //    }

            //    if (selection == "3")
            //    {
            //        var index = 0;
            //        foreach (var namn in allLegendaryPlayers)
            //        {
            //            index++;
            //            Console.WriteLine($"{index} {namn} ");
            //        }

            //        Console.WriteLine("Skriv in nummer på spelare du vill ta bort");

            //        var nummer = Convert.ToInt32(Console.ReadLine());

            //        allLegendaryPlayers.RemoveAt(nummer - 1);

            //    }

            //    if (selection == "4")
            //    {

            //        var index = 0;
            //        foreach (var namn in allLegendaryPlayers)
            //        {
            //            index++;
            //            Console.WriteLine($"{index} {namn} ");
            //        }

            //        Console.WriteLine("Skriv in nummer på spelare du vill ändra");

            //        var nummer = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("Ange namn");

            //        var nyttNamn = Console.ReadLine();

            //        allLegendaryPlayers[nummer - 1] = nyttNamn;
            //    }


            //}



            //LIST 3

            //var stringList = new List<string>() { "Kalle", "aa", "ada", "Nisse" };
            //var antal = 0;

            //foreach (var s in stringList)
            //    if (s.Length >= 2 && s[0] == s[s.Length - 1])
            //        antal++;
            //        Console.WriteLine($"Antal: {antal}");







            //ARRAY 2

            //Console.WriteLine("Hur många tal ska matas in?");

            //int[] arrayOfNumbers = new int[Convert.ToInt32(Console.ReadLine())];

            //Console.WriteLine($"Skriv in {arrayOfNumbers.Length} tal: ");

            //for (int i = 0; i < arrayOfNumbers.Length; i++)
            //    arrayOfNumbers[i] = Convert.ToInt32(Console.ReadLine());

            //var sum = 0;
            //foreach (var number in arrayOfNumbers)
            //    sum += number;

            //Console.WriteLine($"Summan av alla talen är: {sum}");



            //ARRAY 1

            //string[] veckoDagar = new[] { "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag" };

            //Console.WriteLine("Skriv in ett veckotal:");
            //int weekNumber = Convert.ToInt32(Console.ReadLine());

            //for (int i = weekNumber - 1; i == weekNumber - 1; i++)
            //    Console.WriteLine($"Dag {weekNumber} på veckan är {veckoDagar[i]}");



            //LIST & ARRAY #1

            //var listOfNumbers = new List<int>();

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine($"Skriv in tal {i + 1} av {4}:");
            //    listOfNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            //}

            //int biggestNumberSoFar = listOfNumbers[0];
            //foreach (var listNumber in listOfNumbers)
            //    if (listNumber > biggestNumberSoFar)
            //        biggestNumberSoFar = listNumber;
            //Console.WriteLine($"Det största nummret är: {biggestNumberSoFar}");




            //int[] array = new int[4];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Clear();
            //    Console.WriteLine($"Skriv in tal {i + 1} av {array.Length}:");
            //    var number = Convert.ToInt32(Console.ReadLine());
            //    array[i] = number;
            //}

            //var biggestSoFar = array[0];
            //foreach (var number in array)
            //    if (number > biggestSoFar)
            //        biggestSoFar = number;
            //Console.WriteLine($"Det största nummret är: {biggestSoFar}");


            //DEBUG DEMO

            //int age = 12;
            //age = 13;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Talet är {i}");
            //}

            //while (age < 15)
            //{
            //    Console.WriteLine("Hello");
            //    age = age + 1;
            //}
            //Console.WriteLine("sasdasda");


            //GENOMGÅNG LISTS & ARRAYS
            //int antalPriser = Convert.ToInt32(Console.ReadLine());
            //int[] allaPriser = new int[antalPriser];
            //allaPriser[0] = 123;
            //allaPriser[1] = allaPriser[0] + 12;

            //string[] coolPlayers = { "Börje Salming", "Foppa", "Mats Sundin" };


            //var allaBarn = new List<string>();
            //allaBarn.Add("Jocke"); //Index 0
            //allaBarn.Add("Janne"); //Index 1
            //allaBarn.Add("Hunden");
            //allaBarn.Add("Josef"); //Index 2


            //allaBarn.RemoveAt(2);

            //string namn = allaBarn[2];
            //allaBarn[2] = "Ollie";

            //foreach (var namne in allaBarn)
            //{

            //    if (namne[0] == 'O')
            //    {
            //        Console.WriteLine("Grattis");
            //    }


            //    Console.WriteLine($"Brev till {namn}");

            //}

            //for (int i = 0; i < allaBarn.Count; i++)
            //{


            //    if (allaBarn[i][0] == '0')
            //    {
            //        Console.WriteLine("Grattis");
            //    }


            //}



            //var allYears = new List<int>();
            //allYears.Add(1);
            //allYears.Add(2);

            //foreach (var year in allYears)
            //{

            //    Console.WriteLine($"{year}");

            //}















        }




    }
}
