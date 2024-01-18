Random rnd = new Random();

int myRandomNum;

int randomSum = 0;

for (int i = 0; i < 3; i++)
{

    myRandomNum = rnd.Next(0, 11); // 0 - 10
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My ransom number is: {myRandomNum}");
}

Console.WriteLine($"randm sum total: {randomSum}");