#include <stdio.h>
#include <string.h>

int max(int x, int y);

int main() {
	int(*p)(int, int) = &max;
	int a, b, c, d;
	printf("请输入三个数字:");
#pragma warning(disable: 4996)
	scanf("%d %d %d", &a, &b, &c);
	getchar();
	d = p(p(a, b), c);

	printf("最大的数字是:%d\n", d);
	getchar();
	return 0;
}

int max(int x, int y) {
	return x > y ? x : y;
}