#include<iostream>
using namespace std;
class account
{
	public:
		int actno;
		int bal;
		int interest;
		int getdata(int a,int b,int c)
		{
			actno=a;
			bal=b;
			interest=c;
		}
};
class saving:public account
{
	public:
	int deposite(int amt)
	{
		bal=bal+interest+amt;
		return bal;
	}
};
class current:public account
{
	public:
		int deposite(int amt)
		{
			bal=bal+amt;
			return bal;
		}
};
int main()
{
	saving s1;
	current c1;
	int result;
	int actno,bal,interest,amt;
	cout<<"enter act details actno,bal,interest,amt";
	cin>>actno>>bal>>interest>>amt;
	s1.getdata(actno,bal,interest);
	result=s1.deposite(amt);
	cout<<"saving bal :"<<result;
	c1.getdata(actno,bal,interest);
	result=c1.deposite(amt);
	cout<<"current bal without interest :"<<result;
	return 0;
}
