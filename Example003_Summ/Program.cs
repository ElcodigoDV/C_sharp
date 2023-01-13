int numberA=new Random().Next(1, 10); //дает случ. число от 1 до 10 - 10 не входит в диапазон
Console.WriteLine("numberA: "+ numberA);
int numberB=new Random().Next(1, 10);
Console.WriteLine("numberB: "+ numberB);
int result = numberA+numberB;
Console.WriteLine("Sum: "+ result);