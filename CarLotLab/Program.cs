// See https://aka.ms/new-console-template for more information
using CarLotLab;
using System.Diagnostics;
Console.WriteLine("Hello, World!");
Car carFactory = new Car();


Car.CarList = new List<Car>()
{

    new Car("Nikolai","Model S", 2017,54999.90m),
    new  Car("Ford","Escalade" , 2017,31999.90m),
    new Car("Chewie","Vette",2015,44989.95m),
    new UsedCar("Honda","Prior",2015,14795.50m,35987.6),
    new UsedCar("GMC20","Acadia",2019,23456.78m,45678.3),
    new UsedCar("GMC21","Traverse",2019,25675.89m,47897.23)

};
Car.ListCar();

int carNo = GetIntegerFromUser("Which Car No would you like to purchase");

Console.WriteLine(Car.CarList[carNo - 1].ToString());

Car.Remove(carNo - 1);

Console.WriteLine("Excellent!  Our finance department will be in touch shortly.");
Console.WriteLine("Have a great day!");

Car.ListCar();
Console.WriteLine("Search list be 'make'");
List<Car> carSearch = Car.CarList.Where(x => x.Make.Contains("GMC")).ToList();
foreach (Car carMatch in carSearch)
{
    Console.WriteLine(carMatch.ToString());
}
/*Point point = new Point();

do
{
    point.x= GetIntegerFromUser("Enter an X coordinate");
    point.y = GetIntegerFromUser("Enter an Y coordinate");
    point.CalculateDistance(point.x, point.y);
   
} while (GetPlayAgainAnswer() == true);

Console.ReadKey();
*/
int GetIntegerFromUser(string message)
{
    bool isValidInteger = false;
    int returnValue = -1;
    while (isValidInteger == false)
    {
        Console.WriteLine(message);
        try
        {
            returnValue = int.Parse(Console.ReadLine());

        }
        catch (FormatException)
        {
            Console.WriteLine("Value should be an integer");
            continue;
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("value should not be null");
            continue;
        }
        isValidInteger = true;
    }

    return returnValue;
}
bool GetPlayAgainAnswer(string strMessage = "Would you like to Continue? y/n")
{
    Console.WriteLine(strMessage);
    string userAnswer = Console.ReadLine();
    if (userAnswer.ToLower() != "y")
    {
        return false;
    }
    return true;
}