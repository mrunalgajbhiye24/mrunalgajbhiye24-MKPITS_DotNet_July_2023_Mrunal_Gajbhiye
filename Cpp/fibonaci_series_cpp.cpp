#include<iostream>
using namespace std;
int main()
{
	int i;
	int num1=0;
	int num2=1;
	int add=num1+num2;
	cout<<"0,";
	cout<<"1";
	for(i=3;i<10;i++)
	{
		cout<<","<<add;
		num1=num2;
		num2=add;
		add=num1+num2;
	}
}
