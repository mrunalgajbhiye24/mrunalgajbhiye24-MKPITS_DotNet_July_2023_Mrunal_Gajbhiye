#include<iostream>
using namespace std;
class employe
{
	public:
		int empno;
		string empname;
		employe()
		{
			empno=123;
			empname="mrunal";
		}
		void display()
		{
			cout<<"empno :"<<empno<<endl;	
			cout<<"empname :"<<empname<<endl;	
		}			
};
int main()
{
	employe emp1;
	emp1.display();
	return 0;
}
