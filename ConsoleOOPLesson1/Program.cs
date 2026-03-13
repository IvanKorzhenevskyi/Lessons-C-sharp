using System.ComponentModel;
using System.Reflection;

namespace ConsoleOOPLesson1
{

    

    enum TypeGun
    {
        [Description("Пiстолет")]
        Pistol,
        [Description("Гвинтiвка")]
        Rifle,
        [Description("Шотган")]
        Shotgun,
        [Description("Снайперська гвинтiвка")]
        Sniper,
        [Description("Кулемет")]
        MachineGun,
        [Description("Невiдомо")]
        Unknown  
    }

    class Gun
    {   
    
        private bool ammoEnabled;

        private int ammoCapacityGun;

        private TypeGun typeGun;

        public TypeGun TypeGun
        {
            get { return typeGun; }
            set { typeGun = value; }
        }

        static string GetDescription(TypeGun typeGun)
        {
            var field = typeGun.GetType().GetField(typeGun.ToString());// Отримуємо iнформацiю про поле enum, яке вiдповiдає конкретному значенню enum.

            var attribute = field?.GetCustomAttribute<DescriptionAttribute>();// Отримуємо атрибут Description для конкретного значення enum.

            return attribute?.Description ?? typeGun.ToString();// Якщо атрибут Description не знайдено, повертаємо назву enum як рядок.
        }


        private void AmmoCapacityGun(int ammoCapacity)
        {
            if (ammoCapacity < 0)
            {
                Console.WriteLine("Помилка: ємнiсть магазину не може бути вiд'ємною. Встановлено 0.");
                ammoCapacityGun = 0;
                ammoEnabled = false;
            }
            else
            {
                ammoCapacityGun = ammoCapacity;

                if (ammoCapacityGun > 0)
                { 
                    ammoEnabled = true;
                }
                else
                {
                    ammoEnabled = false;
                }
            }
        }

        public void FireGun()
        {
            int counter = 3;
            do
            {
                if (ammoEnabled == false)
                {
                    Console.WriteLine("Вiдсутнi патрони!");
                    LoadGun();
                }

                Console.WriteLine("Стрiляю...");
                while (ammoCapacityGun > 0)
                {
                    Console.Write("Патрони: ");
                    Console.Write(ammoCapacityGun + " ");
                    ammoCapacityGun--;
                }
                Console.WriteLine("\nПатрони закiнчилися!");
                ammoEnabled = false;
            }while (--counter > 0);

        }

        private void LoadGun()
        {
            Console.WriteLine("Зярджаю...");

            ammoCapacityGun = 30;

            ammoEnabled = true;

            Console.WriteLine("Зброю заряджено");  
        }

        public void GunInfo()
        {
            Console.WriteLine($"Тип зброї: {GetDescription(typeGun)}");
            Console.WriteLine($"Ємнiсть магазину: {ammoCapacityGun}");
            Console.WriteLine($"Заряджена: {(ammoEnabled ? "Так" : "Нi")}");
        }
        // Fix the constructor to accept TypeGun instead of Color, and assign it correctly
        public Gun(TypeGun typeGun, int ammoCapacityGun)
        {
            this.typeGun = typeGun;
            AmmoCapacityGun(ammoCapacityGun);
        }

        public Gun() : this(TypeGun.Unknown, 0) // Викликаємо конструктор з параметрами, встановлюючи тип зброї за замовчуванням та ємність магазину 0
        {
            typeGun = TypeGun.Unknown;
            ammoCapacityGun = 0;
            ammoEnabled = false;
        }

    }

    internal class Program
    {
        // Update the Main method to use the correct constructor
        static void Main(string[] args)
        {
           Gun gun = new Gun(TypeGun.Rifle, 30); // Create a gun with specific type and ammo capacity
            gun.GunInfo(); // Display gun information
            gun.FireGun(); // Attempt to fire the gun
            gun.GunInfo(); // Display gun information after firing
            
            Console.ReadLine();
        }
    }
}
