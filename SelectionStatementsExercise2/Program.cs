namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }
    
        

        public static void FavSubject() 
        {

            Console.Write("Enter your favorite subject: ");
            string subject = Console.ReadLine();    

            switch(subject.ToLower()) 
            {
                case "math":
                    Console.WriteLine("I hate math");
                    break;
                case "science":
                    Console.WriteLine("I love science");
                    break;
                case "english":
                    Console.WriteLine("i think english is good comprehension");
                    break;
                case "history":
                    Console.WriteLine("i thik history is great");
                    break;
                case "phyical edcation":
                    Console.WriteLine("Good for the body");
                    break;
                default:
                    Console.WriteLine("Didnt think about that one. That's a good one");
                    break;
            
            
            
            
            }
        
        
        
        
        }
    
    
    
    
    
    
    
    
    
    
    }


}