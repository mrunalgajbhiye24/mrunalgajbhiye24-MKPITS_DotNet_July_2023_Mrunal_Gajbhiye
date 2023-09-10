#include<iostream>
using namespace std;
class Account
{
	public:
		int actno;
		int bal;
		static float roi;
		
		Account(int actno,int bal)
		{
			this->actno=actno;
			this->bal=bal;
		}
		void display()
		{
			cout<<"actno :"<<actno<<endl;
			cout<<"bal :"<<bal<<endl;
			cout<<"rate of interest :"<<roi<<endl;
		}
};
float Account::roi=9.5f;
int main()
{
	Account A1=Account(123,2000);
	Account A2=Account(212,3000);
	A1.display();
	A2.display();
	return 0;
}
