#include<iostream>
using namespace std;
int main()
{
	int n1,n2;
	int sum=0;
	char op;
	cout<<"enter 2 num";
	cin>>n1>>n2;
	cout<<"enter op(+,-,*)";
	cin>>op;
	if(op=='+')
	{
		sum=n1+n2;
	}
	else if(op=='-')
	{
				sum=n1-n2;
	}
	else if(op=='*')
	{
		sum=n1*n2;
	}
	cout<<"sum="<<sum;
	return 0;
}
