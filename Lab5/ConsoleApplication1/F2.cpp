#include "F2.h"

F2::F2(int N) {
	this->N = N;
}

Matrix* F2::getResult() {
	return result;
}

//  F2  2.24  MG = sort(MF - MH * MK)

void F2::run() {
	cout << "Task 2 start\n";
	Matrix *MF = new Matrix(N), *MH = new Matrix(N), *MK = new Matrix(N);
	result = MF->sub(MH->multiply(MK));
	result = result->sort();
	cout << "Thread 2 result:\n" << endl << result->toString() << endl;
	cout << "Task 2 end\n";
	delete MF;
	delete MH;
	delete MK;
}