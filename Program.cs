//start main

int userChoice = GetUserChoice();
while(userChoice!=3){
    RoutUser(userChoice);
    userChoice = GetUserChoice();
}
//end main


static int GetUserChoice(){
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu(){
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userChoice){
    if(userChoice=="1" || userChoice=="2" || userChoice == "3"){
        return true;
    }
    else return false;
}

static void RoutUser(int menuChoice){
    if(menuChoice==1){
        GetFull();
    }
    else if(menuChoice==2){
        GetPartial();
    }
    else if(menuChoice!=3){
        SayInvalid();
    }

}


static void GetFull(){
    Console.Clear();
    Random rnd = new Random();
    int numberOfRows = rnd.Next(3,10);
    for (int i = 1; i<=numberOfRows; i++){
        for (int j = 1; j<=i; j++){
            Console.Write("O ");
        }
        System.Console.WriteLine();
    }
}


static void GetPartial(){
    Console.Clear();
    Random rnd = new Random();
    int numberOfRows = rnd.Next(3, 10);

    for (int i = 1; i <= numberOfRows; i++){
        for (int j = 1; j <= numberOfRows - i; j++){
            Console.Write(" ");
        }
        for (int k = 1; k <= i; k++){
            if (rnd.Next(0, 2) == 1){
                Console.Write("O  ");
            }
            else{
                Console.Write("   ");
            }
        }
        Console.WriteLine();
    }
}
    

static void SayInvalid(){
    Console.Clear();
    System.Console.WriteLine("Invalid!");
    PauseAction();
}

static void PauseAction(){
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}