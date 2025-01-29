using System.Threading.Tasks;
using Mission4;
    
// Welcome the user to the game
System.Console.WriteLine("Welcome to Tic-Tac-Toe!");

// create gameboard array to store play choices
char [] board = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];

bool gameEnd = false;

char player = 'X'; // every game starts with player x

int playerInput = 0;

int guesses = 0;


BoardTools.printBoard(board);

do
{
    // Ask each player in turn for their choice and update the game board array
    System.Console.WriteLine("Player " + player + ", where do you want to place an " + player + "?");
    //playerInput = System.Console.ReadLine();
    while (!int.TryParse(System.Console.ReadLine(), out playerInput) 
        || playerInput < 1 
        || playerInput > 9 
        || board[playerInput - 1] == 'X' 
        || board[playerInput - 1] == 'O')
    {
        System.Console.WriteLine("Please enter a number that has not been chosen yet, 1 through 9.");
    }

    board[playerInput-1] = player;


    // set new player
    if (player == 'X')
    {
        player = 'O';
    }
    else if (player == 'O')
    {
        player = 'X';
    }

    guesses++;



    // Print the board by calling the method in the supporting class
    Console.WriteLine(' ');

    BoardTools.printBoard(board);

    Console.WriteLine(' ');

    // Check for a winner by calling the method in the supporting class notify the players when a win has occurred and which player won the game
    if (BoardTools.gameWinner(board))
    {
        gameEnd = true;
        break; // Exit loop
    }

    if (guesses == 9 && gameEnd == false)
    {
        gameEnd = true;
        System.Console.WriteLine("Cat's Game!");
    }
}

while (gameEnd == false) ;


System.Console.WriteLine("Game Over");
