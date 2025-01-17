// See https://aka.ms/new-console-template for more information

namespace Variant_2;

class Program
{
    static void Main(string[] args)
    {
        // Создаем стрелка и судью
        Shooter shooter = new Shooter();
        Sudia Sudia = new Sudia();

        // Подписываемся на событие "Нужен еще патрон"
        shooter.NeedMoreAmmo += Sudia.OnNeedMoreAmmo;

        // Стрелок делает выстрелы
        shooter.Shoot();
    }
}