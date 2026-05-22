A revisitation of numerone's fortune in which you have to guess the cookie one letter at time.
It takes sentences using th rest api of helloacm.com.

It has no timer, lets you think.

The use case

The game is a family game to play together, to get to know English, so imagine you and your partner playing "guess the English sentence" and she shouts "as so long, not is so long".

This is the registered motto.

## On Windows

Get the msix you like from the releases on github, which are checked and do not contain viruses. The msix package is associated with a .cer certificate that must be installed in "Local Computer" > "Trusted People".

Prerequisites:

#### Windows

    unigetui://DesktopRuntime
    
Install the windows desktopruntime 10

## Updates

For Windows, the msix packages are platform independent and in IL, but they are in dotnet 9 and 10, so it is necessary to recompile to avoid having a spurious system in case of a new dotnet framework which is however necessary for starting the software, which if updated should prevent the shock on the fans.

## Differences between maui software and avalonia software

Maui needs to run in a sandbox, while avalonia runs with user permissions.
So on windows it is better to use avalonia.


## Screenshots

<img width="1600" height="900" alt="Screenshot 2026-05-22 210020" src="https://github.com/user-attachments/assets/17c23627-de34-4c9a-85e0-0a70ce245141" />
<img width="1600" height="900" alt="Screenshot 2026-05-22 210124" src="https://github.com/user-attachments/assets/61b3727e-cb66-4796-8007-293f88baa519" />
<img width="1600" height="900" alt="Screenshot 2026-05-22 210147" src="https://github.com/user-attachments/assets/24ef42af-dc62-49c0-8764-aeb0c6fb309e" />


## Bugs

The multiline bug is resolved, however I see that there are some characters that are not corectly translated from json to system.string, so main features are not guaranteed. The walkaround is copying the unrevealed string into the solution textbox an change the asterisks.

## Optimization of STATIC

Using the static variable to save the data it's an optimization, and then Microsoft has decided to exclude the static variable from the garbage collector.

Is happened that cousin Bruno and friend Francesca (not my "francesca") has discovered that after 7 consecutive games the cellphone goes in out of memory, and my Francesca has understoood that static optimization is banned from dotnet 8.0.4.

Now your Android does not goes out of memory, it slows down.
