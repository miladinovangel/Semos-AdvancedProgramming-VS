// See https://aka.ms/new-console-template for more information


//Console.WriteLine("Hello, World!");
// 1. Promenlivi/Variables
//int
//Console.WriteLine(5);
// float
//Console.WriteLine(3.18f);
// double 
//Console.WriteLine(3.18);
//string
//Console.WriteLine("angel");

//1. kreirajte promenlivi od site tipovi na tablata i inicijalizirajte gi na nekoja vrednost
//short shortVariable = 1;
//int intVariable = 1;
//long longVariable = 1;
//float floatVariable = 1f;
//double doubleVariable = 1.0;
//string stringVariable = "1";
//bool boolVariable = true;
//char charVariable = 'c';


//2. Vreka brasno tezi 13.2 kg, a vreka sol tezi 3.23kg
// Kreirajte 2 promenlivi za vrekata brasno i sol za nivnata tezina
// Presmetajte kolku tezat 5 vreki brasno zaedno so 9 vreki sol i zacuvaj gi 
// tie vrednosti vo int, float i double promenlivi
//float vrekaBrasno = 13.2f;
//float vrekaSol = 3.23f;
//float vkupnaTezina = (5 * vrekaBrasno) + (9 * vrekaSol);
//int vkupnaTezinaInt = (int)vkupnaTezina;
//double vkupnaTezinaDouble = vkupnaTezina;
//Console.WriteLine(vkupnaTezina);
//Console.WriteLine(vkupnaTezinaInt);
//Console.WriteLine(vkupnaTezinaDouble);

//3. Kreiraje 2 promenlivi vo koi treba da go zacuvate vaseto ime i prezime. 
// Potoa kreirajte 3ta promenliva koja treba da gi sodrzi vaseto prvo ime, potoa
// prazno mesto i vaseto prezime.

//string name = "DIno";
//string surname = "Vusljanin";
//string fullName = name + " " + surname;
//string fullName2 = $"{name} {surname}";

//4. Vnesete text od tastatura i zacuvajte go vo string promenliva.
// Vnesete cel broj od tastatura i zacuvajte go vo int promenliva.
// Vnesete decimalen broj od tastatura i zacuvajte go vo float promenliva.
//string text = Console.ReadLine(); // procitaj od tastaturata
//int number = int.Parse(Console.ReadLine());
//float number1 = float.Parse(Console.ReadLine());

//5. Vnesi broj od tastatura i zacuvaj go vo promenliva. 
// Potoa vo nova promenliva zacuvaj go zbirot na promenlivata i brojot 23.
// Rezultatot ispecati go na ekran
//int input = int.Parse(Console.ReadLine());
//int sum = input + 23;
//Console.WriteLine(sum);

////6. Zgolemi ja vrednosta na sum za 1
//sum++;
//sum += 1;
//sum = sum + 1;

////7. Zgolemi ja vrednosta na sum za 2 pati
//sum *= 2;
//sum = sum * 2;

//sum *= sum;
//sum = sum * sum;
// 7. Vnesi 3 broevi od tastaturata i presmetaj go nivniot proizvod

//int number1 = int.Parse(Console.ReadLine());
//int number2 = int.Parse(Console.ReadLine());
//int number3 = int.Parse(Console.ReadLine());
//int product = number1 * number2 * number3;
//Console.WriteLine(product);

//8 Uslov
//if (true) // dokolku uslovot e ispolnet
//{
//    Console.WriteLine("TRUE");
//}
//if (5 > 3) // dokolku uslovot e ispolnet
//{
//    Console.WriteLine("TRUE");
//}
//int number = 5;
//number = int.Parse(Console.ReadLine());
//if (number > 3) // dokolku uslovot e ispolnet
//{
//    Console.WriteLine("TRUE");
//}
//else
//{
//    Console.WriteLine("FALSE");
//}
// Napiste programa koja ke proveruva dali vnesen broj od tastaturata
// e pozitiven ili ne e pozivtiven

//int number = int.Parse(Console.ReadLine());
//if (number == 0) // dokolku uslovot e ispolnet
//{
//    Console.WriteLine("Vnesovte nula");
//}
//else if (number > 0)
//{
//    Console.WriteLine("Vnesovte pozitiven broj");
//}
//else
//{
//    Console.WriteLine("Vnesovte negativen broj");
//}
//int number = int.Parse(Console.ReadLine());
//if (number > 0) // dokolku uslovot e ispolnet
//{
//    Console.WriteLine("Vnesovte pozitiven broj");
//}
//else if (number < 0)
//{
//    Console.WriteLine("Vnesovte negativen broj");
//}
//else
//{
//    Console.WriteLine("Vnesovte nula");
//}
//% - modulo - ostatok pri delenje

int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Brojot e paren");
}




