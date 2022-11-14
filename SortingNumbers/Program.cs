int[] nums = { 11, 22, 54, 87, 32, 87, 27 };

for (int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j < nums.Length; j++)
    {
        int temp = 0;
        if (nums[i] < nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;

        }

    }

}
foreach (var num in nums)
{
    Console.WriteLine(num);

}