# CSV
## My approach:
C# and .NET are new to me, so I started with the documentation and a brief tutorial on how to set up a simple app.  Hello World and a basic number guessing game to get familiar with the syntax and writing to the terminal.  

I then started the pseudocode for this app.  I mapped out what I (thought) I needed most in this program.  I left the pseudocode in at the top of the app to show my thought process. 

One of my main challenges was email validation. .NET has some helpful attributes that I utilized EmailAddressAttribute() and it’s methods to verify the emails. I created a test file based on the provided parameters. I initially thought a regex would be the best way to validate an email, however, I soon realized it would be almost impossible to account for all possible emails with a regex.  (I referenced https://github.com/kdeldycke/awesome-falsehood#emails when I was looking for email validation help) The simple *@* check thru .isValid() at least lets me know I have the minimum data to send an email.  My initial thought was to rule out the example test@gmail, however, example@localhost is a valid email and I don’t want to rule out a valid possibility. 
