#include<iostream>
using namespace std;
class Bankaccount
{
	public:
	    int accountno;
	    int bal=1000;
	    int amt;
int deposite()
{
		bal=bal+amt;
		return bal;
}
int withdrawal()
{
		bal=bal-amt;
		return bal;
}
};
int main()
{
	int result;
	Bankaccount b1;
	cout<<"enter accountno"<<endl;
	cin>>b1.accountno;
	cout<<"enter amt"<<endl;
	cin>>b1.amt;
	result=b1.deposite();
	cout<<"deposite="<<result<<endl;
	result=b1.withdrawal();
	cout<<"withdrawal="<<result<<endl;	
}
