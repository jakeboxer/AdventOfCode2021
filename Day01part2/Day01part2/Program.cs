var depths = File.ReadLines("input.txt").Select(int.Parse).ToArray();
var sums = new int[depths.Length];

for (var i = 0; i < depths.Length; i++) {
    var depth = depths[i];
    sums[i] += depth;

    if (i > 0) {
        sums[i - 1] += depth;
    }

    if (i > 1) {
        sums[i - 2] += depth;
    }

    Console.Write("\n");
}

var increases = 0;
var lastSum = int.MaxValue;

for (var i = 0; i < sums.Length - 2; i++) {
    var sum = sums[i];

    if (sum > lastSum) {
        increases++;
    }

    lastSum = sum;
}

Console.WriteLine(increases);