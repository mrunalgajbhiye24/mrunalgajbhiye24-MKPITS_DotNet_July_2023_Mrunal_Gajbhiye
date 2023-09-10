#include<iostream>
using namespace std;
class classA
{
	protected:
		int n1;
	public:
	void getn1(int n)
	{
		n1=n;
	}	
};
class classB:public classA
{
	protected:
		int n2;
	public:
	void getn2(int n)
	{
		n2=n;
	}	
};
class classC
{
	protected:
		int n3;
	public:
	void getn3(int n)
	{
		n3=n;
	}	
};
class classD:public classB,public classC
{
	public:
		int multiply()
		{
			int m=n1*n2*n3;
			return m;
		}
};
int main()
{
	int res;
	classD d;
	d.getn1(4);
	d.getn2(4);
	d.getn3(4);
	res=d.multiply();
	cout<<"multiplication ="<<res<<endl;
	return 0;
}
