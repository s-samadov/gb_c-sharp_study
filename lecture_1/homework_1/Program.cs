int distance = 10000;
int first_fried_speed = 1;
int second_friend_speed = 2;
int dog_speed = 5;
int friend = 2;
int count = 0;
int time = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (first_fried_speed + dog_speed);
        friend = 2;
    }
    else
    {
        time = distance / (second_friend_speed + dog_speed);
        friend = 1;
    }
    distance = distance - (first_fried_speed + second_friend_speed) * time;
    count = count + 1;
}
Console.Write("Dog run ");
Console.Write(count);
Console.Write(" times");