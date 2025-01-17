
namespace Variant_2;

class Program
{
    static void Main(string[] args)
    {
        Shooter shooter = new Shooter();
        Sudia Sudia = new Sudia();

        shooter.NeedMoreAmmo += Sudia.OnNeedMoreAmmo;

        shooter.Shoot();
    }
}