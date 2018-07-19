#include <stdio.h>
#include <string.h>

int main() {
	char str1[12] = "Hello";
	char str2[12] = "World";
	char str3[12];

	// copy str2 to str3
	// ½ûÓÃ4996ÌáÊ¾
	// #pragma warning (disable : 4996)
	strcpy(str3, str2);
	printf("strcpy(str3,str2) %s\n", str3);
	// catenate str2 to str1
	strcat(str1, str2);
	printf("strcat(st1,str2) %s", str1);
	getchar();
	return 0;
}