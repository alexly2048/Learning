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

/* ��ʼ��˳����˱��д洢����int���͵����� */
sequence initSequence()
{
	sequence sequenceList;
	sequenceList.head = (int*)malloc(sizeof(int) * 100);
	if (!sequenceList.head) {
		printf("��ʼ��ʧ��");
		exit(0);
	}
	sequenceList.length = 0;
	sequenceList.size = 100;
	return sequence();
}
/* ���Һ���������˳���б���int���ݣ����ƥ�䵽�������׸�ƥ���Ԫ�ص�λ��*/
int QuerySequence(sequence sequenceList, int element) {
	for (int i = 0; i < sequenceList.length; i++) {
		if (sequenceList.head[i] == element) {
		//	itoa(i + 1, index, 5);
		//	strcat(result,index);
			return i+1;
		}
	}
	/* δ�ҵ�Ԫ��ʱ����-1 */
	return -1;
}

/* ����˳����е�����Ԫ��
	1. ���ò��Һ������ҵ�Ҫ�޸ĵ�Ԫ�ص�λ��
	2. �滻��Ԫ��*/
sequence UpdateElement(sequence sequenceList, int oldElement, int newElement) {
	int index =  QuerySequence(sequenceList, oldElement);
	sequenceList.head[index + 1] = newElement;
	return sequenceList;
}

/* ��˳�������в�������*/
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
	// �����������ԭ�б���position������position����Ԫ��ȫ������һλ
	for (int i = sequenceList.length - 1; i >= position - 1; i--) {
		sequenceList.head[i + 1] = sequenceList.head[i];
	}
	// position��Ԫ�غ�����ɣ�������Ҫ��Ԫ�ز��뵽positionλ��
	sequenceList.head[position - 1] = newElement;
	// ������ɣ�˳���б���+1
	sequenceList.length++;

	return sequenceList;
}

sequence DeleteElement(sequence sequenceList, int position) {
	if (position > sequenceList.length || position < 1) {
		printf("The position is error");
		return sequenceList;
	}
	/* ɾ��Ԫ��ʱ��ֻ��Ҫ��ɾ��λ�ô����Ԫ�����ǰ�ƾͿ���*/
	for (int i = position; i < sequenceList.length; i++) {
		sequenceList.head[i - 1] = sequenceList.head[i];
	}
	sequenceList.length--;
	return sequenceList;

}
