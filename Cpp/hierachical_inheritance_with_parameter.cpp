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
		int crarea(int l,int b)
		{
			int ra;
			ra=l*b;
			return ra;
		}
};
class triangle:public shape
{
	public:
		float ctarea(int b,int h)
		{
			float ta;
			ta=0.5f*b*h;
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
	ra=r.crarea(length,breath);
	cout<<"area of rectangel :"<<ra<<endl;
	
	cout<<"enter base and height";
	cin>>base>>height;
	ta=t.ctarea(base,height);
	cout<<"area of triangle :"<<ta<<endl;
	return 0;
}
