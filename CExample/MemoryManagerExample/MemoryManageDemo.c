/*	void* calloc(int num,int size); ���ڴ��ж�̬����num������Ϊsize���ڴ棬Ĭ��ֵ0
	void free(void* address); �ͷ��ڴ�
	void* malloc(int num);	�ڶ�������һ��ָ����С���ڴ棬�����ʼ��ֵδ֪
	void* realloc(void* address, int newsize); ���·����ڴ棬��չ��newsize
	Tip: void* ���ͱ�ʾδȷ�����͵�ָ�룬��ͨ������ץ����ת������������
*/

#include <stdio.h>
#include <string.h>
#include <Windows.h>

int main() {
	char name[100];
	char* description;
#pragma warning (disable : 4996)
	strcpy(name, "Zara Ali");
	description = malloc(30 * sizeof(char));
	if (description == NULL) {
		fprintf(stderr, "Error - unable to allocate required memory\n");
	}
	else {
#pragma warning (disable : 4996)
		strcpy(description, "Zara ali a DPS student .");
	}
	description = realloc(description, 100 * sizeof(char));
	if (description == NULL)
	{
		fprintf(stderr, "Error - unable to allocate required memory\n");
	}
	else
	{
#pragma warning (disable : 4996)
		strcat(description, "She is in class 10th");
	}

	printf("Name = %s\n", name);
	printf("Description: %s\n", description);

	/* ʹ�� free() �����ͷ��ڴ�*/
	free(description);
	system("pause");
	return 0;
}