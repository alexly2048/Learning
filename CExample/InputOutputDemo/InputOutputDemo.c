#include <stdio.h>
#include <string.h>

int main() {
	int c;
	/*
	// 使用getchar()读取单个字符
	printf("Enter a value: ");
	c = getchar();
	// 使用putchar()输出单个字符
	printf("\nYou entered: ");
	putchar(c);
	printf("\n");
	*/
	char str[100];
	printf("Enter a value : ");
	gets(str);
	printf("\nYou entered : ");
	puts(str);
	int result = system("pause");
	return 0;
}