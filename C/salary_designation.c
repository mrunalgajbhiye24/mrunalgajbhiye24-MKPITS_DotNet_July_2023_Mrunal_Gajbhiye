#include<stdio.h>
void main()
{
	char name[20];
	char designation;
	int salary;
	printf("enter employe name:\n");
	scanf("%s",&name);
	fflush(stdin);
	printf("enter designation (m,c,p)\n");
	scanf("%c",&designation);
	switch(designation)
	{
		case'm':
			salary=50000;
			break;
		case'c':
		    salary=20000;
			break;
		case'p':
		    salary=10000;
			break;		
	}
	printf("Employe=%s",name);
	printf("Salary=%d",salary);
}
