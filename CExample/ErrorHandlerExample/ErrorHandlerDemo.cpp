#include <stdio.h>
#include <errno.h>
#include <string.h>
#include <Windows.h>

// extern int errno;
int main() {
	FILE* pf = NULL;
	int errnum = 0;
#pragma warning (disable : 4996)
	pf = fopen("unexist.txt", "rb");
	if (pf == NULL) {
		errnum = errno;
		fprintf(stderr, "����ţ� %d\n", errno);
		perror("ͨ�� perror ������� ");
		fprintf(stderr, "���ļ����� %s\n", strerror(errnum));
	}
	else {
		fclose(pf);
	}
	system("pause");
	return 0;
}