#include<iostream>
using namespace std;
class shape
{
	public:
		int x;
		int y;
        void getdata(int a,int b)
        {
        	x=a;
        	y=b;
		}
};
class rectangle:public shape
{
	public:
		int crarea()
		{
			int ra;
			ra=x*y;
			return ra;
		}
};
class triangle:public shape
{
	public:
		float ctarea()
		{
			float ta;
			ta=0.5f*x*y;
			return ta;
		}
};
int main()
{
	rectangle r;
	triangle t;
	int length,breath,base,height;
	int ra;
	float ta;
	cout<<"enter length and breath";
	cin>>length>>breath;
	r.getdata(length,breath);
	ra=r.crarea();
	cout<<"area of rectangel :"<<ra<<endl;
	
	cout<<"enter base and height";
	cin>>base>>height;
	t.getdata(base,height);  
	ta=t.ctarea();
	cout<<"area of triangle :"<<ta<<endl;
	return 0;
}
