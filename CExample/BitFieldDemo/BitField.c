#include <stdio.h>
#include <string.h>

struct BitField {
	unsigned a : 1;
	unsigned b : 3;
	unsigned c : 4;
};

int main() {
	struct BitField bit, *pBit;
	bit.a = 1;
	bit.b = 7;
	bit.c = 15;
	printf("%d,%d,%d\n", bit.a, bit.b, bit.c);

	pBit = &bit;
	pBit->a = 0;
	pBit->b &= 3;
	pBit->c |= 1;
	printf("%d,%d,%d\n", pBit->a, pBit->b, pBit->c);
	getchar();
	return 0;
}