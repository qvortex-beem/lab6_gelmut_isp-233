//try
//{
//    Console.Write("Введите первое число: ");
//    int x = Convert.ToInt32(Console.ReadLine());
//    Console.Write("Введите второе число: ");
//    int y = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(x/y);
//} catch (DivideByZeroException ex) {
//    Console.WriteLine($"Ошибка: {ex}");
//} catch (FormatException ex) {
//    Console.WriteLine($"Ошибка: {ex}");
//} catch (Exception ex) {
//    Console.WriteLine($"Ошибка: {ex}");
//}
//Console.WriteLine("Конец программы");


/*try {
    Console.Write("Введите первое число: ");
    double number1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите второе число: ");
    double number2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите операцию (+,-,*,/): ");
    string? operation = Console.ReadLine();
    double result = 0;
    switch (operation)
    {
        case "+": result = number1 + number2; break;
        case "-": result = number1 - number2; break;
        case "*": result = number1 * number2; break;
        case "/":
            if (number2 == 0) { throw new DivideByZeroException("Нельзя делить на ноль! :/"); }
            result = number1 / number2; break;
        default: Console.WriteLine("Неизвестная операция"); break;
    }
    Console.WriteLine($"Результат: {result}");
} catch (FormatException ex){
    Console.WriteLine($"Ошибка ввода: {ex.Message}");
} catch (DivideByZeroException ex) {
    Console.WriteLine($"Ошибка ввода: {ex.Message}");
} catch (Exception ex) {
    Console.WriteLine($"Ошибка ввода: {ex.Message}");
} finally {
    Console.WriteLine("Работа с калькулятором завершена");
}*/

//double Add(double a, double b) {
//    return a * b;
//}
//double a = 4.5;
//double b = 2.5;
//double answer = Add(a, b);
//Console.WriteLine($"а+b = {answer}");

//int number = 12;
//Console.WriteLine(number.ToString());
//bool boolean = true;
//Console.WriteLine(boolean.ToString());
//DateTime now = DateTime.Now;
//Console.WriteLine(now.ToString());
//object me = new();
//Console.WriteLine(me.ToString());

//int age = int.Parse("27");
//DateTime birthday = DateTime.Parse("4 July 1980");
//Console.WriteLine($"I was born {age} years ago.");
//Console.WriteLine($"My birthday is {birthday}.");
//Console.WriteLine($"My birthday is {birthday:D}.");

//int count = int.Parse("abc");

//Console.Write("Какой максимальный балл по дисциплинам? ");
//string? input = Console.ReadLine();
//if (int.TryParse(input, out int count)) {
//    Console.WriteLine($"Это {count} баллов.");
//} else {
//    Console.WriteLine("Некорректный ввод.");
//}

//Console.Write("Введите сумму: ");
//string? amount = Console.ReadLine();
//try {
//    decimal amountValue = decimal.Parse(amount);
//} catch (FormatException) when (amount.Contains("$")) {
//    Console.WriteLine("В суммах нельзя использвать знак доллара!");
//} catch (FormatException) {
//    Console.WriteLine("Суммы должны содержать только цифры!");
//}


//try
//{
//    checked
//    {
//        int x = int.MaxValue - 1;
//        Console.WriteLine($"iniitial value {x}");
//        x++;
//        Console.WriteLine($"after incrementing: {x}");
//        x++;
//        Console.WriteLine($"after incrementing: {x}");
//        x++;
//        Console.WriteLine($"after incrementing: {x}");
//    }
//} catch (OverflowException){
//    Console.WriteLine("The code overflowed but I caught the exception");
//}

// сам задания
// задание 1
