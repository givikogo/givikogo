using System;
using static System.Console;        

public class Program
{
    public static void Main()
    {
        	Assert.AreEquals(BinaryNumber(0), 1);
		Assert.AreEquals(BinaryNumber(2), 4);
		Assert.AreEquals(BinaryNumber(3), 8);
		Assert.AreEquals(BinaryNumber(19), 524288);
		Assert.AreEquals(BinaryNumber(10), 1024);
    }	
	                              
    public static int Poww(int k) 
	{
		int ans = 1, n = k;
		
        while(n >= 1)
        {
         	n--;
        	ans = ans * 2; 
        }
        
		return ans;
	}
	
	public static int BinaryNumber(int k) 
	{
	int a = Poww(k);
	
		return a;
	}
}

public static class Assert
{
	public static void AreEquals(int excepted, int actual)
	{
		AreEquals(excepted.ToString(), actual.ToString());
	}
	
	public static void AreEquals(string excepted, string actual) 
	{
		if (excepted == actual)
		{
			WriteLine($@"Result: {true}
					  
Excepted: 
{excepted}
					  
Actual:
{actual}");
		}
		else 
		{
			WriteLine($@"Result: {false}
					  
Excepted: 
{excepted} 
					  
Actual:
{actual}");
		}
		WriteLine();
	}
}
