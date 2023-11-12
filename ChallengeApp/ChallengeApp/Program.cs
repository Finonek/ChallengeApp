using System.ComponentModel.Design;

var myName = "Ewa";
var myAge = 33;
var mySex = "female";

if (myName == "Ewa" && myAge == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (mySex == "female" && myAge < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (mySex == "male" && myAge < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (mySex == "female" && myAge > 30)
{
    Console.WriteLine("Kobieta powyżej 30 lat");
}
else if (myName == "Ewa" && mySex == "female")
{
    Console.WriteLine("Ewa to kobieta");
}