Console.Clear();

int count = 0, 
    friend = 2;
int firstFriendSpeed = 1, 
       secondFriendSpeed = 2,
       dogSpeed = 5;
double time;
//double distance = 10000;

Console.Write("Введите дистанцию в метрах: ");
double distance = Convert.ToDouble(Console.ReadLine());

while (distance > 10){
    if (friend == 1){
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else{
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    // Console.Write("Дистанция ");
    // Console.Write(distance);
    // Console.WriteLine(" км.");
    count++;
}

Console.Write("Собака пробежала ");
Console.Write(count);
Console.WriteLine(" раз");

