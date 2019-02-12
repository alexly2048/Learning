#include <stdio.h>
#include <stdlib.h>
#include<Windows.h>
#define LIST_SIZE 100;
typedef struct SequenceList {
	int* head;
	int length;
	int size;
} sequence;

sequence initSequence();

int main() {

}

/* 初始化顺序表，此表中存储的是int类型的数据 */
sequence initSequence()
{
	sequence sequenceList;
	sequenceList.head = (int*)malloc(sizeof(int) * 100);
	if (!sequenceList.head) {
		printf("初始化失败");
		exit(0);
	}
	sequenceList.length = 0;
	sequenceList.size = 100;
	return sequence();
}
/* 查找函数，查找顺序列表中int数据，如果匹配到，返回首个匹配的元素的位置*/
int QuerySequence(sequence sequenceList, int element) {
	for (int i = 0; i < sequenceList.length; i++) {
		if (sequenceList.head[i] == element) {
		//	itoa(i + 1, index, 5);
		//	strcat(result,index);
			return i+1;
		}
	}
	/* 未找到元素时返回-1 */
	return -1;
}

/* 更改顺序表中的数据元素
	1. 利用查找函数，找到要修改的元素的位置
	2. 替换该元素*/
sequence UpdateElement(sequence sequenceList, int oldElement, int newElement) {
	int index =  QuerySequence(sequenceList, oldElement);
	sequenceList.head[index + 1] = newElement;
	return sequenceList;
}

/* 向顺序链表中插入数据*/
sequence InsertElement(sequence sequenceList, int newElement, int position) {
	if (position > sequenceList.length + 1 || position < 1) {
		printf("The position is error.");
		return sequenceList;
	}

	if (sequenceList.length == sequenceList.size) {
		sequenceList.head = (int*)realloc(sequenceList.head, (sequenceList.size + 1) * sizeof(int));
		if (!sequenceList.head) {
			printf("Realloc error.");
			return sequenceList;
		}
	}
	// 插入操作，将原列表中position（包含position）的元素全部后移一位
	for (int i = sequenceList.length - 1; i >= position - 1; i--) {
		sequenceList.head[i + 1] = sequenceList.head[i];
	}
	// position后元素后移完成，将所需要的元素插入到position位置
	sequenceList.head[position - 1] = newElement;
	// 插入完成，顺序列表长度+1
	sequenceList.length++;

	return sequenceList;
}

sequence DeleteElement(sequence sequenceList, int position) {
	if (position > sequenceList.length || position < 1) {
		printf("The position is error");
		return sequenceList;
	}
	/* 删除元素时，只需要将删除位置处后的元素逐次前移就可以*/
	for (int i = position; i < sequenceList.length; i++) {
		sequenceList.head[i - 1] = sequenceList.head[i];
	}
	sequenceList.length--;
	return sequenceList;

}
