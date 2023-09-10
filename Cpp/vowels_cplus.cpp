#include<iostream>
using namespace std;
int main()
{
	int count=0; 
	char name[10];
	char*ptr;
	cout<<"enter name";
	cin>>name;
	ptr=name;
	while(*ptr!='\0')
	{
		if(*ptr=='a'||*ptr=='e'||*ptr=='i'||*ptr=='o'||*ptr=='u')
		{
			count=count+1;
		}
		ptr++;
	}
	cout<<"no of vowels in a string="<<count;
}

