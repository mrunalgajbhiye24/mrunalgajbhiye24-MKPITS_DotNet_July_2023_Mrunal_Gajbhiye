#include<iostream>
using namespace std;
class Animal
{
	public:
		int eat()
		{
			cout<<"eating"<<endl;
		}
};
class Dog:public Animal
{
	public:
		int bark()
		{
			cout<<"dog bark";
		}
};
int main()
{
	Dog d1;
	d1.eat();
	d1.bark();
	return 0;
}
