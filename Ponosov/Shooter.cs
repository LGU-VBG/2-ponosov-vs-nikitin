// Класс "Стрелок"
class Shooter
{
    private int ammoCount = 8; // Количество патронов всего
    private Random random = new Random();

    // "Нужен еще патрон" событие 
    public event Action NeedMoreAmmo;

    // Метод для выстрела
    public void Shoot()
    {
        while (ammoCount > 0)
        {
            Console.WriteLine($"Осталось патронов: {ammoCount}");

            // Симуляция выстрела
            bool isMisfire = random.Next(0, 2) == 0; // рандом число 0 или 1 | 0=>осечка | 1=>попал 
            if (isMisfire)
            {
                Console.WriteLine("Осечка! Нужен еще патрон.");
                NeedMoreAmmo(); // Вызываем событие
            }
            else { Console.WriteLine($"Выстрел!"); }

            ammoCount--;
        }

        Console.WriteLine("Патроны закончились. Стрельба завершена.");
    }

    // Метод для добавления патрона (вызывается судьей)
    public void AddAmmo()
    {
        ammoCount++;
        Console.WriteLine("Судья дал дополнительный патрон.");
    }
}