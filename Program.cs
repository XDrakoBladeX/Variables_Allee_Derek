namespace Variables_Allee_Derek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declares an integer variable named favoriteNumber. 
            int favoriteNumber;

            // Declares two boolean variables named isJumping and isRunning, and initializes them to false.
            bool isJumping = false, isRunning = false;

            //Decleares a float named projectileSpeed. 
            float projectileSpeed;

            //Sets the value of favoriteNumber to 25. 
            favoriteNumber = 25;

            //Sets the value of projectileSpeed to 15.5f.
            projectileSpeed = 15.5f;

            // Makes final grade a constant never changing number to 98.6
            const double finalGrade = 98.6;

            // Prints the values of the variables to the console.
            Console.WriteLine("My favorite number is: " + favoriteNumber);

            // Prints the values of the boolean variables to the console.
            Console.WriteLine("Is the character jumping? " + isJumping);

            // Prints the values of the boolean variables to the console.
            Console.WriteLine("Is the character running? " + isRunning);

            // Prints the value of the projectileSpeed variable to the console.
            Console.WriteLine("The projectile speed is: " + projectileSpeed);

            // Prints the value of the finalGrade constant to the console.
            Console.WriteLine("The final grade is: " + finalGrade);
        }
    }
}
