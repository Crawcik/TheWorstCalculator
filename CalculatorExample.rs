use std::io::{self, Write};

fn main() {
    let mut input_text = String::new();
    println!("Max number: 50");
    print!("First number: ");
    io::stdout().flush().unwrap();
    io::stdin().read_line(&mut input_text).unwrap();
    let a: u32 = input_text.trim().parse().expect("Invalid input!");
    input_text.clear();
    print!("Second number: ");
    io::stdout().flush().unwrap();
    io::stdin().read_line(&mut input_text).unwrap();
    let b: u32 = input_text.trim().parse().expect("Invalid input!");
    input_text.clear();
    println!("Do u wanna: a - Add, s - Subtract");
    io::stdin().read_line(&mut input_text).unwrap();
    let method: char = input_text.trim().parse().expect("Invalid input!");
    print!("Result: ");
	if method == 'a' {
	    add(a, b);
	} else if method == 's' {
	    subtract(a, b);
    } else {
        print!("Bad method selected!");
    }
}

fn add(a: u32, b: u32) {
	if a == 0 && b == 0 {
		print!("0");
	} else if a == 0 && b == 1 {
		print!("1");
	} else if a == 0 && b == 2 {
		print!("2");
	} else if a == 0 && b == 3 {
		print!("3");
	} else if a == 0 && b == 4 {
		print!("4");
	} else if a == 0 && b == 5 {
		print!("5");
	} else if a == 0 && b == 6 {
		print!("6");
	} else if a == 0 && b == 7 {
		print!("7");
	} else if a == 0 && b == 8 {
		print!("8");
	} else if a == 0 && b == 9 {
		print!("9");
	} else if a == 0 && b == 10 {
		print!("10");
	} else if a == 0 && b == 11 {
		print!("11");
	} else if a == 0 && b == 12 {
		print!("12");
	} else if a == 0 && b == 13 {
		print!("13");
	} else if a == 0 && b == 14 {
		print!("14");
	} else if a == 0 && b == 15 {
		print!("15");
	} else if a == 0 && b == 16 {
		print!("16");
	} else if a == 0 && b == 17 {
		print!("17");
	} else if a == 0 && b == 18 {
		print!("18");
	} else if a == 0 && b == 19 {
		print!("19");
	} else if a == 0 && b == 20 {
		print!("20");
	} else if a == 0 && b == 21 {
		print!("21");
	} else if a == 0 && b == 22 {
		print!("22");
	} else if a == 0 && b == 23 {
		print!("23");
	} else if a == 0 && b == 24 {
		print!("24");
	} else if a == 0 && b == 25 {
		print!("25");
	} else if a == 0 && b == 26 {
		print!("26");
	} else if a == 0 && b == 27 {
		print!("27");
	} else if a == 0 && b == 28 {
		print!("28");
	} else if a == 0 && b == 29 {
		print!("29");
	} else if a == 0 && b == 30 {
		print!("30");
	} else if a == 0 && b == 31 {
		print!("31");
	} else if a == 0 && b == 32 {
		print!("32");
	} else if a == 0 && b == 33 {
		print!("33");
	} else if a == 0 && b == 34 {
		print!("34");
	} else if a == 0 && b == 35 {
		print!("35");
	} else if a == 0 && b == 36 {
		print!("36");
	} else if a == 0 && b == 37 {
		print!("37");
	} else if a == 0 && b == 38 {
		print!("38");
	} else if a == 0 && b == 39 {
		print!("39");
	} else if a == 0 && b == 40 {
		print!("40");
	} else if a == 0 && b == 41 {
		print!("41");
	} else if a == 0 && b == 42 {
		print!("42");
	} else if a == 0 && b == 43 {
		print!("43");
	} else if a == 0 && b == 44 {
		print!("44");
	} else if a == 0 && b == 45 {
		print!("45");
	} else if a == 0 && b == 46 {
		print!("46");
	} else if a == 0 && b == 47 {
		print!("47");
	} else if a == 0 && b == 48 {
		print!("48");
	} else if a == 0 && b == 49 {
		print!("49");
	} else if a == 0 && b == 50 {
		print!("50");
	} else if a == 1 && b == 0 {
		print!("1");
	} else if a == 1 && b == 1 {
		print!("2");
	} else if a == 1 && b == 2 {
		print!("3");
	} else if a == 1 && b == 3 {
		print!("4");
	} else if a == 1 && b == 4 {
		print!("5");
	} else if a == 1 && b == 5 {
		print!("6");
	} else if a == 1 && b == 6 {
		print!("7");
	} else if a == 1 && b == 7 {
		print!("8");
	} else if a == 1 && b == 8 {
		print!("9");
	} else if a == 1 && b == 9 {
		print!("10");
	} else if a == 1 && b == 10 {
		print!("11");
	} else if a == 1 && b == 11 {
		print!("12");
	} else if a == 1 && b == 12 {
		print!("13");
	} else if a == 1 && b == 13 {
		print!("14");
	} else if a == 1 && b == 14 {
		print!("15");
	} else if a == 1 && b == 15 {
		print!("16");
	} else if a == 1 && b == 16 {
		print!("17");
	} else if a == 1 && b == 17 {
		print!("18");
	} else if a == 1 && b == 18 {
		print!("19");
	} else if a == 1 && b == 19 {
		print!("20");
	} else if a == 1 && b == 20 {
		print!("21");
	} else if a == 1 && b == 21 {
		print!("22");
	} else if a == 1 && b == 22 {
		print!("23");
	} else if a == 1 && b == 23 {
		print!("24");
	} else if a == 1 && b == 24 {
		print!("25");
	} else if a == 1 && b == 25 {
		print!("26");
	} else if a == 1 && b == 26 {
		print!("27");
	} else if a == 1 && b == 27 {
		print!("28");
	} else if a == 1 && b == 28 {
		print!("29");
	} else if a == 1 && b == 29 {
		print!("30");
	} else if a == 1 && b == 30 {
		print!("31");
	} else if a == 1 && b == 31 {
		print!("32");
	} else if a == 1 && b == 32 {
		print!("33");
	} else if a == 1 && b == 33 {
		print!("34");
	} else if a == 1 && b == 34 {
		print!("35");
	} else if a == 1 && b == 35 {
		print!("36");
	} else if a == 1 && b == 36 {
		print!("37");
	} else if a == 1 && b == 37 {
		print!("38");
	} else if a == 1 && b == 38 {
		print!("39");
	} else if a == 1 && b == 39 {
		print!("40");
	} else if a == 1 && b == 40 {
		print!("41");
	} else if a == 1 && b == 41 {
		print!("42");
	} else if a == 1 && b == 42 {
		print!("43");
	} else if a == 1 && b == 43 {
		print!("44");
	} else if a == 1 && b == 44 {
		print!("45");
	} else if a == 1 && b == 45 {
		print!("46");
	} else if a == 1 && b == 46 {
		print!("47");
	} else if a == 1 && b == 47 {
		print!("48");
	} else if a == 1 && b == 48 {
		print!("49");
	} else if a == 1 && b == 49 {
		print!("50");
	} else if a == 1 && b == 50 {
		print!("51");
	} else if a == 2 && b == 0 {
		print!("2");
	} else if a == 2 && b == 1 {
		print!("3");
	} else if a == 2 && b == 2 {
		print!("4");
	} else if a == 2 && b == 3 {
		print!("5");
	} else if a == 2 && b == 4 {
		print!("6");
	} else if a == 2 && b == 5 {
		print!("7");
	} else if a == 2 && b == 6 {
		print!("8");
	} else if a == 2 && b == 7 {
		print!("9");
	} else if a == 2 && b == 8 {
		print!("10");
	} else if a == 2 && b == 9 {
		print!("11");
	} else if a == 2 && b == 10 {
		print!("12");
	} else if a == 2 && b == 11 {
		print!("13");
	} else if a == 2 && b == 12 {
		print!("14");
	} else if a == 2 && b == 13 {
		print!("15");
	} else if a == 2 && b == 14 {
		print!("16");
	} else if a == 2 && b == 15 {
		print!("17");
	} else if a == 2 && b == 16 {
		print!("18");
	} else if a == 2 && b == 17 {
		print!("19");
	} else if a == 2 && b == 18 {
		print!("20");
	} else if a == 2 && b == 19 {
		print!("21");
	} else if a == 2 && b == 20 {
		print!("22");
	} else if a == 2 && b == 21 {
		print!("23");
	} else if a == 2 && b == 22 {
		print!("24");
	} else if a == 2 && b == 23 {
		print!("25");
	} else if a == 2 && b == 24 {
		print!("26");
	} else if a == 2 && b == 25 {
		print!("27");
	} else if a == 2 && b == 26 {
		print!("28");
	} else if a == 2 && b == 27 {
		print!("29");
	} else if a == 2 && b == 28 {
		print!("30");
	} else if a == 2 && b == 29 {
		print!("31");
	} else if a == 2 && b == 30 {
		print!("32");
	} else if a == 2 && b == 31 {
		print!("33");
	} else if a == 2 && b == 32 {
		print!("34");
	} else if a == 2 && b == 33 {
		print!("35");
	} else if a == 2 && b == 34 {
		print!("36");
	} else if a == 2 && b == 35 {
		print!("37");
	} else if a == 2 && b == 36 {
		print!("38");
	} else if a == 2 && b == 37 {
		print!("39");
	} else if a == 2 && b == 38 {
		print!("40");
	} else if a == 2 && b == 39 {
		print!("41");
	} else if a == 2 && b == 40 {
		print!("42");
	} else if a == 2 && b == 41 {
		print!("43");
	} else if a == 2 && b == 42 {
		print!("44");
	} else if a == 2 && b == 43 {
		print!("45");
	} else if a == 2 && b == 44 {
		print!("46");
	} else if a == 2 && b == 45 {
		print!("47");
	} else if a == 2 && b == 46 {
		print!("48");
	} else if a == 2 && b == 47 {
		print!("49");
	} else if a == 2 && b == 48 {
		print!("50");
	} else if a == 2 && b == 49 {
		print!("51");
	} else if a == 2 && b == 50 {
		print!("52");
	} else if a == 3 && b == 0 {
		print!("3");
	} else if a == 3 && b == 1 {
		print!("4");
	} else if a == 3 && b == 2 {
		print!("5");
	} else if a == 3 && b == 3 {
		print!("6");
	} else if a == 3 && b == 4 {
		print!("7");
	} else if a == 3 && b == 5 {
		print!("8");
	} else if a == 3 && b == 6 {
		print!("9");
	} else if a == 3 && b == 7 {
		print!("10");
	} else if a == 3 && b == 8 {
		print!("11");
	} else if a == 3 && b == 9 {
		print!("12");
	} else if a == 3 && b == 10 {
		print!("13");
	} else if a == 3 && b == 11 {
		print!("14");
	} else if a == 3 && b == 12 {
		print!("15");
	} else if a == 3 && b == 13 {
		print!("16");
	} else if a == 3 && b == 14 {
		print!("17");
	} else if a == 3 && b == 15 {
		print!("18");
	} else if a == 3 && b == 16 {
		print!("19");
	} else if a == 3 && b == 17 {
		print!("20");
	} else if a == 3 && b == 18 {
		print!("21");
	} else if a == 3 && b == 19 {
		print!("22");
	} else if a == 3 && b == 20 {
		print!("23");
	} else if a == 3 && b == 21 {
		print!("24");
	} else if a == 3 && b == 22 {
		print!("25");
	} else if a == 3 && b == 23 {
		print!("26");
	} else if a == 3 && b == 24 {
		print!("27");
	} else if a == 3 && b == 25 {
		print!("28");
	} else if a == 3 && b == 26 {
		print!("29");
	} else if a == 3 && b == 27 {
		print!("30");
	} else if a == 3 && b == 28 {
		print!("31");
	} else if a == 3 && b == 29 {
		print!("32");
	} else if a == 3 && b == 30 {
		print!("33");
	} else if a == 3 && b == 31 {
		print!("34");
	} else if a == 3 && b == 32 {
		print!("35");
	} else if a == 3 && b == 33 {
		print!("36");
	} else if a == 3 && b == 34 {
		print!("37");
	} else if a == 3 && b == 35 {
		print!("38");
	} else if a == 3 && b == 36 {
		print!("39");
	} else if a == 3 && b == 37 {
		print!("40");
	} else if a == 3 && b == 38 {
		print!("41");
	} else if a == 3 && b == 39 {
		print!("42");
	} else if a == 3 && b == 40 {
		print!("43");
	} else if a == 3 && b == 41 {
		print!("44");
	} else if a == 3 && b == 42 {
		print!("45");
	} else if a == 3 && b == 43 {
		print!("46");
	} else if a == 3 && b == 44 {
		print!("47");
	} else if a == 3 && b == 45 {
		print!("48");
	} else if a == 3 && b == 46 {
		print!("49");
	} else if a == 3 && b == 47 {
		print!("50");
	} else if a == 3 && b == 48 {
		print!("51");
	} else if a == 3 && b == 49 {
		print!("52");
	} else if a == 3 && b == 50 {
		print!("53");
	} else if a == 4 && b == 0 {
		print!("4");
	} else if a == 4 && b == 1 {
		print!("5");
	} else if a == 4 && b == 2 {
		print!("6");
	} else if a == 4 && b == 3 {
		print!("7");
	} else if a == 4 && b == 4 {
		print!("8");
	} else if a == 4 && b == 5 {
		print!("9");
	} else if a == 4 && b == 6 {
		print!("10");
	} else if a == 4 && b == 7 {
		print!("11");
	} else if a == 4 && b == 8 {
		print!("12");
	} else if a == 4 && b == 9 {
		print!("13");
	} else if a == 4 && b == 10 {
		print!("14");
	} else if a == 4 && b == 11 {
		print!("15");
	} else if a == 4 && b == 12 {
		print!("16");
	} else if a == 4 && b == 13 {
		print!("17");
	} else if a == 4 && b == 14 {
		print!("18");
	} else if a == 4 && b == 15 {
		print!("19");
	} else if a == 4 && b == 16 {
		print!("20");
	} else if a == 4 && b == 17 {
		print!("21");
	} else if a == 4 && b == 18 {
		print!("22");
	} else if a == 4 && b == 19 {
		print!("23");
	} else if a == 4 && b == 20 {
		print!("24");
	} else if a == 4 && b == 21 {
		print!("25");
	} else if a == 4 && b == 22 {
		print!("26");
	} else if a == 4 && b == 23 {
		print!("27");
	} else if a == 4 && b == 24 {
		print!("28");
	} else if a == 4 && b == 25 {
		print!("29");
	} else if a == 4 && b == 26 {
		print!("30");
	} else if a == 4 && b == 27 {
		print!("31");
	} else if a == 4 && b == 28 {
		print!("32");
	} else if a == 4 && b == 29 {
		print!("33");
	} else if a == 4 && b == 30 {
		print!("34");
	} else if a == 4 && b == 31 {
		print!("35");
	} else if a == 4 && b == 32 {
		print!("36");
	} else if a == 4 && b == 33 {
		print!("37");
	} else if a == 4 && b == 34 {
		print!("38");
	} else if a == 4 && b == 35 {
		print!("39");
	} else if a == 4 && b == 36 {
		print!("40");
	} else if a == 4 && b == 37 {
		print!("41");
	} else if a == 4 && b == 38 {
		print!("42");
	} else if a == 4 && b == 39 {
		print!("43");
	} else if a == 4 && b == 40 {
		print!("44");
	} else if a == 4 && b == 41 {
		print!("45");
	} else if a == 4 && b == 42 {
		print!("46");
	} else if a == 4 && b == 43 {
		print!("47");
	} else if a == 4 && b == 44 {
		print!("48");
	} else if a == 4 && b == 45 {
		print!("49");
	} else if a == 4 && b == 46 {
		print!("50");
	} else if a == 4 && b == 47 {
		print!("51");
	} else if a == 4 && b == 48 {
		print!("52");
	} else if a == 4 && b == 49 {
		print!("53");
	} else if a == 4 && b == 50 {
		print!("54");
	} else if a == 5 && b == 0 {
		print!("5");
	} else if a == 5 && b == 1 {
		print!("6");
	} else if a == 5 && b == 2 {
		print!("7");
	} else if a == 5 && b == 3 {
		print!("8");
	} else if a == 5 && b == 4 {
		print!("9");
	} else if a == 5 && b == 5 {
		print!("10");
	} else if a == 5 && b == 6 {
		print!("11");
	} else if a == 5 && b == 7 {
		print!("12");
	} else if a == 5 && b == 8 {
		print!("13");
	} else if a == 5 && b == 9 {
		print!("14");
	} else if a == 5 && b == 10 {
		print!("15");
	} else if a == 5 && b == 11 {
		print!("16");
	} else if a == 5 && b == 12 {
		print!("17");
	} else if a == 5 && b == 13 {
		print!("18");
	} else if a == 5 && b == 14 {
		print!("19");
	} else if a == 5 && b == 15 {
		print!("20");
	} else if a == 5 && b == 16 {
		print!("21");
	} else if a == 5 && b == 17 {
		print!("22");
	} else if a == 5 && b == 18 {
		print!("23");
	} else if a == 5 && b == 19 {
		print!("24");
	} else if a == 5 && b == 20 {
		print!("25");
	} else if a == 5 && b == 21 {
		print!("26");
	} else if a == 5 && b == 22 {
		print!("27");
	} else if a == 5 && b == 23 {
		print!("28");
	} else if a == 5 && b == 24 {
		print!("29");
	} else if a == 5 && b == 25 {
		print!("30");
	} else if a == 5 && b == 26 {
		print!("31");
	} else if a == 5 && b == 27 {
		print!("32");
	} else if a == 5 && b == 28 {
		print!("33");
	} else if a == 5 && b == 29 {
		print!("34");
	} else if a == 5 && b == 30 {
		print!("35");
	} else if a == 5 && b == 31 {
		print!("36");
	} else if a == 5 && b == 32 {
		print!("37");
	} else if a == 5 && b == 33 {
		print!("38");
	} else if a == 5 && b == 34 {
		print!("39");
	} else if a == 5 && b == 35 {
		print!("40");
	} else if a == 5 && b == 36 {
		print!("41");
	} else if a == 5 && b == 37 {
		print!("42");
	} else if a == 5 && b == 38 {
		print!("43");
	} else if a == 5 && b == 39 {
		print!("44");
	} else if a == 5 && b == 40 {
		print!("45");
	} else if a == 5 && b == 41 {
		print!("46");
	} else if a == 5 && b == 42 {
		print!("47");
	} else if a == 5 && b == 43 {
		print!("48");
	} else if a == 5 && b == 44 {
		print!("49");
	} else if a == 5 && b == 45 {
		print!("50");
	} else if a == 5 && b == 46 {
		print!("51");
	} else if a == 5 && b == 47 {
		print!("52");
	} else if a == 5 && b == 48 {
		print!("53");
	} else if a == 5 && b == 49 {
		print!("54");
	} else if a == 5 && b == 50 {
		print!("55");
	} else if a == 6 && b == 0 {
		print!("6");
	} else if a == 6 && b == 1 {
		print!("7");
	} else if a == 6 && b == 2 {
		print!("8");
	} else if a == 6 && b == 3 {
		print!("9");
	} else if a == 6 && b == 4 {
		print!("10");
	} else if a == 6 && b == 5 {
		print!("11");
	} else if a == 6 && b == 6 {
		print!("12");
	} else if a == 6 && b == 7 {
		print!("13");
	} else if a == 6 && b == 8 {
		print!("14");
	} else if a == 6 && b == 9 {
		print!("15");
	} else if a == 6 && b == 10 {
		print!("16");
	} else if a == 6 && b == 11 {
		print!("17");
	} else if a == 6 && b == 12 {
		print!("18");
	} else if a == 6 && b == 13 {
		print!("19");
	} else if a == 6 && b == 14 {
		print!("20");
	} else if a == 6 && b == 15 {
		print!("21");
	} else if a == 6 && b == 16 {
		print!("22");
	} else if a == 6 && b == 17 {
		print!("23");
	} else if a == 6 && b == 18 {
		print!("24");
	} else if a == 6 && b == 19 {
		print!("25");
	} else if a == 6 && b == 20 {
		print!("26");
	} else if a == 6 && b == 21 {
		print!("27");
	} else if a == 6 && b == 22 {
		print!("28");
	} else if a == 6 && b == 23 {
		print!("29");
	} else if a == 6 && b == 24 {
		print!("30");
	} else if a == 6 && b == 25 {
		print!("31");
	} else if a == 6 && b == 26 {
		print!("32");
	} else if a == 6 && b == 27 {
		print!("33");
	} else if a == 6 && b == 28 {
		print!("34");
	} else if a == 6 && b == 29 {
		print!("35");
	} else if a == 6 && b == 30 {
		print!("36");
	} else if a == 6 && b == 31 {
		print!("37");
	} else if a == 6 && b == 32 {
		print!("38");
	} else if a == 6 && b == 33 {
		print!("39");
	} else if a == 6 && b == 34 {
		print!("40");
	} else if a == 6 && b == 35 {
		print!("41");
	} else if a == 6 && b == 36 {
		print!("42");
	} else if a == 6 && b == 37 {
		print!("43");
	} else if a == 6 && b == 38 {
		print!("44");
	} else if a == 6 && b == 39 {
		print!("45");
	} else if a == 6 && b == 40 {
		print!("46");
	} else if a == 6 && b == 41 {
		print!("47");
	} else if a == 6 && b == 42 {
		print!("48");
	} else if a == 6 && b == 43 {
		print!("49");
	} else if a == 6 && b == 44 {
		print!("50");
	} else if a == 6 && b == 45 {
		print!("51");
	} else if a == 6 && b == 46 {
		print!("52");
	} else if a == 6 && b == 47 {
		print!("53");
	} else if a == 6 && b == 48 {
		print!("54");
	} else if a == 6 && b == 49 {
		print!("55");
	} else if a == 6 && b == 50 {
		print!("56");
	} else if a == 7 && b == 0 {
		print!("7");
	} else if a == 7 && b == 1 {
		print!("8");
	} else if a == 7 && b == 2 {
		print!("9");
	} else if a == 7 && b == 3 {
		print!("10");
	} else if a == 7 && b == 4 {
		print!("11");
	} else if a == 7 && b == 5 {
		print!("12");
	} else if a == 7 && b == 6 {
		print!("13");
	} else if a == 7 && b == 7 {
		print!("14");
	} else if a == 7 && b == 8 {
		print!("15");
	} else if a == 7 && b == 9 {
		print!("16");
	} else if a == 7 && b == 10 {
		print!("17");
	} else if a == 7 && b == 11 {
		print!("18");
	} else if a == 7 && b == 12 {
		print!("19");
	} else if a == 7 && b == 13 {
		print!("20");
	} else if a == 7 && b == 14 {
		print!("21");
	} else if a == 7 && b == 15 {
		print!("22");
	} else if a == 7 && b == 16 {
		print!("23");
	} else if a == 7 && b == 17 {
		print!("24");
	} else if a == 7 && b == 18 {
		print!("25");
	} else if a == 7 && b == 19 {
		print!("26");
	} else if a == 7 && b == 20 {
		print!("27");
	} else if a == 7 && b == 21 {
		print!("28");
	} else if a == 7 && b == 22 {
		print!("29");
	} else if a == 7 && b == 23 {
		print!("30");
	} else if a == 7 && b == 24 {
		print!("31");
	} else if a == 7 && b == 25 {
		print!("32");
	} else if a == 7 && b == 26 {
		print!("33");
	} else if a == 7 && b == 27 {
		print!("34");
	} else if a == 7 && b == 28 {
		print!("35");
	} else if a == 7 && b == 29 {
		print!("36");
	} else if a == 7 && b == 30 {
		print!("37");
	} else if a == 7 && b == 31 {
		print!("38");
	} else if a == 7 && b == 32 {
		print!("39");
	} else if a == 7 && b == 33 {
		print!("40");
	} else if a == 7 && b == 34 {
		print!("41");
	} else if a == 7 && b == 35 {
		print!("42");
	} else if a == 7 && b == 36 {
		print!("43");
	} else if a == 7 && b == 37 {
		print!("44");
	} else if a == 7 && b == 38 {
		print!("45");
	} else if a == 7 && b == 39 {
		print!("46");
	} else if a == 7 && b == 40 {
		print!("47");
	} else if a == 7 && b == 41 {
		print!("48");
	} else if a == 7 && b == 42 {
		print!("49");
	} else if a == 7 && b == 43 {
		print!("50");
	} else if a == 7 && b == 44 {
		print!("51");
	} else if a == 7 && b == 45 {
		print!("52");
	} else if a == 7 && b == 46 {
		print!("53");
	} else if a == 7 && b == 47 {
		print!("54");
	} else if a == 7 && b == 48 {
		print!("55");
	} else if a == 7 && b == 49 {
		print!("56");
	} else if a == 7 && b == 50 {
		print!("57");
	} else if a == 8 && b == 0 {
		print!("8");
	} else if a == 8 && b == 1 {
		print!("9");
	} else if a == 8 && b == 2 {
		print!("10");
	} else if a == 8 && b == 3 {
		print!("11");
	} else if a == 8 && b == 4 {
		print!("12");
	} else if a == 8 && b == 5 {
		print!("13");
	} else if a == 8 && b == 6 {
		print!("14");
	} else if a == 8 && b == 7 {
		print!("15");
	} else if a == 8 && b == 8 {
		print!("16");
	} else if a == 8 && b == 9 {
		print!("17");
	} else if a == 8 && b == 10 {
		print!("18");
	} else if a == 8 && b == 11 {
		print!("19");
	} else if a == 8 && b == 12 {
		print!("20");
	} else if a == 8 && b == 13 {
		print!("21");
	} else if a == 8 && b == 14 {
		print!("22");
	} else if a == 8 && b == 15 {
		print!("23");
	} else if a == 8 && b == 16 {
		print!("24");
	} else if a == 8 && b == 17 {
		print!("25");
	} else if a == 8 && b == 18 {
		print!("26");
	} else if a == 8 && b == 19 {
		print!("27");
	} else if a == 8 && b == 20 {
		print!("28");
	} else if a == 8 && b == 21 {
		print!("29");
	} else if a == 8 && b == 22 {
		print!("30");
	} else if a == 8 && b == 23 {
		print!("31");
	} else if a == 8 && b == 24 {
		print!("32");
	} else if a == 8 && b == 25 {
		print!("33");
	} else if a == 8 && b == 26 {
		print!("34");
	} else if a == 8 && b == 27 {
		print!("35");
	} else if a == 8 && b == 28 {
		print!("36");
	} else if a == 8 && b == 29 {
		print!("37");
	} else if a == 8 && b == 30 {
		print!("38");
	} else if a == 8 && b == 31 {
		print!("39");
	} else if a == 8 && b == 32 {
		print!("40");
	} else if a == 8 && b == 33 {
		print!("41");
	} else if a == 8 && b == 34 {
		print!("42");
	} else if a == 8 && b == 35 {
		print!("43");
	} else if a == 8 && b == 36 {
		print!("44");
	} else if a == 8 && b == 37 {
		print!("45");
	} else if a == 8 && b == 38 {
		print!("46");
	} else if a == 8 && b == 39 {
		print!("47");
	} else if a == 8 && b == 40 {
		print!("48");
	} else if a == 8 && b == 41 {
		print!("49");
	} else if a == 8 && b == 42 {
		print!("50");
	} else if a == 8 && b == 43 {
		print!("51");
	} else if a == 8 && b == 44 {
		print!("52");
	} else if a == 8 && b == 45 {
		print!("53");
	} else if a == 8 && b == 46 {
		print!("54");
	} else if a == 8 && b == 47 {
		print!("55");
	} else if a == 8 && b == 48 {
		print!("56");
	} else if a == 8 && b == 49 {
		print!("57");
	} else if a == 8 && b == 50 {
		print!("58");
	} else if a == 9 && b == 0 {
		print!("9");
	} else if a == 9 && b == 1 {
		print!("10");
	} else if a == 9 && b == 2 {
		print!("11");
	} else if a == 9 && b == 3 {
		print!("12");
	} else if a == 9 && b == 4 {
		print!("13");
	} else if a == 9 && b == 5 {
		print!("14");
	} else if a == 9 && b == 6 {
		print!("15");
	} else if a == 9 && b == 7 {
		print!("16");
	} else if a == 9 && b == 8 {
		print!("17");
	} else if a == 9 && b == 9 {
		print!("18");
	} else if a == 9 && b == 10 {
		print!("19");
	} else if a == 9 && b == 11 {
		print!("20");
	} else if a == 9 && b == 12 {
		print!("21");
	} else if a == 9 && b == 13 {
		print!("22");
	} else if a == 9 && b == 14 {
		print!("23");
	} else if a == 9 && b == 15 {
		print!("24");
	} else if a == 9 && b == 16 {
		print!("25");
	} else if a == 9 && b == 17 {
		print!("26");
	} else if a == 9 && b == 18 {
		print!("27");
	} else if a == 9 && b == 19 {
		print!("28");
	} else if a == 9 && b == 20 {
		print!("29");
	} else if a == 9 && b == 21 {
		print!("30");
	} else if a == 9 && b == 22 {
		print!("31");
	} else if a == 9 && b == 23 {
		print!("32");
	} else if a == 9 && b == 24 {
		print!("33");
	} else if a == 9 && b == 25 {
		print!("34");
	} else if a == 9 && b == 26 {
		print!("35");
	} else if a == 9 && b == 27 {
		print!("36");
	} else if a == 9 && b == 28 {
		print!("37");
	} else if a == 9 && b == 29 {
		print!("38");
	} else if a == 9 && b == 30 {
		print!("39");
	} else if a == 9 && b == 31 {
		print!("40");
	} else if a == 9 && b == 32 {
		print!("41");
	} else if a == 9 && b == 33 {
		print!("42");
	} else if a == 9 && b == 34 {
		print!("43");
	} else if a == 9 && b == 35 {
		print!("44");
	} else if a == 9 && b == 36 {
		print!("45");
	} else if a == 9 && b == 37 {
		print!("46");
	} else if a == 9 && b == 38 {
		print!("47");
	} else if a == 9 && b == 39 {
		print!("48");
	} else if a == 9 && b == 40 {
		print!("49");
	} else if a == 9 && b == 41 {
		print!("50");
	} else if a == 9 && b == 42 {
		print!("51");
	} else if a == 9 && b == 43 {
		print!("52");
	} else if a == 9 && b == 44 {
		print!("53");
	} else if a == 9 && b == 45 {
		print!("54");
	} else if a == 9 && b == 46 {
		print!("55");
	} else if a == 9 && b == 47 {
		print!("56");
	} else if a == 9 && b == 48 {
		print!("57");
	} else if a == 9 && b == 49 {
		print!("58");
	} else if a == 9 && b == 50 {
		print!("59");
	} else if a == 10 && b == 0 {
		print!("10");
	} else if a == 10 && b == 1 {
		print!("11");
	} else if a == 10 && b == 2 {
		print!("12");
	} else if a == 10 && b == 3 {
		print!("13");
	} else if a == 10 && b == 4 {
		print!("14");
	} else if a == 10 && b == 5 {
		print!("15");
	} else if a == 10 && b == 6 {
		print!("16");
	} else if a == 10 && b == 7 {
		print!("17");
	} else if a == 10 && b == 8 {
		print!("18");
	} else if a == 10 && b == 9 {
		print!("19");
	} else if a == 10 && b == 10 {
		print!("20");
	} else if a == 10 && b == 11 {
		print!("21");
	} else if a == 10 && b == 12 {
		print!("22");
	} else if a == 10 && b == 13 {
		print!("23");
	} else if a == 10 && b == 14 {
		print!("24");
	} else if a == 10 && b == 15 {
		print!("25");
	} else if a == 10 && b == 16 {
		print!("26");
	} else if a == 10 && b == 17 {
		print!("27");
	} else if a == 10 && b == 18 {
		print!("28");
	} else if a == 10 && b == 19 {
		print!("29");
	} else if a == 10 && b == 20 {
		print!("30");
	} else if a == 10 && b == 21 {
		print!("31");
	} else if a == 10 && b == 22 {
		print!("32");
	} else if a == 10 && b == 23 {
		print!("33");
	} else if a == 10 && b == 24 {
		print!("34");
	} else if a == 10 && b == 25 {
		print!("35");
	} else if a == 10 && b == 26 {
		print!("36");
	} else if a == 10 && b == 27 {
		print!("37");
	} else if a == 10 && b == 28 {
		print!("38");
	} else if a == 10 && b == 29 {
		print!("39");
	} else if a == 10 && b == 30 {
		print!("40");
	} else if a == 10 && b == 31 {
		print!("41");
	} else if a == 10 && b == 32 {
		print!("42");
	} else if a == 10 && b == 33 {
		print!("43");
	} else if a == 10 && b == 34 {
		print!("44");
	} else if a == 10 && b == 35 {
		print!("45");
	} else if a == 10 && b == 36 {
		print!("46");
	} else if a == 10 && b == 37 {
		print!("47");
	} else if a == 10 && b == 38 {
		print!("48");
	} else if a == 10 && b == 39 {
		print!("49");
	} else if a == 10 && b == 40 {
		print!("50");
	} else if a == 10 && b == 41 {
		print!("51");
	} else if a == 10 && b == 42 {
		print!("52");
	} else if a == 10 && b == 43 {
		print!("53");
	} else if a == 10 && b == 44 {
		print!("54");
	} else if a == 10 && b == 45 {
		print!("55");
	} else if a == 10 && b == 46 {
		print!("56");
	} else if a == 10 && b == 47 {
		print!("57");
	} else if a == 10 && b == 48 {
		print!("58");
	} else if a == 10 && b == 49 {
		print!("59");
	} else if a == 10 && b == 50 {
		print!("60");
	} else if a == 11 && b == 0 {
		print!("11");
	} else if a == 11 && b == 1 {
		print!("12");
	} else if a == 11 && b == 2 {
		print!("13");
	} else if a == 11 && b == 3 {
		print!("14");
	} else if a == 11 && b == 4 {
		print!("15");
	} else if a == 11 && b == 5 {
		print!("16");
	} else if a == 11 && b == 6 {
		print!("17");
	} else if a == 11 && b == 7 {
		print!("18");
	} else if a == 11 && b == 8 {
		print!("19");
	} else if a == 11 && b == 9 {
		print!("20");
	} else if a == 11 && b == 10 {
		print!("21");
	} else if a == 11 && b == 11 {
		print!("22");
	} else if a == 11 && b == 12 {
		print!("23");
	} else if a == 11 && b == 13 {
		print!("24");
	} else if a == 11 && b == 14 {
		print!("25");
	} else if a == 11 && b == 15 {
		print!("26");
	} else if a == 11 && b == 16 {
		print!("27");
	} else if a == 11 && b == 17 {
		print!("28");
	} else if a == 11 && b == 18 {
		print!("29");
	} else if a == 11 && b == 19 {
		print!("30");
	} else if a == 11 && b == 20 {
		print!("31");
	} else if a == 11 && b == 21 {
		print!("32");
	} else if a == 11 && b == 22 {
		print!("33");
	} else if a == 11 && b == 23 {
		print!("34");
	} else if a == 11 && b == 24 {
		print!("35");
	} else if a == 11 && b == 25 {
		print!("36");
	} else if a == 11 && b == 26 {
		print!("37");
	} else if a == 11 && b == 27 {
		print!("38");
	} else if a == 11 && b == 28 {
		print!("39");
	} else if a == 11 && b == 29 {
		print!("40");
	} else if a == 11 && b == 30 {
		print!("41");
	} else if a == 11 && b == 31 {
		print!("42");
	} else if a == 11 && b == 32 {
		print!("43");
	} else if a == 11 && b == 33 {
		print!("44");
	} else if a == 11 && b == 34 {
		print!("45");
	} else if a == 11 && b == 35 {
		print!("46");
	} else if a == 11 && b == 36 {
		print!("47");
	} else if a == 11 && b == 37 {
		print!("48");
	} else if a == 11 && b == 38 {
		print!("49");
	} else if a == 11 && b == 39 {
		print!("50");
	} else if a == 11 && b == 40 {
		print!("51");
	} else if a == 11 && b == 41 {
		print!("52");
	} else if a == 11 && b == 42 {
		print!("53");
	} else if a == 11 && b == 43 {
		print!("54");
	} else if a == 11 && b == 44 {
		print!("55");
	} else if a == 11 && b == 45 {
		print!("56");
	} else if a == 11 && b == 46 {
		print!("57");
	} else if a == 11 && b == 47 {
		print!("58");
	} else if a == 11 && b == 48 {
		print!("59");
	} else if a == 11 && b == 49 {
		print!("60");
	} else if a == 11 && b == 50 {
		print!("61");
	} else if a == 12 && b == 0 {
		print!("12");
	} else if a == 12 && b == 1 {
		print!("13");
	} else if a == 12 && b == 2 {
		print!("14");
	} else if a == 12 && b == 3 {
		print!("15");
	} else if a == 12 && b == 4 {
		print!("16");
	} else if a == 12 && b == 5 {
		print!("17");
	} else if a == 12 && b == 6 {
		print!("18");
	} else if a == 12 && b == 7 {
		print!("19");
	} else if a == 12 && b == 8 {
		print!("20");
	} else if a == 12 && b == 9 {
		print!("21");
	} else if a == 12 && b == 10 {
		print!("22");
	} else if a == 12 && b == 11 {
		print!("23");
	} else if a == 12 && b == 12 {
		print!("24");
	} else if a == 12 && b == 13 {
		print!("25");
	} else if a == 12 && b == 14 {
		print!("26");
	} else if a == 12 && b == 15 {
		print!("27");
	} else if a == 12 && b == 16 {
		print!("28");
	} else if a == 12 && b == 17 {
		print!("29");
	} else if a == 12 && b == 18 {
		print!("30");
	} else if a == 12 && b == 19 {
		print!("31");
	} else if a == 12 && b == 20 {
		print!("32");
	} else if a == 12 && b == 21 {
		print!("33");
	} else if a == 12 && b == 22 {
		print!("34");
	} else if a == 12 && b == 23 {
		print!("35");
	} else if a == 12 && b == 24 {
		print!("36");
	} else if a == 12 && b == 25 {
		print!("37");
	} else if a == 12 && b == 26 {
		print!("38");
	} else if a == 12 && b == 27 {
		print!("39");
	} else if a == 12 && b == 28 {
		print!("40");
	} else if a == 12 && b == 29 {
		print!("41");
	} else if a == 12 && b == 30 {
		print!("42");
	} else if a == 12 && b == 31 {
		print!("43");
	} else if a == 12 && b == 32 {
		print!("44");
	} else if a == 12 && b == 33 {
		print!("45");
	} else if a == 12 && b == 34 {
		print!("46");
	} else if a == 12 && b == 35 {
		print!("47");
	} else if a == 12 && b == 36 {
		print!("48");
	} else if a == 12 && b == 37 {
		print!("49");
	} else if a == 12 && b == 38 {
		print!("50");
	} else if a == 12 && b == 39 {
		print!("51");
	} else if a == 12 && b == 40 {
		print!("52");
	} else if a == 12 && b == 41 {
		print!("53");
	} else if a == 12 && b == 42 {
		print!("54");
	} else if a == 12 && b == 43 {
		print!("55");
	} else if a == 12 && b == 44 {
		print!("56");
	} else if a == 12 && b == 45 {
		print!("57");
	} else if a == 12 && b == 46 {
		print!("58");
	} else if a == 12 && b == 47 {
		print!("59");
	} else if a == 12 && b == 48 {
		print!("60");
	} else if a == 12 && b == 49 {
		print!("61");
	} else if a == 12 && b == 50 {
		print!("62");
	} else if a == 13 && b == 0 {
		print!("13");
	} else if a == 13 && b == 1 {
		print!("14");
	} else if a == 13 && b == 2 {
		print!("15");
	} else if a == 13 && b == 3 {
		print!("16");
	} else if a == 13 && b == 4 {
		print!("17");
	} else if a == 13 && b == 5 {
		print!("18");
	} else if a == 13 && b == 6 {
		print!("19");
	} else if a == 13 && b == 7 {
		print!("20");
	} else if a == 13 && b == 8 {
		print!("21");
	} else if a == 13 && b == 9 {
		print!("22");
	} else if a == 13 && b == 10 {
		print!("23");
	} else if a == 13 && b == 11 {
		print!("24");
	} else if a == 13 && b == 12 {
		print!("25");
	} else if a == 13 && b == 13 {
		print!("26");
	} else if a == 13 && b == 14 {
		print!("27");
	} else if a == 13 && b == 15 {
		print!("28");
	} else if a == 13 && b == 16 {
		print!("29");
	} else if a == 13 && b == 17 {
		print!("30");
	} else if a == 13 && b == 18 {
		print!("31");
	} else if a == 13 && b == 19 {
		print!("32");
	} else if a == 13 && b == 20 {
		print!("33");
	} else if a == 13 && b == 21 {
		print!("34");
	} else if a == 13 && b == 22 {
		print!("35");
	} else if a == 13 && b == 23 {
		print!("36");
	} else if a == 13 && b == 24 {
		print!("37");
	} else if a == 13 && b == 25 {
		print!("38");
	} else if a == 13 && b == 26 {
		print!("39");
	} else if a == 13 && b == 27 {
		print!("40");
	} else if a == 13 && b == 28 {
		print!("41");
	} else if a == 13 && b == 29 {
		print!("42");
	} else if a == 13 && b == 30 {
		print!("43");
	} else if a == 13 && b == 31 {
		print!("44");
	} else if a == 13 && b == 32 {
		print!("45");
	} else if a == 13 && b == 33 {
		print!("46");
	} else if a == 13 && b == 34 {
		print!("47");
	} else if a == 13 && b == 35 {
		print!("48");
	} else if a == 13 && b == 36 {
		print!("49");
	} else if a == 13 && b == 37 {
		print!("50");
	} else if a == 13 && b == 38 {
		print!("51");
	} else if a == 13 && b == 39 {
		print!("52");
	} else if a == 13 && b == 40 {
		print!("53");
	} else if a == 13 && b == 41 {
		print!("54");
	} else if a == 13 && b == 42 {
		print!("55");
	} else if a == 13 && b == 43 {
		print!("56");
	} else if a == 13 && b == 44 {
		print!("57");
	} else if a == 13 && b == 45 {
		print!("58");
	} else if a == 13 && b == 46 {
		print!("59");
	} else if a == 13 && b == 47 {
		print!("60");
	} else if a == 13 && b == 48 {
		print!("61");
	} else if a == 13 && b == 49 {
		print!("62");
	} else if a == 13 && b == 50 {
		print!("63");
	} else if a == 14 && b == 0 {
		print!("14");
	} else if a == 14 && b == 1 {
		print!("15");
	} else if a == 14 && b == 2 {
		print!("16");
	} else if a == 14 && b == 3 {
		print!("17");
	} else if a == 14 && b == 4 {
		print!("18");
	} else if a == 14 && b == 5 {
		print!("19");
	} else if a == 14 && b == 6 {
		print!("20");
	} else if a == 14 && b == 7 {
		print!("21");
	} else if a == 14 && b == 8 {
		print!("22");
	} else if a == 14 && b == 9 {
		print!("23");
	} else if a == 14 && b == 10 {
		print!("24");
	} else if a == 14 && b == 11 {
		print!("25");
	} else if a == 14 && b == 12 {
		print!("26");
	} else if a == 14 && b == 13 {
		print!("27");
	} else if a == 14 && b == 14 {
		print!("28");
	} else if a == 14 && b == 15 {
		print!("29");
	} else if a == 14 && b == 16 {
		print!("30");
	} else if a == 14 && b == 17 {
		print!("31");
	} else if a == 14 && b == 18 {
		print!("32");
	} else if a == 14 && b == 19 {
		print!("33");
	} else if a == 14 && b == 20 {
		print!("34");
	} else if a == 14 && b == 21 {
		print!("35");
	} else if a == 14 && b == 22 {
		print!("36");
	} else if a == 14 && b == 23 {
		print!("37");
	} else if a == 14 && b == 24 {
		print!("38");
	} else if a == 14 && b == 25 {
		print!("39");
	} else if a == 14 && b == 26 {
		print!("40");
	} else if a == 14 && b == 27 {
		print!("41");
	} else if a == 14 && b == 28 {
		print!("42");
	} else if a == 14 && b == 29 {
		print!("43");
	} else if a == 14 && b == 30 {
		print!("44");
	} else if a == 14 && b == 31 {
		print!("45");
	} else if a == 14 && b == 32 {
		print!("46");
	} else if a == 14 && b == 33 {
		print!("47");
	} else if a == 14 && b == 34 {
		print!("48");
	} else if a == 14 && b == 35 {
		print!("49");
	} else if a == 14 && b == 36 {
		print!("50");
	} else if a == 14 && b == 37 {
		print!("51");
	} else if a == 14 && b == 38 {
		print!("52");
	} else if a == 14 && b == 39 {
		print!("53");
	} else if a == 14 && b == 40 {
		print!("54");
	} else if a == 14 && b == 41 {
		print!("55");
	} else if a == 14 && b == 42 {
		print!("56");
	} else if a == 14 && b == 43 {
		print!("57");
	} else if a == 14 && b == 44 {
		print!("58");
	} else if a == 14 && b == 45 {
		print!("59");
	} else if a == 14 && b == 46 {
		print!("60");
	} else if a == 14 && b == 47 {
		print!("61");
	} else if a == 14 && b == 48 {
		print!("62");
	} else if a == 14 && b == 49 {
		print!("63");
	} else if a == 14 && b == 50 {
		print!("64");
	} else if a == 15 && b == 0 {
		print!("15");
	} else if a == 15 && b == 1 {
		print!("16");
	} else if a == 15 && b == 2 {
		print!("17");
	} else if a == 15 && b == 3 {
		print!("18");
	} else if a == 15 && b == 4 {
		print!("19");
	} else if a == 15 && b == 5 {
		print!("20");
	} else if a == 15 && b == 6 {
		print!("21");
	} else if a == 15 && b == 7 {
		print!("22");
	} else if a == 15 && b == 8 {
		print!("23");
	} else if a == 15 && b == 9 {
		print!("24");
	} else if a == 15 && b == 10 {
		print!("25");
	} else if a == 15 && b == 11 {
		print!("26");
	} else if a == 15 && b == 12 {
		print!("27");
	} else if a == 15 && b == 13 {
		print!("28");
	} else if a == 15 && b == 14 {
		print!("29");
	} else if a == 15 && b == 15 {
		print!("30");
	} else if a == 15 && b == 16 {
		print!("31");
	} else if a == 15 && b == 17 {
		print!("32");
	} else if a == 15 && b == 18 {
		print!("33");
	} else if a == 15 && b == 19 {
		print!("34");
	} else if a == 15 && b == 20 {
		print!("35");
	} else if a == 15 && b == 21 {
		print!("36");
	} else if a == 15 && b == 22 {
		print!("37");
	} else if a == 15 && b == 23 {
		print!("38");
	} else if a == 15 && b == 24 {
		print!("39");
	} else if a == 15 && b == 25 {
		print!("40");
	} else if a == 15 && b == 26 {
		print!("41");
	} else if a == 15 && b == 27 {
		print!("42");
	} else if a == 15 && b == 28 {
		print!("43");
	} else if a == 15 && b == 29 {
		print!("44");
	} else if a == 15 && b == 30 {
		print!("45");
	} else if a == 15 && b == 31 {
		print!("46");
	} else if a == 15 && b == 32 {
		print!("47");
	} else if a == 15 && b == 33 {
		print!("48");
	} else if a == 15 && b == 34 {
		print!("49");
	} else if a == 15 && b == 35 {
		print!("50");
	} else if a == 15 && b == 36 {
		print!("51");
	} else if a == 15 && b == 37 {
		print!("52");
	} else if a == 15 && b == 38 {
		print!("53");
	} else if a == 15 && b == 39 {
		print!("54");
	} else if a == 15 && b == 40 {
		print!("55");
	} else if a == 15 && b == 41 {
		print!("56");
	} else if a == 15 && b == 42 {
		print!("57");
	} else if a == 15 && b == 43 {
		print!("58");
	} else if a == 15 && b == 44 {
		print!("59");
	} else if a == 15 && b == 45 {
		print!("60");
	} else if a == 15 && b == 46 {
		print!("61");
	} else if a == 15 && b == 47 {
		print!("62");
	} else if a == 15 && b == 48 {
		print!("63");
	} else if a == 15 && b == 49 {
		print!("64");
	} else if a == 15 && b == 50 {
		print!("65");
	} else if a == 16 && b == 0 {
		print!("16");
	} else if a == 16 && b == 1 {
		print!("17");
	} else if a == 16 && b == 2 {
		print!("18");
	} else if a == 16 && b == 3 {
		print!("19");
	} else if a == 16 && b == 4 {
		print!("20");
	} else if a == 16 && b == 5 {
		print!("21");
	} else if a == 16 && b == 6 {
		print!("22");
	} else if a == 16 && b == 7 {
		print!("23");
	} else if a == 16 && b == 8 {
		print!("24");
	} else if a == 16 && b == 9 {
		print!("25");
	} else if a == 16 && b == 10 {
		print!("26");
	} else if a == 16 && b == 11 {
		print!("27");
	} else if a == 16 && b == 12 {
		print!("28");
	} else if a == 16 && b == 13 {
		print!("29");
	} else if a == 16 && b == 14 {
		print!("30");
	} else if a == 16 && b == 15 {
		print!("31");
	} else if a == 16 && b == 16 {
		print!("32");
	} else if a == 16 && b == 17 {
		print!("33");
	} else if a == 16 && b == 18 {
		print!("34");
	} else if a == 16 && b == 19 {
		print!("35");
	} else if a == 16 && b == 20 {
		print!("36");
	} else if a == 16 && b == 21 {
		print!("37");
	} else if a == 16 && b == 22 {
		print!("38");
	} else if a == 16 && b == 23 {
		print!("39");
	} else if a == 16 && b == 24 {
		print!("40");
	} else if a == 16 && b == 25 {
		print!("41");
	} else if a == 16 && b == 26 {
		print!("42");
	} else if a == 16 && b == 27 {
		print!("43");
	} else if a == 16 && b == 28 {
		print!("44");
	} else if a == 16 && b == 29 {
		print!("45");
	} else if a == 16 && b == 30 {
		print!("46");
	} else if a == 16 && b == 31 {
		print!("47");
	} else if a == 16 && b == 32 {
		print!("48");
	} else if a == 16 && b == 33 {
		print!("49");
	} else if a == 16 && b == 34 {
		print!("50");
	} else if a == 16 && b == 35 {
		print!("51");
	} else if a == 16 && b == 36 {
		print!("52");
	} else if a == 16 && b == 37 {
		print!("53");
	} else if a == 16 && b == 38 {
		print!("54");
	} else if a == 16 && b == 39 {
		print!("55");
	} else if a == 16 && b == 40 {
		print!("56");
	} else if a == 16 && b == 41 {
		print!("57");
	} else if a == 16 && b == 42 {
		print!("58");
	} else if a == 16 && b == 43 {
		print!("59");
	} else if a == 16 && b == 44 {
		print!("60");
	} else if a == 16 && b == 45 {
		print!("61");
	} else if a == 16 && b == 46 {
		print!("62");
	} else if a == 16 && b == 47 {
		print!("63");
	} else if a == 16 && b == 48 {
		print!("64");
	} else if a == 16 && b == 49 {
		print!("65");
	} else if a == 16 && b == 50 {
		print!("66");
	} else if a == 17 && b == 0 {
		print!("17");
	} else if a == 17 && b == 1 {
		print!("18");
	} else if a == 17 && b == 2 {
		print!("19");
	} else if a == 17 && b == 3 {
		print!("20");
	} else if a == 17 && b == 4 {
		print!("21");
	} else if a == 17 && b == 5 {
		print!("22");
	} else if a == 17 && b == 6 {
		print!("23");
	} else if a == 17 && b == 7 {
		print!("24");
	} else if a == 17 && b == 8 {
		print!("25");
	} else if a == 17 && b == 9 {
		print!("26");
	} else if a == 17 && b == 10 {
		print!("27");
	} else if a == 17 && b == 11 {
		print!("28");
	} else if a == 17 && b == 12 {
		print!("29");
	} else if a == 17 && b == 13 {
		print!("30");
	} else if a == 17 && b == 14 {
		print!("31");
	} else if a == 17 && b == 15 {
		print!("32");
	} else if a == 17 && b == 16 {
		print!("33");
	} else if a == 17 && b == 17 {
		print!("34");
	} else if a == 17 && b == 18 {
		print!("35");
	} else if a == 17 && b == 19 {
		print!("36");
	} else if a == 17 && b == 20 {
		print!("37");
	} else if a == 17 && b == 21 {
		print!("38");
	} else if a == 17 && b == 22 {
		print!("39");
	} else if a == 17 && b == 23 {
		print!("40");
	} else if a == 17 && b == 24 {
		print!("41");
	} else if a == 17 && b == 25 {
		print!("42");
	} else if a == 17 && b == 26 {
		print!("43");
	} else if a == 17 && b == 27 {
		print!("44");
	} else if a == 17 && b == 28 {
		print!("45");
	} else if a == 17 && b == 29 {
		print!("46");
	} else if a == 17 && b == 30 {
		print!("47");
	} else if a == 17 && b == 31 {
		print!("48");
	} else if a == 17 && b == 32 {
		print!("49");
	} else if a == 17 && b == 33 {
		print!("50");
	} else if a == 17 && b == 34 {
		print!("51");
	} else if a == 17 && b == 35 {
		print!("52");
	} else if a == 17 && b == 36 {
		print!("53");
	} else if a == 17 && b == 37 {
		print!("54");
	} else if a == 17 && b == 38 {
		print!("55");
	} else if a == 17 && b == 39 {
		print!("56");
	} else if a == 17 && b == 40 {
		print!("57");
	} else if a == 17 && b == 41 {
		print!("58");
	} else if a == 17 && b == 42 {
		print!("59");
	} else if a == 17 && b == 43 {
		print!("60");
	} else if a == 17 && b == 44 {
		print!("61");
	} else if a == 17 && b == 45 {
		print!("62");
	} else if a == 17 && b == 46 {
		print!("63");
	} else if a == 17 && b == 47 {
		print!("64");
	} else if a == 17 && b == 48 {
		print!("65");
	} else if a == 17 && b == 49 {
		print!("66");
	} else if a == 17 && b == 50 {
		print!("67");
	} else if a == 18 && b == 0 {
		print!("18");
	} else if a == 18 && b == 1 {
		print!("19");
	} else if a == 18 && b == 2 {
		print!("20");
	} else if a == 18 && b == 3 {
		print!("21");
	} else if a == 18 && b == 4 {
		print!("22");
	} else if a == 18 && b == 5 {
		print!("23");
	} else if a == 18 && b == 6 {
		print!("24");
	} else if a == 18 && b == 7 {
		print!("25");
	} else if a == 18 && b == 8 {
		print!("26");
	} else if a == 18 && b == 9 {
		print!("27");
	} else if a == 18 && b == 10 {
		print!("28");
	} else if a == 18 && b == 11 {
		print!("29");
	} else if a == 18 && b == 12 {
		print!("30");
	} else if a == 18 && b == 13 {
		print!("31");
	} else if a == 18 && b == 14 {
		print!("32");
	} else if a == 18 && b == 15 {
		print!("33");
	} else if a == 18 && b == 16 {
		print!("34");
	} else if a == 18 && b == 17 {
		print!("35");
	} else if a == 18 && b == 18 {
		print!("36");
	} else if a == 18 && b == 19 {
		print!("37");
	} else if a == 18 && b == 20 {
		print!("38");
	} else if a == 18 && b == 21 {
		print!("39");
	} else if a == 18 && b == 22 {
		print!("40");
	} else if a == 18 && b == 23 {
		print!("41");
	} else if a == 18 && b == 24 {
		print!("42");
	} else if a == 18 && b == 25 {
		print!("43");
	} else if a == 18 && b == 26 {
		print!("44");
	} else if a == 18 && b == 27 {
		print!("45");
	} else if a == 18 && b == 28 {
		print!("46");
	} else if a == 18 && b == 29 {
		print!("47");
	} else if a == 18 && b == 30 {
		print!("48");
	} else if a == 18 && b == 31 {
		print!("49");
	} else if a == 18 && b == 32 {
		print!("50");
	} else if a == 18 && b == 33 {
		print!("51");
	} else if a == 18 && b == 34 {
		print!("52");
	} else if a == 18 && b == 35 {
		print!("53");
	} else if a == 18 && b == 36 {
		print!("54");
	} else if a == 18 && b == 37 {
		print!("55");
	} else if a == 18 && b == 38 {
		print!("56");
	} else if a == 18 && b == 39 {
		print!("57");
	} else if a == 18 && b == 40 {
		print!("58");
	} else if a == 18 && b == 41 {
		print!("59");
	} else if a == 18 && b == 42 {
		print!("60");
	} else if a == 18 && b == 43 {
		print!("61");
	} else if a == 18 && b == 44 {
		print!("62");
	} else if a == 18 && b == 45 {
		print!("63");
	} else if a == 18 && b == 46 {
		print!("64");
	} else if a == 18 && b == 47 {
		print!("65");
	} else if a == 18 && b == 48 {
		print!("66");
	} else if a == 18 && b == 49 {
		print!("67");
	} else if a == 18 && b == 50 {
		print!("68");
	} else if a == 19 && b == 0 {
		print!("19");
	} else if a == 19 && b == 1 {
		print!("20");
	} else if a == 19 && b == 2 {
		print!("21");
	} else if a == 19 && b == 3 {
		print!("22");
	} else if a == 19 && b == 4 {
		print!("23");
	} else if a == 19 && b == 5 {
		print!("24");
	} else if a == 19 && b == 6 {
		print!("25");
	} else if a == 19 && b == 7 {
		print!("26");
	} else if a == 19 && b == 8 {
		print!("27");
	} else if a == 19 && b == 9 {
		print!("28");
	} else if a == 19 && b == 10 {
		print!("29");
	} else if a == 19 && b == 11 {
		print!("30");
	} else if a == 19 && b == 12 {
		print!("31");
	} else if a == 19 && b == 13 {
		print!("32");
	} else if a == 19 && b == 14 {
		print!("33");
	} else if a == 19 && b == 15 {
		print!("34");
	} else if a == 19 && b == 16 {
		print!("35");
	} else if a == 19 && b == 17 {
		print!("36");
	} else if a == 19 && b == 18 {
		print!("37");
	} else if a == 19 && b == 19 {
		print!("38");
	} else if a == 19 && b == 20 {
		print!("39");
	} else if a == 19 && b == 21 {
		print!("40");
	} else if a == 19 && b == 22 {
		print!("41");
	} else if a == 19 && b == 23 {
		print!("42");
	} else if a == 19 && b == 24 {
		print!("43");
	} else if a == 19 && b == 25 {
		print!("44");
	} else if a == 19 && b == 26 {
		print!("45");
	} else if a == 19 && b == 27 {
		print!("46");
	} else if a == 19 && b == 28 {
		print!("47");
	} else if a == 19 && b == 29 {
		print!("48");
	} else if a == 19 && b == 30 {
		print!("49");
	} else if a == 19 && b == 31 {
		print!("50");
	} else if a == 19 && b == 32 {
		print!("51");
	} else if a == 19 && b == 33 {
		print!("52");
	} else if a == 19 && b == 34 {
		print!("53");
	} else if a == 19 && b == 35 {
		print!("54");
	} else if a == 19 && b == 36 {
		print!("55");
	} else if a == 19 && b == 37 {
		print!("56");
	} else if a == 19 && b == 38 {
		print!("57");
	} else if a == 19 && b == 39 {
		print!("58");
	} else if a == 19 && b == 40 {
		print!("59");
	} else if a == 19 && b == 41 {
		print!("60");
	} else if a == 19 && b == 42 {
		print!("61");
	} else if a == 19 && b == 43 {
		print!("62");
	} else if a == 19 && b == 44 {
		print!("63");
	} else if a == 19 && b == 45 {
		print!("64");
	} else if a == 19 && b == 46 {
		print!("65");
	} else if a == 19 && b == 47 {
		print!("66");
	} else if a == 19 && b == 48 {
		print!("67");
	} else if a == 19 && b == 49 {
		print!("68");
	} else if a == 19 && b == 50 {
		print!("69");
	} else if a == 20 && b == 0 {
		print!("20");
	} else if a == 20 && b == 1 {
		print!("21");
	} else if a == 20 && b == 2 {
		print!("22");
	} else if a == 20 && b == 3 {
		print!("23");
	} else if a == 20 && b == 4 {
		print!("24");
	} else if a == 20 && b == 5 {
		print!("25");
	} else if a == 20 && b == 6 {
		print!("26");
	} else if a == 20 && b == 7 {
		print!("27");
	} else if a == 20 && b == 8 {
		print!("28");
	} else if a == 20 && b == 9 {
		print!("29");
	} else if a == 20 && b == 10 {
		print!("30");
	} else if a == 20 && b == 11 {
		print!("31");
	} else if a == 20 && b == 12 {
		print!("32");
	} else if a == 20 && b == 13 {
		print!("33");
	} else if a == 20 && b == 14 {
		print!("34");
	} else if a == 20 && b == 15 {
		print!("35");
	} else if a == 20 && b == 16 {
		print!("36");
	} else if a == 20 && b == 17 {
		print!("37");
	} else if a == 20 && b == 18 {
		print!("38");
	} else if a == 20 && b == 19 {
		print!("39");
	} else if a == 20 && b == 20 {
		print!("40");
	} else if a == 20 && b == 21 {
		print!("41");
	} else if a == 20 && b == 22 {
		print!("42");
	} else if a == 20 && b == 23 {
		print!("43");
	} else if a == 20 && b == 24 {
		print!("44");
	} else if a == 20 && b == 25 {
		print!("45");
	} else if a == 20 && b == 26 {
		print!("46");
	} else if a == 20 && b == 27 {
		print!("47");
	} else if a == 20 && b == 28 {
		print!("48");
	} else if a == 20 && b == 29 {
		print!("49");
	} else if a == 20 && b == 30 {
		print!("50");
	} else if a == 20 && b == 31 {
		print!("51");
	} else if a == 20 && b == 32 {
		print!("52");
	} else if a == 20 && b == 33 {
		print!("53");
	} else if a == 20 && b == 34 {
		print!("54");
	} else if a == 20 && b == 35 {
		print!("55");
	} else if a == 20 && b == 36 {
		print!("56");
	} else if a == 20 && b == 37 {
		print!("57");
	} else if a == 20 && b == 38 {
		print!("58");
	} else if a == 20 && b == 39 {
		print!("59");
	} else if a == 20 && b == 40 {
		print!("60");
	} else if a == 20 && b == 41 {
		print!("61");
	} else if a == 20 && b == 42 {
		print!("62");
	} else if a == 20 && b == 43 {
		print!("63");
	} else if a == 20 && b == 44 {
		print!("64");
	} else if a == 20 && b == 45 {
		print!("65");
	} else if a == 20 && b == 46 {
		print!("66");
	} else if a == 20 && b == 47 {
		print!("67");
	} else if a == 20 && b == 48 {
		print!("68");
	} else if a == 20 && b == 49 {
		print!("69");
	} else if a == 20 && b == 50 {
		print!("70");
	} else if a == 21 && b == 0 {
		print!("21");
	} else if a == 21 && b == 1 {
		print!("22");
	} else if a == 21 && b == 2 {
		print!("23");
	} else if a == 21 && b == 3 {
		print!("24");
	} else if a == 21 && b == 4 {
		print!("25");
	} else if a == 21 && b == 5 {
		print!("26");
	} else if a == 21 && b == 6 {
		print!("27");
	} else if a == 21 && b == 7 {
		print!("28");
	} else if a == 21 && b == 8 {
		print!("29");
	} else if a == 21 && b == 9 {
		print!("30");
	} else if a == 21 && b == 10 {
		print!("31");
	} else if a == 21 && b == 11 {
		print!("32");
	} else if a == 21 && b == 12 {
		print!("33");
	} else if a == 21 && b == 13 {
		print!("34");
	} else if a == 21 && b == 14 {
		print!("35");
	} else if a == 21 && b == 15 {
		print!("36");
	} else if a == 21 && b == 16 {
		print!("37");
	} else if a == 21 && b == 17 {
		print!("38");
	} else if a == 21 && b == 18 {
		print!("39");
	} else if a == 21 && b == 19 {
		print!("40");
	} else if a == 21 && b == 20 {
		print!("41");
	} else if a == 21 && b == 21 {
		print!("42");
	} else if a == 21 && b == 22 {
		print!("43");
	} else if a == 21 && b == 23 {
		print!("44");
	} else if a == 21 && b == 24 {
		print!("45");
	} else if a == 21 && b == 25 {
		print!("46");
	} else if a == 21 && b == 26 {
		print!("47");
	} else if a == 21 && b == 27 {
		print!("48");
	} else if a == 21 && b == 28 {
		print!("49");
	} else if a == 21 && b == 29 {
		print!("50");
	} else if a == 21 && b == 30 {
		print!("51");
	} else if a == 21 && b == 31 {
		print!("52");
	} else if a == 21 && b == 32 {
		print!("53");
	} else if a == 21 && b == 33 {
		print!("54");
	} else if a == 21 && b == 34 {
		print!("55");
	} else if a == 21 && b == 35 {
		print!("56");
	} else if a == 21 && b == 36 {
		print!("57");
	} else if a == 21 && b == 37 {
		print!("58");
	} else if a == 21 && b == 38 {
		print!("59");
	} else if a == 21 && b == 39 {
		print!("60");
	} else if a == 21 && b == 40 {
		print!("61");
	} else if a == 21 && b == 41 {
		print!("62");
	} else if a == 21 && b == 42 {
		print!("63");
	} else if a == 21 && b == 43 {
		print!("64");
	} else if a == 21 && b == 44 {
		print!("65");
	} else if a == 21 && b == 45 {
		print!("66");
	} else if a == 21 && b == 46 {
		print!("67");
	} else if a == 21 && b == 47 {
		print!("68");
	} else if a == 21 && b == 48 {
		print!("69");
	} else if a == 21 && b == 49 {
		print!("70");
	} else if a == 21 && b == 50 {
		print!("71");
	} else if a == 22 && b == 0 {
		print!("22");
	} else if a == 22 && b == 1 {
		print!("23");
	} else if a == 22 && b == 2 {
		print!("24");
	} else if a == 22 && b == 3 {
		print!("25");
	} else if a == 22 && b == 4 {
		print!("26");
	} else if a == 22 && b == 5 {
		print!("27");
	} else if a == 22 && b == 6 {
		print!("28");
	} else if a == 22 && b == 7 {
		print!("29");
	} else if a == 22 && b == 8 {
		print!("30");
	} else if a == 22 && b == 9 {
		print!("31");
	} else if a == 22 && b == 10 {
		print!("32");
	} else if a == 22 && b == 11 {
		print!("33");
	} else if a == 22 && b == 12 {
		print!("34");
	} else if a == 22 && b == 13 {
		print!("35");
	} else if a == 22 && b == 14 {
		print!("36");
	} else if a == 22 && b == 15 {
		print!("37");
	} else if a == 22 && b == 16 {
		print!("38");
	} else if a == 22 && b == 17 {
		print!("39");
	} else if a == 22 && b == 18 {
		print!("40");
	} else if a == 22 && b == 19 {
		print!("41");
	} else if a == 22 && b == 20 {
		print!("42");
	} else if a == 22 && b == 21 {
		print!("43");
	} else if a == 22 && b == 22 {
		print!("44");
	} else if a == 22 && b == 23 {
		print!("45");
	} else if a == 22 && b == 24 {
		print!("46");
	} else if a == 22 && b == 25 {
		print!("47");
	} else if a == 22 && b == 26 {
		print!("48");
	} else if a == 22 && b == 27 {
		print!("49");
	} else if a == 22 && b == 28 {
		print!("50");
	} else if a == 22 && b == 29 {
		print!("51");
	} else if a == 22 && b == 30 {
		print!("52");
	} else if a == 22 && b == 31 {
		print!("53");
	} else if a == 22 && b == 32 {
		print!("54");
	} else if a == 22 && b == 33 {
		print!("55");
	} else if a == 22 && b == 34 {
		print!("56");
	} else if a == 22 && b == 35 {
		print!("57");
	} else if a == 22 && b == 36 {
		print!("58");
	} else if a == 22 && b == 37 {
		print!("59");
	} else if a == 22 && b == 38 {
		print!("60");
	} else if a == 22 && b == 39 {
		print!("61");
	} else if a == 22 && b == 40 {
		print!("62");
	} else if a == 22 && b == 41 {
		print!("63");
	} else if a == 22 && b == 42 {
		print!("64");
	} else if a == 22 && b == 43 {
		print!("65");
	} else if a == 22 && b == 44 {
		print!("66");
	} else if a == 22 && b == 45 {
		print!("67");
	} else if a == 22 && b == 46 {
		print!("68");
	} else if a == 22 && b == 47 {
		print!("69");
	} else if a == 22 && b == 48 {
		print!("70");
	} else if a == 22 && b == 49 {
		print!("71");
	} else if a == 22 && b == 50 {
		print!("72");
	} else if a == 23 && b == 0 {
		print!("23");
	} else if a == 23 && b == 1 {
		print!("24");
	} else if a == 23 && b == 2 {
		print!("25");
	} else if a == 23 && b == 3 {
		print!("26");
	} else if a == 23 && b == 4 {
		print!("27");
	} else if a == 23 && b == 5 {
		print!("28");
	} else if a == 23 && b == 6 {
		print!("29");
	} else if a == 23 && b == 7 {
		print!("30");
	} else if a == 23 && b == 8 {
		print!("31");
	} else if a == 23 && b == 9 {
		print!("32");
	} else if a == 23 && b == 10 {
		print!("33");
	} else if a == 23 && b == 11 {
		print!("34");
	} else if a == 23 && b == 12 {
		print!("35");
	} else if a == 23 && b == 13 {
		print!("36");
	} else if a == 23 && b == 14 {
		print!("37");
	} else if a == 23 && b == 15 {
		print!("38");
	} else if a == 23 && b == 16 {
		print!("39");
	} else if a == 23 && b == 17 {
		print!("40");
	} else if a == 23 && b == 18 {
		print!("41");
	} else if a == 23 && b == 19 {
		print!("42");
	} else if a == 23 && b == 20 {
		print!("43");
	} else if a == 23 && b == 21 {
		print!("44");
	} else if a == 23 && b == 22 {
		print!("45");
	} else if a == 23 && b == 23 {
		print!("46");
	} else if a == 23 && b == 24 {
		print!("47");
	} else if a == 23 && b == 25 {
		print!("48");
	} else if a == 23 && b == 26 {
		print!("49");
	} else if a == 23 && b == 27 {
		print!("50");
	} else if a == 23 && b == 28 {
		print!("51");
	} else if a == 23 && b == 29 {
		print!("52");
	} else if a == 23 && b == 30 {
		print!("53");
	} else if a == 23 && b == 31 {
		print!("54");
	} else if a == 23 && b == 32 {
		print!("55");
	} else if a == 23 && b == 33 {
		print!("56");
	} else if a == 23 && b == 34 {
		print!("57");
	} else if a == 23 && b == 35 {
		print!("58");
	} else if a == 23 && b == 36 {
		print!("59");
	} else if a == 23 && b == 37 {
		print!("60");
	} else if a == 23 && b == 38 {
		print!("61");
	} else if a == 23 && b == 39 {
		print!("62");
	} else if a == 23 && b == 40 {
		print!("63");
	} else if a == 23 && b == 41 {
		print!("64");
	} else if a == 23 && b == 42 {
		print!("65");
	} else if a == 23 && b == 43 {
		print!("66");
	} else if a == 23 && b == 44 {
		print!("67");
	} else if a == 23 && b == 45 {
		print!("68");
	} else if a == 23 && b == 46 {
		print!("69");
	} else if a == 23 && b == 47 {
		print!("70");
	} else if a == 23 && b == 48 {
		print!("71");
	} else if a == 23 && b == 49 {
		print!("72");
	} else if a == 23 && b == 50 {
		print!("73");
	} else if a == 24 && b == 0 {
		print!("24");
	} else if a == 24 && b == 1 {
		print!("25");
	} else if a == 24 && b == 2 {
		print!("26");
	} else if a == 24 && b == 3 {
		print!("27");
	} else if a == 24 && b == 4 {
		print!("28");
	} else if a == 24 && b == 5 {
		print!("29");
	} else if a == 24 && b == 6 {
		print!("30");
	} else if a == 24 && b == 7 {
		print!("31");
	} else if a == 24 && b == 8 {
		print!("32");
	} else if a == 24 && b == 9 {
		print!("33");
	} else if a == 24 && b == 10 {
		print!("34");
	} else if a == 24 && b == 11 {
		print!("35");
	} else if a == 24 && b == 12 {
		print!("36");
	} else if a == 24 && b == 13 {
		print!("37");
	} else if a == 24 && b == 14 {
		print!("38");
	} else if a == 24 && b == 15 {
		print!("39");
	} else if a == 24 && b == 16 {
		print!("40");
	} else if a == 24 && b == 17 {
		print!("41");
	} else if a == 24 && b == 18 {
		print!("42");
	} else if a == 24 && b == 19 {
		print!("43");
	} else if a == 24 && b == 20 {
		print!("44");
	} else if a == 24 && b == 21 {
		print!("45");
	} else if a == 24 && b == 22 {
		print!("46");
	} else if a == 24 && b == 23 {
		print!("47");
	} else if a == 24 && b == 24 {
		print!("48");
	} else if a == 24 && b == 25 {
		print!("49");
	} else if a == 24 && b == 26 {
		print!("50");
	} else if a == 24 && b == 27 {
		print!("51");
	} else if a == 24 && b == 28 {
		print!("52");
	} else if a == 24 && b == 29 {
		print!("53");
	} else if a == 24 && b == 30 {
		print!("54");
	} else if a == 24 && b == 31 {
		print!("55");
	} else if a == 24 && b == 32 {
		print!("56");
	} else if a == 24 && b == 33 {
		print!("57");
	} else if a == 24 && b == 34 {
		print!("58");
	} else if a == 24 && b == 35 {
		print!("59");
	} else if a == 24 && b == 36 {
		print!("60");
	} else if a == 24 && b == 37 {
		print!("61");
	} else if a == 24 && b == 38 {
		print!("62");
	} else if a == 24 && b == 39 {
		print!("63");
	} else if a == 24 && b == 40 {
		print!("64");
	} else if a == 24 && b == 41 {
		print!("65");
	} else if a == 24 && b == 42 {
		print!("66");
	} else if a == 24 && b == 43 {
		print!("67");
	} else if a == 24 && b == 44 {
		print!("68");
	} else if a == 24 && b == 45 {
		print!("69");
	} else if a == 24 && b == 46 {
		print!("70");
	} else if a == 24 && b == 47 {
		print!("71");
	} else if a == 24 && b == 48 {
		print!("72");
	} else if a == 24 && b == 49 {
		print!("73");
	} else if a == 24 && b == 50 {
		print!("74");
	} else if a == 25 && b == 0 {
		print!("25");
	} else if a == 25 && b == 1 {
		print!("26");
	} else if a == 25 && b == 2 {
		print!("27");
	} else if a == 25 && b == 3 {
		print!("28");
	} else if a == 25 && b == 4 {
		print!("29");
	} else if a == 25 && b == 5 {
		print!("30");
	} else if a == 25 && b == 6 {
		print!("31");
	} else if a == 25 && b == 7 {
		print!("32");
	} else if a == 25 && b == 8 {
		print!("33");
	} else if a == 25 && b == 9 {
		print!("34");
	} else if a == 25 && b == 10 {
		print!("35");
	} else if a == 25 && b == 11 {
		print!("36");
	} else if a == 25 && b == 12 {
		print!("37");
	} else if a == 25 && b == 13 {
		print!("38");
	} else if a == 25 && b == 14 {
		print!("39");
	} else if a == 25 && b == 15 {
		print!("40");
	} else if a == 25 && b == 16 {
		print!("41");
	} else if a == 25 && b == 17 {
		print!("42");
	} else if a == 25 && b == 18 {
		print!("43");
	} else if a == 25 && b == 19 {
		print!("44");
	} else if a == 25 && b == 20 {
		print!("45");
	} else if a == 25 && b == 21 {
		print!("46");
	} else if a == 25 && b == 22 {
		print!("47");
	} else if a == 25 && b == 23 {
		print!("48");
	} else if a == 25 && b == 24 {
		print!("49");
	} else if a == 25 && b == 25 {
		print!("50");
	} else if a == 25 && b == 26 {
		print!("51");
	} else if a == 25 && b == 27 {
		print!("52");
	} else if a == 25 && b == 28 {
		print!("53");
	} else if a == 25 && b == 29 {
		print!("54");
	} else if a == 25 && b == 30 {
		print!("55");
	} else if a == 25 && b == 31 {
		print!("56");
	} else if a == 25 && b == 32 {
		print!("57");
	} else if a == 25 && b == 33 {
		print!("58");
	} else if a == 25 && b == 34 {
		print!("59");
	} else if a == 25 && b == 35 {
		print!("60");
	} else if a == 25 && b == 36 {
		print!("61");
	} else if a == 25 && b == 37 {
		print!("62");
	} else if a == 25 && b == 38 {
		print!("63");
	} else if a == 25 && b == 39 {
		print!("64");
	} else if a == 25 && b == 40 {
		print!("65");
	} else if a == 25 && b == 41 {
		print!("66");
	} else if a == 25 && b == 42 {
		print!("67");
	} else if a == 25 && b == 43 {
		print!("68");
	} else if a == 25 && b == 44 {
		print!("69");
	} else if a == 25 && b == 45 {
		print!("70");
	} else if a == 25 && b == 46 {
		print!("71");
	} else if a == 25 && b == 47 {
		print!("72");
	} else if a == 25 && b == 48 {
		print!("73");
	} else if a == 25 && b == 49 {
		print!("74");
	} else if a == 25 && b == 50 {
		print!("75");
	} else if a == 26 && b == 0 {
		print!("26");
	} else if a == 26 && b == 1 {
		print!("27");
	} else if a == 26 && b == 2 {
		print!("28");
	} else if a == 26 && b == 3 {
		print!("29");
	} else if a == 26 && b == 4 {
		print!("30");
	} else if a == 26 && b == 5 {
		print!("31");
	} else if a == 26 && b == 6 {
		print!("32");
	} else if a == 26 && b == 7 {
		print!("33");
	} else if a == 26 && b == 8 {
		print!("34");
	} else if a == 26 && b == 9 {
		print!("35");
	} else if a == 26 && b == 10 {
		print!("36");
	} else if a == 26 && b == 11 {
		print!("37");
	} else if a == 26 && b == 12 {
		print!("38");
	} else if a == 26 && b == 13 {
		print!("39");
	} else if a == 26 && b == 14 {
		print!("40");
	} else if a == 26 && b == 15 {
		print!("41");
	} else if a == 26 && b == 16 {
		print!("42");
	} else if a == 26 && b == 17 {
		print!("43");
	} else if a == 26 && b == 18 {
		print!("44");
	} else if a == 26 && b == 19 {
		print!("45");
	} else if a == 26 && b == 20 {
		print!("46");
	} else if a == 26 && b == 21 {
		print!("47");
	} else if a == 26 && b == 22 {
		print!("48");
	} else if a == 26 && b == 23 {
		print!("49");
	} else if a == 26 && b == 24 {
		print!("50");
	} else if a == 26 && b == 25 {
		print!("51");
	} else if a == 26 && b == 26 {
		print!("52");
	} else if a == 26 && b == 27 {
		print!("53");
	} else if a == 26 && b == 28 {
		print!("54");
	} else if a == 26 && b == 29 {
		print!("55");
	} else if a == 26 && b == 30 {
		print!("56");
	} else if a == 26 && b == 31 {
		print!("57");
	} else if a == 26 && b == 32 {
		print!("58");
	} else if a == 26 && b == 33 {
		print!("59");
	} else if a == 26 && b == 34 {
		print!("60");
	} else if a == 26 && b == 35 {
		print!("61");
	} else if a == 26 && b == 36 {
		print!("62");
	} else if a == 26 && b == 37 {
		print!("63");
	} else if a == 26 && b == 38 {
		print!("64");
	} else if a == 26 && b == 39 {
		print!("65");
	} else if a == 26 && b == 40 {
		print!("66");
	} else if a == 26 && b == 41 {
		print!("67");
	} else if a == 26 && b == 42 {
		print!("68");
	} else if a == 26 && b == 43 {
		print!("69");
	} else if a == 26 && b == 44 {
		print!("70");
	} else if a == 26 && b == 45 {
		print!("71");
	} else if a == 26 && b == 46 {
		print!("72");
	} else if a == 26 && b == 47 {
		print!("73");
	} else if a == 26 && b == 48 {
		print!("74");
	} else if a == 26 && b == 49 {
		print!("75");
	} else if a == 26 && b == 50 {
		print!("76");
	} else if a == 27 && b == 0 {
		print!("27");
	} else if a == 27 && b == 1 {
		print!("28");
	} else if a == 27 && b == 2 {
		print!("29");
	} else if a == 27 && b == 3 {
		print!("30");
	} else if a == 27 && b == 4 {
		print!("31");
	} else if a == 27 && b == 5 {
		print!("32");
	} else if a == 27 && b == 6 {
		print!("33");
	} else if a == 27 && b == 7 {
		print!("34");
	} else if a == 27 && b == 8 {
		print!("35");
	} else if a == 27 && b == 9 {
		print!("36");
	} else if a == 27 && b == 10 {
		print!("37");
	} else if a == 27 && b == 11 {
		print!("38");
	} else if a == 27 && b == 12 {
		print!("39");
	} else if a == 27 && b == 13 {
		print!("40");
	} else if a == 27 && b == 14 {
		print!("41");
	} else if a == 27 && b == 15 {
		print!("42");
	} else if a == 27 && b == 16 {
		print!("43");
	} else if a == 27 && b == 17 {
		print!("44");
	} else if a == 27 && b == 18 {
		print!("45");
	} else if a == 27 && b == 19 {
		print!("46");
	} else if a == 27 && b == 20 {
		print!("47");
	} else if a == 27 && b == 21 {
		print!("48");
	} else if a == 27 && b == 22 {
		print!("49");
	} else if a == 27 && b == 23 {
		print!("50");
	} else if a == 27 && b == 24 {
		print!("51");
	} else if a == 27 && b == 25 {
		print!("52");
	} else if a == 27 && b == 26 {
		print!("53");
	} else if a == 27 && b == 27 {
		print!("54");
	} else if a == 27 && b == 28 {
		print!("55");
	} else if a == 27 && b == 29 {
		print!("56");
	} else if a == 27 && b == 30 {
		print!("57");
	} else if a == 27 && b == 31 {
		print!("58");
	} else if a == 27 && b == 32 {
		print!("59");
	} else if a == 27 && b == 33 {
		print!("60");
	} else if a == 27 && b == 34 {
		print!("61");
	} else if a == 27 && b == 35 {
		print!("62");
	} else if a == 27 && b == 36 {
		print!("63");
	} else if a == 27 && b == 37 {
		print!("64");
	} else if a == 27 && b == 38 {
		print!("65");
	} else if a == 27 && b == 39 {
		print!("66");
	} else if a == 27 && b == 40 {
		print!("67");
	} else if a == 27 && b == 41 {
		print!("68");
	} else if a == 27 && b == 42 {
		print!("69");
	} else if a == 27 && b == 43 {
		print!("70");
	} else if a == 27 && b == 44 {
		print!("71");
	} else if a == 27 && b == 45 {
		print!("72");
	} else if a == 27 && b == 46 {
		print!("73");
	} else if a == 27 && b == 47 {
		print!("74");
	} else if a == 27 && b == 48 {
		print!("75");
	} else if a == 27 && b == 49 {
		print!("76");
	} else if a == 27 && b == 50 {
		print!("77");
	} else if a == 28 && b == 0 {
		print!("28");
	} else if a == 28 && b == 1 {
		print!("29");
	} else if a == 28 && b == 2 {
		print!("30");
	} else if a == 28 && b == 3 {
		print!("31");
	} else if a == 28 && b == 4 {
		print!("32");
	} else if a == 28 && b == 5 {
		print!("33");
	} else if a == 28 && b == 6 {
		print!("34");
	} else if a == 28 && b == 7 {
		print!("35");
	} else if a == 28 && b == 8 {
		print!("36");
	} else if a == 28 && b == 9 {
		print!("37");
	} else if a == 28 && b == 10 {
		print!("38");
	} else if a == 28 && b == 11 {
		print!("39");
	} else if a == 28 && b == 12 {
		print!("40");
	} else if a == 28 && b == 13 {
		print!("41");
	} else if a == 28 && b == 14 {
		print!("42");
	} else if a == 28 && b == 15 {
		print!("43");
	} else if a == 28 && b == 16 {
		print!("44");
	} else if a == 28 && b == 17 {
		print!("45");
	} else if a == 28 && b == 18 {
		print!("46");
	} else if a == 28 && b == 19 {
		print!("47");
	} else if a == 28 && b == 20 {
		print!("48");
	} else if a == 28 && b == 21 {
		print!("49");
	} else if a == 28 && b == 22 {
		print!("50");
	} else if a == 28 && b == 23 {
		print!("51");
	} else if a == 28 && b == 24 {
		print!("52");
	} else if a == 28 && b == 25 {
		print!("53");
	} else if a == 28 && b == 26 {
		print!("54");
	} else if a == 28 && b == 27 {
		print!("55");
	} else if a == 28 && b == 28 {
		print!("56");
	} else if a == 28 && b == 29 {
		print!("57");
	} else if a == 28 && b == 30 {
		print!("58");
	} else if a == 28 && b == 31 {
		print!("59");
	} else if a == 28 && b == 32 {
		print!("60");
	} else if a == 28 && b == 33 {
		print!("61");
	} else if a == 28 && b == 34 {
		print!("62");
	} else if a == 28 && b == 35 {
		print!("63");
	} else if a == 28 && b == 36 {
		print!("64");
	} else if a == 28 && b == 37 {
		print!("65");
	} else if a == 28 && b == 38 {
		print!("66");
	} else if a == 28 && b == 39 {
		print!("67");
	} else if a == 28 && b == 40 {
		print!("68");
	} else if a == 28 && b == 41 {
		print!("69");
	} else if a == 28 && b == 42 {
		print!("70");
	} else if a == 28 && b == 43 {
		print!("71");
	} else if a == 28 && b == 44 {
		print!("72");
	} else if a == 28 && b == 45 {
		print!("73");
	} else if a == 28 && b == 46 {
		print!("74");
	} else if a == 28 && b == 47 {
		print!("75");
	} else if a == 28 && b == 48 {
		print!("76");
	} else if a == 28 && b == 49 {
		print!("77");
	} else if a == 28 && b == 50 {
		print!("78");
	} else if a == 29 && b == 0 {
		print!("29");
	} else if a == 29 && b == 1 {
		print!("30");
	} else if a == 29 && b == 2 {
		print!("31");
	} else if a == 29 && b == 3 {
		print!("32");
	} else if a == 29 && b == 4 {
		print!("33");
	} else if a == 29 && b == 5 {
		print!("34");
	} else if a == 29 && b == 6 {
		print!("35");
	} else if a == 29 && b == 7 {
		print!("36");
	} else if a == 29 && b == 8 {
		print!("37");
	} else if a == 29 && b == 9 {
		print!("38");
	} else if a == 29 && b == 10 {
		print!("39");
	} else if a == 29 && b == 11 {
		print!("40");
	} else if a == 29 && b == 12 {
		print!("41");
	} else if a == 29 && b == 13 {
		print!("42");
	} else if a == 29 && b == 14 {
		print!("43");
	} else if a == 29 && b == 15 {
		print!("44");
	} else if a == 29 && b == 16 {
		print!("45");
	} else if a == 29 && b == 17 {
		print!("46");
	} else if a == 29 && b == 18 {
		print!("47");
	} else if a == 29 && b == 19 {
		print!("48");
	} else if a == 29 && b == 20 {
		print!("49");
	} else if a == 29 && b == 21 {
		print!("50");
	} else if a == 29 && b == 22 {
		print!("51");
	} else if a == 29 && b == 23 {
		print!("52");
	} else if a == 29 && b == 24 {
		print!("53");
	} else if a == 29 && b == 25 {
		print!("54");
	} else if a == 29 && b == 26 {
		print!("55");
	} else if a == 29 && b == 27 {
		print!("56");
	} else if a == 29 && b == 28 {
		print!("57");
	} else if a == 29 && b == 29 {
		print!("58");
	} else if a == 29 && b == 30 {
		print!("59");
	} else if a == 29 && b == 31 {
		print!("60");
	} else if a == 29 && b == 32 {
		print!("61");
	} else if a == 29 && b == 33 {
		print!("62");
	} else if a == 29 && b == 34 {
		print!("63");
	} else if a == 29 && b == 35 {
		print!("64");
	} else if a == 29 && b == 36 {
		print!("65");
	} else if a == 29 && b == 37 {
		print!("66");
	} else if a == 29 && b == 38 {
		print!("67");
	} else if a == 29 && b == 39 {
		print!("68");
	} else if a == 29 && b == 40 {
		print!("69");
	} else if a == 29 && b == 41 {
		print!("70");
	} else if a == 29 && b == 42 {
		print!("71");
	} else if a == 29 && b == 43 {
		print!("72");
	} else if a == 29 && b == 44 {
		print!("73");
	} else if a == 29 && b == 45 {
		print!("74");
	} else if a == 29 && b == 46 {
		print!("75");
	} else if a == 29 && b == 47 {
		print!("76");
	} else if a == 29 && b == 48 {
		print!("77");
	} else if a == 29 && b == 49 {
		print!("78");
	} else if a == 29 && b == 50 {
		print!("79");
	} else if a == 30 && b == 0 {
		print!("30");
	} else if a == 30 && b == 1 {
		print!("31");
	} else if a == 30 && b == 2 {
		print!("32");
	} else if a == 30 && b == 3 {
		print!("33");
	} else if a == 30 && b == 4 {
		print!("34");
	} else if a == 30 && b == 5 {
		print!("35");
	} else if a == 30 && b == 6 {
		print!("36");
	} else if a == 30 && b == 7 {
		print!("37");
	} else if a == 30 && b == 8 {
		print!("38");
	} else if a == 30 && b == 9 {
		print!("39");
	} else if a == 30 && b == 10 {
		print!("40");
	} else if a == 30 && b == 11 {
		print!("41");
	} else if a == 30 && b == 12 {
		print!("42");
	} else if a == 30 && b == 13 {
		print!("43");
	} else if a == 30 && b == 14 {
		print!("44");
	} else if a == 30 && b == 15 {
		print!("45");
	} else if a == 30 && b == 16 {
		print!("46");
	} else if a == 30 && b == 17 {
		print!("47");
	} else if a == 30 && b == 18 {
		print!("48");
	} else if a == 30 && b == 19 {
		print!("49");
	} else if a == 30 && b == 20 {
		print!("50");
	} else if a == 30 && b == 21 {
		print!("51");
	} else if a == 30 && b == 22 {
		print!("52");
	} else if a == 30 && b == 23 {
		print!("53");
	} else if a == 30 && b == 24 {
		print!("54");
	} else if a == 30 && b == 25 {
		print!("55");
	} else if a == 30 && b == 26 {
		print!("56");
	} else if a == 30 && b == 27 {
		print!("57");
	} else if a == 30 && b == 28 {
		print!("58");
	} else if a == 30 && b == 29 {
		print!("59");
	} else if a == 30 && b == 30 {
		print!("60");
	} else if a == 30 && b == 31 {
		print!("61");
	} else if a == 30 && b == 32 {
		print!("62");
	} else if a == 30 && b == 33 {
		print!("63");
	} else if a == 30 && b == 34 {
		print!("64");
	} else if a == 30 && b == 35 {
		print!("65");
	} else if a == 30 && b == 36 {
		print!("66");
	} else if a == 30 && b == 37 {
		print!("67");
	} else if a == 30 && b == 38 {
		print!("68");
	} else if a == 30 && b == 39 {
		print!("69");
	} else if a == 30 && b == 40 {
		print!("70");
	} else if a == 30 && b == 41 {
		print!("71");
	} else if a == 30 && b == 42 {
		print!("72");
	} else if a == 30 && b == 43 {
		print!("73");
	} else if a == 30 && b == 44 {
		print!("74");
	} else if a == 30 && b == 45 {
		print!("75");
	} else if a == 30 && b == 46 {
		print!("76");
	} else if a == 30 && b == 47 {
		print!("77");
	} else if a == 30 && b == 48 {
		print!("78");
	} else if a == 30 && b == 49 {
		print!("79");
	} else if a == 30 && b == 50 {
		print!("80");
	} else if a == 31 && b == 0 {
		print!("31");
	} else if a == 31 && b == 1 {
		print!("32");
	} else if a == 31 && b == 2 {
		print!("33");
	} else if a == 31 && b == 3 {
		print!("34");
	} else if a == 31 && b == 4 {
		print!("35");
	} else if a == 31 && b == 5 {
		print!("36");
	} else if a == 31 && b == 6 {
		print!("37");
	} else if a == 31 && b == 7 {
		print!("38");
	} else if a == 31 && b == 8 {
		print!("39");
	} else if a == 31 && b == 9 {
		print!("40");
	} else if a == 31 && b == 10 {
		print!("41");
	} else if a == 31 && b == 11 {
		print!("42");
	} else if a == 31 && b == 12 {
		print!("43");
	} else if a == 31 && b == 13 {
		print!("44");
	} else if a == 31 && b == 14 {
		print!("45");
	} else if a == 31 && b == 15 {
		print!("46");
	} else if a == 31 && b == 16 {
		print!("47");
	} else if a == 31 && b == 17 {
		print!("48");
	} else if a == 31 && b == 18 {
		print!("49");
	} else if a == 31 && b == 19 {
		print!("50");
	} else if a == 31 && b == 20 {
		print!("51");
	} else if a == 31 && b == 21 {
		print!("52");
	} else if a == 31 && b == 22 {
		print!("53");
	} else if a == 31 && b == 23 {
		print!("54");
	} else if a == 31 && b == 24 {
		print!("55");
	} else if a == 31 && b == 25 {
		print!("56");
	} else if a == 31 && b == 26 {
		print!("57");
	} else if a == 31 && b == 27 {
		print!("58");
	} else if a == 31 && b == 28 {
		print!("59");
	} else if a == 31 && b == 29 {
		print!("60");
	} else if a == 31 && b == 30 {
		print!("61");
	} else if a == 31 && b == 31 {
		print!("62");
	} else if a == 31 && b == 32 {
		print!("63");
	} else if a == 31 && b == 33 {
		print!("64");
	} else if a == 31 && b == 34 {
		print!("65");
	} else if a == 31 && b == 35 {
		print!("66");
	} else if a == 31 && b == 36 {
		print!("67");
	} else if a == 31 && b == 37 {
		print!("68");
	} else if a == 31 && b == 38 {
		print!("69");
	} else if a == 31 && b == 39 {
		print!("70");
	} else if a == 31 && b == 40 {
		print!("71");
	} else if a == 31 && b == 41 {
		print!("72");
	} else if a == 31 && b == 42 {
		print!("73");
	} else if a == 31 && b == 43 {
		print!("74");
	} else if a == 31 && b == 44 {
		print!("75");
	} else if a == 31 && b == 45 {
		print!("76");
	} else if a == 31 && b == 46 {
		print!("77");
	} else if a == 31 && b == 47 {
		print!("78");
	} else if a == 31 && b == 48 {
		print!("79");
	} else if a == 31 && b == 49 {
		print!("80");
	} else if a == 31 && b == 50 {
		print!("81");
	} else if a == 32 && b == 0 {
		print!("32");
	} else if a == 32 && b == 1 {
		print!("33");
	} else if a == 32 && b == 2 {
		print!("34");
	} else if a == 32 && b == 3 {
		print!("35");
	} else if a == 32 && b == 4 {
		print!("36");
	} else if a == 32 && b == 5 {
		print!("37");
	} else if a == 32 && b == 6 {
		print!("38");
	} else if a == 32 && b == 7 {
		print!("39");
	} else if a == 32 && b == 8 {
		print!("40");
	} else if a == 32 && b == 9 {
		print!("41");
	} else if a == 32 && b == 10 {
		print!("42");
	} else if a == 32 && b == 11 {
		print!("43");
	} else if a == 32 && b == 12 {
		print!("44");
	} else if a == 32 && b == 13 {
		print!("45");
	} else if a == 32 && b == 14 {
		print!("46");
	} else if a == 32 && b == 15 {
		print!("47");
	} else if a == 32 && b == 16 {
		print!("48");
	} else if a == 32 && b == 17 {
		print!("49");
	} else if a == 32 && b == 18 {
		print!("50");
	} else if a == 32 && b == 19 {
		print!("51");
	} else if a == 32 && b == 20 {
		print!("52");
	} else if a == 32 && b == 21 {
		print!("53");
	} else if a == 32 && b == 22 {
		print!("54");
	} else if a == 32 && b == 23 {
		print!("55");
	} else if a == 32 && b == 24 {
		print!("56");
	} else if a == 32 && b == 25 {
		print!("57");
	} else if a == 32 && b == 26 {
		print!("58");
	} else if a == 32 && b == 27 {
		print!("59");
	} else if a == 32 && b == 28 {
		print!("60");
	} else if a == 32 && b == 29 {
		print!("61");
	} else if a == 32 && b == 30 {
		print!("62");
	} else if a == 32 && b == 31 {
		print!("63");
	} else if a == 32 && b == 32 {
		print!("64");
	} else if a == 32 && b == 33 {
		print!("65");
	} else if a == 32 && b == 34 {
		print!("66");
	} else if a == 32 && b == 35 {
		print!("67");
	} else if a == 32 && b == 36 {
		print!("68");
	} else if a == 32 && b == 37 {
		print!("69");
	} else if a == 32 && b == 38 {
		print!("70");
	} else if a == 32 && b == 39 {
		print!("71");
	} else if a == 32 && b == 40 {
		print!("72");
	} else if a == 32 && b == 41 {
		print!("73");
	} else if a == 32 && b == 42 {
		print!("74");
	} else if a == 32 && b == 43 {
		print!("75");
	} else if a == 32 && b == 44 {
		print!("76");
	} else if a == 32 && b == 45 {
		print!("77");
	} else if a == 32 && b == 46 {
		print!("78");
	} else if a == 32 && b == 47 {
		print!("79");
	} else if a == 32 && b == 48 {
		print!("80");
	} else if a == 32 && b == 49 {
		print!("81");
	} else if a == 32 && b == 50 {
		print!("82");
	} else if a == 33 && b == 0 {
		print!("33");
	} else if a == 33 && b == 1 {
		print!("34");
	} else if a == 33 && b == 2 {
		print!("35");
	} else if a == 33 && b == 3 {
		print!("36");
	} else if a == 33 && b == 4 {
		print!("37");
	} else if a == 33 && b == 5 {
		print!("38");
	} else if a == 33 && b == 6 {
		print!("39");
	} else if a == 33 && b == 7 {
		print!("40");
	} else if a == 33 && b == 8 {
		print!("41");
	} else if a == 33 && b == 9 {
		print!("42");
	} else if a == 33 && b == 10 {
		print!("43");
	} else if a == 33 && b == 11 {
		print!("44");
	} else if a == 33 && b == 12 {
		print!("45");
	} else if a == 33 && b == 13 {
		print!("46");
	} else if a == 33 && b == 14 {
		print!("47");
	} else if a == 33 && b == 15 {
		print!("48");
	} else if a == 33 && b == 16 {
		print!("49");
	} else if a == 33 && b == 17 {
		print!("50");
	} else if a == 33 && b == 18 {
		print!("51");
	} else if a == 33 && b == 19 {
		print!("52");
	} else if a == 33 && b == 20 {
		print!("53");
	} else if a == 33 && b == 21 {
		print!("54");
	} else if a == 33 && b == 22 {
		print!("55");
	} else if a == 33 && b == 23 {
		print!("56");
	} else if a == 33 && b == 24 {
		print!("57");
	} else if a == 33 && b == 25 {
		print!("58");
	} else if a == 33 && b == 26 {
		print!("59");
	} else if a == 33 && b == 27 {
		print!("60");
	} else if a == 33 && b == 28 {
		print!("61");
	} else if a == 33 && b == 29 {
		print!("62");
	} else if a == 33 && b == 30 {
		print!("63");
	} else if a == 33 && b == 31 {
		print!("64");
	} else if a == 33 && b == 32 {
		print!("65");
	} else if a == 33 && b == 33 {
		print!("66");
	} else if a == 33 && b == 34 {
		print!("67");
	} else if a == 33 && b == 35 {
		print!("68");
	} else if a == 33 && b == 36 {
		print!("69");
	} else if a == 33 && b == 37 {
		print!("70");
	} else if a == 33 && b == 38 {
		print!("71");
	} else if a == 33 && b == 39 {
		print!("72");
	} else if a == 33 && b == 40 {
		print!("73");
	} else if a == 33 && b == 41 {
		print!("74");
	} else if a == 33 && b == 42 {
		print!("75");
	} else if a == 33 && b == 43 {
		print!("76");
	} else if a == 33 && b == 44 {
		print!("77");
	} else if a == 33 && b == 45 {
		print!("78");
	} else if a == 33 && b == 46 {
		print!("79");
	} else if a == 33 && b == 47 {
		print!("80");
	} else if a == 33 && b == 48 {
		print!("81");
	} else if a == 33 && b == 49 {
		print!("82");
	} else if a == 33 && b == 50 {
		print!("83");
	} else if a == 34 && b == 0 {
		print!("34");
	} else if a == 34 && b == 1 {
		print!("35");
	} else if a == 34 && b == 2 {
		print!("36");
	} else if a == 34 && b == 3 {
		print!("37");
	} else if a == 34 && b == 4 {
		print!("38");
	} else if a == 34 && b == 5 {
		print!("39");
	} else if a == 34 && b == 6 {
		print!("40");
	} else if a == 34 && b == 7 {
		print!("41");
	} else if a == 34 && b == 8 {
		print!("42");
	} else if a == 34 && b == 9 {
		print!("43");
	} else if a == 34 && b == 10 {
		print!("44");
	} else if a == 34 && b == 11 {
		print!("45");
	} else if a == 34 && b == 12 {
		print!("46");
	} else if a == 34 && b == 13 {
		print!("47");
	} else if a == 34 && b == 14 {
		print!("48");
	} else if a == 34 && b == 15 {
		print!("49");
	} else if a == 34 && b == 16 {
		print!("50");
	} else if a == 34 && b == 17 {
		print!("51");
	} else if a == 34 && b == 18 {
		print!("52");
	} else if a == 34 && b == 19 {
		print!("53");
	} else if a == 34 && b == 20 {
		print!("54");
	} else if a == 34 && b == 21 {
		print!("55");
	} else if a == 34 && b == 22 {
		print!("56");
	} else if a == 34 && b == 23 {
		print!("57");
	} else if a == 34 && b == 24 {
		print!("58");
	} else if a == 34 && b == 25 {
		print!("59");
	} else if a == 34 && b == 26 {
		print!("60");
	} else if a == 34 && b == 27 {
		print!("61");
	} else if a == 34 && b == 28 {
		print!("62");
	} else if a == 34 && b == 29 {
		print!("63");
	} else if a == 34 && b == 30 {
		print!("64");
	} else if a == 34 && b == 31 {
		print!("65");
	} else if a == 34 && b == 32 {
		print!("66");
	} else if a == 34 && b == 33 {
		print!("67");
	} else if a == 34 && b == 34 {
		print!("68");
	} else if a == 34 && b == 35 {
		print!("69");
	} else if a == 34 && b == 36 {
		print!("70");
	} else if a == 34 && b == 37 {
		print!("71");
	} else if a == 34 && b == 38 {
		print!("72");
	} else if a == 34 && b == 39 {
		print!("73");
	} else if a == 34 && b == 40 {
		print!("74");
	} else if a == 34 && b == 41 {
		print!("75");
	} else if a == 34 && b == 42 {
		print!("76");
	} else if a == 34 && b == 43 {
		print!("77");
	} else if a == 34 && b == 44 {
		print!("78");
	} else if a == 34 && b == 45 {
		print!("79");
	} else if a == 34 && b == 46 {
		print!("80");
	} else if a == 34 && b == 47 {
		print!("81");
	} else if a == 34 && b == 48 {
		print!("82");
	} else if a == 34 && b == 49 {
		print!("83");
	} else if a == 34 && b == 50 {
		print!("84");
	} else if a == 35 && b == 0 {
		print!("35");
	} else if a == 35 && b == 1 {
		print!("36");
	} else if a == 35 && b == 2 {
		print!("37");
	} else if a == 35 && b == 3 {
		print!("38");
	} else if a == 35 && b == 4 {
		print!("39");
	} else if a == 35 && b == 5 {
		print!("40");
	} else if a == 35 && b == 6 {
		print!("41");
	} else if a == 35 && b == 7 {
		print!("42");
	} else if a == 35 && b == 8 {
		print!("43");
	} else if a == 35 && b == 9 {
		print!("44");
	} else if a == 35 && b == 10 {
		print!("45");
	} else if a == 35 && b == 11 {
		print!("46");
	} else if a == 35 && b == 12 {
		print!("47");
	} else if a == 35 && b == 13 {
		print!("48");
	} else if a == 35 && b == 14 {
		print!("49");
	} else if a == 35 && b == 15 {
		print!("50");
	} else if a == 35 && b == 16 {
		print!("51");
	} else if a == 35 && b == 17 {
		print!("52");
	} else if a == 35 && b == 18 {
		print!("53");
	} else if a == 35 && b == 19 {
		print!("54");
	} else if a == 35 && b == 20 {
		print!("55");
	} else if a == 35 && b == 21 {
		print!("56");
	} else if a == 35 && b == 22 {
		print!("57");
	} else if a == 35 && b == 23 {
		print!("58");
	} else if a == 35 && b == 24 {
		print!("59");
	} else if a == 35 && b == 25 {
		print!("60");
	} else if a == 35 && b == 26 {
		print!("61");
	} else if a == 35 && b == 27 {
		print!("62");
	} else if a == 35 && b == 28 {
		print!("63");
	} else if a == 35 && b == 29 {
		print!("64");
	} else if a == 35 && b == 30 {
		print!("65");
	} else if a == 35 && b == 31 {
		print!("66");
	} else if a == 35 && b == 32 {
		print!("67");
	} else if a == 35 && b == 33 {
		print!("68");
	} else if a == 35 && b == 34 {
		print!("69");
	} else if a == 35 && b == 35 {
		print!("70");
	} else if a == 35 && b == 36 {
		print!("71");
	} else if a == 35 && b == 37 {
		print!("72");
	} else if a == 35 && b == 38 {
		print!("73");
	} else if a == 35 && b == 39 {
		print!("74");
	} else if a == 35 && b == 40 {
		print!("75");
	} else if a == 35 && b == 41 {
		print!("76");
	} else if a == 35 && b == 42 {
		print!("77");
	} else if a == 35 && b == 43 {
		print!("78");
	} else if a == 35 && b == 44 {
		print!("79");
	} else if a == 35 && b == 45 {
		print!("80");
	} else if a == 35 && b == 46 {
		print!("81");
	} else if a == 35 && b == 47 {
		print!("82");
	} else if a == 35 && b == 48 {
		print!("83");
	} else if a == 35 && b == 49 {
		print!("84");
	} else if a == 35 && b == 50 {
		print!("85");
	} else if a == 36 && b == 0 {
		print!("36");
	} else if a == 36 && b == 1 {
		print!("37");
	} else if a == 36 && b == 2 {
		print!("38");
	} else if a == 36 && b == 3 {
		print!("39");
	} else if a == 36 && b == 4 {
		print!("40");
	} else if a == 36 && b == 5 {
		print!("41");
	} else if a == 36 && b == 6 {
		print!("42");
	} else if a == 36 && b == 7 {
		print!("43");
	} else if a == 36 && b == 8 {
		print!("44");
	} else if a == 36 && b == 9 {
		print!("45");
	} else if a == 36 && b == 10 {
		print!("46");
	} else if a == 36 && b == 11 {
		print!("47");
	} else if a == 36 && b == 12 {
		print!("48");
	} else if a == 36 && b == 13 {
		print!("49");
	} else if a == 36 && b == 14 {
		print!("50");
	} else if a == 36 && b == 15 {
		print!("51");
	} else if a == 36 && b == 16 {
		print!("52");
	} else if a == 36 && b == 17 {
		print!("53");
	} else if a == 36 && b == 18 {
		print!("54");
	} else if a == 36 && b == 19 {
		print!("55");
	} else if a == 36 && b == 20 {
		print!("56");
	} else if a == 36 && b == 21 {
		print!("57");
	} else if a == 36 && b == 22 {
		print!("58");
	} else if a == 36 && b == 23 {
		print!("59");
	} else if a == 36 && b == 24 {
		print!("60");
	} else if a == 36 && b == 25 {
		print!("61");
	} else if a == 36 && b == 26 {
		print!("62");
	} else if a == 36 && b == 27 {
		print!("63");
	} else if a == 36 && b == 28 {
		print!("64");
	} else if a == 36 && b == 29 {
		print!("65");
	} else if a == 36 && b == 30 {
		print!("66");
	} else if a == 36 && b == 31 {
		print!("67");
	} else if a == 36 && b == 32 {
		print!("68");
	} else if a == 36 && b == 33 {
		print!("69");
	} else if a == 36 && b == 34 {
		print!("70");
	} else if a == 36 && b == 35 {
		print!("71");
	} else if a == 36 && b == 36 {
		print!("72");
	} else if a == 36 && b == 37 {
		print!("73");
	} else if a == 36 && b == 38 {
		print!("74");
	} else if a == 36 && b == 39 {
		print!("75");
	} else if a == 36 && b == 40 {
		print!("76");
	} else if a == 36 && b == 41 {
		print!("77");
	} else if a == 36 && b == 42 {
		print!("78");
	} else if a == 36 && b == 43 {
		print!("79");
	} else if a == 36 && b == 44 {
		print!("80");
	} else if a == 36 && b == 45 {
		print!("81");
	} else if a == 36 && b == 46 {
		print!("82");
	} else if a == 36 && b == 47 {
		print!("83");
	} else if a == 36 && b == 48 {
		print!("84");
	} else if a == 36 && b == 49 {
		print!("85");
	} else if a == 36 && b == 50 {
		print!("86");
	} else if a == 37 && b == 0 {
		print!("37");
	} else if a == 37 && b == 1 {
		print!("38");
	} else if a == 37 && b == 2 {
		print!("39");
	} else if a == 37 && b == 3 {
		print!("40");
	} else if a == 37 && b == 4 {
		print!("41");
	} else if a == 37 && b == 5 {
		print!("42");
	} else if a == 37 && b == 6 {
		print!("43");
	} else if a == 37 && b == 7 {
		print!("44");
	} else if a == 37 && b == 8 {
		print!("45");
	} else if a == 37 && b == 9 {
		print!("46");
	} else if a == 37 && b == 10 {
		print!("47");
	} else if a == 37 && b == 11 {
		print!("48");
	} else if a == 37 && b == 12 {
		print!("49");
	} else if a == 37 && b == 13 {
		print!("50");
	} else if a == 37 && b == 14 {
		print!("51");
	} else if a == 37 && b == 15 {
		print!("52");
	} else if a == 37 && b == 16 {
		print!("53");
	} else if a == 37 && b == 17 {
		print!("54");
	} else if a == 37 && b == 18 {
		print!("55");
	} else if a == 37 && b == 19 {
		print!("56");
	} else if a == 37 && b == 20 {
		print!("57");
	} else if a == 37 && b == 21 {
		print!("58");
	} else if a == 37 && b == 22 {
		print!("59");
	} else if a == 37 && b == 23 {
		print!("60");
	} else if a == 37 && b == 24 {
		print!("61");
	} else if a == 37 && b == 25 {
		print!("62");
	} else if a == 37 && b == 26 {
		print!("63");
	} else if a == 37 && b == 27 {
		print!("64");
	} else if a == 37 && b == 28 {
		print!("65");
	} else if a == 37 && b == 29 {
		print!("66");
	} else if a == 37 && b == 30 {
		print!("67");
	} else if a == 37 && b == 31 {
		print!("68");
	} else if a == 37 && b == 32 {
		print!("69");
	} else if a == 37 && b == 33 {
		print!("70");
	} else if a == 37 && b == 34 {
		print!("71");
	} else if a == 37 && b == 35 {
		print!("72");
	} else if a == 37 && b == 36 {
		print!("73");
	} else if a == 37 && b == 37 {
		print!("74");
	} else if a == 37 && b == 38 {
		print!("75");
	} else if a == 37 && b == 39 {
		print!("76");
	} else if a == 37 && b == 40 {
		print!("77");
	} else if a == 37 && b == 41 {
		print!("78");
	} else if a == 37 && b == 42 {
		print!("79");
	} else if a == 37 && b == 43 {
		print!("80");
	} else if a == 37 && b == 44 {
		print!("81");
	} else if a == 37 && b == 45 {
		print!("82");
	} else if a == 37 && b == 46 {
		print!("83");
	} else if a == 37 && b == 47 {
		print!("84");
	} else if a == 37 && b == 48 {
		print!("85");
	} else if a == 37 && b == 49 {
		print!("86");
	} else if a == 37 && b == 50 {
		print!("87");
	} else if a == 38 && b == 0 {
		print!("38");
	} else if a == 38 && b == 1 {
		print!("39");
	} else if a == 38 && b == 2 {
		print!("40");
	} else if a == 38 && b == 3 {
		print!("41");
	} else if a == 38 && b == 4 {
		print!("42");
	} else if a == 38 && b == 5 {
		print!("43");
	} else if a == 38 && b == 6 {
		print!("44");
	} else if a == 38 && b == 7 {
		print!("45");
	} else if a == 38 && b == 8 {
		print!("46");
	} else if a == 38 && b == 9 {
		print!("47");
	} else if a == 38 && b == 10 {
		print!("48");
	} else if a == 38 && b == 11 {
		print!("49");
	} else if a == 38 && b == 12 {
		print!("50");
	} else if a == 38 && b == 13 {
		print!("51");
	} else if a == 38 && b == 14 {
		print!("52");
	} else if a == 38 && b == 15 {
		print!("53");
	} else if a == 38 && b == 16 {
		print!("54");
	} else if a == 38 && b == 17 {
		print!("55");
	} else if a == 38 && b == 18 {
		print!("56");
	} else if a == 38 && b == 19 {
		print!("57");
	} else if a == 38 && b == 20 {
		print!("58");
	} else if a == 38 && b == 21 {
		print!("59");
	} else if a == 38 && b == 22 {
		print!("60");
	} else if a == 38 && b == 23 {
		print!("61");
	} else if a == 38 && b == 24 {
		print!("62");
	} else if a == 38 && b == 25 {
		print!("63");
	} else if a == 38 && b == 26 {
		print!("64");
	} else if a == 38 && b == 27 {
		print!("65");
	} else if a == 38 && b == 28 {
		print!("66");
	} else if a == 38 && b == 29 {
		print!("67");
	} else if a == 38 && b == 30 {
		print!("68");
	} else if a == 38 && b == 31 {
		print!("69");
	} else if a == 38 && b == 32 {
		print!("70");
	} else if a == 38 && b == 33 {
		print!("71");
	} else if a == 38 && b == 34 {
		print!("72");
	} else if a == 38 && b == 35 {
		print!("73");
	} else if a == 38 && b == 36 {
		print!("74");
	} else if a == 38 && b == 37 {
		print!("75");
	} else if a == 38 && b == 38 {
		print!("76");
	} else if a == 38 && b == 39 {
		print!("77");
	} else if a == 38 && b == 40 {
		print!("78");
	} else if a == 38 && b == 41 {
		print!("79");
	} else if a == 38 && b == 42 {
		print!("80");
	} else if a == 38 && b == 43 {
		print!("81");
	} else if a == 38 && b == 44 {
		print!("82");
	} else if a == 38 && b == 45 {
		print!("83");
	} else if a == 38 && b == 46 {
		print!("84");
	} else if a == 38 && b == 47 {
		print!("85");
	} else if a == 38 && b == 48 {
		print!("86");
	} else if a == 38 && b == 49 {
		print!("87");
	} else if a == 38 && b == 50 {
		print!("88");
	} else if a == 39 && b == 0 {
		print!("39");
	} else if a == 39 && b == 1 {
		print!("40");
	} else if a == 39 && b == 2 {
		print!("41");
	} else if a == 39 && b == 3 {
		print!("42");
	} else if a == 39 && b == 4 {
		print!("43");
	} else if a == 39 && b == 5 {
		print!("44");
	} else if a == 39 && b == 6 {
		print!("45");
	} else if a == 39 && b == 7 {
		print!("46");
	} else if a == 39 && b == 8 {
		print!("47");
	} else if a == 39 && b == 9 {
		print!("48");
	} else if a == 39 && b == 10 {
		print!("49");
	} else if a == 39 && b == 11 {
		print!("50");
	} else if a == 39 && b == 12 {
		print!("51");
	} else if a == 39 && b == 13 {
		print!("52");
	} else if a == 39 && b == 14 {
		print!("53");
	} else if a == 39 && b == 15 {
		print!("54");
	} else if a == 39 && b == 16 {
		print!("55");
	} else if a == 39 && b == 17 {
		print!("56");
	} else if a == 39 && b == 18 {
		print!("57");
	} else if a == 39 && b == 19 {
		print!("58");
	} else if a == 39 && b == 20 {
		print!("59");
	} else if a == 39 && b == 21 {
		print!("60");
	} else if a == 39 && b == 22 {
		print!("61");
	} else if a == 39 && b == 23 {
		print!("62");
	} else if a == 39 && b == 24 {
		print!("63");
	} else if a == 39 && b == 25 {
		print!("64");
	} else if a == 39 && b == 26 {
		print!("65");
	} else if a == 39 && b == 27 {
		print!("66");
	} else if a == 39 && b == 28 {
		print!("67");
	} else if a == 39 && b == 29 {
		print!("68");
	} else if a == 39 && b == 30 {
		print!("69");
	} else if a == 39 && b == 31 {
		print!("70");
	} else if a == 39 && b == 32 {
		print!("71");
	} else if a == 39 && b == 33 {
		print!("72");
	} else if a == 39 && b == 34 {
		print!("73");
	} else if a == 39 && b == 35 {
		print!("74");
	} else if a == 39 && b == 36 {
		print!("75");
	} else if a == 39 && b == 37 {
		print!("76");
	} else if a == 39 && b == 38 {
		print!("77");
	} else if a == 39 && b == 39 {
		print!("78");
	} else if a == 39 && b == 40 {
		print!("79");
	} else if a == 39 && b == 41 {
		print!("80");
	} else if a == 39 && b == 42 {
		print!("81");
	} else if a == 39 && b == 43 {
		print!("82");
	} else if a == 39 && b == 44 {
		print!("83");
	} else if a == 39 && b == 45 {
		print!("84");
	} else if a == 39 && b == 46 {
		print!("85");
	} else if a == 39 && b == 47 {
		print!("86");
	} else if a == 39 && b == 48 {
		print!("87");
	} else if a == 39 && b == 49 {
		print!("88");
	} else if a == 39 && b == 50 {
		print!("89");
	} else if a == 40 && b == 0 {
		print!("40");
	} else if a == 40 && b == 1 {
		print!("41");
	} else if a == 40 && b == 2 {
		print!("42");
	} else if a == 40 && b == 3 {
		print!("43");
	} else if a == 40 && b == 4 {
		print!("44");
	} else if a == 40 && b == 5 {
		print!("45");
	} else if a == 40 && b == 6 {
		print!("46");
	} else if a == 40 && b == 7 {
		print!("47");
	} else if a == 40 && b == 8 {
		print!("48");
	} else if a == 40 && b == 9 {
		print!("49");
	} else if a == 40 && b == 10 {
		print!("50");
	} else if a == 40 && b == 11 {
		print!("51");
	} else if a == 40 && b == 12 {
		print!("52");
	} else if a == 40 && b == 13 {
		print!("53");
	} else if a == 40 && b == 14 {
		print!("54");
	} else if a == 40 && b == 15 {
		print!("55");
	} else if a == 40 && b == 16 {
		print!("56");
	} else if a == 40 && b == 17 {
		print!("57");
	} else if a == 40 && b == 18 {
		print!("58");
	} else if a == 40 && b == 19 {
		print!("59");
	} else if a == 40 && b == 20 {
		print!("60");
	} else if a == 40 && b == 21 {
		print!("61");
	} else if a == 40 && b == 22 {
		print!("62");
	} else if a == 40 && b == 23 {
		print!("63");
	} else if a == 40 && b == 24 {
		print!("64");
	} else if a == 40 && b == 25 {
		print!("65");
	} else if a == 40 && b == 26 {
		print!("66");
	} else if a == 40 && b == 27 {
		print!("67");
	} else if a == 40 && b == 28 {
		print!("68");
	} else if a == 40 && b == 29 {
		print!("69");
	} else if a == 40 && b == 30 {
		print!("70");
	} else if a == 40 && b == 31 {
		print!("71");
	} else if a == 40 && b == 32 {
		print!("72");
	} else if a == 40 && b == 33 {
		print!("73");
	} else if a == 40 && b == 34 {
		print!("74");
	} else if a == 40 && b == 35 {
		print!("75");
	} else if a == 40 && b == 36 {
		print!("76");
	} else if a == 40 && b == 37 {
		print!("77");
	} else if a == 40 && b == 38 {
		print!("78");
	} else if a == 40 && b == 39 {
		print!("79");
	} else if a == 40 && b == 40 {
		print!("80");
	} else if a == 40 && b == 41 {
		print!("81");
	} else if a == 40 && b == 42 {
		print!("82");
	} else if a == 40 && b == 43 {
		print!("83");
	} else if a == 40 && b == 44 {
		print!("84");
	} else if a == 40 && b == 45 {
		print!("85");
	} else if a == 40 && b == 46 {
		print!("86");
	} else if a == 40 && b == 47 {
		print!("87");
	} else if a == 40 && b == 48 {
		print!("88");
	} else if a == 40 && b == 49 {
		print!("89");
	} else if a == 40 && b == 50 {
		print!("90");
	} else if a == 41 && b == 0 {
		print!("41");
	} else if a == 41 && b == 1 {
		print!("42");
	} else if a == 41 && b == 2 {
		print!("43");
	} else if a == 41 && b == 3 {
		print!("44");
	} else if a == 41 && b == 4 {
		print!("45");
	} else if a == 41 && b == 5 {
		print!("46");
	} else if a == 41 && b == 6 {
		print!("47");
	} else if a == 41 && b == 7 {
		print!("48");
	} else if a == 41 && b == 8 {
		print!("49");
	} else if a == 41 && b == 9 {
		print!("50");
	} else if a == 41 && b == 10 {
		print!("51");
	} else if a == 41 && b == 11 {
		print!("52");
	} else if a == 41 && b == 12 {
		print!("53");
	} else if a == 41 && b == 13 {
		print!("54");
	} else if a == 41 && b == 14 {
		print!("55");
	} else if a == 41 && b == 15 {
		print!("56");
	} else if a == 41 && b == 16 {
		print!("57");
	} else if a == 41 && b == 17 {
		print!("58");
	} else if a == 41 && b == 18 {
		print!("59");
	} else if a == 41 && b == 19 {
		print!("60");
	} else if a == 41 && b == 20 {
		print!("61");
	} else if a == 41 && b == 21 {
		print!("62");
	} else if a == 41 && b == 22 {
		print!("63");
	} else if a == 41 && b == 23 {
		print!("64");
	} else if a == 41 && b == 24 {
		print!("65");
	} else if a == 41 && b == 25 {
		print!("66");
	} else if a == 41 && b == 26 {
		print!("67");
	} else if a == 41 && b == 27 {
		print!("68");
	} else if a == 41 && b == 28 {
		print!("69");
	} else if a == 41 && b == 29 {
		print!("70");
	} else if a == 41 && b == 30 {
		print!("71");
	} else if a == 41 && b == 31 {
		print!("72");
	} else if a == 41 && b == 32 {
		print!("73");
	} else if a == 41 && b == 33 {
		print!("74");
	} else if a == 41 && b == 34 {
		print!("75");
	} else if a == 41 && b == 35 {
		print!("76");
	} else if a == 41 && b == 36 {
		print!("77");
	} else if a == 41 && b == 37 {
		print!("78");
	} else if a == 41 && b == 38 {
		print!("79");
	} else if a == 41 && b == 39 {
		print!("80");
	} else if a == 41 && b == 40 {
		print!("81");
	} else if a == 41 && b == 41 {
		print!("82");
	} else if a == 41 && b == 42 {
		print!("83");
	} else if a == 41 && b == 43 {
		print!("84");
	} else if a == 41 && b == 44 {
		print!("85");
	} else if a == 41 && b == 45 {
		print!("86");
	} else if a == 41 && b == 46 {
		print!("87");
	} else if a == 41 && b == 47 {
		print!("88");
	} else if a == 41 && b == 48 {
		print!("89");
	} else if a == 41 && b == 49 {
		print!("90");
	} else if a == 41 && b == 50 {
		print!("91");
	} else if a == 42 && b == 0 {
		print!("42");
	} else if a == 42 && b == 1 {
		print!("43");
	} else if a == 42 && b == 2 {
		print!("44");
	} else if a == 42 && b == 3 {
		print!("45");
	} else if a == 42 && b == 4 {
		print!("46");
	} else if a == 42 && b == 5 {
		print!("47");
	} else if a == 42 && b == 6 {
		print!("48");
	} else if a == 42 && b == 7 {
		print!("49");
	} else if a == 42 && b == 8 {
		print!("50");
	} else if a == 42 && b == 9 {
		print!("51");
	} else if a == 42 && b == 10 {
		print!("52");
	} else if a == 42 && b == 11 {
		print!("53");
	} else if a == 42 && b == 12 {
		print!("54");
	} else if a == 42 && b == 13 {
		print!("55");
	} else if a == 42 && b == 14 {
		print!("56");
	} else if a == 42 && b == 15 {
		print!("57");
	} else if a == 42 && b == 16 {
		print!("58");
	} else if a == 42 && b == 17 {
		print!("59");
	} else if a == 42 && b == 18 {
		print!("60");
	} else if a == 42 && b == 19 {
		print!("61");
	} else if a == 42 && b == 20 {
		print!("62");
	} else if a == 42 && b == 21 {
		print!("63");
	} else if a == 42 && b == 22 {
		print!("64");
	} else if a == 42 && b == 23 {
		print!("65");
	} else if a == 42 && b == 24 {
		print!("66");
	} else if a == 42 && b == 25 {
		print!("67");
	} else if a == 42 && b == 26 {
		print!("68");
	} else if a == 42 && b == 27 {
		print!("69");
	} else if a == 42 && b == 28 {
		print!("70");
	} else if a == 42 && b == 29 {
		print!("71");
	} else if a == 42 && b == 30 {
		print!("72");
	} else if a == 42 && b == 31 {
		print!("73");
	} else if a == 42 && b == 32 {
		print!("74");
	} else if a == 42 && b == 33 {
		print!("75");
	} else if a == 42 && b == 34 {
		print!("76");
	} else if a == 42 && b == 35 {
		print!("77");
	} else if a == 42 && b == 36 {
		print!("78");
	} else if a == 42 && b == 37 {
		print!("79");
	} else if a == 42 && b == 38 {
		print!("80");
	} else if a == 42 && b == 39 {
		print!("81");
	} else if a == 42 && b == 40 {
		print!("82");
	} else if a == 42 && b == 41 {
		print!("83");
	} else if a == 42 && b == 42 {
		print!("84");
	} else if a == 42 && b == 43 {
		print!("85");
	} else if a == 42 && b == 44 {
		print!("86");
	} else if a == 42 && b == 45 {
		print!("87");
	} else if a == 42 && b == 46 {
		print!("88");
	} else if a == 42 && b == 47 {
		print!("89");
	} else if a == 42 && b == 48 {
		print!("90");
	} else if a == 42 && b == 49 {
		print!("91");
	} else if a == 42 && b == 50 {
		print!("92");
	} else if a == 43 && b == 0 {
		print!("43");
	} else if a == 43 && b == 1 {
		print!("44");
	} else if a == 43 && b == 2 {
		print!("45");
	} else if a == 43 && b == 3 {
		print!("46");
	} else if a == 43 && b == 4 {
		print!("47");
	} else if a == 43 && b == 5 {
		print!("48");
	} else if a == 43 && b == 6 {
		print!("49");
	} else if a == 43 && b == 7 {
		print!("50");
	} else if a == 43 && b == 8 {
		print!("51");
	} else if a == 43 && b == 9 {
		print!("52");
	} else if a == 43 && b == 10 {
		print!("53");
	} else if a == 43 && b == 11 {
		print!("54");
	} else if a == 43 && b == 12 {
		print!("55");
	} else if a == 43 && b == 13 {
		print!("56");
	} else if a == 43 && b == 14 {
		print!("57");
	} else if a == 43 && b == 15 {
		print!("58");
	} else if a == 43 && b == 16 {
		print!("59");
	} else if a == 43 && b == 17 {
		print!("60");
	} else if a == 43 && b == 18 {
		print!("61");
	} else if a == 43 && b == 19 {
		print!("62");
	} else if a == 43 && b == 20 {
		print!("63");
	} else if a == 43 && b == 21 {
		print!("64");
	} else if a == 43 && b == 22 {
		print!("65");
	} else if a == 43 && b == 23 {
		print!("66");
	} else if a == 43 && b == 24 {
		print!("67");
	} else if a == 43 && b == 25 {
		print!("68");
	} else if a == 43 && b == 26 {
		print!("69");
	} else if a == 43 && b == 27 {
		print!("70");
	} else if a == 43 && b == 28 {
		print!("71");
	} else if a == 43 && b == 29 {
		print!("72");
	} else if a == 43 && b == 30 {
		print!("73");
	} else if a == 43 && b == 31 {
		print!("74");
	} else if a == 43 && b == 32 {
		print!("75");
	} else if a == 43 && b == 33 {
		print!("76");
	} else if a == 43 && b == 34 {
		print!("77");
	} else if a == 43 && b == 35 {
		print!("78");
	} else if a == 43 && b == 36 {
		print!("79");
	} else if a == 43 && b == 37 {
		print!("80");
	} else if a == 43 && b == 38 {
		print!("81");
	} else if a == 43 && b == 39 {
		print!("82");
	} else if a == 43 && b == 40 {
		print!("83");
	} else if a == 43 && b == 41 {
		print!("84");
	} else if a == 43 && b == 42 {
		print!("85");
	} else if a == 43 && b == 43 {
		print!("86");
	} else if a == 43 && b == 44 {
		print!("87");
	} else if a == 43 && b == 45 {
		print!("88");
	} else if a == 43 && b == 46 {
		print!("89");
	} else if a == 43 && b == 47 {
		print!("90");
	} else if a == 43 && b == 48 {
		print!("91");
	} else if a == 43 && b == 49 {
		print!("92");
	} else if a == 43 && b == 50 {
		print!("93");
	} else if a == 44 && b == 0 {
		print!("44");
	} else if a == 44 && b == 1 {
		print!("45");
	} else if a == 44 && b == 2 {
		print!("46");
	} else if a == 44 && b == 3 {
		print!("47");
	} else if a == 44 && b == 4 {
		print!("48");
	} else if a == 44 && b == 5 {
		print!("49");
	} else if a == 44 && b == 6 {
		print!("50");
	} else if a == 44 && b == 7 {
		print!("51");
	} else if a == 44 && b == 8 {
		print!("52");
	} else if a == 44 && b == 9 {
		print!("53");
	} else if a == 44 && b == 10 {
		print!("54");
	} else if a == 44 && b == 11 {
		print!("55");
	} else if a == 44 && b == 12 {
		print!("56");
	} else if a == 44 && b == 13 {
		print!("57");
	} else if a == 44 && b == 14 {
		print!("58");
	} else if a == 44 && b == 15 {
		print!("59");
	} else if a == 44 && b == 16 {
		print!("60");
	} else if a == 44 && b == 17 {
		print!("61");
	} else if a == 44 && b == 18 {
		print!("62");
	} else if a == 44 && b == 19 {
		print!("63");
	} else if a == 44 && b == 20 {
		print!("64");
	} else if a == 44 && b == 21 {
		print!("65");
	} else if a == 44 && b == 22 {
		print!("66");
	} else if a == 44 && b == 23 {
		print!("67");
	} else if a == 44 && b == 24 {
		print!("68");
	} else if a == 44 && b == 25 {
		print!("69");
	} else if a == 44 && b == 26 {
		print!("70");
	} else if a == 44 && b == 27 {
		print!("71");
	} else if a == 44 && b == 28 {
		print!("72");
	} else if a == 44 && b == 29 {
		print!("73");
	} else if a == 44 && b == 30 {
		print!("74");
	} else if a == 44 && b == 31 {
		print!("75");
	} else if a == 44 && b == 32 {
		print!("76");
	} else if a == 44 && b == 33 {
		print!("77");
	} else if a == 44 && b == 34 {
		print!("78");
	} else if a == 44 && b == 35 {
		print!("79");
	} else if a == 44 && b == 36 {
		print!("80");
	} else if a == 44 && b == 37 {
		print!("81");
	} else if a == 44 && b == 38 {
		print!("82");
	} else if a == 44 && b == 39 {
		print!("83");
	} else if a == 44 && b == 40 {
		print!("84");
	} else if a == 44 && b == 41 {
		print!("85");
	} else if a == 44 && b == 42 {
		print!("86");
	} else if a == 44 && b == 43 {
		print!("87");
	} else if a == 44 && b == 44 {
		print!("88");
	} else if a == 44 && b == 45 {
		print!("89");
	} else if a == 44 && b == 46 {
		print!("90");
	} else if a == 44 && b == 47 {
		print!("91");
	} else if a == 44 && b == 48 {
		print!("92");
	} else if a == 44 && b == 49 {
		print!("93");
	} else if a == 44 && b == 50 {
		print!("94");
	} else if a == 45 && b == 0 {
		print!("45");
	} else if a == 45 && b == 1 {
		print!("46");
	} else if a == 45 && b == 2 {
		print!("47");
	} else if a == 45 && b == 3 {
		print!("48");
	} else if a == 45 && b == 4 {
		print!("49");
	} else if a == 45 && b == 5 {
		print!("50");
	} else if a == 45 && b == 6 {
		print!("51");
	} else if a == 45 && b == 7 {
		print!("52");
	} else if a == 45 && b == 8 {
		print!("53");
	} else if a == 45 && b == 9 {
		print!("54");
	} else if a == 45 && b == 10 {
		print!("55");
	} else if a == 45 && b == 11 {
		print!("56");
	} else if a == 45 && b == 12 {
		print!("57");
	} else if a == 45 && b == 13 {
		print!("58");
	} else if a == 45 && b == 14 {
		print!("59");
	} else if a == 45 && b == 15 {
		print!("60");
	} else if a == 45 && b == 16 {
		print!("61");
	} else if a == 45 && b == 17 {
		print!("62");
	} else if a == 45 && b == 18 {
		print!("63");
	} else if a == 45 && b == 19 {
		print!("64");
	} else if a == 45 && b == 20 {
		print!("65");
	} else if a == 45 && b == 21 {
		print!("66");
	} else if a == 45 && b == 22 {
		print!("67");
	} else if a == 45 && b == 23 {
		print!("68");
	} else if a == 45 && b == 24 {
		print!("69");
	} else if a == 45 && b == 25 {
		print!("70");
	} else if a == 45 && b == 26 {
		print!("71");
	} else if a == 45 && b == 27 {
		print!("72");
	} else if a == 45 && b == 28 {
		print!("73");
	} else if a == 45 && b == 29 {
		print!("74");
	} else if a == 45 && b == 30 {
		print!("75");
	} else if a == 45 && b == 31 {
		print!("76");
	} else if a == 45 && b == 32 {
		print!("77");
	} else if a == 45 && b == 33 {
		print!("78");
	} else if a == 45 && b == 34 {
		print!("79");
	} else if a == 45 && b == 35 {
		print!("80");
	} else if a == 45 && b == 36 {
		print!("81");
	} else if a == 45 && b == 37 {
		print!("82");
	} else if a == 45 && b == 38 {
		print!("83");
	} else if a == 45 && b == 39 {
		print!("84");
	} else if a == 45 && b == 40 {
		print!("85");
	} else if a == 45 && b == 41 {
		print!("86");
	} else if a == 45 && b == 42 {
		print!("87");
	} else if a == 45 && b == 43 {
		print!("88");
	} else if a == 45 && b == 44 {
		print!("89");
	} else if a == 45 && b == 45 {
		print!("90");
	} else if a == 45 && b == 46 {
		print!("91");
	} else if a == 45 && b == 47 {
		print!("92");
	} else if a == 45 && b == 48 {
		print!("93");
	} else if a == 45 && b == 49 {
		print!("94");
	} else if a == 45 && b == 50 {
		print!("95");
	} else if a == 46 && b == 0 {
		print!("46");
	} else if a == 46 && b == 1 {
		print!("47");
	} else if a == 46 && b == 2 {
		print!("48");
	} else if a == 46 && b == 3 {
		print!("49");
	} else if a == 46 && b == 4 {
		print!("50");
	} else if a == 46 && b == 5 {
		print!("51");
	} else if a == 46 && b == 6 {
		print!("52");
	} else if a == 46 && b == 7 {
		print!("53");
	} else if a == 46 && b == 8 {
		print!("54");
	} else if a == 46 && b == 9 {
		print!("55");
	} else if a == 46 && b == 10 {
		print!("56");
	} else if a == 46 && b == 11 {
		print!("57");
	} else if a == 46 && b == 12 {
		print!("58");
	} else if a == 46 && b == 13 {
		print!("59");
	} else if a == 46 && b == 14 {
		print!("60");
	} else if a == 46 && b == 15 {
		print!("61");
	} else if a == 46 && b == 16 {
		print!("62");
	} else if a == 46 && b == 17 {
		print!("63");
	} else if a == 46 && b == 18 {
		print!("64");
	} else if a == 46 && b == 19 {
		print!("65");
	} else if a == 46 && b == 20 {
		print!("66");
	} else if a == 46 && b == 21 {
		print!("67");
	} else if a == 46 && b == 22 {
		print!("68");
	} else if a == 46 && b == 23 {
		print!("69");
	} else if a == 46 && b == 24 {
		print!("70");
	} else if a == 46 && b == 25 {
		print!("71");
	} else if a == 46 && b == 26 {
		print!("72");
	} else if a == 46 && b == 27 {
		print!("73");
	} else if a == 46 && b == 28 {
		print!("74");
	} else if a == 46 && b == 29 {
		print!("75");
	} else if a == 46 && b == 30 {
		print!("76");
	} else if a == 46 && b == 31 {
		print!("77");
	} else if a == 46 && b == 32 {
		print!("78");
	} else if a == 46 && b == 33 {
		print!("79");
	} else if a == 46 && b == 34 {
		print!("80");
	} else if a == 46 && b == 35 {
		print!("81");
	} else if a == 46 && b == 36 {
		print!("82");
	} else if a == 46 && b == 37 {
		print!("83");
	} else if a == 46 && b == 38 {
		print!("84");
	} else if a == 46 && b == 39 {
		print!("85");
	} else if a == 46 && b == 40 {
		print!("86");
	} else if a == 46 && b == 41 {
		print!("87");
	} else if a == 46 && b == 42 {
		print!("88");
	} else if a == 46 && b == 43 {
		print!("89");
	} else if a == 46 && b == 44 {
		print!("90");
	} else if a == 46 && b == 45 {
		print!("91");
	} else if a == 46 && b == 46 {
		print!("92");
	} else if a == 46 && b == 47 {
		print!("93");
	} else if a == 46 && b == 48 {
		print!("94");
	} else if a == 46 && b == 49 {
		print!("95");
	} else if a == 46 && b == 50 {
		print!("96");
	} else if a == 47 && b == 0 {
		print!("47");
	} else if a == 47 && b == 1 {
		print!("48");
	} else if a == 47 && b == 2 {
		print!("49");
	} else if a == 47 && b == 3 {
		print!("50");
	} else if a == 47 && b == 4 {
		print!("51");
	} else if a == 47 && b == 5 {
		print!("52");
	} else if a == 47 && b == 6 {
		print!("53");
	} else if a == 47 && b == 7 {
		print!("54");
	} else if a == 47 && b == 8 {
		print!("55");
	} else if a == 47 && b == 9 {
		print!("56");
	} else if a == 47 && b == 10 {
		print!("57");
	} else if a == 47 && b == 11 {
		print!("58");
	} else if a == 47 && b == 12 {
		print!("59");
	} else if a == 47 && b == 13 {
		print!("60");
	} else if a == 47 && b == 14 {
		print!("61");
	} else if a == 47 && b == 15 {
		print!("62");
	} else if a == 47 && b == 16 {
		print!("63");
	} else if a == 47 && b == 17 {
		print!("64");
	} else if a == 47 && b == 18 {
		print!("65");
	} else if a == 47 && b == 19 {
		print!("66");
	} else if a == 47 && b == 20 {
		print!("67");
	} else if a == 47 && b == 21 {
		print!("68");
	} else if a == 47 && b == 22 {
		print!("69");
	} else if a == 47 && b == 23 {
		print!("70");
	} else if a == 47 && b == 24 {
		print!("71");
	} else if a == 47 && b == 25 {
		print!("72");
	} else if a == 47 && b == 26 {
		print!("73");
	} else if a == 47 && b == 27 {
		print!("74");
	} else if a == 47 && b == 28 {
		print!("75");
	} else if a == 47 && b == 29 {
		print!("76");
	} else if a == 47 && b == 30 {
		print!("77");
	} else if a == 47 && b == 31 {
		print!("78");
	} else if a == 47 && b == 32 {
		print!("79");
	} else if a == 47 && b == 33 {
		print!("80");
	} else if a == 47 && b == 34 {
		print!("81");
	} else if a == 47 && b == 35 {
		print!("82");
	} else if a == 47 && b == 36 {
		print!("83");
	} else if a == 47 && b == 37 {
		print!("84");
	} else if a == 47 && b == 38 {
		print!("85");
	} else if a == 47 && b == 39 {
		print!("86");
	} else if a == 47 && b == 40 {
		print!("87");
	} else if a == 47 && b == 41 {
		print!("88");
	} else if a == 47 && b == 42 {
		print!("89");
	} else if a == 47 && b == 43 {
		print!("90");
	} else if a == 47 && b == 44 {
		print!("91");
	} else if a == 47 && b == 45 {
		print!("92");
	} else if a == 47 && b == 46 {
		print!("93");
	} else if a == 47 && b == 47 {
		print!("94");
	} else if a == 47 && b == 48 {
		print!("95");
	} else if a == 47 && b == 49 {
		print!("96");
	} else if a == 47 && b == 50 {
		print!("97");
	} else if a == 48 && b == 0 {
		print!("48");
	} else if a == 48 && b == 1 {
		print!("49");
	} else if a == 48 && b == 2 {
		print!("50");
	} else if a == 48 && b == 3 {
		print!("51");
	} else if a == 48 && b == 4 {
		print!("52");
	} else if a == 48 && b == 5 {
		print!("53");
	} else if a == 48 && b == 6 {
		print!("54");
	} else if a == 48 && b == 7 {
		print!("55");
	} else if a == 48 && b == 8 {
		print!("56");
	} else if a == 48 && b == 9 {
		print!("57");
	} else if a == 48 && b == 10 {
		print!("58");
	} else if a == 48 && b == 11 {
		print!("59");
	} else if a == 48 && b == 12 {
		print!("60");
	} else if a == 48 && b == 13 {
		print!("61");
	} else if a == 48 && b == 14 {
		print!("62");
	} else if a == 48 && b == 15 {
		print!("63");
	} else if a == 48 && b == 16 {
		print!("64");
	} else if a == 48 && b == 17 {
		print!("65");
	} else if a == 48 && b == 18 {
		print!("66");
	} else if a == 48 && b == 19 {
		print!("67");
	} else if a == 48 && b == 20 {
		print!("68");
	} else if a == 48 && b == 21 {
		print!("69");
	} else if a == 48 && b == 22 {
		print!("70");
	} else if a == 48 && b == 23 {
		print!("71");
	} else if a == 48 && b == 24 {
		print!("72");
	} else if a == 48 && b == 25 {
		print!("73");
	} else if a == 48 && b == 26 {
		print!("74");
	} else if a == 48 && b == 27 {
		print!("75");
	} else if a == 48 && b == 28 {
		print!("76");
	} else if a == 48 && b == 29 {
		print!("77");
	} else if a == 48 && b == 30 {
		print!("78");
	} else if a == 48 && b == 31 {
		print!("79");
	} else if a == 48 && b == 32 {
		print!("80");
	} else if a == 48 && b == 33 {
		print!("81");
	} else if a == 48 && b == 34 {
		print!("82");
	} else if a == 48 && b == 35 {
		print!("83");
	} else if a == 48 && b == 36 {
		print!("84");
	} else if a == 48 && b == 37 {
		print!("85");
	} else if a == 48 && b == 38 {
		print!("86");
	} else if a == 48 && b == 39 {
		print!("87");
	} else if a == 48 && b == 40 {
		print!("88");
	} else if a == 48 && b == 41 {
		print!("89");
	} else if a == 48 && b == 42 {
		print!("90");
	} else if a == 48 && b == 43 {
		print!("91");
	} else if a == 48 && b == 44 {
		print!("92");
	} else if a == 48 && b == 45 {
		print!("93");
	} else if a == 48 && b == 46 {
		print!("94");
	} else if a == 48 && b == 47 {
		print!("95");
	} else if a == 48 && b == 48 {
		print!("96");
	} else if a == 48 && b == 49 {
		print!("97");
	} else if a == 48 && b == 50 {
		print!("98");
	} else if a == 49 && b == 0 {
		print!("49");
	} else if a == 49 && b == 1 {
		print!("50");
	} else if a == 49 && b == 2 {
		print!("51");
	} else if a == 49 && b == 3 {
		print!("52");
	} else if a == 49 && b == 4 {
		print!("53");
	} else if a == 49 && b == 5 {
		print!("54");
	} else if a == 49 && b == 6 {
		print!("55");
	} else if a == 49 && b == 7 {
		print!("56");
	} else if a == 49 && b == 8 {
		print!("57");
	} else if a == 49 && b == 9 {
		print!("58");
	} else if a == 49 && b == 10 {
		print!("59");
	} else if a == 49 && b == 11 {
		print!("60");
	} else if a == 49 && b == 12 {
		print!("61");
	} else if a == 49 && b == 13 {
		print!("62");
	} else if a == 49 && b == 14 {
		print!("63");
	} else if a == 49 && b == 15 {
		print!("64");
	} else if a == 49 && b == 16 {
		print!("65");
	} else if a == 49 && b == 17 {
		print!("66");
	} else if a == 49 && b == 18 {
		print!("67");
	} else if a == 49 && b == 19 {
		print!("68");
	} else if a == 49 && b == 20 {
		print!("69");
	} else if a == 49 && b == 21 {
		print!("70");
	} else if a == 49 && b == 22 {
		print!("71");
	} else if a == 49 && b == 23 {
		print!("72");
	} else if a == 49 && b == 24 {
		print!("73");
	} else if a == 49 && b == 25 {
		print!("74");
	} else if a == 49 && b == 26 {
		print!("75");
	} else if a == 49 && b == 27 {
		print!("76");
	} else if a == 49 && b == 28 {
		print!("77");
	} else if a == 49 && b == 29 {
		print!("78");
	} else if a == 49 && b == 30 {
		print!("79");
	} else if a == 49 && b == 31 {
		print!("80");
	} else if a == 49 && b == 32 {
		print!("81");
	} else if a == 49 && b == 33 {
		print!("82");
	} else if a == 49 && b == 34 {
		print!("83");
	} else if a == 49 && b == 35 {
		print!("84");
	} else if a == 49 && b == 36 {
		print!("85");
	} else if a == 49 && b == 37 {
		print!("86");
	} else if a == 49 && b == 38 {
		print!("87");
	} else if a == 49 && b == 39 {
		print!("88");
	} else if a == 49 && b == 40 {
		print!("89");
	} else if a == 49 && b == 41 {
		print!("90");
	} else if a == 49 && b == 42 {
		print!("91");
	} else if a == 49 && b == 43 {
		print!("92");
	} else if a == 49 && b == 44 {
		print!("93");
	} else if a == 49 && b == 45 {
		print!("94");
	} else if a == 49 && b == 46 {
		print!("95");
	} else if a == 49 && b == 47 {
		print!("96");
	} else if a == 49 && b == 48 {
		print!("97");
	} else if a == 49 && b == 49 {
		print!("98");
	} else if a == 49 && b == 50 {
		print!("99");
	} else if a == 50 && b == 0 {
		print!("50");
	} else if a == 50 && b == 1 {
		print!("51");
	} else if a == 50 && b == 2 {
		print!("52");
	} else if a == 50 && b == 3 {
		print!("53");
	} else if a == 50 && b == 4 {
		print!("54");
	} else if a == 50 && b == 5 {
		print!("55");
	} else if a == 50 && b == 6 {
		print!("56");
	} else if a == 50 && b == 7 {
		print!("57");
	} else if a == 50 && b == 8 {
		print!("58");
	} else if a == 50 && b == 9 {
		print!("59");
	} else if a == 50 && b == 10 {
		print!("60");
	} else if a == 50 && b == 11 {
		print!("61");
	} else if a == 50 && b == 12 {
		print!("62");
	} else if a == 50 && b == 13 {
		print!("63");
	} else if a == 50 && b == 14 {
		print!("64");
	} else if a == 50 && b == 15 {
		print!("65");
	} else if a == 50 && b == 16 {
		print!("66");
	} else if a == 50 && b == 17 {
		print!("67");
	} else if a == 50 && b == 18 {
		print!("68");
	} else if a == 50 && b == 19 {
		print!("69");
	} else if a == 50 && b == 20 {
		print!("70");
	} else if a == 50 && b == 21 {
		print!("71");
	} else if a == 50 && b == 22 {
		print!("72");
	} else if a == 50 && b == 23 {
		print!("73");
	} else if a == 50 && b == 24 {
		print!("74");
	} else if a == 50 && b == 25 {
		print!("75");
	} else if a == 50 && b == 26 {
		print!("76");
	} else if a == 50 && b == 27 {
		print!("77");
	} else if a == 50 && b == 28 {
		print!("78");
	} else if a == 50 && b == 29 {
		print!("79");
	} else if a == 50 && b == 30 {
		print!("80");
	} else if a == 50 && b == 31 {
		print!("81");
	} else if a == 50 && b == 32 {
		print!("82");
	} else if a == 50 && b == 33 {
		print!("83");
	} else if a == 50 && b == 34 {
		print!("84");
	} else if a == 50 && b == 35 {
		print!("85");
	} else if a == 50 && b == 36 {
		print!("86");
	} else if a == 50 && b == 37 {
		print!("87");
	} else if a == 50 && b == 38 {
		print!("88");
	} else if a == 50 && b == 39 {
		print!("89");
	} else if a == 50 && b == 40 {
		print!("90");
	} else if a == 50 && b == 41 {
		print!("91");
	} else if a == 50 && b == 42 {
		print!("92");
	} else if a == 50 && b == 43 {
		print!("93");
	} else if a == 50 && b == 44 {
		print!("94");
	} else if a == 50 && b == 45 {
		print!("95");
	} else if a == 50 && b == 46 {
		print!("96");
	} else if a == 50 && b == 47 {
		print!("97");
	} else if a == 50 && b == 48 {
		print!("98");
	} else if a == 50 && b == 49 {
		print!("99");
	} else if a == 50 && b == 50 {
		print!("100");
	} else {
		print!("Unsupported number given!");
	}
}

fn subtract(a: u32, b: u32) {
	if a == 0 && b == 0 {
		print!("0");
	} else if a == 0 && b == 1 {
		print!("-1");
	} else if a == 0 && b == 2 {
		print!("-2");
	} else if a == 0 && b == 3 {
		print!("-3");
	} else if a == 0 && b == 4 {
		print!("-4");
	} else if a == 0 && b == 5 {
		print!("-5");
	} else if a == 0 && b == 6 {
		print!("-6");
	} else if a == 0 && b == 7 {
		print!("-7");
	} else if a == 0 && b == 8 {
		print!("-8");
	} else if a == 0 && b == 9 {
		print!("-9");
	} else if a == 0 && b == 10 {
		print!("-10");
	} else if a == 0 && b == 11 {
		print!("-11");
	} else if a == 0 && b == 12 {
		print!("-12");
	} else if a == 0 && b == 13 {
		print!("-13");
	} else if a == 0 && b == 14 {
		print!("-14");
	} else if a == 0 && b == 15 {
		print!("-15");
	} else if a == 0 && b == 16 {
		print!("-16");
	} else if a == 0 && b == 17 {
		print!("-17");
	} else if a == 0 && b == 18 {
		print!("-18");
	} else if a == 0 && b == 19 {
		print!("-19");
	} else if a == 0 && b == 20 {
		print!("-20");
	} else if a == 0 && b == 21 {
		print!("-21");
	} else if a == 0 && b == 22 {
		print!("-22");
	} else if a == 0 && b == 23 {
		print!("-23");
	} else if a == 0 && b == 24 {
		print!("-24");
	} else if a == 0 && b == 25 {
		print!("-25");
	} else if a == 0 && b == 26 {
		print!("-26");
	} else if a == 0 && b == 27 {
		print!("-27");
	} else if a == 0 && b == 28 {
		print!("-28");
	} else if a == 0 && b == 29 {
		print!("-29");
	} else if a == 0 && b == 30 {
		print!("-30");
	} else if a == 0 && b == 31 {
		print!("-31");
	} else if a == 0 && b == 32 {
		print!("-32");
	} else if a == 0 && b == 33 {
		print!("-33");
	} else if a == 0 && b == 34 {
		print!("-34");
	} else if a == 0 && b == 35 {
		print!("-35");
	} else if a == 0 && b == 36 {
		print!("-36");
	} else if a == 0 && b == 37 {
		print!("-37");
	} else if a == 0 && b == 38 {
		print!("-38");
	} else if a == 0 && b == 39 {
		print!("-39");
	} else if a == 0 && b == 40 {
		print!("-40");
	} else if a == 0 && b == 41 {
		print!("-41");
	} else if a == 0 && b == 42 {
		print!("-42");
	} else if a == 0 && b == 43 {
		print!("-43");
	} else if a == 0 && b == 44 {
		print!("-44");
	} else if a == 0 && b == 45 {
		print!("-45");
	} else if a == 0 && b == 46 {
		print!("-46");
	} else if a == 0 && b == 47 {
		print!("-47");
	} else if a == 0 && b == 48 {
		print!("-48");
	} else if a == 0 && b == 49 {
		print!("-49");
	} else if a == 0 && b == 50 {
		print!("-50");
	} else if a == 1 && b == 0 {
		print!("1");
	} else if a == 1 && b == 1 {
		print!("0");
	} else if a == 1 && b == 2 {
		print!("-1");
	} else if a == 1 && b == 3 {
		print!("-2");
	} else if a == 1 && b == 4 {
		print!("-3");
	} else if a == 1 && b == 5 {
		print!("-4");
	} else if a == 1 && b == 6 {
		print!("-5");
	} else if a == 1 && b == 7 {
		print!("-6");
	} else if a == 1 && b == 8 {
		print!("-7");
	} else if a == 1 && b == 9 {
		print!("-8");
	} else if a == 1 && b == 10 {
		print!("-9");
	} else if a == 1 && b == 11 {
		print!("-10");
	} else if a == 1 && b == 12 {
		print!("-11");
	} else if a == 1 && b == 13 {
		print!("-12");
	} else if a == 1 && b == 14 {
		print!("-13");
	} else if a == 1 && b == 15 {
		print!("-14");
	} else if a == 1 && b == 16 {
		print!("-15");
	} else if a == 1 && b == 17 {
		print!("-16");
	} else if a == 1 && b == 18 {
		print!("-17");
	} else if a == 1 && b == 19 {
		print!("-18");
	} else if a == 1 && b == 20 {
		print!("-19");
	} else if a == 1 && b == 21 {
		print!("-20");
	} else if a == 1 && b == 22 {
		print!("-21");
	} else if a == 1 && b == 23 {
		print!("-22");
	} else if a == 1 && b == 24 {
		print!("-23");
	} else if a == 1 && b == 25 {
		print!("-24");
	} else if a == 1 && b == 26 {
		print!("-25");
	} else if a == 1 && b == 27 {
		print!("-26");
	} else if a == 1 && b == 28 {
		print!("-27");
	} else if a == 1 && b == 29 {
		print!("-28");
	} else if a == 1 && b == 30 {
		print!("-29");
	} else if a == 1 && b == 31 {
		print!("-30");
	} else if a == 1 && b == 32 {
		print!("-31");
	} else if a == 1 && b == 33 {
		print!("-32");
	} else if a == 1 && b == 34 {
		print!("-33");
	} else if a == 1 && b == 35 {
		print!("-34");
	} else if a == 1 && b == 36 {
		print!("-35");
	} else if a == 1 && b == 37 {
		print!("-36");
	} else if a == 1 && b == 38 {
		print!("-37");
	} else if a == 1 && b == 39 {
		print!("-38");
	} else if a == 1 && b == 40 {
		print!("-39");
	} else if a == 1 && b == 41 {
		print!("-40");
	} else if a == 1 && b == 42 {
		print!("-41");
	} else if a == 1 && b == 43 {
		print!("-42");
	} else if a == 1 && b == 44 {
		print!("-43");
	} else if a == 1 && b == 45 {
		print!("-44");
	} else if a == 1 && b == 46 {
		print!("-45");
	} else if a == 1 && b == 47 {
		print!("-46");
	} else if a == 1 && b == 48 {
		print!("-47");
	} else if a == 1 && b == 49 {
		print!("-48");
	} else if a == 1 && b == 50 {
		print!("-49");
	} else if a == 2 && b == 0 {
		print!("2");
	} else if a == 2 && b == 1 {
		print!("1");
	} else if a == 2 && b == 2 {
		print!("0");
	} else if a == 2 && b == 3 {
		print!("-1");
	} else if a == 2 && b == 4 {
		print!("-2");
	} else if a == 2 && b == 5 {
		print!("-3");
	} else if a == 2 && b == 6 {
		print!("-4");
	} else if a == 2 && b == 7 {
		print!("-5");
	} else if a == 2 && b == 8 {
		print!("-6");
	} else if a == 2 && b == 9 {
		print!("-7");
	} else if a == 2 && b == 10 {
		print!("-8");
	} else if a == 2 && b == 11 {
		print!("-9");
	} else if a == 2 && b == 12 {
		print!("-10");
	} else if a == 2 && b == 13 {
		print!("-11");
	} else if a == 2 && b == 14 {
		print!("-12");
	} else if a == 2 && b == 15 {
		print!("-13");
	} else if a == 2 && b == 16 {
		print!("-14");
	} else if a == 2 && b == 17 {
		print!("-15");
	} else if a == 2 && b == 18 {
		print!("-16");
	} else if a == 2 && b == 19 {
		print!("-17");
	} else if a == 2 && b == 20 {
		print!("-18");
	} else if a == 2 && b == 21 {
		print!("-19");
	} else if a == 2 && b == 22 {
		print!("-20");
	} else if a == 2 && b == 23 {
		print!("-21");
	} else if a == 2 && b == 24 {
		print!("-22");
	} else if a == 2 && b == 25 {
		print!("-23");
	} else if a == 2 && b == 26 {
		print!("-24");
	} else if a == 2 && b == 27 {
		print!("-25");
	} else if a == 2 && b == 28 {
		print!("-26");
	} else if a == 2 && b == 29 {
		print!("-27");
	} else if a == 2 && b == 30 {
		print!("-28");
	} else if a == 2 && b == 31 {
		print!("-29");
	} else if a == 2 && b == 32 {
		print!("-30");
	} else if a == 2 && b == 33 {
		print!("-31");
	} else if a == 2 && b == 34 {
		print!("-32");
	} else if a == 2 && b == 35 {
		print!("-33");
	} else if a == 2 && b == 36 {
		print!("-34");
	} else if a == 2 && b == 37 {
		print!("-35");
	} else if a == 2 && b == 38 {
		print!("-36");
	} else if a == 2 && b == 39 {
		print!("-37");
	} else if a == 2 && b == 40 {
		print!("-38");
	} else if a == 2 && b == 41 {
		print!("-39");
	} else if a == 2 && b == 42 {
		print!("-40");
	} else if a == 2 && b == 43 {
		print!("-41");
	} else if a == 2 && b == 44 {
		print!("-42");
	} else if a == 2 && b == 45 {
		print!("-43");
	} else if a == 2 && b == 46 {
		print!("-44");
	} else if a == 2 && b == 47 {
		print!("-45");
	} else if a == 2 && b == 48 {
		print!("-46");
	} else if a == 2 && b == 49 {
		print!("-47");
	} else if a == 2 && b == 50 {
		print!("-48");
	} else if a == 3 && b == 0 {
		print!("3");
	} else if a == 3 && b == 1 {
		print!("2");
	} else if a == 3 && b == 2 {
		print!("1");
	} else if a == 3 && b == 3 {
		print!("0");
	} else if a == 3 && b == 4 {
		print!("-1");
	} else if a == 3 && b == 5 {
		print!("-2");
	} else if a == 3 && b == 6 {
		print!("-3");
	} else if a == 3 && b == 7 {
		print!("-4");
	} else if a == 3 && b == 8 {
		print!("-5");
	} else if a == 3 && b == 9 {
		print!("-6");
	} else if a == 3 && b == 10 {
		print!("-7");
	} else if a == 3 && b == 11 {
		print!("-8");
	} else if a == 3 && b == 12 {
		print!("-9");
	} else if a == 3 && b == 13 {
		print!("-10");
	} else if a == 3 && b == 14 {
		print!("-11");
	} else if a == 3 && b == 15 {
		print!("-12");
	} else if a == 3 && b == 16 {
		print!("-13");
	} else if a == 3 && b == 17 {
		print!("-14");
	} else if a == 3 && b == 18 {
		print!("-15");
	} else if a == 3 && b == 19 {
		print!("-16");
	} else if a == 3 && b == 20 {
		print!("-17");
	} else if a == 3 && b == 21 {
		print!("-18");
	} else if a == 3 && b == 22 {
		print!("-19");
	} else if a == 3 && b == 23 {
		print!("-20");
	} else if a == 3 && b == 24 {
		print!("-21");
	} else if a == 3 && b == 25 {
		print!("-22");
	} else if a == 3 && b == 26 {
		print!("-23");
	} else if a == 3 && b == 27 {
		print!("-24");
	} else if a == 3 && b == 28 {
		print!("-25");
	} else if a == 3 && b == 29 {
		print!("-26");
	} else if a == 3 && b == 30 {
		print!("-27");
	} else if a == 3 && b == 31 {
		print!("-28");
	} else if a == 3 && b == 32 {
		print!("-29");
	} else if a == 3 && b == 33 {
		print!("-30");
	} else if a == 3 && b == 34 {
		print!("-31");
	} else if a == 3 && b == 35 {
		print!("-32");
	} else if a == 3 && b == 36 {
		print!("-33");
	} else if a == 3 && b == 37 {
		print!("-34");
	} else if a == 3 && b == 38 {
		print!("-35");
	} else if a == 3 && b == 39 {
		print!("-36");
	} else if a == 3 && b == 40 {
		print!("-37");
	} else if a == 3 && b == 41 {
		print!("-38");
	} else if a == 3 && b == 42 {
		print!("-39");
	} else if a == 3 && b == 43 {
		print!("-40");
	} else if a == 3 && b == 44 {
		print!("-41");
	} else if a == 3 && b == 45 {
		print!("-42");
	} else if a == 3 && b == 46 {
		print!("-43");
	} else if a == 3 && b == 47 {
		print!("-44");
	} else if a == 3 && b == 48 {
		print!("-45");
	} else if a == 3 && b == 49 {
		print!("-46");
	} else if a == 3 && b == 50 {
		print!("-47");
	} else if a == 4 && b == 0 {
		print!("4");
	} else if a == 4 && b == 1 {
		print!("3");
	} else if a == 4 && b == 2 {
		print!("2");
	} else if a == 4 && b == 3 {
		print!("1");
	} else if a == 4 && b == 4 {
		print!("0");
	} else if a == 4 && b == 5 {
		print!("-1");
	} else if a == 4 && b == 6 {
		print!("-2");
	} else if a == 4 && b == 7 {
		print!("-3");
	} else if a == 4 && b == 8 {
		print!("-4");
	} else if a == 4 && b == 9 {
		print!("-5");
	} else if a == 4 && b == 10 {
		print!("-6");
	} else if a == 4 && b == 11 {
		print!("-7");
	} else if a == 4 && b == 12 {
		print!("-8");
	} else if a == 4 && b == 13 {
		print!("-9");
	} else if a == 4 && b == 14 {
		print!("-10");
	} else if a == 4 && b == 15 {
		print!("-11");
	} else if a == 4 && b == 16 {
		print!("-12");
	} else if a == 4 && b == 17 {
		print!("-13");
	} else if a == 4 && b == 18 {
		print!("-14");
	} else if a == 4 && b == 19 {
		print!("-15");
	} else if a == 4 && b == 20 {
		print!("-16");
	} else if a == 4 && b == 21 {
		print!("-17");
	} else if a == 4 && b == 22 {
		print!("-18");
	} else if a == 4 && b == 23 {
		print!("-19");
	} else if a == 4 && b == 24 {
		print!("-20");
	} else if a == 4 && b == 25 {
		print!("-21");
	} else if a == 4 && b == 26 {
		print!("-22");
	} else if a == 4 && b == 27 {
		print!("-23");
	} else if a == 4 && b == 28 {
		print!("-24");
	} else if a == 4 && b == 29 {
		print!("-25");
	} else if a == 4 && b == 30 {
		print!("-26");
	} else if a == 4 && b == 31 {
		print!("-27");
	} else if a == 4 && b == 32 {
		print!("-28");
	} else if a == 4 && b == 33 {
		print!("-29");
	} else if a == 4 && b == 34 {
		print!("-30");
	} else if a == 4 && b == 35 {
		print!("-31");
	} else if a == 4 && b == 36 {
		print!("-32");
	} else if a == 4 && b == 37 {
		print!("-33");
	} else if a == 4 && b == 38 {
		print!("-34");
	} else if a == 4 && b == 39 {
		print!("-35");
	} else if a == 4 && b == 40 {
		print!("-36");
	} else if a == 4 && b == 41 {
		print!("-37");
	} else if a == 4 && b == 42 {
		print!("-38");
	} else if a == 4 && b == 43 {
		print!("-39");
	} else if a == 4 && b == 44 {
		print!("-40");
	} else if a == 4 && b == 45 {
		print!("-41");
	} else if a == 4 && b == 46 {
		print!("-42");
	} else if a == 4 && b == 47 {
		print!("-43");
	} else if a == 4 && b == 48 {
		print!("-44");
	} else if a == 4 && b == 49 {
		print!("-45");
	} else if a == 4 && b == 50 {
		print!("-46");
	} else if a == 5 && b == 0 {
		print!("5");
	} else if a == 5 && b == 1 {
		print!("4");
	} else if a == 5 && b == 2 {
		print!("3");
	} else if a == 5 && b == 3 {
		print!("2");
	} else if a == 5 && b == 4 {
		print!("1");
	} else if a == 5 && b == 5 {
		print!("0");
	} else if a == 5 && b == 6 {
		print!("-1");
	} else if a == 5 && b == 7 {
		print!("-2");
	} else if a == 5 && b == 8 {
		print!("-3");
	} else if a == 5 && b == 9 {
		print!("-4");
	} else if a == 5 && b == 10 {
		print!("-5");
	} else if a == 5 && b == 11 {
		print!("-6");
	} else if a == 5 && b == 12 {
		print!("-7");
	} else if a == 5 && b == 13 {
		print!("-8");
	} else if a == 5 && b == 14 {
		print!("-9");
	} else if a == 5 && b == 15 {
		print!("-10");
	} else if a == 5 && b == 16 {
		print!("-11");
	} else if a == 5 && b == 17 {
		print!("-12");
	} else if a == 5 && b == 18 {
		print!("-13");
	} else if a == 5 && b == 19 {
		print!("-14");
	} else if a == 5 && b == 20 {
		print!("-15");
	} else if a == 5 && b == 21 {
		print!("-16");
	} else if a == 5 && b == 22 {
		print!("-17");
	} else if a == 5 && b == 23 {
		print!("-18");
	} else if a == 5 && b == 24 {
		print!("-19");
	} else if a == 5 && b == 25 {
		print!("-20");
	} else if a == 5 && b == 26 {
		print!("-21");
	} else if a == 5 && b == 27 {
		print!("-22");
	} else if a == 5 && b == 28 {
		print!("-23");
	} else if a == 5 && b == 29 {
		print!("-24");
	} else if a == 5 && b == 30 {
		print!("-25");
	} else if a == 5 && b == 31 {
		print!("-26");
	} else if a == 5 && b == 32 {
		print!("-27");
	} else if a == 5 && b == 33 {
		print!("-28");
	} else if a == 5 && b == 34 {
		print!("-29");
	} else if a == 5 && b == 35 {
		print!("-30");
	} else if a == 5 && b == 36 {
		print!("-31");
	} else if a == 5 && b == 37 {
		print!("-32");
	} else if a == 5 && b == 38 {
		print!("-33");
	} else if a == 5 && b == 39 {
		print!("-34");
	} else if a == 5 && b == 40 {
		print!("-35");
	} else if a == 5 && b == 41 {
		print!("-36");
	} else if a == 5 && b == 42 {
		print!("-37");
	} else if a == 5 && b == 43 {
		print!("-38");
	} else if a == 5 && b == 44 {
		print!("-39");
	} else if a == 5 && b == 45 {
		print!("-40");
	} else if a == 5 && b == 46 {
		print!("-41");
	} else if a == 5 && b == 47 {
		print!("-42");
	} else if a == 5 && b == 48 {
		print!("-43");
	} else if a == 5 && b == 49 {
		print!("-44");
	} else if a == 5 && b == 50 {
		print!("-45");
	} else if a == 6 && b == 0 {
		print!("6");
	} else if a == 6 && b == 1 {
		print!("5");
	} else if a == 6 && b == 2 {
		print!("4");
	} else if a == 6 && b == 3 {
		print!("3");
	} else if a == 6 && b == 4 {
		print!("2");
	} else if a == 6 && b == 5 {
		print!("1");
	} else if a == 6 && b == 6 {
		print!("0");
	} else if a == 6 && b == 7 {
		print!("-1");
	} else if a == 6 && b == 8 {
		print!("-2");
	} else if a == 6 && b == 9 {
		print!("-3");
	} else if a == 6 && b == 10 {
		print!("-4");
	} else if a == 6 && b == 11 {
		print!("-5");
	} else if a == 6 && b == 12 {
		print!("-6");
	} else if a == 6 && b == 13 {
		print!("-7");
	} else if a == 6 && b == 14 {
		print!("-8");
	} else if a == 6 && b == 15 {
		print!("-9");
	} else if a == 6 && b == 16 {
		print!("-10");
	} else if a == 6 && b == 17 {
		print!("-11");
	} else if a == 6 && b == 18 {
		print!("-12");
	} else if a == 6 && b == 19 {
		print!("-13");
	} else if a == 6 && b == 20 {
		print!("-14");
	} else if a == 6 && b == 21 {
		print!("-15");
	} else if a == 6 && b == 22 {
		print!("-16");
	} else if a == 6 && b == 23 {
		print!("-17");
	} else if a == 6 && b == 24 {
		print!("-18");
	} else if a == 6 && b == 25 {
		print!("-19");
	} else if a == 6 && b == 26 {
		print!("-20");
	} else if a == 6 && b == 27 {
		print!("-21");
	} else if a == 6 && b == 28 {
		print!("-22");
	} else if a == 6 && b == 29 {
		print!("-23");
	} else if a == 6 && b == 30 {
		print!("-24");
	} else if a == 6 && b == 31 {
		print!("-25");
	} else if a == 6 && b == 32 {
		print!("-26");
	} else if a == 6 && b == 33 {
		print!("-27");
	} else if a == 6 && b == 34 {
		print!("-28");
	} else if a == 6 && b == 35 {
		print!("-29");
	} else if a == 6 && b == 36 {
		print!("-30");
	} else if a == 6 && b == 37 {
		print!("-31");
	} else if a == 6 && b == 38 {
		print!("-32");
	} else if a == 6 && b == 39 {
		print!("-33");
	} else if a == 6 && b == 40 {
		print!("-34");
	} else if a == 6 && b == 41 {
		print!("-35");
	} else if a == 6 && b == 42 {
		print!("-36");
	} else if a == 6 && b == 43 {
		print!("-37");
	} else if a == 6 && b == 44 {
		print!("-38");
	} else if a == 6 && b == 45 {
		print!("-39");
	} else if a == 6 && b == 46 {
		print!("-40");
	} else if a == 6 && b == 47 {
		print!("-41");
	} else if a == 6 && b == 48 {
		print!("-42");
	} else if a == 6 && b == 49 {
		print!("-43");
	} else if a == 6 && b == 50 {
		print!("-44");
	} else if a == 7 && b == 0 {
		print!("7");
	} else if a == 7 && b == 1 {
		print!("6");
	} else if a == 7 && b == 2 {
		print!("5");
	} else if a == 7 && b == 3 {
		print!("4");
	} else if a == 7 && b == 4 {
		print!("3");
	} else if a == 7 && b == 5 {
		print!("2");
	} else if a == 7 && b == 6 {
		print!("1");
	} else if a == 7 && b == 7 {
		print!("0");
	} else if a == 7 && b == 8 {
		print!("-1");
	} else if a == 7 && b == 9 {
		print!("-2");
	} else if a == 7 && b == 10 {
		print!("-3");
	} else if a == 7 && b == 11 {
		print!("-4");
	} else if a == 7 && b == 12 {
		print!("-5");
	} else if a == 7 && b == 13 {
		print!("-6");
	} else if a == 7 && b == 14 {
		print!("-7");
	} else if a == 7 && b == 15 {
		print!("-8");
	} else if a == 7 && b == 16 {
		print!("-9");
	} else if a == 7 && b == 17 {
		print!("-10");
	} else if a == 7 && b == 18 {
		print!("-11");
	} else if a == 7 && b == 19 {
		print!("-12");
	} else if a == 7 && b == 20 {
		print!("-13");
	} else if a == 7 && b == 21 {
		print!("-14");
	} else if a == 7 && b == 22 {
		print!("-15");
	} else if a == 7 && b == 23 {
		print!("-16");
	} else if a == 7 && b == 24 {
		print!("-17");
	} else if a == 7 && b == 25 {
		print!("-18");
	} else if a == 7 && b == 26 {
		print!("-19");
	} else if a == 7 && b == 27 {
		print!("-20");
	} else if a == 7 && b == 28 {
		print!("-21");
	} else if a == 7 && b == 29 {
		print!("-22");
	} else if a == 7 && b == 30 {
		print!("-23");
	} else if a == 7 && b == 31 {
		print!("-24");
	} else if a == 7 && b == 32 {
		print!("-25");
	} else if a == 7 && b == 33 {
		print!("-26");
	} else if a == 7 && b == 34 {
		print!("-27");
	} else if a == 7 && b == 35 {
		print!("-28");
	} else if a == 7 && b == 36 {
		print!("-29");
	} else if a == 7 && b == 37 {
		print!("-30");
	} else if a == 7 && b == 38 {
		print!("-31");
	} else if a == 7 && b == 39 {
		print!("-32");
	} else if a == 7 && b == 40 {
		print!("-33");
	} else if a == 7 && b == 41 {
		print!("-34");
	} else if a == 7 && b == 42 {
		print!("-35");
	} else if a == 7 && b == 43 {
		print!("-36");
	} else if a == 7 && b == 44 {
		print!("-37");
	} else if a == 7 && b == 45 {
		print!("-38");
	} else if a == 7 && b == 46 {
		print!("-39");
	} else if a == 7 && b == 47 {
		print!("-40");
	} else if a == 7 && b == 48 {
		print!("-41");
	} else if a == 7 && b == 49 {
		print!("-42");
	} else if a == 7 && b == 50 {
		print!("-43");
	} else if a == 8 && b == 0 {
		print!("8");
	} else if a == 8 && b == 1 {
		print!("7");
	} else if a == 8 && b == 2 {
		print!("6");
	} else if a == 8 && b == 3 {
		print!("5");
	} else if a == 8 && b == 4 {
		print!("4");
	} else if a == 8 && b == 5 {
		print!("3");
	} else if a == 8 && b == 6 {
		print!("2");
	} else if a == 8 && b == 7 {
		print!("1");
	} else if a == 8 && b == 8 {
		print!("0");
	} else if a == 8 && b == 9 {
		print!("-1");
	} else if a == 8 && b == 10 {
		print!("-2");
	} else if a == 8 && b == 11 {
		print!("-3");
	} else if a == 8 && b == 12 {
		print!("-4");
	} else if a == 8 && b == 13 {
		print!("-5");
	} else if a == 8 && b == 14 {
		print!("-6");
	} else if a == 8 && b == 15 {
		print!("-7");
	} else if a == 8 && b == 16 {
		print!("-8");
	} else if a == 8 && b == 17 {
		print!("-9");
	} else if a == 8 && b == 18 {
		print!("-10");
	} else if a == 8 && b == 19 {
		print!("-11");
	} else if a == 8 && b == 20 {
		print!("-12");
	} else if a == 8 && b == 21 {
		print!("-13");
	} else if a == 8 && b == 22 {
		print!("-14");
	} else if a == 8 && b == 23 {
		print!("-15");
	} else if a == 8 && b == 24 {
		print!("-16");
	} else if a == 8 && b == 25 {
		print!("-17");
	} else if a == 8 && b == 26 {
		print!("-18");
	} else if a == 8 && b == 27 {
		print!("-19");
	} else if a == 8 && b == 28 {
		print!("-20");
	} else if a == 8 && b == 29 {
		print!("-21");
	} else if a == 8 && b == 30 {
		print!("-22");
	} else if a == 8 && b == 31 {
		print!("-23");
	} else if a == 8 && b == 32 {
		print!("-24");
	} else if a == 8 && b == 33 {
		print!("-25");
	} else if a == 8 && b == 34 {
		print!("-26");
	} else if a == 8 && b == 35 {
		print!("-27");
	} else if a == 8 && b == 36 {
		print!("-28");
	} else if a == 8 && b == 37 {
		print!("-29");
	} else if a == 8 && b == 38 {
		print!("-30");
	} else if a == 8 && b == 39 {
		print!("-31");
	} else if a == 8 && b == 40 {
		print!("-32");
	} else if a == 8 && b == 41 {
		print!("-33");
	} else if a == 8 && b == 42 {
		print!("-34");
	} else if a == 8 && b == 43 {
		print!("-35");
	} else if a == 8 && b == 44 {
		print!("-36");
	} else if a == 8 && b == 45 {
		print!("-37");
	} else if a == 8 && b == 46 {
		print!("-38");
	} else if a == 8 && b == 47 {
		print!("-39");
	} else if a == 8 && b == 48 {
		print!("-40");
	} else if a == 8 && b == 49 {
		print!("-41");
	} else if a == 8 && b == 50 {
		print!("-42");
	} else if a == 9 && b == 0 {
		print!("9");
	} else if a == 9 && b == 1 {
		print!("8");
	} else if a == 9 && b == 2 {
		print!("7");
	} else if a == 9 && b == 3 {
		print!("6");
	} else if a == 9 && b == 4 {
		print!("5");
	} else if a == 9 && b == 5 {
		print!("4");
	} else if a == 9 && b == 6 {
		print!("3");
	} else if a == 9 && b == 7 {
		print!("2");
	} else if a == 9 && b == 8 {
		print!("1");
	} else if a == 9 && b == 9 {
		print!("0");
	} else if a == 9 && b == 10 {
		print!("-1");
	} else if a == 9 && b == 11 {
		print!("-2");
	} else if a == 9 && b == 12 {
		print!("-3");
	} else if a == 9 && b == 13 {
		print!("-4");
	} else if a == 9 && b == 14 {
		print!("-5");
	} else if a == 9 && b == 15 {
		print!("-6");
	} else if a == 9 && b == 16 {
		print!("-7");
	} else if a == 9 && b == 17 {
		print!("-8");
	} else if a == 9 && b == 18 {
		print!("-9");
	} else if a == 9 && b == 19 {
		print!("-10");
	} else if a == 9 && b == 20 {
		print!("-11");
	} else if a == 9 && b == 21 {
		print!("-12");
	} else if a == 9 && b == 22 {
		print!("-13");
	} else if a == 9 && b == 23 {
		print!("-14");
	} else if a == 9 && b == 24 {
		print!("-15");
	} else if a == 9 && b == 25 {
		print!("-16");
	} else if a == 9 && b == 26 {
		print!("-17");
	} else if a == 9 && b == 27 {
		print!("-18");
	} else if a == 9 && b == 28 {
		print!("-19");
	} else if a == 9 && b == 29 {
		print!("-20");
	} else if a == 9 && b == 30 {
		print!("-21");
	} else if a == 9 && b == 31 {
		print!("-22");
	} else if a == 9 && b == 32 {
		print!("-23");
	} else if a == 9 && b == 33 {
		print!("-24");
	} else if a == 9 && b == 34 {
		print!("-25");
	} else if a == 9 && b == 35 {
		print!("-26");
	} else if a == 9 && b == 36 {
		print!("-27");
	} else if a == 9 && b == 37 {
		print!("-28");
	} else if a == 9 && b == 38 {
		print!("-29");
	} else if a == 9 && b == 39 {
		print!("-30");
	} else if a == 9 && b == 40 {
		print!("-31");
	} else if a == 9 && b == 41 {
		print!("-32");
	} else if a == 9 && b == 42 {
		print!("-33");
	} else if a == 9 && b == 43 {
		print!("-34");
	} else if a == 9 && b == 44 {
		print!("-35");
	} else if a == 9 && b == 45 {
		print!("-36");
	} else if a == 9 && b == 46 {
		print!("-37");
	} else if a == 9 && b == 47 {
		print!("-38");
	} else if a == 9 && b == 48 {
		print!("-39");
	} else if a == 9 && b == 49 {
		print!("-40");
	} else if a == 9 && b == 50 {
		print!("-41");
	} else if a == 10 && b == 0 {
		print!("10");
	} else if a == 10 && b == 1 {
		print!("9");
	} else if a == 10 && b == 2 {
		print!("8");
	} else if a == 10 && b == 3 {
		print!("7");
	} else if a == 10 && b == 4 {
		print!("6");
	} else if a == 10 && b == 5 {
		print!("5");
	} else if a == 10 && b == 6 {
		print!("4");
	} else if a == 10 && b == 7 {
		print!("3");
	} else if a == 10 && b == 8 {
		print!("2");
	} else if a == 10 && b == 9 {
		print!("1");
	} else if a == 10 && b == 10 {
		print!("0");
	} else if a == 10 && b == 11 {
		print!("-1");
	} else if a == 10 && b == 12 {
		print!("-2");
	} else if a == 10 && b == 13 {
		print!("-3");
	} else if a == 10 && b == 14 {
		print!("-4");
	} else if a == 10 && b == 15 {
		print!("-5");
	} else if a == 10 && b == 16 {
		print!("-6");
	} else if a == 10 && b == 17 {
		print!("-7");
	} else if a == 10 && b == 18 {
		print!("-8");
	} else if a == 10 && b == 19 {
		print!("-9");
	} else if a == 10 && b == 20 {
		print!("-10");
	} else if a == 10 && b == 21 {
		print!("-11");
	} else if a == 10 && b == 22 {
		print!("-12");
	} else if a == 10 && b == 23 {
		print!("-13");
	} else if a == 10 && b == 24 {
		print!("-14");
	} else if a == 10 && b == 25 {
		print!("-15");
	} else if a == 10 && b == 26 {
		print!("-16");
	} else if a == 10 && b == 27 {
		print!("-17");
	} else if a == 10 && b == 28 {
		print!("-18");
	} else if a == 10 && b == 29 {
		print!("-19");
	} else if a == 10 && b == 30 {
		print!("-20");
	} else if a == 10 && b == 31 {
		print!("-21");
	} else if a == 10 && b == 32 {
		print!("-22");
	} else if a == 10 && b == 33 {
		print!("-23");
	} else if a == 10 && b == 34 {
		print!("-24");
	} else if a == 10 && b == 35 {
		print!("-25");
	} else if a == 10 && b == 36 {
		print!("-26");
	} else if a == 10 && b == 37 {
		print!("-27");
	} else if a == 10 && b == 38 {
		print!("-28");
	} else if a == 10 && b == 39 {
		print!("-29");
	} else if a == 10 && b == 40 {
		print!("-30");
	} else if a == 10 && b == 41 {
		print!("-31");
	} else if a == 10 && b == 42 {
		print!("-32");
	} else if a == 10 && b == 43 {
		print!("-33");
	} else if a == 10 && b == 44 {
		print!("-34");
	} else if a == 10 && b == 45 {
		print!("-35");
	} else if a == 10 && b == 46 {
		print!("-36");
	} else if a == 10 && b == 47 {
		print!("-37");
	} else if a == 10 && b == 48 {
		print!("-38");
	} else if a == 10 && b == 49 {
		print!("-39");
	} else if a == 10 && b == 50 {
		print!("-40");
	} else if a == 11 && b == 0 {
		print!("11");
	} else if a == 11 && b == 1 {
		print!("10");
	} else if a == 11 && b == 2 {
		print!("9");
	} else if a == 11 && b == 3 {
		print!("8");
	} else if a == 11 && b == 4 {
		print!("7");
	} else if a == 11 && b == 5 {
		print!("6");
	} else if a == 11 && b == 6 {
		print!("5");
	} else if a == 11 && b == 7 {
		print!("4");
	} else if a == 11 && b == 8 {
		print!("3");
	} else if a == 11 && b == 9 {
		print!("2");
	} else if a == 11 && b == 10 {
		print!("1");
	} else if a == 11 && b == 11 {
		print!("0");
	} else if a == 11 && b == 12 {
		print!("-1");
	} else if a == 11 && b == 13 {
		print!("-2");
	} else if a == 11 && b == 14 {
		print!("-3");
	} else if a == 11 && b == 15 {
		print!("-4");
	} else if a == 11 && b == 16 {
		print!("-5");
	} else if a == 11 && b == 17 {
		print!("-6");
	} else if a == 11 && b == 18 {
		print!("-7");
	} else if a == 11 && b == 19 {
		print!("-8");
	} else if a == 11 && b == 20 {
		print!("-9");
	} else if a == 11 && b == 21 {
		print!("-10");
	} else if a == 11 && b == 22 {
		print!("-11");
	} else if a == 11 && b == 23 {
		print!("-12");
	} else if a == 11 && b == 24 {
		print!("-13");
	} else if a == 11 && b == 25 {
		print!("-14");
	} else if a == 11 && b == 26 {
		print!("-15");
	} else if a == 11 && b == 27 {
		print!("-16");
	} else if a == 11 && b == 28 {
		print!("-17");
	} else if a == 11 && b == 29 {
		print!("-18");
	} else if a == 11 && b == 30 {
		print!("-19");
	} else if a == 11 && b == 31 {
		print!("-20");
	} else if a == 11 && b == 32 {
		print!("-21");
	} else if a == 11 && b == 33 {
		print!("-22");
	} else if a == 11 && b == 34 {
		print!("-23");
	} else if a == 11 && b == 35 {
		print!("-24");
	} else if a == 11 && b == 36 {
		print!("-25");
	} else if a == 11 && b == 37 {
		print!("-26");
	} else if a == 11 && b == 38 {
		print!("-27");
	} else if a == 11 && b == 39 {
		print!("-28");
	} else if a == 11 && b == 40 {
		print!("-29");
	} else if a == 11 && b == 41 {
		print!("-30");
	} else if a == 11 && b == 42 {
		print!("-31");
	} else if a == 11 && b == 43 {
		print!("-32");
	} else if a == 11 && b == 44 {
		print!("-33");
	} else if a == 11 && b == 45 {
		print!("-34");
	} else if a == 11 && b == 46 {
		print!("-35");
	} else if a == 11 && b == 47 {
		print!("-36");
	} else if a == 11 && b == 48 {
		print!("-37");
	} else if a == 11 && b == 49 {
		print!("-38");
	} else if a == 11 && b == 50 {
		print!("-39");
	} else if a == 12 && b == 0 {
		print!("12");
	} else if a == 12 && b == 1 {
		print!("11");
	} else if a == 12 && b == 2 {
		print!("10");
	} else if a == 12 && b == 3 {
		print!("9");
	} else if a == 12 && b == 4 {
		print!("8");
	} else if a == 12 && b == 5 {
		print!("7");
	} else if a == 12 && b == 6 {
		print!("6");
	} else if a == 12 && b == 7 {
		print!("5");
	} else if a == 12 && b == 8 {
		print!("4");
	} else if a == 12 && b == 9 {
		print!("3");
	} else if a == 12 && b == 10 {
		print!("2");
	} else if a == 12 && b == 11 {
		print!("1");
	} else if a == 12 && b == 12 {
		print!("0");
	} else if a == 12 && b == 13 {
		print!("-1");
	} else if a == 12 && b == 14 {
		print!("-2");
	} else if a == 12 && b == 15 {
		print!("-3");
	} else if a == 12 && b == 16 {
		print!("-4");
	} else if a == 12 && b == 17 {
		print!("-5");
	} else if a == 12 && b == 18 {
		print!("-6");
	} else if a == 12 && b == 19 {
		print!("-7");
	} else if a == 12 && b == 20 {
		print!("-8");
	} else if a == 12 && b == 21 {
		print!("-9");
	} else if a == 12 && b == 22 {
		print!("-10");
	} else if a == 12 && b == 23 {
		print!("-11");
	} else if a == 12 && b == 24 {
		print!("-12");
	} else if a == 12 && b == 25 {
		print!("-13");
	} else if a == 12 && b == 26 {
		print!("-14");
	} else if a == 12 && b == 27 {
		print!("-15");
	} else if a == 12 && b == 28 {
		print!("-16");
	} else if a == 12 && b == 29 {
		print!("-17");
	} else if a == 12 && b == 30 {
		print!("-18");
	} else if a == 12 && b == 31 {
		print!("-19");
	} else if a == 12 && b == 32 {
		print!("-20");
	} else if a == 12 && b == 33 {
		print!("-21");
	} else if a == 12 && b == 34 {
		print!("-22");
	} else if a == 12 && b == 35 {
		print!("-23");
	} else if a == 12 && b == 36 {
		print!("-24");
	} else if a == 12 && b == 37 {
		print!("-25");
	} else if a == 12 && b == 38 {
		print!("-26");
	} else if a == 12 && b == 39 {
		print!("-27");
	} else if a == 12 && b == 40 {
		print!("-28");
	} else if a == 12 && b == 41 {
		print!("-29");
	} else if a == 12 && b == 42 {
		print!("-30");
	} else if a == 12 && b == 43 {
		print!("-31");
	} else if a == 12 && b == 44 {
		print!("-32");
	} else if a == 12 && b == 45 {
		print!("-33");
	} else if a == 12 && b == 46 {
		print!("-34");
	} else if a == 12 && b == 47 {
		print!("-35");
	} else if a == 12 && b == 48 {
		print!("-36");
	} else if a == 12 && b == 49 {
		print!("-37");
	} else if a == 12 && b == 50 {
		print!("-38");
	} else if a == 13 && b == 0 {
		print!("13");
	} else if a == 13 && b == 1 {
		print!("12");
	} else if a == 13 && b == 2 {
		print!("11");
	} else if a == 13 && b == 3 {
		print!("10");
	} else if a == 13 && b == 4 {
		print!("9");
	} else if a == 13 && b == 5 {
		print!("8");
	} else if a == 13 && b == 6 {
		print!("7");
	} else if a == 13 && b == 7 {
		print!("6");
	} else if a == 13 && b == 8 {
		print!("5");
	} else if a == 13 && b == 9 {
		print!("4");
	} else if a == 13 && b == 10 {
		print!("3");
	} else if a == 13 && b == 11 {
		print!("2");
	} else if a == 13 && b == 12 {
		print!("1");
	} else if a == 13 && b == 13 {
		print!("0");
	} else if a == 13 && b == 14 {
		print!("-1");
	} else if a == 13 && b == 15 {
		print!("-2");
	} else if a == 13 && b == 16 {
		print!("-3");
	} else if a == 13 && b == 17 {
		print!("-4");
	} else if a == 13 && b == 18 {
		print!("-5");
	} else if a == 13 && b == 19 {
		print!("-6");
	} else if a == 13 && b == 20 {
		print!("-7");
	} else if a == 13 && b == 21 {
		print!("-8");
	} else if a == 13 && b == 22 {
		print!("-9");
	} else if a == 13 && b == 23 {
		print!("-10");
	} else if a == 13 && b == 24 {
		print!("-11");
	} else if a == 13 && b == 25 {
		print!("-12");
	} else if a == 13 && b == 26 {
		print!("-13");
	} else if a == 13 && b == 27 {
		print!("-14");
	} else if a == 13 && b == 28 {
		print!("-15");
	} else if a == 13 && b == 29 {
		print!("-16");
	} else if a == 13 && b == 30 {
		print!("-17");
	} else if a == 13 && b == 31 {
		print!("-18");
	} else if a == 13 && b == 32 {
		print!("-19");
	} else if a == 13 && b == 33 {
		print!("-20");
	} else if a == 13 && b == 34 {
		print!("-21");
	} else if a == 13 && b == 35 {
		print!("-22");
	} else if a == 13 && b == 36 {
		print!("-23");
	} else if a == 13 && b == 37 {
		print!("-24");
	} else if a == 13 && b == 38 {
		print!("-25");
	} else if a == 13 && b == 39 {
		print!("-26");
	} else if a == 13 && b == 40 {
		print!("-27");
	} else if a == 13 && b == 41 {
		print!("-28");
	} else if a == 13 && b == 42 {
		print!("-29");
	} else if a == 13 && b == 43 {
		print!("-30");
	} else if a == 13 && b == 44 {
		print!("-31");
	} else if a == 13 && b == 45 {
		print!("-32");
	} else if a == 13 && b == 46 {
		print!("-33");
	} else if a == 13 && b == 47 {
		print!("-34");
	} else if a == 13 && b == 48 {
		print!("-35");
	} else if a == 13 && b == 49 {
		print!("-36");
	} else if a == 13 && b == 50 {
		print!("-37");
	} else if a == 14 && b == 0 {
		print!("14");
	} else if a == 14 && b == 1 {
		print!("13");
	} else if a == 14 && b == 2 {
		print!("12");
	} else if a == 14 && b == 3 {
		print!("11");
	} else if a == 14 && b == 4 {
		print!("10");
	} else if a == 14 && b == 5 {
		print!("9");
	} else if a == 14 && b == 6 {
		print!("8");
	} else if a == 14 && b == 7 {
		print!("7");
	} else if a == 14 && b == 8 {
		print!("6");
	} else if a == 14 && b == 9 {
		print!("5");
	} else if a == 14 && b == 10 {
		print!("4");
	} else if a == 14 && b == 11 {
		print!("3");
	} else if a == 14 && b == 12 {
		print!("2");
	} else if a == 14 && b == 13 {
		print!("1");
	} else if a == 14 && b == 14 {
		print!("0");
	} else if a == 14 && b == 15 {
		print!("-1");
	} else if a == 14 && b == 16 {
		print!("-2");
	} else if a == 14 && b == 17 {
		print!("-3");
	} else if a == 14 && b == 18 {
		print!("-4");
	} else if a == 14 && b == 19 {
		print!("-5");
	} else if a == 14 && b == 20 {
		print!("-6");
	} else if a == 14 && b == 21 {
		print!("-7");
	} else if a == 14 && b == 22 {
		print!("-8");
	} else if a == 14 && b == 23 {
		print!("-9");
	} else if a == 14 && b == 24 {
		print!("-10");
	} else if a == 14 && b == 25 {
		print!("-11");
	} else if a == 14 && b == 26 {
		print!("-12");
	} else if a == 14 && b == 27 {
		print!("-13");
	} else if a == 14 && b == 28 {
		print!("-14");
	} else if a == 14 && b == 29 {
		print!("-15");
	} else if a == 14 && b == 30 {
		print!("-16");
	} else if a == 14 && b == 31 {
		print!("-17");
	} else if a == 14 && b == 32 {
		print!("-18");
	} else if a == 14 && b == 33 {
		print!("-19");
	} else if a == 14 && b == 34 {
		print!("-20");
	} else if a == 14 && b == 35 {
		print!("-21");
	} else if a == 14 && b == 36 {
		print!("-22");
	} else if a == 14 && b == 37 {
		print!("-23");
	} else if a == 14 && b == 38 {
		print!("-24");
	} else if a == 14 && b == 39 {
		print!("-25");
	} else if a == 14 && b == 40 {
		print!("-26");
	} else if a == 14 && b == 41 {
		print!("-27");
	} else if a == 14 && b == 42 {
		print!("-28");
	} else if a == 14 && b == 43 {
		print!("-29");
	} else if a == 14 && b == 44 {
		print!("-30");
	} else if a == 14 && b == 45 {
		print!("-31");
	} else if a == 14 && b == 46 {
		print!("-32");
	} else if a == 14 && b == 47 {
		print!("-33");
	} else if a == 14 && b == 48 {
		print!("-34");
	} else if a == 14 && b == 49 {
		print!("-35");
	} else if a == 14 && b == 50 {
		print!("-36");
	} else if a == 15 && b == 0 {
		print!("15");
	} else if a == 15 && b == 1 {
		print!("14");
	} else if a == 15 && b == 2 {
		print!("13");
	} else if a == 15 && b == 3 {
		print!("12");
	} else if a == 15 && b == 4 {
		print!("11");
	} else if a == 15 && b == 5 {
		print!("10");
	} else if a == 15 && b == 6 {
		print!("9");
	} else if a == 15 && b == 7 {
		print!("8");
	} else if a == 15 && b == 8 {
		print!("7");
	} else if a == 15 && b == 9 {
		print!("6");
	} else if a == 15 && b == 10 {
		print!("5");
	} else if a == 15 && b == 11 {
		print!("4");
	} else if a == 15 && b == 12 {
		print!("3");
	} else if a == 15 && b == 13 {
		print!("2");
	} else if a == 15 && b == 14 {
		print!("1");
	} else if a == 15 && b == 15 {
		print!("0");
	} else if a == 15 && b == 16 {
		print!("-1");
	} else if a == 15 && b == 17 {
		print!("-2");
	} else if a == 15 && b == 18 {
		print!("-3");
	} else if a == 15 && b == 19 {
		print!("-4");
	} else if a == 15 && b == 20 {
		print!("-5");
	} else if a == 15 && b == 21 {
		print!("-6");
	} else if a == 15 && b == 22 {
		print!("-7");
	} else if a == 15 && b == 23 {
		print!("-8");
	} else if a == 15 && b == 24 {
		print!("-9");
	} else if a == 15 && b == 25 {
		print!("-10");
	} else if a == 15 && b == 26 {
		print!("-11");
	} else if a == 15 && b == 27 {
		print!("-12");
	} else if a == 15 && b == 28 {
		print!("-13");
	} else if a == 15 && b == 29 {
		print!("-14");
	} else if a == 15 && b == 30 {
		print!("-15");
	} else if a == 15 && b == 31 {
		print!("-16");
	} else if a == 15 && b == 32 {
		print!("-17");
	} else if a == 15 && b == 33 {
		print!("-18");
	} else if a == 15 && b == 34 {
		print!("-19");
	} else if a == 15 && b == 35 {
		print!("-20");
	} else if a == 15 && b == 36 {
		print!("-21");
	} else if a == 15 && b == 37 {
		print!("-22");
	} else if a == 15 && b == 38 {
		print!("-23");
	} else if a == 15 && b == 39 {
		print!("-24");
	} else if a == 15 && b == 40 {
		print!("-25");
	} else if a == 15 && b == 41 {
		print!("-26");
	} else if a == 15 && b == 42 {
		print!("-27");
	} else if a == 15 && b == 43 {
		print!("-28");
	} else if a == 15 && b == 44 {
		print!("-29");
	} else if a == 15 && b == 45 {
		print!("-30");
	} else if a == 15 && b == 46 {
		print!("-31");
	} else if a == 15 && b == 47 {
		print!("-32");
	} else if a == 15 && b == 48 {
		print!("-33");
	} else if a == 15 && b == 49 {
		print!("-34");
	} else if a == 15 && b == 50 {
		print!("-35");
	} else if a == 16 && b == 0 {
		print!("16");
	} else if a == 16 && b == 1 {
		print!("15");
	} else if a == 16 && b == 2 {
		print!("14");
	} else if a == 16 && b == 3 {
		print!("13");
	} else if a == 16 && b == 4 {
		print!("12");
	} else if a == 16 && b == 5 {
		print!("11");
	} else if a == 16 && b == 6 {
		print!("10");
	} else if a == 16 && b == 7 {
		print!("9");
	} else if a == 16 && b == 8 {
		print!("8");
	} else if a == 16 && b == 9 {
		print!("7");
	} else if a == 16 && b == 10 {
		print!("6");
	} else if a == 16 && b == 11 {
		print!("5");
	} else if a == 16 && b == 12 {
		print!("4");
	} else if a == 16 && b == 13 {
		print!("3");
	} else if a == 16 && b == 14 {
		print!("2");
	} else if a == 16 && b == 15 {
		print!("1");
	} else if a == 16 && b == 16 {
		print!("0");
	} else if a == 16 && b == 17 {
		print!("-1");
	} else if a == 16 && b == 18 {
		print!("-2");
	} else if a == 16 && b == 19 {
		print!("-3");
	} else if a == 16 && b == 20 {
		print!("-4");
	} else if a == 16 && b == 21 {
		print!("-5");
	} else if a == 16 && b == 22 {
		print!("-6");
	} else if a == 16 && b == 23 {
		print!("-7");
	} else if a == 16 && b == 24 {
		print!("-8");
	} else if a == 16 && b == 25 {
		print!("-9");
	} else if a == 16 && b == 26 {
		print!("-10");
	} else if a == 16 && b == 27 {
		print!("-11");
	} else if a == 16 && b == 28 {
		print!("-12");
	} else if a == 16 && b == 29 {
		print!("-13");
	} else if a == 16 && b == 30 {
		print!("-14");
	} else if a == 16 && b == 31 {
		print!("-15");
	} else if a == 16 && b == 32 {
		print!("-16");
	} else if a == 16 && b == 33 {
		print!("-17");
	} else if a == 16 && b == 34 {
		print!("-18");
	} else if a == 16 && b == 35 {
		print!("-19");
	} else if a == 16 && b == 36 {
		print!("-20");
	} else if a == 16 && b == 37 {
		print!("-21");
	} else if a == 16 && b == 38 {
		print!("-22");
	} else if a == 16 && b == 39 {
		print!("-23");
	} else if a == 16 && b == 40 {
		print!("-24");
	} else if a == 16 && b == 41 {
		print!("-25");
	} else if a == 16 && b == 42 {
		print!("-26");
	} else if a == 16 && b == 43 {
		print!("-27");
	} else if a == 16 && b == 44 {
		print!("-28");
	} else if a == 16 && b == 45 {
		print!("-29");
	} else if a == 16 && b == 46 {
		print!("-30");
	} else if a == 16 && b == 47 {
		print!("-31");
	} else if a == 16 && b == 48 {
		print!("-32");
	} else if a == 16 && b == 49 {
		print!("-33");
	} else if a == 16 && b == 50 {
		print!("-34");
	} else if a == 17 && b == 0 {
		print!("17");
	} else if a == 17 && b == 1 {
		print!("16");
	} else if a == 17 && b == 2 {
		print!("15");
	} else if a == 17 && b == 3 {
		print!("14");
	} else if a == 17 && b == 4 {
		print!("13");
	} else if a == 17 && b == 5 {
		print!("12");
	} else if a == 17 && b == 6 {
		print!("11");
	} else if a == 17 && b == 7 {
		print!("10");
	} else if a == 17 && b == 8 {
		print!("9");
	} else if a == 17 && b == 9 {
		print!("8");
	} else if a == 17 && b == 10 {
		print!("7");
	} else if a == 17 && b == 11 {
		print!("6");
	} else if a == 17 && b == 12 {
		print!("5");
	} else if a == 17 && b == 13 {
		print!("4");
	} else if a == 17 && b == 14 {
		print!("3");
	} else if a == 17 && b == 15 {
		print!("2");
	} else if a == 17 && b == 16 {
		print!("1");
	} else if a == 17 && b == 17 {
		print!("0");
	} else if a == 17 && b == 18 {
		print!("-1");
	} else if a == 17 && b == 19 {
		print!("-2");
	} else if a == 17 && b == 20 {
		print!("-3");
	} else if a == 17 && b == 21 {
		print!("-4");
	} else if a == 17 && b == 22 {
		print!("-5");
	} else if a == 17 && b == 23 {
		print!("-6");
	} else if a == 17 && b == 24 {
		print!("-7");
	} else if a == 17 && b == 25 {
		print!("-8");
	} else if a == 17 && b == 26 {
		print!("-9");
	} else if a == 17 && b == 27 {
		print!("-10");
	} else if a == 17 && b == 28 {
		print!("-11");
	} else if a == 17 && b == 29 {
		print!("-12");
	} else if a == 17 && b == 30 {
		print!("-13");
	} else if a == 17 && b == 31 {
		print!("-14");
	} else if a == 17 && b == 32 {
		print!("-15");
	} else if a == 17 && b == 33 {
		print!("-16");
	} else if a == 17 && b == 34 {
		print!("-17");
	} else if a == 17 && b == 35 {
		print!("-18");
	} else if a == 17 && b == 36 {
		print!("-19");
	} else if a == 17 && b == 37 {
		print!("-20");
	} else if a == 17 && b == 38 {
		print!("-21");
	} else if a == 17 && b == 39 {
		print!("-22");
	} else if a == 17 && b == 40 {
		print!("-23");
	} else if a == 17 && b == 41 {
		print!("-24");
	} else if a == 17 && b == 42 {
		print!("-25");
	} else if a == 17 && b == 43 {
		print!("-26");
	} else if a == 17 && b == 44 {
		print!("-27");
	} else if a == 17 && b == 45 {
		print!("-28");
	} else if a == 17 && b == 46 {
		print!("-29");
	} else if a == 17 && b == 47 {
		print!("-30");
	} else if a == 17 && b == 48 {
		print!("-31");
	} else if a == 17 && b == 49 {
		print!("-32");
	} else if a == 17 && b == 50 {
		print!("-33");
	} else if a == 18 && b == 0 {
		print!("18");
	} else if a == 18 && b == 1 {
		print!("17");
	} else if a == 18 && b == 2 {
		print!("16");
	} else if a == 18 && b == 3 {
		print!("15");
	} else if a == 18 && b == 4 {
		print!("14");
	} else if a == 18 && b == 5 {
		print!("13");
	} else if a == 18 && b == 6 {
		print!("12");
	} else if a == 18 && b == 7 {
		print!("11");
	} else if a == 18 && b == 8 {
		print!("10");
	} else if a == 18 && b == 9 {
		print!("9");
	} else if a == 18 && b == 10 {
		print!("8");
	} else if a == 18 && b == 11 {
		print!("7");
	} else if a == 18 && b == 12 {
		print!("6");
	} else if a == 18 && b == 13 {
		print!("5");
	} else if a == 18 && b == 14 {
		print!("4");
	} else if a == 18 && b == 15 {
		print!("3");
	} else if a == 18 && b == 16 {
		print!("2");
	} else if a == 18 && b == 17 {
		print!("1");
	} else if a == 18 && b == 18 {
		print!("0");
	} else if a == 18 && b == 19 {
		print!("-1");
	} else if a == 18 && b == 20 {
		print!("-2");
	} else if a == 18 && b == 21 {
		print!("-3");
	} else if a == 18 && b == 22 {
		print!("-4");
	} else if a == 18 && b == 23 {
		print!("-5");
	} else if a == 18 && b == 24 {
		print!("-6");
	} else if a == 18 && b == 25 {
		print!("-7");
	} else if a == 18 && b == 26 {
		print!("-8");
	} else if a == 18 && b == 27 {
		print!("-9");
	} else if a == 18 && b == 28 {
		print!("-10");
	} else if a == 18 && b == 29 {
		print!("-11");
	} else if a == 18 && b == 30 {
		print!("-12");
	} else if a == 18 && b == 31 {
		print!("-13");
	} else if a == 18 && b == 32 {
		print!("-14");
	} else if a == 18 && b == 33 {
		print!("-15");
	} else if a == 18 && b == 34 {
		print!("-16");
	} else if a == 18 && b == 35 {
		print!("-17");
	} else if a == 18 && b == 36 {
		print!("-18");
	} else if a == 18 && b == 37 {
		print!("-19");
	} else if a == 18 && b == 38 {
		print!("-20");
	} else if a == 18 && b == 39 {
		print!("-21");
	} else if a == 18 && b == 40 {
		print!("-22");
	} else if a == 18 && b == 41 {
		print!("-23");
	} else if a == 18 && b == 42 {
		print!("-24");
	} else if a == 18 && b == 43 {
		print!("-25");
	} else if a == 18 && b == 44 {
		print!("-26");
	} else if a == 18 && b == 45 {
		print!("-27");
	} else if a == 18 && b == 46 {
		print!("-28");
	} else if a == 18 && b == 47 {
		print!("-29");
	} else if a == 18 && b == 48 {
		print!("-30");
	} else if a == 18 && b == 49 {
		print!("-31");
	} else if a == 18 && b == 50 {
		print!("-32");
	} else if a == 19 && b == 0 {
		print!("19");
	} else if a == 19 && b == 1 {
		print!("18");
	} else if a == 19 && b == 2 {
		print!("17");
	} else if a == 19 && b == 3 {
		print!("16");
	} else if a == 19 && b == 4 {
		print!("15");
	} else if a == 19 && b == 5 {
		print!("14");
	} else if a == 19 && b == 6 {
		print!("13");
	} else if a == 19 && b == 7 {
		print!("12");
	} else if a == 19 && b == 8 {
		print!("11");
	} else if a == 19 && b == 9 {
		print!("10");
	} else if a == 19 && b == 10 {
		print!("9");
	} else if a == 19 && b == 11 {
		print!("8");
	} else if a == 19 && b == 12 {
		print!("7");
	} else if a == 19 && b == 13 {
		print!("6");
	} else if a == 19 && b == 14 {
		print!("5");
	} else if a == 19 && b == 15 {
		print!("4");
	} else if a == 19 && b == 16 {
		print!("3");
	} else if a == 19 && b == 17 {
		print!("2");
	} else if a == 19 && b == 18 {
		print!("1");
	} else if a == 19 && b == 19 {
		print!("0");
	} else if a == 19 && b == 20 {
		print!("-1");
	} else if a == 19 && b == 21 {
		print!("-2");
	} else if a == 19 && b == 22 {
		print!("-3");
	} else if a == 19 && b == 23 {
		print!("-4");
	} else if a == 19 && b == 24 {
		print!("-5");
	} else if a == 19 && b == 25 {
		print!("-6");
	} else if a == 19 && b == 26 {
		print!("-7");
	} else if a == 19 && b == 27 {
		print!("-8");
	} else if a == 19 && b == 28 {
		print!("-9");
	} else if a == 19 && b == 29 {
		print!("-10");
	} else if a == 19 && b == 30 {
		print!("-11");
	} else if a == 19 && b == 31 {
		print!("-12");
	} else if a == 19 && b == 32 {
		print!("-13");
	} else if a == 19 && b == 33 {
		print!("-14");
	} else if a == 19 && b == 34 {
		print!("-15");
	} else if a == 19 && b == 35 {
		print!("-16");
	} else if a == 19 && b == 36 {
		print!("-17");
	} else if a == 19 && b == 37 {
		print!("-18");
	} else if a == 19 && b == 38 {
		print!("-19");
	} else if a == 19 && b == 39 {
		print!("-20");
	} else if a == 19 && b == 40 {
		print!("-21");
	} else if a == 19 && b == 41 {
		print!("-22");
	} else if a == 19 && b == 42 {
		print!("-23");
	} else if a == 19 && b == 43 {
		print!("-24");
	} else if a == 19 && b == 44 {
		print!("-25");
	} else if a == 19 && b == 45 {
		print!("-26");
	} else if a == 19 && b == 46 {
		print!("-27");
	} else if a == 19 && b == 47 {
		print!("-28");
	} else if a == 19 && b == 48 {
		print!("-29");
	} else if a == 19 && b == 49 {
		print!("-30");
	} else if a == 19 && b == 50 {
		print!("-31");
	} else if a == 20 && b == 0 {
		print!("20");
	} else if a == 20 && b == 1 {
		print!("19");
	} else if a == 20 && b == 2 {
		print!("18");
	} else if a == 20 && b == 3 {
		print!("17");
	} else if a == 20 && b == 4 {
		print!("16");
	} else if a == 20 && b == 5 {
		print!("15");
	} else if a == 20 && b == 6 {
		print!("14");
	} else if a == 20 && b == 7 {
		print!("13");
	} else if a == 20 && b == 8 {
		print!("12");
	} else if a == 20 && b == 9 {
		print!("11");
	} else if a == 20 && b == 10 {
		print!("10");
	} else if a == 20 && b == 11 {
		print!("9");
	} else if a == 20 && b == 12 {
		print!("8");
	} else if a == 20 && b == 13 {
		print!("7");
	} else if a == 20 && b == 14 {
		print!("6");
	} else if a == 20 && b == 15 {
		print!("5");
	} else if a == 20 && b == 16 {
		print!("4");
	} else if a == 20 && b == 17 {
		print!("3");
	} else if a == 20 && b == 18 {
		print!("2");
	} else if a == 20 && b == 19 {
		print!("1");
	} else if a == 20 && b == 20 {
		print!("0");
	} else if a == 20 && b == 21 {
		print!("-1");
	} else if a == 20 && b == 22 {
		print!("-2");
	} else if a == 20 && b == 23 {
		print!("-3");
	} else if a == 20 && b == 24 {
		print!("-4");
	} else if a == 20 && b == 25 {
		print!("-5");
	} else if a == 20 && b == 26 {
		print!("-6");
	} else if a == 20 && b == 27 {
		print!("-7");
	} else if a == 20 && b == 28 {
		print!("-8");
	} else if a == 20 && b == 29 {
		print!("-9");
	} else if a == 20 && b == 30 {
		print!("-10");
	} else if a == 20 && b == 31 {
		print!("-11");
	} else if a == 20 && b == 32 {
		print!("-12");
	} else if a == 20 && b == 33 {
		print!("-13");
	} else if a == 20 && b == 34 {
		print!("-14");
	} else if a == 20 && b == 35 {
		print!("-15");
	} else if a == 20 && b == 36 {
		print!("-16");
	} else if a == 20 && b == 37 {
		print!("-17");
	} else if a == 20 && b == 38 {
		print!("-18");
	} else if a == 20 && b == 39 {
		print!("-19");
	} else if a == 20 && b == 40 {
		print!("-20");
	} else if a == 20 && b == 41 {
		print!("-21");
	} else if a == 20 && b == 42 {
		print!("-22");
	} else if a == 20 && b == 43 {
		print!("-23");
	} else if a == 20 && b == 44 {
		print!("-24");
	} else if a == 20 && b == 45 {
		print!("-25");
	} else if a == 20 && b == 46 {
		print!("-26");
	} else if a == 20 && b == 47 {
		print!("-27");
	} else if a == 20 && b == 48 {
		print!("-28");
	} else if a == 20 && b == 49 {
		print!("-29");
	} else if a == 20 && b == 50 {
		print!("-30");
	} else if a == 21 && b == 0 {
		print!("21");
	} else if a == 21 && b == 1 {
		print!("20");
	} else if a == 21 && b == 2 {
		print!("19");
	} else if a == 21 && b == 3 {
		print!("18");
	} else if a == 21 && b == 4 {
		print!("17");
	} else if a == 21 && b == 5 {
		print!("16");
	} else if a == 21 && b == 6 {
		print!("15");
	} else if a == 21 && b == 7 {
		print!("14");
	} else if a == 21 && b == 8 {
		print!("13");
	} else if a == 21 && b == 9 {
		print!("12");
	} else if a == 21 && b == 10 {
		print!("11");
	} else if a == 21 && b == 11 {
		print!("10");
	} else if a == 21 && b == 12 {
		print!("9");
	} else if a == 21 && b == 13 {
		print!("8");
	} else if a == 21 && b == 14 {
		print!("7");
	} else if a == 21 && b == 15 {
		print!("6");
	} else if a == 21 && b == 16 {
		print!("5");
	} else if a == 21 && b == 17 {
		print!("4");
	} else if a == 21 && b == 18 {
		print!("3");
	} else if a == 21 && b == 19 {
		print!("2");
	} else if a == 21 && b == 20 {
		print!("1");
	} else if a == 21 && b == 21 {
		print!("0");
	} else if a == 21 && b == 22 {
		print!("-1");
	} else if a == 21 && b == 23 {
		print!("-2");
	} else if a == 21 && b == 24 {
		print!("-3");
	} else if a == 21 && b == 25 {
		print!("-4");
	} else if a == 21 && b == 26 {
		print!("-5");
	} else if a == 21 && b == 27 {
		print!("-6");
	} else if a == 21 && b == 28 {
		print!("-7");
	} else if a == 21 && b == 29 {
		print!("-8");
	} else if a == 21 && b == 30 {
		print!("-9");
	} else if a == 21 && b == 31 {
		print!("-10");
	} else if a == 21 && b == 32 {
		print!("-11");
	} else if a == 21 && b == 33 {
		print!("-12");
	} else if a == 21 && b == 34 {
		print!("-13");
	} else if a == 21 && b == 35 {
		print!("-14");
	} else if a == 21 && b == 36 {
		print!("-15");
	} else if a == 21 && b == 37 {
		print!("-16");
	} else if a == 21 && b == 38 {
		print!("-17");
	} else if a == 21 && b == 39 {
		print!("-18");
	} else if a == 21 && b == 40 {
		print!("-19");
	} else if a == 21 && b == 41 {
		print!("-20");
	} else if a == 21 && b == 42 {
		print!("-21");
	} else if a == 21 && b == 43 {
		print!("-22");
	} else if a == 21 && b == 44 {
		print!("-23");
	} else if a == 21 && b == 45 {
		print!("-24");
	} else if a == 21 && b == 46 {
		print!("-25");
	} else if a == 21 && b == 47 {
		print!("-26");
	} else if a == 21 && b == 48 {
		print!("-27");
	} else if a == 21 && b == 49 {
		print!("-28");
	} else if a == 21 && b == 50 {
		print!("-29");
	} else if a == 22 && b == 0 {
		print!("22");
	} else if a == 22 && b == 1 {
		print!("21");
	} else if a == 22 && b == 2 {
		print!("20");
	} else if a == 22 && b == 3 {
		print!("19");
	} else if a == 22 && b == 4 {
		print!("18");
	} else if a == 22 && b == 5 {
		print!("17");
	} else if a == 22 && b == 6 {
		print!("16");
	} else if a == 22 && b == 7 {
		print!("15");
	} else if a == 22 && b == 8 {
		print!("14");
	} else if a == 22 && b == 9 {
		print!("13");
	} else if a == 22 && b == 10 {
		print!("12");
	} else if a == 22 && b == 11 {
		print!("11");
	} else if a == 22 && b == 12 {
		print!("10");
	} else if a == 22 && b == 13 {
		print!("9");
	} else if a == 22 && b == 14 {
		print!("8");
	} else if a == 22 && b == 15 {
		print!("7");
	} else if a == 22 && b == 16 {
		print!("6");
	} else if a == 22 && b == 17 {
		print!("5");
	} else if a == 22 && b == 18 {
		print!("4");
	} else if a == 22 && b == 19 {
		print!("3");
	} else if a == 22 && b == 20 {
		print!("2");
	} else if a == 22 && b == 21 {
		print!("1");
	} else if a == 22 && b == 22 {
		print!("0");
	} else if a == 22 && b == 23 {
		print!("-1");
	} else if a == 22 && b == 24 {
		print!("-2");
	} else if a == 22 && b == 25 {
		print!("-3");
	} else if a == 22 && b == 26 {
		print!("-4");
	} else if a == 22 && b == 27 {
		print!("-5");
	} else if a == 22 && b == 28 {
		print!("-6");
	} else if a == 22 && b == 29 {
		print!("-7");
	} else if a == 22 && b == 30 {
		print!("-8");
	} else if a == 22 && b == 31 {
		print!("-9");
	} else if a == 22 && b == 32 {
		print!("-10");
	} else if a == 22 && b == 33 {
		print!("-11");
	} else if a == 22 && b == 34 {
		print!("-12");
	} else if a == 22 && b == 35 {
		print!("-13");
	} else if a == 22 && b == 36 {
		print!("-14");
	} else if a == 22 && b == 37 {
		print!("-15");
	} else if a == 22 && b == 38 {
		print!("-16");
	} else if a == 22 && b == 39 {
		print!("-17");
	} else if a == 22 && b == 40 {
		print!("-18");
	} else if a == 22 && b == 41 {
		print!("-19");
	} else if a == 22 && b == 42 {
		print!("-20");
	} else if a == 22 && b == 43 {
		print!("-21");
	} else if a == 22 && b == 44 {
		print!("-22");
	} else if a == 22 && b == 45 {
		print!("-23");
	} else if a == 22 && b == 46 {
		print!("-24");
	} else if a == 22 && b == 47 {
		print!("-25");
	} else if a == 22 && b == 48 {
		print!("-26");
	} else if a == 22 && b == 49 {
		print!("-27");
	} else if a == 22 && b == 50 {
		print!("-28");
	} else if a == 23 && b == 0 {
		print!("23");
	} else if a == 23 && b == 1 {
		print!("22");
	} else if a == 23 && b == 2 {
		print!("21");
	} else if a == 23 && b == 3 {
		print!("20");
	} else if a == 23 && b == 4 {
		print!("19");
	} else if a == 23 && b == 5 {
		print!("18");
	} else if a == 23 && b == 6 {
		print!("17");
	} else if a == 23 && b == 7 {
		print!("16");
	} else if a == 23 && b == 8 {
		print!("15");
	} else if a == 23 && b == 9 {
		print!("14");
	} else if a == 23 && b == 10 {
		print!("13");
	} else if a == 23 && b == 11 {
		print!("12");
	} else if a == 23 && b == 12 {
		print!("11");
	} else if a == 23 && b == 13 {
		print!("10");
	} else if a == 23 && b == 14 {
		print!("9");
	} else if a == 23 && b == 15 {
		print!("8");
	} else if a == 23 && b == 16 {
		print!("7");
	} else if a == 23 && b == 17 {
		print!("6");
	} else if a == 23 && b == 18 {
		print!("5");
	} else if a == 23 && b == 19 {
		print!("4");
	} else if a == 23 && b == 20 {
		print!("3");
	} else if a == 23 && b == 21 {
		print!("2");
	} else if a == 23 && b == 22 {
		print!("1");
	} else if a == 23 && b == 23 {
		print!("0");
	} else if a == 23 && b == 24 {
		print!("-1");
	} else if a == 23 && b == 25 {
		print!("-2");
	} else if a == 23 && b == 26 {
		print!("-3");
	} else if a == 23 && b == 27 {
		print!("-4");
	} else if a == 23 && b == 28 {
		print!("-5");
	} else if a == 23 && b == 29 {
		print!("-6");
	} else if a == 23 && b == 30 {
		print!("-7");
	} else if a == 23 && b == 31 {
		print!("-8");
	} else if a == 23 && b == 32 {
		print!("-9");
	} else if a == 23 && b == 33 {
		print!("-10");
	} else if a == 23 && b == 34 {
		print!("-11");
	} else if a == 23 && b == 35 {
		print!("-12");
	} else if a == 23 && b == 36 {
		print!("-13");
	} else if a == 23 && b == 37 {
		print!("-14");
	} else if a == 23 && b == 38 {
		print!("-15");
	} else if a == 23 && b == 39 {
		print!("-16");
	} else if a == 23 && b == 40 {
		print!("-17");
	} else if a == 23 && b == 41 {
		print!("-18");
	} else if a == 23 && b == 42 {
		print!("-19");
	} else if a == 23 && b == 43 {
		print!("-20");
	} else if a == 23 && b == 44 {
		print!("-21");
	} else if a == 23 && b == 45 {
		print!("-22");
	} else if a == 23 && b == 46 {
		print!("-23");
	} else if a == 23 && b == 47 {
		print!("-24");
	} else if a == 23 && b == 48 {
		print!("-25");
	} else if a == 23 && b == 49 {
		print!("-26");
	} else if a == 23 && b == 50 {
		print!("-27");
	} else if a == 24 && b == 0 {
		print!("24");
	} else if a == 24 && b == 1 {
		print!("23");
	} else if a == 24 && b == 2 {
		print!("22");
	} else if a == 24 && b == 3 {
		print!("21");
	} else if a == 24 && b == 4 {
		print!("20");
	} else if a == 24 && b == 5 {
		print!("19");
	} else if a == 24 && b == 6 {
		print!("18");
	} else if a == 24 && b == 7 {
		print!("17");
	} else if a == 24 && b == 8 {
		print!("16");
	} else if a == 24 && b == 9 {
		print!("15");
	} else if a == 24 && b == 10 {
		print!("14");
	} else if a == 24 && b == 11 {
		print!("13");
	} else if a == 24 && b == 12 {
		print!("12");
	} else if a == 24 && b == 13 {
		print!("11");
	} else if a == 24 && b == 14 {
		print!("10");
	} else if a == 24 && b == 15 {
		print!("9");
	} else if a == 24 && b == 16 {
		print!("8");
	} else if a == 24 && b == 17 {
		print!("7");
	} else if a == 24 && b == 18 {
		print!("6");
	} else if a == 24 && b == 19 {
		print!("5");
	} else if a == 24 && b == 20 {
		print!("4");
	} else if a == 24 && b == 21 {
		print!("3");
	} else if a == 24 && b == 22 {
		print!("2");
	} else if a == 24 && b == 23 {
		print!("1");
	} else if a == 24 && b == 24 {
		print!("0");
	} else if a == 24 && b == 25 {
		print!("-1");
	} else if a == 24 && b == 26 {
		print!("-2");
	} else if a == 24 && b == 27 {
		print!("-3");
	} else if a == 24 && b == 28 {
		print!("-4");
	} else if a == 24 && b == 29 {
		print!("-5");
	} else if a == 24 && b == 30 {
		print!("-6");
	} else if a == 24 && b == 31 {
		print!("-7");
	} else if a == 24 && b == 32 {
		print!("-8");
	} else if a == 24 && b == 33 {
		print!("-9");
	} else if a == 24 && b == 34 {
		print!("-10");
	} else if a == 24 && b == 35 {
		print!("-11");
	} else if a == 24 && b == 36 {
		print!("-12");
	} else if a == 24 && b == 37 {
		print!("-13");
	} else if a == 24 && b == 38 {
		print!("-14");
	} else if a == 24 && b == 39 {
		print!("-15");
	} else if a == 24 && b == 40 {
		print!("-16");
	} else if a == 24 && b == 41 {
		print!("-17");
	} else if a == 24 && b == 42 {
		print!("-18");
	} else if a == 24 && b == 43 {
		print!("-19");
	} else if a == 24 && b == 44 {
		print!("-20");
	} else if a == 24 && b == 45 {
		print!("-21");
	} else if a == 24 && b == 46 {
		print!("-22");
	} else if a == 24 && b == 47 {
		print!("-23");
	} else if a == 24 && b == 48 {
		print!("-24");
	} else if a == 24 && b == 49 {
		print!("-25");
	} else if a == 24 && b == 50 {
		print!("-26");
	} else if a == 25 && b == 0 {
		print!("25");
	} else if a == 25 && b == 1 {
		print!("24");
	} else if a == 25 && b == 2 {
		print!("23");
	} else if a == 25 && b == 3 {
		print!("22");
	} else if a == 25 && b == 4 {
		print!("21");
	} else if a == 25 && b == 5 {
		print!("20");
	} else if a == 25 && b == 6 {
		print!("19");
	} else if a == 25 && b == 7 {
		print!("18");
	} else if a == 25 && b == 8 {
		print!("17");
	} else if a == 25 && b == 9 {
		print!("16");
	} else if a == 25 && b == 10 {
		print!("15");
	} else if a == 25 && b == 11 {
		print!("14");
	} else if a == 25 && b == 12 {
		print!("13");
	} else if a == 25 && b == 13 {
		print!("12");
	} else if a == 25 && b == 14 {
		print!("11");
	} else if a == 25 && b == 15 {
		print!("10");
	} else if a == 25 && b == 16 {
		print!("9");
	} else if a == 25 && b == 17 {
		print!("8");
	} else if a == 25 && b == 18 {
		print!("7");
	} else if a == 25 && b == 19 {
		print!("6");
	} else if a == 25 && b == 20 {
		print!("5");
	} else if a == 25 && b == 21 {
		print!("4");
	} else if a == 25 && b == 22 {
		print!("3");
	} else if a == 25 && b == 23 {
		print!("2");
	} else if a == 25 && b == 24 {
		print!("1");
	} else if a == 25 && b == 25 {
		print!("0");
	} else if a == 25 && b == 26 {
		print!("-1");
	} else if a == 25 && b == 27 {
		print!("-2");
	} else if a == 25 && b == 28 {
		print!("-3");
	} else if a == 25 && b == 29 {
		print!("-4");
	} else if a == 25 && b == 30 {
		print!("-5");
	} else if a == 25 && b == 31 {
		print!("-6");
	} else if a == 25 && b == 32 {
		print!("-7");
	} else if a == 25 && b == 33 {
		print!("-8");
	} else if a == 25 && b == 34 {
		print!("-9");
	} else if a == 25 && b == 35 {
		print!("-10");
	} else if a == 25 && b == 36 {
		print!("-11");
	} else if a == 25 && b == 37 {
		print!("-12");
	} else if a == 25 && b == 38 {
		print!("-13");
	} else if a == 25 && b == 39 {
		print!("-14");
	} else if a == 25 && b == 40 {
		print!("-15");
	} else if a == 25 && b == 41 {
		print!("-16");
	} else if a == 25 && b == 42 {
		print!("-17");
	} else if a == 25 && b == 43 {
		print!("-18");
	} else if a == 25 && b == 44 {
		print!("-19");
	} else if a == 25 && b == 45 {
		print!("-20");
	} else if a == 25 && b == 46 {
		print!("-21");
	} else if a == 25 && b == 47 {
		print!("-22");
	} else if a == 25 && b == 48 {
		print!("-23");
	} else if a == 25 && b == 49 {
		print!("-24");
	} else if a == 25 && b == 50 {
		print!("-25");
	} else if a == 26 && b == 0 {
		print!("26");
	} else if a == 26 && b == 1 {
		print!("25");
	} else if a == 26 && b == 2 {
		print!("24");
	} else if a == 26 && b == 3 {
		print!("23");
	} else if a == 26 && b == 4 {
		print!("22");
	} else if a == 26 && b == 5 {
		print!("21");
	} else if a == 26 && b == 6 {
		print!("20");
	} else if a == 26 && b == 7 {
		print!("19");
	} else if a == 26 && b == 8 {
		print!("18");
	} else if a == 26 && b == 9 {
		print!("17");
	} else if a == 26 && b == 10 {
		print!("16");
	} else if a == 26 && b == 11 {
		print!("15");
	} else if a == 26 && b == 12 {
		print!("14");
	} else if a == 26 && b == 13 {
		print!("13");
	} else if a == 26 && b == 14 {
		print!("12");
	} else if a == 26 && b == 15 {
		print!("11");
	} else if a == 26 && b == 16 {
		print!("10");
	} else if a == 26 && b == 17 {
		print!("9");
	} else if a == 26 && b == 18 {
		print!("8");
	} else if a == 26 && b == 19 {
		print!("7");
	} else if a == 26 && b == 20 {
		print!("6");
	} else if a == 26 && b == 21 {
		print!("5");
	} else if a == 26 && b == 22 {
		print!("4");
	} else if a == 26 && b == 23 {
		print!("3");
	} else if a == 26 && b == 24 {
		print!("2");
	} else if a == 26 && b == 25 {
		print!("1");
	} else if a == 26 && b == 26 {
		print!("0");
	} else if a == 26 && b == 27 {
		print!("-1");
	} else if a == 26 && b == 28 {
		print!("-2");
	} else if a == 26 && b == 29 {
		print!("-3");
	} else if a == 26 && b == 30 {
		print!("-4");
	} else if a == 26 && b == 31 {
		print!("-5");
	} else if a == 26 && b == 32 {
		print!("-6");
	} else if a == 26 && b == 33 {
		print!("-7");
	} else if a == 26 && b == 34 {
		print!("-8");
	} else if a == 26 && b == 35 {
		print!("-9");
	} else if a == 26 && b == 36 {
		print!("-10");
	} else if a == 26 && b == 37 {
		print!("-11");
	} else if a == 26 && b == 38 {
		print!("-12");
	} else if a == 26 && b == 39 {
		print!("-13");
	} else if a == 26 && b == 40 {
		print!("-14");
	} else if a == 26 && b == 41 {
		print!("-15");
	} else if a == 26 && b == 42 {
		print!("-16");
	} else if a == 26 && b == 43 {
		print!("-17");
	} else if a == 26 && b == 44 {
		print!("-18");
	} else if a == 26 && b == 45 {
		print!("-19");
	} else if a == 26 && b == 46 {
		print!("-20");
	} else if a == 26 && b == 47 {
		print!("-21");
	} else if a == 26 && b == 48 {
		print!("-22");
	} else if a == 26 && b == 49 {
		print!("-23");
	} else if a == 26 && b == 50 {
		print!("-24");
	} else if a == 27 && b == 0 {
		print!("27");
	} else if a == 27 && b == 1 {
		print!("26");
	} else if a == 27 && b == 2 {
		print!("25");
	} else if a == 27 && b == 3 {
		print!("24");
	} else if a == 27 && b == 4 {
		print!("23");
	} else if a == 27 && b == 5 {
		print!("22");
	} else if a == 27 && b == 6 {
		print!("21");
	} else if a == 27 && b == 7 {
		print!("20");
	} else if a == 27 && b == 8 {
		print!("19");
	} else if a == 27 && b == 9 {
		print!("18");
	} else if a == 27 && b == 10 {
		print!("17");
	} else if a == 27 && b == 11 {
		print!("16");
	} else if a == 27 && b == 12 {
		print!("15");
	} else if a == 27 && b == 13 {
		print!("14");
	} else if a == 27 && b == 14 {
		print!("13");
	} else if a == 27 && b == 15 {
		print!("12");
	} else if a == 27 && b == 16 {
		print!("11");
	} else if a == 27 && b == 17 {
		print!("10");
	} else if a == 27 && b == 18 {
		print!("9");
	} else if a == 27 && b == 19 {
		print!("8");
	} else if a == 27 && b == 20 {
		print!("7");
	} else if a == 27 && b == 21 {
		print!("6");
	} else if a == 27 && b == 22 {
		print!("5");
	} else if a == 27 && b == 23 {
		print!("4");
	} else if a == 27 && b == 24 {
		print!("3");
	} else if a == 27 && b == 25 {
		print!("2");
	} else if a == 27 && b == 26 {
		print!("1");
	} else if a == 27 && b == 27 {
		print!("0");
	} else if a == 27 && b == 28 {
		print!("-1");
	} else if a == 27 && b == 29 {
		print!("-2");
	} else if a == 27 && b == 30 {
		print!("-3");
	} else if a == 27 && b == 31 {
		print!("-4");
	} else if a == 27 && b == 32 {
		print!("-5");
	} else if a == 27 && b == 33 {
		print!("-6");
	} else if a == 27 && b == 34 {
		print!("-7");
	} else if a == 27 && b == 35 {
		print!("-8");
	} else if a == 27 && b == 36 {
		print!("-9");
	} else if a == 27 && b == 37 {
		print!("-10");
	} else if a == 27 && b == 38 {
		print!("-11");
	} else if a == 27 && b == 39 {
		print!("-12");
	} else if a == 27 && b == 40 {
		print!("-13");
	} else if a == 27 && b == 41 {
		print!("-14");
	} else if a == 27 && b == 42 {
		print!("-15");
	} else if a == 27 && b == 43 {
		print!("-16");
	} else if a == 27 && b == 44 {
		print!("-17");
	} else if a == 27 && b == 45 {
		print!("-18");
	} else if a == 27 && b == 46 {
		print!("-19");
	} else if a == 27 && b == 47 {
		print!("-20");
	} else if a == 27 && b == 48 {
		print!("-21");
	} else if a == 27 && b == 49 {
		print!("-22");
	} else if a == 27 && b == 50 {
		print!("-23");
	} else if a == 28 && b == 0 {
		print!("28");
	} else if a == 28 && b == 1 {
		print!("27");
	} else if a == 28 && b == 2 {
		print!("26");
	} else if a == 28 && b == 3 {
		print!("25");
	} else if a == 28 && b == 4 {
		print!("24");
	} else if a == 28 && b == 5 {
		print!("23");
	} else if a == 28 && b == 6 {
		print!("22");
	} else if a == 28 && b == 7 {
		print!("21");
	} else if a == 28 && b == 8 {
		print!("20");
	} else if a == 28 && b == 9 {
		print!("19");
	} else if a == 28 && b == 10 {
		print!("18");
	} else if a == 28 && b == 11 {
		print!("17");
	} else if a == 28 && b == 12 {
		print!("16");
	} else if a == 28 && b == 13 {
		print!("15");
	} else if a == 28 && b == 14 {
		print!("14");
	} else if a == 28 && b == 15 {
		print!("13");
	} else if a == 28 && b == 16 {
		print!("12");
	} else if a == 28 && b == 17 {
		print!("11");
	} else if a == 28 && b == 18 {
		print!("10");
	} else if a == 28 && b == 19 {
		print!("9");
	} else if a == 28 && b == 20 {
		print!("8");
	} else if a == 28 && b == 21 {
		print!("7");
	} else if a == 28 && b == 22 {
		print!("6");
	} else if a == 28 && b == 23 {
		print!("5");
	} else if a == 28 && b == 24 {
		print!("4");
	} else if a == 28 && b == 25 {
		print!("3");
	} else if a == 28 && b == 26 {
		print!("2");
	} else if a == 28 && b == 27 {
		print!("1");
	} else if a == 28 && b == 28 {
		print!("0");
	} else if a == 28 && b == 29 {
		print!("-1");
	} else if a == 28 && b == 30 {
		print!("-2");
	} else if a == 28 && b == 31 {
		print!("-3");
	} else if a == 28 && b == 32 {
		print!("-4");
	} else if a == 28 && b == 33 {
		print!("-5");
	} else if a == 28 && b == 34 {
		print!("-6");
	} else if a == 28 && b == 35 {
		print!("-7");
	} else if a == 28 && b == 36 {
		print!("-8");
	} else if a == 28 && b == 37 {
		print!("-9");
	} else if a == 28 && b == 38 {
		print!("-10");
	} else if a == 28 && b == 39 {
		print!("-11");
	} else if a == 28 && b == 40 {
		print!("-12");
	} else if a == 28 && b == 41 {
		print!("-13");
	} else if a == 28 && b == 42 {
		print!("-14");
	} else if a == 28 && b == 43 {
		print!("-15");
	} else if a == 28 && b == 44 {
		print!("-16");
	} else if a == 28 && b == 45 {
		print!("-17");
	} else if a == 28 && b == 46 {
		print!("-18");
	} else if a == 28 && b == 47 {
		print!("-19");
	} else if a == 28 && b == 48 {
		print!("-20");
	} else if a == 28 && b == 49 {
		print!("-21");
	} else if a == 28 && b == 50 {
		print!("-22");
	} else if a == 29 && b == 0 {
		print!("29");
	} else if a == 29 && b == 1 {
		print!("28");
	} else if a == 29 && b == 2 {
		print!("27");
	} else if a == 29 && b == 3 {
		print!("26");
	} else if a == 29 && b == 4 {
		print!("25");
	} else if a == 29 && b == 5 {
		print!("24");
	} else if a == 29 && b == 6 {
		print!("23");
	} else if a == 29 && b == 7 {
		print!("22");
	} else if a == 29 && b == 8 {
		print!("21");
	} else if a == 29 && b == 9 {
		print!("20");
	} else if a == 29 && b == 10 {
		print!("19");
	} else if a == 29 && b == 11 {
		print!("18");
	} else if a == 29 && b == 12 {
		print!("17");
	} else if a == 29 && b == 13 {
		print!("16");
	} else if a == 29 && b == 14 {
		print!("15");
	} else if a == 29 && b == 15 {
		print!("14");
	} else if a == 29 && b == 16 {
		print!("13");
	} else if a == 29 && b == 17 {
		print!("12");
	} else if a == 29 && b == 18 {
		print!("11");
	} else if a == 29 && b == 19 {
		print!("10");
	} else if a == 29 && b == 20 {
		print!("9");
	} else if a == 29 && b == 21 {
		print!("8");
	} else if a == 29 && b == 22 {
		print!("7");
	} else if a == 29 && b == 23 {
		print!("6");
	} else if a == 29 && b == 24 {
		print!("5");
	} else if a == 29 && b == 25 {
		print!("4");
	} else if a == 29 && b == 26 {
		print!("3");
	} else if a == 29 && b == 27 {
		print!("2");
	} else if a == 29 && b == 28 {
		print!("1");
	} else if a == 29 && b == 29 {
		print!("0");
	} else if a == 29 && b == 30 {
		print!("-1");
	} else if a == 29 && b == 31 {
		print!("-2");
	} else if a == 29 && b == 32 {
		print!("-3");
	} else if a == 29 && b == 33 {
		print!("-4");
	} else if a == 29 && b == 34 {
		print!("-5");
	} else if a == 29 && b == 35 {
		print!("-6");
	} else if a == 29 && b == 36 {
		print!("-7");
	} else if a == 29 && b == 37 {
		print!("-8");
	} else if a == 29 && b == 38 {
		print!("-9");
	} else if a == 29 && b == 39 {
		print!("-10");
	} else if a == 29 && b == 40 {
		print!("-11");
	} else if a == 29 && b == 41 {
		print!("-12");
	} else if a == 29 && b == 42 {
		print!("-13");
	} else if a == 29 && b == 43 {
		print!("-14");
	} else if a == 29 && b == 44 {
		print!("-15");
	} else if a == 29 && b == 45 {
		print!("-16");
	} else if a == 29 && b == 46 {
		print!("-17");
	} else if a == 29 && b == 47 {
		print!("-18");
	} else if a == 29 && b == 48 {
		print!("-19");
	} else if a == 29 && b == 49 {
		print!("-20");
	} else if a == 29 && b == 50 {
		print!("-21");
	} else if a == 30 && b == 0 {
		print!("30");
	} else if a == 30 && b == 1 {
		print!("29");
	} else if a == 30 && b == 2 {
		print!("28");
	} else if a == 30 && b == 3 {
		print!("27");
	} else if a == 30 && b == 4 {
		print!("26");
	} else if a == 30 && b == 5 {
		print!("25");
	} else if a == 30 && b == 6 {
		print!("24");
	} else if a == 30 && b == 7 {
		print!("23");
	} else if a == 30 && b == 8 {
		print!("22");
	} else if a == 30 && b == 9 {
		print!("21");
	} else if a == 30 && b == 10 {
		print!("20");
	} else if a == 30 && b == 11 {
		print!("19");
	} else if a == 30 && b == 12 {
		print!("18");
	} else if a == 30 && b == 13 {
		print!("17");
	} else if a == 30 && b == 14 {
		print!("16");
	} else if a == 30 && b == 15 {
		print!("15");
	} else if a == 30 && b == 16 {
		print!("14");
	} else if a == 30 && b == 17 {
		print!("13");
	} else if a == 30 && b == 18 {
		print!("12");
	} else if a == 30 && b == 19 {
		print!("11");
	} else if a == 30 && b == 20 {
		print!("10");
	} else if a == 30 && b == 21 {
		print!("9");
	} else if a == 30 && b == 22 {
		print!("8");
	} else if a == 30 && b == 23 {
		print!("7");
	} else if a == 30 && b == 24 {
		print!("6");
	} else if a == 30 && b == 25 {
		print!("5");
	} else if a == 30 && b == 26 {
		print!("4");
	} else if a == 30 && b == 27 {
		print!("3");
	} else if a == 30 && b == 28 {
		print!("2");
	} else if a == 30 && b == 29 {
		print!("1");
	} else if a == 30 && b == 30 {
		print!("0");
	} else if a == 30 && b == 31 {
		print!("-1");
	} else if a == 30 && b == 32 {
		print!("-2");
	} else if a == 30 && b == 33 {
		print!("-3");
	} else if a == 30 && b == 34 {
		print!("-4");
	} else if a == 30 && b == 35 {
		print!("-5");
	} else if a == 30 && b == 36 {
		print!("-6");
	} else if a == 30 && b == 37 {
		print!("-7");
	} else if a == 30 && b == 38 {
		print!("-8");
	} else if a == 30 && b == 39 {
		print!("-9");
	} else if a == 30 && b == 40 {
		print!("-10");
	} else if a == 30 && b == 41 {
		print!("-11");
	} else if a == 30 && b == 42 {
		print!("-12");
	} else if a == 30 && b == 43 {
		print!("-13");
	} else if a == 30 && b == 44 {
		print!("-14");
	} else if a == 30 && b == 45 {
		print!("-15");
	} else if a == 30 && b == 46 {
		print!("-16");
	} else if a == 30 && b == 47 {
		print!("-17");
	} else if a == 30 && b == 48 {
		print!("-18");
	} else if a == 30 && b == 49 {
		print!("-19");
	} else if a == 30 && b == 50 {
		print!("-20");
	} else if a == 31 && b == 0 {
		print!("31");
	} else if a == 31 && b == 1 {
		print!("30");
	} else if a == 31 && b == 2 {
		print!("29");
	} else if a == 31 && b == 3 {
		print!("28");
	} else if a == 31 && b == 4 {
		print!("27");
	} else if a == 31 && b == 5 {
		print!("26");
	} else if a == 31 && b == 6 {
		print!("25");
	} else if a == 31 && b == 7 {
		print!("24");
	} else if a == 31 && b == 8 {
		print!("23");
	} else if a == 31 && b == 9 {
		print!("22");
	} else if a == 31 && b == 10 {
		print!("21");
	} else if a == 31 && b == 11 {
		print!("20");
	} else if a == 31 && b == 12 {
		print!("19");
	} else if a == 31 && b == 13 {
		print!("18");
	} else if a == 31 && b == 14 {
		print!("17");
	} else if a == 31 && b == 15 {
		print!("16");
	} else if a == 31 && b == 16 {
		print!("15");
	} else if a == 31 && b == 17 {
		print!("14");
	} else if a == 31 && b == 18 {
		print!("13");
	} else if a == 31 && b == 19 {
		print!("12");
	} else if a == 31 && b == 20 {
		print!("11");
	} else if a == 31 && b == 21 {
		print!("10");
	} else if a == 31 && b == 22 {
		print!("9");
	} else if a == 31 && b == 23 {
		print!("8");
	} else if a == 31 && b == 24 {
		print!("7");
	} else if a == 31 && b == 25 {
		print!("6");
	} else if a == 31 && b == 26 {
		print!("5");
	} else if a == 31 && b == 27 {
		print!("4");
	} else if a == 31 && b == 28 {
		print!("3");
	} else if a == 31 && b == 29 {
		print!("2");
	} else if a == 31 && b == 30 {
		print!("1");
	} else if a == 31 && b == 31 {
		print!("0");
	} else if a == 31 && b == 32 {
		print!("-1");
	} else if a == 31 && b == 33 {
		print!("-2");
	} else if a == 31 && b == 34 {
		print!("-3");
	} else if a == 31 && b == 35 {
		print!("-4");
	} else if a == 31 && b == 36 {
		print!("-5");
	} else if a == 31 && b == 37 {
		print!("-6");
	} else if a == 31 && b == 38 {
		print!("-7");
	} else if a == 31 && b == 39 {
		print!("-8");
	} else if a == 31 && b == 40 {
		print!("-9");
	} else if a == 31 && b == 41 {
		print!("-10");
	} else if a == 31 && b == 42 {
		print!("-11");
	} else if a == 31 && b == 43 {
		print!("-12");
	} else if a == 31 && b == 44 {
		print!("-13");
	} else if a == 31 && b == 45 {
		print!("-14");
	} else if a == 31 && b == 46 {
		print!("-15");
	} else if a == 31 && b == 47 {
		print!("-16");
	} else if a == 31 && b == 48 {
		print!("-17");
	} else if a == 31 && b == 49 {
		print!("-18");
	} else if a == 31 && b == 50 {
		print!("-19");
	} else if a == 32 && b == 0 {
		print!("32");
	} else if a == 32 && b == 1 {
		print!("31");
	} else if a == 32 && b == 2 {
		print!("30");
	} else if a == 32 && b == 3 {
		print!("29");
	} else if a == 32 && b == 4 {
		print!("28");
	} else if a == 32 && b == 5 {
		print!("27");
	} else if a == 32 && b == 6 {
		print!("26");
	} else if a == 32 && b == 7 {
		print!("25");
	} else if a == 32 && b == 8 {
		print!("24");
	} else if a == 32 && b == 9 {
		print!("23");
	} else if a == 32 && b == 10 {
		print!("22");
	} else if a == 32 && b == 11 {
		print!("21");
	} else if a == 32 && b == 12 {
		print!("20");
	} else if a == 32 && b == 13 {
		print!("19");
	} else if a == 32 && b == 14 {
		print!("18");
	} else if a == 32 && b == 15 {
		print!("17");
	} else if a == 32 && b == 16 {
		print!("16");
	} else if a == 32 && b == 17 {
		print!("15");
	} else if a == 32 && b == 18 {
		print!("14");
	} else if a == 32 && b == 19 {
		print!("13");
	} else if a == 32 && b == 20 {
		print!("12");
	} else if a == 32 && b == 21 {
		print!("11");
	} else if a == 32 && b == 22 {
		print!("10");
	} else if a == 32 && b == 23 {
		print!("9");
	} else if a == 32 && b == 24 {
		print!("8");
	} else if a == 32 && b == 25 {
		print!("7");
	} else if a == 32 && b == 26 {
		print!("6");
	} else if a == 32 && b == 27 {
		print!("5");
	} else if a == 32 && b == 28 {
		print!("4");
	} else if a == 32 && b == 29 {
		print!("3");
	} else if a == 32 && b == 30 {
		print!("2");
	} else if a == 32 && b == 31 {
		print!("1");
	} else if a == 32 && b == 32 {
		print!("0");
	} else if a == 32 && b == 33 {
		print!("-1");
	} else if a == 32 && b == 34 {
		print!("-2");
	} else if a == 32 && b == 35 {
		print!("-3");
	} else if a == 32 && b == 36 {
		print!("-4");
	} else if a == 32 && b == 37 {
		print!("-5");
	} else if a == 32 && b == 38 {
		print!("-6");
	} else if a == 32 && b == 39 {
		print!("-7");
	} else if a == 32 && b == 40 {
		print!("-8");
	} else if a == 32 && b == 41 {
		print!("-9");
	} else if a == 32 && b == 42 {
		print!("-10");
	} else if a == 32 && b == 43 {
		print!("-11");
	} else if a == 32 && b == 44 {
		print!("-12");
	} else if a == 32 && b == 45 {
		print!("-13");
	} else if a == 32 && b == 46 {
		print!("-14");
	} else if a == 32 && b == 47 {
		print!("-15");
	} else if a == 32 && b == 48 {
		print!("-16");
	} else if a == 32 && b == 49 {
		print!("-17");
	} else if a == 32 && b == 50 {
		print!("-18");
	} else if a == 33 && b == 0 {
		print!("33");
	} else if a == 33 && b == 1 {
		print!("32");
	} else if a == 33 && b == 2 {
		print!("31");
	} else if a == 33 && b == 3 {
		print!("30");
	} else if a == 33 && b == 4 {
		print!("29");
	} else if a == 33 && b == 5 {
		print!("28");
	} else if a == 33 && b == 6 {
		print!("27");
	} else if a == 33 && b == 7 {
		print!("26");
	} else if a == 33 && b == 8 {
		print!("25");
	} else if a == 33 && b == 9 {
		print!("24");
	} else if a == 33 && b == 10 {
		print!("23");
	} else if a == 33 && b == 11 {
		print!("22");
	} else if a == 33 && b == 12 {
		print!("21");
	} else if a == 33 && b == 13 {
		print!("20");
	} else if a == 33 && b == 14 {
		print!("19");
	} else if a == 33 && b == 15 {
		print!("18");
	} else if a == 33 && b == 16 {
		print!("17");
	} else if a == 33 && b == 17 {
		print!("16");
	} else if a == 33 && b == 18 {
		print!("15");
	} else if a == 33 && b == 19 {
		print!("14");
	} else if a == 33 && b == 20 {
		print!("13");
	} else if a == 33 && b == 21 {
		print!("12");
	} else if a == 33 && b == 22 {
		print!("11");
	} else if a == 33 && b == 23 {
		print!("10");
	} else if a == 33 && b == 24 {
		print!("9");
	} else if a == 33 && b == 25 {
		print!("8");
	} else if a == 33 && b == 26 {
		print!("7");
	} else if a == 33 && b == 27 {
		print!("6");
	} else if a == 33 && b == 28 {
		print!("5");
	} else if a == 33 && b == 29 {
		print!("4");
	} else if a == 33 && b == 30 {
		print!("3");
	} else if a == 33 && b == 31 {
		print!("2");
	} else if a == 33 && b == 32 {
		print!("1");
	} else if a == 33 && b == 33 {
		print!("0");
	} else if a == 33 && b == 34 {
		print!("-1");
	} else if a == 33 && b == 35 {
		print!("-2");
	} else if a == 33 && b == 36 {
		print!("-3");
	} else if a == 33 && b == 37 {
		print!("-4");
	} else if a == 33 && b == 38 {
		print!("-5");
	} else if a == 33 && b == 39 {
		print!("-6");
	} else if a == 33 && b == 40 {
		print!("-7");
	} else if a == 33 && b == 41 {
		print!("-8");
	} else if a == 33 && b == 42 {
		print!("-9");
	} else if a == 33 && b == 43 {
		print!("-10");
	} else if a == 33 && b == 44 {
		print!("-11");
	} else if a == 33 && b == 45 {
		print!("-12");
	} else if a == 33 && b == 46 {
		print!("-13");
	} else if a == 33 && b == 47 {
		print!("-14");
	} else if a == 33 && b == 48 {
		print!("-15");
	} else if a == 33 && b == 49 {
		print!("-16");
	} else if a == 33 && b == 50 {
		print!("-17");
	} else if a == 34 && b == 0 {
		print!("34");
	} else if a == 34 && b == 1 {
		print!("33");
	} else if a == 34 && b == 2 {
		print!("32");
	} else if a == 34 && b == 3 {
		print!("31");
	} else if a == 34 && b == 4 {
		print!("30");
	} else if a == 34 && b == 5 {
		print!("29");
	} else if a == 34 && b == 6 {
		print!("28");
	} else if a == 34 && b == 7 {
		print!("27");
	} else if a == 34 && b == 8 {
		print!("26");
	} else if a == 34 && b == 9 {
		print!("25");
	} else if a == 34 && b == 10 {
		print!("24");
	} else if a == 34 && b == 11 {
		print!("23");
	} else if a == 34 && b == 12 {
		print!("22");
	} else if a == 34 && b == 13 {
		print!("21");
	} else if a == 34 && b == 14 {
		print!("20");
	} else if a == 34 && b == 15 {
		print!("19");
	} else if a == 34 && b == 16 {
		print!("18");
	} else if a == 34 && b == 17 {
		print!("17");
	} else if a == 34 && b == 18 {
		print!("16");
	} else if a == 34 && b == 19 {
		print!("15");
	} else if a == 34 && b == 20 {
		print!("14");
	} else if a == 34 && b == 21 {
		print!("13");
	} else if a == 34 && b == 22 {
		print!("12");
	} else if a == 34 && b == 23 {
		print!("11");
	} else if a == 34 && b == 24 {
		print!("10");
	} else if a == 34 && b == 25 {
		print!("9");
	} else if a == 34 && b == 26 {
		print!("8");
	} else if a == 34 && b == 27 {
		print!("7");
	} else if a == 34 && b == 28 {
		print!("6");
	} else if a == 34 && b == 29 {
		print!("5");
	} else if a == 34 && b == 30 {
		print!("4");
	} else if a == 34 && b == 31 {
		print!("3");
	} else if a == 34 && b == 32 {
		print!("2");
	} else if a == 34 && b == 33 {
		print!("1");
	} else if a == 34 && b == 34 {
		print!("0");
	} else if a == 34 && b == 35 {
		print!("-1");
	} else if a == 34 && b == 36 {
		print!("-2");
	} else if a == 34 && b == 37 {
		print!("-3");
	} else if a == 34 && b == 38 {
		print!("-4");
	} else if a == 34 && b == 39 {
		print!("-5");
	} else if a == 34 && b == 40 {
		print!("-6");
	} else if a == 34 && b == 41 {
		print!("-7");
	} else if a == 34 && b == 42 {
		print!("-8");
	} else if a == 34 && b == 43 {
		print!("-9");
	} else if a == 34 && b == 44 {
		print!("-10");
	} else if a == 34 && b == 45 {
		print!("-11");
	} else if a == 34 && b == 46 {
		print!("-12");
	} else if a == 34 && b == 47 {
		print!("-13");
	} else if a == 34 && b == 48 {
		print!("-14");
	} else if a == 34 && b == 49 {
		print!("-15");
	} else if a == 34 && b == 50 {
		print!("-16");
	} else if a == 35 && b == 0 {
		print!("35");
	} else if a == 35 && b == 1 {
		print!("34");
	} else if a == 35 && b == 2 {
		print!("33");
	} else if a == 35 && b == 3 {
		print!("32");
	} else if a == 35 && b == 4 {
		print!("31");
	} else if a == 35 && b == 5 {
		print!("30");
	} else if a == 35 && b == 6 {
		print!("29");
	} else if a == 35 && b == 7 {
		print!("28");
	} else if a == 35 && b == 8 {
		print!("27");
	} else if a == 35 && b == 9 {
		print!("26");
	} else if a == 35 && b == 10 {
		print!("25");
	} else if a == 35 && b == 11 {
		print!("24");
	} else if a == 35 && b == 12 {
		print!("23");
	} else if a == 35 && b == 13 {
		print!("22");
	} else if a == 35 && b == 14 {
		print!("21");
	} else if a == 35 && b == 15 {
		print!("20");
	} else if a == 35 && b == 16 {
		print!("19");
	} else if a == 35 && b == 17 {
		print!("18");
	} else if a == 35 && b == 18 {
		print!("17");
	} else if a == 35 && b == 19 {
		print!("16");
	} else if a == 35 && b == 20 {
		print!("15");
	} else if a == 35 && b == 21 {
		print!("14");
	} else if a == 35 && b == 22 {
		print!("13");
	} else if a == 35 && b == 23 {
		print!("12");
	} else if a == 35 && b == 24 {
		print!("11");
	} else if a == 35 && b == 25 {
		print!("10");
	} else if a == 35 && b == 26 {
		print!("9");
	} else if a == 35 && b == 27 {
		print!("8");
	} else if a == 35 && b == 28 {
		print!("7");
	} else if a == 35 && b == 29 {
		print!("6");
	} else if a == 35 && b == 30 {
		print!("5");
	} else if a == 35 && b == 31 {
		print!("4");
	} else if a == 35 && b == 32 {
		print!("3");
	} else if a == 35 && b == 33 {
		print!("2");
	} else if a == 35 && b == 34 {
		print!("1");
	} else if a == 35 && b == 35 {
		print!("0");
	} else if a == 35 && b == 36 {
		print!("-1");
	} else if a == 35 && b == 37 {
		print!("-2");
	} else if a == 35 && b == 38 {
		print!("-3");
	} else if a == 35 && b == 39 {
		print!("-4");
	} else if a == 35 && b == 40 {
		print!("-5");
	} else if a == 35 && b == 41 {
		print!("-6");
	} else if a == 35 && b == 42 {
		print!("-7");
	} else if a == 35 && b == 43 {
		print!("-8");
	} else if a == 35 && b == 44 {
		print!("-9");
	} else if a == 35 && b == 45 {
		print!("-10");
	} else if a == 35 && b == 46 {
		print!("-11");
	} else if a == 35 && b == 47 {
		print!("-12");
	} else if a == 35 && b == 48 {
		print!("-13");
	} else if a == 35 && b == 49 {
		print!("-14");
	} else if a == 35 && b == 50 {
		print!("-15");
	} else if a == 36 && b == 0 {
		print!("36");
	} else if a == 36 && b == 1 {
		print!("35");
	} else if a == 36 && b == 2 {
		print!("34");
	} else if a == 36 && b == 3 {
		print!("33");
	} else if a == 36 && b == 4 {
		print!("32");
	} else if a == 36 && b == 5 {
		print!("31");
	} else if a == 36 && b == 6 {
		print!("30");
	} else if a == 36 && b == 7 {
		print!("29");
	} else if a == 36 && b == 8 {
		print!("28");
	} else if a == 36 && b == 9 {
		print!("27");
	} else if a == 36 && b == 10 {
		print!("26");
	} else if a == 36 && b == 11 {
		print!("25");
	} else if a == 36 && b == 12 {
		print!("24");
	} else if a == 36 && b == 13 {
		print!("23");
	} else if a == 36 && b == 14 {
		print!("22");
	} else if a == 36 && b == 15 {
		print!("21");
	} else if a == 36 && b == 16 {
		print!("20");
	} else if a == 36 && b == 17 {
		print!("19");
	} else if a == 36 && b == 18 {
		print!("18");
	} else if a == 36 && b == 19 {
		print!("17");
	} else if a == 36 && b == 20 {
		print!("16");
	} else if a == 36 && b == 21 {
		print!("15");
	} else if a == 36 && b == 22 {
		print!("14");
	} else if a == 36 && b == 23 {
		print!("13");
	} else if a == 36 && b == 24 {
		print!("12");
	} else if a == 36 && b == 25 {
		print!("11");
	} else if a == 36 && b == 26 {
		print!("10");
	} else if a == 36 && b == 27 {
		print!("9");
	} else if a == 36 && b == 28 {
		print!("8");
	} else if a == 36 && b == 29 {
		print!("7");
	} else if a == 36 && b == 30 {
		print!("6");
	} else if a == 36 && b == 31 {
		print!("5");
	} else if a == 36 && b == 32 {
		print!("4");
	} else if a == 36 && b == 33 {
		print!("3");
	} else if a == 36 && b == 34 {
		print!("2");
	} else if a == 36 && b == 35 {
		print!("1");
	} else if a == 36 && b == 36 {
		print!("0");
	} else if a == 36 && b == 37 {
		print!("-1");
	} else if a == 36 && b == 38 {
		print!("-2");
	} else if a == 36 && b == 39 {
		print!("-3");
	} else if a == 36 && b == 40 {
		print!("-4");
	} else if a == 36 && b == 41 {
		print!("-5");
	} else if a == 36 && b == 42 {
		print!("-6");
	} else if a == 36 && b == 43 {
		print!("-7");
	} else if a == 36 && b == 44 {
		print!("-8");
	} else if a == 36 && b == 45 {
		print!("-9");
	} else if a == 36 && b == 46 {
		print!("-10");
	} else if a == 36 && b == 47 {
		print!("-11");
	} else if a == 36 && b == 48 {
		print!("-12");
	} else if a == 36 && b == 49 {
		print!("-13");
	} else if a == 36 && b == 50 {
		print!("-14");
	} else if a == 37 && b == 0 {
		print!("37");
	} else if a == 37 && b == 1 {
		print!("36");
	} else if a == 37 && b == 2 {
		print!("35");
	} else if a == 37 && b == 3 {
		print!("34");
	} else if a == 37 && b == 4 {
		print!("33");
	} else if a == 37 && b == 5 {
		print!("32");
	} else if a == 37 && b == 6 {
		print!("31");
	} else if a == 37 && b == 7 {
		print!("30");
	} else if a == 37 && b == 8 {
		print!("29");
	} else if a == 37 && b == 9 {
		print!("28");
	} else if a == 37 && b == 10 {
		print!("27");
	} else if a == 37 && b == 11 {
		print!("26");
	} else if a == 37 && b == 12 {
		print!("25");
	} else if a == 37 && b == 13 {
		print!("24");
	} else if a == 37 && b == 14 {
		print!("23");
	} else if a == 37 && b == 15 {
		print!("22");
	} else if a == 37 && b == 16 {
		print!("21");
	} else if a == 37 && b == 17 {
		print!("20");
	} else if a == 37 && b == 18 {
		print!("19");
	} else if a == 37 && b == 19 {
		print!("18");
	} else if a == 37 && b == 20 {
		print!("17");
	} else if a == 37 && b == 21 {
		print!("16");
	} else if a == 37 && b == 22 {
		print!("15");
	} else if a == 37 && b == 23 {
		print!("14");
	} else if a == 37 && b == 24 {
		print!("13");
	} else if a == 37 && b == 25 {
		print!("12");
	} else if a == 37 && b == 26 {
		print!("11");
	} else if a == 37 && b == 27 {
		print!("10");
	} else if a == 37 && b == 28 {
		print!("9");
	} else if a == 37 && b == 29 {
		print!("8");
	} else if a == 37 && b == 30 {
		print!("7");
	} else if a == 37 && b == 31 {
		print!("6");
	} else if a == 37 && b == 32 {
		print!("5");
	} else if a == 37 && b == 33 {
		print!("4");
	} else if a == 37 && b == 34 {
		print!("3");
	} else if a == 37 && b == 35 {
		print!("2");
	} else if a == 37 && b == 36 {
		print!("1");
	} else if a == 37 && b == 37 {
		print!("0");
	} else if a == 37 && b == 38 {
		print!("-1");
	} else if a == 37 && b == 39 {
		print!("-2");
	} else if a == 37 && b == 40 {
		print!("-3");
	} else if a == 37 && b == 41 {
		print!("-4");
	} else if a == 37 && b == 42 {
		print!("-5");
	} else if a == 37 && b == 43 {
		print!("-6");
	} else if a == 37 && b == 44 {
		print!("-7");
	} else if a == 37 && b == 45 {
		print!("-8");
	} else if a == 37 && b == 46 {
		print!("-9");
	} else if a == 37 && b == 47 {
		print!("-10");
	} else if a == 37 && b == 48 {
		print!("-11");
	} else if a == 37 && b == 49 {
		print!("-12");
	} else if a == 37 && b == 50 {
		print!("-13");
	} else if a == 38 && b == 0 {
		print!("38");
	} else if a == 38 && b == 1 {
		print!("37");
	} else if a == 38 && b == 2 {
		print!("36");
	} else if a == 38 && b == 3 {
		print!("35");
	} else if a == 38 && b == 4 {
		print!("34");
	} else if a == 38 && b == 5 {
		print!("33");
	} else if a == 38 && b == 6 {
		print!("32");
	} else if a == 38 && b == 7 {
		print!("31");
	} else if a == 38 && b == 8 {
		print!("30");
	} else if a == 38 && b == 9 {
		print!("29");
	} else if a == 38 && b == 10 {
		print!("28");
	} else if a == 38 && b == 11 {
		print!("27");
	} else if a == 38 && b == 12 {
		print!("26");
	} else if a == 38 && b == 13 {
		print!("25");
	} else if a == 38 && b == 14 {
		print!("24");
	} else if a == 38 && b == 15 {
		print!("23");
	} else if a == 38 && b == 16 {
		print!("22");
	} else if a == 38 && b == 17 {
		print!("21");
	} else if a == 38 && b == 18 {
		print!("20");
	} else if a == 38 && b == 19 {
		print!("19");
	} else if a == 38 && b == 20 {
		print!("18");
	} else if a == 38 && b == 21 {
		print!("17");
	} else if a == 38 && b == 22 {
		print!("16");
	} else if a == 38 && b == 23 {
		print!("15");
	} else if a == 38 && b == 24 {
		print!("14");
	} else if a == 38 && b == 25 {
		print!("13");
	} else if a == 38 && b == 26 {
		print!("12");
	} else if a == 38 && b == 27 {
		print!("11");
	} else if a == 38 && b == 28 {
		print!("10");
	} else if a == 38 && b == 29 {
		print!("9");
	} else if a == 38 && b == 30 {
		print!("8");
	} else if a == 38 && b == 31 {
		print!("7");
	} else if a == 38 && b == 32 {
		print!("6");
	} else if a == 38 && b == 33 {
		print!("5");
	} else if a == 38 && b == 34 {
		print!("4");
	} else if a == 38 && b == 35 {
		print!("3");
	} else if a == 38 && b == 36 {
		print!("2");
	} else if a == 38 && b == 37 {
		print!("1");
	} else if a == 38 && b == 38 {
		print!("0");
	} else if a == 38 && b == 39 {
		print!("-1");
	} else if a == 38 && b == 40 {
		print!("-2");
	} else if a == 38 && b == 41 {
		print!("-3");
	} else if a == 38 && b == 42 {
		print!("-4");
	} else if a == 38 && b == 43 {
		print!("-5");
	} else if a == 38 && b == 44 {
		print!("-6");
	} else if a == 38 && b == 45 {
		print!("-7");
	} else if a == 38 && b == 46 {
		print!("-8");
	} else if a == 38 && b == 47 {
		print!("-9");
	} else if a == 38 && b == 48 {
		print!("-10");
	} else if a == 38 && b == 49 {
		print!("-11");
	} else if a == 38 && b == 50 {
		print!("-12");
	} else if a == 39 && b == 0 {
		print!("39");
	} else if a == 39 && b == 1 {
		print!("38");
	} else if a == 39 && b == 2 {
		print!("37");
	} else if a == 39 && b == 3 {
		print!("36");
	} else if a == 39 && b == 4 {
		print!("35");
	} else if a == 39 && b == 5 {
		print!("34");
	} else if a == 39 && b == 6 {
		print!("33");
	} else if a == 39 && b == 7 {
		print!("32");
	} else if a == 39 && b == 8 {
		print!("31");
	} else if a == 39 && b == 9 {
		print!("30");
	} else if a == 39 && b == 10 {
		print!("29");
	} else if a == 39 && b == 11 {
		print!("28");
	} else if a == 39 && b == 12 {
		print!("27");
	} else if a == 39 && b == 13 {
		print!("26");
	} else if a == 39 && b == 14 {
		print!("25");
	} else if a == 39 && b == 15 {
		print!("24");
	} else if a == 39 && b == 16 {
		print!("23");
	} else if a == 39 && b == 17 {
		print!("22");
	} else if a == 39 && b == 18 {
		print!("21");
	} else if a == 39 && b == 19 {
		print!("20");
	} else if a == 39 && b == 20 {
		print!("19");
	} else if a == 39 && b == 21 {
		print!("18");
	} else if a == 39 && b == 22 {
		print!("17");
	} else if a == 39 && b == 23 {
		print!("16");
	} else if a == 39 && b == 24 {
		print!("15");
	} else if a == 39 && b == 25 {
		print!("14");
	} else if a == 39 && b == 26 {
		print!("13");
	} else if a == 39 && b == 27 {
		print!("12");
	} else if a == 39 && b == 28 {
		print!("11");
	} else if a == 39 && b == 29 {
		print!("10");
	} else if a == 39 && b == 30 {
		print!("9");
	} else if a == 39 && b == 31 {
		print!("8");
	} else if a == 39 && b == 32 {
		print!("7");
	} else if a == 39 && b == 33 {
		print!("6");
	} else if a == 39 && b == 34 {
		print!("5");
	} else if a == 39 && b == 35 {
		print!("4");
	} else if a == 39 && b == 36 {
		print!("3");
	} else if a == 39 && b == 37 {
		print!("2");
	} else if a == 39 && b == 38 {
		print!("1");
	} else if a == 39 && b == 39 {
		print!("0");
	} else if a == 39 && b == 40 {
		print!("-1");
	} else if a == 39 && b == 41 {
		print!("-2");
	} else if a == 39 && b == 42 {
		print!("-3");
	} else if a == 39 && b == 43 {
		print!("-4");
	} else if a == 39 && b == 44 {
		print!("-5");
	} else if a == 39 && b == 45 {
		print!("-6");
	} else if a == 39 && b == 46 {
		print!("-7");
	} else if a == 39 && b == 47 {
		print!("-8");
	} else if a == 39 && b == 48 {
		print!("-9");
	} else if a == 39 && b == 49 {
		print!("-10");
	} else if a == 39 && b == 50 {
		print!("-11");
	} else if a == 40 && b == 0 {
		print!("40");
	} else if a == 40 && b == 1 {
		print!("39");
	} else if a == 40 && b == 2 {
		print!("38");
	} else if a == 40 && b == 3 {
		print!("37");
	} else if a == 40 && b == 4 {
		print!("36");
	} else if a == 40 && b == 5 {
		print!("35");
	} else if a == 40 && b == 6 {
		print!("34");
	} else if a == 40 && b == 7 {
		print!("33");
	} else if a == 40 && b == 8 {
		print!("32");
	} else if a == 40 && b == 9 {
		print!("31");
	} else if a == 40 && b == 10 {
		print!("30");
	} else if a == 40 && b == 11 {
		print!("29");
	} else if a == 40 && b == 12 {
		print!("28");
	} else if a == 40 && b == 13 {
		print!("27");
	} else if a == 40 && b == 14 {
		print!("26");
	} else if a == 40 && b == 15 {
		print!("25");
	} else if a == 40 && b == 16 {
		print!("24");
	} else if a == 40 && b == 17 {
		print!("23");
	} else if a == 40 && b == 18 {
		print!("22");
	} else if a == 40 && b == 19 {
		print!("21");
	} else if a == 40 && b == 20 {
		print!("20");
	} else if a == 40 && b == 21 {
		print!("19");
	} else if a == 40 && b == 22 {
		print!("18");
	} else if a == 40 && b == 23 {
		print!("17");
	} else if a == 40 && b == 24 {
		print!("16");
	} else if a == 40 && b == 25 {
		print!("15");
	} else if a == 40 && b == 26 {
		print!("14");
	} else if a == 40 && b == 27 {
		print!("13");
	} else if a == 40 && b == 28 {
		print!("12");
	} else if a == 40 && b == 29 {
		print!("11");
	} else if a == 40 && b == 30 {
		print!("10");
	} else if a == 40 && b == 31 {
		print!("9");
	} else if a == 40 && b == 32 {
		print!("8");
	} else if a == 40 && b == 33 {
		print!("7");
	} else if a == 40 && b == 34 {
		print!("6");
	} else if a == 40 && b == 35 {
		print!("5");
	} else if a == 40 && b == 36 {
		print!("4");
	} else if a == 40 && b == 37 {
		print!("3");
	} else if a == 40 && b == 38 {
		print!("2");
	} else if a == 40 && b == 39 {
		print!("1");
	} else if a == 40 && b == 40 {
		print!("0");
	} else if a == 40 && b == 41 {
		print!("-1");
	} else if a == 40 && b == 42 {
		print!("-2");
	} else if a == 40 && b == 43 {
		print!("-3");
	} else if a == 40 && b == 44 {
		print!("-4");
	} else if a == 40 && b == 45 {
		print!("-5");
	} else if a == 40 && b == 46 {
		print!("-6");
	} else if a == 40 && b == 47 {
		print!("-7");
	} else if a == 40 && b == 48 {
		print!("-8");
	} else if a == 40 && b == 49 {
		print!("-9");
	} else if a == 40 && b == 50 {
		print!("-10");
	} else if a == 41 && b == 0 {
		print!("41");
	} else if a == 41 && b == 1 {
		print!("40");
	} else if a == 41 && b == 2 {
		print!("39");
	} else if a == 41 && b == 3 {
		print!("38");
	} else if a == 41 && b == 4 {
		print!("37");
	} else if a == 41 && b == 5 {
		print!("36");
	} else if a == 41 && b == 6 {
		print!("35");
	} else if a == 41 && b == 7 {
		print!("34");
	} else if a == 41 && b == 8 {
		print!("33");
	} else if a == 41 && b == 9 {
		print!("32");
	} else if a == 41 && b == 10 {
		print!("31");
	} else if a == 41 && b == 11 {
		print!("30");
	} else if a == 41 && b == 12 {
		print!("29");
	} else if a == 41 && b == 13 {
		print!("28");
	} else if a == 41 && b == 14 {
		print!("27");
	} else if a == 41 && b == 15 {
		print!("26");
	} else if a == 41 && b == 16 {
		print!("25");
	} else if a == 41 && b == 17 {
		print!("24");
	} else if a == 41 && b == 18 {
		print!("23");
	} else if a == 41 && b == 19 {
		print!("22");
	} else if a == 41 && b == 20 {
		print!("21");
	} else if a == 41 && b == 21 {
		print!("20");
	} else if a == 41 && b == 22 {
		print!("19");
	} else if a == 41 && b == 23 {
		print!("18");
	} else if a == 41 && b == 24 {
		print!("17");
	} else if a == 41 && b == 25 {
		print!("16");
	} else if a == 41 && b == 26 {
		print!("15");
	} else if a == 41 && b == 27 {
		print!("14");
	} else if a == 41 && b == 28 {
		print!("13");
	} else if a == 41 && b == 29 {
		print!("12");
	} else if a == 41 && b == 30 {
		print!("11");
	} else if a == 41 && b == 31 {
		print!("10");
	} else if a == 41 && b == 32 {
		print!("9");
	} else if a == 41 && b == 33 {
		print!("8");
	} else if a == 41 && b == 34 {
		print!("7");
	} else if a == 41 && b == 35 {
		print!("6");
	} else if a == 41 && b == 36 {
		print!("5");
	} else if a == 41 && b == 37 {
		print!("4");
	} else if a == 41 && b == 38 {
		print!("3");
	} else if a == 41 && b == 39 {
		print!("2");
	} else if a == 41 && b == 40 {
		print!("1");
	} else if a == 41 && b == 41 {
		print!("0");
	} else if a == 41 && b == 42 {
		print!("-1");
	} else if a == 41 && b == 43 {
		print!("-2");
	} else if a == 41 && b == 44 {
		print!("-3");
	} else if a == 41 && b == 45 {
		print!("-4");
	} else if a == 41 && b == 46 {
		print!("-5");
	} else if a == 41 && b == 47 {
		print!("-6");
	} else if a == 41 && b == 48 {
		print!("-7");
	} else if a == 41 && b == 49 {
		print!("-8");
	} else if a == 41 && b == 50 {
		print!("-9");
	} else if a == 42 && b == 0 {
		print!("42");
	} else if a == 42 && b == 1 {
		print!("41");
	} else if a == 42 && b == 2 {
		print!("40");
	} else if a == 42 && b == 3 {
		print!("39");
	} else if a == 42 && b == 4 {
		print!("38");
	} else if a == 42 && b == 5 {
		print!("37");
	} else if a == 42 && b == 6 {
		print!("36");
	} else if a == 42 && b == 7 {
		print!("35");
	} else if a == 42 && b == 8 {
		print!("34");
	} else if a == 42 && b == 9 {
		print!("33");
	} else if a == 42 && b == 10 {
		print!("32");
	} else if a == 42 && b == 11 {
		print!("31");
	} else if a == 42 && b == 12 {
		print!("30");
	} else if a == 42 && b == 13 {
		print!("29");
	} else if a == 42 && b == 14 {
		print!("28");
	} else if a == 42 && b == 15 {
		print!("27");
	} else if a == 42 && b == 16 {
		print!("26");
	} else if a == 42 && b == 17 {
		print!("25");
	} else if a == 42 && b == 18 {
		print!("24");
	} else if a == 42 && b == 19 {
		print!("23");
	} else if a == 42 && b == 20 {
		print!("22");
	} else if a == 42 && b == 21 {
		print!("21");
	} else if a == 42 && b == 22 {
		print!("20");
	} else if a == 42 && b == 23 {
		print!("19");
	} else if a == 42 && b == 24 {
		print!("18");
	} else if a == 42 && b == 25 {
		print!("17");
	} else if a == 42 && b == 26 {
		print!("16");
	} else if a == 42 && b == 27 {
		print!("15");
	} else if a == 42 && b == 28 {
		print!("14");
	} else if a == 42 && b == 29 {
		print!("13");
	} else if a == 42 && b == 30 {
		print!("12");
	} else if a == 42 && b == 31 {
		print!("11");
	} else if a == 42 && b == 32 {
		print!("10");
	} else if a == 42 && b == 33 {
		print!("9");
	} else if a == 42 && b == 34 {
		print!("8");
	} else if a == 42 && b == 35 {
		print!("7");
	} else if a == 42 && b == 36 {
		print!("6");
	} else if a == 42 && b == 37 {
		print!("5");
	} else if a == 42 && b == 38 {
		print!("4");
	} else if a == 42 && b == 39 {
		print!("3");
	} else if a == 42 && b == 40 {
		print!("2");
	} else if a == 42 && b == 41 {
		print!("1");
	} else if a == 42 && b == 42 {
		print!("0");
	} else if a == 42 && b == 43 {
		print!("-1");
	} else if a == 42 && b == 44 {
		print!("-2");
	} else if a == 42 && b == 45 {
		print!("-3");
	} else if a == 42 && b == 46 {
		print!("-4");
	} else if a == 42 && b == 47 {
		print!("-5");
	} else if a == 42 && b == 48 {
		print!("-6");
	} else if a == 42 && b == 49 {
		print!("-7");
	} else if a == 42 && b == 50 {
		print!("-8");
	} else if a == 43 && b == 0 {
		print!("43");
	} else if a == 43 && b == 1 {
		print!("42");
	} else if a == 43 && b == 2 {
		print!("41");
	} else if a == 43 && b == 3 {
		print!("40");
	} else if a == 43 && b == 4 {
		print!("39");
	} else if a == 43 && b == 5 {
		print!("38");
	} else if a == 43 && b == 6 {
		print!("37");
	} else if a == 43 && b == 7 {
		print!("36");
	} else if a == 43 && b == 8 {
		print!("35");
	} else if a == 43 && b == 9 {
		print!("34");
	} else if a == 43 && b == 10 {
		print!("33");
	} else if a == 43 && b == 11 {
		print!("32");
	} else if a == 43 && b == 12 {
		print!("31");
	} else if a == 43 && b == 13 {
		print!("30");
	} else if a == 43 && b == 14 {
		print!("29");
	} else if a == 43 && b == 15 {
		print!("28");
	} else if a == 43 && b == 16 {
		print!("27");
	} else if a == 43 && b == 17 {
		print!("26");
	} else if a == 43 && b == 18 {
		print!("25");
	} else if a == 43 && b == 19 {
		print!("24");
	} else if a == 43 && b == 20 {
		print!("23");
	} else if a == 43 && b == 21 {
		print!("22");
	} else if a == 43 && b == 22 {
		print!("21");
	} else if a == 43 && b == 23 {
		print!("20");
	} else if a == 43 && b == 24 {
		print!("19");
	} else if a == 43 && b == 25 {
		print!("18");
	} else if a == 43 && b == 26 {
		print!("17");
	} else if a == 43 && b == 27 {
		print!("16");
	} else if a == 43 && b == 28 {
		print!("15");
	} else if a == 43 && b == 29 {
		print!("14");
	} else if a == 43 && b == 30 {
		print!("13");
	} else if a == 43 && b == 31 {
		print!("12");
	} else if a == 43 && b == 32 {
		print!("11");
	} else if a == 43 && b == 33 {
		print!("10");
	} else if a == 43 && b == 34 {
		print!("9");
	} else if a == 43 && b == 35 {
		print!("8");
	} else if a == 43 && b == 36 {
		print!("7");
	} else if a == 43 && b == 37 {
		print!("6");
	} else if a == 43 && b == 38 {
		print!("5");
	} else if a == 43 && b == 39 {
		print!("4");
	} else if a == 43 && b == 40 {
		print!("3");
	} else if a == 43 && b == 41 {
		print!("2");
	} else if a == 43 && b == 42 {
		print!("1");
	} else if a == 43 && b == 43 {
		print!("0");
	} else if a == 43 && b == 44 {
		print!("-1");
	} else if a == 43 && b == 45 {
		print!("-2");
	} else if a == 43 && b == 46 {
		print!("-3");
	} else if a == 43 && b == 47 {
		print!("-4");
	} else if a == 43 && b == 48 {
		print!("-5");
	} else if a == 43 && b == 49 {
		print!("-6");
	} else if a == 43 && b == 50 {
		print!("-7");
	} else if a == 44 && b == 0 {
		print!("44");
	} else if a == 44 && b == 1 {
		print!("43");
	} else if a == 44 && b == 2 {
		print!("42");
	} else if a == 44 && b == 3 {
		print!("41");
	} else if a == 44 && b == 4 {
		print!("40");
	} else if a == 44 && b == 5 {
		print!("39");
	} else if a == 44 && b == 6 {
		print!("38");
	} else if a == 44 && b == 7 {
		print!("37");
	} else if a == 44 && b == 8 {
		print!("36");
	} else if a == 44 && b == 9 {
		print!("35");
	} else if a == 44 && b == 10 {
		print!("34");
	} else if a == 44 && b == 11 {
		print!("33");
	} else if a == 44 && b == 12 {
		print!("32");
	} else if a == 44 && b == 13 {
		print!("31");
	} else if a == 44 && b == 14 {
		print!("30");
	} else if a == 44 && b == 15 {
		print!("29");
	} else if a == 44 && b == 16 {
		print!("28");
	} else if a == 44 && b == 17 {
		print!("27");
	} else if a == 44 && b == 18 {
		print!("26");
	} else if a == 44 && b == 19 {
		print!("25");
	} else if a == 44 && b == 20 {
		print!("24");
	} else if a == 44 && b == 21 {
		print!("23");
	} else if a == 44 && b == 22 {
		print!("22");
	} else if a == 44 && b == 23 {
		print!("21");
	} else if a == 44 && b == 24 {
		print!("20");
	} else if a == 44 && b == 25 {
		print!("19");
	} else if a == 44 && b == 26 {
		print!("18");
	} else if a == 44 && b == 27 {
		print!("17");
	} else if a == 44 && b == 28 {
		print!("16");
	} else if a == 44 && b == 29 {
		print!("15");
	} else if a == 44 && b == 30 {
		print!("14");
	} else if a == 44 && b == 31 {
		print!("13");
	} else if a == 44 && b == 32 {
		print!("12");
	} else if a == 44 && b == 33 {
		print!("11");
	} else if a == 44 && b == 34 {
		print!("10");
	} else if a == 44 && b == 35 {
		print!("9");
	} else if a == 44 && b == 36 {
		print!("8");
	} else if a == 44 && b == 37 {
		print!("7");
	} else if a == 44 && b == 38 {
		print!("6");
	} else if a == 44 && b == 39 {
		print!("5");
	} else if a == 44 && b == 40 {
		print!("4");
	} else if a == 44 && b == 41 {
		print!("3");
	} else if a == 44 && b == 42 {
		print!("2");
	} else if a == 44 && b == 43 {
		print!("1");
	} else if a == 44 && b == 44 {
		print!("0");
	} else if a == 44 && b == 45 {
		print!("-1");
	} else if a == 44 && b == 46 {
		print!("-2");
	} else if a == 44 && b == 47 {
		print!("-3");
	} else if a == 44 && b == 48 {
		print!("-4");
	} else if a == 44 && b == 49 {
		print!("-5");
	} else if a == 44 && b == 50 {
		print!("-6");
	} else if a == 45 && b == 0 {
		print!("45");
	} else if a == 45 && b == 1 {
		print!("44");
	} else if a == 45 && b == 2 {
		print!("43");
	} else if a == 45 && b == 3 {
		print!("42");
	} else if a == 45 && b == 4 {
		print!("41");
	} else if a == 45 && b == 5 {
		print!("40");
	} else if a == 45 && b == 6 {
		print!("39");
	} else if a == 45 && b == 7 {
		print!("38");
	} else if a == 45 && b == 8 {
		print!("37");
	} else if a == 45 && b == 9 {
		print!("36");
	} else if a == 45 && b == 10 {
		print!("35");
	} else if a == 45 && b == 11 {
		print!("34");
	} else if a == 45 && b == 12 {
		print!("33");
	} else if a == 45 && b == 13 {
		print!("32");
	} else if a == 45 && b == 14 {
		print!("31");
	} else if a == 45 && b == 15 {
		print!("30");
	} else if a == 45 && b == 16 {
		print!("29");
	} else if a == 45 && b == 17 {
		print!("28");
	} else if a == 45 && b == 18 {
		print!("27");
	} else if a == 45 && b == 19 {
		print!("26");
	} else if a == 45 && b == 20 {
		print!("25");
	} else if a == 45 && b == 21 {
		print!("24");
	} else if a == 45 && b == 22 {
		print!("23");
	} else if a == 45 && b == 23 {
		print!("22");
	} else if a == 45 && b == 24 {
		print!("21");
	} else if a == 45 && b == 25 {
		print!("20");
	} else if a == 45 && b == 26 {
		print!("19");
	} else if a == 45 && b == 27 {
		print!("18");
	} else if a == 45 && b == 28 {
		print!("17");
	} else if a == 45 && b == 29 {
		print!("16");
	} else if a == 45 && b == 30 {
		print!("15");
	} else if a == 45 && b == 31 {
		print!("14");
	} else if a == 45 && b == 32 {
		print!("13");
	} else if a == 45 && b == 33 {
		print!("12");
	} else if a == 45 && b == 34 {
		print!("11");
	} else if a == 45 && b == 35 {
		print!("10");
	} else if a == 45 && b == 36 {
		print!("9");
	} else if a == 45 && b == 37 {
		print!("8");
	} else if a == 45 && b == 38 {
		print!("7");
	} else if a == 45 && b == 39 {
		print!("6");
	} else if a == 45 && b == 40 {
		print!("5");
	} else if a == 45 && b == 41 {
		print!("4");
	} else if a == 45 && b == 42 {
		print!("3");
	} else if a == 45 && b == 43 {
		print!("2");
	} else if a == 45 && b == 44 {
		print!("1");
	} else if a == 45 && b == 45 {
		print!("0");
	} else if a == 45 && b == 46 {
		print!("-1");
	} else if a == 45 && b == 47 {
		print!("-2");
	} else if a == 45 && b == 48 {
		print!("-3");
	} else if a == 45 && b == 49 {
		print!("-4");
	} else if a == 45 && b == 50 {
		print!("-5");
	} else if a == 46 && b == 0 {
		print!("46");
	} else if a == 46 && b == 1 {
		print!("45");
	} else if a == 46 && b == 2 {
		print!("44");
	} else if a == 46 && b == 3 {
		print!("43");
	} else if a == 46 && b == 4 {
		print!("42");
	} else if a == 46 && b == 5 {
		print!("41");
	} else if a == 46 && b == 6 {
		print!("40");
	} else if a == 46 && b == 7 {
		print!("39");
	} else if a == 46 && b == 8 {
		print!("38");
	} else if a == 46 && b == 9 {
		print!("37");
	} else if a == 46 && b == 10 {
		print!("36");
	} else if a == 46 && b == 11 {
		print!("35");
	} else if a == 46 && b == 12 {
		print!("34");
	} else if a == 46 && b == 13 {
		print!("33");
	} else if a == 46 && b == 14 {
		print!("32");
	} else if a == 46 && b == 15 {
		print!("31");
	} else if a == 46 && b == 16 {
		print!("30");
	} else if a == 46 && b == 17 {
		print!("29");
	} else if a == 46 && b == 18 {
		print!("28");
	} else if a == 46 && b == 19 {
		print!("27");
	} else if a == 46 && b == 20 {
		print!("26");
	} else if a == 46 && b == 21 {
		print!("25");
	} else if a == 46 && b == 22 {
		print!("24");
	} else if a == 46 && b == 23 {
		print!("23");
	} else if a == 46 && b == 24 {
		print!("22");
	} else if a == 46 && b == 25 {
		print!("21");
	} else if a == 46 && b == 26 {
		print!("20");
	} else if a == 46 && b == 27 {
		print!("19");
	} else if a == 46 && b == 28 {
		print!("18");
	} else if a == 46 && b == 29 {
		print!("17");
	} else if a == 46 && b == 30 {
		print!("16");
	} else if a == 46 && b == 31 {
		print!("15");
	} else if a == 46 && b == 32 {
		print!("14");
	} else if a == 46 && b == 33 {
		print!("13");
	} else if a == 46 && b == 34 {
		print!("12");
	} else if a == 46 && b == 35 {
		print!("11");
	} else if a == 46 && b == 36 {
		print!("10");
	} else if a == 46 && b == 37 {
		print!("9");
	} else if a == 46 && b == 38 {
		print!("8");
	} else if a == 46 && b == 39 {
		print!("7");
	} else if a == 46 && b == 40 {
		print!("6");
	} else if a == 46 && b == 41 {
		print!("5");
	} else if a == 46 && b == 42 {
		print!("4");
	} else if a == 46 && b == 43 {
		print!("3");
	} else if a == 46 && b == 44 {
		print!("2");
	} else if a == 46 && b == 45 {
		print!("1");
	} else if a == 46 && b == 46 {
		print!("0");
	} else if a == 46 && b == 47 {
		print!("-1");
	} else if a == 46 && b == 48 {
		print!("-2");
	} else if a == 46 && b == 49 {
		print!("-3");
	} else if a == 46 && b == 50 {
		print!("-4");
	} else if a == 47 && b == 0 {
		print!("47");
	} else if a == 47 && b == 1 {
		print!("46");
	} else if a == 47 && b == 2 {
		print!("45");
	} else if a == 47 && b == 3 {
		print!("44");
	} else if a == 47 && b == 4 {
		print!("43");
	} else if a == 47 && b == 5 {
		print!("42");
	} else if a == 47 && b == 6 {
		print!("41");
	} else if a == 47 && b == 7 {
		print!("40");
	} else if a == 47 && b == 8 {
		print!("39");
	} else if a == 47 && b == 9 {
		print!("38");
	} else if a == 47 && b == 10 {
		print!("37");
	} else if a == 47 && b == 11 {
		print!("36");
	} else if a == 47 && b == 12 {
		print!("35");
	} else if a == 47 && b == 13 {
		print!("34");
	} else if a == 47 && b == 14 {
		print!("33");
	} else if a == 47 && b == 15 {
		print!("32");
	} else if a == 47 && b == 16 {
		print!("31");
	} else if a == 47 && b == 17 {
		print!("30");
	} else if a == 47 && b == 18 {
		print!("29");
	} else if a == 47 && b == 19 {
		print!("28");
	} else if a == 47 && b == 20 {
		print!("27");
	} else if a == 47 && b == 21 {
		print!("26");
	} else if a == 47 && b == 22 {
		print!("25");
	} else if a == 47 && b == 23 {
		print!("24");
	} else if a == 47 && b == 24 {
		print!("23");
	} else if a == 47 && b == 25 {
		print!("22");
	} else if a == 47 && b == 26 {
		print!("21");
	} else if a == 47 && b == 27 {
		print!("20");
	} else if a == 47 && b == 28 {
		print!("19");
	} else if a == 47 && b == 29 {
		print!("18");
	} else if a == 47 && b == 30 {
		print!("17");
	} else if a == 47 && b == 31 {
		print!("16");
	} else if a == 47 && b == 32 {
		print!("15");
	} else if a == 47 && b == 33 {
		print!("14");
	} else if a == 47 && b == 34 {
		print!("13");
	} else if a == 47 && b == 35 {
		print!("12");
	} else if a == 47 && b == 36 {
		print!("11");
	} else if a == 47 && b == 37 {
		print!("10");
	} else if a == 47 && b == 38 {
		print!("9");
	} else if a == 47 && b == 39 {
		print!("8");
	} else if a == 47 && b == 40 {
		print!("7");
	} else if a == 47 && b == 41 {
		print!("6");
	} else if a == 47 && b == 42 {
		print!("5");
	} else if a == 47 && b == 43 {
		print!("4");
	} else if a == 47 && b == 44 {
		print!("3");
	} else if a == 47 && b == 45 {
		print!("2");
	} else if a == 47 && b == 46 {
		print!("1");
	} else if a == 47 && b == 47 {
		print!("0");
	} else if a == 47 && b == 48 {
		print!("-1");
	} else if a == 47 && b == 49 {
		print!("-2");
	} else if a == 47 && b == 50 {
		print!("-3");
	} else if a == 48 && b == 0 {
		print!("48");
	} else if a == 48 && b == 1 {
		print!("47");
	} else if a == 48 && b == 2 {
		print!("46");
	} else if a == 48 && b == 3 {
		print!("45");
	} else if a == 48 && b == 4 {
		print!("44");
	} else if a == 48 && b == 5 {
		print!("43");
	} else if a == 48 && b == 6 {
		print!("42");
	} else if a == 48 && b == 7 {
		print!("41");
	} else if a == 48 && b == 8 {
		print!("40");
	} else if a == 48 && b == 9 {
		print!("39");
	} else if a == 48 && b == 10 {
		print!("38");
	} else if a == 48 && b == 11 {
		print!("37");
	} else if a == 48 && b == 12 {
		print!("36");
	} else if a == 48 && b == 13 {
		print!("35");
	} else if a == 48 && b == 14 {
		print!("34");
	} else if a == 48 && b == 15 {
		print!("33");
	} else if a == 48 && b == 16 {
		print!("32");
	} else if a == 48 && b == 17 {
		print!("31");
	} else if a == 48 && b == 18 {
		print!("30");
	} else if a == 48 && b == 19 {
		print!("29");
	} else if a == 48 && b == 20 {
		print!("28");
	} else if a == 48 && b == 21 {
		print!("27");
	} else if a == 48 && b == 22 {
		print!("26");
	} else if a == 48 && b == 23 {
		print!("25");
	} else if a == 48 && b == 24 {
		print!("24");
	} else if a == 48 && b == 25 {
		print!("23");
	} else if a == 48 && b == 26 {
		print!("22");
	} else if a == 48 && b == 27 {
		print!("21");
	} else if a == 48 && b == 28 {
		print!("20");
	} else if a == 48 && b == 29 {
		print!("19");
	} else if a == 48 && b == 30 {
		print!("18");
	} else if a == 48 && b == 31 {
		print!("17");
	} else if a == 48 && b == 32 {
		print!("16");
	} else if a == 48 && b == 33 {
		print!("15");
	} else if a == 48 && b == 34 {
		print!("14");
	} else if a == 48 && b == 35 {
		print!("13");
	} else if a == 48 && b == 36 {
		print!("12");
	} else if a == 48 && b == 37 {
		print!("11");
	} else if a == 48 && b == 38 {
		print!("10");
	} else if a == 48 && b == 39 {
		print!("9");
	} else if a == 48 && b == 40 {
		print!("8");
	} else if a == 48 && b == 41 {
		print!("7");
	} else if a == 48 && b == 42 {
		print!("6");
	} else if a == 48 && b == 43 {
		print!("5");
	} else if a == 48 && b == 44 {
		print!("4");
	} else if a == 48 && b == 45 {
		print!("3");
	} else if a == 48 && b == 46 {
		print!("2");
	} else if a == 48 && b == 47 {
		print!("1");
	} else if a == 48 && b == 48 {
		print!("0");
	} else if a == 48 && b == 49 {
		print!("-1");
	} else if a == 48 && b == 50 {
		print!("-2");
	} else if a == 49 && b == 0 {
		print!("49");
	} else if a == 49 && b == 1 {
		print!("48");
	} else if a == 49 && b == 2 {
		print!("47");
	} else if a == 49 && b == 3 {
		print!("46");
	} else if a == 49 && b == 4 {
		print!("45");
	} else if a == 49 && b == 5 {
		print!("44");
	} else if a == 49 && b == 6 {
		print!("43");
	} else if a == 49 && b == 7 {
		print!("42");
	} else if a == 49 && b == 8 {
		print!("41");
	} else if a == 49 && b == 9 {
		print!("40");
	} else if a == 49 && b == 10 {
		print!("39");
	} else if a == 49 && b == 11 {
		print!("38");
	} else if a == 49 && b == 12 {
		print!("37");
	} else if a == 49 && b == 13 {
		print!("36");
	} else if a == 49 && b == 14 {
		print!("35");
	} else if a == 49 && b == 15 {
		print!("34");
	} else if a == 49 && b == 16 {
		print!("33");
	} else if a == 49 && b == 17 {
		print!("32");
	} else if a == 49 && b == 18 {
		print!("31");
	} else if a == 49 && b == 19 {
		print!("30");
	} else if a == 49 && b == 20 {
		print!("29");
	} else if a == 49 && b == 21 {
		print!("28");
	} else if a == 49 && b == 22 {
		print!("27");
	} else if a == 49 && b == 23 {
		print!("26");
	} else if a == 49 && b == 24 {
		print!("25");
	} else if a == 49 && b == 25 {
		print!("24");
	} else if a == 49 && b == 26 {
		print!("23");
	} else if a == 49 && b == 27 {
		print!("22");
	} else if a == 49 && b == 28 {
		print!("21");
	} else if a == 49 && b == 29 {
		print!("20");
	} else if a == 49 && b == 30 {
		print!("19");
	} else if a == 49 && b == 31 {
		print!("18");
	} else if a == 49 && b == 32 {
		print!("17");
	} else if a == 49 && b == 33 {
		print!("16");
	} else if a == 49 && b == 34 {
		print!("15");
	} else if a == 49 && b == 35 {
		print!("14");
	} else if a == 49 && b == 36 {
		print!("13");
	} else if a == 49 && b == 37 {
		print!("12");
	} else if a == 49 && b == 38 {
		print!("11");
	} else if a == 49 && b == 39 {
		print!("10");
	} else if a == 49 && b == 40 {
		print!("9");
	} else if a == 49 && b == 41 {
		print!("8");
	} else if a == 49 && b == 42 {
		print!("7");
	} else if a == 49 && b == 43 {
		print!("6");
	} else if a == 49 && b == 44 {
		print!("5");
	} else if a == 49 && b == 45 {
		print!("4");
	} else if a == 49 && b == 46 {
		print!("3");
	} else if a == 49 && b == 47 {
		print!("2");
	} else if a == 49 && b == 48 {
		print!("1");
	} else if a == 49 && b == 49 {
		print!("0");
	} else if a == 49 && b == 50 {
		print!("-1");
	} else if a == 50 && b == 0 {
		print!("50");
	} else if a == 50 && b == 1 {
		print!("49");
	} else if a == 50 && b == 2 {
		print!("48");
	} else if a == 50 && b == 3 {
		print!("47");
	} else if a == 50 && b == 4 {
		print!("46");
	} else if a == 50 && b == 5 {
		print!("45");
	} else if a == 50 && b == 6 {
		print!("44");
	} else if a == 50 && b == 7 {
		print!("43");
	} else if a == 50 && b == 8 {
		print!("42");
	} else if a == 50 && b == 9 {
		print!("41");
	} else if a == 50 && b == 10 {
		print!("40");
	} else if a == 50 && b == 11 {
		print!("39");
	} else if a == 50 && b == 12 {
		print!("38");
	} else if a == 50 && b == 13 {
		print!("37");
	} else if a == 50 && b == 14 {
		print!("36");
	} else if a == 50 && b == 15 {
		print!("35");
	} else if a == 50 && b == 16 {
		print!("34");
	} else if a == 50 && b == 17 {
		print!("33");
	} else if a == 50 && b == 18 {
		print!("32");
	} else if a == 50 && b == 19 {
		print!("31");
	} else if a == 50 && b == 20 {
		print!("30");
	} else if a == 50 && b == 21 {
		print!("29");
	} else if a == 50 && b == 22 {
		print!("28");
	} else if a == 50 && b == 23 {
		print!("27");
	} else if a == 50 && b == 24 {
		print!("26");
	} else if a == 50 && b == 25 {
		print!("25");
	} else if a == 50 && b == 26 {
		print!("24");
	} else if a == 50 && b == 27 {
		print!("23");
	} else if a == 50 && b == 28 {
		print!("22");
	} else if a == 50 && b == 29 {
		print!("21");
	} else if a == 50 && b == 30 {
		print!("20");
	} else if a == 50 && b == 31 {
		print!("19");
	} else if a == 50 && b == 32 {
		print!("18");
	} else if a == 50 && b == 33 {
		print!("17");
	} else if a == 50 && b == 34 {
		print!("16");
	} else if a == 50 && b == 35 {
		print!("15");
	} else if a == 50 && b == 36 {
		print!("14");
	} else if a == 50 && b == 37 {
		print!("13");
	} else if a == 50 && b == 38 {
		print!("12");
	} else if a == 50 && b == 39 {
		print!("11");
	} else if a == 50 && b == 40 {
		print!("10");
	} else if a == 50 && b == 41 {
		print!("9");
	} else if a == 50 && b == 42 {
		print!("8");
	} else if a == 50 && b == 43 {
		print!("7");
	} else if a == 50 && b == 44 {
		print!("6");
	} else if a == 50 && b == 45 {
		print!("5");
	} else if a == 50 && b == 46 {
		print!("4");
	} else if a == 50 && b == 47 {
		print!("3");
	} else if a == 50 && b == 48 {
		print!("2");
	} else if a == 50 && b == 49 {
		print!("1");
	} else if a == 50 && b == 50 {
		print!("0");
	} else {
		print!("Unsupported number given!");
	}
}
