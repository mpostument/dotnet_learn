using partials.Order;
using partials.OrderProcessing;
using partials.Person;
using partials.UserManager;
using INotificationService = partials.UserManager.INotificationService;

Person person = new Person() { LastName = "Test", FirstName = "Person" };
person.PrintFullName();

person.FirstName = "NewName";

// Task 3
Console.WriteLine(person.FirstName.FirstSymbol());
Console.WriteLine(person.LastName.FirstSymbol());

// Task 4
var anon = new
{
    FirstName = "First",
    LastName = "Last",
    Age = "33"
};

Console.WriteLine($"{anon.FirstName} {anon.LastName} {anon.Age}");

// Task5
var student1 = new Student("Student", "1", "Test1");
var student2 = new Student("Student", "1", "Test1");
Console.WriteLine(student1 == student2);

// Task6
int[] numbers = new[] { 1, 2, 3, 4, 5 };
Console.WriteLine(numbers.Sum());

// Task 7
Console.WriteLine(person.LastName.ToCapital());

// Task 8 and 9 
Order order = new Order() { OrderDate = DateTime.Now, OrderId = 1 };
order.ProcessOrder();

// Task 10
Book book = new Book(Title: "Hobbit", Author: "John Ronald Reuel Tolkien", YearPublished: 1937);
Console.WriteLine($"Book {book.Title} was released in {book.YearPublished}");

// Task 11
Console.WriteLine(book.GetDescription());

// Task 11 Wrong
UserManagerBad userManagerBad = new UserManagerBad();
userManagerBad.AddUser("Test", "test@test.com");

// Fixed example
INotificationService notificationService = new EmailService();
UserManager userManager = new UserManager(notificationService);
userManager.AddUser("test", "test@test.com");

// Task12

Penguin penguin = new Penguin();
// penguin.Fly(); // error here

PenguinFixed penguinFixed = new PenguinFixed();
penguinFixed.Swim();

// Task13

Course course = new Course("Unity", 40);
Console.WriteLine(course);

// Task14
INotificationServiceNew emailService = new EmailNotification();
INotificationServiceNew smsService = new SmsNotification();

OrderProcessor emailOrderProcessor = new OrderProcessor(emailService);
emailOrderProcessor.ProcessOrder("12345");


OrderProcessor smsOrderProcessor = new OrderProcessor(smsService);
smsOrderProcessor.ProcessOrder("67890");