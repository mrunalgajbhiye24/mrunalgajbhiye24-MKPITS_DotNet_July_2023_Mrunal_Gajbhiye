#include<iostream>
using namespace std;
class Student
{
	public:
		int RollNumber;
		string name;
		int studentclass;
		int marks;
void getdata()
{
	cout<<"student details"<<endl;
	cout<<"name"<<endl;
	cin>>name;
	cout<<"class"<<endl;
	cin>>studentclass;
	cout<<"RollNumber"<<endl;
	cin>>RollNumber;
	cout<<"marks(0-100)"<<endl;
	cin>>marks;
}
void displayGrade()
{
	if(marks>=90)
{
	cout<<"A";
}
    else if(marks>=80)
{
	cout<<"B";
}
    else if(marks>=70)
{
	cout<<"C";
}
    else if(marks>=60)
{
	cout<<"D";
}
	else
{
	cout<<"E";
}
}
void displayInformation()
{
	cout<<"name :"<<name<<endl;
	cout<<"studentclass :"<<studentclass<<endl;
	cout<<"RollNumber :"<<RollNumber<<endl;
	cout<<"marks :"<<marks<<endl;
}		
};
int main()
{
	Student stud;
	stud.getdata();
	stud.displayInformation();
	stud.displayGrade();
	return 0;
  
}
