string again = "a"; 
while (again == "a") 
{Console.Clear();
Console.Writeline (*********);
Console.Writeline ("********* Výpis řad čísel ******");
Console.Writeline ("*****Anna Gebhardtová***");
Console.Writeline ();

// Vstup hodnoty do programu - špatné řešení
//Console.Write("Zadejte první číslo řady: ");
//int first = int.Parse(Console. Readline());

//Vstup hodnoty do programu - řešení správně
Console.Write("Zadejte první číslo řady (celé číslo): ");
int first;

while(!int.TryParse(Console.Readline(), out first))
{
Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu:");
}



Console.Writeline();
Console.Writeline("Pro opakování programu stiskněte klávesu a.");
again = Console.Readline();



}
    
