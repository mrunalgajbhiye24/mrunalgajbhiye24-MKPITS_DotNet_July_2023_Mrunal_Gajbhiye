#include<stdio.h>
int main()
{
	int i;
	int n;
	int square=2;
	printf("\n enter the number");
	scanf("%d",&n);
	printf("\n the square numbers are:");
	{
		for(i=1;i<=n;i++)
		{
			printf("\n%d",i*i);
			square+=i*i;	
		}
		printf("\nsum of square natural numbers is %d",square,i);
	}
}
