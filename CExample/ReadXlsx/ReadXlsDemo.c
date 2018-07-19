#include <stdio.h>
#include <string.h>
#define _CRT_SECURE_NO_WARNINGS

int main() {
	char *p[] = {"Welcome to C program.","C++ demo","read xls demo"};
	FILE *fp = NULL;
#pragma warning (disable : 4996)
	fp = fopen("E:\\test.xlsx", "w");
	for (int i = 0; i < 3; i++) {
		fprintf(fp, "%s,", *(p + i));
	};
	fclose(fp);
	getchar();
	return 0;
}