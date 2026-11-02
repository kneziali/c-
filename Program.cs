int abs_max(int a, int b)
{
  if (Math.Abs(a) > Math.Abs(b))
    {
        return Math.Abs(a);
    }
    else
    {
        return Math.Abs(b);
    }
}

Console.WriteLine(abs_max(-20, 10));



int fibo(int n)
{
   if (n  <= 1)
    {
        return n;
    }
   else
    {
        return fibo(n - 1) + fibo(n - 2);
    }
}

Console.WriteLine(fibo(14));