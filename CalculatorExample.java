import java.util.Scanner;

public class CalculatorExample
{
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Max number: 50");
		System.out.print("First number: ");
		int a = input.nextInt();
		System.out.print("Second number: ");
		int b = input.nextInt();
		System.out.println("Do u wanna: a - Add, s - Subtract");
		char method = input.next().charAt(0);
		System.out.print("Result: ");
		if (method == 'a') {
			add(a, b);
		} else if (method == 's') {
			subtract(a, b);
		} else {
			System.out.println("Bad method selected!");
		}
	}

	public static void add(int a, int b) {
		if (a == 0 && b == 0) {
			System.out.println(0);
		} else if (a == 0 && b == 1) {
			System.out.println(1);
		} else if (a == 0 && b == 2) {
			System.out.println(2);
		} else if (a == 0 && b == 3) {
			System.out.println(3);
		} else if (a == 0 && b == 4) {
			System.out.println(4);
		} else if (a == 0 && b == 5) {
			System.out.println(5);
		} else if (a == 0 && b == 6) {
			System.out.println(6);
		} else if (a == 0 && b == 7) {
			System.out.println(7);
		} else if (a == 0 && b == 8) {
			System.out.println(8);
		} else if (a == 0 && b == 9) {
			System.out.println(9);
		} else if (a == 0 && b == 10) {
			System.out.println(10);
		} else if (a == 0 && b == 11) {
			System.out.println(11);
		} else if (a == 0 && b == 12) {
			System.out.println(12);
		} else if (a == 0 && b == 13) {
			System.out.println(13);
		} else if (a == 0 && b == 14) {
			System.out.println(14);
		} else if (a == 0 && b == 15) {
			System.out.println(15);
		} else if (a == 0 && b == 16) {
			System.out.println(16);
		} else if (a == 0 && b == 17) {
			System.out.println(17);
		} else if (a == 0 && b == 18) {
			System.out.println(18);
		} else if (a == 0 && b == 19) {
			System.out.println(19);
		} else if (a == 0 && b == 20) {
			System.out.println(20);
		} else if (a == 0 && b == 21) {
			System.out.println(21);
		} else if (a == 0 && b == 22) {
			System.out.println(22);
		} else if (a == 0 && b == 23) {
			System.out.println(23);
		} else if (a == 0 && b == 24) {
			System.out.println(24);
		} else if (a == 0 && b == 25) {
			System.out.println(25);
		} else if (a == 0 && b == 26) {
			System.out.println(26);
		} else if (a == 0 && b == 27) {
			System.out.println(27);
		} else if (a == 0 && b == 28) {
			System.out.println(28);
		} else if (a == 0 && b == 29) {
			System.out.println(29);
		} else if (a == 0 && b == 30) {
			System.out.println(30);
		} else if (a == 0 && b == 31) {
			System.out.println(31);
		} else if (a == 0 && b == 32) {
			System.out.println(32);
		} else if (a == 0 && b == 33) {
			System.out.println(33);
		} else if (a == 0 && b == 34) {
			System.out.println(34);
		} else if (a == 0 && b == 35) {
			System.out.println(35);
		} else if (a == 0 && b == 36) {
			System.out.println(36);
		} else if (a == 0 && b == 37) {
			System.out.println(37);
		} else if (a == 0 && b == 38) {
			System.out.println(38);
		} else if (a == 0 && b == 39) {
			System.out.println(39);
		} else if (a == 0 && b == 40) {
			System.out.println(40);
		} else if (a == 0 && b == 41) {
			System.out.println(41);
		} else if (a == 0 && b == 42) {
			System.out.println(42);
		} else if (a == 0 && b == 43) {
			System.out.println(43);
		} else if (a == 0 && b == 44) {
			System.out.println(44);
		} else if (a == 0 && b == 45) {
			System.out.println(45);
		} else if (a == 0 && b == 46) {
			System.out.println(46);
		} else if (a == 0 && b == 47) {
			System.out.println(47);
		} else if (a == 0 && b == 48) {
			System.out.println(48);
		} else if (a == 0 && b == 49) {
			System.out.println(49);
		} else if (a == 0 && b == 50) {
			System.out.println(50);
		} else if (a == 1 && b == 0) {
			System.out.println(1);
		} else if (a == 1 && b == 1) {
			System.out.println(2);
		} else if (a == 1 && b == 2) {
			System.out.println(3);
		} else if (a == 1 && b == 3) {
			System.out.println(4);
		} else if (a == 1 && b == 4) {
			System.out.println(5);
		} else if (a == 1 && b == 5) {
			System.out.println(6);
		} else if (a == 1 && b == 6) {
			System.out.println(7);
		} else if (a == 1 && b == 7) {
			System.out.println(8);
		} else if (a == 1 && b == 8) {
			System.out.println(9);
		} else if (a == 1 && b == 9) {
			System.out.println(10);
		} else if (a == 1 && b == 10) {
			System.out.println(11);
		} else if (a == 1 && b == 11) {
			System.out.println(12);
		} else if (a == 1 && b == 12) {
			System.out.println(13);
		} else if (a == 1 && b == 13) {
			System.out.println(14);
		} else if (a == 1 && b == 14) {
			System.out.println(15);
		} else if (a == 1 && b == 15) {
			System.out.println(16);
		} else if (a == 1 && b == 16) {
			System.out.println(17);
		} else if (a == 1 && b == 17) {
			System.out.println(18);
		} else if (a == 1 && b == 18) {
			System.out.println(19);
		} else if (a == 1 && b == 19) {
			System.out.println(20);
		} else if (a == 1 && b == 20) {
			System.out.println(21);
		} else if (a == 1 && b == 21) {
			System.out.println(22);
		} else if (a == 1 && b == 22) {
			System.out.println(23);
		} else if (a == 1 && b == 23) {
			System.out.println(24);
		} else if (a == 1 && b == 24) {
			System.out.println(25);
		} else if (a == 1 && b == 25) {
			System.out.println(26);
		} else if (a == 1 && b == 26) {
			System.out.println(27);
		} else if (a == 1 && b == 27) {
			System.out.println(28);
		} else if (a == 1 && b == 28) {
			System.out.println(29);
		} else if (a == 1 && b == 29) {
			System.out.println(30);
		} else if (a == 1 && b == 30) {
			System.out.println(31);
		} else if (a == 1 && b == 31) {
			System.out.println(32);
		} else if (a == 1 && b == 32) {
			System.out.println(33);
		} else if (a == 1 && b == 33) {
			System.out.println(34);
		} else if (a == 1 && b == 34) {
			System.out.println(35);
		} else if (a == 1 && b == 35) {
			System.out.println(36);
		} else if (a == 1 && b == 36) {
			System.out.println(37);
		} else if (a == 1 && b == 37) {
			System.out.println(38);
		} else if (a == 1 && b == 38) {
			System.out.println(39);
		} else if (a == 1 && b == 39) {
			System.out.println(40);
		} else if (a == 1 && b == 40) {
			System.out.println(41);
		} else if (a == 1 && b == 41) {
			System.out.println(42);
		} else if (a == 1 && b == 42) {
			System.out.println(43);
		} else if (a == 1 && b == 43) {
			System.out.println(44);
		} else if (a == 1 && b == 44) {
			System.out.println(45);
		} else if (a == 1 && b == 45) {
			System.out.println(46);
		} else if (a == 1 && b == 46) {
			System.out.println(47);
		} else if (a == 1 && b == 47) {
			System.out.println(48);
		} else if (a == 1 && b == 48) {
			System.out.println(49);
		} else if (a == 1 && b == 49) {
			System.out.println(50);
		} else if (a == 1 && b == 50) {
			System.out.println(51);
		} else if (a == 2 && b == 0) {
			System.out.println(2);
		} else if (a == 2 && b == 1) {
			System.out.println(3);
		} else if (a == 2 && b == 2) {
			System.out.println(4);
		} else if (a == 2 && b == 3) {
			System.out.println(5);
		} else if (a == 2 && b == 4) {
			System.out.println(6);
		} else if (a == 2 && b == 5) {
			System.out.println(7);
		} else if (a == 2 && b == 6) {
			System.out.println(8);
		} else if (a == 2 && b == 7) {
			System.out.println(9);
		} else if (a == 2 && b == 8) {
			System.out.println(10);
		} else if (a == 2 && b == 9) {
			System.out.println(11);
		} else if (a == 2 && b == 10) {
			System.out.println(12);
		} else if (a == 2 && b == 11) {
			System.out.println(13);
		} else if (a == 2 && b == 12) {
			System.out.println(14);
		} else if (a == 2 && b == 13) {
			System.out.println(15);
		} else if (a == 2 && b == 14) {
			System.out.println(16);
		} else if (a == 2 && b == 15) {
			System.out.println(17);
		} else if (a == 2 && b == 16) {
			System.out.println(18);
		} else if (a == 2 && b == 17) {
			System.out.println(19);
		} else if (a == 2 && b == 18) {
			System.out.println(20);
		} else if (a == 2 && b == 19) {
			System.out.println(21);
		} else if (a == 2 && b == 20) {
			System.out.println(22);
		} else if (a == 2 && b == 21) {
			System.out.println(23);
		} else if (a == 2 && b == 22) {
			System.out.println(24);
		} else if (a == 2 && b == 23) {
			System.out.println(25);
		} else if (a == 2 && b == 24) {
			System.out.println(26);
		} else if (a == 2 && b == 25) {
			System.out.println(27);
		} else if (a == 2 && b == 26) {
			System.out.println(28);
		} else if (a == 2 && b == 27) {
			System.out.println(29);
		} else if (a == 2 && b == 28) {
			System.out.println(30);
		} else if (a == 2 && b == 29) {
			System.out.println(31);
		} else if (a == 2 && b == 30) {
			System.out.println(32);
		} else if (a == 2 && b == 31) {
			System.out.println(33);
		} else if (a == 2 && b == 32) {
			System.out.println(34);
		} else if (a == 2 && b == 33) {
			System.out.println(35);
		} else if (a == 2 && b == 34) {
			System.out.println(36);
		} else if (a == 2 && b == 35) {
			System.out.println(37);
		} else if (a == 2 && b == 36) {
			System.out.println(38);
		} else if (a == 2 && b == 37) {
			System.out.println(39);
		} else if (a == 2 && b == 38) {
			System.out.println(40);
		} else if (a == 2 && b == 39) {
			System.out.println(41);
		} else if (a == 2 && b == 40) {
			System.out.println(42);
		} else if (a == 2 && b == 41) {
			System.out.println(43);
		} else if (a == 2 && b == 42) {
			System.out.println(44);
		} else if (a == 2 && b == 43) {
			System.out.println(45);
		} else if (a == 2 && b == 44) {
			System.out.println(46);
		} else if (a == 2 && b == 45) {
			System.out.println(47);
		} else if (a == 2 && b == 46) {
			System.out.println(48);
		} else if (a == 2 && b == 47) {
			System.out.println(49);
		} else if (a == 2 && b == 48) {
			System.out.println(50);
		} else if (a == 2 && b == 49) {
			System.out.println(51);
		} else if (a == 2 && b == 50) {
			System.out.println(52);
		} else if (a == 3 && b == 0) {
			System.out.println(3);
		} else if (a == 3 && b == 1) {
			System.out.println(4);
		} else if (a == 3 && b == 2) {
			System.out.println(5);
		} else if (a == 3 && b == 3) {
			System.out.println(6);
		} else if (a == 3 && b == 4) {
			System.out.println(7);
		} else if (a == 3 && b == 5) {
			System.out.println(8);
		} else if (a == 3 && b == 6) {
			System.out.println(9);
		} else if (a == 3 && b == 7) {
			System.out.println(10);
		} else if (a == 3 && b == 8) {
			System.out.println(11);
		} else if (a == 3 && b == 9) {
			System.out.println(12);
		} else if (a == 3 && b == 10) {
			System.out.println(13);
		} else if (a == 3 && b == 11) {
			System.out.println(14);
		} else if (a == 3 && b == 12) {
			System.out.println(15);
		} else if (a == 3 && b == 13) {
			System.out.println(16);
		} else if (a == 3 && b == 14) {
			System.out.println(17);
		} else if (a == 3 && b == 15) {
			System.out.println(18);
		} else if (a == 3 && b == 16) {
			System.out.println(19);
		} else if (a == 3 && b == 17) {
			System.out.println(20);
		} else if (a == 3 && b == 18) {
			System.out.println(21);
		} else if (a == 3 && b == 19) {
			System.out.println(22);
		} else if (a == 3 && b == 20) {
			System.out.println(23);
		} else if (a == 3 && b == 21) {
			System.out.println(24);
		} else if (a == 3 && b == 22) {
			System.out.println(25);
		} else if (a == 3 && b == 23) {
			System.out.println(26);
		} else if (a == 3 && b == 24) {
			System.out.println(27);
		} else if (a == 3 && b == 25) {
			System.out.println(28);
		} else if (a == 3 && b == 26) {
			System.out.println(29);
		} else if (a == 3 && b == 27) {
			System.out.println(30);
		} else if (a == 3 && b == 28) {
			System.out.println(31);
		} else if (a == 3 && b == 29) {
			System.out.println(32);
		} else if (a == 3 && b == 30) {
			System.out.println(33);
		} else if (a == 3 && b == 31) {
			System.out.println(34);
		} else if (a == 3 && b == 32) {
			System.out.println(35);
		} else if (a == 3 && b == 33) {
			System.out.println(36);
		} else if (a == 3 && b == 34) {
			System.out.println(37);
		} else if (a == 3 && b == 35) {
			System.out.println(38);
		} else if (a == 3 && b == 36) {
			System.out.println(39);
		} else if (a == 3 && b == 37) {
			System.out.println(40);
		} else if (a == 3 && b == 38) {
			System.out.println(41);
		} else if (a == 3 && b == 39) {
			System.out.println(42);
		} else if (a == 3 && b == 40) {
			System.out.println(43);
		} else if (a == 3 && b == 41) {
			System.out.println(44);
		} else if (a == 3 && b == 42) {
			System.out.println(45);
		} else if (a == 3 && b == 43) {
			System.out.println(46);
		} else if (a == 3 && b == 44) {
			System.out.println(47);
		} else if (a == 3 && b == 45) {
			System.out.println(48);
		} else if (a == 3 && b == 46) {
			System.out.println(49);
		} else if (a == 3 && b == 47) {
			System.out.println(50);
		} else if (a == 3 && b == 48) {
			System.out.println(51);
		} else if (a == 3 && b == 49) {
			System.out.println(52);
		} else if (a == 3 && b == 50) {
			System.out.println(53);
		} else if (a == 4 && b == 0) {
			System.out.println(4);
		} else if (a == 4 && b == 1) {
			System.out.println(5);
		} else if (a == 4 && b == 2) {
			System.out.println(6);
		} else if (a == 4 && b == 3) {
			System.out.println(7);
		} else if (a == 4 && b == 4) {
			System.out.println(8);
		} else if (a == 4 && b == 5) {
			System.out.println(9);
		} else if (a == 4 && b == 6) {
			System.out.println(10);
		} else if (a == 4 && b == 7) {
			System.out.println(11);
		} else if (a == 4 && b == 8) {
			System.out.println(12);
		} else if (a == 4 && b == 9) {
			System.out.println(13);
		} else if (a == 4 && b == 10) {
			System.out.println(14);
		} else if (a == 4 && b == 11) {
			System.out.println(15);
		} else if (a == 4 && b == 12) {
			System.out.println(16);
		} else if (a == 4 && b == 13) {
			System.out.println(17);
		} else if (a == 4 && b == 14) {
			System.out.println(18);
		} else if (a == 4 && b == 15) {
			System.out.println(19);
		} else if (a == 4 && b == 16) {
			System.out.println(20);
		} else if (a == 4 && b == 17) {
			System.out.println(21);
		} else if (a == 4 && b == 18) {
			System.out.println(22);
		} else if (a == 4 && b == 19) {
			System.out.println(23);
		} else if (a == 4 && b == 20) {
			System.out.println(24);
		} else if (a == 4 && b == 21) {
			System.out.println(25);
		} else if (a == 4 && b == 22) {
			System.out.println(26);
		} else if (a == 4 && b == 23) {
			System.out.println(27);
		} else if (a == 4 && b == 24) {
			System.out.println(28);
		} else if (a == 4 && b == 25) {
			System.out.println(29);
		} else if (a == 4 && b == 26) {
			System.out.println(30);
		} else if (a == 4 && b == 27) {
			System.out.println(31);
		} else if (a == 4 && b == 28) {
			System.out.println(32);
		} else if (a == 4 && b == 29) {
			System.out.println(33);
		} else if (a == 4 && b == 30) {
			System.out.println(34);
		} else if (a == 4 && b == 31) {
			System.out.println(35);
		} else if (a == 4 && b == 32) {
			System.out.println(36);
		} else if (a == 4 && b == 33) {
			System.out.println(37);
		} else if (a == 4 && b == 34) {
			System.out.println(38);
		} else if (a == 4 && b == 35) {
			System.out.println(39);
		} else if (a == 4 && b == 36) {
			System.out.println(40);
		} else if (a == 4 && b == 37) {
			System.out.println(41);
		} else if (a == 4 && b == 38) {
			System.out.println(42);
		} else if (a == 4 && b == 39) {
			System.out.println(43);
		} else if (a == 4 && b == 40) {
			System.out.println(44);
		} else if (a == 4 && b == 41) {
			System.out.println(45);
		} else if (a == 4 && b == 42) {
			System.out.println(46);
		} else if (a == 4 && b == 43) {
			System.out.println(47);
		} else if (a == 4 && b == 44) {
			System.out.println(48);
		} else if (a == 4 && b == 45) {
			System.out.println(49);
		} else if (a == 4 && b == 46) {
			System.out.println(50);
		} else if (a == 4 && b == 47) {
			System.out.println(51);
		} else if (a == 4 && b == 48) {
			System.out.println(52);
		} else if (a == 4 && b == 49) {
			System.out.println(53);
		} else if (a == 4 && b == 50) {
			System.out.println(54);
		} else if (a == 5 && b == 0) {
			System.out.println(5);
		} else if (a == 5 && b == 1) {
			System.out.println(6);
		} else if (a == 5 && b == 2) {
			System.out.println(7);
		} else if (a == 5 && b == 3) {
			System.out.println(8);
		} else if (a == 5 && b == 4) {
			System.out.println(9);
		} else if (a == 5 && b == 5) {
			System.out.println(10);
		} else if (a == 5 && b == 6) {
			System.out.println(11);
		} else if (a == 5 && b == 7) {
			System.out.println(12);
		} else if (a == 5 && b == 8) {
			System.out.println(13);
		} else if (a == 5 && b == 9) {
			System.out.println(14);
		} else if (a == 5 && b == 10) {
			System.out.println(15);
		} else if (a == 5 && b == 11) {
			System.out.println(16);
		} else if (a == 5 && b == 12) {
			System.out.println(17);
		} else if (a == 5 && b == 13) {
			System.out.println(18);
		} else if (a == 5 && b == 14) {
			System.out.println(19);
		} else if (a == 5 && b == 15) {
			System.out.println(20);
		} else if (a == 5 && b == 16) {
			System.out.println(21);
		} else if (a == 5 && b == 17) {
			System.out.println(22);
		} else if (a == 5 && b == 18) {
			System.out.println(23);
		} else if (a == 5 && b == 19) {
			System.out.println(24);
		} else if (a == 5 && b == 20) {
			System.out.println(25);
		} else if (a == 5 && b == 21) {
			System.out.println(26);
		} else if (a == 5 && b == 22) {
			System.out.println(27);
		} else if (a == 5 && b == 23) {
			System.out.println(28);
		} else if (a == 5 && b == 24) {
			System.out.println(29);
		} else if (a == 5 && b == 25) {
			System.out.println(30);
		} else if (a == 5 && b == 26) {
			System.out.println(31);
		} else if (a == 5 && b == 27) {
			System.out.println(32);
		} else if (a == 5 && b == 28) {
			System.out.println(33);
		} else if (a == 5 && b == 29) {
			System.out.println(34);
		} else if (a == 5 && b == 30) {
			System.out.println(35);
		} else if (a == 5 && b == 31) {
			System.out.println(36);
		} else if (a == 5 && b == 32) {
			System.out.println(37);
		} else if (a == 5 && b == 33) {
			System.out.println(38);
		} else if (a == 5 && b == 34) {
			System.out.println(39);
		} else if (a == 5 && b == 35) {
			System.out.println(40);
		} else if (a == 5 && b == 36) {
			System.out.println(41);
		} else if (a == 5 && b == 37) {
			System.out.println(42);
		} else if (a == 5 && b == 38) {
			System.out.println(43);
		} else if (a == 5 && b == 39) {
			System.out.println(44);
		} else if (a == 5 && b == 40) {
			System.out.println(45);
		} else if (a == 5 && b == 41) {
			System.out.println(46);
		} else if (a == 5 && b == 42) {
			System.out.println(47);
		} else if (a == 5 && b == 43) {
			System.out.println(48);
		} else if (a == 5 && b == 44) {
			System.out.println(49);
		} else if (a == 5 && b == 45) {
			System.out.println(50);
		} else if (a == 5 && b == 46) {
			System.out.println(51);
		} else if (a == 5 && b == 47) {
			System.out.println(52);
		} else if (a == 5 && b == 48) {
			System.out.println(53);
		} else if (a == 5 && b == 49) {
			System.out.println(54);
		} else if (a == 5 && b == 50) {
			System.out.println(55);
		} else if (a == 6 && b == 0) {
			System.out.println(6);
		} else if (a == 6 && b == 1) {
			System.out.println(7);
		} else if (a == 6 && b == 2) {
			System.out.println(8);
		} else if (a == 6 && b == 3) {
			System.out.println(9);
		} else if (a == 6 && b == 4) {
			System.out.println(10);
		} else if (a == 6 && b == 5) {
			System.out.println(11);
		} else if (a == 6 && b == 6) {
			System.out.println(12);
		} else if (a == 6 && b == 7) {
			System.out.println(13);
		} else if (a == 6 && b == 8) {
			System.out.println(14);
		} else if (a == 6 && b == 9) {
			System.out.println(15);
		} else if (a == 6 && b == 10) {
			System.out.println(16);
		} else if (a == 6 && b == 11) {
			System.out.println(17);
		} else if (a == 6 && b == 12) {
			System.out.println(18);
		} else if (a == 6 && b == 13) {
			System.out.println(19);
		} else if (a == 6 && b == 14) {
			System.out.println(20);
		} else if (a == 6 && b == 15) {
			System.out.println(21);
		} else if (a == 6 && b == 16) {
			System.out.println(22);
		} else if (a == 6 && b == 17) {
			System.out.println(23);
		} else if (a == 6 && b == 18) {
			System.out.println(24);
		} else if (a == 6 && b == 19) {
			System.out.println(25);
		} else if (a == 6 && b == 20) {
			System.out.println(26);
		} else if (a == 6 && b == 21) {
			System.out.println(27);
		} else if (a == 6 && b == 22) {
			System.out.println(28);
		} else if (a == 6 && b == 23) {
			System.out.println(29);
		} else if (a == 6 && b == 24) {
			System.out.println(30);
		} else if (a == 6 && b == 25) {
			System.out.println(31);
		} else if (a == 6 && b == 26) {
			System.out.println(32);
		} else if (a == 6 && b == 27) {
			System.out.println(33);
		} else if (a == 6 && b == 28) {
			System.out.println(34);
		} else if (a == 6 && b == 29) {
			System.out.println(35);
		} else if (a == 6 && b == 30) {
			System.out.println(36);
		} else if (a == 6 && b == 31) {
			System.out.println(37);
		} else if (a == 6 && b == 32) {
			System.out.println(38);
		} else if (a == 6 && b == 33) {
			System.out.println(39);
		} else if (a == 6 && b == 34) {
			System.out.println(40);
		} else if (a == 6 && b == 35) {
			System.out.println(41);
		} else if (a == 6 && b == 36) {
			System.out.println(42);
		} else if (a == 6 && b == 37) {
			System.out.println(43);
		} else if (a == 6 && b == 38) {
			System.out.println(44);
		} else if (a == 6 && b == 39) {
			System.out.println(45);
		} else if (a == 6 && b == 40) {
			System.out.println(46);
		} else if (a == 6 && b == 41) {
			System.out.println(47);
		} else if (a == 6 && b == 42) {
			System.out.println(48);
		} else if (a == 6 && b == 43) {
			System.out.println(49);
		} else if (a == 6 && b == 44) {
			System.out.println(50);
		} else if (a == 6 && b == 45) {
			System.out.println(51);
		} else if (a == 6 && b == 46) {
			System.out.println(52);
		} else if (a == 6 && b == 47) {
			System.out.println(53);
		} else if (a == 6 && b == 48) {
			System.out.println(54);
		} else if (a == 6 && b == 49) {
			System.out.println(55);
		} else if (a == 6 && b == 50) {
			System.out.println(56);
		} else if (a == 7 && b == 0) {
			System.out.println(7);
		} else if (a == 7 && b == 1) {
			System.out.println(8);
		} else if (a == 7 && b == 2) {
			System.out.println(9);
		} else if (a == 7 && b == 3) {
			System.out.println(10);
		} else if (a == 7 && b == 4) {
			System.out.println(11);
		} else if (a == 7 && b == 5) {
			System.out.println(12);
		} else if (a == 7 && b == 6) {
			System.out.println(13);
		} else if (a == 7 && b == 7) {
			System.out.println(14);
		} else if (a == 7 && b == 8) {
			System.out.println(15);
		} else if (a == 7 && b == 9) {
			System.out.println(16);
		} else if (a == 7 && b == 10) {
			System.out.println(17);
		} else if (a == 7 && b == 11) {
			System.out.println(18);
		} else if (a == 7 && b == 12) {
			System.out.println(19);
		} else if (a == 7 && b == 13) {
			System.out.println(20);
		} else if (a == 7 && b == 14) {
			System.out.println(21);
		} else if (a == 7 && b == 15) {
			System.out.println(22);
		} else if (a == 7 && b == 16) {
			System.out.println(23);
		} else if (a == 7 && b == 17) {
			System.out.println(24);
		} else if (a == 7 && b == 18) {
			System.out.println(25);
		} else if (a == 7 && b == 19) {
			System.out.println(26);
		} else if (a == 7 && b == 20) {
			System.out.println(27);
		} else if (a == 7 && b == 21) {
			System.out.println(28);
		} else if (a == 7 && b == 22) {
			System.out.println(29);
		} else if (a == 7 && b == 23) {
			System.out.println(30);
		} else if (a == 7 && b == 24) {
			System.out.println(31);
		} else if (a == 7 && b == 25) {
			System.out.println(32);
		} else if (a == 7 && b == 26) {
			System.out.println(33);
		} else if (a == 7 && b == 27) {
			System.out.println(34);
		} else if (a == 7 && b == 28) {
			System.out.println(35);
		} else if (a == 7 && b == 29) {
			System.out.println(36);
		} else if (a == 7 && b == 30) {
			System.out.println(37);
		} else if (a == 7 && b == 31) {
			System.out.println(38);
		} else if (a == 7 && b == 32) {
			System.out.println(39);
		} else if (a == 7 && b == 33) {
			System.out.println(40);
		} else if (a == 7 && b == 34) {
			System.out.println(41);
		} else if (a == 7 && b == 35) {
			System.out.println(42);
		} else if (a == 7 && b == 36) {
			System.out.println(43);
		} else if (a == 7 && b == 37) {
			System.out.println(44);
		} else if (a == 7 && b == 38) {
			System.out.println(45);
		} else if (a == 7 && b == 39) {
			System.out.println(46);
		} else if (a == 7 && b == 40) {
			System.out.println(47);
		} else if (a == 7 && b == 41) {
			System.out.println(48);
		} else if (a == 7 && b == 42) {
			System.out.println(49);
		} else if (a == 7 && b == 43) {
			System.out.println(50);
		} else if (a == 7 && b == 44) {
			System.out.println(51);
		} else if (a == 7 && b == 45) {
			System.out.println(52);
		} else if (a == 7 && b == 46) {
			System.out.println(53);
		} else if (a == 7 && b == 47) {
			System.out.println(54);
		} else if (a == 7 && b == 48) {
			System.out.println(55);
		} else if (a == 7 && b == 49) {
			System.out.println(56);
		} else if (a == 7 && b == 50) {
			System.out.println(57);
		} else if (a == 8 && b == 0) {
			System.out.println(8);
		} else if (a == 8 && b == 1) {
			System.out.println(9);
		} else if (a == 8 && b == 2) {
			System.out.println(10);
		} else if (a == 8 && b == 3) {
			System.out.println(11);
		} else if (a == 8 && b == 4) {
			System.out.println(12);
		} else if (a == 8 && b == 5) {
			System.out.println(13);
		} else if (a == 8 && b == 6) {
			System.out.println(14);
		} else if (a == 8 && b == 7) {
			System.out.println(15);
		} else if (a == 8 && b == 8) {
			System.out.println(16);
		} else if (a == 8 && b == 9) {
			System.out.println(17);
		} else if (a == 8 && b == 10) {
			System.out.println(18);
		} else if (a == 8 && b == 11) {
			System.out.println(19);
		} else if (a == 8 && b == 12) {
			System.out.println(20);
		} else if (a == 8 && b == 13) {
			System.out.println(21);
		} else if (a == 8 && b == 14) {
			System.out.println(22);
		} else if (a == 8 && b == 15) {
			System.out.println(23);
		} else if (a == 8 && b == 16) {
			System.out.println(24);
		} else if (a == 8 && b == 17) {
			System.out.println(25);
		} else if (a == 8 && b == 18) {
			System.out.println(26);
		} else if (a == 8 && b == 19) {
			System.out.println(27);
		} else if (a == 8 && b == 20) {
			System.out.println(28);
		} else if (a == 8 && b == 21) {
			System.out.println(29);
		} else if (a == 8 && b == 22) {
			System.out.println(30);
		} else if (a == 8 && b == 23) {
			System.out.println(31);
		} else if (a == 8 && b == 24) {
			System.out.println(32);
		} else if (a == 8 && b == 25) {
			System.out.println(33);
		} else if (a == 8 && b == 26) {
			System.out.println(34);
		} else if (a == 8 && b == 27) {
			System.out.println(35);
		} else if (a == 8 && b == 28) {
			System.out.println(36);
		} else if (a == 8 && b == 29) {
			System.out.println(37);
		} else if (a == 8 && b == 30) {
			System.out.println(38);
		} else if (a == 8 && b == 31) {
			System.out.println(39);
		} else if (a == 8 && b == 32) {
			System.out.println(40);
		} else if (a == 8 && b == 33) {
			System.out.println(41);
		} else if (a == 8 && b == 34) {
			System.out.println(42);
		} else if (a == 8 && b == 35) {
			System.out.println(43);
		} else if (a == 8 && b == 36) {
			System.out.println(44);
		} else if (a == 8 && b == 37) {
			System.out.println(45);
		} else if (a == 8 && b == 38) {
			System.out.println(46);
		} else if (a == 8 && b == 39) {
			System.out.println(47);
		} else if (a == 8 && b == 40) {
			System.out.println(48);
		} else if (a == 8 && b == 41) {
			System.out.println(49);
		} else if (a == 8 && b == 42) {
			System.out.println(50);
		} else if (a == 8 && b == 43) {
			System.out.println(51);
		} else if (a == 8 && b == 44) {
			System.out.println(52);
		} else if (a == 8 && b == 45) {
			System.out.println(53);
		} else if (a == 8 && b == 46) {
			System.out.println(54);
		} else if (a == 8 && b == 47) {
			System.out.println(55);
		} else if (a == 8 && b == 48) {
			System.out.println(56);
		} else if (a == 8 && b == 49) {
			System.out.println(57);
		} else if (a == 8 && b == 50) {
			System.out.println(58);
		} else if (a == 9 && b == 0) {
			System.out.println(9);
		} else if (a == 9 && b == 1) {
			System.out.println(10);
		} else if (a == 9 && b == 2) {
			System.out.println(11);
		} else if (a == 9 && b == 3) {
			System.out.println(12);
		} else if (a == 9 && b == 4) {
			System.out.println(13);
		} else if (a == 9 && b == 5) {
			System.out.println(14);
		} else if (a == 9 && b == 6) {
			System.out.println(15);
		} else if (a == 9 && b == 7) {
			System.out.println(16);
		} else if (a == 9 && b == 8) {
			System.out.println(17);
		} else if (a == 9 && b == 9) {
			System.out.println(18);
		} else if (a == 9 && b == 10) {
			System.out.println(19);
		} else if (a == 9 && b == 11) {
			System.out.println(20);
		} else if (a == 9 && b == 12) {
			System.out.println(21);
		} else if (a == 9 && b == 13) {
			System.out.println(22);
		} else if (a == 9 && b == 14) {
			System.out.println(23);
		} else if (a == 9 && b == 15) {
			System.out.println(24);
		} else if (a == 9 && b == 16) {
			System.out.println(25);
		} else if (a == 9 && b == 17) {
			System.out.println(26);
		} else if (a == 9 && b == 18) {
			System.out.println(27);
		} else if (a == 9 && b == 19) {
			System.out.println(28);
		} else if (a == 9 && b == 20) {
			System.out.println(29);
		} else if (a == 9 && b == 21) {
			System.out.println(30);
		} else if (a == 9 && b == 22) {
			System.out.println(31);
		} else if (a == 9 && b == 23) {
			System.out.println(32);
		} else if (a == 9 && b == 24) {
			System.out.println(33);
		} else if (a == 9 && b == 25) {
			System.out.println(34);
		} else if (a == 9 && b == 26) {
			System.out.println(35);
		} else if (a == 9 && b == 27) {
			System.out.println(36);
		} else if (a == 9 && b == 28) {
			System.out.println(37);
		} else if (a == 9 && b == 29) {
			System.out.println(38);
		} else if (a == 9 && b == 30) {
			System.out.println(39);
		} else if (a == 9 && b == 31) {
			System.out.println(40);
		} else if (a == 9 && b == 32) {
			System.out.println(41);
		} else if (a == 9 && b == 33) {
			System.out.println(42);
		} else if (a == 9 && b == 34) {
			System.out.println(43);
		} else if (a == 9 && b == 35) {
			System.out.println(44);
		} else if (a == 9 && b == 36) {
			System.out.println(45);
		} else if (a == 9 && b == 37) {
			System.out.println(46);
		} else if (a == 9 && b == 38) {
			System.out.println(47);
		} else if (a == 9 && b == 39) {
			System.out.println(48);
		} else if (a == 9 && b == 40) {
			System.out.println(49);
		} else if (a == 9 && b == 41) {
			System.out.println(50);
		} else if (a == 9 && b == 42) {
			System.out.println(51);
		} else if (a == 9 && b == 43) {
			System.out.println(52);
		} else if (a == 9 && b == 44) {
			System.out.println(53);
		} else if (a == 9 && b == 45) {
			System.out.println(54);
		} else if (a == 9 && b == 46) {
			System.out.println(55);
		} else if (a == 9 && b == 47) {
			System.out.println(56);
		} else if (a == 9 && b == 48) {
			System.out.println(57);
		} else if (a == 9 && b == 49) {
			System.out.println(58);
		} else if (a == 9 && b == 50) {
			System.out.println(59);
		} else if (a == 10 && b == 0) {
			System.out.println(10);
		} else if (a == 10 && b == 1) {
			System.out.println(11);
		} else if (a == 10 && b == 2) {
			System.out.println(12);
		} else if (a == 10 && b == 3) {
			System.out.println(13);
		} else if (a == 10 && b == 4) {
			System.out.println(14);
		} else if (a == 10 && b == 5) {
			System.out.println(15);
		} else if (a == 10 && b == 6) {
			System.out.println(16);
		} else if (a == 10 && b == 7) {
			System.out.println(17);
		} else if (a == 10 && b == 8) {
			System.out.println(18);
		} else if (a == 10 && b == 9) {
			System.out.println(19);
		} else if (a == 10 && b == 10) {
			System.out.println(20);
		} else if (a == 10 && b == 11) {
			System.out.println(21);
		} else if (a == 10 && b == 12) {
			System.out.println(22);
		} else if (a == 10 && b == 13) {
			System.out.println(23);
		} else if (a == 10 && b == 14) {
			System.out.println(24);
		} else if (a == 10 && b == 15) {
			System.out.println(25);
		} else if (a == 10 && b == 16) {
			System.out.println(26);
		} else if (a == 10 && b == 17) {
			System.out.println(27);
		} else if (a == 10 && b == 18) {
			System.out.println(28);
		} else if (a == 10 && b == 19) {
			System.out.println(29);
		} else if (a == 10 && b == 20) {
			System.out.println(30);
		} else if (a == 10 && b == 21) {
			System.out.println(31);
		} else if (a == 10 && b == 22) {
			System.out.println(32);
		} else if (a == 10 && b == 23) {
			System.out.println(33);
		} else if (a == 10 && b == 24) {
			System.out.println(34);
		} else if (a == 10 && b == 25) {
			System.out.println(35);
		} else if (a == 10 && b == 26) {
			System.out.println(36);
		} else if (a == 10 && b == 27) {
			System.out.println(37);
		} else if (a == 10 && b == 28) {
			System.out.println(38);
		} else if (a == 10 && b == 29) {
			System.out.println(39);
		} else if (a == 10 && b == 30) {
			System.out.println(40);
		} else if (a == 10 && b == 31) {
			System.out.println(41);
		} else if (a == 10 && b == 32) {
			System.out.println(42);
		} else if (a == 10 && b == 33) {
			System.out.println(43);
		} else if (a == 10 && b == 34) {
			System.out.println(44);
		} else if (a == 10 && b == 35) {
			System.out.println(45);
		} else if (a == 10 && b == 36) {
			System.out.println(46);
		} else if (a == 10 && b == 37) {
			System.out.println(47);
		} else if (a == 10 && b == 38) {
			System.out.println(48);
		} else if (a == 10 && b == 39) {
			System.out.println(49);
		} else if (a == 10 && b == 40) {
			System.out.println(50);
		} else if (a == 10 && b == 41) {
			System.out.println(51);
		} else if (a == 10 && b == 42) {
			System.out.println(52);
		} else if (a == 10 && b == 43) {
			System.out.println(53);
		} else if (a == 10 && b == 44) {
			System.out.println(54);
		} else if (a == 10 && b == 45) {
			System.out.println(55);
		} else if (a == 10 && b == 46) {
			System.out.println(56);
		} else if (a == 10 && b == 47) {
			System.out.println(57);
		} else if (a == 10 && b == 48) {
			System.out.println(58);
		} else if (a == 10 && b == 49) {
			System.out.println(59);
		} else if (a == 10 && b == 50) {
			System.out.println(60);
		} else if (a == 11 && b == 0) {
			System.out.println(11);
		} else if (a == 11 && b == 1) {
			System.out.println(12);
		} else if (a == 11 && b == 2) {
			System.out.println(13);
		} else if (a == 11 && b == 3) {
			System.out.println(14);
		} else if (a == 11 && b == 4) {
			System.out.println(15);
		} else if (a == 11 && b == 5) {
			System.out.println(16);
		} else if (a == 11 && b == 6) {
			System.out.println(17);
		} else if (a == 11 && b == 7) {
			System.out.println(18);
		} else if (a == 11 && b == 8) {
			System.out.println(19);
		} else if (a == 11 && b == 9) {
			System.out.println(20);
		} else if (a == 11 && b == 10) {
			System.out.println(21);
		} else if (a == 11 && b == 11) {
			System.out.println(22);
		} else if (a == 11 && b == 12) {
			System.out.println(23);
		} else if (a == 11 && b == 13) {
			System.out.println(24);
		} else if (a == 11 && b == 14) {
			System.out.println(25);
		} else if (a == 11 && b == 15) {
			System.out.println(26);
		} else if (a == 11 && b == 16) {
			System.out.println(27);
		} else if (a == 11 && b == 17) {
			System.out.println(28);
		} else if (a == 11 && b == 18) {
			System.out.println(29);
		} else if (a == 11 && b == 19) {
			System.out.println(30);
		} else if (a == 11 && b == 20) {
			System.out.println(31);
		} else if (a == 11 && b == 21) {
			System.out.println(32);
		} else if (a == 11 && b == 22) {
			System.out.println(33);
		} else if (a == 11 && b == 23) {
			System.out.println(34);
		} else if (a == 11 && b == 24) {
			System.out.println(35);
		} else if (a == 11 && b == 25) {
			System.out.println(36);
		} else if (a == 11 && b == 26) {
			System.out.println(37);
		} else if (a == 11 && b == 27) {
			System.out.println(38);
		} else if (a == 11 && b == 28) {
			System.out.println(39);
		} else if (a == 11 && b == 29) {
			System.out.println(40);
		} else if (a == 11 && b == 30) {
			System.out.println(41);
		} else if (a == 11 && b == 31) {
			System.out.println(42);
		} else if (a == 11 && b == 32) {
			System.out.println(43);
		} else if (a == 11 && b == 33) {
			System.out.println(44);
		} else if (a == 11 && b == 34) {
			System.out.println(45);
		} else if (a == 11 && b == 35) {
			System.out.println(46);
		} else if (a == 11 && b == 36) {
			System.out.println(47);
		} else if (a == 11 && b == 37) {
			System.out.println(48);
		} else if (a == 11 && b == 38) {
			System.out.println(49);
		} else if (a == 11 && b == 39) {
			System.out.println(50);
		} else if (a == 11 && b == 40) {
			System.out.println(51);
		} else if (a == 11 && b == 41) {
			System.out.println(52);
		} else if (a == 11 && b == 42) {
			System.out.println(53);
		} else if (a == 11 && b == 43) {
			System.out.println(54);
		} else if (a == 11 && b == 44) {
			System.out.println(55);
		} else if (a == 11 && b == 45) {
			System.out.println(56);
		} else if (a == 11 && b == 46) {
			System.out.println(57);
		} else if (a == 11 && b == 47) {
			System.out.println(58);
		} else if (a == 11 && b == 48) {
			System.out.println(59);
		} else if (a == 11 && b == 49) {
			System.out.println(60);
		} else if (a == 11 && b == 50) {
			System.out.println(61);
		} else if (a == 12 && b == 0) {
			System.out.println(12);
		} else if (a == 12 && b == 1) {
			System.out.println(13);
		} else if (a == 12 && b == 2) {
			System.out.println(14);
		} else if (a == 12 && b == 3) {
			System.out.println(15);
		} else if (a == 12 && b == 4) {
			System.out.println(16);
		} else if (a == 12 && b == 5) {
			System.out.println(17);
		} else if (a == 12 && b == 6) {
			System.out.println(18);
		} else if (a == 12 && b == 7) {
			System.out.println(19);
		} else if (a == 12 && b == 8) {
			System.out.println(20);
		} else if (a == 12 && b == 9) {
			System.out.println(21);
		} else if (a == 12 && b == 10) {
			System.out.println(22);
		} else if (a == 12 && b == 11) {
			System.out.println(23);
		} else if (a == 12 && b == 12) {
			System.out.println(24);
		} else if (a == 12 && b == 13) {
			System.out.println(25);
		} else if (a == 12 && b == 14) {
			System.out.println(26);
		} else if (a == 12 && b == 15) {
			System.out.println(27);
		} else if (a == 12 && b == 16) {
			System.out.println(28);
		} else if (a == 12 && b == 17) {
			System.out.println(29);
		} else if (a == 12 && b == 18) {
			System.out.println(30);
		} else if (a == 12 && b == 19) {
			System.out.println(31);
		} else if (a == 12 && b == 20) {
			System.out.println(32);
		} else if (a == 12 && b == 21) {
			System.out.println(33);
		} else if (a == 12 && b == 22) {
			System.out.println(34);
		} else if (a == 12 && b == 23) {
			System.out.println(35);
		} else if (a == 12 && b == 24) {
			System.out.println(36);
		} else if (a == 12 && b == 25) {
			System.out.println(37);
		} else if (a == 12 && b == 26) {
			System.out.println(38);
		} else if (a == 12 && b == 27) {
			System.out.println(39);
		} else if (a == 12 && b == 28) {
			System.out.println(40);
		} else if (a == 12 && b == 29) {
			System.out.println(41);
		} else if (a == 12 && b == 30) {
			System.out.println(42);
		} else if (a == 12 && b == 31) {
			System.out.println(43);
		} else if (a == 12 && b == 32) {
			System.out.println(44);
		} else if (a == 12 && b == 33) {
			System.out.println(45);
		} else if (a == 12 && b == 34) {
			System.out.println(46);
		} else if (a == 12 && b == 35) {
			System.out.println(47);
		} else if (a == 12 && b == 36) {
			System.out.println(48);
		} else if (a == 12 && b == 37) {
			System.out.println(49);
		} else if (a == 12 && b == 38) {
			System.out.println(50);
		} else if (a == 12 && b == 39) {
			System.out.println(51);
		} else if (a == 12 && b == 40) {
			System.out.println(52);
		} else if (a == 12 && b == 41) {
			System.out.println(53);
		} else if (a == 12 && b == 42) {
			System.out.println(54);
		} else if (a == 12 && b == 43) {
			System.out.println(55);
		} else if (a == 12 && b == 44) {
			System.out.println(56);
		} else if (a == 12 && b == 45) {
			System.out.println(57);
		} else if (a == 12 && b == 46) {
			System.out.println(58);
		} else if (a == 12 && b == 47) {
			System.out.println(59);
		} else if (a == 12 && b == 48) {
			System.out.println(60);
		} else if (a == 12 && b == 49) {
			System.out.println(61);
		} else if (a == 12 && b == 50) {
			System.out.println(62);
		} else if (a == 13 && b == 0) {
			System.out.println(13);
		} else if (a == 13 && b == 1) {
			System.out.println(14);
		} else if (a == 13 && b == 2) {
			System.out.println(15);
		} else if (a == 13 && b == 3) {
			System.out.println(16);
		} else if (a == 13 && b == 4) {
			System.out.println(17);
		} else if (a == 13 && b == 5) {
			System.out.println(18);
		} else if (a == 13 && b == 6) {
			System.out.println(19);
		} else if (a == 13 && b == 7) {
			System.out.println(20);
		} else if (a == 13 && b == 8) {
			System.out.println(21);
		} else if (a == 13 && b == 9) {
			System.out.println(22);
		} else if (a == 13 && b == 10) {
			System.out.println(23);
		} else if (a == 13 && b == 11) {
			System.out.println(24);
		} else if (a == 13 && b == 12) {
			System.out.println(25);
		} else if (a == 13 && b == 13) {
			System.out.println(26);
		} else if (a == 13 && b == 14) {
			System.out.println(27);
		} else if (a == 13 && b == 15) {
			System.out.println(28);
		} else if (a == 13 && b == 16) {
			System.out.println(29);
		} else if (a == 13 && b == 17) {
			System.out.println(30);
		} else if (a == 13 && b == 18) {
			System.out.println(31);
		} else if (a == 13 && b == 19) {
			System.out.println(32);
		} else if (a == 13 && b == 20) {
			System.out.println(33);
		} else if (a == 13 && b == 21) {
			System.out.println(34);
		} else if (a == 13 && b == 22) {
			System.out.println(35);
		} else if (a == 13 && b == 23) {
			System.out.println(36);
		} else if (a == 13 && b == 24) {
			System.out.println(37);
		} else if (a == 13 && b == 25) {
			System.out.println(38);
		} else if (a == 13 && b == 26) {
			System.out.println(39);
		} else if (a == 13 && b == 27) {
			System.out.println(40);
		} else if (a == 13 && b == 28) {
			System.out.println(41);
		} else if (a == 13 && b == 29) {
			System.out.println(42);
		} else if (a == 13 && b == 30) {
			System.out.println(43);
		} else if (a == 13 && b == 31) {
			System.out.println(44);
		} else if (a == 13 && b == 32) {
			System.out.println(45);
		} else if (a == 13 && b == 33) {
			System.out.println(46);
		} else if (a == 13 && b == 34) {
			System.out.println(47);
		} else if (a == 13 && b == 35) {
			System.out.println(48);
		} else if (a == 13 && b == 36) {
			System.out.println(49);
		} else if (a == 13 && b == 37) {
			System.out.println(50);
		} else if (a == 13 && b == 38) {
			System.out.println(51);
		} else if (a == 13 && b == 39) {
			System.out.println(52);
		} else if (a == 13 && b == 40) {
			System.out.println(53);
		} else if (a == 13 && b == 41) {
			System.out.println(54);
		} else if (a == 13 && b == 42) {
			System.out.println(55);
		} else if (a == 13 && b == 43) {
			System.out.println(56);
		} else if (a == 13 && b == 44) {
			System.out.println(57);
		} else if (a == 13 && b == 45) {
			System.out.println(58);
		} else if (a == 13 && b == 46) {
			System.out.println(59);
		} else if (a == 13 && b == 47) {
			System.out.println(60);
		} else if (a == 13 && b == 48) {
			System.out.println(61);
		} else if (a == 13 && b == 49) {
			System.out.println(62);
		} else if (a == 13 && b == 50) {
			System.out.println(63);
		} else if (a == 14 && b == 0) {
			System.out.println(14);
		} else if (a == 14 && b == 1) {
			System.out.println(15);
		} else if (a == 14 && b == 2) {
			System.out.println(16);
		} else if (a == 14 && b == 3) {
			System.out.println(17);
		} else if (a == 14 && b == 4) {
			System.out.println(18);
		} else if (a == 14 && b == 5) {
			System.out.println(19);
		} else if (a == 14 && b == 6) {
			System.out.println(20);
		} else if (a == 14 && b == 7) {
			System.out.println(21);
		} else if (a == 14 && b == 8) {
			System.out.println(22);
		} else if (a == 14 && b == 9) {
			System.out.println(23);
		} else if (a == 14 && b == 10) {
			System.out.println(24);
		} else if (a == 14 && b == 11) {
			System.out.println(25);
		} else if (a == 14 && b == 12) {
			System.out.println(26);
		} else if (a == 14 && b == 13) {
			System.out.println(27);
		} else if (a == 14 && b == 14) {
			System.out.println(28);
		} else if (a == 14 && b == 15) {
			System.out.println(29);
		} else if (a == 14 && b == 16) {
			System.out.println(30);
		} else if (a == 14 && b == 17) {
			System.out.println(31);
		} else if (a == 14 && b == 18) {
			System.out.println(32);
		} else if (a == 14 && b == 19) {
			System.out.println(33);
		} else if (a == 14 && b == 20) {
			System.out.println(34);
		} else if (a == 14 && b == 21) {
			System.out.println(35);
		} else if (a == 14 && b == 22) {
			System.out.println(36);
		} else if (a == 14 && b == 23) {
			System.out.println(37);
		} else if (a == 14 && b == 24) {
			System.out.println(38);
		} else if (a == 14 && b == 25) {
			System.out.println(39);
		} else if (a == 14 && b == 26) {
			System.out.println(40);
		} else if (a == 14 && b == 27) {
			System.out.println(41);
		} else if (a == 14 && b == 28) {
			System.out.println(42);
		} else if (a == 14 && b == 29) {
			System.out.println(43);
		} else if (a == 14 && b == 30) {
			System.out.println(44);
		} else if (a == 14 && b == 31) {
			System.out.println(45);
		} else if (a == 14 && b == 32) {
			System.out.println(46);
		} else if (a == 14 && b == 33) {
			System.out.println(47);
		} else if (a == 14 && b == 34) {
			System.out.println(48);
		} else if (a == 14 && b == 35) {
			System.out.println(49);
		} else if (a == 14 && b == 36) {
			System.out.println(50);
		} else if (a == 14 && b == 37) {
			System.out.println(51);
		} else if (a == 14 && b == 38) {
			System.out.println(52);
		} else if (a == 14 && b == 39) {
			System.out.println(53);
		} else if (a == 14 && b == 40) {
			System.out.println(54);
		} else if (a == 14 && b == 41) {
			System.out.println(55);
		} else if (a == 14 && b == 42) {
			System.out.println(56);
		} else if (a == 14 && b == 43) {
			System.out.println(57);
		} else if (a == 14 && b == 44) {
			System.out.println(58);
		} else if (a == 14 && b == 45) {
			System.out.println(59);
		} else if (a == 14 && b == 46) {
			System.out.println(60);
		} else if (a == 14 && b == 47) {
			System.out.println(61);
		} else if (a == 14 && b == 48) {
			System.out.println(62);
		} else if (a == 14 && b == 49) {
			System.out.println(63);
		} else if (a == 14 && b == 50) {
			System.out.println(64);
		} else if (a == 15 && b == 0) {
			System.out.println(15);
		} else if (a == 15 && b == 1) {
			System.out.println(16);
		} else if (a == 15 && b == 2) {
			System.out.println(17);
		} else if (a == 15 && b == 3) {
			System.out.println(18);
		} else if (a == 15 && b == 4) {
			System.out.println(19);
		} else if (a == 15 && b == 5) {
			System.out.println(20);
		} else if (a == 15 && b == 6) {
			System.out.println(21);
		} else if (a == 15 && b == 7) {
			System.out.println(22);
		} else if (a == 15 && b == 8) {
			System.out.println(23);
		} else if (a == 15 && b == 9) {
			System.out.println(24);
		} else if (a == 15 && b == 10) {
			System.out.println(25);
		} else if (a == 15 && b == 11) {
			System.out.println(26);
		} else if (a == 15 && b == 12) {
			System.out.println(27);
		} else if (a == 15 && b == 13) {
			System.out.println(28);
		} else if (a == 15 && b == 14) {
			System.out.println(29);
		} else if (a == 15 && b == 15) {
			System.out.println(30);
		} else if (a == 15 && b == 16) {
			System.out.println(31);
		} else if (a == 15 && b == 17) {
			System.out.println(32);
		} else if (a == 15 && b == 18) {
			System.out.println(33);
		} else if (a == 15 && b == 19) {
			System.out.println(34);
		} else if (a == 15 && b == 20) {
			System.out.println(35);
		} else if (a == 15 && b == 21) {
			System.out.println(36);
		} else if (a == 15 && b == 22) {
			System.out.println(37);
		} else if (a == 15 && b == 23) {
			System.out.println(38);
		} else if (a == 15 && b == 24) {
			System.out.println(39);
		} else if (a == 15 && b == 25) {
			System.out.println(40);
		} else if (a == 15 && b == 26) {
			System.out.println(41);
		} else if (a == 15 && b == 27) {
			System.out.println(42);
		} else if (a == 15 && b == 28) {
			System.out.println(43);
		} else if (a == 15 && b == 29) {
			System.out.println(44);
		} else if (a == 15 && b == 30) {
			System.out.println(45);
		} else if (a == 15 && b == 31) {
			System.out.println(46);
		} else if (a == 15 && b == 32) {
			System.out.println(47);
		} else if (a == 15 && b == 33) {
			System.out.println(48);
		} else if (a == 15 && b == 34) {
			System.out.println(49);
		} else if (a == 15 && b == 35) {
			System.out.println(50);
		} else if (a == 15 && b == 36) {
			System.out.println(51);
		} else if (a == 15 && b == 37) {
			System.out.println(52);
		} else if (a == 15 && b == 38) {
			System.out.println(53);
		} else if (a == 15 && b == 39) {
			System.out.println(54);
		} else if (a == 15 && b == 40) {
			System.out.println(55);
		} else if (a == 15 && b == 41) {
			System.out.println(56);
		} else if (a == 15 && b == 42) {
			System.out.println(57);
		} else if (a == 15 && b == 43) {
			System.out.println(58);
		} else if (a == 15 && b == 44) {
			System.out.println(59);
		} else if (a == 15 && b == 45) {
			System.out.println(60);
		} else if (a == 15 && b == 46) {
			System.out.println(61);
		} else if (a == 15 && b == 47) {
			System.out.println(62);
		} else if (a == 15 && b == 48) {
			System.out.println(63);
		} else if (a == 15 && b == 49) {
			System.out.println(64);
		} else if (a == 15 && b == 50) {
			System.out.println(65);
		} else if (a == 16 && b == 0) {
			System.out.println(16);
		} else if (a == 16 && b == 1) {
			System.out.println(17);
		} else if (a == 16 && b == 2) {
			System.out.println(18);
		} else if (a == 16 && b == 3) {
			System.out.println(19);
		} else if (a == 16 && b == 4) {
			System.out.println(20);
		} else if (a == 16 && b == 5) {
			System.out.println(21);
		} else if (a == 16 && b == 6) {
			System.out.println(22);
		} else if (a == 16 && b == 7) {
			System.out.println(23);
		} else if (a == 16 && b == 8) {
			System.out.println(24);
		} else if (a == 16 && b == 9) {
			System.out.println(25);
		} else if (a == 16 && b == 10) {
			System.out.println(26);
		} else if (a == 16 && b == 11) {
			System.out.println(27);
		} else if (a == 16 && b == 12) {
			System.out.println(28);
		} else if (a == 16 && b == 13) {
			System.out.println(29);
		} else if (a == 16 && b == 14) {
			System.out.println(30);
		} else if (a == 16 && b == 15) {
			System.out.println(31);
		} else if (a == 16 && b == 16) {
			System.out.println(32);
		} else if (a == 16 && b == 17) {
			System.out.println(33);
		} else if (a == 16 && b == 18) {
			System.out.println(34);
		} else if (a == 16 && b == 19) {
			System.out.println(35);
		} else if (a == 16 && b == 20) {
			System.out.println(36);
		} else if (a == 16 && b == 21) {
			System.out.println(37);
		} else if (a == 16 && b == 22) {
			System.out.println(38);
		} else if (a == 16 && b == 23) {
			System.out.println(39);
		} else if (a == 16 && b == 24) {
			System.out.println(40);
		} else if (a == 16 && b == 25) {
			System.out.println(41);
		} else if (a == 16 && b == 26) {
			System.out.println(42);
		} else if (a == 16 && b == 27) {
			System.out.println(43);
		} else if (a == 16 && b == 28) {
			System.out.println(44);
		} else if (a == 16 && b == 29) {
			System.out.println(45);
		} else if (a == 16 && b == 30) {
			System.out.println(46);
		} else if (a == 16 && b == 31) {
			System.out.println(47);
		} else if (a == 16 && b == 32) {
			System.out.println(48);
		} else if (a == 16 && b == 33) {
			System.out.println(49);
		} else if (a == 16 && b == 34) {
			System.out.println(50);
		} else if (a == 16 && b == 35) {
			System.out.println(51);
		} else if (a == 16 && b == 36) {
			System.out.println(52);
		} else if (a == 16 && b == 37) {
			System.out.println(53);
		} else if (a == 16 && b == 38) {
			System.out.println(54);
		} else if (a == 16 && b == 39) {
			System.out.println(55);
		} else if (a == 16 && b == 40) {
			System.out.println(56);
		} else if (a == 16 && b == 41) {
			System.out.println(57);
		} else if (a == 16 && b == 42) {
			System.out.println(58);
		} else if (a == 16 && b == 43) {
			System.out.println(59);
		} else if (a == 16 && b == 44) {
			System.out.println(60);
		} else if (a == 16 && b == 45) {
			System.out.println(61);
		} else if (a == 16 && b == 46) {
			System.out.println(62);
		} else if (a == 16 && b == 47) {
			System.out.println(63);
		} else if (a == 16 && b == 48) {
			System.out.println(64);
		} else if (a == 16 && b == 49) {
			System.out.println(65);
		} else if (a == 16 && b == 50) {
			System.out.println(66);
		} else if (a == 17 && b == 0) {
			System.out.println(17);
		} else if (a == 17 && b == 1) {
			System.out.println(18);
		} else if (a == 17 && b == 2) {
			System.out.println(19);
		} else if (a == 17 && b == 3) {
			System.out.println(20);
		} else if (a == 17 && b == 4) {
			System.out.println(21);
		} else if (a == 17 && b == 5) {
			System.out.println(22);
		} else if (a == 17 && b == 6) {
			System.out.println(23);
		} else if (a == 17 && b == 7) {
			System.out.println(24);
		} else if (a == 17 && b == 8) {
			System.out.println(25);
		} else if (a == 17 && b == 9) {
			System.out.println(26);
		} else if (a == 17 && b == 10) {
			System.out.println(27);
		} else if (a == 17 && b == 11) {
			System.out.println(28);
		} else if (a == 17 && b == 12) {
			System.out.println(29);
		} else if (a == 17 && b == 13) {
			System.out.println(30);
		} else if (a == 17 && b == 14) {
			System.out.println(31);
		} else if (a == 17 && b == 15) {
			System.out.println(32);
		} else if (a == 17 && b == 16) {
			System.out.println(33);
		} else if (a == 17 && b == 17) {
			System.out.println(34);
		} else if (a == 17 && b == 18) {
			System.out.println(35);
		} else if (a == 17 && b == 19) {
			System.out.println(36);
		} else if (a == 17 && b == 20) {
			System.out.println(37);
		} else if (a == 17 && b == 21) {
			System.out.println(38);
		} else if (a == 17 && b == 22) {
			System.out.println(39);
		} else if (a == 17 && b == 23) {
			System.out.println(40);
		} else if (a == 17 && b == 24) {
			System.out.println(41);
		} else if (a == 17 && b == 25) {
			System.out.println(42);
		} else if (a == 17 && b == 26) {
			System.out.println(43);
		} else if (a == 17 && b == 27) {
			System.out.println(44);
		} else if (a == 17 && b == 28) {
			System.out.println(45);
		} else if (a == 17 && b == 29) {
			System.out.println(46);
		} else if (a == 17 && b == 30) {
			System.out.println(47);
		} else if (a == 17 && b == 31) {
			System.out.println(48);
		} else if (a == 17 && b == 32) {
			System.out.println(49);
		} else if (a == 17 && b == 33) {
			System.out.println(50);
		} else if (a == 17 && b == 34) {
			System.out.println(51);
		} else if (a == 17 && b == 35) {
			System.out.println(52);
		} else if (a == 17 && b == 36) {
			System.out.println(53);
		} else if (a == 17 && b == 37) {
			System.out.println(54);
		} else if (a == 17 && b == 38) {
			System.out.println(55);
		} else if (a == 17 && b == 39) {
			System.out.println(56);
		} else if (a == 17 && b == 40) {
			System.out.println(57);
		} else if (a == 17 && b == 41) {
			System.out.println(58);
		} else if (a == 17 && b == 42) {
			System.out.println(59);
		} else if (a == 17 && b == 43) {
			System.out.println(60);
		} else if (a == 17 && b == 44) {
			System.out.println(61);
		} else if (a == 17 && b == 45) {
			System.out.println(62);
		} else if (a == 17 && b == 46) {
			System.out.println(63);
		} else if (a == 17 && b == 47) {
			System.out.println(64);
		} else if (a == 17 && b == 48) {
			System.out.println(65);
		} else if (a == 17 && b == 49) {
			System.out.println(66);
		} else if (a == 17 && b == 50) {
			System.out.println(67);
		} else if (a == 18 && b == 0) {
			System.out.println(18);
		} else if (a == 18 && b == 1) {
			System.out.println(19);
		} else if (a == 18 && b == 2) {
			System.out.println(20);
		} else if (a == 18 && b == 3) {
			System.out.println(21);
		} else if (a == 18 && b == 4) {
			System.out.println(22);
		} else if (a == 18 && b == 5) {
			System.out.println(23);
		} else if (a == 18 && b == 6) {
			System.out.println(24);
		} else if (a == 18 && b == 7) {
			System.out.println(25);
		} else if (a == 18 && b == 8) {
			System.out.println(26);
		} else if (a == 18 && b == 9) {
			System.out.println(27);
		} else if (a == 18 && b == 10) {
			System.out.println(28);
		} else if (a == 18 && b == 11) {
			System.out.println(29);
		} else if (a == 18 && b == 12) {
			System.out.println(30);
		} else if (a == 18 && b == 13) {
			System.out.println(31);
		} else if (a == 18 && b == 14) {
			System.out.println(32);
		} else if (a == 18 && b == 15) {
			System.out.println(33);
		} else if (a == 18 && b == 16) {
			System.out.println(34);
		} else if (a == 18 && b == 17) {
			System.out.println(35);
		} else if (a == 18 && b == 18) {
			System.out.println(36);
		} else if (a == 18 && b == 19) {
			System.out.println(37);
		} else if (a == 18 && b == 20) {
			System.out.println(38);
		} else if (a == 18 && b == 21) {
			System.out.println(39);
		} else if (a == 18 && b == 22) {
			System.out.println(40);
		} else if (a == 18 && b == 23) {
			System.out.println(41);
		} else if (a == 18 && b == 24) {
			System.out.println(42);
		} else if (a == 18 && b == 25) {
			System.out.println(43);
		} else if (a == 18 && b == 26) {
			System.out.println(44);
		} else if (a == 18 && b == 27) {
			System.out.println(45);
		} else if (a == 18 && b == 28) {
			System.out.println(46);
		} else if (a == 18 && b == 29) {
			System.out.println(47);
		} else if (a == 18 && b == 30) {
			System.out.println(48);
		} else if (a == 18 && b == 31) {
			System.out.println(49);
		} else if (a == 18 && b == 32) {
			System.out.println(50);
		} else if (a == 18 && b == 33) {
			System.out.println(51);
		} else if (a == 18 && b == 34) {
			System.out.println(52);
		} else if (a == 18 && b == 35) {
			System.out.println(53);
		} else if (a == 18 && b == 36) {
			System.out.println(54);
		} else if (a == 18 && b == 37) {
			System.out.println(55);
		} else if (a == 18 && b == 38) {
			System.out.println(56);
		} else if (a == 18 && b == 39) {
			System.out.println(57);
		} else if (a == 18 && b == 40) {
			System.out.println(58);
		} else if (a == 18 && b == 41) {
			System.out.println(59);
		} else if (a == 18 && b == 42) {
			System.out.println(60);
		} else if (a == 18 && b == 43) {
			System.out.println(61);
		} else if (a == 18 && b == 44) {
			System.out.println(62);
		} else if (a == 18 && b == 45) {
			System.out.println(63);
		} else if (a == 18 && b == 46) {
			System.out.println(64);
		} else if (a == 18 && b == 47) {
			System.out.println(65);
		} else if (a == 18 && b == 48) {
			System.out.println(66);
		} else if (a == 18 && b == 49) {
			System.out.println(67);
		} else if (a == 18 && b == 50) {
			System.out.println(68);
		} else if (a == 19 && b == 0) {
			System.out.println(19);
		} else if (a == 19 && b == 1) {
			System.out.println(20);
		} else if (a == 19 && b == 2) {
			System.out.println(21);
		} else if (a == 19 && b == 3) {
			System.out.println(22);
		} else if (a == 19 && b == 4) {
			System.out.println(23);
		} else if (a == 19 && b == 5) {
			System.out.println(24);
		} else if (a == 19 && b == 6) {
			System.out.println(25);
		} else if (a == 19 && b == 7) {
			System.out.println(26);
		} else if (a == 19 && b == 8) {
			System.out.println(27);
		} else if (a == 19 && b == 9) {
			System.out.println(28);
		} else if (a == 19 && b == 10) {
			System.out.println(29);
		} else if (a == 19 && b == 11) {
			System.out.println(30);
		} else if (a == 19 && b == 12) {
			System.out.println(31);
		} else if (a == 19 && b == 13) {
			System.out.println(32);
		} else if (a == 19 && b == 14) {
			System.out.println(33);
		} else if (a == 19 && b == 15) {
			System.out.println(34);
		} else if (a == 19 && b == 16) {
			System.out.println(35);
		} else if (a == 19 && b == 17) {
			System.out.println(36);
		} else if (a == 19 && b == 18) {
			System.out.println(37);
		} else if (a == 19 && b == 19) {
			System.out.println(38);
		} else if (a == 19 && b == 20) {
			System.out.println(39);
		} else if (a == 19 && b == 21) {
			System.out.println(40);
		} else if (a == 19 && b == 22) {
			System.out.println(41);
		} else if (a == 19 && b == 23) {
			System.out.println(42);
		} else if (a == 19 && b == 24) {
			System.out.println(43);
		} else if (a == 19 && b == 25) {
			System.out.println(44);
		} else if (a == 19 && b == 26) {
			System.out.println(45);
		} else if (a == 19 && b == 27) {
			System.out.println(46);
		} else if (a == 19 && b == 28) {
			System.out.println(47);
		} else if (a == 19 && b == 29) {
			System.out.println(48);
		} else if (a == 19 && b == 30) {
			System.out.println(49);
		} else if (a == 19 && b == 31) {
			System.out.println(50);
		} else if (a == 19 && b == 32) {
			System.out.println(51);
		} else if (a == 19 && b == 33) {
			System.out.println(52);
		} else if (a == 19 && b == 34) {
			System.out.println(53);
		} else if (a == 19 && b == 35) {
			System.out.println(54);
		} else if (a == 19 && b == 36) {
			System.out.println(55);
		} else if (a == 19 && b == 37) {
			System.out.println(56);
		} else if (a == 19 && b == 38) {
			System.out.println(57);
		} else if (a == 19 && b == 39) {
			System.out.println(58);
		} else if (a == 19 && b == 40) {
			System.out.println(59);
		} else if (a == 19 && b == 41) {
			System.out.println(60);
		} else if (a == 19 && b == 42) {
			System.out.println(61);
		} else if (a == 19 && b == 43) {
			System.out.println(62);
		} else if (a == 19 && b == 44) {
			System.out.println(63);
		} else if (a == 19 && b == 45) {
			System.out.println(64);
		} else if (a == 19 && b == 46) {
			System.out.println(65);
		} else if (a == 19 && b == 47) {
			System.out.println(66);
		} else if (a == 19 && b == 48) {
			System.out.println(67);
		} else if (a == 19 && b == 49) {
			System.out.println(68);
		} else if (a == 19 && b == 50) {
			System.out.println(69);
		} else if (a == 20 && b == 0) {
			System.out.println(20);
		} else if (a == 20 && b == 1) {
			System.out.println(21);
		} else if (a == 20 && b == 2) {
			System.out.println(22);
		} else if (a == 20 && b == 3) {
			System.out.println(23);
		} else if (a == 20 && b == 4) {
			System.out.println(24);
		} else if (a == 20 && b == 5) {
			System.out.println(25);
		} else if (a == 20 && b == 6) {
			System.out.println(26);
		} else if (a == 20 && b == 7) {
			System.out.println(27);
		} else if (a == 20 && b == 8) {
			System.out.println(28);
		} else if (a == 20 && b == 9) {
			System.out.println(29);
		} else if (a == 20 && b == 10) {
			System.out.println(30);
		} else if (a == 20 && b == 11) {
			System.out.println(31);
		} else if (a == 20 && b == 12) {
			System.out.println(32);
		} else if (a == 20 && b == 13) {
			System.out.println(33);
		} else if (a == 20 && b == 14) {
			System.out.println(34);
		} else if (a == 20 && b == 15) {
			System.out.println(35);
		} else if (a == 20 && b == 16) {
			System.out.println(36);
		} else if (a == 20 && b == 17) {
			System.out.println(37);
		} else if (a == 20 && b == 18) {
			System.out.println(38);
		} else if (a == 20 && b == 19) {
			System.out.println(39);
		} else if (a == 20 && b == 20) {
			System.out.println(40);
		} else if (a == 20 && b == 21) {
			System.out.println(41);
		} else if (a == 20 && b == 22) {
			System.out.println(42);
		} else if (a == 20 && b == 23) {
			System.out.println(43);
		} else if (a == 20 && b == 24) {
			System.out.println(44);
		} else if (a == 20 && b == 25) {
			System.out.println(45);
		} else if (a == 20 && b == 26) {
			System.out.println(46);
		} else if (a == 20 && b == 27) {
			System.out.println(47);
		} else if (a == 20 && b == 28) {
			System.out.println(48);
		} else if (a == 20 && b == 29) {
			System.out.println(49);
		} else if (a == 20 && b == 30) {
			System.out.println(50);
		} else if (a == 20 && b == 31) {
			System.out.println(51);
		} else if (a == 20 && b == 32) {
			System.out.println(52);
		} else if (a == 20 && b == 33) {
			System.out.println(53);
		} else if (a == 20 && b == 34) {
			System.out.println(54);
		} else if (a == 20 && b == 35) {
			System.out.println(55);
		} else if (a == 20 && b == 36) {
			System.out.println(56);
		} else if (a == 20 && b == 37) {
			System.out.println(57);
		} else if (a == 20 && b == 38) {
			System.out.println(58);
		} else if (a == 20 && b == 39) {
			System.out.println(59);
		} else if (a == 20 && b == 40) {
			System.out.println(60);
		} else if (a == 20 && b == 41) {
			System.out.println(61);
		} else if (a == 20 && b == 42) {
			System.out.println(62);
		} else if (a == 20 && b == 43) {
			System.out.println(63);
		} else if (a == 20 && b == 44) {
			System.out.println(64);
		} else if (a == 20 && b == 45) {
			System.out.println(65);
		} else if (a == 20 && b == 46) {
			System.out.println(66);
		} else if (a == 20 && b == 47) {
			System.out.println(67);
		} else if (a == 20 && b == 48) {
			System.out.println(68);
		} else if (a == 20 && b == 49) {
			System.out.println(69);
		} else if (a == 20 && b == 50) {
			System.out.println(70);
		} else if (a == 21 && b == 0) {
			System.out.println(21);
		} else if (a == 21 && b == 1) {
			System.out.println(22);
		} else if (a == 21 && b == 2) {
			System.out.println(23);
		} else if (a == 21 && b == 3) {
			System.out.println(24);
		} else if (a == 21 && b == 4) {
			System.out.println(25);
		} else if (a == 21 && b == 5) {
			System.out.println(26);
		} else if (a == 21 && b == 6) {
			System.out.println(27);
		} else if (a == 21 && b == 7) {
			System.out.println(28);
		} else if (a == 21 && b == 8) {
			System.out.println(29);
		} else if (a == 21 && b == 9) {
			System.out.println(30);
		} else if (a == 21 && b == 10) {
			System.out.println(31);
		} else if (a == 21 && b == 11) {
			System.out.println(32);
		} else if (a == 21 && b == 12) {
			System.out.println(33);
		} else if (a == 21 && b == 13) {
			System.out.println(34);
		} else if (a == 21 && b == 14) {
			System.out.println(35);
		} else if (a == 21 && b == 15) {
			System.out.println(36);
		} else if (a == 21 && b == 16) {
			System.out.println(37);
		} else if (a == 21 && b == 17) {
			System.out.println(38);
		} else if (a == 21 && b == 18) {
			System.out.println(39);
		} else if (a == 21 && b == 19) {
			System.out.println(40);
		} else if (a == 21 && b == 20) {
			System.out.println(41);
		} else if (a == 21 && b == 21) {
			System.out.println(42);
		} else if (a == 21 && b == 22) {
			System.out.println(43);
		} else if (a == 21 && b == 23) {
			System.out.println(44);
		} else if (a == 21 && b == 24) {
			System.out.println(45);
		} else if (a == 21 && b == 25) {
			System.out.println(46);
		} else if (a == 21 && b == 26) {
			System.out.println(47);
		} else if (a == 21 && b == 27) {
			System.out.println(48);
		} else if (a == 21 && b == 28) {
			System.out.println(49);
		} else if (a == 21 && b == 29) {
			System.out.println(50);
		} else if (a == 21 && b == 30) {
			System.out.println(51);
		} else if (a == 21 && b == 31) {
			System.out.println(52);
		} else if (a == 21 && b == 32) {
			System.out.println(53);
		} else if (a == 21 && b == 33) {
			System.out.println(54);
		} else if (a == 21 && b == 34) {
			System.out.println(55);
		} else if (a == 21 && b == 35) {
			System.out.println(56);
		} else if (a == 21 && b == 36) {
			System.out.println(57);
		} else if (a == 21 && b == 37) {
			System.out.println(58);
		} else if (a == 21 && b == 38) {
			System.out.println(59);
		} else if (a == 21 && b == 39) {
			System.out.println(60);
		} else if (a == 21 && b == 40) {
			System.out.println(61);
		} else if (a == 21 && b == 41) {
			System.out.println(62);
		} else if (a == 21 && b == 42) {
			System.out.println(63);
		} else if (a == 21 && b == 43) {
			System.out.println(64);
		} else if (a == 21 && b == 44) {
			System.out.println(65);
		} else if (a == 21 && b == 45) {
			System.out.println(66);
		} else if (a == 21 && b == 46) {
			System.out.println(67);
		} else if (a == 21 && b == 47) {
			System.out.println(68);
		} else if (a == 21 && b == 48) {
			System.out.println(69);
		} else if (a == 21 && b == 49) {
			System.out.println(70);
		} else if (a == 21 && b == 50) {
			System.out.println(71);
		} else if (a == 22 && b == 0) {
			System.out.println(22);
		} else if (a == 22 && b == 1) {
			System.out.println(23);
		} else if (a == 22 && b == 2) {
			System.out.println(24);
		} else if (a == 22 && b == 3) {
			System.out.println(25);
		} else if (a == 22 && b == 4) {
			System.out.println(26);
		} else if (a == 22 && b == 5) {
			System.out.println(27);
		} else if (a == 22 && b == 6) {
			System.out.println(28);
		} else if (a == 22 && b == 7) {
			System.out.println(29);
		} else if (a == 22 && b == 8) {
			System.out.println(30);
		} else if (a == 22 && b == 9) {
			System.out.println(31);
		} else if (a == 22 && b == 10) {
			System.out.println(32);
		} else if (a == 22 && b == 11) {
			System.out.println(33);
		} else if (a == 22 && b == 12) {
			System.out.println(34);
		} else if (a == 22 && b == 13) {
			System.out.println(35);
		} else if (a == 22 && b == 14) {
			System.out.println(36);
		} else if (a == 22 && b == 15) {
			System.out.println(37);
		} else if (a == 22 && b == 16) {
			System.out.println(38);
		} else if (a == 22 && b == 17) {
			System.out.println(39);
		} else if (a == 22 && b == 18) {
			System.out.println(40);
		} else if (a == 22 && b == 19) {
			System.out.println(41);
		} else if (a == 22 && b == 20) {
			System.out.println(42);
		} else if (a == 22 && b == 21) {
			System.out.println(43);
		} else if (a == 22 && b == 22) {
			System.out.println(44);
		} else if (a == 22 && b == 23) {
			System.out.println(45);
		} else if (a == 22 && b == 24) {
			System.out.println(46);
		} else if (a == 22 && b == 25) {
			System.out.println(47);
		} else if (a == 22 && b == 26) {
			System.out.println(48);
		} else if (a == 22 && b == 27) {
			System.out.println(49);
		} else if (a == 22 && b == 28) {
			System.out.println(50);
		} else if (a == 22 && b == 29) {
			System.out.println(51);
		} else if (a == 22 && b == 30) {
			System.out.println(52);
		} else if (a == 22 && b == 31) {
			System.out.println(53);
		} else if (a == 22 && b == 32) {
			System.out.println(54);
		} else if (a == 22 && b == 33) {
			System.out.println(55);
		} else if (a == 22 && b == 34) {
			System.out.println(56);
		} else if (a == 22 && b == 35) {
			System.out.println(57);
		} else if (a == 22 && b == 36) {
			System.out.println(58);
		} else if (a == 22 && b == 37) {
			System.out.println(59);
		} else if (a == 22 && b == 38) {
			System.out.println(60);
		} else if (a == 22 && b == 39) {
			System.out.println(61);
		} else if (a == 22 && b == 40) {
			System.out.println(62);
		} else if (a == 22 && b == 41) {
			System.out.println(63);
		} else if (a == 22 && b == 42) {
			System.out.println(64);
		} else if (a == 22 && b == 43) {
			System.out.println(65);
		} else if (a == 22 && b == 44) {
			System.out.println(66);
		} else if (a == 22 && b == 45) {
			System.out.println(67);
		} else if (a == 22 && b == 46) {
			System.out.println(68);
		} else if (a == 22 && b == 47) {
			System.out.println(69);
		} else if (a == 22 && b == 48) {
			System.out.println(70);
		} else if (a == 22 && b == 49) {
			System.out.println(71);
		} else if (a == 22 && b == 50) {
			System.out.println(72);
		} else if (a == 23 && b == 0) {
			System.out.println(23);
		} else if (a == 23 && b == 1) {
			System.out.println(24);
		} else if (a == 23 && b == 2) {
			System.out.println(25);
		} else if (a == 23 && b == 3) {
			System.out.println(26);
		} else if (a == 23 && b == 4) {
			System.out.println(27);
		} else if (a == 23 && b == 5) {
			System.out.println(28);
		} else if (a == 23 && b == 6) {
			System.out.println(29);
		} else if (a == 23 && b == 7) {
			System.out.println(30);
		} else if (a == 23 && b == 8) {
			System.out.println(31);
		} else if (a == 23 && b == 9) {
			System.out.println(32);
		} else if (a == 23 && b == 10) {
			System.out.println(33);
		} else if (a == 23 && b == 11) {
			System.out.println(34);
		} else if (a == 23 && b == 12) {
			System.out.println(35);
		} else if (a == 23 && b == 13) {
			System.out.println(36);
		} else if (a == 23 && b == 14) {
			System.out.println(37);
		} else if (a == 23 && b == 15) {
			System.out.println(38);
		} else if (a == 23 && b == 16) {
			System.out.println(39);
		} else if (a == 23 && b == 17) {
			System.out.println(40);
		} else if (a == 23 && b == 18) {
			System.out.println(41);
		} else if (a == 23 && b == 19) {
			System.out.println(42);
		} else if (a == 23 && b == 20) {
			System.out.println(43);
		} else if (a == 23 && b == 21) {
			System.out.println(44);
		} else if (a == 23 && b == 22) {
			System.out.println(45);
		} else if (a == 23 && b == 23) {
			System.out.println(46);
		} else if (a == 23 && b == 24) {
			System.out.println(47);
		} else if (a == 23 && b == 25) {
			System.out.println(48);
		} else if (a == 23 && b == 26) {
			System.out.println(49);
		} else if (a == 23 && b == 27) {
			System.out.println(50);
		} else if (a == 23 && b == 28) {
			System.out.println(51);
		} else if (a == 23 && b == 29) {
			System.out.println(52);
		} else if (a == 23 && b == 30) {
			System.out.println(53);
		} else if (a == 23 && b == 31) {
			System.out.println(54);
		} else if (a == 23 && b == 32) {
			System.out.println(55);
		} else if (a == 23 && b == 33) {
			System.out.println(56);
		} else if (a == 23 && b == 34) {
			System.out.println(57);
		} else if (a == 23 && b == 35) {
			System.out.println(58);
		} else if (a == 23 && b == 36) {
			System.out.println(59);
		} else if (a == 23 && b == 37) {
			System.out.println(60);
		} else if (a == 23 && b == 38) {
			System.out.println(61);
		} else if (a == 23 && b == 39) {
			System.out.println(62);
		} else if (a == 23 && b == 40) {
			System.out.println(63);
		} else if (a == 23 && b == 41) {
			System.out.println(64);
		} else if (a == 23 && b == 42) {
			System.out.println(65);
		} else if (a == 23 && b == 43) {
			System.out.println(66);
		} else if (a == 23 && b == 44) {
			System.out.println(67);
		} else if (a == 23 && b == 45) {
			System.out.println(68);
		} else if (a == 23 && b == 46) {
			System.out.println(69);
		} else if (a == 23 && b == 47) {
			System.out.println(70);
		} else if (a == 23 && b == 48) {
			System.out.println(71);
		} else if (a == 23 && b == 49) {
			System.out.println(72);
		} else if (a == 23 && b == 50) {
			System.out.println(73);
		} else if (a == 24 && b == 0) {
			System.out.println(24);
		} else if (a == 24 && b == 1) {
			System.out.println(25);
		} else if (a == 24 && b == 2) {
			System.out.println(26);
		} else if (a == 24 && b == 3) {
			System.out.println(27);
		} else if (a == 24 && b == 4) {
			System.out.println(28);
		} else if (a == 24 && b == 5) {
			System.out.println(29);
		} else if (a == 24 && b == 6) {
			System.out.println(30);
		} else if (a == 24 && b == 7) {
			System.out.println(31);
		} else if (a == 24 && b == 8) {
			System.out.println(32);
		} else if (a == 24 && b == 9) {
			System.out.println(33);
		} else if (a == 24 && b == 10) {
			System.out.println(34);
		} else if (a == 24 && b == 11) {
			System.out.println(35);
		} else if (a == 24 && b == 12) {
			System.out.println(36);
		} else if (a == 24 && b == 13) {
			System.out.println(37);
		} else if (a == 24 && b == 14) {
			System.out.println(38);
		} else if (a == 24 && b == 15) {
			System.out.println(39);
		} else if (a == 24 && b == 16) {
			System.out.println(40);
		} else if (a == 24 && b == 17) {
			System.out.println(41);
		} else if (a == 24 && b == 18) {
			System.out.println(42);
		} else if (a == 24 && b == 19) {
			System.out.println(43);
		} else if (a == 24 && b == 20) {
			System.out.println(44);
		} else if (a == 24 && b == 21) {
			System.out.println(45);
		} else if (a == 24 && b == 22) {
			System.out.println(46);
		} else if (a == 24 && b == 23) {
			System.out.println(47);
		} else if (a == 24 && b == 24) {
			System.out.println(48);
		} else if (a == 24 && b == 25) {
			System.out.println(49);
		} else if (a == 24 && b == 26) {
			System.out.println(50);
		} else if (a == 24 && b == 27) {
			System.out.println(51);
		} else if (a == 24 && b == 28) {
			System.out.println(52);
		} else if (a == 24 && b == 29) {
			System.out.println(53);
		} else if (a == 24 && b == 30) {
			System.out.println(54);
		} else if (a == 24 && b == 31) {
			System.out.println(55);
		} else if (a == 24 && b == 32) {
			System.out.println(56);
		} else if (a == 24 && b == 33) {
			System.out.println(57);
		} else if (a == 24 && b == 34) {
			System.out.println(58);
		} else if (a == 24 && b == 35) {
			System.out.println(59);
		} else if (a == 24 && b == 36) {
			System.out.println(60);
		} else if (a == 24 && b == 37) {
			System.out.println(61);
		} else if (a == 24 && b == 38) {
			System.out.println(62);
		} else if (a == 24 && b == 39) {
			System.out.println(63);
		} else if (a == 24 && b == 40) {
			System.out.println(64);
		} else if (a == 24 && b == 41) {
			System.out.println(65);
		} else if (a == 24 && b == 42) {
			System.out.println(66);
		} else if (a == 24 && b == 43) {
			System.out.println(67);
		} else if (a == 24 && b == 44) {
			System.out.println(68);
		} else if (a == 24 && b == 45) {
			System.out.println(69);
		} else if (a == 24 && b == 46) {
			System.out.println(70);
		} else if (a == 24 && b == 47) {
			System.out.println(71);
		} else if (a == 24 && b == 48) {
			System.out.println(72);
		} else if (a == 24 && b == 49) {
			System.out.println(73);
		} else if (a == 24 && b == 50) {
			System.out.println(74);
		} else if (a == 25 && b == 0) {
			System.out.println(25);
		} else if (a == 25 && b == 1) {
			System.out.println(26);
		} else if (a == 25 && b == 2) {
			System.out.println(27);
		} else if (a == 25 && b == 3) {
			System.out.println(28);
		} else if (a == 25 && b == 4) {
			System.out.println(29);
		} else if (a == 25 && b == 5) {
			System.out.println(30);
		} else if (a == 25 && b == 6) {
			System.out.println(31);
		} else if (a == 25 && b == 7) {
			System.out.println(32);
		} else if (a == 25 && b == 8) {
			System.out.println(33);
		} else if (a == 25 && b == 9) {
			System.out.println(34);
		} else if (a == 25 && b == 10) {
			System.out.println(35);
		} else if (a == 25 && b == 11) {
			System.out.println(36);
		} else if (a == 25 && b == 12) {
			System.out.println(37);
		} else if (a == 25 && b == 13) {
			System.out.println(38);
		} else if (a == 25 && b == 14) {
			System.out.println(39);
		} else if (a == 25 && b == 15) {
			System.out.println(40);
		} else if (a == 25 && b == 16) {
			System.out.println(41);
		} else if (a == 25 && b == 17) {
			System.out.println(42);
		} else if (a == 25 && b == 18) {
			System.out.println(43);
		} else if (a == 25 && b == 19) {
			System.out.println(44);
		} else if (a == 25 && b == 20) {
			System.out.println(45);
		} else if (a == 25 && b == 21) {
			System.out.println(46);
		} else if (a == 25 && b == 22) {
			System.out.println(47);
		} else if (a == 25 && b == 23) {
			System.out.println(48);
		} else if (a == 25 && b == 24) {
			System.out.println(49);
		} else if (a == 25 && b == 25) {
			System.out.println(50);
		} else if (a == 25 && b == 26) {
			System.out.println(51);
		} else if (a == 25 && b == 27) {
			System.out.println(52);
		} else if (a == 25 && b == 28) {
			System.out.println(53);
		} else if (a == 25 && b == 29) {
			System.out.println(54);
		} else if (a == 25 && b == 30) {
			System.out.println(55);
		} else if (a == 25 && b == 31) {
			System.out.println(56);
		} else if (a == 25 && b == 32) {
			System.out.println(57);
		} else if (a == 25 && b == 33) {
			System.out.println(58);
		} else if (a == 25 && b == 34) {
			System.out.println(59);
		} else if (a == 25 && b == 35) {
			System.out.println(60);
		} else if (a == 25 && b == 36) {
			System.out.println(61);
		} else if (a == 25 && b == 37) {
			System.out.println(62);
		} else if (a == 25 && b == 38) {
			System.out.println(63);
		} else if (a == 25 && b == 39) {
			System.out.println(64);
		} else if (a == 25 && b == 40) {
			System.out.println(65);
		} else if (a == 25 && b == 41) {
			System.out.println(66);
		} else if (a == 25 && b == 42) {
			System.out.println(67);
		} else if (a == 25 && b == 43) {
			System.out.println(68);
		} else if (a == 25 && b == 44) {
			System.out.println(69);
		} else if (a == 25 && b == 45) {
			System.out.println(70);
		} else if (a == 25 && b == 46) {
			System.out.println(71);
		} else if (a == 25 && b == 47) {
			System.out.println(72);
		} else if (a == 25 && b == 48) {
			System.out.println(73);
		} else if (a == 25 && b == 49) {
			System.out.println(74);
		} else if (a == 25 && b == 50) {
			System.out.println(75);
		} else if (a == 26 && b == 0) {
			System.out.println(26);
		} else if (a == 26 && b == 1) {
			System.out.println(27);
		} else if (a == 26 && b == 2) {
			System.out.println(28);
		} else if (a == 26 && b == 3) {
			System.out.println(29);
		} else if (a == 26 && b == 4) {
			System.out.println(30);
		} else if (a == 26 && b == 5) {
			System.out.println(31);
		} else if (a == 26 && b == 6) {
			System.out.println(32);
		} else if (a == 26 && b == 7) {
			System.out.println(33);
		} else if (a == 26 && b == 8) {
			System.out.println(34);
		} else if (a == 26 && b == 9) {
			System.out.println(35);
		} else if (a == 26 && b == 10) {
			System.out.println(36);
		} else if (a == 26 && b == 11) {
			System.out.println(37);
		} else if (a == 26 && b == 12) {
			System.out.println(38);
		} else if (a == 26 && b == 13) {
			System.out.println(39);
		} else if (a == 26 && b == 14) {
			System.out.println(40);
		} else if (a == 26 && b == 15) {
			System.out.println(41);
		} else if (a == 26 && b == 16) {
			System.out.println(42);
		} else if (a == 26 && b == 17) {
			System.out.println(43);
		} else if (a == 26 && b == 18) {
			System.out.println(44);
		} else if (a == 26 && b == 19) {
			System.out.println(45);
		} else if (a == 26 && b == 20) {
			System.out.println(46);
		} else if (a == 26 && b == 21) {
			System.out.println(47);
		} else if (a == 26 && b == 22) {
			System.out.println(48);
		} else if (a == 26 && b == 23) {
			System.out.println(49);
		} else if (a == 26 && b == 24) {
			System.out.println(50);
		} else if (a == 26 && b == 25) {
			System.out.println(51);
		} else if (a == 26 && b == 26) {
			System.out.println(52);
		} else if (a == 26 && b == 27) {
			System.out.println(53);
		} else if (a == 26 && b == 28) {
			System.out.println(54);
		} else if (a == 26 && b == 29) {
			System.out.println(55);
		} else if (a == 26 && b == 30) {
			System.out.println(56);
		} else if (a == 26 && b == 31) {
			System.out.println(57);
		} else if (a == 26 && b == 32) {
			System.out.println(58);
		} else if (a == 26 && b == 33) {
			System.out.println(59);
		} else if (a == 26 && b == 34) {
			System.out.println(60);
		} else if (a == 26 && b == 35) {
			System.out.println(61);
		} else if (a == 26 && b == 36) {
			System.out.println(62);
		} else if (a == 26 && b == 37) {
			System.out.println(63);
		} else if (a == 26 && b == 38) {
			System.out.println(64);
		} else if (a == 26 && b == 39) {
			System.out.println(65);
		} else if (a == 26 && b == 40) {
			System.out.println(66);
		} else if (a == 26 && b == 41) {
			System.out.println(67);
		} else if (a == 26 && b == 42) {
			System.out.println(68);
		} else if (a == 26 && b == 43) {
			System.out.println(69);
		} else if (a == 26 && b == 44) {
			System.out.println(70);
		} else if (a == 26 && b == 45) {
			System.out.println(71);
		} else if (a == 26 && b == 46) {
			System.out.println(72);
		} else if (a == 26 && b == 47) {
			System.out.println(73);
		} else if (a == 26 && b == 48) {
			System.out.println(74);
		} else if (a == 26 && b == 49) {
			System.out.println(75);
		} else if (a == 26 && b == 50) {
			System.out.println(76);
		} else if (a == 27 && b == 0) {
			System.out.println(27);
		} else if (a == 27 && b == 1) {
			System.out.println(28);
		} else if (a == 27 && b == 2) {
			System.out.println(29);
		} else if (a == 27 && b == 3) {
			System.out.println(30);
		} else if (a == 27 && b == 4) {
			System.out.println(31);
		} else if (a == 27 && b == 5) {
			System.out.println(32);
		} else if (a == 27 && b == 6) {
			System.out.println(33);
		} else if (a == 27 && b == 7) {
			System.out.println(34);
		} else if (a == 27 && b == 8) {
			System.out.println(35);
		} else if (a == 27 && b == 9) {
			System.out.println(36);
		} else if (a == 27 && b == 10) {
			System.out.println(37);
		} else if (a == 27 && b == 11) {
			System.out.println(38);
		} else if (a == 27 && b == 12) {
			System.out.println(39);
		} else if (a == 27 && b == 13) {
			System.out.println(40);
		} else if (a == 27 && b == 14) {
			System.out.println(41);
		} else if (a == 27 && b == 15) {
			System.out.println(42);
		} else if (a == 27 && b == 16) {
			System.out.println(43);
		} else if (a == 27 && b == 17) {
			System.out.println(44);
		} else if (a == 27 && b == 18) {
			System.out.println(45);
		} else if (a == 27 && b == 19) {
			System.out.println(46);
		} else if (a == 27 && b == 20) {
			System.out.println(47);
		} else if (a == 27 && b == 21) {
			System.out.println(48);
		} else if (a == 27 && b == 22) {
			System.out.println(49);
		} else if (a == 27 && b == 23) {
			System.out.println(50);
		} else if (a == 27 && b == 24) {
			System.out.println(51);
		} else if (a == 27 && b == 25) {
			System.out.println(52);
		} else if (a == 27 && b == 26) {
			System.out.println(53);
		} else if (a == 27 && b == 27) {
			System.out.println(54);
		} else if (a == 27 && b == 28) {
			System.out.println(55);
		} else if (a == 27 && b == 29) {
			System.out.println(56);
		} else if (a == 27 && b == 30) {
			System.out.println(57);
		} else if (a == 27 && b == 31) {
			System.out.println(58);
		} else if (a == 27 && b == 32) {
			System.out.println(59);
		} else if (a == 27 && b == 33) {
			System.out.println(60);
		} else if (a == 27 && b == 34) {
			System.out.println(61);
		} else if (a == 27 && b == 35) {
			System.out.println(62);
		} else if (a == 27 && b == 36) {
			System.out.println(63);
		} else if (a == 27 && b == 37) {
			System.out.println(64);
		} else if (a == 27 && b == 38) {
			System.out.println(65);
		} else if (a == 27 && b == 39) {
			System.out.println(66);
		} else if (a == 27 && b == 40) {
			System.out.println(67);
		} else if (a == 27 && b == 41) {
			System.out.println(68);
		} else if (a == 27 && b == 42) {
			System.out.println(69);
		} else if (a == 27 && b == 43) {
			System.out.println(70);
		} else if (a == 27 && b == 44) {
			System.out.println(71);
		} else if (a == 27 && b == 45) {
			System.out.println(72);
		} else if (a == 27 && b == 46) {
			System.out.println(73);
		} else if (a == 27 && b == 47) {
			System.out.println(74);
		} else if (a == 27 && b == 48) {
			System.out.println(75);
		} else if (a == 27 && b == 49) {
			System.out.println(76);
		} else if (a == 27 && b == 50) {
			System.out.println(77);
		} else if (a == 28 && b == 0) {
			System.out.println(28);
		} else if (a == 28 && b == 1) {
			System.out.println(29);
		} else if (a == 28 && b == 2) {
			System.out.println(30);
		} else if (a == 28 && b == 3) {
			System.out.println(31);
		} else if (a == 28 && b == 4) {
			System.out.println(32);
		} else if (a == 28 && b == 5) {
			System.out.println(33);
		} else if (a == 28 && b == 6) {
			System.out.println(34);
		} else if (a == 28 && b == 7) {
			System.out.println(35);
		} else if (a == 28 && b == 8) {
			System.out.println(36);
		} else if (a == 28 && b == 9) {
			System.out.println(37);
		} else if (a == 28 && b == 10) {
			System.out.println(38);
		} else if (a == 28 && b == 11) {
			System.out.println(39);
		} else if (a == 28 && b == 12) {
			System.out.println(40);
		} else if (a == 28 && b == 13) {
			System.out.println(41);
		} else if (a == 28 && b == 14) {
			System.out.println(42);
		} else if (a == 28 && b == 15) {
			System.out.println(43);
		} else if (a == 28 && b == 16) {
			System.out.println(44);
		} else if (a == 28 && b == 17) {
			System.out.println(45);
		} else if (a == 28 && b == 18) {
			System.out.println(46);
		} else if (a == 28 && b == 19) {
			System.out.println(47);
		} else if (a == 28 && b == 20) {
			System.out.println(48);
		} else if (a == 28 && b == 21) {
			System.out.println(49);
		} else if (a == 28 && b == 22) {
			System.out.println(50);
		} else if (a == 28 && b == 23) {
			System.out.println(51);
		} else if (a == 28 && b == 24) {
			System.out.println(52);
		} else if (a == 28 && b == 25) {
			System.out.println(53);
		} else if (a == 28 && b == 26) {
			System.out.println(54);
		} else if (a == 28 && b == 27) {
			System.out.println(55);
		} else if (a == 28 && b == 28) {
			System.out.println(56);
		} else if (a == 28 && b == 29) {
			System.out.println(57);
		} else if (a == 28 && b == 30) {
			System.out.println(58);
		} else if (a == 28 && b == 31) {
			System.out.println(59);
		} else if (a == 28 && b == 32) {
			System.out.println(60);
		} else if (a == 28 && b == 33) {
			System.out.println(61);
		} else if (a == 28 && b == 34) {
			System.out.println(62);
		} else if (a == 28 && b == 35) {
			System.out.println(63);
		} else if (a == 28 && b == 36) {
			System.out.println(64);
		} else if (a == 28 && b == 37) {
			System.out.println(65);
		} else if (a == 28 && b == 38) {
			System.out.println(66);
		} else if (a == 28 && b == 39) {
			System.out.println(67);
		} else if (a == 28 && b == 40) {
			System.out.println(68);
		} else if (a == 28 && b == 41) {
			System.out.println(69);
		} else if (a == 28 && b == 42) {
			System.out.println(70);
		} else if (a == 28 && b == 43) {
			System.out.println(71);
		} else if (a == 28 && b == 44) {
			System.out.println(72);
		} else if (a == 28 && b == 45) {
			System.out.println(73);
		} else if (a == 28 && b == 46) {
			System.out.println(74);
		} else if (a == 28 && b == 47) {
			System.out.println(75);
		} else if (a == 28 && b == 48) {
			System.out.println(76);
		} else if (a == 28 && b == 49) {
			System.out.println(77);
		} else if (a == 28 && b == 50) {
			System.out.println(78);
		} else if (a == 29 && b == 0) {
			System.out.println(29);
		} else if (a == 29 && b == 1) {
			System.out.println(30);
		} else if (a == 29 && b == 2) {
			System.out.println(31);
		} else if (a == 29 && b == 3) {
			System.out.println(32);
		} else if (a == 29 && b == 4) {
			System.out.println(33);
		} else if (a == 29 && b == 5) {
			System.out.println(34);
		} else if (a == 29 && b == 6) {
			System.out.println(35);
		} else if (a == 29 && b == 7) {
			System.out.println(36);
		} else if (a == 29 && b == 8) {
			System.out.println(37);
		} else if (a == 29 && b == 9) {
			System.out.println(38);
		} else if (a == 29 && b == 10) {
			System.out.println(39);
		} else if (a == 29 && b == 11) {
			System.out.println(40);
		} else if (a == 29 && b == 12) {
			System.out.println(41);
		} else if (a == 29 && b == 13) {
			System.out.println(42);
		} else if (a == 29 && b == 14) {
			System.out.println(43);
		} else if (a == 29 && b == 15) {
			System.out.println(44);
		} else if (a == 29 && b == 16) {
			System.out.println(45);
		} else if (a == 29 && b == 17) {
			System.out.println(46);
		} else if (a == 29 && b == 18) {
			System.out.println(47);
		} else if (a == 29 && b == 19) {
			System.out.println(48);
		} else if (a == 29 && b == 20) {
			System.out.println(49);
		} else if (a == 29 && b == 21) {
			System.out.println(50);
		} else if (a == 29 && b == 22) {
			System.out.println(51);
		} else if (a == 29 && b == 23) {
			System.out.println(52);
		} else if (a == 29 && b == 24) {
			System.out.println(53);
		} else if (a == 29 && b == 25) {
			System.out.println(54);
		} else if (a == 29 && b == 26) {
			System.out.println(55);
		} else if (a == 29 && b == 27) {
			System.out.println(56);
		} else if (a == 29 && b == 28) {
			System.out.println(57);
		} else if (a == 29 && b == 29) {
			System.out.println(58);
		} else if (a == 29 && b == 30) {
			System.out.println(59);
		} else if (a == 29 && b == 31) {
			System.out.println(60);
		} else if (a == 29 && b == 32) {
			System.out.println(61);
		} else if (a == 29 && b == 33) {
			System.out.println(62);
		} else if (a == 29 && b == 34) {
			System.out.println(63);
		} else if (a == 29 && b == 35) {
			System.out.println(64);
		} else if (a == 29 && b == 36) {
			System.out.println(65);
		} else if (a == 29 && b == 37) {
			System.out.println(66);
		} else if (a == 29 && b == 38) {
			System.out.println(67);
		} else if (a == 29 && b == 39) {
			System.out.println(68);
		} else if (a == 29 && b == 40) {
			System.out.println(69);
		} else if (a == 29 && b == 41) {
			System.out.println(70);
		} else if (a == 29 && b == 42) {
			System.out.println(71);
		} else if (a == 29 && b == 43) {
			System.out.println(72);
		} else if (a == 29 && b == 44) {
			System.out.println(73);
		} else if (a == 29 && b == 45) {
			System.out.println(74);
		} else if (a == 29 && b == 46) {
			System.out.println(75);
		} else if (a == 29 && b == 47) {
			System.out.println(76);
		} else if (a == 29 && b == 48) {
			System.out.println(77);
		} else if (a == 29 && b == 49) {
			System.out.println(78);
		} else if (a == 29 && b == 50) {
			System.out.println(79);
		} else if (a == 30 && b == 0) {
			System.out.println(30);
		} else if (a == 30 && b == 1) {
			System.out.println(31);
		} else if (a == 30 && b == 2) {
			System.out.println(32);
		} else if (a == 30 && b == 3) {
			System.out.println(33);
		} else if (a == 30 && b == 4) {
			System.out.println(34);
		} else if (a == 30 && b == 5) {
			System.out.println(35);
		} else if (a == 30 && b == 6) {
			System.out.println(36);
		} else if (a == 30 && b == 7) {
			System.out.println(37);
		} else if (a == 30 && b == 8) {
			System.out.println(38);
		} else if (a == 30 && b == 9) {
			System.out.println(39);
		} else if (a == 30 && b == 10) {
			System.out.println(40);
		} else if (a == 30 && b == 11) {
			System.out.println(41);
		} else if (a == 30 && b == 12) {
			System.out.println(42);
		} else if (a == 30 && b == 13) {
			System.out.println(43);
		} else if (a == 30 && b == 14) {
			System.out.println(44);
		} else if (a == 30 && b == 15) {
			System.out.println(45);
		} else if (a == 30 && b == 16) {
			System.out.println(46);
		} else if (a == 30 && b == 17) {
			System.out.println(47);
		} else if (a == 30 && b == 18) {
			System.out.println(48);
		} else if (a == 30 && b == 19) {
			System.out.println(49);
		} else if (a == 30 && b == 20) {
			System.out.println(50);
		} else if (a == 30 && b == 21) {
			System.out.println(51);
		} else if (a == 30 && b == 22) {
			System.out.println(52);
		} else if (a == 30 && b == 23) {
			System.out.println(53);
		} else if (a == 30 && b == 24) {
			System.out.println(54);
		} else if (a == 30 && b == 25) {
			System.out.println(55);
		} else if (a == 30 && b == 26) {
			System.out.println(56);
		} else if (a == 30 && b == 27) {
			System.out.println(57);
		} else if (a == 30 && b == 28) {
			System.out.println(58);
		} else if (a == 30 && b == 29) {
			System.out.println(59);
		} else if (a == 30 && b == 30) {
			System.out.println(60);
		} else if (a == 30 && b == 31) {
			System.out.println(61);
		} else if (a == 30 && b == 32) {
			System.out.println(62);
		} else if (a == 30 && b == 33) {
			System.out.println(63);
		} else if (a == 30 && b == 34) {
			System.out.println(64);
		} else if (a == 30 && b == 35) {
			System.out.println(65);
		} else if (a == 30 && b == 36) {
			System.out.println(66);
		} else if (a == 30 && b == 37) {
			System.out.println(67);
		} else if (a == 30 && b == 38) {
			System.out.println(68);
		} else if (a == 30 && b == 39) {
			System.out.println(69);
		} else if (a == 30 && b == 40) {
			System.out.println(70);
		} else if (a == 30 && b == 41) {
			System.out.println(71);
		} else if (a == 30 && b == 42) {
			System.out.println(72);
		} else if (a == 30 && b == 43) {
			System.out.println(73);
		} else if (a == 30 && b == 44) {
			System.out.println(74);
		} else if (a == 30 && b == 45) {
			System.out.println(75);
		} else if (a == 30 && b == 46) {
			System.out.println(76);
		} else if (a == 30 && b == 47) {
			System.out.println(77);
		} else if (a == 30 && b == 48) {
			System.out.println(78);
		} else if (a == 30 && b == 49) {
			System.out.println(79);
		} else if (a == 30 && b == 50) {
			System.out.println(80);
		} else if (a == 31 && b == 0) {
			System.out.println(31);
		} else if (a == 31 && b == 1) {
			System.out.println(32);
		} else if (a == 31 && b == 2) {
			System.out.println(33);
		} else if (a == 31 && b == 3) {
			System.out.println(34);
		} else if (a == 31 && b == 4) {
			System.out.println(35);
		} else if (a == 31 && b == 5) {
			System.out.println(36);
		} else if (a == 31 && b == 6) {
			System.out.println(37);
		} else if (a == 31 && b == 7) {
			System.out.println(38);
		} else if (a == 31 && b == 8) {
			System.out.println(39);
		} else if (a == 31 && b == 9) {
			System.out.println(40);
		} else if (a == 31 && b == 10) {
			System.out.println(41);
		} else if (a == 31 && b == 11) {
			System.out.println(42);
		} else if (a == 31 && b == 12) {
			System.out.println(43);
		} else if (a == 31 && b == 13) {
			System.out.println(44);
		} else if (a == 31 && b == 14) {
			System.out.println(45);
		} else if (a == 31 && b == 15) {
			System.out.println(46);
		} else if (a == 31 && b == 16) {
			System.out.println(47);
		} else if (a == 31 && b == 17) {
			System.out.println(48);
		} else if (a == 31 && b == 18) {
			System.out.println(49);
		} else if (a == 31 && b == 19) {
			System.out.println(50);
		} else if (a == 31 && b == 20) {
			System.out.println(51);
		} else if (a == 31 && b == 21) {
			System.out.println(52);
		} else if (a == 31 && b == 22) {
			System.out.println(53);
		} else if (a == 31 && b == 23) {
			System.out.println(54);
		} else if (a == 31 && b == 24) {
			System.out.println(55);
		} else if (a == 31 && b == 25) {
			System.out.println(56);
		} else if (a == 31 && b == 26) {
			System.out.println(57);
		} else if (a == 31 && b == 27) {
			System.out.println(58);
		} else if (a == 31 && b == 28) {
			System.out.println(59);
		} else if (a == 31 && b == 29) {
			System.out.println(60);
		} else if (a == 31 && b == 30) {
			System.out.println(61);
		} else if (a == 31 && b == 31) {
			System.out.println(62);
		} else if (a == 31 && b == 32) {
			System.out.println(63);
		} else if (a == 31 && b == 33) {
			System.out.println(64);
		} else if (a == 31 && b == 34) {
			System.out.println(65);
		} else if (a == 31 && b == 35) {
			System.out.println(66);
		} else if (a == 31 && b == 36) {
			System.out.println(67);
		} else if (a == 31 && b == 37) {
			System.out.println(68);
		} else if (a == 31 && b == 38) {
			System.out.println(69);
		} else if (a == 31 && b == 39) {
			System.out.println(70);
		} else if (a == 31 && b == 40) {
			System.out.println(71);
		} else if (a == 31 && b == 41) {
			System.out.println(72);
		} else if (a == 31 && b == 42) {
			System.out.println(73);
		} else if (a == 31 && b == 43) {
			System.out.println(74);
		} else if (a == 31 && b == 44) {
			System.out.println(75);
		} else if (a == 31 && b == 45) {
			System.out.println(76);
		} else if (a == 31 && b == 46) {
			System.out.println(77);
		} else if (a == 31 && b == 47) {
			System.out.println(78);
		} else if (a == 31 && b == 48) {
			System.out.println(79);
		} else if (a == 31 && b == 49) {
			System.out.println(80);
		} else if (a == 31 && b == 50) {
			System.out.println(81);
		} else if (a == 32 && b == 0) {
			System.out.println(32);
		} else if (a == 32 && b == 1) {
			System.out.println(33);
		} else if (a == 32 && b == 2) {
			System.out.println(34);
		} else if (a == 32 && b == 3) {
			System.out.println(35);
		} else if (a == 32 && b == 4) {
			System.out.println(36);
		} else if (a == 32 && b == 5) {
			System.out.println(37);
		} else if (a == 32 && b == 6) {
			System.out.println(38);
		} else if (a == 32 && b == 7) {
			System.out.println(39);
		} else if (a == 32 && b == 8) {
			System.out.println(40);
		} else if (a == 32 && b == 9) {
			System.out.println(41);
		} else if (a == 32 && b == 10) {
			System.out.println(42);
		} else if (a == 32 && b == 11) {
			System.out.println(43);
		} else if (a == 32 && b == 12) {
			System.out.println(44);
		} else if (a == 32 && b == 13) {
			System.out.println(45);
		} else if (a == 32 && b == 14) {
			System.out.println(46);
		} else if (a == 32 && b == 15) {
			System.out.println(47);
		} else if (a == 32 && b == 16) {
			System.out.println(48);
		} else if (a == 32 && b == 17) {
			System.out.println(49);
		} else if (a == 32 && b == 18) {
			System.out.println(50);
		} else if (a == 32 && b == 19) {
			System.out.println(51);
		} else if (a == 32 && b == 20) {
			System.out.println(52);
		} else if (a == 32 && b == 21) {
			System.out.println(53);
		} else if (a == 32 && b == 22) {
			System.out.println(54);
		} else if (a == 32 && b == 23) {
			System.out.println(55);
		} else if (a == 32 && b == 24) {
			System.out.println(56);
		} else if (a == 32 && b == 25) {
			System.out.println(57);
		} else if (a == 32 && b == 26) {
			System.out.println(58);
		} else if (a == 32 && b == 27) {
			System.out.println(59);
		} else if (a == 32 && b == 28) {
			System.out.println(60);
		} else if (a == 32 && b == 29) {
			System.out.println(61);
		} else if (a == 32 && b == 30) {
			System.out.println(62);
		} else if (a == 32 && b == 31) {
			System.out.println(63);
		} else if (a == 32 && b == 32) {
			System.out.println(64);
		} else if (a == 32 && b == 33) {
			System.out.println(65);
		} else if (a == 32 && b == 34) {
			System.out.println(66);
		} else if (a == 32 && b == 35) {
			System.out.println(67);
		} else if (a == 32 && b == 36) {
			System.out.println(68);
		} else if (a == 32 && b == 37) {
			System.out.println(69);
		} else if (a == 32 && b == 38) {
			System.out.println(70);
		} else if (a == 32 && b == 39) {
			System.out.println(71);
		} else if (a == 32 && b == 40) {
			System.out.println(72);
		} else if (a == 32 && b == 41) {
			System.out.println(73);
		} else if (a == 32 && b == 42) {
			System.out.println(74);
		} else if (a == 32 && b == 43) {
			System.out.println(75);
		} else if (a == 32 && b == 44) {
			System.out.println(76);
		} else if (a == 32 && b == 45) {
			System.out.println(77);
		} else if (a == 32 && b == 46) {
			System.out.println(78);
		} else if (a == 32 && b == 47) {
			System.out.println(79);
		} else if (a == 32 && b == 48) {
			System.out.println(80);
		} else if (a == 32 && b == 49) {
			System.out.println(81);
		} else if (a == 32 && b == 50) {
			System.out.println(82);
		} else if (a == 33 && b == 0) {
			System.out.println(33);
		} else if (a == 33 && b == 1) {
			System.out.println(34);
		} else if (a == 33 && b == 2) {
			System.out.println(35);
		} else if (a == 33 && b == 3) {
			System.out.println(36);
		} else if (a == 33 && b == 4) {
			System.out.println(37);
		} else if (a == 33 && b == 5) {
			System.out.println(38);
		} else if (a == 33 && b == 6) {
			System.out.println(39);
		} else if (a == 33 && b == 7) {
			System.out.println(40);
		} else if (a == 33 && b == 8) {
			System.out.println(41);
		} else if (a == 33 && b == 9) {
			System.out.println(42);
		} else if (a == 33 && b == 10) {
			System.out.println(43);
		} else if (a == 33 && b == 11) {
			System.out.println(44);
		} else if (a == 33 && b == 12) {
			System.out.println(45);
		} else if (a == 33 && b == 13) {
			System.out.println(46);
		} else if (a == 33 && b == 14) {
			System.out.println(47);
		} else if (a == 33 && b == 15) {
			System.out.println(48);
		} else if (a == 33 && b == 16) {
			System.out.println(49);
		} else if (a == 33 && b == 17) {
			System.out.println(50);
		} else if (a == 33 && b == 18) {
			System.out.println(51);
		} else if (a == 33 && b == 19) {
			System.out.println(52);
		} else if (a == 33 && b == 20) {
			System.out.println(53);
		} else if (a == 33 && b == 21) {
			System.out.println(54);
		} else if (a == 33 && b == 22) {
			System.out.println(55);
		} else if (a == 33 && b == 23) {
			System.out.println(56);
		} else if (a == 33 && b == 24) {
			System.out.println(57);
		} else if (a == 33 && b == 25) {
			System.out.println(58);
		} else if (a == 33 && b == 26) {
			System.out.println(59);
		} else if (a == 33 && b == 27) {
			System.out.println(60);
		} else if (a == 33 && b == 28) {
			System.out.println(61);
		} else if (a == 33 && b == 29) {
			System.out.println(62);
		} else if (a == 33 && b == 30) {
			System.out.println(63);
		} else if (a == 33 && b == 31) {
			System.out.println(64);
		} else if (a == 33 && b == 32) {
			System.out.println(65);
		} else if (a == 33 && b == 33) {
			System.out.println(66);
		} else if (a == 33 && b == 34) {
			System.out.println(67);
		} else if (a == 33 && b == 35) {
			System.out.println(68);
		} else if (a == 33 && b == 36) {
			System.out.println(69);
		} else if (a == 33 && b == 37) {
			System.out.println(70);
		} else if (a == 33 && b == 38) {
			System.out.println(71);
		} else if (a == 33 && b == 39) {
			System.out.println(72);
		} else if (a == 33 && b == 40) {
			System.out.println(73);
		} else if (a == 33 && b == 41) {
			System.out.println(74);
		} else if (a == 33 && b == 42) {
			System.out.println(75);
		} else if (a == 33 && b == 43) {
			System.out.println(76);
		} else if (a == 33 && b == 44) {
			System.out.println(77);
		} else if (a == 33 && b == 45) {
			System.out.println(78);
		} else if (a == 33 && b == 46) {
			System.out.println(79);
		} else if (a == 33 && b == 47) {
			System.out.println(80);
		} else if (a == 33 && b == 48) {
			System.out.println(81);
		} else if (a == 33 && b == 49) {
			System.out.println(82);
		} else if (a == 33 && b == 50) {
			System.out.println(83);
		} else if (a == 34 && b == 0) {
			System.out.println(34);
		} else if (a == 34 && b == 1) {
			System.out.println(35);
		} else if (a == 34 && b == 2) {
			System.out.println(36);
		} else if (a == 34 && b == 3) {
			System.out.println(37);
		} else if (a == 34 && b == 4) {
			System.out.println(38);
		} else if (a == 34 && b == 5) {
			System.out.println(39);
		} else if (a == 34 && b == 6) {
			System.out.println(40);
		} else if (a == 34 && b == 7) {
			System.out.println(41);
		} else if (a == 34 && b == 8) {
			System.out.println(42);
		} else if (a == 34 && b == 9) {
			System.out.println(43);
		} else if (a == 34 && b == 10) {
			System.out.println(44);
		} else if (a == 34 && b == 11) {
			System.out.println(45);
		} else if (a == 34 && b == 12) {
			System.out.println(46);
		} else if (a == 34 && b == 13) {
			System.out.println(47);
		} else if (a == 34 && b == 14) {
			System.out.println(48);
		} else if (a == 34 && b == 15) {
			System.out.println(49);
		} else if (a == 34 && b == 16) {
			System.out.println(50);
		} else if (a == 34 && b == 17) {
			System.out.println(51);
		} else if (a == 34 && b == 18) {
			System.out.println(52);
		} else if (a == 34 && b == 19) {
			System.out.println(53);
		} else if (a == 34 && b == 20) {
			System.out.println(54);
		} else if (a == 34 && b == 21) {
			System.out.println(55);
		} else if (a == 34 && b == 22) {
			System.out.println(56);
		} else if (a == 34 && b == 23) {
			System.out.println(57);
		} else if (a == 34 && b == 24) {
			System.out.println(58);
		} else if (a == 34 && b == 25) {
			System.out.println(59);
		} else if (a == 34 && b == 26) {
			System.out.println(60);
		} else if (a == 34 && b == 27) {
			System.out.println(61);
		} else if (a == 34 && b == 28) {
			System.out.println(62);
		} else if (a == 34 && b == 29) {
			System.out.println(63);
		} else if (a == 34 && b == 30) {
			System.out.println(64);
		} else if (a == 34 && b == 31) {
			System.out.println(65);
		} else if (a == 34 && b == 32) {
			System.out.println(66);
		} else if (a == 34 && b == 33) {
			System.out.println(67);
		} else if (a == 34 && b == 34) {
			System.out.println(68);
		} else if (a == 34 && b == 35) {
			System.out.println(69);
		} else if (a == 34 && b == 36) {
			System.out.println(70);
		} else if (a == 34 && b == 37) {
			System.out.println(71);
		} else if (a == 34 && b == 38) {
			System.out.println(72);
		} else if (a == 34 && b == 39) {
			System.out.println(73);
		} else if (a == 34 && b == 40) {
			System.out.println(74);
		} else if (a == 34 && b == 41) {
			System.out.println(75);
		} else if (a == 34 && b == 42) {
			System.out.println(76);
		} else if (a == 34 && b == 43) {
			System.out.println(77);
		} else if (a == 34 && b == 44) {
			System.out.println(78);
		} else if (a == 34 && b == 45) {
			System.out.println(79);
		} else if (a == 34 && b == 46) {
			System.out.println(80);
		} else if (a == 34 && b == 47) {
			System.out.println(81);
		} else if (a == 34 && b == 48) {
			System.out.println(82);
		} else if (a == 34 && b == 49) {
			System.out.println(83);
		} else if (a == 34 && b == 50) {
			System.out.println(84);
		} else if (a == 35 && b == 0) {
			System.out.println(35);
		} else if (a == 35 && b == 1) {
			System.out.println(36);
		} else if (a == 35 && b == 2) {
			System.out.println(37);
		} else if (a == 35 && b == 3) {
			System.out.println(38);
		} else if (a == 35 && b == 4) {
			System.out.println(39);
		} else if (a == 35 && b == 5) {
			System.out.println(40);
		} else if (a == 35 && b == 6) {
			System.out.println(41);
		} else if (a == 35 && b == 7) {
			System.out.println(42);
		} else if (a == 35 && b == 8) {
			System.out.println(43);
		} else if (a == 35 && b == 9) {
			System.out.println(44);
		} else if (a == 35 && b == 10) {
			System.out.println(45);
		} else if (a == 35 && b == 11) {
			System.out.println(46);
		} else if (a == 35 && b == 12) {
			System.out.println(47);
		} else if (a == 35 && b == 13) {
			System.out.println(48);
		} else if (a == 35 && b == 14) {
			System.out.println(49);
		} else if (a == 35 && b == 15) {
			System.out.println(50);
		} else if (a == 35 && b == 16) {
			System.out.println(51);
		} else if (a == 35 && b == 17) {
			System.out.println(52);
		} else if (a == 35 && b == 18) {
			System.out.println(53);
		} else if (a == 35 && b == 19) {
			System.out.println(54);
		} else if (a == 35 && b == 20) {
			System.out.println(55);
		} else if (a == 35 && b == 21) {
			System.out.println(56);
		} else if (a == 35 && b == 22) {
			System.out.println(57);
		} else if (a == 35 && b == 23) {
			System.out.println(58);
		} else if (a == 35 && b == 24) {
			System.out.println(59);
		} else if (a == 35 && b == 25) {
			System.out.println(60);
		} else if (a == 35 && b == 26) {
			System.out.println(61);
		} else if (a == 35 && b == 27) {
			System.out.println(62);
		} else if (a == 35 && b == 28) {
			System.out.println(63);
		} else if (a == 35 && b == 29) {
			System.out.println(64);
		} else if (a == 35 && b == 30) {
			System.out.println(65);
		} else if (a == 35 && b == 31) {
			System.out.println(66);
		} else if (a == 35 && b == 32) {
			System.out.println(67);
		} else if (a == 35 && b == 33) {
			System.out.println(68);
		} else if (a == 35 && b == 34) {
			System.out.println(69);
		} else if (a == 35 && b == 35) {
			System.out.println(70);
		} else if (a == 35 && b == 36) {
			System.out.println(71);
		} else if (a == 35 && b == 37) {
			System.out.println(72);
		} else if (a == 35 && b == 38) {
			System.out.println(73);
		} else if (a == 35 && b == 39) {
			System.out.println(74);
		} else if (a == 35 && b == 40) {
			System.out.println(75);
		} else if (a == 35 && b == 41) {
			System.out.println(76);
		} else if (a == 35 && b == 42) {
			System.out.println(77);
		} else if (a == 35 && b == 43) {
			System.out.println(78);
		} else if (a == 35 && b == 44) {
			System.out.println(79);
		} else if (a == 35 && b == 45) {
			System.out.println(80);
		} else if (a == 35 && b == 46) {
			System.out.println(81);
		} else if (a == 35 && b == 47) {
			System.out.println(82);
		} else if (a == 35 && b == 48) {
			System.out.println(83);
		} else if (a == 35 && b == 49) {
			System.out.println(84);
		} else if (a == 35 && b == 50) {
			System.out.println(85);
		} else if (a == 36 && b == 0) {
			System.out.println(36);
		} else if (a == 36 && b == 1) {
			System.out.println(37);
		} else if (a == 36 && b == 2) {
			System.out.println(38);
		} else if (a == 36 && b == 3) {
			System.out.println(39);
		} else if (a == 36 && b == 4) {
			System.out.println(40);
		} else if (a == 36 && b == 5) {
			System.out.println(41);
		} else if (a == 36 && b == 6) {
			System.out.println(42);
		} else if (a == 36 && b == 7) {
			System.out.println(43);
		} else if (a == 36 && b == 8) {
			System.out.println(44);
		} else if (a == 36 && b == 9) {
			System.out.println(45);
		} else if (a == 36 && b == 10) {
			System.out.println(46);
		} else if (a == 36 && b == 11) {
			System.out.println(47);
		} else if (a == 36 && b == 12) {
			System.out.println(48);
		} else if (a == 36 && b == 13) {
			System.out.println(49);
		} else if (a == 36 && b == 14) {
			System.out.println(50);
		} else if (a == 36 && b == 15) {
			System.out.println(51);
		} else if (a == 36 && b == 16) {
			System.out.println(52);
		} else if (a == 36 && b == 17) {
			System.out.println(53);
		} else if (a == 36 && b == 18) {
			System.out.println(54);
		} else if (a == 36 && b == 19) {
			System.out.println(55);
		} else if (a == 36 && b == 20) {
			System.out.println(56);
		} else if (a == 36 && b == 21) {
			System.out.println(57);
		} else if (a == 36 && b == 22) {
			System.out.println(58);
		} else if (a == 36 && b == 23) {
			System.out.println(59);
		} else if (a == 36 && b == 24) {
			System.out.println(60);
		} else if (a == 36 && b == 25) {
			System.out.println(61);
		} else if (a == 36 && b == 26) {
			System.out.println(62);
		} else if (a == 36 && b == 27) {
			System.out.println(63);
		} else if (a == 36 && b == 28) {
			System.out.println(64);
		} else if (a == 36 && b == 29) {
			System.out.println(65);
		} else if (a == 36 && b == 30) {
			System.out.println(66);
		} else if (a == 36 && b == 31) {
			System.out.println(67);
		} else if (a == 36 && b == 32) {
			System.out.println(68);
		} else if (a == 36 && b == 33) {
			System.out.println(69);
		} else if (a == 36 && b == 34) {
			System.out.println(70);
		} else if (a == 36 && b == 35) {
			System.out.println(71);
		} else if (a == 36 && b == 36) {
			System.out.println(72);
		} else if (a == 36 && b == 37) {
			System.out.println(73);
		} else if (a == 36 && b == 38) {
			System.out.println(74);
		} else if (a == 36 && b == 39) {
			System.out.println(75);
		} else if (a == 36 && b == 40) {
			System.out.println(76);
		} else if (a == 36 && b == 41) {
			System.out.println(77);
		} else if (a == 36 && b == 42) {
			System.out.println(78);
		} else if (a == 36 && b == 43) {
			System.out.println(79);
		} else if (a == 36 && b == 44) {
			System.out.println(80);
		} else if (a == 36 && b == 45) {
			System.out.println(81);
		} else if (a == 36 && b == 46) {
			System.out.println(82);
		} else if (a == 36 && b == 47) {
			System.out.println(83);
		} else if (a == 36 && b == 48) {
			System.out.println(84);
		} else if (a == 36 && b == 49) {
			System.out.println(85);
		} else if (a == 36 && b == 50) {
			System.out.println(86);
		} else if (a == 37 && b == 0) {
			System.out.println(37);
		} else if (a == 37 && b == 1) {
			System.out.println(38);
		} else if (a == 37 && b == 2) {
			System.out.println(39);
		} else if (a == 37 && b == 3) {
			System.out.println(40);
		} else if (a == 37 && b == 4) {
			System.out.println(41);
		} else if (a == 37 && b == 5) {
			System.out.println(42);
		} else if (a == 37 && b == 6) {
			System.out.println(43);
		} else if (a == 37 && b == 7) {
			System.out.println(44);
		} else if (a == 37 && b == 8) {
			System.out.println(45);
		} else if (a == 37 && b == 9) {
			System.out.println(46);
		} else if (a == 37 && b == 10) {
			System.out.println(47);
		} else if (a == 37 && b == 11) {
			System.out.println(48);
		} else if (a == 37 && b == 12) {
			System.out.println(49);
		} else if (a == 37 && b == 13) {
			System.out.println(50);
		} else if (a == 37 && b == 14) {
			System.out.println(51);
		} else if (a == 37 && b == 15) {
			System.out.println(52);
		} else if (a == 37 && b == 16) {
			System.out.println(53);
		} else if (a == 37 && b == 17) {
			System.out.println(54);
		} else if (a == 37 && b == 18) {
			System.out.println(55);
		} else if (a == 37 && b == 19) {
			System.out.println(56);
		} else if (a == 37 && b == 20) {
			System.out.println(57);
		} else if (a == 37 && b == 21) {
			System.out.println(58);
		} else if (a == 37 && b == 22) {
			System.out.println(59);
		} else if (a == 37 && b == 23) {
			System.out.println(60);
		} else if (a == 37 && b == 24) {
			System.out.println(61);
		} else if (a == 37 && b == 25) {
			System.out.println(62);
		} else if (a == 37 && b == 26) {
			System.out.println(63);
		} else if (a == 37 && b == 27) {
			System.out.println(64);
		} else if (a == 37 && b == 28) {
			System.out.println(65);
		} else if (a == 37 && b == 29) {
			System.out.println(66);
		} else if (a == 37 && b == 30) {
			System.out.println(67);
		} else if (a == 37 && b == 31) {
			System.out.println(68);
		} else if (a == 37 && b == 32) {
			System.out.println(69);
		} else if (a == 37 && b == 33) {
			System.out.println(70);
		} else if (a == 37 && b == 34) {
			System.out.println(71);
		} else if (a == 37 && b == 35) {
			System.out.println(72);
		} else if (a == 37 && b == 36) {
			System.out.println(73);
		} else if (a == 37 && b == 37) {
			System.out.println(74);
		} else if (a == 37 && b == 38) {
			System.out.println(75);
		} else if (a == 37 && b == 39) {
			System.out.println(76);
		} else if (a == 37 && b == 40) {
			System.out.println(77);
		} else if (a == 37 && b == 41) {
			System.out.println(78);
		} else if (a == 37 && b == 42) {
			System.out.println(79);
		} else if (a == 37 && b == 43) {
			System.out.println(80);
		} else if (a == 37 && b == 44) {
			System.out.println(81);
		} else if (a == 37 && b == 45) {
			System.out.println(82);
		} else if (a == 37 && b == 46) {
			System.out.println(83);
		} else if (a == 37 && b == 47) {
			System.out.println(84);
		} else if (a == 37 && b == 48) {
			System.out.println(85);
		} else if (a == 37 && b == 49) {
			System.out.println(86);
		} else if (a == 37 && b == 50) {
			System.out.println(87);
		} else if (a == 38 && b == 0) {
			System.out.println(38);
		} else if (a == 38 && b == 1) {
			System.out.println(39);
		} else if (a == 38 && b == 2) {
			System.out.println(40);
		} else if (a == 38 && b == 3) {
			System.out.println(41);
		} else if (a == 38 && b == 4) {
			System.out.println(42);
		} else if (a == 38 && b == 5) {
			System.out.println(43);
		} else if (a == 38 && b == 6) {
			System.out.println(44);
		} else if (a == 38 && b == 7) {
			System.out.println(45);
		} else if (a == 38 && b == 8) {
			System.out.println(46);
		} else if (a == 38 && b == 9) {
			System.out.println(47);
		} else if (a == 38 && b == 10) {
			System.out.println(48);
		} else if (a == 38 && b == 11) {
			System.out.println(49);
		} else if (a == 38 && b == 12) {
			System.out.println(50);
		} else if (a == 38 && b == 13) {
			System.out.println(51);
		} else if (a == 38 && b == 14) {
			System.out.println(52);
		} else if (a == 38 && b == 15) {
			System.out.println(53);
		} else if (a == 38 && b == 16) {
			System.out.println(54);
		} else if (a == 38 && b == 17) {
			System.out.println(55);
		} else if (a == 38 && b == 18) {
			System.out.println(56);
		} else if (a == 38 && b == 19) {
			System.out.println(57);
		} else if (a == 38 && b == 20) {
			System.out.println(58);
		} else if (a == 38 && b == 21) {
			System.out.println(59);
		} else if (a == 38 && b == 22) {
			System.out.println(60);
		} else if (a == 38 && b == 23) {
			System.out.println(61);
		} else if (a == 38 && b == 24) {
			System.out.println(62);
		} else if (a == 38 && b == 25) {
			System.out.println(63);
		} else if (a == 38 && b == 26) {
			System.out.println(64);
		} else if (a == 38 && b == 27) {
			System.out.println(65);
		} else if (a == 38 && b == 28) {
			System.out.println(66);
		} else if (a == 38 && b == 29) {
			System.out.println(67);
		} else if (a == 38 && b == 30) {
			System.out.println(68);
		} else if (a == 38 && b == 31) {
			System.out.println(69);
		} else if (a == 38 && b == 32) {
			System.out.println(70);
		} else if (a == 38 && b == 33) {
			System.out.println(71);
		} else if (a == 38 && b == 34) {
			System.out.println(72);
		} else if (a == 38 && b == 35) {
			System.out.println(73);
		} else if (a == 38 && b == 36) {
			System.out.println(74);
		} else if (a == 38 && b == 37) {
			System.out.println(75);
		} else if (a == 38 && b == 38) {
			System.out.println(76);
		} else if (a == 38 && b == 39) {
			System.out.println(77);
		} else if (a == 38 && b == 40) {
			System.out.println(78);
		} else if (a == 38 && b == 41) {
			System.out.println(79);
		} else if (a == 38 && b == 42) {
			System.out.println(80);
		} else if (a == 38 && b == 43) {
			System.out.println(81);
		} else if (a == 38 && b == 44) {
			System.out.println(82);
		} else if (a == 38 && b == 45) {
			System.out.println(83);
		} else if (a == 38 && b == 46) {
			System.out.println(84);
		} else if (a == 38 && b == 47) {
			System.out.println(85);
		} else if (a == 38 && b == 48) {
			System.out.println(86);
		} else if (a == 38 && b == 49) {
			System.out.println(87);
		} else if (a == 38 && b == 50) {
			System.out.println(88);
		} else if (a == 39 && b == 0) {
			System.out.println(39);
		} else if (a == 39 && b == 1) {
			System.out.println(40);
		} else if (a == 39 && b == 2) {
			System.out.println(41);
		} else if (a == 39 && b == 3) {
			System.out.println(42);
		} else if (a == 39 && b == 4) {
			System.out.println(43);
		} else if (a == 39 && b == 5) {
			System.out.println(44);
		} else if (a == 39 && b == 6) {
			System.out.println(45);
		} else if (a == 39 && b == 7) {
			System.out.println(46);
		} else if (a == 39 && b == 8) {
			System.out.println(47);
		} else if (a == 39 && b == 9) {
			System.out.println(48);
		} else if (a == 39 && b == 10) {
			System.out.println(49);
		} else if (a == 39 && b == 11) {
			System.out.println(50);
		} else if (a == 39 && b == 12) {
			System.out.println(51);
		} else if (a == 39 && b == 13) {
			System.out.println(52);
		} else if (a == 39 && b == 14) {
			System.out.println(53);
		} else if (a == 39 && b == 15) {
			System.out.println(54);
		} else if (a == 39 && b == 16) {
			System.out.println(55);
		} else if (a == 39 && b == 17) {
			System.out.println(56);
		} else if (a == 39 && b == 18) {
			System.out.println(57);
		} else if (a == 39 && b == 19) {
			System.out.println(58);
		} else if (a == 39 && b == 20) {
			System.out.println(59);
		} else if (a == 39 && b == 21) {
			System.out.println(60);
		} else if (a == 39 && b == 22) {
			System.out.println(61);
		} else if (a == 39 && b == 23) {
			System.out.println(62);
		} else if (a == 39 && b == 24) {
			System.out.println(63);
		} else if (a == 39 && b == 25) {
			System.out.println(64);
		} else if (a == 39 && b == 26) {
			System.out.println(65);
		} else if (a == 39 && b == 27) {
			System.out.println(66);
		} else if (a == 39 && b == 28) {
			System.out.println(67);
		} else if (a == 39 && b == 29) {
			System.out.println(68);
		} else if (a == 39 && b == 30) {
			System.out.println(69);
		} else if (a == 39 && b == 31) {
			System.out.println(70);
		} else if (a == 39 && b == 32) {
			System.out.println(71);
		} else if (a == 39 && b == 33) {
			System.out.println(72);
		} else if (a == 39 && b == 34) {
			System.out.println(73);
		} else if (a == 39 && b == 35) {
			System.out.println(74);
		} else if (a == 39 && b == 36) {
			System.out.println(75);
		} else if (a == 39 && b == 37) {
			System.out.println(76);
		} else if (a == 39 && b == 38) {
			System.out.println(77);
		} else if (a == 39 && b == 39) {
			System.out.println(78);
		} else if (a == 39 && b == 40) {
			System.out.println(79);
		} else if (a == 39 && b == 41) {
			System.out.println(80);
		} else if (a == 39 && b == 42) {
			System.out.println(81);
		} else if (a == 39 && b == 43) {
			System.out.println(82);
		} else if (a == 39 && b == 44) {
			System.out.println(83);
		} else if (a == 39 && b == 45) {
			System.out.println(84);
		} else if (a == 39 && b == 46) {
			System.out.println(85);
		} else if (a == 39 && b == 47) {
			System.out.println(86);
		} else if (a == 39 && b == 48) {
			System.out.println(87);
		} else if (a == 39 && b == 49) {
			System.out.println(88);
		} else if (a == 39 && b == 50) {
			System.out.println(89);
		} else if (a == 40 && b == 0) {
			System.out.println(40);
		} else if (a == 40 && b == 1) {
			System.out.println(41);
		} else if (a == 40 && b == 2) {
			System.out.println(42);
		} else if (a == 40 && b == 3) {
			System.out.println(43);
		} else if (a == 40 && b == 4) {
			System.out.println(44);
		} else if (a == 40 && b == 5) {
			System.out.println(45);
		} else if (a == 40 && b == 6) {
			System.out.println(46);
		} else if (a == 40 && b == 7) {
			System.out.println(47);
		} else if (a == 40 && b == 8) {
			System.out.println(48);
		} else if (a == 40 && b == 9) {
			System.out.println(49);
		} else if (a == 40 && b == 10) {
			System.out.println(50);
		} else if (a == 40 && b == 11) {
			System.out.println(51);
		} else if (a == 40 && b == 12) {
			System.out.println(52);
		} else if (a == 40 && b == 13) {
			System.out.println(53);
		} else if (a == 40 && b == 14) {
			System.out.println(54);
		} else if (a == 40 && b == 15) {
			System.out.println(55);
		} else if (a == 40 && b == 16) {
			System.out.println(56);
		} else if (a == 40 && b == 17) {
			System.out.println(57);
		} else if (a == 40 && b == 18) {
			System.out.println(58);
		} else if (a == 40 && b == 19) {
			System.out.println(59);
		} else if (a == 40 && b == 20) {
			System.out.println(60);
		} else if (a == 40 && b == 21) {
			System.out.println(61);
		} else if (a == 40 && b == 22) {
			System.out.println(62);
		} else if (a == 40 && b == 23) {
			System.out.println(63);
		} else if (a == 40 && b == 24) {
			System.out.println(64);
		} else if (a == 40 && b == 25) {
			System.out.println(65);
		} else if (a == 40 && b == 26) {
			System.out.println(66);
		} else if (a == 40 && b == 27) {
			System.out.println(67);
		} else if (a == 40 && b == 28) {
			System.out.println(68);
		} else if (a == 40 && b == 29) {
			System.out.println(69);
		} else if (a == 40 && b == 30) {
			System.out.println(70);
		} else if (a == 40 && b == 31) {
			System.out.println(71);
		} else if (a == 40 && b == 32) {
			System.out.println(72);
		} else if (a == 40 && b == 33) {
			System.out.println(73);
		} else if (a == 40 && b == 34) {
			System.out.println(74);
		} else if (a == 40 && b == 35) {
			System.out.println(75);
		} else if (a == 40 && b == 36) {
			System.out.println(76);
		} else if (a == 40 && b == 37) {
			System.out.println(77);
		} else if (a == 40 && b == 38) {
			System.out.println(78);
		} else if (a == 40 && b == 39) {
			System.out.println(79);
		} else if (a == 40 && b == 40) {
			System.out.println(80);
		} else if (a == 40 && b == 41) {
			System.out.println(81);
		} else if (a == 40 && b == 42) {
			System.out.println(82);
		} else if (a == 40 && b == 43) {
			System.out.println(83);
		} else if (a == 40 && b == 44) {
			System.out.println(84);
		} else if (a == 40 && b == 45) {
			System.out.println(85);
		} else if (a == 40 && b == 46) {
			System.out.println(86);
		} else if (a == 40 && b == 47) {
			System.out.println(87);
		} else if (a == 40 && b == 48) {
			System.out.println(88);
		} else if (a == 40 && b == 49) {
			System.out.println(89);
		} else if (a == 40 && b == 50) {
			System.out.println(90);
		} else if (a == 41 && b == 0) {
			System.out.println(41);
		} else if (a == 41 && b == 1) {
			System.out.println(42);
		} else if (a == 41 && b == 2) {
			System.out.println(43);
		} else if (a == 41 && b == 3) {
			System.out.println(44);
		} else if (a == 41 && b == 4) {
			System.out.println(45);
		} else if (a == 41 && b == 5) {
			System.out.println(46);
		} else if (a == 41 && b == 6) {
			System.out.println(47);
		} else if (a == 41 && b == 7) {
			System.out.println(48);
		} else if (a == 41 && b == 8) {
			System.out.println(49);
		} else if (a == 41 && b == 9) {
			System.out.println(50);
		} else if (a == 41 && b == 10) {
			System.out.println(51);
		} else if (a == 41 && b == 11) {
			System.out.println(52);
		} else if (a == 41 && b == 12) {
			System.out.println(53);
		} else if (a == 41 && b == 13) {
			System.out.println(54);
		} else if (a == 41 && b == 14) {
			System.out.println(55);
		} else if (a == 41 && b == 15) {
			System.out.println(56);
		} else if (a == 41 && b == 16) {
			System.out.println(57);
		} else if (a == 41 && b == 17) {
			System.out.println(58);
		} else if (a == 41 && b == 18) {
			System.out.println(59);
		} else if (a == 41 && b == 19) {
			System.out.println(60);
		} else if (a == 41 && b == 20) {
			System.out.println(61);
		} else if (a == 41 && b == 21) {
			System.out.println(62);
		} else if (a == 41 && b == 22) {
			System.out.println(63);
		} else if (a == 41 && b == 23) {
			System.out.println(64);
		} else if (a == 41 && b == 24) {
			System.out.println(65);
		} else if (a == 41 && b == 25) {
			System.out.println(66);
		} else if (a == 41 && b == 26) {
			System.out.println(67);
		} else if (a == 41 && b == 27) {
			System.out.println(68);
		} else if (a == 41 && b == 28) {
			System.out.println(69);
		} else if (a == 41 && b == 29) {
			System.out.println(70);
		} else if (a == 41 && b == 30) {
			System.out.println(71);
		} else if (a == 41 && b == 31) {
			System.out.println(72);
		} else if (a == 41 && b == 32) {
			System.out.println(73);
		} else if (a == 41 && b == 33) {
			System.out.println(74);
		} else if (a == 41 && b == 34) {
			System.out.println(75);
		} else if (a == 41 && b == 35) {
			System.out.println(76);
		} else if (a == 41 && b == 36) {
			System.out.println(77);
		} else if (a == 41 && b == 37) {
			System.out.println(78);
		} else if (a == 41 && b == 38) {
			System.out.println(79);
		} else if (a == 41 && b == 39) {
			System.out.println(80);
		} else if (a == 41 && b == 40) {
			System.out.println(81);
		} else if (a == 41 && b == 41) {
			System.out.println(82);
		} else if (a == 41 && b == 42) {
			System.out.println(83);
		} else if (a == 41 && b == 43) {
			System.out.println(84);
		} else if (a == 41 && b == 44) {
			System.out.println(85);
		} else if (a == 41 && b == 45) {
			System.out.println(86);
		} else if (a == 41 && b == 46) {
			System.out.println(87);
		} else if (a == 41 && b == 47) {
			System.out.println(88);
		} else if (a == 41 && b == 48) {
			System.out.println(89);
		} else if (a == 41 && b == 49) {
			System.out.println(90);
		} else if (a == 41 && b == 50) {
			System.out.println(91);
		} else if (a == 42 && b == 0) {
			System.out.println(42);
		} else if (a == 42 && b == 1) {
			System.out.println(43);
		} else if (a == 42 && b == 2) {
			System.out.println(44);
		} else if (a == 42 && b == 3) {
			System.out.println(45);
		} else if (a == 42 && b == 4) {
			System.out.println(46);
		} else if (a == 42 && b == 5) {
			System.out.println(47);
		} else if (a == 42 && b == 6) {
			System.out.println(48);
		} else if (a == 42 && b == 7) {
			System.out.println(49);
		} else if (a == 42 && b == 8) {
			System.out.println(50);
		} else if (a == 42 && b == 9) {
			System.out.println(51);
		} else if (a == 42 && b == 10) {
			System.out.println(52);
		} else if (a == 42 && b == 11) {
			System.out.println(53);
		} else if (a == 42 && b == 12) {
			System.out.println(54);
		} else if (a == 42 && b == 13) {
			System.out.println(55);
		} else if (a == 42 && b == 14) {
			System.out.println(56);
		} else if (a == 42 && b == 15) {
			System.out.println(57);
		} else if (a == 42 && b == 16) {
			System.out.println(58);
		} else if (a == 42 && b == 17) {
			System.out.println(59);
		} else if (a == 42 && b == 18) {
			System.out.println(60);
		} else if (a == 42 && b == 19) {
			System.out.println(61);
		} else if (a == 42 && b == 20) {
			System.out.println(62);
		} else if (a == 42 && b == 21) {
			System.out.println(63);
		} else if (a == 42 && b == 22) {
			System.out.println(64);
		} else if (a == 42 && b == 23) {
			System.out.println(65);
		} else if (a == 42 && b == 24) {
			System.out.println(66);
		} else if (a == 42 && b == 25) {
			System.out.println(67);
		} else if (a == 42 && b == 26) {
			System.out.println(68);
		} else if (a == 42 && b == 27) {
			System.out.println(69);
		} else if (a == 42 && b == 28) {
			System.out.println(70);
		} else if (a == 42 && b == 29) {
			System.out.println(71);
		} else if (a == 42 && b == 30) {
			System.out.println(72);
		} else if (a == 42 && b == 31) {
			System.out.println(73);
		} else if (a == 42 && b == 32) {
			System.out.println(74);
		} else if (a == 42 && b == 33) {
			System.out.println(75);
		} else if (a == 42 && b == 34) {
			System.out.println(76);
		} else if (a == 42 && b == 35) {
			System.out.println(77);
		} else if (a == 42 && b == 36) {
			System.out.println(78);
		} else if (a == 42 && b == 37) {
			System.out.println(79);
		} else if (a == 42 && b == 38) {
			System.out.println(80);
		} else if (a == 42 && b == 39) {
			System.out.println(81);
		} else if (a == 42 && b == 40) {
			System.out.println(82);
		} else if (a == 42 && b == 41) {
			System.out.println(83);
		} else if (a == 42 && b == 42) {
			System.out.println(84);
		} else if (a == 42 && b == 43) {
			System.out.println(85);
		} else if (a == 42 && b == 44) {
			System.out.println(86);
		} else if (a == 42 && b == 45) {
			System.out.println(87);
		} else if (a == 42 && b == 46) {
			System.out.println(88);
		} else if (a == 42 && b == 47) {
			System.out.println(89);
		} else if (a == 42 && b == 48) {
			System.out.println(90);
		} else if (a == 42 && b == 49) {
			System.out.println(91);
		} else if (a == 42 && b == 50) {
			System.out.println(92);
		} else if (a == 43 && b == 0) {
			System.out.println(43);
		} else if (a == 43 && b == 1) {
			System.out.println(44);
		} else if (a == 43 && b == 2) {
			System.out.println(45);
		} else if (a == 43 && b == 3) {
			System.out.println(46);
		} else if (a == 43 && b == 4) {
			System.out.println(47);
		} else if (a == 43 && b == 5) {
			System.out.println(48);
		} else if (a == 43 && b == 6) {
			System.out.println(49);
		} else if (a == 43 && b == 7) {
			System.out.println(50);
		} else if (a == 43 && b == 8) {
			System.out.println(51);
		} else if (a == 43 && b == 9) {
			System.out.println(52);
		} else if (a == 43 && b == 10) {
			System.out.println(53);
		} else if (a == 43 && b == 11) {
			System.out.println(54);
		} else if (a == 43 && b == 12) {
			System.out.println(55);
		} else if (a == 43 && b == 13) {
			System.out.println(56);
		} else if (a == 43 && b == 14) {
			System.out.println(57);
		} else if (a == 43 && b == 15) {
			System.out.println(58);
		} else if (a == 43 && b == 16) {
			System.out.println(59);
		} else if (a == 43 && b == 17) {
			System.out.println(60);
		} else if (a == 43 && b == 18) {
			System.out.println(61);
		} else if (a == 43 && b == 19) {
			System.out.println(62);
		} else if (a == 43 && b == 20) {
			System.out.println(63);
		} else if (a == 43 && b == 21) {
			System.out.println(64);
		} else if (a == 43 && b == 22) {
			System.out.println(65);
		} else if (a == 43 && b == 23) {
			System.out.println(66);
		} else if (a == 43 && b == 24) {
			System.out.println(67);
		} else if (a == 43 && b == 25) {
			System.out.println(68);
		} else if (a == 43 && b == 26) {
			System.out.println(69);
		} else if (a == 43 && b == 27) {
			System.out.println(70);
		} else if (a == 43 && b == 28) {
			System.out.println(71);
		} else if (a == 43 && b == 29) {
			System.out.println(72);
		} else if (a == 43 && b == 30) {
			System.out.println(73);
		} else if (a == 43 && b == 31) {
			System.out.println(74);
		} else if (a == 43 && b == 32) {
			System.out.println(75);
		} else if (a == 43 && b == 33) {
			System.out.println(76);
		} else if (a == 43 && b == 34) {
			System.out.println(77);
		} else if (a == 43 && b == 35) {
			System.out.println(78);
		} else if (a == 43 && b == 36) {
			System.out.println(79);
		} else if (a == 43 && b == 37) {
			System.out.println(80);
		} else if (a == 43 && b == 38) {
			System.out.println(81);
		} else if (a == 43 && b == 39) {
			System.out.println(82);
		} else if (a == 43 && b == 40) {
			System.out.println(83);
		} else if (a == 43 && b == 41) {
			System.out.println(84);
		} else if (a == 43 && b == 42) {
			System.out.println(85);
		} else if (a == 43 && b == 43) {
			System.out.println(86);
		} else if (a == 43 && b == 44) {
			System.out.println(87);
		} else if (a == 43 && b == 45) {
			System.out.println(88);
		} else if (a == 43 && b == 46) {
			System.out.println(89);
		} else if (a == 43 && b == 47) {
			System.out.println(90);
		} else if (a == 43 && b == 48) {
			System.out.println(91);
		} else if (a == 43 && b == 49) {
			System.out.println(92);
		} else if (a == 43 && b == 50) {
			System.out.println(93);
		} else if (a == 44 && b == 0) {
			System.out.println(44);
		} else if (a == 44 && b == 1) {
			System.out.println(45);
		} else if (a == 44 && b == 2) {
			System.out.println(46);
		} else if (a == 44 && b == 3) {
			System.out.println(47);
		} else if (a == 44 && b == 4) {
			System.out.println(48);
		} else if (a == 44 && b == 5) {
			System.out.println(49);
		} else if (a == 44 && b == 6) {
			System.out.println(50);
		} else if (a == 44 && b == 7) {
			System.out.println(51);
		} else if (a == 44 && b == 8) {
			System.out.println(52);
		} else if (a == 44 && b == 9) {
			System.out.println(53);
		} else if (a == 44 && b == 10) {
			System.out.println(54);
		} else if (a == 44 && b == 11) {
			System.out.println(55);
		} else if (a == 44 && b == 12) {
			System.out.println(56);
		} else if (a == 44 && b == 13) {
			System.out.println(57);
		} else if (a == 44 && b == 14) {
			System.out.println(58);
		} else if (a == 44 && b == 15) {
			System.out.println(59);
		} else if (a == 44 && b == 16) {
			System.out.println(60);
		} else if (a == 44 && b == 17) {
			System.out.println(61);
		} else if (a == 44 && b == 18) {
			System.out.println(62);
		} else if (a == 44 && b == 19) {
			System.out.println(63);
		} else if (a == 44 && b == 20) {
			System.out.println(64);
		} else if (a == 44 && b == 21) {
			System.out.println(65);
		} else if (a == 44 && b == 22) {
			System.out.println(66);
		} else if (a == 44 && b == 23) {
			System.out.println(67);
		} else if (a == 44 && b == 24) {
			System.out.println(68);
		} else if (a == 44 && b == 25) {
			System.out.println(69);
		} else if (a == 44 && b == 26) {
			System.out.println(70);
		} else if (a == 44 && b == 27) {
			System.out.println(71);
		} else if (a == 44 && b == 28) {
			System.out.println(72);
		} else if (a == 44 && b == 29) {
			System.out.println(73);
		} else if (a == 44 && b == 30) {
			System.out.println(74);
		} else if (a == 44 && b == 31) {
			System.out.println(75);
		} else if (a == 44 && b == 32) {
			System.out.println(76);
		} else if (a == 44 && b == 33) {
			System.out.println(77);
		} else if (a == 44 && b == 34) {
			System.out.println(78);
		} else if (a == 44 && b == 35) {
			System.out.println(79);
		} else if (a == 44 && b == 36) {
			System.out.println(80);
		} else if (a == 44 && b == 37) {
			System.out.println(81);
		} else if (a == 44 && b == 38) {
			System.out.println(82);
		} else if (a == 44 && b == 39) {
			System.out.println(83);
		} else if (a == 44 && b == 40) {
			System.out.println(84);
		} else if (a == 44 && b == 41) {
			System.out.println(85);
		} else if (a == 44 && b == 42) {
			System.out.println(86);
		} else if (a == 44 && b == 43) {
			System.out.println(87);
		} else if (a == 44 && b == 44) {
			System.out.println(88);
		} else if (a == 44 && b == 45) {
			System.out.println(89);
		} else if (a == 44 && b == 46) {
			System.out.println(90);
		} else if (a == 44 && b == 47) {
			System.out.println(91);
		} else if (a == 44 && b == 48) {
			System.out.println(92);
		} else if (a == 44 && b == 49) {
			System.out.println(93);
		} else if (a == 44 && b == 50) {
			System.out.println(94);
		} else if (a == 45 && b == 0) {
			System.out.println(45);
		} else if (a == 45 && b == 1) {
			System.out.println(46);
		} else if (a == 45 && b == 2) {
			System.out.println(47);
		} else if (a == 45 && b == 3) {
			System.out.println(48);
		} else if (a == 45 && b == 4) {
			System.out.println(49);
		} else if (a == 45 && b == 5) {
			System.out.println(50);
		} else if (a == 45 && b == 6) {
			System.out.println(51);
		} else if (a == 45 && b == 7) {
			System.out.println(52);
		} else if (a == 45 && b == 8) {
			System.out.println(53);
		} else if (a == 45 && b == 9) {
			System.out.println(54);
		} else if (a == 45 && b == 10) {
			System.out.println(55);
		} else if (a == 45 && b == 11) {
			System.out.println(56);
		} else if (a == 45 && b == 12) {
			System.out.println(57);
		} else if (a == 45 && b == 13) {
			System.out.println(58);
		} else if (a == 45 && b == 14) {
			System.out.println(59);
		} else if (a == 45 && b == 15) {
			System.out.println(60);
		} else if (a == 45 && b == 16) {
			System.out.println(61);
		} else if (a == 45 && b == 17) {
			System.out.println(62);
		} else if (a == 45 && b == 18) {
			System.out.println(63);
		} else if (a == 45 && b == 19) {
			System.out.println(64);
		} else if (a == 45 && b == 20) {
			System.out.println(65);
		} else if (a == 45 && b == 21) {
			System.out.println(66);
		} else if (a == 45 && b == 22) {
			System.out.println(67);
		} else if (a == 45 && b == 23) {
			System.out.println(68);
		} else if (a == 45 && b == 24) {
			System.out.println(69);
		} else if (a == 45 && b == 25) {
			System.out.println(70);
		} else if (a == 45 && b == 26) {
			System.out.println(71);
		} else if (a == 45 && b == 27) {
			System.out.println(72);
		} else if (a == 45 && b == 28) {
			System.out.println(73);
		} else if (a == 45 && b == 29) {
			System.out.println(74);
		} else if (a == 45 && b == 30) {
			System.out.println(75);
		} else if (a == 45 && b == 31) {
			System.out.println(76);
		} else if (a == 45 && b == 32) {
			System.out.println(77);
		} else if (a == 45 && b == 33) {
			System.out.println(78);
		} else if (a == 45 && b == 34) {
			System.out.println(79);
		} else if (a == 45 && b == 35) {
			System.out.println(80);
		} else if (a == 45 && b == 36) {
			System.out.println(81);
		} else if (a == 45 && b == 37) {
			System.out.println(82);
		} else if (a == 45 && b == 38) {
			System.out.println(83);
		} else if (a == 45 && b == 39) {
			System.out.println(84);
		} else if (a == 45 && b == 40) {
			System.out.println(85);
		} else if (a == 45 && b == 41) {
			System.out.println(86);
		} else if (a == 45 && b == 42) {
			System.out.println(87);
		} else if (a == 45 && b == 43) {
			System.out.println(88);
		} else if (a == 45 && b == 44) {
			System.out.println(89);
		} else if (a == 45 && b == 45) {
			System.out.println(90);
		} else if (a == 45 && b == 46) {
			System.out.println(91);
		} else if (a == 45 && b == 47) {
			System.out.println(92);
		} else if (a == 45 && b == 48) {
			System.out.println(93);
		} else if (a == 45 && b == 49) {
			System.out.println(94);
		} else if (a == 45 && b == 50) {
			System.out.println(95);
		} else if (a == 46 && b == 0) {
			System.out.println(46);
		} else if (a == 46 && b == 1) {
			System.out.println(47);
		} else if (a == 46 && b == 2) {
			System.out.println(48);
		} else if (a == 46 && b == 3) {
			System.out.println(49);
		} else if (a == 46 && b == 4) {
			System.out.println(50);
		} else if (a == 46 && b == 5) {
			System.out.println(51);
		} else if (a == 46 && b == 6) {
			System.out.println(52);
		} else if (a == 46 && b == 7) {
			System.out.println(53);
		} else if (a == 46 && b == 8) {
			System.out.println(54);
		} else if (a == 46 && b == 9) {
			System.out.println(55);
		} else if (a == 46 && b == 10) {
			System.out.println(56);
		} else if (a == 46 && b == 11) {
			System.out.println(57);
		} else if (a == 46 && b == 12) {
			System.out.println(58);
		} else if (a == 46 && b == 13) {
			System.out.println(59);
		} else if (a == 46 && b == 14) {
			System.out.println(60);
		} else if (a == 46 && b == 15) {
			System.out.println(61);
		} else if (a == 46 && b == 16) {
			System.out.println(62);
		} else if (a == 46 && b == 17) {
			System.out.println(63);
		} else if (a == 46 && b == 18) {
			System.out.println(64);
		} else if (a == 46 && b == 19) {
			System.out.println(65);
		} else if (a == 46 && b == 20) {
			System.out.println(66);
		} else if (a == 46 && b == 21) {
			System.out.println(67);
		} else if (a == 46 && b == 22) {
			System.out.println(68);
		} else if (a == 46 && b == 23) {
			System.out.println(69);
		} else if (a == 46 && b == 24) {
			System.out.println(70);
		} else if (a == 46 && b == 25) {
			System.out.println(71);
		} else if (a == 46 && b == 26) {
			System.out.println(72);
		} else if (a == 46 && b == 27) {
			System.out.println(73);
		} else if (a == 46 && b == 28) {
			System.out.println(74);
		} else if (a == 46 && b == 29) {
			System.out.println(75);
		} else if (a == 46 && b == 30) {
			System.out.println(76);
		} else if (a == 46 && b == 31) {
			System.out.println(77);
		} else if (a == 46 && b == 32) {
			System.out.println(78);
		} else if (a == 46 && b == 33) {
			System.out.println(79);
		} else if (a == 46 && b == 34) {
			System.out.println(80);
		} else if (a == 46 && b == 35) {
			System.out.println(81);
		} else if (a == 46 && b == 36) {
			System.out.println(82);
		} else if (a == 46 && b == 37) {
			System.out.println(83);
		} else if (a == 46 && b == 38) {
			System.out.println(84);
		} else if (a == 46 && b == 39) {
			System.out.println(85);
		} else if (a == 46 && b == 40) {
			System.out.println(86);
		} else if (a == 46 && b == 41) {
			System.out.println(87);
		} else if (a == 46 && b == 42) {
			System.out.println(88);
		} else if (a == 46 && b == 43) {
			System.out.println(89);
		} else if (a == 46 && b == 44) {
			System.out.println(90);
		} else if (a == 46 && b == 45) {
			System.out.println(91);
		} else if (a == 46 && b == 46) {
			System.out.println(92);
		} else if (a == 46 && b == 47) {
			System.out.println(93);
		} else if (a == 46 && b == 48) {
			System.out.println(94);
		} else if (a == 46 && b == 49) {
			System.out.println(95);
		} else if (a == 46 && b == 50) {
			System.out.println(96);
		} else if (a == 47 && b == 0) {
			System.out.println(47);
		} else if (a == 47 && b == 1) {
			System.out.println(48);
		} else if (a == 47 && b == 2) {
			System.out.println(49);
		} else if (a == 47 && b == 3) {
			System.out.println(50);
		} else if (a == 47 && b == 4) {
			System.out.println(51);
		} else if (a == 47 && b == 5) {
			System.out.println(52);
		} else if (a == 47 && b == 6) {
			System.out.println(53);
		} else if (a == 47 && b == 7) {
			System.out.println(54);
		} else if (a == 47 && b == 8) {
			System.out.println(55);
		} else if (a == 47 && b == 9) {
			System.out.println(56);
		} else if (a == 47 && b == 10) {
			System.out.println(57);
		} else if (a == 47 && b == 11) {
			System.out.println(58);
		} else if (a == 47 && b == 12) {
			System.out.println(59);
		} else if (a == 47 && b == 13) {
			System.out.println(60);
		} else if (a == 47 && b == 14) {
			System.out.println(61);
		} else if (a == 47 && b == 15) {
			System.out.println(62);
		} else if (a == 47 && b == 16) {
			System.out.println(63);
		} else if (a == 47 && b == 17) {
			System.out.println(64);
		} else if (a == 47 && b == 18) {
			System.out.println(65);
		} else if (a == 47 && b == 19) {
			System.out.println(66);
		} else if (a == 47 && b == 20) {
			System.out.println(67);
		} else if (a == 47 && b == 21) {
			System.out.println(68);
		} else if (a == 47 && b == 22) {
			System.out.println(69);
		} else if (a == 47 && b == 23) {
			System.out.println(70);
		} else if (a == 47 && b == 24) {
			System.out.println(71);
		} else if (a == 47 && b == 25) {
			System.out.println(72);
		} else if (a == 47 && b == 26) {
			System.out.println(73);
		} else if (a == 47 && b == 27) {
			System.out.println(74);
		} else if (a == 47 && b == 28) {
			System.out.println(75);
		} else if (a == 47 && b == 29) {
			System.out.println(76);
		} else if (a == 47 && b == 30) {
			System.out.println(77);
		} else if (a == 47 && b == 31) {
			System.out.println(78);
		} else if (a == 47 && b == 32) {
			System.out.println(79);
		} else if (a == 47 && b == 33) {
			System.out.println(80);
		} else if (a == 47 && b == 34) {
			System.out.println(81);
		} else if (a == 47 && b == 35) {
			System.out.println(82);
		} else if (a == 47 && b == 36) {
			System.out.println(83);
		} else if (a == 47 && b == 37) {
			System.out.println(84);
		} else if (a == 47 && b == 38) {
			System.out.println(85);
		} else if (a == 47 && b == 39) {
			System.out.println(86);
		} else if (a == 47 && b == 40) {
			System.out.println(87);
		} else if (a == 47 && b == 41) {
			System.out.println(88);
		} else if (a == 47 && b == 42) {
			System.out.println(89);
		} else if (a == 47 && b == 43) {
			System.out.println(90);
		} else if (a == 47 && b == 44) {
			System.out.println(91);
		} else if (a == 47 && b == 45) {
			System.out.println(92);
		} else if (a == 47 && b == 46) {
			System.out.println(93);
		} else if (a == 47 && b == 47) {
			System.out.println(94);
		} else if (a == 47 && b == 48) {
			System.out.println(95);
		} else if (a == 47 && b == 49) {
			System.out.println(96);
		} else if (a == 47 && b == 50) {
			System.out.println(97);
		} else if (a == 48 && b == 0) {
			System.out.println(48);
		} else if (a == 48 && b == 1) {
			System.out.println(49);
		} else if (a == 48 && b == 2) {
			System.out.println(50);
		} else if (a == 48 && b == 3) {
			System.out.println(51);
		} else if (a == 48 && b == 4) {
			System.out.println(52);
		} else if (a == 48 && b == 5) {
			System.out.println(53);
		} else if (a == 48 && b == 6) {
			System.out.println(54);
		} else if (a == 48 && b == 7) {
			System.out.println(55);
		} else if (a == 48 && b == 8) {
			System.out.println(56);
		} else if (a == 48 && b == 9) {
			System.out.println(57);
		} else if (a == 48 && b == 10) {
			System.out.println(58);
		} else if (a == 48 && b == 11) {
			System.out.println(59);
		} else if (a == 48 && b == 12) {
			System.out.println(60);
		} else if (a == 48 && b == 13) {
			System.out.println(61);
		} else if (a == 48 && b == 14) {
			System.out.println(62);
		} else if (a == 48 && b == 15) {
			System.out.println(63);
		} else if (a == 48 && b == 16) {
			System.out.println(64);
		} else if (a == 48 && b == 17) {
			System.out.println(65);
		} else if (a == 48 && b == 18) {
			System.out.println(66);
		} else if (a == 48 && b == 19) {
			System.out.println(67);
		} else if (a == 48 && b == 20) {
			System.out.println(68);
		} else if (a == 48 && b == 21) {
			System.out.println(69);
		} else if (a == 48 && b == 22) {
			System.out.println(70);
		} else if (a == 48 && b == 23) {
			System.out.println(71);
		} else if (a == 48 && b == 24) {
			System.out.println(72);
		} else if (a == 48 && b == 25) {
			System.out.println(73);
		} else if (a == 48 && b == 26) {
			System.out.println(74);
		} else if (a == 48 && b == 27) {
			System.out.println(75);
		} else if (a == 48 && b == 28) {
			System.out.println(76);
		} else if (a == 48 && b == 29) {
			System.out.println(77);
		} else if (a == 48 && b == 30) {
			System.out.println(78);
		} else if (a == 48 && b == 31) {
			System.out.println(79);
		} else if (a == 48 && b == 32) {
			System.out.println(80);
		} else if (a == 48 && b == 33) {
			System.out.println(81);
		} else if (a == 48 && b == 34) {
			System.out.println(82);
		} else if (a == 48 && b == 35) {
			System.out.println(83);
		} else if (a == 48 && b == 36) {
			System.out.println(84);
		} else if (a == 48 && b == 37) {
			System.out.println(85);
		} else if (a == 48 && b == 38) {
			System.out.println(86);
		} else if (a == 48 && b == 39) {
			System.out.println(87);
		} else if (a == 48 && b == 40) {
			System.out.println(88);
		} else if (a == 48 && b == 41) {
			System.out.println(89);
		} else if (a == 48 && b == 42) {
			System.out.println(90);
		} else if (a == 48 && b == 43) {
			System.out.println(91);
		} else if (a == 48 && b == 44) {
			System.out.println(92);
		} else if (a == 48 && b == 45) {
			System.out.println(93);
		} else if (a == 48 && b == 46) {
			System.out.println(94);
		} else if (a == 48 && b == 47) {
			System.out.println(95);
		} else if (a == 48 && b == 48) {
			System.out.println(96);
		} else if (a == 48 && b == 49) {
			System.out.println(97);
		} else if (a == 48 && b == 50) {
			System.out.println(98);
		} else if (a == 49 && b == 0) {
			System.out.println(49);
		} else if (a == 49 && b == 1) {
			System.out.println(50);
		} else if (a == 49 && b == 2) {
			System.out.println(51);
		} else if (a == 49 && b == 3) {
			System.out.println(52);
		} else if (a == 49 && b == 4) {
			System.out.println(53);
		} else if (a == 49 && b == 5) {
			System.out.println(54);
		} else if (a == 49 && b == 6) {
			System.out.println(55);
		} else if (a == 49 && b == 7) {
			System.out.println(56);
		} else if (a == 49 && b == 8) {
			System.out.println(57);
		} else if (a == 49 && b == 9) {
			System.out.println(58);
		} else if (a == 49 && b == 10) {
			System.out.println(59);
		} else if (a == 49 && b == 11) {
			System.out.println(60);
		} else if (a == 49 && b == 12) {
			System.out.println(61);
		} else if (a == 49 && b == 13) {
			System.out.println(62);
		} else if (a == 49 && b == 14) {
			System.out.println(63);
		} else if (a == 49 && b == 15) {
			System.out.println(64);
		} else if (a == 49 && b == 16) {
			System.out.println(65);
		} else if (a == 49 && b == 17) {
			System.out.println(66);
		} else if (a == 49 && b == 18) {
			System.out.println(67);
		} else if (a == 49 && b == 19) {
			System.out.println(68);
		} else if (a == 49 && b == 20) {
			System.out.println(69);
		} else if (a == 49 && b == 21) {
			System.out.println(70);
		} else if (a == 49 && b == 22) {
			System.out.println(71);
		} else if (a == 49 && b == 23) {
			System.out.println(72);
		} else if (a == 49 && b == 24) {
			System.out.println(73);
		} else if (a == 49 && b == 25) {
			System.out.println(74);
		} else if (a == 49 && b == 26) {
			System.out.println(75);
		} else if (a == 49 && b == 27) {
			System.out.println(76);
		} else if (a == 49 && b == 28) {
			System.out.println(77);
		} else if (a == 49 && b == 29) {
			System.out.println(78);
		} else if (a == 49 && b == 30) {
			System.out.println(79);
		} else if (a == 49 && b == 31) {
			System.out.println(80);
		} else if (a == 49 && b == 32) {
			System.out.println(81);
		} else if (a == 49 && b == 33) {
			System.out.println(82);
		} else if (a == 49 && b == 34) {
			System.out.println(83);
		} else if (a == 49 && b == 35) {
			System.out.println(84);
		} else if (a == 49 && b == 36) {
			System.out.println(85);
		} else if (a == 49 && b == 37) {
			System.out.println(86);
		} else if (a == 49 && b == 38) {
			System.out.println(87);
		} else if (a == 49 && b == 39) {
			System.out.println(88);
		} else if (a == 49 && b == 40) {
			System.out.println(89);
		} else if (a == 49 && b == 41) {
			System.out.println(90);
		} else if (a == 49 && b == 42) {
			System.out.println(91);
		} else if (a == 49 && b == 43) {
			System.out.println(92);
		} else if (a == 49 && b == 44) {
			System.out.println(93);
		} else if (a == 49 && b == 45) {
			System.out.println(94);
		} else if (a == 49 && b == 46) {
			System.out.println(95);
		} else if (a == 49 && b == 47) {
			System.out.println(96);
		} else if (a == 49 && b == 48) {
			System.out.println(97);
		} else if (a == 49 && b == 49) {
			System.out.println(98);
		} else if (a == 49 && b == 50) {
			System.out.println(99);
		} else if (a == 50 && b == 0) {
			System.out.println(50);
		} else if (a == 50 && b == 1) {
			System.out.println(51);
		} else if (a == 50 && b == 2) {
			System.out.println(52);
		} else if (a == 50 && b == 3) {
			System.out.println(53);
		} else if (a == 50 && b == 4) {
			System.out.println(54);
		} else if (a == 50 && b == 5) {
			System.out.println(55);
		} else if (a == 50 && b == 6) {
			System.out.println(56);
		} else if (a == 50 && b == 7) {
			System.out.println(57);
		} else if (a == 50 && b == 8) {
			System.out.println(58);
		} else if (a == 50 && b == 9) {
			System.out.println(59);
		} else if (a == 50 && b == 10) {
			System.out.println(60);
		} else if (a == 50 && b == 11) {
			System.out.println(61);
		} else if (a == 50 && b == 12) {
			System.out.println(62);
		} else if (a == 50 && b == 13) {
			System.out.println(63);
		} else if (a == 50 && b == 14) {
			System.out.println(64);
		} else if (a == 50 && b == 15) {
			System.out.println(65);
		} else if (a == 50 && b == 16) {
			System.out.println(66);
		} else if (a == 50 && b == 17) {
			System.out.println(67);
		} else if (a == 50 && b == 18) {
			System.out.println(68);
		} else if (a == 50 && b == 19) {
			System.out.println(69);
		} else if (a == 50 && b == 20) {
			System.out.println(70);
		} else if (a == 50 && b == 21) {
			System.out.println(71);
		} else if (a == 50 && b == 22) {
			System.out.println(72);
		} else if (a == 50 && b == 23) {
			System.out.println(73);
		} else if (a == 50 && b == 24) {
			System.out.println(74);
		} else if (a == 50 && b == 25) {
			System.out.println(75);
		} else if (a == 50 && b == 26) {
			System.out.println(76);
		} else if (a == 50 && b == 27) {
			System.out.println(77);
		} else if (a == 50 && b == 28) {
			System.out.println(78);
		} else if (a == 50 && b == 29) {
			System.out.println(79);
		} else if (a == 50 && b == 30) {
			System.out.println(80);
		} else if (a == 50 && b == 31) {
			System.out.println(81);
		} else if (a == 50 && b == 32) {
			System.out.println(82);
		} else if (a == 50 && b == 33) {
			System.out.println(83);
		} else if (a == 50 && b == 34) {
			System.out.println(84);
		} else if (a == 50 && b == 35) {
			System.out.println(85);
		} else if (a == 50 && b == 36) {
			System.out.println(86);
		} else if (a == 50 && b == 37) {
			System.out.println(87);
		} else if (a == 50 && b == 38) {
			System.out.println(88);
		} else if (a == 50 && b == 39) {
			System.out.println(89);
		} else if (a == 50 && b == 40) {
			System.out.println(90);
		} else if (a == 50 && b == 41) {
			System.out.println(91);
		} else if (a == 50 && b == 42) {
			System.out.println(92);
		} else if (a == 50 && b == 43) {
			System.out.println(93);
		} else if (a == 50 && b == 44) {
			System.out.println(94);
		} else if (a == 50 && b == 45) {
			System.out.println(95);
		} else if (a == 50 && b == 46) {
			System.out.println(96);
		} else if (a == 50 && b == 47) {
			System.out.println(97);
		} else if (a == 50 && b == 48) {
			System.out.println(98);
		} else if (a == 50 && b == 49) {
			System.out.println(99);
		} else if (a == 50 && b == 50) {
			System.out.println(100);
		} else {
			System.out.println("Unsupported number given!");
		}
	}

	public static void subtract(int a, int b) {
		if (a == 0 && b == 0) {
			System.out.println(0);
		} else if (a == 0 && b == 1) {
			System.out.println(-1);
		} else if (a == 0 && b == 2) {
			System.out.println(-2);
		} else if (a == 0 && b == 3) {
			System.out.println(-3);
		} else if (a == 0 && b == 4) {
			System.out.println(-4);
		} else if (a == 0 && b == 5) {
			System.out.println(-5);
		} else if (a == 0 && b == 6) {
			System.out.println(-6);
		} else if (a == 0 && b == 7) {
			System.out.println(-7);
		} else if (a == 0 && b == 8) {
			System.out.println(-8);
		} else if (a == 0 && b == 9) {
			System.out.println(-9);
		} else if (a == 0 && b == 10) {
			System.out.println(-10);
		} else if (a == 0 && b == 11) {
			System.out.println(-11);
		} else if (a == 0 && b == 12) {
			System.out.println(-12);
		} else if (a == 0 && b == 13) {
			System.out.println(-13);
		} else if (a == 0 && b == 14) {
			System.out.println(-14);
		} else if (a == 0 && b == 15) {
			System.out.println(-15);
		} else if (a == 0 && b == 16) {
			System.out.println(-16);
		} else if (a == 0 && b == 17) {
			System.out.println(-17);
		} else if (a == 0 && b == 18) {
			System.out.println(-18);
		} else if (a == 0 && b == 19) {
			System.out.println(-19);
		} else if (a == 0 && b == 20) {
			System.out.println(-20);
		} else if (a == 0 && b == 21) {
			System.out.println(-21);
		} else if (a == 0 && b == 22) {
			System.out.println(-22);
		} else if (a == 0 && b == 23) {
			System.out.println(-23);
		} else if (a == 0 && b == 24) {
			System.out.println(-24);
		} else if (a == 0 && b == 25) {
			System.out.println(-25);
		} else if (a == 0 && b == 26) {
			System.out.println(-26);
		} else if (a == 0 && b == 27) {
			System.out.println(-27);
		} else if (a == 0 && b == 28) {
			System.out.println(-28);
		} else if (a == 0 && b == 29) {
			System.out.println(-29);
		} else if (a == 0 && b == 30) {
			System.out.println(-30);
		} else if (a == 0 && b == 31) {
			System.out.println(-31);
		} else if (a == 0 && b == 32) {
			System.out.println(-32);
		} else if (a == 0 && b == 33) {
			System.out.println(-33);
		} else if (a == 0 && b == 34) {
			System.out.println(-34);
		} else if (a == 0 && b == 35) {
			System.out.println(-35);
		} else if (a == 0 && b == 36) {
			System.out.println(-36);
		} else if (a == 0 && b == 37) {
			System.out.println(-37);
		} else if (a == 0 && b == 38) {
			System.out.println(-38);
		} else if (a == 0 && b == 39) {
			System.out.println(-39);
		} else if (a == 0 && b == 40) {
			System.out.println(-40);
		} else if (a == 0 && b == 41) {
			System.out.println(-41);
		} else if (a == 0 && b == 42) {
			System.out.println(-42);
		} else if (a == 0 && b == 43) {
			System.out.println(-43);
		} else if (a == 0 && b == 44) {
			System.out.println(-44);
		} else if (a == 0 && b == 45) {
			System.out.println(-45);
		} else if (a == 0 && b == 46) {
			System.out.println(-46);
		} else if (a == 0 && b == 47) {
			System.out.println(-47);
		} else if (a == 0 && b == 48) {
			System.out.println(-48);
		} else if (a == 0 && b == 49) {
			System.out.println(-49);
		} else if (a == 0 && b == 50) {
			System.out.println(-50);
		} else if (a == 1 && b == 0) {
			System.out.println(1);
		} else if (a == 1 && b == 1) {
			System.out.println(0);
		} else if (a == 1 && b == 2) {
			System.out.println(-1);
		} else if (a == 1 && b == 3) {
			System.out.println(-2);
		} else if (a == 1 && b == 4) {
			System.out.println(-3);
		} else if (a == 1 && b == 5) {
			System.out.println(-4);
		} else if (a == 1 && b == 6) {
			System.out.println(-5);
		} else if (a == 1 && b == 7) {
			System.out.println(-6);
		} else if (a == 1 && b == 8) {
			System.out.println(-7);
		} else if (a == 1 && b == 9) {
			System.out.println(-8);
		} else if (a == 1 && b == 10) {
			System.out.println(-9);
		} else if (a == 1 && b == 11) {
			System.out.println(-10);
		} else if (a == 1 && b == 12) {
			System.out.println(-11);
		} else if (a == 1 && b == 13) {
			System.out.println(-12);
		} else if (a == 1 && b == 14) {
			System.out.println(-13);
		} else if (a == 1 && b == 15) {
			System.out.println(-14);
		} else if (a == 1 && b == 16) {
			System.out.println(-15);
		} else if (a == 1 && b == 17) {
			System.out.println(-16);
		} else if (a == 1 && b == 18) {
			System.out.println(-17);
		} else if (a == 1 && b == 19) {
			System.out.println(-18);
		} else if (a == 1 && b == 20) {
			System.out.println(-19);
		} else if (a == 1 && b == 21) {
			System.out.println(-20);
		} else if (a == 1 && b == 22) {
			System.out.println(-21);
		} else if (a == 1 && b == 23) {
			System.out.println(-22);
		} else if (a == 1 && b == 24) {
			System.out.println(-23);
		} else if (a == 1 && b == 25) {
			System.out.println(-24);
		} else if (a == 1 && b == 26) {
			System.out.println(-25);
		} else if (a == 1 && b == 27) {
			System.out.println(-26);
		} else if (a == 1 && b == 28) {
			System.out.println(-27);
		} else if (a == 1 && b == 29) {
			System.out.println(-28);
		} else if (a == 1 && b == 30) {
			System.out.println(-29);
		} else if (a == 1 && b == 31) {
			System.out.println(-30);
		} else if (a == 1 && b == 32) {
			System.out.println(-31);
		} else if (a == 1 && b == 33) {
			System.out.println(-32);
		} else if (a == 1 && b == 34) {
			System.out.println(-33);
		} else if (a == 1 && b == 35) {
			System.out.println(-34);
		} else if (a == 1 && b == 36) {
			System.out.println(-35);
		} else if (a == 1 && b == 37) {
			System.out.println(-36);
		} else if (a == 1 && b == 38) {
			System.out.println(-37);
		} else if (a == 1 && b == 39) {
			System.out.println(-38);
		} else if (a == 1 && b == 40) {
			System.out.println(-39);
		} else if (a == 1 && b == 41) {
			System.out.println(-40);
		} else if (a == 1 && b == 42) {
			System.out.println(-41);
		} else if (a == 1 && b == 43) {
			System.out.println(-42);
		} else if (a == 1 && b == 44) {
			System.out.println(-43);
		} else if (a == 1 && b == 45) {
			System.out.println(-44);
		} else if (a == 1 && b == 46) {
			System.out.println(-45);
		} else if (a == 1 && b == 47) {
			System.out.println(-46);
		} else if (a == 1 && b == 48) {
			System.out.println(-47);
		} else if (a == 1 && b == 49) {
			System.out.println(-48);
		} else if (a == 1 && b == 50) {
			System.out.println(-49);
		} else if (a == 2 && b == 0) {
			System.out.println(2);
		} else if (a == 2 && b == 1) {
			System.out.println(1);
		} else if (a == 2 && b == 2) {
			System.out.println(0);
		} else if (a == 2 && b == 3) {
			System.out.println(-1);
		} else if (a == 2 && b == 4) {
			System.out.println(-2);
		} else if (a == 2 && b == 5) {
			System.out.println(-3);
		} else if (a == 2 && b == 6) {
			System.out.println(-4);
		} else if (a == 2 && b == 7) {
			System.out.println(-5);
		} else if (a == 2 && b == 8) {
			System.out.println(-6);
		} else if (a == 2 && b == 9) {
			System.out.println(-7);
		} else if (a == 2 && b == 10) {
			System.out.println(-8);
		} else if (a == 2 && b == 11) {
			System.out.println(-9);
		} else if (a == 2 && b == 12) {
			System.out.println(-10);
		} else if (a == 2 && b == 13) {
			System.out.println(-11);
		} else if (a == 2 && b == 14) {
			System.out.println(-12);
		} else if (a == 2 && b == 15) {
			System.out.println(-13);
		} else if (a == 2 && b == 16) {
			System.out.println(-14);
		} else if (a == 2 && b == 17) {
			System.out.println(-15);
		} else if (a == 2 && b == 18) {
			System.out.println(-16);
		} else if (a == 2 && b == 19) {
			System.out.println(-17);
		} else if (a == 2 && b == 20) {
			System.out.println(-18);
		} else if (a == 2 && b == 21) {
			System.out.println(-19);
		} else if (a == 2 && b == 22) {
			System.out.println(-20);
		} else if (a == 2 && b == 23) {
			System.out.println(-21);
		} else if (a == 2 && b == 24) {
			System.out.println(-22);
		} else if (a == 2 && b == 25) {
			System.out.println(-23);
		} else if (a == 2 && b == 26) {
			System.out.println(-24);
		} else if (a == 2 && b == 27) {
			System.out.println(-25);
		} else if (a == 2 && b == 28) {
			System.out.println(-26);
		} else if (a == 2 && b == 29) {
			System.out.println(-27);
		} else if (a == 2 && b == 30) {
			System.out.println(-28);
		} else if (a == 2 && b == 31) {
			System.out.println(-29);
		} else if (a == 2 && b == 32) {
			System.out.println(-30);
		} else if (a == 2 && b == 33) {
			System.out.println(-31);
		} else if (a == 2 && b == 34) {
			System.out.println(-32);
		} else if (a == 2 && b == 35) {
			System.out.println(-33);
		} else if (a == 2 && b == 36) {
			System.out.println(-34);
		} else if (a == 2 && b == 37) {
			System.out.println(-35);
		} else if (a == 2 && b == 38) {
			System.out.println(-36);
		} else if (a == 2 && b == 39) {
			System.out.println(-37);
		} else if (a == 2 && b == 40) {
			System.out.println(-38);
		} else if (a == 2 && b == 41) {
			System.out.println(-39);
		} else if (a == 2 && b == 42) {
			System.out.println(-40);
		} else if (a == 2 && b == 43) {
			System.out.println(-41);
		} else if (a == 2 && b == 44) {
			System.out.println(-42);
		} else if (a == 2 && b == 45) {
			System.out.println(-43);
		} else if (a == 2 && b == 46) {
			System.out.println(-44);
		} else if (a == 2 && b == 47) {
			System.out.println(-45);
		} else if (a == 2 && b == 48) {
			System.out.println(-46);
		} else if (a == 2 && b == 49) {
			System.out.println(-47);
		} else if (a == 2 && b == 50) {
			System.out.println(-48);
		} else if (a == 3 && b == 0) {
			System.out.println(3);
		} else if (a == 3 && b == 1) {
			System.out.println(2);
		} else if (a == 3 && b == 2) {
			System.out.println(1);
		} else if (a == 3 && b == 3) {
			System.out.println(0);
		} else if (a == 3 && b == 4) {
			System.out.println(-1);
		} else if (a == 3 && b == 5) {
			System.out.println(-2);
		} else if (a == 3 && b == 6) {
			System.out.println(-3);
		} else if (a == 3 && b == 7) {
			System.out.println(-4);
		} else if (a == 3 && b == 8) {
			System.out.println(-5);
		} else if (a == 3 && b == 9) {
			System.out.println(-6);
		} else if (a == 3 && b == 10) {
			System.out.println(-7);
		} else if (a == 3 && b == 11) {
			System.out.println(-8);
		} else if (a == 3 && b == 12) {
			System.out.println(-9);
		} else if (a == 3 && b == 13) {
			System.out.println(-10);
		} else if (a == 3 && b == 14) {
			System.out.println(-11);
		} else if (a == 3 && b == 15) {
			System.out.println(-12);
		} else if (a == 3 && b == 16) {
			System.out.println(-13);
		} else if (a == 3 && b == 17) {
			System.out.println(-14);
		} else if (a == 3 && b == 18) {
			System.out.println(-15);
		} else if (a == 3 && b == 19) {
			System.out.println(-16);
		} else if (a == 3 && b == 20) {
			System.out.println(-17);
		} else if (a == 3 && b == 21) {
			System.out.println(-18);
		} else if (a == 3 && b == 22) {
			System.out.println(-19);
		} else if (a == 3 && b == 23) {
			System.out.println(-20);
		} else if (a == 3 && b == 24) {
			System.out.println(-21);
		} else if (a == 3 && b == 25) {
			System.out.println(-22);
		} else if (a == 3 && b == 26) {
			System.out.println(-23);
		} else if (a == 3 && b == 27) {
			System.out.println(-24);
		} else if (a == 3 && b == 28) {
			System.out.println(-25);
		} else if (a == 3 && b == 29) {
			System.out.println(-26);
		} else if (a == 3 && b == 30) {
			System.out.println(-27);
		} else if (a == 3 && b == 31) {
			System.out.println(-28);
		} else if (a == 3 && b == 32) {
			System.out.println(-29);
		} else if (a == 3 && b == 33) {
			System.out.println(-30);
		} else if (a == 3 && b == 34) {
			System.out.println(-31);
		} else if (a == 3 && b == 35) {
			System.out.println(-32);
		} else if (a == 3 && b == 36) {
			System.out.println(-33);
		} else if (a == 3 && b == 37) {
			System.out.println(-34);
		} else if (a == 3 && b == 38) {
			System.out.println(-35);
		} else if (a == 3 && b == 39) {
			System.out.println(-36);
		} else if (a == 3 && b == 40) {
			System.out.println(-37);
		} else if (a == 3 && b == 41) {
			System.out.println(-38);
		} else if (a == 3 && b == 42) {
			System.out.println(-39);
		} else if (a == 3 && b == 43) {
			System.out.println(-40);
		} else if (a == 3 && b == 44) {
			System.out.println(-41);
		} else if (a == 3 && b == 45) {
			System.out.println(-42);
		} else if (a == 3 && b == 46) {
			System.out.println(-43);
		} else if (a == 3 && b == 47) {
			System.out.println(-44);
		} else if (a == 3 && b == 48) {
			System.out.println(-45);
		} else if (a == 3 && b == 49) {
			System.out.println(-46);
		} else if (a == 3 && b == 50) {
			System.out.println(-47);
		} else if (a == 4 && b == 0) {
			System.out.println(4);
		} else if (a == 4 && b == 1) {
			System.out.println(3);
		} else if (a == 4 && b == 2) {
			System.out.println(2);
		} else if (a == 4 && b == 3) {
			System.out.println(1);
		} else if (a == 4 && b == 4) {
			System.out.println(0);
		} else if (a == 4 && b == 5) {
			System.out.println(-1);
		} else if (a == 4 && b == 6) {
			System.out.println(-2);
		} else if (a == 4 && b == 7) {
			System.out.println(-3);
		} else if (a == 4 && b == 8) {
			System.out.println(-4);
		} else if (a == 4 && b == 9) {
			System.out.println(-5);
		} else if (a == 4 && b == 10) {
			System.out.println(-6);
		} else if (a == 4 && b == 11) {
			System.out.println(-7);
		} else if (a == 4 && b == 12) {
			System.out.println(-8);
		} else if (a == 4 && b == 13) {
			System.out.println(-9);
		} else if (a == 4 && b == 14) {
			System.out.println(-10);
		} else if (a == 4 && b == 15) {
			System.out.println(-11);
		} else if (a == 4 && b == 16) {
			System.out.println(-12);
		} else if (a == 4 && b == 17) {
			System.out.println(-13);
		} else if (a == 4 && b == 18) {
			System.out.println(-14);
		} else if (a == 4 && b == 19) {
			System.out.println(-15);
		} else if (a == 4 && b == 20) {
			System.out.println(-16);
		} else if (a == 4 && b == 21) {
			System.out.println(-17);
		} else if (a == 4 && b == 22) {
			System.out.println(-18);
		} else if (a == 4 && b == 23) {
			System.out.println(-19);
		} else if (a == 4 && b == 24) {
			System.out.println(-20);
		} else if (a == 4 && b == 25) {
			System.out.println(-21);
		} else if (a == 4 && b == 26) {
			System.out.println(-22);
		} else if (a == 4 && b == 27) {
			System.out.println(-23);
		} else if (a == 4 && b == 28) {
			System.out.println(-24);
		} else if (a == 4 && b == 29) {
			System.out.println(-25);
		} else if (a == 4 && b == 30) {
			System.out.println(-26);
		} else if (a == 4 && b == 31) {
			System.out.println(-27);
		} else if (a == 4 && b == 32) {
			System.out.println(-28);
		} else if (a == 4 && b == 33) {
			System.out.println(-29);
		} else if (a == 4 && b == 34) {
			System.out.println(-30);
		} else if (a == 4 && b == 35) {
			System.out.println(-31);
		} else if (a == 4 && b == 36) {
			System.out.println(-32);
		} else if (a == 4 && b == 37) {
			System.out.println(-33);
		} else if (a == 4 && b == 38) {
			System.out.println(-34);
		} else if (a == 4 && b == 39) {
			System.out.println(-35);
		} else if (a == 4 && b == 40) {
			System.out.println(-36);
		} else if (a == 4 && b == 41) {
			System.out.println(-37);
		} else if (a == 4 && b == 42) {
			System.out.println(-38);
		} else if (a == 4 && b == 43) {
			System.out.println(-39);
		} else if (a == 4 && b == 44) {
			System.out.println(-40);
		} else if (a == 4 && b == 45) {
			System.out.println(-41);
		} else if (a == 4 && b == 46) {
			System.out.println(-42);
		} else if (a == 4 && b == 47) {
			System.out.println(-43);
		} else if (a == 4 && b == 48) {
			System.out.println(-44);
		} else if (a == 4 && b == 49) {
			System.out.println(-45);
		} else if (a == 4 && b == 50) {
			System.out.println(-46);
		} else if (a == 5 && b == 0) {
			System.out.println(5);
		} else if (a == 5 && b == 1) {
			System.out.println(4);
		} else if (a == 5 && b == 2) {
			System.out.println(3);
		} else if (a == 5 && b == 3) {
			System.out.println(2);
		} else if (a == 5 && b == 4) {
			System.out.println(1);
		} else if (a == 5 && b == 5) {
			System.out.println(0);
		} else if (a == 5 && b == 6) {
			System.out.println(-1);
		} else if (a == 5 && b == 7) {
			System.out.println(-2);
		} else if (a == 5 && b == 8) {
			System.out.println(-3);
		} else if (a == 5 && b == 9) {
			System.out.println(-4);
		} else if (a == 5 && b == 10) {
			System.out.println(-5);
		} else if (a == 5 && b == 11) {
			System.out.println(-6);
		} else if (a == 5 && b == 12) {
			System.out.println(-7);
		} else if (a == 5 && b == 13) {
			System.out.println(-8);
		} else if (a == 5 && b == 14) {
			System.out.println(-9);
		} else if (a == 5 && b == 15) {
			System.out.println(-10);
		} else if (a == 5 && b == 16) {
			System.out.println(-11);
		} else if (a == 5 && b == 17) {
			System.out.println(-12);
		} else if (a == 5 && b == 18) {
			System.out.println(-13);
		} else if (a == 5 && b == 19) {
			System.out.println(-14);
		} else if (a == 5 && b == 20) {
			System.out.println(-15);
		} else if (a == 5 && b == 21) {
			System.out.println(-16);
		} else if (a == 5 && b == 22) {
			System.out.println(-17);
		} else if (a == 5 && b == 23) {
			System.out.println(-18);
		} else if (a == 5 && b == 24) {
			System.out.println(-19);
		} else if (a == 5 && b == 25) {
			System.out.println(-20);
		} else if (a == 5 && b == 26) {
			System.out.println(-21);
		} else if (a == 5 && b == 27) {
			System.out.println(-22);
		} else if (a == 5 && b == 28) {
			System.out.println(-23);
		} else if (a == 5 && b == 29) {
			System.out.println(-24);
		} else if (a == 5 && b == 30) {
			System.out.println(-25);
		} else if (a == 5 && b == 31) {
			System.out.println(-26);
		} else if (a == 5 && b == 32) {
			System.out.println(-27);
		} else if (a == 5 && b == 33) {
			System.out.println(-28);
		} else if (a == 5 && b == 34) {
			System.out.println(-29);
		} else if (a == 5 && b == 35) {
			System.out.println(-30);
		} else if (a == 5 && b == 36) {
			System.out.println(-31);
		} else if (a == 5 && b == 37) {
			System.out.println(-32);
		} else if (a == 5 && b == 38) {
			System.out.println(-33);
		} else if (a == 5 && b == 39) {
			System.out.println(-34);
		} else if (a == 5 && b == 40) {
			System.out.println(-35);
		} else if (a == 5 && b == 41) {
			System.out.println(-36);
		} else if (a == 5 && b == 42) {
			System.out.println(-37);
		} else if (a == 5 && b == 43) {
			System.out.println(-38);
		} else if (a == 5 && b == 44) {
			System.out.println(-39);
		} else if (a == 5 && b == 45) {
			System.out.println(-40);
		} else if (a == 5 && b == 46) {
			System.out.println(-41);
		} else if (a == 5 && b == 47) {
			System.out.println(-42);
		} else if (a == 5 && b == 48) {
			System.out.println(-43);
		} else if (a == 5 && b == 49) {
			System.out.println(-44);
		} else if (a == 5 && b == 50) {
			System.out.println(-45);
		} else if (a == 6 && b == 0) {
			System.out.println(6);
		} else if (a == 6 && b == 1) {
			System.out.println(5);
		} else if (a == 6 && b == 2) {
			System.out.println(4);
		} else if (a == 6 && b == 3) {
			System.out.println(3);
		} else if (a == 6 && b == 4) {
			System.out.println(2);
		} else if (a == 6 && b == 5) {
			System.out.println(1);
		} else if (a == 6 && b == 6) {
			System.out.println(0);
		} else if (a == 6 && b == 7) {
			System.out.println(-1);
		} else if (a == 6 && b == 8) {
			System.out.println(-2);
		} else if (a == 6 && b == 9) {
			System.out.println(-3);
		} else if (a == 6 && b == 10) {
			System.out.println(-4);
		} else if (a == 6 && b == 11) {
			System.out.println(-5);
		} else if (a == 6 && b == 12) {
			System.out.println(-6);
		} else if (a == 6 && b == 13) {
			System.out.println(-7);
		} else if (a == 6 && b == 14) {
			System.out.println(-8);
		} else if (a == 6 && b == 15) {
			System.out.println(-9);
		} else if (a == 6 && b == 16) {
			System.out.println(-10);
		} else if (a == 6 && b == 17) {
			System.out.println(-11);
		} else if (a == 6 && b == 18) {
			System.out.println(-12);
		} else if (a == 6 && b == 19) {
			System.out.println(-13);
		} else if (a == 6 && b == 20) {
			System.out.println(-14);
		} else if (a == 6 && b == 21) {
			System.out.println(-15);
		} else if (a == 6 && b == 22) {
			System.out.println(-16);
		} else if (a == 6 && b == 23) {
			System.out.println(-17);
		} else if (a == 6 && b == 24) {
			System.out.println(-18);
		} else if (a == 6 && b == 25) {
			System.out.println(-19);
		} else if (a == 6 && b == 26) {
			System.out.println(-20);
		} else if (a == 6 && b == 27) {
			System.out.println(-21);
		} else if (a == 6 && b == 28) {
			System.out.println(-22);
		} else if (a == 6 && b == 29) {
			System.out.println(-23);
		} else if (a == 6 && b == 30) {
			System.out.println(-24);
		} else if (a == 6 && b == 31) {
			System.out.println(-25);
		} else if (a == 6 && b == 32) {
			System.out.println(-26);
		} else if (a == 6 && b == 33) {
			System.out.println(-27);
		} else if (a == 6 && b == 34) {
			System.out.println(-28);
		} else if (a == 6 && b == 35) {
			System.out.println(-29);
		} else if (a == 6 && b == 36) {
			System.out.println(-30);
		} else if (a == 6 && b == 37) {
			System.out.println(-31);
		} else if (a == 6 && b == 38) {
			System.out.println(-32);
		} else if (a == 6 && b == 39) {
			System.out.println(-33);
		} else if (a == 6 && b == 40) {
			System.out.println(-34);
		} else if (a == 6 && b == 41) {
			System.out.println(-35);
		} else if (a == 6 && b == 42) {
			System.out.println(-36);
		} else if (a == 6 && b == 43) {
			System.out.println(-37);
		} else if (a == 6 && b == 44) {
			System.out.println(-38);
		} else if (a == 6 && b == 45) {
			System.out.println(-39);
		} else if (a == 6 && b == 46) {
			System.out.println(-40);
		} else if (a == 6 && b == 47) {
			System.out.println(-41);
		} else if (a == 6 && b == 48) {
			System.out.println(-42);
		} else if (a == 6 && b == 49) {
			System.out.println(-43);
		} else if (a == 6 && b == 50) {
			System.out.println(-44);
		} else if (a == 7 && b == 0) {
			System.out.println(7);
		} else if (a == 7 && b == 1) {
			System.out.println(6);
		} else if (a == 7 && b == 2) {
			System.out.println(5);
		} else if (a == 7 && b == 3) {
			System.out.println(4);
		} else if (a == 7 && b == 4) {
			System.out.println(3);
		} else if (a == 7 && b == 5) {
			System.out.println(2);
		} else if (a == 7 && b == 6) {
			System.out.println(1);
		} else if (a == 7 && b == 7) {
			System.out.println(0);
		} else if (a == 7 && b == 8) {
			System.out.println(-1);
		} else if (a == 7 && b == 9) {
			System.out.println(-2);
		} else if (a == 7 && b == 10) {
			System.out.println(-3);
		} else if (a == 7 && b == 11) {
			System.out.println(-4);
		} else if (a == 7 && b == 12) {
			System.out.println(-5);
		} else if (a == 7 && b == 13) {
			System.out.println(-6);
		} else if (a == 7 && b == 14) {
			System.out.println(-7);
		} else if (a == 7 && b == 15) {
			System.out.println(-8);
		} else if (a == 7 && b == 16) {
			System.out.println(-9);
		} else if (a == 7 && b == 17) {
			System.out.println(-10);
		} else if (a == 7 && b == 18) {
			System.out.println(-11);
		} else if (a == 7 && b == 19) {
			System.out.println(-12);
		} else if (a == 7 && b == 20) {
			System.out.println(-13);
		} else if (a == 7 && b == 21) {
			System.out.println(-14);
		} else if (a == 7 && b == 22) {
			System.out.println(-15);
		} else if (a == 7 && b == 23) {
			System.out.println(-16);
		} else if (a == 7 && b == 24) {
			System.out.println(-17);
		} else if (a == 7 && b == 25) {
			System.out.println(-18);
		} else if (a == 7 && b == 26) {
			System.out.println(-19);
		} else if (a == 7 && b == 27) {
			System.out.println(-20);
		} else if (a == 7 && b == 28) {
			System.out.println(-21);
		} else if (a == 7 && b == 29) {
			System.out.println(-22);
		} else if (a == 7 && b == 30) {
			System.out.println(-23);
		} else if (a == 7 && b == 31) {
			System.out.println(-24);
		} else if (a == 7 && b == 32) {
			System.out.println(-25);
		} else if (a == 7 && b == 33) {
			System.out.println(-26);
		} else if (a == 7 && b == 34) {
			System.out.println(-27);
		} else if (a == 7 && b == 35) {
			System.out.println(-28);
		} else if (a == 7 && b == 36) {
			System.out.println(-29);
		} else if (a == 7 && b == 37) {
			System.out.println(-30);
		} else if (a == 7 && b == 38) {
			System.out.println(-31);
		} else if (a == 7 && b == 39) {
			System.out.println(-32);
		} else if (a == 7 && b == 40) {
			System.out.println(-33);
		} else if (a == 7 && b == 41) {
			System.out.println(-34);
		} else if (a == 7 && b == 42) {
			System.out.println(-35);
		} else if (a == 7 && b == 43) {
			System.out.println(-36);
		} else if (a == 7 && b == 44) {
			System.out.println(-37);
		} else if (a == 7 && b == 45) {
			System.out.println(-38);
		} else if (a == 7 && b == 46) {
			System.out.println(-39);
		} else if (a == 7 && b == 47) {
			System.out.println(-40);
		} else if (a == 7 && b == 48) {
			System.out.println(-41);
		} else if (a == 7 && b == 49) {
			System.out.println(-42);
		} else if (a == 7 && b == 50) {
			System.out.println(-43);
		} else if (a == 8 && b == 0) {
			System.out.println(8);
		} else if (a == 8 && b == 1) {
			System.out.println(7);
		} else if (a == 8 && b == 2) {
			System.out.println(6);
		} else if (a == 8 && b == 3) {
			System.out.println(5);
		} else if (a == 8 && b == 4) {
			System.out.println(4);
		} else if (a == 8 && b == 5) {
			System.out.println(3);
		} else if (a == 8 && b == 6) {
			System.out.println(2);
		} else if (a == 8 && b == 7) {
			System.out.println(1);
		} else if (a == 8 && b == 8) {
			System.out.println(0);
		} else if (a == 8 && b == 9) {
			System.out.println(-1);
		} else if (a == 8 && b == 10) {
			System.out.println(-2);
		} else if (a == 8 && b == 11) {
			System.out.println(-3);
		} else if (a == 8 && b == 12) {
			System.out.println(-4);
		} else if (a == 8 && b == 13) {
			System.out.println(-5);
		} else if (a == 8 && b == 14) {
			System.out.println(-6);
		} else if (a == 8 && b == 15) {
			System.out.println(-7);
		} else if (a == 8 && b == 16) {
			System.out.println(-8);
		} else if (a == 8 && b == 17) {
			System.out.println(-9);
		} else if (a == 8 && b == 18) {
			System.out.println(-10);
		} else if (a == 8 && b == 19) {
			System.out.println(-11);
		} else if (a == 8 && b == 20) {
			System.out.println(-12);
		} else if (a == 8 && b == 21) {
			System.out.println(-13);
		} else if (a == 8 && b == 22) {
			System.out.println(-14);
		} else if (a == 8 && b == 23) {
			System.out.println(-15);
		} else if (a == 8 && b == 24) {
			System.out.println(-16);
		} else if (a == 8 && b == 25) {
			System.out.println(-17);
		} else if (a == 8 && b == 26) {
			System.out.println(-18);
		} else if (a == 8 && b == 27) {
			System.out.println(-19);
		} else if (a == 8 && b == 28) {
			System.out.println(-20);
		} else if (a == 8 && b == 29) {
			System.out.println(-21);
		} else if (a == 8 && b == 30) {
			System.out.println(-22);
		} else if (a == 8 && b == 31) {
			System.out.println(-23);
		} else if (a == 8 && b == 32) {
			System.out.println(-24);
		} else if (a == 8 && b == 33) {
			System.out.println(-25);
		} else if (a == 8 && b == 34) {
			System.out.println(-26);
		} else if (a == 8 && b == 35) {
			System.out.println(-27);
		} else if (a == 8 && b == 36) {
			System.out.println(-28);
		} else if (a == 8 && b == 37) {
			System.out.println(-29);
		} else if (a == 8 && b == 38) {
			System.out.println(-30);
		} else if (a == 8 && b == 39) {
			System.out.println(-31);
		} else if (a == 8 && b == 40) {
			System.out.println(-32);
		} else if (a == 8 && b == 41) {
			System.out.println(-33);
		} else if (a == 8 && b == 42) {
			System.out.println(-34);
		} else if (a == 8 && b == 43) {
			System.out.println(-35);
		} else if (a == 8 && b == 44) {
			System.out.println(-36);
		} else if (a == 8 && b == 45) {
			System.out.println(-37);
		} else if (a == 8 && b == 46) {
			System.out.println(-38);
		} else if (a == 8 && b == 47) {
			System.out.println(-39);
		} else if (a == 8 && b == 48) {
			System.out.println(-40);
		} else if (a == 8 && b == 49) {
			System.out.println(-41);
		} else if (a == 8 && b == 50) {
			System.out.println(-42);
		} else if (a == 9 && b == 0) {
			System.out.println(9);
		} else if (a == 9 && b == 1) {
			System.out.println(8);
		} else if (a == 9 && b == 2) {
			System.out.println(7);
		} else if (a == 9 && b == 3) {
			System.out.println(6);
		} else if (a == 9 && b == 4) {
			System.out.println(5);
		} else if (a == 9 && b == 5) {
			System.out.println(4);
		} else if (a == 9 && b == 6) {
			System.out.println(3);
		} else if (a == 9 && b == 7) {
			System.out.println(2);
		} else if (a == 9 && b == 8) {
			System.out.println(1);
		} else if (a == 9 && b == 9) {
			System.out.println(0);
		} else if (a == 9 && b == 10) {
			System.out.println(-1);
		} else if (a == 9 && b == 11) {
			System.out.println(-2);
		} else if (a == 9 && b == 12) {
			System.out.println(-3);
		} else if (a == 9 && b == 13) {
			System.out.println(-4);
		} else if (a == 9 && b == 14) {
			System.out.println(-5);
		} else if (a == 9 && b == 15) {
			System.out.println(-6);
		} else if (a == 9 && b == 16) {
			System.out.println(-7);
		} else if (a == 9 && b == 17) {
			System.out.println(-8);
		} else if (a == 9 && b == 18) {
			System.out.println(-9);
		} else if (a == 9 && b == 19) {
			System.out.println(-10);
		} else if (a == 9 && b == 20) {
			System.out.println(-11);
		} else if (a == 9 && b == 21) {
			System.out.println(-12);
		} else if (a == 9 && b == 22) {
			System.out.println(-13);
		} else if (a == 9 && b == 23) {
			System.out.println(-14);
		} else if (a == 9 && b == 24) {
			System.out.println(-15);
		} else if (a == 9 && b == 25) {
			System.out.println(-16);
		} else if (a == 9 && b == 26) {
			System.out.println(-17);
		} else if (a == 9 && b == 27) {
			System.out.println(-18);
		} else if (a == 9 && b == 28) {
			System.out.println(-19);
		} else if (a == 9 && b == 29) {
			System.out.println(-20);
		} else if (a == 9 && b == 30) {
			System.out.println(-21);
		} else if (a == 9 && b == 31) {
			System.out.println(-22);
		} else if (a == 9 && b == 32) {
			System.out.println(-23);
		} else if (a == 9 && b == 33) {
			System.out.println(-24);
		} else if (a == 9 && b == 34) {
			System.out.println(-25);
		} else if (a == 9 && b == 35) {
			System.out.println(-26);
		} else if (a == 9 && b == 36) {
			System.out.println(-27);
		} else if (a == 9 && b == 37) {
			System.out.println(-28);
		} else if (a == 9 && b == 38) {
			System.out.println(-29);
		} else if (a == 9 && b == 39) {
			System.out.println(-30);
		} else if (a == 9 && b == 40) {
			System.out.println(-31);
		} else if (a == 9 && b == 41) {
			System.out.println(-32);
		} else if (a == 9 && b == 42) {
			System.out.println(-33);
		} else if (a == 9 && b == 43) {
			System.out.println(-34);
		} else if (a == 9 && b == 44) {
			System.out.println(-35);
		} else if (a == 9 && b == 45) {
			System.out.println(-36);
		} else if (a == 9 && b == 46) {
			System.out.println(-37);
		} else if (a == 9 && b == 47) {
			System.out.println(-38);
		} else if (a == 9 && b == 48) {
			System.out.println(-39);
		} else if (a == 9 && b == 49) {
			System.out.println(-40);
		} else if (a == 9 && b == 50) {
			System.out.println(-41);
		} else if (a == 10 && b == 0) {
			System.out.println(10);
		} else if (a == 10 && b == 1) {
			System.out.println(9);
		} else if (a == 10 && b == 2) {
			System.out.println(8);
		} else if (a == 10 && b == 3) {
			System.out.println(7);
		} else if (a == 10 && b == 4) {
			System.out.println(6);
		} else if (a == 10 && b == 5) {
			System.out.println(5);
		} else if (a == 10 && b == 6) {
			System.out.println(4);
		} else if (a == 10 && b == 7) {
			System.out.println(3);
		} else if (a == 10 && b == 8) {
			System.out.println(2);
		} else if (a == 10 && b == 9) {
			System.out.println(1);
		} else if (a == 10 && b == 10) {
			System.out.println(0);
		} else if (a == 10 && b == 11) {
			System.out.println(-1);
		} else if (a == 10 && b == 12) {
			System.out.println(-2);
		} else if (a == 10 && b == 13) {
			System.out.println(-3);
		} else if (a == 10 && b == 14) {
			System.out.println(-4);
		} else if (a == 10 && b == 15) {
			System.out.println(-5);
		} else if (a == 10 && b == 16) {
			System.out.println(-6);
		} else if (a == 10 && b == 17) {
			System.out.println(-7);
		} else if (a == 10 && b == 18) {
			System.out.println(-8);
		} else if (a == 10 && b == 19) {
			System.out.println(-9);
		} else if (a == 10 && b == 20) {
			System.out.println(-10);
		} else if (a == 10 && b == 21) {
			System.out.println(-11);
		} else if (a == 10 && b == 22) {
			System.out.println(-12);
		} else if (a == 10 && b == 23) {
			System.out.println(-13);
		} else if (a == 10 && b == 24) {
			System.out.println(-14);
		} else if (a == 10 && b == 25) {
			System.out.println(-15);
		} else if (a == 10 && b == 26) {
			System.out.println(-16);
		} else if (a == 10 && b == 27) {
			System.out.println(-17);
		} else if (a == 10 && b == 28) {
			System.out.println(-18);
		} else if (a == 10 && b == 29) {
			System.out.println(-19);
		} else if (a == 10 && b == 30) {
			System.out.println(-20);
		} else if (a == 10 && b == 31) {
			System.out.println(-21);
		} else if (a == 10 && b == 32) {
			System.out.println(-22);
		} else if (a == 10 && b == 33) {
			System.out.println(-23);
		} else if (a == 10 && b == 34) {
			System.out.println(-24);
		} else if (a == 10 && b == 35) {
			System.out.println(-25);
		} else if (a == 10 && b == 36) {
			System.out.println(-26);
		} else if (a == 10 && b == 37) {
			System.out.println(-27);
		} else if (a == 10 && b == 38) {
			System.out.println(-28);
		} else if (a == 10 && b == 39) {
			System.out.println(-29);
		} else if (a == 10 && b == 40) {
			System.out.println(-30);
		} else if (a == 10 && b == 41) {
			System.out.println(-31);
		} else if (a == 10 && b == 42) {
			System.out.println(-32);
		} else if (a == 10 && b == 43) {
			System.out.println(-33);
		} else if (a == 10 && b == 44) {
			System.out.println(-34);
		} else if (a == 10 && b == 45) {
			System.out.println(-35);
		} else if (a == 10 && b == 46) {
			System.out.println(-36);
		} else if (a == 10 && b == 47) {
			System.out.println(-37);
		} else if (a == 10 && b == 48) {
			System.out.println(-38);
		} else if (a == 10 && b == 49) {
			System.out.println(-39);
		} else if (a == 10 && b == 50) {
			System.out.println(-40);
		} else if (a == 11 && b == 0) {
			System.out.println(11);
		} else if (a == 11 && b == 1) {
			System.out.println(10);
		} else if (a == 11 && b == 2) {
			System.out.println(9);
		} else if (a == 11 && b == 3) {
			System.out.println(8);
		} else if (a == 11 && b == 4) {
			System.out.println(7);
		} else if (a == 11 && b == 5) {
			System.out.println(6);
		} else if (a == 11 && b == 6) {
			System.out.println(5);
		} else if (a == 11 && b == 7) {
			System.out.println(4);
		} else if (a == 11 && b == 8) {
			System.out.println(3);
		} else if (a == 11 && b == 9) {
			System.out.println(2);
		} else if (a == 11 && b == 10) {
			System.out.println(1);
		} else if (a == 11 && b == 11) {
			System.out.println(0);
		} else if (a == 11 && b == 12) {
			System.out.println(-1);
		} else if (a == 11 && b == 13) {
			System.out.println(-2);
		} else if (a == 11 && b == 14) {
			System.out.println(-3);
		} else if (a == 11 && b == 15) {
			System.out.println(-4);
		} else if (a == 11 && b == 16) {
			System.out.println(-5);
		} else if (a == 11 && b == 17) {
			System.out.println(-6);
		} else if (a == 11 && b == 18) {
			System.out.println(-7);
		} else if (a == 11 && b == 19) {
			System.out.println(-8);
		} else if (a == 11 && b == 20) {
			System.out.println(-9);
		} else if (a == 11 && b == 21) {
			System.out.println(-10);
		} else if (a == 11 && b == 22) {
			System.out.println(-11);
		} else if (a == 11 && b == 23) {
			System.out.println(-12);
		} else if (a == 11 && b == 24) {
			System.out.println(-13);
		} else if (a == 11 && b == 25) {
			System.out.println(-14);
		} else if (a == 11 && b == 26) {
			System.out.println(-15);
		} else if (a == 11 && b == 27) {
			System.out.println(-16);
		} else if (a == 11 && b == 28) {
			System.out.println(-17);
		} else if (a == 11 && b == 29) {
			System.out.println(-18);
		} else if (a == 11 && b == 30) {
			System.out.println(-19);
		} else if (a == 11 && b == 31) {
			System.out.println(-20);
		} else if (a == 11 && b == 32) {
			System.out.println(-21);
		} else if (a == 11 && b == 33) {
			System.out.println(-22);
		} else if (a == 11 && b == 34) {
			System.out.println(-23);
		} else if (a == 11 && b == 35) {
			System.out.println(-24);
		} else if (a == 11 && b == 36) {
			System.out.println(-25);
		} else if (a == 11 && b == 37) {
			System.out.println(-26);
		} else if (a == 11 && b == 38) {
			System.out.println(-27);
		} else if (a == 11 && b == 39) {
			System.out.println(-28);
		} else if (a == 11 && b == 40) {
			System.out.println(-29);
		} else if (a == 11 && b == 41) {
			System.out.println(-30);
		} else if (a == 11 && b == 42) {
			System.out.println(-31);
		} else if (a == 11 && b == 43) {
			System.out.println(-32);
		} else if (a == 11 && b == 44) {
			System.out.println(-33);
		} else if (a == 11 && b == 45) {
			System.out.println(-34);
		} else if (a == 11 && b == 46) {
			System.out.println(-35);
		} else if (a == 11 && b == 47) {
			System.out.println(-36);
		} else if (a == 11 && b == 48) {
			System.out.println(-37);
		} else if (a == 11 && b == 49) {
			System.out.println(-38);
		} else if (a == 11 && b == 50) {
			System.out.println(-39);
		} else if (a == 12 && b == 0) {
			System.out.println(12);
		} else if (a == 12 && b == 1) {
			System.out.println(11);
		} else if (a == 12 && b == 2) {
			System.out.println(10);
		} else if (a == 12 && b == 3) {
			System.out.println(9);
		} else if (a == 12 && b == 4) {
			System.out.println(8);
		} else if (a == 12 && b == 5) {
			System.out.println(7);
		} else if (a == 12 && b == 6) {
			System.out.println(6);
		} else if (a == 12 && b == 7) {
			System.out.println(5);
		} else if (a == 12 && b == 8) {
			System.out.println(4);
		} else if (a == 12 && b == 9) {
			System.out.println(3);
		} else if (a == 12 && b == 10) {
			System.out.println(2);
		} else if (a == 12 && b == 11) {
			System.out.println(1);
		} else if (a == 12 && b == 12) {
			System.out.println(0);
		} else if (a == 12 && b == 13) {
			System.out.println(-1);
		} else if (a == 12 && b == 14) {
			System.out.println(-2);
		} else if (a == 12 && b == 15) {
			System.out.println(-3);
		} else if (a == 12 && b == 16) {
			System.out.println(-4);
		} else if (a == 12 && b == 17) {
			System.out.println(-5);
		} else if (a == 12 && b == 18) {
			System.out.println(-6);
		} else if (a == 12 && b == 19) {
			System.out.println(-7);
		} else if (a == 12 && b == 20) {
			System.out.println(-8);
		} else if (a == 12 && b == 21) {
			System.out.println(-9);
		} else if (a == 12 && b == 22) {
			System.out.println(-10);
		} else if (a == 12 && b == 23) {
			System.out.println(-11);
		} else if (a == 12 && b == 24) {
			System.out.println(-12);
		} else if (a == 12 && b == 25) {
			System.out.println(-13);
		} else if (a == 12 && b == 26) {
			System.out.println(-14);
		} else if (a == 12 && b == 27) {
			System.out.println(-15);
		} else if (a == 12 && b == 28) {
			System.out.println(-16);
		} else if (a == 12 && b == 29) {
			System.out.println(-17);
		} else if (a == 12 && b == 30) {
			System.out.println(-18);
		} else if (a == 12 && b == 31) {
			System.out.println(-19);
		} else if (a == 12 && b == 32) {
			System.out.println(-20);
		} else if (a == 12 && b == 33) {
			System.out.println(-21);
		} else if (a == 12 && b == 34) {
			System.out.println(-22);
		} else if (a == 12 && b == 35) {
			System.out.println(-23);
		} else if (a == 12 && b == 36) {
			System.out.println(-24);
		} else if (a == 12 && b == 37) {
			System.out.println(-25);
		} else if (a == 12 && b == 38) {
			System.out.println(-26);
		} else if (a == 12 && b == 39) {
			System.out.println(-27);
		} else if (a == 12 && b == 40) {
			System.out.println(-28);
		} else if (a == 12 && b == 41) {
			System.out.println(-29);
		} else if (a == 12 && b == 42) {
			System.out.println(-30);
		} else if (a == 12 && b == 43) {
			System.out.println(-31);
		} else if (a == 12 && b == 44) {
			System.out.println(-32);
		} else if (a == 12 && b == 45) {
			System.out.println(-33);
		} else if (a == 12 && b == 46) {
			System.out.println(-34);
		} else if (a == 12 && b == 47) {
			System.out.println(-35);
		} else if (a == 12 && b == 48) {
			System.out.println(-36);
		} else if (a == 12 && b == 49) {
			System.out.println(-37);
		} else if (a == 12 && b == 50) {
			System.out.println(-38);
		} else if (a == 13 && b == 0) {
			System.out.println(13);
		} else if (a == 13 && b == 1) {
			System.out.println(12);
		} else if (a == 13 && b == 2) {
			System.out.println(11);
		} else if (a == 13 && b == 3) {
			System.out.println(10);
		} else if (a == 13 && b == 4) {
			System.out.println(9);
		} else if (a == 13 && b == 5) {
			System.out.println(8);
		} else if (a == 13 && b == 6) {
			System.out.println(7);
		} else if (a == 13 && b == 7) {
			System.out.println(6);
		} else if (a == 13 && b == 8) {
			System.out.println(5);
		} else if (a == 13 && b == 9) {
			System.out.println(4);
		} else if (a == 13 && b == 10) {
			System.out.println(3);
		} else if (a == 13 && b == 11) {
			System.out.println(2);
		} else if (a == 13 && b == 12) {
			System.out.println(1);
		} else if (a == 13 && b == 13) {
			System.out.println(0);
		} else if (a == 13 && b == 14) {
			System.out.println(-1);
		} else if (a == 13 && b == 15) {
			System.out.println(-2);
		} else if (a == 13 && b == 16) {
			System.out.println(-3);
		} else if (a == 13 && b == 17) {
			System.out.println(-4);
		} else if (a == 13 && b == 18) {
			System.out.println(-5);
		} else if (a == 13 && b == 19) {
			System.out.println(-6);
		} else if (a == 13 && b == 20) {
			System.out.println(-7);
		} else if (a == 13 && b == 21) {
			System.out.println(-8);
		} else if (a == 13 && b == 22) {
			System.out.println(-9);
		} else if (a == 13 && b == 23) {
			System.out.println(-10);
		} else if (a == 13 && b == 24) {
			System.out.println(-11);
		} else if (a == 13 && b == 25) {
			System.out.println(-12);
		} else if (a == 13 && b == 26) {
			System.out.println(-13);
		} else if (a == 13 && b == 27) {
			System.out.println(-14);
		} else if (a == 13 && b == 28) {
			System.out.println(-15);
		} else if (a == 13 && b == 29) {
			System.out.println(-16);
		} else if (a == 13 && b == 30) {
			System.out.println(-17);
		} else if (a == 13 && b == 31) {
			System.out.println(-18);
		} else if (a == 13 && b == 32) {
			System.out.println(-19);
		} else if (a == 13 && b == 33) {
			System.out.println(-20);
		} else if (a == 13 && b == 34) {
			System.out.println(-21);
		} else if (a == 13 && b == 35) {
			System.out.println(-22);
		} else if (a == 13 && b == 36) {
			System.out.println(-23);
		} else if (a == 13 && b == 37) {
			System.out.println(-24);
		} else if (a == 13 && b == 38) {
			System.out.println(-25);
		} else if (a == 13 && b == 39) {
			System.out.println(-26);
		} else if (a == 13 && b == 40) {
			System.out.println(-27);
		} else if (a == 13 && b == 41) {
			System.out.println(-28);
		} else if (a == 13 && b == 42) {
			System.out.println(-29);
		} else if (a == 13 && b == 43) {
			System.out.println(-30);
		} else if (a == 13 && b == 44) {
			System.out.println(-31);
		} else if (a == 13 && b == 45) {
			System.out.println(-32);
		} else if (a == 13 && b == 46) {
			System.out.println(-33);
		} else if (a == 13 && b == 47) {
			System.out.println(-34);
		} else if (a == 13 && b == 48) {
			System.out.println(-35);
		} else if (a == 13 && b == 49) {
			System.out.println(-36);
		} else if (a == 13 && b == 50) {
			System.out.println(-37);
		} else if (a == 14 && b == 0) {
			System.out.println(14);
		} else if (a == 14 && b == 1) {
			System.out.println(13);
		} else if (a == 14 && b == 2) {
			System.out.println(12);
		} else if (a == 14 && b == 3) {
			System.out.println(11);
		} else if (a == 14 && b == 4) {
			System.out.println(10);
		} else if (a == 14 && b == 5) {
			System.out.println(9);
		} else if (a == 14 && b == 6) {
			System.out.println(8);
		} else if (a == 14 && b == 7) {
			System.out.println(7);
		} else if (a == 14 && b == 8) {
			System.out.println(6);
		} else if (a == 14 && b == 9) {
			System.out.println(5);
		} else if (a == 14 && b == 10) {
			System.out.println(4);
		} else if (a == 14 && b == 11) {
			System.out.println(3);
		} else if (a == 14 && b == 12) {
			System.out.println(2);
		} else if (a == 14 && b == 13) {
			System.out.println(1);
		} else if (a == 14 && b == 14) {
			System.out.println(0);
		} else if (a == 14 && b == 15) {
			System.out.println(-1);
		} else if (a == 14 && b == 16) {
			System.out.println(-2);
		} else if (a == 14 && b == 17) {
			System.out.println(-3);
		} else if (a == 14 && b == 18) {
			System.out.println(-4);
		} else if (a == 14 && b == 19) {
			System.out.println(-5);
		} else if (a == 14 && b == 20) {
			System.out.println(-6);
		} else if (a == 14 && b == 21) {
			System.out.println(-7);
		} else if (a == 14 && b == 22) {
			System.out.println(-8);
		} else if (a == 14 && b == 23) {
			System.out.println(-9);
		} else if (a == 14 && b == 24) {
			System.out.println(-10);
		} else if (a == 14 && b == 25) {
			System.out.println(-11);
		} else if (a == 14 && b == 26) {
			System.out.println(-12);
		} else if (a == 14 && b == 27) {
			System.out.println(-13);
		} else if (a == 14 && b == 28) {
			System.out.println(-14);
		} else if (a == 14 && b == 29) {
			System.out.println(-15);
		} else if (a == 14 && b == 30) {
			System.out.println(-16);
		} else if (a == 14 && b == 31) {
			System.out.println(-17);
		} else if (a == 14 && b == 32) {
			System.out.println(-18);
		} else if (a == 14 && b == 33) {
			System.out.println(-19);
		} else if (a == 14 && b == 34) {
			System.out.println(-20);
		} else if (a == 14 && b == 35) {
			System.out.println(-21);
		} else if (a == 14 && b == 36) {
			System.out.println(-22);
		} else if (a == 14 && b == 37) {
			System.out.println(-23);
		} else if (a == 14 && b == 38) {
			System.out.println(-24);
		} else if (a == 14 && b == 39) {
			System.out.println(-25);
		} else if (a == 14 && b == 40) {
			System.out.println(-26);
		} else if (a == 14 && b == 41) {
			System.out.println(-27);
		} else if (a == 14 && b == 42) {
			System.out.println(-28);
		} else if (a == 14 && b == 43) {
			System.out.println(-29);
		} else if (a == 14 && b == 44) {
			System.out.println(-30);
		} else if (a == 14 && b == 45) {
			System.out.println(-31);
		} else if (a == 14 && b == 46) {
			System.out.println(-32);
		} else if (a == 14 && b == 47) {
			System.out.println(-33);
		} else if (a == 14 && b == 48) {
			System.out.println(-34);
		} else if (a == 14 && b == 49) {
			System.out.println(-35);
		} else if (a == 14 && b == 50) {
			System.out.println(-36);
		} else if (a == 15 && b == 0) {
			System.out.println(15);
		} else if (a == 15 && b == 1) {
			System.out.println(14);
		} else if (a == 15 && b == 2) {
			System.out.println(13);
		} else if (a == 15 && b == 3) {
			System.out.println(12);
		} else if (a == 15 && b == 4) {
			System.out.println(11);
		} else if (a == 15 && b == 5) {
			System.out.println(10);
		} else if (a == 15 && b == 6) {
			System.out.println(9);
		} else if (a == 15 && b == 7) {
			System.out.println(8);
		} else if (a == 15 && b == 8) {
			System.out.println(7);
		} else if (a == 15 && b == 9) {
			System.out.println(6);
		} else if (a == 15 && b == 10) {
			System.out.println(5);
		} else if (a == 15 && b == 11) {
			System.out.println(4);
		} else if (a == 15 && b == 12) {
			System.out.println(3);
		} else if (a == 15 && b == 13) {
			System.out.println(2);
		} else if (a == 15 && b == 14) {
			System.out.println(1);
		} else if (a == 15 && b == 15) {
			System.out.println(0);
		} else if (a == 15 && b == 16) {
			System.out.println(-1);
		} else if (a == 15 && b == 17) {
			System.out.println(-2);
		} else if (a == 15 && b == 18) {
			System.out.println(-3);
		} else if (a == 15 && b == 19) {
			System.out.println(-4);
		} else if (a == 15 && b == 20) {
			System.out.println(-5);
		} else if (a == 15 && b == 21) {
			System.out.println(-6);
		} else if (a == 15 && b == 22) {
			System.out.println(-7);
		} else if (a == 15 && b == 23) {
			System.out.println(-8);
		} else if (a == 15 && b == 24) {
			System.out.println(-9);
		} else if (a == 15 && b == 25) {
			System.out.println(-10);
		} else if (a == 15 && b == 26) {
			System.out.println(-11);
		} else if (a == 15 && b == 27) {
			System.out.println(-12);
		} else if (a == 15 && b == 28) {
			System.out.println(-13);
		} else if (a == 15 && b == 29) {
			System.out.println(-14);
		} else if (a == 15 && b == 30) {
			System.out.println(-15);
		} else if (a == 15 && b == 31) {
			System.out.println(-16);
		} else if (a == 15 && b == 32) {
			System.out.println(-17);
		} else if (a == 15 && b == 33) {
			System.out.println(-18);
		} else if (a == 15 && b == 34) {
			System.out.println(-19);
		} else if (a == 15 && b == 35) {
			System.out.println(-20);
		} else if (a == 15 && b == 36) {
			System.out.println(-21);
		} else if (a == 15 && b == 37) {
			System.out.println(-22);
		} else if (a == 15 && b == 38) {
			System.out.println(-23);
		} else if (a == 15 && b == 39) {
			System.out.println(-24);
		} else if (a == 15 && b == 40) {
			System.out.println(-25);
		} else if (a == 15 && b == 41) {
			System.out.println(-26);
		} else if (a == 15 && b == 42) {
			System.out.println(-27);
		} else if (a == 15 && b == 43) {
			System.out.println(-28);
		} else if (a == 15 && b == 44) {
			System.out.println(-29);
		} else if (a == 15 && b == 45) {
			System.out.println(-30);
		} else if (a == 15 && b == 46) {
			System.out.println(-31);
		} else if (a == 15 && b == 47) {
			System.out.println(-32);
		} else if (a == 15 && b == 48) {
			System.out.println(-33);
		} else if (a == 15 && b == 49) {
			System.out.println(-34);
		} else if (a == 15 && b == 50) {
			System.out.println(-35);
		} else if (a == 16 && b == 0) {
			System.out.println(16);
		} else if (a == 16 && b == 1) {
			System.out.println(15);
		} else if (a == 16 && b == 2) {
			System.out.println(14);
		} else if (a == 16 && b == 3) {
			System.out.println(13);
		} else if (a == 16 && b == 4) {
			System.out.println(12);
		} else if (a == 16 && b == 5) {
			System.out.println(11);
		} else if (a == 16 && b == 6) {
			System.out.println(10);
		} else if (a == 16 && b == 7) {
			System.out.println(9);
		} else if (a == 16 && b == 8) {
			System.out.println(8);
		} else if (a == 16 && b == 9) {
			System.out.println(7);
		} else if (a == 16 && b == 10) {
			System.out.println(6);
		} else if (a == 16 && b == 11) {
			System.out.println(5);
		} else if (a == 16 && b == 12) {
			System.out.println(4);
		} else if (a == 16 && b == 13) {
			System.out.println(3);
		} else if (a == 16 && b == 14) {
			System.out.println(2);
		} else if (a == 16 && b == 15) {
			System.out.println(1);
		} else if (a == 16 && b == 16) {
			System.out.println(0);
		} else if (a == 16 && b == 17) {
			System.out.println(-1);
		} else if (a == 16 && b == 18) {
			System.out.println(-2);
		} else if (a == 16 && b == 19) {
			System.out.println(-3);
		} else if (a == 16 && b == 20) {
			System.out.println(-4);
		} else if (a == 16 && b == 21) {
			System.out.println(-5);
		} else if (a == 16 && b == 22) {
			System.out.println(-6);
		} else if (a == 16 && b == 23) {
			System.out.println(-7);
		} else if (a == 16 && b == 24) {
			System.out.println(-8);
		} else if (a == 16 && b == 25) {
			System.out.println(-9);
		} else if (a == 16 && b == 26) {
			System.out.println(-10);
		} else if (a == 16 && b == 27) {
			System.out.println(-11);
		} else if (a == 16 && b == 28) {
			System.out.println(-12);
		} else if (a == 16 && b == 29) {
			System.out.println(-13);
		} else if (a == 16 && b == 30) {
			System.out.println(-14);
		} else if (a == 16 && b == 31) {
			System.out.println(-15);
		} else if (a == 16 && b == 32) {
			System.out.println(-16);
		} else if (a == 16 && b == 33) {
			System.out.println(-17);
		} else if (a == 16 && b == 34) {
			System.out.println(-18);
		} else if (a == 16 && b == 35) {
			System.out.println(-19);
		} else if (a == 16 && b == 36) {
			System.out.println(-20);
		} else if (a == 16 && b == 37) {
			System.out.println(-21);
		} else if (a == 16 && b == 38) {
			System.out.println(-22);
		} else if (a == 16 && b == 39) {
			System.out.println(-23);
		} else if (a == 16 && b == 40) {
			System.out.println(-24);
		} else if (a == 16 && b == 41) {
			System.out.println(-25);
		} else if (a == 16 && b == 42) {
			System.out.println(-26);
		} else if (a == 16 && b == 43) {
			System.out.println(-27);
		} else if (a == 16 && b == 44) {
			System.out.println(-28);
		} else if (a == 16 && b == 45) {
			System.out.println(-29);
		} else if (a == 16 && b == 46) {
			System.out.println(-30);
		} else if (a == 16 && b == 47) {
			System.out.println(-31);
		} else if (a == 16 && b == 48) {
			System.out.println(-32);
		} else if (a == 16 && b == 49) {
			System.out.println(-33);
		} else if (a == 16 && b == 50) {
			System.out.println(-34);
		} else if (a == 17 && b == 0) {
			System.out.println(17);
		} else if (a == 17 && b == 1) {
			System.out.println(16);
		} else if (a == 17 && b == 2) {
			System.out.println(15);
		} else if (a == 17 && b == 3) {
			System.out.println(14);
		} else if (a == 17 && b == 4) {
			System.out.println(13);
		} else if (a == 17 && b == 5) {
			System.out.println(12);
		} else if (a == 17 && b == 6) {
			System.out.println(11);
		} else if (a == 17 && b == 7) {
			System.out.println(10);
		} else if (a == 17 && b == 8) {
			System.out.println(9);
		} else if (a == 17 && b == 9) {
			System.out.println(8);
		} else if (a == 17 && b == 10) {
			System.out.println(7);
		} else if (a == 17 && b == 11) {
			System.out.println(6);
		} else if (a == 17 && b == 12) {
			System.out.println(5);
		} else if (a == 17 && b == 13) {
			System.out.println(4);
		} else if (a == 17 && b == 14) {
			System.out.println(3);
		} else if (a == 17 && b == 15) {
			System.out.println(2);
		} else if (a == 17 && b == 16) {
			System.out.println(1);
		} else if (a == 17 && b == 17) {
			System.out.println(0);
		} else if (a == 17 && b == 18) {
			System.out.println(-1);
		} else if (a == 17 && b == 19) {
			System.out.println(-2);
		} else if (a == 17 && b == 20) {
			System.out.println(-3);
		} else if (a == 17 && b == 21) {
			System.out.println(-4);
		} else if (a == 17 && b == 22) {
			System.out.println(-5);
		} else if (a == 17 && b == 23) {
			System.out.println(-6);
		} else if (a == 17 && b == 24) {
			System.out.println(-7);
		} else if (a == 17 && b == 25) {
			System.out.println(-8);
		} else if (a == 17 && b == 26) {
			System.out.println(-9);
		} else if (a == 17 && b == 27) {
			System.out.println(-10);
		} else if (a == 17 && b == 28) {
			System.out.println(-11);
		} else if (a == 17 && b == 29) {
			System.out.println(-12);
		} else if (a == 17 && b == 30) {
			System.out.println(-13);
		} else if (a == 17 && b == 31) {
			System.out.println(-14);
		} else if (a == 17 && b == 32) {
			System.out.println(-15);
		} else if (a == 17 && b == 33) {
			System.out.println(-16);
		} else if (a == 17 && b == 34) {
			System.out.println(-17);
		} else if (a == 17 && b == 35) {
			System.out.println(-18);
		} else if (a == 17 && b == 36) {
			System.out.println(-19);
		} else if (a == 17 && b == 37) {
			System.out.println(-20);
		} else if (a == 17 && b == 38) {
			System.out.println(-21);
		} else if (a == 17 && b == 39) {
			System.out.println(-22);
		} else if (a == 17 && b == 40) {
			System.out.println(-23);
		} else if (a == 17 && b == 41) {
			System.out.println(-24);
		} else if (a == 17 && b == 42) {
			System.out.println(-25);
		} else if (a == 17 && b == 43) {
			System.out.println(-26);
		} else if (a == 17 && b == 44) {
			System.out.println(-27);
		} else if (a == 17 && b == 45) {
			System.out.println(-28);
		} else if (a == 17 && b == 46) {
			System.out.println(-29);
		} else if (a == 17 && b == 47) {
			System.out.println(-30);
		} else if (a == 17 && b == 48) {
			System.out.println(-31);
		} else if (a == 17 && b == 49) {
			System.out.println(-32);
		} else if (a == 17 && b == 50) {
			System.out.println(-33);
		} else if (a == 18 && b == 0) {
			System.out.println(18);
		} else if (a == 18 && b == 1) {
			System.out.println(17);
		} else if (a == 18 && b == 2) {
			System.out.println(16);
		} else if (a == 18 && b == 3) {
			System.out.println(15);
		} else if (a == 18 && b == 4) {
			System.out.println(14);
		} else if (a == 18 && b == 5) {
			System.out.println(13);
		} else if (a == 18 && b == 6) {
			System.out.println(12);
		} else if (a == 18 && b == 7) {
			System.out.println(11);
		} else if (a == 18 && b == 8) {
			System.out.println(10);
		} else if (a == 18 && b == 9) {
			System.out.println(9);
		} else if (a == 18 && b == 10) {
			System.out.println(8);
		} else if (a == 18 && b == 11) {
			System.out.println(7);
		} else if (a == 18 && b == 12) {
			System.out.println(6);
		} else if (a == 18 && b == 13) {
			System.out.println(5);
		} else if (a == 18 && b == 14) {
			System.out.println(4);
		} else if (a == 18 && b == 15) {
			System.out.println(3);
		} else if (a == 18 && b == 16) {
			System.out.println(2);
		} else if (a == 18 && b == 17) {
			System.out.println(1);
		} else if (a == 18 && b == 18) {
			System.out.println(0);
		} else if (a == 18 && b == 19) {
			System.out.println(-1);
		} else if (a == 18 && b == 20) {
			System.out.println(-2);
		} else if (a == 18 && b == 21) {
			System.out.println(-3);
		} else if (a == 18 && b == 22) {
			System.out.println(-4);
		} else if (a == 18 && b == 23) {
			System.out.println(-5);
		} else if (a == 18 && b == 24) {
			System.out.println(-6);
		} else if (a == 18 && b == 25) {
			System.out.println(-7);
		} else if (a == 18 && b == 26) {
			System.out.println(-8);
		} else if (a == 18 && b == 27) {
			System.out.println(-9);
		} else if (a == 18 && b == 28) {
			System.out.println(-10);
		} else if (a == 18 && b == 29) {
			System.out.println(-11);
		} else if (a == 18 && b == 30) {
			System.out.println(-12);
		} else if (a == 18 && b == 31) {
			System.out.println(-13);
		} else if (a == 18 && b == 32) {
			System.out.println(-14);
		} else if (a == 18 && b == 33) {
			System.out.println(-15);
		} else if (a == 18 && b == 34) {
			System.out.println(-16);
		} else if (a == 18 && b == 35) {
			System.out.println(-17);
		} else if (a == 18 && b == 36) {
			System.out.println(-18);
		} else if (a == 18 && b == 37) {
			System.out.println(-19);
		} else if (a == 18 && b == 38) {
			System.out.println(-20);
		} else if (a == 18 && b == 39) {
			System.out.println(-21);
		} else if (a == 18 && b == 40) {
			System.out.println(-22);
		} else if (a == 18 && b == 41) {
			System.out.println(-23);
		} else if (a == 18 && b == 42) {
			System.out.println(-24);
		} else if (a == 18 && b == 43) {
			System.out.println(-25);
		} else if (a == 18 && b == 44) {
			System.out.println(-26);
		} else if (a == 18 && b == 45) {
			System.out.println(-27);
		} else if (a == 18 && b == 46) {
			System.out.println(-28);
		} else if (a == 18 && b == 47) {
			System.out.println(-29);
		} else if (a == 18 && b == 48) {
			System.out.println(-30);
		} else if (a == 18 && b == 49) {
			System.out.println(-31);
		} else if (a == 18 && b == 50) {
			System.out.println(-32);
		} else if (a == 19 && b == 0) {
			System.out.println(19);
		} else if (a == 19 && b == 1) {
			System.out.println(18);
		} else if (a == 19 && b == 2) {
			System.out.println(17);
		} else if (a == 19 && b == 3) {
			System.out.println(16);
		} else if (a == 19 && b == 4) {
			System.out.println(15);
		} else if (a == 19 && b == 5) {
			System.out.println(14);
		} else if (a == 19 && b == 6) {
			System.out.println(13);
		} else if (a == 19 && b == 7) {
			System.out.println(12);
		} else if (a == 19 && b == 8) {
			System.out.println(11);
		} else if (a == 19 && b == 9) {
			System.out.println(10);
		} else if (a == 19 && b == 10) {
			System.out.println(9);
		} else if (a == 19 && b == 11) {
			System.out.println(8);
		} else if (a == 19 && b == 12) {
			System.out.println(7);
		} else if (a == 19 && b == 13) {
			System.out.println(6);
		} else if (a == 19 && b == 14) {
			System.out.println(5);
		} else if (a == 19 && b == 15) {
			System.out.println(4);
		} else if (a == 19 && b == 16) {
			System.out.println(3);
		} else if (a == 19 && b == 17) {
			System.out.println(2);
		} else if (a == 19 && b == 18) {
			System.out.println(1);
		} else if (a == 19 && b == 19) {
			System.out.println(0);
		} else if (a == 19 && b == 20) {
			System.out.println(-1);
		} else if (a == 19 && b == 21) {
			System.out.println(-2);
		} else if (a == 19 && b == 22) {
			System.out.println(-3);
		} else if (a == 19 && b == 23) {
			System.out.println(-4);
		} else if (a == 19 && b == 24) {
			System.out.println(-5);
		} else if (a == 19 && b == 25) {
			System.out.println(-6);
		} else if (a == 19 && b == 26) {
			System.out.println(-7);
		} else if (a == 19 && b == 27) {
			System.out.println(-8);
		} else if (a == 19 && b == 28) {
			System.out.println(-9);
		} else if (a == 19 && b == 29) {
			System.out.println(-10);
		} else if (a == 19 && b == 30) {
			System.out.println(-11);
		} else if (a == 19 && b == 31) {
			System.out.println(-12);
		} else if (a == 19 && b == 32) {
			System.out.println(-13);
		} else if (a == 19 && b == 33) {
			System.out.println(-14);
		} else if (a == 19 && b == 34) {
			System.out.println(-15);
		} else if (a == 19 && b == 35) {
			System.out.println(-16);
		} else if (a == 19 && b == 36) {
			System.out.println(-17);
		} else if (a == 19 && b == 37) {
			System.out.println(-18);
		} else if (a == 19 && b == 38) {
			System.out.println(-19);
		} else if (a == 19 && b == 39) {
			System.out.println(-20);
		} else if (a == 19 && b == 40) {
			System.out.println(-21);
		} else if (a == 19 && b == 41) {
			System.out.println(-22);
		} else if (a == 19 && b == 42) {
			System.out.println(-23);
		} else if (a == 19 && b == 43) {
			System.out.println(-24);
		} else if (a == 19 && b == 44) {
			System.out.println(-25);
		} else if (a == 19 && b == 45) {
			System.out.println(-26);
		} else if (a == 19 && b == 46) {
			System.out.println(-27);
		} else if (a == 19 && b == 47) {
			System.out.println(-28);
		} else if (a == 19 && b == 48) {
			System.out.println(-29);
		} else if (a == 19 && b == 49) {
			System.out.println(-30);
		} else if (a == 19 && b == 50) {
			System.out.println(-31);
		} else if (a == 20 && b == 0) {
			System.out.println(20);
		} else if (a == 20 && b == 1) {
			System.out.println(19);
		} else if (a == 20 && b == 2) {
			System.out.println(18);
		} else if (a == 20 && b == 3) {
			System.out.println(17);
		} else if (a == 20 && b == 4) {
			System.out.println(16);
		} else if (a == 20 && b == 5) {
			System.out.println(15);
		} else if (a == 20 && b == 6) {
			System.out.println(14);
		} else if (a == 20 && b == 7) {
			System.out.println(13);
		} else if (a == 20 && b == 8) {
			System.out.println(12);
		} else if (a == 20 && b == 9) {
			System.out.println(11);
		} else if (a == 20 && b == 10) {
			System.out.println(10);
		} else if (a == 20 && b == 11) {
			System.out.println(9);
		} else if (a == 20 && b == 12) {
			System.out.println(8);
		} else if (a == 20 && b == 13) {
			System.out.println(7);
		} else if (a == 20 && b == 14) {
			System.out.println(6);
		} else if (a == 20 && b == 15) {
			System.out.println(5);
		} else if (a == 20 && b == 16) {
			System.out.println(4);
		} else if (a == 20 && b == 17) {
			System.out.println(3);
		} else if (a == 20 && b == 18) {
			System.out.println(2);
		} else if (a == 20 && b == 19) {
			System.out.println(1);
		} else if (a == 20 && b == 20) {
			System.out.println(0);
		} else if (a == 20 && b == 21) {
			System.out.println(-1);
		} else if (a == 20 && b == 22) {
			System.out.println(-2);
		} else if (a == 20 && b == 23) {
			System.out.println(-3);
		} else if (a == 20 && b == 24) {
			System.out.println(-4);
		} else if (a == 20 && b == 25) {
			System.out.println(-5);
		} else if (a == 20 && b == 26) {
			System.out.println(-6);
		} else if (a == 20 && b == 27) {
			System.out.println(-7);
		} else if (a == 20 && b == 28) {
			System.out.println(-8);
		} else if (a == 20 && b == 29) {
			System.out.println(-9);
		} else if (a == 20 && b == 30) {
			System.out.println(-10);
		} else if (a == 20 && b == 31) {
			System.out.println(-11);
		} else if (a == 20 && b == 32) {
			System.out.println(-12);
		} else if (a == 20 && b == 33) {
			System.out.println(-13);
		} else if (a == 20 && b == 34) {
			System.out.println(-14);
		} else if (a == 20 && b == 35) {
			System.out.println(-15);
		} else if (a == 20 && b == 36) {
			System.out.println(-16);
		} else if (a == 20 && b == 37) {
			System.out.println(-17);
		} else if (a == 20 && b == 38) {
			System.out.println(-18);
		} else if (a == 20 && b == 39) {
			System.out.println(-19);
		} else if (a == 20 && b == 40) {
			System.out.println(-20);
		} else if (a == 20 && b == 41) {
			System.out.println(-21);
		} else if (a == 20 && b == 42) {
			System.out.println(-22);
		} else if (a == 20 && b == 43) {
			System.out.println(-23);
		} else if (a == 20 && b == 44) {
			System.out.println(-24);
		} else if (a == 20 && b == 45) {
			System.out.println(-25);
		} else if (a == 20 && b == 46) {
			System.out.println(-26);
		} else if (a == 20 && b == 47) {
			System.out.println(-27);
		} else if (a == 20 && b == 48) {
			System.out.println(-28);
		} else if (a == 20 && b == 49) {
			System.out.println(-29);
		} else if (a == 20 && b == 50) {
			System.out.println(-30);
		} else if (a == 21 && b == 0) {
			System.out.println(21);
		} else if (a == 21 && b == 1) {
			System.out.println(20);
		} else if (a == 21 && b == 2) {
			System.out.println(19);
		} else if (a == 21 && b == 3) {
			System.out.println(18);
		} else if (a == 21 && b == 4) {
			System.out.println(17);
		} else if (a == 21 && b == 5) {
			System.out.println(16);
		} else if (a == 21 && b == 6) {
			System.out.println(15);
		} else if (a == 21 && b == 7) {
			System.out.println(14);
		} else if (a == 21 && b == 8) {
			System.out.println(13);
		} else if (a == 21 && b == 9) {
			System.out.println(12);
		} else if (a == 21 && b == 10) {
			System.out.println(11);
		} else if (a == 21 && b == 11) {
			System.out.println(10);
		} else if (a == 21 && b == 12) {
			System.out.println(9);
		} else if (a == 21 && b == 13) {
			System.out.println(8);
		} else if (a == 21 && b == 14) {
			System.out.println(7);
		} else if (a == 21 && b == 15) {
			System.out.println(6);
		} else if (a == 21 && b == 16) {
			System.out.println(5);
		} else if (a == 21 && b == 17) {
			System.out.println(4);
		} else if (a == 21 && b == 18) {
			System.out.println(3);
		} else if (a == 21 && b == 19) {
			System.out.println(2);
		} else if (a == 21 && b == 20) {
			System.out.println(1);
		} else if (a == 21 && b == 21) {
			System.out.println(0);
		} else if (a == 21 && b == 22) {
			System.out.println(-1);
		} else if (a == 21 && b == 23) {
			System.out.println(-2);
		} else if (a == 21 && b == 24) {
			System.out.println(-3);
		} else if (a == 21 && b == 25) {
			System.out.println(-4);
		} else if (a == 21 && b == 26) {
			System.out.println(-5);
		} else if (a == 21 && b == 27) {
			System.out.println(-6);
		} else if (a == 21 && b == 28) {
			System.out.println(-7);
		} else if (a == 21 && b == 29) {
			System.out.println(-8);
		} else if (a == 21 && b == 30) {
			System.out.println(-9);
		} else if (a == 21 && b == 31) {
			System.out.println(-10);
		} else if (a == 21 && b == 32) {
			System.out.println(-11);
		} else if (a == 21 && b == 33) {
			System.out.println(-12);
		} else if (a == 21 && b == 34) {
			System.out.println(-13);
		} else if (a == 21 && b == 35) {
			System.out.println(-14);
		} else if (a == 21 && b == 36) {
			System.out.println(-15);
		} else if (a == 21 && b == 37) {
			System.out.println(-16);
		} else if (a == 21 && b == 38) {
			System.out.println(-17);
		} else if (a == 21 && b == 39) {
			System.out.println(-18);
		} else if (a == 21 && b == 40) {
			System.out.println(-19);
		} else if (a == 21 && b == 41) {
			System.out.println(-20);
		} else if (a == 21 && b == 42) {
			System.out.println(-21);
		} else if (a == 21 && b == 43) {
			System.out.println(-22);
		} else if (a == 21 && b == 44) {
			System.out.println(-23);
		} else if (a == 21 && b == 45) {
			System.out.println(-24);
		} else if (a == 21 && b == 46) {
			System.out.println(-25);
		} else if (a == 21 && b == 47) {
			System.out.println(-26);
		} else if (a == 21 && b == 48) {
			System.out.println(-27);
		} else if (a == 21 && b == 49) {
			System.out.println(-28);
		} else if (a == 21 && b == 50) {
			System.out.println(-29);
		} else if (a == 22 && b == 0) {
			System.out.println(22);
		} else if (a == 22 && b == 1) {
			System.out.println(21);
		} else if (a == 22 && b == 2) {
			System.out.println(20);
		} else if (a == 22 && b == 3) {
			System.out.println(19);
		} else if (a == 22 && b == 4) {
			System.out.println(18);
		} else if (a == 22 && b == 5) {
			System.out.println(17);
		} else if (a == 22 && b == 6) {
			System.out.println(16);
		} else if (a == 22 && b == 7) {
			System.out.println(15);
		} else if (a == 22 && b == 8) {
			System.out.println(14);
		} else if (a == 22 && b == 9) {
			System.out.println(13);
		} else if (a == 22 && b == 10) {
			System.out.println(12);
		} else if (a == 22 && b == 11) {
			System.out.println(11);
		} else if (a == 22 && b == 12) {
			System.out.println(10);
		} else if (a == 22 && b == 13) {
			System.out.println(9);
		} else if (a == 22 && b == 14) {
			System.out.println(8);
		} else if (a == 22 && b == 15) {
			System.out.println(7);
		} else if (a == 22 && b == 16) {
			System.out.println(6);
		} else if (a == 22 && b == 17) {
			System.out.println(5);
		} else if (a == 22 && b == 18) {
			System.out.println(4);
		} else if (a == 22 && b == 19) {
			System.out.println(3);
		} else if (a == 22 && b == 20) {
			System.out.println(2);
		} else if (a == 22 && b == 21) {
			System.out.println(1);
		} else if (a == 22 && b == 22) {
			System.out.println(0);
		} else if (a == 22 && b == 23) {
			System.out.println(-1);
		} else if (a == 22 && b == 24) {
			System.out.println(-2);
		} else if (a == 22 && b == 25) {
			System.out.println(-3);
		} else if (a == 22 && b == 26) {
			System.out.println(-4);
		} else if (a == 22 && b == 27) {
			System.out.println(-5);
		} else if (a == 22 && b == 28) {
			System.out.println(-6);
		} else if (a == 22 && b == 29) {
			System.out.println(-7);
		} else if (a == 22 && b == 30) {
			System.out.println(-8);
		} else if (a == 22 && b == 31) {
			System.out.println(-9);
		} else if (a == 22 && b == 32) {
			System.out.println(-10);
		} else if (a == 22 && b == 33) {
			System.out.println(-11);
		} else if (a == 22 && b == 34) {
			System.out.println(-12);
		} else if (a == 22 && b == 35) {
			System.out.println(-13);
		} else if (a == 22 && b == 36) {
			System.out.println(-14);
		} else if (a == 22 && b == 37) {
			System.out.println(-15);
		} else if (a == 22 && b == 38) {
			System.out.println(-16);
		} else if (a == 22 && b == 39) {
			System.out.println(-17);
		} else if (a == 22 && b == 40) {
			System.out.println(-18);
		} else if (a == 22 && b == 41) {
			System.out.println(-19);
		} else if (a == 22 && b == 42) {
			System.out.println(-20);
		} else if (a == 22 && b == 43) {
			System.out.println(-21);
		} else if (a == 22 && b == 44) {
			System.out.println(-22);
		} else if (a == 22 && b == 45) {
			System.out.println(-23);
		} else if (a == 22 && b == 46) {
			System.out.println(-24);
		} else if (a == 22 && b == 47) {
			System.out.println(-25);
		} else if (a == 22 && b == 48) {
			System.out.println(-26);
		} else if (a == 22 && b == 49) {
			System.out.println(-27);
		} else if (a == 22 && b == 50) {
			System.out.println(-28);
		} else if (a == 23 && b == 0) {
			System.out.println(23);
		} else if (a == 23 && b == 1) {
			System.out.println(22);
		} else if (a == 23 && b == 2) {
			System.out.println(21);
		} else if (a == 23 && b == 3) {
			System.out.println(20);
		} else if (a == 23 && b == 4) {
			System.out.println(19);
		} else if (a == 23 && b == 5) {
			System.out.println(18);
		} else if (a == 23 && b == 6) {
			System.out.println(17);
		} else if (a == 23 && b == 7) {
			System.out.println(16);
		} else if (a == 23 && b == 8) {
			System.out.println(15);
		} else if (a == 23 && b == 9) {
			System.out.println(14);
		} else if (a == 23 && b == 10) {
			System.out.println(13);
		} else if (a == 23 && b == 11) {
			System.out.println(12);
		} else if (a == 23 && b == 12) {
			System.out.println(11);
		} else if (a == 23 && b == 13) {
			System.out.println(10);
		} else if (a == 23 && b == 14) {
			System.out.println(9);
		} else if (a == 23 && b == 15) {
			System.out.println(8);
		} else if (a == 23 && b == 16) {
			System.out.println(7);
		} else if (a == 23 && b == 17) {
			System.out.println(6);
		} else if (a == 23 && b == 18) {
			System.out.println(5);
		} else if (a == 23 && b == 19) {
			System.out.println(4);
		} else if (a == 23 && b == 20) {
			System.out.println(3);
		} else if (a == 23 && b == 21) {
			System.out.println(2);
		} else if (a == 23 && b == 22) {
			System.out.println(1);
		} else if (a == 23 && b == 23) {
			System.out.println(0);
		} else if (a == 23 && b == 24) {
			System.out.println(-1);
		} else if (a == 23 && b == 25) {
			System.out.println(-2);
		} else if (a == 23 && b == 26) {
			System.out.println(-3);
		} else if (a == 23 && b == 27) {
			System.out.println(-4);
		} else if (a == 23 && b == 28) {
			System.out.println(-5);
		} else if (a == 23 && b == 29) {
			System.out.println(-6);
		} else if (a == 23 && b == 30) {
			System.out.println(-7);
		} else if (a == 23 && b == 31) {
			System.out.println(-8);
		} else if (a == 23 && b == 32) {
			System.out.println(-9);
		} else if (a == 23 && b == 33) {
			System.out.println(-10);
		} else if (a == 23 && b == 34) {
			System.out.println(-11);
		} else if (a == 23 && b == 35) {
			System.out.println(-12);
		} else if (a == 23 && b == 36) {
			System.out.println(-13);
		} else if (a == 23 && b == 37) {
			System.out.println(-14);
		} else if (a == 23 && b == 38) {
			System.out.println(-15);
		} else if (a == 23 && b == 39) {
			System.out.println(-16);
		} else if (a == 23 && b == 40) {
			System.out.println(-17);
		} else if (a == 23 && b == 41) {
			System.out.println(-18);
		} else if (a == 23 && b == 42) {
			System.out.println(-19);
		} else if (a == 23 && b == 43) {
			System.out.println(-20);
		} else if (a == 23 && b == 44) {
			System.out.println(-21);
		} else if (a == 23 && b == 45) {
			System.out.println(-22);
		} else if (a == 23 && b == 46) {
			System.out.println(-23);
		} else if (a == 23 && b == 47) {
			System.out.println(-24);
		} else if (a == 23 && b == 48) {
			System.out.println(-25);
		} else if (a == 23 && b == 49) {
			System.out.println(-26);
		} else if (a == 23 && b == 50) {
			System.out.println(-27);
		} else if (a == 24 && b == 0) {
			System.out.println(24);
		} else if (a == 24 && b == 1) {
			System.out.println(23);
		} else if (a == 24 && b == 2) {
			System.out.println(22);
		} else if (a == 24 && b == 3) {
			System.out.println(21);
		} else if (a == 24 && b == 4) {
			System.out.println(20);
		} else if (a == 24 && b == 5) {
			System.out.println(19);
		} else if (a == 24 && b == 6) {
			System.out.println(18);
		} else if (a == 24 && b == 7) {
			System.out.println(17);
		} else if (a == 24 && b == 8) {
			System.out.println(16);
		} else if (a == 24 && b == 9) {
			System.out.println(15);
		} else if (a == 24 && b == 10) {
			System.out.println(14);
		} else if (a == 24 && b == 11) {
			System.out.println(13);
		} else if (a == 24 && b == 12) {
			System.out.println(12);
		} else if (a == 24 && b == 13) {
			System.out.println(11);
		} else if (a == 24 && b == 14) {
			System.out.println(10);
		} else if (a == 24 && b == 15) {
			System.out.println(9);
		} else if (a == 24 && b == 16) {
			System.out.println(8);
		} else if (a == 24 && b == 17) {
			System.out.println(7);
		} else if (a == 24 && b == 18) {
			System.out.println(6);
		} else if (a == 24 && b == 19) {
			System.out.println(5);
		} else if (a == 24 && b == 20) {
			System.out.println(4);
		} else if (a == 24 && b == 21) {
			System.out.println(3);
		} else if (a == 24 && b == 22) {
			System.out.println(2);
		} else if (a == 24 && b == 23) {
			System.out.println(1);
		} else if (a == 24 && b == 24) {
			System.out.println(0);
		} else if (a == 24 && b == 25) {
			System.out.println(-1);
		} else if (a == 24 && b == 26) {
			System.out.println(-2);
		} else if (a == 24 && b == 27) {
			System.out.println(-3);
		} else if (a == 24 && b == 28) {
			System.out.println(-4);
		} else if (a == 24 && b == 29) {
			System.out.println(-5);
		} else if (a == 24 && b == 30) {
			System.out.println(-6);
		} else if (a == 24 && b == 31) {
			System.out.println(-7);
		} else if (a == 24 && b == 32) {
			System.out.println(-8);
		} else if (a == 24 && b == 33) {
			System.out.println(-9);
		} else if (a == 24 && b == 34) {
			System.out.println(-10);
		} else if (a == 24 && b == 35) {
			System.out.println(-11);
		} else if (a == 24 && b == 36) {
			System.out.println(-12);
		} else if (a == 24 && b == 37) {
			System.out.println(-13);
		} else if (a == 24 && b == 38) {
			System.out.println(-14);
		} else if (a == 24 && b == 39) {
			System.out.println(-15);
		} else if (a == 24 && b == 40) {
			System.out.println(-16);
		} else if (a == 24 && b == 41) {
			System.out.println(-17);
		} else if (a == 24 && b == 42) {
			System.out.println(-18);
		} else if (a == 24 && b == 43) {
			System.out.println(-19);
		} else if (a == 24 && b == 44) {
			System.out.println(-20);
		} else if (a == 24 && b == 45) {
			System.out.println(-21);
		} else if (a == 24 && b == 46) {
			System.out.println(-22);
		} else if (a == 24 && b == 47) {
			System.out.println(-23);
		} else if (a == 24 && b == 48) {
			System.out.println(-24);
		} else if (a == 24 && b == 49) {
			System.out.println(-25);
		} else if (a == 24 && b == 50) {
			System.out.println(-26);
		} else if (a == 25 && b == 0) {
			System.out.println(25);
		} else if (a == 25 && b == 1) {
			System.out.println(24);
		} else if (a == 25 && b == 2) {
			System.out.println(23);
		} else if (a == 25 && b == 3) {
			System.out.println(22);
		} else if (a == 25 && b == 4) {
			System.out.println(21);
		} else if (a == 25 && b == 5) {
			System.out.println(20);
		} else if (a == 25 && b == 6) {
			System.out.println(19);
		} else if (a == 25 && b == 7) {
			System.out.println(18);
		} else if (a == 25 && b == 8) {
			System.out.println(17);
		} else if (a == 25 && b == 9) {
			System.out.println(16);
		} else if (a == 25 && b == 10) {
			System.out.println(15);
		} else if (a == 25 && b == 11) {
			System.out.println(14);
		} else if (a == 25 && b == 12) {
			System.out.println(13);
		} else if (a == 25 && b == 13) {
			System.out.println(12);
		} else if (a == 25 && b == 14) {
			System.out.println(11);
		} else if (a == 25 && b == 15) {
			System.out.println(10);
		} else if (a == 25 && b == 16) {
			System.out.println(9);
		} else if (a == 25 && b == 17) {
			System.out.println(8);
		} else if (a == 25 && b == 18) {
			System.out.println(7);
		} else if (a == 25 && b == 19) {
			System.out.println(6);
		} else if (a == 25 && b == 20) {
			System.out.println(5);
		} else if (a == 25 && b == 21) {
			System.out.println(4);
		} else if (a == 25 && b == 22) {
			System.out.println(3);
		} else if (a == 25 && b == 23) {
			System.out.println(2);
		} else if (a == 25 && b == 24) {
			System.out.println(1);
		} else if (a == 25 && b == 25) {
			System.out.println(0);
		} else if (a == 25 && b == 26) {
			System.out.println(-1);
		} else if (a == 25 && b == 27) {
			System.out.println(-2);
		} else if (a == 25 && b == 28) {
			System.out.println(-3);
		} else if (a == 25 && b == 29) {
			System.out.println(-4);
		} else if (a == 25 && b == 30) {
			System.out.println(-5);
		} else if (a == 25 && b == 31) {
			System.out.println(-6);
		} else if (a == 25 && b == 32) {
			System.out.println(-7);
		} else if (a == 25 && b == 33) {
			System.out.println(-8);
		} else if (a == 25 && b == 34) {
			System.out.println(-9);
		} else if (a == 25 && b == 35) {
			System.out.println(-10);
		} else if (a == 25 && b == 36) {
			System.out.println(-11);
		} else if (a == 25 && b == 37) {
			System.out.println(-12);
		} else if (a == 25 && b == 38) {
			System.out.println(-13);
		} else if (a == 25 && b == 39) {
			System.out.println(-14);
		} else if (a == 25 && b == 40) {
			System.out.println(-15);
		} else if (a == 25 && b == 41) {
			System.out.println(-16);
		} else if (a == 25 && b == 42) {
			System.out.println(-17);
		} else if (a == 25 && b == 43) {
			System.out.println(-18);
		} else if (a == 25 && b == 44) {
			System.out.println(-19);
		} else if (a == 25 && b == 45) {
			System.out.println(-20);
		} else if (a == 25 && b == 46) {
			System.out.println(-21);
		} else if (a == 25 && b == 47) {
			System.out.println(-22);
		} else if (a == 25 && b == 48) {
			System.out.println(-23);
		} else if (a == 25 && b == 49) {
			System.out.println(-24);
		} else if (a == 25 && b == 50) {
			System.out.println(-25);
		} else if (a == 26 && b == 0) {
			System.out.println(26);
		} else if (a == 26 && b == 1) {
			System.out.println(25);
		} else if (a == 26 && b == 2) {
			System.out.println(24);
		} else if (a == 26 && b == 3) {
			System.out.println(23);
		} else if (a == 26 && b == 4) {
			System.out.println(22);
		} else if (a == 26 && b == 5) {
			System.out.println(21);
		} else if (a == 26 && b == 6) {
			System.out.println(20);
		} else if (a == 26 && b == 7) {
			System.out.println(19);
		} else if (a == 26 && b == 8) {
			System.out.println(18);
		} else if (a == 26 && b == 9) {
			System.out.println(17);
		} else if (a == 26 && b == 10) {
			System.out.println(16);
		} else if (a == 26 && b == 11) {
			System.out.println(15);
		} else if (a == 26 && b == 12) {
			System.out.println(14);
		} else if (a == 26 && b == 13) {
			System.out.println(13);
		} else if (a == 26 && b == 14) {
			System.out.println(12);
		} else if (a == 26 && b == 15) {
			System.out.println(11);
		} else if (a == 26 && b == 16) {
			System.out.println(10);
		} else if (a == 26 && b == 17) {
			System.out.println(9);
		} else if (a == 26 && b == 18) {
			System.out.println(8);
		} else if (a == 26 && b == 19) {
			System.out.println(7);
		} else if (a == 26 && b == 20) {
			System.out.println(6);
		} else if (a == 26 && b == 21) {
			System.out.println(5);
		} else if (a == 26 && b == 22) {
			System.out.println(4);
		} else if (a == 26 && b == 23) {
			System.out.println(3);
		} else if (a == 26 && b == 24) {
			System.out.println(2);
		} else if (a == 26 && b == 25) {
			System.out.println(1);
		} else if (a == 26 && b == 26) {
			System.out.println(0);
		} else if (a == 26 && b == 27) {
			System.out.println(-1);
		} else if (a == 26 && b == 28) {
			System.out.println(-2);
		} else if (a == 26 && b == 29) {
			System.out.println(-3);
		} else if (a == 26 && b == 30) {
			System.out.println(-4);
		} else if (a == 26 && b == 31) {
			System.out.println(-5);
		} else if (a == 26 && b == 32) {
			System.out.println(-6);
		} else if (a == 26 && b == 33) {
			System.out.println(-7);
		} else if (a == 26 && b == 34) {
			System.out.println(-8);
		} else if (a == 26 && b == 35) {
			System.out.println(-9);
		} else if (a == 26 && b == 36) {
			System.out.println(-10);
		} else if (a == 26 && b == 37) {
			System.out.println(-11);
		} else if (a == 26 && b == 38) {
			System.out.println(-12);
		} else if (a == 26 && b == 39) {
			System.out.println(-13);
		} else if (a == 26 && b == 40) {
			System.out.println(-14);
		} else if (a == 26 && b == 41) {
			System.out.println(-15);
		} else if (a == 26 && b == 42) {
			System.out.println(-16);
		} else if (a == 26 && b == 43) {
			System.out.println(-17);
		} else if (a == 26 && b == 44) {
			System.out.println(-18);
		} else if (a == 26 && b == 45) {
			System.out.println(-19);
		} else if (a == 26 && b == 46) {
			System.out.println(-20);
		} else if (a == 26 && b == 47) {
			System.out.println(-21);
		} else if (a == 26 && b == 48) {
			System.out.println(-22);
		} else if (a == 26 && b == 49) {
			System.out.println(-23);
		} else if (a == 26 && b == 50) {
			System.out.println(-24);
		} else if (a == 27 && b == 0) {
			System.out.println(27);
		} else if (a == 27 && b == 1) {
			System.out.println(26);
		} else if (a == 27 && b == 2) {
			System.out.println(25);
		} else if (a == 27 && b == 3) {
			System.out.println(24);
		} else if (a == 27 && b == 4) {
			System.out.println(23);
		} else if (a == 27 && b == 5) {
			System.out.println(22);
		} else if (a == 27 && b == 6) {
			System.out.println(21);
		} else if (a == 27 && b == 7) {
			System.out.println(20);
		} else if (a == 27 && b == 8) {
			System.out.println(19);
		} else if (a == 27 && b == 9) {
			System.out.println(18);
		} else if (a == 27 && b == 10) {
			System.out.println(17);
		} else if (a == 27 && b == 11) {
			System.out.println(16);
		} else if (a == 27 && b == 12) {
			System.out.println(15);
		} else if (a == 27 && b == 13) {
			System.out.println(14);
		} else if (a == 27 && b == 14) {
			System.out.println(13);
		} else if (a == 27 && b == 15) {
			System.out.println(12);
		} else if (a == 27 && b == 16) {
			System.out.println(11);
		} else if (a == 27 && b == 17) {
			System.out.println(10);
		} else if (a == 27 && b == 18) {
			System.out.println(9);
		} else if (a == 27 && b == 19) {
			System.out.println(8);
		} else if (a == 27 && b == 20) {
			System.out.println(7);
		} else if (a == 27 && b == 21) {
			System.out.println(6);
		} else if (a == 27 && b == 22) {
			System.out.println(5);
		} else if (a == 27 && b == 23) {
			System.out.println(4);
		} else if (a == 27 && b == 24) {
			System.out.println(3);
		} else if (a == 27 && b == 25) {
			System.out.println(2);
		} else if (a == 27 && b == 26) {
			System.out.println(1);
		} else if (a == 27 && b == 27) {
			System.out.println(0);
		} else if (a == 27 && b == 28) {
			System.out.println(-1);
		} else if (a == 27 && b == 29) {
			System.out.println(-2);
		} else if (a == 27 && b == 30) {
			System.out.println(-3);
		} else if (a == 27 && b == 31) {
			System.out.println(-4);
		} else if (a == 27 && b == 32) {
			System.out.println(-5);
		} else if (a == 27 && b == 33) {
			System.out.println(-6);
		} else if (a == 27 && b == 34) {
			System.out.println(-7);
		} else if (a == 27 && b == 35) {
			System.out.println(-8);
		} else if (a == 27 && b == 36) {
			System.out.println(-9);
		} else if (a == 27 && b == 37) {
			System.out.println(-10);
		} else if (a == 27 && b == 38) {
			System.out.println(-11);
		} else if (a == 27 && b == 39) {
			System.out.println(-12);
		} else if (a == 27 && b == 40) {
			System.out.println(-13);
		} else if (a == 27 && b == 41) {
			System.out.println(-14);
		} else if (a == 27 && b == 42) {
			System.out.println(-15);
		} else if (a == 27 && b == 43) {
			System.out.println(-16);
		} else if (a == 27 && b == 44) {
			System.out.println(-17);
		} else if (a == 27 && b == 45) {
			System.out.println(-18);
		} else if (a == 27 && b == 46) {
			System.out.println(-19);
		} else if (a == 27 && b == 47) {
			System.out.println(-20);
		} else if (a == 27 && b == 48) {
			System.out.println(-21);
		} else if (a == 27 && b == 49) {
			System.out.println(-22);
		} else if (a == 27 && b == 50) {
			System.out.println(-23);
		} else if (a == 28 && b == 0) {
			System.out.println(28);
		} else if (a == 28 && b == 1) {
			System.out.println(27);
		} else if (a == 28 && b == 2) {
			System.out.println(26);
		} else if (a == 28 && b == 3) {
			System.out.println(25);
		} else if (a == 28 && b == 4) {
			System.out.println(24);
		} else if (a == 28 && b == 5) {
			System.out.println(23);
		} else if (a == 28 && b == 6) {
			System.out.println(22);
		} else if (a == 28 && b == 7) {
			System.out.println(21);
		} else if (a == 28 && b == 8) {
			System.out.println(20);
		} else if (a == 28 && b == 9) {
			System.out.println(19);
		} else if (a == 28 && b == 10) {
			System.out.println(18);
		} else if (a == 28 && b == 11) {
			System.out.println(17);
		} else if (a == 28 && b == 12) {
			System.out.println(16);
		} else if (a == 28 && b == 13) {
			System.out.println(15);
		} else if (a == 28 && b == 14) {
			System.out.println(14);
		} else if (a == 28 && b == 15) {
			System.out.println(13);
		} else if (a == 28 && b == 16) {
			System.out.println(12);
		} else if (a == 28 && b == 17) {
			System.out.println(11);
		} else if (a == 28 && b == 18) {
			System.out.println(10);
		} else if (a == 28 && b == 19) {
			System.out.println(9);
		} else if (a == 28 && b == 20) {
			System.out.println(8);
		} else if (a == 28 && b == 21) {
			System.out.println(7);
		} else if (a == 28 && b == 22) {
			System.out.println(6);
		} else if (a == 28 && b == 23) {
			System.out.println(5);
		} else if (a == 28 && b == 24) {
			System.out.println(4);
		} else if (a == 28 && b == 25) {
			System.out.println(3);
		} else if (a == 28 && b == 26) {
			System.out.println(2);
		} else if (a == 28 && b == 27) {
			System.out.println(1);
		} else if (a == 28 && b == 28) {
			System.out.println(0);
		} else if (a == 28 && b == 29) {
			System.out.println(-1);
		} else if (a == 28 && b == 30) {
			System.out.println(-2);
		} else if (a == 28 && b == 31) {
			System.out.println(-3);
		} else if (a == 28 && b == 32) {
			System.out.println(-4);
		} else if (a == 28 && b == 33) {
			System.out.println(-5);
		} else if (a == 28 && b == 34) {
			System.out.println(-6);
		} else if (a == 28 && b == 35) {
			System.out.println(-7);
		} else if (a == 28 && b == 36) {
			System.out.println(-8);
		} else if (a == 28 && b == 37) {
			System.out.println(-9);
		} else if (a == 28 && b == 38) {
			System.out.println(-10);
		} else if (a == 28 && b == 39) {
			System.out.println(-11);
		} else if (a == 28 && b == 40) {
			System.out.println(-12);
		} else if (a == 28 && b == 41) {
			System.out.println(-13);
		} else if (a == 28 && b == 42) {
			System.out.println(-14);
		} else if (a == 28 && b == 43) {
			System.out.println(-15);
		} else if (a == 28 && b == 44) {
			System.out.println(-16);
		} else if (a == 28 && b == 45) {
			System.out.println(-17);
		} else if (a == 28 && b == 46) {
			System.out.println(-18);
		} else if (a == 28 && b == 47) {
			System.out.println(-19);
		} else if (a == 28 && b == 48) {
			System.out.println(-20);
		} else if (a == 28 && b == 49) {
			System.out.println(-21);
		} else if (a == 28 && b == 50) {
			System.out.println(-22);
		} else if (a == 29 && b == 0) {
			System.out.println(29);
		} else if (a == 29 && b == 1) {
			System.out.println(28);
		} else if (a == 29 && b == 2) {
			System.out.println(27);
		} else if (a == 29 && b == 3) {
			System.out.println(26);
		} else if (a == 29 && b == 4) {
			System.out.println(25);
		} else if (a == 29 && b == 5) {
			System.out.println(24);
		} else if (a == 29 && b == 6) {
			System.out.println(23);
		} else if (a == 29 && b == 7) {
			System.out.println(22);
		} else if (a == 29 && b == 8) {
			System.out.println(21);
		} else if (a == 29 && b == 9) {
			System.out.println(20);
		} else if (a == 29 && b == 10) {
			System.out.println(19);
		} else if (a == 29 && b == 11) {
			System.out.println(18);
		} else if (a == 29 && b == 12) {
			System.out.println(17);
		} else if (a == 29 && b == 13) {
			System.out.println(16);
		} else if (a == 29 && b == 14) {
			System.out.println(15);
		} else if (a == 29 && b == 15) {
			System.out.println(14);
		} else if (a == 29 && b == 16) {
			System.out.println(13);
		} else if (a == 29 && b == 17) {
			System.out.println(12);
		} else if (a == 29 && b == 18) {
			System.out.println(11);
		} else if (a == 29 && b == 19) {
			System.out.println(10);
		} else if (a == 29 && b == 20) {
			System.out.println(9);
		} else if (a == 29 && b == 21) {
			System.out.println(8);
		} else if (a == 29 && b == 22) {
			System.out.println(7);
		} else if (a == 29 && b == 23) {
			System.out.println(6);
		} else if (a == 29 && b == 24) {
			System.out.println(5);
		} else if (a == 29 && b == 25) {
			System.out.println(4);
		} else if (a == 29 && b == 26) {
			System.out.println(3);
		} else if (a == 29 && b == 27) {
			System.out.println(2);
		} else if (a == 29 && b == 28) {
			System.out.println(1);
		} else if (a == 29 && b == 29) {
			System.out.println(0);
		} else if (a == 29 && b == 30) {
			System.out.println(-1);
		} else if (a == 29 && b == 31) {
			System.out.println(-2);
		} else if (a == 29 && b == 32) {
			System.out.println(-3);
		} else if (a == 29 && b == 33) {
			System.out.println(-4);
		} else if (a == 29 && b == 34) {
			System.out.println(-5);
		} else if (a == 29 && b == 35) {
			System.out.println(-6);
		} else if (a == 29 && b == 36) {
			System.out.println(-7);
		} else if (a == 29 && b == 37) {
			System.out.println(-8);
		} else if (a == 29 && b == 38) {
			System.out.println(-9);
		} else if (a == 29 && b == 39) {
			System.out.println(-10);
		} else if (a == 29 && b == 40) {
			System.out.println(-11);
		} else if (a == 29 && b == 41) {
			System.out.println(-12);
		} else if (a == 29 && b == 42) {
			System.out.println(-13);
		} else if (a == 29 && b == 43) {
			System.out.println(-14);
		} else if (a == 29 && b == 44) {
			System.out.println(-15);
		} else if (a == 29 && b == 45) {
			System.out.println(-16);
		} else if (a == 29 && b == 46) {
			System.out.println(-17);
		} else if (a == 29 && b == 47) {
			System.out.println(-18);
		} else if (a == 29 && b == 48) {
			System.out.println(-19);
		} else if (a == 29 && b == 49) {
			System.out.println(-20);
		} else if (a == 29 && b == 50) {
			System.out.println(-21);
		} else if (a == 30 && b == 0) {
			System.out.println(30);
		} else if (a == 30 && b == 1) {
			System.out.println(29);
		} else if (a == 30 && b == 2) {
			System.out.println(28);
		} else if (a == 30 && b == 3) {
			System.out.println(27);
		} else if (a == 30 && b == 4) {
			System.out.println(26);
		} else if (a == 30 && b == 5) {
			System.out.println(25);
		} else if (a == 30 && b == 6) {
			System.out.println(24);
		} else if (a == 30 && b == 7) {
			System.out.println(23);
		} else if (a == 30 && b == 8) {
			System.out.println(22);
		} else if (a == 30 && b == 9) {
			System.out.println(21);
		} else if (a == 30 && b == 10) {
			System.out.println(20);
		} else if (a == 30 && b == 11) {
			System.out.println(19);
		} else if (a == 30 && b == 12) {
			System.out.println(18);
		} else if (a == 30 && b == 13) {
			System.out.println(17);
		} else if (a == 30 && b == 14) {
			System.out.println(16);
		} else if (a == 30 && b == 15) {
			System.out.println(15);
		} else if (a == 30 && b == 16) {
			System.out.println(14);
		} else if (a == 30 && b == 17) {
			System.out.println(13);
		} else if (a == 30 && b == 18) {
			System.out.println(12);
		} else if (a == 30 && b == 19) {
			System.out.println(11);
		} else if (a == 30 && b == 20) {
			System.out.println(10);
		} else if (a == 30 && b == 21) {
			System.out.println(9);
		} else if (a == 30 && b == 22) {
			System.out.println(8);
		} else if (a == 30 && b == 23) {
			System.out.println(7);
		} else if (a == 30 && b == 24) {
			System.out.println(6);
		} else if (a == 30 && b == 25) {
			System.out.println(5);
		} else if (a == 30 && b == 26) {
			System.out.println(4);
		} else if (a == 30 && b == 27) {
			System.out.println(3);
		} else if (a == 30 && b == 28) {
			System.out.println(2);
		} else if (a == 30 && b == 29) {
			System.out.println(1);
		} else if (a == 30 && b == 30) {
			System.out.println(0);
		} else if (a == 30 && b == 31) {
			System.out.println(-1);
		} else if (a == 30 && b == 32) {
			System.out.println(-2);
		} else if (a == 30 && b == 33) {
			System.out.println(-3);
		} else if (a == 30 && b == 34) {
			System.out.println(-4);
		} else if (a == 30 && b == 35) {
			System.out.println(-5);
		} else if (a == 30 && b == 36) {
			System.out.println(-6);
		} else if (a == 30 && b == 37) {
			System.out.println(-7);
		} else if (a == 30 && b == 38) {
			System.out.println(-8);
		} else if (a == 30 && b == 39) {
			System.out.println(-9);
		} else if (a == 30 && b == 40) {
			System.out.println(-10);
		} else if (a == 30 && b == 41) {
			System.out.println(-11);
		} else if (a == 30 && b == 42) {
			System.out.println(-12);
		} else if (a == 30 && b == 43) {
			System.out.println(-13);
		} else if (a == 30 && b == 44) {
			System.out.println(-14);
		} else if (a == 30 && b == 45) {
			System.out.println(-15);
		} else if (a == 30 && b == 46) {
			System.out.println(-16);
		} else if (a == 30 && b == 47) {
			System.out.println(-17);
		} else if (a == 30 && b == 48) {
			System.out.println(-18);
		} else if (a == 30 && b == 49) {
			System.out.println(-19);
		} else if (a == 30 && b == 50) {
			System.out.println(-20);
		} else if (a == 31 && b == 0) {
			System.out.println(31);
		} else if (a == 31 && b == 1) {
			System.out.println(30);
		} else if (a == 31 && b == 2) {
			System.out.println(29);
		} else if (a == 31 && b == 3) {
			System.out.println(28);
		} else if (a == 31 && b == 4) {
			System.out.println(27);
		} else if (a == 31 && b == 5) {
			System.out.println(26);
		} else if (a == 31 && b == 6) {
			System.out.println(25);
		} else if (a == 31 && b == 7) {
			System.out.println(24);
		} else if (a == 31 && b == 8) {
			System.out.println(23);
		} else if (a == 31 && b == 9) {
			System.out.println(22);
		} else if (a == 31 && b == 10) {
			System.out.println(21);
		} else if (a == 31 && b == 11) {
			System.out.println(20);
		} else if (a == 31 && b == 12) {
			System.out.println(19);
		} else if (a == 31 && b == 13) {
			System.out.println(18);
		} else if (a == 31 && b == 14) {
			System.out.println(17);
		} else if (a == 31 && b == 15) {
			System.out.println(16);
		} else if (a == 31 && b == 16) {
			System.out.println(15);
		} else if (a == 31 && b == 17) {
			System.out.println(14);
		} else if (a == 31 && b == 18) {
			System.out.println(13);
		} else if (a == 31 && b == 19) {
			System.out.println(12);
		} else if (a == 31 && b == 20) {
			System.out.println(11);
		} else if (a == 31 && b == 21) {
			System.out.println(10);
		} else if (a == 31 && b == 22) {
			System.out.println(9);
		} else if (a == 31 && b == 23) {
			System.out.println(8);
		} else if (a == 31 && b == 24) {
			System.out.println(7);
		} else if (a == 31 && b == 25) {
			System.out.println(6);
		} else if (a == 31 && b == 26) {
			System.out.println(5);
		} else if (a == 31 && b == 27) {
			System.out.println(4);
		} else if (a == 31 && b == 28) {
			System.out.println(3);
		} else if (a == 31 && b == 29) {
			System.out.println(2);
		} else if (a == 31 && b == 30) {
			System.out.println(1);
		} else if (a == 31 && b == 31) {
			System.out.println(0);
		} else if (a == 31 && b == 32) {
			System.out.println(-1);
		} else if (a == 31 && b == 33) {
			System.out.println(-2);
		} else if (a == 31 && b == 34) {
			System.out.println(-3);
		} else if (a == 31 && b == 35) {
			System.out.println(-4);
		} else if (a == 31 && b == 36) {
			System.out.println(-5);
		} else if (a == 31 && b == 37) {
			System.out.println(-6);
		} else if (a == 31 && b == 38) {
			System.out.println(-7);
		} else if (a == 31 && b == 39) {
			System.out.println(-8);
		} else if (a == 31 && b == 40) {
			System.out.println(-9);
		} else if (a == 31 && b == 41) {
			System.out.println(-10);
		} else if (a == 31 && b == 42) {
			System.out.println(-11);
		} else if (a == 31 && b == 43) {
			System.out.println(-12);
		} else if (a == 31 && b == 44) {
			System.out.println(-13);
		} else if (a == 31 && b == 45) {
			System.out.println(-14);
		} else if (a == 31 && b == 46) {
			System.out.println(-15);
		} else if (a == 31 && b == 47) {
			System.out.println(-16);
		} else if (a == 31 && b == 48) {
			System.out.println(-17);
		} else if (a == 31 && b == 49) {
			System.out.println(-18);
		} else if (a == 31 && b == 50) {
			System.out.println(-19);
		} else if (a == 32 && b == 0) {
			System.out.println(32);
		} else if (a == 32 && b == 1) {
			System.out.println(31);
		} else if (a == 32 && b == 2) {
			System.out.println(30);
		} else if (a == 32 && b == 3) {
			System.out.println(29);
		} else if (a == 32 && b == 4) {
			System.out.println(28);
		} else if (a == 32 && b == 5) {
			System.out.println(27);
		} else if (a == 32 && b == 6) {
			System.out.println(26);
		} else if (a == 32 && b == 7) {
			System.out.println(25);
		} else if (a == 32 && b == 8) {
			System.out.println(24);
		} else if (a == 32 && b == 9) {
			System.out.println(23);
		} else if (a == 32 && b == 10) {
			System.out.println(22);
		} else if (a == 32 && b == 11) {
			System.out.println(21);
		} else if (a == 32 && b == 12) {
			System.out.println(20);
		} else if (a == 32 && b == 13) {
			System.out.println(19);
		} else if (a == 32 && b == 14) {
			System.out.println(18);
		} else if (a == 32 && b == 15) {
			System.out.println(17);
		} else if (a == 32 && b == 16) {
			System.out.println(16);
		} else if (a == 32 && b == 17) {
			System.out.println(15);
		} else if (a == 32 && b == 18) {
			System.out.println(14);
		} else if (a == 32 && b == 19) {
			System.out.println(13);
		} else if (a == 32 && b == 20) {
			System.out.println(12);
		} else if (a == 32 && b == 21) {
			System.out.println(11);
		} else if (a == 32 && b == 22) {
			System.out.println(10);
		} else if (a == 32 && b == 23) {
			System.out.println(9);
		} else if (a == 32 && b == 24) {
			System.out.println(8);
		} else if (a == 32 && b == 25) {
			System.out.println(7);
		} else if (a == 32 && b == 26) {
			System.out.println(6);
		} else if (a == 32 && b == 27) {
			System.out.println(5);
		} else if (a == 32 && b == 28) {
			System.out.println(4);
		} else if (a == 32 && b == 29) {
			System.out.println(3);
		} else if (a == 32 && b == 30) {
			System.out.println(2);
		} else if (a == 32 && b == 31) {
			System.out.println(1);
		} else if (a == 32 && b == 32) {
			System.out.println(0);
		} else if (a == 32 && b == 33) {
			System.out.println(-1);
		} else if (a == 32 && b == 34) {
			System.out.println(-2);
		} else if (a == 32 && b == 35) {
			System.out.println(-3);
		} else if (a == 32 && b == 36) {
			System.out.println(-4);
		} else if (a == 32 && b == 37) {
			System.out.println(-5);
		} else if (a == 32 && b == 38) {
			System.out.println(-6);
		} else if (a == 32 && b == 39) {
			System.out.println(-7);
		} else if (a == 32 && b == 40) {
			System.out.println(-8);
		} else if (a == 32 && b == 41) {
			System.out.println(-9);
		} else if (a == 32 && b == 42) {
			System.out.println(-10);
		} else if (a == 32 && b == 43) {
			System.out.println(-11);
		} else if (a == 32 && b == 44) {
			System.out.println(-12);
		} else if (a == 32 && b == 45) {
			System.out.println(-13);
		} else if (a == 32 && b == 46) {
			System.out.println(-14);
		} else if (a == 32 && b == 47) {
			System.out.println(-15);
		} else if (a == 32 && b == 48) {
			System.out.println(-16);
		} else if (a == 32 && b == 49) {
			System.out.println(-17);
		} else if (a == 32 && b == 50) {
			System.out.println(-18);
		} else if (a == 33 && b == 0) {
			System.out.println(33);
		} else if (a == 33 && b == 1) {
			System.out.println(32);
		} else if (a == 33 && b == 2) {
			System.out.println(31);
		} else if (a == 33 && b == 3) {
			System.out.println(30);
		} else if (a == 33 && b == 4) {
			System.out.println(29);
		} else if (a == 33 && b == 5) {
			System.out.println(28);
		} else if (a == 33 && b == 6) {
			System.out.println(27);
		} else if (a == 33 && b == 7) {
			System.out.println(26);
		} else if (a == 33 && b == 8) {
			System.out.println(25);
		} else if (a == 33 && b == 9) {
			System.out.println(24);
		} else if (a == 33 && b == 10) {
			System.out.println(23);
		} else if (a == 33 && b == 11) {
			System.out.println(22);
		} else if (a == 33 && b == 12) {
			System.out.println(21);
		} else if (a == 33 && b == 13) {
			System.out.println(20);
		} else if (a == 33 && b == 14) {
			System.out.println(19);
		} else if (a == 33 && b == 15) {
			System.out.println(18);
		} else if (a == 33 && b == 16) {
			System.out.println(17);
		} else if (a == 33 && b == 17) {
			System.out.println(16);
		} else if (a == 33 && b == 18) {
			System.out.println(15);
		} else if (a == 33 && b == 19) {
			System.out.println(14);
		} else if (a == 33 && b == 20) {
			System.out.println(13);
		} else if (a == 33 && b == 21) {
			System.out.println(12);
		} else if (a == 33 && b == 22) {
			System.out.println(11);
		} else if (a == 33 && b == 23) {
			System.out.println(10);
		} else if (a == 33 && b == 24) {
			System.out.println(9);
		} else if (a == 33 && b == 25) {
			System.out.println(8);
		} else if (a == 33 && b == 26) {
			System.out.println(7);
		} else if (a == 33 && b == 27) {
			System.out.println(6);
		} else if (a == 33 && b == 28) {
			System.out.println(5);
		} else if (a == 33 && b == 29) {
			System.out.println(4);
		} else if (a == 33 && b == 30) {
			System.out.println(3);
		} else if (a == 33 && b == 31) {
			System.out.println(2);
		} else if (a == 33 && b == 32) {
			System.out.println(1);
		} else if (a == 33 && b == 33) {
			System.out.println(0);
		} else if (a == 33 && b == 34) {
			System.out.println(-1);
		} else if (a == 33 && b == 35) {
			System.out.println(-2);
		} else if (a == 33 && b == 36) {
			System.out.println(-3);
		} else if (a == 33 && b == 37) {
			System.out.println(-4);
		} else if (a == 33 && b == 38) {
			System.out.println(-5);
		} else if (a == 33 && b == 39) {
			System.out.println(-6);
		} else if (a == 33 && b == 40) {
			System.out.println(-7);
		} else if (a == 33 && b == 41) {
			System.out.println(-8);
		} else if (a == 33 && b == 42) {
			System.out.println(-9);
		} else if (a == 33 && b == 43) {
			System.out.println(-10);
		} else if (a == 33 && b == 44) {
			System.out.println(-11);
		} else if (a == 33 && b == 45) {
			System.out.println(-12);
		} else if (a == 33 && b == 46) {
			System.out.println(-13);
		} else if (a == 33 && b == 47) {
			System.out.println(-14);
		} else if (a == 33 && b == 48) {
			System.out.println(-15);
		} else if (a == 33 && b == 49) {
			System.out.println(-16);
		} else if (a == 33 && b == 50) {
			System.out.println(-17);
		} else if (a == 34 && b == 0) {
			System.out.println(34);
		} else if (a == 34 && b == 1) {
			System.out.println(33);
		} else if (a == 34 && b == 2) {
			System.out.println(32);
		} else if (a == 34 && b == 3) {
			System.out.println(31);
		} else if (a == 34 && b == 4) {
			System.out.println(30);
		} else if (a == 34 && b == 5) {
			System.out.println(29);
		} else if (a == 34 && b == 6) {
			System.out.println(28);
		} else if (a == 34 && b == 7) {
			System.out.println(27);
		} else if (a == 34 && b == 8) {
			System.out.println(26);
		} else if (a == 34 && b == 9) {
			System.out.println(25);
		} else if (a == 34 && b == 10) {
			System.out.println(24);
		} else if (a == 34 && b == 11) {
			System.out.println(23);
		} else if (a == 34 && b == 12) {
			System.out.println(22);
		} else if (a == 34 && b == 13) {
			System.out.println(21);
		} else if (a == 34 && b == 14) {
			System.out.println(20);
		} else if (a == 34 && b == 15) {
			System.out.println(19);
		} else if (a == 34 && b == 16) {
			System.out.println(18);
		} else if (a == 34 && b == 17) {
			System.out.println(17);
		} else if (a == 34 && b == 18) {
			System.out.println(16);
		} else if (a == 34 && b == 19) {
			System.out.println(15);
		} else if (a == 34 && b == 20) {
			System.out.println(14);
		} else if (a == 34 && b == 21) {
			System.out.println(13);
		} else if (a == 34 && b == 22) {
			System.out.println(12);
		} else if (a == 34 && b == 23) {
			System.out.println(11);
		} else if (a == 34 && b == 24) {
			System.out.println(10);
		} else if (a == 34 && b == 25) {
			System.out.println(9);
		} else if (a == 34 && b == 26) {
			System.out.println(8);
		} else if (a == 34 && b == 27) {
			System.out.println(7);
		} else if (a == 34 && b == 28) {
			System.out.println(6);
		} else if (a == 34 && b == 29) {
			System.out.println(5);
		} else if (a == 34 && b == 30) {
			System.out.println(4);
		} else if (a == 34 && b == 31) {
			System.out.println(3);
		} else if (a == 34 && b == 32) {
			System.out.println(2);
		} else if (a == 34 && b == 33) {
			System.out.println(1);
		} else if (a == 34 && b == 34) {
			System.out.println(0);
		} else if (a == 34 && b == 35) {
			System.out.println(-1);
		} else if (a == 34 && b == 36) {
			System.out.println(-2);
		} else if (a == 34 && b == 37) {
			System.out.println(-3);
		} else if (a == 34 && b == 38) {
			System.out.println(-4);
		} else if (a == 34 && b == 39) {
			System.out.println(-5);
		} else if (a == 34 && b == 40) {
			System.out.println(-6);
		} else if (a == 34 && b == 41) {
			System.out.println(-7);
		} else if (a == 34 && b == 42) {
			System.out.println(-8);
		} else if (a == 34 && b == 43) {
			System.out.println(-9);
		} else if (a == 34 && b == 44) {
			System.out.println(-10);
		} else if (a == 34 && b == 45) {
			System.out.println(-11);
		} else if (a == 34 && b == 46) {
			System.out.println(-12);
		} else if (a == 34 && b == 47) {
			System.out.println(-13);
		} else if (a == 34 && b == 48) {
			System.out.println(-14);
		} else if (a == 34 && b == 49) {
			System.out.println(-15);
		} else if (a == 34 && b == 50) {
			System.out.println(-16);
		} else if (a == 35 && b == 0) {
			System.out.println(35);
		} else if (a == 35 && b == 1) {
			System.out.println(34);
		} else if (a == 35 && b == 2) {
			System.out.println(33);
		} else if (a == 35 && b == 3) {
			System.out.println(32);
		} else if (a == 35 && b == 4) {
			System.out.println(31);
		} else if (a == 35 && b == 5) {
			System.out.println(30);
		} else if (a == 35 && b == 6) {
			System.out.println(29);
		} else if (a == 35 && b == 7) {
			System.out.println(28);
		} else if (a == 35 && b == 8) {
			System.out.println(27);
		} else if (a == 35 && b == 9) {
			System.out.println(26);
		} else if (a == 35 && b == 10) {
			System.out.println(25);
		} else if (a == 35 && b == 11) {
			System.out.println(24);
		} else if (a == 35 && b == 12) {
			System.out.println(23);
		} else if (a == 35 && b == 13) {
			System.out.println(22);
		} else if (a == 35 && b == 14) {
			System.out.println(21);
		} else if (a == 35 && b == 15) {
			System.out.println(20);
		} else if (a == 35 && b == 16) {
			System.out.println(19);
		} else if (a == 35 && b == 17) {
			System.out.println(18);
		} else if (a == 35 && b == 18) {
			System.out.println(17);
		} else if (a == 35 && b == 19) {
			System.out.println(16);
		} else if (a == 35 && b == 20) {
			System.out.println(15);
		} else if (a == 35 && b == 21) {
			System.out.println(14);
		} else if (a == 35 && b == 22) {
			System.out.println(13);
		} else if (a == 35 && b == 23) {
			System.out.println(12);
		} else if (a == 35 && b == 24) {
			System.out.println(11);
		} else if (a == 35 && b == 25) {
			System.out.println(10);
		} else if (a == 35 && b == 26) {
			System.out.println(9);
		} else if (a == 35 && b == 27) {
			System.out.println(8);
		} else if (a == 35 && b == 28) {
			System.out.println(7);
		} else if (a == 35 && b == 29) {
			System.out.println(6);
		} else if (a == 35 && b == 30) {
			System.out.println(5);
		} else if (a == 35 && b == 31) {
			System.out.println(4);
		} else if (a == 35 && b == 32) {
			System.out.println(3);
		} else if (a == 35 && b == 33) {
			System.out.println(2);
		} else if (a == 35 && b == 34) {
			System.out.println(1);
		} else if (a == 35 && b == 35) {
			System.out.println(0);
		} else if (a == 35 && b == 36) {
			System.out.println(-1);
		} else if (a == 35 && b == 37) {
			System.out.println(-2);
		} else if (a == 35 && b == 38) {
			System.out.println(-3);
		} else if (a == 35 && b == 39) {
			System.out.println(-4);
		} else if (a == 35 && b == 40) {
			System.out.println(-5);
		} else if (a == 35 && b == 41) {
			System.out.println(-6);
		} else if (a == 35 && b == 42) {
			System.out.println(-7);
		} else if (a == 35 && b == 43) {
			System.out.println(-8);
		} else if (a == 35 && b == 44) {
			System.out.println(-9);
		} else if (a == 35 && b == 45) {
			System.out.println(-10);
		} else if (a == 35 && b == 46) {
			System.out.println(-11);
		} else if (a == 35 && b == 47) {
			System.out.println(-12);
		} else if (a == 35 && b == 48) {
			System.out.println(-13);
		} else if (a == 35 && b == 49) {
			System.out.println(-14);
		} else if (a == 35 && b == 50) {
			System.out.println(-15);
		} else if (a == 36 && b == 0) {
			System.out.println(36);
		} else if (a == 36 && b == 1) {
			System.out.println(35);
		} else if (a == 36 && b == 2) {
			System.out.println(34);
		} else if (a == 36 && b == 3) {
			System.out.println(33);
		} else if (a == 36 && b == 4) {
			System.out.println(32);
		} else if (a == 36 && b == 5) {
			System.out.println(31);
		} else if (a == 36 && b == 6) {
			System.out.println(30);
		} else if (a == 36 && b == 7) {
			System.out.println(29);
		} else if (a == 36 && b == 8) {
			System.out.println(28);
		} else if (a == 36 && b == 9) {
			System.out.println(27);
		} else if (a == 36 && b == 10) {
			System.out.println(26);
		} else if (a == 36 && b == 11) {
			System.out.println(25);
		} else if (a == 36 && b == 12) {
			System.out.println(24);
		} else if (a == 36 && b == 13) {
			System.out.println(23);
		} else if (a == 36 && b == 14) {
			System.out.println(22);
		} else if (a == 36 && b == 15) {
			System.out.println(21);
		} else if (a == 36 && b == 16) {
			System.out.println(20);
		} else if (a == 36 && b == 17) {
			System.out.println(19);
		} else if (a == 36 && b == 18) {
			System.out.println(18);
		} else if (a == 36 && b == 19) {
			System.out.println(17);
		} else if (a == 36 && b == 20) {
			System.out.println(16);
		} else if (a == 36 && b == 21) {
			System.out.println(15);
		} else if (a == 36 && b == 22) {
			System.out.println(14);
		} else if (a == 36 && b == 23) {
			System.out.println(13);
		} else if (a == 36 && b == 24) {
			System.out.println(12);
		} else if (a == 36 && b == 25) {
			System.out.println(11);
		} else if (a == 36 && b == 26) {
			System.out.println(10);
		} else if (a == 36 && b == 27) {
			System.out.println(9);
		} else if (a == 36 && b == 28) {
			System.out.println(8);
		} else if (a == 36 && b == 29) {
			System.out.println(7);
		} else if (a == 36 && b == 30) {
			System.out.println(6);
		} else if (a == 36 && b == 31) {
			System.out.println(5);
		} else if (a == 36 && b == 32) {
			System.out.println(4);
		} else if (a == 36 && b == 33) {
			System.out.println(3);
		} else if (a == 36 && b == 34) {
			System.out.println(2);
		} else if (a == 36 && b == 35) {
			System.out.println(1);
		} else if (a == 36 && b == 36) {
			System.out.println(0);
		} else if (a == 36 && b == 37) {
			System.out.println(-1);
		} else if (a == 36 && b == 38) {
			System.out.println(-2);
		} else if (a == 36 && b == 39) {
			System.out.println(-3);
		} else if (a == 36 && b == 40) {
			System.out.println(-4);
		} else if (a == 36 && b == 41) {
			System.out.println(-5);
		} else if (a == 36 && b == 42) {
			System.out.println(-6);
		} else if (a == 36 && b == 43) {
			System.out.println(-7);
		} else if (a == 36 && b == 44) {
			System.out.println(-8);
		} else if (a == 36 && b == 45) {
			System.out.println(-9);
		} else if (a == 36 && b == 46) {
			System.out.println(-10);
		} else if (a == 36 && b == 47) {
			System.out.println(-11);
		} else if (a == 36 && b == 48) {
			System.out.println(-12);
		} else if (a == 36 && b == 49) {
			System.out.println(-13);
		} else if (a == 36 && b == 50) {
			System.out.println(-14);
		} else if (a == 37 && b == 0) {
			System.out.println(37);
		} else if (a == 37 && b == 1) {
			System.out.println(36);
		} else if (a == 37 && b == 2) {
			System.out.println(35);
		} else if (a == 37 && b == 3) {
			System.out.println(34);
		} else if (a == 37 && b == 4) {
			System.out.println(33);
		} else if (a == 37 && b == 5) {
			System.out.println(32);
		} else if (a == 37 && b == 6) {
			System.out.println(31);
		} else if (a == 37 && b == 7) {
			System.out.println(30);
		} else if (a == 37 && b == 8) {
			System.out.println(29);
		} else if (a == 37 && b == 9) {
			System.out.println(28);
		} else if (a == 37 && b == 10) {
			System.out.println(27);
		} else if (a == 37 && b == 11) {
			System.out.println(26);
		} else if (a == 37 && b == 12) {
			System.out.println(25);
		} else if (a == 37 && b == 13) {
			System.out.println(24);
		} else if (a == 37 && b == 14) {
			System.out.println(23);
		} else if (a == 37 && b == 15) {
			System.out.println(22);
		} else if (a == 37 && b == 16) {
			System.out.println(21);
		} else if (a == 37 && b == 17) {
			System.out.println(20);
		} else if (a == 37 && b == 18) {
			System.out.println(19);
		} else if (a == 37 && b == 19) {
			System.out.println(18);
		} else if (a == 37 && b == 20) {
			System.out.println(17);
		} else if (a == 37 && b == 21) {
			System.out.println(16);
		} else if (a == 37 && b == 22) {
			System.out.println(15);
		} else if (a == 37 && b == 23) {
			System.out.println(14);
		} else if (a == 37 && b == 24) {
			System.out.println(13);
		} else if (a == 37 && b == 25) {
			System.out.println(12);
		} else if (a == 37 && b == 26) {
			System.out.println(11);
		} else if (a == 37 && b == 27) {
			System.out.println(10);
		} else if (a == 37 && b == 28) {
			System.out.println(9);
		} else if (a == 37 && b == 29) {
			System.out.println(8);
		} else if (a == 37 && b == 30) {
			System.out.println(7);
		} else if (a == 37 && b == 31) {
			System.out.println(6);
		} else if (a == 37 && b == 32) {
			System.out.println(5);
		} else if (a == 37 && b == 33) {
			System.out.println(4);
		} else if (a == 37 && b == 34) {
			System.out.println(3);
		} else if (a == 37 && b == 35) {
			System.out.println(2);
		} else if (a == 37 && b == 36) {
			System.out.println(1);
		} else if (a == 37 && b == 37) {
			System.out.println(0);
		} else if (a == 37 && b == 38) {
			System.out.println(-1);
		} else if (a == 37 && b == 39) {
			System.out.println(-2);
		} else if (a == 37 && b == 40) {
			System.out.println(-3);
		} else if (a == 37 && b == 41) {
			System.out.println(-4);
		} else if (a == 37 && b == 42) {
			System.out.println(-5);
		} else if (a == 37 && b == 43) {
			System.out.println(-6);
		} else if (a == 37 && b == 44) {
			System.out.println(-7);
		} else if (a == 37 && b == 45) {
			System.out.println(-8);
		} else if (a == 37 && b == 46) {
			System.out.println(-9);
		} else if (a == 37 && b == 47) {
			System.out.println(-10);
		} else if (a == 37 && b == 48) {
			System.out.println(-11);
		} else if (a == 37 && b == 49) {
			System.out.println(-12);
		} else if (a == 37 && b == 50) {
			System.out.println(-13);
		} else if (a == 38 && b == 0) {
			System.out.println(38);
		} else if (a == 38 && b == 1) {
			System.out.println(37);
		} else if (a == 38 && b == 2) {
			System.out.println(36);
		} else if (a == 38 && b == 3) {
			System.out.println(35);
		} else if (a == 38 && b == 4) {
			System.out.println(34);
		} else if (a == 38 && b == 5) {
			System.out.println(33);
		} else if (a == 38 && b == 6) {
			System.out.println(32);
		} else if (a == 38 && b == 7) {
			System.out.println(31);
		} else if (a == 38 && b == 8) {
			System.out.println(30);
		} else if (a == 38 && b == 9) {
			System.out.println(29);
		} else if (a == 38 && b == 10) {
			System.out.println(28);
		} else if (a == 38 && b == 11) {
			System.out.println(27);
		} else if (a == 38 && b == 12) {
			System.out.println(26);
		} else if (a == 38 && b == 13) {
			System.out.println(25);
		} else if (a == 38 && b == 14) {
			System.out.println(24);
		} else if (a == 38 && b == 15) {
			System.out.println(23);
		} else if (a == 38 && b == 16) {
			System.out.println(22);
		} else if (a == 38 && b == 17) {
			System.out.println(21);
		} else if (a == 38 && b == 18) {
			System.out.println(20);
		} else if (a == 38 && b == 19) {
			System.out.println(19);
		} else if (a == 38 && b == 20) {
			System.out.println(18);
		} else if (a == 38 && b == 21) {
			System.out.println(17);
		} else if (a == 38 && b == 22) {
			System.out.println(16);
		} else if (a == 38 && b == 23) {
			System.out.println(15);
		} else if (a == 38 && b == 24) {
			System.out.println(14);
		} else if (a == 38 && b == 25) {
			System.out.println(13);
		} else if (a == 38 && b == 26) {
			System.out.println(12);
		} else if (a == 38 && b == 27) {
			System.out.println(11);
		} else if (a == 38 && b == 28) {
			System.out.println(10);
		} else if (a == 38 && b == 29) {
			System.out.println(9);
		} else if (a == 38 && b == 30) {
			System.out.println(8);
		} else if (a == 38 && b == 31) {
			System.out.println(7);
		} else if (a == 38 && b == 32) {
			System.out.println(6);
		} else if (a == 38 && b == 33) {
			System.out.println(5);
		} else if (a == 38 && b == 34) {
			System.out.println(4);
		} else if (a == 38 && b == 35) {
			System.out.println(3);
		} else if (a == 38 && b == 36) {
			System.out.println(2);
		} else if (a == 38 && b == 37) {
			System.out.println(1);
		} else if (a == 38 && b == 38) {
			System.out.println(0);
		} else if (a == 38 && b == 39) {
			System.out.println(-1);
		} else if (a == 38 && b == 40) {
			System.out.println(-2);
		} else if (a == 38 && b == 41) {
			System.out.println(-3);
		} else if (a == 38 && b == 42) {
			System.out.println(-4);
		} else if (a == 38 && b == 43) {
			System.out.println(-5);
		} else if (a == 38 && b == 44) {
			System.out.println(-6);
		} else if (a == 38 && b == 45) {
			System.out.println(-7);
		} else if (a == 38 && b == 46) {
			System.out.println(-8);
		} else if (a == 38 && b == 47) {
			System.out.println(-9);
		} else if (a == 38 && b == 48) {
			System.out.println(-10);
		} else if (a == 38 && b == 49) {
			System.out.println(-11);
		} else if (a == 38 && b == 50) {
			System.out.println(-12);
		} else if (a == 39 && b == 0) {
			System.out.println(39);
		} else if (a == 39 && b == 1) {
			System.out.println(38);
		} else if (a == 39 && b == 2) {
			System.out.println(37);
		} else if (a == 39 && b == 3) {
			System.out.println(36);
		} else if (a == 39 && b == 4) {
			System.out.println(35);
		} else if (a == 39 && b == 5) {
			System.out.println(34);
		} else if (a == 39 && b == 6) {
			System.out.println(33);
		} else if (a == 39 && b == 7) {
			System.out.println(32);
		} else if (a == 39 && b == 8) {
			System.out.println(31);
		} else if (a == 39 && b == 9) {
			System.out.println(30);
		} else if (a == 39 && b == 10) {
			System.out.println(29);
		} else if (a == 39 && b == 11) {
			System.out.println(28);
		} else if (a == 39 && b == 12) {
			System.out.println(27);
		} else if (a == 39 && b == 13) {
			System.out.println(26);
		} else if (a == 39 && b == 14) {
			System.out.println(25);
		} else if (a == 39 && b == 15) {
			System.out.println(24);
		} else if (a == 39 && b == 16) {
			System.out.println(23);
		} else if (a == 39 && b == 17) {
			System.out.println(22);
		} else if (a == 39 && b == 18) {
			System.out.println(21);
		} else if (a == 39 && b == 19) {
			System.out.println(20);
		} else if (a == 39 && b == 20) {
			System.out.println(19);
		} else if (a == 39 && b == 21) {
			System.out.println(18);
		} else if (a == 39 && b == 22) {
			System.out.println(17);
		} else if (a == 39 && b == 23) {
			System.out.println(16);
		} else if (a == 39 && b == 24) {
			System.out.println(15);
		} else if (a == 39 && b == 25) {
			System.out.println(14);
		} else if (a == 39 && b == 26) {
			System.out.println(13);
		} else if (a == 39 && b == 27) {
			System.out.println(12);
		} else if (a == 39 && b == 28) {
			System.out.println(11);
		} else if (a == 39 && b == 29) {
			System.out.println(10);
		} else if (a == 39 && b == 30) {
			System.out.println(9);
		} else if (a == 39 && b == 31) {
			System.out.println(8);
		} else if (a == 39 && b == 32) {
			System.out.println(7);
		} else if (a == 39 && b == 33) {
			System.out.println(6);
		} else if (a == 39 && b == 34) {
			System.out.println(5);
		} else if (a == 39 && b == 35) {
			System.out.println(4);
		} else if (a == 39 && b == 36) {
			System.out.println(3);
		} else if (a == 39 && b == 37) {
			System.out.println(2);
		} else if (a == 39 && b == 38) {
			System.out.println(1);
		} else if (a == 39 && b == 39) {
			System.out.println(0);
		} else if (a == 39 && b == 40) {
			System.out.println(-1);
		} else if (a == 39 && b == 41) {
			System.out.println(-2);
		} else if (a == 39 && b == 42) {
			System.out.println(-3);
		} else if (a == 39 && b == 43) {
			System.out.println(-4);
		} else if (a == 39 && b == 44) {
			System.out.println(-5);
		} else if (a == 39 && b == 45) {
			System.out.println(-6);
		} else if (a == 39 && b == 46) {
			System.out.println(-7);
		} else if (a == 39 && b == 47) {
			System.out.println(-8);
		} else if (a == 39 && b == 48) {
			System.out.println(-9);
		} else if (a == 39 && b == 49) {
			System.out.println(-10);
		} else if (a == 39 && b == 50) {
			System.out.println(-11);
		} else if (a == 40 && b == 0) {
			System.out.println(40);
		} else if (a == 40 && b == 1) {
			System.out.println(39);
		} else if (a == 40 && b == 2) {
			System.out.println(38);
		} else if (a == 40 && b == 3) {
			System.out.println(37);
		} else if (a == 40 && b == 4) {
			System.out.println(36);
		} else if (a == 40 && b == 5) {
			System.out.println(35);
		} else if (a == 40 && b == 6) {
			System.out.println(34);
		} else if (a == 40 && b == 7) {
			System.out.println(33);
		} else if (a == 40 && b == 8) {
			System.out.println(32);
		} else if (a == 40 && b == 9) {
			System.out.println(31);
		} else if (a == 40 && b == 10) {
			System.out.println(30);
		} else if (a == 40 && b == 11) {
			System.out.println(29);
		} else if (a == 40 && b == 12) {
			System.out.println(28);
		} else if (a == 40 && b == 13) {
			System.out.println(27);
		} else if (a == 40 && b == 14) {
			System.out.println(26);
		} else if (a == 40 && b == 15) {
			System.out.println(25);
		} else if (a == 40 && b == 16) {
			System.out.println(24);
		} else if (a == 40 && b == 17) {
			System.out.println(23);
		} else if (a == 40 && b == 18) {
			System.out.println(22);
		} else if (a == 40 && b == 19) {
			System.out.println(21);
		} else if (a == 40 && b == 20) {
			System.out.println(20);
		} else if (a == 40 && b == 21) {
			System.out.println(19);
		} else if (a == 40 && b == 22) {
			System.out.println(18);
		} else if (a == 40 && b == 23) {
			System.out.println(17);
		} else if (a == 40 && b == 24) {
			System.out.println(16);
		} else if (a == 40 && b == 25) {
			System.out.println(15);
		} else if (a == 40 && b == 26) {
			System.out.println(14);
		} else if (a == 40 && b == 27) {
			System.out.println(13);
		} else if (a == 40 && b == 28) {
			System.out.println(12);
		} else if (a == 40 && b == 29) {
			System.out.println(11);
		} else if (a == 40 && b == 30) {
			System.out.println(10);
		} else if (a == 40 && b == 31) {
			System.out.println(9);
		} else if (a == 40 && b == 32) {
			System.out.println(8);
		} else if (a == 40 && b == 33) {
			System.out.println(7);
		} else if (a == 40 && b == 34) {
			System.out.println(6);
		} else if (a == 40 && b == 35) {
			System.out.println(5);
		} else if (a == 40 && b == 36) {
			System.out.println(4);
		} else if (a == 40 && b == 37) {
			System.out.println(3);
		} else if (a == 40 && b == 38) {
			System.out.println(2);
		} else if (a == 40 && b == 39) {
			System.out.println(1);
		} else if (a == 40 && b == 40) {
			System.out.println(0);
		} else if (a == 40 && b == 41) {
			System.out.println(-1);
		} else if (a == 40 && b == 42) {
			System.out.println(-2);
		} else if (a == 40 && b == 43) {
			System.out.println(-3);
		} else if (a == 40 && b == 44) {
			System.out.println(-4);
		} else if (a == 40 && b == 45) {
			System.out.println(-5);
		} else if (a == 40 && b == 46) {
			System.out.println(-6);
		} else if (a == 40 && b == 47) {
			System.out.println(-7);
		} else if (a == 40 && b == 48) {
			System.out.println(-8);
		} else if (a == 40 && b == 49) {
			System.out.println(-9);
		} else if (a == 40 && b == 50) {
			System.out.println(-10);
		} else if (a == 41 && b == 0) {
			System.out.println(41);
		} else if (a == 41 && b == 1) {
			System.out.println(40);
		} else if (a == 41 && b == 2) {
			System.out.println(39);
		} else if (a == 41 && b == 3) {
			System.out.println(38);
		} else if (a == 41 && b == 4) {
			System.out.println(37);
		} else if (a == 41 && b == 5) {
			System.out.println(36);
		} else if (a == 41 && b == 6) {
			System.out.println(35);
		} else if (a == 41 && b == 7) {
			System.out.println(34);
		} else if (a == 41 && b == 8) {
			System.out.println(33);
		} else if (a == 41 && b == 9) {
			System.out.println(32);
		} else if (a == 41 && b == 10) {
			System.out.println(31);
		} else if (a == 41 && b == 11) {
			System.out.println(30);
		} else if (a == 41 && b == 12) {
			System.out.println(29);
		} else if (a == 41 && b == 13) {
			System.out.println(28);
		} else if (a == 41 && b == 14) {
			System.out.println(27);
		} else if (a == 41 && b == 15) {
			System.out.println(26);
		} else if (a == 41 && b == 16) {
			System.out.println(25);
		} else if (a == 41 && b == 17) {
			System.out.println(24);
		} else if (a == 41 && b == 18) {
			System.out.println(23);
		} else if (a == 41 && b == 19) {
			System.out.println(22);
		} else if (a == 41 && b == 20) {
			System.out.println(21);
		} else if (a == 41 && b == 21) {
			System.out.println(20);
		} else if (a == 41 && b == 22) {
			System.out.println(19);
		} else if (a == 41 && b == 23) {
			System.out.println(18);
		} else if (a == 41 && b == 24) {
			System.out.println(17);
		} else if (a == 41 && b == 25) {
			System.out.println(16);
		} else if (a == 41 && b == 26) {
			System.out.println(15);
		} else if (a == 41 && b == 27) {
			System.out.println(14);
		} else if (a == 41 && b == 28) {
			System.out.println(13);
		} else if (a == 41 && b == 29) {
			System.out.println(12);
		} else if (a == 41 && b == 30) {
			System.out.println(11);
		} else if (a == 41 && b == 31) {
			System.out.println(10);
		} else if (a == 41 && b == 32) {
			System.out.println(9);
		} else if (a == 41 && b == 33) {
			System.out.println(8);
		} else if (a == 41 && b == 34) {
			System.out.println(7);
		} else if (a == 41 && b == 35) {
			System.out.println(6);
		} else if (a == 41 && b == 36) {
			System.out.println(5);
		} else if (a == 41 && b == 37) {
			System.out.println(4);
		} else if (a == 41 && b == 38) {
			System.out.println(3);
		} else if (a == 41 && b == 39) {
			System.out.println(2);
		} else if (a == 41 && b == 40) {
			System.out.println(1);
		} else if (a == 41 && b == 41) {
			System.out.println(0);
		} else if (a == 41 && b == 42) {
			System.out.println(-1);
		} else if (a == 41 && b == 43) {
			System.out.println(-2);
		} else if (a == 41 && b == 44) {
			System.out.println(-3);
		} else if (a == 41 && b == 45) {
			System.out.println(-4);
		} else if (a == 41 && b == 46) {
			System.out.println(-5);
		} else if (a == 41 && b == 47) {
			System.out.println(-6);
		} else if (a == 41 && b == 48) {
			System.out.println(-7);
		} else if (a == 41 && b == 49) {
			System.out.println(-8);
		} else if (a == 41 && b == 50) {
			System.out.println(-9);
		} else if (a == 42 && b == 0) {
			System.out.println(42);
		} else if (a == 42 && b == 1) {
			System.out.println(41);
		} else if (a == 42 && b == 2) {
			System.out.println(40);
		} else if (a == 42 && b == 3) {
			System.out.println(39);
		} else if (a == 42 && b == 4) {
			System.out.println(38);
		} else if (a == 42 && b == 5) {
			System.out.println(37);
		} else if (a == 42 && b == 6) {
			System.out.println(36);
		} else if (a == 42 && b == 7) {
			System.out.println(35);
		} else if (a == 42 && b == 8) {
			System.out.println(34);
		} else if (a == 42 && b == 9) {
			System.out.println(33);
		} else if (a == 42 && b == 10) {
			System.out.println(32);
		} else if (a == 42 && b == 11) {
			System.out.println(31);
		} else if (a == 42 && b == 12) {
			System.out.println(30);
		} else if (a == 42 && b == 13) {
			System.out.println(29);
		} else if (a == 42 && b == 14) {
			System.out.println(28);
		} else if (a == 42 && b == 15) {
			System.out.println(27);
		} else if (a == 42 && b == 16) {
			System.out.println(26);
		} else if (a == 42 && b == 17) {
			System.out.println(25);
		} else if (a == 42 && b == 18) {
			System.out.println(24);
		} else if (a == 42 && b == 19) {
			System.out.println(23);
		} else if (a == 42 && b == 20) {
			System.out.println(22);
		} else if (a == 42 && b == 21) {
			System.out.println(21);
		} else if (a == 42 && b == 22) {
			System.out.println(20);
		} else if (a == 42 && b == 23) {
			System.out.println(19);
		} else if (a == 42 && b == 24) {
			System.out.println(18);
		} else if (a == 42 && b == 25) {
			System.out.println(17);
		} else if (a == 42 && b == 26) {
			System.out.println(16);
		} else if (a == 42 && b == 27) {
			System.out.println(15);
		} else if (a == 42 && b == 28) {
			System.out.println(14);
		} else if (a == 42 && b == 29) {
			System.out.println(13);
		} else if (a == 42 && b == 30) {
			System.out.println(12);
		} else if (a == 42 && b == 31) {
			System.out.println(11);
		} else if (a == 42 && b == 32) {
			System.out.println(10);
		} else if (a == 42 && b == 33) {
			System.out.println(9);
		} else if (a == 42 && b == 34) {
			System.out.println(8);
		} else if (a == 42 && b == 35) {
			System.out.println(7);
		} else if (a == 42 && b == 36) {
			System.out.println(6);
		} else if (a == 42 && b == 37) {
			System.out.println(5);
		} else if (a == 42 && b == 38) {
			System.out.println(4);
		} else if (a == 42 && b == 39) {
			System.out.println(3);
		} else if (a == 42 && b == 40) {
			System.out.println(2);
		} else if (a == 42 && b == 41) {
			System.out.println(1);
		} else if (a == 42 && b == 42) {
			System.out.println(0);
		} else if (a == 42 && b == 43) {
			System.out.println(-1);
		} else if (a == 42 && b == 44) {
			System.out.println(-2);
		} else if (a == 42 && b == 45) {
			System.out.println(-3);
		} else if (a == 42 && b == 46) {
			System.out.println(-4);
		} else if (a == 42 && b == 47) {
			System.out.println(-5);
		} else if (a == 42 && b == 48) {
			System.out.println(-6);
		} else if (a == 42 && b == 49) {
			System.out.println(-7);
		} else if (a == 42 && b == 50) {
			System.out.println(-8);
		} else if (a == 43 && b == 0) {
			System.out.println(43);
		} else if (a == 43 && b == 1) {
			System.out.println(42);
		} else if (a == 43 && b == 2) {
			System.out.println(41);
		} else if (a == 43 && b == 3) {
			System.out.println(40);
		} else if (a == 43 && b == 4) {
			System.out.println(39);
		} else if (a == 43 && b == 5) {
			System.out.println(38);
		} else if (a == 43 && b == 6) {
			System.out.println(37);
		} else if (a == 43 && b == 7) {
			System.out.println(36);
		} else if (a == 43 && b == 8) {
			System.out.println(35);
		} else if (a == 43 && b == 9) {
			System.out.println(34);
		} else if (a == 43 && b == 10) {
			System.out.println(33);
		} else if (a == 43 && b == 11) {
			System.out.println(32);
		} else if (a == 43 && b == 12) {
			System.out.println(31);
		} else if (a == 43 && b == 13) {
			System.out.println(30);
		} else if (a == 43 && b == 14) {
			System.out.println(29);
		} else if (a == 43 && b == 15) {
			System.out.println(28);
		} else if (a == 43 && b == 16) {
			System.out.println(27);
		} else if (a == 43 && b == 17) {
			System.out.println(26);
		} else if (a == 43 && b == 18) {
			System.out.println(25);
		} else if (a == 43 && b == 19) {
			System.out.println(24);
		} else if (a == 43 && b == 20) {
			System.out.println(23);
		} else if (a == 43 && b == 21) {
			System.out.println(22);
		} else if (a == 43 && b == 22) {
			System.out.println(21);
		} else if (a == 43 && b == 23) {
			System.out.println(20);
		} else if (a == 43 && b == 24) {
			System.out.println(19);
		} else if (a == 43 && b == 25) {
			System.out.println(18);
		} else if (a == 43 && b == 26) {
			System.out.println(17);
		} else if (a == 43 && b == 27) {
			System.out.println(16);
		} else if (a == 43 && b == 28) {
			System.out.println(15);
		} else if (a == 43 && b == 29) {
			System.out.println(14);
		} else if (a == 43 && b == 30) {
			System.out.println(13);
		} else if (a == 43 && b == 31) {
			System.out.println(12);
		} else if (a == 43 && b == 32) {
			System.out.println(11);
		} else if (a == 43 && b == 33) {
			System.out.println(10);
		} else if (a == 43 && b == 34) {
			System.out.println(9);
		} else if (a == 43 && b == 35) {
			System.out.println(8);
		} else if (a == 43 && b == 36) {
			System.out.println(7);
		} else if (a == 43 && b == 37) {
			System.out.println(6);
		} else if (a == 43 && b == 38) {
			System.out.println(5);
		} else if (a == 43 && b == 39) {
			System.out.println(4);
		} else if (a == 43 && b == 40) {
			System.out.println(3);
		} else if (a == 43 && b == 41) {
			System.out.println(2);
		} else if (a == 43 && b == 42) {
			System.out.println(1);
		} else if (a == 43 && b == 43) {
			System.out.println(0);
		} else if (a == 43 && b == 44) {
			System.out.println(-1);
		} else if (a == 43 && b == 45) {
			System.out.println(-2);
		} else if (a == 43 && b == 46) {
			System.out.println(-3);
		} else if (a == 43 && b == 47) {
			System.out.println(-4);
		} else if (a == 43 && b == 48) {
			System.out.println(-5);
		} else if (a == 43 && b == 49) {
			System.out.println(-6);
		} else if (a == 43 && b == 50) {
			System.out.println(-7);
		} else if (a == 44 && b == 0) {
			System.out.println(44);
		} else if (a == 44 && b == 1) {
			System.out.println(43);
		} else if (a == 44 && b == 2) {
			System.out.println(42);
		} else if (a == 44 && b == 3) {
			System.out.println(41);
		} else if (a == 44 && b == 4) {
			System.out.println(40);
		} else if (a == 44 && b == 5) {
			System.out.println(39);
		} else if (a == 44 && b == 6) {
			System.out.println(38);
		} else if (a == 44 && b == 7) {
			System.out.println(37);
		} else if (a == 44 && b == 8) {
			System.out.println(36);
		} else if (a == 44 && b == 9) {
			System.out.println(35);
		} else if (a == 44 && b == 10) {
			System.out.println(34);
		} else if (a == 44 && b == 11) {
			System.out.println(33);
		} else if (a == 44 && b == 12) {
			System.out.println(32);
		} else if (a == 44 && b == 13) {
			System.out.println(31);
		} else if (a == 44 && b == 14) {
			System.out.println(30);
		} else if (a == 44 && b == 15) {
			System.out.println(29);
		} else if (a == 44 && b == 16) {
			System.out.println(28);
		} else if (a == 44 && b == 17) {
			System.out.println(27);
		} else if (a == 44 && b == 18) {
			System.out.println(26);
		} else if (a == 44 && b == 19) {
			System.out.println(25);
		} else if (a == 44 && b == 20) {
			System.out.println(24);
		} else if (a == 44 && b == 21) {
			System.out.println(23);
		} else if (a == 44 && b == 22) {
			System.out.println(22);
		} else if (a == 44 && b == 23) {
			System.out.println(21);
		} else if (a == 44 && b == 24) {
			System.out.println(20);
		} else if (a == 44 && b == 25) {
			System.out.println(19);
		} else if (a == 44 && b == 26) {
			System.out.println(18);
		} else if (a == 44 && b == 27) {
			System.out.println(17);
		} else if (a == 44 && b == 28) {
			System.out.println(16);
		} else if (a == 44 && b == 29) {
			System.out.println(15);
		} else if (a == 44 && b == 30) {
			System.out.println(14);
		} else if (a == 44 && b == 31) {
			System.out.println(13);
		} else if (a == 44 && b == 32) {
			System.out.println(12);
		} else if (a == 44 && b == 33) {
			System.out.println(11);
		} else if (a == 44 && b == 34) {
			System.out.println(10);
		} else if (a == 44 && b == 35) {
			System.out.println(9);
		} else if (a == 44 && b == 36) {
			System.out.println(8);
		} else if (a == 44 && b == 37) {
			System.out.println(7);
		} else if (a == 44 && b == 38) {
			System.out.println(6);
		} else if (a == 44 && b == 39) {
			System.out.println(5);
		} else if (a == 44 && b == 40) {
			System.out.println(4);
		} else if (a == 44 && b == 41) {
			System.out.println(3);
		} else if (a == 44 && b == 42) {
			System.out.println(2);
		} else if (a == 44 && b == 43) {
			System.out.println(1);
		} else if (a == 44 && b == 44) {
			System.out.println(0);
		} else if (a == 44 && b == 45) {
			System.out.println(-1);
		} else if (a == 44 && b == 46) {
			System.out.println(-2);
		} else if (a == 44 && b == 47) {
			System.out.println(-3);
		} else if (a == 44 && b == 48) {
			System.out.println(-4);
		} else if (a == 44 && b == 49) {
			System.out.println(-5);
		} else if (a == 44 && b == 50) {
			System.out.println(-6);
		} else if (a == 45 && b == 0) {
			System.out.println(45);
		} else if (a == 45 && b == 1) {
			System.out.println(44);
		} else if (a == 45 && b == 2) {
			System.out.println(43);
		} else if (a == 45 && b == 3) {
			System.out.println(42);
		} else if (a == 45 && b == 4) {
			System.out.println(41);
		} else if (a == 45 && b == 5) {
			System.out.println(40);
		} else if (a == 45 && b == 6) {
			System.out.println(39);
		} else if (a == 45 && b == 7) {
			System.out.println(38);
		} else if (a == 45 && b == 8) {
			System.out.println(37);
		} else if (a == 45 && b == 9) {
			System.out.println(36);
		} else if (a == 45 && b == 10) {
			System.out.println(35);
		} else if (a == 45 && b == 11) {
			System.out.println(34);
		} else if (a == 45 && b == 12) {
			System.out.println(33);
		} else if (a == 45 && b == 13) {
			System.out.println(32);
		} else if (a == 45 && b == 14) {
			System.out.println(31);
		} else if (a == 45 && b == 15) {
			System.out.println(30);
		} else if (a == 45 && b == 16) {
			System.out.println(29);
		} else if (a == 45 && b == 17) {
			System.out.println(28);
		} else if (a == 45 && b == 18) {
			System.out.println(27);
		} else if (a == 45 && b == 19) {
			System.out.println(26);
		} else if (a == 45 && b == 20) {
			System.out.println(25);
		} else if (a == 45 && b == 21) {
			System.out.println(24);
		} else if (a == 45 && b == 22) {
			System.out.println(23);
		} else if (a == 45 && b == 23) {
			System.out.println(22);
		} else if (a == 45 && b == 24) {
			System.out.println(21);
		} else if (a == 45 && b == 25) {
			System.out.println(20);
		} else if (a == 45 && b == 26) {
			System.out.println(19);
		} else if (a == 45 && b == 27) {
			System.out.println(18);
		} else if (a == 45 && b == 28) {
			System.out.println(17);
		} else if (a == 45 && b == 29) {
			System.out.println(16);
		} else if (a == 45 && b == 30) {
			System.out.println(15);
		} else if (a == 45 && b == 31) {
			System.out.println(14);
		} else if (a == 45 && b == 32) {
			System.out.println(13);
		} else if (a == 45 && b == 33) {
			System.out.println(12);
		} else if (a == 45 && b == 34) {
			System.out.println(11);
		} else if (a == 45 && b == 35) {
			System.out.println(10);
		} else if (a == 45 && b == 36) {
			System.out.println(9);
		} else if (a == 45 && b == 37) {
			System.out.println(8);
		} else if (a == 45 && b == 38) {
			System.out.println(7);
		} else if (a == 45 && b == 39) {
			System.out.println(6);
		} else if (a == 45 && b == 40) {
			System.out.println(5);
		} else if (a == 45 && b == 41) {
			System.out.println(4);
		} else if (a == 45 && b == 42) {
			System.out.println(3);
		} else if (a == 45 && b == 43) {
			System.out.println(2);
		} else if (a == 45 && b == 44) {
			System.out.println(1);
		} else if (a == 45 && b == 45) {
			System.out.println(0);
		} else if (a == 45 && b == 46) {
			System.out.println(-1);
		} else if (a == 45 && b == 47) {
			System.out.println(-2);
		} else if (a == 45 && b == 48) {
			System.out.println(-3);
		} else if (a == 45 && b == 49) {
			System.out.println(-4);
		} else if (a == 45 && b == 50) {
			System.out.println(-5);
		} else if (a == 46 && b == 0) {
			System.out.println(46);
		} else if (a == 46 && b == 1) {
			System.out.println(45);
		} else if (a == 46 && b == 2) {
			System.out.println(44);
		} else if (a == 46 && b == 3) {
			System.out.println(43);
		} else if (a == 46 && b == 4) {
			System.out.println(42);
		} else if (a == 46 && b == 5) {
			System.out.println(41);
		} else if (a == 46 && b == 6) {
			System.out.println(40);
		} else if (a == 46 && b == 7) {
			System.out.println(39);
		} else if (a == 46 && b == 8) {
			System.out.println(38);
		} else if (a == 46 && b == 9) {
			System.out.println(37);
		} else if (a == 46 && b == 10) {
			System.out.println(36);
		} else if (a == 46 && b == 11) {
			System.out.println(35);
		} else if (a == 46 && b == 12) {
			System.out.println(34);
		} else if (a == 46 && b == 13) {
			System.out.println(33);
		} else if (a == 46 && b == 14) {
			System.out.println(32);
		} else if (a == 46 && b == 15) {
			System.out.println(31);
		} else if (a == 46 && b == 16) {
			System.out.println(30);
		} else if (a == 46 && b == 17) {
			System.out.println(29);
		} else if (a == 46 && b == 18) {
			System.out.println(28);
		} else if (a == 46 && b == 19) {
			System.out.println(27);
		} else if (a == 46 && b == 20) {
			System.out.println(26);
		} else if (a == 46 && b == 21) {
			System.out.println(25);
		} else if (a == 46 && b == 22) {
			System.out.println(24);
		} else if (a == 46 && b == 23) {
			System.out.println(23);
		} else if (a == 46 && b == 24) {
			System.out.println(22);
		} else if (a == 46 && b == 25) {
			System.out.println(21);
		} else if (a == 46 && b == 26) {
			System.out.println(20);
		} else if (a == 46 && b == 27) {
			System.out.println(19);
		} else if (a == 46 && b == 28) {
			System.out.println(18);
		} else if (a == 46 && b == 29) {
			System.out.println(17);
		} else if (a == 46 && b == 30) {
			System.out.println(16);
		} else if (a == 46 && b == 31) {
			System.out.println(15);
		} else if (a == 46 && b == 32) {
			System.out.println(14);
		} else if (a == 46 && b == 33) {
			System.out.println(13);
		} else if (a == 46 && b == 34) {
			System.out.println(12);
		} else if (a == 46 && b == 35) {
			System.out.println(11);
		} else if (a == 46 && b == 36) {
			System.out.println(10);
		} else if (a == 46 && b == 37) {
			System.out.println(9);
		} else if (a == 46 && b == 38) {
			System.out.println(8);
		} else if (a == 46 && b == 39) {
			System.out.println(7);
		} else if (a == 46 && b == 40) {
			System.out.println(6);
		} else if (a == 46 && b == 41) {
			System.out.println(5);
		} else if (a == 46 && b == 42) {
			System.out.println(4);
		} else if (a == 46 && b == 43) {
			System.out.println(3);
		} else if (a == 46 && b == 44) {
			System.out.println(2);
		} else if (a == 46 && b == 45) {
			System.out.println(1);
		} else if (a == 46 && b == 46) {
			System.out.println(0);
		} else if (a == 46 && b == 47) {
			System.out.println(-1);
		} else if (a == 46 && b == 48) {
			System.out.println(-2);
		} else if (a == 46 && b == 49) {
			System.out.println(-3);
		} else if (a == 46 && b == 50) {
			System.out.println(-4);
		} else if (a == 47 && b == 0) {
			System.out.println(47);
		} else if (a == 47 && b == 1) {
			System.out.println(46);
		} else if (a == 47 && b == 2) {
			System.out.println(45);
		} else if (a == 47 && b == 3) {
			System.out.println(44);
		} else if (a == 47 && b == 4) {
			System.out.println(43);
		} else if (a == 47 && b == 5) {
			System.out.println(42);
		} else if (a == 47 && b == 6) {
			System.out.println(41);
		} else if (a == 47 && b == 7) {
			System.out.println(40);
		} else if (a == 47 && b == 8) {
			System.out.println(39);
		} else if (a == 47 && b == 9) {
			System.out.println(38);
		} else if (a == 47 && b == 10) {
			System.out.println(37);
		} else if (a == 47 && b == 11) {
			System.out.println(36);
		} else if (a == 47 && b == 12) {
			System.out.println(35);
		} else if (a == 47 && b == 13) {
			System.out.println(34);
		} else if (a == 47 && b == 14) {
			System.out.println(33);
		} else if (a == 47 && b == 15) {
			System.out.println(32);
		} else if (a == 47 && b == 16) {
			System.out.println(31);
		} else if (a == 47 && b == 17) {
			System.out.println(30);
		} else if (a == 47 && b == 18) {
			System.out.println(29);
		} else if (a == 47 && b == 19) {
			System.out.println(28);
		} else if (a == 47 && b == 20) {
			System.out.println(27);
		} else if (a == 47 && b == 21) {
			System.out.println(26);
		} else if (a == 47 && b == 22) {
			System.out.println(25);
		} else if (a == 47 && b == 23) {
			System.out.println(24);
		} else if (a == 47 && b == 24) {
			System.out.println(23);
		} else if (a == 47 && b == 25) {
			System.out.println(22);
		} else if (a == 47 && b == 26) {
			System.out.println(21);
		} else if (a == 47 && b == 27) {
			System.out.println(20);
		} else if (a == 47 && b == 28) {
			System.out.println(19);
		} else if (a == 47 && b == 29) {
			System.out.println(18);
		} else if (a == 47 && b == 30) {
			System.out.println(17);
		} else if (a == 47 && b == 31) {
			System.out.println(16);
		} else if (a == 47 && b == 32) {
			System.out.println(15);
		} else if (a == 47 && b == 33) {
			System.out.println(14);
		} else if (a == 47 && b == 34) {
			System.out.println(13);
		} else if (a == 47 && b == 35) {
			System.out.println(12);
		} else if (a == 47 && b == 36) {
			System.out.println(11);
		} else if (a == 47 && b == 37) {
			System.out.println(10);
		} else if (a == 47 && b == 38) {
			System.out.println(9);
		} else if (a == 47 && b == 39) {
			System.out.println(8);
		} else if (a == 47 && b == 40) {
			System.out.println(7);
		} else if (a == 47 && b == 41) {
			System.out.println(6);
		} else if (a == 47 && b == 42) {
			System.out.println(5);
		} else if (a == 47 && b == 43) {
			System.out.println(4);
		} else if (a == 47 && b == 44) {
			System.out.println(3);
		} else if (a == 47 && b == 45) {
			System.out.println(2);
		} else if (a == 47 && b == 46) {
			System.out.println(1);
		} else if (a == 47 && b == 47) {
			System.out.println(0);
		} else if (a == 47 && b == 48) {
			System.out.println(-1);
		} else if (a == 47 && b == 49) {
			System.out.println(-2);
		} else if (a == 47 && b == 50) {
			System.out.println(-3);
		} else if (a == 48 && b == 0) {
			System.out.println(48);
		} else if (a == 48 && b == 1) {
			System.out.println(47);
		} else if (a == 48 && b == 2) {
			System.out.println(46);
		} else if (a == 48 && b == 3) {
			System.out.println(45);
		} else if (a == 48 && b == 4) {
			System.out.println(44);
		} else if (a == 48 && b == 5) {
			System.out.println(43);
		} else if (a == 48 && b == 6) {
			System.out.println(42);
		} else if (a == 48 && b == 7) {
			System.out.println(41);
		} else if (a == 48 && b == 8) {
			System.out.println(40);
		} else if (a == 48 && b == 9) {
			System.out.println(39);
		} else if (a == 48 && b == 10) {
			System.out.println(38);
		} else if (a == 48 && b == 11) {
			System.out.println(37);
		} else if (a == 48 && b == 12) {
			System.out.println(36);
		} else if (a == 48 && b == 13) {
			System.out.println(35);
		} else if (a == 48 && b == 14) {
			System.out.println(34);
		} else if (a == 48 && b == 15) {
			System.out.println(33);
		} else if (a == 48 && b == 16) {
			System.out.println(32);
		} else if (a == 48 && b == 17) {
			System.out.println(31);
		} else if (a == 48 && b == 18) {
			System.out.println(30);
		} else if (a == 48 && b == 19) {
			System.out.println(29);
		} else if (a == 48 && b == 20) {
			System.out.println(28);
		} else if (a == 48 && b == 21) {
			System.out.println(27);
		} else if (a == 48 && b == 22) {
			System.out.println(26);
		} else if (a == 48 && b == 23) {
			System.out.println(25);
		} else if (a == 48 && b == 24) {
			System.out.println(24);
		} else if (a == 48 && b == 25) {
			System.out.println(23);
		} else if (a == 48 && b == 26) {
			System.out.println(22);
		} else if (a == 48 && b == 27) {
			System.out.println(21);
		} else if (a == 48 && b == 28) {
			System.out.println(20);
		} else if (a == 48 && b == 29) {
			System.out.println(19);
		} else if (a == 48 && b == 30) {
			System.out.println(18);
		} else if (a == 48 && b == 31) {
			System.out.println(17);
		} else if (a == 48 && b == 32) {
			System.out.println(16);
		} else if (a == 48 && b == 33) {
			System.out.println(15);
		} else if (a == 48 && b == 34) {
			System.out.println(14);
		} else if (a == 48 && b == 35) {
			System.out.println(13);
		} else if (a == 48 && b == 36) {
			System.out.println(12);
		} else if (a == 48 && b == 37) {
			System.out.println(11);
		} else if (a == 48 && b == 38) {
			System.out.println(10);
		} else if (a == 48 && b == 39) {
			System.out.println(9);
		} else if (a == 48 && b == 40) {
			System.out.println(8);
		} else if (a == 48 && b == 41) {
			System.out.println(7);
		} else if (a == 48 && b == 42) {
			System.out.println(6);
		} else if (a == 48 && b == 43) {
			System.out.println(5);
		} else if (a == 48 && b == 44) {
			System.out.println(4);
		} else if (a == 48 && b == 45) {
			System.out.println(3);
		} else if (a == 48 && b == 46) {
			System.out.println(2);
		} else if (a == 48 && b == 47) {
			System.out.println(1);
		} else if (a == 48 && b == 48) {
			System.out.println(0);
		} else if (a == 48 && b == 49) {
			System.out.println(-1);
		} else if (a == 48 && b == 50) {
			System.out.println(-2);
		} else if (a == 49 && b == 0) {
			System.out.println(49);
		} else if (a == 49 && b == 1) {
			System.out.println(48);
		} else if (a == 49 && b == 2) {
			System.out.println(47);
		} else if (a == 49 && b == 3) {
			System.out.println(46);
		} else if (a == 49 && b == 4) {
			System.out.println(45);
		} else if (a == 49 && b == 5) {
			System.out.println(44);
		} else if (a == 49 && b == 6) {
			System.out.println(43);
		} else if (a == 49 && b == 7) {
			System.out.println(42);
		} else if (a == 49 && b == 8) {
			System.out.println(41);
		} else if (a == 49 && b == 9) {
			System.out.println(40);
		} else if (a == 49 && b == 10) {
			System.out.println(39);
		} else if (a == 49 && b == 11) {
			System.out.println(38);
		} else if (a == 49 && b == 12) {
			System.out.println(37);
		} else if (a == 49 && b == 13) {
			System.out.println(36);
		} else if (a == 49 && b == 14) {
			System.out.println(35);
		} else if (a == 49 && b == 15) {
			System.out.println(34);
		} else if (a == 49 && b == 16) {
			System.out.println(33);
		} else if (a == 49 && b == 17) {
			System.out.println(32);
		} else if (a == 49 && b == 18) {
			System.out.println(31);
		} else if (a == 49 && b == 19) {
			System.out.println(30);
		} else if (a == 49 && b == 20) {
			System.out.println(29);
		} else if (a == 49 && b == 21) {
			System.out.println(28);
		} else if (a == 49 && b == 22) {
			System.out.println(27);
		} else if (a == 49 && b == 23) {
			System.out.println(26);
		} else if (a == 49 && b == 24) {
			System.out.println(25);
		} else if (a == 49 && b == 25) {
			System.out.println(24);
		} else if (a == 49 && b == 26) {
			System.out.println(23);
		} else if (a == 49 && b == 27) {
			System.out.println(22);
		} else if (a == 49 && b == 28) {
			System.out.println(21);
		} else if (a == 49 && b == 29) {
			System.out.println(20);
		} else if (a == 49 && b == 30) {
			System.out.println(19);
		} else if (a == 49 && b == 31) {
			System.out.println(18);
		} else if (a == 49 && b == 32) {
			System.out.println(17);
		} else if (a == 49 && b == 33) {
			System.out.println(16);
		} else if (a == 49 && b == 34) {
			System.out.println(15);
		} else if (a == 49 && b == 35) {
			System.out.println(14);
		} else if (a == 49 && b == 36) {
			System.out.println(13);
		} else if (a == 49 && b == 37) {
			System.out.println(12);
		} else if (a == 49 && b == 38) {
			System.out.println(11);
		} else if (a == 49 && b == 39) {
			System.out.println(10);
		} else if (a == 49 && b == 40) {
			System.out.println(9);
		} else if (a == 49 && b == 41) {
			System.out.println(8);
		} else if (a == 49 && b == 42) {
			System.out.println(7);
		} else if (a == 49 && b == 43) {
			System.out.println(6);
		} else if (a == 49 && b == 44) {
			System.out.println(5);
		} else if (a == 49 && b == 45) {
			System.out.println(4);
		} else if (a == 49 && b == 46) {
			System.out.println(3);
		} else if (a == 49 && b == 47) {
			System.out.println(2);
		} else if (a == 49 && b == 48) {
			System.out.println(1);
		} else if (a == 49 && b == 49) {
			System.out.println(0);
		} else if (a == 49 && b == 50) {
			System.out.println(-1);
		} else if (a == 50 && b == 0) {
			System.out.println(50);
		} else if (a == 50 && b == 1) {
			System.out.println(49);
		} else if (a == 50 && b == 2) {
			System.out.println(48);
		} else if (a == 50 && b == 3) {
			System.out.println(47);
		} else if (a == 50 && b == 4) {
			System.out.println(46);
		} else if (a == 50 && b == 5) {
			System.out.println(45);
		} else if (a == 50 && b == 6) {
			System.out.println(44);
		} else if (a == 50 && b == 7) {
			System.out.println(43);
		} else if (a == 50 && b == 8) {
			System.out.println(42);
		} else if (a == 50 && b == 9) {
			System.out.println(41);
		} else if (a == 50 && b == 10) {
			System.out.println(40);
		} else if (a == 50 && b == 11) {
			System.out.println(39);
		} else if (a == 50 && b == 12) {
			System.out.println(38);
		} else if (a == 50 && b == 13) {
			System.out.println(37);
		} else if (a == 50 && b == 14) {
			System.out.println(36);
		} else if (a == 50 && b == 15) {
			System.out.println(35);
		} else if (a == 50 && b == 16) {
			System.out.println(34);
		} else if (a == 50 && b == 17) {
			System.out.println(33);
		} else if (a == 50 && b == 18) {
			System.out.println(32);
		} else if (a == 50 && b == 19) {
			System.out.println(31);
		} else if (a == 50 && b == 20) {
			System.out.println(30);
		} else if (a == 50 && b == 21) {
			System.out.println(29);
		} else if (a == 50 && b == 22) {
			System.out.println(28);
		} else if (a == 50 && b == 23) {
			System.out.println(27);
		} else if (a == 50 && b == 24) {
			System.out.println(26);
		} else if (a == 50 && b == 25) {
			System.out.println(25);
		} else if (a == 50 && b == 26) {
			System.out.println(24);
		} else if (a == 50 && b == 27) {
			System.out.println(23);
		} else if (a == 50 && b == 28) {
			System.out.println(22);
		} else if (a == 50 && b == 29) {
			System.out.println(21);
		} else if (a == 50 && b == 30) {
			System.out.println(20);
		} else if (a == 50 && b == 31) {
			System.out.println(19);
		} else if (a == 50 && b == 32) {
			System.out.println(18);
		} else if (a == 50 && b == 33) {
			System.out.println(17);
		} else if (a == 50 && b == 34) {
			System.out.println(16);
		} else if (a == 50 && b == 35) {
			System.out.println(15);
		} else if (a == 50 && b == 36) {
			System.out.println(14);
		} else if (a == 50 && b == 37) {
			System.out.println(13);
		} else if (a == 50 && b == 38) {
			System.out.println(12);
		} else if (a == 50 && b == 39) {
			System.out.println(11);
		} else if (a == 50 && b == 40) {
			System.out.println(10);
		} else if (a == 50 && b == 41) {
			System.out.println(9);
		} else if (a == 50 && b == 42) {
			System.out.println(8);
		} else if (a == 50 && b == 43) {
			System.out.println(7);
		} else if (a == 50 && b == 44) {
			System.out.println(6);
		} else if (a == 50 && b == 45) {
			System.out.println(5);
		} else if (a == 50 && b == 46) {
			System.out.println(4);
		} else if (a == 50 && b == 47) {
			System.out.println(3);
		} else if (a == 50 && b == 48) {
			System.out.println(2);
		} else if (a == 50 && b == 49) {
			System.out.println(1);
		} else if (a == 50 && b == 50) {
			System.out.println(0);
		} else {
			System.out.println("Unsupported number given!");
		}
	}
}