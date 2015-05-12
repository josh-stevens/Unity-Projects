using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	// The Text object is the onscreen text box. The enum object lists possible game states.
	// The States object stores the current game state.
	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame. This handles state changes and calls the appropriate
	// state_ function.
	void Update () {
		print (myState);                          // This line prints to the console and is not seen by the player
		if (myState == States.cell) 			      	{state_cell ();} 
		else if (myState == States.cell_mirror)		{state_cell_mirror();}
		else if (myState == States.sheets_0) 		  {state_sheets_0();}
		else if (myState == States.sheets_1) 		  {state_sheets_1();} 
		else if (myState == States.lock_0) 			  {state_lock_0();}
		else if (myState == States.lock_1) 			  {state_lock_1();}
		else if (myState == States.mirror) 			  {state_mirror();}
		else if (myState == States.freedom)			  {state_freedom();}
	}
	
	
	// Below are the state_ functions. These update the onscreen text, and accept user input
	// to change the game state.
	
	void state_cell () {
		text.text = "You have been wrongfully convicted of a brutal crime. The authorities " +
					"conspired to win the conviction, and sentenced you to life in prison.\n\n" +
					"You are in a dirty prison cell. There is nothing but the sheets on the bed, " +
					"a mirror on the wall, and the door which is locked from the outside.\n\n" + 
					"Press S to view Sheets, M to view Mirror, L to view Lock.";
		if (Input.GetKeyDown (KeyCode.S)) 			{myState = States.sheets_0;}
		else if (Input.GetKeyDown (KeyCode.M))		{myState = States.mirror;}
		else if (Input.GetKeyDown (KeyCode.L)) 		{myState = States.lock_0;}
	}
	
	void state_cell_mirror () {
		text.text = "You are still in your cell. There are some dirty sheets on the bed, " +
					"a mark where the mirror used to be, and the door...firmly locked.\n\n" + 
					"Press S to view Sheets or L to view Lock.";
		if (Input.GetKeyDown (KeyCode.S)) 			{myState = States.sheets_1;}
		else if (Input.GetKeyDown (KeyCode.L)) 		{myState = States.lock_1;}
	}
	
	void state_mirror () {
		text.text = "The dirty old mirror on the wall seems loose.\n\n" +
					"Press T to Take the mirror, or R to Return to cell";
		if (Input.GetKeyDown (KeyCode.T)) 			{myState = States.cell_mirror;}
		else if (Input.GetKeyDown (KeyCode.R)) 			{myState = States.cell;}
	}
	
	void state_sheets_0 () {
		text.text = "The musty sheets have a foul odor. They weren't changed after the " +
					"previous occupant departed. Society considers you a beast, not a human.\n\n" + 
					"Press R to Return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) 			{myState = States.cell;}
	}
	
	void state_sheets_1 () {
		text.text = "Looking through the mirror in your hand, the sheets look equally disgusting.\n\n" +
					"Press R to Return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) 			{myState = States.cell_mirror;}
	}
	
	void state_lock_0 () {
		text.text = "The door is locked with a push button lock. You don't know the combination. " +
					"\n\n" + 
					"Press R to Return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) 			{myState = States.cell;}
	}
	
	void state_lock_1 () {
		text.text = "You carefully put the mirror through the bars, and turn it around " +
					"so you can see the lock. You can just make out fingerprint smudges " +
					"on the buttons. You press the dirty buttons, and hear a click.\n\n" + 
					"Press O to Open, or R to Return to your cell.";
		if (Input.GetKeyDown (KeyCode.O)) 			{myState = States.freedom;} 
		else if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell_mirror;}
	}
	
	void state_freedom () {
		text.text = "You are FREE!\n\n" +
					"Press P to Play again";
		if (Input.GetKeyDown (KeyCode.P))			{myState = States.cell;}
	}
}
