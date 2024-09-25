using System;

using static System.Console;

using System.Globalization;

class ProjectedRaisesInteractive

{

    static void Main()

    {

        //Declarations

        const double raise = 0.04;

        double employee1 = 25000, employee2 = 38000, employee3 = 51000;




        //Processing (implementing the business rules)

        employee1 = employee1 * (1 + raise);

        employee2 = employee2 * (1 + raise);

        employee3 = employee3 * (1 + raise);




        //Ouput (follow the exact requirements)

        WriteLine("Next year's salary for the first employee will be {0}.", employee1.ToString("C", CultureInfo.GetCultureInfo("en-US")));

        WriteLine("Next year's salary for the second employee will be {0}.", employee2.ToString("C", CultureInfo.GetCultureInfo("en-US")));

        WriteLine("Next year's salary for the third employee will be {0}.", employee3.ToString("C", CultureInfo.GetCultureInfo("en-US")));




    }

}
