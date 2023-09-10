#include<iostream>
using namespace std;
class Shape
{
	public:
		virtual void draw()
		{
			cout<<"draw method of shape"<<endl;
		}
};
class Rectangle:public Shape
{
	public:
		void draw()
		{
			cout<<"draw method of rectangle"<<endl;
		}
};
int main()
{
	Shape *s;
	Shape s1;
	Rectangle r1;
	s=&s1;
	s->draw();
	s=&r1;
	s->draw();
	return 0;
}
