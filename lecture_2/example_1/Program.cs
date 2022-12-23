int Max(int arg1, int arg2, int arg3) //to find maximum of 3 arguments
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}


int a1 = 15;
int a2 = 12;
int a3 = 2156;
int b1 = 21;
int b2 = 23;
int b3 = 23334;
int c1 = 39;
int c2 = 33;
int c3 = 313;

//int max1 = Max(a1, a2, a3);
//int max2 = Max(b1, b2, b3);
//int max3 = Max(c1, c2, c3);
//int max = Max(max1, max2, max3);

int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

Console.WriteLine(max);
