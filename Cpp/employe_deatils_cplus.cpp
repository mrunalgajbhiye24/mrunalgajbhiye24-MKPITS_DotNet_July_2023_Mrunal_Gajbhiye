#include<iostream>
using namespace std;
class employe
{
	public:
	int num;
	string name;
	string designation;
	int salary;
int getemployedetails()
{
		cout<<"enter num,name,designation,salary";
		cin>>num>>name>>designation>>salary;
}
int displayemployedetails()
{
	cout<<"num :"<<num<<endl;
	cout<<"name :"<<name<<endl;
	cout<<"designation :"<<designation<<endl;
	cout<<"salary :"<<salary<<endl;
}
};
int main()
{
	employe empl1,empl2;
	cout<<"employe1"<<endl;
	empl1.getemployedetails();
	empl1.displayemployedetails();
	cout<<"employe2"<<endl;
	empl2.getemployedetails();
	empl2.displayemployedetails();	
}
