#pragma once
#include <iostream>
#include <windows.h>
#include "Matrix.h"
#include "Vector.h"


class F2 {
private:
	Matrix* result;
	int N;
public:
	F2(int N);
	Matrix* getResult();
	void run();
};
