#include<iostream>
using namespace std;
class employe
{
	public:
		//constructor
		employe()
		{
			cout<<"constructor called"<<endl;
		}
		//destructor
		~employe()
		{
			cout<<"destructor called"<<endl;
		}
};
int main()
{
	employe e1;
	employe e2;
	return 0;
}
