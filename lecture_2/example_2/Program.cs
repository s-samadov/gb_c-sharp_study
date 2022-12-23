int Max(int arg1, int arg2, int arg3) //to find maximum of 3 arguments
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int [] array_1 = {11, 21, 31, 41, 175, 61, 17, 18, 19}; //massive
//                0   1   2                       8    index
array_1[0] = 12;
Console.WriteLine(array_1[0]);

int max = Max(
    Max(array_1[0], array_1[1], array_1[2]), 
    Max(array_1[3], array_1[4], array_1[5]),
    Max(array_1[6], array_1[7], array_1[8]));

Console.WriteLine(max);
