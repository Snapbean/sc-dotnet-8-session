var numbers = new int[] { 1, 2, 4, 8, 16 };

var result = false;

result = numbers is [1, 2, 4, 8, 16]; // true
result = numbers is [1, 4, 8, 16]; // false
result = numbers is [1, 2, 8, 4, 16]; // false
result = numbers is [1, 2, 8, 4, 15]; // false

// discard
result = numbers is [_, _, _, 8, _]; // true
result = numbers is [_, _, _, 8]; // false
result = numbers is [_, 2, _, 8, _]; // true
result = numbers is [_, 4, _, _, _]; // false

// range
result = numbers is [1, ..]; // true
result = numbers is [_, _, 4, ..]; // true
result = numbers is [1, .., 16]; // true

// var
result = numbers is [1, var a, ..]; // true

Console.WriteLine(result);