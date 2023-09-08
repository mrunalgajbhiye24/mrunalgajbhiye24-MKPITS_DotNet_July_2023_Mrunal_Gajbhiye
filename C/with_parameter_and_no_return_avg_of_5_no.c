#include<stdio.h>
void average(int n1,int n2,int n3,int n4,int n5)
{
	int result=n1+n2+n3+n4+n5/5;
	printf("average of 5 no=%f",result);
}
int main()
{
    float num1,num2,num3,num4,num5,result;
	printf("enter a no");
	scanf("%f%f%f%f%f",&num1,&num2,&num3,&num4,&num5);
	result=(num1+num2+num3+num4+num5)/5;
	printf("average of 5 no=%f", result);
}

