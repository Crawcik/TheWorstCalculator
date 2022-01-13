<?php

if (isset($_GET['method'][0]))
{
	$method = $_GET['method'][0];
}
else
{
	$method = 'a';
}

if (isset($_GET['a']) && isset($_GET['b'])) 
{
	echo "Max number: 50<br>";
	$a = $_GET['a'];
	$b = $_GET['b'];
	echo "First number: $a<br>";
	echo "Second number: $b<br>";
	echo "Result: ";
	if ($method == 'a')
	{
		add($a, $b);
	}
	else if ($method == 's')
	{
		subtract($a, $b);
	}
	else
	{
		echo "Bad method selected!";
	}
} 
else
{
	echo "Parameter a and/or b is not set!<br>Example: calculator.php?a=2&b=3&method=add";
}


function add($a, $b)
{
	if ($a == 0 && $b == 0)
	{
		echo 0;
	}
	else if ($a == 0 && $b == 1)
	{
		echo 1;
	}
	else if ($a == 0 && $b == 2)
	{
		echo 2;
	}
	else if ($a == 0 && $b == 3)
	{
		echo 3;
	}
	else if ($a == 0 && $b == 4)
	{
		echo 4;
	}
	else if ($a == 0 && $b == 5)
	{
		echo 5;
	}
	else if ($a == 0 && $b == 6)
	{
		echo 6;
	}
	else if ($a == 0 && $b == 7)
	{
		echo 7;
	}
	else if ($a == 0 && $b == 8)
	{
		echo 8;
	}
	else if ($a == 0 && $b == 9)
	{
		echo 9;
	}
	else if ($a == 0 && $b == 10)
	{
		echo 10;
	}
	else if ($a == 0 && $b == 11)
	{
		echo 11;
	}
	else if ($a == 0 && $b == 12)
	{
		echo 12;
	}
	else if ($a == 0 && $b == 13)
	{
		echo 13;
	}
	else if ($a == 0 && $b == 14)
	{
		echo 14;
	}
	else if ($a == 0 && $b == 15)
	{
		echo 15;
	}
	else if ($a == 0 && $b == 16)
	{
		echo 16;
	}
	else if ($a == 0 && $b == 17)
	{
		echo 17;
	}
	else if ($a == 0 && $b == 18)
	{
		echo 18;
	}
	else if ($a == 0 && $b == 19)
	{
		echo 19;
	}
	else if ($a == 0 && $b == 20)
	{
		echo 20;
	}
	else if ($a == 0 && $b == 21)
	{
		echo 21;
	}
	else if ($a == 0 && $b == 22)
	{
		echo 22;
	}
	else if ($a == 0 && $b == 23)
	{
		echo 23;
	}
	else if ($a == 0 && $b == 24)
	{
		echo 24;
	}
	else if ($a == 0 && $b == 25)
	{
		echo 25;
	}
	else if ($a == 0 && $b == 26)
	{
		echo 26;
	}
	else if ($a == 0 && $b == 27)
	{
		echo 27;
	}
	else if ($a == 0 && $b == 28)
	{
		echo 28;
	}
	else if ($a == 0 && $b == 29)
	{
		echo 29;
	}
	else if ($a == 0 && $b == 30)
	{
		echo 30;
	}
	else if ($a == 0 && $b == 31)
	{
		echo 31;
	}
	else if ($a == 0 && $b == 32)
	{
		echo 32;
	}
	else if ($a == 0 && $b == 33)
	{
		echo 33;
	}
	else if ($a == 0 && $b == 34)
	{
		echo 34;
	}
	else if ($a == 0 && $b == 35)
	{
		echo 35;
	}
	else if ($a == 0 && $b == 36)
	{
		echo 36;
	}
	else if ($a == 0 && $b == 37)
	{
		echo 37;
	}
	else if ($a == 0 && $b == 38)
	{
		echo 38;
	}
	else if ($a == 0 && $b == 39)
	{
		echo 39;
	}
	else if ($a == 0 && $b == 40)
	{
		echo 40;
	}
	else if ($a == 0 && $b == 41)
	{
		echo 41;
	}
	else if ($a == 0 && $b == 42)
	{
		echo 42;
	}
	else if ($a == 0 && $b == 43)
	{
		echo 43;
	}
	else if ($a == 0 && $b == 44)
	{
		echo 44;
	}
	else if ($a == 0 && $b == 45)
	{
		echo 45;
	}
	else if ($a == 0 && $b == 46)
	{
		echo 46;
	}
	else if ($a == 0 && $b == 47)
	{
		echo 47;
	}
	else if ($a == 0 && $b == 48)
	{
		echo 48;
	}
	else if ($a == 0 && $b == 49)
	{
		echo 49;
	}
	else if ($a == 0 && $b == 50)
	{
		echo 50;
	}
	else if ($a == 1 && $b == 0)
	{
		echo 1;
	}
	else if ($a == 1 && $b == 1)
	{
		echo 2;
	}
	else if ($a == 1 && $b == 2)
	{
		echo 3;
	}
	else if ($a == 1 && $b == 3)
	{
		echo 4;
	}
	else if ($a == 1 && $b == 4)
	{
		echo 5;
	}
	else if ($a == 1 && $b == 5)
	{
		echo 6;
	}
	else if ($a == 1 && $b == 6)
	{
		echo 7;
	}
	else if ($a == 1 && $b == 7)
	{
		echo 8;
	}
	else if ($a == 1 && $b == 8)
	{
		echo 9;
	}
	else if ($a == 1 && $b == 9)
	{
		echo 10;
	}
	else if ($a == 1 && $b == 10)
	{
		echo 11;
	}
	else if ($a == 1 && $b == 11)
	{
		echo 12;
	}
	else if ($a == 1 && $b == 12)
	{
		echo 13;
	}
	else if ($a == 1 && $b == 13)
	{
		echo 14;
	}
	else if ($a == 1 && $b == 14)
	{
		echo 15;
	}
	else if ($a == 1 && $b == 15)
	{
		echo 16;
	}
	else if ($a == 1 && $b == 16)
	{
		echo 17;
	}
	else if ($a == 1 && $b == 17)
	{
		echo 18;
	}
	else if ($a == 1 && $b == 18)
	{
		echo 19;
	}
	else if ($a == 1 && $b == 19)
	{
		echo 20;
	}
	else if ($a == 1 && $b == 20)
	{
		echo 21;
	}
	else if ($a == 1 && $b == 21)
	{
		echo 22;
	}
	else if ($a == 1 && $b == 22)
	{
		echo 23;
	}
	else if ($a == 1 && $b == 23)
	{
		echo 24;
	}
	else if ($a == 1 && $b == 24)
	{
		echo 25;
	}
	else if ($a == 1 && $b == 25)
	{
		echo 26;
	}
	else if ($a == 1 && $b == 26)
	{
		echo 27;
	}
	else if ($a == 1 && $b == 27)
	{
		echo 28;
	}
	else if ($a == 1 && $b == 28)
	{
		echo 29;
	}
	else if ($a == 1 && $b == 29)
	{
		echo 30;
	}
	else if ($a == 1 && $b == 30)
	{
		echo 31;
	}
	else if ($a == 1 && $b == 31)
	{
		echo 32;
	}
	else if ($a == 1 && $b == 32)
	{
		echo 33;
	}
	else if ($a == 1 && $b == 33)
	{
		echo 34;
	}
	else if ($a == 1 && $b == 34)
	{
		echo 35;
	}
	else if ($a == 1 && $b == 35)
	{
		echo 36;
	}
	else if ($a == 1 && $b == 36)
	{
		echo 37;
	}
	else if ($a == 1 && $b == 37)
	{
		echo 38;
	}
	else if ($a == 1 && $b == 38)
	{
		echo 39;
	}
	else if ($a == 1 && $b == 39)
	{
		echo 40;
	}
	else if ($a == 1 && $b == 40)
	{
		echo 41;
	}
	else if ($a == 1 && $b == 41)
	{
		echo 42;
	}
	else if ($a == 1 && $b == 42)
	{
		echo 43;
	}
	else if ($a == 1 && $b == 43)
	{
		echo 44;
	}
	else if ($a == 1 && $b == 44)
	{
		echo 45;
	}
	else if ($a == 1 && $b == 45)
	{
		echo 46;
	}
	else if ($a == 1 && $b == 46)
	{
		echo 47;
	}
	else if ($a == 1 && $b == 47)
	{
		echo 48;
	}
	else if ($a == 1 && $b == 48)
	{
		echo 49;
	}
	else if ($a == 1 && $b == 49)
	{
		echo 50;
	}
	else if ($a == 1 && $b == 50)
	{
		echo 51;
	}
	else if ($a == 2 && $b == 0)
	{
		echo 2;
	}
	else if ($a == 2 && $b == 1)
	{
		echo 3;
	}
	else if ($a == 2 && $b == 2)
	{
		echo 4;
	}
	else if ($a == 2 && $b == 3)
	{
		echo 5;
	}
	else if ($a == 2 && $b == 4)
	{
		echo 6;
	}
	else if ($a == 2 && $b == 5)
	{
		echo 7;
	}
	else if ($a == 2 && $b == 6)
	{
		echo 8;
	}
	else if ($a == 2 && $b == 7)
	{
		echo 9;
	}
	else if ($a == 2 && $b == 8)
	{
		echo 10;
	}
	else if ($a == 2 && $b == 9)
	{
		echo 11;
	}
	else if ($a == 2 && $b == 10)
	{
		echo 12;
	}
	else if ($a == 2 && $b == 11)
	{
		echo 13;
	}
	else if ($a == 2 && $b == 12)
	{
		echo 14;
	}
	else if ($a == 2 && $b == 13)
	{
		echo 15;
	}
	else if ($a == 2 && $b == 14)
	{
		echo 16;
	}
	else if ($a == 2 && $b == 15)
	{
		echo 17;
	}
	else if ($a == 2 && $b == 16)
	{
		echo 18;
	}
	else if ($a == 2 && $b == 17)
	{
		echo 19;
	}
	else if ($a == 2 && $b == 18)
	{
		echo 20;
	}
	else if ($a == 2 && $b == 19)
	{
		echo 21;
	}
	else if ($a == 2 && $b == 20)
	{
		echo 22;
	}
	else if ($a == 2 && $b == 21)
	{
		echo 23;
	}
	else if ($a == 2 && $b == 22)
	{
		echo 24;
	}
	else if ($a == 2 && $b == 23)
	{
		echo 25;
	}
	else if ($a == 2 && $b == 24)
	{
		echo 26;
	}
	else if ($a == 2 && $b == 25)
	{
		echo 27;
	}
	else if ($a == 2 && $b == 26)
	{
		echo 28;
	}
	else if ($a == 2 && $b == 27)
	{
		echo 29;
	}
	else if ($a == 2 && $b == 28)
	{
		echo 30;
	}
	else if ($a == 2 && $b == 29)
	{
		echo 31;
	}
	else if ($a == 2 && $b == 30)
	{
		echo 32;
	}
	else if ($a == 2 && $b == 31)
	{
		echo 33;
	}
	else if ($a == 2 && $b == 32)
	{
		echo 34;
	}
	else if ($a == 2 && $b == 33)
	{
		echo 35;
	}
	else if ($a == 2 && $b == 34)
	{
		echo 36;
	}
	else if ($a == 2 && $b == 35)
	{
		echo 37;
	}
	else if ($a == 2 && $b == 36)
	{
		echo 38;
	}
	else if ($a == 2 && $b == 37)
	{
		echo 39;
	}
	else if ($a == 2 && $b == 38)
	{
		echo 40;
	}
	else if ($a == 2 && $b == 39)
	{
		echo 41;
	}
	else if ($a == 2 && $b == 40)
	{
		echo 42;
	}
	else if ($a == 2 && $b == 41)
	{
		echo 43;
	}
	else if ($a == 2 && $b == 42)
	{
		echo 44;
	}
	else if ($a == 2 && $b == 43)
	{
		echo 45;
	}
	else if ($a == 2 && $b == 44)
	{
		echo 46;
	}
	else if ($a == 2 && $b == 45)
	{
		echo 47;
	}
	else if ($a == 2 && $b == 46)
	{
		echo 48;
	}
	else if ($a == 2 && $b == 47)
	{
		echo 49;
	}
	else if ($a == 2 && $b == 48)
	{
		echo 50;
	}
	else if ($a == 2 && $b == 49)
	{
		echo 51;
	}
	else if ($a == 2 && $b == 50)
	{
		echo 52;
	}
	else if ($a == 3 && $b == 0)
	{
		echo 3;
	}
	else if ($a == 3 && $b == 1)
	{
		echo 4;
	}
	else if ($a == 3 && $b == 2)
	{
		echo 5;
	}
	else if ($a == 3 && $b == 3)
	{
		echo 6;
	}
	else if ($a == 3 && $b == 4)
	{
		echo 7;
	}
	else if ($a == 3 && $b == 5)
	{
		echo 8;
	}
	else if ($a == 3 && $b == 6)
	{
		echo 9;
	}
	else if ($a == 3 && $b == 7)
	{
		echo 10;
	}
	else if ($a == 3 && $b == 8)
	{
		echo 11;
	}
	else if ($a == 3 && $b == 9)
	{
		echo 12;
	}
	else if ($a == 3 && $b == 10)
	{
		echo 13;
	}
	else if ($a == 3 && $b == 11)
	{
		echo 14;
	}
	else if ($a == 3 && $b == 12)
	{
		echo 15;
	}
	else if ($a == 3 && $b == 13)
	{
		echo 16;
	}
	else if ($a == 3 && $b == 14)
	{
		echo 17;
	}
	else if ($a == 3 && $b == 15)
	{
		echo 18;
	}
	else if ($a == 3 && $b == 16)
	{
		echo 19;
	}
	else if ($a == 3 && $b == 17)
	{
		echo 20;
	}
	else if ($a == 3 && $b == 18)
	{
		echo 21;
	}
	else if ($a == 3 && $b == 19)
	{
		echo 22;
	}
	else if ($a == 3 && $b == 20)
	{
		echo 23;
	}
	else if ($a == 3 && $b == 21)
	{
		echo 24;
	}
	else if ($a == 3 && $b == 22)
	{
		echo 25;
	}
	else if ($a == 3 && $b == 23)
	{
		echo 26;
	}
	else if ($a == 3 && $b == 24)
	{
		echo 27;
	}
	else if ($a == 3 && $b == 25)
	{
		echo 28;
	}
	else if ($a == 3 && $b == 26)
	{
		echo 29;
	}
	else if ($a == 3 && $b == 27)
	{
		echo 30;
	}
	else if ($a == 3 && $b == 28)
	{
		echo 31;
	}
	else if ($a == 3 && $b == 29)
	{
		echo 32;
	}
	else if ($a == 3 && $b == 30)
	{
		echo 33;
	}
	else if ($a == 3 && $b == 31)
	{
		echo 34;
	}
	else if ($a == 3 && $b == 32)
	{
		echo 35;
	}
	else if ($a == 3 && $b == 33)
	{
		echo 36;
	}
	else if ($a == 3 && $b == 34)
	{
		echo 37;
	}
	else if ($a == 3 && $b == 35)
	{
		echo 38;
	}
	else if ($a == 3 && $b == 36)
	{
		echo 39;
	}
	else if ($a == 3 && $b == 37)
	{
		echo 40;
	}
	else if ($a == 3 && $b == 38)
	{
		echo 41;
	}
	else if ($a == 3 && $b == 39)
	{
		echo 42;
	}
	else if ($a == 3 && $b == 40)
	{
		echo 43;
	}
	else if ($a == 3 && $b == 41)
	{
		echo 44;
	}
	else if ($a == 3 && $b == 42)
	{
		echo 45;
	}
	else if ($a == 3 && $b == 43)
	{
		echo 46;
	}
	else if ($a == 3 && $b == 44)
	{
		echo 47;
	}
	else if ($a == 3 && $b == 45)
	{
		echo 48;
	}
	else if ($a == 3 && $b == 46)
	{
		echo 49;
	}
	else if ($a == 3 && $b == 47)
	{
		echo 50;
	}
	else if ($a == 3 && $b == 48)
	{
		echo 51;
	}
	else if ($a == 3 && $b == 49)
	{
		echo 52;
	}
	else if ($a == 3 && $b == 50)
	{
		echo 53;
	}
	else if ($a == 4 && $b == 0)
	{
		echo 4;
	}
	else if ($a == 4 && $b == 1)
	{
		echo 5;
	}
	else if ($a == 4 && $b == 2)
	{
		echo 6;
	}
	else if ($a == 4 && $b == 3)
	{
		echo 7;
	}
	else if ($a == 4 && $b == 4)
	{
		echo 8;
	}
	else if ($a == 4 && $b == 5)
	{
		echo 9;
	}
	else if ($a == 4 && $b == 6)
	{
		echo 10;
	}
	else if ($a == 4 && $b == 7)
	{
		echo 11;
	}
	else if ($a == 4 && $b == 8)
	{
		echo 12;
	}
	else if ($a == 4 && $b == 9)
	{
		echo 13;
	}
	else if ($a == 4 && $b == 10)
	{
		echo 14;
	}
	else if ($a == 4 && $b == 11)
	{
		echo 15;
	}
	else if ($a == 4 && $b == 12)
	{
		echo 16;
	}
	else if ($a == 4 && $b == 13)
	{
		echo 17;
	}
	else if ($a == 4 && $b == 14)
	{
		echo 18;
	}
	else if ($a == 4 && $b == 15)
	{
		echo 19;
	}
	else if ($a == 4 && $b == 16)
	{
		echo 20;
	}
	else if ($a == 4 && $b == 17)
	{
		echo 21;
	}
	else if ($a == 4 && $b == 18)
	{
		echo 22;
	}
	else if ($a == 4 && $b == 19)
	{
		echo 23;
	}
	else if ($a == 4 && $b == 20)
	{
		echo 24;
	}
	else if ($a == 4 && $b == 21)
	{
		echo 25;
	}
	else if ($a == 4 && $b == 22)
	{
		echo 26;
	}
	else if ($a == 4 && $b == 23)
	{
		echo 27;
	}
	else if ($a == 4 && $b == 24)
	{
		echo 28;
	}
	else if ($a == 4 && $b == 25)
	{
		echo 29;
	}
	else if ($a == 4 && $b == 26)
	{
		echo 30;
	}
	else if ($a == 4 && $b == 27)
	{
		echo 31;
	}
	else if ($a == 4 && $b == 28)
	{
		echo 32;
	}
	else if ($a == 4 && $b == 29)
	{
		echo 33;
	}
	else if ($a == 4 && $b == 30)
	{
		echo 34;
	}
	else if ($a == 4 && $b == 31)
	{
		echo 35;
	}
	else if ($a == 4 && $b == 32)
	{
		echo 36;
	}
	else if ($a == 4 && $b == 33)
	{
		echo 37;
	}
	else if ($a == 4 && $b == 34)
	{
		echo 38;
	}
	else if ($a == 4 && $b == 35)
	{
		echo 39;
	}
	else if ($a == 4 && $b == 36)
	{
		echo 40;
	}
	else if ($a == 4 && $b == 37)
	{
		echo 41;
	}
	else if ($a == 4 && $b == 38)
	{
		echo 42;
	}
	else if ($a == 4 && $b == 39)
	{
		echo 43;
	}
	else if ($a == 4 && $b == 40)
	{
		echo 44;
	}
	else if ($a == 4 && $b == 41)
	{
		echo 45;
	}
	else if ($a == 4 && $b == 42)
	{
		echo 46;
	}
	else if ($a == 4 && $b == 43)
	{
		echo 47;
	}
	else if ($a == 4 && $b == 44)
	{
		echo 48;
	}
	else if ($a == 4 && $b == 45)
	{
		echo 49;
	}
	else if ($a == 4 && $b == 46)
	{
		echo 50;
	}
	else if ($a == 4 && $b == 47)
	{
		echo 51;
	}
	else if ($a == 4 && $b == 48)
	{
		echo 52;
	}
	else if ($a == 4 && $b == 49)
	{
		echo 53;
	}
	else if ($a == 4 && $b == 50)
	{
		echo 54;
	}
	else if ($a == 5 && $b == 0)
	{
		echo 5;
	}
	else if ($a == 5 && $b == 1)
	{
		echo 6;
	}
	else if ($a == 5 && $b == 2)
	{
		echo 7;
	}
	else if ($a == 5 && $b == 3)
	{
		echo 8;
	}
	else if ($a == 5 && $b == 4)
	{
		echo 9;
	}
	else if ($a == 5 && $b == 5)
	{
		echo 10;
	}
	else if ($a == 5 && $b == 6)
	{
		echo 11;
	}
	else if ($a == 5 && $b == 7)
	{
		echo 12;
	}
	else if ($a == 5 && $b == 8)
	{
		echo 13;
	}
	else if ($a == 5 && $b == 9)
	{
		echo 14;
	}
	else if ($a == 5 && $b == 10)
	{
		echo 15;
	}
	else if ($a == 5 && $b == 11)
	{
		echo 16;
	}
	else if ($a == 5 && $b == 12)
	{
		echo 17;
	}
	else if ($a == 5 && $b == 13)
	{
		echo 18;
	}
	else if ($a == 5 && $b == 14)
	{
		echo 19;
	}
	else if ($a == 5 && $b == 15)
	{
		echo 20;
	}
	else if ($a == 5 && $b == 16)
	{
		echo 21;
	}
	else if ($a == 5 && $b == 17)
	{
		echo 22;
	}
	else if ($a == 5 && $b == 18)
	{
		echo 23;
	}
	else if ($a == 5 && $b == 19)
	{
		echo 24;
	}
	else if ($a == 5 && $b == 20)
	{
		echo 25;
	}
	else if ($a == 5 && $b == 21)
	{
		echo 26;
	}
	else if ($a == 5 && $b == 22)
	{
		echo 27;
	}
	else if ($a == 5 && $b == 23)
	{
		echo 28;
	}
	else if ($a == 5 && $b == 24)
	{
		echo 29;
	}
	else if ($a == 5 && $b == 25)
	{
		echo 30;
	}
	else if ($a == 5 && $b == 26)
	{
		echo 31;
	}
	else if ($a == 5 && $b == 27)
	{
		echo 32;
	}
	else if ($a == 5 && $b == 28)
	{
		echo 33;
	}
	else if ($a == 5 && $b == 29)
	{
		echo 34;
	}
	else if ($a == 5 && $b == 30)
	{
		echo 35;
	}
	else if ($a == 5 && $b == 31)
	{
		echo 36;
	}
	else if ($a == 5 && $b == 32)
	{
		echo 37;
	}
	else if ($a == 5 && $b == 33)
	{
		echo 38;
	}
	else if ($a == 5 && $b == 34)
	{
		echo 39;
	}
	else if ($a == 5 && $b == 35)
	{
		echo 40;
	}
	else if ($a == 5 && $b == 36)
	{
		echo 41;
	}
	else if ($a == 5 && $b == 37)
	{
		echo 42;
	}
	else if ($a == 5 && $b == 38)
	{
		echo 43;
	}
	else if ($a == 5 && $b == 39)
	{
		echo 44;
	}
	else if ($a == 5 && $b == 40)
	{
		echo 45;
	}
	else if ($a == 5 && $b == 41)
	{
		echo 46;
	}
	else if ($a == 5 && $b == 42)
	{
		echo 47;
	}
	else if ($a == 5 && $b == 43)
	{
		echo 48;
	}
	else if ($a == 5 && $b == 44)
	{
		echo 49;
	}
	else if ($a == 5 && $b == 45)
	{
		echo 50;
	}
	else if ($a == 5 && $b == 46)
	{
		echo 51;
	}
	else if ($a == 5 && $b == 47)
	{
		echo 52;
	}
	else if ($a == 5 && $b == 48)
	{
		echo 53;
	}
	else if ($a == 5 && $b == 49)
	{
		echo 54;
	}
	else if ($a == 5 && $b == 50)
	{
		echo 55;
	}
	else if ($a == 6 && $b == 0)
	{
		echo 6;
	}
	else if ($a == 6 && $b == 1)
	{
		echo 7;
	}
	else if ($a == 6 && $b == 2)
	{
		echo 8;
	}
	else if ($a == 6 && $b == 3)
	{
		echo 9;
	}
	else if ($a == 6 && $b == 4)
	{
		echo 10;
	}
	else if ($a == 6 && $b == 5)
	{
		echo 11;
	}
	else if ($a == 6 && $b == 6)
	{
		echo 12;
	}
	else if ($a == 6 && $b == 7)
	{
		echo 13;
	}
	else if ($a == 6 && $b == 8)
	{
		echo 14;
	}
	else if ($a == 6 && $b == 9)
	{
		echo 15;
	}
	else if ($a == 6 && $b == 10)
	{
		echo 16;
	}
	else if ($a == 6 && $b == 11)
	{
		echo 17;
	}
	else if ($a == 6 && $b == 12)
	{
		echo 18;
	}
	else if ($a == 6 && $b == 13)
	{
		echo 19;
	}
	else if ($a == 6 && $b == 14)
	{
		echo 20;
	}
	else if ($a == 6 && $b == 15)
	{
		echo 21;
	}
	else if ($a == 6 && $b == 16)
	{
		echo 22;
	}
	else if ($a == 6 && $b == 17)
	{
		echo 23;
	}
	else if ($a == 6 && $b == 18)
	{
		echo 24;
	}
	else if ($a == 6 && $b == 19)
	{
		echo 25;
	}
	else if ($a == 6 && $b == 20)
	{
		echo 26;
	}
	else if ($a == 6 && $b == 21)
	{
		echo 27;
	}
	else if ($a == 6 && $b == 22)
	{
		echo 28;
	}
	else if ($a == 6 && $b == 23)
	{
		echo 29;
	}
	else if ($a == 6 && $b == 24)
	{
		echo 30;
	}
	else if ($a == 6 && $b == 25)
	{
		echo 31;
	}
	else if ($a == 6 && $b == 26)
	{
		echo 32;
	}
	else if ($a == 6 && $b == 27)
	{
		echo 33;
	}
	else if ($a == 6 && $b == 28)
	{
		echo 34;
	}
	else if ($a == 6 && $b == 29)
	{
		echo 35;
	}
	else if ($a == 6 && $b == 30)
	{
		echo 36;
	}
	else if ($a == 6 && $b == 31)
	{
		echo 37;
	}
	else if ($a == 6 && $b == 32)
	{
		echo 38;
	}
	else if ($a == 6 && $b == 33)
	{
		echo 39;
	}
	else if ($a == 6 && $b == 34)
	{
		echo 40;
	}
	else if ($a == 6 && $b == 35)
	{
		echo 41;
	}
	else if ($a == 6 && $b == 36)
	{
		echo 42;
	}
	else if ($a == 6 && $b == 37)
	{
		echo 43;
	}
	else if ($a == 6 && $b == 38)
	{
		echo 44;
	}
	else if ($a == 6 && $b == 39)
	{
		echo 45;
	}
	else if ($a == 6 && $b == 40)
	{
		echo 46;
	}
	else if ($a == 6 && $b == 41)
	{
		echo 47;
	}
	else if ($a == 6 && $b == 42)
	{
		echo 48;
	}
	else if ($a == 6 && $b == 43)
	{
		echo 49;
	}
	else if ($a == 6 && $b == 44)
	{
		echo 50;
	}
	else if ($a == 6 && $b == 45)
	{
		echo 51;
	}
	else if ($a == 6 && $b == 46)
	{
		echo 52;
	}
	else if ($a == 6 && $b == 47)
	{
		echo 53;
	}
	else if ($a == 6 && $b == 48)
	{
		echo 54;
	}
	else if ($a == 6 && $b == 49)
	{
		echo 55;
	}
	else if ($a == 6 && $b == 50)
	{
		echo 56;
	}
	else if ($a == 7 && $b == 0)
	{
		echo 7;
	}
	else if ($a == 7 && $b == 1)
	{
		echo 8;
	}
	else if ($a == 7 && $b == 2)
	{
		echo 9;
	}
	else if ($a == 7 && $b == 3)
	{
		echo 10;
	}
	else if ($a == 7 && $b == 4)
	{
		echo 11;
	}
	else if ($a == 7 && $b == 5)
	{
		echo 12;
	}
	else if ($a == 7 && $b == 6)
	{
		echo 13;
	}
	else if ($a == 7 && $b == 7)
	{
		echo 14;
	}
	else if ($a == 7 && $b == 8)
	{
		echo 15;
	}
	else if ($a == 7 && $b == 9)
	{
		echo 16;
	}
	else if ($a == 7 && $b == 10)
	{
		echo 17;
	}
	else if ($a == 7 && $b == 11)
	{
		echo 18;
	}
	else if ($a == 7 && $b == 12)
	{
		echo 19;
	}
	else if ($a == 7 && $b == 13)
	{
		echo 20;
	}
	else if ($a == 7 && $b == 14)
	{
		echo 21;
	}
	else if ($a == 7 && $b == 15)
	{
		echo 22;
	}
	else if ($a == 7 && $b == 16)
	{
		echo 23;
	}
	else if ($a == 7 && $b == 17)
	{
		echo 24;
	}
	else if ($a == 7 && $b == 18)
	{
		echo 25;
	}
	else if ($a == 7 && $b == 19)
	{
		echo 26;
	}
	else if ($a == 7 && $b == 20)
	{
		echo 27;
	}
	else if ($a == 7 && $b == 21)
	{
		echo 28;
	}
	else if ($a == 7 && $b == 22)
	{
		echo 29;
	}
	else if ($a == 7 && $b == 23)
	{
		echo 30;
	}
	else if ($a == 7 && $b == 24)
	{
		echo 31;
	}
	else if ($a == 7 && $b == 25)
	{
		echo 32;
	}
	else if ($a == 7 && $b == 26)
	{
		echo 33;
	}
	else if ($a == 7 && $b == 27)
	{
		echo 34;
	}
	else if ($a == 7 && $b == 28)
	{
		echo 35;
	}
	else if ($a == 7 && $b == 29)
	{
		echo 36;
	}
	else if ($a == 7 && $b == 30)
	{
		echo 37;
	}
	else if ($a == 7 && $b == 31)
	{
		echo 38;
	}
	else if ($a == 7 && $b == 32)
	{
		echo 39;
	}
	else if ($a == 7 && $b == 33)
	{
		echo 40;
	}
	else if ($a == 7 && $b == 34)
	{
		echo 41;
	}
	else if ($a == 7 && $b == 35)
	{
		echo 42;
	}
	else if ($a == 7 && $b == 36)
	{
		echo 43;
	}
	else if ($a == 7 && $b == 37)
	{
		echo 44;
	}
	else if ($a == 7 && $b == 38)
	{
		echo 45;
	}
	else if ($a == 7 && $b == 39)
	{
		echo 46;
	}
	else if ($a == 7 && $b == 40)
	{
		echo 47;
	}
	else if ($a == 7 && $b == 41)
	{
		echo 48;
	}
	else if ($a == 7 && $b == 42)
	{
		echo 49;
	}
	else if ($a == 7 && $b == 43)
	{
		echo 50;
	}
	else if ($a == 7 && $b == 44)
	{
		echo 51;
	}
	else if ($a == 7 && $b == 45)
	{
		echo 52;
	}
	else if ($a == 7 && $b == 46)
	{
		echo 53;
	}
	else if ($a == 7 && $b == 47)
	{
		echo 54;
	}
	else if ($a == 7 && $b == 48)
	{
		echo 55;
	}
	else if ($a == 7 && $b == 49)
	{
		echo 56;
	}
	else if ($a == 7 && $b == 50)
	{
		echo 57;
	}
	else if ($a == 8 && $b == 0)
	{
		echo 8;
	}
	else if ($a == 8 && $b == 1)
	{
		echo 9;
	}
	else if ($a == 8 && $b == 2)
	{
		echo 10;
	}
	else if ($a == 8 && $b == 3)
	{
		echo 11;
	}
	else if ($a == 8 && $b == 4)
	{
		echo 12;
	}
	else if ($a == 8 && $b == 5)
	{
		echo 13;
	}
	else if ($a == 8 && $b == 6)
	{
		echo 14;
	}
	else if ($a == 8 && $b == 7)
	{
		echo 15;
	}
	else if ($a == 8 && $b == 8)
	{
		echo 16;
	}
	else if ($a == 8 && $b == 9)
	{
		echo 17;
	}
	else if ($a == 8 && $b == 10)
	{
		echo 18;
	}
	else if ($a == 8 && $b == 11)
	{
		echo 19;
	}
	else if ($a == 8 && $b == 12)
	{
		echo 20;
	}
	else if ($a == 8 && $b == 13)
	{
		echo 21;
	}
	else if ($a == 8 && $b == 14)
	{
		echo 22;
	}
	else if ($a == 8 && $b == 15)
	{
		echo 23;
	}
	else if ($a == 8 && $b == 16)
	{
		echo 24;
	}
	else if ($a == 8 && $b == 17)
	{
		echo 25;
	}
	else if ($a == 8 && $b == 18)
	{
		echo 26;
	}
	else if ($a == 8 && $b == 19)
	{
		echo 27;
	}
	else if ($a == 8 && $b == 20)
	{
		echo 28;
	}
	else if ($a == 8 && $b == 21)
	{
		echo 29;
	}
	else if ($a == 8 && $b == 22)
	{
		echo 30;
	}
	else if ($a == 8 && $b == 23)
	{
		echo 31;
	}
	else if ($a == 8 && $b == 24)
	{
		echo 32;
	}
	else if ($a == 8 && $b == 25)
	{
		echo 33;
	}
	else if ($a == 8 && $b == 26)
	{
		echo 34;
	}
	else if ($a == 8 && $b == 27)
	{
		echo 35;
	}
	else if ($a == 8 && $b == 28)
	{
		echo 36;
	}
	else if ($a == 8 && $b == 29)
	{
		echo 37;
	}
	else if ($a == 8 && $b == 30)
	{
		echo 38;
	}
	else if ($a == 8 && $b == 31)
	{
		echo 39;
	}
	else if ($a == 8 && $b == 32)
	{
		echo 40;
	}
	else if ($a == 8 && $b == 33)
	{
		echo 41;
	}
	else if ($a == 8 && $b == 34)
	{
		echo 42;
	}
	else if ($a == 8 && $b == 35)
	{
		echo 43;
	}
	else if ($a == 8 && $b == 36)
	{
		echo 44;
	}
	else if ($a == 8 && $b == 37)
	{
		echo 45;
	}
	else if ($a == 8 && $b == 38)
	{
		echo 46;
	}
	else if ($a == 8 && $b == 39)
	{
		echo 47;
	}
	else if ($a == 8 && $b == 40)
	{
		echo 48;
	}
	else if ($a == 8 && $b == 41)
	{
		echo 49;
	}
	else if ($a == 8 && $b == 42)
	{
		echo 50;
	}
	else if ($a == 8 && $b == 43)
	{
		echo 51;
	}
	else if ($a == 8 && $b == 44)
	{
		echo 52;
	}
	else if ($a == 8 && $b == 45)
	{
		echo 53;
	}
	else if ($a == 8 && $b == 46)
	{
		echo 54;
	}
	else if ($a == 8 && $b == 47)
	{
		echo 55;
	}
	else if ($a == 8 && $b == 48)
	{
		echo 56;
	}
	else if ($a == 8 && $b == 49)
	{
		echo 57;
	}
	else if ($a == 8 && $b == 50)
	{
		echo 58;
	}
	else if ($a == 9 && $b == 0)
	{
		echo 9;
	}
	else if ($a == 9 && $b == 1)
	{
		echo 10;
	}
	else if ($a == 9 && $b == 2)
	{
		echo 11;
	}
	else if ($a == 9 && $b == 3)
	{
		echo 12;
	}
	else if ($a == 9 && $b == 4)
	{
		echo 13;
	}
	else if ($a == 9 && $b == 5)
	{
		echo 14;
	}
	else if ($a == 9 && $b == 6)
	{
		echo 15;
	}
	else if ($a == 9 && $b == 7)
	{
		echo 16;
	}
	else if ($a == 9 && $b == 8)
	{
		echo 17;
	}
	else if ($a == 9 && $b == 9)
	{
		echo 18;
	}
	else if ($a == 9 && $b == 10)
	{
		echo 19;
	}
	else if ($a == 9 && $b == 11)
	{
		echo 20;
	}
	else if ($a == 9 && $b == 12)
	{
		echo 21;
	}
	else if ($a == 9 && $b == 13)
	{
		echo 22;
	}
	else if ($a == 9 && $b == 14)
	{
		echo 23;
	}
	else if ($a == 9 && $b == 15)
	{
		echo 24;
	}
	else if ($a == 9 && $b == 16)
	{
		echo 25;
	}
	else if ($a == 9 && $b == 17)
	{
		echo 26;
	}
	else if ($a == 9 && $b == 18)
	{
		echo 27;
	}
	else if ($a == 9 && $b == 19)
	{
		echo 28;
	}
	else if ($a == 9 && $b == 20)
	{
		echo 29;
	}
	else if ($a == 9 && $b == 21)
	{
		echo 30;
	}
	else if ($a == 9 && $b == 22)
	{
		echo 31;
	}
	else if ($a == 9 && $b == 23)
	{
		echo 32;
	}
	else if ($a == 9 && $b == 24)
	{
		echo 33;
	}
	else if ($a == 9 && $b == 25)
	{
		echo 34;
	}
	else if ($a == 9 && $b == 26)
	{
		echo 35;
	}
	else if ($a == 9 && $b == 27)
	{
		echo 36;
	}
	else if ($a == 9 && $b == 28)
	{
		echo 37;
	}
	else if ($a == 9 && $b == 29)
	{
		echo 38;
	}
	else if ($a == 9 && $b == 30)
	{
		echo 39;
	}
	else if ($a == 9 && $b == 31)
	{
		echo 40;
	}
	else if ($a == 9 && $b == 32)
	{
		echo 41;
	}
	else if ($a == 9 && $b == 33)
	{
		echo 42;
	}
	else if ($a == 9 && $b == 34)
	{
		echo 43;
	}
	else if ($a == 9 && $b == 35)
	{
		echo 44;
	}
	else if ($a == 9 && $b == 36)
	{
		echo 45;
	}
	else if ($a == 9 && $b == 37)
	{
		echo 46;
	}
	else if ($a == 9 && $b == 38)
	{
		echo 47;
	}
	else if ($a == 9 && $b == 39)
	{
		echo 48;
	}
	else if ($a == 9 && $b == 40)
	{
		echo 49;
	}
	else if ($a == 9 && $b == 41)
	{
		echo 50;
	}
	else if ($a == 9 && $b == 42)
	{
		echo 51;
	}
	else if ($a == 9 && $b == 43)
	{
		echo 52;
	}
	else if ($a == 9 && $b == 44)
	{
		echo 53;
	}
	else if ($a == 9 && $b == 45)
	{
		echo 54;
	}
	else if ($a == 9 && $b == 46)
	{
		echo 55;
	}
	else if ($a == 9 && $b == 47)
	{
		echo 56;
	}
	else if ($a == 9 && $b == 48)
	{
		echo 57;
	}
	else if ($a == 9 && $b == 49)
	{
		echo 58;
	}
	else if ($a == 9 && $b == 50)
	{
		echo 59;
	}
	else if ($a == 10 && $b == 0)
	{
		echo 10;
	}
	else if ($a == 10 && $b == 1)
	{
		echo 11;
	}
	else if ($a == 10 && $b == 2)
	{
		echo 12;
	}
	else if ($a == 10 && $b == 3)
	{
		echo 13;
	}
	else if ($a == 10 && $b == 4)
	{
		echo 14;
	}
	else if ($a == 10 && $b == 5)
	{
		echo 15;
	}
	else if ($a == 10 && $b == 6)
	{
		echo 16;
	}
	else if ($a == 10 && $b == 7)
	{
		echo 17;
	}
	else if ($a == 10 && $b == 8)
	{
		echo 18;
	}
	else if ($a == 10 && $b == 9)
	{
		echo 19;
	}
	else if ($a == 10 && $b == 10)
	{
		echo 20;
	}
	else if ($a == 10 && $b == 11)
	{
		echo 21;
	}
	else if ($a == 10 && $b == 12)
	{
		echo 22;
	}
	else if ($a == 10 && $b == 13)
	{
		echo 23;
	}
	else if ($a == 10 && $b == 14)
	{
		echo 24;
	}
	else if ($a == 10 && $b == 15)
	{
		echo 25;
	}
	else if ($a == 10 && $b == 16)
	{
		echo 26;
	}
	else if ($a == 10 && $b == 17)
	{
		echo 27;
	}
	else if ($a == 10 && $b == 18)
	{
		echo 28;
	}
	else if ($a == 10 && $b == 19)
	{
		echo 29;
	}
	else if ($a == 10 && $b == 20)
	{
		echo 30;
	}
	else if ($a == 10 && $b == 21)
	{
		echo 31;
	}
	else if ($a == 10 && $b == 22)
	{
		echo 32;
	}
	else if ($a == 10 && $b == 23)
	{
		echo 33;
	}
	else if ($a == 10 && $b == 24)
	{
		echo 34;
	}
	else if ($a == 10 && $b == 25)
	{
		echo 35;
	}
	else if ($a == 10 && $b == 26)
	{
		echo 36;
	}
	else if ($a == 10 && $b == 27)
	{
		echo 37;
	}
	else if ($a == 10 && $b == 28)
	{
		echo 38;
	}
	else if ($a == 10 && $b == 29)
	{
		echo 39;
	}
	else if ($a == 10 && $b == 30)
	{
		echo 40;
	}
	else if ($a == 10 && $b == 31)
	{
		echo 41;
	}
	else if ($a == 10 && $b == 32)
	{
		echo 42;
	}
	else if ($a == 10 && $b == 33)
	{
		echo 43;
	}
	else if ($a == 10 && $b == 34)
	{
		echo 44;
	}
	else if ($a == 10 && $b == 35)
	{
		echo 45;
	}
	else if ($a == 10 && $b == 36)
	{
		echo 46;
	}
	else if ($a == 10 && $b == 37)
	{
		echo 47;
	}
	else if ($a == 10 && $b == 38)
	{
		echo 48;
	}
	else if ($a == 10 && $b == 39)
	{
		echo 49;
	}
	else if ($a == 10 && $b == 40)
	{
		echo 50;
	}
	else if ($a == 10 && $b == 41)
	{
		echo 51;
	}
	else if ($a == 10 && $b == 42)
	{
		echo 52;
	}
	else if ($a == 10 && $b == 43)
	{
		echo 53;
	}
	else if ($a == 10 && $b == 44)
	{
		echo 54;
	}
	else if ($a == 10 && $b == 45)
	{
		echo 55;
	}
	else if ($a == 10 && $b == 46)
	{
		echo 56;
	}
	else if ($a == 10 && $b == 47)
	{
		echo 57;
	}
	else if ($a == 10 && $b == 48)
	{
		echo 58;
	}
	else if ($a == 10 && $b == 49)
	{
		echo 59;
	}
	else if ($a == 10 && $b == 50)
	{
		echo 60;
	}
	else if ($a == 11 && $b == 0)
	{
		echo 11;
	}
	else if ($a == 11 && $b == 1)
	{
		echo 12;
	}
	else if ($a == 11 && $b == 2)
	{
		echo 13;
	}
	else if ($a == 11 && $b == 3)
	{
		echo 14;
	}
	else if ($a == 11 && $b == 4)
	{
		echo 15;
	}
	else if ($a == 11 && $b == 5)
	{
		echo 16;
	}
	else if ($a == 11 && $b == 6)
	{
		echo 17;
	}
	else if ($a == 11 && $b == 7)
	{
		echo 18;
	}
	else if ($a == 11 && $b == 8)
	{
		echo 19;
	}
	else if ($a == 11 && $b == 9)
	{
		echo 20;
	}
	else if ($a == 11 && $b == 10)
	{
		echo 21;
	}
	else if ($a == 11 && $b == 11)
	{
		echo 22;
	}
	else if ($a == 11 && $b == 12)
	{
		echo 23;
	}
	else if ($a == 11 && $b == 13)
	{
		echo 24;
	}
	else if ($a == 11 && $b == 14)
	{
		echo 25;
	}
	else if ($a == 11 && $b == 15)
	{
		echo 26;
	}
	else if ($a == 11 && $b == 16)
	{
		echo 27;
	}
	else if ($a == 11 && $b == 17)
	{
		echo 28;
	}
	else if ($a == 11 && $b == 18)
	{
		echo 29;
	}
	else if ($a == 11 && $b == 19)
	{
		echo 30;
	}
	else if ($a == 11 && $b == 20)
	{
		echo 31;
	}
	else if ($a == 11 && $b == 21)
	{
		echo 32;
	}
	else if ($a == 11 && $b == 22)
	{
		echo 33;
	}
	else if ($a == 11 && $b == 23)
	{
		echo 34;
	}
	else if ($a == 11 && $b == 24)
	{
		echo 35;
	}
	else if ($a == 11 && $b == 25)
	{
		echo 36;
	}
	else if ($a == 11 && $b == 26)
	{
		echo 37;
	}
	else if ($a == 11 && $b == 27)
	{
		echo 38;
	}
	else if ($a == 11 && $b == 28)
	{
		echo 39;
	}
	else if ($a == 11 && $b == 29)
	{
		echo 40;
	}
	else if ($a == 11 && $b == 30)
	{
		echo 41;
	}
	else if ($a == 11 && $b == 31)
	{
		echo 42;
	}
	else if ($a == 11 && $b == 32)
	{
		echo 43;
	}
	else if ($a == 11 && $b == 33)
	{
		echo 44;
	}
	else if ($a == 11 && $b == 34)
	{
		echo 45;
	}
	else if ($a == 11 && $b == 35)
	{
		echo 46;
	}
	else if ($a == 11 && $b == 36)
	{
		echo 47;
	}
	else if ($a == 11 && $b == 37)
	{
		echo 48;
	}
	else if ($a == 11 && $b == 38)
	{
		echo 49;
	}
	else if ($a == 11 && $b == 39)
	{
		echo 50;
	}
	else if ($a == 11 && $b == 40)
	{
		echo 51;
	}
	else if ($a == 11 && $b == 41)
	{
		echo 52;
	}
	else if ($a == 11 && $b == 42)
	{
		echo 53;
	}
	else if ($a == 11 && $b == 43)
	{
		echo 54;
	}
	else if ($a == 11 && $b == 44)
	{
		echo 55;
	}
	else if ($a == 11 && $b == 45)
	{
		echo 56;
	}
	else if ($a == 11 && $b == 46)
	{
		echo 57;
	}
	else if ($a == 11 && $b == 47)
	{
		echo 58;
	}
	else if ($a == 11 && $b == 48)
	{
		echo 59;
	}
	else if ($a == 11 && $b == 49)
	{
		echo 60;
	}
	else if ($a == 11 && $b == 50)
	{
		echo 61;
	}
	else if ($a == 12 && $b == 0)
	{
		echo 12;
	}
	else if ($a == 12 && $b == 1)
	{
		echo 13;
	}
	else if ($a == 12 && $b == 2)
	{
		echo 14;
	}
	else if ($a == 12 && $b == 3)
	{
		echo 15;
	}
	else if ($a == 12 && $b == 4)
	{
		echo 16;
	}
	else if ($a == 12 && $b == 5)
	{
		echo 17;
	}
	else if ($a == 12 && $b == 6)
	{
		echo 18;
	}
	else if ($a == 12 && $b == 7)
	{
		echo 19;
	}
	else if ($a == 12 && $b == 8)
	{
		echo 20;
	}
	else if ($a == 12 && $b == 9)
	{
		echo 21;
	}
	else if ($a == 12 && $b == 10)
	{
		echo 22;
	}
	else if ($a == 12 && $b == 11)
	{
		echo 23;
	}
	else if ($a == 12 && $b == 12)
	{
		echo 24;
	}
	else if ($a == 12 && $b == 13)
	{
		echo 25;
	}
	else if ($a == 12 && $b == 14)
	{
		echo 26;
	}
	else if ($a == 12 && $b == 15)
	{
		echo 27;
	}
	else if ($a == 12 && $b == 16)
	{
		echo 28;
	}
	else if ($a == 12 && $b == 17)
	{
		echo 29;
	}
	else if ($a == 12 && $b == 18)
	{
		echo 30;
	}
	else if ($a == 12 && $b == 19)
	{
		echo 31;
	}
	else if ($a == 12 && $b == 20)
	{
		echo 32;
	}
	else if ($a == 12 && $b == 21)
	{
		echo 33;
	}
	else if ($a == 12 && $b == 22)
	{
		echo 34;
	}
	else if ($a == 12 && $b == 23)
	{
		echo 35;
	}
	else if ($a == 12 && $b == 24)
	{
		echo 36;
	}
	else if ($a == 12 && $b == 25)
	{
		echo 37;
	}
	else if ($a == 12 && $b == 26)
	{
		echo 38;
	}
	else if ($a == 12 && $b == 27)
	{
		echo 39;
	}
	else if ($a == 12 && $b == 28)
	{
		echo 40;
	}
	else if ($a == 12 && $b == 29)
	{
		echo 41;
	}
	else if ($a == 12 && $b == 30)
	{
		echo 42;
	}
	else if ($a == 12 && $b == 31)
	{
		echo 43;
	}
	else if ($a == 12 && $b == 32)
	{
		echo 44;
	}
	else if ($a == 12 && $b == 33)
	{
		echo 45;
	}
	else if ($a == 12 && $b == 34)
	{
		echo 46;
	}
	else if ($a == 12 && $b == 35)
	{
		echo 47;
	}
	else if ($a == 12 && $b == 36)
	{
		echo 48;
	}
	else if ($a == 12 && $b == 37)
	{
		echo 49;
	}
	else if ($a == 12 && $b == 38)
	{
		echo 50;
	}
	else if ($a == 12 && $b == 39)
	{
		echo 51;
	}
	else if ($a == 12 && $b == 40)
	{
		echo 52;
	}
	else if ($a == 12 && $b == 41)
	{
		echo 53;
	}
	else if ($a == 12 && $b == 42)
	{
		echo 54;
	}
	else if ($a == 12 && $b == 43)
	{
		echo 55;
	}
	else if ($a == 12 && $b == 44)
	{
		echo 56;
	}
	else if ($a == 12 && $b == 45)
	{
		echo 57;
	}
	else if ($a == 12 && $b == 46)
	{
		echo 58;
	}
	else if ($a == 12 && $b == 47)
	{
		echo 59;
	}
	else if ($a == 12 && $b == 48)
	{
		echo 60;
	}
	else if ($a == 12 && $b == 49)
	{
		echo 61;
	}
	else if ($a == 12 && $b == 50)
	{
		echo 62;
	}
	else if ($a == 13 && $b == 0)
	{
		echo 13;
	}
	else if ($a == 13 && $b == 1)
	{
		echo 14;
	}
	else if ($a == 13 && $b == 2)
	{
		echo 15;
	}
	else if ($a == 13 && $b == 3)
	{
		echo 16;
	}
	else if ($a == 13 && $b == 4)
	{
		echo 17;
	}
	else if ($a == 13 && $b == 5)
	{
		echo 18;
	}
	else if ($a == 13 && $b == 6)
	{
		echo 19;
	}
	else if ($a == 13 && $b == 7)
	{
		echo 20;
	}
	else if ($a == 13 && $b == 8)
	{
		echo 21;
	}
	else if ($a == 13 && $b == 9)
	{
		echo 22;
	}
	else if ($a == 13 && $b == 10)
	{
		echo 23;
	}
	else if ($a == 13 && $b == 11)
	{
		echo 24;
	}
	else if ($a == 13 && $b == 12)
	{
		echo 25;
	}
	else if ($a == 13 && $b == 13)
	{
		echo 26;
	}
	else if ($a == 13 && $b == 14)
	{
		echo 27;
	}
	else if ($a == 13 && $b == 15)
	{
		echo 28;
	}
	else if ($a == 13 && $b == 16)
	{
		echo 29;
	}
	else if ($a == 13 && $b == 17)
	{
		echo 30;
	}
	else if ($a == 13 && $b == 18)
	{
		echo 31;
	}
	else if ($a == 13 && $b == 19)
	{
		echo 32;
	}
	else if ($a == 13 && $b == 20)
	{
		echo 33;
	}
	else if ($a == 13 && $b == 21)
	{
		echo 34;
	}
	else if ($a == 13 && $b == 22)
	{
		echo 35;
	}
	else if ($a == 13 && $b == 23)
	{
		echo 36;
	}
	else if ($a == 13 && $b == 24)
	{
		echo 37;
	}
	else if ($a == 13 && $b == 25)
	{
		echo 38;
	}
	else if ($a == 13 && $b == 26)
	{
		echo 39;
	}
	else if ($a == 13 && $b == 27)
	{
		echo 40;
	}
	else if ($a == 13 && $b == 28)
	{
		echo 41;
	}
	else if ($a == 13 && $b == 29)
	{
		echo 42;
	}
	else if ($a == 13 && $b == 30)
	{
		echo 43;
	}
	else if ($a == 13 && $b == 31)
	{
		echo 44;
	}
	else if ($a == 13 && $b == 32)
	{
		echo 45;
	}
	else if ($a == 13 && $b == 33)
	{
		echo 46;
	}
	else if ($a == 13 && $b == 34)
	{
		echo 47;
	}
	else if ($a == 13 && $b == 35)
	{
		echo 48;
	}
	else if ($a == 13 && $b == 36)
	{
		echo 49;
	}
	else if ($a == 13 && $b == 37)
	{
		echo 50;
	}
	else if ($a == 13 && $b == 38)
	{
		echo 51;
	}
	else if ($a == 13 && $b == 39)
	{
		echo 52;
	}
	else if ($a == 13 && $b == 40)
	{
		echo 53;
	}
	else if ($a == 13 && $b == 41)
	{
		echo 54;
	}
	else if ($a == 13 && $b == 42)
	{
		echo 55;
	}
	else if ($a == 13 && $b == 43)
	{
		echo 56;
	}
	else if ($a == 13 && $b == 44)
	{
		echo 57;
	}
	else if ($a == 13 && $b == 45)
	{
		echo 58;
	}
	else if ($a == 13 && $b == 46)
	{
		echo 59;
	}
	else if ($a == 13 && $b == 47)
	{
		echo 60;
	}
	else if ($a == 13 && $b == 48)
	{
		echo 61;
	}
	else if ($a == 13 && $b == 49)
	{
		echo 62;
	}
	else if ($a == 13 && $b == 50)
	{
		echo 63;
	}
	else if ($a == 14 && $b == 0)
	{
		echo 14;
	}
	else if ($a == 14 && $b == 1)
	{
		echo 15;
	}
	else if ($a == 14 && $b == 2)
	{
		echo 16;
	}
	else if ($a == 14 && $b == 3)
	{
		echo 17;
	}
	else if ($a == 14 && $b == 4)
	{
		echo 18;
	}
	else if ($a == 14 && $b == 5)
	{
		echo 19;
	}
	else if ($a == 14 && $b == 6)
	{
		echo 20;
	}
	else if ($a == 14 && $b == 7)
	{
		echo 21;
	}
	else if ($a == 14 && $b == 8)
	{
		echo 22;
	}
	else if ($a == 14 && $b == 9)
	{
		echo 23;
	}
	else if ($a == 14 && $b == 10)
	{
		echo 24;
	}
	else if ($a == 14 && $b == 11)
	{
		echo 25;
	}
	else if ($a == 14 && $b == 12)
	{
		echo 26;
	}
	else if ($a == 14 && $b == 13)
	{
		echo 27;
	}
	else if ($a == 14 && $b == 14)
	{
		echo 28;
	}
	else if ($a == 14 && $b == 15)
	{
		echo 29;
	}
	else if ($a == 14 && $b == 16)
	{
		echo 30;
	}
	else if ($a == 14 && $b == 17)
	{
		echo 31;
	}
	else if ($a == 14 && $b == 18)
	{
		echo 32;
	}
	else if ($a == 14 && $b == 19)
	{
		echo 33;
	}
	else if ($a == 14 && $b == 20)
	{
		echo 34;
	}
	else if ($a == 14 && $b == 21)
	{
		echo 35;
	}
	else if ($a == 14 && $b == 22)
	{
		echo 36;
	}
	else if ($a == 14 && $b == 23)
	{
		echo 37;
	}
	else if ($a == 14 && $b == 24)
	{
		echo 38;
	}
	else if ($a == 14 && $b == 25)
	{
		echo 39;
	}
	else if ($a == 14 && $b == 26)
	{
		echo 40;
	}
	else if ($a == 14 && $b == 27)
	{
		echo 41;
	}
	else if ($a == 14 && $b == 28)
	{
		echo 42;
	}
	else if ($a == 14 && $b == 29)
	{
		echo 43;
	}
	else if ($a == 14 && $b == 30)
	{
		echo 44;
	}
	else if ($a == 14 && $b == 31)
	{
		echo 45;
	}
	else if ($a == 14 && $b == 32)
	{
		echo 46;
	}
	else if ($a == 14 && $b == 33)
	{
		echo 47;
	}
	else if ($a == 14 && $b == 34)
	{
		echo 48;
	}
	else if ($a == 14 && $b == 35)
	{
		echo 49;
	}
	else if ($a == 14 && $b == 36)
	{
		echo 50;
	}
	else if ($a == 14 && $b == 37)
	{
		echo 51;
	}
	else if ($a == 14 && $b == 38)
	{
		echo 52;
	}
	else if ($a == 14 && $b == 39)
	{
		echo 53;
	}
	else if ($a == 14 && $b == 40)
	{
		echo 54;
	}
	else if ($a == 14 && $b == 41)
	{
		echo 55;
	}
	else if ($a == 14 && $b == 42)
	{
		echo 56;
	}
	else if ($a == 14 && $b == 43)
	{
		echo 57;
	}
	else if ($a == 14 && $b == 44)
	{
		echo 58;
	}
	else if ($a == 14 && $b == 45)
	{
		echo 59;
	}
	else if ($a == 14 && $b == 46)
	{
		echo 60;
	}
	else if ($a == 14 && $b == 47)
	{
		echo 61;
	}
	else if ($a == 14 && $b == 48)
	{
		echo 62;
	}
	else if ($a == 14 && $b == 49)
	{
		echo 63;
	}
	else if ($a == 14 && $b == 50)
	{
		echo 64;
	}
	else if ($a == 15 && $b == 0)
	{
		echo 15;
	}
	else if ($a == 15 && $b == 1)
	{
		echo 16;
	}
	else if ($a == 15 && $b == 2)
	{
		echo 17;
	}
	else if ($a == 15 && $b == 3)
	{
		echo 18;
	}
	else if ($a == 15 && $b == 4)
	{
		echo 19;
	}
	else if ($a == 15 && $b == 5)
	{
		echo 20;
	}
	else if ($a == 15 && $b == 6)
	{
		echo 21;
	}
	else if ($a == 15 && $b == 7)
	{
		echo 22;
	}
	else if ($a == 15 && $b == 8)
	{
		echo 23;
	}
	else if ($a == 15 && $b == 9)
	{
		echo 24;
	}
	else if ($a == 15 && $b == 10)
	{
		echo 25;
	}
	else if ($a == 15 && $b == 11)
	{
		echo 26;
	}
	else if ($a == 15 && $b == 12)
	{
		echo 27;
	}
	else if ($a == 15 && $b == 13)
	{
		echo 28;
	}
	else if ($a == 15 && $b == 14)
	{
		echo 29;
	}
	else if ($a == 15 && $b == 15)
	{
		echo 30;
	}
	else if ($a == 15 && $b == 16)
	{
		echo 31;
	}
	else if ($a == 15 && $b == 17)
	{
		echo 32;
	}
	else if ($a == 15 && $b == 18)
	{
		echo 33;
	}
	else if ($a == 15 && $b == 19)
	{
		echo 34;
	}
	else if ($a == 15 && $b == 20)
	{
		echo 35;
	}
	else if ($a == 15 && $b == 21)
	{
		echo 36;
	}
	else if ($a == 15 && $b == 22)
	{
		echo 37;
	}
	else if ($a == 15 && $b == 23)
	{
		echo 38;
	}
	else if ($a == 15 && $b == 24)
	{
		echo 39;
	}
	else if ($a == 15 && $b == 25)
	{
		echo 40;
	}
	else if ($a == 15 && $b == 26)
	{
		echo 41;
	}
	else if ($a == 15 && $b == 27)
	{
		echo 42;
	}
	else if ($a == 15 && $b == 28)
	{
		echo 43;
	}
	else if ($a == 15 && $b == 29)
	{
		echo 44;
	}
	else if ($a == 15 && $b == 30)
	{
		echo 45;
	}
	else if ($a == 15 && $b == 31)
	{
		echo 46;
	}
	else if ($a == 15 && $b == 32)
	{
		echo 47;
	}
	else if ($a == 15 && $b == 33)
	{
		echo 48;
	}
	else if ($a == 15 && $b == 34)
	{
		echo 49;
	}
	else if ($a == 15 && $b == 35)
	{
		echo 50;
	}
	else if ($a == 15 && $b == 36)
	{
		echo 51;
	}
	else if ($a == 15 && $b == 37)
	{
		echo 52;
	}
	else if ($a == 15 && $b == 38)
	{
		echo 53;
	}
	else if ($a == 15 && $b == 39)
	{
		echo 54;
	}
	else if ($a == 15 && $b == 40)
	{
		echo 55;
	}
	else if ($a == 15 && $b == 41)
	{
		echo 56;
	}
	else if ($a == 15 && $b == 42)
	{
		echo 57;
	}
	else if ($a == 15 && $b == 43)
	{
		echo 58;
	}
	else if ($a == 15 && $b == 44)
	{
		echo 59;
	}
	else if ($a == 15 && $b == 45)
	{
		echo 60;
	}
	else if ($a == 15 && $b == 46)
	{
		echo 61;
	}
	else if ($a == 15 && $b == 47)
	{
		echo 62;
	}
	else if ($a == 15 && $b == 48)
	{
		echo 63;
	}
	else if ($a == 15 && $b == 49)
	{
		echo 64;
	}
	else if ($a == 15 && $b == 50)
	{
		echo 65;
	}
	else if ($a == 16 && $b == 0)
	{
		echo 16;
	}
	else if ($a == 16 && $b == 1)
	{
		echo 17;
	}
	else if ($a == 16 && $b == 2)
	{
		echo 18;
	}
	else if ($a == 16 && $b == 3)
	{
		echo 19;
	}
	else if ($a == 16 && $b == 4)
	{
		echo 20;
	}
	else if ($a == 16 && $b == 5)
	{
		echo 21;
	}
	else if ($a == 16 && $b == 6)
	{
		echo 22;
	}
	else if ($a == 16 && $b == 7)
	{
		echo 23;
	}
	else if ($a == 16 && $b == 8)
	{
		echo 24;
	}
	else if ($a == 16 && $b == 9)
	{
		echo 25;
	}
	else if ($a == 16 && $b == 10)
	{
		echo 26;
	}
	else if ($a == 16 && $b == 11)
	{
		echo 27;
	}
	else if ($a == 16 && $b == 12)
	{
		echo 28;
	}
	else if ($a == 16 && $b == 13)
	{
		echo 29;
	}
	else if ($a == 16 && $b == 14)
	{
		echo 30;
	}
	else if ($a == 16 && $b == 15)
	{
		echo 31;
	}
	else if ($a == 16 && $b == 16)
	{
		echo 32;
	}
	else if ($a == 16 && $b == 17)
	{
		echo 33;
	}
	else if ($a == 16 && $b == 18)
	{
		echo 34;
	}
	else if ($a == 16 && $b == 19)
	{
		echo 35;
	}
	else if ($a == 16 && $b == 20)
	{
		echo 36;
	}
	else if ($a == 16 && $b == 21)
	{
		echo 37;
	}
	else if ($a == 16 && $b == 22)
	{
		echo 38;
	}
	else if ($a == 16 && $b == 23)
	{
		echo 39;
	}
	else if ($a == 16 && $b == 24)
	{
		echo 40;
	}
	else if ($a == 16 && $b == 25)
	{
		echo 41;
	}
	else if ($a == 16 && $b == 26)
	{
		echo 42;
	}
	else if ($a == 16 && $b == 27)
	{
		echo 43;
	}
	else if ($a == 16 && $b == 28)
	{
		echo 44;
	}
	else if ($a == 16 && $b == 29)
	{
		echo 45;
	}
	else if ($a == 16 && $b == 30)
	{
		echo 46;
	}
	else if ($a == 16 && $b == 31)
	{
		echo 47;
	}
	else if ($a == 16 && $b == 32)
	{
		echo 48;
	}
	else if ($a == 16 && $b == 33)
	{
		echo 49;
	}
	else if ($a == 16 && $b == 34)
	{
		echo 50;
	}
	else if ($a == 16 && $b == 35)
	{
		echo 51;
	}
	else if ($a == 16 && $b == 36)
	{
		echo 52;
	}
	else if ($a == 16 && $b == 37)
	{
		echo 53;
	}
	else if ($a == 16 && $b == 38)
	{
		echo 54;
	}
	else if ($a == 16 && $b == 39)
	{
		echo 55;
	}
	else if ($a == 16 && $b == 40)
	{
		echo 56;
	}
	else if ($a == 16 && $b == 41)
	{
		echo 57;
	}
	else if ($a == 16 && $b == 42)
	{
		echo 58;
	}
	else if ($a == 16 && $b == 43)
	{
		echo 59;
	}
	else if ($a == 16 && $b == 44)
	{
		echo 60;
	}
	else if ($a == 16 && $b == 45)
	{
		echo 61;
	}
	else if ($a == 16 && $b == 46)
	{
		echo 62;
	}
	else if ($a == 16 && $b == 47)
	{
		echo 63;
	}
	else if ($a == 16 && $b == 48)
	{
		echo 64;
	}
	else if ($a == 16 && $b == 49)
	{
		echo 65;
	}
	else if ($a == 16 && $b == 50)
	{
		echo 66;
	}
	else if ($a == 17 && $b == 0)
	{
		echo 17;
	}
	else if ($a == 17 && $b == 1)
	{
		echo 18;
	}
	else if ($a == 17 && $b == 2)
	{
		echo 19;
	}
	else if ($a == 17 && $b == 3)
	{
		echo 20;
	}
	else if ($a == 17 && $b == 4)
	{
		echo 21;
	}
	else if ($a == 17 && $b == 5)
	{
		echo 22;
	}
	else if ($a == 17 && $b == 6)
	{
		echo 23;
	}
	else if ($a == 17 && $b == 7)
	{
		echo 24;
	}
	else if ($a == 17 && $b == 8)
	{
		echo 25;
	}
	else if ($a == 17 && $b == 9)
	{
		echo 26;
	}
	else if ($a == 17 && $b == 10)
	{
		echo 27;
	}
	else if ($a == 17 && $b == 11)
	{
		echo 28;
	}
	else if ($a == 17 && $b == 12)
	{
		echo 29;
	}
	else if ($a == 17 && $b == 13)
	{
		echo 30;
	}
	else if ($a == 17 && $b == 14)
	{
		echo 31;
	}
	else if ($a == 17 && $b == 15)
	{
		echo 32;
	}
	else if ($a == 17 && $b == 16)
	{
		echo 33;
	}
	else if ($a == 17 && $b == 17)
	{
		echo 34;
	}
	else if ($a == 17 && $b == 18)
	{
		echo 35;
	}
	else if ($a == 17 && $b == 19)
	{
		echo 36;
	}
	else if ($a == 17 && $b == 20)
	{
		echo 37;
	}
	else if ($a == 17 && $b == 21)
	{
		echo 38;
	}
	else if ($a == 17 && $b == 22)
	{
		echo 39;
	}
	else if ($a == 17 && $b == 23)
	{
		echo 40;
	}
	else if ($a == 17 && $b == 24)
	{
		echo 41;
	}
	else if ($a == 17 && $b == 25)
	{
		echo 42;
	}
	else if ($a == 17 && $b == 26)
	{
		echo 43;
	}
	else if ($a == 17 && $b == 27)
	{
		echo 44;
	}
	else if ($a == 17 && $b == 28)
	{
		echo 45;
	}
	else if ($a == 17 && $b == 29)
	{
		echo 46;
	}
	else if ($a == 17 && $b == 30)
	{
		echo 47;
	}
	else if ($a == 17 && $b == 31)
	{
		echo 48;
	}
	else if ($a == 17 && $b == 32)
	{
		echo 49;
	}
	else if ($a == 17 && $b == 33)
	{
		echo 50;
	}
	else if ($a == 17 && $b == 34)
	{
		echo 51;
	}
	else if ($a == 17 && $b == 35)
	{
		echo 52;
	}
	else if ($a == 17 && $b == 36)
	{
		echo 53;
	}
	else if ($a == 17 && $b == 37)
	{
		echo 54;
	}
	else if ($a == 17 && $b == 38)
	{
		echo 55;
	}
	else if ($a == 17 && $b == 39)
	{
		echo 56;
	}
	else if ($a == 17 && $b == 40)
	{
		echo 57;
	}
	else if ($a == 17 && $b == 41)
	{
		echo 58;
	}
	else if ($a == 17 && $b == 42)
	{
		echo 59;
	}
	else if ($a == 17 && $b == 43)
	{
		echo 60;
	}
	else if ($a == 17 && $b == 44)
	{
		echo 61;
	}
	else if ($a == 17 && $b == 45)
	{
		echo 62;
	}
	else if ($a == 17 && $b == 46)
	{
		echo 63;
	}
	else if ($a == 17 && $b == 47)
	{
		echo 64;
	}
	else if ($a == 17 && $b == 48)
	{
		echo 65;
	}
	else if ($a == 17 && $b == 49)
	{
		echo 66;
	}
	else if ($a == 17 && $b == 50)
	{
		echo 67;
	}
	else if ($a == 18 && $b == 0)
	{
		echo 18;
	}
	else if ($a == 18 && $b == 1)
	{
		echo 19;
	}
	else if ($a == 18 && $b == 2)
	{
		echo 20;
	}
	else if ($a == 18 && $b == 3)
	{
		echo 21;
	}
	else if ($a == 18 && $b == 4)
	{
		echo 22;
	}
	else if ($a == 18 && $b == 5)
	{
		echo 23;
	}
	else if ($a == 18 && $b == 6)
	{
		echo 24;
	}
	else if ($a == 18 && $b == 7)
	{
		echo 25;
	}
	else if ($a == 18 && $b == 8)
	{
		echo 26;
	}
	else if ($a == 18 && $b == 9)
	{
		echo 27;
	}
	else if ($a == 18 && $b == 10)
	{
		echo 28;
	}
	else if ($a == 18 && $b == 11)
	{
		echo 29;
	}
	else if ($a == 18 && $b == 12)
	{
		echo 30;
	}
	else if ($a == 18 && $b == 13)
	{
		echo 31;
	}
	else if ($a == 18 && $b == 14)
	{
		echo 32;
	}
	else if ($a == 18 && $b == 15)
	{
		echo 33;
	}
	else if ($a == 18 && $b == 16)
	{
		echo 34;
	}
	else if ($a == 18 && $b == 17)
	{
		echo 35;
	}
	else if ($a == 18 && $b == 18)
	{
		echo 36;
	}
	else if ($a == 18 && $b == 19)
	{
		echo 37;
	}
	else if ($a == 18 && $b == 20)
	{
		echo 38;
	}
	else if ($a == 18 && $b == 21)
	{
		echo 39;
	}
	else if ($a == 18 && $b == 22)
	{
		echo 40;
	}
	else if ($a == 18 && $b == 23)
	{
		echo 41;
	}
	else if ($a == 18 && $b == 24)
	{
		echo 42;
	}
	else if ($a == 18 && $b == 25)
	{
		echo 43;
	}
	else if ($a == 18 && $b == 26)
	{
		echo 44;
	}
	else if ($a == 18 && $b == 27)
	{
		echo 45;
	}
	else if ($a == 18 && $b == 28)
	{
		echo 46;
	}
	else if ($a == 18 && $b == 29)
	{
		echo 47;
	}
	else if ($a == 18 && $b == 30)
	{
		echo 48;
	}
	else if ($a == 18 && $b == 31)
	{
		echo 49;
	}
	else if ($a == 18 && $b == 32)
	{
		echo 50;
	}
	else if ($a == 18 && $b == 33)
	{
		echo 51;
	}
	else if ($a == 18 && $b == 34)
	{
		echo 52;
	}
	else if ($a == 18 && $b == 35)
	{
		echo 53;
	}
	else if ($a == 18 && $b == 36)
	{
		echo 54;
	}
	else if ($a == 18 && $b == 37)
	{
		echo 55;
	}
	else if ($a == 18 && $b == 38)
	{
		echo 56;
	}
	else if ($a == 18 && $b == 39)
	{
		echo 57;
	}
	else if ($a == 18 && $b == 40)
	{
		echo 58;
	}
	else if ($a == 18 && $b == 41)
	{
		echo 59;
	}
	else if ($a == 18 && $b == 42)
	{
		echo 60;
	}
	else if ($a == 18 && $b == 43)
	{
		echo 61;
	}
	else if ($a == 18 && $b == 44)
	{
		echo 62;
	}
	else if ($a == 18 && $b == 45)
	{
		echo 63;
	}
	else if ($a == 18 && $b == 46)
	{
		echo 64;
	}
	else if ($a == 18 && $b == 47)
	{
		echo 65;
	}
	else if ($a == 18 && $b == 48)
	{
		echo 66;
	}
	else if ($a == 18 && $b == 49)
	{
		echo 67;
	}
	else if ($a == 18 && $b == 50)
	{
		echo 68;
	}
	else if ($a == 19 && $b == 0)
	{
		echo 19;
	}
	else if ($a == 19 && $b == 1)
	{
		echo 20;
	}
	else if ($a == 19 && $b == 2)
	{
		echo 21;
	}
	else if ($a == 19 && $b == 3)
	{
		echo 22;
	}
	else if ($a == 19 && $b == 4)
	{
		echo 23;
	}
	else if ($a == 19 && $b == 5)
	{
		echo 24;
	}
	else if ($a == 19 && $b == 6)
	{
		echo 25;
	}
	else if ($a == 19 && $b == 7)
	{
		echo 26;
	}
	else if ($a == 19 && $b == 8)
	{
		echo 27;
	}
	else if ($a == 19 && $b == 9)
	{
		echo 28;
	}
	else if ($a == 19 && $b == 10)
	{
		echo 29;
	}
	else if ($a == 19 && $b == 11)
	{
		echo 30;
	}
	else if ($a == 19 && $b == 12)
	{
		echo 31;
	}
	else if ($a == 19 && $b == 13)
	{
		echo 32;
	}
	else if ($a == 19 && $b == 14)
	{
		echo 33;
	}
	else if ($a == 19 && $b == 15)
	{
		echo 34;
	}
	else if ($a == 19 && $b == 16)
	{
		echo 35;
	}
	else if ($a == 19 && $b == 17)
	{
		echo 36;
	}
	else if ($a == 19 && $b == 18)
	{
		echo 37;
	}
	else if ($a == 19 && $b == 19)
	{
		echo 38;
	}
	else if ($a == 19 && $b == 20)
	{
		echo 39;
	}
	else if ($a == 19 && $b == 21)
	{
		echo 40;
	}
	else if ($a == 19 && $b == 22)
	{
		echo 41;
	}
	else if ($a == 19 && $b == 23)
	{
		echo 42;
	}
	else if ($a == 19 && $b == 24)
	{
		echo 43;
	}
	else if ($a == 19 && $b == 25)
	{
		echo 44;
	}
	else if ($a == 19 && $b == 26)
	{
		echo 45;
	}
	else if ($a == 19 && $b == 27)
	{
		echo 46;
	}
	else if ($a == 19 && $b == 28)
	{
		echo 47;
	}
	else if ($a == 19 && $b == 29)
	{
		echo 48;
	}
	else if ($a == 19 && $b == 30)
	{
		echo 49;
	}
	else if ($a == 19 && $b == 31)
	{
		echo 50;
	}
	else if ($a == 19 && $b == 32)
	{
		echo 51;
	}
	else if ($a == 19 && $b == 33)
	{
		echo 52;
	}
	else if ($a == 19 && $b == 34)
	{
		echo 53;
	}
	else if ($a == 19 && $b == 35)
	{
		echo 54;
	}
	else if ($a == 19 && $b == 36)
	{
		echo 55;
	}
	else if ($a == 19 && $b == 37)
	{
		echo 56;
	}
	else if ($a == 19 && $b == 38)
	{
		echo 57;
	}
	else if ($a == 19 && $b == 39)
	{
		echo 58;
	}
	else if ($a == 19 && $b == 40)
	{
		echo 59;
	}
	else if ($a == 19 && $b == 41)
	{
		echo 60;
	}
	else if ($a == 19 && $b == 42)
	{
		echo 61;
	}
	else if ($a == 19 && $b == 43)
	{
		echo 62;
	}
	else if ($a == 19 && $b == 44)
	{
		echo 63;
	}
	else if ($a == 19 && $b == 45)
	{
		echo 64;
	}
	else if ($a == 19 && $b == 46)
	{
		echo 65;
	}
	else if ($a == 19 && $b == 47)
	{
		echo 66;
	}
	else if ($a == 19 && $b == 48)
	{
		echo 67;
	}
	else if ($a == 19 && $b == 49)
	{
		echo 68;
	}
	else if ($a == 19 && $b == 50)
	{
		echo 69;
	}
	else if ($a == 20 && $b == 0)
	{
		echo 20;
	}
	else if ($a == 20 && $b == 1)
	{
		echo 21;
	}
	else if ($a == 20 && $b == 2)
	{
		echo 22;
	}
	else if ($a == 20 && $b == 3)
	{
		echo 23;
	}
	else if ($a == 20 && $b == 4)
	{
		echo 24;
	}
	else if ($a == 20 && $b == 5)
	{
		echo 25;
	}
	else if ($a == 20 && $b == 6)
	{
		echo 26;
	}
	else if ($a == 20 && $b == 7)
	{
		echo 27;
	}
	else if ($a == 20 && $b == 8)
	{
		echo 28;
	}
	else if ($a == 20 && $b == 9)
	{
		echo 29;
	}
	else if ($a == 20 && $b == 10)
	{
		echo 30;
	}
	else if ($a == 20 && $b == 11)
	{
		echo 31;
	}
	else if ($a == 20 && $b == 12)
	{
		echo 32;
	}
	else if ($a == 20 && $b == 13)
	{
		echo 33;
	}
	else if ($a == 20 && $b == 14)
	{
		echo 34;
	}
	else if ($a == 20 && $b == 15)
	{
		echo 35;
	}
	else if ($a == 20 && $b == 16)
	{
		echo 36;
	}
	else if ($a == 20 && $b == 17)
	{
		echo 37;
	}
	else if ($a == 20 && $b == 18)
	{
		echo 38;
	}
	else if ($a == 20 && $b == 19)
	{
		echo 39;
	}
	else if ($a == 20 && $b == 20)
	{
		echo 40;
	}
	else if ($a == 20 && $b == 21)
	{
		echo 41;
	}
	else if ($a == 20 && $b == 22)
	{
		echo 42;
	}
	else if ($a == 20 && $b == 23)
	{
		echo 43;
	}
	else if ($a == 20 && $b == 24)
	{
		echo 44;
	}
	else if ($a == 20 && $b == 25)
	{
		echo 45;
	}
	else if ($a == 20 && $b == 26)
	{
		echo 46;
	}
	else if ($a == 20 && $b == 27)
	{
		echo 47;
	}
	else if ($a == 20 && $b == 28)
	{
		echo 48;
	}
	else if ($a == 20 && $b == 29)
	{
		echo 49;
	}
	else if ($a == 20 && $b == 30)
	{
		echo 50;
	}
	else if ($a == 20 && $b == 31)
	{
		echo 51;
	}
	else if ($a == 20 && $b == 32)
	{
		echo 52;
	}
	else if ($a == 20 && $b == 33)
	{
		echo 53;
	}
	else if ($a == 20 && $b == 34)
	{
		echo 54;
	}
	else if ($a == 20 && $b == 35)
	{
		echo 55;
	}
	else if ($a == 20 && $b == 36)
	{
		echo 56;
	}
	else if ($a == 20 && $b == 37)
	{
		echo 57;
	}
	else if ($a == 20 && $b == 38)
	{
		echo 58;
	}
	else if ($a == 20 && $b == 39)
	{
		echo 59;
	}
	else if ($a == 20 && $b == 40)
	{
		echo 60;
	}
	else if ($a == 20 && $b == 41)
	{
		echo 61;
	}
	else if ($a == 20 && $b == 42)
	{
		echo 62;
	}
	else if ($a == 20 && $b == 43)
	{
		echo 63;
	}
	else if ($a == 20 && $b == 44)
	{
		echo 64;
	}
	else if ($a == 20 && $b == 45)
	{
		echo 65;
	}
	else if ($a == 20 && $b == 46)
	{
		echo 66;
	}
	else if ($a == 20 && $b == 47)
	{
		echo 67;
	}
	else if ($a == 20 && $b == 48)
	{
		echo 68;
	}
	else if ($a == 20 && $b == 49)
	{
		echo 69;
	}
	else if ($a == 20 && $b == 50)
	{
		echo 70;
	}
	else if ($a == 21 && $b == 0)
	{
		echo 21;
	}
	else if ($a == 21 && $b == 1)
	{
		echo 22;
	}
	else if ($a == 21 && $b == 2)
	{
		echo 23;
	}
	else if ($a == 21 && $b == 3)
	{
		echo 24;
	}
	else if ($a == 21 && $b == 4)
	{
		echo 25;
	}
	else if ($a == 21 && $b == 5)
	{
		echo 26;
	}
	else if ($a == 21 && $b == 6)
	{
		echo 27;
	}
	else if ($a == 21 && $b == 7)
	{
		echo 28;
	}
	else if ($a == 21 && $b == 8)
	{
		echo 29;
	}
	else if ($a == 21 && $b == 9)
	{
		echo 30;
	}
	else if ($a == 21 && $b == 10)
	{
		echo 31;
	}
	else if ($a == 21 && $b == 11)
	{
		echo 32;
	}
	else if ($a == 21 && $b == 12)
	{
		echo 33;
	}
	else if ($a == 21 && $b == 13)
	{
		echo 34;
	}
	else if ($a == 21 && $b == 14)
	{
		echo 35;
	}
	else if ($a == 21 && $b == 15)
	{
		echo 36;
	}
	else if ($a == 21 && $b == 16)
	{
		echo 37;
	}
	else if ($a == 21 && $b == 17)
	{
		echo 38;
	}
	else if ($a == 21 && $b == 18)
	{
		echo 39;
	}
	else if ($a == 21 && $b == 19)
	{
		echo 40;
	}
	else if ($a == 21 && $b == 20)
	{
		echo 41;
	}
	else if ($a == 21 && $b == 21)
	{
		echo 42;
	}
	else if ($a == 21 && $b == 22)
	{
		echo 43;
	}
	else if ($a == 21 && $b == 23)
	{
		echo 44;
	}
	else if ($a == 21 && $b == 24)
	{
		echo 45;
	}
	else if ($a == 21 && $b == 25)
	{
		echo 46;
	}
	else if ($a == 21 && $b == 26)
	{
		echo 47;
	}
	else if ($a == 21 && $b == 27)
	{
		echo 48;
	}
	else if ($a == 21 && $b == 28)
	{
		echo 49;
	}
	else if ($a == 21 && $b == 29)
	{
		echo 50;
	}
	else if ($a == 21 && $b == 30)
	{
		echo 51;
	}
	else if ($a == 21 && $b == 31)
	{
		echo 52;
	}
	else if ($a == 21 && $b == 32)
	{
		echo 53;
	}
	else if ($a == 21 && $b == 33)
	{
		echo 54;
	}
	else if ($a == 21 && $b == 34)
	{
		echo 55;
	}
	else if ($a == 21 && $b == 35)
	{
		echo 56;
	}
	else if ($a == 21 && $b == 36)
	{
		echo 57;
	}
	else if ($a == 21 && $b == 37)
	{
		echo 58;
	}
	else if ($a == 21 && $b == 38)
	{
		echo 59;
	}
	else if ($a == 21 && $b == 39)
	{
		echo 60;
	}
	else if ($a == 21 && $b == 40)
	{
		echo 61;
	}
	else if ($a == 21 && $b == 41)
	{
		echo 62;
	}
	else if ($a == 21 && $b == 42)
	{
		echo 63;
	}
	else if ($a == 21 && $b == 43)
	{
		echo 64;
	}
	else if ($a == 21 && $b == 44)
	{
		echo 65;
	}
	else if ($a == 21 && $b == 45)
	{
		echo 66;
	}
	else if ($a == 21 && $b == 46)
	{
		echo 67;
	}
	else if ($a == 21 && $b == 47)
	{
		echo 68;
	}
	else if ($a == 21 && $b == 48)
	{
		echo 69;
	}
	else if ($a == 21 && $b == 49)
	{
		echo 70;
	}
	else if ($a == 21 && $b == 50)
	{
		echo 71;
	}
	else if ($a == 22 && $b == 0)
	{
		echo 22;
	}
	else if ($a == 22 && $b == 1)
	{
		echo 23;
	}
	else if ($a == 22 && $b == 2)
	{
		echo 24;
	}
	else if ($a == 22 && $b == 3)
	{
		echo 25;
	}
	else if ($a == 22 && $b == 4)
	{
		echo 26;
	}
	else if ($a == 22 && $b == 5)
	{
		echo 27;
	}
	else if ($a == 22 && $b == 6)
	{
		echo 28;
	}
	else if ($a == 22 && $b == 7)
	{
		echo 29;
	}
	else if ($a == 22 && $b == 8)
	{
		echo 30;
	}
	else if ($a == 22 && $b == 9)
	{
		echo 31;
	}
	else if ($a == 22 && $b == 10)
	{
		echo 32;
	}
	else if ($a == 22 && $b == 11)
	{
		echo 33;
	}
	else if ($a == 22 && $b == 12)
	{
		echo 34;
	}
	else if ($a == 22 && $b == 13)
	{
		echo 35;
	}
	else if ($a == 22 && $b == 14)
	{
		echo 36;
	}
	else if ($a == 22 && $b == 15)
	{
		echo 37;
	}
	else if ($a == 22 && $b == 16)
	{
		echo 38;
	}
	else if ($a == 22 && $b == 17)
	{
		echo 39;
	}
	else if ($a == 22 && $b == 18)
	{
		echo 40;
	}
	else if ($a == 22 && $b == 19)
	{
		echo 41;
	}
	else if ($a == 22 && $b == 20)
	{
		echo 42;
	}
	else if ($a == 22 && $b == 21)
	{
		echo 43;
	}
	else if ($a == 22 && $b == 22)
	{
		echo 44;
	}
	else if ($a == 22 && $b == 23)
	{
		echo 45;
	}
	else if ($a == 22 && $b == 24)
	{
		echo 46;
	}
	else if ($a == 22 && $b == 25)
	{
		echo 47;
	}
	else if ($a == 22 && $b == 26)
	{
		echo 48;
	}
	else if ($a == 22 && $b == 27)
	{
		echo 49;
	}
	else if ($a == 22 && $b == 28)
	{
		echo 50;
	}
	else if ($a == 22 && $b == 29)
	{
		echo 51;
	}
	else if ($a == 22 && $b == 30)
	{
		echo 52;
	}
	else if ($a == 22 && $b == 31)
	{
		echo 53;
	}
	else if ($a == 22 && $b == 32)
	{
		echo 54;
	}
	else if ($a == 22 && $b == 33)
	{
		echo 55;
	}
	else if ($a == 22 && $b == 34)
	{
		echo 56;
	}
	else if ($a == 22 && $b == 35)
	{
		echo 57;
	}
	else if ($a == 22 && $b == 36)
	{
		echo 58;
	}
	else if ($a == 22 && $b == 37)
	{
		echo 59;
	}
	else if ($a == 22 && $b == 38)
	{
		echo 60;
	}
	else if ($a == 22 && $b == 39)
	{
		echo 61;
	}
	else if ($a == 22 && $b == 40)
	{
		echo 62;
	}
	else if ($a == 22 && $b == 41)
	{
		echo 63;
	}
	else if ($a == 22 && $b == 42)
	{
		echo 64;
	}
	else if ($a == 22 && $b == 43)
	{
		echo 65;
	}
	else if ($a == 22 && $b == 44)
	{
		echo 66;
	}
	else if ($a == 22 && $b == 45)
	{
		echo 67;
	}
	else if ($a == 22 && $b == 46)
	{
		echo 68;
	}
	else if ($a == 22 && $b == 47)
	{
		echo 69;
	}
	else if ($a == 22 && $b == 48)
	{
		echo 70;
	}
	else if ($a == 22 && $b == 49)
	{
		echo 71;
	}
	else if ($a == 22 && $b == 50)
	{
		echo 72;
	}
	else if ($a == 23 && $b == 0)
	{
		echo 23;
	}
	else if ($a == 23 && $b == 1)
	{
		echo 24;
	}
	else if ($a == 23 && $b == 2)
	{
		echo 25;
	}
	else if ($a == 23 && $b == 3)
	{
		echo 26;
	}
	else if ($a == 23 && $b == 4)
	{
		echo 27;
	}
	else if ($a == 23 && $b == 5)
	{
		echo 28;
	}
	else if ($a == 23 && $b == 6)
	{
		echo 29;
	}
	else if ($a == 23 && $b == 7)
	{
		echo 30;
	}
	else if ($a == 23 && $b == 8)
	{
		echo 31;
	}
	else if ($a == 23 && $b == 9)
	{
		echo 32;
	}
	else if ($a == 23 && $b == 10)
	{
		echo 33;
	}
	else if ($a == 23 && $b == 11)
	{
		echo 34;
	}
	else if ($a == 23 && $b == 12)
	{
		echo 35;
	}
	else if ($a == 23 && $b == 13)
	{
		echo 36;
	}
	else if ($a == 23 && $b == 14)
	{
		echo 37;
	}
	else if ($a == 23 && $b == 15)
	{
		echo 38;
	}
	else if ($a == 23 && $b == 16)
	{
		echo 39;
	}
	else if ($a == 23 && $b == 17)
	{
		echo 40;
	}
	else if ($a == 23 && $b == 18)
	{
		echo 41;
	}
	else if ($a == 23 && $b == 19)
	{
		echo 42;
	}
	else if ($a == 23 && $b == 20)
	{
		echo 43;
	}
	else if ($a == 23 && $b == 21)
	{
		echo 44;
	}
	else if ($a == 23 && $b == 22)
	{
		echo 45;
	}
	else if ($a == 23 && $b == 23)
	{
		echo 46;
	}
	else if ($a == 23 && $b == 24)
	{
		echo 47;
	}
	else if ($a == 23 && $b == 25)
	{
		echo 48;
	}
	else if ($a == 23 && $b == 26)
	{
		echo 49;
	}
	else if ($a == 23 && $b == 27)
	{
		echo 50;
	}
	else if ($a == 23 && $b == 28)
	{
		echo 51;
	}
	else if ($a == 23 && $b == 29)
	{
		echo 52;
	}
	else if ($a == 23 && $b == 30)
	{
		echo 53;
	}
	else if ($a == 23 && $b == 31)
	{
		echo 54;
	}
	else if ($a == 23 && $b == 32)
	{
		echo 55;
	}
	else if ($a == 23 && $b == 33)
	{
		echo 56;
	}
	else if ($a == 23 && $b == 34)
	{
		echo 57;
	}
	else if ($a == 23 && $b == 35)
	{
		echo 58;
	}
	else if ($a == 23 && $b == 36)
	{
		echo 59;
	}
	else if ($a == 23 && $b == 37)
	{
		echo 60;
	}
	else if ($a == 23 && $b == 38)
	{
		echo 61;
	}
	else if ($a == 23 && $b == 39)
	{
		echo 62;
	}
	else if ($a == 23 && $b == 40)
	{
		echo 63;
	}
	else if ($a == 23 && $b == 41)
	{
		echo 64;
	}
	else if ($a == 23 && $b == 42)
	{
		echo 65;
	}
	else if ($a == 23 && $b == 43)
	{
		echo 66;
	}
	else if ($a == 23 && $b == 44)
	{
		echo 67;
	}
	else if ($a == 23 && $b == 45)
	{
		echo 68;
	}
	else if ($a == 23 && $b == 46)
	{
		echo 69;
	}
	else if ($a == 23 && $b == 47)
	{
		echo 70;
	}
	else if ($a == 23 && $b == 48)
	{
		echo 71;
	}
	else if ($a == 23 && $b == 49)
	{
		echo 72;
	}
	else if ($a == 23 && $b == 50)
	{
		echo 73;
	}
	else if ($a == 24 && $b == 0)
	{
		echo 24;
	}
	else if ($a == 24 && $b == 1)
	{
		echo 25;
	}
	else if ($a == 24 && $b == 2)
	{
		echo 26;
	}
	else if ($a == 24 && $b == 3)
	{
		echo 27;
	}
	else if ($a == 24 && $b == 4)
	{
		echo 28;
	}
	else if ($a == 24 && $b == 5)
	{
		echo 29;
	}
	else if ($a == 24 && $b == 6)
	{
		echo 30;
	}
	else if ($a == 24 && $b == 7)
	{
		echo 31;
	}
	else if ($a == 24 && $b == 8)
	{
		echo 32;
	}
	else if ($a == 24 && $b == 9)
	{
		echo 33;
	}
	else if ($a == 24 && $b == 10)
	{
		echo 34;
	}
	else if ($a == 24 && $b == 11)
	{
		echo 35;
	}
	else if ($a == 24 && $b == 12)
	{
		echo 36;
	}
	else if ($a == 24 && $b == 13)
	{
		echo 37;
	}
	else if ($a == 24 && $b == 14)
	{
		echo 38;
	}
	else if ($a == 24 && $b == 15)
	{
		echo 39;
	}
	else if ($a == 24 && $b == 16)
	{
		echo 40;
	}
	else if ($a == 24 && $b == 17)
	{
		echo 41;
	}
	else if ($a == 24 && $b == 18)
	{
		echo 42;
	}
	else if ($a == 24 && $b == 19)
	{
		echo 43;
	}
	else if ($a == 24 && $b == 20)
	{
		echo 44;
	}
	else if ($a == 24 && $b == 21)
	{
		echo 45;
	}
	else if ($a == 24 && $b == 22)
	{
		echo 46;
	}
	else if ($a == 24 && $b == 23)
	{
		echo 47;
	}
	else if ($a == 24 && $b == 24)
	{
		echo 48;
	}
	else if ($a == 24 && $b == 25)
	{
		echo 49;
	}
	else if ($a == 24 && $b == 26)
	{
		echo 50;
	}
	else if ($a == 24 && $b == 27)
	{
		echo 51;
	}
	else if ($a == 24 && $b == 28)
	{
		echo 52;
	}
	else if ($a == 24 && $b == 29)
	{
		echo 53;
	}
	else if ($a == 24 && $b == 30)
	{
		echo 54;
	}
	else if ($a == 24 && $b == 31)
	{
		echo 55;
	}
	else if ($a == 24 && $b == 32)
	{
		echo 56;
	}
	else if ($a == 24 && $b == 33)
	{
		echo 57;
	}
	else if ($a == 24 && $b == 34)
	{
		echo 58;
	}
	else if ($a == 24 && $b == 35)
	{
		echo 59;
	}
	else if ($a == 24 && $b == 36)
	{
		echo 60;
	}
	else if ($a == 24 && $b == 37)
	{
		echo 61;
	}
	else if ($a == 24 && $b == 38)
	{
		echo 62;
	}
	else if ($a == 24 && $b == 39)
	{
		echo 63;
	}
	else if ($a == 24 && $b == 40)
	{
		echo 64;
	}
	else if ($a == 24 && $b == 41)
	{
		echo 65;
	}
	else if ($a == 24 && $b == 42)
	{
		echo 66;
	}
	else if ($a == 24 && $b == 43)
	{
		echo 67;
	}
	else if ($a == 24 && $b == 44)
	{
		echo 68;
	}
	else if ($a == 24 && $b == 45)
	{
		echo 69;
	}
	else if ($a == 24 && $b == 46)
	{
		echo 70;
	}
	else if ($a == 24 && $b == 47)
	{
		echo 71;
	}
	else if ($a == 24 && $b == 48)
	{
		echo 72;
	}
	else if ($a == 24 && $b == 49)
	{
		echo 73;
	}
	else if ($a == 24 && $b == 50)
	{
		echo 74;
	}
	else if ($a == 25 && $b == 0)
	{
		echo 25;
	}
	else if ($a == 25 && $b == 1)
	{
		echo 26;
	}
	else if ($a == 25 && $b == 2)
	{
		echo 27;
	}
	else if ($a == 25 && $b == 3)
	{
		echo 28;
	}
	else if ($a == 25 && $b == 4)
	{
		echo 29;
	}
	else if ($a == 25 && $b == 5)
	{
		echo 30;
	}
	else if ($a == 25 && $b == 6)
	{
		echo 31;
	}
	else if ($a == 25 && $b == 7)
	{
		echo 32;
	}
	else if ($a == 25 && $b == 8)
	{
		echo 33;
	}
	else if ($a == 25 && $b == 9)
	{
		echo 34;
	}
	else if ($a == 25 && $b == 10)
	{
		echo 35;
	}
	else if ($a == 25 && $b == 11)
	{
		echo 36;
	}
	else if ($a == 25 && $b == 12)
	{
		echo 37;
	}
	else if ($a == 25 && $b == 13)
	{
		echo 38;
	}
	else if ($a == 25 && $b == 14)
	{
		echo 39;
	}
	else if ($a == 25 && $b == 15)
	{
		echo 40;
	}
	else if ($a == 25 && $b == 16)
	{
		echo 41;
	}
	else if ($a == 25 && $b == 17)
	{
		echo 42;
	}
	else if ($a == 25 && $b == 18)
	{
		echo 43;
	}
	else if ($a == 25 && $b == 19)
	{
		echo 44;
	}
	else if ($a == 25 && $b == 20)
	{
		echo 45;
	}
	else if ($a == 25 && $b == 21)
	{
		echo 46;
	}
	else if ($a == 25 && $b == 22)
	{
		echo 47;
	}
	else if ($a == 25 && $b == 23)
	{
		echo 48;
	}
	else if ($a == 25 && $b == 24)
	{
		echo 49;
	}
	else if ($a == 25 && $b == 25)
	{
		echo 50;
	}
	else if ($a == 25 && $b == 26)
	{
		echo 51;
	}
	else if ($a == 25 && $b == 27)
	{
		echo 52;
	}
	else if ($a == 25 && $b == 28)
	{
		echo 53;
	}
	else if ($a == 25 && $b == 29)
	{
		echo 54;
	}
	else if ($a == 25 && $b == 30)
	{
		echo 55;
	}
	else if ($a == 25 && $b == 31)
	{
		echo 56;
	}
	else if ($a == 25 && $b == 32)
	{
		echo 57;
	}
	else if ($a == 25 && $b == 33)
	{
		echo 58;
	}
	else if ($a == 25 && $b == 34)
	{
		echo 59;
	}
	else if ($a == 25 && $b == 35)
	{
		echo 60;
	}
	else if ($a == 25 && $b == 36)
	{
		echo 61;
	}
	else if ($a == 25 && $b == 37)
	{
		echo 62;
	}
	else if ($a == 25 && $b == 38)
	{
		echo 63;
	}
	else if ($a == 25 && $b == 39)
	{
		echo 64;
	}
	else if ($a == 25 && $b == 40)
	{
		echo 65;
	}
	else if ($a == 25 && $b == 41)
	{
		echo 66;
	}
	else if ($a == 25 && $b == 42)
	{
		echo 67;
	}
	else if ($a == 25 && $b == 43)
	{
		echo 68;
	}
	else if ($a == 25 && $b == 44)
	{
		echo 69;
	}
	else if ($a == 25 && $b == 45)
	{
		echo 70;
	}
	else if ($a == 25 && $b == 46)
	{
		echo 71;
	}
	else if ($a == 25 && $b == 47)
	{
		echo 72;
	}
	else if ($a == 25 && $b == 48)
	{
		echo 73;
	}
	else if ($a == 25 && $b == 49)
	{
		echo 74;
	}
	else if ($a == 25 && $b == 50)
	{
		echo 75;
	}
	else if ($a == 26 && $b == 0)
	{
		echo 26;
	}
	else if ($a == 26 && $b == 1)
	{
		echo 27;
	}
	else if ($a == 26 && $b == 2)
	{
		echo 28;
	}
	else if ($a == 26 && $b == 3)
	{
		echo 29;
	}
	else if ($a == 26 && $b == 4)
	{
		echo 30;
	}
	else if ($a == 26 && $b == 5)
	{
		echo 31;
	}
	else if ($a == 26 && $b == 6)
	{
		echo 32;
	}
	else if ($a == 26 && $b == 7)
	{
		echo 33;
	}
	else if ($a == 26 && $b == 8)
	{
		echo 34;
	}
	else if ($a == 26 && $b == 9)
	{
		echo 35;
	}
	else if ($a == 26 && $b == 10)
	{
		echo 36;
	}
	else if ($a == 26 && $b == 11)
	{
		echo 37;
	}
	else if ($a == 26 && $b == 12)
	{
		echo 38;
	}
	else if ($a == 26 && $b == 13)
	{
		echo 39;
	}
	else if ($a == 26 && $b == 14)
	{
		echo 40;
	}
	else if ($a == 26 && $b == 15)
	{
		echo 41;
	}
	else if ($a == 26 && $b == 16)
	{
		echo 42;
	}
	else if ($a == 26 && $b == 17)
	{
		echo 43;
	}
	else if ($a == 26 && $b == 18)
	{
		echo 44;
	}
	else if ($a == 26 && $b == 19)
	{
		echo 45;
	}
	else if ($a == 26 && $b == 20)
	{
		echo 46;
	}
	else if ($a == 26 && $b == 21)
	{
		echo 47;
	}
	else if ($a == 26 && $b == 22)
	{
		echo 48;
	}
	else if ($a == 26 && $b == 23)
	{
		echo 49;
	}
	else if ($a == 26 && $b == 24)
	{
		echo 50;
	}
	else if ($a == 26 && $b == 25)
	{
		echo 51;
	}
	else if ($a == 26 && $b == 26)
	{
		echo 52;
	}
	else if ($a == 26 && $b == 27)
	{
		echo 53;
	}
	else if ($a == 26 && $b == 28)
	{
		echo 54;
	}
	else if ($a == 26 && $b == 29)
	{
		echo 55;
	}
	else if ($a == 26 && $b == 30)
	{
		echo 56;
	}
	else if ($a == 26 && $b == 31)
	{
		echo 57;
	}
	else if ($a == 26 && $b == 32)
	{
		echo 58;
	}
	else if ($a == 26 && $b == 33)
	{
		echo 59;
	}
	else if ($a == 26 && $b == 34)
	{
		echo 60;
	}
	else if ($a == 26 && $b == 35)
	{
		echo 61;
	}
	else if ($a == 26 && $b == 36)
	{
		echo 62;
	}
	else if ($a == 26 && $b == 37)
	{
		echo 63;
	}
	else if ($a == 26 && $b == 38)
	{
		echo 64;
	}
	else if ($a == 26 && $b == 39)
	{
		echo 65;
	}
	else if ($a == 26 && $b == 40)
	{
		echo 66;
	}
	else if ($a == 26 && $b == 41)
	{
		echo 67;
	}
	else if ($a == 26 && $b == 42)
	{
		echo 68;
	}
	else if ($a == 26 && $b == 43)
	{
		echo 69;
	}
	else if ($a == 26 && $b == 44)
	{
		echo 70;
	}
	else if ($a == 26 && $b == 45)
	{
		echo 71;
	}
	else if ($a == 26 && $b == 46)
	{
		echo 72;
	}
	else if ($a == 26 && $b == 47)
	{
		echo 73;
	}
	else if ($a == 26 && $b == 48)
	{
		echo 74;
	}
	else if ($a == 26 && $b == 49)
	{
		echo 75;
	}
	else if ($a == 26 && $b == 50)
	{
		echo 76;
	}
	else if ($a == 27 && $b == 0)
	{
		echo 27;
	}
	else if ($a == 27 && $b == 1)
	{
		echo 28;
	}
	else if ($a == 27 && $b == 2)
	{
		echo 29;
	}
	else if ($a == 27 && $b == 3)
	{
		echo 30;
	}
	else if ($a == 27 && $b == 4)
	{
		echo 31;
	}
	else if ($a == 27 && $b == 5)
	{
		echo 32;
	}
	else if ($a == 27 && $b == 6)
	{
		echo 33;
	}
	else if ($a == 27 && $b == 7)
	{
		echo 34;
	}
	else if ($a == 27 && $b == 8)
	{
		echo 35;
	}
	else if ($a == 27 && $b == 9)
	{
		echo 36;
	}
	else if ($a == 27 && $b == 10)
	{
		echo 37;
	}
	else if ($a == 27 && $b == 11)
	{
		echo 38;
	}
	else if ($a == 27 && $b == 12)
	{
		echo 39;
	}
	else if ($a == 27 && $b == 13)
	{
		echo 40;
	}
	else if ($a == 27 && $b == 14)
	{
		echo 41;
	}
	else if ($a == 27 && $b == 15)
	{
		echo 42;
	}
	else if ($a == 27 && $b == 16)
	{
		echo 43;
	}
	else if ($a == 27 && $b == 17)
	{
		echo 44;
	}
	else if ($a == 27 && $b == 18)
	{
		echo 45;
	}
	else if ($a == 27 && $b == 19)
	{
		echo 46;
	}
	else if ($a == 27 && $b == 20)
	{
		echo 47;
	}
	else if ($a == 27 && $b == 21)
	{
		echo 48;
	}
	else if ($a == 27 && $b == 22)
	{
		echo 49;
	}
	else if ($a == 27 && $b == 23)
	{
		echo 50;
	}
	else if ($a == 27 && $b == 24)
	{
		echo 51;
	}
	else if ($a == 27 && $b == 25)
	{
		echo 52;
	}
	else if ($a == 27 && $b == 26)
	{
		echo 53;
	}
	else if ($a == 27 && $b == 27)
	{
		echo 54;
	}
	else if ($a == 27 && $b == 28)
	{
		echo 55;
	}
	else if ($a == 27 && $b == 29)
	{
		echo 56;
	}
	else if ($a == 27 && $b == 30)
	{
		echo 57;
	}
	else if ($a == 27 && $b == 31)
	{
		echo 58;
	}
	else if ($a == 27 && $b == 32)
	{
		echo 59;
	}
	else if ($a == 27 && $b == 33)
	{
		echo 60;
	}
	else if ($a == 27 && $b == 34)
	{
		echo 61;
	}
	else if ($a == 27 && $b == 35)
	{
		echo 62;
	}
	else if ($a == 27 && $b == 36)
	{
		echo 63;
	}
	else if ($a == 27 && $b == 37)
	{
		echo 64;
	}
	else if ($a == 27 && $b == 38)
	{
		echo 65;
	}
	else if ($a == 27 && $b == 39)
	{
		echo 66;
	}
	else if ($a == 27 && $b == 40)
	{
		echo 67;
	}
	else if ($a == 27 && $b == 41)
	{
		echo 68;
	}
	else if ($a == 27 && $b == 42)
	{
		echo 69;
	}
	else if ($a == 27 && $b == 43)
	{
		echo 70;
	}
	else if ($a == 27 && $b == 44)
	{
		echo 71;
	}
	else if ($a == 27 && $b == 45)
	{
		echo 72;
	}
	else if ($a == 27 && $b == 46)
	{
		echo 73;
	}
	else if ($a == 27 && $b == 47)
	{
		echo 74;
	}
	else if ($a == 27 && $b == 48)
	{
		echo 75;
	}
	else if ($a == 27 && $b == 49)
	{
		echo 76;
	}
	else if ($a == 27 && $b == 50)
	{
		echo 77;
	}
	else if ($a == 28 && $b == 0)
	{
		echo 28;
	}
	else if ($a == 28 && $b == 1)
	{
		echo 29;
	}
	else if ($a == 28 && $b == 2)
	{
		echo 30;
	}
	else if ($a == 28 && $b == 3)
	{
		echo 31;
	}
	else if ($a == 28 && $b == 4)
	{
		echo 32;
	}
	else if ($a == 28 && $b == 5)
	{
		echo 33;
	}
	else if ($a == 28 && $b == 6)
	{
		echo 34;
	}
	else if ($a == 28 && $b == 7)
	{
		echo 35;
	}
	else if ($a == 28 && $b == 8)
	{
		echo 36;
	}
	else if ($a == 28 && $b == 9)
	{
		echo 37;
	}
	else if ($a == 28 && $b == 10)
	{
		echo 38;
	}
	else if ($a == 28 && $b == 11)
	{
		echo 39;
	}
	else if ($a == 28 && $b == 12)
	{
		echo 40;
	}
	else if ($a == 28 && $b == 13)
	{
		echo 41;
	}
	else if ($a == 28 && $b == 14)
	{
		echo 42;
	}
	else if ($a == 28 && $b == 15)
	{
		echo 43;
	}
	else if ($a == 28 && $b == 16)
	{
		echo 44;
	}
	else if ($a == 28 && $b == 17)
	{
		echo 45;
	}
	else if ($a == 28 && $b == 18)
	{
		echo 46;
	}
	else if ($a == 28 && $b == 19)
	{
		echo 47;
	}
	else if ($a == 28 && $b == 20)
	{
		echo 48;
	}
	else if ($a == 28 && $b == 21)
	{
		echo 49;
	}
	else if ($a == 28 && $b == 22)
	{
		echo 50;
	}
	else if ($a == 28 && $b == 23)
	{
		echo 51;
	}
	else if ($a == 28 && $b == 24)
	{
		echo 52;
	}
	else if ($a == 28 && $b == 25)
	{
		echo 53;
	}
	else if ($a == 28 && $b == 26)
	{
		echo 54;
	}
	else if ($a == 28 && $b == 27)
	{
		echo 55;
	}
	else if ($a == 28 && $b == 28)
	{
		echo 56;
	}
	else if ($a == 28 && $b == 29)
	{
		echo 57;
	}
	else if ($a == 28 && $b == 30)
	{
		echo 58;
	}
	else if ($a == 28 && $b == 31)
	{
		echo 59;
	}
	else if ($a == 28 && $b == 32)
	{
		echo 60;
	}
	else if ($a == 28 && $b == 33)
	{
		echo 61;
	}
	else if ($a == 28 && $b == 34)
	{
		echo 62;
	}
	else if ($a == 28 && $b == 35)
	{
		echo 63;
	}
	else if ($a == 28 && $b == 36)
	{
		echo 64;
	}
	else if ($a == 28 && $b == 37)
	{
		echo 65;
	}
	else if ($a == 28 && $b == 38)
	{
		echo 66;
	}
	else if ($a == 28 && $b == 39)
	{
		echo 67;
	}
	else if ($a == 28 && $b == 40)
	{
		echo 68;
	}
	else if ($a == 28 && $b == 41)
	{
		echo 69;
	}
	else if ($a == 28 && $b == 42)
	{
		echo 70;
	}
	else if ($a == 28 && $b == 43)
	{
		echo 71;
	}
	else if ($a == 28 && $b == 44)
	{
		echo 72;
	}
	else if ($a == 28 && $b == 45)
	{
		echo 73;
	}
	else if ($a == 28 && $b == 46)
	{
		echo 74;
	}
	else if ($a == 28 && $b == 47)
	{
		echo 75;
	}
	else if ($a == 28 && $b == 48)
	{
		echo 76;
	}
	else if ($a == 28 && $b == 49)
	{
		echo 77;
	}
	else if ($a == 28 && $b == 50)
	{
		echo 78;
	}
	else if ($a == 29 && $b == 0)
	{
		echo 29;
	}
	else if ($a == 29 && $b == 1)
	{
		echo 30;
	}
	else if ($a == 29 && $b == 2)
	{
		echo 31;
	}
	else if ($a == 29 && $b == 3)
	{
		echo 32;
	}
	else if ($a == 29 && $b == 4)
	{
		echo 33;
	}
	else if ($a == 29 && $b == 5)
	{
		echo 34;
	}
	else if ($a == 29 && $b == 6)
	{
		echo 35;
	}
	else if ($a == 29 && $b == 7)
	{
		echo 36;
	}
	else if ($a == 29 && $b == 8)
	{
		echo 37;
	}
	else if ($a == 29 && $b == 9)
	{
		echo 38;
	}
	else if ($a == 29 && $b == 10)
	{
		echo 39;
	}
	else if ($a == 29 && $b == 11)
	{
		echo 40;
	}
	else if ($a == 29 && $b == 12)
	{
		echo 41;
	}
	else if ($a == 29 && $b == 13)
	{
		echo 42;
	}
	else if ($a == 29 && $b == 14)
	{
		echo 43;
	}
	else if ($a == 29 && $b == 15)
	{
		echo 44;
	}
	else if ($a == 29 && $b == 16)
	{
		echo 45;
	}
	else if ($a == 29 && $b == 17)
	{
		echo 46;
	}
	else if ($a == 29 && $b == 18)
	{
		echo 47;
	}
	else if ($a == 29 && $b == 19)
	{
		echo 48;
	}
	else if ($a == 29 && $b == 20)
	{
		echo 49;
	}
	else if ($a == 29 && $b == 21)
	{
		echo 50;
	}
	else if ($a == 29 && $b == 22)
	{
		echo 51;
	}
	else if ($a == 29 && $b == 23)
	{
		echo 52;
	}
	else if ($a == 29 && $b == 24)
	{
		echo 53;
	}
	else if ($a == 29 && $b == 25)
	{
		echo 54;
	}
	else if ($a == 29 && $b == 26)
	{
		echo 55;
	}
	else if ($a == 29 && $b == 27)
	{
		echo 56;
	}
	else if ($a == 29 && $b == 28)
	{
		echo 57;
	}
	else if ($a == 29 && $b == 29)
	{
		echo 58;
	}
	else if ($a == 29 && $b == 30)
	{
		echo 59;
	}
	else if ($a == 29 && $b == 31)
	{
		echo 60;
	}
	else if ($a == 29 && $b == 32)
	{
		echo 61;
	}
	else if ($a == 29 && $b == 33)
	{
		echo 62;
	}
	else if ($a == 29 && $b == 34)
	{
		echo 63;
	}
	else if ($a == 29 && $b == 35)
	{
		echo 64;
	}
	else if ($a == 29 && $b == 36)
	{
		echo 65;
	}
	else if ($a == 29 && $b == 37)
	{
		echo 66;
	}
	else if ($a == 29 && $b == 38)
	{
		echo 67;
	}
	else if ($a == 29 && $b == 39)
	{
		echo 68;
	}
	else if ($a == 29 && $b == 40)
	{
		echo 69;
	}
	else if ($a == 29 && $b == 41)
	{
		echo 70;
	}
	else if ($a == 29 && $b == 42)
	{
		echo 71;
	}
	else if ($a == 29 && $b == 43)
	{
		echo 72;
	}
	else if ($a == 29 && $b == 44)
	{
		echo 73;
	}
	else if ($a == 29 && $b == 45)
	{
		echo 74;
	}
	else if ($a == 29 && $b == 46)
	{
		echo 75;
	}
	else if ($a == 29 && $b == 47)
	{
		echo 76;
	}
	else if ($a == 29 && $b == 48)
	{
		echo 77;
	}
	else if ($a == 29 && $b == 49)
	{
		echo 78;
	}
	else if ($a == 29 && $b == 50)
	{
		echo 79;
	}
	else if ($a == 30 && $b == 0)
	{
		echo 30;
	}
	else if ($a == 30 && $b == 1)
	{
		echo 31;
	}
	else if ($a == 30 && $b == 2)
	{
		echo 32;
	}
	else if ($a == 30 && $b == 3)
	{
		echo 33;
	}
	else if ($a == 30 && $b == 4)
	{
		echo 34;
	}
	else if ($a == 30 && $b == 5)
	{
		echo 35;
	}
	else if ($a == 30 && $b == 6)
	{
		echo 36;
	}
	else if ($a == 30 && $b == 7)
	{
		echo 37;
	}
	else if ($a == 30 && $b == 8)
	{
		echo 38;
	}
	else if ($a == 30 && $b == 9)
	{
		echo 39;
	}
	else if ($a == 30 && $b == 10)
	{
		echo 40;
	}
	else if ($a == 30 && $b == 11)
	{
		echo 41;
	}
	else if ($a == 30 && $b == 12)
	{
		echo 42;
	}
	else if ($a == 30 && $b == 13)
	{
		echo 43;
	}
	else if ($a == 30 && $b == 14)
	{
		echo 44;
	}
	else if ($a == 30 && $b == 15)
	{
		echo 45;
	}
	else if ($a == 30 && $b == 16)
	{
		echo 46;
	}
	else if ($a == 30 && $b == 17)
	{
		echo 47;
	}
	else if ($a == 30 && $b == 18)
	{
		echo 48;
	}
	else if ($a == 30 && $b == 19)
	{
		echo 49;
	}
	else if ($a == 30 && $b == 20)
	{
		echo 50;
	}
	else if ($a == 30 && $b == 21)
	{
		echo 51;
	}
	else if ($a == 30 && $b == 22)
	{
		echo 52;
	}
	else if ($a == 30 && $b == 23)
	{
		echo 53;
	}
	else if ($a == 30 && $b == 24)
	{
		echo 54;
	}
	else if ($a == 30 && $b == 25)
	{
		echo 55;
	}
	else if ($a == 30 && $b == 26)
	{
		echo 56;
	}
	else if ($a == 30 && $b == 27)
	{
		echo 57;
	}
	else if ($a == 30 && $b == 28)
	{
		echo 58;
	}
	else if ($a == 30 && $b == 29)
	{
		echo 59;
	}
	else if ($a == 30 && $b == 30)
	{
		echo 60;
	}
	else if ($a == 30 && $b == 31)
	{
		echo 61;
	}
	else if ($a == 30 && $b == 32)
	{
		echo 62;
	}
	else if ($a == 30 && $b == 33)
	{
		echo 63;
	}
	else if ($a == 30 && $b == 34)
	{
		echo 64;
	}
	else if ($a == 30 && $b == 35)
	{
		echo 65;
	}
	else if ($a == 30 && $b == 36)
	{
		echo 66;
	}
	else if ($a == 30 && $b == 37)
	{
		echo 67;
	}
	else if ($a == 30 && $b == 38)
	{
		echo 68;
	}
	else if ($a == 30 && $b == 39)
	{
		echo 69;
	}
	else if ($a == 30 && $b == 40)
	{
		echo 70;
	}
	else if ($a == 30 && $b == 41)
	{
		echo 71;
	}
	else if ($a == 30 && $b == 42)
	{
		echo 72;
	}
	else if ($a == 30 && $b == 43)
	{
		echo 73;
	}
	else if ($a == 30 && $b == 44)
	{
		echo 74;
	}
	else if ($a == 30 && $b == 45)
	{
		echo 75;
	}
	else if ($a == 30 && $b == 46)
	{
		echo 76;
	}
	else if ($a == 30 && $b == 47)
	{
		echo 77;
	}
	else if ($a == 30 && $b == 48)
	{
		echo 78;
	}
	else if ($a == 30 && $b == 49)
	{
		echo 79;
	}
	else if ($a == 30 && $b == 50)
	{
		echo 80;
	}
	else if ($a == 31 && $b == 0)
	{
		echo 31;
	}
	else if ($a == 31 && $b == 1)
	{
		echo 32;
	}
	else if ($a == 31 && $b == 2)
	{
		echo 33;
	}
	else if ($a == 31 && $b == 3)
	{
		echo 34;
	}
	else if ($a == 31 && $b == 4)
	{
		echo 35;
	}
	else if ($a == 31 && $b == 5)
	{
		echo 36;
	}
	else if ($a == 31 && $b == 6)
	{
		echo 37;
	}
	else if ($a == 31 && $b == 7)
	{
		echo 38;
	}
	else if ($a == 31 && $b == 8)
	{
		echo 39;
	}
	else if ($a == 31 && $b == 9)
	{
		echo 40;
	}
	else if ($a == 31 && $b == 10)
	{
		echo 41;
	}
	else if ($a == 31 && $b == 11)
	{
		echo 42;
	}
	else if ($a == 31 && $b == 12)
	{
		echo 43;
	}
	else if ($a == 31 && $b == 13)
	{
		echo 44;
	}
	else if ($a == 31 && $b == 14)
	{
		echo 45;
	}
	else if ($a == 31 && $b == 15)
	{
		echo 46;
	}
	else if ($a == 31 && $b == 16)
	{
		echo 47;
	}
	else if ($a == 31 && $b == 17)
	{
		echo 48;
	}
	else if ($a == 31 && $b == 18)
	{
		echo 49;
	}
	else if ($a == 31 && $b == 19)
	{
		echo 50;
	}
	else if ($a == 31 && $b == 20)
	{
		echo 51;
	}
	else if ($a == 31 && $b == 21)
	{
		echo 52;
	}
	else if ($a == 31 && $b == 22)
	{
		echo 53;
	}
	else if ($a == 31 && $b == 23)
	{
		echo 54;
	}
	else if ($a == 31 && $b == 24)
	{
		echo 55;
	}
	else if ($a == 31 && $b == 25)
	{
		echo 56;
	}
	else if ($a == 31 && $b == 26)
	{
		echo 57;
	}
	else if ($a == 31 && $b == 27)
	{
		echo 58;
	}
	else if ($a == 31 && $b == 28)
	{
		echo 59;
	}
	else if ($a == 31 && $b == 29)
	{
		echo 60;
	}
	else if ($a == 31 && $b == 30)
	{
		echo 61;
	}
	else if ($a == 31 && $b == 31)
	{
		echo 62;
	}
	else if ($a == 31 && $b == 32)
	{
		echo 63;
	}
	else if ($a == 31 && $b == 33)
	{
		echo 64;
	}
	else if ($a == 31 && $b == 34)
	{
		echo 65;
	}
	else if ($a == 31 && $b == 35)
	{
		echo 66;
	}
	else if ($a == 31 && $b == 36)
	{
		echo 67;
	}
	else if ($a == 31 && $b == 37)
	{
		echo 68;
	}
	else if ($a == 31 && $b == 38)
	{
		echo 69;
	}
	else if ($a == 31 && $b == 39)
	{
		echo 70;
	}
	else if ($a == 31 && $b == 40)
	{
		echo 71;
	}
	else if ($a == 31 && $b == 41)
	{
		echo 72;
	}
	else if ($a == 31 && $b == 42)
	{
		echo 73;
	}
	else if ($a == 31 && $b == 43)
	{
		echo 74;
	}
	else if ($a == 31 && $b == 44)
	{
		echo 75;
	}
	else if ($a == 31 && $b == 45)
	{
		echo 76;
	}
	else if ($a == 31 && $b == 46)
	{
		echo 77;
	}
	else if ($a == 31 && $b == 47)
	{
		echo 78;
	}
	else if ($a == 31 && $b == 48)
	{
		echo 79;
	}
	else if ($a == 31 && $b == 49)
	{
		echo 80;
	}
	else if ($a == 31 && $b == 50)
	{
		echo 81;
	}
	else if ($a == 32 && $b == 0)
	{
		echo 32;
	}
	else if ($a == 32 && $b == 1)
	{
		echo 33;
	}
	else if ($a == 32 && $b == 2)
	{
		echo 34;
	}
	else if ($a == 32 && $b == 3)
	{
		echo 35;
	}
	else if ($a == 32 && $b == 4)
	{
		echo 36;
	}
	else if ($a == 32 && $b == 5)
	{
		echo 37;
	}
	else if ($a == 32 && $b == 6)
	{
		echo 38;
	}
	else if ($a == 32 && $b == 7)
	{
		echo 39;
	}
	else if ($a == 32 && $b == 8)
	{
		echo 40;
	}
	else if ($a == 32 && $b == 9)
	{
		echo 41;
	}
	else if ($a == 32 && $b == 10)
	{
		echo 42;
	}
	else if ($a == 32 && $b == 11)
	{
		echo 43;
	}
	else if ($a == 32 && $b == 12)
	{
		echo 44;
	}
	else if ($a == 32 && $b == 13)
	{
		echo 45;
	}
	else if ($a == 32 && $b == 14)
	{
		echo 46;
	}
	else if ($a == 32 && $b == 15)
	{
		echo 47;
	}
	else if ($a == 32 && $b == 16)
	{
		echo 48;
	}
	else if ($a == 32 && $b == 17)
	{
		echo 49;
	}
	else if ($a == 32 && $b == 18)
	{
		echo 50;
	}
	else if ($a == 32 && $b == 19)
	{
		echo 51;
	}
	else if ($a == 32 && $b == 20)
	{
		echo 52;
	}
	else if ($a == 32 && $b == 21)
	{
		echo 53;
	}
	else if ($a == 32 && $b == 22)
	{
		echo 54;
	}
	else if ($a == 32 && $b == 23)
	{
		echo 55;
	}
	else if ($a == 32 && $b == 24)
	{
		echo 56;
	}
	else if ($a == 32 && $b == 25)
	{
		echo 57;
	}
	else if ($a == 32 && $b == 26)
	{
		echo 58;
	}
	else if ($a == 32 && $b == 27)
	{
		echo 59;
	}
	else if ($a == 32 && $b == 28)
	{
		echo 60;
	}
	else if ($a == 32 && $b == 29)
	{
		echo 61;
	}
	else if ($a == 32 && $b == 30)
	{
		echo 62;
	}
	else if ($a == 32 && $b == 31)
	{
		echo 63;
	}
	else if ($a == 32 && $b == 32)
	{
		echo 64;
	}
	else if ($a == 32 && $b == 33)
	{
		echo 65;
	}
	else if ($a == 32 && $b == 34)
	{
		echo 66;
	}
	else if ($a == 32 && $b == 35)
	{
		echo 67;
	}
	else if ($a == 32 && $b == 36)
	{
		echo 68;
	}
	else if ($a == 32 && $b == 37)
	{
		echo 69;
	}
	else if ($a == 32 && $b == 38)
	{
		echo 70;
	}
	else if ($a == 32 && $b == 39)
	{
		echo 71;
	}
	else if ($a == 32 && $b == 40)
	{
		echo 72;
	}
	else if ($a == 32 && $b == 41)
	{
		echo 73;
	}
	else if ($a == 32 && $b == 42)
	{
		echo 74;
	}
	else if ($a == 32 && $b == 43)
	{
		echo 75;
	}
	else if ($a == 32 && $b == 44)
	{
		echo 76;
	}
	else if ($a == 32 && $b == 45)
	{
		echo 77;
	}
	else if ($a == 32 && $b == 46)
	{
		echo 78;
	}
	else if ($a == 32 && $b == 47)
	{
		echo 79;
	}
	else if ($a == 32 && $b == 48)
	{
		echo 80;
	}
	else if ($a == 32 && $b == 49)
	{
		echo 81;
	}
	else if ($a == 32 && $b == 50)
	{
		echo 82;
	}
	else if ($a == 33 && $b == 0)
	{
		echo 33;
	}
	else if ($a == 33 && $b == 1)
	{
		echo 34;
	}
	else if ($a == 33 && $b == 2)
	{
		echo 35;
	}
	else if ($a == 33 && $b == 3)
	{
		echo 36;
	}
	else if ($a == 33 && $b == 4)
	{
		echo 37;
	}
	else if ($a == 33 && $b == 5)
	{
		echo 38;
	}
	else if ($a == 33 && $b == 6)
	{
		echo 39;
	}
	else if ($a == 33 && $b == 7)
	{
		echo 40;
	}
	else if ($a == 33 && $b == 8)
	{
		echo 41;
	}
	else if ($a == 33 && $b == 9)
	{
		echo 42;
	}
	else if ($a == 33 && $b == 10)
	{
		echo 43;
	}
	else if ($a == 33 && $b == 11)
	{
		echo 44;
	}
	else if ($a == 33 && $b == 12)
	{
		echo 45;
	}
	else if ($a == 33 && $b == 13)
	{
		echo 46;
	}
	else if ($a == 33 && $b == 14)
	{
		echo 47;
	}
	else if ($a == 33 && $b == 15)
	{
		echo 48;
	}
	else if ($a == 33 && $b == 16)
	{
		echo 49;
	}
	else if ($a == 33 && $b == 17)
	{
		echo 50;
	}
	else if ($a == 33 && $b == 18)
	{
		echo 51;
	}
	else if ($a == 33 && $b == 19)
	{
		echo 52;
	}
	else if ($a == 33 && $b == 20)
	{
		echo 53;
	}
	else if ($a == 33 && $b == 21)
	{
		echo 54;
	}
	else if ($a == 33 && $b == 22)
	{
		echo 55;
	}
	else if ($a == 33 && $b == 23)
	{
		echo 56;
	}
	else if ($a == 33 && $b == 24)
	{
		echo 57;
	}
	else if ($a == 33 && $b == 25)
	{
		echo 58;
	}
	else if ($a == 33 && $b == 26)
	{
		echo 59;
	}
	else if ($a == 33 && $b == 27)
	{
		echo 60;
	}
	else if ($a == 33 && $b == 28)
	{
		echo 61;
	}
	else if ($a == 33 && $b == 29)
	{
		echo 62;
	}
	else if ($a == 33 && $b == 30)
	{
		echo 63;
	}
	else if ($a == 33 && $b == 31)
	{
		echo 64;
	}
	else if ($a == 33 && $b == 32)
	{
		echo 65;
	}
	else if ($a == 33 && $b == 33)
	{
		echo 66;
	}
	else if ($a == 33 && $b == 34)
	{
		echo 67;
	}
	else if ($a == 33 && $b == 35)
	{
		echo 68;
	}
	else if ($a == 33 && $b == 36)
	{
		echo 69;
	}
	else if ($a == 33 && $b == 37)
	{
		echo 70;
	}
	else if ($a == 33 && $b == 38)
	{
		echo 71;
	}
	else if ($a == 33 && $b == 39)
	{
		echo 72;
	}
	else if ($a == 33 && $b == 40)
	{
		echo 73;
	}
	else if ($a == 33 && $b == 41)
	{
		echo 74;
	}
	else if ($a == 33 && $b == 42)
	{
		echo 75;
	}
	else if ($a == 33 && $b == 43)
	{
		echo 76;
	}
	else if ($a == 33 && $b == 44)
	{
		echo 77;
	}
	else if ($a == 33 && $b == 45)
	{
		echo 78;
	}
	else if ($a == 33 && $b == 46)
	{
		echo 79;
	}
	else if ($a == 33 && $b == 47)
	{
		echo 80;
	}
	else if ($a == 33 && $b == 48)
	{
		echo 81;
	}
	else if ($a == 33 && $b == 49)
	{
		echo 82;
	}
	else if ($a == 33 && $b == 50)
	{
		echo 83;
	}
	else if ($a == 34 && $b == 0)
	{
		echo 34;
	}
	else if ($a == 34 && $b == 1)
	{
		echo 35;
	}
	else if ($a == 34 && $b == 2)
	{
		echo 36;
	}
	else if ($a == 34 && $b == 3)
	{
		echo 37;
	}
	else if ($a == 34 && $b == 4)
	{
		echo 38;
	}
	else if ($a == 34 && $b == 5)
	{
		echo 39;
	}
	else if ($a == 34 && $b == 6)
	{
		echo 40;
	}
	else if ($a == 34 && $b == 7)
	{
		echo 41;
	}
	else if ($a == 34 && $b == 8)
	{
		echo 42;
	}
	else if ($a == 34 && $b == 9)
	{
		echo 43;
	}
	else if ($a == 34 && $b == 10)
	{
		echo 44;
	}
	else if ($a == 34 && $b == 11)
	{
		echo 45;
	}
	else if ($a == 34 && $b == 12)
	{
		echo 46;
	}
	else if ($a == 34 && $b == 13)
	{
		echo 47;
	}
	else if ($a == 34 && $b == 14)
	{
		echo 48;
	}
	else if ($a == 34 && $b == 15)
	{
		echo 49;
	}
	else if ($a == 34 && $b == 16)
	{
		echo 50;
	}
	else if ($a == 34 && $b == 17)
	{
		echo 51;
	}
	else if ($a == 34 && $b == 18)
	{
		echo 52;
	}
	else if ($a == 34 && $b == 19)
	{
		echo 53;
	}
	else if ($a == 34 && $b == 20)
	{
		echo 54;
	}
	else if ($a == 34 && $b == 21)
	{
		echo 55;
	}
	else if ($a == 34 && $b == 22)
	{
		echo 56;
	}
	else if ($a == 34 && $b == 23)
	{
		echo 57;
	}
	else if ($a == 34 && $b == 24)
	{
		echo 58;
	}
	else if ($a == 34 && $b == 25)
	{
		echo 59;
	}
	else if ($a == 34 && $b == 26)
	{
		echo 60;
	}
	else if ($a == 34 && $b == 27)
	{
		echo 61;
	}
	else if ($a == 34 && $b == 28)
	{
		echo 62;
	}
	else if ($a == 34 && $b == 29)
	{
		echo 63;
	}
	else if ($a == 34 && $b == 30)
	{
		echo 64;
	}
	else if ($a == 34 && $b == 31)
	{
		echo 65;
	}
	else if ($a == 34 && $b == 32)
	{
		echo 66;
	}
	else if ($a == 34 && $b == 33)
	{
		echo 67;
	}
	else if ($a == 34 && $b == 34)
	{
		echo 68;
	}
	else if ($a == 34 && $b == 35)
	{
		echo 69;
	}
	else if ($a == 34 && $b == 36)
	{
		echo 70;
	}
	else if ($a == 34 && $b == 37)
	{
		echo 71;
	}
	else if ($a == 34 && $b == 38)
	{
		echo 72;
	}
	else if ($a == 34 && $b == 39)
	{
		echo 73;
	}
	else if ($a == 34 && $b == 40)
	{
		echo 74;
	}
	else if ($a == 34 && $b == 41)
	{
		echo 75;
	}
	else if ($a == 34 && $b == 42)
	{
		echo 76;
	}
	else if ($a == 34 && $b == 43)
	{
		echo 77;
	}
	else if ($a == 34 && $b == 44)
	{
		echo 78;
	}
	else if ($a == 34 && $b == 45)
	{
		echo 79;
	}
	else if ($a == 34 && $b == 46)
	{
		echo 80;
	}
	else if ($a == 34 && $b == 47)
	{
		echo 81;
	}
	else if ($a == 34 && $b == 48)
	{
		echo 82;
	}
	else if ($a == 34 && $b == 49)
	{
		echo 83;
	}
	else if ($a == 34 && $b == 50)
	{
		echo 84;
	}
	else if ($a == 35 && $b == 0)
	{
		echo 35;
	}
	else if ($a == 35 && $b == 1)
	{
		echo 36;
	}
	else if ($a == 35 && $b == 2)
	{
		echo 37;
	}
	else if ($a == 35 && $b == 3)
	{
		echo 38;
	}
	else if ($a == 35 && $b == 4)
	{
		echo 39;
	}
	else if ($a == 35 && $b == 5)
	{
		echo 40;
	}
	else if ($a == 35 && $b == 6)
	{
		echo 41;
	}
	else if ($a == 35 && $b == 7)
	{
		echo 42;
	}
	else if ($a == 35 && $b == 8)
	{
		echo 43;
	}
	else if ($a == 35 && $b == 9)
	{
		echo 44;
	}
	else if ($a == 35 && $b == 10)
	{
		echo 45;
	}
	else if ($a == 35 && $b == 11)
	{
		echo 46;
	}
	else if ($a == 35 && $b == 12)
	{
		echo 47;
	}
	else if ($a == 35 && $b == 13)
	{
		echo 48;
	}
	else if ($a == 35 && $b == 14)
	{
		echo 49;
	}
	else if ($a == 35 && $b == 15)
	{
		echo 50;
	}
	else if ($a == 35 && $b == 16)
	{
		echo 51;
	}
	else if ($a == 35 && $b == 17)
	{
		echo 52;
	}
	else if ($a == 35 && $b == 18)
	{
		echo 53;
	}
	else if ($a == 35 && $b == 19)
	{
		echo 54;
	}
	else if ($a == 35 && $b == 20)
	{
		echo 55;
	}
	else if ($a == 35 && $b == 21)
	{
		echo 56;
	}
	else if ($a == 35 && $b == 22)
	{
		echo 57;
	}
	else if ($a == 35 && $b == 23)
	{
		echo 58;
	}
	else if ($a == 35 && $b == 24)
	{
		echo 59;
	}
	else if ($a == 35 && $b == 25)
	{
		echo 60;
	}
	else if ($a == 35 && $b == 26)
	{
		echo 61;
	}
	else if ($a == 35 && $b == 27)
	{
		echo 62;
	}
	else if ($a == 35 && $b == 28)
	{
		echo 63;
	}
	else if ($a == 35 && $b == 29)
	{
		echo 64;
	}
	else if ($a == 35 && $b == 30)
	{
		echo 65;
	}
	else if ($a == 35 && $b == 31)
	{
		echo 66;
	}
	else if ($a == 35 && $b == 32)
	{
		echo 67;
	}
	else if ($a == 35 && $b == 33)
	{
		echo 68;
	}
	else if ($a == 35 && $b == 34)
	{
		echo 69;
	}
	else if ($a == 35 && $b == 35)
	{
		echo 70;
	}
	else if ($a == 35 && $b == 36)
	{
		echo 71;
	}
	else if ($a == 35 && $b == 37)
	{
		echo 72;
	}
	else if ($a == 35 && $b == 38)
	{
		echo 73;
	}
	else if ($a == 35 && $b == 39)
	{
		echo 74;
	}
	else if ($a == 35 && $b == 40)
	{
		echo 75;
	}
	else if ($a == 35 && $b == 41)
	{
		echo 76;
	}
	else if ($a == 35 && $b == 42)
	{
		echo 77;
	}
	else if ($a == 35 && $b == 43)
	{
		echo 78;
	}
	else if ($a == 35 && $b == 44)
	{
		echo 79;
	}
	else if ($a == 35 && $b == 45)
	{
		echo 80;
	}
	else if ($a == 35 && $b == 46)
	{
		echo 81;
	}
	else if ($a == 35 && $b == 47)
	{
		echo 82;
	}
	else if ($a == 35 && $b == 48)
	{
		echo 83;
	}
	else if ($a == 35 && $b == 49)
	{
		echo 84;
	}
	else if ($a == 35 && $b == 50)
	{
		echo 85;
	}
	else if ($a == 36 && $b == 0)
	{
		echo 36;
	}
	else if ($a == 36 && $b == 1)
	{
		echo 37;
	}
	else if ($a == 36 && $b == 2)
	{
		echo 38;
	}
	else if ($a == 36 && $b == 3)
	{
		echo 39;
	}
	else if ($a == 36 && $b == 4)
	{
		echo 40;
	}
	else if ($a == 36 && $b == 5)
	{
		echo 41;
	}
	else if ($a == 36 && $b == 6)
	{
		echo 42;
	}
	else if ($a == 36 && $b == 7)
	{
		echo 43;
	}
	else if ($a == 36 && $b == 8)
	{
		echo 44;
	}
	else if ($a == 36 && $b == 9)
	{
		echo 45;
	}
	else if ($a == 36 && $b == 10)
	{
		echo 46;
	}
	else if ($a == 36 && $b == 11)
	{
		echo 47;
	}
	else if ($a == 36 && $b == 12)
	{
		echo 48;
	}
	else if ($a == 36 && $b == 13)
	{
		echo 49;
	}
	else if ($a == 36 && $b == 14)
	{
		echo 50;
	}
	else if ($a == 36 && $b == 15)
	{
		echo 51;
	}
	else if ($a == 36 && $b == 16)
	{
		echo 52;
	}
	else if ($a == 36 && $b == 17)
	{
		echo 53;
	}
	else if ($a == 36 && $b == 18)
	{
		echo 54;
	}
	else if ($a == 36 && $b == 19)
	{
		echo 55;
	}
	else if ($a == 36 && $b == 20)
	{
		echo 56;
	}
	else if ($a == 36 && $b == 21)
	{
		echo 57;
	}
	else if ($a == 36 && $b == 22)
	{
		echo 58;
	}
	else if ($a == 36 && $b == 23)
	{
		echo 59;
	}
	else if ($a == 36 && $b == 24)
	{
		echo 60;
	}
	else if ($a == 36 && $b == 25)
	{
		echo 61;
	}
	else if ($a == 36 && $b == 26)
	{
		echo 62;
	}
	else if ($a == 36 && $b == 27)
	{
		echo 63;
	}
	else if ($a == 36 && $b == 28)
	{
		echo 64;
	}
	else if ($a == 36 && $b == 29)
	{
		echo 65;
	}
	else if ($a == 36 && $b == 30)
	{
		echo 66;
	}
	else if ($a == 36 && $b == 31)
	{
		echo 67;
	}
	else if ($a == 36 && $b == 32)
	{
		echo 68;
	}
	else if ($a == 36 && $b == 33)
	{
		echo 69;
	}
	else if ($a == 36 && $b == 34)
	{
		echo 70;
	}
	else if ($a == 36 && $b == 35)
	{
		echo 71;
	}
	else if ($a == 36 && $b == 36)
	{
		echo 72;
	}
	else if ($a == 36 && $b == 37)
	{
		echo 73;
	}
	else if ($a == 36 && $b == 38)
	{
		echo 74;
	}
	else if ($a == 36 && $b == 39)
	{
		echo 75;
	}
	else if ($a == 36 && $b == 40)
	{
		echo 76;
	}
	else if ($a == 36 && $b == 41)
	{
		echo 77;
	}
	else if ($a == 36 && $b == 42)
	{
		echo 78;
	}
	else if ($a == 36 && $b == 43)
	{
		echo 79;
	}
	else if ($a == 36 && $b == 44)
	{
		echo 80;
	}
	else if ($a == 36 && $b == 45)
	{
		echo 81;
	}
	else if ($a == 36 && $b == 46)
	{
		echo 82;
	}
	else if ($a == 36 && $b == 47)
	{
		echo 83;
	}
	else if ($a == 36 && $b == 48)
	{
		echo 84;
	}
	else if ($a == 36 && $b == 49)
	{
		echo 85;
	}
	else if ($a == 36 && $b == 50)
	{
		echo 86;
	}
	else if ($a == 37 && $b == 0)
	{
		echo 37;
	}
	else if ($a == 37 && $b == 1)
	{
		echo 38;
	}
	else if ($a == 37 && $b == 2)
	{
		echo 39;
	}
	else if ($a == 37 && $b == 3)
	{
		echo 40;
	}
	else if ($a == 37 && $b == 4)
	{
		echo 41;
	}
	else if ($a == 37 && $b == 5)
	{
		echo 42;
	}
	else if ($a == 37 && $b == 6)
	{
		echo 43;
	}
	else if ($a == 37 && $b == 7)
	{
		echo 44;
	}
	else if ($a == 37 && $b == 8)
	{
		echo 45;
	}
	else if ($a == 37 && $b == 9)
	{
		echo 46;
	}
	else if ($a == 37 && $b == 10)
	{
		echo 47;
	}
	else if ($a == 37 && $b == 11)
	{
		echo 48;
	}
	else if ($a == 37 && $b == 12)
	{
		echo 49;
	}
	else if ($a == 37 && $b == 13)
	{
		echo 50;
	}
	else if ($a == 37 && $b == 14)
	{
		echo 51;
	}
	else if ($a == 37 && $b == 15)
	{
		echo 52;
	}
	else if ($a == 37 && $b == 16)
	{
		echo 53;
	}
	else if ($a == 37 && $b == 17)
	{
		echo 54;
	}
	else if ($a == 37 && $b == 18)
	{
		echo 55;
	}
	else if ($a == 37 && $b == 19)
	{
		echo 56;
	}
	else if ($a == 37 && $b == 20)
	{
		echo 57;
	}
	else if ($a == 37 && $b == 21)
	{
		echo 58;
	}
	else if ($a == 37 && $b == 22)
	{
		echo 59;
	}
	else if ($a == 37 && $b == 23)
	{
		echo 60;
	}
	else if ($a == 37 && $b == 24)
	{
		echo 61;
	}
	else if ($a == 37 && $b == 25)
	{
		echo 62;
	}
	else if ($a == 37 && $b == 26)
	{
		echo 63;
	}
	else if ($a == 37 && $b == 27)
	{
		echo 64;
	}
	else if ($a == 37 && $b == 28)
	{
		echo 65;
	}
	else if ($a == 37 && $b == 29)
	{
		echo 66;
	}
	else if ($a == 37 && $b == 30)
	{
		echo 67;
	}
	else if ($a == 37 && $b == 31)
	{
		echo 68;
	}
	else if ($a == 37 && $b == 32)
	{
		echo 69;
	}
	else if ($a == 37 && $b == 33)
	{
		echo 70;
	}
	else if ($a == 37 && $b == 34)
	{
		echo 71;
	}
	else if ($a == 37 && $b == 35)
	{
		echo 72;
	}
	else if ($a == 37 && $b == 36)
	{
		echo 73;
	}
	else if ($a == 37 && $b == 37)
	{
		echo 74;
	}
	else if ($a == 37 && $b == 38)
	{
		echo 75;
	}
	else if ($a == 37 && $b == 39)
	{
		echo 76;
	}
	else if ($a == 37 && $b == 40)
	{
		echo 77;
	}
	else if ($a == 37 && $b == 41)
	{
		echo 78;
	}
	else if ($a == 37 && $b == 42)
	{
		echo 79;
	}
	else if ($a == 37 && $b == 43)
	{
		echo 80;
	}
	else if ($a == 37 && $b == 44)
	{
		echo 81;
	}
	else if ($a == 37 && $b == 45)
	{
		echo 82;
	}
	else if ($a == 37 && $b == 46)
	{
		echo 83;
	}
	else if ($a == 37 && $b == 47)
	{
		echo 84;
	}
	else if ($a == 37 && $b == 48)
	{
		echo 85;
	}
	else if ($a == 37 && $b == 49)
	{
		echo 86;
	}
	else if ($a == 37 && $b == 50)
	{
		echo 87;
	}
	else if ($a == 38 && $b == 0)
	{
		echo 38;
	}
	else if ($a == 38 && $b == 1)
	{
		echo 39;
	}
	else if ($a == 38 && $b == 2)
	{
		echo 40;
	}
	else if ($a == 38 && $b == 3)
	{
		echo 41;
	}
	else if ($a == 38 && $b == 4)
	{
		echo 42;
	}
	else if ($a == 38 && $b == 5)
	{
		echo 43;
	}
	else if ($a == 38 && $b == 6)
	{
		echo 44;
	}
	else if ($a == 38 && $b == 7)
	{
		echo 45;
	}
	else if ($a == 38 && $b == 8)
	{
		echo 46;
	}
	else if ($a == 38 && $b == 9)
	{
		echo 47;
	}
	else if ($a == 38 && $b == 10)
	{
		echo 48;
	}
	else if ($a == 38 && $b == 11)
	{
		echo 49;
	}
	else if ($a == 38 && $b == 12)
	{
		echo 50;
	}
	else if ($a == 38 && $b == 13)
	{
		echo 51;
	}
	else if ($a == 38 && $b == 14)
	{
		echo 52;
	}
	else if ($a == 38 && $b == 15)
	{
		echo 53;
	}
	else if ($a == 38 && $b == 16)
	{
		echo 54;
	}
	else if ($a == 38 && $b == 17)
	{
		echo 55;
	}
	else if ($a == 38 && $b == 18)
	{
		echo 56;
	}
	else if ($a == 38 && $b == 19)
	{
		echo 57;
	}
	else if ($a == 38 && $b == 20)
	{
		echo 58;
	}
	else if ($a == 38 && $b == 21)
	{
		echo 59;
	}
	else if ($a == 38 && $b == 22)
	{
		echo 60;
	}
	else if ($a == 38 && $b == 23)
	{
		echo 61;
	}
	else if ($a == 38 && $b == 24)
	{
		echo 62;
	}
	else if ($a == 38 && $b == 25)
	{
		echo 63;
	}
	else if ($a == 38 && $b == 26)
	{
		echo 64;
	}
	else if ($a == 38 && $b == 27)
	{
		echo 65;
	}
	else if ($a == 38 && $b == 28)
	{
		echo 66;
	}
	else if ($a == 38 && $b == 29)
	{
		echo 67;
	}
	else if ($a == 38 && $b == 30)
	{
		echo 68;
	}
	else if ($a == 38 && $b == 31)
	{
		echo 69;
	}
	else if ($a == 38 && $b == 32)
	{
		echo 70;
	}
	else if ($a == 38 && $b == 33)
	{
		echo 71;
	}
	else if ($a == 38 && $b == 34)
	{
		echo 72;
	}
	else if ($a == 38 && $b == 35)
	{
		echo 73;
	}
	else if ($a == 38 && $b == 36)
	{
		echo 74;
	}
	else if ($a == 38 && $b == 37)
	{
		echo 75;
	}
	else if ($a == 38 && $b == 38)
	{
		echo 76;
	}
	else if ($a == 38 && $b == 39)
	{
		echo 77;
	}
	else if ($a == 38 && $b == 40)
	{
		echo 78;
	}
	else if ($a == 38 && $b == 41)
	{
		echo 79;
	}
	else if ($a == 38 && $b == 42)
	{
		echo 80;
	}
	else if ($a == 38 && $b == 43)
	{
		echo 81;
	}
	else if ($a == 38 && $b == 44)
	{
		echo 82;
	}
	else if ($a == 38 && $b == 45)
	{
		echo 83;
	}
	else if ($a == 38 && $b == 46)
	{
		echo 84;
	}
	else if ($a == 38 && $b == 47)
	{
		echo 85;
	}
	else if ($a == 38 && $b == 48)
	{
		echo 86;
	}
	else if ($a == 38 && $b == 49)
	{
		echo 87;
	}
	else if ($a == 38 && $b == 50)
	{
		echo 88;
	}
	else if ($a == 39 && $b == 0)
	{
		echo 39;
	}
	else if ($a == 39 && $b == 1)
	{
		echo 40;
	}
	else if ($a == 39 && $b == 2)
	{
		echo 41;
	}
	else if ($a == 39 && $b == 3)
	{
		echo 42;
	}
	else if ($a == 39 && $b == 4)
	{
		echo 43;
	}
	else if ($a == 39 && $b == 5)
	{
		echo 44;
	}
	else if ($a == 39 && $b == 6)
	{
		echo 45;
	}
	else if ($a == 39 && $b == 7)
	{
		echo 46;
	}
	else if ($a == 39 && $b == 8)
	{
		echo 47;
	}
	else if ($a == 39 && $b == 9)
	{
		echo 48;
	}
	else if ($a == 39 && $b == 10)
	{
		echo 49;
	}
	else if ($a == 39 && $b == 11)
	{
		echo 50;
	}
	else if ($a == 39 && $b == 12)
	{
		echo 51;
	}
	else if ($a == 39 && $b == 13)
	{
		echo 52;
	}
	else if ($a == 39 && $b == 14)
	{
		echo 53;
	}
	else if ($a == 39 && $b == 15)
	{
		echo 54;
	}
	else if ($a == 39 && $b == 16)
	{
		echo 55;
	}
	else if ($a == 39 && $b == 17)
	{
		echo 56;
	}
	else if ($a == 39 && $b == 18)
	{
		echo 57;
	}
	else if ($a == 39 && $b == 19)
	{
		echo 58;
	}
	else if ($a == 39 && $b == 20)
	{
		echo 59;
	}
	else if ($a == 39 && $b == 21)
	{
		echo 60;
	}
	else if ($a == 39 && $b == 22)
	{
		echo 61;
	}
	else if ($a == 39 && $b == 23)
	{
		echo 62;
	}
	else if ($a == 39 && $b == 24)
	{
		echo 63;
	}
	else if ($a == 39 && $b == 25)
	{
		echo 64;
	}
	else if ($a == 39 && $b == 26)
	{
		echo 65;
	}
	else if ($a == 39 && $b == 27)
	{
		echo 66;
	}
	else if ($a == 39 && $b == 28)
	{
		echo 67;
	}
	else if ($a == 39 && $b == 29)
	{
		echo 68;
	}
	else if ($a == 39 && $b == 30)
	{
		echo 69;
	}
	else if ($a == 39 && $b == 31)
	{
		echo 70;
	}
	else if ($a == 39 && $b == 32)
	{
		echo 71;
	}
	else if ($a == 39 && $b == 33)
	{
		echo 72;
	}
	else if ($a == 39 && $b == 34)
	{
		echo 73;
	}
	else if ($a == 39 && $b == 35)
	{
		echo 74;
	}
	else if ($a == 39 && $b == 36)
	{
		echo 75;
	}
	else if ($a == 39 && $b == 37)
	{
		echo 76;
	}
	else if ($a == 39 && $b == 38)
	{
		echo 77;
	}
	else if ($a == 39 && $b == 39)
	{
		echo 78;
	}
	else if ($a == 39 && $b == 40)
	{
		echo 79;
	}
	else if ($a == 39 && $b == 41)
	{
		echo 80;
	}
	else if ($a == 39 && $b == 42)
	{
		echo 81;
	}
	else if ($a == 39 && $b == 43)
	{
		echo 82;
	}
	else if ($a == 39 && $b == 44)
	{
		echo 83;
	}
	else if ($a == 39 && $b == 45)
	{
		echo 84;
	}
	else if ($a == 39 && $b == 46)
	{
		echo 85;
	}
	else if ($a == 39 && $b == 47)
	{
		echo 86;
	}
	else if ($a == 39 && $b == 48)
	{
		echo 87;
	}
	else if ($a == 39 && $b == 49)
	{
		echo 88;
	}
	else if ($a == 39 && $b == 50)
	{
		echo 89;
	}
	else if ($a == 40 && $b == 0)
	{
		echo 40;
	}
	else if ($a == 40 && $b == 1)
	{
		echo 41;
	}
	else if ($a == 40 && $b == 2)
	{
		echo 42;
	}
	else if ($a == 40 && $b == 3)
	{
		echo 43;
	}
	else if ($a == 40 && $b == 4)
	{
		echo 44;
	}
	else if ($a == 40 && $b == 5)
	{
		echo 45;
	}
	else if ($a == 40 && $b == 6)
	{
		echo 46;
	}
	else if ($a == 40 && $b == 7)
	{
		echo 47;
	}
	else if ($a == 40 && $b == 8)
	{
		echo 48;
	}
	else if ($a == 40 && $b == 9)
	{
		echo 49;
	}
	else if ($a == 40 && $b == 10)
	{
		echo 50;
	}
	else if ($a == 40 && $b == 11)
	{
		echo 51;
	}
	else if ($a == 40 && $b == 12)
	{
		echo 52;
	}
	else if ($a == 40 && $b == 13)
	{
		echo 53;
	}
	else if ($a == 40 && $b == 14)
	{
		echo 54;
	}
	else if ($a == 40 && $b == 15)
	{
		echo 55;
	}
	else if ($a == 40 && $b == 16)
	{
		echo 56;
	}
	else if ($a == 40 && $b == 17)
	{
		echo 57;
	}
	else if ($a == 40 && $b == 18)
	{
		echo 58;
	}
	else if ($a == 40 && $b == 19)
	{
		echo 59;
	}
	else if ($a == 40 && $b == 20)
	{
		echo 60;
	}
	else if ($a == 40 && $b == 21)
	{
		echo 61;
	}
	else if ($a == 40 && $b == 22)
	{
		echo 62;
	}
	else if ($a == 40 && $b == 23)
	{
		echo 63;
	}
	else if ($a == 40 && $b == 24)
	{
		echo 64;
	}
	else if ($a == 40 && $b == 25)
	{
		echo 65;
	}
	else if ($a == 40 && $b == 26)
	{
		echo 66;
	}
	else if ($a == 40 && $b == 27)
	{
		echo 67;
	}
	else if ($a == 40 && $b == 28)
	{
		echo 68;
	}
	else if ($a == 40 && $b == 29)
	{
		echo 69;
	}
	else if ($a == 40 && $b == 30)
	{
		echo 70;
	}
	else if ($a == 40 && $b == 31)
	{
		echo 71;
	}
	else if ($a == 40 && $b == 32)
	{
		echo 72;
	}
	else if ($a == 40 && $b == 33)
	{
		echo 73;
	}
	else if ($a == 40 && $b == 34)
	{
		echo 74;
	}
	else if ($a == 40 && $b == 35)
	{
		echo 75;
	}
	else if ($a == 40 && $b == 36)
	{
		echo 76;
	}
	else if ($a == 40 && $b == 37)
	{
		echo 77;
	}
	else if ($a == 40 && $b == 38)
	{
		echo 78;
	}
	else if ($a == 40 && $b == 39)
	{
		echo 79;
	}
	else if ($a == 40 && $b == 40)
	{
		echo 80;
	}
	else if ($a == 40 && $b == 41)
	{
		echo 81;
	}
	else if ($a == 40 && $b == 42)
	{
		echo 82;
	}
	else if ($a == 40 && $b == 43)
	{
		echo 83;
	}
	else if ($a == 40 && $b == 44)
	{
		echo 84;
	}
	else if ($a == 40 && $b == 45)
	{
		echo 85;
	}
	else if ($a == 40 && $b == 46)
	{
		echo 86;
	}
	else if ($a == 40 && $b == 47)
	{
		echo 87;
	}
	else if ($a == 40 && $b == 48)
	{
		echo 88;
	}
	else if ($a == 40 && $b == 49)
	{
		echo 89;
	}
	else if ($a == 40 && $b == 50)
	{
		echo 90;
	}
	else if ($a == 41 && $b == 0)
	{
		echo 41;
	}
	else if ($a == 41 && $b == 1)
	{
		echo 42;
	}
	else if ($a == 41 && $b == 2)
	{
		echo 43;
	}
	else if ($a == 41 && $b == 3)
	{
		echo 44;
	}
	else if ($a == 41 && $b == 4)
	{
		echo 45;
	}
	else if ($a == 41 && $b == 5)
	{
		echo 46;
	}
	else if ($a == 41 && $b == 6)
	{
		echo 47;
	}
	else if ($a == 41 && $b == 7)
	{
		echo 48;
	}
	else if ($a == 41 && $b == 8)
	{
		echo 49;
	}
	else if ($a == 41 && $b == 9)
	{
		echo 50;
	}
	else if ($a == 41 && $b == 10)
	{
		echo 51;
	}
	else if ($a == 41 && $b == 11)
	{
		echo 52;
	}
	else if ($a == 41 && $b == 12)
	{
		echo 53;
	}
	else if ($a == 41 && $b == 13)
	{
		echo 54;
	}
	else if ($a == 41 && $b == 14)
	{
		echo 55;
	}
	else if ($a == 41 && $b == 15)
	{
		echo 56;
	}
	else if ($a == 41 && $b == 16)
	{
		echo 57;
	}
	else if ($a == 41 && $b == 17)
	{
		echo 58;
	}
	else if ($a == 41 && $b == 18)
	{
		echo 59;
	}
	else if ($a == 41 && $b == 19)
	{
		echo 60;
	}
	else if ($a == 41 && $b == 20)
	{
		echo 61;
	}
	else if ($a == 41 && $b == 21)
	{
		echo 62;
	}
	else if ($a == 41 && $b == 22)
	{
		echo 63;
	}
	else if ($a == 41 && $b == 23)
	{
		echo 64;
	}
	else if ($a == 41 && $b == 24)
	{
		echo 65;
	}
	else if ($a == 41 && $b == 25)
	{
		echo 66;
	}
	else if ($a == 41 && $b == 26)
	{
		echo 67;
	}
	else if ($a == 41 && $b == 27)
	{
		echo 68;
	}
	else if ($a == 41 && $b == 28)
	{
		echo 69;
	}
	else if ($a == 41 && $b == 29)
	{
		echo 70;
	}
	else if ($a == 41 && $b == 30)
	{
		echo 71;
	}
	else if ($a == 41 && $b == 31)
	{
		echo 72;
	}
	else if ($a == 41 && $b == 32)
	{
		echo 73;
	}
	else if ($a == 41 && $b == 33)
	{
		echo 74;
	}
	else if ($a == 41 && $b == 34)
	{
		echo 75;
	}
	else if ($a == 41 && $b == 35)
	{
		echo 76;
	}
	else if ($a == 41 && $b == 36)
	{
		echo 77;
	}
	else if ($a == 41 && $b == 37)
	{
		echo 78;
	}
	else if ($a == 41 && $b == 38)
	{
		echo 79;
	}
	else if ($a == 41 && $b == 39)
	{
		echo 80;
	}
	else if ($a == 41 && $b == 40)
	{
		echo 81;
	}
	else if ($a == 41 && $b == 41)
	{
		echo 82;
	}
	else if ($a == 41 && $b == 42)
	{
		echo 83;
	}
	else if ($a == 41 && $b == 43)
	{
		echo 84;
	}
	else if ($a == 41 && $b == 44)
	{
		echo 85;
	}
	else if ($a == 41 && $b == 45)
	{
		echo 86;
	}
	else if ($a == 41 && $b == 46)
	{
		echo 87;
	}
	else if ($a == 41 && $b == 47)
	{
		echo 88;
	}
	else if ($a == 41 && $b == 48)
	{
		echo 89;
	}
	else if ($a == 41 && $b == 49)
	{
		echo 90;
	}
	else if ($a == 41 && $b == 50)
	{
		echo 91;
	}
	else if ($a == 42 && $b == 0)
	{
		echo 42;
	}
	else if ($a == 42 && $b == 1)
	{
		echo 43;
	}
	else if ($a == 42 && $b == 2)
	{
		echo 44;
	}
	else if ($a == 42 && $b == 3)
	{
		echo 45;
	}
	else if ($a == 42 && $b == 4)
	{
		echo 46;
	}
	else if ($a == 42 && $b == 5)
	{
		echo 47;
	}
	else if ($a == 42 && $b == 6)
	{
		echo 48;
	}
	else if ($a == 42 && $b == 7)
	{
		echo 49;
	}
	else if ($a == 42 && $b == 8)
	{
		echo 50;
	}
	else if ($a == 42 && $b == 9)
	{
		echo 51;
	}
	else if ($a == 42 && $b == 10)
	{
		echo 52;
	}
	else if ($a == 42 && $b == 11)
	{
		echo 53;
	}
	else if ($a == 42 && $b == 12)
	{
		echo 54;
	}
	else if ($a == 42 && $b == 13)
	{
		echo 55;
	}
	else if ($a == 42 && $b == 14)
	{
		echo 56;
	}
	else if ($a == 42 && $b == 15)
	{
		echo 57;
	}
	else if ($a == 42 && $b == 16)
	{
		echo 58;
	}
	else if ($a == 42 && $b == 17)
	{
		echo 59;
	}
	else if ($a == 42 && $b == 18)
	{
		echo 60;
	}
	else if ($a == 42 && $b == 19)
	{
		echo 61;
	}
	else if ($a == 42 && $b == 20)
	{
		echo 62;
	}
	else if ($a == 42 && $b == 21)
	{
		echo 63;
	}
	else if ($a == 42 && $b == 22)
	{
		echo 64;
	}
	else if ($a == 42 && $b == 23)
	{
		echo 65;
	}
	else if ($a == 42 && $b == 24)
	{
		echo 66;
	}
	else if ($a == 42 && $b == 25)
	{
		echo 67;
	}
	else if ($a == 42 && $b == 26)
	{
		echo 68;
	}
	else if ($a == 42 && $b == 27)
	{
		echo 69;
	}
	else if ($a == 42 && $b == 28)
	{
		echo 70;
	}
	else if ($a == 42 && $b == 29)
	{
		echo 71;
	}
	else if ($a == 42 && $b == 30)
	{
		echo 72;
	}
	else if ($a == 42 && $b == 31)
	{
		echo 73;
	}
	else if ($a == 42 && $b == 32)
	{
		echo 74;
	}
	else if ($a == 42 && $b == 33)
	{
		echo 75;
	}
	else if ($a == 42 && $b == 34)
	{
		echo 76;
	}
	else if ($a == 42 && $b == 35)
	{
		echo 77;
	}
	else if ($a == 42 && $b == 36)
	{
		echo 78;
	}
	else if ($a == 42 && $b == 37)
	{
		echo 79;
	}
	else if ($a == 42 && $b == 38)
	{
		echo 80;
	}
	else if ($a == 42 && $b == 39)
	{
		echo 81;
	}
	else if ($a == 42 && $b == 40)
	{
		echo 82;
	}
	else if ($a == 42 && $b == 41)
	{
		echo 83;
	}
	else if ($a == 42 && $b == 42)
	{
		echo 84;
	}
	else if ($a == 42 && $b == 43)
	{
		echo 85;
	}
	else if ($a == 42 && $b == 44)
	{
		echo 86;
	}
	else if ($a == 42 && $b == 45)
	{
		echo 87;
	}
	else if ($a == 42 && $b == 46)
	{
		echo 88;
	}
	else if ($a == 42 && $b == 47)
	{
		echo 89;
	}
	else if ($a == 42 && $b == 48)
	{
		echo 90;
	}
	else if ($a == 42 && $b == 49)
	{
		echo 91;
	}
	else if ($a == 42 && $b == 50)
	{
		echo 92;
	}
	else if ($a == 43 && $b == 0)
	{
		echo 43;
	}
	else if ($a == 43 && $b == 1)
	{
		echo 44;
	}
	else if ($a == 43 && $b == 2)
	{
		echo 45;
	}
	else if ($a == 43 && $b == 3)
	{
		echo 46;
	}
	else if ($a == 43 && $b == 4)
	{
		echo 47;
	}
	else if ($a == 43 && $b == 5)
	{
		echo 48;
	}
	else if ($a == 43 && $b == 6)
	{
		echo 49;
	}
	else if ($a == 43 && $b == 7)
	{
		echo 50;
	}
	else if ($a == 43 && $b == 8)
	{
		echo 51;
	}
	else if ($a == 43 && $b == 9)
	{
		echo 52;
	}
	else if ($a == 43 && $b == 10)
	{
		echo 53;
	}
	else if ($a == 43 && $b == 11)
	{
		echo 54;
	}
	else if ($a == 43 && $b == 12)
	{
		echo 55;
	}
	else if ($a == 43 && $b == 13)
	{
		echo 56;
	}
	else if ($a == 43 && $b == 14)
	{
		echo 57;
	}
	else if ($a == 43 && $b == 15)
	{
		echo 58;
	}
	else if ($a == 43 && $b == 16)
	{
		echo 59;
	}
	else if ($a == 43 && $b == 17)
	{
		echo 60;
	}
	else if ($a == 43 && $b == 18)
	{
		echo 61;
	}
	else if ($a == 43 && $b == 19)
	{
		echo 62;
	}
	else if ($a == 43 && $b == 20)
	{
		echo 63;
	}
	else if ($a == 43 && $b == 21)
	{
		echo 64;
	}
	else if ($a == 43 && $b == 22)
	{
		echo 65;
	}
	else if ($a == 43 && $b == 23)
	{
		echo 66;
	}
	else if ($a == 43 && $b == 24)
	{
		echo 67;
	}
	else if ($a == 43 && $b == 25)
	{
		echo 68;
	}
	else if ($a == 43 && $b == 26)
	{
		echo 69;
	}
	else if ($a == 43 && $b == 27)
	{
		echo 70;
	}
	else if ($a == 43 && $b == 28)
	{
		echo 71;
	}
	else if ($a == 43 && $b == 29)
	{
		echo 72;
	}
	else if ($a == 43 && $b == 30)
	{
		echo 73;
	}
	else if ($a == 43 && $b == 31)
	{
		echo 74;
	}
	else if ($a == 43 && $b == 32)
	{
		echo 75;
	}
	else if ($a == 43 && $b == 33)
	{
		echo 76;
	}
	else if ($a == 43 && $b == 34)
	{
		echo 77;
	}
	else if ($a == 43 && $b == 35)
	{
		echo 78;
	}
	else if ($a == 43 && $b == 36)
	{
		echo 79;
	}
	else if ($a == 43 && $b == 37)
	{
		echo 80;
	}
	else if ($a == 43 && $b == 38)
	{
		echo 81;
	}
	else if ($a == 43 && $b == 39)
	{
		echo 82;
	}
	else if ($a == 43 && $b == 40)
	{
		echo 83;
	}
	else if ($a == 43 && $b == 41)
	{
		echo 84;
	}
	else if ($a == 43 && $b == 42)
	{
		echo 85;
	}
	else if ($a == 43 && $b == 43)
	{
		echo 86;
	}
	else if ($a == 43 && $b == 44)
	{
		echo 87;
	}
	else if ($a == 43 && $b == 45)
	{
		echo 88;
	}
	else if ($a == 43 && $b == 46)
	{
		echo 89;
	}
	else if ($a == 43 && $b == 47)
	{
		echo 90;
	}
	else if ($a == 43 && $b == 48)
	{
		echo 91;
	}
	else if ($a == 43 && $b == 49)
	{
		echo 92;
	}
	else if ($a == 43 && $b == 50)
	{
		echo 93;
	}
	else if ($a == 44 && $b == 0)
	{
		echo 44;
	}
	else if ($a == 44 && $b == 1)
	{
		echo 45;
	}
	else if ($a == 44 && $b == 2)
	{
		echo 46;
	}
	else if ($a == 44 && $b == 3)
	{
		echo 47;
	}
	else if ($a == 44 && $b == 4)
	{
		echo 48;
	}
	else if ($a == 44 && $b == 5)
	{
		echo 49;
	}
	else if ($a == 44 && $b == 6)
	{
		echo 50;
	}
	else if ($a == 44 && $b == 7)
	{
		echo 51;
	}
	else if ($a == 44 && $b == 8)
	{
		echo 52;
	}
	else if ($a == 44 && $b == 9)
	{
		echo 53;
	}
	else if ($a == 44 && $b == 10)
	{
		echo 54;
	}
	else if ($a == 44 && $b == 11)
	{
		echo 55;
	}
	else if ($a == 44 && $b == 12)
	{
		echo 56;
	}
	else if ($a == 44 && $b == 13)
	{
		echo 57;
	}
	else if ($a == 44 && $b == 14)
	{
		echo 58;
	}
	else if ($a == 44 && $b == 15)
	{
		echo 59;
	}
	else if ($a == 44 && $b == 16)
	{
		echo 60;
	}
	else if ($a == 44 && $b == 17)
	{
		echo 61;
	}
	else if ($a == 44 && $b == 18)
	{
		echo 62;
	}
	else if ($a == 44 && $b == 19)
	{
		echo 63;
	}
	else if ($a == 44 && $b == 20)
	{
		echo 64;
	}
	else if ($a == 44 && $b == 21)
	{
		echo 65;
	}
	else if ($a == 44 && $b == 22)
	{
		echo 66;
	}
	else if ($a == 44 && $b == 23)
	{
		echo 67;
	}
	else if ($a == 44 && $b == 24)
	{
		echo 68;
	}
	else if ($a == 44 && $b == 25)
	{
		echo 69;
	}
	else if ($a == 44 && $b == 26)
	{
		echo 70;
	}
	else if ($a == 44 && $b == 27)
	{
		echo 71;
	}
	else if ($a == 44 && $b == 28)
	{
		echo 72;
	}
	else if ($a == 44 && $b == 29)
	{
		echo 73;
	}
	else if ($a == 44 && $b == 30)
	{
		echo 74;
	}
	else if ($a == 44 && $b == 31)
	{
		echo 75;
	}
	else if ($a == 44 && $b == 32)
	{
		echo 76;
	}
	else if ($a == 44 && $b == 33)
	{
		echo 77;
	}
	else if ($a == 44 && $b == 34)
	{
		echo 78;
	}
	else if ($a == 44 && $b == 35)
	{
		echo 79;
	}
	else if ($a == 44 && $b == 36)
	{
		echo 80;
	}
	else if ($a == 44 && $b == 37)
	{
		echo 81;
	}
	else if ($a == 44 && $b == 38)
	{
		echo 82;
	}
	else if ($a == 44 && $b == 39)
	{
		echo 83;
	}
	else if ($a == 44 && $b == 40)
	{
		echo 84;
	}
	else if ($a == 44 && $b == 41)
	{
		echo 85;
	}
	else if ($a == 44 && $b == 42)
	{
		echo 86;
	}
	else if ($a == 44 && $b == 43)
	{
		echo 87;
	}
	else if ($a == 44 && $b == 44)
	{
		echo 88;
	}
	else if ($a == 44 && $b == 45)
	{
		echo 89;
	}
	else if ($a == 44 && $b == 46)
	{
		echo 90;
	}
	else if ($a == 44 && $b == 47)
	{
		echo 91;
	}
	else if ($a == 44 && $b == 48)
	{
		echo 92;
	}
	else if ($a == 44 && $b == 49)
	{
		echo 93;
	}
	else if ($a == 44 && $b == 50)
	{
		echo 94;
	}
	else if ($a == 45 && $b == 0)
	{
		echo 45;
	}
	else if ($a == 45 && $b == 1)
	{
		echo 46;
	}
	else if ($a == 45 && $b == 2)
	{
		echo 47;
	}
	else if ($a == 45 && $b == 3)
	{
		echo 48;
	}
	else if ($a == 45 && $b == 4)
	{
		echo 49;
	}
	else if ($a == 45 && $b == 5)
	{
		echo 50;
	}
	else if ($a == 45 && $b == 6)
	{
		echo 51;
	}
	else if ($a == 45 && $b == 7)
	{
		echo 52;
	}
	else if ($a == 45 && $b == 8)
	{
		echo 53;
	}
	else if ($a == 45 && $b == 9)
	{
		echo 54;
	}
	else if ($a == 45 && $b == 10)
	{
		echo 55;
	}
	else if ($a == 45 && $b == 11)
	{
		echo 56;
	}
	else if ($a == 45 && $b == 12)
	{
		echo 57;
	}
	else if ($a == 45 && $b == 13)
	{
		echo 58;
	}
	else if ($a == 45 && $b == 14)
	{
		echo 59;
	}
	else if ($a == 45 && $b == 15)
	{
		echo 60;
	}
	else if ($a == 45 && $b == 16)
	{
		echo 61;
	}
	else if ($a == 45 && $b == 17)
	{
		echo 62;
	}
	else if ($a == 45 && $b == 18)
	{
		echo 63;
	}
	else if ($a == 45 && $b == 19)
	{
		echo 64;
	}
	else if ($a == 45 && $b == 20)
	{
		echo 65;
	}
	else if ($a == 45 && $b == 21)
	{
		echo 66;
	}
	else if ($a == 45 && $b == 22)
	{
		echo 67;
	}
	else if ($a == 45 && $b == 23)
	{
		echo 68;
	}
	else if ($a == 45 && $b == 24)
	{
		echo 69;
	}
	else if ($a == 45 && $b == 25)
	{
		echo 70;
	}
	else if ($a == 45 && $b == 26)
	{
		echo 71;
	}
	else if ($a == 45 && $b == 27)
	{
		echo 72;
	}
	else if ($a == 45 && $b == 28)
	{
		echo 73;
	}
	else if ($a == 45 && $b == 29)
	{
		echo 74;
	}
	else if ($a == 45 && $b == 30)
	{
		echo 75;
	}
	else if ($a == 45 && $b == 31)
	{
		echo 76;
	}
	else if ($a == 45 && $b == 32)
	{
		echo 77;
	}
	else if ($a == 45 && $b == 33)
	{
		echo 78;
	}
	else if ($a == 45 && $b == 34)
	{
		echo 79;
	}
	else if ($a == 45 && $b == 35)
	{
		echo 80;
	}
	else if ($a == 45 && $b == 36)
	{
		echo 81;
	}
	else if ($a == 45 && $b == 37)
	{
		echo 82;
	}
	else if ($a == 45 && $b == 38)
	{
		echo 83;
	}
	else if ($a == 45 && $b == 39)
	{
		echo 84;
	}
	else if ($a == 45 && $b == 40)
	{
		echo 85;
	}
	else if ($a == 45 && $b == 41)
	{
		echo 86;
	}
	else if ($a == 45 && $b == 42)
	{
		echo 87;
	}
	else if ($a == 45 && $b == 43)
	{
		echo 88;
	}
	else if ($a == 45 && $b == 44)
	{
		echo 89;
	}
	else if ($a == 45 && $b == 45)
	{
		echo 90;
	}
	else if ($a == 45 && $b == 46)
	{
		echo 91;
	}
	else if ($a == 45 && $b == 47)
	{
		echo 92;
	}
	else if ($a == 45 && $b == 48)
	{
		echo 93;
	}
	else if ($a == 45 && $b == 49)
	{
		echo 94;
	}
	else if ($a == 45 && $b == 50)
	{
		echo 95;
	}
	else if ($a == 46 && $b == 0)
	{
		echo 46;
	}
	else if ($a == 46 && $b == 1)
	{
		echo 47;
	}
	else if ($a == 46 && $b == 2)
	{
		echo 48;
	}
	else if ($a == 46 && $b == 3)
	{
		echo 49;
	}
	else if ($a == 46 && $b == 4)
	{
		echo 50;
	}
	else if ($a == 46 && $b == 5)
	{
		echo 51;
	}
	else if ($a == 46 && $b == 6)
	{
		echo 52;
	}
	else if ($a == 46 && $b == 7)
	{
		echo 53;
	}
	else if ($a == 46 && $b == 8)
	{
		echo 54;
	}
	else if ($a == 46 && $b == 9)
	{
		echo 55;
	}
	else if ($a == 46 && $b == 10)
	{
		echo 56;
	}
	else if ($a == 46 && $b == 11)
	{
		echo 57;
	}
	else if ($a == 46 && $b == 12)
	{
		echo 58;
	}
	else if ($a == 46 && $b == 13)
	{
		echo 59;
	}
	else if ($a == 46 && $b == 14)
	{
		echo 60;
	}
	else if ($a == 46 && $b == 15)
	{
		echo 61;
	}
	else if ($a == 46 && $b == 16)
	{
		echo 62;
	}
	else if ($a == 46 && $b == 17)
	{
		echo 63;
	}
	else if ($a == 46 && $b == 18)
	{
		echo 64;
	}
	else if ($a == 46 && $b == 19)
	{
		echo 65;
	}
	else if ($a == 46 && $b == 20)
	{
		echo 66;
	}
	else if ($a == 46 && $b == 21)
	{
		echo 67;
	}
	else if ($a == 46 && $b == 22)
	{
		echo 68;
	}
	else if ($a == 46 && $b == 23)
	{
		echo 69;
	}
	else if ($a == 46 && $b == 24)
	{
		echo 70;
	}
	else if ($a == 46 && $b == 25)
	{
		echo 71;
	}
	else if ($a == 46 && $b == 26)
	{
		echo 72;
	}
	else if ($a == 46 && $b == 27)
	{
		echo 73;
	}
	else if ($a == 46 && $b == 28)
	{
		echo 74;
	}
	else if ($a == 46 && $b == 29)
	{
		echo 75;
	}
	else if ($a == 46 && $b == 30)
	{
		echo 76;
	}
	else if ($a == 46 && $b == 31)
	{
		echo 77;
	}
	else if ($a == 46 && $b == 32)
	{
		echo 78;
	}
	else if ($a == 46 && $b == 33)
	{
		echo 79;
	}
	else if ($a == 46 && $b == 34)
	{
		echo 80;
	}
	else if ($a == 46 && $b == 35)
	{
		echo 81;
	}
	else if ($a == 46 && $b == 36)
	{
		echo 82;
	}
	else if ($a == 46 && $b == 37)
	{
		echo 83;
	}
	else if ($a == 46 && $b == 38)
	{
		echo 84;
	}
	else if ($a == 46 && $b == 39)
	{
		echo 85;
	}
	else if ($a == 46 && $b == 40)
	{
		echo 86;
	}
	else if ($a == 46 && $b == 41)
	{
		echo 87;
	}
	else if ($a == 46 && $b == 42)
	{
		echo 88;
	}
	else if ($a == 46 && $b == 43)
	{
		echo 89;
	}
	else if ($a == 46 && $b == 44)
	{
		echo 90;
	}
	else if ($a == 46 && $b == 45)
	{
		echo 91;
	}
	else if ($a == 46 && $b == 46)
	{
		echo 92;
	}
	else if ($a == 46 && $b == 47)
	{
		echo 93;
	}
	else if ($a == 46 && $b == 48)
	{
		echo 94;
	}
	else if ($a == 46 && $b == 49)
	{
		echo 95;
	}
	else if ($a == 46 && $b == 50)
	{
		echo 96;
	}
	else if ($a == 47 && $b == 0)
	{
		echo 47;
	}
	else if ($a == 47 && $b == 1)
	{
		echo 48;
	}
	else if ($a == 47 && $b == 2)
	{
		echo 49;
	}
	else if ($a == 47 && $b == 3)
	{
		echo 50;
	}
	else if ($a == 47 && $b == 4)
	{
		echo 51;
	}
	else if ($a == 47 && $b == 5)
	{
		echo 52;
	}
	else if ($a == 47 && $b == 6)
	{
		echo 53;
	}
	else if ($a == 47 && $b == 7)
	{
		echo 54;
	}
	else if ($a == 47 && $b == 8)
	{
		echo 55;
	}
	else if ($a == 47 && $b == 9)
	{
		echo 56;
	}
	else if ($a == 47 && $b == 10)
	{
		echo 57;
	}
	else if ($a == 47 && $b == 11)
	{
		echo 58;
	}
	else if ($a == 47 && $b == 12)
	{
		echo 59;
	}
	else if ($a == 47 && $b == 13)
	{
		echo 60;
	}
	else if ($a == 47 && $b == 14)
	{
		echo 61;
	}
	else if ($a == 47 && $b == 15)
	{
		echo 62;
	}
	else if ($a == 47 && $b == 16)
	{
		echo 63;
	}
	else if ($a == 47 && $b == 17)
	{
		echo 64;
	}
	else if ($a == 47 && $b == 18)
	{
		echo 65;
	}
	else if ($a == 47 && $b == 19)
	{
		echo 66;
	}
	else if ($a == 47 && $b == 20)
	{
		echo 67;
	}
	else if ($a == 47 && $b == 21)
	{
		echo 68;
	}
	else if ($a == 47 && $b == 22)
	{
		echo 69;
	}
	else if ($a == 47 && $b == 23)
	{
		echo 70;
	}
	else if ($a == 47 && $b == 24)
	{
		echo 71;
	}
	else if ($a == 47 && $b == 25)
	{
		echo 72;
	}
	else if ($a == 47 && $b == 26)
	{
		echo 73;
	}
	else if ($a == 47 && $b == 27)
	{
		echo 74;
	}
	else if ($a == 47 && $b == 28)
	{
		echo 75;
	}
	else if ($a == 47 && $b == 29)
	{
		echo 76;
	}
	else if ($a == 47 && $b == 30)
	{
		echo 77;
	}
	else if ($a == 47 && $b == 31)
	{
		echo 78;
	}
	else if ($a == 47 && $b == 32)
	{
		echo 79;
	}
	else if ($a == 47 && $b == 33)
	{
		echo 80;
	}
	else if ($a == 47 && $b == 34)
	{
		echo 81;
	}
	else if ($a == 47 && $b == 35)
	{
		echo 82;
	}
	else if ($a == 47 && $b == 36)
	{
		echo 83;
	}
	else if ($a == 47 && $b == 37)
	{
		echo 84;
	}
	else if ($a == 47 && $b == 38)
	{
		echo 85;
	}
	else if ($a == 47 && $b == 39)
	{
		echo 86;
	}
	else if ($a == 47 && $b == 40)
	{
		echo 87;
	}
	else if ($a == 47 && $b == 41)
	{
		echo 88;
	}
	else if ($a == 47 && $b == 42)
	{
		echo 89;
	}
	else if ($a == 47 && $b == 43)
	{
		echo 90;
	}
	else if ($a == 47 && $b == 44)
	{
		echo 91;
	}
	else if ($a == 47 && $b == 45)
	{
		echo 92;
	}
	else if ($a == 47 && $b == 46)
	{
		echo 93;
	}
	else if ($a == 47 && $b == 47)
	{
		echo 94;
	}
	else if ($a == 47 && $b == 48)
	{
		echo 95;
	}
	else if ($a == 47 && $b == 49)
	{
		echo 96;
	}
	else if ($a == 47 && $b == 50)
	{
		echo 97;
	}
	else if ($a == 48 && $b == 0)
	{
		echo 48;
	}
	else if ($a == 48 && $b == 1)
	{
		echo 49;
	}
	else if ($a == 48 && $b == 2)
	{
		echo 50;
	}
	else if ($a == 48 && $b == 3)
	{
		echo 51;
	}
	else if ($a == 48 && $b == 4)
	{
		echo 52;
	}
	else if ($a == 48 && $b == 5)
	{
		echo 53;
	}
	else if ($a == 48 && $b == 6)
	{
		echo 54;
	}
	else if ($a == 48 && $b == 7)
	{
		echo 55;
	}
	else if ($a == 48 && $b == 8)
	{
		echo 56;
	}
	else if ($a == 48 && $b == 9)
	{
		echo 57;
	}
	else if ($a == 48 && $b == 10)
	{
		echo 58;
	}
	else if ($a == 48 && $b == 11)
	{
		echo 59;
	}
	else if ($a == 48 && $b == 12)
	{
		echo 60;
	}
	else if ($a == 48 && $b == 13)
	{
		echo 61;
	}
	else if ($a == 48 && $b == 14)
	{
		echo 62;
	}
	else if ($a == 48 && $b == 15)
	{
		echo 63;
	}
	else if ($a == 48 && $b == 16)
	{
		echo 64;
	}
	else if ($a == 48 && $b == 17)
	{
		echo 65;
	}
	else if ($a == 48 && $b == 18)
	{
		echo 66;
	}
	else if ($a == 48 && $b == 19)
	{
		echo 67;
	}
	else if ($a == 48 && $b == 20)
	{
		echo 68;
	}
	else if ($a == 48 && $b == 21)
	{
		echo 69;
	}
	else if ($a == 48 && $b == 22)
	{
		echo 70;
	}
	else if ($a == 48 && $b == 23)
	{
		echo 71;
	}
	else if ($a == 48 && $b == 24)
	{
		echo 72;
	}
	else if ($a == 48 && $b == 25)
	{
		echo 73;
	}
	else if ($a == 48 && $b == 26)
	{
		echo 74;
	}
	else if ($a == 48 && $b == 27)
	{
		echo 75;
	}
	else if ($a == 48 && $b == 28)
	{
		echo 76;
	}
	else if ($a == 48 && $b == 29)
	{
		echo 77;
	}
	else if ($a == 48 && $b == 30)
	{
		echo 78;
	}
	else if ($a == 48 && $b == 31)
	{
		echo 79;
	}
	else if ($a == 48 && $b == 32)
	{
		echo 80;
	}
	else if ($a == 48 && $b == 33)
	{
		echo 81;
	}
	else if ($a == 48 && $b == 34)
	{
		echo 82;
	}
	else if ($a == 48 && $b == 35)
	{
		echo 83;
	}
	else if ($a == 48 && $b == 36)
	{
		echo 84;
	}
	else if ($a == 48 && $b == 37)
	{
		echo 85;
	}
	else if ($a == 48 && $b == 38)
	{
		echo 86;
	}
	else if ($a == 48 && $b == 39)
	{
		echo 87;
	}
	else if ($a == 48 && $b == 40)
	{
		echo 88;
	}
	else if ($a == 48 && $b == 41)
	{
		echo 89;
	}
	else if ($a == 48 && $b == 42)
	{
		echo 90;
	}
	else if ($a == 48 && $b == 43)
	{
		echo 91;
	}
	else if ($a == 48 && $b == 44)
	{
		echo 92;
	}
	else if ($a == 48 && $b == 45)
	{
		echo 93;
	}
	else if ($a == 48 && $b == 46)
	{
		echo 94;
	}
	else if ($a == 48 && $b == 47)
	{
		echo 95;
	}
	else if ($a == 48 && $b == 48)
	{
		echo 96;
	}
	else if ($a == 48 && $b == 49)
	{
		echo 97;
	}
	else if ($a == 48 && $b == 50)
	{
		echo 98;
	}
	else if ($a == 49 && $b == 0)
	{
		echo 49;
	}
	else if ($a == 49 && $b == 1)
	{
		echo 50;
	}
	else if ($a == 49 && $b == 2)
	{
		echo 51;
	}
	else if ($a == 49 && $b == 3)
	{
		echo 52;
	}
	else if ($a == 49 && $b == 4)
	{
		echo 53;
	}
	else if ($a == 49 && $b == 5)
	{
		echo 54;
	}
	else if ($a == 49 && $b == 6)
	{
		echo 55;
	}
	else if ($a == 49 && $b == 7)
	{
		echo 56;
	}
	else if ($a == 49 && $b == 8)
	{
		echo 57;
	}
	else if ($a == 49 && $b == 9)
	{
		echo 58;
	}
	else if ($a == 49 && $b == 10)
	{
		echo 59;
	}
	else if ($a == 49 && $b == 11)
	{
		echo 60;
	}
	else if ($a == 49 && $b == 12)
	{
		echo 61;
	}
	else if ($a == 49 && $b == 13)
	{
		echo 62;
	}
	else if ($a == 49 && $b == 14)
	{
		echo 63;
	}
	else if ($a == 49 && $b == 15)
	{
		echo 64;
	}
	else if ($a == 49 && $b == 16)
	{
		echo 65;
	}
	else if ($a == 49 && $b == 17)
	{
		echo 66;
	}
	else if ($a == 49 && $b == 18)
	{
		echo 67;
	}
	else if ($a == 49 && $b == 19)
	{
		echo 68;
	}
	else if ($a == 49 && $b == 20)
	{
		echo 69;
	}
	else if ($a == 49 && $b == 21)
	{
		echo 70;
	}
	else if ($a == 49 && $b == 22)
	{
		echo 71;
	}
	else if ($a == 49 && $b == 23)
	{
		echo 72;
	}
	else if ($a == 49 && $b == 24)
	{
		echo 73;
	}
	else if ($a == 49 && $b == 25)
	{
		echo 74;
	}
	else if ($a == 49 && $b == 26)
	{
		echo 75;
	}
	else if ($a == 49 && $b == 27)
	{
		echo 76;
	}
	else if ($a == 49 && $b == 28)
	{
		echo 77;
	}
	else if ($a == 49 && $b == 29)
	{
		echo 78;
	}
	else if ($a == 49 && $b == 30)
	{
		echo 79;
	}
	else if ($a == 49 && $b == 31)
	{
		echo 80;
	}
	else if ($a == 49 && $b == 32)
	{
		echo 81;
	}
	else if ($a == 49 && $b == 33)
	{
		echo 82;
	}
	else if ($a == 49 && $b == 34)
	{
		echo 83;
	}
	else if ($a == 49 && $b == 35)
	{
		echo 84;
	}
	else if ($a == 49 && $b == 36)
	{
		echo 85;
	}
	else if ($a == 49 && $b == 37)
	{
		echo 86;
	}
	else if ($a == 49 && $b == 38)
	{
		echo 87;
	}
	else if ($a == 49 && $b == 39)
	{
		echo 88;
	}
	else if ($a == 49 && $b == 40)
	{
		echo 89;
	}
	else if ($a == 49 && $b == 41)
	{
		echo 90;
	}
	else if ($a == 49 && $b == 42)
	{
		echo 91;
	}
	else if ($a == 49 && $b == 43)
	{
		echo 92;
	}
	else if ($a == 49 && $b == 44)
	{
		echo 93;
	}
	else if ($a == 49 && $b == 45)
	{
		echo 94;
	}
	else if ($a == 49 && $b == 46)
	{
		echo 95;
	}
	else if ($a == 49 && $b == 47)
	{
		echo 96;
	}
	else if ($a == 49 && $b == 48)
	{
		echo 97;
	}
	else if ($a == 49 && $b == 49)
	{
		echo 98;
	}
	else if ($a == 49 && $b == 50)
	{
		echo 99;
	}
	else if ($a == 50 && $b == 0)
	{
		echo 50;
	}
	else if ($a == 50 && $b == 1)
	{
		echo 51;
	}
	else if ($a == 50 && $b == 2)
	{
		echo 52;
	}
	else if ($a == 50 && $b == 3)
	{
		echo 53;
	}
	else if ($a == 50 && $b == 4)
	{
		echo 54;
	}
	else if ($a == 50 && $b == 5)
	{
		echo 55;
	}
	else if ($a == 50 && $b == 6)
	{
		echo 56;
	}
	else if ($a == 50 && $b == 7)
	{
		echo 57;
	}
	else if ($a == 50 && $b == 8)
	{
		echo 58;
	}
	else if ($a == 50 && $b == 9)
	{
		echo 59;
	}
	else if ($a == 50 && $b == 10)
	{
		echo 60;
	}
	else if ($a == 50 && $b == 11)
	{
		echo 61;
	}
	else if ($a == 50 && $b == 12)
	{
		echo 62;
	}
	else if ($a == 50 && $b == 13)
	{
		echo 63;
	}
	else if ($a == 50 && $b == 14)
	{
		echo 64;
	}
	else if ($a == 50 && $b == 15)
	{
		echo 65;
	}
	else if ($a == 50 && $b == 16)
	{
		echo 66;
	}
	else if ($a == 50 && $b == 17)
	{
		echo 67;
	}
	else if ($a == 50 && $b == 18)
	{
		echo 68;
	}
	else if ($a == 50 && $b == 19)
	{
		echo 69;
	}
	else if ($a == 50 && $b == 20)
	{
		echo 70;
	}
	else if ($a == 50 && $b == 21)
	{
		echo 71;
	}
	else if ($a == 50 && $b == 22)
	{
		echo 72;
	}
	else if ($a == 50 && $b == 23)
	{
		echo 73;
	}
	else if ($a == 50 && $b == 24)
	{
		echo 74;
	}
	else if ($a == 50 && $b == 25)
	{
		echo 75;
	}
	else if ($a == 50 && $b == 26)
	{
		echo 76;
	}
	else if ($a == 50 && $b == 27)
	{
		echo 77;
	}
	else if ($a == 50 && $b == 28)
	{
		echo 78;
	}
	else if ($a == 50 && $b == 29)
	{
		echo 79;
	}
	else if ($a == 50 && $b == 30)
	{
		echo 80;
	}
	else if ($a == 50 && $b == 31)
	{
		echo 81;
	}
	else if ($a == 50 && $b == 32)
	{
		echo 82;
	}
	else if ($a == 50 && $b == 33)
	{
		echo 83;
	}
	else if ($a == 50 && $b == 34)
	{
		echo 84;
	}
	else if ($a == 50 && $b == 35)
	{
		echo 85;
	}
	else if ($a == 50 && $b == 36)
	{
		echo 86;
	}
	else if ($a == 50 && $b == 37)
	{
		echo 87;
	}
	else if ($a == 50 && $b == 38)
	{
		echo 88;
	}
	else if ($a == 50 && $b == 39)
	{
		echo 89;
	}
	else if ($a == 50 && $b == 40)
	{
		echo 90;
	}
	else if ($a == 50 && $b == 41)
	{
		echo 91;
	}
	else if ($a == 50 && $b == 42)
	{
		echo 92;
	}
	else if ($a == 50 && $b == 43)
	{
		echo 93;
	}
	else if ($a == 50 && $b == 44)
	{
		echo 94;
	}
	else if ($a == 50 && $b == 45)
	{
		echo 95;
	}
	else if ($a == 50 && $b == 46)
	{
		echo 96;
	}
	else if ($a == 50 && $b == 47)
	{
		echo 97;
	}
	else if ($a == 50 && $b == 48)
	{
		echo 98;
	}
	else if ($a == 50 && $b == 49)
	{
		echo 99;
	}
	else if ($a == 50 && $b == 50)
	{
		echo 100;
	}
	else
	{
		echo "Unsupported number given!";
	}
}

function subtract($a, $b)
{
	if ($a == 0 && $b == 0)
	{
		echo 0;
	}
	else if ($a == 0 && $b == 1)
	{
		echo -1;
	}
	else if ($a == 0 && $b == 2)
	{
		echo -2;
	}
	else if ($a == 0 && $b == 3)
	{
		echo -3;
	}
	else if ($a == 0 && $b == 4)
	{
		echo -4;
	}
	else if ($a == 0 && $b == 5)
	{
		echo -5;
	}
	else if ($a == 0 && $b == 6)
	{
		echo -6;
	}
	else if ($a == 0 && $b == 7)
	{
		echo -7;
	}
	else if ($a == 0 && $b == 8)
	{
		echo -8;
	}
	else if ($a == 0 && $b == 9)
	{
		echo -9;
	}
	else if ($a == 0 && $b == 10)
	{
		echo -10;
	}
	else if ($a == 0 && $b == 11)
	{
		echo -11;
	}
	else if ($a == 0 && $b == 12)
	{
		echo -12;
	}
	else if ($a == 0 && $b == 13)
	{
		echo -13;
	}
	else if ($a == 0 && $b == 14)
	{
		echo -14;
	}
	else if ($a == 0 && $b == 15)
	{
		echo -15;
	}
	else if ($a == 0 && $b == 16)
	{
		echo -16;
	}
	else if ($a == 0 && $b == 17)
	{
		echo -17;
	}
	else if ($a == 0 && $b == 18)
	{
		echo -18;
	}
	else if ($a == 0 && $b == 19)
	{
		echo -19;
	}
	else if ($a == 0 && $b == 20)
	{
		echo -20;
	}
	else if ($a == 0 && $b == 21)
	{
		echo -21;
	}
	else if ($a == 0 && $b == 22)
	{
		echo -22;
	}
	else if ($a == 0 && $b == 23)
	{
		echo -23;
	}
	else if ($a == 0 && $b == 24)
	{
		echo -24;
	}
	else if ($a == 0 && $b == 25)
	{
		echo -25;
	}
	else if ($a == 0 && $b == 26)
	{
		echo -26;
	}
	else if ($a == 0 && $b == 27)
	{
		echo -27;
	}
	else if ($a == 0 && $b == 28)
	{
		echo -28;
	}
	else if ($a == 0 && $b == 29)
	{
		echo -29;
	}
	else if ($a == 0 && $b == 30)
	{
		echo -30;
	}
	else if ($a == 0 && $b == 31)
	{
		echo -31;
	}
	else if ($a == 0 && $b == 32)
	{
		echo -32;
	}
	else if ($a == 0 && $b == 33)
	{
		echo -33;
	}
	else if ($a == 0 && $b == 34)
	{
		echo -34;
	}
	else if ($a == 0 && $b == 35)
	{
		echo -35;
	}
	else if ($a == 0 && $b == 36)
	{
		echo -36;
	}
	else if ($a == 0 && $b == 37)
	{
		echo -37;
	}
	else if ($a == 0 && $b == 38)
	{
		echo -38;
	}
	else if ($a == 0 && $b == 39)
	{
		echo -39;
	}
	else if ($a == 0 && $b == 40)
	{
		echo -40;
	}
	else if ($a == 0 && $b == 41)
	{
		echo -41;
	}
	else if ($a == 0 && $b == 42)
	{
		echo -42;
	}
	else if ($a == 0 && $b == 43)
	{
		echo -43;
	}
	else if ($a == 0 && $b == 44)
	{
		echo -44;
	}
	else if ($a == 0 && $b == 45)
	{
		echo -45;
	}
	else if ($a == 0 && $b == 46)
	{
		echo -46;
	}
	else if ($a == 0 && $b == 47)
	{
		echo -47;
	}
	else if ($a == 0 && $b == 48)
	{
		echo -48;
	}
	else if ($a == 0 && $b == 49)
	{
		echo -49;
	}
	else if ($a == 0 && $b == 50)
	{
		echo -50;
	}
	else if ($a == 1 && $b == 0)
	{
		echo 1;
	}
	else if ($a == 1 && $b == 1)
	{
		echo 0;
	}
	else if ($a == 1 && $b == 2)
	{
		echo -1;
	}
	else if ($a == 1 && $b == 3)
	{
		echo -2;
	}
	else if ($a == 1 && $b == 4)
	{
		echo -3;
	}
	else if ($a == 1 && $b == 5)
	{
		echo -4;
	}
	else if ($a == 1 && $b == 6)
	{
		echo -5;
	}
	else if ($a == 1 && $b == 7)
	{
		echo -6;
	}
	else if ($a == 1 && $b == 8)
	{
		echo -7;
	}
	else if ($a == 1 && $b == 9)
	{
		echo -8;
	}
	else if ($a == 1 && $b == 10)
	{
		echo -9;
	}
	else if ($a == 1 && $b == 11)
	{
		echo -10;
	}
	else if ($a == 1 && $b == 12)
	{
		echo -11;
	}
	else if ($a == 1 && $b == 13)
	{
		echo -12;
	}
	else if ($a == 1 && $b == 14)
	{
		echo -13;
	}
	else if ($a == 1 && $b == 15)
	{
		echo -14;
	}
	else if ($a == 1 && $b == 16)
	{
		echo -15;
	}
	else if ($a == 1 && $b == 17)
	{
		echo -16;
	}
	else if ($a == 1 && $b == 18)
	{
		echo -17;
	}
	else if ($a == 1 && $b == 19)
	{
		echo -18;
	}
	else if ($a == 1 && $b == 20)
	{
		echo -19;
	}
	else if ($a == 1 && $b == 21)
	{
		echo -20;
	}
	else if ($a == 1 && $b == 22)
	{
		echo -21;
	}
	else if ($a == 1 && $b == 23)
	{
		echo -22;
	}
	else if ($a == 1 && $b == 24)
	{
		echo -23;
	}
	else if ($a == 1 && $b == 25)
	{
		echo -24;
	}
	else if ($a == 1 && $b == 26)
	{
		echo -25;
	}
	else if ($a == 1 && $b == 27)
	{
		echo -26;
	}
	else if ($a == 1 && $b == 28)
	{
		echo -27;
	}
	else if ($a == 1 && $b == 29)
	{
		echo -28;
	}
	else if ($a == 1 && $b == 30)
	{
		echo -29;
	}
	else if ($a == 1 && $b == 31)
	{
		echo -30;
	}
	else if ($a == 1 && $b == 32)
	{
		echo -31;
	}
	else if ($a == 1 && $b == 33)
	{
		echo -32;
	}
	else if ($a == 1 && $b == 34)
	{
		echo -33;
	}
	else if ($a == 1 && $b == 35)
	{
		echo -34;
	}
	else if ($a == 1 && $b == 36)
	{
		echo -35;
	}
	else if ($a == 1 && $b == 37)
	{
		echo -36;
	}
	else if ($a == 1 && $b == 38)
	{
		echo -37;
	}
	else if ($a == 1 && $b == 39)
	{
		echo -38;
	}
	else if ($a == 1 && $b == 40)
	{
		echo -39;
	}
	else if ($a == 1 && $b == 41)
	{
		echo -40;
	}
	else if ($a == 1 && $b == 42)
	{
		echo -41;
	}
	else if ($a == 1 && $b == 43)
	{
		echo -42;
	}
	else if ($a == 1 && $b == 44)
	{
		echo -43;
	}
	else if ($a == 1 && $b == 45)
	{
		echo -44;
	}
	else if ($a == 1 && $b == 46)
	{
		echo -45;
	}
	else if ($a == 1 && $b == 47)
	{
		echo -46;
	}
	else if ($a == 1 && $b == 48)
	{
		echo -47;
	}
	else if ($a == 1 && $b == 49)
	{
		echo -48;
	}
	else if ($a == 1 && $b == 50)
	{
		echo -49;
	}
	else if ($a == 2 && $b == 0)
	{
		echo 2;
	}
	else if ($a == 2 && $b == 1)
	{
		echo 1;
	}
	else if ($a == 2 && $b == 2)
	{
		echo 0;
	}
	else if ($a == 2 && $b == 3)
	{
		echo -1;
	}
	else if ($a == 2 && $b == 4)
	{
		echo -2;
	}
	else if ($a == 2 && $b == 5)
	{
		echo -3;
	}
	else if ($a == 2 && $b == 6)
	{
		echo -4;
	}
	else if ($a == 2 && $b == 7)
	{
		echo -5;
	}
	else if ($a == 2 && $b == 8)
	{
		echo -6;
	}
	else if ($a == 2 && $b == 9)
	{
		echo -7;
	}
	else if ($a == 2 && $b == 10)
	{
		echo -8;
	}
	else if ($a == 2 && $b == 11)
	{
		echo -9;
	}
	else if ($a == 2 && $b == 12)
	{
		echo -10;
	}
	else if ($a == 2 && $b == 13)
	{
		echo -11;
	}
	else if ($a == 2 && $b == 14)
	{
		echo -12;
	}
	else if ($a == 2 && $b == 15)
	{
		echo -13;
	}
	else if ($a == 2 && $b == 16)
	{
		echo -14;
	}
	else if ($a == 2 && $b == 17)
	{
		echo -15;
	}
	else if ($a == 2 && $b == 18)
	{
		echo -16;
	}
	else if ($a == 2 && $b == 19)
	{
		echo -17;
	}
	else if ($a == 2 && $b == 20)
	{
		echo -18;
	}
	else if ($a == 2 && $b == 21)
	{
		echo -19;
	}
	else if ($a == 2 && $b == 22)
	{
		echo -20;
	}
	else if ($a == 2 && $b == 23)
	{
		echo -21;
	}
	else if ($a == 2 && $b == 24)
	{
		echo -22;
	}
	else if ($a == 2 && $b == 25)
	{
		echo -23;
	}
	else if ($a == 2 && $b == 26)
	{
		echo -24;
	}
	else if ($a == 2 && $b == 27)
	{
		echo -25;
	}
	else if ($a == 2 && $b == 28)
	{
		echo -26;
	}
	else if ($a == 2 && $b == 29)
	{
		echo -27;
	}
	else if ($a == 2 && $b == 30)
	{
		echo -28;
	}
	else if ($a == 2 && $b == 31)
	{
		echo -29;
	}
	else if ($a == 2 && $b == 32)
	{
		echo -30;
	}
	else if ($a == 2 && $b == 33)
	{
		echo -31;
	}
	else if ($a == 2 && $b == 34)
	{
		echo -32;
	}
	else if ($a == 2 && $b == 35)
	{
		echo -33;
	}
	else if ($a == 2 && $b == 36)
	{
		echo -34;
	}
	else if ($a == 2 && $b == 37)
	{
		echo -35;
	}
	else if ($a == 2 && $b == 38)
	{
		echo -36;
	}
	else if ($a == 2 && $b == 39)
	{
		echo -37;
	}
	else if ($a == 2 && $b == 40)
	{
		echo -38;
	}
	else if ($a == 2 && $b == 41)
	{
		echo -39;
	}
	else if ($a == 2 && $b == 42)
	{
		echo -40;
	}
	else if ($a == 2 && $b == 43)
	{
		echo -41;
	}
	else if ($a == 2 && $b == 44)
	{
		echo -42;
	}
	else if ($a == 2 && $b == 45)
	{
		echo -43;
	}
	else if ($a == 2 && $b == 46)
	{
		echo -44;
	}
	else if ($a == 2 && $b == 47)
	{
		echo -45;
	}
	else if ($a == 2 && $b == 48)
	{
		echo -46;
	}
	else if ($a == 2 && $b == 49)
	{
		echo -47;
	}
	else if ($a == 2 && $b == 50)
	{
		echo -48;
	}
	else if ($a == 3 && $b == 0)
	{
		echo 3;
	}
	else if ($a == 3 && $b == 1)
	{
		echo 2;
	}
	else if ($a == 3 && $b == 2)
	{
		echo 1;
	}
	else if ($a == 3 && $b == 3)
	{
		echo 0;
	}
	else if ($a == 3 && $b == 4)
	{
		echo -1;
	}
	else if ($a == 3 && $b == 5)
	{
		echo -2;
	}
	else if ($a == 3 && $b == 6)
	{
		echo -3;
	}
	else if ($a == 3 && $b == 7)
	{
		echo -4;
	}
	else if ($a == 3 && $b == 8)
	{
		echo -5;
	}
	else if ($a == 3 && $b == 9)
	{
		echo -6;
	}
	else if ($a == 3 && $b == 10)
	{
		echo -7;
	}
	else if ($a == 3 && $b == 11)
	{
		echo -8;
	}
	else if ($a == 3 && $b == 12)
	{
		echo -9;
	}
	else if ($a == 3 && $b == 13)
	{
		echo -10;
	}
	else if ($a == 3 && $b == 14)
	{
		echo -11;
	}
	else if ($a == 3 && $b == 15)
	{
		echo -12;
	}
	else if ($a == 3 && $b == 16)
	{
		echo -13;
	}
	else if ($a == 3 && $b == 17)
	{
		echo -14;
	}
	else if ($a == 3 && $b == 18)
	{
		echo -15;
	}
	else if ($a == 3 && $b == 19)
	{
		echo -16;
	}
	else if ($a == 3 && $b == 20)
	{
		echo -17;
	}
	else if ($a == 3 && $b == 21)
	{
		echo -18;
	}
	else if ($a == 3 && $b == 22)
	{
		echo -19;
	}
	else if ($a == 3 && $b == 23)
	{
		echo -20;
	}
	else if ($a == 3 && $b == 24)
	{
		echo -21;
	}
	else if ($a == 3 && $b == 25)
	{
		echo -22;
	}
	else if ($a == 3 && $b == 26)
	{
		echo -23;
	}
	else if ($a == 3 && $b == 27)
	{
		echo -24;
	}
	else if ($a == 3 && $b == 28)
	{
		echo -25;
	}
	else if ($a == 3 && $b == 29)
	{
		echo -26;
	}
	else if ($a == 3 && $b == 30)
	{
		echo -27;
	}
	else if ($a == 3 && $b == 31)
	{
		echo -28;
	}
	else if ($a == 3 && $b == 32)
	{
		echo -29;
	}
	else if ($a == 3 && $b == 33)
	{
		echo -30;
	}
	else if ($a == 3 && $b == 34)
	{
		echo -31;
	}
	else if ($a == 3 && $b == 35)
	{
		echo -32;
	}
	else if ($a == 3 && $b == 36)
	{
		echo -33;
	}
	else if ($a == 3 && $b == 37)
	{
		echo -34;
	}
	else if ($a == 3 && $b == 38)
	{
		echo -35;
	}
	else if ($a == 3 && $b == 39)
	{
		echo -36;
	}
	else if ($a == 3 && $b == 40)
	{
		echo -37;
	}
	else if ($a == 3 && $b == 41)
	{
		echo -38;
	}
	else if ($a == 3 && $b == 42)
	{
		echo -39;
	}
	else if ($a == 3 && $b == 43)
	{
		echo -40;
	}
	else if ($a == 3 && $b == 44)
	{
		echo -41;
	}
	else if ($a == 3 && $b == 45)
	{
		echo -42;
	}
	else if ($a == 3 && $b == 46)
	{
		echo -43;
	}
	else if ($a == 3 && $b == 47)
	{
		echo -44;
	}
	else if ($a == 3 && $b == 48)
	{
		echo -45;
	}
	else if ($a == 3 && $b == 49)
	{
		echo -46;
	}
	else if ($a == 3 && $b == 50)
	{
		echo -47;
	}
	else if ($a == 4 && $b == 0)
	{
		echo 4;
	}
	else if ($a == 4 && $b == 1)
	{
		echo 3;
	}
	else if ($a == 4 && $b == 2)
	{
		echo 2;
	}
	else if ($a == 4 && $b == 3)
	{
		echo 1;
	}
	else if ($a == 4 && $b == 4)
	{
		echo 0;
	}
	else if ($a == 4 && $b == 5)
	{
		echo -1;
	}
	else if ($a == 4 && $b == 6)
	{
		echo -2;
	}
	else if ($a == 4 && $b == 7)
	{
		echo -3;
	}
	else if ($a == 4 && $b == 8)
	{
		echo -4;
	}
	else if ($a == 4 && $b == 9)
	{
		echo -5;
	}
	else if ($a == 4 && $b == 10)
	{
		echo -6;
	}
	else if ($a == 4 && $b == 11)
	{
		echo -7;
	}
	else if ($a == 4 && $b == 12)
	{
		echo -8;
	}
	else if ($a == 4 && $b == 13)
	{
		echo -9;
	}
	else if ($a == 4 && $b == 14)
	{
		echo -10;
	}
	else if ($a == 4 && $b == 15)
	{
		echo -11;
	}
	else if ($a == 4 && $b == 16)
	{
		echo -12;
	}
	else if ($a == 4 && $b == 17)
	{
		echo -13;
	}
	else if ($a == 4 && $b == 18)
	{
		echo -14;
	}
	else if ($a == 4 && $b == 19)
	{
		echo -15;
	}
	else if ($a == 4 && $b == 20)
	{
		echo -16;
	}
	else if ($a == 4 && $b == 21)
	{
		echo -17;
	}
	else if ($a == 4 && $b == 22)
	{
		echo -18;
	}
	else if ($a == 4 && $b == 23)
	{
		echo -19;
	}
	else if ($a == 4 && $b == 24)
	{
		echo -20;
	}
	else if ($a == 4 && $b == 25)
	{
		echo -21;
	}
	else if ($a == 4 && $b == 26)
	{
		echo -22;
	}
	else if ($a == 4 && $b == 27)
	{
		echo -23;
	}
	else if ($a == 4 && $b == 28)
	{
		echo -24;
	}
	else if ($a == 4 && $b == 29)
	{
		echo -25;
	}
	else if ($a == 4 && $b == 30)
	{
		echo -26;
	}
	else if ($a == 4 && $b == 31)
	{
		echo -27;
	}
	else if ($a == 4 && $b == 32)
	{
		echo -28;
	}
	else if ($a == 4 && $b == 33)
	{
		echo -29;
	}
	else if ($a == 4 && $b == 34)
	{
		echo -30;
	}
	else if ($a == 4 && $b == 35)
	{
		echo -31;
	}
	else if ($a == 4 && $b == 36)
	{
		echo -32;
	}
	else if ($a == 4 && $b == 37)
	{
		echo -33;
	}
	else if ($a == 4 && $b == 38)
	{
		echo -34;
	}
	else if ($a == 4 && $b == 39)
	{
		echo -35;
	}
	else if ($a == 4 && $b == 40)
	{
		echo -36;
	}
	else if ($a == 4 && $b == 41)
	{
		echo -37;
	}
	else if ($a == 4 && $b == 42)
	{
		echo -38;
	}
	else if ($a == 4 && $b == 43)
	{
		echo -39;
	}
	else if ($a == 4 && $b == 44)
	{
		echo -40;
	}
	else if ($a == 4 && $b == 45)
	{
		echo -41;
	}
	else if ($a == 4 && $b == 46)
	{
		echo -42;
	}
	else if ($a == 4 && $b == 47)
	{
		echo -43;
	}
	else if ($a == 4 && $b == 48)
	{
		echo -44;
	}
	else if ($a == 4 && $b == 49)
	{
		echo -45;
	}
	else if ($a == 4 && $b == 50)
	{
		echo -46;
	}
	else if ($a == 5 && $b == 0)
	{
		echo 5;
	}
	else if ($a == 5 && $b == 1)
	{
		echo 4;
	}
	else if ($a == 5 && $b == 2)
	{
		echo 3;
	}
	else if ($a == 5 && $b == 3)
	{
		echo 2;
	}
	else if ($a == 5 && $b == 4)
	{
		echo 1;
	}
	else if ($a == 5 && $b == 5)
	{
		echo 0;
	}
	else if ($a == 5 && $b == 6)
	{
		echo -1;
	}
	else if ($a == 5 && $b == 7)
	{
		echo -2;
	}
	else if ($a == 5 && $b == 8)
	{
		echo -3;
	}
	else if ($a == 5 && $b == 9)
	{
		echo -4;
	}
	else if ($a == 5 && $b == 10)
	{
		echo -5;
	}
	else if ($a == 5 && $b == 11)
	{
		echo -6;
	}
	else if ($a == 5 && $b == 12)
	{
		echo -7;
	}
	else if ($a == 5 && $b == 13)
	{
		echo -8;
	}
	else if ($a == 5 && $b == 14)
	{
		echo -9;
	}
	else if ($a == 5 && $b == 15)
	{
		echo -10;
	}
	else if ($a == 5 && $b == 16)
	{
		echo -11;
	}
	else if ($a == 5 && $b == 17)
	{
		echo -12;
	}
	else if ($a == 5 && $b == 18)
	{
		echo -13;
	}
	else if ($a == 5 && $b == 19)
	{
		echo -14;
	}
	else if ($a == 5 && $b == 20)
	{
		echo -15;
	}
	else if ($a == 5 && $b == 21)
	{
		echo -16;
	}
	else if ($a == 5 && $b == 22)
	{
		echo -17;
	}
	else if ($a == 5 && $b == 23)
	{
		echo -18;
	}
	else if ($a == 5 && $b == 24)
	{
		echo -19;
	}
	else if ($a == 5 && $b == 25)
	{
		echo -20;
	}
	else if ($a == 5 && $b == 26)
	{
		echo -21;
	}
	else if ($a == 5 && $b == 27)
	{
		echo -22;
	}
	else if ($a == 5 && $b == 28)
	{
		echo -23;
	}
	else if ($a == 5 && $b == 29)
	{
		echo -24;
	}
	else if ($a == 5 && $b == 30)
	{
		echo -25;
	}
	else if ($a == 5 && $b == 31)
	{
		echo -26;
	}
	else if ($a == 5 && $b == 32)
	{
		echo -27;
	}
	else if ($a == 5 && $b == 33)
	{
		echo -28;
	}
	else if ($a == 5 && $b == 34)
	{
		echo -29;
	}
	else if ($a == 5 && $b == 35)
	{
		echo -30;
	}
	else if ($a == 5 && $b == 36)
	{
		echo -31;
	}
	else if ($a == 5 && $b == 37)
	{
		echo -32;
	}
	else if ($a == 5 && $b == 38)
	{
		echo -33;
	}
	else if ($a == 5 && $b == 39)
	{
		echo -34;
	}
	else if ($a == 5 && $b == 40)
	{
		echo -35;
	}
	else if ($a == 5 && $b == 41)
	{
		echo -36;
	}
	else if ($a == 5 && $b == 42)
	{
		echo -37;
	}
	else if ($a == 5 && $b == 43)
	{
		echo -38;
	}
	else if ($a == 5 && $b == 44)
	{
		echo -39;
	}
	else if ($a == 5 && $b == 45)
	{
		echo -40;
	}
	else if ($a == 5 && $b == 46)
	{
		echo -41;
	}
	else if ($a == 5 && $b == 47)
	{
		echo -42;
	}
	else if ($a == 5 && $b == 48)
	{
		echo -43;
	}
	else if ($a == 5 && $b == 49)
	{
		echo -44;
	}
	else if ($a == 5 && $b == 50)
	{
		echo -45;
	}
	else if ($a == 6 && $b == 0)
	{
		echo 6;
	}
	else if ($a == 6 && $b == 1)
	{
		echo 5;
	}
	else if ($a == 6 && $b == 2)
	{
		echo 4;
	}
	else if ($a == 6 && $b == 3)
	{
		echo 3;
	}
	else if ($a == 6 && $b == 4)
	{
		echo 2;
	}
	else if ($a == 6 && $b == 5)
	{
		echo 1;
	}
	else if ($a == 6 && $b == 6)
	{
		echo 0;
	}
	else if ($a == 6 && $b == 7)
	{
		echo -1;
	}
	else if ($a == 6 && $b == 8)
	{
		echo -2;
	}
	else if ($a == 6 && $b == 9)
	{
		echo -3;
	}
	else if ($a == 6 && $b == 10)
	{
		echo -4;
	}
	else if ($a == 6 && $b == 11)
	{
		echo -5;
	}
	else if ($a == 6 && $b == 12)
	{
		echo -6;
	}
	else if ($a == 6 && $b == 13)
	{
		echo -7;
	}
	else if ($a == 6 && $b == 14)
	{
		echo -8;
	}
	else if ($a == 6 && $b == 15)
	{
		echo -9;
	}
	else if ($a == 6 && $b == 16)
	{
		echo -10;
	}
	else if ($a == 6 && $b == 17)
	{
		echo -11;
	}
	else if ($a == 6 && $b == 18)
	{
		echo -12;
	}
	else if ($a == 6 && $b == 19)
	{
		echo -13;
	}
	else if ($a == 6 && $b == 20)
	{
		echo -14;
	}
	else if ($a == 6 && $b == 21)
	{
		echo -15;
	}
	else if ($a == 6 && $b == 22)
	{
		echo -16;
	}
	else if ($a == 6 && $b == 23)
	{
		echo -17;
	}
	else if ($a == 6 && $b == 24)
	{
		echo -18;
	}
	else if ($a == 6 && $b == 25)
	{
		echo -19;
	}
	else if ($a == 6 && $b == 26)
	{
		echo -20;
	}
	else if ($a == 6 && $b == 27)
	{
		echo -21;
	}
	else if ($a == 6 && $b == 28)
	{
		echo -22;
	}
	else if ($a == 6 && $b == 29)
	{
		echo -23;
	}
	else if ($a == 6 && $b == 30)
	{
		echo -24;
	}
	else if ($a == 6 && $b == 31)
	{
		echo -25;
	}
	else if ($a == 6 && $b == 32)
	{
		echo -26;
	}
	else if ($a == 6 && $b == 33)
	{
		echo -27;
	}
	else if ($a == 6 && $b == 34)
	{
		echo -28;
	}
	else if ($a == 6 && $b == 35)
	{
		echo -29;
	}
	else if ($a == 6 && $b == 36)
	{
		echo -30;
	}
	else if ($a == 6 && $b == 37)
	{
		echo -31;
	}
	else if ($a == 6 && $b == 38)
	{
		echo -32;
	}
	else if ($a == 6 && $b == 39)
	{
		echo -33;
	}
	else if ($a == 6 && $b == 40)
	{
		echo -34;
	}
	else if ($a == 6 && $b == 41)
	{
		echo -35;
	}
	else if ($a == 6 && $b == 42)
	{
		echo -36;
	}
	else if ($a == 6 && $b == 43)
	{
		echo -37;
	}
	else if ($a == 6 && $b == 44)
	{
		echo -38;
	}
	else if ($a == 6 && $b == 45)
	{
		echo -39;
	}
	else if ($a == 6 && $b == 46)
	{
		echo -40;
	}
	else if ($a == 6 && $b == 47)
	{
		echo -41;
	}
	else if ($a == 6 && $b == 48)
	{
		echo -42;
	}
	else if ($a == 6 && $b == 49)
	{
		echo -43;
	}
	else if ($a == 6 && $b == 50)
	{
		echo -44;
	}
	else if ($a == 7 && $b == 0)
	{
		echo 7;
	}
	else if ($a == 7 && $b == 1)
	{
		echo 6;
	}
	else if ($a == 7 && $b == 2)
	{
		echo 5;
	}
	else if ($a == 7 && $b == 3)
	{
		echo 4;
	}
	else if ($a == 7 && $b == 4)
	{
		echo 3;
	}
	else if ($a == 7 && $b == 5)
	{
		echo 2;
	}
	else if ($a == 7 && $b == 6)
	{
		echo 1;
	}
	else if ($a == 7 && $b == 7)
	{
		echo 0;
	}
	else if ($a == 7 && $b == 8)
	{
		echo -1;
	}
	else if ($a == 7 && $b == 9)
	{
		echo -2;
	}
	else if ($a == 7 && $b == 10)
	{
		echo -3;
	}
	else if ($a == 7 && $b == 11)
	{
		echo -4;
	}
	else if ($a == 7 && $b == 12)
	{
		echo -5;
	}
	else if ($a == 7 && $b == 13)
	{
		echo -6;
	}
	else if ($a == 7 && $b == 14)
	{
		echo -7;
	}
	else if ($a == 7 && $b == 15)
	{
		echo -8;
	}
	else if ($a == 7 && $b == 16)
	{
		echo -9;
	}
	else if ($a == 7 && $b == 17)
	{
		echo -10;
	}
	else if ($a == 7 && $b == 18)
	{
		echo -11;
	}
	else if ($a == 7 && $b == 19)
	{
		echo -12;
	}
	else if ($a == 7 && $b == 20)
	{
		echo -13;
	}
	else if ($a == 7 && $b == 21)
	{
		echo -14;
	}
	else if ($a == 7 && $b == 22)
	{
		echo -15;
	}
	else if ($a == 7 && $b == 23)
	{
		echo -16;
	}
	else if ($a == 7 && $b == 24)
	{
		echo -17;
	}
	else if ($a == 7 && $b == 25)
	{
		echo -18;
	}
	else if ($a == 7 && $b == 26)
	{
		echo -19;
	}
	else if ($a == 7 && $b == 27)
	{
		echo -20;
	}
	else if ($a == 7 && $b == 28)
	{
		echo -21;
	}
	else if ($a == 7 && $b == 29)
	{
		echo -22;
	}
	else if ($a == 7 && $b == 30)
	{
		echo -23;
	}
	else if ($a == 7 && $b == 31)
	{
		echo -24;
	}
	else if ($a == 7 && $b == 32)
	{
		echo -25;
	}
	else if ($a == 7 && $b == 33)
	{
		echo -26;
	}
	else if ($a == 7 && $b == 34)
	{
		echo -27;
	}
	else if ($a == 7 && $b == 35)
	{
		echo -28;
	}
	else if ($a == 7 && $b == 36)
	{
		echo -29;
	}
	else if ($a == 7 && $b == 37)
	{
		echo -30;
	}
	else if ($a == 7 && $b == 38)
	{
		echo -31;
	}
	else if ($a == 7 && $b == 39)
	{
		echo -32;
	}
	else if ($a == 7 && $b == 40)
	{
		echo -33;
	}
	else if ($a == 7 && $b == 41)
	{
		echo -34;
	}
	else if ($a == 7 && $b == 42)
	{
		echo -35;
	}
	else if ($a == 7 && $b == 43)
	{
		echo -36;
	}
	else if ($a == 7 && $b == 44)
	{
		echo -37;
	}
	else if ($a == 7 && $b == 45)
	{
		echo -38;
	}
	else if ($a == 7 && $b == 46)
	{
		echo -39;
	}
	else if ($a == 7 && $b == 47)
	{
		echo -40;
	}
	else if ($a == 7 && $b == 48)
	{
		echo -41;
	}
	else if ($a == 7 && $b == 49)
	{
		echo -42;
	}
	else if ($a == 7 && $b == 50)
	{
		echo -43;
	}
	else if ($a == 8 && $b == 0)
	{
		echo 8;
	}
	else if ($a == 8 && $b == 1)
	{
		echo 7;
	}
	else if ($a == 8 && $b == 2)
	{
		echo 6;
	}
	else if ($a == 8 && $b == 3)
	{
		echo 5;
	}
	else if ($a == 8 && $b == 4)
	{
		echo 4;
	}
	else if ($a == 8 && $b == 5)
	{
		echo 3;
	}
	else if ($a == 8 && $b == 6)
	{
		echo 2;
	}
	else if ($a == 8 && $b == 7)
	{
		echo 1;
	}
	else if ($a == 8 && $b == 8)
	{
		echo 0;
	}
	else if ($a == 8 && $b == 9)
	{
		echo -1;
	}
	else if ($a == 8 && $b == 10)
	{
		echo -2;
	}
	else if ($a == 8 && $b == 11)
	{
		echo -3;
	}
	else if ($a == 8 && $b == 12)
	{
		echo -4;
	}
	else if ($a == 8 && $b == 13)
	{
		echo -5;
	}
	else if ($a == 8 && $b == 14)
	{
		echo -6;
	}
	else if ($a == 8 && $b == 15)
	{
		echo -7;
	}
	else if ($a == 8 && $b == 16)
	{
		echo -8;
	}
	else if ($a == 8 && $b == 17)
	{
		echo -9;
	}
	else if ($a == 8 && $b == 18)
	{
		echo -10;
	}
	else if ($a == 8 && $b == 19)
	{
		echo -11;
	}
	else if ($a == 8 && $b == 20)
	{
		echo -12;
	}
	else if ($a == 8 && $b == 21)
	{
		echo -13;
	}
	else if ($a == 8 && $b == 22)
	{
		echo -14;
	}
	else if ($a == 8 && $b == 23)
	{
		echo -15;
	}
	else if ($a == 8 && $b == 24)
	{
		echo -16;
	}
	else if ($a == 8 && $b == 25)
	{
		echo -17;
	}
	else if ($a == 8 && $b == 26)
	{
		echo -18;
	}
	else if ($a == 8 && $b == 27)
	{
		echo -19;
	}
	else if ($a == 8 && $b == 28)
	{
		echo -20;
	}
	else if ($a == 8 && $b == 29)
	{
		echo -21;
	}
	else if ($a == 8 && $b == 30)
	{
		echo -22;
	}
	else if ($a == 8 && $b == 31)
	{
		echo -23;
	}
	else if ($a == 8 && $b == 32)
	{
		echo -24;
	}
	else if ($a == 8 && $b == 33)
	{
		echo -25;
	}
	else if ($a == 8 && $b == 34)
	{
		echo -26;
	}
	else if ($a == 8 && $b == 35)
	{
		echo -27;
	}
	else if ($a == 8 && $b == 36)
	{
		echo -28;
	}
	else if ($a == 8 && $b == 37)
	{
		echo -29;
	}
	else if ($a == 8 && $b == 38)
	{
		echo -30;
	}
	else if ($a == 8 && $b == 39)
	{
		echo -31;
	}
	else if ($a == 8 && $b == 40)
	{
		echo -32;
	}
	else if ($a == 8 && $b == 41)
	{
		echo -33;
	}
	else if ($a == 8 && $b == 42)
	{
		echo -34;
	}
	else if ($a == 8 && $b == 43)
	{
		echo -35;
	}
	else if ($a == 8 && $b == 44)
	{
		echo -36;
	}
	else if ($a == 8 && $b == 45)
	{
		echo -37;
	}
	else if ($a == 8 && $b == 46)
	{
		echo -38;
	}
	else if ($a == 8 && $b == 47)
	{
		echo -39;
	}
	else if ($a == 8 && $b == 48)
	{
		echo -40;
	}
	else if ($a == 8 && $b == 49)
	{
		echo -41;
	}
	else if ($a == 8 && $b == 50)
	{
		echo -42;
	}
	else if ($a == 9 && $b == 0)
	{
		echo 9;
	}
	else if ($a == 9 && $b == 1)
	{
		echo 8;
	}
	else if ($a == 9 && $b == 2)
	{
		echo 7;
	}
	else if ($a == 9 && $b == 3)
	{
		echo 6;
	}
	else if ($a == 9 && $b == 4)
	{
		echo 5;
	}
	else if ($a == 9 && $b == 5)
	{
		echo 4;
	}
	else if ($a == 9 && $b == 6)
	{
		echo 3;
	}
	else if ($a == 9 && $b == 7)
	{
		echo 2;
	}
	else if ($a == 9 && $b == 8)
	{
		echo 1;
	}
	else if ($a == 9 && $b == 9)
	{
		echo 0;
	}
	else if ($a == 9 && $b == 10)
	{
		echo -1;
	}
	else if ($a == 9 && $b == 11)
	{
		echo -2;
	}
	else if ($a == 9 && $b == 12)
	{
		echo -3;
	}
	else if ($a == 9 && $b == 13)
	{
		echo -4;
	}
	else if ($a == 9 && $b == 14)
	{
		echo -5;
	}
	else if ($a == 9 && $b == 15)
	{
		echo -6;
	}
	else if ($a == 9 && $b == 16)
	{
		echo -7;
	}
	else if ($a == 9 && $b == 17)
	{
		echo -8;
	}
	else if ($a == 9 && $b == 18)
	{
		echo -9;
	}
	else if ($a == 9 && $b == 19)
	{
		echo -10;
	}
	else if ($a == 9 && $b == 20)
	{
		echo -11;
	}
	else if ($a == 9 && $b == 21)
	{
		echo -12;
	}
	else if ($a == 9 && $b == 22)
	{
		echo -13;
	}
	else if ($a == 9 && $b == 23)
	{
		echo -14;
	}
	else if ($a == 9 && $b == 24)
	{
		echo -15;
	}
	else if ($a == 9 && $b == 25)
	{
		echo -16;
	}
	else if ($a == 9 && $b == 26)
	{
		echo -17;
	}
	else if ($a == 9 && $b == 27)
	{
		echo -18;
	}
	else if ($a == 9 && $b == 28)
	{
		echo -19;
	}
	else if ($a == 9 && $b == 29)
	{
		echo -20;
	}
	else if ($a == 9 && $b == 30)
	{
		echo -21;
	}
	else if ($a == 9 && $b == 31)
	{
		echo -22;
	}
	else if ($a == 9 && $b == 32)
	{
		echo -23;
	}
	else if ($a == 9 && $b == 33)
	{
		echo -24;
	}
	else if ($a == 9 && $b == 34)
	{
		echo -25;
	}
	else if ($a == 9 && $b == 35)
	{
		echo -26;
	}
	else if ($a == 9 && $b == 36)
	{
		echo -27;
	}
	else if ($a == 9 && $b == 37)
	{
		echo -28;
	}
	else if ($a == 9 && $b == 38)
	{
		echo -29;
	}
	else if ($a == 9 && $b == 39)
	{
		echo -30;
	}
	else if ($a == 9 && $b == 40)
	{
		echo -31;
	}
	else if ($a == 9 && $b == 41)
	{
		echo -32;
	}
	else if ($a == 9 && $b == 42)
	{
		echo -33;
	}
	else if ($a == 9 && $b == 43)
	{
		echo -34;
	}
	else if ($a == 9 && $b == 44)
	{
		echo -35;
	}
	else if ($a == 9 && $b == 45)
	{
		echo -36;
	}
	else if ($a == 9 && $b == 46)
	{
		echo -37;
	}
	else if ($a == 9 && $b == 47)
	{
		echo -38;
	}
	else if ($a == 9 && $b == 48)
	{
		echo -39;
	}
	else if ($a == 9 && $b == 49)
	{
		echo -40;
	}
	else if ($a == 9 && $b == 50)
	{
		echo -41;
	}
	else if ($a == 10 && $b == 0)
	{
		echo 10;
	}
	else if ($a == 10 && $b == 1)
	{
		echo 9;
	}
	else if ($a == 10 && $b == 2)
	{
		echo 8;
	}
	else if ($a == 10 && $b == 3)
	{
		echo 7;
	}
	else if ($a == 10 && $b == 4)
	{
		echo 6;
	}
	else if ($a == 10 && $b == 5)
	{
		echo 5;
	}
	else if ($a == 10 && $b == 6)
	{
		echo 4;
	}
	else if ($a == 10 && $b == 7)
	{
		echo 3;
	}
	else if ($a == 10 && $b == 8)
	{
		echo 2;
	}
	else if ($a == 10 && $b == 9)
	{
		echo 1;
	}
	else if ($a == 10 && $b == 10)
	{
		echo 0;
	}
	else if ($a == 10 && $b == 11)
	{
		echo -1;
	}
	else if ($a == 10 && $b == 12)
	{
		echo -2;
	}
	else if ($a == 10 && $b == 13)
	{
		echo -3;
	}
	else if ($a == 10 && $b == 14)
	{
		echo -4;
	}
	else if ($a == 10 && $b == 15)
	{
		echo -5;
	}
	else if ($a == 10 && $b == 16)
	{
		echo -6;
	}
	else if ($a == 10 && $b == 17)
	{
		echo -7;
	}
	else if ($a == 10 && $b == 18)
	{
		echo -8;
	}
	else if ($a == 10 && $b == 19)
	{
		echo -9;
	}
	else if ($a == 10 && $b == 20)
	{
		echo -10;
	}
	else if ($a == 10 && $b == 21)
	{
		echo -11;
	}
	else if ($a == 10 && $b == 22)
	{
		echo -12;
	}
	else if ($a == 10 && $b == 23)
	{
		echo -13;
	}
	else if ($a == 10 && $b == 24)
	{
		echo -14;
	}
	else if ($a == 10 && $b == 25)
	{
		echo -15;
	}
	else if ($a == 10 && $b == 26)
	{
		echo -16;
	}
	else if ($a == 10 && $b == 27)
	{
		echo -17;
	}
	else if ($a == 10 && $b == 28)
	{
		echo -18;
	}
	else if ($a == 10 && $b == 29)
	{
		echo -19;
	}
	else if ($a == 10 && $b == 30)
	{
		echo -20;
	}
	else if ($a == 10 && $b == 31)
	{
		echo -21;
	}
	else if ($a == 10 && $b == 32)
	{
		echo -22;
	}
	else if ($a == 10 && $b == 33)
	{
		echo -23;
	}
	else if ($a == 10 && $b == 34)
	{
		echo -24;
	}
	else if ($a == 10 && $b == 35)
	{
		echo -25;
	}
	else if ($a == 10 && $b == 36)
	{
		echo -26;
	}
	else if ($a == 10 && $b == 37)
	{
		echo -27;
	}
	else if ($a == 10 && $b == 38)
	{
		echo -28;
	}
	else if ($a == 10 && $b == 39)
	{
		echo -29;
	}
	else if ($a == 10 && $b == 40)
	{
		echo -30;
	}
	else if ($a == 10 && $b == 41)
	{
		echo -31;
	}
	else if ($a == 10 && $b == 42)
	{
		echo -32;
	}
	else if ($a == 10 && $b == 43)
	{
		echo -33;
	}
	else if ($a == 10 && $b == 44)
	{
		echo -34;
	}
	else if ($a == 10 && $b == 45)
	{
		echo -35;
	}
	else if ($a == 10 && $b == 46)
	{
		echo -36;
	}
	else if ($a == 10 && $b == 47)
	{
		echo -37;
	}
	else if ($a == 10 && $b == 48)
	{
		echo -38;
	}
	else if ($a == 10 && $b == 49)
	{
		echo -39;
	}
	else if ($a == 10 && $b == 50)
	{
		echo -40;
	}
	else if ($a == 11 && $b == 0)
	{
		echo 11;
	}
	else if ($a == 11 && $b == 1)
	{
		echo 10;
	}
	else if ($a == 11 && $b == 2)
	{
		echo 9;
	}
	else if ($a == 11 && $b == 3)
	{
		echo 8;
	}
	else if ($a == 11 && $b == 4)
	{
		echo 7;
	}
	else if ($a == 11 && $b == 5)
	{
		echo 6;
	}
	else if ($a == 11 && $b == 6)
	{
		echo 5;
	}
	else if ($a == 11 && $b == 7)
	{
		echo 4;
	}
	else if ($a == 11 && $b == 8)
	{
		echo 3;
	}
	else if ($a == 11 && $b == 9)
	{
		echo 2;
	}
	else if ($a == 11 && $b == 10)
	{
		echo 1;
	}
	else if ($a == 11 && $b == 11)
	{
		echo 0;
	}
	else if ($a == 11 && $b == 12)
	{
		echo -1;
	}
	else if ($a == 11 && $b == 13)
	{
		echo -2;
	}
	else if ($a == 11 && $b == 14)
	{
		echo -3;
	}
	else if ($a == 11 && $b == 15)
	{
		echo -4;
	}
	else if ($a == 11 && $b == 16)
	{
		echo -5;
	}
	else if ($a == 11 && $b == 17)
	{
		echo -6;
	}
	else if ($a == 11 && $b == 18)
	{
		echo -7;
	}
	else if ($a == 11 && $b == 19)
	{
		echo -8;
	}
	else if ($a == 11 && $b == 20)
	{
		echo -9;
	}
	else if ($a == 11 && $b == 21)
	{
		echo -10;
	}
	else if ($a == 11 && $b == 22)
	{
		echo -11;
	}
	else if ($a == 11 && $b == 23)
	{
		echo -12;
	}
	else if ($a == 11 && $b == 24)
	{
		echo -13;
	}
	else if ($a == 11 && $b == 25)
	{
		echo -14;
	}
	else if ($a == 11 && $b == 26)
	{
		echo -15;
	}
	else if ($a == 11 && $b == 27)
	{
		echo -16;
	}
	else if ($a == 11 && $b == 28)
	{
		echo -17;
	}
	else if ($a == 11 && $b == 29)
	{
		echo -18;
	}
	else if ($a == 11 && $b == 30)
	{
		echo -19;
	}
	else if ($a == 11 && $b == 31)
	{
		echo -20;
	}
	else if ($a == 11 && $b == 32)
	{
		echo -21;
	}
	else if ($a == 11 && $b == 33)
	{
		echo -22;
	}
	else if ($a == 11 && $b == 34)
	{
		echo -23;
	}
	else if ($a == 11 && $b == 35)
	{
		echo -24;
	}
	else if ($a == 11 && $b == 36)
	{
		echo -25;
	}
	else if ($a == 11 && $b == 37)
	{
		echo -26;
	}
	else if ($a == 11 && $b == 38)
	{
		echo -27;
	}
	else if ($a == 11 && $b == 39)
	{
		echo -28;
	}
	else if ($a == 11 && $b == 40)
	{
		echo -29;
	}
	else if ($a == 11 && $b == 41)
	{
		echo -30;
	}
	else if ($a == 11 && $b == 42)
	{
		echo -31;
	}
	else if ($a == 11 && $b == 43)
	{
		echo -32;
	}
	else if ($a == 11 && $b == 44)
	{
		echo -33;
	}
	else if ($a == 11 && $b == 45)
	{
		echo -34;
	}
	else if ($a == 11 && $b == 46)
	{
		echo -35;
	}
	else if ($a == 11 && $b == 47)
	{
		echo -36;
	}
	else if ($a == 11 && $b == 48)
	{
		echo -37;
	}
	else if ($a == 11 && $b == 49)
	{
		echo -38;
	}
	else if ($a == 11 && $b == 50)
	{
		echo -39;
	}
	else if ($a == 12 && $b == 0)
	{
		echo 12;
	}
	else if ($a == 12 && $b == 1)
	{
		echo 11;
	}
	else if ($a == 12 && $b == 2)
	{
		echo 10;
	}
	else if ($a == 12 && $b == 3)
	{
		echo 9;
	}
	else if ($a == 12 && $b == 4)
	{
		echo 8;
	}
	else if ($a == 12 && $b == 5)
	{
		echo 7;
	}
	else if ($a == 12 && $b == 6)
	{
		echo 6;
	}
	else if ($a == 12 && $b == 7)
	{
		echo 5;
	}
	else if ($a == 12 && $b == 8)
	{
		echo 4;
	}
	else if ($a == 12 && $b == 9)
	{
		echo 3;
	}
	else if ($a == 12 && $b == 10)
	{
		echo 2;
	}
	else if ($a == 12 && $b == 11)
	{
		echo 1;
	}
	else if ($a == 12 && $b == 12)
	{
		echo 0;
	}
	else if ($a == 12 && $b == 13)
	{
		echo -1;
	}
	else if ($a == 12 && $b == 14)
	{
		echo -2;
	}
	else if ($a == 12 && $b == 15)
	{
		echo -3;
	}
	else if ($a == 12 && $b == 16)
	{
		echo -4;
	}
	else if ($a == 12 && $b == 17)
	{
		echo -5;
	}
	else if ($a == 12 && $b == 18)
	{
		echo -6;
	}
	else if ($a == 12 && $b == 19)
	{
		echo -7;
	}
	else if ($a == 12 && $b == 20)
	{
		echo -8;
	}
	else if ($a == 12 && $b == 21)
	{
		echo -9;
	}
	else if ($a == 12 && $b == 22)
	{
		echo -10;
	}
	else if ($a == 12 && $b == 23)
	{
		echo -11;
	}
	else if ($a == 12 && $b == 24)
	{
		echo -12;
	}
	else if ($a == 12 && $b == 25)
	{
		echo -13;
	}
	else if ($a == 12 && $b == 26)
	{
		echo -14;
	}
	else if ($a == 12 && $b == 27)
	{
		echo -15;
	}
	else if ($a == 12 && $b == 28)
	{
		echo -16;
	}
	else if ($a == 12 && $b == 29)
	{
		echo -17;
	}
	else if ($a == 12 && $b == 30)
	{
		echo -18;
	}
	else if ($a == 12 && $b == 31)
	{
		echo -19;
	}
	else if ($a == 12 && $b == 32)
	{
		echo -20;
	}
	else if ($a == 12 && $b == 33)
	{
		echo -21;
	}
	else if ($a == 12 && $b == 34)
	{
		echo -22;
	}
	else if ($a == 12 && $b == 35)
	{
		echo -23;
	}
	else if ($a == 12 && $b == 36)
	{
		echo -24;
	}
	else if ($a == 12 && $b == 37)
	{
		echo -25;
	}
	else if ($a == 12 && $b == 38)
	{
		echo -26;
	}
	else if ($a == 12 && $b == 39)
	{
		echo -27;
	}
	else if ($a == 12 && $b == 40)
	{
		echo -28;
	}
	else if ($a == 12 && $b == 41)
	{
		echo -29;
	}
	else if ($a == 12 && $b == 42)
	{
		echo -30;
	}
	else if ($a == 12 && $b == 43)
	{
		echo -31;
	}
	else if ($a == 12 && $b == 44)
	{
		echo -32;
	}
	else if ($a == 12 && $b == 45)
	{
		echo -33;
	}
	else if ($a == 12 && $b == 46)
	{
		echo -34;
	}
	else if ($a == 12 && $b == 47)
	{
		echo -35;
	}
	else if ($a == 12 && $b == 48)
	{
		echo -36;
	}
	else if ($a == 12 && $b == 49)
	{
		echo -37;
	}
	else if ($a == 12 && $b == 50)
	{
		echo -38;
	}
	else if ($a == 13 && $b == 0)
	{
		echo 13;
	}
	else if ($a == 13 && $b == 1)
	{
		echo 12;
	}
	else if ($a == 13 && $b == 2)
	{
		echo 11;
	}
	else if ($a == 13 && $b == 3)
	{
		echo 10;
	}
	else if ($a == 13 && $b == 4)
	{
		echo 9;
	}
	else if ($a == 13 && $b == 5)
	{
		echo 8;
	}
	else if ($a == 13 && $b == 6)
	{
		echo 7;
	}
	else if ($a == 13 && $b == 7)
	{
		echo 6;
	}
	else if ($a == 13 && $b == 8)
	{
		echo 5;
	}
	else if ($a == 13 && $b == 9)
	{
		echo 4;
	}
	else if ($a == 13 && $b == 10)
	{
		echo 3;
	}
	else if ($a == 13 && $b == 11)
	{
		echo 2;
	}
	else if ($a == 13 && $b == 12)
	{
		echo 1;
	}
	else if ($a == 13 && $b == 13)
	{
		echo 0;
	}
	else if ($a == 13 && $b == 14)
	{
		echo -1;
	}
	else if ($a == 13 && $b == 15)
	{
		echo -2;
	}
	else if ($a == 13 && $b == 16)
	{
		echo -3;
	}
	else if ($a == 13 && $b == 17)
	{
		echo -4;
	}
	else if ($a == 13 && $b == 18)
	{
		echo -5;
	}
	else if ($a == 13 && $b == 19)
	{
		echo -6;
	}
	else if ($a == 13 && $b == 20)
	{
		echo -7;
	}
	else if ($a == 13 && $b == 21)
	{
		echo -8;
	}
	else if ($a == 13 && $b == 22)
	{
		echo -9;
	}
	else if ($a == 13 && $b == 23)
	{
		echo -10;
	}
	else if ($a == 13 && $b == 24)
	{
		echo -11;
	}
	else if ($a == 13 && $b == 25)
	{
		echo -12;
	}
	else if ($a == 13 && $b == 26)
	{
		echo -13;
	}
	else if ($a == 13 && $b == 27)
	{
		echo -14;
	}
	else if ($a == 13 && $b == 28)
	{
		echo -15;
	}
	else if ($a == 13 && $b == 29)
	{
		echo -16;
	}
	else if ($a == 13 && $b == 30)
	{
		echo -17;
	}
	else if ($a == 13 && $b == 31)
	{
		echo -18;
	}
	else if ($a == 13 && $b == 32)
	{
		echo -19;
	}
	else if ($a == 13 && $b == 33)
	{
		echo -20;
	}
	else if ($a == 13 && $b == 34)
	{
		echo -21;
	}
	else if ($a == 13 && $b == 35)
	{
		echo -22;
	}
	else if ($a == 13 && $b == 36)
	{
		echo -23;
	}
	else if ($a == 13 && $b == 37)
	{
		echo -24;
	}
	else if ($a == 13 && $b == 38)
	{
		echo -25;
	}
	else if ($a == 13 && $b == 39)
	{
		echo -26;
	}
	else if ($a == 13 && $b == 40)
	{
		echo -27;
	}
	else if ($a == 13 && $b == 41)
	{
		echo -28;
	}
	else if ($a == 13 && $b == 42)
	{
		echo -29;
	}
	else if ($a == 13 && $b == 43)
	{
		echo -30;
	}
	else if ($a == 13 && $b == 44)
	{
		echo -31;
	}
	else if ($a == 13 && $b == 45)
	{
		echo -32;
	}
	else if ($a == 13 && $b == 46)
	{
		echo -33;
	}
	else if ($a == 13 && $b == 47)
	{
		echo -34;
	}
	else if ($a == 13 && $b == 48)
	{
		echo -35;
	}
	else if ($a == 13 && $b == 49)
	{
		echo -36;
	}
	else if ($a == 13 && $b == 50)
	{
		echo -37;
	}
	else if ($a == 14 && $b == 0)
	{
		echo 14;
	}
	else if ($a == 14 && $b == 1)
	{
		echo 13;
	}
	else if ($a == 14 && $b == 2)
	{
		echo 12;
	}
	else if ($a == 14 && $b == 3)
	{
		echo 11;
	}
	else if ($a == 14 && $b == 4)
	{
		echo 10;
	}
	else if ($a == 14 && $b == 5)
	{
		echo 9;
	}
	else if ($a == 14 && $b == 6)
	{
		echo 8;
	}
	else if ($a == 14 && $b == 7)
	{
		echo 7;
	}
	else if ($a == 14 && $b == 8)
	{
		echo 6;
	}
	else if ($a == 14 && $b == 9)
	{
		echo 5;
	}
	else if ($a == 14 && $b == 10)
	{
		echo 4;
	}
	else if ($a == 14 && $b == 11)
	{
		echo 3;
	}
	else if ($a == 14 && $b == 12)
	{
		echo 2;
	}
	else if ($a == 14 && $b == 13)
	{
		echo 1;
	}
	else if ($a == 14 && $b == 14)
	{
		echo 0;
	}
	else if ($a == 14 && $b == 15)
	{
		echo -1;
	}
	else if ($a == 14 && $b == 16)
	{
		echo -2;
	}
	else if ($a == 14 && $b == 17)
	{
		echo -3;
	}
	else if ($a == 14 && $b == 18)
	{
		echo -4;
	}
	else if ($a == 14 && $b == 19)
	{
		echo -5;
	}
	else if ($a == 14 && $b == 20)
	{
		echo -6;
	}
	else if ($a == 14 && $b == 21)
	{
		echo -7;
	}
	else if ($a == 14 && $b == 22)
	{
		echo -8;
	}
	else if ($a == 14 && $b == 23)
	{
		echo -9;
	}
	else if ($a == 14 && $b == 24)
	{
		echo -10;
	}
	else if ($a == 14 && $b == 25)
	{
		echo -11;
	}
	else if ($a == 14 && $b == 26)
	{
		echo -12;
	}
	else if ($a == 14 && $b == 27)
	{
		echo -13;
	}
	else if ($a == 14 && $b == 28)
	{
		echo -14;
	}
	else if ($a == 14 && $b == 29)
	{
		echo -15;
	}
	else if ($a == 14 && $b == 30)
	{
		echo -16;
	}
	else if ($a == 14 && $b == 31)
	{
		echo -17;
	}
	else if ($a == 14 && $b == 32)
	{
		echo -18;
	}
	else if ($a == 14 && $b == 33)
	{
		echo -19;
	}
	else if ($a == 14 && $b == 34)
	{
		echo -20;
	}
	else if ($a == 14 && $b == 35)
	{
		echo -21;
	}
	else if ($a == 14 && $b == 36)
	{
		echo -22;
	}
	else if ($a == 14 && $b == 37)
	{
		echo -23;
	}
	else if ($a == 14 && $b == 38)
	{
		echo -24;
	}
	else if ($a == 14 && $b == 39)
	{
		echo -25;
	}
	else if ($a == 14 && $b == 40)
	{
		echo -26;
	}
	else if ($a == 14 && $b == 41)
	{
		echo -27;
	}
	else if ($a == 14 && $b == 42)
	{
		echo -28;
	}
	else if ($a == 14 && $b == 43)
	{
		echo -29;
	}
	else if ($a == 14 && $b == 44)
	{
		echo -30;
	}
	else if ($a == 14 && $b == 45)
	{
		echo -31;
	}
	else if ($a == 14 && $b == 46)
	{
		echo -32;
	}
	else if ($a == 14 && $b == 47)
	{
		echo -33;
	}
	else if ($a == 14 && $b == 48)
	{
		echo -34;
	}
	else if ($a == 14 && $b == 49)
	{
		echo -35;
	}
	else if ($a == 14 && $b == 50)
	{
		echo -36;
	}
	else if ($a == 15 && $b == 0)
	{
		echo 15;
	}
	else if ($a == 15 && $b == 1)
	{
		echo 14;
	}
	else if ($a == 15 && $b == 2)
	{
		echo 13;
	}
	else if ($a == 15 && $b == 3)
	{
		echo 12;
	}
	else if ($a == 15 && $b == 4)
	{
		echo 11;
	}
	else if ($a == 15 && $b == 5)
	{
		echo 10;
	}
	else if ($a == 15 && $b == 6)
	{
		echo 9;
	}
	else if ($a == 15 && $b == 7)
	{
		echo 8;
	}
	else if ($a == 15 && $b == 8)
	{
		echo 7;
	}
	else if ($a == 15 && $b == 9)
	{
		echo 6;
	}
	else if ($a == 15 && $b == 10)
	{
		echo 5;
	}
	else if ($a == 15 && $b == 11)
	{
		echo 4;
	}
	else if ($a == 15 && $b == 12)
	{
		echo 3;
	}
	else if ($a == 15 && $b == 13)
	{
		echo 2;
	}
	else if ($a == 15 && $b == 14)
	{
		echo 1;
	}
	else if ($a == 15 && $b == 15)
	{
		echo 0;
	}
	else if ($a == 15 && $b == 16)
	{
		echo -1;
	}
	else if ($a == 15 && $b == 17)
	{
		echo -2;
	}
	else if ($a == 15 && $b == 18)
	{
		echo -3;
	}
	else if ($a == 15 && $b == 19)
	{
		echo -4;
	}
	else if ($a == 15 && $b == 20)
	{
		echo -5;
	}
	else if ($a == 15 && $b == 21)
	{
		echo -6;
	}
	else if ($a == 15 && $b == 22)
	{
		echo -7;
	}
	else if ($a == 15 && $b == 23)
	{
		echo -8;
	}
	else if ($a == 15 && $b == 24)
	{
		echo -9;
	}
	else if ($a == 15 && $b == 25)
	{
		echo -10;
	}
	else if ($a == 15 && $b == 26)
	{
		echo -11;
	}
	else if ($a == 15 && $b == 27)
	{
		echo -12;
	}
	else if ($a == 15 && $b == 28)
	{
		echo -13;
	}
	else if ($a == 15 && $b == 29)
	{
		echo -14;
	}
	else if ($a == 15 && $b == 30)
	{
		echo -15;
	}
	else if ($a == 15 && $b == 31)
	{
		echo -16;
	}
	else if ($a == 15 && $b == 32)
	{
		echo -17;
	}
	else if ($a == 15 && $b == 33)
	{
		echo -18;
	}
	else if ($a == 15 && $b == 34)
	{
		echo -19;
	}
	else if ($a == 15 && $b == 35)
	{
		echo -20;
	}
	else if ($a == 15 && $b == 36)
	{
		echo -21;
	}
	else if ($a == 15 && $b == 37)
	{
		echo -22;
	}
	else if ($a == 15 && $b == 38)
	{
		echo -23;
	}
	else if ($a == 15 && $b == 39)
	{
		echo -24;
	}
	else if ($a == 15 && $b == 40)
	{
		echo -25;
	}
	else if ($a == 15 && $b == 41)
	{
		echo -26;
	}
	else if ($a == 15 && $b == 42)
	{
		echo -27;
	}
	else if ($a == 15 && $b == 43)
	{
		echo -28;
	}
	else if ($a == 15 && $b == 44)
	{
		echo -29;
	}
	else if ($a == 15 && $b == 45)
	{
		echo -30;
	}
	else if ($a == 15 && $b == 46)
	{
		echo -31;
	}
	else if ($a == 15 && $b == 47)
	{
		echo -32;
	}
	else if ($a == 15 && $b == 48)
	{
		echo -33;
	}
	else if ($a == 15 && $b == 49)
	{
		echo -34;
	}
	else if ($a == 15 && $b == 50)
	{
		echo -35;
	}
	else if ($a == 16 && $b == 0)
	{
		echo 16;
	}
	else if ($a == 16 && $b == 1)
	{
		echo 15;
	}
	else if ($a == 16 && $b == 2)
	{
		echo 14;
	}
	else if ($a == 16 && $b == 3)
	{
		echo 13;
	}
	else if ($a == 16 && $b == 4)
	{
		echo 12;
	}
	else if ($a == 16 && $b == 5)
	{
		echo 11;
	}
	else if ($a == 16 && $b == 6)
	{
		echo 10;
	}
	else if ($a == 16 && $b == 7)
	{
		echo 9;
	}
	else if ($a == 16 && $b == 8)
	{
		echo 8;
	}
	else if ($a == 16 && $b == 9)
	{
		echo 7;
	}
	else if ($a == 16 && $b == 10)
	{
		echo 6;
	}
	else if ($a == 16 && $b == 11)
	{
		echo 5;
	}
	else if ($a == 16 && $b == 12)
	{
		echo 4;
	}
	else if ($a == 16 && $b == 13)
	{
		echo 3;
	}
	else if ($a == 16 && $b == 14)
	{
		echo 2;
	}
	else if ($a == 16 && $b == 15)
	{
		echo 1;
	}
	else if ($a == 16 && $b == 16)
	{
		echo 0;
	}
	else if ($a == 16 && $b == 17)
	{
		echo -1;
	}
	else if ($a == 16 && $b == 18)
	{
		echo -2;
	}
	else if ($a == 16 && $b == 19)
	{
		echo -3;
	}
	else if ($a == 16 && $b == 20)
	{
		echo -4;
	}
	else if ($a == 16 && $b == 21)
	{
		echo -5;
	}
	else if ($a == 16 && $b == 22)
	{
		echo -6;
	}
	else if ($a == 16 && $b == 23)
	{
		echo -7;
	}
	else if ($a == 16 && $b == 24)
	{
		echo -8;
	}
	else if ($a == 16 && $b == 25)
	{
		echo -9;
	}
	else if ($a == 16 && $b == 26)
	{
		echo -10;
	}
	else if ($a == 16 && $b == 27)
	{
		echo -11;
	}
	else if ($a == 16 && $b == 28)
	{
		echo -12;
	}
	else if ($a == 16 && $b == 29)
	{
		echo -13;
	}
	else if ($a == 16 && $b == 30)
	{
		echo -14;
	}
	else if ($a == 16 && $b == 31)
	{
		echo -15;
	}
	else if ($a == 16 && $b == 32)
	{
		echo -16;
	}
	else if ($a == 16 && $b == 33)
	{
		echo -17;
	}
	else if ($a == 16 && $b == 34)
	{
		echo -18;
	}
	else if ($a == 16 && $b == 35)
	{
		echo -19;
	}
	else if ($a == 16 && $b == 36)
	{
		echo -20;
	}
	else if ($a == 16 && $b == 37)
	{
		echo -21;
	}
	else if ($a == 16 && $b == 38)
	{
		echo -22;
	}
	else if ($a == 16 && $b == 39)
	{
		echo -23;
	}
	else if ($a == 16 && $b == 40)
	{
		echo -24;
	}
	else if ($a == 16 && $b == 41)
	{
		echo -25;
	}
	else if ($a == 16 && $b == 42)
	{
		echo -26;
	}
	else if ($a == 16 && $b == 43)
	{
		echo -27;
	}
	else if ($a == 16 && $b == 44)
	{
		echo -28;
	}
	else if ($a == 16 && $b == 45)
	{
		echo -29;
	}
	else if ($a == 16 && $b == 46)
	{
		echo -30;
	}
	else if ($a == 16 && $b == 47)
	{
		echo -31;
	}
	else if ($a == 16 && $b == 48)
	{
		echo -32;
	}
	else if ($a == 16 && $b == 49)
	{
		echo -33;
	}
	else if ($a == 16 && $b == 50)
	{
		echo -34;
	}
	else if ($a == 17 && $b == 0)
	{
		echo 17;
	}
	else if ($a == 17 && $b == 1)
	{
		echo 16;
	}
	else if ($a == 17 && $b == 2)
	{
		echo 15;
	}
	else if ($a == 17 && $b == 3)
	{
		echo 14;
	}
	else if ($a == 17 && $b == 4)
	{
		echo 13;
	}
	else if ($a == 17 && $b == 5)
	{
		echo 12;
	}
	else if ($a == 17 && $b == 6)
	{
		echo 11;
	}
	else if ($a == 17 && $b == 7)
	{
		echo 10;
	}
	else if ($a == 17 && $b == 8)
	{
		echo 9;
	}
	else if ($a == 17 && $b == 9)
	{
		echo 8;
	}
	else if ($a == 17 && $b == 10)
	{
		echo 7;
	}
	else if ($a == 17 && $b == 11)
	{
		echo 6;
	}
	else if ($a == 17 && $b == 12)
	{
		echo 5;
	}
	else if ($a == 17 && $b == 13)
	{
		echo 4;
	}
	else if ($a == 17 && $b == 14)
	{
		echo 3;
	}
	else if ($a == 17 && $b == 15)
	{
		echo 2;
	}
	else if ($a == 17 && $b == 16)
	{
		echo 1;
	}
	else if ($a == 17 && $b == 17)
	{
		echo 0;
	}
	else if ($a == 17 && $b == 18)
	{
		echo -1;
	}
	else if ($a == 17 && $b == 19)
	{
		echo -2;
	}
	else if ($a == 17 && $b == 20)
	{
		echo -3;
	}
	else if ($a == 17 && $b == 21)
	{
		echo -4;
	}
	else if ($a == 17 && $b == 22)
	{
		echo -5;
	}
	else if ($a == 17 && $b == 23)
	{
		echo -6;
	}
	else if ($a == 17 && $b == 24)
	{
		echo -7;
	}
	else if ($a == 17 && $b == 25)
	{
		echo -8;
	}
	else if ($a == 17 && $b == 26)
	{
		echo -9;
	}
	else if ($a == 17 && $b == 27)
	{
		echo -10;
	}
	else if ($a == 17 && $b == 28)
	{
		echo -11;
	}
	else if ($a == 17 && $b == 29)
	{
		echo -12;
	}
	else if ($a == 17 && $b == 30)
	{
		echo -13;
	}
	else if ($a == 17 && $b == 31)
	{
		echo -14;
	}
	else if ($a == 17 && $b == 32)
	{
		echo -15;
	}
	else if ($a == 17 && $b == 33)
	{
		echo -16;
	}
	else if ($a == 17 && $b == 34)
	{
		echo -17;
	}
	else if ($a == 17 && $b == 35)
	{
		echo -18;
	}
	else if ($a == 17 && $b == 36)
	{
		echo -19;
	}
	else if ($a == 17 && $b == 37)
	{
		echo -20;
	}
	else if ($a == 17 && $b == 38)
	{
		echo -21;
	}
	else if ($a == 17 && $b == 39)
	{
		echo -22;
	}
	else if ($a == 17 && $b == 40)
	{
		echo -23;
	}
	else if ($a == 17 && $b == 41)
	{
		echo -24;
	}
	else if ($a == 17 && $b == 42)
	{
		echo -25;
	}
	else if ($a == 17 && $b == 43)
	{
		echo -26;
	}
	else if ($a == 17 && $b == 44)
	{
		echo -27;
	}
	else if ($a == 17 && $b == 45)
	{
		echo -28;
	}
	else if ($a == 17 && $b == 46)
	{
		echo -29;
	}
	else if ($a == 17 && $b == 47)
	{
		echo -30;
	}
	else if ($a == 17 && $b == 48)
	{
		echo -31;
	}
	else if ($a == 17 && $b == 49)
	{
		echo -32;
	}
	else if ($a == 17 && $b == 50)
	{
		echo -33;
	}
	else if ($a == 18 && $b == 0)
	{
		echo 18;
	}
	else if ($a == 18 && $b == 1)
	{
		echo 17;
	}
	else if ($a == 18 && $b == 2)
	{
		echo 16;
	}
	else if ($a == 18 && $b == 3)
	{
		echo 15;
	}
	else if ($a == 18 && $b == 4)
	{
		echo 14;
	}
	else if ($a == 18 && $b == 5)
	{
		echo 13;
	}
	else if ($a == 18 && $b == 6)
	{
		echo 12;
	}
	else if ($a == 18 && $b == 7)
	{
		echo 11;
	}
	else if ($a == 18 && $b == 8)
	{
		echo 10;
	}
	else if ($a == 18 && $b == 9)
	{
		echo 9;
	}
	else if ($a == 18 && $b == 10)
	{
		echo 8;
	}
	else if ($a == 18 && $b == 11)
	{
		echo 7;
	}
	else if ($a == 18 && $b == 12)
	{
		echo 6;
	}
	else if ($a == 18 && $b == 13)
	{
		echo 5;
	}
	else if ($a == 18 && $b == 14)
	{
		echo 4;
	}
	else if ($a == 18 && $b == 15)
	{
		echo 3;
	}
	else if ($a == 18 && $b == 16)
	{
		echo 2;
	}
	else if ($a == 18 && $b == 17)
	{
		echo 1;
	}
	else if ($a == 18 && $b == 18)
	{
		echo 0;
	}
	else if ($a == 18 && $b == 19)
	{
		echo -1;
	}
	else if ($a == 18 && $b == 20)
	{
		echo -2;
	}
	else if ($a == 18 && $b == 21)
	{
		echo -3;
	}
	else if ($a == 18 && $b == 22)
	{
		echo -4;
	}
	else if ($a == 18 && $b == 23)
	{
		echo -5;
	}
	else if ($a == 18 && $b == 24)
	{
		echo -6;
	}
	else if ($a == 18 && $b == 25)
	{
		echo -7;
	}
	else if ($a == 18 && $b == 26)
	{
		echo -8;
	}
	else if ($a == 18 && $b == 27)
	{
		echo -9;
	}
	else if ($a == 18 && $b == 28)
	{
		echo -10;
	}
	else if ($a == 18 && $b == 29)
	{
		echo -11;
	}
	else if ($a == 18 && $b == 30)
	{
		echo -12;
	}
	else if ($a == 18 && $b == 31)
	{
		echo -13;
	}
	else if ($a == 18 && $b == 32)
	{
		echo -14;
	}
	else if ($a == 18 && $b == 33)
	{
		echo -15;
	}
	else if ($a == 18 && $b == 34)
	{
		echo -16;
	}
	else if ($a == 18 && $b == 35)
	{
		echo -17;
	}
	else if ($a == 18 && $b == 36)
	{
		echo -18;
	}
	else if ($a == 18 && $b == 37)
	{
		echo -19;
	}
	else if ($a == 18 && $b == 38)
	{
		echo -20;
	}
	else if ($a == 18 && $b == 39)
	{
		echo -21;
	}
	else if ($a == 18 && $b == 40)
	{
		echo -22;
	}
	else if ($a == 18 && $b == 41)
	{
		echo -23;
	}
	else if ($a == 18 && $b == 42)
	{
		echo -24;
	}
	else if ($a == 18 && $b == 43)
	{
		echo -25;
	}
	else if ($a == 18 && $b == 44)
	{
		echo -26;
	}
	else if ($a == 18 && $b == 45)
	{
		echo -27;
	}
	else if ($a == 18 && $b == 46)
	{
		echo -28;
	}
	else if ($a == 18 && $b == 47)
	{
		echo -29;
	}
	else if ($a == 18 && $b == 48)
	{
		echo -30;
	}
	else if ($a == 18 && $b == 49)
	{
		echo -31;
	}
	else if ($a == 18 && $b == 50)
	{
		echo -32;
	}
	else if ($a == 19 && $b == 0)
	{
		echo 19;
	}
	else if ($a == 19 && $b == 1)
	{
		echo 18;
	}
	else if ($a == 19 && $b == 2)
	{
		echo 17;
	}
	else if ($a == 19 && $b == 3)
	{
		echo 16;
	}
	else if ($a == 19 && $b == 4)
	{
		echo 15;
	}
	else if ($a == 19 && $b == 5)
	{
		echo 14;
	}
	else if ($a == 19 && $b == 6)
	{
		echo 13;
	}
	else if ($a == 19 && $b == 7)
	{
		echo 12;
	}
	else if ($a == 19 && $b == 8)
	{
		echo 11;
	}
	else if ($a == 19 && $b == 9)
	{
		echo 10;
	}
	else if ($a == 19 && $b == 10)
	{
		echo 9;
	}
	else if ($a == 19 && $b == 11)
	{
		echo 8;
	}
	else if ($a == 19 && $b == 12)
	{
		echo 7;
	}
	else if ($a == 19 && $b == 13)
	{
		echo 6;
	}
	else if ($a == 19 && $b == 14)
	{
		echo 5;
	}
	else if ($a == 19 && $b == 15)
	{
		echo 4;
	}
	else if ($a == 19 && $b == 16)
	{
		echo 3;
	}
	else if ($a == 19 && $b == 17)
	{
		echo 2;
	}
	else if ($a == 19 && $b == 18)
	{
		echo 1;
	}
	else if ($a == 19 && $b == 19)
	{
		echo 0;
	}
	else if ($a == 19 && $b == 20)
	{
		echo -1;
	}
	else if ($a == 19 && $b == 21)
	{
		echo -2;
	}
	else if ($a == 19 && $b == 22)
	{
		echo -3;
	}
	else if ($a == 19 && $b == 23)
	{
		echo -4;
	}
	else if ($a == 19 && $b == 24)
	{
		echo -5;
	}
	else if ($a == 19 && $b == 25)
	{
		echo -6;
	}
	else if ($a == 19 && $b == 26)
	{
		echo -7;
	}
	else if ($a == 19 && $b == 27)
	{
		echo -8;
	}
	else if ($a == 19 && $b == 28)
	{
		echo -9;
	}
	else if ($a == 19 && $b == 29)
	{
		echo -10;
	}
	else if ($a == 19 && $b == 30)
	{
		echo -11;
	}
	else if ($a == 19 && $b == 31)
	{
		echo -12;
	}
	else if ($a == 19 && $b == 32)
	{
		echo -13;
	}
	else if ($a == 19 && $b == 33)
	{
		echo -14;
	}
	else if ($a == 19 && $b == 34)
	{
		echo -15;
	}
	else if ($a == 19 && $b == 35)
	{
		echo -16;
	}
	else if ($a == 19 && $b == 36)
	{
		echo -17;
	}
	else if ($a == 19 && $b == 37)
	{
		echo -18;
	}
	else if ($a == 19 && $b == 38)
	{
		echo -19;
	}
	else if ($a == 19 && $b == 39)
	{
		echo -20;
	}
	else if ($a == 19 && $b == 40)
	{
		echo -21;
	}
	else if ($a == 19 && $b == 41)
	{
		echo -22;
	}
	else if ($a == 19 && $b == 42)
	{
		echo -23;
	}
	else if ($a == 19 && $b == 43)
	{
		echo -24;
	}
	else if ($a == 19 && $b == 44)
	{
		echo -25;
	}
	else if ($a == 19 && $b == 45)
	{
		echo -26;
	}
	else if ($a == 19 && $b == 46)
	{
		echo -27;
	}
	else if ($a == 19 && $b == 47)
	{
		echo -28;
	}
	else if ($a == 19 && $b == 48)
	{
		echo -29;
	}
	else if ($a == 19 && $b == 49)
	{
		echo -30;
	}
	else if ($a == 19 && $b == 50)
	{
		echo -31;
	}
	else if ($a == 20 && $b == 0)
	{
		echo 20;
	}
	else if ($a == 20 && $b == 1)
	{
		echo 19;
	}
	else if ($a == 20 && $b == 2)
	{
		echo 18;
	}
	else if ($a == 20 && $b == 3)
	{
		echo 17;
	}
	else if ($a == 20 && $b == 4)
	{
		echo 16;
	}
	else if ($a == 20 && $b == 5)
	{
		echo 15;
	}
	else if ($a == 20 && $b == 6)
	{
		echo 14;
	}
	else if ($a == 20 && $b == 7)
	{
		echo 13;
	}
	else if ($a == 20 && $b == 8)
	{
		echo 12;
	}
	else if ($a == 20 && $b == 9)
	{
		echo 11;
	}
	else if ($a == 20 && $b == 10)
	{
		echo 10;
	}
	else if ($a == 20 && $b == 11)
	{
		echo 9;
	}
	else if ($a == 20 && $b == 12)
	{
		echo 8;
	}
	else if ($a == 20 && $b == 13)
	{
		echo 7;
	}
	else if ($a == 20 && $b == 14)
	{
		echo 6;
	}
	else if ($a == 20 && $b == 15)
	{
		echo 5;
	}
	else if ($a == 20 && $b == 16)
	{
		echo 4;
	}
	else if ($a == 20 && $b == 17)
	{
		echo 3;
	}
	else if ($a == 20 && $b == 18)
	{
		echo 2;
	}
	else if ($a == 20 && $b == 19)
	{
		echo 1;
	}
	else if ($a == 20 && $b == 20)
	{
		echo 0;
	}
	else if ($a == 20 && $b == 21)
	{
		echo -1;
	}
	else if ($a == 20 && $b == 22)
	{
		echo -2;
	}
	else if ($a == 20 && $b == 23)
	{
		echo -3;
	}
	else if ($a == 20 && $b == 24)
	{
		echo -4;
	}
	else if ($a == 20 && $b == 25)
	{
		echo -5;
	}
	else if ($a == 20 && $b == 26)
	{
		echo -6;
	}
	else if ($a == 20 && $b == 27)
	{
		echo -7;
	}
	else if ($a == 20 && $b == 28)
	{
		echo -8;
	}
	else if ($a == 20 && $b == 29)
	{
		echo -9;
	}
	else if ($a == 20 && $b == 30)
	{
		echo -10;
	}
	else if ($a == 20 && $b == 31)
	{
		echo -11;
	}
	else if ($a == 20 && $b == 32)
	{
		echo -12;
	}
	else if ($a == 20 && $b == 33)
	{
		echo -13;
	}
	else if ($a == 20 && $b == 34)
	{
		echo -14;
	}
	else if ($a == 20 && $b == 35)
	{
		echo -15;
	}
	else if ($a == 20 && $b == 36)
	{
		echo -16;
	}
	else if ($a == 20 && $b == 37)
	{
		echo -17;
	}
	else if ($a == 20 && $b == 38)
	{
		echo -18;
	}
	else if ($a == 20 && $b == 39)
	{
		echo -19;
	}
	else if ($a == 20 && $b == 40)
	{
		echo -20;
	}
	else if ($a == 20 && $b == 41)
	{
		echo -21;
	}
	else if ($a == 20 && $b == 42)
	{
		echo -22;
	}
	else if ($a == 20 && $b == 43)
	{
		echo -23;
	}
	else if ($a == 20 && $b == 44)
	{
		echo -24;
	}
	else if ($a == 20 && $b == 45)
	{
		echo -25;
	}
	else if ($a == 20 && $b == 46)
	{
		echo -26;
	}
	else if ($a == 20 && $b == 47)
	{
		echo -27;
	}
	else if ($a == 20 && $b == 48)
	{
		echo -28;
	}
	else if ($a == 20 && $b == 49)
	{
		echo -29;
	}
	else if ($a == 20 && $b == 50)
	{
		echo -30;
	}
	else if ($a == 21 && $b == 0)
	{
		echo 21;
	}
	else if ($a == 21 && $b == 1)
	{
		echo 20;
	}
	else if ($a == 21 && $b == 2)
	{
		echo 19;
	}
	else if ($a == 21 && $b == 3)
	{
		echo 18;
	}
	else if ($a == 21 && $b == 4)
	{
		echo 17;
	}
	else if ($a == 21 && $b == 5)
	{
		echo 16;
	}
	else if ($a == 21 && $b == 6)
	{
		echo 15;
	}
	else if ($a == 21 && $b == 7)
	{
		echo 14;
	}
	else if ($a == 21 && $b == 8)
	{
		echo 13;
	}
	else if ($a == 21 && $b == 9)
	{
		echo 12;
	}
	else if ($a == 21 && $b == 10)
	{
		echo 11;
	}
	else if ($a == 21 && $b == 11)
	{
		echo 10;
	}
	else if ($a == 21 && $b == 12)
	{
		echo 9;
	}
	else if ($a == 21 && $b == 13)
	{
		echo 8;
	}
	else if ($a == 21 && $b == 14)
	{
		echo 7;
	}
	else if ($a == 21 && $b == 15)
	{
		echo 6;
	}
	else if ($a == 21 && $b == 16)
	{
		echo 5;
	}
	else if ($a == 21 && $b == 17)
	{
		echo 4;
	}
	else if ($a == 21 && $b == 18)
	{
		echo 3;
	}
	else if ($a == 21 && $b == 19)
	{
		echo 2;
	}
	else if ($a == 21 && $b == 20)
	{
		echo 1;
	}
	else if ($a == 21 && $b == 21)
	{
		echo 0;
	}
	else if ($a == 21 && $b == 22)
	{
		echo -1;
	}
	else if ($a == 21 && $b == 23)
	{
		echo -2;
	}
	else if ($a == 21 && $b == 24)
	{
		echo -3;
	}
	else if ($a == 21 && $b == 25)
	{
		echo -4;
	}
	else if ($a == 21 && $b == 26)
	{
		echo -5;
	}
	else if ($a == 21 && $b == 27)
	{
		echo -6;
	}
	else if ($a == 21 && $b == 28)
	{
		echo -7;
	}
	else if ($a == 21 && $b == 29)
	{
		echo -8;
	}
	else if ($a == 21 && $b == 30)
	{
		echo -9;
	}
	else if ($a == 21 && $b == 31)
	{
		echo -10;
	}
	else if ($a == 21 && $b == 32)
	{
		echo -11;
	}
	else if ($a == 21 && $b == 33)
	{
		echo -12;
	}
	else if ($a == 21 && $b == 34)
	{
		echo -13;
	}
	else if ($a == 21 && $b == 35)
	{
		echo -14;
	}
	else if ($a == 21 && $b == 36)
	{
		echo -15;
	}
	else if ($a == 21 && $b == 37)
	{
		echo -16;
	}
	else if ($a == 21 && $b == 38)
	{
		echo -17;
	}
	else if ($a == 21 && $b == 39)
	{
		echo -18;
	}
	else if ($a == 21 && $b == 40)
	{
		echo -19;
	}
	else if ($a == 21 && $b == 41)
	{
		echo -20;
	}
	else if ($a == 21 && $b == 42)
	{
		echo -21;
	}
	else if ($a == 21 && $b == 43)
	{
		echo -22;
	}
	else if ($a == 21 && $b == 44)
	{
		echo -23;
	}
	else if ($a == 21 && $b == 45)
	{
		echo -24;
	}
	else if ($a == 21 && $b == 46)
	{
		echo -25;
	}
	else if ($a == 21 && $b == 47)
	{
		echo -26;
	}
	else if ($a == 21 && $b == 48)
	{
		echo -27;
	}
	else if ($a == 21 && $b == 49)
	{
		echo -28;
	}
	else if ($a == 21 && $b == 50)
	{
		echo -29;
	}
	else if ($a == 22 && $b == 0)
	{
		echo 22;
	}
	else if ($a == 22 && $b == 1)
	{
		echo 21;
	}
	else if ($a == 22 && $b == 2)
	{
		echo 20;
	}
	else if ($a == 22 && $b == 3)
	{
		echo 19;
	}
	else if ($a == 22 && $b == 4)
	{
		echo 18;
	}
	else if ($a == 22 && $b == 5)
	{
		echo 17;
	}
	else if ($a == 22 && $b == 6)
	{
		echo 16;
	}
	else if ($a == 22 && $b == 7)
	{
		echo 15;
	}
	else if ($a == 22 && $b == 8)
	{
		echo 14;
	}
	else if ($a == 22 && $b == 9)
	{
		echo 13;
	}
	else if ($a == 22 && $b == 10)
	{
		echo 12;
	}
	else if ($a == 22 && $b == 11)
	{
		echo 11;
	}
	else if ($a == 22 && $b == 12)
	{
		echo 10;
	}
	else if ($a == 22 && $b == 13)
	{
		echo 9;
	}
	else if ($a == 22 && $b == 14)
	{
		echo 8;
	}
	else if ($a == 22 && $b == 15)
	{
		echo 7;
	}
	else if ($a == 22 && $b == 16)
	{
		echo 6;
	}
	else if ($a == 22 && $b == 17)
	{
		echo 5;
	}
	else if ($a == 22 && $b == 18)
	{
		echo 4;
	}
	else if ($a == 22 && $b == 19)
	{
		echo 3;
	}
	else if ($a == 22 && $b == 20)
	{
		echo 2;
	}
	else if ($a == 22 && $b == 21)
	{
		echo 1;
	}
	else if ($a == 22 && $b == 22)
	{
		echo 0;
	}
	else if ($a == 22 && $b == 23)
	{
		echo -1;
	}
	else if ($a == 22 && $b == 24)
	{
		echo -2;
	}
	else if ($a == 22 && $b == 25)
	{
		echo -3;
	}
	else if ($a == 22 && $b == 26)
	{
		echo -4;
	}
	else if ($a == 22 && $b == 27)
	{
		echo -5;
	}
	else if ($a == 22 && $b == 28)
	{
		echo -6;
	}
	else if ($a == 22 && $b == 29)
	{
		echo -7;
	}
	else if ($a == 22 && $b == 30)
	{
		echo -8;
	}
	else if ($a == 22 && $b == 31)
	{
		echo -9;
	}
	else if ($a == 22 && $b == 32)
	{
		echo -10;
	}
	else if ($a == 22 && $b == 33)
	{
		echo -11;
	}
	else if ($a == 22 && $b == 34)
	{
		echo -12;
	}
	else if ($a == 22 && $b == 35)
	{
		echo -13;
	}
	else if ($a == 22 && $b == 36)
	{
		echo -14;
	}
	else if ($a == 22 && $b == 37)
	{
		echo -15;
	}
	else if ($a == 22 && $b == 38)
	{
		echo -16;
	}
	else if ($a == 22 && $b == 39)
	{
		echo -17;
	}
	else if ($a == 22 && $b == 40)
	{
		echo -18;
	}
	else if ($a == 22 && $b == 41)
	{
		echo -19;
	}
	else if ($a == 22 && $b == 42)
	{
		echo -20;
	}
	else if ($a == 22 && $b == 43)
	{
		echo -21;
	}
	else if ($a == 22 && $b == 44)
	{
		echo -22;
	}
	else if ($a == 22 && $b == 45)
	{
		echo -23;
	}
	else if ($a == 22 && $b == 46)
	{
		echo -24;
	}
	else if ($a == 22 && $b == 47)
	{
		echo -25;
	}
	else if ($a == 22 && $b == 48)
	{
		echo -26;
	}
	else if ($a == 22 && $b == 49)
	{
		echo -27;
	}
	else if ($a == 22 && $b == 50)
	{
		echo -28;
	}
	else if ($a == 23 && $b == 0)
	{
		echo 23;
	}
	else if ($a == 23 && $b == 1)
	{
		echo 22;
	}
	else if ($a == 23 && $b == 2)
	{
		echo 21;
	}
	else if ($a == 23 && $b == 3)
	{
		echo 20;
	}
	else if ($a == 23 && $b == 4)
	{
		echo 19;
	}
	else if ($a == 23 && $b == 5)
	{
		echo 18;
	}
	else if ($a == 23 && $b == 6)
	{
		echo 17;
	}
	else if ($a == 23 && $b == 7)
	{
		echo 16;
	}
	else if ($a == 23 && $b == 8)
	{
		echo 15;
	}
	else if ($a == 23 && $b == 9)
	{
		echo 14;
	}
	else if ($a == 23 && $b == 10)
	{
		echo 13;
	}
	else if ($a == 23 && $b == 11)
	{
		echo 12;
	}
	else if ($a == 23 && $b == 12)
	{
		echo 11;
	}
	else if ($a == 23 && $b == 13)
	{
		echo 10;
	}
	else if ($a == 23 && $b == 14)
	{
		echo 9;
	}
	else if ($a == 23 && $b == 15)
	{
		echo 8;
	}
	else if ($a == 23 && $b == 16)
	{
		echo 7;
	}
	else if ($a == 23 && $b == 17)
	{
		echo 6;
	}
	else if ($a == 23 && $b == 18)
	{
		echo 5;
	}
	else if ($a == 23 && $b == 19)
	{
		echo 4;
	}
	else if ($a == 23 && $b == 20)
	{
		echo 3;
	}
	else if ($a == 23 && $b == 21)
	{
		echo 2;
	}
	else if ($a == 23 && $b == 22)
	{
		echo 1;
	}
	else if ($a == 23 && $b == 23)
	{
		echo 0;
	}
	else if ($a == 23 && $b == 24)
	{
		echo -1;
	}
	else if ($a == 23 && $b == 25)
	{
		echo -2;
	}
	else if ($a == 23 && $b == 26)
	{
		echo -3;
	}
	else if ($a == 23 && $b == 27)
	{
		echo -4;
	}
	else if ($a == 23 && $b == 28)
	{
		echo -5;
	}
	else if ($a == 23 && $b == 29)
	{
		echo -6;
	}
	else if ($a == 23 && $b == 30)
	{
		echo -7;
	}
	else if ($a == 23 && $b == 31)
	{
		echo -8;
	}
	else if ($a == 23 && $b == 32)
	{
		echo -9;
	}
	else if ($a == 23 && $b == 33)
	{
		echo -10;
	}
	else if ($a == 23 && $b == 34)
	{
		echo -11;
	}
	else if ($a == 23 && $b == 35)
	{
		echo -12;
	}
	else if ($a == 23 && $b == 36)
	{
		echo -13;
	}
	else if ($a == 23 && $b == 37)
	{
		echo -14;
	}
	else if ($a == 23 && $b == 38)
	{
		echo -15;
	}
	else if ($a == 23 && $b == 39)
	{
		echo -16;
	}
	else if ($a == 23 && $b == 40)
	{
		echo -17;
	}
	else if ($a == 23 && $b == 41)
	{
		echo -18;
	}
	else if ($a == 23 && $b == 42)
	{
		echo -19;
	}
	else if ($a == 23 && $b == 43)
	{
		echo -20;
	}
	else if ($a == 23 && $b == 44)
	{
		echo -21;
	}
	else if ($a == 23 && $b == 45)
	{
		echo -22;
	}
	else if ($a == 23 && $b == 46)
	{
		echo -23;
	}
	else if ($a == 23 && $b == 47)
	{
		echo -24;
	}
	else if ($a == 23 && $b == 48)
	{
		echo -25;
	}
	else if ($a == 23 && $b == 49)
	{
		echo -26;
	}
	else if ($a == 23 && $b == 50)
	{
		echo -27;
	}
	else if ($a == 24 && $b == 0)
	{
		echo 24;
	}
	else if ($a == 24 && $b == 1)
	{
		echo 23;
	}
	else if ($a == 24 && $b == 2)
	{
		echo 22;
	}
	else if ($a == 24 && $b == 3)
	{
		echo 21;
	}
	else if ($a == 24 && $b == 4)
	{
		echo 20;
	}
	else if ($a == 24 && $b == 5)
	{
		echo 19;
	}
	else if ($a == 24 && $b == 6)
	{
		echo 18;
	}
	else if ($a == 24 && $b == 7)
	{
		echo 17;
	}
	else if ($a == 24 && $b == 8)
	{
		echo 16;
	}
	else if ($a == 24 && $b == 9)
	{
		echo 15;
	}
	else if ($a == 24 && $b == 10)
	{
		echo 14;
	}
	else if ($a == 24 && $b == 11)
	{
		echo 13;
	}
	else if ($a == 24 && $b == 12)
	{
		echo 12;
	}
	else if ($a == 24 && $b == 13)
	{
		echo 11;
	}
	else if ($a == 24 && $b == 14)
	{
		echo 10;
	}
	else if ($a == 24 && $b == 15)
	{
		echo 9;
	}
	else if ($a == 24 && $b == 16)
	{
		echo 8;
	}
	else if ($a == 24 && $b == 17)
	{
		echo 7;
	}
	else if ($a == 24 && $b == 18)
	{
		echo 6;
	}
	else if ($a == 24 && $b == 19)
	{
		echo 5;
	}
	else if ($a == 24 && $b == 20)
	{
		echo 4;
	}
	else if ($a == 24 && $b == 21)
	{
		echo 3;
	}
	else if ($a == 24 && $b == 22)
	{
		echo 2;
	}
	else if ($a == 24 && $b == 23)
	{
		echo 1;
	}
	else if ($a == 24 && $b == 24)
	{
		echo 0;
	}
	else if ($a == 24 && $b == 25)
	{
		echo -1;
	}
	else if ($a == 24 && $b == 26)
	{
		echo -2;
	}
	else if ($a == 24 && $b == 27)
	{
		echo -3;
	}
	else if ($a == 24 && $b == 28)
	{
		echo -4;
	}
	else if ($a == 24 && $b == 29)
	{
		echo -5;
	}
	else if ($a == 24 && $b == 30)
	{
		echo -6;
	}
	else if ($a == 24 && $b == 31)
	{
		echo -7;
	}
	else if ($a == 24 && $b == 32)
	{
		echo -8;
	}
	else if ($a == 24 && $b == 33)
	{
		echo -9;
	}
	else if ($a == 24 && $b == 34)
	{
		echo -10;
	}
	else if ($a == 24 && $b == 35)
	{
		echo -11;
	}
	else if ($a == 24 && $b == 36)
	{
		echo -12;
	}
	else if ($a == 24 && $b == 37)
	{
		echo -13;
	}
	else if ($a == 24 && $b == 38)
	{
		echo -14;
	}
	else if ($a == 24 && $b == 39)
	{
		echo -15;
	}
	else if ($a == 24 && $b == 40)
	{
		echo -16;
	}
	else if ($a == 24 && $b == 41)
	{
		echo -17;
	}
	else if ($a == 24 && $b == 42)
	{
		echo -18;
	}
	else if ($a == 24 && $b == 43)
	{
		echo -19;
	}
	else if ($a == 24 && $b == 44)
	{
		echo -20;
	}
	else if ($a == 24 && $b == 45)
	{
		echo -21;
	}
	else if ($a == 24 && $b == 46)
	{
		echo -22;
	}
	else if ($a == 24 && $b == 47)
	{
		echo -23;
	}
	else if ($a == 24 && $b == 48)
	{
		echo -24;
	}
	else if ($a == 24 && $b == 49)
	{
		echo -25;
	}
	else if ($a == 24 && $b == 50)
	{
		echo -26;
	}
	else if ($a == 25 && $b == 0)
	{
		echo 25;
	}
	else if ($a == 25 && $b == 1)
	{
		echo 24;
	}
	else if ($a == 25 && $b == 2)
	{
		echo 23;
	}
	else if ($a == 25 && $b == 3)
	{
		echo 22;
	}
	else if ($a == 25 && $b == 4)
	{
		echo 21;
	}
	else if ($a == 25 && $b == 5)
	{
		echo 20;
	}
	else if ($a == 25 && $b == 6)
	{
		echo 19;
	}
	else if ($a == 25 && $b == 7)
	{
		echo 18;
	}
	else if ($a == 25 && $b == 8)
	{
		echo 17;
	}
	else if ($a == 25 && $b == 9)
	{
		echo 16;
	}
	else if ($a == 25 && $b == 10)
	{
		echo 15;
	}
	else if ($a == 25 && $b == 11)
	{
		echo 14;
	}
	else if ($a == 25 && $b == 12)
	{
		echo 13;
	}
	else if ($a == 25 && $b == 13)
	{
		echo 12;
	}
	else if ($a == 25 && $b == 14)
	{
		echo 11;
	}
	else if ($a == 25 && $b == 15)
	{
		echo 10;
	}
	else if ($a == 25 && $b == 16)
	{
		echo 9;
	}
	else if ($a == 25 && $b == 17)
	{
		echo 8;
	}
	else if ($a == 25 && $b == 18)
	{
		echo 7;
	}
	else if ($a == 25 && $b == 19)
	{
		echo 6;
	}
	else if ($a == 25 && $b == 20)
	{
		echo 5;
	}
	else if ($a == 25 && $b == 21)
	{
		echo 4;
	}
	else if ($a == 25 && $b == 22)
	{
		echo 3;
	}
	else if ($a == 25 && $b == 23)
	{
		echo 2;
	}
	else if ($a == 25 && $b == 24)
	{
		echo 1;
	}
	else if ($a == 25 && $b == 25)
	{
		echo 0;
	}
	else if ($a == 25 && $b == 26)
	{
		echo -1;
	}
	else if ($a == 25 && $b == 27)
	{
		echo -2;
	}
	else if ($a == 25 && $b == 28)
	{
		echo -3;
	}
	else if ($a == 25 && $b == 29)
	{
		echo -4;
	}
	else if ($a == 25 && $b == 30)
	{
		echo -5;
	}
	else if ($a == 25 && $b == 31)
	{
		echo -6;
	}
	else if ($a == 25 && $b == 32)
	{
		echo -7;
	}
	else if ($a == 25 && $b == 33)
	{
		echo -8;
	}
	else if ($a == 25 && $b == 34)
	{
		echo -9;
	}
	else if ($a == 25 && $b == 35)
	{
		echo -10;
	}
	else if ($a == 25 && $b == 36)
	{
		echo -11;
	}
	else if ($a == 25 && $b == 37)
	{
		echo -12;
	}
	else if ($a == 25 && $b == 38)
	{
		echo -13;
	}
	else if ($a == 25 && $b == 39)
	{
		echo -14;
	}
	else if ($a == 25 && $b == 40)
	{
		echo -15;
	}
	else if ($a == 25 && $b == 41)
	{
		echo -16;
	}
	else if ($a == 25 && $b == 42)
	{
		echo -17;
	}
	else if ($a == 25 && $b == 43)
	{
		echo -18;
	}
	else if ($a == 25 && $b == 44)
	{
		echo -19;
	}
	else if ($a == 25 && $b == 45)
	{
		echo -20;
	}
	else if ($a == 25 && $b == 46)
	{
		echo -21;
	}
	else if ($a == 25 && $b == 47)
	{
		echo -22;
	}
	else if ($a == 25 && $b == 48)
	{
		echo -23;
	}
	else if ($a == 25 && $b == 49)
	{
		echo -24;
	}
	else if ($a == 25 && $b == 50)
	{
		echo -25;
	}
	else if ($a == 26 && $b == 0)
	{
		echo 26;
	}
	else if ($a == 26 && $b == 1)
	{
		echo 25;
	}
	else if ($a == 26 && $b == 2)
	{
		echo 24;
	}
	else if ($a == 26 && $b == 3)
	{
		echo 23;
	}
	else if ($a == 26 && $b == 4)
	{
		echo 22;
	}
	else if ($a == 26 && $b == 5)
	{
		echo 21;
	}
	else if ($a == 26 && $b == 6)
	{
		echo 20;
	}
	else if ($a == 26 && $b == 7)
	{
		echo 19;
	}
	else if ($a == 26 && $b == 8)
	{
		echo 18;
	}
	else if ($a == 26 && $b == 9)
	{
		echo 17;
	}
	else if ($a == 26 && $b == 10)
	{
		echo 16;
	}
	else if ($a == 26 && $b == 11)
	{
		echo 15;
	}
	else if ($a == 26 && $b == 12)
	{
		echo 14;
	}
	else if ($a == 26 && $b == 13)
	{
		echo 13;
	}
	else if ($a == 26 && $b == 14)
	{
		echo 12;
	}
	else if ($a == 26 && $b == 15)
	{
		echo 11;
	}
	else if ($a == 26 && $b == 16)
	{
		echo 10;
	}
	else if ($a == 26 && $b == 17)
	{
		echo 9;
	}
	else if ($a == 26 && $b == 18)
	{
		echo 8;
	}
	else if ($a == 26 && $b == 19)
	{
		echo 7;
	}
	else if ($a == 26 && $b == 20)
	{
		echo 6;
	}
	else if ($a == 26 && $b == 21)
	{
		echo 5;
	}
	else if ($a == 26 && $b == 22)
	{
		echo 4;
	}
	else if ($a == 26 && $b == 23)
	{
		echo 3;
	}
	else if ($a == 26 && $b == 24)
	{
		echo 2;
	}
	else if ($a == 26 && $b == 25)
	{
		echo 1;
	}
	else if ($a == 26 && $b == 26)
	{
		echo 0;
	}
	else if ($a == 26 && $b == 27)
	{
		echo -1;
	}
	else if ($a == 26 && $b == 28)
	{
		echo -2;
	}
	else if ($a == 26 && $b == 29)
	{
		echo -3;
	}
	else if ($a == 26 && $b == 30)
	{
		echo -4;
	}
	else if ($a == 26 && $b == 31)
	{
		echo -5;
	}
	else if ($a == 26 && $b == 32)
	{
		echo -6;
	}
	else if ($a == 26 && $b == 33)
	{
		echo -7;
	}
	else if ($a == 26 && $b == 34)
	{
		echo -8;
	}
	else if ($a == 26 && $b == 35)
	{
		echo -9;
	}
	else if ($a == 26 && $b == 36)
	{
		echo -10;
	}
	else if ($a == 26 && $b == 37)
	{
		echo -11;
	}
	else if ($a == 26 && $b == 38)
	{
		echo -12;
	}
	else if ($a == 26 && $b == 39)
	{
		echo -13;
	}
	else if ($a == 26 && $b == 40)
	{
		echo -14;
	}
	else if ($a == 26 && $b == 41)
	{
		echo -15;
	}
	else if ($a == 26 && $b == 42)
	{
		echo -16;
	}
	else if ($a == 26 && $b == 43)
	{
		echo -17;
	}
	else if ($a == 26 && $b == 44)
	{
		echo -18;
	}
	else if ($a == 26 && $b == 45)
	{
		echo -19;
	}
	else if ($a == 26 && $b == 46)
	{
		echo -20;
	}
	else if ($a == 26 && $b == 47)
	{
		echo -21;
	}
	else if ($a == 26 && $b == 48)
	{
		echo -22;
	}
	else if ($a == 26 && $b == 49)
	{
		echo -23;
	}
	else if ($a == 26 && $b == 50)
	{
		echo -24;
	}
	else if ($a == 27 && $b == 0)
	{
		echo 27;
	}
	else if ($a == 27 && $b == 1)
	{
		echo 26;
	}
	else if ($a == 27 && $b == 2)
	{
		echo 25;
	}
	else if ($a == 27 && $b == 3)
	{
		echo 24;
	}
	else if ($a == 27 && $b == 4)
	{
		echo 23;
	}
	else if ($a == 27 && $b == 5)
	{
		echo 22;
	}
	else if ($a == 27 && $b == 6)
	{
		echo 21;
	}
	else if ($a == 27 && $b == 7)
	{
		echo 20;
	}
	else if ($a == 27 && $b == 8)
	{
		echo 19;
	}
	else if ($a == 27 && $b == 9)
	{
		echo 18;
	}
	else if ($a == 27 && $b == 10)
	{
		echo 17;
	}
	else if ($a == 27 && $b == 11)
	{
		echo 16;
	}
	else if ($a == 27 && $b == 12)
	{
		echo 15;
	}
	else if ($a == 27 && $b == 13)
	{
		echo 14;
	}
	else if ($a == 27 && $b == 14)
	{
		echo 13;
	}
	else if ($a == 27 && $b == 15)
	{
		echo 12;
	}
	else if ($a == 27 && $b == 16)
	{
		echo 11;
	}
	else if ($a == 27 && $b == 17)
	{
		echo 10;
	}
	else if ($a == 27 && $b == 18)
	{
		echo 9;
	}
	else if ($a == 27 && $b == 19)
	{
		echo 8;
	}
	else if ($a == 27 && $b == 20)
	{
		echo 7;
	}
	else if ($a == 27 && $b == 21)
	{
		echo 6;
	}
	else if ($a == 27 && $b == 22)
	{
		echo 5;
	}
	else if ($a == 27 && $b == 23)
	{
		echo 4;
	}
	else if ($a == 27 && $b == 24)
	{
		echo 3;
	}
	else if ($a == 27 && $b == 25)
	{
		echo 2;
	}
	else if ($a == 27 && $b == 26)
	{
		echo 1;
	}
	else if ($a == 27 && $b == 27)
	{
		echo 0;
	}
	else if ($a == 27 && $b == 28)
	{
		echo -1;
	}
	else if ($a == 27 && $b == 29)
	{
		echo -2;
	}
	else if ($a == 27 && $b == 30)
	{
		echo -3;
	}
	else if ($a == 27 && $b == 31)
	{
		echo -4;
	}
	else if ($a == 27 && $b == 32)
	{
		echo -5;
	}
	else if ($a == 27 && $b == 33)
	{
		echo -6;
	}
	else if ($a == 27 && $b == 34)
	{
		echo -7;
	}
	else if ($a == 27 && $b == 35)
	{
		echo -8;
	}
	else if ($a == 27 && $b == 36)
	{
		echo -9;
	}
	else if ($a == 27 && $b == 37)
	{
		echo -10;
	}
	else if ($a == 27 && $b == 38)
	{
		echo -11;
	}
	else if ($a == 27 && $b == 39)
	{
		echo -12;
	}
	else if ($a == 27 && $b == 40)
	{
		echo -13;
	}
	else if ($a == 27 && $b == 41)
	{
		echo -14;
	}
	else if ($a == 27 && $b == 42)
	{
		echo -15;
	}
	else if ($a == 27 && $b == 43)
	{
		echo -16;
	}
	else if ($a == 27 && $b == 44)
	{
		echo -17;
	}
	else if ($a == 27 && $b == 45)
	{
		echo -18;
	}
	else if ($a == 27 && $b == 46)
	{
		echo -19;
	}
	else if ($a == 27 && $b == 47)
	{
		echo -20;
	}
	else if ($a == 27 && $b == 48)
	{
		echo -21;
	}
	else if ($a == 27 && $b == 49)
	{
		echo -22;
	}
	else if ($a == 27 && $b == 50)
	{
		echo -23;
	}
	else if ($a == 28 && $b == 0)
	{
		echo 28;
	}
	else if ($a == 28 && $b == 1)
	{
		echo 27;
	}
	else if ($a == 28 && $b == 2)
	{
		echo 26;
	}
	else if ($a == 28 && $b == 3)
	{
		echo 25;
	}
	else if ($a == 28 && $b == 4)
	{
		echo 24;
	}
	else if ($a == 28 && $b == 5)
	{
		echo 23;
	}
	else if ($a == 28 && $b == 6)
	{
		echo 22;
	}
	else if ($a == 28 && $b == 7)
	{
		echo 21;
	}
	else if ($a == 28 && $b == 8)
	{
		echo 20;
	}
	else if ($a == 28 && $b == 9)
	{
		echo 19;
	}
	else if ($a == 28 && $b == 10)
	{
		echo 18;
	}
	else if ($a == 28 && $b == 11)
	{
		echo 17;
	}
	else if ($a == 28 && $b == 12)
	{
		echo 16;
	}
	else if ($a == 28 && $b == 13)
	{
		echo 15;
	}
	else if ($a == 28 && $b == 14)
	{
		echo 14;
	}
	else if ($a == 28 && $b == 15)
	{
		echo 13;
	}
	else if ($a == 28 && $b == 16)
	{
		echo 12;
	}
	else if ($a == 28 && $b == 17)
	{
		echo 11;
	}
	else if ($a == 28 && $b == 18)
	{
		echo 10;
	}
	else if ($a == 28 && $b == 19)
	{
		echo 9;
	}
	else if ($a == 28 && $b == 20)
	{
		echo 8;
	}
	else if ($a == 28 && $b == 21)
	{
		echo 7;
	}
	else if ($a == 28 && $b == 22)
	{
		echo 6;
	}
	else if ($a == 28 && $b == 23)
	{
		echo 5;
	}
	else if ($a == 28 && $b == 24)
	{
		echo 4;
	}
	else if ($a == 28 && $b == 25)
	{
		echo 3;
	}
	else if ($a == 28 && $b == 26)
	{
		echo 2;
	}
	else if ($a == 28 && $b == 27)
	{
		echo 1;
	}
	else if ($a == 28 && $b == 28)
	{
		echo 0;
	}
	else if ($a == 28 && $b == 29)
	{
		echo -1;
	}
	else if ($a == 28 && $b == 30)
	{
		echo -2;
	}
	else if ($a == 28 && $b == 31)
	{
		echo -3;
	}
	else if ($a == 28 && $b == 32)
	{
		echo -4;
	}
	else if ($a == 28 && $b == 33)
	{
		echo -5;
	}
	else if ($a == 28 && $b == 34)
	{
		echo -6;
	}
	else if ($a == 28 && $b == 35)
	{
		echo -7;
	}
	else if ($a == 28 && $b == 36)
	{
		echo -8;
	}
	else if ($a == 28 && $b == 37)
	{
		echo -9;
	}
	else if ($a == 28 && $b == 38)
	{
		echo -10;
	}
	else if ($a == 28 && $b == 39)
	{
		echo -11;
	}
	else if ($a == 28 && $b == 40)
	{
		echo -12;
	}
	else if ($a == 28 && $b == 41)
	{
		echo -13;
	}
	else if ($a == 28 && $b == 42)
	{
		echo -14;
	}
	else if ($a == 28 && $b == 43)
	{
		echo -15;
	}
	else if ($a == 28 && $b == 44)
	{
		echo -16;
	}
	else if ($a == 28 && $b == 45)
	{
		echo -17;
	}
	else if ($a == 28 && $b == 46)
	{
		echo -18;
	}
	else if ($a == 28 && $b == 47)
	{
		echo -19;
	}
	else if ($a == 28 && $b == 48)
	{
		echo -20;
	}
	else if ($a == 28 && $b == 49)
	{
		echo -21;
	}
	else if ($a == 28 && $b == 50)
	{
		echo -22;
	}
	else if ($a == 29 && $b == 0)
	{
		echo 29;
	}
	else if ($a == 29 && $b == 1)
	{
		echo 28;
	}
	else if ($a == 29 && $b == 2)
	{
		echo 27;
	}
	else if ($a == 29 && $b == 3)
	{
		echo 26;
	}
	else if ($a == 29 && $b == 4)
	{
		echo 25;
	}
	else if ($a == 29 && $b == 5)
	{
		echo 24;
	}
	else if ($a == 29 && $b == 6)
	{
		echo 23;
	}
	else if ($a == 29 && $b == 7)
	{
		echo 22;
	}
	else if ($a == 29 && $b == 8)
	{
		echo 21;
	}
	else if ($a == 29 && $b == 9)
	{
		echo 20;
	}
	else if ($a == 29 && $b == 10)
	{
		echo 19;
	}
	else if ($a == 29 && $b == 11)
	{
		echo 18;
	}
	else if ($a == 29 && $b == 12)
	{
		echo 17;
	}
	else if ($a == 29 && $b == 13)
	{
		echo 16;
	}
	else if ($a == 29 && $b == 14)
	{
		echo 15;
	}
	else if ($a == 29 && $b == 15)
	{
		echo 14;
	}
	else if ($a == 29 && $b == 16)
	{
		echo 13;
	}
	else if ($a == 29 && $b == 17)
	{
		echo 12;
	}
	else if ($a == 29 && $b == 18)
	{
		echo 11;
	}
	else if ($a == 29 && $b == 19)
	{
		echo 10;
	}
	else if ($a == 29 && $b == 20)
	{
		echo 9;
	}
	else if ($a == 29 && $b == 21)
	{
		echo 8;
	}
	else if ($a == 29 && $b == 22)
	{
		echo 7;
	}
	else if ($a == 29 && $b == 23)
	{
		echo 6;
	}
	else if ($a == 29 && $b == 24)
	{
		echo 5;
	}
	else if ($a == 29 && $b == 25)
	{
		echo 4;
	}
	else if ($a == 29 && $b == 26)
	{
		echo 3;
	}
	else if ($a == 29 && $b == 27)
	{
		echo 2;
	}
	else if ($a == 29 && $b == 28)
	{
		echo 1;
	}
	else if ($a == 29 && $b == 29)
	{
		echo 0;
	}
	else if ($a == 29 && $b == 30)
	{
		echo -1;
	}
	else if ($a == 29 && $b == 31)
	{
		echo -2;
	}
	else if ($a == 29 && $b == 32)
	{
		echo -3;
	}
	else if ($a == 29 && $b == 33)
	{
		echo -4;
	}
	else if ($a == 29 && $b == 34)
	{
		echo -5;
	}
	else if ($a == 29 && $b == 35)
	{
		echo -6;
	}
	else if ($a == 29 && $b == 36)
	{
		echo -7;
	}
	else if ($a == 29 && $b == 37)
	{
		echo -8;
	}
	else if ($a == 29 && $b == 38)
	{
		echo -9;
	}
	else if ($a == 29 && $b == 39)
	{
		echo -10;
	}
	else if ($a == 29 && $b == 40)
	{
		echo -11;
	}
	else if ($a == 29 && $b == 41)
	{
		echo -12;
	}
	else if ($a == 29 && $b == 42)
	{
		echo -13;
	}
	else if ($a == 29 && $b == 43)
	{
		echo -14;
	}
	else if ($a == 29 && $b == 44)
	{
		echo -15;
	}
	else if ($a == 29 && $b == 45)
	{
		echo -16;
	}
	else if ($a == 29 && $b == 46)
	{
		echo -17;
	}
	else if ($a == 29 && $b == 47)
	{
		echo -18;
	}
	else if ($a == 29 && $b == 48)
	{
		echo -19;
	}
	else if ($a == 29 && $b == 49)
	{
		echo -20;
	}
	else if ($a == 29 && $b == 50)
	{
		echo -21;
	}
	else if ($a == 30 && $b == 0)
	{
		echo 30;
	}
	else if ($a == 30 && $b == 1)
	{
		echo 29;
	}
	else if ($a == 30 && $b == 2)
	{
		echo 28;
	}
	else if ($a == 30 && $b == 3)
	{
		echo 27;
	}
	else if ($a == 30 && $b == 4)
	{
		echo 26;
	}
	else if ($a == 30 && $b == 5)
	{
		echo 25;
	}
	else if ($a == 30 && $b == 6)
	{
		echo 24;
	}
	else if ($a == 30 && $b == 7)
	{
		echo 23;
	}
	else if ($a == 30 && $b == 8)
	{
		echo 22;
	}
	else if ($a == 30 && $b == 9)
	{
		echo 21;
	}
	else if ($a == 30 && $b == 10)
	{
		echo 20;
	}
	else if ($a == 30 && $b == 11)
	{
		echo 19;
	}
	else if ($a == 30 && $b == 12)
	{
		echo 18;
	}
	else if ($a == 30 && $b == 13)
	{
		echo 17;
	}
	else if ($a == 30 && $b == 14)
	{
		echo 16;
	}
	else if ($a == 30 && $b == 15)
	{
		echo 15;
	}
	else if ($a == 30 && $b == 16)
	{
		echo 14;
	}
	else if ($a == 30 && $b == 17)
	{
		echo 13;
	}
	else if ($a == 30 && $b == 18)
	{
		echo 12;
	}
	else if ($a == 30 && $b == 19)
	{
		echo 11;
	}
	else if ($a == 30 && $b == 20)
	{
		echo 10;
	}
	else if ($a == 30 && $b == 21)
	{
		echo 9;
	}
	else if ($a == 30 && $b == 22)
	{
		echo 8;
	}
	else if ($a == 30 && $b == 23)
	{
		echo 7;
	}
	else if ($a == 30 && $b == 24)
	{
		echo 6;
	}
	else if ($a == 30 && $b == 25)
	{
		echo 5;
	}
	else if ($a == 30 && $b == 26)
	{
		echo 4;
	}
	else if ($a == 30 && $b == 27)
	{
		echo 3;
	}
	else if ($a == 30 && $b == 28)
	{
		echo 2;
	}
	else if ($a == 30 && $b == 29)
	{
		echo 1;
	}
	else if ($a == 30 && $b == 30)
	{
		echo 0;
	}
	else if ($a == 30 && $b == 31)
	{
		echo -1;
	}
	else if ($a == 30 && $b == 32)
	{
		echo -2;
	}
	else if ($a == 30 && $b == 33)
	{
		echo -3;
	}
	else if ($a == 30 && $b == 34)
	{
		echo -4;
	}
	else if ($a == 30 && $b == 35)
	{
		echo -5;
	}
	else if ($a == 30 && $b == 36)
	{
		echo -6;
	}
	else if ($a == 30 && $b == 37)
	{
		echo -7;
	}
	else if ($a == 30 && $b == 38)
	{
		echo -8;
	}
	else if ($a == 30 && $b == 39)
	{
		echo -9;
	}
	else if ($a == 30 && $b == 40)
	{
		echo -10;
	}
	else if ($a == 30 && $b == 41)
	{
		echo -11;
	}
	else if ($a == 30 && $b == 42)
	{
		echo -12;
	}
	else if ($a == 30 && $b == 43)
	{
		echo -13;
	}
	else if ($a == 30 && $b == 44)
	{
		echo -14;
	}
	else if ($a == 30 && $b == 45)
	{
		echo -15;
	}
	else if ($a == 30 && $b == 46)
	{
		echo -16;
	}
	else if ($a == 30 && $b == 47)
	{
		echo -17;
	}
	else if ($a == 30 && $b == 48)
	{
		echo -18;
	}
	else if ($a == 30 && $b == 49)
	{
		echo -19;
	}
	else if ($a == 30 && $b == 50)
	{
		echo -20;
	}
	else if ($a == 31 && $b == 0)
	{
		echo 31;
	}
	else if ($a == 31 && $b == 1)
	{
		echo 30;
	}
	else if ($a == 31 && $b == 2)
	{
		echo 29;
	}
	else if ($a == 31 && $b == 3)
	{
		echo 28;
	}
	else if ($a == 31 && $b == 4)
	{
		echo 27;
	}
	else if ($a == 31 && $b == 5)
	{
		echo 26;
	}
	else if ($a == 31 && $b == 6)
	{
		echo 25;
	}
	else if ($a == 31 && $b == 7)
	{
		echo 24;
	}
	else if ($a == 31 && $b == 8)
	{
		echo 23;
	}
	else if ($a == 31 && $b == 9)
	{
		echo 22;
	}
	else if ($a == 31 && $b == 10)
	{
		echo 21;
	}
	else if ($a == 31 && $b == 11)
	{
		echo 20;
	}
	else if ($a == 31 && $b == 12)
	{
		echo 19;
	}
	else if ($a == 31 && $b == 13)
	{
		echo 18;
	}
	else if ($a == 31 && $b == 14)
	{
		echo 17;
	}
	else if ($a == 31 && $b == 15)
	{
		echo 16;
	}
	else if ($a == 31 && $b == 16)
	{
		echo 15;
	}
	else if ($a == 31 && $b == 17)
	{
		echo 14;
	}
	else if ($a == 31 && $b == 18)
	{
		echo 13;
	}
	else if ($a == 31 && $b == 19)
	{
		echo 12;
	}
	else if ($a == 31 && $b == 20)
	{
		echo 11;
	}
	else if ($a == 31 && $b == 21)
	{
		echo 10;
	}
	else if ($a == 31 && $b == 22)
	{
		echo 9;
	}
	else if ($a == 31 && $b == 23)
	{
		echo 8;
	}
	else if ($a == 31 && $b == 24)
	{
		echo 7;
	}
	else if ($a == 31 && $b == 25)
	{
		echo 6;
	}
	else if ($a == 31 && $b == 26)
	{
		echo 5;
	}
	else if ($a == 31 && $b == 27)
	{
		echo 4;
	}
	else if ($a == 31 && $b == 28)
	{
		echo 3;
	}
	else if ($a == 31 && $b == 29)
	{
		echo 2;
	}
	else if ($a == 31 && $b == 30)
	{
		echo 1;
	}
	else if ($a == 31 && $b == 31)
	{
		echo 0;
	}
	else if ($a == 31 && $b == 32)
	{
		echo -1;
	}
	else if ($a == 31 && $b == 33)
	{
		echo -2;
	}
	else if ($a == 31 && $b == 34)
	{
		echo -3;
	}
	else if ($a == 31 && $b == 35)
	{
		echo -4;
	}
	else if ($a == 31 && $b == 36)
	{
		echo -5;
	}
	else if ($a == 31 && $b == 37)
	{
		echo -6;
	}
	else if ($a == 31 && $b == 38)
	{
		echo -7;
	}
	else if ($a == 31 && $b == 39)
	{
		echo -8;
	}
	else if ($a == 31 && $b == 40)
	{
		echo -9;
	}
	else if ($a == 31 && $b == 41)
	{
		echo -10;
	}
	else if ($a == 31 && $b == 42)
	{
		echo -11;
	}
	else if ($a == 31 && $b == 43)
	{
		echo -12;
	}
	else if ($a == 31 && $b == 44)
	{
		echo -13;
	}
	else if ($a == 31 && $b == 45)
	{
		echo -14;
	}
	else if ($a == 31 && $b == 46)
	{
		echo -15;
	}
	else if ($a == 31 && $b == 47)
	{
		echo -16;
	}
	else if ($a == 31 && $b == 48)
	{
		echo -17;
	}
	else if ($a == 31 && $b == 49)
	{
		echo -18;
	}
	else if ($a == 31 && $b == 50)
	{
		echo -19;
	}
	else if ($a == 32 && $b == 0)
	{
		echo 32;
	}
	else if ($a == 32 && $b == 1)
	{
		echo 31;
	}
	else if ($a == 32 && $b == 2)
	{
		echo 30;
	}
	else if ($a == 32 && $b == 3)
	{
		echo 29;
	}
	else if ($a == 32 && $b == 4)
	{
		echo 28;
	}
	else if ($a == 32 && $b == 5)
	{
		echo 27;
	}
	else if ($a == 32 && $b == 6)
	{
		echo 26;
	}
	else if ($a == 32 && $b == 7)
	{
		echo 25;
	}
	else if ($a == 32 && $b == 8)
	{
		echo 24;
	}
	else if ($a == 32 && $b == 9)
	{
		echo 23;
	}
	else if ($a == 32 && $b == 10)
	{
		echo 22;
	}
	else if ($a == 32 && $b == 11)
	{
		echo 21;
	}
	else if ($a == 32 && $b == 12)
	{
		echo 20;
	}
	else if ($a == 32 && $b == 13)
	{
		echo 19;
	}
	else if ($a == 32 && $b == 14)
	{
		echo 18;
	}
	else if ($a == 32 && $b == 15)
	{
		echo 17;
	}
	else if ($a == 32 && $b == 16)
	{
		echo 16;
	}
	else if ($a == 32 && $b == 17)
	{
		echo 15;
	}
	else if ($a == 32 && $b == 18)
	{
		echo 14;
	}
	else if ($a == 32 && $b == 19)
	{
		echo 13;
	}
	else if ($a == 32 && $b == 20)
	{
		echo 12;
	}
	else if ($a == 32 && $b == 21)
	{
		echo 11;
	}
	else if ($a == 32 && $b == 22)
	{
		echo 10;
	}
	else if ($a == 32 && $b == 23)
	{
		echo 9;
	}
	else if ($a == 32 && $b == 24)
	{
		echo 8;
	}
	else if ($a == 32 && $b == 25)
	{
		echo 7;
	}
	else if ($a == 32 && $b == 26)
	{
		echo 6;
	}
	else if ($a == 32 && $b == 27)
	{
		echo 5;
	}
	else if ($a == 32 && $b == 28)
	{
		echo 4;
	}
	else if ($a == 32 && $b == 29)
	{
		echo 3;
	}
	else if ($a == 32 && $b == 30)
	{
		echo 2;
	}
	else if ($a == 32 && $b == 31)
	{
		echo 1;
	}
	else if ($a == 32 && $b == 32)
	{
		echo 0;
	}
	else if ($a == 32 && $b == 33)
	{
		echo -1;
	}
	else if ($a == 32 && $b == 34)
	{
		echo -2;
	}
	else if ($a == 32 && $b == 35)
	{
		echo -3;
	}
	else if ($a == 32 && $b == 36)
	{
		echo -4;
	}
	else if ($a == 32 && $b == 37)
	{
		echo -5;
	}
	else if ($a == 32 && $b == 38)
	{
		echo -6;
	}
	else if ($a == 32 && $b == 39)
	{
		echo -7;
	}
	else if ($a == 32 && $b == 40)
	{
		echo -8;
	}
	else if ($a == 32 && $b == 41)
	{
		echo -9;
	}
	else if ($a == 32 && $b == 42)
	{
		echo -10;
	}
	else if ($a == 32 && $b == 43)
	{
		echo -11;
	}
	else if ($a == 32 && $b == 44)
	{
		echo -12;
	}
	else if ($a == 32 && $b == 45)
	{
		echo -13;
	}
	else if ($a == 32 && $b == 46)
	{
		echo -14;
	}
	else if ($a == 32 && $b == 47)
	{
		echo -15;
	}
	else if ($a == 32 && $b == 48)
	{
		echo -16;
	}
	else if ($a == 32 && $b == 49)
	{
		echo -17;
	}
	else if ($a == 32 && $b == 50)
	{
		echo -18;
	}
	else if ($a == 33 && $b == 0)
	{
		echo 33;
	}
	else if ($a == 33 && $b == 1)
	{
		echo 32;
	}
	else if ($a == 33 && $b == 2)
	{
		echo 31;
	}
	else if ($a == 33 && $b == 3)
	{
		echo 30;
	}
	else if ($a == 33 && $b == 4)
	{
		echo 29;
	}
	else if ($a == 33 && $b == 5)
	{
		echo 28;
	}
	else if ($a == 33 && $b == 6)
	{
		echo 27;
	}
	else if ($a == 33 && $b == 7)
	{
		echo 26;
	}
	else if ($a == 33 && $b == 8)
	{
		echo 25;
	}
	else if ($a == 33 && $b == 9)
	{
		echo 24;
	}
	else if ($a == 33 && $b == 10)
	{
		echo 23;
	}
	else if ($a == 33 && $b == 11)
	{
		echo 22;
	}
	else if ($a == 33 && $b == 12)
	{
		echo 21;
	}
	else if ($a == 33 && $b == 13)
	{
		echo 20;
	}
	else if ($a == 33 && $b == 14)
	{
		echo 19;
	}
	else if ($a == 33 && $b == 15)
	{
		echo 18;
	}
	else if ($a == 33 && $b == 16)
	{
		echo 17;
	}
	else if ($a == 33 && $b == 17)
	{
		echo 16;
	}
	else if ($a == 33 && $b == 18)
	{
		echo 15;
	}
	else if ($a == 33 && $b == 19)
	{
		echo 14;
	}
	else if ($a == 33 && $b == 20)
	{
		echo 13;
	}
	else if ($a == 33 && $b == 21)
	{
		echo 12;
	}
	else if ($a == 33 && $b == 22)
	{
		echo 11;
	}
	else if ($a == 33 && $b == 23)
	{
		echo 10;
	}
	else if ($a == 33 && $b == 24)
	{
		echo 9;
	}
	else if ($a == 33 && $b == 25)
	{
		echo 8;
	}
	else if ($a == 33 && $b == 26)
	{
		echo 7;
	}
	else if ($a == 33 && $b == 27)
	{
		echo 6;
	}
	else if ($a == 33 && $b == 28)
	{
		echo 5;
	}
	else if ($a == 33 && $b == 29)
	{
		echo 4;
	}
	else if ($a == 33 && $b == 30)
	{
		echo 3;
	}
	else if ($a == 33 && $b == 31)
	{
		echo 2;
	}
	else if ($a == 33 && $b == 32)
	{
		echo 1;
	}
	else if ($a == 33 && $b == 33)
	{
		echo 0;
	}
	else if ($a == 33 && $b == 34)
	{
		echo -1;
	}
	else if ($a == 33 && $b == 35)
	{
		echo -2;
	}
	else if ($a == 33 && $b == 36)
	{
		echo -3;
	}
	else if ($a == 33 && $b == 37)
	{
		echo -4;
	}
	else if ($a == 33 && $b == 38)
	{
		echo -5;
	}
	else if ($a == 33 && $b == 39)
	{
		echo -6;
	}
	else if ($a == 33 && $b == 40)
	{
		echo -7;
	}
	else if ($a == 33 && $b == 41)
	{
		echo -8;
	}
	else if ($a == 33 && $b == 42)
	{
		echo -9;
	}
	else if ($a == 33 && $b == 43)
	{
		echo -10;
	}
	else if ($a == 33 && $b == 44)
	{
		echo -11;
	}
	else if ($a == 33 && $b == 45)
	{
		echo -12;
	}
	else if ($a == 33 && $b == 46)
	{
		echo -13;
	}
	else if ($a == 33 && $b == 47)
	{
		echo -14;
	}
	else if ($a == 33 && $b == 48)
	{
		echo -15;
	}
	else if ($a == 33 && $b == 49)
	{
		echo -16;
	}
	else if ($a == 33 && $b == 50)
	{
		echo -17;
	}
	else if ($a == 34 && $b == 0)
	{
		echo 34;
	}
	else if ($a == 34 && $b == 1)
	{
		echo 33;
	}
	else if ($a == 34 && $b == 2)
	{
		echo 32;
	}
	else if ($a == 34 && $b == 3)
	{
		echo 31;
	}
	else if ($a == 34 && $b == 4)
	{
		echo 30;
	}
	else if ($a == 34 && $b == 5)
	{
		echo 29;
	}
	else if ($a == 34 && $b == 6)
	{
		echo 28;
	}
	else if ($a == 34 && $b == 7)
	{
		echo 27;
	}
	else if ($a == 34 && $b == 8)
	{
		echo 26;
	}
	else if ($a == 34 && $b == 9)
	{
		echo 25;
	}
	else if ($a == 34 && $b == 10)
	{
		echo 24;
	}
	else if ($a == 34 && $b == 11)
	{
		echo 23;
	}
	else if ($a == 34 && $b == 12)
	{
		echo 22;
	}
	else if ($a == 34 && $b == 13)
	{
		echo 21;
	}
	else if ($a == 34 && $b == 14)
	{
		echo 20;
	}
	else if ($a == 34 && $b == 15)
	{
		echo 19;
	}
	else if ($a == 34 && $b == 16)
	{
		echo 18;
	}
	else if ($a == 34 && $b == 17)
	{
		echo 17;
	}
	else if ($a == 34 && $b == 18)
	{
		echo 16;
	}
	else if ($a == 34 && $b == 19)
	{
		echo 15;
	}
	else if ($a == 34 && $b == 20)
	{
		echo 14;
	}
	else if ($a == 34 && $b == 21)
	{
		echo 13;
	}
	else if ($a == 34 && $b == 22)
	{
		echo 12;
	}
	else if ($a == 34 && $b == 23)
	{
		echo 11;
	}
	else if ($a == 34 && $b == 24)
	{
		echo 10;
	}
	else if ($a == 34 && $b == 25)
	{
		echo 9;
	}
	else if ($a == 34 && $b == 26)
	{
		echo 8;
	}
	else if ($a == 34 && $b == 27)
	{
		echo 7;
	}
	else if ($a == 34 && $b == 28)
	{
		echo 6;
	}
	else if ($a == 34 && $b == 29)
	{
		echo 5;
	}
	else if ($a == 34 && $b == 30)
	{
		echo 4;
	}
	else if ($a == 34 && $b == 31)
	{
		echo 3;
	}
	else if ($a == 34 && $b == 32)
	{
		echo 2;
	}
	else if ($a == 34 && $b == 33)
	{
		echo 1;
	}
	else if ($a == 34 && $b == 34)
	{
		echo 0;
	}
	else if ($a == 34 && $b == 35)
	{
		echo -1;
	}
	else if ($a == 34 && $b == 36)
	{
		echo -2;
	}
	else if ($a == 34 && $b == 37)
	{
		echo -3;
	}
	else if ($a == 34 && $b == 38)
	{
		echo -4;
	}
	else if ($a == 34 && $b == 39)
	{
		echo -5;
	}
	else if ($a == 34 && $b == 40)
	{
		echo -6;
	}
	else if ($a == 34 && $b == 41)
	{
		echo -7;
	}
	else if ($a == 34 && $b == 42)
	{
		echo -8;
	}
	else if ($a == 34 && $b == 43)
	{
		echo -9;
	}
	else if ($a == 34 && $b == 44)
	{
		echo -10;
	}
	else if ($a == 34 && $b == 45)
	{
		echo -11;
	}
	else if ($a == 34 && $b == 46)
	{
		echo -12;
	}
	else if ($a == 34 && $b == 47)
	{
		echo -13;
	}
	else if ($a == 34 && $b == 48)
	{
		echo -14;
	}
	else if ($a == 34 && $b == 49)
	{
		echo -15;
	}
	else if ($a == 34 && $b == 50)
	{
		echo -16;
	}
	else if ($a == 35 && $b == 0)
	{
		echo 35;
	}
	else if ($a == 35 && $b == 1)
	{
		echo 34;
	}
	else if ($a == 35 && $b == 2)
	{
		echo 33;
	}
	else if ($a == 35 && $b == 3)
	{
		echo 32;
	}
	else if ($a == 35 && $b == 4)
	{
		echo 31;
	}
	else if ($a == 35 && $b == 5)
	{
		echo 30;
	}
	else if ($a == 35 && $b == 6)
	{
		echo 29;
	}
	else if ($a == 35 && $b == 7)
	{
		echo 28;
	}
	else if ($a == 35 && $b == 8)
	{
		echo 27;
	}
	else if ($a == 35 && $b == 9)
	{
		echo 26;
	}
	else if ($a == 35 && $b == 10)
	{
		echo 25;
	}
	else if ($a == 35 && $b == 11)
	{
		echo 24;
	}
	else if ($a == 35 && $b == 12)
	{
		echo 23;
	}
	else if ($a == 35 && $b == 13)
	{
		echo 22;
	}
	else if ($a == 35 && $b == 14)
	{
		echo 21;
	}
	else if ($a == 35 && $b == 15)
	{
		echo 20;
	}
	else if ($a == 35 && $b == 16)
	{
		echo 19;
	}
	else if ($a == 35 && $b == 17)
	{
		echo 18;
	}
	else if ($a == 35 && $b == 18)
	{
		echo 17;
	}
	else if ($a == 35 && $b == 19)
	{
		echo 16;
	}
	else if ($a == 35 && $b == 20)
	{
		echo 15;
	}
	else if ($a == 35 && $b == 21)
	{
		echo 14;
	}
	else if ($a == 35 && $b == 22)
	{
		echo 13;
	}
	else if ($a == 35 && $b == 23)
	{
		echo 12;
	}
	else if ($a == 35 && $b == 24)
	{
		echo 11;
	}
	else if ($a == 35 && $b == 25)
	{
		echo 10;
	}
	else if ($a == 35 && $b == 26)
	{
		echo 9;
	}
	else if ($a == 35 && $b == 27)
	{
		echo 8;
	}
	else if ($a == 35 && $b == 28)
	{
		echo 7;
	}
	else if ($a == 35 && $b == 29)
	{
		echo 6;
	}
	else if ($a == 35 && $b == 30)
	{
		echo 5;
	}
	else if ($a == 35 && $b == 31)
	{
		echo 4;
	}
	else if ($a == 35 && $b == 32)
	{
		echo 3;
	}
	else if ($a == 35 && $b == 33)
	{
		echo 2;
	}
	else if ($a == 35 && $b == 34)
	{
		echo 1;
	}
	else if ($a == 35 && $b == 35)
	{
		echo 0;
	}
	else if ($a == 35 && $b == 36)
	{
		echo -1;
	}
	else if ($a == 35 && $b == 37)
	{
		echo -2;
	}
	else if ($a == 35 && $b == 38)
	{
		echo -3;
	}
	else if ($a == 35 && $b == 39)
	{
		echo -4;
	}
	else if ($a == 35 && $b == 40)
	{
		echo -5;
	}
	else if ($a == 35 && $b == 41)
	{
		echo -6;
	}
	else if ($a == 35 && $b == 42)
	{
		echo -7;
	}
	else if ($a == 35 && $b == 43)
	{
		echo -8;
	}
	else if ($a == 35 && $b == 44)
	{
		echo -9;
	}
	else if ($a == 35 && $b == 45)
	{
		echo -10;
	}
	else if ($a == 35 && $b == 46)
	{
		echo -11;
	}
	else if ($a == 35 && $b == 47)
	{
		echo -12;
	}
	else if ($a == 35 && $b == 48)
	{
		echo -13;
	}
	else if ($a == 35 && $b == 49)
	{
		echo -14;
	}
	else if ($a == 35 && $b == 50)
	{
		echo -15;
	}
	else if ($a == 36 && $b == 0)
	{
		echo 36;
	}
	else if ($a == 36 && $b == 1)
	{
		echo 35;
	}
	else if ($a == 36 && $b == 2)
	{
		echo 34;
	}
	else if ($a == 36 && $b == 3)
	{
		echo 33;
	}
	else if ($a == 36 && $b == 4)
	{
		echo 32;
	}
	else if ($a == 36 && $b == 5)
	{
		echo 31;
	}
	else if ($a == 36 && $b == 6)
	{
		echo 30;
	}
	else if ($a == 36 && $b == 7)
	{
		echo 29;
	}
	else if ($a == 36 && $b == 8)
	{
		echo 28;
	}
	else if ($a == 36 && $b == 9)
	{
		echo 27;
	}
	else if ($a == 36 && $b == 10)
	{
		echo 26;
	}
	else if ($a == 36 && $b == 11)
	{
		echo 25;
	}
	else if ($a == 36 && $b == 12)
	{
		echo 24;
	}
	else if ($a == 36 && $b == 13)
	{
		echo 23;
	}
	else if ($a == 36 && $b == 14)
	{
		echo 22;
	}
	else if ($a == 36 && $b == 15)
	{
		echo 21;
	}
	else if ($a == 36 && $b == 16)
	{
		echo 20;
	}
	else if ($a == 36 && $b == 17)
	{
		echo 19;
	}
	else if ($a == 36 && $b == 18)
	{
		echo 18;
	}
	else if ($a == 36 && $b == 19)
	{
		echo 17;
	}
	else if ($a == 36 && $b == 20)
	{
		echo 16;
	}
	else if ($a == 36 && $b == 21)
	{
		echo 15;
	}
	else if ($a == 36 && $b == 22)
	{
		echo 14;
	}
	else if ($a == 36 && $b == 23)
	{
		echo 13;
	}
	else if ($a == 36 && $b == 24)
	{
		echo 12;
	}
	else if ($a == 36 && $b == 25)
	{
		echo 11;
	}
	else if ($a == 36 && $b == 26)
	{
		echo 10;
	}
	else if ($a == 36 && $b == 27)
	{
		echo 9;
	}
	else if ($a == 36 && $b == 28)
	{
		echo 8;
	}
	else if ($a == 36 && $b == 29)
	{
		echo 7;
	}
	else if ($a == 36 && $b == 30)
	{
		echo 6;
	}
	else if ($a == 36 && $b == 31)
	{
		echo 5;
	}
	else if ($a == 36 && $b == 32)
	{
		echo 4;
	}
	else if ($a == 36 && $b == 33)
	{
		echo 3;
	}
	else if ($a == 36 && $b == 34)
	{
		echo 2;
	}
	else if ($a == 36 && $b == 35)
	{
		echo 1;
	}
	else if ($a == 36 && $b == 36)
	{
		echo 0;
	}
	else if ($a == 36 && $b == 37)
	{
		echo -1;
	}
	else if ($a == 36 && $b == 38)
	{
		echo -2;
	}
	else if ($a == 36 && $b == 39)
	{
		echo -3;
	}
	else if ($a == 36 && $b == 40)
	{
		echo -4;
	}
	else if ($a == 36 && $b == 41)
	{
		echo -5;
	}
	else if ($a == 36 && $b == 42)
	{
		echo -6;
	}
	else if ($a == 36 && $b == 43)
	{
		echo -7;
	}
	else if ($a == 36 && $b == 44)
	{
		echo -8;
	}
	else if ($a == 36 && $b == 45)
	{
		echo -9;
	}
	else if ($a == 36 && $b == 46)
	{
		echo -10;
	}
	else if ($a == 36 && $b == 47)
	{
		echo -11;
	}
	else if ($a == 36 && $b == 48)
	{
		echo -12;
	}
	else if ($a == 36 && $b == 49)
	{
		echo -13;
	}
	else if ($a == 36 && $b == 50)
	{
		echo -14;
	}
	else if ($a == 37 && $b == 0)
	{
		echo 37;
	}
	else if ($a == 37 && $b == 1)
	{
		echo 36;
	}
	else if ($a == 37 && $b == 2)
	{
		echo 35;
	}
	else if ($a == 37 && $b == 3)
	{
		echo 34;
	}
	else if ($a == 37 && $b == 4)
	{
		echo 33;
	}
	else if ($a == 37 && $b == 5)
	{
		echo 32;
	}
	else if ($a == 37 && $b == 6)
	{
		echo 31;
	}
	else if ($a == 37 && $b == 7)
	{
		echo 30;
	}
	else if ($a == 37 && $b == 8)
	{
		echo 29;
	}
	else if ($a == 37 && $b == 9)
	{
		echo 28;
	}
	else if ($a == 37 && $b == 10)
	{
		echo 27;
	}
	else if ($a == 37 && $b == 11)
	{
		echo 26;
	}
	else if ($a == 37 && $b == 12)
	{
		echo 25;
	}
	else if ($a == 37 && $b == 13)
	{
		echo 24;
	}
	else if ($a == 37 && $b == 14)
	{
		echo 23;
	}
	else if ($a == 37 && $b == 15)
	{
		echo 22;
	}
	else if ($a == 37 && $b == 16)
	{
		echo 21;
	}
	else if ($a == 37 && $b == 17)
	{
		echo 20;
	}
	else if ($a == 37 && $b == 18)
	{
		echo 19;
	}
	else if ($a == 37 && $b == 19)
	{
		echo 18;
	}
	else if ($a == 37 && $b == 20)
	{
		echo 17;
	}
	else if ($a == 37 && $b == 21)
	{
		echo 16;
	}
	else if ($a == 37 && $b == 22)
	{
		echo 15;
	}
	else if ($a == 37 && $b == 23)
	{
		echo 14;
	}
	else if ($a == 37 && $b == 24)
	{
		echo 13;
	}
	else if ($a == 37 && $b == 25)
	{
		echo 12;
	}
	else if ($a == 37 && $b == 26)
	{
		echo 11;
	}
	else if ($a == 37 && $b == 27)
	{
		echo 10;
	}
	else if ($a == 37 && $b == 28)
	{
		echo 9;
	}
	else if ($a == 37 && $b == 29)
	{
		echo 8;
	}
	else if ($a == 37 && $b == 30)
	{
		echo 7;
	}
	else if ($a == 37 && $b == 31)
	{
		echo 6;
	}
	else if ($a == 37 && $b == 32)
	{
		echo 5;
	}
	else if ($a == 37 && $b == 33)
	{
		echo 4;
	}
	else if ($a == 37 && $b == 34)
	{
		echo 3;
	}
	else if ($a == 37 && $b == 35)
	{
		echo 2;
	}
	else if ($a == 37 && $b == 36)
	{
		echo 1;
	}
	else if ($a == 37 && $b == 37)
	{
		echo 0;
	}
	else if ($a == 37 && $b == 38)
	{
		echo -1;
	}
	else if ($a == 37 && $b == 39)
	{
		echo -2;
	}
	else if ($a == 37 && $b == 40)
	{
		echo -3;
	}
	else if ($a == 37 && $b == 41)
	{
		echo -4;
	}
	else if ($a == 37 && $b == 42)
	{
		echo -5;
	}
	else if ($a == 37 && $b == 43)
	{
		echo -6;
	}
	else if ($a == 37 && $b == 44)
	{
		echo -7;
	}
	else if ($a == 37 && $b == 45)
	{
		echo -8;
	}
	else if ($a == 37 && $b == 46)
	{
		echo -9;
	}
	else if ($a == 37 && $b == 47)
	{
		echo -10;
	}
	else if ($a == 37 && $b == 48)
	{
		echo -11;
	}
	else if ($a == 37 && $b == 49)
	{
		echo -12;
	}
	else if ($a == 37 && $b == 50)
	{
		echo -13;
	}
	else if ($a == 38 && $b == 0)
	{
		echo 38;
	}
	else if ($a == 38 && $b == 1)
	{
		echo 37;
	}
	else if ($a == 38 && $b == 2)
	{
		echo 36;
	}
	else if ($a == 38 && $b == 3)
	{
		echo 35;
	}
	else if ($a == 38 && $b == 4)
	{
		echo 34;
	}
	else if ($a == 38 && $b == 5)
	{
		echo 33;
	}
	else if ($a == 38 && $b == 6)
	{
		echo 32;
	}
	else if ($a == 38 && $b == 7)
	{
		echo 31;
	}
	else if ($a == 38 && $b == 8)
	{
		echo 30;
	}
	else if ($a == 38 && $b == 9)
	{
		echo 29;
	}
	else if ($a == 38 && $b == 10)
	{
		echo 28;
	}
	else if ($a == 38 && $b == 11)
	{
		echo 27;
	}
	else if ($a == 38 && $b == 12)
	{
		echo 26;
	}
	else if ($a == 38 && $b == 13)
	{
		echo 25;
	}
	else if ($a == 38 && $b == 14)
	{
		echo 24;
	}
	else if ($a == 38 && $b == 15)
	{
		echo 23;
	}
	else if ($a == 38 && $b == 16)
	{
		echo 22;
	}
	else if ($a == 38 && $b == 17)
	{
		echo 21;
	}
	else if ($a == 38 && $b == 18)
	{
		echo 20;
	}
	else if ($a == 38 && $b == 19)
	{
		echo 19;
	}
	else if ($a == 38 && $b == 20)
	{
		echo 18;
	}
	else if ($a == 38 && $b == 21)
	{
		echo 17;
	}
	else if ($a == 38 && $b == 22)
	{
		echo 16;
	}
	else if ($a == 38 && $b == 23)
	{
		echo 15;
	}
	else if ($a == 38 && $b == 24)
	{
		echo 14;
	}
	else if ($a == 38 && $b == 25)
	{
		echo 13;
	}
	else if ($a == 38 && $b == 26)
	{
		echo 12;
	}
	else if ($a == 38 && $b == 27)
	{
		echo 11;
	}
	else if ($a == 38 && $b == 28)
	{
		echo 10;
	}
	else if ($a == 38 && $b == 29)
	{
		echo 9;
	}
	else if ($a == 38 && $b == 30)
	{
		echo 8;
	}
	else if ($a == 38 && $b == 31)
	{
		echo 7;
	}
	else if ($a == 38 && $b == 32)
	{
		echo 6;
	}
	else if ($a == 38 && $b == 33)
	{
		echo 5;
	}
	else if ($a == 38 && $b == 34)
	{
		echo 4;
	}
	else if ($a == 38 && $b == 35)
	{
		echo 3;
	}
	else if ($a == 38 && $b == 36)
	{
		echo 2;
	}
	else if ($a == 38 && $b == 37)
	{
		echo 1;
	}
	else if ($a == 38 && $b == 38)
	{
		echo 0;
	}
	else if ($a == 38 && $b == 39)
	{
		echo -1;
	}
	else if ($a == 38 && $b == 40)
	{
		echo -2;
	}
	else if ($a == 38 && $b == 41)
	{
		echo -3;
	}
	else if ($a == 38 && $b == 42)
	{
		echo -4;
	}
	else if ($a == 38 && $b == 43)
	{
		echo -5;
	}
	else if ($a == 38 && $b == 44)
	{
		echo -6;
	}
	else if ($a == 38 && $b == 45)
	{
		echo -7;
	}
	else if ($a == 38 && $b == 46)
	{
		echo -8;
	}
	else if ($a == 38 && $b == 47)
	{
		echo -9;
	}
	else if ($a == 38 && $b == 48)
	{
		echo -10;
	}
	else if ($a == 38 && $b == 49)
	{
		echo -11;
	}
	else if ($a == 38 && $b == 50)
	{
		echo -12;
	}
	else if ($a == 39 && $b == 0)
	{
		echo 39;
	}
	else if ($a == 39 && $b == 1)
	{
		echo 38;
	}
	else if ($a == 39 && $b == 2)
	{
		echo 37;
	}
	else if ($a == 39 && $b == 3)
	{
		echo 36;
	}
	else if ($a == 39 && $b == 4)
	{
		echo 35;
	}
	else if ($a == 39 && $b == 5)
	{
		echo 34;
	}
	else if ($a == 39 && $b == 6)
	{
		echo 33;
	}
	else if ($a == 39 && $b == 7)
	{
		echo 32;
	}
	else if ($a == 39 && $b == 8)
	{
		echo 31;
	}
	else if ($a == 39 && $b == 9)
	{
		echo 30;
	}
	else if ($a == 39 && $b == 10)
	{
		echo 29;
	}
	else if ($a == 39 && $b == 11)
	{
		echo 28;
	}
	else if ($a == 39 && $b == 12)
	{
		echo 27;
	}
	else if ($a == 39 && $b == 13)
	{
		echo 26;
	}
	else if ($a == 39 && $b == 14)
	{
		echo 25;
	}
	else if ($a == 39 && $b == 15)
	{
		echo 24;
	}
	else if ($a == 39 && $b == 16)
	{
		echo 23;
	}
	else if ($a == 39 && $b == 17)
	{
		echo 22;
	}
	else if ($a == 39 && $b == 18)
	{
		echo 21;
	}
	else if ($a == 39 && $b == 19)
	{
		echo 20;
	}
	else if ($a == 39 && $b == 20)
	{
		echo 19;
	}
	else if ($a == 39 && $b == 21)
	{
		echo 18;
	}
	else if ($a == 39 && $b == 22)
	{
		echo 17;
	}
	else if ($a == 39 && $b == 23)
	{
		echo 16;
	}
	else if ($a == 39 && $b == 24)
	{
		echo 15;
	}
	else if ($a == 39 && $b == 25)
	{
		echo 14;
	}
	else if ($a == 39 && $b == 26)
	{
		echo 13;
	}
	else if ($a == 39 && $b == 27)
	{
		echo 12;
	}
	else if ($a == 39 && $b == 28)
	{
		echo 11;
	}
	else if ($a == 39 && $b == 29)
	{
		echo 10;
	}
	else if ($a == 39 && $b == 30)
	{
		echo 9;
	}
	else if ($a == 39 && $b == 31)
	{
		echo 8;
	}
	else if ($a == 39 && $b == 32)
	{
		echo 7;
	}
	else if ($a == 39 && $b == 33)
	{
		echo 6;
	}
	else if ($a == 39 && $b == 34)
	{
		echo 5;
	}
	else if ($a == 39 && $b == 35)
	{
		echo 4;
	}
	else if ($a == 39 && $b == 36)
	{
		echo 3;
	}
	else if ($a == 39 && $b == 37)
	{
		echo 2;
	}
	else if ($a == 39 && $b == 38)
	{
		echo 1;
	}
	else if ($a == 39 && $b == 39)
	{
		echo 0;
	}
	else if ($a == 39 && $b == 40)
	{
		echo -1;
	}
	else if ($a == 39 && $b == 41)
	{
		echo -2;
	}
	else if ($a == 39 && $b == 42)
	{
		echo -3;
	}
	else if ($a == 39 && $b == 43)
	{
		echo -4;
	}
	else if ($a == 39 && $b == 44)
	{
		echo -5;
	}
	else if ($a == 39 && $b == 45)
	{
		echo -6;
	}
	else if ($a == 39 && $b == 46)
	{
		echo -7;
	}
	else if ($a == 39 && $b == 47)
	{
		echo -8;
	}
	else if ($a == 39 && $b == 48)
	{
		echo -9;
	}
	else if ($a == 39 && $b == 49)
	{
		echo -10;
	}
	else if ($a == 39 && $b == 50)
	{
		echo -11;
	}
	else if ($a == 40 && $b == 0)
	{
		echo 40;
	}
	else if ($a == 40 && $b == 1)
	{
		echo 39;
	}
	else if ($a == 40 && $b == 2)
	{
		echo 38;
	}
	else if ($a == 40 && $b == 3)
	{
		echo 37;
	}
	else if ($a == 40 && $b == 4)
	{
		echo 36;
	}
	else if ($a == 40 && $b == 5)
	{
		echo 35;
	}
	else if ($a == 40 && $b == 6)
	{
		echo 34;
	}
	else if ($a == 40 && $b == 7)
	{
		echo 33;
	}
	else if ($a == 40 && $b == 8)
	{
		echo 32;
	}
	else if ($a == 40 && $b == 9)
	{
		echo 31;
	}
	else if ($a == 40 && $b == 10)
	{
		echo 30;
	}
	else if ($a == 40 && $b == 11)
	{
		echo 29;
	}
	else if ($a == 40 && $b == 12)
	{
		echo 28;
	}
	else if ($a == 40 && $b == 13)
	{
		echo 27;
	}
	else if ($a == 40 && $b == 14)
	{
		echo 26;
	}
	else if ($a == 40 && $b == 15)
	{
		echo 25;
	}
	else if ($a == 40 && $b == 16)
	{
		echo 24;
	}
	else if ($a == 40 && $b == 17)
	{
		echo 23;
	}
	else if ($a == 40 && $b == 18)
	{
		echo 22;
	}
	else if ($a == 40 && $b == 19)
	{
		echo 21;
	}
	else if ($a == 40 && $b == 20)
	{
		echo 20;
	}
	else if ($a == 40 && $b == 21)
	{
		echo 19;
	}
	else if ($a == 40 && $b == 22)
	{
		echo 18;
	}
	else if ($a == 40 && $b == 23)
	{
		echo 17;
	}
	else if ($a == 40 && $b == 24)
	{
		echo 16;
	}
	else if ($a == 40 && $b == 25)
	{
		echo 15;
	}
	else if ($a == 40 && $b == 26)
	{
		echo 14;
	}
	else if ($a == 40 && $b == 27)
	{
		echo 13;
	}
	else if ($a == 40 && $b == 28)
	{
		echo 12;
	}
	else if ($a == 40 && $b == 29)
	{
		echo 11;
	}
	else if ($a == 40 && $b == 30)
	{
		echo 10;
	}
	else if ($a == 40 && $b == 31)
	{
		echo 9;
	}
	else if ($a == 40 && $b == 32)
	{
		echo 8;
	}
	else if ($a == 40 && $b == 33)
	{
		echo 7;
	}
	else if ($a == 40 && $b == 34)
	{
		echo 6;
	}
	else if ($a == 40 && $b == 35)
	{
		echo 5;
	}
	else if ($a == 40 && $b == 36)
	{
		echo 4;
	}
	else if ($a == 40 && $b == 37)
	{
		echo 3;
	}
	else if ($a == 40 && $b == 38)
	{
		echo 2;
	}
	else if ($a == 40 && $b == 39)
	{
		echo 1;
	}
	else if ($a == 40 && $b == 40)
	{
		echo 0;
	}
	else if ($a == 40 && $b == 41)
	{
		echo -1;
	}
	else if ($a == 40 && $b == 42)
	{
		echo -2;
	}
	else if ($a == 40 && $b == 43)
	{
		echo -3;
	}
	else if ($a == 40 && $b == 44)
	{
		echo -4;
	}
	else if ($a == 40 && $b == 45)
	{
		echo -5;
	}
	else if ($a == 40 && $b == 46)
	{
		echo -6;
	}
	else if ($a == 40 && $b == 47)
	{
		echo -7;
	}
	else if ($a == 40 && $b == 48)
	{
		echo -8;
	}
	else if ($a == 40 && $b == 49)
	{
		echo -9;
	}
	else if ($a == 40 && $b == 50)
	{
		echo -10;
	}
	else if ($a == 41 && $b == 0)
	{
		echo 41;
	}
	else if ($a == 41 && $b == 1)
	{
		echo 40;
	}
	else if ($a == 41 && $b == 2)
	{
		echo 39;
	}
	else if ($a == 41 && $b == 3)
	{
		echo 38;
	}
	else if ($a == 41 && $b == 4)
	{
		echo 37;
	}
	else if ($a == 41 && $b == 5)
	{
		echo 36;
	}
	else if ($a == 41 && $b == 6)
	{
		echo 35;
	}
	else if ($a == 41 && $b == 7)
	{
		echo 34;
	}
	else if ($a == 41 && $b == 8)
	{
		echo 33;
	}
	else if ($a == 41 && $b == 9)
	{
		echo 32;
	}
	else if ($a == 41 && $b == 10)
	{
		echo 31;
	}
	else if ($a == 41 && $b == 11)
	{
		echo 30;
	}
	else if ($a == 41 && $b == 12)
	{
		echo 29;
	}
	else if ($a == 41 && $b == 13)
	{
		echo 28;
	}
	else if ($a == 41 && $b == 14)
	{
		echo 27;
	}
	else if ($a == 41 && $b == 15)
	{
		echo 26;
	}
	else if ($a == 41 && $b == 16)
	{
		echo 25;
	}
	else if ($a == 41 && $b == 17)
	{
		echo 24;
	}
	else if ($a == 41 && $b == 18)
	{
		echo 23;
	}
	else if ($a == 41 && $b == 19)
	{
		echo 22;
	}
	else if ($a == 41 && $b == 20)
	{
		echo 21;
	}
	else if ($a == 41 && $b == 21)
	{
		echo 20;
	}
	else if ($a == 41 && $b == 22)
	{
		echo 19;
	}
	else if ($a == 41 && $b == 23)
	{
		echo 18;
	}
	else if ($a == 41 && $b == 24)
	{
		echo 17;
	}
	else if ($a == 41 && $b == 25)
	{
		echo 16;
	}
	else if ($a == 41 && $b == 26)
	{
		echo 15;
	}
	else if ($a == 41 && $b == 27)
	{
		echo 14;
	}
	else if ($a == 41 && $b == 28)
	{
		echo 13;
	}
	else if ($a == 41 && $b == 29)
	{
		echo 12;
	}
	else if ($a == 41 && $b == 30)
	{
		echo 11;
	}
	else if ($a == 41 && $b == 31)
	{
		echo 10;
	}
	else if ($a == 41 && $b == 32)
	{
		echo 9;
	}
	else if ($a == 41 && $b == 33)
	{
		echo 8;
	}
	else if ($a == 41 && $b == 34)
	{
		echo 7;
	}
	else if ($a == 41 && $b == 35)
	{
		echo 6;
	}
	else if ($a == 41 && $b == 36)
	{
		echo 5;
	}
	else if ($a == 41 && $b == 37)
	{
		echo 4;
	}
	else if ($a == 41 && $b == 38)
	{
		echo 3;
	}
	else if ($a == 41 && $b == 39)
	{
		echo 2;
	}
	else if ($a == 41 && $b == 40)
	{
		echo 1;
	}
	else if ($a == 41 && $b == 41)
	{
		echo 0;
	}
	else if ($a == 41 && $b == 42)
	{
		echo -1;
	}
	else if ($a == 41 && $b == 43)
	{
		echo -2;
	}
	else if ($a == 41 && $b == 44)
	{
		echo -3;
	}
	else if ($a == 41 && $b == 45)
	{
		echo -4;
	}
	else if ($a == 41 && $b == 46)
	{
		echo -5;
	}
	else if ($a == 41 && $b == 47)
	{
		echo -6;
	}
	else if ($a == 41 && $b == 48)
	{
		echo -7;
	}
	else if ($a == 41 && $b == 49)
	{
		echo -8;
	}
	else if ($a == 41 && $b == 50)
	{
		echo -9;
	}
	else if ($a == 42 && $b == 0)
	{
		echo 42;
	}
	else if ($a == 42 && $b == 1)
	{
		echo 41;
	}
	else if ($a == 42 && $b == 2)
	{
		echo 40;
	}
	else if ($a == 42 && $b == 3)
	{
		echo 39;
	}
	else if ($a == 42 && $b == 4)
	{
		echo 38;
	}
	else if ($a == 42 && $b == 5)
	{
		echo 37;
	}
	else if ($a == 42 && $b == 6)
	{
		echo 36;
	}
	else if ($a == 42 && $b == 7)
	{
		echo 35;
	}
	else if ($a == 42 && $b == 8)
	{
		echo 34;
	}
	else if ($a == 42 && $b == 9)
	{
		echo 33;
	}
	else if ($a == 42 && $b == 10)
	{
		echo 32;
	}
	else if ($a == 42 && $b == 11)
	{
		echo 31;
	}
	else if ($a == 42 && $b == 12)
	{
		echo 30;
	}
	else if ($a == 42 && $b == 13)
	{
		echo 29;
	}
	else if ($a == 42 && $b == 14)
	{
		echo 28;
	}
	else if ($a == 42 && $b == 15)
	{
		echo 27;
	}
	else if ($a == 42 && $b == 16)
	{
		echo 26;
	}
	else if ($a == 42 && $b == 17)
	{
		echo 25;
	}
	else if ($a == 42 && $b == 18)
	{
		echo 24;
	}
	else if ($a == 42 && $b == 19)
	{
		echo 23;
	}
	else if ($a == 42 && $b == 20)
	{
		echo 22;
	}
	else if ($a == 42 && $b == 21)
	{
		echo 21;
	}
	else if ($a == 42 && $b == 22)
	{
		echo 20;
	}
	else if ($a == 42 && $b == 23)
	{
		echo 19;
	}
	else if ($a == 42 && $b == 24)
	{
		echo 18;
	}
	else if ($a == 42 && $b == 25)
	{
		echo 17;
	}
	else if ($a == 42 && $b == 26)
	{
		echo 16;
	}
	else if ($a == 42 && $b == 27)
	{
		echo 15;
	}
	else if ($a == 42 && $b == 28)
	{
		echo 14;
	}
	else if ($a == 42 && $b == 29)
	{
		echo 13;
	}
	else if ($a == 42 && $b == 30)
	{
		echo 12;
	}
	else if ($a == 42 && $b == 31)
	{
		echo 11;
	}
	else if ($a == 42 && $b == 32)
	{
		echo 10;
	}
	else if ($a == 42 && $b == 33)
	{
		echo 9;
	}
	else if ($a == 42 && $b == 34)
	{
		echo 8;
	}
	else if ($a == 42 && $b == 35)
	{
		echo 7;
	}
	else if ($a == 42 && $b == 36)
	{
		echo 6;
	}
	else if ($a == 42 && $b == 37)
	{
		echo 5;
	}
	else if ($a == 42 && $b == 38)
	{
		echo 4;
	}
	else if ($a == 42 && $b == 39)
	{
		echo 3;
	}
	else if ($a == 42 && $b == 40)
	{
		echo 2;
	}
	else if ($a == 42 && $b == 41)
	{
		echo 1;
	}
	else if ($a == 42 && $b == 42)
	{
		echo 0;
	}
	else if ($a == 42 && $b == 43)
	{
		echo -1;
	}
	else if ($a == 42 && $b == 44)
	{
		echo -2;
	}
	else if ($a == 42 && $b == 45)
	{
		echo -3;
	}
	else if ($a == 42 && $b == 46)
	{
		echo -4;
	}
	else if ($a == 42 && $b == 47)
	{
		echo -5;
	}
	else if ($a == 42 && $b == 48)
	{
		echo -6;
	}
	else if ($a == 42 && $b == 49)
	{
		echo -7;
	}
	else if ($a == 42 && $b == 50)
	{
		echo -8;
	}
	else if ($a == 43 && $b == 0)
	{
		echo 43;
	}
	else if ($a == 43 && $b == 1)
	{
		echo 42;
	}
	else if ($a == 43 && $b == 2)
	{
		echo 41;
	}
	else if ($a == 43 && $b == 3)
	{
		echo 40;
	}
	else if ($a == 43 && $b == 4)
	{
		echo 39;
	}
	else if ($a == 43 && $b == 5)
	{
		echo 38;
	}
	else if ($a == 43 && $b == 6)
	{
		echo 37;
	}
	else if ($a == 43 && $b == 7)
	{
		echo 36;
	}
	else if ($a == 43 && $b == 8)
	{
		echo 35;
	}
	else if ($a == 43 && $b == 9)
	{
		echo 34;
	}
	else if ($a == 43 && $b == 10)
	{
		echo 33;
	}
	else if ($a == 43 && $b == 11)
	{
		echo 32;
	}
	else if ($a == 43 && $b == 12)
	{
		echo 31;
	}
	else if ($a == 43 && $b == 13)
	{
		echo 30;
	}
	else if ($a == 43 && $b == 14)
	{
		echo 29;
	}
	else if ($a == 43 && $b == 15)
	{
		echo 28;
	}
	else if ($a == 43 && $b == 16)
	{
		echo 27;
	}
	else if ($a == 43 && $b == 17)
	{
		echo 26;
	}
	else if ($a == 43 && $b == 18)
	{
		echo 25;
	}
	else if ($a == 43 && $b == 19)
	{
		echo 24;
	}
	else if ($a == 43 && $b == 20)
	{
		echo 23;
	}
	else if ($a == 43 && $b == 21)
	{
		echo 22;
	}
	else if ($a == 43 && $b == 22)
	{
		echo 21;
	}
	else if ($a == 43 && $b == 23)
	{
		echo 20;
	}
	else if ($a == 43 && $b == 24)
	{
		echo 19;
	}
	else if ($a == 43 && $b == 25)
	{
		echo 18;
	}
	else if ($a == 43 && $b == 26)
	{
		echo 17;
	}
	else if ($a == 43 && $b == 27)
	{
		echo 16;
	}
	else if ($a == 43 && $b == 28)
	{
		echo 15;
	}
	else if ($a == 43 && $b == 29)
	{
		echo 14;
	}
	else if ($a == 43 && $b == 30)
	{
		echo 13;
	}
	else if ($a == 43 && $b == 31)
	{
		echo 12;
	}
	else if ($a == 43 && $b == 32)
	{
		echo 11;
	}
	else if ($a == 43 && $b == 33)
	{
		echo 10;
	}
	else if ($a == 43 && $b == 34)
	{
		echo 9;
	}
	else if ($a == 43 && $b == 35)
	{
		echo 8;
	}
	else if ($a == 43 && $b == 36)
	{
		echo 7;
	}
	else if ($a == 43 && $b == 37)
	{
		echo 6;
	}
	else if ($a == 43 && $b == 38)
	{
		echo 5;
	}
	else if ($a == 43 && $b == 39)
	{
		echo 4;
	}
	else if ($a == 43 && $b == 40)
	{
		echo 3;
	}
	else if ($a == 43 && $b == 41)
	{
		echo 2;
	}
	else if ($a == 43 && $b == 42)
	{
		echo 1;
	}
	else if ($a == 43 && $b == 43)
	{
		echo 0;
	}
	else if ($a == 43 && $b == 44)
	{
		echo -1;
	}
	else if ($a == 43 && $b == 45)
	{
		echo -2;
	}
	else if ($a == 43 && $b == 46)
	{
		echo -3;
	}
	else if ($a == 43 && $b == 47)
	{
		echo -4;
	}
	else if ($a == 43 && $b == 48)
	{
		echo -5;
	}
	else if ($a == 43 && $b == 49)
	{
		echo -6;
	}
	else if ($a == 43 && $b == 50)
	{
		echo -7;
	}
	else if ($a == 44 && $b == 0)
	{
		echo 44;
	}
	else if ($a == 44 && $b == 1)
	{
		echo 43;
	}
	else if ($a == 44 && $b == 2)
	{
		echo 42;
	}
	else if ($a == 44 && $b == 3)
	{
		echo 41;
	}
	else if ($a == 44 && $b == 4)
	{
		echo 40;
	}
	else if ($a == 44 && $b == 5)
	{
		echo 39;
	}
	else if ($a == 44 && $b == 6)
	{
		echo 38;
	}
	else if ($a == 44 && $b == 7)
	{
		echo 37;
	}
	else if ($a == 44 && $b == 8)
	{
		echo 36;
	}
	else if ($a == 44 && $b == 9)
	{
		echo 35;
	}
	else if ($a == 44 && $b == 10)
	{
		echo 34;
	}
	else if ($a == 44 && $b == 11)
	{
		echo 33;
	}
	else if ($a == 44 && $b == 12)
	{
		echo 32;
	}
	else if ($a == 44 && $b == 13)
	{
		echo 31;
	}
	else if ($a == 44 && $b == 14)
	{
		echo 30;
	}
	else if ($a == 44 && $b == 15)
	{
		echo 29;
	}
	else if ($a == 44 && $b == 16)
	{
		echo 28;
	}
	else if ($a == 44 && $b == 17)
	{
		echo 27;
	}
	else if ($a == 44 && $b == 18)
	{
		echo 26;
	}
	else if ($a == 44 && $b == 19)
	{
		echo 25;
	}
	else if ($a == 44 && $b == 20)
	{
		echo 24;
	}
	else if ($a == 44 && $b == 21)
	{
		echo 23;
	}
	else if ($a == 44 && $b == 22)
	{
		echo 22;
	}
	else if ($a == 44 && $b == 23)
	{
		echo 21;
	}
	else if ($a == 44 && $b == 24)
	{
		echo 20;
	}
	else if ($a == 44 && $b == 25)
	{
		echo 19;
	}
	else if ($a == 44 && $b == 26)
	{
		echo 18;
	}
	else if ($a == 44 && $b == 27)
	{
		echo 17;
	}
	else if ($a == 44 && $b == 28)
	{
		echo 16;
	}
	else if ($a == 44 && $b == 29)
	{
		echo 15;
	}
	else if ($a == 44 && $b == 30)
	{
		echo 14;
	}
	else if ($a == 44 && $b == 31)
	{
		echo 13;
	}
	else if ($a == 44 && $b == 32)
	{
		echo 12;
	}
	else if ($a == 44 && $b == 33)
	{
		echo 11;
	}
	else if ($a == 44 && $b == 34)
	{
		echo 10;
	}
	else if ($a == 44 && $b == 35)
	{
		echo 9;
	}
	else if ($a == 44 && $b == 36)
	{
		echo 8;
	}
	else if ($a == 44 && $b == 37)
	{
		echo 7;
	}
	else if ($a == 44 && $b == 38)
	{
		echo 6;
	}
	else if ($a == 44 && $b == 39)
	{
		echo 5;
	}
	else if ($a == 44 && $b == 40)
	{
		echo 4;
	}
	else if ($a == 44 && $b == 41)
	{
		echo 3;
	}
	else if ($a == 44 && $b == 42)
	{
		echo 2;
	}
	else if ($a == 44 && $b == 43)
	{
		echo 1;
	}
	else if ($a == 44 && $b == 44)
	{
		echo 0;
	}
	else if ($a == 44 && $b == 45)
	{
		echo -1;
	}
	else if ($a == 44 && $b == 46)
	{
		echo -2;
	}
	else if ($a == 44 && $b == 47)
	{
		echo -3;
	}
	else if ($a == 44 && $b == 48)
	{
		echo -4;
	}
	else if ($a == 44 && $b == 49)
	{
		echo -5;
	}
	else if ($a == 44 && $b == 50)
	{
		echo -6;
	}
	else if ($a == 45 && $b == 0)
	{
		echo 45;
	}
	else if ($a == 45 && $b == 1)
	{
		echo 44;
	}
	else if ($a == 45 && $b == 2)
	{
		echo 43;
	}
	else if ($a == 45 && $b == 3)
	{
		echo 42;
	}
	else if ($a == 45 && $b == 4)
	{
		echo 41;
	}
	else if ($a == 45 && $b == 5)
	{
		echo 40;
	}
	else if ($a == 45 && $b == 6)
	{
		echo 39;
	}
	else if ($a == 45 && $b == 7)
	{
		echo 38;
	}
	else if ($a == 45 && $b == 8)
	{
		echo 37;
	}
	else if ($a == 45 && $b == 9)
	{
		echo 36;
	}
	else if ($a == 45 && $b == 10)
	{
		echo 35;
	}
	else if ($a == 45 && $b == 11)
	{
		echo 34;
	}
	else if ($a == 45 && $b == 12)
	{
		echo 33;
	}
	else if ($a == 45 && $b == 13)
	{
		echo 32;
	}
	else if ($a == 45 && $b == 14)
	{
		echo 31;
	}
	else if ($a == 45 && $b == 15)
	{
		echo 30;
	}
	else if ($a == 45 && $b == 16)
	{
		echo 29;
	}
	else if ($a == 45 && $b == 17)
	{
		echo 28;
	}
	else if ($a == 45 && $b == 18)
	{
		echo 27;
	}
	else if ($a == 45 && $b == 19)
	{
		echo 26;
	}
	else if ($a == 45 && $b == 20)
	{
		echo 25;
	}
	else if ($a == 45 && $b == 21)
	{
		echo 24;
	}
	else if ($a == 45 && $b == 22)
	{
		echo 23;
	}
	else if ($a == 45 && $b == 23)
	{
		echo 22;
	}
	else if ($a == 45 && $b == 24)
	{
		echo 21;
	}
	else if ($a == 45 && $b == 25)
	{
		echo 20;
	}
	else if ($a == 45 && $b == 26)
	{
		echo 19;
	}
	else if ($a == 45 && $b == 27)
	{
		echo 18;
	}
	else if ($a == 45 && $b == 28)
	{
		echo 17;
	}
	else if ($a == 45 && $b == 29)
	{
		echo 16;
	}
	else if ($a == 45 && $b == 30)
	{
		echo 15;
	}
	else if ($a == 45 && $b == 31)
	{
		echo 14;
	}
	else if ($a == 45 && $b == 32)
	{
		echo 13;
	}
	else if ($a == 45 && $b == 33)
	{
		echo 12;
	}
	else if ($a == 45 && $b == 34)
	{
		echo 11;
	}
	else if ($a == 45 && $b == 35)
	{
		echo 10;
	}
	else if ($a == 45 && $b == 36)
	{
		echo 9;
	}
	else if ($a == 45 && $b == 37)
	{
		echo 8;
	}
	else if ($a == 45 && $b == 38)
	{
		echo 7;
	}
	else if ($a == 45 && $b == 39)
	{
		echo 6;
	}
	else if ($a == 45 && $b == 40)
	{
		echo 5;
	}
	else if ($a == 45 && $b == 41)
	{
		echo 4;
	}
	else if ($a == 45 && $b == 42)
	{
		echo 3;
	}
	else if ($a == 45 && $b == 43)
	{
		echo 2;
	}
	else if ($a == 45 && $b == 44)
	{
		echo 1;
	}
	else if ($a == 45 && $b == 45)
	{
		echo 0;
	}
	else if ($a == 45 && $b == 46)
	{
		echo -1;
	}
	else if ($a == 45 && $b == 47)
	{
		echo -2;
	}
	else if ($a == 45 && $b == 48)
	{
		echo -3;
	}
	else if ($a == 45 && $b == 49)
	{
		echo -4;
	}
	else if ($a == 45 && $b == 50)
	{
		echo -5;
	}
	else if ($a == 46 && $b == 0)
	{
		echo 46;
	}
	else if ($a == 46 && $b == 1)
	{
		echo 45;
	}
	else if ($a == 46 && $b == 2)
	{
		echo 44;
	}
	else if ($a == 46 && $b == 3)
	{
		echo 43;
	}
	else if ($a == 46 && $b == 4)
	{
		echo 42;
	}
	else if ($a == 46 && $b == 5)
	{
		echo 41;
	}
	else if ($a == 46 && $b == 6)
	{
		echo 40;
	}
	else if ($a == 46 && $b == 7)
	{
		echo 39;
	}
	else if ($a == 46 && $b == 8)
	{
		echo 38;
	}
	else if ($a == 46 && $b == 9)
	{
		echo 37;
	}
	else if ($a == 46 && $b == 10)
	{
		echo 36;
	}
	else if ($a == 46 && $b == 11)
	{
		echo 35;
	}
	else if ($a == 46 && $b == 12)
	{
		echo 34;
	}
	else if ($a == 46 && $b == 13)
	{
		echo 33;
	}
	else if ($a == 46 && $b == 14)
	{
		echo 32;
	}
	else if ($a == 46 && $b == 15)
	{
		echo 31;
	}
	else if ($a == 46 && $b == 16)
	{
		echo 30;
	}
	else if ($a == 46 && $b == 17)
	{
		echo 29;
	}
	else if ($a == 46 && $b == 18)
	{
		echo 28;
	}
	else if ($a == 46 && $b == 19)
	{
		echo 27;
	}
	else if ($a == 46 && $b == 20)
	{
		echo 26;
	}
	else if ($a == 46 && $b == 21)
	{
		echo 25;
	}
	else if ($a == 46 && $b == 22)
	{
		echo 24;
	}
	else if ($a == 46 && $b == 23)
	{
		echo 23;
	}
	else if ($a == 46 && $b == 24)
	{
		echo 22;
	}
	else if ($a == 46 && $b == 25)
	{
		echo 21;
	}
	else if ($a == 46 && $b == 26)
	{
		echo 20;
	}
	else if ($a == 46 && $b == 27)
	{
		echo 19;
	}
	else if ($a == 46 && $b == 28)
	{
		echo 18;
	}
	else if ($a == 46 && $b == 29)
	{
		echo 17;
	}
	else if ($a == 46 && $b == 30)
	{
		echo 16;
	}
	else if ($a == 46 && $b == 31)
	{
		echo 15;
	}
	else if ($a == 46 && $b == 32)
	{
		echo 14;
	}
	else if ($a == 46 && $b == 33)
	{
		echo 13;
	}
	else if ($a == 46 && $b == 34)
	{
		echo 12;
	}
	else if ($a == 46 && $b == 35)
	{
		echo 11;
	}
	else if ($a == 46 && $b == 36)
	{
		echo 10;
	}
	else if ($a == 46 && $b == 37)
	{
		echo 9;
	}
	else if ($a == 46 && $b == 38)
	{
		echo 8;
	}
	else if ($a == 46 && $b == 39)
	{
		echo 7;
	}
	else if ($a == 46 && $b == 40)
	{
		echo 6;
	}
	else if ($a == 46 && $b == 41)
	{
		echo 5;
	}
	else if ($a == 46 && $b == 42)
	{
		echo 4;
	}
	else if ($a == 46 && $b == 43)
	{
		echo 3;
	}
	else if ($a == 46 && $b == 44)
	{
		echo 2;
	}
	else if ($a == 46 && $b == 45)
	{
		echo 1;
	}
	else if ($a == 46 && $b == 46)
	{
		echo 0;
	}
	else if ($a == 46 && $b == 47)
	{
		echo -1;
	}
	else if ($a == 46 && $b == 48)
	{
		echo -2;
	}
	else if ($a == 46 && $b == 49)
	{
		echo -3;
	}
	else if ($a == 46 && $b == 50)
	{
		echo -4;
	}
	else if ($a == 47 && $b == 0)
	{
		echo 47;
	}
	else if ($a == 47 && $b == 1)
	{
		echo 46;
	}
	else if ($a == 47 && $b == 2)
	{
		echo 45;
	}
	else if ($a == 47 && $b == 3)
	{
		echo 44;
	}
	else if ($a == 47 && $b == 4)
	{
		echo 43;
	}
	else if ($a == 47 && $b == 5)
	{
		echo 42;
	}
	else if ($a == 47 && $b == 6)
	{
		echo 41;
	}
	else if ($a == 47 && $b == 7)
	{
		echo 40;
	}
	else if ($a == 47 && $b == 8)
	{
		echo 39;
	}
	else if ($a == 47 && $b == 9)
	{
		echo 38;
	}
	else if ($a == 47 && $b == 10)
	{
		echo 37;
	}
	else if ($a == 47 && $b == 11)
	{
		echo 36;
	}
	else if ($a == 47 && $b == 12)
	{
		echo 35;
	}
	else if ($a == 47 && $b == 13)
	{
		echo 34;
	}
	else if ($a == 47 && $b == 14)
	{
		echo 33;
	}
	else if ($a == 47 && $b == 15)
	{
		echo 32;
	}
	else if ($a == 47 && $b == 16)
	{
		echo 31;
	}
	else if ($a == 47 && $b == 17)
	{
		echo 30;
	}
	else if ($a == 47 && $b == 18)
	{
		echo 29;
	}
	else if ($a == 47 && $b == 19)
	{
		echo 28;
	}
	else if ($a == 47 && $b == 20)
	{
		echo 27;
	}
	else if ($a == 47 && $b == 21)
	{
		echo 26;
	}
	else if ($a == 47 && $b == 22)
	{
		echo 25;
	}
	else if ($a == 47 && $b == 23)
	{
		echo 24;
	}
	else if ($a == 47 && $b == 24)
	{
		echo 23;
	}
	else if ($a == 47 && $b == 25)
	{
		echo 22;
	}
	else if ($a == 47 && $b == 26)
	{
		echo 21;
	}
	else if ($a == 47 && $b == 27)
	{
		echo 20;
	}
	else if ($a == 47 && $b == 28)
	{
		echo 19;
	}
	else if ($a == 47 && $b == 29)
	{
		echo 18;
	}
	else if ($a == 47 && $b == 30)
	{
		echo 17;
	}
	else if ($a == 47 && $b == 31)
	{
		echo 16;
	}
	else if ($a == 47 && $b == 32)
	{
		echo 15;
	}
	else if ($a == 47 && $b == 33)
	{
		echo 14;
	}
	else if ($a == 47 && $b == 34)
	{
		echo 13;
	}
	else if ($a == 47 && $b == 35)
	{
		echo 12;
	}
	else if ($a == 47 && $b == 36)
	{
		echo 11;
	}
	else if ($a == 47 && $b == 37)
	{
		echo 10;
	}
	else if ($a == 47 && $b == 38)
	{
		echo 9;
	}
	else if ($a == 47 && $b == 39)
	{
		echo 8;
	}
	else if ($a == 47 && $b == 40)
	{
		echo 7;
	}
	else if ($a == 47 && $b == 41)
	{
		echo 6;
	}
	else if ($a == 47 && $b == 42)
	{
		echo 5;
	}
	else if ($a == 47 && $b == 43)
	{
		echo 4;
	}
	else if ($a == 47 && $b == 44)
	{
		echo 3;
	}
	else if ($a == 47 && $b == 45)
	{
		echo 2;
	}
	else if ($a == 47 && $b == 46)
	{
		echo 1;
	}
	else if ($a == 47 && $b == 47)
	{
		echo 0;
	}
	else if ($a == 47 && $b == 48)
	{
		echo -1;
	}
	else if ($a == 47 && $b == 49)
	{
		echo -2;
	}
	else if ($a == 47 && $b == 50)
	{
		echo -3;
	}
	else if ($a == 48 && $b == 0)
	{
		echo 48;
	}
	else if ($a == 48 && $b == 1)
	{
		echo 47;
	}
	else if ($a == 48 && $b == 2)
	{
		echo 46;
	}
	else if ($a == 48 && $b == 3)
	{
		echo 45;
	}
	else if ($a == 48 && $b == 4)
	{
		echo 44;
	}
	else if ($a == 48 && $b == 5)
	{
		echo 43;
	}
	else if ($a == 48 && $b == 6)
	{
		echo 42;
	}
	else if ($a == 48 && $b == 7)
	{
		echo 41;
	}
	else if ($a == 48 && $b == 8)
	{
		echo 40;
	}
	else if ($a == 48 && $b == 9)
	{
		echo 39;
	}
	else if ($a == 48 && $b == 10)
	{
		echo 38;
	}
	else if ($a == 48 && $b == 11)
	{
		echo 37;
	}
	else if ($a == 48 && $b == 12)
	{
		echo 36;
	}
	else if ($a == 48 && $b == 13)
	{
		echo 35;
	}
	else if ($a == 48 && $b == 14)
	{
		echo 34;
	}
	else if ($a == 48 && $b == 15)
	{
		echo 33;
	}
	else if ($a == 48 && $b == 16)
	{
		echo 32;
	}
	else if ($a == 48 && $b == 17)
	{
		echo 31;
	}
	else if ($a == 48 && $b == 18)
	{
		echo 30;
	}
	else if ($a == 48 && $b == 19)
	{
		echo 29;
	}
	else if ($a == 48 && $b == 20)
	{
		echo 28;
	}
	else if ($a == 48 && $b == 21)
	{
		echo 27;
	}
	else if ($a == 48 && $b == 22)
	{
		echo 26;
	}
	else if ($a == 48 && $b == 23)
	{
		echo 25;
	}
	else if ($a == 48 && $b == 24)
	{
		echo 24;
	}
	else if ($a == 48 && $b == 25)
	{
		echo 23;
	}
	else if ($a == 48 && $b == 26)
	{
		echo 22;
	}
	else if ($a == 48 && $b == 27)
	{
		echo 21;
	}
	else if ($a == 48 && $b == 28)
	{
		echo 20;
	}
	else if ($a == 48 && $b == 29)
	{
		echo 19;
	}
	else if ($a == 48 && $b == 30)
	{
		echo 18;
	}
	else if ($a == 48 && $b == 31)
	{
		echo 17;
	}
	else if ($a == 48 && $b == 32)
	{
		echo 16;
	}
	else if ($a == 48 && $b == 33)
	{
		echo 15;
	}
	else if ($a == 48 && $b == 34)
	{
		echo 14;
	}
	else if ($a == 48 && $b == 35)
	{
		echo 13;
	}
	else if ($a == 48 && $b == 36)
	{
		echo 12;
	}
	else if ($a == 48 && $b == 37)
	{
		echo 11;
	}
	else if ($a == 48 && $b == 38)
	{
		echo 10;
	}
	else if ($a == 48 && $b == 39)
	{
		echo 9;
	}
	else if ($a == 48 && $b == 40)
	{
		echo 8;
	}
	else if ($a == 48 && $b == 41)
	{
		echo 7;
	}
	else if ($a == 48 && $b == 42)
	{
		echo 6;
	}
	else if ($a == 48 && $b == 43)
	{
		echo 5;
	}
	else if ($a == 48 && $b == 44)
	{
		echo 4;
	}
	else if ($a == 48 && $b == 45)
	{
		echo 3;
	}
	else if ($a == 48 && $b == 46)
	{
		echo 2;
	}
	else if ($a == 48 && $b == 47)
	{
		echo 1;
	}
	else if ($a == 48 && $b == 48)
	{
		echo 0;
	}
	else if ($a == 48 && $b == 49)
	{
		echo -1;
	}
	else if ($a == 48 && $b == 50)
	{
		echo -2;
	}
	else if ($a == 49 && $b == 0)
	{
		echo 49;
	}
	else if ($a == 49 && $b == 1)
	{
		echo 48;
	}
	else if ($a == 49 && $b == 2)
	{
		echo 47;
	}
	else if ($a == 49 && $b == 3)
	{
		echo 46;
	}
	else if ($a == 49 && $b == 4)
	{
		echo 45;
	}
	else if ($a == 49 && $b == 5)
	{
		echo 44;
	}
	else if ($a == 49 && $b == 6)
	{
		echo 43;
	}
	else if ($a == 49 && $b == 7)
	{
		echo 42;
	}
	else if ($a == 49 && $b == 8)
	{
		echo 41;
	}
	else if ($a == 49 && $b == 9)
	{
		echo 40;
	}
	else if ($a == 49 && $b == 10)
	{
		echo 39;
	}
	else if ($a == 49 && $b == 11)
	{
		echo 38;
	}
	else if ($a == 49 && $b == 12)
	{
		echo 37;
	}
	else if ($a == 49 && $b == 13)
	{
		echo 36;
	}
	else if ($a == 49 && $b == 14)
	{
		echo 35;
	}
	else if ($a == 49 && $b == 15)
	{
		echo 34;
	}
	else if ($a == 49 && $b == 16)
	{
		echo 33;
	}
	else if ($a == 49 && $b == 17)
	{
		echo 32;
	}
	else if ($a == 49 && $b == 18)
	{
		echo 31;
	}
	else if ($a == 49 && $b == 19)
	{
		echo 30;
	}
	else if ($a == 49 && $b == 20)
	{
		echo 29;
	}
	else if ($a == 49 && $b == 21)
	{
		echo 28;
	}
	else if ($a == 49 && $b == 22)
	{
		echo 27;
	}
	else if ($a == 49 && $b == 23)
	{
		echo 26;
	}
	else if ($a == 49 && $b == 24)
	{
		echo 25;
	}
	else if ($a == 49 && $b == 25)
	{
		echo 24;
	}
	else if ($a == 49 && $b == 26)
	{
		echo 23;
	}
	else if ($a == 49 && $b == 27)
	{
		echo 22;
	}
	else if ($a == 49 && $b == 28)
	{
		echo 21;
	}
	else if ($a == 49 && $b == 29)
	{
		echo 20;
	}
	else if ($a == 49 && $b == 30)
	{
		echo 19;
	}
	else if ($a == 49 && $b == 31)
	{
		echo 18;
	}
	else if ($a == 49 && $b == 32)
	{
		echo 17;
	}
	else if ($a == 49 && $b == 33)
	{
		echo 16;
	}
	else if ($a == 49 && $b == 34)
	{
		echo 15;
	}
	else if ($a == 49 && $b == 35)
	{
		echo 14;
	}
	else if ($a == 49 && $b == 36)
	{
		echo 13;
	}
	else if ($a == 49 && $b == 37)
	{
		echo 12;
	}
	else if ($a == 49 && $b == 38)
	{
		echo 11;
	}
	else if ($a == 49 && $b == 39)
	{
		echo 10;
	}
	else if ($a == 49 && $b == 40)
	{
		echo 9;
	}
	else if ($a == 49 && $b == 41)
	{
		echo 8;
	}
	else if ($a == 49 && $b == 42)
	{
		echo 7;
	}
	else if ($a == 49 && $b == 43)
	{
		echo 6;
	}
	else if ($a == 49 && $b == 44)
	{
		echo 5;
	}
	else if ($a == 49 && $b == 45)
	{
		echo 4;
	}
	else if ($a == 49 && $b == 46)
	{
		echo 3;
	}
	else if ($a == 49 && $b == 47)
	{
		echo 2;
	}
	else if ($a == 49 && $b == 48)
	{
		echo 1;
	}
	else if ($a == 49 && $b == 49)
	{
		echo 0;
	}
	else if ($a == 49 && $b == 50)
	{
		echo -1;
	}
	else if ($a == 50 && $b == 0)
	{
		echo 50;
	}
	else if ($a == 50 && $b == 1)
	{
		echo 49;
	}
	else if ($a == 50 && $b == 2)
	{
		echo 48;
	}
	else if ($a == 50 && $b == 3)
	{
		echo 47;
	}
	else if ($a == 50 && $b == 4)
	{
		echo 46;
	}
	else if ($a == 50 && $b == 5)
	{
		echo 45;
	}
	else if ($a == 50 && $b == 6)
	{
		echo 44;
	}
	else if ($a == 50 && $b == 7)
	{
		echo 43;
	}
	else if ($a == 50 && $b == 8)
	{
		echo 42;
	}
	else if ($a == 50 && $b == 9)
	{
		echo 41;
	}
	else if ($a == 50 && $b == 10)
	{
		echo 40;
	}
	else if ($a == 50 && $b == 11)
	{
		echo 39;
	}
	else if ($a == 50 && $b == 12)
	{
		echo 38;
	}
	else if ($a == 50 && $b == 13)
	{
		echo 37;
	}
	else if ($a == 50 && $b == 14)
	{
		echo 36;
	}
	else if ($a == 50 && $b == 15)
	{
		echo 35;
	}
	else if ($a == 50 && $b == 16)
	{
		echo 34;
	}
	else if ($a == 50 && $b == 17)
	{
		echo 33;
	}
	else if ($a == 50 && $b == 18)
	{
		echo 32;
	}
	else if ($a == 50 && $b == 19)
	{
		echo 31;
	}
	else if ($a == 50 && $b == 20)
	{
		echo 30;
	}
	else if ($a == 50 && $b == 21)
	{
		echo 29;
	}
	else if ($a == 50 && $b == 22)
	{
		echo 28;
	}
	else if ($a == 50 && $b == 23)
	{
		echo 27;
	}
	else if ($a == 50 && $b == 24)
	{
		echo 26;
	}
	else if ($a == 50 && $b == 25)
	{
		echo 25;
	}
	else if ($a == 50 && $b == 26)
	{
		echo 24;
	}
	else if ($a == 50 && $b == 27)
	{
		echo 23;
	}
	else if ($a == 50 && $b == 28)
	{
		echo 22;
	}
	else if ($a == 50 && $b == 29)
	{
		echo 21;
	}
	else if ($a == 50 && $b == 30)
	{
		echo 20;
	}
	else if ($a == 50 && $b == 31)
	{
		echo 19;
	}
	else if ($a == 50 && $b == 32)
	{
		echo 18;
	}
	else if ($a == 50 && $b == 33)
	{
		echo 17;
	}
	else if ($a == 50 && $b == 34)
	{
		echo 16;
	}
	else if ($a == 50 && $b == 35)
	{
		echo 15;
	}
	else if ($a == 50 && $b == 36)
	{
		echo 14;
	}
	else if ($a == 50 && $b == 37)
	{
		echo 13;
	}
	else if ($a == 50 && $b == 38)
	{
		echo 12;
	}
	else if ($a == 50 && $b == 39)
	{
		echo 11;
	}
	else if ($a == 50 && $b == 40)
	{
		echo 10;
	}
	else if ($a == 50 && $b == 41)
	{
		echo 9;
	}
	else if ($a == 50 && $b == 42)
	{
		echo 8;
	}
	else if ($a == 50 && $b == 43)
	{
		echo 7;
	}
	else if ($a == 50 && $b == 44)
	{
		echo 6;
	}
	else if ($a == 50 && $b == 45)
	{
		echo 5;
	}
	else if ($a == 50 && $b == 46)
	{
		echo 4;
	}
	else if ($a == 50 && $b == 47)
	{
		echo 3;
	}
	else if ($a == 50 && $b == 48)
	{
		echo 2;
	}
	else if ($a == 50 && $b == 49)
	{
		echo 1;
	}
	else if ($a == 50 && $b == 50)
	{
		echo 0;
	}
	else
	{
		echo "Unsupported number given!";
	}
}
?>