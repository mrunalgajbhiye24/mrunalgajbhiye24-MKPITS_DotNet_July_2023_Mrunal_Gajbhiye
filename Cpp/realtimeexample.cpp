#include<iostream>
using namespace std;
class Ability
{
	protected:
		string abilityname;
	public:
	void getName(string an)
	{
		abilityname=an;	
	}	
};
class Equipment
{
	protected:
		string equipmentitem;
	public:
	void getEquipmentitem(string ei)
	{
		equipmentitem=ei;
	}	
};
class Character:public Ability,public Equipment
{
	protected:
		string charactername;
	public:
	void getcharactername(string cn)
	{
		charactername=cn;
	}
	void display()
	{
		cout<<"charatername :"<<charactername<<endl;
		cout<<"abilityname :"<<abilityname<<endl;
		cout<<"equipmentname :"<<equipmentitem<<endl;
	}				
};
int main()
{
	Character c1;
	c1.getName("attack");
	c1.getEquipmentitem("gun");
	c1.getcharactername("alien");
	c1.display();
 } 

