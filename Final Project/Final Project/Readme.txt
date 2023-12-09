While most of the program's functionality is explained on the form, I'll explain in more detail given that I've got more space here.
This program is a tool which can be used to solve triangles using trigonometric identities, namely the law of sines and the law of
cosines. 

The form contians three text boxes which correspond to three inputs for a triangle.
The user can select the kind of triangle to be solved; a triangle that is SSS (side, side, side) SAS (side, angle, side) etc. 

While at a quick glimpse, it may look like the program lacks a few inputs (such as SAA), those inputs can be obtained through 
reversing the order of the input values. (Ex; an AAS triangle with the values of 90 degrees, 30 degrees and one unit is the same 
as an SAA triangle with the values of one unit, 30 degrees and then 90 degrees.)

The form contains a pair of buttons labeled "Degrees" and "Radians." These buttons can be switched to change the inputs of degrees
between these two units.

When the user hits the "Confirm" button, the values they inputted are filtered through a menu and then outputted through a display.
During this process, the values the user didn't input (like three angles for a SSS triangle) are solved for and also displayed.

Unfortunately, I was unable to make the input of SSA work with the other triangles due to the fact that that input can correspond
to two separate triangles, meaning a list is the most practical option to store the values. This made it not function properly as 
a GeneralTriangle, as it contained a list with the needed outputs while the other triangles contained a variety of GeneralTriangle.
Because of this, a little bit of hijinks was needed to make due with the difference in outputs. I suspect there is a way to make
it work that I'm not aware of or didn't think of, but the program I've made functions to its purpose, so it'll have to due.

I was able to learn a lot about Windows Forms in doing this project which I'm grateful for. I was able to create a program using
this very different GUI, which makes it so that this marks a great achievement for me, as I'm now able to better grasp programming
as a general tool instead of a console output only. 