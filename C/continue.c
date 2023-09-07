#include<stdio.h>
int main()
{
	int i=0;
	for(i=1;i<=10;i++)
	{
		if(i%2==0)
	{
		continue;
	}
	printf("\nnum=%d",i);
	}
	printf("\nbye");
}
