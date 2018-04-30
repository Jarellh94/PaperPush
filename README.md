# Bibleswipe
A unity3d mobile game where the player sorts scripture verses that may or may not be in the bible.

Goal:
The goal of this game is to correctly sort scriptures into their proper stack. Whether in or not in the bible. The game will then give a score based on the amount of correct guesses. Then it will show all of the sciptures used, whether the player sorted them correctly, and where they are found in the bible. The players have either a limited amount of time, or a limited amount of incorrect moves.

How does it work?
Papers hold the scptures. The papers slide in at the bottom of the stack in the middle of your desk. The player must swipe the paper to the correct stack. The stacks that they move the papers to should get bigger as they progress. Will probably need colliders on each stack to tell when the papers should stop moving and handle whether or not the papers are in the right place. If they’re in the right place, increment the score. If they’re in the wrong place, indicate they’re wrong.

Game Mechanics:
Swiping left and right
The papers are instantiated and move to the bottom of the stack. This will actually be more like a queue.
Papers move from the base stack to their proper stack.
There is a

Programming:

Paper class?
 - Target Stack/variable for value
 - Instantiates a stamp somewhere on the paper
 
Main Stack Class - Goes on mainStackManager
 - Holds a queue of all the papers
 - Add to queue
 - Remove from Queue
  - Returns the paper
  - Activates the next paper
  
PaperSpawner - Goes one mainStackManager
 - Instantiates a paper object
 
PlayerManager
 - Score
 - Number of mistakes
 - Detects swipes
  - Applies actions to 
 - Handle Losing
  - Shows gameover gui
  
GameOverGui
 - Allows player to play again
 
 Tasks to do:
- [x] Fix the papers dropping too far into the stack collider. Probably need to change this to be stopped by y value, not by collision.
- [x] Add a main menu
- [x] Add a lose menu that allows the player to flip through the cards. (Kind of. Currently it's go until you lose.)
- [ ] Create a mode where you play a timed session and it keeps track of what you got wrong.
