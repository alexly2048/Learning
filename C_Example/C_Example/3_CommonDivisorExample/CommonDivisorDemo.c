#include <stdio.h>
#include <Windows.h>

unsigned int Gcd(unsigned numOne, unsigned numTwo) {
	unsigned rem;
	while (numTwo > 0) {
		rem = numOne % numTwo;
		numOne = numTwo;
		numTwo = rem;
	}
	return numOne;
}

 int Substract(int numOne,  int numTwo) {
	int temp;
	if (numOne < numTwo) {
		temp = numOne;
		numOne = numTwo;
		numTwo = temp;
	}

	while (numOne - numTwo != 0) {
		temp = numOne - numTwo;
		numOne = numTwo;
		numTwo = temp;
	}
	return numTwo;
}

int main() {

	unsigned int a = 20;
	unsigned int b = 40;
	printf("%d\n", Gcd(a, b));

	printf("Substract method: %d\n", Substract(a, b));
	system("pause");
	return 0;
}