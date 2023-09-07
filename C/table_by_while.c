#include<stdio.h>
int main()
{
	int counter=1;
	int num;
	printf("enter the num");
	scanf("%d",&num);
	while(counter<=10)
	{
		printf("\n%d*%d=%d",num,counter,num*counter);
		counter++;
	}
	
}
