#include<stdio.h>
int main()
{
	int i;
	int n;
	int sum=0;
	printf("\n enter the number");
	scanf("%d",&n);
	printf("\n the odd numbers are:");
	{
		for(i=1;i<=n;i++)
		{
			printf("\n%d",2*i-1);
			sum+=2*i-1;
		}
		printf("\nsum of odd natural numbers is %d",sum);
	}
}
