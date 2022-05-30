//Fråga 1

//En stack är en datastruktur där man bara kan lägga 
//till nya element överst, och ta bort element överst, d.v.s. i omvänd ordning som 
//man la till dem (som på en stapel tallrikar). Stacken, i bestämd form, är en 
//sådan datastruktur som programmet använder när det körs för att lagra data som 
//det (programmet) behöver.




//int add(int x, int y)
//{

//    int result = x + y;

//    return result;

//}

//void print_times(int x, int times)
//{

//    for (int i = 0; i < times; i++)

//    {

//        Console.WriteLine(x);

//    }

//}

//void add_and_print_3_times(int a, int b)
//{

//    int sum = add(a, b);

//    print_times(sum, 3);

//}



//static int Main(string[] args)
//{

//    add_and_print_3_times(3, 17);

//    return 0;

//}

//Så hur används heapen? 

//Om en stackframe som refererar till ett objekt tas bort (för 
//att vi är klara med den metoden) så förlorar vi referensen till objektet om vi 
//inte hade sparat undan den nånstans. Om vi nu inte har kvar några referenser 
//till objektet så kommer objektet så småningom att städas undan av garbage 
//collectorn. 

 

 

 

//Fråga 2 

 

//Värdedatatyper: I C# kommer värdedatatyperna att lagra variabelvärdet direkt i minnet och det kommer också att acceptera både signerade och osignerade bokstaver. Den härledda klassen för dessa datatyper är System.ValueType . 

//Referensdatatyper: Referensdatatyperna kommer att innehålla en minnesadress med variabelt värde eftersom referenstyperna inte lagrar variabelvärdet direkt i minnet. De inbyggda referenstyperna är sträng, objekt. 

//Skillnaden är att en värdetyp lagrar sitt värde direkt, medan en referenstyp lagrar en referens till värdet. Värdetyper i C# är i princip samma som enkla typer (heltal, flytande men inte pekare eller referenser). 

 

//Fråga 3 

//I det första fallet får X värdet 3. Sedan tar en ny variabel som initieras med Y och får värdet 3 efter att den är lika med X. Då är Y lika med 4 men värdet på X kommer att förbli 3 eftersom det i en STACKEN spelar roll att tilldela värden. 

//I det andra fallet har vi att göra med ett HEAPEN, därför blir det slutliga resultatet 4. 
