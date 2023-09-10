#include<iostream>
using namespace std;
class Engine
{
	protected:
		int power;
	public:
	void start()
	{
		cout<<"engine is started"<<endl;
	}
	void stop()
	{
		cout<<"engine is stop"<<endl;
	}		
};
class vehicle
{
	protected:
		int brand;
 
	public:
	    void accelerate()
	{
    	cout<<"car is accelerate"<<endl;	
	}
	void brake()
	{
		cout<<"car brake"<<endl;
	}
	void displaybrand()
	{
		cout<<"display brand:maruti"<<brand<<endl;
	}	
};
class car:public Engine,public vehicle
{
	public:
	void drive()
	
	{
		start();
		accelerate();
		cout<<"car is driving"<<endl;
	}	
	void park()
	{
		brake();
		stop();
		cout<<"car is park"<<endl;
	}
};
int main()
{
	car c1;
	c1.displaybrand();
	c1.drive();
	c1.park();
	return 0;
}
