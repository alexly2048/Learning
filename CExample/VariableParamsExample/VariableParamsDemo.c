#include <stdio.h>
#include <stdarg.h>
#include <Windows.h>

double average(int paramCount, ...) {
	va_list valist;
	double sum = 0.0;

	/* 初始化valist,参数个数为paramCount*/
	va_start(valist, paramCount);
	/* 访问所有赋给valist的参数 */
	for (int i = 0; i < paramCount; i++) {
		sum += va_arg(valist, int);
	}
	/* 清理为 valist 保留的内存*/
	va_end(valist);

	return sum / paramCount;
}
int main() {
	printf("Average of 1, 2, 3, 4 = %f\n", average(4, 1, 2, 3, 4));
	printf("Average of 1,2,3,4,5 = %f\n", average(5, 1, 2, 3, 4, 5));
	system("pause");
	return 0;
}