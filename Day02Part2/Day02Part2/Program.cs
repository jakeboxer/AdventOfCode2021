var x = 0;
var y = 0;
var aim = 0;

foreach (var line in File.ReadLines("input.txt")) {
    var tokens = line.Split();
    var amount = int.Parse(tokens[1]);
    var direction = tokens[0];

    switch (direction) {
        case "forward":
            x += amount;
            y += aim * amount;
            break;
        case "down":
            aim += amount;
            break;
        case "up":
            aim -= amount;
            break;
    }
}

Console.WriteLine(x * y);