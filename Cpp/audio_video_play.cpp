#include<iostream>
using namespace std;
class Media
{
	public:
		virtual void play()=0;
		virtual void pause()=0;
		virtual void stop()=0;
};
class Audioplayer:public Media
{
	public:
		void play()
		{
			cout<<"audio is play"<<endl;
		}
		void pause()
		{
			cout<<"audio is pause"<<endl;
		}
		void stop()
		{
			cout<<"audio is stop"<<endl;
		}
};
class Videoplayer:public Media
{
	public:
		void play()
		{
			cout<<"video is play"<<endl;
		}
		void pause()
		{
			cout<<"video is pause"<<endl;
		}
		void stop()
		{
			cout<<"video is stop"<<endl;
		}
};
int main()
{
	Audioplayer A;
	A.play();
	A.pause();
	A.stop();
	
	Videoplayer V;
	V.play();
	V.pause();
	V.stop();
	return 0;
}
