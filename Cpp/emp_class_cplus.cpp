#include<iostream>
using namespace std;
class employe
{
	public:
		int empno;
		string empname;
		employe(int eno,string ename)
		{
			empno=eno;
			empname=ename;	
		}
		void display()
		{
			cout<<"empno :"<<empno<<endl;
			cout<<"empname :"<<empname<<endl;
		}
};
int main()
{
	int eno;
	string ename;
	cout<<"enter empno and empname";
	cin>>eno>>ename;
	employe emp1(eno,ename);
	emp1.display();
	return 0;
}
