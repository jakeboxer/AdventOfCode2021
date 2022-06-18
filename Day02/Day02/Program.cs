var x = 0;
var y = 0;

foreach (var line in File.ReadLines("input.txt")) {
    var tokens = line.Split();
    var amount = int.Parse(tokens[1]);
    var direction = tokens[0];

    switch (direction) {
        case "forward":
            x += amount;
            break;
        case "down":
            y += amount;
            break;
        case "up":
            y -= amount;
            break;
    }
}

Console.WriteLine(x * y);