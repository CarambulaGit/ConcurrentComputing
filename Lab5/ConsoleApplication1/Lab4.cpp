#include <iostream>
#include "F1.h"
#include "F2.h"
#include "F3.h"
#include <omp.h>



/**
 * Parallel computing.
 * Labwork 4. OpenMP.
 *
 * F1  1.12  A = B + C + D * (MD * ME)
 * F2  2.24  MG = sort(MF - MH * MK)
 * F3  3.21  S = sort(O * MO) * (MS * MT)
 *
 * Didenko Vladyslav
 * IO-91
 * 10.11.2021
 */


int N = 5;

int main()
{
    std::cout << "Lab 4 started!\n";

	F1* T1 = new F1(N);
	F2* T2 = new F2(N);
	F3* T3 = new F3(N);

	int tid;
	#pragma omp parallel num_threads(3)
	{
		tid = omp_get_thread_num();
		switch (tid) {
		case 0:
			T1->run();
		case 1:
			T2->run();
		case 2:
			T3->run();
		}
	}

	std::cout << "Lab 4 end\n" << "Press Enter...";
}