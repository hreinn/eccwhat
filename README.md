# eccwhat
Html Command line startup tool 

Shows HTML for easy command parameter generation.

Put the name of the runtime in eccwhat.html
Do your think with HTML to explain what the user is doing.

OK starts the program for you.

Details.
<input type="hidden" id="theprogram" value="s3cmd.bat"/>
Change this line to the command line program you want the html to generate parameters from.
f.x. c:\python\python.exe 

Then write html+script that generates those paramters you want.

Pressing ok will run theprogram with the parameters.

window.external.callback(theprogram.value,thename.value, theage.value, !thecheckmybox.checked ? '' : '--recursive');

Will call theprogram "thename.value" "theage.value" "--recursive/''"

I wrote this to solve a problem between chair and computer, hopefully it helps you aswell.

f.x. 

<img src='http://t.np.is/green/20160304233316jumplistforvisualstudio2015.png'>
<img src='http://t.np.is/green/20160304233344jumplistforvisualstudio2015.png'>
