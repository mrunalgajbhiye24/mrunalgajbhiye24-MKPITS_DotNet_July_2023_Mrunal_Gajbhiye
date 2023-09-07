#include<stdio.h>
int main()
{
	int num;
	int counter;
	int res=0;
	printf("enter the num");
	scanf("%d",&num);
	for(counter=1;counter<=10;counter++)
	{
		res=num*counter;
		printf("\n%d*%d=%d",num,counter,num*counter);
	}
}
