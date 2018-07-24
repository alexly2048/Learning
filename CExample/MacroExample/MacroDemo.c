#include <stdio.h>
#include <Windows.h>


int main() {
	/* 打印C语言中定义的宏变量*/
	printf("File : %s\n", __FILE__);
	printf("Date : %s\n", __DATE__);
	printf("Time : %s\n", __TIME__);
	printf("Line : %d\n", __LINE__);
	//printf("ANSI : %d\n", __STDC__);
	system("pause......");
	return 1;
}