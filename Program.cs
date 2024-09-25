namespace CIS205_Master_Project
{
    internal class Program //internal is the default access level.
        //every program in VS is a class
        /*
        The class program include a pair of curly braces.
        The console app starts with the Main() entry point. 
        Multiple Main() entries will cause conflicts!
        Make sure to disable the other non-active programs/classes!
         */

    {
        static void Main(string[] args)
        {
            //Create a business card for myself
            //You can use either the Write() - append
            //method of the WriteLine() - start a new line for each literal string.
            Console.WriteLine("Jeremy Wang");
            Console.WriteLine("MAT Department");
            Console.WriteLine("904-660-3340");
            Console.Write("My favorite Sayings:\n");
            
        }
    }
}
