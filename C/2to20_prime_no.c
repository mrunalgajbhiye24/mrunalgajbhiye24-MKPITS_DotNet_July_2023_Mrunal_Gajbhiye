#include<stdio.h>
int main()
{
	int counter=2;
	int num;
	int rem=0;
	
	for(num=3;num<=20;num++)
{
		counter=2;
		while(counter<num)
	{
		rem=num%counter;
		if(rem==0)
	{
		break;
    }
		counter++;
	}
		if(num==counter)	
    {
	    printf("\n%d is a prime num",num);
    }
}
}
