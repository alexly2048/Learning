#include <stdio.h>
#include <string.h>

int main() {
	int c;
	/*
	// ʹ��getchar()��ȡ�����ַ�
	printf("Enter a value: ");
	c = getchar();
	// ʹ��putchar()��������ַ�
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