/*Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica
daca x este divizibil cu y.
 In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar,
“indivizibil”.*/

Console.WriteLine("Introduceti numarul x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti numarul y");
int y = Convert.ToInt32(Console.ReadLine());

if (x % y == 0)
{
    Console.WriteLine("divizibil");
}
else
{
    Console.WriteLine("indivizibil");
}
