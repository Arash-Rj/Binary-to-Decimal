Console.Write("Please enter ones and zeros: ");
string n = Console.ReadLine();
Console.WriteLine("The decimal form  of the binary number: " + B2D(n));
bool check(string num1)
{
    bool s = false;
    for (int i = 0; i < num1.Length; i++)
    {
        int num = Convert.ToInt32(n[i].ToString());
        if (num != 1 && num != 0)
        {
            return s;
        }

    }
    return !s;
}
string B2D(string num)
{
    string n = "";
    bool check2 = check(num);
    if (check2==false)
    {
        n += "Ther inserted number is wrong.";
        return n; 
    }
    double N = 0;
    for (int i = 0; i < num.Length; i++)
    {
        double m = Convert.ToInt32(num[num.Length - 1 - i].ToString()) * power(2,i);
        N += m;
    }
    n += Convert.ToString(N);
    return n;
}
int power(int x,int y)
{
    int n = 1;
    if (y == 0)
    {
        return n; 
    }
    if(y>0)
    {
        for(int h=0; h < y; h++)
        {
            n *= x;
        }
    }
    return n;
}