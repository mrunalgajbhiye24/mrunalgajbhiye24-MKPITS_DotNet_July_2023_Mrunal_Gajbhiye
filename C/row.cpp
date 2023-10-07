#include<stdio.h>
int main()
{
	int row,col,spc,k;
	spc=row+4-1;
	for(row=1;row<=4;row++)
	{
		for(k=spc;k>=1;k--)
		{
			printf(" ");
		}
		for(col=1;col<=row;col++)
		{
			printf("* ",row);
		}
		spc--;
		printf("\n");
	}
}
