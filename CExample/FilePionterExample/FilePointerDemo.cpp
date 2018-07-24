#include <stdio.h>
#include <Windows.h>

int main() {
	/* Method
	// 输入二进制
		size_t fread(void* ptr,size_t zise_of_elements,
							size_t number_of_elements,FILE* a_file)
	// 输出二进制
		size_t fwrite(const void* ptr,size_t size_of_elements,
							size_t number_of_elements, FILE* a_file)
	*/



	FILE* fp = NULL;
#pragma warning(disable: 4996)
	// fp = fopen(".\\test.txt", "w+");
	// 向文件中写入数据
	// fprintf(fp, "This is testing for fprintf...\n");
	// fputs("This is testing for fputs ...\n", fp);

	// 读取文件
	 fp = fopen(".\\test.txt", "r");
	 char buff[255];
	 // 读取第一个单词
	 fscanf(fp, "%s", buff);
	 printf("1: %s\n", buff);
	 // 读取剩下的行数据
	 fgets(buff, 255, (FILE*)fp);
	 printf("2: %s", buff);
	 // 读取整行数据
	 fgets(buff, 255, (FILE*)fp);
	 printf("3: %s\n", buff);
	// 关闭打开的文件，成功返回非负值，失败返回EOF
	fclose(fp);
	printf("Create sucess");
	system("pause...");
	return 0;
}