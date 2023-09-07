#include<stdio.h>
int main()
{
	int num;
	int i;
	int cube;
	printf("enter the num");
	scanf("%d",&num);
	for(i=1;i<=num;i++)
	{
		cube=i*i*i;
		printf("\n%d cube is %d",i,cube);
	}
}
