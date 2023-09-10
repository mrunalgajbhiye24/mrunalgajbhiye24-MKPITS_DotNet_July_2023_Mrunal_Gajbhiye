#include<iostream>
using namespace std;
class student
{
	public:
		int rno;
		string name;
		string course;
		void getdata()
		{
			cout<<"enter rno,name,course";
			cin>>rno>>name>>course;
		}
		void displaydata()
		{
			cout<<"rno :"<<rno<<endl;
			cout<<"name :"<<name<<endl;
			cout<<"course :"<<course<<endl;
		}
};
int main()
{
student stud1,stud2;
cout<<"student1"<<endl;
stud1.getdata();
stud1.displaydata();

cout<<"student2"<<endl;
stud2.getdata();
stud2.displaydata();
return 0;
}

