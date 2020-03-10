using System;

namespace Queue
{
    class QueueDemo
    {
        private int[] q;
        private int f = -1, r = -1;
        private int max = 0;

        public QueueDemo(int max)
        {
            this.max = max;
            q = new int[max];
        }

        public void Push(int ele)
        {
            if (r == max - 1) Console.WriteLine("Queue Overflow");
            else
            {
                r++;
               q[r] = ele;
                if (f == -1) f++;
            }
        }

        public Boolean empty()
        {
            if (f == -1 ||f>r) return true;
            else return false;
        }

        public void Pop()
        {
            if (empty()) Console.WriteLine("Queue Underflow");
            else
            {
                int z = q[f];
                f++;
                Console.WriteLine("Deleted element:-" + z);
            }
        }

        public void Display()
        {
            for (int i = f; i <= r; i++)
            {
                Console.Write(q[i] + "");
                Console.WriteLine();
            }
        }

        public Boolean Serch(int ele)
        {
            Boolean result = false;
            for (int i = f; i <= r; i++)
            {
                if (ele == q[i])
                {
                    result = true;
                }
                else result = false;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the capacity of queue");
            int k = Convert.ToInt32(Console.ReadLine());
            QueueDemo obj = new QueueDemo(k);
            while (true)
            {
                Console.WriteLine("Enter the choice");
                Console.WriteLine("1:PUSH 2:POP 3:DISPLAY 4:SEARCH 5:Exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the element to push");
                        int ele = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            obj.Push(ele);
                        }
                        catch (Exception ex) { Console.WriteLine("Error:-" + ex); }
                        break;
                    case 2:
                        try
                        {
                            obj.Pop();
                        }
                        catch (Exception ex) { Console.WriteLine("Error:-" + ex); }
                        break;
                    case 3:
                        try
                        {
                            if (obj.empty() == true) Console.WriteLine("queue Empty");
                            else obj.Display();

                        }
                        catch (Exception ex) { Console.WriteLine("Error:-" + ex); }
                        break;
                    case 4:
                        Console.WriteLine("Enter the element to Search");
                        int searchEle = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            if (obj.Serch(searchEle)) Console.WriteLine(searchEle + " present in queue");
                            else Console.WriteLine(searchEle + " not present in queue");
                        }
                        catch (Exception ex) { Console.WriteLine("Error:-" + ex); }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}



    


