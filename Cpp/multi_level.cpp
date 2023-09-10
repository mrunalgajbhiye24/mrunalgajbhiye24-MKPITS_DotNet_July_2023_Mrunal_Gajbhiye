#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mobileno;
};
class employe:public person
{
	public:
		int empno;
		int salary;
};
class parttime:public employe
{
	public:
		int hours;
};
int main()
{
	employe e1;
	e1.name="mrunal";
	e1.mobileno=952704;
	e1.empno=123;
	e1.salary=60000;
	cout<<"emp details"<<endl;
	cout<<e1.name<<endl<<e1.mobileno<<endl<<e1.empno<<endl<<e1.salary<<endl;
	
	parttime p1;
	p1.name="purvi";
	p1.mobileno=983439;
	p1.empno=223;
	p1.salary=50000;
	p1.hours=5;
	cout<<"parttime details"<<endl;
	cout<<p1.name<<endl<<p1.mobileno<<endl<<p1.empno<<endl<<p1.salary<<endl<<p1.hours<<endl;
	return 0;
}
	

