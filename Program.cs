int num = int.Parse(Console.ReadLine());
string day;

//Reading user`s input and convert it into int
Console.WriteLine("Enter number of week day (1-7)");

//Check the entered number from 1 to 7 and invalid bumber case
switch (num)
{
    case 1:
        day = "Monday";
        break;

    case 2:
        day = "Tuesday";
        break;

    case 3:
        day = "Wednesday";
        break;

    case 4:
        day = "Thursday";
        break;

    case 5:
        day = "Friday";
        break;

    case 6:
        day = "Saturday";
        break;

    case 7:
        day = "Sunday";
        break;

    default:
        day = "Invalid day number";
        break;
}

//Display the results 
Console.WriteLine(day);