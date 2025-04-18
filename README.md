A revisitation of numerone's fortune in which you have to guess the cookie one letter at time.
It has no timer, lets you think.

The use case

The game is a family game to play together, to get to know English, so imagine you and your partner playing "guess the English sentence" and she shouts "as so long, not is so long".

This is the registered motto.

## How to download
## On Android

[![google](https://play.google.com/intl/it_it/badges/static/images/badges/en_badge_web_generic.png)](https://play.google.com/store/apps/details?id=org.altervista.numerone.wheelofnumfortune)

## On Windows

Get the msix you like from the releases on github, which are checked and do not contain viruses. The msix package is associated with a .cer certificate that must be installed in "Local Computer" > "Trusted People".

Prerequisites:

https://winstall.app/apps/Microsoft.DotNet.DesktopRuntime.9

## Updates

For windows the msix packages are platform indepedent and in IL, so you have to download the new dotnet framework runtime eand reinstall the package for obtaining the binary code with latest patches. If microsoft releases new version of maui you need to recompile.

## Differences between maui software and avalonia software

Maui needs to run in a sandbox, while avalonia runs with user permissions.
So on windows it is better to use avalonia.


## Screenshots

<img width="1431" alt="2025-02-01" src="https://github.com/user-attachments/assets/7a9d6bad-9ed7-43ad-bcd6-73350c75a9d4" />
<img width="1431" alt="2025-02-01 (3)" src="https://github.com/user-attachments/assets/dd3aa978-1188-412f-86cd-49e22f425d8d" />
<img width="1431" alt="2025-02-01 (2)" src="https://github.com/user-attachments/assets/7411f027-3e12-448f-a133-5078f586abcd" />
<img width="1431" alt="2025-02-01 (1)" src="https://github.com/user-attachments/assets/f4039f83-2852-4c67-be24-3b2dd90e41c3" />


## Bugs

The multiline bug is resolved, however I see that there are some characters that are not corectly translated from json to system.string, so main features are not guaranteed.

The site on which the app takes the cookies has changed and now it does not allow more than one cookie at time, for changing it you have to restart the application.

## Optimization of STATIC

Using the static variable to save the data it's an optimization, and then Microsoft has decided to exclude the static variable from the garbage collector.

Is happened that cousin Bruno and friend Francesca (not my "francesca") has discovered that after 7 consecutive games the cellphone goes in out of memory, and my Francesca has understoood that static optimization is banned from dotnet 8.0.4.

Now your Android does not goes out of memory, it slows down.
