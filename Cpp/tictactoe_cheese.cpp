#include<iostream>
using namespace std;
class Game
{
	public:
		virtual void start()=0;
		virtual void play()=0;
		virtual void end()=0;
};
class Tictactoe:public Game
{
	public:
		void start()
		{
			cout<<"tictactoe game is start"<<endl;
		}
		void play()
		{
			cout<<"tictactoe game is play"<<endl;
		}
		void end()
		{
			cout<<"tictactoe game is end"<<endl;
			cout<<endl;
		}
};
class Cheese:public Game
{
	public:
		void start()
		{
			cout<<"cheese game is start"<<endl;
		}
		void play()
		{
			cout<<"cheese game is play"<<endl;
		}
		void end()
		{
			cout<<"cheese game is end"<<endl;
		}
};
int main()
{
	Tictactoe t;
	t.start();
	t.play();
	t.end();
	
	Cheese c;
	c.start();
	c.play();
	c.end();
	return 0;
}
