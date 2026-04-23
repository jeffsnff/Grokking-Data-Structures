namespace Chapter_2;

class Program
{
    static void Main(string[] args)
    {
        int[] numArray = new int[6];
        
        DiceRoles(numArray);
        PrintArray(numArray);
        FindMaxValue(numArray);
        
        
        void DiceRoles(int[] self)
        {
            Random _rng = new Random();
            for (int i = 0; i < 10000; i++)
            {
                int index = _rng.Next(1, 7);
                self[index-1] += 1;
            }
        }
        void FindMaxValue(int[] self)
        {
            if (self.Length == 0)
            {
                Console.WriteLine("Array is empty!");
                return;
            }

            int maxValue_index = 0;
            int minValue_index = 0;
            for (int index = 0; index < self.Length; index++)
            {
                if (self[maxValue_index] < self[index])
                {
                    maxValue_index = index;
                }

                if (self[minValue_index] > self[index])
                {
                    minValue_index = index;
                }
            }
            
            Console.WriteLine($"The side that came up most was : {maxValue_index+1}");
            Console.WriteLine($"The side that came up least was {minValue_index+1}");
        }
        void PrintArray(int[] self)
        {
            for(int index = 0; index < self.Length; index++)
            {
                Console.WriteLine($"{index+1} : {self[index]}");
            }
        }
    }
}