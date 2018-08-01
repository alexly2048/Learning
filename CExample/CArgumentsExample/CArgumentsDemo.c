#include <stdio.h>
#include <Windows.h>
int main(int argc, char* argv[]) {
	if (argc == 2) {
		printf("The argument supplied is %s\n", argv[1]);
	}
	else if (argc > 2){
		for (int i = 1; i < argc; i++) {
			printf("The argument supplied %d is %s\n", i, argv[i]);
		}
	}
	else {
		printf("One argument expected.\n");
	}
	system("pause...");
	return 0;
}