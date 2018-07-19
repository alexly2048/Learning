#include <stdio.h>

void staticDemo();

int main() {
	staticDemo();
	staticDemo();
	staticDemo();
}
void staticDemo() {
	static int temp = 1;
	printf("%d \t",temp);
	temp++;
}