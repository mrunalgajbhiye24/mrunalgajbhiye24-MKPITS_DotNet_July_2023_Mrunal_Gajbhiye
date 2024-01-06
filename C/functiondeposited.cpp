#include<stdio.h>
void deposit(int amt,int bal);
void withdrawl(int amt,int bal);
int main()
{
	int amt,bal=1000;
	printf("enter a amt");
	scanf("%d",&amt);
	deposit(amt,bal);
	withdrawl(amt,bal);
}
void deposit(int amt,int bal)
{
	bal=bal+amt;
	printf("\namt deposited,bal is=%d",bal);
}
void withdrawl(int amt,int bal)
{
	bal=bal-amt;
	printf("\namt withdrawl,bal is=%d",bal);
}

