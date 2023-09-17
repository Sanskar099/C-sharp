//FROMATTING CURRENCY
// decimal price = 123.4m;
// int discount = 50;
// Console.WriteLine($"price {price:C} saved {discount:C}");

//measurement
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N4} units"); // by defaul n only shows 2 digits after decimal

decimal num = 0.3645m;
Console.WriteLine($"percentage: {num:P2}"); //p for percentage and 2 does significant figure count (2 here)

decimal price = 67.55m;
decimal salePrice = 59.99m;

string discount = string.Format("you saved: {0:C2} off the regular price of {1:C2}",(price - salePrice),(price));
discount += $"that is a discount of {((price-salePrice)/price):P2}";
Console.WriteLine(discount);
