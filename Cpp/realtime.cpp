#include<iostream>
using namespace std;
class Ability
{
	private:
		string abilityname;
	public:
	void getname(string an)
	{
		abilityname=an;	
	}
	void display()
	{
		cout<<"ability :"<<abilityname<<endl;
	}	
};
class Equipment
{
	private:
		string equipmentitem;
		
	public:
	void getEquipmentitem(string ei)
	{
		equipmentitem=ei;
	}
	void display()
	{
		cout<<"equipment :"<<equipmentitem<<endl;
	}	
};
class Character:public Ability,public Equipment
{
	private:
		string charactername;
		
	public:
	void getcharactername(string cn,string an,string ei)
	{
		
		charactername=cn;
		getname(an);
		getEquipmentitem(ei);
	}
	void displayc()
	{
		cout<<"character :"<<charactername<<endl;
		Ability::display();
		Equipment::display();
		
	}				
};
int main()
{
	Character c1;
	c1.getcharactername("alien","attack","gun");
	c1.displayc();
	return 0;
 } 

