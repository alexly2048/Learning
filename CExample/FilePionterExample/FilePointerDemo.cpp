#include <stdio.h>
#include <Windows.h>

int main() {
	/* Method
	// ���������
		size_t fread(void* ptr,size_t zise_of_elements,
							size_t number_of_elements,FILE* a_file)
	// ���������
		size_t fwrite(const void* ptr,size_t size_of_elements,
							size_t number_of_elements, FILE* a_file)
	*/



	FILE* fp = NULL;
#pragma warning(disable: 4996)
	// fp = fopen(".\\test.txt", "w+");
	// ���ļ���д������
	// fprintf(fp, "This is testing for fprintf...\n");
	// fputs("This is testing for fputs ...\n", fp);

	// ��ȡ�ļ�
	 fp = fopen(".\\test.txt", "r");
	 char buff[255];
	 // ��ȡ��һ������
	 fscanf(fp, "%s", buff);
	 printf("1: %s\n", buff);
	 // ��ȡʣ�µ�������
	 fgets(buff, 255, (FILE*)fp);
	 printf("2: %s", buff);
	 // ��ȡ��������
	 fgets(buff, 255, (FILE*)fp);
	 printf("3: %s\n", buff);
	// �رմ򿪵��ļ����ɹ����طǸ�ֵ��ʧ�ܷ���EOF
	fclose(fp);
	printf("Create sucess");
	system("pause...");
	return 0;
}