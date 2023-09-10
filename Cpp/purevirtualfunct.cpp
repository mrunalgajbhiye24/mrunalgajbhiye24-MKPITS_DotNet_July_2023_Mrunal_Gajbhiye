#include<iostream>
using namespace std;
class Account
{
	public:
		int actno;
		int bal;
	virtual void deposite(int amt)=0;
};
class Saving:public Account
{
	public:
		void deposite(int amt)
		{
			int interest=500;
			bal=bal+amt+interest;
			cout<<"bal with interest is:"<<bal<<endl;
		}
};
class Current:public Account
{
	public:
		void deposite(int amt)
		{
			bal=bal+amt;
			cout<<"bal without interest:"<<bal<<endl;
		}
};
int main()
{
	Account *act;
	Saving s;
	act=&s;
	act->actno=123;
	act->bal=2000;
	act->deposite(500);
	
	Current c;
	act=&c;
	act->actno=223;
	act->bal=1000;
	act->deposite(500);
	return 0;
}
