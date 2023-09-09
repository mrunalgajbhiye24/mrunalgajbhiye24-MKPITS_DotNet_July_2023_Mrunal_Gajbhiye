#include<stdio.h>
int area(int n1,int n2)
{
	int result=n1*n2;
	return result;
}
int main()
{
	int num1,num2,result;
	printf("enter a num");
	scanf("%d%d",&num1,&num2);
	result=area(num1,num2);
	printf("result=%d",result);
}

