#!/usr/bin/perl
#
print "Max number: 50\n";
print "First number: ";
chomp(my $a = <>);
print "Second number: ";
chomp(my $b = <>);
print "Do u wanna: a - Add, s - Subtract\n";
my $method = <>;
$method = substr($method, 0, 1);
print "\nResult: ";
if ($method eq 'a') {
	add($a, $b);
} elsif ($method eq's') {
	subtract($a, $b);
} else {
	print "Bad method selected!";
}

sub add {
	my $a = shift;
	my $b = shift;
	if ($a eq 0 && $b eq 0) {
		print 0;
	} elsif ($a eq 0 && $b eq 1) {
		print 1;
	} elsif ($a eq 0 && $b eq 2) {
		print 2;
	} elsif ($a eq 0 && $b eq 3) {
		print 3;
	} elsif ($a eq 0 && $b eq 4) {
		print 4;
	} elsif ($a eq 0 && $b eq 5) {
		print 5;
	} elsif ($a eq 0 && $b eq 6) {
		print 6;
	} elsif ($a eq 0 && $b eq 7) {
		print 7;
	} elsif ($a eq 0 && $b eq 8) {
		print 8;
	} elsif ($a eq 0 && $b eq 9) {
		print 9;
	} elsif ($a eq 0 && $b eq 10) {
		print 10;
	} elsif ($a eq 0 && $b eq 11) {
		print 11;
	} elsif ($a eq 0 && $b eq 12) {
		print 12;
	} elsif ($a eq 0 && $b eq 13) {
		print 13;
	} elsif ($a eq 0 && $b eq 14) {
		print 14;
	} elsif ($a eq 0 && $b eq 15) {
		print 15;
	} elsif ($a eq 0 && $b eq 16) {
		print 16;
	} elsif ($a eq 0 && $b eq 17) {
		print 17;
	} elsif ($a eq 0 && $b eq 18) {
		print 18;
	} elsif ($a eq 0 && $b eq 19) {
		print 19;
	} elsif ($a eq 0 && $b eq 20) {
		print 20;
	} elsif ($a eq 0 && $b eq 21) {
		print 21;
	} elsif ($a eq 0 && $b eq 22) {
		print 22;
	} elsif ($a eq 0 && $b eq 23) {
		print 23;
	} elsif ($a eq 0 && $b eq 24) {
		print 24;
	} elsif ($a eq 0 && $b eq 25) {
		print 25;
	} elsif ($a eq 0 && $b eq 26) {
		print 26;
	} elsif ($a eq 0 && $b eq 27) {
		print 27;
	} elsif ($a eq 0 && $b eq 28) {
		print 28;
	} elsif ($a eq 0 && $b eq 29) {
		print 29;
	} elsif ($a eq 0 && $b eq 30) {
		print 30;
	} elsif ($a eq 0 && $b eq 31) {
		print 31;
	} elsif ($a eq 0 && $b eq 32) {
		print 32;
	} elsif ($a eq 0 && $b eq 33) {
		print 33;
	} elsif ($a eq 0 && $b eq 34) {
		print 34;
	} elsif ($a eq 0 && $b eq 35) {
		print 35;
	} elsif ($a eq 0 && $b eq 36) {
		print 36;
	} elsif ($a eq 0 && $b eq 37) {
		print 37;
	} elsif ($a eq 0 && $b eq 38) {
		print 38;
	} elsif ($a eq 0 && $b eq 39) {
		print 39;
	} elsif ($a eq 0 && $b eq 40) {
		print 40;
	} elsif ($a eq 0 && $b eq 41) {
		print 41;
	} elsif ($a eq 0 && $b eq 42) {
		print 42;
	} elsif ($a eq 0 && $b eq 43) {
		print 43;
	} elsif ($a eq 0 && $b eq 44) {
		print 44;
	} elsif ($a eq 0 && $b eq 45) {
		print 45;
	} elsif ($a eq 0 && $b eq 46) {
		print 46;
	} elsif ($a eq 0 && $b eq 47) {
		print 47;
	} elsif ($a eq 0 && $b eq 48) {
		print 48;
	} elsif ($a eq 0 && $b eq 49) {
		print 49;
	} elsif ($a eq 0 && $b eq 50) {
		print 50;
	} elsif ($a eq 1 && $b eq 0) {
		print 1;
	} elsif ($a eq 1 && $b eq 1) {
		print 2;
	} elsif ($a eq 1 && $b eq 2) {
		print 3;
	} elsif ($a eq 1 && $b eq 3) {
		print 4;
	} elsif ($a eq 1 && $b eq 4) {
		print 5;
	} elsif ($a eq 1 && $b eq 5) {
		print 6;
	} elsif ($a eq 1 && $b eq 6) {
		print 7;
	} elsif ($a eq 1 && $b eq 7) {
		print 8;
	} elsif ($a eq 1 && $b eq 8) {
		print 9;
	} elsif ($a eq 1 && $b eq 9) {
		print 10;
	} elsif ($a eq 1 && $b eq 10) {
		print 11;
	} elsif ($a eq 1 && $b eq 11) {
		print 12;
	} elsif ($a eq 1 && $b eq 12) {
		print 13;
	} elsif ($a eq 1 && $b eq 13) {
		print 14;
	} elsif ($a eq 1 && $b eq 14) {
		print 15;
	} elsif ($a eq 1 && $b eq 15) {
		print 16;
	} elsif ($a eq 1 && $b eq 16) {
		print 17;
	} elsif ($a eq 1 && $b eq 17) {
		print 18;
	} elsif ($a eq 1 && $b eq 18) {
		print 19;
	} elsif ($a eq 1 && $b eq 19) {
		print 20;
	} elsif ($a eq 1 && $b eq 20) {
		print 21;
	} elsif ($a eq 1 && $b eq 21) {
		print 22;
	} elsif ($a eq 1 && $b eq 22) {
		print 23;
	} elsif ($a eq 1 && $b eq 23) {
		print 24;
	} elsif ($a eq 1 && $b eq 24) {
		print 25;
	} elsif ($a eq 1 && $b eq 25) {
		print 26;
	} elsif ($a eq 1 && $b eq 26) {
		print 27;
	} elsif ($a eq 1 && $b eq 27) {
		print 28;
	} elsif ($a eq 1 && $b eq 28) {
		print 29;
	} elsif ($a eq 1 && $b eq 29) {
		print 30;
	} elsif ($a eq 1 && $b eq 30) {
		print 31;
	} elsif ($a eq 1 && $b eq 31) {
		print 32;
	} elsif ($a eq 1 && $b eq 32) {
		print 33;
	} elsif ($a eq 1 && $b eq 33) {
		print 34;
	} elsif ($a eq 1 && $b eq 34) {
		print 35;
	} elsif ($a eq 1 && $b eq 35) {
		print 36;
	} elsif ($a eq 1 && $b eq 36) {
		print 37;
	} elsif ($a eq 1 && $b eq 37) {
		print 38;
	} elsif ($a eq 1 && $b eq 38) {
		print 39;
	} elsif ($a eq 1 && $b eq 39) {
		print 40;
	} elsif ($a eq 1 && $b eq 40) {
		print 41;
	} elsif ($a eq 1 && $b eq 41) {
		print 42;
	} elsif ($a eq 1 && $b eq 42) {
		print 43;
	} elsif ($a eq 1 && $b eq 43) {
		print 44;
	} elsif ($a eq 1 && $b eq 44) {
		print 45;
	} elsif ($a eq 1 && $b eq 45) {
		print 46;
	} elsif ($a eq 1 && $b eq 46) {
		print 47;
	} elsif ($a eq 1 && $b eq 47) {
		print 48;
	} elsif ($a eq 1 && $b eq 48) {
		print 49;
	} elsif ($a eq 1 && $b eq 49) {
		print 50;
	} elsif ($a eq 1 && $b eq 50) {
		print 51;
	} elsif ($a eq 2 && $b eq 0) {
		print 2;
	} elsif ($a eq 2 && $b eq 1) {
		print 3;
	} elsif ($a eq 2 && $b eq 2) {
		print 4;
	} elsif ($a eq 2 && $b eq 3) {
		print 5;
	} elsif ($a eq 2 && $b eq 4) {
		print 6;
	} elsif ($a eq 2 && $b eq 5) {
		print 7;
	} elsif ($a eq 2 && $b eq 6) {
		print 8;
	} elsif ($a eq 2 && $b eq 7) {
		print 9;
	} elsif ($a eq 2 && $b eq 8) {
		print 10;
	} elsif ($a eq 2 && $b eq 9) {
		print 11;
	} elsif ($a eq 2 && $b eq 10) {
		print 12;
	} elsif ($a eq 2 && $b eq 11) {
		print 13;
	} elsif ($a eq 2 && $b eq 12) {
		print 14;
	} elsif ($a eq 2 && $b eq 13) {
		print 15;
	} elsif ($a eq 2 && $b eq 14) {
		print 16;
	} elsif ($a eq 2 && $b eq 15) {
		print 17;
	} elsif ($a eq 2 && $b eq 16) {
		print 18;
	} elsif ($a eq 2 && $b eq 17) {
		print 19;
	} elsif ($a eq 2 && $b eq 18) {
		print 20;
	} elsif ($a eq 2 && $b eq 19) {
		print 21;
	} elsif ($a eq 2 && $b eq 20) {
		print 22;
	} elsif ($a eq 2 && $b eq 21) {
		print 23;
	} elsif ($a eq 2 && $b eq 22) {
		print 24;
	} elsif ($a eq 2 && $b eq 23) {
		print 25;
	} elsif ($a eq 2 && $b eq 24) {
		print 26;
	} elsif ($a eq 2 && $b eq 25) {
		print 27;
	} elsif ($a eq 2 && $b eq 26) {
		print 28;
	} elsif ($a eq 2 && $b eq 27) {
		print 29;
	} elsif ($a eq 2 && $b eq 28) {
		print 30;
	} elsif ($a eq 2 && $b eq 29) {
		print 31;
	} elsif ($a eq 2 && $b eq 30) {
		print 32;
	} elsif ($a eq 2 && $b eq 31) {
		print 33;
	} elsif ($a eq 2 && $b eq 32) {
		print 34;
	} elsif ($a eq 2 && $b eq 33) {
		print 35;
	} elsif ($a eq 2 && $b eq 34) {
		print 36;
	} elsif ($a eq 2 && $b eq 35) {
		print 37;
	} elsif ($a eq 2 && $b eq 36) {
		print 38;
	} elsif ($a eq 2 && $b eq 37) {
		print 39;
	} elsif ($a eq 2 && $b eq 38) {
		print 40;
	} elsif ($a eq 2 && $b eq 39) {
		print 41;
	} elsif ($a eq 2 && $b eq 40) {
		print 42;
	} elsif ($a eq 2 && $b eq 41) {
		print 43;
	} elsif ($a eq 2 && $b eq 42) {
		print 44;
	} elsif ($a eq 2 && $b eq 43) {
		print 45;
	} elsif ($a eq 2 && $b eq 44) {
		print 46;
	} elsif ($a eq 2 && $b eq 45) {
		print 47;
	} elsif ($a eq 2 && $b eq 46) {
		print 48;
	} elsif ($a eq 2 && $b eq 47) {
		print 49;
	} elsif ($a eq 2 && $b eq 48) {
		print 50;
	} elsif ($a eq 2 && $b eq 49) {
		print 51;
	} elsif ($a eq 2 && $b eq 50) {
		print 52;
	} elsif ($a eq 3 && $b eq 0) {
		print 3;
	} elsif ($a eq 3 && $b eq 1) {
		print 4;
	} elsif ($a eq 3 && $b eq 2) {
		print 5;
	} elsif ($a eq 3 && $b eq 3) {
		print 6;
	} elsif ($a eq 3 && $b eq 4) {
		print 7;
	} elsif ($a eq 3 && $b eq 5) {
		print 8;
	} elsif ($a eq 3 && $b eq 6) {
		print 9;
	} elsif ($a eq 3 && $b eq 7) {
		print 10;
	} elsif ($a eq 3 && $b eq 8) {
		print 11;
	} elsif ($a eq 3 && $b eq 9) {
		print 12;
	} elsif ($a eq 3 && $b eq 10) {
		print 13;
	} elsif ($a eq 3 && $b eq 11) {
		print 14;
	} elsif ($a eq 3 && $b eq 12) {
		print 15;
	} elsif ($a eq 3 && $b eq 13) {
		print 16;
	} elsif ($a eq 3 && $b eq 14) {
		print 17;
	} elsif ($a eq 3 && $b eq 15) {
		print 18;
	} elsif ($a eq 3 && $b eq 16) {
		print 19;
	} elsif ($a eq 3 && $b eq 17) {
		print 20;
	} elsif ($a eq 3 && $b eq 18) {
		print 21;
	} elsif ($a eq 3 && $b eq 19) {
		print 22;
	} elsif ($a eq 3 && $b eq 20) {
		print 23;
	} elsif ($a eq 3 && $b eq 21) {
		print 24;
	} elsif ($a eq 3 && $b eq 22) {
		print 25;
	} elsif ($a eq 3 && $b eq 23) {
		print 26;
	} elsif ($a eq 3 && $b eq 24) {
		print 27;
	} elsif ($a eq 3 && $b eq 25) {
		print 28;
	} elsif ($a eq 3 && $b eq 26) {
		print 29;
	} elsif ($a eq 3 && $b eq 27) {
		print 30;
	} elsif ($a eq 3 && $b eq 28) {
		print 31;
	} elsif ($a eq 3 && $b eq 29) {
		print 32;
	} elsif ($a eq 3 && $b eq 30) {
		print 33;
	} elsif ($a eq 3 && $b eq 31) {
		print 34;
	} elsif ($a eq 3 && $b eq 32) {
		print 35;
	} elsif ($a eq 3 && $b eq 33) {
		print 36;
	} elsif ($a eq 3 && $b eq 34) {
		print 37;
	} elsif ($a eq 3 && $b eq 35) {
		print 38;
	} elsif ($a eq 3 && $b eq 36) {
		print 39;
	} elsif ($a eq 3 && $b eq 37) {
		print 40;
	} elsif ($a eq 3 && $b eq 38) {
		print 41;
	} elsif ($a eq 3 && $b eq 39) {
		print 42;
	} elsif ($a eq 3 && $b eq 40) {
		print 43;
	} elsif ($a eq 3 && $b eq 41) {
		print 44;
	} elsif ($a eq 3 && $b eq 42) {
		print 45;
	} elsif ($a eq 3 && $b eq 43) {
		print 46;
	} elsif ($a eq 3 && $b eq 44) {
		print 47;
	} elsif ($a eq 3 && $b eq 45) {
		print 48;
	} elsif ($a eq 3 && $b eq 46) {
		print 49;
	} elsif ($a eq 3 && $b eq 47) {
		print 50;
	} elsif ($a eq 3 && $b eq 48) {
		print 51;
	} elsif ($a eq 3 && $b eq 49) {
		print 52;
	} elsif ($a eq 3 && $b eq 50) {
		print 53;
	} elsif ($a eq 4 && $b eq 0) {
		print 4;
	} elsif ($a eq 4 && $b eq 1) {
		print 5;
	} elsif ($a eq 4 && $b eq 2) {
		print 6;
	} elsif ($a eq 4 && $b eq 3) {
		print 7;
	} elsif ($a eq 4 && $b eq 4) {
		print 8;
	} elsif ($a eq 4 && $b eq 5) {
		print 9;
	} elsif ($a eq 4 && $b eq 6) {
		print 10;
	} elsif ($a eq 4 && $b eq 7) {
		print 11;
	} elsif ($a eq 4 && $b eq 8) {
		print 12;
	} elsif ($a eq 4 && $b eq 9) {
		print 13;
	} elsif ($a eq 4 && $b eq 10) {
		print 14;
	} elsif ($a eq 4 && $b eq 11) {
		print 15;
	} elsif ($a eq 4 && $b eq 12) {
		print 16;
	} elsif ($a eq 4 && $b eq 13) {
		print 17;
	} elsif ($a eq 4 && $b eq 14) {
		print 18;
	} elsif ($a eq 4 && $b eq 15) {
		print 19;
	} elsif ($a eq 4 && $b eq 16) {
		print 20;
	} elsif ($a eq 4 && $b eq 17) {
		print 21;
	} elsif ($a eq 4 && $b eq 18) {
		print 22;
	} elsif ($a eq 4 && $b eq 19) {
		print 23;
	} elsif ($a eq 4 && $b eq 20) {
		print 24;
	} elsif ($a eq 4 && $b eq 21) {
		print 25;
	} elsif ($a eq 4 && $b eq 22) {
		print 26;
	} elsif ($a eq 4 && $b eq 23) {
		print 27;
	} elsif ($a eq 4 && $b eq 24) {
		print 28;
	} elsif ($a eq 4 && $b eq 25) {
		print 29;
	} elsif ($a eq 4 && $b eq 26) {
		print 30;
	} elsif ($a eq 4 && $b eq 27) {
		print 31;
	} elsif ($a eq 4 && $b eq 28) {
		print 32;
	} elsif ($a eq 4 && $b eq 29) {
		print 33;
	} elsif ($a eq 4 && $b eq 30) {
		print 34;
	} elsif ($a eq 4 && $b eq 31) {
		print 35;
	} elsif ($a eq 4 && $b eq 32) {
		print 36;
	} elsif ($a eq 4 && $b eq 33) {
		print 37;
	} elsif ($a eq 4 && $b eq 34) {
		print 38;
	} elsif ($a eq 4 && $b eq 35) {
		print 39;
	} elsif ($a eq 4 && $b eq 36) {
		print 40;
	} elsif ($a eq 4 && $b eq 37) {
		print 41;
	} elsif ($a eq 4 && $b eq 38) {
		print 42;
	} elsif ($a eq 4 && $b eq 39) {
		print 43;
	} elsif ($a eq 4 && $b eq 40) {
		print 44;
	} elsif ($a eq 4 && $b eq 41) {
		print 45;
	} elsif ($a eq 4 && $b eq 42) {
		print 46;
	} elsif ($a eq 4 && $b eq 43) {
		print 47;
	} elsif ($a eq 4 && $b eq 44) {
		print 48;
	} elsif ($a eq 4 && $b eq 45) {
		print 49;
	} elsif ($a eq 4 && $b eq 46) {
		print 50;
	} elsif ($a eq 4 && $b eq 47) {
		print 51;
	} elsif ($a eq 4 && $b eq 48) {
		print 52;
	} elsif ($a eq 4 && $b eq 49) {
		print 53;
	} elsif ($a eq 4 && $b eq 50) {
		print 54;
	} elsif ($a eq 5 && $b eq 0) {
		print 5;
	} elsif ($a eq 5 && $b eq 1) {
		print 6;
	} elsif ($a eq 5 && $b eq 2) {
		print 7;
	} elsif ($a eq 5 && $b eq 3) {
		print 8;
	} elsif ($a eq 5 && $b eq 4) {
		print 9;
	} elsif ($a eq 5 && $b eq 5) {
		print 10;
	} elsif ($a eq 5 && $b eq 6) {
		print 11;
	} elsif ($a eq 5 && $b eq 7) {
		print 12;
	} elsif ($a eq 5 && $b eq 8) {
		print 13;
	} elsif ($a eq 5 && $b eq 9) {
		print 14;
	} elsif ($a eq 5 && $b eq 10) {
		print 15;
	} elsif ($a eq 5 && $b eq 11) {
		print 16;
	} elsif ($a eq 5 && $b eq 12) {
		print 17;
	} elsif ($a eq 5 && $b eq 13) {
		print 18;
	} elsif ($a eq 5 && $b eq 14) {
		print 19;
	} elsif ($a eq 5 && $b eq 15) {
		print 20;
	} elsif ($a eq 5 && $b eq 16) {
		print 21;
	} elsif ($a eq 5 && $b eq 17) {
		print 22;
	} elsif ($a eq 5 && $b eq 18) {
		print 23;
	} elsif ($a eq 5 && $b eq 19) {
		print 24;
	} elsif ($a eq 5 && $b eq 20) {
		print 25;
	} elsif ($a eq 5 && $b eq 21) {
		print 26;
	} elsif ($a eq 5 && $b eq 22) {
		print 27;
	} elsif ($a eq 5 && $b eq 23) {
		print 28;
	} elsif ($a eq 5 && $b eq 24) {
		print 29;
	} elsif ($a eq 5 && $b eq 25) {
		print 30;
	} elsif ($a eq 5 && $b eq 26) {
		print 31;
	} elsif ($a eq 5 && $b eq 27) {
		print 32;
	} elsif ($a eq 5 && $b eq 28) {
		print 33;
	} elsif ($a eq 5 && $b eq 29) {
		print 34;
	} elsif ($a eq 5 && $b eq 30) {
		print 35;
	} elsif ($a eq 5 && $b eq 31) {
		print 36;
	} elsif ($a eq 5 && $b eq 32) {
		print 37;
	} elsif ($a eq 5 && $b eq 33) {
		print 38;
	} elsif ($a eq 5 && $b eq 34) {
		print 39;
	} elsif ($a eq 5 && $b eq 35) {
		print 40;
	} elsif ($a eq 5 && $b eq 36) {
		print 41;
	} elsif ($a eq 5 && $b eq 37) {
		print 42;
	} elsif ($a eq 5 && $b eq 38) {
		print 43;
	} elsif ($a eq 5 && $b eq 39) {
		print 44;
	} elsif ($a eq 5 && $b eq 40) {
		print 45;
	} elsif ($a eq 5 && $b eq 41) {
		print 46;
	} elsif ($a eq 5 && $b eq 42) {
		print 47;
	} elsif ($a eq 5 && $b eq 43) {
		print 48;
	} elsif ($a eq 5 && $b eq 44) {
		print 49;
	} elsif ($a eq 5 && $b eq 45) {
		print 50;
	} elsif ($a eq 5 && $b eq 46) {
		print 51;
	} elsif ($a eq 5 && $b eq 47) {
		print 52;
	} elsif ($a eq 5 && $b eq 48) {
		print 53;
	} elsif ($a eq 5 && $b eq 49) {
		print 54;
	} elsif ($a eq 5 && $b eq 50) {
		print 55;
	} elsif ($a eq 6 && $b eq 0) {
		print 6;
	} elsif ($a eq 6 && $b eq 1) {
		print 7;
	} elsif ($a eq 6 && $b eq 2) {
		print 8;
	} elsif ($a eq 6 && $b eq 3) {
		print 9;
	} elsif ($a eq 6 && $b eq 4) {
		print 10;
	} elsif ($a eq 6 && $b eq 5) {
		print 11;
	} elsif ($a eq 6 && $b eq 6) {
		print 12;
	} elsif ($a eq 6 && $b eq 7) {
		print 13;
	} elsif ($a eq 6 && $b eq 8) {
		print 14;
	} elsif ($a eq 6 && $b eq 9) {
		print 15;
	} elsif ($a eq 6 && $b eq 10) {
		print 16;
	} elsif ($a eq 6 && $b eq 11) {
		print 17;
	} elsif ($a eq 6 && $b eq 12) {
		print 18;
	} elsif ($a eq 6 && $b eq 13) {
		print 19;
	} elsif ($a eq 6 && $b eq 14) {
		print 20;
	} elsif ($a eq 6 && $b eq 15) {
		print 21;
	} elsif ($a eq 6 && $b eq 16) {
		print 22;
	} elsif ($a eq 6 && $b eq 17) {
		print 23;
	} elsif ($a eq 6 && $b eq 18) {
		print 24;
	} elsif ($a eq 6 && $b eq 19) {
		print 25;
	} elsif ($a eq 6 && $b eq 20) {
		print 26;
	} elsif ($a eq 6 && $b eq 21) {
		print 27;
	} elsif ($a eq 6 && $b eq 22) {
		print 28;
	} elsif ($a eq 6 && $b eq 23) {
		print 29;
	} elsif ($a eq 6 && $b eq 24) {
		print 30;
	} elsif ($a eq 6 && $b eq 25) {
		print 31;
	} elsif ($a eq 6 && $b eq 26) {
		print 32;
	} elsif ($a eq 6 && $b eq 27) {
		print 33;
	} elsif ($a eq 6 && $b eq 28) {
		print 34;
	} elsif ($a eq 6 && $b eq 29) {
		print 35;
	} elsif ($a eq 6 && $b eq 30) {
		print 36;
	} elsif ($a eq 6 && $b eq 31) {
		print 37;
	} elsif ($a eq 6 && $b eq 32) {
		print 38;
	} elsif ($a eq 6 && $b eq 33) {
		print 39;
	} elsif ($a eq 6 && $b eq 34) {
		print 40;
	} elsif ($a eq 6 && $b eq 35) {
		print 41;
	} elsif ($a eq 6 && $b eq 36) {
		print 42;
	} elsif ($a eq 6 && $b eq 37) {
		print 43;
	} elsif ($a eq 6 && $b eq 38) {
		print 44;
	} elsif ($a eq 6 && $b eq 39) {
		print 45;
	} elsif ($a eq 6 && $b eq 40) {
		print 46;
	} elsif ($a eq 6 && $b eq 41) {
		print 47;
	} elsif ($a eq 6 && $b eq 42) {
		print 48;
	} elsif ($a eq 6 && $b eq 43) {
		print 49;
	} elsif ($a eq 6 && $b eq 44) {
		print 50;
	} elsif ($a eq 6 && $b eq 45) {
		print 51;
	} elsif ($a eq 6 && $b eq 46) {
		print 52;
	} elsif ($a eq 6 && $b eq 47) {
		print 53;
	} elsif ($a eq 6 && $b eq 48) {
		print 54;
	} elsif ($a eq 6 && $b eq 49) {
		print 55;
	} elsif ($a eq 6 && $b eq 50) {
		print 56;
	} elsif ($a eq 7 && $b eq 0) {
		print 7;
	} elsif ($a eq 7 && $b eq 1) {
		print 8;
	} elsif ($a eq 7 && $b eq 2) {
		print 9;
	} elsif ($a eq 7 && $b eq 3) {
		print 10;
	} elsif ($a eq 7 && $b eq 4) {
		print 11;
	} elsif ($a eq 7 && $b eq 5) {
		print 12;
	} elsif ($a eq 7 && $b eq 6) {
		print 13;
	} elsif ($a eq 7 && $b eq 7) {
		print 14;
	} elsif ($a eq 7 && $b eq 8) {
		print 15;
	} elsif ($a eq 7 && $b eq 9) {
		print 16;
	} elsif ($a eq 7 && $b eq 10) {
		print 17;
	} elsif ($a eq 7 && $b eq 11) {
		print 18;
	} elsif ($a eq 7 && $b eq 12) {
		print 19;
	} elsif ($a eq 7 && $b eq 13) {
		print 20;
	} elsif ($a eq 7 && $b eq 14) {
		print 21;
	} elsif ($a eq 7 && $b eq 15) {
		print 22;
	} elsif ($a eq 7 && $b eq 16) {
		print 23;
	} elsif ($a eq 7 && $b eq 17) {
		print 24;
	} elsif ($a eq 7 && $b eq 18) {
		print 25;
	} elsif ($a eq 7 && $b eq 19) {
		print 26;
	} elsif ($a eq 7 && $b eq 20) {
		print 27;
	} elsif ($a eq 7 && $b eq 21) {
		print 28;
	} elsif ($a eq 7 && $b eq 22) {
		print 29;
	} elsif ($a eq 7 && $b eq 23) {
		print 30;
	} elsif ($a eq 7 && $b eq 24) {
		print 31;
	} elsif ($a eq 7 && $b eq 25) {
		print 32;
	} elsif ($a eq 7 && $b eq 26) {
		print 33;
	} elsif ($a eq 7 && $b eq 27) {
		print 34;
	} elsif ($a eq 7 && $b eq 28) {
		print 35;
	} elsif ($a eq 7 && $b eq 29) {
		print 36;
	} elsif ($a eq 7 && $b eq 30) {
		print 37;
	} elsif ($a eq 7 && $b eq 31) {
		print 38;
	} elsif ($a eq 7 && $b eq 32) {
		print 39;
	} elsif ($a eq 7 && $b eq 33) {
		print 40;
	} elsif ($a eq 7 && $b eq 34) {
		print 41;
	} elsif ($a eq 7 && $b eq 35) {
		print 42;
	} elsif ($a eq 7 && $b eq 36) {
		print 43;
	} elsif ($a eq 7 && $b eq 37) {
		print 44;
	} elsif ($a eq 7 && $b eq 38) {
		print 45;
	} elsif ($a eq 7 && $b eq 39) {
		print 46;
	} elsif ($a eq 7 && $b eq 40) {
		print 47;
	} elsif ($a eq 7 && $b eq 41) {
		print 48;
	} elsif ($a eq 7 && $b eq 42) {
		print 49;
	} elsif ($a eq 7 && $b eq 43) {
		print 50;
	} elsif ($a eq 7 && $b eq 44) {
		print 51;
	} elsif ($a eq 7 && $b eq 45) {
		print 52;
	} elsif ($a eq 7 && $b eq 46) {
		print 53;
	} elsif ($a eq 7 && $b eq 47) {
		print 54;
	} elsif ($a eq 7 && $b eq 48) {
		print 55;
	} elsif ($a eq 7 && $b eq 49) {
		print 56;
	} elsif ($a eq 7 && $b eq 50) {
		print 57;
	} elsif ($a eq 8 && $b eq 0) {
		print 8;
	} elsif ($a eq 8 && $b eq 1) {
		print 9;
	} elsif ($a eq 8 && $b eq 2) {
		print 10;
	} elsif ($a eq 8 && $b eq 3) {
		print 11;
	} elsif ($a eq 8 && $b eq 4) {
		print 12;
	} elsif ($a eq 8 && $b eq 5) {
		print 13;
	} elsif ($a eq 8 && $b eq 6) {
		print 14;
	} elsif ($a eq 8 && $b eq 7) {
		print 15;
	} elsif ($a eq 8 && $b eq 8) {
		print 16;
	} elsif ($a eq 8 && $b eq 9) {
		print 17;
	} elsif ($a eq 8 && $b eq 10) {
		print 18;
	} elsif ($a eq 8 && $b eq 11) {
		print 19;
	} elsif ($a eq 8 && $b eq 12) {
		print 20;
	} elsif ($a eq 8 && $b eq 13) {
		print 21;
	} elsif ($a eq 8 && $b eq 14) {
		print 22;
	} elsif ($a eq 8 && $b eq 15) {
		print 23;
	} elsif ($a eq 8 && $b eq 16) {
		print 24;
	} elsif ($a eq 8 && $b eq 17) {
		print 25;
	} elsif ($a eq 8 && $b eq 18) {
		print 26;
	} elsif ($a eq 8 && $b eq 19) {
		print 27;
	} elsif ($a eq 8 && $b eq 20) {
		print 28;
	} elsif ($a eq 8 && $b eq 21) {
		print 29;
	} elsif ($a eq 8 && $b eq 22) {
		print 30;
	} elsif ($a eq 8 && $b eq 23) {
		print 31;
	} elsif ($a eq 8 && $b eq 24) {
		print 32;
	} elsif ($a eq 8 && $b eq 25) {
		print 33;
	} elsif ($a eq 8 && $b eq 26) {
		print 34;
	} elsif ($a eq 8 && $b eq 27) {
		print 35;
	} elsif ($a eq 8 && $b eq 28) {
		print 36;
	} elsif ($a eq 8 && $b eq 29) {
		print 37;
	} elsif ($a eq 8 && $b eq 30) {
		print 38;
	} elsif ($a eq 8 && $b eq 31) {
		print 39;
	} elsif ($a eq 8 && $b eq 32) {
		print 40;
	} elsif ($a eq 8 && $b eq 33) {
		print 41;
	} elsif ($a eq 8 && $b eq 34) {
		print 42;
	} elsif ($a eq 8 && $b eq 35) {
		print 43;
	} elsif ($a eq 8 && $b eq 36) {
		print 44;
	} elsif ($a eq 8 && $b eq 37) {
		print 45;
	} elsif ($a eq 8 && $b eq 38) {
		print 46;
	} elsif ($a eq 8 && $b eq 39) {
		print 47;
	} elsif ($a eq 8 && $b eq 40) {
		print 48;
	} elsif ($a eq 8 && $b eq 41) {
		print 49;
	} elsif ($a eq 8 && $b eq 42) {
		print 50;
	} elsif ($a eq 8 && $b eq 43) {
		print 51;
	} elsif ($a eq 8 && $b eq 44) {
		print 52;
	} elsif ($a eq 8 && $b eq 45) {
		print 53;
	} elsif ($a eq 8 && $b eq 46) {
		print 54;
	} elsif ($a eq 8 && $b eq 47) {
		print 55;
	} elsif ($a eq 8 && $b eq 48) {
		print 56;
	} elsif ($a eq 8 && $b eq 49) {
		print 57;
	} elsif ($a eq 8 && $b eq 50) {
		print 58;
	} elsif ($a eq 9 && $b eq 0) {
		print 9;
	} elsif ($a eq 9 && $b eq 1) {
		print 10;
	} elsif ($a eq 9 && $b eq 2) {
		print 11;
	} elsif ($a eq 9 && $b eq 3) {
		print 12;
	} elsif ($a eq 9 && $b eq 4) {
		print 13;
	} elsif ($a eq 9 && $b eq 5) {
		print 14;
	} elsif ($a eq 9 && $b eq 6) {
		print 15;
	} elsif ($a eq 9 && $b eq 7) {
		print 16;
	} elsif ($a eq 9 && $b eq 8) {
		print 17;
	} elsif ($a eq 9 && $b eq 9) {
		print 18;
	} elsif ($a eq 9 && $b eq 10) {
		print 19;
	} elsif ($a eq 9 && $b eq 11) {
		print 20;
	} elsif ($a eq 9 && $b eq 12) {
		print 21;
	} elsif ($a eq 9 && $b eq 13) {
		print 22;
	} elsif ($a eq 9 && $b eq 14) {
		print 23;
	} elsif ($a eq 9 && $b eq 15) {
		print 24;
	} elsif ($a eq 9 && $b eq 16) {
		print 25;
	} elsif ($a eq 9 && $b eq 17) {
		print 26;
	} elsif ($a eq 9 && $b eq 18) {
		print 27;
	} elsif ($a eq 9 && $b eq 19) {
		print 28;
	} elsif ($a eq 9 && $b eq 20) {
		print 29;
	} elsif ($a eq 9 && $b eq 21) {
		print 30;
	} elsif ($a eq 9 && $b eq 22) {
		print 31;
	} elsif ($a eq 9 && $b eq 23) {
		print 32;
	} elsif ($a eq 9 && $b eq 24) {
		print 33;
	} elsif ($a eq 9 && $b eq 25) {
		print 34;
	} elsif ($a eq 9 && $b eq 26) {
		print 35;
	} elsif ($a eq 9 && $b eq 27) {
		print 36;
	} elsif ($a eq 9 && $b eq 28) {
		print 37;
	} elsif ($a eq 9 && $b eq 29) {
		print 38;
	} elsif ($a eq 9 && $b eq 30) {
		print 39;
	} elsif ($a eq 9 && $b eq 31) {
		print 40;
	} elsif ($a eq 9 && $b eq 32) {
		print 41;
	} elsif ($a eq 9 && $b eq 33) {
		print 42;
	} elsif ($a eq 9 && $b eq 34) {
		print 43;
	} elsif ($a eq 9 && $b eq 35) {
		print 44;
	} elsif ($a eq 9 && $b eq 36) {
		print 45;
	} elsif ($a eq 9 && $b eq 37) {
		print 46;
	} elsif ($a eq 9 && $b eq 38) {
		print 47;
	} elsif ($a eq 9 && $b eq 39) {
		print 48;
	} elsif ($a eq 9 && $b eq 40) {
		print 49;
	} elsif ($a eq 9 && $b eq 41) {
		print 50;
	} elsif ($a eq 9 && $b eq 42) {
		print 51;
	} elsif ($a eq 9 && $b eq 43) {
		print 52;
	} elsif ($a eq 9 && $b eq 44) {
		print 53;
	} elsif ($a eq 9 && $b eq 45) {
		print 54;
	} elsif ($a eq 9 && $b eq 46) {
		print 55;
	} elsif ($a eq 9 && $b eq 47) {
		print 56;
	} elsif ($a eq 9 && $b eq 48) {
		print 57;
	} elsif ($a eq 9 && $b eq 49) {
		print 58;
	} elsif ($a eq 9 && $b eq 50) {
		print 59;
	} elsif ($a eq 10 && $b eq 0) {
		print 10;
	} elsif ($a eq 10 && $b eq 1) {
		print 11;
	} elsif ($a eq 10 && $b eq 2) {
		print 12;
	} elsif ($a eq 10 && $b eq 3) {
		print 13;
	} elsif ($a eq 10 && $b eq 4) {
		print 14;
	} elsif ($a eq 10 && $b eq 5) {
		print 15;
	} elsif ($a eq 10 && $b eq 6) {
		print 16;
	} elsif ($a eq 10 && $b eq 7) {
		print 17;
	} elsif ($a eq 10 && $b eq 8) {
		print 18;
	} elsif ($a eq 10 && $b eq 9) {
		print 19;
	} elsif ($a eq 10 && $b eq 10) {
		print 20;
	} elsif ($a eq 10 && $b eq 11) {
		print 21;
	} elsif ($a eq 10 && $b eq 12) {
		print 22;
	} elsif ($a eq 10 && $b eq 13) {
		print 23;
	} elsif ($a eq 10 && $b eq 14) {
		print 24;
	} elsif ($a eq 10 && $b eq 15) {
		print 25;
	} elsif ($a eq 10 && $b eq 16) {
		print 26;
	} elsif ($a eq 10 && $b eq 17) {
		print 27;
	} elsif ($a eq 10 && $b eq 18) {
		print 28;
	} elsif ($a eq 10 && $b eq 19) {
		print 29;
	} elsif ($a eq 10 && $b eq 20) {
		print 30;
	} elsif ($a eq 10 && $b eq 21) {
		print 31;
	} elsif ($a eq 10 && $b eq 22) {
		print 32;
	} elsif ($a eq 10 && $b eq 23) {
		print 33;
	} elsif ($a eq 10 && $b eq 24) {
		print 34;
	} elsif ($a eq 10 && $b eq 25) {
		print 35;
	} elsif ($a eq 10 && $b eq 26) {
		print 36;
	} elsif ($a eq 10 && $b eq 27) {
		print 37;
	} elsif ($a eq 10 && $b eq 28) {
		print 38;
	} elsif ($a eq 10 && $b eq 29) {
		print 39;
	} elsif ($a eq 10 && $b eq 30) {
		print 40;
	} elsif ($a eq 10 && $b eq 31) {
		print 41;
	} elsif ($a eq 10 && $b eq 32) {
		print 42;
	} elsif ($a eq 10 && $b eq 33) {
		print 43;
	} elsif ($a eq 10 && $b eq 34) {
		print 44;
	} elsif ($a eq 10 && $b eq 35) {
		print 45;
	} elsif ($a eq 10 && $b eq 36) {
		print 46;
	} elsif ($a eq 10 && $b eq 37) {
		print 47;
	} elsif ($a eq 10 && $b eq 38) {
		print 48;
	} elsif ($a eq 10 && $b eq 39) {
		print 49;
	} elsif ($a eq 10 && $b eq 40) {
		print 50;
	} elsif ($a eq 10 && $b eq 41) {
		print 51;
	} elsif ($a eq 10 && $b eq 42) {
		print 52;
	} elsif ($a eq 10 && $b eq 43) {
		print 53;
	} elsif ($a eq 10 && $b eq 44) {
		print 54;
	} elsif ($a eq 10 && $b eq 45) {
		print 55;
	} elsif ($a eq 10 && $b eq 46) {
		print 56;
	} elsif ($a eq 10 && $b eq 47) {
		print 57;
	} elsif ($a eq 10 && $b eq 48) {
		print 58;
	} elsif ($a eq 10 && $b eq 49) {
		print 59;
	} elsif ($a eq 10 && $b eq 50) {
		print 60;
	} elsif ($a eq 11 && $b eq 0) {
		print 11;
	} elsif ($a eq 11 && $b eq 1) {
		print 12;
	} elsif ($a eq 11 && $b eq 2) {
		print 13;
	} elsif ($a eq 11 && $b eq 3) {
		print 14;
	} elsif ($a eq 11 && $b eq 4) {
		print 15;
	} elsif ($a eq 11 && $b eq 5) {
		print 16;
	} elsif ($a eq 11 && $b eq 6) {
		print 17;
	} elsif ($a eq 11 && $b eq 7) {
		print 18;
	} elsif ($a eq 11 && $b eq 8) {
		print 19;
	} elsif ($a eq 11 && $b eq 9) {
		print 20;
	} elsif ($a eq 11 && $b eq 10) {
		print 21;
	} elsif ($a eq 11 && $b eq 11) {
		print 22;
	} elsif ($a eq 11 && $b eq 12) {
		print 23;
	} elsif ($a eq 11 && $b eq 13) {
		print 24;
	} elsif ($a eq 11 && $b eq 14) {
		print 25;
	} elsif ($a eq 11 && $b eq 15) {
		print 26;
	} elsif ($a eq 11 && $b eq 16) {
		print 27;
	} elsif ($a eq 11 && $b eq 17) {
		print 28;
	} elsif ($a eq 11 && $b eq 18) {
		print 29;
	} elsif ($a eq 11 && $b eq 19) {
		print 30;
	} elsif ($a eq 11 && $b eq 20) {
		print 31;
	} elsif ($a eq 11 && $b eq 21) {
		print 32;
	} elsif ($a eq 11 && $b eq 22) {
		print 33;
	} elsif ($a eq 11 && $b eq 23) {
		print 34;
	} elsif ($a eq 11 && $b eq 24) {
		print 35;
	} elsif ($a eq 11 && $b eq 25) {
		print 36;
	} elsif ($a eq 11 && $b eq 26) {
		print 37;
	} elsif ($a eq 11 && $b eq 27) {
		print 38;
	} elsif ($a eq 11 && $b eq 28) {
		print 39;
	} elsif ($a eq 11 && $b eq 29) {
		print 40;
	} elsif ($a eq 11 && $b eq 30) {
		print 41;
	} elsif ($a eq 11 && $b eq 31) {
		print 42;
	} elsif ($a eq 11 && $b eq 32) {
		print 43;
	} elsif ($a eq 11 && $b eq 33) {
		print 44;
	} elsif ($a eq 11 && $b eq 34) {
		print 45;
	} elsif ($a eq 11 && $b eq 35) {
		print 46;
	} elsif ($a eq 11 && $b eq 36) {
		print 47;
	} elsif ($a eq 11 && $b eq 37) {
		print 48;
	} elsif ($a eq 11 && $b eq 38) {
		print 49;
	} elsif ($a eq 11 && $b eq 39) {
		print 50;
	} elsif ($a eq 11 && $b eq 40) {
		print 51;
	} elsif ($a eq 11 && $b eq 41) {
		print 52;
	} elsif ($a eq 11 && $b eq 42) {
		print 53;
	} elsif ($a eq 11 && $b eq 43) {
		print 54;
	} elsif ($a eq 11 && $b eq 44) {
		print 55;
	} elsif ($a eq 11 && $b eq 45) {
		print 56;
	} elsif ($a eq 11 && $b eq 46) {
		print 57;
	} elsif ($a eq 11 && $b eq 47) {
		print 58;
	} elsif ($a eq 11 && $b eq 48) {
		print 59;
	} elsif ($a eq 11 && $b eq 49) {
		print 60;
	} elsif ($a eq 11 && $b eq 50) {
		print 61;
	} elsif ($a eq 12 && $b eq 0) {
		print 12;
	} elsif ($a eq 12 && $b eq 1) {
		print 13;
	} elsif ($a eq 12 && $b eq 2) {
		print 14;
	} elsif ($a eq 12 && $b eq 3) {
		print 15;
	} elsif ($a eq 12 && $b eq 4) {
		print 16;
	} elsif ($a eq 12 && $b eq 5) {
		print 17;
	} elsif ($a eq 12 && $b eq 6) {
		print 18;
	} elsif ($a eq 12 && $b eq 7) {
		print 19;
	} elsif ($a eq 12 && $b eq 8) {
		print 20;
	} elsif ($a eq 12 && $b eq 9) {
		print 21;
	} elsif ($a eq 12 && $b eq 10) {
		print 22;
	} elsif ($a eq 12 && $b eq 11) {
		print 23;
	} elsif ($a eq 12 && $b eq 12) {
		print 24;
	} elsif ($a eq 12 && $b eq 13) {
		print 25;
	} elsif ($a eq 12 && $b eq 14) {
		print 26;
	} elsif ($a eq 12 && $b eq 15) {
		print 27;
	} elsif ($a eq 12 && $b eq 16) {
		print 28;
	} elsif ($a eq 12 && $b eq 17) {
		print 29;
	} elsif ($a eq 12 && $b eq 18) {
		print 30;
	} elsif ($a eq 12 && $b eq 19) {
		print 31;
	} elsif ($a eq 12 && $b eq 20) {
		print 32;
	} elsif ($a eq 12 && $b eq 21) {
		print 33;
	} elsif ($a eq 12 && $b eq 22) {
		print 34;
	} elsif ($a eq 12 && $b eq 23) {
		print 35;
	} elsif ($a eq 12 && $b eq 24) {
		print 36;
	} elsif ($a eq 12 && $b eq 25) {
		print 37;
	} elsif ($a eq 12 && $b eq 26) {
		print 38;
	} elsif ($a eq 12 && $b eq 27) {
		print 39;
	} elsif ($a eq 12 && $b eq 28) {
		print 40;
	} elsif ($a eq 12 && $b eq 29) {
		print 41;
	} elsif ($a eq 12 && $b eq 30) {
		print 42;
	} elsif ($a eq 12 && $b eq 31) {
		print 43;
	} elsif ($a eq 12 && $b eq 32) {
		print 44;
	} elsif ($a eq 12 && $b eq 33) {
		print 45;
	} elsif ($a eq 12 && $b eq 34) {
		print 46;
	} elsif ($a eq 12 && $b eq 35) {
		print 47;
	} elsif ($a eq 12 && $b eq 36) {
		print 48;
	} elsif ($a eq 12 && $b eq 37) {
		print 49;
	} elsif ($a eq 12 && $b eq 38) {
		print 50;
	} elsif ($a eq 12 && $b eq 39) {
		print 51;
	} elsif ($a eq 12 && $b eq 40) {
		print 52;
	} elsif ($a eq 12 && $b eq 41) {
		print 53;
	} elsif ($a eq 12 && $b eq 42) {
		print 54;
	} elsif ($a eq 12 && $b eq 43) {
		print 55;
	} elsif ($a eq 12 && $b eq 44) {
		print 56;
	} elsif ($a eq 12 && $b eq 45) {
		print 57;
	} elsif ($a eq 12 && $b eq 46) {
		print 58;
	} elsif ($a eq 12 && $b eq 47) {
		print 59;
	} elsif ($a eq 12 && $b eq 48) {
		print 60;
	} elsif ($a eq 12 && $b eq 49) {
		print 61;
	} elsif ($a eq 12 && $b eq 50) {
		print 62;
	} elsif ($a eq 13 && $b eq 0) {
		print 13;
	} elsif ($a eq 13 && $b eq 1) {
		print 14;
	} elsif ($a eq 13 && $b eq 2) {
		print 15;
	} elsif ($a eq 13 && $b eq 3) {
		print 16;
	} elsif ($a eq 13 && $b eq 4) {
		print 17;
	} elsif ($a eq 13 && $b eq 5) {
		print 18;
	} elsif ($a eq 13 && $b eq 6) {
		print 19;
	} elsif ($a eq 13 && $b eq 7) {
		print 20;
	} elsif ($a eq 13 && $b eq 8) {
		print 21;
	} elsif ($a eq 13 && $b eq 9) {
		print 22;
	} elsif ($a eq 13 && $b eq 10) {
		print 23;
	} elsif ($a eq 13 && $b eq 11) {
		print 24;
	} elsif ($a eq 13 && $b eq 12) {
		print 25;
	} elsif ($a eq 13 && $b eq 13) {
		print 26;
	} elsif ($a eq 13 && $b eq 14) {
		print 27;
	} elsif ($a eq 13 && $b eq 15) {
		print 28;
	} elsif ($a eq 13 && $b eq 16) {
		print 29;
	} elsif ($a eq 13 && $b eq 17) {
		print 30;
	} elsif ($a eq 13 && $b eq 18) {
		print 31;
	} elsif ($a eq 13 && $b eq 19) {
		print 32;
	} elsif ($a eq 13 && $b eq 20) {
		print 33;
	} elsif ($a eq 13 && $b eq 21) {
		print 34;
	} elsif ($a eq 13 && $b eq 22) {
		print 35;
	} elsif ($a eq 13 && $b eq 23) {
		print 36;
	} elsif ($a eq 13 && $b eq 24) {
		print 37;
	} elsif ($a eq 13 && $b eq 25) {
		print 38;
	} elsif ($a eq 13 && $b eq 26) {
		print 39;
	} elsif ($a eq 13 && $b eq 27) {
		print 40;
	} elsif ($a eq 13 && $b eq 28) {
		print 41;
	} elsif ($a eq 13 && $b eq 29) {
		print 42;
	} elsif ($a eq 13 && $b eq 30) {
		print 43;
	} elsif ($a eq 13 && $b eq 31) {
		print 44;
	} elsif ($a eq 13 && $b eq 32) {
		print 45;
	} elsif ($a eq 13 && $b eq 33) {
		print 46;
	} elsif ($a eq 13 && $b eq 34) {
		print 47;
	} elsif ($a eq 13 && $b eq 35) {
		print 48;
	} elsif ($a eq 13 && $b eq 36) {
		print 49;
	} elsif ($a eq 13 && $b eq 37) {
		print 50;
	} elsif ($a eq 13 && $b eq 38) {
		print 51;
	} elsif ($a eq 13 && $b eq 39) {
		print 52;
	} elsif ($a eq 13 && $b eq 40) {
		print 53;
	} elsif ($a eq 13 && $b eq 41) {
		print 54;
	} elsif ($a eq 13 && $b eq 42) {
		print 55;
	} elsif ($a eq 13 && $b eq 43) {
		print 56;
	} elsif ($a eq 13 && $b eq 44) {
		print 57;
	} elsif ($a eq 13 && $b eq 45) {
		print 58;
	} elsif ($a eq 13 && $b eq 46) {
		print 59;
	} elsif ($a eq 13 && $b eq 47) {
		print 60;
	} elsif ($a eq 13 && $b eq 48) {
		print 61;
	} elsif ($a eq 13 && $b eq 49) {
		print 62;
	} elsif ($a eq 13 && $b eq 50) {
		print 63;
	} elsif ($a eq 14 && $b eq 0) {
		print 14;
	} elsif ($a eq 14 && $b eq 1) {
		print 15;
	} elsif ($a eq 14 && $b eq 2) {
		print 16;
	} elsif ($a eq 14 && $b eq 3) {
		print 17;
	} elsif ($a eq 14 && $b eq 4) {
		print 18;
	} elsif ($a eq 14 && $b eq 5) {
		print 19;
	} elsif ($a eq 14 && $b eq 6) {
		print 20;
	} elsif ($a eq 14 && $b eq 7) {
		print 21;
	} elsif ($a eq 14 && $b eq 8) {
		print 22;
	} elsif ($a eq 14 && $b eq 9) {
		print 23;
	} elsif ($a eq 14 && $b eq 10) {
		print 24;
	} elsif ($a eq 14 && $b eq 11) {
		print 25;
	} elsif ($a eq 14 && $b eq 12) {
		print 26;
	} elsif ($a eq 14 && $b eq 13) {
		print 27;
	} elsif ($a eq 14 && $b eq 14) {
		print 28;
	} elsif ($a eq 14 && $b eq 15) {
		print 29;
	} elsif ($a eq 14 && $b eq 16) {
		print 30;
	} elsif ($a eq 14 && $b eq 17) {
		print 31;
	} elsif ($a eq 14 && $b eq 18) {
		print 32;
	} elsif ($a eq 14 && $b eq 19) {
		print 33;
	} elsif ($a eq 14 && $b eq 20) {
		print 34;
	} elsif ($a eq 14 && $b eq 21) {
		print 35;
	} elsif ($a eq 14 && $b eq 22) {
		print 36;
	} elsif ($a eq 14 && $b eq 23) {
		print 37;
	} elsif ($a eq 14 && $b eq 24) {
		print 38;
	} elsif ($a eq 14 && $b eq 25) {
		print 39;
	} elsif ($a eq 14 && $b eq 26) {
		print 40;
	} elsif ($a eq 14 && $b eq 27) {
		print 41;
	} elsif ($a eq 14 && $b eq 28) {
		print 42;
	} elsif ($a eq 14 && $b eq 29) {
		print 43;
	} elsif ($a eq 14 && $b eq 30) {
		print 44;
	} elsif ($a eq 14 && $b eq 31) {
		print 45;
	} elsif ($a eq 14 && $b eq 32) {
		print 46;
	} elsif ($a eq 14 && $b eq 33) {
		print 47;
	} elsif ($a eq 14 && $b eq 34) {
		print 48;
	} elsif ($a eq 14 && $b eq 35) {
		print 49;
	} elsif ($a eq 14 && $b eq 36) {
		print 50;
	} elsif ($a eq 14 && $b eq 37) {
		print 51;
	} elsif ($a eq 14 && $b eq 38) {
		print 52;
	} elsif ($a eq 14 && $b eq 39) {
		print 53;
	} elsif ($a eq 14 && $b eq 40) {
		print 54;
	} elsif ($a eq 14 && $b eq 41) {
		print 55;
	} elsif ($a eq 14 && $b eq 42) {
		print 56;
	} elsif ($a eq 14 && $b eq 43) {
		print 57;
	} elsif ($a eq 14 && $b eq 44) {
		print 58;
	} elsif ($a eq 14 && $b eq 45) {
		print 59;
	} elsif ($a eq 14 && $b eq 46) {
		print 60;
	} elsif ($a eq 14 && $b eq 47) {
		print 61;
	} elsif ($a eq 14 && $b eq 48) {
		print 62;
	} elsif ($a eq 14 && $b eq 49) {
		print 63;
	} elsif ($a eq 14 && $b eq 50) {
		print 64;
	} elsif ($a eq 15 && $b eq 0) {
		print 15;
	} elsif ($a eq 15 && $b eq 1) {
		print 16;
	} elsif ($a eq 15 && $b eq 2) {
		print 17;
	} elsif ($a eq 15 && $b eq 3) {
		print 18;
	} elsif ($a eq 15 && $b eq 4) {
		print 19;
	} elsif ($a eq 15 && $b eq 5) {
		print 20;
	} elsif ($a eq 15 && $b eq 6) {
		print 21;
	} elsif ($a eq 15 && $b eq 7) {
		print 22;
	} elsif ($a eq 15 && $b eq 8) {
		print 23;
	} elsif ($a eq 15 && $b eq 9) {
		print 24;
	} elsif ($a eq 15 && $b eq 10) {
		print 25;
	} elsif ($a eq 15 && $b eq 11) {
		print 26;
	} elsif ($a eq 15 && $b eq 12) {
		print 27;
	} elsif ($a eq 15 && $b eq 13) {
		print 28;
	} elsif ($a eq 15 && $b eq 14) {
		print 29;
	} elsif ($a eq 15 && $b eq 15) {
		print 30;
	} elsif ($a eq 15 && $b eq 16) {
		print 31;
	} elsif ($a eq 15 && $b eq 17) {
		print 32;
	} elsif ($a eq 15 && $b eq 18) {
		print 33;
	} elsif ($a eq 15 && $b eq 19) {
		print 34;
	} elsif ($a eq 15 && $b eq 20) {
		print 35;
	} elsif ($a eq 15 && $b eq 21) {
		print 36;
	} elsif ($a eq 15 && $b eq 22) {
		print 37;
	} elsif ($a eq 15 && $b eq 23) {
		print 38;
	} elsif ($a eq 15 && $b eq 24) {
		print 39;
	} elsif ($a eq 15 && $b eq 25) {
		print 40;
	} elsif ($a eq 15 && $b eq 26) {
		print 41;
	} elsif ($a eq 15 && $b eq 27) {
		print 42;
	} elsif ($a eq 15 && $b eq 28) {
		print 43;
	} elsif ($a eq 15 && $b eq 29) {
		print 44;
	} elsif ($a eq 15 && $b eq 30) {
		print 45;
	} elsif ($a eq 15 && $b eq 31) {
		print 46;
	} elsif ($a eq 15 && $b eq 32) {
		print 47;
	} elsif ($a eq 15 && $b eq 33) {
		print 48;
	} elsif ($a eq 15 && $b eq 34) {
		print 49;
	} elsif ($a eq 15 && $b eq 35) {
		print 50;
	} elsif ($a eq 15 && $b eq 36) {
		print 51;
	} elsif ($a eq 15 && $b eq 37) {
		print 52;
	} elsif ($a eq 15 && $b eq 38) {
		print 53;
	} elsif ($a eq 15 && $b eq 39) {
		print 54;
	} elsif ($a eq 15 && $b eq 40) {
		print 55;
	} elsif ($a eq 15 && $b eq 41) {
		print 56;
	} elsif ($a eq 15 && $b eq 42) {
		print 57;
	} elsif ($a eq 15 && $b eq 43) {
		print 58;
	} elsif ($a eq 15 && $b eq 44) {
		print 59;
	} elsif ($a eq 15 && $b eq 45) {
		print 60;
	} elsif ($a eq 15 && $b eq 46) {
		print 61;
	} elsif ($a eq 15 && $b eq 47) {
		print 62;
	} elsif ($a eq 15 && $b eq 48) {
		print 63;
	} elsif ($a eq 15 && $b eq 49) {
		print 64;
	} elsif ($a eq 15 && $b eq 50) {
		print 65;
	} elsif ($a eq 16 && $b eq 0) {
		print 16;
	} elsif ($a eq 16 && $b eq 1) {
		print 17;
	} elsif ($a eq 16 && $b eq 2) {
		print 18;
	} elsif ($a eq 16 && $b eq 3) {
		print 19;
	} elsif ($a eq 16 && $b eq 4) {
		print 20;
	} elsif ($a eq 16 && $b eq 5) {
		print 21;
	} elsif ($a eq 16 && $b eq 6) {
		print 22;
	} elsif ($a eq 16 && $b eq 7) {
		print 23;
	} elsif ($a eq 16 && $b eq 8) {
		print 24;
	} elsif ($a eq 16 && $b eq 9) {
		print 25;
	} elsif ($a eq 16 && $b eq 10) {
		print 26;
	} elsif ($a eq 16 && $b eq 11) {
		print 27;
	} elsif ($a eq 16 && $b eq 12) {
		print 28;
	} elsif ($a eq 16 && $b eq 13) {
		print 29;
	} elsif ($a eq 16 && $b eq 14) {
		print 30;
	} elsif ($a eq 16 && $b eq 15) {
		print 31;
	} elsif ($a eq 16 && $b eq 16) {
		print 32;
	} elsif ($a eq 16 && $b eq 17) {
		print 33;
	} elsif ($a eq 16 && $b eq 18) {
		print 34;
	} elsif ($a eq 16 && $b eq 19) {
		print 35;
	} elsif ($a eq 16 && $b eq 20) {
		print 36;
	} elsif ($a eq 16 && $b eq 21) {
		print 37;
	} elsif ($a eq 16 && $b eq 22) {
		print 38;
	} elsif ($a eq 16 && $b eq 23) {
		print 39;
	} elsif ($a eq 16 && $b eq 24) {
		print 40;
	} elsif ($a eq 16 && $b eq 25) {
		print 41;
	} elsif ($a eq 16 && $b eq 26) {
		print 42;
	} elsif ($a eq 16 && $b eq 27) {
		print 43;
	} elsif ($a eq 16 && $b eq 28) {
		print 44;
	} elsif ($a eq 16 && $b eq 29) {
		print 45;
	} elsif ($a eq 16 && $b eq 30) {
		print 46;
	} elsif ($a eq 16 && $b eq 31) {
		print 47;
	} elsif ($a eq 16 && $b eq 32) {
		print 48;
	} elsif ($a eq 16 && $b eq 33) {
		print 49;
	} elsif ($a eq 16 && $b eq 34) {
		print 50;
	} elsif ($a eq 16 && $b eq 35) {
		print 51;
	} elsif ($a eq 16 && $b eq 36) {
		print 52;
	} elsif ($a eq 16 && $b eq 37) {
		print 53;
	} elsif ($a eq 16 && $b eq 38) {
		print 54;
	} elsif ($a eq 16 && $b eq 39) {
		print 55;
	} elsif ($a eq 16 && $b eq 40) {
		print 56;
	} elsif ($a eq 16 && $b eq 41) {
		print 57;
	} elsif ($a eq 16 && $b eq 42) {
		print 58;
	} elsif ($a eq 16 && $b eq 43) {
		print 59;
	} elsif ($a eq 16 && $b eq 44) {
		print 60;
	} elsif ($a eq 16 && $b eq 45) {
		print 61;
	} elsif ($a eq 16 && $b eq 46) {
		print 62;
	} elsif ($a eq 16 && $b eq 47) {
		print 63;
	} elsif ($a eq 16 && $b eq 48) {
		print 64;
	} elsif ($a eq 16 && $b eq 49) {
		print 65;
	} elsif ($a eq 16 && $b eq 50) {
		print 66;
	} elsif ($a eq 17 && $b eq 0) {
		print 17;
	} elsif ($a eq 17 && $b eq 1) {
		print 18;
	} elsif ($a eq 17 && $b eq 2) {
		print 19;
	} elsif ($a eq 17 && $b eq 3) {
		print 20;
	} elsif ($a eq 17 && $b eq 4) {
		print 21;
	} elsif ($a eq 17 && $b eq 5) {
		print 22;
	} elsif ($a eq 17 && $b eq 6) {
		print 23;
	} elsif ($a eq 17 && $b eq 7) {
		print 24;
	} elsif ($a eq 17 && $b eq 8) {
		print 25;
	} elsif ($a eq 17 && $b eq 9) {
		print 26;
	} elsif ($a eq 17 && $b eq 10) {
		print 27;
	} elsif ($a eq 17 && $b eq 11) {
		print 28;
	} elsif ($a eq 17 && $b eq 12) {
		print 29;
	} elsif ($a eq 17 && $b eq 13) {
		print 30;
	} elsif ($a eq 17 && $b eq 14) {
		print 31;
	} elsif ($a eq 17 && $b eq 15) {
		print 32;
	} elsif ($a eq 17 && $b eq 16) {
		print 33;
	} elsif ($a eq 17 && $b eq 17) {
		print 34;
	} elsif ($a eq 17 && $b eq 18) {
		print 35;
	} elsif ($a eq 17 && $b eq 19) {
		print 36;
	} elsif ($a eq 17 && $b eq 20) {
		print 37;
	} elsif ($a eq 17 && $b eq 21) {
		print 38;
	} elsif ($a eq 17 && $b eq 22) {
		print 39;
	} elsif ($a eq 17 && $b eq 23) {
		print 40;
	} elsif ($a eq 17 && $b eq 24) {
		print 41;
	} elsif ($a eq 17 && $b eq 25) {
		print 42;
	} elsif ($a eq 17 && $b eq 26) {
		print 43;
	} elsif ($a eq 17 && $b eq 27) {
		print 44;
	} elsif ($a eq 17 && $b eq 28) {
		print 45;
	} elsif ($a eq 17 && $b eq 29) {
		print 46;
	} elsif ($a eq 17 && $b eq 30) {
		print 47;
	} elsif ($a eq 17 && $b eq 31) {
		print 48;
	} elsif ($a eq 17 && $b eq 32) {
		print 49;
	} elsif ($a eq 17 && $b eq 33) {
		print 50;
	} elsif ($a eq 17 && $b eq 34) {
		print 51;
	} elsif ($a eq 17 && $b eq 35) {
		print 52;
	} elsif ($a eq 17 && $b eq 36) {
		print 53;
	} elsif ($a eq 17 && $b eq 37) {
		print 54;
	} elsif ($a eq 17 && $b eq 38) {
		print 55;
	} elsif ($a eq 17 && $b eq 39) {
		print 56;
	} elsif ($a eq 17 && $b eq 40) {
		print 57;
	} elsif ($a eq 17 && $b eq 41) {
		print 58;
	} elsif ($a eq 17 && $b eq 42) {
		print 59;
	} elsif ($a eq 17 && $b eq 43) {
		print 60;
	} elsif ($a eq 17 && $b eq 44) {
		print 61;
	} elsif ($a eq 17 && $b eq 45) {
		print 62;
	} elsif ($a eq 17 && $b eq 46) {
		print 63;
	} elsif ($a eq 17 && $b eq 47) {
		print 64;
	} elsif ($a eq 17 && $b eq 48) {
		print 65;
	} elsif ($a eq 17 && $b eq 49) {
		print 66;
	} elsif ($a eq 17 && $b eq 50) {
		print 67;
	} elsif ($a eq 18 && $b eq 0) {
		print 18;
	} elsif ($a eq 18 && $b eq 1) {
		print 19;
	} elsif ($a eq 18 && $b eq 2) {
		print 20;
	} elsif ($a eq 18 && $b eq 3) {
		print 21;
	} elsif ($a eq 18 && $b eq 4) {
		print 22;
	} elsif ($a eq 18 && $b eq 5) {
		print 23;
	} elsif ($a eq 18 && $b eq 6) {
		print 24;
	} elsif ($a eq 18 && $b eq 7) {
		print 25;
	} elsif ($a eq 18 && $b eq 8) {
		print 26;
	} elsif ($a eq 18 && $b eq 9) {
		print 27;
	} elsif ($a eq 18 && $b eq 10) {
		print 28;
	} elsif ($a eq 18 && $b eq 11) {
		print 29;
	} elsif ($a eq 18 && $b eq 12) {
		print 30;
	} elsif ($a eq 18 && $b eq 13) {
		print 31;
	} elsif ($a eq 18 && $b eq 14) {
		print 32;
	} elsif ($a eq 18 && $b eq 15) {
		print 33;
	} elsif ($a eq 18 && $b eq 16) {
		print 34;
	} elsif ($a eq 18 && $b eq 17) {
		print 35;
	} elsif ($a eq 18 && $b eq 18) {
		print 36;
	} elsif ($a eq 18 && $b eq 19) {
		print 37;
	} elsif ($a eq 18 && $b eq 20) {
		print 38;
	} elsif ($a eq 18 && $b eq 21) {
		print 39;
	} elsif ($a eq 18 && $b eq 22) {
		print 40;
	} elsif ($a eq 18 && $b eq 23) {
		print 41;
	} elsif ($a eq 18 && $b eq 24) {
		print 42;
	} elsif ($a eq 18 && $b eq 25) {
		print 43;
	} elsif ($a eq 18 && $b eq 26) {
		print 44;
	} elsif ($a eq 18 && $b eq 27) {
		print 45;
	} elsif ($a eq 18 && $b eq 28) {
		print 46;
	} elsif ($a eq 18 && $b eq 29) {
		print 47;
	} elsif ($a eq 18 && $b eq 30) {
		print 48;
	} elsif ($a eq 18 && $b eq 31) {
		print 49;
	} elsif ($a eq 18 && $b eq 32) {
		print 50;
	} elsif ($a eq 18 && $b eq 33) {
		print 51;
	} elsif ($a eq 18 && $b eq 34) {
		print 52;
	} elsif ($a eq 18 && $b eq 35) {
		print 53;
	} elsif ($a eq 18 && $b eq 36) {
		print 54;
	} elsif ($a eq 18 && $b eq 37) {
		print 55;
	} elsif ($a eq 18 && $b eq 38) {
		print 56;
	} elsif ($a eq 18 && $b eq 39) {
		print 57;
	} elsif ($a eq 18 && $b eq 40) {
		print 58;
	} elsif ($a eq 18 && $b eq 41) {
		print 59;
	} elsif ($a eq 18 && $b eq 42) {
		print 60;
	} elsif ($a eq 18 && $b eq 43) {
		print 61;
	} elsif ($a eq 18 && $b eq 44) {
		print 62;
	} elsif ($a eq 18 && $b eq 45) {
		print 63;
	} elsif ($a eq 18 && $b eq 46) {
		print 64;
	} elsif ($a eq 18 && $b eq 47) {
		print 65;
	} elsif ($a eq 18 && $b eq 48) {
		print 66;
	} elsif ($a eq 18 && $b eq 49) {
		print 67;
	} elsif ($a eq 18 && $b eq 50) {
		print 68;
	} elsif ($a eq 19 && $b eq 0) {
		print 19;
	} elsif ($a eq 19 && $b eq 1) {
		print 20;
	} elsif ($a eq 19 && $b eq 2) {
		print 21;
	} elsif ($a eq 19 && $b eq 3) {
		print 22;
	} elsif ($a eq 19 && $b eq 4) {
		print 23;
	} elsif ($a eq 19 && $b eq 5) {
		print 24;
	} elsif ($a eq 19 && $b eq 6) {
		print 25;
	} elsif ($a eq 19 && $b eq 7) {
		print 26;
	} elsif ($a eq 19 && $b eq 8) {
		print 27;
	} elsif ($a eq 19 && $b eq 9) {
		print 28;
	} elsif ($a eq 19 && $b eq 10) {
		print 29;
	} elsif ($a eq 19 && $b eq 11) {
		print 30;
	} elsif ($a eq 19 && $b eq 12) {
		print 31;
	} elsif ($a eq 19 && $b eq 13) {
		print 32;
	} elsif ($a eq 19 && $b eq 14) {
		print 33;
	} elsif ($a eq 19 && $b eq 15) {
		print 34;
	} elsif ($a eq 19 && $b eq 16) {
		print 35;
	} elsif ($a eq 19 && $b eq 17) {
		print 36;
	} elsif ($a eq 19 && $b eq 18) {
		print 37;
	} elsif ($a eq 19 && $b eq 19) {
		print 38;
	} elsif ($a eq 19 && $b eq 20) {
		print 39;
	} elsif ($a eq 19 && $b eq 21) {
		print 40;
	} elsif ($a eq 19 && $b eq 22) {
		print 41;
	} elsif ($a eq 19 && $b eq 23) {
		print 42;
	} elsif ($a eq 19 && $b eq 24) {
		print 43;
	} elsif ($a eq 19 && $b eq 25) {
		print 44;
	} elsif ($a eq 19 && $b eq 26) {
		print 45;
	} elsif ($a eq 19 && $b eq 27) {
		print 46;
	} elsif ($a eq 19 && $b eq 28) {
		print 47;
	} elsif ($a eq 19 && $b eq 29) {
		print 48;
	} elsif ($a eq 19 && $b eq 30) {
		print 49;
	} elsif ($a eq 19 && $b eq 31) {
		print 50;
	} elsif ($a eq 19 && $b eq 32) {
		print 51;
	} elsif ($a eq 19 && $b eq 33) {
		print 52;
	} elsif ($a eq 19 && $b eq 34) {
		print 53;
	} elsif ($a eq 19 && $b eq 35) {
		print 54;
	} elsif ($a eq 19 && $b eq 36) {
		print 55;
	} elsif ($a eq 19 && $b eq 37) {
		print 56;
	} elsif ($a eq 19 && $b eq 38) {
		print 57;
	} elsif ($a eq 19 && $b eq 39) {
		print 58;
	} elsif ($a eq 19 && $b eq 40) {
		print 59;
	} elsif ($a eq 19 && $b eq 41) {
		print 60;
	} elsif ($a eq 19 && $b eq 42) {
		print 61;
	} elsif ($a eq 19 && $b eq 43) {
		print 62;
	} elsif ($a eq 19 && $b eq 44) {
		print 63;
	} elsif ($a eq 19 && $b eq 45) {
		print 64;
	} elsif ($a eq 19 && $b eq 46) {
		print 65;
	} elsif ($a eq 19 && $b eq 47) {
		print 66;
	} elsif ($a eq 19 && $b eq 48) {
		print 67;
	} elsif ($a eq 19 && $b eq 49) {
		print 68;
	} elsif ($a eq 19 && $b eq 50) {
		print 69;
	} elsif ($a eq 20 && $b eq 0) {
		print 20;
	} elsif ($a eq 20 && $b eq 1) {
		print 21;
	} elsif ($a eq 20 && $b eq 2) {
		print 22;
	} elsif ($a eq 20 && $b eq 3) {
		print 23;
	} elsif ($a eq 20 && $b eq 4) {
		print 24;
	} elsif ($a eq 20 && $b eq 5) {
		print 25;
	} elsif ($a eq 20 && $b eq 6) {
		print 26;
	} elsif ($a eq 20 && $b eq 7) {
		print 27;
	} elsif ($a eq 20 && $b eq 8) {
		print 28;
	} elsif ($a eq 20 && $b eq 9) {
		print 29;
	} elsif ($a eq 20 && $b eq 10) {
		print 30;
	} elsif ($a eq 20 && $b eq 11) {
		print 31;
	} elsif ($a eq 20 && $b eq 12) {
		print 32;
	} elsif ($a eq 20 && $b eq 13) {
		print 33;
	} elsif ($a eq 20 && $b eq 14) {
		print 34;
	} elsif ($a eq 20 && $b eq 15) {
		print 35;
	} elsif ($a eq 20 && $b eq 16) {
		print 36;
	} elsif ($a eq 20 && $b eq 17) {
		print 37;
	} elsif ($a eq 20 && $b eq 18) {
		print 38;
	} elsif ($a eq 20 && $b eq 19) {
		print 39;
	} elsif ($a eq 20 && $b eq 20) {
		print 40;
	} elsif ($a eq 20 && $b eq 21) {
		print 41;
	} elsif ($a eq 20 && $b eq 22) {
		print 42;
	} elsif ($a eq 20 && $b eq 23) {
		print 43;
	} elsif ($a eq 20 && $b eq 24) {
		print 44;
	} elsif ($a eq 20 && $b eq 25) {
		print 45;
	} elsif ($a eq 20 && $b eq 26) {
		print 46;
	} elsif ($a eq 20 && $b eq 27) {
		print 47;
	} elsif ($a eq 20 && $b eq 28) {
		print 48;
	} elsif ($a eq 20 && $b eq 29) {
		print 49;
	} elsif ($a eq 20 && $b eq 30) {
		print 50;
	} elsif ($a eq 20 && $b eq 31) {
		print 51;
	} elsif ($a eq 20 && $b eq 32) {
		print 52;
	} elsif ($a eq 20 && $b eq 33) {
		print 53;
	} elsif ($a eq 20 && $b eq 34) {
		print 54;
	} elsif ($a eq 20 && $b eq 35) {
		print 55;
	} elsif ($a eq 20 && $b eq 36) {
		print 56;
	} elsif ($a eq 20 && $b eq 37) {
		print 57;
	} elsif ($a eq 20 && $b eq 38) {
		print 58;
	} elsif ($a eq 20 && $b eq 39) {
		print 59;
	} elsif ($a eq 20 && $b eq 40) {
		print 60;
	} elsif ($a eq 20 && $b eq 41) {
		print 61;
	} elsif ($a eq 20 && $b eq 42) {
		print 62;
	} elsif ($a eq 20 && $b eq 43) {
		print 63;
	} elsif ($a eq 20 && $b eq 44) {
		print 64;
	} elsif ($a eq 20 && $b eq 45) {
		print 65;
	} elsif ($a eq 20 && $b eq 46) {
		print 66;
	} elsif ($a eq 20 && $b eq 47) {
		print 67;
	} elsif ($a eq 20 && $b eq 48) {
		print 68;
	} elsif ($a eq 20 && $b eq 49) {
		print 69;
	} elsif ($a eq 20 && $b eq 50) {
		print 70;
	} elsif ($a eq 21 && $b eq 0) {
		print 21;
	} elsif ($a eq 21 && $b eq 1) {
		print 22;
	} elsif ($a eq 21 && $b eq 2) {
		print 23;
	} elsif ($a eq 21 && $b eq 3) {
		print 24;
	} elsif ($a eq 21 && $b eq 4) {
		print 25;
	} elsif ($a eq 21 && $b eq 5) {
		print 26;
	} elsif ($a eq 21 && $b eq 6) {
		print 27;
	} elsif ($a eq 21 && $b eq 7) {
		print 28;
	} elsif ($a eq 21 && $b eq 8) {
		print 29;
	} elsif ($a eq 21 && $b eq 9) {
		print 30;
	} elsif ($a eq 21 && $b eq 10) {
		print 31;
	} elsif ($a eq 21 && $b eq 11) {
		print 32;
	} elsif ($a eq 21 && $b eq 12) {
		print 33;
	} elsif ($a eq 21 && $b eq 13) {
		print 34;
	} elsif ($a eq 21 && $b eq 14) {
		print 35;
	} elsif ($a eq 21 && $b eq 15) {
		print 36;
	} elsif ($a eq 21 && $b eq 16) {
		print 37;
	} elsif ($a eq 21 && $b eq 17) {
		print 38;
	} elsif ($a eq 21 && $b eq 18) {
		print 39;
	} elsif ($a eq 21 && $b eq 19) {
		print 40;
	} elsif ($a eq 21 && $b eq 20) {
		print 41;
	} elsif ($a eq 21 && $b eq 21) {
		print 42;
	} elsif ($a eq 21 && $b eq 22) {
		print 43;
	} elsif ($a eq 21 && $b eq 23) {
		print 44;
	} elsif ($a eq 21 && $b eq 24) {
		print 45;
	} elsif ($a eq 21 && $b eq 25) {
		print 46;
	} elsif ($a eq 21 && $b eq 26) {
		print 47;
	} elsif ($a eq 21 && $b eq 27) {
		print 48;
	} elsif ($a eq 21 && $b eq 28) {
		print 49;
	} elsif ($a eq 21 && $b eq 29) {
		print 50;
	} elsif ($a eq 21 && $b eq 30) {
		print 51;
	} elsif ($a eq 21 && $b eq 31) {
		print 52;
	} elsif ($a eq 21 && $b eq 32) {
		print 53;
	} elsif ($a eq 21 && $b eq 33) {
		print 54;
	} elsif ($a eq 21 && $b eq 34) {
		print 55;
	} elsif ($a eq 21 && $b eq 35) {
		print 56;
	} elsif ($a eq 21 && $b eq 36) {
		print 57;
	} elsif ($a eq 21 && $b eq 37) {
		print 58;
	} elsif ($a eq 21 && $b eq 38) {
		print 59;
	} elsif ($a eq 21 && $b eq 39) {
		print 60;
	} elsif ($a eq 21 && $b eq 40) {
		print 61;
	} elsif ($a eq 21 && $b eq 41) {
		print 62;
	} elsif ($a eq 21 && $b eq 42) {
		print 63;
	} elsif ($a eq 21 && $b eq 43) {
		print 64;
	} elsif ($a eq 21 && $b eq 44) {
		print 65;
	} elsif ($a eq 21 && $b eq 45) {
		print 66;
	} elsif ($a eq 21 && $b eq 46) {
		print 67;
	} elsif ($a eq 21 && $b eq 47) {
		print 68;
	} elsif ($a eq 21 && $b eq 48) {
		print 69;
	} elsif ($a eq 21 && $b eq 49) {
		print 70;
	} elsif ($a eq 21 && $b eq 50) {
		print 71;
	} elsif ($a eq 22 && $b eq 0) {
		print 22;
	} elsif ($a eq 22 && $b eq 1) {
		print 23;
	} elsif ($a eq 22 && $b eq 2) {
		print 24;
	} elsif ($a eq 22 && $b eq 3) {
		print 25;
	} elsif ($a eq 22 && $b eq 4) {
		print 26;
	} elsif ($a eq 22 && $b eq 5) {
		print 27;
	} elsif ($a eq 22 && $b eq 6) {
		print 28;
	} elsif ($a eq 22 && $b eq 7) {
		print 29;
	} elsif ($a eq 22 && $b eq 8) {
		print 30;
	} elsif ($a eq 22 && $b eq 9) {
		print 31;
	} elsif ($a eq 22 && $b eq 10) {
		print 32;
	} elsif ($a eq 22 && $b eq 11) {
		print 33;
	} elsif ($a eq 22 && $b eq 12) {
		print 34;
	} elsif ($a eq 22 && $b eq 13) {
		print 35;
	} elsif ($a eq 22 && $b eq 14) {
		print 36;
	} elsif ($a eq 22 && $b eq 15) {
		print 37;
	} elsif ($a eq 22 && $b eq 16) {
		print 38;
	} elsif ($a eq 22 && $b eq 17) {
		print 39;
	} elsif ($a eq 22 && $b eq 18) {
		print 40;
	} elsif ($a eq 22 && $b eq 19) {
		print 41;
	} elsif ($a eq 22 && $b eq 20) {
		print 42;
	} elsif ($a eq 22 && $b eq 21) {
		print 43;
	} elsif ($a eq 22 && $b eq 22) {
		print 44;
	} elsif ($a eq 22 && $b eq 23) {
		print 45;
	} elsif ($a eq 22 && $b eq 24) {
		print 46;
	} elsif ($a eq 22 && $b eq 25) {
		print 47;
	} elsif ($a eq 22 && $b eq 26) {
		print 48;
	} elsif ($a eq 22 && $b eq 27) {
		print 49;
	} elsif ($a eq 22 && $b eq 28) {
		print 50;
	} elsif ($a eq 22 && $b eq 29) {
		print 51;
	} elsif ($a eq 22 && $b eq 30) {
		print 52;
	} elsif ($a eq 22 && $b eq 31) {
		print 53;
	} elsif ($a eq 22 && $b eq 32) {
		print 54;
	} elsif ($a eq 22 && $b eq 33) {
		print 55;
	} elsif ($a eq 22 && $b eq 34) {
		print 56;
	} elsif ($a eq 22 && $b eq 35) {
		print 57;
	} elsif ($a eq 22 && $b eq 36) {
		print 58;
	} elsif ($a eq 22 && $b eq 37) {
		print 59;
	} elsif ($a eq 22 && $b eq 38) {
		print 60;
	} elsif ($a eq 22 && $b eq 39) {
		print 61;
	} elsif ($a eq 22 && $b eq 40) {
		print 62;
	} elsif ($a eq 22 && $b eq 41) {
		print 63;
	} elsif ($a eq 22 && $b eq 42) {
		print 64;
	} elsif ($a eq 22 && $b eq 43) {
		print 65;
	} elsif ($a eq 22 && $b eq 44) {
		print 66;
	} elsif ($a eq 22 && $b eq 45) {
		print 67;
	} elsif ($a eq 22 && $b eq 46) {
		print 68;
	} elsif ($a eq 22 && $b eq 47) {
		print 69;
	} elsif ($a eq 22 && $b eq 48) {
		print 70;
	} elsif ($a eq 22 && $b eq 49) {
		print 71;
	} elsif ($a eq 22 && $b eq 50) {
		print 72;
	} elsif ($a eq 23 && $b eq 0) {
		print 23;
	} elsif ($a eq 23 && $b eq 1) {
		print 24;
	} elsif ($a eq 23 && $b eq 2) {
		print 25;
	} elsif ($a eq 23 && $b eq 3) {
		print 26;
	} elsif ($a eq 23 && $b eq 4) {
		print 27;
	} elsif ($a eq 23 && $b eq 5) {
		print 28;
	} elsif ($a eq 23 && $b eq 6) {
		print 29;
	} elsif ($a eq 23 && $b eq 7) {
		print 30;
	} elsif ($a eq 23 && $b eq 8) {
		print 31;
	} elsif ($a eq 23 && $b eq 9) {
		print 32;
	} elsif ($a eq 23 && $b eq 10) {
		print 33;
	} elsif ($a eq 23 && $b eq 11) {
		print 34;
	} elsif ($a eq 23 && $b eq 12) {
		print 35;
	} elsif ($a eq 23 && $b eq 13) {
		print 36;
	} elsif ($a eq 23 && $b eq 14) {
		print 37;
	} elsif ($a eq 23 && $b eq 15) {
		print 38;
	} elsif ($a eq 23 && $b eq 16) {
		print 39;
	} elsif ($a eq 23 && $b eq 17) {
		print 40;
	} elsif ($a eq 23 && $b eq 18) {
		print 41;
	} elsif ($a eq 23 && $b eq 19) {
		print 42;
	} elsif ($a eq 23 && $b eq 20) {
		print 43;
	} elsif ($a eq 23 && $b eq 21) {
		print 44;
	} elsif ($a eq 23 && $b eq 22) {
		print 45;
	} elsif ($a eq 23 && $b eq 23) {
		print 46;
	} elsif ($a eq 23 && $b eq 24) {
		print 47;
	} elsif ($a eq 23 && $b eq 25) {
		print 48;
	} elsif ($a eq 23 && $b eq 26) {
		print 49;
	} elsif ($a eq 23 && $b eq 27) {
		print 50;
	} elsif ($a eq 23 && $b eq 28) {
		print 51;
	} elsif ($a eq 23 && $b eq 29) {
		print 52;
	} elsif ($a eq 23 && $b eq 30) {
		print 53;
	} elsif ($a eq 23 && $b eq 31) {
		print 54;
	} elsif ($a eq 23 && $b eq 32) {
		print 55;
	} elsif ($a eq 23 && $b eq 33) {
		print 56;
	} elsif ($a eq 23 && $b eq 34) {
		print 57;
	} elsif ($a eq 23 && $b eq 35) {
		print 58;
	} elsif ($a eq 23 && $b eq 36) {
		print 59;
	} elsif ($a eq 23 && $b eq 37) {
		print 60;
	} elsif ($a eq 23 && $b eq 38) {
		print 61;
	} elsif ($a eq 23 && $b eq 39) {
		print 62;
	} elsif ($a eq 23 && $b eq 40) {
		print 63;
	} elsif ($a eq 23 && $b eq 41) {
		print 64;
	} elsif ($a eq 23 && $b eq 42) {
		print 65;
	} elsif ($a eq 23 && $b eq 43) {
		print 66;
	} elsif ($a eq 23 && $b eq 44) {
		print 67;
	} elsif ($a eq 23 && $b eq 45) {
		print 68;
	} elsif ($a eq 23 && $b eq 46) {
		print 69;
	} elsif ($a eq 23 && $b eq 47) {
		print 70;
	} elsif ($a eq 23 && $b eq 48) {
		print 71;
	} elsif ($a eq 23 && $b eq 49) {
		print 72;
	} elsif ($a eq 23 && $b eq 50) {
		print 73;
	} elsif ($a eq 24 && $b eq 0) {
		print 24;
	} elsif ($a eq 24 && $b eq 1) {
		print 25;
	} elsif ($a eq 24 && $b eq 2) {
		print 26;
	} elsif ($a eq 24 && $b eq 3) {
		print 27;
	} elsif ($a eq 24 && $b eq 4) {
		print 28;
	} elsif ($a eq 24 && $b eq 5) {
		print 29;
	} elsif ($a eq 24 && $b eq 6) {
		print 30;
	} elsif ($a eq 24 && $b eq 7) {
		print 31;
	} elsif ($a eq 24 && $b eq 8) {
		print 32;
	} elsif ($a eq 24 && $b eq 9) {
		print 33;
	} elsif ($a eq 24 && $b eq 10) {
		print 34;
	} elsif ($a eq 24 && $b eq 11) {
		print 35;
	} elsif ($a eq 24 && $b eq 12) {
		print 36;
	} elsif ($a eq 24 && $b eq 13) {
		print 37;
	} elsif ($a eq 24 && $b eq 14) {
		print 38;
	} elsif ($a eq 24 && $b eq 15) {
		print 39;
	} elsif ($a eq 24 && $b eq 16) {
		print 40;
	} elsif ($a eq 24 && $b eq 17) {
		print 41;
	} elsif ($a eq 24 && $b eq 18) {
		print 42;
	} elsif ($a eq 24 && $b eq 19) {
		print 43;
	} elsif ($a eq 24 && $b eq 20) {
		print 44;
	} elsif ($a eq 24 && $b eq 21) {
		print 45;
	} elsif ($a eq 24 && $b eq 22) {
		print 46;
	} elsif ($a eq 24 && $b eq 23) {
		print 47;
	} elsif ($a eq 24 && $b eq 24) {
		print 48;
	} elsif ($a eq 24 && $b eq 25) {
		print 49;
	} elsif ($a eq 24 && $b eq 26) {
		print 50;
	} elsif ($a eq 24 && $b eq 27) {
		print 51;
	} elsif ($a eq 24 && $b eq 28) {
		print 52;
	} elsif ($a eq 24 && $b eq 29) {
		print 53;
	} elsif ($a eq 24 && $b eq 30) {
		print 54;
	} elsif ($a eq 24 && $b eq 31) {
		print 55;
	} elsif ($a eq 24 && $b eq 32) {
		print 56;
	} elsif ($a eq 24 && $b eq 33) {
		print 57;
	} elsif ($a eq 24 && $b eq 34) {
		print 58;
	} elsif ($a eq 24 && $b eq 35) {
		print 59;
	} elsif ($a eq 24 && $b eq 36) {
		print 60;
	} elsif ($a eq 24 && $b eq 37) {
		print 61;
	} elsif ($a eq 24 && $b eq 38) {
		print 62;
	} elsif ($a eq 24 && $b eq 39) {
		print 63;
	} elsif ($a eq 24 && $b eq 40) {
		print 64;
	} elsif ($a eq 24 && $b eq 41) {
		print 65;
	} elsif ($a eq 24 && $b eq 42) {
		print 66;
	} elsif ($a eq 24 && $b eq 43) {
		print 67;
	} elsif ($a eq 24 && $b eq 44) {
		print 68;
	} elsif ($a eq 24 && $b eq 45) {
		print 69;
	} elsif ($a eq 24 && $b eq 46) {
		print 70;
	} elsif ($a eq 24 && $b eq 47) {
		print 71;
	} elsif ($a eq 24 && $b eq 48) {
		print 72;
	} elsif ($a eq 24 && $b eq 49) {
		print 73;
	} elsif ($a eq 24 && $b eq 50) {
		print 74;
	} elsif ($a eq 25 && $b eq 0) {
		print 25;
	} elsif ($a eq 25 && $b eq 1) {
		print 26;
	} elsif ($a eq 25 && $b eq 2) {
		print 27;
	} elsif ($a eq 25 && $b eq 3) {
		print 28;
	} elsif ($a eq 25 && $b eq 4) {
		print 29;
	} elsif ($a eq 25 && $b eq 5) {
		print 30;
	} elsif ($a eq 25 && $b eq 6) {
		print 31;
	} elsif ($a eq 25 && $b eq 7) {
		print 32;
	} elsif ($a eq 25 && $b eq 8) {
		print 33;
	} elsif ($a eq 25 && $b eq 9) {
		print 34;
	} elsif ($a eq 25 && $b eq 10) {
		print 35;
	} elsif ($a eq 25 && $b eq 11) {
		print 36;
	} elsif ($a eq 25 && $b eq 12) {
		print 37;
	} elsif ($a eq 25 && $b eq 13) {
		print 38;
	} elsif ($a eq 25 && $b eq 14) {
		print 39;
	} elsif ($a eq 25 && $b eq 15) {
		print 40;
	} elsif ($a eq 25 && $b eq 16) {
		print 41;
	} elsif ($a eq 25 && $b eq 17) {
		print 42;
	} elsif ($a eq 25 && $b eq 18) {
		print 43;
	} elsif ($a eq 25 && $b eq 19) {
		print 44;
	} elsif ($a eq 25 && $b eq 20) {
		print 45;
	} elsif ($a eq 25 && $b eq 21) {
		print 46;
	} elsif ($a eq 25 && $b eq 22) {
		print 47;
	} elsif ($a eq 25 && $b eq 23) {
		print 48;
	} elsif ($a eq 25 && $b eq 24) {
		print 49;
	} elsif ($a eq 25 && $b eq 25) {
		print 50;
	} elsif ($a eq 25 && $b eq 26) {
		print 51;
	} elsif ($a eq 25 && $b eq 27) {
		print 52;
	} elsif ($a eq 25 && $b eq 28) {
		print 53;
	} elsif ($a eq 25 && $b eq 29) {
		print 54;
	} elsif ($a eq 25 && $b eq 30) {
		print 55;
	} elsif ($a eq 25 && $b eq 31) {
		print 56;
	} elsif ($a eq 25 && $b eq 32) {
		print 57;
	} elsif ($a eq 25 && $b eq 33) {
		print 58;
	} elsif ($a eq 25 && $b eq 34) {
		print 59;
	} elsif ($a eq 25 && $b eq 35) {
		print 60;
	} elsif ($a eq 25 && $b eq 36) {
		print 61;
	} elsif ($a eq 25 && $b eq 37) {
		print 62;
	} elsif ($a eq 25 && $b eq 38) {
		print 63;
	} elsif ($a eq 25 && $b eq 39) {
		print 64;
	} elsif ($a eq 25 && $b eq 40) {
		print 65;
	} elsif ($a eq 25 && $b eq 41) {
		print 66;
	} elsif ($a eq 25 && $b eq 42) {
		print 67;
	} elsif ($a eq 25 && $b eq 43) {
		print 68;
	} elsif ($a eq 25 && $b eq 44) {
		print 69;
	} elsif ($a eq 25 && $b eq 45) {
		print 70;
	} elsif ($a eq 25 && $b eq 46) {
		print 71;
	} elsif ($a eq 25 && $b eq 47) {
		print 72;
	} elsif ($a eq 25 && $b eq 48) {
		print 73;
	} elsif ($a eq 25 && $b eq 49) {
		print 74;
	} elsif ($a eq 25 && $b eq 50) {
		print 75;
	} elsif ($a eq 26 && $b eq 0) {
		print 26;
	} elsif ($a eq 26 && $b eq 1) {
		print 27;
	} elsif ($a eq 26 && $b eq 2) {
		print 28;
	} elsif ($a eq 26 && $b eq 3) {
		print 29;
	} elsif ($a eq 26 && $b eq 4) {
		print 30;
	} elsif ($a eq 26 && $b eq 5) {
		print 31;
	} elsif ($a eq 26 && $b eq 6) {
		print 32;
	} elsif ($a eq 26 && $b eq 7) {
		print 33;
	} elsif ($a eq 26 && $b eq 8) {
		print 34;
	} elsif ($a eq 26 && $b eq 9) {
		print 35;
	} elsif ($a eq 26 && $b eq 10) {
		print 36;
	} elsif ($a eq 26 && $b eq 11) {
		print 37;
	} elsif ($a eq 26 && $b eq 12) {
		print 38;
	} elsif ($a eq 26 && $b eq 13) {
		print 39;
	} elsif ($a eq 26 && $b eq 14) {
		print 40;
	} elsif ($a eq 26 && $b eq 15) {
		print 41;
	} elsif ($a eq 26 && $b eq 16) {
		print 42;
	} elsif ($a eq 26 && $b eq 17) {
		print 43;
	} elsif ($a eq 26 && $b eq 18) {
		print 44;
	} elsif ($a eq 26 && $b eq 19) {
		print 45;
	} elsif ($a eq 26 && $b eq 20) {
		print 46;
	} elsif ($a eq 26 && $b eq 21) {
		print 47;
	} elsif ($a eq 26 && $b eq 22) {
		print 48;
	} elsif ($a eq 26 && $b eq 23) {
		print 49;
	} elsif ($a eq 26 && $b eq 24) {
		print 50;
	} elsif ($a eq 26 && $b eq 25) {
		print 51;
	} elsif ($a eq 26 && $b eq 26) {
		print 52;
	} elsif ($a eq 26 && $b eq 27) {
		print 53;
	} elsif ($a eq 26 && $b eq 28) {
		print 54;
	} elsif ($a eq 26 && $b eq 29) {
		print 55;
	} elsif ($a eq 26 && $b eq 30) {
		print 56;
	} elsif ($a eq 26 && $b eq 31) {
		print 57;
	} elsif ($a eq 26 && $b eq 32) {
		print 58;
	} elsif ($a eq 26 && $b eq 33) {
		print 59;
	} elsif ($a eq 26 && $b eq 34) {
		print 60;
	} elsif ($a eq 26 && $b eq 35) {
		print 61;
	} elsif ($a eq 26 && $b eq 36) {
		print 62;
	} elsif ($a eq 26 && $b eq 37) {
		print 63;
	} elsif ($a eq 26 && $b eq 38) {
		print 64;
	} elsif ($a eq 26 && $b eq 39) {
		print 65;
	} elsif ($a eq 26 && $b eq 40) {
		print 66;
	} elsif ($a eq 26 && $b eq 41) {
		print 67;
	} elsif ($a eq 26 && $b eq 42) {
		print 68;
	} elsif ($a eq 26 && $b eq 43) {
		print 69;
	} elsif ($a eq 26 && $b eq 44) {
		print 70;
	} elsif ($a eq 26 && $b eq 45) {
		print 71;
	} elsif ($a eq 26 && $b eq 46) {
		print 72;
	} elsif ($a eq 26 && $b eq 47) {
		print 73;
	} elsif ($a eq 26 && $b eq 48) {
		print 74;
	} elsif ($a eq 26 && $b eq 49) {
		print 75;
	} elsif ($a eq 26 && $b eq 50) {
		print 76;
	} elsif ($a eq 27 && $b eq 0) {
		print 27;
	} elsif ($a eq 27 && $b eq 1) {
		print 28;
	} elsif ($a eq 27 && $b eq 2) {
		print 29;
	} elsif ($a eq 27 && $b eq 3) {
		print 30;
	} elsif ($a eq 27 && $b eq 4) {
		print 31;
	} elsif ($a eq 27 && $b eq 5) {
		print 32;
	} elsif ($a eq 27 && $b eq 6) {
		print 33;
	} elsif ($a eq 27 && $b eq 7) {
		print 34;
	} elsif ($a eq 27 && $b eq 8) {
		print 35;
	} elsif ($a eq 27 && $b eq 9) {
		print 36;
	} elsif ($a eq 27 && $b eq 10) {
		print 37;
	} elsif ($a eq 27 && $b eq 11) {
		print 38;
	} elsif ($a eq 27 && $b eq 12) {
		print 39;
	} elsif ($a eq 27 && $b eq 13) {
		print 40;
	} elsif ($a eq 27 && $b eq 14) {
		print 41;
	} elsif ($a eq 27 && $b eq 15) {
		print 42;
	} elsif ($a eq 27 && $b eq 16) {
		print 43;
	} elsif ($a eq 27 && $b eq 17) {
		print 44;
	} elsif ($a eq 27 && $b eq 18) {
		print 45;
	} elsif ($a eq 27 && $b eq 19) {
		print 46;
	} elsif ($a eq 27 && $b eq 20) {
		print 47;
	} elsif ($a eq 27 && $b eq 21) {
		print 48;
	} elsif ($a eq 27 && $b eq 22) {
		print 49;
	} elsif ($a eq 27 && $b eq 23) {
		print 50;
	} elsif ($a eq 27 && $b eq 24) {
		print 51;
	} elsif ($a eq 27 && $b eq 25) {
		print 52;
	} elsif ($a eq 27 && $b eq 26) {
		print 53;
	} elsif ($a eq 27 && $b eq 27) {
		print 54;
	} elsif ($a eq 27 && $b eq 28) {
		print 55;
	} elsif ($a eq 27 && $b eq 29) {
		print 56;
	} elsif ($a eq 27 && $b eq 30) {
		print 57;
	} elsif ($a eq 27 && $b eq 31) {
		print 58;
	} elsif ($a eq 27 && $b eq 32) {
		print 59;
	} elsif ($a eq 27 && $b eq 33) {
		print 60;
	} elsif ($a eq 27 && $b eq 34) {
		print 61;
	} elsif ($a eq 27 && $b eq 35) {
		print 62;
	} elsif ($a eq 27 && $b eq 36) {
		print 63;
	} elsif ($a eq 27 && $b eq 37) {
		print 64;
	} elsif ($a eq 27 && $b eq 38) {
		print 65;
	} elsif ($a eq 27 && $b eq 39) {
		print 66;
	} elsif ($a eq 27 && $b eq 40) {
		print 67;
	} elsif ($a eq 27 && $b eq 41) {
		print 68;
	} elsif ($a eq 27 && $b eq 42) {
		print 69;
	} elsif ($a eq 27 && $b eq 43) {
		print 70;
	} elsif ($a eq 27 && $b eq 44) {
		print 71;
	} elsif ($a eq 27 && $b eq 45) {
		print 72;
	} elsif ($a eq 27 && $b eq 46) {
		print 73;
	} elsif ($a eq 27 && $b eq 47) {
		print 74;
	} elsif ($a eq 27 && $b eq 48) {
		print 75;
	} elsif ($a eq 27 && $b eq 49) {
		print 76;
	} elsif ($a eq 27 && $b eq 50) {
		print 77;
	} elsif ($a eq 28 && $b eq 0) {
		print 28;
	} elsif ($a eq 28 && $b eq 1) {
		print 29;
	} elsif ($a eq 28 && $b eq 2) {
		print 30;
	} elsif ($a eq 28 && $b eq 3) {
		print 31;
	} elsif ($a eq 28 && $b eq 4) {
		print 32;
	} elsif ($a eq 28 && $b eq 5) {
		print 33;
	} elsif ($a eq 28 && $b eq 6) {
		print 34;
	} elsif ($a eq 28 && $b eq 7) {
		print 35;
	} elsif ($a eq 28 && $b eq 8) {
		print 36;
	} elsif ($a eq 28 && $b eq 9) {
		print 37;
	} elsif ($a eq 28 && $b eq 10) {
		print 38;
	} elsif ($a eq 28 && $b eq 11) {
		print 39;
	} elsif ($a eq 28 && $b eq 12) {
		print 40;
	} elsif ($a eq 28 && $b eq 13) {
		print 41;
	} elsif ($a eq 28 && $b eq 14) {
		print 42;
	} elsif ($a eq 28 && $b eq 15) {
		print 43;
	} elsif ($a eq 28 && $b eq 16) {
		print 44;
	} elsif ($a eq 28 && $b eq 17) {
		print 45;
	} elsif ($a eq 28 && $b eq 18) {
		print 46;
	} elsif ($a eq 28 && $b eq 19) {
		print 47;
	} elsif ($a eq 28 && $b eq 20) {
		print 48;
	} elsif ($a eq 28 && $b eq 21) {
		print 49;
	} elsif ($a eq 28 && $b eq 22) {
		print 50;
	} elsif ($a eq 28 && $b eq 23) {
		print 51;
	} elsif ($a eq 28 && $b eq 24) {
		print 52;
	} elsif ($a eq 28 && $b eq 25) {
		print 53;
	} elsif ($a eq 28 && $b eq 26) {
		print 54;
	} elsif ($a eq 28 && $b eq 27) {
		print 55;
	} elsif ($a eq 28 && $b eq 28) {
		print 56;
	} elsif ($a eq 28 && $b eq 29) {
		print 57;
	} elsif ($a eq 28 && $b eq 30) {
		print 58;
	} elsif ($a eq 28 && $b eq 31) {
		print 59;
	} elsif ($a eq 28 && $b eq 32) {
		print 60;
	} elsif ($a eq 28 && $b eq 33) {
		print 61;
	} elsif ($a eq 28 && $b eq 34) {
		print 62;
	} elsif ($a eq 28 && $b eq 35) {
		print 63;
	} elsif ($a eq 28 && $b eq 36) {
		print 64;
	} elsif ($a eq 28 && $b eq 37) {
		print 65;
	} elsif ($a eq 28 && $b eq 38) {
		print 66;
	} elsif ($a eq 28 && $b eq 39) {
		print 67;
	} elsif ($a eq 28 && $b eq 40) {
		print 68;
	} elsif ($a eq 28 && $b eq 41) {
		print 69;
	} elsif ($a eq 28 && $b eq 42) {
		print 70;
	} elsif ($a eq 28 && $b eq 43) {
		print 71;
	} elsif ($a eq 28 && $b eq 44) {
		print 72;
	} elsif ($a eq 28 && $b eq 45) {
		print 73;
	} elsif ($a eq 28 && $b eq 46) {
		print 74;
	} elsif ($a eq 28 && $b eq 47) {
		print 75;
	} elsif ($a eq 28 && $b eq 48) {
		print 76;
	} elsif ($a eq 28 && $b eq 49) {
		print 77;
	} elsif ($a eq 28 && $b eq 50) {
		print 78;
	} elsif ($a eq 29 && $b eq 0) {
		print 29;
	} elsif ($a eq 29 && $b eq 1) {
		print 30;
	} elsif ($a eq 29 && $b eq 2) {
		print 31;
	} elsif ($a eq 29 && $b eq 3) {
		print 32;
	} elsif ($a eq 29 && $b eq 4) {
		print 33;
	} elsif ($a eq 29 && $b eq 5) {
		print 34;
	} elsif ($a eq 29 && $b eq 6) {
		print 35;
	} elsif ($a eq 29 && $b eq 7) {
		print 36;
	} elsif ($a eq 29 && $b eq 8) {
		print 37;
	} elsif ($a eq 29 && $b eq 9) {
		print 38;
	} elsif ($a eq 29 && $b eq 10) {
		print 39;
	} elsif ($a eq 29 && $b eq 11) {
		print 40;
	} elsif ($a eq 29 && $b eq 12) {
		print 41;
	} elsif ($a eq 29 && $b eq 13) {
		print 42;
	} elsif ($a eq 29 && $b eq 14) {
		print 43;
	} elsif ($a eq 29 && $b eq 15) {
		print 44;
	} elsif ($a eq 29 && $b eq 16) {
		print 45;
	} elsif ($a eq 29 && $b eq 17) {
		print 46;
	} elsif ($a eq 29 && $b eq 18) {
		print 47;
	} elsif ($a eq 29 && $b eq 19) {
		print 48;
	} elsif ($a eq 29 && $b eq 20) {
		print 49;
	} elsif ($a eq 29 && $b eq 21) {
		print 50;
	} elsif ($a eq 29 && $b eq 22) {
		print 51;
	} elsif ($a eq 29 && $b eq 23) {
		print 52;
	} elsif ($a eq 29 && $b eq 24) {
		print 53;
	} elsif ($a eq 29 && $b eq 25) {
		print 54;
	} elsif ($a eq 29 && $b eq 26) {
		print 55;
	} elsif ($a eq 29 && $b eq 27) {
		print 56;
	} elsif ($a eq 29 && $b eq 28) {
		print 57;
	} elsif ($a eq 29 && $b eq 29) {
		print 58;
	} elsif ($a eq 29 && $b eq 30) {
		print 59;
	} elsif ($a eq 29 && $b eq 31) {
		print 60;
	} elsif ($a eq 29 && $b eq 32) {
		print 61;
	} elsif ($a eq 29 && $b eq 33) {
		print 62;
	} elsif ($a eq 29 && $b eq 34) {
		print 63;
	} elsif ($a eq 29 && $b eq 35) {
		print 64;
	} elsif ($a eq 29 && $b eq 36) {
		print 65;
	} elsif ($a eq 29 && $b eq 37) {
		print 66;
	} elsif ($a eq 29 && $b eq 38) {
		print 67;
	} elsif ($a eq 29 && $b eq 39) {
		print 68;
	} elsif ($a eq 29 && $b eq 40) {
		print 69;
	} elsif ($a eq 29 && $b eq 41) {
		print 70;
	} elsif ($a eq 29 && $b eq 42) {
		print 71;
	} elsif ($a eq 29 && $b eq 43) {
		print 72;
	} elsif ($a eq 29 && $b eq 44) {
		print 73;
	} elsif ($a eq 29 && $b eq 45) {
		print 74;
	} elsif ($a eq 29 && $b eq 46) {
		print 75;
	} elsif ($a eq 29 && $b eq 47) {
		print 76;
	} elsif ($a eq 29 && $b eq 48) {
		print 77;
	} elsif ($a eq 29 && $b eq 49) {
		print 78;
	} elsif ($a eq 29 && $b eq 50) {
		print 79;
	} elsif ($a eq 30 && $b eq 0) {
		print 30;
	} elsif ($a eq 30 && $b eq 1) {
		print 31;
	} elsif ($a eq 30 && $b eq 2) {
		print 32;
	} elsif ($a eq 30 && $b eq 3) {
		print 33;
	} elsif ($a eq 30 && $b eq 4) {
		print 34;
	} elsif ($a eq 30 && $b eq 5) {
		print 35;
	} elsif ($a eq 30 && $b eq 6) {
		print 36;
	} elsif ($a eq 30 && $b eq 7) {
		print 37;
	} elsif ($a eq 30 && $b eq 8) {
		print 38;
	} elsif ($a eq 30 && $b eq 9) {
		print 39;
	} elsif ($a eq 30 && $b eq 10) {
		print 40;
	} elsif ($a eq 30 && $b eq 11) {
		print 41;
	} elsif ($a eq 30 && $b eq 12) {
		print 42;
	} elsif ($a eq 30 && $b eq 13) {
		print 43;
	} elsif ($a eq 30 && $b eq 14) {
		print 44;
	} elsif ($a eq 30 && $b eq 15) {
		print 45;
	} elsif ($a eq 30 && $b eq 16) {
		print 46;
	} elsif ($a eq 30 && $b eq 17) {
		print 47;
	} elsif ($a eq 30 && $b eq 18) {
		print 48;
	} elsif ($a eq 30 && $b eq 19) {
		print 49;
	} elsif ($a eq 30 && $b eq 20) {
		print 50;
	} elsif ($a eq 30 && $b eq 21) {
		print 51;
	} elsif ($a eq 30 && $b eq 22) {
		print 52;
	} elsif ($a eq 30 && $b eq 23) {
		print 53;
	} elsif ($a eq 30 && $b eq 24) {
		print 54;
	} elsif ($a eq 30 && $b eq 25) {
		print 55;
	} elsif ($a eq 30 && $b eq 26) {
		print 56;
	} elsif ($a eq 30 && $b eq 27) {
		print 57;
	} elsif ($a eq 30 && $b eq 28) {
		print 58;
	} elsif ($a eq 30 && $b eq 29) {
		print 59;
	} elsif ($a eq 30 && $b eq 30) {
		print 60;
	} elsif ($a eq 30 && $b eq 31) {
		print 61;
	} elsif ($a eq 30 && $b eq 32) {
		print 62;
	} elsif ($a eq 30 && $b eq 33) {
		print 63;
	} elsif ($a eq 30 && $b eq 34) {
		print 64;
	} elsif ($a eq 30 && $b eq 35) {
		print 65;
	} elsif ($a eq 30 && $b eq 36) {
		print 66;
	} elsif ($a eq 30 && $b eq 37) {
		print 67;
	} elsif ($a eq 30 && $b eq 38) {
		print 68;
	} elsif ($a eq 30 && $b eq 39) {
		print 69;
	} elsif ($a eq 30 && $b eq 40) {
		print 70;
	} elsif ($a eq 30 && $b eq 41) {
		print 71;
	} elsif ($a eq 30 && $b eq 42) {
		print 72;
	} elsif ($a eq 30 && $b eq 43) {
		print 73;
	} elsif ($a eq 30 && $b eq 44) {
		print 74;
	} elsif ($a eq 30 && $b eq 45) {
		print 75;
	} elsif ($a eq 30 && $b eq 46) {
		print 76;
	} elsif ($a eq 30 && $b eq 47) {
		print 77;
	} elsif ($a eq 30 && $b eq 48) {
		print 78;
	} elsif ($a eq 30 && $b eq 49) {
		print 79;
	} elsif ($a eq 30 && $b eq 50) {
		print 80;
	} elsif ($a eq 31 && $b eq 0) {
		print 31;
	} elsif ($a eq 31 && $b eq 1) {
		print 32;
	} elsif ($a eq 31 && $b eq 2) {
		print 33;
	} elsif ($a eq 31 && $b eq 3) {
		print 34;
	} elsif ($a eq 31 && $b eq 4) {
		print 35;
	} elsif ($a eq 31 && $b eq 5) {
		print 36;
	} elsif ($a eq 31 && $b eq 6) {
		print 37;
	} elsif ($a eq 31 && $b eq 7) {
		print 38;
	} elsif ($a eq 31 && $b eq 8) {
		print 39;
	} elsif ($a eq 31 && $b eq 9) {
		print 40;
	} elsif ($a eq 31 && $b eq 10) {
		print 41;
	} elsif ($a eq 31 && $b eq 11) {
		print 42;
	} elsif ($a eq 31 && $b eq 12) {
		print 43;
	} elsif ($a eq 31 && $b eq 13) {
		print 44;
	} elsif ($a eq 31 && $b eq 14) {
		print 45;
	} elsif ($a eq 31 && $b eq 15) {
		print 46;
	} elsif ($a eq 31 && $b eq 16) {
		print 47;
	} elsif ($a eq 31 && $b eq 17) {
		print 48;
	} elsif ($a eq 31 && $b eq 18) {
		print 49;
	} elsif ($a eq 31 && $b eq 19) {
		print 50;
	} elsif ($a eq 31 && $b eq 20) {
		print 51;
	} elsif ($a eq 31 && $b eq 21) {
		print 52;
	} elsif ($a eq 31 && $b eq 22) {
		print 53;
	} elsif ($a eq 31 && $b eq 23) {
		print 54;
	} elsif ($a eq 31 && $b eq 24) {
		print 55;
	} elsif ($a eq 31 && $b eq 25) {
		print 56;
	} elsif ($a eq 31 && $b eq 26) {
		print 57;
	} elsif ($a eq 31 && $b eq 27) {
		print 58;
	} elsif ($a eq 31 && $b eq 28) {
		print 59;
	} elsif ($a eq 31 && $b eq 29) {
		print 60;
	} elsif ($a eq 31 && $b eq 30) {
		print 61;
	} elsif ($a eq 31 && $b eq 31) {
		print 62;
	} elsif ($a eq 31 && $b eq 32) {
		print 63;
	} elsif ($a eq 31 && $b eq 33) {
		print 64;
	} elsif ($a eq 31 && $b eq 34) {
		print 65;
	} elsif ($a eq 31 && $b eq 35) {
		print 66;
	} elsif ($a eq 31 && $b eq 36) {
		print 67;
	} elsif ($a eq 31 && $b eq 37) {
		print 68;
	} elsif ($a eq 31 && $b eq 38) {
		print 69;
	} elsif ($a eq 31 && $b eq 39) {
		print 70;
	} elsif ($a eq 31 && $b eq 40) {
		print 71;
	} elsif ($a eq 31 && $b eq 41) {
		print 72;
	} elsif ($a eq 31 && $b eq 42) {
		print 73;
	} elsif ($a eq 31 && $b eq 43) {
		print 74;
	} elsif ($a eq 31 && $b eq 44) {
		print 75;
	} elsif ($a eq 31 && $b eq 45) {
		print 76;
	} elsif ($a eq 31 && $b eq 46) {
		print 77;
	} elsif ($a eq 31 && $b eq 47) {
		print 78;
	} elsif ($a eq 31 && $b eq 48) {
		print 79;
	} elsif ($a eq 31 && $b eq 49) {
		print 80;
	} elsif ($a eq 31 && $b eq 50) {
		print 81;
	} elsif ($a eq 32 && $b eq 0) {
		print 32;
	} elsif ($a eq 32 && $b eq 1) {
		print 33;
	} elsif ($a eq 32 && $b eq 2) {
		print 34;
	} elsif ($a eq 32 && $b eq 3) {
		print 35;
	} elsif ($a eq 32 && $b eq 4) {
		print 36;
	} elsif ($a eq 32 && $b eq 5) {
		print 37;
	} elsif ($a eq 32 && $b eq 6) {
		print 38;
	} elsif ($a eq 32 && $b eq 7) {
		print 39;
	} elsif ($a eq 32 && $b eq 8) {
		print 40;
	} elsif ($a eq 32 && $b eq 9) {
		print 41;
	} elsif ($a eq 32 && $b eq 10) {
		print 42;
	} elsif ($a eq 32 && $b eq 11) {
		print 43;
	} elsif ($a eq 32 && $b eq 12) {
		print 44;
	} elsif ($a eq 32 && $b eq 13) {
		print 45;
	} elsif ($a eq 32 && $b eq 14) {
		print 46;
	} elsif ($a eq 32 && $b eq 15) {
		print 47;
	} elsif ($a eq 32 && $b eq 16) {
		print 48;
	} elsif ($a eq 32 && $b eq 17) {
		print 49;
	} elsif ($a eq 32 && $b eq 18) {
		print 50;
	} elsif ($a eq 32 && $b eq 19) {
		print 51;
	} elsif ($a eq 32 && $b eq 20) {
		print 52;
	} elsif ($a eq 32 && $b eq 21) {
		print 53;
	} elsif ($a eq 32 && $b eq 22) {
		print 54;
	} elsif ($a eq 32 && $b eq 23) {
		print 55;
	} elsif ($a eq 32 && $b eq 24) {
		print 56;
	} elsif ($a eq 32 && $b eq 25) {
		print 57;
	} elsif ($a eq 32 && $b eq 26) {
		print 58;
	} elsif ($a eq 32 && $b eq 27) {
		print 59;
	} elsif ($a eq 32 && $b eq 28) {
		print 60;
	} elsif ($a eq 32 && $b eq 29) {
		print 61;
	} elsif ($a eq 32 && $b eq 30) {
		print 62;
	} elsif ($a eq 32 && $b eq 31) {
		print 63;
	} elsif ($a eq 32 && $b eq 32) {
		print 64;
	} elsif ($a eq 32 && $b eq 33) {
		print 65;
	} elsif ($a eq 32 && $b eq 34) {
		print 66;
	} elsif ($a eq 32 && $b eq 35) {
		print 67;
	} elsif ($a eq 32 && $b eq 36) {
		print 68;
	} elsif ($a eq 32 && $b eq 37) {
		print 69;
	} elsif ($a eq 32 && $b eq 38) {
		print 70;
	} elsif ($a eq 32 && $b eq 39) {
		print 71;
	} elsif ($a eq 32 && $b eq 40) {
		print 72;
	} elsif ($a eq 32 && $b eq 41) {
		print 73;
	} elsif ($a eq 32 && $b eq 42) {
		print 74;
	} elsif ($a eq 32 && $b eq 43) {
		print 75;
	} elsif ($a eq 32 && $b eq 44) {
		print 76;
	} elsif ($a eq 32 && $b eq 45) {
		print 77;
	} elsif ($a eq 32 && $b eq 46) {
		print 78;
	} elsif ($a eq 32 && $b eq 47) {
		print 79;
	} elsif ($a eq 32 && $b eq 48) {
		print 80;
	} elsif ($a eq 32 && $b eq 49) {
		print 81;
	} elsif ($a eq 32 && $b eq 50) {
		print 82;
	} elsif ($a eq 33 && $b eq 0) {
		print 33;
	} elsif ($a eq 33 && $b eq 1) {
		print 34;
	} elsif ($a eq 33 && $b eq 2) {
		print 35;
	} elsif ($a eq 33 && $b eq 3) {
		print 36;
	} elsif ($a eq 33 && $b eq 4) {
		print 37;
	} elsif ($a eq 33 && $b eq 5) {
		print 38;
	} elsif ($a eq 33 && $b eq 6) {
		print 39;
	} elsif ($a eq 33 && $b eq 7) {
		print 40;
	} elsif ($a eq 33 && $b eq 8) {
		print 41;
	} elsif ($a eq 33 && $b eq 9) {
		print 42;
	} elsif ($a eq 33 && $b eq 10) {
		print 43;
	} elsif ($a eq 33 && $b eq 11) {
		print 44;
	} elsif ($a eq 33 && $b eq 12) {
		print 45;
	} elsif ($a eq 33 && $b eq 13) {
		print 46;
	} elsif ($a eq 33 && $b eq 14) {
		print 47;
	} elsif ($a eq 33 && $b eq 15) {
		print 48;
	} elsif ($a eq 33 && $b eq 16) {
		print 49;
	} elsif ($a eq 33 && $b eq 17) {
		print 50;
	} elsif ($a eq 33 && $b eq 18) {
		print 51;
	} elsif ($a eq 33 && $b eq 19) {
		print 52;
	} elsif ($a eq 33 && $b eq 20) {
		print 53;
	} elsif ($a eq 33 && $b eq 21) {
		print 54;
	} elsif ($a eq 33 && $b eq 22) {
		print 55;
	} elsif ($a eq 33 && $b eq 23) {
		print 56;
	} elsif ($a eq 33 && $b eq 24) {
		print 57;
	} elsif ($a eq 33 && $b eq 25) {
		print 58;
	} elsif ($a eq 33 && $b eq 26) {
		print 59;
	} elsif ($a eq 33 && $b eq 27) {
		print 60;
	} elsif ($a eq 33 && $b eq 28) {
		print 61;
	} elsif ($a eq 33 && $b eq 29) {
		print 62;
	} elsif ($a eq 33 && $b eq 30) {
		print 63;
	} elsif ($a eq 33 && $b eq 31) {
		print 64;
	} elsif ($a eq 33 && $b eq 32) {
		print 65;
	} elsif ($a eq 33 && $b eq 33) {
		print 66;
	} elsif ($a eq 33 && $b eq 34) {
		print 67;
	} elsif ($a eq 33 && $b eq 35) {
		print 68;
	} elsif ($a eq 33 && $b eq 36) {
		print 69;
	} elsif ($a eq 33 && $b eq 37) {
		print 70;
	} elsif ($a eq 33 && $b eq 38) {
		print 71;
	} elsif ($a eq 33 && $b eq 39) {
		print 72;
	} elsif ($a eq 33 && $b eq 40) {
		print 73;
	} elsif ($a eq 33 && $b eq 41) {
		print 74;
	} elsif ($a eq 33 && $b eq 42) {
		print 75;
	} elsif ($a eq 33 && $b eq 43) {
		print 76;
	} elsif ($a eq 33 && $b eq 44) {
		print 77;
	} elsif ($a eq 33 && $b eq 45) {
		print 78;
	} elsif ($a eq 33 && $b eq 46) {
		print 79;
	} elsif ($a eq 33 && $b eq 47) {
		print 80;
	} elsif ($a eq 33 && $b eq 48) {
		print 81;
	} elsif ($a eq 33 && $b eq 49) {
		print 82;
	} elsif ($a eq 33 && $b eq 50) {
		print 83;
	} elsif ($a eq 34 && $b eq 0) {
		print 34;
	} elsif ($a eq 34 && $b eq 1) {
		print 35;
	} elsif ($a eq 34 && $b eq 2) {
		print 36;
	} elsif ($a eq 34 && $b eq 3) {
		print 37;
	} elsif ($a eq 34 && $b eq 4) {
		print 38;
	} elsif ($a eq 34 && $b eq 5) {
		print 39;
	} elsif ($a eq 34 && $b eq 6) {
		print 40;
	} elsif ($a eq 34 && $b eq 7) {
		print 41;
	} elsif ($a eq 34 && $b eq 8) {
		print 42;
	} elsif ($a eq 34 && $b eq 9) {
		print 43;
	} elsif ($a eq 34 && $b eq 10) {
		print 44;
	} elsif ($a eq 34 && $b eq 11) {
		print 45;
	} elsif ($a eq 34 && $b eq 12) {
		print 46;
	} elsif ($a eq 34 && $b eq 13) {
		print 47;
	} elsif ($a eq 34 && $b eq 14) {
		print 48;
	} elsif ($a eq 34 && $b eq 15) {
		print 49;
	} elsif ($a eq 34 && $b eq 16) {
		print 50;
	} elsif ($a eq 34 && $b eq 17) {
		print 51;
	} elsif ($a eq 34 && $b eq 18) {
		print 52;
	} elsif ($a eq 34 && $b eq 19) {
		print 53;
	} elsif ($a eq 34 && $b eq 20) {
		print 54;
	} elsif ($a eq 34 && $b eq 21) {
		print 55;
	} elsif ($a eq 34 && $b eq 22) {
		print 56;
	} elsif ($a eq 34 && $b eq 23) {
		print 57;
	} elsif ($a eq 34 && $b eq 24) {
		print 58;
	} elsif ($a eq 34 && $b eq 25) {
		print 59;
	} elsif ($a eq 34 && $b eq 26) {
		print 60;
	} elsif ($a eq 34 && $b eq 27) {
		print 61;
	} elsif ($a eq 34 && $b eq 28) {
		print 62;
	} elsif ($a eq 34 && $b eq 29) {
		print 63;
	} elsif ($a eq 34 && $b eq 30) {
		print 64;
	} elsif ($a eq 34 && $b eq 31) {
		print 65;
	} elsif ($a eq 34 && $b eq 32) {
		print 66;
	} elsif ($a eq 34 && $b eq 33) {
		print 67;
	} elsif ($a eq 34 && $b eq 34) {
		print 68;
	} elsif ($a eq 34 && $b eq 35) {
		print 69;
	} elsif ($a eq 34 && $b eq 36) {
		print 70;
	} elsif ($a eq 34 && $b eq 37) {
		print 71;
	} elsif ($a eq 34 && $b eq 38) {
		print 72;
	} elsif ($a eq 34 && $b eq 39) {
		print 73;
	} elsif ($a eq 34 && $b eq 40) {
		print 74;
	} elsif ($a eq 34 && $b eq 41) {
		print 75;
	} elsif ($a eq 34 && $b eq 42) {
		print 76;
	} elsif ($a eq 34 && $b eq 43) {
		print 77;
	} elsif ($a eq 34 && $b eq 44) {
		print 78;
	} elsif ($a eq 34 && $b eq 45) {
		print 79;
	} elsif ($a eq 34 && $b eq 46) {
		print 80;
	} elsif ($a eq 34 && $b eq 47) {
		print 81;
	} elsif ($a eq 34 && $b eq 48) {
		print 82;
	} elsif ($a eq 34 && $b eq 49) {
		print 83;
	} elsif ($a eq 34 && $b eq 50) {
		print 84;
	} elsif ($a eq 35 && $b eq 0) {
		print 35;
	} elsif ($a eq 35 && $b eq 1) {
		print 36;
	} elsif ($a eq 35 && $b eq 2) {
		print 37;
	} elsif ($a eq 35 && $b eq 3) {
		print 38;
	} elsif ($a eq 35 && $b eq 4) {
		print 39;
	} elsif ($a eq 35 && $b eq 5) {
		print 40;
	} elsif ($a eq 35 && $b eq 6) {
		print 41;
	} elsif ($a eq 35 && $b eq 7) {
		print 42;
	} elsif ($a eq 35 && $b eq 8) {
		print 43;
	} elsif ($a eq 35 && $b eq 9) {
		print 44;
	} elsif ($a eq 35 && $b eq 10) {
		print 45;
	} elsif ($a eq 35 && $b eq 11) {
		print 46;
	} elsif ($a eq 35 && $b eq 12) {
		print 47;
	} elsif ($a eq 35 && $b eq 13) {
		print 48;
	} elsif ($a eq 35 && $b eq 14) {
		print 49;
	} elsif ($a eq 35 && $b eq 15) {
		print 50;
	} elsif ($a eq 35 && $b eq 16) {
		print 51;
	} elsif ($a eq 35 && $b eq 17) {
		print 52;
	} elsif ($a eq 35 && $b eq 18) {
		print 53;
	} elsif ($a eq 35 && $b eq 19) {
		print 54;
	} elsif ($a eq 35 && $b eq 20) {
		print 55;
	} elsif ($a eq 35 && $b eq 21) {
		print 56;
	} elsif ($a eq 35 && $b eq 22) {
		print 57;
	} elsif ($a eq 35 && $b eq 23) {
		print 58;
	} elsif ($a eq 35 && $b eq 24) {
		print 59;
	} elsif ($a eq 35 && $b eq 25) {
		print 60;
	} elsif ($a eq 35 && $b eq 26) {
		print 61;
	} elsif ($a eq 35 && $b eq 27) {
		print 62;
	} elsif ($a eq 35 && $b eq 28) {
		print 63;
	} elsif ($a eq 35 && $b eq 29) {
		print 64;
	} elsif ($a eq 35 && $b eq 30) {
		print 65;
	} elsif ($a eq 35 && $b eq 31) {
		print 66;
	} elsif ($a eq 35 && $b eq 32) {
		print 67;
	} elsif ($a eq 35 && $b eq 33) {
		print 68;
	} elsif ($a eq 35 && $b eq 34) {
		print 69;
	} elsif ($a eq 35 && $b eq 35) {
		print 70;
	} elsif ($a eq 35 && $b eq 36) {
		print 71;
	} elsif ($a eq 35 && $b eq 37) {
		print 72;
	} elsif ($a eq 35 && $b eq 38) {
		print 73;
	} elsif ($a eq 35 && $b eq 39) {
		print 74;
	} elsif ($a eq 35 && $b eq 40) {
		print 75;
	} elsif ($a eq 35 && $b eq 41) {
		print 76;
	} elsif ($a eq 35 && $b eq 42) {
		print 77;
	} elsif ($a eq 35 && $b eq 43) {
		print 78;
	} elsif ($a eq 35 && $b eq 44) {
		print 79;
	} elsif ($a eq 35 && $b eq 45) {
		print 80;
	} elsif ($a eq 35 && $b eq 46) {
		print 81;
	} elsif ($a eq 35 && $b eq 47) {
		print 82;
	} elsif ($a eq 35 && $b eq 48) {
		print 83;
	} elsif ($a eq 35 && $b eq 49) {
		print 84;
	} elsif ($a eq 35 && $b eq 50) {
		print 85;
	} elsif ($a eq 36 && $b eq 0) {
		print 36;
	} elsif ($a eq 36 && $b eq 1) {
		print 37;
	} elsif ($a eq 36 && $b eq 2) {
		print 38;
	} elsif ($a eq 36 && $b eq 3) {
		print 39;
	} elsif ($a eq 36 && $b eq 4) {
		print 40;
	} elsif ($a eq 36 && $b eq 5) {
		print 41;
	} elsif ($a eq 36 && $b eq 6) {
		print 42;
	} elsif ($a eq 36 && $b eq 7) {
		print 43;
	} elsif ($a eq 36 && $b eq 8) {
		print 44;
	} elsif ($a eq 36 && $b eq 9) {
		print 45;
	} elsif ($a eq 36 && $b eq 10) {
		print 46;
	} elsif ($a eq 36 && $b eq 11) {
		print 47;
	} elsif ($a eq 36 && $b eq 12) {
		print 48;
	} elsif ($a eq 36 && $b eq 13) {
		print 49;
	} elsif ($a eq 36 && $b eq 14) {
		print 50;
	} elsif ($a eq 36 && $b eq 15) {
		print 51;
	} elsif ($a eq 36 && $b eq 16) {
		print 52;
	} elsif ($a eq 36 && $b eq 17) {
		print 53;
	} elsif ($a eq 36 && $b eq 18) {
		print 54;
	} elsif ($a eq 36 && $b eq 19) {
		print 55;
	} elsif ($a eq 36 && $b eq 20) {
		print 56;
	} elsif ($a eq 36 && $b eq 21) {
		print 57;
	} elsif ($a eq 36 && $b eq 22) {
		print 58;
	} elsif ($a eq 36 && $b eq 23) {
		print 59;
	} elsif ($a eq 36 && $b eq 24) {
		print 60;
	} elsif ($a eq 36 && $b eq 25) {
		print 61;
	} elsif ($a eq 36 && $b eq 26) {
		print 62;
	} elsif ($a eq 36 && $b eq 27) {
		print 63;
	} elsif ($a eq 36 && $b eq 28) {
		print 64;
	} elsif ($a eq 36 && $b eq 29) {
		print 65;
	} elsif ($a eq 36 && $b eq 30) {
		print 66;
	} elsif ($a eq 36 && $b eq 31) {
		print 67;
	} elsif ($a eq 36 && $b eq 32) {
		print 68;
	} elsif ($a eq 36 && $b eq 33) {
		print 69;
	} elsif ($a eq 36 && $b eq 34) {
		print 70;
	} elsif ($a eq 36 && $b eq 35) {
		print 71;
	} elsif ($a eq 36 && $b eq 36) {
		print 72;
	} elsif ($a eq 36 && $b eq 37) {
		print 73;
	} elsif ($a eq 36 && $b eq 38) {
		print 74;
	} elsif ($a eq 36 && $b eq 39) {
		print 75;
	} elsif ($a eq 36 && $b eq 40) {
		print 76;
	} elsif ($a eq 36 && $b eq 41) {
		print 77;
	} elsif ($a eq 36 && $b eq 42) {
		print 78;
	} elsif ($a eq 36 && $b eq 43) {
		print 79;
	} elsif ($a eq 36 && $b eq 44) {
		print 80;
	} elsif ($a eq 36 && $b eq 45) {
		print 81;
	} elsif ($a eq 36 && $b eq 46) {
		print 82;
	} elsif ($a eq 36 && $b eq 47) {
		print 83;
	} elsif ($a eq 36 && $b eq 48) {
		print 84;
	} elsif ($a eq 36 && $b eq 49) {
		print 85;
	} elsif ($a eq 36 && $b eq 50) {
		print 86;
	} elsif ($a eq 37 && $b eq 0) {
		print 37;
	} elsif ($a eq 37 && $b eq 1) {
		print 38;
	} elsif ($a eq 37 && $b eq 2) {
		print 39;
	} elsif ($a eq 37 && $b eq 3) {
		print 40;
	} elsif ($a eq 37 && $b eq 4) {
		print 41;
	} elsif ($a eq 37 && $b eq 5) {
		print 42;
	} elsif ($a eq 37 && $b eq 6) {
		print 43;
	} elsif ($a eq 37 && $b eq 7) {
		print 44;
	} elsif ($a eq 37 && $b eq 8) {
		print 45;
	} elsif ($a eq 37 && $b eq 9) {
		print 46;
	} elsif ($a eq 37 && $b eq 10) {
		print 47;
	} elsif ($a eq 37 && $b eq 11) {
		print 48;
	} elsif ($a eq 37 && $b eq 12) {
		print 49;
	} elsif ($a eq 37 && $b eq 13) {
		print 50;
	} elsif ($a eq 37 && $b eq 14) {
		print 51;
	} elsif ($a eq 37 && $b eq 15) {
		print 52;
	} elsif ($a eq 37 && $b eq 16) {
		print 53;
	} elsif ($a eq 37 && $b eq 17) {
		print 54;
	} elsif ($a eq 37 && $b eq 18) {
		print 55;
	} elsif ($a eq 37 && $b eq 19) {
		print 56;
	} elsif ($a eq 37 && $b eq 20) {
		print 57;
	} elsif ($a eq 37 && $b eq 21) {
		print 58;
	} elsif ($a eq 37 && $b eq 22) {
		print 59;
	} elsif ($a eq 37 && $b eq 23) {
		print 60;
	} elsif ($a eq 37 && $b eq 24) {
		print 61;
	} elsif ($a eq 37 && $b eq 25) {
		print 62;
	} elsif ($a eq 37 && $b eq 26) {
		print 63;
	} elsif ($a eq 37 && $b eq 27) {
		print 64;
	} elsif ($a eq 37 && $b eq 28) {
		print 65;
	} elsif ($a eq 37 && $b eq 29) {
		print 66;
	} elsif ($a eq 37 && $b eq 30) {
		print 67;
	} elsif ($a eq 37 && $b eq 31) {
		print 68;
	} elsif ($a eq 37 && $b eq 32) {
		print 69;
	} elsif ($a eq 37 && $b eq 33) {
		print 70;
	} elsif ($a eq 37 && $b eq 34) {
		print 71;
	} elsif ($a eq 37 && $b eq 35) {
		print 72;
	} elsif ($a eq 37 && $b eq 36) {
		print 73;
	} elsif ($a eq 37 && $b eq 37) {
		print 74;
	} elsif ($a eq 37 && $b eq 38) {
		print 75;
	} elsif ($a eq 37 && $b eq 39) {
		print 76;
	} elsif ($a eq 37 && $b eq 40) {
		print 77;
	} elsif ($a eq 37 && $b eq 41) {
		print 78;
	} elsif ($a eq 37 && $b eq 42) {
		print 79;
	} elsif ($a eq 37 && $b eq 43) {
		print 80;
	} elsif ($a eq 37 && $b eq 44) {
		print 81;
	} elsif ($a eq 37 && $b eq 45) {
		print 82;
	} elsif ($a eq 37 && $b eq 46) {
		print 83;
	} elsif ($a eq 37 && $b eq 47) {
		print 84;
	} elsif ($a eq 37 && $b eq 48) {
		print 85;
	} elsif ($a eq 37 && $b eq 49) {
		print 86;
	} elsif ($a eq 37 && $b eq 50) {
		print 87;
	} elsif ($a eq 38 && $b eq 0) {
		print 38;
	} elsif ($a eq 38 && $b eq 1) {
		print 39;
	} elsif ($a eq 38 && $b eq 2) {
		print 40;
	} elsif ($a eq 38 && $b eq 3) {
		print 41;
	} elsif ($a eq 38 && $b eq 4) {
		print 42;
	} elsif ($a eq 38 && $b eq 5) {
		print 43;
	} elsif ($a eq 38 && $b eq 6) {
		print 44;
	} elsif ($a eq 38 && $b eq 7) {
		print 45;
	} elsif ($a eq 38 && $b eq 8) {
		print 46;
	} elsif ($a eq 38 && $b eq 9) {
		print 47;
	} elsif ($a eq 38 && $b eq 10) {
		print 48;
	} elsif ($a eq 38 && $b eq 11) {
		print 49;
	} elsif ($a eq 38 && $b eq 12) {
		print 50;
	} elsif ($a eq 38 && $b eq 13) {
		print 51;
	} elsif ($a eq 38 && $b eq 14) {
		print 52;
	} elsif ($a eq 38 && $b eq 15) {
		print 53;
	} elsif ($a eq 38 && $b eq 16) {
		print 54;
	} elsif ($a eq 38 && $b eq 17) {
		print 55;
	} elsif ($a eq 38 && $b eq 18) {
		print 56;
	} elsif ($a eq 38 && $b eq 19) {
		print 57;
	} elsif ($a eq 38 && $b eq 20) {
		print 58;
	} elsif ($a eq 38 && $b eq 21) {
		print 59;
	} elsif ($a eq 38 && $b eq 22) {
		print 60;
	} elsif ($a eq 38 && $b eq 23) {
		print 61;
	} elsif ($a eq 38 && $b eq 24) {
		print 62;
	} elsif ($a eq 38 && $b eq 25) {
		print 63;
	} elsif ($a eq 38 && $b eq 26) {
		print 64;
	} elsif ($a eq 38 && $b eq 27) {
		print 65;
	} elsif ($a eq 38 && $b eq 28) {
		print 66;
	} elsif ($a eq 38 && $b eq 29) {
		print 67;
	} elsif ($a eq 38 && $b eq 30) {
		print 68;
	} elsif ($a eq 38 && $b eq 31) {
		print 69;
	} elsif ($a eq 38 && $b eq 32) {
		print 70;
	} elsif ($a eq 38 && $b eq 33) {
		print 71;
	} elsif ($a eq 38 && $b eq 34) {
		print 72;
	} elsif ($a eq 38 && $b eq 35) {
		print 73;
	} elsif ($a eq 38 && $b eq 36) {
		print 74;
	} elsif ($a eq 38 && $b eq 37) {
		print 75;
	} elsif ($a eq 38 && $b eq 38) {
		print 76;
	} elsif ($a eq 38 && $b eq 39) {
		print 77;
	} elsif ($a eq 38 && $b eq 40) {
		print 78;
	} elsif ($a eq 38 && $b eq 41) {
		print 79;
	} elsif ($a eq 38 && $b eq 42) {
		print 80;
	} elsif ($a eq 38 && $b eq 43) {
		print 81;
	} elsif ($a eq 38 && $b eq 44) {
		print 82;
	} elsif ($a eq 38 && $b eq 45) {
		print 83;
	} elsif ($a eq 38 && $b eq 46) {
		print 84;
	} elsif ($a eq 38 && $b eq 47) {
		print 85;
	} elsif ($a eq 38 && $b eq 48) {
		print 86;
	} elsif ($a eq 38 && $b eq 49) {
		print 87;
	} elsif ($a eq 38 && $b eq 50) {
		print 88;
	} elsif ($a eq 39 && $b eq 0) {
		print 39;
	} elsif ($a eq 39 && $b eq 1) {
		print 40;
	} elsif ($a eq 39 && $b eq 2) {
		print 41;
	} elsif ($a eq 39 && $b eq 3) {
		print 42;
	} elsif ($a eq 39 && $b eq 4) {
		print 43;
	} elsif ($a eq 39 && $b eq 5) {
		print 44;
	} elsif ($a eq 39 && $b eq 6) {
		print 45;
	} elsif ($a eq 39 && $b eq 7) {
		print 46;
	} elsif ($a eq 39 && $b eq 8) {
		print 47;
	} elsif ($a eq 39 && $b eq 9) {
		print 48;
	} elsif ($a eq 39 && $b eq 10) {
		print 49;
	} elsif ($a eq 39 && $b eq 11) {
		print 50;
	} elsif ($a eq 39 && $b eq 12) {
		print 51;
	} elsif ($a eq 39 && $b eq 13) {
		print 52;
	} elsif ($a eq 39 && $b eq 14) {
		print 53;
	} elsif ($a eq 39 && $b eq 15) {
		print 54;
	} elsif ($a eq 39 && $b eq 16) {
		print 55;
	} elsif ($a eq 39 && $b eq 17) {
		print 56;
	} elsif ($a eq 39 && $b eq 18) {
		print 57;
	} elsif ($a eq 39 && $b eq 19) {
		print 58;
	} elsif ($a eq 39 && $b eq 20) {
		print 59;
	} elsif ($a eq 39 && $b eq 21) {
		print 60;
	} elsif ($a eq 39 && $b eq 22) {
		print 61;
	} elsif ($a eq 39 && $b eq 23) {
		print 62;
	} elsif ($a eq 39 && $b eq 24) {
		print 63;
	} elsif ($a eq 39 && $b eq 25) {
		print 64;
	} elsif ($a eq 39 && $b eq 26) {
		print 65;
	} elsif ($a eq 39 && $b eq 27) {
		print 66;
	} elsif ($a eq 39 && $b eq 28) {
		print 67;
	} elsif ($a eq 39 && $b eq 29) {
		print 68;
	} elsif ($a eq 39 && $b eq 30) {
		print 69;
	} elsif ($a eq 39 && $b eq 31) {
		print 70;
	} elsif ($a eq 39 && $b eq 32) {
		print 71;
	} elsif ($a eq 39 && $b eq 33) {
		print 72;
	} elsif ($a eq 39 && $b eq 34) {
		print 73;
	} elsif ($a eq 39 && $b eq 35) {
		print 74;
	} elsif ($a eq 39 && $b eq 36) {
		print 75;
	} elsif ($a eq 39 && $b eq 37) {
		print 76;
	} elsif ($a eq 39 && $b eq 38) {
		print 77;
	} elsif ($a eq 39 && $b eq 39) {
		print 78;
	} elsif ($a eq 39 && $b eq 40) {
		print 79;
	} elsif ($a eq 39 && $b eq 41) {
		print 80;
	} elsif ($a eq 39 && $b eq 42) {
		print 81;
	} elsif ($a eq 39 && $b eq 43) {
		print 82;
	} elsif ($a eq 39 && $b eq 44) {
		print 83;
	} elsif ($a eq 39 && $b eq 45) {
		print 84;
	} elsif ($a eq 39 && $b eq 46) {
		print 85;
	} elsif ($a eq 39 && $b eq 47) {
		print 86;
	} elsif ($a eq 39 && $b eq 48) {
		print 87;
	} elsif ($a eq 39 && $b eq 49) {
		print 88;
	} elsif ($a eq 39 && $b eq 50) {
		print 89;
	} elsif ($a eq 40 && $b eq 0) {
		print 40;
	} elsif ($a eq 40 && $b eq 1) {
		print 41;
	} elsif ($a eq 40 && $b eq 2) {
		print 42;
	} elsif ($a eq 40 && $b eq 3) {
		print 43;
	} elsif ($a eq 40 && $b eq 4) {
		print 44;
	} elsif ($a eq 40 && $b eq 5) {
		print 45;
	} elsif ($a eq 40 && $b eq 6) {
		print 46;
	} elsif ($a eq 40 && $b eq 7) {
		print 47;
	} elsif ($a eq 40 && $b eq 8) {
		print 48;
	} elsif ($a eq 40 && $b eq 9) {
		print 49;
	} elsif ($a eq 40 && $b eq 10) {
		print 50;
	} elsif ($a eq 40 && $b eq 11) {
		print 51;
	} elsif ($a eq 40 && $b eq 12) {
		print 52;
	} elsif ($a eq 40 && $b eq 13) {
		print 53;
	} elsif ($a eq 40 && $b eq 14) {
		print 54;
	} elsif ($a eq 40 && $b eq 15) {
		print 55;
	} elsif ($a eq 40 && $b eq 16) {
		print 56;
	} elsif ($a eq 40 && $b eq 17) {
		print 57;
	} elsif ($a eq 40 && $b eq 18) {
		print 58;
	} elsif ($a eq 40 && $b eq 19) {
		print 59;
	} elsif ($a eq 40 && $b eq 20) {
		print 60;
	} elsif ($a eq 40 && $b eq 21) {
		print 61;
	} elsif ($a eq 40 && $b eq 22) {
		print 62;
	} elsif ($a eq 40 && $b eq 23) {
		print 63;
	} elsif ($a eq 40 && $b eq 24) {
		print 64;
	} elsif ($a eq 40 && $b eq 25) {
		print 65;
	} elsif ($a eq 40 && $b eq 26) {
		print 66;
	} elsif ($a eq 40 && $b eq 27) {
		print 67;
	} elsif ($a eq 40 && $b eq 28) {
		print 68;
	} elsif ($a eq 40 && $b eq 29) {
		print 69;
	} elsif ($a eq 40 && $b eq 30) {
		print 70;
	} elsif ($a eq 40 && $b eq 31) {
		print 71;
	} elsif ($a eq 40 && $b eq 32) {
		print 72;
	} elsif ($a eq 40 && $b eq 33) {
		print 73;
	} elsif ($a eq 40 && $b eq 34) {
		print 74;
	} elsif ($a eq 40 && $b eq 35) {
		print 75;
	} elsif ($a eq 40 && $b eq 36) {
		print 76;
	} elsif ($a eq 40 && $b eq 37) {
		print 77;
	} elsif ($a eq 40 && $b eq 38) {
		print 78;
	} elsif ($a eq 40 && $b eq 39) {
		print 79;
	} elsif ($a eq 40 && $b eq 40) {
		print 80;
	} elsif ($a eq 40 && $b eq 41) {
		print 81;
	} elsif ($a eq 40 && $b eq 42) {
		print 82;
	} elsif ($a eq 40 && $b eq 43) {
		print 83;
	} elsif ($a eq 40 && $b eq 44) {
		print 84;
	} elsif ($a eq 40 && $b eq 45) {
		print 85;
	} elsif ($a eq 40 && $b eq 46) {
		print 86;
	} elsif ($a eq 40 && $b eq 47) {
		print 87;
	} elsif ($a eq 40 && $b eq 48) {
		print 88;
	} elsif ($a eq 40 && $b eq 49) {
		print 89;
	} elsif ($a eq 40 && $b eq 50) {
		print 90;
	} elsif ($a eq 41 && $b eq 0) {
		print 41;
	} elsif ($a eq 41 && $b eq 1) {
		print 42;
	} elsif ($a eq 41 && $b eq 2) {
		print 43;
	} elsif ($a eq 41 && $b eq 3) {
		print 44;
	} elsif ($a eq 41 && $b eq 4) {
		print 45;
	} elsif ($a eq 41 && $b eq 5) {
		print 46;
	} elsif ($a eq 41 && $b eq 6) {
		print 47;
	} elsif ($a eq 41 && $b eq 7) {
		print 48;
	} elsif ($a eq 41 && $b eq 8) {
		print 49;
	} elsif ($a eq 41 && $b eq 9) {
		print 50;
	} elsif ($a eq 41 && $b eq 10) {
		print 51;
	} elsif ($a eq 41 && $b eq 11) {
		print 52;
	} elsif ($a eq 41 && $b eq 12) {
		print 53;
	} elsif ($a eq 41 && $b eq 13) {
		print 54;
	} elsif ($a eq 41 && $b eq 14) {
		print 55;
	} elsif ($a eq 41 && $b eq 15) {
		print 56;
	} elsif ($a eq 41 && $b eq 16) {
		print 57;
	} elsif ($a eq 41 && $b eq 17) {
		print 58;
	} elsif ($a eq 41 && $b eq 18) {
		print 59;
	} elsif ($a eq 41 && $b eq 19) {
		print 60;
	} elsif ($a eq 41 && $b eq 20) {
		print 61;
	} elsif ($a eq 41 && $b eq 21) {
		print 62;
	} elsif ($a eq 41 && $b eq 22) {
		print 63;
	} elsif ($a eq 41 && $b eq 23) {
		print 64;
	} elsif ($a eq 41 && $b eq 24) {
		print 65;
	} elsif ($a eq 41 && $b eq 25) {
		print 66;
	} elsif ($a eq 41 && $b eq 26) {
		print 67;
	} elsif ($a eq 41 && $b eq 27) {
		print 68;
	} elsif ($a eq 41 && $b eq 28) {
		print 69;
	} elsif ($a eq 41 && $b eq 29) {
		print 70;
	} elsif ($a eq 41 && $b eq 30) {
		print 71;
	} elsif ($a eq 41 && $b eq 31) {
		print 72;
	} elsif ($a eq 41 && $b eq 32) {
		print 73;
	} elsif ($a eq 41 && $b eq 33) {
		print 74;
	} elsif ($a eq 41 && $b eq 34) {
		print 75;
	} elsif ($a eq 41 && $b eq 35) {
		print 76;
	} elsif ($a eq 41 && $b eq 36) {
		print 77;
	} elsif ($a eq 41 && $b eq 37) {
		print 78;
	} elsif ($a eq 41 && $b eq 38) {
		print 79;
	} elsif ($a eq 41 && $b eq 39) {
		print 80;
	} elsif ($a eq 41 && $b eq 40) {
		print 81;
	} elsif ($a eq 41 && $b eq 41) {
		print 82;
	} elsif ($a eq 41 && $b eq 42) {
		print 83;
	} elsif ($a eq 41 && $b eq 43) {
		print 84;
	} elsif ($a eq 41 && $b eq 44) {
		print 85;
	} elsif ($a eq 41 && $b eq 45) {
		print 86;
	} elsif ($a eq 41 && $b eq 46) {
		print 87;
	} elsif ($a eq 41 && $b eq 47) {
		print 88;
	} elsif ($a eq 41 && $b eq 48) {
		print 89;
	} elsif ($a eq 41 && $b eq 49) {
		print 90;
	} elsif ($a eq 41 && $b eq 50) {
		print 91;
	} elsif ($a eq 42 && $b eq 0) {
		print 42;
	} elsif ($a eq 42 && $b eq 1) {
		print 43;
	} elsif ($a eq 42 && $b eq 2) {
		print 44;
	} elsif ($a eq 42 && $b eq 3) {
		print 45;
	} elsif ($a eq 42 && $b eq 4) {
		print 46;
	} elsif ($a eq 42 && $b eq 5) {
		print 47;
	} elsif ($a eq 42 && $b eq 6) {
		print 48;
	} elsif ($a eq 42 && $b eq 7) {
		print 49;
	} elsif ($a eq 42 && $b eq 8) {
		print 50;
	} elsif ($a eq 42 && $b eq 9) {
		print 51;
	} elsif ($a eq 42 && $b eq 10) {
		print 52;
	} elsif ($a eq 42 && $b eq 11) {
		print 53;
	} elsif ($a eq 42 && $b eq 12) {
		print 54;
	} elsif ($a eq 42 && $b eq 13) {
		print 55;
	} elsif ($a eq 42 && $b eq 14) {
		print 56;
	} elsif ($a eq 42 && $b eq 15) {
		print 57;
	} elsif ($a eq 42 && $b eq 16) {
		print 58;
	} elsif ($a eq 42 && $b eq 17) {
		print 59;
	} elsif ($a eq 42 && $b eq 18) {
		print 60;
	} elsif ($a eq 42 && $b eq 19) {
		print 61;
	} elsif ($a eq 42 && $b eq 20) {
		print 62;
	} elsif ($a eq 42 && $b eq 21) {
		print 63;
	} elsif ($a eq 42 && $b eq 22) {
		print 64;
	} elsif ($a eq 42 && $b eq 23) {
		print 65;
	} elsif ($a eq 42 && $b eq 24) {
		print 66;
	} elsif ($a eq 42 && $b eq 25) {
		print 67;
	} elsif ($a eq 42 && $b eq 26) {
		print 68;
	} elsif ($a eq 42 && $b eq 27) {
		print 69;
	} elsif ($a eq 42 && $b eq 28) {
		print 70;
	} elsif ($a eq 42 && $b eq 29) {
		print 71;
	} elsif ($a eq 42 && $b eq 30) {
		print 72;
	} elsif ($a eq 42 && $b eq 31) {
		print 73;
	} elsif ($a eq 42 && $b eq 32) {
		print 74;
	} elsif ($a eq 42 && $b eq 33) {
		print 75;
	} elsif ($a eq 42 && $b eq 34) {
		print 76;
	} elsif ($a eq 42 && $b eq 35) {
		print 77;
	} elsif ($a eq 42 && $b eq 36) {
		print 78;
	} elsif ($a eq 42 && $b eq 37) {
		print 79;
	} elsif ($a eq 42 && $b eq 38) {
		print 80;
	} elsif ($a eq 42 && $b eq 39) {
		print 81;
	} elsif ($a eq 42 && $b eq 40) {
		print 82;
	} elsif ($a eq 42 && $b eq 41) {
		print 83;
	} elsif ($a eq 42 && $b eq 42) {
		print 84;
	} elsif ($a eq 42 && $b eq 43) {
		print 85;
	} elsif ($a eq 42 && $b eq 44) {
		print 86;
	} elsif ($a eq 42 && $b eq 45) {
		print 87;
	} elsif ($a eq 42 && $b eq 46) {
		print 88;
	} elsif ($a eq 42 && $b eq 47) {
		print 89;
	} elsif ($a eq 42 && $b eq 48) {
		print 90;
	} elsif ($a eq 42 && $b eq 49) {
		print 91;
	} elsif ($a eq 42 && $b eq 50) {
		print 92;
	} elsif ($a eq 43 && $b eq 0) {
		print 43;
	} elsif ($a eq 43 && $b eq 1) {
		print 44;
	} elsif ($a eq 43 && $b eq 2) {
		print 45;
	} elsif ($a eq 43 && $b eq 3) {
		print 46;
	} elsif ($a eq 43 && $b eq 4) {
		print 47;
	} elsif ($a eq 43 && $b eq 5) {
		print 48;
	} elsif ($a eq 43 && $b eq 6) {
		print 49;
	} elsif ($a eq 43 && $b eq 7) {
		print 50;
	} elsif ($a eq 43 && $b eq 8) {
		print 51;
	} elsif ($a eq 43 && $b eq 9) {
		print 52;
	} elsif ($a eq 43 && $b eq 10) {
		print 53;
	} elsif ($a eq 43 && $b eq 11) {
		print 54;
	} elsif ($a eq 43 && $b eq 12) {
		print 55;
	} elsif ($a eq 43 && $b eq 13) {
		print 56;
	} elsif ($a eq 43 && $b eq 14) {
		print 57;
	} elsif ($a eq 43 && $b eq 15) {
		print 58;
	} elsif ($a eq 43 && $b eq 16) {
		print 59;
	} elsif ($a eq 43 && $b eq 17) {
		print 60;
	} elsif ($a eq 43 && $b eq 18) {
		print 61;
	} elsif ($a eq 43 && $b eq 19) {
		print 62;
	} elsif ($a eq 43 && $b eq 20) {
		print 63;
	} elsif ($a eq 43 && $b eq 21) {
		print 64;
	} elsif ($a eq 43 && $b eq 22) {
		print 65;
	} elsif ($a eq 43 && $b eq 23) {
		print 66;
	} elsif ($a eq 43 && $b eq 24) {
		print 67;
	} elsif ($a eq 43 && $b eq 25) {
		print 68;
	} elsif ($a eq 43 && $b eq 26) {
		print 69;
	} elsif ($a eq 43 && $b eq 27) {
		print 70;
	} elsif ($a eq 43 && $b eq 28) {
		print 71;
	} elsif ($a eq 43 && $b eq 29) {
		print 72;
	} elsif ($a eq 43 && $b eq 30) {
		print 73;
	} elsif ($a eq 43 && $b eq 31) {
		print 74;
	} elsif ($a eq 43 && $b eq 32) {
		print 75;
	} elsif ($a eq 43 && $b eq 33) {
		print 76;
	} elsif ($a eq 43 && $b eq 34) {
		print 77;
	} elsif ($a eq 43 && $b eq 35) {
		print 78;
	} elsif ($a eq 43 && $b eq 36) {
		print 79;
	} elsif ($a eq 43 && $b eq 37) {
		print 80;
	} elsif ($a eq 43 && $b eq 38) {
		print 81;
	} elsif ($a eq 43 && $b eq 39) {
		print 82;
	} elsif ($a eq 43 && $b eq 40) {
		print 83;
	} elsif ($a eq 43 && $b eq 41) {
		print 84;
	} elsif ($a eq 43 && $b eq 42) {
		print 85;
	} elsif ($a eq 43 && $b eq 43) {
		print 86;
	} elsif ($a eq 43 && $b eq 44) {
		print 87;
	} elsif ($a eq 43 && $b eq 45) {
		print 88;
	} elsif ($a eq 43 && $b eq 46) {
		print 89;
	} elsif ($a eq 43 && $b eq 47) {
		print 90;
	} elsif ($a eq 43 && $b eq 48) {
		print 91;
	} elsif ($a eq 43 && $b eq 49) {
		print 92;
	} elsif ($a eq 43 && $b eq 50) {
		print 93;
	} elsif ($a eq 44 && $b eq 0) {
		print 44;
	} elsif ($a eq 44 && $b eq 1) {
		print 45;
	} elsif ($a eq 44 && $b eq 2) {
		print 46;
	} elsif ($a eq 44 && $b eq 3) {
		print 47;
	} elsif ($a eq 44 && $b eq 4) {
		print 48;
	} elsif ($a eq 44 && $b eq 5) {
		print 49;
	} elsif ($a eq 44 && $b eq 6) {
		print 50;
	} elsif ($a eq 44 && $b eq 7) {
		print 51;
	} elsif ($a eq 44 && $b eq 8) {
		print 52;
	} elsif ($a eq 44 && $b eq 9) {
		print 53;
	} elsif ($a eq 44 && $b eq 10) {
		print 54;
	} elsif ($a eq 44 && $b eq 11) {
		print 55;
	} elsif ($a eq 44 && $b eq 12) {
		print 56;
	} elsif ($a eq 44 && $b eq 13) {
		print 57;
	} elsif ($a eq 44 && $b eq 14) {
		print 58;
	} elsif ($a eq 44 && $b eq 15) {
		print 59;
	} elsif ($a eq 44 && $b eq 16) {
		print 60;
	} elsif ($a eq 44 && $b eq 17) {
		print 61;
	} elsif ($a eq 44 && $b eq 18) {
		print 62;
	} elsif ($a eq 44 && $b eq 19) {
		print 63;
	} elsif ($a eq 44 && $b eq 20) {
		print 64;
	} elsif ($a eq 44 && $b eq 21) {
		print 65;
	} elsif ($a eq 44 && $b eq 22) {
		print 66;
	} elsif ($a eq 44 && $b eq 23) {
		print 67;
	} elsif ($a eq 44 && $b eq 24) {
		print 68;
	} elsif ($a eq 44 && $b eq 25) {
		print 69;
	} elsif ($a eq 44 && $b eq 26) {
		print 70;
	} elsif ($a eq 44 && $b eq 27) {
		print 71;
	} elsif ($a eq 44 && $b eq 28) {
		print 72;
	} elsif ($a eq 44 && $b eq 29) {
		print 73;
	} elsif ($a eq 44 && $b eq 30) {
		print 74;
	} elsif ($a eq 44 && $b eq 31) {
		print 75;
	} elsif ($a eq 44 && $b eq 32) {
		print 76;
	} elsif ($a eq 44 && $b eq 33) {
		print 77;
	} elsif ($a eq 44 && $b eq 34) {
		print 78;
	} elsif ($a eq 44 && $b eq 35) {
		print 79;
	} elsif ($a eq 44 && $b eq 36) {
		print 80;
	} elsif ($a eq 44 && $b eq 37) {
		print 81;
	} elsif ($a eq 44 && $b eq 38) {
		print 82;
	} elsif ($a eq 44 && $b eq 39) {
		print 83;
	} elsif ($a eq 44 && $b eq 40) {
		print 84;
	} elsif ($a eq 44 && $b eq 41) {
		print 85;
	} elsif ($a eq 44 && $b eq 42) {
		print 86;
	} elsif ($a eq 44 && $b eq 43) {
		print 87;
	} elsif ($a eq 44 && $b eq 44) {
		print 88;
	} elsif ($a eq 44 && $b eq 45) {
		print 89;
	} elsif ($a eq 44 && $b eq 46) {
		print 90;
	} elsif ($a eq 44 && $b eq 47) {
		print 91;
	} elsif ($a eq 44 && $b eq 48) {
		print 92;
	} elsif ($a eq 44 && $b eq 49) {
		print 93;
	} elsif ($a eq 44 && $b eq 50) {
		print 94;
	} elsif ($a eq 45 && $b eq 0) {
		print 45;
	} elsif ($a eq 45 && $b eq 1) {
		print 46;
	} elsif ($a eq 45 && $b eq 2) {
		print 47;
	} elsif ($a eq 45 && $b eq 3) {
		print 48;
	} elsif ($a eq 45 && $b eq 4) {
		print 49;
	} elsif ($a eq 45 && $b eq 5) {
		print 50;
	} elsif ($a eq 45 && $b eq 6) {
		print 51;
	} elsif ($a eq 45 && $b eq 7) {
		print 52;
	} elsif ($a eq 45 && $b eq 8) {
		print 53;
	} elsif ($a eq 45 && $b eq 9) {
		print 54;
	} elsif ($a eq 45 && $b eq 10) {
		print 55;
	} elsif ($a eq 45 && $b eq 11) {
		print 56;
	} elsif ($a eq 45 && $b eq 12) {
		print 57;
	} elsif ($a eq 45 && $b eq 13) {
		print 58;
	} elsif ($a eq 45 && $b eq 14) {
		print 59;
	} elsif ($a eq 45 && $b eq 15) {
		print 60;
	} elsif ($a eq 45 && $b eq 16) {
		print 61;
	} elsif ($a eq 45 && $b eq 17) {
		print 62;
	} elsif ($a eq 45 && $b eq 18) {
		print 63;
	} elsif ($a eq 45 && $b eq 19) {
		print 64;
	} elsif ($a eq 45 && $b eq 20) {
		print 65;
	} elsif ($a eq 45 && $b eq 21) {
		print 66;
	} elsif ($a eq 45 && $b eq 22) {
		print 67;
	} elsif ($a eq 45 && $b eq 23) {
		print 68;
	} elsif ($a eq 45 && $b eq 24) {
		print 69;
	} elsif ($a eq 45 && $b eq 25) {
		print 70;
	} elsif ($a eq 45 && $b eq 26) {
		print 71;
	} elsif ($a eq 45 && $b eq 27) {
		print 72;
	} elsif ($a eq 45 && $b eq 28) {
		print 73;
	} elsif ($a eq 45 && $b eq 29) {
		print 74;
	} elsif ($a eq 45 && $b eq 30) {
		print 75;
	} elsif ($a eq 45 && $b eq 31) {
		print 76;
	} elsif ($a eq 45 && $b eq 32) {
		print 77;
	} elsif ($a eq 45 && $b eq 33) {
		print 78;
	} elsif ($a eq 45 && $b eq 34) {
		print 79;
	} elsif ($a eq 45 && $b eq 35) {
		print 80;
	} elsif ($a eq 45 && $b eq 36) {
		print 81;
	} elsif ($a eq 45 && $b eq 37) {
		print 82;
	} elsif ($a eq 45 && $b eq 38) {
		print 83;
	} elsif ($a eq 45 && $b eq 39) {
		print 84;
	} elsif ($a eq 45 && $b eq 40) {
		print 85;
	} elsif ($a eq 45 && $b eq 41) {
		print 86;
	} elsif ($a eq 45 && $b eq 42) {
		print 87;
	} elsif ($a eq 45 && $b eq 43) {
		print 88;
	} elsif ($a eq 45 && $b eq 44) {
		print 89;
	} elsif ($a eq 45 && $b eq 45) {
		print 90;
	} elsif ($a eq 45 && $b eq 46) {
		print 91;
	} elsif ($a eq 45 && $b eq 47) {
		print 92;
	} elsif ($a eq 45 && $b eq 48) {
		print 93;
	} elsif ($a eq 45 && $b eq 49) {
		print 94;
	} elsif ($a eq 45 && $b eq 50) {
		print 95;
	} elsif ($a eq 46 && $b eq 0) {
		print 46;
	} elsif ($a eq 46 && $b eq 1) {
		print 47;
	} elsif ($a eq 46 && $b eq 2) {
		print 48;
	} elsif ($a eq 46 && $b eq 3) {
		print 49;
	} elsif ($a eq 46 && $b eq 4) {
		print 50;
	} elsif ($a eq 46 && $b eq 5) {
		print 51;
	} elsif ($a eq 46 && $b eq 6) {
		print 52;
	} elsif ($a eq 46 && $b eq 7) {
		print 53;
	} elsif ($a eq 46 && $b eq 8) {
		print 54;
	} elsif ($a eq 46 && $b eq 9) {
		print 55;
	} elsif ($a eq 46 && $b eq 10) {
		print 56;
	} elsif ($a eq 46 && $b eq 11) {
		print 57;
	} elsif ($a eq 46 && $b eq 12) {
		print 58;
	} elsif ($a eq 46 && $b eq 13) {
		print 59;
	} elsif ($a eq 46 && $b eq 14) {
		print 60;
	} elsif ($a eq 46 && $b eq 15) {
		print 61;
	} elsif ($a eq 46 && $b eq 16) {
		print 62;
	} elsif ($a eq 46 && $b eq 17) {
		print 63;
	} elsif ($a eq 46 && $b eq 18) {
		print 64;
	} elsif ($a eq 46 && $b eq 19) {
		print 65;
	} elsif ($a eq 46 && $b eq 20) {
		print 66;
	} elsif ($a eq 46 && $b eq 21) {
		print 67;
	} elsif ($a eq 46 && $b eq 22) {
		print 68;
	} elsif ($a eq 46 && $b eq 23) {
		print 69;
	} elsif ($a eq 46 && $b eq 24) {
		print 70;
	} elsif ($a eq 46 && $b eq 25) {
		print 71;
	} elsif ($a eq 46 && $b eq 26) {
		print 72;
	} elsif ($a eq 46 && $b eq 27) {
		print 73;
	} elsif ($a eq 46 && $b eq 28) {
		print 74;
	} elsif ($a eq 46 && $b eq 29) {
		print 75;
	} elsif ($a eq 46 && $b eq 30) {
		print 76;
	} elsif ($a eq 46 && $b eq 31) {
		print 77;
	} elsif ($a eq 46 && $b eq 32) {
		print 78;
	} elsif ($a eq 46 && $b eq 33) {
		print 79;
	} elsif ($a eq 46 && $b eq 34) {
		print 80;
	} elsif ($a eq 46 && $b eq 35) {
		print 81;
	} elsif ($a eq 46 && $b eq 36) {
		print 82;
	} elsif ($a eq 46 && $b eq 37) {
		print 83;
	} elsif ($a eq 46 && $b eq 38) {
		print 84;
	} elsif ($a eq 46 && $b eq 39) {
		print 85;
	} elsif ($a eq 46 && $b eq 40) {
		print 86;
	} elsif ($a eq 46 && $b eq 41) {
		print 87;
	} elsif ($a eq 46 && $b eq 42) {
		print 88;
	} elsif ($a eq 46 && $b eq 43) {
		print 89;
	} elsif ($a eq 46 && $b eq 44) {
		print 90;
	} elsif ($a eq 46 && $b eq 45) {
		print 91;
	} elsif ($a eq 46 && $b eq 46) {
		print 92;
	} elsif ($a eq 46 && $b eq 47) {
		print 93;
	} elsif ($a eq 46 && $b eq 48) {
		print 94;
	} elsif ($a eq 46 && $b eq 49) {
		print 95;
	} elsif ($a eq 46 && $b eq 50) {
		print 96;
	} elsif ($a eq 47 && $b eq 0) {
		print 47;
	} elsif ($a eq 47 && $b eq 1) {
		print 48;
	} elsif ($a eq 47 && $b eq 2) {
		print 49;
	} elsif ($a eq 47 && $b eq 3) {
		print 50;
	} elsif ($a eq 47 && $b eq 4) {
		print 51;
	} elsif ($a eq 47 && $b eq 5) {
		print 52;
	} elsif ($a eq 47 && $b eq 6) {
		print 53;
	} elsif ($a eq 47 && $b eq 7) {
		print 54;
	} elsif ($a eq 47 && $b eq 8) {
		print 55;
	} elsif ($a eq 47 && $b eq 9) {
		print 56;
	} elsif ($a eq 47 && $b eq 10) {
		print 57;
	} elsif ($a eq 47 && $b eq 11) {
		print 58;
	} elsif ($a eq 47 && $b eq 12) {
		print 59;
	} elsif ($a eq 47 && $b eq 13) {
		print 60;
	} elsif ($a eq 47 && $b eq 14) {
		print 61;
	} elsif ($a eq 47 && $b eq 15) {
		print 62;
	} elsif ($a eq 47 && $b eq 16) {
		print 63;
	} elsif ($a eq 47 && $b eq 17) {
		print 64;
	} elsif ($a eq 47 && $b eq 18) {
		print 65;
	} elsif ($a eq 47 && $b eq 19) {
		print 66;
	} elsif ($a eq 47 && $b eq 20) {
		print 67;
	} elsif ($a eq 47 && $b eq 21) {
		print 68;
	} elsif ($a eq 47 && $b eq 22) {
		print 69;
	} elsif ($a eq 47 && $b eq 23) {
		print 70;
	} elsif ($a eq 47 && $b eq 24) {
		print 71;
	} elsif ($a eq 47 && $b eq 25) {
		print 72;
	} elsif ($a eq 47 && $b eq 26) {
		print 73;
	} elsif ($a eq 47 && $b eq 27) {
		print 74;
	} elsif ($a eq 47 && $b eq 28) {
		print 75;
	} elsif ($a eq 47 && $b eq 29) {
		print 76;
	} elsif ($a eq 47 && $b eq 30) {
		print 77;
	} elsif ($a eq 47 && $b eq 31) {
		print 78;
	} elsif ($a eq 47 && $b eq 32) {
		print 79;
	} elsif ($a eq 47 && $b eq 33) {
		print 80;
	} elsif ($a eq 47 && $b eq 34) {
		print 81;
	} elsif ($a eq 47 && $b eq 35) {
		print 82;
	} elsif ($a eq 47 && $b eq 36) {
		print 83;
	} elsif ($a eq 47 && $b eq 37) {
		print 84;
	} elsif ($a eq 47 && $b eq 38) {
		print 85;
	} elsif ($a eq 47 && $b eq 39) {
		print 86;
	} elsif ($a eq 47 && $b eq 40) {
		print 87;
	} elsif ($a eq 47 && $b eq 41) {
		print 88;
	} elsif ($a eq 47 && $b eq 42) {
		print 89;
	} elsif ($a eq 47 && $b eq 43) {
		print 90;
	} elsif ($a eq 47 && $b eq 44) {
		print 91;
	} elsif ($a eq 47 && $b eq 45) {
		print 92;
	} elsif ($a eq 47 && $b eq 46) {
		print 93;
	} elsif ($a eq 47 && $b eq 47) {
		print 94;
	} elsif ($a eq 47 && $b eq 48) {
		print 95;
	} elsif ($a eq 47 && $b eq 49) {
		print 96;
	} elsif ($a eq 47 && $b eq 50) {
		print 97;
	} elsif ($a eq 48 && $b eq 0) {
		print 48;
	} elsif ($a eq 48 && $b eq 1) {
		print 49;
	} elsif ($a eq 48 && $b eq 2) {
		print 50;
	} elsif ($a eq 48 && $b eq 3) {
		print 51;
	} elsif ($a eq 48 && $b eq 4) {
		print 52;
	} elsif ($a eq 48 && $b eq 5) {
		print 53;
	} elsif ($a eq 48 && $b eq 6) {
		print 54;
	} elsif ($a eq 48 && $b eq 7) {
		print 55;
	} elsif ($a eq 48 && $b eq 8) {
		print 56;
	} elsif ($a eq 48 && $b eq 9) {
		print 57;
	} elsif ($a eq 48 && $b eq 10) {
		print 58;
	} elsif ($a eq 48 && $b eq 11) {
		print 59;
	} elsif ($a eq 48 && $b eq 12) {
		print 60;
	} elsif ($a eq 48 && $b eq 13) {
		print 61;
	} elsif ($a eq 48 && $b eq 14) {
		print 62;
	} elsif ($a eq 48 && $b eq 15) {
		print 63;
	} elsif ($a eq 48 && $b eq 16) {
		print 64;
	} elsif ($a eq 48 && $b eq 17) {
		print 65;
	} elsif ($a eq 48 && $b eq 18) {
		print 66;
	} elsif ($a eq 48 && $b eq 19) {
		print 67;
	} elsif ($a eq 48 && $b eq 20) {
		print 68;
	} elsif ($a eq 48 && $b eq 21) {
		print 69;
	} elsif ($a eq 48 && $b eq 22) {
		print 70;
	} elsif ($a eq 48 && $b eq 23) {
		print 71;
	} elsif ($a eq 48 && $b eq 24) {
		print 72;
	} elsif ($a eq 48 && $b eq 25) {
		print 73;
	} elsif ($a eq 48 && $b eq 26) {
		print 74;
	} elsif ($a eq 48 && $b eq 27) {
		print 75;
	} elsif ($a eq 48 && $b eq 28) {
		print 76;
	} elsif ($a eq 48 && $b eq 29) {
		print 77;
	} elsif ($a eq 48 && $b eq 30) {
		print 78;
	} elsif ($a eq 48 && $b eq 31) {
		print 79;
	} elsif ($a eq 48 && $b eq 32) {
		print 80;
	} elsif ($a eq 48 && $b eq 33) {
		print 81;
	} elsif ($a eq 48 && $b eq 34) {
		print 82;
	} elsif ($a eq 48 && $b eq 35) {
		print 83;
	} elsif ($a eq 48 && $b eq 36) {
		print 84;
	} elsif ($a eq 48 && $b eq 37) {
		print 85;
	} elsif ($a eq 48 && $b eq 38) {
		print 86;
	} elsif ($a eq 48 && $b eq 39) {
		print 87;
	} elsif ($a eq 48 && $b eq 40) {
		print 88;
	} elsif ($a eq 48 && $b eq 41) {
		print 89;
	} elsif ($a eq 48 && $b eq 42) {
		print 90;
	} elsif ($a eq 48 && $b eq 43) {
		print 91;
	} elsif ($a eq 48 && $b eq 44) {
		print 92;
	} elsif ($a eq 48 && $b eq 45) {
		print 93;
	} elsif ($a eq 48 && $b eq 46) {
		print 94;
	} elsif ($a eq 48 && $b eq 47) {
		print 95;
	} elsif ($a eq 48 && $b eq 48) {
		print 96;
	} elsif ($a eq 48 && $b eq 49) {
		print 97;
	} elsif ($a eq 48 && $b eq 50) {
		print 98;
	} elsif ($a eq 49 && $b eq 0) {
		print 49;
	} elsif ($a eq 49 && $b eq 1) {
		print 50;
	} elsif ($a eq 49 && $b eq 2) {
		print 51;
	} elsif ($a eq 49 && $b eq 3) {
		print 52;
	} elsif ($a eq 49 && $b eq 4) {
		print 53;
	} elsif ($a eq 49 && $b eq 5) {
		print 54;
	} elsif ($a eq 49 && $b eq 6) {
		print 55;
	} elsif ($a eq 49 && $b eq 7) {
		print 56;
	} elsif ($a eq 49 && $b eq 8) {
		print 57;
	} elsif ($a eq 49 && $b eq 9) {
		print 58;
	} elsif ($a eq 49 && $b eq 10) {
		print 59;
	} elsif ($a eq 49 && $b eq 11) {
		print 60;
	} elsif ($a eq 49 && $b eq 12) {
		print 61;
	} elsif ($a eq 49 && $b eq 13) {
		print 62;
	} elsif ($a eq 49 && $b eq 14) {
		print 63;
	} elsif ($a eq 49 && $b eq 15) {
		print 64;
	} elsif ($a eq 49 && $b eq 16) {
		print 65;
	} elsif ($a eq 49 && $b eq 17) {
		print 66;
	} elsif ($a eq 49 && $b eq 18) {
		print 67;
	} elsif ($a eq 49 && $b eq 19) {
		print 68;
	} elsif ($a eq 49 && $b eq 20) {
		print 69;
	} elsif ($a eq 49 && $b eq 21) {
		print 70;
	} elsif ($a eq 49 && $b eq 22) {
		print 71;
	} elsif ($a eq 49 && $b eq 23) {
		print 72;
	} elsif ($a eq 49 && $b eq 24) {
		print 73;
	} elsif ($a eq 49 && $b eq 25) {
		print 74;
	} elsif ($a eq 49 && $b eq 26) {
		print 75;
	} elsif ($a eq 49 && $b eq 27) {
		print 76;
	} elsif ($a eq 49 && $b eq 28) {
		print 77;
	} elsif ($a eq 49 && $b eq 29) {
		print 78;
	} elsif ($a eq 49 && $b eq 30) {
		print 79;
	} elsif ($a eq 49 && $b eq 31) {
		print 80;
	} elsif ($a eq 49 && $b eq 32) {
		print 81;
	} elsif ($a eq 49 && $b eq 33) {
		print 82;
	} elsif ($a eq 49 && $b eq 34) {
		print 83;
	} elsif ($a eq 49 && $b eq 35) {
		print 84;
	} elsif ($a eq 49 && $b eq 36) {
		print 85;
	} elsif ($a eq 49 && $b eq 37) {
		print 86;
	} elsif ($a eq 49 && $b eq 38) {
		print 87;
	} elsif ($a eq 49 && $b eq 39) {
		print 88;
	} elsif ($a eq 49 && $b eq 40) {
		print 89;
	} elsif ($a eq 49 && $b eq 41) {
		print 90;
	} elsif ($a eq 49 && $b eq 42) {
		print 91;
	} elsif ($a eq 49 && $b eq 43) {
		print 92;
	} elsif ($a eq 49 && $b eq 44) {
		print 93;
	} elsif ($a eq 49 && $b eq 45) {
		print 94;
	} elsif ($a eq 49 && $b eq 46) {
		print 95;
	} elsif ($a eq 49 && $b eq 47) {
		print 96;
	} elsif ($a eq 49 && $b eq 48) {
		print 97;
	} elsif ($a eq 49 && $b eq 49) {
		print 98;
	} elsif ($a eq 49 && $b eq 50) {
		print 99;
	} elsif ($a eq 50 && $b eq 0) {
		print 50;
	} elsif ($a eq 50 && $b eq 1) {
		print 51;
	} elsif ($a eq 50 && $b eq 2) {
		print 52;
	} elsif ($a eq 50 && $b eq 3) {
		print 53;
	} elsif ($a eq 50 && $b eq 4) {
		print 54;
	} elsif ($a eq 50 && $b eq 5) {
		print 55;
	} elsif ($a eq 50 && $b eq 6) {
		print 56;
	} elsif ($a eq 50 && $b eq 7) {
		print 57;
	} elsif ($a eq 50 && $b eq 8) {
		print 58;
	} elsif ($a eq 50 && $b eq 9) {
		print 59;
	} elsif ($a eq 50 && $b eq 10) {
		print 60;
	} elsif ($a eq 50 && $b eq 11) {
		print 61;
	} elsif ($a eq 50 && $b eq 12) {
		print 62;
	} elsif ($a eq 50 && $b eq 13) {
		print 63;
	} elsif ($a eq 50 && $b eq 14) {
		print 64;
	} elsif ($a eq 50 && $b eq 15) {
		print 65;
	} elsif ($a eq 50 && $b eq 16) {
		print 66;
	} elsif ($a eq 50 && $b eq 17) {
		print 67;
	} elsif ($a eq 50 && $b eq 18) {
		print 68;
	} elsif ($a eq 50 && $b eq 19) {
		print 69;
	} elsif ($a eq 50 && $b eq 20) {
		print 70;
	} elsif ($a eq 50 && $b eq 21) {
		print 71;
	} elsif ($a eq 50 && $b eq 22) {
		print 72;
	} elsif ($a eq 50 && $b eq 23) {
		print 73;
	} elsif ($a eq 50 && $b eq 24) {
		print 74;
	} elsif ($a eq 50 && $b eq 25) {
		print 75;
	} elsif ($a eq 50 && $b eq 26) {
		print 76;
	} elsif ($a eq 50 && $b eq 27) {
		print 77;
	} elsif ($a eq 50 && $b eq 28) {
		print 78;
	} elsif ($a eq 50 && $b eq 29) {
		print 79;
	} elsif ($a eq 50 && $b eq 30) {
		print 80;
	} elsif ($a eq 50 && $b eq 31) {
		print 81;
	} elsif ($a eq 50 && $b eq 32) {
		print 82;
	} elsif ($a eq 50 && $b eq 33) {
		print 83;
	} elsif ($a eq 50 && $b eq 34) {
		print 84;
	} elsif ($a eq 50 && $b eq 35) {
		print 85;
	} elsif ($a eq 50 && $b eq 36) {
		print 86;
	} elsif ($a eq 50 && $b eq 37) {
		print 87;
	} elsif ($a eq 50 && $b eq 38) {
		print 88;
	} elsif ($a eq 50 && $b eq 39) {
		print 89;
	} elsif ($a eq 50 && $b eq 40) {
		print 90;
	} elsif ($a eq 50 && $b eq 41) {
		print 91;
	} elsif ($a eq 50 && $b eq 42) {
		print 92;
	} elsif ($a eq 50 && $b eq 43) {
		print 93;
	} elsif ($a eq 50 && $b eq 44) {
		print 94;
	} elsif ($a eq 50 && $b eq 45) {
		print 95;
	} elsif ($a eq 50 && $b eq 46) {
		print 96;
	} elsif ($a eq 50 && $b eq 47) {
		print 97;
	} elsif ($a eq 50 && $b eq 48) {
		print 98;
	} elsif ($a eq 50 && $b eq 49) {
		print 99;
	} elsif ($a eq 50 && $b eq 50) {
		print 100;
	} else {
		print "Unsupported number given!";
	}
}
sub subtract {
	my $a = shift;
	my $b = shift;
	if ($a eq 0 && $b eq 0) {
		print 0;
	} elsif ($a eq 0 && $b eq 1) {
		print -1;
	} elsif ($a eq 0 && $b eq 2) {
		print -2;
	} elsif ($a eq 0 && $b eq 3) {
		print -3;
	} elsif ($a eq 0 && $b eq 4) {
		print -4;
	} elsif ($a eq 0 && $b eq 5) {
		print -5;
	} elsif ($a eq 0 && $b eq 6) {
		print -6;
	} elsif ($a eq 0 && $b eq 7) {
		print -7;
	} elsif ($a eq 0 && $b eq 8) {
		print -8;
	} elsif ($a eq 0 && $b eq 9) {
		print -9;
	} elsif ($a eq 0 && $b eq 10) {
		print -10;
	} elsif ($a eq 0 && $b eq 11) {
		print -11;
	} elsif ($a eq 0 && $b eq 12) {
		print -12;
	} elsif ($a eq 0 && $b eq 13) {
		print -13;
	} elsif ($a eq 0 && $b eq 14) {
		print -14;
	} elsif ($a eq 0 && $b eq 15) {
		print -15;
	} elsif ($a eq 0 && $b eq 16) {
		print -16;
	} elsif ($a eq 0 && $b eq 17) {
		print -17;
	} elsif ($a eq 0 && $b eq 18) {
		print -18;
	} elsif ($a eq 0 && $b eq 19) {
		print -19;
	} elsif ($a eq 0 && $b eq 20) {
		print -20;
	} elsif ($a eq 0 && $b eq 21) {
		print -21;
	} elsif ($a eq 0 && $b eq 22) {
		print -22;
	} elsif ($a eq 0 && $b eq 23) {
		print -23;
	} elsif ($a eq 0 && $b eq 24) {
		print -24;
	} elsif ($a eq 0 && $b eq 25) {
		print -25;
	} elsif ($a eq 0 && $b eq 26) {
		print -26;
	} elsif ($a eq 0 && $b eq 27) {
		print -27;
	} elsif ($a eq 0 && $b eq 28) {
		print -28;
	} elsif ($a eq 0 && $b eq 29) {
		print -29;
	} elsif ($a eq 0 && $b eq 30) {
		print -30;
	} elsif ($a eq 0 && $b eq 31) {
		print -31;
	} elsif ($a eq 0 && $b eq 32) {
		print -32;
	} elsif ($a eq 0 && $b eq 33) {
		print -33;
	} elsif ($a eq 0 && $b eq 34) {
		print -34;
	} elsif ($a eq 0 && $b eq 35) {
		print -35;
	} elsif ($a eq 0 && $b eq 36) {
		print -36;
	} elsif ($a eq 0 && $b eq 37) {
		print -37;
	} elsif ($a eq 0 && $b eq 38) {
		print -38;
	} elsif ($a eq 0 && $b eq 39) {
		print -39;
	} elsif ($a eq 0 && $b eq 40) {
		print -40;
	} elsif ($a eq 0 && $b eq 41) {
		print -41;
	} elsif ($a eq 0 && $b eq 42) {
		print -42;
	} elsif ($a eq 0 && $b eq 43) {
		print -43;
	} elsif ($a eq 0 && $b eq 44) {
		print -44;
	} elsif ($a eq 0 && $b eq 45) {
		print -45;
	} elsif ($a eq 0 && $b eq 46) {
		print -46;
	} elsif ($a eq 0 && $b eq 47) {
		print -47;
	} elsif ($a eq 0 && $b eq 48) {
		print -48;
	} elsif ($a eq 0 && $b eq 49) {
		print -49;
	} elsif ($a eq 0 && $b eq 50) {
		print -50;
	} elsif ($a eq 1 && $b eq 0) {
		print 1;
	} elsif ($a eq 1 && $b eq 1) {
		print 0;
	} elsif ($a eq 1 && $b eq 2) {
		print -1;
	} elsif ($a eq 1 && $b eq 3) {
		print -2;
	} elsif ($a eq 1 && $b eq 4) {
		print -3;
	} elsif ($a eq 1 && $b eq 5) {
		print -4;
	} elsif ($a eq 1 && $b eq 6) {
		print -5;
	} elsif ($a eq 1 && $b eq 7) {
		print -6;
	} elsif ($a eq 1 && $b eq 8) {
		print -7;
	} elsif ($a eq 1 && $b eq 9) {
		print -8;
	} elsif ($a eq 1 && $b eq 10) {
		print -9;
	} elsif ($a eq 1 && $b eq 11) {
		print -10;
	} elsif ($a eq 1 && $b eq 12) {
		print -11;
	} elsif ($a eq 1 && $b eq 13) {
		print -12;
	} elsif ($a eq 1 && $b eq 14) {
		print -13;
	} elsif ($a eq 1 && $b eq 15) {
		print -14;
	} elsif ($a eq 1 && $b eq 16) {
		print -15;
	} elsif ($a eq 1 && $b eq 17) {
		print -16;
	} elsif ($a eq 1 && $b eq 18) {
		print -17;
	} elsif ($a eq 1 && $b eq 19) {
		print -18;
	} elsif ($a eq 1 && $b eq 20) {
		print -19;
	} elsif ($a eq 1 && $b eq 21) {
		print -20;
	} elsif ($a eq 1 && $b eq 22) {
		print -21;
	} elsif ($a eq 1 && $b eq 23) {
		print -22;
	} elsif ($a eq 1 && $b eq 24) {
		print -23;
	} elsif ($a eq 1 && $b eq 25) {
		print -24;
	} elsif ($a eq 1 && $b eq 26) {
		print -25;
	} elsif ($a eq 1 && $b eq 27) {
		print -26;
	} elsif ($a eq 1 && $b eq 28) {
		print -27;
	} elsif ($a eq 1 && $b eq 29) {
		print -28;
	} elsif ($a eq 1 && $b eq 30) {
		print -29;
	} elsif ($a eq 1 && $b eq 31) {
		print -30;
	} elsif ($a eq 1 && $b eq 32) {
		print -31;
	} elsif ($a eq 1 && $b eq 33) {
		print -32;
	} elsif ($a eq 1 && $b eq 34) {
		print -33;
	} elsif ($a eq 1 && $b eq 35) {
		print -34;
	} elsif ($a eq 1 && $b eq 36) {
		print -35;
	} elsif ($a eq 1 && $b eq 37) {
		print -36;
	} elsif ($a eq 1 && $b eq 38) {
		print -37;
	} elsif ($a eq 1 && $b eq 39) {
		print -38;
	} elsif ($a eq 1 && $b eq 40) {
		print -39;
	} elsif ($a eq 1 && $b eq 41) {
		print -40;
	} elsif ($a eq 1 && $b eq 42) {
		print -41;
	} elsif ($a eq 1 && $b eq 43) {
		print -42;
	} elsif ($a eq 1 && $b eq 44) {
		print -43;
	} elsif ($a eq 1 && $b eq 45) {
		print -44;
	} elsif ($a eq 1 && $b eq 46) {
		print -45;
	} elsif ($a eq 1 && $b eq 47) {
		print -46;
	} elsif ($a eq 1 && $b eq 48) {
		print -47;
	} elsif ($a eq 1 && $b eq 49) {
		print -48;
	} elsif ($a eq 1 && $b eq 50) {
		print -49;
	} elsif ($a eq 2 && $b eq 0) {
		print 2;
	} elsif ($a eq 2 && $b eq 1) {
		print 1;
	} elsif ($a eq 2 && $b eq 2) {
		print 0;
	} elsif ($a eq 2 && $b eq 3) {
		print -1;
	} elsif ($a eq 2 && $b eq 4) {
		print -2;
	} elsif ($a eq 2 && $b eq 5) {
		print -3;
	} elsif ($a eq 2 && $b eq 6) {
		print -4;
	} elsif ($a eq 2 && $b eq 7) {
		print -5;
	} elsif ($a eq 2 && $b eq 8) {
		print -6;
	} elsif ($a eq 2 && $b eq 9) {
		print -7;
	} elsif ($a eq 2 && $b eq 10) {
		print -8;
	} elsif ($a eq 2 && $b eq 11) {
		print -9;
	} elsif ($a eq 2 && $b eq 12) {
		print -10;
	} elsif ($a eq 2 && $b eq 13) {
		print -11;
	} elsif ($a eq 2 && $b eq 14) {
		print -12;
	} elsif ($a eq 2 && $b eq 15) {
		print -13;
	} elsif ($a eq 2 && $b eq 16) {
		print -14;
	} elsif ($a eq 2 && $b eq 17) {
		print -15;
	} elsif ($a eq 2 && $b eq 18) {
		print -16;
	} elsif ($a eq 2 && $b eq 19) {
		print -17;
	} elsif ($a eq 2 && $b eq 20) {
		print -18;
	} elsif ($a eq 2 && $b eq 21) {
		print -19;
	} elsif ($a eq 2 && $b eq 22) {
		print -20;
	} elsif ($a eq 2 && $b eq 23) {
		print -21;
	} elsif ($a eq 2 && $b eq 24) {
		print -22;
	} elsif ($a eq 2 && $b eq 25) {
		print -23;
	} elsif ($a eq 2 && $b eq 26) {
		print -24;
	} elsif ($a eq 2 && $b eq 27) {
		print -25;
	} elsif ($a eq 2 && $b eq 28) {
		print -26;
	} elsif ($a eq 2 && $b eq 29) {
		print -27;
	} elsif ($a eq 2 && $b eq 30) {
		print -28;
	} elsif ($a eq 2 && $b eq 31) {
		print -29;
	} elsif ($a eq 2 && $b eq 32) {
		print -30;
	} elsif ($a eq 2 && $b eq 33) {
		print -31;
	} elsif ($a eq 2 && $b eq 34) {
		print -32;
	} elsif ($a eq 2 && $b eq 35) {
		print -33;
	} elsif ($a eq 2 && $b eq 36) {
		print -34;
	} elsif ($a eq 2 && $b eq 37) {
		print -35;
	} elsif ($a eq 2 && $b eq 38) {
		print -36;
	} elsif ($a eq 2 && $b eq 39) {
		print -37;
	} elsif ($a eq 2 && $b eq 40) {
		print -38;
	} elsif ($a eq 2 && $b eq 41) {
		print -39;
	} elsif ($a eq 2 && $b eq 42) {
		print -40;
	} elsif ($a eq 2 && $b eq 43) {
		print -41;
	} elsif ($a eq 2 && $b eq 44) {
		print -42;
	} elsif ($a eq 2 && $b eq 45) {
		print -43;
	} elsif ($a eq 2 && $b eq 46) {
		print -44;
	} elsif ($a eq 2 && $b eq 47) {
		print -45;
	} elsif ($a eq 2 && $b eq 48) {
		print -46;
	} elsif ($a eq 2 && $b eq 49) {
		print -47;
	} elsif ($a eq 2 && $b eq 50) {
		print -48;
	} elsif ($a eq 3 && $b eq 0) {
		print 3;
	} elsif ($a eq 3 && $b eq 1) {
		print 2;
	} elsif ($a eq 3 && $b eq 2) {
		print 1;
	} elsif ($a eq 3 && $b eq 3) {
		print 0;
	} elsif ($a eq 3 && $b eq 4) {
		print -1;
	} elsif ($a eq 3 && $b eq 5) {
		print -2;
	} elsif ($a eq 3 && $b eq 6) {
		print -3;
	} elsif ($a eq 3 && $b eq 7) {
		print -4;
	} elsif ($a eq 3 && $b eq 8) {
		print -5;
	} elsif ($a eq 3 && $b eq 9) {
		print -6;
	} elsif ($a eq 3 && $b eq 10) {
		print -7;
	} elsif ($a eq 3 && $b eq 11) {
		print -8;
	} elsif ($a eq 3 && $b eq 12) {
		print -9;
	} elsif ($a eq 3 && $b eq 13) {
		print -10;
	} elsif ($a eq 3 && $b eq 14) {
		print -11;
	} elsif ($a eq 3 && $b eq 15) {
		print -12;
	} elsif ($a eq 3 && $b eq 16) {
		print -13;
	} elsif ($a eq 3 && $b eq 17) {
		print -14;
	} elsif ($a eq 3 && $b eq 18) {
		print -15;
	} elsif ($a eq 3 && $b eq 19) {
		print -16;
	} elsif ($a eq 3 && $b eq 20) {
		print -17;
	} elsif ($a eq 3 && $b eq 21) {
		print -18;
	} elsif ($a eq 3 && $b eq 22) {
		print -19;
	} elsif ($a eq 3 && $b eq 23) {
		print -20;
	} elsif ($a eq 3 && $b eq 24) {
		print -21;
	} elsif ($a eq 3 && $b eq 25) {
		print -22;
	} elsif ($a eq 3 && $b eq 26) {
		print -23;
	} elsif ($a eq 3 && $b eq 27) {
		print -24;
	} elsif ($a eq 3 && $b eq 28) {
		print -25;
	} elsif ($a eq 3 && $b eq 29) {
		print -26;
	} elsif ($a eq 3 && $b eq 30) {
		print -27;
	} elsif ($a eq 3 && $b eq 31) {
		print -28;
	} elsif ($a eq 3 && $b eq 32) {
		print -29;
	} elsif ($a eq 3 && $b eq 33) {
		print -30;
	} elsif ($a eq 3 && $b eq 34) {
		print -31;
	} elsif ($a eq 3 && $b eq 35) {
		print -32;
	} elsif ($a eq 3 && $b eq 36) {
		print -33;
	} elsif ($a eq 3 && $b eq 37) {
		print -34;
	} elsif ($a eq 3 && $b eq 38) {
		print -35;
	} elsif ($a eq 3 && $b eq 39) {
		print -36;
	} elsif ($a eq 3 && $b eq 40) {
		print -37;
	} elsif ($a eq 3 && $b eq 41) {
		print -38;
	} elsif ($a eq 3 && $b eq 42) {
		print -39;
	} elsif ($a eq 3 && $b eq 43) {
		print -40;
	} elsif ($a eq 3 && $b eq 44) {
		print -41;
	} elsif ($a eq 3 && $b eq 45) {
		print -42;
	} elsif ($a eq 3 && $b eq 46) {
		print -43;
	} elsif ($a eq 3 && $b eq 47) {
		print -44;
	} elsif ($a eq 3 && $b eq 48) {
		print -45;
	} elsif ($a eq 3 && $b eq 49) {
		print -46;
	} elsif ($a eq 3 && $b eq 50) {
		print -47;
	} elsif ($a eq 4 && $b eq 0) {
		print 4;
	} elsif ($a eq 4 && $b eq 1) {
		print 3;
	} elsif ($a eq 4 && $b eq 2) {
		print 2;
	} elsif ($a eq 4 && $b eq 3) {
		print 1;
	} elsif ($a eq 4 && $b eq 4) {
		print 0;
	} elsif ($a eq 4 && $b eq 5) {
		print -1;
	} elsif ($a eq 4 && $b eq 6) {
		print -2;
	} elsif ($a eq 4 && $b eq 7) {
		print -3;
	} elsif ($a eq 4 && $b eq 8) {
		print -4;
	} elsif ($a eq 4 && $b eq 9) {
		print -5;
	} elsif ($a eq 4 && $b eq 10) {
		print -6;
	} elsif ($a eq 4 && $b eq 11) {
		print -7;
	} elsif ($a eq 4 && $b eq 12) {
		print -8;
	} elsif ($a eq 4 && $b eq 13) {
		print -9;
	} elsif ($a eq 4 && $b eq 14) {
		print -10;
	} elsif ($a eq 4 && $b eq 15) {
		print -11;
	} elsif ($a eq 4 && $b eq 16) {
		print -12;
	} elsif ($a eq 4 && $b eq 17) {
		print -13;
	} elsif ($a eq 4 && $b eq 18) {
		print -14;
	} elsif ($a eq 4 && $b eq 19) {
		print -15;
	} elsif ($a eq 4 && $b eq 20) {
		print -16;
	} elsif ($a eq 4 && $b eq 21) {
		print -17;
	} elsif ($a eq 4 && $b eq 22) {
		print -18;
	} elsif ($a eq 4 && $b eq 23) {
		print -19;
	} elsif ($a eq 4 && $b eq 24) {
		print -20;
	} elsif ($a eq 4 && $b eq 25) {
		print -21;
	} elsif ($a eq 4 && $b eq 26) {
		print -22;
	} elsif ($a eq 4 && $b eq 27) {
		print -23;
	} elsif ($a eq 4 && $b eq 28) {
		print -24;
	} elsif ($a eq 4 && $b eq 29) {
		print -25;
	} elsif ($a eq 4 && $b eq 30) {
		print -26;
	} elsif ($a eq 4 && $b eq 31) {
		print -27;
	} elsif ($a eq 4 && $b eq 32) {
		print -28;
	} elsif ($a eq 4 && $b eq 33) {
		print -29;
	} elsif ($a eq 4 && $b eq 34) {
		print -30;
	} elsif ($a eq 4 && $b eq 35) {
		print -31;
	} elsif ($a eq 4 && $b eq 36) {
		print -32;
	} elsif ($a eq 4 && $b eq 37) {
		print -33;
	} elsif ($a eq 4 && $b eq 38) {
		print -34;
	} elsif ($a eq 4 && $b eq 39) {
		print -35;
	} elsif ($a eq 4 && $b eq 40) {
		print -36;
	} elsif ($a eq 4 && $b eq 41) {
		print -37;
	} elsif ($a eq 4 && $b eq 42) {
		print -38;
	} elsif ($a eq 4 && $b eq 43) {
		print -39;
	} elsif ($a eq 4 && $b eq 44) {
		print -40;
	} elsif ($a eq 4 && $b eq 45) {
		print -41;
	} elsif ($a eq 4 && $b eq 46) {
		print -42;
	} elsif ($a eq 4 && $b eq 47) {
		print -43;
	} elsif ($a eq 4 && $b eq 48) {
		print -44;
	} elsif ($a eq 4 && $b eq 49) {
		print -45;
	} elsif ($a eq 4 && $b eq 50) {
		print -46;
	} elsif ($a eq 5 && $b eq 0) {
		print 5;
	} elsif ($a eq 5 && $b eq 1) {
		print 4;
	} elsif ($a eq 5 && $b eq 2) {
		print 3;
	} elsif ($a eq 5 && $b eq 3) {
		print 2;
	} elsif ($a eq 5 && $b eq 4) {
		print 1;
	} elsif ($a eq 5 && $b eq 5) {
		print 0;
	} elsif ($a eq 5 && $b eq 6) {
		print -1;
	} elsif ($a eq 5 && $b eq 7) {
		print -2;
	} elsif ($a eq 5 && $b eq 8) {
		print -3;
	} elsif ($a eq 5 && $b eq 9) {
		print -4;
	} elsif ($a eq 5 && $b eq 10) {
		print -5;
	} elsif ($a eq 5 && $b eq 11) {
		print -6;
	} elsif ($a eq 5 && $b eq 12) {
		print -7;
	} elsif ($a eq 5 && $b eq 13) {
		print -8;
	} elsif ($a eq 5 && $b eq 14) {
		print -9;
	} elsif ($a eq 5 && $b eq 15) {
		print -10;
	} elsif ($a eq 5 && $b eq 16) {
		print -11;
	} elsif ($a eq 5 && $b eq 17) {
		print -12;
	} elsif ($a eq 5 && $b eq 18) {
		print -13;
	} elsif ($a eq 5 && $b eq 19) {
		print -14;
	} elsif ($a eq 5 && $b eq 20) {
		print -15;
	} elsif ($a eq 5 && $b eq 21) {
		print -16;
	} elsif ($a eq 5 && $b eq 22) {
		print -17;
	} elsif ($a eq 5 && $b eq 23) {
		print -18;
	} elsif ($a eq 5 && $b eq 24) {
		print -19;
	} elsif ($a eq 5 && $b eq 25) {
		print -20;
	} elsif ($a eq 5 && $b eq 26) {
		print -21;
	} elsif ($a eq 5 && $b eq 27) {
		print -22;
	} elsif ($a eq 5 && $b eq 28) {
		print -23;
	} elsif ($a eq 5 && $b eq 29) {
		print -24;
	} elsif ($a eq 5 && $b eq 30) {
		print -25;
	} elsif ($a eq 5 && $b eq 31) {
		print -26;
	} elsif ($a eq 5 && $b eq 32) {
		print -27;
	} elsif ($a eq 5 && $b eq 33) {
		print -28;
	} elsif ($a eq 5 && $b eq 34) {
		print -29;
	} elsif ($a eq 5 && $b eq 35) {
		print -30;
	} elsif ($a eq 5 && $b eq 36) {
		print -31;
	} elsif ($a eq 5 && $b eq 37) {
		print -32;
	} elsif ($a eq 5 && $b eq 38) {
		print -33;
	} elsif ($a eq 5 && $b eq 39) {
		print -34;
	} elsif ($a eq 5 && $b eq 40) {
		print -35;
	} elsif ($a eq 5 && $b eq 41) {
		print -36;
	} elsif ($a eq 5 && $b eq 42) {
		print -37;
	} elsif ($a eq 5 && $b eq 43) {
		print -38;
	} elsif ($a eq 5 && $b eq 44) {
		print -39;
	} elsif ($a eq 5 && $b eq 45) {
		print -40;
	} elsif ($a eq 5 && $b eq 46) {
		print -41;
	} elsif ($a eq 5 && $b eq 47) {
		print -42;
	} elsif ($a eq 5 && $b eq 48) {
		print -43;
	} elsif ($a eq 5 && $b eq 49) {
		print -44;
	} elsif ($a eq 5 && $b eq 50) {
		print -45;
	} elsif ($a eq 6 && $b eq 0) {
		print 6;
	} elsif ($a eq 6 && $b eq 1) {
		print 5;
	} elsif ($a eq 6 && $b eq 2) {
		print 4;
	} elsif ($a eq 6 && $b eq 3) {
		print 3;
	} elsif ($a eq 6 && $b eq 4) {
		print 2;
	} elsif ($a eq 6 && $b eq 5) {
		print 1;
	} elsif ($a eq 6 && $b eq 6) {
		print 0;
	} elsif ($a eq 6 && $b eq 7) {
		print -1;
	} elsif ($a eq 6 && $b eq 8) {
		print -2;
	} elsif ($a eq 6 && $b eq 9) {
		print -3;
	} elsif ($a eq 6 && $b eq 10) {
		print -4;
	} elsif ($a eq 6 && $b eq 11) {
		print -5;
	} elsif ($a eq 6 && $b eq 12) {
		print -6;
	} elsif ($a eq 6 && $b eq 13) {
		print -7;
	} elsif ($a eq 6 && $b eq 14) {
		print -8;
	} elsif ($a eq 6 && $b eq 15) {
		print -9;
	} elsif ($a eq 6 && $b eq 16) {
		print -10;
	} elsif ($a eq 6 && $b eq 17) {
		print -11;
	} elsif ($a eq 6 && $b eq 18) {
		print -12;
	} elsif ($a eq 6 && $b eq 19) {
		print -13;
	} elsif ($a eq 6 && $b eq 20) {
		print -14;
	} elsif ($a eq 6 && $b eq 21) {
		print -15;
	} elsif ($a eq 6 && $b eq 22) {
		print -16;
	} elsif ($a eq 6 && $b eq 23) {
		print -17;
	} elsif ($a eq 6 && $b eq 24) {
		print -18;
	} elsif ($a eq 6 && $b eq 25) {
		print -19;
	} elsif ($a eq 6 && $b eq 26) {
		print -20;
	} elsif ($a eq 6 && $b eq 27) {
		print -21;
	} elsif ($a eq 6 && $b eq 28) {
		print -22;
	} elsif ($a eq 6 && $b eq 29) {
		print -23;
	} elsif ($a eq 6 && $b eq 30) {
		print -24;
	} elsif ($a eq 6 && $b eq 31) {
		print -25;
	} elsif ($a eq 6 && $b eq 32) {
		print -26;
	} elsif ($a eq 6 && $b eq 33) {
		print -27;
	} elsif ($a eq 6 && $b eq 34) {
		print -28;
	} elsif ($a eq 6 && $b eq 35) {
		print -29;
	} elsif ($a eq 6 && $b eq 36) {
		print -30;
	} elsif ($a eq 6 && $b eq 37) {
		print -31;
	} elsif ($a eq 6 && $b eq 38) {
		print -32;
	} elsif ($a eq 6 && $b eq 39) {
		print -33;
	} elsif ($a eq 6 && $b eq 40) {
		print -34;
	} elsif ($a eq 6 && $b eq 41) {
		print -35;
	} elsif ($a eq 6 && $b eq 42) {
		print -36;
	} elsif ($a eq 6 && $b eq 43) {
		print -37;
	} elsif ($a eq 6 && $b eq 44) {
		print -38;
	} elsif ($a eq 6 && $b eq 45) {
		print -39;
	} elsif ($a eq 6 && $b eq 46) {
		print -40;
	} elsif ($a eq 6 && $b eq 47) {
		print -41;
	} elsif ($a eq 6 && $b eq 48) {
		print -42;
	} elsif ($a eq 6 && $b eq 49) {
		print -43;
	} elsif ($a eq 6 && $b eq 50) {
		print -44;
	} elsif ($a eq 7 && $b eq 0) {
		print 7;
	} elsif ($a eq 7 && $b eq 1) {
		print 6;
	} elsif ($a eq 7 && $b eq 2) {
		print 5;
	} elsif ($a eq 7 && $b eq 3) {
		print 4;
	} elsif ($a eq 7 && $b eq 4) {
		print 3;
	} elsif ($a eq 7 && $b eq 5) {
		print 2;
	} elsif ($a eq 7 && $b eq 6) {
		print 1;
	} elsif ($a eq 7 && $b eq 7) {
		print 0;
	} elsif ($a eq 7 && $b eq 8) {
		print -1;
	} elsif ($a eq 7 && $b eq 9) {
		print -2;
	} elsif ($a eq 7 && $b eq 10) {
		print -3;
	} elsif ($a eq 7 && $b eq 11) {
		print -4;
	} elsif ($a eq 7 && $b eq 12) {
		print -5;
	} elsif ($a eq 7 && $b eq 13) {
		print -6;
	} elsif ($a eq 7 && $b eq 14) {
		print -7;
	} elsif ($a eq 7 && $b eq 15) {
		print -8;
	} elsif ($a eq 7 && $b eq 16) {
		print -9;
	} elsif ($a eq 7 && $b eq 17) {
		print -10;
	} elsif ($a eq 7 && $b eq 18) {
		print -11;
	} elsif ($a eq 7 && $b eq 19) {
		print -12;
	} elsif ($a eq 7 && $b eq 20) {
		print -13;
	} elsif ($a eq 7 && $b eq 21) {
		print -14;
	} elsif ($a eq 7 && $b eq 22) {
		print -15;
	} elsif ($a eq 7 && $b eq 23) {
		print -16;
	} elsif ($a eq 7 && $b eq 24) {
		print -17;
	} elsif ($a eq 7 && $b eq 25) {
		print -18;
	} elsif ($a eq 7 && $b eq 26) {
		print -19;
	} elsif ($a eq 7 && $b eq 27) {
		print -20;
	} elsif ($a eq 7 && $b eq 28) {
		print -21;
	} elsif ($a eq 7 && $b eq 29) {
		print -22;
	} elsif ($a eq 7 && $b eq 30) {
		print -23;
	} elsif ($a eq 7 && $b eq 31) {
		print -24;
	} elsif ($a eq 7 && $b eq 32) {
		print -25;
	} elsif ($a eq 7 && $b eq 33) {
		print -26;
	} elsif ($a eq 7 && $b eq 34) {
		print -27;
	} elsif ($a eq 7 && $b eq 35) {
		print -28;
	} elsif ($a eq 7 && $b eq 36) {
		print -29;
	} elsif ($a eq 7 && $b eq 37) {
		print -30;
	} elsif ($a eq 7 && $b eq 38) {
		print -31;
	} elsif ($a eq 7 && $b eq 39) {
		print -32;
	} elsif ($a eq 7 && $b eq 40) {
		print -33;
	} elsif ($a eq 7 && $b eq 41) {
		print -34;
	} elsif ($a eq 7 && $b eq 42) {
		print -35;
	} elsif ($a eq 7 && $b eq 43) {
		print -36;
	} elsif ($a eq 7 && $b eq 44) {
		print -37;
	} elsif ($a eq 7 && $b eq 45) {
		print -38;
	} elsif ($a eq 7 && $b eq 46) {
		print -39;
	} elsif ($a eq 7 && $b eq 47) {
		print -40;
	} elsif ($a eq 7 && $b eq 48) {
		print -41;
	} elsif ($a eq 7 && $b eq 49) {
		print -42;
	} elsif ($a eq 7 && $b eq 50) {
		print -43;
	} elsif ($a eq 8 && $b eq 0) {
		print 8;
	} elsif ($a eq 8 && $b eq 1) {
		print 7;
	} elsif ($a eq 8 && $b eq 2) {
		print 6;
	} elsif ($a eq 8 && $b eq 3) {
		print 5;
	} elsif ($a eq 8 && $b eq 4) {
		print 4;
	} elsif ($a eq 8 && $b eq 5) {
		print 3;
	} elsif ($a eq 8 && $b eq 6) {
		print 2;
	} elsif ($a eq 8 && $b eq 7) {
		print 1;
	} elsif ($a eq 8 && $b eq 8) {
		print 0;
	} elsif ($a eq 8 && $b eq 9) {
		print -1;
	} elsif ($a eq 8 && $b eq 10) {
		print -2;
	} elsif ($a eq 8 && $b eq 11) {
		print -3;
	} elsif ($a eq 8 && $b eq 12) {
		print -4;
	} elsif ($a eq 8 && $b eq 13) {
		print -5;
	} elsif ($a eq 8 && $b eq 14) {
		print -6;
	} elsif ($a eq 8 && $b eq 15) {
		print -7;
	} elsif ($a eq 8 && $b eq 16) {
		print -8;
	} elsif ($a eq 8 && $b eq 17) {
		print -9;
	} elsif ($a eq 8 && $b eq 18) {
		print -10;
	} elsif ($a eq 8 && $b eq 19) {
		print -11;
	} elsif ($a eq 8 && $b eq 20) {
		print -12;
	} elsif ($a eq 8 && $b eq 21) {
		print -13;
	} elsif ($a eq 8 && $b eq 22) {
		print -14;
	} elsif ($a eq 8 && $b eq 23) {
		print -15;
	} elsif ($a eq 8 && $b eq 24) {
		print -16;
	} elsif ($a eq 8 && $b eq 25) {
		print -17;
	} elsif ($a eq 8 && $b eq 26) {
		print -18;
	} elsif ($a eq 8 && $b eq 27) {
		print -19;
	} elsif ($a eq 8 && $b eq 28) {
		print -20;
	} elsif ($a eq 8 && $b eq 29) {
		print -21;
	} elsif ($a eq 8 && $b eq 30) {
		print -22;
	} elsif ($a eq 8 && $b eq 31) {
		print -23;
	} elsif ($a eq 8 && $b eq 32) {
		print -24;
	} elsif ($a eq 8 && $b eq 33) {
		print -25;
	} elsif ($a eq 8 && $b eq 34) {
		print -26;
	} elsif ($a eq 8 && $b eq 35) {
		print -27;
	} elsif ($a eq 8 && $b eq 36) {
		print -28;
	} elsif ($a eq 8 && $b eq 37) {
		print -29;
	} elsif ($a eq 8 && $b eq 38) {
		print -30;
	} elsif ($a eq 8 && $b eq 39) {
		print -31;
	} elsif ($a eq 8 && $b eq 40) {
		print -32;
	} elsif ($a eq 8 && $b eq 41) {
		print -33;
	} elsif ($a eq 8 && $b eq 42) {
		print -34;
	} elsif ($a eq 8 && $b eq 43) {
		print -35;
	} elsif ($a eq 8 && $b eq 44) {
		print -36;
	} elsif ($a eq 8 && $b eq 45) {
		print -37;
	} elsif ($a eq 8 && $b eq 46) {
		print -38;
	} elsif ($a eq 8 && $b eq 47) {
		print -39;
	} elsif ($a eq 8 && $b eq 48) {
		print -40;
	} elsif ($a eq 8 && $b eq 49) {
		print -41;
	} elsif ($a eq 8 && $b eq 50) {
		print -42;
	} elsif ($a eq 9 && $b eq 0) {
		print 9;
	} elsif ($a eq 9 && $b eq 1) {
		print 8;
	} elsif ($a eq 9 && $b eq 2) {
		print 7;
	} elsif ($a eq 9 && $b eq 3) {
		print 6;
	} elsif ($a eq 9 && $b eq 4) {
		print 5;
	} elsif ($a eq 9 && $b eq 5) {
		print 4;
	} elsif ($a eq 9 && $b eq 6) {
		print 3;
	} elsif ($a eq 9 && $b eq 7) {
		print 2;
	} elsif ($a eq 9 && $b eq 8) {
		print 1;
	} elsif ($a eq 9 && $b eq 9) {
		print 0;
	} elsif ($a eq 9 && $b eq 10) {
		print -1;
	} elsif ($a eq 9 && $b eq 11) {
		print -2;
	} elsif ($a eq 9 && $b eq 12) {
		print -3;
	} elsif ($a eq 9 && $b eq 13) {
		print -4;
	} elsif ($a eq 9 && $b eq 14) {
		print -5;
	} elsif ($a eq 9 && $b eq 15) {
		print -6;
	} elsif ($a eq 9 && $b eq 16) {
		print -7;
	} elsif ($a eq 9 && $b eq 17) {
		print -8;
	} elsif ($a eq 9 && $b eq 18) {
		print -9;
	} elsif ($a eq 9 && $b eq 19) {
		print -10;
	} elsif ($a eq 9 && $b eq 20) {
		print -11;
	} elsif ($a eq 9 && $b eq 21) {
		print -12;
	} elsif ($a eq 9 && $b eq 22) {
		print -13;
	} elsif ($a eq 9 && $b eq 23) {
		print -14;
	} elsif ($a eq 9 && $b eq 24) {
		print -15;
	} elsif ($a eq 9 && $b eq 25) {
		print -16;
	} elsif ($a eq 9 && $b eq 26) {
		print -17;
	} elsif ($a eq 9 && $b eq 27) {
		print -18;
	} elsif ($a eq 9 && $b eq 28) {
		print -19;
	} elsif ($a eq 9 && $b eq 29) {
		print -20;
	} elsif ($a eq 9 && $b eq 30) {
		print -21;
	} elsif ($a eq 9 && $b eq 31) {
		print -22;
	} elsif ($a eq 9 && $b eq 32) {
		print -23;
	} elsif ($a eq 9 && $b eq 33) {
		print -24;
	} elsif ($a eq 9 && $b eq 34) {
		print -25;
	} elsif ($a eq 9 && $b eq 35) {
		print -26;
	} elsif ($a eq 9 && $b eq 36) {
		print -27;
	} elsif ($a eq 9 && $b eq 37) {
		print -28;
	} elsif ($a eq 9 && $b eq 38) {
		print -29;
	} elsif ($a eq 9 && $b eq 39) {
		print -30;
	} elsif ($a eq 9 && $b eq 40) {
		print -31;
	} elsif ($a eq 9 && $b eq 41) {
		print -32;
	} elsif ($a eq 9 && $b eq 42) {
		print -33;
	} elsif ($a eq 9 && $b eq 43) {
		print -34;
	} elsif ($a eq 9 && $b eq 44) {
		print -35;
	} elsif ($a eq 9 && $b eq 45) {
		print -36;
	} elsif ($a eq 9 && $b eq 46) {
		print -37;
	} elsif ($a eq 9 && $b eq 47) {
		print -38;
	} elsif ($a eq 9 && $b eq 48) {
		print -39;
	} elsif ($a eq 9 && $b eq 49) {
		print -40;
	} elsif ($a eq 9 && $b eq 50) {
		print -41;
	} elsif ($a eq 10 && $b eq 0) {
		print 10;
	} elsif ($a eq 10 && $b eq 1) {
		print 9;
	} elsif ($a eq 10 && $b eq 2) {
		print 8;
	} elsif ($a eq 10 && $b eq 3) {
		print 7;
	} elsif ($a eq 10 && $b eq 4) {
		print 6;
	} elsif ($a eq 10 && $b eq 5) {
		print 5;
	} elsif ($a eq 10 && $b eq 6) {
		print 4;
	} elsif ($a eq 10 && $b eq 7) {
		print 3;
	} elsif ($a eq 10 && $b eq 8) {
		print 2;
	} elsif ($a eq 10 && $b eq 9) {
		print 1;
	} elsif ($a eq 10 && $b eq 10) {
		print 0;
	} elsif ($a eq 10 && $b eq 11) {
		print -1;
	} elsif ($a eq 10 && $b eq 12) {
		print -2;
	} elsif ($a eq 10 && $b eq 13) {
		print -3;
	} elsif ($a eq 10 && $b eq 14) {
		print -4;
	} elsif ($a eq 10 && $b eq 15) {
		print -5;
	} elsif ($a eq 10 && $b eq 16) {
		print -6;
	} elsif ($a eq 10 && $b eq 17) {
		print -7;
	} elsif ($a eq 10 && $b eq 18) {
		print -8;
	} elsif ($a eq 10 && $b eq 19) {
		print -9;
	} elsif ($a eq 10 && $b eq 20) {
		print -10;
	} elsif ($a eq 10 && $b eq 21) {
		print -11;
	} elsif ($a eq 10 && $b eq 22) {
		print -12;
	} elsif ($a eq 10 && $b eq 23) {
		print -13;
	} elsif ($a eq 10 && $b eq 24) {
		print -14;
	} elsif ($a eq 10 && $b eq 25) {
		print -15;
	} elsif ($a eq 10 && $b eq 26) {
		print -16;
	} elsif ($a eq 10 && $b eq 27) {
		print -17;
	} elsif ($a eq 10 && $b eq 28) {
		print -18;
	} elsif ($a eq 10 && $b eq 29) {
		print -19;
	} elsif ($a eq 10 && $b eq 30) {
		print -20;
	} elsif ($a eq 10 && $b eq 31) {
		print -21;
	} elsif ($a eq 10 && $b eq 32) {
		print -22;
	} elsif ($a eq 10 && $b eq 33) {
		print -23;
	} elsif ($a eq 10 && $b eq 34) {
		print -24;
	} elsif ($a eq 10 && $b eq 35) {
		print -25;
	} elsif ($a eq 10 && $b eq 36) {
		print -26;
	} elsif ($a eq 10 && $b eq 37) {
		print -27;
	} elsif ($a eq 10 && $b eq 38) {
		print -28;
	} elsif ($a eq 10 && $b eq 39) {
		print -29;
	} elsif ($a eq 10 && $b eq 40) {
		print -30;
	} elsif ($a eq 10 && $b eq 41) {
		print -31;
	} elsif ($a eq 10 && $b eq 42) {
		print -32;
	} elsif ($a eq 10 && $b eq 43) {
		print -33;
	} elsif ($a eq 10 && $b eq 44) {
		print -34;
	} elsif ($a eq 10 && $b eq 45) {
		print -35;
	} elsif ($a eq 10 && $b eq 46) {
		print -36;
	} elsif ($a eq 10 && $b eq 47) {
		print -37;
	} elsif ($a eq 10 && $b eq 48) {
		print -38;
	} elsif ($a eq 10 && $b eq 49) {
		print -39;
	} elsif ($a eq 10 && $b eq 50) {
		print -40;
	} elsif ($a eq 11 && $b eq 0) {
		print 11;
	} elsif ($a eq 11 && $b eq 1) {
		print 10;
	} elsif ($a eq 11 && $b eq 2) {
		print 9;
	} elsif ($a eq 11 && $b eq 3) {
		print 8;
	} elsif ($a eq 11 && $b eq 4) {
		print 7;
	} elsif ($a eq 11 && $b eq 5) {
		print 6;
	} elsif ($a eq 11 && $b eq 6) {
		print 5;
	} elsif ($a eq 11 && $b eq 7) {
		print 4;
	} elsif ($a eq 11 && $b eq 8) {
		print 3;
	} elsif ($a eq 11 && $b eq 9) {
		print 2;
	} elsif ($a eq 11 && $b eq 10) {
		print 1;
	} elsif ($a eq 11 && $b eq 11) {
		print 0;
	} elsif ($a eq 11 && $b eq 12) {
		print -1;
	} elsif ($a eq 11 && $b eq 13) {
		print -2;
	} elsif ($a eq 11 && $b eq 14) {
		print -3;
	} elsif ($a eq 11 && $b eq 15) {
		print -4;
	} elsif ($a eq 11 && $b eq 16) {
		print -5;
	} elsif ($a eq 11 && $b eq 17) {
		print -6;
	} elsif ($a eq 11 && $b eq 18) {
		print -7;
	} elsif ($a eq 11 && $b eq 19) {
		print -8;
	} elsif ($a eq 11 && $b eq 20) {
		print -9;
	} elsif ($a eq 11 && $b eq 21) {
		print -10;
	} elsif ($a eq 11 && $b eq 22) {
		print -11;
	} elsif ($a eq 11 && $b eq 23) {
		print -12;
	} elsif ($a eq 11 && $b eq 24) {
		print -13;
	} elsif ($a eq 11 && $b eq 25) {
		print -14;
	} elsif ($a eq 11 && $b eq 26) {
		print -15;
	} elsif ($a eq 11 && $b eq 27) {
		print -16;
	} elsif ($a eq 11 && $b eq 28) {
		print -17;
	} elsif ($a eq 11 && $b eq 29) {
		print -18;
	} elsif ($a eq 11 && $b eq 30) {
		print -19;
	} elsif ($a eq 11 && $b eq 31) {
		print -20;
	} elsif ($a eq 11 && $b eq 32) {
		print -21;
	} elsif ($a eq 11 && $b eq 33) {
		print -22;
	} elsif ($a eq 11 && $b eq 34) {
		print -23;
	} elsif ($a eq 11 && $b eq 35) {
		print -24;
	} elsif ($a eq 11 && $b eq 36) {
		print -25;
	} elsif ($a eq 11 && $b eq 37) {
		print -26;
	} elsif ($a eq 11 && $b eq 38) {
		print -27;
	} elsif ($a eq 11 && $b eq 39) {
		print -28;
	} elsif ($a eq 11 && $b eq 40) {
		print -29;
	} elsif ($a eq 11 && $b eq 41) {
		print -30;
	} elsif ($a eq 11 && $b eq 42) {
		print -31;
	} elsif ($a eq 11 && $b eq 43) {
		print -32;
	} elsif ($a eq 11 && $b eq 44) {
		print -33;
	} elsif ($a eq 11 && $b eq 45) {
		print -34;
	} elsif ($a eq 11 && $b eq 46) {
		print -35;
	} elsif ($a eq 11 && $b eq 47) {
		print -36;
	} elsif ($a eq 11 && $b eq 48) {
		print -37;
	} elsif ($a eq 11 && $b eq 49) {
		print -38;
	} elsif ($a eq 11 && $b eq 50) {
		print -39;
	} elsif ($a eq 12 && $b eq 0) {
		print 12;
	} elsif ($a eq 12 && $b eq 1) {
		print 11;
	} elsif ($a eq 12 && $b eq 2) {
		print 10;
	} elsif ($a eq 12 && $b eq 3) {
		print 9;
	} elsif ($a eq 12 && $b eq 4) {
		print 8;
	} elsif ($a eq 12 && $b eq 5) {
		print 7;
	} elsif ($a eq 12 && $b eq 6) {
		print 6;
	} elsif ($a eq 12 && $b eq 7) {
		print 5;
	} elsif ($a eq 12 && $b eq 8) {
		print 4;
	} elsif ($a eq 12 && $b eq 9) {
		print 3;
	} elsif ($a eq 12 && $b eq 10) {
		print 2;
	} elsif ($a eq 12 && $b eq 11) {
		print 1;
	} elsif ($a eq 12 && $b eq 12) {
		print 0;
	} elsif ($a eq 12 && $b eq 13) {
		print -1;
	} elsif ($a eq 12 && $b eq 14) {
		print -2;
	} elsif ($a eq 12 && $b eq 15) {
		print -3;
	} elsif ($a eq 12 && $b eq 16) {
		print -4;
	} elsif ($a eq 12 && $b eq 17) {
		print -5;
	} elsif ($a eq 12 && $b eq 18) {
		print -6;
	} elsif ($a eq 12 && $b eq 19) {
		print -7;
	} elsif ($a eq 12 && $b eq 20) {
		print -8;
	} elsif ($a eq 12 && $b eq 21) {
		print -9;
	} elsif ($a eq 12 && $b eq 22) {
		print -10;
	} elsif ($a eq 12 && $b eq 23) {
		print -11;
	} elsif ($a eq 12 && $b eq 24) {
		print -12;
	} elsif ($a eq 12 && $b eq 25) {
		print -13;
	} elsif ($a eq 12 && $b eq 26) {
		print -14;
	} elsif ($a eq 12 && $b eq 27) {
		print -15;
	} elsif ($a eq 12 && $b eq 28) {
		print -16;
	} elsif ($a eq 12 && $b eq 29) {
		print -17;
	} elsif ($a eq 12 && $b eq 30) {
		print -18;
	} elsif ($a eq 12 && $b eq 31) {
		print -19;
	} elsif ($a eq 12 && $b eq 32) {
		print -20;
	} elsif ($a eq 12 && $b eq 33) {
		print -21;
	} elsif ($a eq 12 && $b eq 34) {
		print -22;
	} elsif ($a eq 12 && $b eq 35) {
		print -23;
	} elsif ($a eq 12 && $b eq 36) {
		print -24;
	} elsif ($a eq 12 && $b eq 37) {
		print -25;
	} elsif ($a eq 12 && $b eq 38) {
		print -26;
	} elsif ($a eq 12 && $b eq 39) {
		print -27;
	} elsif ($a eq 12 && $b eq 40) {
		print -28;
	} elsif ($a eq 12 && $b eq 41) {
		print -29;
	} elsif ($a eq 12 && $b eq 42) {
		print -30;
	} elsif ($a eq 12 && $b eq 43) {
		print -31;
	} elsif ($a eq 12 && $b eq 44) {
		print -32;
	} elsif ($a eq 12 && $b eq 45) {
		print -33;
	} elsif ($a eq 12 && $b eq 46) {
		print -34;
	} elsif ($a eq 12 && $b eq 47) {
		print -35;
	} elsif ($a eq 12 && $b eq 48) {
		print -36;
	} elsif ($a eq 12 && $b eq 49) {
		print -37;
	} elsif ($a eq 12 && $b eq 50) {
		print -38;
	} elsif ($a eq 13 && $b eq 0) {
		print 13;
	} elsif ($a eq 13 && $b eq 1) {
		print 12;
	} elsif ($a eq 13 && $b eq 2) {
		print 11;
	} elsif ($a eq 13 && $b eq 3) {
		print 10;
	} elsif ($a eq 13 && $b eq 4) {
		print 9;
	} elsif ($a eq 13 && $b eq 5) {
		print 8;
	} elsif ($a eq 13 && $b eq 6) {
		print 7;
	} elsif ($a eq 13 && $b eq 7) {
		print 6;
	} elsif ($a eq 13 && $b eq 8) {
		print 5;
	} elsif ($a eq 13 && $b eq 9) {
		print 4;
	} elsif ($a eq 13 && $b eq 10) {
		print 3;
	} elsif ($a eq 13 && $b eq 11) {
		print 2;
	} elsif ($a eq 13 && $b eq 12) {
		print 1;
	} elsif ($a eq 13 && $b eq 13) {
		print 0;
	} elsif ($a eq 13 && $b eq 14) {
		print -1;
	} elsif ($a eq 13 && $b eq 15) {
		print -2;
	} elsif ($a eq 13 && $b eq 16) {
		print -3;
	} elsif ($a eq 13 && $b eq 17) {
		print -4;
	} elsif ($a eq 13 && $b eq 18) {
		print -5;
	} elsif ($a eq 13 && $b eq 19) {
		print -6;
	} elsif ($a eq 13 && $b eq 20) {
		print -7;
	} elsif ($a eq 13 && $b eq 21) {
		print -8;
	} elsif ($a eq 13 && $b eq 22) {
		print -9;
	} elsif ($a eq 13 && $b eq 23) {
		print -10;
	} elsif ($a eq 13 && $b eq 24) {
		print -11;
	} elsif ($a eq 13 && $b eq 25) {
		print -12;
	} elsif ($a eq 13 && $b eq 26) {
		print -13;
	} elsif ($a eq 13 && $b eq 27) {
		print -14;
	} elsif ($a eq 13 && $b eq 28) {
		print -15;
	} elsif ($a eq 13 && $b eq 29) {
		print -16;
	} elsif ($a eq 13 && $b eq 30) {
		print -17;
	} elsif ($a eq 13 && $b eq 31) {
		print -18;
	} elsif ($a eq 13 && $b eq 32) {
		print -19;
	} elsif ($a eq 13 && $b eq 33) {
		print -20;
	} elsif ($a eq 13 && $b eq 34) {
		print -21;
	} elsif ($a eq 13 && $b eq 35) {
		print -22;
	} elsif ($a eq 13 && $b eq 36) {
		print -23;
	} elsif ($a eq 13 && $b eq 37) {
		print -24;
	} elsif ($a eq 13 && $b eq 38) {
		print -25;
	} elsif ($a eq 13 && $b eq 39) {
		print -26;
	} elsif ($a eq 13 && $b eq 40) {
		print -27;
	} elsif ($a eq 13 && $b eq 41) {
		print -28;
	} elsif ($a eq 13 && $b eq 42) {
		print -29;
	} elsif ($a eq 13 && $b eq 43) {
		print -30;
	} elsif ($a eq 13 && $b eq 44) {
		print -31;
	} elsif ($a eq 13 && $b eq 45) {
		print -32;
	} elsif ($a eq 13 && $b eq 46) {
		print -33;
	} elsif ($a eq 13 && $b eq 47) {
		print -34;
	} elsif ($a eq 13 && $b eq 48) {
		print -35;
	} elsif ($a eq 13 && $b eq 49) {
		print -36;
	} elsif ($a eq 13 && $b eq 50) {
		print -37;
	} elsif ($a eq 14 && $b eq 0) {
		print 14;
	} elsif ($a eq 14 && $b eq 1) {
		print 13;
	} elsif ($a eq 14 && $b eq 2) {
		print 12;
	} elsif ($a eq 14 && $b eq 3) {
		print 11;
	} elsif ($a eq 14 && $b eq 4) {
		print 10;
	} elsif ($a eq 14 && $b eq 5) {
		print 9;
	} elsif ($a eq 14 && $b eq 6) {
		print 8;
	} elsif ($a eq 14 && $b eq 7) {
		print 7;
	} elsif ($a eq 14 && $b eq 8) {
		print 6;
	} elsif ($a eq 14 && $b eq 9) {
		print 5;
	} elsif ($a eq 14 && $b eq 10) {
		print 4;
	} elsif ($a eq 14 && $b eq 11) {
		print 3;
	} elsif ($a eq 14 && $b eq 12) {
		print 2;
	} elsif ($a eq 14 && $b eq 13) {
		print 1;
	} elsif ($a eq 14 && $b eq 14) {
		print 0;
	} elsif ($a eq 14 && $b eq 15) {
		print -1;
	} elsif ($a eq 14 && $b eq 16) {
		print -2;
	} elsif ($a eq 14 && $b eq 17) {
		print -3;
	} elsif ($a eq 14 && $b eq 18) {
		print -4;
	} elsif ($a eq 14 && $b eq 19) {
		print -5;
	} elsif ($a eq 14 && $b eq 20) {
		print -6;
	} elsif ($a eq 14 && $b eq 21) {
		print -7;
	} elsif ($a eq 14 && $b eq 22) {
		print -8;
	} elsif ($a eq 14 && $b eq 23) {
		print -9;
	} elsif ($a eq 14 && $b eq 24) {
		print -10;
	} elsif ($a eq 14 && $b eq 25) {
		print -11;
	} elsif ($a eq 14 && $b eq 26) {
		print -12;
	} elsif ($a eq 14 && $b eq 27) {
		print -13;
	} elsif ($a eq 14 && $b eq 28) {
		print -14;
	} elsif ($a eq 14 && $b eq 29) {
		print -15;
	} elsif ($a eq 14 && $b eq 30) {
		print -16;
	} elsif ($a eq 14 && $b eq 31) {
		print -17;
	} elsif ($a eq 14 && $b eq 32) {
		print -18;
	} elsif ($a eq 14 && $b eq 33) {
		print -19;
	} elsif ($a eq 14 && $b eq 34) {
		print -20;
	} elsif ($a eq 14 && $b eq 35) {
		print -21;
	} elsif ($a eq 14 && $b eq 36) {
		print -22;
	} elsif ($a eq 14 && $b eq 37) {
		print -23;
	} elsif ($a eq 14 && $b eq 38) {
		print -24;
	} elsif ($a eq 14 && $b eq 39) {
		print -25;
	} elsif ($a eq 14 && $b eq 40) {
		print -26;
	} elsif ($a eq 14 && $b eq 41) {
		print -27;
	} elsif ($a eq 14 && $b eq 42) {
		print -28;
	} elsif ($a eq 14 && $b eq 43) {
		print -29;
	} elsif ($a eq 14 && $b eq 44) {
		print -30;
	} elsif ($a eq 14 && $b eq 45) {
		print -31;
	} elsif ($a eq 14 && $b eq 46) {
		print -32;
	} elsif ($a eq 14 && $b eq 47) {
		print -33;
	} elsif ($a eq 14 && $b eq 48) {
		print -34;
	} elsif ($a eq 14 && $b eq 49) {
		print -35;
	} elsif ($a eq 14 && $b eq 50) {
		print -36;
	} elsif ($a eq 15 && $b eq 0) {
		print 15;
	} elsif ($a eq 15 && $b eq 1) {
		print 14;
	} elsif ($a eq 15 && $b eq 2) {
		print 13;
	} elsif ($a eq 15 && $b eq 3) {
		print 12;
	} elsif ($a eq 15 && $b eq 4) {
		print 11;
	} elsif ($a eq 15 && $b eq 5) {
		print 10;
	} elsif ($a eq 15 && $b eq 6) {
		print 9;
	} elsif ($a eq 15 && $b eq 7) {
		print 8;
	} elsif ($a eq 15 && $b eq 8) {
		print 7;
	} elsif ($a eq 15 && $b eq 9) {
		print 6;
	} elsif ($a eq 15 && $b eq 10) {
		print 5;
	} elsif ($a eq 15 && $b eq 11) {
		print 4;
	} elsif ($a eq 15 && $b eq 12) {
		print 3;
	} elsif ($a eq 15 && $b eq 13) {
		print 2;
	} elsif ($a eq 15 && $b eq 14) {
		print 1;
	} elsif ($a eq 15 && $b eq 15) {
		print 0;
	} elsif ($a eq 15 && $b eq 16) {
		print -1;
	} elsif ($a eq 15 && $b eq 17) {
		print -2;
	} elsif ($a eq 15 && $b eq 18) {
		print -3;
	} elsif ($a eq 15 && $b eq 19) {
		print -4;
	} elsif ($a eq 15 && $b eq 20) {
		print -5;
	} elsif ($a eq 15 && $b eq 21) {
		print -6;
	} elsif ($a eq 15 && $b eq 22) {
		print -7;
	} elsif ($a eq 15 && $b eq 23) {
		print -8;
	} elsif ($a eq 15 && $b eq 24) {
		print -9;
	} elsif ($a eq 15 && $b eq 25) {
		print -10;
	} elsif ($a eq 15 && $b eq 26) {
		print -11;
	} elsif ($a eq 15 && $b eq 27) {
		print -12;
	} elsif ($a eq 15 && $b eq 28) {
		print -13;
	} elsif ($a eq 15 && $b eq 29) {
		print -14;
	} elsif ($a eq 15 && $b eq 30) {
		print -15;
	} elsif ($a eq 15 && $b eq 31) {
		print -16;
	} elsif ($a eq 15 && $b eq 32) {
		print -17;
	} elsif ($a eq 15 && $b eq 33) {
		print -18;
	} elsif ($a eq 15 && $b eq 34) {
		print -19;
	} elsif ($a eq 15 && $b eq 35) {
		print -20;
	} elsif ($a eq 15 && $b eq 36) {
		print -21;
	} elsif ($a eq 15 && $b eq 37) {
		print -22;
	} elsif ($a eq 15 && $b eq 38) {
		print -23;
	} elsif ($a eq 15 && $b eq 39) {
		print -24;
	} elsif ($a eq 15 && $b eq 40) {
		print -25;
	} elsif ($a eq 15 && $b eq 41) {
		print -26;
	} elsif ($a eq 15 && $b eq 42) {
		print -27;
	} elsif ($a eq 15 && $b eq 43) {
		print -28;
	} elsif ($a eq 15 && $b eq 44) {
		print -29;
	} elsif ($a eq 15 && $b eq 45) {
		print -30;
	} elsif ($a eq 15 && $b eq 46) {
		print -31;
	} elsif ($a eq 15 && $b eq 47) {
		print -32;
	} elsif ($a eq 15 && $b eq 48) {
		print -33;
	} elsif ($a eq 15 && $b eq 49) {
		print -34;
	} elsif ($a eq 15 && $b eq 50) {
		print -35;
	} elsif ($a eq 16 && $b eq 0) {
		print 16;
	} elsif ($a eq 16 && $b eq 1) {
		print 15;
	} elsif ($a eq 16 && $b eq 2) {
		print 14;
	} elsif ($a eq 16 && $b eq 3) {
		print 13;
	} elsif ($a eq 16 && $b eq 4) {
		print 12;
	} elsif ($a eq 16 && $b eq 5) {
		print 11;
	} elsif ($a eq 16 && $b eq 6) {
		print 10;
	} elsif ($a eq 16 && $b eq 7) {
		print 9;
	} elsif ($a eq 16 && $b eq 8) {
		print 8;
	} elsif ($a eq 16 && $b eq 9) {
		print 7;
	} elsif ($a eq 16 && $b eq 10) {
		print 6;
	} elsif ($a eq 16 && $b eq 11) {
		print 5;
	} elsif ($a eq 16 && $b eq 12) {
		print 4;
	} elsif ($a eq 16 && $b eq 13) {
		print 3;
	} elsif ($a eq 16 && $b eq 14) {
		print 2;
	} elsif ($a eq 16 && $b eq 15) {
		print 1;
	} elsif ($a eq 16 && $b eq 16) {
		print 0;
	} elsif ($a eq 16 && $b eq 17) {
		print -1;
	} elsif ($a eq 16 && $b eq 18) {
		print -2;
	} elsif ($a eq 16 && $b eq 19) {
		print -3;
	} elsif ($a eq 16 && $b eq 20) {
		print -4;
	} elsif ($a eq 16 && $b eq 21) {
		print -5;
	} elsif ($a eq 16 && $b eq 22) {
		print -6;
	} elsif ($a eq 16 && $b eq 23) {
		print -7;
	} elsif ($a eq 16 && $b eq 24) {
		print -8;
	} elsif ($a eq 16 && $b eq 25) {
		print -9;
	} elsif ($a eq 16 && $b eq 26) {
		print -10;
	} elsif ($a eq 16 && $b eq 27) {
		print -11;
	} elsif ($a eq 16 && $b eq 28) {
		print -12;
	} elsif ($a eq 16 && $b eq 29) {
		print -13;
	} elsif ($a eq 16 && $b eq 30) {
		print -14;
	} elsif ($a eq 16 && $b eq 31) {
		print -15;
	} elsif ($a eq 16 && $b eq 32) {
		print -16;
	} elsif ($a eq 16 && $b eq 33) {
		print -17;
	} elsif ($a eq 16 && $b eq 34) {
		print -18;
	} elsif ($a eq 16 && $b eq 35) {
		print -19;
	} elsif ($a eq 16 && $b eq 36) {
		print -20;
	} elsif ($a eq 16 && $b eq 37) {
		print -21;
	} elsif ($a eq 16 && $b eq 38) {
		print -22;
	} elsif ($a eq 16 && $b eq 39) {
		print -23;
	} elsif ($a eq 16 && $b eq 40) {
		print -24;
	} elsif ($a eq 16 && $b eq 41) {
		print -25;
	} elsif ($a eq 16 && $b eq 42) {
		print -26;
	} elsif ($a eq 16 && $b eq 43) {
		print -27;
	} elsif ($a eq 16 && $b eq 44) {
		print -28;
	} elsif ($a eq 16 && $b eq 45) {
		print -29;
	} elsif ($a eq 16 && $b eq 46) {
		print -30;
	} elsif ($a eq 16 && $b eq 47) {
		print -31;
	} elsif ($a eq 16 && $b eq 48) {
		print -32;
	} elsif ($a eq 16 && $b eq 49) {
		print -33;
	} elsif ($a eq 16 && $b eq 50) {
		print -34;
	} elsif ($a eq 17 && $b eq 0) {
		print 17;
	} elsif ($a eq 17 && $b eq 1) {
		print 16;
	} elsif ($a eq 17 && $b eq 2) {
		print 15;
	} elsif ($a eq 17 && $b eq 3) {
		print 14;
	} elsif ($a eq 17 && $b eq 4) {
		print 13;
	} elsif ($a eq 17 && $b eq 5) {
		print 12;
	} elsif ($a eq 17 && $b eq 6) {
		print 11;
	} elsif ($a eq 17 && $b eq 7) {
		print 10;
	} elsif ($a eq 17 && $b eq 8) {
		print 9;
	} elsif ($a eq 17 && $b eq 9) {
		print 8;
	} elsif ($a eq 17 && $b eq 10) {
		print 7;
	} elsif ($a eq 17 && $b eq 11) {
		print 6;
	} elsif ($a eq 17 && $b eq 12) {
		print 5;
	} elsif ($a eq 17 && $b eq 13) {
		print 4;
	} elsif ($a eq 17 && $b eq 14) {
		print 3;
	} elsif ($a eq 17 && $b eq 15) {
		print 2;
	} elsif ($a eq 17 && $b eq 16) {
		print 1;
	} elsif ($a eq 17 && $b eq 17) {
		print 0;
	} elsif ($a eq 17 && $b eq 18) {
		print -1;
	} elsif ($a eq 17 && $b eq 19) {
		print -2;
	} elsif ($a eq 17 && $b eq 20) {
		print -3;
	} elsif ($a eq 17 && $b eq 21) {
		print -4;
	} elsif ($a eq 17 && $b eq 22) {
		print -5;
	} elsif ($a eq 17 && $b eq 23) {
		print -6;
	} elsif ($a eq 17 && $b eq 24) {
		print -7;
	} elsif ($a eq 17 && $b eq 25) {
		print -8;
	} elsif ($a eq 17 && $b eq 26) {
		print -9;
	} elsif ($a eq 17 && $b eq 27) {
		print -10;
	} elsif ($a eq 17 && $b eq 28) {
		print -11;
	} elsif ($a eq 17 && $b eq 29) {
		print -12;
	} elsif ($a eq 17 && $b eq 30) {
		print -13;
	} elsif ($a eq 17 && $b eq 31) {
		print -14;
	} elsif ($a eq 17 && $b eq 32) {
		print -15;
	} elsif ($a eq 17 && $b eq 33) {
		print -16;
	} elsif ($a eq 17 && $b eq 34) {
		print -17;
	} elsif ($a eq 17 && $b eq 35) {
		print -18;
	} elsif ($a eq 17 && $b eq 36) {
		print -19;
	} elsif ($a eq 17 && $b eq 37) {
		print -20;
	} elsif ($a eq 17 && $b eq 38) {
		print -21;
	} elsif ($a eq 17 && $b eq 39) {
		print -22;
	} elsif ($a eq 17 && $b eq 40) {
		print -23;
	} elsif ($a eq 17 && $b eq 41) {
		print -24;
	} elsif ($a eq 17 && $b eq 42) {
		print -25;
	} elsif ($a eq 17 && $b eq 43) {
		print -26;
	} elsif ($a eq 17 && $b eq 44) {
		print -27;
	} elsif ($a eq 17 && $b eq 45) {
		print -28;
	} elsif ($a eq 17 && $b eq 46) {
		print -29;
	} elsif ($a eq 17 && $b eq 47) {
		print -30;
	} elsif ($a eq 17 && $b eq 48) {
		print -31;
	} elsif ($a eq 17 && $b eq 49) {
		print -32;
	} elsif ($a eq 17 && $b eq 50) {
		print -33;
	} elsif ($a eq 18 && $b eq 0) {
		print 18;
	} elsif ($a eq 18 && $b eq 1) {
		print 17;
	} elsif ($a eq 18 && $b eq 2) {
		print 16;
	} elsif ($a eq 18 && $b eq 3) {
		print 15;
	} elsif ($a eq 18 && $b eq 4) {
		print 14;
	} elsif ($a eq 18 && $b eq 5) {
		print 13;
	} elsif ($a eq 18 && $b eq 6) {
		print 12;
	} elsif ($a eq 18 && $b eq 7) {
		print 11;
	} elsif ($a eq 18 && $b eq 8) {
		print 10;
	} elsif ($a eq 18 && $b eq 9) {
		print 9;
	} elsif ($a eq 18 && $b eq 10) {
		print 8;
	} elsif ($a eq 18 && $b eq 11) {
		print 7;
	} elsif ($a eq 18 && $b eq 12) {
		print 6;
	} elsif ($a eq 18 && $b eq 13) {
		print 5;
	} elsif ($a eq 18 && $b eq 14) {
		print 4;
	} elsif ($a eq 18 && $b eq 15) {
		print 3;
	} elsif ($a eq 18 && $b eq 16) {
		print 2;
	} elsif ($a eq 18 && $b eq 17) {
		print 1;
	} elsif ($a eq 18 && $b eq 18) {
		print 0;
	} elsif ($a eq 18 && $b eq 19) {
		print -1;
	} elsif ($a eq 18 && $b eq 20) {
		print -2;
	} elsif ($a eq 18 && $b eq 21) {
		print -3;
	} elsif ($a eq 18 && $b eq 22) {
		print -4;
	} elsif ($a eq 18 && $b eq 23) {
		print -5;
	} elsif ($a eq 18 && $b eq 24) {
		print -6;
	} elsif ($a eq 18 && $b eq 25) {
		print -7;
	} elsif ($a eq 18 && $b eq 26) {
		print -8;
	} elsif ($a eq 18 && $b eq 27) {
		print -9;
	} elsif ($a eq 18 && $b eq 28) {
		print -10;
	} elsif ($a eq 18 && $b eq 29) {
		print -11;
	} elsif ($a eq 18 && $b eq 30) {
		print -12;
	} elsif ($a eq 18 && $b eq 31) {
		print -13;
	} elsif ($a eq 18 && $b eq 32) {
		print -14;
	} elsif ($a eq 18 && $b eq 33) {
		print -15;
	} elsif ($a eq 18 && $b eq 34) {
		print -16;
	} elsif ($a eq 18 && $b eq 35) {
		print -17;
	} elsif ($a eq 18 && $b eq 36) {
		print -18;
	} elsif ($a eq 18 && $b eq 37) {
		print -19;
	} elsif ($a eq 18 && $b eq 38) {
		print -20;
	} elsif ($a eq 18 && $b eq 39) {
		print -21;
	} elsif ($a eq 18 && $b eq 40) {
		print -22;
	} elsif ($a eq 18 && $b eq 41) {
		print -23;
	} elsif ($a eq 18 && $b eq 42) {
		print -24;
	} elsif ($a eq 18 && $b eq 43) {
		print -25;
	} elsif ($a eq 18 && $b eq 44) {
		print -26;
	} elsif ($a eq 18 && $b eq 45) {
		print -27;
	} elsif ($a eq 18 && $b eq 46) {
		print -28;
	} elsif ($a eq 18 && $b eq 47) {
		print -29;
	} elsif ($a eq 18 && $b eq 48) {
		print -30;
	} elsif ($a eq 18 && $b eq 49) {
		print -31;
	} elsif ($a eq 18 && $b eq 50) {
		print -32;
	} elsif ($a eq 19 && $b eq 0) {
		print 19;
	} elsif ($a eq 19 && $b eq 1) {
		print 18;
	} elsif ($a eq 19 && $b eq 2) {
		print 17;
	} elsif ($a eq 19 && $b eq 3) {
		print 16;
	} elsif ($a eq 19 && $b eq 4) {
		print 15;
	} elsif ($a eq 19 && $b eq 5) {
		print 14;
	} elsif ($a eq 19 && $b eq 6) {
		print 13;
	} elsif ($a eq 19 && $b eq 7) {
		print 12;
	} elsif ($a eq 19 && $b eq 8) {
		print 11;
	} elsif ($a eq 19 && $b eq 9) {
		print 10;
	} elsif ($a eq 19 && $b eq 10) {
		print 9;
	} elsif ($a eq 19 && $b eq 11) {
		print 8;
	} elsif ($a eq 19 && $b eq 12) {
		print 7;
	} elsif ($a eq 19 && $b eq 13) {
		print 6;
	} elsif ($a eq 19 && $b eq 14) {
		print 5;
	} elsif ($a eq 19 && $b eq 15) {
		print 4;
	} elsif ($a eq 19 && $b eq 16) {
		print 3;
	} elsif ($a eq 19 && $b eq 17) {
		print 2;
	} elsif ($a eq 19 && $b eq 18) {
		print 1;
	} elsif ($a eq 19 && $b eq 19) {
		print 0;
	} elsif ($a eq 19 && $b eq 20) {
		print -1;
	} elsif ($a eq 19 && $b eq 21) {
		print -2;
	} elsif ($a eq 19 && $b eq 22) {
		print -3;
	} elsif ($a eq 19 && $b eq 23) {
		print -4;
	} elsif ($a eq 19 && $b eq 24) {
		print -5;
	} elsif ($a eq 19 && $b eq 25) {
		print -6;
	} elsif ($a eq 19 && $b eq 26) {
		print -7;
	} elsif ($a eq 19 && $b eq 27) {
		print -8;
	} elsif ($a eq 19 && $b eq 28) {
		print -9;
	} elsif ($a eq 19 && $b eq 29) {
		print -10;
	} elsif ($a eq 19 && $b eq 30) {
		print -11;
	} elsif ($a eq 19 && $b eq 31) {
		print -12;
	} elsif ($a eq 19 && $b eq 32) {
		print -13;
	} elsif ($a eq 19 && $b eq 33) {
		print -14;
	} elsif ($a eq 19 && $b eq 34) {
		print -15;
	} elsif ($a eq 19 && $b eq 35) {
		print -16;
	} elsif ($a eq 19 && $b eq 36) {
		print -17;
	} elsif ($a eq 19 && $b eq 37) {
		print -18;
	} elsif ($a eq 19 && $b eq 38) {
		print -19;
	} elsif ($a eq 19 && $b eq 39) {
		print -20;
	} elsif ($a eq 19 && $b eq 40) {
		print -21;
	} elsif ($a eq 19 && $b eq 41) {
		print -22;
	} elsif ($a eq 19 && $b eq 42) {
		print -23;
	} elsif ($a eq 19 && $b eq 43) {
		print -24;
	} elsif ($a eq 19 && $b eq 44) {
		print -25;
	} elsif ($a eq 19 && $b eq 45) {
		print -26;
	} elsif ($a eq 19 && $b eq 46) {
		print -27;
	} elsif ($a eq 19 && $b eq 47) {
		print -28;
	} elsif ($a eq 19 && $b eq 48) {
		print -29;
	} elsif ($a eq 19 && $b eq 49) {
		print -30;
	} elsif ($a eq 19 && $b eq 50) {
		print -31;
	} elsif ($a eq 20 && $b eq 0) {
		print 20;
	} elsif ($a eq 20 && $b eq 1) {
		print 19;
	} elsif ($a eq 20 && $b eq 2) {
		print 18;
	} elsif ($a eq 20 && $b eq 3) {
		print 17;
	} elsif ($a eq 20 && $b eq 4) {
		print 16;
	} elsif ($a eq 20 && $b eq 5) {
		print 15;
	} elsif ($a eq 20 && $b eq 6) {
		print 14;
	} elsif ($a eq 20 && $b eq 7) {
		print 13;
	} elsif ($a eq 20 && $b eq 8) {
		print 12;
	} elsif ($a eq 20 && $b eq 9) {
		print 11;
	} elsif ($a eq 20 && $b eq 10) {
		print 10;
	} elsif ($a eq 20 && $b eq 11) {
		print 9;
	} elsif ($a eq 20 && $b eq 12) {
		print 8;
	} elsif ($a eq 20 && $b eq 13) {
		print 7;
	} elsif ($a eq 20 && $b eq 14) {
		print 6;
	} elsif ($a eq 20 && $b eq 15) {
		print 5;
	} elsif ($a eq 20 && $b eq 16) {
		print 4;
	} elsif ($a eq 20 && $b eq 17) {
		print 3;
	} elsif ($a eq 20 && $b eq 18) {
		print 2;
	} elsif ($a eq 20 && $b eq 19) {
		print 1;
	} elsif ($a eq 20 && $b eq 20) {
		print 0;
	} elsif ($a eq 20 && $b eq 21) {
		print -1;
	} elsif ($a eq 20 && $b eq 22) {
		print -2;
	} elsif ($a eq 20 && $b eq 23) {
		print -3;
	} elsif ($a eq 20 && $b eq 24) {
		print -4;
	} elsif ($a eq 20 && $b eq 25) {
		print -5;
	} elsif ($a eq 20 && $b eq 26) {
		print -6;
	} elsif ($a eq 20 && $b eq 27) {
		print -7;
	} elsif ($a eq 20 && $b eq 28) {
		print -8;
	} elsif ($a eq 20 && $b eq 29) {
		print -9;
	} elsif ($a eq 20 && $b eq 30) {
		print -10;
	} elsif ($a eq 20 && $b eq 31) {
		print -11;
	} elsif ($a eq 20 && $b eq 32) {
		print -12;
	} elsif ($a eq 20 && $b eq 33) {
		print -13;
	} elsif ($a eq 20 && $b eq 34) {
		print -14;
	} elsif ($a eq 20 && $b eq 35) {
		print -15;
	} elsif ($a eq 20 && $b eq 36) {
		print -16;
	} elsif ($a eq 20 && $b eq 37) {
		print -17;
	} elsif ($a eq 20 && $b eq 38) {
		print -18;
	} elsif ($a eq 20 && $b eq 39) {
		print -19;
	} elsif ($a eq 20 && $b eq 40) {
		print -20;
	} elsif ($a eq 20 && $b eq 41) {
		print -21;
	} elsif ($a eq 20 && $b eq 42) {
		print -22;
	} elsif ($a eq 20 && $b eq 43) {
		print -23;
	} elsif ($a eq 20 && $b eq 44) {
		print -24;
	} elsif ($a eq 20 && $b eq 45) {
		print -25;
	} elsif ($a eq 20 && $b eq 46) {
		print -26;
	} elsif ($a eq 20 && $b eq 47) {
		print -27;
	} elsif ($a eq 20 && $b eq 48) {
		print -28;
	} elsif ($a eq 20 && $b eq 49) {
		print -29;
	} elsif ($a eq 20 && $b eq 50) {
		print -30;
	} elsif ($a eq 21 && $b eq 0) {
		print 21;
	} elsif ($a eq 21 && $b eq 1) {
		print 20;
	} elsif ($a eq 21 && $b eq 2) {
		print 19;
	} elsif ($a eq 21 && $b eq 3) {
		print 18;
	} elsif ($a eq 21 && $b eq 4) {
		print 17;
	} elsif ($a eq 21 && $b eq 5) {
		print 16;
	} elsif ($a eq 21 && $b eq 6) {
		print 15;
	} elsif ($a eq 21 && $b eq 7) {
		print 14;
	} elsif ($a eq 21 && $b eq 8) {
		print 13;
	} elsif ($a eq 21 && $b eq 9) {
		print 12;
	} elsif ($a eq 21 && $b eq 10) {
		print 11;
	} elsif ($a eq 21 && $b eq 11) {
		print 10;
	} elsif ($a eq 21 && $b eq 12) {
		print 9;
	} elsif ($a eq 21 && $b eq 13) {
		print 8;
	} elsif ($a eq 21 && $b eq 14) {
		print 7;
	} elsif ($a eq 21 && $b eq 15) {
		print 6;
	} elsif ($a eq 21 && $b eq 16) {
		print 5;
	} elsif ($a eq 21 && $b eq 17) {
		print 4;
	} elsif ($a eq 21 && $b eq 18) {
		print 3;
	} elsif ($a eq 21 && $b eq 19) {
		print 2;
	} elsif ($a eq 21 && $b eq 20) {
		print 1;
	} elsif ($a eq 21 && $b eq 21) {
		print 0;
	} elsif ($a eq 21 && $b eq 22) {
		print -1;
	} elsif ($a eq 21 && $b eq 23) {
		print -2;
	} elsif ($a eq 21 && $b eq 24) {
		print -3;
	} elsif ($a eq 21 && $b eq 25) {
		print -4;
	} elsif ($a eq 21 && $b eq 26) {
		print -5;
	} elsif ($a eq 21 && $b eq 27) {
		print -6;
	} elsif ($a eq 21 && $b eq 28) {
		print -7;
	} elsif ($a eq 21 && $b eq 29) {
		print -8;
	} elsif ($a eq 21 && $b eq 30) {
		print -9;
	} elsif ($a eq 21 && $b eq 31) {
		print -10;
	} elsif ($a eq 21 && $b eq 32) {
		print -11;
	} elsif ($a eq 21 && $b eq 33) {
		print -12;
	} elsif ($a eq 21 && $b eq 34) {
		print -13;
	} elsif ($a eq 21 && $b eq 35) {
		print -14;
	} elsif ($a eq 21 && $b eq 36) {
		print -15;
	} elsif ($a eq 21 && $b eq 37) {
		print -16;
	} elsif ($a eq 21 && $b eq 38) {
		print -17;
	} elsif ($a eq 21 && $b eq 39) {
		print -18;
	} elsif ($a eq 21 && $b eq 40) {
		print -19;
	} elsif ($a eq 21 && $b eq 41) {
		print -20;
	} elsif ($a eq 21 && $b eq 42) {
		print -21;
	} elsif ($a eq 21 && $b eq 43) {
		print -22;
	} elsif ($a eq 21 && $b eq 44) {
		print -23;
	} elsif ($a eq 21 && $b eq 45) {
		print -24;
	} elsif ($a eq 21 && $b eq 46) {
		print -25;
	} elsif ($a eq 21 && $b eq 47) {
		print -26;
	} elsif ($a eq 21 && $b eq 48) {
		print -27;
	} elsif ($a eq 21 && $b eq 49) {
		print -28;
	} elsif ($a eq 21 && $b eq 50) {
		print -29;
	} elsif ($a eq 22 && $b eq 0) {
		print 22;
	} elsif ($a eq 22 && $b eq 1) {
		print 21;
	} elsif ($a eq 22 && $b eq 2) {
		print 20;
	} elsif ($a eq 22 && $b eq 3) {
		print 19;
	} elsif ($a eq 22 && $b eq 4) {
		print 18;
	} elsif ($a eq 22 && $b eq 5) {
		print 17;
	} elsif ($a eq 22 && $b eq 6) {
		print 16;
	} elsif ($a eq 22 && $b eq 7) {
		print 15;
	} elsif ($a eq 22 && $b eq 8) {
		print 14;
	} elsif ($a eq 22 && $b eq 9) {
		print 13;
	} elsif ($a eq 22 && $b eq 10) {
		print 12;
	} elsif ($a eq 22 && $b eq 11) {
		print 11;
	} elsif ($a eq 22 && $b eq 12) {
		print 10;
	} elsif ($a eq 22 && $b eq 13) {
		print 9;
	} elsif ($a eq 22 && $b eq 14) {
		print 8;
	} elsif ($a eq 22 && $b eq 15) {
		print 7;
	} elsif ($a eq 22 && $b eq 16) {
		print 6;
	} elsif ($a eq 22 && $b eq 17) {
		print 5;
	} elsif ($a eq 22 && $b eq 18) {
		print 4;
	} elsif ($a eq 22 && $b eq 19) {
		print 3;
	} elsif ($a eq 22 && $b eq 20) {
		print 2;
	} elsif ($a eq 22 && $b eq 21) {
		print 1;
	} elsif ($a eq 22 && $b eq 22) {
		print 0;
	} elsif ($a eq 22 && $b eq 23) {
		print -1;
	} elsif ($a eq 22 && $b eq 24) {
		print -2;
	} elsif ($a eq 22 && $b eq 25) {
		print -3;
	} elsif ($a eq 22 && $b eq 26) {
		print -4;
	} elsif ($a eq 22 && $b eq 27) {
		print -5;
	} elsif ($a eq 22 && $b eq 28) {
		print -6;
	} elsif ($a eq 22 && $b eq 29) {
		print -7;
	} elsif ($a eq 22 && $b eq 30) {
		print -8;
	} elsif ($a eq 22 && $b eq 31) {
		print -9;
	} elsif ($a eq 22 && $b eq 32) {
		print -10;
	} elsif ($a eq 22 && $b eq 33) {
		print -11;
	} elsif ($a eq 22 && $b eq 34) {
		print -12;
	} elsif ($a eq 22 && $b eq 35) {
		print -13;
	} elsif ($a eq 22 && $b eq 36) {
		print -14;
	} elsif ($a eq 22 && $b eq 37) {
		print -15;
	} elsif ($a eq 22 && $b eq 38) {
		print -16;
	} elsif ($a eq 22 && $b eq 39) {
		print -17;
	} elsif ($a eq 22 && $b eq 40) {
		print -18;
	} elsif ($a eq 22 && $b eq 41) {
		print -19;
	} elsif ($a eq 22 && $b eq 42) {
		print -20;
	} elsif ($a eq 22 && $b eq 43) {
		print -21;
	} elsif ($a eq 22 && $b eq 44) {
		print -22;
	} elsif ($a eq 22 && $b eq 45) {
		print -23;
	} elsif ($a eq 22 && $b eq 46) {
		print -24;
	} elsif ($a eq 22 && $b eq 47) {
		print -25;
	} elsif ($a eq 22 && $b eq 48) {
		print -26;
	} elsif ($a eq 22 && $b eq 49) {
		print -27;
	} elsif ($a eq 22 && $b eq 50) {
		print -28;
	} elsif ($a eq 23 && $b eq 0) {
		print 23;
	} elsif ($a eq 23 && $b eq 1) {
		print 22;
	} elsif ($a eq 23 && $b eq 2) {
		print 21;
	} elsif ($a eq 23 && $b eq 3) {
		print 20;
	} elsif ($a eq 23 && $b eq 4) {
		print 19;
	} elsif ($a eq 23 && $b eq 5) {
		print 18;
	} elsif ($a eq 23 && $b eq 6) {
		print 17;
	} elsif ($a eq 23 && $b eq 7) {
		print 16;
	} elsif ($a eq 23 && $b eq 8) {
		print 15;
	} elsif ($a eq 23 && $b eq 9) {
		print 14;
	} elsif ($a eq 23 && $b eq 10) {
		print 13;
	} elsif ($a eq 23 && $b eq 11) {
		print 12;
	} elsif ($a eq 23 && $b eq 12) {
		print 11;
	} elsif ($a eq 23 && $b eq 13) {
		print 10;
	} elsif ($a eq 23 && $b eq 14) {
		print 9;
	} elsif ($a eq 23 && $b eq 15) {
		print 8;
	} elsif ($a eq 23 && $b eq 16) {
		print 7;
	} elsif ($a eq 23 && $b eq 17) {
		print 6;
	} elsif ($a eq 23 && $b eq 18) {
		print 5;
	} elsif ($a eq 23 && $b eq 19) {
		print 4;
	} elsif ($a eq 23 && $b eq 20) {
		print 3;
	} elsif ($a eq 23 && $b eq 21) {
		print 2;
	} elsif ($a eq 23 && $b eq 22) {
		print 1;
	} elsif ($a eq 23 && $b eq 23) {
		print 0;
	} elsif ($a eq 23 && $b eq 24) {
		print -1;
	} elsif ($a eq 23 && $b eq 25) {
		print -2;
	} elsif ($a eq 23 && $b eq 26) {
		print -3;
	} elsif ($a eq 23 && $b eq 27) {
		print -4;
	} elsif ($a eq 23 && $b eq 28) {
		print -5;
	} elsif ($a eq 23 && $b eq 29) {
		print -6;
	} elsif ($a eq 23 && $b eq 30) {
		print -7;
	} elsif ($a eq 23 && $b eq 31) {
		print -8;
	} elsif ($a eq 23 && $b eq 32) {
		print -9;
	} elsif ($a eq 23 && $b eq 33) {
		print -10;
	} elsif ($a eq 23 && $b eq 34) {
		print -11;
	} elsif ($a eq 23 && $b eq 35) {
		print -12;
	} elsif ($a eq 23 && $b eq 36) {
		print -13;
	} elsif ($a eq 23 && $b eq 37) {
		print -14;
	} elsif ($a eq 23 && $b eq 38) {
		print -15;
	} elsif ($a eq 23 && $b eq 39) {
		print -16;
	} elsif ($a eq 23 && $b eq 40) {
		print -17;
	} elsif ($a eq 23 && $b eq 41) {
		print -18;
	} elsif ($a eq 23 && $b eq 42) {
		print -19;
	} elsif ($a eq 23 && $b eq 43) {
		print -20;
	} elsif ($a eq 23 && $b eq 44) {
		print -21;
	} elsif ($a eq 23 && $b eq 45) {
		print -22;
	} elsif ($a eq 23 && $b eq 46) {
		print -23;
	} elsif ($a eq 23 && $b eq 47) {
		print -24;
	} elsif ($a eq 23 && $b eq 48) {
		print -25;
	} elsif ($a eq 23 && $b eq 49) {
		print -26;
	} elsif ($a eq 23 && $b eq 50) {
		print -27;
	} elsif ($a eq 24 && $b eq 0) {
		print 24;
	} elsif ($a eq 24 && $b eq 1) {
		print 23;
	} elsif ($a eq 24 && $b eq 2) {
		print 22;
	} elsif ($a eq 24 && $b eq 3) {
		print 21;
	} elsif ($a eq 24 && $b eq 4) {
		print 20;
	} elsif ($a eq 24 && $b eq 5) {
		print 19;
	} elsif ($a eq 24 && $b eq 6) {
		print 18;
	} elsif ($a eq 24 && $b eq 7) {
		print 17;
	} elsif ($a eq 24 && $b eq 8) {
		print 16;
	} elsif ($a eq 24 && $b eq 9) {
		print 15;
	} elsif ($a eq 24 && $b eq 10) {
		print 14;
	} elsif ($a eq 24 && $b eq 11) {
		print 13;
	} elsif ($a eq 24 && $b eq 12) {
		print 12;
	} elsif ($a eq 24 && $b eq 13) {
		print 11;
	} elsif ($a eq 24 && $b eq 14) {
		print 10;
	} elsif ($a eq 24 && $b eq 15) {
		print 9;
	} elsif ($a eq 24 && $b eq 16) {
		print 8;
	} elsif ($a eq 24 && $b eq 17) {
		print 7;
	} elsif ($a eq 24 && $b eq 18) {
		print 6;
	} elsif ($a eq 24 && $b eq 19) {
		print 5;
	} elsif ($a eq 24 && $b eq 20) {
		print 4;
	} elsif ($a eq 24 && $b eq 21) {
		print 3;
	} elsif ($a eq 24 && $b eq 22) {
		print 2;
	} elsif ($a eq 24 && $b eq 23) {
		print 1;
	} elsif ($a eq 24 && $b eq 24) {
		print 0;
	} elsif ($a eq 24 && $b eq 25) {
		print -1;
	} elsif ($a eq 24 && $b eq 26) {
		print -2;
	} elsif ($a eq 24 && $b eq 27) {
		print -3;
	} elsif ($a eq 24 && $b eq 28) {
		print -4;
	} elsif ($a eq 24 && $b eq 29) {
		print -5;
	} elsif ($a eq 24 && $b eq 30) {
		print -6;
	} elsif ($a eq 24 && $b eq 31) {
		print -7;
	} elsif ($a eq 24 && $b eq 32) {
		print -8;
	} elsif ($a eq 24 && $b eq 33) {
		print -9;
	} elsif ($a eq 24 && $b eq 34) {
		print -10;
	} elsif ($a eq 24 && $b eq 35) {
		print -11;
	} elsif ($a eq 24 && $b eq 36) {
		print -12;
	} elsif ($a eq 24 && $b eq 37) {
		print -13;
	} elsif ($a eq 24 && $b eq 38) {
		print -14;
	} elsif ($a eq 24 && $b eq 39) {
		print -15;
	} elsif ($a eq 24 && $b eq 40) {
		print -16;
	} elsif ($a eq 24 && $b eq 41) {
		print -17;
	} elsif ($a eq 24 && $b eq 42) {
		print -18;
	} elsif ($a eq 24 && $b eq 43) {
		print -19;
	} elsif ($a eq 24 && $b eq 44) {
		print -20;
	} elsif ($a eq 24 && $b eq 45) {
		print -21;
	} elsif ($a eq 24 && $b eq 46) {
		print -22;
	} elsif ($a eq 24 && $b eq 47) {
		print -23;
	} elsif ($a eq 24 && $b eq 48) {
		print -24;
	} elsif ($a eq 24 && $b eq 49) {
		print -25;
	} elsif ($a eq 24 && $b eq 50) {
		print -26;
	} elsif ($a eq 25 && $b eq 0) {
		print 25;
	} elsif ($a eq 25 && $b eq 1) {
		print 24;
	} elsif ($a eq 25 && $b eq 2) {
		print 23;
	} elsif ($a eq 25 && $b eq 3) {
		print 22;
	} elsif ($a eq 25 && $b eq 4) {
		print 21;
	} elsif ($a eq 25 && $b eq 5) {
		print 20;
	} elsif ($a eq 25 && $b eq 6) {
		print 19;
	} elsif ($a eq 25 && $b eq 7) {
		print 18;
	} elsif ($a eq 25 && $b eq 8) {
		print 17;
	} elsif ($a eq 25 && $b eq 9) {
		print 16;
	} elsif ($a eq 25 && $b eq 10) {
		print 15;
	} elsif ($a eq 25 && $b eq 11) {
		print 14;
	} elsif ($a eq 25 && $b eq 12) {
		print 13;
	} elsif ($a eq 25 && $b eq 13) {
		print 12;
	} elsif ($a eq 25 && $b eq 14) {
		print 11;
	} elsif ($a eq 25 && $b eq 15) {
		print 10;
	} elsif ($a eq 25 && $b eq 16) {
		print 9;
	} elsif ($a eq 25 && $b eq 17) {
		print 8;
	} elsif ($a eq 25 && $b eq 18) {
		print 7;
	} elsif ($a eq 25 && $b eq 19) {
		print 6;
	} elsif ($a eq 25 && $b eq 20) {
		print 5;
	} elsif ($a eq 25 && $b eq 21) {
		print 4;
	} elsif ($a eq 25 && $b eq 22) {
		print 3;
	} elsif ($a eq 25 && $b eq 23) {
		print 2;
	} elsif ($a eq 25 && $b eq 24) {
		print 1;
	} elsif ($a eq 25 && $b eq 25) {
		print 0;
	} elsif ($a eq 25 && $b eq 26) {
		print -1;
	} elsif ($a eq 25 && $b eq 27) {
		print -2;
	} elsif ($a eq 25 && $b eq 28) {
		print -3;
	} elsif ($a eq 25 && $b eq 29) {
		print -4;
	} elsif ($a eq 25 && $b eq 30) {
		print -5;
	} elsif ($a eq 25 && $b eq 31) {
		print -6;
	} elsif ($a eq 25 && $b eq 32) {
		print -7;
	} elsif ($a eq 25 && $b eq 33) {
		print -8;
	} elsif ($a eq 25 && $b eq 34) {
		print -9;
	} elsif ($a eq 25 && $b eq 35) {
		print -10;
	} elsif ($a eq 25 && $b eq 36) {
		print -11;
	} elsif ($a eq 25 && $b eq 37) {
		print -12;
	} elsif ($a eq 25 && $b eq 38) {
		print -13;
	} elsif ($a eq 25 && $b eq 39) {
		print -14;
	} elsif ($a eq 25 && $b eq 40) {
		print -15;
	} elsif ($a eq 25 && $b eq 41) {
		print -16;
	} elsif ($a eq 25 && $b eq 42) {
		print -17;
	} elsif ($a eq 25 && $b eq 43) {
		print -18;
	} elsif ($a eq 25 && $b eq 44) {
		print -19;
	} elsif ($a eq 25 && $b eq 45) {
		print -20;
	} elsif ($a eq 25 && $b eq 46) {
		print -21;
	} elsif ($a eq 25 && $b eq 47) {
		print -22;
	} elsif ($a eq 25 && $b eq 48) {
		print -23;
	} elsif ($a eq 25 && $b eq 49) {
		print -24;
	} elsif ($a eq 25 && $b eq 50) {
		print -25;
	} elsif ($a eq 26 && $b eq 0) {
		print 26;
	} elsif ($a eq 26 && $b eq 1) {
		print 25;
	} elsif ($a eq 26 && $b eq 2) {
		print 24;
	} elsif ($a eq 26 && $b eq 3) {
		print 23;
	} elsif ($a eq 26 && $b eq 4) {
		print 22;
	} elsif ($a eq 26 && $b eq 5) {
		print 21;
	} elsif ($a eq 26 && $b eq 6) {
		print 20;
	} elsif ($a eq 26 && $b eq 7) {
		print 19;
	} elsif ($a eq 26 && $b eq 8) {
		print 18;
	} elsif ($a eq 26 && $b eq 9) {
		print 17;
	} elsif ($a eq 26 && $b eq 10) {
		print 16;
	} elsif ($a eq 26 && $b eq 11) {
		print 15;
	} elsif ($a eq 26 && $b eq 12) {
		print 14;
	} elsif ($a eq 26 && $b eq 13) {
		print 13;
	} elsif ($a eq 26 && $b eq 14) {
		print 12;
	} elsif ($a eq 26 && $b eq 15) {
		print 11;
	} elsif ($a eq 26 && $b eq 16) {
		print 10;
	} elsif ($a eq 26 && $b eq 17) {
		print 9;
	} elsif ($a eq 26 && $b eq 18) {
		print 8;
	} elsif ($a eq 26 && $b eq 19) {
		print 7;
	} elsif ($a eq 26 && $b eq 20) {
		print 6;
	} elsif ($a eq 26 && $b eq 21) {
		print 5;
	} elsif ($a eq 26 && $b eq 22) {
		print 4;
	} elsif ($a eq 26 && $b eq 23) {
		print 3;
	} elsif ($a eq 26 && $b eq 24) {
		print 2;
	} elsif ($a eq 26 && $b eq 25) {
		print 1;
	} elsif ($a eq 26 && $b eq 26) {
		print 0;
	} elsif ($a eq 26 && $b eq 27) {
		print -1;
	} elsif ($a eq 26 && $b eq 28) {
		print -2;
	} elsif ($a eq 26 && $b eq 29) {
		print -3;
	} elsif ($a eq 26 && $b eq 30) {
		print -4;
	} elsif ($a eq 26 && $b eq 31) {
		print -5;
	} elsif ($a eq 26 && $b eq 32) {
		print -6;
	} elsif ($a eq 26 && $b eq 33) {
		print -7;
	} elsif ($a eq 26 && $b eq 34) {
		print -8;
	} elsif ($a eq 26 && $b eq 35) {
		print -9;
	} elsif ($a eq 26 && $b eq 36) {
		print -10;
	} elsif ($a eq 26 && $b eq 37) {
		print -11;
	} elsif ($a eq 26 && $b eq 38) {
		print -12;
	} elsif ($a eq 26 && $b eq 39) {
		print -13;
	} elsif ($a eq 26 && $b eq 40) {
		print -14;
	} elsif ($a eq 26 && $b eq 41) {
		print -15;
	} elsif ($a eq 26 && $b eq 42) {
		print -16;
	} elsif ($a eq 26 && $b eq 43) {
		print -17;
	} elsif ($a eq 26 && $b eq 44) {
		print -18;
	} elsif ($a eq 26 && $b eq 45) {
		print -19;
	} elsif ($a eq 26 && $b eq 46) {
		print -20;
	} elsif ($a eq 26 && $b eq 47) {
		print -21;
	} elsif ($a eq 26 && $b eq 48) {
		print -22;
	} elsif ($a eq 26 && $b eq 49) {
		print -23;
	} elsif ($a eq 26 && $b eq 50) {
		print -24;
	} elsif ($a eq 27 && $b eq 0) {
		print 27;
	} elsif ($a eq 27 && $b eq 1) {
		print 26;
	} elsif ($a eq 27 && $b eq 2) {
		print 25;
	} elsif ($a eq 27 && $b eq 3) {
		print 24;
	} elsif ($a eq 27 && $b eq 4) {
		print 23;
	} elsif ($a eq 27 && $b eq 5) {
		print 22;
	} elsif ($a eq 27 && $b eq 6) {
		print 21;
	} elsif ($a eq 27 && $b eq 7) {
		print 20;
	} elsif ($a eq 27 && $b eq 8) {
		print 19;
	} elsif ($a eq 27 && $b eq 9) {
		print 18;
	} elsif ($a eq 27 && $b eq 10) {
		print 17;
	} elsif ($a eq 27 && $b eq 11) {
		print 16;
	} elsif ($a eq 27 && $b eq 12) {
		print 15;
	} elsif ($a eq 27 && $b eq 13) {
		print 14;
	} elsif ($a eq 27 && $b eq 14) {
		print 13;
	} elsif ($a eq 27 && $b eq 15) {
		print 12;
	} elsif ($a eq 27 && $b eq 16) {
		print 11;
	} elsif ($a eq 27 && $b eq 17) {
		print 10;
	} elsif ($a eq 27 && $b eq 18) {
		print 9;
	} elsif ($a eq 27 && $b eq 19) {
		print 8;
	} elsif ($a eq 27 && $b eq 20) {
		print 7;
	} elsif ($a eq 27 && $b eq 21) {
		print 6;
	} elsif ($a eq 27 && $b eq 22) {
		print 5;
	} elsif ($a eq 27 && $b eq 23) {
		print 4;
	} elsif ($a eq 27 && $b eq 24) {
		print 3;
	} elsif ($a eq 27 && $b eq 25) {
		print 2;
	} elsif ($a eq 27 && $b eq 26) {
		print 1;
	} elsif ($a eq 27 && $b eq 27) {
		print 0;
	} elsif ($a eq 27 && $b eq 28) {
		print -1;
	} elsif ($a eq 27 && $b eq 29) {
		print -2;
	} elsif ($a eq 27 && $b eq 30) {
		print -3;
	} elsif ($a eq 27 && $b eq 31) {
		print -4;
	} elsif ($a eq 27 && $b eq 32) {
		print -5;
	} elsif ($a eq 27 && $b eq 33) {
		print -6;
	} elsif ($a eq 27 && $b eq 34) {
		print -7;
	} elsif ($a eq 27 && $b eq 35) {
		print -8;
	} elsif ($a eq 27 && $b eq 36) {
		print -9;
	} elsif ($a eq 27 && $b eq 37) {
		print -10;
	} elsif ($a eq 27 && $b eq 38) {
		print -11;
	} elsif ($a eq 27 && $b eq 39) {
		print -12;
	} elsif ($a eq 27 && $b eq 40) {
		print -13;
	} elsif ($a eq 27 && $b eq 41) {
		print -14;
	} elsif ($a eq 27 && $b eq 42) {
		print -15;
	} elsif ($a eq 27 && $b eq 43) {
		print -16;
	} elsif ($a eq 27 && $b eq 44) {
		print -17;
	} elsif ($a eq 27 && $b eq 45) {
		print -18;
	} elsif ($a eq 27 && $b eq 46) {
		print -19;
	} elsif ($a eq 27 && $b eq 47) {
		print -20;
	} elsif ($a eq 27 && $b eq 48) {
		print -21;
	} elsif ($a eq 27 && $b eq 49) {
		print -22;
	} elsif ($a eq 27 && $b eq 50) {
		print -23;
	} elsif ($a eq 28 && $b eq 0) {
		print 28;
	} elsif ($a eq 28 && $b eq 1) {
		print 27;
	} elsif ($a eq 28 && $b eq 2) {
		print 26;
	} elsif ($a eq 28 && $b eq 3) {
		print 25;
	} elsif ($a eq 28 && $b eq 4) {
		print 24;
	} elsif ($a eq 28 && $b eq 5) {
		print 23;
	} elsif ($a eq 28 && $b eq 6) {
		print 22;
	} elsif ($a eq 28 && $b eq 7) {
		print 21;
	} elsif ($a eq 28 && $b eq 8) {
		print 20;
	} elsif ($a eq 28 && $b eq 9) {
		print 19;
	} elsif ($a eq 28 && $b eq 10) {
		print 18;
	} elsif ($a eq 28 && $b eq 11) {
		print 17;
	} elsif ($a eq 28 && $b eq 12) {
		print 16;
	} elsif ($a eq 28 && $b eq 13) {
		print 15;
	} elsif ($a eq 28 && $b eq 14) {
		print 14;
	} elsif ($a eq 28 && $b eq 15) {
		print 13;
	} elsif ($a eq 28 && $b eq 16) {
		print 12;
	} elsif ($a eq 28 && $b eq 17) {
		print 11;
	} elsif ($a eq 28 && $b eq 18) {
		print 10;
	} elsif ($a eq 28 && $b eq 19) {
		print 9;
	} elsif ($a eq 28 && $b eq 20) {
		print 8;
	} elsif ($a eq 28 && $b eq 21) {
		print 7;
	} elsif ($a eq 28 && $b eq 22) {
		print 6;
	} elsif ($a eq 28 && $b eq 23) {
		print 5;
	} elsif ($a eq 28 && $b eq 24) {
		print 4;
	} elsif ($a eq 28 && $b eq 25) {
		print 3;
	} elsif ($a eq 28 && $b eq 26) {
		print 2;
	} elsif ($a eq 28 && $b eq 27) {
		print 1;
	} elsif ($a eq 28 && $b eq 28) {
		print 0;
	} elsif ($a eq 28 && $b eq 29) {
		print -1;
	} elsif ($a eq 28 && $b eq 30) {
		print -2;
	} elsif ($a eq 28 && $b eq 31) {
		print -3;
	} elsif ($a eq 28 && $b eq 32) {
		print -4;
	} elsif ($a eq 28 && $b eq 33) {
		print -5;
	} elsif ($a eq 28 && $b eq 34) {
		print -6;
	} elsif ($a eq 28 && $b eq 35) {
		print -7;
	} elsif ($a eq 28 && $b eq 36) {
		print -8;
	} elsif ($a eq 28 && $b eq 37) {
		print -9;
	} elsif ($a eq 28 && $b eq 38) {
		print -10;
	} elsif ($a eq 28 && $b eq 39) {
		print -11;
	} elsif ($a eq 28 && $b eq 40) {
		print -12;
	} elsif ($a eq 28 && $b eq 41) {
		print -13;
	} elsif ($a eq 28 && $b eq 42) {
		print -14;
	} elsif ($a eq 28 && $b eq 43) {
		print -15;
	} elsif ($a eq 28 && $b eq 44) {
		print -16;
	} elsif ($a eq 28 && $b eq 45) {
		print -17;
	} elsif ($a eq 28 && $b eq 46) {
		print -18;
	} elsif ($a eq 28 && $b eq 47) {
		print -19;
	} elsif ($a eq 28 && $b eq 48) {
		print -20;
	} elsif ($a eq 28 && $b eq 49) {
		print -21;
	} elsif ($a eq 28 && $b eq 50) {
		print -22;
	} elsif ($a eq 29 && $b eq 0) {
		print 29;
	} elsif ($a eq 29 && $b eq 1) {
		print 28;
	} elsif ($a eq 29 && $b eq 2) {
		print 27;
	} elsif ($a eq 29 && $b eq 3) {
		print 26;
	} elsif ($a eq 29 && $b eq 4) {
		print 25;
	} elsif ($a eq 29 && $b eq 5) {
		print 24;
	} elsif ($a eq 29 && $b eq 6) {
		print 23;
	} elsif ($a eq 29 && $b eq 7) {
		print 22;
	} elsif ($a eq 29 && $b eq 8) {
		print 21;
	} elsif ($a eq 29 && $b eq 9) {
		print 20;
	} elsif ($a eq 29 && $b eq 10) {
		print 19;
	} elsif ($a eq 29 && $b eq 11) {
		print 18;
	} elsif ($a eq 29 && $b eq 12) {
		print 17;
	} elsif ($a eq 29 && $b eq 13) {
		print 16;
	} elsif ($a eq 29 && $b eq 14) {
		print 15;
	} elsif ($a eq 29 && $b eq 15) {
		print 14;
	} elsif ($a eq 29 && $b eq 16) {
		print 13;
	} elsif ($a eq 29 && $b eq 17) {
		print 12;
	} elsif ($a eq 29 && $b eq 18) {
		print 11;
	} elsif ($a eq 29 && $b eq 19) {
		print 10;
	} elsif ($a eq 29 && $b eq 20) {
		print 9;
	} elsif ($a eq 29 && $b eq 21) {
		print 8;
	} elsif ($a eq 29 && $b eq 22) {
		print 7;
	} elsif ($a eq 29 && $b eq 23) {
		print 6;
	} elsif ($a eq 29 && $b eq 24) {
		print 5;
	} elsif ($a eq 29 && $b eq 25) {
		print 4;
	} elsif ($a eq 29 && $b eq 26) {
		print 3;
	} elsif ($a eq 29 && $b eq 27) {
		print 2;
	} elsif ($a eq 29 && $b eq 28) {
		print 1;
	} elsif ($a eq 29 && $b eq 29) {
		print 0;
	} elsif ($a eq 29 && $b eq 30) {
		print -1;
	} elsif ($a eq 29 && $b eq 31) {
		print -2;
	} elsif ($a eq 29 && $b eq 32) {
		print -3;
	} elsif ($a eq 29 && $b eq 33) {
		print -4;
	} elsif ($a eq 29 && $b eq 34) {
		print -5;
	} elsif ($a eq 29 && $b eq 35) {
		print -6;
	} elsif ($a eq 29 && $b eq 36) {
		print -7;
	} elsif ($a eq 29 && $b eq 37) {
		print -8;
	} elsif ($a eq 29 && $b eq 38) {
		print -9;
	} elsif ($a eq 29 && $b eq 39) {
		print -10;
	} elsif ($a eq 29 && $b eq 40) {
		print -11;
	} elsif ($a eq 29 && $b eq 41) {
		print -12;
	} elsif ($a eq 29 && $b eq 42) {
		print -13;
	} elsif ($a eq 29 && $b eq 43) {
		print -14;
	} elsif ($a eq 29 && $b eq 44) {
		print -15;
	} elsif ($a eq 29 && $b eq 45) {
		print -16;
	} elsif ($a eq 29 && $b eq 46) {
		print -17;
	} elsif ($a eq 29 && $b eq 47) {
		print -18;
	} elsif ($a eq 29 && $b eq 48) {
		print -19;
	} elsif ($a eq 29 && $b eq 49) {
		print -20;
	} elsif ($a eq 29 && $b eq 50) {
		print -21;
	} elsif ($a eq 30 && $b eq 0) {
		print 30;
	} elsif ($a eq 30 && $b eq 1) {
		print 29;
	} elsif ($a eq 30 && $b eq 2) {
		print 28;
	} elsif ($a eq 30 && $b eq 3) {
		print 27;
	} elsif ($a eq 30 && $b eq 4) {
		print 26;
	} elsif ($a eq 30 && $b eq 5) {
		print 25;
	} elsif ($a eq 30 && $b eq 6) {
		print 24;
	} elsif ($a eq 30 && $b eq 7) {
		print 23;
	} elsif ($a eq 30 && $b eq 8) {
		print 22;
	} elsif ($a eq 30 && $b eq 9) {
		print 21;
	} elsif ($a eq 30 && $b eq 10) {
		print 20;
	} elsif ($a eq 30 && $b eq 11) {
		print 19;
	} elsif ($a eq 30 && $b eq 12) {
		print 18;
	} elsif ($a eq 30 && $b eq 13) {
		print 17;
	} elsif ($a eq 30 && $b eq 14) {
		print 16;
	} elsif ($a eq 30 && $b eq 15) {
		print 15;
	} elsif ($a eq 30 && $b eq 16) {
		print 14;
	} elsif ($a eq 30 && $b eq 17) {
		print 13;
	} elsif ($a eq 30 && $b eq 18) {
		print 12;
	} elsif ($a eq 30 && $b eq 19) {
		print 11;
	} elsif ($a eq 30 && $b eq 20) {
		print 10;
	} elsif ($a eq 30 && $b eq 21) {
		print 9;
	} elsif ($a eq 30 && $b eq 22) {
		print 8;
	} elsif ($a eq 30 && $b eq 23) {
		print 7;
	} elsif ($a eq 30 && $b eq 24) {
		print 6;
	} elsif ($a eq 30 && $b eq 25) {
		print 5;
	} elsif ($a eq 30 && $b eq 26) {
		print 4;
	} elsif ($a eq 30 && $b eq 27) {
		print 3;
	} elsif ($a eq 30 && $b eq 28) {
		print 2;
	} elsif ($a eq 30 && $b eq 29) {
		print 1;
	} elsif ($a eq 30 && $b eq 30) {
		print 0;
	} elsif ($a eq 30 && $b eq 31) {
		print -1;
	} elsif ($a eq 30 && $b eq 32) {
		print -2;
	} elsif ($a eq 30 && $b eq 33) {
		print -3;
	} elsif ($a eq 30 && $b eq 34) {
		print -4;
	} elsif ($a eq 30 && $b eq 35) {
		print -5;
	} elsif ($a eq 30 && $b eq 36) {
		print -6;
	} elsif ($a eq 30 && $b eq 37) {
		print -7;
	} elsif ($a eq 30 && $b eq 38) {
		print -8;
	} elsif ($a eq 30 && $b eq 39) {
		print -9;
	} elsif ($a eq 30 && $b eq 40) {
		print -10;
	} elsif ($a eq 30 && $b eq 41) {
		print -11;
	} elsif ($a eq 30 && $b eq 42) {
		print -12;
	} elsif ($a eq 30 && $b eq 43) {
		print -13;
	} elsif ($a eq 30 && $b eq 44) {
		print -14;
	} elsif ($a eq 30 && $b eq 45) {
		print -15;
	} elsif ($a eq 30 && $b eq 46) {
		print -16;
	} elsif ($a eq 30 && $b eq 47) {
		print -17;
	} elsif ($a eq 30 && $b eq 48) {
		print -18;
	} elsif ($a eq 30 && $b eq 49) {
		print -19;
	} elsif ($a eq 30 && $b eq 50) {
		print -20;
	} elsif ($a eq 31 && $b eq 0) {
		print 31;
	} elsif ($a eq 31 && $b eq 1) {
		print 30;
	} elsif ($a eq 31 && $b eq 2) {
		print 29;
	} elsif ($a eq 31 && $b eq 3) {
		print 28;
	} elsif ($a eq 31 && $b eq 4) {
		print 27;
	} elsif ($a eq 31 && $b eq 5) {
		print 26;
	} elsif ($a eq 31 && $b eq 6) {
		print 25;
	} elsif ($a eq 31 && $b eq 7) {
		print 24;
	} elsif ($a eq 31 && $b eq 8) {
		print 23;
	} elsif ($a eq 31 && $b eq 9) {
		print 22;
	} elsif ($a eq 31 && $b eq 10) {
		print 21;
	} elsif ($a eq 31 && $b eq 11) {
		print 20;
	} elsif ($a eq 31 && $b eq 12) {
		print 19;
	} elsif ($a eq 31 && $b eq 13) {
		print 18;
	} elsif ($a eq 31 && $b eq 14) {
		print 17;
	} elsif ($a eq 31 && $b eq 15) {
		print 16;
	} elsif ($a eq 31 && $b eq 16) {
		print 15;
	} elsif ($a eq 31 && $b eq 17) {
		print 14;
	} elsif ($a eq 31 && $b eq 18) {
		print 13;
	} elsif ($a eq 31 && $b eq 19) {
		print 12;
	} elsif ($a eq 31 && $b eq 20) {
		print 11;
	} elsif ($a eq 31 && $b eq 21) {
		print 10;
	} elsif ($a eq 31 && $b eq 22) {
		print 9;
	} elsif ($a eq 31 && $b eq 23) {
		print 8;
	} elsif ($a eq 31 && $b eq 24) {
		print 7;
	} elsif ($a eq 31 && $b eq 25) {
		print 6;
	} elsif ($a eq 31 && $b eq 26) {
		print 5;
	} elsif ($a eq 31 && $b eq 27) {
		print 4;
	} elsif ($a eq 31 && $b eq 28) {
		print 3;
	} elsif ($a eq 31 && $b eq 29) {
		print 2;
	} elsif ($a eq 31 && $b eq 30) {
		print 1;
	} elsif ($a eq 31 && $b eq 31) {
		print 0;
	} elsif ($a eq 31 && $b eq 32) {
		print -1;
	} elsif ($a eq 31 && $b eq 33) {
		print -2;
	} elsif ($a eq 31 && $b eq 34) {
		print -3;
	} elsif ($a eq 31 && $b eq 35) {
		print -4;
	} elsif ($a eq 31 && $b eq 36) {
		print -5;
	} elsif ($a eq 31 && $b eq 37) {
		print -6;
	} elsif ($a eq 31 && $b eq 38) {
		print -7;
	} elsif ($a eq 31 && $b eq 39) {
		print -8;
	} elsif ($a eq 31 && $b eq 40) {
		print -9;
	} elsif ($a eq 31 && $b eq 41) {
		print -10;
	} elsif ($a eq 31 && $b eq 42) {
		print -11;
	} elsif ($a eq 31 && $b eq 43) {
		print -12;
	} elsif ($a eq 31 && $b eq 44) {
		print -13;
	} elsif ($a eq 31 && $b eq 45) {
		print -14;
	} elsif ($a eq 31 && $b eq 46) {
		print -15;
	} elsif ($a eq 31 && $b eq 47) {
		print -16;
	} elsif ($a eq 31 && $b eq 48) {
		print -17;
	} elsif ($a eq 31 && $b eq 49) {
		print -18;
	} elsif ($a eq 31 && $b eq 50) {
		print -19;
	} elsif ($a eq 32 && $b eq 0) {
		print 32;
	} elsif ($a eq 32 && $b eq 1) {
		print 31;
	} elsif ($a eq 32 && $b eq 2) {
		print 30;
	} elsif ($a eq 32 && $b eq 3) {
		print 29;
	} elsif ($a eq 32 && $b eq 4) {
		print 28;
	} elsif ($a eq 32 && $b eq 5) {
		print 27;
	} elsif ($a eq 32 && $b eq 6) {
		print 26;
	} elsif ($a eq 32 && $b eq 7) {
		print 25;
	} elsif ($a eq 32 && $b eq 8) {
		print 24;
	} elsif ($a eq 32 && $b eq 9) {
		print 23;
	} elsif ($a eq 32 && $b eq 10) {
		print 22;
	} elsif ($a eq 32 && $b eq 11) {
		print 21;
	} elsif ($a eq 32 && $b eq 12) {
		print 20;
	} elsif ($a eq 32 && $b eq 13) {
		print 19;
	} elsif ($a eq 32 && $b eq 14) {
		print 18;
	} elsif ($a eq 32 && $b eq 15) {
		print 17;
	} elsif ($a eq 32 && $b eq 16) {
		print 16;
	} elsif ($a eq 32 && $b eq 17) {
		print 15;
	} elsif ($a eq 32 && $b eq 18) {
		print 14;
	} elsif ($a eq 32 && $b eq 19) {
		print 13;
	} elsif ($a eq 32 && $b eq 20) {
		print 12;
	} elsif ($a eq 32 && $b eq 21) {
		print 11;
	} elsif ($a eq 32 && $b eq 22) {
		print 10;
	} elsif ($a eq 32 && $b eq 23) {
		print 9;
	} elsif ($a eq 32 && $b eq 24) {
		print 8;
	} elsif ($a eq 32 && $b eq 25) {
		print 7;
	} elsif ($a eq 32 && $b eq 26) {
		print 6;
	} elsif ($a eq 32 && $b eq 27) {
		print 5;
	} elsif ($a eq 32 && $b eq 28) {
		print 4;
	} elsif ($a eq 32 && $b eq 29) {
		print 3;
	} elsif ($a eq 32 && $b eq 30) {
		print 2;
	} elsif ($a eq 32 && $b eq 31) {
		print 1;
	} elsif ($a eq 32 && $b eq 32) {
		print 0;
	} elsif ($a eq 32 && $b eq 33) {
		print -1;
	} elsif ($a eq 32 && $b eq 34) {
		print -2;
	} elsif ($a eq 32 && $b eq 35) {
		print -3;
	} elsif ($a eq 32 && $b eq 36) {
		print -4;
	} elsif ($a eq 32 && $b eq 37) {
		print -5;
	} elsif ($a eq 32 && $b eq 38) {
		print -6;
	} elsif ($a eq 32 && $b eq 39) {
		print -7;
	} elsif ($a eq 32 && $b eq 40) {
		print -8;
	} elsif ($a eq 32 && $b eq 41) {
		print -9;
	} elsif ($a eq 32 && $b eq 42) {
		print -10;
	} elsif ($a eq 32 && $b eq 43) {
		print -11;
	} elsif ($a eq 32 && $b eq 44) {
		print -12;
	} elsif ($a eq 32 && $b eq 45) {
		print -13;
	} elsif ($a eq 32 && $b eq 46) {
		print -14;
	} elsif ($a eq 32 && $b eq 47) {
		print -15;
	} elsif ($a eq 32 && $b eq 48) {
		print -16;
	} elsif ($a eq 32 && $b eq 49) {
		print -17;
	} elsif ($a eq 32 && $b eq 50) {
		print -18;
	} elsif ($a eq 33 && $b eq 0) {
		print 33;
	} elsif ($a eq 33 && $b eq 1) {
		print 32;
	} elsif ($a eq 33 && $b eq 2) {
		print 31;
	} elsif ($a eq 33 && $b eq 3) {
		print 30;
	} elsif ($a eq 33 && $b eq 4) {
		print 29;
	} elsif ($a eq 33 && $b eq 5) {
		print 28;
	} elsif ($a eq 33 && $b eq 6) {
		print 27;
	} elsif ($a eq 33 && $b eq 7) {
		print 26;
	} elsif ($a eq 33 && $b eq 8) {
		print 25;
	} elsif ($a eq 33 && $b eq 9) {
		print 24;
	} elsif ($a eq 33 && $b eq 10) {
		print 23;
	} elsif ($a eq 33 && $b eq 11) {
		print 22;
	} elsif ($a eq 33 && $b eq 12) {
		print 21;
	} elsif ($a eq 33 && $b eq 13) {
		print 20;
	} elsif ($a eq 33 && $b eq 14) {
		print 19;
	} elsif ($a eq 33 && $b eq 15) {
		print 18;
	} elsif ($a eq 33 && $b eq 16) {
		print 17;
	} elsif ($a eq 33 && $b eq 17) {
		print 16;
	} elsif ($a eq 33 && $b eq 18) {
		print 15;
	} elsif ($a eq 33 && $b eq 19) {
		print 14;
	} elsif ($a eq 33 && $b eq 20) {
		print 13;
	} elsif ($a eq 33 && $b eq 21) {
		print 12;
	} elsif ($a eq 33 && $b eq 22) {
		print 11;
	} elsif ($a eq 33 && $b eq 23) {
		print 10;
	} elsif ($a eq 33 && $b eq 24) {
		print 9;
	} elsif ($a eq 33 && $b eq 25) {
		print 8;
	} elsif ($a eq 33 && $b eq 26) {
		print 7;
	} elsif ($a eq 33 && $b eq 27) {
		print 6;
	} elsif ($a eq 33 && $b eq 28) {
		print 5;
	} elsif ($a eq 33 && $b eq 29) {
		print 4;
	} elsif ($a eq 33 && $b eq 30) {
		print 3;
	} elsif ($a eq 33 && $b eq 31) {
		print 2;
	} elsif ($a eq 33 && $b eq 32) {
		print 1;
	} elsif ($a eq 33 && $b eq 33) {
		print 0;
	} elsif ($a eq 33 && $b eq 34) {
		print -1;
	} elsif ($a eq 33 && $b eq 35) {
		print -2;
	} elsif ($a eq 33 && $b eq 36) {
		print -3;
	} elsif ($a eq 33 && $b eq 37) {
		print -4;
	} elsif ($a eq 33 && $b eq 38) {
		print -5;
	} elsif ($a eq 33 && $b eq 39) {
		print -6;
	} elsif ($a eq 33 && $b eq 40) {
		print -7;
	} elsif ($a eq 33 && $b eq 41) {
		print -8;
	} elsif ($a eq 33 && $b eq 42) {
		print -9;
	} elsif ($a eq 33 && $b eq 43) {
		print -10;
	} elsif ($a eq 33 && $b eq 44) {
		print -11;
	} elsif ($a eq 33 && $b eq 45) {
		print -12;
	} elsif ($a eq 33 && $b eq 46) {
		print -13;
	} elsif ($a eq 33 && $b eq 47) {
		print -14;
	} elsif ($a eq 33 && $b eq 48) {
		print -15;
	} elsif ($a eq 33 && $b eq 49) {
		print -16;
	} elsif ($a eq 33 && $b eq 50) {
		print -17;
	} elsif ($a eq 34 && $b eq 0) {
		print 34;
	} elsif ($a eq 34 && $b eq 1) {
		print 33;
	} elsif ($a eq 34 && $b eq 2) {
		print 32;
	} elsif ($a eq 34 && $b eq 3) {
		print 31;
	} elsif ($a eq 34 && $b eq 4) {
		print 30;
	} elsif ($a eq 34 && $b eq 5) {
		print 29;
	} elsif ($a eq 34 && $b eq 6) {
		print 28;
	} elsif ($a eq 34 && $b eq 7) {
		print 27;
	} elsif ($a eq 34 && $b eq 8) {
		print 26;
	} elsif ($a eq 34 && $b eq 9) {
		print 25;
	} elsif ($a eq 34 && $b eq 10) {
		print 24;
	} elsif ($a eq 34 && $b eq 11) {
		print 23;
	} elsif ($a eq 34 && $b eq 12) {
		print 22;
	} elsif ($a eq 34 && $b eq 13) {
		print 21;
	} elsif ($a eq 34 && $b eq 14) {
		print 20;
	} elsif ($a eq 34 && $b eq 15) {
		print 19;
	} elsif ($a eq 34 && $b eq 16) {
		print 18;
	} elsif ($a eq 34 && $b eq 17) {
		print 17;
	} elsif ($a eq 34 && $b eq 18) {
		print 16;
	} elsif ($a eq 34 && $b eq 19) {
		print 15;
	} elsif ($a eq 34 && $b eq 20) {
		print 14;
	} elsif ($a eq 34 && $b eq 21) {
		print 13;
	} elsif ($a eq 34 && $b eq 22) {
		print 12;
	} elsif ($a eq 34 && $b eq 23) {
		print 11;
	} elsif ($a eq 34 && $b eq 24) {
		print 10;
	} elsif ($a eq 34 && $b eq 25) {
		print 9;
	} elsif ($a eq 34 && $b eq 26) {
		print 8;
	} elsif ($a eq 34 && $b eq 27) {
		print 7;
	} elsif ($a eq 34 && $b eq 28) {
		print 6;
	} elsif ($a eq 34 && $b eq 29) {
		print 5;
	} elsif ($a eq 34 && $b eq 30) {
		print 4;
	} elsif ($a eq 34 && $b eq 31) {
		print 3;
	} elsif ($a eq 34 && $b eq 32) {
		print 2;
	} elsif ($a eq 34 && $b eq 33) {
		print 1;
	} elsif ($a eq 34 && $b eq 34) {
		print 0;
	} elsif ($a eq 34 && $b eq 35) {
		print -1;
	} elsif ($a eq 34 && $b eq 36) {
		print -2;
	} elsif ($a eq 34 && $b eq 37) {
		print -3;
	} elsif ($a eq 34 && $b eq 38) {
		print -4;
	} elsif ($a eq 34 && $b eq 39) {
		print -5;
	} elsif ($a eq 34 && $b eq 40) {
		print -6;
	} elsif ($a eq 34 && $b eq 41) {
		print -7;
	} elsif ($a eq 34 && $b eq 42) {
		print -8;
	} elsif ($a eq 34 && $b eq 43) {
		print -9;
	} elsif ($a eq 34 && $b eq 44) {
		print -10;
	} elsif ($a eq 34 && $b eq 45) {
		print -11;
	} elsif ($a eq 34 && $b eq 46) {
		print -12;
	} elsif ($a eq 34 && $b eq 47) {
		print -13;
	} elsif ($a eq 34 && $b eq 48) {
		print -14;
	} elsif ($a eq 34 && $b eq 49) {
		print -15;
	} elsif ($a eq 34 && $b eq 50) {
		print -16;
	} elsif ($a eq 35 && $b eq 0) {
		print 35;
	} elsif ($a eq 35 && $b eq 1) {
		print 34;
	} elsif ($a eq 35 && $b eq 2) {
		print 33;
	} elsif ($a eq 35 && $b eq 3) {
		print 32;
	} elsif ($a eq 35 && $b eq 4) {
		print 31;
	} elsif ($a eq 35 && $b eq 5) {
		print 30;
	} elsif ($a eq 35 && $b eq 6) {
		print 29;
	} elsif ($a eq 35 && $b eq 7) {
		print 28;
	} elsif ($a eq 35 && $b eq 8) {
		print 27;
	} elsif ($a eq 35 && $b eq 9) {
		print 26;
	} elsif ($a eq 35 && $b eq 10) {
		print 25;
	} elsif ($a eq 35 && $b eq 11) {
		print 24;
	} elsif ($a eq 35 && $b eq 12) {
		print 23;
	} elsif ($a eq 35 && $b eq 13) {
		print 22;
	} elsif ($a eq 35 && $b eq 14) {
		print 21;
	} elsif ($a eq 35 && $b eq 15) {
		print 20;
	} elsif ($a eq 35 && $b eq 16) {
		print 19;
	} elsif ($a eq 35 && $b eq 17) {
		print 18;
	} elsif ($a eq 35 && $b eq 18) {
		print 17;
	} elsif ($a eq 35 && $b eq 19) {
		print 16;
	} elsif ($a eq 35 && $b eq 20) {
		print 15;
	} elsif ($a eq 35 && $b eq 21) {
		print 14;
	} elsif ($a eq 35 && $b eq 22) {
		print 13;
	} elsif ($a eq 35 && $b eq 23) {
		print 12;
	} elsif ($a eq 35 && $b eq 24) {
		print 11;
	} elsif ($a eq 35 && $b eq 25) {
		print 10;
	} elsif ($a eq 35 && $b eq 26) {
		print 9;
	} elsif ($a eq 35 && $b eq 27) {
		print 8;
	} elsif ($a eq 35 && $b eq 28) {
		print 7;
	} elsif ($a eq 35 && $b eq 29) {
		print 6;
	} elsif ($a eq 35 && $b eq 30) {
		print 5;
	} elsif ($a eq 35 && $b eq 31) {
		print 4;
	} elsif ($a eq 35 && $b eq 32) {
		print 3;
	} elsif ($a eq 35 && $b eq 33) {
		print 2;
	} elsif ($a eq 35 && $b eq 34) {
		print 1;
	} elsif ($a eq 35 && $b eq 35) {
		print 0;
	} elsif ($a eq 35 && $b eq 36) {
		print -1;
	} elsif ($a eq 35 && $b eq 37) {
		print -2;
	} elsif ($a eq 35 && $b eq 38) {
		print -3;
	} elsif ($a eq 35 && $b eq 39) {
		print -4;
	} elsif ($a eq 35 && $b eq 40) {
		print -5;
	} elsif ($a eq 35 && $b eq 41) {
		print -6;
	} elsif ($a eq 35 && $b eq 42) {
		print -7;
	} elsif ($a eq 35 && $b eq 43) {
		print -8;
	} elsif ($a eq 35 && $b eq 44) {
		print -9;
	} elsif ($a eq 35 && $b eq 45) {
		print -10;
	} elsif ($a eq 35 && $b eq 46) {
		print -11;
	} elsif ($a eq 35 && $b eq 47) {
		print -12;
	} elsif ($a eq 35 && $b eq 48) {
		print -13;
	} elsif ($a eq 35 && $b eq 49) {
		print -14;
	} elsif ($a eq 35 && $b eq 50) {
		print -15;
	} elsif ($a eq 36 && $b eq 0) {
		print 36;
	} elsif ($a eq 36 && $b eq 1) {
		print 35;
	} elsif ($a eq 36 && $b eq 2) {
		print 34;
	} elsif ($a eq 36 && $b eq 3) {
		print 33;
	} elsif ($a eq 36 && $b eq 4) {
		print 32;
	} elsif ($a eq 36 && $b eq 5) {
		print 31;
	} elsif ($a eq 36 && $b eq 6) {
		print 30;
	} elsif ($a eq 36 && $b eq 7) {
		print 29;
	} elsif ($a eq 36 && $b eq 8) {
		print 28;
	} elsif ($a eq 36 && $b eq 9) {
		print 27;
	} elsif ($a eq 36 && $b eq 10) {
		print 26;
	} elsif ($a eq 36 && $b eq 11) {
		print 25;
	} elsif ($a eq 36 && $b eq 12) {
		print 24;
	} elsif ($a eq 36 && $b eq 13) {
		print 23;
	} elsif ($a eq 36 && $b eq 14) {
		print 22;
	} elsif ($a eq 36 && $b eq 15) {
		print 21;
	} elsif ($a eq 36 && $b eq 16) {
		print 20;
	} elsif ($a eq 36 && $b eq 17) {
		print 19;
	} elsif ($a eq 36 && $b eq 18) {
		print 18;
	} elsif ($a eq 36 && $b eq 19) {
		print 17;
	} elsif ($a eq 36 && $b eq 20) {
		print 16;
	} elsif ($a eq 36 && $b eq 21) {
		print 15;
	} elsif ($a eq 36 && $b eq 22) {
		print 14;
	} elsif ($a eq 36 && $b eq 23) {
		print 13;
	} elsif ($a eq 36 && $b eq 24) {
		print 12;
	} elsif ($a eq 36 && $b eq 25) {
		print 11;
	} elsif ($a eq 36 && $b eq 26) {
		print 10;
	} elsif ($a eq 36 && $b eq 27) {
		print 9;
	} elsif ($a eq 36 && $b eq 28) {
		print 8;
	} elsif ($a eq 36 && $b eq 29) {
		print 7;
	} elsif ($a eq 36 && $b eq 30) {
		print 6;
	} elsif ($a eq 36 && $b eq 31) {
		print 5;
	} elsif ($a eq 36 && $b eq 32) {
		print 4;
	} elsif ($a eq 36 && $b eq 33) {
		print 3;
	} elsif ($a eq 36 && $b eq 34) {
		print 2;
	} elsif ($a eq 36 && $b eq 35) {
		print 1;
	} elsif ($a eq 36 && $b eq 36) {
		print 0;
	} elsif ($a eq 36 && $b eq 37) {
		print -1;
	} elsif ($a eq 36 && $b eq 38) {
		print -2;
	} elsif ($a eq 36 && $b eq 39) {
		print -3;
	} elsif ($a eq 36 && $b eq 40) {
		print -4;
	} elsif ($a eq 36 && $b eq 41) {
		print -5;
	} elsif ($a eq 36 && $b eq 42) {
		print -6;
	} elsif ($a eq 36 && $b eq 43) {
		print -7;
	} elsif ($a eq 36 && $b eq 44) {
		print -8;
	} elsif ($a eq 36 && $b eq 45) {
		print -9;
	} elsif ($a eq 36 && $b eq 46) {
		print -10;
	} elsif ($a eq 36 && $b eq 47) {
		print -11;
	} elsif ($a eq 36 && $b eq 48) {
		print -12;
	} elsif ($a eq 36 && $b eq 49) {
		print -13;
	} elsif ($a eq 36 && $b eq 50) {
		print -14;
	} elsif ($a eq 37 && $b eq 0) {
		print 37;
	} elsif ($a eq 37 && $b eq 1) {
		print 36;
	} elsif ($a eq 37 && $b eq 2) {
		print 35;
	} elsif ($a eq 37 && $b eq 3) {
		print 34;
	} elsif ($a eq 37 && $b eq 4) {
		print 33;
	} elsif ($a eq 37 && $b eq 5) {
		print 32;
	} elsif ($a eq 37 && $b eq 6) {
		print 31;
	} elsif ($a eq 37 && $b eq 7) {
		print 30;
	} elsif ($a eq 37 && $b eq 8) {
		print 29;
	} elsif ($a eq 37 && $b eq 9) {
		print 28;
	} elsif ($a eq 37 && $b eq 10) {
		print 27;
	} elsif ($a eq 37 && $b eq 11) {
		print 26;
	} elsif ($a eq 37 && $b eq 12) {
		print 25;
	} elsif ($a eq 37 && $b eq 13) {
		print 24;
	} elsif ($a eq 37 && $b eq 14) {
		print 23;
	} elsif ($a eq 37 && $b eq 15) {
		print 22;
	} elsif ($a eq 37 && $b eq 16) {
		print 21;
	} elsif ($a eq 37 && $b eq 17) {
		print 20;
	} elsif ($a eq 37 && $b eq 18) {
		print 19;
	} elsif ($a eq 37 && $b eq 19) {
		print 18;
	} elsif ($a eq 37 && $b eq 20) {
		print 17;
	} elsif ($a eq 37 && $b eq 21) {
		print 16;
	} elsif ($a eq 37 && $b eq 22) {
		print 15;
	} elsif ($a eq 37 && $b eq 23) {
		print 14;
	} elsif ($a eq 37 && $b eq 24) {
		print 13;
	} elsif ($a eq 37 && $b eq 25) {
		print 12;
	} elsif ($a eq 37 && $b eq 26) {
		print 11;
	} elsif ($a eq 37 && $b eq 27) {
		print 10;
	} elsif ($a eq 37 && $b eq 28) {
		print 9;
	} elsif ($a eq 37 && $b eq 29) {
		print 8;
	} elsif ($a eq 37 && $b eq 30) {
		print 7;
	} elsif ($a eq 37 && $b eq 31) {
		print 6;
	} elsif ($a eq 37 && $b eq 32) {
		print 5;
	} elsif ($a eq 37 && $b eq 33) {
		print 4;
	} elsif ($a eq 37 && $b eq 34) {
		print 3;
	} elsif ($a eq 37 && $b eq 35) {
		print 2;
	} elsif ($a eq 37 && $b eq 36) {
		print 1;
	} elsif ($a eq 37 && $b eq 37) {
		print 0;
	} elsif ($a eq 37 && $b eq 38) {
		print -1;
	} elsif ($a eq 37 && $b eq 39) {
		print -2;
	} elsif ($a eq 37 && $b eq 40) {
		print -3;
	} elsif ($a eq 37 && $b eq 41) {
		print -4;
	} elsif ($a eq 37 && $b eq 42) {
		print -5;
	} elsif ($a eq 37 && $b eq 43) {
		print -6;
	} elsif ($a eq 37 && $b eq 44) {
		print -7;
	} elsif ($a eq 37 && $b eq 45) {
		print -8;
	} elsif ($a eq 37 && $b eq 46) {
		print -9;
	} elsif ($a eq 37 && $b eq 47) {
		print -10;
	} elsif ($a eq 37 && $b eq 48) {
		print -11;
	} elsif ($a eq 37 && $b eq 49) {
		print -12;
	} elsif ($a eq 37 && $b eq 50) {
		print -13;
	} elsif ($a eq 38 && $b eq 0) {
		print 38;
	} elsif ($a eq 38 && $b eq 1) {
		print 37;
	} elsif ($a eq 38 && $b eq 2) {
		print 36;
	} elsif ($a eq 38 && $b eq 3) {
		print 35;
	} elsif ($a eq 38 && $b eq 4) {
		print 34;
	} elsif ($a eq 38 && $b eq 5) {
		print 33;
	} elsif ($a eq 38 && $b eq 6) {
		print 32;
	} elsif ($a eq 38 && $b eq 7) {
		print 31;
	} elsif ($a eq 38 && $b eq 8) {
		print 30;
	} elsif ($a eq 38 && $b eq 9) {
		print 29;
	} elsif ($a eq 38 && $b eq 10) {
		print 28;
	} elsif ($a eq 38 && $b eq 11) {
		print 27;
	} elsif ($a eq 38 && $b eq 12) {
		print 26;
	} elsif ($a eq 38 && $b eq 13) {
		print 25;
	} elsif ($a eq 38 && $b eq 14) {
		print 24;
	} elsif ($a eq 38 && $b eq 15) {
		print 23;
	} elsif ($a eq 38 && $b eq 16) {
		print 22;
	} elsif ($a eq 38 && $b eq 17) {
		print 21;
	} elsif ($a eq 38 && $b eq 18) {
		print 20;
	} elsif ($a eq 38 && $b eq 19) {
		print 19;
	} elsif ($a eq 38 && $b eq 20) {
		print 18;
	} elsif ($a eq 38 && $b eq 21) {
		print 17;
	} elsif ($a eq 38 && $b eq 22) {
		print 16;
	} elsif ($a eq 38 && $b eq 23) {
		print 15;
	} elsif ($a eq 38 && $b eq 24) {
		print 14;
	} elsif ($a eq 38 && $b eq 25) {
		print 13;
	} elsif ($a eq 38 && $b eq 26) {
		print 12;
	} elsif ($a eq 38 && $b eq 27) {
		print 11;
	} elsif ($a eq 38 && $b eq 28) {
		print 10;
	} elsif ($a eq 38 && $b eq 29) {
		print 9;
	} elsif ($a eq 38 && $b eq 30) {
		print 8;
	} elsif ($a eq 38 && $b eq 31) {
		print 7;
	} elsif ($a eq 38 && $b eq 32) {
		print 6;
	} elsif ($a eq 38 && $b eq 33) {
		print 5;
	} elsif ($a eq 38 && $b eq 34) {
		print 4;
	} elsif ($a eq 38 && $b eq 35) {
		print 3;
	} elsif ($a eq 38 && $b eq 36) {
		print 2;
	} elsif ($a eq 38 && $b eq 37) {
		print 1;
	} elsif ($a eq 38 && $b eq 38) {
		print 0;
	} elsif ($a eq 38 && $b eq 39) {
		print -1;
	} elsif ($a eq 38 && $b eq 40) {
		print -2;
	} elsif ($a eq 38 && $b eq 41) {
		print -3;
	} elsif ($a eq 38 && $b eq 42) {
		print -4;
	} elsif ($a eq 38 && $b eq 43) {
		print -5;
	} elsif ($a eq 38 && $b eq 44) {
		print -6;
	} elsif ($a eq 38 && $b eq 45) {
		print -7;
	} elsif ($a eq 38 && $b eq 46) {
		print -8;
	} elsif ($a eq 38 && $b eq 47) {
		print -9;
	} elsif ($a eq 38 && $b eq 48) {
		print -10;
	} elsif ($a eq 38 && $b eq 49) {
		print -11;
	} elsif ($a eq 38 && $b eq 50) {
		print -12;
	} elsif ($a eq 39 && $b eq 0) {
		print 39;
	} elsif ($a eq 39 && $b eq 1) {
		print 38;
	} elsif ($a eq 39 && $b eq 2) {
		print 37;
	} elsif ($a eq 39 && $b eq 3) {
		print 36;
	} elsif ($a eq 39 && $b eq 4) {
		print 35;
	} elsif ($a eq 39 && $b eq 5) {
		print 34;
	} elsif ($a eq 39 && $b eq 6) {
		print 33;
	} elsif ($a eq 39 && $b eq 7) {
		print 32;
	} elsif ($a eq 39 && $b eq 8) {
		print 31;
	} elsif ($a eq 39 && $b eq 9) {
		print 30;
	} elsif ($a eq 39 && $b eq 10) {
		print 29;
	} elsif ($a eq 39 && $b eq 11) {
		print 28;
	} elsif ($a eq 39 && $b eq 12) {
		print 27;
	} elsif ($a eq 39 && $b eq 13) {
		print 26;
	} elsif ($a eq 39 && $b eq 14) {
		print 25;
	} elsif ($a eq 39 && $b eq 15) {
		print 24;
	} elsif ($a eq 39 && $b eq 16) {
		print 23;
	} elsif ($a eq 39 && $b eq 17) {
		print 22;
	} elsif ($a eq 39 && $b eq 18) {
		print 21;
	} elsif ($a eq 39 && $b eq 19) {
		print 20;
	} elsif ($a eq 39 && $b eq 20) {
		print 19;
	} elsif ($a eq 39 && $b eq 21) {
		print 18;
	} elsif ($a eq 39 && $b eq 22) {
		print 17;
	} elsif ($a eq 39 && $b eq 23) {
		print 16;
	} elsif ($a eq 39 && $b eq 24) {
		print 15;
	} elsif ($a eq 39 && $b eq 25) {
		print 14;
	} elsif ($a eq 39 && $b eq 26) {
		print 13;
	} elsif ($a eq 39 && $b eq 27) {
		print 12;
	} elsif ($a eq 39 && $b eq 28) {
		print 11;
	} elsif ($a eq 39 && $b eq 29) {
		print 10;
	} elsif ($a eq 39 && $b eq 30) {
		print 9;
	} elsif ($a eq 39 && $b eq 31) {
		print 8;
	} elsif ($a eq 39 && $b eq 32) {
		print 7;
	} elsif ($a eq 39 && $b eq 33) {
		print 6;
	} elsif ($a eq 39 && $b eq 34) {
		print 5;
	} elsif ($a eq 39 && $b eq 35) {
		print 4;
	} elsif ($a eq 39 && $b eq 36) {
		print 3;
	} elsif ($a eq 39 && $b eq 37) {
		print 2;
	} elsif ($a eq 39 && $b eq 38) {
		print 1;
	} elsif ($a eq 39 && $b eq 39) {
		print 0;
	} elsif ($a eq 39 && $b eq 40) {
		print -1;
	} elsif ($a eq 39 && $b eq 41) {
		print -2;
	} elsif ($a eq 39 && $b eq 42) {
		print -3;
	} elsif ($a eq 39 && $b eq 43) {
		print -4;
	} elsif ($a eq 39 && $b eq 44) {
		print -5;
	} elsif ($a eq 39 && $b eq 45) {
		print -6;
	} elsif ($a eq 39 && $b eq 46) {
		print -7;
	} elsif ($a eq 39 && $b eq 47) {
		print -8;
	} elsif ($a eq 39 && $b eq 48) {
		print -9;
	} elsif ($a eq 39 && $b eq 49) {
		print -10;
	} elsif ($a eq 39 && $b eq 50) {
		print -11;
	} elsif ($a eq 40 && $b eq 0) {
		print 40;
	} elsif ($a eq 40 && $b eq 1) {
		print 39;
	} elsif ($a eq 40 && $b eq 2) {
		print 38;
	} elsif ($a eq 40 && $b eq 3) {
		print 37;
	} elsif ($a eq 40 && $b eq 4) {
		print 36;
	} elsif ($a eq 40 && $b eq 5) {
		print 35;
	} elsif ($a eq 40 && $b eq 6) {
		print 34;
	} elsif ($a eq 40 && $b eq 7) {
		print 33;
	} elsif ($a eq 40 && $b eq 8) {
		print 32;
	} elsif ($a eq 40 && $b eq 9) {
		print 31;
	} elsif ($a eq 40 && $b eq 10) {
		print 30;
	} elsif ($a eq 40 && $b eq 11) {
		print 29;
	} elsif ($a eq 40 && $b eq 12) {
		print 28;
	} elsif ($a eq 40 && $b eq 13) {
		print 27;
	} elsif ($a eq 40 && $b eq 14) {
		print 26;
	} elsif ($a eq 40 && $b eq 15) {
		print 25;
	} elsif ($a eq 40 && $b eq 16) {
		print 24;
	} elsif ($a eq 40 && $b eq 17) {
		print 23;
	} elsif ($a eq 40 && $b eq 18) {
		print 22;
	} elsif ($a eq 40 && $b eq 19) {
		print 21;
	} elsif ($a eq 40 && $b eq 20) {
		print 20;
	} elsif ($a eq 40 && $b eq 21) {
		print 19;
	} elsif ($a eq 40 && $b eq 22) {
		print 18;
	} elsif ($a eq 40 && $b eq 23) {
		print 17;
	} elsif ($a eq 40 && $b eq 24) {
		print 16;
	} elsif ($a eq 40 && $b eq 25) {
		print 15;
	} elsif ($a eq 40 && $b eq 26) {
		print 14;
	} elsif ($a eq 40 && $b eq 27) {
		print 13;
	} elsif ($a eq 40 && $b eq 28) {
		print 12;
	} elsif ($a eq 40 && $b eq 29) {
		print 11;
	} elsif ($a eq 40 && $b eq 30) {
		print 10;
	} elsif ($a eq 40 && $b eq 31) {
		print 9;
	} elsif ($a eq 40 && $b eq 32) {
		print 8;
	} elsif ($a eq 40 && $b eq 33) {
		print 7;
	} elsif ($a eq 40 && $b eq 34) {
		print 6;
	} elsif ($a eq 40 && $b eq 35) {
		print 5;
	} elsif ($a eq 40 && $b eq 36) {
		print 4;
	} elsif ($a eq 40 && $b eq 37) {
		print 3;
	} elsif ($a eq 40 && $b eq 38) {
		print 2;
	} elsif ($a eq 40 && $b eq 39) {
		print 1;
	} elsif ($a eq 40 && $b eq 40) {
		print 0;
	} elsif ($a eq 40 && $b eq 41) {
		print -1;
	} elsif ($a eq 40 && $b eq 42) {
		print -2;
	} elsif ($a eq 40 && $b eq 43) {
		print -3;
	} elsif ($a eq 40 && $b eq 44) {
		print -4;
	} elsif ($a eq 40 && $b eq 45) {
		print -5;
	} elsif ($a eq 40 && $b eq 46) {
		print -6;
	} elsif ($a eq 40 && $b eq 47) {
		print -7;
	} elsif ($a eq 40 && $b eq 48) {
		print -8;
	} elsif ($a eq 40 && $b eq 49) {
		print -9;
	} elsif ($a eq 40 && $b eq 50) {
		print -10;
	} elsif ($a eq 41 && $b eq 0) {
		print 41;
	} elsif ($a eq 41 && $b eq 1) {
		print 40;
	} elsif ($a eq 41 && $b eq 2) {
		print 39;
	} elsif ($a eq 41 && $b eq 3) {
		print 38;
	} elsif ($a eq 41 && $b eq 4) {
		print 37;
	} elsif ($a eq 41 && $b eq 5) {
		print 36;
	} elsif ($a eq 41 && $b eq 6) {
		print 35;
	} elsif ($a eq 41 && $b eq 7) {
		print 34;
	} elsif ($a eq 41 && $b eq 8) {
		print 33;
	} elsif ($a eq 41 && $b eq 9) {
		print 32;
	} elsif ($a eq 41 && $b eq 10) {
		print 31;
	} elsif ($a eq 41 && $b eq 11) {
		print 30;
	} elsif ($a eq 41 && $b eq 12) {
		print 29;
	} elsif ($a eq 41 && $b eq 13) {
		print 28;
	} elsif ($a eq 41 && $b eq 14) {
		print 27;
	} elsif ($a eq 41 && $b eq 15) {
		print 26;
	} elsif ($a eq 41 && $b eq 16) {
		print 25;
	} elsif ($a eq 41 && $b eq 17) {
		print 24;
	} elsif ($a eq 41 && $b eq 18) {
		print 23;
	} elsif ($a eq 41 && $b eq 19) {
		print 22;
	} elsif ($a eq 41 && $b eq 20) {
		print 21;
	} elsif ($a eq 41 && $b eq 21) {
		print 20;
	} elsif ($a eq 41 && $b eq 22) {
		print 19;
	} elsif ($a eq 41 && $b eq 23) {
		print 18;
	} elsif ($a eq 41 && $b eq 24) {
		print 17;
	} elsif ($a eq 41 && $b eq 25) {
		print 16;
	} elsif ($a eq 41 && $b eq 26) {
		print 15;
	} elsif ($a eq 41 && $b eq 27) {
		print 14;
	} elsif ($a eq 41 && $b eq 28) {
		print 13;
	} elsif ($a eq 41 && $b eq 29) {
		print 12;
	} elsif ($a eq 41 && $b eq 30) {
		print 11;
	} elsif ($a eq 41 && $b eq 31) {
		print 10;
	} elsif ($a eq 41 && $b eq 32) {
		print 9;
	} elsif ($a eq 41 && $b eq 33) {
		print 8;
	} elsif ($a eq 41 && $b eq 34) {
		print 7;
	} elsif ($a eq 41 && $b eq 35) {
		print 6;
	} elsif ($a eq 41 && $b eq 36) {
		print 5;
	} elsif ($a eq 41 && $b eq 37) {
		print 4;
	} elsif ($a eq 41 && $b eq 38) {
		print 3;
	} elsif ($a eq 41 && $b eq 39) {
		print 2;
	} elsif ($a eq 41 && $b eq 40) {
		print 1;
	} elsif ($a eq 41 && $b eq 41) {
		print 0;
	} elsif ($a eq 41 && $b eq 42) {
		print -1;
	} elsif ($a eq 41 && $b eq 43) {
		print -2;
	} elsif ($a eq 41 && $b eq 44) {
		print -3;
	} elsif ($a eq 41 && $b eq 45) {
		print -4;
	} elsif ($a eq 41 && $b eq 46) {
		print -5;
	} elsif ($a eq 41 && $b eq 47) {
		print -6;
	} elsif ($a eq 41 && $b eq 48) {
		print -7;
	} elsif ($a eq 41 && $b eq 49) {
		print -8;
	} elsif ($a eq 41 && $b eq 50) {
		print -9;
	} elsif ($a eq 42 && $b eq 0) {
		print 42;
	} elsif ($a eq 42 && $b eq 1) {
		print 41;
	} elsif ($a eq 42 && $b eq 2) {
		print 40;
	} elsif ($a eq 42 && $b eq 3) {
		print 39;
	} elsif ($a eq 42 && $b eq 4) {
		print 38;
	} elsif ($a eq 42 && $b eq 5) {
		print 37;
	} elsif ($a eq 42 && $b eq 6) {
		print 36;
	} elsif ($a eq 42 && $b eq 7) {
		print 35;
	} elsif ($a eq 42 && $b eq 8) {
		print 34;
	} elsif ($a eq 42 && $b eq 9) {
		print 33;
	} elsif ($a eq 42 && $b eq 10) {
		print 32;
	} elsif ($a eq 42 && $b eq 11) {
		print 31;
	} elsif ($a eq 42 && $b eq 12) {
		print 30;
	} elsif ($a eq 42 && $b eq 13) {
		print 29;
	} elsif ($a eq 42 && $b eq 14) {
		print 28;
	} elsif ($a eq 42 && $b eq 15) {
		print 27;
	} elsif ($a eq 42 && $b eq 16) {
		print 26;
	} elsif ($a eq 42 && $b eq 17) {
		print 25;
	} elsif ($a eq 42 && $b eq 18) {
		print 24;
	} elsif ($a eq 42 && $b eq 19) {
		print 23;
	} elsif ($a eq 42 && $b eq 20) {
		print 22;
	} elsif ($a eq 42 && $b eq 21) {
		print 21;
	} elsif ($a eq 42 && $b eq 22) {
		print 20;
	} elsif ($a eq 42 && $b eq 23) {
		print 19;
	} elsif ($a eq 42 && $b eq 24) {
		print 18;
	} elsif ($a eq 42 && $b eq 25) {
		print 17;
	} elsif ($a eq 42 && $b eq 26) {
		print 16;
	} elsif ($a eq 42 && $b eq 27) {
		print 15;
	} elsif ($a eq 42 && $b eq 28) {
		print 14;
	} elsif ($a eq 42 && $b eq 29) {
		print 13;
	} elsif ($a eq 42 && $b eq 30) {
		print 12;
	} elsif ($a eq 42 && $b eq 31) {
		print 11;
	} elsif ($a eq 42 && $b eq 32) {
		print 10;
	} elsif ($a eq 42 && $b eq 33) {
		print 9;
	} elsif ($a eq 42 && $b eq 34) {
		print 8;
	} elsif ($a eq 42 && $b eq 35) {
		print 7;
	} elsif ($a eq 42 && $b eq 36) {
		print 6;
	} elsif ($a eq 42 && $b eq 37) {
		print 5;
	} elsif ($a eq 42 && $b eq 38) {
		print 4;
	} elsif ($a eq 42 && $b eq 39) {
		print 3;
	} elsif ($a eq 42 && $b eq 40) {
		print 2;
	} elsif ($a eq 42 && $b eq 41) {
		print 1;
	} elsif ($a eq 42 && $b eq 42) {
		print 0;
	} elsif ($a eq 42 && $b eq 43) {
		print -1;
	} elsif ($a eq 42 && $b eq 44) {
		print -2;
	} elsif ($a eq 42 && $b eq 45) {
		print -3;
	} elsif ($a eq 42 && $b eq 46) {
		print -4;
	} elsif ($a eq 42 && $b eq 47) {
		print -5;
	} elsif ($a eq 42 && $b eq 48) {
		print -6;
	} elsif ($a eq 42 && $b eq 49) {
		print -7;
	} elsif ($a eq 42 && $b eq 50) {
		print -8;
	} elsif ($a eq 43 && $b eq 0) {
		print 43;
	} elsif ($a eq 43 && $b eq 1) {
		print 42;
	} elsif ($a eq 43 && $b eq 2) {
		print 41;
	} elsif ($a eq 43 && $b eq 3) {
		print 40;
	} elsif ($a eq 43 && $b eq 4) {
		print 39;
	} elsif ($a eq 43 && $b eq 5) {
		print 38;
	} elsif ($a eq 43 && $b eq 6) {
		print 37;
	} elsif ($a eq 43 && $b eq 7) {
		print 36;
	} elsif ($a eq 43 && $b eq 8) {
		print 35;
	} elsif ($a eq 43 && $b eq 9) {
		print 34;
	} elsif ($a eq 43 && $b eq 10) {
		print 33;
	} elsif ($a eq 43 && $b eq 11) {
		print 32;
	} elsif ($a eq 43 && $b eq 12) {
		print 31;
	} elsif ($a eq 43 && $b eq 13) {
		print 30;
	} elsif ($a eq 43 && $b eq 14) {
		print 29;
	} elsif ($a eq 43 && $b eq 15) {
		print 28;
	} elsif ($a eq 43 && $b eq 16) {
		print 27;
	} elsif ($a eq 43 && $b eq 17) {
		print 26;
	} elsif ($a eq 43 && $b eq 18) {
		print 25;
	} elsif ($a eq 43 && $b eq 19) {
		print 24;
	} elsif ($a eq 43 && $b eq 20) {
		print 23;
	} elsif ($a eq 43 && $b eq 21) {
		print 22;
	} elsif ($a eq 43 && $b eq 22) {
		print 21;
	} elsif ($a eq 43 && $b eq 23) {
		print 20;
	} elsif ($a eq 43 && $b eq 24) {
		print 19;
	} elsif ($a eq 43 && $b eq 25) {
		print 18;
	} elsif ($a eq 43 && $b eq 26) {
		print 17;
	} elsif ($a eq 43 && $b eq 27) {
		print 16;
	} elsif ($a eq 43 && $b eq 28) {
		print 15;
	} elsif ($a eq 43 && $b eq 29) {
		print 14;
	} elsif ($a eq 43 && $b eq 30) {
		print 13;
	} elsif ($a eq 43 && $b eq 31) {
		print 12;
	} elsif ($a eq 43 && $b eq 32) {
		print 11;
	} elsif ($a eq 43 && $b eq 33) {
		print 10;
	} elsif ($a eq 43 && $b eq 34) {
		print 9;
	} elsif ($a eq 43 && $b eq 35) {
		print 8;
	} elsif ($a eq 43 && $b eq 36) {
		print 7;
	} elsif ($a eq 43 && $b eq 37) {
		print 6;
	} elsif ($a eq 43 && $b eq 38) {
		print 5;
	} elsif ($a eq 43 && $b eq 39) {
		print 4;
	} elsif ($a eq 43 && $b eq 40) {
		print 3;
	} elsif ($a eq 43 && $b eq 41) {
		print 2;
	} elsif ($a eq 43 && $b eq 42) {
		print 1;
	} elsif ($a eq 43 && $b eq 43) {
		print 0;
	} elsif ($a eq 43 && $b eq 44) {
		print -1;
	} elsif ($a eq 43 && $b eq 45) {
		print -2;
	} elsif ($a eq 43 && $b eq 46) {
		print -3;
	} elsif ($a eq 43 && $b eq 47) {
		print -4;
	} elsif ($a eq 43 && $b eq 48) {
		print -5;
	} elsif ($a eq 43 && $b eq 49) {
		print -6;
	} elsif ($a eq 43 && $b eq 50) {
		print -7;
	} elsif ($a eq 44 && $b eq 0) {
		print 44;
	} elsif ($a eq 44 && $b eq 1) {
		print 43;
	} elsif ($a eq 44 && $b eq 2) {
		print 42;
	} elsif ($a eq 44 && $b eq 3) {
		print 41;
	} elsif ($a eq 44 && $b eq 4) {
		print 40;
	} elsif ($a eq 44 && $b eq 5) {
		print 39;
	} elsif ($a eq 44 && $b eq 6) {
		print 38;
	} elsif ($a eq 44 && $b eq 7) {
		print 37;
	} elsif ($a eq 44 && $b eq 8) {
		print 36;
	} elsif ($a eq 44 && $b eq 9) {
		print 35;
	} elsif ($a eq 44 && $b eq 10) {
		print 34;
	} elsif ($a eq 44 && $b eq 11) {
		print 33;
	} elsif ($a eq 44 && $b eq 12) {
		print 32;
	} elsif ($a eq 44 && $b eq 13) {
		print 31;
	} elsif ($a eq 44 && $b eq 14) {
		print 30;
	} elsif ($a eq 44 && $b eq 15) {
		print 29;
	} elsif ($a eq 44 && $b eq 16) {
		print 28;
	} elsif ($a eq 44 && $b eq 17) {
		print 27;
	} elsif ($a eq 44 && $b eq 18) {
		print 26;
	} elsif ($a eq 44 && $b eq 19) {
		print 25;
	} elsif ($a eq 44 && $b eq 20) {
		print 24;
	} elsif ($a eq 44 && $b eq 21) {
		print 23;
	} elsif ($a eq 44 && $b eq 22) {
		print 22;
	} elsif ($a eq 44 && $b eq 23) {
		print 21;
	} elsif ($a eq 44 && $b eq 24) {
		print 20;
	} elsif ($a eq 44 && $b eq 25) {
		print 19;
	} elsif ($a eq 44 && $b eq 26) {
		print 18;
	} elsif ($a eq 44 && $b eq 27) {
		print 17;
	} elsif ($a eq 44 && $b eq 28) {
		print 16;
	} elsif ($a eq 44 && $b eq 29) {
		print 15;
	} elsif ($a eq 44 && $b eq 30) {
		print 14;
	} elsif ($a eq 44 && $b eq 31) {
		print 13;
	} elsif ($a eq 44 && $b eq 32) {
		print 12;
	} elsif ($a eq 44 && $b eq 33) {
		print 11;
	} elsif ($a eq 44 && $b eq 34) {
		print 10;
	} elsif ($a eq 44 && $b eq 35) {
		print 9;
	} elsif ($a eq 44 && $b eq 36) {
		print 8;
	} elsif ($a eq 44 && $b eq 37) {
		print 7;
	} elsif ($a eq 44 && $b eq 38) {
		print 6;
	} elsif ($a eq 44 && $b eq 39) {
		print 5;
	} elsif ($a eq 44 && $b eq 40) {
		print 4;
	} elsif ($a eq 44 && $b eq 41) {
		print 3;
	} elsif ($a eq 44 && $b eq 42) {
		print 2;
	} elsif ($a eq 44 && $b eq 43) {
		print 1;
	} elsif ($a eq 44 && $b eq 44) {
		print 0;
	} elsif ($a eq 44 && $b eq 45) {
		print -1;
	} elsif ($a eq 44 && $b eq 46) {
		print -2;
	} elsif ($a eq 44 && $b eq 47) {
		print -3;
	} elsif ($a eq 44 && $b eq 48) {
		print -4;
	} elsif ($a eq 44 && $b eq 49) {
		print -5;
	} elsif ($a eq 44 && $b eq 50) {
		print -6;
	} elsif ($a eq 45 && $b eq 0) {
		print 45;
	} elsif ($a eq 45 && $b eq 1) {
		print 44;
	} elsif ($a eq 45 && $b eq 2) {
		print 43;
	} elsif ($a eq 45 && $b eq 3) {
		print 42;
	} elsif ($a eq 45 && $b eq 4) {
		print 41;
	} elsif ($a eq 45 && $b eq 5) {
		print 40;
	} elsif ($a eq 45 && $b eq 6) {
		print 39;
	} elsif ($a eq 45 && $b eq 7) {
		print 38;
	} elsif ($a eq 45 && $b eq 8) {
		print 37;
	} elsif ($a eq 45 && $b eq 9) {
		print 36;
	} elsif ($a eq 45 && $b eq 10) {
		print 35;
	} elsif ($a eq 45 && $b eq 11) {
		print 34;
	} elsif ($a eq 45 && $b eq 12) {
		print 33;
	} elsif ($a eq 45 && $b eq 13) {
		print 32;
	} elsif ($a eq 45 && $b eq 14) {
		print 31;
	} elsif ($a eq 45 && $b eq 15) {
		print 30;
	} elsif ($a eq 45 && $b eq 16) {
		print 29;
	} elsif ($a eq 45 && $b eq 17) {
		print 28;
	} elsif ($a eq 45 && $b eq 18) {
		print 27;
	} elsif ($a eq 45 && $b eq 19) {
		print 26;
	} elsif ($a eq 45 && $b eq 20) {
		print 25;
	} elsif ($a eq 45 && $b eq 21) {
		print 24;
	} elsif ($a eq 45 && $b eq 22) {
		print 23;
	} elsif ($a eq 45 && $b eq 23) {
		print 22;
	} elsif ($a eq 45 && $b eq 24) {
		print 21;
	} elsif ($a eq 45 && $b eq 25) {
		print 20;
	} elsif ($a eq 45 && $b eq 26) {
		print 19;
	} elsif ($a eq 45 && $b eq 27) {
		print 18;
	} elsif ($a eq 45 && $b eq 28) {
		print 17;
	} elsif ($a eq 45 && $b eq 29) {
		print 16;
	} elsif ($a eq 45 && $b eq 30) {
		print 15;
	} elsif ($a eq 45 && $b eq 31) {
		print 14;
	} elsif ($a eq 45 && $b eq 32) {
		print 13;
	} elsif ($a eq 45 && $b eq 33) {
		print 12;
	} elsif ($a eq 45 && $b eq 34) {
		print 11;
	} elsif ($a eq 45 && $b eq 35) {
		print 10;
	} elsif ($a eq 45 && $b eq 36) {
		print 9;
	} elsif ($a eq 45 && $b eq 37) {
		print 8;
	} elsif ($a eq 45 && $b eq 38) {
		print 7;
	} elsif ($a eq 45 && $b eq 39) {
		print 6;
	} elsif ($a eq 45 && $b eq 40) {
		print 5;
	} elsif ($a eq 45 && $b eq 41) {
		print 4;
	} elsif ($a eq 45 && $b eq 42) {
		print 3;
	} elsif ($a eq 45 && $b eq 43) {
		print 2;
	} elsif ($a eq 45 && $b eq 44) {
		print 1;
	} elsif ($a eq 45 && $b eq 45) {
		print 0;
	} elsif ($a eq 45 && $b eq 46) {
		print -1;
	} elsif ($a eq 45 && $b eq 47) {
		print -2;
	} elsif ($a eq 45 && $b eq 48) {
		print -3;
	} elsif ($a eq 45 && $b eq 49) {
		print -4;
	} elsif ($a eq 45 && $b eq 50) {
		print -5;
	} elsif ($a eq 46 && $b eq 0) {
		print 46;
	} elsif ($a eq 46 && $b eq 1) {
		print 45;
	} elsif ($a eq 46 && $b eq 2) {
		print 44;
	} elsif ($a eq 46 && $b eq 3) {
		print 43;
	} elsif ($a eq 46 && $b eq 4) {
		print 42;
	} elsif ($a eq 46 && $b eq 5) {
		print 41;
	} elsif ($a eq 46 && $b eq 6) {
		print 40;
	} elsif ($a eq 46 && $b eq 7) {
		print 39;
	} elsif ($a eq 46 && $b eq 8) {
		print 38;
	} elsif ($a eq 46 && $b eq 9) {
		print 37;
	} elsif ($a eq 46 && $b eq 10) {
		print 36;
	} elsif ($a eq 46 && $b eq 11) {
		print 35;
	} elsif ($a eq 46 && $b eq 12) {
		print 34;
	} elsif ($a eq 46 && $b eq 13) {
		print 33;
	} elsif ($a eq 46 && $b eq 14) {
		print 32;
	} elsif ($a eq 46 && $b eq 15) {
		print 31;
	} elsif ($a eq 46 && $b eq 16) {
		print 30;
	} elsif ($a eq 46 && $b eq 17) {
		print 29;
	} elsif ($a eq 46 && $b eq 18) {
		print 28;
	} elsif ($a eq 46 && $b eq 19) {
		print 27;
	} elsif ($a eq 46 && $b eq 20) {
		print 26;
	} elsif ($a eq 46 && $b eq 21) {
		print 25;
	} elsif ($a eq 46 && $b eq 22) {
		print 24;
	} elsif ($a eq 46 && $b eq 23) {
		print 23;
	} elsif ($a eq 46 && $b eq 24) {
		print 22;
	} elsif ($a eq 46 && $b eq 25) {
		print 21;
	} elsif ($a eq 46 && $b eq 26) {
		print 20;
	} elsif ($a eq 46 && $b eq 27) {
		print 19;
	} elsif ($a eq 46 && $b eq 28) {
		print 18;
	} elsif ($a eq 46 && $b eq 29) {
		print 17;
	} elsif ($a eq 46 && $b eq 30) {
		print 16;
	} elsif ($a eq 46 && $b eq 31) {
		print 15;
	} elsif ($a eq 46 && $b eq 32) {
		print 14;
	} elsif ($a eq 46 && $b eq 33) {
		print 13;
	} elsif ($a eq 46 && $b eq 34) {
		print 12;
	} elsif ($a eq 46 && $b eq 35) {
		print 11;
	} elsif ($a eq 46 && $b eq 36) {
		print 10;
	} elsif ($a eq 46 && $b eq 37) {
		print 9;
	} elsif ($a eq 46 && $b eq 38) {
		print 8;
	} elsif ($a eq 46 && $b eq 39) {
		print 7;
	} elsif ($a eq 46 && $b eq 40) {
		print 6;
	} elsif ($a eq 46 && $b eq 41) {
		print 5;
	} elsif ($a eq 46 && $b eq 42) {
		print 4;
	} elsif ($a eq 46 && $b eq 43) {
		print 3;
	} elsif ($a eq 46 && $b eq 44) {
		print 2;
	} elsif ($a eq 46 && $b eq 45) {
		print 1;
	} elsif ($a eq 46 && $b eq 46) {
		print 0;
	} elsif ($a eq 46 && $b eq 47) {
		print -1;
	} elsif ($a eq 46 && $b eq 48) {
		print -2;
	} elsif ($a eq 46 && $b eq 49) {
		print -3;
	} elsif ($a eq 46 && $b eq 50) {
		print -4;
	} elsif ($a eq 47 && $b eq 0) {
		print 47;
	} elsif ($a eq 47 && $b eq 1) {
		print 46;
	} elsif ($a eq 47 && $b eq 2) {
		print 45;
	} elsif ($a eq 47 && $b eq 3) {
		print 44;
	} elsif ($a eq 47 && $b eq 4) {
		print 43;
	} elsif ($a eq 47 && $b eq 5) {
		print 42;
	} elsif ($a eq 47 && $b eq 6) {
		print 41;
	} elsif ($a eq 47 && $b eq 7) {
		print 40;
	} elsif ($a eq 47 && $b eq 8) {
		print 39;
	} elsif ($a eq 47 && $b eq 9) {
		print 38;
	} elsif ($a eq 47 && $b eq 10) {
		print 37;
	} elsif ($a eq 47 && $b eq 11) {
		print 36;
	} elsif ($a eq 47 && $b eq 12) {
		print 35;
	} elsif ($a eq 47 && $b eq 13) {
		print 34;
	} elsif ($a eq 47 && $b eq 14) {
		print 33;
	} elsif ($a eq 47 && $b eq 15) {
		print 32;
	} elsif ($a eq 47 && $b eq 16) {
		print 31;
	} elsif ($a eq 47 && $b eq 17) {
		print 30;
	} elsif ($a eq 47 && $b eq 18) {
		print 29;
	} elsif ($a eq 47 && $b eq 19) {
		print 28;
	} elsif ($a eq 47 && $b eq 20) {
		print 27;
	} elsif ($a eq 47 && $b eq 21) {
		print 26;
	} elsif ($a eq 47 && $b eq 22) {
		print 25;
	} elsif ($a eq 47 && $b eq 23) {
		print 24;
	} elsif ($a eq 47 && $b eq 24) {
		print 23;
	} elsif ($a eq 47 && $b eq 25) {
		print 22;
	} elsif ($a eq 47 && $b eq 26) {
		print 21;
	} elsif ($a eq 47 && $b eq 27) {
		print 20;
	} elsif ($a eq 47 && $b eq 28) {
		print 19;
	} elsif ($a eq 47 && $b eq 29) {
		print 18;
	} elsif ($a eq 47 && $b eq 30) {
		print 17;
	} elsif ($a eq 47 && $b eq 31) {
		print 16;
	} elsif ($a eq 47 && $b eq 32) {
		print 15;
	} elsif ($a eq 47 && $b eq 33) {
		print 14;
	} elsif ($a eq 47 && $b eq 34) {
		print 13;
	} elsif ($a eq 47 && $b eq 35) {
		print 12;
	} elsif ($a eq 47 && $b eq 36) {
		print 11;
	} elsif ($a eq 47 && $b eq 37) {
		print 10;
	} elsif ($a eq 47 && $b eq 38) {
		print 9;
	} elsif ($a eq 47 && $b eq 39) {
		print 8;
	} elsif ($a eq 47 && $b eq 40) {
		print 7;
	} elsif ($a eq 47 && $b eq 41) {
		print 6;
	} elsif ($a eq 47 && $b eq 42) {
		print 5;
	} elsif ($a eq 47 && $b eq 43) {
		print 4;
	} elsif ($a eq 47 && $b eq 44) {
		print 3;
	} elsif ($a eq 47 && $b eq 45) {
		print 2;
	} elsif ($a eq 47 && $b eq 46) {
		print 1;
	} elsif ($a eq 47 && $b eq 47) {
		print 0;
	} elsif ($a eq 47 && $b eq 48) {
		print -1;
	} elsif ($a eq 47 && $b eq 49) {
		print -2;
	} elsif ($a eq 47 && $b eq 50) {
		print -3;
	} elsif ($a eq 48 && $b eq 0) {
		print 48;
	} elsif ($a eq 48 && $b eq 1) {
		print 47;
	} elsif ($a eq 48 && $b eq 2) {
		print 46;
	} elsif ($a eq 48 && $b eq 3) {
		print 45;
	} elsif ($a eq 48 && $b eq 4) {
		print 44;
	} elsif ($a eq 48 && $b eq 5) {
		print 43;
	} elsif ($a eq 48 && $b eq 6) {
		print 42;
	} elsif ($a eq 48 && $b eq 7) {
		print 41;
	} elsif ($a eq 48 && $b eq 8) {
		print 40;
	} elsif ($a eq 48 && $b eq 9) {
		print 39;
	} elsif ($a eq 48 && $b eq 10) {
		print 38;
	} elsif ($a eq 48 && $b eq 11) {
		print 37;
	} elsif ($a eq 48 && $b eq 12) {
		print 36;
	} elsif ($a eq 48 && $b eq 13) {
		print 35;
	} elsif ($a eq 48 && $b eq 14) {
		print 34;
	} elsif ($a eq 48 && $b eq 15) {
		print 33;
	} elsif ($a eq 48 && $b eq 16) {
		print 32;
	} elsif ($a eq 48 && $b eq 17) {
		print 31;
	} elsif ($a eq 48 && $b eq 18) {
		print 30;
	} elsif ($a eq 48 && $b eq 19) {
		print 29;
	} elsif ($a eq 48 && $b eq 20) {
		print 28;
	} elsif ($a eq 48 && $b eq 21) {
		print 27;
	} elsif ($a eq 48 && $b eq 22) {
		print 26;
	} elsif ($a eq 48 && $b eq 23) {
		print 25;
	} elsif ($a eq 48 && $b eq 24) {
		print 24;
	} elsif ($a eq 48 && $b eq 25) {
		print 23;
	} elsif ($a eq 48 && $b eq 26) {
		print 22;
	} elsif ($a eq 48 && $b eq 27) {
		print 21;
	} elsif ($a eq 48 && $b eq 28) {
		print 20;
	} elsif ($a eq 48 && $b eq 29) {
		print 19;
	} elsif ($a eq 48 && $b eq 30) {
		print 18;
	} elsif ($a eq 48 && $b eq 31) {
		print 17;
	} elsif ($a eq 48 && $b eq 32) {
		print 16;
	} elsif ($a eq 48 && $b eq 33) {
		print 15;
	} elsif ($a eq 48 && $b eq 34) {
		print 14;
	} elsif ($a eq 48 && $b eq 35) {
		print 13;
	} elsif ($a eq 48 && $b eq 36) {
		print 12;
	} elsif ($a eq 48 && $b eq 37) {
		print 11;
	} elsif ($a eq 48 && $b eq 38) {
		print 10;
	} elsif ($a eq 48 && $b eq 39) {
		print 9;
	} elsif ($a eq 48 && $b eq 40) {
		print 8;
	} elsif ($a eq 48 && $b eq 41) {
		print 7;
	} elsif ($a eq 48 && $b eq 42) {
		print 6;
	} elsif ($a eq 48 && $b eq 43) {
		print 5;
	} elsif ($a eq 48 && $b eq 44) {
		print 4;
	} elsif ($a eq 48 && $b eq 45) {
		print 3;
	} elsif ($a eq 48 && $b eq 46) {
		print 2;
	} elsif ($a eq 48 && $b eq 47) {
		print 1;
	} elsif ($a eq 48 && $b eq 48) {
		print 0;
	} elsif ($a eq 48 && $b eq 49) {
		print -1;
	} elsif ($a eq 48 && $b eq 50) {
		print -2;
	} elsif ($a eq 49 && $b eq 0) {
		print 49;
	} elsif ($a eq 49 && $b eq 1) {
		print 48;
	} elsif ($a eq 49 && $b eq 2) {
		print 47;
	} elsif ($a eq 49 && $b eq 3) {
		print 46;
	} elsif ($a eq 49 && $b eq 4) {
		print 45;
	} elsif ($a eq 49 && $b eq 5) {
		print 44;
	} elsif ($a eq 49 && $b eq 6) {
		print 43;
	} elsif ($a eq 49 && $b eq 7) {
		print 42;
	} elsif ($a eq 49 && $b eq 8) {
		print 41;
	} elsif ($a eq 49 && $b eq 9) {
		print 40;
	} elsif ($a eq 49 && $b eq 10) {
		print 39;
	} elsif ($a eq 49 && $b eq 11) {
		print 38;
	} elsif ($a eq 49 && $b eq 12) {
		print 37;
	} elsif ($a eq 49 && $b eq 13) {
		print 36;
	} elsif ($a eq 49 && $b eq 14) {
		print 35;
	} elsif ($a eq 49 && $b eq 15) {
		print 34;
	} elsif ($a eq 49 && $b eq 16) {
		print 33;
	} elsif ($a eq 49 && $b eq 17) {
		print 32;
	} elsif ($a eq 49 && $b eq 18) {
		print 31;
	} elsif ($a eq 49 && $b eq 19) {
		print 30;
	} elsif ($a eq 49 && $b eq 20) {
		print 29;
	} elsif ($a eq 49 && $b eq 21) {
		print 28;
	} elsif ($a eq 49 && $b eq 22) {
		print 27;
	} elsif ($a eq 49 && $b eq 23) {
		print 26;
	} elsif ($a eq 49 && $b eq 24) {
		print 25;
	} elsif ($a eq 49 && $b eq 25) {
		print 24;
	} elsif ($a eq 49 && $b eq 26) {
		print 23;
	} elsif ($a eq 49 && $b eq 27) {
		print 22;
	} elsif ($a eq 49 && $b eq 28) {
		print 21;
	} elsif ($a eq 49 && $b eq 29) {
		print 20;
	} elsif ($a eq 49 && $b eq 30) {
		print 19;
	} elsif ($a eq 49 && $b eq 31) {
		print 18;
	} elsif ($a eq 49 && $b eq 32) {
		print 17;
	} elsif ($a eq 49 && $b eq 33) {
		print 16;
	} elsif ($a eq 49 && $b eq 34) {
		print 15;
	} elsif ($a eq 49 && $b eq 35) {
		print 14;
	} elsif ($a eq 49 && $b eq 36) {
		print 13;
	} elsif ($a eq 49 && $b eq 37) {
		print 12;
	} elsif ($a eq 49 && $b eq 38) {
		print 11;
	} elsif ($a eq 49 && $b eq 39) {
		print 10;
	} elsif ($a eq 49 && $b eq 40) {
		print 9;
	} elsif ($a eq 49 && $b eq 41) {
		print 8;
	} elsif ($a eq 49 && $b eq 42) {
		print 7;
	} elsif ($a eq 49 && $b eq 43) {
		print 6;
	} elsif ($a eq 49 && $b eq 44) {
		print 5;
	} elsif ($a eq 49 && $b eq 45) {
		print 4;
	} elsif ($a eq 49 && $b eq 46) {
		print 3;
	} elsif ($a eq 49 && $b eq 47) {
		print 2;
	} elsif ($a eq 49 && $b eq 48) {
		print 1;
	} elsif ($a eq 49 && $b eq 49) {
		print 0;
	} elsif ($a eq 49 && $b eq 50) {
		print -1;
	} elsif ($a eq 50 && $b eq 0) {
		print 50;
	} elsif ($a eq 50 && $b eq 1) {
		print 49;
	} elsif ($a eq 50 && $b eq 2) {
		print 48;
	} elsif ($a eq 50 && $b eq 3) {
		print 47;
	} elsif ($a eq 50 && $b eq 4) {
		print 46;
	} elsif ($a eq 50 && $b eq 5) {
		print 45;
	} elsif ($a eq 50 && $b eq 6) {
		print 44;
	} elsif ($a eq 50 && $b eq 7) {
		print 43;
	} elsif ($a eq 50 && $b eq 8) {
		print 42;
	} elsif ($a eq 50 && $b eq 9) {
		print 41;
	} elsif ($a eq 50 && $b eq 10) {
		print 40;
	} elsif ($a eq 50 && $b eq 11) {
		print 39;
	} elsif ($a eq 50 && $b eq 12) {
		print 38;
	} elsif ($a eq 50 && $b eq 13) {
		print 37;
	} elsif ($a eq 50 && $b eq 14) {
		print 36;
	} elsif ($a eq 50 && $b eq 15) {
		print 35;
	} elsif ($a eq 50 && $b eq 16) {
		print 34;
	} elsif ($a eq 50 && $b eq 17) {
		print 33;
	} elsif ($a eq 50 && $b eq 18) {
		print 32;
	} elsif ($a eq 50 && $b eq 19) {
		print 31;
	} elsif ($a eq 50 && $b eq 20) {
		print 30;
	} elsif ($a eq 50 && $b eq 21) {
		print 29;
	} elsif ($a eq 50 && $b eq 22) {
		print 28;
	} elsif ($a eq 50 && $b eq 23) {
		print 27;
	} elsif ($a eq 50 && $b eq 24) {
		print 26;
	} elsif ($a eq 50 && $b eq 25) {
		print 25;
	} elsif ($a eq 50 && $b eq 26) {
		print 24;
	} elsif ($a eq 50 && $b eq 27) {
		print 23;
	} elsif ($a eq 50 && $b eq 28) {
		print 22;
	} elsif ($a eq 50 && $b eq 29) {
		print 21;
	} elsif ($a eq 50 && $b eq 30) {
		print 20;
	} elsif ($a eq 50 && $b eq 31) {
		print 19;
	} elsif ($a eq 50 && $b eq 32) {
		print 18;
	} elsif ($a eq 50 && $b eq 33) {
		print 17;
	} elsif ($a eq 50 && $b eq 34) {
		print 16;
	} elsif ($a eq 50 && $b eq 35) {
		print 15;
	} elsif ($a eq 50 && $b eq 36) {
		print 14;
	} elsif ($a eq 50 && $b eq 37) {
		print 13;
	} elsif ($a eq 50 && $b eq 38) {
		print 12;
	} elsif ($a eq 50 && $b eq 39) {
		print 11;
	} elsif ($a eq 50 && $b eq 40) {
		print 10;
	} elsif ($a eq 50 && $b eq 41) {
		print 9;
	} elsif ($a eq 50 && $b eq 42) {
		print 8;
	} elsif ($a eq 50 && $b eq 43) {
		print 7;
	} elsif ($a eq 50 && $b eq 44) {
		print 6;
	} elsif ($a eq 50 && $b eq 45) {
		print 5;
	} elsif ($a eq 50 && $b eq 46) {
		print 4;
	} elsif ($a eq 50 && $b eq 47) {
		print 3;
	} elsif ($a eq 50 && $b eq 48) {
		print 2;
	} elsif ($a eq 50 && $b eq 49) {
		print 1;
	} elsif ($a eq 50 && $b eq 50) {
		print 0;
	} else {
		print "Unsupported number given!";
	}
}
