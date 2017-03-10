// IntroCPP.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

class CStudent
{
public:
	CStudent(){
		studentId = "00000";
		name = "Boris";
		lastName = "Ruiz";
	}

	string studentId;
	string name;
	string lastName;

	int nuevoSaldo(int pago) {
		saldo -= pago;
	}
	
private:
	float saldo;

};

bool compareStudents(CStudent p1, CStudent p2){
	//Finish Reading Params
	bool res = p1.name == p2.name;
	return res;
}

bool compareStudents(CStudent* p1, CStudent p2) {
	//Finish Reading Params
	bool res = p1->name == p2.name;
	return res;
}

bool compareStudents(CStudent* p1, CStudent* p2) {
	//Finish Reading Params
	bool res = p1->name == p2->name;
	return res;
}

void test()
{
	int j = 20;
	int t = 399;
	float jm = 33.323f;
	CStudent* ce = new CStudent();
}

int main(){

	test();

	//Instance est1
	CStudent est;

	//Instance est1
	CStudent est2;

	///Begins No Pointers
	compareStudents(est, est2);
	///Ends No Pointers

	///Begins One Pointer Pointers
	compareStudents(&est, est2);
	///Ends One Pointer Pointers

	///Begins Only Pointers
	compareStudents(&est, &est2);
	///Ends Only Pointers

	
	return 0;
}

