#include <stdio.h>
#include <string.h>
/*
	#define����ı���������ʹ���������ͷ��Ժ������չ��typedef����ı���������ʹ���������ͷ�������չ
*/
typedef struct Books
{
	char  title[50];
	char  author[50];
	char  subject[100];
	int   book_id;
} Book;

int main() {
	Book book;
#pragma warning(disable:4996)
	strcpy(book.title, "C �̳�");
#pragma warning(disable:4996)
	strcpy(book.author, "Runoob");
#pragma warning(disable:4996)
	strcpy(book.subject, "�������");
	book.book_id = 12345;

	printf("����� : %s\n", book.title);
	printf("������ : %s\n", book.author);
	printf("����Ŀ : %s\n", book.subject);
	printf("�� ID : %d\n", book.book_id);

	getchar();
	return 0;
	return 0;
}