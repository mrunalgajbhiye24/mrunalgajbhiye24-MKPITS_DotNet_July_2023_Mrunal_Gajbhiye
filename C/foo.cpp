#include<stdio.h>
void foo();
int main()
{
	void foo(int);
	foo(1);
	return 0;
}
void foo(int i)
{
	printf("2");
}

