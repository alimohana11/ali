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
		x player1 = new x ("player1",0);
		y player2  = new y ("player2",0);
		ladder[] ladderArray = new ladder[8]; 
		snake[] snakArray = new snake [7];
		
		
		ladderArray [0] = new ladder (1,38);
		ladderArray [1] = new ladder (4,14);
		ladderArray [2] = new ladder (8,30);
		ladderArray [3] = new ladder (21,42);
		ladderArray [4] = new ladder (28,76);
		ladderArray [5] = new ladder (80,99);
		ladderArray [6] = new ladder (71,92);
		ladderArray [7] = new ladder (50,67);
		
		snakArray [0] = new snake (95,56);
		snakArray [1] = new snake (97,78);
		snakArray [2] = new snake (88,24);
		snakArray [3] = new snake (62,18);
		snakArray [4] = new snake (48,26);
		snakArray [5] = new snake (34,6);
		snakArray [6] = new snake (32,10);
		
		
		int mzal; 
		random moves = new moves();
		mzal = moves.next(2,12)
		player1.num = player1.num + mzal;
		mzal = moves.next(2,12)
		player2.num = player2.num + mzal;
		
		
		for (int n =0 ; n<8; n++)
		{
			if (player1.num=ladderArray[i].up)
			{
				player1.num=ladderArray[i].down
			}
			
			if (player2.num=ladderArray[i].up)
			{
				player2.num=ladderArray[i].down;
			}
		}
		
		for (int n ; n<7 ; n++ )
		{
			if(player1.num=snakArray[i].head)
			{
				player1.num = snakArray[i].tail;
			}
			if(player2.num=snakArray[i].head)
			{
				player2.num = snakArray[i].tail;
			}
		}
		
		console.WriteLine("Player 1 : " + player1.num);
		console.WriteLine("Player 2 : " + player2.num);
		
	}
}
