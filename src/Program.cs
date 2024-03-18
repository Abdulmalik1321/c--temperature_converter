string TempConvert(float amount, char unit)
{
    if (char.ToLower(unit) == 'f')
    {
        float newTemp = (amount - 32) * 5 / 9;
        return $"\nConverted: {amount} F = {newTemp} C\n";
    }
    else if (char.ToLower(unit) == 'c')
    {
        float newTemp = (amount * 9 / 5) + 32;
        return $"\nConverted: {amount} C = {newTemp} F\n";
    }
    else return "\nInvalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.\n";
}

while (true)
{
    Console.WriteLine("Enter a temperature and its unit (C or F) or (Q) to quit:");
    string? input = Console.ReadLine();

    if (input == "")
    {
        Console.WriteLine("Please enter a value");
        continue;
    }
    else if (input.ToLower() == "q")
    {
        Console.WriteLine("Program terminated.");
        break;
    }

    string[] temp = input.Split(' ');
    try
    {
        float amount = float.Parse(temp[0]);
        char unit = char.Parse(temp[1]);

        Console.WriteLine(TempConvert(amount, unit));
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("\nInvalid input. Please enter a numeric temperature followed by temperature unit\n");
    }
    catch (FormatException)
    {
        Console.WriteLine("\nInvalid input. Please enter a numeric temperature followed by temperature unit\n");
    }
    catch (Exception)
    {
        Console.WriteLine("\nSomething went wrong\n");
        throw;
    }
}