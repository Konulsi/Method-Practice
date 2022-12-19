


namespace _19._12._2022_homeWork.Models
{
    internal class Calculator
    {
        public string Calculation(double num1, double num2, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1+num2;
                    return result.ToString(); 
                    case "-":   
                    result = num2 - num1;
                    return result.ToString();
                case "*":   
                    result = num2 * num1;   
                    return result.ToString();  
                    case "/":   
                    result = num2 / num1;   
                    return result.ToString();
                    

                default:
                    return "Duzgun reqem daxil edin";


            }
        }



    }
}
