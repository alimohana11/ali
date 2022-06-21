class ladder 
{
	puplic int up;
	puplic int down;
	puplic ladder (int upNew , int downNew)
	{
		up = upNew;
		down = downNew;
	}
}

class snake
{
	puplic int head;
	puplic int tail;
	puplic snake (int headNew , int tailNew)
	{
		head = headNew;
		tail = tailNew;
	}
}

class users
{
	
	puplic string name;
	puplic int num;
	puplic users (string nameNew , int numNew)
	{
		name = nameNew;
		num = numNew;
	}
}

class transfers
{
	static void main()
	{
static void Main()

x player1 = new player("player1",0);
y player2 = new player("player2",0);

console.WriteLine("Enter the number of ladders: ");

console.WriteLine("Enter the number of snakes: ");
int snakenum = console.ReadLine();

int[] changeroute = new int[(laddernum + snakenum )* 2];

ladder [] ladderArray = new ladder[laddernum];
snake [] snakeArray = new snake[snakenum];

int[] changeroute = new int[(laddernum + snakenum )* 2];
int changes=0;
ladder [] ladderArray = new ladder[laddernum];
snake [] snakeArray = new snake[snakenum];

random rd = new Random();
for (int n=0 ; n<laddernum ; n++)
{
 int downposition = rnd.Next(1,100);
 int upposition = rnd.Next (downposition,100);
 
 ladderArray[i] = new ladder (downposition , upposition);
 changeroute [changes] = upposition;
 changeroute [changes + 1] = upposition downposition;
 changes= changes+2;