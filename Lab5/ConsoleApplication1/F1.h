#pragma once
#include <iostream>
#include <windows.h>
#include "Matrix.h"
#include "Vector.h"


class F1 {
private:
	Vector* result;
	int N;
public:
	F1(int N);
	Vector* getResult();
	void run();
};
