# Plan Your Heist

Plan Your Heist is a CLI game built in C# where users are able to assemble their dream team for the ultimate bank heist. Select the level of difficulty, team's skill level, courage factor and number of trial runs and see if your team can crack the bank's vault or risk going to jail.

# Contributors

- Patrick Murphy
- Anthony Johnson
- James Su-Shum

# Installation
1. Copy repo's url
2. ```git clone url``` on your console 
3. Run ```dotnet run``` inside the project's directory

# Project Requirements

### Phase One

The program should...

1. Print the message "Plan Your Heist!".
1. Create a way to store a single team member. A team member will have a _name_, a  _skill Level_ and a _courage factor_. The _skill Level_ will be a positive integer and the _courage factor_ will be a decimal between 0.0 and 2.0.
1. Prompt the user to enter a team member's name and save that name.
1. Prompt the user to enter a team member's skill level and save that skill level with the name.
1. Prompt the user to enter a team member's courage factor and save that courage factor with the name.
1. Display the team member's information.

### Phase Two

The program should be updated to...

1. Create a way to store several team members.
1. Collect several team members' information.
1. Stop collecting team members when a blank name is entered.
1. Display a message containing the number of members of the team.
1. Display each team member's information.

### Phase Three

The program should be updated to...

1. Stop displaying each team member's information.
1. Store a value for the _bank's difficulty level_. Set this value to 100.
1. Sum the skill levels of the team. Save that number.
1. Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.

### Phase Four

The program should be updated to...

1. Create a random number between -10 and 10 for the heist's _luck value_.
1. Add this number to the bank's difficulty level.
1. Before displaying the success or failure message, display a report that shows.
    * The team's combined skill level
    * The bank's difficulty level

### Phase Five

The program should be updated to...

1. Run the scenario multiple times.
1. After the user enters the team information, prompt them to enter the number of _trial runs_ the program should perform.
1. Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new _luck value_ each time.

### Phase Six

The program should be updated to...

1. At the beginning of the program, prompt the user to enter the difficulty level of the bank.
1. At the end of the program, display a report showing the number of successful runs and the number of failed runs.