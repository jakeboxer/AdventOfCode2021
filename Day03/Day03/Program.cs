using System.Text;

var nums = File.ReadLines("input.txt").ToArray();
var halfCount = nums.Length * 0.5f;
var size = nums[0].Length;
var gamma = new StringBuilder();
var epsilon = new StringBuilder();

for (var digit = 0; digit < size; digit++) {
    var count = 0;

    foreach (var num in nums) {
        if (num[digit] == '1') {
            count++;
        }
    }

    if (count >= halfCount) {
        gamma.Append('1');
        epsilon.Append('0');
    } else {
        gamma.Append('0');
        epsilon.Append('1');
    }
}

Console.WriteLine(Convert.ToInt32(gamma.ToString(), 2) * Convert.ToInt32(epsilon.ToString(), 2));