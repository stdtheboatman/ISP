#include "pch.h" // use stdafx.h in Visual Studio 2017 and earlier
#include <utility>
#include <limits.h>
#include "myLib.h"

int _stdcall Min(int a, int b) {
	return (a < b ? a : b);
}

int _stdcall Max(int a, int b) {
	return (a > b ? a : b);
}

int Pow(int a, int n) {
	int result = 1;
	for (int i = 0; i < n; i++) {
		result *= a;
	}


	return result;
}

int Gcd(int a, int b) {
	if (a < 0) {
		a = -a;
	}

	if (b < 0) {
		b = -b;
	}

	while (a && b) {
		(a > b ? a %= b : b %= a);
	}

	return a + b;
}