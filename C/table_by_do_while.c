#include<stdio.h>
int main()
{
	int counter=1;
	int num;
	printf("enter the num");
	scanf("%d",&num);
	do
	{
		printf("\n%d*%d=%d",num,counter,num*counter);
		counter++;
	}
	while(counter<=10);
}

