#include<iostream>
using namespace std;
class employe
{
	public:
		int empno;
		string empname;
		employe(int empno,string empname)
		{
			this->empno=empno;
			this->empname=empname;
		}
		void display()
		{
			cout<<empno :<<empname <<endl;
		}
};
int main()
{
	employe e1(123,"mrunal");
	e1.display();
	return 0;
}

		
			
