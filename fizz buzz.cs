

int i;

for (i = 1; i <= 100; i++)
{

        

    if (i % 15 == 0)
    {
        System.Console.WriteLine("fizzbuzz");
    }
          
    else if (i % 5 == 0)

    {
        System.Console.WriteLine("buzz");
        
    }
    else if (i % 3 == 0)
    { System.Console.WriteLine("Fizz"); 
    
    } 
    else
  {System.Console.WriteLine(i);}
  
}
