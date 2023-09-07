#include<stdio.h>
int main()
{
	int num;
	int counter=2;
	int rem=0;
	printf("enter num");
	scanf("%d",&num);
	do
	{
		rem=num%counter;
		if(rem==0)
		{
			printf("not a prime no");
		}
		counter=counter+1;
		
	}
	while(counter<num);
	    if(num==counter)
	{
		printf("it is a prime no");
		
	}
	
}
