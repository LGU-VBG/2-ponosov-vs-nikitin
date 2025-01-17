
class Shooter
{
    private int ammoCount = 8; 
    private Random random = new Random();
    public event Action NeedMoreAmmo;
    public void Shoot()
    {
        while (ammoCount > 0)
        {
            Console.WriteLine($"Осталось патронов: {ammoCount}");

            bool isMisfire = random.Next(0, 2) == 0; 
            if (isMisfire)
            {
                Console.WriteLine("Осечка! Нужен еще патрон.");
                NeedMoreAmmo(); 
            }
            else { Console.WriteLine($"Выстрел!"); }

            ammoCount--;
        }

        Console.WriteLine("Патроны закончились. Стрельба завершена.");
    }

    public void AddAmmo()
    {
        ammoCount++;
        Console.WriteLine("Судья дал дополнительный патрон.");
    }
}