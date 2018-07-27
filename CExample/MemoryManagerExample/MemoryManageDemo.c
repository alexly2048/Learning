/*	void* calloc(int num,int size); 在内存中动态分配num个长度为size的内存，默认值0
	void free(void* address); 释放内存
	void* malloc(int num);	在堆区分配一块指定大小的内存，不会初始化值未知
	void* realloc(void* address, int newsize); 重新分配内存，扩展到newsize
	Tip: void* 类型表示未确定类型的指针，可通过类型抓换，转换成任意类型
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

	/* 使用 free() 函数释放内存*/
	free(description);
	system("pause");
	return 0;
}