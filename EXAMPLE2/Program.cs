Console.WriteLine("Введите числo"); 
int a=  Convert.ToInt32 (Console.ReadLine()); 

if( a>99) 
{ while (a>=999)
 {a=a/10;}
   int b=(a%10);
   Console.WriteLine (b); }
 else
{ Console. WriteLine( " Третьей цифры нет ");}

