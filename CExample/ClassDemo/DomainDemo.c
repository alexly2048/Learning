#include <stdio.h>

void staticDemo();

int main() {
	staticDemo();
	staticDemo();
	staticDemo();
	getchar();
}
void staticDemo() {
	static int temp = 1;
	printf("%d \t", temp);
	temp++;
}