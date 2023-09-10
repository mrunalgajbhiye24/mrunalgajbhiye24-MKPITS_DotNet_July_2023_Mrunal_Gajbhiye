#include<iostream>
using namespace std;
class calculation
{
	public:
	int add(int n1,int n2)
	{
		return n1+n2;
	}
	int add(int n1,int n2,int n3)
	{
		return n1+n2+n3;
	}
};
int main()
{
	calculation c;
	cout<<"addition of 2 no:"<<c.add(2,3)<<endl;
	cout<<"addition of 3 no:"<<c.add(2,3,4);
	return 0;
}
