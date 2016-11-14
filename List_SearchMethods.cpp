// List_SearchMethods.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <iostream>
#include <list>

using namespace std;

struct newList
{
	list<int>k;
};

//Overload to the + operator, this method concanate two lists. 
newList operator+(newList &list1, newList &list2)
{
	//New instance for the new list.
	newList BiggerList; 
	
	//Size of the list 1 and the list 2. 
	int size1 = list1.k.size();
	int size2 = list2.k.size();

	for (int i = 0; i < size2; i++)
	{
		//Push every element of the list 2 to the new list. 
		BiggerList.k.push_front(list2.k.front());
		list2.k.pop_front();
	}

	for (int i = 0; i < size1; i++)
	{
		//Push every element of the list 1 to the new list. 
		BiggerList.k.push_front(list1.k.front());
		list1.k.pop_front();
	}

	//Return the new list that contains both lists received. 
	return BiggerList;
}

//Overload to the - operator, this method delete the elements of the list 2 from the list that contains both lists.  
newList operator-(newList &newOne, newList &list2)
{
	//Use an iterator to point to the elements of the list 2. 
	list<int>::iterator posList2;
	//Temp variable to compare and know if there's elements of the list 2. 
	int temp = 0;

	posList2 = list2.k.begin();

	for (int i = 0; i < list2.k.back(); i++)
	{
		//Compare if the actual value of the temp variable is on the list 2. 
		if (temp == *posList2)
		{
			//If the value is in the list 2, we remove the element from the bigger list. 
			newOne.k.remove(*posList2);
			posList2++;
		}
		temp++;
	}
	//Return list that doesn't have elements of the list2. 
	return newOne;
}

//Method that print the list. 
void print(list<int> & sList)
{
	list<int>::iterator pos;
	pos = sList.begin();
	while (pos != sList.end())
	{
		cout << *pos << endl;
		pos++;
	}
}

int main()
{
	//Implementation
	newList list1, list2, newOne, secondNewOne, listcopy2;

	list1.k.push_front(2);
	list1.k.push_front(3);
	list1.k.push_front(7);

	list2.k.push_front(1);
	list2.k.push_front(4);
	list2.k.push_front(5);
	
	//This copy of the list 2 is in order to remove the elements from the bigger list when we call the "Operator-" method.
	listcopy2.k.push_front(5);
	listcopy2.k.push_front(4);
	listcopy2.k.push_front(1);

	newOne = list1 + list2;

	print(newOne.k);

	secondNewOne = newOne - listcopy2; 

	cout << "NUEVA LISTA" << endl;
	print(secondNewOne.k);

	system("pause");
		
	return 0;
}


