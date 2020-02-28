import java.util.Scanner;
import java.util.Random;
import java.util.concurrent.ThreadLocalRandom; // to make a range for random number 1-6
// ^^ this came from a solution I found on stackoverflow:
// https://stackoverflow.com/questions/363681/how-do-i-generate-random-integers-within-a-specific-range-in-java
import java.util.ArrayList;
import java.util.Arrays;
import java.util.stream.IntStream;
import java.lang.System;

import static java.lang.System.exit;

public class Nim {

    // random stuff that needs to be generated
    public static int min_wd = 0; // defining lower bounds of whoFirst and difficulty "wd = whoDifficulty, a hodge podge of 'whoFirst' and 'difficulty' "
    public static int max_wd = 1; // defining upper bounds of whoFirst and difficulty
    public static int whoFirst = ThreadLocalRandom.current().nextInt(min_wd, max_wd + 1); // generate a random number between 0 and 1, which will determine who will go first
    public static int difficulty = ThreadLocalRandom.current().nextInt(min_wd, max_wd + 1); // generate a random number between 0 and 1, which will determine the difficulty of the computer
    public static int min_pile = 10; // defining lower bounds of the pile of marbles
    public static int max_pile = 100; // defining upper bounds of the pile of marbles
    public static int pile_size = ThreadLocalRandom.current().nextInt(min_pile, max_pile + 1); // generate a random number based on the bounds defined above in min/max_pile. This will store the pile size

    // booleans for play style by the computer:
    public static boolean stupid = false; // play style stupid defined in the problem
    public static boolean smart = false; // play style smart defined in the problem

    // booleans for who gets to go first
    public static boolean computer = false;
    public static boolean human = false;

    // booleans to determine whose turn it is
    public static boolean computer_turn = false;
    public static boolean human_turn = false;

    // string that stores who took the most recent turn
    public static String turn = "nobody";
    // this string will come in handy in order to determine who won the game


    public static void main(String[] args) {
       game();
    }

    public static void game(){
        System.out.println("Welcome to the game on Nim. Let's see who will go first...");
        // determine who goes first
        if(whoFirst == 0){
            //computer goes first
            computer = true;
            computer_turn = true;
            System.out.println("Computer will go first.");
        }
        else if(whoFirst == 1){
            //human goes first
            human = true;
            human_turn = true;
            System.out.println("Human will go first.");
        }

        // announce how big the pile shall be
        System.out.println("The size of the pile is: " + pile_size);

        // determine the play style of the computer
        if(difficulty == 0){
            //computer plays stupid
            stupid = true;
            System.out.println("Computer difficulty = easy. You've got this!");
        }
        else if(difficulty == 1){
            //computer plays smart
            smart = true;
            System.out.println("Computer difficulty = hard. You're screwed.");
        }

        while(pile_size != 0) {
            int stupid_min = 1;
            int stupid_max = pile_size / 2;
            if(stupid_max==0){ //if only one marble is left then maximum value should be 1
                stupid_max=1;
            }
            int computer_move = 0;
            int human_move = 0;
            if (human_turn == true) {
                // determine how many marbles the user wants to remove from the pile
                boolean validInput = false;
                do { //Loop until valid input is entered by user
                    Scanner s = new Scanner(System.in);
                    System.out.println("How many marbles do you want to remove from the pile? >>> ");
                    int temp = s.nextInt(); //store the user input in a temporary variable
                    if(temp < stupid_min || temp > stupid_max) {
                        System.out.println("The marbles value must be between " + stupid_min + " and "+  stupid_max);
                    }else{
                        human_move = temp; //assign valid human move value
                        validInput = true; //assign this ti true, to break the loop
                    }
                }while (validInput!=true);

                pile_size -= human_move; // removes marbles from pile
                System.out.println("The pile now has " + pile_size + " marbles left."); // announce new pile size
                human_turn = false; // make sure they don't take more than 1 turn at once
                human_move = 0; // reset the value for the next turn
                turn = "human"; // notes that the last person to take a turn was the human player
                computer_turn = true;
            } else if (computer_turn == true) {
                if (smart == true) {
                    // lets assume the pile is not of any size in powerMoves.
                    // In that case, lets choose a value from powerMoves as our move
                    int[] powerMoves = {3, 7, 15, 31, 63}; // powerMoves array, as described in the problem

                    boolean pileSizeEqualtToPowerMove = false;
                    for(int p=0; p< powerMoves.length; p++) { //check if current pile size is equal any of powerMoves vale
                        if(pile_size==powerMoves[p]) {
                            pileSizeEqualtToPowerMove = true;
                            break;
                        }
                    }
                    if (pileSizeEqualtToPowerMove) { //if current pile size is equal to any of power move value then generate a random number move
                        computer_move = ThreadLocalRandom.current().nextInt(stupid_min, stupid_max + 1);
                    }else { //find the move required to achieve pile size equal to any of powerMove value
                        boolean valueFound = false;
                        for (int p=powerMoves.length-1; p>=0;p--) {
                            int diff = pile_size-powerMoves[p]; //number move required to achieve pile size equal to powerMoves[p]
                            if(diff > 0) {
                                if(diff >= stupid_min && diff<=stupid_max) { //if difference required match lower and higher limit then choose the diff as move
                                    computer_move = diff;
                                    valueFound = true;
                                    break;
                                }
                            }
                        }
                        if(!valueFound) { //if no value found to match the powerMove value, create a random move value (this case will raise when pile size is less than 3)
                            computer_move = ThreadLocalRandom.current().nextInt(stupid_min, stupid_max + 1);
                        }
                    }
                } else {
                    //in stupid mode generate a random move value
                    computer_move = ThreadLocalRandom.current().nextInt(stupid_min, stupid_max + 1);
                }
                pile_size -= computer_move;
                System.out.println("The computer took out " + computer_move + " marbles.");
                System.out.println("The pile now has " + pile_size + " marbles left."); // announce new pile size
                computer_turn = false;
                human_turn = true;
                turn = "computer";
            } else {
                System.out.println("That's odd. We encountered an error. Game over.");
                break;
            }
        }

        // finally, we determine the winner
        if(turn == "computer"){
            System.out.println("The winner is: Human!"); // announce winner
        }
        else if(turn == "human"){
            System.out.println("The winner is: Computer!"); // announce winner
        }
        System.out.println("Thanks for playing the game of Nim! Play again? 1 for yes 2 for no.");
//        Scanner s = new Scanner(System.in);
//        int playAgain = s.nextInt();
//
//        if(playAgain == 1){
//            System.out.println("Clearing out your old game...");
//            for(int i = 0; i <100; i++){
//                System.out.println("           ");
//            }
//            game();
//        }
//        else{
//            exit(0);
//        }


    }
}