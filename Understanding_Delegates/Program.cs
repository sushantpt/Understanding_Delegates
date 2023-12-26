// See https://aka.ms/new-console-template for more information
using Understanding_Delegates.Classes;

Console.WriteLine("Hello, World!");


Console.WriteLine("------------------");
Console.WriteLine("--------- Simple delegate example ---------");
Console.WriteLine("------------------");

Example eg = new Example();
eg.AddNumbers();

Console.WriteLine("------------------");
Console.WriteLine("--------- Notification service example ---------");
Console.WriteLine("------------------");


// create notification service
NotificationService notificationService = new NotificationService();
// create subscribers
List<Subscriber> listOfSubscriber = new List<Subscriber>()
{
    new Subscriber(){ Username = "Priti"},
    new Subscriber(){ Username = "Jon"},
    new Subscriber(){ Username = "Ram"}
};

// Subscribe Users to the Notification Service 
foreach (Subscriber subscriber in listOfSubscriber)
{
    notificationService.Notify += subscriber.ReceiveNotification;
    // add reference of another method to our Notify delegate.
    notificationService.Notify += subscriber.ReceiveAnotherNotification;
    // this is multicast delegate. 
}

// random amount of voucher 
Random randAMount = new Random();
int discountAmount = randAMount.Next(10, 251);

// send notification to the subscribers who are subscribed. 
notificationService.SendNotification($"Here's a voucher of Rs. {discountAmount}! Enjoyyyyyy.");



Console.WriteLine("------------------");
Console.WriteLine("--------- Simple built in delegate examples ---------");
Console.WriteLine("------------------");


// func delegate
Console.WriteLine(eg.AddNumbersFunc(1, 4));


// predicate delegate
Console.WriteLine(eg.isEven(2)); // Output: True


// action delegate
eg.printSumOfNums(30, 20);


Console.WriteLine("------------------");
Console.WriteLine("--------- Built in delegate examples ---------");
Console.WriteLine("------------------");

/*examples*/

/* func example */
Console.WriteLine("Func example:");
List<int> itemInCartPrices = new List<int> { 210, 450, 1500, 2600 };
int totalPrice = eg.calculateTotalPriceInTheCart(itemInCartPrices);
Console.WriteLine(totalPrice);


/* predicate example */
Console.WriteLine("Predicate example:");
bool eligible = eg.isEligibleForDiscount(totalPrice); // Result: True
Console.WriteLine($"Is eligible for discount: {eligible}");
if (eligible)
{
    Console.WriteLine($"Total price before discount: {totalPrice}");
    totalPrice = totalPrice - (int)(0.1 * totalPrice);
    Console.WriteLine($"Total price after 10% discount: { totalPrice}");
}


/* action example */
Console.WriteLine("Action example.");
eg.logPurchaseConfirmationMessage("Purchase confirmed for username12345."); // Logs the confirmation message.


