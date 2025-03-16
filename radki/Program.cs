
Console.Write("enter name and surename; ");
string fullName =  Console.ReadLine();
string[] parts = fullName.Split(' ');
    
if (parts.Length >= 2)   
{   
    char firstLetterName = char.ToUpper(parts[0][0]);
    char firstLetterSurname = char.ToUpper(parts[1][0]);

        
    if (firstLetterName == firstLetterSurname)
        
    {
            Console.WriteLine("surename begins with same letter as name");
        
    }
        
    else
        
    {
            Console.WriteLine("surename doesnt begins with same letter as name");
        
    }
    }

