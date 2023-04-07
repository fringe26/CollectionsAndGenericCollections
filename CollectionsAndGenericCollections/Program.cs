using System.Collections;

namespace CollectionsAndGenericsCollections
{
    class Program
    {
        public static void Main()
        {
            #region ArrayList NON GENERIC
            //int a = 15;
            //object obj = (object)a;
            //int b = (int)obj;
            //object[] arr = new object[4];
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(3);
            //arrayList.Add(3);
            //arrayList.Add(4);
            //arrayList.Add(6);
            //arrayList.Add(new Enemy());

            //object obt = new Enemy();


            //Console.WriteLine(arrayList.Capacity);
            //int salam = 0;
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    salam += (int)arrayList[i];
            //}
            #endregion

            #region Stack Queue Non Generic
            //Stack stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push("Salam");
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());


            //foreach (object item in stack)
            //{

            //    Console.WriteLine(item);
            //}

            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Dequeue());
            #endregion\

            #region List<T> Generic

            //List<List<string>> list = new List<List<string>>();

            //Weapon weapon = new Weapon();
            //Weapon weapon1 = new Weapon();
            //Weapon weapon2 = new Weapon();
            //Weapon weapon3 = new Weapon();


            //list.Add(new Weapon() { Name="AK47"});
            //list.Add(new Weapon() { Name = "adsasd" });
            //list.Add(new Weapon() { Name = "asdasd" });
            //list.Add(new Weapon() { Name = "asd" });

            //List<Weapon> newWeapons = new List<Weapon> { weapon1, weapon2 };

            //Weapon[] weapons = list.ToArray();

            //List<Weapon> list2 = weapons.ToList();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i].Name == "AK47")
            //    {
            //        list.RemoveAt(i);
            //    }
            //}

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Dictionary
            //var dictionary = new Dictionary<string, string>();
            
            //dictionary.Add("Tural", "099-350-00-15");
            //dictionary.TryAdd("Tural1", "099-350-00-15");
            //dictionary.TryAdd("Tural2", "099-350-00-15");

            

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item.Key +"-"+item.Value);
            //}
            #endregion 

            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(3);

            
        }
    }

  
}