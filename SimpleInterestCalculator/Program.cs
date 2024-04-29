using System;

namespace SimpleInterestCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create an Instace of the investment class
            Investments FirstInvestment = new Investments();

            //Prompt the user to enter the principal amount,interest rate and investment duration(in years)
            Console.WriteLine("Welcome to your Simple Interest Calculator");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Pls enter your name");
            string name = Console.ReadLine();



            Console.WriteLine("Pls enter your principal amount");
            double userPrincipalAmount = double.Parse(Console.ReadLine());

           
            Console.WriteLine("Pls enter your interest rate");
            double userInterestRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Pls enter your duration");
            int userInvestmentDuration = int.Parse(Console.ReadLine());

            //Assigning User Inputs to Field.
            FirstInvestment.Principal = userPrincipalAmount;
            FirstInvestment.Rate = userInterestRate;
            FirstInvestment.Time = userInvestmentDuration;


            //Call the respective methods to calculate
            //the simple interest,
            //final amount,
            //interest rate (based on the final amount),
            //and investment duration (based on the final amount).

            //(a) Calculating Simple Interest
            double simpleInterestResult=FirstInvestment.CalculateSimpleInterest();
            //(b) calculating final Amount
            double finalAmountResult = FirstInvestment.CalculateFinalAmount();
            //(c) calculating interest rate
            double interestRateResult = FirstInvestment.CalculateIntrestRate( finalAmountResult , userPrincipalAmount);
            //(d) calculating investment duration
            int investmentDurationResult = FirstInvestment.CalculateInvestmentDuration( (int)userPrincipalAmount, userInterestRate);

            Console.WriteLine($"Your inputed data are Principal :{userPrincipalAmount}.\n Rate: {userInterestRate}.\n Time :{userInvestmentDuration}years");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Calculating Based on your Data");
            Console.WriteLine($"Welcome{name}\n Simple Interest: {simpleInterestResult}.\n Final-Amount: {finalAmountResult}.\n Interest Rate: {interestRateResult}.\n Investment-Duration: {investmentDurationResult}");


          
        }
    }
}
