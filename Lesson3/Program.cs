namespace Lesson3
{
    public class App
    {
        public static void Main()
        {
            List<int> list = null;

            Console.WriteLine(GetValue(list));

            var myObject = new MyClass();

            if (myObject == null || myObject.myObject == null || myObject.myObject.lastObject == null) return;

        }

        public static int GetValue(List<int> list) => list.Count switch
        {
            0 => 0,
            1 => list[0],
            2 => list[1],
            3 => list[2],
            4 => list[3], 
            _ => -1
        };
    }

    public class MyClass
    {
        public MyClass2 myObject
        {
            get;
            set;
        }
    }

    public class MyClass2
    {
        public MyClass3 lastObject
        {
            get;
            set;
        }
    }

    public class MyClass3
    {

    }
}
