#include <stdio.h>
#include <string.h>
/*
	#define定义的别名，可以使用其他类型符对宏进行扩展，typedef定义的别名，不能使用其他类型符进行扩展
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
	strcpy(book.title, "C 教程");
#pragma warning(disable:4996)
	strcpy(book.author, "Runoob");
#pragma warning(disable:4996)
	strcpy(book.subject, "编程语言");
	book.book_id = 12345;

	printf("书标题 : %s\n", book.title);
	printf("书作者 : %s\n", book.author);
	printf("书类目 : %s\n", book.subject);
	printf("书 ID : %d\n", book.book_id);

	getchar();
	return 0;
	return 0;
}