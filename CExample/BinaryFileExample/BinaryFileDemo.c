#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>
typedef struct {
	char name[50];
	int age;
}people;
int main() {
	FILE* pFile = NULL;
	/* ʹ�� fwrite()����д����������� */
	/* ʹ�� fwrite()����д�����������
	int buffer[] = { 1,2,3,4,5 };
#pragma warning (disable : 4996)
	if ((pFile = fopen(".\\test.txt", "wb")) == NULL) {
		printf("Can't open the file .");
		exit(0);
	}
	fwrite(buffer, sizeof(int), 5, pFile);
	*/

	/* ʹ�� fread() ������ȡ����������*/
	/*
	int buffer[5];
	#pragma warning(disable : 4996)
	if ((pFile = fopen(".\\test.txt", "rb")) == NULL) {
		printf("Can't open the file.\n");
	}
	if (fread(buffer, sizeof(int), 5, pFile) == 0) {
		printf("File read error\n");
	}
	for (int i = 0; i < 5; i++) {
		printf("%d\n", buffer[i]);
	}
	*/

	/* ʹ�� fwrite() ����д��ṹ������*/
	/*
	int i = 0;
	people per[3];
	per[0].age = 20; strcpy(per[0].name, "li");
	per[1].age = 18; strcpy(per[1].name, "wang");
	per[2].age = 21; strcpy(per[2].name, "zhang");
#pragma warning(disable : 4996)
	if ((pFile = fopen(".\\test.txt", "wb+")) == NULL) {
		printf("Can't open the file.\n");
	}
	// д��ṹ��
	for (i = 0; i < 3; i++) {
		if (fwrite(&per[i], sizeof(people), 1, pFile) != 1) {
			printf("File write error \n");
		}
	}
	*/

	//people per;
	/* ʹ�� fread() ������ȡ�ṹ������*/
	/*
	if ((pFile = fopen(".\\test.txt", "rb")) == NULL)
		printf("Open file error .");
	while (fread(&per, sizeof(people), 1, pFile) == 1) {
		printf("%-30s\t%-3d\n", per.name, per.age);
	}
	*/
	/* ʹ��fseek(FILE* stream, long offset, int whence) �����ļ�ָ��
	whence ������ SEEK_SET,SEEK_CUR,SEEK_END ��Щֵ�����Ǵ�
	�ļ�ͷ��
	��ǰ��
	�ļ�β����ƫ���� offset��
	*/
	if ((pFile = fopen(".\\seekInput.txt", "r+")) == NULL)
		printf("Can't open file");
	fprintf(pFile, "�����ҵľƣ��������");
	fseek(pFile, 22, SEEK_SET);
	if (fputc(65, pFile) == EOF)
		printf("fputc fail");

	fclose(pFile);
	system("Pause...\nPress any key to exit.");
	return 0;
}