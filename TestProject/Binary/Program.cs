
namespace Binary
{
    internal class Program                        //Binary   |  HEX   |  //DECIMAL
    {    
        
                                                  //         |        |
        //const byte CHAINSAW = 0x01;             //00000001 |  0x01  |  1
        //const byte PISTOL = 0x01 << 1;          //00000010 |  0x02  |  2
        //const byte SHOTGUN = 0x01 << 2;         //00000100 |  0x04  |  4
        //const byte SUPER_SHOTGUN = 0x01 << 3;   //00001000 |  0x08  |  8
        //const byte CHAINGUN = 0x01 << 4;        //00010000 |  0x10  |  16
        //const byte ROCKET_LAUNCHER = 0x01 << 5; //00100000 |  0x20  |  32
        //const byte PLASMA_GUN = 0x01 << 6;      //01000000 |  0x40  |  64
        //const byte BFG9000 = 0x01 << 7;         //10000000 |  0x80  |  128 

        //public static readonly string[] weapons =
        //{
        //    "Fists", "Chainsaw", "Pistol", "Shotgun", "Super Shotgun", "Chaingun", "Rocket Launcher", "Plasma Gun", "BFG 9000"
        //};

        public enum Weapons { CHAINSAW = 0x01,
                              PISTOL = 0x01 << 1,
                              SHOTGUN = 0x01 << 2,
                              SUPERSHOTGUN = 0x01 << 3,
                              CHAINGUN = 0x01 << 4,
                              ROCKETLAUNCHER = 0x01 << 5,
                              PLASMAGUN = 0x01 << 6,
                              BFG9000 = 0x01 << 7
        };


        public static void AddToInventory(ref Weapons inventory, Weapons weapon)
        {

            //inventory |= weapon; //01000011 | 00000100 = 01000111
            inventory = inventory | weapon;
        }

        public static void PrintInventory(Weapons inventory)
        {
            string[] names = System.Enum.GetNames(typeof(Weapons));
            Console.Write("FISTS | ");
            for (int i = 0; i <= names.Length; i++)
            {
                int mask = 0x01 << i;
                if (((int)inventory & mask) == mask)
                {
                    Console.Write("{0} | ", names[i].ToString());
                }
            }

            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            Weapons inventory = 0;

            AddToInventory(ref inventory, Weapons.BFG9000);
            AddToInventory(ref inventory, Weapons.PISTOL);

            PrintInventory(inventory);
            Console.ReadKey();

            int r = 5;
            for (int i = 10; i < 50; i++)
            {
                ;
                Console.WriteLine(UsrRan(ref r));
            }
            Console.ReadKey();
        }

        static public double UsrRan(ref int ir)
        {
            double da = 16807.0;
            double db = 2147483647.0;
            double dc = 2147483648.0;

            ir = (int)Math.Abs(da * ir % db + 0.5);
            return ir / dc;
        }



    }
}