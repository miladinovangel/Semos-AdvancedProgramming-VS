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

//int number = int.Parse(Console.ReadLine());
//if (number % 2 == 0)
//{
//    Console.WriteLine("Brojot e paren");
//}

//int input = int.Parse(Console.ReadLine());
////if(input >= 0)
////{
////    Console.Write(input);
////}
////else
////{
////    Console.WriteLine(-input);
////}

//// ternaren operator
//int absoluteValue = input >= 0 ? input : -input;// uslov ? x : y;
//Console.WriteLine(absoluteValue);

//int input = int.Parse(Console.ReadLine());
//if (input % 2 == 0 && input % 3 == 0)
//{
//    //Console.WriteLine("The number " + input + " is divisible by 2 or 3");
//    Console.WriteLine($"The number {input} is divisible by 2 or 3");

//}
//else
//{
//    Console.WriteLine("The number " + input + " is not divisible by 2 or 3");
//}

// VO koja ke vnesite 2 broja od tastaturata i treba da go ispecatite pogolemiot broj
//int input1 = int.Parse(Console.ReadLine());
//int input2 = int.Parse(Console.ReadLine());
//if (input1 > input2)
//{
//    Console.WriteLine(input1);
//}
//else
//{
//    Console.WriteLine(input2);
//}
//int pogolem = (input1 > input2) ? input1 : input2; //ternaren operator
//Console.WriteLine(pogolem);

// napisete ciklus sto ke go pecati vaseto ime beskonecno
//while (true)
//{
//    Console.WriteLine("Angel");
//}

//for ( ; ; ) // eleganten beskonecen ciklus
//    Console.WriteLine("Angel")


// Ispecati gi broevite od 0 do 5
//Console.WriteLine(0);
//Console.WriteLine(1);
//Console.WriteLine(2);
//Console.WriteLine(3);
//Console.WriteLine(4);
//Console.WriteLine(5);

//if (input % 2 == 0 && input % 3 == 0)
//{
//    Console.WriteLine($"The number {input} is divisible by 2 or 3");
//}

//pecati broevi site broevi od 1 do 100 sto se delivi so 2 i 3
//for (int i = 1; i <= 100; i++)/// 1 3 5 7 9
//{
//    if (i % 2 == 0 && i % 3 == 0)
//    {
//        Console.WriteLine(i);
//    } 

//}

// zbirot na broevite od 1 do 5
//int sum = 0;
//sum += 1;
//sum += 2;
//sum += 3;
//sum += 4;
//sum += 5;
//Console.WriteLine(sum);
//int sum = 0;
//for (int i = 1; i <= 10; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum);


//int sum = 0;
//for (int i = 1; i <= 100; i++)/// sobiranje na site broevi od 1 do 100 delivi so 2 i 3
//{
//    if (i % 5 == 0 && i % 7 == 0)
//    {
//        sum += i;
//        Console.WriteLine(i);
//    }
//}
//Console.WriteLine(sum);

// treba da vnesete 5 broevi od tastaturata
//Console.ReadLine();
//Console.ReadLine();
//Console.ReadLine();
//Console.ReadLine();
//Console.ReadLine();

// prosek?
//int numbers = int.Parse(Console.ReadLine());
//int sum = 0;
//int product = 1;

//for (int i = 0; i < numbers; i++)
//{
//    int input = int.Parse(Console.ReadLine());
//    sum += input;
//    product *= input;

//}

//Console.WriteLine(sum);
//Console.WriteLine(product);
//Console.WriteLine((float) sum / numbers);


int result;


for (int j = 1; j < 20; j++) // presmetaj go tretiot stepen na broevite od 1 do 20
{
    result = 1;
    for (int i = 0; i < 3; i++)
    {
        result *= j;
    }
    Console.WriteLine(result);
}


//result = 1;
//for (int i = 0; i < 3; i++)
//{
//    result *= 3;
//}
//Console.WriteLine(result);

//result = 1;
//for (int i = 0; i < 3; i++)
//{
//    result *= 4;
//}
//Console.WriteLine(result);

//result = 1;
//for (int i = 0; i < 3; i++)
//{
//    result *= 5;
//}
//Console.WriteLine(result);

//for (int i = 2; i < 7; i++)
//{
//    result = 1;
//    for(int j = 0; j < 3; j++)
//    {
//        result *= i;
//    }
//    Console.WriteLine(result);
//}