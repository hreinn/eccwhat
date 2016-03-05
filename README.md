# eccwhat
<h2>Prompt user for input with Html&javascript, start program with command line arguments. </h2><br/>
Lets you write html to startup your command line program.<br/>

Put the name of the runtime in eccwhat.html<br/>
Do your thing with HTML to explain what the user is doing.<br/>
You can write simple javascript to get user input or do more complex logic to generate the startup paramters.<br/>

After the Html is displayed, any call to window.external.callback starts the program for you and closes the form.

Details.<br/>
(best to use fullpath here)
<input type="hidden" id="theprogram" value="C:\path\s3cmd.bat"/>
Change this line to the command line program you want the html to generate parameters from.
f.x. c:\python\python.exe 

Then write html+script that generates the paramters you want.

Pressing ok will run theprogram with the parameters.

f.x.
window.external.callback(theprogram.value,thename.value, theage.value, !thecheckmybox.checked ? '' : '--recursive');

Will call theprogram "thename.value" "theage.value" "--recursive/''"

I wrote this to solve a problem between chair and computer, hopefully it helps you aswell.

f.x. 

<img src='http://t.np.is/green/20160304233729groovetnlist.png'>
<img src='http://t.np.is/green/20160304233344jumplistforvisualstudio2015.png'>

Please send me any html you think might be useful for other people.
