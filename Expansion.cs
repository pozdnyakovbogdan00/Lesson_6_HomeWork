class Expansion_Greater_Than_Zero
{
    public static void Expansion_Greater_Than_Zero_Main()
    {
        int[] InputTextArr = InPutData_Greater_Than_Zero();
        int result = CalculateMoreThanZero(InputTextArr);
        CommonMethods.OutPutData("Your array" + ArrayToString(InputTextArr), "Result: " + Convert.ToString(result));
    }

    private static int[] InPutData_Greater_Than_Zero()
    {
        Console.WriteLine("Enter number of digits");
        int N = Convert.ToInt32(Console.ReadLine());
        int[] ArrayNumbers = new int[N];
        int i = 0;
        while (i < N)
        {
            Console.WriteLine("Enter " + (i + 1) + " number: ");
            ArrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }

        return ArrayNumbers;
    }

    private static int CalculateMoreThanZero(int[] InputTextArr)
    {
        int result = 0;

        foreach (var item in InputTextArr)
        {
            if (item > 0)
            {
                result++;
            }
        }

        return result;
    }

    private static string ArrayToString(int[] IntArray)
    {
        string StringArray = "[ ";

        foreach (var item in IntArray)
        {
            StringArray = StringArray + item + "; ";
        }

        StringArray = StringArray + "]";

        return StringArray;
    }

}

class Expansion_Find_Intersection
{
    public static void Expansion_Find_Intersection_Main()
    {
        double[] InputTextArr = InPutData_Find_Intersection();
        string result = FindTheIntersection(InputTextArr[2], InputTextArr[0], InputTextArr[3], InputTextArr[1]);
        CommonMethods.OutPutData(result);
    }

    private static double[] InPutData_Find_Intersection()
    {
        double[] Array = new double[4];
        Console.WriteLine("Enter b1: ");
        Array[0] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter k1: ");
        Array[1] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter b2: ");
        Array[2] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter k2: ");
        Array[3] = Convert.ToDouble(Console.ReadLine());

        return Array;
    }

    private static string FindTheIntersection(double b2, double b1 , double k2, double k1)
    {
        string result = "";
        
        double x = (b2-b1)/(k1-k2);
        double y = k1*x+b1;
        
        result = "("+x+";"+y+")";

        return result;
    }
}

class CommonMethods
{
    public static void OutPutData(params string[] OutPutText)
    {
        foreach (var item in OutPutText)
        {
            Console.WriteLine(item);
        }

    }    
}