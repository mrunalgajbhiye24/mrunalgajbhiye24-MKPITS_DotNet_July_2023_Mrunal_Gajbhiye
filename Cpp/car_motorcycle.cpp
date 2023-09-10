#include<iostream>
using namespace std;
class Vehicle
{
	public:
		virtual void start()
		{
			cout<<"start the engine"<<endl;
		}
		virtual void stop()
		{
			cout<<"stop the engine"<<endl;
		}
};
class Car:public Vehicle
{
	public:
		void start()
		{
			cout<<"start the car engine"<<endl;
		}
		void stop()
		{
			cout<<"stop the car engine"<<endl;
		}
};
class Motorcycle:public Vehicle
{
	public:
		void start()
		{
			cout<<"motorcycle engine is start"<<endl;
		}
		void stop()
		{
			cout<<"motorcycle engine is stop"<<endl;
		}
};
class Truck:public Vehicle
{
	public:
		void start()
		{
			cout<<"truck engine is start"<<endl;
		}
		void stop()
		{
			cout<<"truck engine is stop"<<endl;
		}		
};
int main()
{
	Vehicle *V;
	Car c;
	Motorcycle m;
	Truck t;
	V=&c;
	V->start();
	V->stop();
	V=&m;
	V->start();
	V->stop();
	V=&t;
	V->start();
	V->stop();
	return 0;
}
