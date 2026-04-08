    // Функція для генерації рекламного заголовка на основі ключових слів та обраної платформи

    public class HookService
    {
        public string GenerateHook(string topic, string platform)
        {
            string hook = $"Захоплюючий контент про {topic} на {platform}! Не пропустіть!";
            return hook;
        }
    }
    class Program
{
    static void Main()
    {
        
        Console.WriteLine("\n--- Тестування HookCraft AI ---");
        
        HookService aiService = new HookService();
        
        string myHook = aiService.GenerateHook("Основи програмної інженерії", "Instagram");
        
        Console.WriteLine("Згенерований гачок:");
        Console.WriteLine(myHook);
        Console.WriteLine("-------------------------------\n");
    }
}