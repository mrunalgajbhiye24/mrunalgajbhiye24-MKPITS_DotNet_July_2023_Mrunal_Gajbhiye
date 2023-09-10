#include<iostream>
using namespace std;
class Circle
{
	public:
		int radius;
		float calculateArea()
		{
			float a=3.14f*radius*radius;
			return a;
		}
		float calculateCirc()
		{
			float cir=2*3.14f*radius;
			return cir;
		}
};
int main()
{
	float result;
	Circle c1;
	cout<<"enter radius";
	cin>>c1.radius;
	result=c1.calculateArea();
	cout<<"area="<<result<<endl;
	
	result=c1.calculateCirc();
	cout<<"circ="<<result<<endl;
}
