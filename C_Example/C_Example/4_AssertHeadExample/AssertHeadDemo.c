#include <stdio.h>
#include <Windows.h>
#include <assert.h>

int main() {

	int a;
	a = 10;
	assert(a > 10);
	printf("a is : %d\n", a);

	system("pause");
	return 0;
}