namespace ValueAndReferenceTypes;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 30;

        num1 = num2;
        num2 = 65;
        Console.WriteLine(num1);

        int[] nums1 = new int[] { 10, 20, 30 };
        int[] nums2 = new int[] { 100, 200, 300 };
        nums1 = nums2;
        nums2[0] = 999;
        Console.WriteLine(nums1[0]);


        Console.ReadLine();
    }
}

