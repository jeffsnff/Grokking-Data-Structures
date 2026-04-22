namespace Chapter_2;

class Program
{
    static void Main(string[] args)
    {
        int[] numArray = new int[6];
        
        AddNumbersToArray(numArray);
        PrintArray(numArray);
        FindMaxValue(numArray);
        
        
        void AddNumbersToArray(int[] self)
        {
            Random _rng = new Random();
            for (int i = 0; i < 100; i++)
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

            int maxValue = self[0];
            int indexOfMaxValue = 0;
            for (int i = 0; i < self.Length; i++)
            {
                if (maxValue < self[i])
                {
                    maxValue = self[i];
                    indexOfMaxValue = i;
                }
            }
            
            Console.WriteLine($"The side that came up most was : {indexOfMaxValue+1}");
        }
        void PrintArray(int[] self)
        {
            for(int index = 0; index < self.Length; index++)
            {
                Console.WriteLine($"{index} : {self[index]}");
            }
        }
    }
}