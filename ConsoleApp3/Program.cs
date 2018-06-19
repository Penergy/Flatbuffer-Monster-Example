using System;
using System.IO;
using FlatBuffers;
using MyGame.Sample;

namespace MyGame
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var builder = new FlatBufferBuilder(1);

        //    var weaponOneName = builder.CreateString("Sword");
        //    var weaponOneDamage = 3;
        //    var weaponTwoName = builder.CreateString("Axe");
        //    var weaponTwoDamage = 5;
        //    // Use the `CreateWeapon()` helper function to create the weapons, since we set every field.  
        //    var sword = Weapon.CreateWeapon(builder, weaponOneName, (short)weaponOneDamage);
        //    var axe = Weapon.CreateWeapon(builder, weaponTwoName, (short)weaponTwoDamage);

        //    // Serialize a name for our monster, called "Orc".  
        //    var name = builder.CreateString("Orc");
        //    // 创建一个矢量来表示会掉落的物品，  
        //    // 每一个数字都可以和一个道具通信。在兽人死后，对应的道具就会被声明。  
        //    //注意：我们放入byte的顺序，和取出来的时候是反的（比如我先放入的是9，但是数组里第9个才是9）  
        //    Monster.StartInventoryVector(builder, 10);
        //    for (int i = 9; i >= 0; i--)
        //    {
        //        builder.AddByte((byte)i);
        //    }
        //    var inv = builder.EndVector();

        //    var weaps = new Offset<Weapon>[2];
        //    weaps[0] = sword;
        //    weaps[1] = axe;
        //    // Pass the `weaps` array into the `CreateWeaponsVector()` method to create a FlatBuffer vector.  
        //    var weapons = Monster.CreateWeaponsVector(builder, weaps);

        //    // Create a `Vec3`, representing the Orc's position in 3-D space.  
        //    var pos = Vec3.CreateVec3(builder, 1.0f, 2.0f, 3.0f);

        //    // Create our monster using `StartMonster()` and `EndMonster()`.  
        //    Monster.StartMonster(builder);
        //    Monster.AddPos(builder, pos);
        //    Monster.AddHp(builder, (short)300);
        //    Monster.AddName(builder, name);
        //    Monster.AddInventory(builder, inv);
        //    Monster.AddColor(builder, Color.Red);
        //    Monster.AddWeapons(builder, weapons);
        //    Monster.AddEquippedType(builder, Equipment.Weapon);
        //    Monster.AddEquipped(builder, axe.Value); // Union类型包含两个字段。  
        //    var orc = Monster.EndMonster(builder);

        //    // Call `Finish()` to instruct the builder that this monster is complete.  
        //    builder.Finish(orc.Value); // You could also call `Monster.FinishMonsterBuffer(builder, orc);`.  

        //    using (var ms = new MemoryStream(builder.DataBuffer.ToFullArray(), builder.DataBuffer.Position, builder.Offset))
        //    {
        //        var data = ms.ToArray();
        //        File.WriteAllBytes(@"Resources/monsterdata_cstest.mon", data);
        //    }
        //    Console.ReadLine();
        //}
        static void Main(string[] args)
        {
            var data = File.ReadAllBytes(@"Resources/monsterdata_cstest.mon");
            var bb = new ByteBuffer(data);
            var monster = Monster.GetRootAsMonster(bb);
            // For C#, unlike other languages support by FlatBuffers, most values (except for  
            // vectors and unions) are available as propreties instead of asccessor methods.  
            var hp = monster.Hp;
            var mana = monster.Mana;
            var name = monster.Name;
            var pos = monster.Pos;
            int invLength = monster.InventoryLength;
            //var thirdItem = monster.GetInventory(2);
            int weaponsLength = monster.WeaponsLength;
            Console.WriteLine("Weapon number is {0}", weaponsLength);
            Console.WriteLine("Monster name is {0}", name);
            Console.WriteLine("Monster's hp is {0}", hp);
            Console.ReadKey();
        }
    }
}
