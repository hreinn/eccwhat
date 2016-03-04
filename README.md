# eccwhat
Html Command line startup tool 

To use it, 

edit eccwhat.html 

<input type="hidden" id="theprogram" value="s3cmd.bat"/>

Change this line to the command line program you want the html to generate parameters from.

f.x. c:\python\python.exe 

Then write html+script that generates those paramters you want.

Pressing ok will run theprogram with the parameters.

window.external.callback(theprogram.value,thename.value, theage.value, !thecheckmybox.checked ? '' : '--recursive');

Will call theprogram "thename.value" "theage.value" "--recursive/''"

I wrote this to solve a problem between chair and computer, hopefully it helps you aswell.

f.x. 
<img src='http://t.np.is/green/20160304231905settings.png'>
<img src='http://t.np.is/green/20160304232844start.png'>
