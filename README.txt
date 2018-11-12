EPL 426-Computer Graphics 
Lab Teacher: Mr. Ladas Nicolas
Student: Stefanos Ioannou
ID: 945470

Implemented:
1.Different materials, skybox, height maps, textures on gameobjects.
2.Rotate ,Translate, Reloading, Firing ,Increasing chain weight of Trebuchet.
3.Playground to hit cube targets.
4.Functionality scene where all the functions of the Trebuchet are shown.
5.No-Functionality scene that only when you press play fires the payload.
6.Reloading is realistic using Quaternion Slerp function.
7.The bag which is the payload inside is made out of multiple joints.

**SOS***
***Delays are added to the functionalities. Please note to wait for the reload to finish and then
rotate or fire the Trebuchet.There is one second delay in order for
the reloading to be complete,also half second on rotating and firing so
if user commits both rigidbodies will not be messed up.

**Unity Text Functionality Scene**
''spacebar''-> Fire

''r'' -> Reloading
Left Arrow - Right Arrow -> Rotate
Up Arrow - Down Arror -> Increase size of weight (Chain)

MouseButton -> Move 
Please commit one action at a time 

and always wait to reload complete 
and then move or rotate.

Mass of Chain Gameobject must be between

100 and 1500 to physics to work correctly

with the structure. 

