#include "F1.h"

F1::F1(int N) {
	this->N = N;
}

Vector* F1::getResult() {
	return result;
}


// F1  1.12  A = B + C + D * (MD * ME)

void F1::run() {
	cout << "Task 1 start\n";
	Vector *B = new Vector(N), *C = new Vector(N), *D = new Vector(N) ;
	Matrix *MD = new Matrix(N), *ME = new Matrix(N);
	result = B->sum(C->sum(MD->multiply(ME)->multiply(D)));
	cout << "Thread 1 result:\n" << endl << result->toString() << endl;
	cout << "Task 1 end\n";
	delete B;
	delete C;
	delete D;
	delete MD;
	delete ME;
}