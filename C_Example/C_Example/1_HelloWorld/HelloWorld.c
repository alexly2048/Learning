#include <stdio.h>
#include <Windows.h>

int main() {
	/* Print "Hello World" */
	printf("Helle World !\n");
	char* pString = "Hello World !";
	printf("Output point:  %s\n", pString);


	/* Scanf integer and output integer*/
	int number = 0;
	printf("Please input one number: ");
#pragma warning (disable : 4996)
	scanf("%d", &number);
	printf("You input number is : %d\n", number);

	/* Output char */
	char varA = 'A';
	printf("Variable 'varA' value is : %c\n", varA);
	printf("Variable 'varA' address is: %p\n", &varA);
	printf("Variable 'varA' ASIIC value is : %d\n", varA);

	/* Output float number */
	double f = 1.23;
	double dNum = 3.141592657;
	printf("f's value is : %lf\n", f);
	printf("dNum's value is : %lf\n", dNum);

	/* Outpuc ASIIC char */
	for (int i = 36; i < 127; i++) {
		printf("%d : %c\t", i, i);
		if (((i - 35) % 5) == 0) {
			printf("\n");
		}
	}
	system("pause");
	return 0;
}