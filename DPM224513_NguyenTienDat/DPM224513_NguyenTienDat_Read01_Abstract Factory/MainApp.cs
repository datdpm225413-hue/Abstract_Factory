using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM224513_NguyenTienDat_Read01_Abstract_Factory
{
    class MainApp
    {
        public static void Main()
        {
            // Tạo và chạy thế giới động vật Châu Phi
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Tạo và chạy thế giới động vật Châu Mỹ
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            Console.ReadKey();
        }
    }
}
