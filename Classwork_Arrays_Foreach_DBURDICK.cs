using UnityEngine;

// L9 - Arrays & foreach (In-Class Classwork)
// Work through the TODOs in order. Attach this to an empty GameObject and press Play to test.
// Directions:
//   Section A - read the code and write your predicted answer, then test it.
//   Section B - write the code for each task.
//   Section C - solve each mini-interview problem (the approach is up to you).
public class Classwork_Arrays_Foreach_DBURDICK : MonoBehaviour
{
    void Start()
    {
        // For Section A, use this array:
        int[] loot = { 5, 10, 15, 20 };

        // ============================================================
        // SECTION A: Trace & Predict (predict, then test)
        // ============================================================
        // A1. loot[0]
        // Answer: 5
        //
        // A2. loot[3]
        // Answer: 20
        //
        // A3. loot.Length
        // Answer: 4
        //
        // A4. loot[loot.Length - 1]
        // Answer: 3
        //
        // A5. loot[4]        (valid, or ERROR?)
        // Answer: error
        //
        // A6. loot[-1]       (valid, or ERROR?)
        // Answer: error
        //
        // A7. What does this print?
        //     foreach (int g in loot)
        //     {
        //         Debug.Log(g);
        //     }
        // Answer: 5
        //          10
        //          15
        //          20
        //
        // A8. What does this print?
        //     for (int i = 0; i < 2; i++)
        //     {
        //         Debug.Log(loot[i]);
        //     }
        // Answer: 5        
                // 10       

        // ============================================================
        // SECTION B: Application (write the code)
        // ============================================================
        // B1. Declare three arrays (write the full lines):
        //     a) three room names as strings: "Hall", "Vault", "Cell"
        //     b) four potion counts as ints: 2, 4, 6, 8
        //     c) an empty array that holds 5 ints (all start at 0)
        string[] rooms = {"Hall", "Vault", "Cell"};
        int[] potionCounts = {2, 4, 6, 8};
        int[] emptyArray = new int[5]; //i think this is the correct way to go about it, although this was just what i found after searching this up.
        //
        // B2. TOTAL LOOT: add up every value in the loot array above and print
        //     the total.
        int totalTreasure = 0;
        foreach (int g in loot)
             {
                 totalTreasure += g;
             }
        Debug.Log(totalTreasure);
        //
        // B3. INVENTORY LIST: given a string[] of items, print each item together
        //     with its index, like "0: torch". 
        string[] items = {"Lamp", "Rope", "Bomb", "Torch"};
        for (int i = 0; i < items.Length; i++)
        {
            Debug.Log(i + ": " + items[i]);
        }
        
        // B4. UPGRADE A SLOT: change the third item of an int[] to a new value,
        //     then print the whole array.
        int[] slots = {1, 2, 3};
        slots[2] = 5;
        foreach (int g in slots)
        {
            Debug.Log(g);
        }

        // ============================================================
        // SECTION C: Mini-Interview (write the code)
        // ============================================================
        // C1. STRONGEST ENEMY: given int[] enemyHealth, find and print the
        //     largest value (don't use a built-in Max).
        int[] enemyHealth = {100, 400, 300, 200};
        int currentLargestHP = 0;
        for (int i = 0; i < enemyHealth.Length; i++)
        {
            if (currentLargestHP < enemyHealth[i])
            {
                currentLargestHP = enemyHealth[i];
            }
        }
        Debug.Log(currentLargestHP);
        //
        // C2. COUNT THE POTIONS: given a string[] of items and a target word
        //     (say "potion"), print how many times the target appears.
    string[] items2 = {"potion", "lamp", "oil", "rope", "potion", "bomb"};
    int potionCount = 0;
        foreach (string i in items2)
        {
            if (i == "potion")
            {
                potionCount += 1;
            }
        }   
        Debug.Log(potionCount);

        //
        // C3. REVERSE ROLL CALL: given a string[] of party members, print the
        //     names from last to first.

        string[] names = {"Patricia", "Patrick", "Petunia", "Parker"};

        for (int i = names.Length - 1; i >= 0; i--)
        {
            Debug.Log(names[i]);
        }
        //
        // C4. SURVIVORS: given int[] enemyHealth, print how many enemies are
        //     still alive (health above 0).
        int[] enemyHealth2 = {10,20,0,30,0,40,0};
        int aliveEnemies = 0;
        foreach (int e in enemyHealth2)
            {
                if (e > 0)
                {
                    aliveEnemies++;
                }
            }
            Debug.Log(aliveEnemies);
        //
        // C5. SORT THE LOOT: given an int[] of values in any order, rearrange
        //     them so they run from smallest to largest, then print them in order.
        //i got some help from my uncle who has a lot more experience with having to think through these sorts of problems for this one, so ill leave some comments to show that i understand what we worked out
        int[] moreEnemyHealth = {50, 20, 90, 10, 50, 60};
        int c = 0;
        for (int i = 0; i < moreEnemyHealth.Length - 1; i++) // loops multiple times because each loop nested inside of this one only pushes the current largest number to the front
        {
            for (int p = 0; p < moreEnemyHealth.Length - i - 1; p++) //the loop shouldn't need to go through every variable each time, as the bigger variables get pushed to the end, so they don't need to be checked again
            {
                if (moreEnemyHealth[p] > moreEnemyHealth[p + 1])
                {
                    c = moreEnemyHealth[p]; // this basically repeats the "swap a and b using a third variable" problem we did awhile ago
                    moreEnemyHealth[p] = moreEnemyHealth[p + 1];
                    moreEnemyHealth[p + 1] = c;
                }
            }
        }
        for (int i = 0; i < moreEnemyHealth.Length; i++) // honestly i dont know if theres a better way to print these out, that would be nice to know
        {
            Debug.Log(moreEnemyHealth[i]);
        }
        //
        // C6. FIND IN THE SORTED LOOT: using the now-sorted values from C5, look
        //     for a particular value and print whether it is in the list and, if
        //     so, at what index.
        foreach (int e in moreEnemyHealth)
        {
            if (e == 10)
            {
                Debug.Log("Target HP Found");
            }
        }
        //
        // C7. PALINDROME WORD: given a word (say "level"), print whether it reads
        //     the same forwards and backwards.
        // for reference for future self: probably just make a list of chars for the word. to find the opposite end do listthingy.Length - i (dont forget Length has a capital L)
        // find a way to check if the list length is even or odd, thats gonna factor into it probably (it didnt lol)
        // make a for loop like (i = 0; i<halfthelengthofthelist; i++) (didnt need to make it half the length of the list)
        char[] word = {'l', 'e', 'v', 'e', 'l'};
        bool isPalindrome = true;
        for (int i = 0; i < word.Length - 1; i++)
        {
            if (word[i] == word[word.Length - (i+1)])
            {
                continue;
            }
            else
            {
                isPalindrome = false;
            }
        }
        if (isPalindrome == true)
        {
            Debug.Log("The word is a palidrome.");
        }
        else
        {
            Debug.Log("The word is not a palindrome.");
        }
    }
}
