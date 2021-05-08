public class Holiday
{
    //private fields of a class
    private string _name;
    private int _day;
    private string _month;

    //constructor that initiates the field, with the instances passed into the class
    public Holiday(string name, int day, string month)
    {
        this._name = name;
        this._day = day;
        this._month = month;
    }

    //Checks if the instaces of two holiday months are equal
    public static void inSameMonth(Holiday holiday1, Holiday holiday2)
    {
        if(holiday1._month == holiday2._month)
        {
            System.Console.WriteLine("True");
        }
        else
        {
            System.Console.WriteLine("False");
        }
    }

    //Computes the average the Holiday days
    public static double avgDate(Holiday[] holidayArray)
    {
        double sum = 0;
        foreach (var day in holidayArray)
        {
            sum += day._day;
            //sum = sum + day._day
        }
        double average = sum/holidayArray.Length;

        //prints out the average
        System.Console.WriteLine(average);
        return average;

    }
}