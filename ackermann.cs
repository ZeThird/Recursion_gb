
using System;

public class HelloWorld
{
    
    private static uint akkerman(uint n, uint m) {
        if (n == 0) {
            return m + 1;
        } else if (m == 0) {
            return akkerman(n - 1, 1);
        }
        return akkerman(n - 1, akkerman(n, m - 1));
    } 
    
    public static void Main(string[] args)
    {
        Console.WriteLine(akkerman(4, 1));
    }
}
