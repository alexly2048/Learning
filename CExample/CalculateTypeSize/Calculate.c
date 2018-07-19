#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define MAX_ROW_SIZE 100
#define MAX_COLUMNS_SIZE 100
int * getRandom() {
	static int r[10];
	int i;
	srand((unsigned)time(NULL));
	for (i = 0; i < 10; i++) {
		r[i] = rand();
		printf("r[%d] = %d\n", i, r[i]);
	}
	return r;
}

int maxFunc(int x, int y) {
	return x > y ? x : y;
}

void populate_array(int * array, size_t arraySize, int(*getNextValue)(void)) {
	for (size_t i = 0; i < arraySize; i++) {
		array[i] = getNextValue();
	}
}

int getNextRandomValue(void) {
	
	return rand();
}
int main() {
	// printf("int �洢��С: %lu byte.\n",sizeof(int));
	// printf("unsigned int �洢��С: %lu byte.\n", sizeof(unsigned int));
	// printf("char �洢��С: %lu byte.\n", sizeof(char));
	// printf("short �洢��С: %lu byte.\n", sizeof(short));
	// printf("unsigned short �洢��С: %lu byte.\n", sizeof(unsigned short));
	// printf("long �洢��С: %lu byte.\n", sizeof(long));
	// printf("double �洢��С: %lu byte.\n", sizeof(double));
	// printf("float �洢��С: %lu byte.\n", sizeof(float));
	// printf("unsigned long �洢��С: %lu byte.\n", sizeof(unsigned long));
	// printf("long int �洢��С: %lu byte.\n", sizeof(long int));
	// printf("long float �洢��С: %lu byte.\n", sizeof(long float));
	// printf("long double �洢��С: %lu byte.\n", sizeof(long double));
	// 
	// int arrTest[MAX_ROW_SIZE][MAX_COLUMNS_SIZE]; 
	// for (int i = 0; i < MAX_ROW_SIZE; i++) {
	// 	for (int j = 0; j < MAX_COLUMNS_SIZE; j++) {
	// 		arrTest[i][j] = i + j;
	// 	}
	// }
	// 
	// for (int i = 0; i < MAX_ROW_SIZE; i++) {
	// 	for (int j = 0; j < MAX_COLUMNS_SIZE; j++) {
	// 		printf("Row %lu, Column %lu = %lu\t", i, j, arrTest[i][j]);
	// 	}
	// 	printf("\n");
	// }
	// ʹ��ָ��ָ������
	//int *p;
	//int i;
	//p = getRandom();
	//for (i = 0; i < 10; i++) {
	//	printf("*(p + %d) : %d\n", i, *(p + i));
	// ָ�����飬ָ���ַ���
	// const char *names[] = {
	// 	"Zara Ali",
	// 	"Hina Ali",
	// 	"Nuha Ali",
	// 	"Sara Ali",
	// };
	// int i = 0;
	// for (i = 0; i < 4; i++) {
	// 	printf("Value of names[%d] = %s\n", i, names[i]);
	// }

	// ����ָ��
	// int(*p)(int, int) = &maxFunc;
	// int a, b, c, d;
	// printf("��������������\n");
	// scanf_s("%d %d %d", &a, &b, &c);
	// getchar();
	// d = p(p(a, b), c);
	// printf("����������: %d\n", d);

	// �ص�����
	int myArray[10];
	srand((unsigned)(time(NULL)));
	populate_array(myArray, 10, getNextRandomValue);
	for (int i = 0; i < 10; i++) {
		printf("%d ", myArray[i]);
	}
	getchar();
	return 0;
}