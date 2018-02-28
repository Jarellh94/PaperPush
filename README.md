# PaperPush
A unity3d mobile game about working in an office. Moving papers.

Goal:
This game will be about being a desk worker sorting through papers that are stamped with different stamps. The papers come in onto the desk and the player swipes left or right to place the papers where they need to go. If the player messes up too much, they’ll be fired. The papers come faster as the game progresses. The goal of the game is to get as far as you can for a high score.

How does it work?
The papers slide in at the bottom of the stack in the middle of your desk. The papers are documents like resumes/memos/reports. They are stamped/graded randomly on the paper(causing the player to have to look for it). The game should choose a theme randomly at the start of playing. The player must swipe the paper to the correct stack. The stacks that they move the papers to should get bigger as they progress. Will probably need colliders on each stack to tell when the papers should stop moving and handle whether or not the papers are in the right place. If they’re in the right place, increment the score. If they’re in the wrong place, indicate they’re wrong.

Game Mechanics:
Swiping left and right
The papers are instantiated and move to the bottom of the stack. This will actually be more like a queue.
Papers move from the stack to their proper stack.

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
