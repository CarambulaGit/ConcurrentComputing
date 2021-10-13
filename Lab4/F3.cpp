#include "F3.h"

F3::F3(int N) {
	this->N = N;
}

Vector* F3::getResult() {
	return result;
}

DWORD WINAPI F3::startThread(void* param) {
	F3* This = (F3*)param;
	return This->run();
}

// F3  3.21  S = sort(O * MO) * (MS * MT)

DWORD F3::run() {
	cout << "Task 3 start\n";
	Vector *O = new Vector(N);
	Matrix *MO = new Matrix(N), *MS = new Matrix(N), *MT = new Matrix(N);
	result = MS->multiply(MT)->multiply(MO->multiply(O)->sort());
	cout << "Thread 3 result:\n" << endl << result->toString() << endl;
	cout << "Task 3 end\n";
	delete O;
	delete MO;
	delete MS;
	delete MT;
	return 0;
}