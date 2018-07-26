#include <stdio.h>
#include <Windows.h>
#include <string.h>

double factorial(unsigned int i) {
	if (i <= 1) {
		return 1;
	}
	return i * factorial(i - 1);
}
/* 斐波那契数列 */
int fibonacci(int i) {
	if (i == 0) {
		return 0;
	}
	if (i == 1) {
		return 1;
	}
	return fibonacci(i - 1) + fibonacci(i - 2);
}
int main() {

	//int i = 15;
	//printf("%d 的阶乘 %f\n", i, factorial(i));
	int i;
	for (i = 0; i < 10; i++) {
		printf("%d\t\n", fibonacci(i));
	}
	system("pause");
	return 0;
}