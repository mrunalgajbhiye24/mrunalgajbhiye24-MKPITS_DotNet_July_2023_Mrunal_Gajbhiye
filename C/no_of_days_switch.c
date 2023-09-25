#include<stdio.h>
void main()
{
	int N;
	printf("/n enter a month");
	scanf("%d",&N);
	switch(N)
	{
		//case for 31 days
		case 1:
			case 3:
				case 5:
					case 7:
						case 8:
							case 10:
								case 12:
									printf("31 days");
									break;
		
		//case for 30 days
		case 4:
		case 6:
		case 9:
		case 11:
		printf("30 days");
		break;
		
		//case for 28 days
		case 2:
		printf("28 days");
		break;
		
		default:
		printf("Invalid month");
		break;															
	}
}
