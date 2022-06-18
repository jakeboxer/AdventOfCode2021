var increases = 0;
var lastDepth = int.MaxValue;

foreach (var line in File.ReadLines("input.txt")) {
    var currentDepth = int.Parse(line);

    if (currentDepth > lastDepth) {
        increases++;
    }

    lastDepth = currentDepth;
}

Console.WriteLine(increases);