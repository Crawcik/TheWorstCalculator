/*

Leave, before it's to late
It's you're last chance...



























*/
using System;

public static class Calculator
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Max number: 100");
		Console.WriteLine("First number: ");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Second number: ");
		int b = int.Parse(Console.ReadLine());
		Console.WriteLine("Do u wanna: a - Add, b - Subtract, c - Multiple, d - Divide");
		char method = Console.ReadKey().KeyChar;
		int result = 69;
		if(method == 'a')
		{
			result = Add(a, b);
		}
		else if(method == 'b')
		{
			result = Subtract(a, b);
		}
		else if(method == 'c')
		{
			result = Multiple(a, b);
		}
		else if(method == 'd')
		{
			result = Divide(a, b);
		}
		Console.WriteLine("\nOutput: " + result);
	}

	public static int Add(int a, int b)
	{
		if(a == 0 && b == 0)
		{
			return 0;
		}
		else if(a == 0 && b == 0)
		{
			return 0;
		}
		else if(a == 0 && b == 1)
		{
			return 1;
		}
		else if(a == 0 && b == 2)
		{
			return 2;
		}
		else if(a == 0 && b == 3)
		{
			return 3;
		}
		else if(a == 0 && b == 4)
		{
			return 4;
		}
		else if(a == 0 && b == 5)
		{
			return 5;
		}
		else if(a == 0 && b == 6)
		{
			return 6;
		}
		else if(a == 0 && b == 7)
		{
			return 7;
		}
		else if(a == 0 && b == 8)
		{
			return 8;
		}
		else if(a == 0 && b == 9)
		{
			return 9;
		}
		else if(a == 0 && b == 10)
		{
			return 10;
		}
		else if(a == 0 && b == 11)
		{
			return 11;
		}
		else if(a == 0 && b == 12)
		{
			return 12;
		}
		else if(a == 0 && b == 13)
		{
			return 13;
		}
		else if(a == 0 && b == 14)
		{
			return 14;
		}
		else if(a == 0 && b == 15)
		{
			return 15;
		}
		else if(a == 0 && b == 16)
		{
			return 16;
		}
		else if(a == 0 && b == 17)
		{
			return 17;
		}
		else if(a == 0 && b == 18)
		{
			return 18;
		}
		else if(a == 0 && b == 19)
		{
			return 19;
		}
		else if(a == 0 && b == 20)
		{
			return 20;
		}
		else if(a == 0 && b == 21)
		{
			return 21;
		}
		else if(a == 0 && b == 22)
		{
			return 22;
		}
		else if(a == 0 && b == 23)
		{
			return 23;
		}
		else if(a == 0 && b == 24)
		{
			return 24;
		}
		else if(a == 0 && b == 25)
		{
			return 25;
		}
		else if(a == 0 && b == 26)
		{
			return 26;
		}
		else if(a == 0 && b == 27)
		{
			return 27;
		}
		else if(a == 0 && b == 28)
		{
			return 28;
		}
		else if(a == 0 && b == 29)
		{
			return 29;
		}
		else if(a == 0 && b == 30)
		{
			return 30;
		}
		else if(a == 0 && b == 31)
		{
			return 31;
		}
		else if(a == 0 && b == 32)
		{
			return 32;
		}
		else if(a == 0 && b == 33)
		{
			return 33;
		}
		else if(a == 0 && b == 34)
		{
			return 34;
		}
		else if(a == 0 && b == 35)
		{
			return 35;
		}
		else if(a == 0 && b == 36)
		{
			return 36;
		}
		else if(a == 0 && b == 37)
		{
			return 37;
		}
		else if(a == 0 && b == 38)
		{
			return 38;
		}
		else if(a == 0 && b == 39)
		{
			return 39;
		}
		else if(a == 0 && b == 40)
		{
			return 40;
		}
		else if(a == 0 && b == 41)
		{
			return 41;
		}
		else if(a == 0 && b == 42)
		{
			return 42;
		}
		else if(a == 0 && b == 43)
		{
			return 43;
		}
		else if(a == 0 && b == 44)
		{
			return 44;
		}
		else if(a == 0 && b == 45)
		{
			return 45;
		}
		else if(a == 0 && b == 46)
		{
			return 46;
		}
		else if(a == 0 && b == 47)
		{
			return 47;
		}
		else if(a == 0 && b == 48)
		{
			return 48;
		}
		else if(a == 0 && b == 49)
		{
			return 49;
		}
		else if(a == 0 && b == 50)
		{
			return 50;
		}
		else if(a == 0 && b == 51)
		{
			return 51;
		}
		else if(a == 0 && b == 52)
		{
			return 52;
		}
		else if(a == 0 && b == 53)
		{
			return 53;
		}
		else if(a == 0 && b == 54)
		{
			return 54;
		}
		else if(a == 0 && b == 55)
		{
			return 55;
		}
		else if(a == 0 && b == 56)
		{
			return 56;
		}
		else if(a == 0 && b == 57)
		{
			return 57;
		}
		else if(a == 0 && b == 58)
		{
			return 58;
		}
		else if(a == 0 && b == 59)
		{
			return 59;
		}
		else if(a == 0 && b == 60)
		{
			return 60;
		}
		else if(a == 0 && b == 61)
		{
			return 61;
		}
		else if(a == 0 && b == 62)
		{
			return 62;
		}
		else if(a == 0 && b == 63)
		{
			return 63;
		}
		else if(a == 0 && b == 64)
		{
			return 64;
		}
		else if(a == 0 && b == 65)
		{
			return 65;
		}
		else if(a == 0 && b == 66)
		{
			return 66;
		}
		else if(a == 0 && b == 67)
		{
			return 67;
		}
		else if(a == 0 && b == 68)
		{
			return 68;
		}
		else if(a == 0 && b == 69)
		{
			return 69;
		}
		else if(a == 0 && b == 70)
		{
			return 70;
		}
		else if(a == 0 && b == 71)
		{
			return 71;
		}
		else if(a == 0 && b == 72)
		{
			return 72;
		}
		else if(a == 0 && b == 73)
		{
			return 73;
		}
		else if(a == 0 && b == 74)
		{
			return 74;
		}
		else if(a == 0 && b == 75)
		{
			return 75;
		}
		else if(a == 0 && b == 76)
		{
			return 76;
		}
		else if(a == 0 && b == 77)
		{
			return 77;
		}
		else if(a == 0 && b == 78)
		{
			return 78;
		}
		else if(a == 0 && b == 79)
		{
			return 79;
		}
		else if(a == 0 && b == 80)
		{
			return 80;
		}
		else if(a == 0 && b == 81)
		{
			return 81;
		}
		else if(a == 0 && b == 82)
		{
			return 82;
		}
		else if(a == 0 && b == 83)
		{
			return 83;
		}
		else if(a == 0 && b == 84)
		{
			return 84;
		}
		else if(a == 0 && b == 85)
		{
			return 85;
		}
		else if(a == 0 && b == 86)
		{
			return 86;
		}
		else if(a == 0 && b == 87)
		{
			return 87;
		}
		else if(a == 0 && b == 88)
		{
			return 88;
		}
		else if(a == 0 && b == 89)
		{
			return 89;
		}
		else if(a == 0 && b == 90)
		{
			return 90;
		}
		else if(a == 0 && b == 91)
		{
			return 91;
		}
		else if(a == 0 && b == 92)
		{
			return 92;
		}
		else if(a == 0 && b == 93)
		{
			return 93;
		}
		else if(a == 0 && b == 94)
		{
			return 94;
		}
		else if(a == 0 && b == 95)
		{
			return 95;
		}
		else if(a == 0 && b == 96)
		{
			return 96;
		}
		else if(a == 0 && b == 97)
		{
			return 97;
		}
		else if(a == 0 && b == 98)
		{
			return 98;
		}
		else if(a == 0 && b == 99)
		{
			return 99;
		}
		else if(a == 0 && b == 100)
		{
			return 100;
		}
		else if(a == 1 && b == 0)
		{
			return 1;
		}
		else if(a == 1 && b == 1)
		{
			return 2;
		}
		else if(a == 1 && b == 2)
		{
			return 3;
		}
		else if(a == 1 && b == 3)
		{
			return 4;
		}
		else if(a == 1 && b == 4)
		{
			return 5;
		}
		else if(a == 1 && b == 5)
		{
			return 6;
		}
		else if(a == 1 && b == 6)
		{
			return 7;
		}
		else if(a == 1 && b == 7)
		{
			return 8;
		}
		else if(a == 1 && b == 8)
		{
			return 9;
		}
		else if(a == 1 && b == 9)
		{
			return 10;
		}
		else if(a == 1 && b == 10)
		{
			return 11;
		}
		else if(a == 1 && b == 11)
		{
			return 12;
		}
		else if(a == 1 && b == 12)
		{
			return 13;
		}
		else if(a == 1 && b == 13)
		{
			return 14;
		}
		else if(a == 1 && b == 14)
		{
			return 15;
		}
		else if(a == 1 && b == 15)
		{
			return 16;
		}
		else if(a == 1 && b == 16)
		{
			return 17;
		}
		else if(a == 1 && b == 17)
		{
			return 18;
		}
		else if(a == 1 && b == 18)
		{
			return 19;
		}
		else if(a == 1 && b == 19)
		{
			return 20;
		}
		else if(a == 1 && b == 20)
		{
			return 21;
		}
		else if(a == 1 && b == 21)
		{
			return 22;
		}
		else if(a == 1 && b == 22)
		{
			return 23;
		}
		else if(a == 1 && b == 23)
		{
			return 24;
		}
		else if(a == 1 && b == 24)
		{
			return 25;
		}
		else if(a == 1 && b == 25)
		{
			return 26;
		}
		else if(a == 1 && b == 26)
		{
			return 27;
		}
		else if(a == 1 && b == 27)
		{
			return 28;
		}
		else if(a == 1 && b == 28)
		{
			return 29;
		}
		else if(a == 1 && b == 29)
		{
			return 30;
		}
		else if(a == 1 && b == 30)
		{
			return 31;
		}
		else if(a == 1 && b == 31)
		{
			return 32;
		}
		else if(a == 1 && b == 32)
		{
			return 33;
		}
		else if(a == 1 && b == 33)
		{
			return 34;
		}
		else if(a == 1 && b == 34)
		{
			return 35;
		}
		else if(a == 1 && b == 35)
		{
			return 36;
		}
		else if(a == 1 && b == 36)
		{
			return 37;
		}
		else if(a == 1 && b == 37)
		{
			return 38;
		}
		else if(a == 1 && b == 38)
		{
			return 39;
		}
		else if(a == 1 && b == 39)
		{
			return 40;
		}
		else if(a == 1 && b == 40)
		{
			return 41;
		}
		else if(a == 1 && b == 41)
		{
			return 42;
		}
		else if(a == 1 && b == 42)
		{
			return 43;
		}
		else if(a == 1 && b == 43)
		{
			return 44;
		}
		else if(a == 1 && b == 44)
		{
			return 45;
		}
		else if(a == 1 && b == 45)
		{
			return 46;
		}
		else if(a == 1 && b == 46)
		{
			return 47;
		}
		else if(a == 1 && b == 47)
		{
			return 48;
		}
		else if(a == 1 && b == 48)
		{
			return 49;
		}
		else if(a == 1 && b == 49)
		{
			return 50;
		}
		else if(a == 1 && b == 50)
		{
			return 51;
		}
		else if(a == 1 && b == 51)
		{
			return 52;
		}
		else if(a == 1 && b == 52)
		{
			return 53;
		}
		else if(a == 1 && b == 53)
		{
			return 54;
		}
		else if(a == 1 && b == 54)
		{
			return 55;
		}
		else if(a == 1 && b == 55)
		{
			return 56;
		}
		else if(a == 1 && b == 56)
		{
			return 57;
		}
		else if(a == 1 && b == 57)
		{
			return 58;
		}
		else if(a == 1 && b == 58)
		{
			return 59;
		}
		else if(a == 1 && b == 59)
		{
			return 60;
		}
		else if(a == 1 && b == 60)
		{
			return 61;
		}
		else if(a == 1 && b == 61)
		{
			return 62;
		}
		else if(a == 1 && b == 62)
		{
			return 63;
		}
		else if(a == 1 && b == 63)
		{
			return 64;
		}
		else if(a == 1 && b == 64)
		{
			return 65;
		}
		else if(a == 1 && b == 65)
		{
			return 66;
		}
		else if(a == 1 && b == 66)
		{
			return 67;
		}
		else if(a == 1 && b == 67)
		{
			return 68;
		}
		else if(a == 1 && b == 68)
		{
			return 69;
		}
		else if(a == 1 && b == 69)
		{
			return 70;
		}
		else if(a == 1 && b == 70)
		{
			return 71;
		}
		else if(a == 1 && b == 71)
		{
			return 72;
		}
		else if(a == 1 && b == 72)
		{
			return 73;
		}
		else if(a == 1 && b == 73)
		{
			return 74;
		}
		else if(a == 1 && b == 74)
		{
			return 75;
		}
		else if(a == 1 && b == 75)
		{
			return 76;
		}
		else if(a == 1 && b == 76)
		{
			return 77;
		}
		else if(a == 1 && b == 77)
		{
			return 78;
		}
		else if(a == 1 && b == 78)
		{
			return 79;
		}
		else if(a == 1 && b == 79)
		{
			return 80;
		}
		else if(a == 1 && b == 80)
		{
			return 81;
		}
		else if(a == 1 && b == 81)
		{
			return 82;
		}
		else if(a == 1 && b == 82)
		{
			return 83;
		}
		else if(a == 1 && b == 83)
		{
			return 84;
		}
		else if(a == 1 && b == 84)
		{
			return 85;
		}
		else if(a == 1 && b == 85)
		{
			return 86;
		}
		else if(a == 1 && b == 86)
		{
			return 87;
		}
		else if(a == 1 && b == 87)
		{
			return 88;
		}
		else if(a == 1 && b == 88)
		{
			return 89;
		}
		else if(a == 1 && b == 89)
		{
			return 90;
		}
		else if(a == 1 && b == 90)
		{
			return 91;
		}
		else if(a == 1 && b == 91)
		{
			return 92;
		}
		else if(a == 1 && b == 92)
		{
			return 93;
		}
		else if(a == 1 && b == 93)
		{
			return 94;
		}
		else if(a == 1 && b == 94)
		{
			return 95;
		}
		else if(a == 1 && b == 95)
		{
			return 96;
		}
		else if(a == 1 && b == 96)
		{
			return 97;
		}
		else if(a == 1 && b == 97)
		{
			return 98;
		}
		else if(a == 1 && b == 98)
		{
			return 99;
		}
		else if(a == 1 && b == 99)
		{
			return 100;
		}
		else if(a == 1 && b == 100)
		{
			return 101;
		}
		else if(a == 2 && b == 0)
		{
			return 2;
		}
		else if(a == 2 && b == 1)
		{
			return 3;
		}
		else if(a == 2 && b == 2)
		{
			return 4;
		}
		else if(a == 2 && b == 3)
		{
			return 5;
		}
		else if(a == 2 && b == 4)
		{
			return 6;
		}
		else if(a == 2 && b == 5)
		{
			return 7;
		}
		else if(a == 2 && b == 6)
		{
			return 8;
		}
		else if(a == 2 && b == 7)
		{
			return 9;
		}
		else if(a == 2 && b == 8)
		{
			return 10;
		}
		else if(a == 2 && b == 9)
		{
			return 11;
		}
		else if(a == 2 && b == 10)
		{
			return 12;
		}
		else if(a == 2 && b == 11)
		{
			return 13;
		}
		else if(a == 2 && b == 12)
		{
			return 14;
		}
		else if(a == 2 && b == 13)
		{
			return 15;
		}
		else if(a == 2 && b == 14)
		{
			return 16;
		}
		else if(a == 2 && b == 15)
		{
			return 17;
		}
		else if(a == 2 && b == 16)
		{
			return 18;
		}
		else if(a == 2 && b == 17)
		{
			return 19;
		}
		else if(a == 2 && b == 18)
		{
			return 20;
		}
		else if(a == 2 && b == 19)
		{
			return 21;
		}
		else if(a == 2 && b == 20)
		{
			return 22;
		}
		else if(a == 2 && b == 21)
		{
			return 23;
		}
		else if(a == 2 && b == 22)
		{
			return 24;
		}
		else if(a == 2 && b == 23)
		{
			return 25;
		}
		else if(a == 2 && b == 24)
		{
			return 26;
		}
		else if(a == 2 && b == 25)
		{
			return 27;
		}
		else if(a == 2 && b == 26)
		{
			return 28;
		}
		else if(a == 2 && b == 27)
		{
			return 29;
		}
		else if(a == 2 && b == 28)
		{
			return 30;
		}
		else if(a == 2 && b == 29)
		{
			return 31;
		}
		else if(a == 2 && b == 30)
		{
			return 32;
		}
		else if(a == 2 && b == 31)
		{
			return 33;
		}
		else if(a == 2 && b == 32)
		{
			return 34;
		}
		else if(a == 2 && b == 33)
		{
			return 35;
		}
		else if(a == 2 && b == 34)
		{
			return 36;
		}
		else if(a == 2 && b == 35)
		{
			return 37;
		}
		else if(a == 2 && b == 36)
		{
			return 38;
		}
		else if(a == 2 && b == 37)
		{
			return 39;
		}
		else if(a == 2 && b == 38)
		{
			return 40;
		}
		else if(a == 2 && b == 39)
		{
			return 41;
		}
		else if(a == 2 && b == 40)
		{
			return 42;
		}
		else if(a == 2 && b == 41)
		{
			return 43;
		}
		else if(a == 2 && b == 42)
		{
			return 44;
		}
		else if(a == 2 && b == 43)
		{
			return 45;
		}
		else if(a == 2 && b == 44)
		{
			return 46;
		}
		else if(a == 2 && b == 45)
		{
			return 47;
		}
		else if(a == 2 && b == 46)
		{
			return 48;
		}
		else if(a == 2 && b == 47)
		{
			return 49;
		}
		else if(a == 2 && b == 48)
		{
			return 50;
		}
		else if(a == 2 && b == 49)
		{
			return 51;
		}
		else if(a == 2 && b == 50)
		{
			return 52;
		}
		else if(a == 2 && b == 51)
		{
			return 53;
		}
		else if(a == 2 && b == 52)
		{
			return 54;
		}
		else if(a == 2 && b == 53)
		{
			return 55;
		}
		else if(a == 2 && b == 54)
		{
			return 56;
		}
		else if(a == 2 && b == 55)
		{
			return 57;
		}
		else if(a == 2 && b == 56)
		{
			return 58;
		}
		else if(a == 2 && b == 57)
		{
			return 59;
		}
		else if(a == 2 && b == 58)
		{
			return 60;
		}
		else if(a == 2 && b == 59)
		{
			return 61;
		}
		else if(a == 2 && b == 60)
		{
			return 62;
		}
		else if(a == 2 && b == 61)
		{
			return 63;
		}
		else if(a == 2 && b == 62)
		{
			return 64;
		}
		else if(a == 2 && b == 63)
		{
			return 65;
		}
		else if(a == 2 && b == 64)
		{
			return 66;
		}
		else if(a == 2 && b == 65)
		{
			return 67;
		}
		else if(a == 2 && b == 66)
		{
			return 68;
		}
		else if(a == 2 && b == 67)
		{
			return 69;
		}
		else if(a == 2 && b == 68)
		{
			return 70;
		}
		else if(a == 2 && b == 69)
		{
			return 71;
		}
		else if(a == 2 && b == 70)
		{
			return 72;
		}
		else if(a == 2 && b == 71)
		{
			return 73;
		}
		else if(a == 2 && b == 72)
		{
			return 74;
		}
		else if(a == 2 && b == 73)
		{
			return 75;
		}
		else if(a == 2 && b == 74)
		{
			return 76;
		}
		else if(a == 2 && b == 75)
		{
			return 77;
		}
		else if(a == 2 && b == 76)
		{
			return 78;
		}
		else if(a == 2 && b == 77)
		{
			return 79;
		}
		else if(a == 2 && b == 78)
		{
			return 80;
		}
		else if(a == 2 && b == 79)
		{
			return 81;
		}
		else if(a == 2 && b == 80)
		{
			return 82;
		}
		else if(a == 2 && b == 81)
		{
			return 83;
		}
		else if(a == 2 && b == 82)
		{
			return 84;
		}
		else if(a == 2 && b == 83)
		{
			return 85;
		}
		else if(a == 2 && b == 84)
		{
			return 86;
		}
		else if(a == 2 && b == 85)
		{
			return 87;
		}
		else if(a == 2 && b == 86)
		{
			return 88;
		}
		else if(a == 2 && b == 87)
		{
			return 89;
		}
		else if(a == 2 && b == 88)
		{
			return 90;
		}
		else if(a == 2 && b == 89)
		{
			return 91;
		}
		else if(a == 2 && b == 90)
		{
			return 92;
		}
		else if(a == 2 && b == 91)
		{
			return 93;
		}
		else if(a == 2 && b == 92)
		{
			return 94;
		}
		else if(a == 2 && b == 93)
		{
			return 95;
		}
		else if(a == 2 && b == 94)
		{
			return 96;
		}
		else if(a == 2 && b == 95)
		{
			return 97;
		}
		else if(a == 2 && b == 96)
		{
			return 98;
		}
		else if(a == 2 && b == 97)
		{
			return 99;
		}
		else if(a == 2 && b == 98)
		{
			return 100;
		}
		else if(a == 2 && b == 99)
		{
			return 101;
		}
		else if(a == 2 && b == 100)
		{
			return 102;
		}
		else if(a == 3 && b == 0)
		{
			return 3;
		}
		else if(a == 3 && b == 1)
		{
			return 4;
		}
		else if(a == 3 && b == 2)
		{
			return 5;
		}
		else if(a == 3 && b == 3)
		{
			return 6;
		}
		else if(a == 3 && b == 4)
		{
			return 7;
		}
		else if(a == 3 && b == 5)
		{
			return 8;
		}
		else if(a == 3 && b == 6)
		{
			return 9;
		}
		else if(a == 3 && b == 7)
		{
			return 10;
		}
		else if(a == 3 && b == 8)
		{
			return 11;
		}
		else if(a == 3 && b == 9)
		{
			return 12;
		}
		else if(a == 3 && b == 10)
		{
			return 13;
		}
		else if(a == 3 && b == 11)
		{
			return 14;
		}
		else if(a == 3 && b == 12)
		{
			return 15;
		}
		else if(a == 3 && b == 13)
		{
			return 16;
		}
		else if(a == 3 && b == 14)
		{
			return 17;
		}
		else if(a == 3 && b == 15)
		{
			return 18;
		}
		else if(a == 3 && b == 16)
		{
			return 19;
		}
		else if(a == 3 && b == 17)
		{
			return 20;
		}
		else if(a == 3 && b == 18)
		{
			return 21;
		}
		else if(a == 3 && b == 19)
		{
			return 22;
		}
		else if(a == 3 && b == 20)
		{
			return 23;
		}
		else if(a == 3 && b == 21)
		{
			return 24;
		}
		else if(a == 3 && b == 22)
		{
			return 25;
		}
		else if(a == 3 && b == 23)
		{
			return 26;
		}
		else if(a == 3 && b == 24)
		{
			return 27;
		}
		else if(a == 3 && b == 25)
		{
			return 28;
		}
		else if(a == 3 && b == 26)
		{
			return 29;
		}
		else if(a == 3 && b == 27)
		{
			return 30;
		}
		else if(a == 3 && b == 28)
		{
			return 31;
		}
		else if(a == 3 && b == 29)
		{
			return 32;
		}
		else if(a == 3 && b == 30)
		{
			return 33;
		}
		else if(a == 3 && b == 31)
		{
			return 34;
		}
		else if(a == 3 && b == 32)
		{
			return 35;
		}
		else if(a == 3 && b == 33)
		{
			return 36;
		}
		else if(a == 3 && b == 34)
		{
			return 37;
		}
		else if(a == 3 && b == 35)
		{
			return 38;
		}
		else if(a == 3 && b == 36)
		{
			return 39;
		}
		else if(a == 3 && b == 37)
		{
			return 40;
		}
		else if(a == 3 && b == 38)
		{
			return 41;
		}
		else if(a == 3 && b == 39)
		{
			return 42;
		}
		else if(a == 3 && b == 40)
		{
			return 43;
		}
		else if(a == 3 && b == 41)
		{
			return 44;
		}
		else if(a == 3 && b == 42)
		{
			return 45;
		}
		else if(a == 3 && b == 43)
		{
			return 46;
		}
		else if(a == 3 && b == 44)
		{
			return 47;
		}
		else if(a == 3 && b == 45)
		{
			return 48;
		}
		else if(a == 3 && b == 46)
		{
			return 49;
		}
		else if(a == 3 && b == 47)
		{
			return 50;
		}
		else if(a == 3 && b == 48)
		{
			return 51;
		}
		else if(a == 3 && b == 49)
		{
			return 52;
		}
		else if(a == 3 && b == 50)
		{
			return 53;
		}
		else if(a == 3 && b == 51)
		{
			return 54;
		}
		else if(a == 3 && b == 52)
		{
			return 55;
		}
		else if(a == 3 && b == 53)
		{
			return 56;
		}
		else if(a == 3 && b == 54)
		{
			return 57;
		}
		else if(a == 3 && b == 55)
		{
			return 58;
		}
		else if(a == 3 && b == 56)
		{
			return 59;
		}
		else if(a == 3 && b == 57)
		{
			return 60;
		}
		else if(a == 3 && b == 58)
		{
			return 61;
		}
		else if(a == 3 && b == 59)
		{
			return 62;
		}
		else if(a == 3 && b == 60)
		{
			return 63;
		}
		else if(a == 3 && b == 61)
		{
			return 64;
		}
		else if(a == 3 && b == 62)
		{
			return 65;
		}
		else if(a == 3 && b == 63)
		{
			return 66;
		}
		else if(a == 3 && b == 64)
		{
			return 67;
		}
		else if(a == 3 && b == 65)
		{
			return 68;
		}
		else if(a == 3 && b == 66)
		{
			return 69;
		}
		else if(a == 3 && b == 67)
		{
			return 70;
		}
		else if(a == 3 && b == 68)
		{
			return 71;
		}
		else if(a == 3 && b == 69)
		{
			return 72;
		}
		else if(a == 3 && b == 70)
		{
			return 73;
		}
		else if(a == 3 && b == 71)
		{
			return 74;
		}
		else if(a == 3 && b == 72)
		{
			return 75;
		}
		else if(a == 3 && b == 73)
		{
			return 76;
		}
		else if(a == 3 && b == 74)
		{
			return 77;
		}
		else if(a == 3 && b == 75)
		{
			return 78;
		}
		else if(a == 3 && b == 76)
		{
			return 79;
		}
		else if(a == 3 && b == 77)
		{
			return 80;
		}
		else if(a == 3 && b == 78)
		{
			return 81;
		}
		else if(a == 3 && b == 79)
		{
			return 82;
		}
		else if(a == 3 && b == 80)
		{
			return 83;
		}
		else if(a == 3 && b == 81)
		{
			return 84;
		}
		else if(a == 3 && b == 82)
		{
			return 85;
		}
		else if(a == 3 && b == 83)
		{
			return 86;
		}
		else if(a == 3 && b == 84)
		{
			return 87;
		}
		else if(a == 3 && b == 85)
		{
			return 88;
		}
		else if(a == 3 && b == 86)
		{
			return 89;
		}
		else if(a == 3 && b == 87)
		{
			return 90;
		}
		else if(a == 3 && b == 88)
		{
			return 91;
		}
		else if(a == 3 && b == 89)
		{
			return 92;
		}
		else if(a == 3 && b == 90)
		{
			return 93;
		}
		else if(a == 3 && b == 91)
		{
			return 94;
		}
		else if(a == 3 && b == 92)
		{
			return 95;
		}
		else if(a == 3 && b == 93)
		{
			return 96;
		}
		else if(a == 3 && b == 94)
		{
			return 97;
		}
		else if(a == 3 && b == 95)
		{
			return 98;
		}
		else if(a == 3 && b == 96)
		{
			return 99;
		}
		else if(a == 3 && b == 97)
		{
			return 100;
		}
		else if(a == 3 && b == 98)
		{
			return 101;
		}
		else if(a == 3 && b == 99)
		{
			return 102;
		}
		else if(a == 3 && b == 100)
		{
			return 103;
		}
		else if(a == 4 && b == 0)
		{
			return 4;
		}
		else if(a == 4 && b == 1)
		{
			return 5;
		}
		else if(a == 4 && b == 2)
		{
			return 6;
		}
		else if(a == 4 && b == 3)
		{
			return 7;
		}
		else if(a == 4 && b == 4)
		{
			return 8;
		}
		else if(a == 4 && b == 5)
		{
			return 9;
		}
		else if(a == 4 && b == 6)
		{
			return 10;
		}
		else if(a == 4 && b == 7)
		{
			return 11;
		}
		else if(a == 4 && b == 8)
		{
			return 12;
		}
		else if(a == 4 && b == 9)
		{
			return 13;
		}
		else if(a == 4 && b == 10)
		{
			return 14;
		}
		else if(a == 4 && b == 11)
		{
			return 15;
		}
		else if(a == 4 && b == 12)
		{
			return 16;
		}
		else if(a == 4 && b == 13)
		{
			return 17;
		}
		else if(a == 4 && b == 14)
		{
			return 18;
		}
		else if(a == 4 && b == 15)
		{
			return 19;
		}
		else if(a == 4 && b == 16)
		{
			return 20;
		}
		else if(a == 4 && b == 17)
		{
			return 21;
		}
		else if(a == 4 && b == 18)
		{
			return 22;
		}
		else if(a == 4 && b == 19)
		{
			return 23;
		}
		else if(a == 4 && b == 20)
		{
			return 24;
		}
		else if(a == 4 && b == 21)
		{
			return 25;
		}
		else if(a == 4 && b == 22)
		{
			return 26;
		}
		else if(a == 4 && b == 23)
		{
			return 27;
		}
		else if(a == 4 && b == 24)
		{
			return 28;
		}
		else if(a == 4 && b == 25)
		{
			return 29;
		}
		else if(a == 4 && b == 26)
		{
			return 30;
		}
		else if(a == 4 && b == 27)
		{
			return 31;
		}
		else if(a == 4 && b == 28)
		{
			return 32;
		}
		else if(a == 4 && b == 29)
		{
			return 33;
		}
		else if(a == 4 && b == 30)
		{
			return 34;
		}
		else if(a == 4 && b == 31)
		{
			return 35;
		}
		else if(a == 4 && b == 32)
		{
			return 36;
		}
		else if(a == 4 && b == 33)
		{
			return 37;
		}
		else if(a == 4 && b == 34)
		{
			return 38;
		}
		else if(a == 4 && b == 35)
		{
			return 39;
		}
		else if(a == 4 && b == 36)
		{
			return 40;
		}
		else if(a == 4 && b == 37)
		{
			return 41;
		}
		else if(a == 4 && b == 38)
		{
			return 42;
		}
		else if(a == 4 && b == 39)
		{
			return 43;
		}
		else if(a == 4 && b == 40)
		{
			return 44;
		}
		else if(a == 4 && b == 41)
		{
			return 45;
		}
		else if(a == 4 && b == 42)
		{
			return 46;
		}
		else if(a == 4 && b == 43)
		{
			return 47;
		}
		else if(a == 4 && b == 44)
		{
			return 48;
		}
		else if(a == 4 && b == 45)
		{
			return 49;
		}
		else if(a == 4 && b == 46)
		{
			return 50;
		}
		else if(a == 4 && b == 47)
		{
			return 51;
		}
		else if(a == 4 && b == 48)
		{
			return 52;
		}
		else if(a == 4 && b == 49)
		{
			return 53;
		}
		else if(a == 4 && b == 50)
		{
			return 54;
		}
		else if(a == 4 && b == 51)
		{
			return 55;
		}
		else if(a == 4 && b == 52)
		{
			return 56;
		}
		else if(a == 4 && b == 53)
		{
			return 57;
		}
		else if(a == 4 && b == 54)
		{
			return 58;
		}
		else if(a == 4 && b == 55)
		{
			return 59;
		}
		else if(a == 4 && b == 56)
		{
			return 60;
		}
		else if(a == 4 && b == 57)
		{
			return 61;
		}
		else if(a == 4 && b == 58)
		{
			return 62;
		}
		else if(a == 4 && b == 59)
		{
			return 63;
		}
		else if(a == 4 && b == 60)
		{
			return 64;
		}
		else if(a == 4 && b == 61)
		{
			return 65;
		}
		else if(a == 4 && b == 62)
		{
			return 66;
		}
		else if(a == 4 && b == 63)
		{
			return 67;
		}
		else if(a == 4 && b == 64)
		{
			return 68;
		}
		else if(a == 4 && b == 65)
		{
			return 69;
		}
		else if(a == 4 && b == 66)
		{
			return 70;
		}
		else if(a == 4 && b == 67)
		{
			return 71;
		}
		else if(a == 4 && b == 68)
		{
			return 72;
		}
		else if(a == 4 && b == 69)
		{
			return 73;
		}
		else if(a == 4 && b == 70)
		{
			return 74;
		}
		else if(a == 4 && b == 71)
		{
			return 75;
		}
		else if(a == 4 && b == 72)
		{
			return 76;
		}
		else if(a == 4 && b == 73)
		{
			return 77;
		}
		else if(a == 4 && b == 74)
		{
			return 78;
		}
		else if(a == 4 && b == 75)
		{
			return 79;
		}
		else if(a == 4 && b == 76)
		{
			return 80;
		}
		else if(a == 4 && b == 77)
		{
			return 81;
		}
		else if(a == 4 && b == 78)
		{
			return 82;
		}
		else if(a == 4 && b == 79)
		{
			return 83;
		}
		else if(a == 4 && b == 80)
		{
			return 84;
		}
		else if(a == 4 && b == 81)
		{
			return 85;
		}
		else if(a == 4 && b == 82)
		{
			return 86;
		}
		else if(a == 4 && b == 83)
		{
			return 87;
		}
		else if(a == 4 && b == 84)
		{
			return 88;
		}
		else if(a == 4 && b == 85)
		{
			return 89;
		}
		else if(a == 4 && b == 86)
		{
			return 90;
		}
		else if(a == 4 && b == 87)
		{
			return 91;
		}
		else if(a == 4 && b == 88)
		{
			return 92;
		}
		else if(a == 4 && b == 89)
		{
			return 93;
		}
		else if(a == 4 && b == 90)
		{
			return 94;
		}
		else if(a == 4 && b == 91)
		{
			return 95;
		}
		else if(a == 4 && b == 92)
		{
			return 96;
		}
		else if(a == 4 && b == 93)
		{
			return 97;
		}
		else if(a == 4 && b == 94)
		{
			return 98;
		}
		else if(a == 4 && b == 95)
		{
			return 99;
		}
		else if(a == 4 && b == 96)
		{
			return 100;
		}
		else if(a == 4 && b == 97)
		{
			return 101;
		}
		else if(a == 4 && b == 98)
		{
			return 102;
		}
		else if(a == 4 && b == 99)
		{
			return 103;
		}
		else if(a == 4 && b == 100)
		{
			return 104;
		}
		else if(a == 5 && b == 0)
		{
			return 5;
		}
		else if(a == 5 && b == 1)
		{
			return 6;
		}
		else if(a == 5 && b == 2)
		{
			return 7;
		}
		else if(a == 5 && b == 3)
		{
			return 8;
		}
		else if(a == 5 && b == 4)
		{
			return 9;
		}
		else if(a == 5 && b == 5)
		{
			return 10;
		}
		else if(a == 5 && b == 6)
		{
			return 11;
		}
		else if(a == 5 && b == 7)
		{
			return 12;
		}
		else if(a == 5 && b == 8)
		{
			return 13;
		}
		else if(a == 5 && b == 9)
		{
			return 14;
		}
		else if(a == 5 && b == 10)
		{
			return 15;
		}
		else if(a == 5 && b == 11)
		{
			return 16;
		}
		else if(a == 5 && b == 12)
		{
			return 17;
		}
		else if(a == 5 && b == 13)
		{
			return 18;
		}
		else if(a == 5 && b == 14)
		{
			return 19;
		}
		else if(a == 5 && b == 15)
		{
			return 20;
		}
		else if(a == 5 && b == 16)
		{
			return 21;
		}
		else if(a == 5 && b == 17)
		{
			return 22;
		}
		else if(a == 5 && b == 18)
		{
			return 23;
		}
		else if(a == 5 && b == 19)
		{
			return 24;
		}
		else if(a == 5 && b == 20)
		{
			return 25;
		}
		else if(a == 5 && b == 21)
		{
			return 26;
		}
		else if(a == 5 && b == 22)
		{
			return 27;
		}
		else if(a == 5 && b == 23)
		{
			return 28;
		}
		else if(a == 5 && b == 24)
		{
			return 29;
		}
		else if(a == 5 && b == 25)
		{
			return 30;
		}
		else if(a == 5 && b == 26)
		{
			return 31;
		}
		else if(a == 5 && b == 27)
		{
			return 32;
		}
		else if(a == 5 && b == 28)
		{
			return 33;
		}
		else if(a == 5 && b == 29)
		{
			return 34;
		}
		else if(a == 5 && b == 30)
		{
			return 35;
		}
		else if(a == 5 && b == 31)
		{
			return 36;
		}
		else if(a == 5 && b == 32)
		{
			return 37;
		}
		else if(a == 5 && b == 33)
		{
			return 38;
		}
		else if(a == 5 && b == 34)
		{
			return 39;
		}
		else if(a == 5 && b == 35)
		{
			return 40;
		}
		else if(a == 5 && b == 36)
		{
			return 41;
		}
		else if(a == 5 && b == 37)
		{
			return 42;
		}
		else if(a == 5 && b == 38)
		{
			return 43;
		}
		else if(a == 5 && b == 39)
		{
			return 44;
		}
		else if(a == 5 && b == 40)
		{
			return 45;
		}
		else if(a == 5 && b == 41)
		{
			return 46;
		}
		else if(a == 5 && b == 42)
		{
			return 47;
		}
		else if(a == 5 && b == 43)
		{
			return 48;
		}
		else if(a == 5 && b == 44)
		{
			return 49;
		}
		else if(a == 5 && b == 45)
		{
			return 50;
		}
		else if(a == 5 && b == 46)
		{
			return 51;
		}
		else if(a == 5 && b == 47)
		{
			return 52;
		}
		else if(a == 5 && b == 48)
		{
			return 53;
		}
		else if(a == 5 && b == 49)
		{
			return 54;
		}
		else if(a == 5 && b == 50)
		{
			return 55;
		}
		else if(a == 5 && b == 51)
		{
			return 56;
		}
		else if(a == 5 && b == 52)
		{
			return 57;
		}
		else if(a == 5 && b == 53)
		{
			return 58;
		}
		else if(a == 5 && b == 54)
		{
			return 59;
		}
		else if(a == 5 && b == 55)
		{
			return 60;
		}
		else if(a == 5 && b == 56)
		{
			return 61;
		}
		else if(a == 5 && b == 57)
		{
			return 62;
		}
		else if(a == 5 && b == 58)
		{
			return 63;
		}
		else if(a == 5 && b == 59)
		{
			return 64;
		}
		else if(a == 5 && b == 60)
		{
			return 65;
		}
		else if(a == 5 && b == 61)
		{
			return 66;
		}
		else if(a == 5 && b == 62)
		{
			return 67;
		}
		else if(a == 5 && b == 63)
		{
			return 68;
		}
		else if(a == 5 && b == 64)
		{
			return 69;
		}
		else if(a == 5 && b == 65)
		{
			return 70;
		}
		else if(a == 5 && b == 66)
		{
			return 71;
		}
		else if(a == 5 && b == 67)
		{
			return 72;
		}
		else if(a == 5 && b == 68)
		{
			return 73;
		}
		else if(a == 5 && b == 69)
		{
			return 74;
		}
		else if(a == 5 && b == 70)
		{
			return 75;
		}
		else if(a == 5 && b == 71)
		{
			return 76;
		}
		else if(a == 5 && b == 72)
		{
			return 77;
		}
		else if(a == 5 && b == 73)
		{
			return 78;
		}
		else if(a == 5 && b == 74)
		{
			return 79;
		}
		else if(a == 5 && b == 75)
		{
			return 80;
		}
		else if(a == 5 && b == 76)
		{
			return 81;
		}
		else if(a == 5 && b == 77)
		{
			return 82;
		}
		else if(a == 5 && b == 78)
		{
			return 83;
		}
		else if(a == 5 && b == 79)
		{
			return 84;
		}
		else if(a == 5 && b == 80)
		{
			return 85;
		}
		else if(a == 5 && b == 81)
		{
			return 86;
		}
		else if(a == 5 && b == 82)
		{
			return 87;
		}
		else if(a == 5 && b == 83)
		{
			return 88;
		}
		else if(a == 5 && b == 84)
		{
			return 89;
		}
		else if(a == 5 && b == 85)
		{
			return 90;
		}
		else if(a == 5 && b == 86)
		{
			return 91;
		}
		else if(a == 5 && b == 87)
		{
			return 92;
		}
		else if(a == 5 && b == 88)
		{
			return 93;
		}
		else if(a == 5 && b == 89)
		{
			return 94;
		}
		else if(a == 5 && b == 90)
		{
			return 95;
		}
		else if(a == 5 && b == 91)
		{
			return 96;
		}
		else if(a == 5 && b == 92)
		{
			return 97;
		}
		else if(a == 5 && b == 93)
		{
			return 98;
		}
		else if(a == 5 && b == 94)
		{
			return 99;
		}
		else if(a == 5 && b == 95)
		{
			return 100;
		}
		else if(a == 5 && b == 96)
		{
			return 101;
		}
		else if(a == 5 && b == 97)
		{
			return 102;
		}
		else if(a == 5 && b == 98)
		{
			return 103;
		}
		else if(a == 5 && b == 99)
		{
			return 104;
		}
		else if(a == 5 && b == 100)
		{
			return 105;
		}
		else if(a == 6 && b == 0)
		{
			return 6;
		}
		else if(a == 6 && b == 1)
		{
			return 7;
		}
		else if(a == 6 && b == 2)
		{
			return 8;
		}
		else if(a == 6 && b == 3)
		{
			return 9;
		}
		else if(a == 6 && b == 4)
		{
			return 10;
		}
		else if(a == 6 && b == 5)
		{
			return 11;
		}
		else if(a == 6 && b == 6)
		{
			return 12;
		}
		else if(a == 6 && b == 7)
		{
			return 13;
		}
		else if(a == 6 && b == 8)
		{
			return 14;
		}
		else if(a == 6 && b == 9)
		{
			return 15;
		}
		else if(a == 6 && b == 10)
		{
			return 16;
		}
		else if(a == 6 && b == 11)
		{
			return 17;
		}
		else if(a == 6 && b == 12)
		{
			return 18;
		}
		else if(a == 6 && b == 13)
		{
			return 19;
		}
		else if(a == 6 && b == 14)
		{
			return 20;
		}
		else if(a == 6 && b == 15)
		{
			return 21;
		}
		else if(a == 6 && b == 16)
		{
			return 22;
		}
		else if(a == 6 && b == 17)
		{
			return 23;
		}
		else if(a == 6 && b == 18)
		{
			return 24;
		}
		else if(a == 6 && b == 19)
		{
			return 25;
		}
		else if(a == 6 && b == 20)
		{
			return 26;
		}
		else if(a == 6 && b == 21)
		{
			return 27;
		}
		else if(a == 6 && b == 22)
		{
			return 28;
		}
		else if(a == 6 && b == 23)
		{
			return 29;
		}
		else if(a == 6 && b == 24)
		{
			return 30;
		}
		else if(a == 6 && b == 25)
		{
			return 31;
		}
		else if(a == 6 && b == 26)
		{
			return 32;
		}
		else if(a == 6 && b == 27)
		{
			return 33;
		}
		else if(a == 6 && b == 28)
		{
			return 34;
		}
		else if(a == 6 && b == 29)
		{
			return 35;
		}
		else if(a == 6 && b == 30)
		{
			return 36;
		}
		else if(a == 6 && b == 31)
		{
			return 37;
		}
		else if(a == 6 && b == 32)
		{
			return 38;
		}
		else if(a == 6 && b == 33)
		{
			return 39;
		}
		else if(a == 6 && b == 34)
		{
			return 40;
		}
		else if(a == 6 && b == 35)
		{
			return 41;
		}
		else if(a == 6 && b == 36)
		{
			return 42;
		}
		else if(a == 6 && b == 37)
		{
			return 43;
		}
		else if(a == 6 && b == 38)
		{
			return 44;
		}
		else if(a == 6 && b == 39)
		{
			return 45;
		}
		else if(a == 6 && b == 40)
		{
			return 46;
		}
		else if(a == 6 && b == 41)
		{
			return 47;
		}
		else if(a == 6 && b == 42)
		{
			return 48;
		}
		else if(a == 6 && b == 43)
		{
			return 49;
		}
		else if(a == 6 && b == 44)
		{
			return 50;
		}
		else if(a == 6 && b == 45)
		{
			return 51;
		}
		else if(a == 6 && b == 46)
		{
			return 52;
		}
		else if(a == 6 && b == 47)
		{
			return 53;
		}
		else if(a == 6 && b == 48)
		{
			return 54;
		}
		else if(a == 6 && b == 49)
		{
			return 55;
		}
		else if(a == 6 && b == 50)
		{
			return 56;
		}
		else if(a == 6 && b == 51)
		{
			return 57;
		}
		else if(a == 6 && b == 52)
		{
			return 58;
		}
		else if(a == 6 && b == 53)
		{
			return 59;
		}
		else if(a == 6 && b == 54)
		{
			return 60;
		}
		else if(a == 6 && b == 55)
		{
			return 61;
		}
		else if(a == 6 && b == 56)
		{
			return 62;
		}
		else if(a == 6 && b == 57)
		{
			return 63;
		}
		else if(a == 6 && b == 58)
		{
			return 64;
		}
		else if(a == 6 && b == 59)
		{
			return 65;
		}
		else if(a == 6 && b == 60)
		{
			return 66;
		}
		else if(a == 6 && b == 61)
		{
			return 67;
		}
		else if(a == 6 && b == 62)
		{
			return 68;
		}
		else if(a == 6 && b == 63)
		{
			return 69;
		}
		else if(a == 6 && b == 64)
		{
			return 70;
		}
		else if(a == 6 && b == 65)
		{
			return 71;
		}
		else if(a == 6 && b == 66)
		{
			return 72;
		}
		else if(a == 6 && b == 67)
		{
			return 73;
		}
		else if(a == 6 && b == 68)
		{
			return 74;
		}
		else if(a == 6 && b == 69)
		{
			return 75;
		}
		else if(a == 6 && b == 70)
		{
			return 76;
		}
		else if(a == 6 && b == 71)
		{
			return 77;
		}
		else if(a == 6 && b == 72)
		{
			return 78;
		}
		else if(a == 6 && b == 73)
		{
			return 79;
		}
		else if(a == 6 && b == 74)
		{
			return 80;
		}
		else if(a == 6 && b == 75)
		{
			return 81;
		}
		else if(a == 6 && b == 76)
		{
			return 82;
		}
		else if(a == 6 && b == 77)
		{
			return 83;
		}
		else if(a == 6 && b == 78)
		{
			return 84;
		}
		else if(a == 6 && b == 79)
		{
			return 85;
		}
		else if(a == 6 && b == 80)
		{
			return 86;
		}
		else if(a == 6 && b == 81)
		{
			return 87;
		}
		else if(a == 6 && b == 82)
		{
			return 88;
		}
		else if(a == 6 && b == 83)
		{
			return 89;
		}
		else if(a == 6 && b == 84)
		{
			return 90;
		}
		else if(a == 6 && b == 85)
		{
			return 91;
		}
		else if(a == 6 && b == 86)
		{
			return 92;
		}
		else if(a == 6 && b == 87)
		{
			return 93;
		}
		else if(a == 6 && b == 88)
		{
			return 94;
		}
		else if(a == 6 && b == 89)
		{
			return 95;
		}
		else if(a == 6 && b == 90)
		{
			return 96;
		}
		else if(a == 6 && b == 91)
		{
			return 97;
		}
		else if(a == 6 && b == 92)
		{
			return 98;
		}
		else if(a == 6 && b == 93)
		{
			return 99;
		}
		else if(a == 6 && b == 94)
		{
			return 100;
		}
		else if(a == 6 && b == 95)
		{
			return 101;
		}
		else if(a == 6 && b == 96)
		{
			return 102;
		}
		else if(a == 6 && b == 97)
		{
			return 103;
		}
		else if(a == 6 && b == 98)
		{
			return 104;
		}
		else if(a == 6 && b == 99)
		{
			return 105;
		}
		else if(a == 6 && b == 100)
		{
			return 106;
		}
		else if(a == 7 && b == 0)
		{
			return 7;
		}
		else if(a == 7 && b == 1)
		{
			return 8;
		}
		else if(a == 7 && b == 2)
		{
			return 9;
		}
		else if(a == 7 && b == 3)
		{
			return 10;
		}
		else if(a == 7 && b == 4)
		{
			return 11;
		}
		else if(a == 7 && b == 5)
		{
			return 12;
		}
		else if(a == 7 && b == 6)
		{
			return 13;
		}
		else if(a == 7 && b == 7)
		{
			return 14;
		}
		else if(a == 7 && b == 8)
		{
			return 15;
		}
		else if(a == 7 && b == 9)
		{
			return 16;
		}
		else if(a == 7 && b == 10)
		{
			return 17;
		}
		else if(a == 7 && b == 11)
		{
			return 18;
		}
		else if(a == 7 && b == 12)
		{
			return 19;
		}
		else if(a == 7 && b == 13)
		{
			return 20;
		}
		else if(a == 7 && b == 14)
		{
			return 21;
		}
		else if(a == 7 && b == 15)
		{
			return 22;
		}
		else if(a == 7 && b == 16)
		{
			return 23;
		}
		else if(a == 7 && b == 17)
		{
			return 24;
		}
		else if(a == 7 && b == 18)
		{
			return 25;
		}
		else if(a == 7 && b == 19)
		{
			return 26;
		}
		else if(a == 7 && b == 20)
		{
			return 27;
		}
		else if(a == 7 && b == 21)
		{
			return 28;
		}
		else if(a == 7 && b == 22)
		{
			return 29;
		}
		else if(a == 7 && b == 23)
		{
			return 30;
		}
		else if(a == 7 && b == 24)
		{
			return 31;
		}
		else if(a == 7 && b == 25)
		{
			return 32;
		}
		else if(a == 7 && b == 26)
		{
			return 33;
		}
		else if(a == 7 && b == 27)
		{
			return 34;
		}
		else if(a == 7 && b == 28)
		{
			return 35;
		}
		else if(a == 7 && b == 29)
		{
			return 36;
		}
		else if(a == 7 && b == 30)
		{
			return 37;
		}
		else if(a == 7 && b == 31)
		{
			return 38;
		}
		else if(a == 7 && b == 32)
		{
			return 39;
		}
		else if(a == 7 && b == 33)
		{
			return 40;
		}
		else if(a == 7 && b == 34)
		{
			return 41;
		}
		else if(a == 7 && b == 35)
		{
			return 42;
		}
		else if(a == 7 && b == 36)
		{
			return 43;
		}
		else if(a == 7 && b == 37)
		{
			return 44;
		}
		else if(a == 7 && b == 38)
		{
			return 45;
		}
		else if(a == 7 && b == 39)
		{
			return 46;
		}
		else if(a == 7 && b == 40)
		{
			return 47;
		}
		else if(a == 7 && b == 41)
		{
			return 48;
		}
		else if(a == 7 && b == 42)
		{
			return 49;
		}
		else if(a == 7 && b == 43)
		{
			return 50;
		}
		else if(a == 7 && b == 44)
		{
			return 51;
		}
		else if(a == 7 && b == 45)
		{
			return 52;
		}
		else if(a == 7 && b == 46)
		{
			return 53;
		}
		else if(a == 7 && b == 47)
		{
			return 54;
		}
		else if(a == 7 && b == 48)
		{
			return 55;
		}
		else if(a == 7 && b == 49)
		{
			return 56;
		}
		else if(a == 7 && b == 50)
		{
			return 57;
		}
		else if(a == 7 && b == 51)
		{
			return 58;
		}
		else if(a == 7 && b == 52)
		{
			return 59;
		}
		else if(a == 7 && b == 53)
		{
			return 60;
		}
		else if(a == 7 && b == 54)
		{
			return 61;
		}
		else if(a == 7 && b == 55)
		{
			return 62;
		}
		else if(a == 7 && b == 56)
		{
			return 63;
		}
		else if(a == 7 && b == 57)
		{
			return 64;
		}
		else if(a == 7 && b == 58)
		{
			return 65;
		}
		else if(a == 7 && b == 59)
		{
			return 66;
		}
		else if(a == 7 && b == 60)
		{
			return 67;
		}
		else if(a == 7 && b == 61)
		{
			return 68;
		}
		else if(a == 7 && b == 62)
		{
			return 69;
		}
		else if(a == 7 && b == 63)
		{
			return 70;
		}
		else if(a == 7 && b == 64)
		{
			return 71;
		}
		else if(a == 7 && b == 65)
		{
			return 72;
		}
		else if(a == 7 && b == 66)
		{
			return 73;
		}
		else if(a == 7 && b == 67)
		{
			return 74;
		}
		else if(a == 7 && b == 68)
		{
			return 75;
		}
		else if(a == 7 && b == 69)
		{
			return 76;
		}
		else if(a == 7 && b == 70)
		{
			return 77;
		}
		else if(a == 7 && b == 71)
		{
			return 78;
		}
		else if(a == 7 && b == 72)
		{
			return 79;
		}
		else if(a == 7 && b == 73)
		{
			return 80;
		}
		else if(a == 7 && b == 74)
		{
			return 81;
		}
		else if(a == 7 && b == 75)
		{
			return 82;
		}
		else if(a == 7 && b == 76)
		{
			return 83;
		}
		else if(a == 7 && b == 77)
		{
			return 84;
		}
		else if(a == 7 && b == 78)
		{
			return 85;
		}
		else if(a == 7 && b == 79)
		{
			return 86;
		}
		else if(a == 7 && b == 80)
		{
			return 87;
		}
		else if(a == 7 && b == 81)
		{
			return 88;
		}
		else if(a == 7 && b == 82)
		{
			return 89;
		}
		else if(a == 7 && b == 83)
		{
			return 90;
		}
		else if(a == 7 && b == 84)
		{
			return 91;
		}
		else if(a == 7 && b == 85)
		{
			return 92;
		}
		else if(a == 7 && b == 86)
		{
			return 93;
		}
		else if(a == 7 && b == 87)
		{
			return 94;
		}
		else if(a == 7 && b == 88)
		{
			return 95;
		}
		else if(a == 7 && b == 89)
		{
			return 96;
		}
		else if(a == 7 && b == 90)
		{
			return 97;
		}
		else if(a == 7 && b == 91)
		{
			return 98;
		}
		else if(a == 7 && b == 92)
		{
			return 99;
		}
		else if(a == 7 && b == 93)
		{
			return 100;
		}
		else if(a == 7 && b == 94)
		{
			return 101;
		}
		else if(a == 7 && b == 95)
		{
			return 102;
		}
		else if(a == 7 && b == 96)
		{
			return 103;
		}
		else if(a == 7 && b == 97)
		{
			return 104;
		}
		else if(a == 7 && b == 98)
		{
			return 105;
		}
		else if(a == 7 && b == 99)
		{
			return 106;
		}
		else if(a == 7 && b == 100)
		{
			return 107;
		}
		else if(a == 8 && b == 0)
		{
			return 8;
		}
		else if(a == 8 && b == 1)
		{
			return 9;
		}
		else if(a == 8 && b == 2)
		{
			return 10;
		}
		else if(a == 8 && b == 3)
		{
			return 11;
		}
		else if(a == 8 && b == 4)
		{
			return 12;
		}
		else if(a == 8 && b == 5)
		{
			return 13;
		}
		else if(a == 8 && b == 6)
		{
			return 14;
		}
		else if(a == 8 && b == 7)
		{
			return 15;
		}
		else if(a == 8 && b == 8)
		{
			return 16;
		}
		else if(a == 8 && b == 9)
		{
			return 17;
		}
		else if(a == 8 && b == 10)
		{
			return 18;
		}
		else if(a == 8 && b == 11)
		{
			return 19;
		}
		else if(a == 8 && b == 12)
		{
			return 20;
		}
		else if(a == 8 && b == 13)
		{
			return 21;
		}
		else if(a == 8 && b == 14)
		{
			return 22;
		}
		else if(a == 8 && b == 15)
		{
			return 23;
		}
		else if(a == 8 && b == 16)
		{
			return 24;
		}
		else if(a == 8 && b == 17)
		{
			return 25;
		}
		else if(a == 8 && b == 18)
		{
			return 26;
		}
		else if(a == 8 && b == 19)
		{
			return 27;
		}
		else if(a == 8 && b == 20)
		{
			return 28;
		}
		else if(a == 8 && b == 21)
		{
			return 29;
		}
		else if(a == 8 && b == 22)
		{
			return 30;
		}
		else if(a == 8 && b == 23)
		{
			return 31;
		}
		else if(a == 8 && b == 24)
		{
			return 32;
		}
		else if(a == 8 && b == 25)
		{
			return 33;
		}
		else if(a == 8 && b == 26)
		{
			return 34;
		}
		else if(a == 8 && b == 27)
		{
			return 35;
		}
		else if(a == 8 && b == 28)
		{
			return 36;
		}
		else if(a == 8 && b == 29)
		{
			return 37;
		}
		else if(a == 8 && b == 30)
		{
			return 38;
		}
		else if(a == 8 && b == 31)
		{
			return 39;
		}
		else if(a == 8 && b == 32)
		{
			return 40;
		}
		else if(a == 8 && b == 33)
		{
			return 41;
		}
		else if(a == 8 && b == 34)
		{
			return 42;
		}
		else if(a == 8 && b == 35)
		{
			return 43;
		}
		else if(a == 8 && b == 36)
		{
			return 44;
		}
		else if(a == 8 && b == 37)
		{
			return 45;
		}
		else if(a == 8 && b == 38)
		{
			return 46;
		}
		else if(a == 8 && b == 39)
		{
			return 47;
		}
		else if(a == 8 && b == 40)
		{
			return 48;
		}
		else if(a == 8 && b == 41)
		{
			return 49;
		}
		else if(a == 8 && b == 42)
		{
			return 50;
		}
		else if(a == 8 && b == 43)
		{
			return 51;
		}
		else if(a == 8 && b == 44)
		{
			return 52;
		}
		else if(a == 8 && b == 45)
		{
			return 53;
		}
		else if(a == 8 && b == 46)
		{
			return 54;
		}
		else if(a == 8 && b == 47)
		{
			return 55;
		}
		else if(a == 8 && b == 48)
		{
			return 56;
		}
		else if(a == 8 && b == 49)
		{
			return 57;
		}
		else if(a == 8 && b == 50)
		{
			return 58;
		}
		else if(a == 8 && b == 51)
		{
			return 59;
		}
		else if(a == 8 && b == 52)
		{
			return 60;
		}
		else if(a == 8 && b == 53)
		{
			return 61;
		}
		else if(a == 8 && b == 54)
		{
			return 62;
		}
		else if(a == 8 && b == 55)
		{
			return 63;
		}
		else if(a == 8 && b == 56)
		{
			return 64;
		}
		else if(a == 8 && b == 57)
		{
			return 65;
		}
		else if(a == 8 && b == 58)
		{
			return 66;
		}
		else if(a == 8 && b == 59)
		{
			return 67;
		}
		else if(a == 8 && b == 60)
		{
			return 68;
		}
		else if(a == 8 && b == 61)
		{
			return 69;
		}
		else if(a == 8 && b == 62)
		{
			return 70;
		}
		else if(a == 8 && b == 63)
		{
			return 71;
		}
		else if(a == 8 && b == 64)
		{
			return 72;
		}
		else if(a == 8 && b == 65)
		{
			return 73;
		}
		else if(a == 8 && b == 66)
		{
			return 74;
		}
		else if(a == 8 && b == 67)
		{
			return 75;
		}
		else if(a == 8 && b == 68)
		{
			return 76;
		}
		else if(a == 8 && b == 69)
		{
			return 77;
		}
		else if(a == 8 && b == 70)
		{
			return 78;
		}
		else if(a == 8 && b == 71)
		{
			return 79;
		}
		else if(a == 8 && b == 72)
		{
			return 80;
		}
		else if(a == 8 && b == 73)
		{
			return 81;
		}
		else if(a == 8 && b == 74)
		{
			return 82;
		}
		else if(a == 8 && b == 75)
		{
			return 83;
		}
		else if(a == 8 && b == 76)
		{
			return 84;
		}
		else if(a == 8 && b == 77)
		{
			return 85;
		}
		else if(a == 8 && b == 78)
		{
			return 86;
		}
		else if(a == 8 && b == 79)
		{
			return 87;
		}
		else if(a == 8 && b == 80)
		{
			return 88;
		}
		else if(a == 8 && b == 81)
		{
			return 89;
		}
		else if(a == 8 && b == 82)
		{
			return 90;
		}
		else if(a == 8 && b == 83)
		{
			return 91;
		}
		else if(a == 8 && b == 84)
		{
			return 92;
		}
		else if(a == 8 && b == 85)
		{
			return 93;
		}
		else if(a == 8 && b == 86)
		{
			return 94;
		}
		else if(a == 8 && b == 87)
		{
			return 95;
		}
		else if(a == 8 && b == 88)
		{
			return 96;
		}
		else if(a == 8 && b == 89)
		{
			return 97;
		}
		else if(a == 8 && b == 90)
		{
			return 98;
		}
		else if(a == 8 && b == 91)
		{
			return 99;
		}
		else if(a == 8 && b == 92)
		{
			return 100;
		}
		else if(a == 8 && b == 93)
		{
			return 101;
		}
		else if(a == 8 && b == 94)
		{
			return 102;
		}
		else if(a == 8 && b == 95)
		{
			return 103;
		}
		else if(a == 8 && b == 96)
		{
			return 104;
		}
		else if(a == 8 && b == 97)
		{
			return 105;
		}
		else if(a == 8 && b == 98)
		{
			return 106;
		}
		else if(a == 8 && b == 99)
		{
			return 107;
		}
		else if(a == 8 && b == 100)
		{
			return 108;
		}
		else if(a == 9 && b == 0)
		{
			return 9;
		}
		else if(a == 9 && b == 1)
		{
			return 10;
		}
		else if(a == 9 && b == 2)
		{
			return 11;
		}
		else if(a == 9 && b == 3)
		{
			return 12;
		}
		else if(a == 9 && b == 4)
		{
			return 13;
		}
		else if(a == 9 && b == 5)
		{
			return 14;
		}
		else if(a == 9 && b == 6)
		{
			return 15;
		}
		else if(a == 9 && b == 7)
		{
			return 16;
		}
		else if(a == 9 && b == 8)
		{
			return 17;
		}
		else if(a == 9 && b == 9)
		{
			return 18;
		}
		else if(a == 9 && b == 10)
		{
			return 19;
		}
		else if(a == 9 && b == 11)
		{
			return 20;
		}
		else if(a == 9 && b == 12)
		{
			return 21;
		}
		else if(a == 9 && b == 13)
		{
			return 22;
		}
		else if(a == 9 && b == 14)
		{
			return 23;
		}
		else if(a == 9 && b == 15)
		{
			return 24;
		}
		else if(a == 9 && b == 16)
		{
			return 25;
		}
		else if(a == 9 && b == 17)
		{
			return 26;
		}
		else if(a == 9 && b == 18)
		{
			return 27;
		}
		else if(a == 9 && b == 19)
		{
			return 28;
		}
		else if(a == 9 && b == 20)
		{
			return 29;
		}
		else if(a == 9 && b == 21)
		{
			return 30;
		}
		else if(a == 9 && b == 22)
		{
			return 31;
		}
		else if(a == 9 && b == 23)
		{
			return 32;
		}
		else if(a == 9 && b == 24)
		{
			return 33;
		}
		else if(a == 9 && b == 25)
		{
			return 34;
		}
		else if(a == 9 && b == 26)
		{
			return 35;
		}
		else if(a == 9 && b == 27)
		{
			return 36;
		}
		else if(a == 9 && b == 28)
		{
			return 37;
		}
		else if(a == 9 && b == 29)
		{
			return 38;
		}
		else if(a == 9 && b == 30)
		{
			return 39;
		}
		else if(a == 9 && b == 31)
		{
			return 40;
		}
		else if(a == 9 && b == 32)
		{
			return 41;
		}
		else if(a == 9 && b == 33)
		{
			return 42;
		}
		else if(a == 9 && b == 34)
		{
			return 43;
		}
		else if(a == 9 && b == 35)
		{
			return 44;
		}
		else if(a == 9 && b == 36)
		{
			return 45;
		}
		else if(a == 9 && b == 37)
		{
			return 46;
		}
		else if(a == 9 && b == 38)
		{
			return 47;
		}
		else if(a == 9 && b == 39)
		{
			return 48;
		}
		else if(a == 9 && b == 40)
		{
			return 49;
		}
		else if(a == 9 && b == 41)
		{
			return 50;
		}
		else if(a == 9 && b == 42)
		{
			return 51;
		}
		else if(a == 9 && b == 43)
		{
			return 52;
		}
		else if(a == 9 && b == 44)
		{
			return 53;
		}
		else if(a == 9 && b == 45)
		{
			return 54;
		}
		else if(a == 9 && b == 46)
		{
			return 55;
		}
		else if(a == 9 && b == 47)
		{
			return 56;
		}
		else if(a == 9 && b == 48)
		{
			return 57;
		}
		else if(a == 9 && b == 49)
		{
			return 58;
		}
		else if(a == 9 && b == 50)
		{
			return 59;
		}
		else if(a == 9 && b == 51)
		{
			return 60;
		}
		else if(a == 9 && b == 52)
		{
			return 61;
		}
		else if(a == 9 && b == 53)
		{
			return 62;
		}
		else if(a == 9 && b == 54)
		{
			return 63;
		}
		else if(a == 9 && b == 55)
		{
			return 64;
		}
		else if(a == 9 && b == 56)
		{
			return 65;
		}
		else if(a == 9 && b == 57)
		{
			return 66;
		}
		else if(a == 9 && b == 58)
		{
			return 67;
		}
		else if(a == 9 && b == 59)
		{
			return 68;
		}
		else if(a == 9 && b == 60)
		{
			return 69;
		}
		else if(a == 9 && b == 61)
		{
			return 70;
		}
		else if(a == 9 && b == 62)
		{
			return 71;
		}
		else if(a == 9 && b == 63)
		{
			return 72;
		}
		else if(a == 9 && b == 64)
		{
			return 73;
		}
		else if(a == 9 && b == 65)
		{
			return 74;
		}
		else if(a == 9 && b == 66)
		{
			return 75;
		}
		else if(a == 9 && b == 67)
		{
			return 76;
		}
		else if(a == 9 && b == 68)
		{
			return 77;
		}
		else if(a == 9 && b == 69)
		{
			return 78;
		}
		else if(a == 9 && b == 70)
		{
			return 79;
		}
		else if(a == 9 && b == 71)
		{
			return 80;
		}
		else if(a == 9 && b == 72)
		{
			return 81;
		}
		else if(a == 9 && b == 73)
		{
			return 82;
		}
		else if(a == 9 && b == 74)
		{
			return 83;
		}
		else if(a == 9 && b == 75)
		{
			return 84;
		}
		else if(a == 9 && b == 76)
		{
			return 85;
		}
		else if(a == 9 && b == 77)
		{
			return 86;
		}
		else if(a == 9 && b == 78)
		{
			return 87;
		}
		else if(a == 9 && b == 79)
		{
			return 88;
		}
		else if(a == 9 && b == 80)
		{
			return 89;
		}
		else if(a == 9 && b == 81)
		{
			return 90;
		}
		else if(a == 9 && b == 82)
		{
			return 91;
		}
		else if(a == 9 && b == 83)
		{
			return 92;
		}
		else if(a == 9 && b == 84)
		{
			return 93;
		}
		else if(a == 9 && b == 85)
		{
			return 94;
		}
		else if(a == 9 && b == 86)
		{
			return 95;
		}
		else if(a == 9 && b == 87)
		{
			return 96;
		}
		else if(a == 9 && b == 88)
		{
			return 97;
		}
		else if(a == 9 && b == 89)
		{
			return 98;
		}
		else if(a == 9 && b == 90)
		{
			return 99;
		}
		else if(a == 9 && b == 91)
		{
			return 100;
		}
		else if(a == 9 && b == 92)
		{
			return 101;
		}
		else if(a == 9 && b == 93)
		{
			return 102;
		}
		else if(a == 9 && b == 94)
		{
			return 103;
		}
		else if(a == 9 && b == 95)
		{
			return 104;
		}
		else if(a == 9 && b == 96)
		{
			return 105;
		}
		else if(a == 9 && b == 97)
		{
			return 106;
		}
		else if(a == 9 && b == 98)
		{
			return 107;
		}
		else if(a == 9 && b == 99)
		{
			return 108;
		}
		else if(a == 9 && b == 100)
		{
			return 109;
		}
		else if(a == 10 && b == 0)
		{
			return 10;
		}
		else if(a == 10 && b == 1)
		{
			return 11;
		}
		else if(a == 10 && b == 2)
		{
			return 12;
		}
		else if(a == 10 && b == 3)
		{
			return 13;
		}
		else if(a == 10 && b == 4)
		{
			return 14;
		}
		else if(a == 10 && b == 5)
		{
			return 15;
		}
		else if(a == 10 && b == 6)
		{
			return 16;
		}
		else if(a == 10 && b == 7)
		{
			return 17;
		}
		else if(a == 10 && b == 8)
		{
			return 18;
		}
		else if(a == 10 && b == 9)
		{
			return 19;
		}
		else if(a == 10 && b == 10)
		{
			return 20;
		}
		else if(a == 10 && b == 11)
		{
			return 21;
		}
		else if(a == 10 && b == 12)
		{
			return 22;
		}
		else if(a == 10 && b == 13)
		{
			return 23;
		}
		else if(a == 10 && b == 14)
		{
			return 24;
		}
		else if(a == 10 && b == 15)
		{
			return 25;
		}
		else if(a == 10 && b == 16)
		{
			return 26;
		}
		else if(a == 10 && b == 17)
		{
			return 27;
		}
		else if(a == 10 && b == 18)
		{
			return 28;
		}
		else if(a == 10 && b == 19)
		{
			return 29;
		}
		else if(a == 10 && b == 20)
		{
			return 30;
		}
		else if(a == 10 && b == 21)
		{
			return 31;
		}
		else if(a == 10 && b == 22)
		{
			return 32;
		}
		else if(a == 10 && b == 23)
		{
			return 33;
		}
		else if(a == 10 && b == 24)
		{
			return 34;
		}
		else if(a == 10 && b == 25)
		{
			return 35;
		}
		else if(a == 10 && b == 26)
		{
			return 36;
		}
		else if(a == 10 && b == 27)
		{
			return 37;
		}
		else if(a == 10 && b == 28)
		{
			return 38;
		}
		else if(a == 10 && b == 29)
		{
			return 39;
		}
		else if(a == 10 && b == 30)
		{
			return 40;
		}
		else if(a == 10 && b == 31)
		{
			return 41;
		}
		else if(a == 10 && b == 32)
		{
			return 42;
		}
		else if(a == 10 && b == 33)
		{
			return 43;
		}
		else if(a == 10 && b == 34)
		{
			return 44;
		}
		else if(a == 10 && b == 35)
		{
			return 45;
		}
		else if(a == 10 && b == 36)
		{
			return 46;
		}
		else if(a == 10 && b == 37)
		{
			return 47;
		}
		else if(a == 10 && b == 38)
		{
			return 48;
		}
		else if(a == 10 && b == 39)
		{
			return 49;
		}
		else if(a == 10 && b == 40)
		{
			return 50;
		}
		else if(a == 10 && b == 41)
		{
			return 51;
		}
		else if(a == 10 && b == 42)
		{
			return 52;
		}
		else if(a == 10 && b == 43)
		{
			return 53;
		}
		else if(a == 10 && b == 44)
		{
			return 54;
		}
		else if(a == 10 && b == 45)
		{
			return 55;
		}
		else if(a == 10 && b == 46)
		{
			return 56;
		}
		else if(a == 10 && b == 47)
		{
			return 57;
		}
		else if(a == 10 && b == 48)
		{
			return 58;
		}
		else if(a == 10 && b == 49)
		{
			return 59;
		}
		else if(a == 10 && b == 50)
		{
			return 60;
		}
		else if(a == 10 && b == 51)
		{
			return 61;
		}
		else if(a == 10 && b == 52)
		{
			return 62;
		}
		else if(a == 10 && b == 53)
		{
			return 63;
		}
		else if(a == 10 && b == 54)
		{
			return 64;
		}
		else if(a == 10 && b == 55)
		{
			return 65;
		}
		else if(a == 10 && b == 56)
		{
			return 66;
		}
		else if(a == 10 && b == 57)
		{
			return 67;
		}
		else if(a == 10 && b == 58)
		{
			return 68;
		}
		else if(a == 10 && b == 59)
		{
			return 69;
		}
		else if(a == 10 && b == 60)
		{
			return 70;
		}
		else if(a == 10 && b == 61)
		{
			return 71;
		}
		else if(a == 10 && b == 62)
		{
			return 72;
		}
		else if(a == 10 && b == 63)
		{
			return 73;
		}
		else if(a == 10 && b == 64)
		{
			return 74;
		}
		else if(a == 10 && b == 65)
		{
			return 75;
		}
		else if(a == 10 && b == 66)
		{
			return 76;
		}
		else if(a == 10 && b == 67)
		{
			return 77;
		}
		else if(a == 10 && b == 68)
		{
			return 78;
		}
		else if(a == 10 && b == 69)
		{
			return 79;
		}
		else if(a == 10 && b == 70)
		{
			return 80;
		}
		else if(a == 10 && b == 71)
		{
			return 81;
		}
		else if(a == 10 && b == 72)
		{
			return 82;
		}
		else if(a == 10 && b == 73)
		{
			return 83;
		}
		else if(a == 10 && b == 74)
		{
			return 84;
		}
		else if(a == 10 && b == 75)
		{
			return 85;
		}
		else if(a == 10 && b == 76)
		{
			return 86;
		}
		else if(a == 10 && b == 77)
		{
			return 87;
		}
		else if(a == 10 && b == 78)
		{
			return 88;
		}
		else if(a == 10 && b == 79)
		{
			return 89;
		}
		else if(a == 10 && b == 80)
		{
			return 90;
		}
		else if(a == 10 && b == 81)
		{
			return 91;
		}
		else if(a == 10 && b == 82)
		{
			return 92;
		}
		else if(a == 10 && b == 83)
		{
			return 93;
		}
		else if(a == 10 && b == 84)
		{
			return 94;
		}
		else if(a == 10 && b == 85)
		{
			return 95;
		}
		else if(a == 10 && b == 86)
		{
			return 96;
		}
		else if(a == 10 && b == 87)
		{
			return 97;
		}
		else if(a == 10 && b == 88)
		{
			return 98;
		}
		else if(a == 10 && b == 89)
		{
			return 99;
		}
		else if(a == 10 && b == 90)
		{
			return 100;
		}
		else if(a == 10 && b == 91)
		{
			return 101;
		}
		else if(a == 10 && b == 92)
		{
			return 102;
		}
		else if(a == 10 && b == 93)
		{
			return 103;
		}
		else if(a == 10 && b == 94)
		{
			return 104;
		}
		else if(a == 10 && b == 95)
		{
			return 105;
		}
		else if(a == 10 && b == 96)
		{
			return 106;
		}
		else if(a == 10 && b == 97)
		{
			return 107;
		}
		else if(a == 10 && b == 98)
		{
			return 108;
		}
		else if(a == 10 && b == 99)
		{
			return 109;
		}
		else if(a == 10 && b == 100)
		{
			return 110;
		}
		else if(a == 11 && b == 0)
		{
			return 11;
		}
		else if(a == 11 && b == 1)
		{
			return 12;
		}
		else if(a == 11 && b == 2)
		{
			return 13;
		}
		else if(a == 11 && b == 3)
		{
			return 14;
		}
		else if(a == 11 && b == 4)
		{
			return 15;
		}
		else if(a == 11 && b == 5)
		{
			return 16;
		}
		else if(a == 11 && b == 6)
		{
			return 17;
		}
		else if(a == 11 && b == 7)
		{
			return 18;
		}
		else if(a == 11 && b == 8)
		{
			return 19;
		}
		else if(a == 11 && b == 9)
		{
			return 20;
		}
		else if(a == 11 && b == 10)
		{
			return 21;
		}
		else if(a == 11 && b == 11)
		{
			return 22;
		}
		else if(a == 11 && b == 12)
		{
			return 23;
		}
		else if(a == 11 && b == 13)
		{
			return 24;
		}
		else if(a == 11 && b == 14)
		{
			return 25;
		}
		else if(a == 11 && b == 15)
		{
			return 26;
		}
		else if(a == 11 && b == 16)
		{
			return 27;
		}
		else if(a == 11 && b == 17)
		{
			return 28;
		}
		else if(a == 11 && b == 18)
		{
			return 29;
		}
		else if(a == 11 && b == 19)
		{
			return 30;
		}
		else if(a == 11 && b == 20)
		{
			return 31;
		}
		else if(a == 11 && b == 21)
		{
			return 32;
		}
		else if(a == 11 && b == 22)
		{
			return 33;
		}
		else if(a == 11 && b == 23)
		{
			return 34;
		}
		else if(a == 11 && b == 24)
		{
			return 35;
		}
		else if(a == 11 && b == 25)
		{
			return 36;
		}
		else if(a == 11 && b == 26)
		{
			return 37;
		}
		else if(a == 11 && b == 27)
		{
			return 38;
		}
		else if(a == 11 && b == 28)
		{
			return 39;
		}
		else if(a == 11 && b == 29)
		{
			return 40;
		}
		else if(a == 11 && b == 30)
		{
			return 41;
		}
		else if(a == 11 && b == 31)
		{
			return 42;
		}
		else if(a == 11 && b == 32)
		{
			return 43;
		}
		else if(a == 11 && b == 33)
		{
			return 44;
		}
		else if(a == 11 && b == 34)
		{
			return 45;
		}
		else if(a == 11 && b == 35)
		{
			return 46;
		}
		else if(a == 11 && b == 36)
		{
			return 47;
		}
		else if(a == 11 && b == 37)
		{
			return 48;
		}
		else if(a == 11 && b == 38)
		{
			return 49;
		}
		else if(a == 11 && b == 39)
		{
			return 50;
		}
		else if(a == 11 && b == 40)
		{
			return 51;
		}
		else if(a == 11 && b == 41)
		{
			return 52;
		}
		else if(a == 11 && b == 42)
		{
			return 53;
		}
		else if(a == 11 && b == 43)
		{
			return 54;
		}
		else if(a == 11 && b == 44)
		{
			return 55;
		}
		else if(a == 11 && b == 45)
		{
			return 56;
		}
		else if(a == 11 && b == 46)
		{
			return 57;
		}
		else if(a == 11 && b == 47)
		{
			return 58;
		}
		else if(a == 11 && b == 48)
		{
			return 59;
		}
		else if(a == 11 && b == 49)
		{
			return 60;
		}
		else if(a == 11 && b == 50)
		{
			return 61;
		}
		else if(a == 11 && b == 51)
		{
			return 62;
		}
		else if(a == 11 && b == 52)
		{
			return 63;
		}
		else if(a == 11 && b == 53)
		{
			return 64;
		}
		else if(a == 11 && b == 54)
		{
			return 65;
		}
		else if(a == 11 && b == 55)
		{
			return 66;
		}
		else if(a == 11 && b == 56)
		{
			return 67;
		}
		else if(a == 11 && b == 57)
		{
			return 68;
		}
		else if(a == 11 && b == 58)
		{
			return 69;
		}
		else if(a == 11 && b == 59)
		{
			return 70;
		}
		else if(a == 11 && b == 60)
		{
			return 71;
		}
		else if(a == 11 && b == 61)
		{
			return 72;
		}
		else if(a == 11 && b == 62)
		{
			return 73;
		}
		else if(a == 11 && b == 63)
		{
			return 74;
		}
		else if(a == 11 && b == 64)
		{
			return 75;
		}
		else if(a == 11 && b == 65)
		{
			return 76;
		}
		else if(a == 11 && b == 66)
		{
			return 77;
		}
		else if(a == 11 && b == 67)
		{
			return 78;
		}
		else if(a == 11 && b == 68)
		{
			return 79;
		}
		else if(a == 11 && b == 69)
		{
			return 80;
		}
		else if(a == 11 && b == 70)
		{
			return 81;
		}
		else if(a == 11 && b == 71)
		{
			return 82;
		}
		else if(a == 11 && b == 72)
		{
			return 83;
		}
		else if(a == 11 && b == 73)
		{
			return 84;
		}
		else if(a == 11 && b == 74)
		{
			return 85;
		}
		else if(a == 11 && b == 75)
		{
			return 86;
		}
		else if(a == 11 && b == 76)
		{
			return 87;
		}
		else if(a == 11 && b == 77)
		{
			return 88;
		}
		else if(a == 11 && b == 78)
		{
			return 89;
		}
		else if(a == 11 && b == 79)
		{
			return 90;
		}
		else if(a == 11 && b == 80)
		{
			return 91;
		}
		else if(a == 11 && b == 81)
		{
			return 92;
		}
		else if(a == 11 && b == 82)
		{
			return 93;
		}
		else if(a == 11 && b == 83)
		{
			return 94;
		}
		else if(a == 11 && b == 84)
		{
			return 95;
		}
		else if(a == 11 && b == 85)
		{
			return 96;
		}
		else if(a == 11 && b == 86)
		{
			return 97;
		}
		else if(a == 11 && b == 87)
		{
			return 98;
		}
		else if(a == 11 && b == 88)
		{
			return 99;
		}
		else if(a == 11 && b == 89)
		{
			return 100;
		}
		else if(a == 11 && b == 90)
		{
			return 101;
		}
		else if(a == 11 && b == 91)
		{
			return 102;
		}
		else if(a == 11 && b == 92)
		{
			return 103;
		}
		else if(a == 11 && b == 93)
		{
			return 104;
		}
		else if(a == 11 && b == 94)
		{
			return 105;
		}
		else if(a == 11 && b == 95)
		{
			return 106;
		}
		else if(a == 11 && b == 96)
		{
			return 107;
		}
		else if(a == 11 && b == 97)
		{
			return 108;
		}
		else if(a == 11 && b == 98)
		{
			return 109;
		}
		else if(a == 11 && b == 99)
		{
			return 110;
		}
		else if(a == 11 && b == 100)
		{
			return 111;
		}
		else if(a == 12 && b == 0)
		{
			return 12;
		}
		else if(a == 12 && b == 1)
		{
			return 13;
		}
		else if(a == 12 && b == 2)
		{
			return 14;
		}
		else if(a == 12 && b == 3)
		{
			return 15;
		}
		else if(a == 12 && b == 4)
		{
			return 16;
		}
		else if(a == 12 && b == 5)
		{
			return 17;
		}
		else if(a == 12 && b == 6)
		{
			return 18;
		}
		else if(a == 12 && b == 7)
		{
			return 19;
		}
		else if(a == 12 && b == 8)
		{
			return 20;
		}
		else if(a == 12 && b == 9)
		{
			return 21;
		}
		else if(a == 12 && b == 10)
		{
			return 22;
		}
		else if(a == 12 && b == 11)
		{
			return 23;
		}
		else if(a == 12 && b == 12)
		{
			return 24;
		}
		else if(a == 12 && b == 13)
		{
			return 25;
		}
		else if(a == 12 && b == 14)
		{
			return 26;
		}
		else if(a == 12 && b == 15)
		{
			return 27;
		}
		else if(a == 12 && b == 16)
		{
			return 28;
		}
		else if(a == 12 && b == 17)
		{
			return 29;
		}
		else if(a == 12 && b == 18)
		{
			return 30;
		}
		else if(a == 12 && b == 19)
		{
			return 31;
		}
		else if(a == 12 && b == 20)
		{
			return 32;
		}
		else if(a == 12 && b == 21)
		{
			return 33;
		}
		else if(a == 12 && b == 22)
		{
			return 34;
		}
		else if(a == 12 && b == 23)
		{
			return 35;
		}
		else if(a == 12 && b == 24)
		{
			return 36;
		}
		else if(a == 12 && b == 25)
		{
			return 37;
		}
		else if(a == 12 && b == 26)
		{
			return 38;
		}
		else if(a == 12 && b == 27)
		{
			return 39;
		}
		else if(a == 12 && b == 28)
		{
			return 40;
		}
		else if(a == 12 && b == 29)
		{
			return 41;
		}
		else if(a == 12 && b == 30)
		{
			return 42;
		}
		else if(a == 12 && b == 31)
		{
			return 43;
		}
		else if(a == 12 && b == 32)
		{
			return 44;
		}
		else if(a == 12 && b == 33)
		{
			return 45;
		}
		else if(a == 12 && b == 34)
		{
			return 46;
		}
		else if(a == 12 && b == 35)
		{
			return 47;
		}
		else if(a == 12 && b == 36)
		{
			return 48;
		}
		else if(a == 12 && b == 37)
		{
			return 49;
		}
		else if(a == 12 && b == 38)
		{
			return 50;
		}
		else if(a == 12 && b == 39)
		{
			return 51;
		}
		else if(a == 12 && b == 40)
		{
			return 52;
		}
		else if(a == 12 && b == 41)
		{
			return 53;
		}
		else if(a == 12 && b == 42)
		{
			return 54;
		}
		else if(a == 12 && b == 43)
		{
			return 55;
		}
		else if(a == 12 && b == 44)
		{
			return 56;
		}
		else if(a == 12 && b == 45)
		{
			return 57;
		}
		else if(a == 12 && b == 46)
		{
			return 58;
		}
		else if(a == 12 && b == 47)
		{
			return 59;
		}
		else if(a == 12 && b == 48)
		{
			return 60;
		}
		else if(a == 12 && b == 49)
		{
			return 61;
		}
		else if(a == 12 && b == 50)
		{
			return 62;
		}
		else if(a == 12 && b == 51)
		{
			return 63;
		}
		else if(a == 12 && b == 52)
		{
			return 64;
		}
		else if(a == 12 && b == 53)
		{
			return 65;
		}
		else if(a == 12 && b == 54)
		{
			return 66;
		}
		else if(a == 12 && b == 55)
		{
			return 67;
		}
		else if(a == 12 && b == 56)
		{
			return 68;
		}
		else if(a == 12 && b == 57)
		{
			return 69;
		}
		else if(a == 12 && b == 58)
		{
			return 70;
		}
		else if(a == 12 && b == 59)
		{
			return 71;
		}
		else if(a == 12 && b == 60)
		{
			return 72;
		}
		else if(a == 12 && b == 61)
		{
			return 73;
		}
		else if(a == 12 && b == 62)
		{
			return 74;
		}
		else if(a == 12 && b == 63)
		{
			return 75;
		}
		else if(a == 12 && b == 64)
		{
			return 76;
		}
		else if(a == 12 && b == 65)
		{
			return 77;
		}
		else if(a == 12 && b == 66)
		{
			return 78;
		}
		else if(a == 12 && b == 67)
		{
			return 79;
		}
		else if(a == 12 && b == 68)
		{
			return 80;
		}
		else if(a == 12 && b == 69)
		{
			return 81;
		}
		else if(a == 12 && b == 70)
		{
			return 82;
		}
		else if(a == 12 && b == 71)
		{
			return 83;
		}
		else if(a == 12 && b == 72)
		{
			return 84;
		}
		else if(a == 12 && b == 73)
		{
			return 85;
		}
		else if(a == 12 && b == 74)
		{
			return 86;
		}
		else if(a == 12 && b == 75)
		{
			return 87;
		}
		else if(a == 12 && b == 76)
		{
			return 88;
		}
		else if(a == 12 && b == 77)
		{
			return 89;
		}
		else if(a == 12 && b == 78)
		{
			return 90;
		}
		else if(a == 12 && b == 79)
		{
			return 91;
		}
		else if(a == 12 && b == 80)
		{
			return 92;
		}
		else if(a == 12 && b == 81)
		{
			return 93;
		}
		else if(a == 12 && b == 82)
		{
			return 94;
		}
		else if(a == 12 && b == 83)
		{
			return 95;
		}
		else if(a == 12 && b == 84)
		{
			return 96;
		}
		else if(a == 12 && b == 85)
		{
			return 97;
		}
		else if(a == 12 && b == 86)
		{
			return 98;
		}
		else if(a == 12 && b == 87)
		{
			return 99;
		}
		else if(a == 12 && b == 88)
		{
			return 100;
		}
		else if(a == 12 && b == 89)
		{
			return 101;
		}
		else if(a == 12 && b == 90)
		{
			return 102;
		}
		else if(a == 12 && b == 91)
		{
			return 103;
		}
		else if(a == 12 && b == 92)
		{
			return 104;
		}
		else if(a == 12 && b == 93)
		{
			return 105;
		}
		else if(a == 12 && b == 94)
		{
			return 106;
		}
		else if(a == 12 && b == 95)
		{
			return 107;
		}
		else if(a == 12 && b == 96)
		{
			return 108;
		}
		else if(a == 12 && b == 97)
		{
			return 109;
		}
		else if(a == 12 && b == 98)
		{
			return 110;
		}
		else if(a == 12 && b == 99)
		{
			return 111;
		}
		else if(a == 12 && b == 100)
		{
			return 112;
		}
		else if(a == 13 && b == 0)
		{
			return 13;
		}
		else if(a == 13 && b == 1)
		{
			return 14;
		}
		else if(a == 13 && b == 2)
		{
			return 15;
		}
		else if(a == 13 && b == 3)
		{
			return 16;
		}
		else if(a == 13 && b == 4)
		{
			return 17;
		}
		else if(a == 13 && b == 5)
		{
			return 18;
		}
		else if(a == 13 && b == 6)
		{
			return 19;
		}
		else if(a == 13 && b == 7)
		{
			return 20;
		}
		else if(a == 13 && b == 8)
		{
			return 21;
		}
		else if(a == 13 && b == 9)
		{
			return 22;
		}
		else if(a == 13 && b == 10)
		{
			return 23;
		}
		else if(a == 13 && b == 11)
		{
			return 24;
		}
		else if(a == 13 && b == 12)
		{
			return 25;
		}
		else if(a == 13 && b == 13)
		{
			return 26;
		}
		else if(a == 13 && b == 14)
		{
			return 27;
		}
		else if(a == 13 && b == 15)
		{
			return 28;
		}
		else if(a == 13 && b == 16)
		{
			return 29;
		}
		else if(a == 13 && b == 17)
		{
			return 30;
		}
		else if(a == 13 && b == 18)
		{
			return 31;
		}
		else if(a == 13 && b == 19)
		{
			return 32;
		}
		else if(a == 13 && b == 20)
		{
			return 33;
		}
		else if(a == 13 && b == 21)
		{
			return 34;
		}
		else if(a == 13 && b == 22)
		{
			return 35;
		}
		else if(a == 13 && b == 23)
		{
			return 36;
		}
		else if(a == 13 && b == 24)
		{
			return 37;
		}
		else if(a == 13 && b == 25)
		{
			return 38;
		}
		else if(a == 13 && b == 26)
		{
			return 39;
		}
		else if(a == 13 && b == 27)
		{
			return 40;
		}
		else if(a == 13 && b == 28)
		{
			return 41;
		}
		else if(a == 13 && b == 29)
		{
			return 42;
		}
		else if(a == 13 && b == 30)
		{
			return 43;
		}
		else if(a == 13 && b == 31)
		{
			return 44;
		}
		else if(a == 13 && b == 32)
		{
			return 45;
		}
		else if(a == 13 && b == 33)
		{
			return 46;
		}
		else if(a == 13 && b == 34)
		{
			return 47;
		}
		else if(a == 13 && b == 35)
		{
			return 48;
		}
		else if(a == 13 && b == 36)
		{
			return 49;
		}
		else if(a == 13 && b == 37)
		{
			return 50;
		}
		else if(a == 13 && b == 38)
		{
			return 51;
		}
		else if(a == 13 && b == 39)
		{
			return 52;
		}
		else if(a == 13 && b == 40)
		{
			return 53;
		}
		else if(a == 13 && b == 41)
		{
			return 54;
		}
		else if(a == 13 && b == 42)
		{
			return 55;
		}
		else if(a == 13 && b == 43)
		{
			return 56;
		}
		else if(a == 13 && b == 44)
		{
			return 57;
		}
		else if(a == 13 && b == 45)
		{
			return 58;
		}
		else if(a == 13 && b == 46)
		{
			return 59;
		}
		else if(a == 13 && b == 47)
		{
			return 60;
		}
		else if(a == 13 && b == 48)
		{
			return 61;
		}
		else if(a == 13 && b == 49)
		{
			return 62;
		}
		else if(a == 13 && b == 50)
		{
			return 63;
		}
		else if(a == 13 && b == 51)
		{
			return 64;
		}
		else if(a == 13 && b == 52)
		{
			return 65;
		}
		else if(a == 13 && b == 53)
		{
			return 66;
		}
		else if(a == 13 && b == 54)
		{
			return 67;
		}
		else if(a == 13 && b == 55)
		{
			return 68;
		}
		else if(a == 13 && b == 56)
		{
			return 69;
		}
		else if(a == 13 && b == 57)
		{
			return 70;
		}
		else if(a == 13 && b == 58)
		{
			return 71;
		}
		else if(a == 13 && b == 59)
		{
			return 72;
		}
		else if(a == 13 && b == 60)
		{
			return 73;
		}
		else if(a == 13 && b == 61)
		{
			return 74;
		}
		else if(a == 13 && b == 62)
		{
			return 75;
		}
		else if(a == 13 && b == 63)
		{
			return 76;
		}
		else if(a == 13 && b == 64)
		{
			return 77;
		}
		else if(a == 13 && b == 65)
		{
			return 78;
		}
		else if(a == 13 && b == 66)
		{
			return 79;
		}
		else if(a == 13 && b == 67)
		{
			return 80;
		}
		else if(a == 13 && b == 68)
		{
			return 81;
		}
		else if(a == 13 && b == 69)
		{
			return 82;
		}
		else if(a == 13 && b == 70)
		{
			return 83;
		}
		else if(a == 13 && b == 71)
		{
			return 84;
		}
		else if(a == 13 && b == 72)
		{
			return 85;
		}
		else if(a == 13 && b == 73)
		{
			return 86;
		}
		else if(a == 13 && b == 74)
		{
			return 87;
		}
		else if(a == 13 && b == 75)
		{
			return 88;
		}
		else if(a == 13 && b == 76)
		{
			return 89;
		}
		else if(a == 13 && b == 77)
		{
			return 90;
		}
		else if(a == 13 && b == 78)
		{
			return 91;
		}
		else if(a == 13 && b == 79)
		{
			return 92;
		}
		else if(a == 13 && b == 80)
		{
			return 93;
		}
		else if(a == 13 && b == 81)
		{
			return 94;
		}
		else if(a == 13 && b == 82)
		{
			return 95;
		}
		else if(a == 13 && b == 83)
		{
			return 96;
		}
		else if(a == 13 && b == 84)
		{
			return 97;
		}
		else if(a == 13 && b == 85)
		{
			return 98;
		}
		else if(a == 13 && b == 86)
		{
			return 99;
		}
		else if(a == 13 && b == 87)
		{
			return 100;
		}
		else if(a == 13 && b == 88)
		{
			return 101;
		}
		else if(a == 13 && b == 89)
		{
			return 102;
		}
		else if(a == 13 && b == 90)
		{
			return 103;
		}
		else if(a == 13 && b == 91)
		{
			return 104;
		}
		else if(a == 13 && b == 92)
		{
			return 105;
		}
		else if(a == 13 && b == 93)
		{
			return 106;
		}
		else if(a == 13 && b == 94)
		{
			return 107;
		}
		else if(a == 13 && b == 95)
		{
			return 108;
		}
		else if(a == 13 && b == 96)
		{
			return 109;
		}
		else if(a == 13 && b == 97)
		{
			return 110;
		}
		else if(a == 13 && b == 98)
		{
			return 111;
		}
		else if(a == 13 && b == 99)
		{
			return 112;
		}
		else if(a == 13 && b == 100)
		{
			return 113;
		}
		else if(a == 14 && b == 0)
		{
			return 14;
		}
		else if(a == 14 && b == 1)
		{
			return 15;
		}
		else if(a == 14 && b == 2)
		{
			return 16;
		}
		else if(a == 14 && b == 3)
		{
			return 17;
		}
		else if(a == 14 && b == 4)
		{
			return 18;
		}
		else if(a == 14 && b == 5)
		{
			return 19;
		}
		else if(a == 14 && b == 6)
		{
			return 20;
		}
		else if(a == 14 && b == 7)
		{
			return 21;
		}
		else if(a == 14 && b == 8)
		{
			return 22;
		}
		else if(a == 14 && b == 9)
		{
			return 23;
		}
		else if(a == 14 && b == 10)
		{
			return 24;
		}
		else if(a == 14 && b == 11)
		{
			return 25;
		}
		else if(a == 14 && b == 12)
		{
			return 26;
		}
		else if(a == 14 && b == 13)
		{
			return 27;
		}
		else if(a == 14 && b == 14)
		{
			return 28;
		}
		else if(a == 14 && b == 15)
		{
			return 29;
		}
		else if(a == 14 && b == 16)
		{
			return 30;
		}
		else if(a == 14 && b == 17)
		{
			return 31;
		}
		else if(a == 14 && b == 18)
		{
			return 32;
		}
		else if(a == 14 && b == 19)
		{
			return 33;
		}
		else if(a == 14 && b == 20)
		{
			return 34;
		}
		else if(a == 14 && b == 21)
		{
			return 35;
		}
		else if(a == 14 && b == 22)
		{
			return 36;
		}
		else if(a == 14 && b == 23)
		{
			return 37;
		}
		else if(a == 14 && b == 24)
		{
			return 38;
		}
		else if(a == 14 && b == 25)
		{
			return 39;
		}
		else if(a == 14 && b == 26)
		{
			return 40;
		}
		else if(a == 14 && b == 27)
		{
			return 41;
		}
		else if(a == 14 && b == 28)
		{
			return 42;
		}
		else if(a == 14 && b == 29)
		{
			return 43;
		}
		else if(a == 14 && b == 30)
		{
			return 44;
		}
		else if(a == 14 && b == 31)
		{
			return 45;
		}
		else if(a == 14 && b == 32)
		{
			return 46;
		}
		else if(a == 14 && b == 33)
		{
			return 47;
		}
		else if(a == 14 && b == 34)
		{
			return 48;
		}
		else if(a == 14 && b == 35)
		{
			return 49;
		}
		else if(a == 14 && b == 36)
		{
			return 50;
		}
		else if(a == 14 && b == 37)
		{
			return 51;
		}
		else if(a == 14 && b == 38)
		{
			return 52;
		}
		else if(a == 14 && b == 39)
		{
			return 53;
		}
		else if(a == 14 && b == 40)
		{
			return 54;
		}
		else if(a == 14 && b == 41)
		{
			return 55;
		}
		else if(a == 14 && b == 42)
		{
			return 56;
		}
		else if(a == 14 && b == 43)
		{
			return 57;
		}
		else if(a == 14 && b == 44)
		{
			return 58;
		}
		else if(a == 14 && b == 45)
		{
			return 59;
		}
		else if(a == 14 && b == 46)
		{
			return 60;
		}
		else if(a == 14 && b == 47)
		{
			return 61;
		}
		else if(a == 14 && b == 48)
		{
			return 62;
		}
		else if(a == 14 && b == 49)
		{
			return 63;
		}
		else if(a == 14 && b == 50)
		{
			return 64;
		}
		else if(a == 14 && b == 51)
		{
			return 65;
		}
		else if(a == 14 && b == 52)
		{
			return 66;
		}
		else if(a == 14 && b == 53)
		{
			return 67;
		}
		else if(a == 14 && b == 54)
		{
			return 68;
		}
		else if(a == 14 && b == 55)
		{
			return 69;
		}
		else if(a == 14 && b == 56)
		{
			return 70;
		}
		else if(a == 14 && b == 57)
		{
			return 71;
		}
		else if(a == 14 && b == 58)
		{
			return 72;
		}
		else if(a == 14 && b == 59)
		{
			return 73;
		}
		else if(a == 14 && b == 60)
		{
			return 74;
		}
		else if(a == 14 && b == 61)
		{
			return 75;
		}
		else if(a == 14 && b == 62)
		{
			return 76;
		}
		else if(a == 14 && b == 63)
		{
			return 77;
		}
		else if(a == 14 && b == 64)
		{
			return 78;
		}
		else if(a == 14 && b == 65)
		{
			return 79;
		}
		else if(a == 14 && b == 66)
		{
			return 80;
		}
		else if(a == 14 && b == 67)
		{
			return 81;
		}
		else if(a == 14 && b == 68)
		{
			return 82;
		}
		else if(a == 14 && b == 69)
		{
			return 83;
		}
		else if(a == 14 && b == 70)
		{
			return 84;
		}
		else if(a == 14 && b == 71)
		{
			return 85;
		}
		else if(a == 14 && b == 72)
		{
			return 86;
		}
		else if(a == 14 && b == 73)
		{
			return 87;
		}
		else if(a == 14 && b == 74)
		{
			return 88;
		}
		else if(a == 14 && b == 75)
		{
			return 89;
		}
		else if(a == 14 && b == 76)
		{
			return 90;
		}
		else if(a == 14 && b == 77)
		{
			return 91;
		}
		else if(a == 14 && b == 78)
		{
			return 92;
		}
		else if(a == 14 && b == 79)
		{
			return 93;
		}
		else if(a == 14 && b == 80)
		{
			return 94;
		}
		else if(a == 14 && b == 81)
		{
			return 95;
		}
		else if(a == 14 && b == 82)
		{
			return 96;
		}
		else if(a == 14 && b == 83)
		{
			return 97;
		}
		else if(a == 14 && b == 84)
		{
			return 98;
		}
		else if(a == 14 && b == 85)
		{
			return 99;
		}
		else if(a == 14 && b == 86)
		{
			return 100;
		}
		else if(a == 14 && b == 87)
		{
			return 101;
		}
		else if(a == 14 && b == 88)
		{
			return 102;
		}
		else if(a == 14 && b == 89)
		{
			return 103;
		}
		else if(a == 14 && b == 90)
		{
			return 104;
		}
		else if(a == 14 && b == 91)
		{
			return 105;
		}
		else if(a == 14 && b == 92)
		{
			return 106;
		}
		else if(a == 14 && b == 93)
		{
			return 107;
		}
		else if(a == 14 && b == 94)
		{
			return 108;
		}
		else if(a == 14 && b == 95)
		{
			return 109;
		}
		else if(a == 14 && b == 96)
		{
			return 110;
		}
		else if(a == 14 && b == 97)
		{
			return 111;
		}
		else if(a == 14 && b == 98)
		{
			return 112;
		}
		else if(a == 14 && b == 99)
		{
			return 113;
		}
		else if(a == 14 && b == 100)
		{
			return 114;
		}
		else if(a == 15 && b == 0)
		{
			return 15;
		}
		else if(a == 15 && b == 1)
		{
			return 16;
		}
		else if(a == 15 && b == 2)
		{
			return 17;
		}
		else if(a == 15 && b == 3)
		{
			return 18;
		}
		else if(a == 15 && b == 4)
		{
			return 19;
		}
		else if(a == 15 && b == 5)
		{
			return 20;
		}
		else if(a == 15 && b == 6)
		{
			return 21;
		}
		else if(a == 15 && b == 7)
		{
			return 22;
		}
		else if(a == 15 && b == 8)
		{
			return 23;
		}
		else if(a == 15 && b == 9)
		{
			return 24;
		}
		else if(a == 15 && b == 10)
		{
			return 25;
		}
		else if(a == 15 && b == 11)
		{
			return 26;
		}
		else if(a == 15 && b == 12)
		{
			return 27;
		}
		else if(a == 15 && b == 13)
		{
			return 28;
		}
		else if(a == 15 && b == 14)
		{
			return 29;
		}
		else if(a == 15 && b == 15)
		{
			return 30;
		}
		else if(a == 15 && b == 16)
		{
			return 31;
		}
		else if(a == 15 && b == 17)
		{
			return 32;
		}
		else if(a == 15 && b == 18)
		{
			return 33;
		}
		else if(a == 15 && b == 19)
		{
			return 34;
		}
		else if(a == 15 && b == 20)
		{
			return 35;
		}
		else if(a == 15 && b == 21)
		{
			return 36;
		}
		else if(a == 15 && b == 22)
		{
			return 37;
		}
		else if(a == 15 && b == 23)
		{
			return 38;
		}
		else if(a == 15 && b == 24)
		{
			return 39;
		}
		else if(a == 15 && b == 25)
		{
			return 40;
		}
		else if(a == 15 && b == 26)
		{
			return 41;
		}
		else if(a == 15 && b == 27)
		{
			return 42;
		}
		else if(a == 15 && b == 28)
		{
			return 43;
		}
		else if(a == 15 && b == 29)
		{
			return 44;
		}
		else if(a == 15 && b == 30)
		{
			return 45;
		}
		else if(a == 15 && b == 31)
		{
			return 46;
		}
		else if(a == 15 && b == 32)
		{
			return 47;
		}
		else if(a == 15 && b == 33)
		{
			return 48;
		}
		else if(a == 15 && b == 34)
		{
			return 49;
		}
		else if(a == 15 && b == 35)
		{
			return 50;
		}
		else if(a == 15 && b == 36)
		{
			return 51;
		}
		else if(a == 15 && b == 37)
		{
			return 52;
		}
		else if(a == 15 && b == 38)
		{
			return 53;
		}
		else if(a == 15 && b == 39)
		{
			return 54;
		}
		else if(a == 15 && b == 40)
		{
			return 55;
		}
		else if(a == 15 && b == 41)
		{
			return 56;
		}
		else if(a == 15 && b == 42)
		{
			return 57;
		}
		else if(a == 15 && b == 43)
		{
			return 58;
		}
		else if(a == 15 && b == 44)
		{
			return 59;
		}
		else if(a == 15 && b == 45)
		{
			return 60;
		}
		else if(a == 15 && b == 46)
		{
			return 61;
		}
		else if(a == 15 && b == 47)
		{
			return 62;
		}
		else if(a == 15 && b == 48)
		{
			return 63;
		}
		else if(a == 15 && b == 49)
		{
			return 64;
		}
		else if(a == 15 && b == 50)
		{
			return 65;
		}
		else if(a == 15 && b == 51)
		{
			return 66;
		}
		else if(a == 15 && b == 52)
		{
			return 67;
		}
		else if(a == 15 && b == 53)
		{
			return 68;
		}
		else if(a == 15 && b == 54)
		{
			return 69;
		}
		else if(a == 15 && b == 55)
		{
			return 70;
		}
		else if(a == 15 && b == 56)
		{
			return 71;
		}
		else if(a == 15 && b == 57)
		{
			return 72;
		}
		else if(a == 15 && b == 58)
		{
			return 73;
		}
		else if(a == 15 && b == 59)
		{
			return 74;
		}
		else if(a == 15 && b == 60)
		{
			return 75;
		}
		else if(a == 15 && b == 61)
		{
			return 76;
		}
		else if(a == 15 && b == 62)
		{
			return 77;
		}
		else if(a == 15 && b == 63)
		{
			return 78;
		}
		else if(a == 15 && b == 64)
		{
			return 79;
		}
		else if(a == 15 && b == 65)
		{
			return 80;
		}
		else if(a == 15 && b == 66)
		{
			return 81;
		}
		else if(a == 15 && b == 67)
		{
			return 82;
		}
		else if(a == 15 && b == 68)
		{
			return 83;
		}
		else if(a == 15 && b == 69)
		{
			return 84;
		}
		else if(a == 15 && b == 70)
		{
			return 85;
		}
		else if(a == 15 && b == 71)
		{
			return 86;
		}
		else if(a == 15 && b == 72)
		{
			return 87;
		}
		else if(a == 15 && b == 73)
		{
			return 88;
		}
		else if(a == 15 && b == 74)
		{
			return 89;
		}
		else if(a == 15 && b == 75)
		{
			return 90;
		}
		else if(a == 15 && b == 76)
		{
			return 91;
		}
		else if(a == 15 && b == 77)
		{
			return 92;
		}
		else if(a == 15 && b == 78)
		{
			return 93;
		}
		else if(a == 15 && b == 79)
		{
			return 94;
		}
		else if(a == 15 && b == 80)
		{
			return 95;
		}
		else if(a == 15 && b == 81)
		{
			return 96;
		}
		else if(a == 15 && b == 82)
		{
			return 97;
		}
		else if(a == 15 && b == 83)
		{
			return 98;
		}
		else if(a == 15 && b == 84)
		{
			return 99;
		}
		else if(a == 15 && b == 85)
		{
			return 100;
		}
		else if(a == 15 && b == 86)
		{
			return 101;
		}
		else if(a == 15 && b == 87)
		{
			return 102;
		}
		else if(a == 15 && b == 88)
		{
			return 103;
		}
		else if(a == 15 && b == 89)
		{
			return 104;
		}
		else if(a == 15 && b == 90)
		{
			return 105;
		}
		else if(a == 15 && b == 91)
		{
			return 106;
		}
		else if(a == 15 && b == 92)
		{
			return 107;
		}
		else if(a == 15 && b == 93)
		{
			return 108;
		}
		else if(a == 15 && b == 94)
		{
			return 109;
		}
		else if(a == 15 && b == 95)
		{
			return 110;
		}
		else if(a == 15 && b == 96)
		{
			return 111;
		}
		else if(a == 15 && b == 97)
		{
			return 112;
		}
		else if(a == 15 && b == 98)
		{
			return 113;
		}
		else if(a == 15 && b == 99)
		{
			return 114;
		}
		else if(a == 15 && b == 100)
		{
			return 115;
		}
		else if(a == 16 && b == 0)
		{
			return 16;
		}
		else if(a == 16 && b == 1)
		{
			return 17;
		}
		else if(a == 16 && b == 2)
		{
			return 18;
		}
		else if(a == 16 && b == 3)
		{
			return 19;
		}
		else if(a == 16 && b == 4)
		{
			return 20;
		}
		else if(a == 16 && b == 5)
		{
			return 21;
		}
		else if(a == 16 && b == 6)
		{
			return 22;
		}
		else if(a == 16 && b == 7)
		{
			return 23;
		}
		else if(a == 16 && b == 8)
		{
			return 24;
		}
		else if(a == 16 && b == 9)
		{
			return 25;
		}
		else if(a == 16 && b == 10)
		{
			return 26;
		}
		else if(a == 16 && b == 11)
		{
			return 27;
		}
		else if(a == 16 && b == 12)
		{
			return 28;
		}
		else if(a == 16 && b == 13)
		{
			return 29;
		}
		else if(a == 16 && b == 14)
		{
			return 30;
		}
		else if(a == 16 && b == 15)
		{
			return 31;
		}
		else if(a == 16 && b == 16)
		{
			return 32;
		}
		else if(a == 16 && b == 17)
		{
			return 33;
		}
		else if(a == 16 && b == 18)
		{
			return 34;
		}
		else if(a == 16 && b == 19)
		{
			return 35;
		}
		else if(a == 16 && b == 20)
		{
			return 36;
		}
		else if(a == 16 && b == 21)
		{
			return 37;
		}
		else if(a == 16 && b == 22)
		{
			return 38;
		}
		else if(a == 16 && b == 23)
		{
			return 39;
		}
		else if(a == 16 && b == 24)
		{
			return 40;
		}
		else if(a == 16 && b == 25)
		{
			return 41;
		}
		else if(a == 16 && b == 26)
		{
			return 42;
		}
		else if(a == 16 && b == 27)
		{
			return 43;
		}
		else if(a == 16 && b == 28)
		{
			return 44;
		}
		else if(a == 16 && b == 29)
		{
			return 45;
		}
		else if(a == 16 && b == 30)
		{
			return 46;
		}
		else if(a == 16 && b == 31)
		{
			return 47;
		}
		else if(a == 16 && b == 32)
		{
			return 48;
		}
		else if(a == 16 && b == 33)
		{
			return 49;
		}
		else if(a == 16 && b == 34)
		{
			return 50;
		}
		else if(a == 16 && b == 35)
		{
			return 51;
		}
		else if(a == 16 && b == 36)
		{
			return 52;
		}
		else if(a == 16 && b == 37)
		{
			return 53;
		}
		else if(a == 16 && b == 38)
		{
			return 54;
		}
		else if(a == 16 && b == 39)
		{
			return 55;
		}
		else if(a == 16 && b == 40)
		{
			return 56;
		}
		else if(a == 16 && b == 41)
		{
			return 57;
		}
		else if(a == 16 && b == 42)
		{
			return 58;
		}
		else if(a == 16 && b == 43)
		{
			return 59;
		}
		else if(a == 16 && b == 44)
		{
			return 60;
		}
		else if(a == 16 && b == 45)
		{
			return 61;
		}
		else if(a == 16 && b == 46)
		{
			return 62;
		}
		else if(a == 16 && b == 47)
		{
			return 63;
		}
		else if(a == 16 && b == 48)
		{
			return 64;
		}
		else if(a == 16 && b == 49)
		{
			return 65;
		}
		else if(a == 16 && b == 50)
		{
			return 66;
		}
		else if(a == 16 && b == 51)
		{
			return 67;
		}
		else if(a == 16 && b == 52)
		{
			return 68;
		}
		else if(a == 16 && b == 53)
		{
			return 69;
		}
		else if(a == 16 && b == 54)
		{
			return 70;
		}
		else if(a == 16 && b == 55)
		{
			return 71;
		}
		else if(a == 16 && b == 56)
		{
			return 72;
		}
		else if(a == 16 && b == 57)
		{
			return 73;
		}
		else if(a == 16 && b == 58)
		{
			return 74;
		}
		else if(a == 16 && b == 59)
		{
			return 75;
		}
		else if(a == 16 && b == 60)
		{
			return 76;
		}
		else if(a == 16 && b == 61)
		{
			return 77;
		}
		else if(a == 16 && b == 62)
		{
			return 78;
		}
		else if(a == 16 && b == 63)
		{
			return 79;
		}
		else if(a == 16 && b == 64)
		{
			return 80;
		}
		else if(a == 16 && b == 65)
		{
			return 81;
		}
		else if(a == 16 && b == 66)
		{
			return 82;
		}
		else if(a == 16 && b == 67)
		{
			return 83;
		}
		else if(a == 16 && b == 68)
		{
			return 84;
		}
		else if(a == 16 && b == 69)
		{
			return 85;
		}
		else if(a == 16 && b == 70)
		{
			return 86;
		}
		else if(a == 16 && b == 71)
		{
			return 87;
		}
		else if(a == 16 && b == 72)
		{
			return 88;
		}
		else if(a == 16 && b == 73)
		{
			return 89;
		}
		else if(a == 16 && b == 74)
		{
			return 90;
		}
		else if(a == 16 && b == 75)
		{
			return 91;
		}
		else if(a == 16 && b == 76)
		{
			return 92;
		}
		else if(a == 16 && b == 77)
		{
			return 93;
		}
		else if(a == 16 && b == 78)
		{
			return 94;
		}
		else if(a == 16 && b == 79)
		{
			return 95;
		}
		else if(a == 16 && b == 80)
		{
			return 96;
		}
		else if(a == 16 && b == 81)
		{
			return 97;
		}
		else if(a == 16 && b == 82)
		{
			return 98;
		}
		else if(a == 16 && b == 83)
		{
			return 99;
		}
		else if(a == 16 && b == 84)
		{
			return 100;
		}
		else if(a == 16 && b == 85)
		{
			return 101;
		}
		else if(a == 16 && b == 86)
		{
			return 102;
		}
		else if(a == 16 && b == 87)
		{
			return 103;
		}
		else if(a == 16 && b == 88)
		{
			return 104;
		}
		else if(a == 16 && b == 89)
		{
			return 105;
		}
		else if(a == 16 && b == 90)
		{
			return 106;
		}
		else if(a == 16 && b == 91)
		{
			return 107;
		}
		else if(a == 16 && b == 92)
		{
			return 108;
		}
		else if(a == 16 && b == 93)
		{
			return 109;
		}
		else if(a == 16 && b == 94)
		{
			return 110;
		}
		else if(a == 16 && b == 95)
		{
			return 111;
		}
		else if(a == 16 && b == 96)
		{
			return 112;
		}
		else if(a == 16 && b == 97)
		{
			return 113;
		}
		else if(a == 16 && b == 98)
		{
			return 114;
		}
		else if(a == 16 && b == 99)
		{
			return 115;
		}
		else if(a == 16 && b == 100)
		{
			return 116;
		}
		else if(a == 17 && b == 0)
		{
			return 17;
		}
		else if(a == 17 && b == 1)
		{
			return 18;
		}
		else if(a == 17 && b == 2)
		{
			return 19;
		}
		else if(a == 17 && b == 3)
		{
			return 20;
		}
		else if(a == 17 && b == 4)
		{
			return 21;
		}
		else if(a == 17 && b == 5)
		{
			return 22;
		}
		else if(a == 17 && b == 6)
		{
			return 23;
		}
		else if(a == 17 && b == 7)
		{
			return 24;
		}
		else if(a == 17 && b == 8)
		{
			return 25;
		}
		else if(a == 17 && b == 9)
		{
			return 26;
		}
		else if(a == 17 && b == 10)
		{
			return 27;
		}
		else if(a == 17 && b == 11)
		{
			return 28;
		}
		else if(a == 17 && b == 12)
		{
			return 29;
		}
		else if(a == 17 && b == 13)
		{
			return 30;
		}
		else if(a == 17 && b == 14)
		{
			return 31;
		}
		else if(a == 17 && b == 15)
		{
			return 32;
		}
		else if(a == 17 && b == 16)
		{
			return 33;
		}
		else if(a == 17 && b == 17)
		{
			return 34;
		}
		else if(a == 17 && b == 18)
		{
			return 35;
		}
		else if(a == 17 && b == 19)
		{
			return 36;
		}
		else if(a == 17 && b == 20)
		{
			return 37;
		}
		else if(a == 17 && b == 21)
		{
			return 38;
		}
		else if(a == 17 && b == 22)
		{
			return 39;
		}
		else if(a == 17 && b == 23)
		{
			return 40;
		}
		else if(a == 17 && b == 24)
		{
			return 41;
		}
		else if(a == 17 && b == 25)
		{
			return 42;
		}
		else if(a == 17 && b == 26)
		{
			return 43;
		}
		else if(a == 17 && b == 27)
		{
			return 44;
		}
		else if(a == 17 && b == 28)
		{
			return 45;
		}
		else if(a == 17 && b == 29)
		{
			return 46;
		}
		else if(a == 17 && b == 30)
		{
			return 47;
		}
		else if(a == 17 && b == 31)
		{
			return 48;
		}
		else if(a == 17 && b == 32)
		{
			return 49;
		}
		else if(a == 17 && b == 33)
		{
			return 50;
		}
		else if(a == 17 && b == 34)
		{
			return 51;
		}
		else if(a == 17 && b == 35)
		{
			return 52;
		}
		else if(a == 17 && b == 36)
		{
			return 53;
		}
		else if(a == 17 && b == 37)
		{
			return 54;
		}
		else if(a == 17 && b == 38)
		{
			return 55;
		}
		else if(a == 17 && b == 39)
		{
			return 56;
		}
		else if(a == 17 && b == 40)
		{
			return 57;
		}
		else if(a == 17 && b == 41)
		{
			return 58;
		}
		else if(a == 17 && b == 42)
		{
			return 59;
		}
		else if(a == 17 && b == 43)
		{
			return 60;
		}
		else if(a == 17 && b == 44)
		{
			return 61;
		}
		else if(a == 17 && b == 45)
		{
			return 62;
		}
		else if(a == 17 && b == 46)
		{
			return 63;
		}
		else if(a == 17 && b == 47)
		{
			return 64;
		}
		else if(a == 17 && b == 48)
		{
			return 65;
		}
		else if(a == 17 && b == 49)
		{
			return 66;
		}
		else if(a == 17 && b == 50)
		{
			return 67;
		}
		else if(a == 17 && b == 51)
		{
			return 68;
		}
		else if(a == 17 && b == 52)
		{
			return 69;
		}
		else if(a == 17 && b == 53)
		{
			return 70;
		}
		else if(a == 17 && b == 54)
		{
			return 71;
		}
		else if(a == 17 && b == 55)
		{
			return 72;
		}
		else if(a == 17 && b == 56)
		{
			return 73;
		}
		else if(a == 17 && b == 57)
		{
			return 74;
		}
		else if(a == 17 && b == 58)
		{
			return 75;
		}
		else if(a == 17 && b == 59)
		{
			return 76;
		}
		else if(a == 17 && b == 60)
		{
			return 77;
		}
		else if(a == 17 && b == 61)
		{
			return 78;
		}
		else if(a == 17 && b == 62)
		{
			return 79;
		}
		else if(a == 17 && b == 63)
		{
			return 80;
		}
		else if(a == 17 && b == 64)
		{
			return 81;
		}
		else if(a == 17 && b == 65)
		{
			return 82;
		}
		else if(a == 17 && b == 66)
		{
			return 83;
		}
		else if(a == 17 && b == 67)
		{
			return 84;
		}
		else if(a == 17 && b == 68)
		{
			return 85;
		}
		else if(a == 17 && b == 69)
		{
			return 86;
		}
		else if(a == 17 && b == 70)
		{
			return 87;
		}
		else if(a == 17 && b == 71)
		{
			return 88;
		}
		else if(a == 17 && b == 72)
		{
			return 89;
		}
		else if(a == 17 && b == 73)
		{
			return 90;
		}
		else if(a == 17 && b == 74)
		{
			return 91;
		}
		else if(a == 17 && b == 75)
		{
			return 92;
		}
		else if(a == 17 && b == 76)
		{
			return 93;
		}
		else if(a == 17 && b == 77)
		{
			return 94;
		}
		else if(a == 17 && b == 78)
		{
			return 95;
		}
		else if(a == 17 && b == 79)
		{
			return 96;
		}
		else if(a == 17 && b == 80)
		{
			return 97;
		}
		else if(a == 17 && b == 81)
		{
			return 98;
		}
		else if(a == 17 && b == 82)
		{
			return 99;
		}
		else if(a == 17 && b == 83)
		{
			return 100;
		}
		else if(a == 17 && b == 84)
		{
			return 101;
		}
		else if(a == 17 && b == 85)
		{
			return 102;
		}
		else if(a == 17 && b == 86)
		{
			return 103;
		}
		else if(a == 17 && b == 87)
		{
			return 104;
		}
		else if(a == 17 && b == 88)
		{
			return 105;
		}
		else if(a == 17 && b == 89)
		{
			return 106;
		}
		else if(a == 17 && b == 90)
		{
			return 107;
		}
		else if(a == 17 && b == 91)
		{
			return 108;
		}
		else if(a == 17 && b == 92)
		{
			return 109;
		}
		else if(a == 17 && b == 93)
		{
			return 110;
		}
		else if(a == 17 && b == 94)
		{
			return 111;
		}
		else if(a == 17 && b == 95)
		{
			return 112;
		}
		else if(a == 17 && b == 96)
		{
			return 113;
		}
		else if(a == 17 && b == 97)
		{
			return 114;
		}
		else if(a == 17 && b == 98)
		{
			return 115;
		}
		else if(a == 17 && b == 99)
		{
			return 116;
		}
		else if(a == 17 && b == 100)
		{
			return 117;
		}
		else if(a == 18 && b == 0)
		{
			return 18;
		}
		else if(a == 18 && b == 1)
		{
			return 19;
		}
		else if(a == 18 && b == 2)
		{
			return 20;
		}
		else if(a == 18 && b == 3)
		{
			return 21;
		}
		else if(a == 18 && b == 4)
		{
			return 22;
		}
		else if(a == 18 && b == 5)
		{
			return 23;
		}
		else if(a == 18 && b == 6)
		{
			return 24;
		}
		else if(a == 18 && b == 7)
		{
			return 25;
		}
		else if(a == 18 && b == 8)
		{
			return 26;
		}
		else if(a == 18 && b == 9)
		{
			return 27;
		}
		else if(a == 18 && b == 10)
		{
			return 28;
		}
		else if(a == 18 && b == 11)
		{
			return 29;
		}
		else if(a == 18 && b == 12)
		{
			return 30;
		}
		else if(a == 18 && b == 13)
		{
			return 31;
		}
		else if(a == 18 && b == 14)
		{
			return 32;
		}
		else if(a == 18 && b == 15)
		{
			return 33;
		}
		else if(a == 18 && b == 16)
		{
			return 34;
		}
		else if(a == 18 && b == 17)
		{
			return 35;
		}
		else if(a == 18 && b == 18)
		{
			return 36;
		}
		else if(a == 18 && b == 19)
		{
			return 37;
		}
		else if(a == 18 && b == 20)
		{
			return 38;
		}
		else if(a == 18 && b == 21)
		{
			return 39;
		}
		else if(a == 18 && b == 22)
		{
			return 40;
		}
		else if(a == 18 && b == 23)
		{
			return 41;
		}
		else if(a == 18 && b == 24)
		{
			return 42;
		}
		else if(a == 18 && b == 25)
		{
			return 43;
		}
		else if(a == 18 && b == 26)
		{
			return 44;
		}
		else if(a == 18 && b == 27)
		{
			return 45;
		}
		else if(a == 18 && b == 28)
		{
			return 46;
		}
		else if(a == 18 && b == 29)
		{
			return 47;
		}
		else if(a == 18 && b == 30)
		{
			return 48;
		}
		else if(a == 18 && b == 31)
		{
			return 49;
		}
		else if(a == 18 && b == 32)
		{
			return 50;
		}
		else if(a == 18 && b == 33)
		{
			return 51;
		}
		else if(a == 18 && b == 34)
		{
			return 52;
		}
		else if(a == 18 && b == 35)
		{
			return 53;
		}
		else if(a == 18 && b == 36)
		{
			return 54;
		}
		else if(a == 18 && b == 37)
		{
			return 55;
		}
		else if(a == 18 && b == 38)
		{
			return 56;
		}
		else if(a == 18 && b == 39)
		{
			return 57;
		}
		else if(a == 18 && b == 40)
		{
			return 58;
		}
		else if(a == 18 && b == 41)
		{
			return 59;
		}
		else if(a == 18 && b == 42)
		{
			return 60;
		}
		else if(a == 18 && b == 43)
		{
			return 61;
		}
		else if(a == 18 && b == 44)
		{
			return 62;
		}
		else if(a == 18 && b == 45)
		{
			return 63;
		}
		else if(a == 18 && b == 46)
		{
			return 64;
		}
		else if(a == 18 && b == 47)
		{
			return 65;
		}
		else if(a == 18 && b == 48)
		{
			return 66;
		}
		else if(a == 18 && b == 49)
		{
			return 67;
		}
		else if(a == 18 && b == 50)
		{
			return 68;
		}
		else if(a == 18 && b == 51)
		{
			return 69;
		}
		else if(a == 18 && b == 52)
		{
			return 70;
		}
		else if(a == 18 && b == 53)
		{
			return 71;
		}
		else if(a == 18 && b == 54)
		{
			return 72;
		}
		else if(a == 18 && b == 55)
		{
			return 73;
		}
		else if(a == 18 && b == 56)
		{
			return 74;
		}
		else if(a == 18 && b == 57)
		{
			return 75;
		}
		else if(a == 18 && b == 58)
		{
			return 76;
		}
		else if(a == 18 && b == 59)
		{
			return 77;
		}
		else if(a == 18 && b == 60)
		{
			return 78;
		}
		else if(a == 18 && b == 61)
		{
			return 79;
		}
		else if(a == 18 && b == 62)
		{
			return 80;
		}
		else if(a == 18 && b == 63)
		{
			return 81;
		}
		else if(a == 18 && b == 64)
		{
			return 82;
		}
		else if(a == 18 && b == 65)
		{
			return 83;
		}
		else if(a == 18 && b == 66)
		{
			return 84;
		}
		else if(a == 18 && b == 67)
		{
			return 85;
		}
		else if(a == 18 && b == 68)
		{
			return 86;
		}
		else if(a == 18 && b == 69)
		{
			return 87;
		}
		else if(a == 18 && b == 70)
		{
			return 88;
		}
		else if(a == 18 && b == 71)
		{
			return 89;
		}
		else if(a == 18 && b == 72)
		{
			return 90;
		}
		else if(a == 18 && b == 73)
		{
			return 91;
		}
		else if(a == 18 && b == 74)
		{
			return 92;
		}
		else if(a == 18 && b == 75)
		{
			return 93;
		}
		else if(a == 18 && b == 76)
		{
			return 94;
		}
		else if(a == 18 && b == 77)
		{
			return 95;
		}
		else if(a == 18 && b == 78)
		{
			return 96;
		}
		else if(a == 18 && b == 79)
		{
			return 97;
		}
		else if(a == 18 && b == 80)
		{
			return 98;
		}
		else if(a == 18 && b == 81)
		{
			return 99;
		}
		else if(a == 18 && b == 82)
		{
			return 100;
		}
		else if(a == 18 && b == 83)
		{
			return 101;
		}
		else if(a == 18 && b == 84)
		{
			return 102;
		}
		else if(a == 18 && b == 85)
		{
			return 103;
		}
		else if(a == 18 && b == 86)
		{
			return 104;
		}
		else if(a == 18 && b == 87)
		{
			return 105;
		}
		else if(a == 18 && b == 88)
		{
			return 106;
		}
		else if(a == 18 && b == 89)
		{
			return 107;
		}
		else if(a == 18 && b == 90)
		{
			return 108;
		}
		else if(a == 18 && b == 91)
		{
			return 109;
		}
		else if(a == 18 && b == 92)
		{
			return 110;
		}
		else if(a == 18 && b == 93)
		{
			return 111;
		}
		else if(a == 18 && b == 94)
		{
			return 112;
		}
		else if(a == 18 && b == 95)
		{
			return 113;
		}
		else if(a == 18 && b == 96)
		{
			return 114;
		}
		else if(a == 18 && b == 97)
		{
			return 115;
		}
		else if(a == 18 && b == 98)
		{
			return 116;
		}
		else if(a == 18 && b == 99)
		{
			return 117;
		}
		else if(a == 18 && b == 100)
		{
			return 118;
		}
		else if(a == 19 && b == 0)
		{
			return 19;
		}
		else if(a == 19 && b == 1)
		{
			return 20;
		}
		else if(a == 19 && b == 2)
		{
			return 21;
		}
		else if(a == 19 && b == 3)
		{
			return 22;
		}
		else if(a == 19 && b == 4)
		{
			return 23;
		}
		else if(a == 19 && b == 5)
		{
			return 24;
		}
		else if(a == 19 && b == 6)
		{
			return 25;
		}
		else if(a == 19 && b == 7)
		{
			return 26;
		}
		else if(a == 19 && b == 8)
		{
			return 27;
		}
		else if(a == 19 && b == 9)
		{
			return 28;
		}
		else if(a == 19 && b == 10)
		{
			return 29;
		}
		else if(a == 19 && b == 11)
		{
			return 30;
		}
		else if(a == 19 && b == 12)
		{
			return 31;
		}
		else if(a == 19 && b == 13)
		{
			return 32;
		}
		else if(a == 19 && b == 14)
		{
			return 33;
		}
		else if(a == 19 && b == 15)
		{
			return 34;
		}
		else if(a == 19 && b == 16)
		{
			return 35;
		}
		else if(a == 19 && b == 17)
		{
			return 36;
		}
		else if(a == 19 && b == 18)
		{
			return 37;
		}
		else if(a == 19 && b == 19)
		{
			return 38;
		}
		else if(a == 19 && b == 20)
		{
			return 39;
		}
		else if(a == 19 && b == 21)
		{
			return 40;
		}
		else if(a == 19 && b == 22)
		{
			return 41;
		}
		else if(a == 19 && b == 23)
		{
			return 42;
		}
		else if(a == 19 && b == 24)
		{
			return 43;
		}
		else if(a == 19 && b == 25)
		{
			return 44;
		}
		else if(a == 19 && b == 26)
		{
			return 45;
		}
		else if(a == 19 && b == 27)
		{
			return 46;
		}
		else if(a == 19 && b == 28)
		{
			return 47;
		}
		else if(a == 19 && b == 29)
		{
			return 48;
		}
		else if(a == 19 && b == 30)
		{
			return 49;
		}
		else if(a == 19 && b == 31)
		{
			return 50;
		}
		else if(a == 19 && b == 32)
		{
			return 51;
		}
		else if(a == 19 && b == 33)
		{
			return 52;
		}
		else if(a == 19 && b == 34)
		{
			return 53;
		}
		else if(a == 19 && b == 35)
		{
			return 54;
		}
		else if(a == 19 && b == 36)
		{
			return 55;
		}
		else if(a == 19 && b == 37)
		{
			return 56;
		}
		else if(a == 19 && b == 38)
		{
			return 57;
		}
		else if(a == 19 && b == 39)
		{
			return 58;
		}
		else if(a == 19 && b == 40)
		{
			return 59;
		}
		else if(a == 19 && b == 41)
		{
			return 60;
		}
		else if(a == 19 && b == 42)
		{
			return 61;
		}
		else if(a == 19 && b == 43)
		{
			return 62;
		}
		else if(a == 19 && b == 44)
		{
			return 63;
		}
		else if(a == 19 && b == 45)
		{
			return 64;
		}
		else if(a == 19 && b == 46)
		{
			return 65;
		}
		else if(a == 19 && b == 47)
		{
			return 66;
		}
		else if(a == 19 && b == 48)
		{
			return 67;
		}
		else if(a == 19 && b == 49)
		{
			return 68;
		}
		else if(a == 19 && b == 50)
		{
			return 69;
		}
		else if(a == 19 && b == 51)
		{
			return 70;
		}
		else if(a == 19 && b == 52)
		{
			return 71;
		}
		else if(a == 19 && b == 53)
		{
			return 72;
		}
		else if(a == 19 && b == 54)
		{
			return 73;
		}
		else if(a == 19 && b == 55)
		{
			return 74;
		}
		else if(a == 19 && b == 56)
		{
			return 75;
		}
		else if(a == 19 && b == 57)
		{
			return 76;
		}
		else if(a == 19 && b == 58)
		{
			return 77;
		}
		else if(a == 19 && b == 59)
		{
			return 78;
		}
		else if(a == 19 && b == 60)
		{
			return 79;
		}
		else if(a == 19 && b == 61)
		{
			return 80;
		}
		else if(a == 19 && b == 62)
		{
			return 81;
		}
		else if(a == 19 && b == 63)
		{
			return 82;
		}
		else if(a == 19 && b == 64)
		{
			return 83;
		}
		else if(a == 19 && b == 65)
		{
			return 84;
		}
		else if(a == 19 && b == 66)
		{
			return 85;
		}
		else if(a == 19 && b == 67)
		{
			return 86;
		}
		else if(a == 19 && b == 68)
		{
			return 87;
		}
		else if(a == 19 && b == 69)
		{
			return 88;
		}
		else if(a == 19 && b == 70)
		{
			return 89;
		}
		else if(a == 19 && b == 71)
		{
			return 90;
		}
		else if(a == 19 && b == 72)
		{
			return 91;
		}
		else if(a == 19 && b == 73)
		{
			return 92;
		}
		else if(a == 19 && b == 74)
		{
			return 93;
		}
		else if(a == 19 && b == 75)
		{
			return 94;
		}
		else if(a == 19 && b == 76)
		{
			return 95;
		}
		else if(a == 19 && b == 77)
		{
			return 96;
		}
		else if(a == 19 && b == 78)
		{
			return 97;
		}
		else if(a == 19 && b == 79)
		{
			return 98;
		}
		else if(a == 19 && b == 80)
		{
			return 99;
		}
		else if(a == 19 && b == 81)
		{
			return 100;
		}
		else if(a == 19 && b == 82)
		{
			return 101;
		}
		else if(a == 19 && b == 83)
		{
			return 102;
		}
		else if(a == 19 && b == 84)
		{
			return 103;
		}
		else if(a == 19 && b == 85)
		{
			return 104;
		}
		else if(a == 19 && b == 86)
		{
			return 105;
		}
		else if(a == 19 && b == 87)
		{
			return 106;
		}
		else if(a == 19 && b == 88)
		{
			return 107;
		}
		else if(a == 19 && b == 89)
		{
			return 108;
		}
		else if(a == 19 && b == 90)
		{
			return 109;
		}
		else if(a == 19 && b == 91)
		{
			return 110;
		}
		else if(a == 19 && b == 92)
		{
			return 111;
		}
		else if(a == 19 && b == 93)
		{
			return 112;
		}
		else if(a == 19 && b == 94)
		{
			return 113;
		}
		else if(a == 19 && b == 95)
		{
			return 114;
		}
		else if(a == 19 && b == 96)
		{
			return 115;
		}
		else if(a == 19 && b == 97)
		{
			return 116;
		}
		else if(a == 19 && b == 98)
		{
			return 117;
		}
		else if(a == 19 && b == 99)
		{
			return 118;
		}
		else if(a == 19 && b == 100)
		{
			return 119;
		}
		else if(a == 20 && b == 0)
		{
			return 20;
		}
		else if(a == 20 && b == 1)
		{
			return 21;
		}
		else if(a == 20 && b == 2)
		{
			return 22;
		}
		else if(a == 20 && b == 3)
		{
			return 23;
		}
		else if(a == 20 && b == 4)
		{
			return 24;
		}
		else if(a == 20 && b == 5)
		{
			return 25;
		}
		else if(a == 20 && b == 6)
		{
			return 26;
		}
		else if(a == 20 && b == 7)
		{
			return 27;
		}
		else if(a == 20 && b == 8)
		{
			return 28;
		}
		else if(a == 20 && b == 9)
		{
			return 29;
		}
		else if(a == 20 && b == 10)
		{
			return 30;
		}
		else if(a == 20 && b == 11)
		{
			return 31;
		}
		else if(a == 20 && b == 12)
		{
			return 32;
		}
		else if(a == 20 && b == 13)
		{
			return 33;
		}
		else if(a == 20 && b == 14)
		{
			return 34;
		}
		else if(a == 20 && b == 15)
		{
			return 35;
		}
		else if(a == 20 && b == 16)
		{
			return 36;
		}
		else if(a == 20 && b == 17)
		{
			return 37;
		}
		else if(a == 20 && b == 18)
		{
			return 38;
		}
		else if(a == 20 && b == 19)
		{
			return 39;
		}
		else if(a == 20 && b == 20)
		{
			return 40;
		}
		else if(a == 20 && b == 21)
		{
			return 41;
		}
		else if(a == 20 && b == 22)
		{
			return 42;
		}
		else if(a == 20 && b == 23)
		{
			return 43;
		}
		else if(a == 20 && b == 24)
		{
			return 44;
		}
		else if(a == 20 && b == 25)
		{
			return 45;
		}
		else if(a == 20 && b == 26)
		{
			return 46;
		}
		else if(a == 20 && b == 27)
		{
			return 47;
		}
		else if(a == 20 && b == 28)
		{
			return 48;
		}
		else if(a == 20 && b == 29)
		{
			return 49;
		}
		else if(a == 20 && b == 30)
		{
			return 50;
		}
		else if(a == 20 && b == 31)
		{
			return 51;
		}
		else if(a == 20 && b == 32)
		{
			return 52;
		}
		else if(a == 20 && b == 33)
		{
			return 53;
		}
		else if(a == 20 && b == 34)
		{
			return 54;
		}
		else if(a == 20 && b == 35)
		{
			return 55;
		}
		else if(a == 20 && b == 36)
		{
			return 56;
		}
		else if(a == 20 && b == 37)
		{
			return 57;
		}
		else if(a == 20 && b == 38)
		{
			return 58;
		}
		else if(a == 20 && b == 39)
		{
			return 59;
		}
		else if(a == 20 && b == 40)
		{
			return 60;
		}
		else if(a == 20 && b == 41)
		{
			return 61;
		}
		else if(a == 20 && b == 42)
		{
			return 62;
		}
		else if(a == 20 && b == 43)
		{
			return 63;
		}
		else if(a == 20 && b == 44)
		{
			return 64;
		}
		else if(a == 20 && b == 45)
		{
			return 65;
		}
		else if(a == 20 && b == 46)
		{
			return 66;
		}
		else if(a == 20 && b == 47)
		{
			return 67;
		}
		else if(a == 20 && b == 48)
		{
			return 68;
		}
		else if(a == 20 && b == 49)
		{
			return 69;
		}
		else if(a == 20 && b == 50)
		{
			return 70;
		}
		else if(a == 20 && b == 51)
		{
			return 71;
		}
		else if(a == 20 && b == 52)
		{
			return 72;
		}
		else if(a == 20 && b == 53)
		{
			return 73;
		}
		else if(a == 20 && b == 54)
		{
			return 74;
		}
		else if(a == 20 && b == 55)
		{
			return 75;
		}
		else if(a == 20 && b == 56)
		{
			return 76;
		}
		else if(a == 20 && b == 57)
		{
			return 77;
		}
		else if(a == 20 && b == 58)
		{
			return 78;
		}
		else if(a == 20 && b == 59)
		{
			return 79;
		}
		else if(a == 20 && b == 60)
		{
			return 80;
		}
		else if(a == 20 && b == 61)
		{
			return 81;
		}
		else if(a == 20 && b == 62)
		{
			return 82;
		}
		else if(a == 20 && b == 63)
		{
			return 83;
		}
		else if(a == 20 && b == 64)
		{
			return 84;
		}
		else if(a == 20 && b == 65)
		{
			return 85;
		}
		else if(a == 20 && b == 66)
		{
			return 86;
		}
		else if(a == 20 && b == 67)
		{
			return 87;
		}
		else if(a == 20 && b == 68)
		{
			return 88;
		}
		else if(a == 20 && b == 69)
		{
			return 89;
		}
		else if(a == 20 && b == 70)
		{
			return 90;
		}
		else if(a == 20 && b == 71)
		{
			return 91;
		}
		else if(a == 20 && b == 72)
		{
			return 92;
		}
		else if(a == 20 && b == 73)
		{
			return 93;
		}
		else if(a == 20 && b == 74)
		{
			return 94;
		}
		else if(a == 20 && b == 75)
		{
			return 95;
		}
		else if(a == 20 && b == 76)
		{
			return 96;
		}
		else if(a == 20 && b == 77)
		{
			return 97;
		}
		else if(a == 20 && b == 78)
		{
			return 98;
		}
		else if(a == 20 && b == 79)
		{
			return 99;
		}
		else if(a == 20 && b == 80)
		{
			return 100;
		}
		else if(a == 20 && b == 81)
		{
			return 101;
		}
		else if(a == 20 && b == 82)
		{
			return 102;
		}
		else if(a == 20 && b == 83)
		{
			return 103;
		}
		else if(a == 20 && b == 84)
		{
			return 104;
		}
		else if(a == 20 && b == 85)
		{
			return 105;
		}
		else if(a == 20 && b == 86)
		{
			return 106;
		}
		else if(a == 20 && b == 87)
		{
			return 107;
		}
		else if(a == 20 && b == 88)
		{
			return 108;
		}
		else if(a == 20 && b == 89)
		{
			return 109;
		}
		else if(a == 20 && b == 90)
		{
			return 110;
		}
		else if(a == 20 && b == 91)
		{
			return 111;
		}
		else if(a == 20 && b == 92)
		{
			return 112;
		}
		else if(a == 20 && b == 93)
		{
			return 113;
		}
		else if(a == 20 && b == 94)
		{
			return 114;
		}
		else if(a == 20 && b == 95)
		{
			return 115;
		}
		else if(a == 20 && b == 96)
		{
			return 116;
		}
		else if(a == 20 && b == 97)
		{
			return 117;
		}
		else if(a == 20 && b == 98)
		{
			return 118;
		}
		else if(a == 20 && b == 99)
		{
			return 119;
		}
		else if(a == 20 && b == 100)
		{
			return 120;
		}
		else if(a == 21 && b == 0)
		{
			return 21;
		}
		else if(a == 21 && b == 1)
		{
			return 22;
		}
		else if(a == 21 && b == 2)
		{
			return 23;
		}
		else if(a == 21 && b == 3)
		{
			return 24;
		}
		else if(a == 21 && b == 4)
		{
			return 25;
		}
		else if(a == 21 && b == 5)
		{
			return 26;
		}
		else if(a == 21 && b == 6)
		{
			return 27;
		}
		else if(a == 21 && b == 7)
		{
			return 28;
		}
		else if(a == 21 && b == 8)
		{
			return 29;
		}
		else if(a == 21 && b == 9)
		{
			return 30;
		}
		else if(a == 21 && b == 10)
		{
			return 31;
		}
		else if(a == 21 && b == 11)
		{
			return 32;
		}
		else if(a == 21 && b == 12)
		{
			return 33;
		}
		else if(a == 21 && b == 13)
		{
			return 34;
		}
		else if(a == 21 && b == 14)
		{
			return 35;
		}
		else if(a == 21 && b == 15)
		{
			return 36;
		}
		else if(a == 21 && b == 16)
		{
			return 37;
		}
		else if(a == 21 && b == 17)
		{
			return 38;
		}
		else if(a == 21 && b == 18)
		{
			return 39;
		}
		else if(a == 21 && b == 19)
		{
			return 40;
		}
		else if(a == 21 && b == 20)
		{
			return 41;
		}
		else if(a == 21 && b == 21)
		{
			return 42;
		}
		else if(a == 21 && b == 22)
		{
			return 43;
		}
		else if(a == 21 && b == 23)
		{
			return 44;
		}
		else if(a == 21 && b == 24)
		{
			return 45;
		}
		else if(a == 21 && b == 25)
		{
			return 46;
		}
		else if(a == 21 && b == 26)
		{
			return 47;
		}
		else if(a == 21 && b == 27)
		{
			return 48;
		}
		else if(a == 21 && b == 28)
		{
			return 49;
		}
		else if(a == 21 && b == 29)
		{
			return 50;
		}
		else if(a == 21 && b == 30)
		{
			return 51;
		}
		else if(a == 21 && b == 31)
		{
			return 52;
		}
		else if(a == 21 && b == 32)
		{
			return 53;
		}
		else if(a == 21 && b == 33)
		{
			return 54;
		}
		else if(a == 21 && b == 34)
		{
			return 55;
		}
		else if(a == 21 && b == 35)
		{
			return 56;
		}
		else if(a == 21 && b == 36)
		{
			return 57;
		}
		else if(a == 21 && b == 37)
		{
			return 58;
		}
		else if(a == 21 && b == 38)
		{
			return 59;
		}
		else if(a == 21 && b == 39)
		{
			return 60;
		}
		else if(a == 21 && b == 40)
		{
			return 61;
		}
		else if(a == 21 && b == 41)
		{
			return 62;
		}
		else if(a == 21 && b == 42)
		{
			return 63;
		}
		else if(a == 21 && b == 43)
		{
			return 64;
		}
		else if(a == 21 && b == 44)
		{
			return 65;
		}
		else if(a == 21 && b == 45)
		{
			return 66;
		}
		else if(a == 21 && b == 46)
		{
			return 67;
		}
		else if(a == 21 && b == 47)
		{
			return 68;
		}
		else if(a == 21 && b == 48)
		{
			return 69;
		}
		else if(a == 21 && b == 49)
		{
			return 70;
		}
		else if(a == 21 && b == 50)
		{
			return 71;
		}
		else if(a == 21 && b == 51)
		{
			return 72;
		}
		else if(a == 21 && b == 52)
		{
			return 73;
		}
		else if(a == 21 && b == 53)
		{
			return 74;
		}
		else if(a == 21 && b == 54)
		{
			return 75;
		}
		else if(a == 21 && b == 55)
		{
			return 76;
		}
		else if(a == 21 && b == 56)
		{
			return 77;
		}
		else if(a == 21 && b == 57)
		{
			return 78;
		}
		else if(a == 21 && b == 58)
		{
			return 79;
		}
		else if(a == 21 && b == 59)
		{
			return 80;
		}
		else if(a == 21 && b == 60)
		{
			return 81;
		}
		else if(a == 21 && b == 61)
		{
			return 82;
		}
		else if(a == 21 && b == 62)
		{
			return 83;
		}
		else if(a == 21 && b == 63)
		{
			return 84;
		}
		else if(a == 21 && b == 64)
		{
			return 85;
		}
		else if(a == 21 && b == 65)
		{
			return 86;
		}
		else if(a == 21 && b == 66)
		{
			return 87;
		}
		else if(a == 21 && b == 67)
		{
			return 88;
		}
		else if(a == 21 && b == 68)
		{
			return 89;
		}
		else if(a == 21 && b == 69)
		{
			return 90;
		}
		else if(a == 21 && b == 70)
		{
			return 91;
		}
		else if(a == 21 && b == 71)
		{
			return 92;
		}
		else if(a == 21 && b == 72)
		{
			return 93;
		}
		else if(a == 21 && b == 73)
		{
			return 94;
		}
		else if(a == 21 && b == 74)
		{
			return 95;
		}
		else if(a == 21 && b == 75)
		{
			return 96;
		}
		else if(a == 21 && b == 76)
		{
			return 97;
		}
		else if(a == 21 && b == 77)
		{
			return 98;
		}
		else if(a == 21 && b == 78)
		{
			return 99;
		}
		else if(a == 21 && b == 79)
		{
			return 100;
		}
		else if(a == 21 && b == 80)
		{
			return 101;
		}
		else if(a == 21 && b == 81)
		{
			return 102;
		}
		else if(a == 21 && b == 82)
		{
			return 103;
		}
		else if(a == 21 && b == 83)
		{
			return 104;
		}
		else if(a == 21 && b == 84)
		{
			return 105;
		}
		else if(a == 21 && b == 85)
		{
			return 106;
		}
		else if(a == 21 && b == 86)
		{
			return 107;
		}
		else if(a == 21 && b == 87)
		{
			return 108;
		}
		else if(a == 21 && b == 88)
		{
			return 109;
		}
		else if(a == 21 && b == 89)
		{
			return 110;
		}
		else if(a == 21 && b == 90)
		{
			return 111;
		}
		else if(a == 21 && b == 91)
		{
			return 112;
		}
		else if(a == 21 && b == 92)
		{
			return 113;
		}
		else if(a == 21 && b == 93)
		{
			return 114;
		}
		else if(a == 21 && b == 94)
		{
			return 115;
		}
		else if(a == 21 && b == 95)
		{
			return 116;
		}
		else if(a == 21 && b == 96)
		{
			return 117;
		}
		else if(a == 21 && b == 97)
		{
			return 118;
		}
		else if(a == 21 && b == 98)
		{
			return 119;
		}
		else if(a == 21 && b == 99)
		{
			return 120;
		}
		else if(a == 21 && b == 100)
		{
			return 121;
		}
		else if(a == 22 && b == 0)
		{
			return 22;
		}
		else if(a == 22 && b == 1)
		{
			return 23;
		}
		else if(a == 22 && b == 2)
		{
			return 24;
		}
		else if(a == 22 && b == 3)
		{
			return 25;
		}
		else if(a == 22 && b == 4)
		{
			return 26;
		}
		else if(a == 22 && b == 5)
		{
			return 27;
		}
		else if(a == 22 && b == 6)
		{
			return 28;
		}
		else if(a == 22 && b == 7)
		{
			return 29;
		}
		else if(a == 22 && b == 8)
		{
			return 30;
		}
		else if(a == 22 && b == 9)
		{
			return 31;
		}
		else if(a == 22 && b == 10)
		{
			return 32;
		}
		else if(a == 22 && b == 11)
		{
			return 33;
		}
		else if(a == 22 && b == 12)
		{
			return 34;
		}
		else if(a == 22 && b == 13)
		{
			return 35;
		}
		else if(a == 22 && b == 14)
		{
			return 36;
		}
		else if(a == 22 && b == 15)
		{
			return 37;
		}
		else if(a == 22 && b == 16)
		{
			return 38;
		}
		else if(a == 22 && b == 17)
		{
			return 39;
		}
		else if(a == 22 && b == 18)
		{
			return 40;
		}
		else if(a == 22 && b == 19)
		{
			return 41;
		}
		else if(a == 22 && b == 20)
		{
			return 42;
		}
		else if(a == 22 && b == 21)
		{
			return 43;
		}
		else if(a == 22 && b == 22)
		{
			return 44;
		}
		else if(a == 22 && b == 23)
		{
			return 45;
		}
		else if(a == 22 && b == 24)
		{
			return 46;
		}
		else if(a == 22 && b == 25)
		{
			return 47;
		}
		else if(a == 22 && b == 26)
		{
			return 48;
		}
		else if(a == 22 && b == 27)
		{
			return 49;
		}
		else if(a == 22 && b == 28)
		{
			return 50;
		}
		else if(a == 22 && b == 29)
		{
			return 51;
		}
		else if(a == 22 && b == 30)
		{
			return 52;
		}
		else if(a == 22 && b == 31)
		{
			return 53;
		}
		else if(a == 22 && b == 32)
		{
			return 54;
		}
		else if(a == 22 && b == 33)
		{
			return 55;
		}
		else if(a == 22 && b == 34)
		{
			return 56;
		}
		else if(a == 22 && b == 35)
		{
			return 57;
		}
		else if(a == 22 && b == 36)
		{
			return 58;
		}
		else if(a == 22 && b == 37)
		{
			return 59;
		}
		else if(a == 22 && b == 38)
		{
			return 60;
		}
		else if(a == 22 && b == 39)
		{
			return 61;
		}
		else if(a == 22 && b == 40)
		{
			return 62;
		}
		else if(a == 22 && b == 41)
		{
			return 63;
		}
		else if(a == 22 && b == 42)
		{
			return 64;
		}
		else if(a == 22 && b == 43)
		{
			return 65;
		}
		else if(a == 22 && b == 44)
		{
			return 66;
		}
		else if(a == 22 && b == 45)
		{
			return 67;
		}
		else if(a == 22 && b == 46)
		{
			return 68;
		}
		else if(a == 22 && b == 47)
		{
			return 69;
		}
		else if(a == 22 && b == 48)
		{
			return 70;
		}
		else if(a == 22 && b == 49)
		{
			return 71;
		}
		else if(a == 22 && b == 50)
		{
			return 72;
		}
		else if(a == 22 && b == 51)
		{
			return 73;
		}
		else if(a == 22 && b == 52)
		{
			return 74;
		}
		else if(a == 22 && b == 53)
		{
			return 75;
		}
		else if(a == 22 && b == 54)
		{
			return 76;
		}
		else if(a == 22 && b == 55)
		{
			return 77;
		}
		else if(a == 22 && b == 56)
		{
			return 78;
		}
		else if(a == 22 && b == 57)
		{
			return 79;
		}
		else if(a == 22 && b == 58)
		{
			return 80;
		}
		else if(a == 22 && b == 59)
		{
			return 81;
		}
		else if(a == 22 && b == 60)
		{
			return 82;
		}
		else if(a == 22 && b == 61)
		{
			return 83;
		}
		else if(a == 22 && b == 62)
		{
			return 84;
		}
		else if(a == 22 && b == 63)
		{
			return 85;
		}
		else if(a == 22 && b == 64)
		{
			return 86;
		}
		else if(a == 22 && b == 65)
		{
			return 87;
		}
		else if(a == 22 && b == 66)
		{
			return 88;
		}
		else if(a == 22 && b == 67)
		{
			return 89;
		}
		else if(a == 22 && b == 68)
		{
			return 90;
		}
		else if(a == 22 && b == 69)
		{
			return 91;
		}
		else if(a == 22 && b == 70)
		{
			return 92;
		}
		else if(a == 22 && b == 71)
		{
			return 93;
		}
		else if(a == 22 && b == 72)
		{
			return 94;
		}
		else if(a == 22 && b == 73)
		{
			return 95;
		}
		else if(a == 22 && b == 74)
		{
			return 96;
		}
		else if(a == 22 && b == 75)
		{
			return 97;
		}
		else if(a == 22 && b == 76)
		{
			return 98;
		}
		else if(a == 22 && b == 77)
		{
			return 99;
		}
		else if(a == 22 && b == 78)
		{
			return 100;
		}
		else if(a == 22 && b == 79)
		{
			return 101;
		}
		else if(a == 22 && b == 80)
		{
			return 102;
		}
		else if(a == 22 && b == 81)
		{
			return 103;
		}
		else if(a == 22 && b == 82)
		{
			return 104;
		}
		else if(a == 22 && b == 83)
		{
			return 105;
		}
		else if(a == 22 && b == 84)
		{
			return 106;
		}
		else if(a == 22 && b == 85)
		{
			return 107;
		}
		else if(a == 22 && b == 86)
		{
			return 108;
		}
		else if(a == 22 && b == 87)
		{
			return 109;
		}
		else if(a == 22 && b == 88)
		{
			return 110;
		}
		else if(a == 22 && b == 89)
		{
			return 111;
		}
		else if(a == 22 && b == 90)
		{
			return 112;
		}
		else if(a == 22 && b == 91)
		{
			return 113;
		}
		else if(a == 22 && b == 92)
		{
			return 114;
		}
		else if(a == 22 && b == 93)
		{
			return 115;
		}
		else if(a == 22 && b == 94)
		{
			return 116;
		}
		else if(a == 22 && b == 95)
		{
			return 117;
		}
		else if(a == 22 && b == 96)
		{
			return 118;
		}
		else if(a == 22 && b == 97)
		{
			return 119;
		}
		else if(a == 22 && b == 98)
		{
			return 120;
		}
		else if(a == 22 && b == 99)
		{
			return 121;
		}
		else if(a == 22 && b == 100)
		{
			return 122;
		}
		else if(a == 23 && b == 0)
		{
			return 23;
		}
		else if(a == 23 && b == 1)
		{
			return 24;
		}
		else if(a == 23 && b == 2)
		{
			return 25;
		}
		else if(a == 23 && b == 3)
		{
			return 26;
		}
		else if(a == 23 && b == 4)
		{
			return 27;
		}
		else if(a == 23 && b == 5)
		{
			return 28;
		}
		else if(a == 23 && b == 6)
		{
			return 29;
		}
		else if(a == 23 && b == 7)
		{
			return 30;
		}
		else if(a == 23 && b == 8)
		{
			return 31;
		}
		else if(a == 23 && b == 9)
		{
			return 32;
		}
		else if(a == 23 && b == 10)
		{
			return 33;
		}
		else if(a == 23 && b == 11)
		{
			return 34;
		}
		else if(a == 23 && b == 12)
		{
			return 35;
		}
		else if(a == 23 && b == 13)
		{
			return 36;
		}
		else if(a == 23 && b == 14)
		{
			return 37;
		}
		else if(a == 23 && b == 15)
		{
			return 38;
		}
		else if(a == 23 && b == 16)
		{
			return 39;
		}
		else if(a == 23 && b == 17)
		{
			return 40;
		}
		else if(a == 23 && b == 18)
		{
			return 41;
		}
		else if(a == 23 && b == 19)
		{
			return 42;
		}
		else if(a == 23 && b == 20)
		{
			return 43;
		}
		else if(a == 23 && b == 21)
		{
			return 44;
		}
		else if(a == 23 && b == 22)
		{
			return 45;
		}
		else if(a == 23 && b == 23)
		{
			return 46;
		}
		else if(a == 23 && b == 24)
		{
			return 47;
		}
		else if(a == 23 && b == 25)
		{
			return 48;
		}
		else if(a == 23 && b == 26)
		{
			return 49;
		}
		else if(a == 23 && b == 27)
		{
			return 50;
		}
		else if(a == 23 && b == 28)
		{
			return 51;
		}
		else if(a == 23 && b == 29)
		{
			return 52;
		}
		else if(a == 23 && b == 30)
		{
			return 53;
		}
		else if(a == 23 && b == 31)
		{
			return 54;
		}
		else if(a == 23 && b == 32)
		{
			return 55;
		}
		else if(a == 23 && b == 33)
		{
			return 56;
		}
		else if(a == 23 && b == 34)
		{
			return 57;
		}
		else if(a == 23 && b == 35)
		{
			return 58;
		}
		else if(a == 23 && b == 36)
		{
			return 59;
		}
		else if(a == 23 && b == 37)
		{
			return 60;
		}
		else if(a == 23 && b == 38)
		{
			return 61;
		}
		else if(a == 23 && b == 39)
		{
			return 62;
		}
		else if(a == 23 && b == 40)
		{
			return 63;
		}
		else if(a == 23 && b == 41)
		{
			return 64;
		}
		else if(a == 23 && b == 42)
		{
			return 65;
		}
		else if(a == 23 && b == 43)
		{
			return 66;
		}
		else if(a == 23 && b == 44)
		{
			return 67;
		}
		else if(a == 23 && b == 45)
		{
			return 68;
		}
		else if(a == 23 && b == 46)
		{
			return 69;
		}
		else if(a == 23 && b == 47)
		{
			return 70;
		}
		else if(a == 23 && b == 48)
		{
			return 71;
		}
		else if(a == 23 && b == 49)
		{
			return 72;
		}
		else if(a == 23 && b == 50)
		{
			return 73;
		}
		else if(a == 23 && b == 51)
		{
			return 74;
		}
		else if(a == 23 && b == 52)
		{
			return 75;
		}
		else if(a == 23 && b == 53)
		{
			return 76;
		}
		else if(a == 23 && b == 54)
		{
			return 77;
		}
		else if(a == 23 && b == 55)
		{
			return 78;
		}
		else if(a == 23 && b == 56)
		{
			return 79;
		}
		else if(a == 23 && b == 57)
		{
			return 80;
		}
		else if(a == 23 && b == 58)
		{
			return 81;
		}
		else if(a == 23 && b == 59)
		{
			return 82;
		}
		else if(a == 23 && b == 60)
		{
			return 83;
		}
		else if(a == 23 && b == 61)
		{
			return 84;
		}
		else if(a == 23 && b == 62)
		{
			return 85;
		}
		else if(a == 23 && b == 63)
		{
			return 86;
		}
		else if(a == 23 && b == 64)
		{
			return 87;
		}
		else if(a == 23 && b == 65)
		{
			return 88;
		}
		else if(a == 23 && b == 66)
		{
			return 89;
		}
		else if(a == 23 && b == 67)
		{
			return 90;
		}
		else if(a == 23 && b == 68)
		{
			return 91;
		}
		else if(a == 23 && b == 69)
		{
			return 92;
		}
		else if(a == 23 && b == 70)
		{
			return 93;
		}
		else if(a == 23 && b == 71)
		{
			return 94;
		}
		else if(a == 23 && b == 72)
		{
			return 95;
		}
		else if(a == 23 && b == 73)
		{
			return 96;
		}
		else if(a == 23 && b == 74)
		{
			return 97;
		}
		else if(a == 23 && b == 75)
		{
			return 98;
		}
		else if(a == 23 && b == 76)
		{
			return 99;
		}
		else if(a == 23 && b == 77)
		{
			return 100;
		}
		else if(a == 23 && b == 78)
		{
			return 101;
		}
		else if(a == 23 && b == 79)
		{
			return 102;
		}
		else if(a == 23 && b == 80)
		{
			return 103;
		}
		else if(a == 23 && b == 81)
		{
			return 104;
		}
		else if(a == 23 && b == 82)
		{
			return 105;
		}
		else if(a == 23 && b == 83)
		{
			return 106;
		}
		else if(a == 23 && b == 84)
		{
			return 107;
		}
		else if(a == 23 && b == 85)
		{
			return 108;
		}
		else if(a == 23 && b == 86)
		{
			return 109;
		}
		else if(a == 23 && b == 87)
		{
			return 110;
		}
		else if(a == 23 && b == 88)
		{
			return 111;
		}
		else if(a == 23 && b == 89)
		{
			return 112;
		}
		else if(a == 23 && b == 90)
		{
			return 113;
		}
		else if(a == 23 && b == 91)
		{
			return 114;
		}
		else if(a == 23 && b == 92)
		{
			return 115;
		}
		else if(a == 23 && b == 93)
		{
			return 116;
		}
		else if(a == 23 && b == 94)
		{
			return 117;
		}
		else if(a == 23 && b == 95)
		{
			return 118;
		}
		else if(a == 23 && b == 96)
		{
			return 119;
		}
		else if(a == 23 && b == 97)
		{
			return 120;
		}
		else if(a == 23 && b == 98)
		{
			return 121;
		}
		else if(a == 23 && b == 99)
		{
			return 122;
		}
		else if(a == 23 && b == 100)
		{
			return 123;
		}
		else if(a == 24 && b == 0)
		{
			return 24;
		}
		else if(a == 24 && b == 1)
		{
			return 25;
		}
		else if(a == 24 && b == 2)
		{
			return 26;
		}
		else if(a == 24 && b == 3)
		{
			return 27;
		}
		else if(a == 24 && b == 4)
		{
			return 28;
		}
		else if(a == 24 && b == 5)
		{
			return 29;
		}
		else if(a == 24 && b == 6)
		{
			return 30;
		}
		else if(a == 24 && b == 7)
		{
			return 31;
		}
		else if(a == 24 && b == 8)
		{
			return 32;
		}
		else if(a == 24 && b == 9)
		{
			return 33;
		}
		else if(a == 24 && b == 10)
		{
			return 34;
		}
		else if(a == 24 && b == 11)
		{
			return 35;
		}
		else if(a == 24 && b == 12)
		{
			return 36;
		}
		else if(a == 24 && b == 13)
		{
			return 37;
		}
		else if(a == 24 && b == 14)
		{
			return 38;
		}
		else if(a == 24 && b == 15)
		{
			return 39;
		}
		else if(a == 24 && b == 16)
		{
			return 40;
		}
		else if(a == 24 && b == 17)
		{
			return 41;
		}
		else if(a == 24 && b == 18)
		{
			return 42;
		}
		else if(a == 24 && b == 19)
		{
			return 43;
		}
		else if(a == 24 && b == 20)
		{
			return 44;
		}
		else if(a == 24 && b == 21)
		{
			return 45;
		}
		else if(a == 24 && b == 22)
		{
			return 46;
		}
		else if(a == 24 && b == 23)
		{
			return 47;
		}
		else if(a == 24 && b == 24)
		{
			return 48;
		}
		else if(a == 24 && b == 25)
		{
			return 49;
		}
		else if(a == 24 && b == 26)
		{
			return 50;
		}
		else if(a == 24 && b == 27)
		{
			return 51;
		}
		else if(a == 24 && b == 28)
		{
			return 52;
		}
		else if(a == 24 && b == 29)
		{
			return 53;
		}
		else if(a == 24 && b == 30)
		{
			return 54;
		}
		else if(a == 24 && b == 31)
		{
			return 55;
		}
		else if(a == 24 && b == 32)
		{
			return 56;
		}
		else if(a == 24 && b == 33)
		{
			return 57;
		}
		else if(a == 24 && b == 34)
		{
			return 58;
		}
		else if(a == 24 && b == 35)
		{
			return 59;
		}
		else if(a == 24 && b == 36)
		{
			return 60;
		}
		else if(a == 24 && b == 37)
		{
			return 61;
		}
		else if(a == 24 && b == 38)
		{
			return 62;
		}
		else if(a == 24 && b == 39)
		{
			return 63;
		}
		else if(a == 24 && b == 40)
		{
			return 64;
		}
		else if(a == 24 && b == 41)
		{
			return 65;
		}
		else if(a == 24 && b == 42)
		{
			return 66;
		}
		else if(a == 24 && b == 43)
		{
			return 67;
		}
		else if(a == 24 && b == 44)
		{
			return 68;
		}
		else if(a == 24 && b == 45)
		{
			return 69;
		}
		else if(a == 24 && b == 46)
		{
			return 70;
		}
		else if(a == 24 && b == 47)
		{
			return 71;
		}
		else if(a == 24 && b == 48)
		{
			return 72;
		}
		else if(a == 24 && b == 49)
		{
			return 73;
		}
		else if(a == 24 && b == 50)
		{
			return 74;
		}
		else if(a == 24 && b == 51)
		{
			return 75;
		}
		else if(a == 24 && b == 52)
		{
			return 76;
		}
		else if(a == 24 && b == 53)
		{
			return 77;
		}
		else if(a == 24 && b == 54)
		{
			return 78;
		}
		else if(a == 24 && b == 55)
		{
			return 79;
		}
		else if(a == 24 && b == 56)
		{
			return 80;
		}
		else if(a == 24 && b == 57)
		{
			return 81;
		}
		else if(a == 24 && b == 58)
		{
			return 82;
		}
		else if(a == 24 && b == 59)
		{
			return 83;
		}
		else if(a == 24 && b == 60)
		{
			return 84;
		}
		else if(a == 24 && b == 61)
		{
			return 85;
		}
		else if(a == 24 && b == 62)
		{
			return 86;
		}
		else if(a == 24 && b == 63)
		{
			return 87;
		}
		else if(a == 24 && b == 64)
		{
			return 88;
		}
		else if(a == 24 && b == 65)
		{
			return 89;
		}
		else if(a == 24 && b == 66)
		{
			return 90;
		}
		else if(a == 24 && b == 67)
		{
			return 91;
		}
		else if(a == 24 && b == 68)
		{
			return 92;
		}
		else if(a == 24 && b == 69)
		{
			return 93;
		}
		else if(a == 24 && b == 70)
		{
			return 94;
		}
		else if(a == 24 && b == 71)
		{
			return 95;
		}
		else if(a == 24 && b == 72)
		{
			return 96;
		}
		else if(a == 24 && b == 73)
		{
			return 97;
		}
		else if(a == 24 && b == 74)
		{
			return 98;
		}
		else if(a == 24 && b == 75)
		{
			return 99;
		}
		else if(a == 24 && b == 76)
		{
			return 100;
		}
		else if(a == 24 && b == 77)
		{
			return 101;
		}
		else if(a == 24 && b == 78)
		{
			return 102;
		}
		else if(a == 24 && b == 79)
		{
			return 103;
		}
		else if(a == 24 && b == 80)
		{
			return 104;
		}
		else if(a == 24 && b == 81)
		{
			return 105;
		}
		else if(a == 24 && b == 82)
		{
			return 106;
		}
		else if(a == 24 && b == 83)
		{
			return 107;
		}
		else if(a == 24 && b == 84)
		{
			return 108;
		}
		else if(a == 24 && b == 85)
		{
			return 109;
		}
		else if(a == 24 && b == 86)
		{
			return 110;
		}
		else if(a == 24 && b == 87)
		{
			return 111;
		}
		else if(a == 24 && b == 88)
		{
			return 112;
		}
		else if(a == 24 && b == 89)
		{
			return 113;
		}
		else if(a == 24 && b == 90)
		{
			return 114;
		}
		else if(a == 24 && b == 91)
		{
			return 115;
		}
		else if(a == 24 && b == 92)
		{
			return 116;
		}
		else if(a == 24 && b == 93)
		{
			return 117;
		}
		else if(a == 24 && b == 94)
		{
			return 118;
		}
		else if(a == 24 && b == 95)
		{
			return 119;
		}
		else if(a == 24 && b == 96)
		{
			return 120;
		}
		else if(a == 24 && b == 97)
		{
			return 121;
		}
		else if(a == 24 && b == 98)
		{
			return 122;
		}
		else if(a == 24 && b == 99)
		{
			return 123;
		}
		else if(a == 24 && b == 100)
		{
			return 124;
		}
		else if(a == 25 && b == 0)
		{
			return 25;
		}
		else if(a == 25 && b == 1)
		{
			return 26;
		}
		else if(a == 25 && b == 2)
		{
			return 27;
		}
		else if(a == 25 && b == 3)
		{
			return 28;
		}
		else if(a == 25 && b == 4)
		{
			return 29;
		}
		else if(a == 25 && b == 5)
		{
			return 30;
		}
		else if(a == 25 && b == 6)
		{
			return 31;
		}
		else if(a == 25 && b == 7)
		{
			return 32;
		}
		else if(a == 25 && b == 8)
		{
			return 33;
		}
		else if(a == 25 && b == 9)
		{
			return 34;
		}
		else if(a == 25 && b == 10)
		{
			return 35;
		}
		else if(a == 25 && b == 11)
		{
			return 36;
		}
		else if(a == 25 && b == 12)
		{
			return 37;
		}
		else if(a == 25 && b == 13)
		{
			return 38;
		}
		else if(a == 25 && b == 14)
		{
			return 39;
		}
		else if(a == 25 && b == 15)
		{
			return 40;
		}
		else if(a == 25 && b == 16)
		{
			return 41;
		}
		else if(a == 25 && b == 17)
		{
			return 42;
		}
		else if(a == 25 && b == 18)
		{
			return 43;
		}
		else if(a == 25 && b == 19)
		{
			return 44;
		}
		else if(a == 25 && b == 20)
		{
			return 45;
		}
		else if(a == 25 && b == 21)
		{
			return 46;
		}
		else if(a == 25 && b == 22)
		{
			return 47;
		}
		else if(a == 25 && b == 23)
		{
			return 48;
		}
		else if(a == 25 && b == 24)
		{
			return 49;
		}
		else if(a == 25 && b == 25)
		{
			return 50;
		}
		else if(a == 25 && b == 26)
		{
			return 51;
		}
		else if(a == 25 && b == 27)
		{
			return 52;
		}
		else if(a == 25 && b == 28)
		{
			return 53;
		}
		else if(a == 25 && b == 29)
		{
			return 54;
		}
		else if(a == 25 && b == 30)
		{
			return 55;
		}
		else if(a == 25 && b == 31)
		{
			return 56;
		}
		else if(a == 25 && b == 32)
		{
			return 57;
		}
		else if(a == 25 && b == 33)
		{
			return 58;
		}
		else if(a == 25 && b == 34)
		{
			return 59;
		}
		else if(a == 25 && b == 35)
		{
			return 60;
		}
		else if(a == 25 && b == 36)
		{
			return 61;
		}
		else if(a == 25 && b == 37)
		{
			return 62;
		}
		else if(a == 25 && b == 38)
		{
			return 63;
		}
		else if(a == 25 && b == 39)
		{
			return 64;
		}
		else if(a == 25 && b == 40)
		{
			return 65;
		}
		else if(a == 25 && b == 41)
		{
			return 66;
		}
		else if(a == 25 && b == 42)
		{
			return 67;
		}
		else if(a == 25 && b == 43)
		{
			return 68;
		}
		else if(a == 25 && b == 44)
		{
			return 69;
		}
		else if(a == 25 && b == 45)
		{
			return 70;
		}
		else if(a == 25 && b == 46)
		{
			return 71;
		}
		else if(a == 25 && b == 47)
		{
			return 72;
		}
		else if(a == 25 && b == 48)
		{
			return 73;
		}
		else if(a == 25 && b == 49)
		{
			return 74;
		}
		else if(a == 25 && b == 50)
		{
			return 75;
		}
		else if(a == 25 && b == 51)
		{
			return 76;
		}
		else if(a == 25 && b == 52)
		{
			return 77;
		}
		else if(a == 25 && b == 53)
		{
			return 78;
		}
		else if(a == 25 && b == 54)
		{
			return 79;
		}
		else if(a == 25 && b == 55)
		{
			return 80;
		}
		else if(a == 25 && b == 56)
		{
			return 81;
		}
		else if(a == 25 && b == 57)
		{
			return 82;
		}
		else if(a == 25 && b == 58)
		{
			return 83;
		}
		else if(a == 25 && b == 59)
		{
			return 84;
		}
		else if(a == 25 && b == 60)
		{
			return 85;
		}
		else if(a == 25 && b == 61)
		{
			return 86;
		}
		else if(a == 25 && b == 62)
		{
			return 87;
		}
		else if(a == 25 && b == 63)
		{
			return 88;
		}
		else if(a == 25 && b == 64)
		{
			return 89;
		}
		else if(a == 25 && b == 65)
		{
			return 90;
		}
		else if(a == 25 && b == 66)
		{
			return 91;
		}
		else if(a == 25 && b == 67)
		{
			return 92;
		}
		else if(a == 25 && b == 68)
		{
			return 93;
		}
		else if(a == 25 && b == 69)
		{
			return 94;
		}
		else if(a == 25 && b == 70)
		{
			return 95;
		}
		else if(a == 25 && b == 71)
		{
			return 96;
		}
		else if(a == 25 && b == 72)
		{
			return 97;
		}
		else if(a == 25 && b == 73)
		{
			return 98;
		}
		else if(a == 25 && b == 74)
		{
			return 99;
		}
		else if(a == 25 && b == 75)
		{
			return 100;
		}
		else if(a == 25 && b == 76)
		{
			return 101;
		}
		else if(a == 25 && b == 77)
		{
			return 102;
		}
		else if(a == 25 && b == 78)
		{
			return 103;
		}
		else if(a == 25 && b == 79)
		{
			return 104;
		}
		else if(a == 25 && b == 80)
		{
			return 105;
		}
		else if(a == 25 && b == 81)
		{
			return 106;
		}
		else if(a == 25 && b == 82)
		{
			return 107;
		}
		else if(a == 25 && b == 83)
		{
			return 108;
		}
		else if(a == 25 && b == 84)
		{
			return 109;
		}
		else if(a == 25 && b == 85)
		{
			return 110;
		}
		else if(a == 25 && b == 86)
		{
			return 111;
		}
		else if(a == 25 && b == 87)
		{
			return 112;
		}
		else if(a == 25 && b == 88)
		{
			return 113;
		}
		else if(a == 25 && b == 89)
		{
			return 114;
		}
		else if(a == 25 && b == 90)
		{
			return 115;
		}
		else if(a == 25 && b == 91)
		{
			return 116;
		}
		else if(a == 25 && b == 92)
		{
			return 117;
		}
		else if(a == 25 && b == 93)
		{
			return 118;
		}
		else if(a == 25 && b == 94)
		{
			return 119;
		}
		else if(a == 25 && b == 95)
		{
			return 120;
		}
		else if(a == 25 && b == 96)
		{
			return 121;
		}
		else if(a == 25 && b == 97)
		{
			return 122;
		}
		else if(a == 25 && b == 98)
		{
			return 123;
		}
		else if(a == 25 && b == 99)
		{
			return 124;
		}
		else if(a == 25 && b == 100)
		{
			return 125;
		}
		else if(a == 26 && b == 0)
		{
			return 26;
		}
		else if(a == 26 && b == 1)
		{
			return 27;
		}
		else if(a == 26 && b == 2)
		{
			return 28;
		}
		else if(a == 26 && b == 3)
		{
			return 29;
		}
		else if(a == 26 && b == 4)
		{
			return 30;
		}
		else if(a == 26 && b == 5)
		{
			return 31;
		}
		else if(a == 26 && b == 6)
		{
			return 32;
		}
		else if(a == 26 && b == 7)
		{
			return 33;
		}
		else if(a == 26 && b == 8)
		{
			return 34;
		}
		else if(a == 26 && b == 9)
		{
			return 35;
		}
		else if(a == 26 && b == 10)
		{
			return 36;
		}
		else if(a == 26 && b == 11)
		{
			return 37;
		}
		else if(a == 26 && b == 12)
		{
			return 38;
		}
		else if(a == 26 && b == 13)
		{
			return 39;
		}
		else if(a == 26 && b == 14)
		{
			return 40;
		}
		else if(a == 26 && b == 15)
		{
			return 41;
		}
		else if(a == 26 && b == 16)
		{
			return 42;
		}
		else if(a == 26 && b == 17)
		{
			return 43;
		}
		else if(a == 26 && b == 18)
		{
			return 44;
		}
		else if(a == 26 && b == 19)
		{
			return 45;
		}
		else if(a == 26 && b == 20)
		{
			return 46;
		}
		else if(a == 26 && b == 21)
		{
			return 47;
		}
		else if(a == 26 && b == 22)
		{
			return 48;
		}
		else if(a == 26 && b == 23)
		{
			return 49;
		}
		else if(a == 26 && b == 24)
		{
			return 50;
		}
		else if(a == 26 && b == 25)
		{
			return 51;
		}
		else if(a == 26 && b == 26)
		{
			return 52;
		}
		else if(a == 26 && b == 27)
		{
			return 53;
		}
		else if(a == 26 && b == 28)
		{
			return 54;
		}
		else if(a == 26 && b == 29)
		{
			return 55;
		}
		else if(a == 26 && b == 30)
		{
			return 56;
		}
		else if(a == 26 && b == 31)
		{
			return 57;
		}
		else if(a == 26 && b == 32)
		{
			return 58;
		}
		else if(a == 26 && b == 33)
		{
			return 59;
		}
		else if(a == 26 && b == 34)
		{
			return 60;
		}
		else if(a == 26 && b == 35)
		{
			return 61;
		}
		else if(a == 26 && b == 36)
		{
			return 62;
		}
		else if(a == 26 && b == 37)
		{
			return 63;
		}
		else if(a == 26 && b == 38)
		{
			return 64;
		}
		else if(a == 26 && b == 39)
		{
			return 65;
		}
		else if(a == 26 && b == 40)
		{
			return 66;
		}
		else if(a == 26 && b == 41)
		{
			return 67;
		}
		else if(a == 26 && b == 42)
		{
			return 68;
		}
		else if(a == 26 && b == 43)
		{
			return 69;
		}
		else if(a == 26 && b == 44)
		{
			return 70;
		}
		else if(a == 26 && b == 45)
		{
			return 71;
		}
		else if(a == 26 && b == 46)
		{
			return 72;
		}
		else if(a == 26 && b == 47)
		{
			return 73;
		}
		else if(a == 26 && b == 48)
		{
			return 74;
		}
		else if(a == 26 && b == 49)
		{
			return 75;
		}
		else if(a == 26 && b == 50)
		{
			return 76;
		}
		else if(a == 26 && b == 51)
		{
			return 77;
		}
		else if(a == 26 && b == 52)
		{
			return 78;
		}
		else if(a == 26 && b == 53)
		{
			return 79;
		}
		else if(a == 26 && b == 54)
		{
			return 80;
		}
		else if(a == 26 && b == 55)
		{
			return 81;
		}
		else if(a == 26 && b == 56)
		{
			return 82;
		}
		else if(a == 26 && b == 57)
		{
			return 83;
		}
		else if(a == 26 && b == 58)
		{
			return 84;
		}
		else if(a == 26 && b == 59)
		{
			return 85;
		}
		else if(a == 26 && b == 60)
		{
			return 86;
		}
		else if(a == 26 && b == 61)
		{
			return 87;
		}
		else if(a == 26 && b == 62)
		{
			return 88;
		}
		else if(a == 26 && b == 63)
		{
			return 89;
		}
		else if(a == 26 && b == 64)
		{
			return 90;
		}
		else if(a == 26 && b == 65)
		{
			return 91;
		}
		else if(a == 26 && b == 66)
		{
			return 92;
		}
		else if(a == 26 && b == 67)
		{
			return 93;
		}
		else if(a == 26 && b == 68)
		{
			return 94;
		}
		else if(a == 26 && b == 69)
		{
			return 95;
		}
		else if(a == 26 && b == 70)
		{
			return 96;
		}
		else if(a == 26 && b == 71)
		{
			return 97;
		}
		else if(a == 26 && b == 72)
		{
			return 98;
		}
		else if(a == 26 && b == 73)
		{
			return 99;
		}
		else if(a == 26 && b == 74)
		{
			return 100;
		}
		else if(a == 26 && b == 75)
		{
			return 101;
		}
		else if(a == 26 && b == 76)
		{
			return 102;
		}
		else if(a == 26 && b == 77)
		{
			return 103;
		}
		else if(a == 26 && b == 78)
		{
			return 104;
		}
		else if(a == 26 && b == 79)
		{
			return 105;
		}
		else if(a == 26 && b == 80)
		{
			return 106;
		}
		else if(a == 26 && b == 81)
		{
			return 107;
		}
		else if(a == 26 && b == 82)
		{
			return 108;
		}
		else if(a == 26 && b == 83)
		{
			return 109;
		}
		else if(a == 26 && b == 84)
		{
			return 110;
		}
		else if(a == 26 && b == 85)
		{
			return 111;
		}
		else if(a == 26 && b == 86)
		{
			return 112;
		}
		else if(a == 26 && b == 87)
		{
			return 113;
		}
		else if(a == 26 && b == 88)
		{
			return 114;
		}
		else if(a == 26 && b == 89)
		{
			return 115;
		}
		else if(a == 26 && b == 90)
		{
			return 116;
		}
		else if(a == 26 && b == 91)
		{
			return 117;
		}
		else if(a == 26 && b == 92)
		{
			return 118;
		}
		else if(a == 26 && b == 93)
		{
			return 119;
		}
		else if(a == 26 && b == 94)
		{
			return 120;
		}
		else if(a == 26 && b == 95)
		{
			return 121;
		}
		else if(a == 26 && b == 96)
		{
			return 122;
		}
		else if(a == 26 && b == 97)
		{
			return 123;
		}
		else if(a == 26 && b == 98)
		{
			return 124;
		}
		else if(a == 26 && b == 99)
		{
			return 125;
		}
		else if(a == 26 && b == 100)
		{
			return 126;
		}
		else if(a == 27 && b == 0)
		{
			return 27;
		}
		else if(a == 27 && b == 1)
		{
			return 28;
		}
		else if(a == 27 && b == 2)
		{
			return 29;
		}
		else if(a == 27 && b == 3)
		{
			return 30;
		}
		else if(a == 27 && b == 4)
		{
			return 31;
		}
		else if(a == 27 && b == 5)
		{
			return 32;
		}
		else if(a == 27 && b == 6)
		{
			return 33;
		}
		else if(a == 27 && b == 7)
		{
			return 34;
		}
		else if(a == 27 && b == 8)
		{
			return 35;
		}
		else if(a == 27 && b == 9)
		{
			return 36;
		}
		else if(a == 27 && b == 10)
		{
			return 37;
		}
		else if(a == 27 && b == 11)
		{
			return 38;
		}
		else if(a == 27 && b == 12)
		{
			return 39;
		}
		else if(a == 27 && b == 13)
		{
			return 40;
		}
		else if(a == 27 && b == 14)
		{
			return 41;
		}
		else if(a == 27 && b == 15)
		{
			return 42;
		}
		else if(a == 27 && b == 16)
		{
			return 43;
		}
		else if(a == 27 && b == 17)
		{
			return 44;
		}
		else if(a == 27 && b == 18)
		{
			return 45;
		}
		else if(a == 27 && b == 19)
		{
			return 46;
		}
		else if(a == 27 && b == 20)
		{
			return 47;
		}
		else if(a == 27 && b == 21)
		{
			return 48;
		}
		else if(a == 27 && b == 22)
		{
			return 49;
		}
		else if(a == 27 && b == 23)
		{
			return 50;
		}
		else if(a == 27 && b == 24)
		{
			return 51;
		}
		else if(a == 27 && b == 25)
		{
			return 52;
		}
		else if(a == 27 && b == 26)
		{
			return 53;
		}
		else if(a == 27 && b == 27)
		{
			return 54;
		}
		else if(a == 27 && b == 28)
		{
			return 55;
		}
		else if(a == 27 && b == 29)
		{
			return 56;
		}
		else if(a == 27 && b == 30)
		{
			return 57;
		}
		else if(a == 27 && b == 31)
		{
			return 58;
		}
		else if(a == 27 && b == 32)
		{
			return 59;
		}
		else if(a == 27 && b == 33)
		{
			return 60;
		}
		else if(a == 27 && b == 34)
		{
			return 61;
		}
		else if(a == 27 && b == 35)
		{
			return 62;
		}
		else if(a == 27 && b == 36)
		{
			return 63;
		}
		else if(a == 27 && b == 37)
		{
			return 64;
		}
		else if(a == 27 && b == 38)
		{
			return 65;
		}
		else if(a == 27 && b == 39)
		{
			return 66;
		}
		else if(a == 27 && b == 40)
		{
			return 67;
		}
		else if(a == 27 && b == 41)
		{
			return 68;
		}
		else if(a == 27 && b == 42)
		{
			return 69;
		}
		else if(a == 27 && b == 43)
		{
			return 70;
		}
		else if(a == 27 && b == 44)
		{
			return 71;
		}
		else if(a == 27 && b == 45)
		{
			return 72;
		}
		else if(a == 27 && b == 46)
		{
			return 73;
		}
		else if(a == 27 && b == 47)
		{
			return 74;
		}
		else if(a == 27 && b == 48)
		{
			return 75;
		}
		else if(a == 27 && b == 49)
		{
			return 76;
		}
		else if(a == 27 && b == 50)
		{
			return 77;
		}
		else if(a == 27 && b == 51)
		{
			return 78;
		}
		else if(a == 27 && b == 52)
		{
			return 79;
		}
		else if(a == 27 && b == 53)
		{
			return 80;
		}
		else if(a == 27 && b == 54)
		{
			return 81;
		}
		else if(a == 27 && b == 55)
		{
			return 82;
		}
		else if(a == 27 && b == 56)
		{
			return 83;
		}
		else if(a == 27 && b == 57)
		{
			return 84;
		}
		else if(a == 27 && b == 58)
		{
			return 85;
		}
		else if(a == 27 && b == 59)
		{
			return 86;
		}
		else if(a == 27 && b == 60)
		{
			return 87;
		}
		else if(a == 27 && b == 61)
		{
			return 88;
		}
		else if(a == 27 && b == 62)
		{
			return 89;
		}
		else if(a == 27 && b == 63)
		{
			return 90;
		}
		else if(a == 27 && b == 64)
		{
			return 91;
		}
		else if(a == 27 && b == 65)
		{
			return 92;
		}
		else if(a == 27 && b == 66)
		{
			return 93;
		}
		else if(a == 27 && b == 67)
		{
			return 94;
		}
		else if(a == 27 && b == 68)
		{
			return 95;
		}
		else if(a == 27 && b == 69)
		{
			return 96;
		}
		else if(a == 27 && b == 70)
		{
			return 97;
		}
		else if(a == 27 && b == 71)
		{
			return 98;
		}
		else if(a == 27 && b == 72)
		{
			return 99;
		}
		else if(a == 27 && b == 73)
		{
			return 100;
		}
		else if(a == 27 && b == 74)
		{
			return 101;
		}
		else if(a == 27 && b == 75)
		{
			return 102;
		}
		else if(a == 27 && b == 76)
		{
			return 103;
		}
		else if(a == 27 && b == 77)
		{
			return 104;
		}
		else if(a == 27 && b == 78)
		{
			return 105;
		}
		else if(a == 27 && b == 79)
		{
			return 106;
		}
		else if(a == 27 && b == 80)
		{
			return 107;
		}
		else if(a == 27 && b == 81)
		{
			return 108;
		}
		else if(a == 27 && b == 82)
		{
			return 109;
		}
		else if(a == 27 && b == 83)
		{
			return 110;
		}
		else if(a == 27 && b == 84)
		{
			return 111;
		}
		else if(a == 27 && b == 85)
		{
			return 112;
		}
		else if(a == 27 && b == 86)
		{
			return 113;
		}
		else if(a == 27 && b == 87)
		{
			return 114;
		}
		else if(a == 27 && b == 88)
		{
			return 115;
		}
		else if(a == 27 && b == 89)
		{
			return 116;
		}
		else if(a == 27 && b == 90)
		{
			return 117;
		}
		else if(a == 27 && b == 91)
		{
			return 118;
		}
		else if(a == 27 && b == 92)
		{
			return 119;
		}
		else if(a == 27 && b == 93)
		{
			return 120;
		}
		else if(a == 27 && b == 94)
		{
			return 121;
		}
		else if(a == 27 && b == 95)
		{
			return 122;
		}
		else if(a == 27 && b == 96)
		{
			return 123;
		}
		else if(a == 27 && b == 97)
		{
			return 124;
		}
		else if(a == 27 && b == 98)
		{
			return 125;
		}
		else if(a == 27 && b == 99)
		{
			return 126;
		}
		else if(a == 27 && b == 100)
		{
			return 127;
		}
		else if(a == 28 && b == 0)
		{
			return 28;
		}
		else if(a == 28 && b == 1)
		{
			return 29;
		}
		else if(a == 28 && b == 2)
		{
			return 30;
		}
		else if(a == 28 && b == 3)
		{
			return 31;
		}
		else if(a == 28 && b == 4)
		{
			return 32;
		}
		else if(a == 28 && b == 5)
		{
			return 33;
		}
		else if(a == 28 && b == 6)
		{
			return 34;
		}
		else if(a == 28 && b == 7)
		{
			return 35;
		}
		else if(a == 28 && b == 8)
		{
			return 36;
		}
		else if(a == 28 && b == 9)
		{
			return 37;
		}
		else if(a == 28 && b == 10)
		{
			return 38;
		}
		else if(a == 28 && b == 11)
		{
			return 39;
		}
		else if(a == 28 && b == 12)
		{
			return 40;
		}
		else if(a == 28 && b == 13)
		{
			return 41;
		}
		else if(a == 28 && b == 14)
		{
			return 42;
		}
		else if(a == 28 && b == 15)
		{
			return 43;
		}
		else if(a == 28 && b == 16)
		{
			return 44;
		}
		else if(a == 28 && b == 17)
		{
			return 45;
		}
		else if(a == 28 && b == 18)
		{
			return 46;
		}
		else if(a == 28 && b == 19)
		{
			return 47;
		}
		else if(a == 28 && b == 20)
		{
			return 48;
		}
		else if(a == 28 && b == 21)
		{
			return 49;
		}
		else if(a == 28 && b == 22)
		{
			return 50;
		}
		else if(a == 28 && b == 23)
		{
			return 51;
		}
		else if(a == 28 && b == 24)
		{
			return 52;
		}
		else if(a == 28 && b == 25)
		{
			return 53;
		}
		else if(a == 28 && b == 26)
		{
			return 54;
		}
		else if(a == 28 && b == 27)
		{
			return 55;
		}
		else if(a == 28 && b == 28)
		{
			return 56;
		}
		else if(a == 28 && b == 29)
		{
			return 57;
		}
		else if(a == 28 && b == 30)
		{
			return 58;
		}
		else if(a == 28 && b == 31)
		{
			return 59;
		}
		else if(a == 28 && b == 32)
		{
			return 60;
		}
		else if(a == 28 && b == 33)
		{
			return 61;
		}
		else if(a == 28 && b == 34)
		{
			return 62;
		}
		else if(a == 28 && b == 35)
		{
			return 63;
		}
		else if(a == 28 && b == 36)
		{
			return 64;
		}
		else if(a == 28 && b == 37)
		{
			return 65;
		}
		else if(a == 28 && b == 38)
		{
			return 66;
		}
		else if(a == 28 && b == 39)
		{
			return 67;
		}
		else if(a == 28 && b == 40)
		{
			return 68;
		}
		else if(a == 28 && b == 41)
		{
			return 69;
		}
		else if(a == 28 && b == 42)
		{
			return 70;
		}
		else if(a == 28 && b == 43)
		{
			return 71;
		}
		else if(a == 28 && b == 44)
		{
			return 72;
		}
		else if(a == 28 && b == 45)
		{
			return 73;
		}
		else if(a == 28 && b == 46)
		{
			return 74;
		}
		else if(a == 28 && b == 47)
		{
			return 75;
		}
		else if(a == 28 && b == 48)
		{
			return 76;
		}
		else if(a == 28 && b == 49)
		{
			return 77;
		}
		else if(a == 28 && b == 50)
		{
			return 78;
		}
		else if(a == 28 && b == 51)
		{
			return 79;
		}
		else if(a == 28 && b == 52)
		{
			return 80;
		}
		else if(a == 28 && b == 53)
		{
			return 81;
		}
		else if(a == 28 && b == 54)
		{
			return 82;
		}
		else if(a == 28 && b == 55)
		{
			return 83;
		}
		else if(a == 28 && b == 56)
		{
			return 84;
		}
		else if(a == 28 && b == 57)
		{
			return 85;
		}
		else if(a == 28 && b == 58)
		{
			return 86;
		}
		else if(a == 28 && b == 59)
		{
			return 87;
		}
		else if(a == 28 && b == 60)
		{
			return 88;
		}
		else if(a == 28 && b == 61)
		{
			return 89;
		}
		else if(a == 28 && b == 62)
		{
			return 90;
		}
		else if(a == 28 && b == 63)
		{
			return 91;
		}
		else if(a == 28 && b == 64)
		{
			return 92;
		}
		else if(a == 28 && b == 65)
		{
			return 93;
		}
		else if(a == 28 && b == 66)
		{
			return 94;
		}
		else if(a == 28 && b == 67)
		{
			return 95;
		}
		else if(a == 28 && b == 68)
		{
			return 96;
		}
		else if(a == 28 && b == 69)
		{
			return 97;
		}
		else if(a == 28 && b == 70)
		{
			return 98;
		}
		else if(a == 28 && b == 71)
		{
			return 99;
		}
		else if(a == 28 && b == 72)
		{
			return 100;
		}
		else if(a == 28 && b == 73)
		{
			return 101;
		}
		else if(a == 28 && b == 74)
		{
			return 102;
		}
		else if(a == 28 && b == 75)
		{
			return 103;
		}
		else if(a == 28 && b == 76)
		{
			return 104;
		}
		else if(a == 28 && b == 77)
		{
			return 105;
		}
		else if(a == 28 && b == 78)
		{
			return 106;
		}
		else if(a == 28 && b == 79)
		{
			return 107;
		}
		else if(a == 28 && b == 80)
		{
			return 108;
		}
		else if(a == 28 && b == 81)
		{
			return 109;
		}
		else if(a == 28 && b == 82)
		{
			return 110;
		}
		else if(a == 28 && b == 83)
		{
			return 111;
		}
		else if(a == 28 && b == 84)
		{
			return 112;
		}
		else if(a == 28 && b == 85)
		{
			return 113;
		}
		else if(a == 28 && b == 86)
		{
			return 114;
		}
		else if(a == 28 && b == 87)
		{
			return 115;
		}
		else if(a == 28 && b == 88)
		{
			return 116;
		}
		else if(a == 28 && b == 89)
		{
			return 117;
		}
		else if(a == 28 && b == 90)
		{
			return 118;
		}
		else if(a == 28 && b == 91)
		{
			return 119;
		}
		else if(a == 28 && b == 92)
		{
			return 120;
		}
		else if(a == 28 && b == 93)
		{
			return 121;
		}
		else if(a == 28 && b == 94)
		{
			return 122;
		}
		else if(a == 28 && b == 95)
		{
			return 123;
		}
		else if(a == 28 && b == 96)
		{
			return 124;
		}
		else if(a == 28 && b == 97)
		{
			return 125;
		}
		else if(a == 28 && b == 98)
		{
			return 126;
		}
		else if(a == 28 && b == 99)
		{
			return 127;
		}
		else if(a == 28 && b == 100)
		{
			return 128;
		}
		else if(a == 29 && b == 0)
		{
			return 29;
		}
		else if(a == 29 && b == 1)
		{
			return 30;
		}
		else if(a == 29 && b == 2)
		{
			return 31;
		}
		else if(a == 29 && b == 3)
		{
			return 32;
		}
		else if(a == 29 && b == 4)
		{
			return 33;
		}
		else if(a == 29 && b == 5)
		{
			return 34;
		}
		else if(a == 29 && b == 6)
		{
			return 35;
		}
		else if(a == 29 && b == 7)
		{
			return 36;
		}
		else if(a == 29 && b == 8)
		{
			return 37;
		}
		else if(a == 29 && b == 9)
		{
			return 38;
		}
		else if(a == 29 && b == 10)
		{
			return 39;
		}
		else if(a == 29 && b == 11)
		{
			return 40;
		}
		else if(a == 29 && b == 12)
		{
			return 41;
		}
		else if(a == 29 && b == 13)
		{
			return 42;
		}
		else if(a == 29 && b == 14)
		{
			return 43;
		}
		else if(a == 29 && b == 15)
		{
			return 44;
		}
		else if(a == 29 && b == 16)
		{
			return 45;
		}
		else if(a == 29 && b == 17)
		{
			return 46;
		}
		else if(a == 29 && b == 18)
		{
			return 47;
		}
		else if(a == 29 && b == 19)
		{
			return 48;
		}
		else if(a == 29 && b == 20)
		{
			return 49;
		}
		else if(a == 29 && b == 21)
		{
			return 50;
		}
		else if(a == 29 && b == 22)
		{
			return 51;
		}
		else if(a == 29 && b == 23)
		{
			return 52;
		}
		else if(a == 29 && b == 24)
		{
			return 53;
		}
		else if(a == 29 && b == 25)
		{
			return 54;
		}
		else if(a == 29 && b == 26)
		{
			return 55;
		}
		else if(a == 29 && b == 27)
		{
			return 56;
		}
		else if(a == 29 && b == 28)
		{
			return 57;
		}
		else if(a == 29 && b == 29)
		{
			return 58;
		}
		else if(a == 29 && b == 30)
		{
			return 59;
		}
		else if(a == 29 && b == 31)
		{
			return 60;
		}
		else if(a == 29 && b == 32)
		{
			return 61;
		}
		else if(a == 29 && b == 33)
		{
			return 62;
		}
		else if(a == 29 && b == 34)
		{
			return 63;
		}
		else if(a == 29 && b == 35)
		{
			return 64;
		}
		else if(a == 29 && b == 36)
		{
			return 65;
		}
		else if(a == 29 && b == 37)
		{
			return 66;
		}
		else if(a == 29 && b == 38)
		{
			return 67;
		}
		else if(a == 29 && b == 39)
		{
			return 68;
		}
		else if(a == 29 && b == 40)
		{
			return 69;
		}
		else if(a == 29 && b == 41)
		{
			return 70;
		}
		else if(a == 29 && b == 42)
		{
			return 71;
		}
		else if(a == 29 && b == 43)
		{
			return 72;
		}
		else if(a == 29 && b == 44)
		{
			return 73;
		}
		else if(a == 29 && b == 45)
		{
			return 74;
		}
		else if(a == 29 && b == 46)
		{
			return 75;
		}
		else if(a == 29 && b == 47)
		{
			return 76;
		}
		else if(a == 29 && b == 48)
		{
			return 77;
		}
		else if(a == 29 && b == 49)
		{
			return 78;
		}
		else if(a == 29 && b == 50)
		{
			return 79;
		}
		else if(a == 29 && b == 51)
		{
			return 80;
		}
		else if(a == 29 && b == 52)
		{
			return 81;
		}
		else if(a == 29 && b == 53)
		{
			return 82;
		}
		else if(a == 29 && b == 54)
		{
			return 83;
		}
		else if(a == 29 && b == 55)
		{
			return 84;
		}
		else if(a == 29 && b == 56)
		{
			return 85;
		}
		else if(a == 29 && b == 57)
		{
			return 86;
		}
		else if(a == 29 && b == 58)
		{
			return 87;
		}
		else if(a == 29 && b == 59)
		{
			return 88;
		}
		else if(a == 29 && b == 60)
		{
			return 89;
		}
		else if(a == 29 && b == 61)
		{
			return 90;
		}
		else if(a == 29 && b == 62)
		{
			return 91;
		}
		else if(a == 29 && b == 63)
		{
			return 92;
		}
		else if(a == 29 && b == 64)
		{
			return 93;
		}
		else if(a == 29 && b == 65)
		{
			return 94;
		}
		else if(a == 29 && b == 66)
		{
			return 95;
		}
		else if(a == 29 && b == 67)
		{
			return 96;
		}
		else if(a == 29 && b == 68)
		{
			return 97;
		}
		else if(a == 29 && b == 69)
		{
			return 98;
		}
		else if(a == 29 && b == 70)
		{
			return 99;
		}
		else if(a == 29 && b == 71)
		{
			return 100;
		}
		else if(a == 29 && b == 72)
		{
			return 101;
		}
		else if(a == 29 && b == 73)
		{
			return 102;
		}
		else if(a == 29 && b == 74)
		{
			return 103;
		}
		else if(a == 29 && b == 75)
		{
			return 104;
		}
		else if(a == 29 && b == 76)
		{
			return 105;
		}
		else if(a == 29 && b == 77)
		{
			return 106;
		}
		else if(a == 29 && b == 78)
		{
			return 107;
		}
		else if(a == 29 && b == 79)
		{
			return 108;
		}
		else if(a == 29 && b == 80)
		{
			return 109;
		}
		else if(a == 29 && b == 81)
		{
			return 110;
		}
		else if(a == 29 && b == 82)
		{
			return 111;
		}
		else if(a == 29 && b == 83)
		{
			return 112;
		}
		else if(a == 29 && b == 84)
		{
			return 113;
		}
		else if(a == 29 && b == 85)
		{
			return 114;
		}
		else if(a == 29 && b == 86)
		{
			return 115;
		}
		else if(a == 29 && b == 87)
		{
			return 116;
		}
		else if(a == 29 && b == 88)
		{
			return 117;
		}
		else if(a == 29 && b == 89)
		{
			return 118;
		}
		else if(a == 29 && b == 90)
		{
			return 119;
		}
		else if(a == 29 && b == 91)
		{
			return 120;
		}
		else if(a == 29 && b == 92)
		{
			return 121;
		}
		else if(a == 29 && b == 93)
		{
			return 122;
		}
		else if(a == 29 && b == 94)
		{
			return 123;
		}
		else if(a == 29 && b == 95)
		{
			return 124;
		}
		else if(a == 29 && b == 96)
		{
			return 125;
		}
		else if(a == 29 && b == 97)
		{
			return 126;
		}
		else if(a == 29 && b == 98)
		{
			return 127;
		}
		else if(a == 29 && b == 99)
		{
			return 128;
		}
		else if(a == 29 && b == 100)
		{
			return 129;
		}
		else if(a == 30 && b == 0)
		{
			return 30;
		}
		else if(a == 30 && b == 1)
		{
			return 31;
		}
		else if(a == 30 && b == 2)
		{
			return 32;
		}
		else if(a == 30 && b == 3)
		{
			return 33;
		}
		else if(a == 30 && b == 4)
		{
			return 34;
		}
		else if(a == 30 && b == 5)
		{
			return 35;
		}
		else if(a == 30 && b == 6)
		{
			return 36;
		}
		else if(a == 30 && b == 7)
		{
			return 37;
		}
		else if(a == 30 && b == 8)
		{
			return 38;
		}
		else if(a == 30 && b == 9)
		{
			return 39;
		}
		else if(a == 30 && b == 10)
		{
			return 40;
		}
		else if(a == 30 && b == 11)
		{
			return 41;
		}
		else if(a == 30 && b == 12)
		{
			return 42;
		}
		else if(a == 30 && b == 13)
		{
			return 43;
		}
		else if(a == 30 && b == 14)
		{
			return 44;
		}
		else if(a == 30 && b == 15)
		{
			return 45;
		}
		else if(a == 30 && b == 16)
		{
			return 46;
		}
		else if(a == 30 && b == 17)
		{
			return 47;
		}
		else if(a == 30 && b == 18)
		{
			return 48;
		}
		else if(a == 30 && b == 19)
		{
			return 49;
		}
		else if(a == 30 && b == 20)
		{
			return 50;
		}
		else if(a == 30 && b == 21)
		{
			return 51;
		}
		else if(a == 30 && b == 22)
		{
			return 52;
		}
		else if(a == 30 && b == 23)
		{
			return 53;
		}
		else if(a == 30 && b == 24)
		{
			return 54;
		}
		else if(a == 30 && b == 25)
		{
			return 55;
		}
		else if(a == 30 && b == 26)
		{
			return 56;
		}
		else if(a == 30 && b == 27)
		{
			return 57;
		}
		else if(a == 30 && b == 28)
		{
			return 58;
		}
		else if(a == 30 && b == 29)
		{
			return 59;
		}
		else if(a == 30 && b == 30)
		{
			return 60;
		}
		else if(a == 30 && b == 31)
		{
			return 61;
		}
		else if(a == 30 && b == 32)
		{
			return 62;
		}
		else if(a == 30 && b == 33)
		{
			return 63;
		}
		else if(a == 30 && b == 34)
		{
			return 64;
		}
		else if(a == 30 && b == 35)
		{
			return 65;
		}
		else if(a == 30 && b == 36)
		{
			return 66;
		}
		else if(a == 30 && b == 37)
		{
			return 67;
		}
		else if(a == 30 && b == 38)
		{
			return 68;
		}
		else if(a == 30 && b == 39)
		{
			return 69;
		}
		else if(a == 30 && b == 40)
		{
			return 70;
		}
		else if(a == 30 && b == 41)
		{
			return 71;
		}
		else if(a == 30 && b == 42)
		{
			return 72;
		}
		else if(a == 30 && b == 43)
		{
			return 73;
		}
		else if(a == 30 && b == 44)
		{
			return 74;
		}
		else if(a == 30 && b == 45)
		{
			return 75;
		}
		else if(a == 30 && b == 46)
		{
			return 76;
		}
		else if(a == 30 && b == 47)
		{
			return 77;
		}
		else if(a == 30 && b == 48)
		{
			return 78;
		}
		else if(a == 30 && b == 49)
		{
			return 79;
		}
		else if(a == 30 && b == 50)
		{
			return 80;
		}
		else if(a == 30 && b == 51)
		{
			return 81;
		}
		else if(a == 30 && b == 52)
		{
			return 82;
		}
		else if(a == 30 && b == 53)
		{
			return 83;
		}
		else if(a == 30 && b == 54)
		{
			return 84;
		}
		else if(a == 30 && b == 55)
		{
			return 85;
		}
		else if(a == 30 && b == 56)
		{
			return 86;
		}
		else if(a == 30 && b == 57)
		{
			return 87;
		}
		else if(a == 30 && b == 58)
		{
			return 88;
		}
		else if(a == 30 && b == 59)
		{
			return 89;
		}
		else if(a == 30 && b == 60)
		{
			return 90;
		}
		else if(a == 30 && b == 61)
		{
			return 91;
		}
		else if(a == 30 && b == 62)
		{
			return 92;
		}
		else if(a == 30 && b == 63)
		{
			return 93;
		}
		else if(a == 30 && b == 64)
		{
			return 94;
		}
		else if(a == 30 && b == 65)
		{
			return 95;
		}
		else if(a == 30 && b == 66)
		{
			return 96;
		}
		else if(a == 30 && b == 67)
		{
			return 97;
		}
		else if(a == 30 && b == 68)
		{
			return 98;
		}
		else if(a == 30 && b == 69)
		{
			return 99;
		}
		else if(a == 30 && b == 70)
		{
			return 100;
		}
		else if(a == 30 && b == 71)
		{
			return 101;
		}
		else if(a == 30 && b == 72)
		{
			return 102;
		}
		else if(a == 30 && b == 73)
		{
			return 103;
		}
		else if(a == 30 && b == 74)
		{
			return 104;
		}
		else if(a == 30 && b == 75)
		{
			return 105;
		}
		else if(a == 30 && b == 76)
		{
			return 106;
		}
		else if(a == 30 && b == 77)
		{
			return 107;
		}
		else if(a == 30 && b == 78)
		{
			return 108;
		}
		else if(a == 30 && b == 79)
		{
			return 109;
		}
		else if(a == 30 && b == 80)
		{
			return 110;
		}
		else if(a == 30 && b == 81)
		{
			return 111;
		}
		else if(a == 30 && b == 82)
		{
			return 112;
		}
		else if(a == 30 && b == 83)
		{
			return 113;
		}
		else if(a == 30 && b == 84)
		{
			return 114;
		}
		else if(a == 30 && b == 85)
		{
			return 115;
		}
		else if(a == 30 && b == 86)
		{
			return 116;
		}
		else if(a == 30 && b == 87)
		{
			return 117;
		}
		else if(a == 30 && b == 88)
		{
			return 118;
		}
		else if(a == 30 && b == 89)
		{
			return 119;
		}
		else if(a == 30 && b == 90)
		{
			return 120;
		}
		else if(a == 30 && b == 91)
		{
			return 121;
		}
		else if(a == 30 && b == 92)
		{
			return 122;
		}
		else if(a == 30 && b == 93)
		{
			return 123;
		}
		else if(a == 30 && b == 94)
		{
			return 124;
		}
		else if(a == 30 && b == 95)
		{
			return 125;
		}
		else if(a == 30 && b == 96)
		{
			return 126;
		}
		else if(a == 30 && b == 97)
		{
			return 127;
		}
		else if(a == 30 && b == 98)
		{
			return 128;
		}
		else if(a == 30 && b == 99)
		{
			return 129;
		}
		else if(a == 30 && b == 100)
		{
			return 130;
		}
		else if(a == 31 && b == 0)
		{
			return 31;
		}
		else if(a == 31 && b == 1)
		{
			return 32;
		}
		else if(a == 31 && b == 2)
		{
			return 33;
		}
		else if(a == 31 && b == 3)
		{
			return 34;
		}
		else if(a == 31 && b == 4)
		{
			return 35;
		}
		else if(a == 31 && b == 5)
		{
			return 36;
		}
		else if(a == 31 && b == 6)
		{
			return 37;
		}
		else if(a == 31 && b == 7)
		{
			return 38;
		}
		else if(a == 31 && b == 8)
		{
			return 39;
		}
		else if(a == 31 && b == 9)
		{
			return 40;
		}
		else if(a == 31 && b == 10)
		{
			return 41;
		}
		else if(a == 31 && b == 11)
		{
			return 42;
		}
		else if(a == 31 && b == 12)
		{
			return 43;
		}
		else if(a == 31 && b == 13)
		{
			return 44;
		}
		else if(a == 31 && b == 14)
		{
			return 45;
		}
		else if(a == 31 && b == 15)
		{
			return 46;
		}
		else if(a == 31 && b == 16)
		{
			return 47;
		}
		else if(a == 31 && b == 17)
		{
			return 48;
		}
		else if(a == 31 && b == 18)
		{
			return 49;
		}
		else if(a == 31 && b == 19)
		{
			return 50;
		}
		else if(a == 31 && b == 20)
		{
			return 51;
		}
		else if(a == 31 && b == 21)
		{
			return 52;
		}
		else if(a == 31 && b == 22)
		{
			return 53;
		}
		else if(a == 31 && b == 23)
		{
			return 54;
		}
		else if(a == 31 && b == 24)
		{
			return 55;
		}
		else if(a == 31 && b == 25)
		{
			return 56;
		}
		else if(a == 31 && b == 26)
		{
			return 57;
		}
		else if(a == 31 && b == 27)
		{
			return 58;
		}
		else if(a == 31 && b == 28)
		{
			return 59;
		}
		else if(a == 31 && b == 29)
		{
			return 60;
		}
		else if(a == 31 && b == 30)
		{
			return 61;
		}
		else if(a == 31 && b == 31)
		{
			return 62;
		}
		else if(a == 31 && b == 32)
		{
			return 63;
		}
		else if(a == 31 && b == 33)
		{
			return 64;
		}
		else if(a == 31 && b == 34)
		{
			return 65;
		}
		else if(a == 31 && b == 35)
		{
			return 66;
		}
		else if(a == 31 && b == 36)
		{
			return 67;
		}
		else if(a == 31 && b == 37)
		{
			return 68;
		}
		else if(a == 31 && b == 38)
		{
			return 69;
		}
		else if(a == 31 && b == 39)
		{
			return 70;
		}
		else if(a == 31 && b == 40)
		{
			return 71;
		}
		else if(a == 31 && b == 41)
		{
			return 72;
		}
		else if(a == 31 && b == 42)
		{
			return 73;
		}
		else if(a == 31 && b == 43)
		{
			return 74;
		}
		else if(a == 31 && b == 44)
		{
			return 75;
		}
		else if(a == 31 && b == 45)
		{
			return 76;
		}
		else if(a == 31 && b == 46)
		{
			return 77;
		}
		else if(a == 31 && b == 47)
		{
			return 78;
		}
		else if(a == 31 && b == 48)
		{
			return 79;
		}
		else if(a == 31 && b == 49)
		{
			return 80;
		}
		else if(a == 31 && b == 50)
		{
			return 81;
		}
		else if(a == 31 && b == 51)
		{
			return 82;
		}
		else if(a == 31 && b == 52)
		{
			return 83;
		}
		else if(a == 31 && b == 53)
		{
			return 84;
		}
		else if(a == 31 && b == 54)
		{
			return 85;
		}
		else if(a == 31 && b == 55)
		{
			return 86;
		}
		else if(a == 31 && b == 56)
		{
			return 87;
		}
		else if(a == 31 && b == 57)
		{
			return 88;
		}
		else if(a == 31 && b == 58)
		{
			return 89;
		}
		else if(a == 31 && b == 59)
		{
			return 90;
		}
		else if(a == 31 && b == 60)
		{
			return 91;
		}
		else if(a == 31 && b == 61)
		{
			return 92;
		}
		else if(a == 31 && b == 62)
		{
			return 93;
		}
		else if(a == 31 && b == 63)
		{
			return 94;
		}
		else if(a == 31 && b == 64)
		{
			return 95;
		}
		else if(a == 31 && b == 65)
		{
			return 96;
		}
		else if(a == 31 && b == 66)
		{
			return 97;
		}
		else if(a == 31 && b == 67)
		{
			return 98;
		}
		else if(a == 31 && b == 68)
		{
			return 99;
		}
		else if(a == 31 && b == 69)
		{
			return 100;
		}
		else if(a == 31 && b == 70)
		{
			return 101;
		}
		else if(a == 31 && b == 71)
		{
			return 102;
		}
		else if(a == 31 && b == 72)
		{
			return 103;
		}
		else if(a == 31 && b == 73)
		{
			return 104;
		}
		else if(a == 31 && b == 74)
		{
			return 105;
		}
		else if(a == 31 && b == 75)
		{
			return 106;
		}
		else if(a == 31 && b == 76)
		{
			return 107;
		}
		else if(a == 31 && b == 77)
		{
			return 108;
		}
		else if(a == 31 && b == 78)
		{
			return 109;
		}
		else if(a == 31 && b == 79)
		{
			return 110;
		}
		else if(a == 31 && b == 80)
		{
			return 111;
		}
		else if(a == 31 && b == 81)
		{
			return 112;
		}
		else if(a == 31 && b == 82)
		{
			return 113;
		}
		else if(a == 31 && b == 83)
		{
			return 114;
		}
		else if(a == 31 && b == 84)
		{
			return 115;
		}
		else if(a == 31 && b == 85)
		{
			return 116;
		}
		else if(a == 31 && b == 86)
		{
			return 117;
		}
		else if(a == 31 && b == 87)
		{
			return 118;
		}
		else if(a == 31 && b == 88)
		{
			return 119;
		}
		else if(a == 31 && b == 89)
		{
			return 120;
		}
		else if(a == 31 && b == 90)
		{
			return 121;
		}
		else if(a == 31 && b == 91)
		{
			return 122;
		}
		else if(a == 31 && b == 92)
		{
			return 123;
		}
		else if(a == 31 && b == 93)
		{
			return 124;
		}
		else if(a == 31 && b == 94)
		{
			return 125;
		}
		else if(a == 31 && b == 95)
		{
			return 126;
		}
		else if(a == 31 && b == 96)
		{
			return 127;
		}
		else if(a == 31 && b == 97)
		{
			return 128;
		}
		else if(a == 31 && b == 98)
		{
			return 129;
		}
		else if(a == 31 && b == 99)
		{
			return 130;
		}
		else if(a == 31 && b == 100)
		{
			return 131;
		}
		else if(a == 32 && b == 0)
		{
			return 32;
		}
		else if(a == 32 && b == 1)
		{
			return 33;
		}
		else if(a == 32 && b == 2)
		{
			return 34;
		}
		else if(a == 32 && b == 3)
		{
			return 35;
		}
		else if(a == 32 && b == 4)
		{
			return 36;
		}
		else if(a == 32 && b == 5)
		{
			return 37;
		}
		else if(a == 32 && b == 6)
		{
			return 38;
		}
		else if(a == 32 && b == 7)
		{
			return 39;
		}
		else if(a == 32 && b == 8)
		{
			return 40;
		}
		else if(a == 32 && b == 9)
		{
			return 41;
		}
		else if(a == 32 && b == 10)
		{
			return 42;
		}
		else if(a == 32 && b == 11)
		{
			return 43;
		}
		else if(a == 32 && b == 12)
		{
			return 44;
		}
		else if(a == 32 && b == 13)
		{
			return 45;
		}
		else if(a == 32 && b == 14)
		{
			return 46;
		}
		else if(a == 32 && b == 15)
		{
			return 47;
		}
		else if(a == 32 && b == 16)
		{
			return 48;
		}
		else if(a == 32 && b == 17)
		{
			return 49;
		}
		else if(a == 32 && b == 18)
		{
			return 50;
		}
		else if(a == 32 && b == 19)
		{
			return 51;
		}
		else if(a == 32 && b == 20)
		{
			return 52;
		}
		else if(a == 32 && b == 21)
		{
			return 53;
		}
		else if(a == 32 && b == 22)
		{
			return 54;
		}
		else if(a == 32 && b == 23)
		{
			return 55;
		}
		else if(a == 32 && b == 24)
		{
			return 56;
		}
		else if(a == 32 && b == 25)
		{
			return 57;
		}
		else if(a == 32 && b == 26)
		{
			return 58;
		}
		else if(a == 32 && b == 27)
		{
			return 59;
		}
		else if(a == 32 && b == 28)
		{
			return 60;
		}
		else if(a == 32 && b == 29)
		{
			return 61;
		}
		else if(a == 32 && b == 30)
		{
			return 62;
		}
		else if(a == 32 && b == 31)
		{
			return 63;
		}
		else if(a == 32 && b == 32)
		{
			return 64;
		}
		else if(a == 32 && b == 33)
		{
			return 65;
		}
		else if(a == 32 && b == 34)
		{
			return 66;
		}
		else if(a == 32 && b == 35)
		{
			return 67;
		}
		else if(a == 32 && b == 36)
		{
			return 68;
		}
		else if(a == 32 && b == 37)
		{
			return 69;
		}
		else if(a == 32 && b == 38)
		{
			return 70;
		}
		else if(a == 32 && b == 39)
		{
			return 71;
		}
		else if(a == 32 && b == 40)
		{
			return 72;
		}
		else if(a == 32 && b == 41)
		{
			return 73;
		}
		else if(a == 32 && b == 42)
		{
			return 74;
		}
		else if(a == 32 && b == 43)
		{
			return 75;
		}
		else if(a == 32 && b == 44)
		{
			return 76;
		}
		else if(a == 32 && b == 45)
		{
			return 77;
		}
		else if(a == 32 && b == 46)
		{
			return 78;
		}
		else if(a == 32 && b == 47)
		{
			return 79;
		}
		else if(a == 32 && b == 48)
		{
			return 80;
		}
		else if(a == 32 && b == 49)
		{
			return 81;
		}
		else if(a == 32 && b == 50)
		{
			return 82;
		}
		else if(a == 32 && b == 51)
		{
			return 83;
		}
		else if(a == 32 && b == 52)
		{
			return 84;
		}
		else if(a == 32 && b == 53)
		{
			return 85;
		}
		else if(a == 32 && b == 54)
		{
			return 86;
		}
		else if(a == 32 && b == 55)
		{
			return 87;
		}
		else if(a == 32 && b == 56)
		{
			return 88;
		}
		else if(a == 32 && b == 57)
		{
			return 89;
		}
		else if(a == 32 && b == 58)
		{
			return 90;
		}
		else if(a == 32 && b == 59)
		{
			return 91;
		}
		else if(a == 32 && b == 60)
		{
			return 92;
		}
		else if(a == 32 && b == 61)
		{
			return 93;
		}
		else if(a == 32 && b == 62)
		{
			return 94;
		}
		else if(a == 32 && b == 63)
		{
			return 95;
		}
		else if(a == 32 && b == 64)
		{
			return 96;
		}
		else if(a == 32 && b == 65)
		{
			return 97;
		}
		else if(a == 32 && b == 66)
		{
			return 98;
		}
		else if(a == 32 && b == 67)
		{
			return 99;
		}
		else if(a == 32 && b == 68)
		{
			return 100;
		}
		else if(a == 32 && b == 69)
		{
			return 101;
		}
		else if(a == 32 && b == 70)
		{
			return 102;
		}
		else if(a == 32 && b == 71)
		{
			return 103;
		}
		else if(a == 32 && b == 72)
		{
			return 104;
		}
		else if(a == 32 && b == 73)
		{
			return 105;
		}
		else if(a == 32 && b == 74)
		{
			return 106;
		}
		else if(a == 32 && b == 75)
		{
			return 107;
		}
		else if(a == 32 && b == 76)
		{
			return 108;
		}
		else if(a == 32 && b == 77)
		{
			return 109;
		}
		else if(a == 32 && b == 78)
		{
			return 110;
		}
		else if(a == 32 && b == 79)
		{
			return 111;
		}
		else if(a == 32 && b == 80)
		{
			return 112;
		}
		else if(a == 32 && b == 81)
		{
			return 113;
		}
		else if(a == 32 && b == 82)
		{
			return 114;
		}
		else if(a == 32 && b == 83)
		{
			return 115;
		}
		else if(a == 32 && b == 84)
		{
			return 116;
		}
		else if(a == 32 && b == 85)
		{
			return 117;
		}
		else if(a == 32 && b == 86)
		{
			return 118;
		}
		else if(a == 32 && b == 87)
		{
			return 119;
		}
		else if(a == 32 && b == 88)
		{
			return 120;
		}
		else if(a == 32 && b == 89)
		{
			return 121;
		}
		else if(a == 32 && b == 90)
		{
			return 122;
		}
		else if(a == 32 && b == 91)
		{
			return 123;
		}
		else if(a == 32 && b == 92)
		{
			return 124;
		}
		else if(a == 32 && b == 93)
		{
			return 125;
		}
		else if(a == 32 && b == 94)
		{
			return 126;
		}
		else if(a == 32 && b == 95)
		{
			return 127;
		}
		else if(a == 32 && b == 96)
		{
			return 128;
		}
		else if(a == 32 && b == 97)
		{
			return 129;
		}
		else if(a == 32 && b == 98)
		{
			return 130;
		}
		else if(a == 32 && b == 99)
		{
			return 131;
		}
		else if(a == 32 && b == 100)
		{
			return 132;
		}
		else if(a == 33 && b == 0)
		{
			return 33;
		}
		else if(a == 33 && b == 1)
		{
			return 34;
		}
		else if(a == 33 && b == 2)
		{
			return 35;
		}
		else if(a == 33 && b == 3)
		{
			return 36;
		}
		else if(a == 33 && b == 4)
		{
			return 37;
		}
		else if(a == 33 && b == 5)
		{
			return 38;
		}
		else if(a == 33 && b == 6)
		{
			return 39;
		}
		else if(a == 33 && b == 7)
		{
			return 40;
		}
		else if(a == 33 && b == 8)
		{
			return 41;
		}
		else if(a == 33 && b == 9)
		{
			return 42;
		}
		else if(a == 33 && b == 10)
		{
			return 43;
		}
		else if(a == 33 && b == 11)
		{
			return 44;
		}
		else if(a == 33 && b == 12)
		{
			return 45;
		}
		else if(a == 33 && b == 13)
		{
			return 46;
		}
		else if(a == 33 && b == 14)
		{
			return 47;
		}
		else if(a == 33 && b == 15)
		{
			return 48;
		}
		else if(a == 33 && b == 16)
		{
			return 49;
		}
		else if(a == 33 && b == 17)
		{
			return 50;
		}
		else if(a == 33 && b == 18)
		{
			return 51;
		}
		else if(a == 33 && b == 19)
		{
			return 52;
		}
		else if(a == 33 && b == 20)
		{
			return 53;
		}
		else if(a == 33 && b == 21)
		{
			return 54;
		}
		else if(a == 33 && b == 22)
		{
			return 55;
		}
		else if(a == 33 && b == 23)
		{
			return 56;
		}
		else if(a == 33 && b == 24)
		{
			return 57;
		}
		else if(a == 33 && b == 25)
		{
			return 58;
		}
		else if(a == 33 && b == 26)
		{
			return 59;
		}
		else if(a == 33 && b == 27)
		{
			return 60;
		}
		else if(a == 33 && b == 28)
		{
			return 61;
		}
		else if(a == 33 && b == 29)
		{
			return 62;
		}
		else if(a == 33 && b == 30)
		{
			return 63;
		}
		else if(a == 33 && b == 31)
		{
			return 64;
		}
		else if(a == 33 && b == 32)
		{
			return 65;
		}
		else if(a == 33 && b == 33)
		{
			return 66;
		}
		else if(a == 33 && b == 34)
		{
			return 67;
		}
		else if(a == 33 && b == 35)
		{
			return 68;
		}
		else if(a == 33 && b == 36)
		{
			return 69;
		}
		else if(a == 33 && b == 37)
		{
			return 70;
		}
		else if(a == 33 && b == 38)
		{
			return 71;
		}
		else if(a == 33 && b == 39)
		{
			return 72;
		}
		else if(a == 33 && b == 40)
		{
			return 73;
		}
		else if(a == 33 && b == 41)
		{
			return 74;
		}
		else if(a == 33 && b == 42)
		{
			return 75;
		}
		else if(a == 33 && b == 43)
		{
			return 76;
		}
		else if(a == 33 && b == 44)
		{
			return 77;
		}
		else if(a == 33 && b == 45)
		{
			return 78;
		}
		else if(a == 33 && b == 46)
		{
			return 79;
		}
		else if(a == 33 && b == 47)
		{
			return 80;
		}
		else if(a == 33 && b == 48)
		{
			return 81;
		}
		else if(a == 33 && b == 49)
		{
			return 82;
		}
		else if(a == 33 && b == 50)
		{
			return 83;
		}
		else if(a == 33 && b == 51)
		{
			return 84;
		}
		else if(a == 33 && b == 52)
		{
			return 85;
		}
		else if(a == 33 && b == 53)
		{
			return 86;
		}
		else if(a == 33 && b == 54)
		{
			return 87;
		}
		else if(a == 33 && b == 55)
		{
			return 88;
		}
		else if(a == 33 && b == 56)
		{
			return 89;
		}
		else if(a == 33 && b == 57)
		{
			return 90;
		}
		else if(a == 33 && b == 58)
		{
			return 91;
		}
		else if(a == 33 && b == 59)
		{
			return 92;
		}
		else if(a == 33 && b == 60)
		{
			return 93;
		}
		else if(a == 33 && b == 61)
		{
			return 94;
		}
		else if(a == 33 && b == 62)
		{
			return 95;
		}
		else if(a == 33 && b == 63)
		{
			return 96;
		}
		else if(a == 33 && b == 64)
		{
			return 97;
		}
		else if(a == 33 && b == 65)
		{
			return 98;
		}
		else if(a == 33 && b == 66)
		{
			return 99;
		}
		else if(a == 33 && b == 67)
		{
			return 100;
		}
		else if(a == 33 && b == 68)
		{
			return 101;
		}
		else if(a == 33 && b == 69)
		{
			return 102;
		}
		else if(a == 33 && b == 70)
		{
			return 103;
		}
		else if(a == 33 && b == 71)
		{
			return 104;
		}
		else if(a == 33 && b == 72)
		{
			return 105;
		}
		else if(a == 33 && b == 73)
		{
			return 106;
		}
		else if(a == 33 && b == 74)
		{
			return 107;
		}
		else if(a == 33 && b == 75)
		{
			return 108;
		}
		else if(a == 33 && b == 76)
		{
			return 109;
		}
		else if(a == 33 && b == 77)
		{
			return 110;
		}
		else if(a == 33 && b == 78)
		{
			return 111;
		}
		else if(a == 33 && b == 79)
		{
			return 112;
		}
		else if(a == 33 && b == 80)
		{
			return 113;
		}
		else if(a == 33 && b == 81)
		{
			return 114;
		}
		else if(a == 33 && b == 82)
		{
			return 115;
		}
		else if(a == 33 && b == 83)
		{
			return 116;
		}
		else if(a == 33 && b == 84)
		{
			return 117;
		}
		else if(a == 33 && b == 85)
		{
			return 118;
		}
		else if(a == 33 && b == 86)
		{
			return 119;
		}
		else if(a == 33 && b == 87)
		{
			return 120;
		}
		else if(a == 33 && b == 88)
		{
			return 121;
		}
		else if(a == 33 && b == 89)
		{
			return 122;
		}
		else if(a == 33 && b == 90)
		{
			return 123;
		}
		else if(a == 33 && b == 91)
		{
			return 124;
		}
		else if(a == 33 && b == 92)
		{
			return 125;
		}
		else if(a == 33 && b == 93)
		{
			return 126;
		}
		else if(a == 33 && b == 94)
		{
			return 127;
		}
		else if(a == 33 && b == 95)
		{
			return 128;
		}
		else if(a == 33 && b == 96)
		{
			return 129;
		}
		else if(a == 33 && b == 97)
		{
			return 130;
		}
		else if(a == 33 && b == 98)
		{
			return 131;
		}
		else if(a == 33 && b == 99)
		{
			return 132;
		}
		else if(a == 33 && b == 100)
		{
			return 133;
		}
		else if(a == 34 && b == 0)
		{
			return 34;
		}
		else if(a == 34 && b == 1)
		{
			return 35;
		}
		else if(a == 34 && b == 2)
		{
			return 36;
		}
		else if(a == 34 && b == 3)
		{
			return 37;
		}
		else if(a == 34 && b == 4)
		{
			return 38;
		}
		else if(a == 34 && b == 5)
		{
			return 39;
		}
		else if(a == 34 && b == 6)
		{
			return 40;
		}
		else if(a == 34 && b == 7)
		{
			return 41;
		}
		else if(a == 34 && b == 8)
		{
			return 42;
		}
		else if(a == 34 && b == 9)
		{
			return 43;
		}
		else if(a == 34 && b == 10)
		{
			return 44;
		}
		else if(a == 34 && b == 11)
		{
			return 45;
		}
		else if(a == 34 && b == 12)
		{
			return 46;
		}
		else if(a == 34 && b == 13)
		{
			return 47;
		}
		else if(a == 34 && b == 14)
		{
			return 48;
		}
		else if(a == 34 && b == 15)
		{
			return 49;
		}
		else if(a == 34 && b == 16)
		{
			return 50;
		}
		else if(a == 34 && b == 17)
		{
			return 51;
		}
		else if(a == 34 && b == 18)
		{
			return 52;
		}
		else if(a == 34 && b == 19)
		{
			return 53;
		}
		else if(a == 34 && b == 20)
		{
			return 54;
		}
		else if(a == 34 && b == 21)
		{
			return 55;
		}
		else if(a == 34 && b == 22)
		{
			return 56;
		}
		else if(a == 34 && b == 23)
		{
			return 57;
		}
		else if(a == 34 && b == 24)
		{
			return 58;
		}
		else if(a == 34 && b == 25)
		{
			return 59;
		}
		else if(a == 34 && b == 26)
		{
			return 60;
		}
		else if(a == 34 && b == 27)
		{
			return 61;
		}
		else if(a == 34 && b == 28)
		{
			return 62;
		}
		else if(a == 34 && b == 29)
		{
			return 63;
		}
		else if(a == 34 && b == 30)
		{
			return 64;
		}
		else if(a == 34 && b == 31)
		{
			return 65;
		}
		else if(a == 34 && b == 32)
		{
			return 66;
		}
		else if(a == 34 && b == 33)
		{
			return 67;
		}
		else if(a == 34 && b == 34)
		{
			return 68;
		}
		else if(a == 34 && b == 35)
		{
			return 69;
		}
		else if(a == 34 && b == 36)
		{
			return 70;
		}
		else if(a == 34 && b == 37)
		{
			return 71;
		}
		else if(a == 34 && b == 38)
		{
			return 72;
		}
		else if(a == 34 && b == 39)
		{
			return 73;
		}
		else if(a == 34 && b == 40)
		{
			return 74;
		}
		else if(a == 34 && b == 41)
		{
			return 75;
		}
		else if(a == 34 && b == 42)
		{
			return 76;
		}
		else if(a == 34 && b == 43)
		{
			return 77;
		}
		else if(a == 34 && b == 44)
		{
			return 78;
		}
		else if(a == 34 && b == 45)
		{
			return 79;
		}
		else if(a == 34 && b == 46)
		{
			return 80;
		}
		else if(a == 34 && b == 47)
		{
			return 81;
		}
		else if(a == 34 && b == 48)
		{
			return 82;
		}
		else if(a == 34 && b == 49)
		{
			return 83;
		}
		else if(a == 34 && b == 50)
		{
			return 84;
		}
		else if(a == 34 && b == 51)
		{
			return 85;
		}
		else if(a == 34 && b == 52)
		{
			return 86;
		}
		else if(a == 34 && b == 53)
		{
			return 87;
		}
		else if(a == 34 && b == 54)
		{
			return 88;
		}
		else if(a == 34 && b == 55)
		{
			return 89;
		}
		else if(a == 34 && b == 56)
		{
			return 90;
		}
		else if(a == 34 && b == 57)
		{
			return 91;
		}
		else if(a == 34 && b == 58)
		{
			return 92;
		}
		else if(a == 34 && b == 59)
		{
			return 93;
		}
		else if(a == 34 && b == 60)
		{
			return 94;
		}
		else if(a == 34 && b == 61)
		{
			return 95;
		}
		else if(a == 34 && b == 62)
		{
			return 96;
		}
		else if(a == 34 && b == 63)
		{
			return 97;
		}
		else if(a == 34 && b == 64)
		{
			return 98;
		}
		else if(a == 34 && b == 65)
		{
			return 99;
		}
		else if(a == 34 && b == 66)
		{
			return 100;
		}
		else if(a == 34 && b == 67)
		{
			return 101;
		}
		else if(a == 34 && b == 68)
		{
			return 102;
		}
		else if(a == 34 && b == 69)
		{
			return 103;
		}
		else if(a == 34 && b == 70)
		{
			return 104;
		}
		else if(a == 34 && b == 71)
		{
			return 105;
		}
		else if(a == 34 && b == 72)
		{
			return 106;
		}
		else if(a == 34 && b == 73)
		{
			return 107;
		}
		else if(a == 34 && b == 74)
		{
			return 108;
		}
		else if(a == 34 && b == 75)
		{
			return 109;
		}
		else if(a == 34 && b == 76)
		{
			return 110;
		}
		else if(a == 34 && b == 77)
		{
			return 111;
		}
		else if(a == 34 && b == 78)
		{
			return 112;
		}
		else if(a == 34 && b == 79)
		{
			return 113;
		}
		else if(a == 34 && b == 80)
		{
			return 114;
		}
		else if(a == 34 && b == 81)
		{
			return 115;
		}
		else if(a == 34 && b == 82)
		{
			return 116;
		}
		else if(a == 34 && b == 83)
		{
			return 117;
		}
		else if(a == 34 && b == 84)
		{
			return 118;
		}
		else if(a == 34 && b == 85)
		{
			return 119;
		}
		else if(a == 34 && b == 86)
		{
			return 120;
		}
		else if(a == 34 && b == 87)
		{
			return 121;
		}
		else if(a == 34 && b == 88)
		{
			return 122;
		}
		else if(a == 34 && b == 89)
		{
			return 123;
		}
		else if(a == 34 && b == 90)
		{
			return 124;
		}
		else if(a == 34 && b == 91)
		{
			return 125;
		}
		else if(a == 34 && b == 92)
		{
			return 126;
		}
		else if(a == 34 && b == 93)
		{
			return 127;
		}
		else if(a == 34 && b == 94)
		{
			return 128;
		}
		else if(a == 34 && b == 95)
		{
			return 129;
		}
		else if(a == 34 && b == 96)
		{
			return 130;
		}
		else if(a == 34 && b == 97)
		{
			return 131;
		}
		else if(a == 34 && b == 98)
		{
			return 132;
		}
		else if(a == 34 && b == 99)
		{
			return 133;
		}
		else if(a == 34 && b == 100)
		{
			return 134;
		}
		else if(a == 35 && b == 0)
		{
			return 35;
		}
		else if(a == 35 && b == 1)
		{
			return 36;
		}
		else if(a == 35 && b == 2)
		{
			return 37;
		}
		else if(a == 35 && b == 3)
		{
			return 38;
		}
		else if(a == 35 && b == 4)
		{
			return 39;
		}
		else if(a == 35 && b == 5)
		{
			return 40;
		}
		else if(a == 35 && b == 6)
		{
			return 41;
		}
		else if(a == 35 && b == 7)
		{
			return 42;
		}
		else if(a == 35 && b == 8)
		{
			return 43;
		}
		else if(a == 35 && b == 9)
		{
			return 44;
		}
		else if(a == 35 && b == 10)
		{
			return 45;
		}
		else if(a == 35 && b == 11)
		{
			return 46;
		}
		else if(a == 35 && b == 12)
		{
			return 47;
		}
		else if(a == 35 && b == 13)
		{
			return 48;
		}
		else if(a == 35 && b == 14)
		{
			return 49;
		}
		else if(a == 35 && b == 15)
		{
			return 50;
		}
		else if(a == 35 && b == 16)
		{
			return 51;
		}
		else if(a == 35 && b == 17)
		{
			return 52;
		}
		else if(a == 35 && b == 18)
		{
			return 53;
		}
		else if(a == 35 && b == 19)
		{
			return 54;
		}
		else if(a == 35 && b == 20)
		{
			return 55;
		}
		else if(a == 35 && b == 21)
		{
			return 56;
		}
		else if(a == 35 && b == 22)
		{
			return 57;
		}
		else if(a == 35 && b == 23)
		{
			return 58;
		}
		else if(a == 35 && b == 24)
		{
			return 59;
		}
		else if(a == 35 && b == 25)
		{
			return 60;
		}
		else if(a == 35 && b == 26)
		{
			return 61;
		}
		else if(a == 35 && b == 27)
		{
			return 62;
		}
		else if(a == 35 && b == 28)
		{
			return 63;
		}
		else if(a == 35 && b == 29)
		{
			return 64;
		}
		else if(a == 35 && b == 30)
		{
			return 65;
		}
		else if(a == 35 && b == 31)
		{
			return 66;
		}
		else if(a == 35 && b == 32)
		{
			return 67;
		}
		else if(a == 35 && b == 33)
		{
			return 68;
		}
		else if(a == 35 && b == 34)
		{
			return 69;
		}
		else if(a == 35 && b == 35)
		{
			return 70;
		}
		else if(a == 35 && b == 36)
		{
			return 71;
		}
		else if(a == 35 && b == 37)
		{
			return 72;
		}
		else if(a == 35 && b == 38)
		{
			return 73;
		}
		else if(a == 35 && b == 39)
		{
			return 74;
		}
		else if(a == 35 && b == 40)
		{
			return 75;
		}
		else if(a == 35 && b == 41)
		{
			return 76;
		}
		else if(a == 35 && b == 42)
		{
			return 77;
		}
		else if(a == 35 && b == 43)
		{
			return 78;
		}
		else if(a == 35 && b == 44)
		{
			return 79;
		}
		else if(a == 35 && b == 45)
		{
			return 80;
		}
		else if(a == 35 && b == 46)
		{
			return 81;
		}
		else if(a == 35 && b == 47)
		{
			return 82;
		}
		else if(a == 35 && b == 48)
		{
			return 83;
		}
		else if(a == 35 && b == 49)
		{
			return 84;
		}
		else if(a == 35 && b == 50)
		{
			return 85;
		}
		else if(a == 35 && b == 51)
		{
			return 86;
		}
		else if(a == 35 && b == 52)
		{
			return 87;
		}
		else if(a == 35 && b == 53)
		{
			return 88;
		}
		else if(a == 35 && b == 54)
		{
			return 89;
		}
		else if(a == 35 && b == 55)
		{
			return 90;
		}
		else if(a == 35 && b == 56)
		{
			return 91;
		}
		else if(a == 35 && b == 57)
		{
			return 92;
		}
		else if(a == 35 && b == 58)
		{
			return 93;
		}
		else if(a == 35 && b == 59)
		{
			return 94;
		}
		else if(a == 35 && b == 60)
		{
			return 95;
		}
		else if(a == 35 && b == 61)
		{
			return 96;
		}
		else if(a == 35 && b == 62)
		{
			return 97;
		}
		else if(a == 35 && b == 63)
		{
			return 98;
		}
		else if(a == 35 && b == 64)
		{
			return 99;
		}
		else if(a == 35 && b == 65)
		{
			return 100;
		}
		else if(a == 35 && b == 66)
		{
			return 101;
		}
		else if(a == 35 && b == 67)
		{
			return 102;
		}
		else if(a == 35 && b == 68)
		{
			return 103;
		}
		else if(a == 35 && b == 69)
		{
			return 104;
		}
		else if(a == 35 && b == 70)
		{
			return 105;
		}
		else if(a == 35 && b == 71)
		{
			return 106;
		}
		else if(a == 35 && b == 72)
		{
			return 107;
		}
		else if(a == 35 && b == 73)
		{
			return 108;
		}
		else if(a == 35 && b == 74)
		{
			return 109;
		}
		else if(a == 35 && b == 75)
		{
			return 110;
		}
		else if(a == 35 && b == 76)
		{
			return 111;
		}
		else if(a == 35 && b == 77)
		{
			return 112;
		}
		else if(a == 35 && b == 78)
		{
			return 113;
		}
		else if(a == 35 && b == 79)
		{
			return 114;
		}
		else if(a == 35 && b == 80)
		{
			return 115;
		}
		else if(a == 35 && b == 81)
		{
			return 116;
		}
		else if(a == 35 && b == 82)
		{
			return 117;
		}
		else if(a == 35 && b == 83)
		{
			return 118;
		}
		else if(a == 35 && b == 84)
		{
			return 119;
		}
		else if(a == 35 && b == 85)
		{
			return 120;
		}
		else if(a == 35 && b == 86)
		{
			return 121;
		}
		else if(a == 35 && b == 87)
		{
			return 122;
		}
		else if(a == 35 && b == 88)
		{
			return 123;
		}
		else if(a == 35 && b == 89)
		{
			return 124;
		}
		else if(a == 35 && b == 90)
		{
			return 125;
		}
		else if(a == 35 && b == 91)
		{
			return 126;
		}
		else if(a == 35 && b == 92)
		{
			return 127;
		}
		else if(a == 35 && b == 93)
		{
			return 128;
		}
		else if(a == 35 && b == 94)
		{
			return 129;
		}
		else if(a == 35 && b == 95)
		{
			return 130;
		}
		else if(a == 35 && b == 96)
		{
			return 131;
		}
		else if(a == 35 && b == 97)
		{
			return 132;
		}
		else if(a == 35 && b == 98)
		{
			return 133;
		}
		else if(a == 35 && b == 99)
		{
			return 134;
		}
		else if(a == 35 && b == 100)
		{
			return 135;
		}
		else if(a == 36 && b == 0)
		{
			return 36;
		}
		else if(a == 36 && b == 1)
		{
			return 37;
		}
		else if(a == 36 && b == 2)
		{
			return 38;
		}
		else if(a == 36 && b == 3)
		{
			return 39;
		}
		else if(a == 36 && b == 4)
		{
			return 40;
		}
		else if(a == 36 && b == 5)
		{
			return 41;
		}
		else if(a == 36 && b == 6)
		{
			return 42;
		}
		else if(a == 36 && b == 7)
		{
			return 43;
		}
		else if(a == 36 && b == 8)
		{
			return 44;
		}
		else if(a == 36 && b == 9)
		{
			return 45;
		}
		else if(a == 36 && b == 10)
		{
			return 46;
		}
		else if(a == 36 && b == 11)
		{
			return 47;
		}
		else if(a == 36 && b == 12)
		{
			return 48;
		}
		else if(a == 36 && b == 13)
		{
			return 49;
		}
		else if(a == 36 && b == 14)
		{
			return 50;
		}
		else if(a == 36 && b == 15)
		{
			return 51;
		}
		else if(a == 36 && b == 16)
		{
			return 52;
		}
		else if(a == 36 && b == 17)
		{
			return 53;
		}
		else if(a == 36 && b == 18)
		{
			return 54;
		}
		else if(a == 36 && b == 19)
		{
			return 55;
		}
		else if(a == 36 && b == 20)
		{
			return 56;
		}
		else if(a == 36 && b == 21)
		{
			return 57;
		}
		else if(a == 36 && b == 22)
		{
			return 58;
		}
		else if(a == 36 && b == 23)
		{
			return 59;
		}
		else if(a == 36 && b == 24)
		{
			return 60;
		}
		else if(a == 36 && b == 25)
		{
			return 61;
		}
		else if(a == 36 && b == 26)
		{
			return 62;
		}
		else if(a == 36 && b == 27)
		{
			return 63;
		}
		else if(a == 36 && b == 28)
		{
			return 64;
		}
		else if(a == 36 && b == 29)
		{
			return 65;
		}
		else if(a == 36 && b == 30)
		{
			return 66;
		}
		else if(a == 36 && b == 31)
		{
			return 67;
		}
		else if(a == 36 && b == 32)
		{
			return 68;
		}
		else if(a == 36 && b == 33)
		{
			return 69;
		}
		else if(a == 36 && b == 34)
		{
			return 70;
		}
		else if(a == 36 && b == 35)
		{
			return 71;
		}
		else if(a == 36 && b == 36)
		{
			return 72;
		}
		else if(a == 36 && b == 37)
		{
			return 73;
		}
		else if(a == 36 && b == 38)
		{
			return 74;
		}
		else if(a == 36 && b == 39)
		{
			return 75;
		}
		else if(a == 36 && b == 40)
		{
			return 76;
		}
		else if(a == 36 && b == 41)
		{
			return 77;
		}
		else if(a == 36 && b == 42)
		{
			return 78;
		}
		else if(a == 36 && b == 43)
		{
			return 79;
		}
		else if(a == 36 && b == 44)
		{
			return 80;
		}
		else if(a == 36 && b == 45)
		{
			return 81;
		}
		else if(a == 36 && b == 46)
		{
			return 82;
		}
		else if(a == 36 && b == 47)
		{
			return 83;
		}
		else if(a == 36 && b == 48)
		{
			return 84;
		}
		else if(a == 36 && b == 49)
		{
			return 85;
		}
		else if(a == 36 && b == 50)
		{
			return 86;
		}
		else if(a == 36 && b == 51)
		{
			return 87;
		}
		else if(a == 36 && b == 52)
		{
			return 88;
		}
		else if(a == 36 && b == 53)
		{
			return 89;
		}
		else if(a == 36 && b == 54)
		{
			return 90;
		}
		else if(a == 36 && b == 55)
		{
			return 91;
		}
		else if(a == 36 && b == 56)
		{
			return 92;
		}
		else if(a == 36 && b == 57)
		{
			return 93;
		}
		else if(a == 36 && b == 58)
		{
			return 94;
		}
		else if(a == 36 && b == 59)
		{
			return 95;
		}
		else if(a == 36 && b == 60)
		{
			return 96;
		}
		else if(a == 36 && b == 61)
		{
			return 97;
		}
		else if(a == 36 && b == 62)
		{
			return 98;
		}
		else if(a == 36 && b == 63)
		{
			return 99;
		}
		else if(a == 36 && b == 64)
		{
			return 100;
		}
		else if(a == 36 && b == 65)
		{
			return 101;
		}
		else if(a == 36 && b == 66)
		{
			return 102;
		}
		else if(a == 36 && b == 67)
		{
			return 103;
		}
		else if(a == 36 && b == 68)
		{
			return 104;
		}
		else if(a == 36 && b == 69)
		{
			return 105;
		}
		else if(a == 36 && b == 70)
		{
			return 106;
		}
		else if(a == 36 && b == 71)
		{
			return 107;
		}
		else if(a == 36 && b == 72)
		{
			return 108;
		}
		else if(a == 36 && b == 73)
		{
			return 109;
		}
		else if(a == 36 && b == 74)
		{
			return 110;
		}
		else if(a == 36 && b == 75)
		{
			return 111;
		}
		else if(a == 36 && b == 76)
		{
			return 112;
		}
		else if(a == 36 && b == 77)
		{
			return 113;
		}
		else if(a == 36 && b == 78)
		{
			return 114;
		}
		else if(a == 36 && b == 79)
		{
			return 115;
		}
		else if(a == 36 && b == 80)
		{
			return 116;
		}
		else if(a == 36 && b == 81)
		{
			return 117;
		}
		else if(a == 36 && b == 82)
		{
			return 118;
		}
		else if(a == 36 && b == 83)
		{
			return 119;
		}
		else if(a == 36 && b == 84)
		{
			return 120;
		}
		else if(a == 36 && b == 85)
		{
			return 121;
		}
		else if(a == 36 && b == 86)
		{
			return 122;
		}
		else if(a == 36 && b == 87)
		{
			return 123;
		}
		else if(a == 36 && b == 88)
		{
			return 124;
		}
		else if(a == 36 && b == 89)
		{
			return 125;
		}
		else if(a == 36 && b == 90)
		{
			return 126;
		}
		else if(a == 36 && b == 91)
		{
			return 127;
		}
		else if(a == 36 && b == 92)
		{
			return 128;
		}
		else if(a == 36 && b == 93)
		{
			return 129;
		}
		else if(a == 36 && b == 94)
		{
			return 130;
		}
		else if(a == 36 && b == 95)
		{
			return 131;
		}
		else if(a == 36 && b == 96)
		{
			return 132;
		}
		else if(a == 36 && b == 97)
		{
			return 133;
		}
		else if(a == 36 && b == 98)
		{
			return 134;
		}
		else if(a == 36 && b == 99)
		{
			return 135;
		}
		else if(a == 36 && b == 100)
		{
			return 136;
		}
		else if(a == 37 && b == 0)
		{
			return 37;
		}
		else if(a == 37 && b == 1)
		{
			return 38;
		}
		else if(a == 37 && b == 2)
		{
			return 39;
		}
		else if(a == 37 && b == 3)
		{
			return 40;
		}
		else if(a == 37 && b == 4)
		{
			return 41;
		}
		else if(a == 37 && b == 5)
		{
			return 42;
		}
		else if(a == 37 && b == 6)
		{
			return 43;
		}
		else if(a == 37 && b == 7)
		{
			return 44;
		}
		else if(a == 37 && b == 8)
		{
			return 45;
		}
		else if(a == 37 && b == 9)
		{
			return 46;
		}
		else if(a == 37 && b == 10)
		{
			return 47;
		}
		else if(a == 37 && b == 11)
		{
			return 48;
		}
		else if(a == 37 && b == 12)
		{
			return 49;
		}
		else if(a == 37 && b == 13)
		{
			return 50;
		}
		else if(a == 37 && b == 14)
		{
			return 51;
		}
		else if(a == 37 && b == 15)
		{
			return 52;
		}
		else if(a == 37 && b == 16)
		{
			return 53;
		}
		else if(a == 37 && b == 17)
		{
			return 54;
		}
		else if(a == 37 && b == 18)
		{
			return 55;
		}
		else if(a == 37 && b == 19)
		{
			return 56;
		}
		else if(a == 37 && b == 20)
		{
			return 57;
		}
		else if(a == 37 && b == 21)
		{
			return 58;
		}
		else if(a == 37 && b == 22)
		{
			return 59;
		}
		else if(a == 37 && b == 23)
		{
			return 60;
		}
		else if(a == 37 && b == 24)
		{
			return 61;
		}
		else if(a == 37 && b == 25)
		{
			return 62;
		}
		else if(a == 37 && b == 26)
		{
			return 63;
		}
		else if(a == 37 && b == 27)
		{
			return 64;
		}
		else if(a == 37 && b == 28)
		{
			return 65;
		}
		else if(a == 37 && b == 29)
		{
			return 66;
		}
		else if(a == 37 && b == 30)
		{
			return 67;
		}
		else if(a == 37 && b == 31)
		{
			return 68;
		}
		else if(a == 37 && b == 32)
		{
			return 69;
		}
		else if(a == 37 && b == 33)
		{
			return 70;
		}
		else if(a == 37 && b == 34)
		{
			return 71;
		}
		else if(a == 37 && b == 35)
		{
			return 72;
		}
		else if(a == 37 && b == 36)
		{
			return 73;
		}
		else if(a == 37 && b == 37)
		{
			return 74;
		}
		else if(a == 37 && b == 38)
		{
			return 75;
		}
		else if(a == 37 && b == 39)
		{
			return 76;
		}
		else if(a == 37 && b == 40)
		{
			return 77;
		}
		else if(a == 37 && b == 41)
		{
			return 78;
		}
		else if(a == 37 && b == 42)
		{
			return 79;
		}
		else if(a == 37 && b == 43)
		{
			return 80;
		}
		else if(a == 37 && b == 44)
		{
			return 81;
		}
		else if(a == 37 && b == 45)
		{
			return 82;
		}
		else if(a == 37 && b == 46)
		{
			return 83;
		}
		else if(a == 37 && b == 47)
		{
			return 84;
		}
		else if(a == 37 && b == 48)
		{
			return 85;
		}
		else if(a == 37 && b == 49)
		{
			return 86;
		}
		else if(a == 37 && b == 50)
		{
			return 87;
		}
		else if(a == 37 && b == 51)
		{
			return 88;
		}
		else if(a == 37 && b == 52)
		{
			return 89;
		}
		else if(a == 37 && b == 53)
		{
			return 90;
		}
		else if(a == 37 && b == 54)
		{
			return 91;
		}
		else if(a == 37 && b == 55)
		{
			return 92;
		}
		else if(a == 37 && b == 56)
		{
			return 93;
		}
		else if(a == 37 && b == 57)
		{
			return 94;
		}
		else if(a == 37 && b == 58)
		{
			return 95;
		}
		else if(a == 37 && b == 59)
		{
			return 96;
		}
		else if(a == 37 && b == 60)
		{
			return 97;
		}
		else if(a == 37 && b == 61)
		{
			return 98;
		}
		else if(a == 37 && b == 62)
		{
			return 99;
		}
		else if(a == 37 && b == 63)
		{
			return 100;
		}
		else if(a == 37 && b == 64)
		{
			return 101;
		}
		else if(a == 37 && b == 65)
		{
			return 102;
		}
		else if(a == 37 && b == 66)
		{
			return 103;
		}
		else if(a == 37 && b == 67)
		{
			return 104;
		}
		else if(a == 37 && b == 68)
		{
			return 105;
		}
		else if(a == 37 && b == 69)
		{
			return 106;
		}
		else if(a == 37 && b == 70)
		{
			return 107;
		}
		else if(a == 37 && b == 71)
		{
			return 108;
		}
		else if(a == 37 && b == 72)
		{
			return 109;
		}
		else if(a == 37 && b == 73)
		{
			return 110;
		}
		else if(a == 37 && b == 74)
		{
			return 111;
		}
		else if(a == 37 && b == 75)
		{
			return 112;
		}
		else if(a == 37 && b == 76)
		{
			return 113;
		}
		else if(a == 37 && b == 77)
		{
			return 114;
		}
		else if(a == 37 && b == 78)
		{
			return 115;
		}
		else if(a == 37 && b == 79)
		{
			return 116;
		}
		else if(a == 37 && b == 80)
		{
			return 117;
		}
		else if(a == 37 && b == 81)
		{
			return 118;
		}
		else if(a == 37 && b == 82)
		{
			return 119;
		}
		else if(a == 37 && b == 83)
		{
			return 120;
		}
		else if(a == 37 && b == 84)
		{
			return 121;
		}
		else if(a == 37 && b == 85)
		{
			return 122;
		}
		else if(a == 37 && b == 86)
		{
			return 123;
		}
		else if(a == 37 && b == 87)
		{
			return 124;
		}
		else if(a == 37 && b == 88)
		{
			return 125;
		}
		else if(a == 37 && b == 89)
		{
			return 126;
		}
		else if(a == 37 && b == 90)
		{
			return 127;
		}
		else if(a == 37 && b == 91)
		{
			return 128;
		}
		else if(a == 37 && b == 92)
		{
			return 129;
		}
		else if(a == 37 && b == 93)
		{
			return 130;
		}
		else if(a == 37 && b == 94)
		{
			return 131;
		}
		else if(a == 37 && b == 95)
		{
			return 132;
		}
		else if(a == 37 && b == 96)
		{
			return 133;
		}
		else if(a == 37 && b == 97)
		{
			return 134;
		}
		else if(a == 37 && b == 98)
		{
			return 135;
		}
		else if(a == 37 && b == 99)
		{
			return 136;
		}
		else if(a == 37 && b == 100)
		{
			return 137;
		}
		else if(a == 38 && b == 0)
		{
			return 38;
		}
		else if(a == 38 && b == 1)
		{
			return 39;
		}
		else if(a == 38 && b == 2)
		{
			return 40;
		}
		else if(a == 38 && b == 3)
		{
			return 41;
		}
		else if(a == 38 && b == 4)
		{
			return 42;
		}
		else if(a == 38 && b == 5)
		{
			return 43;
		}
		else if(a == 38 && b == 6)
		{
			return 44;
		}
		else if(a == 38 && b == 7)
		{
			return 45;
		}
		else if(a == 38 && b == 8)
		{
			return 46;
		}
		else if(a == 38 && b == 9)
		{
			return 47;
		}
		else if(a == 38 && b == 10)
		{
			return 48;
		}
		else if(a == 38 && b == 11)
		{
			return 49;
		}
		else if(a == 38 && b == 12)
		{
			return 50;
		}
		else if(a == 38 && b == 13)
		{
			return 51;
		}
		else if(a == 38 && b == 14)
		{
			return 52;
		}
		else if(a == 38 && b == 15)
		{
			return 53;
		}
		else if(a == 38 && b == 16)
		{
			return 54;
		}
		else if(a == 38 && b == 17)
		{
			return 55;
		}
		else if(a == 38 && b == 18)
		{
			return 56;
		}
		else if(a == 38 && b == 19)
		{
			return 57;
		}
		else if(a == 38 && b == 20)
		{
			return 58;
		}
		else if(a == 38 && b == 21)
		{
			return 59;
		}
		else if(a == 38 && b == 22)
		{
			return 60;
		}
		else if(a == 38 && b == 23)
		{
			return 61;
		}
		else if(a == 38 && b == 24)
		{
			return 62;
		}
		else if(a == 38 && b == 25)
		{
			return 63;
		}
		else if(a == 38 && b == 26)
		{
			return 64;
		}
		else if(a == 38 && b == 27)
		{
			return 65;
		}
		else if(a == 38 && b == 28)
		{
			return 66;
		}
		else if(a == 38 && b == 29)
		{
			return 67;
		}
		else if(a == 38 && b == 30)
		{
			return 68;
		}
		else if(a == 38 && b == 31)
		{
			return 69;
		}
		else if(a == 38 && b == 32)
		{
			return 70;
		}
		else if(a == 38 && b == 33)
		{
			return 71;
		}
		else if(a == 38 && b == 34)
		{
			return 72;
		}
		else if(a == 38 && b == 35)
		{
			return 73;
		}
		else if(a == 38 && b == 36)
		{
			return 74;
		}
		else if(a == 38 && b == 37)
		{
			return 75;
		}
		else if(a == 38 && b == 38)
		{
			return 76;
		}
		else if(a == 38 && b == 39)
		{
			return 77;
		}
		else if(a == 38 && b == 40)
		{
			return 78;
		}
		else if(a == 38 && b == 41)
		{
			return 79;
		}
		else if(a == 38 && b == 42)
		{
			return 80;
		}
		else if(a == 38 && b == 43)
		{
			return 81;
		}
		else if(a == 38 && b == 44)
		{
			return 82;
		}
		else if(a == 38 && b == 45)
		{
			return 83;
		}
		else if(a == 38 && b == 46)
		{
			return 84;
		}
		else if(a == 38 && b == 47)
		{
			return 85;
		}
		else if(a == 38 && b == 48)
		{
			return 86;
		}
		else if(a == 38 && b == 49)
		{
			return 87;
		}
		else if(a == 38 && b == 50)
		{
			return 88;
		}
		else if(a == 38 && b == 51)
		{
			return 89;
		}
		else if(a == 38 && b == 52)
		{
			return 90;
		}
		else if(a == 38 && b == 53)
		{
			return 91;
		}
		else if(a == 38 && b == 54)
		{
			return 92;
		}
		else if(a == 38 && b == 55)
		{
			return 93;
		}
		else if(a == 38 && b == 56)
		{
			return 94;
		}
		else if(a == 38 && b == 57)
		{
			return 95;
		}
		else if(a == 38 && b == 58)
		{
			return 96;
		}
		else if(a == 38 && b == 59)
		{
			return 97;
		}
		else if(a == 38 && b == 60)
		{
			return 98;
		}
		else if(a == 38 && b == 61)
		{
			return 99;
		}
		else if(a == 38 && b == 62)
		{
			return 100;
		}
		else if(a == 38 && b == 63)
		{
			return 101;
		}
		else if(a == 38 && b == 64)
		{
			return 102;
		}
		else if(a == 38 && b == 65)
		{
			return 103;
		}
		else if(a == 38 && b == 66)
		{
			return 104;
		}
		else if(a == 38 && b == 67)
		{
			return 105;
		}
		else if(a == 38 && b == 68)
		{
			return 106;
		}
		else if(a == 38 && b == 69)
		{
			return 107;
		}
		else if(a == 38 && b == 70)
		{
			return 108;
		}
		else if(a == 38 && b == 71)
		{
			return 109;
		}
		else if(a == 38 && b == 72)
		{
			return 110;
		}
		else if(a == 38 && b == 73)
		{
			return 111;
		}
		else if(a == 38 && b == 74)
		{
			return 112;
		}
		else if(a == 38 && b == 75)
		{
			return 113;
		}
		else if(a == 38 && b == 76)
		{
			return 114;
		}
		else if(a == 38 && b == 77)
		{
			return 115;
		}
		else if(a == 38 && b == 78)
		{
			return 116;
		}
		else if(a == 38 && b == 79)
		{
			return 117;
		}
		else if(a == 38 && b == 80)
		{
			return 118;
		}
		else if(a == 38 && b == 81)
		{
			return 119;
		}
		else if(a == 38 && b == 82)
		{
			return 120;
		}
		else if(a == 38 && b == 83)
		{
			return 121;
		}
		else if(a == 38 && b == 84)
		{
			return 122;
		}
		else if(a == 38 && b == 85)
		{
			return 123;
		}
		else if(a == 38 && b == 86)
		{
			return 124;
		}
		else if(a == 38 && b == 87)
		{
			return 125;
		}
		else if(a == 38 && b == 88)
		{
			return 126;
		}
		else if(a == 38 && b == 89)
		{
			return 127;
		}
		else if(a == 38 && b == 90)
		{
			return 128;
		}
		else if(a == 38 && b == 91)
		{
			return 129;
		}
		else if(a == 38 && b == 92)
		{
			return 130;
		}
		else if(a == 38 && b == 93)
		{
			return 131;
		}
		else if(a == 38 && b == 94)
		{
			return 132;
		}
		else if(a == 38 && b == 95)
		{
			return 133;
		}
		else if(a == 38 && b == 96)
		{
			return 134;
		}
		else if(a == 38 && b == 97)
		{
			return 135;
		}
		else if(a == 38 && b == 98)
		{
			return 136;
		}
		else if(a == 38 && b == 99)
		{
			return 137;
		}
		else if(a == 38 && b == 100)
		{
			return 138;
		}
		else if(a == 39 && b == 0)
		{
			return 39;
		}
		else if(a == 39 && b == 1)
		{
			return 40;
		}
		else if(a == 39 && b == 2)
		{
			return 41;
		}
		else if(a == 39 && b == 3)
		{
			return 42;
		}
		else if(a == 39 && b == 4)
		{
			return 43;
		}
		else if(a == 39 && b == 5)
		{
			return 44;
		}
		else if(a == 39 && b == 6)
		{
			return 45;
		}
		else if(a == 39 && b == 7)
		{
			return 46;
		}
		else if(a == 39 && b == 8)
		{
			return 47;
		}
		else if(a == 39 && b == 9)
		{
			return 48;
		}
		else if(a == 39 && b == 10)
		{
			return 49;
		}
		else if(a == 39 && b == 11)
		{
			return 50;
		}
		else if(a == 39 && b == 12)
		{
			return 51;
		}
		else if(a == 39 && b == 13)
		{
			return 52;
		}
		else if(a == 39 && b == 14)
		{
			return 53;
		}
		else if(a == 39 && b == 15)
		{
			return 54;
		}
		else if(a == 39 && b == 16)
		{
			return 55;
		}
		else if(a == 39 && b == 17)
		{
			return 56;
		}
		else if(a == 39 && b == 18)
		{
			return 57;
		}
		else if(a == 39 && b == 19)
		{
			return 58;
		}
		else if(a == 39 && b == 20)
		{
			return 59;
		}
		else if(a == 39 && b == 21)
		{
			return 60;
		}
		else if(a == 39 && b == 22)
		{
			return 61;
		}
		else if(a == 39 && b == 23)
		{
			return 62;
		}
		else if(a == 39 && b == 24)
		{
			return 63;
		}
		else if(a == 39 && b == 25)
		{
			return 64;
		}
		else if(a == 39 && b == 26)
		{
			return 65;
		}
		else if(a == 39 && b == 27)
		{
			return 66;
		}
		else if(a == 39 && b == 28)
		{
			return 67;
		}
		else if(a == 39 && b == 29)
		{
			return 68;
		}
		else if(a == 39 && b == 30)
		{
			return 69;
		}
		else if(a == 39 && b == 31)
		{
			return 70;
		}
		else if(a == 39 && b == 32)
		{
			return 71;
		}
		else if(a == 39 && b == 33)
		{
			return 72;
		}
		else if(a == 39 && b == 34)
		{
			return 73;
		}
		else if(a == 39 && b == 35)
		{
			return 74;
		}
		else if(a == 39 && b == 36)
		{
			return 75;
		}
		else if(a == 39 && b == 37)
		{
			return 76;
		}
		else if(a == 39 && b == 38)
		{
			return 77;
		}
		else if(a == 39 && b == 39)
		{
			return 78;
		}
		else if(a == 39 && b == 40)
		{
			return 79;
		}
		else if(a == 39 && b == 41)
		{
			return 80;
		}
		else if(a == 39 && b == 42)
		{
			return 81;
		}
		else if(a == 39 && b == 43)
		{
			return 82;
		}
		else if(a == 39 && b == 44)
		{
			return 83;
		}
		else if(a == 39 && b == 45)
		{
			return 84;
		}
		else if(a == 39 && b == 46)
		{
			return 85;
		}
		else if(a == 39 && b == 47)
		{
			return 86;
		}
		else if(a == 39 && b == 48)
		{
			return 87;
		}
		else if(a == 39 && b == 49)
		{
			return 88;
		}
		else if(a == 39 && b == 50)
		{
			return 89;
		}
		else if(a == 39 && b == 51)
		{
			return 90;
		}
		else if(a == 39 && b == 52)
		{
			return 91;
		}
		else if(a == 39 && b == 53)
		{
			return 92;
		}
		else if(a == 39 && b == 54)
		{
			return 93;
		}
		else if(a == 39 && b == 55)
		{
			return 94;
		}
		else if(a == 39 && b == 56)
		{
			return 95;
		}
		else if(a == 39 && b == 57)
		{
			return 96;
		}
		else if(a == 39 && b == 58)
		{
			return 97;
		}
		else if(a == 39 && b == 59)
		{
			return 98;
		}
		else if(a == 39 && b == 60)
		{
			return 99;
		}
		else if(a == 39 && b == 61)
		{
			return 100;
		}
		else if(a == 39 && b == 62)
		{
			return 101;
		}
		else if(a == 39 && b == 63)
		{
			return 102;
		}
		else if(a == 39 && b == 64)
		{
			return 103;
		}
		else if(a == 39 && b == 65)
		{
			return 104;
		}
		else if(a == 39 && b == 66)
		{
			return 105;
		}
		else if(a == 39 && b == 67)
		{
			return 106;
		}
		else if(a == 39 && b == 68)
		{
			return 107;
		}
		else if(a == 39 && b == 69)
		{
			return 108;
		}
		else if(a == 39 && b == 70)
		{
			return 109;
		}
		else if(a == 39 && b == 71)
		{
			return 110;
		}
		else if(a == 39 && b == 72)
		{
			return 111;
		}
		else if(a == 39 && b == 73)
		{
			return 112;
		}
		else if(a == 39 && b == 74)
		{
			return 113;
		}
		else if(a == 39 && b == 75)
		{
			return 114;
		}
		else if(a == 39 && b == 76)
		{
			return 115;
		}
		else if(a == 39 && b == 77)
		{
			return 116;
		}
		else if(a == 39 && b == 78)
		{
			return 117;
		}
		else if(a == 39 && b == 79)
		{
			return 118;
		}
		else if(a == 39 && b == 80)
		{
			return 119;
		}
		else if(a == 39 && b == 81)
		{
			return 120;
		}
		else if(a == 39 && b == 82)
		{
			return 121;
		}
		else if(a == 39 && b == 83)
		{
			return 122;
		}
		else if(a == 39 && b == 84)
		{
			return 123;
		}
		else if(a == 39 && b == 85)
		{
			return 124;
		}
		else if(a == 39 && b == 86)
		{
			return 125;
		}
		else if(a == 39 && b == 87)
		{
			return 126;
		}
		else if(a == 39 && b == 88)
		{
			return 127;
		}
		else if(a == 39 && b == 89)
		{
			return 128;
		}
		else if(a == 39 && b == 90)
		{
			return 129;
		}
		else if(a == 39 && b == 91)
		{
			return 130;
		}
		else if(a == 39 && b == 92)
		{
			return 131;
		}
		else if(a == 39 && b == 93)
		{
			return 132;
		}
		else if(a == 39 && b == 94)
		{
			return 133;
		}
		else if(a == 39 && b == 95)
		{
			return 134;
		}
		else if(a == 39 && b == 96)
		{
			return 135;
		}
		else if(a == 39 && b == 97)
		{
			return 136;
		}
		else if(a == 39 && b == 98)
		{
			return 137;
		}
		else if(a == 39 && b == 99)
		{
			return 138;
		}
		else if(a == 39 && b == 100)
		{
			return 139;
		}
		else if(a == 40 && b == 0)
		{
			return 40;
		}
		else if(a == 40 && b == 1)
		{
			return 41;
		}
		else if(a == 40 && b == 2)
		{
			return 42;
		}
		else if(a == 40 && b == 3)
		{
			return 43;
		}
		else if(a == 40 && b == 4)
		{
			return 44;
		}
		else if(a == 40 && b == 5)
		{
			return 45;
		}
		else if(a == 40 && b == 6)
		{
			return 46;
		}
		else if(a == 40 && b == 7)
		{
			return 47;
		}
		else if(a == 40 && b == 8)
		{
			return 48;
		}
		else if(a == 40 && b == 9)
		{
			return 49;
		}
		else if(a == 40 && b == 10)
		{
			return 50;
		}
		else if(a == 40 && b == 11)
		{
			return 51;
		}
		else if(a == 40 && b == 12)
		{
			return 52;
		}
		else if(a == 40 && b == 13)
		{
			return 53;
		}
		else if(a == 40 && b == 14)
		{
			return 54;
		}
		else if(a == 40 && b == 15)
		{
			return 55;
		}
		else if(a == 40 && b == 16)
		{
			return 56;
		}
		else if(a == 40 && b == 17)
		{
			return 57;
		}
		else if(a == 40 && b == 18)
		{
			return 58;
		}
		else if(a == 40 && b == 19)
		{
			return 59;
		}
		else if(a == 40 && b == 20)
		{
			return 60;
		}
		else if(a == 40 && b == 21)
		{
			return 61;
		}
		else if(a == 40 && b == 22)
		{
			return 62;
		}
		else if(a == 40 && b == 23)
		{
			return 63;
		}
		else if(a == 40 && b == 24)
		{
			return 64;
		}
		else if(a == 40 && b == 25)
		{
			return 65;
		}
		else if(a == 40 && b == 26)
		{
			return 66;
		}
		else if(a == 40 && b == 27)
		{
			return 67;
		}
		else if(a == 40 && b == 28)
		{
			return 68;
		}
		else if(a == 40 && b == 29)
		{
			return 69;
		}
		else if(a == 40 && b == 30)
		{
			return 70;
		}
		else if(a == 40 && b == 31)
		{
			return 71;
		}
		else if(a == 40 && b == 32)
		{
			return 72;
		}
		else if(a == 40 && b == 33)
		{
			return 73;
		}
		else if(a == 40 && b == 34)
		{
			return 74;
		}
		else if(a == 40 && b == 35)
		{
			return 75;
		}
		else if(a == 40 && b == 36)
		{
			return 76;
		}
		else if(a == 40 && b == 37)
		{
			return 77;
		}
		else if(a == 40 && b == 38)
		{
			return 78;
		}
		else if(a == 40 && b == 39)
		{
			return 79;
		}
		else if(a == 40 && b == 40)
		{
			return 80;
		}
		else if(a == 40 && b == 41)
		{
			return 81;
		}
		else if(a == 40 && b == 42)
		{
			return 82;
		}
		else if(a == 40 && b == 43)
		{
			return 83;
		}
		else if(a == 40 && b == 44)
		{
			return 84;
		}
		else if(a == 40 && b == 45)
		{
			return 85;
		}
		else if(a == 40 && b == 46)
		{
			return 86;
		}
		else if(a == 40 && b == 47)
		{
			return 87;
		}
		else if(a == 40 && b == 48)
		{
			return 88;
		}
		else if(a == 40 && b == 49)
		{
			return 89;
		}
		else if(a == 40 && b == 50)
		{
			return 90;
		}
		else if(a == 40 && b == 51)
		{
			return 91;
		}
		else if(a == 40 && b == 52)
		{
			return 92;
		}
		else if(a == 40 && b == 53)
		{
			return 93;
		}
		else if(a == 40 && b == 54)
		{
			return 94;
		}
		else if(a == 40 && b == 55)
		{
			return 95;
		}
		else if(a == 40 && b == 56)
		{
			return 96;
		}
		else if(a == 40 && b == 57)
		{
			return 97;
		}
		else if(a == 40 && b == 58)
		{
			return 98;
		}
		else if(a == 40 && b == 59)
		{
			return 99;
		}
		else if(a == 40 && b == 60)
		{
			return 100;
		}
		else if(a == 40 && b == 61)
		{
			return 101;
		}
		else if(a == 40 && b == 62)
		{
			return 102;
		}
		else if(a == 40 && b == 63)
		{
			return 103;
		}
		else if(a == 40 && b == 64)
		{
			return 104;
		}
		else if(a == 40 && b == 65)
		{
			return 105;
		}
		else if(a == 40 && b == 66)
		{
			return 106;
		}
		else if(a == 40 && b == 67)
		{
			return 107;
		}
		else if(a == 40 && b == 68)
		{
			return 108;
		}
		else if(a == 40 && b == 69)
		{
			return 109;
		}
		else if(a == 40 && b == 70)
		{
			return 110;
		}
		else if(a == 40 && b == 71)
		{
			return 111;
		}
		else if(a == 40 && b == 72)
		{
			return 112;
		}
		else if(a == 40 && b == 73)
		{
			return 113;
		}
		else if(a == 40 && b == 74)
		{
			return 114;
		}
		else if(a == 40 && b == 75)
		{
			return 115;
		}
		else if(a == 40 && b == 76)
		{
			return 116;
		}
		else if(a == 40 && b == 77)
		{
			return 117;
		}
		else if(a == 40 && b == 78)
		{
			return 118;
		}
		else if(a == 40 && b == 79)
		{
			return 119;
		}
		else if(a == 40 && b == 80)
		{
			return 120;
		}
		else if(a == 40 && b == 81)
		{
			return 121;
		}
		else if(a == 40 && b == 82)
		{
			return 122;
		}
		else if(a == 40 && b == 83)
		{
			return 123;
		}
		else if(a == 40 && b == 84)
		{
			return 124;
		}
		else if(a == 40 && b == 85)
		{
			return 125;
		}
		else if(a == 40 && b == 86)
		{
			return 126;
		}
		else if(a == 40 && b == 87)
		{
			return 127;
		}
		else if(a == 40 && b == 88)
		{
			return 128;
		}
		else if(a == 40 && b == 89)
		{
			return 129;
		}
		else if(a == 40 && b == 90)
		{
			return 130;
		}
		else if(a == 40 && b == 91)
		{
			return 131;
		}
		else if(a == 40 && b == 92)
		{
			return 132;
		}
		else if(a == 40 && b == 93)
		{
			return 133;
		}
		else if(a == 40 && b == 94)
		{
			return 134;
		}
		else if(a == 40 && b == 95)
		{
			return 135;
		}
		else if(a == 40 && b == 96)
		{
			return 136;
		}
		else if(a == 40 && b == 97)
		{
			return 137;
		}
		else if(a == 40 && b == 98)
		{
			return 138;
		}
		else if(a == 40 && b == 99)
		{
			return 139;
		}
		else if(a == 40 && b == 100)
		{
			return 140;
		}
		else if(a == 41 && b == 0)
		{
			return 41;
		}
		else if(a == 41 && b == 1)
		{
			return 42;
		}
		else if(a == 41 && b == 2)
		{
			return 43;
		}
		else if(a == 41 && b == 3)
		{
			return 44;
		}
		else if(a == 41 && b == 4)
		{
			return 45;
		}
		else if(a == 41 && b == 5)
		{
			return 46;
		}
		else if(a == 41 && b == 6)
		{
			return 47;
		}
		else if(a == 41 && b == 7)
		{
			return 48;
		}
		else if(a == 41 && b == 8)
		{
			return 49;
		}
		else if(a == 41 && b == 9)
		{
			return 50;
		}
		else if(a == 41 && b == 10)
		{
			return 51;
		}
		else if(a == 41 && b == 11)
		{
			return 52;
		}
		else if(a == 41 && b == 12)
		{
			return 53;
		}
		else if(a == 41 && b == 13)
		{
			return 54;
		}
		else if(a == 41 && b == 14)
		{
			return 55;
		}
		else if(a == 41 && b == 15)
		{
			return 56;
		}
		else if(a == 41 && b == 16)
		{
			return 57;
		}
		else if(a == 41 && b == 17)
		{
			return 58;
		}
		else if(a == 41 && b == 18)
		{
			return 59;
		}
		else if(a == 41 && b == 19)
		{
			return 60;
		}
		else if(a == 41 && b == 20)
		{
			return 61;
		}
		else if(a == 41 && b == 21)
		{
			return 62;
		}
		else if(a == 41 && b == 22)
		{
			return 63;
		}
		else if(a == 41 && b == 23)
		{
			return 64;
		}
		else if(a == 41 && b == 24)
		{
			return 65;
		}
		else if(a == 41 && b == 25)
		{
			return 66;
		}
		else if(a == 41 && b == 26)
		{
			return 67;
		}
		else if(a == 41 && b == 27)
		{
			return 68;
		}
		else if(a == 41 && b == 28)
		{
			return 69;
		}
		else if(a == 41 && b == 29)
		{
			return 70;
		}
		else if(a == 41 && b == 30)
		{
			return 71;
		}
		else if(a == 41 && b == 31)
		{
			return 72;
		}
		else if(a == 41 && b == 32)
		{
			return 73;
		}
		else if(a == 41 && b == 33)
		{
			return 74;
		}
		else if(a == 41 && b == 34)
		{
			return 75;
		}
		else if(a == 41 && b == 35)
		{
			return 76;
		}
		else if(a == 41 && b == 36)
		{
			return 77;
		}
		else if(a == 41 && b == 37)
		{
			return 78;
		}
		else if(a == 41 && b == 38)
		{
			return 79;
		}
		else if(a == 41 && b == 39)
		{
			return 80;
		}
		else if(a == 41 && b == 40)
		{
			return 81;
		}
		else if(a == 41 && b == 41)
		{
			return 82;
		}
		else if(a == 41 && b == 42)
		{
			return 83;
		}
		else if(a == 41 && b == 43)
		{
			return 84;
		}
		else if(a == 41 && b == 44)
		{
			return 85;
		}
		else if(a == 41 && b == 45)
		{
			return 86;
		}
		else if(a == 41 && b == 46)
		{
			return 87;
		}
		else if(a == 41 && b == 47)
		{
			return 88;
		}
		else if(a == 41 && b == 48)
		{
			return 89;
		}
		else if(a == 41 && b == 49)
		{
			return 90;
		}
		else if(a == 41 && b == 50)
		{
			return 91;
		}
		else if(a == 41 && b == 51)
		{
			return 92;
		}
		else if(a == 41 && b == 52)
		{
			return 93;
		}
		else if(a == 41 && b == 53)
		{
			return 94;
		}
		else if(a == 41 && b == 54)
		{
			return 95;
		}
		else if(a == 41 && b == 55)
		{
			return 96;
		}
		else if(a == 41 && b == 56)
		{
			return 97;
		}
		else if(a == 41 && b == 57)
		{
			return 98;
		}
		else if(a == 41 && b == 58)
		{
			return 99;
		}
		else if(a == 41 && b == 59)
		{
			return 100;
		}
		else if(a == 41 && b == 60)
		{
			return 101;
		}
		else if(a == 41 && b == 61)
		{
			return 102;
		}
		else if(a == 41 && b == 62)
		{
			return 103;
		}
		else if(a == 41 && b == 63)
		{
			return 104;
		}
		else if(a == 41 && b == 64)
		{
			return 105;
		}
		else if(a == 41 && b == 65)
		{
			return 106;
		}
		else if(a == 41 && b == 66)
		{
			return 107;
		}
		else if(a == 41 && b == 67)
		{
			return 108;
		}
		else if(a == 41 && b == 68)
		{
			return 109;
		}
		else if(a == 41 && b == 69)
		{
			return 110;
		}
		else if(a == 41 && b == 70)
		{
			return 111;
		}
		else if(a == 41 && b == 71)
		{
			return 112;
		}
		else if(a == 41 && b == 72)
		{
			return 113;
		}
		else if(a == 41 && b == 73)
		{
			return 114;
		}
		else if(a == 41 && b == 74)
		{
			return 115;
		}
		else if(a == 41 && b == 75)
		{
			return 116;
		}
		else if(a == 41 && b == 76)
		{
			return 117;
		}
		else if(a == 41 && b == 77)
		{
			return 118;
		}
		else if(a == 41 && b == 78)
		{
			return 119;
		}
		else if(a == 41 && b == 79)
		{
			return 120;
		}
		else if(a == 41 && b == 80)
		{
			return 121;
		}
		else if(a == 41 && b == 81)
		{
			return 122;
		}
		else if(a == 41 && b == 82)
		{
			return 123;
		}
		else if(a == 41 && b == 83)
		{
			return 124;
		}
		else if(a == 41 && b == 84)
		{
			return 125;
		}
		else if(a == 41 && b == 85)
		{
			return 126;
		}
		else if(a == 41 && b == 86)
		{
			return 127;
		}
		else if(a == 41 && b == 87)
		{
			return 128;
		}
		else if(a == 41 && b == 88)
		{
			return 129;
		}
		else if(a == 41 && b == 89)
		{
			return 130;
		}
		else if(a == 41 && b == 90)
		{
			return 131;
		}
		else if(a == 41 && b == 91)
		{
			return 132;
		}
		else if(a == 41 && b == 92)
		{
			return 133;
		}
		else if(a == 41 && b == 93)
		{
			return 134;
		}
		else if(a == 41 && b == 94)
		{
			return 135;
		}
		else if(a == 41 && b == 95)
		{
			return 136;
		}
		else if(a == 41 && b == 96)
		{
			return 137;
		}
		else if(a == 41 && b == 97)
		{
			return 138;
		}
		else if(a == 41 && b == 98)
		{
			return 139;
		}
		else if(a == 41 && b == 99)
		{
			return 140;
		}
		else if(a == 41 && b == 100)
		{
			return 141;
		}
		else if(a == 42 && b == 0)
		{
			return 42;
		}
		else if(a == 42 && b == 1)
		{
			return 43;
		}
		else if(a == 42 && b == 2)
		{
			return 44;
		}
		else if(a == 42 && b == 3)
		{
			return 45;
		}
		else if(a == 42 && b == 4)
		{
			return 46;
		}
		else if(a == 42 && b == 5)
		{
			return 47;
		}
		else if(a == 42 && b == 6)
		{
			return 48;
		}
		else if(a == 42 && b == 7)
		{
			return 49;
		}
		else if(a == 42 && b == 8)
		{
			return 50;
		}
		else if(a == 42 && b == 9)
		{
			return 51;
		}
		else if(a == 42 && b == 10)
		{
			return 52;
		}
		else if(a == 42 && b == 11)
		{
			return 53;
		}
		else if(a == 42 && b == 12)
		{
			return 54;
		}
		else if(a == 42 && b == 13)
		{
			return 55;
		}
		else if(a == 42 && b == 14)
		{
			return 56;
		}
		else if(a == 42 && b == 15)
		{
			return 57;
		}
		else if(a == 42 && b == 16)
		{
			return 58;
		}
		else if(a == 42 && b == 17)
		{
			return 59;
		}
		else if(a == 42 && b == 18)
		{
			return 60;
		}
		else if(a == 42 && b == 19)
		{
			return 61;
		}
		else if(a == 42 && b == 20)
		{
			return 62;
		}
		else if(a == 42 && b == 21)
		{
			return 63;
		}
		else if(a == 42 && b == 22)
		{
			return 64;
		}
		else if(a == 42 && b == 23)
		{
			return 65;
		}
		else if(a == 42 && b == 24)
		{
			return 66;
		}
		else if(a == 42 && b == 25)
		{
			return 67;
		}
		else if(a == 42 && b == 26)
		{
			return 68;
		}
		else if(a == 42 && b == 27)
		{
			return 69;
		}
		else if(a == 42 && b == 28)
		{
			return 70;
		}
		else if(a == 42 && b == 29)
		{
			return 71;
		}
		else if(a == 42 && b == 30)
		{
			return 72;
		}
		else if(a == 42 && b == 31)
		{
			return 73;
		}
		else if(a == 42 && b == 32)
		{
			return 74;
		}
		else if(a == 42 && b == 33)
		{
			return 75;
		}
		else if(a == 42 && b == 34)
		{
			return 76;
		}
		else if(a == 42 && b == 35)
		{
			return 77;
		}
		else if(a == 42 && b == 36)
		{
			return 78;
		}
		else if(a == 42 && b == 37)
		{
			return 79;
		}
		else if(a == 42 && b == 38)
		{
			return 80;
		}
		else if(a == 42 && b == 39)
		{
			return 81;
		}
		else if(a == 42 && b == 40)
		{
			return 82;
		}
		else if(a == 42 && b == 41)
		{
			return 83;
		}
		else if(a == 42 && b == 42)
		{
			return 84;
		}
		else if(a == 42 && b == 43)
		{
			return 85;
		}
		else if(a == 42 && b == 44)
		{
			return 86;
		}
		else if(a == 42 && b == 45)
		{
			return 87;
		}
		else if(a == 42 && b == 46)
		{
			return 88;
		}
		else if(a == 42 && b == 47)
		{
			return 89;
		}
		else if(a == 42 && b == 48)
		{
			return 90;
		}
		else if(a == 42 && b == 49)
		{
			return 91;
		}
		else if(a == 42 && b == 50)
		{
			return 92;
		}
		else if(a == 42 && b == 51)
		{
			return 93;
		}
		else if(a == 42 && b == 52)
		{
			return 94;
		}
		else if(a == 42 && b == 53)
		{
			return 95;
		}
		else if(a == 42 && b == 54)
		{
			return 96;
		}
		else if(a == 42 && b == 55)
		{
			return 97;
		}
		else if(a == 42 && b == 56)
		{
			return 98;
		}
		else if(a == 42 && b == 57)
		{
			return 99;
		}
		else if(a == 42 && b == 58)
		{
			return 100;
		}
		else if(a == 42 && b == 59)
		{
			return 101;
		}
		else if(a == 42 && b == 60)
		{
			return 102;
		}
		else if(a == 42 && b == 61)
		{
			return 103;
		}
		else if(a == 42 && b == 62)
		{
			return 104;
		}
		else if(a == 42 && b == 63)
		{
			return 105;
		}
		else if(a == 42 && b == 64)
		{
			return 106;
		}
		else if(a == 42 && b == 65)
		{
			return 107;
		}
		else if(a == 42 && b == 66)
		{
			return 108;
		}
		else if(a == 42 && b == 67)
		{
			return 109;
		}
		else if(a == 42 && b == 68)
		{
			return 110;
		}
		else if(a == 42 && b == 69)
		{
			return 111;
		}
		else if(a == 42 && b == 70)
		{
			return 112;
		}
		else if(a == 42 && b == 71)
		{
			return 113;
		}
		else if(a == 42 && b == 72)
		{
			return 114;
		}
		else if(a == 42 && b == 73)
		{
			return 115;
		}
		else if(a == 42 && b == 74)
		{
			return 116;
		}
		else if(a == 42 && b == 75)
		{
			return 117;
		}
		else if(a == 42 && b == 76)
		{
			return 118;
		}
		else if(a == 42 && b == 77)
		{
			return 119;
		}
		else if(a == 42 && b == 78)
		{
			return 120;
		}
		else if(a == 42 && b == 79)
		{
			return 121;
		}
		else if(a == 42 && b == 80)
		{
			return 122;
		}
		else if(a == 42 && b == 81)
		{
			return 123;
		}
		else if(a == 42 && b == 82)
		{
			return 124;
		}
		else if(a == 42 && b == 83)
		{
			return 125;
		}
		else if(a == 42 && b == 84)
		{
			return 126;
		}
		else if(a == 42 && b == 85)
		{
			return 127;
		}
		else if(a == 42 && b == 86)
		{
			return 128;
		}
		else if(a == 42 && b == 87)
		{
			return 129;
		}
		else if(a == 42 && b == 88)
		{
			return 130;
		}
		else if(a == 42 && b == 89)
		{
			return 131;
		}
		else if(a == 42 && b == 90)
		{
			return 132;
		}
		else if(a == 42 && b == 91)
		{
			return 133;
		}
		else if(a == 42 && b == 92)
		{
			return 134;
		}
		else if(a == 42 && b == 93)
		{
			return 135;
		}
		else if(a == 42 && b == 94)
		{
			return 136;
		}
		else if(a == 42 && b == 95)
		{
			return 137;
		}
		else if(a == 42 && b == 96)
		{
			return 138;
		}
		else if(a == 42 && b == 97)
		{
			return 139;
		}
		else if(a == 42 && b == 98)
		{
			return 140;
		}
		else if(a == 42 && b == 99)
		{
			return 141;
		}
		else if(a == 42 && b == 100)
		{
			return 142;
		}
		else if(a == 43 && b == 0)
		{
			return 43;
		}
		else if(a == 43 && b == 1)
		{
			return 44;
		}
		else if(a == 43 && b == 2)
		{
			return 45;
		}
		else if(a == 43 && b == 3)
		{
			return 46;
		}
		else if(a == 43 && b == 4)
		{
			return 47;
		}
		else if(a == 43 && b == 5)
		{
			return 48;
		}
		else if(a == 43 && b == 6)
		{
			return 49;
		}
		else if(a == 43 && b == 7)
		{
			return 50;
		}
		else if(a == 43 && b == 8)
		{
			return 51;
		}
		else if(a == 43 && b == 9)
		{
			return 52;
		}
		else if(a == 43 && b == 10)
		{
			return 53;
		}
		else if(a == 43 && b == 11)
		{
			return 54;
		}
		else if(a == 43 && b == 12)
		{
			return 55;
		}
		else if(a == 43 && b == 13)
		{
			return 56;
		}
		else if(a == 43 && b == 14)
		{
			return 57;
		}
		else if(a == 43 && b == 15)
		{
			return 58;
		}
		else if(a == 43 && b == 16)
		{
			return 59;
		}
		else if(a == 43 && b == 17)
		{
			return 60;
		}
		else if(a == 43 && b == 18)
		{
			return 61;
		}
		else if(a == 43 && b == 19)
		{
			return 62;
		}
		else if(a == 43 && b == 20)
		{
			return 63;
		}
		else if(a == 43 && b == 21)
		{
			return 64;
		}
		else if(a == 43 && b == 22)
		{
			return 65;
		}
		else if(a == 43 && b == 23)
		{
			return 66;
		}
		else if(a == 43 && b == 24)
		{
			return 67;
		}
		else if(a == 43 && b == 25)
		{
			return 68;
		}
		else if(a == 43 && b == 26)
		{
			return 69;
		}
		else if(a == 43 && b == 27)
		{
			return 70;
		}
		else if(a == 43 && b == 28)
		{
			return 71;
		}
		else if(a == 43 && b == 29)
		{
			return 72;
		}
		else if(a == 43 && b == 30)
		{
			return 73;
		}
		else if(a == 43 && b == 31)
		{
			return 74;
		}
		else if(a == 43 && b == 32)
		{
			return 75;
		}
		else if(a == 43 && b == 33)
		{
			return 76;
		}
		else if(a == 43 && b == 34)
		{
			return 77;
		}
		else if(a == 43 && b == 35)
		{
			return 78;
		}
		else if(a == 43 && b == 36)
		{
			return 79;
		}
		else if(a == 43 && b == 37)
		{
			return 80;
		}
		else if(a == 43 && b == 38)
		{
			return 81;
		}
		else if(a == 43 && b == 39)
		{
			return 82;
		}
		else if(a == 43 && b == 40)
		{
			return 83;
		}
		else if(a == 43 && b == 41)
		{
			return 84;
		}
		else if(a == 43 && b == 42)
		{
			return 85;
		}
		else if(a == 43 && b == 43)
		{
			return 86;
		}
		else if(a == 43 && b == 44)
		{
			return 87;
		}
		else if(a == 43 && b == 45)
		{
			return 88;
		}
		else if(a == 43 && b == 46)
		{
			return 89;
		}
		else if(a == 43 && b == 47)
		{
			return 90;
		}
		else if(a == 43 && b == 48)
		{
			return 91;
		}
		else if(a == 43 && b == 49)
		{
			return 92;
		}
		else if(a == 43 && b == 50)
		{
			return 93;
		}
		else if(a == 43 && b == 51)
		{
			return 94;
		}
		else if(a == 43 && b == 52)
		{
			return 95;
		}
		else if(a == 43 && b == 53)
		{
			return 96;
		}
		else if(a == 43 && b == 54)
		{
			return 97;
		}
		else if(a == 43 && b == 55)
		{
			return 98;
		}
		else if(a == 43 && b == 56)
		{
			return 99;
		}
		else if(a == 43 && b == 57)
		{
			return 100;
		}
		else if(a == 43 && b == 58)
		{
			return 101;
		}
		else if(a == 43 && b == 59)
		{
			return 102;
		}
		else if(a == 43 && b == 60)
		{
			return 103;
		}
		else if(a == 43 && b == 61)
		{
			return 104;
		}
		else if(a == 43 && b == 62)
		{
			return 105;
		}
		else if(a == 43 && b == 63)
		{
			return 106;
		}
		else if(a == 43 && b == 64)
		{
			return 107;
		}
		else if(a == 43 && b == 65)
		{
			return 108;
		}
		else if(a == 43 && b == 66)
		{
			return 109;
		}
		else if(a == 43 && b == 67)
		{
			return 110;
		}
		else if(a == 43 && b == 68)
		{
			return 111;
		}
		else if(a == 43 && b == 69)
		{
			return 112;
		}
		else if(a == 43 && b == 70)
		{
			return 113;
		}
		else if(a == 43 && b == 71)
		{
			return 114;
		}
		else if(a == 43 && b == 72)
		{
			return 115;
		}
		else if(a == 43 && b == 73)
		{
			return 116;
		}
		else if(a == 43 && b == 74)
		{
			return 117;
		}
		else if(a == 43 && b == 75)
		{
			return 118;
		}
		else if(a == 43 && b == 76)
		{
			return 119;
		}
		else if(a == 43 && b == 77)
		{
			return 120;
		}
		else if(a == 43 && b == 78)
		{
			return 121;
		}
		else if(a == 43 && b == 79)
		{
			return 122;
		}
		else if(a == 43 && b == 80)
		{
			return 123;
		}
		else if(a == 43 && b == 81)
		{
			return 124;
		}
		else if(a == 43 && b == 82)
		{
			return 125;
		}
		else if(a == 43 && b == 83)
		{
			return 126;
		}
		else if(a == 43 && b == 84)
		{
			return 127;
		}
		else if(a == 43 && b == 85)
		{
			return 128;
		}
		else if(a == 43 && b == 86)
		{
			return 129;
		}
		else if(a == 43 && b == 87)
		{
			return 130;
		}
		else if(a == 43 && b == 88)
		{
			return 131;
		}
		else if(a == 43 && b == 89)
		{
			return 132;
		}
		else if(a == 43 && b == 90)
		{
			return 133;
		}
		else if(a == 43 && b == 91)
		{
			return 134;
		}
		else if(a == 43 && b == 92)
		{
			return 135;
		}
		else if(a == 43 && b == 93)
		{
			return 136;
		}
		else if(a == 43 && b == 94)
		{
			return 137;
		}
		else if(a == 43 && b == 95)
		{
			return 138;
		}
		else if(a == 43 && b == 96)
		{
			return 139;
		}
		else if(a == 43 && b == 97)
		{
			return 140;
		}
		else if(a == 43 && b == 98)
		{
			return 141;
		}
		else if(a == 43 && b == 99)
		{
			return 142;
		}
		else if(a == 43 && b == 100)
		{
			return 143;
		}
		else if(a == 44 && b == 0)
		{
			return 44;
		}
		else if(a == 44 && b == 1)
		{
			return 45;
		}
		else if(a == 44 && b == 2)
		{
			return 46;
		}
		else if(a == 44 && b == 3)
		{
			return 47;
		}
		else if(a == 44 && b == 4)
		{
			return 48;
		}
		else if(a == 44 && b == 5)
		{
			return 49;
		}
		else if(a == 44 && b == 6)
		{
			return 50;
		}
		else if(a == 44 && b == 7)
		{
			return 51;
		}
		else if(a == 44 && b == 8)
		{
			return 52;
		}
		else if(a == 44 && b == 9)
		{
			return 53;
		}
		else if(a == 44 && b == 10)
		{
			return 54;
		}
		else if(a == 44 && b == 11)
		{
			return 55;
		}
		else if(a == 44 && b == 12)
		{
			return 56;
		}
		else if(a == 44 && b == 13)
		{
			return 57;
		}
		else if(a == 44 && b == 14)
		{
			return 58;
		}
		else if(a == 44 && b == 15)
		{
			return 59;
		}
		else if(a == 44 && b == 16)
		{
			return 60;
		}
		else if(a == 44 && b == 17)
		{
			return 61;
		}
		else if(a == 44 && b == 18)
		{
			return 62;
		}
		else if(a == 44 && b == 19)
		{
			return 63;
		}
		else if(a == 44 && b == 20)
		{
			return 64;
		}
		else if(a == 44 && b == 21)
		{
			return 65;
		}
		else if(a == 44 && b == 22)
		{
			return 66;
		}
		else if(a == 44 && b == 23)
		{
			return 67;
		}
		else if(a == 44 && b == 24)
		{
			return 68;
		}
		else if(a == 44 && b == 25)
		{
			return 69;
		}
		else if(a == 44 && b == 26)
		{
			return 70;
		}
		else if(a == 44 && b == 27)
		{
			return 71;
		}
		else if(a == 44 && b == 28)
		{
			return 72;
		}
		else if(a == 44 && b == 29)
		{
			return 73;
		}
		else if(a == 44 && b == 30)
		{
			return 74;
		}
		else if(a == 44 && b == 31)
		{
			return 75;
		}
		else if(a == 44 && b == 32)
		{
			return 76;
		}
		else if(a == 44 && b == 33)
		{
			return 77;
		}
		else if(a == 44 && b == 34)
		{
			return 78;
		}
		else if(a == 44 && b == 35)
		{
			return 79;
		}
		else if(a == 44 && b == 36)
		{
			return 80;
		}
		else if(a == 44 && b == 37)
		{
			return 81;
		}
		else if(a == 44 && b == 38)
		{
			return 82;
		}
		else if(a == 44 && b == 39)
		{
			return 83;
		}
		else if(a == 44 && b == 40)
		{
			return 84;
		}
		else if(a == 44 && b == 41)
		{
			return 85;
		}
		else if(a == 44 && b == 42)
		{
			return 86;
		}
		else if(a == 44 && b == 43)
		{
			return 87;
		}
		else if(a == 44 && b == 44)
		{
			return 88;
		}
		else if(a == 44 && b == 45)
		{
			return 89;
		}
		else if(a == 44 && b == 46)
		{
			return 90;
		}
		else if(a == 44 && b == 47)
		{
			return 91;
		}
		else if(a == 44 && b == 48)
		{
			return 92;
		}
		else if(a == 44 && b == 49)
		{
			return 93;
		}
		else if(a == 44 && b == 50)
		{
			return 94;
		}
		else if(a == 44 && b == 51)
		{
			return 95;
		}
		else if(a == 44 && b == 52)
		{
			return 96;
		}
		else if(a == 44 && b == 53)
		{
			return 97;
		}
		else if(a == 44 && b == 54)
		{
			return 98;
		}
		else if(a == 44 && b == 55)
		{
			return 99;
		}
		else if(a == 44 && b == 56)
		{
			return 100;
		}
		else if(a == 44 && b == 57)
		{
			return 101;
		}
		else if(a == 44 && b == 58)
		{
			return 102;
		}
		else if(a == 44 && b == 59)
		{
			return 103;
		}
		else if(a == 44 && b == 60)
		{
			return 104;
		}
		else if(a == 44 && b == 61)
		{
			return 105;
		}
		else if(a == 44 && b == 62)
		{
			return 106;
		}
		else if(a == 44 && b == 63)
		{
			return 107;
		}
		else if(a == 44 && b == 64)
		{
			return 108;
		}
		else if(a == 44 && b == 65)
		{
			return 109;
		}
		else if(a == 44 && b == 66)
		{
			return 110;
		}
		else if(a == 44 && b == 67)
		{
			return 111;
		}
		else if(a == 44 && b == 68)
		{
			return 112;
		}
		else if(a == 44 && b == 69)
		{
			return 113;
		}
		else if(a == 44 && b == 70)
		{
			return 114;
		}
		else if(a == 44 && b == 71)
		{
			return 115;
		}
		else if(a == 44 && b == 72)
		{
			return 116;
		}
		else if(a == 44 && b == 73)
		{
			return 117;
		}
		else if(a == 44 && b == 74)
		{
			return 118;
		}
		else if(a == 44 && b == 75)
		{
			return 119;
		}
		else if(a == 44 && b == 76)
		{
			return 120;
		}
		else if(a == 44 && b == 77)
		{
			return 121;
		}
		else if(a == 44 && b == 78)
		{
			return 122;
		}
		else if(a == 44 && b == 79)
		{
			return 123;
		}
		else if(a == 44 && b == 80)
		{
			return 124;
		}
		else if(a == 44 && b == 81)
		{
			return 125;
		}
		else if(a == 44 && b == 82)
		{
			return 126;
		}
		else if(a == 44 && b == 83)
		{
			return 127;
		}
		else if(a == 44 && b == 84)
		{
			return 128;
		}
		else if(a == 44 && b == 85)
		{
			return 129;
		}
		else if(a == 44 && b == 86)
		{
			return 130;
		}
		else if(a == 44 && b == 87)
		{
			return 131;
		}
		else if(a == 44 && b == 88)
		{
			return 132;
		}
		else if(a == 44 && b == 89)
		{
			return 133;
		}
		else if(a == 44 && b == 90)
		{
			return 134;
		}
		else if(a == 44 && b == 91)
		{
			return 135;
		}
		else if(a == 44 && b == 92)
		{
			return 136;
		}
		else if(a == 44 && b == 93)
		{
			return 137;
		}
		else if(a == 44 && b == 94)
		{
			return 138;
		}
		else if(a == 44 && b == 95)
		{
			return 139;
		}
		else if(a == 44 && b == 96)
		{
			return 140;
		}
		else if(a == 44 && b == 97)
		{
			return 141;
		}
		else if(a == 44 && b == 98)
		{
			return 142;
		}
		else if(a == 44 && b == 99)
		{
			return 143;
		}
		else if(a == 44 && b == 100)
		{
			return 144;
		}
		else if(a == 45 && b == 0)
		{
			return 45;
		}
		else if(a == 45 && b == 1)
		{
			return 46;
		}
		else if(a == 45 && b == 2)
		{
			return 47;
		}
		else if(a == 45 && b == 3)
		{
			return 48;
		}
		else if(a == 45 && b == 4)
		{
			return 49;
		}
		else if(a == 45 && b == 5)
		{
			return 50;
		}
		else if(a == 45 && b == 6)
		{
			return 51;
		}
		else if(a == 45 && b == 7)
		{
			return 52;
		}
		else if(a == 45 && b == 8)
		{
			return 53;
		}
		else if(a == 45 && b == 9)
		{
			return 54;
		}
		else if(a == 45 && b == 10)
		{
			return 55;
		}
		else if(a == 45 && b == 11)
		{
			return 56;
		}
		else if(a == 45 && b == 12)
		{
			return 57;
		}
		else if(a == 45 && b == 13)
		{
			return 58;
		}
		else if(a == 45 && b == 14)
		{
			return 59;
		}
		else if(a == 45 && b == 15)
		{
			return 60;
		}
		else if(a == 45 && b == 16)
		{
			return 61;
		}
		else if(a == 45 && b == 17)
		{
			return 62;
		}
		else if(a == 45 && b == 18)
		{
			return 63;
		}
		else if(a == 45 && b == 19)
		{
			return 64;
		}
		else if(a == 45 && b == 20)
		{
			return 65;
		}
		else if(a == 45 && b == 21)
		{
			return 66;
		}
		else if(a == 45 && b == 22)
		{
			return 67;
		}
		else if(a == 45 && b == 23)
		{
			return 68;
		}
		else if(a == 45 && b == 24)
		{
			return 69;
		}
		else if(a == 45 && b == 25)
		{
			return 70;
		}
		else if(a == 45 && b == 26)
		{
			return 71;
		}
		else if(a == 45 && b == 27)
		{
			return 72;
		}
		else if(a == 45 && b == 28)
		{
			return 73;
		}
		else if(a == 45 && b == 29)
		{
			return 74;
		}
		else if(a == 45 && b == 30)
		{
			return 75;
		}
		else if(a == 45 && b == 31)
		{
			return 76;
		}
		else if(a == 45 && b == 32)
		{
			return 77;
		}
		else if(a == 45 && b == 33)
		{
			return 78;
		}
		else if(a == 45 && b == 34)
		{
			return 79;
		}
		else if(a == 45 && b == 35)
		{
			return 80;
		}
		else if(a == 45 && b == 36)
		{
			return 81;
		}
		else if(a == 45 && b == 37)
		{
			return 82;
		}
		else if(a == 45 && b == 38)
		{
			return 83;
		}
		else if(a == 45 && b == 39)
		{
			return 84;
		}
		else if(a == 45 && b == 40)
		{
			return 85;
		}
		else if(a == 45 && b == 41)
		{
			return 86;
		}
		else if(a == 45 && b == 42)
		{
			return 87;
		}
		else if(a == 45 && b == 43)
		{
			return 88;
		}
		else if(a == 45 && b == 44)
		{
			return 89;
		}
		else if(a == 45 && b == 45)
		{
			return 90;
		}
		else if(a == 45 && b == 46)
		{
			return 91;
		}
		else if(a == 45 && b == 47)
		{
			return 92;
		}
		else if(a == 45 && b == 48)
		{
			return 93;
		}
		else if(a == 45 && b == 49)
		{
			return 94;
		}
		else if(a == 45 && b == 50)
		{
			return 95;
		}
		else if(a == 45 && b == 51)
		{
			return 96;
		}
		else if(a == 45 && b == 52)
		{
			return 97;
		}
		else if(a == 45 && b == 53)
		{
			return 98;
		}
		else if(a == 45 && b == 54)
		{
			return 99;
		}
		else if(a == 45 && b == 55)
		{
			return 100;
		}
		else if(a == 45 && b == 56)
		{
			return 101;
		}
		else if(a == 45 && b == 57)
		{
			return 102;
		}
		else if(a == 45 && b == 58)
		{
			return 103;
		}
		else if(a == 45 && b == 59)
		{
			return 104;
		}
		else if(a == 45 && b == 60)
		{
			return 105;
		}
		else if(a == 45 && b == 61)
		{
			return 106;
		}
		else if(a == 45 && b == 62)
		{
			return 107;
		}
		else if(a == 45 && b == 63)
		{
			return 108;
		}
		else if(a == 45 && b == 64)
		{
			return 109;
		}
		else if(a == 45 && b == 65)
		{
			return 110;
		}
		else if(a == 45 && b == 66)
		{
			return 111;
		}
		else if(a == 45 && b == 67)
		{
			return 112;
		}
		else if(a == 45 && b == 68)
		{
			return 113;
		}
		else if(a == 45 && b == 69)
		{
			return 114;
		}
		else if(a == 45 && b == 70)
		{
			return 115;
		}
		else if(a == 45 && b == 71)
		{
			return 116;
		}
		else if(a == 45 && b == 72)
		{
			return 117;
		}
		else if(a == 45 && b == 73)
		{
			return 118;
		}
		else if(a == 45 && b == 74)
		{
			return 119;
		}
		else if(a == 45 && b == 75)
		{
			return 120;
		}
		else if(a == 45 && b == 76)
		{
			return 121;
		}
		else if(a == 45 && b == 77)
		{
			return 122;
		}
		else if(a == 45 && b == 78)
		{
			return 123;
		}
		else if(a == 45 && b == 79)
		{
			return 124;
		}
		else if(a == 45 && b == 80)
		{
			return 125;
		}
		else if(a == 45 && b == 81)
		{
			return 126;
		}
		else if(a == 45 && b == 82)
		{
			return 127;
		}
		else if(a == 45 && b == 83)
		{
			return 128;
		}
		else if(a == 45 && b == 84)
		{
			return 129;
		}
		else if(a == 45 && b == 85)
		{
			return 130;
		}
		else if(a == 45 && b == 86)
		{
			return 131;
		}
		else if(a == 45 && b == 87)
		{
			return 132;
		}
		else if(a == 45 && b == 88)
		{
			return 133;
		}
		else if(a == 45 && b == 89)
		{
			return 134;
		}
		else if(a == 45 && b == 90)
		{
			return 135;
		}
		else if(a == 45 && b == 91)
		{
			return 136;
		}
		else if(a == 45 && b == 92)
		{
			return 137;
		}
		else if(a == 45 && b == 93)
		{
			return 138;
		}
		else if(a == 45 && b == 94)
		{
			return 139;
		}
		else if(a == 45 && b == 95)
		{
			return 140;
		}
		else if(a == 45 && b == 96)
		{
			return 141;
		}
		else if(a == 45 && b == 97)
		{
			return 142;
		}
		else if(a == 45 && b == 98)
		{
			return 143;
		}
		else if(a == 45 && b == 99)
		{
			return 144;
		}
		else if(a == 45 && b == 100)
		{
			return 145;
		}
		else if(a == 46 && b == 0)
		{
			return 46;
		}
		else if(a == 46 && b == 1)
		{
			return 47;
		}
		else if(a == 46 && b == 2)
		{
			return 48;
		}
		else if(a == 46 && b == 3)
		{
			return 49;
		}
		else if(a == 46 && b == 4)
		{
			return 50;
		}
		else if(a == 46 && b == 5)
		{
			return 51;
		}
		else if(a == 46 && b == 6)
		{
			return 52;
		}
		else if(a == 46 && b == 7)
		{
			return 53;
		}
		else if(a == 46 && b == 8)
		{
			return 54;
		}
		else if(a == 46 && b == 9)
		{
			return 55;
		}
		else if(a == 46 && b == 10)
		{
			return 56;
		}
		else if(a == 46 && b == 11)
		{
			return 57;
		}
		else if(a == 46 && b == 12)
		{
			return 58;
		}
		else if(a == 46 && b == 13)
		{
			return 59;
		}
		else if(a == 46 && b == 14)
		{
			return 60;
		}
		else if(a == 46 && b == 15)
		{
			return 61;
		}
		else if(a == 46 && b == 16)
		{
			return 62;
		}
		else if(a == 46 && b == 17)
		{
			return 63;
		}
		else if(a == 46 && b == 18)
		{
			return 64;
		}
		else if(a == 46 && b == 19)
		{
			return 65;
		}
		else if(a == 46 && b == 20)
		{
			return 66;
		}
		else if(a == 46 && b == 21)
		{
			return 67;
		}
		else if(a == 46 && b == 22)
		{
			return 68;
		}
		else if(a == 46 && b == 23)
		{
			return 69;
		}
		else if(a == 46 && b == 24)
		{
			return 70;
		}
		else if(a == 46 && b == 25)
		{
			return 71;
		}
		else if(a == 46 && b == 26)
		{
			return 72;
		}
		else if(a == 46 && b == 27)
		{
			return 73;
		}
		else if(a == 46 && b == 28)
		{
			return 74;
		}
		else if(a == 46 && b == 29)
		{
			return 75;
		}
		else if(a == 46 && b == 30)
		{
			return 76;
		}
		else if(a == 46 && b == 31)
		{
			return 77;
		}
		else if(a == 46 && b == 32)
		{
			return 78;
		}
		else if(a == 46 && b == 33)
		{
			return 79;
		}
		else if(a == 46 && b == 34)
		{
			return 80;
		}
		else if(a == 46 && b == 35)
		{
			return 81;
		}
		else if(a == 46 && b == 36)
		{
			return 82;
		}
		else if(a == 46 && b == 37)
		{
			return 83;
		}
		else if(a == 46 && b == 38)
		{
			return 84;
		}
		else if(a == 46 && b == 39)
		{
			return 85;
		}
		else if(a == 46 && b == 40)
		{
			return 86;
		}
		else if(a == 46 && b == 41)
		{
			return 87;
		}
		else if(a == 46 && b == 42)
		{
			return 88;
		}
		else if(a == 46 && b == 43)
		{
			return 89;
		}
		else if(a == 46 && b == 44)
		{
			return 90;
		}
		else if(a == 46 && b == 45)
		{
			return 91;
		}
		else if(a == 46 && b == 46)
		{
			return 92;
		}
		else if(a == 46 && b == 47)
		{
			return 93;
		}
		else if(a == 46 && b == 48)
		{
			return 94;
		}
		else if(a == 46 && b == 49)
		{
			return 95;
		}
		else if(a == 46 && b == 50)
		{
			return 96;
		}
		else if(a == 46 && b == 51)
		{
			return 97;
		}
		else if(a == 46 && b == 52)
		{
			return 98;
		}
		else if(a == 46 && b == 53)
		{
			return 99;
		}
		else if(a == 46 && b == 54)
		{
			return 100;
		}
		else if(a == 46 && b == 55)
		{
			return 101;
		}
		else if(a == 46 && b == 56)
		{
			return 102;
		}
		else if(a == 46 && b == 57)
		{
			return 103;
		}
		else if(a == 46 && b == 58)
		{
			return 104;
		}
		else if(a == 46 && b == 59)
		{
			return 105;
		}
		else if(a == 46 && b == 60)
		{
			return 106;
		}
		else if(a == 46 && b == 61)
		{
			return 107;
		}
		else if(a == 46 && b == 62)
		{
			return 108;
		}
		else if(a == 46 && b == 63)
		{
			return 109;
		}
		else if(a == 46 && b == 64)
		{
			return 110;
		}
		else if(a == 46 && b == 65)
		{
			return 111;
		}
		else if(a == 46 && b == 66)
		{
			return 112;
		}
		else if(a == 46 && b == 67)
		{
			return 113;
		}
		else if(a == 46 && b == 68)
		{
			return 114;
		}
		else if(a == 46 && b == 69)
		{
			return 115;
		}
		else if(a == 46 && b == 70)
		{
			return 116;
		}
		else if(a == 46 && b == 71)
		{
			return 117;
		}
		else if(a == 46 && b == 72)
		{
			return 118;
		}
		else if(a == 46 && b == 73)
		{
			return 119;
		}
		else if(a == 46 && b == 74)
		{
			return 120;
		}
		else if(a == 46 && b == 75)
		{
			return 121;
		}
		else if(a == 46 && b == 76)
		{
			return 122;
		}
		else if(a == 46 && b == 77)
		{
			return 123;
		}
		else if(a == 46 && b == 78)
		{
			return 124;
		}
		else if(a == 46 && b == 79)
		{
			return 125;
		}
		else if(a == 46 && b == 80)
		{
			return 126;
		}
		else if(a == 46 && b == 81)
		{
			return 127;
		}
		else if(a == 46 && b == 82)
		{
			return 128;
		}
		else if(a == 46 && b == 83)
		{
			return 129;
		}
		else if(a == 46 && b == 84)
		{
			return 130;
		}
		else if(a == 46 && b == 85)
		{
			return 131;
		}
		else if(a == 46 && b == 86)
		{
			return 132;
		}
		else if(a == 46 && b == 87)
		{
			return 133;
		}
		else if(a == 46 && b == 88)
		{
			return 134;
		}
		else if(a == 46 && b == 89)
		{
			return 135;
		}
		else if(a == 46 && b == 90)
		{
			return 136;
		}
		else if(a == 46 && b == 91)
		{
			return 137;
		}
		else if(a == 46 && b == 92)
		{
			return 138;
		}
		else if(a == 46 && b == 93)
		{
			return 139;
		}
		else if(a == 46 && b == 94)
		{
			return 140;
		}
		else if(a == 46 && b == 95)
		{
			return 141;
		}
		else if(a == 46 && b == 96)
		{
			return 142;
		}
		else if(a == 46 && b == 97)
		{
			return 143;
		}
		else if(a == 46 && b == 98)
		{
			return 144;
		}
		else if(a == 46 && b == 99)
		{
			return 145;
		}
		else if(a == 46 && b == 100)
		{
			return 146;
		}
		else if(a == 47 && b == 0)
		{
			return 47;
		}
		else if(a == 47 && b == 1)
		{
			return 48;
		}
		else if(a == 47 && b == 2)
		{
			return 49;
		}
		else if(a == 47 && b == 3)
		{
			return 50;
		}
		else if(a == 47 && b == 4)
		{
			return 51;
		}
		else if(a == 47 && b == 5)
		{
			return 52;
		}
		else if(a == 47 && b == 6)
		{
			return 53;
		}
		else if(a == 47 && b == 7)
		{
			return 54;
		}
		else if(a == 47 && b == 8)
		{
			return 55;
		}
		else if(a == 47 && b == 9)
		{
			return 56;
		}
		else if(a == 47 && b == 10)
		{
			return 57;
		}
		else if(a == 47 && b == 11)
		{
			return 58;
		}
		else if(a == 47 && b == 12)
		{
			return 59;
		}
		else if(a == 47 && b == 13)
		{
			return 60;
		}
		else if(a == 47 && b == 14)
		{
			return 61;
		}
		else if(a == 47 && b == 15)
		{
			return 62;
		}
		else if(a == 47 && b == 16)
		{
			return 63;
		}
		else if(a == 47 && b == 17)
		{
			return 64;
		}
		else if(a == 47 && b == 18)
		{
			return 65;
		}
		else if(a == 47 && b == 19)
		{
			return 66;
		}
		else if(a == 47 && b == 20)
		{
			return 67;
		}
		else if(a == 47 && b == 21)
		{
			return 68;
		}
		else if(a == 47 && b == 22)
		{
			return 69;
		}
		else if(a == 47 && b == 23)
		{
			return 70;
		}
		else if(a == 47 && b == 24)
		{
			return 71;
		}
		else if(a == 47 && b == 25)
		{
			return 72;
		}
		else if(a == 47 && b == 26)
		{
			return 73;
		}
		else if(a == 47 && b == 27)
		{
			return 74;
		}
		else if(a == 47 && b == 28)
		{
			return 75;
		}
		else if(a == 47 && b == 29)
		{
			return 76;
		}
		else if(a == 47 && b == 30)
		{
			return 77;
		}
		else if(a == 47 && b == 31)
		{
			return 78;
		}
		else if(a == 47 && b == 32)
		{
			return 79;
		}
		else if(a == 47 && b == 33)
		{
			return 80;
		}
		else if(a == 47 && b == 34)
		{
			return 81;
		}
		else if(a == 47 && b == 35)
		{
			return 82;
		}
		else if(a == 47 && b == 36)
		{
			return 83;
		}
		else if(a == 47 && b == 37)
		{
			return 84;
		}
		else if(a == 47 && b == 38)
		{
			return 85;
		}
		else if(a == 47 && b == 39)
		{
			return 86;
		}
		else if(a == 47 && b == 40)
		{
			return 87;
		}
		else if(a == 47 && b == 41)
		{
			return 88;
		}
		else if(a == 47 && b == 42)
		{
			return 89;
		}
		else if(a == 47 && b == 43)
		{
			return 90;
		}
		else if(a == 47 && b == 44)
		{
			return 91;
		}
		else if(a == 47 && b == 45)
		{
			return 92;
		}
		else if(a == 47 && b == 46)
		{
			return 93;
		}
		else if(a == 47 && b == 47)
		{
			return 94;
		}
		else if(a == 47 && b == 48)
		{
			return 95;
		}
		else if(a == 47 && b == 49)
		{
			return 96;
		}
		else if(a == 47 && b == 50)
		{
			return 97;
		}
		else if(a == 47 && b == 51)
		{
			return 98;
		}
		else if(a == 47 && b == 52)
		{
			return 99;
		}
		else if(a == 47 && b == 53)
		{
			return 100;
		}
		else if(a == 47 && b == 54)
		{
			return 101;
		}
		else if(a == 47 && b == 55)
		{
			return 102;
		}
		else if(a == 47 && b == 56)
		{
			return 103;
		}
		else if(a == 47 && b == 57)
		{
			return 104;
		}
		else if(a == 47 && b == 58)
		{
			return 105;
		}
		else if(a == 47 && b == 59)
		{
			return 106;
		}
		else if(a == 47 && b == 60)
		{
			return 107;
		}
		else if(a == 47 && b == 61)
		{
			return 108;
		}
		else if(a == 47 && b == 62)
		{
			return 109;
		}
		else if(a == 47 && b == 63)
		{
			return 110;
		}
		else if(a == 47 && b == 64)
		{
			return 111;
		}
		else if(a == 47 && b == 65)
		{
			return 112;
		}
		else if(a == 47 && b == 66)
		{
			return 113;
		}
		else if(a == 47 && b == 67)
		{
			return 114;
		}
		else if(a == 47 && b == 68)
		{
			return 115;
		}
		else if(a == 47 && b == 69)
		{
			return 116;
		}
		else if(a == 47 && b == 70)
		{
			return 117;
		}
		else if(a == 47 && b == 71)
		{
			return 118;
		}
		else if(a == 47 && b == 72)
		{
			return 119;
		}
		else if(a == 47 && b == 73)
		{
			return 120;
		}
		else if(a == 47 && b == 74)
		{
			return 121;
		}
		else if(a == 47 && b == 75)
		{
			return 122;
		}
		else if(a == 47 && b == 76)
		{
			return 123;
		}
		else if(a == 47 && b == 77)
		{
			return 124;
		}
		else if(a == 47 && b == 78)
		{
			return 125;
		}
		else if(a == 47 && b == 79)
		{
			return 126;
		}
		else if(a == 47 && b == 80)
		{
			return 127;
		}
		else if(a == 47 && b == 81)
		{
			return 128;
		}
		else if(a == 47 && b == 82)
		{
			return 129;
		}
		else if(a == 47 && b == 83)
		{
			return 130;
		}
		else if(a == 47 && b == 84)
		{
			return 131;
		}
		else if(a == 47 && b == 85)
		{
			return 132;
		}
		else if(a == 47 && b == 86)
		{
			return 133;
		}
		else if(a == 47 && b == 87)
		{
			return 134;
		}
		else if(a == 47 && b == 88)
		{
			return 135;
		}
		else if(a == 47 && b == 89)
		{
			return 136;
		}
		else if(a == 47 && b == 90)
		{
			return 137;
		}
		else if(a == 47 && b == 91)
		{
			return 138;
		}
		else if(a == 47 && b == 92)
		{
			return 139;
		}
		else if(a == 47 && b == 93)
		{
			return 140;
		}
		else if(a == 47 && b == 94)
		{
			return 141;
		}
		else if(a == 47 && b == 95)
		{
			return 142;
		}
		else if(a == 47 && b == 96)
		{
			return 143;
		}
		else if(a == 47 && b == 97)
		{
			return 144;
		}
		else if(a == 47 && b == 98)
		{
			return 145;
		}
		else if(a == 47 && b == 99)
		{
			return 146;
		}
		else if(a == 47 && b == 100)
		{
			return 147;
		}
		else if(a == 48 && b == 0)
		{
			return 48;
		}
		else if(a == 48 && b == 1)
		{
			return 49;
		}
		else if(a == 48 && b == 2)
		{
			return 50;
		}
		else if(a == 48 && b == 3)
		{
			return 51;
		}
		else if(a == 48 && b == 4)
		{
			return 52;
		}
		else if(a == 48 && b == 5)
		{
			return 53;
		}
		else if(a == 48 && b == 6)
		{
			return 54;
		}
		else if(a == 48 && b == 7)
		{
			return 55;
		}
		else if(a == 48 && b == 8)
		{
			return 56;
		}
		else if(a == 48 && b == 9)
		{
			return 57;
		}
		else if(a == 48 && b == 10)
		{
			return 58;
		}
		else if(a == 48 && b == 11)
		{
			return 59;
		}
		else if(a == 48 && b == 12)
		{
			return 60;
		}
		else if(a == 48 && b == 13)
		{
			return 61;
		}
		else if(a == 48 && b == 14)
		{
			return 62;
		}
		else if(a == 48 && b == 15)
		{
			return 63;
		}
		else if(a == 48 && b == 16)
		{
			return 64;
		}
		else if(a == 48 && b == 17)
		{
			return 65;
		}
		else if(a == 48 && b == 18)
		{
			return 66;
		}
		else if(a == 48 && b == 19)
		{
			return 67;
		}
		else if(a == 48 && b == 20)
		{
			return 68;
		}
		else if(a == 48 && b == 21)
		{
			return 69;
		}
		else if(a == 48 && b == 22)
		{
			return 70;
		}
		else if(a == 48 && b == 23)
		{
			return 71;
		}
		else if(a == 48 && b == 24)
		{
			return 72;
		}
		else if(a == 48 && b == 25)
		{
			return 73;
		}
		else if(a == 48 && b == 26)
		{
			return 74;
		}
		else if(a == 48 && b == 27)
		{
			return 75;
		}
		else if(a == 48 && b == 28)
		{
			return 76;
		}
		else if(a == 48 && b == 29)
		{
			return 77;
		}
		else if(a == 48 && b == 30)
		{
			return 78;
		}
		else if(a == 48 && b == 31)
		{
			return 79;
		}
		else if(a == 48 && b == 32)
		{
			return 80;
		}
		else if(a == 48 && b == 33)
		{
			return 81;
		}
		else if(a == 48 && b == 34)
		{
			return 82;
		}
		else if(a == 48 && b == 35)
		{
			return 83;
		}
		else if(a == 48 && b == 36)
		{
			return 84;
		}
		else if(a == 48 && b == 37)
		{
			return 85;
		}
		else if(a == 48 && b == 38)
		{
			return 86;
		}
		else if(a == 48 && b == 39)
		{
			return 87;
		}
		else if(a == 48 && b == 40)
		{
			return 88;
		}
		else if(a == 48 && b == 41)
		{
			return 89;
		}
		else if(a == 48 && b == 42)
		{
			return 90;
		}
		else if(a == 48 && b == 43)
		{
			return 91;
		}
		else if(a == 48 && b == 44)
		{
			return 92;
		}
		else if(a == 48 && b == 45)
		{
			return 93;
		}
		else if(a == 48 && b == 46)
		{
			return 94;
		}
		else if(a == 48 && b == 47)
		{
			return 95;
		}
		else if(a == 48 && b == 48)
		{
			return 96;
		}
		else if(a == 48 && b == 49)
		{
			return 97;
		}
		else if(a == 48 && b == 50)
		{
			return 98;
		}
		else if(a == 48 && b == 51)
		{
			return 99;
		}
		else if(a == 48 && b == 52)
		{
			return 100;
		}
		else if(a == 48 && b == 53)
		{
			return 101;
		}
		else if(a == 48 && b == 54)
		{
			return 102;
		}
		else if(a == 48 && b == 55)
		{
			return 103;
		}
		else if(a == 48 && b == 56)
		{
			return 104;
		}
		else if(a == 48 && b == 57)
		{
			return 105;
		}
		else if(a == 48 && b == 58)
		{
			return 106;
		}
		else if(a == 48 && b == 59)
		{
			return 107;
		}
		else if(a == 48 && b == 60)
		{
			return 108;
		}
		else if(a == 48 && b == 61)
		{
			return 109;
		}
		else if(a == 48 && b == 62)
		{
			return 110;
		}
		else if(a == 48 && b == 63)
		{
			return 111;
		}
		else if(a == 48 && b == 64)
		{
			return 112;
		}
		else if(a == 48 && b == 65)
		{
			return 113;
		}
		else if(a == 48 && b == 66)
		{
			return 114;
		}
		else if(a == 48 && b == 67)
		{
			return 115;
		}
		else if(a == 48 && b == 68)
		{
			return 116;
		}
		else if(a == 48 && b == 69)
		{
			return 117;
		}
		else if(a == 48 && b == 70)
		{
			return 118;
		}
		else if(a == 48 && b == 71)
		{
			return 119;
		}
		else if(a == 48 && b == 72)
		{
			return 120;
		}
		else if(a == 48 && b == 73)
		{
			return 121;
		}
		else if(a == 48 && b == 74)
		{
			return 122;
		}
		else if(a == 48 && b == 75)
		{
			return 123;
		}
		else if(a == 48 && b == 76)
		{
			return 124;
		}
		else if(a == 48 && b == 77)
		{
			return 125;
		}
		else if(a == 48 && b == 78)
		{
			return 126;
		}
		else if(a == 48 && b == 79)
		{
			return 127;
		}
		else if(a == 48 && b == 80)
		{
			return 128;
		}
		else if(a == 48 && b == 81)
		{
			return 129;
		}
		else if(a == 48 && b == 82)
		{
			return 130;
		}
		else if(a == 48 && b == 83)
		{
			return 131;
		}
		else if(a == 48 && b == 84)
		{
			return 132;
		}
		else if(a == 48 && b == 85)
		{
			return 133;
		}
		else if(a == 48 && b == 86)
		{
			return 134;
		}
		else if(a == 48 && b == 87)
		{
			return 135;
		}
		else if(a == 48 && b == 88)
		{
			return 136;
		}
		else if(a == 48 && b == 89)
		{
			return 137;
		}
		else if(a == 48 && b == 90)
		{
			return 138;
		}
		else if(a == 48 && b == 91)
		{
			return 139;
		}
		else if(a == 48 && b == 92)
		{
			return 140;
		}
		else if(a == 48 && b == 93)
		{
			return 141;
		}
		else if(a == 48 && b == 94)
		{
			return 142;
		}
		else if(a == 48 && b == 95)
		{
			return 143;
		}
		else if(a == 48 && b == 96)
		{
			return 144;
		}
		else if(a == 48 && b == 97)
		{
			return 145;
		}
		else if(a == 48 && b == 98)
		{
			return 146;
		}
		else if(a == 48 && b == 99)
		{
			return 147;
		}
		else if(a == 48 && b == 100)
		{
			return 148;
		}
		else if(a == 49 && b == 0)
		{
			return 49;
		}
		else if(a == 49 && b == 1)
		{
			return 50;
		}
		else if(a == 49 && b == 2)
		{
			return 51;
		}
		else if(a == 49 && b == 3)
		{
			return 52;
		}
		else if(a == 49 && b == 4)
		{
			return 53;
		}
		else if(a == 49 && b == 5)
		{
			return 54;
		}
		else if(a == 49 && b == 6)
		{
			return 55;
		}
		else if(a == 49 && b == 7)
		{
			return 56;
		}
		else if(a == 49 && b == 8)
		{
			return 57;
		}
		else if(a == 49 && b == 9)
		{
			return 58;
		}
		else if(a == 49 && b == 10)
		{
			return 59;
		}
		else if(a == 49 && b == 11)
		{
			return 60;
		}
		else if(a == 49 && b == 12)
		{
			return 61;
		}
		else if(a == 49 && b == 13)
		{
			return 62;
		}
		else if(a == 49 && b == 14)
		{
			return 63;
		}
		else if(a == 49 && b == 15)
		{
			return 64;
		}
		else if(a == 49 && b == 16)
		{
			return 65;
		}
		else if(a == 49 && b == 17)
		{
			return 66;
		}
		else if(a == 49 && b == 18)
		{
			return 67;
		}
		else if(a == 49 && b == 19)
		{
			return 68;
		}
		else if(a == 49 && b == 20)
		{
			return 69;
		}
		else if(a == 49 && b == 21)
		{
			return 70;
		}
		else if(a == 49 && b == 22)
		{
			return 71;
		}
		else if(a == 49 && b == 23)
		{
			return 72;
		}
		else if(a == 49 && b == 24)
		{
			return 73;
		}
		else if(a == 49 && b == 25)
		{
			return 74;
		}
		else if(a == 49 && b == 26)
		{
			return 75;
		}
		else if(a == 49 && b == 27)
		{
			return 76;
		}
		else if(a == 49 && b == 28)
		{
			return 77;
		}
		else if(a == 49 && b == 29)
		{
			return 78;
		}
		else if(a == 49 && b == 30)
		{
			return 79;
		}
		else if(a == 49 && b == 31)
		{
			return 80;
		}
		else if(a == 49 && b == 32)
		{
			return 81;
		}
		else if(a == 49 && b == 33)
		{
			return 82;
		}
		else if(a == 49 && b == 34)
		{
			return 83;
		}
		else if(a == 49 && b == 35)
		{
			return 84;
		}
		else if(a == 49 && b == 36)
		{
			return 85;
		}
		else if(a == 49 && b == 37)
		{
			return 86;
		}
		else if(a == 49 && b == 38)
		{
			return 87;
		}
		else if(a == 49 && b == 39)
		{
			return 88;
		}
		else if(a == 49 && b == 40)
		{
			return 89;
		}
		else if(a == 49 && b == 41)
		{
			return 90;
		}
		else if(a == 49 && b == 42)
		{
			return 91;
		}
		else if(a == 49 && b == 43)
		{
			return 92;
		}
		else if(a == 49 && b == 44)
		{
			return 93;
		}
		else if(a == 49 && b == 45)
		{
			return 94;
		}
		else if(a == 49 && b == 46)
		{
			return 95;
		}
		else if(a == 49 && b == 47)
		{
			return 96;
		}
		else if(a == 49 && b == 48)
		{
			return 97;
		}
		else if(a == 49 && b == 49)
		{
			return 98;
		}
		else if(a == 49 && b == 50)
		{
			return 99;
		}
		else if(a == 49 && b == 51)
		{
			return 100;
		}
		else if(a == 49 && b == 52)
		{
			return 101;
		}
		else if(a == 49 && b == 53)
		{
			return 102;
		}
		else if(a == 49 && b == 54)
		{
			return 103;
		}
		else if(a == 49 && b == 55)
		{
			return 104;
		}
		else if(a == 49 && b == 56)
		{
			return 105;
		}
		else if(a == 49 && b == 57)
		{
			return 106;
		}
		else if(a == 49 && b == 58)
		{
			return 107;
		}
		else if(a == 49 && b == 59)
		{
			return 108;
		}
		else if(a == 49 && b == 60)
		{
			return 109;
		}
		else if(a == 49 && b == 61)
		{
			return 110;
		}
		else if(a == 49 && b == 62)
		{
			return 111;
		}
		else if(a == 49 && b == 63)
		{
			return 112;
		}
		else if(a == 49 && b == 64)
		{
			return 113;
		}
		else if(a == 49 && b == 65)
		{
			return 114;
		}
		else if(a == 49 && b == 66)
		{
			return 115;
		}
		else if(a == 49 && b == 67)
		{
			return 116;
		}
		else if(a == 49 && b == 68)
		{
			return 117;
		}
		else if(a == 49 && b == 69)
		{
			return 118;
		}
		else if(a == 49 && b == 70)
		{
			return 119;
		}
		else if(a == 49 && b == 71)
		{
			return 120;
		}
		else if(a == 49 && b == 72)
		{
			return 121;
		}
		else if(a == 49 && b == 73)
		{
			return 122;
		}
		else if(a == 49 && b == 74)
		{
			return 123;
		}
		else if(a == 49 && b == 75)
		{
			return 124;
		}
		else if(a == 49 && b == 76)
		{
			return 125;
		}
		else if(a == 49 && b == 77)
		{
			return 126;
		}
		else if(a == 49 && b == 78)
		{
			return 127;
		}
		else if(a == 49 && b == 79)
		{
			return 128;
		}
		else if(a == 49 && b == 80)
		{
			return 129;
		}
		else if(a == 49 && b == 81)
		{
			return 130;
		}
		else if(a == 49 && b == 82)
		{
			return 131;
		}
		else if(a == 49 && b == 83)
		{
			return 132;
		}
		else if(a == 49 && b == 84)
		{
			return 133;
		}
		else if(a == 49 && b == 85)
		{
			return 134;
		}
		else if(a == 49 && b == 86)
		{
			return 135;
		}
		else if(a == 49 && b == 87)
		{
			return 136;
		}
		else if(a == 49 && b == 88)
		{
			return 137;
		}
		else if(a == 49 && b == 89)
		{
			return 138;
		}
		else if(a == 49 && b == 90)
		{
			return 139;
		}
		else if(a == 49 && b == 91)
		{
			return 140;
		}
		else if(a == 49 && b == 92)
		{
			return 141;
		}
		else if(a == 49 && b == 93)
		{
			return 142;
		}
		else if(a == 49 && b == 94)
		{
			return 143;
		}
		else if(a == 49 && b == 95)
		{
			return 144;
		}
		else if(a == 49 && b == 96)
		{
			return 145;
		}
		else if(a == 49 && b == 97)
		{
			return 146;
		}
		else if(a == 49 && b == 98)
		{
			return 147;
		}
		else if(a == 49 && b == 99)
		{
			return 148;
		}
		else if(a == 49 && b == 100)
		{
			return 149;
		}
		else if(a == 50 && b == 0)
		{
			return 50;
		}
		else if(a == 50 && b == 1)
		{
			return 51;
		}
		else if(a == 50 && b == 2)
		{
			return 52;
		}
		else if(a == 50 && b == 3)
		{
			return 53;
		}
		else if(a == 50 && b == 4)
		{
			return 54;
		}
		else if(a == 50 && b == 5)
		{
			return 55;
		}
		else if(a == 50 && b == 6)
		{
			return 56;
		}
		else if(a == 50 && b == 7)
		{
			return 57;
		}
		else if(a == 50 && b == 8)
		{
			return 58;
		}
		else if(a == 50 && b == 9)
		{
			return 59;
		}
		else if(a == 50 && b == 10)
		{
			return 60;
		}
		else if(a == 50 && b == 11)
		{
			return 61;
		}
		else if(a == 50 && b == 12)
		{
			return 62;
		}
		else if(a == 50 && b == 13)
		{
			return 63;
		}
		else if(a == 50 && b == 14)
		{
			return 64;
		}
		else if(a == 50 && b == 15)
		{
			return 65;
		}
		else if(a == 50 && b == 16)
		{
			return 66;
		}
		else if(a == 50 && b == 17)
		{
			return 67;
		}
		else if(a == 50 && b == 18)
		{
			return 68;
		}
		else if(a == 50 && b == 19)
		{
			return 69;
		}
		else if(a == 50 && b == 20)
		{
			return 70;
		}
		else if(a == 50 && b == 21)
		{
			return 71;
		}
		else if(a == 50 && b == 22)
		{
			return 72;
		}
		else if(a == 50 && b == 23)
		{
			return 73;
		}
		else if(a == 50 && b == 24)
		{
			return 74;
		}
		else if(a == 50 && b == 25)
		{
			return 75;
		}
		else if(a == 50 && b == 26)
		{
			return 76;
		}
		else if(a == 50 && b == 27)
		{
			return 77;
		}
		else if(a == 50 && b == 28)
		{
			return 78;
		}
		else if(a == 50 && b == 29)
		{
			return 79;
		}
		else if(a == 50 && b == 30)
		{
			return 80;
		}
		else if(a == 50 && b == 31)
		{
			return 81;
		}
		else if(a == 50 && b == 32)
		{
			return 82;
		}
		else if(a == 50 && b == 33)
		{
			return 83;
		}
		else if(a == 50 && b == 34)
		{
			return 84;
		}
		else if(a == 50 && b == 35)
		{
			return 85;
		}
		else if(a == 50 && b == 36)
		{
			return 86;
		}
		else if(a == 50 && b == 37)
		{
			return 87;
		}
		else if(a == 50 && b == 38)
		{
			return 88;
		}
		else if(a == 50 && b == 39)
		{
			return 89;
		}
		else if(a == 50 && b == 40)
		{
			return 90;
		}
		else if(a == 50 && b == 41)
		{
			return 91;
		}
		else if(a == 50 && b == 42)
		{
			return 92;
		}
		else if(a == 50 && b == 43)
		{
			return 93;
		}
		else if(a == 50 && b == 44)
		{
			return 94;
		}
		else if(a == 50 && b == 45)
		{
			return 95;
		}
		else if(a == 50 && b == 46)
		{
			return 96;
		}
		else if(a == 50 && b == 47)
		{
			return 97;
		}
		else if(a == 50 && b == 48)
		{
			return 98;
		}
		else if(a == 50 && b == 49)
		{
			return 99;
		}
		else if(a == 50 && b == 50)
		{
			return 100;
		}
		else if(a == 50 && b == 51)
		{
			return 101;
		}
		else if(a == 50 && b == 52)
		{
			return 102;
		}
		else if(a == 50 && b == 53)
		{
			return 103;
		}
		else if(a == 50 && b == 54)
		{
			return 104;
		}
		else if(a == 50 && b == 55)
		{
			return 105;
		}
		else if(a == 50 && b == 56)
		{
			return 106;
		}
		else if(a == 50 && b == 57)
		{
			return 107;
		}
		else if(a == 50 && b == 58)
		{
			return 108;
		}
		else if(a == 50 && b == 59)
		{
			return 109;
		}
		else if(a == 50 && b == 60)
		{
			return 110;
		}
		else if(a == 50 && b == 61)
		{
			return 111;
		}
		else if(a == 50 && b == 62)
		{
			return 112;
		}
		else if(a == 50 && b == 63)
		{
			return 113;
		}
		else if(a == 50 && b == 64)
		{
			return 114;
		}
		else if(a == 50 && b == 65)
		{
			return 115;
		}
		else if(a == 50 && b == 66)
		{
			return 116;
		}
		else if(a == 50 && b == 67)
		{
			return 117;
		}
		else if(a == 50 && b == 68)
		{
			return 118;
		}
		else if(a == 50 && b == 69)
		{
			return 119;
		}
		else if(a == 50 && b == 70)
		{
			return 120;
		}
		else if(a == 50 && b == 71)
		{
			return 121;
		}
		else if(a == 50 && b == 72)
		{
			return 122;
		}
		else if(a == 50 && b == 73)
		{
			return 123;
		}
		else if(a == 50 && b == 74)
		{
			return 124;
		}
		else if(a == 50 && b == 75)
		{
			return 125;
		}
		else if(a == 50 && b == 76)
		{
			return 126;
		}
		else if(a == 50 && b == 77)
		{
			return 127;
		}
		else if(a == 50 && b == 78)
		{
			return 128;
		}
		else if(a == 50 && b == 79)
		{
			return 129;
		}
		else if(a == 50 && b == 80)
		{
			return 130;
		}
		else if(a == 50 && b == 81)
		{
			return 131;
		}
		else if(a == 50 && b == 82)
		{
			return 132;
		}
		else if(a == 50 && b == 83)
		{
			return 133;
		}
		else if(a == 50 && b == 84)
		{
			return 134;
		}
		else if(a == 50 && b == 85)
		{
			return 135;
		}
		else if(a == 50 && b == 86)
		{
			return 136;
		}
		else if(a == 50 && b == 87)
		{
			return 137;
		}
		else if(a == 50 && b == 88)
		{
			return 138;
		}
		else if(a == 50 && b == 89)
		{
			return 139;
		}
		else if(a == 50 && b == 90)
		{
			return 140;
		}
		else if(a == 50 && b == 91)
		{
			return 141;
		}
		else if(a == 50 && b == 92)
		{
			return 142;
		}
		else if(a == 50 && b == 93)
		{
			return 143;
		}
		else if(a == 50 && b == 94)
		{
			return 144;
		}
		else if(a == 50 && b == 95)
		{
			return 145;
		}
		else if(a == 50 && b == 96)
		{
			return 146;
		}
		else if(a == 50 && b == 97)
		{
			return 147;
		}
		else if(a == 50 && b == 98)
		{
			return 148;
		}
		else if(a == 50 && b == 99)
		{
			return 149;
		}
		else if(a == 50 && b == 100)
		{
			return 150;
		}
		else if(a == 51 && b == 0)
		{
			return 51;
		}
		else if(a == 51 && b == 1)
		{
			return 52;
		}
		else if(a == 51 && b == 2)
		{
			return 53;
		}
		else if(a == 51 && b == 3)
		{
			return 54;
		}
		else if(a == 51 && b == 4)
		{
			return 55;
		}
		else if(a == 51 && b == 5)
		{
			return 56;
		}
		else if(a == 51 && b == 6)
		{
			return 57;
		}
		else if(a == 51 && b == 7)
		{
			return 58;
		}
		else if(a == 51 && b == 8)
		{
			return 59;
		}
		else if(a == 51 && b == 9)
		{
			return 60;
		}
		else if(a == 51 && b == 10)
		{
			return 61;
		}
		else if(a == 51 && b == 11)
		{
			return 62;
		}
		else if(a == 51 && b == 12)
		{
			return 63;
		}
		else if(a == 51 && b == 13)
		{
			return 64;
		}
		else if(a == 51 && b == 14)
		{
			return 65;
		}
		else if(a == 51 && b == 15)
		{
			return 66;
		}
		else if(a == 51 && b == 16)
		{
			return 67;
		}
		else if(a == 51 && b == 17)
		{
			return 68;
		}
		else if(a == 51 && b == 18)
		{
			return 69;
		}
		else if(a == 51 && b == 19)
		{
			return 70;
		}
		else if(a == 51 && b == 20)
		{
			return 71;
		}
		else if(a == 51 && b == 21)
		{
			return 72;
		}
		else if(a == 51 && b == 22)
		{
			return 73;
		}
		else if(a == 51 && b == 23)
		{
			return 74;
		}
		else if(a == 51 && b == 24)
		{
			return 75;
		}
		else if(a == 51 && b == 25)
		{
			return 76;
		}
		else if(a == 51 && b == 26)
		{
			return 77;
		}
		else if(a == 51 && b == 27)
		{
			return 78;
		}
		else if(a == 51 && b == 28)
		{
			return 79;
		}
		else if(a == 51 && b == 29)
		{
			return 80;
		}
		else if(a == 51 && b == 30)
		{
			return 81;
		}
		else if(a == 51 && b == 31)
		{
			return 82;
		}
		else if(a == 51 && b == 32)
		{
			return 83;
		}
		else if(a == 51 && b == 33)
		{
			return 84;
		}
		else if(a == 51 && b == 34)
		{
			return 85;
		}
		else if(a == 51 && b == 35)
		{
			return 86;
		}
		else if(a == 51 && b == 36)
		{
			return 87;
		}
		else if(a == 51 && b == 37)
		{
			return 88;
		}
		else if(a == 51 && b == 38)
		{
			return 89;
		}
		else if(a == 51 && b == 39)
		{
			return 90;
		}
		else if(a == 51 && b == 40)
		{
			return 91;
		}
		else if(a == 51 && b == 41)
		{
			return 92;
		}
		else if(a == 51 && b == 42)
		{
			return 93;
		}
		else if(a == 51 && b == 43)
		{
			return 94;
		}
		else if(a == 51 && b == 44)
		{
			return 95;
		}
		else if(a == 51 && b == 45)
		{
			return 96;
		}
		else if(a == 51 && b == 46)
		{
			return 97;
		}
		else if(a == 51 && b == 47)
		{
			return 98;
		}
		else if(a == 51 && b == 48)
		{
			return 99;
		}
		else if(a == 51 && b == 49)
		{
			return 100;
		}
		else if(a == 51 && b == 50)
		{
			return 101;
		}
		else if(a == 51 && b == 51)
		{
			return 102;
		}
		else if(a == 51 && b == 52)
		{
			return 103;
		}
		else if(a == 51 && b == 53)
		{
			return 104;
		}
		else if(a == 51 && b == 54)
		{
			return 105;
		}
		else if(a == 51 && b == 55)
		{
			return 106;
		}
		else if(a == 51 && b == 56)
		{
			return 107;
		}
		else if(a == 51 && b == 57)
		{
			return 108;
		}
		else if(a == 51 && b == 58)
		{
			return 109;
		}
		else if(a == 51 && b == 59)
		{
			return 110;
		}
		else if(a == 51 && b == 60)
		{
			return 111;
		}
		else if(a == 51 && b == 61)
		{
			return 112;
		}
		else if(a == 51 && b == 62)
		{
			return 113;
		}
		else if(a == 51 && b == 63)
		{
			return 114;
		}
		else if(a == 51 && b == 64)
		{
			return 115;
		}
		else if(a == 51 && b == 65)
		{
			return 116;
		}
		else if(a == 51 && b == 66)
		{
			return 117;
		}
		else if(a == 51 && b == 67)
		{
			return 118;
		}
		else if(a == 51 && b == 68)
		{
			return 119;
		}
		else if(a == 51 && b == 69)
		{
			return 120;
		}
		else if(a == 51 && b == 70)
		{
			return 121;
		}
		else if(a == 51 && b == 71)
		{
			return 122;
		}
		else if(a == 51 && b == 72)
		{
			return 123;
		}
		else if(a == 51 && b == 73)
		{
			return 124;
		}
		else if(a == 51 && b == 74)
		{
			return 125;
		}
		else if(a == 51 && b == 75)
		{
			return 126;
		}
		else if(a == 51 && b == 76)
		{
			return 127;
		}
		else if(a == 51 && b == 77)
		{
			return 128;
		}
		else if(a == 51 && b == 78)
		{
			return 129;
		}
		else if(a == 51 && b == 79)
		{
			return 130;
		}
		else if(a == 51 && b == 80)
		{
			return 131;
		}
		else if(a == 51 && b == 81)
		{
			return 132;
		}
		else if(a == 51 && b == 82)
		{
			return 133;
		}
		else if(a == 51 && b == 83)
		{
			return 134;
		}
		else if(a == 51 && b == 84)
		{
			return 135;
		}
		else if(a == 51 && b == 85)
		{
			return 136;
		}
		else if(a == 51 && b == 86)
		{
			return 137;
		}
		else if(a == 51 && b == 87)
		{
			return 138;
		}
		else if(a == 51 && b == 88)
		{
			return 139;
		}
		else if(a == 51 && b == 89)
		{
			return 140;
		}
		else if(a == 51 && b == 90)
		{
			return 141;
		}
		else if(a == 51 && b == 91)
		{
			return 142;
		}
		else if(a == 51 && b == 92)
		{
			return 143;
		}
		else if(a == 51 && b == 93)
		{
			return 144;
		}
		else if(a == 51 && b == 94)
		{
			return 145;
		}
		else if(a == 51 && b == 95)
		{
			return 146;
		}
		else if(a == 51 && b == 96)
		{
			return 147;
		}
		else if(a == 51 && b == 97)
		{
			return 148;
		}
		else if(a == 51 && b == 98)
		{
			return 149;
		}
		else if(a == 51 && b == 99)
		{
			return 150;
		}
		else if(a == 51 && b == 100)
		{
			return 151;
		}
		else if(a == 52 && b == 0)
		{
			return 52;
		}
		else if(a == 52 && b == 1)
		{
			return 53;
		}
		else if(a == 52 && b == 2)
		{
			return 54;
		}
		else if(a == 52 && b == 3)
		{
			return 55;
		}
		else if(a == 52 && b == 4)
		{
			return 56;
		}
		else if(a == 52 && b == 5)
		{
			return 57;
		}
		else if(a == 52 && b == 6)
		{
			return 58;
		}
		else if(a == 52 && b == 7)
		{
			return 59;
		}
		else if(a == 52 && b == 8)
		{
			return 60;
		}
		else if(a == 52 && b == 9)
		{
			return 61;
		}
		else if(a == 52 && b == 10)
		{
			return 62;
		}
		else if(a == 52 && b == 11)
		{
			return 63;
		}
		else if(a == 52 && b == 12)
		{
			return 64;
		}
		else if(a == 52 && b == 13)
		{
			return 65;
		}
		else if(a == 52 && b == 14)
		{
			return 66;
		}
		else if(a == 52 && b == 15)
		{
			return 67;
		}
		else if(a == 52 && b == 16)
		{
			return 68;
		}
		else if(a == 52 && b == 17)
		{
			return 69;
		}
		else if(a == 52 && b == 18)
		{
			return 70;
		}
		else if(a == 52 && b == 19)
		{
			return 71;
		}
		else if(a == 52 && b == 20)
		{
			return 72;
		}
		else if(a == 52 && b == 21)
		{
			return 73;
		}
		else if(a == 52 && b == 22)
		{
			return 74;
		}
		else if(a == 52 && b == 23)
		{
			return 75;
		}
		else if(a == 52 && b == 24)
		{
			return 76;
		}
		else if(a == 52 && b == 25)
		{
			return 77;
		}
		else if(a == 52 && b == 26)
		{
			return 78;
		}
		else if(a == 52 && b == 27)
		{
			return 79;
		}
		else if(a == 52 && b == 28)
		{
			return 80;
		}
		else if(a == 52 && b == 29)
		{
			return 81;
		}
		else if(a == 52 && b == 30)
		{
			return 82;
		}
		else if(a == 52 && b == 31)
		{
			return 83;
		}
		else if(a == 52 && b == 32)
		{
			return 84;
		}
		else if(a == 52 && b == 33)
		{
			return 85;
		}
		else if(a == 52 && b == 34)
		{
			return 86;
		}
		else if(a == 52 && b == 35)
		{
			return 87;
		}
		else if(a == 52 && b == 36)
		{
			return 88;
		}
		else if(a == 52 && b == 37)
		{
			return 89;
		}
		else if(a == 52 && b == 38)
		{
			return 90;
		}
		else if(a == 52 && b == 39)
		{
			return 91;
		}
		else if(a == 52 && b == 40)
		{
			return 92;
		}
		else if(a == 52 && b == 41)
		{
			return 93;
		}
		else if(a == 52 && b == 42)
		{
			return 94;
		}
		else if(a == 52 && b == 43)
		{
			return 95;
		}
		else if(a == 52 && b == 44)
		{
			return 96;
		}
		else if(a == 52 && b == 45)
		{
			return 97;
		}
		else if(a == 52 && b == 46)
		{
			return 98;
		}
		else if(a == 52 && b == 47)
		{
			return 99;
		}
		else if(a == 52 && b == 48)
		{
			return 100;
		}
		else if(a == 52 && b == 49)
		{
			return 101;
		}
		else if(a == 52 && b == 50)
		{
			return 102;
		}
		else if(a == 52 && b == 51)
		{
			return 103;
		}
		else if(a == 52 && b == 52)
		{
			return 104;
		}
		else if(a == 52 && b == 53)
		{
			return 105;
		}
		else if(a == 52 && b == 54)
		{
			return 106;
		}
		else if(a == 52 && b == 55)
		{
			return 107;
		}
		else if(a == 52 && b == 56)
		{
			return 108;
		}
		else if(a == 52 && b == 57)
		{
			return 109;
		}
		else if(a == 52 && b == 58)
		{
			return 110;
		}
		else if(a == 52 && b == 59)
		{
			return 111;
		}
		else if(a == 52 && b == 60)
		{
			return 112;
		}
		else if(a == 52 && b == 61)
		{
			return 113;
		}
		else if(a == 52 && b == 62)
		{
			return 114;
		}
		else if(a == 52 && b == 63)
		{
			return 115;
		}
		else if(a == 52 && b == 64)
		{
			return 116;
		}
		else if(a == 52 && b == 65)
		{
			return 117;
		}
		else if(a == 52 && b == 66)
		{
			return 118;
		}
		else if(a == 52 && b == 67)
		{
			return 119;
		}
		else if(a == 52 && b == 68)
		{
			return 120;
		}
		else if(a == 52 && b == 69)
		{
			return 121;
		}
		else if(a == 52 && b == 70)
		{
			return 122;
		}
		else if(a == 52 && b == 71)
		{
			return 123;
		}
		else if(a == 52 && b == 72)
		{
			return 124;
		}
		else if(a == 52 && b == 73)
		{
			return 125;
		}
		else if(a == 52 && b == 74)
		{
			return 126;
		}
		else if(a == 52 && b == 75)
		{
			return 127;
		}
		else if(a == 52 && b == 76)
		{
			return 128;
		}
		else if(a == 52 && b == 77)
		{
			return 129;
		}
		else if(a == 52 && b == 78)
		{
			return 130;
		}
		else if(a == 52 && b == 79)
		{
			return 131;
		}
		else if(a == 52 && b == 80)
		{
			return 132;
		}
		else if(a == 52 && b == 81)
		{
			return 133;
		}
		else if(a == 52 && b == 82)
		{
			return 134;
		}
		else if(a == 52 && b == 83)
		{
			return 135;
		}
		else if(a == 52 && b == 84)
		{
			return 136;
		}
		else if(a == 52 && b == 85)
		{
			return 137;
		}
		else if(a == 52 && b == 86)
		{
			return 138;
		}
		else if(a == 52 && b == 87)
		{
			return 139;
		}
		else if(a == 52 && b == 88)
		{
			return 140;
		}
		else if(a == 52 && b == 89)
		{
			return 141;
		}
		else if(a == 52 && b == 90)
		{
			return 142;
		}
		else if(a == 52 && b == 91)
		{
			return 143;
		}
		else if(a == 52 && b == 92)
		{
			return 144;
		}
		else if(a == 52 && b == 93)
		{
			return 145;
		}
		else if(a == 52 && b == 94)
		{
			return 146;
		}
		else if(a == 52 && b == 95)
		{
			return 147;
		}
		else if(a == 52 && b == 96)
		{
			return 148;
		}
		else if(a == 52 && b == 97)
		{
			return 149;
		}
		else if(a == 52 && b == 98)
		{
			return 150;
		}
		else if(a == 52 && b == 99)
		{
			return 151;
		}
		else if(a == 52 && b == 100)
		{
			return 152;
		}
		else if(a == 53 && b == 0)
		{
			return 53;
		}
		else if(a == 53 && b == 1)
		{
			return 54;
		}
		else if(a == 53 && b == 2)
		{
			return 55;
		}
		else if(a == 53 && b == 3)
		{
			return 56;
		}
		else if(a == 53 && b == 4)
		{
			return 57;
		}
		else if(a == 53 && b == 5)
		{
			return 58;
		}
		else if(a == 53 && b == 6)
		{
			return 59;
		}
		else if(a == 53 && b == 7)
		{
			return 60;
		}
		else if(a == 53 && b == 8)
		{
			return 61;
		}
		else if(a == 53 && b == 9)
		{
			return 62;
		}
		else if(a == 53 && b == 10)
		{
			return 63;
		}
		else if(a == 53 && b == 11)
		{
			return 64;
		}
		else if(a == 53 && b == 12)
		{
			return 65;
		}
		else if(a == 53 && b == 13)
		{
			return 66;
		}
		else if(a == 53 && b == 14)
		{
			return 67;
		}
		else if(a == 53 && b == 15)
		{
			return 68;
		}
		else if(a == 53 && b == 16)
		{
			return 69;
		}
		else if(a == 53 && b == 17)
		{
			return 70;
		}
		else if(a == 53 && b == 18)
		{
			return 71;
		}
		else if(a == 53 && b == 19)
		{
			return 72;
		}
		else if(a == 53 && b == 20)
		{
			return 73;
		}
		else if(a == 53 && b == 21)
		{
			return 74;
		}
		else if(a == 53 && b == 22)
		{
			return 75;
		}
		else if(a == 53 && b == 23)
		{
			return 76;
		}
		else if(a == 53 && b == 24)
		{
			return 77;
		}
		else if(a == 53 && b == 25)
		{
			return 78;
		}
		else if(a == 53 && b == 26)
		{
			return 79;
		}
		else if(a == 53 && b == 27)
		{
			return 80;
		}
		else if(a == 53 && b == 28)
		{
			return 81;
		}
		else if(a == 53 && b == 29)
		{
			return 82;
		}
		else if(a == 53 && b == 30)
		{
			return 83;
		}
		else if(a == 53 && b == 31)
		{
			return 84;
		}
		else if(a == 53 && b == 32)
		{
			return 85;
		}
		else if(a == 53 && b == 33)
		{
			return 86;
		}
		else if(a == 53 && b == 34)
		{
			return 87;
		}
		else if(a == 53 && b == 35)
		{
			return 88;
		}
		else if(a == 53 && b == 36)
		{
			return 89;
		}
		else if(a == 53 && b == 37)
		{
			return 90;
		}
		else if(a == 53 && b == 38)
		{
			return 91;
		}
		else if(a == 53 && b == 39)
		{
			return 92;
		}
		else if(a == 53 && b == 40)
		{
			return 93;
		}
		else if(a == 53 && b == 41)
		{
			return 94;
		}
		else if(a == 53 && b == 42)
		{
			return 95;
		}
		else if(a == 53 && b == 43)
		{
			return 96;
		}
		else if(a == 53 && b == 44)
		{
			return 97;
		}
		else if(a == 53 && b == 45)
		{
			return 98;
		}
		else if(a == 53 && b == 46)
		{
			return 99;
		}
		else if(a == 53 && b == 47)
		{
			return 100;
		}
		else if(a == 53 && b == 48)
		{
			return 101;
		}
		else if(a == 53 && b == 49)
		{
			return 102;
		}
		else if(a == 53 && b == 50)
		{
			return 103;
		}
		else if(a == 53 && b == 51)
		{
			return 104;
		}
		else if(a == 53 && b == 52)
		{
			return 105;
		}
		else if(a == 53 && b == 53)
		{
			return 106;
		}
		else if(a == 53 && b == 54)
		{
			return 107;
		}
		else if(a == 53 && b == 55)
		{
			return 108;
		}
		else if(a == 53 && b == 56)
		{
			return 109;
		}
		else if(a == 53 && b == 57)
		{
			return 110;
		}
		else if(a == 53 && b == 58)
		{
			return 111;
		}
		else if(a == 53 && b == 59)
		{
			return 112;
		}
		else if(a == 53 && b == 60)
		{
			return 113;
		}
		else if(a == 53 && b == 61)
		{
			return 114;
		}
		else if(a == 53 && b == 62)
		{
			return 115;
		}
		else if(a == 53 && b == 63)
		{
			return 116;
		}
		else if(a == 53 && b == 64)
		{
			return 117;
		}
		else if(a == 53 && b == 65)
		{
			return 118;
		}
		else if(a == 53 && b == 66)
		{
			return 119;
		}
		else if(a == 53 && b == 67)
		{
			return 120;
		}
		else if(a == 53 && b == 68)
		{
			return 121;
		}
		else if(a == 53 && b == 69)
		{
			return 122;
		}
		else if(a == 53 && b == 70)
		{
			return 123;
		}
		else if(a == 53 && b == 71)
		{
			return 124;
		}
		else if(a == 53 && b == 72)
		{
			return 125;
		}
		else if(a == 53 && b == 73)
		{
			return 126;
		}
		else if(a == 53 && b == 74)
		{
			return 127;
		}
		else if(a == 53 && b == 75)
		{
			return 128;
		}
		else if(a == 53 && b == 76)
		{
			return 129;
		}
		else if(a == 53 && b == 77)
		{
			return 130;
		}
		else if(a == 53 && b == 78)
		{
			return 131;
		}
		else if(a == 53 && b == 79)
		{
			return 132;
		}
		else if(a == 53 && b == 80)
		{
			return 133;
		}
		else if(a == 53 && b == 81)
		{
			return 134;
		}
		else if(a == 53 && b == 82)
		{
			return 135;
		}
		else if(a == 53 && b == 83)
		{
			return 136;
		}
		else if(a == 53 && b == 84)
		{
			return 137;
		}
		else if(a == 53 && b == 85)
		{
			return 138;
		}
		else if(a == 53 && b == 86)
		{
			return 139;
		}
		else if(a == 53 && b == 87)
		{
			return 140;
		}
		else if(a == 53 && b == 88)
		{
			return 141;
		}
		else if(a == 53 && b == 89)
		{
			return 142;
		}
		else if(a == 53 && b == 90)
		{
			return 143;
		}
		else if(a == 53 && b == 91)
		{
			return 144;
		}
		else if(a == 53 && b == 92)
		{
			return 145;
		}
		else if(a == 53 && b == 93)
		{
			return 146;
		}
		else if(a == 53 && b == 94)
		{
			return 147;
		}
		else if(a == 53 && b == 95)
		{
			return 148;
		}
		else if(a == 53 && b == 96)
		{
			return 149;
		}
		else if(a == 53 && b == 97)
		{
			return 150;
		}
		else if(a == 53 && b == 98)
		{
			return 151;
		}
		else if(a == 53 && b == 99)
		{
			return 152;
		}
		else if(a == 53 && b == 100)
		{
			return 153;
		}
		else if(a == 54 && b == 0)
		{
			return 54;
		}
		else if(a == 54 && b == 1)
		{
			return 55;
		}
		else if(a == 54 && b == 2)
		{
			return 56;
		}
		else if(a == 54 && b == 3)
		{
			return 57;
		}
		else if(a == 54 && b == 4)
		{
			return 58;
		}
		else if(a == 54 && b == 5)
		{
			return 59;
		}
		else if(a == 54 && b == 6)
		{
			return 60;
		}
		else if(a == 54 && b == 7)
		{
			return 61;
		}
		else if(a == 54 && b == 8)
		{
			return 62;
		}
		else if(a == 54 && b == 9)
		{
			return 63;
		}
		else if(a == 54 && b == 10)
		{
			return 64;
		}
		else if(a == 54 && b == 11)
		{
			return 65;
		}
		else if(a == 54 && b == 12)
		{
			return 66;
		}
		else if(a == 54 && b == 13)
		{
			return 67;
		}
		else if(a == 54 && b == 14)
		{
			return 68;
		}
		else if(a == 54 && b == 15)
		{
			return 69;
		}
		else if(a == 54 && b == 16)
		{
			return 70;
		}
		else if(a == 54 && b == 17)
		{
			return 71;
		}
		else if(a == 54 && b == 18)
		{
			return 72;
		}
		else if(a == 54 && b == 19)
		{
			return 73;
		}
		else if(a == 54 && b == 20)
		{
			return 74;
		}
		else if(a == 54 && b == 21)
		{
			return 75;
		}
		else if(a == 54 && b == 22)
		{
			return 76;
		}
		else if(a == 54 && b == 23)
		{
			return 77;
		}
		else if(a == 54 && b == 24)
		{
			return 78;
		}
		else if(a == 54 && b == 25)
		{
			return 79;
		}
		else if(a == 54 && b == 26)
		{
			return 80;
		}
		else if(a == 54 && b == 27)
		{
			return 81;
		}
		else if(a == 54 && b == 28)
		{
			return 82;
		}
		else if(a == 54 && b == 29)
		{
			return 83;
		}
		else if(a == 54 && b == 30)
		{
			return 84;
		}
		else if(a == 54 && b == 31)
		{
			return 85;
		}
		else if(a == 54 && b == 32)
		{
			return 86;
		}
		else if(a == 54 && b == 33)
		{
			return 87;
		}
		else if(a == 54 && b == 34)
		{
			return 88;
		}
		else if(a == 54 && b == 35)
		{
			return 89;
		}
		else if(a == 54 && b == 36)
		{
			return 90;
		}
		else if(a == 54 && b == 37)
		{
			return 91;
		}
		else if(a == 54 && b == 38)
		{
			return 92;
		}
		else if(a == 54 && b == 39)
		{
			return 93;
		}
		else if(a == 54 && b == 40)
		{
			return 94;
		}
		else if(a == 54 && b == 41)
		{
			return 95;
		}
		else if(a == 54 && b == 42)
		{
			return 96;
		}
		else if(a == 54 && b == 43)
		{
			return 97;
		}
		else if(a == 54 && b == 44)
		{
			return 98;
		}
		else if(a == 54 && b == 45)
		{
			return 99;
		}
		else if(a == 54 && b == 46)
		{
			return 100;
		}
		else if(a == 54 && b == 47)
		{
			return 101;
		}
		else if(a == 54 && b == 48)
		{
			return 102;
		}
		else if(a == 54 && b == 49)
		{
			return 103;
		}
		else if(a == 54 && b == 50)
		{
			return 104;
		}
		else if(a == 54 && b == 51)
		{
			return 105;
		}
		else if(a == 54 && b == 52)
		{
			return 106;
		}
		else if(a == 54 && b == 53)
		{
			return 107;
		}
		else if(a == 54 && b == 54)
		{
			return 108;
		}
		else if(a == 54 && b == 55)
		{
			return 109;
		}
		else if(a == 54 && b == 56)
		{
			return 110;
		}
		else if(a == 54 && b == 57)
		{
			return 111;
		}
		else if(a == 54 && b == 58)
		{
			return 112;
		}
		else if(a == 54 && b == 59)
		{
			return 113;
		}
		else if(a == 54 && b == 60)
		{
			return 114;
		}
		else if(a == 54 && b == 61)
		{
			return 115;
		}
		else if(a == 54 && b == 62)
		{
			return 116;
		}
		else if(a == 54 && b == 63)
		{
			return 117;
		}
		else if(a == 54 && b == 64)
		{
			return 118;
		}
		else if(a == 54 && b == 65)
		{
			return 119;
		}
		else if(a == 54 && b == 66)
		{
			return 120;
		}
		else if(a == 54 && b == 67)
		{
			return 121;
		}
		else if(a == 54 && b == 68)
		{
			return 122;
		}
		else if(a == 54 && b == 69)
		{
			return 123;
		}
		else if(a == 54 && b == 70)
		{
			return 124;
		}
		else if(a == 54 && b == 71)
		{
			return 125;
		}
		else if(a == 54 && b == 72)
		{
			return 126;
		}
		else if(a == 54 && b == 73)
		{
			return 127;
		}
		else if(a == 54 && b == 74)
		{
			return 128;
		}
		else if(a == 54 && b == 75)
		{
			return 129;
		}
		else if(a == 54 && b == 76)
		{
			return 130;
		}
		else if(a == 54 && b == 77)
		{
			return 131;
		}
		else if(a == 54 && b == 78)
		{
			return 132;
		}
		else if(a == 54 && b == 79)
		{
			return 133;
		}
		else if(a == 54 && b == 80)
		{
			return 134;
		}
		else if(a == 54 && b == 81)
		{
			return 135;
		}
		else if(a == 54 && b == 82)
		{
			return 136;
		}
		else if(a == 54 && b == 83)
		{
			return 137;
		}
		else if(a == 54 && b == 84)
		{
			return 138;
		}
		else if(a == 54 && b == 85)
		{
			return 139;
		}
		else if(a == 54 && b == 86)
		{
			return 140;
		}
		else if(a == 54 && b == 87)
		{
			return 141;
		}
		else if(a == 54 && b == 88)
		{
			return 142;
		}
		else if(a == 54 && b == 89)
		{
			return 143;
		}
		else if(a == 54 && b == 90)
		{
			return 144;
		}
		else if(a == 54 && b == 91)
		{
			return 145;
		}
		else if(a == 54 && b == 92)
		{
			return 146;
		}
		else if(a == 54 && b == 93)
		{
			return 147;
		}
		else if(a == 54 && b == 94)
		{
			return 148;
		}
		else if(a == 54 && b == 95)
		{
			return 149;
		}
		else if(a == 54 && b == 96)
		{
			return 150;
		}
		else if(a == 54 && b == 97)
		{
			return 151;
		}
		else if(a == 54 && b == 98)
		{
			return 152;
		}
		else if(a == 54 && b == 99)
		{
			return 153;
		}
		else if(a == 54 && b == 100)
		{
			return 154;
		}
		else if(a == 55 && b == 0)
		{
			return 55;
		}
		else if(a == 55 && b == 1)
		{
			return 56;
		}
		else if(a == 55 && b == 2)
		{
			return 57;
		}
		else if(a == 55 && b == 3)
		{
			return 58;
		}
		else if(a == 55 && b == 4)
		{
			return 59;
		}
		else if(a == 55 && b == 5)
		{
			return 60;
		}
		else if(a == 55 && b == 6)
		{
			return 61;
		}
		else if(a == 55 && b == 7)
		{
			return 62;
		}
		else if(a == 55 && b == 8)
		{
			return 63;
		}
		else if(a == 55 && b == 9)
		{
			return 64;
		}
		else if(a == 55 && b == 10)
		{
			return 65;
		}
		else if(a == 55 && b == 11)
		{
			return 66;
		}
		else if(a == 55 && b == 12)
		{
			return 67;
		}
		else if(a == 55 && b == 13)
		{
			return 68;
		}
		else if(a == 55 && b == 14)
		{
			return 69;
		}
		else if(a == 55 && b == 15)
		{
			return 70;
		}
		else if(a == 55 && b == 16)
		{
			return 71;
		}
		else if(a == 55 && b == 17)
		{
			return 72;
		}
		else if(a == 55 && b == 18)
		{
			return 73;
		}
		else if(a == 55 && b == 19)
		{
			return 74;
		}
		else if(a == 55 && b == 20)
		{
			return 75;
		}
		else if(a == 55 && b == 21)
		{
			return 76;
		}
		else if(a == 55 && b == 22)
		{
			return 77;
		}
		else if(a == 55 && b == 23)
		{
			return 78;
		}
		else if(a == 55 && b == 24)
		{
			return 79;
		}
		else if(a == 55 && b == 25)
		{
			return 80;
		}
		else if(a == 55 && b == 26)
		{
			return 81;
		}
		else if(a == 55 && b == 27)
		{
			return 82;
		}
		else if(a == 55 && b == 28)
		{
			return 83;
		}
		else if(a == 55 && b == 29)
		{
			return 84;
		}
		else if(a == 55 && b == 30)
		{
			return 85;
		}
		else if(a == 55 && b == 31)
		{
			return 86;
		}
		else if(a == 55 && b == 32)
		{
			return 87;
		}
		else if(a == 55 && b == 33)
		{
			return 88;
		}
		else if(a == 55 && b == 34)
		{
			return 89;
		}
		else if(a == 55 && b == 35)
		{
			return 90;
		}
		else if(a == 55 && b == 36)
		{
			return 91;
		}
		else if(a == 55 && b == 37)
		{
			return 92;
		}
		else if(a == 55 && b == 38)
		{
			return 93;
		}
		else if(a == 55 && b == 39)
		{
			return 94;
		}
		else if(a == 55 && b == 40)
		{
			return 95;
		}
		else if(a == 55 && b == 41)
		{
			return 96;
		}
		else if(a == 55 && b == 42)
		{
			return 97;
		}
		else if(a == 55 && b == 43)
		{
			return 98;
		}
		else if(a == 55 && b == 44)
		{
			return 99;
		}
		else if(a == 55 && b == 45)
		{
			return 100;
		}
		else if(a == 55 && b == 46)
		{
			return 101;
		}
		else if(a == 55 && b == 47)
		{
			return 102;
		}
		else if(a == 55 && b == 48)
		{
			return 103;
		}
		else if(a == 55 && b == 49)
		{
			return 104;
		}
		else if(a == 55 && b == 50)
		{
			return 105;
		}
		else if(a == 55 && b == 51)
		{
			return 106;
		}
		else if(a == 55 && b == 52)
		{
			return 107;
		}
		else if(a == 55 && b == 53)
		{
			return 108;
		}
		else if(a == 55 && b == 54)
		{
			return 109;
		}
		else if(a == 55 && b == 55)
		{
			return 110;
		}
		else if(a == 55 && b == 56)
		{
			return 111;
		}
		else if(a == 55 && b == 57)
		{
			return 112;
		}
		else if(a == 55 && b == 58)
		{
			return 113;
		}
		else if(a == 55 && b == 59)
		{
			return 114;
		}
		else if(a == 55 && b == 60)
		{
			return 115;
		}
		else if(a == 55 && b == 61)
		{
			return 116;
		}
		else if(a == 55 && b == 62)
		{
			return 117;
		}
		else if(a == 55 && b == 63)
		{
			return 118;
		}
		else if(a == 55 && b == 64)
		{
			return 119;
		}
		else if(a == 55 && b == 65)
		{
			return 120;
		}
		else if(a == 55 && b == 66)
		{
			return 121;
		}
		else if(a == 55 && b == 67)
		{
			return 122;
		}
		else if(a == 55 && b == 68)
		{
			return 123;
		}
		else if(a == 55 && b == 69)
		{
			return 124;
		}
		else if(a == 55 && b == 70)
		{
			return 125;
		}
		else if(a == 55 && b == 71)
		{
			return 126;
		}
		else if(a == 55 && b == 72)
		{
			return 127;
		}
		else if(a == 55 && b == 73)
		{
			return 128;
		}
		else if(a == 55 && b == 74)
		{
			return 129;
		}
		else if(a == 55 && b == 75)
		{
			return 130;
		}
		else if(a == 55 && b == 76)
		{
			return 131;
		}
		else if(a == 55 && b == 77)
		{
			return 132;
		}
		else if(a == 55 && b == 78)
		{
			return 133;
		}
		else if(a == 55 && b == 79)
		{
			return 134;
		}
		else if(a == 55 && b == 80)
		{
			return 135;
		}
		else if(a == 55 && b == 81)
		{
			return 136;
		}
		else if(a == 55 && b == 82)
		{
			return 137;
		}
		else if(a == 55 && b == 83)
		{
			return 138;
		}
		else if(a == 55 && b == 84)
		{
			return 139;
		}
		else if(a == 55 && b == 85)
		{
			return 140;
		}
		else if(a == 55 && b == 86)
		{
			return 141;
		}
		else if(a == 55 && b == 87)
		{
			return 142;
		}
		else if(a == 55 && b == 88)
		{
			return 143;
		}
		else if(a == 55 && b == 89)
		{
			return 144;
		}
		else if(a == 55 && b == 90)
		{
			return 145;
		}
		else if(a == 55 && b == 91)
		{
			return 146;
		}
		else if(a == 55 && b == 92)
		{
			return 147;
		}
		else if(a == 55 && b == 93)
		{
			return 148;
		}
		else if(a == 55 && b == 94)
		{
			return 149;
		}
		else if(a == 55 && b == 95)
		{
			return 150;
		}
		else if(a == 55 && b == 96)
		{
			return 151;
		}
		else if(a == 55 && b == 97)
		{
			return 152;
		}
		else if(a == 55 && b == 98)
		{
			return 153;
		}
		else if(a == 55 && b == 99)
		{
			return 154;
		}
		else if(a == 55 && b == 100)
		{
			return 155;
		}
		else if(a == 56 && b == 0)
		{
			return 56;
		}
		else if(a == 56 && b == 1)
		{
			return 57;
		}
		else if(a == 56 && b == 2)
		{
			return 58;
		}
		else if(a == 56 && b == 3)
		{
			return 59;
		}
		else if(a == 56 && b == 4)
		{
			return 60;
		}
		else if(a == 56 && b == 5)
		{
			return 61;
		}
		else if(a == 56 && b == 6)
		{
			return 62;
		}
		else if(a == 56 && b == 7)
		{
			return 63;
		}
		else if(a == 56 && b == 8)
		{
			return 64;
		}
		else if(a == 56 && b == 9)
		{
			return 65;
		}
		else if(a == 56 && b == 10)
		{
			return 66;
		}
		else if(a == 56 && b == 11)
		{
			return 67;
		}
		else if(a == 56 && b == 12)
		{
			return 68;
		}
		else if(a == 56 && b == 13)
		{
			return 69;
		}
		else if(a == 56 && b == 14)
		{
			return 70;
		}
		else if(a == 56 && b == 15)
		{
			return 71;
		}
		else if(a == 56 && b == 16)
		{
			return 72;
		}
		else if(a == 56 && b == 17)
		{
			return 73;
		}
		else if(a == 56 && b == 18)
		{
			return 74;
		}
		else if(a == 56 && b == 19)
		{
			return 75;
		}
		else if(a == 56 && b == 20)
		{
			return 76;
		}
		else if(a == 56 && b == 21)
		{
			return 77;
		}
		else if(a == 56 && b == 22)
		{
			return 78;
		}
		else if(a == 56 && b == 23)
		{
			return 79;
		}
		else if(a == 56 && b == 24)
		{
			return 80;
		}
		else if(a == 56 && b == 25)
		{
			return 81;
		}
		else if(a == 56 && b == 26)
		{
			return 82;
		}
		else if(a == 56 && b == 27)
		{
			return 83;
		}
		else if(a == 56 && b == 28)
		{
			return 84;
		}
		else if(a == 56 && b == 29)
		{
			return 85;
		}
		else if(a == 56 && b == 30)
		{
			return 86;
		}
		else if(a == 56 && b == 31)
		{
			return 87;
		}
		else if(a == 56 && b == 32)
		{
			return 88;
		}
		else if(a == 56 && b == 33)
		{
			return 89;
		}
		else if(a == 56 && b == 34)
		{
			return 90;
		}
		else if(a == 56 && b == 35)
		{
			return 91;
		}
		else if(a == 56 && b == 36)
		{
			return 92;
		}
		else if(a == 56 && b == 37)
		{
			return 93;
		}
		else if(a == 56 && b == 38)
		{
			return 94;
		}
		else if(a == 56 && b == 39)
		{
			return 95;
		}
		else if(a == 56 && b == 40)
		{
			return 96;
		}
		else if(a == 56 && b == 41)
		{
			return 97;
		}
		else if(a == 56 && b == 42)
		{
			return 98;
		}
		else if(a == 56 && b == 43)
		{
			return 99;
		}
		else if(a == 56 && b == 44)
		{
			return 100;
		}
		else if(a == 56 && b == 45)
		{
			return 101;
		}
		else if(a == 56 && b == 46)
		{
			return 102;
		}
		else if(a == 56 && b == 47)
		{
			return 103;
		}
		else if(a == 56 && b == 48)
		{
			return 104;
		}
		else if(a == 56 && b == 49)
		{
			return 105;
		}
		else if(a == 56 && b == 50)
		{
			return 106;
		}
		else if(a == 56 && b == 51)
		{
			return 107;
		}
		else if(a == 56 && b == 52)
		{
			return 108;
		}
		else if(a == 56 && b == 53)
		{
			return 109;
		}
		else if(a == 56 && b == 54)
		{
			return 110;
		}
		else if(a == 56 && b == 55)
		{
			return 111;
		}
		else if(a == 56 && b == 56)
		{
			return 112;
		}
		else if(a == 56 && b == 57)
		{
			return 113;
		}
		else if(a == 56 && b == 58)
		{
			return 114;
		}
		else if(a == 56 && b == 59)
		{
			return 115;
		}
		else if(a == 56 && b == 60)
		{
			return 116;
		}
		else if(a == 56 && b == 61)
		{
			return 117;
		}
		else if(a == 56 && b == 62)
		{
			return 118;
		}
		else if(a == 56 && b == 63)
		{
			return 119;
		}
		else if(a == 56 && b == 64)
		{
			return 120;
		}
		else if(a == 56 && b == 65)
		{
			return 121;
		}
		else if(a == 56 && b == 66)
		{
			return 122;
		}
		else if(a == 56 && b == 67)
		{
			return 123;
		}
		else if(a == 56 && b == 68)
		{
			return 124;
		}
		else if(a == 56 && b == 69)
		{
			return 125;
		}
		else if(a == 56 && b == 70)
		{
			return 126;
		}
		else if(a == 56 && b == 71)
		{
			return 127;
		}
		else if(a == 56 && b == 72)
		{
			return 128;
		}
		else if(a == 56 && b == 73)
		{
			return 129;
		}
		else if(a == 56 && b == 74)
		{
			return 130;
		}
		else if(a == 56 && b == 75)
		{
			return 131;
		}
		else if(a == 56 && b == 76)
		{
			return 132;
		}
		else if(a == 56 && b == 77)
		{
			return 133;
		}
		else if(a == 56 && b == 78)
		{
			return 134;
		}
		else if(a == 56 && b == 79)
		{
			return 135;
		}
		else if(a == 56 && b == 80)
		{
			return 136;
		}
		else if(a == 56 && b == 81)
		{
			return 137;
		}
		else if(a == 56 && b == 82)
		{
			return 138;
		}
		else if(a == 56 && b == 83)
		{
			return 139;
		}
		else if(a == 56 && b == 84)
		{
			return 140;
		}
		else if(a == 56 && b == 85)
		{
			return 141;
		}
		else if(a == 56 && b == 86)
		{
			return 142;
		}
		else if(a == 56 && b == 87)
		{
			return 143;
		}
		else if(a == 56 && b == 88)
		{
			return 144;
		}
		else if(a == 56 && b == 89)
		{
			return 145;
		}
		else if(a == 56 && b == 90)
		{
			return 146;
		}
		else if(a == 56 && b == 91)
		{
			return 147;
		}
		else if(a == 56 && b == 92)
		{
			return 148;
		}
		else if(a == 56 && b == 93)
		{
			return 149;
		}
		else if(a == 56 && b == 94)
		{
			return 150;
		}
		else if(a == 56 && b == 95)
		{
			return 151;
		}
		else if(a == 56 && b == 96)
		{
			return 152;
		}
		else if(a == 56 && b == 97)
		{
			return 153;
		}
		else if(a == 56 && b == 98)
		{
			return 154;
		}
		else if(a == 56 && b == 99)
		{
			return 155;
		}
		else if(a == 56 && b == 100)
		{
			return 156;
		}
		else if(a == 57 && b == 0)
		{
			return 57;
		}
		else if(a == 57 && b == 1)
		{
			return 58;
		}
		else if(a == 57 && b == 2)
		{
			return 59;
		}
		else if(a == 57 && b == 3)
		{
			return 60;
		}
		else if(a == 57 && b == 4)
		{
			return 61;
		}
		else if(a == 57 && b == 5)
		{
			return 62;
		}
		else if(a == 57 && b == 6)
		{
			return 63;
		}
		else if(a == 57 && b == 7)
		{
			return 64;
		}
		else if(a == 57 && b == 8)
		{
			return 65;
		}
		else if(a == 57 && b == 9)
		{
			return 66;
		}
		else if(a == 57 && b == 10)
		{
			return 67;
		}
		else if(a == 57 && b == 11)
		{
			return 68;
		}
		else if(a == 57 && b == 12)
		{
			return 69;
		}
		else if(a == 57 && b == 13)
		{
			return 70;
		}
		else if(a == 57 && b == 14)
		{
			return 71;
		}
		else if(a == 57 && b == 15)
		{
			return 72;
		}
		else if(a == 57 && b == 16)
		{
			return 73;
		}
		else if(a == 57 && b == 17)
		{
			return 74;
		}
		else if(a == 57 && b == 18)
		{
			return 75;
		}
		else if(a == 57 && b == 19)
		{
			return 76;
		}
		else if(a == 57 && b == 20)
		{
			return 77;
		}
		else if(a == 57 && b == 21)
		{
			return 78;
		}
		else if(a == 57 && b == 22)
		{
			return 79;
		}
		else if(a == 57 && b == 23)
		{
			return 80;
		}
		else if(a == 57 && b == 24)
		{
			return 81;
		}
		else if(a == 57 && b == 25)
		{
			return 82;
		}
		else if(a == 57 && b == 26)
		{
			return 83;
		}
		else if(a == 57 && b == 27)
		{
			return 84;
		}
		else if(a == 57 && b == 28)
		{
			return 85;
		}
		else if(a == 57 && b == 29)
		{
			return 86;
		}
		else if(a == 57 && b == 30)
		{
			return 87;
		}
		else if(a == 57 && b == 31)
		{
			return 88;
		}
		else if(a == 57 && b == 32)
		{
			return 89;
		}
		else if(a == 57 && b == 33)
		{
			return 90;
		}
		else if(a == 57 && b == 34)
		{
			return 91;
		}
		else if(a == 57 && b == 35)
		{
			return 92;
		}
		else if(a == 57 && b == 36)
		{
			return 93;
		}
		else if(a == 57 && b == 37)
		{
			return 94;
		}
		else if(a == 57 && b == 38)
		{
			return 95;
		}
		else if(a == 57 && b == 39)
		{
			return 96;
		}
		else if(a == 57 && b == 40)
		{
			return 97;
		}
		else if(a == 57 && b == 41)
		{
			return 98;
		}
		else if(a == 57 && b == 42)
		{
			return 99;
		}
		else if(a == 57 && b == 43)
		{
			return 100;
		}
		else if(a == 57 && b == 44)
		{
			return 101;
		}
		else if(a == 57 && b == 45)
		{
			return 102;
		}
		else if(a == 57 && b == 46)
		{
			return 103;
		}
		else if(a == 57 && b == 47)
		{
			return 104;
		}
		else if(a == 57 && b == 48)
		{
			return 105;
		}
		else if(a == 57 && b == 49)
		{
			return 106;
		}
		else if(a == 57 && b == 50)
		{
			return 107;
		}
		else if(a == 57 && b == 51)
		{
			return 108;
		}
		else if(a == 57 && b == 52)
		{
			return 109;
		}
		else if(a == 57 && b == 53)
		{
			return 110;
		}
		else if(a == 57 && b == 54)
		{
			return 111;
		}
		else if(a == 57 && b == 55)
		{
			return 112;
		}
		else if(a == 57 && b == 56)
		{
			return 113;
		}
		else if(a == 57 && b == 57)
		{
			return 114;
		}
		else if(a == 57 && b == 58)
		{
			return 115;
		}
		else if(a == 57 && b == 59)
		{
			return 116;
		}
		else if(a == 57 && b == 60)
		{
			return 117;
		}
		else if(a == 57 && b == 61)
		{
			return 118;
		}
		else if(a == 57 && b == 62)
		{
			return 119;
		}
		else if(a == 57 && b == 63)
		{
			return 120;
		}
		else if(a == 57 && b == 64)
		{
			return 121;
		}
		else if(a == 57 && b == 65)
		{
			return 122;
		}
		else if(a == 57 && b == 66)
		{
			return 123;
		}
		else if(a == 57 && b == 67)
		{
			return 124;
		}
		else if(a == 57 && b == 68)
		{
			return 125;
		}
		else if(a == 57 && b == 69)
		{
			return 126;
		}
		else if(a == 57 && b == 70)
		{
			return 127;
		}
		else if(a == 57 && b == 71)
		{
			return 128;
		}
		else if(a == 57 && b == 72)
		{
			return 129;
		}
		else if(a == 57 && b == 73)
		{
			return 130;
		}
		else if(a == 57 && b == 74)
		{
			return 131;
		}
		else if(a == 57 && b == 75)
		{
			return 132;
		}
		else if(a == 57 && b == 76)
		{
			return 133;
		}
		else if(a == 57 && b == 77)
		{
			return 134;
		}
		else if(a == 57 && b == 78)
		{
			return 135;
		}
		else if(a == 57 && b == 79)
		{
			return 136;
		}
		else if(a == 57 && b == 80)
		{
			return 137;
		}
		else if(a == 57 && b == 81)
		{
			return 138;
		}
		else if(a == 57 && b == 82)
		{
			return 139;
		}
		else if(a == 57 && b == 83)
		{
			return 140;
		}
		else if(a == 57 && b == 84)
		{
			return 141;
		}
		else if(a == 57 && b == 85)
		{
			return 142;
		}
		else if(a == 57 && b == 86)
		{
			return 143;
		}
		else if(a == 57 && b == 87)
		{
			return 144;
		}
		else if(a == 57 && b == 88)
		{
			return 145;
		}
		else if(a == 57 && b == 89)
		{
			return 146;
		}
		else if(a == 57 && b == 90)
		{
			return 147;
		}
		else if(a == 57 && b == 91)
		{
			return 148;
		}
		else if(a == 57 && b == 92)
		{
			return 149;
		}
		else if(a == 57 && b == 93)
		{
			return 150;
		}
		else if(a == 57 && b == 94)
		{
			return 151;
		}
		else if(a == 57 && b == 95)
		{
			return 152;
		}
		else if(a == 57 && b == 96)
		{
			return 153;
		}
		else if(a == 57 && b == 97)
		{
			return 154;
		}
		else if(a == 57 && b == 98)
		{
			return 155;
		}
		else if(a == 57 && b == 99)
		{
			return 156;
		}
		else if(a == 57 && b == 100)
		{
			return 157;
		}
		else if(a == 58 && b == 0)
		{
			return 58;
		}
		else if(a == 58 && b == 1)
		{
			return 59;
		}
		else if(a == 58 && b == 2)
		{
			return 60;
		}
		else if(a == 58 && b == 3)
		{
			return 61;
		}
		else if(a == 58 && b == 4)
		{
			return 62;
		}
		else if(a == 58 && b == 5)
		{
			return 63;
		}
		else if(a == 58 && b == 6)
		{
			return 64;
		}
		else if(a == 58 && b == 7)
		{
			return 65;
		}
		else if(a == 58 && b == 8)
		{
			return 66;
		}
		else if(a == 58 && b == 9)
		{
			return 67;
		}
		else if(a == 58 && b == 10)
		{
			return 68;
		}
		else if(a == 58 && b == 11)
		{
			return 69;
		}
		else if(a == 58 && b == 12)
		{
			return 70;
		}
		else if(a == 58 && b == 13)
		{
			return 71;
		}
		else if(a == 58 && b == 14)
		{
			return 72;
		}
		else if(a == 58 && b == 15)
		{
			return 73;
		}
		else if(a == 58 && b == 16)
		{
			return 74;
		}
		else if(a == 58 && b == 17)
		{
			return 75;
		}
		else if(a == 58 && b == 18)
		{
			return 76;
		}
		else if(a == 58 && b == 19)
		{
			return 77;
		}
		else if(a == 58 && b == 20)
		{
			return 78;
		}
		else if(a == 58 && b == 21)
		{
			return 79;
		}
		else if(a == 58 && b == 22)
		{
			return 80;
		}
		else if(a == 58 && b == 23)
		{
			return 81;
		}
		else if(a == 58 && b == 24)
		{
			return 82;
		}
		else if(a == 58 && b == 25)
		{
			return 83;
		}
		else if(a == 58 && b == 26)
		{
			return 84;
		}
		else if(a == 58 && b == 27)
		{
			return 85;
		}
		else if(a == 58 && b == 28)
		{
			return 86;
		}
		else if(a == 58 && b == 29)
		{
			return 87;
		}
		else if(a == 58 && b == 30)
		{
			return 88;
		}
		else if(a == 58 && b == 31)
		{
			return 89;
		}
		else if(a == 58 && b == 32)
		{
			return 90;
		}
		else if(a == 58 && b == 33)
		{
			return 91;
		}
		else if(a == 58 && b == 34)
		{
			return 92;
		}
		else if(a == 58 && b == 35)
		{
			return 93;
		}
		else if(a == 58 && b == 36)
		{
			return 94;
		}
		else if(a == 58 && b == 37)
		{
			return 95;
		}
		else if(a == 58 && b == 38)
		{
			return 96;
		}
		else if(a == 58 && b == 39)
		{
			return 97;
		}
		else if(a == 58 && b == 40)
		{
			return 98;
		}
		else if(a == 58 && b == 41)
		{
			return 99;
		}
		else if(a == 58 && b == 42)
		{
			return 100;
		}
		else if(a == 58 && b == 43)
		{
			return 101;
		}
		else if(a == 58 && b == 44)
		{
			return 102;
		}
		else if(a == 58 && b == 45)
		{
			return 103;
		}
		else if(a == 58 && b == 46)
		{
			return 104;
		}
		else if(a == 58 && b == 47)
		{
			return 105;
		}
		else if(a == 58 && b == 48)
		{
			return 106;
		}
		else if(a == 58 && b == 49)
		{
			return 107;
		}
		else if(a == 58 && b == 50)
		{
			return 108;
		}
		else if(a == 58 && b == 51)
		{
			return 109;
		}
		else if(a == 58 && b == 52)
		{
			return 110;
		}
		else if(a == 58 && b == 53)
		{
			return 111;
		}
		else if(a == 58 && b == 54)
		{
			return 112;
		}
		else if(a == 58 && b == 55)
		{
			return 113;
		}
		else if(a == 58 && b == 56)
		{
			return 114;
		}
		else if(a == 58 && b == 57)
		{
			return 115;
		}
		else if(a == 58 && b == 58)
		{
			return 116;
		}
		else if(a == 58 && b == 59)
		{
			return 117;
		}
		else if(a == 58 && b == 60)
		{
			return 118;
		}
		else if(a == 58 && b == 61)
		{
			return 119;
		}
		else if(a == 58 && b == 62)
		{
			return 120;
		}
		else if(a == 58 && b == 63)
		{
			return 121;
		}
		else if(a == 58 && b == 64)
		{
			return 122;
		}
		else if(a == 58 && b == 65)
		{
			return 123;
		}
		else if(a == 58 && b == 66)
		{
			return 124;
		}
		else if(a == 58 && b == 67)
		{
			return 125;
		}
		else if(a == 58 && b == 68)
		{
			return 126;
		}
		else if(a == 58 && b == 69)
		{
			return 127;
		}
		else if(a == 58 && b == 70)
		{
			return 128;
		}
		else if(a == 58 && b == 71)
		{
			return 129;
		}
		else if(a == 58 && b == 72)
		{
			return 130;
		}
		else if(a == 58 && b == 73)
		{
			return 131;
		}
		else if(a == 58 && b == 74)
		{
			return 132;
		}
		else if(a == 58 && b == 75)
		{
			return 133;
		}
		else if(a == 58 && b == 76)
		{
			return 134;
		}
		else if(a == 58 && b == 77)
		{
			return 135;
		}
		else if(a == 58 && b == 78)
		{
			return 136;
		}
		else if(a == 58 && b == 79)
		{
			return 137;
		}
		else if(a == 58 && b == 80)
		{
			return 138;
		}
		else if(a == 58 && b == 81)
		{
			return 139;
		}
		else if(a == 58 && b == 82)
		{
			return 140;
		}
		else if(a == 58 && b == 83)
		{
			return 141;
		}
		else if(a == 58 && b == 84)
		{
			return 142;
		}
		else if(a == 58 && b == 85)
		{
			return 143;
		}
		else if(a == 58 && b == 86)
		{
			return 144;
		}
		else if(a == 58 && b == 87)
		{
			return 145;
		}
		else if(a == 58 && b == 88)
		{
			return 146;
		}
		else if(a == 58 && b == 89)
		{
			return 147;
		}
		else if(a == 58 && b == 90)
		{
			return 148;
		}
		else if(a == 58 && b == 91)
		{
			return 149;
		}
		else if(a == 58 && b == 92)
		{
			return 150;
		}
		else if(a == 58 && b == 93)
		{
			return 151;
		}
		else if(a == 58 && b == 94)
		{
			return 152;
		}
		else if(a == 58 && b == 95)
		{
			return 153;
		}
		else if(a == 58 && b == 96)
		{
			return 154;
		}
		else if(a == 58 && b == 97)
		{
			return 155;
		}
		else if(a == 58 && b == 98)
		{
			return 156;
		}
		else if(a == 58 && b == 99)
		{
			return 157;
		}
		else if(a == 58 && b == 100)
		{
			return 158;
		}
		else if(a == 59 && b == 0)
		{
			return 59;
		}
		else if(a == 59 && b == 1)
		{
			return 60;
		}
		else if(a == 59 && b == 2)
		{
			return 61;
		}
		else if(a == 59 && b == 3)
		{
			return 62;
		}
		else if(a == 59 && b == 4)
		{
			return 63;
		}
		else if(a == 59 && b == 5)
		{
			return 64;
		}
		else if(a == 59 && b == 6)
		{
			return 65;
		}
		else if(a == 59 && b == 7)
		{
			return 66;
		}
		else if(a == 59 && b == 8)
		{
			return 67;
		}
		else if(a == 59 && b == 9)
		{
			return 68;
		}
		else if(a == 59 && b == 10)
		{
			return 69;
		}
		else if(a == 59 && b == 11)
		{
			return 70;
		}
		else if(a == 59 && b == 12)
		{
			return 71;
		}
		else if(a == 59 && b == 13)
		{
			return 72;
		}
		else if(a == 59 && b == 14)
		{
			return 73;
		}
		else if(a == 59 && b == 15)
		{
			return 74;
		}
		else if(a == 59 && b == 16)
		{
			return 75;
		}
		else if(a == 59 && b == 17)
		{
			return 76;
		}
		else if(a == 59 && b == 18)
		{
			return 77;
		}
		else if(a == 59 && b == 19)
		{
			return 78;
		}
		else if(a == 59 && b == 20)
		{
			return 79;
		}
		else if(a == 59 && b == 21)
		{
			return 80;
		}
		else if(a == 59 && b == 22)
		{
			return 81;
		}
		else if(a == 59 && b == 23)
		{
			return 82;
		}
		else if(a == 59 && b == 24)
		{
			return 83;
		}
		else if(a == 59 && b == 25)
		{
			return 84;
		}
		else if(a == 59 && b == 26)
		{
			return 85;
		}
		else if(a == 59 && b == 27)
		{
			return 86;
		}
		else if(a == 59 && b == 28)
		{
			return 87;
		}
		else if(a == 59 && b == 29)
		{
			return 88;
		}
		else if(a == 59 && b == 30)
		{
			return 89;
		}
		else if(a == 59 && b == 31)
		{
			return 90;
		}
		else if(a == 59 && b == 32)
		{
			return 91;
		}
		else if(a == 59 && b == 33)
		{
			return 92;
		}
		else if(a == 59 && b == 34)
		{
			return 93;
		}
		else if(a == 59 && b == 35)
		{
			return 94;
		}
		else if(a == 59 && b == 36)
		{
			return 95;
		}
		else if(a == 59 && b == 37)
		{
			return 96;
		}
		else if(a == 59 && b == 38)
		{
			return 97;
		}
		else if(a == 59 && b == 39)
		{
			return 98;
		}
		else if(a == 59 && b == 40)
		{
			return 99;
		}
		else if(a == 59 && b == 41)
		{
			return 100;
		}
		else if(a == 59 && b == 42)
		{
			return 101;
		}
		else if(a == 59 && b == 43)
		{
			return 102;
		}
		else if(a == 59 && b == 44)
		{
			return 103;
		}
		else if(a == 59 && b == 45)
		{
			return 104;
		}
		else if(a == 59 && b == 46)
		{
			return 105;
		}
		else if(a == 59 && b == 47)
		{
			return 106;
		}
		else if(a == 59 && b == 48)
		{
			return 107;
		}
		else if(a == 59 && b == 49)
		{
			return 108;
		}
		else if(a == 59 && b == 50)
		{
			return 109;
		}
		else if(a == 59 && b == 51)
		{
			return 110;
		}
		else if(a == 59 && b == 52)
		{
			return 111;
		}
		else if(a == 59 && b == 53)
		{
			return 112;
		}
		else if(a == 59 && b == 54)
		{
			return 113;
		}
		else if(a == 59 && b == 55)
		{
			return 114;
		}
		else if(a == 59 && b == 56)
		{
			return 115;
		}
		else if(a == 59 && b == 57)
		{
			return 116;
		}
		else if(a == 59 && b == 58)
		{
			return 117;
		}
		else if(a == 59 && b == 59)
		{
			return 118;
		}
		else if(a == 59 && b == 60)
		{
			return 119;
		}
		else if(a == 59 && b == 61)
		{
			return 120;
		}
		else if(a == 59 && b == 62)
		{
			return 121;
		}
		else if(a == 59 && b == 63)
		{
			return 122;
		}
		else if(a == 59 && b == 64)
		{
			return 123;
		}
		else if(a == 59 && b == 65)
		{
			return 124;
		}
		else if(a == 59 && b == 66)
		{
			return 125;
		}
		else if(a == 59 && b == 67)
		{
			return 126;
		}
		else if(a == 59 && b == 68)
		{
			return 127;
		}
		else if(a == 59 && b == 69)
		{
			return 128;
		}
		else if(a == 59 && b == 70)
		{
			return 129;
		}
		else if(a == 59 && b == 71)
		{
			return 130;
		}
		else if(a == 59 && b == 72)
		{
			return 131;
		}
		else if(a == 59 && b == 73)
		{
			return 132;
		}
		else if(a == 59 && b == 74)
		{
			return 133;
		}
		else if(a == 59 && b == 75)
		{
			return 134;
		}
		else if(a == 59 && b == 76)
		{
			return 135;
		}
		else if(a == 59 && b == 77)
		{
			return 136;
		}
		else if(a == 59 && b == 78)
		{
			return 137;
		}
		else if(a == 59 && b == 79)
		{
			return 138;
		}
		else if(a == 59 && b == 80)
		{
			return 139;
		}
		else if(a == 59 && b == 81)
		{
			return 140;
		}
		else if(a == 59 && b == 82)
		{
			return 141;
		}
		else if(a == 59 && b == 83)
		{
			return 142;
		}
		else if(a == 59 && b == 84)
		{
			return 143;
		}
		else if(a == 59 && b == 85)
		{
			return 144;
		}
		else if(a == 59 && b == 86)
		{
			return 145;
		}
		else if(a == 59 && b == 87)
		{
			return 146;
		}
		else if(a == 59 && b == 88)
		{
			return 147;
		}
		else if(a == 59 && b == 89)
		{
			return 148;
		}
		else if(a == 59 && b == 90)
		{
			return 149;
		}
		else if(a == 59 && b == 91)
		{
			return 150;
		}
		else if(a == 59 && b == 92)
		{
			return 151;
		}
		else if(a == 59 && b == 93)
		{
			return 152;
		}
		else if(a == 59 && b == 94)
		{
			return 153;
		}
		else if(a == 59 && b == 95)
		{
			return 154;
		}
		else if(a == 59 && b == 96)
		{
			return 155;
		}
		else if(a == 59 && b == 97)
		{
			return 156;
		}
		else if(a == 59 && b == 98)
		{
			return 157;
		}
		else if(a == 59 && b == 99)
		{
			return 158;
		}
		else if(a == 59 && b == 100)
		{
			return 159;
		}
		else if(a == 60 && b == 0)
		{
			return 60;
		}
		else if(a == 60 && b == 1)
		{
			return 61;
		}
		else if(a == 60 && b == 2)
		{
			return 62;
		}
		else if(a == 60 && b == 3)
		{
			return 63;
		}
		else if(a == 60 && b == 4)
		{
			return 64;
		}
		else if(a == 60 && b == 5)
		{
			return 65;
		}
		else if(a == 60 && b == 6)
		{
			return 66;
		}
		else if(a == 60 && b == 7)
		{
			return 67;
		}
		else if(a == 60 && b == 8)
		{
			return 68;
		}
		else if(a == 60 && b == 9)
		{
			return 69;
		}
		else if(a == 60 && b == 10)
		{
			return 70;
		}
		else if(a == 60 && b == 11)
		{
			return 71;
		}
		else if(a == 60 && b == 12)
		{
			return 72;
		}
		else if(a == 60 && b == 13)
		{
			return 73;
		}
		else if(a == 60 && b == 14)
		{
			return 74;
		}
		else if(a == 60 && b == 15)
		{
			return 75;
		}
		else if(a == 60 && b == 16)
		{
			return 76;
		}
		else if(a == 60 && b == 17)
		{
			return 77;
		}
		else if(a == 60 && b == 18)
		{
			return 78;
		}
		else if(a == 60 && b == 19)
		{
			return 79;
		}
		else if(a == 60 && b == 20)
		{
			return 80;
		}
		else if(a == 60 && b == 21)
		{
			return 81;
		}
		else if(a == 60 && b == 22)
		{
			return 82;
		}
		else if(a == 60 && b == 23)
		{
			return 83;
		}
		else if(a == 60 && b == 24)
		{
			return 84;
		}
		else if(a == 60 && b == 25)
		{
			return 85;
		}
		else if(a == 60 && b == 26)
		{
			return 86;
		}
		else if(a == 60 && b == 27)
		{
			return 87;
		}
		else if(a == 60 && b == 28)
		{
			return 88;
		}
		else if(a == 60 && b == 29)
		{
			return 89;
		}
		else if(a == 60 && b == 30)
		{
			return 90;
		}
		else if(a == 60 && b == 31)
		{
			return 91;
		}
		else if(a == 60 && b == 32)
		{
			return 92;
		}
		else if(a == 60 && b == 33)
		{
			return 93;
		}
		else if(a == 60 && b == 34)
		{
			return 94;
		}
		else if(a == 60 && b == 35)
		{
			return 95;
		}
		else if(a == 60 && b == 36)
		{
			return 96;
		}
		else if(a == 60 && b == 37)
		{
			return 97;
		}
		else if(a == 60 && b == 38)
		{
			return 98;
		}
		else if(a == 60 && b == 39)
		{
			return 99;
		}
		else if(a == 60 && b == 40)
		{
			return 100;
		}
		else if(a == 60 && b == 41)
		{
			return 101;
		}
		else if(a == 60 && b == 42)
		{
			return 102;
		}
		else if(a == 60 && b == 43)
		{
			return 103;
		}
		else if(a == 60 && b == 44)
		{
			return 104;
		}
		else if(a == 60 && b == 45)
		{
			return 105;
		}
		else if(a == 60 && b == 46)
		{
			return 106;
		}
		else if(a == 60 && b == 47)
		{
			return 107;
		}
		else if(a == 60 && b == 48)
		{
			return 108;
		}
		else if(a == 60 && b == 49)
		{
			return 109;
		}
		else if(a == 60 && b == 50)
		{
			return 110;
		}
		else if(a == 60 && b == 51)
		{
			return 111;
		}
		else if(a == 60 && b == 52)
		{
			return 112;
		}
		else if(a == 60 && b == 53)
		{
			return 113;
		}
		else if(a == 60 && b == 54)
		{
			return 114;
		}
		else if(a == 60 && b == 55)
		{
			return 115;
		}
		else if(a == 60 && b == 56)
		{
			return 116;
		}
		else if(a == 60 && b == 57)
		{
			return 117;
		}
		else if(a == 60 && b == 58)
		{
			return 118;
		}
		else if(a == 60 && b == 59)
		{
			return 119;
		}
		else if(a == 60 && b == 60)
		{
			return 120;
		}
		else if(a == 60 && b == 61)
		{
			return 121;
		}
		else if(a == 60 && b == 62)
		{
			return 122;
		}
		else if(a == 60 && b == 63)
		{
			return 123;
		}
		else if(a == 60 && b == 64)
		{
			return 124;
		}
		else if(a == 60 && b == 65)
		{
			return 125;
		}
		else if(a == 60 && b == 66)
		{
			return 126;
		}
		else if(a == 60 && b == 67)
		{
			return 127;
		}
		else if(a == 60 && b == 68)
		{
			return 128;
		}
		else if(a == 60 && b == 69)
		{
			return 129;
		}
		else if(a == 60 && b == 70)
		{
			return 130;
		}
		else if(a == 60 && b == 71)
		{
			return 131;
		}
		else if(a == 60 && b == 72)
		{
			return 132;
		}
		else if(a == 60 && b == 73)
		{
			return 133;
		}
		else if(a == 60 && b == 74)
		{
			return 134;
		}
		else if(a == 60 && b == 75)
		{
			return 135;
		}
		else if(a == 60 && b == 76)
		{
			return 136;
		}
		else if(a == 60 && b == 77)
		{
			return 137;
		}
		else if(a == 60 && b == 78)
		{
			return 138;
		}
		else if(a == 60 && b == 79)
		{
			return 139;
		}
		else if(a == 60 && b == 80)
		{
			return 140;
		}
		else if(a == 60 && b == 81)
		{
			return 141;
		}
		else if(a == 60 && b == 82)
		{
			return 142;
		}
		else if(a == 60 && b == 83)
		{
			return 143;
		}
		else if(a == 60 && b == 84)
		{
			return 144;
		}
		else if(a == 60 && b == 85)
		{
			return 145;
		}
		else if(a == 60 && b == 86)
		{
			return 146;
		}
		else if(a == 60 && b == 87)
		{
			return 147;
		}
		else if(a == 60 && b == 88)
		{
			return 148;
		}
		else if(a == 60 && b == 89)
		{
			return 149;
		}
		else if(a == 60 && b == 90)
		{
			return 150;
		}
		else if(a == 60 && b == 91)
		{
			return 151;
		}
		else if(a == 60 && b == 92)
		{
			return 152;
		}
		else if(a == 60 && b == 93)
		{
			return 153;
		}
		else if(a == 60 && b == 94)
		{
			return 154;
		}
		else if(a == 60 && b == 95)
		{
			return 155;
		}
		else if(a == 60 && b == 96)
		{
			return 156;
		}
		else if(a == 60 && b == 97)
		{
			return 157;
		}
		else if(a == 60 && b == 98)
		{
			return 158;
		}
		else if(a == 60 && b == 99)
		{
			return 159;
		}
		else if(a == 60 && b == 100)
		{
			return 160;
		}
		else if(a == 61 && b == 0)
		{
			return 61;
		}
		else if(a == 61 && b == 1)
		{
			return 62;
		}
		else if(a == 61 && b == 2)
		{
			return 63;
		}
		else if(a == 61 && b == 3)
		{
			return 64;
		}
		else if(a == 61 && b == 4)
		{
			return 65;
		}
		else if(a == 61 && b == 5)
		{
			return 66;
		}
		else if(a == 61 && b == 6)
		{
			return 67;
		}
		else if(a == 61 && b == 7)
		{
			return 68;
		}
		else if(a == 61 && b == 8)
		{
			return 69;
		}
		else if(a == 61 && b == 9)
		{
			return 70;
		}
		else if(a == 61 && b == 10)
		{
			return 71;
		}
		else if(a == 61 && b == 11)
		{
			return 72;
		}
		else if(a == 61 && b == 12)
		{
			return 73;
		}
		else if(a == 61 && b == 13)
		{
			return 74;
		}
		else if(a == 61 && b == 14)
		{
			return 75;
		}
		else if(a == 61 && b == 15)
		{
			return 76;
		}
		else if(a == 61 && b == 16)
		{
			return 77;
		}
		else if(a == 61 && b == 17)
		{
			return 78;
		}
		else if(a == 61 && b == 18)
		{
			return 79;
		}
		else if(a == 61 && b == 19)
		{
			return 80;
		}
		else if(a == 61 && b == 20)
		{
			return 81;
		}
		else if(a == 61 && b == 21)
		{
			return 82;
		}
		else if(a == 61 && b == 22)
		{
			return 83;
		}
		else if(a == 61 && b == 23)
		{
			return 84;
		}
		else if(a == 61 && b == 24)
		{
			return 85;
		}
		else if(a == 61 && b == 25)
		{
			return 86;
		}
		else if(a == 61 && b == 26)
		{
			return 87;
		}
		else if(a == 61 && b == 27)
		{
			return 88;
		}
		else if(a == 61 && b == 28)
		{
			return 89;
		}
		else if(a == 61 && b == 29)
		{
			return 90;
		}
		else if(a == 61 && b == 30)
		{
			return 91;
		}
		else if(a == 61 && b == 31)
		{
			return 92;
		}
		else if(a == 61 && b == 32)
		{
			return 93;
		}
		else if(a == 61 && b == 33)
		{
			return 94;
		}
		else if(a == 61 && b == 34)
		{
			return 95;
		}
		else if(a == 61 && b == 35)
		{
			return 96;
		}
		else if(a == 61 && b == 36)
		{
			return 97;
		}
		else if(a == 61 && b == 37)
		{
			return 98;
		}
		else if(a == 61 && b == 38)
		{
			return 99;
		}
		else if(a == 61 && b == 39)
		{
			return 100;
		}
		else if(a == 61 && b == 40)
		{
			return 101;
		}
		else if(a == 61 && b == 41)
		{
			return 102;
		}
		else if(a == 61 && b == 42)
		{
			return 103;
		}
		else if(a == 61 && b == 43)
		{
			return 104;
		}
		else if(a == 61 && b == 44)
		{
			return 105;
		}
		else if(a == 61 && b == 45)
		{
			return 106;
		}
		else if(a == 61 && b == 46)
		{
			return 107;
		}
		else if(a == 61 && b == 47)
		{
			return 108;
		}
		else if(a == 61 && b == 48)
		{
			return 109;
		}
		else if(a == 61 && b == 49)
		{
			return 110;
		}
		else if(a == 61 && b == 50)
		{
			return 111;
		}
		else if(a == 61 && b == 51)
		{
			return 112;
		}
		else if(a == 61 && b == 52)
		{
			return 113;
		}
		else if(a == 61 && b == 53)
		{
			return 114;
		}
		else if(a == 61 && b == 54)
		{
			return 115;
		}
		else if(a == 61 && b == 55)
		{
			return 116;
		}
		else if(a == 61 && b == 56)
		{
			return 117;
		}
		else if(a == 61 && b == 57)
		{
			return 118;
		}
		else if(a == 61 && b == 58)
		{
			return 119;
		}
		else if(a == 61 && b == 59)
		{
			return 120;
		}
		else if(a == 61 && b == 60)
		{
			return 121;
		}
		else if(a == 61 && b == 61)
		{
			return 122;
		}
		else if(a == 61 && b == 62)
		{
			return 123;
		}
		else if(a == 61 && b == 63)
		{
			return 124;
		}
		else if(a == 61 && b == 64)
		{
			return 125;
		}
		else if(a == 61 && b == 65)
		{
			return 126;
		}
		else if(a == 61 && b == 66)
		{
			return 127;
		}
		else if(a == 61 && b == 67)
		{
			return 128;
		}
		else if(a == 61 && b == 68)
		{
			return 129;
		}
		else if(a == 61 && b == 69)
		{
			return 130;
		}
		else if(a == 61 && b == 70)
		{
			return 131;
		}
		else if(a == 61 && b == 71)
		{
			return 132;
		}
		else if(a == 61 && b == 72)
		{
			return 133;
		}
		else if(a == 61 && b == 73)
		{
			return 134;
		}
		else if(a == 61 && b == 74)
		{
			return 135;
		}
		else if(a == 61 && b == 75)
		{
			return 136;
		}
		else if(a == 61 && b == 76)
		{
			return 137;
		}
		else if(a == 61 && b == 77)
		{
			return 138;
		}
		else if(a == 61 && b == 78)
		{
			return 139;
		}
		else if(a == 61 && b == 79)
		{
			return 140;
		}
		else if(a == 61 && b == 80)
		{
			return 141;
		}
		else if(a == 61 && b == 81)
		{
			return 142;
		}
		else if(a == 61 && b == 82)
		{
			return 143;
		}
		else if(a == 61 && b == 83)
		{
			return 144;
		}
		else if(a == 61 && b == 84)
		{
			return 145;
		}
		else if(a == 61 && b == 85)
		{
			return 146;
		}
		else if(a == 61 && b == 86)
		{
			return 147;
		}
		else if(a == 61 && b == 87)
		{
			return 148;
		}
		else if(a == 61 && b == 88)
		{
			return 149;
		}
		else if(a == 61 && b == 89)
		{
			return 150;
		}
		else if(a == 61 && b == 90)
		{
			return 151;
		}
		else if(a == 61 && b == 91)
		{
			return 152;
		}
		else if(a == 61 && b == 92)
		{
			return 153;
		}
		else if(a == 61 && b == 93)
		{
			return 154;
		}
		else if(a == 61 && b == 94)
		{
			return 155;
		}
		else if(a == 61 && b == 95)
		{
			return 156;
		}
		else if(a == 61 && b == 96)
		{
			return 157;
		}
		else if(a == 61 && b == 97)
		{
			return 158;
		}
		else if(a == 61 && b == 98)
		{
			return 159;
		}
		else if(a == 61 && b == 99)
		{
			return 160;
		}
		else if(a == 61 && b == 100)
		{
			return 161;
		}
		else if(a == 62 && b == 0)
		{
			return 62;
		}
		else if(a == 62 && b == 1)
		{
			return 63;
		}
		else if(a == 62 && b == 2)
		{
			return 64;
		}
		else if(a == 62 && b == 3)
		{
			return 65;
		}
		else if(a == 62 && b == 4)
		{
			return 66;
		}
		else if(a == 62 && b == 5)
		{
			return 67;
		}
		else if(a == 62 && b == 6)
		{
			return 68;
		}
		else if(a == 62 && b == 7)
		{
			return 69;
		}
		else if(a == 62 && b == 8)
		{
			return 70;
		}
		else if(a == 62 && b == 9)
		{
			return 71;
		}
		else if(a == 62 && b == 10)
		{
			return 72;
		}
		else if(a == 62 && b == 11)
		{
			return 73;
		}
		else if(a == 62 && b == 12)
		{
			return 74;
		}
		else if(a == 62 && b == 13)
		{
			return 75;
		}
		else if(a == 62 && b == 14)
		{
			return 76;
		}
		else if(a == 62 && b == 15)
		{
			return 77;
		}
		else if(a == 62 && b == 16)
		{
			return 78;
		}
		else if(a == 62 && b == 17)
		{
			return 79;
		}
		else if(a == 62 && b == 18)
		{
			return 80;
		}
		else if(a == 62 && b == 19)
		{
			return 81;
		}
		else if(a == 62 && b == 20)
		{
			return 82;
		}
		else if(a == 62 && b == 21)
		{
			return 83;
		}
		else if(a == 62 && b == 22)
		{
			return 84;
		}
		else if(a == 62 && b == 23)
		{
			return 85;
		}
		else if(a == 62 && b == 24)
		{
			return 86;
		}
		else if(a == 62 && b == 25)
		{
			return 87;
		}
		else if(a == 62 && b == 26)
		{
			return 88;
		}
		else if(a == 62 && b == 27)
		{
			return 89;
		}
		else if(a == 62 && b == 28)
		{
			return 90;
		}
		else if(a == 62 && b == 29)
		{
			return 91;
		}
		else if(a == 62 && b == 30)
		{
			return 92;
		}
		else if(a == 62 && b == 31)
		{
			return 93;
		}
		else if(a == 62 && b == 32)
		{
			return 94;
		}
		else if(a == 62 && b == 33)
		{
			return 95;
		}
		else if(a == 62 && b == 34)
		{
			return 96;
		}
		else if(a == 62 && b == 35)
		{
			return 97;
		}
		else if(a == 62 && b == 36)
		{
			return 98;
		}
		else if(a == 62 && b == 37)
		{
			return 99;
		}
		else if(a == 62 && b == 38)
		{
			return 100;
		}
		else if(a == 62 && b == 39)
		{
			return 101;
		}
		else if(a == 62 && b == 40)
		{
			return 102;
		}
		else if(a == 62 && b == 41)
		{
			return 103;
		}
		else if(a == 62 && b == 42)
		{
			return 104;
		}
		else if(a == 62 && b == 43)
		{
			return 105;
		}
		else if(a == 62 && b == 44)
		{
			return 106;
		}
		else if(a == 62 && b == 45)
		{
			return 107;
		}
		else if(a == 62 && b == 46)
		{
			return 108;
		}
		else if(a == 62 && b == 47)
		{
			return 109;
		}
		else if(a == 62 && b == 48)
		{
			return 110;
		}
		else if(a == 62 && b == 49)
		{
			return 111;
		}
		else if(a == 62 && b == 50)
		{
			return 112;
		}
		else if(a == 62 && b == 51)
		{
			return 113;
		}
		else if(a == 62 && b == 52)
		{
			return 114;
		}
		else if(a == 62 && b == 53)
		{
			return 115;
		}
		else if(a == 62 && b == 54)
		{
			return 116;
		}
		else if(a == 62 && b == 55)
		{
			return 117;
		}
		else if(a == 62 && b == 56)
		{
			return 118;
		}
		else if(a == 62 && b == 57)
		{
			return 119;
		}
		else if(a == 62 && b == 58)
		{
			return 120;
		}
		else if(a == 62 && b == 59)
		{
			return 121;
		}
		else if(a == 62 && b == 60)
		{
			return 122;
		}
		else if(a == 62 && b == 61)
		{
			return 123;
		}
		else if(a == 62 && b == 62)
		{
			return 124;
		}
		else if(a == 62 && b == 63)
		{
			return 125;
		}
		else if(a == 62 && b == 64)
		{
			return 126;
		}
		else if(a == 62 && b == 65)
		{
			return 127;
		}
		else if(a == 62 && b == 66)
		{
			return 128;
		}
		else if(a == 62 && b == 67)
		{
			return 129;
		}
		else if(a == 62 && b == 68)
		{
			return 130;
		}
		else if(a == 62 && b == 69)
		{
			return 131;
		}
		else if(a == 62 && b == 70)
		{
			return 132;
		}
		else if(a == 62 && b == 71)
		{
			return 133;
		}
		else if(a == 62 && b == 72)
		{
			return 134;
		}
		else if(a == 62 && b == 73)
		{
			return 135;
		}
		else if(a == 62 && b == 74)
		{
			return 136;
		}
		else if(a == 62 && b == 75)
		{
			return 137;
		}
		else if(a == 62 && b == 76)
		{
			return 138;
		}
		else if(a == 62 && b == 77)
		{
			return 139;
		}
		else if(a == 62 && b == 78)
		{
			return 140;
		}
		else if(a == 62 && b == 79)
		{
			return 141;
		}
		else if(a == 62 && b == 80)
		{
			return 142;
		}
		else if(a == 62 && b == 81)
		{
			return 143;
		}
		else if(a == 62 && b == 82)
		{
			return 144;
		}
		else if(a == 62 && b == 83)
		{
			return 145;
		}
		else if(a == 62 && b == 84)
		{
			return 146;
		}
		else if(a == 62 && b == 85)
		{
			return 147;
		}
		else if(a == 62 && b == 86)
		{
			return 148;
		}
		else if(a == 62 && b == 87)
		{
			return 149;
		}
		else if(a == 62 && b == 88)
		{
			return 150;
		}
		else if(a == 62 && b == 89)
		{
			return 151;
		}
		else if(a == 62 && b == 90)
		{
			return 152;
		}
		else if(a == 62 && b == 91)
		{
			return 153;
		}
		else if(a == 62 && b == 92)
		{
			return 154;
		}
		else if(a == 62 && b == 93)
		{
			return 155;
		}
		else if(a == 62 && b == 94)
		{
			return 156;
		}
		else if(a == 62 && b == 95)
		{
			return 157;
		}
		else if(a == 62 && b == 96)
		{
			return 158;
		}
		else if(a == 62 && b == 97)
		{
			return 159;
		}
		else if(a == 62 && b == 98)
		{
			return 160;
		}
		else if(a == 62 && b == 99)
		{
			return 161;
		}
		else if(a == 62 && b == 100)
		{
			return 162;
		}
		else if(a == 63 && b == 0)
		{
			return 63;
		}
		else if(a == 63 && b == 1)
		{
			return 64;
		}
		else if(a == 63 && b == 2)
		{
			return 65;
		}
		else if(a == 63 && b == 3)
		{
			return 66;
		}
		else if(a == 63 && b == 4)
		{
			return 67;
		}
		else if(a == 63 && b == 5)
		{
			return 68;
		}
		else if(a == 63 && b == 6)
		{
			return 69;
		}
		else if(a == 63 && b == 7)
		{
			return 70;
		}
		else if(a == 63 && b == 8)
		{
			return 71;
		}
		else if(a == 63 && b == 9)
		{
			return 72;
		}
		else if(a == 63 && b == 10)
		{
			return 73;
		}
		else if(a == 63 && b == 11)
		{
			return 74;
		}
		else if(a == 63 && b == 12)
		{
			return 75;
		}
		else if(a == 63 && b == 13)
		{
			return 76;
		}
		else if(a == 63 && b == 14)
		{
			return 77;
		}
		else if(a == 63 && b == 15)
		{
			return 78;
		}
		else if(a == 63 && b == 16)
		{
			return 79;
		}
		else if(a == 63 && b == 17)
		{
			return 80;
		}
		else if(a == 63 && b == 18)
		{
			return 81;
		}
		else if(a == 63 && b == 19)
		{
			return 82;
		}
		else if(a == 63 && b == 20)
		{
			return 83;
		}
		else if(a == 63 && b == 21)
		{
			return 84;
		}
		else if(a == 63 && b == 22)
		{
			return 85;
		}
		else if(a == 63 && b == 23)
		{
			return 86;
		}
		else if(a == 63 && b == 24)
		{
			return 87;
		}
		else if(a == 63 && b == 25)
		{
			return 88;
		}
		else if(a == 63 && b == 26)
		{
			return 89;
		}
		else if(a == 63 && b == 27)
		{
			return 90;
		}
		else if(a == 63 && b == 28)
		{
			return 91;
		}
		else if(a == 63 && b == 29)
		{
			return 92;
		}
		else if(a == 63 && b == 30)
		{
			return 93;
		}
		else if(a == 63 && b == 31)
		{
			return 94;
		}
		else if(a == 63 && b == 32)
		{
			return 95;
		}
		else if(a == 63 && b == 33)
		{
			return 96;
		}
		else if(a == 63 && b == 34)
		{
			return 97;
		}
		else if(a == 63 && b == 35)
		{
			return 98;
		}
		else if(a == 63 && b == 36)
		{
			return 99;
		}
		else if(a == 63 && b == 37)
		{
			return 100;
		}
		else if(a == 63 && b == 38)
		{
			return 101;
		}
		else if(a == 63 && b == 39)
		{
			return 102;
		}
		else if(a == 63 && b == 40)
		{
			return 103;
		}
		else if(a == 63 && b == 41)
		{
			return 104;
		}
		else if(a == 63 && b == 42)
		{
			return 105;
		}
		else if(a == 63 && b == 43)
		{
			return 106;
		}
		else if(a == 63 && b == 44)
		{
			return 107;
		}
		else if(a == 63 && b == 45)
		{
			return 108;
		}
		else if(a == 63 && b == 46)
		{
			return 109;
		}
		else if(a == 63 && b == 47)
		{
			return 110;
		}
		else if(a == 63 && b == 48)
		{
			return 111;
		}
		else if(a == 63 && b == 49)
		{
			return 112;
		}
		else if(a == 63 && b == 50)
		{
			return 113;
		}
		else if(a == 63 && b == 51)
		{
			return 114;
		}
		else if(a == 63 && b == 52)
		{
			return 115;
		}
		else if(a == 63 && b == 53)
		{
			return 116;
		}
		else if(a == 63 && b == 54)
		{
			return 117;
		}
		else if(a == 63 && b == 55)
		{
			return 118;
		}
		else if(a == 63 && b == 56)
		{
			return 119;
		}
		else if(a == 63 && b == 57)
		{
			return 120;
		}
		else if(a == 63 && b == 58)
		{
			return 121;
		}
		else if(a == 63 && b == 59)
		{
			return 122;
		}
		else if(a == 63 && b == 60)
		{
			return 123;
		}
		else if(a == 63 && b == 61)
		{
			return 124;
		}
		else if(a == 63 && b == 62)
		{
			return 125;
		}
		else if(a == 63 && b == 63)
		{
			return 126;
		}
		else if(a == 63 && b == 64)
		{
			return 127;
		}
		else if(a == 63 && b == 65)
		{
			return 128;
		}
		else if(a == 63 && b == 66)
		{
			return 129;
		}
		else if(a == 63 && b == 67)
		{
			return 130;
		}
		else if(a == 63 && b == 68)
		{
			return 131;
		}
		else if(a == 63 && b == 69)
		{
			return 132;
		}
		else if(a == 63 && b == 70)
		{
			return 133;
		}
		else if(a == 63 && b == 71)
		{
			return 134;
		}
		else if(a == 63 && b == 72)
		{
			return 135;
		}
		else if(a == 63 && b == 73)
		{
			return 136;
		}
		else if(a == 63 && b == 74)
		{
			return 137;
		}
		else if(a == 63 && b == 75)
		{
			return 138;
		}
		else if(a == 63 && b == 76)
		{
			return 139;
		}
		else if(a == 63 && b == 77)
		{
			return 140;
		}
		else if(a == 63 && b == 78)
		{
			return 141;
		}
		else if(a == 63 && b == 79)
		{
			return 142;
		}
		else if(a == 63 && b == 80)
		{
			return 143;
		}
		else if(a == 63 && b == 81)
		{
			return 144;
		}
		else if(a == 63 && b == 82)
		{
			return 145;
		}
		else if(a == 63 && b == 83)
		{
			return 146;
		}
		else if(a == 63 && b == 84)
		{
			return 147;
		}
		else if(a == 63 && b == 85)
		{
			return 148;
		}
		else if(a == 63 && b == 86)
		{
			return 149;
		}
		else if(a == 63 && b == 87)
		{
			return 150;
		}
		else if(a == 63 && b == 88)
		{
			return 151;
		}
		else if(a == 63 && b == 89)
		{
			return 152;
		}
		else if(a == 63 && b == 90)
		{
			return 153;
		}
		else if(a == 63 && b == 91)
		{
			return 154;
		}
		else if(a == 63 && b == 92)
		{
			return 155;
		}
		else if(a == 63 && b == 93)
		{
			return 156;
		}
		else if(a == 63 && b == 94)
		{
			return 157;
		}
		else if(a == 63 && b == 95)
		{
			return 158;
		}
		else if(a == 63 && b == 96)
		{
			return 159;
		}
		else if(a == 63 && b == 97)
		{
			return 160;
		}
		else if(a == 63 && b == 98)
		{
			return 161;
		}
		else if(a == 63 && b == 99)
		{
			return 162;
		}
		else if(a == 63 && b == 100)
		{
			return 163;
		}
		else if(a == 64 && b == 0)
		{
			return 64;
		}
		else if(a == 64 && b == 1)
		{
			return 65;
		}
		else if(a == 64 && b == 2)
		{
			return 66;
		}
		else if(a == 64 && b == 3)
		{
			return 67;
		}
		else if(a == 64 && b == 4)
		{
			return 68;
		}
		else if(a == 64 && b == 5)
		{
			return 69;
		}
		else if(a == 64 && b == 6)
		{
			return 70;
		}
		else if(a == 64 && b == 7)
		{
			return 71;
		}
		else if(a == 64 && b == 8)
		{
			return 72;
		}
		else if(a == 64 && b == 9)
		{
			return 73;
		}
		else if(a == 64 && b == 10)
		{
			return 74;
		}
		else if(a == 64 && b == 11)
		{
			return 75;
		}
		else if(a == 64 && b == 12)
		{
			return 76;
		}
		else if(a == 64 && b == 13)
		{
			return 77;
		}
		else if(a == 64 && b == 14)
		{
			return 78;
		}
		else if(a == 64 && b == 15)
		{
			return 79;
		}
		else if(a == 64 && b == 16)
		{
			return 80;
		}
		else if(a == 64 && b == 17)
		{
			return 81;
		}
		else if(a == 64 && b == 18)
		{
			return 82;
		}
		else if(a == 64 && b == 19)
		{
			return 83;
		}
		else if(a == 64 && b == 20)
		{
			return 84;
		}
		else if(a == 64 && b == 21)
		{
			return 85;
		}
		else if(a == 64 && b == 22)
		{
			return 86;
		}
		else if(a == 64 && b == 23)
		{
			return 87;
		}
		else if(a == 64 && b == 24)
		{
			return 88;
		}
		else if(a == 64 && b == 25)
		{
			return 89;
		}
		else if(a == 64 && b == 26)
		{
			return 90;
		}
		else if(a == 64 && b == 27)
		{
			return 91;
		}
		else if(a == 64 && b == 28)
		{
			return 92;
		}
		else if(a == 64 && b == 29)
		{
			return 93;
		}
		else if(a == 64 && b == 30)
		{
			return 94;
		}
		else if(a == 64 && b == 31)
		{
			return 95;
		}
		else if(a == 64 && b == 32)
		{
			return 96;
		}
		else if(a == 64 && b == 33)
		{
			return 97;
		}
		else if(a == 64 && b == 34)
		{
			return 98;
		}
		else if(a == 64 && b == 35)
		{
			return 99;
		}
		else if(a == 64 && b == 36)
		{
			return 100;
		}
		else if(a == 64 && b == 37)
		{
			return 101;
		}
		else if(a == 64 && b == 38)
		{
			return 102;
		}
		else if(a == 64 && b == 39)
		{
			return 103;
		}
		else if(a == 64 && b == 40)
		{
			return 104;
		}
		else if(a == 64 && b == 41)
		{
			return 105;
		}
		else if(a == 64 && b == 42)
		{
			return 106;
		}
		else if(a == 64 && b == 43)
		{
			return 107;
		}
		else if(a == 64 && b == 44)
		{
			return 108;
		}
		else if(a == 64 && b == 45)
		{
			return 109;
		}
		else if(a == 64 && b == 46)
		{
			return 110;
		}
		else if(a == 64 && b == 47)
		{
			return 111;
		}
		else if(a == 64 && b == 48)
		{
			return 112;
		}
		else if(a == 64 && b == 49)
		{
			return 113;
		}
		else if(a == 64 && b == 50)
		{
			return 114;
		}
		else if(a == 64 && b == 51)
		{
			return 115;
		}
		else if(a == 64 && b == 52)
		{
			return 116;
		}
		else if(a == 64 && b == 53)
		{
			return 117;
		}
		else if(a == 64 && b == 54)
		{
			return 118;
		}
		else if(a == 64 && b == 55)
		{
			return 119;
		}
		else if(a == 64 && b == 56)
		{
			return 120;
		}
		else if(a == 64 && b == 57)
		{
			return 121;
		}
		else if(a == 64 && b == 58)
		{
			return 122;
		}
		else if(a == 64 && b == 59)
		{
			return 123;
		}
		else if(a == 64 && b == 60)
		{
			return 124;
		}
		else if(a == 64 && b == 61)
		{
			return 125;
		}
		else if(a == 64 && b == 62)
		{
			return 126;
		}
		else if(a == 64 && b == 63)
		{
			return 127;
		}
		else if(a == 64 && b == 64)
		{
			return 128;
		}
		else if(a == 64 && b == 65)
		{
			return 129;
		}
		else if(a == 64 && b == 66)
		{
			return 130;
		}
		else if(a == 64 && b == 67)
		{
			return 131;
		}
		else if(a == 64 && b == 68)
		{
			return 132;
		}
		else if(a == 64 && b == 69)
		{
			return 133;
		}
		else if(a == 64 && b == 70)
		{
			return 134;
		}
		else if(a == 64 && b == 71)
		{
			return 135;
		}
		else if(a == 64 && b == 72)
		{
			return 136;
		}
		else if(a == 64 && b == 73)
		{
			return 137;
		}
		else if(a == 64 && b == 74)
		{
			return 138;
		}
		else if(a == 64 && b == 75)
		{
			return 139;
		}
		else if(a == 64 && b == 76)
		{
			return 140;
		}
		else if(a == 64 && b == 77)
		{
			return 141;
		}
		else if(a == 64 && b == 78)
		{
			return 142;
		}
		else if(a == 64 && b == 79)
		{
			return 143;
		}
		else if(a == 64 && b == 80)
		{
			return 144;
		}
		else if(a == 64 && b == 81)
		{
			return 145;
		}
		else if(a == 64 && b == 82)
		{
			return 146;
		}
		else if(a == 64 && b == 83)
		{
			return 147;
		}
		else if(a == 64 && b == 84)
		{
			return 148;
		}
		else if(a == 64 && b == 85)
		{
			return 149;
		}
		else if(a == 64 && b == 86)
		{
			return 150;
		}
		else if(a == 64 && b == 87)
		{
			return 151;
		}
		else if(a == 64 && b == 88)
		{
			return 152;
		}
		else if(a == 64 && b == 89)
		{
			return 153;
		}
		else if(a == 64 && b == 90)
		{
			return 154;
		}
		else if(a == 64 && b == 91)
		{
			return 155;
		}
		else if(a == 64 && b == 92)
		{
			return 156;
		}
		else if(a == 64 && b == 93)
		{
			return 157;
		}
		else if(a == 64 && b == 94)
		{
			return 158;
		}
		else if(a == 64 && b == 95)
		{
			return 159;
		}
		else if(a == 64 && b == 96)
		{
			return 160;
		}
		else if(a == 64 && b == 97)
		{
			return 161;
		}
		else if(a == 64 && b == 98)
		{
			return 162;
		}
		else if(a == 64 && b == 99)
		{
			return 163;
		}
		else if(a == 64 && b == 100)
		{
			return 164;
		}
		else if(a == 65 && b == 0)
		{
			return 65;
		}
		else if(a == 65 && b == 1)
		{
			return 66;
		}
		else if(a == 65 && b == 2)
		{
			return 67;
		}
		else if(a == 65 && b == 3)
		{
			return 68;
		}
		else if(a == 65 && b == 4)
		{
			return 69;
		}
		else if(a == 65 && b == 5)
		{
			return 70;
		}
		else if(a == 65 && b == 6)
		{
			return 71;
		}
		else if(a == 65 && b == 7)
		{
			return 72;
		}
		else if(a == 65 && b == 8)
		{
			return 73;
		}
		else if(a == 65 && b == 9)
		{
			return 74;
		}
		else if(a == 65 && b == 10)
		{
			return 75;
		}
		else if(a == 65 && b == 11)
		{
			return 76;
		}
		else if(a == 65 && b == 12)
		{
			return 77;
		}
		else if(a == 65 && b == 13)
		{
			return 78;
		}
		else if(a == 65 && b == 14)
		{
			return 79;
		}
		else if(a == 65 && b == 15)
		{
			return 80;
		}
		else if(a == 65 && b == 16)
		{
			return 81;
		}
		else if(a == 65 && b == 17)
		{
			return 82;
		}
		else if(a == 65 && b == 18)
		{
			return 83;
		}
		else if(a == 65 && b == 19)
		{
			return 84;
		}
		else if(a == 65 && b == 20)
		{
			return 85;
		}
		else if(a == 65 && b == 21)
		{
			return 86;
		}
		else if(a == 65 && b == 22)
		{
			return 87;
		}
		else if(a == 65 && b == 23)
		{
			return 88;
		}
		else if(a == 65 && b == 24)
		{
			return 89;
		}
		else if(a == 65 && b == 25)
		{
			return 90;
		}
		else if(a == 65 && b == 26)
		{
			return 91;
		}
		else if(a == 65 && b == 27)
		{
			return 92;
		}
		else if(a == 65 && b == 28)
		{
			return 93;
		}
		else if(a == 65 && b == 29)
		{
			return 94;
		}
		else if(a == 65 && b == 30)
		{
			return 95;
		}
		else if(a == 65 && b == 31)
		{
			return 96;
		}
		else if(a == 65 && b == 32)
		{
			return 97;
		}
		else if(a == 65 && b == 33)
		{
			return 98;
		}
		else if(a == 65 && b == 34)
		{
			return 99;
		}
		else if(a == 65 && b == 35)
		{
			return 100;
		}
		else if(a == 65 && b == 36)
		{
			return 101;
		}
		else if(a == 65 && b == 37)
		{
			return 102;
		}
		else if(a == 65 && b == 38)
		{
			return 103;
		}
		else if(a == 65 && b == 39)
		{
			return 104;
		}
		else if(a == 65 && b == 40)
		{
			return 105;
		}
		else if(a == 65 && b == 41)
		{
			return 106;
		}
		else if(a == 65 && b == 42)
		{
			return 107;
		}
		else if(a == 65 && b == 43)
		{
			return 108;
		}
		else if(a == 65 && b == 44)
		{
			return 109;
		}
		else if(a == 65 && b == 45)
		{
			return 110;
		}
		else if(a == 65 && b == 46)
		{
			return 111;
		}
		else if(a == 65 && b == 47)
		{
			return 112;
		}
		else if(a == 65 && b == 48)
		{
			return 113;
		}
		else if(a == 65 && b == 49)
		{
			return 114;
		}
		else if(a == 65 && b == 50)
		{
			return 115;
		}
		else if(a == 65 && b == 51)
		{
			return 116;
		}
		else if(a == 65 && b == 52)
		{
			return 117;
		}
		else if(a == 65 && b == 53)
		{
			return 118;
		}
		else if(a == 65 && b == 54)
		{
			return 119;
		}
		else if(a == 65 && b == 55)
		{
			return 120;
		}
		else if(a == 65 && b == 56)
		{
			return 121;
		}
		else if(a == 65 && b == 57)
		{
			return 122;
		}
		else if(a == 65 && b == 58)
		{
			return 123;
		}
		else if(a == 65 && b == 59)
		{
			return 124;
		}
		else if(a == 65 && b == 60)
		{
			return 125;
		}
		else if(a == 65 && b == 61)
		{
			return 126;
		}
		else if(a == 65 && b == 62)
		{
			return 127;
		}
		else if(a == 65 && b == 63)
		{
			return 128;
		}
		else if(a == 65 && b == 64)
		{
			return 129;
		}
		else if(a == 65 && b == 65)
		{
			return 130;
		}
		else if(a == 65 && b == 66)
		{
			return 131;
		}
		else if(a == 65 && b == 67)
		{
			return 132;
		}
		else if(a == 65 && b == 68)
		{
			return 133;
		}
		else if(a == 65 && b == 69)
		{
			return 134;
		}
		else if(a == 65 && b == 70)
		{
			return 135;
		}
		else if(a == 65 && b == 71)
		{
			return 136;
		}
		else if(a == 65 && b == 72)
		{
			return 137;
		}
		else if(a == 65 && b == 73)
		{
			return 138;
		}
		else if(a == 65 && b == 74)
		{
			return 139;
		}
		else if(a == 65 && b == 75)
		{
			return 140;
		}
		else if(a == 65 && b == 76)
		{
			return 141;
		}
		else if(a == 65 && b == 77)
		{
			return 142;
		}
		else if(a == 65 && b == 78)
		{
			return 143;
		}
		else if(a == 65 && b == 79)
		{
			return 144;
		}
		else if(a == 65 && b == 80)
		{
			return 145;
		}
		else if(a == 65 && b == 81)
		{
			return 146;
		}
		else if(a == 65 && b == 82)
		{
			return 147;
		}
		else if(a == 65 && b == 83)
		{
			return 148;
		}
		else if(a == 65 && b == 84)
		{
			return 149;
		}
		else if(a == 65 && b == 85)
		{
			return 150;
		}
		else if(a == 65 && b == 86)
		{
			return 151;
		}
		else if(a == 65 && b == 87)
		{
			return 152;
		}
		else if(a == 65 && b == 88)
		{
			return 153;
		}
		else if(a == 65 && b == 89)
		{
			return 154;
		}
		else if(a == 65 && b == 90)
		{
			return 155;
		}
		else if(a == 65 && b == 91)
		{
			return 156;
		}
		else if(a == 65 && b == 92)
		{
			return 157;
		}
		else if(a == 65 && b == 93)
		{
			return 158;
		}
		else if(a == 65 && b == 94)
		{
			return 159;
		}
		else if(a == 65 && b == 95)
		{
			return 160;
		}
		else if(a == 65 && b == 96)
		{
			return 161;
		}
		else if(a == 65 && b == 97)
		{
			return 162;
		}
		else if(a == 65 && b == 98)
		{
			return 163;
		}
		else if(a == 65 && b == 99)
		{
			return 164;
		}
		else if(a == 65 && b == 100)
		{
			return 165;
		}
		else if(a == 66 && b == 0)
		{
			return 66;
		}
		else if(a == 66 && b == 1)
		{
			return 67;
		}
		else if(a == 66 && b == 2)
		{
			return 68;
		}
		else if(a == 66 && b == 3)
		{
			return 69;
		}
		else if(a == 66 && b == 4)
		{
			return 70;
		}
		else if(a == 66 && b == 5)
		{
			return 71;
		}
		else if(a == 66 && b == 6)
		{
			return 72;
		}
		else if(a == 66 && b == 7)
		{
			return 73;
		}
		else if(a == 66 && b == 8)
		{
			return 74;
		}
		else if(a == 66 && b == 9)
		{
			return 75;
		}
		else if(a == 66 && b == 10)
		{
			return 76;
		}
		else if(a == 66 && b == 11)
		{
			return 77;
		}
		else if(a == 66 && b == 12)
		{
			return 78;
		}
		else if(a == 66 && b == 13)
		{
			return 79;
		}
		else if(a == 66 && b == 14)
		{
			return 80;
		}
		else if(a == 66 && b == 15)
		{
			return 81;
		}
		else if(a == 66 && b == 16)
		{
			return 82;
		}
		else if(a == 66 && b == 17)
		{
			return 83;
		}
		else if(a == 66 && b == 18)
		{
			return 84;
		}
		else if(a == 66 && b == 19)
		{
			return 85;
		}
		else if(a == 66 && b == 20)
		{
			return 86;
		}
		else if(a == 66 && b == 21)
		{
			return 87;
		}
		else if(a == 66 && b == 22)
		{
			return 88;
		}
		else if(a == 66 && b == 23)
		{
			return 89;
		}
		else if(a == 66 && b == 24)
		{
			return 90;
		}
		else if(a == 66 && b == 25)
		{
			return 91;
		}
		else if(a == 66 && b == 26)
		{
			return 92;
		}
		else if(a == 66 && b == 27)
		{
			return 93;
		}
		else if(a == 66 && b == 28)
		{
			return 94;
		}
		else if(a == 66 && b == 29)
		{
			return 95;
		}
		else if(a == 66 && b == 30)
		{
			return 96;
		}
		else if(a == 66 && b == 31)
		{
			return 97;
		}
		else if(a == 66 && b == 32)
		{
			return 98;
		}
		else if(a == 66 && b == 33)
		{
			return 99;
		}
		else if(a == 66 && b == 34)
		{
			return 100;
		}
		else if(a == 66 && b == 35)
		{
			return 101;
		}
		else if(a == 66 && b == 36)
		{
			return 102;
		}
		else if(a == 66 && b == 37)
		{
			return 103;
		}
		else if(a == 66 && b == 38)
		{
			return 104;
		}
		else if(a == 66 && b == 39)
		{
			return 105;
		}
		else if(a == 66 && b == 40)
		{
			return 106;
		}
		else if(a == 66 && b == 41)
		{
			return 107;
		}
		else if(a == 66 && b == 42)
		{
			return 108;
		}
		else if(a == 66 && b == 43)
		{
			return 109;
		}
		else if(a == 66 && b == 44)
		{
			return 110;
		}
		else if(a == 66 && b == 45)
		{
			return 111;
		}
		else if(a == 66 && b == 46)
		{
			return 112;
		}
		else if(a == 66 && b == 47)
		{
			return 113;
		}
		else if(a == 66 && b == 48)
		{
			return 114;
		}
		else if(a == 66 && b == 49)
		{
			return 115;
		}
		else if(a == 66 && b == 50)
		{
			return 116;
		}
		else if(a == 66 && b == 51)
		{
			return 117;
		}
		else if(a == 66 && b == 52)
		{
			return 118;
		}
		else if(a == 66 && b == 53)
		{
			return 119;
		}
		else if(a == 66 && b == 54)
		{
			return 120;
		}
		else if(a == 66 && b == 55)
		{
			return 121;
		}
		else if(a == 66 && b == 56)
		{
			return 122;
		}
		else if(a == 66 && b == 57)
		{
			return 123;
		}
		else if(a == 66 && b == 58)
		{
			return 124;
		}
		else if(a == 66 && b == 59)
		{
			return 125;
		}
		else if(a == 66 && b == 60)
		{
			return 126;
		}
		else if(a == 66 && b == 61)
		{
			return 127;
		}
		else if(a == 66 && b == 62)
		{
			return 128;
		}
		else if(a == 66 && b == 63)
		{
			return 129;
		}
		else if(a == 66 && b == 64)
		{
			return 130;
		}
		else if(a == 66 && b == 65)
		{
			return 131;
		}
		else if(a == 66 && b == 66)
		{
			return 132;
		}
		else if(a == 66 && b == 67)
		{
			return 133;
		}
		else if(a == 66 && b == 68)
		{
			return 134;
		}
		else if(a == 66 && b == 69)
		{
			return 135;
		}
		else if(a == 66 && b == 70)
		{
			return 136;
		}
		else if(a == 66 && b == 71)
		{
			return 137;
		}
		else if(a == 66 && b == 72)
		{
			return 138;
		}
		else if(a == 66 && b == 73)
		{
			return 139;
		}
		else if(a == 66 && b == 74)
		{
			return 140;
		}
		else if(a == 66 && b == 75)
		{
			return 141;
		}
		else if(a == 66 && b == 76)
		{
			return 142;
		}
		else if(a == 66 && b == 77)
		{
			return 143;
		}
		else if(a == 66 && b == 78)
		{
			return 144;
		}
		else if(a == 66 && b == 79)
		{
			return 145;
		}
		else if(a == 66 && b == 80)
		{
			return 146;
		}
		else if(a == 66 && b == 81)
		{
			return 147;
		}
		else if(a == 66 && b == 82)
		{
			return 148;
		}
		else if(a == 66 && b == 83)
		{
			return 149;
		}
		else if(a == 66 && b == 84)
		{
			return 150;
		}
		else if(a == 66 && b == 85)
		{
			return 151;
		}
		else if(a == 66 && b == 86)
		{
			return 152;
		}
		else if(a == 66 && b == 87)
		{
			return 153;
		}
		else if(a == 66 && b == 88)
		{
			return 154;
		}
		else if(a == 66 && b == 89)
		{
			return 155;
		}
		else if(a == 66 && b == 90)
		{
			return 156;
		}
		else if(a == 66 && b == 91)
		{
			return 157;
		}
		else if(a == 66 && b == 92)
		{
			return 158;
		}
		else if(a == 66 && b == 93)
		{
			return 159;
		}
		else if(a == 66 && b == 94)
		{
			return 160;
		}
		else if(a == 66 && b == 95)
		{
			return 161;
		}
		else if(a == 66 && b == 96)
		{
			return 162;
		}
		else if(a == 66 && b == 97)
		{
			return 163;
		}
		else if(a == 66 && b == 98)
		{
			return 164;
		}
		else if(a == 66 && b == 99)
		{
			return 165;
		}
		else if(a == 66 && b == 100)
		{
			return 166;
		}
		else if(a == 67 && b == 0)
		{
			return 67;
		}
		else if(a == 67 && b == 1)
		{
			return 68;
		}
		else if(a == 67 && b == 2)
		{
			return 69;
		}
		else if(a == 67 && b == 3)
		{
			return 70;
		}
		else if(a == 67 && b == 4)
		{
			return 71;
		}
		else if(a == 67 && b == 5)
		{
			return 72;
		}
		else if(a == 67 && b == 6)
		{
			return 73;
		}
		else if(a == 67 && b == 7)
		{
			return 74;
		}
		else if(a == 67 && b == 8)
		{
			return 75;
		}
		else if(a == 67 && b == 9)
		{
			return 76;
		}
		else if(a == 67 && b == 10)
		{
			return 77;
		}
		else if(a == 67 && b == 11)
		{
			return 78;
		}
		else if(a == 67 && b == 12)
		{
			return 79;
		}
		else if(a == 67 && b == 13)
		{
			return 80;
		}
		else if(a == 67 && b == 14)
		{
			return 81;
		}
		else if(a == 67 && b == 15)
		{
			return 82;
		}
		else if(a == 67 && b == 16)
		{
			return 83;
		}
		else if(a == 67 && b == 17)
		{
			return 84;
		}
		else if(a == 67 && b == 18)
		{
			return 85;
		}
		else if(a == 67 && b == 19)
		{
			return 86;
		}
		else if(a == 67 && b == 20)
		{
			return 87;
		}
		else if(a == 67 && b == 21)
		{
			return 88;
		}
		else if(a == 67 && b == 22)
		{
			return 89;
		}
		else if(a == 67 && b == 23)
		{
			return 90;
		}
		else if(a == 67 && b == 24)
		{
			return 91;
		}
		else if(a == 67 && b == 25)
		{
			return 92;
		}
		else if(a == 67 && b == 26)
		{
			return 93;
		}
		else if(a == 67 && b == 27)
		{
			return 94;
		}
		else if(a == 67 && b == 28)
		{
			return 95;
		}
		else if(a == 67 && b == 29)
		{
			return 96;
		}
		else if(a == 67 && b == 30)
		{
			return 97;
		}
		else if(a == 67 && b == 31)
		{
			return 98;
		}
		else if(a == 67 && b == 32)
		{
			return 99;
		}
		else if(a == 67 && b == 33)
		{
			return 100;
		}
		else if(a == 67 && b == 34)
		{
			return 101;
		}
		else if(a == 67 && b == 35)
		{
			return 102;
		}
		else if(a == 67 && b == 36)
		{
			return 103;
		}
		else if(a == 67 && b == 37)
		{
			return 104;
		}
		else if(a == 67 && b == 38)
		{
			return 105;
		}
		else if(a == 67 && b == 39)
		{
			return 106;
		}
		else if(a == 67 && b == 40)
		{
			return 107;
		}
		else if(a == 67 && b == 41)
		{
			return 108;
		}
		else if(a == 67 && b == 42)
		{
			return 109;
		}
		else if(a == 67 && b == 43)
		{
			return 110;
		}
		else if(a == 67 && b == 44)
		{
			return 111;
		}
		else if(a == 67 && b == 45)
		{
			return 112;
		}
		else if(a == 67 && b == 46)
		{
			return 113;
		}
		else if(a == 67 && b == 47)
		{
			return 114;
		}
		else if(a == 67 && b == 48)
		{
			return 115;
		}
		else if(a == 67 && b == 49)
		{
			return 116;
		}
		else if(a == 67 && b == 50)
		{
			return 117;
		}
		else if(a == 67 && b == 51)
		{
			return 118;
		}
		else if(a == 67 && b == 52)
		{
			return 119;
		}
		else if(a == 67 && b == 53)
		{
			return 120;
		}
		else if(a == 67 && b == 54)
		{
			return 121;
		}
		else if(a == 67 && b == 55)
		{
			return 122;
		}
		else if(a == 67 && b == 56)
		{
			return 123;
		}
		else if(a == 67 && b == 57)
		{
			return 124;
		}
		else if(a == 67 && b == 58)
		{
			return 125;
		}
		else if(a == 67 && b == 59)
		{
			return 126;
		}
		else if(a == 67 && b == 60)
		{
			return 127;
		}
		else if(a == 67 && b == 61)
		{
			return 128;
		}
		else if(a == 67 && b == 62)
		{
			return 129;
		}
		else if(a == 67 && b == 63)
		{
			return 130;
		}
		else if(a == 67 && b == 64)
		{
			return 131;
		}
		else if(a == 67 && b == 65)
		{
			return 132;
		}
		else if(a == 67 && b == 66)
		{
			return 133;
		}
		else if(a == 67 && b == 67)
		{
			return 134;
		}
		else if(a == 67 && b == 68)
		{
			return 135;
		}
		else if(a == 67 && b == 69)
		{
			return 136;
		}
		else if(a == 67 && b == 70)
		{
			return 137;
		}
		else if(a == 67 && b == 71)
		{
			return 138;
		}
		else if(a == 67 && b == 72)
		{
			return 139;
		}
		else if(a == 67 && b == 73)
		{
			return 140;
		}
		else if(a == 67 && b == 74)
		{
			return 141;
		}
		else if(a == 67 && b == 75)
		{
			return 142;
		}
		else if(a == 67 && b == 76)
		{
			return 143;
		}
		else if(a == 67 && b == 77)
		{
			return 144;
		}
		else if(a == 67 && b == 78)
		{
			return 145;
		}
		else if(a == 67 && b == 79)
		{
			return 146;
		}
		else if(a == 67 && b == 80)
		{
			return 147;
		}
		else if(a == 67 && b == 81)
		{
			return 148;
		}
		else if(a == 67 && b == 82)
		{
			return 149;
		}
		else if(a == 67 && b == 83)
		{
			return 150;
		}
		else if(a == 67 && b == 84)
		{
			return 151;
		}
		else if(a == 67 && b == 85)
		{
			return 152;
		}
		else if(a == 67 && b == 86)
		{
			return 153;
		}
		else if(a == 67 && b == 87)
		{
			return 154;
		}
		else if(a == 67 && b == 88)
		{
			return 155;
		}
		else if(a == 67 && b == 89)
		{
			return 156;
		}
		else if(a == 67 && b == 90)
		{
			return 157;
		}
		else if(a == 67 && b == 91)
		{
			return 158;
		}
		else if(a == 67 && b == 92)
		{
			return 159;
		}
		else if(a == 67 && b == 93)
		{
			return 160;
		}
		else if(a == 67 && b == 94)
		{
			return 161;
		}
		else if(a == 67 && b == 95)
		{
			return 162;
		}
		else if(a == 67 && b == 96)
		{
			return 163;
		}
		else if(a == 67 && b == 97)
		{
			return 164;
		}
		else if(a == 67 && b == 98)
		{
			return 165;
		}
		else if(a == 67 && b == 99)
		{
			return 166;
		}
		else if(a == 67 && b == 100)
		{
			return 167;
		}
		else if(a == 68 && b == 0)
		{
			return 68;
		}
		else if(a == 68 && b == 1)
		{
			return 69;
		}
		else if(a == 68 && b == 2)
		{
			return 70;
		}
		else if(a == 68 && b == 3)
		{
			return 71;
		}
		else if(a == 68 && b == 4)
		{
			return 72;
		}
		else if(a == 68 && b == 5)
		{
			return 73;
		}
		else if(a == 68 && b == 6)
		{
			return 74;
		}
		else if(a == 68 && b == 7)
		{
			return 75;
		}
		else if(a == 68 && b == 8)
		{
			return 76;
		}
		else if(a == 68 && b == 9)
		{
			return 77;
		}
		else if(a == 68 && b == 10)
		{
			return 78;
		}
		else if(a == 68 && b == 11)
		{
			return 79;
		}
		else if(a == 68 && b == 12)
		{
			return 80;
		}
		else if(a == 68 && b == 13)
		{
			return 81;
		}
		else if(a == 68 && b == 14)
		{
			return 82;
		}
		else if(a == 68 && b == 15)
		{
			return 83;
		}
		else if(a == 68 && b == 16)
		{
			return 84;
		}
		else if(a == 68 && b == 17)
		{
			return 85;
		}
		else if(a == 68 && b == 18)
		{
			return 86;
		}
		else if(a == 68 && b == 19)
		{
			return 87;
		}
		else if(a == 68 && b == 20)
		{
			return 88;
		}
		else if(a == 68 && b == 21)
		{
			return 89;
		}
		else if(a == 68 && b == 22)
		{
			return 90;
		}
		else if(a == 68 && b == 23)
		{
			return 91;
		}
		else if(a == 68 && b == 24)
		{
			return 92;
		}
		else if(a == 68 && b == 25)
		{
			return 93;
		}
		else if(a == 68 && b == 26)
		{
			return 94;
		}
		else if(a == 68 && b == 27)
		{
			return 95;
		}
		else if(a == 68 && b == 28)
		{
			return 96;
		}
		else if(a == 68 && b == 29)
		{
			return 97;
		}
		else if(a == 68 && b == 30)
		{
			return 98;
		}
		else if(a == 68 && b == 31)
		{
			return 99;
		}
		else if(a == 68 && b == 32)
		{
			return 100;
		}
		else if(a == 68 && b == 33)
		{
			return 101;
		}
		else if(a == 68 && b == 34)
		{
			return 102;
		}
		else if(a == 68 && b == 35)
		{
			return 103;
		}
		else if(a == 68 && b == 36)
		{
			return 104;
		}
		else if(a == 68 && b == 37)
		{
			return 105;
		}
		else if(a == 68 && b == 38)
		{
			return 106;
		}
		else if(a == 68 && b == 39)
		{
			return 107;
		}
		else if(a == 68 && b == 40)
		{
			return 108;
		}
		else if(a == 68 && b == 41)
		{
			return 109;
		}
		else if(a == 68 && b == 42)
		{
			return 110;
		}
		else if(a == 68 && b == 43)
		{
			return 111;
		}
		else if(a == 68 && b == 44)
		{
			return 112;
		}
		else if(a == 68 && b == 45)
		{
			return 113;
		}
		else if(a == 68 && b == 46)
		{
			return 114;
		}
		else if(a == 68 && b == 47)
		{
			return 115;
		}
		else if(a == 68 && b == 48)
		{
			return 116;
		}
		else if(a == 68 && b == 49)
		{
			return 117;
		}
		else if(a == 68 && b == 50)
		{
			return 118;
		}
		else if(a == 68 && b == 51)
		{
			return 119;
		}
		else if(a == 68 && b == 52)
		{
			return 120;
		}
		else if(a == 68 && b == 53)
		{
			return 121;
		}
		else if(a == 68 && b == 54)
		{
			return 122;
		}
		else if(a == 68 && b == 55)
		{
			return 123;
		}
		else if(a == 68 && b == 56)
		{
			return 124;
		}
		else if(a == 68 && b == 57)
		{
			return 125;
		}
		else if(a == 68 && b == 58)
		{
			return 126;
		}
		else if(a == 68 && b == 59)
		{
			return 127;
		}
		else if(a == 68 && b == 60)
		{
			return 128;
		}
		else if(a == 68 && b == 61)
		{
			return 129;
		}
		else if(a == 68 && b == 62)
		{
			return 130;
		}
		else if(a == 68 && b == 63)
		{
			return 131;
		}
		else if(a == 68 && b == 64)
		{
			return 132;
		}
		else if(a == 68 && b == 65)
		{
			return 133;
		}
		else if(a == 68 && b == 66)
		{
			return 134;
		}
		else if(a == 68 && b == 67)
		{
			return 135;
		}
		else if(a == 68 && b == 68)
		{
			return 136;
		}
		else if(a == 68 && b == 69)
		{
			return 137;
		}
		else if(a == 68 && b == 70)
		{
			return 138;
		}
		else if(a == 68 && b == 71)
		{
			return 139;
		}
		else if(a == 68 && b == 72)
		{
			return 140;
		}
		else if(a == 68 && b == 73)
		{
			return 141;
		}
		else if(a == 68 && b == 74)
		{
			return 142;
		}
		else if(a == 68 && b == 75)
		{
			return 143;
		}
		else if(a == 68 && b == 76)
		{
			return 144;
		}
		else if(a == 68 && b == 77)
		{
			return 145;
		}
		else if(a == 68 && b == 78)
		{
			return 146;
		}
		else if(a == 68 && b == 79)
		{
			return 147;
		}
		else if(a == 68 && b == 80)
		{
			return 148;
		}
		else if(a == 68 && b == 81)
		{
			return 149;
		}
		else if(a == 68 && b == 82)
		{
			return 150;
		}
		else if(a == 68 && b == 83)
		{
			return 151;
		}
		else if(a == 68 && b == 84)
		{
			return 152;
		}
		else if(a == 68 && b == 85)
		{
			return 153;
		}
		else if(a == 68 && b == 86)
		{
			return 154;
		}
		else if(a == 68 && b == 87)
		{
			return 155;
		}
		else if(a == 68 && b == 88)
		{
			return 156;
		}
		else if(a == 68 && b == 89)
		{
			return 157;
		}
		else if(a == 68 && b == 90)
		{
			return 158;
		}
		else if(a == 68 && b == 91)
		{
			return 159;
		}
		else if(a == 68 && b == 92)
		{
			return 160;
		}
		else if(a == 68 && b == 93)
		{
			return 161;
		}
		else if(a == 68 && b == 94)
		{
			return 162;
		}
		else if(a == 68 && b == 95)
		{
			return 163;
		}
		else if(a == 68 && b == 96)
		{
			return 164;
		}
		else if(a == 68 && b == 97)
		{
			return 165;
		}
		else if(a == 68 && b == 98)
		{
			return 166;
		}
		else if(a == 68 && b == 99)
		{
			return 167;
		}
		else if(a == 68 && b == 100)
		{
			return 168;
		}
		else if(a == 69 && b == 0)
		{
			return 69;
		}
		else if(a == 69 && b == 1)
		{
			return 70;
		}
		else if(a == 69 && b == 2)
		{
			return 71;
		}
		else if(a == 69 && b == 3)
		{
			return 72;
		}
		else if(a == 69 && b == 4)
		{
			return 73;
		}
		else if(a == 69 && b == 5)
		{
			return 74;
		}
		else if(a == 69 && b == 6)
		{
			return 75;
		}
		else if(a == 69 && b == 7)
		{
			return 76;
		}
		else if(a == 69 && b == 8)
		{
			return 77;
		}
		else if(a == 69 && b == 9)
		{
			return 78;
		}
		else if(a == 69 && b == 10)
		{
			return 79;
		}
		else if(a == 69 && b == 11)
		{
			return 80;
		}
		else if(a == 69 && b == 12)
		{
			return 81;
		}
		else if(a == 69 && b == 13)
		{
			return 82;
		}
		else if(a == 69 && b == 14)
		{
			return 83;
		}
		else if(a == 69 && b == 15)
		{
			return 84;
		}
		else if(a == 69 && b == 16)
		{
			return 85;
		}
		else if(a == 69 && b == 17)
		{
			return 86;
		}
		else if(a == 69 && b == 18)
		{
			return 87;
		}
		else if(a == 69 && b == 19)
		{
			return 88;
		}
		else if(a == 69 && b == 20)
		{
			return 89;
		}
		else if(a == 69 && b == 21)
		{
			return 90;
		}
		else if(a == 69 && b == 22)
		{
			return 91;
		}
		else if(a == 69 && b == 23)
		{
			return 92;
		}
		else if(a == 69 && b == 24)
		{
			return 93;
		}
		else if(a == 69 && b == 25)
		{
			return 94;
		}
		else if(a == 69 && b == 26)
		{
			return 95;
		}
		else if(a == 69 && b == 27)
		{
			return 96;
		}
		else if(a == 69 && b == 28)
		{
			return 97;
		}
		else if(a == 69 && b == 29)
		{
			return 98;
		}
		else if(a == 69 && b == 30)
		{
			return 99;
		}
		else if(a == 69 && b == 31)
		{
			return 100;
		}
		else if(a == 69 && b == 32)
		{
			return 101;
		}
		else if(a == 69 && b == 33)
		{
			return 102;
		}
		else if(a == 69 && b == 34)
		{
			return 103;
		}
		else if(a == 69 && b == 35)
		{
			return 104;
		}
		else if(a == 69 && b == 36)
		{
			return 105;
		}
		else if(a == 69 && b == 37)
		{
			return 106;
		}
		else if(a == 69 && b == 38)
		{
			return 107;
		}
		else if(a == 69 && b == 39)
		{
			return 108;
		}
		else if(a == 69 && b == 40)
		{
			return 109;
		}
		else if(a == 69 && b == 41)
		{
			return 110;
		}
		else if(a == 69 && b == 42)
		{
			return 111;
		}
		else if(a == 69 && b == 43)
		{
			return 112;
		}
		else if(a == 69 && b == 44)
		{
			return 113;
		}
		else if(a == 69 && b == 45)
		{
			return 114;
		}
		else if(a == 69 && b == 46)
		{
			return 115;
		}
		else if(a == 69 && b == 47)
		{
			return 116;
		}
		else if(a == 69 && b == 48)
		{
			return 117;
		}
		else if(a == 69 && b == 49)
		{
			return 118;
		}
		else if(a == 69 && b == 50)
		{
			return 119;
		}
		else if(a == 69 && b == 51)
		{
			return 120;
		}
		else if(a == 69 && b == 52)
		{
			return 121;
		}
		else if(a == 69 && b == 53)
		{
			return 122;
		}
		else if(a == 69 && b == 54)
		{
			return 123;
		}
		else if(a == 69 && b == 55)
		{
			return 124;
		}
		else if(a == 69 && b == 56)
		{
			return 125;
		}
		else if(a == 69 && b == 57)
		{
			return 126;
		}
		else if(a == 69 && b == 58)
		{
			return 127;
		}
		else if(a == 69 && b == 59)
		{
			return 128;
		}
		else if(a == 69 && b == 60)
		{
			return 129;
		}
		else if(a == 69 && b == 61)
		{
			return 130;
		}
		else if(a == 69 && b == 62)
		{
			return 131;
		}
		else if(a == 69 && b == 63)
		{
			return 132;
		}
		else if(a == 69 && b == 64)
		{
			return 133;
		}
		else if(a == 69 && b == 65)
		{
			return 134;
		}
		else if(a == 69 && b == 66)
		{
			return 135;
		}
		else if(a == 69 && b == 67)
		{
			return 136;
		}
		else if(a == 69 && b == 68)
		{
			return 137;
		}
		else if(a == 69 && b == 69)
		{
			return 138;
		}
		else if(a == 69 && b == 70)
		{
			return 139;
		}
		else if(a == 69 && b == 71)
		{
			return 140;
		}
		else if(a == 69 && b == 72)
		{
			return 141;
		}
		else if(a == 69 && b == 73)
		{
			return 142;
		}
		else if(a == 69 && b == 74)
		{
			return 143;
		}
		else if(a == 69 && b == 75)
		{
			return 144;
		}
		else if(a == 69 && b == 76)
		{
			return 145;
		}
		else if(a == 69 && b == 77)
		{
			return 146;
		}
		else if(a == 69 && b == 78)
		{
			return 147;
		}
		else if(a == 69 && b == 79)
		{
			return 148;
		}
		else if(a == 69 && b == 80)
		{
			return 149;
		}
		else if(a == 69 && b == 81)
		{
			return 150;
		}
		else if(a == 69 && b == 82)
		{
			return 151;
		}
		else if(a == 69 && b == 83)
		{
			return 152;
		}
		else if(a == 69 && b == 84)
		{
			return 153;
		}
		else if(a == 69 && b == 85)
		{
			return 154;
		}
		else if(a == 69 && b == 86)
		{
			return 155;
		}
		else if(a == 69 && b == 87)
		{
			return 156;
		}
		else if(a == 69 && b == 88)
		{
			return 157;
		}
		else if(a == 69 && b == 89)
		{
			return 158;
		}
		else if(a == 69 && b == 90)
		{
			return 159;
		}
		else if(a == 69 && b == 91)
		{
			return 160;
		}
		else if(a == 69 && b == 92)
		{
			return 161;
		}
		else if(a == 69 && b == 93)
		{
			return 162;
		}
		else if(a == 69 && b == 94)
		{
			return 163;
		}
		else if(a == 69 && b == 95)
		{
			return 164;
		}
		else if(a == 69 && b == 96)
		{
			return 165;
		}
		else if(a == 69 && b == 97)
		{
			return 166;
		}
		else if(a == 69 && b == 98)
		{
			return 167;
		}
		else if(a == 69 && b == 99)
		{
			return 168;
		}
		else if(a == 69 && b == 100)
		{
			return 169;
		}
		else if(a == 70 && b == 0)
		{
			return 70;
		}
		else if(a == 70 && b == 1)
		{
			return 71;
		}
		else if(a == 70 && b == 2)
		{
			return 72;
		}
		else if(a == 70 && b == 3)
		{
			return 73;
		}
		else if(a == 70 && b == 4)
		{
			return 74;
		}
		else if(a == 70 && b == 5)
		{
			return 75;
		}
		else if(a == 70 && b == 6)
		{
			return 76;
		}
		else if(a == 70 && b == 7)
		{
			return 77;
		}
		else if(a == 70 && b == 8)
		{
			return 78;
		}
		else if(a == 70 && b == 9)
		{
			return 79;
		}
		else if(a == 70 && b == 10)
		{
			return 80;
		}
		else if(a == 70 && b == 11)
		{
			return 81;
		}
		else if(a == 70 && b == 12)
		{
			return 82;
		}
		else if(a == 70 && b == 13)
		{
			return 83;
		}
		else if(a == 70 && b == 14)
		{
			return 84;
		}
		else if(a == 70 && b == 15)
		{
			return 85;
		}
		else if(a == 70 && b == 16)
		{
			return 86;
		}
		else if(a == 70 && b == 17)
		{
			return 87;
		}
		else if(a == 70 && b == 18)
		{
			return 88;
		}
		else if(a == 70 && b == 19)
		{
			return 89;
		}
		else if(a == 70 && b == 20)
		{
			return 90;
		}
		else if(a == 70 && b == 21)
		{
			return 91;
		}
		else if(a == 70 && b == 22)
		{
			return 92;
		}
		else if(a == 70 && b == 23)
		{
			return 93;
		}
		else if(a == 70 && b == 24)
		{
			return 94;
		}
		else if(a == 70 && b == 25)
		{
			return 95;
		}
		else if(a == 70 && b == 26)
		{
			return 96;
		}
		else if(a == 70 && b == 27)
		{
			return 97;
		}
		else if(a == 70 && b == 28)
		{
			return 98;
		}
		else if(a == 70 && b == 29)
		{
			return 99;
		}
		else if(a == 70 && b == 30)
		{
			return 100;
		}
		else if(a == 70 && b == 31)
		{
			return 101;
		}
		else if(a == 70 && b == 32)
		{
			return 102;
		}
		else if(a == 70 && b == 33)
		{
			return 103;
		}
		else if(a == 70 && b == 34)
		{
			return 104;
		}
		else if(a == 70 && b == 35)
		{
			return 105;
		}
		else if(a == 70 && b == 36)
		{
			return 106;
		}
		else if(a == 70 && b == 37)
		{
			return 107;
		}
		else if(a == 70 && b == 38)
		{
			return 108;
		}
		else if(a == 70 && b == 39)
		{
			return 109;
		}
		else if(a == 70 && b == 40)
		{
			return 110;
		}
		else if(a == 70 && b == 41)
		{
			return 111;
		}
		else if(a == 70 && b == 42)
		{
			return 112;
		}
		else if(a == 70 && b == 43)
		{
			return 113;
		}
		else if(a == 70 && b == 44)
		{
			return 114;
		}
		else if(a == 70 && b == 45)
		{
			return 115;
		}
		else if(a == 70 && b == 46)
		{
			return 116;
		}
		else if(a == 70 && b == 47)
		{
			return 117;
		}
		else if(a == 70 && b == 48)
		{
			return 118;
		}
		else if(a == 70 && b == 49)
		{
			return 119;
		}
		else if(a == 70 && b == 50)
		{
			return 120;
		}
		else if(a == 70 && b == 51)
		{
			return 121;
		}
		else if(a == 70 && b == 52)
		{
			return 122;
		}
		else if(a == 70 && b == 53)
		{
			return 123;
		}
		else if(a == 70 && b == 54)
		{
			return 124;
		}
		else if(a == 70 && b == 55)
		{
			return 125;
		}
		else if(a == 70 && b == 56)
		{
			return 126;
		}
		else if(a == 70 && b == 57)
		{
			return 127;
		}
		else if(a == 70 && b == 58)
		{
			return 128;
		}
		else if(a == 70 && b == 59)
		{
			return 129;
		}
		else if(a == 70 && b == 60)
		{
			return 130;
		}
		else if(a == 70 && b == 61)
		{
			return 131;
		}
		else if(a == 70 && b == 62)
		{
			return 132;
		}
		else if(a == 70 && b == 63)
		{
			return 133;
		}
		else if(a == 70 && b == 64)
		{
			return 134;
		}
		else if(a == 70 && b == 65)
		{
			return 135;
		}
		else if(a == 70 && b == 66)
		{
			return 136;
		}
		else if(a == 70 && b == 67)
		{
			return 137;
		}
		else if(a == 70 && b == 68)
		{
			return 138;
		}
		else if(a == 70 && b == 69)
		{
			return 139;
		}
		else if(a == 70 && b == 70)
		{
			return 140;
		}
		else if(a == 70 && b == 71)
		{
			return 141;
		}
		else if(a == 70 && b == 72)
		{
			return 142;
		}
		else if(a == 70 && b == 73)
		{
			return 143;
		}
		else if(a == 70 && b == 74)
		{
			return 144;
		}
		else if(a == 70 && b == 75)
		{
			return 145;
		}
		else if(a == 70 && b == 76)
		{
			return 146;
		}
		else if(a == 70 && b == 77)
		{
			return 147;
		}
		else if(a == 70 && b == 78)
		{
			return 148;
		}
		else if(a == 70 && b == 79)
		{
			return 149;
		}
		else if(a == 70 && b == 80)
		{
			return 150;
		}
		else if(a == 70 && b == 81)
		{
			return 151;
		}
		else if(a == 70 && b == 82)
		{
			return 152;
		}
		else if(a == 70 && b == 83)
		{
			return 153;
		}
		else if(a == 70 && b == 84)
		{
			return 154;
		}
		else if(a == 70 && b == 85)
		{
			return 155;
		}
		else if(a == 70 && b == 86)
		{
			return 156;
		}
		else if(a == 70 && b == 87)
		{
			return 157;
		}
		else if(a == 70 && b == 88)
		{
			return 158;
		}
		else if(a == 70 && b == 89)
		{
			return 159;
		}
		else if(a == 70 && b == 90)
		{
			return 160;
		}
		else if(a == 70 && b == 91)
		{
			return 161;
		}
		else if(a == 70 && b == 92)
		{
			return 162;
		}
		else if(a == 70 && b == 93)
		{
			return 163;
		}
		else if(a == 70 && b == 94)
		{
			return 164;
		}
		else if(a == 70 && b == 95)
		{
			return 165;
		}
		else if(a == 70 && b == 96)
		{
			return 166;
		}
		else if(a == 70 && b == 97)
		{
			return 167;
		}
		else if(a == 70 && b == 98)
		{
			return 168;
		}
		else if(a == 70 && b == 99)
		{
			return 169;
		}
		else if(a == 70 && b == 100)
		{
			return 170;
		}
		else if(a == 71 && b == 0)
		{
			return 71;
		}
		else if(a == 71 && b == 1)
		{
			return 72;
		}
		else if(a == 71 && b == 2)
		{
			return 73;
		}
		else if(a == 71 && b == 3)
		{
			return 74;
		}
		else if(a == 71 && b == 4)
		{
			return 75;
		}
		else if(a == 71 && b == 5)
		{
			return 76;
		}
		else if(a == 71 && b == 6)
		{
			return 77;
		}
		else if(a == 71 && b == 7)
		{
			return 78;
		}
		else if(a == 71 && b == 8)
		{
			return 79;
		}
		else if(a == 71 && b == 9)
		{
			return 80;
		}
		else if(a == 71 && b == 10)
		{
			return 81;
		}
		else if(a == 71 && b == 11)
		{
			return 82;
		}
		else if(a == 71 && b == 12)
		{
			return 83;
		}
		else if(a == 71 && b == 13)
		{
			return 84;
		}
		else if(a == 71 && b == 14)
		{
			return 85;
		}
		else if(a == 71 && b == 15)
		{
			return 86;
		}
		else if(a == 71 && b == 16)
		{
			return 87;
		}
		else if(a == 71 && b == 17)
		{
			return 88;
		}
		else if(a == 71 && b == 18)
		{
			return 89;
		}
		else if(a == 71 && b == 19)
		{
			return 90;
		}
		else if(a == 71 && b == 20)
		{
			return 91;
		}
		else if(a == 71 && b == 21)
		{
			return 92;
		}
		else if(a == 71 && b == 22)
		{
			return 93;
		}
		else if(a == 71 && b == 23)
		{
			return 94;
		}
		else if(a == 71 && b == 24)
		{
			return 95;
		}
		else if(a == 71 && b == 25)
		{
			return 96;
		}
		else if(a == 71 && b == 26)
		{
			return 97;
		}
		else if(a == 71 && b == 27)
		{
			return 98;
		}
		else if(a == 71 && b == 28)
		{
			return 99;
		}
		else if(a == 71 && b == 29)
		{
			return 100;
		}
		else if(a == 71 && b == 30)
		{
			return 101;
		}
		else if(a == 71 && b == 31)
		{
			return 102;
		}
		else if(a == 71 && b == 32)
		{
			return 103;
		}
		else if(a == 71 && b == 33)
		{
			return 104;
		}
		else if(a == 71 && b == 34)
		{
			return 105;
		}
		else if(a == 71 && b == 35)
		{
			return 106;
		}
		else if(a == 71 && b == 36)
		{
			return 107;
		}
		else if(a == 71 && b == 37)
		{
			return 108;
		}
		else if(a == 71 && b == 38)
		{
			return 109;
		}
		else if(a == 71 && b == 39)
		{
			return 110;
		}
		else if(a == 71 && b == 40)
		{
			return 111;
		}
		else if(a == 71 && b == 41)
		{
			return 112;
		}
		else if(a == 71 && b == 42)
		{
			return 113;
		}
		else if(a == 71 && b == 43)
		{
			return 114;
		}
		else if(a == 71 && b == 44)
		{
			return 115;
		}
		else if(a == 71 && b == 45)
		{
			return 116;
		}
		else if(a == 71 && b == 46)
		{
			return 117;
		}
		else if(a == 71 && b == 47)
		{
			return 118;
		}
		else if(a == 71 && b == 48)
		{
			return 119;
		}
		else if(a == 71 && b == 49)
		{
			return 120;
		}
		else if(a == 71 && b == 50)
		{
			return 121;
		}
		else if(a == 71 && b == 51)
		{
			return 122;
		}
		else if(a == 71 && b == 52)
		{
			return 123;
		}
		else if(a == 71 && b == 53)
		{
			return 124;
		}
		else if(a == 71 && b == 54)
		{
			return 125;
		}
		else if(a == 71 && b == 55)
		{
			return 126;
		}
		else if(a == 71 && b == 56)
		{
			return 127;
		}
		else if(a == 71 && b == 57)
		{
			return 128;
		}
		else if(a == 71 && b == 58)
		{
			return 129;
		}
		else if(a == 71 && b == 59)
		{
			return 130;
		}
		else if(a == 71 && b == 60)
		{
			return 131;
		}
		else if(a == 71 && b == 61)
		{
			return 132;
		}
		else if(a == 71 && b == 62)
		{
			return 133;
		}
		else if(a == 71 && b == 63)
		{
			return 134;
		}
		else if(a == 71 && b == 64)
		{
			return 135;
		}
		else if(a == 71 && b == 65)
		{
			return 136;
		}
		else if(a == 71 && b == 66)
		{
			return 137;
		}
		else if(a == 71 && b == 67)
		{
			return 138;
		}
		else if(a == 71 && b == 68)
		{
			return 139;
		}
		else if(a == 71 && b == 69)
		{
			return 140;
		}
		else if(a == 71 && b == 70)
		{
			return 141;
		}
		else if(a == 71 && b == 71)
		{
			return 142;
		}
		else if(a == 71 && b == 72)
		{
			return 143;
		}
		else if(a == 71 && b == 73)
		{
			return 144;
		}
		else if(a == 71 && b == 74)
		{
			return 145;
		}
		else if(a == 71 && b == 75)
		{
			return 146;
		}
		else if(a == 71 && b == 76)
		{
			return 147;
		}
		else if(a == 71 && b == 77)
		{
			return 148;
		}
		else if(a == 71 && b == 78)
		{
			return 149;
		}
		else if(a == 71 && b == 79)
		{
			return 150;
		}
		else if(a == 71 && b == 80)
		{
			return 151;
		}
		else if(a == 71 && b == 81)
		{
			return 152;
		}
		else if(a == 71 && b == 82)
		{
			return 153;
		}
		else if(a == 71 && b == 83)
		{
			return 154;
		}
		else if(a == 71 && b == 84)
		{
			return 155;
		}
		else if(a == 71 && b == 85)
		{
			return 156;
		}
		else if(a == 71 && b == 86)
		{
			return 157;
		}
		else if(a == 71 && b == 87)
		{
			return 158;
		}
		else if(a == 71 && b == 88)
		{
			return 159;
		}
		else if(a == 71 && b == 89)
		{
			return 160;
		}
		else if(a == 71 && b == 90)
		{
			return 161;
		}
		else if(a == 71 && b == 91)
		{
			return 162;
		}
		else if(a == 71 && b == 92)
		{
			return 163;
		}
		else if(a == 71 && b == 93)
		{
			return 164;
		}
		else if(a == 71 && b == 94)
		{
			return 165;
		}
		else if(a == 71 && b == 95)
		{
			return 166;
		}
		else if(a == 71 && b == 96)
		{
			return 167;
		}
		else if(a == 71 && b == 97)
		{
			return 168;
		}
		else if(a == 71 && b == 98)
		{
			return 169;
		}
		else if(a == 71 && b == 99)
		{
			return 170;
		}
		else if(a == 71 && b == 100)
		{
			return 171;
		}
		else if(a == 72 && b == 0)
		{
			return 72;
		}
		else if(a == 72 && b == 1)
		{
			return 73;
		}
		else if(a == 72 && b == 2)
		{
			return 74;
		}
		else if(a == 72 && b == 3)
		{
			return 75;
		}
		else if(a == 72 && b == 4)
		{
			return 76;
		}
		else if(a == 72 && b == 5)
		{
			return 77;
		}
		else if(a == 72 && b == 6)
		{
			return 78;
		}
		else if(a == 72 && b == 7)
		{
			return 79;
		}
		else if(a == 72 && b == 8)
		{
			return 80;
		}
		else if(a == 72 && b == 9)
		{
			return 81;
		}
		else if(a == 72 && b == 10)
		{
			return 82;
		}
		else if(a == 72 && b == 11)
		{
			return 83;
		}
		else if(a == 72 && b == 12)
		{
			return 84;
		}
		else if(a == 72 && b == 13)
		{
			return 85;
		}
		else if(a == 72 && b == 14)
		{
			return 86;
		}
		else if(a == 72 && b == 15)
		{
			return 87;
		}
		else if(a == 72 && b == 16)
		{
			return 88;
		}
		else if(a == 72 && b == 17)
		{
			return 89;
		}
		else if(a == 72 && b == 18)
		{
			return 90;
		}
		else if(a == 72 && b == 19)
		{
			return 91;
		}
		else if(a == 72 && b == 20)
		{
			return 92;
		}
		else if(a == 72 && b == 21)
		{
			return 93;
		}
		else if(a == 72 && b == 22)
		{
			return 94;
		}
		else if(a == 72 && b == 23)
		{
			return 95;
		}
		else if(a == 72 && b == 24)
		{
			return 96;
		}
		else if(a == 72 && b == 25)
		{
			return 97;
		}
		else if(a == 72 && b == 26)
		{
			return 98;
		}
		else if(a == 72 && b == 27)
		{
			return 99;
		}
		else if(a == 72 && b == 28)
		{
			return 100;
		}
		else if(a == 72 && b == 29)
		{
			return 101;
		}
		else if(a == 72 && b == 30)
		{
			return 102;
		}
		else if(a == 72 && b == 31)
		{
			return 103;
		}
		else if(a == 72 && b == 32)
		{
			return 104;
		}
		else if(a == 72 && b == 33)
		{
			return 105;
		}
		else if(a == 72 && b == 34)
		{
			return 106;
		}
		else if(a == 72 && b == 35)
		{
			return 107;
		}
		else if(a == 72 && b == 36)
		{
			return 108;
		}
		else if(a == 72 && b == 37)
		{
			return 109;
		}
		else if(a == 72 && b == 38)
		{
			return 110;
		}
		else if(a == 72 && b == 39)
		{
			return 111;
		}
		else if(a == 72 && b == 40)
		{
			return 112;
		}
		else if(a == 72 && b == 41)
		{
			return 113;
		}
		else if(a == 72 && b == 42)
		{
			return 114;
		}
		else if(a == 72 && b == 43)
		{
			return 115;
		}
		else if(a == 72 && b == 44)
		{
			return 116;
		}
		else if(a == 72 && b == 45)
		{
			return 117;
		}
		else if(a == 72 && b == 46)
		{
			return 118;
		}
		else if(a == 72 && b == 47)
		{
			return 119;
		}
		else if(a == 72 && b == 48)
		{
			return 120;
		}
		else if(a == 72 && b == 49)
		{
			return 121;
		}
		else if(a == 72 && b == 50)
		{
			return 122;
		}
		else if(a == 72 && b == 51)
		{
			return 123;
		}
		else if(a == 72 && b == 52)
		{
			return 124;
		}
		else if(a == 72 && b == 53)
		{
			return 125;
		}
		else if(a == 72 && b == 54)
		{
			return 126;
		}
		else if(a == 72 && b == 55)
		{
			return 127;
		}
		else if(a == 72 && b == 56)
		{
			return 128;
		}
		else if(a == 72 && b == 57)
		{
			return 129;
		}
		else if(a == 72 && b == 58)
		{
			return 130;
		}
		else if(a == 72 && b == 59)
		{
			return 131;
		}
		else if(a == 72 && b == 60)
		{
			return 132;
		}
		else if(a == 72 && b == 61)
		{
			return 133;
		}
		else if(a == 72 && b == 62)
		{
			return 134;
		}
		else if(a == 72 && b == 63)
		{
			return 135;
		}
		else if(a == 72 && b == 64)
		{
			return 136;
		}
		else if(a == 72 && b == 65)
		{
			return 137;
		}
		else if(a == 72 && b == 66)
		{
			return 138;
		}
		else if(a == 72 && b == 67)
		{
			return 139;
		}
		else if(a == 72 && b == 68)
		{
			return 140;
		}
		else if(a == 72 && b == 69)
		{
			return 141;
		}
		else if(a == 72 && b == 70)
		{
			return 142;
		}
		else if(a == 72 && b == 71)
		{
			return 143;
		}
		else if(a == 72 && b == 72)
		{
			return 144;
		}
		else if(a == 72 && b == 73)
		{
			return 145;
		}
		else if(a == 72 && b == 74)
		{
			return 146;
		}
		else if(a == 72 && b == 75)
		{
			return 147;
		}
		else if(a == 72 && b == 76)
		{
			return 148;
		}
		else if(a == 72 && b == 77)
		{
			return 149;
		}
		else if(a == 72 && b == 78)
		{
			return 150;
		}
		else if(a == 72 && b == 79)
		{
			return 151;
		}
		else if(a == 72 && b == 80)
		{
			return 152;
		}
		else if(a == 72 && b == 81)
		{
			return 153;
		}
		else if(a == 72 && b == 82)
		{
			return 154;
		}
		else if(a == 72 && b == 83)
		{
			return 155;
		}
		else if(a == 72 && b == 84)
		{
			return 156;
		}
		else if(a == 72 && b == 85)
		{
			return 157;
		}
		else if(a == 72 && b == 86)
		{
			return 158;
		}
		else if(a == 72 && b == 87)
		{
			return 159;
		}
		else if(a == 72 && b == 88)
		{
			return 160;
		}
		else if(a == 72 && b == 89)
		{
			return 161;
		}
		else if(a == 72 && b == 90)
		{
			return 162;
		}
		else if(a == 72 && b == 91)
		{
			return 163;
		}
		else if(a == 72 && b == 92)
		{
			return 164;
		}
		else if(a == 72 && b == 93)
		{
			return 165;
		}
		else if(a == 72 && b == 94)
		{
			return 166;
		}
		else if(a == 72 && b == 95)
		{
			return 167;
		}
		else if(a == 72 && b == 96)
		{
			return 168;
		}
		else if(a == 72 && b == 97)
		{
			return 169;
		}
		else if(a == 72 && b == 98)
		{
			return 170;
		}
		else if(a == 72 && b == 99)
		{
			return 171;
		}
		else if(a == 72 && b == 100)
		{
			return 172;
		}
		else if(a == 73 && b == 0)
		{
			return 73;
		}
		else if(a == 73 && b == 1)
		{
			return 74;
		}
		else if(a == 73 && b == 2)
		{
			return 75;
		}
		else if(a == 73 && b == 3)
		{
			return 76;
		}
		else if(a == 73 && b == 4)
		{
			return 77;
		}
		else if(a == 73 && b == 5)
		{
			return 78;
		}
		else if(a == 73 && b == 6)
		{
			return 79;
		}
		else if(a == 73 && b == 7)
		{
			return 80;
		}
		else if(a == 73 && b == 8)
		{
			return 81;
		}
		else if(a == 73 && b == 9)
		{
			return 82;
		}
		else if(a == 73 && b == 10)
		{
			return 83;
		}
		else if(a == 73 && b == 11)
		{
			return 84;
		}
		else if(a == 73 && b == 12)
		{
			return 85;
		}
		else if(a == 73 && b == 13)
		{
			return 86;
		}
		else if(a == 73 && b == 14)
		{
			return 87;
		}
		else if(a == 73 && b == 15)
		{
			return 88;
		}
		else if(a == 73 && b == 16)
		{
			return 89;
		}
		else if(a == 73 && b == 17)
		{
			return 90;
		}
		else if(a == 73 && b == 18)
		{
			return 91;
		}
		else if(a == 73 && b == 19)
		{
			return 92;
		}
		else if(a == 73 && b == 20)
		{
			return 93;
		}
		else if(a == 73 && b == 21)
		{
			return 94;
		}
		else if(a == 73 && b == 22)
		{
			return 95;
		}
		else if(a == 73 && b == 23)
		{
			return 96;
		}
		else if(a == 73 && b == 24)
		{
			return 97;
		}
		else if(a == 73 && b == 25)
		{
			return 98;
		}
		else if(a == 73 && b == 26)
		{
			return 99;
		}
		else if(a == 73 && b == 27)
		{
			return 100;
		}
		else if(a == 73 && b == 28)
		{
			return 101;
		}
		else if(a == 73 && b == 29)
		{
			return 102;
		}
		else if(a == 73 && b == 30)
		{
			return 103;
		}
		else if(a == 73 && b == 31)
		{
			return 104;
		}
		else if(a == 73 && b == 32)
		{
			return 105;
		}
		else if(a == 73 && b == 33)
		{
			return 106;
		}
		else if(a == 73 && b == 34)
		{
			return 107;
		}
		else if(a == 73 && b == 35)
		{
			return 108;
		}
		else if(a == 73 && b == 36)
		{
			return 109;
		}
		else if(a == 73 && b == 37)
		{
			return 110;
		}
		else if(a == 73 && b == 38)
		{
			return 111;
		}
		else if(a == 73 && b == 39)
		{
			return 112;
		}
		else if(a == 73 && b == 40)
		{
			return 113;
		}
		else if(a == 73 && b == 41)
		{
			return 114;
		}
		else if(a == 73 && b == 42)
		{
			return 115;
		}
		else if(a == 73 && b == 43)
		{
			return 116;
		}
		else if(a == 73 && b == 44)
		{
			return 117;
		}
		else if(a == 73 && b == 45)
		{
			return 118;
		}
		else if(a == 73 && b == 46)
		{
			return 119;
		}
		else if(a == 73 && b == 47)
		{
			return 120;
		}
		else if(a == 73 && b == 48)
		{
			return 121;
		}
		else if(a == 73 && b == 49)
		{
			return 122;
		}
		else if(a == 73 && b == 50)
		{
			return 123;
		}
		else if(a == 73 && b == 51)
		{
			return 124;
		}
		else if(a == 73 && b == 52)
		{
			return 125;
		}
		else if(a == 73 && b == 53)
		{
			return 126;
		}
		else if(a == 73 && b == 54)
		{
			return 127;
		}
		else if(a == 73 && b == 55)
		{
			return 128;
		}
		else if(a == 73 && b == 56)
		{
			return 129;
		}
		else if(a == 73 && b == 57)
		{
			return 130;
		}
		else if(a == 73 && b == 58)
		{
			return 131;
		}
		else if(a == 73 && b == 59)
		{
			return 132;
		}
		else if(a == 73 && b == 60)
		{
			return 133;
		}
		else if(a == 73 && b == 61)
		{
			return 134;
		}
		else if(a == 73 && b == 62)
		{
			return 135;
		}
		else if(a == 73 && b == 63)
		{
			return 136;
		}
		else if(a == 73 && b == 64)
		{
			return 137;
		}
		else if(a == 73 && b == 65)
		{
			return 138;
		}
		else if(a == 73 && b == 66)
		{
			return 139;
		}
		else if(a == 73 && b == 67)
		{
			return 140;
		}
		else if(a == 73 && b == 68)
		{
			return 141;
		}
		else if(a == 73 && b == 69)
		{
			return 142;
		}
		else if(a == 73 && b == 70)
		{
			return 143;
		}
		else if(a == 73 && b == 71)
		{
			return 144;
		}
		else if(a == 73 && b == 72)
		{
			return 145;
		}
		else if(a == 73 && b == 73)
		{
			return 146;
		}
		else if(a == 73 && b == 74)
		{
			return 147;
		}
		else if(a == 73 && b == 75)
		{
			return 148;
		}
		else if(a == 73 && b == 76)
		{
			return 149;
		}
		else if(a == 73 && b == 77)
		{
			return 150;
		}
		else if(a == 73 && b == 78)
		{
			return 151;
		}
		else if(a == 73 && b == 79)
		{
			return 152;
		}
		else if(a == 73 && b == 80)
		{
			return 153;
		}
		else if(a == 73 && b == 81)
		{
			return 154;
		}
		else if(a == 73 && b == 82)
		{
			return 155;
		}
		else if(a == 73 && b == 83)
		{
			return 156;
		}
		else if(a == 73 && b == 84)
		{
			return 157;
		}
		else if(a == 73 && b == 85)
		{
			return 158;
		}
		else if(a == 73 && b == 86)
		{
			return 159;
		}
		else if(a == 73 && b == 87)
		{
			return 160;
		}
		else if(a == 73 && b == 88)
		{
			return 161;
		}
		else if(a == 73 && b == 89)
		{
			return 162;
		}
		else if(a == 73 && b == 90)
		{
			return 163;
		}
		else if(a == 73 && b == 91)
		{
			return 164;
		}
		else if(a == 73 && b == 92)
		{
			return 165;
		}
		else if(a == 73 && b == 93)
		{
			return 166;
		}
		else if(a == 73 && b == 94)
		{
			return 167;
		}
		else if(a == 73 && b == 95)
		{
			return 168;
		}
		else if(a == 73 && b == 96)
		{
			return 169;
		}
		else if(a == 73 && b == 97)
		{
			return 170;
		}
		else if(a == 73 && b == 98)
		{
			return 171;
		}
		else if(a == 73 && b == 99)
		{
			return 172;
		}
		else if(a == 73 && b == 100)
		{
			return 173;
		}
		else if(a == 74 && b == 0)
		{
			return 74;
		}
		else if(a == 74 && b == 1)
		{
			return 75;
		}
		else if(a == 74 && b == 2)
		{
			return 76;
		}
		else if(a == 74 && b == 3)
		{
			return 77;
		}
		else if(a == 74 && b == 4)
		{
			return 78;
		}
		else if(a == 74 && b == 5)
		{
			return 79;
		}
		else if(a == 74 && b == 6)
		{
			return 80;
		}
		else if(a == 74 && b == 7)
		{
			return 81;
		}
		else if(a == 74 && b == 8)
		{
			return 82;
		}
		else if(a == 74 && b == 9)
		{
			return 83;
		}
		else if(a == 74 && b == 10)
		{
			return 84;
		}
		else if(a == 74 && b == 11)
		{
			return 85;
		}
		else if(a == 74 && b == 12)
		{
			return 86;
		}
		else if(a == 74 && b == 13)
		{
			return 87;
		}
		else if(a == 74 && b == 14)
		{
			return 88;
		}
		else if(a == 74 && b == 15)
		{
			return 89;
		}
		else if(a == 74 && b == 16)
		{
			return 90;
		}
		else if(a == 74 && b == 17)
		{
			return 91;
		}
		else if(a == 74 && b == 18)
		{
			return 92;
		}
		else if(a == 74 && b == 19)
		{
			return 93;
		}
		else if(a == 74 && b == 20)
		{
			return 94;
		}
		else if(a == 74 && b == 21)
		{
			return 95;
		}
		else if(a == 74 && b == 22)
		{
			return 96;
		}
		else if(a == 74 && b == 23)
		{
			return 97;
		}
		else if(a == 74 && b == 24)
		{
			return 98;
		}
		else if(a == 74 && b == 25)
		{
			return 99;
		}
		else if(a == 74 && b == 26)
		{
			return 100;
		}
		else if(a == 74 && b == 27)
		{
			return 101;
		}
		else if(a == 74 && b == 28)
		{
			return 102;
		}
		else if(a == 74 && b == 29)
		{
			return 103;
		}
		else if(a == 74 && b == 30)
		{
			return 104;
		}
		else if(a == 74 && b == 31)
		{
			return 105;
		}
		else if(a == 74 && b == 32)
		{
			return 106;
		}
		else if(a == 74 && b == 33)
		{
			return 107;
		}
		else if(a == 74 && b == 34)
		{
			return 108;
		}
		else if(a == 74 && b == 35)
		{
			return 109;
		}
		else if(a == 74 && b == 36)
		{
			return 110;
		}
		else if(a == 74 && b == 37)
		{
			return 111;
		}
		else if(a == 74 && b == 38)
		{
			return 112;
		}
		else if(a == 74 && b == 39)
		{
			return 113;
		}
		else if(a == 74 && b == 40)
		{
			return 114;
		}
		else if(a == 74 && b == 41)
		{
			return 115;
		}
		else if(a == 74 && b == 42)
		{
			return 116;
		}
		else if(a == 74 && b == 43)
		{
			return 117;
		}
		else if(a == 74 && b == 44)
		{
			return 118;
		}
		else if(a == 74 && b == 45)
		{
			return 119;
		}
		else if(a == 74 && b == 46)
		{
			return 120;
		}
		else if(a == 74 && b == 47)
		{
			return 121;
		}
		else if(a == 74 && b == 48)
		{
			return 122;
		}
		else if(a == 74 && b == 49)
		{
			return 123;
		}
		else if(a == 74 && b == 50)
		{
			return 124;
		}
		else if(a == 74 && b == 51)
		{
			return 125;
		}
		else if(a == 74 && b == 52)
		{
			return 126;
		}
		else if(a == 74 && b == 53)
		{
			return 127;
		}
		else if(a == 74 && b == 54)
		{
			return 128;
		}
		else if(a == 74 && b == 55)
		{
			return 129;
		}
		else if(a == 74 && b == 56)
		{
			return 130;
		}
		else if(a == 74 && b == 57)
		{
			return 131;
		}
		else if(a == 74 && b == 58)
		{
			return 132;
		}
		else if(a == 74 && b == 59)
		{
			return 133;
		}
		else if(a == 74 && b == 60)
		{
			return 134;
		}
		else if(a == 74 && b == 61)
		{
			return 135;
		}
		else if(a == 74 && b == 62)
		{
			return 136;
		}
		else if(a == 74 && b == 63)
		{
			return 137;
		}
		else if(a == 74 && b == 64)
		{
			return 138;
		}
		else if(a == 74 && b == 65)
		{
			return 139;
		}
		else if(a == 74 && b == 66)
		{
			return 140;
		}
		else if(a == 74 && b == 67)
		{
			return 141;
		}
		else if(a == 74 && b == 68)
		{
			return 142;
		}
		else if(a == 74 && b == 69)
		{
			return 143;
		}
		else if(a == 74 && b == 70)
		{
			return 144;
		}
		else if(a == 74 && b == 71)
		{
			return 145;
		}
		else if(a == 74 && b == 72)
		{
			return 146;
		}
		else if(a == 74 && b == 73)
		{
			return 147;
		}
		else if(a == 74 && b == 74)
		{
			return 148;
		}
		else if(a == 74 && b == 75)
		{
			return 149;
		}
		else if(a == 74 && b == 76)
		{
			return 150;
		}
		else if(a == 74 && b == 77)
		{
			return 151;
		}
		else if(a == 74 && b == 78)
		{
			return 152;
		}
		else if(a == 74 && b == 79)
		{
			return 153;
		}
		else if(a == 74 && b == 80)
		{
			return 154;
		}
		else if(a == 74 && b == 81)
		{
			return 155;
		}
		else if(a == 74 && b == 82)
		{
			return 156;
		}
		else if(a == 74 && b == 83)
		{
			return 157;
		}
		else if(a == 74 && b == 84)
		{
			return 158;
		}
		else if(a == 74 && b == 85)
		{
			return 159;
		}
		else if(a == 74 && b == 86)
		{
			return 160;
		}
		else if(a == 74 && b == 87)
		{
			return 161;
		}
		else if(a == 74 && b == 88)
		{
			return 162;
		}
		else if(a == 74 && b == 89)
		{
			return 163;
		}
		else if(a == 74 && b == 90)
		{
			return 164;
		}
		else if(a == 74 && b == 91)
		{
			return 165;
		}
		else if(a == 74 && b == 92)
		{
			return 166;
		}
		else if(a == 74 && b == 93)
		{
			return 167;
		}
		else if(a == 74 && b == 94)
		{
			return 168;
		}
		else if(a == 74 && b == 95)
		{
			return 169;
		}
		else if(a == 74 && b == 96)
		{
			return 170;
		}
		else if(a == 74 && b == 97)
		{
			return 171;
		}
		else if(a == 74 && b == 98)
		{
			return 172;
		}
		else if(a == 74 && b == 99)
		{
			return 173;
		}
		else if(a == 74 && b == 100)
		{
			return 174;
		}
		else if(a == 75 && b == 0)
		{
			return 75;
		}
		else if(a == 75 && b == 1)
		{
			return 76;
		}
		else if(a == 75 && b == 2)
		{
			return 77;
		}
		else if(a == 75 && b == 3)
		{
			return 78;
		}
		else if(a == 75 && b == 4)
		{
			return 79;
		}
		else if(a == 75 && b == 5)
		{
			return 80;
		}
		else if(a == 75 && b == 6)
		{
			return 81;
		}
		else if(a == 75 && b == 7)
		{
			return 82;
		}
		else if(a == 75 && b == 8)
		{
			return 83;
		}
		else if(a == 75 && b == 9)
		{
			return 84;
		}
		else if(a == 75 && b == 10)
		{
			return 85;
		}
		else if(a == 75 && b == 11)
		{
			return 86;
		}
		else if(a == 75 && b == 12)
		{
			return 87;
		}
		else if(a == 75 && b == 13)
		{
			return 88;
		}
		else if(a == 75 && b == 14)
		{
			return 89;
		}
		else if(a == 75 && b == 15)
		{
			return 90;
		}
		else if(a == 75 && b == 16)
		{
			return 91;
		}
		else if(a == 75 && b == 17)
		{
			return 92;
		}
		else if(a == 75 && b == 18)
		{
			return 93;
		}
		else if(a == 75 && b == 19)
		{
			return 94;
		}
		else if(a == 75 && b == 20)
		{
			return 95;
		}
		else if(a == 75 && b == 21)
		{
			return 96;
		}
		else if(a == 75 && b == 22)
		{
			return 97;
		}
		else if(a == 75 && b == 23)
		{
			return 98;
		}
		else if(a == 75 && b == 24)
		{
			return 99;
		}
		else if(a == 75 && b == 25)
		{
			return 100;
		}
		else if(a == 75 && b == 26)
		{
			return 101;
		}
		else if(a == 75 && b == 27)
		{
			return 102;
		}
		else if(a == 75 && b == 28)
		{
			return 103;
		}
		else if(a == 75 && b == 29)
		{
			return 104;
		}
		else if(a == 75 && b == 30)
		{
			return 105;
		}
		else if(a == 75 && b == 31)
		{
			return 106;
		}
		else if(a == 75 && b == 32)
		{
			return 107;
		}
		else if(a == 75 && b == 33)
		{
			return 108;
		}
		else if(a == 75 && b == 34)
		{
			return 109;
		}
		else if(a == 75 && b == 35)
		{
			return 110;
		}
		else if(a == 75 && b == 36)
		{
			return 111;
		}
		else if(a == 75 && b == 37)
		{
			return 112;
		}
		else if(a == 75 && b == 38)
		{
			return 113;
		}
		else if(a == 75 && b == 39)
		{
			return 114;
		}
		else if(a == 75 && b == 40)
		{
			return 115;
		}
		else if(a == 75 && b == 41)
		{
			return 116;
		}
		else if(a == 75 && b == 42)
		{
			return 117;
		}
		else if(a == 75 && b == 43)
		{
			return 118;
		}
		else if(a == 75 && b == 44)
		{
			return 119;
		}
		else if(a == 75 && b == 45)
		{
			return 120;
		}
		else if(a == 75 && b == 46)
		{
			return 121;
		}
		else if(a == 75 && b == 47)
		{
			return 122;
		}
		else if(a == 75 && b == 48)
		{
			return 123;
		}
		else if(a == 75 && b == 49)
		{
			return 124;
		}
		else if(a == 75 && b == 50)
		{
			return 125;
		}
		else if(a == 75 && b == 51)
		{
			return 126;
		}
		else if(a == 75 && b == 52)
		{
			return 127;
		}
		else if(a == 75 && b == 53)
		{
			return 128;
		}
		else if(a == 75 && b == 54)
		{
			return 129;
		}
		else if(a == 75 && b == 55)
		{
			return 130;
		}
		else if(a == 75 && b == 56)
		{
			return 131;
		}
		else if(a == 75 && b == 57)
		{
			return 132;
		}
		else if(a == 75 && b == 58)
		{
			return 133;
		}
		else if(a == 75 && b == 59)
		{
			return 134;
		}
		else if(a == 75 && b == 60)
		{
			return 135;
		}
		else if(a == 75 && b == 61)
		{
			return 136;
		}
		else if(a == 75 && b == 62)
		{
			return 137;
		}
		else if(a == 75 && b == 63)
		{
			return 138;
		}
		else if(a == 75 && b == 64)
		{
			return 139;
		}
		else if(a == 75 && b == 65)
		{
			return 140;
		}
		else if(a == 75 && b == 66)
		{
			return 141;
		}
		else if(a == 75 && b == 67)
		{
			return 142;
		}
		else if(a == 75 && b == 68)
		{
			return 143;
		}
		else if(a == 75 && b == 69)
		{
			return 144;
		}
		else if(a == 75 && b == 70)
		{
			return 145;
		}
		else if(a == 75 && b == 71)
		{
			return 146;
		}
		else if(a == 75 && b == 72)
		{
			return 147;
		}
		else if(a == 75 && b == 73)
		{
			return 148;
		}
		else if(a == 75 && b == 74)
		{
			return 149;
		}
		else if(a == 75 && b == 75)
		{
			return 150;
		}
		else if(a == 75 && b == 76)
		{
			return 151;
		}
		else if(a == 75 && b == 77)
		{
			return 152;
		}
		else if(a == 75 && b == 78)
		{
			return 153;
		}
		else if(a == 75 && b == 79)
		{
			return 154;
		}
		else if(a == 75 && b == 80)
		{
			return 155;
		}
		else if(a == 75 && b == 81)
		{
			return 156;
		}
		else if(a == 75 && b == 82)
		{
			return 157;
		}
		else if(a == 75 && b == 83)
		{
			return 158;
		}
		else if(a == 75 && b == 84)
		{
			return 159;
		}
		else if(a == 75 && b == 85)
		{
			return 160;
		}
		else if(a == 75 && b == 86)
		{
			return 161;
		}
		else if(a == 75 && b == 87)
		{
			return 162;
		}
		else if(a == 75 && b == 88)
		{
			return 163;
		}
		else if(a == 75 && b == 89)
		{
			return 164;
		}
		else if(a == 75 && b == 90)
		{
			return 165;
		}
		else if(a == 75 && b == 91)
		{
			return 166;
		}
		else if(a == 75 && b == 92)
		{
			return 167;
		}
		else if(a == 75 && b == 93)
		{
			return 168;
		}
		else if(a == 75 && b == 94)
		{
			return 169;
		}
		else if(a == 75 && b == 95)
		{
			return 170;
		}
		else if(a == 75 && b == 96)
		{
			return 171;
		}
		else if(a == 75 && b == 97)
		{
			return 172;
		}
		else if(a == 75 && b == 98)
		{
			return 173;
		}
		else if(a == 75 && b == 99)
		{
			return 174;
		}
		else if(a == 75 && b == 100)
		{
			return 175;
		}
		else if(a == 76 && b == 0)
		{
			return 76;
		}
		else if(a == 76 && b == 1)
		{
			return 77;
		}
		else if(a == 76 && b == 2)
		{
			return 78;
		}
		else if(a == 76 && b == 3)
		{
			return 79;
		}
		else if(a == 76 && b == 4)
		{
			return 80;
		}
		else if(a == 76 && b == 5)
		{
			return 81;
		}
		else if(a == 76 && b == 6)
		{
			return 82;
		}
		else if(a == 76 && b == 7)
		{
			return 83;
		}
		else if(a == 76 && b == 8)
		{
			return 84;
		}
		else if(a == 76 && b == 9)
		{
			return 85;
		}
		else if(a == 76 && b == 10)
		{
			return 86;
		}
		else if(a == 76 && b == 11)
		{
			return 87;
		}
		else if(a == 76 && b == 12)
		{
			return 88;
		}
		else if(a == 76 && b == 13)
		{
			return 89;
		}
		else if(a == 76 && b == 14)
		{
			return 90;
		}
		else if(a == 76 && b == 15)
		{
			return 91;
		}
		else if(a == 76 && b == 16)
		{
			return 92;
		}
		else if(a == 76 && b == 17)
		{
			return 93;
		}
		else if(a == 76 && b == 18)
		{
			return 94;
		}
		else if(a == 76 && b == 19)
		{
			return 95;
		}
		else if(a == 76 && b == 20)
		{
			return 96;
		}
		else if(a == 76 && b == 21)
		{
			return 97;
		}
		else if(a == 76 && b == 22)
		{
			return 98;
		}
		else if(a == 76 && b == 23)
		{
			return 99;
		}
		else if(a == 76 && b == 24)
		{
			return 100;
		}
		else if(a == 76 && b == 25)
		{
			return 101;
		}
		else if(a == 76 && b == 26)
		{
			return 102;
		}
		else if(a == 76 && b == 27)
		{
			return 103;
		}
		else if(a == 76 && b == 28)
		{
			return 104;
		}
		else if(a == 76 && b == 29)
		{
			return 105;
		}
		else if(a == 76 && b == 30)
		{
			return 106;
		}
		else if(a == 76 && b == 31)
		{
			return 107;
		}
		else if(a == 76 && b == 32)
		{
			return 108;
		}
		else if(a == 76 && b == 33)
		{
			return 109;
		}
		else if(a == 76 && b == 34)
		{
			return 110;
		}
		else if(a == 76 && b == 35)
		{
			return 111;
		}
		else if(a == 76 && b == 36)
		{
			return 112;
		}
		else if(a == 76 && b == 37)
		{
			return 113;
		}
		else if(a == 76 && b == 38)
		{
			return 114;
		}
		else if(a == 76 && b == 39)
		{
			return 115;
		}
		else if(a == 76 && b == 40)
		{
			return 116;
		}
		else if(a == 76 && b == 41)
		{
			return 117;
		}
		else if(a == 76 && b == 42)
		{
			return 118;
		}
		else if(a == 76 && b == 43)
		{
			return 119;
		}
		else if(a == 76 && b == 44)
		{
			return 120;
		}
		else if(a == 76 && b == 45)
		{
			return 121;
		}
		else if(a == 76 && b == 46)
		{
			return 122;
		}
		else if(a == 76 && b == 47)
		{
			return 123;
		}
		else if(a == 76 && b == 48)
		{
			return 124;
		}
		else if(a == 76 && b == 49)
		{
			return 125;
		}
		else if(a == 76 && b == 50)
		{
			return 126;
		}
		else if(a == 76 && b == 51)
		{
			return 127;
		}
		else if(a == 76 && b == 52)
		{
			return 128;
		}
		else if(a == 76 && b == 53)
		{
			return 129;
		}
		else if(a == 76 && b == 54)
		{
			return 130;
		}
		else if(a == 76 && b == 55)
		{
			return 131;
		}
		else if(a == 76 && b == 56)
		{
			return 132;
		}
		else if(a == 76 && b == 57)
		{
			return 133;
		}
		else if(a == 76 && b == 58)
		{
			return 134;
		}
		else if(a == 76 && b == 59)
		{
			return 135;
		}
		else if(a == 76 && b == 60)
		{
			return 136;
		}
		else if(a == 76 && b == 61)
		{
			return 137;
		}
		else if(a == 76 && b == 62)
		{
			return 138;
		}
		else if(a == 76 && b == 63)
		{
			return 139;
		}
		else if(a == 76 && b == 64)
		{
			return 140;
		}
		else if(a == 76 && b == 65)
		{
			return 141;
		}
		else if(a == 76 && b == 66)
		{
			return 142;
		}
		else if(a == 76 && b == 67)
		{
			return 143;
		}
		else if(a == 76 && b == 68)
		{
			return 144;
		}
		else if(a == 76 && b == 69)
		{
			return 145;
		}
		else if(a == 76 && b == 70)
		{
			return 146;
		}
		else if(a == 76 && b == 71)
		{
			return 147;
		}
		else if(a == 76 && b == 72)
		{
			return 148;
		}
		else if(a == 76 && b == 73)
		{
			return 149;
		}
		else if(a == 76 && b == 74)
		{
			return 150;
		}
		else if(a == 76 && b == 75)
		{
			return 151;
		}
		else if(a == 76 && b == 76)
		{
			return 152;
		}
		else if(a == 76 && b == 77)
		{
			return 153;
		}
		else if(a == 76 && b == 78)
		{
			return 154;
		}
		else if(a == 76 && b == 79)
		{
			return 155;
		}
		else if(a == 76 && b == 80)
		{
			return 156;
		}
		else if(a == 76 && b == 81)
		{
			return 157;
		}
		else if(a == 76 && b == 82)
		{
			return 158;
		}
		else if(a == 76 && b == 83)
		{
			return 159;
		}
		else if(a == 76 && b == 84)
		{
			return 160;
		}
		else if(a == 76 && b == 85)
		{
			return 161;
		}
		else if(a == 76 && b == 86)
		{
			return 162;
		}
		else if(a == 76 && b == 87)
		{
			return 163;
		}
		else if(a == 76 && b == 88)
		{
			return 164;
		}
		else if(a == 76 && b == 89)
		{
			return 165;
		}
		else if(a == 76 && b == 90)
		{
			return 166;
		}
		else if(a == 76 && b == 91)
		{
			return 167;
		}
		else if(a == 76 && b == 92)
		{
			return 168;
		}
		else if(a == 76 && b == 93)
		{
			return 169;
		}
		else if(a == 76 && b == 94)
		{
			return 170;
		}
		else if(a == 76 && b == 95)
		{
			return 171;
		}
		else if(a == 76 && b == 96)
		{
			return 172;
		}
		else if(a == 76 && b == 97)
		{
			return 173;
		}
		else if(a == 76 && b == 98)
		{
			return 174;
		}
		else if(a == 76 && b == 99)
		{
			return 175;
		}
		else if(a == 76 && b == 100)
		{
			return 176;
		}
		else if(a == 77 && b == 0)
		{
			return 77;
		}
		else if(a == 77 && b == 1)
		{
			return 78;
		}
		else if(a == 77 && b == 2)
		{
			return 79;
		}
		else if(a == 77 && b == 3)
		{
			return 80;
		}
		else if(a == 77 && b == 4)
		{
			return 81;
		}
		else if(a == 77 && b == 5)
		{
			return 82;
		}
		else if(a == 77 && b == 6)
		{
			return 83;
		}
		else if(a == 77 && b == 7)
		{
			return 84;
		}
		else if(a == 77 && b == 8)
		{
			return 85;
		}
		else if(a == 77 && b == 9)
		{
			return 86;
		}
		else if(a == 77 && b == 10)
		{
			return 87;
		}
		else if(a == 77 && b == 11)
		{
			return 88;
		}
		else if(a == 77 && b == 12)
		{
			return 89;
		}
		else if(a == 77 && b == 13)
		{
			return 90;
		}
		else if(a == 77 && b == 14)
		{
			return 91;
		}
		else if(a == 77 && b == 15)
		{
			return 92;
		}
		else if(a == 77 && b == 16)
		{
			return 93;
		}
		else if(a == 77 && b == 17)
		{
			return 94;
		}
		else if(a == 77 && b == 18)
		{
			return 95;
		}
		else if(a == 77 && b == 19)
		{
			return 96;
		}
		else if(a == 77 && b == 20)
		{
			return 97;
		}
		else if(a == 77 && b == 21)
		{
			return 98;
		}
		else if(a == 77 && b == 22)
		{
			return 99;
		}
		else if(a == 77 && b == 23)
		{
			return 100;
		}
		else if(a == 77 && b == 24)
		{
			return 101;
		}
		else if(a == 77 && b == 25)
		{
			return 102;
		}
		else if(a == 77 && b == 26)
		{
			return 103;
		}
		else if(a == 77 && b == 27)
		{
			return 104;
		}
		else if(a == 77 && b == 28)
		{
			return 105;
		}
		else if(a == 77 && b == 29)
		{
			return 106;
		}
		else if(a == 77 && b == 30)
		{
			return 107;
		}
		else if(a == 77 && b == 31)
		{
			return 108;
		}
		else if(a == 77 && b == 32)
		{
			return 109;
		}
		else if(a == 77 && b == 33)
		{
			return 110;
		}
		else if(a == 77 && b == 34)
		{
			return 111;
		}
		else if(a == 77 && b == 35)
		{
			return 112;
		}
		else if(a == 77 && b == 36)
		{
			return 113;
		}
		else if(a == 77 && b == 37)
		{
			return 114;
		}
		else if(a == 77 && b == 38)
		{
			return 115;
		}
		else if(a == 77 && b == 39)
		{
			return 116;
		}
		else if(a == 77 && b == 40)
		{
			return 117;
		}
		else if(a == 77 && b == 41)
		{
			return 118;
		}
		else if(a == 77 && b == 42)
		{
			return 119;
		}
		else if(a == 77 && b == 43)
		{
			return 120;
		}
		else if(a == 77 && b == 44)
		{
			return 121;
		}
		else if(a == 77 && b == 45)
		{
			return 122;
		}
		else if(a == 77 && b == 46)
		{
			return 123;
		}
		else if(a == 77 && b == 47)
		{
			return 124;
		}
		else if(a == 77 && b == 48)
		{
			return 125;
		}
		else if(a == 77 && b == 49)
		{
			return 126;
		}
		else if(a == 77 && b == 50)
		{
			return 127;
		}
		else if(a == 77 && b == 51)
		{
			return 128;
		}
		else if(a == 77 && b == 52)
		{
			return 129;
		}
		else if(a == 77 && b == 53)
		{
			return 130;
		}
		else if(a == 77 && b == 54)
		{
			return 131;
		}
		else if(a == 77 && b == 55)
		{
			return 132;
		}
		else if(a == 77 && b == 56)
		{
			return 133;
		}
		else if(a == 77 && b == 57)
		{
			return 134;
		}
		else if(a == 77 && b == 58)
		{
			return 135;
		}
		else if(a == 77 && b == 59)
		{
			return 136;
		}
		else if(a == 77 && b == 60)
		{
			return 137;
		}
		else if(a == 77 && b == 61)
		{
			return 138;
		}
		else if(a == 77 && b == 62)
		{
			return 139;
		}
		else if(a == 77 && b == 63)
		{
			return 140;
		}
		else if(a == 77 && b == 64)
		{
			return 141;
		}
		else if(a == 77 && b == 65)
		{
			return 142;
		}
		else if(a == 77 && b == 66)
		{
			return 143;
		}
		else if(a == 77 && b == 67)
		{
			return 144;
		}
		else if(a == 77 && b == 68)
		{
			return 145;
		}
		else if(a == 77 && b == 69)
		{
			return 146;
		}
		else if(a == 77 && b == 70)
		{
			return 147;
		}
		else if(a == 77 && b == 71)
		{
			return 148;
		}
		else if(a == 77 && b == 72)
		{
			return 149;
		}
		else if(a == 77 && b == 73)
		{
			return 150;
		}
		else if(a == 77 && b == 74)
		{
			return 151;
		}
		else if(a == 77 && b == 75)
		{
			return 152;
		}
		else if(a == 77 && b == 76)
		{
			return 153;
		}
		else if(a == 77 && b == 77)
		{
			return 154;
		}
		else if(a == 77 && b == 78)
		{
			return 155;
		}
		else if(a == 77 && b == 79)
		{
			return 156;
		}
		else if(a == 77 && b == 80)
		{
			return 157;
		}
		else if(a == 77 && b == 81)
		{
			return 158;
		}
		else if(a == 77 && b == 82)
		{
			return 159;
		}
		else if(a == 77 && b == 83)
		{
			return 160;
		}
		else if(a == 77 && b == 84)
		{
			return 161;
		}
		else if(a == 77 && b == 85)
		{
			return 162;
		}
		else if(a == 77 && b == 86)
		{
			return 163;
		}
		else if(a == 77 && b == 87)
		{
			return 164;
		}
		else if(a == 77 && b == 88)
		{
			return 165;
		}
		else if(a == 77 && b == 89)
		{
			return 166;
		}
		else if(a == 77 && b == 90)
		{
			return 167;
		}
		else if(a == 77 && b == 91)
		{
			return 168;
		}
		else if(a == 77 && b == 92)
		{
			return 169;
		}
		else if(a == 77 && b == 93)
		{
			return 170;
		}
		else if(a == 77 && b == 94)
		{
			return 171;
		}
		else if(a == 77 && b == 95)
		{
			return 172;
		}
		else if(a == 77 && b == 96)
		{
			return 173;
		}
		else if(a == 77 && b == 97)
		{
			return 174;
		}
		else if(a == 77 && b == 98)
		{
			return 175;
		}
		else if(a == 77 && b == 99)
		{
			return 176;
		}
		else if(a == 77 && b == 100)
		{
			return 177;
		}
		else if(a == 78 && b == 0)
		{
			return 78;
		}
		else if(a == 78 && b == 1)
		{
			return 79;
		}
		else if(a == 78 && b == 2)
		{
			return 80;
		}
		else if(a == 78 && b == 3)
		{
			return 81;
		}
		else if(a == 78 && b == 4)
		{
			return 82;
		}
		else if(a == 78 && b == 5)
		{
			return 83;
		}
		else if(a == 78 && b == 6)
		{
			return 84;
		}
		else if(a == 78 && b == 7)
		{
			return 85;
		}
		else if(a == 78 && b == 8)
		{
			return 86;
		}
		else if(a == 78 && b == 9)
		{
			return 87;
		}
		else if(a == 78 && b == 10)
		{
			return 88;
		}
		else if(a == 78 && b == 11)
		{
			return 89;
		}
		else if(a == 78 && b == 12)
		{
			return 90;
		}
		else if(a == 78 && b == 13)
		{
			return 91;
		}
		else if(a == 78 && b == 14)
		{
			return 92;
		}
		else if(a == 78 && b == 15)
		{
			return 93;
		}
		else if(a == 78 && b == 16)
		{
			return 94;
		}
		else if(a == 78 && b == 17)
		{
			return 95;
		}
		else if(a == 78 && b == 18)
		{
			return 96;
		}
		else if(a == 78 && b == 19)
		{
			return 97;
		}
		else if(a == 78 && b == 20)
		{
			return 98;
		}
		else if(a == 78 && b == 21)
		{
			return 99;
		}
		else if(a == 78 && b == 22)
		{
			return 100;
		}
		else if(a == 78 && b == 23)
		{
			return 101;
		}
		else if(a == 78 && b == 24)
		{
			return 102;
		}
		else if(a == 78 && b == 25)
		{
			return 103;
		}
		else if(a == 78 && b == 26)
		{
			return 104;
		}
		else if(a == 78 && b == 27)
		{
			return 105;
		}
		else if(a == 78 && b == 28)
		{
			return 106;
		}
		else if(a == 78 && b == 29)
		{
			return 107;
		}
		else if(a == 78 && b == 30)
		{
			return 108;
		}
		else if(a == 78 && b == 31)
		{
			return 109;
		}
		else if(a == 78 && b == 32)
		{
			return 110;
		}
		else if(a == 78 && b == 33)
		{
			return 111;
		}
		else if(a == 78 && b == 34)
		{
			return 112;
		}
		else if(a == 78 && b == 35)
		{
			return 113;
		}
		else if(a == 78 && b == 36)
		{
			return 114;
		}
		else if(a == 78 && b == 37)
		{
			return 115;
		}
		else if(a == 78 && b == 38)
		{
			return 116;
		}
		else if(a == 78 && b == 39)
		{
			return 117;
		}
		else if(a == 78 && b == 40)
		{
			return 118;
		}
		else if(a == 78 && b == 41)
		{
			return 119;
		}
		else if(a == 78 && b == 42)
		{
			return 120;
		}
		else if(a == 78 && b == 43)
		{
			return 121;
		}
		else if(a == 78 && b == 44)
		{
			return 122;
		}
		else if(a == 78 && b == 45)
		{
			return 123;
		}
		else if(a == 78 && b == 46)
		{
			return 124;
		}
		else if(a == 78 && b == 47)
		{
			return 125;
		}
		else if(a == 78 && b == 48)
		{
			return 126;
		}
		else if(a == 78 && b == 49)
		{
			return 127;
		}
		else if(a == 78 && b == 50)
		{
			return 128;
		}
		else if(a == 78 && b == 51)
		{
			return 129;
		}
		else if(a == 78 && b == 52)
		{
			return 130;
		}
		else if(a == 78 && b == 53)
		{
			return 131;
		}
		else if(a == 78 && b == 54)
		{
			return 132;
		}
		else if(a == 78 && b == 55)
		{
			return 133;
		}
		else if(a == 78 && b == 56)
		{
			return 134;
		}
		else if(a == 78 && b == 57)
		{
			return 135;
		}
		else if(a == 78 && b == 58)
		{
			return 136;
		}
		else if(a == 78 && b == 59)
		{
			return 137;
		}
		else if(a == 78 && b == 60)
		{
			return 138;
		}
		else if(a == 78 && b == 61)
		{
			return 139;
		}
		else if(a == 78 && b == 62)
		{
			return 140;
		}
		else if(a == 78 && b == 63)
		{
			return 141;
		}
		else if(a == 78 && b == 64)
		{
			return 142;
		}
		else if(a == 78 && b == 65)
		{
			return 143;
		}
		else if(a == 78 && b == 66)
		{
			return 144;
		}
		else if(a == 78 && b == 67)
		{
			return 145;
		}
		else if(a == 78 && b == 68)
		{
			return 146;
		}
		else if(a == 78 && b == 69)
		{
			return 147;
		}
		else if(a == 78 && b == 70)
		{
			return 148;
		}
		else if(a == 78 && b == 71)
		{
			return 149;
		}
		else if(a == 78 && b == 72)
		{
			return 150;
		}
		else if(a == 78 && b == 73)
		{
			return 151;
		}
		else if(a == 78 && b == 74)
		{
			return 152;
		}
		else if(a == 78 && b == 75)
		{
			return 153;
		}
		else if(a == 78 && b == 76)
		{
			return 154;
		}
		else if(a == 78 && b == 77)
		{
			return 155;
		}
		else if(a == 78 && b == 78)
		{
			return 156;
		}
		else if(a == 78 && b == 79)
		{
			return 157;
		}
		else if(a == 78 && b == 80)
		{
			return 158;
		}
		else if(a == 78 && b == 81)
		{
			return 159;
		}
		else if(a == 78 && b == 82)
		{
			return 160;
		}
		else if(a == 78 && b == 83)
		{
			return 161;
		}
		else if(a == 78 && b == 84)
		{
			return 162;
		}
		else if(a == 78 && b == 85)
		{
			return 163;
		}
		else if(a == 78 && b == 86)
		{
			return 164;
		}
		else if(a == 78 && b == 87)
		{
			return 165;
		}
		else if(a == 78 && b == 88)
		{
			return 166;
		}
		else if(a == 78 && b == 89)
		{
			return 167;
		}
		else if(a == 78 && b == 90)
		{
			return 168;
		}
		else if(a == 78 && b == 91)
		{
			return 169;
		}
		else if(a == 78 && b == 92)
		{
			return 170;
		}
		else if(a == 78 && b == 93)
		{
			return 171;
		}
		else if(a == 78 && b == 94)
		{
			return 172;
		}
		else if(a == 78 && b == 95)
		{
			return 173;
		}
		else if(a == 78 && b == 96)
		{
			return 174;
		}
		else if(a == 78 && b == 97)
		{
			return 175;
		}
		else if(a == 78 && b == 98)
		{
			return 176;
		}
		else if(a == 78 && b == 99)
		{
			return 177;
		}
		else if(a == 78 && b == 100)
		{
			return 178;
		}
		else if(a == 79 && b == 0)
		{
			return 79;
		}
		else if(a == 79 && b == 1)
		{
			return 80;
		}
		else if(a == 79 && b == 2)
		{
			return 81;
		}
		else if(a == 79 && b == 3)
		{
			return 82;
		}
		else if(a == 79 && b == 4)
		{
			return 83;
		}
		else if(a == 79 && b == 5)
		{
			return 84;
		}
		else if(a == 79 && b == 6)
		{
			return 85;
		}
		else if(a == 79 && b == 7)
		{
			return 86;
		}
		else if(a == 79 && b == 8)
		{
			return 87;
		}
		else if(a == 79 && b == 9)
		{
			return 88;
		}
		else if(a == 79 && b == 10)
		{
			return 89;
		}
		else if(a == 79 && b == 11)
		{
			return 90;
		}
		else if(a == 79 && b == 12)
		{
			return 91;
		}
		else if(a == 79 && b == 13)
		{
			return 92;
		}
		else if(a == 79 && b == 14)
		{
			return 93;
		}
		else if(a == 79 && b == 15)
		{
			return 94;
		}
		else if(a == 79 && b == 16)
		{
			return 95;
		}
		else if(a == 79 && b == 17)
		{
			return 96;
		}
		else if(a == 79 && b == 18)
		{
			return 97;
		}
		else if(a == 79 && b == 19)
		{
			return 98;
		}
		else if(a == 79 && b == 20)
		{
			return 99;
		}
		else if(a == 79 && b == 21)
		{
			return 100;
		}
		else if(a == 79 && b == 22)
		{
			return 101;
		}
		else if(a == 79 && b == 23)
		{
			return 102;
		}
		else if(a == 79 && b == 24)
		{
			return 103;
		}
		else if(a == 79 && b == 25)
		{
			return 104;
		}
		else if(a == 79 && b == 26)
		{
			return 105;
		}
		else if(a == 79 && b == 27)
		{
			return 106;
		}
		else if(a == 79 && b == 28)
		{
			return 107;
		}
		else if(a == 79 && b == 29)
		{
			return 108;
		}
		else if(a == 79 && b == 30)
		{
			return 109;
		}
		else if(a == 79 && b == 31)
		{
			return 110;
		}
		else if(a == 79 && b == 32)
		{
			return 111;
		}
		else if(a == 79 && b == 33)
		{
			return 112;
		}
		else if(a == 79 && b == 34)
		{
			return 113;
		}
		else if(a == 79 && b == 35)
		{
			return 114;
		}
		else if(a == 79 && b == 36)
		{
			return 115;
		}
		else if(a == 79 && b == 37)
		{
			return 116;
		}
		else if(a == 79 && b == 38)
		{
			return 117;
		}
		else if(a == 79 && b == 39)
		{
			return 118;
		}
		else if(a == 79 && b == 40)
		{
			return 119;
		}
		else if(a == 79 && b == 41)
		{
			return 120;
		}
		else if(a == 79 && b == 42)
		{
			return 121;
		}
		else if(a == 79 && b == 43)
		{
			return 122;
		}
		else if(a == 79 && b == 44)
		{
			return 123;
		}
		else if(a == 79 && b == 45)
		{
			return 124;
		}
		else if(a == 79 && b == 46)
		{
			return 125;
		}
		else if(a == 79 && b == 47)
		{
			return 126;
		}
		else if(a == 79 && b == 48)
		{
			return 127;
		}
		else if(a == 79 && b == 49)
		{
			return 128;
		}
		else if(a == 79 && b == 50)
		{
			return 129;
		}
		else if(a == 79 && b == 51)
		{
			return 130;
		}
		else if(a == 79 && b == 52)
		{
			return 131;
		}
		else if(a == 79 && b == 53)
		{
			return 132;
		}
		else if(a == 79 && b == 54)
		{
			return 133;
		}
		else if(a == 79 && b == 55)
		{
			return 134;
		}
		else if(a == 79 && b == 56)
		{
			return 135;
		}
		else if(a == 79 && b == 57)
		{
			return 136;
		}
		else if(a == 79 && b == 58)
		{
			return 137;
		}
		else if(a == 79 && b == 59)
		{
			return 138;
		}
		else if(a == 79 && b == 60)
		{
			return 139;
		}
		else if(a == 79 && b == 61)
		{
			return 140;
		}
		else if(a == 79 && b == 62)
		{
			return 141;
		}
		else if(a == 79 && b == 63)
		{
			return 142;
		}
		else if(a == 79 && b == 64)
		{
			return 143;
		}
		else if(a == 79 && b == 65)
		{
			return 144;
		}
		else if(a == 79 && b == 66)
		{
			return 145;
		}
		else if(a == 79 && b == 67)
		{
			return 146;
		}
		else if(a == 79 && b == 68)
		{
			return 147;
		}
		else if(a == 79 && b == 69)
		{
			return 148;
		}
		else if(a == 79 && b == 70)
		{
			return 149;
		}
		else if(a == 79 && b == 71)
		{
			return 150;
		}
		else if(a == 79 && b == 72)
		{
			return 151;
		}
		else if(a == 79 && b == 73)
		{
			return 152;
		}
		else if(a == 79 && b == 74)
		{
			return 153;
		}
		else if(a == 79 && b == 75)
		{
			return 154;
		}
		else if(a == 79 && b == 76)
		{
			return 155;
		}
		else if(a == 79 && b == 77)
		{
			return 156;
		}
		else if(a == 79 && b == 78)
		{
			return 157;
		}
		else if(a == 79 && b == 79)
		{
			return 158;
		}
		else if(a == 79 && b == 80)
		{
			return 159;
		}
		else if(a == 79 && b == 81)
		{
			return 160;
		}
		else if(a == 79 && b == 82)
		{
			return 161;
		}
		else if(a == 79 && b == 83)
		{
			return 162;
		}
		else if(a == 79 && b == 84)
		{
			return 163;
		}
		else if(a == 79 && b == 85)
		{
			return 164;
		}
		else if(a == 79 && b == 86)
		{
			return 165;
		}
		else if(a == 79 && b == 87)
		{
			return 166;
		}
		else if(a == 79 && b == 88)
		{
			return 167;
		}
		else if(a == 79 && b == 89)
		{
			return 168;
		}
		else if(a == 79 && b == 90)
		{
			return 169;
		}
		else if(a == 79 && b == 91)
		{
			return 170;
		}
		else if(a == 79 && b == 92)
		{
			return 171;
		}
		else if(a == 79 && b == 93)
		{
			return 172;
		}
		else if(a == 79 && b == 94)
		{
			return 173;
		}
		else if(a == 79 && b == 95)
		{
			return 174;
		}
		else if(a == 79 && b == 96)
		{
			return 175;
		}
		else if(a == 79 && b == 97)
		{
			return 176;
		}
		else if(a == 79 && b == 98)
		{
			return 177;
		}
		else if(a == 79 && b == 99)
		{
			return 178;
		}
		else if(a == 79 && b == 100)
		{
			return 179;
		}
		else if(a == 80 && b == 0)
		{
			return 80;
		}
		else if(a == 80 && b == 1)
		{
			return 81;
		}
		else if(a == 80 && b == 2)
		{
			return 82;
		}
		else if(a == 80 && b == 3)
		{
			return 83;
		}
		else if(a == 80 && b == 4)
		{
			return 84;
		}
		else if(a == 80 && b == 5)
		{
			return 85;
		}
		else if(a == 80 && b == 6)
		{
			return 86;
		}
		else if(a == 80 && b == 7)
		{
			return 87;
		}
		else if(a == 80 && b == 8)
		{
			return 88;
		}
		else if(a == 80 && b == 9)
		{
			return 89;
		}
		else if(a == 80 && b == 10)
		{
			return 90;
		}
		else if(a == 80 && b == 11)
		{
			return 91;
		}
		else if(a == 80 && b == 12)
		{
			return 92;
		}
		else if(a == 80 && b == 13)
		{
			return 93;
		}
		else if(a == 80 && b == 14)
		{
			return 94;
		}
		else if(a == 80 && b == 15)
		{
			return 95;
		}
		else if(a == 80 && b == 16)
		{
			return 96;
		}
		else if(a == 80 && b == 17)
		{
			return 97;
		}
		else if(a == 80 && b == 18)
		{
			return 98;
		}
		else if(a == 80 && b == 19)
		{
			return 99;
		}
		else if(a == 80 && b == 20)
		{
			return 100;
		}
		else if(a == 80 && b == 21)
		{
			return 101;
		}
		else if(a == 80 && b == 22)
		{
			return 102;
		}
		else if(a == 80 && b == 23)
		{
			return 103;
		}
		else if(a == 80 && b == 24)
		{
			return 104;
		}
		else if(a == 80 && b == 25)
		{
			return 105;
		}
		else if(a == 80 && b == 26)
		{
			return 106;
		}
		else if(a == 80 && b == 27)
		{
			return 107;
		}
		else if(a == 80 && b == 28)
		{
			return 108;
		}
		else if(a == 80 && b == 29)
		{
			return 109;
		}
		else if(a == 80 && b == 30)
		{
			return 110;
		}
		else if(a == 80 && b == 31)
		{
			return 111;
		}
		else if(a == 80 && b == 32)
		{
			return 112;
		}
		else if(a == 80 && b == 33)
		{
			return 113;
		}
		else if(a == 80 && b == 34)
		{
			return 114;
		}
		else if(a == 80 && b == 35)
		{
			return 115;
		}
		else if(a == 80 && b == 36)
		{
			return 116;
		}
		else if(a == 80 && b == 37)
		{
			return 117;
		}
		else if(a == 80 && b == 38)
		{
			return 118;
		}
		else if(a == 80 && b == 39)
		{
			return 119;
		}
		else if(a == 80 && b == 40)
		{
			return 120;
		}
		else if(a == 80 && b == 41)
		{
			return 121;
		}
		else if(a == 80 && b == 42)
		{
			return 122;
		}
		else if(a == 80 && b == 43)
		{
			return 123;
		}
		else if(a == 80 && b == 44)
		{
			return 124;
		}
		else if(a == 80 && b == 45)
		{
			return 125;
		}
		else if(a == 80 && b == 46)
		{
			return 126;
		}
		else if(a == 80 && b == 47)
		{
			return 127;
		}
		else if(a == 80 && b == 48)
		{
			return 128;
		}
		else if(a == 80 && b == 49)
		{
			return 129;
		}
		else if(a == 80 && b == 50)
		{
			return 130;
		}
		else if(a == 80 && b == 51)
		{
			return 131;
		}
		else if(a == 80 && b == 52)
		{
			return 132;
		}
		else if(a == 80 && b == 53)
		{
			return 133;
		}
		else if(a == 80 && b == 54)
		{
			return 134;
		}
		else if(a == 80 && b == 55)
		{
			return 135;
		}
		else if(a == 80 && b == 56)
		{
			return 136;
		}
		else if(a == 80 && b == 57)
		{
			return 137;
		}
		else if(a == 80 && b == 58)
		{
			return 138;
		}
		else if(a == 80 && b == 59)
		{
			return 139;
		}
		else if(a == 80 && b == 60)
		{
			return 140;
		}
		else if(a == 80 && b == 61)
		{
			return 141;
		}
		else if(a == 80 && b == 62)
		{
			return 142;
		}
		else if(a == 80 && b == 63)
		{
			return 143;
		}
		else if(a == 80 && b == 64)
		{
			return 144;
		}
		else if(a == 80 && b == 65)
		{
			return 145;
		}
		else if(a == 80 && b == 66)
		{
			return 146;
		}
		else if(a == 80 && b == 67)
		{
			return 147;
		}
		else if(a == 80 && b == 68)
		{
			return 148;
		}
		else if(a == 80 && b == 69)
		{
			return 149;
		}
		else if(a == 80 && b == 70)
		{
			return 150;
		}
		else if(a == 80 && b == 71)
		{
			return 151;
		}
		else if(a == 80 && b == 72)
		{
			return 152;
		}
		else if(a == 80 && b == 73)
		{
			return 153;
		}
		else if(a == 80 && b == 74)
		{
			return 154;
		}
		else if(a == 80 && b == 75)
		{
			return 155;
		}
		else if(a == 80 && b == 76)
		{
			return 156;
		}
		else if(a == 80 && b == 77)
		{
			return 157;
		}
		else if(a == 80 && b == 78)
		{
			return 158;
		}
		else if(a == 80 && b == 79)
		{
			return 159;
		}
		else if(a == 80 && b == 80)
		{
			return 160;
		}
		else if(a == 80 && b == 81)
		{
			return 161;
		}
		else if(a == 80 && b == 82)
		{
			return 162;
		}
		else if(a == 80 && b == 83)
		{
			return 163;
		}
		else if(a == 80 && b == 84)
		{
			return 164;
		}
		else if(a == 80 && b == 85)
		{
			return 165;
		}
		else if(a == 80 && b == 86)
		{
			return 166;
		}
		else if(a == 80 && b == 87)
		{
			return 167;
		}
		else if(a == 80 && b == 88)
		{
			return 168;
		}
		else if(a == 80 && b == 89)
		{
			return 169;
		}
		else if(a == 80 && b == 90)
		{
			return 170;
		}
		else if(a == 80 && b == 91)
		{
			return 171;
		}
		else if(a == 80 && b == 92)
		{
			return 172;
		}
		else if(a == 80 && b == 93)
		{
			return 173;
		}
		else if(a == 80 && b == 94)
		{
			return 174;
		}
		else if(a == 80 && b == 95)
		{
			return 175;
		}
		else if(a == 80 && b == 96)
		{
			return 176;
		}
		else if(a == 80 && b == 97)
		{
			return 177;
		}
		else if(a == 80 && b == 98)
		{
			return 178;
		}
		else if(a == 80 && b == 99)
		{
			return 179;
		}
		else if(a == 80 && b == 100)
		{
			return 180;
		}
		else if(a == 81 && b == 0)
		{
			return 81;
		}
		else if(a == 81 && b == 1)
		{
			return 82;
		}
		else if(a == 81 && b == 2)
		{
			return 83;
		}
		else if(a == 81 && b == 3)
		{
			return 84;
		}
		else if(a == 81 && b == 4)
		{
			return 85;
		}
		else if(a == 81 && b == 5)
		{
			return 86;
		}
		else if(a == 81 && b == 6)
		{
			return 87;
		}
		else if(a == 81 && b == 7)
		{
			return 88;
		}
		else if(a == 81 && b == 8)
		{
			return 89;
		}
		else if(a == 81 && b == 9)
		{
			return 90;
		}
		else if(a == 81 && b == 10)
		{
			return 91;
		}
		else if(a == 81 && b == 11)
		{
			return 92;
		}
		else if(a == 81 && b == 12)
		{
			return 93;
		}
		else if(a == 81 && b == 13)
		{
			return 94;
		}
		else if(a == 81 && b == 14)
		{
			return 95;
		}
		else if(a == 81 && b == 15)
		{
			return 96;
		}
		else if(a == 81 && b == 16)
		{
			return 97;
		}
		else if(a == 81 && b == 17)
		{
			return 98;
		}
		else if(a == 81 && b == 18)
		{
			return 99;
		}
		else if(a == 81 && b == 19)
		{
			return 100;
		}
		else if(a == 81 && b == 20)
		{
			return 101;
		}
		else if(a == 81 && b == 21)
		{
			return 102;
		}
		else if(a == 81 && b == 22)
		{
			return 103;
		}
		else if(a == 81 && b == 23)
		{
			return 104;
		}
		else if(a == 81 && b == 24)
		{
			return 105;
		}
		else if(a == 81 && b == 25)
		{
			return 106;
		}
		else if(a == 81 && b == 26)
		{
			return 107;
		}
		else if(a == 81 && b == 27)
		{
			return 108;
		}
		else if(a == 81 && b == 28)
		{
			return 109;
		}
		else if(a == 81 && b == 29)
		{
			return 110;
		}
		else if(a == 81 && b == 30)
		{
			return 111;
		}
		else if(a == 81 && b == 31)
		{
			return 112;
		}
		else if(a == 81 && b == 32)
		{
			return 113;
		}
		else if(a == 81 && b == 33)
		{
			return 114;
		}
		else if(a == 81 && b == 34)
		{
			return 115;
		}
		else if(a == 81 && b == 35)
		{
			return 116;
		}
		else if(a == 81 && b == 36)
		{
			return 117;
		}
		else if(a == 81 && b == 37)
		{
			return 118;
		}
		else if(a == 81 && b == 38)
		{
			return 119;
		}
		else if(a == 81 && b == 39)
		{
			return 120;
		}
		else if(a == 81 && b == 40)
		{
			return 121;
		}
		else if(a == 81 && b == 41)
		{
			return 122;
		}
		else if(a == 81 && b == 42)
		{
			return 123;
		}
		else if(a == 81 && b == 43)
		{
			return 124;
		}
		else if(a == 81 && b == 44)
		{
			return 125;
		}
		else if(a == 81 && b == 45)
		{
			return 126;
		}
		else if(a == 81 && b == 46)
		{
			return 127;
		}
		else if(a == 81 && b == 47)
		{
			return 128;
		}
		else if(a == 81 && b == 48)
		{
			return 129;
		}
		else if(a == 81 && b == 49)
		{
			return 130;
		}
		else if(a == 81 && b == 50)
		{
			return 131;
		}
		else if(a == 81 && b == 51)
		{
			return 132;
		}
		else if(a == 81 && b == 52)
		{
			return 133;
		}
		else if(a == 81 && b == 53)
		{
			return 134;
		}
		else if(a == 81 && b == 54)
		{
			return 135;
		}
		else if(a == 81 && b == 55)
		{
			return 136;
		}
		else if(a == 81 && b == 56)
		{
			return 137;
		}
		else if(a == 81 && b == 57)
		{
			return 138;
		}
		else if(a == 81 && b == 58)
		{
			return 139;
		}
		else if(a == 81 && b == 59)
		{
			return 140;
		}
		else if(a == 81 && b == 60)
		{
			return 141;
		}
		else if(a == 81 && b == 61)
		{
			return 142;
		}
		else if(a == 81 && b == 62)
		{
			return 143;
		}
		else if(a == 81 && b == 63)
		{
			return 144;
		}
		else if(a == 81 && b == 64)
		{
			return 145;
		}
		else if(a == 81 && b == 65)
		{
			return 146;
		}
		else if(a == 81 && b == 66)
		{
			return 147;
		}
		else if(a == 81 && b == 67)
		{
			return 148;
		}
		else if(a == 81 && b == 68)
		{
			return 149;
		}
		else if(a == 81 && b == 69)
		{
			return 150;
		}
		else if(a == 81 && b == 70)
		{
			return 151;
		}
		else if(a == 81 && b == 71)
		{
			return 152;
		}
		else if(a == 81 && b == 72)
		{
			return 153;
		}
		else if(a == 81 && b == 73)
		{
			return 154;
		}
		else if(a == 81 && b == 74)
		{
			return 155;
		}
		else if(a == 81 && b == 75)
		{
			return 156;
		}
		else if(a == 81 && b == 76)
		{
			return 157;
		}
		else if(a == 81 && b == 77)
		{
			return 158;
		}
		else if(a == 81 && b == 78)
		{
			return 159;
		}
		else if(a == 81 && b == 79)
		{
			return 160;
		}
		else if(a == 81 && b == 80)
		{
			return 161;
		}
		else if(a == 81 && b == 81)
		{
			return 162;
		}
		else if(a == 81 && b == 82)
		{
			return 163;
		}
		else if(a == 81 && b == 83)
		{
			return 164;
		}
		else if(a == 81 && b == 84)
		{
			return 165;
		}
		else if(a == 81 && b == 85)
		{
			return 166;
		}
		else if(a == 81 && b == 86)
		{
			return 167;
		}
		else if(a == 81 && b == 87)
		{
			return 168;
		}
		else if(a == 81 && b == 88)
		{
			return 169;
		}
		else if(a == 81 && b == 89)
		{
			return 170;
		}
		else if(a == 81 && b == 90)
		{
			return 171;
		}
		else if(a == 81 && b == 91)
		{
			return 172;
		}
		else if(a == 81 && b == 92)
		{
			return 173;
		}
		else if(a == 81 && b == 93)
		{
			return 174;
		}
		else if(a == 81 && b == 94)
		{
			return 175;
		}
		else if(a == 81 && b == 95)
		{
			return 176;
		}
		else if(a == 81 && b == 96)
		{
			return 177;
		}
		else if(a == 81 && b == 97)
		{
			return 178;
		}
		else if(a == 81 && b == 98)
		{
			return 179;
		}
		else if(a == 81 && b == 99)
		{
			return 180;
		}
		else if(a == 81 && b == 100)
		{
			return 181;
		}
		else if(a == 82 && b == 0)
		{
			return 82;
		}
		else if(a == 82 && b == 1)
		{
			return 83;
		}
		else if(a == 82 && b == 2)
		{
			return 84;
		}
		else if(a == 82 && b == 3)
		{
			return 85;
		}
		else if(a == 82 && b == 4)
		{
			return 86;
		}
		else if(a == 82 && b == 5)
		{
			return 87;
		}
		else if(a == 82 && b == 6)
		{
			return 88;
		}
		else if(a == 82 && b == 7)
		{
			return 89;
		}
		else if(a == 82 && b == 8)
		{
			return 90;
		}
		else if(a == 82 && b == 9)
		{
			return 91;
		}
		else if(a == 82 && b == 10)
		{
			return 92;
		}
		else if(a == 82 && b == 11)
		{
			return 93;
		}
		else if(a == 82 && b == 12)
		{
			return 94;
		}
		else if(a == 82 && b == 13)
		{
			return 95;
		}
		else if(a == 82 && b == 14)
		{
			return 96;
		}
		else if(a == 82 && b == 15)
		{
			return 97;
		}
		else if(a == 82 && b == 16)
		{
			return 98;
		}
		else if(a == 82 && b == 17)
		{
			return 99;
		}
		else if(a == 82 && b == 18)
		{
			return 100;
		}
		else if(a == 82 && b == 19)
		{
			return 101;
		}
		else if(a == 82 && b == 20)
		{
			return 102;
		}
		else if(a == 82 && b == 21)
		{
			return 103;
		}
		else if(a == 82 && b == 22)
		{
			return 104;
		}
		else if(a == 82 && b == 23)
		{
			return 105;
		}
		else if(a == 82 && b == 24)
		{
			return 106;
		}
		else if(a == 82 && b == 25)
		{
			return 107;
		}
		else if(a == 82 && b == 26)
		{
			return 108;
		}
		else if(a == 82 && b == 27)
		{
			return 109;
		}
		else if(a == 82 && b == 28)
		{
			return 110;
		}
		else if(a == 82 && b == 29)
		{
			return 111;
		}
		else if(a == 82 && b == 30)
		{
			return 112;
		}
		else if(a == 82 && b == 31)
		{
			return 113;
		}
		else if(a == 82 && b == 32)
		{
			return 114;
		}
		else if(a == 82 && b == 33)
		{
			return 115;
		}
		else if(a == 82 && b == 34)
		{
			return 116;
		}
		else if(a == 82 && b == 35)
		{
			return 117;
		}
		else if(a == 82 && b == 36)
		{
			return 118;
		}
		else if(a == 82 && b == 37)
		{
			return 119;
		}
		else if(a == 82 && b == 38)
		{
			return 120;
		}
		else if(a == 82 && b == 39)
		{
			return 121;
		}
		else if(a == 82 && b == 40)
		{
			return 122;
		}
		else if(a == 82 && b == 41)
		{
			return 123;
		}
		else if(a == 82 && b == 42)
		{
			return 124;
		}
		else if(a == 82 && b == 43)
		{
			return 125;
		}
		else if(a == 82 && b == 44)
		{
			return 126;
		}
		else if(a == 82 && b == 45)
		{
			return 127;
		}
		else if(a == 82 && b == 46)
		{
			return 128;
		}
		else if(a == 82 && b == 47)
		{
			return 129;
		}
		else if(a == 82 && b == 48)
		{
			return 130;
		}
		else if(a == 82 && b == 49)
		{
			return 131;
		}
		else if(a == 82 && b == 50)
		{
			return 132;
		}
		else if(a == 82 && b == 51)
		{
			return 133;
		}
		else if(a == 82 && b == 52)
		{
			return 134;
		}
		else if(a == 82 && b == 53)
		{
			return 135;
		}
		else if(a == 82 && b == 54)
		{
			return 136;
		}
		else if(a == 82 && b == 55)
		{
			return 137;
		}
		else if(a == 82 && b == 56)
		{
			return 138;
		}
		else if(a == 82 && b == 57)
		{
			return 139;
		}
		else if(a == 82 && b == 58)
		{
			return 140;
		}
		else if(a == 82 && b == 59)
		{
			return 141;
		}
		else if(a == 82 && b == 60)
		{
			return 142;
		}
		else if(a == 82 && b == 61)
		{
			return 143;
		}
		else if(a == 82 && b == 62)
		{
			return 144;
		}
		else if(a == 82 && b == 63)
		{
			return 145;
		}
		else if(a == 82 && b == 64)
		{
			return 146;
		}
		else if(a == 82 && b == 65)
		{
			return 147;
		}
		else if(a == 82 && b == 66)
		{
			return 148;
		}
		else if(a == 82 && b == 67)
		{
			return 149;
		}
		else if(a == 82 && b == 68)
		{
			return 150;
		}
		else if(a == 82 && b == 69)
		{
			return 151;
		}
		else if(a == 82 && b == 70)
		{
			return 152;
		}
		else if(a == 82 && b == 71)
		{
			return 153;
		}
		else if(a == 82 && b == 72)
		{
			return 154;
		}
		else if(a == 82 && b == 73)
		{
			return 155;
		}
		else if(a == 82 && b == 74)
		{
			return 156;
		}
		else if(a == 82 && b == 75)
		{
			return 157;
		}
		else if(a == 82 && b == 76)
		{
			return 158;
		}
		else if(a == 82 && b == 77)
		{
			return 159;
		}
		else if(a == 82 && b == 78)
		{
			return 160;
		}
		else if(a == 82 && b == 79)
		{
			return 161;
		}
		else if(a == 82 && b == 80)
		{
			return 162;
		}
		else if(a == 82 && b == 81)
		{
			return 163;
		}
		else if(a == 82 && b == 82)
		{
			return 164;
		}
		else if(a == 82 && b == 83)
		{
			return 165;
		}
		else if(a == 82 && b == 84)
		{
			return 166;
		}
		else if(a == 82 && b == 85)
		{
			return 167;
		}
		else if(a == 82 && b == 86)
		{
			return 168;
		}
		else if(a == 82 && b == 87)
		{
			return 169;
		}
		else if(a == 82 && b == 88)
		{
			return 170;
		}
		else if(a == 82 && b == 89)
		{
			return 171;
		}
		else if(a == 82 && b == 90)
		{
			return 172;
		}
		else if(a == 82 && b == 91)
		{
			return 173;
		}
		else if(a == 82 && b == 92)
		{
			return 174;
		}
		else if(a == 82 && b == 93)
		{
			return 175;
		}
		else if(a == 82 && b == 94)
		{
			return 176;
		}
		else if(a == 82 && b == 95)
		{
			return 177;
		}
		else if(a == 82 && b == 96)
		{
			return 178;
		}
		else if(a == 82 && b == 97)
		{
			return 179;
		}
		else if(a == 82 && b == 98)
		{
			return 180;
		}
		else if(a == 82 && b == 99)
		{
			return 181;
		}
		else if(a == 82 && b == 100)
		{
			return 182;
		}
		else if(a == 83 && b == 0)
		{
			return 83;
		}
		else if(a == 83 && b == 1)
		{
			return 84;
		}
		else if(a == 83 && b == 2)
		{
			return 85;
		}
		else if(a == 83 && b == 3)
		{
			return 86;
		}
		else if(a == 83 && b == 4)
		{
			return 87;
		}
		else if(a == 83 && b == 5)
		{
			return 88;
		}
		else if(a == 83 && b == 6)
		{
			return 89;
		}
		else if(a == 83 && b == 7)
		{
			return 90;
		}
		else if(a == 83 && b == 8)
		{
			return 91;
		}
		else if(a == 83 && b == 9)
		{
			return 92;
		}
		else if(a == 83 && b == 10)
		{
			return 93;
		}
		else if(a == 83 && b == 11)
		{
			return 94;
		}
		else if(a == 83 && b == 12)
		{
			return 95;
		}
		else if(a == 83 && b == 13)
		{
			return 96;
		}
		else if(a == 83 && b == 14)
		{
			return 97;
		}
		else if(a == 83 && b == 15)
		{
			return 98;
		}
		else if(a == 83 && b == 16)
		{
			return 99;
		}
		else if(a == 83 && b == 17)
		{
			return 100;
		}
		else if(a == 83 && b == 18)
		{
			return 101;
		}
		else if(a == 83 && b == 19)
		{
			return 102;
		}
		else if(a == 83 && b == 20)
		{
			return 103;
		}
		else if(a == 83 && b == 21)
		{
			return 104;
		}
		else if(a == 83 && b == 22)
		{
			return 105;
		}
		else if(a == 83 && b == 23)
		{
			return 106;
		}
		else if(a == 83 && b == 24)
		{
			return 107;
		}
		else if(a == 83 && b == 25)
		{
			return 108;
		}
		else if(a == 83 && b == 26)
		{
			return 109;
		}
		else if(a == 83 && b == 27)
		{
			return 110;
		}
		else if(a == 83 && b == 28)
		{
			return 111;
		}
		else if(a == 83 && b == 29)
		{
			return 112;
		}
		else if(a == 83 && b == 30)
		{
			return 113;
		}
		else if(a == 83 && b == 31)
		{
			return 114;
		}
		else if(a == 83 && b == 32)
		{
			return 115;
		}
		else if(a == 83 && b == 33)
		{
			return 116;
		}
		else if(a == 83 && b == 34)
		{
			return 117;
		}
		else if(a == 83 && b == 35)
		{
			return 118;
		}
		else if(a == 83 && b == 36)
		{
			return 119;
		}
		else if(a == 83 && b == 37)
		{
			return 120;
		}
		else if(a == 83 && b == 38)
		{
			return 121;
		}
		else if(a == 83 && b == 39)
		{
			return 122;
		}
		else if(a == 83 && b == 40)
		{
			return 123;
		}
		else if(a == 83 && b == 41)
		{
			return 124;
		}
		else if(a == 83 && b == 42)
		{
			return 125;
		}
		else if(a == 83 && b == 43)
		{
			return 126;
		}
		else if(a == 83 && b == 44)
		{
			return 127;
		}
		else if(a == 83 && b == 45)
		{
			return 128;
		}
		else if(a == 83 && b == 46)
		{
			return 129;
		}
		else if(a == 83 && b == 47)
		{
			return 130;
		}
		else if(a == 83 && b == 48)
		{
			return 131;
		}
		else if(a == 83 && b == 49)
		{
			return 132;
		}
		else if(a == 83 && b == 50)
		{
			return 133;
		}
		else if(a == 83 && b == 51)
		{
			return 134;
		}
		else if(a == 83 && b == 52)
		{
			return 135;
		}
		else if(a == 83 && b == 53)
		{
			return 136;
		}
		else if(a == 83 && b == 54)
		{
			return 137;
		}
		else if(a == 83 && b == 55)
		{
			return 138;
		}
		else if(a == 83 && b == 56)
		{
			return 139;
		}
		else if(a == 83 && b == 57)
		{
			return 140;
		}
		else if(a == 83 && b == 58)
		{
			return 141;
		}
		else if(a == 83 && b == 59)
		{
			return 142;
		}
		else if(a == 83 && b == 60)
		{
			return 143;
		}
		else if(a == 83 && b == 61)
		{
			return 144;
		}
		else if(a == 83 && b == 62)
		{
			return 145;
		}
		else if(a == 83 && b == 63)
		{
			return 146;
		}
		else if(a == 83 && b == 64)
		{
			return 147;
		}
		else if(a == 83 && b == 65)
		{
			return 148;
		}
		else if(a == 83 && b == 66)
		{
			return 149;
		}
		else if(a == 83 && b == 67)
		{
			return 150;
		}
		else if(a == 83 && b == 68)
		{
			return 151;
		}
		else if(a == 83 && b == 69)
		{
			return 152;
		}
		else if(a == 83 && b == 70)
		{
			return 153;
		}
		else if(a == 83 && b == 71)
		{
			return 154;
		}
		else if(a == 83 && b == 72)
		{
			return 155;
		}
		else if(a == 83 && b == 73)
		{
			return 156;
		}
		else if(a == 83 && b == 74)
		{
			return 157;
		}
		else if(a == 83 && b == 75)
		{
			return 158;
		}
		else if(a == 83 && b == 76)
		{
			return 159;
		}
		else if(a == 83 && b == 77)
		{
			return 160;
		}
		else if(a == 83 && b == 78)
		{
			return 161;
		}
		else if(a == 83 && b == 79)
		{
			return 162;
		}
		else if(a == 83 && b == 80)
		{
			return 163;
		}
		else if(a == 83 && b == 81)
		{
			return 164;
		}
		else if(a == 83 && b == 82)
		{
			return 165;
		}
		else if(a == 83 && b == 83)
		{
			return 166;
		}
		else if(a == 83 && b == 84)
		{
			return 167;
		}
		else if(a == 83 && b == 85)
		{
			return 168;
		}
		else if(a == 83 && b == 86)
		{
			return 169;
		}
		else if(a == 83 && b == 87)
		{
			return 170;
		}
		else if(a == 83 && b == 88)
		{
			return 171;
		}
		else if(a == 83 && b == 89)
		{
			return 172;
		}
		else if(a == 83 && b == 90)
		{
			return 173;
		}
		else if(a == 83 && b == 91)
		{
			return 174;
		}
		else if(a == 83 && b == 92)
		{
			return 175;
		}
		else if(a == 83 && b == 93)
		{
			return 176;
		}
		else if(a == 83 && b == 94)
		{
			return 177;
		}
		else if(a == 83 && b == 95)
		{
			return 178;
		}
		else if(a == 83 && b == 96)
		{
			return 179;
		}
		else if(a == 83 && b == 97)
		{
			return 180;
		}
		else if(a == 83 && b == 98)
		{
			return 181;
		}
		else if(a == 83 && b == 99)
		{
			return 182;
		}
		else if(a == 83 && b == 100)
		{
			return 183;
		}
		else if(a == 84 && b == 0)
		{
			return 84;
		}
		else if(a == 84 && b == 1)
		{
			return 85;
		}
		else if(a == 84 && b == 2)
		{
			return 86;
		}
		else if(a == 84 && b == 3)
		{
			return 87;
		}
		else if(a == 84 && b == 4)
		{
			return 88;
		}
		else if(a == 84 && b == 5)
		{
			return 89;
		}
		else if(a == 84 && b == 6)
		{
			return 90;
		}
		else if(a == 84 && b == 7)
		{
			return 91;
		}
		else if(a == 84 && b == 8)
		{
			return 92;
		}
		else if(a == 84 && b == 9)
		{
			return 93;
		}
		else if(a == 84 && b == 10)
		{
			return 94;
		}
		else if(a == 84 && b == 11)
		{
			return 95;
		}
		else if(a == 84 && b == 12)
		{
			return 96;
		}
		else if(a == 84 && b == 13)
		{
			return 97;
		}
		else if(a == 84 && b == 14)
		{
			return 98;
		}
		else if(a == 84 && b == 15)
		{
			return 99;
		}
		else if(a == 84 && b == 16)
		{
			return 100;
		}
		else if(a == 84 && b == 17)
		{
			return 101;
		}
		else if(a == 84 && b == 18)
		{
			return 102;
		}
		else if(a == 84 && b == 19)
		{
			return 103;
		}
		else if(a == 84 && b == 20)
		{
			return 104;
		}
		else if(a == 84 && b == 21)
		{
			return 105;
		}
		else if(a == 84 && b == 22)
		{
			return 106;
		}
		else if(a == 84 && b == 23)
		{
			return 107;
		}
		else if(a == 84 && b == 24)
		{
			return 108;
		}
		else if(a == 84 && b == 25)
		{
			return 109;
		}
		else if(a == 84 && b == 26)
		{
			return 110;
		}
		else if(a == 84 && b == 27)
		{
			return 111;
		}
		else if(a == 84 && b == 28)
		{
			return 112;
		}
		else if(a == 84 && b == 29)
		{
			return 113;
		}
		else if(a == 84 && b == 30)
		{
			return 114;
		}
		else if(a == 84 && b == 31)
		{
			return 115;
		}
		else if(a == 84 && b == 32)
		{
			return 116;
		}
		else if(a == 84 && b == 33)
		{
			return 117;
		}
		else if(a == 84 && b == 34)
		{
			return 118;
		}
		else if(a == 84 && b == 35)
		{
			return 119;
		}
		else if(a == 84 && b == 36)
		{
			return 120;
		}
		else if(a == 84 && b == 37)
		{
			return 121;
		}
		else if(a == 84 && b == 38)
		{
			return 122;
		}
		else if(a == 84 && b == 39)
		{
			return 123;
		}
		else if(a == 84 && b == 40)
		{
			return 124;
		}
		else if(a == 84 && b == 41)
		{
			return 125;
		}
		else if(a == 84 && b == 42)
		{
			return 126;
		}
		else if(a == 84 && b == 43)
		{
			return 127;
		}
		else if(a == 84 && b == 44)
		{
			return 128;
		}
		else if(a == 84 && b == 45)
		{
			return 129;
		}
		else if(a == 84 && b == 46)
		{
			return 130;
		}
		else if(a == 84 && b == 47)
		{
			return 131;
		}
		else if(a == 84 && b == 48)
		{
			return 132;
		}
		else if(a == 84 && b == 49)
		{
			return 133;
		}
		else if(a == 84 && b == 50)
		{
			return 134;
		}
		else if(a == 84 && b == 51)
		{
			return 135;
		}
		else if(a == 84 && b == 52)
		{
			return 136;
		}
		else if(a == 84 && b == 53)
		{
			return 137;
		}
		else if(a == 84 && b == 54)
		{
			return 138;
		}
		else if(a == 84 && b == 55)
		{
			return 139;
		}
		else if(a == 84 && b == 56)
		{
			return 140;
		}
		else if(a == 84 && b == 57)
		{
			return 141;
		}
		else if(a == 84 && b == 58)
		{
			return 142;
		}
		else if(a == 84 && b == 59)
		{
			return 143;
		}
		else if(a == 84 && b == 60)
		{
			return 144;
		}
		else if(a == 84 && b == 61)
		{
			return 145;
		}
		else if(a == 84 && b == 62)
		{
			return 146;
		}
		else if(a == 84 && b == 63)
		{
			return 147;
		}
		else if(a == 84 && b == 64)
		{
			return 148;
		}
		else if(a == 84 && b == 65)
		{
			return 149;
		}
		else if(a == 84 && b == 66)
		{
			return 150;
		}
		else if(a == 84 && b == 67)
		{
			return 151;
		}
		else if(a == 84 && b == 68)
		{
			return 152;
		}
		else if(a == 84 && b == 69)
		{
			return 153;
		}
		else if(a == 84 && b == 70)
		{
			return 154;
		}
		else if(a == 84 && b == 71)
		{
			return 155;
		}
		else if(a == 84 && b == 72)
		{
			return 156;
		}
		else if(a == 84 && b == 73)
		{
			return 157;
		}
		else if(a == 84 && b == 74)
		{
			return 158;
		}
		else if(a == 84 && b == 75)
		{
			return 159;
		}
		else if(a == 84 && b == 76)
		{
			return 160;
		}
		else if(a == 84 && b == 77)
		{
			return 161;
		}
		else if(a == 84 && b == 78)
		{
			return 162;
		}
		else if(a == 84 && b == 79)
		{
			return 163;
		}
		else if(a == 84 && b == 80)
		{
			return 164;
		}
		else if(a == 84 && b == 81)
		{
			return 165;
		}
		else if(a == 84 && b == 82)
		{
			return 166;
		}
		else if(a == 84 && b == 83)
		{
			return 167;
		}
		else if(a == 84 && b == 84)
		{
			return 168;
		}
		else if(a == 84 && b == 85)
		{
			return 169;
		}
		else if(a == 84 && b == 86)
		{
			return 170;
		}
		else if(a == 84 && b == 87)
		{
			return 171;
		}
		else if(a == 84 && b == 88)
		{
			return 172;
		}
		else if(a == 84 && b == 89)
		{
			return 173;
		}
		else if(a == 84 && b == 90)
		{
			return 174;
		}
		else if(a == 84 && b == 91)
		{
			return 175;
		}
		else if(a == 84 && b == 92)
		{
			return 176;
		}
		else if(a == 84 && b == 93)
		{
			return 177;
		}
		else if(a == 84 && b == 94)
		{
			return 178;
		}
		else if(a == 84 && b == 95)
		{
			return 179;
		}
		else if(a == 84 && b == 96)
		{
			return 180;
		}
		else if(a == 84 && b == 97)
		{
			return 181;
		}
		else if(a == 84 && b == 98)
		{
			return 182;
		}
		else if(a == 84 && b == 99)
		{
			return 183;
		}
		else if(a == 84 && b == 100)
		{
			return 184;
		}
		else if(a == 85 && b == 0)
		{
			return 85;
		}
		else if(a == 85 && b == 1)
		{
			return 86;
		}
		else if(a == 85 && b == 2)
		{
			return 87;
		}
		else if(a == 85 && b == 3)
		{
			return 88;
		}
		else if(a == 85 && b == 4)
		{
			return 89;
		}
		else if(a == 85 && b == 5)
		{
			return 90;
		}
		else if(a == 85 && b == 6)
		{
			return 91;
		}
		else if(a == 85 && b == 7)
		{
			return 92;
		}
		else if(a == 85 && b == 8)
		{
			return 93;
		}
		else if(a == 85 && b == 9)
		{
			return 94;
		}
		else if(a == 85 && b == 10)
		{
			return 95;
		}
		else if(a == 85 && b == 11)
		{
			return 96;
		}
		else if(a == 85 && b == 12)
		{
			return 97;
		}
		else if(a == 85 && b == 13)
		{
			return 98;
		}
		else if(a == 85 && b == 14)
		{
			return 99;
		}
		else if(a == 85 && b == 15)
		{
			return 100;
		}
		else if(a == 85 && b == 16)
		{
			return 101;
		}
		else if(a == 85 && b == 17)
		{
			return 102;
		}
		else if(a == 85 && b == 18)
		{
			return 103;
		}
		else if(a == 85 && b == 19)
		{
			return 104;
		}
		else if(a == 85 && b == 20)
		{
			return 105;
		}
		else if(a == 85 && b == 21)
		{
			return 106;
		}
		else if(a == 85 && b == 22)
		{
			return 107;
		}
		else if(a == 85 && b == 23)
		{
			return 108;
		}
		else if(a == 85 && b == 24)
		{
			return 109;
		}
		else if(a == 85 && b == 25)
		{
			return 110;
		}
		else if(a == 85 && b == 26)
		{
			return 111;
		}
		else if(a == 85 && b == 27)
		{
			return 112;
		}
		else if(a == 85 && b == 28)
		{
			return 113;
		}
		else if(a == 85 && b == 29)
		{
			return 114;
		}
		else if(a == 85 && b == 30)
		{
			return 115;
		}
		else if(a == 85 && b == 31)
		{
			return 116;
		}
		else if(a == 85 && b == 32)
		{
			return 117;
		}
		else if(a == 85 && b == 33)
		{
			return 118;
		}
		else if(a == 85 && b == 34)
		{
			return 119;
		}
		else if(a == 85 && b == 35)
		{
			return 120;
		}
		else if(a == 85 && b == 36)
		{
			return 121;
		}
		else if(a == 85 && b == 37)
		{
			return 122;
		}
		else if(a == 85 && b == 38)
		{
			return 123;
		}
		else if(a == 85 && b == 39)
		{
			return 124;
		}
		else if(a == 85 && b == 40)
		{
			return 125;
		}
		else if(a == 85 && b == 41)
		{
			return 126;
		}
		else if(a == 85 && b == 42)
		{
			return 127;
		}
		else if(a == 85 && b == 43)
		{
			return 128;
		}
		else if(a == 85 && b == 44)
		{
			return 129;
		}
		else if(a == 85 && b == 45)
		{
			return 130;
		}
		else if(a == 85 && b == 46)
		{
			return 131;
		}
		else if(a == 85 && b == 47)
		{
			return 132;
		}
		else if(a == 85 && b == 48)
		{
			return 133;
		}
		else if(a == 85 && b == 49)
		{
			return 134;
		}
		else if(a == 85 && b == 50)
		{
			return 135;
		}
		else if(a == 85 && b == 51)
		{
			return 136;
		}
		else if(a == 85 && b == 52)
		{
			return 137;
		}
		else if(a == 85 && b == 53)
		{
			return 138;
		}
		else if(a == 85 && b == 54)
		{
			return 139;
		}
		else if(a == 85 && b == 55)
		{
			return 140;
		}
		else if(a == 85 && b == 56)
		{
			return 141;
		}
		else if(a == 85 && b == 57)
		{
			return 142;
		}
		else if(a == 85 && b == 58)
		{
			return 143;
		}
		else if(a == 85 && b == 59)
		{
			return 144;
		}
		else if(a == 85 && b == 60)
		{
			return 145;
		}
		else if(a == 85 && b == 61)
		{
			return 146;
		}
		else if(a == 85 && b == 62)
		{
			return 147;
		}
		else if(a == 85 && b == 63)
		{
			return 148;
		}
		else if(a == 85 && b == 64)
		{
			return 149;
		}
		else if(a == 85 && b == 65)
		{
			return 150;
		}
		else if(a == 85 && b == 66)
		{
			return 151;
		}
		else if(a == 85 && b == 67)
		{
			return 152;
		}
		else if(a == 85 && b == 68)
		{
			return 153;
		}
		else if(a == 85 && b == 69)
		{
			return 154;
		}
		else if(a == 85 && b == 70)
		{
			return 155;
		}
		else if(a == 85 && b == 71)
		{
			return 156;
		}
		else if(a == 85 && b == 72)
		{
			return 157;
		}
		else if(a == 85 && b == 73)
		{
			return 158;
		}
		else if(a == 85 && b == 74)
		{
			return 159;
		}
		else if(a == 85 && b == 75)
		{
			return 160;
		}
		else if(a == 85 && b == 76)
		{
			return 161;
		}
		else if(a == 85 && b == 77)
		{
			return 162;
		}
		else if(a == 85 && b == 78)
		{
			return 163;
		}
		else if(a == 85 && b == 79)
		{
			return 164;
		}
		else if(a == 85 && b == 80)
		{
			return 165;
		}
		else if(a == 85 && b == 81)
		{
			return 166;
		}
		else if(a == 85 && b == 82)
		{
			return 167;
		}
		else if(a == 85 && b == 83)
		{
			return 168;
		}
		else if(a == 85 && b == 84)
		{
			return 169;
		}
		else if(a == 85 && b == 85)
		{
			return 170;
		}
		else if(a == 85 && b == 86)
		{
			return 171;
		}
		else if(a == 85 && b == 87)
		{
			return 172;
		}
		else if(a == 85 && b == 88)
		{
			return 173;
		}
		else if(a == 85 && b == 89)
		{
			return 174;
		}
		else if(a == 85 && b == 90)
		{
			return 175;
		}
		else if(a == 85 && b == 91)
		{
			return 176;
		}
		else if(a == 85 && b == 92)
		{
			return 177;
		}
		else if(a == 85 && b == 93)
		{
			return 178;
		}
		else if(a == 85 && b == 94)
		{
			return 179;
		}
		else if(a == 85 && b == 95)
		{
			return 180;
		}
		else if(a == 85 && b == 96)
		{
			return 181;
		}
		else if(a == 85 && b == 97)
		{
			return 182;
		}
		else if(a == 85 && b == 98)
		{
			return 183;
		}
		else if(a == 85 && b == 99)
		{
			return 184;
		}
		else if(a == 85 && b == 100)
		{
			return 185;
		}
		else if(a == 86 && b == 0)
		{
			return 86;
		}
		else if(a == 86 && b == 1)
		{
			return 87;
		}
		else if(a == 86 && b == 2)
		{
			return 88;
		}
		else if(a == 86 && b == 3)
		{
			return 89;
		}
		else if(a == 86 && b == 4)
		{
			return 90;
		}
		else if(a == 86 && b == 5)
		{
			return 91;
		}
		else if(a == 86 && b == 6)
		{
			return 92;
		}
		else if(a == 86 && b == 7)
		{
			return 93;
		}
		else if(a == 86 && b == 8)
		{
			return 94;
		}
		else if(a == 86 && b == 9)
		{
			return 95;
		}
		else if(a == 86 && b == 10)
		{
			return 96;
		}
		else if(a == 86 && b == 11)
		{
			return 97;
		}
		else if(a == 86 && b == 12)
		{
			return 98;
		}
		else if(a == 86 && b == 13)
		{
			return 99;
		}
		else if(a == 86 && b == 14)
		{
			return 100;
		}
		else if(a == 86 && b == 15)
		{
			return 101;
		}
		else if(a == 86 && b == 16)
		{
			return 102;
		}
		else if(a == 86 && b == 17)
		{
			return 103;
		}
		else if(a == 86 && b == 18)
		{
			return 104;
		}
		else if(a == 86 && b == 19)
		{
			return 105;
		}
		else if(a == 86 && b == 20)
		{
			return 106;
		}
		else if(a == 86 && b == 21)
		{
			return 107;
		}
		else if(a == 86 && b == 22)
		{
			return 108;
		}
		else if(a == 86 && b == 23)
		{
			return 109;
		}
		else if(a == 86 && b == 24)
		{
			return 110;
		}
		else if(a == 86 && b == 25)
		{
			return 111;
		}
		else if(a == 86 && b == 26)
		{
			return 112;
		}
		else if(a == 86 && b == 27)
		{
			return 113;
		}
		else if(a == 86 && b == 28)
		{
			return 114;
		}
		else if(a == 86 && b == 29)
		{
			return 115;
		}
		else if(a == 86 && b == 30)
		{
			return 116;
		}
		else if(a == 86 && b == 31)
		{
			return 117;
		}
		else if(a == 86 && b == 32)
		{
			return 118;
		}
		else if(a == 86 && b == 33)
		{
			return 119;
		}
		else if(a == 86 && b == 34)
		{
			return 120;
		}
		else if(a == 86 && b == 35)
		{
			return 121;
		}
		else if(a == 86 && b == 36)
		{
			return 122;
		}
		else if(a == 86 && b == 37)
		{
			return 123;
		}
		else if(a == 86 && b == 38)
		{
			return 124;
		}
		else if(a == 86 && b == 39)
		{
			return 125;
		}
		else if(a == 86 && b == 40)
		{
			return 126;
		}
		else if(a == 86 && b == 41)
		{
			return 127;
		}
		else if(a == 86 && b == 42)
		{
			return 128;
		}
		else if(a == 86 && b == 43)
		{
			return 129;
		}
		else if(a == 86 && b == 44)
		{
			return 130;
		}
		else if(a == 86 && b == 45)
		{
			return 131;
		}
		else if(a == 86 && b == 46)
		{
			return 132;
		}
		else if(a == 86 && b == 47)
		{
			return 133;
		}
		else if(a == 86 && b == 48)
		{
			return 134;
		}
		else if(a == 86 && b == 49)
		{
			return 135;
		}
		else if(a == 86 && b == 50)
		{
			return 136;
		}
		else if(a == 86 && b == 51)
		{
			return 137;
		}
		else if(a == 86 && b == 52)
		{
			return 138;
		}
		else if(a == 86 && b == 53)
		{
			return 139;
		}
		else if(a == 86 && b == 54)
		{
			return 140;
		}
		else if(a == 86 && b == 55)
		{
			return 141;
		}
		else if(a == 86 && b == 56)
		{
			return 142;
		}
		else if(a == 86 && b == 57)
		{
			return 143;
		}
		else if(a == 86 && b == 58)
		{
			return 144;
		}
		else if(a == 86 && b == 59)
		{
			return 145;
		}
		else if(a == 86 && b == 60)
		{
			return 146;
		}
		else if(a == 86 && b == 61)
		{
			return 147;
		}
		else if(a == 86 && b == 62)
		{
			return 148;
		}
		else if(a == 86 && b == 63)
		{
			return 149;
		}
		else if(a == 86 && b == 64)
		{
			return 150;
		}
		else if(a == 86 && b == 65)
		{
			return 151;
		}
		else if(a == 86 && b == 66)
		{
			return 152;
		}
		else if(a == 86 && b == 67)
		{
			return 153;
		}
		else if(a == 86 && b == 68)
		{
			return 154;
		}
		else if(a == 86 && b == 69)
		{
			return 155;
		}
		else if(a == 86 && b == 70)
		{
			return 156;
		}
		else if(a == 86 && b == 71)
		{
			return 157;
		}
		else if(a == 86 && b == 72)
		{
			return 158;
		}
		else if(a == 86 && b == 73)
		{
			return 159;
		}
		else if(a == 86 && b == 74)
		{
			return 160;
		}
		else if(a == 86 && b == 75)
		{
			return 161;
		}
		else if(a == 86 && b == 76)
		{
			return 162;
		}
		else if(a == 86 && b == 77)
		{
			return 163;
		}
		else if(a == 86 && b == 78)
		{
			return 164;
		}
		else if(a == 86 && b == 79)
		{
			return 165;
		}
		else if(a == 86 && b == 80)
		{
			return 166;
		}
		else if(a == 86 && b == 81)
		{
			return 167;
		}
		else if(a == 86 && b == 82)
		{
			return 168;
		}
		else if(a == 86 && b == 83)
		{
			return 169;
		}
		else if(a == 86 && b == 84)
		{
			return 170;
		}
		else if(a == 86 && b == 85)
		{
			return 171;
		}
		else if(a == 86 && b == 86)
		{
			return 172;
		}
		else if(a == 86 && b == 87)
		{
			return 173;
		}
		else if(a == 86 && b == 88)
		{
			return 174;
		}
		else if(a == 86 && b == 89)
		{
			return 175;
		}
		else if(a == 86 && b == 90)
		{
			return 176;
		}
		else if(a == 86 && b == 91)
		{
			return 177;
		}
		else if(a == 86 && b == 92)
		{
			return 178;
		}
		else if(a == 86 && b == 93)
		{
			return 179;
		}
		else if(a == 86 && b == 94)
		{
			return 180;
		}
		else if(a == 86 && b == 95)
		{
			return 181;
		}
		else if(a == 86 && b == 96)
		{
			return 182;
		}
		else if(a == 86 && b == 97)
		{
			return 183;
		}
		else if(a == 86 && b == 98)
		{
			return 184;
		}
		else if(a == 86 && b == 99)
		{
			return 185;
		}
		else if(a == 86 && b == 100)
		{
			return 186;
		}
		else if(a == 87 && b == 0)
		{
			return 87;
		}
		else if(a == 87 && b == 1)
		{
			return 88;
		}
		else if(a == 87 && b == 2)
		{
			return 89;
		}
		else if(a == 87 && b == 3)
		{
			return 90;
		}
		else if(a == 87 && b == 4)
		{
			return 91;
		}
		else if(a == 87 && b == 5)
		{
			return 92;
		}
		else if(a == 87 && b == 6)
		{
			return 93;
		}
		else if(a == 87 && b == 7)
		{
			return 94;
		}
		else if(a == 87 && b == 8)
		{
			return 95;
		}
		else if(a == 87 && b == 9)
		{
			return 96;
		}
		else if(a == 87 && b == 10)
		{
			return 97;
		}
		else if(a == 87 && b == 11)
		{
			return 98;
		}
		else if(a == 87 && b == 12)
		{
			return 99;
		}
		else if(a == 87 && b == 13)
		{
			return 100;
		}
		else if(a == 87 && b == 14)
		{
			return 101;
		}
		else if(a == 87 && b == 15)
		{
			return 102;
		}
		else if(a == 87 && b == 16)
		{
			return 103;
		}
		else if(a == 87 && b == 17)
		{
			return 104;
		}
		else if(a == 87 && b == 18)
		{
			return 105;
		}
		else if(a == 87 && b == 19)
		{
			return 106;
		}
		else if(a == 87 && b == 20)
		{
			return 107;
		}
		else if(a == 87 && b == 21)
		{
			return 108;
		}
		else if(a == 87 && b == 22)
		{
			return 109;
		}
		else if(a == 87 && b == 23)
		{
			return 110;
		}
		else if(a == 87 && b == 24)
		{
			return 111;
		}
		else if(a == 87 && b == 25)
		{
			return 112;
		}
		else if(a == 87 && b == 26)
		{
			return 113;
		}
		else if(a == 87 && b == 27)
		{
			return 114;
		}
		else if(a == 87 && b == 28)
		{
			return 115;
		}
		else if(a == 87 && b == 29)
		{
			return 116;
		}
		else if(a == 87 && b == 30)
		{
			return 117;
		}
		else if(a == 87 && b == 31)
		{
			return 118;
		}
		else if(a == 87 && b == 32)
		{
			return 119;
		}
		else if(a == 87 && b == 33)
		{
			return 120;
		}
		else if(a == 87 && b == 34)
		{
			return 121;
		}
		else if(a == 87 && b == 35)
		{
			return 122;
		}
		else if(a == 87 && b == 36)
		{
			return 123;
		}
		else if(a == 87 && b == 37)
		{
			return 124;
		}
		else if(a == 87 && b == 38)
		{
			return 125;
		}
		else if(a == 87 && b == 39)
		{
			return 126;
		}
		else if(a == 87 && b == 40)
		{
			return 127;
		}
		else if(a == 87 && b == 41)
		{
			return 128;
		}
		else if(a == 87 && b == 42)
		{
			return 129;
		}
		else if(a == 87 && b == 43)
		{
			return 130;
		}
		else if(a == 87 && b == 44)
		{
			return 131;
		}
		else if(a == 87 && b == 45)
		{
			return 132;
		}
		else if(a == 87 && b == 46)
		{
			return 133;
		}
		else if(a == 87 && b == 47)
		{
			return 134;
		}
		else if(a == 87 && b == 48)
		{
			return 135;
		}
		else if(a == 87 && b == 49)
		{
			return 136;
		}
		else if(a == 87 && b == 50)
		{
			return 137;
		}
		else if(a == 87 && b == 51)
		{
			return 138;
		}
		else if(a == 87 && b == 52)
		{
			return 139;
		}
		else if(a == 87 && b == 53)
		{
			return 140;
		}
		else if(a == 87 && b == 54)
		{
			return 141;
		}
		else if(a == 87 && b == 55)
		{
			return 142;
		}
		else if(a == 87 && b == 56)
		{
			return 143;
		}
		else if(a == 87 && b == 57)
		{
			return 144;
		}
		else if(a == 87 && b == 58)
		{
			return 145;
		}
		else if(a == 87 && b == 59)
		{
			return 146;
		}
		else if(a == 87 && b == 60)
		{
			return 147;
		}
		else if(a == 87 && b == 61)
		{
			return 148;
		}
		else if(a == 87 && b == 62)
		{
			return 149;
		}
		else if(a == 87 && b == 63)
		{
			return 150;
		}
		else if(a == 87 && b == 64)
		{
			return 151;
		}
		else if(a == 87 && b == 65)
		{
			return 152;
		}
		else if(a == 87 && b == 66)
		{
			return 153;
		}
		else if(a == 87 && b == 67)
		{
			return 154;
		}
		else if(a == 87 && b == 68)
		{
			return 155;
		}
		else if(a == 87 && b == 69)
		{
			return 156;
		}
		else if(a == 87 && b == 70)
		{
			return 157;
		}
		else if(a == 87 && b == 71)
		{
			return 158;
		}
		else if(a == 87 && b == 72)
		{
			return 159;
		}
		else if(a == 87 && b == 73)
		{
			return 160;
		}
		else if(a == 87 && b == 74)
		{
			return 161;
		}
		else if(a == 87 && b == 75)
		{
			return 162;
		}
		else if(a == 87 && b == 76)
		{
			return 163;
		}
		else if(a == 87 && b == 77)
		{
			return 164;
		}
		else if(a == 87 && b == 78)
		{
			return 165;
		}
		else if(a == 87 && b == 79)
		{
			return 166;
		}
		else if(a == 87 && b == 80)
		{
			return 167;
		}
		else if(a == 87 && b == 81)
		{
			return 168;
		}
		else if(a == 87 && b == 82)
		{
			return 169;
		}
		else if(a == 87 && b == 83)
		{
			return 170;
		}
		else if(a == 87 && b == 84)
		{
			return 171;
		}
		else if(a == 87 && b == 85)
		{
			return 172;
		}
		else if(a == 87 && b == 86)
		{
			return 173;
		}
		else if(a == 87 && b == 87)
		{
			return 174;
		}
		else if(a == 87 && b == 88)
		{
			return 175;
		}
		else if(a == 87 && b == 89)
		{
			return 176;
		}
		else if(a == 87 && b == 90)
		{
			return 177;
		}
		else if(a == 87 && b == 91)
		{
			return 178;
		}
		else if(a == 87 && b == 92)
		{
			return 179;
		}
		else if(a == 87 && b == 93)
		{
			return 180;
		}
		else if(a == 87 && b == 94)
		{
			return 181;
		}
		else if(a == 87 && b == 95)
		{
			return 182;
		}
		else if(a == 87 && b == 96)
		{
			return 183;
		}
		else if(a == 87 && b == 97)
		{
			return 184;
		}
		else if(a == 87 && b == 98)
		{
			return 185;
		}
		else if(a == 87 && b == 99)
		{
			return 186;
		}
		else if(a == 87 && b == 100)
		{
			return 187;
		}
		else if(a == 88 && b == 0)
		{
			return 88;
		}
		else if(a == 88 && b == 1)
		{
			return 89;
		}
		else if(a == 88 && b == 2)
		{
			return 90;
		}
		else if(a == 88 && b == 3)
		{
			return 91;
		}
		else if(a == 88 && b == 4)
		{
			return 92;
		}
		else if(a == 88 && b == 5)
		{
			return 93;
		}
		else if(a == 88 && b == 6)
		{
			return 94;
		}
		else if(a == 88 && b == 7)
		{
			return 95;
		}
		else if(a == 88 && b == 8)
		{
			return 96;
		}
		else if(a == 88 && b == 9)
		{
			return 97;
		}
		else if(a == 88 && b == 10)
		{
			return 98;
		}
		else if(a == 88 && b == 11)
		{
			return 99;
		}
		else if(a == 88 && b == 12)
		{
			return 100;
		}
		else if(a == 88 && b == 13)
		{
			return 101;
		}
		else if(a == 88 && b == 14)
		{
			return 102;
		}
		else if(a == 88 && b == 15)
		{
			return 103;
		}
		else if(a == 88 && b == 16)
		{
			return 104;
		}
		else if(a == 88 && b == 17)
		{
			return 105;
		}
		else if(a == 88 && b == 18)
		{
			return 106;
		}
		else if(a == 88 && b == 19)
		{
			return 107;
		}
		else if(a == 88 && b == 20)
		{
			return 108;
		}
		else if(a == 88 && b == 21)
		{
			return 109;
		}
		else if(a == 88 && b == 22)
		{
			return 110;
		}
		else if(a == 88 && b == 23)
		{
			return 111;
		}
		else if(a == 88 && b == 24)
		{
			return 112;
		}
		else if(a == 88 && b == 25)
		{
			return 113;
		}
		else if(a == 88 && b == 26)
		{
			return 114;
		}
		else if(a == 88 && b == 27)
		{
			return 115;
		}
		else if(a == 88 && b == 28)
		{
			return 116;
		}
		else if(a == 88 && b == 29)
		{
			return 117;
		}
		else if(a == 88 && b == 30)
		{
			return 118;
		}
		else if(a == 88 && b == 31)
		{
			return 119;
		}
		else if(a == 88 && b == 32)
		{
			return 120;
		}
		else if(a == 88 && b == 33)
		{
			return 121;
		}
		else if(a == 88 && b == 34)
		{
			return 122;
		}
		else if(a == 88 && b == 35)
		{
			return 123;
		}
		else if(a == 88 && b == 36)
		{
			return 124;
		}
		else if(a == 88 && b == 37)
		{
			return 125;
		}
		else if(a == 88 && b == 38)
		{
			return 126;
		}
		else if(a == 88 && b == 39)
		{
			return 127;
		}
		else if(a == 88 && b == 40)
		{
			return 128;
		}
		else if(a == 88 && b == 41)
		{
			return 129;
		}
		else if(a == 88 && b == 42)
		{
			return 130;
		}
		else if(a == 88 && b == 43)
		{
			return 131;
		}
		else if(a == 88 && b == 44)
		{
			return 132;
		}
		else if(a == 88 && b == 45)
		{
			return 133;
		}
		else if(a == 88 && b == 46)
		{
			return 134;
		}
		else if(a == 88 && b == 47)
		{
			return 135;
		}
		else if(a == 88 && b == 48)
		{
			return 136;
		}
		else if(a == 88 && b == 49)
		{
			return 137;
		}
		else if(a == 88 && b == 50)
		{
			return 138;
		}
		else if(a == 88 && b == 51)
		{
			return 139;
		}
		else if(a == 88 && b == 52)
		{
			return 140;
		}
		else if(a == 88 && b == 53)
		{
			return 141;
		}
		else if(a == 88 && b == 54)
		{
			return 142;
		}
		else if(a == 88 && b == 55)
		{
			return 143;
		}
		else if(a == 88 && b == 56)
		{
			return 144;
		}
		else if(a == 88 && b == 57)
		{
			return 145;
		}
		else if(a == 88 && b == 58)
		{
			return 146;
		}
		else if(a == 88 && b == 59)
		{
			return 147;
		}
		else if(a == 88 && b == 60)
		{
			return 148;
		}
		else if(a == 88 && b == 61)
		{
			return 149;
		}
		else if(a == 88 && b == 62)
		{
			return 150;
		}
		else if(a == 88 && b == 63)
		{
			return 151;
		}
		else if(a == 88 && b == 64)
		{
			return 152;
		}
		else if(a == 88 && b == 65)
		{
			return 153;
		}
		else if(a == 88 && b == 66)
		{
			return 154;
		}
		else if(a == 88 && b == 67)
		{
			return 155;
		}
		else if(a == 88 && b == 68)
		{
			return 156;
		}
		else if(a == 88 && b == 69)
		{
			return 157;
		}
		else if(a == 88 && b == 70)
		{
			return 158;
		}
		else if(a == 88 && b == 71)
		{
			return 159;
		}
		else if(a == 88 && b == 72)
		{
			return 160;
		}
		else if(a == 88 && b == 73)
		{
			return 161;
		}
		else if(a == 88 && b == 74)
		{
			return 162;
		}
		else if(a == 88 && b == 75)
		{
			return 163;
		}
		else if(a == 88 && b == 76)
		{
			return 164;
		}
		else if(a == 88 && b == 77)
		{
			return 165;
		}
		else if(a == 88 && b == 78)
		{
			return 166;
		}
		else if(a == 88 && b == 79)
		{
			return 167;
		}
		else if(a == 88 && b == 80)
		{
			return 168;
		}
		else if(a == 88 && b == 81)
		{
			return 169;
		}
		else if(a == 88 && b == 82)
		{
			return 170;
		}
		else if(a == 88 && b == 83)
		{
			return 171;
		}
		else if(a == 88 && b == 84)
		{
			return 172;
		}
		else if(a == 88 && b == 85)
		{
			return 173;
		}
		else if(a == 88 && b == 86)
		{
			return 174;
		}
		else if(a == 88 && b == 87)
		{
			return 175;
		}
		else if(a == 88 && b == 88)
		{
			return 176;
		}
		else if(a == 88 && b == 89)
		{
			return 177;
		}
		else if(a == 88 && b == 90)
		{
			return 178;
		}
		else if(a == 88 && b == 91)
		{
			return 179;
		}
		else if(a == 88 && b == 92)
		{
			return 180;
		}
		else if(a == 88 && b == 93)
		{
			return 181;
		}
		else if(a == 88 && b == 94)
		{
			return 182;
		}
		else if(a == 88 && b == 95)
		{
			return 183;
		}
		else if(a == 88 && b == 96)
		{
			return 184;
		}
		else if(a == 88 && b == 97)
		{
			return 185;
		}
		else if(a == 88 && b == 98)
		{
			return 186;
		}
		else if(a == 88 && b == 99)
		{
			return 187;
		}
		else if(a == 88 && b == 100)
		{
			return 188;
		}
		else if(a == 89 && b == 0)
		{
			return 89;
		}
		else if(a == 89 && b == 1)
		{
			return 90;
		}
		else if(a == 89 && b == 2)
		{
			return 91;
		}
		else if(a == 89 && b == 3)
		{
			return 92;
		}
		else if(a == 89 && b == 4)
		{
			return 93;
		}
		else if(a == 89 && b == 5)
		{
			return 94;
		}
		else if(a == 89 && b == 6)
		{
			return 95;
		}
		else if(a == 89 && b == 7)
		{
			return 96;
		}
		else if(a == 89 && b == 8)
		{
			return 97;
		}
		else if(a == 89 && b == 9)
		{
			return 98;
		}
		else if(a == 89 && b == 10)
		{
			return 99;
		}
		else if(a == 89 && b == 11)
		{
			return 100;
		}
		else if(a == 89 && b == 12)
		{
			return 101;
		}
		else if(a == 89 && b == 13)
		{
			return 102;
		}
		else if(a == 89 && b == 14)
		{
			return 103;
		}
		else if(a == 89 && b == 15)
		{
			return 104;
		}
		else if(a == 89 && b == 16)
		{
			return 105;
		}
		else if(a == 89 && b == 17)
		{
			return 106;
		}
		else if(a == 89 && b == 18)
		{
			return 107;
		}
		else if(a == 89 && b == 19)
		{
			return 108;
		}
		else if(a == 89 && b == 20)
		{
			return 109;
		}
		else if(a == 89 && b == 21)
		{
			return 110;
		}
		else if(a == 89 && b == 22)
		{
			return 111;
		}
		else if(a == 89 && b == 23)
		{
			return 112;
		}
		else if(a == 89 && b == 24)
		{
			return 113;
		}
		else if(a == 89 && b == 25)
		{
			return 114;
		}
		else if(a == 89 && b == 26)
		{
			return 115;
		}
		else if(a == 89 && b == 27)
		{
			return 116;
		}
		else if(a == 89 && b == 28)
		{
			return 117;
		}
		else if(a == 89 && b == 29)
		{
			return 118;
		}
		else if(a == 89 && b == 30)
		{
			return 119;
		}
		else if(a == 89 && b == 31)
		{
			return 120;
		}
		else if(a == 89 && b == 32)
		{
			return 121;
		}
		else if(a == 89 && b == 33)
		{
			return 122;
		}
		else if(a == 89 && b == 34)
		{
			return 123;
		}
		else if(a == 89 && b == 35)
		{
			return 124;
		}
		else if(a == 89 && b == 36)
		{
			return 125;
		}
		else if(a == 89 && b == 37)
		{
			return 126;
		}
		else if(a == 89 && b == 38)
		{
			return 127;
		}
		else if(a == 89 && b == 39)
		{
			return 128;
		}
		else if(a == 89 && b == 40)
		{
			return 129;
		}
		else if(a == 89 && b == 41)
		{
			return 130;
		}
		else if(a == 89 && b == 42)
		{
			return 131;
		}
		else if(a == 89 && b == 43)
		{
			return 132;
		}
		else if(a == 89 && b == 44)
		{
			return 133;
		}
		else if(a == 89 && b == 45)
		{
			return 134;
		}
		else if(a == 89 && b == 46)
		{
			return 135;
		}
		else if(a == 89 && b == 47)
		{
			return 136;
		}
		else if(a == 89 && b == 48)
		{
			return 137;
		}
		else if(a == 89 && b == 49)
		{
			return 138;
		}
		else if(a == 89 && b == 50)
		{
			return 139;
		}
		else if(a == 89 && b == 51)
		{
			return 140;
		}
		else if(a == 89 && b == 52)
		{
			return 141;
		}
		else if(a == 89 && b == 53)
		{
			return 142;
		}
		else if(a == 89 && b == 54)
		{
			return 143;
		}
		else if(a == 89 && b == 55)
		{
			return 144;
		}
		else if(a == 89 && b == 56)
		{
			return 145;
		}
		else if(a == 89 && b == 57)
		{
			return 146;
		}
		else if(a == 89 && b == 58)
		{
			return 147;
		}
		else if(a == 89 && b == 59)
		{
			return 148;
		}
		else if(a == 89 && b == 60)
		{
			return 149;
		}
		else if(a == 89 && b == 61)
		{
			return 150;
		}
		else if(a == 89 && b == 62)
		{
			return 151;
		}
		else if(a == 89 && b == 63)
		{
			return 152;
		}
		else if(a == 89 && b == 64)
		{
			return 153;
		}
		else if(a == 89 && b == 65)
		{
			return 154;
		}
		else if(a == 89 && b == 66)
		{
			return 155;
		}
		else if(a == 89 && b == 67)
		{
			return 156;
		}
		else if(a == 89 && b == 68)
		{
			return 157;
		}
		else if(a == 89 && b == 69)
		{
			return 158;
		}
		else if(a == 89 && b == 70)
		{
			return 159;
		}
		else if(a == 89 && b == 71)
		{
			return 160;
		}
		else if(a == 89 && b == 72)
		{
			return 161;
		}
		else if(a == 89 && b == 73)
		{
			return 162;
		}
		else if(a == 89 && b == 74)
		{
			return 163;
		}
		else if(a == 89 && b == 75)
		{
			return 164;
		}
		else if(a == 89 && b == 76)
		{
			return 165;
		}
		else if(a == 89 && b == 77)
		{
			return 166;
		}
		else if(a == 89 && b == 78)
		{
			return 167;
		}
		else if(a == 89 && b == 79)
		{
			return 168;
		}
		else if(a == 89 && b == 80)
		{
			return 169;
		}
		else if(a == 89 && b == 81)
		{
			return 170;
		}
		else if(a == 89 && b == 82)
		{
			return 171;
		}
		else if(a == 89 && b == 83)
		{
			return 172;
		}
		else if(a == 89 && b == 84)
		{
			return 173;
		}
		else if(a == 89 && b == 85)
		{
			return 174;
		}
		else if(a == 89 && b == 86)
		{
			return 175;
		}
		else if(a == 89 && b == 87)
		{
			return 176;
		}
		else if(a == 89 && b == 88)
		{
			return 177;
		}
		else if(a == 89 && b == 89)
		{
			return 178;
		}
		else if(a == 89 && b == 90)
		{
			return 179;
		}
		else if(a == 89 && b == 91)
		{
			return 180;
		}
		else if(a == 89 && b == 92)
		{
			return 181;
		}
		else if(a == 89 && b == 93)
		{
			return 182;
		}
		else if(a == 89 && b == 94)
		{
			return 183;
		}
		else if(a == 89 && b == 95)
		{
			return 184;
		}
		else if(a == 89 && b == 96)
		{
			return 185;
		}
		else if(a == 89 && b == 97)
		{
			return 186;
		}
		else if(a == 89 && b == 98)
		{
			return 187;
		}
		else if(a == 89 && b == 99)
		{
			return 188;
		}
		else if(a == 89 && b == 100)
		{
			return 189;
		}
		else if(a == 90 && b == 0)
		{
			return 90;
		}
		else if(a == 90 && b == 1)
		{
			return 91;
		}
		else if(a == 90 && b == 2)
		{
			return 92;
		}
		else if(a == 90 && b == 3)
		{
			return 93;
		}
		else if(a == 90 && b == 4)
		{
			return 94;
		}
		else if(a == 90 && b == 5)
		{
			return 95;
		}
		else if(a == 90 && b == 6)
		{
			return 96;
		}
		else if(a == 90 && b == 7)
		{
			return 97;
		}
		else if(a == 90 && b == 8)
		{
			return 98;
		}
		else if(a == 90 && b == 9)
		{
			return 99;
		}
		else if(a == 90 && b == 10)
		{
			return 100;
		}
		else if(a == 90 && b == 11)
		{
			return 101;
		}
		else if(a == 90 && b == 12)
		{
			return 102;
		}
		else if(a == 90 && b == 13)
		{
			return 103;
		}
		else if(a == 90 && b == 14)
		{
			return 104;
		}
		else if(a == 90 && b == 15)
		{
			return 105;
		}
		else if(a == 90 && b == 16)
		{
			return 106;
		}
		else if(a == 90 && b == 17)
		{
			return 107;
		}
		else if(a == 90 && b == 18)
		{
			return 108;
		}
		else if(a == 90 && b == 19)
		{
			return 109;
		}
		else if(a == 90 && b == 20)
		{
			return 110;
		}
		else if(a == 90 && b == 21)
		{
			return 111;
		}
		else if(a == 90 && b == 22)
		{
			return 112;
		}
		else if(a == 90 && b == 23)
		{
			return 113;
		}
		else if(a == 90 && b == 24)
		{
			return 114;
		}
		else if(a == 90 && b == 25)
		{
			return 115;
		}
		else if(a == 90 && b == 26)
		{
			return 116;
		}
		else if(a == 90 && b == 27)
		{
			return 117;
		}
		else if(a == 90 && b == 28)
		{
			return 118;
		}
		else if(a == 90 && b == 29)
		{
			return 119;
		}
		else if(a == 90 && b == 30)
		{
			return 120;
		}
		else if(a == 90 && b == 31)
		{
			return 121;
		}
		else if(a == 90 && b == 32)
		{
			return 122;
		}
		else if(a == 90 && b == 33)
		{
			return 123;
		}
		else if(a == 90 && b == 34)
		{
			return 124;
		}
		else if(a == 90 && b == 35)
		{
			return 125;
		}
		else if(a == 90 && b == 36)
		{
			return 126;
		}
		else if(a == 90 && b == 37)
		{
			return 127;
		}
		else if(a == 90 && b == 38)
		{
			return 128;
		}
		else if(a == 90 && b == 39)
		{
			return 129;
		}
		else if(a == 90 && b == 40)
		{
			return 130;
		}
		else if(a == 90 && b == 41)
		{
			return 131;
		}
		else if(a == 90 && b == 42)
		{
			return 132;
		}
		else if(a == 90 && b == 43)
		{
			return 133;
		}
		else if(a == 90 && b == 44)
		{
			return 134;
		}
		else if(a == 90 && b == 45)
		{
			return 135;
		}
		else if(a == 90 && b == 46)
		{
			return 136;
		}
		else if(a == 90 && b == 47)
		{
			return 137;
		}
		else if(a == 90 && b == 48)
		{
			return 138;
		}
		else if(a == 90 && b == 49)
		{
			return 139;
		}
		else if(a == 90 && b == 50)
		{
			return 140;
		}
		else if(a == 90 && b == 51)
		{
			return 141;
		}
		else if(a == 90 && b == 52)
		{
			return 142;
		}
		else if(a == 90 && b == 53)
		{
			return 143;
		}
		else if(a == 90 && b == 54)
		{
			return 144;
		}
		else if(a == 90 && b == 55)
		{
			return 145;
		}
		else if(a == 90 && b == 56)
		{
			return 146;
		}
		else if(a == 90 && b == 57)
		{
			return 147;
		}
		else if(a == 90 && b == 58)
		{
			return 148;
		}
		else if(a == 90 && b == 59)
		{
			return 149;
		}
		else if(a == 90 && b == 60)
		{
			return 150;
		}
		else if(a == 90 && b == 61)
		{
			return 151;
		}
		else if(a == 90 && b == 62)
		{
			return 152;
		}
		else if(a == 90 && b == 63)
		{
			return 153;
		}
		else if(a == 90 && b == 64)
		{
			return 154;
		}
		else if(a == 90 && b == 65)
		{
			return 155;
		}
		else if(a == 90 && b == 66)
		{
			return 156;
		}
		else if(a == 90 && b == 67)
		{
			return 157;
		}
		else if(a == 90 && b == 68)
		{
			return 158;
		}
		else if(a == 90 && b == 69)
		{
			return 159;
		}
		else if(a == 90 && b == 70)
		{
			return 160;
		}
		else if(a == 90 && b == 71)
		{
			return 161;
		}
		else if(a == 90 && b == 72)
		{
			return 162;
		}
		else if(a == 90 && b == 73)
		{
			return 163;
		}
		else if(a == 90 && b == 74)
		{
			return 164;
		}
		else if(a == 90 && b == 75)
		{
			return 165;
		}
		else if(a == 90 && b == 76)
		{
			return 166;
		}
		else if(a == 90 && b == 77)
		{
			return 167;
		}
		else if(a == 90 && b == 78)
		{
			return 168;
		}
		else if(a == 90 && b == 79)
		{
			return 169;
		}
		else if(a == 90 && b == 80)
		{
			return 170;
		}
		else if(a == 90 && b == 81)
		{
			return 171;
		}
		else if(a == 90 && b == 82)
		{
			return 172;
		}
		else if(a == 90 && b == 83)
		{
			return 173;
		}
		else if(a == 90 && b == 84)
		{
			return 174;
		}
		else if(a == 90 && b == 85)
		{
			return 175;
		}
		else if(a == 90 && b == 86)
		{
			return 176;
		}
		else if(a == 90 && b == 87)
		{
			return 177;
		}
		else if(a == 90 && b == 88)
		{
			return 178;
		}
		else if(a == 90 && b == 89)
		{
			return 179;
		}
		else if(a == 90 && b == 90)
		{
			return 180;
		}
		else if(a == 90 && b == 91)
		{
			return 181;
		}
		else if(a == 90 && b == 92)
		{
			return 182;
		}
		else if(a == 90 && b == 93)
		{
			return 183;
		}
		else if(a == 90 && b == 94)
		{
			return 184;
		}
		else if(a == 90 && b == 95)
		{
			return 185;
		}
		else if(a == 90 && b == 96)
		{
			return 186;
		}
		else if(a == 90 && b == 97)
		{
			return 187;
		}
		else if(a == 90 && b == 98)
		{
			return 188;
		}
		else if(a == 90 && b == 99)
		{
			return 189;
		}
		else if(a == 90 && b == 100)
		{
			return 190;
		}
		else if(a == 91 && b == 0)
		{
			return 91;
		}
		else if(a == 91 && b == 1)
		{
			return 92;
		}
		else if(a == 91 && b == 2)
		{
			return 93;
		}
		else if(a == 91 && b == 3)
		{
			return 94;
		}
		else if(a == 91 && b == 4)
		{
			return 95;
		}
		else if(a == 91 && b == 5)
		{
			return 96;
		}
		else if(a == 91 && b == 6)
		{
			return 97;
		}
		else if(a == 91 && b == 7)
		{
			return 98;
		}
		else if(a == 91 && b == 8)
		{
			return 99;
		}
		else if(a == 91 && b == 9)
		{
			return 100;
		}
		else if(a == 91 && b == 10)
		{
			return 101;
		}
		else if(a == 91 && b == 11)
		{
			return 102;
		}
		else if(a == 91 && b == 12)
		{
			return 103;
		}
		else if(a == 91 && b == 13)
		{
			return 104;
		}
		else if(a == 91 && b == 14)
		{
			return 105;
		}
		else if(a == 91 && b == 15)
		{
			return 106;
		}
		else if(a == 91 && b == 16)
		{
			return 107;
		}
		else if(a == 91 && b == 17)
		{
			return 108;
		}
		else if(a == 91 && b == 18)
		{
			return 109;
		}
		else if(a == 91 && b == 19)
		{
			return 110;
		}
		else if(a == 91 && b == 20)
		{
			return 111;
		}
		else if(a == 91 && b == 21)
		{
			return 112;
		}
		else if(a == 91 && b == 22)
		{
			return 113;
		}
		else if(a == 91 && b == 23)
		{
			return 114;
		}
		else if(a == 91 && b == 24)
		{
			return 115;
		}
		else if(a == 91 && b == 25)
		{
			return 116;
		}
		else if(a == 91 && b == 26)
		{
			return 117;
		}
		else if(a == 91 && b == 27)
		{
			return 118;
		}
		else if(a == 91 && b == 28)
		{
			return 119;
		}
		else if(a == 91 && b == 29)
		{
			return 120;
		}
		else if(a == 91 && b == 30)
		{
			return 121;
		}
		else if(a == 91 && b == 31)
		{
			return 122;
		}
		else if(a == 91 && b == 32)
		{
			return 123;
		}
		else if(a == 91 && b == 33)
		{
			return 124;
		}
		else if(a == 91 && b == 34)
		{
			return 125;
		}
		else if(a == 91 && b == 35)
		{
			return 126;
		}
		else if(a == 91 && b == 36)
		{
			return 127;
		}
		else if(a == 91 && b == 37)
		{
			return 128;
		}
		else if(a == 91 && b == 38)
		{
			return 129;
		}
		else if(a == 91 && b == 39)
		{
			return 130;
		}
		else if(a == 91 && b == 40)
		{
			return 131;
		}
		else if(a == 91 && b == 41)
		{
			return 132;
		}
		else if(a == 91 && b == 42)
		{
			return 133;
		}
		else if(a == 91 && b == 43)
		{
			return 134;
		}
		else if(a == 91 && b == 44)
		{
			return 135;
		}
		else if(a == 91 && b == 45)
		{
			return 136;
		}
		else if(a == 91 && b == 46)
		{
			return 137;
		}
		else if(a == 91 && b == 47)
		{
			return 138;
		}
		else if(a == 91 && b == 48)
		{
			return 139;
		}
		else if(a == 91 && b == 49)
		{
			return 140;
		}
		else if(a == 91 && b == 50)
		{
			return 141;
		}
		else if(a == 91 && b == 51)
		{
			return 142;
		}
		else if(a == 91 && b == 52)
		{
			return 143;
		}
		else if(a == 91 && b == 53)
		{
			return 144;
		}
		else if(a == 91 && b == 54)
		{
			return 145;
		}
		else if(a == 91 && b == 55)
		{
			return 146;
		}
		else if(a == 91 && b == 56)
		{
			return 147;
		}
		else if(a == 91 && b == 57)
		{
			return 148;
		}
		else if(a == 91 && b == 58)
		{
			return 149;
		}
		else if(a == 91 && b == 59)
		{
			return 150;
		}
		else if(a == 91 && b == 60)
		{
			return 151;
		}
		else if(a == 91 && b == 61)
		{
			return 152;
		}
		else if(a == 91 && b == 62)
		{
			return 153;
		}
		else if(a == 91 && b == 63)
		{
			return 154;
		}
		else if(a == 91 && b == 64)
		{
			return 155;
		}
		else if(a == 91 && b == 65)
		{
			return 156;
		}
		else if(a == 91 && b == 66)
		{
			return 157;
		}
		else if(a == 91 && b == 67)
		{
			return 158;
		}
		else if(a == 91 && b == 68)
		{
			return 159;
		}
		else if(a == 91 && b == 69)
		{
			return 160;
		}
		else if(a == 91 && b == 70)
		{
			return 161;
		}
		else if(a == 91 && b == 71)
		{
			return 162;
		}
		else if(a == 91 && b == 72)
		{
			return 163;
		}
		else if(a == 91 && b == 73)
		{
			return 164;
		}
		else if(a == 91 && b == 74)
		{
			return 165;
		}
		else if(a == 91 && b == 75)
		{
			return 166;
		}
		else if(a == 91 && b == 76)
		{
			return 167;
		}
		else if(a == 91 && b == 77)
		{
			return 168;
		}
		else if(a == 91 && b == 78)
		{
			return 169;
		}
		else if(a == 91 && b == 79)
		{
			return 170;
		}
		else if(a == 91 && b == 80)
		{
			return 171;
		}
		else if(a == 91 && b == 81)
		{
			return 172;
		}
		else if(a == 91 && b == 82)
		{
			return 173;
		}
		else if(a == 91 && b == 83)
		{
			return 174;
		}
		else if(a == 91 && b == 84)
		{
			return 175;
		}
		else if(a == 91 && b == 85)
		{
			return 176;
		}
		else if(a == 91 && b == 86)
		{
			return 177;
		}
		else if(a == 91 && b == 87)
		{
			return 178;
		}
		else if(a == 91 && b == 88)
		{
			return 179;
		}
		else if(a == 91 && b == 89)
		{
			return 180;
		}
		else if(a == 91 && b == 90)
		{
			return 181;
		}
		else if(a == 91 && b == 91)
		{
			return 182;
		}
		else if(a == 91 && b == 92)
		{
			return 183;
		}
		else if(a == 91 && b == 93)
		{
			return 184;
		}
		else if(a == 91 && b == 94)
		{
			return 185;
		}
		else if(a == 91 && b == 95)
		{
			return 186;
		}
		else if(a == 91 && b == 96)
		{
			return 187;
		}
		else if(a == 91 && b == 97)
		{
			return 188;
		}
		else if(a == 91 && b == 98)
		{
			return 189;
		}
		else if(a == 91 && b == 99)
		{
			return 190;
		}
		else if(a == 91 && b == 100)
		{
			return 191;
		}
		else if(a == 92 && b == 0)
		{
			return 92;
		}
		else if(a == 92 && b == 1)
		{
			return 93;
		}
		else if(a == 92 && b == 2)
		{
			return 94;
		}
		else if(a == 92 && b == 3)
		{
			return 95;
		}
		else if(a == 92 && b == 4)
		{
			return 96;
		}
		else if(a == 92 && b == 5)
		{
			return 97;
		}
		else if(a == 92 && b == 6)
		{
			return 98;
		}
		else if(a == 92 && b == 7)
		{
			return 99;
		}
		else if(a == 92 && b == 8)
		{
			return 100;
		}
		else if(a == 92 && b == 9)
		{
			return 101;
		}
		else if(a == 92 && b == 10)
		{
			return 102;
		}
		else if(a == 92 && b == 11)
		{
			return 103;
		}
		else if(a == 92 && b == 12)
		{
			return 104;
		}
		else if(a == 92 && b == 13)
		{
			return 105;
		}
		else if(a == 92 && b == 14)
		{
			return 106;
		}
		else if(a == 92 && b == 15)
		{
			return 107;
		}
		else if(a == 92 && b == 16)
		{
			return 108;
		}
		else if(a == 92 && b == 17)
		{
			return 109;
		}
		else if(a == 92 && b == 18)
		{
			return 110;
		}
		else if(a == 92 && b == 19)
		{
			return 111;
		}
		else if(a == 92 && b == 20)
		{
			return 112;
		}
		else if(a == 92 && b == 21)
		{
			return 113;
		}
		else if(a == 92 && b == 22)
		{
			return 114;
		}
		else if(a == 92 && b == 23)
		{
			return 115;
		}
		else if(a == 92 && b == 24)
		{
			return 116;
		}
		else if(a == 92 && b == 25)
		{
			return 117;
		}
		else if(a == 92 && b == 26)
		{
			return 118;
		}
		else if(a == 92 && b == 27)
		{
			return 119;
		}
		else if(a == 92 && b == 28)
		{
			return 120;
		}
		else if(a == 92 && b == 29)
		{
			return 121;
		}
		else if(a == 92 && b == 30)
		{
			return 122;
		}
		else if(a == 92 && b == 31)
		{
			return 123;
		}
		else if(a == 92 && b == 32)
		{
			return 124;
		}
		else if(a == 92 && b == 33)
		{
			return 125;
		}
		else if(a == 92 && b == 34)
		{
			return 126;
		}
		else if(a == 92 && b == 35)
		{
			return 127;
		}
		else if(a == 92 && b == 36)
		{
			return 128;
		}
		else if(a == 92 && b == 37)
		{
			return 129;
		}
		else if(a == 92 && b == 38)
		{
			return 130;
		}
		else if(a == 92 && b == 39)
		{
			return 131;
		}
		else if(a == 92 && b == 40)
		{
			return 132;
		}
		else if(a == 92 && b == 41)
		{
			return 133;
		}
		else if(a == 92 && b == 42)
		{
			return 134;
		}
		else if(a == 92 && b == 43)
		{
			return 135;
		}
		else if(a == 92 && b == 44)
		{
			return 136;
		}
		else if(a == 92 && b == 45)
		{
			return 137;
		}
		else if(a == 92 && b == 46)
		{
			return 138;
		}
		else if(a == 92 && b == 47)
		{
			return 139;
		}
		else if(a == 92 && b == 48)
		{
			return 140;
		}
		else if(a == 92 && b == 49)
		{
			return 141;
		}
		else if(a == 92 && b == 50)
		{
			return 142;
		}
		else if(a == 92 && b == 51)
		{
			return 143;
		}
		else if(a == 92 && b == 52)
		{
			return 144;
		}
		else if(a == 92 && b == 53)
		{
			return 145;
		}
		else if(a == 92 && b == 54)
		{
			return 146;
		}
		else if(a == 92 && b == 55)
		{
			return 147;
		}
		else if(a == 92 && b == 56)
		{
			return 148;
		}
		else if(a == 92 && b == 57)
		{
			return 149;
		}
		else if(a == 92 && b == 58)
		{
			return 150;
		}
		else if(a == 92 && b == 59)
		{
			return 151;
		}
		else if(a == 92 && b == 60)
		{
			return 152;
		}
		else if(a == 92 && b == 61)
		{
			return 153;
		}
		else if(a == 92 && b == 62)
		{
			return 154;
		}
		else if(a == 92 && b == 63)
		{
			return 155;
		}
		else if(a == 92 && b == 64)
		{
			return 156;
		}
		else if(a == 92 && b == 65)
		{
			return 157;
		}
		else if(a == 92 && b == 66)
		{
			return 158;
		}
		else if(a == 92 && b == 67)
		{
			return 159;
		}
		else if(a == 92 && b == 68)
		{
			return 160;
		}
		else if(a == 92 && b == 69)
		{
			return 161;
		}
		else if(a == 92 && b == 70)
		{
			return 162;
		}
		else if(a == 92 && b == 71)
		{
			return 163;
		}
		else if(a == 92 && b == 72)
		{
			return 164;
		}
		else if(a == 92 && b == 73)
		{
			return 165;
		}
		else if(a == 92 && b == 74)
		{
			return 166;
		}
		else if(a == 92 && b == 75)
		{
			return 167;
		}
		else if(a == 92 && b == 76)
		{
			return 168;
		}
		else if(a == 92 && b == 77)
		{
			return 169;
		}
		else if(a == 92 && b == 78)
		{
			return 170;
		}
		else if(a == 92 && b == 79)
		{
			return 171;
		}
		else if(a == 92 && b == 80)
		{
			return 172;
		}
		else if(a == 92 && b == 81)
		{
			return 173;
		}
		else if(a == 92 && b == 82)
		{
			return 174;
		}
		else if(a == 92 && b == 83)
		{
			return 175;
		}
		else if(a == 92 && b == 84)
		{
			return 176;
		}
		else if(a == 92 && b == 85)
		{
			return 177;
		}
		else if(a == 92 && b == 86)
		{
			return 178;
		}
		else if(a == 92 && b == 87)
		{
			return 179;
		}
		else if(a == 92 && b == 88)
		{
			return 180;
		}
		else if(a == 92 && b == 89)
		{
			return 181;
		}
		else if(a == 92 && b == 90)
		{
			return 182;
		}
		else if(a == 92 && b == 91)
		{
			return 183;
		}
		else if(a == 92 && b == 92)
		{
			return 184;
		}
		else if(a == 92 && b == 93)
		{
			return 185;
		}
		else if(a == 92 && b == 94)
		{
			return 186;
		}
		else if(a == 92 && b == 95)
		{
			return 187;
		}
		else if(a == 92 && b == 96)
		{
			return 188;
		}
		else if(a == 92 && b == 97)
		{
			return 189;
		}
		else if(a == 92 && b == 98)
		{
			return 190;
		}
		else if(a == 92 && b == 99)
		{
			return 191;
		}
		else if(a == 92 && b == 100)
		{
			return 192;
		}
		else if(a == 93 && b == 0)
		{
			return 93;
		}
		else if(a == 93 && b == 1)
		{
			return 94;
		}
		else if(a == 93 && b == 2)
		{
			return 95;
		}
		else if(a == 93 && b == 3)
		{
			return 96;
		}
		else if(a == 93 && b == 4)
		{
			return 97;
		}
		else if(a == 93 && b == 5)
		{
			return 98;
		}
		else if(a == 93 && b == 6)
		{
			return 99;
		}
		else if(a == 93 && b == 7)
		{
			return 100;
		}
		else if(a == 93 && b == 8)
		{
			return 101;
		}
		else if(a == 93 && b == 9)
		{
			return 102;
		}
		else if(a == 93 && b == 10)
		{
			return 103;
		}
		else if(a == 93 && b == 11)
		{
			return 104;
		}
		else if(a == 93 && b == 12)
		{
			return 105;
		}
		else if(a == 93 && b == 13)
		{
			return 106;
		}
		else if(a == 93 && b == 14)
		{
			return 107;
		}
		else if(a == 93 && b == 15)
		{
			return 108;
		}
		else if(a == 93 && b == 16)
		{
			return 109;
		}
		else if(a == 93 && b == 17)
		{
			return 110;
		}
		else if(a == 93 && b == 18)
		{
			return 111;
		}
		else if(a == 93 && b == 19)
		{
			return 112;
		}
		else if(a == 93 && b == 20)
		{
			return 113;
		}
		else if(a == 93 && b == 21)
		{
			return 114;
		}
		else if(a == 93 && b == 22)
		{
			return 115;
		}
		else if(a == 93 && b == 23)
		{
			return 116;
		}
		else if(a == 93 && b == 24)
		{
			return 117;
		}
		else if(a == 93 && b == 25)
		{
			return 118;
		}
		else if(a == 93 && b == 26)
		{
			return 119;
		}
		else if(a == 93 && b == 27)
		{
			return 120;
		}
		else if(a == 93 && b == 28)
		{
			return 121;
		}
		else if(a == 93 && b == 29)
		{
			return 122;
		}
		else if(a == 93 && b == 30)
		{
			return 123;
		}
		else if(a == 93 && b == 31)
		{
			return 124;
		}
		else if(a == 93 && b == 32)
		{
			return 125;
		}
		else if(a == 93 && b == 33)
		{
			return 126;
		}
		else if(a == 93 && b == 34)
		{
			return 127;
		}
		else if(a == 93 && b == 35)
		{
			return 128;
		}
		else if(a == 93 && b == 36)
		{
			return 129;
		}
		else if(a == 93 && b == 37)
		{
			return 130;
		}
		else if(a == 93 && b == 38)
		{
			return 131;
		}
		else if(a == 93 && b == 39)
		{
			return 132;
		}
		else if(a == 93 && b == 40)
		{
			return 133;
		}
		else if(a == 93 && b == 41)
		{
			return 134;
		}
		else if(a == 93 && b == 42)
		{
			return 135;
		}
		else if(a == 93 && b == 43)
		{
			return 136;
		}
		else if(a == 93 && b == 44)
		{
			return 137;
		}
		else if(a == 93 && b == 45)
		{
			return 138;
		}
		else if(a == 93 && b == 46)
		{
			return 139;
		}
		else if(a == 93 && b == 47)
		{
			return 140;
		}
		else if(a == 93 && b == 48)
		{
			return 141;
		}
		else if(a == 93 && b == 49)
		{
			return 142;
		}
		else if(a == 93 && b == 50)
		{
			return 143;
		}
		else if(a == 93 && b == 51)
		{
			return 144;
		}
		else if(a == 93 && b == 52)
		{
			return 145;
		}
		else if(a == 93 && b == 53)
		{
			return 146;
		}
		else if(a == 93 && b == 54)
		{
			return 147;
		}
		else if(a == 93 && b == 55)
		{
			return 148;
		}
		else if(a == 93 && b == 56)
		{
			return 149;
		}
		else if(a == 93 && b == 57)
		{
			return 150;
		}
		else if(a == 93 && b == 58)
		{
			return 151;
		}
		else if(a == 93 && b == 59)
		{
			return 152;
		}
		else if(a == 93 && b == 60)
		{
			return 153;
		}
		else if(a == 93 && b == 61)
		{
			return 154;
		}
		else if(a == 93 && b == 62)
		{
			return 155;
		}
		else if(a == 93 && b == 63)
		{
			return 156;
		}
		else if(a == 93 && b == 64)
		{
			return 157;
		}
		else if(a == 93 && b == 65)
		{
			return 158;
		}
		else if(a == 93 && b == 66)
		{
			return 159;
		}
		else if(a == 93 && b == 67)
		{
			return 160;
		}
		else if(a == 93 && b == 68)
		{
			return 161;
		}
		else if(a == 93 && b == 69)
		{
			return 162;
		}
		else if(a == 93 && b == 70)
		{
			return 163;
		}
		else if(a == 93 && b == 71)
		{
			return 164;
		}
		else if(a == 93 && b == 72)
		{
			return 165;
		}
		else if(a == 93 && b == 73)
		{
			return 166;
		}
		else if(a == 93 && b == 74)
		{
			return 167;
		}
		else if(a == 93 && b == 75)
		{
			return 168;
		}
		else if(a == 93 && b == 76)
		{
			return 169;
		}
		else if(a == 93 && b == 77)
		{
			return 170;
		}
		else if(a == 93 && b == 78)
		{
			return 171;
		}
		else if(a == 93 && b == 79)
		{
			return 172;
		}
		else if(a == 93 && b == 80)
		{
			return 173;
		}
		else if(a == 93 && b == 81)
		{
			return 174;
		}
		else if(a == 93 && b == 82)
		{
			return 175;
		}
		else if(a == 93 && b == 83)
		{
			return 176;
		}
		else if(a == 93 && b == 84)
		{
			return 177;
		}
		else if(a == 93 && b == 85)
		{
			return 178;
		}
		else if(a == 93 && b == 86)
		{
			return 179;
		}
		else if(a == 93 && b == 87)
		{
			return 180;
		}
		else if(a == 93 && b == 88)
		{
			return 181;
		}
		else if(a == 93 && b == 89)
		{
			return 182;
		}
		else if(a == 93 && b == 90)
		{
			return 183;
		}
		else if(a == 93 && b == 91)
		{
			return 184;
		}
		else if(a == 93 && b == 92)
		{
			return 185;
		}
		else if(a == 93 && b == 93)
		{
			return 186;
		}
		else if(a == 93 && b == 94)
		{
			return 187;
		}
		else if(a == 93 && b == 95)
		{
			return 188;
		}
		else if(a == 93 && b == 96)
		{
			return 189;
		}
		else if(a == 93 && b == 97)
		{
			return 190;
		}
		else if(a == 93 && b == 98)
		{
			return 191;
		}
		else if(a == 93 && b == 99)
		{
			return 192;
		}
		else if(a == 93 && b == 100)
		{
			return 193;
		}
		else if(a == 94 && b == 0)
		{
			return 94;
		}
		else if(a == 94 && b == 1)
		{
			return 95;
		}
		else if(a == 94 && b == 2)
		{
			return 96;
		}
		else if(a == 94 && b == 3)
		{
			return 97;
		}
		else if(a == 94 && b == 4)
		{
			return 98;
		}
		else if(a == 94 && b == 5)
		{
			return 99;
		}
		else if(a == 94 && b == 6)
		{
			return 100;
		}
		else if(a == 94 && b == 7)
		{
			return 101;
		}
		else if(a == 94 && b == 8)
		{
			return 102;
		}
		else if(a == 94 && b == 9)
		{
			return 103;
		}
		else if(a == 94 && b == 10)
		{
			return 104;
		}
		else if(a == 94 && b == 11)
		{
			return 105;
		}
		else if(a == 94 && b == 12)
		{
			return 106;
		}
		else if(a == 94 && b == 13)
		{
			return 107;
		}
		else if(a == 94 && b == 14)
		{
			return 108;
		}
		else if(a == 94 && b == 15)
		{
			return 109;
		}
		else if(a == 94 && b == 16)
		{
			return 110;
		}
		else if(a == 94 && b == 17)
		{
			return 111;
		}
		else if(a == 94 && b == 18)
		{
			return 112;
		}
		else if(a == 94 && b == 19)
		{
			return 113;
		}
		else if(a == 94 && b == 20)
		{
			return 114;
		}
		else if(a == 94 && b == 21)
		{
			return 115;
		}
		else if(a == 94 && b == 22)
		{
			return 116;
		}
		else if(a == 94 && b == 23)
		{
			return 117;
		}
		else if(a == 94 && b == 24)
		{
			return 118;
		}
		else if(a == 94 && b == 25)
		{
			return 119;
		}
		else if(a == 94 && b == 26)
		{
			return 120;
		}
		else if(a == 94 && b == 27)
		{
			return 121;
		}
		else if(a == 94 && b == 28)
		{
			return 122;
		}
		else if(a == 94 && b == 29)
		{
			return 123;
		}
		else if(a == 94 && b == 30)
		{
			return 124;
		}
		else if(a == 94 && b == 31)
		{
			return 125;
		}
		else if(a == 94 && b == 32)
		{
			return 126;
		}
		else if(a == 94 && b == 33)
		{
			return 127;
		}
		else if(a == 94 && b == 34)
		{
			return 128;
		}
		else if(a == 94 && b == 35)
		{
			return 129;
		}
		else if(a == 94 && b == 36)
		{
			return 130;
		}
		else if(a == 94 && b == 37)
		{
			return 131;
		}
		else if(a == 94 && b == 38)
		{
			return 132;
		}
		else if(a == 94 && b == 39)
		{
			return 133;
		}
		else if(a == 94 && b == 40)
		{
			return 134;
		}
		else if(a == 94 && b == 41)
		{
			return 135;
		}
		else if(a == 94 && b == 42)
		{
			return 136;
		}
		else if(a == 94 && b == 43)
		{
			return 137;
		}
		else if(a == 94 && b == 44)
		{
			return 138;
		}
		else if(a == 94 && b == 45)
		{
			return 139;
		}
		else if(a == 94 && b == 46)
		{
			return 140;
		}
		else if(a == 94 && b == 47)
		{
			return 141;
		}
		else if(a == 94 && b == 48)
		{
			return 142;
		}
		else if(a == 94 && b == 49)
		{
			return 143;
		}
		else if(a == 94 && b == 50)
		{
			return 144;
		}
		else if(a == 94 && b == 51)
		{
			return 145;
		}
		else if(a == 94 && b == 52)
		{
			return 146;
		}
		else if(a == 94 && b == 53)
		{
			return 147;
		}
		else if(a == 94 && b == 54)
		{
			return 148;
		}
		else if(a == 94 && b == 55)
		{
			return 149;
		}
		else if(a == 94 && b == 56)
		{
			return 150;
		}
		else if(a == 94 && b == 57)
		{
			return 151;
		}
		else if(a == 94 && b == 58)
		{
			return 152;
		}
		else if(a == 94 && b == 59)
		{
			return 153;
		}
		else if(a == 94 && b == 60)
		{
			return 154;
		}
		else if(a == 94 && b == 61)
		{
			return 155;
		}
		else if(a == 94 && b == 62)
		{
			return 156;
		}
		else if(a == 94 && b == 63)
		{
			return 157;
		}
		else if(a == 94 && b == 64)
		{
			return 158;
		}
		else if(a == 94 && b == 65)
		{
			return 159;
		}
		else if(a == 94 && b == 66)
		{
			return 160;
		}
		else if(a == 94 && b == 67)
		{
			return 161;
		}
		else if(a == 94 && b == 68)
		{
			return 162;
		}
		else if(a == 94 && b == 69)
		{
			return 163;
		}
		else if(a == 94 && b == 70)
		{
			return 164;
		}
		else if(a == 94 && b == 71)
		{
			return 165;
		}
		else if(a == 94 && b == 72)
		{
			return 166;
		}
		else if(a == 94 && b == 73)
		{
			return 167;
		}
		else if(a == 94 && b == 74)
		{
			return 168;
		}
		else if(a == 94 && b == 75)
		{
			return 169;
		}
		else if(a == 94 && b == 76)
		{
			return 170;
		}
		else if(a == 94 && b == 77)
		{
			return 171;
		}
		else if(a == 94 && b == 78)
		{
			return 172;
		}
		else if(a == 94 && b == 79)
		{
			return 173;
		}
		else if(a == 94 && b == 80)
		{
			return 174;
		}
		else if(a == 94 && b == 81)
		{
			return 175;
		}
		else if(a == 94 && b == 82)
		{
			return 176;
		}
		else if(a == 94 && b == 83)
		{
			return 177;
		}
		else if(a == 94 && b == 84)
		{
			return 178;
		}
		else if(a == 94 && b == 85)
		{
			return 179;
		}
		else if(a == 94 && b == 86)
		{
			return 180;
		}
		else if(a == 94 && b == 87)
		{
			return 181;
		}
		else if(a == 94 && b == 88)
		{
			return 182;
		}
		else if(a == 94 && b == 89)
		{
			return 183;
		}
		else if(a == 94 && b == 90)
		{
			return 184;
		}
		else if(a == 94 && b == 91)
		{
			return 185;
		}
		else if(a == 94 && b == 92)
		{
			return 186;
		}
		else if(a == 94 && b == 93)
		{
			return 187;
		}
		else if(a == 94 && b == 94)
		{
			return 188;
		}
		else if(a == 94 && b == 95)
		{
			return 189;
		}
		else if(a == 94 && b == 96)
		{
			return 190;
		}
		else if(a == 94 && b == 97)
		{
			return 191;
		}
		else if(a == 94 && b == 98)
		{
			return 192;
		}
		else if(a == 94 && b == 99)
		{
			return 193;
		}
		else if(a == 94 && b == 100)
		{
			return 194;
		}
		else if(a == 95 && b == 0)
		{
			return 95;
		}
		else if(a == 95 && b == 1)
		{
			return 96;
		}
		else if(a == 95 && b == 2)
		{
			return 97;
		}
		else if(a == 95 && b == 3)
		{
			return 98;
		}
		else if(a == 95 && b == 4)
		{
			return 99;
		}
		else if(a == 95 && b == 5)
		{
			return 100;
		}
		else if(a == 95 && b == 6)
		{
			return 101;
		}
		else if(a == 95 && b == 7)
		{
			return 102;
		}
		else if(a == 95 && b == 8)
		{
			return 103;
		}
		else if(a == 95 && b == 9)
		{
			return 104;
		}
		else if(a == 95 && b == 10)
		{
			return 105;
		}
		else if(a == 95 && b == 11)
		{
			return 106;
		}
		else if(a == 95 && b == 12)
		{
			return 107;
		}
		else if(a == 95 && b == 13)
		{
			return 108;
		}
		else if(a == 95 && b == 14)
		{
			return 109;
		}
		else if(a == 95 && b == 15)
		{
			return 110;
		}
		else if(a == 95 && b == 16)
		{
			return 111;
		}
		else if(a == 95 && b == 17)
		{
			return 112;
		}
		else if(a == 95 && b == 18)
		{
			return 113;
		}
		else if(a == 95 && b == 19)
		{
			return 114;
		}
		else if(a == 95 && b == 20)
		{
			return 115;
		}
		else if(a == 95 && b == 21)
		{
			return 116;
		}
		else if(a == 95 && b == 22)
		{
			return 117;
		}
		else if(a == 95 && b == 23)
		{
			return 118;
		}
		else if(a == 95 && b == 24)
		{
			return 119;
		}
		else if(a == 95 && b == 25)
		{
			return 120;
		}
		else if(a == 95 && b == 26)
		{
			return 121;
		}
		else if(a == 95 && b == 27)
		{
			return 122;
		}
		else if(a == 95 && b == 28)
		{
			return 123;
		}
		else if(a == 95 && b == 29)
		{
			return 124;
		}
		else if(a == 95 && b == 30)
		{
			return 125;
		}
		else if(a == 95 && b == 31)
		{
			return 126;
		}
		else if(a == 95 && b == 32)
		{
			return 127;
		}
		else if(a == 95 && b == 33)
		{
			return 128;
		}
		else if(a == 95 && b == 34)
		{
			return 129;
		}
		else if(a == 95 && b == 35)
		{
			return 130;
		}
		else if(a == 95 && b == 36)
		{
			return 131;
		}
		else if(a == 95 && b == 37)
		{
			return 132;
		}
		else if(a == 95 && b == 38)
		{
			return 133;
		}
		else if(a == 95 && b == 39)
		{
			return 134;
		}
		else if(a == 95 && b == 40)
		{
			return 135;
		}
		else if(a == 95 && b == 41)
		{
			return 136;
		}
		else if(a == 95 && b == 42)
		{
			return 137;
		}
		else if(a == 95 && b == 43)
		{
			return 138;
		}
		else if(a == 95 && b == 44)
		{
			return 139;
		}
		else if(a == 95 && b == 45)
		{
			return 140;
		}
		else if(a == 95 && b == 46)
		{
			return 141;
		}
		else if(a == 95 && b == 47)
		{
			return 142;
		}
		else if(a == 95 && b == 48)
		{
			return 143;
		}
		else if(a == 95 && b == 49)
		{
			return 144;
		}
		else if(a == 95 && b == 50)
		{
			return 145;
		}
		else if(a == 95 && b == 51)
		{
			return 146;
		}
		else if(a == 95 && b == 52)
		{
			return 147;
		}
		else if(a == 95 && b == 53)
		{
			return 148;
		}
		else if(a == 95 && b == 54)
		{
			return 149;
		}
		else if(a == 95 && b == 55)
		{
			return 150;
		}
		else if(a == 95 && b == 56)
		{
			return 151;
		}
		else if(a == 95 && b == 57)
		{
			return 152;
		}
		else if(a == 95 && b == 58)
		{
			return 153;
		}
		else if(a == 95 && b == 59)
		{
			return 154;
		}
		else if(a == 95 && b == 60)
		{
			return 155;
		}
		else if(a == 95 && b == 61)
		{
			return 156;
		}
		else if(a == 95 && b == 62)
		{
			return 157;
		}
		else if(a == 95 && b == 63)
		{
			return 158;
		}
		else if(a == 95 && b == 64)
		{
			return 159;
		}
		else if(a == 95 && b == 65)
		{
			return 160;
		}
		else if(a == 95 && b == 66)
		{
			return 161;
		}
		else if(a == 95 && b == 67)
		{
			return 162;
		}
		else if(a == 95 && b == 68)
		{
			return 163;
		}
		else if(a == 95 && b == 69)
		{
			return 164;
		}
		else if(a == 95 && b == 70)
		{
			return 165;
		}
		else if(a == 95 && b == 71)
		{
			return 166;
		}
		else if(a == 95 && b == 72)
		{
			return 167;
		}
		else if(a == 95 && b == 73)
		{
			return 168;
		}
		else if(a == 95 && b == 74)
		{
			return 169;
		}
		else if(a == 95 && b == 75)
		{
			return 170;
		}
		else if(a == 95 && b == 76)
		{
			return 171;
		}
		else if(a == 95 && b == 77)
		{
			return 172;
		}
		else if(a == 95 && b == 78)
		{
			return 173;
		}
		else if(a == 95 && b == 79)
		{
			return 174;
		}
		else if(a == 95 && b == 80)
		{
			return 175;
		}
		else if(a == 95 && b == 81)
		{
			return 176;
		}
		else if(a == 95 && b == 82)
		{
			return 177;
		}
		else if(a == 95 && b == 83)
		{
			return 178;
		}
		else if(a == 95 && b == 84)
		{
			return 179;
		}
		else if(a == 95 && b == 85)
		{
			return 180;
		}
		else if(a == 95 && b == 86)
		{
			return 181;
		}
		else if(a == 95 && b == 87)
		{
			return 182;
		}
		else if(a == 95 && b == 88)
		{
			return 183;
		}
		else if(a == 95 && b == 89)
		{
			return 184;
		}
		else if(a == 95 && b == 90)
		{
			return 185;
		}
		else if(a == 95 && b == 91)
		{
			return 186;
		}
		else if(a == 95 && b == 92)
		{
			return 187;
		}
		else if(a == 95 && b == 93)
		{
			return 188;
		}
		else if(a == 95 && b == 94)
		{
			return 189;
		}
		else if(a == 95 && b == 95)
		{
			return 190;
		}
		else if(a == 95 && b == 96)
		{
			return 191;
		}
		else if(a == 95 && b == 97)
		{
			return 192;
		}
		else if(a == 95 && b == 98)
		{
			return 193;
		}
		else if(a == 95 && b == 99)
		{
			return 194;
		}
		else if(a == 95 && b == 100)
		{
			return 195;
		}
		else if(a == 96 && b == 0)
		{
			return 96;
		}
		else if(a == 96 && b == 1)
		{
			return 97;
		}
		else if(a == 96 && b == 2)
		{
			return 98;
		}
		else if(a == 96 && b == 3)
		{
			return 99;
		}
		else if(a == 96 && b == 4)
		{
			return 100;
		}
		else if(a == 96 && b == 5)
		{
			return 101;
		}
		else if(a == 96 && b == 6)
		{
			return 102;
		}
		else if(a == 96 && b == 7)
		{
			return 103;
		}
		else if(a == 96 && b == 8)
		{
			return 104;
		}
		else if(a == 96 && b == 9)
		{
			return 105;
		}
		else if(a == 96 && b == 10)
		{
			return 106;
		}
		else if(a == 96 && b == 11)
		{
			return 107;
		}
		else if(a == 96 && b == 12)
		{
			return 108;
		}
		else if(a == 96 && b == 13)
		{
			return 109;
		}
		else if(a == 96 && b == 14)
		{
			return 110;
		}
		else if(a == 96 && b == 15)
		{
			return 111;
		}
		else if(a == 96 && b == 16)
		{
			return 112;
		}
		else if(a == 96 && b == 17)
		{
			return 113;
		}
		else if(a == 96 && b == 18)
		{
			return 114;
		}
		else if(a == 96 && b == 19)
		{
			return 115;
		}
		else if(a == 96 && b == 20)
		{
			return 116;
		}
		else if(a == 96 && b == 21)
		{
			return 117;
		}
		else if(a == 96 && b == 22)
		{
			return 118;
		}
		else if(a == 96 && b == 23)
		{
			return 119;
		}
		else if(a == 96 && b == 24)
		{
			return 120;
		}
		else if(a == 96 && b == 25)
		{
			return 121;
		}
		else if(a == 96 && b == 26)
		{
			return 122;
		}
		else if(a == 96 && b == 27)
		{
			return 123;
		}
		else if(a == 96 && b == 28)
		{
			return 124;
		}
		else if(a == 96 && b == 29)
		{
			return 125;
		}
		else if(a == 96 && b == 30)
		{
			return 126;
		}
		else if(a == 96 && b == 31)
		{
			return 127;
		}
		else if(a == 96 && b == 32)
		{
			return 128;
		}
		else if(a == 96 && b == 33)
		{
			return 129;
		}
		else if(a == 96 && b == 34)
		{
			return 130;
		}
		else if(a == 96 && b == 35)
		{
			return 131;
		}
		else if(a == 96 && b == 36)
		{
			return 132;
		}
		else if(a == 96 && b == 37)
		{
			return 133;
		}
		else if(a == 96 && b == 38)
		{
			return 134;
		}
		else if(a == 96 && b == 39)
		{
			return 135;
		}
		else if(a == 96 && b == 40)
		{
			return 136;
		}
		else if(a == 96 && b == 41)
		{
			return 137;
		}
		else if(a == 96 && b == 42)
		{
			return 138;
		}
		else if(a == 96 && b == 43)
		{
			return 139;
		}
		else if(a == 96 && b == 44)
		{
			return 140;
		}
		else if(a == 96 && b == 45)
		{
			return 141;
		}
		else if(a == 96 && b == 46)
		{
			return 142;
		}
		else if(a == 96 && b == 47)
		{
			return 143;
		}
		else if(a == 96 && b == 48)
		{
			return 144;
		}
		else if(a == 96 && b == 49)
		{
			return 145;
		}
		else if(a == 96 && b == 50)
		{
			return 146;
		}
		else if(a == 96 && b == 51)
		{
			return 147;
		}
		else if(a == 96 && b == 52)
		{
			return 148;
		}
		else if(a == 96 && b == 53)
		{
			return 149;
		}
		else if(a == 96 && b == 54)
		{
			return 150;
		}
		else if(a == 96 && b == 55)
		{
			return 151;
		}
		else if(a == 96 && b == 56)
		{
			return 152;
		}
		else if(a == 96 && b == 57)
		{
			return 153;
		}
		else if(a == 96 && b == 58)
		{
			return 154;
		}
		else if(a == 96 && b == 59)
		{
			return 155;
		}
		else if(a == 96 && b == 60)
		{
			return 156;
		}
		else if(a == 96 && b == 61)
		{
			return 157;
		}
		else if(a == 96 && b == 62)
		{
			return 158;
		}
		else if(a == 96 && b == 63)
		{
			return 159;
		}
		else if(a == 96 && b == 64)
		{
			return 160;
		}
		else if(a == 96 && b == 65)
		{
			return 161;
		}
		else if(a == 96 && b == 66)
		{
			return 162;
		}
		else if(a == 96 && b == 67)
		{
			return 163;
		}
		else if(a == 96 && b == 68)
		{
			return 164;
		}
		else if(a == 96 && b == 69)
		{
			return 165;
		}
		else if(a == 96 && b == 70)
		{
			return 166;
		}
		else if(a == 96 && b == 71)
		{
			return 167;
		}
		else if(a == 96 && b == 72)
		{
			return 168;
		}
		else if(a == 96 && b == 73)
		{
			return 169;
		}
		else if(a == 96 && b == 74)
		{
			return 170;
		}
		else if(a == 96 && b == 75)
		{
			return 171;
		}
		else if(a == 96 && b == 76)
		{
			return 172;
		}
		else if(a == 96 && b == 77)
		{
			return 173;
		}
		else if(a == 96 && b == 78)
		{
			return 174;
		}
		else if(a == 96 && b == 79)
		{
			return 175;
		}
		else if(a == 96 && b == 80)
		{
			return 176;
		}
		else if(a == 96 && b == 81)
		{
			return 177;
		}
		else if(a == 96 && b == 82)
		{
			return 178;
		}
		else if(a == 96 && b == 83)
		{
			return 179;
		}
		else if(a == 96 && b == 84)
		{
			return 180;
		}
		else if(a == 96 && b == 85)
		{
			return 181;
		}
		else if(a == 96 && b == 86)
		{
			return 182;
		}
		else if(a == 96 && b == 87)
		{
			return 183;
		}
		else if(a == 96 && b == 88)
		{
			return 184;
		}
		else if(a == 96 && b == 89)
		{
			return 185;
		}
		else if(a == 96 && b == 90)
		{
			return 186;
		}
		else if(a == 96 && b == 91)
		{
			return 187;
		}
		else if(a == 96 && b == 92)
		{
			return 188;
		}
		else if(a == 96 && b == 93)
		{
			return 189;
		}
		else if(a == 96 && b == 94)
		{
			return 190;
		}
		else if(a == 96 && b == 95)
		{
			return 191;
		}
		else if(a == 96 && b == 96)
		{
			return 192;
		}
		else if(a == 96 && b == 97)
		{
			return 193;
		}
		else if(a == 96 && b == 98)
		{
			return 194;
		}
		else if(a == 96 && b == 99)
		{
			return 195;
		}
		else if(a == 96 && b == 100)
		{
			return 196;
		}
		else if(a == 97 && b == 0)
		{
			return 97;
		}
		else if(a == 97 && b == 1)
		{
			return 98;
		}
		else if(a == 97 && b == 2)
		{
			return 99;
		}
		else if(a == 97 && b == 3)
		{
			return 100;
		}
		else if(a == 97 && b == 4)
		{
			return 101;
		}
		else if(a == 97 && b == 5)
		{
			return 102;
		}
		else if(a == 97 && b == 6)
		{
			return 103;
		}
		else if(a == 97 && b == 7)
		{
			return 104;
		}
		else if(a == 97 && b == 8)
		{
			return 105;
		}
		else if(a == 97 && b == 9)
		{
			return 106;
		}
		else if(a == 97 && b == 10)
		{
			return 107;
		}
		else if(a == 97 && b == 11)
		{
			return 108;
		}
		else if(a == 97 && b == 12)
		{
			return 109;
		}
		else if(a == 97 && b == 13)
		{
			return 110;
		}
		else if(a == 97 && b == 14)
		{
			return 111;
		}
		else if(a == 97 && b == 15)
		{
			return 112;
		}
		else if(a == 97 && b == 16)
		{
			return 113;
		}
		else if(a == 97 && b == 17)
		{
			return 114;
		}
		else if(a == 97 && b == 18)
		{
			return 115;
		}
		else if(a == 97 && b == 19)
		{
			return 116;
		}
		else if(a == 97 && b == 20)
		{
			return 117;
		}
		else if(a == 97 && b == 21)
		{
			return 118;
		}
		else if(a == 97 && b == 22)
		{
			return 119;
		}
		else if(a == 97 && b == 23)
		{
			return 120;
		}
		else if(a == 97 && b == 24)
		{
			return 121;
		}
		else if(a == 97 && b == 25)
		{
			return 122;
		}
		else if(a == 97 && b == 26)
		{
			return 123;
		}
		else if(a == 97 && b == 27)
		{
			return 124;
		}
		else if(a == 97 && b == 28)
		{
			return 125;
		}
		else if(a == 97 && b == 29)
		{
			return 126;
		}
		else if(a == 97 && b == 30)
		{
			return 127;
		}
		else if(a == 97 && b == 31)
		{
			return 128;
		}
		else if(a == 97 && b == 32)
		{
			return 129;
		}
		else if(a == 97 && b == 33)
		{
			return 130;
		}
		else if(a == 97 && b == 34)
		{
			return 131;
		}
		else if(a == 97 && b == 35)
		{
			return 132;
		}
		else if(a == 97 && b == 36)
		{
			return 133;
		}
		else if(a == 97 && b == 37)
		{
			return 134;
		}
		else if(a == 97 && b == 38)
		{
			return 135;
		}
		else if(a == 97 && b == 39)
		{
			return 136;
		}
		else if(a == 97 && b == 40)
		{
			return 137;
		}
		else if(a == 97 && b == 41)
		{
			return 138;
		}
		else if(a == 97 && b == 42)
		{
			return 139;
		}
		else if(a == 97 && b == 43)
		{
			return 140;
		}
		else if(a == 97 && b == 44)
		{
			return 141;
		}
		else if(a == 97 && b == 45)
		{
			return 142;
		}
		else if(a == 97 && b == 46)
		{
			return 143;
		}
		else if(a == 97 && b == 47)
		{
			return 144;
		}
		else if(a == 97 && b == 48)
		{
			return 145;
		}
		else if(a == 97 && b == 49)
		{
			return 146;
		}
		else if(a == 97 && b == 50)
		{
			return 147;
		}
		else if(a == 97 && b == 51)
		{
			return 148;
		}
		else if(a == 97 && b == 52)
		{
			return 149;
		}
		else if(a == 97 && b == 53)
		{
			return 150;
		}
		else if(a == 97 && b == 54)
		{
			return 151;
		}
		else if(a == 97 && b == 55)
		{
			return 152;
		}
		else if(a == 97 && b == 56)
		{
			return 153;
		}
		else if(a == 97 && b == 57)
		{
			return 154;
		}
		else if(a == 97 && b == 58)
		{
			return 155;
		}
		else if(a == 97 && b == 59)
		{
			return 156;
		}
		else if(a == 97 && b == 60)
		{
			return 157;
		}
		else if(a == 97 && b == 61)
		{
			return 158;
		}
		else if(a == 97 && b == 62)
		{
			return 159;
		}
		else if(a == 97 && b == 63)
		{
			return 160;
		}
		else if(a == 97 && b == 64)
		{
			return 161;
		}
		else if(a == 97 && b == 65)
		{
			return 162;
		}
		else if(a == 97 && b == 66)
		{
			return 163;
		}
		else if(a == 97 && b == 67)
		{
			return 164;
		}
		else if(a == 97 && b == 68)
		{
			return 165;
		}
		else if(a == 97 && b == 69)
		{
			return 166;
		}
		else if(a == 97 && b == 70)
		{
			return 167;
		}
		else if(a == 97 && b == 71)
		{
			return 168;
		}
		else if(a == 97 && b == 72)
		{
			return 169;
		}
		else if(a == 97 && b == 73)
		{
			return 170;
		}
		else if(a == 97 && b == 74)
		{
			return 171;
		}
		else if(a == 97 && b == 75)
		{
			return 172;
		}
		else if(a == 97 && b == 76)
		{
			return 173;
		}
		else if(a == 97 && b == 77)
		{
			return 174;
		}
		else if(a == 97 && b == 78)
		{
			return 175;
		}
		else if(a == 97 && b == 79)
		{
			return 176;
		}
		else if(a == 97 && b == 80)
		{
			return 177;
		}
		else if(a == 97 && b == 81)
		{
			return 178;
		}
		else if(a == 97 && b == 82)
		{
			return 179;
		}
		else if(a == 97 && b == 83)
		{
			return 180;
		}
		else if(a == 97 && b == 84)
		{
			return 181;
		}
		else if(a == 97 && b == 85)
		{
			return 182;
		}
		else if(a == 97 && b == 86)
		{
			return 183;
		}
		else if(a == 97 && b == 87)
		{
			return 184;
		}
		else if(a == 97 && b == 88)
		{
			return 185;
		}
		else if(a == 97 && b == 89)
		{
			return 186;
		}
		else if(a == 97 && b == 90)
		{
			return 187;
		}
		else if(a == 97 && b == 91)
		{
			return 188;
		}
		else if(a == 97 && b == 92)
		{
			return 189;
		}
		else if(a == 97 && b == 93)
		{
			return 190;
		}
		else if(a == 97 && b == 94)
		{
			return 191;
		}
		else if(a == 97 && b == 95)
		{
			return 192;
		}
		else if(a == 97 && b == 96)
		{
			return 193;
		}
		else if(a == 97 && b == 97)
		{
			return 194;
		}
		else if(a == 97 && b == 98)
		{
			return 195;
		}
		else if(a == 97 && b == 99)
		{
			return 196;
		}
		else if(a == 97 && b == 100)
		{
			return 197;
		}
		else if(a == 98 && b == 0)
		{
			return 98;
		}
		else if(a == 98 && b == 1)
		{
			return 99;
		}
		else if(a == 98 && b == 2)
		{
			return 100;
		}
		else if(a == 98 && b == 3)
		{
			return 101;
		}
		else if(a == 98 && b == 4)
		{
			return 102;
		}
		else if(a == 98 && b == 5)
		{
			return 103;
		}
		else if(a == 98 && b == 6)
		{
			return 104;
		}
		else if(a == 98 && b == 7)
		{
			return 105;
		}
		else if(a == 98 && b == 8)
		{
			return 106;
		}
		else if(a == 98 && b == 9)
		{
			return 107;
		}
		else if(a == 98 && b == 10)
		{
			return 108;
		}
		else if(a == 98 && b == 11)
		{
			return 109;
		}
		else if(a == 98 && b == 12)
		{
			return 110;
		}
		else if(a == 98 && b == 13)
		{
			return 111;
		}
		else if(a == 98 && b == 14)
		{
			return 112;
		}
		else if(a == 98 && b == 15)
		{
			return 113;
		}
		else if(a == 98 && b == 16)
		{
			return 114;
		}
		else if(a == 98 && b == 17)
		{
			return 115;
		}
		else if(a == 98 && b == 18)
		{
			return 116;
		}
		else if(a == 98 && b == 19)
		{
			return 117;
		}
		else if(a == 98 && b == 20)
		{
			return 118;
		}
		else if(a == 98 && b == 21)
		{
			return 119;
		}
		else if(a == 98 && b == 22)
		{
			return 120;
		}
		else if(a == 98 && b == 23)
		{
			return 121;
		}
		else if(a == 98 && b == 24)
		{
			return 122;
		}
		else if(a == 98 && b == 25)
		{
			return 123;
		}
		else if(a == 98 && b == 26)
		{
			return 124;
		}
		else if(a == 98 && b == 27)
		{
			return 125;
		}
		else if(a == 98 && b == 28)
		{
			return 126;
		}
		else if(a == 98 && b == 29)
		{
			return 127;
		}
		else if(a == 98 && b == 30)
		{
			return 128;
		}
		else if(a == 98 && b == 31)
		{
			return 129;
		}
		else if(a == 98 && b == 32)
		{
			return 130;
		}
		else if(a == 98 && b == 33)
		{
			return 131;
		}
		else if(a == 98 && b == 34)
		{
			return 132;
		}
		else if(a == 98 && b == 35)
		{
			return 133;
		}
		else if(a == 98 && b == 36)
		{
			return 134;
		}
		else if(a == 98 && b == 37)
		{
			return 135;
		}
		else if(a == 98 && b == 38)
		{
			return 136;
		}
		else if(a == 98 && b == 39)
		{
			return 137;
		}
		else if(a == 98 && b == 40)
		{
			return 138;
		}
		else if(a == 98 && b == 41)
		{
			return 139;
		}
		else if(a == 98 && b == 42)
		{
			return 140;
		}
		else if(a == 98 && b == 43)
		{
			return 141;
		}
		else if(a == 98 && b == 44)
		{
			return 142;
		}
		else if(a == 98 && b == 45)
		{
			return 143;
		}
		else if(a == 98 && b == 46)
		{
			return 144;
		}
		else if(a == 98 && b == 47)
		{
			return 145;
		}
		else if(a == 98 && b == 48)
		{
			return 146;
		}
		else if(a == 98 && b == 49)
		{
			return 147;
		}
		else if(a == 98 && b == 50)
		{
			return 148;
		}
		else if(a == 98 && b == 51)
		{
			return 149;
		}
		else if(a == 98 && b == 52)
		{
			return 150;
		}
		else if(a == 98 && b == 53)
		{
			return 151;
		}
		else if(a == 98 && b == 54)
		{
			return 152;
		}
		else if(a == 98 && b == 55)
		{
			return 153;
		}
		else if(a == 98 && b == 56)
		{
			return 154;
		}
		else if(a == 98 && b == 57)
		{
			return 155;
		}
		else if(a == 98 && b == 58)
		{
			return 156;
		}
		else if(a == 98 && b == 59)
		{
			return 157;
		}
		else if(a == 98 && b == 60)
		{
			return 158;
		}
		else if(a == 98 && b == 61)
		{
			return 159;
		}
		else if(a == 98 && b == 62)
		{
			return 160;
		}
		else if(a == 98 && b == 63)
		{
			return 161;
		}
		else if(a == 98 && b == 64)
		{
			return 162;
		}
		else if(a == 98 && b == 65)
		{
			return 163;
		}
		else if(a == 98 && b == 66)
		{
			return 164;
		}
		else if(a == 98 && b == 67)
		{
			return 165;
		}
		else if(a == 98 && b == 68)
		{
			return 166;
		}
		else if(a == 98 && b == 69)
		{
			return 167;
		}
		else if(a == 98 && b == 70)
		{
			return 168;
		}
		else if(a == 98 && b == 71)
		{
			return 169;
		}
		else if(a == 98 && b == 72)
		{
			return 170;
		}
		else if(a == 98 && b == 73)
		{
			return 171;
		}
		else if(a == 98 && b == 74)
		{
			return 172;
		}
		else if(a == 98 && b == 75)
		{
			return 173;
		}
		else if(a == 98 && b == 76)
		{
			return 174;
		}
		else if(a == 98 && b == 77)
		{
			return 175;
		}
		else if(a == 98 && b == 78)
		{
			return 176;
		}
		else if(a == 98 && b == 79)
		{
			return 177;
		}
		else if(a == 98 && b == 80)
		{
			return 178;
		}
		else if(a == 98 && b == 81)
		{
			return 179;
		}
		else if(a == 98 && b == 82)
		{
			return 180;
		}
		else if(a == 98 && b == 83)
		{
			return 181;
		}
		else if(a == 98 && b == 84)
		{
			return 182;
		}
		else if(a == 98 && b == 85)
		{
			return 183;
		}
		else if(a == 98 && b == 86)
		{
			return 184;
		}
		else if(a == 98 && b == 87)
		{
			return 185;
		}
		else if(a == 98 && b == 88)
		{
			return 186;
		}
		else if(a == 98 && b == 89)
		{
			return 187;
		}
		else if(a == 98 && b == 90)
		{
			return 188;
		}
		else if(a == 98 && b == 91)
		{
			return 189;
		}
		else if(a == 98 && b == 92)
		{
			return 190;
		}
		else if(a == 98 && b == 93)
		{
			return 191;
		}
		else if(a == 98 && b == 94)
		{
			return 192;
		}
		else if(a == 98 && b == 95)
		{
			return 193;
		}
		else if(a == 98 && b == 96)
		{
			return 194;
		}
		else if(a == 98 && b == 97)
		{
			return 195;
		}
		else if(a == 98 && b == 98)
		{
			return 196;
		}
		else if(a == 98 && b == 99)
		{
			return 197;
		}
		else if(a == 98 && b == 100)
		{
			return 198;
		}
		else if(a == 99 && b == 0)
		{
			return 99;
		}
		else if(a == 99 && b == 1)
		{
			return 100;
		}
		else if(a == 99 && b == 2)
		{
			return 101;
		}
		else if(a == 99 && b == 3)
		{
			return 102;
		}
		else if(a == 99 && b == 4)
		{
			return 103;
		}
		else if(a == 99 && b == 5)
		{
			return 104;
		}
		else if(a == 99 && b == 6)
		{
			return 105;
		}
		else if(a == 99 && b == 7)
		{
			return 106;
		}
		else if(a == 99 && b == 8)
		{
			return 107;
		}
		else if(a == 99 && b == 9)
		{
			return 108;
		}
		else if(a == 99 && b == 10)
		{
			return 109;
		}
		else if(a == 99 && b == 11)
		{
			return 110;
		}
		else if(a == 99 && b == 12)
		{
			return 111;
		}
		else if(a == 99 && b == 13)
		{
			return 112;
		}
		else if(a == 99 && b == 14)
		{
			return 113;
		}
		else if(a == 99 && b == 15)
		{
			return 114;
		}
		else if(a == 99 && b == 16)
		{
			return 115;
		}
		else if(a == 99 && b == 17)
		{
			return 116;
		}
		else if(a == 99 && b == 18)
		{
			return 117;
		}
		else if(a == 99 && b == 19)
		{
			return 118;
		}
		else if(a == 99 && b == 20)
		{
			return 119;
		}
		else if(a == 99 && b == 21)
		{
			return 120;
		}
		else if(a == 99 && b == 22)
		{
			return 121;
		}
		else if(a == 99 && b == 23)
		{
			return 122;
		}
		else if(a == 99 && b == 24)
		{
			return 123;
		}
		else if(a == 99 && b == 25)
		{
			return 124;
		}
		else if(a == 99 && b == 26)
		{
			return 125;
		}
		else if(a == 99 && b == 27)
		{
			return 126;
		}
		else if(a == 99 && b == 28)
		{
			return 127;
		}
		else if(a == 99 && b == 29)
		{
			return 128;
		}
		else if(a == 99 && b == 30)
		{
			return 129;
		}
		else if(a == 99 && b == 31)
		{
			return 130;
		}
		else if(a == 99 && b == 32)
		{
			return 131;
		}
		else if(a == 99 && b == 33)
		{
			return 132;
		}
		else if(a == 99 && b == 34)
		{
			return 133;
		}
		else if(a == 99 && b == 35)
		{
			return 134;
		}
		else if(a == 99 && b == 36)
		{
			return 135;
		}
		else if(a == 99 && b == 37)
		{
			return 136;
		}
		else if(a == 99 && b == 38)
		{
			return 137;
		}
		else if(a == 99 && b == 39)
		{
			return 138;
		}
		else if(a == 99 && b == 40)
		{
			return 139;
		}
		else if(a == 99 && b == 41)
		{
			return 140;
		}
		else if(a == 99 && b == 42)
		{
			return 141;
		}
		else if(a == 99 && b == 43)
		{
			return 142;
		}
		else if(a == 99 && b == 44)
		{
			return 143;
		}
		else if(a == 99 && b == 45)
		{
			return 144;
		}
		else if(a == 99 && b == 46)
		{
			return 145;
		}
		else if(a == 99 && b == 47)
		{
			return 146;
		}
		else if(a == 99 && b == 48)
		{
			return 147;
		}
		else if(a == 99 && b == 49)
		{
			return 148;
		}
		else if(a == 99 && b == 50)
		{
			return 149;
		}
		else if(a == 99 && b == 51)
		{
			return 150;
		}
		else if(a == 99 && b == 52)
		{
			return 151;
		}
		else if(a == 99 && b == 53)
		{
			return 152;
		}
		else if(a == 99 && b == 54)
		{
			return 153;
		}
		else if(a == 99 && b == 55)
		{
			return 154;
		}
		else if(a == 99 && b == 56)
		{
			return 155;
		}
		else if(a == 99 && b == 57)
		{
			return 156;
		}
		else if(a == 99 && b == 58)
		{
			return 157;
		}
		else if(a == 99 && b == 59)
		{
			return 158;
		}
		else if(a == 99 && b == 60)
		{
			return 159;
		}
		else if(a == 99 && b == 61)
		{
			return 160;
		}
		else if(a == 99 && b == 62)
		{
			return 161;
		}
		else if(a == 99 && b == 63)
		{
			return 162;
		}
		else if(a == 99 && b == 64)
		{
			return 163;
		}
		else if(a == 99 && b == 65)
		{
			return 164;
		}
		else if(a == 99 && b == 66)
		{
			return 165;
		}
		else if(a == 99 && b == 67)
		{
			return 166;
		}
		else if(a == 99 && b == 68)
		{
			return 167;
		}
		else if(a == 99 && b == 69)
		{
			return 168;
		}
		else if(a == 99 && b == 70)
		{
			return 169;
		}
		else if(a == 99 && b == 71)
		{
			return 170;
		}
		else if(a == 99 && b == 72)
		{
			return 171;
		}
		else if(a == 99 && b == 73)
		{
			return 172;
		}
		else if(a == 99 && b == 74)
		{
			return 173;
		}
		else if(a == 99 && b == 75)
		{
			return 174;
		}
		else if(a == 99 && b == 76)
		{
			return 175;
		}
		else if(a == 99 && b == 77)
		{
			return 176;
		}
		else if(a == 99 && b == 78)
		{
			return 177;
		}
		else if(a == 99 && b == 79)
		{
			return 178;
		}
		else if(a == 99 && b == 80)
		{
			return 179;
		}
		else if(a == 99 && b == 81)
		{
			return 180;
		}
		else if(a == 99 && b == 82)
		{
			return 181;
		}
		else if(a == 99 && b == 83)
		{
			return 182;
		}
		else if(a == 99 && b == 84)
		{
			return 183;
		}
		else if(a == 99 && b == 85)
		{
			return 184;
		}
		else if(a == 99 && b == 86)
		{
			return 185;
		}
		else if(a == 99 && b == 87)
		{
			return 186;
		}
		else if(a == 99 && b == 88)
		{
			return 187;
		}
		else if(a == 99 && b == 89)
		{
			return 188;
		}
		else if(a == 99 && b == 90)
		{
			return 189;
		}
		else if(a == 99 && b == 91)
		{
			return 190;
		}
		else if(a == 99 && b == 92)
		{
			return 191;
		}
		else if(a == 99 && b == 93)
		{
			return 192;
		}
		else if(a == 99 && b == 94)
		{
			return 193;
		}
		else if(a == 99 && b == 95)
		{
			return 194;
		}
		else if(a == 99 && b == 96)
		{
			return 195;
		}
		else if(a == 99 && b == 97)
		{
			return 196;
		}
		else if(a == 99 && b == 98)
		{
			return 197;
		}
		else if(a == 99 && b == 99)
		{
			return 198;
		}
		else if(a == 99 && b == 100)
		{
			return 199;
		}
		else if(a == 100 && b == 0)
		{
			return 100;
		}
		else if(a == 100 && b == 1)
		{
			return 101;
		}
		else if(a == 100 && b == 2)
		{
			return 102;
		}
		else if(a == 100 && b == 3)
		{
			return 103;
		}
		else if(a == 100 && b == 4)
		{
			return 104;
		}
		else if(a == 100 && b == 5)
		{
			return 105;
		}
		else if(a == 100 && b == 6)
		{
			return 106;
		}
		else if(a == 100 && b == 7)
		{
			return 107;
		}
		else if(a == 100 && b == 8)
		{
			return 108;
		}
		else if(a == 100 && b == 9)
		{
			return 109;
		}
		else if(a == 100 && b == 10)
		{
			return 110;
		}
		else if(a == 100 && b == 11)
		{
			return 111;
		}
		else if(a == 100 && b == 12)
		{
			return 112;
		}
		else if(a == 100 && b == 13)
		{
			return 113;
		}
		else if(a == 100 && b == 14)
		{
			return 114;
		}
		else if(a == 100 && b == 15)
		{
			return 115;
		}
		else if(a == 100 && b == 16)
		{
			return 116;
		}
		else if(a == 100 && b == 17)
		{
			return 117;
		}
		else if(a == 100 && b == 18)
		{
			return 118;
		}
		else if(a == 100 && b == 19)
		{
			return 119;
		}
		else if(a == 100 && b == 20)
		{
			return 120;
		}
		else if(a == 100 && b == 21)
		{
			return 121;
		}
		else if(a == 100 && b == 22)
		{
			return 122;
		}
		else if(a == 100 && b == 23)
		{
			return 123;
		}
		else if(a == 100 && b == 24)
		{
			return 124;
		}
		else if(a == 100 && b == 25)
		{
			return 125;
		}
		else if(a == 100 && b == 26)
		{
			return 126;
		}
		else if(a == 100 && b == 27)
		{
			return 127;
		}
		else if(a == 100 && b == 28)
		{
			return 128;
		}
		else if(a == 100 && b == 29)
		{
			return 129;
		}
		else if(a == 100 && b == 30)
		{
			return 130;
		}
		else if(a == 100 && b == 31)
		{
			return 131;
		}
		else if(a == 100 && b == 32)
		{
			return 132;
		}
		else if(a == 100 && b == 33)
		{
			return 133;
		}
		else if(a == 100 && b == 34)
		{
			return 134;
		}
		else if(a == 100 && b == 35)
		{
			return 135;
		}
		else if(a == 100 && b == 36)
		{
			return 136;
		}
		else if(a == 100 && b == 37)
		{
			return 137;
		}
		else if(a == 100 && b == 38)
		{
			return 138;
		}
		else if(a == 100 && b == 39)
		{
			return 139;
		}
		else if(a == 100 && b == 40)
		{
			return 140;
		}
		else if(a == 100 && b == 41)
		{
			return 141;
		}
		else if(a == 100 && b == 42)
		{
			return 142;
		}
		else if(a == 100 && b == 43)
		{
			return 143;
		}
		else if(a == 100 && b == 44)
		{
			return 144;
		}
		else if(a == 100 && b == 45)
		{
			return 145;
		}
		else if(a == 100 && b == 46)
		{
			return 146;
		}
		else if(a == 100 && b == 47)
		{
			return 147;
		}
		else if(a == 100 && b == 48)
		{
			return 148;
		}
		else if(a == 100 && b == 49)
		{
			return 149;
		}
		else if(a == 100 && b == 50)
		{
			return 150;
		}
		else if(a == 100 && b == 51)
		{
			return 151;
		}
		else if(a == 100 && b == 52)
		{
			return 152;
		}
		else if(a == 100 && b == 53)
		{
			return 153;
		}
		else if(a == 100 && b == 54)
		{
			return 154;
		}
		else if(a == 100 && b == 55)
		{
			return 155;
		}
		else if(a == 100 && b == 56)
		{
			return 156;
		}
		else if(a == 100 && b == 57)
		{
			return 157;
		}
		else if(a == 100 && b == 58)
		{
			return 158;
		}
		else if(a == 100 && b == 59)
		{
			return 159;
		}
		else if(a == 100 && b == 60)
		{
			return 160;
		}
		else if(a == 100 && b == 61)
		{
			return 161;
		}
		else if(a == 100 && b == 62)
		{
			return 162;
		}
		else if(a == 100 && b == 63)
		{
			return 163;
		}
		else if(a == 100 && b == 64)
		{
			return 164;
		}
		else if(a == 100 && b == 65)
		{
			return 165;
		}
		else if(a == 100 && b == 66)
		{
			return 166;
		}
		else if(a == 100 && b == 67)
		{
			return 167;
		}
		else if(a == 100 && b == 68)
		{
			return 168;
		}
		else if(a == 100 && b == 69)
		{
			return 169;
		}
		else if(a == 100 && b == 70)
		{
			return 170;
		}
		else if(a == 100 && b == 71)
		{
			return 171;
		}
		else if(a == 100 && b == 72)
		{
			return 172;
		}
		else if(a == 100 && b == 73)
		{
			return 173;
		}
		else if(a == 100 && b == 74)
		{
			return 174;
		}
		else if(a == 100 && b == 75)
		{
			return 175;
		}
		else if(a == 100 && b == 76)
		{
			return 176;
		}
		else if(a == 100 && b == 77)
		{
			return 177;
		}
		else if(a == 100 && b == 78)
		{
			return 178;
		}
		else if(a == 100 && b == 79)
		{
			return 179;
		}
		else if(a == 100 && b == 80)
		{
			return 180;
		}
		else if(a == 100 && b == 81)
		{
			return 181;
		}
		else if(a == 100 && b == 82)
		{
			return 182;
		}
		else if(a == 100 && b == 83)
		{
			return 183;
		}
		else if(a == 100 && b == 84)
		{
			return 184;
		}
		else if(a == 100 && b == 85)
		{
			return 185;
		}
		else if(a == 100 && b == 86)
		{
			return 186;
		}
		else if(a == 100 && b == 87)
		{
			return 187;
		}
		else if(a == 100 && b == 88)
		{
			return 188;
		}
		else if(a == 100 && b == 89)
		{
			return 189;
		}
		else if(a == 100 && b == 90)
		{
			return 190;
		}
		else if(a == 100 && b == 91)
		{
			return 191;
		}
		else if(a == 100 && b == 92)
		{
			return 192;
		}
		else if(a == 100 && b == 93)
		{
			return 193;
		}
		else if(a == 100 && b == 94)
		{
			return 194;
		}
		else if(a == 100 && b == 95)
		{
			return 195;
		}
		else if(a == 100 && b == 96)
		{
			return 196;
		}
		else if(a == 100 && b == 97)
		{
			return 197;
		}
		else if(a == 100 && b == 98)
		{
			return 198;
		}
		else if(a == 100 && b == 99)
		{
			return 199;
		}
		else if(a == 100 && b == 100)
		{
			return 200;
		}
		throw new Exception("Calculator cannot calculate this numbers ;-;");
	}

	public static int Subtract(int a, int b)
	{
		if(a == 0 && b == 0)
		{
			return 0;
		}
		else if(a == 0 && b == 0)
		{
			return 0;
		}
		else if(a == 0 && b == 1)
		{
			return -1;
		}
		else if(a == 0 && b == 2)
		{
			return -2;
		}
		else if(a == 0 && b == 3)
		{
			return -3;
		}
		else if(a == 0 && b == 4)
		{
			return -4;
		}
		else if(a == 0 && b == 5)
		{
			return -5;
		}
		else if(a == 0 && b == 6)
		{
			return -6;
		}
		else if(a == 0 && b == 7)
		{
			return -7;
		}
		else if(a == 0 && b == 8)
		{
			return -8;
		}
		else if(a == 0 && b == 9)
		{
			return -9;
		}
		else if(a == 0 && b == 10)
		{
			return -10;
		}
		else if(a == 0 && b == 11)
		{
			return -11;
		}
		else if(a == 0 && b == 12)
		{
			return -12;
		}
		else if(a == 0 && b == 13)
		{
			return -13;
		}
		else if(a == 0 && b == 14)
		{
			return -14;
		}
		else if(a == 0 && b == 15)
		{
			return -15;
		}
		else if(a == 0 && b == 16)
		{
			return -16;
		}
		else if(a == 0 && b == 17)
		{
			return -17;
		}
		else if(a == 0 && b == 18)
		{
			return -18;
		}
		else if(a == 0 && b == 19)
		{
			return -19;
		}
		else if(a == 0 && b == 20)
		{
			return -20;
		}
		else if(a == 0 && b == 21)
		{
			return -21;
		}
		else if(a == 0 && b == 22)
		{
			return -22;
		}
		else if(a == 0 && b == 23)
		{
			return -23;
		}
		else if(a == 0 && b == 24)
		{
			return -24;
		}
		else if(a == 0 && b == 25)
		{
			return -25;
		}
		else if(a == 0 && b == 26)
		{
			return -26;
		}
		else if(a == 0 && b == 27)
		{
			return -27;
		}
		else if(a == 0 && b == 28)
		{
			return -28;
		}
		else if(a == 0 && b == 29)
		{
			return -29;
		}
		else if(a == 0 && b == 30)
		{
			return -30;
		}
		else if(a == 0 && b == 31)
		{
			return -31;
		}
		else if(a == 0 && b == 32)
		{
			return -32;
		}
		else if(a == 0 && b == 33)
		{
			return -33;
		}
		else if(a == 0 && b == 34)
		{
			return -34;
		}
		else if(a == 0 && b == 35)
		{
			return -35;
		}
		else if(a == 0 && b == 36)
		{
			return -36;
		}
		else if(a == 0 && b == 37)
		{
			return -37;
		}
		else if(a == 0 && b == 38)
		{
			return -38;
		}
		else if(a == 0 && b == 39)
		{
			return -39;
		}
		else if(a == 0 && b == 40)
		{
			return -40;
		}
		else if(a == 0 && b == 41)
		{
			return -41;
		}
		else if(a == 0 && b == 42)
		{
			return -42;
		}
		else if(a == 0 && b == 43)
		{
			return -43;
		}
		else if(a == 0 && b == 44)
		{
			return -44;
		}
		else if(a == 0 && b == 45)
		{
			return -45;
		}
		else if(a == 0 && b == 46)
		{
			return -46;
		}
		else if(a == 0 && b == 47)
		{
			return -47;
		}
		else if(a == 0 && b == 48)
		{
			return -48;
		}
		else if(a == 0 && b == 49)
		{
			return -49;
		}
		else if(a == 0 && b == 50)
		{
			return -50;
		}
		else if(a == 0 && b == 51)
		{
			return -51;
		}
		else if(a == 0 && b == 52)
		{
			return -52;
		}
		else if(a == 0 && b == 53)
		{
			return -53;
		}
		else if(a == 0 && b == 54)
		{
			return -54;
		}
		else if(a == 0 && b == 55)
		{
			return -55;
		}
		else if(a == 0 && b == 56)
		{
			return -56;
		}
		else if(a == 0 && b == 57)
		{
			return -57;
		}
		else if(a == 0 && b == 58)
		{
			return -58;
		}
		else if(a == 0 && b == 59)
		{
			return -59;
		}
		else if(a == 0 && b == 60)
		{
			return -60;
		}
		else if(a == 0 && b == 61)
		{
			return -61;
		}
		else if(a == 0 && b == 62)
		{
			return -62;
		}
		else if(a == 0 && b == 63)
		{
			return -63;
		}
		else if(a == 0 && b == 64)
		{
			return -64;
		}
		else if(a == 0 && b == 65)
		{
			return -65;
		}
		else if(a == 0 && b == 66)
		{
			return -66;
		}
		else if(a == 0 && b == 67)
		{
			return -67;
		}
		else if(a == 0 && b == 68)
		{
			return -68;
		}
		else if(a == 0 && b == 69)
		{
			return -69;
		}
		else if(a == 0 && b == 70)
		{
			return -70;
		}
		else if(a == 0 && b == 71)
		{
			return -71;
		}
		else if(a == 0 && b == 72)
		{
			return -72;
		}
		else if(a == 0 && b == 73)
		{
			return -73;
		}
		else if(a == 0 && b == 74)
		{
			return -74;
		}
		else if(a == 0 && b == 75)
		{
			return -75;
		}
		else if(a == 0 && b == 76)
		{
			return -76;
		}
		else if(a == 0 && b == 77)
		{
			return -77;
		}
		else if(a == 0 && b == 78)
		{
			return -78;
		}
		else if(a == 0 && b == 79)
		{
			return -79;
		}
		else if(a == 0 && b == 80)
		{
			return -80;
		}
		else if(a == 0 && b == 81)
		{
			return -81;
		}
		else if(a == 0 && b == 82)
		{
			return -82;
		}
		else if(a == 0 && b == 83)
		{
			return -83;
		}
		else if(a == 0 && b == 84)
		{
			return -84;
		}
		else if(a == 0 && b == 85)
		{
			return -85;
		}
		else if(a == 0 && b == 86)
		{
			return -86;
		}
		else if(a == 0 && b == 87)
		{
			return -87;
		}
		else if(a == 0 && b == 88)
		{
			return -88;
		}
		else if(a == 0 && b == 89)
		{
			return -89;
		}
		else if(a == 0 && b == 90)
		{
			return -90;
		}
		else if(a == 0 && b == 91)
		{
			return -91;
		}
		else if(a == 0 && b == 92)
		{
			return -92;
		}
		else if(a == 0 && b == 93)
		{
			return -93;
		}
		else if(a == 0 && b == 94)
		{
			return -94;
		}
		else if(a == 0 && b == 95)
		{
			return -95;
		}
		else if(a == 0 && b == 96)
		{
			return -96;
		}
		else if(a == 0 && b == 97)
		{
			return -97;
		}
		else if(a == 0 && b == 98)
		{
			return -98;
		}
		else if(a == 0 && b == 99)
		{
			return -99;
		}
		else if(a == 0 && b == 100)
		{
			return -100;
		}
		else if(a == 1 && b == 0)
		{
			return 1;
		}
		else if(a == 1 && b == 1)
		{
			return 0;
		}
		else if(a == 1 && b == 2)
		{
			return -1;
		}
		else if(a == 1 && b == 3)
		{
			return -2;
		}
		else if(a == 1 && b == 4)
		{
			return -3;
		}
		else if(a == 1 && b == 5)
		{
			return -4;
		}
		else if(a == 1 && b == 6)
		{
			return -5;
		}
		else if(a == 1 && b == 7)
		{
			return -6;
		}
		else if(a == 1 && b == 8)
		{
			return -7;
		}
		else if(a == 1 && b == 9)
		{
			return -8;
		}
		else if(a == 1 && b == 10)
		{
			return -9;
		}
		else if(a == 1 && b == 11)
		{
			return -10;
		}
		else if(a == 1 && b == 12)
		{
			return -11;
		}
		else if(a == 1 && b == 13)
		{
			return -12;
		}
		else if(a == 1 && b == 14)
		{
			return -13;
		}
		else if(a == 1 && b == 15)
		{
			return -14;
		}
		else if(a == 1 && b == 16)
		{
			return -15;
		}
		else if(a == 1 && b == 17)
		{
			return -16;
		}
		else if(a == 1 && b == 18)
		{
			return -17;
		}
		else if(a == 1 && b == 19)
		{
			return -18;
		}
		else if(a == 1 && b == 20)
		{
			return -19;
		}
		else if(a == 1 && b == 21)
		{
			return -20;
		}
		else if(a == 1 && b == 22)
		{
			return -21;
		}
		else if(a == 1 && b == 23)
		{
			return -22;
		}
		else if(a == 1 && b == 24)
		{
			return -23;
		}
		else if(a == 1 && b == 25)
		{
			return -24;
		}
		else if(a == 1 && b == 26)
		{
			return -25;
		}
		else if(a == 1 && b == 27)
		{
			return -26;
		}
		else if(a == 1 && b == 28)
		{
			return -27;
		}
		else if(a == 1 && b == 29)
		{
			return -28;
		}
		else if(a == 1 && b == 30)
		{
			return -29;
		}
		else if(a == 1 && b == 31)
		{
			return -30;
		}
		else if(a == 1 && b == 32)
		{
			return -31;
		}
		else if(a == 1 && b == 33)
		{
			return -32;
		}
		else if(a == 1 && b == 34)
		{
			return -33;
		}
		else if(a == 1 && b == 35)
		{
			return -34;
		}
		else if(a == 1 && b == 36)
		{
			return -35;
		}
		else if(a == 1 && b == 37)
		{
			return -36;
		}
		else if(a == 1 && b == 38)
		{
			return -37;
		}
		else if(a == 1 && b == 39)
		{
			return -38;
		}
		else if(a == 1 && b == 40)
		{
			return -39;
		}
		else if(a == 1 && b == 41)
		{
			return -40;
		}
		else if(a == 1 && b == 42)
		{
			return -41;
		}
		else if(a == 1 && b == 43)
		{
			return -42;
		}
		else if(a == 1 && b == 44)
		{
			return -43;
		}
		else if(a == 1 && b == 45)
		{
			return -44;
		}
		else if(a == 1 && b == 46)
		{
			return -45;
		}
		else if(a == 1 && b == 47)
		{
			return -46;
		}
		else if(a == 1 && b == 48)
		{
			return -47;
		}
		else if(a == 1 && b == 49)
		{
			return -48;
		}
		else if(a == 1 && b == 50)
		{
			return -49;
		}
		else if(a == 1 && b == 51)
		{
			return -50;
		}
		else if(a == 1 && b == 52)
		{
			return -51;
		}
		else if(a == 1 && b == 53)
		{
			return -52;
		}
		else if(a == 1 && b == 54)
		{
			return -53;
		}
		else if(a == 1 && b == 55)
		{
			return -54;
		}
		else if(a == 1 && b == 56)
		{
			return -55;
		}
		else if(a == 1 && b == 57)
		{
			return -56;
		}
		else if(a == 1 && b == 58)
		{
			return -57;
		}
		else if(a == 1 && b == 59)
		{
			return -58;
		}
		else if(a == 1 && b == 60)
		{
			return -59;
		}
		else if(a == 1 && b == 61)
		{
			return -60;
		}
		else if(a == 1 && b == 62)
		{
			return -61;
		}
		else if(a == 1 && b == 63)
		{
			return -62;
		}
		else if(a == 1 && b == 64)
		{
			return -63;
		}
		else if(a == 1 && b == 65)
		{
			return -64;
		}
		else if(a == 1 && b == 66)
		{
			return -65;
		}
		else if(a == 1 && b == 67)
		{
			return -66;
		}
		else if(a == 1 && b == 68)
		{
			return -67;
		}
		else if(a == 1 && b == 69)
		{
			return -68;
		}
		else if(a == 1 && b == 70)
		{
			return -69;
		}
		else if(a == 1 && b == 71)
		{
			return -70;
		}
		else if(a == 1 && b == 72)
		{
			return -71;
		}
		else if(a == 1 && b == 73)
		{
			return -72;
		}
		else if(a == 1 && b == 74)
		{
			return -73;
		}
		else if(a == 1 && b == 75)
		{
			return -74;
		}
		else if(a == 1 && b == 76)
		{
			return -75;
		}
		else if(a == 1 && b == 77)
		{
			return -76;
		}
		else if(a == 1 && b == 78)
		{
			return -77;
		}
		else if(a == 1 && b == 79)
		{
			return -78;
		}
		else if(a == 1 && b == 80)
		{
			return -79;
		}
		else if(a == 1 && b == 81)
		{
			return -80;
		}
		else if(a == 1 && b == 82)
		{
			return -81;
		}
		else if(a == 1 && b == 83)
		{
			return -82;
		}
		else if(a == 1 && b == 84)
		{
			return -83;
		}
		else if(a == 1 && b == 85)
		{
			return -84;
		}
		else if(a == 1 && b == 86)
		{
			return -85;
		}
		else if(a == 1 && b == 87)
		{
			return -86;
		}
		else if(a == 1 && b == 88)
		{
			return -87;
		}
		else if(a == 1 && b == 89)
		{
			return -88;
		}
		else if(a == 1 && b == 90)
		{
			return -89;
		}
		else if(a == 1 && b == 91)
		{
			return -90;
		}
		else if(a == 1 && b == 92)
		{
			return -91;
		}
		else if(a == 1 && b == 93)
		{
			return -92;
		}
		else if(a == 1 && b == 94)
		{
			return -93;
		}
		else if(a == 1 && b == 95)
		{
			return -94;
		}
		else if(a == 1 && b == 96)
		{
			return -95;
		}
		else if(a == 1 && b == 97)
		{
			return -96;
		}
		else if(a == 1 && b == 98)
		{
			return -97;
		}
		else if(a == 1 && b == 99)
		{
			return -98;
		}
		else if(a == 1 && b == 100)
		{
			return -99;
		}
		else if(a == 2 && b == 0)
		{
			return 2;
		}
		else if(a == 2 && b == 1)
		{
			return 1;
		}
		else if(a == 2 && b == 2)
		{
			return 0;
		}
		else if(a == 2 && b == 3)
		{
			return -1;
		}
		else if(a == 2 && b == 4)
		{
			return -2;
		}
		else if(a == 2 && b == 5)
		{
			return -3;
		}
		else if(a == 2 && b == 6)
		{
			return -4;
		}
		else if(a == 2 && b == 7)
		{
			return -5;
		}
		else if(a == 2 && b == 8)
		{
			return -6;
		}
		else if(a == 2 && b == 9)
		{
			return -7;
		}
		else if(a == 2 && b == 10)
		{
			return -8;
		}
		else if(a == 2 && b == 11)
		{
			return -9;
		}
		else if(a == 2 && b == 12)
		{
			return -10;
		}
		else if(a == 2 && b == 13)
		{
			return -11;
		}
		else if(a == 2 && b == 14)
		{
			return -12;
		}
		else if(a == 2 && b == 15)
		{
			return -13;
		}
		else if(a == 2 && b == 16)
		{
			return -14;
		}
		else if(a == 2 && b == 17)
		{
			return -15;
		}
		else if(a == 2 && b == 18)
		{
			return -16;
		}
		else if(a == 2 && b == 19)
		{
			return -17;
		}
		else if(a == 2 && b == 20)
		{
			return -18;
		}
		else if(a == 2 && b == 21)
		{
			return -19;
		}
		else if(a == 2 && b == 22)
		{
			return -20;
		}
		else if(a == 2 && b == 23)
		{
			return -21;
		}
		else if(a == 2 && b == 24)
		{
			return -22;
		}
		else if(a == 2 && b == 25)
		{
			return -23;
		}
		else if(a == 2 && b == 26)
		{
			return -24;
		}
		else if(a == 2 && b == 27)
		{
			return -25;
		}
		else if(a == 2 && b == 28)
		{
			return -26;
		}
		else if(a == 2 && b == 29)
		{
			return -27;
		}
		else if(a == 2 && b == 30)
		{
			return -28;
		}
		else if(a == 2 && b == 31)
		{
			return -29;
		}
		else if(a == 2 && b == 32)
		{
			return -30;
		}
		else if(a == 2 && b == 33)
		{
			return -31;
		}
		else if(a == 2 && b == 34)
		{
			return -32;
		}
		else if(a == 2 && b == 35)
		{
			return -33;
		}
		else if(a == 2 && b == 36)
		{
			return -34;
		}
		else if(a == 2 && b == 37)
		{
			return -35;
		}
		else if(a == 2 && b == 38)
		{
			return -36;
		}
		else if(a == 2 && b == 39)
		{
			return -37;
		}
		else if(a == 2 && b == 40)
		{
			return -38;
		}
		else if(a == 2 && b == 41)
		{
			return -39;
		}
		else if(a == 2 && b == 42)
		{
			return -40;
		}
		else if(a == 2 && b == 43)
		{
			return -41;
		}
		else if(a == 2 && b == 44)
		{
			return -42;
		}
		else if(a == 2 && b == 45)
		{
			return -43;
		}
		else if(a == 2 && b == 46)
		{
			return -44;
		}
		else if(a == 2 && b == 47)
		{
			return -45;
		}
		else if(a == 2 && b == 48)
		{
			return -46;
		}
		else if(a == 2 && b == 49)
		{
			return -47;
		}
		else if(a == 2 && b == 50)
		{
			return -48;
		}
		else if(a == 2 && b == 51)
		{
			return -49;
		}
		else if(a == 2 && b == 52)
		{
			return -50;
		}
		else if(a == 2 && b == 53)
		{
			return -51;
		}
		else if(a == 2 && b == 54)
		{
			return -52;
		}
		else if(a == 2 && b == 55)
		{
			return -53;
		}
		else if(a == 2 && b == 56)
		{
			return -54;
		}
		else if(a == 2 && b == 57)
		{
			return -55;
		}
		else if(a == 2 && b == 58)
		{
			return -56;
		}
		else if(a == 2 && b == 59)
		{
			return -57;
		}
		else if(a == 2 && b == 60)
		{
			return -58;
		}
		else if(a == 2 && b == 61)
		{
			return -59;
		}
		else if(a == 2 && b == 62)
		{
			return -60;
		}
		else if(a == 2 && b == 63)
		{
			return -61;
		}
		else if(a == 2 && b == 64)
		{
			return -62;
		}
		else if(a == 2 && b == 65)
		{
			return -63;
		}
		else if(a == 2 && b == 66)
		{
			return -64;
		}
		else if(a == 2 && b == 67)
		{
			return -65;
		}
		else if(a == 2 && b == 68)
		{
			return -66;
		}
		else if(a == 2 && b == 69)
		{
			return -67;
		}
		else if(a == 2 && b == 70)
		{
			return -68;
		}
		else if(a == 2 && b == 71)
		{
			return -69;
		}
		else if(a == 2 && b == 72)
		{
			return -70;
		}
		else if(a == 2 && b == 73)
		{
			return -71;
		}
		else if(a == 2 && b == 74)
		{
			return -72;
		}
		else if(a == 2 && b == 75)
		{
			return -73;
		}
		else if(a == 2 && b == 76)
		{
			return -74;
		}
		else if(a == 2 && b == 77)
		{
			return -75;
		}
		else if(a == 2 && b == 78)
		{
			return -76;
		}
		else if(a == 2 && b == 79)
		{
			return -77;
		}
		else if(a == 2 && b == 80)
		{
			return -78;
		}
		else if(a == 2 && b == 81)
		{
			return -79;
		}
		else if(a == 2 && b == 82)
		{
			return -80;
		}
		else if(a == 2 && b == 83)
		{
			return -81;
		}
		else if(a == 2 && b == 84)
		{
			return -82;
		}
		else if(a == 2 && b == 85)
		{
			return -83;
		}
		else if(a == 2 && b == 86)
		{
			return -84;
		}
		else if(a == 2 && b == 87)
		{
			return -85;
		}
		else if(a == 2 && b == 88)
		{
			return -86;
		}
		else if(a == 2 && b == 89)
		{
			return -87;
		}
		else if(a == 2 && b == 90)
		{
			return -88;
		}
		else if(a == 2 && b == 91)
		{
			return -89;
		}
		else if(a == 2 && b == 92)
		{
			return -90;
		}
		else if(a == 2 && b == 93)
		{
			return -91;
		}
		else if(a == 2 && b == 94)
		{
			return -92;
		}
		else if(a == 2 && b == 95)
		{
			return -93;
		}
		else if(a == 2 && b == 96)
		{
			return -94;
		}
		else if(a == 2 && b == 97)
		{
			return -95;
		}
		else if(a == 2 && b == 98)
		{
			return -96;
		}
		else if(a == 2 && b == 99)
		{
			return -97;
		}
		else if(a == 2 && b == 100)
		{
			return -98;
		}
		else if(a == 3 && b == 0)
		{
			return 3;
		}
		else if(a == 3 && b == 1)
		{
			return 2;
		}
		else if(a == 3 && b == 2)
		{
			return 1;
		}
		else if(a == 3 && b == 3)
		{
			return 0;
		}
		else if(a == 3 && b == 4)
		{
			return -1;
		}
		else if(a == 3 && b == 5)
		{
			return -2;
		}
		else if(a == 3 && b == 6)
		{
			return -3;
		}
		else if(a == 3 && b == 7)
		{
			return -4;
		}
		else if(a == 3 && b == 8)
		{
			return -5;
		}
		else if(a == 3 && b == 9)
		{
			return -6;
		}
		else if(a == 3 && b == 10)
		{
			return -7;
		}
		else if(a == 3 && b == 11)
		{
			return -8;
		}
		else if(a == 3 && b == 12)
		{
			return -9;
		}
		else if(a == 3 && b == 13)
		{
			return -10;
		}
		else if(a == 3 && b == 14)
		{
			return -11;
		}
		else if(a == 3 && b == 15)
		{
			return -12;
		}
		else if(a == 3 && b == 16)
		{
			return -13;
		}
		else if(a == 3 && b == 17)
		{
			return -14;
		}
		else if(a == 3 && b == 18)
		{
			return -15;
		}
		else if(a == 3 && b == 19)
		{
			return -16;
		}
		else if(a == 3 && b == 20)
		{
			return -17;
		}
		else if(a == 3 && b == 21)
		{
			return -18;
		}
		else if(a == 3 && b == 22)
		{
			return -19;
		}
		else if(a == 3 && b == 23)
		{
			return -20;
		}
		else if(a == 3 && b == 24)
		{
			return -21;
		}
		else if(a == 3 && b == 25)
		{
			return -22;
		}
		else if(a == 3 && b == 26)
		{
			return -23;
		}
		else if(a == 3 && b == 27)
		{
			return -24;
		}
		else if(a == 3 && b == 28)
		{
			return -25;
		}
		else if(a == 3 && b == 29)
		{
			return -26;
		}
		else if(a == 3 && b == 30)
		{
			return -27;
		}
		else if(a == 3 && b == 31)
		{
			return -28;
		}
		else if(a == 3 && b == 32)
		{
			return -29;
		}
		else if(a == 3 && b == 33)
		{
			return -30;
		}
		else if(a == 3 && b == 34)
		{
			return -31;
		}
		else if(a == 3 && b == 35)
		{
			return -32;
		}
		else if(a == 3 && b == 36)
		{
			return -33;
		}
		else if(a == 3 && b == 37)
		{
			return -34;
		}
		else if(a == 3 && b == 38)
		{
			return -35;
		}
		else if(a == 3 && b == 39)
		{
			return -36;
		}
		else if(a == 3 && b == 40)
		{
			return -37;
		}
		else if(a == 3 && b == 41)
		{
			return -38;
		}
		else if(a == 3 && b == 42)
		{
			return -39;
		}
		else if(a == 3 && b == 43)
		{
			return -40;
		}
		else if(a == 3 && b == 44)
		{
			return -41;
		}
		else if(a == 3 && b == 45)
		{
			return -42;
		}
		else if(a == 3 && b == 46)
		{
			return -43;
		}
		else if(a == 3 && b == 47)
		{
			return -44;
		}
		else if(a == 3 && b == 48)
		{
			return -45;
		}
		else if(a == 3 && b == 49)
		{
			return -46;
		}
		else if(a == 3 && b == 50)
		{
			return -47;
		}
		else if(a == 3 && b == 51)
		{
			return -48;
		}
		else if(a == 3 && b == 52)
		{
			return -49;
		}
		else if(a == 3 && b == 53)
		{
			return -50;
		}
		else if(a == 3 && b == 54)
		{
			return -51;
		}
		else if(a == 3 && b == 55)
		{
			return -52;
		}
		else if(a == 3 && b == 56)
		{
			return -53;
		}
		else if(a == 3 && b == 57)
		{
			return -54;
		}
		else if(a == 3 && b == 58)
		{
			return -55;
		}
		else if(a == 3 && b == 59)
		{
			return -56;
		}
		else if(a == 3 && b == 60)
		{
			return -57;
		}
		else if(a == 3 && b == 61)
		{
			return -58;
		}
		else if(a == 3 && b == 62)
		{
			return -59;
		}
		else if(a == 3 && b == 63)
		{
			return -60;
		}
		else if(a == 3 && b == 64)
		{
			return -61;
		}
		else if(a == 3 && b == 65)
		{
			return -62;
		}
		else if(a == 3 && b == 66)
		{
			return -63;
		}
		else if(a == 3 && b == 67)
		{
			return -64;
		}
		else if(a == 3 && b == 68)
		{
			return -65;
		}
		else if(a == 3 && b == 69)
		{
			return -66;
		}
		else if(a == 3 && b == 70)
		{
			return -67;
		}
		else if(a == 3 && b == 71)
		{
			return -68;
		}
		else if(a == 3 && b == 72)
		{
			return -69;
		}
		else if(a == 3 && b == 73)
		{
			return -70;
		}
		else if(a == 3 && b == 74)
		{
			return -71;
		}
		else if(a == 3 && b == 75)
		{
			return -72;
		}
		else if(a == 3 && b == 76)
		{
			return -73;
		}
		else if(a == 3 && b == 77)
		{
			return -74;
		}
		else if(a == 3 && b == 78)
		{
			return -75;
		}
		else if(a == 3 && b == 79)
		{
			return -76;
		}
		else if(a == 3 && b == 80)
		{
			return -77;
		}
		else if(a == 3 && b == 81)
		{
			return -78;
		}
		else if(a == 3 && b == 82)
		{
			return -79;
		}
		else if(a == 3 && b == 83)
		{
			return -80;
		}
		else if(a == 3 && b == 84)
		{
			return -81;
		}
		else if(a == 3 && b == 85)
		{
			return -82;
		}
		else if(a == 3 && b == 86)
		{
			return -83;
		}
		else if(a == 3 && b == 87)
		{
			return -84;
		}
		else if(a == 3 && b == 88)
		{
			return -85;
		}
		else if(a == 3 && b == 89)
		{
			return -86;
		}
		else if(a == 3 && b == 90)
		{
			return -87;
		}
		else if(a == 3 && b == 91)
		{
			return -88;
		}
		else if(a == 3 && b == 92)
		{
			return -89;
		}
		else if(a == 3 && b == 93)
		{
			return -90;
		}
		else if(a == 3 && b == 94)
		{
			return -91;
		}
		else if(a == 3 && b == 95)
		{
			return -92;
		}
		else if(a == 3 && b == 96)
		{
			return -93;
		}
		else if(a == 3 && b == 97)
		{
			return -94;
		}
		else if(a == 3 && b == 98)
		{
			return -95;
		}
		else if(a == 3 && b == 99)
		{
			return -96;
		}
		else if(a == 3 && b == 100)
		{
			return -97;
		}
		else if(a == 4 && b == 0)
		{
			return 4;
		}
		else if(a == 4 && b == 1)
		{
			return 3;
		}
		else if(a == 4 && b == 2)
		{
			return 2;
		}
		else if(a == 4 && b == 3)
		{
			return 1;
		}
		else if(a == 4 && b == 4)
		{
			return 0;
		}
		else if(a == 4 && b == 5)
		{
			return -1;
		}
		else if(a == 4 && b == 6)
		{
			return -2;
		}
		else if(a == 4 && b == 7)
		{
			return -3;
		}
		else if(a == 4 && b == 8)
		{
			return -4;
		}
		else if(a == 4 && b == 9)
		{
			return -5;
		}
		else if(a == 4 && b == 10)
		{
			return -6;
		}
		else if(a == 4 && b == 11)
		{
			return -7;
		}
		else if(a == 4 && b == 12)
		{
			return -8;
		}
		else if(a == 4 && b == 13)
		{
			return -9;
		}
		else if(a == 4 && b == 14)
		{
			return -10;
		}
		else if(a == 4 && b == 15)
		{
			return -11;
		}
		else if(a == 4 && b == 16)
		{
			return -12;
		}
		else if(a == 4 && b == 17)
		{
			return -13;
		}
		else if(a == 4 && b == 18)
		{
			return -14;
		}
		else if(a == 4 && b == 19)
		{
			return -15;
		}
		else if(a == 4 && b == 20)
		{
			return -16;
		}
		else if(a == 4 && b == 21)
		{
			return -17;
		}
		else if(a == 4 && b == 22)
		{
			return -18;
		}
		else if(a == 4 && b == 23)
		{
			return -19;
		}
		else if(a == 4 && b == 24)
		{
			return -20;
		}
		else if(a == 4 && b == 25)
		{
			return -21;
		}
		else if(a == 4 && b == 26)
		{
			return -22;
		}
		else if(a == 4 && b == 27)
		{
			return -23;
		}
		else if(a == 4 && b == 28)
		{
			return -24;
		}
		else if(a == 4 && b == 29)
		{
			return -25;
		}
		else if(a == 4 && b == 30)
		{
			return -26;
		}
		else if(a == 4 && b == 31)
		{
			return -27;
		}
		else if(a == 4 && b == 32)
		{
			return -28;
		}
		else if(a == 4 && b == 33)
		{
			return -29;
		}
		else if(a == 4 && b == 34)
		{
			return -30;
		}
		else if(a == 4 && b == 35)
		{
			return -31;
		}
		else if(a == 4 && b == 36)
		{
			return -32;
		}
		else if(a == 4 && b == 37)
		{
			return -33;
		}
		else if(a == 4 && b == 38)
		{
			return -34;
		}
		else if(a == 4 && b == 39)
		{
			return -35;
		}
		else if(a == 4 && b == 40)
		{
			return -36;
		}
		else if(a == 4 && b == 41)
		{
			return -37;
		}
		else if(a == 4 && b == 42)
		{
			return -38;
		}
		else if(a == 4 && b == 43)
		{
			return -39;
		}
		else if(a == 4 && b == 44)
		{
			return -40;
		}
		else if(a == 4 && b == 45)
		{
			return -41;
		}
		else if(a == 4 && b == 46)
		{
			return -42;
		}
		else if(a == 4 && b == 47)
		{
			return -43;
		}
		else if(a == 4 && b == 48)
		{
			return -44;
		}
		else if(a == 4 && b == 49)
		{
			return -45;
		}
		else if(a == 4 && b == 50)
		{
			return -46;
		}
		else if(a == 4 && b == 51)
		{
			return -47;
		}
		else if(a == 4 && b == 52)
		{
			return -48;
		}
		else if(a == 4 && b == 53)
		{
			return -49;
		}
		else if(a == 4 && b == 54)
		{
			return -50;
		}
		else if(a == 4 && b == 55)
		{
			return -51;
		}
		else if(a == 4 && b == 56)
		{
			return -52;
		}
		else if(a == 4 && b == 57)
		{
			return -53;
		}
		else if(a == 4 && b == 58)
		{
			return -54;
		}
		else if(a == 4 && b == 59)
		{
			return -55;
		}
		else if(a == 4 && b == 60)
		{
			return -56;
		}
		else if(a == 4 && b == 61)
		{
			return -57;
		}
		else if(a == 4 && b == 62)
		{
			return -58;
		}
		else if(a == 4 && b == 63)
		{
			return -59;
		}
		else if(a == 4 && b == 64)
		{
			return -60;
		}
		else if(a == 4 && b == 65)
		{
			return -61;
		}
		else if(a == 4 && b == 66)
		{
			return -62;
		}
		else if(a == 4 && b == 67)
		{
			return -63;
		}
		else if(a == 4 && b == 68)
		{
			return -64;
		}
		else if(a == 4 && b == 69)
		{
			return -65;
		}
		else if(a == 4 && b == 70)
		{
			return -66;
		}
		else if(a == 4 && b == 71)
		{
			return -67;
		}
		else if(a == 4 && b == 72)
		{
			return -68;
		}
		else if(a == 4 && b == 73)
		{
			return -69;
		}
		else if(a == 4 && b == 74)
		{
			return -70;
		}
		else if(a == 4 && b == 75)
		{
			return -71;
		}
		else if(a == 4 && b == 76)
		{
			return -72;
		}
		else if(a == 4 && b == 77)
		{
			return -73;
		}
		else if(a == 4 && b == 78)
		{
			return -74;
		}
		else if(a == 4 && b == 79)
		{
			return -75;
		}
		else if(a == 4 && b == 80)
		{
			return -76;
		}
		else if(a == 4 && b == 81)
		{
			return -77;
		}
		else if(a == 4 && b == 82)
		{
			return -78;
		}
		else if(a == 4 && b == 83)
		{
			return -79;
		}
		else if(a == 4 && b == 84)
		{
			return -80;
		}
		else if(a == 4 && b == 85)
		{
			return -81;
		}
		else if(a == 4 && b == 86)
		{
			return -82;
		}
		else if(a == 4 && b == 87)
		{
			return -83;
		}
		else if(a == 4 && b == 88)
		{
			return -84;
		}
		else if(a == 4 && b == 89)
		{
			return -85;
		}
		else if(a == 4 && b == 90)
		{
			return -86;
		}
		else if(a == 4 && b == 91)
		{
			return -87;
		}
		else if(a == 4 && b == 92)
		{
			return -88;
		}
		else if(a == 4 && b == 93)
		{
			return -89;
		}
		else if(a == 4 && b == 94)
		{
			return -90;
		}
		else if(a == 4 && b == 95)
		{
			return -91;
		}
		else if(a == 4 && b == 96)
		{
			return -92;
		}
		else if(a == 4 && b == 97)
		{
			return -93;
		}
		else if(a == 4 && b == 98)
		{
			return -94;
		}
		else if(a == 4 && b == 99)
		{
			return -95;
		}
		else if(a == 4 && b == 100)
		{
			return -96;
		}
		else if(a == 5 && b == 0)
		{
			return 5;
		}
		else if(a == 5 && b == 1)
		{
			return 4;
		}
		else if(a == 5 && b == 2)
		{
			return 3;
		}
		else if(a == 5 && b == 3)
		{
			return 2;
		}
		else if(a == 5 && b == 4)
		{
			return 1;
		}
		else if(a == 5 && b == 5)
		{
			return 0;
		}
		else if(a == 5 && b == 6)
		{
			return -1;
		}
		else if(a == 5 && b == 7)
		{
			return -2;
		}
		else if(a == 5 && b == 8)
		{
			return -3;
		}
		else if(a == 5 && b == 9)
		{
			return -4;
		}
		else if(a == 5 && b == 10)
		{
			return -5;
		}
		else if(a == 5 && b == 11)
		{
			return -6;
		}
		else if(a == 5 && b == 12)
		{
			return -7;
		}
		else if(a == 5 && b == 13)
		{
			return -8;
		}
		else if(a == 5 && b == 14)
		{
			return -9;
		}
		else if(a == 5 && b == 15)
		{
			return -10;
		}
		else if(a == 5 && b == 16)
		{
			return -11;
		}
		else if(a == 5 && b == 17)
		{
			return -12;
		}
		else if(a == 5 && b == 18)
		{
			return -13;
		}
		else if(a == 5 && b == 19)
		{
			return -14;
		}
		else if(a == 5 && b == 20)
		{
			return -15;
		}
		else if(a == 5 && b == 21)
		{
			return -16;
		}
		else if(a == 5 && b == 22)
		{
			return -17;
		}
		else if(a == 5 && b == 23)
		{
			return -18;
		}
		else if(a == 5 && b == 24)
		{
			return -19;
		}
		else if(a == 5 && b == 25)
		{
			return -20;
		}
		else if(a == 5 && b == 26)
		{
			return -21;
		}
		else if(a == 5 && b == 27)
		{
			return -22;
		}
		else if(a == 5 && b == 28)
		{
			return -23;
		}
		else if(a == 5 && b == 29)
		{
			return -24;
		}
		else if(a == 5 && b == 30)
		{
			return -25;
		}
		else if(a == 5 && b == 31)
		{
			return -26;
		}
		else if(a == 5 && b == 32)
		{
			return -27;
		}
		else if(a == 5 && b == 33)
		{
			return -28;
		}
		else if(a == 5 && b == 34)
		{
			return -29;
		}
		else if(a == 5 && b == 35)
		{
			return -30;
		}
		else if(a == 5 && b == 36)
		{
			return -31;
		}
		else if(a == 5 && b == 37)
		{
			return -32;
		}
		else if(a == 5 && b == 38)
		{
			return -33;
		}
		else if(a == 5 && b == 39)
		{
			return -34;
		}
		else if(a == 5 && b == 40)
		{
			return -35;
		}
		else if(a == 5 && b == 41)
		{
			return -36;
		}
		else if(a == 5 && b == 42)
		{
			return -37;
		}
		else if(a == 5 && b == 43)
		{
			return -38;
		}
		else if(a == 5 && b == 44)
		{
			return -39;
		}
		else if(a == 5 && b == 45)
		{
			return -40;
		}
		else if(a == 5 && b == 46)
		{
			return -41;
		}
		else if(a == 5 && b == 47)
		{
			return -42;
		}
		else if(a == 5 && b == 48)
		{
			return -43;
		}
		else if(a == 5 && b == 49)
		{
			return -44;
		}
		else if(a == 5 && b == 50)
		{
			return -45;
		}
		else if(a == 5 && b == 51)
		{
			return -46;
		}
		else if(a == 5 && b == 52)
		{
			return -47;
		}
		else if(a == 5 && b == 53)
		{
			return -48;
		}
		else if(a == 5 && b == 54)
		{
			return -49;
		}
		else if(a == 5 && b == 55)
		{
			return -50;
		}
		else if(a == 5 && b == 56)
		{
			return -51;
		}
		else if(a == 5 && b == 57)
		{
			return -52;
		}
		else if(a == 5 && b == 58)
		{
			return -53;
		}
		else if(a == 5 && b == 59)
		{
			return -54;
		}
		else if(a == 5 && b == 60)
		{
			return -55;
		}
		else if(a == 5 && b == 61)
		{
			return -56;
		}
		else if(a == 5 && b == 62)
		{
			return -57;
		}
		else if(a == 5 && b == 63)
		{
			return -58;
		}
		else if(a == 5 && b == 64)
		{
			return -59;
		}
		else if(a == 5 && b == 65)
		{
			return -60;
		}
		else if(a == 5 && b == 66)
		{
			return -61;
		}
		else if(a == 5 && b == 67)
		{
			return -62;
		}
		else if(a == 5 && b == 68)
		{
			return -63;
		}
		else if(a == 5 && b == 69)
		{
			return -64;
		}
		else if(a == 5 && b == 70)
		{
			return -65;
		}
		else if(a == 5 && b == 71)
		{
			return -66;
		}
		else if(a == 5 && b == 72)
		{
			return -67;
		}
		else if(a == 5 && b == 73)
		{
			return -68;
		}
		else if(a == 5 && b == 74)
		{
			return -69;
		}
		else if(a == 5 && b == 75)
		{
			return -70;
		}
		else if(a == 5 && b == 76)
		{
			return -71;
		}
		else if(a == 5 && b == 77)
		{
			return -72;
		}
		else if(a == 5 && b == 78)
		{
			return -73;
		}
		else if(a == 5 && b == 79)
		{
			return -74;
		}
		else if(a == 5 && b == 80)
		{
			return -75;
		}
		else if(a == 5 && b == 81)
		{
			return -76;
		}
		else if(a == 5 && b == 82)
		{
			return -77;
		}
		else if(a == 5 && b == 83)
		{
			return -78;
		}
		else if(a == 5 && b == 84)
		{
			return -79;
		}
		else if(a == 5 && b == 85)
		{
			return -80;
		}
		else if(a == 5 && b == 86)
		{
			return -81;
		}
		else if(a == 5 && b == 87)
		{
			return -82;
		}
		else if(a == 5 && b == 88)
		{
			return -83;
		}
		else if(a == 5 && b == 89)
		{
			return -84;
		}
		else if(a == 5 && b == 90)
		{
			return -85;
		}
		else if(a == 5 && b == 91)
		{
			return -86;
		}
		else if(a == 5 && b == 92)
		{
			return -87;
		}
		else if(a == 5 && b == 93)
		{
			return -88;
		}
		else if(a == 5 && b == 94)
		{
			return -89;
		}
		else if(a == 5 && b == 95)
		{
			return -90;
		}
		else if(a == 5 && b == 96)
		{
			return -91;
		}
		else if(a == 5 && b == 97)
		{
			return -92;
		}
		else if(a == 5 && b == 98)
		{
			return -93;
		}
		else if(a == 5 && b == 99)
		{
			return -94;
		}
		else if(a == 5 && b == 100)
		{
			return -95;
		}
		else if(a == 6 && b == 0)
		{
			return 6;
		}
		else if(a == 6 && b == 1)
		{
			return 5;
		}
		else if(a == 6 && b == 2)
		{
			return 4;
		}
		else if(a == 6 && b == 3)
		{
			return 3;
		}
		else if(a == 6 && b == 4)
		{
			return 2;
		}
		else if(a == 6 && b == 5)
		{
			return 1;
		}
		else if(a == 6 && b == 6)
		{
			return 0;
		}
		else if(a == 6 && b == 7)
		{
			return -1;
		}
		else if(a == 6 && b == 8)
		{
			return -2;
		}
		else if(a == 6 && b == 9)
		{
			return -3;
		}
		else if(a == 6 && b == 10)
		{
			return -4;
		}
		else if(a == 6 && b == 11)
		{
			return -5;
		}
		else if(a == 6 && b == 12)
		{
			return -6;
		}
		else if(a == 6 && b == 13)
		{
			return -7;
		}
		else if(a == 6 && b == 14)
		{
			return -8;
		}
		else if(a == 6 && b == 15)
		{
			return -9;
		}
		else if(a == 6 && b == 16)
		{
			return -10;
		}
		else if(a == 6 && b == 17)
		{
			return -11;
		}
		else if(a == 6 && b == 18)
		{
			return -12;
		}
		else if(a == 6 && b == 19)
		{
			return -13;
		}
		else if(a == 6 && b == 20)
		{
			return -14;
		}
		else if(a == 6 && b == 21)
		{
			return -15;
		}
		else if(a == 6 && b == 22)
		{
			return -16;
		}
		else if(a == 6 && b == 23)
		{
			return -17;
		}
		else if(a == 6 && b == 24)
		{
			return -18;
		}
		else if(a == 6 && b == 25)
		{
			return -19;
		}
		else if(a == 6 && b == 26)
		{
			return -20;
		}
		else if(a == 6 && b == 27)
		{
			return -21;
		}
		else if(a == 6 && b == 28)
		{
			return -22;
		}
		else if(a == 6 && b == 29)
		{
			return -23;
		}
		else if(a == 6 && b == 30)
		{
			return -24;
		}
		else if(a == 6 && b == 31)
		{
			return -25;
		}
		else if(a == 6 && b == 32)
		{
			return -26;
		}
		else if(a == 6 && b == 33)
		{
			return -27;
		}
		else if(a == 6 && b == 34)
		{
			return -28;
		}
		else if(a == 6 && b == 35)
		{
			return -29;
		}
		else if(a == 6 && b == 36)
		{
			return -30;
		}
		else if(a == 6 && b == 37)
		{
			return -31;
		}
		else if(a == 6 && b == 38)
		{
			return -32;
		}
		else if(a == 6 && b == 39)
		{
			return -33;
		}
		else if(a == 6 && b == 40)
		{
			return -34;
		}
		else if(a == 6 && b == 41)
		{
			return -35;
		}
		else if(a == 6 && b == 42)
		{
			return -36;
		}
		else if(a == 6 && b == 43)
		{
			return -37;
		}
		else if(a == 6 && b == 44)
		{
			return -38;
		}
		else if(a == 6 && b == 45)
		{
			return -39;
		}
		else if(a == 6 && b == 46)
		{
			return -40;
		}
		else if(a == 6 && b == 47)
		{
			return -41;
		}
		else if(a == 6 && b == 48)
		{
			return -42;
		}
		else if(a == 6 && b == 49)
		{
			return -43;
		}
		else if(a == 6 && b == 50)
		{
			return -44;
		}
		else if(a == 6 && b == 51)
		{
			return -45;
		}
		else if(a == 6 && b == 52)
		{
			return -46;
		}
		else if(a == 6 && b == 53)
		{
			return -47;
		}
		else if(a == 6 && b == 54)
		{
			return -48;
		}
		else if(a == 6 && b == 55)
		{
			return -49;
		}
		else if(a == 6 && b == 56)
		{
			return -50;
		}
		else if(a == 6 && b == 57)
		{
			return -51;
		}
		else if(a == 6 && b == 58)
		{
			return -52;
		}
		else if(a == 6 && b == 59)
		{
			return -53;
		}
		else if(a == 6 && b == 60)
		{
			return -54;
		}
		else if(a == 6 && b == 61)
		{
			return -55;
		}
		else if(a == 6 && b == 62)
		{
			return -56;
		}
		else if(a == 6 && b == 63)
		{
			return -57;
		}
		else if(a == 6 && b == 64)
		{
			return -58;
		}
		else if(a == 6 && b == 65)
		{
			return -59;
		}
		else if(a == 6 && b == 66)
		{
			return -60;
		}
		else if(a == 6 && b == 67)
		{
			return -61;
		}
		else if(a == 6 && b == 68)
		{
			return -62;
		}
		else if(a == 6 && b == 69)
		{
			return -63;
		}
		else if(a == 6 && b == 70)
		{
			return -64;
		}
		else if(a == 6 && b == 71)
		{
			return -65;
		}
		else if(a == 6 && b == 72)
		{
			return -66;
		}
		else if(a == 6 && b == 73)
		{
			return -67;
		}
		else if(a == 6 && b == 74)
		{
			return -68;
		}
		else if(a == 6 && b == 75)
		{
			return -69;
		}
		else if(a == 6 && b == 76)
		{
			return -70;
		}
		else if(a == 6 && b == 77)
		{
			return -71;
		}
		else if(a == 6 && b == 78)
		{
			return -72;
		}
		else if(a == 6 && b == 79)
		{
			return -73;
		}
		else if(a == 6 && b == 80)
		{
			return -74;
		}
		else if(a == 6 && b == 81)
		{
			return -75;
		}
		else if(a == 6 && b == 82)
		{
			return -76;
		}
		else if(a == 6 && b == 83)
		{
			return -77;
		}
		else if(a == 6 && b == 84)
		{
			return -78;
		}
		else if(a == 6 && b == 85)
		{
			return -79;
		}
		else if(a == 6 && b == 86)
		{
			return -80;
		}
		else if(a == 6 && b == 87)
		{
			return -81;
		}
		else if(a == 6 && b == 88)
		{
			return -82;
		}
		else if(a == 6 && b == 89)
		{
			return -83;
		}
		else if(a == 6 && b == 90)
		{
			return -84;
		}
		else if(a == 6 && b == 91)
		{
			return -85;
		}
		else if(a == 6 && b == 92)
		{
			return -86;
		}
		else if(a == 6 && b == 93)
		{
			return -87;
		}
		else if(a == 6 && b == 94)
		{
			return -88;
		}
		else if(a == 6 && b == 95)
		{
			return -89;
		}
		else if(a == 6 && b == 96)
		{
			return -90;
		}
		else if(a == 6 && b == 97)
		{
			return -91;
		}
		else if(a == 6 && b == 98)
		{
			return -92;
		}
		else if(a == 6 && b == 99)
		{
			return -93;
		}
		else if(a == 6 && b == 100)
		{
			return -94;
		}
		else if(a == 7 && b == 0)
		{
			return 7;
		}
		else if(a == 7 && b == 1)
		{
			return 6;
		}
		else if(a == 7 && b == 2)
		{
			return 5;
		}
		else if(a == 7 && b == 3)
		{
			return 4;
		}
		else if(a == 7 && b == 4)
		{
			return 3;
		}
		else if(a == 7 && b == 5)
		{
			return 2;
		}
		else if(a == 7 && b == 6)
		{
			return 1;
		}
		else if(a == 7 && b == 7)
		{
			return 0;
		}
		else if(a == 7 && b == 8)
		{
			return -1;
		}
		else if(a == 7 && b == 9)
		{
			return -2;
		}
		else if(a == 7 && b == 10)
		{
			return -3;
		}
		else if(a == 7 && b == 11)
		{
			return -4;
		}
		else if(a == 7 && b == 12)
		{
			return -5;
		}
		else if(a == 7 && b == 13)
		{
			return -6;
		}
		else if(a == 7 && b == 14)
		{
			return -7;
		}
		else if(a == 7 && b == 15)
		{
			return -8;
		}
		else if(a == 7 && b == 16)
		{
			return -9;
		}
		else if(a == 7 && b == 17)
		{
			return -10;
		}
		else if(a == 7 && b == 18)
		{
			return -11;
		}
		else if(a == 7 && b == 19)
		{
			return -12;
		}
		else if(a == 7 && b == 20)
		{
			return -13;
		}
		else if(a == 7 && b == 21)
		{
			return -14;
		}
		else if(a == 7 && b == 22)
		{
			return -15;
		}
		else if(a == 7 && b == 23)
		{
			return -16;
		}
		else if(a == 7 && b == 24)
		{
			return -17;
		}
		else if(a == 7 && b == 25)
		{
			return -18;
		}
		else if(a == 7 && b == 26)
		{
			return -19;
		}
		else if(a == 7 && b == 27)
		{
			return -20;
		}
		else if(a == 7 && b == 28)
		{
			return -21;
		}
		else if(a == 7 && b == 29)
		{
			return -22;
		}
		else if(a == 7 && b == 30)
		{
			return -23;
		}
		else if(a == 7 && b == 31)
		{
			return -24;
		}
		else if(a == 7 && b == 32)
		{
			return -25;
		}
		else if(a == 7 && b == 33)
		{
			return -26;
		}
		else if(a == 7 && b == 34)
		{
			return -27;
		}
		else if(a == 7 && b == 35)
		{
			return -28;
		}
		else if(a == 7 && b == 36)
		{
			return -29;
		}
		else if(a == 7 && b == 37)
		{
			return -30;
		}
		else if(a == 7 && b == 38)
		{
			return -31;
		}
		else if(a == 7 && b == 39)
		{
			return -32;
		}
		else if(a == 7 && b == 40)
		{
			return -33;
		}
		else if(a == 7 && b == 41)
		{
			return -34;
		}
		else if(a == 7 && b == 42)
		{
			return -35;
		}
		else if(a == 7 && b == 43)
		{
			return -36;
		}
		else if(a == 7 && b == 44)
		{
			return -37;
		}
		else if(a == 7 && b == 45)
		{
			return -38;
		}
		else if(a == 7 && b == 46)
		{
			return -39;
		}
		else if(a == 7 && b == 47)
		{
			return -40;
		}
		else if(a == 7 && b == 48)
		{
			return -41;
		}
		else if(a == 7 && b == 49)
		{
			return -42;
		}
		else if(a == 7 && b == 50)
		{
			return -43;
		}
		else if(a == 7 && b == 51)
		{
			return -44;
		}
		else if(a == 7 && b == 52)
		{
			return -45;
		}
		else if(a == 7 && b == 53)
		{
			return -46;
		}
		else if(a == 7 && b == 54)
		{
			return -47;
		}
		else if(a == 7 && b == 55)
		{
			return -48;
		}
		else if(a == 7 && b == 56)
		{
			return -49;
		}
		else if(a == 7 && b == 57)
		{
			return -50;
		}
		else if(a == 7 && b == 58)
		{
			return -51;
		}
		else if(a == 7 && b == 59)
		{
			return -52;
		}
		else if(a == 7 && b == 60)
		{
			return -53;
		}
		else if(a == 7 && b == 61)
		{
			return -54;
		}
		else if(a == 7 && b == 62)
		{
			return -55;
		}
		else if(a == 7 && b == 63)
		{
			return -56;
		}
		else if(a == 7 && b == 64)
		{
			return -57;
		}
		else if(a == 7 && b == 65)
		{
			return -58;
		}
		else if(a == 7 && b == 66)
		{
			return -59;
		}
		else if(a == 7 && b == 67)
		{
			return -60;
		}
		else if(a == 7 && b == 68)
		{
			return -61;
		}
		else if(a == 7 && b == 69)
		{
			return -62;
		}
		else if(a == 7 && b == 70)
		{
			return -63;
		}
		else if(a == 7 && b == 71)
		{
			return -64;
		}
		else if(a == 7 && b == 72)
		{
			return -65;
		}
		else if(a == 7 && b == 73)
		{
			return -66;
		}
		else if(a == 7 && b == 74)
		{
			return -67;
		}
		else if(a == 7 && b == 75)
		{
			return -68;
		}
		else if(a == 7 && b == 76)
		{
			return -69;
		}
		else if(a == 7 && b == 77)
		{
			return -70;
		}
		else if(a == 7 && b == 78)
		{
			return -71;
		}
		else if(a == 7 && b == 79)
		{
			return -72;
		}
		else if(a == 7 && b == 80)
		{
			return -73;
		}
		else if(a == 7 && b == 81)
		{
			return -74;
		}
		else if(a == 7 && b == 82)
		{
			return -75;
		}
		else if(a == 7 && b == 83)
		{
			return -76;
		}
		else if(a == 7 && b == 84)
		{
			return -77;
		}
		else if(a == 7 && b == 85)
		{
			return -78;
		}
		else if(a == 7 && b == 86)
		{
			return -79;
		}
		else if(a == 7 && b == 87)
		{
			return -80;
		}
		else if(a == 7 && b == 88)
		{
			return -81;
		}
		else if(a == 7 && b == 89)
		{
			return -82;
		}
		else if(a == 7 && b == 90)
		{
			return -83;
		}
		else if(a == 7 && b == 91)
		{
			return -84;
		}
		else if(a == 7 && b == 92)
		{
			return -85;
		}
		else if(a == 7 && b == 93)
		{
			return -86;
		}
		else if(a == 7 && b == 94)
		{
			return -87;
		}
		else if(a == 7 && b == 95)
		{
			return -88;
		}
		else if(a == 7 && b == 96)
		{
			return -89;
		}
		else if(a == 7 && b == 97)
		{
			return -90;
		}
		else if(a == 7 && b == 98)
		{
			return -91;
		}
		else if(a == 7 && b == 99)
		{
			return -92;
		}
		else if(a == 7 && b == 100)
		{
			return -93;
		}
		else if(a == 8 && b == 0)
		{
			return 8;
		}
		else if(a == 8 && b == 1)
		{
			return 7;
		}
		else if(a == 8 && b == 2)
		{
			return 6;
		}
		else if(a == 8 && b == 3)
		{
			return 5;
		}
		else if(a == 8 && b == 4)
		{
			return 4;
		}
		else if(a == 8 && b == 5)
		{
			return 3;
		}
		else if(a == 8 && b == 6)
		{
			return 2;
		}
		else if(a == 8 && b == 7)
		{
			return 1;
		}
		else if(a == 8 && b == 8)
		{
			return 0;
		}
		else if(a == 8 && b == 9)
		{
			return -1;
		}
		else if(a == 8 && b == 10)
		{
			return -2;
		}
		else if(a == 8 && b == 11)
		{
			return -3;
		}
		else if(a == 8 && b == 12)
		{
			return -4;
		}
		else if(a == 8 && b == 13)
		{
			return -5;
		}
		else if(a == 8 && b == 14)
		{
			return -6;
		}
		else if(a == 8 && b == 15)
		{
			return -7;
		}
		else if(a == 8 && b == 16)
		{
			return -8;
		}
		else if(a == 8 && b == 17)
		{
			return -9;
		}
		else if(a == 8 && b == 18)
		{
			return -10;
		}
		else if(a == 8 && b == 19)
		{
			return -11;
		}
		else if(a == 8 && b == 20)
		{
			return -12;
		}
		else if(a == 8 && b == 21)
		{
			return -13;
		}
		else if(a == 8 && b == 22)
		{
			return -14;
		}
		else if(a == 8 && b == 23)
		{
			return -15;
		}
		else if(a == 8 && b == 24)
		{
			return -16;
		}
		else if(a == 8 && b == 25)
		{
			return -17;
		}
		else if(a == 8 && b == 26)
		{
			return -18;
		}
		else if(a == 8 && b == 27)
		{
			return -19;
		}
		else if(a == 8 && b == 28)
		{
			return -20;
		}
		else if(a == 8 && b == 29)
		{
			return -21;
		}
		else if(a == 8 && b == 30)
		{
			return -22;
		}
		else if(a == 8 && b == 31)
		{
			return -23;
		}
		else if(a == 8 && b == 32)
		{
			return -24;
		}
		else if(a == 8 && b == 33)
		{
			return -25;
		}
		else if(a == 8 && b == 34)
		{
			return -26;
		}
		else if(a == 8 && b == 35)
		{
			return -27;
		}
		else if(a == 8 && b == 36)
		{
			return -28;
		}
		else if(a == 8 && b == 37)
		{
			return -29;
		}
		else if(a == 8 && b == 38)
		{
			return -30;
		}
		else if(a == 8 && b == 39)
		{
			return -31;
		}
		else if(a == 8 && b == 40)
		{
			return -32;
		}
		else if(a == 8 && b == 41)
		{
			return -33;
		}
		else if(a == 8 && b == 42)
		{
			return -34;
		}
		else if(a == 8 && b == 43)
		{
			return -35;
		}
		else if(a == 8 && b == 44)
		{
			return -36;
		}
		else if(a == 8 && b == 45)
		{
			return -37;
		}
		else if(a == 8 && b == 46)
		{
			return -38;
		}
		else if(a == 8 && b == 47)
		{
			return -39;
		}
		else if(a == 8 && b == 48)
		{
			return -40;
		}
		else if(a == 8 && b == 49)
		{
			return -41;
		}
		else if(a == 8 && b == 50)
		{
			return -42;
		}
		else if(a == 8 && b == 51)
		{
			return -43;
		}
		else if(a == 8 && b == 52)
		{
			return -44;
		}
		else if(a == 8 && b == 53)
		{
			return -45;
		}
		else if(a == 8 && b == 54)
		{
			return -46;
		}
		else if(a == 8 && b == 55)
		{
			return -47;
		}
		else if(a == 8 && b == 56)
		{
			return -48;
		}
		else if(a == 8 && b == 57)
		{
			return -49;
		}
		else if(a == 8 && b == 58)
		{
			return -50;
		}
		else if(a == 8 && b == 59)
		{
			return -51;
		}
		else if(a == 8 && b == 60)
		{
			return -52;
		}
		else if(a == 8 && b == 61)
		{
			return -53;
		}
		else if(a == 8 && b == 62)
		{
			return -54;
		}
		else if(a == 8 && b == 63)
		{
			return -55;
		}
		else if(a == 8 && b == 64)
		{
			return -56;
		}
		else if(a == 8 && b == 65)
		{
			return -57;
		}
		else if(a == 8 && b == 66)
		{
			return -58;
		}
		else if(a == 8 && b == 67)
		{
			return -59;
		}
		else if(a == 8 && b == 68)
		{
			return -60;
		}
		else if(a == 8 && b == 69)
		{
			return -61;
		}
		else if(a == 8 && b == 70)
		{
			return -62;
		}
		else if(a == 8 && b == 71)
		{
			return -63;
		}
		else if(a == 8 && b == 72)
		{
			return -64;
		}
		else if(a == 8 && b == 73)
		{
			return -65;
		}
		else if(a == 8 && b == 74)
		{
			return -66;
		}
		else if(a == 8 && b == 75)
		{
			return -67;
		}
		else if(a == 8 && b == 76)
		{
			return -68;
		}
		else if(a == 8 && b == 77)
		{
			return -69;
		}
		else if(a == 8 && b == 78)
		{
			return -70;
		}
		else if(a == 8 && b == 79)
		{
			return -71;
		}
		else if(a == 8 && b == 80)
		{
			return -72;
		}
		else if(a == 8 && b == 81)
		{
			return -73;
		}
		else if(a == 8 && b == 82)
		{
			return -74;
		}
		else if(a == 8 && b == 83)
		{
			return -75;
		}
		else if(a == 8 && b == 84)
		{
			return -76;
		}
		else if(a == 8 && b == 85)
		{
			return -77;
		}
		else if(a == 8 && b == 86)
		{
			return -78;
		}
		else if(a == 8 && b == 87)
		{
			return -79;
		}
		else if(a == 8 && b == 88)
		{
			return -80;
		}
		else if(a == 8 && b == 89)
		{
			return -81;
		}
		else if(a == 8 && b == 90)
		{
			return -82;
		}
		else if(a == 8 && b == 91)
		{
			return -83;
		}
		else if(a == 8 && b == 92)
		{
			return -84;
		}
		else if(a == 8 && b == 93)
		{
			return -85;
		}
		else if(a == 8 && b == 94)
		{
			return -86;
		}
		else if(a == 8 && b == 95)
		{
			return -87;
		}
		else if(a == 8 && b == 96)
		{
			return -88;
		}
		else if(a == 8 && b == 97)
		{
			return -89;
		}
		else if(a == 8 && b == 98)
		{
			return -90;
		}
		else if(a == 8 && b == 99)
		{
			return -91;
		}
		else if(a == 8 && b == 100)
		{
			return -92;
		}
		else if(a == 9 && b == 0)
		{
			return 9;
		}
		else if(a == 9 && b == 1)
		{
			return 8;
		}
		else if(a == 9 && b == 2)
		{
			return 7;
		}
		else if(a == 9 && b == 3)
		{
			return 6;
		}
		else if(a == 9 && b == 4)
		{
			return 5;
		}
		else if(a == 9 && b == 5)
		{
			return 4;
		}
		else if(a == 9 && b == 6)
		{
			return 3;
		}
		else if(a == 9 && b == 7)
		{
			return 2;
		}
		else if(a == 9 && b == 8)
		{
			return 1;
		}
		else if(a == 9 && b == 9)
		{
			return 0;
		}
		else if(a == 9 && b == 10)
		{
			return -1;
		}
		else if(a == 9 && b == 11)
		{
			return -2;
		}
		else if(a == 9 && b == 12)
		{
			return -3;
		}
		else if(a == 9 && b == 13)
		{
			return -4;
		}
		else if(a == 9 && b == 14)
		{
			return -5;
		}
		else if(a == 9 && b == 15)
		{
			return -6;
		}
		else if(a == 9 && b == 16)
		{
			return -7;
		}
		else if(a == 9 && b == 17)
		{
			return -8;
		}
		else if(a == 9 && b == 18)
		{
			return -9;
		}
		else if(a == 9 && b == 19)
		{
			return -10;
		}
		else if(a == 9 && b == 20)
		{
			return -11;
		}
		else if(a == 9 && b == 21)
		{
			return -12;
		}
		else if(a == 9 && b == 22)
		{
			return -13;
		}
		else if(a == 9 && b == 23)
		{
			return -14;
		}
		else if(a == 9 && b == 24)
		{
			return -15;
		}
		else if(a == 9 && b == 25)
		{
			return -16;
		}
		else if(a == 9 && b == 26)
		{
			return -17;
		}
		else if(a == 9 && b == 27)
		{
			return -18;
		}
		else if(a == 9 && b == 28)
		{
			return -19;
		}
		else if(a == 9 && b == 29)
		{
			return -20;
		}
		else if(a == 9 && b == 30)
		{
			return -21;
		}
		else if(a == 9 && b == 31)
		{
			return -22;
		}
		else if(a == 9 && b == 32)
		{
			return -23;
		}
		else if(a == 9 && b == 33)
		{
			return -24;
		}
		else if(a == 9 && b == 34)
		{
			return -25;
		}
		else if(a == 9 && b == 35)
		{
			return -26;
		}
		else if(a == 9 && b == 36)
		{
			return -27;
		}
		else if(a == 9 && b == 37)
		{
			return -28;
		}
		else if(a == 9 && b == 38)
		{
			return -29;
		}
		else if(a == 9 && b == 39)
		{
			return -30;
		}
		else if(a == 9 && b == 40)
		{
			return -31;
		}
		else if(a == 9 && b == 41)
		{
			return -32;
		}
		else if(a == 9 && b == 42)
		{
			return -33;
		}
		else if(a == 9 && b == 43)
		{
			return -34;
		}
		else if(a == 9 && b == 44)
		{
			return -35;
		}
		else if(a == 9 && b == 45)
		{
			return -36;
		}
		else if(a == 9 && b == 46)
		{
			return -37;
		}
		else if(a == 9 && b == 47)
		{
			return -38;
		}
		else if(a == 9 && b == 48)
		{
			return -39;
		}
		else if(a == 9 && b == 49)
		{
			return -40;
		}
		else if(a == 9 && b == 50)
		{
			return -41;
		}
		else if(a == 9 && b == 51)
		{
			return -42;
		}
		else if(a == 9 && b == 52)
		{
			return -43;
		}
		else if(a == 9 && b == 53)
		{
			return -44;
		}
		else if(a == 9 && b == 54)
		{
			return -45;
		}
		else if(a == 9 && b == 55)
		{
			return -46;
		}
		else if(a == 9 && b == 56)
		{
			return -47;
		}
		else if(a == 9 && b == 57)
		{
			return -48;
		}
		else if(a == 9 && b == 58)
		{
			return -49;
		}
		else if(a == 9 && b == 59)
		{
			return -50;
		}
		else if(a == 9 && b == 60)
		{
			return -51;
		}
		else if(a == 9 && b == 61)
		{
			return -52;
		}
		else if(a == 9 && b == 62)
		{
			return -53;
		}
		else if(a == 9 && b == 63)
		{
			return -54;
		}
		else if(a == 9 && b == 64)
		{
			return -55;
		}
		else if(a == 9 && b == 65)
		{
			return -56;
		}
		else if(a == 9 && b == 66)
		{
			return -57;
		}
		else if(a == 9 && b == 67)
		{
			return -58;
		}
		else if(a == 9 && b == 68)
		{
			return -59;
		}
		else if(a == 9 && b == 69)
		{
			return -60;
		}
		else if(a == 9 && b == 70)
		{
			return -61;
		}
		else if(a == 9 && b == 71)
		{
			return -62;
		}
		else if(a == 9 && b == 72)
		{
			return -63;
		}
		else if(a == 9 && b == 73)
		{
			return -64;
		}
		else if(a == 9 && b == 74)
		{
			return -65;
		}
		else if(a == 9 && b == 75)
		{
			return -66;
		}
		else if(a == 9 && b == 76)
		{
			return -67;
		}
		else if(a == 9 && b == 77)
		{
			return -68;
		}
		else if(a == 9 && b == 78)
		{
			return -69;
		}
		else if(a == 9 && b == 79)
		{
			return -70;
		}
		else if(a == 9 && b == 80)
		{
			return -71;
		}
		else if(a == 9 && b == 81)
		{
			return -72;
		}
		else if(a == 9 && b == 82)
		{
			return -73;
		}
		else if(a == 9 && b == 83)
		{
			return -74;
		}
		else if(a == 9 && b == 84)
		{
			return -75;
		}
		else if(a == 9 && b == 85)
		{
			return -76;
		}
		else if(a == 9 && b == 86)
		{
			return -77;
		}
		else if(a == 9 && b == 87)
		{
			return -78;
		}
		else if(a == 9 && b == 88)
		{
			return -79;
		}
		else if(a == 9 && b == 89)
		{
			return -80;
		}
		else if(a == 9 && b == 90)
		{
			return -81;
		}
		else if(a == 9 && b == 91)
		{
			return -82;
		}
		else if(a == 9 && b == 92)
		{
			return -83;
		}
		else if(a == 9 && b == 93)
		{
			return -84;
		}
		else if(a == 9 && b == 94)
		{
			return -85;
		}
		else if(a == 9 && b == 95)
		{
			return -86;
		}
		else if(a == 9 && b == 96)
		{
			return -87;
		}
		else if(a == 9 && b == 97)
		{
			return -88;
		}
		else if(a == 9 && b == 98)
		{
			return -89;
		}
		else if(a == 9 && b == 99)
		{
			return -90;
		}
		else if(a == 9 && b == 100)
		{
			return -91;
		}
		else if(a == 10 && b == 0)
		{
			return 10;
		}
		else if(a == 10 && b == 1)
		{
			return 9;
		}
		else if(a == 10 && b == 2)
		{
			return 8;
		}
		else if(a == 10 && b == 3)
		{
			return 7;
		}
		else if(a == 10 && b == 4)
		{
			return 6;
		}
		else if(a == 10 && b == 5)
		{
			return 5;
		}
		else if(a == 10 && b == 6)
		{
			return 4;
		}
		else if(a == 10 && b == 7)
		{
			return 3;
		}
		else if(a == 10 && b == 8)
		{
			return 2;
		}
		else if(a == 10 && b == 9)
		{
			return 1;
		}
		else if(a == 10 && b == 10)
		{
			return 0;
		}
		else if(a == 10 && b == 11)
		{
			return -1;
		}
		else if(a == 10 && b == 12)
		{
			return -2;
		}
		else if(a == 10 && b == 13)
		{
			return -3;
		}
		else if(a == 10 && b == 14)
		{
			return -4;
		}
		else if(a == 10 && b == 15)
		{
			return -5;
		}
		else if(a == 10 && b == 16)
		{
			return -6;
		}
		else if(a == 10 && b == 17)
		{
			return -7;
		}
		else if(a == 10 && b == 18)
		{
			return -8;
		}
		else if(a == 10 && b == 19)
		{
			return -9;
		}
		else if(a == 10 && b == 20)
		{
			return -10;
		}
		else if(a == 10 && b == 21)
		{
			return -11;
		}
		else if(a == 10 && b == 22)
		{
			return -12;
		}
		else if(a == 10 && b == 23)
		{
			return -13;
		}
		else if(a == 10 && b == 24)
		{
			return -14;
		}
		else if(a == 10 && b == 25)
		{
			return -15;
		}
		else if(a == 10 && b == 26)
		{
			return -16;
		}
		else if(a == 10 && b == 27)
		{
			return -17;
		}
		else if(a == 10 && b == 28)
		{
			return -18;
		}
		else if(a == 10 && b == 29)
		{
			return -19;
		}
		else if(a == 10 && b == 30)
		{
			return -20;
		}
		else if(a == 10 && b == 31)
		{
			return -21;
		}
		else if(a == 10 && b == 32)
		{
			return -22;
		}
		else if(a == 10 && b == 33)
		{
			return -23;
		}
		else if(a == 10 && b == 34)
		{
			return -24;
		}
		else if(a == 10 && b == 35)
		{
			return -25;
		}
		else if(a == 10 && b == 36)
		{
			return -26;
		}
		else if(a == 10 && b == 37)
		{
			return -27;
		}
		else if(a == 10 && b == 38)
		{
			return -28;
		}
		else if(a == 10 && b == 39)
		{
			return -29;
		}
		else if(a == 10 && b == 40)
		{
			return -30;
		}
		else if(a == 10 && b == 41)
		{
			return -31;
		}
		else if(a == 10 && b == 42)
		{
			return -32;
		}
		else if(a == 10 && b == 43)
		{
			return -33;
		}
		else if(a == 10 && b == 44)
		{
			return -34;
		}
		else if(a == 10 && b == 45)
		{
			return -35;
		}
		else if(a == 10 && b == 46)
		{
			return -36;
		}
		else if(a == 10 && b == 47)
		{
			return -37;
		}
		else if(a == 10 && b == 48)
		{
			return -38;
		}
		else if(a == 10 && b == 49)
		{
			return -39;
		}
		else if(a == 10 && b == 50)
		{
			return -40;
		}
		else if(a == 10 && b == 51)
		{
			return -41;
		}
		else if(a == 10 && b == 52)
		{
			return -42;
		}
		else if(a == 10 && b == 53)
		{
			return -43;
		}
		else if(a == 10 && b == 54)
		{
			return -44;
		}
		else if(a == 10 && b == 55)
		{
			return -45;
		}
		else if(a == 10 && b == 56)
		{
			return -46;
		}
		else if(a == 10 && b == 57)
		{
			return -47;
		}
		else if(a == 10 && b == 58)
		{
			return -48;
		}
		else if(a == 10 && b == 59)
		{
			return -49;
		}
		else if(a == 10 && b == 60)
		{
			return -50;
		}
		else if(a == 10 && b == 61)
		{
			return -51;
		}
		else if(a == 10 && b == 62)
		{
			return -52;
		}
		else if(a == 10 && b == 63)
		{
			return -53;
		}
		else if(a == 10 && b == 64)
		{
			return -54;
		}
		else if(a == 10 && b == 65)
		{
			return -55;
		}
		else if(a == 10 && b == 66)
		{
			return -56;
		}
		else if(a == 10 && b == 67)
		{
			return -57;
		}
		else if(a == 10 && b == 68)
		{
			return -58;
		}
		else if(a == 10 && b == 69)
		{
			return -59;
		}
		else if(a == 10 && b == 70)
		{
			return -60;
		}
		else if(a == 10 && b == 71)
		{
			return -61;
		}
		else if(a == 10 && b == 72)
		{
			return -62;
		}
		else if(a == 10 && b == 73)
		{
			return -63;
		}
		else if(a == 10 && b == 74)
		{
			return -64;
		}
		else if(a == 10 && b == 75)
		{
			return -65;
		}
		else if(a == 10 && b == 76)
		{
			return -66;
		}
		else if(a == 10 && b == 77)
		{
			return -67;
		}
		else if(a == 10 && b == 78)
		{
			return -68;
		}
		else if(a == 10 && b == 79)
		{
			return -69;
		}
		else if(a == 10 && b == 80)
		{
			return -70;
		}
		else if(a == 10 && b == 81)
		{
			return -71;
		}
		else if(a == 10 && b == 82)
		{
			return -72;
		}
		else if(a == 10 && b == 83)
		{
			return -73;
		}
		else if(a == 10 && b == 84)
		{
			return -74;
		}
		else if(a == 10 && b == 85)
		{
			return -75;
		}
		else if(a == 10 && b == 86)
		{
			return -76;
		}
		else if(a == 10 && b == 87)
		{
			return -77;
		}
		else if(a == 10 && b == 88)
		{
			return -78;
		}
		else if(a == 10 && b == 89)
		{
			return -79;
		}
		else if(a == 10 && b == 90)
		{
			return -80;
		}
		else if(a == 10 && b == 91)
		{
			return -81;
		}
		else if(a == 10 && b == 92)
		{
			return -82;
		}
		else if(a == 10 && b == 93)
		{
			return -83;
		}
		else if(a == 10 && b == 94)
		{
			return -84;
		}
		else if(a == 10 && b == 95)
		{
			return -85;
		}
		else if(a == 10 && b == 96)
		{
			return -86;
		}
		else if(a == 10 && b == 97)
		{
			return -87;
		}
		else if(a == 10 && b == 98)
		{
			return -88;
		}
		else if(a == 10 && b == 99)
		{
			return -89;
		}
		else if(a == 10 && b == 100)
		{
			return -90;
		}
		else if(a == 11 && b == 0)
		{
			return 11;
		}
		else if(a == 11 && b == 1)
		{
			return 10;
		}
		else if(a == 11 && b == 2)
		{
			return 9;
		}
		else if(a == 11 && b == 3)
		{
			return 8;
		}
		else if(a == 11 && b == 4)
		{
			return 7;
		}
		else if(a == 11 && b == 5)
		{
			return 6;
		}
		else if(a == 11 && b == 6)
		{
			return 5;
		}
		else if(a == 11 && b == 7)
		{
			return 4;
		}
		else if(a == 11 && b == 8)
		{
			return 3;
		}
		else if(a == 11 && b == 9)
		{
			return 2;
		}
		else if(a == 11 && b == 10)
		{
			return 1;
		}
		else if(a == 11 && b == 11)
		{
			return 0;
		}
		else if(a == 11 && b == 12)
		{
			return -1;
		}
		else if(a == 11 && b == 13)
		{
			return -2;
		}
		else if(a == 11 && b == 14)
		{
			return -3;
		}
		else if(a == 11 && b == 15)
		{
			return -4;
		}
		else if(a == 11 && b == 16)
		{
			return -5;
		}
		else if(a == 11 && b == 17)
		{
			return -6;
		}
		else if(a == 11 && b == 18)
		{
			return -7;
		}
		else if(a == 11 && b == 19)
		{
			return -8;
		}
		else if(a == 11 && b == 20)
		{
			return -9;
		}
		else if(a == 11 && b == 21)
		{
			return -10;
		}
		else if(a == 11 && b == 22)
		{
			return -11;
		}
		else if(a == 11 && b == 23)
		{
			return -12;
		}
		else if(a == 11 && b == 24)
		{
			return -13;
		}
		else if(a == 11 && b == 25)
		{
			return -14;
		}
		else if(a == 11 && b == 26)
		{
			return -15;
		}
		else if(a == 11 && b == 27)
		{
			return -16;
		}
		else if(a == 11 && b == 28)
		{
			return -17;
		}
		else if(a == 11 && b == 29)
		{
			return -18;
		}
		else if(a == 11 && b == 30)
		{
			return -19;
		}
		else if(a == 11 && b == 31)
		{
			return -20;
		}
		else if(a == 11 && b == 32)
		{
			return -21;
		}
		else if(a == 11 && b == 33)
		{
			return -22;
		}
		else if(a == 11 && b == 34)
		{
			return -23;
		}
		else if(a == 11 && b == 35)
		{
			return -24;
		}
		else if(a == 11 && b == 36)
		{
			return -25;
		}
		else if(a == 11 && b == 37)
		{
			return -26;
		}
		else if(a == 11 && b == 38)
		{
			return -27;
		}
		else if(a == 11 && b == 39)
		{
			return -28;
		}
		else if(a == 11 && b == 40)
		{
			return -29;
		}
		else if(a == 11 && b == 41)
		{
			return -30;
		}
		else if(a == 11 && b == 42)
		{
			return -31;
		}
		else if(a == 11 && b == 43)
		{
			return -32;
		}
		else if(a == 11 && b == 44)
		{
			return -33;
		}
		else if(a == 11 && b == 45)
		{
			return -34;
		}
		else if(a == 11 && b == 46)
		{
			return -35;
		}
		else if(a == 11 && b == 47)
		{
			return -36;
		}
		else if(a == 11 && b == 48)
		{
			return -37;
		}
		else if(a == 11 && b == 49)
		{
			return -38;
		}
		else if(a == 11 && b == 50)
		{
			return -39;
		}
		else if(a == 11 && b == 51)
		{
			return -40;
		}
		else if(a == 11 && b == 52)
		{
			return -41;
		}
		else if(a == 11 && b == 53)
		{
			return -42;
		}
		else if(a == 11 && b == 54)
		{
			return -43;
		}
		else if(a == 11 && b == 55)
		{
			return -44;
		}
		else if(a == 11 && b == 56)
		{
			return -45;
		}
		else if(a == 11 && b == 57)
		{
			return -46;
		}
		else if(a == 11 && b == 58)
		{
			return -47;
		}
		else if(a == 11 && b == 59)
		{
			return -48;
		}
		else if(a == 11 && b == 60)
		{
			return -49;
		}
		else if(a == 11 && b == 61)
		{
			return -50;
		}
		else if(a == 11 && b == 62)
		{
			return -51;
		}
		else if(a == 11 && b == 63)
		{
			return -52;
		}
		else if(a == 11 && b == 64)
		{
			return -53;
		}
		else if(a == 11 && b == 65)
		{
			return -54;
		}
		else if(a == 11 && b == 66)
		{
			return -55;
		}
		else if(a == 11 && b == 67)
		{
			return -56;
		}
		else if(a == 11 && b == 68)
		{
			return -57;
		}
		else if(a == 11 && b == 69)
		{
			return -58;
		}
		else if(a == 11 && b == 70)
		{
			return -59;
		}
		else if(a == 11 && b == 71)
		{
			return -60;
		}
		else if(a == 11 && b == 72)
		{
			return -61;
		}
		else if(a == 11 && b == 73)
		{
			return -62;
		}
		else if(a == 11 && b == 74)
		{
			return -63;
		}
		else if(a == 11 && b == 75)
		{
			return -64;
		}
		else if(a == 11 && b == 76)
		{
			return -65;
		}
		else if(a == 11 && b == 77)
		{
			return -66;
		}
		else if(a == 11 && b == 78)
		{
			return -67;
		}
		else if(a == 11 && b == 79)
		{
			return -68;
		}
		else if(a == 11 && b == 80)
		{
			return -69;
		}
		else if(a == 11 && b == 81)
		{
			return -70;
		}
		else if(a == 11 && b == 82)
		{
			return -71;
		}
		else if(a == 11 && b == 83)
		{
			return -72;
		}
		else if(a == 11 && b == 84)
		{
			return -73;
		}
		else if(a == 11 && b == 85)
		{
			return -74;
		}
		else if(a == 11 && b == 86)
		{
			return -75;
		}
		else if(a == 11 && b == 87)
		{
			return -76;
		}
		else if(a == 11 && b == 88)
		{
			return -77;
		}
		else if(a == 11 && b == 89)
		{
			return -78;
		}
		else if(a == 11 && b == 90)
		{
			return -79;
		}
		else if(a == 11 && b == 91)
		{
			return -80;
		}
		else if(a == 11 && b == 92)
		{
			return -81;
		}
		else if(a == 11 && b == 93)
		{
			return -82;
		}
		else if(a == 11 && b == 94)
		{
			return -83;
		}
		else if(a == 11 && b == 95)
		{
			return -84;
		}
		else if(a == 11 && b == 96)
		{
			return -85;
		}
		else if(a == 11 && b == 97)
		{
			return -86;
		}
		else if(a == 11 && b == 98)
		{
			return -87;
		}
		else if(a == 11 && b == 99)
		{
			return -88;
		}
		else if(a == 11 && b == 100)
		{
			return -89;
		}
		else if(a == 12 && b == 0)
		{
			return 12;
		}
		else if(a == 12 && b == 1)
		{
			return 11;
		}
		else if(a == 12 && b == 2)
		{
			return 10;
		}
		else if(a == 12 && b == 3)
		{
			return 9;
		}
		else if(a == 12 && b == 4)
		{
			return 8;
		}
		else if(a == 12 && b == 5)
		{
			return 7;
		}
		else if(a == 12 && b == 6)
		{
			return 6;
		}
		else if(a == 12 && b == 7)
		{
			return 5;
		}
		else if(a == 12 && b == 8)
		{
			return 4;
		}
		else if(a == 12 && b == 9)
		{
			return 3;
		}
		else if(a == 12 && b == 10)
		{
			return 2;
		}
		else if(a == 12 && b == 11)
		{
			return 1;
		}
		else if(a == 12 && b == 12)
		{
			return 0;
		}
		else if(a == 12 && b == 13)
		{
			return -1;
		}
		else if(a == 12 && b == 14)
		{
			return -2;
		}
		else if(a == 12 && b == 15)
		{
			return -3;
		}
		else if(a == 12 && b == 16)
		{
			return -4;
		}
		else if(a == 12 && b == 17)
		{
			return -5;
		}
		else if(a == 12 && b == 18)
		{
			return -6;
		}
		else if(a == 12 && b == 19)
		{
			return -7;
		}
		else if(a == 12 && b == 20)
		{
			return -8;
		}
		else if(a == 12 && b == 21)
		{
			return -9;
		}
		else if(a == 12 && b == 22)
		{
			return -10;
		}
		else if(a == 12 && b == 23)
		{
			return -11;
		}
		else if(a == 12 && b == 24)
		{
			return -12;
		}
		else if(a == 12 && b == 25)
		{
			return -13;
		}
		else if(a == 12 && b == 26)
		{
			return -14;
		}
		else if(a == 12 && b == 27)
		{
			return -15;
		}
		else if(a == 12 && b == 28)
		{
			return -16;
		}
		else if(a == 12 && b == 29)
		{
			return -17;
		}
		else if(a == 12 && b == 30)
		{
			return -18;
		}
		else if(a == 12 && b == 31)
		{
			return -19;
		}
		else if(a == 12 && b == 32)
		{
			return -20;
		}
		else if(a == 12 && b == 33)
		{
			return -21;
		}
		else if(a == 12 && b == 34)
		{
			return -22;
		}
		else if(a == 12 && b == 35)
		{
			return -23;
		}
		else if(a == 12 && b == 36)
		{
			return -24;
		}
		else if(a == 12 && b == 37)
		{
			return -25;
		}
		else if(a == 12 && b == 38)
		{
			return -26;
		}
		else if(a == 12 && b == 39)
		{
			return -27;
		}
		else if(a == 12 && b == 40)
		{
			return -28;
		}
		else if(a == 12 && b == 41)
		{
			return -29;
		}
		else if(a == 12 && b == 42)
		{
			return -30;
		}
		else if(a == 12 && b == 43)
		{
			return -31;
		}
		else if(a == 12 && b == 44)
		{
			return -32;
		}
		else if(a == 12 && b == 45)
		{
			return -33;
		}
		else if(a == 12 && b == 46)
		{
			return -34;
		}
		else if(a == 12 && b == 47)
		{
			return -35;
		}
		else if(a == 12 && b == 48)
		{
			return -36;
		}
		else if(a == 12 && b == 49)
		{
			return -37;
		}
		else if(a == 12 && b == 50)
		{
			return -38;
		}
		else if(a == 12 && b == 51)
		{
			return -39;
		}
		else if(a == 12 && b == 52)
		{
			return -40;
		}
		else if(a == 12 && b == 53)
		{
			return -41;
		}
		else if(a == 12 && b == 54)
		{
			return -42;
		}
		else if(a == 12 && b == 55)
		{
			return -43;
		}
		else if(a == 12 && b == 56)
		{
			return -44;
		}
		else if(a == 12 && b == 57)
		{
			return -45;
		}
		else if(a == 12 && b == 58)
		{
			return -46;
		}
		else if(a == 12 && b == 59)
		{
			return -47;
		}
		else if(a == 12 && b == 60)
		{
			return -48;
		}
		else if(a == 12 && b == 61)
		{
			return -49;
		}
		else if(a == 12 && b == 62)
		{
			return -50;
		}
		else if(a == 12 && b == 63)
		{
			return -51;
		}
		else if(a == 12 && b == 64)
		{
			return -52;
		}
		else if(a == 12 && b == 65)
		{
			return -53;
		}
		else if(a == 12 && b == 66)
		{
			return -54;
		}
		else if(a == 12 && b == 67)
		{
			return -55;
		}
		else if(a == 12 && b == 68)
		{
			return -56;
		}
		else if(a == 12 && b == 69)
		{
			return -57;
		}
		else if(a == 12 && b == 70)
		{
			return -58;
		}
		else if(a == 12 && b == 71)
		{
			return -59;
		}
		else if(a == 12 && b == 72)
		{
			return -60;
		}
		else if(a == 12 && b == 73)
		{
			return -61;
		}
		else if(a == 12 && b == 74)
		{
			return -62;
		}
		else if(a == 12 && b == 75)
		{
			return -63;
		}
		else if(a == 12 && b == 76)
		{
			return -64;
		}
		else if(a == 12 && b == 77)
		{
			return -65;
		}
		else if(a == 12 && b == 78)
		{
			return -66;
		}
		else if(a == 12 && b == 79)
		{
			return -67;
		}
		else if(a == 12 && b == 80)
		{
			return -68;
		}
		else if(a == 12 && b == 81)
		{
			return -69;
		}
		else if(a == 12 && b == 82)
		{
			return -70;
		}
		else if(a == 12 && b == 83)
		{
			return -71;
		}
		else if(a == 12 && b == 84)
		{
			return -72;
		}
		else if(a == 12 && b == 85)
		{
			return -73;
		}
		else if(a == 12 && b == 86)
		{
			return -74;
		}
		else if(a == 12 && b == 87)
		{
			return -75;
		}
		else if(a == 12 && b == 88)
		{
			return -76;
		}
		else if(a == 12 && b == 89)
		{
			return -77;
		}
		else if(a == 12 && b == 90)
		{
			return -78;
		}
		else if(a == 12 && b == 91)
		{
			return -79;
		}
		else if(a == 12 && b == 92)
		{
			return -80;
		}
		else if(a == 12 && b == 93)
		{
			return -81;
		}
		else if(a == 12 && b == 94)
		{
			return -82;
		}
		else if(a == 12 && b == 95)
		{
			return -83;
		}
		else if(a == 12 && b == 96)
		{
			return -84;
		}
		else if(a == 12 && b == 97)
		{
			return -85;
		}
		else if(a == 12 && b == 98)
		{
			return -86;
		}
		else if(a == 12 && b == 99)
		{
			return -87;
		}
		else if(a == 12 && b == 100)
		{
			return -88;
		}
		else if(a == 13 && b == 0)
		{
			return 13;
		}
		else if(a == 13 && b == 1)
		{
			return 12;
		}
		else if(a == 13 && b == 2)
		{
			return 11;
		}
		else if(a == 13 && b == 3)
		{
			return 10;
		}
		else if(a == 13 && b == 4)
		{
			return 9;
		}
		else if(a == 13 && b == 5)
		{
			return 8;
		}
		else if(a == 13 && b == 6)
		{
			return 7;
		}
		else if(a == 13 && b == 7)
		{
			return 6;
		}
		else if(a == 13 && b == 8)
		{
			return 5;
		}
		else if(a == 13 && b == 9)
		{
			return 4;
		}
		else if(a == 13 && b == 10)
		{
			return 3;
		}
		else if(a == 13 && b == 11)
		{
			return 2;
		}
		else if(a == 13 && b == 12)
		{
			return 1;
		}
		else if(a == 13 && b == 13)
		{
			return 0;
		}
		else if(a == 13 && b == 14)
		{
			return -1;
		}
		else if(a == 13 && b == 15)
		{
			return -2;
		}
		else if(a == 13 && b == 16)
		{
			return -3;
		}
		else if(a == 13 && b == 17)
		{
			return -4;
		}
		else if(a == 13 && b == 18)
		{
			return -5;
		}
		else if(a == 13 && b == 19)
		{
			return -6;
		}
		else if(a == 13 && b == 20)
		{
			return -7;
		}
		else if(a == 13 && b == 21)
		{
			return -8;
		}
		else if(a == 13 && b == 22)
		{
			return -9;
		}
		else if(a == 13 && b == 23)
		{
			return -10;
		}
		else if(a == 13 && b == 24)
		{
			return -11;
		}
		else if(a == 13 && b == 25)
		{
			return -12;
		}
		else if(a == 13 && b == 26)
		{
			return -13;
		}
		else if(a == 13 && b == 27)
		{
			return -14;
		}
		else if(a == 13 && b == 28)
		{
			return -15;
		}
		else if(a == 13 && b == 29)
		{
			return -16;
		}
		else if(a == 13 && b == 30)
		{
			return -17;
		}
		else if(a == 13 && b == 31)
		{
			return -18;
		}
		else if(a == 13 && b == 32)
		{
			return -19;
		}
		else if(a == 13 && b == 33)
		{
			return -20;
		}
		else if(a == 13 && b == 34)
		{
			return -21;
		}
		else if(a == 13 && b == 35)
		{
			return -22;
		}
		else if(a == 13 && b == 36)
		{
			return -23;
		}
		else if(a == 13 && b == 37)
		{
			return -24;
		}
		else if(a == 13 && b == 38)
		{
			return -25;
		}
		else if(a == 13 && b == 39)
		{
			return -26;
		}
		else if(a == 13 && b == 40)
		{
			return -27;
		}
		else if(a == 13 && b == 41)
		{
			return -28;
		}
		else if(a == 13 && b == 42)
		{
			return -29;
		}
		else if(a == 13 && b == 43)
		{
			return -30;
		}
		else if(a == 13 && b == 44)
		{
			return -31;
		}
		else if(a == 13 && b == 45)
		{
			return -32;
		}
		else if(a == 13 && b == 46)
		{
			return -33;
		}
		else if(a == 13 && b == 47)
		{
			return -34;
		}
		else if(a == 13 && b == 48)
		{
			return -35;
		}
		else if(a == 13 && b == 49)
		{
			return -36;
		}
		else if(a == 13 && b == 50)
		{
			return -37;
		}
		else if(a == 13 && b == 51)
		{
			return -38;
		}
		else if(a == 13 && b == 52)
		{
			return -39;
		}
		else if(a == 13 && b == 53)
		{
			return -40;
		}
		else if(a == 13 && b == 54)
		{
			return -41;
		}
		else if(a == 13 && b == 55)
		{
			return -42;
		}
		else if(a == 13 && b == 56)
		{
			return -43;
		}
		else if(a == 13 && b == 57)
		{
			return -44;
		}
		else if(a == 13 && b == 58)
		{
			return -45;
		}
		else if(a == 13 && b == 59)
		{
			return -46;
		}
		else if(a == 13 && b == 60)
		{
			return -47;
		}
		else if(a == 13 && b == 61)
		{
			return -48;
		}
		else if(a == 13 && b == 62)
		{
			return -49;
		}
		else if(a == 13 && b == 63)
		{
			return -50;
		}
		else if(a == 13 && b == 64)
		{
			return -51;
		}
		else if(a == 13 && b == 65)
		{
			return -52;
		}
		else if(a == 13 && b == 66)
		{
			return -53;
		}
		else if(a == 13 && b == 67)
		{
			return -54;
		}
		else if(a == 13 && b == 68)
		{
			return -55;
		}
		else if(a == 13 && b == 69)
		{
			return -56;
		}
		else if(a == 13 && b == 70)
		{
			return -57;
		}
		else if(a == 13 && b == 71)
		{
			return -58;
		}
		else if(a == 13 && b == 72)
		{
			return -59;
		}
		else if(a == 13 && b == 73)
		{
			return -60;
		}
		else if(a == 13 && b == 74)
		{
			return -61;
		}
		else if(a == 13 && b == 75)
		{
			return -62;
		}
		else if(a == 13 && b == 76)
		{
			return -63;
		}
		else if(a == 13 && b == 77)
		{
			return -64;
		}
		else if(a == 13 && b == 78)
		{
			return -65;
		}
		else if(a == 13 && b == 79)
		{
			return -66;
		}
		else if(a == 13 && b == 80)
		{
			return -67;
		}
		else if(a == 13 && b == 81)
		{
			return -68;
		}
		else if(a == 13 && b == 82)
		{
			return -69;
		}
		else if(a == 13 && b == 83)
		{
			return -70;
		}
		else if(a == 13 && b == 84)
		{
			return -71;
		}
		else if(a == 13 && b == 85)
		{
			return -72;
		}
		else if(a == 13 && b == 86)
		{
			return -73;
		}
		else if(a == 13 && b == 87)
		{
			return -74;
		}
		else if(a == 13 && b == 88)
		{
			return -75;
		}
		else if(a == 13 && b == 89)
		{
			return -76;
		}
		else if(a == 13 && b == 90)
		{
			return -77;
		}
		else if(a == 13 && b == 91)
		{
			return -78;
		}
		else if(a == 13 && b == 92)
		{
			return -79;
		}
		else if(a == 13 && b == 93)
		{
			return -80;
		}
		else if(a == 13 && b == 94)
		{
			return -81;
		}
		else if(a == 13 && b == 95)
		{
			return -82;
		}
		else if(a == 13 && b == 96)
		{
			return -83;
		}
		else if(a == 13 && b == 97)
		{
			return -84;
		}
		else if(a == 13 && b == 98)
		{
			return -85;
		}
		else if(a == 13 && b == 99)
		{
			return -86;
		}
		else if(a == 13 && b == 100)
		{
			return -87;
		}
		else if(a == 14 && b == 0)
		{
			return 14;
		}
		else if(a == 14 && b == 1)
		{
			return 13;
		}
		else if(a == 14 && b == 2)
		{
			return 12;
		}
		else if(a == 14 && b == 3)
		{
			return 11;
		}
		else if(a == 14 && b == 4)
		{
			return 10;
		}
		else if(a == 14 && b == 5)
		{
			return 9;
		}
		else if(a == 14 && b == 6)
		{
			return 8;
		}
		else if(a == 14 && b == 7)
		{
			return 7;
		}
		else if(a == 14 && b == 8)
		{
			return 6;
		}
		else if(a == 14 && b == 9)
		{
			return 5;
		}
		else if(a == 14 && b == 10)
		{
			return 4;
		}
		else if(a == 14 && b == 11)
		{
			return 3;
		}
		else if(a == 14 && b == 12)
		{
			return 2;
		}
		else if(a == 14 && b == 13)
		{
			return 1;
		}
		else if(a == 14 && b == 14)
		{
			return 0;
		}
		else if(a == 14 && b == 15)
		{
			return -1;
		}
		else if(a == 14 && b == 16)
		{
			return -2;
		}
		else if(a == 14 && b == 17)
		{
			return -3;
		}
		else if(a == 14 && b == 18)
		{
			return -4;
		}
		else if(a == 14 && b == 19)
		{
			return -5;
		}
		else if(a == 14 && b == 20)
		{
			return -6;
		}
		else if(a == 14 && b == 21)
		{
			return -7;
		}
		else if(a == 14 && b == 22)
		{
			return -8;
		}
		else if(a == 14 && b == 23)
		{
			return -9;
		}
		else if(a == 14 && b == 24)
		{
			return -10;
		}
		else if(a == 14 && b == 25)
		{
			return -11;
		}
		else if(a == 14 && b == 26)
		{
			return -12;
		}
		else if(a == 14 && b == 27)
		{
			return -13;
		}
		else if(a == 14 && b == 28)
		{
			return -14;
		}
		else if(a == 14 && b == 29)
		{
			return -15;
		}
		else if(a == 14 && b == 30)
		{
			return -16;
		}
		else if(a == 14 && b == 31)
		{
			return -17;
		}
		else if(a == 14 && b == 32)
		{
			return -18;
		}
		else if(a == 14 && b == 33)
		{
			return -19;
		}
		else if(a == 14 && b == 34)
		{
			return -20;
		}
		else if(a == 14 && b == 35)
		{
			return -21;
		}
		else if(a == 14 && b == 36)
		{
			return -22;
		}
		else if(a == 14 && b == 37)
		{
			return -23;
		}
		else if(a == 14 && b == 38)
		{
			return -24;
		}
		else if(a == 14 && b == 39)
		{
			return -25;
		}
		else if(a == 14 && b == 40)
		{
			return -26;
		}
		else if(a == 14 && b == 41)
		{
			return -27;
		}
		else if(a == 14 && b == 42)
		{
			return -28;
		}
		else if(a == 14 && b == 43)
		{
			return -29;
		}
		else if(a == 14 && b == 44)
		{
			return -30;
		}
		else if(a == 14 && b == 45)
		{
			return -31;
		}
		else if(a == 14 && b == 46)
		{
			return -32;
		}
		else if(a == 14 && b == 47)
		{
			return -33;
		}
		else if(a == 14 && b == 48)
		{
			return -34;
		}
		else if(a == 14 && b == 49)
		{
			return -35;
		}
		else if(a == 14 && b == 50)
		{
			return -36;
		}
		else if(a == 14 && b == 51)
		{
			return -37;
		}
		else if(a == 14 && b == 52)
		{
			return -38;
		}
		else if(a == 14 && b == 53)
		{
			return -39;
		}
		else if(a == 14 && b == 54)
		{
			return -40;
		}
		else if(a == 14 && b == 55)
		{
			return -41;
		}
		else if(a == 14 && b == 56)
		{
			return -42;
		}
		else if(a == 14 && b == 57)
		{
			return -43;
		}
		else if(a == 14 && b == 58)
		{
			return -44;
		}
		else if(a == 14 && b == 59)
		{
			return -45;
		}
		else if(a == 14 && b == 60)
		{
			return -46;
		}
		else if(a == 14 && b == 61)
		{
			return -47;
		}
		else if(a == 14 && b == 62)
		{
			return -48;
		}
		else if(a == 14 && b == 63)
		{
			return -49;
		}
		else if(a == 14 && b == 64)
		{
			return -50;
		}
		else if(a == 14 && b == 65)
		{
			return -51;
		}
		else if(a == 14 && b == 66)
		{
			return -52;
		}
		else if(a == 14 && b == 67)
		{
			return -53;
		}
		else if(a == 14 && b == 68)
		{
			return -54;
		}
		else if(a == 14 && b == 69)
		{
			return -55;
		}
		else if(a == 14 && b == 70)
		{
			return -56;
		}
		else if(a == 14 && b == 71)
		{
			return -57;
		}
		else if(a == 14 && b == 72)
		{
			return -58;
		}
		else if(a == 14 && b == 73)
		{
			return -59;
		}
		else if(a == 14 && b == 74)
		{
			return -60;
		}
		else if(a == 14 && b == 75)
		{
			return -61;
		}
		else if(a == 14 && b == 76)
		{
			return -62;
		}
		else if(a == 14 && b == 77)
		{
			return -63;
		}
		else if(a == 14 && b == 78)
		{
			return -64;
		}
		else if(a == 14 && b == 79)
		{
			return -65;
		}
		else if(a == 14 && b == 80)
		{
			return -66;
		}
		else if(a == 14 && b == 81)
		{
			return -67;
		}
		else if(a == 14 && b == 82)
		{
			return -68;
		}
		else if(a == 14 && b == 83)
		{
			return -69;
		}
		else if(a == 14 && b == 84)
		{
			return -70;
		}
		else if(a == 14 && b == 85)
		{
			return -71;
		}
		else if(a == 14 && b == 86)
		{
			return -72;
		}
		else if(a == 14 && b == 87)
		{
			return -73;
		}
		else if(a == 14 && b == 88)
		{
			return -74;
		}
		else if(a == 14 && b == 89)
		{
			return -75;
		}
		else if(a == 14 && b == 90)
		{
			return -76;
		}
		else if(a == 14 && b == 91)
		{
			return -77;
		}
		else if(a == 14 && b == 92)
		{
			return -78;
		}
		else if(a == 14 && b == 93)
		{
			return -79;
		}
		else if(a == 14 && b == 94)
		{
			return -80;
		}
		else if(a == 14 && b == 95)
		{
			return -81;
		}
		else if(a == 14 && b == 96)
		{
			return -82;
		}
		else if(a == 14 && b == 97)
		{
			return -83;
		}
		else if(a == 14 && b == 98)
		{
			return -84;
		}
		else if(a == 14 && b == 99)
		{
			return -85;
		}
		else if(a == 14 && b == 100)
		{
			return -86;
		}
		else if(a == 15 && b == 0)
		{
			return 15;
		}
		else if(a == 15 && b == 1)
		{
			return 14;
		}
		else if(a == 15 && b == 2)
		{
			return 13;
		}
		else if(a == 15 && b == 3)
		{
			return 12;
		}
		else if(a == 15 && b == 4)
		{
			return 11;
		}
		else if(a == 15 && b == 5)
		{
			return 10;
		}
		else if(a == 15 && b == 6)
		{
			return 9;
		}
		else if(a == 15 && b == 7)
		{
			return 8;
		}
		else if(a == 15 && b == 8)
		{
			return 7;
		}
		else if(a == 15 && b == 9)
		{
			return 6;
		}
		else if(a == 15 && b == 10)
		{
			return 5;
		}
		else if(a == 15 && b == 11)
		{
			return 4;
		}
		else if(a == 15 && b == 12)
		{
			return 3;
		}
		else if(a == 15 && b == 13)
		{
			return 2;
		}
		else if(a == 15 && b == 14)
		{
			return 1;
		}
		else if(a == 15 && b == 15)
		{
			return 0;
		}
		else if(a == 15 && b == 16)
		{
			return -1;
		}
		else if(a == 15 && b == 17)
		{
			return -2;
		}
		else if(a == 15 && b == 18)
		{
			return -3;
		}
		else if(a == 15 && b == 19)
		{
			return -4;
		}
		else if(a == 15 && b == 20)
		{
			return -5;
		}
		else if(a == 15 && b == 21)
		{
			return -6;
		}
		else if(a == 15 && b == 22)
		{
			return -7;
		}
		else if(a == 15 && b == 23)
		{
			return -8;
		}
		else if(a == 15 && b == 24)
		{
			return -9;
		}
		else if(a == 15 && b == 25)
		{
			return -10;
		}
		else if(a == 15 && b == 26)
		{
			return -11;
		}
		else if(a == 15 && b == 27)
		{
			return -12;
		}
		else if(a == 15 && b == 28)
		{
			return -13;
		}
		else if(a == 15 && b == 29)
		{
			return -14;
		}
		else if(a == 15 && b == 30)
		{
			return -15;
		}
		else if(a == 15 && b == 31)
		{
			return -16;
		}
		else if(a == 15 && b == 32)
		{
			return -17;
		}
		else if(a == 15 && b == 33)
		{
			return -18;
		}
		else if(a == 15 && b == 34)
		{
			return -19;
		}
		else if(a == 15 && b == 35)
		{
			return -20;
		}
		else if(a == 15 && b == 36)
		{
			return -21;
		}
		else if(a == 15 && b == 37)
		{
			return -22;
		}
		else if(a == 15 && b == 38)
		{
			return -23;
		}
		else if(a == 15 && b == 39)
		{
			return -24;
		}
		else if(a == 15 && b == 40)
		{
			return -25;
		}
		else if(a == 15 && b == 41)
		{
			return -26;
		}
		else if(a == 15 && b == 42)
		{
			return -27;
		}
		else if(a == 15 && b == 43)
		{
			return -28;
		}
		else if(a == 15 && b == 44)
		{
			return -29;
		}
		else if(a == 15 && b == 45)
		{
			return -30;
		}
		else if(a == 15 && b == 46)
		{
			return -31;
		}
		else if(a == 15 && b == 47)
		{
			return -32;
		}
		else if(a == 15 && b == 48)
		{
			return -33;
		}
		else if(a == 15 && b == 49)
		{
			return -34;
		}
		else if(a == 15 && b == 50)
		{
			return -35;
		}
		else if(a == 15 && b == 51)
		{
			return -36;
		}
		else if(a == 15 && b == 52)
		{
			return -37;
		}
		else if(a == 15 && b == 53)
		{
			return -38;
		}
		else if(a == 15 && b == 54)
		{
			return -39;
		}
		else if(a == 15 && b == 55)
		{
			return -40;
		}
		else if(a == 15 && b == 56)
		{
			return -41;
		}
		else if(a == 15 && b == 57)
		{
			return -42;
		}
		else if(a == 15 && b == 58)
		{
			return -43;
		}
		else if(a == 15 && b == 59)
		{
			return -44;
		}
		else if(a == 15 && b == 60)
		{
			return -45;
		}
		else if(a == 15 && b == 61)
		{
			return -46;
		}
		else if(a == 15 && b == 62)
		{
			return -47;
		}
		else if(a == 15 && b == 63)
		{
			return -48;
		}
		else if(a == 15 && b == 64)
		{
			return -49;
		}
		else if(a == 15 && b == 65)
		{
			return -50;
		}
		else if(a == 15 && b == 66)
		{
			return -51;
		}
		else if(a == 15 && b == 67)
		{
			return -52;
		}
		else if(a == 15 && b == 68)
		{
			return -53;
		}
		else if(a == 15 && b == 69)
		{
			return -54;
		}
		else if(a == 15 && b == 70)
		{
			return -55;
		}
		else if(a == 15 && b == 71)
		{
			return -56;
		}
		else if(a == 15 && b == 72)
		{
			return -57;
		}
		else if(a == 15 && b == 73)
		{
			return -58;
		}
		else if(a == 15 && b == 74)
		{
			return -59;
		}
		else if(a == 15 && b == 75)
		{
			return -60;
		}
		else if(a == 15 && b == 76)
		{
			return -61;
		}
		else if(a == 15 && b == 77)
		{
			return -62;
		}
		else if(a == 15 && b == 78)
		{
			return -63;
		}
		else if(a == 15 && b == 79)
		{
			return -64;
		}
		else if(a == 15 && b == 80)
		{
			return -65;
		}
		else if(a == 15 && b == 81)
		{
			return -66;
		}
		else if(a == 15 && b == 82)
		{
			return -67;
		}
		else if(a == 15 && b == 83)
		{
			return -68;
		}
		else if(a == 15 && b == 84)
		{
			return -69;
		}
		else if(a == 15 && b == 85)
		{
			return -70;
		}
		else if(a == 15 && b == 86)
		{
			return -71;
		}
		else if(a == 15 && b == 87)
		{
			return -72;
		}
		else if(a == 15 && b == 88)
		{
			return -73;
		}
		else if(a == 15 && b == 89)
		{
			return -74;
		}
		else if(a == 15 && b == 90)
		{
			return -75;
		}
		else if(a == 15 && b == 91)
		{
			return -76;
		}
		else if(a == 15 && b == 92)
		{
			return -77;
		}
		else if(a == 15 && b == 93)
		{
			return -78;
		}
		else if(a == 15 && b == 94)
		{
			return -79;
		}
		else if(a == 15 && b == 95)
		{
			return -80;
		}
		else if(a == 15 && b == 96)
		{
			return -81;
		}
		else if(a == 15 && b == 97)
		{
			return -82;
		}
		else if(a == 15 && b == 98)
		{
			return -83;
		}
		else if(a == 15 && b == 99)
		{
			return -84;
		}
		else if(a == 15 && b == 100)
		{
			return -85;
		}
		else if(a == 16 && b == 0)
		{
			return 16;
		}
		else if(a == 16 && b == 1)
		{
			return 15;
		}
		else if(a == 16 && b == 2)
		{
			return 14;
		}
		else if(a == 16 && b == 3)
		{
			return 13;
		}
		else if(a == 16 && b == 4)
		{
			return 12;
		}
		else if(a == 16 && b == 5)
		{
			return 11;
		}
		else if(a == 16 && b == 6)
		{
			return 10;
		}
		else if(a == 16 && b == 7)
		{
			return 9;
		}
		else if(a == 16 && b == 8)
		{
			return 8;
		}
		else if(a == 16 && b == 9)
		{
			return 7;
		}
		else if(a == 16 && b == 10)
		{
			return 6;
		}
		else if(a == 16 && b == 11)
		{
			return 5;
		}
		else if(a == 16 && b == 12)
		{
			return 4;
		}
		else if(a == 16 && b == 13)
		{
			return 3;
		}
		else if(a == 16 && b == 14)
		{
			return 2;
		}
		else if(a == 16 && b == 15)
		{
			return 1;
		}
		else if(a == 16 && b == 16)
		{
			return 0;
		}
		else if(a == 16 && b == 17)
		{
			return -1;
		}
		else if(a == 16 && b == 18)
		{
			return -2;
		}
		else if(a == 16 && b == 19)
		{
			return -3;
		}
		else if(a == 16 && b == 20)
		{
			return -4;
		}
		else if(a == 16 && b == 21)
		{
			return -5;
		}
		else if(a == 16 && b == 22)
		{
			return -6;
		}
		else if(a == 16 && b == 23)
		{
			return -7;
		}
		else if(a == 16 && b == 24)
		{
			return -8;
		}
		else if(a == 16 && b == 25)
		{
			return -9;
		}
		else if(a == 16 && b == 26)
		{
			return -10;
		}
		else if(a == 16 && b == 27)
		{
			return -11;
		}
		else if(a == 16 && b == 28)
		{
			return -12;
		}
		else if(a == 16 && b == 29)
		{
			return -13;
		}
		else if(a == 16 && b == 30)
		{
			return -14;
		}
		else if(a == 16 && b == 31)
		{
			return -15;
		}
		else if(a == 16 && b == 32)
		{
			return -16;
		}
		else if(a == 16 && b == 33)
		{
			return -17;
		}
		else if(a == 16 && b == 34)
		{
			return -18;
		}
		else if(a == 16 && b == 35)
		{
			return -19;
		}
		else if(a == 16 && b == 36)
		{
			return -20;
		}
		else if(a == 16 && b == 37)
		{
			return -21;
		}
		else if(a == 16 && b == 38)
		{
			return -22;
		}
		else if(a == 16 && b == 39)
		{
			return -23;
		}
		else if(a == 16 && b == 40)
		{
			return -24;
		}
		else if(a == 16 && b == 41)
		{
			return -25;
		}
		else if(a == 16 && b == 42)
		{
			return -26;
		}
		else if(a == 16 && b == 43)
		{
			return -27;
		}
		else if(a == 16 && b == 44)
		{
			return -28;
		}
		else if(a == 16 && b == 45)
		{
			return -29;
		}
		else if(a == 16 && b == 46)
		{
			return -30;
		}
		else if(a == 16 && b == 47)
		{
			return -31;
		}
		else if(a == 16 && b == 48)
		{
			return -32;
		}
		else if(a == 16 && b == 49)
		{
			return -33;
		}
		else if(a == 16 && b == 50)
		{
			return -34;
		}
		else if(a == 16 && b == 51)
		{
			return -35;
		}
		else if(a == 16 && b == 52)
		{
			return -36;
		}
		else if(a == 16 && b == 53)
		{
			return -37;
		}
		else if(a == 16 && b == 54)
		{
			return -38;
		}
		else if(a == 16 && b == 55)
		{
			return -39;
		}
		else if(a == 16 && b == 56)
		{
			return -40;
		}
		else if(a == 16 && b == 57)
		{
			return -41;
		}
		else if(a == 16 && b == 58)
		{
			return -42;
		}
		else if(a == 16 && b == 59)
		{
			return -43;
		}
		else if(a == 16 && b == 60)
		{
			return -44;
		}
		else if(a == 16 && b == 61)
		{
			return -45;
		}
		else if(a == 16 && b == 62)
		{
			return -46;
		}
		else if(a == 16 && b == 63)
		{
			return -47;
		}
		else if(a == 16 && b == 64)
		{
			return -48;
		}
		else if(a == 16 && b == 65)
		{
			return -49;
		}
		else if(a == 16 && b == 66)
		{
			return -50;
		}
		else if(a == 16 && b == 67)
		{
			return -51;
		}
		else if(a == 16 && b == 68)
		{
			return -52;
		}
		else if(a == 16 && b == 69)
		{
			return -53;
		}
		else if(a == 16 && b == 70)
		{
			return -54;
		}
		else if(a == 16 && b == 71)
		{
			return -55;
		}
		else if(a == 16 && b == 72)
		{
			return -56;
		}
		else if(a == 16 && b == 73)
		{
			return -57;
		}
		else if(a == 16 && b == 74)
		{
			return -58;
		}
		else if(a == 16 && b == 75)
		{
			return -59;
		}
		else if(a == 16 && b == 76)
		{
			return -60;
		}
		else if(a == 16 && b == 77)
		{
			return -61;
		}
		else if(a == 16 && b == 78)
		{
			return -62;
		}
		else if(a == 16 && b == 79)
		{
			return -63;
		}
		else if(a == 16 && b == 80)
		{
			return -64;
		}
		else if(a == 16 && b == 81)
		{
			return -65;
		}
		else if(a == 16 && b == 82)
		{
			return -66;
		}
		else if(a == 16 && b == 83)
		{
			return -67;
		}
		else if(a == 16 && b == 84)
		{
			return -68;
		}
		else if(a == 16 && b == 85)
		{
			return -69;
		}
		else if(a == 16 && b == 86)
		{
			return -70;
		}
		else if(a == 16 && b == 87)
		{
			return -71;
		}
		else if(a == 16 && b == 88)
		{
			return -72;
		}
		else if(a == 16 && b == 89)
		{
			return -73;
		}
		else if(a == 16 && b == 90)
		{
			return -74;
		}
		else if(a == 16 && b == 91)
		{
			return -75;
		}
		else if(a == 16 && b == 92)
		{
			return -76;
		}
		else if(a == 16 && b == 93)
		{
			return -77;
		}
		else if(a == 16 && b == 94)
		{
			return -78;
		}
		else if(a == 16 && b == 95)
		{
			return -79;
		}
		else if(a == 16 && b == 96)
		{
			return -80;
		}
		else if(a == 16 && b == 97)
		{
			return -81;
		}
		else if(a == 16 && b == 98)
		{
			return -82;
		}
		else if(a == 16 && b == 99)
		{
			return -83;
		}
		else if(a == 16 && b == 100)
		{
			return -84;
		}
		else if(a == 17 && b == 0)
		{
			return 17;
		}
		else if(a == 17 && b == 1)
		{
			return 16;
		}
		else if(a == 17 && b == 2)
		{
			return 15;
		}
		else if(a == 17 && b == 3)
		{
			return 14;
		}
		else if(a == 17 && b == 4)
		{
			return 13;
		}
		else if(a == 17 && b == 5)
		{
			return 12;
		}
		else if(a == 17 && b == 6)
		{
			return 11;
		}
		else if(a == 17 && b == 7)
		{
			return 10;
		}
		else if(a == 17 && b == 8)
		{
			return 9;
		}
		else if(a == 17 && b == 9)
		{
			return 8;
		}
		else if(a == 17 && b == 10)
		{
			return 7;
		}
		else if(a == 17 && b == 11)
		{
			return 6;
		}
		else if(a == 17 && b == 12)
		{
			return 5;
		}
		else if(a == 17 && b == 13)
		{
			return 4;
		}
		else if(a == 17 && b == 14)
		{
			return 3;
		}
		else if(a == 17 && b == 15)
		{
			return 2;
		}
		else if(a == 17 && b == 16)
		{
			return 1;
		}
		else if(a == 17 && b == 17)
		{
			return 0;
		}
		else if(a == 17 && b == 18)
		{
			return -1;
		}
		else if(a == 17 && b == 19)
		{
			return -2;
		}
		else if(a == 17 && b == 20)
		{
			return -3;
		}
		else if(a == 17 && b == 21)
		{
			return -4;
		}
		else if(a == 17 && b == 22)
		{
			return -5;
		}
		else if(a == 17 && b == 23)
		{
			return -6;
		}
		else if(a == 17 && b == 24)
		{
			return -7;
		}
		else if(a == 17 && b == 25)
		{
			return -8;
		}
		else if(a == 17 && b == 26)
		{
			return -9;
		}
		else if(a == 17 && b == 27)
		{
			return -10;
		}
		else if(a == 17 && b == 28)
		{
			return -11;
		}
		else if(a == 17 && b == 29)
		{
			return -12;
		}
		else if(a == 17 && b == 30)
		{
			return -13;
		}
		else if(a == 17 && b == 31)
		{
			return -14;
		}
		else if(a == 17 && b == 32)
		{
			return -15;
		}
		else if(a == 17 && b == 33)
		{
			return -16;
		}
		else if(a == 17 && b == 34)
		{
			return -17;
		}
		else if(a == 17 && b == 35)
		{
			return -18;
		}
		else if(a == 17 && b == 36)
		{
			return -19;
		}
		else if(a == 17 && b == 37)
		{
			return -20;
		}
		else if(a == 17 && b == 38)
		{
			return -21;
		}
		else if(a == 17 && b == 39)
		{
			return -22;
		}
		else if(a == 17 && b == 40)
		{
			return -23;
		}
		else if(a == 17 && b == 41)
		{
			return -24;
		}
		else if(a == 17 && b == 42)
		{
			return -25;
		}
		else if(a == 17 && b == 43)
		{
			return -26;
		}
		else if(a == 17 && b == 44)
		{
			return -27;
		}
		else if(a == 17 && b == 45)
		{
			return -28;
		}
		else if(a == 17 && b == 46)
		{
			return -29;
		}
		else if(a == 17 && b == 47)
		{
			return -30;
		}
		else if(a == 17 && b == 48)
		{
			return -31;
		}
		else if(a == 17 && b == 49)
		{
			return -32;
		}
		else if(a == 17 && b == 50)
		{
			return -33;
		}
		else if(a == 17 && b == 51)
		{
			return -34;
		}
		else if(a == 17 && b == 52)
		{
			return -35;
		}
		else if(a == 17 && b == 53)
		{
			return -36;
		}
		else if(a == 17 && b == 54)
		{
			return -37;
		}
		else if(a == 17 && b == 55)
		{
			return -38;
		}
		else if(a == 17 && b == 56)
		{
			return -39;
		}
		else if(a == 17 && b == 57)
		{
			return -40;
		}
		else if(a == 17 && b == 58)
		{
			return -41;
		}
		else if(a == 17 && b == 59)
		{
			return -42;
		}
		else if(a == 17 && b == 60)
		{
			return -43;
		}
		else if(a == 17 && b == 61)
		{
			return -44;
		}
		else if(a == 17 && b == 62)
		{
			return -45;
		}
		else if(a == 17 && b == 63)
		{
			return -46;
		}
		else if(a == 17 && b == 64)
		{
			return -47;
		}
		else if(a == 17 && b == 65)
		{
			return -48;
		}
		else if(a == 17 && b == 66)
		{
			return -49;
		}
		else if(a == 17 && b == 67)
		{
			return -50;
		}
		else if(a == 17 && b == 68)
		{
			return -51;
		}
		else if(a == 17 && b == 69)
		{
			return -52;
		}
		else if(a == 17 && b == 70)
		{
			return -53;
		}
		else if(a == 17 && b == 71)
		{
			return -54;
		}
		else if(a == 17 && b == 72)
		{
			return -55;
		}
		else if(a == 17 && b == 73)
		{
			return -56;
		}
		else if(a == 17 && b == 74)
		{
			return -57;
		}
		else if(a == 17 && b == 75)
		{
			return -58;
		}
		else if(a == 17 && b == 76)
		{
			return -59;
		}
		else if(a == 17 && b == 77)
		{
			return -60;
		}
		else if(a == 17 && b == 78)
		{
			return -61;
		}
		else if(a == 17 && b == 79)
		{
			return -62;
		}
		else if(a == 17 && b == 80)
		{
			return -63;
		}
		else if(a == 17 && b == 81)
		{
			return -64;
		}
		else if(a == 17 && b == 82)
		{
			return -65;
		}
		else if(a == 17 && b == 83)
		{
			return -66;
		}
		else if(a == 17 && b == 84)
		{
			return -67;
		}
		else if(a == 17 && b == 85)
		{
			return -68;
		}
		else if(a == 17 && b == 86)
		{
			return -69;
		}
		else if(a == 17 && b == 87)
		{
			return -70;
		}
		else if(a == 17 && b == 88)
		{
			return -71;
		}
		else if(a == 17 && b == 89)
		{
			return -72;
		}
		else if(a == 17 && b == 90)
		{
			return -73;
		}
		else if(a == 17 && b == 91)
		{
			return -74;
		}
		else if(a == 17 && b == 92)
		{
			return -75;
		}
		else if(a == 17 && b == 93)
		{
			return -76;
		}
		else if(a == 17 && b == 94)
		{
			return -77;
		}
		else if(a == 17 && b == 95)
		{
			return -78;
		}
		else if(a == 17 && b == 96)
		{
			return -79;
		}
		else if(a == 17 && b == 97)
		{
			return -80;
		}
		else if(a == 17 && b == 98)
		{
			return -81;
		}
		else if(a == 17 && b == 99)
		{
			return -82;
		}
		else if(a == 17 && b == 100)
		{
			return -83;
		}
		else if(a == 18 && b == 0)
		{
			return 18;
		}
		else if(a == 18 && b == 1)
		{
			return 17;
		}
		else if(a == 18 && b == 2)
		{
			return 16;
		}
		else if(a == 18 && b == 3)
		{
			return 15;
		}
		else if(a == 18 && b == 4)
		{
			return 14;
		}
		else if(a == 18 && b == 5)
		{
			return 13;
		}
		else if(a == 18 && b == 6)
		{
			return 12;
		}
		else if(a == 18 && b == 7)
		{
			return 11;
		}
		else if(a == 18 && b == 8)
		{
			return 10;
		}
		else if(a == 18 && b == 9)
		{
			return 9;
		}
		else if(a == 18 && b == 10)
		{
			return 8;
		}
		else if(a == 18 && b == 11)
		{
			return 7;
		}
		else if(a == 18 && b == 12)
		{
			return 6;
		}
		else if(a == 18 && b == 13)
		{
			return 5;
		}
		else if(a == 18 && b == 14)
		{
			return 4;
		}
		else if(a == 18 && b == 15)
		{
			return 3;
		}
		else if(a == 18 && b == 16)
		{
			return 2;
		}
		else if(a == 18 && b == 17)
		{
			return 1;
		}
		else if(a == 18 && b == 18)
		{
			return 0;
		}
		else if(a == 18 && b == 19)
		{
			return -1;
		}
		else if(a == 18 && b == 20)
		{
			return -2;
		}
		else if(a == 18 && b == 21)
		{
			return -3;
		}
		else if(a == 18 && b == 22)
		{
			return -4;
		}
		else if(a == 18 && b == 23)
		{
			return -5;
		}
		else if(a == 18 && b == 24)
		{
			return -6;
		}
		else if(a == 18 && b == 25)
		{
			return -7;
		}
		else if(a == 18 && b == 26)
		{
			return -8;
		}
		else if(a == 18 && b == 27)
		{
			return -9;
		}
		else if(a == 18 && b == 28)
		{
			return -10;
		}
		else if(a == 18 && b == 29)
		{
			return -11;
		}
		else if(a == 18 && b == 30)
		{
			return -12;
		}
		else if(a == 18 && b == 31)
		{
			return -13;
		}
		else if(a == 18 && b == 32)
		{
			return -14;
		}
		else if(a == 18 && b == 33)
		{
			return -15;
		}
		else if(a == 18 && b == 34)
		{
			return -16;
		}
		else if(a == 18 && b == 35)
		{
			return -17;
		}
		else if(a == 18 && b == 36)
		{
			return -18;
		}
		else if(a == 18 && b == 37)
		{
			return -19;
		}
		else if(a == 18 && b == 38)
		{
			return -20;
		}
		else if(a == 18 && b == 39)
		{
			return -21;
		}
		else if(a == 18 && b == 40)
		{
			return -22;
		}
		else if(a == 18 && b == 41)
		{
			return -23;
		}
		else if(a == 18 && b == 42)
		{
			return -24;
		}
		else if(a == 18 && b == 43)
		{
			return -25;
		}
		else if(a == 18 && b == 44)
		{
			return -26;
		}
		else if(a == 18 && b == 45)
		{
			return -27;
		}
		else if(a == 18 && b == 46)
		{
			return -28;
		}
		else if(a == 18 && b == 47)
		{
			return -29;
		}
		else if(a == 18 && b == 48)
		{
			return -30;
		}
		else if(a == 18 && b == 49)
		{
			return -31;
		}
		else if(a == 18 && b == 50)
		{
			return -32;
		}
		else if(a == 18 && b == 51)
		{
			return -33;
		}
		else if(a == 18 && b == 52)
		{
			return -34;
		}
		else if(a == 18 && b == 53)
		{
			return -35;
		}
		else if(a == 18 && b == 54)
		{
			return -36;
		}
		else if(a == 18 && b == 55)
		{
			return -37;
		}
		else if(a == 18 && b == 56)
		{
			return -38;
		}
		else if(a == 18 && b == 57)
		{
			return -39;
		}
		else if(a == 18 && b == 58)
		{
			return -40;
		}
		else if(a == 18 && b == 59)
		{
			return -41;
		}
		else if(a == 18 && b == 60)
		{
			return -42;
		}
		else if(a == 18 && b == 61)
		{
			return -43;
		}
		else if(a == 18 && b == 62)
		{
			return -44;
		}
		else if(a == 18 && b == 63)
		{
			return -45;
		}
		else if(a == 18 && b == 64)
		{
			return -46;
		}
		else if(a == 18 && b == 65)
		{
			return -47;
		}
		else if(a == 18 && b == 66)
		{
			return -48;
		}
		else if(a == 18 && b == 67)
		{
			return -49;
		}
		else if(a == 18 && b == 68)
		{
			return -50;
		}
		else if(a == 18 && b == 69)
		{
			return -51;
		}
		else if(a == 18 && b == 70)
		{
			return -52;
		}
		else if(a == 18 && b == 71)
		{
			return -53;
		}
		else if(a == 18 && b == 72)
		{
			return -54;
		}
		else if(a == 18 && b == 73)
		{
			return -55;
		}
		else if(a == 18 && b == 74)
		{
			return -56;
		}
		else if(a == 18 && b == 75)
		{
			return -57;
		}
		else if(a == 18 && b == 76)
		{
			return -58;
		}
		else if(a == 18 && b == 77)
		{
			return -59;
		}
		else if(a == 18 && b == 78)
		{
			return -60;
		}
		else if(a == 18 && b == 79)
		{
			return -61;
		}
		else if(a == 18 && b == 80)
		{
			return -62;
		}
		else if(a == 18 && b == 81)
		{
			return -63;
		}
		else if(a == 18 && b == 82)
		{
			return -64;
		}
		else if(a == 18 && b == 83)
		{
			return -65;
		}
		else if(a == 18 && b == 84)
		{
			return -66;
		}
		else if(a == 18 && b == 85)
		{
			return -67;
		}
		else if(a == 18 && b == 86)
		{
			return -68;
		}
		else if(a == 18 && b == 87)
		{
			return -69;
		}
		else if(a == 18 && b == 88)
		{
			return -70;
		}
		else if(a == 18 && b == 89)
		{
			return -71;
		}
		else if(a == 18 && b == 90)
		{
			return -72;
		}
		else if(a == 18 && b == 91)
		{
			return -73;
		}
		else if(a == 18 && b == 92)
		{
			return -74;
		}
		else if(a == 18 && b == 93)
		{
			return -75;
		}
		else if(a == 18 && b == 94)
		{
			return -76;
		}
		else if(a == 18 && b == 95)
		{
			return -77;
		}
		else if(a == 18 && b == 96)
		{
			return -78;
		}
		else if(a == 18 && b == 97)
		{
			return -79;
		}
		else if(a == 18 && b == 98)
		{
			return -80;
		}
		else if(a == 18 && b == 99)
		{
			return -81;
		}
		else if(a == 18 && b == 100)
		{
			return -82;
		}
		else if(a == 19 && b == 0)
		{
			return 19;
		}
		else if(a == 19 && b == 1)
		{
			return 18;
		}
		else if(a == 19 && b == 2)
		{
			return 17;
		}
		else if(a == 19 && b == 3)
		{
			return 16;
		}
		else if(a == 19 && b == 4)
		{
			return 15;
		}
		else if(a == 19 && b == 5)
		{
			return 14;
		}
		else if(a == 19 && b == 6)
		{
			return 13;
		}
		else if(a == 19 && b == 7)
		{
			return 12;
		}
		else if(a == 19 && b == 8)
		{
			return 11;
		}
		else if(a == 19 && b == 9)
		{
			return 10;
		}
		else if(a == 19 && b == 10)
		{
			return 9;
		}
		else if(a == 19 && b == 11)
		{
			return 8;
		}
		else if(a == 19 && b == 12)
		{
			return 7;
		}
		else if(a == 19 && b == 13)
		{
			return 6;
		}
		else if(a == 19 && b == 14)
		{
			return 5;
		}
		else if(a == 19 && b == 15)
		{
			return 4;
		}
		else if(a == 19 && b == 16)
		{
			return 3;
		}
		else if(a == 19 && b == 17)
		{
			return 2;
		}
		else if(a == 19 && b == 18)
		{
			return 1;
		}
		else if(a == 19 && b == 19)
		{
			return 0;
		}
		else if(a == 19 && b == 20)
		{
			return -1;
		}
		else if(a == 19 && b == 21)
		{
			return -2;
		}
		else if(a == 19 && b == 22)
		{
			return -3;
		}
		else if(a == 19 && b == 23)
		{
			return -4;
		}
		else if(a == 19 && b == 24)
		{
			return -5;
		}
		else if(a == 19 && b == 25)
		{
			return -6;
		}
		else if(a == 19 && b == 26)
		{
			return -7;
		}
		else if(a == 19 && b == 27)
		{
			return -8;
		}
		else if(a == 19 && b == 28)
		{
			return -9;
		}
		else if(a == 19 && b == 29)
		{
			return -10;
		}
		else if(a == 19 && b == 30)
		{
			return -11;
		}
		else if(a == 19 && b == 31)
		{
			return -12;
		}
		else if(a == 19 && b == 32)
		{
			return -13;
		}
		else if(a == 19 && b == 33)
		{
			return -14;
		}
		else if(a == 19 && b == 34)
		{
			return -15;
		}
		else if(a == 19 && b == 35)
		{
			return -16;
		}
		else if(a == 19 && b == 36)
		{
			return -17;
		}
		else if(a == 19 && b == 37)
		{
			return -18;
		}
		else if(a == 19 && b == 38)
		{
			return -19;
		}
		else if(a == 19 && b == 39)
		{
			return -20;
		}
		else if(a == 19 && b == 40)
		{
			return -21;
		}
		else if(a == 19 && b == 41)
		{
			return -22;
		}
		else if(a == 19 && b == 42)
		{
			return -23;
		}
		else if(a == 19 && b == 43)
		{
			return -24;
		}
		else if(a == 19 && b == 44)
		{
			return -25;
		}
		else if(a == 19 && b == 45)
		{
			return -26;
		}
		else if(a == 19 && b == 46)
		{
			return -27;
		}
		else if(a == 19 && b == 47)
		{
			return -28;
		}
		else if(a == 19 && b == 48)
		{
			return -29;
		}
		else if(a == 19 && b == 49)
		{
			return -30;
		}
		else if(a == 19 && b == 50)
		{
			return -31;
		}
		else if(a == 19 && b == 51)
		{
			return -32;
		}
		else if(a == 19 && b == 52)
		{
			return -33;
		}
		else if(a == 19 && b == 53)
		{
			return -34;
		}
		else if(a == 19 && b == 54)
		{
			return -35;
		}
		else if(a == 19 && b == 55)
		{
			return -36;
		}
		else if(a == 19 && b == 56)
		{
			return -37;
		}
		else if(a == 19 && b == 57)
		{
			return -38;
		}
		else if(a == 19 && b == 58)
		{
			return -39;
		}
		else if(a == 19 && b == 59)
		{
			return -40;
		}
		else if(a == 19 && b == 60)
		{
			return -41;
		}
		else if(a == 19 && b == 61)
		{
			return -42;
		}
		else if(a == 19 && b == 62)
		{
			return -43;
		}
		else if(a == 19 && b == 63)
		{
			return -44;
		}
		else if(a == 19 && b == 64)
		{
			return -45;
		}
		else if(a == 19 && b == 65)
		{
			return -46;
		}
		else if(a == 19 && b == 66)
		{
			return -47;
		}
		else if(a == 19 && b == 67)
		{
			return -48;
		}
		else if(a == 19 && b == 68)
		{
			return -49;
		}
		else if(a == 19 && b == 69)
		{
			return -50;
		}
		else if(a == 19 && b == 70)
		{
			return -51;
		}
		else if(a == 19 && b == 71)
		{
			return -52;
		}
		else if(a == 19 && b == 72)
		{
			return -53;
		}
		else if(a == 19 && b == 73)
		{
			return -54;
		}
		else if(a == 19 && b == 74)
		{
			return -55;
		}
		else if(a == 19 && b == 75)
		{
			return -56;
		}
		else if(a == 19 && b == 76)
		{
			return -57;
		}
		else if(a == 19 && b == 77)
		{
			return -58;
		}
		else if(a == 19 && b == 78)
		{
			return -59;
		}
		else if(a == 19 && b == 79)
		{
			return -60;
		}
		else if(a == 19 && b == 80)
		{
			return -61;
		}
		else if(a == 19 && b == 81)
		{
			return -62;
		}
		else if(a == 19 && b == 82)
		{
			return -63;
		}
		else if(a == 19 && b == 83)
		{
			return -64;
		}
		else if(a == 19 && b == 84)
		{
			return -65;
		}
		else if(a == 19 && b == 85)
		{
			return -66;
		}
		else if(a == 19 && b == 86)
		{
			return -67;
		}
		else if(a == 19 && b == 87)
		{
			return -68;
		}
		else if(a == 19 && b == 88)
		{
			return -69;
		}
		else if(a == 19 && b == 89)
		{
			return -70;
		}
		else if(a == 19 && b == 90)
		{
			return -71;
		}
		else if(a == 19 && b == 91)
		{
			return -72;
		}
		else if(a == 19 && b == 92)
		{
			return -73;
		}
		else if(a == 19 && b == 93)
		{
			return -74;
		}
		else if(a == 19 && b == 94)
		{
			return -75;
		}
		else if(a == 19 && b == 95)
		{
			return -76;
		}
		else if(a == 19 && b == 96)
		{
			return -77;
		}
		else if(a == 19 && b == 97)
		{
			return -78;
		}
		else if(a == 19 && b == 98)
		{
			return -79;
		}
		else if(a == 19 && b == 99)
		{
			return -80;
		}
		else if(a == 19 && b == 100)
		{
			return -81;
		}
		else if(a == 20 && b == 0)
		{
			return 20;
		}
		else if(a == 20 && b == 1)
		{
			return 19;
		}
		else if(a == 20 && b == 2)
		{
			return 18;
		}
		else if(a == 20 && b == 3)
		{
			return 17;
		}
		else if(a == 20 && b == 4)
		{
			return 16;
		}
		else if(a == 20 && b == 5)
		{
			return 15;
		}
		else if(a == 20 && b == 6)
		{
			return 14;
		}
		else if(a == 20 && b == 7)
		{
			return 13;
		}
		else if(a == 20 && b == 8)
		{
			return 12;
		}
		else if(a == 20 && b == 9)
		{
			return 11;
		}
		else if(a == 20 && b == 10)
		{
			return 10;
		}
		else if(a == 20 && b == 11)
		{
			return 9;
		}
		else if(a == 20 && b == 12)
		{
			return 8;
		}
		else if(a == 20 && b == 13)
		{
			return 7;
		}
		else if(a == 20 && b == 14)
		{
			return 6;
		}
		else if(a == 20 && b == 15)
		{
			return 5;
		}
		else if(a == 20 && b == 16)
		{
			return 4;
		}
		else if(a == 20 && b == 17)
		{
			return 3;
		}
		else if(a == 20 && b == 18)
		{
			return 2;
		}
		else if(a == 20 && b == 19)
		{
			return 1;
		}
		else if(a == 20 && b == 20)
		{
			return 0;
		}
		else if(a == 20 && b == 21)
		{
			return -1;
		}
		else if(a == 20 && b == 22)
		{
			return -2;
		}
		else if(a == 20 && b == 23)
		{
			return -3;
		}
		else if(a == 20 && b == 24)
		{
			return -4;
		}
		else if(a == 20 && b == 25)
		{
			return -5;
		}
		else if(a == 20 && b == 26)
		{
			return -6;
		}
		else if(a == 20 && b == 27)
		{
			return -7;
		}
		else if(a == 20 && b == 28)
		{
			return -8;
		}
		else if(a == 20 && b == 29)
		{
			return -9;
		}
		else if(a == 20 && b == 30)
		{
			return -10;
		}
		else if(a == 20 && b == 31)
		{
			return -11;
		}
		else if(a == 20 && b == 32)
		{
			return -12;
		}
		else if(a == 20 && b == 33)
		{
			return -13;
		}
		else if(a == 20 && b == 34)
		{
			return -14;
		}
		else if(a == 20 && b == 35)
		{
			return -15;
		}
		else if(a == 20 && b == 36)
		{
			return -16;
		}
		else if(a == 20 && b == 37)
		{
			return -17;
		}
		else if(a == 20 && b == 38)
		{
			return -18;
		}
		else if(a == 20 && b == 39)
		{
			return -19;
		}
		else if(a == 20 && b == 40)
		{
			return -20;
		}
		else if(a == 20 && b == 41)
		{
			return -21;
		}
		else if(a == 20 && b == 42)
		{
			return -22;
		}
		else if(a == 20 && b == 43)
		{
			return -23;
		}
		else if(a == 20 && b == 44)
		{
			return -24;
		}
		else if(a == 20 && b == 45)
		{
			return -25;
		}
		else if(a == 20 && b == 46)
		{
			return -26;
		}
		else if(a == 20 && b == 47)
		{
			return -27;
		}
		else if(a == 20 && b == 48)
		{
			return -28;
		}
		else if(a == 20 && b == 49)
		{
			return -29;
		}
		else if(a == 20 && b == 50)
		{
			return -30;
		}
		else if(a == 20 && b == 51)
		{
			return -31;
		}
		else if(a == 20 && b == 52)
		{
			return -32;
		}
		else if(a == 20 && b == 53)
		{
			return -33;
		}
		else if(a == 20 && b == 54)
		{
			return -34;
		}
		else if(a == 20 && b == 55)
		{
			return -35;
		}
		else if(a == 20 && b == 56)
		{
			return -36;
		}
		else if(a == 20 && b == 57)
		{
			return -37;
		}
		else if(a == 20 && b == 58)
		{
			return -38;
		}
		else if(a == 20 && b == 59)
		{
			return -39;
		}
		else if(a == 20 && b == 60)
		{
			return -40;
		}
		else if(a == 20 && b == 61)
		{
			return -41;
		}
		else if(a == 20 && b == 62)
		{
			return -42;
		}
		else if(a == 20 && b == 63)
		{
			return -43;
		}
		else if(a == 20 && b == 64)
		{
			return -44;
		}
		else if(a == 20 && b == 65)
		{
			return -45;
		}
		else if(a == 20 && b == 66)
		{
			return -46;
		}
		else if(a == 20 && b == 67)
		{
			return -47;
		}
		else if(a == 20 && b == 68)
		{
			return -48;
		}
		else if(a == 20 && b == 69)
		{
			return -49;
		}
		else if(a == 20 && b == 70)
		{
			return -50;
		}
		else if(a == 20 && b == 71)
		{
			return -51;
		}
		else if(a == 20 && b == 72)
		{
			return -52;
		}
		else if(a == 20 && b == 73)
		{
			return -53;
		}
		else if(a == 20 && b == 74)
		{
			return -54;
		}
		else if(a == 20 && b == 75)
		{
			return -55;
		}
		else if(a == 20 && b == 76)
		{
			return -56;
		}
		else if(a == 20 && b == 77)
		{
			return -57;
		}
		else if(a == 20 && b == 78)
		{
			return -58;
		}
		else if(a == 20 && b == 79)
		{
			return -59;
		}
		else if(a == 20 && b == 80)
		{
			return -60;
		}
		else if(a == 20 && b == 81)
		{
			return -61;
		}
		else if(a == 20 && b == 82)
		{
			return -62;
		}
		else if(a == 20 && b == 83)
		{
			return -63;
		}
		else if(a == 20 && b == 84)
		{
			return -64;
		}
		else if(a == 20 && b == 85)
		{
			return -65;
		}
		else if(a == 20 && b == 86)
		{
			return -66;
		}
		else if(a == 20 && b == 87)
		{
			return -67;
		}
		else if(a == 20 && b == 88)
		{
			return -68;
		}
		else if(a == 20 && b == 89)
		{
			return -69;
		}
		else if(a == 20 && b == 90)
		{
			return -70;
		}
		else if(a == 20 && b == 91)
		{
			return -71;
		}
		else if(a == 20 && b == 92)
		{
			return -72;
		}
		else if(a == 20 && b == 93)
		{
			return -73;
		}
		else if(a == 20 && b == 94)
		{
			return -74;
		}
		else if(a == 20 && b == 95)
		{
			return -75;
		}
		else if(a == 20 && b == 96)
		{
			return -76;
		}
		else if(a == 20 && b == 97)
		{
			return -77;
		}
		else if(a == 20 && b == 98)
		{
			return -78;
		}
		else if(a == 20 && b == 99)
		{
			return -79;
		}
		else if(a == 20 && b == 100)
		{
			return -80;
		}
		else if(a == 21 && b == 0)
		{
			return 21;
		}
		else if(a == 21 && b == 1)
		{
			return 20;
		}
		else if(a == 21 && b == 2)
		{
			return 19;
		}
		else if(a == 21 && b == 3)
		{
			return 18;
		}
		else if(a == 21 && b == 4)
		{
			return 17;
		}
		else if(a == 21 && b == 5)
		{
			return 16;
		}
		else if(a == 21 && b == 6)
		{
			return 15;
		}
		else if(a == 21 && b == 7)
		{
			return 14;
		}
		else if(a == 21 && b == 8)
		{
			return 13;
		}
		else if(a == 21 && b == 9)
		{
			return 12;
		}
		else if(a == 21 && b == 10)
		{
			return 11;
		}
		else if(a == 21 && b == 11)
		{
			return 10;
		}
		else if(a == 21 && b == 12)
		{
			return 9;
		}
		else if(a == 21 && b == 13)
		{
			return 8;
		}
		else if(a == 21 && b == 14)
		{
			return 7;
		}
		else if(a == 21 && b == 15)
		{
			return 6;
		}
		else if(a == 21 && b == 16)
		{
			return 5;
		}
		else if(a == 21 && b == 17)
		{
			return 4;
		}
		else if(a == 21 && b == 18)
		{
			return 3;
		}
		else if(a == 21 && b == 19)
		{
			return 2;
		}
		else if(a == 21 && b == 20)
		{
			return 1;
		}
		else if(a == 21 && b == 21)
		{
			return 0;
		}
		else if(a == 21 && b == 22)
		{
			return -1;
		}
		else if(a == 21 && b == 23)
		{
			return -2;
		}
		else if(a == 21 && b == 24)
		{
			return -3;
		}
		else if(a == 21 && b == 25)
		{
			return -4;
		}
		else if(a == 21 && b == 26)
		{
			return -5;
		}
		else if(a == 21 && b == 27)
		{
			return -6;
		}
		else if(a == 21 && b == 28)
		{
			return -7;
		}
		else if(a == 21 && b == 29)
		{
			return -8;
		}
		else if(a == 21 && b == 30)
		{
			return -9;
		}
		else if(a == 21 && b == 31)
		{
			return -10;
		}
		else if(a == 21 && b == 32)
		{
			return -11;
		}
		else if(a == 21 && b == 33)
		{
			return -12;
		}
		else if(a == 21 && b == 34)
		{
			return -13;
		}
		else if(a == 21 && b == 35)
		{
			return -14;
		}
		else if(a == 21 && b == 36)
		{
			return -15;
		}
		else if(a == 21 && b == 37)
		{
			return -16;
		}
		else if(a == 21 && b == 38)
		{
			return -17;
		}
		else if(a == 21 && b == 39)
		{
			return -18;
		}
		else if(a == 21 && b == 40)
		{
			return -19;
		}
		else if(a == 21 && b == 41)
		{
			return -20;
		}
		else if(a == 21 && b == 42)
		{
			return -21;
		}
		else if(a == 21 && b == 43)
		{
			return -22;
		}
		else if(a == 21 && b == 44)
		{
			return -23;
		}
		else if(a == 21 && b == 45)
		{
			return -24;
		}
		else if(a == 21 && b == 46)
		{
			return -25;
		}
		else if(a == 21 && b == 47)
		{
			return -26;
		}
		else if(a == 21 && b == 48)
		{
			return -27;
		}
		else if(a == 21 && b == 49)
		{
			return -28;
		}
		else if(a == 21 && b == 50)
		{
			return -29;
		}
		else if(a == 21 && b == 51)
		{
			return -30;
		}
		else if(a == 21 && b == 52)
		{
			return -31;
		}
		else if(a == 21 && b == 53)
		{
			return -32;
		}
		else if(a == 21 && b == 54)
		{
			return -33;
		}
		else if(a == 21 && b == 55)
		{
			return -34;
		}
		else if(a == 21 && b == 56)
		{
			return -35;
		}
		else if(a == 21 && b == 57)
		{
			return -36;
		}
		else if(a == 21 && b == 58)
		{
			return -37;
		}
		else if(a == 21 && b == 59)
		{
			return -38;
		}
		else if(a == 21 && b == 60)
		{
			return -39;
		}
		else if(a == 21 && b == 61)
		{
			return -40;
		}
		else if(a == 21 && b == 62)
		{
			return -41;
		}
		else if(a == 21 && b == 63)
		{
			return -42;
		}
		else if(a == 21 && b == 64)
		{
			return -43;
		}
		else if(a == 21 && b == 65)
		{
			return -44;
		}
		else if(a == 21 && b == 66)
		{
			return -45;
		}
		else if(a == 21 && b == 67)
		{
			return -46;
		}
		else if(a == 21 && b == 68)
		{
			return -47;
		}
		else if(a == 21 && b == 69)
		{
			return -48;
		}
		else if(a == 21 && b == 70)
		{
			return -49;
		}
		else if(a == 21 && b == 71)
		{
			return -50;
		}
		else if(a == 21 && b == 72)
		{
			return -51;
		}
		else if(a == 21 && b == 73)
		{
			return -52;
		}
		else if(a == 21 && b == 74)
		{
			return -53;
		}
		else if(a == 21 && b == 75)
		{
			return -54;
		}
		else if(a == 21 && b == 76)
		{
			return -55;
		}
		else if(a == 21 && b == 77)
		{
			return -56;
		}
		else if(a == 21 && b == 78)
		{
			return -57;
		}
		else if(a == 21 && b == 79)
		{
			return -58;
		}
		else if(a == 21 && b == 80)
		{
			return -59;
		}
		else if(a == 21 && b == 81)
		{
			return -60;
		}
		else if(a == 21 && b == 82)
		{
			return -61;
		}
		else if(a == 21 && b == 83)
		{
			return -62;
		}
		else if(a == 21 && b == 84)
		{
			return -63;
		}
		else if(a == 21 && b == 85)
		{
			return -64;
		}
		else if(a == 21 && b == 86)
		{
			return -65;
		}
		else if(a == 21 && b == 87)
		{
			return -66;
		}
		else if(a == 21 && b == 88)
		{
			return -67;
		}
		else if(a == 21 && b == 89)
		{
			return -68;
		}
		else if(a == 21 && b == 90)
		{
			return -69;
		}
		else if(a == 21 && b == 91)
		{
			return -70;
		}
		else if(a == 21 && b == 92)
		{
			return -71;
		}
		else if(a == 21 && b == 93)
		{
			return -72;
		}
		else if(a == 21 && b == 94)
		{
			return -73;
		}
		else if(a == 21 && b == 95)
		{
			return -74;
		}
		else if(a == 21 && b == 96)
		{
			return -75;
		}
		else if(a == 21 && b == 97)
		{
			return -76;
		}
		else if(a == 21 && b == 98)
		{
			return -77;
		}
		else if(a == 21 && b == 99)
		{
			return -78;
		}
		else if(a == 21 && b == 100)
		{
			return -79;
		}
		else if(a == 22 && b == 0)
		{
			return 22;
		}
		else if(a == 22 && b == 1)
		{
			return 21;
		}
		else if(a == 22 && b == 2)
		{
			return 20;
		}
		else if(a == 22 && b == 3)
		{
			return 19;
		}
		else if(a == 22 && b == 4)
		{
			return 18;
		}
		else if(a == 22 && b == 5)
		{
			return 17;
		}
		else if(a == 22 && b == 6)
		{
			return 16;
		}
		else if(a == 22 && b == 7)
		{
			return 15;
		}
		else if(a == 22 && b == 8)
		{
			return 14;
		}
		else if(a == 22 && b == 9)
		{
			return 13;
		}
		else if(a == 22 && b == 10)
		{
			return 12;
		}
		else if(a == 22 && b == 11)
		{
			return 11;
		}
		else if(a == 22 && b == 12)
		{
			return 10;
		}
		else if(a == 22 && b == 13)
		{
			return 9;
		}
		else if(a == 22 && b == 14)
		{
			return 8;
		}
		else if(a == 22 && b == 15)
		{
			return 7;
		}
		else if(a == 22 && b == 16)
		{
			return 6;
		}
		else if(a == 22 && b == 17)
		{
			return 5;
		}
		else if(a == 22 && b == 18)
		{
			return 4;
		}
		else if(a == 22 && b == 19)
		{
			return 3;
		}
		else if(a == 22 && b == 20)
		{
			return 2;
		}
		else if(a == 22 && b == 21)
		{
			return 1;
		}
		else if(a == 22 && b == 22)
		{
			return 0;
		}
		else if(a == 22 && b == 23)
		{
			return -1;
		}
		else if(a == 22 && b == 24)
		{
			return -2;
		}
		else if(a == 22 && b == 25)
		{
			return -3;
		}
		else if(a == 22 && b == 26)
		{
			return -4;
		}
		else if(a == 22 && b == 27)
		{
			return -5;
		}
		else if(a == 22 && b == 28)
		{
			return -6;
		}
		else if(a == 22 && b == 29)
		{
			return -7;
		}
		else if(a == 22 && b == 30)
		{
			return -8;
		}
		else if(a == 22 && b == 31)
		{
			return -9;
		}
		else if(a == 22 && b == 32)
		{
			return -10;
		}
		else if(a == 22 && b == 33)
		{
			return -11;
		}
		else if(a == 22 && b == 34)
		{
			return -12;
		}
		else if(a == 22 && b == 35)
		{
			return -13;
		}
		else if(a == 22 && b == 36)
		{
			return -14;
		}
		else if(a == 22 && b == 37)
		{
			return -15;
		}
		else if(a == 22 && b == 38)
		{
			return -16;
		}
		else if(a == 22 && b == 39)
		{
			return -17;
		}
		else if(a == 22 && b == 40)
		{
			return -18;
		}
		else if(a == 22 && b == 41)
		{
			return -19;
		}
		else if(a == 22 && b == 42)
		{
			return -20;
		}
		else if(a == 22 && b == 43)
		{
			return -21;
		}
		else if(a == 22 && b == 44)
		{
			return -22;
		}
		else if(a == 22 && b == 45)
		{
			return -23;
		}
		else if(a == 22 && b == 46)
		{
			return -24;
		}
		else if(a == 22 && b == 47)
		{
			return -25;
		}
		else if(a == 22 && b == 48)
		{
			return -26;
		}
		else if(a == 22 && b == 49)
		{
			return -27;
		}
		else if(a == 22 && b == 50)
		{
			return -28;
		}
		else if(a == 22 && b == 51)
		{
			return -29;
		}
		else if(a == 22 && b == 52)
		{
			return -30;
		}
		else if(a == 22 && b == 53)
		{
			return -31;
		}
		else if(a == 22 && b == 54)
		{
			return -32;
		}
		else if(a == 22 && b == 55)
		{
			return -33;
		}
		else if(a == 22 && b == 56)
		{
			return -34;
		}
		else if(a == 22 && b == 57)
		{
			return -35;
		}
		else if(a == 22 && b == 58)
		{
			return -36;
		}
		else if(a == 22 && b == 59)
		{
			return -37;
		}
		else if(a == 22 && b == 60)
		{
			return -38;
		}
		else if(a == 22 && b == 61)
		{
			return -39;
		}
		else if(a == 22 && b == 62)
		{
			return -40;
		}
		else if(a == 22 && b == 63)
		{
			return -41;
		}
		else if(a == 22 && b == 64)
		{
			return -42;
		}
		else if(a == 22 && b == 65)
		{
			return -43;
		}
		else if(a == 22 && b == 66)
		{
			return -44;
		}
		else if(a == 22 && b == 67)
		{
			return -45;
		}
		else if(a == 22 && b == 68)
		{
			return -46;
		}
		else if(a == 22 && b == 69)
		{
			return -47;
		}
		else if(a == 22 && b == 70)
		{
			return -48;
		}
		else if(a == 22 && b == 71)
		{
			return -49;
		}
		else if(a == 22 && b == 72)
		{
			return -50;
		}
		else if(a == 22 && b == 73)
		{
			return -51;
		}
		else if(a == 22 && b == 74)
		{
			return -52;
		}
		else if(a == 22 && b == 75)
		{
			return -53;
		}
		else if(a == 22 && b == 76)
		{
			return -54;
		}
		else if(a == 22 && b == 77)
		{
			return -55;
		}
		else if(a == 22 && b == 78)
		{
			return -56;
		}
		else if(a == 22 && b == 79)
		{
			return -57;
		}
		else if(a == 22 && b == 80)
		{
			return -58;
		}
		else if(a == 22 && b == 81)
		{
			return -59;
		}
		else if(a == 22 && b == 82)
		{
			return -60;
		}
		else if(a == 22 && b == 83)
		{
			return -61;
		}
		else if(a == 22 && b == 84)
		{
			return -62;
		}
		else if(a == 22 && b == 85)
		{
			return -63;
		}
		else if(a == 22 && b == 86)
		{
			return -64;
		}
		else if(a == 22 && b == 87)
		{
			return -65;
		}
		else if(a == 22 && b == 88)
		{
			return -66;
		}
		else if(a == 22 && b == 89)
		{
			return -67;
		}
		else if(a == 22 && b == 90)
		{
			return -68;
		}
		else if(a == 22 && b == 91)
		{
			return -69;
		}
		else if(a == 22 && b == 92)
		{
			return -70;
		}
		else if(a == 22 && b == 93)
		{
			return -71;
		}
		else if(a == 22 && b == 94)
		{
			return -72;
		}
		else if(a == 22 && b == 95)
		{
			return -73;
		}
		else if(a == 22 && b == 96)
		{
			return -74;
		}
		else if(a == 22 && b == 97)
		{
			return -75;
		}
		else if(a == 22 && b == 98)
		{
			return -76;
		}
		else if(a == 22 && b == 99)
		{
			return -77;
		}
		else if(a == 22 && b == 100)
		{
			return -78;
		}
		else if(a == 23 && b == 0)
		{
			return 23;
		}
		else if(a == 23 && b == 1)
		{
			return 22;
		}
		else if(a == 23 && b == 2)
		{
			return 21;
		}
		else if(a == 23 && b == 3)
		{
			return 20;
		}
		else if(a == 23 && b == 4)
		{
			return 19;
		}
		else if(a == 23 && b == 5)
		{
			return 18;
		}
		else if(a == 23 && b == 6)
		{
			return 17;
		}
		else if(a == 23 && b == 7)
		{
			return 16;
		}
		else if(a == 23 && b == 8)
		{
			return 15;
		}
		else if(a == 23 && b == 9)
		{
			return 14;
		}
		else if(a == 23 && b == 10)
		{
			return 13;
		}
		else if(a == 23 && b == 11)
		{
			return 12;
		}
		else if(a == 23 && b == 12)
		{
			return 11;
		}
		else if(a == 23 && b == 13)
		{
			return 10;
		}
		else if(a == 23 && b == 14)
		{
			return 9;
		}
		else if(a == 23 && b == 15)
		{
			return 8;
		}
		else if(a == 23 && b == 16)
		{
			return 7;
		}
		else if(a == 23 && b == 17)
		{
			return 6;
		}
		else if(a == 23 && b == 18)
		{
			return 5;
		}
		else if(a == 23 && b == 19)
		{
			return 4;
		}
		else if(a == 23 && b == 20)
		{
			return 3;
		}
		else if(a == 23 && b == 21)
		{
			return 2;
		}
		else if(a == 23 && b == 22)
		{
			return 1;
		}
		else if(a == 23 && b == 23)
		{
			return 0;
		}
		else if(a == 23 && b == 24)
		{
			return -1;
		}
		else if(a == 23 && b == 25)
		{
			return -2;
		}
		else if(a == 23 && b == 26)
		{
			return -3;
		}
		else if(a == 23 && b == 27)
		{
			return -4;
		}
		else if(a == 23 && b == 28)
		{
			return -5;
		}
		else if(a == 23 && b == 29)
		{
			return -6;
		}
		else if(a == 23 && b == 30)
		{
			return -7;
		}
		else if(a == 23 && b == 31)
		{
			return -8;
		}
		else if(a == 23 && b == 32)
		{
			return -9;
		}
		else if(a == 23 && b == 33)
		{
			return -10;
		}
		else if(a == 23 && b == 34)
		{
			return -11;
		}
		else if(a == 23 && b == 35)
		{
			return -12;
		}
		else if(a == 23 && b == 36)
		{
			return -13;
		}
		else if(a == 23 && b == 37)
		{
			return -14;
		}
		else if(a == 23 && b == 38)
		{
			return -15;
		}
		else if(a == 23 && b == 39)
		{
			return -16;
		}
		else if(a == 23 && b == 40)
		{
			return -17;
		}
		else if(a == 23 && b == 41)
		{
			return -18;
		}
		else if(a == 23 && b == 42)
		{
			return -19;
		}
		else if(a == 23 && b == 43)
		{
			return -20;
		}
		else if(a == 23 && b == 44)
		{
			return -21;
		}
		else if(a == 23 && b == 45)
		{
			return -22;
		}
		else if(a == 23 && b == 46)
		{
			return -23;
		}
		else if(a == 23 && b == 47)
		{
			return -24;
		}
		else if(a == 23 && b == 48)
		{
			return -25;
		}
		else if(a == 23 && b == 49)
		{
			return -26;
		}
		else if(a == 23 && b == 50)
		{
			return -27;
		}
		else if(a == 23 && b == 51)
		{
			return -28;
		}
		else if(a == 23 && b == 52)
		{
			return -29;
		}
		else if(a == 23 && b == 53)
		{
			return -30;
		}
		else if(a == 23 && b == 54)
		{
			return -31;
		}
		else if(a == 23 && b == 55)
		{
			return -32;
		}
		else if(a == 23 && b == 56)
		{
			return -33;
		}
		else if(a == 23 && b == 57)
		{
			return -34;
		}
		else if(a == 23 && b == 58)
		{
			return -35;
		}
		else if(a == 23 && b == 59)
		{
			return -36;
		}
		else if(a == 23 && b == 60)
		{
			return -37;
		}
		else if(a == 23 && b == 61)
		{
			return -38;
		}
		else if(a == 23 && b == 62)
		{
			return -39;
		}
		else if(a == 23 && b == 63)
		{
			return -40;
		}
		else if(a == 23 && b == 64)
		{
			return -41;
		}
		else if(a == 23 && b == 65)
		{
			return -42;
		}
		else if(a == 23 && b == 66)
		{
			return -43;
		}
		else if(a == 23 && b == 67)
		{
			return -44;
		}
		else if(a == 23 && b == 68)
		{
			return -45;
		}
		else if(a == 23 && b == 69)
		{
			return -46;
		}
		else if(a == 23 && b == 70)
		{
			return -47;
		}
		else if(a == 23 && b == 71)
		{
			return -48;
		}
		else if(a == 23 && b == 72)
		{
			return -49;
		}
		else if(a == 23 && b == 73)
		{
			return -50;
		}
		else if(a == 23 && b == 74)
		{
			return -51;
		}
		else if(a == 23 && b == 75)
		{
			return -52;
		}
		else if(a == 23 && b == 76)
		{
			return -53;
		}
		else if(a == 23 && b == 77)
		{
			return -54;
		}
		else if(a == 23 && b == 78)
		{
			return -55;
		}
		else if(a == 23 && b == 79)
		{
			return -56;
		}
		else if(a == 23 && b == 80)
		{
			return -57;
		}
		else if(a == 23 && b == 81)
		{
			return -58;
		}
		else if(a == 23 && b == 82)
		{
			return -59;
		}
		else if(a == 23 && b == 83)
		{
			return -60;
		}
		else if(a == 23 && b == 84)
		{
			return -61;
		}
		else if(a == 23 && b == 85)
		{
			return -62;
		}
		else if(a == 23 && b == 86)
		{
			return -63;
		}
		else if(a == 23 && b == 87)
		{
			return -64;
		}
		else if(a == 23 && b == 88)
		{
			return -65;
		}
		else if(a == 23 && b == 89)
		{
			return -66;
		}
		else if(a == 23 && b == 90)
		{
			return -67;
		}
		else if(a == 23 && b == 91)
		{
			return -68;
		}
		else if(a == 23 && b == 92)
		{
			return -69;
		}
		else if(a == 23 && b == 93)
		{
			return -70;
		}
		else if(a == 23 && b == 94)
		{
			return -71;
		}
		else if(a == 23 && b == 95)
		{
			return -72;
		}
		else if(a == 23 && b == 96)
		{
			return -73;
		}
		else if(a == 23 && b == 97)
		{
			return -74;
		}
		else if(a == 23 && b == 98)
		{
			return -75;
		}
		else if(a == 23 && b == 99)
		{
			return -76;
		}
		else if(a == 23 && b == 100)
		{
			return -77;
		}
		else if(a == 24 && b == 0)
		{
			return 24;
		}
		else if(a == 24 && b == 1)
		{
			return 23;
		}
		else if(a == 24 && b == 2)
		{
			return 22;
		}
		else if(a == 24 && b == 3)
		{
			return 21;
		}
		else if(a == 24 && b == 4)
		{
			return 20;
		}
		else if(a == 24 && b == 5)
		{
			return 19;
		}
		else if(a == 24 && b == 6)
		{
			return 18;
		}
		else if(a == 24 && b == 7)
		{
			return 17;
		}
		else if(a == 24 && b == 8)
		{
			return 16;
		}
		else if(a == 24 && b == 9)
		{
			return 15;
		}
		else if(a == 24 && b == 10)
		{
			return 14;
		}
		else if(a == 24 && b == 11)
		{
			return 13;
		}
		else if(a == 24 && b == 12)
		{
			return 12;
		}
		else if(a == 24 && b == 13)
		{
			return 11;
		}
		else if(a == 24 && b == 14)
		{
			return 10;
		}
		else if(a == 24 && b == 15)
		{
			return 9;
		}
		else if(a == 24 && b == 16)
		{
			return 8;
		}
		else if(a == 24 && b == 17)
		{
			return 7;
		}
		else if(a == 24 && b == 18)
		{
			return 6;
		}
		else if(a == 24 && b == 19)
		{
			return 5;
		}
		else if(a == 24 && b == 20)
		{
			return 4;
		}
		else if(a == 24 && b == 21)
		{
			return 3;
		}
		else if(a == 24 && b == 22)
		{
			return 2;
		}
		else if(a == 24 && b == 23)
		{
			return 1;
		}
		else if(a == 24 && b == 24)
		{
			return 0;
		}
		else if(a == 24 && b == 25)
		{
			return -1;
		}
		else if(a == 24 && b == 26)
		{
			return -2;
		}
		else if(a == 24 && b == 27)
		{
			return -3;
		}
		else if(a == 24 && b == 28)
		{
			return -4;
		}
		else if(a == 24 && b == 29)
		{
			return -5;
		}
		else if(a == 24 && b == 30)
		{
			return -6;
		}
		else if(a == 24 && b == 31)
		{
			return -7;
		}
		else if(a == 24 && b == 32)
		{
			return -8;
		}
		else if(a == 24 && b == 33)
		{
			return -9;
		}
		else if(a == 24 && b == 34)
		{
			return -10;
		}
		else if(a == 24 && b == 35)
		{
			return -11;
		}
		else if(a == 24 && b == 36)
		{
			return -12;
		}
		else if(a == 24 && b == 37)
		{
			return -13;
		}
		else if(a == 24 && b == 38)
		{
			return -14;
		}
		else if(a == 24 && b == 39)
		{
			return -15;
		}
		else if(a == 24 && b == 40)
		{
			return -16;
		}
		else if(a == 24 && b == 41)
		{
			return -17;
		}
		else if(a == 24 && b == 42)
		{
			return -18;
		}
		else if(a == 24 && b == 43)
		{
			return -19;
		}
		else if(a == 24 && b == 44)
		{
			return -20;
		}
		else if(a == 24 && b == 45)
		{
			return -21;
		}
		else if(a == 24 && b == 46)
		{
			return -22;
		}
		else if(a == 24 && b == 47)
		{
			return -23;
		}
		else if(a == 24 && b == 48)
		{
			return -24;
		}
		else if(a == 24 && b == 49)
		{
			return -25;
		}
		else if(a == 24 && b == 50)
		{
			return -26;
		}
		else if(a == 24 && b == 51)
		{
			return -27;
		}
		else if(a == 24 && b == 52)
		{
			return -28;
		}
		else if(a == 24 && b == 53)
		{
			return -29;
		}
		else if(a == 24 && b == 54)
		{
			return -30;
		}
		else if(a == 24 && b == 55)
		{
			return -31;
		}
		else if(a == 24 && b == 56)
		{
			return -32;
		}
		else if(a == 24 && b == 57)
		{
			return -33;
		}
		else if(a == 24 && b == 58)
		{
			return -34;
		}
		else if(a == 24 && b == 59)
		{
			return -35;
		}
		else if(a == 24 && b == 60)
		{
			return -36;
		}
		else if(a == 24 && b == 61)
		{
			return -37;
		}
		else if(a == 24 && b == 62)
		{
			return -38;
		}
		else if(a == 24 && b == 63)
		{
			return -39;
		}
		else if(a == 24 && b == 64)
		{
			return -40;
		}
		else if(a == 24 && b == 65)
		{
			return -41;
		}
		else if(a == 24 && b == 66)
		{
			return -42;
		}
		else if(a == 24 && b == 67)
		{
			return -43;
		}
		else if(a == 24 && b == 68)
		{
			return -44;
		}
		else if(a == 24 && b == 69)
		{
			return -45;
		}
		else if(a == 24 && b == 70)
		{
			return -46;
		}
		else if(a == 24 && b == 71)
		{
			return -47;
		}
		else if(a == 24 && b == 72)
		{
			return -48;
		}
		else if(a == 24 && b == 73)
		{
			return -49;
		}
		else if(a == 24 && b == 74)
		{
			return -50;
		}
		else if(a == 24 && b == 75)
		{
			return -51;
		}
		else if(a == 24 && b == 76)
		{
			return -52;
		}
		else if(a == 24 && b == 77)
		{
			return -53;
		}
		else if(a == 24 && b == 78)
		{
			return -54;
		}
		else if(a == 24 && b == 79)
		{
			return -55;
		}
		else if(a == 24 && b == 80)
		{
			return -56;
		}
		else if(a == 24 && b == 81)
		{
			return -57;
		}
		else if(a == 24 && b == 82)
		{
			return -58;
		}
		else if(a == 24 && b == 83)
		{
			return -59;
		}
		else if(a == 24 && b == 84)
		{
			return -60;
		}
		else if(a == 24 && b == 85)
		{
			return -61;
		}
		else if(a == 24 && b == 86)
		{
			return -62;
		}
		else if(a == 24 && b == 87)
		{
			return -63;
		}
		else if(a == 24 && b == 88)
		{
			return -64;
		}
		else if(a == 24 && b == 89)
		{
			return -65;
		}
		else if(a == 24 && b == 90)
		{
			return -66;
		}
		else if(a == 24 && b == 91)
		{
			return -67;
		}
		else if(a == 24 && b == 92)
		{
			return -68;
		}
		else if(a == 24 && b == 93)
		{
			return -69;
		}
		else if(a == 24 && b == 94)
		{
			return -70;
		}
		else if(a == 24 && b == 95)
		{
			return -71;
		}
		else if(a == 24 && b == 96)
		{
			return -72;
		}
		else if(a == 24 && b == 97)
		{
			return -73;
		}
		else if(a == 24 && b == 98)
		{
			return -74;
		}
		else if(a == 24 && b == 99)
		{
			return -75;
		}
		else if(a == 24 && b == 100)
		{
			return -76;
		}
		else if(a == 25 && b == 0)
		{
			return 25;
		}
		else if(a == 25 && b == 1)
		{
			return 24;
		}
		else if(a == 25 && b == 2)
		{
			return 23;
		}
		else if(a == 25 && b == 3)
		{
			return 22;
		}
		else if(a == 25 && b == 4)
		{
			return 21;
		}
		else if(a == 25 && b == 5)
		{
			return 20;
		}
		else if(a == 25 && b == 6)
		{
			return 19;
		}
		else if(a == 25 && b == 7)
		{
			return 18;
		}
		else if(a == 25 && b == 8)
		{
			return 17;
		}
		else if(a == 25 && b == 9)
		{
			return 16;
		}
		else if(a == 25 && b == 10)
		{
			return 15;
		}
		else if(a == 25 && b == 11)
		{
			return 14;
		}
		else if(a == 25 && b == 12)
		{
			return 13;
		}
		else if(a == 25 && b == 13)
		{
			return 12;
		}
		else if(a == 25 && b == 14)
		{
			return 11;
		}
		else if(a == 25 && b == 15)
		{
			return 10;
		}
		else if(a == 25 && b == 16)
		{
			return 9;
		}
		else if(a == 25 && b == 17)
		{
			return 8;
		}
		else if(a == 25 && b == 18)
		{
			return 7;
		}
		else if(a == 25 && b == 19)
		{
			return 6;
		}
		else if(a == 25 && b == 20)
		{
			return 5;
		}
		else if(a == 25 && b == 21)
		{
			return 4;
		}
		else if(a == 25 && b == 22)
		{
			return 3;
		}
		else if(a == 25 && b == 23)
		{
			return 2;
		}
		else if(a == 25 && b == 24)
		{
			return 1;
		}
		else if(a == 25 && b == 25)
		{
			return 0;
		}
		else if(a == 25 && b == 26)
		{
			return -1;
		}
		else if(a == 25 && b == 27)
		{
			return -2;
		}
		else if(a == 25 && b == 28)
		{
			return -3;
		}
		else if(a == 25 && b == 29)
		{
			return -4;
		}
		else if(a == 25 && b == 30)
		{
			return -5;
		}
		else if(a == 25 && b == 31)
		{
			return -6;
		}
		else if(a == 25 && b == 32)
		{
			return -7;
		}
		else if(a == 25 && b == 33)
		{
			return -8;
		}
		else if(a == 25 && b == 34)
		{
			return -9;
		}
		else if(a == 25 && b == 35)
		{
			return -10;
		}
		else if(a == 25 && b == 36)
		{
			return -11;
		}
		else if(a == 25 && b == 37)
		{
			return -12;
		}
		else if(a == 25 && b == 38)
		{
			return -13;
		}
		else if(a == 25 && b == 39)
		{
			return -14;
		}
		else if(a == 25 && b == 40)
		{
			return -15;
		}
		else if(a == 25 && b == 41)
		{
			return -16;
		}
		else if(a == 25 && b == 42)
		{
			return -17;
		}
		else if(a == 25 && b == 43)
		{
			return -18;
		}
		else if(a == 25 && b == 44)
		{
			return -19;
		}
		else if(a == 25 && b == 45)
		{
			return -20;
		}
		else if(a == 25 && b == 46)
		{
			return -21;
		}
		else if(a == 25 && b == 47)
		{
			return -22;
		}
		else if(a == 25 && b == 48)
		{
			return -23;
		}
		else if(a == 25 && b == 49)
		{
			return -24;
		}
		else if(a == 25 && b == 50)
		{
			return -25;
		}
		else if(a == 25 && b == 51)
		{
			return -26;
		}
		else if(a == 25 && b == 52)
		{
			return -27;
		}
		else if(a == 25 && b == 53)
		{
			return -28;
		}
		else if(a == 25 && b == 54)
		{
			return -29;
		}
		else if(a == 25 && b == 55)
		{
			return -30;
		}
		else if(a == 25 && b == 56)
		{
			return -31;
		}
		else if(a == 25 && b == 57)
		{
			return -32;
		}
		else if(a == 25 && b == 58)
		{
			return -33;
		}
		else if(a == 25 && b == 59)
		{
			return -34;
		}
		else if(a == 25 && b == 60)
		{
			return -35;
		}
		else if(a == 25 && b == 61)
		{
			return -36;
		}
		else if(a == 25 && b == 62)
		{
			return -37;
		}
		else if(a == 25 && b == 63)
		{
			return -38;
		}
		else if(a == 25 && b == 64)
		{
			return -39;
		}
		else if(a == 25 && b == 65)
		{
			return -40;
		}
		else if(a == 25 && b == 66)
		{
			return -41;
		}
		else if(a == 25 && b == 67)
		{
			return -42;
		}
		else if(a == 25 && b == 68)
		{
			return -43;
		}
		else if(a == 25 && b == 69)
		{
			return -44;
		}
		else if(a == 25 && b == 70)
		{
			return -45;
		}
		else if(a == 25 && b == 71)
		{
			return -46;
		}
		else if(a == 25 && b == 72)
		{
			return -47;
		}
		else if(a == 25 && b == 73)
		{
			return -48;
		}
		else if(a == 25 && b == 74)
		{
			return -49;
		}
		else if(a == 25 && b == 75)
		{
			return -50;
		}
		else if(a == 25 && b == 76)
		{
			return -51;
		}
		else if(a == 25 && b == 77)
		{
			return -52;
		}
		else if(a == 25 && b == 78)
		{
			return -53;
		}
		else if(a == 25 && b == 79)
		{
			return -54;
		}
		else if(a == 25 && b == 80)
		{
			return -55;
		}
		else if(a == 25 && b == 81)
		{
			return -56;
		}
		else if(a == 25 && b == 82)
		{
			return -57;
		}
		else if(a == 25 && b == 83)
		{
			return -58;
		}
		else if(a == 25 && b == 84)
		{
			return -59;
		}
		else if(a == 25 && b == 85)
		{
			return -60;
		}
		else if(a == 25 && b == 86)
		{
			return -61;
		}
		else if(a == 25 && b == 87)
		{
			return -62;
		}
		else if(a == 25 && b == 88)
		{
			return -63;
		}
		else if(a == 25 && b == 89)
		{
			return -64;
		}
		else if(a == 25 && b == 90)
		{
			return -65;
		}
		else if(a == 25 && b == 91)
		{
			return -66;
		}
		else if(a == 25 && b == 92)
		{
			return -67;
		}
		else if(a == 25 && b == 93)
		{
			return -68;
		}
		else if(a == 25 && b == 94)
		{
			return -69;
		}
		else if(a == 25 && b == 95)
		{
			return -70;
		}
		else if(a == 25 && b == 96)
		{
			return -71;
		}
		else if(a == 25 && b == 97)
		{
			return -72;
		}
		else if(a == 25 && b == 98)
		{
			return -73;
		}
		else if(a == 25 && b == 99)
		{
			return -74;
		}
		else if(a == 25 && b == 100)
		{
			return -75;
		}
		else if(a == 26 && b == 0)
		{
			return 26;
		}
		else if(a == 26 && b == 1)
		{
			return 25;
		}
		else if(a == 26 && b == 2)
		{
			return 24;
		}
		else if(a == 26 && b == 3)
		{
			return 23;
		}
		else if(a == 26 && b == 4)
		{
			return 22;
		}
		else if(a == 26 && b == 5)
		{
			return 21;
		}
		else if(a == 26 && b == 6)
		{
			return 20;
		}
		else if(a == 26 && b == 7)
		{
			return 19;
		}
		else if(a == 26 && b == 8)
		{
			return 18;
		}
		else if(a == 26 && b == 9)
		{
			return 17;
		}
		else if(a == 26 && b == 10)
		{
			return 16;
		}
		else if(a == 26 && b == 11)
		{
			return 15;
		}
		else if(a == 26 && b == 12)
		{
			return 14;
		}
		else if(a == 26 && b == 13)
		{
			return 13;
		}
		else if(a == 26 && b == 14)
		{
			return 12;
		}
		else if(a == 26 && b == 15)
		{
			return 11;
		}
		else if(a == 26 && b == 16)
		{
			return 10;
		}
		else if(a == 26 && b == 17)
		{
			return 9;
		}
		else if(a == 26 && b == 18)
		{
			return 8;
		}
		else if(a == 26 && b == 19)
		{
			return 7;
		}
		else if(a == 26 && b == 20)
		{
			return 6;
		}
		else if(a == 26 && b == 21)
		{
			return 5;
		}
		else if(a == 26 && b == 22)
		{
			return 4;
		}
		else if(a == 26 && b == 23)
		{
			return 3;
		}
		else if(a == 26 && b == 24)
		{
			return 2;
		}
		else if(a == 26 && b == 25)
		{
			return 1;
		}
		else if(a == 26 && b == 26)
		{
			return 0;
		}
		else if(a == 26 && b == 27)
		{
			return -1;
		}
		else if(a == 26 && b == 28)
		{
			return -2;
		}
		else if(a == 26 && b == 29)
		{
			return -3;
		}
		else if(a == 26 && b == 30)
		{
			return -4;
		}
		else if(a == 26 && b == 31)
		{
			return -5;
		}
		else if(a == 26 && b == 32)
		{
			return -6;
		}
		else if(a == 26 && b == 33)
		{
			return -7;
		}
		else if(a == 26 && b == 34)
		{
			return -8;
		}
		else if(a == 26 && b == 35)
		{
			return -9;
		}
		else if(a == 26 && b == 36)
		{
			return -10;
		}
		else if(a == 26 && b == 37)
		{
			return -11;
		}
		else if(a == 26 && b == 38)
		{
			return -12;
		}
		else if(a == 26 && b == 39)
		{
			return -13;
		}
		else if(a == 26 && b == 40)
		{
			return -14;
		}
		else if(a == 26 && b == 41)
		{
			return -15;
		}
		else if(a == 26 && b == 42)
		{
			return -16;
		}
		else if(a == 26 && b == 43)
		{
			return -17;
		}
		else if(a == 26 && b == 44)
		{
			return -18;
		}
		else if(a == 26 && b == 45)
		{
			return -19;
		}
		else if(a == 26 && b == 46)
		{
			return -20;
		}
		else if(a == 26 && b == 47)
		{
			return -21;
		}
		else if(a == 26 && b == 48)
		{
			return -22;
		}
		else if(a == 26 && b == 49)
		{
			return -23;
		}
		else if(a == 26 && b == 50)
		{
			return -24;
		}
		else if(a == 26 && b == 51)
		{
			return -25;
		}
		else if(a == 26 && b == 52)
		{
			return -26;
		}
		else if(a == 26 && b == 53)
		{
			return -27;
		}
		else if(a == 26 && b == 54)
		{
			return -28;
		}
		else if(a == 26 && b == 55)
		{
			return -29;
		}
		else if(a == 26 && b == 56)
		{
			return -30;
		}
		else if(a == 26 && b == 57)
		{
			return -31;
		}
		else if(a == 26 && b == 58)
		{
			return -32;
		}
		else if(a == 26 && b == 59)
		{
			return -33;
		}
		else if(a == 26 && b == 60)
		{
			return -34;
		}
		else if(a == 26 && b == 61)
		{
			return -35;
		}
		else if(a == 26 && b == 62)
		{
			return -36;
		}
		else if(a == 26 && b == 63)
		{
			return -37;
		}
		else if(a == 26 && b == 64)
		{
			return -38;
		}
		else if(a == 26 && b == 65)
		{
			return -39;
		}
		else if(a == 26 && b == 66)
		{
			return -40;
		}
		else if(a == 26 && b == 67)
		{
			return -41;
		}
		else if(a == 26 && b == 68)
		{
			return -42;
		}
		else if(a == 26 && b == 69)
		{
			return -43;
		}
		else if(a == 26 && b == 70)
		{
			return -44;
		}
		else if(a == 26 && b == 71)
		{
			return -45;
		}
		else if(a == 26 && b == 72)
		{
			return -46;
		}
		else if(a == 26 && b == 73)
		{
			return -47;
		}
		else if(a == 26 && b == 74)
		{
			return -48;
		}
		else if(a == 26 && b == 75)
		{
			return -49;
		}
		else if(a == 26 && b == 76)
		{
			return -50;
		}
		else if(a == 26 && b == 77)
		{
			return -51;
		}
		else if(a == 26 && b == 78)
		{
			return -52;
		}
		else if(a == 26 && b == 79)
		{
			return -53;
		}
		else if(a == 26 && b == 80)
		{
			return -54;
		}
		else if(a == 26 && b == 81)
		{
			return -55;
		}
		else if(a == 26 && b == 82)
		{
			return -56;
		}
		else if(a == 26 && b == 83)
		{
			return -57;
		}
		else if(a == 26 && b == 84)
		{
			return -58;
		}
		else if(a == 26 && b == 85)
		{
			return -59;
		}
		else if(a == 26 && b == 86)
		{
			return -60;
		}
		else if(a == 26 && b == 87)
		{
			return -61;
		}
		else if(a == 26 && b == 88)
		{
			return -62;
		}
		else if(a == 26 && b == 89)
		{
			return -63;
		}
		else if(a == 26 && b == 90)
		{
			return -64;
		}
		else if(a == 26 && b == 91)
		{
			return -65;
		}
		else if(a == 26 && b == 92)
		{
			return -66;
		}
		else if(a == 26 && b == 93)
		{
			return -67;
		}
		else if(a == 26 && b == 94)
		{
			return -68;
		}
		else if(a == 26 && b == 95)
		{
			return -69;
		}
		else if(a == 26 && b == 96)
		{
			return -70;
		}
		else if(a == 26 && b == 97)
		{
			return -71;
		}
		else if(a == 26 && b == 98)
		{
			return -72;
		}
		else if(a == 26 && b == 99)
		{
			return -73;
		}
		else if(a == 26 && b == 100)
		{
			return -74;
		}
		else if(a == 27 && b == 0)
		{
			return 27;
		}
		else if(a == 27 && b == 1)
		{
			return 26;
		}
		else if(a == 27 && b == 2)
		{
			return 25;
		}
		else if(a == 27 && b == 3)
		{
			return 24;
		}
		else if(a == 27 && b == 4)
		{
			return 23;
		}
		else if(a == 27 && b == 5)
		{
			return 22;
		}
		else if(a == 27 && b == 6)
		{
			return 21;
		}
		else if(a == 27 && b == 7)
		{
			return 20;
		}
		else if(a == 27 && b == 8)
		{
			return 19;
		}
		else if(a == 27 && b == 9)
		{
			return 18;
		}
		else if(a == 27 && b == 10)
		{
			return 17;
		}
		else if(a == 27 && b == 11)
		{
			return 16;
		}
		else if(a == 27 && b == 12)
		{
			return 15;
		}
		else if(a == 27 && b == 13)
		{
			return 14;
		}
		else if(a == 27 && b == 14)
		{
			return 13;
		}
		else if(a == 27 && b == 15)
		{
			return 12;
		}
		else if(a == 27 && b == 16)
		{
			return 11;
		}
		else if(a == 27 && b == 17)
		{
			return 10;
		}
		else if(a == 27 && b == 18)
		{
			return 9;
		}
		else if(a == 27 && b == 19)
		{
			return 8;
		}
		else if(a == 27 && b == 20)
		{
			return 7;
		}
		else if(a == 27 && b == 21)
		{
			return 6;
		}
		else if(a == 27 && b == 22)
		{
			return 5;
		}
		else if(a == 27 && b == 23)
		{
			return 4;
		}
		else if(a == 27 && b == 24)
		{
			return 3;
		}
		else if(a == 27 && b == 25)
		{
			return 2;
		}
		else if(a == 27 && b == 26)
		{
			return 1;
		}
		else if(a == 27 && b == 27)
		{
			return 0;
		}
		else if(a == 27 && b == 28)
		{
			return -1;
		}
		else if(a == 27 && b == 29)
		{
			return -2;
		}
		else if(a == 27 && b == 30)
		{
			return -3;
		}
		else if(a == 27 && b == 31)
		{
			return -4;
		}
		else if(a == 27 && b == 32)
		{
			return -5;
		}
		else if(a == 27 && b == 33)
		{
			return -6;
		}
		else if(a == 27 && b == 34)
		{
			return -7;
		}
		else if(a == 27 && b == 35)
		{
			return -8;
		}
		else if(a == 27 && b == 36)
		{
			return -9;
		}
		else if(a == 27 && b == 37)
		{
			return -10;
		}
		else if(a == 27 && b == 38)
		{
			return -11;
		}
		else if(a == 27 && b == 39)
		{
			return -12;
		}
		else if(a == 27 && b == 40)
		{
			return -13;
		}
		else if(a == 27 && b == 41)
		{
			return -14;
		}
		else if(a == 27 && b == 42)
		{
			return -15;
		}
		else if(a == 27 && b == 43)
		{
			return -16;
		}
		else if(a == 27 && b == 44)
		{
			return -17;
		}
		else if(a == 27 && b == 45)
		{
			return -18;
		}
		else if(a == 27 && b == 46)
		{
			return -19;
		}
		else if(a == 27 && b == 47)
		{
			return -20;
		}
		else if(a == 27 && b == 48)
		{
			return -21;
		}
		else if(a == 27 && b == 49)
		{
			return -22;
		}
		else if(a == 27 && b == 50)
		{
			return -23;
		}
		else if(a == 27 && b == 51)
		{
			return -24;
		}
		else if(a == 27 && b == 52)
		{
			return -25;
		}
		else if(a == 27 && b == 53)
		{
			return -26;
		}
		else if(a == 27 && b == 54)
		{
			return -27;
		}
		else if(a == 27 && b == 55)
		{
			return -28;
		}
		else if(a == 27 && b == 56)
		{
			return -29;
		}
		else if(a == 27 && b == 57)
		{
			return -30;
		}
		else if(a == 27 && b == 58)
		{
			return -31;
		}
		else if(a == 27 && b == 59)
		{
			return -32;
		}
		else if(a == 27 && b == 60)
		{
			return -33;
		}
		else if(a == 27 && b == 61)
		{
			return -34;
		}
		else if(a == 27 && b == 62)
		{
			return -35;
		}
		else if(a == 27 && b == 63)
		{
			return -36;
		}
		else if(a == 27 && b == 64)
		{
			return -37;
		}
		else if(a == 27 && b == 65)
		{
			return -38;
		}
		else if(a == 27 && b == 66)
		{
			return -39;
		}
		else if(a == 27 && b == 67)
		{
			return -40;
		}
		else if(a == 27 && b == 68)
		{
			return -41;
		}
		else if(a == 27 && b == 69)
		{
			return -42;
		}
		else if(a == 27 && b == 70)
		{
			return -43;
		}
		else if(a == 27 && b == 71)
		{
			return -44;
		}
		else if(a == 27 && b == 72)
		{
			return -45;
		}
		else if(a == 27 && b == 73)
		{
			return -46;
		}
		else if(a == 27 && b == 74)
		{
			return -47;
		}
		else if(a == 27 && b == 75)
		{
			return -48;
		}
		else if(a == 27 && b == 76)
		{
			return -49;
		}
		else if(a == 27 && b == 77)
		{
			return -50;
		}
		else if(a == 27 && b == 78)
		{
			return -51;
		}
		else if(a == 27 && b == 79)
		{
			return -52;
		}
		else if(a == 27 && b == 80)
		{
			return -53;
		}
		else if(a == 27 && b == 81)
		{
			return -54;
		}
		else if(a == 27 && b == 82)
		{
			return -55;
		}
		else if(a == 27 && b == 83)
		{
			return -56;
		}
		else if(a == 27 && b == 84)
		{
			return -57;
		}
		else if(a == 27 && b == 85)
		{
			return -58;
		}
		else if(a == 27 && b == 86)
		{
			return -59;
		}
		else if(a == 27 && b == 87)
		{
			return -60;
		}
		else if(a == 27 && b == 88)
		{
			return -61;
		}
		else if(a == 27 && b == 89)
		{
			return -62;
		}
		else if(a == 27 && b == 90)
		{
			return -63;
		}
		else if(a == 27 && b == 91)
		{
			return -64;
		}
		else if(a == 27 && b == 92)
		{
			return -65;
		}
		else if(a == 27 && b == 93)
		{
			return -66;
		}
		else if(a == 27 && b == 94)
		{
			return -67;
		}
		else if(a == 27 && b == 95)
		{
			return -68;
		}
		else if(a == 27 && b == 96)
		{
			return -69;
		}
		else if(a == 27 && b == 97)
		{
			return -70;
		}
		else if(a == 27 && b == 98)
		{
			return -71;
		}
		else if(a == 27 && b == 99)
		{
			return -72;
		}
		else if(a == 27 && b == 100)
		{
			return -73;
		}
		else if(a == 28 && b == 0)
		{
			return 28;
		}
		else if(a == 28 && b == 1)
		{
			return 27;
		}
		else if(a == 28 && b == 2)
		{
			return 26;
		}
		else if(a == 28 && b == 3)
		{
			return 25;
		}
		else if(a == 28 && b == 4)
		{
			return 24;
		}
		else if(a == 28 && b == 5)
		{
			return 23;
		}
		else if(a == 28 && b == 6)
		{
			return 22;
		}
		else if(a == 28 && b == 7)
		{
			return 21;
		}
		else if(a == 28 && b == 8)
		{
			return 20;
		}
		else if(a == 28 && b == 9)
		{
			return 19;
		}
		else if(a == 28 && b == 10)
		{
			return 18;
		}
		else if(a == 28 && b == 11)
		{
			return 17;
		}
		else if(a == 28 && b == 12)
		{
			return 16;
		}
		else if(a == 28 && b == 13)
		{
			return 15;
		}
		else if(a == 28 && b == 14)
		{
			return 14;
		}
		else if(a == 28 && b == 15)
		{
			return 13;
		}
		else if(a == 28 && b == 16)
		{
			return 12;
		}
		else if(a == 28 && b == 17)
		{
			return 11;
		}
		else if(a == 28 && b == 18)
		{
			return 10;
		}
		else if(a == 28 && b == 19)
		{
			return 9;
		}
		else if(a == 28 && b == 20)
		{
			return 8;
		}
		else if(a == 28 && b == 21)
		{
			return 7;
		}
		else if(a == 28 && b == 22)
		{
			return 6;
		}
		else if(a == 28 && b == 23)
		{
			return 5;
		}
		else if(a == 28 && b == 24)
		{
			return 4;
		}
		else if(a == 28 && b == 25)
		{
			return 3;
		}
		else if(a == 28 && b == 26)
		{
			return 2;
		}
		else if(a == 28 && b == 27)
		{
			return 1;
		}
		else if(a == 28 && b == 28)
		{
			return 0;
		}
		else if(a == 28 && b == 29)
		{
			return -1;
		}
		else if(a == 28 && b == 30)
		{
			return -2;
		}
		else if(a == 28 && b == 31)
		{
			return -3;
		}
		else if(a == 28 && b == 32)
		{
			return -4;
		}
		else if(a == 28 && b == 33)
		{
			return -5;
		}
		else if(a == 28 && b == 34)
		{
			return -6;
		}
		else if(a == 28 && b == 35)
		{
			return -7;
		}
		else if(a == 28 && b == 36)
		{
			return -8;
		}
		else if(a == 28 && b == 37)
		{
			return -9;
		}
		else if(a == 28 && b == 38)
		{
			return -10;
		}
		else if(a == 28 && b == 39)
		{
			return -11;
		}
		else if(a == 28 && b == 40)
		{
			return -12;
		}
		else if(a == 28 && b == 41)
		{
			return -13;
		}
		else if(a == 28 && b == 42)
		{
			return -14;
		}
		else if(a == 28 && b == 43)
		{
			return -15;
		}
		else if(a == 28 && b == 44)
		{
			return -16;
		}
		else if(a == 28 && b == 45)
		{
			return -17;
		}
		else if(a == 28 && b == 46)
		{
			return -18;
		}
		else if(a == 28 && b == 47)
		{
			return -19;
		}
		else if(a == 28 && b == 48)
		{
			return -20;
		}
		else if(a == 28 && b == 49)
		{
			return -21;
		}
		else if(a == 28 && b == 50)
		{
			return -22;
		}
		else if(a == 28 && b == 51)
		{
			return -23;
		}
		else if(a == 28 && b == 52)
		{
			return -24;
		}
		else if(a == 28 && b == 53)
		{
			return -25;
		}
		else if(a == 28 && b == 54)
		{
			return -26;
		}
		else if(a == 28 && b == 55)
		{
			return -27;
		}
		else if(a == 28 && b == 56)
		{
			return -28;
		}
		else if(a == 28 && b == 57)
		{
			return -29;
		}
		else if(a == 28 && b == 58)
		{
			return -30;
		}
		else if(a == 28 && b == 59)
		{
			return -31;
		}
		else if(a == 28 && b == 60)
		{
			return -32;
		}
		else if(a == 28 && b == 61)
		{
			return -33;
		}
		else if(a == 28 && b == 62)
		{
			return -34;
		}
		else if(a == 28 && b == 63)
		{
			return -35;
		}
		else if(a == 28 && b == 64)
		{
			return -36;
		}
		else if(a == 28 && b == 65)
		{
			return -37;
		}
		else if(a == 28 && b == 66)
		{
			return -38;
		}
		else if(a == 28 && b == 67)
		{
			return -39;
		}
		else if(a == 28 && b == 68)
		{
			return -40;
		}
		else if(a == 28 && b == 69)
		{
			return -41;
		}
		else if(a == 28 && b == 70)
		{
			return -42;
		}
		else if(a == 28 && b == 71)
		{
			return -43;
		}
		else if(a == 28 && b == 72)
		{
			return -44;
		}
		else if(a == 28 && b == 73)
		{
			return -45;
		}
		else if(a == 28 && b == 74)
		{
			return -46;
		}
		else if(a == 28 && b == 75)
		{
			return -47;
		}
		else if(a == 28 && b == 76)
		{
			return -48;
		}
		else if(a == 28 && b == 77)
		{
			return -49;
		}
		else if(a == 28 && b == 78)
		{
			return -50;
		}
		else if(a == 28 && b == 79)
		{
			return -51;
		}
		else if(a == 28 && b == 80)
		{
			return -52;
		}
		else if(a == 28 && b == 81)
		{
			return -53;
		}
		else if(a == 28 && b == 82)
		{
			return -54;
		}
		else if(a == 28 && b == 83)
		{
			return -55;
		}
		else if(a == 28 && b == 84)
		{
			return -56;
		}
		else if(a == 28 && b == 85)
		{
			return -57;
		}
		else if(a == 28 && b == 86)
		{
			return -58;
		}
		else if(a == 28 && b == 87)
		{
			return -59;
		}
		else if(a == 28 && b == 88)
		{
			return -60;
		}
		else if(a == 28 && b == 89)
		{
			return -61;
		}
		else if(a == 28 && b == 90)
		{
			return -62;
		}
		else if(a == 28 && b == 91)
		{
			return -63;
		}
		else if(a == 28 && b == 92)
		{
			return -64;
		}
		else if(a == 28 && b == 93)
		{
			return -65;
		}
		else if(a == 28 && b == 94)
		{
			return -66;
		}
		else if(a == 28 && b == 95)
		{
			return -67;
		}
		else if(a == 28 && b == 96)
		{
			return -68;
		}
		else if(a == 28 && b == 97)
		{
			return -69;
		}
		else if(a == 28 && b == 98)
		{
			return -70;
		}
		else if(a == 28 && b == 99)
		{
			return -71;
		}
		else if(a == 28 && b == 100)
		{
			return -72;
		}
		else if(a == 29 && b == 0)
		{
			return 29;
		}
		else if(a == 29 && b == 1)
		{
			return 28;
		}
		else if(a == 29 && b == 2)
		{
			return 27;
		}
		else if(a == 29 && b == 3)
		{
			return 26;
		}
		else if(a == 29 && b == 4)
		{
			return 25;
		}
		else if(a == 29 && b == 5)
		{
			return 24;
		}
		else if(a == 29 && b == 6)
		{
			return 23;
		}
		else if(a == 29 && b == 7)
		{
			return 22;
		}
		else if(a == 29 && b == 8)
		{
			return 21;
		}
		else if(a == 29 && b == 9)
		{
			return 20;
		}
		else if(a == 29 && b == 10)
		{
			return 19;
		}
		else if(a == 29 && b == 11)
		{
			return 18;
		}
		else if(a == 29 && b == 12)
		{
			return 17;
		}
		else if(a == 29 && b == 13)
		{
			return 16;
		}
		else if(a == 29 && b == 14)
		{
			return 15;
		}
		else if(a == 29 && b == 15)
		{
			return 14;
		}
		else if(a == 29 && b == 16)
		{
			return 13;
		}
		else if(a == 29 && b == 17)
		{
			return 12;
		}
		else if(a == 29 && b == 18)
		{
			return 11;
		}
		else if(a == 29 && b == 19)
		{
			return 10;
		}
		else if(a == 29 && b == 20)
		{
			return 9;
		}
		else if(a == 29 && b == 21)
		{
			return 8;
		}
		else if(a == 29 && b == 22)
		{
			return 7;
		}
		else if(a == 29 && b == 23)
		{
			return 6;
		}
		else if(a == 29 && b == 24)
		{
			return 5;
		}
		else if(a == 29 && b == 25)
		{
			return 4;
		}
		else if(a == 29 && b == 26)
		{
			return 3;
		}
		else if(a == 29 && b == 27)
		{
			return 2;
		}
		else if(a == 29 && b == 28)
		{
			return 1;
		}
		else if(a == 29 && b == 29)
		{
			return 0;
		}
		else if(a == 29 && b == 30)
		{
			return -1;
		}
		else if(a == 29 && b == 31)
		{
			return -2;
		}
		else if(a == 29 && b == 32)
		{
			return -3;
		}
		else if(a == 29 && b == 33)
		{
			return -4;
		}
		else if(a == 29 && b == 34)
		{
			return -5;
		}
		else if(a == 29 && b == 35)
		{
			return -6;
		}
		else if(a == 29 && b == 36)
		{
			return -7;
		}
		else if(a == 29 && b == 37)
		{
			return -8;
		}
		else if(a == 29 && b == 38)
		{
			return -9;
		}
		else if(a == 29 && b == 39)
		{
			return -10;
		}
		else if(a == 29 && b == 40)
		{
			return -11;
		}
		else if(a == 29 && b == 41)
		{
			return -12;
		}
		else if(a == 29 && b == 42)
		{
			return -13;
		}
		else if(a == 29 && b == 43)
		{
			return -14;
		}
		else if(a == 29 && b == 44)
		{
			return -15;
		}
		else if(a == 29 && b == 45)
		{
			return -16;
		}
		else if(a == 29 && b == 46)
		{
			return -17;
		}
		else if(a == 29 && b == 47)
		{
			return -18;
		}
		else if(a == 29 && b == 48)
		{
			return -19;
		}
		else if(a == 29 && b == 49)
		{
			return -20;
		}
		else if(a == 29 && b == 50)
		{
			return -21;
		}
		else if(a == 29 && b == 51)
		{
			return -22;
		}
		else if(a == 29 && b == 52)
		{
			return -23;
		}
		else if(a == 29 && b == 53)
		{
			return -24;
		}
		else if(a == 29 && b == 54)
		{
			return -25;
		}
		else if(a == 29 && b == 55)
		{
			return -26;
		}
		else if(a == 29 && b == 56)
		{
			return -27;
		}
		else if(a == 29 && b == 57)
		{
			return -28;
		}
		else if(a == 29 && b == 58)
		{
			return -29;
		}
		else if(a == 29 && b == 59)
		{
			return -30;
		}
		else if(a == 29 && b == 60)
		{
			return -31;
		}
		else if(a == 29 && b == 61)
		{
			return -32;
		}
		else if(a == 29 && b == 62)
		{
			return -33;
		}
		else if(a == 29 && b == 63)
		{
			return -34;
		}
		else if(a == 29 && b == 64)
		{
			return -35;
		}
		else if(a == 29 && b == 65)
		{
			return -36;
		}
		else if(a == 29 && b == 66)
		{
			return -37;
		}
		else if(a == 29 && b == 67)
		{
			return -38;
		}
		else if(a == 29 && b == 68)
		{
			return -39;
		}
		else if(a == 29 && b == 69)
		{
			return -40;
		}
		else if(a == 29 && b == 70)
		{
			return -41;
		}
		else if(a == 29 && b == 71)
		{
			return -42;
		}
		else if(a == 29 && b == 72)
		{
			return -43;
		}
		else if(a == 29 && b == 73)
		{
			return -44;
		}
		else if(a == 29 && b == 74)
		{
			return -45;
		}
		else if(a == 29 && b == 75)
		{
			return -46;
		}
		else if(a == 29 && b == 76)
		{
			return -47;
		}
		else if(a == 29 && b == 77)
		{
			return -48;
		}
		else if(a == 29 && b == 78)
		{
			return -49;
		}
		else if(a == 29 && b == 79)
		{
			return -50;
		}
		else if(a == 29 && b == 80)
		{
			return -51;
		}
		else if(a == 29 && b == 81)
		{
			return -52;
		}
		else if(a == 29 && b == 82)
		{
			return -53;
		}
		else if(a == 29 && b == 83)
		{
			return -54;
		}
		else if(a == 29 && b == 84)
		{
			return -55;
		}
		else if(a == 29 && b == 85)
		{
			return -56;
		}
		else if(a == 29 && b == 86)
		{
			return -57;
		}
		else if(a == 29 && b == 87)
		{
			return -58;
		}
		else if(a == 29 && b == 88)
		{
			return -59;
		}
		else if(a == 29 && b == 89)
		{
			return -60;
		}
		else if(a == 29 && b == 90)
		{
			return -61;
		}
		else if(a == 29 && b == 91)
		{
			return -62;
		}
		else if(a == 29 && b == 92)
		{
			return -63;
		}
		else if(a == 29 && b == 93)
		{
			return -64;
		}
		else if(a == 29 && b == 94)
		{
			return -65;
		}
		else if(a == 29 && b == 95)
		{
			return -66;
		}
		else if(a == 29 && b == 96)
		{
			return -67;
		}
		else if(a == 29 && b == 97)
		{
			return -68;
		}
		else if(a == 29 && b == 98)
		{
			return -69;
		}
		else if(a == 29 && b == 99)
		{
			return -70;
		}
		else if(a == 29 && b == 100)
		{
			return -71;
		}
		else if(a == 30 && b == 0)
		{
			return 30;
		}
		else if(a == 30 && b == 1)
		{
			return 29;
		}
		else if(a == 30 && b == 2)
		{
			return 28;
		}
		else if(a == 30 && b == 3)
		{
			return 27;
		}
		else if(a == 30 && b == 4)
		{
			return 26;
		}
		else if(a == 30 && b == 5)
		{
			return 25;
		}
		else if(a == 30 && b == 6)
		{
			return 24;
		}
		else if(a == 30 && b == 7)
		{
			return 23;
		}
		else if(a == 30 && b == 8)
		{
			return 22;
		}
		else if(a == 30 && b == 9)
		{
			return 21;
		}
		else if(a == 30 && b == 10)
		{
			return 20;
		}
		else if(a == 30 && b == 11)
		{
			return 19;
		}
		else if(a == 30 && b == 12)
		{
			return 18;
		}
		else if(a == 30 && b == 13)
		{
			return 17;
		}
		else if(a == 30 && b == 14)
		{
			return 16;
		}
		else if(a == 30 && b == 15)
		{
			return 15;
		}
		else if(a == 30 && b == 16)
		{
			return 14;
		}
		else if(a == 30 && b == 17)
		{
			return 13;
		}
		else if(a == 30 && b == 18)
		{
			return 12;
		}
		else if(a == 30 && b == 19)
		{
			return 11;
		}
		else if(a == 30 && b == 20)
		{
			return 10;
		}
		else if(a == 30 && b == 21)
		{
			return 9;
		}
		else if(a == 30 && b == 22)
		{
			return 8;
		}
		else if(a == 30 && b == 23)
		{
			return 7;
		}
		else if(a == 30 && b == 24)
		{
			return 6;
		}
		else if(a == 30 && b == 25)
		{
			return 5;
		}
		else if(a == 30 && b == 26)
		{
			return 4;
		}
		else if(a == 30 && b == 27)
		{
			return 3;
		}
		else if(a == 30 && b == 28)
		{
			return 2;
		}
		else if(a == 30 && b == 29)
		{
			return 1;
		}
		else if(a == 30 && b == 30)
		{
			return 0;
		}
		else if(a == 30 && b == 31)
		{
			return -1;
		}
		else if(a == 30 && b == 32)
		{
			return -2;
		}
		else if(a == 30 && b == 33)
		{
			return -3;
		}
		else if(a == 30 && b == 34)
		{
			return -4;
		}
		else if(a == 30 && b == 35)
		{
			return -5;
		}
		else if(a == 30 && b == 36)
		{
			return -6;
		}
		else if(a == 30 && b == 37)
		{
			return -7;
		}
		else if(a == 30 && b == 38)
		{
			return -8;
		}
		else if(a == 30 && b == 39)
		{
			return -9;
		}
		else if(a == 30 && b == 40)
		{
			return -10;
		}
		else if(a == 30 && b == 41)
		{
			return -11;
		}
		else if(a == 30 && b == 42)
		{
			return -12;
		}
		else if(a == 30 && b == 43)
		{
			return -13;
		}
		else if(a == 30 && b == 44)
		{
			return -14;
		}
		else if(a == 30 && b == 45)
		{
			return -15;
		}
		else if(a == 30 && b == 46)
		{
			return -16;
		}
		else if(a == 30 && b == 47)
		{
			return -17;
		}
		else if(a == 30 && b == 48)
		{
			return -18;
		}
		else if(a == 30 && b == 49)
		{
			return -19;
		}
		else if(a == 30 && b == 50)
		{
			return -20;
		}
		else if(a == 30 && b == 51)
		{
			return -21;
		}
		else if(a == 30 && b == 52)
		{
			return -22;
		}
		else if(a == 30 && b == 53)
		{
			return -23;
		}
		else if(a == 30 && b == 54)
		{
			return -24;
		}
		else if(a == 30 && b == 55)
		{
			return -25;
		}
		else if(a == 30 && b == 56)
		{
			return -26;
		}
		else if(a == 30 && b == 57)
		{
			return -27;
		}
		else if(a == 30 && b == 58)
		{
			return -28;
		}
		else if(a == 30 && b == 59)
		{
			return -29;
		}
		else if(a == 30 && b == 60)
		{
			return -30;
		}
		else if(a == 30 && b == 61)
		{
			return -31;
		}
		else if(a == 30 && b == 62)
		{
			return -32;
		}
		else if(a == 30 && b == 63)
		{
			return -33;
		}
		else if(a == 30 && b == 64)
		{
			return -34;
		}
		else if(a == 30 && b == 65)
		{
			return -35;
		}
		else if(a == 30 && b == 66)
		{
			return -36;
		}
		else if(a == 30 && b == 67)
		{
			return -37;
		}
		else if(a == 30 && b == 68)
		{
			return -38;
		}
		else if(a == 30 && b == 69)
		{
			return -39;
		}
		else if(a == 30 && b == 70)
		{
			return -40;
		}
		else if(a == 30 && b == 71)
		{
			return -41;
		}
		else if(a == 30 && b == 72)
		{
			return -42;
		}
		else if(a == 30 && b == 73)
		{
			return -43;
		}
		else if(a == 30 && b == 74)
		{
			return -44;
		}
		else if(a == 30 && b == 75)
		{
			return -45;
		}
		else if(a == 30 && b == 76)
		{
			return -46;
		}
		else if(a == 30 && b == 77)
		{
			return -47;
		}
		else if(a == 30 && b == 78)
		{
			return -48;
		}
		else if(a == 30 && b == 79)
		{
			return -49;
		}
		else if(a == 30 && b == 80)
		{
			return -50;
		}
		else if(a == 30 && b == 81)
		{
			return -51;
		}
		else if(a == 30 && b == 82)
		{
			return -52;
		}
		else if(a == 30 && b == 83)
		{
			return -53;
		}
		else if(a == 30 && b == 84)
		{
			return -54;
		}
		else if(a == 30 && b == 85)
		{
			return -55;
		}
		else if(a == 30 && b == 86)
		{
			return -56;
		}
		else if(a == 30 && b == 87)
		{
			return -57;
		}
		else if(a == 30 && b == 88)
		{
			return -58;
		}
		else if(a == 30 && b == 89)
		{
			return -59;
		}
		else if(a == 30 && b == 90)
		{
			return -60;
		}
		else if(a == 30 && b == 91)
		{
			return -61;
		}
		else if(a == 30 && b == 92)
		{
			return -62;
		}
		else if(a == 30 && b == 93)
		{
			return -63;
		}
		else if(a == 30 && b == 94)
		{
			return -64;
		}
		else if(a == 30 && b == 95)
		{
			return -65;
		}
		else if(a == 30 && b == 96)
		{
			return -66;
		}
		else if(a == 30 && b == 97)
		{
			return -67;
		}
		else if(a == 30 && b == 98)
		{
			return -68;
		}
		else if(a == 30 && b == 99)
		{
			return -69;
		}
		else if(a == 30 && b == 100)
		{
			return -70;
		}
		else if(a == 31 && b == 0)
		{
			return 31;
		}
		else if(a == 31 && b == 1)
		{
			return 30;
		}
		else if(a == 31 && b == 2)
		{
			return 29;
		}
		else if(a == 31 && b == 3)
		{
			return 28;
		}
		else if(a == 31 && b == 4)
		{
			return 27;
		}
		else if(a == 31 && b == 5)
		{
			return 26;
		}
		else if(a == 31 && b == 6)
		{
			return 25;
		}
		else if(a == 31 && b == 7)
		{
			return 24;
		}
		else if(a == 31 && b == 8)
		{
			return 23;
		}
		else if(a == 31 && b == 9)
		{
			return 22;
		}
		else if(a == 31 && b == 10)
		{
			return 21;
		}
		else if(a == 31 && b == 11)
		{
			return 20;
		}
		else if(a == 31 && b == 12)
		{
			return 19;
		}
		else if(a == 31 && b == 13)
		{
			return 18;
		}
		else if(a == 31 && b == 14)
		{
			return 17;
		}
		else if(a == 31 && b == 15)
		{
			return 16;
		}
		else if(a == 31 && b == 16)
		{
			return 15;
		}
		else if(a == 31 && b == 17)
		{
			return 14;
		}
		else if(a == 31 && b == 18)
		{
			return 13;
		}
		else if(a == 31 && b == 19)
		{
			return 12;
		}
		else if(a == 31 && b == 20)
		{
			return 11;
		}
		else if(a == 31 && b == 21)
		{
			return 10;
		}
		else if(a == 31 && b == 22)
		{
			return 9;
		}
		else if(a == 31 && b == 23)
		{
			return 8;
		}
		else if(a == 31 && b == 24)
		{
			return 7;
		}
		else if(a == 31 && b == 25)
		{
			return 6;
		}
		else if(a == 31 && b == 26)
		{
			return 5;
		}
		else if(a == 31 && b == 27)
		{
			return 4;
		}
		else if(a == 31 && b == 28)
		{
			return 3;
		}
		else if(a == 31 && b == 29)
		{
			return 2;
		}
		else if(a == 31 && b == 30)
		{
			return 1;
		}
		else if(a == 31 && b == 31)
		{
			return 0;
		}
		else if(a == 31 && b == 32)
		{
			return -1;
		}
		else if(a == 31 && b == 33)
		{
			return -2;
		}
		else if(a == 31 && b == 34)
		{
			return -3;
		}
		else if(a == 31 && b == 35)
		{
			return -4;
		}
		else if(a == 31 && b == 36)
		{
			return -5;
		}
		else if(a == 31 && b == 37)
		{
			return -6;
		}
		else if(a == 31 && b == 38)
		{
			return -7;
		}
		else if(a == 31 && b == 39)
		{
			return -8;
		}
		else if(a == 31 && b == 40)
		{
			return -9;
		}
		else if(a == 31 && b == 41)
		{
			return -10;
		}
		else if(a == 31 && b == 42)
		{
			return -11;
		}
		else if(a == 31 && b == 43)
		{
			return -12;
		}
		else if(a == 31 && b == 44)
		{
			return -13;
		}
		else if(a == 31 && b == 45)
		{
			return -14;
		}
		else if(a == 31 && b == 46)
		{
			return -15;
		}
		else if(a == 31 && b == 47)
		{
			return -16;
		}
		else if(a == 31 && b == 48)
		{
			return -17;
		}
		else if(a == 31 && b == 49)
		{
			return -18;
		}
		else if(a == 31 && b == 50)
		{
			return -19;
		}
		else if(a == 31 && b == 51)
		{
			return -20;
		}
		else if(a == 31 && b == 52)
		{
			return -21;
		}
		else if(a == 31 && b == 53)
		{
			return -22;
		}
		else if(a == 31 && b == 54)
		{
			return -23;
		}
		else if(a == 31 && b == 55)
		{
			return -24;
		}
		else if(a == 31 && b == 56)
		{
			return -25;
		}
		else if(a == 31 && b == 57)
		{
			return -26;
		}
		else if(a == 31 && b == 58)
		{
			return -27;
		}
		else if(a == 31 && b == 59)
		{
			return -28;
		}
		else if(a == 31 && b == 60)
		{
			return -29;
		}
		else if(a == 31 && b == 61)
		{
			return -30;
		}
		else if(a == 31 && b == 62)
		{
			return -31;
		}
		else if(a == 31 && b == 63)
		{
			return -32;
		}
		else if(a == 31 && b == 64)
		{
			return -33;
		}
		else if(a == 31 && b == 65)
		{
			return -34;
		}
		else if(a == 31 && b == 66)
		{
			return -35;
		}
		else if(a == 31 && b == 67)
		{
			return -36;
		}
		else if(a == 31 && b == 68)
		{
			return -37;
		}
		else if(a == 31 && b == 69)
		{
			return -38;
		}
		else if(a == 31 && b == 70)
		{
			return -39;
		}
		else if(a == 31 && b == 71)
		{
			return -40;
		}
		else if(a == 31 && b == 72)
		{
			return -41;
		}
		else if(a == 31 && b == 73)
		{
			return -42;
		}
		else if(a == 31 && b == 74)
		{
			return -43;
		}
		else if(a == 31 && b == 75)
		{
			return -44;
		}
		else if(a == 31 && b == 76)
		{
			return -45;
		}
		else if(a == 31 && b == 77)
		{
			return -46;
		}
		else if(a == 31 && b == 78)
		{
			return -47;
		}
		else if(a == 31 && b == 79)
		{
			return -48;
		}
		else if(a == 31 && b == 80)
		{
			return -49;
		}
		else if(a == 31 && b == 81)
		{
			return -50;
		}
		else if(a == 31 && b == 82)
		{
			return -51;
		}
		else if(a == 31 && b == 83)
		{
			return -52;
		}
		else if(a == 31 && b == 84)
		{
			return -53;
		}
		else if(a == 31 && b == 85)
		{
			return -54;
		}
		else if(a == 31 && b == 86)
		{
			return -55;
		}
		else if(a == 31 && b == 87)
		{
			return -56;
		}
		else if(a == 31 && b == 88)
		{
			return -57;
		}
		else if(a == 31 && b == 89)
		{
			return -58;
		}
		else if(a == 31 && b == 90)
		{
			return -59;
		}
		else if(a == 31 && b == 91)
		{
			return -60;
		}
		else if(a == 31 && b == 92)
		{
			return -61;
		}
		else if(a == 31 && b == 93)
		{
			return -62;
		}
		else if(a == 31 && b == 94)
		{
			return -63;
		}
		else if(a == 31 && b == 95)
		{
			return -64;
		}
		else if(a == 31 && b == 96)
		{
			return -65;
		}
		else if(a == 31 && b == 97)
		{
			return -66;
		}
		else if(a == 31 && b == 98)
		{
			return -67;
		}
		else if(a == 31 && b == 99)
		{
			return -68;
		}
		else if(a == 31 && b == 100)
		{
			return -69;
		}
		else if(a == 32 && b == 0)
		{
			return 32;
		}
		else if(a == 32 && b == 1)
		{
			return 31;
		}
		else if(a == 32 && b == 2)
		{
			return 30;
		}
		else if(a == 32 && b == 3)
		{
			return 29;
		}
		else if(a == 32 && b == 4)
		{
			return 28;
		}
		else if(a == 32 && b == 5)
		{
			return 27;
		}
		else if(a == 32 && b == 6)
		{
			return 26;
		}
		else if(a == 32 && b == 7)
		{
			return 25;
		}
		else if(a == 32 && b == 8)
		{
			return 24;
		}
		else if(a == 32 && b == 9)
		{
			return 23;
		}
		else if(a == 32 && b == 10)
		{
			return 22;
		}
		else if(a == 32 && b == 11)
		{
			return 21;
		}
		else if(a == 32 && b == 12)
		{
			return 20;
		}
		else if(a == 32 && b == 13)
		{
			return 19;
		}
		else if(a == 32 && b == 14)
		{
			return 18;
		}
		else if(a == 32 && b == 15)
		{
			return 17;
		}
		else if(a == 32 && b == 16)
		{
			return 16;
		}
		else if(a == 32 && b == 17)
		{
			return 15;
		}
		else if(a == 32 && b == 18)
		{
			return 14;
		}
		else if(a == 32 && b == 19)
		{
			return 13;
		}
		else if(a == 32 && b == 20)
		{
			return 12;
		}
		else if(a == 32 && b == 21)
		{
			return 11;
		}
		else if(a == 32 && b == 22)
		{
			return 10;
		}
		else if(a == 32 && b == 23)
		{
			return 9;
		}
		else if(a == 32 && b == 24)
		{
			return 8;
		}
		else if(a == 32 && b == 25)
		{
			return 7;
		}
		else if(a == 32 && b == 26)
		{
			return 6;
		}
		else if(a == 32 && b == 27)
		{
			return 5;
		}
		else if(a == 32 && b == 28)
		{
			return 4;
		}
		else if(a == 32 && b == 29)
		{
			return 3;
		}
		else if(a == 32 && b == 30)
		{
			return 2;
		}
		else if(a == 32 && b == 31)
		{
			return 1;
		}
		else if(a == 32 && b == 32)
		{
			return 0;
		}
		else if(a == 32 && b == 33)
		{
			return -1;
		}
		else if(a == 32 && b == 34)
		{
			return -2;
		}
		else if(a == 32 && b == 35)
		{
			return -3;
		}
		else if(a == 32 && b == 36)
		{
			return -4;
		}
		else if(a == 32 && b == 37)
		{
			return -5;
		}
		else if(a == 32 && b == 38)
		{
			return -6;
		}
		else if(a == 32 && b == 39)
		{
			return -7;
		}
		else if(a == 32 && b == 40)
		{
			return -8;
		}
		else if(a == 32 && b == 41)
		{
			return -9;
		}
		else if(a == 32 && b == 42)
		{
			return -10;
		}
		else if(a == 32 && b == 43)
		{
			return -11;
		}
		else if(a == 32 && b == 44)
		{
			return -12;
		}
		else if(a == 32 && b == 45)
		{
			return -13;
		}
		else if(a == 32 && b == 46)
		{
			return -14;
		}
		else if(a == 32 && b == 47)
		{
			return -15;
		}
		else if(a == 32 && b == 48)
		{
			return -16;
		}
		else if(a == 32 && b == 49)
		{
			return -17;
		}
		else if(a == 32 && b == 50)
		{
			return -18;
		}
		else if(a == 32 && b == 51)
		{
			return -19;
		}
		else if(a == 32 && b == 52)
		{
			return -20;
		}
		else if(a == 32 && b == 53)
		{
			return -21;
		}
		else if(a == 32 && b == 54)
		{
			return -22;
		}
		else if(a == 32 && b == 55)
		{
			return -23;
		}
		else if(a == 32 && b == 56)
		{
			return -24;
		}
		else if(a == 32 && b == 57)
		{
			return -25;
		}
		else if(a == 32 && b == 58)
		{
			return -26;
		}
		else if(a == 32 && b == 59)
		{
			return -27;
		}
		else if(a == 32 && b == 60)
		{
			return -28;
		}
		else if(a == 32 && b == 61)
		{
			return -29;
		}
		else if(a == 32 && b == 62)
		{
			return -30;
		}
		else if(a == 32 && b == 63)
		{
			return -31;
		}
		else if(a == 32 && b == 64)
		{
			return -32;
		}
		else if(a == 32 && b == 65)
		{
			return -33;
		}
		else if(a == 32 && b == 66)
		{
			return -34;
		}
		else if(a == 32 && b == 67)
		{
			return -35;
		}
		else if(a == 32 && b == 68)
		{
			return -36;
		}
		else if(a == 32 && b == 69)
		{
			return -37;
		}
		else if(a == 32 && b == 70)
		{
			return -38;
		}
		else if(a == 32 && b == 71)
		{
			return -39;
		}
		else if(a == 32 && b == 72)
		{
			return -40;
		}
		else if(a == 32 && b == 73)
		{
			return -41;
		}
		else if(a == 32 && b == 74)
		{
			return -42;
		}
		else if(a == 32 && b == 75)
		{
			return -43;
		}
		else if(a == 32 && b == 76)
		{
			return -44;
		}
		else if(a == 32 && b == 77)
		{
			return -45;
		}
		else if(a == 32 && b == 78)
		{
			return -46;
		}
		else if(a == 32 && b == 79)
		{
			return -47;
		}
		else if(a == 32 && b == 80)
		{
			return -48;
		}
		else if(a == 32 && b == 81)
		{
			return -49;
		}
		else if(a == 32 && b == 82)
		{
			return -50;
		}
		else if(a == 32 && b == 83)
		{
			return -51;
		}
		else if(a == 32 && b == 84)
		{
			return -52;
		}
		else if(a == 32 && b == 85)
		{
			return -53;
		}
		else if(a == 32 && b == 86)
		{
			return -54;
		}
		else if(a == 32 && b == 87)
		{
			return -55;
		}
		else if(a == 32 && b == 88)
		{
			return -56;
		}
		else if(a == 32 && b == 89)
		{
			return -57;
		}
		else if(a == 32 && b == 90)
		{
			return -58;
		}
		else if(a == 32 && b == 91)
		{
			return -59;
		}
		else if(a == 32 && b == 92)
		{
			return -60;
		}
		else if(a == 32 && b == 93)
		{
			return -61;
		}
		else if(a == 32 && b == 94)
		{
			return -62;
		}
		else if(a == 32 && b == 95)
		{
			return -63;
		}
		else if(a == 32 && b == 96)
		{
			return -64;
		}
		else if(a == 32 && b == 97)
		{
			return -65;
		}
		else if(a == 32 && b == 98)
		{
			return -66;
		}
		else if(a == 32 && b == 99)
		{
			return -67;
		}
		else if(a == 32 && b == 100)
		{
			return -68;
		}
		else if(a == 33 && b == 0)
		{
			return 33;
		}
		else if(a == 33 && b == 1)
		{
			return 32;
		}
		else if(a == 33 && b == 2)
		{
			return 31;
		}
		else if(a == 33 && b == 3)
		{
			return 30;
		}
		else if(a == 33 && b == 4)
		{
			return 29;
		}
		else if(a == 33 && b == 5)
		{
			return 28;
		}
		else if(a == 33 && b == 6)
		{
			return 27;
		}
		else if(a == 33 && b == 7)
		{
			return 26;
		}
		else if(a == 33 && b == 8)
		{
			return 25;
		}
		else if(a == 33 && b == 9)
		{
			return 24;
		}
		else if(a == 33 && b == 10)
		{
			return 23;
		}
		else if(a == 33 && b == 11)
		{
			return 22;
		}
		else if(a == 33 && b == 12)
		{
			return 21;
		}
		else if(a == 33 && b == 13)
		{
			return 20;
		}
		else if(a == 33 && b == 14)
		{
			return 19;
		}
		else if(a == 33 && b == 15)
		{
			return 18;
		}
		else if(a == 33 && b == 16)
		{
			return 17;
		}
		else if(a == 33 && b == 17)
		{
			return 16;
		}
		else if(a == 33 && b == 18)
		{
			return 15;
		}
		else if(a == 33 && b == 19)
		{
			return 14;
		}
		else if(a == 33 && b == 20)
		{
			return 13;
		}
		else if(a == 33 && b == 21)
		{
			return 12;
		}
		else if(a == 33 && b == 22)
		{
			return 11;
		}
		else if(a == 33 && b == 23)
		{
			return 10;
		}
		else if(a == 33 && b == 24)
		{
			return 9;
		}
		else if(a == 33 && b == 25)
		{
			return 8;
		}
		else if(a == 33 && b == 26)
		{
			return 7;
		}
		else if(a == 33 && b == 27)
		{
			return 6;
		}
		else if(a == 33 && b == 28)
		{
			return 5;
		}
		else if(a == 33 && b == 29)
		{
			return 4;
		}
		else if(a == 33 && b == 30)
		{
			return 3;
		}
		else if(a == 33 && b == 31)
		{
			return 2;
		}
		else if(a == 33 && b == 32)
		{
			return 1;
		}
		else if(a == 33 && b == 33)
		{
			return 0;
		}
		else if(a == 33 && b == 34)
		{
			return -1;
		}
		else if(a == 33 && b == 35)
		{
			return -2;
		}
		else if(a == 33 && b == 36)
		{
			return -3;
		}
		else if(a == 33 && b == 37)
		{
			return -4;
		}
		else if(a == 33 && b == 38)
		{
			return -5;
		}
		else if(a == 33 && b == 39)
		{
			return -6;
		}
		else if(a == 33 && b == 40)
		{
			return -7;
		}
		else if(a == 33 && b == 41)
		{
			return -8;
		}
		else if(a == 33 && b == 42)
		{
			return -9;
		}
		else if(a == 33 && b == 43)
		{
			return -10;
		}
		else if(a == 33 && b == 44)
		{
			return -11;
		}
		else if(a == 33 && b == 45)
		{
			return -12;
		}
		else if(a == 33 && b == 46)
		{
			return -13;
		}
		else if(a == 33 && b == 47)
		{
			return -14;
		}
		else if(a == 33 && b == 48)
		{
			return -15;
		}
		else if(a == 33 && b == 49)
		{
			return -16;
		}
		else if(a == 33 && b == 50)
		{
			return -17;
		}
		else if(a == 33 && b == 51)
		{
			return -18;
		}
		else if(a == 33 && b == 52)
		{
			return -19;
		}
		else if(a == 33 && b == 53)
		{
			return -20;
		}
		else if(a == 33 && b == 54)
		{
			return -21;
		}
		else if(a == 33 && b == 55)
		{
			return -22;
		}
		else if(a == 33 && b == 56)
		{
			return -23;
		}
		else if(a == 33 && b == 57)
		{
			return -24;
		}
		else if(a == 33 && b == 58)
		{
			return -25;
		}
		else if(a == 33 && b == 59)
		{
			return -26;
		}
		else if(a == 33 && b == 60)
		{
			return -27;
		}
		else if(a == 33 && b == 61)
		{
			return -28;
		}
		else if(a == 33 && b == 62)
		{
			return -29;
		}
		else if(a == 33 && b == 63)
		{
			return -30;
		}
		else if(a == 33 && b == 64)
		{
			return -31;
		}
		else if(a == 33 && b == 65)
		{
			return -32;
		}
		else if(a == 33 && b == 66)
		{
			return -33;
		}
		else if(a == 33 && b == 67)
		{
			return -34;
		}
		else if(a == 33 && b == 68)
		{
			return -35;
		}
		else if(a == 33 && b == 69)
		{
			return -36;
		}
		else if(a == 33 && b == 70)
		{
			return -37;
		}
		else if(a == 33 && b == 71)
		{
			return -38;
		}
		else if(a == 33 && b == 72)
		{
			return -39;
		}
		else if(a == 33 && b == 73)
		{
			return -40;
		}
		else if(a == 33 && b == 74)
		{
			return -41;
		}
		else if(a == 33 && b == 75)
		{
			return -42;
		}
		else if(a == 33 && b == 76)
		{
			return -43;
		}
		else if(a == 33 && b == 77)
		{
			return -44;
		}
		else if(a == 33 && b == 78)
		{
			return -45;
		}
		else if(a == 33 && b == 79)
		{
			return -46;
		}
		else if(a == 33 && b == 80)
		{
			return -47;
		}
		else if(a == 33 && b == 81)
		{
			return -48;
		}
		else if(a == 33 && b == 82)
		{
			return -49;
		}
		else if(a == 33 && b == 83)
		{
			return -50;
		}
		else if(a == 33 && b == 84)
		{
			return -51;
		}
		else if(a == 33 && b == 85)
		{
			return -52;
		}
		else if(a == 33 && b == 86)
		{
			return -53;
		}
		else if(a == 33 && b == 87)
		{
			return -54;
		}
		else if(a == 33 && b == 88)
		{
			return -55;
		}
		else if(a == 33 && b == 89)
		{
			return -56;
		}
		else if(a == 33 && b == 90)
		{
			return -57;
		}
		else if(a == 33 && b == 91)
		{
			return -58;
		}
		else if(a == 33 && b == 92)
		{
			return -59;
		}
		else if(a == 33 && b == 93)
		{
			return -60;
		}
		else if(a == 33 && b == 94)
		{
			return -61;
		}
		else if(a == 33 && b == 95)
		{
			return -62;
		}
		else if(a == 33 && b == 96)
		{
			return -63;
		}
		else if(a == 33 && b == 97)
		{
			return -64;
		}
		else if(a == 33 && b == 98)
		{
			return -65;
		}
		else if(a == 33 && b == 99)
		{
			return -66;
		}
		else if(a == 33 && b == 100)
		{
			return -67;
		}
		else if(a == 34 && b == 0)
		{
			return 34;
		}
		else if(a == 34 && b == 1)
		{
			return 33;
		}
		else if(a == 34 && b == 2)
		{
			return 32;
		}
		else if(a == 34 && b == 3)
		{
			return 31;
		}
		else if(a == 34 && b == 4)
		{
			return 30;
		}
		else if(a == 34 && b == 5)
		{
			return 29;
		}
		else if(a == 34 && b == 6)
		{
			return 28;
		}
		else if(a == 34 && b == 7)
		{
			return 27;
		}
		else if(a == 34 && b == 8)
		{
			return 26;
		}
		else if(a == 34 && b == 9)
		{
			return 25;
		}
		else if(a == 34 && b == 10)
		{
			return 24;
		}
		else if(a == 34 && b == 11)
		{
			return 23;
		}
		else if(a == 34 && b == 12)
		{
			return 22;
		}
		else if(a == 34 && b == 13)
		{
			return 21;
		}
		else if(a == 34 && b == 14)
		{
			return 20;
		}
		else if(a == 34 && b == 15)
		{
			return 19;
		}
		else if(a == 34 && b == 16)
		{
			return 18;
		}
		else if(a == 34 && b == 17)
		{
			return 17;
		}
		else if(a == 34 && b == 18)
		{
			return 16;
		}
		else if(a == 34 && b == 19)
		{
			return 15;
		}
		else if(a == 34 && b == 20)
		{
			return 14;
		}
		else if(a == 34 && b == 21)
		{
			return 13;
		}
		else if(a == 34 && b == 22)
		{
			return 12;
		}
		else if(a == 34 && b == 23)
		{
			return 11;
		}
		else if(a == 34 && b == 24)
		{
			return 10;
		}
		else if(a == 34 && b == 25)
		{
			return 9;
		}
		else if(a == 34 && b == 26)
		{
			return 8;
		}
		else if(a == 34 && b == 27)
		{
			return 7;
		}
		else if(a == 34 && b == 28)
		{
			return 6;
		}
		else if(a == 34 && b == 29)
		{
			return 5;
		}
		else if(a == 34 && b == 30)
		{
			return 4;
		}
		else if(a == 34 && b == 31)
		{
			return 3;
		}
		else if(a == 34 && b == 32)
		{
			return 2;
		}
		else if(a == 34 && b == 33)
		{
			return 1;
		}
		else if(a == 34 && b == 34)
		{
			return 0;
		}
		else if(a == 34 && b == 35)
		{
			return -1;
		}
		else if(a == 34 && b == 36)
		{
			return -2;
		}
		else if(a == 34 && b == 37)
		{
			return -3;
		}
		else if(a == 34 && b == 38)
		{
			return -4;
		}
		else if(a == 34 && b == 39)
		{
			return -5;
		}
		else if(a == 34 && b == 40)
		{
			return -6;
		}
		else if(a == 34 && b == 41)
		{
			return -7;
		}
		else if(a == 34 && b == 42)
		{
			return -8;
		}
		else if(a == 34 && b == 43)
		{
			return -9;
		}
		else if(a == 34 && b == 44)
		{
			return -10;
		}
		else if(a == 34 && b == 45)
		{
			return -11;
		}
		else if(a == 34 && b == 46)
		{
			return -12;
		}
		else if(a == 34 && b == 47)
		{
			return -13;
		}
		else if(a == 34 && b == 48)
		{
			return -14;
		}
		else if(a == 34 && b == 49)
		{
			return -15;
		}
		else if(a == 34 && b == 50)
		{
			return -16;
		}
		else if(a == 34 && b == 51)
		{
			return -17;
		}
		else if(a == 34 && b == 52)
		{
			return -18;
		}
		else if(a == 34 && b == 53)
		{
			return -19;
		}
		else if(a == 34 && b == 54)
		{
			return -20;
		}
		else if(a == 34 && b == 55)
		{
			return -21;
		}
		else if(a == 34 && b == 56)
		{
			return -22;
		}
		else if(a == 34 && b == 57)
		{
			return -23;
		}
		else if(a == 34 && b == 58)
		{
			return -24;
		}
		else if(a == 34 && b == 59)
		{
			return -25;
		}
		else if(a == 34 && b == 60)
		{
			return -26;
		}
		else if(a == 34 && b == 61)
		{
			return -27;
		}
		else if(a == 34 && b == 62)
		{
			return -28;
		}
		else if(a == 34 && b == 63)
		{
			return -29;
		}
		else if(a == 34 && b == 64)
		{
			return -30;
		}
		else if(a == 34 && b == 65)
		{
			return -31;
		}
		else if(a == 34 && b == 66)
		{
			return -32;
		}
		else if(a == 34 && b == 67)
		{
			return -33;
		}
		else if(a == 34 && b == 68)
		{
			return -34;
		}
		else if(a == 34 && b == 69)
		{
			return -35;
		}
		else if(a == 34 && b == 70)
		{
			return -36;
		}
		else if(a == 34 && b == 71)
		{
			return -37;
		}
		else if(a == 34 && b == 72)
		{
			return -38;
		}
		else if(a == 34 && b == 73)
		{
			return -39;
		}
		else if(a == 34 && b == 74)
		{
			return -40;
		}
		else if(a == 34 && b == 75)
		{
			return -41;
		}
		else if(a == 34 && b == 76)
		{
			return -42;
		}
		else if(a == 34 && b == 77)
		{
			return -43;
		}
		else if(a == 34 && b == 78)
		{
			return -44;
		}
		else if(a == 34 && b == 79)
		{
			return -45;
		}
		else if(a == 34 && b == 80)
		{
			return -46;
		}
		else if(a == 34 && b == 81)
		{
			return -47;
		}
		else if(a == 34 && b == 82)
		{
			return -48;
		}
		else if(a == 34 && b == 83)
		{
			return -49;
		}
		else if(a == 34 && b == 84)
		{
			return -50;
		}
		else if(a == 34 && b == 85)
		{
			return -51;
		}
		else if(a == 34 && b == 86)
		{
			return -52;
		}
		else if(a == 34 && b == 87)
		{
			return -53;
		}
		else if(a == 34 && b == 88)
		{
			return -54;
		}
		else if(a == 34 && b == 89)
		{
			return -55;
		}
		else if(a == 34 && b == 90)
		{
			return -56;
		}
		else if(a == 34 && b == 91)
		{
			return -57;
		}
		else if(a == 34 && b == 92)
		{
			return -58;
		}
		else if(a == 34 && b == 93)
		{
			return -59;
		}
		else if(a == 34 && b == 94)
		{
			return -60;
		}
		else if(a == 34 && b == 95)
		{
			return -61;
		}
		else if(a == 34 && b == 96)
		{
			return -62;
		}
		else if(a == 34 && b == 97)
		{
			return -63;
		}
		else if(a == 34 && b == 98)
		{
			return -64;
		}
		else if(a == 34 && b == 99)
		{
			return -65;
		}
		else if(a == 34 && b == 100)
		{
			return -66;
		}
		else if(a == 35 && b == 0)
		{
			return 35;
		}
		else if(a == 35 && b == 1)
		{
			return 34;
		}
		else if(a == 35 && b == 2)
		{
			return 33;
		}
		else if(a == 35 && b == 3)
		{
			return 32;
		}
		else if(a == 35 && b == 4)
		{
			return 31;
		}
		else if(a == 35 && b == 5)
		{
			return 30;
		}
		else if(a == 35 && b == 6)
		{
			return 29;
		}
		else if(a == 35 && b == 7)
		{
			return 28;
		}
		else if(a == 35 && b == 8)
		{
			return 27;
		}
		else if(a == 35 && b == 9)
		{
			return 26;
		}
		else if(a == 35 && b == 10)
		{
			return 25;
		}
		else if(a == 35 && b == 11)
		{
			return 24;
		}
		else if(a == 35 && b == 12)
		{
			return 23;
		}
		else if(a == 35 && b == 13)
		{
			return 22;
		}
		else if(a == 35 && b == 14)
		{
			return 21;
		}
		else if(a == 35 && b == 15)
		{
			return 20;
		}
		else if(a == 35 && b == 16)
		{
			return 19;
		}
		else if(a == 35 && b == 17)
		{
			return 18;
		}
		else if(a == 35 && b == 18)
		{
			return 17;
		}
		else if(a == 35 && b == 19)
		{
			return 16;
		}
		else if(a == 35 && b == 20)
		{
			return 15;
		}
		else if(a == 35 && b == 21)
		{
			return 14;
		}
		else if(a == 35 && b == 22)
		{
			return 13;
		}
		else if(a == 35 && b == 23)
		{
			return 12;
		}
		else if(a == 35 && b == 24)
		{
			return 11;
		}
		else if(a == 35 && b == 25)
		{
			return 10;
		}
		else if(a == 35 && b == 26)
		{
			return 9;
		}
		else if(a == 35 && b == 27)
		{
			return 8;
		}
		else if(a == 35 && b == 28)
		{
			return 7;
		}
		else if(a == 35 && b == 29)
		{
			return 6;
		}
		else if(a == 35 && b == 30)
		{
			return 5;
		}
		else if(a == 35 && b == 31)
		{
			return 4;
		}
		else if(a == 35 && b == 32)
		{
			return 3;
		}
		else if(a == 35 && b == 33)
		{
			return 2;
		}
		else if(a == 35 && b == 34)
		{
			return 1;
		}
		else if(a == 35 && b == 35)
		{
			return 0;
		}
		else if(a == 35 && b == 36)
		{
			return -1;
		}
		else if(a == 35 && b == 37)
		{
			return -2;
		}
		else if(a == 35 && b == 38)
		{
			return -3;
		}
		else if(a == 35 && b == 39)
		{
			return -4;
		}
		else if(a == 35 && b == 40)
		{
			return -5;
		}
		else if(a == 35 && b == 41)
		{
			return -6;
		}
		else if(a == 35 && b == 42)
		{
			return -7;
		}
		else if(a == 35 && b == 43)
		{
			return -8;
		}
		else if(a == 35 && b == 44)
		{
			return -9;
		}
		else if(a == 35 && b == 45)
		{
			return -10;
		}
		else if(a == 35 && b == 46)
		{
			return -11;
		}
		else if(a == 35 && b == 47)
		{
			return -12;
		}
		else if(a == 35 && b == 48)
		{
			return -13;
		}
		else if(a == 35 && b == 49)
		{
			return -14;
		}
		else if(a == 35 && b == 50)
		{
			return -15;
		}
		else if(a == 35 && b == 51)
		{
			return -16;
		}
		else if(a == 35 && b == 52)
		{
			return -17;
		}
		else if(a == 35 && b == 53)
		{
			return -18;
		}
		else if(a == 35 && b == 54)
		{
			return -19;
		}
		else if(a == 35 && b == 55)
		{
			return -20;
		}
		else if(a == 35 && b == 56)
		{
			return -21;
		}
		else if(a == 35 && b == 57)
		{
			return -22;
		}
		else if(a == 35 && b == 58)
		{
			return -23;
		}
		else if(a == 35 && b == 59)
		{
			return -24;
		}
		else if(a == 35 && b == 60)
		{
			return -25;
		}
		else if(a == 35 && b == 61)
		{
			return -26;
		}
		else if(a == 35 && b == 62)
		{
			return -27;
		}
		else if(a == 35 && b == 63)
		{
			return -28;
		}
		else if(a == 35 && b == 64)
		{
			return -29;
		}
		else if(a == 35 && b == 65)
		{
			return -30;
		}
		else if(a == 35 && b == 66)
		{
			return -31;
		}
		else if(a == 35 && b == 67)
		{
			return -32;
		}
		else if(a == 35 && b == 68)
		{
			return -33;
		}
		else if(a == 35 && b == 69)
		{
			return -34;
		}
		else if(a == 35 && b == 70)
		{
			return -35;
		}
		else if(a == 35 && b == 71)
		{
			return -36;
		}
		else if(a == 35 && b == 72)
		{
			return -37;
		}
		else if(a == 35 && b == 73)
		{
			return -38;
		}
		else if(a == 35 && b == 74)
		{
			return -39;
		}
		else if(a == 35 && b == 75)
		{
			return -40;
		}
		else if(a == 35 && b == 76)
		{
			return -41;
		}
		else if(a == 35 && b == 77)
		{
			return -42;
		}
		else if(a == 35 && b == 78)
		{
			return -43;
		}
		else if(a == 35 && b == 79)
		{
			return -44;
		}
		else if(a == 35 && b == 80)
		{
			return -45;
		}
		else if(a == 35 && b == 81)
		{
			return -46;
		}
		else if(a == 35 && b == 82)
		{
			return -47;
		}
		else if(a == 35 && b == 83)
		{
			return -48;
		}
		else if(a == 35 && b == 84)
		{
			return -49;
		}
		else if(a == 35 && b == 85)
		{
			return -50;
		}
		else if(a == 35 && b == 86)
		{
			return -51;
		}
		else if(a == 35 && b == 87)
		{
			return -52;
		}
		else if(a == 35 && b == 88)
		{
			return -53;
		}
		else if(a == 35 && b == 89)
		{
			return -54;
		}
		else if(a == 35 && b == 90)
		{
			return -55;
		}
		else if(a == 35 && b == 91)
		{
			return -56;
		}
		else if(a == 35 && b == 92)
		{
			return -57;
		}
		else if(a == 35 && b == 93)
		{
			return -58;
		}
		else if(a == 35 && b == 94)
		{
			return -59;
		}
		else if(a == 35 && b == 95)
		{
			return -60;
		}
		else if(a == 35 && b == 96)
		{
			return -61;
		}
		else if(a == 35 && b == 97)
		{
			return -62;
		}
		else if(a == 35 && b == 98)
		{
			return -63;
		}
		else if(a == 35 && b == 99)
		{
			return -64;
		}
		else if(a == 35 && b == 100)
		{
			return -65;
		}
		else if(a == 36 && b == 0)
		{
			return 36;
		}
		else if(a == 36 && b == 1)
		{
			return 35;
		}
		else if(a == 36 && b == 2)
		{
			return 34;
		}
		else if(a == 36 && b == 3)
		{
			return 33;
		}
		else if(a == 36 && b == 4)
		{
			return 32;
		}
		else if(a == 36 && b == 5)
		{
			return 31;
		}
		else if(a == 36 && b == 6)
		{
			return 30;
		}
		else if(a == 36 && b == 7)
		{
			return 29;
		}
		else if(a == 36 && b == 8)
		{
			return 28;
		}
		else if(a == 36 && b == 9)
		{
			return 27;
		}
		else if(a == 36 && b == 10)
		{
			return 26;
		}
		else if(a == 36 && b == 11)
		{
			return 25;
		}
		else if(a == 36 && b == 12)
		{
			return 24;
		}
		else if(a == 36 && b == 13)
		{
			return 23;
		}
		else if(a == 36 && b == 14)
		{
			return 22;
		}
		else if(a == 36 && b == 15)
		{
			return 21;
		}
		else if(a == 36 && b == 16)
		{
			return 20;
		}
		else if(a == 36 && b == 17)
		{
			return 19;
		}
		else if(a == 36 && b == 18)
		{
			return 18;
		}
		else if(a == 36 && b == 19)
		{
			return 17;
		}
		else if(a == 36 && b == 20)
		{
			return 16;
		}
		else if(a == 36 && b == 21)
		{
			return 15;
		}
		else if(a == 36 && b == 22)
		{
			return 14;
		}
		else if(a == 36 && b == 23)
		{
			return 13;
		}
		else if(a == 36 && b == 24)
		{
			return 12;
		}
		else if(a == 36 && b == 25)
		{
			return 11;
		}
		else if(a == 36 && b == 26)
		{
			return 10;
		}
		else if(a == 36 && b == 27)
		{
			return 9;
		}
		else if(a == 36 && b == 28)
		{
			return 8;
		}
		else if(a == 36 && b == 29)
		{
			return 7;
		}
		else if(a == 36 && b == 30)
		{
			return 6;
		}
		else if(a == 36 && b == 31)
		{
			return 5;
		}
		else if(a == 36 && b == 32)
		{
			return 4;
		}
		else if(a == 36 && b == 33)
		{
			return 3;
		}
		else if(a == 36 && b == 34)
		{
			return 2;
		}
		else if(a == 36 && b == 35)
		{
			return 1;
		}
		else if(a == 36 && b == 36)
		{
			return 0;
		}
		else if(a == 36 && b == 37)
		{
			return -1;
		}
		else if(a == 36 && b == 38)
		{
			return -2;
		}
		else if(a == 36 && b == 39)
		{
			return -3;
		}
		else if(a == 36 && b == 40)
		{
			return -4;
		}
		else if(a == 36 && b == 41)
		{
			return -5;
		}
		else if(a == 36 && b == 42)
		{
			return -6;
		}
		else if(a == 36 && b == 43)
		{
			return -7;
		}
		else if(a == 36 && b == 44)
		{
			return -8;
		}
		else if(a == 36 && b == 45)
		{
			return -9;
		}
		else if(a == 36 && b == 46)
		{
			return -10;
		}
		else if(a == 36 && b == 47)
		{
			return -11;
		}
		else if(a == 36 && b == 48)
		{
			return -12;
		}
		else if(a == 36 && b == 49)
		{
			return -13;
		}
		else if(a == 36 && b == 50)
		{
			return -14;
		}
		else if(a == 36 && b == 51)
		{
			return -15;
		}
		else if(a == 36 && b == 52)
		{
			return -16;
		}
		else if(a == 36 && b == 53)
		{
			return -17;
		}
		else if(a == 36 && b == 54)
		{
			return -18;
		}
		else if(a == 36 && b == 55)
		{
			return -19;
		}
		else if(a == 36 && b == 56)
		{
			return -20;
		}
		else if(a == 36 && b == 57)
		{
			return -21;
		}
		else if(a == 36 && b == 58)
		{
			return -22;
		}
		else if(a == 36 && b == 59)
		{
			return -23;
		}
		else if(a == 36 && b == 60)
		{
			return -24;
		}
		else if(a == 36 && b == 61)
		{
			return -25;
		}
		else if(a == 36 && b == 62)
		{
			return -26;
		}
		else if(a == 36 && b == 63)
		{
			return -27;
		}
		else if(a == 36 && b == 64)
		{
			return -28;
		}
		else if(a == 36 && b == 65)
		{
			return -29;
		}
		else if(a == 36 && b == 66)
		{
			return -30;
		}
		else if(a == 36 && b == 67)
		{
			return -31;
		}
		else if(a == 36 && b == 68)
		{
			return -32;
		}
		else if(a == 36 && b == 69)
		{
			return -33;
		}
		else if(a == 36 && b == 70)
		{
			return -34;
		}
		else if(a == 36 && b == 71)
		{
			return -35;
		}
		else if(a == 36 && b == 72)
		{
			return -36;
		}
		else if(a == 36 && b == 73)
		{
			return -37;
		}
		else if(a == 36 && b == 74)
		{
			return -38;
		}
		else if(a == 36 && b == 75)
		{
			return -39;
		}
		else if(a == 36 && b == 76)
		{
			return -40;
		}
		else if(a == 36 && b == 77)
		{
			return -41;
		}
		else if(a == 36 && b == 78)
		{
			return -42;
		}
		else if(a == 36 && b == 79)
		{
			return -43;
		}
		else if(a == 36 && b == 80)
		{
			return -44;
		}
		else if(a == 36 && b == 81)
		{
			return -45;
		}
		else if(a == 36 && b == 82)
		{
			return -46;
		}
		else if(a == 36 && b == 83)
		{
			return -47;
		}
		else if(a == 36 && b == 84)
		{
			return -48;
		}
		else if(a == 36 && b == 85)
		{
			return -49;
		}
		else if(a == 36 && b == 86)
		{
			return -50;
		}
		else if(a == 36 && b == 87)
		{
			return -51;
		}
		else if(a == 36 && b == 88)
		{
			return -52;
		}
		else if(a == 36 && b == 89)
		{
			return -53;
		}
		else if(a == 36 && b == 90)
		{
			return -54;
		}
		else if(a == 36 && b == 91)
		{
			return -55;
		}
		else if(a == 36 && b == 92)
		{
			return -56;
		}
		else if(a == 36 && b == 93)
		{
			return -57;
		}
		else if(a == 36 && b == 94)
		{
			return -58;
		}
		else if(a == 36 && b == 95)
		{
			return -59;
		}
		else if(a == 36 && b == 96)
		{
			return -60;
		}
		else if(a == 36 && b == 97)
		{
			return -61;
		}
		else if(a == 36 && b == 98)
		{
			return -62;
		}
		else if(a == 36 && b == 99)
		{
			return -63;
		}
		else if(a == 36 && b == 100)
		{
			return -64;
		}
		else if(a == 37 && b == 0)
		{
			return 37;
		}
		else if(a == 37 && b == 1)
		{
			return 36;
		}
		else if(a == 37 && b == 2)
		{
			return 35;
		}
		else if(a == 37 && b == 3)
		{
			return 34;
		}
		else if(a == 37 && b == 4)
		{
			return 33;
		}
		else if(a == 37 && b == 5)
		{
			return 32;
		}
		else if(a == 37 && b == 6)
		{
			return 31;
		}
		else if(a == 37 && b == 7)
		{
			return 30;
		}
		else if(a == 37 && b == 8)
		{
			return 29;
		}
		else if(a == 37 && b == 9)
		{
			return 28;
		}
		else if(a == 37 && b == 10)
		{
			return 27;
		}
		else if(a == 37 && b == 11)
		{
			return 26;
		}
		else if(a == 37 && b == 12)
		{
			return 25;
		}
		else if(a == 37 && b == 13)
		{
			return 24;
		}
		else if(a == 37 && b == 14)
		{
			return 23;
		}
		else if(a == 37 && b == 15)
		{
			return 22;
		}
		else if(a == 37 && b == 16)
		{
			return 21;
		}
		else if(a == 37 && b == 17)
		{
			return 20;
		}
		else if(a == 37 && b == 18)
		{
			return 19;
		}
		else if(a == 37 && b == 19)
		{
			return 18;
		}
		else if(a == 37 && b == 20)
		{
			return 17;
		}
		else if(a == 37 && b == 21)
		{
			return 16;
		}
		else if(a == 37 && b == 22)
		{
			return 15;
		}
		else if(a == 37 && b == 23)
		{
			return 14;
		}
		else if(a == 37 && b == 24)
		{
			return 13;
		}
		else if(a == 37 && b == 25)
		{
			return 12;
		}
		else if(a == 37 && b == 26)
		{
			return 11;
		}
		else if(a == 37 && b == 27)
		{
			return 10;
		}
		else if(a == 37 && b == 28)
		{
			return 9;
		}
		else if(a == 37 && b == 29)
		{
			return 8;
		}
		else if(a == 37 && b == 30)
		{
			return 7;
		}
		else if(a == 37 && b == 31)
		{
			return 6;
		}
		else if(a == 37 && b == 32)
		{
			return 5;
		}
		else if(a == 37 && b == 33)
		{
			return 4;
		}
		else if(a == 37 && b == 34)
		{
			return 3;
		}
		else if(a == 37 && b == 35)
		{
			return 2;
		}
		else if(a == 37 && b == 36)
		{
			return 1;
		}
		else if(a == 37 && b == 37)
		{
			return 0;
		}
		else if(a == 37 && b == 38)
		{
			return -1;
		}
		else if(a == 37 && b == 39)
		{
			return -2;
		}
		else if(a == 37 && b == 40)
		{
			return -3;
		}
		else if(a == 37 && b == 41)
		{
			return -4;
		}
		else if(a == 37 && b == 42)
		{
			return -5;
		}
		else if(a == 37 && b == 43)
		{
			return -6;
		}
		else if(a == 37 && b == 44)
		{
			return -7;
		}
		else if(a == 37 && b == 45)
		{
			return -8;
		}
		else if(a == 37 && b == 46)
		{
			return -9;
		}
		else if(a == 37 && b == 47)
		{
			return -10;
		}
		else if(a == 37 && b == 48)
		{
			return -11;
		}
		else if(a == 37 && b == 49)
		{
			return -12;
		}
		else if(a == 37 && b == 50)
		{
			return -13;
		}
		else if(a == 37 && b == 51)
		{
			return -14;
		}
		else if(a == 37 && b == 52)
		{
			return -15;
		}
		else if(a == 37 && b == 53)
		{
			return -16;
		}
		else if(a == 37 && b == 54)
		{
			return -17;
		}
		else if(a == 37 && b == 55)
		{
			return -18;
		}
		else if(a == 37 && b == 56)
		{
			return -19;
		}
		else if(a == 37 && b == 57)
		{
			return -20;
		}
		else if(a == 37 && b == 58)
		{
			return -21;
		}
		else if(a == 37 && b == 59)
		{
			return -22;
		}
		else if(a == 37 && b == 60)
		{
			return -23;
		}
		else if(a == 37 && b == 61)
		{
			return -24;
		}
		else if(a == 37 && b == 62)
		{
			return -25;
		}
		else if(a == 37 && b == 63)
		{
			return -26;
		}
		else if(a == 37 && b == 64)
		{
			return -27;
		}
		else if(a == 37 && b == 65)
		{
			return -28;
		}
		else if(a == 37 && b == 66)
		{
			return -29;
		}
		else if(a == 37 && b == 67)
		{
			return -30;
		}
		else if(a == 37 && b == 68)
		{
			return -31;
		}
		else if(a == 37 && b == 69)
		{
			return -32;
		}
		else if(a == 37 && b == 70)
		{
			return -33;
		}
		else if(a == 37 && b == 71)
		{
			return -34;
		}
		else if(a == 37 && b == 72)
		{
			return -35;
		}
		else if(a == 37 && b == 73)
		{
			return -36;
		}
		else if(a == 37 && b == 74)
		{
			return -37;
		}
		else if(a == 37 && b == 75)
		{
			return -38;
		}
		else if(a == 37 && b == 76)
		{
			return -39;
		}
		else if(a == 37 && b == 77)
		{
			return -40;
		}
		else if(a == 37 && b == 78)
		{
			return -41;
		}
		else if(a == 37 && b == 79)
		{
			return -42;
		}
		else if(a == 37 && b == 80)
		{
			return -43;
		}
		else if(a == 37 && b == 81)
		{
			return -44;
		}
		else if(a == 37 && b == 82)
		{
			return -45;
		}
		else if(a == 37 && b == 83)
		{
			return -46;
		}
		else if(a == 37 && b == 84)
		{
			return -47;
		}
		else if(a == 37 && b == 85)
		{
			return -48;
		}
		else if(a == 37 && b == 86)
		{
			return -49;
		}
		else if(a == 37 && b == 87)
		{
			return -50;
		}
		else if(a == 37 && b == 88)
		{
			return -51;
		}
		else if(a == 37 && b == 89)
		{
			return -52;
		}
		else if(a == 37 && b == 90)
		{
			return -53;
		}
		else if(a == 37 && b == 91)
		{
			return -54;
		}
		else if(a == 37 && b == 92)
		{
			return -55;
		}
		else if(a == 37 && b == 93)
		{
			return -56;
		}
		else if(a == 37 && b == 94)
		{
			return -57;
		}
		else if(a == 37 && b == 95)
		{
			return -58;
		}
		else if(a == 37 && b == 96)
		{
			return -59;
		}
		else if(a == 37 && b == 97)
		{
			return -60;
		}
		else if(a == 37 && b == 98)
		{
			return -61;
		}
		else if(a == 37 && b == 99)
		{
			return -62;
		}
		else if(a == 37 && b == 100)
		{
			return -63;
		}
		else if(a == 38 && b == 0)
		{
			return 38;
		}
		else if(a == 38 && b == 1)
		{
			return 37;
		}
		else if(a == 38 && b == 2)
		{
			return 36;
		}
		else if(a == 38 && b == 3)
		{
			return 35;
		}
		else if(a == 38 && b == 4)
		{
			return 34;
		}
		else if(a == 38 && b == 5)
		{
			return 33;
		}
		else if(a == 38 && b == 6)
		{
			return 32;
		}
		else if(a == 38 && b == 7)
		{
			return 31;
		}
		else if(a == 38 && b == 8)
		{
			return 30;
		}
		else if(a == 38 && b == 9)
		{
			return 29;
		}
		else if(a == 38 && b == 10)
		{
			return 28;
		}
		else if(a == 38 && b == 11)
		{
			return 27;
		}
		else if(a == 38 && b == 12)
		{
			return 26;
		}
		else if(a == 38 && b == 13)
		{
			return 25;
		}
		else if(a == 38 && b == 14)
		{
			return 24;
		}
		else if(a == 38 && b == 15)
		{
			return 23;
		}
		else if(a == 38 && b == 16)
		{
			return 22;
		}
		else if(a == 38 && b == 17)
		{
			return 21;
		}
		else if(a == 38 && b == 18)
		{
			return 20;
		}
		else if(a == 38 && b == 19)
		{
			return 19;
		}
		else if(a == 38 && b == 20)
		{
			return 18;
		}
		else if(a == 38 && b == 21)
		{
			return 17;
		}
		else if(a == 38 && b == 22)
		{
			return 16;
		}
		else if(a == 38 && b == 23)
		{
			return 15;
		}
		else if(a == 38 && b == 24)
		{
			return 14;
		}
		else if(a == 38 && b == 25)
		{
			return 13;
		}
		else if(a == 38 && b == 26)
		{
			return 12;
		}
		else if(a == 38 && b == 27)
		{
			return 11;
		}
		else if(a == 38 && b == 28)
		{
			return 10;
		}
		else if(a == 38 && b == 29)
		{
			return 9;
		}
		else if(a == 38 && b == 30)
		{
			return 8;
		}
		else if(a == 38 && b == 31)
		{
			return 7;
		}
		else if(a == 38 && b == 32)
		{
			return 6;
		}
		else if(a == 38 && b == 33)
		{
			return 5;
		}
		else if(a == 38 && b == 34)
		{
			return 4;
		}
		else if(a == 38 && b == 35)
		{
			return 3;
		}
		else if(a == 38 && b == 36)
		{
			return 2;
		}
		else if(a == 38 && b == 37)
		{
			return 1;
		}
		else if(a == 38 && b == 38)
		{
			return 0;
		}
		else if(a == 38 && b == 39)
		{
			return -1;
		}
		else if(a == 38 && b == 40)
		{
			return -2;
		}
		else if(a == 38 && b == 41)
		{
			return -3;
		}
		else if(a == 38 && b == 42)
		{
			return -4;
		}
		else if(a == 38 && b == 43)
		{
			return -5;
		}
		else if(a == 38 && b == 44)
		{
			return -6;
		}
		else if(a == 38 && b == 45)
		{
			return -7;
		}
		else if(a == 38 && b == 46)
		{
			return -8;
		}
		else if(a == 38 && b == 47)
		{
			return -9;
		}
		else if(a == 38 && b == 48)
		{
			return -10;
		}
		else if(a == 38 && b == 49)
		{
			return -11;
		}
		else if(a == 38 && b == 50)
		{
			return -12;
		}
		else if(a == 38 && b == 51)
		{
			return -13;
		}
		else if(a == 38 && b == 52)
		{
			return -14;
		}
		else if(a == 38 && b == 53)
		{
			return -15;
		}
		else if(a == 38 && b == 54)
		{
			return -16;
		}
		else if(a == 38 && b == 55)
		{
			return -17;
		}
		else if(a == 38 && b == 56)
		{
			return -18;
		}
		else if(a == 38 && b == 57)
		{
			return -19;
		}
		else if(a == 38 && b == 58)
		{
			return -20;
		}
		else if(a == 38 && b == 59)
		{
			return -21;
		}
		else if(a == 38 && b == 60)
		{
			return -22;
		}
		else if(a == 38 && b == 61)
		{
			return -23;
		}
		else if(a == 38 && b == 62)
		{
			return -24;
		}
		else if(a == 38 && b == 63)
		{
			return -25;
		}
		else if(a == 38 && b == 64)
		{
			return -26;
		}
		else if(a == 38 && b == 65)
		{
			return -27;
		}
		else if(a == 38 && b == 66)
		{
			return -28;
		}
		else if(a == 38 && b == 67)
		{
			return -29;
		}
		else if(a == 38 && b == 68)
		{
			return -30;
		}
		else if(a == 38 && b == 69)
		{
			return -31;
		}
		else if(a == 38 && b == 70)
		{
			return -32;
		}
		else if(a == 38 && b == 71)
		{
			return -33;
		}
		else if(a == 38 && b == 72)
		{
			return -34;
		}
		else if(a == 38 && b == 73)
		{
			return -35;
		}
		else if(a == 38 && b == 74)
		{
			return -36;
		}
		else if(a == 38 && b == 75)
		{
			return -37;
		}
		else if(a == 38 && b == 76)
		{
			return -38;
		}
		else if(a == 38 && b == 77)
		{
			return -39;
		}
		else if(a == 38 && b == 78)
		{
			return -40;
		}
		else if(a == 38 && b == 79)
		{
			return -41;
		}
		else if(a == 38 && b == 80)
		{
			return -42;
		}
		else if(a == 38 && b == 81)
		{
			return -43;
		}
		else if(a == 38 && b == 82)
		{
			return -44;
		}
		else if(a == 38 && b == 83)
		{
			return -45;
		}
		else if(a == 38 && b == 84)
		{
			return -46;
		}
		else if(a == 38 && b == 85)
		{
			return -47;
		}
		else if(a == 38 && b == 86)
		{
			return -48;
		}
		else if(a == 38 && b == 87)
		{
			return -49;
		}
		else if(a == 38 && b == 88)
		{
			return -50;
		}
		else if(a == 38 && b == 89)
		{
			return -51;
		}
		else if(a == 38 && b == 90)
		{
			return -52;
		}
		else if(a == 38 && b == 91)
		{
			return -53;
		}
		else if(a == 38 && b == 92)
		{
			return -54;
		}
		else if(a == 38 && b == 93)
		{
			return -55;
		}
		else if(a == 38 && b == 94)
		{
			return -56;
		}
		else if(a == 38 && b == 95)
		{
			return -57;
		}
		else if(a == 38 && b == 96)
		{
			return -58;
		}
		else if(a == 38 && b == 97)
		{
			return -59;
		}
		else if(a == 38 && b == 98)
		{
			return -60;
		}
		else if(a == 38 && b == 99)
		{
			return -61;
		}
		else if(a == 38 && b == 100)
		{
			return -62;
		}
		else if(a == 39 && b == 0)
		{
			return 39;
		}
		else if(a == 39 && b == 1)
		{
			return 38;
		}
		else if(a == 39 && b == 2)
		{
			return 37;
		}
		else if(a == 39 && b == 3)
		{
			return 36;
		}
		else if(a == 39 && b == 4)
		{
			return 35;
		}
		else if(a == 39 && b == 5)
		{
			return 34;
		}
		else if(a == 39 && b == 6)
		{
			return 33;
		}
		else if(a == 39 && b == 7)
		{
			return 32;
		}
		else if(a == 39 && b == 8)
		{
			return 31;
		}
		else if(a == 39 && b == 9)
		{
			return 30;
		}
		else if(a == 39 && b == 10)
		{
			return 29;
		}
		else if(a == 39 && b == 11)
		{
			return 28;
		}
		else if(a == 39 && b == 12)
		{
			return 27;
		}
		else if(a == 39 && b == 13)
		{
			return 26;
		}
		else if(a == 39 && b == 14)
		{
			return 25;
		}
		else if(a == 39 && b == 15)
		{
			return 24;
		}
		else if(a == 39 && b == 16)
		{
			return 23;
		}
		else if(a == 39 && b == 17)
		{
			return 22;
		}
		else if(a == 39 && b == 18)
		{
			return 21;
		}
		else if(a == 39 && b == 19)
		{
			return 20;
		}
		else if(a == 39 && b == 20)
		{
			return 19;
		}
		else if(a == 39 && b == 21)
		{
			return 18;
		}
		else if(a == 39 && b == 22)
		{
			return 17;
		}
		else if(a == 39 && b == 23)
		{
			return 16;
		}
		else if(a == 39 && b == 24)
		{
			return 15;
		}
		else if(a == 39 && b == 25)
		{
			return 14;
		}
		else if(a == 39 && b == 26)
		{
			return 13;
		}
		else if(a == 39 && b == 27)
		{
			return 12;
		}
		else if(a == 39 && b == 28)
		{
			return 11;
		}
		else if(a == 39 && b == 29)
		{
			return 10;
		}
		else if(a == 39 && b == 30)
		{
			return 9;
		}
		else if(a == 39 && b == 31)
		{
			return 8;
		}
		else if(a == 39 && b == 32)
		{
			return 7;
		}
		else if(a == 39 && b == 33)
		{
			return 6;
		}
		else if(a == 39 && b == 34)
		{
			return 5;
		}
		else if(a == 39 && b == 35)
		{
			return 4;
		}
		else if(a == 39 && b == 36)
		{
			return 3;
		}
		else if(a == 39 && b == 37)
		{
			return 2;
		}
		else if(a == 39 && b == 38)
		{
			return 1;
		}
		else if(a == 39 && b == 39)
		{
			return 0;
		}
		else if(a == 39 && b == 40)
		{
			return -1;
		}
		else if(a == 39 && b == 41)
		{
			return -2;
		}
		else if(a == 39 && b == 42)
		{
			return -3;
		}
		else if(a == 39 && b == 43)
		{
			return -4;
		}
		else if(a == 39 && b == 44)
		{
			return -5;
		}
		else if(a == 39 && b == 45)
		{
			return -6;
		}
		else if(a == 39 && b == 46)
		{
			return -7;
		}
		else if(a == 39 && b == 47)
		{
			return -8;
		}
		else if(a == 39 && b == 48)
		{
			return -9;
		}
		else if(a == 39 && b == 49)
		{
			return -10;
		}
		else if(a == 39 && b == 50)
		{
			return -11;
		}
		else if(a == 39 && b == 51)
		{
			return -12;
		}
		else if(a == 39 && b == 52)
		{
			return -13;
		}
		else if(a == 39 && b == 53)
		{
			return -14;
		}
		else if(a == 39 && b == 54)
		{
			return -15;
		}
		else if(a == 39 && b == 55)
		{
			return -16;
		}
		else if(a == 39 && b == 56)
		{
			return -17;
		}
		else if(a == 39 && b == 57)
		{
			return -18;
		}
		else if(a == 39 && b == 58)
		{
			return -19;
		}
		else if(a == 39 && b == 59)
		{
			return -20;
		}
		else if(a == 39 && b == 60)
		{
			return -21;
		}
		else if(a == 39 && b == 61)
		{
			return -22;
		}
		else if(a == 39 && b == 62)
		{
			return -23;
		}
		else if(a == 39 && b == 63)
		{
			return -24;
		}
		else if(a == 39 && b == 64)
		{
			return -25;
		}
		else if(a == 39 && b == 65)
		{
			return -26;
		}
		else if(a == 39 && b == 66)
		{
			return -27;
		}
		else if(a == 39 && b == 67)
		{
			return -28;
		}
		else if(a == 39 && b == 68)
		{
			return -29;
		}
		else if(a == 39 && b == 69)
		{
			return -30;
		}
		else if(a == 39 && b == 70)
		{
			return -31;
		}
		else if(a == 39 && b == 71)
		{
			return -32;
		}
		else if(a == 39 && b == 72)
		{
			return -33;
		}
		else if(a == 39 && b == 73)
		{
			return -34;
		}
		else if(a == 39 && b == 74)
		{
			return -35;
		}
		else if(a == 39 && b == 75)
		{
			return -36;
		}
		else if(a == 39 && b == 76)
		{
			return -37;
		}
		else if(a == 39 && b == 77)
		{
			return -38;
		}
		else if(a == 39 && b == 78)
		{
			return -39;
		}
		else if(a == 39 && b == 79)
		{
			return -40;
		}
		else if(a == 39 && b == 80)
		{
			return -41;
		}
		else if(a == 39 && b == 81)
		{
			return -42;
		}
		else if(a == 39 && b == 82)
		{
			return -43;
		}
		else if(a == 39 && b == 83)
		{
			return -44;
		}
		else if(a == 39 && b == 84)
		{
			return -45;
		}
		else if(a == 39 && b == 85)
		{
			return -46;
		}
		else if(a == 39 && b == 86)
		{
			return -47;
		}
		else if(a == 39 && b == 87)
		{
			return -48;
		}
		else if(a == 39 && b == 88)
		{
			return -49;
		}
		else if(a == 39 && b == 89)
		{
			return -50;
		}
		else if(a == 39 && b == 90)
		{
			return -51;
		}
		else if(a == 39 && b == 91)
		{
			return -52;
		}
		else if(a == 39 && b == 92)
		{
			return -53;
		}
		else if(a == 39 && b == 93)
		{
			return -54;
		}
		else if(a == 39 && b == 94)
		{
			return -55;
		}
		else if(a == 39 && b == 95)
		{
			return -56;
		}
		else if(a == 39 && b == 96)
		{
			return -57;
		}
		else if(a == 39 && b == 97)
		{
			return -58;
		}
		else if(a == 39 && b == 98)
		{
			return -59;
		}
		else if(a == 39 && b == 99)
		{
			return -60;
		}
		else if(a == 39 && b == 100)
		{
			return -61;
		}
		else if(a == 40 && b == 0)
		{
			return 40;
		}
		else if(a == 40 && b == 1)
		{
			return 39;
		}
		else if(a == 40 && b == 2)
		{
			return 38;
		}
		else if(a == 40 && b == 3)
		{
			return 37;
		}
		else if(a == 40 && b == 4)
		{
			return 36;
		}
		else if(a == 40 && b == 5)
		{
			return 35;
		}
		else if(a == 40 && b == 6)
		{
			return 34;
		}
		else if(a == 40 && b == 7)
		{
			return 33;
		}
		else if(a == 40 && b == 8)
		{
			return 32;
		}
		else if(a == 40 && b == 9)
		{
			return 31;
		}
		else if(a == 40 && b == 10)
		{
			return 30;
		}
		else if(a == 40 && b == 11)
		{
			return 29;
		}
		else if(a == 40 && b == 12)
		{
			return 28;
		}
		else if(a == 40 && b == 13)
		{
			return 27;
		}
		else if(a == 40 && b == 14)
		{
			return 26;
		}
		else if(a == 40 && b == 15)
		{
			return 25;
		}
		else if(a == 40 && b == 16)
		{
			return 24;
		}
		else if(a == 40 && b == 17)
		{
			return 23;
		}
		else if(a == 40 && b == 18)
		{
			return 22;
		}
		else if(a == 40 && b == 19)
		{
			return 21;
		}
		else if(a == 40 && b == 20)
		{
			return 20;
		}
		else if(a == 40 && b == 21)
		{
			return 19;
		}
		else if(a == 40 && b == 22)
		{
			return 18;
		}
		else if(a == 40 && b == 23)
		{
			return 17;
		}
		else if(a == 40 && b == 24)
		{
			return 16;
		}
		else if(a == 40 && b == 25)
		{
			return 15;
		}
		else if(a == 40 && b == 26)
		{
			return 14;
		}
		else if(a == 40 && b == 27)
		{
			return 13;
		}
		else if(a == 40 && b == 28)
		{
			return 12;
		}
		else if(a == 40 && b == 29)
		{
			return 11;
		}
		else if(a == 40 && b == 30)
		{
			return 10;
		}
		else if(a == 40 && b == 31)
		{
			return 9;
		}
		else if(a == 40 && b == 32)
		{
			return 8;
		}
		else if(a == 40 && b == 33)
		{
			return 7;
		}
		else if(a == 40 && b == 34)
		{
			return 6;
		}
		else if(a == 40 && b == 35)
		{
			return 5;
		}
		else if(a == 40 && b == 36)
		{
			return 4;
		}
		else if(a == 40 && b == 37)
		{
			return 3;
		}
		else if(a == 40 && b == 38)
		{
			return 2;
		}
		else if(a == 40 && b == 39)
		{
			return 1;
		}
		else if(a == 40 && b == 40)
		{
			return 0;
		}
		else if(a == 40 && b == 41)
		{
			return -1;
		}
		else if(a == 40 && b == 42)
		{
			return -2;
		}
		else if(a == 40 && b == 43)
		{
			return -3;
		}
		else if(a == 40 && b == 44)
		{
			return -4;
		}
		else if(a == 40 && b == 45)
		{
			return -5;
		}
		else if(a == 40 && b == 46)
		{
			return -6;
		}
		else if(a == 40 && b == 47)
		{
			return -7;
		}
		else if(a == 40 && b == 48)
		{
			return -8;
		}
		else if(a == 40 && b == 49)
		{
			return -9;
		}
		else if(a == 40 && b == 50)
		{
			return -10;
		}
		else if(a == 40 && b == 51)
		{
			return -11;
		}
		else if(a == 40 && b == 52)
		{
			return -12;
		}
		else if(a == 40 && b == 53)
		{
			return -13;
		}
		else if(a == 40 && b == 54)
		{
			return -14;
		}
		else if(a == 40 && b == 55)
		{
			return -15;
		}
		else if(a == 40 && b == 56)
		{
			return -16;
		}
		else if(a == 40 && b == 57)
		{
			return -17;
		}
		else if(a == 40 && b == 58)
		{
			return -18;
		}
		else if(a == 40 && b == 59)
		{
			return -19;
		}
		else if(a == 40 && b == 60)
		{
			return -20;
		}
		else if(a == 40 && b == 61)
		{
			return -21;
		}
		else if(a == 40 && b == 62)
		{
			return -22;
		}
		else if(a == 40 && b == 63)
		{
			return -23;
		}
		else if(a == 40 && b == 64)
		{
			return -24;
		}
		else if(a == 40 && b == 65)
		{
			return -25;
		}
		else if(a == 40 && b == 66)
		{
			return -26;
		}
		else if(a == 40 && b == 67)
		{
			return -27;
		}
		else if(a == 40 && b == 68)
		{
			return -28;
		}
		else if(a == 40 && b == 69)
		{
			return -29;
		}
		else if(a == 40 && b == 70)
		{
			return -30;
		}
		else if(a == 40 && b == 71)
		{
			return -31;
		}
		else if(a == 40 && b == 72)
		{
			return -32;
		}
		else if(a == 40 && b == 73)
		{
			return -33;
		}
		else if(a == 40 && b == 74)
		{
			return -34;
		}
		else if(a == 40 && b == 75)
		{
			return -35;
		}
		else if(a == 40 && b == 76)
		{
			return -36;
		}
		else if(a == 40 && b == 77)
		{
			return -37;
		}
		else if(a == 40 && b == 78)
		{
			return -38;
		}
		else if(a == 40 && b == 79)
		{
			return -39;
		}
		else if(a == 40 && b == 80)
		{
			return -40;
		}
		else if(a == 40 && b == 81)
		{
			return -41;
		}
		else if(a == 40 && b == 82)
		{
			return -42;
		}
		else if(a == 40 && b == 83)
		{
			return -43;
		}
		else if(a == 40 && b == 84)
		{
			return -44;
		}
		else if(a == 40 && b == 85)
		{
			return -45;
		}
		else if(a == 40 && b == 86)
		{
			return -46;
		}
		else if(a == 40 && b == 87)
		{
			return -47;
		}
		else if(a == 40 && b == 88)
		{
			return -48;
		}
		else if(a == 40 && b == 89)
		{
			return -49;
		}
		else if(a == 40 && b == 90)
		{
			return -50;
		}
		else if(a == 40 && b == 91)
		{
			return -51;
		}
		else if(a == 40 && b == 92)
		{
			return -52;
		}
		else if(a == 40 && b == 93)
		{
			return -53;
		}
		else if(a == 40 && b == 94)
		{
			return -54;
		}
		else if(a == 40 && b == 95)
		{
			return -55;
		}
		else if(a == 40 && b == 96)
		{
			return -56;
		}
		else if(a == 40 && b == 97)
		{
			return -57;
		}
		else if(a == 40 && b == 98)
		{
			return -58;
		}
		else if(a == 40 && b == 99)
		{
			return -59;
		}
		else if(a == 40 && b == 100)
		{
			return -60;
		}
		else if(a == 41 && b == 0)
		{
			return 41;
		}
		else if(a == 41 && b == 1)
		{
			return 40;
		}
		else if(a == 41 && b == 2)
		{
			return 39;
		}
		else if(a == 41 && b == 3)
		{
			return 38;
		}
		else if(a == 41 && b == 4)
		{
			return 37;
		}
		else if(a == 41 && b == 5)
		{
			return 36;
		}
		else if(a == 41 && b == 6)
		{
			return 35;
		}
		else if(a == 41 && b == 7)
		{
			return 34;
		}
		else if(a == 41 && b == 8)
		{
			return 33;
		}
		else if(a == 41 && b == 9)
		{
			return 32;
		}
		else if(a == 41 && b == 10)
		{
			return 31;
		}
		else if(a == 41 && b == 11)
		{
			return 30;
		}
		else if(a == 41 && b == 12)
		{
			return 29;
		}
		else if(a == 41 && b == 13)
		{
			return 28;
		}
		else if(a == 41 && b == 14)
		{
			return 27;
		}
		else if(a == 41 && b == 15)
		{
			return 26;
		}
		else if(a == 41 && b == 16)
		{
			return 25;
		}
		else if(a == 41 && b == 17)
		{
			return 24;
		}
		else if(a == 41 && b == 18)
		{
			return 23;
		}
		else if(a == 41 && b == 19)
		{
			return 22;
		}
		else if(a == 41 && b == 20)
		{
			return 21;
		}
		else if(a == 41 && b == 21)
		{
			return 20;
		}
		else if(a == 41 && b == 22)
		{
			return 19;
		}
		else if(a == 41 && b == 23)
		{
			return 18;
		}
		else if(a == 41 && b == 24)
		{
			return 17;
		}
		else if(a == 41 && b == 25)
		{
			return 16;
		}
		else if(a == 41 && b == 26)
		{
			return 15;
		}
		else if(a == 41 && b == 27)
		{
			return 14;
		}
		else if(a == 41 && b == 28)
		{
			return 13;
		}
		else if(a == 41 && b == 29)
		{
			return 12;
		}
		else if(a == 41 && b == 30)
		{
			return 11;
		}
		else if(a == 41 && b == 31)
		{
			return 10;
		}
		else if(a == 41 && b == 32)
		{
			return 9;
		}
		else if(a == 41 && b == 33)
		{
			return 8;
		}
		else if(a == 41 && b == 34)
		{
			return 7;
		}
		else if(a == 41 && b == 35)
		{
			return 6;
		}
		else if(a == 41 && b == 36)
		{
			return 5;
		}
		else if(a == 41 && b == 37)
		{
			return 4;
		}
		else if(a == 41 && b == 38)
		{
			return 3;
		}
		else if(a == 41 && b == 39)
		{
			return 2;
		}
		else if(a == 41 && b == 40)
		{
			return 1;
		}
		else if(a == 41 && b == 41)
		{
			return 0;
		}
		else if(a == 41 && b == 42)
		{
			return -1;
		}
		else if(a == 41 && b == 43)
		{
			return -2;
		}
		else if(a == 41 && b == 44)
		{
			return -3;
		}
		else if(a == 41 && b == 45)
		{
			return -4;
		}
		else if(a == 41 && b == 46)
		{
			return -5;
		}
		else if(a == 41 && b == 47)
		{
			return -6;
		}
		else if(a == 41 && b == 48)
		{
			return -7;
		}
		else if(a == 41 && b == 49)
		{
			return -8;
		}
		else if(a == 41 && b == 50)
		{
			return -9;
		}
		else if(a == 41 && b == 51)
		{
			return -10;
		}
		else if(a == 41 && b == 52)
		{
			return -11;
		}
		else if(a == 41 && b == 53)
		{
			return -12;
		}
		else if(a == 41 && b == 54)
		{
			return -13;
		}
		else if(a == 41 && b == 55)
		{
			return -14;
		}
		else if(a == 41 && b == 56)
		{
			return -15;
		}
		else if(a == 41 && b == 57)
		{
			return -16;
		}
		else if(a == 41 && b == 58)
		{
			return -17;
		}
		else if(a == 41 && b == 59)
		{
			return -18;
		}
		else if(a == 41 && b == 60)
		{
			return -19;
		}
		else if(a == 41 && b == 61)
		{
			return -20;
		}
		else if(a == 41 && b == 62)
		{
			return -21;
		}
		else if(a == 41 && b == 63)
		{
			return -22;
		}
		else if(a == 41 && b == 64)
		{
			return -23;
		}
		else if(a == 41 && b == 65)
		{
			return -24;
		}
		else if(a == 41 && b == 66)
		{
			return -25;
		}
		else if(a == 41 && b == 67)
		{
			return -26;
		}
		else if(a == 41 && b == 68)
		{
			return -27;
		}
		else if(a == 41 && b == 69)
		{
			return -28;
		}
		else if(a == 41 && b == 70)
		{
			return -29;
		}
		else if(a == 41 && b == 71)
		{
			return -30;
		}
		else if(a == 41 && b == 72)
		{
			return -31;
		}
		else if(a == 41 && b == 73)
		{
			return -32;
		}
		else if(a == 41 && b == 74)
		{
			return -33;
		}
		else if(a == 41 && b == 75)
		{
			return -34;
		}
		else if(a == 41 && b == 76)
		{
			return -35;
		}
		else if(a == 41 && b == 77)
		{
			return -36;
		}
		else if(a == 41 && b == 78)
		{
			return -37;
		}
		else if(a == 41 && b == 79)
		{
			return -38;
		}
		else if(a == 41 && b == 80)
		{
			return -39;
		}
		else if(a == 41 && b == 81)
		{
			return -40;
		}
		else if(a == 41 && b == 82)
		{
			return -41;
		}
		else if(a == 41 && b == 83)
		{
			return -42;
		}
		else if(a == 41 && b == 84)
		{
			return -43;
		}
		else if(a == 41 && b == 85)
		{
			return -44;
		}
		else if(a == 41 && b == 86)
		{
			return -45;
		}
		else if(a == 41 && b == 87)
		{
			return -46;
		}
		else if(a == 41 && b == 88)
		{
			return -47;
		}
		else if(a == 41 && b == 89)
		{
			return -48;
		}
		else if(a == 41 && b == 90)
		{
			return -49;
		}
		else if(a == 41 && b == 91)
		{
			return -50;
		}
		else if(a == 41 && b == 92)
		{
			return -51;
		}
		else if(a == 41 && b == 93)
		{
			return -52;
		}
		else if(a == 41 && b == 94)
		{
			return -53;
		}
		else if(a == 41 && b == 95)
		{
			return -54;
		}
		else if(a == 41 && b == 96)
		{
			return -55;
		}
		else if(a == 41 && b == 97)
		{
			return -56;
		}
		else if(a == 41 && b == 98)
		{
			return -57;
		}
		else if(a == 41 && b == 99)
		{
			return -58;
		}
		else if(a == 41 && b == 100)
		{
			return -59;
		}
		else if(a == 42 && b == 0)
		{
			return 42;
		}
		else if(a == 42 && b == 1)
		{
			return 41;
		}
		else if(a == 42 && b == 2)
		{
			return 40;
		}
		else if(a == 42 && b == 3)
		{
			return 39;
		}
		else if(a == 42 && b == 4)
		{
			return 38;
		}
		else if(a == 42 && b == 5)
		{
			return 37;
		}
		else if(a == 42 && b == 6)
		{
			return 36;
		}
		else if(a == 42 && b == 7)
		{
			return 35;
		}
		else if(a == 42 && b == 8)
		{
			return 34;
		}
		else if(a == 42 && b == 9)
		{
			return 33;
		}
		else if(a == 42 && b == 10)
		{
			return 32;
		}
		else if(a == 42 && b == 11)
		{
			return 31;
		}
		else if(a == 42 && b == 12)
		{
			return 30;
		}
		else if(a == 42 && b == 13)
		{
			return 29;
		}
		else if(a == 42 && b == 14)
		{
			return 28;
		}
		else if(a == 42 && b == 15)
		{
			return 27;
		}
		else if(a == 42 && b == 16)
		{
			return 26;
		}
		else if(a == 42 && b == 17)
		{
			return 25;
		}
		else if(a == 42 && b == 18)
		{
			return 24;
		}
		else if(a == 42 && b == 19)
		{
			return 23;
		}
		else if(a == 42 && b == 20)
		{
			return 22;
		}
		else if(a == 42 && b == 21)
		{
			return 21;
		}
		else if(a == 42 && b == 22)
		{
			return 20;
		}
		else if(a == 42 && b == 23)
		{
			return 19;
		}
		else if(a == 42 && b == 24)
		{
			return 18;
		}
		else if(a == 42 && b == 25)
		{
			return 17;
		}
		else if(a == 42 && b == 26)
		{
			return 16;
		}
		else if(a == 42 && b == 27)
		{
			return 15;
		}
		else if(a == 42 && b == 28)
		{
			return 14;
		}
		else if(a == 42 && b == 29)
		{
			return 13;
		}
		else if(a == 42 && b == 30)
		{
			return 12;
		}
		else if(a == 42 && b == 31)
		{
			return 11;
		}
		else if(a == 42 && b == 32)
		{
			return 10;
		}
		else if(a == 42 && b == 33)
		{
			return 9;
		}
		else if(a == 42 && b == 34)
		{
			return 8;
		}
		else if(a == 42 && b == 35)
		{
			return 7;
		}
		else if(a == 42 && b == 36)
		{
			return 6;
		}
		else if(a == 42 && b == 37)
		{
			return 5;
		}
		else if(a == 42 && b == 38)
		{
			return 4;
		}
		else if(a == 42 && b == 39)
		{
			return 3;
		}
		else if(a == 42 && b == 40)
		{
			return 2;
		}
		else if(a == 42 && b == 41)
		{
			return 1;
		}
		else if(a == 42 && b == 42)
		{
			return 0;
		}
		else if(a == 42 && b == 43)
		{
			return -1;
		}
		else if(a == 42 && b == 44)
		{
			return -2;
		}
		else if(a == 42 && b == 45)
		{
			return -3;
		}
		else if(a == 42 && b == 46)
		{
			return -4;
		}
		else if(a == 42 && b == 47)
		{
			return -5;
		}
		else if(a == 42 && b == 48)
		{
			return -6;
		}
		else if(a == 42 && b == 49)
		{
			return -7;
		}
		else if(a == 42 && b == 50)
		{
			return -8;
		}
		else if(a == 42 && b == 51)
		{
			return -9;
		}
		else if(a == 42 && b == 52)
		{
			return -10;
		}
		else if(a == 42 && b == 53)
		{
			return -11;
		}
		else if(a == 42 && b == 54)
		{
			return -12;
		}
		else if(a == 42 && b == 55)
		{
			return -13;
		}
		else if(a == 42 && b == 56)
		{
			return -14;
		}
		else if(a == 42 && b == 57)
		{
			return -15;
		}
		else if(a == 42 && b == 58)
		{
			return -16;
		}
		else if(a == 42 && b == 59)
		{
			return -17;
		}
		else if(a == 42 && b == 60)
		{
			return -18;
		}
		else if(a == 42 && b == 61)
		{
			return -19;
		}
		else if(a == 42 && b == 62)
		{
			return -20;
		}
		else if(a == 42 && b == 63)
		{
			return -21;
		}
		else if(a == 42 && b == 64)
		{
			return -22;
		}
		else if(a == 42 && b == 65)
		{
			return -23;
		}
		else if(a == 42 && b == 66)
		{
			return -24;
		}
		else if(a == 42 && b == 67)
		{
			return -25;
		}
		else if(a == 42 && b == 68)
		{
			return -26;
		}
		else if(a == 42 && b == 69)
		{
			return -27;
		}
		else if(a == 42 && b == 70)
		{
			return -28;
		}
		else if(a == 42 && b == 71)
		{
			return -29;
		}
		else if(a == 42 && b == 72)
		{
			return -30;
		}
		else if(a == 42 && b == 73)
		{
			return -31;
		}
		else if(a == 42 && b == 74)
		{
			return -32;
		}
		else if(a == 42 && b == 75)
		{
			return -33;
		}
		else if(a == 42 && b == 76)
		{
			return -34;
		}
		else if(a == 42 && b == 77)
		{
			return -35;
		}
		else if(a == 42 && b == 78)
		{
			return -36;
		}
		else if(a == 42 && b == 79)
		{
			return -37;
		}
		else if(a == 42 && b == 80)
		{
			return -38;
		}
		else if(a == 42 && b == 81)
		{
			return -39;
		}
		else if(a == 42 && b == 82)
		{
			return -40;
		}
		else if(a == 42 && b == 83)
		{
			return -41;
		}
		else if(a == 42 && b == 84)
		{
			return -42;
		}
		else if(a == 42 && b == 85)
		{
			return -43;
		}
		else if(a == 42 && b == 86)
		{
			return -44;
		}
		else if(a == 42 && b == 87)
		{
			return -45;
		}
		else if(a == 42 && b == 88)
		{
			return -46;
		}
		else if(a == 42 && b == 89)
		{
			return -47;
		}
		else if(a == 42 && b == 90)
		{
			return -48;
		}
		else if(a == 42 && b == 91)
		{
			return -49;
		}
		else if(a == 42 && b == 92)
		{
			return -50;
		}
		else if(a == 42 && b == 93)
		{
			return -51;
		}
		else if(a == 42 && b == 94)
		{
			return -52;
		}
		else if(a == 42 && b == 95)
		{
			return -53;
		}
		else if(a == 42 && b == 96)
		{
			return -54;
		}
		else if(a == 42 && b == 97)
		{
			return -55;
		}
		else if(a == 42 && b == 98)
		{
			return -56;
		}
		else if(a == 42 && b == 99)
		{
			return -57;
		}
		else if(a == 42 && b == 100)
		{
			return -58;
		}
		else if(a == 43 && b == 0)
		{
			return 43;
		}
		else if(a == 43 && b == 1)
		{
			return 42;
		}
		else if(a == 43 && b == 2)
		{
			return 41;
		}
		else if(a == 43 && b == 3)
		{
			return 40;
		}
		else if(a == 43 && b == 4)
		{
			return 39;
		}
		else if(a == 43 && b == 5)
		{
			return 38;
		}
		else if(a == 43 && b == 6)
		{
			return 37;
		}
		else if(a == 43 && b == 7)
		{
			return 36;
		}
		else if(a == 43 && b == 8)
		{
			return 35;
		}
		else if(a == 43 && b == 9)
		{
			return 34;
		}
		else if(a == 43 && b == 10)
		{
			return 33;
		}
		else if(a == 43 && b == 11)
		{
			return 32;
		}
		else if(a == 43 && b == 12)
		{
			return 31;
		}
		else if(a == 43 && b == 13)
		{
			return 30;
		}
		else if(a == 43 && b == 14)
		{
			return 29;
		}
		else if(a == 43 && b == 15)
		{
			return 28;
		}
		else if(a == 43 && b == 16)
		{
			return 27;
		}
		else if(a == 43 && b == 17)
		{
			return 26;
		}
		else if(a == 43 && b == 18)
		{
			return 25;
		}
		else if(a == 43 && b == 19)
		{
			return 24;
		}
		else if(a == 43 && b == 20)
		{
			return 23;
		}
		else if(a == 43 && b == 21)
		{
			return 22;
		}
		else if(a == 43 && b == 22)
		{
			return 21;
		}
		else if(a == 43 && b == 23)
		{
			return 20;
		}
		else if(a == 43 && b == 24)
		{
			return 19;
		}
		else if(a == 43 && b == 25)
		{
			return 18;
		}
		else if(a == 43 && b == 26)
		{
			return 17;
		}
		else if(a == 43 && b == 27)
		{
			return 16;
		}
		else if(a == 43 && b == 28)
		{
			return 15;
		}
		else if(a == 43 && b == 29)
		{
			return 14;
		}
		else if(a == 43 && b == 30)
		{
			return 13;
		}
		else if(a == 43 && b == 31)
		{
			return 12;
		}
		else if(a == 43 && b == 32)
		{
			return 11;
		}
		else if(a == 43 && b == 33)
		{
			return 10;
		}
		else if(a == 43 && b == 34)
		{
			return 9;
		}
		else if(a == 43 && b == 35)
		{
			return 8;
		}
		else if(a == 43 && b == 36)
		{
			return 7;
		}
		else if(a == 43 && b == 37)
		{
			return 6;
		}
		else if(a == 43 && b == 38)
		{
			return 5;
		}
		else if(a == 43 && b == 39)
		{
			return 4;
		}
		else if(a == 43 && b == 40)
		{
			return 3;
		}
		else if(a == 43 && b == 41)
		{
			return 2;
		}
		else if(a == 43 && b == 42)
		{
			return 1;
		}
		else if(a == 43 && b == 43)
		{
			return 0;
		}
		else if(a == 43 && b == 44)
		{
			return -1;
		}
		else if(a == 43 && b == 45)
		{
			return -2;
		}
		else if(a == 43 && b == 46)
		{
			return -3;
		}
		else if(a == 43 && b == 47)
		{
			return -4;
		}
		else if(a == 43 && b == 48)
		{
			return -5;
		}
		else if(a == 43 && b == 49)
		{
			return -6;
		}
		else if(a == 43 && b == 50)
		{
			return -7;
		}
		else if(a == 43 && b == 51)
		{
			return -8;
		}
		else if(a == 43 && b == 52)
		{
			return -9;
		}
		else if(a == 43 && b == 53)
		{
			return -10;
		}
		else if(a == 43 && b == 54)
		{
			return -11;
		}
		else if(a == 43 && b == 55)
		{
			return -12;
		}
		else if(a == 43 && b == 56)
		{
			return -13;
		}
		else if(a == 43 && b == 57)
		{
			return -14;
		}
		else if(a == 43 && b == 58)
		{
			return -15;
		}
		else if(a == 43 && b == 59)
		{
			return -16;
		}
		else if(a == 43 && b == 60)
		{
			return -17;
		}
		else if(a == 43 && b == 61)
		{
			return -18;
		}
		else if(a == 43 && b == 62)
		{
			return -19;
		}
		else if(a == 43 && b == 63)
		{
			return -20;
		}
		else if(a == 43 && b == 64)
		{
			return -21;
		}
		else if(a == 43 && b == 65)
		{
			return -22;
		}
		else if(a == 43 && b == 66)
		{
			return -23;
		}
		else if(a == 43 && b == 67)
		{
			return -24;
		}
		else if(a == 43 && b == 68)
		{
			return -25;
		}
		else if(a == 43 && b == 69)
		{
			return -26;
		}
		else if(a == 43 && b == 70)
		{
			return -27;
		}
		else if(a == 43 && b == 71)
		{
			return -28;
		}
		else if(a == 43 && b == 72)
		{
			return -29;
		}
		else if(a == 43 && b == 73)
		{
			return -30;
		}
		else if(a == 43 && b == 74)
		{
			return -31;
		}
		else if(a == 43 && b == 75)
		{
			return -32;
		}
		else if(a == 43 && b == 76)
		{
			return -33;
		}
		else if(a == 43 && b == 77)
		{
			return -34;
		}
		else if(a == 43 && b == 78)
		{
			return -35;
		}
		else if(a == 43 && b == 79)
		{
			return -36;
		}
		else if(a == 43 && b == 80)
		{
			return -37;
		}
		else if(a == 43 && b == 81)
		{
			return -38;
		}
		else if(a == 43 && b == 82)
		{
			return -39;
		}
		else if(a == 43 && b == 83)
		{
			return -40;
		}
		else if(a == 43 && b == 84)
		{
			return -41;
		}
		else if(a == 43 && b == 85)
		{
			return -42;
		}
		else if(a == 43 && b == 86)
		{
			return -43;
		}
		else if(a == 43 && b == 87)
		{
			return -44;
		}
		else if(a == 43 && b == 88)
		{
			return -45;
		}
		else if(a == 43 && b == 89)
		{
			return -46;
		}
		else if(a == 43 && b == 90)
		{
			return -47;
		}
		else if(a == 43 && b == 91)
		{
			return -48;
		}
		else if(a == 43 && b == 92)
		{
			return -49;
		}
		else if(a == 43 && b == 93)
		{
			return -50;
		}
		else if(a == 43 && b == 94)
		{
			return -51;
		}
		else if(a == 43 && b == 95)
		{
			return -52;
		}
		else if(a == 43 && b == 96)
		{
			return -53;
		}
		else if(a == 43 && b == 97)
		{
			return -54;
		}
		else if(a == 43 && b == 98)
		{
			return -55;
		}
		else if(a == 43 && b == 99)
		{
			return -56;
		}
		else if(a == 43 && b == 100)
		{
			return -57;
		}
		else if(a == 44 && b == 0)
		{
			return 44;
		}
		else if(a == 44 && b == 1)
		{
			return 43;
		}
		else if(a == 44 && b == 2)
		{
			return 42;
		}
		else if(a == 44 && b == 3)
		{
			return 41;
		}
		else if(a == 44 && b == 4)
		{
			return 40;
		}
		else if(a == 44 && b == 5)
		{
			return 39;
		}
		else if(a == 44 && b == 6)
		{
			return 38;
		}
		else if(a == 44 && b == 7)
		{
			return 37;
		}
		else if(a == 44 && b == 8)
		{
			return 36;
		}
		else if(a == 44 && b == 9)
		{
			return 35;
		}
		else if(a == 44 && b == 10)
		{
			return 34;
		}
		else if(a == 44 && b == 11)
		{
			return 33;
		}
		else if(a == 44 && b == 12)
		{
			return 32;
		}
		else if(a == 44 && b == 13)
		{
			return 31;
		}
		else if(a == 44 && b == 14)
		{
			return 30;
		}
		else if(a == 44 && b == 15)
		{
			return 29;
		}
		else if(a == 44 && b == 16)
		{
			return 28;
		}
		else if(a == 44 && b == 17)
		{
			return 27;
		}
		else if(a == 44 && b == 18)
		{
			return 26;
		}
		else if(a == 44 && b == 19)
		{
			return 25;
		}
		else if(a == 44 && b == 20)
		{
			return 24;
		}
		else if(a == 44 && b == 21)
		{
			return 23;
		}
		else if(a == 44 && b == 22)
		{
			return 22;
		}
		else if(a == 44 && b == 23)
		{
			return 21;
		}
		else if(a == 44 && b == 24)
		{
			return 20;
		}
		else if(a == 44 && b == 25)
		{
			return 19;
		}
		else if(a == 44 && b == 26)
		{
			return 18;
		}
		else if(a == 44 && b == 27)
		{
			return 17;
		}
		else if(a == 44 && b == 28)
		{
			return 16;
		}
		else if(a == 44 && b == 29)
		{
			return 15;
		}
		else if(a == 44 && b == 30)
		{
			return 14;
		}
		else if(a == 44 && b == 31)
		{
			return 13;
		}
		else if(a == 44 && b == 32)
		{
			return 12;
		}
		else if(a == 44 && b == 33)
		{
			return 11;
		}
		else if(a == 44 && b == 34)
		{
			return 10;
		}
		else if(a == 44 && b == 35)
		{
			return 9;
		}
		else if(a == 44 && b == 36)
		{
			return 8;
		}
		else if(a == 44 && b == 37)
		{
			return 7;
		}
		else if(a == 44 && b == 38)
		{
			return 6;
		}
		else if(a == 44 && b == 39)
		{
			return 5;
		}
		else if(a == 44 && b == 40)
		{
			return 4;
		}
		else if(a == 44 && b == 41)
		{
			return 3;
		}
		else if(a == 44 && b == 42)
		{
			return 2;
		}
		else if(a == 44 && b == 43)
		{
			return 1;
		}
		else if(a == 44 && b == 44)
		{
			return 0;
		}
		else if(a == 44 && b == 45)
		{
			return -1;
		}
		else if(a == 44 && b == 46)
		{
			return -2;
		}
		else if(a == 44 && b == 47)
		{
			return -3;
		}
		else if(a == 44 && b == 48)
		{
			return -4;
		}
		else if(a == 44 && b == 49)
		{
			return -5;
		}
		else if(a == 44 && b == 50)
		{
			return -6;
		}
		else if(a == 44 && b == 51)
		{
			return -7;
		}
		else if(a == 44 && b == 52)
		{
			return -8;
		}
		else if(a == 44 && b == 53)
		{
			return -9;
		}
		else if(a == 44 && b == 54)
		{
			return -10;
		}
		else if(a == 44 && b == 55)
		{
			return -11;
		}
		else if(a == 44 && b == 56)
		{
			return -12;
		}
		else if(a == 44 && b == 57)
		{
			return -13;
		}
		else if(a == 44 && b == 58)
		{
			return -14;
		}
		else if(a == 44 && b == 59)
		{
			return -15;
		}
		else if(a == 44 && b == 60)
		{
			return -16;
		}
		else if(a == 44 && b == 61)
		{
			return -17;
		}
		else if(a == 44 && b == 62)
		{
			return -18;
		}
		else if(a == 44 && b == 63)
		{
			return -19;
		}
		else if(a == 44 && b == 64)
		{
			return -20;
		}
		else if(a == 44 && b == 65)
		{
			return -21;
		}
		else if(a == 44 && b == 66)
		{
			return -22;
		}
		else if(a == 44 && b == 67)
		{
			return -23;
		}
		else if(a == 44 && b == 68)
		{
			return -24;
		}
		else if(a == 44 && b == 69)
		{
			return -25;
		}
		else if(a == 44 && b == 70)
		{
			return -26;
		}
		else if(a == 44 && b == 71)
		{
			return -27;
		}
		else if(a == 44 && b == 72)
		{
			return -28;
		}
		else if(a == 44 && b == 73)
		{
			return -29;
		}
		else if(a == 44 && b == 74)
		{
			return -30;
		}
		else if(a == 44 && b == 75)
		{
			return -31;
		}
		else if(a == 44 && b == 76)
		{
			return -32;
		}
		else if(a == 44 && b == 77)
		{
			return -33;
		}
		else if(a == 44 && b == 78)
		{
			return -34;
		}
		else if(a == 44 && b == 79)
		{
			return -35;
		}
		else if(a == 44 && b == 80)
		{
			return -36;
		}
		else if(a == 44 && b == 81)
		{
			return -37;
		}
		else if(a == 44 && b == 82)
		{
			return -38;
		}
		else if(a == 44 && b == 83)
		{
			return -39;
		}
		else if(a == 44 && b == 84)
		{
			return -40;
		}
		else if(a == 44 && b == 85)
		{
			return -41;
		}
		else if(a == 44 && b == 86)
		{
			return -42;
		}
		else if(a == 44 && b == 87)
		{
			return -43;
		}
		else if(a == 44 && b == 88)
		{
			return -44;
		}
		else if(a == 44 && b == 89)
		{
			return -45;
		}
		else if(a == 44 && b == 90)
		{
			return -46;
		}
		else if(a == 44 && b == 91)
		{
			return -47;
		}
		else if(a == 44 && b == 92)
		{
			return -48;
		}
		else if(a == 44 && b == 93)
		{
			return -49;
		}
		else if(a == 44 && b == 94)
		{
			return -50;
		}
		else if(a == 44 && b == 95)
		{
			return -51;
		}
		else if(a == 44 && b == 96)
		{
			return -52;
		}
		else if(a == 44 && b == 97)
		{
			return -53;
		}
		else if(a == 44 && b == 98)
		{
			return -54;
		}
		else if(a == 44 && b == 99)
		{
			return -55;
		}
		else if(a == 44 && b == 100)
		{
			return -56;
		}
		else if(a == 45 && b == 0)
		{
			return 45;
		}
		else if(a == 45 && b == 1)
		{
			return 44;
		}
		else if(a == 45 && b == 2)
		{
			return 43;
		}
		else if(a == 45 && b == 3)
		{
			return 42;
		}
		else if(a == 45 && b == 4)
		{
			return 41;
		}
		else if(a == 45 && b == 5)
		{
			return 40;
		}
		else if(a == 45 && b == 6)
		{
			return 39;
		}
		else if(a == 45 && b == 7)
		{
			return 38;
		}
		else if(a == 45 && b == 8)
		{
			return 37;
		}
		else if(a == 45 && b == 9)
		{
			return 36;
		}
		else if(a == 45 && b == 10)
		{
			return 35;
		}
		else if(a == 45 && b == 11)
		{
			return 34;
		}
		else if(a == 45 && b == 12)
		{
			return 33;
		}
		else if(a == 45 && b == 13)
		{
			return 32;
		}
		else if(a == 45 && b == 14)
		{
			return 31;
		}
		else if(a == 45 && b == 15)
		{
			return 30;
		}
		else if(a == 45 && b == 16)
		{
			return 29;
		}
		else if(a == 45 && b == 17)
		{
			return 28;
		}
		else if(a == 45 && b == 18)
		{
			return 27;
		}
		else if(a == 45 && b == 19)
		{
			return 26;
		}
		else if(a == 45 && b == 20)
		{
			return 25;
		}
		else if(a == 45 && b == 21)
		{
			return 24;
		}
		else if(a == 45 && b == 22)
		{
			return 23;
		}
		else if(a == 45 && b == 23)
		{
			return 22;
		}
		else if(a == 45 && b == 24)
		{
			return 21;
		}
		else if(a == 45 && b == 25)
		{
			return 20;
		}
		else if(a == 45 && b == 26)
		{
			return 19;
		}
		else if(a == 45 && b == 27)
		{
			return 18;
		}
		else if(a == 45 && b == 28)
		{
			return 17;
		}
		else if(a == 45 && b == 29)
		{
			return 16;
		}
		else if(a == 45 && b == 30)
		{
			return 15;
		}
		else if(a == 45 && b == 31)
		{
			return 14;
		}
		else if(a == 45 && b == 32)
		{
			return 13;
		}
		else if(a == 45 && b == 33)
		{
			return 12;
		}
		else if(a == 45 && b == 34)
		{
			return 11;
		}
		else if(a == 45 && b == 35)
		{
			return 10;
		}
		else if(a == 45 && b == 36)
		{
			return 9;
		}
		else if(a == 45 && b == 37)
		{
			return 8;
		}
		else if(a == 45 && b == 38)
		{
			return 7;
		}
		else if(a == 45 && b == 39)
		{
			return 6;
		}
		else if(a == 45 && b == 40)
		{
			return 5;
		}
		else if(a == 45 && b == 41)
		{
			return 4;
		}
		else if(a == 45 && b == 42)
		{
			return 3;
		}
		else if(a == 45 && b == 43)
		{
			return 2;
		}
		else if(a == 45 && b == 44)
		{
			return 1;
		}
		else if(a == 45 && b == 45)
		{
			return 0;
		}
		else if(a == 45 && b == 46)
		{
			return -1;
		}
		else if(a == 45 && b == 47)
		{
			return -2;
		}
		else if(a == 45 && b == 48)
		{
			return -3;
		}
		else if(a == 45 && b == 49)
		{
			return -4;
		}
		else if(a == 45 && b == 50)
		{
			return -5;
		}
		else if(a == 45 && b == 51)
		{
			return -6;
		}
		else if(a == 45 && b == 52)
		{
			return -7;
		}
		else if(a == 45 && b == 53)
		{
			return -8;
		}
		else if(a == 45 && b == 54)
		{
			return -9;
		}
		else if(a == 45 && b == 55)
		{
			return -10;
		}
		else if(a == 45 && b == 56)
		{
			return -11;
		}
		else if(a == 45 && b == 57)
		{
			return -12;
		}
		else if(a == 45 && b == 58)
		{
			return -13;
		}
		else if(a == 45 && b == 59)
		{
			return -14;
		}
		else if(a == 45 && b == 60)
		{
			return -15;
		}
		else if(a == 45 && b == 61)
		{
			return -16;
		}
		else if(a == 45 && b == 62)
		{
			return -17;
		}
		else if(a == 45 && b == 63)
		{
			return -18;
		}
		else if(a == 45 && b == 64)
		{
			return -19;
		}
		else if(a == 45 && b == 65)
		{
			return -20;
		}
		else if(a == 45 && b == 66)
		{
			return -21;
		}
		else if(a == 45 && b == 67)
		{
			return -22;
		}
		else if(a == 45 && b == 68)
		{
			return -23;
		}
		else if(a == 45 && b == 69)
		{
			return -24;
		}
		else if(a == 45 && b == 70)
		{
			return -25;
		}
		else if(a == 45 && b == 71)
		{
			return -26;
		}
		else if(a == 45 && b == 72)
		{
			return -27;
		}
		else if(a == 45 && b == 73)
		{
			return -28;
		}
		else if(a == 45 && b == 74)
		{
			return -29;
		}
		else if(a == 45 && b == 75)
		{
			return -30;
		}
		else if(a == 45 && b == 76)
		{
			return -31;
		}
		else if(a == 45 && b == 77)
		{
			return -32;
		}
		else if(a == 45 && b == 78)
		{
			return -33;
		}
		else if(a == 45 && b == 79)
		{
			return -34;
		}
		else if(a == 45 && b == 80)
		{
			return -35;
		}
		else if(a == 45 && b == 81)
		{
			return -36;
		}
		else if(a == 45 && b == 82)
		{
			return -37;
		}
		else if(a == 45 && b == 83)
		{
			return -38;
		}
		else if(a == 45 && b == 84)
		{
			return -39;
		}
		else if(a == 45 && b == 85)
		{
			return -40;
		}
		else if(a == 45 && b == 86)
		{
			return -41;
		}
		else if(a == 45 && b == 87)
		{
			return -42;
		}
		else if(a == 45 && b == 88)
		{
			return -43;
		}
		else if(a == 45 && b == 89)
		{
			return -44;
		}
		else if(a == 45 && b == 90)
		{
			return -45;
		}
		else if(a == 45 && b == 91)
		{
			return -46;
		}
		else if(a == 45 && b == 92)
		{
			return -47;
		}
		else if(a == 45 && b == 93)
		{
			return -48;
		}
		else if(a == 45 && b == 94)
		{
			return -49;
		}
		else if(a == 45 && b == 95)
		{
			return -50;
		}
		else if(a == 45 && b == 96)
		{
			return -51;
		}
		else if(a == 45 && b == 97)
		{
			return -52;
		}
		else if(a == 45 && b == 98)
		{
			return -53;
		}
		else if(a == 45 && b == 99)
		{
			return -54;
		}
		else if(a == 45 && b == 100)
		{
			return -55;
		}
		else if(a == 46 && b == 0)
		{
			return 46;
		}
		else if(a == 46 && b == 1)
		{
			return 45;
		}
		else if(a == 46 && b == 2)
		{
			return 44;
		}
		else if(a == 46 && b == 3)
		{
			return 43;
		}
		else if(a == 46 && b == 4)
		{
			return 42;
		}
		else if(a == 46 && b == 5)
		{
			return 41;
		}
		else if(a == 46 && b == 6)
		{
			return 40;
		}
		else if(a == 46 && b == 7)
		{
			return 39;
		}
		else if(a == 46 && b == 8)
		{
			return 38;
		}
		else if(a == 46 && b == 9)
		{
			return 37;
		}
		else if(a == 46 && b == 10)
		{
			return 36;
		}
		else if(a == 46 && b == 11)
		{
			return 35;
		}
		else if(a == 46 && b == 12)
		{
			return 34;
		}
		else if(a == 46 && b == 13)
		{
			return 33;
		}
		else if(a == 46 && b == 14)
		{
			return 32;
		}
		else if(a == 46 && b == 15)
		{
			return 31;
		}
		else if(a == 46 && b == 16)
		{
			return 30;
		}
		else if(a == 46 && b == 17)
		{
			return 29;
		}
		else if(a == 46 && b == 18)
		{
			return 28;
		}
		else if(a == 46 && b == 19)
		{
			return 27;
		}
		else if(a == 46 && b == 20)
		{
			return 26;
		}
		else if(a == 46 && b == 21)
		{
			return 25;
		}
		else if(a == 46 && b == 22)
		{
			return 24;
		}
		else if(a == 46 && b == 23)
		{
			return 23;
		}
		else if(a == 46 && b == 24)
		{
			return 22;
		}
		else if(a == 46 && b == 25)
		{
			return 21;
		}
		else if(a == 46 && b == 26)
		{
			return 20;
		}
		else if(a == 46 && b == 27)
		{
			return 19;
		}
		else if(a == 46 && b == 28)
		{
			return 18;
		}
		else if(a == 46 && b == 29)
		{
			return 17;
		}
		else if(a == 46 && b == 30)
		{
			return 16;
		}
		else if(a == 46 && b == 31)
		{
			return 15;
		}
		else if(a == 46 && b == 32)
		{
			return 14;
		}
		else if(a == 46 && b == 33)
		{
			return 13;
		}
		else if(a == 46 && b == 34)
		{
			return 12;
		}
		else if(a == 46 && b == 35)
		{
			return 11;
		}
		else if(a == 46 && b == 36)
		{
			return 10;
		}
		else if(a == 46 && b == 37)
		{
			return 9;
		}
		else if(a == 46 && b == 38)
		{
			return 8;
		}
		else if(a == 46 && b == 39)
		{
			return 7;
		}
		else if(a == 46 && b == 40)
		{
			return 6;
		}
		else if(a == 46 && b == 41)
		{
			return 5;
		}
		else if(a == 46 && b == 42)
		{
			return 4;
		}
		else if(a == 46 && b == 43)
		{
			return 3;
		}
		else if(a == 46 && b == 44)
		{
			return 2;
		}
		else if(a == 46 && b == 45)
		{
			return 1;
		}
		else if(a == 46 && b == 46)
		{
			return 0;
		}
		else if(a == 46 && b == 47)
		{
			return -1;
		}
		else if(a == 46 && b == 48)
		{
			return -2;
		}
		else if(a == 46 && b == 49)
		{
			return -3;
		}
		else if(a == 46 && b == 50)
		{
			return -4;
		}
		else if(a == 46 && b == 51)
		{
			return -5;
		}
		else if(a == 46 && b == 52)
		{
			return -6;
		}
		else if(a == 46 && b == 53)
		{
			return -7;
		}
		else if(a == 46 && b == 54)
		{
			return -8;
		}
		else if(a == 46 && b == 55)
		{
			return -9;
		}
		else if(a == 46 && b == 56)
		{
			return -10;
		}
		else if(a == 46 && b == 57)
		{
			return -11;
		}
		else if(a == 46 && b == 58)
		{
			return -12;
		}
		else if(a == 46 && b == 59)
		{
			return -13;
		}
		else if(a == 46 && b == 60)
		{
			return -14;
		}
		else if(a == 46 && b == 61)
		{
			return -15;
		}
		else if(a == 46 && b == 62)
		{
			return -16;
		}
		else if(a == 46 && b == 63)
		{
			return -17;
		}
		else if(a == 46 && b == 64)
		{
			return -18;
		}
		else if(a == 46 && b == 65)
		{
			return -19;
		}
		else if(a == 46 && b == 66)
		{
			return -20;
		}
		else if(a == 46 && b == 67)
		{
			return -21;
		}
		else if(a == 46 && b == 68)
		{
			return -22;
		}
		else if(a == 46 && b == 69)
		{
			return -23;
		}
		else if(a == 46 && b == 70)
		{
			return -24;
		}
		else if(a == 46 && b == 71)
		{
			return -25;
		}
		else if(a == 46 && b == 72)
		{
			return -26;
		}
		else if(a == 46 && b == 73)
		{
			return -27;
		}
		else if(a == 46 && b == 74)
		{
			return -28;
		}
		else if(a == 46 && b == 75)
		{
			return -29;
		}
		else if(a == 46 && b == 76)
		{
			return -30;
		}
		else if(a == 46 && b == 77)
		{
			return -31;
		}
		else if(a == 46 && b == 78)
		{
			return -32;
		}
		else if(a == 46 && b == 79)
		{
			return -33;
		}
		else if(a == 46 && b == 80)
		{
			return -34;
		}
		else if(a == 46 && b == 81)
		{
			return -35;
		}
		else if(a == 46 && b == 82)
		{
			return -36;
		}
		else if(a == 46 && b == 83)
		{
			return -37;
		}
		else if(a == 46 && b == 84)
		{
			return -38;
		}
		else if(a == 46 && b == 85)
		{
			return -39;
		}
		else if(a == 46 && b == 86)
		{
			return -40;
		}
		else if(a == 46 && b == 87)
		{
			return -41;
		}
		else if(a == 46 && b == 88)
		{
			return -42;
		}
		else if(a == 46 && b == 89)
		{
			return -43;
		}
		else if(a == 46 && b == 90)
		{
			return -44;
		}
		else if(a == 46 && b == 91)
		{
			return -45;
		}
		else if(a == 46 && b == 92)
		{
			return -46;
		}
		else if(a == 46 && b == 93)
		{
			return -47;
		}
		else if(a == 46 && b == 94)
		{
			return -48;
		}
		else if(a == 46 && b == 95)
		{
			return -49;
		}
		else if(a == 46 && b == 96)
		{
			return -50;
		}
		else if(a == 46 && b == 97)
		{
			return -51;
		}
		else if(a == 46 && b == 98)
		{
			return -52;
		}
		else if(a == 46 && b == 99)
		{
			return -53;
		}
		else if(a == 46 && b == 100)
		{
			return -54;
		}
		else if(a == 47 && b == 0)
		{
			return 47;
		}
		else if(a == 47 && b == 1)
		{
			return 46;
		}
		else if(a == 47 && b == 2)
		{
			return 45;
		}
		else if(a == 47 && b == 3)
		{
			return 44;
		}
		else if(a == 47 && b == 4)
		{
			return 43;
		}
		else if(a == 47 && b == 5)
		{
			return 42;
		}
		else if(a == 47 && b == 6)
		{
			return 41;
		}
		else if(a == 47 && b == 7)
		{
			return 40;
		}
		else if(a == 47 && b == 8)
		{
			return 39;
		}
		else if(a == 47 && b == 9)
		{
			return 38;
		}
		else if(a == 47 && b == 10)
		{
			return 37;
		}
		else if(a == 47 && b == 11)
		{
			return 36;
		}
		else if(a == 47 && b == 12)
		{
			return 35;
		}
		else if(a == 47 && b == 13)
		{
			return 34;
		}
		else if(a == 47 && b == 14)
		{
			return 33;
		}
		else if(a == 47 && b == 15)
		{
			return 32;
		}
		else if(a == 47 && b == 16)
		{
			return 31;
		}
		else if(a == 47 && b == 17)
		{
			return 30;
		}
		else if(a == 47 && b == 18)
		{
			return 29;
		}
		else if(a == 47 && b == 19)
		{
			return 28;
		}
		else if(a == 47 && b == 20)
		{
			return 27;
		}
		else if(a == 47 && b == 21)
		{
			return 26;
		}
		else if(a == 47 && b == 22)
		{
			return 25;
		}
		else if(a == 47 && b == 23)
		{
			return 24;
		}
		else if(a == 47 && b == 24)
		{
			return 23;
		}
		else if(a == 47 && b == 25)
		{
			return 22;
		}
		else if(a == 47 && b == 26)
		{
			return 21;
		}
		else if(a == 47 && b == 27)
		{
			return 20;
		}
		else if(a == 47 && b == 28)
		{
			return 19;
		}
		else if(a == 47 && b == 29)
		{
			return 18;
		}
		else if(a == 47 && b == 30)
		{
			return 17;
		}
		else if(a == 47 && b == 31)
		{
			return 16;
		}
		else if(a == 47 && b == 32)
		{
			return 15;
		}
		else if(a == 47 && b == 33)
		{
			return 14;
		}
		else if(a == 47 && b == 34)
		{
			return 13;
		}
		else if(a == 47 && b == 35)
		{
			return 12;
		}
		else if(a == 47 && b == 36)
		{
			return 11;
		}
		else if(a == 47 && b == 37)
		{
			return 10;
		}
		else if(a == 47 && b == 38)
		{
			return 9;
		}
		else if(a == 47 && b == 39)
		{
			return 8;
		}
		else if(a == 47 && b == 40)
		{
			return 7;
		}
		else if(a == 47 && b == 41)
		{
			return 6;
		}
		else if(a == 47 && b == 42)
		{
			return 5;
		}
		else if(a == 47 && b == 43)
		{
			return 4;
		}
		else if(a == 47 && b == 44)
		{
			return 3;
		}
		else if(a == 47 && b == 45)
		{
			return 2;
		}
		else if(a == 47 && b == 46)
		{
			return 1;
		}
		else if(a == 47 && b == 47)
		{
			return 0;
		}
		else if(a == 47 && b == 48)
		{
			return -1;
		}
		else if(a == 47 && b == 49)
		{
			return -2;
		}
		else if(a == 47 && b == 50)
		{
			return -3;
		}
		else if(a == 47 && b == 51)
		{
			return -4;
		}
		else if(a == 47 && b == 52)
		{
			return -5;
		}
		else if(a == 47 && b == 53)
		{
			return -6;
		}
		else if(a == 47 && b == 54)
		{
			return -7;
		}
		else if(a == 47 && b == 55)
		{
			return -8;
		}
		else if(a == 47 && b == 56)
		{
			return -9;
		}
		else if(a == 47 && b == 57)
		{
			return -10;
		}
		else if(a == 47 && b == 58)
		{
			return -11;
		}
		else if(a == 47 && b == 59)
		{
			return -12;
		}
		else if(a == 47 && b == 60)
		{
			return -13;
		}
		else if(a == 47 && b == 61)
		{
			return -14;
		}
		else if(a == 47 && b == 62)
		{
			return -15;
		}
		else if(a == 47 && b == 63)
		{
			return -16;
		}
		else if(a == 47 && b == 64)
		{
			return -17;
		}
		else if(a == 47 && b == 65)
		{
			return -18;
		}
		else if(a == 47 && b == 66)
		{
			return -19;
		}
		else if(a == 47 && b == 67)
		{
			return -20;
		}
		else if(a == 47 && b == 68)
		{
			return -21;
		}
		else if(a == 47 && b == 69)
		{
			return -22;
		}
		else if(a == 47 && b == 70)
		{
			return -23;
		}
		else if(a == 47 && b == 71)
		{
			return -24;
		}
		else if(a == 47 && b == 72)
		{
			return -25;
		}
		else if(a == 47 && b == 73)
		{
			return -26;
		}
		else if(a == 47 && b == 74)
		{
			return -27;
		}
		else if(a == 47 && b == 75)
		{
			return -28;
		}
		else if(a == 47 && b == 76)
		{
			return -29;
		}
		else if(a == 47 && b == 77)
		{
			return -30;
		}
		else if(a == 47 && b == 78)
		{
			return -31;
		}
		else if(a == 47 && b == 79)
		{
			return -32;
		}
		else if(a == 47 && b == 80)
		{
			return -33;
		}
		else if(a == 47 && b == 81)
		{
			return -34;
		}
		else if(a == 47 && b == 82)
		{
			return -35;
		}
		else if(a == 47 && b == 83)
		{
			return -36;
		}
		else if(a == 47 && b == 84)
		{
			return -37;
		}
		else if(a == 47 && b == 85)
		{
			return -38;
		}
		else if(a == 47 && b == 86)
		{
			return -39;
		}
		else if(a == 47 && b == 87)
		{
			return -40;
		}
		else if(a == 47 && b == 88)
		{
			return -41;
		}
		else if(a == 47 && b == 89)
		{
			return -42;
		}
		else if(a == 47 && b == 90)
		{
			return -43;
		}
		else if(a == 47 && b == 91)
		{
			return -44;
		}
		else if(a == 47 && b == 92)
		{
			return -45;
		}
		else if(a == 47 && b == 93)
		{
			return -46;
		}
		else if(a == 47 && b == 94)
		{
			return -47;
		}
		else if(a == 47 && b == 95)
		{
			return -48;
		}
		else if(a == 47 && b == 96)
		{
			return -49;
		}
		else if(a == 47 && b == 97)
		{
			return -50;
		}
		else if(a == 47 && b == 98)
		{
			return -51;
		}
		else if(a == 47 && b == 99)
		{
			return -52;
		}
		else if(a == 47 && b == 100)
		{
			return -53;
		}
		else if(a == 48 && b == 0)
		{
			return 48;
		}
		else if(a == 48 && b == 1)
		{
			return 47;
		}
		else if(a == 48 && b == 2)
		{
			return 46;
		}
		else if(a == 48 && b == 3)
		{
			return 45;
		}
		else if(a == 48 && b == 4)
		{
			return 44;
		}
		else if(a == 48 && b == 5)
		{
			return 43;
		}
		else if(a == 48 && b == 6)
		{
			return 42;
		}
		else if(a == 48 && b == 7)
		{
			return 41;
		}
		else if(a == 48 && b == 8)
		{
			return 40;
		}
		else if(a == 48 && b == 9)
		{
			return 39;
		}
		else if(a == 48 && b == 10)
		{
			return 38;
		}
		else if(a == 48 && b == 11)
		{
			return 37;
		}
		else if(a == 48 && b == 12)
		{
			return 36;
		}
		else if(a == 48 && b == 13)
		{
			return 35;
		}
		else if(a == 48 && b == 14)
		{
			return 34;
		}
		else if(a == 48 && b == 15)
		{
			return 33;
		}
		else if(a == 48 && b == 16)
		{
			return 32;
		}
		else if(a == 48 && b == 17)
		{
			return 31;
		}
		else if(a == 48 && b == 18)
		{
			return 30;
		}
		else if(a == 48 && b == 19)
		{
			return 29;
		}
		else if(a == 48 && b == 20)
		{
			return 28;
		}
		else if(a == 48 && b == 21)
		{
			return 27;
		}
		else if(a == 48 && b == 22)
		{
			return 26;
		}
		else if(a == 48 && b == 23)
		{
			return 25;
		}
		else if(a == 48 && b == 24)
		{
			return 24;
		}
		else if(a == 48 && b == 25)
		{
			return 23;
		}
		else if(a == 48 && b == 26)
		{
			return 22;
		}
		else if(a == 48 && b == 27)
		{
			return 21;
		}
		else if(a == 48 && b == 28)
		{
			return 20;
		}
		else if(a == 48 && b == 29)
		{
			return 19;
		}
		else if(a == 48 && b == 30)
		{
			return 18;
		}
		else if(a == 48 && b == 31)
		{
			return 17;
		}
		else if(a == 48 && b == 32)
		{
			return 16;
		}
		else if(a == 48 && b == 33)
		{
			return 15;
		}
		else if(a == 48 && b == 34)
		{
			return 14;
		}
		else if(a == 48 && b == 35)
		{
			return 13;
		}
		else if(a == 48 && b == 36)
		{
			return 12;
		}
		else if(a == 48 && b == 37)
		{
			return 11;
		}
		else if(a == 48 && b == 38)
		{
			return 10;
		}
		else if(a == 48 && b == 39)
		{
			return 9;
		}
		else if(a == 48 && b == 40)
		{
			return 8;
		}
		else if(a == 48 && b == 41)
		{
			return 7;
		}
		else if(a == 48 && b == 42)
		{
			return 6;
		}
		else if(a == 48 && b == 43)
		{
			return 5;
		}
		else if(a == 48 && b == 44)
		{
			return 4;
		}
		else if(a == 48 && b == 45)
		{
			return 3;
		}
		else if(a == 48 && b == 46)
		{
			return 2;
		}
		else if(a == 48 && b == 47)
		{
			return 1;
		}
		else if(a == 48 && b == 48)
		{
			return 0;
		}
		else if(a == 48 && b == 49)
		{
			return -1;
		}
		else if(a == 48 && b == 50)
		{
			return -2;
		}
		else if(a == 48 && b == 51)
		{
			return -3;
		}
		else if(a == 48 && b == 52)
		{
			return -4;
		}
		else if(a == 48 && b == 53)
		{
			return -5;
		}
		else if(a == 48 && b == 54)
		{
			return -6;
		}
		else if(a == 48 && b == 55)
		{
			return -7;
		}
		else if(a == 48 && b == 56)
		{
			return -8;
		}
		else if(a == 48 && b == 57)
		{
			return -9;
		}
		else if(a == 48 && b == 58)
		{
			return -10;
		}
		else if(a == 48 && b == 59)
		{
			return -11;
		}
		else if(a == 48 && b == 60)
		{
			return -12;
		}
		else if(a == 48 && b == 61)
		{
			return -13;
		}
		else if(a == 48 && b == 62)
		{
			return -14;
		}
		else if(a == 48 && b == 63)
		{
			return -15;
		}
		else if(a == 48 && b == 64)
		{
			return -16;
		}
		else if(a == 48 && b == 65)
		{
			return -17;
		}
		else if(a == 48 && b == 66)
		{
			return -18;
		}
		else if(a == 48 && b == 67)
		{
			return -19;
		}
		else if(a == 48 && b == 68)
		{
			return -20;
		}
		else if(a == 48 && b == 69)
		{
			return -21;
		}
		else if(a == 48 && b == 70)
		{
			return -22;
		}
		else if(a == 48 && b == 71)
		{
			return -23;
		}
		else if(a == 48 && b == 72)
		{
			return -24;
		}
		else if(a == 48 && b == 73)
		{
			return -25;
		}
		else if(a == 48 && b == 74)
		{
			return -26;
		}
		else if(a == 48 && b == 75)
		{
			return -27;
		}
		else if(a == 48 && b == 76)
		{
			return -28;
		}
		else if(a == 48 && b == 77)
		{
			return -29;
		}
		else if(a == 48 && b == 78)
		{
			return -30;
		}
		else if(a == 48 && b == 79)
		{
			return -31;
		}
		else if(a == 48 && b == 80)
		{
			return -32;
		}
		else if(a == 48 && b == 81)
		{
			return -33;
		}
		else if(a == 48 && b == 82)
		{
			return -34;
		}
		else if(a == 48 && b == 83)
		{
			return -35;
		}
		else if(a == 48 && b == 84)
		{
			return -36;
		}
		else if(a == 48 && b == 85)
		{
			return -37;
		}
		else if(a == 48 && b == 86)
		{
			return -38;
		}
		else if(a == 48 && b == 87)
		{
			return -39;
		}
		else if(a == 48 && b == 88)
		{
			return -40;
		}
		else if(a == 48 && b == 89)
		{
			return -41;
		}
		else if(a == 48 && b == 90)
		{
			return -42;
		}
		else if(a == 48 && b == 91)
		{
			return -43;
		}
		else if(a == 48 && b == 92)
		{
			return -44;
		}
		else if(a == 48 && b == 93)
		{
			return -45;
		}
		else if(a == 48 && b == 94)
		{
			return -46;
		}
		else if(a == 48 && b == 95)
		{
			return -47;
		}
		else if(a == 48 && b == 96)
		{
			return -48;
		}
		else if(a == 48 && b == 97)
		{
			return -49;
		}
		else if(a == 48 && b == 98)
		{
			return -50;
		}
		else if(a == 48 && b == 99)
		{
			return -51;
		}
		else if(a == 48 && b == 100)
		{
			return -52;
		}
		else if(a == 49 && b == 0)
		{
			return 49;
		}
		else if(a == 49 && b == 1)
		{
			return 48;
		}
		else if(a == 49 && b == 2)
		{
			return 47;
		}
		else if(a == 49 && b == 3)
		{
			return 46;
		}
		else if(a == 49 && b == 4)
		{
			return 45;
		}
		else if(a == 49 && b == 5)
		{
			return 44;
		}
		else if(a == 49 && b == 6)
		{
			return 43;
		}
		else if(a == 49 && b == 7)
		{
			return 42;
		}
		else if(a == 49 && b == 8)
		{
			return 41;
		}
		else if(a == 49 && b == 9)
		{
			return 40;
		}
		else if(a == 49 && b == 10)
		{
			return 39;
		}
		else if(a == 49 && b == 11)
		{
			return 38;
		}
		else if(a == 49 && b == 12)
		{
			return 37;
		}
		else if(a == 49 && b == 13)
		{
			return 36;
		}
		else if(a == 49 && b == 14)
		{
			return 35;
		}
		else if(a == 49 && b == 15)
		{
			return 34;
		}
		else if(a == 49 && b == 16)
		{
			return 33;
		}
		else if(a == 49 && b == 17)
		{
			return 32;
		}
		else if(a == 49 && b == 18)
		{
			return 31;
		}
		else if(a == 49 && b == 19)
		{
			return 30;
		}
		else if(a == 49 && b == 20)
		{
			return 29;
		}
		else if(a == 49 && b == 21)
		{
			return 28;
		}
		else if(a == 49 && b == 22)
		{
			return 27;
		}
		else if(a == 49 && b == 23)
		{
			return 26;
		}
		else if(a == 49 && b == 24)
		{
			return 25;
		}
		else if(a == 49 && b == 25)
		{
			return 24;
		}
		else if(a == 49 && b == 26)
		{
			return 23;
		}
		else if(a == 49 && b == 27)
		{
			return 22;
		}
		else if(a == 49 && b == 28)
		{
			return 21;
		}
		else if(a == 49 && b == 29)
		{
			return 20;
		}
		else if(a == 49 && b == 30)
		{
			return 19;
		}
		else if(a == 49 && b == 31)
		{
			return 18;
		}
		else if(a == 49 && b == 32)
		{
			return 17;
		}
		else if(a == 49 && b == 33)
		{
			return 16;
		}
		else if(a == 49 && b == 34)
		{
			return 15;
		}
		else if(a == 49 && b == 35)
		{
			return 14;
		}
		else if(a == 49 && b == 36)
		{
			return 13;
		}
		else if(a == 49 && b == 37)
		{
			return 12;
		}
		else if(a == 49 && b == 38)
		{
			return 11;
		}
		else if(a == 49 && b == 39)
		{
			return 10;
		}
		else if(a == 49 && b == 40)
		{
			return 9;
		}
		else if(a == 49 && b == 41)
		{
			return 8;
		}
		else if(a == 49 && b == 42)
		{
			return 7;
		}
		else if(a == 49 && b == 43)
		{
			return 6;
		}
		else if(a == 49 && b == 44)
		{
			return 5;
		}
		else if(a == 49 && b == 45)
		{
			return 4;
		}
		else if(a == 49 && b == 46)
		{
			return 3;
		}
		else if(a == 49 && b == 47)
		{
			return 2;
		}
		else if(a == 49 && b == 48)
		{
			return 1;
		}
		else if(a == 49 && b == 49)
		{
			return 0;
		}
		else if(a == 49 && b == 50)
		{
			return -1;
		}
		else if(a == 49 && b == 51)
		{
			return -2;
		}
		else if(a == 49 && b == 52)
		{
			return -3;
		}
		else if(a == 49 && b == 53)
		{
			return -4;
		}
		else if(a == 49 && b == 54)
		{
			return -5;
		}
		else if(a == 49 && b == 55)
		{
			return -6;
		}
		else if(a == 49 && b == 56)
		{
			return -7;
		}
		else if(a == 49 && b == 57)
		{
			return -8;
		}
		else if(a == 49 && b == 58)
		{
			return -9;
		}
		else if(a == 49 && b == 59)
		{
			return -10;
		}
		else if(a == 49 && b == 60)
		{
			return -11;
		}
		else if(a == 49 && b == 61)
		{
			return -12;
		}
		else if(a == 49 && b == 62)
		{
			return -13;
		}
		else if(a == 49 && b == 63)
		{
			return -14;
		}
		else if(a == 49 && b == 64)
		{
			return -15;
		}
		else if(a == 49 && b == 65)
		{
			return -16;
		}
		else if(a == 49 && b == 66)
		{
			return -17;
		}
		else if(a == 49 && b == 67)
		{
			return -18;
		}
		else if(a == 49 && b == 68)
		{
			return -19;
		}
		else if(a == 49 && b == 69)
		{
			return -20;
		}
		else if(a == 49 && b == 70)
		{
			return -21;
		}
		else if(a == 49 && b == 71)
		{
			return -22;
		}
		else if(a == 49 && b == 72)
		{
			return -23;
		}
		else if(a == 49 && b == 73)
		{
			return -24;
		}
		else if(a == 49 && b == 74)
		{
			return -25;
		}
		else if(a == 49 && b == 75)
		{
			return -26;
		}
		else if(a == 49 && b == 76)
		{
			return -27;
		}
		else if(a == 49 && b == 77)
		{
			return -28;
		}
		else if(a == 49 && b == 78)
		{
			return -29;
		}
		else if(a == 49 && b == 79)
		{
			return -30;
		}
		else if(a == 49 && b == 80)
		{
			return -31;
		}
		else if(a == 49 && b == 81)
		{
			return -32;
		}
		else if(a == 49 && b == 82)
		{
			return -33;
		}
		else if(a == 49 && b == 83)
		{
			return -34;
		}
		else if(a == 49 && b == 84)
		{
			return -35;
		}
		else if(a == 49 && b == 85)
		{
			return -36;
		}
		else if(a == 49 && b == 86)
		{
			return -37;
		}
		else if(a == 49 && b == 87)
		{
			return -38;
		}
		else if(a == 49 && b == 88)
		{
			return -39;
		}
		else if(a == 49 && b == 89)
		{
			return -40;
		}
		else if(a == 49 && b == 90)
		{
			return -41;
		}
		else if(a == 49 && b == 91)
		{
			return -42;
		}
		else if(a == 49 && b == 92)
		{
			return -43;
		}
		else if(a == 49 && b == 93)
		{
			return -44;
		}
		else if(a == 49 && b == 94)
		{
			return -45;
		}
		else if(a == 49 && b == 95)
		{
			return -46;
		}
		else if(a == 49 && b == 96)
		{
			return -47;
		}
		else if(a == 49 && b == 97)
		{
			return -48;
		}
		else if(a == 49 && b == 98)
		{
			return -49;
		}
		else if(a == 49 && b == 99)
		{
			return -50;
		}
		else if(a == 49 && b == 100)
		{
			return -51;
		}
		else if(a == 50 && b == 0)
		{
			return 50;
		}
		else if(a == 50 && b == 1)
		{
			return 49;
		}
		else if(a == 50 && b == 2)
		{
			return 48;
		}
		else if(a == 50 && b == 3)
		{
			return 47;
		}
		else if(a == 50 && b == 4)
		{
			return 46;
		}
		else if(a == 50 && b == 5)
		{
			return 45;
		}
		else if(a == 50 && b == 6)
		{
			return 44;
		}
		else if(a == 50 && b == 7)
		{
			return 43;
		}
		else if(a == 50 && b == 8)
		{
			return 42;
		}
		else if(a == 50 && b == 9)
		{
			return 41;
		}
		else if(a == 50 && b == 10)
		{
			return 40;
		}
		else if(a == 50 && b == 11)
		{
			return 39;
		}
		else if(a == 50 && b == 12)
		{
			return 38;
		}
		else if(a == 50 && b == 13)
		{
			return 37;
		}
		else if(a == 50 && b == 14)
		{
			return 36;
		}
		else if(a == 50 && b == 15)
		{
			return 35;
		}
		else if(a == 50 && b == 16)
		{
			return 34;
		}
		else if(a == 50 && b == 17)
		{
			return 33;
		}
		else if(a == 50 && b == 18)
		{
			return 32;
		}
		else if(a == 50 && b == 19)
		{
			return 31;
		}
		else if(a == 50 && b == 20)
		{
			return 30;
		}
		else if(a == 50 && b == 21)
		{
			return 29;
		}
		else if(a == 50 && b == 22)
		{
			return 28;
		}
		else if(a == 50 && b == 23)
		{
			return 27;
		}
		else if(a == 50 && b == 24)
		{
			return 26;
		}
		else if(a == 50 && b == 25)
		{
			return 25;
		}
		else if(a == 50 && b == 26)
		{
			return 24;
		}
		else if(a == 50 && b == 27)
		{
			return 23;
		}
		else if(a == 50 && b == 28)
		{
			return 22;
		}
		else if(a == 50 && b == 29)
		{
			return 21;
		}
		else if(a == 50 && b == 30)
		{
			return 20;
		}
		else if(a == 50 && b == 31)
		{
			return 19;
		}
		else if(a == 50 && b == 32)
		{
			return 18;
		}
		else if(a == 50 && b == 33)
		{
			return 17;
		}
		else if(a == 50 && b == 34)
		{
			return 16;
		}
		else if(a == 50 && b == 35)
		{
			return 15;
		}
		else if(a == 50 && b == 36)
		{
			return 14;
		}
		else if(a == 50 && b == 37)
		{
			return 13;
		}
		else if(a == 50 && b == 38)
		{
			return 12;
		}
		else if(a == 50 && b == 39)
		{
			return 11;
		}
		else if(a == 50 && b == 40)
		{
			return 10;
		}
		else if(a == 50 && b == 41)
		{
			return 9;
		}
		else if(a == 50 && b == 42)
		{
			return 8;
		}
		else if(a == 50 && b == 43)
		{
			return 7;
		}
		else if(a == 50 && b == 44)
		{
			return 6;
		}
		else if(a == 50 && b == 45)
		{
			return 5;
		}
		else if(a == 50 && b == 46)
		{
			return 4;
		}
		else if(a == 50 && b == 47)
		{
			return 3;
		}
		else if(a == 50 && b == 48)
		{
			return 2;
		}
		else if(a == 50 && b == 49)
		{
			return 1;
		}
		else if(a == 50 && b == 50)
		{
			return 0;
		}
		else if(a == 50 && b == 51)
		{
			return -1;
		}
		else if(a == 50 && b == 52)
		{
			return -2;
		}
		else if(a == 50 && b == 53)
		{
			return -3;
		}
		else if(a == 50 && b == 54)
		{
			return -4;
		}
		else if(a == 50 && b == 55)
		{
			return -5;
		}
		else if(a == 50 && b == 56)
		{
			return -6;
		}
		else if(a == 50 && b == 57)
		{
			return -7;
		}
		else if(a == 50 && b == 58)
		{
			return -8;
		}
		else if(a == 50 && b == 59)
		{
			return -9;
		}
		else if(a == 50 && b == 60)
		{
			return -10;
		}
		else if(a == 50 && b == 61)
		{
			return -11;
		}
		else if(a == 50 && b == 62)
		{
			return -12;
		}
		else if(a == 50 && b == 63)
		{
			return -13;
		}
		else if(a == 50 && b == 64)
		{
			return -14;
		}
		else if(a == 50 && b == 65)
		{
			return -15;
		}
		else if(a == 50 && b == 66)
		{
			return -16;
		}
		else if(a == 50 && b == 67)
		{
			return -17;
		}
		else if(a == 50 && b == 68)
		{
			return -18;
		}
		else if(a == 50 && b == 69)
		{
			return -19;
		}
		else if(a == 50 && b == 70)
		{
			return -20;
		}
		else if(a == 50 && b == 71)
		{
			return -21;
		}
		else if(a == 50 && b == 72)
		{
			return -22;
		}
		else if(a == 50 && b == 73)
		{
			return -23;
		}
		else if(a == 50 && b == 74)
		{
			return -24;
		}
		else if(a == 50 && b == 75)
		{
			return -25;
		}
		else if(a == 50 && b == 76)
		{
			return -26;
		}
		else if(a == 50 && b == 77)
		{
			return -27;
		}
		else if(a == 50 && b == 78)
		{
			return -28;
		}
		else if(a == 50 && b == 79)
		{
			return -29;
		}
		else if(a == 50 && b == 80)
		{
			return -30;
		}
		else if(a == 50 && b == 81)
		{
			return -31;
		}
		else if(a == 50 && b == 82)
		{
			return -32;
		}
		else if(a == 50 && b == 83)
		{
			return -33;
		}
		else if(a == 50 && b == 84)
		{
			return -34;
		}
		else if(a == 50 && b == 85)
		{
			return -35;
		}
		else if(a == 50 && b == 86)
		{
			return -36;
		}
		else if(a == 50 && b == 87)
		{
			return -37;
		}
		else if(a == 50 && b == 88)
		{
			return -38;
		}
		else if(a == 50 && b == 89)
		{
			return -39;
		}
		else if(a == 50 && b == 90)
		{
			return -40;
		}
		else if(a == 50 && b == 91)
		{
			return -41;
		}
		else if(a == 50 && b == 92)
		{
			return -42;
		}
		else if(a == 50 && b == 93)
		{
			return -43;
		}
		else if(a == 50 && b == 94)
		{
			return -44;
		}
		else if(a == 50 && b == 95)
		{
			return -45;
		}
		else if(a == 50 && b == 96)
		{
			return -46;
		}
		else if(a == 50 && b == 97)
		{
			return -47;
		}
		else if(a == 50 && b == 98)
		{
			return -48;
		}
		else if(a == 50 && b == 99)
		{
			return -49;
		}
		else if(a == 50 && b == 100)
		{
			return -50;
		}
		else if(a == 51 && b == 0)
		{
			return 51;
		}
		else if(a == 51 && b == 1)
		{
			return 50;
		}
		else if(a == 51 && b == 2)
		{
			return 49;
		}
		else if(a == 51 && b == 3)
		{
			return 48;
		}
		else if(a == 51 && b == 4)
		{
			return 47;
		}
		else if(a == 51 && b == 5)
		{
			return 46;
		}
		else if(a == 51 && b == 6)
		{
			return 45;
		}
		else if(a == 51 && b == 7)
		{
			return 44;
		}
		else if(a == 51 && b == 8)
		{
			return 43;
		}
		else if(a == 51 && b == 9)
		{
			return 42;
		}
		else if(a == 51 && b == 10)
		{
			return 41;
		}
		else if(a == 51 && b == 11)
		{
			return 40;
		}
		else if(a == 51 && b == 12)
		{
			return 39;
		}
		else if(a == 51 && b == 13)
		{
			return 38;
		}
		else if(a == 51 && b == 14)
		{
			return 37;
		}
		else if(a == 51 && b == 15)
		{
			return 36;
		}
		else if(a == 51 && b == 16)
		{
			return 35;
		}
		else if(a == 51 && b == 17)
		{
			return 34;
		}
		else if(a == 51 && b == 18)
		{
			return 33;
		}
		else if(a == 51 && b == 19)
		{
			return 32;
		}
		else if(a == 51 && b == 20)
		{
			return 31;
		}
		else if(a == 51 && b == 21)
		{
			return 30;
		}
		else if(a == 51 && b == 22)
		{
			return 29;
		}
		else if(a == 51 && b == 23)
		{
			return 28;
		}
		else if(a == 51 && b == 24)
		{
			return 27;
		}
		else if(a == 51 && b == 25)
		{
			return 26;
		}
		else if(a == 51 && b == 26)
		{
			return 25;
		}
		else if(a == 51 && b == 27)
		{
			return 24;
		}
		else if(a == 51 && b == 28)
		{
			return 23;
		}
		else if(a == 51 && b == 29)
		{
			return 22;
		}
		else if(a == 51 && b == 30)
		{
			return 21;
		}
		else if(a == 51 && b == 31)
		{
			return 20;
		}
		else if(a == 51 && b == 32)
		{
			return 19;
		}
		else if(a == 51 && b == 33)
		{
			return 18;
		}
		else if(a == 51 && b == 34)
		{
			return 17;
		}
		else if(a == 51 && b == 35)
		{
			return 16;
		}
		else if(a == 51 && b == 36)
		{
			return 15;
		}
		else if(a == 51 && b == 37)
		{
			return 14;
		}
		else if(a == 51 && b == 38)
		{
			return 13;
		}
		else if(a == 51 && b == 39)
		{
			return 12;
		}
		else if(a == 51 && b == 40)
		{
			return 11;
		}
		else if(a == 51 && b == 41)
		{
			return 10;
		}
		else if(a == 51 && b == 42)
		{
			return 9;
		}
		else if(a == 51 && b == 43)
		{
			return 8;
		}
		else if(a == 51 && b == 44)
		{
			return 7;
		}
		else if(a == 51 && b == 45)
		{
			return 6;
		}
		else if(a == 51 && b == 46)
		{
			return 5;
		}
		else if(a == 51 && b == 47)
		{
			return 4;
		}
		else if(a == 51 && b == 48)
		{
			return 3;
		}
		else if(a == 51 && b == 49)
		{
			return 2;
		}
		else if(a == 51 && b == 50)
		{
			return 1;
		}
		else if(a == 51 && b == 51)
		{
			return 0;
		}
		else if(a == 51 && b == 52)
		{
			return -1;
		}
		else if(a == 51 && b == 53)
		{
			return -2;
		}
		else if(a == 51 && b == 54)
		{
			return -3;
		}
		else if(a == 51 && b == 55)
		{
			return -4;
		}
		else if(a == 51 && b == 56)
		{
			return -5;
		}
		else if(a == 51 && b == 57)
		{
			return -6;
		}
		else if(a == 51 && b == 58)
		{
			return -7;
		}
		else if(a == 51 && b == 59)
		{
			return -8;
		}
		else if(a == 51 && b == 60)
		{
			return -9;
		}
		else if(a == 51 && b == 61)
		{
			return -10;
		}
		else if(a == 51 && b == 62)
		{
			return -11;
		}
		else if(a == 51 && b == 63)
		{
			return -12;
		}
		else if(a == 51 && b == 64)
		{
			return -13;
		}
		else if(a == 51 && b == 65)
		{
			return -14;
		}
		else if(a == 51 && b == 66)
		{
			return -15;
		}
		else if(a == 51 && b == 67)
		{
			return -16;
		}
		else if(a == 51 && b == 68)
		{
			return -17;
		}
		else if(a == 51 && b == 69)
		{
			return -18;
		}
		else if(a == 51 && b == 70)
		{
			return -19;
		}
		else if(a == 51 && b == 71)
		{
			return -20;
		}
		else if(a == 51 && b == 72)
		{
			return -21;
		}
		else if(a == 51 && b == 73)
		{
			return -22;
		}
		else if(a == 51 && b == 74)
		{
			return -23;
		}
		else if(a == 51 && b == 75)
		{
			return -24;
		}
		else if(a == 51 && b == 76)
		{
			return -25;
		}
		else if(a == 51 && b == 77)
		{
			return -26;
		}
		else if(a == 51 && b == 78)
		{
			return -27;
		}
		else if(a == 51 && b == 79)
		{
			return -28;
		}
		else if(a == 51 && b == 80)
		{
			return -29;
		}
		else if(a == 51 && b == 81)
		{
			return -30;
		}
		else if(a == 51 && b == 82)
		{
			return -31;
		}
		else if(a == 51 && b == 83)
		{
			return -32;
		}
		else if(a == 51 && b == 84)
		{
			return -33;
		}
		else if(a == 51 && b == 85)
		{
			return -34;
		}
		else if(a == 51 && b == 86)
		{
			return -35;
		}
		else if(a == 51 && b == 87)
		{
			return -36;
		}
		else if(a == 51 && b == 88)
		{
			return -37;
		}
		else if(a == 51 && b == 89)
		{
			return -38;
		}
		else if(a == 51 && b == 90)
		{
			return -39;
		}
		else if(a == 51 && b == 91)
		{
			return -40;
		}
		else if(a == 51 && b == 92)
		{
			return -41;
		}
		else if(a == 51 && b == 93)
		{
			return -42;
		}
		else if(a == 51 && b == 94)
		{
			return -43;
		}
		else if(a == 51 && b == 95)
		{
			return -44;
		}
		else if(a == 51 && b == 96)
		{
			return -45;
		}
		else if(a == 51 && b == 97)
		{
			return -46;
		}
		else if(a == 51 && b == 98)
		{
			return -47;
		}
		else if(a == 51 && b == 99)
		{
			return -48;
		}
		else if(a == 51 && b == 100)
		{
			return -49;
		}
		else if(a == 52 && b == 0)
		{
			return 52;
		}
		else if(a == 52 && b == 1)
		{
			return 51;
		}
		else if(a == 52 && b == 2)
		{
			return 50;
		}
		else if(a == 52 && b == 3)
		{
			return 49;
		}
		else if(a == 52 && b == 4)
		{
			return 48;
		}
		else if(a == 52 && b == 5)
		{
			return 47;
		}
		else if(a == 52 && b == 6)
		{
			return 46;
		}
		else if(a == 52 && b == 7)
		{
			return 45;
		}
		else if(a == 52 && b == 8)
		{
			return 44;
		}
		else if(a == 52 && b == 9)
		{
			return 43;
		}
		else if(a == 52 && b == 10)
		{
			return 42;
		}
		else if(a == 52 && b == 11)
		{
			return 41;
		}
		else if(a == 52 && b == 12)
		{
			return 40;
		}
		else if(a == 52 && b == 13)
		{
			return 39;
		}
		else if(a == 52 && b == 14)
		{
			return 38;
		}
		else if(a == 52 && b == 15)
		{
			return 37;
		}
		else if(a == 52 && b == 16)
		{
			return 36;
		}
		else if(a == 52 && b == 17)
		{
			return 35;
		}
		else if(a == 52 && b == 18)
		{
			return 34;
		}
		else if(a == 52 && b == 19)
		{
			return 33;
		}
		else if(a == 52 && b == 20)
		{
			return 32;
		}
		else if(a == 52 && b == 21)
		{
			return 31;
		}
		else if(a == 52 && b == 22)
		{
			return 30;
		}
		else if(a == 52 && b == 23)
		{
			return 29;
		}
		else if(a == 52 && b == 24)
		{
			return 28;
		}
		else if(a == 52 && b == 25)
		{
			return 27;
		}
		else if(a == 52 && b == 26)
		{
			return 26;
		}
		else if(a == 52 && b == 27)
		{
			return 25;
		}
		else if(a == 52 && b == 28)
		{
			return 24;
		}
		else if(a == 52 && b == 29)
		{
			return 23;
		}
		else if(a == 52 && b == 30)
		{
			return 22;
		}
		else if(a == 52 && b == 31)
		{
			return 21;
		}
		else if(a == 52 && b == 32)
		{
			return 20;
		}
		else if(a == 52 && b == 33)
		{
			return 19;
		}
		else if(a == 52 && b == 34)
		{
			return 18;
		}
		else if(a == 52 && b == 35)
		{
			return 17;
		}
		else if(a == 52 && b == 36)
		{
			return 16;
		}
		else if(a == 52 && b == 37)
		{
			return 15;
		}
		else if(a == 52 && b == 38)
		{
			return 14;
		}
		else if(a == 52 && b == 39)
		{
			return 13;
		}
		else if(a == 52 && b == 40)
		{
			return 12;
		}
		else if(a == 52 && b == 41)
		{
			return 11;
		}
		else if(a == 52 && b == 42)
		{
			return 10;
		}
		else if(a == 52 && b == 43)
		{
			return 9;
		}
		else if(a == 52 && b == 44)
		{
			return 8;
		}
		else if(a == 52 && b == 45)
		{
			return 7;
		}
		else if(a == 52 && b == 46)
		{
			return 6;
		}
		else if(a == 52 && b == 47)
		{
			return 5;
		}
		else if(a == 52 && b == 48)
		{
			return 4;
		}
		else if(a == 52 && b == 49)
		{
			return 3;
		}
		else if(a == 52 && b == 50)
		{
			return 2;
		}
		else if(a == 52 && b == 51)
		{
			return 1;
		}
		else if(a == 52 && b == 52)
		{
			return 0;
		}
		else if(a == 52 && b == 53)
		{
			return -1;
		}
		else if(a == 52 && b == 54)
		{
			return -2;
		}
		else if(a == 52 && b == 55)
		{
			return -3;
		}
		else if(a == 52 && b == 56)
		{
			return -4;
		}
		else if(a == 52 && b == 57)
		{
			return -5;
		}
		else if(a == 52 && b == 58)
		{
			return -6;
		}
		else if(a == 52 && b == 59)
		{
			return -7;
		}
		else if(a == 52 && b == 60)
		{
			return -8;
		}
		else if(a == 52 && b == 61)
		{
			return -9;
		}
		else if(a == 52 && b == 62)
		{
			return -10;
		}
		else if(a == 52 && b == 63)
		{
			return -11;
		}
		else if(a == 52 && b == 64)
		{
			return -12;
		}
		else if(a == 52 && b == 65)
		{
			return -13;
		}
		else if(a == 52 && b == 66)
		{
			return -14;
		}
		else if(a == 52 && b == 67)
		{
			return -15;
		}
		else if(a == 52 && b == 68)
		{
			return -16;
		}
		else if(a == 52 && b == 69)
		{
			return -17;
		}
		else if(a == 52 && b == 70)
		{
			return -18;
		}
		else if(a == 52 && b == 71)
		{
			return -19;
		}
		else if(a == 52 && b == 72)
		{
			return -20;
		}
		else if(a == 52 && b == 73)
		{
			return -21;
		}
		else if(a == 52 && b == 74)
		{
			return -22;
		}
		else if(a == 52 && b == 75)
		{
			return -23;
		}
		else if(a == 52 && b == 76)
		{
			return -24;
		}
		else if(a == 52 && b == 77)
		{
			return -25;
		}
		else if(a == 52 && b == 78)
		{
			return -26;
		}
		else if(a == 52 && b == 79)
		{
			return -27;
		}
		else if(a == 52 && b == 80)
		{
			return -28;
		}
		else if(a == 52 && b == 81)
		{
			return -29;
		}
		else if(a == 52 && b == 82)
		{
			return -30;
		}
		else if(a == 52 && b == 83)
		{
			return -31;
		}
		else if(a == 52 && b == 84)
		{
			return -32;
		}
		else if(a == 52 && b == 85)
		{
			return -33;
		}
		else if(a == 52 && b == 86)
		{
			return -34;
		}
		else if(a == 52 && b == 87)
		{
			return -35;
		}
		else if(a == 52 && b == 88)
		{
			return -36;
		}
		else if(a == 52 && b == 89)
		{
			return -37;
		}
		else if(a == 52 && b == 90)
		{
			return -38;
		}
		else if(a == 52 && b == 91)
		{
			return -39;
		}
		else if(a == 52 && b == 92)
		{
			return -40;
		}
		else if(a == 52 && b == 93)
		{
			return -41;
		}
		else if(a == 52 && b == 94)
		{
			return -42;
		}
		else if(a == 52 && b == 95)
		{
			return -43;
		}
		else if(a == 52 && b == 96)
		{
			return -44;
		}
		else if(a == 52 && b == 97)
		{
			return -45;
		}
		else if(a == 52 && b == 98)
		{
			return -46;
		}
		else if(a == 52 && b == 99)
		{
			return -47;
		}
		else if(a == 52 && b == 100)
		{
			return -48;
		}
		else if(a == 53 && b == 0)
		{
			return 53;
		}
		else if(a == 53 && b == 1)
		{
			return 52;
		}
		else if(a == 53 && b == 2)
		{
			return 51;
		}
		else if(a == 53 && b == 3)
		{
			return 50;
		}
		else if(a == 53 && b == 4)
		{
			return 49;
		}
		else if(a == 53 && b == 5)
		{
			return 48;
		}
		else if(a == 53 && b == 6)
		{
			return 47;
		}
		else if(a == 53 && b == 7)
		{
			return 46;
		}
		else if(a == 53 && b == 8)
		{
			return 45;
		}
		else if(a == 53 && b == 9)
		{
			return 44;
		}
		else if(a == 53 && b == 10)
		{
			return 43;
		}
		else if(a == 53 && b == 11)
		{
			return 42;
		}
		else if(a == 53 && b == 12)
		{
			return 41;
		}
		else if(a == 53 && b == 13)
		{
			return 40;
		}
		else if(a == 53 && b == 14)
		{
			return 39;
		}
		else if(a == 53 && b == 15)
		{
			return 38;
		}
		else if(a == 53 && b == 16)
		{
			return 37;
		}
		else if(a == 53 && b == 17)
		{
			return 36;
		}
		else if(a == 53 && b == 18)
		{
			return 35;
		}
		else if(a == 53 && b == 19)
		{
			return 34;
		}
		else if(a == 53 && b == 20)
		{
			return 33;
		}
		else if(a == 53 && b == 21)
		{
			return 32;
		}
		else if(a == 53 && b == 22)
		{
			return 31;
		}
		else if(a == 53 && b == 23)
		{
			return 30;
		}
		else if(a == 53 && b == 24)
		{
			return 29;
		}
		else if(a == 53 && b == 25)
		{
			return 28;
		}
		else if(a == 53 && b == 26)
		{
			return 27;
		}
		else if(a == 53 && b == 27)
		{
			return 26;
		}
		else if(a == 53 && b == 28)
		{
			return 25;
		}
		else if(a == 53 && b == 29)
		{
			return 24;
		}
		else if(a == 53 && b == 30)
		{
			return 23;
		}
		else if(a == 53 && b == 31)
		{
			return 22;
		}
		else if(a == 53 && b == 32)
		{
			return 21;
		}
		else if(a == 53 && b == 33)
		{
			return 20;
		}
		else if(a == 53 && b == 34)
		{
			return 19;
		}
		else if(a == 53 && b == 35)
		{
			return 18;
		}
		else if(a == 53 && b == 36)
		{
			return 17;
		}
		else if(a == 53 && b == 37)
		{
			return 16;
		}
		else if(a == 53 && b == 38)
		{
			return 15;
		}
		else if(a == 53 && b == 39)
		{
			return 14;
		}
		else if(a == 53 && b == 40)
		{
			return 13;
		}
		else if(a == 53 && b == 41)
		{
			return 12;
		}
		else if(a == 53 && b == 42)
		{
			return 11;
		}
		else if(a == 53 && b == 43)
		{
			return 10;
		}
		else if(a == 53 && b == 44)
		{
			return 9;
		}
		else if(a == 53 && b == 45)
		{
			return 8;
		}
		else if(a == 53 && b == 46)
		{
			return 7;
		}
		else if(a == 53 && b == 47)
		{
			return 6;
		}
		else if(a == 53 && b == 48)
		{
			return 5;
		}
		else if(a == 53 && b == 49)
		{
			return 4;
		}
		else if(a == 53 && b == 50)
		{
			return 3;
		}
		else if(a == 53 && b == 51)
		{
			return 2;
		}
		else if(a == 53 && b == 52)
		{
			return 1;
		}
		else if(a == 53 && b == 53)
		{
			return 0;
		}
		else if(a == 53 && b == 54)
		{
			return -1;
		}
		else if(a == 53 && b == 55)
		{
			return -2;
		}
		else if(a == 53 && b == 56)
		{
			return -3;
		}
		else if(a == 53 && b == 57)
		{
			return -4;
		}
		else if(a == 53 && b == 58)
		{
			return -5;
		}
		else if(a == 53 && b == 59)
		{
			return -6;
		}
		else if(a == 53 && b == 60)
		{
			return -7;
		}
		else if(a == 53 && b == 61)
		{
			return -8;
		}
		else if(a == 53 && b == 62)
		{
			return -9;
		}
		else if(a == 53 && b == 63)
		{
			return -10;
		}
		else if(a == 53 && b == 64)
		{
			return -11;
		}
		else if(a == 53 && b == 65)
		{
			return -12;
		}
		else if(a == 53 && b == 66)
		{
			return -13;
		}
		else if(a == 53 && b == 67)
		{
			return -14;
		}
		else if(a == 53 && b == 68)
		{
			return -15;
		}
		else if(a == 53 && b == 69)
		{
			return -16;
		}
		else if(a == 53 && b == 70)
		{
			return -17;
		}
		else if(a == 53 && b == 71)
		{
			return -18;
		}
		else if(a == 53 && b == 72)
		{
			return -19;
		}
		else if(a == 53 && b == 73)
		{
			return -20;
		}
		else if(a == 53 && b == 74)
		{
			return -21;
		}
		else if(a == 53 && b == 75)
		{
			return -22;
		}
		else if(a == 53 && b == 76)
		{
			return -23;
		}
		else if(a == 53 && b == 77)
		{
			return -24;
		}
		else if(a == 53 && b == 78)
		{
			return -25;
		}
		else if(a == 53 && b == 79)
		{
			return -26;
		}
		else if(a == 53 && b == 80)
		{
			return -27;
		}
		else if(a == 53 && b == 81)
		{
			return -28;
		}
		else if(a == 53 && b == 82)
		{
			return -29;
		}
		else if(a == 53 && b == 83)
		{
			return -30;
		}
		else if(a == 53 && b == 84)
		{
			return -31;
		}
		else if(a == 53 && b == 85)
		{
			return -32;
		}
		else if(a == 53 && b == 86)
		{
			return -33;
		}
		else if(a == 53 && b == 87)
		{
			return -34;
		}
		else if(a == 53 && b == 88)
		{
			return -35;
		}
		else if(a == 53 && b == 89)
		{
			return -36;
		}
		else if(a == 53 && b == 90)
		{
			return -37;
		}
		else if(a == 53 && b == 91)
		{
			return -38;
		}
		else if(a == 53 && b == 92)
		{
			return -39;
		}
		else if(a == 53 && b == 93)
		{
			return -40;
		}
		else if(a == 53 && b == 94)
		{
			return -41;
		}
		else if(a == 53 && b == 95)
		{
			return -42;
		}
		else if(a == 53 && b == 96)
		{
			return -43;
		}
		else if(a == 53 && b == 97)
		{
			return -44;
		}
		else if(a == 53 && b == 98)
		{
			return -45;
		}
		else if(a == 53 && b == 99)
		{
			return -46;
		}
		else if(a == 53 && b == 100)
		{
			return -47;
		}
		else if(a == 54 && b == 0)
		{
			return 54;
		}
		else if(a == 54 && b == 1)
		{
			return 53;
		}
		else if(a == 54 && b == 2)
		{
			return 52;
		}
		else if(a == 54 && b == 3)
		{
			return 51;
		}
		else if(a == 54 && b == 4)
		{
			return 50;
		}
		else if(a == 54 && b == 5)
		{
			return 49;
		}
		else if(a == 54 && b == 6)
		{
			return 48;
		}
		else if(a == 54 && b == 7)
		{
			return 47;
		}
		else if(a == 54 && b == 8)
		{
			return 46;
		}
		else if(a == 54 && b == 9)
		{
			return 45;
		}
		else if(a == 54 && b == 10)
		{
			return 44;
		}
		else if(a == 54 && b == 11)
		{
			return 43;
		}
		else if(a == 54 && b == 12)
		{
			return 42;
		}
		else if(a == 54 && b == 13)
		{
			return 41;
		}
		else if(a == 54 && b == 14)
		{
			return 40;
		}
		else if(a == 54 && b == 15)
		{
			return 39;
		}
		else if(a == 54 && b == 16)
		{
			return 38;
		}
		else if(a == 54 && b == 17)
		{
			return 37;
		}
		else if(a == 54 && b == 18)
		{
			return 36;
		}
		else if(a == 54 && b == 19)
		{
			return 35;
		}
		else if(a == 54 && b == 20)
		{
			return 34;
		}
		else if(a == 54 && b == 21)
		{
			return 33;
		}
		else if(a == 54 && b == 22)
		{
			return 32;
		}
		else if(a == 54 && b == 23)
		{
			return 31;
		}
		else if(a == 54 && b == 24)
		{
			return 30;
		}
		else if(a == 54 && b == 25)
		{
			return 29;
		}
		else if(a == 54 && b == 26)
		{
			return 28;
		}
		else if(a == 54 && b == 27)
		{
			return 27;
		}
		else if(a == 54 && b == 28)
		{
			return 26;
		}
		else if(a == 54 && b == 29)
		{
			return 25;
		}
		else if(a == 54 && b == 30)
		{
			return 24;
		}
		else if(a == 54 && b == 31)
		{
			return 23;
		}
		else if(a == 54 && b == 32)
		{
			return 22;
		}
		else if(a == 54 && b == 33)
		{
			return 21;
		}
		else if(a == 54 && b == 34)
		{
			return 20;
		}
		else if(a == 54 && b == 35)
		{
			return 19;
		}
		else if(a == 54 && b == 36)
		{
			return 18;
		}
		else if(a == 54 && b == 37)
		{
			return 17;
		}
		else if(a == 54 && b == 38)
		{
			return 16;
		}
		else if(a == 54 && b == 39)
		{
			return 15;
		}
		else if(a == 54 && b == 40)
		{
			return 14;
		}
		else if(a == 54 && b == 41)
		{
			return 13;
		}
		else if(a == 54 && b == 42)
		{
			return 12;
		}
		else if(a == 54 && b == 43)
		{
			return 11;
		}
		else if(a == 54 && b == 44)
		{
			return 10;
		}
		else if(a == 54 && b == 45)
		{
			return 9;
		}
		else if(a == 54 && b == 46)
		{
			return 8;
		}
		else if(a == 54 && b == 47)
		{
			return 7;
		}
		else if(a == 54 && b == 48)
		{
			return 6;
		}
		else if(a == 54 && b == 49)
		{
			return 5;
		}
		else if(a == 54 && b == 50)
		{
			return 4;
		}
		else if(a == 54 && b == 51)
		{
			return 3;
		}
		else if(a == 54 && b == 52)
		{
			return 2;
		}
		else if(a == 54 && b == 53)
		{
			return 1;
		}
		else if(a == 54 && b == 54)
		{
			return 0;
		}
		else if(a == 54 && b == 55)
		{
			return -1;
		}
		else if(a == 54 && b == 56)
		{
			return -2;
		}
		else if(a == 54 && b == 57)
		{
			return -3;
		}
		else if(a == 54 && b == 58)
		{
			return -4;
		}
		else if(a == 54 && b == 59)
		{
			return -5;
		}
		else if(a == 54 && b == 60)
		{
			return -6;
		}
		else if(a == 54 && b == 61)
		{
			return -7;
		}
		else if(a == 54 && b == 62)
		{
			return -8;
		}
		else if(a == 54 && b == 63)
		{
			return -9;
		}
		else if(a == 54 && b == 64)
		{
			return -10;
		}
		else if(a == 54 && b == 65)
		{
			return -11;
		}
		else if(a == 54 && b == 66)
		{
			return -12;
		}
		else if(a == 54 && b == 67)
		{
			return -13;
		}
		else if(a == 54 && b == 68)
		{
			return -14;
		}
		else if(a == 54 && b == 69)
		{
			return -15;
		}
		else if(a == 54 && b == 70)
		{
			return -16;
		}
		else if(a == 54 && b == 71)
		{
			return -17;
		}
		else if(a == 54 && b == 72)
		{
			return -18;
		}
		else if(a == 54 && b == 73)
		{
			return -19;
		}
		else if(a == 54 && b == 74)
		{
			return -20;
		}
		else if(a == 54 && b == 75)
		{
			return -21;
		}
		else if(a == 54 && b == 76)
		{
			return -22;
		}
		else if(a == 54 && b == 77)
		{
			return -23;
		}
		else if(a == 54 && b == 78)
		{
			return -24;
		}
		else if(a == 54 && b == 79)
		{
			return -25;
		}
		else if(a == 54 && b == 80)
		{
			return -26;
		}
		else if(a == 54 && b == 81)
		{
			return -27;
		}
		else if(a == 54 && b == 82)
		{
			return -28;
		}
		else if(a == 54 && b == 83)
		{
			return -29;
		}
		else if(a == 54 && b == 84)
		{
			return -30;
		}
		else if(a == 54 && b == 85)
		{
			return -31;
		}
		else if(a == 54 && b == 86)
		{
			return -32;
		}
		else if(a == 54 && b == 87)
		{
			return -33;
		}
		else if(a == 54 && b == 88)
		{
			return -34;
		}
		else if(a == 54 && b == 89)
		{
			return -35;
		}
		else if(a == 54 && b == 90)
		{
			return -36;
		}
		else if(a == 54 && b == 91)
		{
			return -37;
		}
		else if(a == 54 && b == 92)
		{
			return -38;
		}
		else if(a == 54 && b == 93)
		{
			return -39;
		}
		else if(a == 54 && b == 94)
		{
			return -40;
		}
		else if(a == 54 && b == 95)
		{
			return -41;
		}
		else if(a == 54 && b == 96)
		{
			return -42;
		}
		else if(a == 54 && b == 97)
		{
			return -43;
		}
		else if(a == 54 && b == 98)
		{
			return -44;
		}
		else if(a == 54 && b == 99)
		{
			return -45;
		}
		else if(a == 54 && b == 100)
		{
			return -46;
		}
		else if(a == 55 && b == 0)
		{
			return 55;
		}
		else if(a == 55 && b == 1)
		{
			return 54;
		}
		else if(a == 55 && b == 2)
		{
			return 53;
		}
		else if(a == 55 && b == 3)
		{
			return 52;
		}
		else if(a == 55 && b == 4)
		{
			return 51;
		}
		else if(a == 55 && b == 5)
		{
			return 50;
		}
		else if(a == 55 && b == 6)
		{
			return 49;
		}
		else if(a == 55 && b == 7)
		{
			return 48;
		}
		else if(a == 55 && b == 8)
		{
			return 47;
		}
		else if(a == 55 && b == 9)
		{
			return 46;
		}
		else if(a == 55 && b == 10)
		{
			return 45;
		}
		else if(a == 55 && b == 11)
		{
			return 44;
		}
		else if(a == 55 && b == 12)
		{
			return 43;
		}
		else if(a == 55 && b == 13)
		{
			return 42;
		}
		else if(a == 55 && b == 14)
		{
			return 41;
		}
		else if(a == 55 && b == 15)
		{
			return 40;
		}
		else if(a == 55 && b == 16)
		{
			return 39;
		}
		else if(a == 55 && b == 17)
		{
			return 38;
		}
		else if(a == 55 && b == 18)
		{
			return 37;
		}
		else if(a == 55 && b == 19)
		{
			return 36;
		}
		else if(a == 55 && b == 20)
		{
			return 35;
		}
		else if(a == 55 && b == 21)
		{
			return 34;
		}
		else if(a == 55 && b == 22)
		{
			return 33;
		}
		else if(a == 55 && b == 23)
		{
			return 32;
		}
		else if(a == 55 && b == 24)
		{
			return 31;
		}
		else if(a == 55 && b == 25)
		{
			return 30;
		}
		else if(a == 55 && b == 26)
		{
			return 29;
		}
		else if(a == 55 && b == 27)
		{
			return 28;
		}
		else if(a == 55 && b == 28)
		{
			return 27;
		}
		else if(a == 55 && b == 29)
		{
			return 26;
		}
		else if(a == 55 && b == 30)
		{
			return 25;
		}
		else if(a == 55 && b == 31)
		{
			return 24;
		}
		else if(a == 55 && b == 32)
		{
			return 23;
		}
		else if(a == 55 && b == 33)
		{
			return 22;
		}
		else if(a == 55 && b == 34)
		{
			return 21;
		}
		else if(a == 55 && b == 35)
		{
			return 20;
		}
		else if(a == 55 && b == 36)
		{
			return 19;
		}
		else if(a == 55 && b == 37)
		{
			return 18;
		}
		else if(a == 55 && b == 38)
		{
			return 17;
		}
		else if(a == 55 && b == 39)
		{
			return 16;
		}
		else if(a == 55 && b == 40)
		{
			return 15;
		}
		else if(a == 55 && b == 41)
		{
			return 14;
		}
		else if(a == 55 && b == 42)
		{
			return 13;
		}
		else if(a == 55 && b == 43)
		{
			return 12;
		}
		else if(a == 55 && b == 44)
		{
			return 11;
		}
		else if(a == 55 && b == 45)
		{
			return 10;
		}
		else if(a == 55 && b == 46)
		{
			return 9;
		}
		else if(a == 55 && b == 47)
		{
			return 8;
		}
		else if(a == 55 && b == 48)
		{
			return 7;
		}
		else if(a == 55 && b == 49)
		{
			return 6;
		}
		else if(a == 55 && b == 50)
		{
			return 5;
		}
		else if(a == 55 && b == 51)
		{
			return 4;
		}
		else if(a == 55 && b == 52)
		{
			return 3;
		}
		else if(a == 55 && b == 53)
		{
			return 2;
		}
		else if(a == 55 && b == 54)
		{
			return 1;
		}
		else if(a == 55 && b == 55)
		{
			return 0;
		}
		else if(a == 55 && b == 56)
		{
			return -1;
		}
		else if(a == 55 && b == 57)
		{
			return -2;
		}
		else if(a == 55 && b == 58)
		{
			return -3;
		}
		else if(a == 55 && b == 59)
		{
			return -4;
		}
		else if(a == 55 && b == 60)
		{
			return -5;
		}
		else if(a == 55 && b == 61)
		{
			return -6;
		}
		else if(a == 55 && b == 62)
		{
			return -7;
		}
		else if(a == 55 && b == 63)
		{
			return -8;
		}
		else if(a == 55 && b == 64)
		{
			return -9;
		}
		else if(a == 55 && b == 65)
		{
			return -10;
		}
		else if(a == 55 && b == 66)
		{
			return -11;
		}
		else if(a == 55 && b == 67)
		{
			return -12;
		}
		else if(a == 55 && b == 68)
		{
			return -13;
		}
		else if(a == 55 && b == 69)
		{
			return -14;
		}
		else if(a == 55 && b == 70)
		{
			return -15;
		}
		else if(a == 55 && b == 71)
		{
			return -16;
		}
		else if(a == 55 && b == 72)
		{
			return -17;
		}
		else if(a == 55 && b == 73)
		{
			return -18;
		}
		else if(a == 55 && b == 74)
		{
			return -19;
		}
		else if(a == 55 && b == 75)
		{
			return -20;
		}
		else if(a == 55 && b == 76)
		{
			return -21;
		}
		else if(a == 55 && b == 77)
		{
			return -22;
		}
		else if(a == 55 && b == 78)
		{
			return -23;
		}
		else if(a == 55 && b == 79)
		{
			return -24;
		}
		else if(a == 55 && b == 80)
		{
			return -25;
		}
		else if(a == 55 && b == 81)
		{
			return -26;
		}
		else if(a == 55 && b == 82)
		{
			return -27;
		}
		else if(a == 55 && b == 83)
		{
			return -28;
		}
		else if(a == 55 && b == 84)
		{
			return -29;
		}
		else if(a == 55 && b == 85)
		{
			return -30;
		}
		else if(a == 55 && b == 86)
		{
			return -31;
		}
		else if(a == 55 && b == 87)
		{
			return -32;
		}
		else if(a == 55 && b == 88)
		{
			return -33;
		}
		else if(a == 55 && b == 89)
		{
			return -34;
		}
		else if(a == 55 && b == 90)
		{
			return -35;
		}
		else if(a == 55 && b == 91)
		{
			return -36;
		}
		else if(a == 55 && b == 92)
		{
			return -37;
		}
		else if(a == 55 && b == 93)
		{
			return -38;
		}
		else if(a == 55 && b == 94)
		{
			return -39;
		}
		else if(a == 55 && b == 95)
		{
			return -40;
		}
		else if(a == 55 && b == 96)
		{
			return -41;
		}
		else if(a == 55 && b == 97)
		{
			return -42;
		}
		else if(a == 55 && b == 98)
		{
			return -43;
		}
		else if(a == 55 && b == 99)
		{
			return -44;
		}
		else if(a == 55 && b == 100)
		{
			return -45;
		}
		else if(a == 56 && b == 0)
		{
			return 56;
		}
		else if(a == 56 && b == 1)
		{
			return 55;
		}
		else if(a == 56 && b == 2)
		{
			return 54;
		}
		else if(a == 56 && b == 3)
		{
			return 53;
		}
		else if(a == 56 && b == 4)
		{
			return 52;
		}
		else if(a == 56 && b == 5)
		{
			return 51;
		}
		else if(a == 56 && b == 6)
		{
			return 50;
		}
		else if(a == 56 && b == 7)
		{
			return 49;
		}
		else if(a == 56 && b == 8)
		{
			return 48;
		}
		else if(a == 56 && b == 9)
		{
			return 47;
		}
		else if(a == 56 && b == 10)
		{
			return 46;
		}
		else if(a == 56 && b == 11)
		{
			return 45;
		}
		else if(a == 56 && b == 12)
		{
			return 44;
		}
		else if(a == 56 && b == 13)
		{
			return 43;
		}
		else if(a == 56 && b == 14)
		{
			return 42;
		}
		else if(a == 56 && b == 15)
		{
			return 41;
		}
		else if(a == 56 && b == 16)
		{
			return 40;
		}
		else if(a == 56 && b == 17)
		{
			return 39;
		}
		else if(a == 56 && b == 18)
		{
			return 38;
		}
		else if(a == 56 && b == 19)
		{
			return 37;
		}
		else if(a == 56 && b == 20)
		{
			return 36;
		}
		else if(a == 56 && b == 21)
		{
			return 35;
		}
		else if(a == 56 && b == 22)
		{
			return 34;
		}
		else if(a == 56 && b == 23)
		{
			return 33;
		}
		else if(a == 56 && b == 24)
		{
			return 32;
		}
		else if(a == 56 && b == 25)
		{
			return 31;
		}
		else if(a == 56 && b == 26)
		{
			return 30;
		}
		else if(a == 56 && b == 27)
		{
			return 29;
		}
		else if(a == 56 && b == 28)
		{
			return 28;
		}
		else if(a == 56 && b == 29)
		{
			return 27;
		}
		else if(a == 56 && b == 30)
		{
			return 26;
		}
		else if(a == 56 && b == 31)
		{
			return 25;
		}
		else if(a == 56 && b == 32)
		{
			return 24;
		}
		else if(a == 56 && b == 33)
		{
			return 23;
		}
		else if(a == 56 && b == 34)
		{
			return 22;
		}
		else if(a == 56 && b == 35)
		{
			return 21;
		}
		else if(a == 56 && b == 36)
		{
			return 20;
		}
		else if(a == 56 && b == 37)
		{
			return 19;
		}
		else if(a == 56 && b == 38)
		{
			return 18;
		}
		else if(a == 56 && b == 39)
		{
			return 17;
		}
		else if(a == 56 && b == 40)
		{
			return 16;
		}
		else if(a == 56 && b == 41)
		{
			return 15;
		}
		else if(a == 56 && b == 42)
		{
			return 14;
		}
		else if(a == 56 && b == 43)
		{
			return 13;
		}
		else if(a == 56 && b == 44)
		{
			return 12;
		}
		else if(a == 56 && b == 45)
		{
			return 11;
		}
		else if(a == 56 && b == 46)
		{
			return 10;
		}
		else if(a == 56 && b == 47)
		{
			return 9;
		}
		else if(a == 56 && b == 48)
		{
			return 8;
		}
		else if(a == 56 && b == 49)
		{
			return 7;
		}
		else if(a == 56 && b == 50)
		{
			return 6;
		}
		else if(a == 56 && b == 51)
		{
			return 5;
		}
		else if(a == 56 && b == 52)
		{
			return 4;
		}
		else if(a == 56 && b == 53)
		{
			return 3;
		}
		else if(a == 56 && b == 54)
		{
			return 2;
		}
		else if(a == 56 && b == 55)
		{
			return 1;
		}
		else if(a == 56 && b == 56)
		{
			return 0;
		}
		else if(a == 56 && b == 57)
		{
			return -1;
		}
		else if(a == 56 && b == 58)
		{
			return -2;
		}
		else if(a == 56 && b == 59)
		{
			return -3;
		}
		else if(a == 56 && b == 60)
		{
			return -4;
		}
		else if(a == 56 && b == 61)
		{
			return -5;
		}
		else if(a == 56 && b == 62)
		{
			return -6;
		}
		else if(a == 56 && b == 63)
		{
			return -7;
		}
		else if(a == 56 && b == 64)
		{
			return -8;
		}
		else if(a == 56 && b == 65)
		{
			return -9;
		}
		else if(a == 56 && b == 66)
		{
			return -10;
		}
		else if(a == 56 && b == 67)
		{
			return -11;
		}
		else if(a == 56 && b == 68)
		{
			return -12;
		}
		else if(a == 56 && b == 69)
		{
			return -13;
		}
		else if(a == 56 && b == 70)
		{
			return -14;
		}
		else if(a == 56 && b == 71)
		{
			return -15;
		}
		else if(a == 56 && b == 72)
		{
			return -16;
		}
		else if(a == 56 && b == 73)
		{
			return -17;
		}
		else if(a == 56 && b == 74)
		{
			return -18;
		}
		else if(a == 56 && b == 75)
		{
			return -19;
		}
		else if(a == 56 && b == 76)
		{
			return -20;
		}
		else if(a == 56 && b == 77)
		{
			return -21;
		}
		else if(a == 56 && b == 78)
		{
			return -22;
		}
		else if(a == 56 && b == 79)
		{
			return -23;
		}
		else if(a == 56 && b == 80)
		{
			return -24;
		}
		else if(a == 56 && b == 81)
		{
			return -25;
		}
		else if(a == 56 && b == 82)
		{
			return -26;
		}
		else if(a == 56 && b == 83)
		{
			return -27;
		}
		else if(a == 56 && b == 84)
		{
			return -28;
		}
		else if(a == 56 && b == 85)
		{
			return -29;
		}
		else if(a == 56 && b == 86)
		{
			return -30;
		}
		else if(a == 56 && b == 87)
		{
			return -31;
		}
		else if(a == 56 && b == 88)
		{
			return -32;
		}
		else if(a == 56 && b == 89)
		{
			return -33;
		}
		else if(a == 56 && b == 90)
		{
			return -34;
		}
		else if(a == 56 && b == 91)
		{
			return -35;
		}
		else if(a == 56 && b == 92)
		{
			return -36;
		}
		else if(a == 56 && b == 93)
		{
			return -37;
		}
		else if(a == 56 && b == 94)
		{
			return -38;
		}
		else if(a == 56 && b == 95)
		{
			return -39;
		}
		else if(a == 56 && b == 96)
		{
			return -40;
		}
		else if(a == 56 && b == 97)
		{
			return -41;
		}
		else if(a == 56 && b == 98)
		{
			return -42;
		}
		else if(a == 56 && b == 99)
		{
			return -43;
		}
		else if(a == 56 && b == 100)
		{
			return -44;
		}
		else if(a == 57 && b == 0)
		{
			return 57;
		}
		else if(a == 57 && b == 1)
		{
			return 56;
		}
		else if(a == 57 && b == 2)
		{
			return 55;
		}
		else if(a == 57 && b == 3)
		{
			return 54;
		}
		else if(a == 57 && b == 4)
		{
			return 53;
		}
		else if(a == 57 && b == 5)
		{
			return 52;
		}
		else if(a == 57 && b == 6)
		{
			return 51;
		}
		else if(a == 57 && b == 7)
		{
			return 50;
		}
		else if(a == 57 && b == 8)
		{
			return 49;
		}
		else if(a == 57 && b == 9)
		{
			return 48;
		}
		else if(a == 57 && b == 10)
		{
			return 47;
		}
		else if(a == 57 && b == 11)
		{
			return 46;
		}
		else if(a == 57 && b == 12)
		{
			return 45;
		}
		else if(a == 57 && b == 13)
		{
			return 44;
		}
		else if(a == 57 && b == 14)
		{
			return 43;
		}
		else if(a == 57 && b == 15)
		{
			return 42;
		}
		else if(a == 57 && b == 16)
		{
			return 41;
		}
		else if(a == 57 && b == 17)
		{
			return 40;
		}
		else if(a == 57 && b == 18)
		{
			return 39;
		}
		else if(a == 57 && b == 19)
		{
			return 38;
		}
		else if(a == 57 && b == 20)
		{
			return 37;
		}
		else if(a == 57 && b == 21)
		{
			return 36;
		}
		else if(a == 57 && b == 22)
		{
			return 35;
		}
		else if(a == 57 && b == 23)
		{
			return 34;
		}
		else if(a == 57 && b == 24)
		{
			return 33;
		}
		else if(a == 57 && b == 25)
		{
			return 32;
		}
		else if(a == 57 && b == 26)
		{
			return 31;
		}
		else if(a == 57 && b == 27)
		{
			return 30;
		}
		else if(a == 57 && b == 28)
		{
			return 29;
		}
		else if(a == 57 && b == 29)
		{
			return 28;
		}
		else if(a == 57 && b == 30)
		{
			return 27;
		}
		else if(a == 57 && b == 31)
		{
			return 26;
		}
		else if(a == 57 && b == 32)
		{
			return 25;
		}
		else if(a == 57 && b == 33)
		{
			return 24;
		}
		else if(a == 57 && b == 34)
		{
			return 23;
		}
		else if(a == 57 && b == 35)
		{
			return 22;
		}
		else if(a == 57 && b == 36)
		{
			return 21;
		}
		else if(a == 57 && b == 37)
		{
			return 20;
		}
		else if(a == 57 && b == 38)
		{
			return 19;
		}
		else if(a == 57 && b == 39)
		{
			return 18;
		}
		else if(a == 57 && b == 40)
		{
			return 17;
		}
		else if(a == 57 && b == 41)
		{
			return 16;
		}
		else if(a == 57 && b == 42)
		{
			return 15;
		}
		else if(a == 57 && b == 43)
		{
			return 14;
		}
		else if(a == 57 && b == 44)
		{
			return 13;
		}
		else if(a == 57 && b == 45)
		{
			return 12;
		}
		else if(a == 57 && b == 46)
		{
			return 11;
		}
		else if(a == 57 && b == 47)
		{
			return 10;
		}
		else if(a == 57 && b == 48)
		{
			return 9;
		}
		else if(a == 57 && b == 49)
		{
			return 8;
		}
		else if(a == 57 && b == 50)
		{
			return 7;
		}
		else if(a == 57 && b == 51)
		{
			return 6;
		}
		else if(a == 57 && b == 52)
		{
			return 5;
		}
		else if(a == 57 && b == 53)
		{
			return 4;
		}
		else if(a == 57 && b == 54)
		{
			return 3;
		}
		else if(a == 57 && b == 55)
		{
			return 2;
		}
		else if(a == 57 && b == 56)
		{
			return 1;
		}
		else if(a == 57 && b == 57)
		{
			return 0;
		}
		else if(a == 57 && b == 58)
		{
			return -1;
		}
		else if(a == 57 && b == 59)
		{
			return -2;
		}
		else if(a == 57 && b == 60)
		{
			return -3;
		}
		else if(a == 57 && b == 61)
		{
			return -4;
		}
		else if(a == 57 && b == 62)
		{
			return -5;
		}
		else if(a == 57 && b == 63)
		{
			return -6;
		}
		else if(a == 57 && b == 64)
		{
			return -7;
		}
		else if(a == 57 && b == 65)
		{
			return -8;
		}
		else if(a == 57 && b == 66)
		{
			return -9;
		}
		else if(a == 57 && b == 67)
		{
			return -10;
		}
		else if(a == 57 && b == 68)
		{
			return -11;
		}
		else if(a == 57 && b == 69)
		{
			return -12;
		}
		else if(a == 57 && b == 70)
		{
			return -13;
		}
		else if(a == 57 && b == 71)
		{
			return -14;
		}
		else if(a == 57 && b == 72)
		{
			return -15;
		}
		else if(a == 57 && b == 73)
		{
			return -16;
		}
		else if(a == 57 && b == 74)
		{
			return -17;
		}
		else if(a == 57 && b == 75)
		{
			return -18;
		}
		else if(a == 57 && b == 76)
		{
			return -19;
		}
		else if(a == 57 && b == 77)
		{
			return -20;
		}
		else if(a == 57 && b == 78)
		{
			return -21;
		}
		else if(a == 57 && b == 79)
		{
			return -22;
		}
		else if(a == 57 && b == 80)
		{
			return -23;
		}
		else if(a == 57 && b == 81)
		{
			return -24;
		}
		else if(a == 57 && b == 82)
		{
			return -25;
		}
		else if(a == 57 && b == 83)
		{
			return -26;
		}
		else if(a == 57 && b == 84)
		{
			return -27;
		}
		else if(a == 57 && b == 85)
		{
			return -28;
		}
		else if(a == 57 && b == 86)
		{
			return -29;
		}
		else if(a == 57 && b == 87)
		{
			return -30;
		}
		else if(a == 57 && b == 88)
		{
			return -31;
		}
		else if(a == 57 && b == 89)
		{
			return -32;
		}
		else if(a == 57 && b == 90)
		{
			return -33;
		}
		else if(a == 57 && b == 91)
		{
			return -34;
		}
		else if(a == 57 && b == 92)
		{
			return -35;
		}
		else if(a == 57 && b == 93)
		{
			return -36;
		}
		else if(a == 57 && b == 94)
		{
			return -37;
		}
		else if(a == 57 && b == 95)
		{
			return -38;
		}
		else if(a == 57 && b == 96)
		{
			return -39;
		}
		else if(a == 57 && b == 97)
		{
			return -40;
		}
		else if(a == 57 && b == 98)
		{
			return -41;
		}
		else if(a == 57 && b == 99)
		{
			return -42;
		}
		else if(a == 57 && b == 100)
		{
			return -43;
		}
		else if(a == 58 && b == 0)
		{
			return 58;
		}
		else if(a == 58 && b == 1)
		{
			return 57;
		}
		else if(a == 58 && b == 2)
		{
			return 56;
		}
		else if(a == 58 && b == 3)
		{
			return 55;
		}
		else if(a == 58 && b == 4)
		{
			return 54;
		}
		else if(a == 58 && b == 5)
		{
			return 53;
		}
		else if(a == 58 && b == 6)
		{
			return 52;
		}
		else if(a == 58 && b == 7)
		{
			return 51;
		}
		else if(a == 58 && b == 8)
		{
			return 50;
		}
		else if(a == 58 && b == 9)
		{
			return 49;
		}
		else if(a == 58 && b == 10)
		{
			return 48;
		}
		else if(a == 58 && b == 11)
		{
			return 47;
		}
		else if(a == 58 && b == 12)
		{
			return 46;
		}
		else if(a == 58 && b == 13)
		{
			return 45;
		}
		else if(a == 58 && b == 14)
		{
			return 44;
		}
		else if(a == 58 && b == 15)
		{
			return 43;
		}
		else if(a == 58 && b == 16)
		{
			return 42;
		}
		else if(a == 58 && b == 17)
		{
			return 41;
		}
		else if(a == 58 && b == 18)
		{
			return 40;
		}
		else if(a == 58 && b == 19)
		{
			return 39;
		}
		else if(a == 58 && b == 20)
		{
			return 38;
		}
		else if(a == 58 && b == 21)
		{
			return 37;
		}
		else if(a == 58 && b == 22)
		{
			return 36;
		}
		else if(a == 58 && b == 23)
		{
			return 35;
		}
		else if(a == 58 && b == 24)
		{
			return 34;
		}
		else if(a == 58 && b == 25)
		{
			return 33;
		}
		else if(a == 58 && b == 26)
		{
			return 32;
		}
		else if(a == 58 && b == 27)
		{
			return 31;
		}
		else if(a == 58 && b == 28)
		{
			return 30;
		}
		else if(a == 58 && b == 29)
		{
			return 29;
		}
		else if(a == 58 && b == 30)
		{
			return 28;
		}
		else if(a == 58 && b == 31)
		{
			return 27;
		}
		else if(a == 58 && b == 32)
		{
			return 26;
		}
		else if(a == 58 && b == 33)
		{
			return 25;
		}
		else if(a == 58 && b == 34)
		{
			return 24;
		}
		else if(a == 58 && b == 35)
		{
			return 23;
		}
		else if(a == 58 && b == 36)
		{
			return 22;
		}
		else if(a == 58 && b == 37)
		{
			return 21;
		}
		else if(a == 58 && b == 38)
		{
			return 20;
		}
		else if(a == 58 && b == 39)
		{
			return 19;
		}
		else if(a == 58 && b == 40)
		{
			return 18;
		}
		else if(a == 58 && b == 41)
		{
			return 17;
		}
		else if(a == 58 && b == 42)
		{
			return 16;
		}
		else if(a == 58 && b == 43)
		{
			return 15;
		}
		else if(a == 58 && b == 44)
		{
			return 14;
		}
		else if(a == 58 && b == 45)
		{
			return 13;
		}
		else if(a == 58 && b == 46)
		{
			return 12;
		}
		else if(a == 58 && b == 47)
		{
			return 11;
		}
		else if(a == 58 && b == 48)
		{
			return 10;
		}
		else if(a == 58 && b == 49)
		{
			return 9;
		}
		else if(a == 58 && b == 50)
		{
			return 8;
		}
		else if(a == 58 && b == 51)
		{
			return 7;
		}
		else if(a == 58 && b == 52)
		{
			return 6;
		}
		else if(a == 58 && b == 53)
		{
			return 5;
		}
		else if(a == 58 && b == 54)
		{
			return 4;
		}
		else if(a == 58 && b == 55)
		{
			return 3;
		}
		else if(a == 58 && b == 56)
		{
			return 2;
		}
		else if(a == 58 && b == 57)
		{
			return 1;
		}
		else if(a == 58 && b == 58)
		{
			return 0;
		}
		else if(a == 58 && b == 59)
		{
			return -1;
		}
		else if(a == 58 && b == 60)
		{
			return -2;
		}
		else if(a == 58 && b == 61)
		{
			return -3;
		}
		else if(a == 58 && b == 62)
		{
			return -4;
		}
		else if(a == 58 && b == 63)
		{
			return -5;
		}
		else if(a == 58 && b == 64)
		{
			return -6;
		}
		else if(a == 58 && b == 65)
		{
			return -7;
		}
		else if(a == 58 && b == 66)
		{
			return -8;
		}
		else if(a == 58 && b == 67)
		{
			return -9;
		}
		else if(a == 58 && b == 68)
		{
			return -10;
		}
		else if(a == 58 && b == 69)
		{
			return -11;
		}
		else if(a == 58 && b == 70)
		{
			return -12;
		}
		else if(a == 58 && b == 71)
		{
			return -13;
		}
		else if(a == 58 && b == 72)
		{
			return -14;
		}
		else if(a == 58 && b == 73)
		{
			return -15;
		}
		else if(a == 58 && b == 74)
		{
			return -16;
		}
		else if(a == 58 && b == 75)
		{
			return -17;
		}
		else if(a == 58 && b == 76)
		{
			return -18;
		}
		else if(a == 58 && b == 77)
		{
			return -19;
		}
		else if(a == 58 && b == 78)
		{
			return -20;
		}
		else if(a == 58 && b == 79)
		{
			return -21;
		}
		else if(a == 58 && b == 80)
		{
			return -22;
		}
		else if(a == 58 && b == 81)
		{
			return -23;
		}
		else if(a == 58 && b == 82)
		{
			return -24;
		}
		else if(a == 58 && b == 83)
		{
			return -25;
		}
		else if(a == 58 && b == 84)
		{
			return -26;
		}
		else if(a == 58 && b == 85)
		{
			return -27;
		}
		else if(a == 58 && b == 86)
		{
			return -28;
		}
		else if(a == 58 && b == 87)
		{
			return -29;
		}
		else if(a == 58 && b == 88)
		{
			return -30;
		}
		else if(a == 58 && b == 89)
		{
			return -31;
		}
		else if(a == 58 && b == 90)
		{
			return -32;
		}
		else if(a == 58 && b == 91)
		{
			return -33;
		}
		else if(a == 58 && b == 92)
		{
			return -34;
		}
		else if(a == 58 && b == 93)
		{
			return -35;
		}
		else if(a == 58 && b == 94)
		{
			return -36;
		}
		else if(a == 58 && b == 95)
		{
			return -37;
		}
		else if(a == 58 && b == 96)
		{
			return -38;
		}
		else if(a == 58 && b == 97)
		{
			return -39;
		}
		else if(a == 58 && b == 98)
		{
			return -40;
		}
		else if(a == 58 && b == 99)
		{
			return -41;
		}
		else if(a == 58 && b == 100)
		{
			return -42;
		}
		else if(a == 59 && b == 0)
		{
			return 59;
		}
		else if(a == 59 && b == 1)
		{
			return 58;
		}
		else if(a == 59 && b == 2)
		{
			return 57;
		}
		else if(a == 59 && b == 3)
		{
			return 56;
		}
		else if(a == 59 && b == 4)
		{
			return 55;
		}
		else if(a == 59 && b == 5)
		{
			return 54;
		}
		else if(a == 59 && b == 6)
		{
			return 53;
		}
		else if(a == 59 && b == 7)
		{
			return 52;
		}
		else if(a == 59 && b == 8)
		{
			return 51;
		}
		else if(a == 59 && b == 9)
		{
			return 50;
		}
		else if(a == 59 && b == 10)
		{
			return 49;
		}
		else if(a == 59 && b == 11)
		{
			return 48;
		}
		else if(a == 59 && b == 12)
		{
			return 47;
		}
		else if(a == 59 && b == 13)
		{
			return 46;
		}
		else if(a == 59 && b == 14)
		{
			return 45;
		}
		else if(a == 59 && b == 15)
		{
			return 44;
		}
		else if(a == 59 && b == 16)
		{
			return 43;
		}
		else if(a == 59 && b == 17)
		{
			return 42;
		}
		else if(a == 59 && b == 18)
		{
			return 41;
		}
		else if(a == 59 && b == 19)
		{
			return 40;
		}
		else if(a == 59 && b == 20)
		{
			return 39;
		}
		else if(a == 59 && b == 21)
		{
			return 38;
		}
		else if(a == 59 && b == 22)
		{
			return 37;
		}
		else if(a == 59 && b == 23)
		{
			return 36;
		}
		else if(a == 59 && b == 24)
		{
			return 35;
		}
		else if(a == 59 && b == 25)
		{
			return 34;
		}
		else if(a == 59 && b == 26)
		{
			return 33;
		}
		else if(a == 59 && b == 27)
		{
			return 32;
		}
		else if(a == 59 && b == 28)
		{
			return 31;
		}
		else if(a == 59 && b == 29)
		{
			return 30;
		}
		else if(a == 59 && b == 30)
		{
			return 29;
		}
		else if(a == 59 && b == 31)
		{
			return 28;
		}
		else if(a == 59 && b == 32)
		{
			return 27;
		}
		else if(a == 59 && b == 33)
		{
			return 26;
		}
		else if(a == 59 && b == 34)
		{
			return 25;
		}
		else if(a == 59 && b == 35)
		{
			return 24;
		}
		else if(a == 59 && b == 36)
		{
			return 23;
		}
		else if(a == 59 && b == 37)
		{
			return 22;
		}
		else if(a == 59 && b == 38)
		{
			return 21;
		}
		else if(a == 59 && b == 39)
		{
			return 20;
		}
		else if(a == 59 && b == 40)
		{
			return 19;
		}
		else if(a == 59 && b == 41)
		{
			return 18;
		}
		else if(a == 59 && b == 42)
		{
			return 17;
		}
		else if(a == 59 && b == 43)
		{
			return 16;
		}
		else if(a == 59 && b == 44)
		{
			return 15;
		}
		else if(a == 59 && b == 45)
		{
			return 14;
		}
		else if(a == 59 && b == 46)
		{
			return 13;
		}
		else if(a == 59 && b == 47)
		{
			return 12;
		}
		else if(a == 59 && b == 48)
		{
			return 11;
		}
		else if(a == 59 && b == 49)
		{
			return 10;
		}
		else if(a == 59 && b == 50)
		{
			return 9;
		}
		else if(a == 59 && b == 51)
		{
			return 8;
		}
		else if(a == 59 && b == 52)
		{
			return 7;
		}
		else if(a == 59 && b == 53)
		{
			return 6;
		}
		else if(a == 59 && b == 54)
		{
			return 5;
		}
		else if(a == 59 && b == 55)
		{
			return 4;
		}
		else if(a == 59 && b == 56)
		{
			return 3;
		}
		else if(a == 59 && b == 57)
		{
			return 2;
		}
		else if(a == 59 && b == 58)
		{
			return 1;
		}
		else if(a == 59 && b == 59)
		{
			return 0;
		}
		else if(a == 59 && b == 60)
		{
			return -1;
		}
		else if(a == 59 && b == 61)
		{
			return -2;
		}
		else if(a == 59 && b == 62)
		{
			return -3;
		}
		else if(a == 59 && b == 63)
		{
			return -4;
		}
		else if(a == 59 && b == 64)
		{
			return -5;
		}
		else if(a == 59 && b == 65)
		{
			return -6;
		}
		else if(a == 59 && b == 66)
		{
			return -7;
		}
		else if(a == 59 && b == 67)
		{
			return -8;
		}
		else if(a == 59 && b == 68)
		{
			return -9;
		}
		else if(a == 59 && b == 69)
		{
			return -10;
		}
		else if(a == 59 && b == 70)
		{
			return -11;
		}
		else if(a == 59 && b == 71)
		{
			return -12;
		}
		else if(a == 59 && b == 72)
		{
			return -13;
		}
		else if(a == 59 && b == 73)
		{
			return -14;
		}
		else if(a == 59 && b == 74)
		{
			return -15;
		}
		else if(a == 59 && b == 75)
		{
			return -16;
		}
		else if(a == 59 && b == 76)
		{
			return -17;
		}
		else if(a == 59 && b == 77)
		{
			return -18;
		}
		else if(a == 59 && b == 78)
		{
			return -19;
		}
		else if(a == 59 && b == 79)
		{
			return -20;
		}
		else if(a == 59 && b == 80)
		{
			return -21;
		}
		else if(a == 59 && b == 81)
		{
			return -22;
		}
		else if(a == 59 && b == 82)
		{
			return -23;
		}
		else if(a == 59 && b == 83)
		{
			return -24;
		}
		else if(a == 59 && b == 84)
		{
			return -25;
		}
		else if(a == 59 && b == 85)
		{
			return -26;
		}
		else if(a == 59 && b == 86)
		{
			return -27;
		}
		else if(a == 59 && b == 87)
		{
			return -28;
		}
		else if(a == 59 && b == 88)
		{
			return -29;
		}
		else if(a == 59 && b == 89)
		{
			return -30;
		}
		else if(a == 59 && b == 90)
		{
			return -31;
		}
		else if(a == 59 && b == 91)
		{
			return -32;
		}
		else if(a == 59 && b == 92)
		{
			return -33;
		}
		else if(a == 59 && b == 93)
		{
			return -34;
		}
		else if(a == 59 && b == 94)
		{
			return -35;
		}
		else if(a == 59 && b == 95)
		{
			return -36;
		}
		else if(a == 59 && b == 96)
		{
			return -37;
		}
		else if(a == 59 && b == 97)
		{
			return -38;
		}
		else if(a == 59 && b == 98)
		{
			return -39;
		}
		else if(a == 59 && b == 99)
		{
			return -40;
		}
		else if(a == 59 && b == 100)
		{
			return -41;
		}
		else if(a == 60 && b == 0)
		{
			return 60;
		}
		else if(a == 60 && b == 1)
		{
			return 59;
		}
		else if(a == 60 && b == 2)
		{
			return 58;
		}
		else if(a == 60 && b == 3)
		{
			return 57;
		}
		else if(a == 60 && b == 4)
		{
			return 56;
		}
		else if(a == 60 && b == 5)
		{
			return 55;
		}
		else if(a == 60 && b == 6)
		{
			return 54;
		}
		else if(a == 60 && b == 7)
		{
			return 53;
		}
		else if(a == 60 && b == 8)
		{
			return 52;
		}
		else if(a == 60 && b == 9)
		{
			return 51;
		}
		else if(a == 60 && b == 10)
		{
			return 50;
		}
		else if(a == 60 && b == 11)
		{
			return 49;
		}
		else if(a == 60 && b == 12)
		{
			return 48;
		}
		else if(a == 60 && b == 13)
		{
			return 47;
		}
		else if(a == 60 && b == 14)
		{
			return 46;
		}
		else if(a == 60 && b == 15)
		{
			return 45;
		}
		else if(a == 60 && b == 16)
		{
			return 44;
		}
		else if(a == 60 && b == 17)
		{
			return 43;
		}
		else if(a == 60 && b == 18)
		{
			return 42;
		}
		else if(a == 60 && b == 19)
		{
			return 41;
		}
		else if(a == 60 && b == 20)
		{
			return 40;
		}
		else if(a == 60 && b == 21)
		{
			return 39;
		}
		else if(a == 60 && b == 22)
		{
			return 38;
		}
		else if(a == 60 && b == 23)
		{
			return 37;
		}
		else if(a == 60 && b == 24)
		{
			return 36;
		}
		else if(a == 60 && b == 25)
		{
			return 35;
		}
		else if(a == 60 && b == 26)
		{
			return 34;
		}
		else if(a == 60 && b == 27)
		{
			return 33;
		}
		else if(a == 60 && b == 28)
		{
			return 32;
		}
		else if(a == 60 && b == 29)
		{
			return 31;
		}
		else if(a == 60 && b == 30)
		{
			return 30;
		}
		else if(a == 60 && b == 31)
		{
			return 29;
		}
		else if(a == 60 && b == 32)
		{
			return 28;
		}
		else if(a == 60 && b == 33)
		{
			return 27;
		}
		else if(a == 60 && b == 34)
		{
			return 26;
		}
		else if(a == 60 && b == 35)
		{
			return 25;
		}
		else if(a == 60 && b == 36)
		{
			return 24;
		}
		else if(a == 60 && b == 37)
		{
			return 23;
		}
		else if(a == 60 && b == 38)
		{
			return 22;
		}
		else if(a == 60 && b == 39)
		{
			return 21;
		}
		else if(a == 60 && b == 40)
		{
			return 20;
		}
		else if(a == 60 && b == 41)
		{
			return 19;
		}
		else if(a == 60 && b == 42)
		{
			return 18;
		}
		else if(a == 60 && b == 43)
		{
			return 17;
		}
		else if(a == 60 && b == 44)
		{
			return 16;
		}
		else if(a == 60 && b == 45)
		{
			return 15;
		}
		else if(a == 60 && b == 46)
		{
			return 14;
		}
		else if(a == 60 && b == 47)
		{
			return 13;
		}
		else if(a == 60 && b == 48)
		{
			return 12;
		}
		else if(a == 60 && b == 49)
		{
			return 11;
		}
		else if(a == 60 && b == 50)
		{
			return 10;
		}
		else if(a == 60 && b == 51)
		{
			return 9;
		}
		else if(a == 60 && b == 52)
		{
			return 8;
		}
		else if(a == 60 && b == 53)
		{
			return 7;
		}
		else if(a == 60 && b == 54)
		{
			return 6;
		}
		else if(a == 60 && b == 55)
		{
			return 5;
		}
		else if(a == 60 && b == 56)
		{
			return 4;
		}
		else if(a == 60 && b == 57)
		{
			return 3;
		}
		else if(a == 60 && b == 58)
		{
			return 2;
		}
		else if(a == 60 && b == 59)
		{
			return 1;
		}
		else if(a == 60 && b == 60)
		{
			return 0;
		}
		else if(a == 60 && b == 61)
		{
			return -1;
		}
		else if(a == 60 && b == 62)
		{
			return -2;
		}
		else if(a == 60 && b == 63)
		{
			return -3;
		}
		else if(a == 60 && b == 64)
		{
			return -4;
		}
		else if(a == 60 && b == 65)
		{
			return -5;
		}
		else if(a == 60 && b == 66)
		{
			return -6;
		}
		else if(a == 60 && b == 67)
		{
			return -7;
		}
		else if(a == 60 && b == 68)
		{
			return -8;
		}
		else if(a == 60 && b == 69)
		{
			return -9;
		}
		else if(a == 60 && b == 70)
		{
			return -10;
		}
		else if(a == 60 && b == 71)
		{
			return -11;
		}
		else if(a == 60 && b == 72)
		{
			return -12;
		}
		else if(a == 60 && b == 73)
		{
			return -13;
		}
		else if(a == 60 && b == 74)
		{
			return -14;
		}
		else if(a == 60 && b == 75)
		{
			return -15;
		}
		else if(a == 60 && b == 76)
		{
			return -16;
		}
		else if(a == 60 && b == 77)
		{
			return -17;
		}
		else if(a == 60 && b == 78)
		{
			return -18;
		}
		else if(a == 60 && b == 79)
		{
			return -19;
		}
		else if(a == 60 && b == 80)
		{
			return -20;
		}
		else if(a == 60 && b == 81)
		{
			return -21;
		}
		else if(a == 60 && b == 82)
		{
			return -22;
		}
		else if(a == 60 && b == 83)
		{
			return -23;
		}
		else if(a == 60 && b == 84)
		{
			return -24;
		}
		else if(a == 60 && b == 85)
		{
			return -25;
		}
		else if(a == 60 && b == 86)
		{
			return -26;
		}
		else if(a == 60 && b == 87)
		{
			return -27;
		}
		else if(a == 60 && b == 88)
		{
			return -28;
		}
		else if(a == 60 && b == 89)
		{
			return -29;
		}
		else if(a == 60 && b == 90)
		{
			return -30;
		}
		else if(a == 60 && b == 91)
		{
			return -31;
		}
		else if(a == 60 && b == 92)
		{
			return -32;
		}
		else if(a == 60 && b == 93)
		{
			return -33;
		}
		else if(a == 60 && b == 94)
		{
			return -34;
		}
		else if(a == 60 && b == 95)
		{
			return -35;
		}
		else if(a == 60 && b == 96)
		{
			return -36;
		}
		else if(a == 60 && b == 97)
		{
			return -37;
		}
		else if(a == 60 && b == 98)
		{
			return -38;
		}
		else if(a == 60 && b == 99)
		{
			return -39;
		}
		else if(a == 60 && b == 100)
		{
			return -40;
		}
		else if(a == 61 && b == 0)
		{
			return 61;
		}
		else if(a == 61 && b == 1)
		{
			return 60;
		}
		else if(a == 61 && b == 2)
		{
			return 59;
		}
		else if(a == 61 && b == 3)
		{
			return 58;
		}
		else if(a == 61 && b == 4)
		{
			return 57;
		}
		else if(a == 61 && b == 5)
		{
			return 56;
		}
		else if(a == 61 && b == 6)
		{
			return 55;
		}
		else if(a == 61 && b == 7)
		{
			return 54;
		}
		else if(a == 61 && b == 8)
		{
			return 53;
		}
		else if(a == 61 && b == 9)
		{
			return 52;
		}
		else if(a == 61 && b == 10)
		{
			return 51;
		}
		else if(a == 61 && b == 11)
		{
			return 50;
		}
		else if(a == 61 && b == 12)
		{
			return 49;
		}
		else if(a == 61 && b == 13)
		{
			return 48;
		}
		else if(a == 61 && b == 14)
		{
			return 47;
		}
		else if(a == 61 && b == 15)
		{
			return 46;
		}
		else if(a == 61 && b == 16)
		{
			return 45;
		}
		else if(a == 61 && b == 17)
		{
			return 44;
		}
		else if(a == 61 && b == 18)
		{
			return 43;
		}
		else if(a == 61 && b == 19)
		{
			return 42;
		}
		else if(a == 61 && b == 20)
		{
			return 41;
		}
		else if(a == 61 && b == 21)
		{
			return 40;
		}
		else if(a == 61 && b == 22)
		{
			return 39;
		}
		else if(a == 61 && b == 23)
		{
			return 38;
		}
		else if(a == 61 && b == 24)
		{
			return 37;
		}
		else if(a == 61 && b == 25)
		{
			return 36;
		}
		else if(a == 61 && b == 26)
		{
			return 35;
		}
		else if(a == 61 && b == 27)
		{
			return 34;
		}
		else if(a == 61 && b == 28)
		{
			return 33;
		}
		else if(a == 61 && b == 29)
		{
			return 32;
		}
		else if(a == 61 && b == 30)
		{
			return 31;
		}
		else if(a == 61 && b == 31)
		{
			return 30;
		}
		else if(a == 61 && b == 32)
		{
			return 29;
		}
		else if(a == 61 && b == 33)
		{
			return 28;
		}
		else if(a == 61 && b == 34)
		{
			return 27;
		}
		else if(a == 61 && b == 35)
		{
			return 26;
		}
		else if(a == 61 && b == 36)
		{
			return 25;
		}
		else if(a == 61 && b == 37)
		{
			return 24;
		}
		else if(a == 61 && b == 38)
		{
			return 23;
		}
		else if(a == 61 && b == 39)
		{
			return 22;
		}
		else if(a == 61 && b == 40)
		{
			return 21;
		}
		else if(a == 61 && b == 41)
		{
			return 20;
		}
		else if(a == 61 && b == 42)
		{
			return 19;
		}
		else if(a == 61 && b == 43)
		{
			return 18;
		}
		else if(a == 61 && b == 44)
		{
			return 17;
		}
		else if(a == 61 && b == 45)
		{
			return 16;
		}
		else if(a == 61 && b == 46)
		{
			return 15;
		}
		else if(a == 61 && b == 47)
		{
			return 14;
		}
		else if(a == 61 && b == 48)
		{
			return 13;
		}
		else if(a == 61 && b == 49)
		{
			return 12;
		}
		else if(a == 61 && b == 50)
		{
			return 11;
		}
		else if(a == 61 && b == 51)
		{
			return 10;
		}
		else if(a == 61 && b == 52)
		{
			return 9;
		}
		else if(a == 61 && b == 53)
		{
			return 8;
		}
		else if(a == 61 && b == 54)
		{
			return 7;
		}
		else if(a == 61 && b == 55)
		{
			return 6;
		}
		else if(a == 61 && b == 56)
		{
			return 5;
		}
		else if(a == 61 && b == 57)
		{
			return 4;
		}
		else if(a == 61 && b == 58)
		{
			return 3;
		}
		else if(a == 61 && b == 59)
		{
			return 2;
		}
		else if(a == 61 && b == 60)
		{
			return 1;
		}
		else if(a == 61 && b == 61)
		{
			return 0;
		}
		else if(a == 61 && b == 62)
		{
			return -1;
		}
		else if(a == 61 && b == 63)
		{
			return -2;
		}
		else if(a == 61 && b == 64)
		{
			return -3;
		}
		else if(a == 61 && b == 65)
		{
			return -4;
		}
		else if(a == 61 && b == 66)
		{
			return -5;
		}
		else if(a == 61 && b == 67)
		{
			return -6;
		}
		else if(a == 61 && b == 68)
		{
			return -7;
		}
		else if(a == 61 && b == 69)
		{
			return -8;
		}
		else if(a == 61 && b == 70)
		{
			return -9;
		}
		else if(a == 61 && b == 71)
		{
			return -10;
		}
		else if(a == 61 && b == 72)
		{
			return -11;
		}
		else if(a == 61 && b == 73)
		{
			return -12;
		}
		else if(a == 61 && b == 74)
		{
			return -13;
		}
		else if(a == 61 && b == 75)
		{
			return -14;
		}
		else if(a == 61 && b == 76)
		{
			return -15;
		}
		else if(a == 61 && b == 77)
		{
			return -16;
		}
		else if(a == 61 && b == 78)
		{
			return -17;
		}
		else if(a == 61 && b == 79)
		{
			return -18;
		}
		else if(a == 61 && b == 80)
		{
			return -19;
		}
		else if(a == 61 && b == 81)
		{
			return -20;
		}
		else if(a == 61 && b == 82)
		{
			return -21;
		}
		else if(a == 61 && b == 83)
		{
			return -22;
		}
		else if(a == 61 && b == 84)
		{
			return -23;
		}
		else if(a == 61 && b == 85)
		{
			return -24;
		}
		else if(a == 61 && b == 86)
		{
			return -25;
		}
		else if(a == 61 && b == 87)
		{
			return -26;
		}
		else if(a == 61 && b == 88)
		{
			return -27;
		}
		else if(a == 61 && b == 89)
		{
			return -28;
		}
		else if(a == 61 && b == 90)
		{
			return -29;
		}
		else if(a == 61 && b == 91)
		{
			return -30;
		}
		else if(a == 61 && b == 92)
		{
			return -31;
		}
		else if(a == 61 && b == 93)
		{
			return -32;
		}
		else if(a == 61 && b == 94)
		{
			return -33;
		}
		else if(a == 61 && b == 95)
		{
			return -34;
		}
		else if(a == 61 && b == 96)
		{
			return -35;
		}
		else if(a == 61 && b == 97)
		{
			return -36;
		}
		else if(a == 61 && b == 98)
		{
			return -37;
		}
		else if(a == 61 && b == 99)
		{
			return -38;
		}
		else if(a == 61 && b == 100)
		{
			return -39;
		}
		else if(a == 62 && b == 0)
		{
			return 62;
		}
		else if(a == 62 && b == 1)
		{
			return 61;
		}
		else if(a == 62 && b == 2)
		{
			return 60;
		}
		else if(a == 62 && b == 3)
		{
			return 59;
		}
		else if(a == 62 && b == 4)
		{
			return 58;
		}
		else if(a == 62 && b == 5)
		{
			return 57;
		}
		else if(a == 62 && b == 6)
		{
			return 56;
		}
		else if(a == 62 && b == 7)
		{
			return 55;
		}
		else if(a == 62 && b == 8)
		{
			return 54;
		}
		else if(a == 62 && b == 9)
		{
			return 53;
		}
		else if(a == 62 && b == 10)
		{
			return 52;
		}
		else if(a == 62 && b == 11)
		{
			return 51;
		}
		else if(a == 62 && b == 12)
		{
			return 50;
		}
		else if(a == 62 && b == 13)
		{
			return 49;
		}
		else if(a == 62 && b == 14)
		{
			return 48;
		}
		else if(a == 62 && b == 15)
		{
			return 47;
		}
		else if(a == 62 && b == 16)
		{
			return 46;
		}
		else if(a == 62 && b == 17)
		{
			return 45;
		}
		else if(a == 62 && b == 18)
		{
			return 44;
		}
		else if(a == 62 && b == 19)
		{
			return 43;
		}
		else if(a == 62 && b == 20)
		{
			return 42;
		}
		else if(a == 62 && b == 21)
		{
			return 41;
		}
		else if(a == 62 && b == 22)
		{
			return 40;
		}
		else if(a == 62 && b == 23)
		{
			return 39;
		}
		else if(a == 62 && b == 24)
		{
			return 38;
		}
		else if(a == 62 && b == 25)
		{
			return 37;
		}
		else if(a == 62 && b == 26)
		{
			return 36;
		}
		else if(a == 62 && b == 27)
		{
			return 35;
		}
		else if(a == 62 && b == 28)
		{
			return 34;
		}
		else if(a == 62 && b == 29)
		{
			return 33;
		}
		else if(a == 62 && b == 30)
		{
			return 32;
		}
		else if(a == 62 && b == 31)
		{
			return 31;
		}
		else if(a == 62 && b == 32)
		{
			return 30;
		}
		else if(a == 62 && b == 33)
		{
			return 29;
		}
		else if(a == 62 && b == 34)
		{
			return 28;
		}
		else if(a == 62 && b == 35)
		{
			return 27;
		}
		else if(a == 62 && b == 36)
		{
			return 26;
		}
		else if(a == 62 && b == 37)
		{
			return 25;
		}
		else if(a == 62 && b == 38)
		{
			return 24;
		}
		else if(a == 62 && b == 39)
		{
			return 23;
		}
		else if(a == 62 && b == 40)
		{
			return 22;
		}
		else if(a == 62 && b == 41)
		{
			return 21;
		}
		else if(a == 62 && b == 42)
		{
			return 20;
		}
		else if(a == 62 && b == 43)
		{
			return 19;
		}
		else if(a == 62 && b == 44)
		{
			return 18;
		}
		else if(a == 62 && b == 45)
		{
			return 17;
		}
		else if(a == 62 && b == 46)
		{
			return 16;
		}
		else if(a == 62 && b == 47)
		{
			return 15;
		}
		else if(a == 62 && b == 48)
		{
			return 14;
		}
		else if(a == 62 && b == 49)
		{
			return 13;
		}
		else if(a == 62 && b == 50)
		{
			return 12;
		}
		else if(a == 62 && b == 51)
		{
			return 11;
		}
		else if(a == 62 && b == 52)
		{
			return 10;
		}
		else if(a == 62 && b == 53)
		{
			return 9;
		}
		else if(a == 62 && b == 54)
		{
			return 8;
		}
		else if(a == 62 && b == 55)
		{
			return 7;
		}
		else if(a == 62 && b == 56)
		{
			return 6;
		}
		else if(a == 62 && b == 57)
		{
			return 5;
		}
		else if(a == 62 && b == 58)
		{
			return 4;
		}
		else if(a == 62 && b == 59)
		{
			return 3;
		}
		else if(a == 62 && b == 60)
		{
			return 2;
		}
		else if(a == 62 && b == 61)
		{
			return 1;
		}
		else if(a == 62 && b == 62)
		{
			return 0;
		}
		else if(a == 62 && b == 63)
		{
			return -1;
		}
		else if(a == 62 && b == 64)
		{
			return -2;
		}
		else if(a == 62 && b == 65)
		{
			return -3;
		}
		else if(a == 62 && b == 66)
		{
			return -4;
		}
		else if(a == 62 && b == 67)
		{
			return -5;
		}
		else if(a == 62 && b == 68)
		{
			return -6;
		}
		else if(a == 62 && b == 69)
		{
			return -7;
		}
		else if(a == 62 && b == 70)
		{
			return -8;
		}
		else if(a == 62 && b == 71)
		{
			return -9;
		}
		else if(a == 62 && b == 72)
		{
			return -10;
		}
		else if(a == 62 && b == 73)
		{
			return -11;
		}
		else if(a == 62 && b == 74)
		{
			return -12;
		}
		else if(a == 62 && b == 75)
		{
			return -13;
		}
		else if(a == 62 && b == 76)
		{
			return -14;
		}
		else if(a == 62 && b == 77)
		{
			return -15;
		}
		else if(a == 62 && b == 78)
		{
			return -16;
		}
		else if(a == 62 && b == 79)
		{
			return -17;
		}
		else if(a == 62 && b == 80)
		{
			return -18;
		}
		else if(a == 62 && b == 81)
		{
			return -19;
		}
		else if(a == 62 && b == 82)
		{
			return -20;
		}
		else if(a == 62 && b == 83)
		{
			return -21;
		}
		else if(a == 62 && b == 84)
		{
			return -22;
		}
		else if(a == 62 && b == 85)
		{
			return -23;
		}
		else if(a == 62 && b == 86)
		{
			return -24;
		}
		else if(a == 62 && b == 87)
		{
			return -25;
		}
		else if(a == 62 && b == 88)
		{
			return -26;
		}
		else if(a == 62 && b == 89)
		{
			return -27;
		}
		else if(a == 62 && b == 90)
		{
			return -28;
		}
		else if(a == 62 && b == 91)
		{
			return -29;
		}
		else if(a == 62 && b == 92)
		{
			return -30;
		}
		else if(a == 62 && b == 93)
		{
			return -31;
		}
		else if(a == 62 && b == 94)
		{
			return -32;
		}
		else if(a == 62 && b == 95)
		{
			return -33;
		}
		else if(a == 62 && b == 96)
		{
			return -34;
		}
		else if(a == 62 && b == 97)
		{
			return -35;
		}
		else if(a == 62 && b == 98)
		{
			return -36;
		}
		else if(a == 62 && b == 99)
		{
			return -37;
		}
		else if(a == 62 && b == 100)
		{
			return -38;
		}
		else if(a == 63 && b == 0)
		{
			return 63;
		}
		else if(a == 63 && b == 1)
		{
			return 62;
		}
		else if(a == 63 && b == 2)
		{
			return 61;
		}
		else if(a == 63 && b == 3)
		{
			return 60;
		}
		else if(a == 63 && b == 4)
		{
			return 59;
		}
		else if(a == 63 && b == 5)
		{
			return 58;
		}
		else if(a == 63 && b == 6)
		{
			return 57;
		}
		else if(a == 63 && b == 7)
		{
			return 56;
		}
		else if(a == 63 && b == 8)
		{
			return 55;
		}
		else if(a == 63 && b == 9)
		{
			return 54;
		}
		else if(a == 63 && b == 10)
		{
			return 53;
		}
		else if(a == 63 && b == 11)
		{
			return 52;
		}
		else if(a == 63 && b == 12)
		{
			return 51;
		}
		else if(a == 63 && b == 13)
		{
			return 50;
		}
		else if(a == 63 && b == 14)
		{
			return 49;
		}
		else if(a == 63 && b == 15)
		{
			return 48;
		}
		else if(a == 63 && b == 16)
		{
			return 47;
		}
		else if(a == 63 && b == 17)
		{
			return 46;
		}
		else if(a == 63 && b == 18)
		{
			return 45;
		}
		else if(a == 63 && b == 19)
		{
			return 44;
		}
		else if(a == 63 && b == 20)
		{
			return 43;
		}
		else if(a == 63 && b == 21)
		{
			return 42;
		}
		else if(a == 63 && b == 22)
		{
			return 41;
		}
		else if(a == 63 && b == 23)
		{
			return 40;
		}
		else if(a == 63 && b == 24)
		{
			return 39;
		}
		else if(a == 63 && b == 25)
		{
			return 38;
		}
		else if(a == 63 && b == 26)
		{
			return 37;
		}
		else if(a == 63 && b == 27)
		{
			return 36;
		}
		else if(a == 63 && b == 28)
		{
			return 35;
		}
		else if(a == 63 && b == 29)
		{
			return 34;
		}
		else if(a == 63 && b == 30)
		{
			return 33;
		}
		else if(a == 63 && b == 31)
		{
			return 32;
		}
		else if(a == 63 && b == 32)
		{
			return 31;
		}
		else if(a == 63 && b == 33)
		{
			return 30;
		}
		else if(a == 63 && b == 34)
		{
			return 29;
		}
		else if(a == 63 && b == 35)
		{
			return 28;
		}
		else if(a == 63 && b == 36)
		{
			return 27;
		}
		else if(a == 63 && b == 37)
		{
			return 26;
		}
		else if(a == 63 && b == 38)
		{
			return 25;
		}
		else if(a == 63 && b == 39)
		{
			return 24;
		}
		else if(a == 63 && b == 40)
		{
			return 23;
		}
		else if(a == 63 && b == 41)
		{
			return 22;
		}
		else if(a == 63 && b == 42)
		{
			return 21;
		}
		else if(a == 63 && b == 43)
		{
			return 20;
		}
		else if(a == 63 && b == 44)
		{
			return 19;
		}
		else if(a == 63 && b == 45)
		{
			return 18;
		}
		else if(a == 63 && b == 46)
		{
			return 17;
		}
		else if(a == 63 && b == 47)
		{
			return 16;
		}
		else if(a == 63 && b == 48)
		{
			return 15;
		}
		else if(a == 63 && b == 49)
		{
			return 14;
		}
		else if(a == 63 && b == 50)
		{
			return 13;
		}
		else if(a == 63 && b == 51)
		{
			return 12;
		}
		else if(a == 63 && b == 52)
		{
			return 11;
		}
		else if(a == 63 && b == 53)
		{
			return 10;
		}
		else if(a == 63 && b == 54)
		{
			return 9;
		}
		else if(a == 63 && b == 55)
		{
			return 8;
		}
		else if(a == 63 && b == 56)
		{
			return 7;
		}
		else if(a == 63 && b == 57)
		{
			return 6;
		}
		else if(a == 63 && b == 58)
		{
			return 5;
		}
		else if(a == 63 && b == 59)
		{
			return 4;
		}
		else if(a == 63 && b == 60)
		{
			return 3;
		}
		else if(a == 63 && b == 61)
		{
			return 2;
		}
		else if(a == 63 && b == 62)
		{
			return 1;
		}
		else if(a == 63 && b == 63)
		{
			return 0;
		}
		else if(a == 63 && b == 64)
		{
			return -1;
		}
		else if(a == 63 && b == 65)
		{
			return -2;
		}
		else if(a == 63 && b == 66)
		{
			return -3;
		}
		else if(a == 63 && b == 67)
		{
			return -4;
		}
		else if(a == 63 && b == 68)
		{
			return -5;
		}
		else if(a == 63 && b == 69)
		{
			return -6;
		}
		else if(a == 63 && b == 70)
		{
			return -7;
		}
		else if(a == 63 && b == 71)
		{
			return -8;
		}
		else if(a == 63 && b == 72)
		{
			return -9;
		}
		else if(a == 63 && b == 73)
		{
			return -10;
		}
		else if(a == 63 && b == 74)
		{
			return -11;
		}
		else if(a == 63 && b == 75)
		{
			return -12;
		}
		else if(a == 63 && b == 76)
		{
			return -13;
		}
		else if(a == 63 && b == 77)
		{
			return -14;
		}
		else if(a == 63 && b == 78)
		{
			return -15;
		}
		else if(a == 63 && b == 79)
		{
			return -16;
		}
		else if(a == 63 && b == 80)
		{
			return -17;
		}
		else if(a == 63 && b == 81)
		{
			return -18;
		}
		else if(a == 63 && b == 82)
		{
			return -19;
		}
		else if(a == 63 && b == 83)
		{
			return -20;
		}
		else if(a == 63 && b == 84)
		{
			return -21;
		}
		else if(a == 63 && b == 85)
		{
			return -22;
		}
		else if(a == 63 && b == 86)
		{
			return -23;
		}
		else if(a == 63 && b == 87)
		{
			return -24;
		}
		else if(a == 63 && b == 88)
		{
			return -25;
		}
		else if(a == 63 && b == 89)
		{
			return -26;
		}
		else if(a == 63 && b == 90)
		{
			return -27;
		}
		else if(a == 63 && b == 91)
		{
			return -28;
		}
		else if(a == 63 && b == 92)
		{
			return -29;
		}
		else if(a == 63 && b == 93)
		{
			return -30;
		}
		else if(a == 63 && b == 94)
		{
			return -31;
		}
		else if(a == 63 && b == 95)
		{
			return -32;
		}
		else if(a == 63 && b == 96)
		{
			return -33;
		}
		else if(a == 63 && b == 97)
		{
			return -34;
		}
		else if(a == 63 && b == 98)
		{
			return -35;
		}
		else if(a == 63 && b == 99)
		{
			return -36;
		}
		else if(a == 63 && b == 100)
		{
			return -37;
		}
		else if(a == 64 && b == 0)
		{
			return 64;
		}
		else if(a == 64 && b == 1)
		{
			return 63;
		}
		else if(a == 64 && b == 2)
		{
			return 62;
		}
		else if(a == 64 && b == 3)
		{
			return 61;
		}
		else if(a == 64 && b == 4)
		{
			return 60;
		}
		else if(a == 64 && b == 5)
		{
			return 59;
		}
		else if(a == 64 && b == 6)
		{
			return 58;
		}
		else if(a == 64 && b == 7)
		{
			return 57;
		}
		else if(a == 64 && b == 8)
		{
			return 56;
		}
		else if(a == 64 && b == 9)
		{
			return 55;
		}
		else if(a == 64 && b == 10)
		{
			return 54;
		}
		else if(a == 64 && b == 11)
		{
			return 53;
		}
		else if(a == 64 && b == 12)
		{
			return 52;
		}
		else if(a == 64 && b == 13)
		{
			return 51;
		}
		else if(a == 64 && b == 14)
		{
			return 50;
		}
		else if(a == 64 && b == 15)
		{
			return 49;
		}
		else if(a == 64 && b == 16)
		{
			return 48;
		}
		else if(a == 64 && b == 17)
		{
			return 47;
		}
		else if(a == 64 && b == 18)
		{
			return 46;
		}
		else if(a == 64 && b == 19)
		{
			return 45;
		}
		else if(a == 64 && b == 20)
		{
			return 44;
		}
		else if(a == 64 && b == 21)
		{
			return 43;
		}
		else if(a == 64 && b == 22)
		{
			return 42;
		}
		else if(a == 64 && b == 23)
		{
			return 41;
		}
		else if(a == 64 && b == 24)
		{
			return 40;
		}
		else if(a == 64 && b == 25)
		{
			return 39;
		}
		else if(a == 64 && b == 26)
		{
			return 38;
		}
		else if(a == 64 && b == 27)
		{
			return 37;
		}
		else if(a == 64 && b == 28)
		{
			return 36;
		}
		else if(a == 64 && b == 29)
		{
			return 35;
		}
		else if(a == 64 && b == 30)
		{
			return 34;
		}
		else if(a == 64 && b == 31)
		{
			return 33;
		}
		else if(a == 64 && b == 32)
		{
			return 32;
		}
		else if(a == 64 && b == 33)
		{
			return 31;
		}
		else if(a == 64 && b == 34)
		{
			return 30;
		}
		else if(a == 64 && b == 35)
		{
			return 29;
		}
		else if(a == 64 && b == 36)
		{
			return 28;
		}
		else if(a == 64 && b == 37)
		{
			return 27;
		}
		else if(a == 64 && b == 38)
		{
			return 26;
		}
		else if(a == 64 && b == 39)
		{
			return 25;
		}
		else if(a == 64 && b == 40)
		{
			return 24;
		}
		else if(a == 64 && b == 41)
		{
			return 23;
		}
		else if(a == 64 && b == 42)
		{
			return 22;
		}
		else if(a == 64 && b == 43)
		{
			return 21;
		}
		else if(a == 64 && b == 44)
		{
			return 20;
		}
		else if(a == 64 && b == 45)
		{
			return 19;
		}
		else if(a == 64 && b == 46)
		{
			return 18;
		}
		else if(a == 64 && b == 47)
		{
			return 17;
		}
		else if(a == 64 && b == 48)
		{
			return 16;
		}
		else if(a == 64 && b == 49)
		{
			return 15;
		}
		else if(a == 64 && b == 50)
		{
			return 14;
		}
		else if(a == 64 && b == 51)
		{
			return 13;
		}
		else if(a == 64 && b == 52)
		{
			return 12;
		}
		else if(a == 64 && b == 53)
		{
			return 11;
		}
		else if(a == 64 && b == 54)
		{
			return 10;
		}
		else if(a == 64 && b == 55)
		{
			return 9;
		}
		else if(a == 64 && b == 56)
		{
			return 8;
		}
		else if(a == 64 && b == 57)
		{
			return 7;
		}
		else if(a == 64 && b == 58)
		{
			return 6;
		}
		else if(a == 64 && b == 59)
		{
			return 5;
		}
		else if(a == 64 && b == 60)
		{
			return 4;
		}
		else if(a == 64 && b == 61)
		{
			return 3;
		}
		else if(a == 64 && b == 62)
		{
			return 2;
		}
		else if(a == 64 && b == 63)
		{
			return 1;
		}
		else if(a == 64 && b == 64)
		{
			return 0;
		}
		else if(a == 64 && b == 65)
		{
			return -1;
		}
		else if(a == 64 && b == 66)
		{
			return -2;
		}
		else if(a == 64 && b == 67)
		{
			return -3;
		}
		else if(a == 64 && b == 68)
		{
			return -4;
		}
		else if(a == 64 && b == 69)
		{
			return -5;
		}
		else if(a == 64 && b == 70)
		{
			return -6;
		}
		else if(a == 64 && b == 71)
		{
			return -7;
		}
		else if(a == 64 && b == 72)
		{
			return -8;
		}
		else if(a == 64 && b == 73)
		{
			return -9;
		}
		else if(a == 64 && b == 74)
		{
			return -10;
		}
		else if(a == 64 && b == 75)
		{
			return -11;
		}
		else if(a == 64 && b == 76)
		{
			return -12;
		}
		else if(a == 64 && b == 77)
		{
			return -13;
		}
		else if(a == 64 && b == 78)
		{
			return -14;
		}
		else if(a == 64 && b == 79)
		{
			return -15;
		}
		else if(a == 64 && b == 80)
		{
			return -16;
		}
		else if(a == 64 && b == 81)
		{
			return -17;
		}
		else if(a == 64 && b == 82)
		{
			return -18;
		}
		else if(a == 64 && b == 83)
		{
			return -19;
		}
		else if(a == 64 && b == 84)
		{
			return -20;
		}
		else if(a == 64 && b == 85)
		{
			return -21;
		}
		else if(a == 64 && b == 86)
		{
			return -22;
		}
		else if(a == 64 && b == 87)
		{
			return -23;
		}
		else if(a == 64 && b == 88)
		{
			return -24;
		}
		else if(a == 64 && b == 89)
		{
			return -25;
		}
		else if(a == 64 && b == 90)
		{
			return -26;
		}
		else if(a == 64 && b == 91)
		{
			return -27;
		}
		else if(a == 64 && b == 92)
		{
			return -28;
		}
		else if(a == 64 && b == 93)
		{
			return -29;
		}
		else if(a == 64 && b == 94)
		{
			return -30;
		}
		else if(a == 64 && b == 95)
		{
			return -31;
		}
		else if(a == 64 && b == 96)
		{
			return -32;
		}
		else if(a == 64 && b == 97)
		{
			return -33;
		}
		else if(a == 64 && b == 98)
		{
			return -34;
		}
		else if(a == 64 && b == 99)
		{
			return -35;
		}
		else if(a == 64 && b == 100)
		{
			return -36;
		}
		else if(a == 65 && b == 0)
		{
			return 65;
		}
		else if(a == 65 && b == 1)
		{
			return 64;
		}
		else if(a == 65 && b == 2)
		{
			return 63;
		}
		else if(a == 65 && b == 3)
		{
			return 62;
		}
		else if(a == 65 && b == 4)
		{
			return 61;
		}
		else if(a == 65 && b == 5)
		{
			return 60;
		}
		else if(a == 65 && b == 6)
		{
			return 59;
		}
		else if(a == 65 && b == 7)
		{
			return 58;
		}
		else if(a == 65 && b == 8)
		{
			return 57;
		}
		else if(a == 65 && b == 9)
		{
			return 56;
		}
		else if(a == 65 && b == 10)
		{
			return 55;
		}
		else if(a == 65 && b == 11)
		{
			return 54;
		}
		else if(a == 65 && b == 12)
		{
			return 53;
		}
		else if(a == 65 && b == 13)
		{
			return 52;
		}
		else if(a == 65 && b == 14)
		{
			return 51;
		}
		else if(a == 65 && b == 15)
		{
			return 50;
		}
		else if(a == 65 && b == 16)
		{
			return 49;
		}
		else if(a == 65 && b == 17)
		{
			return 48;
		}
		else if(a == 65 && b == 18)
		{
			return 47;
		}
		else if(a == 65 && b == 19)
		{
			return 46;
		}
		else if(a == 65 && b == 20)
		{
			return 45;
		}
		else if(a == 65 && b == 21)
		{
			return 44;
		}
		else if(a == 65 && b == 22)
		{
			return 43;
		}
		else if(a == 65 && b == 23)
		{
			return 42;
		}
		else if(a == 65 && b == 24)
		{
			return 41;
		}
		else if(a == 65 && b == 25)
		{
			return 40;
		}
		else if(a == 65 && b == 26)
		{
			return 39;
		}
		else if(a == 65 && b == 27)
		{
			return 38;
		}
		else if(a == 65 && b == 28)
		{
			return 37;
		}
		else if(a == 65 && b == 29)
		{
			return 36;
		}
		else if(a == 65 && b == 30)
		{
			return 35;
		}
		else if(a == 65 && b == 31)
		{
			return 34;
		}
		else if(a == 65 && b == 32)
		{
			return 33;
		}
		else if(a == 65 && b == 33)
		{
			return 32;
		}
		else if(a == 65 && b == 34)
		{
			return 31;
		}
		else if(a == 65 && b == 35)
		{
			return 30;
		}
		else if(a == 65 && b == 36)
		{
			return 29;
		}
		else if(a == 65 && b == 37)
		{
			return 28;
		}
		else if(a == 65 && b == 38)
		{
			return 27;
		}
		else if(a == 65 && b == 39)
		{
			return 26;
		}
		else if(a == 65 && b == 40)
		{
			return 25;
		}
		else if(a == 65 && b == 41)
		{
			return 24;
		}
		else if(a == 65 && b == 42)
		{
			return 23;
		}
		else if(a == 65 && b == 43)
		{
			return 22;
		}
		else if(a == 65 && b == 44)
		{
			return 21;
		}
		else if(a == 65 && b == 45)
		{
			return 20;
		}
		else if(a == 65 && b == 46)
		{
			return 19;
		}
		else if(a == 65 && b == 47)
		{
			return 18;
		}
		else if(a == 65 && b == 48)
		{
			return 17;
		}
		else if(a == 65 && b == 49)
		{
			return 16;
		}
		else if(a == 65 && b == 50)
		{
			return 15;
		}
		else if(a == 65 && b == 51)
		{
			return 14;
		}
		else if(a == 65 && b == 52)
		{
			return 13;
		}
		else if(a == 65 && b == 53)
		{
			return 12;
		}
		else if(a == 65 && b == 54)
		{
			return 11;
		}
		else if(a == 65 && b == 55)
		{
			return 10;
		}
		else if(a == 65 && b == 56)
		{
			return 9;
		}
		else if(a == 65 && b == 57)
		{
			return 8;
		}
		else if(a == 65 && b == 58)
		{
			return 7;
		}
		else if(a == 65 && b == 59)
		{
			return 6;
		}
		else if(a == 65 && b == 60)
		{
			return 5;
		}
		else if(a == 65 && b == 61)
		{
			return 4;
		}
		else if(a == 65 && b == 62)
		{
			return 3;
		}
		else if(a == 65 && b == 63)
		{
			return 2;
		}
		else if(a == 65 && b == 64)
		{
			return 1;
		}
		else if(a == 65 && b == 65)
		{
			return 0;
		}
		else if(a == 65 && b == 66)
		{
			return -1;
		}
		else if(a == 65 && b == 67)
		{
			return -2;
		}
		else if(a == 65 && b == 68)
		{
			return -3;
		}
		else if(a == 65 && b == 69)
		{
			return -4;
		}
		else if(a == 65 && b == 70)
		{
			return -5;
		}
		else if(a == 65 && b == 71)
		{
			return -6;
		}
		else if(a == 65 && b == 72)
		{
			return -7;
		}
		else if(a == 65 && b == 73)
		{
			return -8;
		}
		else if(a == 65 && b == 74)
		{
			return -9;
		}
		else if(a == 65 && b == 75)
		{
			return -10;
		}
		else if(a == 65 && b == 76)
		{
			return -11;
		}
		else if(a == 65 && b == 77)
		{
			return -12;
		}
		else if(a == 65 && b == 78)
		{
			return -13;
		}
		else if(a == 65 && b == 79)
		{
			return -14;
		}
		else if(a == 65 && b == 80)
		{
			return -15;
		}
		else if(a == 65 && b == 81)
		{
			return -16;
		}
		else if(a == 65 && b == 82)
		{
			return -17;
		}
		else if(a == 65 && b == 83)
		{
			return -18;
		}
		else if(a == 65 && b == 84)
		{
			return -19;
		}
		else if(a == 65 && b == 85)
		{
			return -20;
		}
		else if(a == 65 && b == 86)
		{
			return -21;
		}
		else if(a == 65 && b == 87)
		{
			return -22;
		}
		else if(a == 65 && b == 88)
		{
			return -23;
		}
		else if(a == 65 && b == 89)
		{
			return -24;
		}
		else if(a == 65 && b == 90)
		{
			return -25;
		}
		else if(a == 65 && b == 91)
		{
			return -26;
		}
		else if(a == 65 && b == 92)
		{
			return -27;
		}
		else if(a == 65 && b == 93)
		{
			return -28;
		}
		else if(a == 65 && b == 94)
		{
			return -29;
		}
		else if(a == 65 && b == 95)
		{
			return -30;
		}
		else if(a == 65 && b == 96)
		{
			return -31;
		}
		else if(a == 65 && b == 97)
		{
			return -32;
		}
		else if(a == 65 && b == 98)
		{
			return -33;
		}
		else if(a == 65 && b == 99)
		{
			return -34;
		}
		else if(a == 65 && b == 100)
		{
			return -35;
		}
		else if(a == 66 && b == 0)
		{
			return 66;
		}
		else if(a == 66 && b == 1)
		{
			return 65;
		}
		else if(a == 66 && b == 2)
		{
			return 64;
		}
		else if(a == 66 && b == 3)
		{
			return 63;
		}
		else if(a == 66 && b == 4)
		{
			return 62;
		}
		else if(a == 66 && b == 5)
		{
			return 61;
		}
		else if(a == 66 && b == 6)
		{
			return 60;
		}
		else if(a == 66 && b == 7)
		{
			return 59;
		}
		else if(a == 66 && b == 8)
		{
			return 58;
		}
		else if(a == 66 && b == 9)
		{
			return 57;
		}
		else if(a == 66 && b == 10)
		{
			return 56;
		}
		else if(a == 66 && b == 11)
		{
			return 55;
		}
		else if(a == 66 && b == 12)
		{
			return 54;
		}
		else if(a == 66 && b == 13)
		{
			return 53;
		}
		else if(a == 66 && b == 14)
		{
			return 52;
		}
		else if(a == 66 && b == 15)
		{
			return 51;
		}
		else if(a == 66 && b == 16)
		{
			return 50;
		}
		else if(a == 66 && b == 17)
		{
			return 49;
		}
		else if(a == 66 && b == 18)
		{
			return 48;
		}
		else if(a == 66 && b == 19)
		{
			return 47;
		}
		else if(a == 66 && b == 20)
		{
			return 46;
		}
		else if(a == 66 && b == 21)
		{
			return 45;
		}
		else if(a == 66 && b == 22)
		{
			return 44;
		}
		else if(a == 66 && b == 23)
		{
			return 43;
		}
		else if(a == 66 && b == 24)
		{
			return 42;
		}
		else if(a == 66 && b == 25)
		{
			return 41;
		}
		else if(a == 66 && b == 26)
		{
			return 40;
		}
		else if(a == 66 && b == 27)
		{
			return 39;
		}
		else if(a == 66 && b == 28)
		{
			return 38;
		}
		else if(a == 66 && b == 29)
		{
			return 37;
		}
		else if(a == 66 && b == 30)
		{
			return 36;
		}
		else if(a == 66 && b == 31)
		{
			return 35;
		}
		else if(a == 66 && b == 32)
		{
			return 34;
		}
		else if(a == 66 && b == 33)
		{
			return 33;
		}
		else if(a == 66 && b == 34)
		{
			return 32;
		}
		else if(a == 66 && b == 35)
		{
			return 31;
		}
		else if(a == 66 && b == 36)
		{
			return 30;
		}
		else if(a == 66 && b == 37)
		{
			return 29;
		}
		else if(a == 66 && b == 38)
		{
			return 28;
		}
		else if(a == 66 && b == 39)
		{
			return 27;
		}
		else if(a == 66 && b == 40)
		{
			return 26;
		}
		else if(a == 66 && b == 41)
		{
			return 25;
		}
		else if(a == 66 && b == 42)
		{
			return 24;
		}
		else if(a == 66 && b == 43)
		{
			return 23;
		}
		else if(a == 66 && b == 44)
		{
			return 22;
		}
		else if(a == 66 && b == 45)
		{
			return 21;
		}
		else if(a == 66 && b == 46)
		{
			return 20;
		}
		else if(a == 66 && b == 47)
		{
			return 19;
		}
		else if(a == 66 && b == 48)
		{
			return 18;
		}
		else if(a == 66 && b == 49)
		{
			return 17;
		}
		else if(a == 66 && b == 50)
		{
			return 16;
		}
		else if(a == 66 && b == 51)
		{
			return 15;
		}
		else if(a == 66 && b == 52)
		{
			return 14;
		}
		else if(a == 66 && b == 53)
		{
			return 13;
		}
		else if(a == 66 && b == 54)
		{
			return 12;
		}
		else if(a == 66 && b == 55)
		{
			return 11;
		}
		else if(a == 66 && b == 56)
		{
			return 10;
		}
		else if(a == 66 && b == 57)
		{
			return 9;
		}
		else if(a == 66 && b == 58)
		{
			return 8;
		}
		else if(a == 66 && b == 59)
		{
			return 7;
		}
		else if(a == 66 && b == 60)
		{
			return 6;
		}
		else if(a == 66 && b == 61)
		{
			return 5;
		}
		else if(a == 66 && b == 62)
		{
			return 4;
		}
		else if(a == 66 && b == 63)
		{
			return 3;
		}
		else if(a == 66 && b == 64)
		{
			return 2;
		}
		else if(a == 66 && b == 65)
		{
			return 1;
		}
		else if(a == 66 && b == 66)
		{
			return 0;
		}
		else if(a == 66 && b == 67)
		{
			return -1;
		}
		else if(a == 66 && b == 68)
		{
			return -2;
		}
		else if(a == 66 && b == 69)
		{
			return -3;
		}
		else if(a == 66 && b == 70)
		{
			return -4;
		}
		else if(a == 66 && b == 71)
		{
			return -5;
		}
		else if(a == 66 && b == 72)
		{
			return -6;
		}
		else if(a == 66 && b == 73)
		{
			return -7;
		}
		else if(a == 66 && b == 74)
		{
			return -8;
		}
		else if(a == 66 && b == 75)
		{
			return -9;
		}
		else if(a == 66 && b == 76)
		{
			return -10;
		}
		else if(a == 66 && b == 77)
		{
			return -11;
		}
		else if(a == 66 && b == 78)
		{
			return -12;
		}
		else if(a == 66 && b == 79)
		{
			return -13;
		}
		else if(a == 66 && b == 80)
		{
			return -14;
		}
		else if(a == 66 && b == 81)
		{
			return -15;
		}
		else if(a == 66 && b == 82)
		{
			return -16;
		}
		else if(a == 66 && b == 83)
		{
			return -17;
		}
		else if(a == 66 && b == 84)
		{
			return -18;
		}
		else if(a == 66 && b == 85)
		{
			return -19;
		}
		else if(a == 66 && b == 86)
		{
			return -20;
		}
		else if(a == 66 && b == 87)
		{
			return -21;
		}
		else if(a == 66 && b == 88)
		{
			return -22;
		}
		else if(a == 66 && b == 89)
		{
			return -23;
		}
		else if(a == 66 && b == 90)
		{
			return -24;
		}
		else if(a == 66 && b == 91)
		{
			return -25;
		}
		else if(a == 66 && b == 92)
		{
			return -26;
		}
		else if(a == 66 && b == 93)
		{
			return -27;
		}
		else if(a == 66 && b == 94)
		{
			return -28;
		}
		else if(a == 66 && b == 95)
		{
			return -29;
		}
		else if(a == 66 && b == 96)
		{
			return -30;
		}
		else if(a == 66 && b == 97)
		{
			return -31;
		}
		else if(a == 66 && b == 98)
		{
			return -32;
		}
		else if(a == 66 && b == 99)
		{
			return -33;
		}
		else if(a == 66 && b == 100)
		{
			return -34;
		}
		else if(a == 67 && b == 0)
		{
			return 67;
		}
		else if(a == 67 && b == 1)
		{
			return 66;
		}
		else if(a == 67 && b == 2)
		{
			return 65;
		}
		else if(a == 67 && b == 3)
		{
			return 64;
		}
		else if(a == 67 && b == 4)
		{
			return 63;
		}
		else if(a == 67 && b == 5)
		{
			return 62;
		}
		else if(a == 67 && b == 6)
		{
			return 61;
		}
		else if(a == 67 && b == 7)
		{
			return 60;
		}
		else if(a == 67 && b == 8)
		{
			return 59;
		}
		else if(a == 67 && b == 9)
		{
			return 58;
		}
		else if(a == 67 && b == 10)
		{
			return 57;
		}
		else if(a == 67 && b == 11)
		{
			return 56;
		}
		else if(a == 67 && b == 12)
		{
			return 55;
		}
		else if(a == 67 && b == 13)
		{
			return 54;
		}
		else if(a == 67 && b == 14)
		{
			return 53;
		}
		else if(a == 67 && b == 15)
		{
			return 52;
		}
		else if(a == 67 && b == 16)
		{
			return 51;
		}
		else if(a == 67 && b == 17)
		{
			return 50;
		}
		else if(a == 67 && b == 18)
		{
			return 49;
		}
		else if(a == 67 && b == 19)
		{
			return 48;
		}
		else if(a == 67 && b == 20)
		{
			return 47;
		}
		else if(a == 67 && b == 21)
		{
			return 46;
		}
		else if(a == 67 && b == 22)
		{
			return 45;
		}
		else if(a == 67 && b == 23)
		{
			return 44;
		}
		else if(a == 67 && b == 24)
		{
			return 43;
		}
		else if(a == 67 && b == 25)
		{
			return 42;
		}
		else if(a == 67 && b == 26)
		{
			return 41;
		}
		else if(a == 67 && b == 27)
		{
			return 40;
		}
		else if(a == 67 && b == 28)
		{
			return 39;
		}
		else if(a == 67 && b == 29)
		{
			return 38;
		}
		else if(a == 67 && b == 30)
		{
			return 37;
		}
		else if(a == 67 && b == 31)
		{
			return 36;
		}
		else if(a == 67 && b == 32)
		{
			return 35;
		}
		else if(a == 67 && b == 33)
		{
			return 34;
		}
		else if(a == 67 && b == 34)
		{
			return 33;
		}
		else if(a == 67 && b == 35)
		{
			return 32;
		}
		else if(a == 67 && b == 36)
		{
			return 31;
		}
		else if(a == 67 && b == 37)
		{
			return 30;
		}
		else if(a == 67 && b == 38)
		{
			return 29;
		}
		else if(a == 67 && b == 39)
		{
			return 28;
		}
		else if(a == 67 && b == 40)
		{
			return 27;
		}
		else if(a == 67 && b == 41)
		{
			return 26;
		}
		else if(a == 67 && b == 42)
		{
			return 25;
		}
		else if(a == 67 && b == 43)
		{
			return 24;
		}
		else if(a == 67 && b == 44)
		{
			return 23;
		}
		else if(a == 67 && b == 45)
		{
			return 22;
		}
		else if(a == 67 && b == 46)
		{
			return 21;
		}
		else if(a == 67 && b == 47)
		{
			return 20;
		}
		else if(a == 67 && b == 48)
		{
			return 19;
		}
		else if(a == 67 && b == 49)
		{
			return 18;
		}
		else if(a == 67 && b == 50)
		{
			return 17;
		}
		else if(a == 67 && b == 51)
		{
			return 16;
		}
		else if(a == 67 && b == 52)
		{
			return 15;
		}
		else if(a == 67 && b == 53)
		{
			return 14;
		}
		else if(a == 67 && b == 54)
		{
			return 13;
		}
		else if(a == 67 && b == 55)
		{
			return 12;
		}
		else if(a == 67 && b == 56)
		{
			return 11;
		}
		else if(a == 67 && b == 57)
		{
			return 10;
		}
		else if(a == 67 && b == 58)
		{
			return 9;
		}
		else if(a == 67 && b == 59)
		{
			return 8;
		}
		else if(a == 67 && b == 60)
		{
			return 7;
		}
		else if(a == 67 && b == 61)
		{
			return 6;
		}
		else if(a == 67 && b == 62)
		{
			return 5;
		}
		else if(a == 67 && b == 63)
		{
			return 4;
		}
		else if(a == 67 && b == 64)
		{
			return 3;
		}
		else if(a == 67 && b == 65)
		{
			return 2;
		}
		else if(a == 67 && b == 66)
		{
			return 1;
		}
		else if(a == 67 && b == 67)
		{
			return 0;
		}
		else if(a == 67 && b == 68)
		{
			return -1;
		}
		else if(a == 67 && b == 69)
		{
			return -2;
		}
		else if(a == 67 && b == 70)
		{
			return -3;
		}
		else if(a == 67 && b == 71)
		{
			return -4;
		}
		else if(a == 67 && b == 72)
		{
			return -5;
		}
		else if(a == 67 && b == 73)
		{
			return -6;
		}
		else if(a == 67 && b == 74)
		{
			return -7;
		}
		else if(a == 67 && b == 75)
		{
			return -8;
		}
		else if(a == 67 && b == 76)
		{
			return -9;
		}
		else if(a == 67 && b == 77)
		{
			return -10;
		}
		else if(a == 67 && b == 78)
		{
			return -11;
		}
		else if(a == 67 && b == 79)
		{
			return -12;
		}
		else if(a == 67 && b == 80)
		{
			return -13;
		}
		else if(a == 67 && b == 81)
		{
			return -14;
		}
		else if(a == 67 && b == 82)
		{
			return -15;
		}
		else if(a == 67 && b == 83)
		{
			return -16;
		}
		else if(a == 67 && b == 84)
		{
			return -17;
		}
		else if(a == 67 && b == 85)
		{
			return -18;
		}
		else if(a == 67 && b == 86)
		{
			return -19;
		}
		else if(a == 67 && b == 87)
		{
			return -20;
		}
		else if(a == 67 && b == 88)
		{
			return -21;
		}
		else if(a == 67 && b == 89)
		{
			return -22;
		}
		else if(a == 67 && b == 90)
		{
			return -23;
		}
		else if(a == 67 && b == 91)
		{
			return -24;
		}
		else if(a == 67 && b == 92)
		{
			return -25;
		}
		else if(a == 67 && b == 93)
		{
			return -26;
		}
		else if(a == 67 && b == 94)
		{
			return -27;
		}
		else if(a == 67 && b == 95)
		{
			return -28;
		}
		else if(a == 67 && b == 96)
		{
			return -29;
		}
		else if(a == 67 && b == 97)
		{
			return -30;
		}
		else if(a == 67 && b == 98)
		{
			return -31;
		}
		else if(a == 67 && b == 99)
		{
			return -32;
		}
		else if(a == 67 && b == 100)
		{
			return -33;
		}
		else if(a == 68 && b == 0)
		{
			return 68;
		}
		else if(a == 68 && b == 1)
		{
			return 67;
		}
		else if(a == 68 && b == 2)
		{
			return 66;
		}
		else if(a == 68 && b == 3)
		{
			return 65;
		}
		else if(a == 68 && b == 4)
		{
			return 64;
		}
		else if(a == 68 && b == 5)
		{
			return 63;
		}
		else if(a == 68 && b == 6)
		{
			return 62;
		}
		else if(a == 68 && b == 7)
		{
			return 61;
		}
		else if(a == 68 && b == 8)
		{
			return 60;
		}
		else if(a == 68 && b == 9)
		{
			return 59;
		}
		else if(a == 68 && b == 10)
		{
			return 58;
		}
		else if(a == 68 && b == 11)
		{
			return 57;
		}
		else if(a == 68 && b == 12)
		{
			return 56;
		}
		else if(a == 68 && b == 13)
		{
			return 55;
		}
		else if(a == 68 && b == 14)
		{
			return 54;
		}
		else if(a == 68 && b == 15)
		{
			return 53;
		}
		else if(a == 68 && b == 16)
		{
			return 52;
		}
		else if(a == 68 && b == 17)
		{
			return 51;
		}
		else if(a == 68 && b == 18)
		{
			return 50;
		}
		else if(a == 68 && b == 19)
		{
			return 49;
		}
		else if(a == 68 && b == 20)
		{
			return 48;
		}
		else if(a == 68 && b == 21)
		{
			return 47;
		}
		else if(a == 68 && b == 22)
		{
			return 46;
		}
		else if(a == 68 && b == 23)
		{
			return 45;
		}
		else if(a == 68 && b == 24)
		{
			return 44;
		}
		else if(a == 68 && b == 25)
		{
			return 43;
		}
		else if(a == 68 && b == 26)
		{
			return 42;
		}
		else if(a == 68 && b == 27)
		{
			return 41;
		}
		else if(a == 68 && b == 28)
		{
			return 40;
		}
		else if(a == 68 && b == 29)
		{
			return 39;
		}
		else if(a == 68 && b == 30)
		{
			return 38;
		}
		else if(a == 68 && b == 31)
		{
			return 37;
		}
		else if(a == 68 && b == 32)
		{
			return 36;
		}
		else if(a == 68 && b == 33)
		{
			return 35;
		}
		else if(a == 68 && b == 34)
		{
			return 34;
		}
		else if(a == 68 && b == 35)
		{
			return 33;
		}
		else if(a == 68 && b == 36)
		{
			return 32;
		}
		else if(a == 68 && b == 37)
		{
			return 31;
		}
		else if(a == 68 && b == 38)
		{
			return 30;
		}
		else if(a == 68 && b == 39)
		{
			return 29;
		}
		else if(a == 68 && b == 40)
		{
			return 28;
		}
		else if(a == 68 && b == 41)
		{
			return 27;
		}
		else if(a == 68 && b == 42)
		{
			return 26;
		}
		else if(a == 68 && b == 43)
		{
			return 25;
		}
		else if(a == 68 && b == 44)
		{
			return 24;
		}
		else if(a == 68 && b == 45)
		{
			return 23;
		}
		else if(a == 68 && b == 46)
		{
			return 22;
		}
		else if(a == 68 && b == 47)
		{
			return 21;
		}
		else if(a == 68 && b == 48)
		{
			return 20;
		}
		else if(a == 68 && b == 49)
		{
			return 19;
		}
		else if(a == 68 && b == 50)
		{
			return 18;
		}
		else if(a == 68 && b == 51)
		{
			return 17;
		}
		else if(a == 68 && b == 52)
		{
			return 16;
		}
		else if(a == 68 && b == 53)
		{
			return 15;
		}
		else if(a == 68 && b == 54)
		{
			return 14;
		}
		else if(a == 68 && b == 55)
		{
			return 13;
		}
		else if(a == 68 && b == 56)
		{
			return 12;
		}
		else if(a == 68 && b == 57)
		{
			return 11;
		}
		else if(a == 68 && b == 58)
		{
			return 10;
		}
		else if(a == 68 && b == 59)
		{
			return 9;
		}
		else if(a == 68 && b == 60)
		{
			return 8;
		}
		else if(a == 68 && b == 61)
		{
			return 7;
		}
		else if(a == 68 && b == 62)
		{
			return 6;
		}
		else if(a == 68 && b == 63)
		{
			return 5;
		}
		else if(a == 68 && b == 64)
		{
			return 4;
		}
		else if(a == 68 && b == 65)
		{
			return 3;
		}
		else if(a == 68 && b == 66)
		{
			return 2;
		}
		else if(a == 68 && b == 67)
		{
			return 1;
		}
		else if(a == 68 && b == 68)
		{
			return 0;
		}
		else if(a == 68 && b == 69)
		{
			return -1;
		}
		else if(a == 68 && b == 70)
		{
			return -2;
		}
		else if(a == 68 && b == 71)
		{
			return -3;
		}
		else if(a == 68 && b == 72)
		{
			return -4;
		}
		else if(a == 68 && b == 73)
		{
			return -5;
		}
		else if(a == 68 && b == 74)
		{
			return -6;
		}
		else if(a == 68 && b == 75)
		{
			return -7;
		}
		else if(a == 68 && b == 76)
		{
			return -8;
		}
		else if(a == 68 && b == 77)
		{
			return -9;
		}
		else if(a == 68 && b == 78)
		{
			return -10;
		}
		else if(a == 68 && b == 79)
		{
			return -11;
		}
		else if(a == 68 && b == 80)
		{
			return -12;
		}
		else if(a == 68 && b == 81)
		{
			return -13;
		}
		else if(a == 68 && b == 82)
		{
			return -14;
		}
		else if(a == 68 && b == 83)
		{
			return -15;
		}
		else if(a == 68 && b == 84)
		{
			return -16;
		}
		else if(a == 68 && b == 85)
		{
			return -17;
		}
		else if(a == 68 && b == 86)
		{
			return -18;
		}
		else if(a == 68 && b == 87)
		{
			return -19;
		}
		else if(a == 68 && b == 88)
		{
			return -20;
		}
		else if(a == 68 && b == 89)
		{
			return -21;
		}
		else if(a == 68 && b == 90)
		{
			return -22;
		}
		else if(a == 68 && b == 91)
		{
			return -23;
		}
		else if(a == 68 && b == 92)
		{
			return -24;
		}
		else if(a == 68 && b == 93)
		{
			return -25;
		}
		else if(a == 68 && b == 94)
		{
			return -26;
		}
		else if(a == 68 && b == 95)
		{
			return -27;
		}
		else if(a == 68 && b == 96)
		{
			return -28;
		}
		else if(a == 68 && b == 97)
		{
			return -29;
		}
		else if(a == 68 && b == 98)
		{
			return -30;
		}
		else if(a == 68 && b == 99)
		{
			return -31;
		}
		else if(a == 68 && b == 100)
		{
			return -32;
		}
		else if(a == 69 && b == 0)
		{
			return 69;
		}
		else if(a == 69 && b == 1)
		{
			return 68;
		}
		else if(a == 69 && b == 2)
		{
			return 67;
		}
		else if(a == 69 && b == 3)
		{
			return 66;
		}
		else if(a == 69 && b == 4)
		{
			return 65;
		}
		else if(a == 69 && b == 5)
		{
			return 64;
		}
		else if(a == 69 && b == 6)
		{
			return 63;
		}
		else if(a == 69 && b == 7)
		{
			return 62;
		}
		else if(a == 69 && b == 8)
		{
			return 61;
		}
		else if(a == 69 && b == 9)
		{
			return 60;
		}
		else if(a == 69 && b == 10)
		{
			return 59;
		}
		else if(a == 69 && b == 11)
		{
			return 58;
		}
		else if(a == 69 && b == 12)
		{
			return 57;
		}
		else if(a == 69 && b == 13)
		{
			return 56;
		}
		else if(a == 69 && b == 14)
		{
			return 55;
		}
		else if(a == 69 && b == 15)
		{
			return 54;
		}
		else if(a == 69 && b == 16)
		{
			return 53;
		}
		else if(a == 69 && b == 17)
		{
			return 52;
		}
		else if(a == 69 && b == 18)
		{
			return 51;
		}
		else if(a == 69 && b == 19)
		{
			return 50;
		}
		else if(a == 69 && b == 20)
		{
			return 49;
		}
		else if(a == 69 && b == 21)
		{
			return 48;
		}
		else if(a == 69 && b == 22)
		{
			return 47;
		}
		else if(a == 69 && b == 23)
		{
			return 46;
		}
		else if(a == 69 && b == 24)
		{
			return 45;
		}
		else if(a == 69 && b == 25)
		{
			return 44;
		}
		else if(a == 69 && b == 26)
		{
			return 43;
		}
		else if(a == 69 && b == 27)
		{
			return 42;
		}
		else if(a == 69 && b == 28)
		{
			return 41;
		}
		else if(a == 69 && b == 29)
		{
			return 40;
		}
		else if(a == 69 && b == 30)
		{
			return 39;
		}
		else if(a == 69 && b == 31)
		{
			return 38;
		}
		else if(a == 69 && b == 32)
		{
			return 37;
		}
		else if(a == 69 && b == 33)
		{
			return 36;
		}
		else if(a == 69 && b == 34)
		{
			return 35;
		}
		else if(a == 69 && b == 35)
		{
			return 34;
		}
		else if(a == 69 && b == 36)
		{
			return 33;
		}
		else if(a == 69 && b == 37)
		{
			return 32;
		}
		else if(a == 69 && b == 38)
		{
			return 31;
		}
		else if(a == 69 && b == 39)
		{
			return 30;
		}
		else if(a == 69 && b == 40)
		{
			return 29;
		}
		else if(a == 69 && b == 41)
		{
			return 28;
		}
		else if(a == 69 && b == 42)
		{
			return 27;
		}
		else if(a == 69 && b == 43)
		{
			return 26;
		}
		else if(a == 69 && b == 44)
		{
			return 25;
		}
		else if(a == 69 && b == 45)
		{
			return 24;
		}
		else if(a == 69 && b == 46)
		{
			return 23;
		}
		else if(a == 69 && b == 47)
		{
			return 22;
		}
		else if(a == 69 && b == 48)
		{
			return 21;
		}
		else if(a == 69 && b == 49)
		{
			return 20;
		}
		else if(a == 69 && b == 50)
		{
			return 19;
		}
		else if(a == 69 && b == 51)
		{
			return 18;
		}
		else if(a == 69 && b == 52)
		{
			return 17;
		}
		else if(a == 69 && b == 53)
		{
			return 16;
		}
		else if(a == 69 && b == 54)
		{
			return 15;
		}
		else if(a == 69 && b == 55)
		{
			return 14;
		}
		else if(a == 69 && b == 56)
		{
			return 13;
		}
		else if(a == 69 && b == 57)
		{
			return 12;
		}
		else if(a == 69 && b == 58)
		{
			return 11;
		}
		else if(a == 69 && b == 59)
		{
			return 10;
		}
		else if(a == 69 && b == 60)
		{
			return 9;
		}
		else if(a == 69 && b == 61)
		{
			return 8;
		}
		else if(a == 69 && b == 62)
		{
			return 7;
		}
		else if(a == 69 && b == 63)
		{
			return 6;
		}
		else if(a == 69 && b == 64)
		{
			return 5;
		}
		else if(a == 69 && b == 65)
		{
			return 4;
		}
		else if(a == 69 && b == 66)
		{
			return 3;
		}
		else if(a == 69 && b == 67)
		{
			return 2;
		}
		else if(a == 69 && b == 68)
		{
			return 1;
		}
		else if(a == 69 && b == 69)
		{
			return 0;
		}
		else if(a == 69 && b == 70)
		{
			return -1;
		}
		else if(a == 69 && b == 71)
		{
			return -2;
		}
		else if(a == 69 && b == 72)
		{
			return -3;
		}
		else if(a == 69 && b == 73)
		{
			return -4;
		}
		else if(a == 69 && b == 74)
		{
			return -5;
		}
		else if(a == 69 && b == 75)
		{
			return -6;
		}
		else if(a == 69 && b == 76)
		{
			return -7;
		}
		else if(a == 69 && b == 77)
		{
			return -8;
		}
		else if(a == 69 && b == 78)
		{
			return -9;
		}
		else if(a == 69 && b == 79)
		{
			return -10;
		}
		else if(a == 69 && b == 80)
		{
			return -11;
		}
		else if(a == 69 && b == 81)
		{
			return -12;
		}
		else if(a == 69 && b == 82)
		{
			return -13;
		}
		else if(a == 69 && b == 83)
		{
			return -14;
		}
		else if(a == 69 && b == 84)
		{
			return -15;
		}
		else if(a == 69 && b == 85)
		{
			return -16;
		}
		else if(a == 69 && b == 86)
		{
			return -17;
		}
		else if(a == 69 && b == 87)
		{
			return -18;
		}
		else if(a == 69 && b == 88)
		{
			return -19;
		}
		else if(a == 69 && b == 89)
		{
			return -20;
		}
		else if(a == 69 && b == 90)
		{
			return -21;
		}
		else if(a == 69 && b == 91)
		{
			return -22;
		}
		else if(a == 69 && b == 92)
		{
			return -23;
		}
		else if(a == 69 && b == 93)
		{
			return -24;
		}
		else if(a == 69 && b == 94)
		{
			return -25;
		}
		else if(a == 69 && b == 95)
		{
			return -26;
		}
		else if(a == 69 && b == 96)
		{
			return -27;
		}
		else if(a == 69 && b == 97)
		{
			return -28;
		}
		else if(a == 69 && b == 98)
		{
			return -29;
		}
		else if(a == 69 && b == 99)
		{
			return -30;
		}
		else if(a == 69 && b == 100)
		{
			return -31;
		}
		else if(a == 70 && b == 0)
		{
			return 70;
		}
		else if(a == 70 && b == 1)
		{
			return 69;
		}
		else if(a == 70 && b == 2)
		{
			return 68;
		}
		else if(a == 70 && b == 3)
		{
			return 67;
		}
		else if(a == 70 && b == 4)
		{
			return 66;
		}
		else if(a == 70 && b == 5)
		{
			return 65;
		}
		else if(a == 70 && b == 6)
		{
			return 64;
		}
		else if(a == 70 && b == 7)
		{
			return 63;
		}
		else if(a == 70 && b == 8)
		{
			return 62;
		}
		else if(a == 70 && b == 9)
		{
			return 61;
		}
		else if(a == 70 && b == 10)
		{
			return 60;
		}
		else if(a == 70 && b == 11)
		{
			return 59;
		}
		else if(a == 70 && b == 12)
		{
			return 58;
		}
		else if(a == 70 && b == 13)
		{
			return 57;
		}
		else if(a == 70 && b == 14)
		{
			return 56;
		}
		else if(a == 70 && b == 15)
		{
			return 55;
		}
		else if(a == 70 && b == 16)
		{
			return 54;
		}
		else if(a == 70 && b == 17)
		{
			return 53;
		}
		else if(a == 70 && b == 18)
		{
			return 52;
		}
		else if(a == 70 && b == 19)
		{
			return 51;
		}
		else if(a == 70 && b == 20)
		{
			return 50;
		}
		else if(a == 70 && b == 21)
		{
			return 49;
		}
		else if(a == 70 && b == 22)
		{
			return 48;
		}
		else if(a == 70 && b == 23)
		{
			return 47;
		}
		else if(a == 70 && b == 24)
		{
			return 46;
		}
		else if(a == 70 && b == 25)
		{
			return 45;
		}
		else if(a == 70 && b == 26)
		{
			return 44;
		}
		else if(a == 70 && b == 27)
		{
			return 43;
		}
		else if(a == 70 && b == 28)
		{
			return 42;
		}
		else if(a == 70 && b == 29)
		{
			return 41;
		}
		else if(a == 70 && b == 30)
		{
			return 40;
		}
		else if(a == 70 && b == 31)
		{
			return 39;
		}
		else if(a == 70 && b == 32)
		{
			return 38;
		}
		else if(a == 70 && b == 33)
		{
			return 37;
		}
		else if(a == 70 && b == 34)
		{
			return 36;
		}
		else if(a == 70 && b == 35)
		{
			return 35;
		}
		else if(a == 70 && b == 36)
		{
			return 34;
		}
		else if(a == 70 && b == 37)
		{
			return 33;
		}
		else if(a == 70 && b == 38)
		{
			return 32;
		}
		else if(a == 70 && b == 39)
		{
			return 31;
		}
		else if(a == 70 && b == 40)
		{
			return 30;
		}
		else if(a == 70 && b == 41)
		{
			return 29;
		}
		else if(a == 70 && b == 42)
		{
			return 28;
		}
		else if(a == 70 && b == 43)
		{
			return 27;
		}
		else if(a == 70 && b == 44)
		{
			return 26;
		}
		else if(a == 70 && b == 45)
		{
			return 25;
		}
		else if(a == 70 && b == 46)
		{
			return 24;
		}
		else if(a == 70 && b == 47)
		{
			return 23;
		}
		else if(a == 70 && b == 48)
		{
			return 22;
		}
		else if(a == 70 && b == 49)
		{
			return 21;
		}
		else if(a == 70 && b == 50)
		{
			return 20;
		}
		else if(a == 70 && b == 51)
		{
			return 19;
		}
		else if(a == 70 && b == 52)
		{
			return 18;
		}
		else if(a == 70 && b == 53)
		{
			return 17;
		}
		else if(a == 70 && b == 54)
		{
			return 16;
		}
		else if(a == 70 && b == 55)
		{
			return 15;
		}
		else if(a == 70 && b == 56)
		{
			return 14;
		}
		else if(a == 70 && b == 57)
		{
			return 13;
		}
		else if(a == 70 && b == 58)
		{
			return 12;
		}
		else if(a == 70 && b == 59)
		{
			return 11;
		}
		else if(a == 70 && b == 60)
		{
			return 10;
		}
		else if(a == 70 && b == 61)
		{
			return 9;
		}
		else if(a == 70 && b == 62)
		{
			return 8;
		}
		else if(a == 70 && b == 63)
		{
			return 7;
		}
		else if(a == 70 && b == 64)
		{
			return 6;
		}
		else if(a == 70 && b == 65)
		{
			return 5;
		}
		else if(a == 70 && b == 66)
		{
			return 4;
		}
		else if(a == 70 && b == 67)
		{
			return 3;
		}
		else if(a == 70 && b == 68)
		{
			return 2;
		}
		else if(a == 70 && b == 69)
		{
			return 1;
		}
		else if(a == 70 && b == 70)
		{
			return 0;
		}
		else if(a == 70 && b == 71)
		{
			return -1;
		}
		else if(a == 70 && b == 72)
		{
			return -2;
		}
		else if(a == 70 && b == 73)
		{
			return -3;
		}
		else if(a == 70 && b == 74)
		{
			return -4;
		}
		else if(a == 70 && b == 75)
		{
			return -5;
		}
		else if(a == 70 && b == 76)
		{
			return -6;
		}
		else if(a == 70 && b == 77)
		{
			return -7;
		}
		else if(a == 70 && b == 78)
		{
			return -8;
		}
		else if(a == 70 && b == 79)
		{
			return -9;
		}
		else if(a == 70 && b == 80)
		{
			return -10;
		}
		else if(a == 70 && b == 81)
		{
			return -11;
		}
		else if(a == 70 && b == 82)
		{
			return -12;
		}
		else if(a == 70 && b == 83)
		{
			return -13;
		}
		else if(a == 70 && b == 84)
		{
			return -14;
		}
		else if(a == 70 && b == 85)
		{
			return -15;
		}
		else if(a == 70 && b == 86)
		{
			return -16;
		}
		else if(a == 70 && b == 87)
		{
			return -17;
		}
		else if(a == 70 && b == 88)
		{
			return -18;
		}
		else if(a == 70 && b == 89)
		{
			return -19;
		}
		else if(a == 70 && b == 90)
		{
			return -20;
		}
		else if(a == 70 && b == 91)
		{
			return -21;
		}
		else if(a == 70 && b == 92)
		{
			return -22;
		}
		else if(a == 70 && b == 93)
		{
			return -23;
		}
		else if(a == 70 && b == 94)
		{
			return -24;
		}
		else if(a == 70 && b == 95)
		{
			return -25;
		}
		else if(a == 70 && b == 96)
		{
			return -26;
		}
		else if(a == 70 && b == 97)
		{
			return -27;
		}
		else if(a == 70 && b == 98)
		{
			return -28;
		}
		else if(a == 70 && b == 99)
		{
			return -29;
		}
		else if(a == 70 && b == 100)
		{
			return -30;
		}
		else if(a == 71 && b == 0)
		{
			return 71;
		}
		else if(a == 71 && b == 1)
		{
			return 70;
		}
		else if(a == 71 && b == 2)
		{
			return 69;
		}
		else if(a == 71 && b == 3)
		{
			return 68;
		}
		else if(a == 71 && b == 4)
		{
			return 67;
		}
		else if(a == 71 && b == 5)
		{
			return 66;
		}
		else if(a == 71 && b == 6)
		{
			return 65;
		}
		else if(a == 71 && b == 7)
		{
			return 64;
		}
		else if(a == 71 && b == 8)
		{
			return 63;
		}
		else if(a == 71 && b == 9)
		{
			return 62;
		}
		else if(a == 71 && b == 10)
		{
			return 61;
		}
		else if(a == 71 && b == 11)
		{
			return 60;
		}
		else if(a == 71 && b == 12)
		{
			return 59;
		}
		else if(a == 71 && b == 13)
		{
			return 58;
		}
		else if(a == 71 && b == 14)
		{
			return 57;
		}
		else if(a == 71 && b == 15)
		{
			return 56;
		}
		else if(a == 71 && b == 16)
		{
			return 55;
		}
		else if(a == 71 && b == 17)
		{
			return 54;
		}
		else if(a == 71 && b == 18)
		{
			return 53;
		}
		else if(a == 71 && b == 19)
		{
			return 52;
		}
		else if(a == 71 && b == 20)
		{
			return 51;
		}
		else if(a == 71 && b == 21)
		{
			return 50;
		}
		else if(a == 71 && b == 22)
		{
			return 49;
		}
		else if(a == 71 && b == 23)
		{
			return 48;
		}
		else if(a == 71 && b == 24)
		{
			return 47;
		}
		else if(a == 71 && b == 25)
		{
			return 46;
		}
		else if(a == 71 && b == 26)
		{
			return 45;
		}
		else if(a == 71 && b == 27)
		{
			return 44;
		}
		else if(a == 71 && b == 28)
		{
			return 43;
		}
		else if(a == 71 && b == 29)
		{
			return 42;
		}
		else if(a == 71 && b == 30)
		{
			return 41;
		}
		else if(a == 71 && b == 31)
		{
			return 40;
		}
		else if(a == 71 && b == 32)
		{
			return 39;
		}
		else if(a == 71 && b == 33)
		{
			return 38;
		}
		else if(a == 71 && b == 34)
		{
			return 37;
		}
		else if(a == 71 && b == 35)
		{
			return 36;
		}
		else if(a == 71 && b == 36)
		{
			return 35;
		}
		else if(a == 71 && b == 37)
		{
			return 34;
		}
		else if(a == 71 && b == 38)
		{
			return 33;
		}
		else if(a == 71 && b == 39)
		{
			return 32;
		}
		else if(a == 71 && b == 40)
		{
			return 31;
		}
		else if(a == 71 && b == 41)
		{
			return 30;
		}
		else if(a == 71 && b == 42)
		{
			return 29;
		}
		else if(a == 71 && b == 43)
		{
			return 28;
		}
		else if(a == 71 && b == 44)
		{
			return 27;
		}
		else if(a == 71 && b == 45)
		{
			return 26;
		}
		else if(a == 71 && b == 46)
		{
			return 25;
		}
		else if(a == 71 && b == 47)
		{
			return 24;
		}
		else if(a == 71 && b == 48)
		{
			return 23;
		}
		else if(a == 71 && b == 49)
		{
			return 22;
		}
		else if(a == 71 && b == 50)
		{
			return 21;
		}
		else if(a == 71 && b == 51)
		{
			return 20;
		}
		else if(a == 71 && b == 52)
		{
			return 19;
		}
		else if(a == 71 && b == 53)
		{
			return 18;
		}
		else if(a == 71 && b == 54)
		{
			return 17;
		}
		else if(a == 71 && b == 55)
		{
			return 16;
		}
		else if(a == 71 && b == 56)
		{
			return 15;
		}
		else if(a == 71 && b == 57)
		{
			return 14;
		}
		else if(a == 71 && b == 58)
		{
			return 13;
		}
		else if(a == 71 && b == 59)
		{
			return 12;
		}
		else if(a == 71 && b == 60)
		{
			return 11;
		}
		else if(a == 71 && b == 61)
		{
			return 10;
		}
		else if(a == 71 && b == 62)
		{
			return 9;
		}
		else if(a == 71 && b == 63)
		{
			return 8;
		}
		else if(a == 71 && b == 64)
		{
			return 7;
		}
		else if(a == 71 && b == 65)
		{
			return 6;
		}
		else if(a == 71 && b == 66)
		{
			return 5;
		}
		else if(a == 71 && b == 67)
		{
			return 4;
		}
		else if(a == 71 && b == 68)
		{
			return 3;
		}
		else if(a == 71 && b == 69)
		{
			return 2;
		}
		else if(a == 71 && b == 70)
		{
			return 1;
		}
		else if(a == 71 && b == 71)
		{
			return 0;
		}
		else if(a == 71 && b == 72)
		{
			return -1;
		}
		else if(a == 71 && b == 73)
		{
			return -2;
		}
		else if(a == 71 && b == 74)
		{
			return -3;
		}
		else if(a == 71 && b == 75)
		{
			return -4;
		}
		else if(a == 71 && b == 76)
		{
			return -5;
		}
		else if(a == 71 && b == 77)
		{
			return -6;
		}
		else if(a == 71 && b == 78)
		{
			return -7;
		}
		else if(a == 71 && b == 79)
		{
			return -8;
		}
		else if(a == 71 && b == 80)
		{
			return -9;
		}
		else if(a == 71 && b == 81)
		{
			return -10;
		}
		else if(a == 71 && b == 82)
		{
			return -11;
		}
		else if(a == 71 && b == 83)
		{
			return -12;
		}
		else if(a == 71 && b == 84)
		{
			return -13;
		}
		else if(a == 71 && b == 85)
		{
			return -14;
		}
		else if(a == 71 && b == 86)
		{
			return -15;
		}
		else if(a == 71 && b == 87)
		{
			return -16;
		}
		else if(a == 71 && b == 88)
		{
			return -17;
		}
		else if(a == 71 && b == 89)
		{
			return -18;
		}
		else if(a == 71 && b == 90)
		{
			return -19;
		}
		else if(a == 71 && b == 91)
		{
			return -20;
		}
		else if(a == 71 && b == 92)
		{
			return -21;
		}
		else if(a == 71 && b == 93)
		{
			return -22;
		}
		else if(a == 71 && b == 94)
		{
			return -23;
		}
		else if(a == 71 && b == 95)
		{
			return -24;
		}
		else if(a == 71 && b == 96)
		{
			return -25;
		}
		else if(a == 71 && b == 97)
		{
			return -26;
		}
		else if(a == 71 && b == 98)
		{
			return -27;
		}
		else if(a == 71 && b == 99)
		{
			return -28;
		}
		else if(a == 71 && b == 100)
		{
			return -29;
		}
		else if(a == 72 && b == 0)
		{
			return 72;
		}
		else if(a == 72 && b == 1)
		{
			return 71;
		}
		else if(a == 72 && b == 2)
		{
			return 70;
		}
		else if(a == 72 && b == 3)
		{
			return 69;
		}
		else if(a == 72 && b == 4)
		{
			return 68;
		}
		else if(a == 72 && b == 5)
		{
			return 67;
		}
		else if(a == 72 && b == 6)
		{
			return 66;
		}
		else if(a == 72 && b == 7)
		{
			return 65;
		}
		else if(a == 72 && b == 8)
		{
			return 64;
		}
		else if(a == 72 && b == 9)
		{
			return 63;
		}
		else if(a == 72 && b == 10)
		{
			return 62;
		}
		else if(a == 72 && b == 11)
		{
			return 61;
		}
		else if(a == 72 && b == 12)
		{
			return 60;
		}
		else if(a == 72 && b == 13)
		{
			return 59;
		}
		else if(a == 72 && b == 14)
		{
			return 58;
		}
		else if(a == 72 && b == 15)
		{
			return 57;
		}
		else if(a == 72 && b == 16)
		{
			return 56;
		}
		else if(a == 72 && b == 17)
		{
			return 55;
		}
		else if(a == 72 && b == 18)
		{
			return 54;
		}
		else if(a == 72 && b == 19)
		{
			return 53;
		}
		else if(a == 72 && b == 20)
		{
			return 52;
		}
		else if(a == 72 && b == 21)
		{
			return 51;
		}
		else if(a == 72 && b == 22)
		{
			return 50;
		}
		else if(a == 72 && b == 23)
		{
			return 49;
		}
		else if(a == 72 && b == 24)
		{
			return 48;
		}
		else if(a == 72 && b == 25)
		{
			return 47;
		}
		else if(a == 72 && b == 26)
		{
			return 46;
		}
		else if(a == 72 && b == 27)
		{
			return 45;
		}
		else if(a == 72 && b == 28)
		{
			return 44;
		}
		else if(a == 72 && b == 29)
		{
			return 43;
		}
		else if(a == 72 && b == 30)
		{
			return 42;
		}
		else if(a == 72 && b == 31)
		{
			return 41;
		}
		else if(a == 72 && b == 32)
		{
			return 40;
		}
		else if(a == 72 && b == 33)
		{
			return 39;
		}
		else if(a == 72 && b == 34)
		{
			return 38;
		}
		else if(a == 72 && b == 35)
		{
			return 37;
		}
		else if(a == 72 && b == 36)
		{
			return 36;
		}
		else if(a == 72 && b == 37)
		{
			return 35;
		}
		else if(a == 72 && b == 38)
		{
			return 34;
		}
		else if(a == 72 && b == 39)
		{
			return 33;
		}
		else if(a == 72 && b == 40)
		{
			return 32;
		}
		else if(a == 72 && b == 41)
		{
			return 31;
		}
		else if(a == 72 && b == 42)
		{
			return 30;
		}
		else if(a == 72 && b == 43)
		{
			return 29;
		}
		else if(a == 72 && b == 44)
		{
			return 28;
		}
		else if(a == 72 && b == 45)
		{
			return 27;
		}
		else if(a == 72 && b == 46)
		{
			return 26;
		}
		else if(a == 72 && b == 47)
		{
			return 25;
		}
		else if(a == 72 && b == 48)
		{
			return 24;
		}
		else if(a == 72 && b == 49)
		{
			return 23;
		}
		else if(a == 72 && b == 50)
		{
			return 22;
		}
		else if(a == 72 && b == 51)
		{
			return 21;
		}
		else if(a == 72 && b == 52)
		{
			return 20;
		}
		else if(a == 72 && b == 53)
		{
			return 19;
		}
		else if(a == 72 && b == 54)
		{
			return 18;
		}
		else if(a == 72 && b == 55)
		{
			return 17;
		}
		else if(a == 72 && b == 56)
		{
			return 16;
		}
		else if(a == 72 && b == 57)
		{
			return 15;
		}
		else if(a == 72 && b == 58)
		{
			return 14;
		}
		else if(a == 72 && b == 59)
		{
			return 13;
		}
		else if(a == 72 && b == 60)
		{
			return 12;
		}
		else if(a == 72 && b == 61)
		{
			return 11;
		}
		else if(a == 72 && b == 62)
		{
			return 10;
		}
		else if(a == 72 && b == 63)
		{
			return 9;
		}
		else if(a == 72 && b == 64)
		{
			return 8;
		}
		else if(a == 72 && b == 65)
		{
			return 7;
		}
		else if(a == 72 && b == 66)
		{
			return 6;
		}
		else if(a == 72 && b == 67)
		{
			return 5;
		}
		else if(a == 72 && b == 68)
		{
			return 4;
		}
		else if(a == 72 && b == 69)
		{
			return 3;
		}
		else if(a == 72 && b == 70)
		{
			return 2;
		}
		else if(a == 72 && b == 71)
		{
			return 1;
		}
		else if(a == 72 && b == 72)
		{
			return 0;
		}
		else if(a == 72 && b == 73)
		{
			return -1;
		}
		else if(a == 72 && b == 74)
		{
			return -2;
		}
		else if(a == 72 && b == 75)
		{
			return -3;
		}
		else if(a == 72 && b == 76)
		{
			return -4;
		}
		else if(a == 72 && b == 77)
		{
			return -5;
		}
		else if(a == 72 && b == 78)
		{
			return -6;
		}
		else if(a == 72 && b == 79)
		{
			return -7;
		}
		else if(a == 72 && b == 80)
		{
			return -8;
		}
		else if(a == 72 && b == 81)
		{
			return -9;
		}
		else if(a == 72 && b == 82)
		{
			return -10;
		}
		else if(a == 72 && b == 83)
		{
			return -11;
		}
		else if(a == 72 && b == 84)
		{
			return -12;
		}
		else if(a == 72 && b == 85)
		{
			return -13;
		}
		else if(a == 72 && b == 86)
		{
			return -14;
		}
		else if(a == 72 && b == 87)
		{
			return -15;
		}
		else if(a == 72 && b == 88)
		{
			return -16;
		}
		else if(a == 72 && b == 89)
		{
			return -17;
		}
		else if(a == 72 && b == 90)
		{
			return -18;
		}
		else if(a == 72 && b == 91)
		{
			return -19;
		}
		else if(a == 72 && b == 92)
		{
			return -20;
		}
		else if(a == 72 && b == 93)
		{
			return -21;
		}
		else if(a == 72 && b == 94)
		{
			return -22;
		}
		else if(a == 72 && b == 95)
		{
			return -23;
		}
		else if(a == 72 && b == 96)
		{
			return -24;
		}
		else if(a == 72 && b == 97)
		{
			return -25;
		}
		else if(a == 72 && b == 98)
		{
			return -26;
		}
		else if(a == 72 && b == 99)
		{
			return -27;
		}
		else if(a == 72 && b == 100)
		{
			return -28;
		}
		else if(a == 73 && b == 0)
		{
			return 73;
		}
		else if(a == 73 && b == 1)
		{
			return 72;
		}
		else if(a == 73 && b == 2)
		{
			return 71;
		}
		else if(a == 73 && b == 3)
		{
			return 70;
		}
		else if(a == 73 && b == 4)
		{
			return 69;
		}
		else if(a == 73 && b == 5)
		{
			return 68;
		}
		else if(a == 73 && b == 6)
		{
			return 67;
		}
		else if(a == 73 && b == 7)
		{
			return 66;
		}
		else if(a == 73 && b == 8)
		{
			return 65;
		}
		else if(a == 73 && b == 9)
		{
			return 64;
		}
		else if(a == 73 && b == 10)
		{
			return 63;
		}
		else if(a == 73 && b == 11)
		{
			return 62;
		}
		else if(a == 73 && b == 12)
		{
			return 61;
		}
		else if(a == 73 && b == 13)
		{
			return 60;
		}
		else if(a == 73 && b == 14)
		{
			return 59;
		}
		else if(a == 73 && b == 15)
		{
			return 58;
		}
		else if(a == 73 && b == 16)
		{
			return 57;
		}
		else if(a == 73 && b == 17)
		{
			return 56;
		}
		else if(a == 73 && b == 18)
		{
			return 55;
		}
		else if(a == 73 && b == 19)
		{
			return 54;
		}
		else if(a == 73 && b == 20)
		{
			return 53;
		}
		else if(a == 73 && b == 21)
		{
			return 52;
		}
		else if(a == 73 && b == 22)
		{
			return 51;
		}
		else if(a == 73 && b == 23)
		{
			return 50;
		}
		else if(a == 73 && b == 24)
		{
			return 49;
		}
		else if(a == 73 && b == 25)
		{
			return 48;
		}
		else if(a == 73 && b == 26)
		{
			return 47;
		}
		else if(a == 73 && b == 27)
		{
			return 46;
		}
		else if(a == 73 && b == 28)
		{
			return 45;
		}
		else if(a == 73 && b == 29)
		{
			return 44;
		}
		else if(a == 73 && b == 30)
		{
			return 43;
		}
		else if(a == 73 && b == 31)
		{
			return 42;
		}
		else if(a == 73 && b == 32)
		{
			return 41;
		}
		else if(a == 73 && b == 33)
		{
			return 40;
		}
		else if(a == 73 && b == 34)
		{
			return 39;
		}
		else if(a == 73 && b == 35)
		{
			return 38;
		}
		else if(a == 73 && b == 36)
		{
			return 37;
		}
		else if(a == 73 && b == 37)
		{
			return 36;
		}
		else if(a == 73 && b == 38)
		{
			return 35;
		}
		else if(a == 73 && b == 39)
		{
			return 34;
		}
		else if(a == 73 && b == 40)
		{
			return 33;
		}
		else if(a == 73 && b == 41)
		{
			return 32;
		}
		else if(a == 73 && b == 42)
		{
			return 31;
		}
		else if(a == 73 && b == 43)
		{
			return 30;
		}
		else if(a == 73 && b == 44)
		{
			return 29;
		}
		else if(a == 73 && b == 45)
		{
			return 28;
		}
		else if(a == 73 && b == 46)
		{
			return 27;
		}
		else if(a == 73 && b == 47)
		{
			return 26;
		}
		else if(a == 73 && b == 48)
		{
			return 25;
		}
		else if(a == 73 && b == 49)
		{
			return 24;
		}
		else if(a == 73 && b == 50)
		{
			return 23;
		}
		else if(a == 73 && b == 51)
		{
			return 22;
		}
		else if(a == 73 && b == 52)
		{
			return 21;
		}
		else if(a == 73 && b == 53)
		{
			return 20;
		}
		else if(a == 73 && b == 54)
		{
			return 19;
		}
		else if(a == 73 && b == 55)
		{
			return 18;
		}
		else if(a == 73 && b == 56)
		{
			return 17;
		}
		else if(a == 73 && b == 57)
		{
			return 16;
		}
		else if(a == 73 && b == 58)
		{
			return 15;
		}
		else if(a == 73 && b == 59)
		{
			return 14;
		}
		else if(a == 73 && b == 60)
		{
			return 13;
		}
		else if(a == 73 && b == 61)
		{
			return 12;
		}
		else if(a == 73 && b == 62)
		{
			return 11;
		}
		else if(a == 73 && b == 63)
		{
			return 10;
		}
		else if(a == 73 && b == 64)
		{
			return 9;
		}
		else if(a == 73 && b == 65)
		{
			return 8;
		}
		else if(a == 73 && b == 66)
		{
			return 7;
		}
		else if(a == 73 && b == 67)
		{
			return 6;
		}
		else if(a == 73 && b == 68)
		{
			return 5;
		}
		else if(a == 73 && b == 69)
		{
			return 4;
		}
		else if(a == 73 && b == 70)
		{
			return 3;
		}
		else if(a == 73 && b == 71)
		{
			return 2;
		}
		else if(a == 73 && b == 72)
		{
			return 1;
		}
		else if(a == 73 && b == 73)
		{
			return 0;
		}
		else if(a == 73 && b == 74)
		{
			return -1;
		}
		else if(a == 73 && b == 75)
		{
			return -2;
		}
		else if(a == 73 && b == 76)
		{
			return -3;
		}
		else if(a == 73 && b == 77)
		{
			return -4;
		}
		else if(a == 73 && b == 78)
		{
			return -5;
		}
		else if(a == 73 && b == 79)
		{
			return -6;
		}
		else if(a == 73 && b == 80)
		{
			return -7;
		}
		else if(a == 73 && b == 81)
		{
			return -8;
		}
		else if(a == 73 && b == 82)
		{
			return -9;
		}
		else if(a == 73 && b == 83)
		{
			return -10;
		}
		else if(a == 73 && b == 84)
		{
			return -11;
		}
		else if(a == 73 && b == 85)
		{
			return -12;
		}
		else if(a == 73 && b == 86)
		{
			return -13;
		}
		else if(a == 73 && b == 87)
		{
			return -14;
		}
		else if(a == 73 && b == 88)
		{
			return -15;
		}
		else if(a == 73 && b == 89)
		{
			return -16;
		}
		else if(a == 73 && b == 90)
		{
			return -17;
		}
		else if(a == 73 && b == 91)
		{
			return -18;
		}
		else if(a == 73 && b == 92)
		{
			return -19;
		}
		else if(a == 73 && b == 93)
		{
			return -20;
		}
		else if(a == 73 && b == 94)
		{
			return -21;
		}
		else if(a == 73 && b == 95)
		{
			return -22;
		}
		else if(a == 73 && b == 96)
		{
			return -23;
		}
		else if(a == 73 && b == 97)
		{
			return -24;
		}
		else if(a == 73 && b == 98)
		{
			return -25;
		}
		else if(a == 73 && b == 99)
		{
			return -26;
		}
		else if(a == 73 && b == 100)
		{
			return -27;
		}
		else if(a == 74 && b == 0)
		{
			return 74;
		}
		else if(a == 74 && b == 1)
		{
			return 73;
		}
		else if(a == 74 && b == 2)
		{
			return 72;
		}
		else if(a == 74 && b == 3)
		{
			return 71;
		}
		else if(a == 74 && b == 4)
		{
			return 70;
		}
		else if(a == 74 && b == 5)
		{
			return 69;
		}
		else if(a == 74 && b == 6)
		{
			return 68;
		}
		else if(a == 74 && b == 7)
		{
			return 67;
		}
		else if(a == 74 && b == 8)
		{
			return 66;
		}
		else if(a == 74 && b == 9)
		{
			return 65;
		}
		else if(a == 74 && b == 10)
		{
			return 64;
		}
		else if(a == 74 && b == 11)
		{
			return 63;
		}
		else if(a == 74 && b == 12)
		{
			return 62;
		}
		else if(a == 74 && b == 13)
		{
			return 61;
		}
		else if(a == 74 && b == 14)
		{
			return 60;
		}
		else if(a == 74 && b == 15)
		{
			return 59;
		}
		else if(a == 74 && b == 16)
		{
			return 58;
		}
		else if(a == 74 && b == 17)
		{
			return 57;
		}
		else if(a == 74 && b == 18)
		{
			return 56;
		}
		else if(a == 74 && b == 19)
		{
			return 55;
		}
		else if(a == 74 && b == 20)
		{
			return 54;
		}
		else if(a == 74 && b == 21)
		{
			return 53;
		}
		else if(a == 74 && b == 22)
		{
			return 52;
		}
		else if(a == 74 && b == 23)
		{
			return 51;
		}
		else if(a == 74 && b == 24)
		{
			return 50;
		}
		else if(a == 74 && b == 25)
		{
			return 49;
		}
		else if(a == 74 && b == 26)
		{
			return 48;
		}
		else if(a == 74 && b == 27)
		{
			return 47;
		}
		else if(a == 74 && b == 28)
		{
			return 46;
		}
		else if(a == 74 && b == 29)
		{
			return 45;
		}
		else if(a == 74 && b == 30)
		{
			return 44;
		}
		else if(a == 74 && b == 31)
		{
			return 43;
		}
		else if(a == 74 && b == 32)
		{
			return 42;
		}
		else if(a == 74 && b == 33)
		{
			return 41;
		}
		else if(a == 74 && b == 34)
		{
			return 40;
		}
		else if(a == 74 && b == 35)
		{
			return 39;
		}
		else if(a == 74 && b == 36)
		{
			return 38;
		}
		else if(a == 74 && b == 37)
		{
			return 37;
		}
		else if(a == 74 && b == 38)
		{
			return 36;
		}
		else if(a == 74 && b == 39)
		{
			return 35;
		}
		else if(a == 74 && b == 40)
		{
			return 34;
		}
		else if(a == 74 && b == 41)
		{
			return 33;
		}
		else if(a == 74 && b == 42)
		{
			return 32;
		}
		else if(a == 74 && b == 43)
		{
			return 31;
		}
		else if(a == 74 && b == 44)
		{
			return 30;
		}
		else if(a == 74 && b == 45)
		{
			return 29;
		}
		else if(a == 74 && b == 46)
		{
			return 28;
		}
		else if(a == 74 && b == 47)
		{
			return 27;
		}
		else if(a == 74 && b == 48)
		{
			return 26;
		}
		else if(a == 74 && b == 49)
		{
			return 25;
		}
		else if(a == 74 && b == 50)
		{
			return 24;
		}
		else if(a == 74 && b == 51)
		{
			return 23;
		}
		else if(a == 74 && b == 52)
		{
			return 22;
		}
		else if(a == 74 && b == 53)
		{
			return 21;
		}
		else if(a == 74 && b == 54)
		{
			return 20;
		}
		else if(a == 74 && b == 55)
		{
			return 19;
		}
		else if(a == 74 && b == 56)
		{
			return 18;
		}
		else if(a == 74 && b == 57)
		{
			return 17;
		}
		else if(a == 74 && b == 58)
		{
			return 16;
		}
		else if(a == 74 && b == 59)
		{
			return 15;
		}
		else if(a == 74 && b == 60)
		{
			return 14;
		}
		else if(a == 74 && b == 61)
		{
			return 13;
		}
		else if(a == 74 && b == 62)
		{
			return 12;
		}
		else if(a == 74 && b == 63)
		{
			return 11;
		}
		else if(a == 74 && b == 64)
		{
			return 10;
		}
		else if(a == 74 && b == 65)
		{
			return 9;
		}
		else if(a == 74 && b == 66)
		{
			return 8;
		}
		else if(a == 74 && b == 67)
		{
			return 7;
		}
		else if(a == 74 && b == 68)
		{
			return 6;
		}
		else if(a == 74 && b == 69)
		{
			return 5;
		}
		else if(a == 74 && b == 70)
		{
			return 4;
		}
		else if(a == 74 && b == 71)
		{
			return 3;
		}
		else if(a == 74 && b == 72)
		{
			return 2;
		}
		else if(a == 74 && b == 73)
		{
			return 1;
		}
		else if(a == 74 && b == 74)
		{
			return 0;
		}
		else if(a == 74 && b == 75)
		{
			return -1;
		}
		else if(a == 74 && b == 76)
		{
			return -2;
		}
		else if(a == 74 && b == 77)
		{
			return -3;
		}
		else if(a == 74 && b == 78)
		{
			return -4;
		}
		else if(a == 74 && b == 79)
		{
			return -5;
		}
		else if(a == 74 && b == 80)
		{
			return -6;
		}
		else if(a == 74 && b == 81)
		{
			return -7;
		}
		else if(a == 74 && b == 82)
		{
			return -8;
		}
		else if(a == 74 && b == 83)
		{
			return -9;
		}
		else if(a == 74 && b == 84)
		{
			return -10;
		}
		else if(a == 74 && b == 85)
		{
			return -11;
		}
		else if(a == 74 && b == 86)
		{
			return -12;
		}
		else if(a == 74 && b == 87)
		{
			return -13;
		}
		else if(a == 74 && b == 88)
		{
			return -14;
		}
		else if(a == 74 && b == 89)
		{
			return -15;
		}
		else if(a == 74 && b == 90)
		{
			return -16;
		}
		else if(a == 74 && b == 91)
		{
			return -17;
		}
		else if(a == 74 && b == 92)
		{
			return -18;
		}
		else if(a == 74 && b == 93)
		{
			return -19;
		}
		else if(a == 74 && b == 94)
		{
			return -20;
		}
		else if(a == 74 && b == 95)
		{
			return -21;
		}
		else if(a == 74 && b == 96)
		{
			return -22;
		}
		else if(a == 74 && b == 97)
		{
			return -23;
		}
		else if(a == 74 && b == 98)
		{
			return -24;
		}
		else if(a == 74 && b == 99)
		{
			return -25;
		}
		else if(a == 74 && b == 100)
		{
			return -26;
		}
		else if(a == 75 && b == 0)
		{
			return 75;
		}
		else if(a == 75 && b == 1)
		{
			return 74;
		}
		else if(a == 75 && b == 2)
		{
			return 73;
		}
		else if(a == 75 && b == 3)
		{
			return 72;
		}
		else if(a == 75 && b == 4)
		{
			return 71;
		}
		else if(a == 75 && b == 5)
		{
			return 70;
		}
		else if(a == 75 && b == 6)
		{
			return 69;
		}
		else if(a == 75 && b == 7)
		{
			return 68;
		}
		else if(a == 75 && b == 8)
		{
			return 67;
		}
		else if(a == 75 && b == 9)
		{
			return 66;
		}
		else if(a == 75 && b == 10)
		{
			return 65;
		}
		else if(a == 75 && b == 11)
		{
			return 64;
		}
		else if(a == 75 && b == 12)
		{
			return 63;
		}
		else if(a == 75 && b == 13)
		{
			return 62;
		}
		else if(a == 75 && b == 14)
		{
			return 61;
		}
		else if(a == 75 && b == 15)
		{
			return 60;
		}
		else if(a == 75 && b == 16)
		{
			return 59;
		}
		else if(a == 75 && b == 17)
		{
			return 58;
		}
		else if(a == 75 && b == 18)
		{
			return 57;
		}
		else if(a == 75 && b == 19)
		{
			return 56;
		}
		else if(a == 75 && b == 20)
		{
			return 55;
		}
		else if(a == 75 && b == 21)
		{
			return 54;
		}
		else if(a == 75 && b == 22)
		{
			return 53;
		}
		else if(a == 75 && b == 23)
		{
			return 52;
		}
		else if(a == 75 && b == 24)
		{
			return 51;
		}
		else if(a == 75 && b == 25)
		{
			return 50;
		}
		else if(a == 75 && b == 26)
		{
			return 49;
		}
		else if(a == 75 && b == 27)
		{
			return 48;
		}
		else if(a == 75 && b == 28)
		{
			return 47;
		}
		else if(a == 75 && b == 29)
		{
			return 46;
		}
		else if(a == 75 && b == 30)
		{
			return 45;
		}
		else if(a == 75 && b == 31)
		{
			return 44;
		}
		else if(a == 75 && b == 32)
		{
			return 43;
		}
		else if(a == 75 && b == 33)
		{
			return 42;
		}
		else if(a == 75 && b == 34)
		{
			return 41;
		}
		else if(a == 75 && b == 35)
		{
			return 40;
		}
		else if(a == 75 && b == 36)
		{
			return 39;
		}
		else if(a == 75 && b == 37)
		{
			return 38;
		}
		else if(a == 75 && b == 38)
		{
			return 37;
		}
		else if(a == 75 && b == 39)
		{
			return 36;
		}
		else if(a == 75 && b == 40)
		{
			return 35;
		}
		else if(a == 75 && b == 41)
		{
			return 34;
		}
		else if(a == 75 && b == 42)
		{
			return 33;
		}
		else if(a == 75 && b == 43)
		{
			return 32;
		}
		else if(a == 75 && b == 44)
		{
			return 31;
		}
		else if(a == 75 && b == 45)
		{
			return 30;
		}
		else if(a == 75 && b == 46)
		{
			return 29;
		}
		else if(a == 75 && b == 47)
		{
			return 28;
		}
		else if(a == 75 && b == 48)
		{
			return 27;
		}
		else if(a == 75 && b == 49)
		{
			return 26;
		}
		else if(a == 75 && b == 50)
		{
			return 25;
		}
		else if(a == 75 && b == 51)
		{
			return 24;
		}
		else if(a == 75 && b == 52)
		{
			return 23;
		}
		else if(a == 75 && b == 53)
		{
			return 22;
		}
		else if(a == 75 && b == 54)
		{
			return 21;
		}
		else if(a == 75 && b == 55)
		{
			return 20;
		}
		else if(a == 75 && b == 56)
		{
			return 19;
		}
		else if(a == 75 && b == 57)
		{
			return 18;
		}
		else if(a == 75 && b == 58)
		{
			return 17;
		}
		else if(a == 75 && b == 59)
		{
			return 16;
		}
		else if(a == 75 && b == 60)
		{
			return 15;
		}
		else if(a == 75 && b == 61)
		{
			return 14;
		}
		else if(a == 75 && b == 62)
		{
			return 13;
		}
		else if(a == 75 && b == 63)
		{
			return 12;
		}
		else if(a == 75 && b == 64)
		{
			return 11;
		}
		else if(a == 75 && b == 65)
		{
			return 10;
		}
		else if(a == 75 && b == 66)
		{
			return 9;
		}
		else if(a == 75 && b == 67)
		{
			return 8;
		}
		else if(a == 75 && b == 68)
		{
			return 7;
		}
		else if(a == 75 && b == 69)
		{
			return 6;
		}
		else if(a == 75 && b == 70)
		{
			return 5;
		}
		else if(a == 75 && b == 71)
		{
			return 4;
		}
		else if(a == 75 && b == 72)
		{
			return 3;
		}
		else if(a == 75 && b == 73)
		{
			return 2;
		}
		else if(a == 75 && b == 74)
		{
			return 1;
		}
		else if(a == 75 && b == 75)
		{
			return 0;
		}
		else if(a == 75 && b == 76)
		{
			return -1;
		}
		else if(a == 75 && b == 77)
		{
			return -2;
		}
		else if(a == 75 && b == 78)
		{
			return -3;
		}
		else if(a == 75 && b == 79)
		{
			return -4;
		}
		else if(a == 75 && b == 80)
		{
			return -5;
		}
		else if(a == 75 && b == 81)
		{
			return -6;
		}
		else if(a == 75 && b == 82)
		{
			return -7;
		}
		else if(a == 75 && b == 83)
		{
			return -8;
		}
		else if(a == 75 && b == 84)
		{
			return -9;
		}
		else if(a == 75 && b == 85)
		{
			return -10;
		}
		else if(a == 75 && b == 86)
		{
			return -11;
		}
		else if(a == 75 && b == 87)
		{
			return -12;
		}
		else if(a == 75 && b == 88)
		{
			return -13;
		}
		else if(a == 75 && b == 89)
		{
			return -14;
		}
		else if(a == 75 && b == 90)
		{
			return -15;
		}
		else if(a == 75 && b == 91)
		{
			return -16;
		}
		else if(a == 75 && b == 92)
		{
			return -17;
		}
		else if(a == 75 && b == 93)
		{
			return -18;
		}
		else if(a == 75 && b == 94)
		{
			return -19;
		}
		else if(a == 75 && b == 95)
		{
			return -20;
		}
		else if(a == 75 && b == 96)
		{
			return -21;
		}
		else if(a == 75 && b == 97)
		{
			return -22;
		}
		else if(a == 75 && b == 98)
		{
			return -23;
		}
		else if(a == 75 && b == 99)
		{
			return -24;
		}
		else if(a == 75 && b == 100)
		{
			return -25;
		}
		else if(a == 76 && b == 0)
		{
			return 76;
		}
		else if(a == 76 && b == 1)
		{
			return 75;
		}
		else if(a == 76 && b == 2)
		{
			return 74;
		}
		else if(a == 76 && b == 3)
		{
			return 73;
		}
		else if(a == 76 && b == 4)
		{
			return 72;
		}
		else if(a == 76 && b == 5)
		{
			return 71;
		}
		else if(a == 76 && b == 6)
		{
			return 70;
		}
		else if(a == 76 && b == 7)
		{
			return 69;
		}
		else if(a == 76 && b == 8)
		{
			return 68;
		}
		else if(a == 76 && b == 9)
		{
			return 67;
		}
		else if(a == 76 && b == 10)
		{
			return 66;
		}
		else if(a == 76 && b == 11)
		{
			return 65;
		}
		else if(a == 76 && b == 12)
		{
			return 64;
		}
		else if(a == 76 && b == 13)
		{
			return 63;
		}
		else if(a == 76 && b == 14)
		{
			return 62;
		}
		else if(a == 76 && b == 15)
		{
			return 61;
		}
		else if(a == 76 && b == 16)
		{
			return 60;
		}
		else if(a == 76 && b == 17)
		{
			return 59;
		}
		else if(a == 76 && b == 18)
		{
			return 58;
		}
		else if(a == 76 && b == 19)
		{
			return 57;
		}
		else if(a == 76 && b == 20)
		{
			return 56;
		}
		else if(a == 76 && b == 21)
		{
			return 55;
		}
		else if(a == 76 && b == 22)
		{
			return 54;
		}
		else if(a == 76 && b == 23)
		{
			return 53;
		}
		else if(a == 76 && b == 24)
		{
			return 52;
		}
		else if(a == 76 && b == 25)
		{
			return 51;
		}
		else if(a == 76 && b == 26)
		{
			return 50;
		}
		else if(a == 76 && b == 27)
		{
			return 49;
		}
		else if(a == 76 && b == 28)
		{
			return 48;
		}
		else if(a == 76 && b == 29)
		{
			return 47;
		}
		else if(a == 76 && b == 30)
		{
			return 46;
		}
		else if(a == 76 && b == 31)
		{
			return 45;
		}
		else if(a == 76 && b == 32)
		{
			return 44;
		}
		else if(a == 76 && b == 33)
		{
			return 43;
		}
		else if(a == 76 && b == 34)
		{
			return 42;
		}
		else if(a == 76 && b == 35)
		{
			return 41;
		}
		else if(a == 76 && b == 36)
		{
			return 40;
		}
		else if(a == 76 && b == 37)
		{
			return 39;
		}
		else if(a == 76 && b == 38)
		{
			return 38;
		}
		else if(a == 76 && b == 39)
		{
			return 37;
		}
		else if(a == 76 && b == 40)
		{
			return 36;
		}
		else if(a == 76 && b == 41)
		{
			return 35;
		}
		else if(a == 76 && b == 42)
		{
			return 34;
		}
		else if(a == 76 && b == 43)
		{
			return 33;
		}
		else if(a == 76 && b == 44)
		{
			return 32;
		}
		else if(a == 76 && b == 45)
		{
			return 31;
		}
		else if(a == 76 && b == 46)
		{
			return 30;
		}
		else if(a == 76 && b == 47)
		{
			return 29;
		}
		else if(a == 76 && b == 48)
		{
			return 28;
		}
		else if(a == 76 && b == 49)
		{
			return 27;
		}
		else if(a == 76 && b == 50)
		{
			return 26;
		}
		else if(a == 76 && b == 51)
		{
			return 25;
		}
		else if(a == 76 && b == 52)
		{
			return 24;
		}
		else if(a == 76 && b == 53)
		{
			return 23;
		}
		else if(a == 76 && b == 54)
		{
			return 22;
		}
		else if(a == 76 && b == 55)
		{
			return 21;
		}
		else if(a == 76 && b == 56)
		{
			return 20;
		}
		else if(a == 76 && b == 57)
		{
			return 19;
		}
		else if(a == 76 && b == 58)
		{
			return 18;
		}
		else if(a == 76 && b == 59)
		{
			return 17;
		}
		else if(a == 76 && b == 60)
		{
			return 16;
		}
		else if(a == 76 && b == 61)
		{
			return 15;
		}
		else if(a == 76 && b == 62)
		{
			return 14;
		}
		else if(a == 76 && b == 63)
		{
			return 13;
		}
		else if(a == 76 && b == 64)
		{
			return 12;
		}
		else if(a == 76 && b == 65)
		{
			return 11;
		}
		else if(a == 76 && b == 66)
		{
			return 10;
		}
		else if(a == 76 && b == 67)
		{
			return 9;
		}
		else if(a == 76 && b == 68)
		{
			return 8;
		}
		else if(a == 76 && b == 69)
		{
			return 7;
		}
		else if(a == 76 && b == 70)
		{
			return 6;
		}
		else if(a == 76 && b == 71)
		{
			return 5;
		}
		else if(a == 76 && b == 72)
		{
			return 4;
		}
		else if(a == 76 && b == 73)
		{
			return 3;
		}
		else if(a == 76 && b == 74)
		{
			return 2;
		}
		else if(a == 76 && b == 75)
		{
			return 1;
		}
		else if(a == 76 && b == 76)
		{
			return 0;
		}
		else if(a == 76 && b == 77)
		{
			return -1;
		}
		else if(a == 76 && b == 78)
		{
			return -2;
		}
		else if(a == 76 && b == 79)
		{
			return -3;
		}
		else if(a == 76 && b == 80)
		{
			return -4;
		}
		else if(a == 76 && b == 81)
		{
			return -5;
		}
		else if(a == 76 && b == 82)
		{
			return -6;
		}
		else if(a == 76 && b == 83)
		{
			return -7;
		}
		else if(a == 76 && b == 84)
		{
			return -8;
		}
		else if(a == 76 && b == 85)
		{
			return -9;
		}
		else if(a == 76 && b == 86)
		{
			return -10;
		}
		else if(a == 76 && b == 87)
		{
			return -11;
		}
		else if(a == 76 && b == 88)
		{
			return -12;
		}
		else if(a == 76 && b == 89)
		{
			return -13;
		}
		else if(a == 76 && b == 90)
		{
			return -14;
		}
		else if(a == 76 && b == 91)
		{
			return -15;
		}
		else if(a == 76 && b == 92)
		{
			return -16;
		}
		else if(a == 76 && b == 93)
		{
			return -17;
		}
		else if(a == 76 && b == 94)
		{
			return -18;
		}
		else if(a == 76 && b == 95)
		{
			return -19;
		}
		else if(a == 76 && b == 96)
		{
			return -20;
		}
		else if(a == 76 && b == 97)
		{
			return -21;
		}
		else if(a == 76 && b == 98)
		{
			return -22;
		}
		else if(a == 76 && b == 99)
		{
			return -23;
		}
		else if(a == 76 && b == 100)
		{
			return -24;
		}
		else if(a == 77 && b == 0)
		{
			return 77;
		}
		else if(a == 77 && b == 1)
		{
			return 76;
		}
		else if(a == 77 && b == 2)
		{
			return 75;
		}
		else if(a == 77 && b == 3)
		{
			return 74;
		}
		else if(a == 77 && b == 4)
		{
			return 73;
		}
		else if(a == 77 && b == 5)
		{
			return 72;
		}
		else if(a == 77 && b == 6)
		{
			return 71;
		}
		else if(a == 77 && b == 7)
		{
			return 70;
		}
		else if(a == 77 && b == 8)
		{
			return 69;
		}
		else if(a == 77 && b == 9)
		{
			return 68;
		}
		else if(a == 77 && b == 10)
		{
			return 67;
		}
		else if(a == 77 && b == 11)
		{
			return 66;
		}
		else if(a == 77 && b == 12)
		{
			return 65;
		}
		else if(a == 77 && b == 13)
		{
			return 64;
		}
		else if(a == 77 && b == 14)
		{
			return 63;
		}
		else if(a == 77 && b == 15)
		{
			return 62;
		}
		else if(a == 77 && b == 16)
		{
			return 61;
		}
		else if(a == 77 && b == 17)
		{
			return 60;
		}
		else if(a == 77 && b == 18)
		{
			return 59;
		}
		else if(a == 77 && b == 19)
		{
			return 58;
		}
		else if(a == 77 && b == 20)
		{
			return 57;
		}
		else if(a == 77 && b == 21)
		{
			return 56;
		}
		else if(a == 77 && b == 22)
		{
			return 55;
		}
		else if(a == 77 && b == 23)
		{
			return 54;
		}
		else if(a == 77 && b == 24)
		{
			return 53;
		}
		else if(a == 77 && b == 25)
		{
			return 52;
		}
		else if(a == 77 && b == 26)
		{
			return 51;
		}
		else if(a == 77 && b == 27)
		{
			return 50;
		}
		else if(a == 77 && b == 28)
		{
			return 49;
		}
		else if(a == 77 && b == 29)
		{
			return 48;
		}
		else if(a == 77 && b == 30)
		{
			return 47;
		}
		else if(a == 77 && b == 31)
		{
			return 46;
		}
		else if(a == 77 && b == 32)
		{
			return 45;
		}
		else if(a == 77 && b == 33)
		{
			return 44;
		}
		else if(a == 77 && b == 34)
		{
			return 43;
		}
		else if(a == 77 && b == 35)
		{
			return 42;
		}
		else if(a == 77 && b == 36)
		{
			return 41;
		}
		else if(a == 77 && b == 37)
		{
			return 40;
		}
		else if(a == 77 && b == 38)
		{
			return 39;
		}
		else if(a == 77 && b == 39)
		{
			return 38;
		}
		else if(a == 77 && b == 40)
		{
			return 37;
		}
		else if(a == 77 && b == 41)
		{
			return 36;
		}
		else if(a == 77 && b == 42)
		{
			return 35;
		}
		else if(a == 77 && b == 43)
		{
			return 34;
		}
		else if(a == 77 && b == 44)
		{
			return 33;
		}
		else if(a == 77 && b == 45)
		{
			return 32;
		}
		else if(a == 77 && b == 46)
		{
			return 31;
		}
		else if(a == 77 && b == 47)
		{
			return 30;
		}
		else if(a == 77 && b == 48)
		{
			return 29;
		}
		else if(a == 77 && b == 49)
		{
			return 28;
		}
		else if(a == 77 && b == 50)
		{
			return 27;
		}
		else if(a == 77 && b == 51)
		{
			return 26;
		}
		else if(a == 77 && b == 52)
		{
			return 25;
		}
		else if(a == 77 && b == 53)
		{
			return 24;
		}
		else if(a == 77 && b == 54)
		{
			return 23;
		}
		else if(a == 77 && b == 55)
		{
			return 22;
		}
		else if(a == 77 && b == 56)
		{
			return 21;
		}
		else if(a == 77 && b == 57)
		{
			return 20;
		}
		else if(a == 77 && b == 58)
		{
			return 19;
		}
		else if(a == 77 && b == 59)
		{
			return 18;
		}
		else if(a == 77 && b == 60)
		{
			return 17;
		}
		else if(a == 77 && b == 61)
		{
			return 16;
		}
		else if(a == 77 && b == 62)
		{
			return 15;
		}
		else if(a == 77 && b == 63)
		{
			return 14;
		}
		else if(a == 77 && b == 64)
		{
			return 13;
		}
		else if(a == 77 && b == 65)
		{
			return 12;
		}
		else if(a == 77 && b == 66)
		{
			return 11;
		}
		else if(a == 77 && b == 67)
		{
			return 10;
		}
		else if(a == 77 && b == 68)
		{
			return 9;
		}
		else if(a == 77 && b == 69)
		{
			return 8;
		}
		else if(a == 77 && b == 70)
		{
			return 7;
		}
		else if(a == 77 && b == 71)
		{
			return 6;
		}
		else if(a == 77 && b == 72)
		{
			return 5;
		}
		else if(a == 77 && b == 73)
		{
			return 4;
		}
		else if(a == 77 && b == 74)
		{
			return 3;
		}
		else if(a == 77 && b == 75)
		{
			return 2;
		}
		else if(a == 77 && b == 76)
		{
			return 1;
		}
		else if(a == 77 && b == 77)
		{
			return 0;
		}
		else if(a == 77 && b == 78)
		{
			return -1;
		}
		else if(a == 77 && b == 79)
		{
			return -2;
		}
		else if(a == 77 && b == 80)
		{
			return -3;
		}
		else if(a == 77 && b == 81)
		{
			return -4;
		}
		else if(a == 77 && b == 82)
		{
			return -5;
		}
		else if(a == 77 && b == 83)
		{
			return -6;
		}
		else if(a == 77 && b == 84)
		{
			return -7;
		}
		else if(a == 77 && b == 85)
		{
			return -8;
		}
		else if(a == 77 && b == 86)
		{
			return -9;
		}
		else if(a == 77 && b == 87)
		{
			return -10;
		}
		else if(a == 77 && b == 88)
		{
			return -11;
		}
		else if(a == 77 && b == 89)
		{
			return -12;
		}
		else if(a == 77 && b == 90)
		{
			return -13;
		}
		else if(a == 77 && b == 91)
		{
			return -14;
		}
		else if(a == 77 && b == 92)
		{
			return -15;
		}
		else if(a == 77 && b == 93)
		{
			return -16;
		}
		else if(a == 77 && b == 94)
		{
			return -17;
		}
		else if(a == 77 && b == 95)
		{
			return -18;
		}
		else if(a == 77 && b == 96)
		{
			return -19;
		}
		else if(a == 77 && b == 97)
		{
			return -20;
		}
		else if(a == 77 && b == 98)
		{
			return -21;
		}
		else if(a == 77 && b == 99)
		{
			return -22;
		}
		else if(a == 77 && b == 100)
		{
			return -23;
		}
		else if(a == 78 && b == 0)
		{
			return 78;
		}
		else if(a == 78 && b == 1)
		{
			return 77;
		}
		else if(a == 78 && b == 2)
		{
			return 76;
		}
		else if(a == 78 && b == 3)
		{
			return 75;
		}
		else if(a == 78 && b == 4)
		{
			return 74;
		}
		else if(a == 78 && b == 5)
		{
			return 73;
		}
		else if(a == 78 && b == 6)
		{
			return 72;
		}
		else if(a == 78 && b == 7)
		{
			return 71;
		}
		else if(a == 78 && b == 8)
		{
			return 70;
		}
		else if(a == 78 && b == 9)
		{
			return 69;
		}
		else if(a == 78 && b == 10)
		{
			return 68;
		}
		else if(a == 78 && b == 11)
		{
			return 67;
		}
		else if(a == 78 && b == 12)
		{
			return 66;
		}
		else if(a == 78 && b == 13)
		{
			return 65;
		}
		else if(a == 78 && b == 14)
		{
			return 64;
		}
		else if(a == 78 && b == 15)
		{
			return 63;
		}
		else if(a == 78 && b == 16)
		{
			return 62;
		}
		else if(a == 78 && b == 17)
		{
			return 61;
		}
		else if(a == 78 && b == 18)
		{
			return 60;
		}
		else if(a == 78 && b == 19)
		{
			return 59;
		}
		else if(a == 78 && b == 20)
		{
			return 58;
		}
		else if(a == 78 && b == 21)
		{
			return 57;
		}
		else if(a == 78 && b == 22)
		{
			return 56;
		}
		else if(a == 78 && b == 23)
		{
			return 55;
		}
		else if(a == 78 && b == 24)
		{
			return 54;
		}
		else if(a == 78 && b == 25)
		{
			return 53;
		}
		else if(a == 78 && b == 26)
		{
			return 52;
		}
		else if(a == 78 && b == 27)
		{
			return 51;
		}
		else if(a == 78 && b == 28)
		{
			return 50;
		}
		else if(a == 78 && b == 29)
		{
			return 49;
		}
		else if(a == 78 && b == 30)
		{
			return 48;
		}
		else if(a == 78 && b == 31)
		{
			return 47;
		}
		else if(a == 78 && b == 32)
		{
			return 46;
		}
		else if(a == 78 && b == 33)
		{
			return 45;
		}
		else if(a == 78 && b == 34)
		{
			return 44;
		}
		else if(a == 78 && b == 35)
		{
			return 43;
		}
		else if(a == 78 && b == 36)
		{
			return 42;
		}
		else if(a == 78 && b == 37)
		{
			return 41;
		}
		else if(a == 78 && b == 38)
		{
			return 40;
		}
		else if(a == 78 && b == 39)
		{
			return 39;
		}
		else if(a == 78 && b == 40)
		{
			return 38;
		}
		else if(a == 78 && b == 41)
		{
			return 37;
		}
		else if(a == 78 && b == 42)
		{
			return 36;
		}
		else if(a == 78 && b == 43)
		{
			return 35;
		}
		else if(a == 78 && b == 44)
		{
			return 34;
		}
		else if(a == 78 && b == 45)
		{
			return 33;
		}
		else if(a == 78 && b == 46)
		{
			return 32;
		}
		else if(a == 78 && b == 47)
		{
			return 31;
		}
		else if(a == 78 && b == 48)
		{
			return 30;
		}
		else if(a == 78 && b == 49)
		{
			return 29;
		}
		else if(a == 78 && b == 50)
		{
			return 28;
		}
		else if(a == 78 && b == 51)
		{
			return 27;
		}
		else if(a == 78 && b == 52)
		{
			return 26;
		}
		else if(a == 78 && b == 53)
		{
			return 25;
		}
		else if(a == 78 && b == 54)
		{
			return 24;
		}
		else if(a == 78 && b == 55)
		{
			return 23;
		}
		else if(a == 78 && b == 56)
		{
			return 22;
		}
		else if(a == 78 && b == 57)
		{
			return 21;
		}
		else if(a == 78 && b == 58)
		{
			return 20;
		}
		else if(a == 78 && b == 59)
		{
			return 19;
		}
		else if(a == 78 && b == 60)
		{
			return 18;
		}
		else if(a == 78 && b == 61)
		{
			return 17;
		}
		else if(a == 78 && b == 62)
		{
			return 16;
		}
		else if(a == 78 && b == 63)
		{
			return 15;
		}
		else if(a == 78 && b == 64)
		{
			return 14;
		}
		else if(a == 78 && b == 65)
		{
			return 13;
		}
		else if(a == 78 && b == 66)
		{
			return 12;
		}
		else if(a == 78 && b == 67)
		{
			return 11;
		}
		else if(a == 78 && b == 68)
		{
			return 10;
		}
		else if(a == 78 && b == 69)
		{
			return 9;
		}
		else if(a == 78 && b == 70)
		{
			return 8;
		}
		else if(a == 78 && b == 71)
		{
			return 7;
		}
		else if(a == 78 && b == 72)
		{
			return 6;
		}
		else if(a == 78 && b == 73)
		{
			return 5;
		}
		else if(a == 78 && b == 74)
		{
			return 4;
		}
		else if(a == 78 && b == 75)
		{
			return 3;
		}
		else if(a == 78 && b == 76)
		{
			return 2;
		}
		else if(a == 78 && b == 77)
		{
			return 1;
		}
		else if(a == 78 && b == 78)
		{
			return 0;
		}
		else if(a == 78 && b == 79)
		{
			return -1;
		}
		else if(a == 78 && b == 80)
		{
			return -2;
		}
		else if(a == 78 && b == 81)
		{
			return -3;
		}
		else if(a == 78 && b == 82)
		{
			return -4;
		}
		else if(a == 78 && b == 83)
		{
			return -5;
		}
		else if(a == 78 && b == 84)
		{
			return -6;
		}
		else if(a == 78 && b == 85)
		{
			return -7;
		}
		else if(a == 78 && b == 86)
		{
			return -8;
		}
		else if(a == 78 && b == 87)
		{
			return -9;
		}
		else if(a == 78 && b == 88)
		{
			return -10;
		}
		else if(a == 78 && b == 89)
		{
			return -11;
		}
		else if(a == 78 && b == 90)
		{
			return -12;
		}
		else if(a == 78 && b == 91)
		{
			return -13;
		}
		else if(a == 78 && b == 92)
		{
			return -14;
		}
		else if(a == 78 && b == 93)
		{
			return -15;
		}
		else if(a == 78 && b == 94)
		{
			return -16;
		}
		else if(a == 78 && b == 95)
		{
			return -17;
		}
		else if(a == 78 && b == 96)
		{
			return -18;
		}
		else if(a == 78 && b == 97)
		{
			return -19;
		}
		else if(a == 78 && b == 98)
		{
			return -20;
		}
		else if(a == 78 && b == 99)
		{
			return -21;
		}
		else if(a == 78 && b == 100)
		{
			return -22;
		}
		else if(a == 79 && b == 0)
		{
			return 79;
		}
		else if(a == 79 && b == 1)
		{
			return 78;
		}
		else if(a == 79 && b == 2)
		{
			return 77;
		}
		else if(a == 79 && b == 3)
		{
			return 76;
		}
		else if(a == 79 && b == 4)
		{
			return 75;
		}
		else if(a == 79 && b == 5)
		{
			return 74;
		}
		else if(a == 79 && b == 6)
		{
			return 73;
		}
		else if(a == 79 && b == 7)
		{
			return 72;
		}
		else if(a == 79 && b == 8)
		{
			return 71;
		}
		else if(a == 79 && b == 9)
		{
			return 70;
		}
		else if(a == 79 && b == 10)
		{
			return 69;
		}
		else if(a == 79 && b == 11)
		{
			return 68;
		}
		else if(a == 79 && b == 12)
		{
			return 67;
		}
		else if(a == 79 && b == 13)
		{
			return 66;
		}
		else if(a == 79 && b == 14)
		{
			return 65;
		}
		else if(a == 79 && b == 15)
		{
			return 64;
		}
		else if(a == 79 && b == 16)
		{
			return 63;
		}
		else if(a == 79 && b == 17)
		{
			return 62;
		}
		else if(a == 79 && b == 18)
		{
			return 61;
		}
		else if(a == 79 && b == 19)
		{
			return 60;
		}
		else if(a == 79 && b == 20)
		{
			return 59;
		}
		else if(a == 79 && b == 21)
		{
			return 58;
		}
		else if(a == 79 && b == 22)
		{
			return 57;
		}
		else if(a == 79 && b == 23)
		{
			return 56;
		}
		else if(a == 79 && b == 24)
		{
			return 55;
		}
		else if(a == 79 && b == 25)
		{
			return 54;
		}
		else if(a == 79 && b == 26)
		{
			return 53;
		}
		else if(a == 79 && b == 27)
		{
			return 52;
		}
		else if(a == 79 && b == 28)
		{
			return 51;
		}
		else if(a == 79 && b == 29)
		{
			return 50;
		}
		else if(a == 79 && b == 30)
		{
			return 49;
		}
		else if(a == 79 && b == 31)
		{
			return 48;
		}
		else if(a == 79 && b == 32)
		{
			return 47;
		}
		else if(a == 79 && b == 33)
		{
			return 46;
		}
		else if(a == 79 && b == 34)
		{
			return 45;
		}
		else if(a == 79 && b == 35)
		{
			return 44;
		}
		else if(a == 79 && b == 36)
		{
			return 43;
		}
		else if(a == 79 && b == 37)
		{
			return 42;
		}
		else if(a == 79 && b == 38)
		{
			return 41;
		}
		else if(a == 79 && b == 39)
		{
			return 40;
		}
		else if(a == 79 && b == 40)
		{
			return 39;
		}
		else if(a == 79 && b == 41)
		{
			return 38;
		}
		else if(a == 79 && b == 42)
		{
			return 37;
		}
		else if(a == 79 && b == 43)
		{
			return 36;
		}
		else if(a == 79 && b == 44)
		{
			return 35;
		}
		else if(a == 79 && b == 45)
		{
			return 34;
		}
		else if(a == 79 && b == 46)
		{
			return 33;
		}
		else if(a == 79 && b == 47)
		{
			return 32;
		}
		else if(a == 79 && b == 48)
		{
			return 31;
		}
		else if(a == 79 && b == 49)
		{
			return 30;
		}
		else if(a == 79 && b == 50)
		{
			return 29;
		}
		else if(a == 79 && b == 51)
		{
			return 28;
		}
		else if(a == 79 && b == 52)
		{
			return 27;
		}
		else if(a == 79 && b == 53)
		{
			return 26;
		}
		else if(a == 79 && b == 54)
		{
			return 25;
		}
		else if(a == 79 && b == 55)
		{
			return 24;
		}
		else if(a == 79 && b == 56)
		{
			return 23;
		}
		else if(a == 79 && b == 57)
		{
			return 22;
		}
		else if(a == 79 && b == 58)
		{
			return 21;
		}
		else if(a == 79 && b == 59)
		{
			return 20;
		}
		else if(a == 79 && b == 60)
		{
			return 19;
		}
		else if(a == 79 && b == 61)
		{
			return 18;
		}
		else if(a == 79 && b == 62)
		{
			return 17;
		}
		else if(a == 79 && b == 63)
		{
			return 16;
		}
		else if(a == 79 && b == 64)
		{
			return 15;
		}
		else if(a == 79 && b == 65)
		{
			return 14;
		}
		else if(a == 79 && b == 66)
		{
			return 13;
		}
		else if(a == 79 && b == 67)
		{
			return 12;
		}
		else if(a == 79 && b == 68)
		{
			return 11;
		}
		else if(a == 79 && b == 69)
		{
			return 10;
		}
		else if(a == 79 && b == 70)
		{
			return 9;
		}
		else if(a == 79 && b == 71)
		{
			return 8;
		}
		else if(a == 79 && b == 72)
		{
			return 7;
		}
		else if(a == 79 && b == 73)
		{
			return 6;
		}
		else if(a == 79 && b == 74)
		{
			return 5;
		}
		else if(a == 79 && b == 75)
		{
			return 4;
		}
		else if(a == 79 && b == 76)
		{
			return 3;
		}
		else if(a == 79 && b == 77)
		{
			return 2;
		}
		else if(a == 79 && b == 78)
		{
			return 1;
		}
		else if(a == 79 && b == 79)
		{
			return 0;
		}
		else if(a == 79 && b == 80)
		{
			return -1;
		}
		else if(a == 79 && b == 81)
		{
			return -2;
		}
		else if(a == 79 && b == 82)
		{
			return -3;
		}
		else if(a == 79 && b == 83)
		{
			return -4;
		}
		else if(a == 79 && b == 84)
		{
			return -5;
		}
		else if(a == 79 && b == 85)
		{
			return -6;
		}
		else if(a == 79 && b == 86)
		{
			return -7;
		}
		else if(a == 79 && b == 87)
		{
			return -8;
		}
		else if(a == 79 && b == 88)
		{
			return -9;
		}
		else if(a == 79 && b == 89)
		{
			return -10;
		}
		else if(a == 79 && b == 90)
		{
			return -11;
		}
		else if(a == 79 && b == 91)
		{
			return -12;
		}
		else if(a == 79 && b == 92)
		{
			return -13;
		}
		else if(a == 79 && b == 93)
		{
			return -14;
		}
		else if(a == 79 && b == 94)
		{
			return -15;
		}
		else if(a == 79 && b == 95)
		{
			return -16;
		}
		else if(a == 79 && b == 96)
		{
			return -17;
		}
		else if(a == 79 && b == 97)
		{
			return -18;
		}
		else if(a == 79 && b == 98)
		{
			return -19;
		}
		else if(a == 79 && b == 99)
		{
			return -20;
		}
		else if(a == 79 && b == 100)
		{
			return -21;
		}
		else if(a == 80 && b == 0)
		{
			return 80;
		}
		else if(a == 80 && b == 1)
		{
			return 79;
		}
		else if(a == 80 && b == 2)
		{
			return 78;
		}
		else if(a == 80 && b == 3)
		{
			return 77;
		}
		else if(a == 80 && b == 4)
		{
			return 76;
		}
		else if(a == 80 && b == 5)
		{
			return 75;
		}
		else if(a == 80 && b == 6)
		{
			return 74;
		}
		else if(a == 80 && b == 7)
		{
			return 73;
		}
		else if(a == 80 && b == 8)
		{
			return 72;
		}
		else if(a == 80 && b == 9)
		{
			return 71;
		}
		else if(a == 80 && b == 10)
		{
			return 70;
		}
		else if(a == 80 && b == 11)
		{
			return 69;
		}
		else if(a == 80 && b == 12)
		{
			return 68;
		}
		else if(a == 80 && b == 13)
		{
			return 67;
		}
		else if(a == 80 && b == 14)
		{
			return 66;
		}
		else if(a == 80 && b == 15)
		{
			return 65;
		}
		else if(a == 80 && b == 16)
		{
			return 64;
		}
		else if(a == 80 && b == 17)
		{
			return 63;
		}
		else if(a == 80 && b == 18)
		{
			return 62;
		}
		else if(a == 80 && b == 19)
		{
			return 61;
		}
		else if(a == 80 && b == 20)
		{
			return 60;
		}
		else if(a == 80 && b == 21)
		{
			return 59;
		}
		else if(a == 80 && b == 22)
		{
			return 58;
		}
		else if(a == 80 && b == 23)
		{
			return 57;
		}
		else if(a == 80 && b == 24)
		{
			return 56;
		}
		else if(a == 80 && b == 25)
		{
			return 55;
		}
		else if(a == 80 && b == 26)
		{
			return 54;
		}
		else if(a == 80 && b == 27)
		{
			return 53;
		}
		else if(a == 80 && b == 28)
		{
			return 52;
		}
		else if(a == 80 && b == 29)
		{
			return 51;
		}
		else if(a == 80 && b == 30)
		{
			return 50;
		}
		else if(a == 80 && b == 31)
		{
			return 49;
		}
		else if(a == 80 && b == 32)
		{
			return 48;
		}
		else if(a == 80 && b == 33)
		{
			return 47;
		}
		else if(a == 80 && b == 34)
		{
			return 46;
		}
		else if(a == 80 && b == 35)
		{
			return 45;
		}
		else if(a == 80 && b == 36)
		{
			return 44;
		}
		else if(a == 80 && b == 37)
		{
			return 43;
		}
		else if(a == 80 && b == 38)
		{
			return 42;
		}
		else if(a == 80 && b == 39)
		{
			return 41;
		}
		else if(a == 80 && b == 40)
		{
			return 40;
		}
		else if(a == 80 && b == 41)
		{
			return 39;
		}
		else if(a == 80 && b == 42)
		{
			return 38;
		}
		else if(a == 80 && b == 43)
		{
			return 37;
		}
		else if(a == 80 && b == 44)
		{
			return 36;
		}
		else if(a == 80 && b == 45)
		{
			return 35;
		}
		else if(a == 80 && b == 46)
		{
			return 34;
		}
		else if(a == 80 && b == 47)
		{
			return 33;
		}
		else if(a == 80 && b == 48)
		{
			return 32;
		}
		else if(a == 80 && b == 49)
		{
			return 31;
		}
		else if(a == 80 && b == 50)
		{
			return 30;
		}
		else if(a == 80 && b == 51)
		{
			return 29;
		}
		else if(a == 80 && b == 52)
		{
			return 28;
		}
		else if(a == 80 && b == 53)
		{
			return 27;
		}
		else if(a == 80 && b == 54)
		{
			return 26;
		}
		else if(a == 80 && b == 55)
		{
			return 25;
		}
		else if(a == 80 && b == 56)
		{
			return 24;
		}
		else if(a == 80 && b == 57)
		{
			return 23;
		}
		else if(a == 80 && b == 58)
		{
			return 22;
		}
		else if(a == 80 && b == 59)
		{
			return 21;
		}
		else if(a == 80 && b == 60)
		{
			return 20;
		}
		else if(a == 80 && b == 61)
		{
			return 19;
		}
		else if(a == 80 && b == 62)
		{
			return 18;
		}
		else if(a == 80 && b == 63)
		{
			return 17;
		}
		else if(a == 80 && b == 64)
		{
			return 16;
		}
		else if(a == 80 && b == 65)
		{
			return 15;
		}
		else if(a == 80 && b == 66)
		{
			return 14;
		}
		else if(a == 80 && b == 67)
		{
			return 13;
		}
		else if(a == 80 && b == 68)
		{
			return 12;
		}
		else if(a == 80 && b == 69)
		{
			return 11;
		}
		else if(a == 80 && b == 70)
		{
			return 10;
		}
		else if(a == 80 && b == 71)
		{
			return 9;
		}
		else if(a == 80 && b == 72)
		{
			return 8;
		}
		else if(a == 80 && b == 73)
		{
			return 7;
		}
		else if(a == 80 && b == 74)
		{
			return 6;
		}
		else if(a == 80 && b == 75)
		{
			return 5;
		}
		else if(a == 80 && b == 76)
		{
			return 4;
		}
		else if(a == 80 && b == 77)
		{
			return 3;
		}
		else if(a == 80 && b == 78)
		{
			return 2;
		}
		else if(a == 80 && b == 79)
		{
			return 1;
		}
		else if(a == 80 && b == 80)
		{
			return 0;
		}
		else if(a == 80 && b == 81)
		{
			return -1;
		}
		else if(a == 80 && b == 82)
		{
			return -2;
		}
		else if(a == 80 && b == 83)
		{
			return -3;
		}
		else if(a == 80 && b == 84)
		{
			return -4;
		}
		else if(a == 80 && b == 85)
		{
			return -5;
		}
		else if(a == 80 && b == 86)
		{
			return -6;
		}
		else if(a == 80 && b == 87)
		{
			return -7;
		}
		else if(a == 80 && b == 88)
		{
			return -8;
		}
		else if(a == 80 && b == 89)
		{
			return -9;
		}
		else if(a == 80 && b == 90)
		{
			return -10;
		}
		else if(a == 80 && b == 91)
		{
			return -11;
		}
		else if(a == 80 && b == 92)
		{
			return -12;
		}
		else if(a == 80 && b == 93)
		{
			return -13;
		}
		else if(a == 80 && b == 94)
		{
			return -14;
		}
		else if(a == 80 && b == 95)
		{
			return -15;
		}
		else if(a == 80 && b == 96)
		{
			return -16;
		}
		else if(a == 80 && b == 97)
		{
			return -17;
		}
		else if(a == 80 && b == 98)
		{
			return -18;
		}
		else if(a == 80 && b == 99)
		{
			return -19;
		}
		else if(a == 80 && b == 100)
		{
			return -20;
		}
		else if(a == 81 && b == 0)
		{
			return 81;
		}
		else if(a == 81 && b == 1)
		{
			return 80;
		}
		else if(a == 81 && b == 2)
		{
			return 79;
		}
		else if(a == 81 && b == 3)
		{
			return 78;
		}
		else if(a == 81 && b == 4)
		{
			return 77;
		}
		else if(a == 81 && b == 5)
		{
			return 76;
		}
		else if(a == 81 && b == 6)
		{
			return 75;
		}
		else if(a == 81 && b == 7)
		{
			return 74;
		}
		else if(a == 81 && b == 8)
		{
			return 73;
		}
		else if(a == 81 && b == 9)
		{
			return 72;
		}
		else if(a == 81 && b == 10)
		{
			return 71;
		}
		else if(a == 81 && b == 11)
		{
			return 70;
		}
		else if(a == 81 && b == 12)
		{
			return 69;
		}
		else if(a == 81 && b == 13)
		{
			return 68;
		}
		else if(a == 81 && b == 14)
		{
			return 67;
		}
		else if(a == 81 && b == 15)
		{
			return 66;
		}
		else if(a == 81 && b == 16)
		{
			return 65;
		}
		else if(a == 81 && b == 17)
		{
			return 64;
		}
		else if(a == 81 && b == 18)
		{
			return 63;
		}
		else if(a == 81 && b == 19)
		{
			return 62;
		}
		else if(a == 81 && b == 20)
		{
			return 61;
		}
		else if(a == 81 && b == 21)
		{
			return 60;
		}
		else if(a == 81 && b == 22)
		{
			return 59;
		}
		else if(a == 81 && b == 23)
		{
			return 58;
		}
		else if(a == 81 && b == 24)
		{
			return 57;
		}
		else if(a == 81 && b == 25)
		{
			return 56;
		}
		else if(a == 81 && b == 26)
		{
			return 55;
		}
		else if(a == 81 && b == 27)
		{
			return 54;
		}
		else if(a == 81 && b == 28)
		{
			return 53;
		}
		else if(a == 81 && b == 29)
		{
			return 52;
		}
		else if(a == 81 && b == 30)
		{
			return 51;
		}
		else if(a == 81 && b == 31)
		{
			return 50;
		}
		else if(a == 81 && b == 32)
		{
			return 49;
		}
		else if(a == 81 && b == 33)
		{
			return 48;
		}
		else if(a == 81 && b == 34)
		{
			return 47;
		}
		else if(a == 81 && b == 35)
		{
			return 46;
		}
		else if(a == 81 && b == 36)
		{
			return 45;
		}
		else if(a == 81 && b == 37)
		{
			return 44;
		}
		else if(a == 81 && b == 38)
		{
			return 43;
		}
		else if(a == 81 && b == 39)
		{
			return 42;
		}
		else if(a == 81 && b == 40)
		{
			return 41;
		}
		else if(a == 81 && b == 41)
		{
			return 40;
		}
		else if(a == 81 && b == 42)
		{
			return 39;
		}
		else if(a == 81 && b == 43)
		{
			return 38;
		}
		else if(a == 81 && b == 44)
		{
			return 37;
		}
		else if(a == 81 && b == 45)
		{
			return 36;
		}
		else if(a == 81 && b == 46)
		{
			return 35;
		}
		else if(a == 81 && b == 47)
		{
			return 34;
		}
		else if(a == 81 && b == 48)
		{
			return 33;
		}
		else if(a == 81 && b == 49)
		{
			return 32;
		}
		else if(a == 81 && b == 50)
		{
			return 31;
		}
		else if(a == 81 && b == 51)
		{
			return 30;
		}
		else if(a == 81 && b == 52)
		{
			return 29;
		}
		else if(a == 81 && b == 53)
		{
			return 28;
		}
		else if(a == 81 && b == 54)
		{
			return 27;
		}
		else if(a == 81 && b == 55)
		{
			return 26;
		}
		else if(a == 81 && b == 56)
		{
			return 25;
		}
		else if(a == 81 && b == 57)
		{
			return 24;
		}
		else if(a == 81 && b == 58)
		{
			return 23;
		}
		else if(a == 81 && b == 59)
		{
			return 22;
		}
		else if(a == 81 && b == 60)
		{
			return 21;
		}
		else if(a == 81 && b == 61)
		{
			return 20;
		}
		else if(a == 81 && b == 62)
		{
			return 19;
		}
		else if(a == 81 && b == 63)
		{
			return 18;
		}
		else if(a == 81 && b == 64)
		{
			return 17;
		}
		else if(a == 81 && b == 65)
		{
			return 16;
		}
		else if(a == 81 && b == 66)
		{
			return 15;
		}
		else if(a == 81 && b == 67)
		{
			return 14;
		}
		else if(a == 81 && b == 68)
		{
			return 13;
		}
		else if(a == 81 && b == 69)
		{
			return 12;
		}
		else if(a == 81 && b == 70)
		{
			return 11;
		}
		else if(a == 81 && b == 71)
		{
			return 10;
		}
		else if(a == 81 && b == 72)
		{
			return 9;
		}
		else if(a == 81 && b == 73)
		{
			return 8;
		}
		else if(a == 81 && b == 74)
		{
			return 7;
		}
		else if(a == 81 && b == 75)
		{
			return 6;
		}
		else if(a == 81 && b == 76)
		{
			return 5;
		}
		else if(a == 81 && b == 77)
		{
			return 4;
		}
		else if(a == 81 && b == 78)
		{
			return 3;
		}
		else if(a == 81 && b == 79)
		{
			return 2;
		}
		else if(a == 81 && b == 80)
		{
			return 1;
		}
		else if(a == 81 && b == 81)
		{
			return 0;
		}
		else if(a == 81 && b == 82)
		{
			return -1;
		}
		else if(a == 81 && b == 83)
		{
			return -2;
		}
		else if(a == 81 && b == 84)
		{
			return -3;
		}
		else if(a == 81 && b == 85)
		{
			return -4;
		}
		else if(a == 81 && b == 86)
		{
			return -5;
		}
		else if(a == 81 && b == 87)
		{
			return -6;
		}
		else if(a == 81 && b == 88)
		{
			return -7;
		}
		else if(a == 81 && b == 89)
		{
			return -8;
		}
		else if(a == 81 && b == 90)
		{
			return -9;
		}
		else if(a == 81 && b == 91)
		{
			return -10;
		}
		else if(a == 81 && b == 92)
		{
			return -11;
		}
		else if(a == 81 && b == 93)
		{
			return -12;
		}
		else if(a == 81 && b == 94)
		{
			return -13;
		}
		else if(a == 81 && b == 95)
		{
			return -14;
		}
		else if(a == 81 && b == 96)
		{
			return -15;
		}
		else if(a == 81 && b == 97)
		{
			return -16;
		}
		else if(a == 81 && b == 98)
		{
			return -17;
		}
		else if(a == 81 && b == 99)
		{
			return -18;
		}
		else if(a == 81 && b == 100)
		{
			return -19;
		}
		else if(a == 82 && b == 0)
		{
			return 82;
		}
		else if(a == 82 && b == 1)
		{
			return 81;
		}
		else if(a == 82 && b == 2)
		{
			return 80;
		}
		else if(a == 82 && b == 3)
		{
			return 79;
		}
		else if(a == 82 && b == 4)
		{
			return 78;
		}
		else if(a == 82 && b == 5)
		{
			return 77;
		}
		else if(a == 82 && b == 6)
		{
			return 76;
		}
		else if(a == 82 && b == 7)
		{
			return 75;
		}
		else if(a == 82 && b == 8)
		{
			return 74;
		}
		else if(a == 82 && b == 9)
		{
			return 73;
		}
		else if(a == 82 && b == 10)
		{
			return 72;
		}
		else if(a == 82 && b == 11)
		{
			return 71;
		}
		else if(a == 82 && b == 12)
		{
			return 70;
		}
		else if(a == 82 && b == 13)
		{
			return 69;
		}
		else if(a == 82 && b == 14)
		{
			return 68;
		}
		else if(a == 82 && b == 15)
		{
			return 67;
		}
		else if(a == 82 && b == 16)
		{
			return 66;
		}
		else if(a == 82 && b == 17)
		{
			return 65;
		}
		else if(a == 82 && b == 18)
		{
			return 64;
		}
		else if(a == 82 && b == 19)
		{
			return 63;
		}
		else if(a == 82 && b == 20)
		{
			return 62;
		}
		else if(a == 82 && b == 21)
		{
			return 61;
		}
		else if(a == 82 && b == 22)
		{
			return 60;
		}
		else if(a == 82 && b == 23)
		{
			return 59;
		}
		else if(a == 82 && b == 24)
		{
			return 58;
		}
		else if(a == 82 && b == 25)
		{
			return 57;
		}
		else if(a == 82 && b == 26)
		{
			return 56;
		}
		else if(a == 82 && b == 27)
		{
			return 55;
		}
		else if(a == 82 && b == 28)
		{
			return 54;
		}
		else if(a == 82 && b == 29)
		{
			return 53;
		}
		else if(a == 82 && b == 30)
		{
			return 52;
		}
		else if(a == 82 && b == 31)
		{
			return 51;
		}
		else if(a == 82 && b == 32)
		{
			return 50;
		}
		else if(a == 82 && b == 33)
		{
			return 49;
		}
		else if(a == 82 && b == 34)
		{
			return 48;
		}
		else if(a == 82 && b == 35)
		{
			return 47;
		}
		else if(a == 82 && b == 36)
		{
			return 46;
		}
		else if(a == 82 && b == 37)
		{
			return 45;
		}
		else if(a == 82 && b == 38)
		{
			return 44;
		}
		else if(a == 82 && b == 39)
		{
			return 43;
		}
		else if(a == 82 && b == 40)
		{
			return 42;
		}
		else if(a == 82 && b == 41)
		{
			return 41;
		}
		else if(a == 82 && b == 42)
		{
			return 40;
		}
		else if(a == 82 && b == 43)
		{
			return 39;
		}
		else if(a == 82 && b == 44)
		{
			return 38;
		}
		else if(a == 82 && b == 45)
		{
			return 37;
		}
		else if(a == 82 && b == 46)
		{
			return 36;
		}
		else if(a == 82 && b == 47)
		{
			return 35;
		}
		else if(a == 82 && b == 48)
		{
			return 34;
		}
		else if(a == 82 && b == 49)
		{
			return 33;
		}
		else if(a == 82 && b == 50)
		{
			return 32;
		}
		else if(a == 82 && b == 51)
		{
			return 31;
		}
		else if(a == 82 && b == 52)
		{
			return 30;
		}
		else if(a == 82 && b == 53)
		{
			return 29;
		}
		else if(a == 82 && b == 54)
		{
			return 28;
		}
		else if(a == 82 && b == 55)
		{
			return 27;
		}
		else if(a == 82 && b == 56)
		{
			return 26;
		}
		else if(a == 82 && b == 57)
		{
			return 25;
		}
		else if(a == 82 && b == 58)
		{
			return 24;
		}
		else if(a == 82 && b == 59)
		{
			return 23;
		}
		else if(a == 82 && b == 60)
		{
			return 22;
		}
		else if(a == 82 && b == 61)
		{
			return 21;
		}
		else if(a == 82 && b == 62)
		{
			return 20;
		}
		else if(a == 82 && b == 63)
		{
			return 19;
		}
		else if(a == 82 && b == 64)
		{
			return 18;
		}
		else if(a == 82 && b == 65)
		{
			return 17;
		}
		else if(a == 82 && b == 66)
		{
			return 16;
		}
		else if(a == 82 && b == 67)
		{
			return 15;
		}
		else if(a == 82 && b == 68)
		{
			return 14;
		}
		else if(a == 82 && b == 69)
		{
			return 13;
		}
		else if(a == 82 && b == 70)
		{
			return 12;
		}
		else if(a == 82 && b == 71)
		{
			return 11;
		}
		else if(a == 82 && b == 72)
		{
			return 10;
		}
		else if(a == 82 && b == 73)
		{
			return 9;
		}
		else if(a == 82 && b == 74)
		{
			return 8;
		}
		else if(a == 82 && b == 75)
		{
			return 7;
		}
		else if(a == 82 && b == 76)
		{
			return 6;
		}
		else if(a == 82 && b == 77)
		{
			return 5;
		}
		else if(a == 82 && b == 78)
		{
			return 4;
		}
		else if(a == 82 && b == 79)
		{
			return 3;
		}
		else if(a == 82 && b == 80)
		{
			return 2;
		}
		else if(a == 82 && b == 81)
		{
			return 1;
		}
		else if(a == 82 && b == 82)
		{
			return 0;
		}
		else if(a == 82 && b == 83)
		{
			return -1;
		}
		else if(a == 82 && b == 84)
		{
			return -2;
		}
		else if(a == 82 && b == 85)
		{
			return -3;
		}
		else if(a == 82 && b == 86)
		{
			return -4;
		}
		else if(a == 82 && b == 87)
		{
			return -5;
		}
		else if(a == 82 && b == 88)
		{
			return -6;
		}
		else if(a == 82 && b == 89)
		{
			return -7;
		}
		else if(a == 82 && b == 90)
		{
			return -8;
		}
		else if(a == 82 && b == 91)
		{
			return -9;
		}
		else if(a == 82 && b == 92)
		{
			return -10;
		}
		else if(a == 82 && b == 93)
		{
			return -11;
		}
		else if(a == 82 && b == 94)
		{
			return -12;
		}
		else if(a == 82 && b == 95)
		{
			return -13;
		}
		else if(a == 82 && b == 96)
		{
			return -14;
		}
		else if(a == 82 && b == 97)
		{
			return -15;
		}
		else if(a == 82 && b == 98)
		{
			return -16;
		}
		else if(a == 82 && b == 99)
		{
			return -17;
		}
		else if(a == 82 && b == 100)
		{
			return -18;
		}
		else if(a == 83 && b == 0)
		{
			return 83;
		}
		else if(a == 83 && b == 1)
		{
			return 82;
		}
		else if(a == 83 && b == 2)
		{
			return 81;
		}
		else if(a == 83 && b == 3)
		{
			return 80;
		}
		else if(a == 83 && b == 4)
		{
			return 79;
		}
		else if(a == 83 && b == 5)
		{
			return 78;
		}
		else if(a == 83 && b == 6)
		{
			return 77;
		}
		else if(a == 83 && b == 7)
		{
			return 76;
		}
		else if(a == 83 && b == 8)
		{
			return 75;
		}
		else if(a == 83 && b == 9)
		{
			return 74;
		}
		else if(a == 83 && b == 10)
		{
			return 73;
		}
		else if(a == 83 && b == 11)
		{
			return 72;
		}
		else if(a == 83 && b == 12)
		{
			return 71;
		}
		else if(a == 83 && b == 13)
		{
			return 70;
		}
		else if(a == 83 && b == 14)
		{
			return 69;
		}
		else if(a == 83 && b == 15)
		{
			return 68;
		}
		else if(a == 83 && b == 16)
		{
			return 67;
		}
		else if(a == 83 && b == 17)
		{
			return 66;
		}
		else if(a == 83 && b == 18)
		{
			return 65;
		}
		else if(a == 83 && b == 19)
		{
			return 64;
		}
		else if(a == 83 && b == 20)
		{
			return 63;
		}
		else if(a == 83 && b == 21)
		{
			return 62;
		}
		else if(a == 83 && b == 22)
		{
			return 61;
		}
		else if(a == 83 && b == 23)
		{
			return 60;
		}
		else if(a == 83 && b == 24)
		{
			return 59;
		}
		else if(a == 83 && b == 25)
		{
			return 58;
		}
		else if(a == 83 && b == 26)
		{
			return 57;
		}
		else if(a == 83 && b == 27)
		{
			return 56;
		}
		else if(a == 83 && b == 28)
		{
			return 55;
		}
		else if(a == 83 && b == 29)
		{
			return 54;
		}
		{
		}
		{
