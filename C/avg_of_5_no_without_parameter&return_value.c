#include<stdio.h>
int average()
{
	int n1,n2,n3,n4,n5;
	printf("enter a no");
	scanf("%d%d%d%d%d",&n1,&n2,&n3,&n4,&n5);
	int result=(n1+n2+n3+n4+n5)/5;
	return result;
}
int main()
{
	int result;
	result=average();
	printf("average of 5 no=%d",result);
}

