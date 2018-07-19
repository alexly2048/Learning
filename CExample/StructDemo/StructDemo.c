#include <stdio.h>
#include <string.h>

struct Books {
	char title[50];
	char author[50];
	char subject[100];
	int book_id;
};

/* 函数声明*/
/*
void printBook(struct Books book);
*/
void printBook(struct Books *book);
int main() {
	struct Books Book1;
	struct Books Book2;
	/* Book1 信息*/
	strcpy_s(Book1.title, 50,"C Programming");
	strcpy_s(Book1.author,50, "Nuha Ali");
	strcpy_s(Book1.subject, 100,"C Programming Tutorial");
	Book1.book_id = 6495407;

	/* Book2 详述 */
	strcpy_s(Book2.title, 50,"Telecom Billing");
	strcpy_s(Book2.author,50, "Zara Ali");
	strcpy_s(Book2.subject,100, "Telecom Billing Tutorial");
	Book2.book_id = 6495700;

	/* 输出 Book1 信息 */
	/*
	printf("Book 1 title : %s\n", Book1.title);
	printf("Book 1 author : %s\n", Book1.author);
	printf("Book 1 subject : %s\n", Book1.subject);
	printf("Book 1 book_id : %d\n", Book1.book_id);
	*/
	/* 输出 Book2 信息 */
	/*
	printf("Book 2 title : %s\n", Book2.title);
	printf("Book 2 author : %s\n", Book2.author);
	printf("Book 2 subject : %s\n", Book2.subject);
	printf("Book 2 book_id : %d\n", Book2.book_id);
	*/
	printBook(&Book1);
	printBook(&Book2);

	getchar();
	return 0;
}
/* 结构体作为参数传递
void printBook(struct Books book) {
	printf("Book title : %s\n", book.title);
	printf("Book author : %s\n", book.author);
	printf("Book subject : %s\n", book.subject);
	printf("Book book_id : %d\n", book.book_id);
	}
*/
void printBook(struct Books *book)
{
	printf("Book title : %s\n", book->title);
	printf("Book author : %s\n", book->author);
	printf("Book subject : %s\n", book->subject);
	printf("Book book_id : %d\n", book->book_id);
}


