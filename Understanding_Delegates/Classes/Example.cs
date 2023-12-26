namespace Understanding_Delegates.Classes
{
    public class Example
    {

        // declares a delegate named Addition that takes two int parameters and returns an int.
        delegate int Addition(int a, int b);

        // method that takes two numbers (a and b) and returns their sum.
        private int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public void AddNumbers()
        {
            // create an instance of the Addition delegate and point it to the private AddNumbers method.
            Addition addition = new Addition(AddNumbers);
            // invokes the delegate, calling the AddNumbers method with following arguments.
            int ret = addition(1,2);
            Console.WriteLine($"Result of addition: {ret}");
        }

        // Simple Func delegate
        public Func<int, int, string> AddNumbersFunc = (a, b) => (a + b).ToString();


        // Simple predicate function
        public Predicate<int> isEven = num => num % 2 == 0;


        // Simple action function
        public Action<int, int> printSumOfNums = (a, b) => Console.WriteLine($"Sum : {a + b}");


        // examples of built in delegates:
        /* Func<> */
        public Func<List<int>, int> calculateTotalPriceInTheCart = items => items.Sum();


        /* predicate<> */
        public Predicate<int> isEligibleForDiscount = purchaseAmount => purchaseAmount > 1000;


        /* action */
        public Action<string> logPurchaseConfirmationMessage = message => Console.WriteLine($"Log: {message}");
        
    }
}
