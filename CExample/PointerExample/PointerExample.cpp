#include <stdio.h>
#include <Windows.h>
int main() {

	int m = 100;

	int* p =(int*) &m;
	printf("m = %d\n", m);
	*p = 200;
	printf("m = %d", m);
	system("pause");
	return 0;
}