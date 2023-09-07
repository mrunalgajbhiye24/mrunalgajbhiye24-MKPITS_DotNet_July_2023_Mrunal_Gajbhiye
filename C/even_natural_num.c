#include<stdio.h>
int main()
{
	int i;
	int n;
	int sum=0;
	printf("\n enter the number");
	scanf("%d",&n);
	printf("\n the even numbers are:");
	{
		for(i=1;i<=n;i++)
		{
			printf("\n%d",2*i);
			sum+=2*i;
		}
    	printf("\nsum of even natural numbers is %d",sum);
	}
}
