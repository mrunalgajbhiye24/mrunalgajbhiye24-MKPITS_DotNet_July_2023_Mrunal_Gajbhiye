#include<iostream>
using namespace std;
class student
{
	private:
		int rno;
	
	public:
		void display()
		{
			cout<<"rno="<<rno;
		}
		void setdata(int r)
		{
			rno=r;
		}
};
int main()
{
	student s1;
	int rn;
	cout<<"enter rno";
	cin>>rn;
	s1.setdata(rn);
	s1.display();
	return 0;
}
