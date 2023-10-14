#include<stdio.h>
int main()
{
	int num,fact;
	int*ptr=&num;
	printf("enter a num");
	scanf("%d",&num);
	fact=fact*num;
	num=num-1;
	printf("fact=%d",fact);
}
