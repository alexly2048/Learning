#include <stdio.h>
#include <string.h>

int max(int x, int y);

int main() {
	int(*p)(int, int) = &max;
	int a, b, c, d;
	printf("��������������:");
#pragma warning(disable: 4996)
	scanf("%d %d %d", &a, &b, &c);
	getchar();
	d = p(p(a, b), c);

	printf("����������:%d\n", d);
	getchar();
	return 0;
}

int max(int x, int y) {
	return x > y ? x : y;
}