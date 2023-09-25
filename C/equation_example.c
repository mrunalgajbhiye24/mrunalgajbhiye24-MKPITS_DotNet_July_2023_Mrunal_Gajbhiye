#include<stdio.h>
int myfunct(int x,int y)
{
	if(y<=0)
	return 1;
	return x*(myfunct(x,y-1));
}
int main()
{
	int result;
	myfunct(5,3);
	printf("result:%d\n",result);
}
