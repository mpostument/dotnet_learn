using delegates;

FixErrors fixErrors = new FixErrors();
fixErrors.Case1();
fixErrors.Case2();
fixErrors.Case3();
fixErrors.Case4();
fixErrors.Case5();
fixErrors.Case6();
fixErrors.Case7();
fixErrors.Case8();
fixErrors.Case9();
fixErrors.Case10();

// Task1
NotificationService notificationService;
Console.WriteLine("Choose notification method: 1 for Console, 2 for File, 3 for Both");
string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        notificationService = new NotificationService(ConsoleNotification);
        break;
    case "2":
        notificationService = new NotificationService(FileNotification);
        break;
    case "3":
        notificationService = new NotificationService(new List<NotificationHandler>() {FileNotification, ConsoleNotification});
        break;
    default:
        Console.WriteLine("Invalid choice");
        return;
}

Console.WriteLine("Enter the message to send:");
string message = Console.ReadLine();

notificationService.Send(message);
void ConsoleNotification(string message)
{
    Console.WriteLine(message);
}

void FileNotification(string message)
{
    File.AppendAllText("notifications.txt", message);
}

// Task 2
UsersManager userManger = new UsersManager();
userManger.GenerateUsers();
userManger.FilterUsers((u) => u.Age > 18);

// Task 3
Alarm alarm = new Alarm();
alarm.OnAlarm += () => Console.WriteLine("Alarm received");
alarm.OnAlarm += () => File.AppendAllText("alarm.txt", "Alarm received");
alarm.Trigger();

// Taks 4
CurrencyConversionService currencyConverter = new CurrencyConversionService();
Console.WriteLine(currencyConverter.Convert(100, 73.5f, (a, r) => a / r));

