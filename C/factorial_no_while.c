#include<stdio.h>
int main()
{
	int num;
	int fact=1;
	printf("enter the number");
	scanf("%d",&num);
	while (num>0)
	{
		fact=fact*num;
		num=num-1;
	}
	printf("fact=%d",fact);
}
