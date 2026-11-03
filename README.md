# Fibonacci ba kis absMax és barátaik

## AbsMaxx

```cs

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

```
elég menő dolog


most pedig következzen a Fiboo

## Fibo


```cs

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

```


## Jelszó erősség néző


```cs
int jelszo_erosseg(string jelszo)
{
       int erosseg = 1;
    if (jelszo.Length >= 5)
        erosseg++;
    if (jelszo.Length >= 8)
        erosseg+=2;
    foreach(char x in jelszo)
    {
        if (x == '_' || x == '-')
            erosseg += 2;

    }
    if (jelszo.Contains("123") || jelszo.Contains("jelszo"))
        erosseg = 0;
    if (jelszo.Length < 1)
        erosseg = 0;

    return erosseg;
}


Console.Write("Jelszo: ");
string a = Console.ReadLine();
Console.WriteLine( jelszo_erosseg(a));

```


## Magánhangzó nuku





```cs
string magan = "aáeéiíoóöőuúüű";
string semmi = "";

string tavolitas(string szoveg)
{
    foreach (char x in szoveg)
        if (!magan.Contains(x))
            semmi += x;
    return semmi;
}



Console.Write("Szoveg: ");
string b = Console.ReadLine();

Console.WriteLine(tavolitas(b));


```
