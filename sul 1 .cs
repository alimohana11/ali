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
int changes=0;
ladder [] ladderArray = new ladder[laddernum];
snake [] snakeArray = new snake[snakenum];

Random rnd = new Random();
int goldposition1 = rnd.Next(1,100);
int goldposition2 = rnd.Next(1,100);

while(goldposition1 == goldposition2)
{
 changeroute[changes] = goldposition1;
 changeroute[changes+1] = goldposition2;
 changes= changes+2
 
}


    }
  }
}