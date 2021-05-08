using System;

namespace HolidayTeamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating instances of Holiday class
            Holiday holiday1 = new Holiday("Independence Day", 1, "October" );
            Holiday holiday2 = new Holiday("Workers' Day", 2, "May");

            //calls the inSameMonth method
            Holiday.inSameMonth(holiday1, holiday2);



            Holiday[] holidayArray = {holiday1, holiday2};

            //calls the avgDate months
            Holiday.avgDate(holidayArray);
        }
    }
}
