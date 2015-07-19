**YouTube Video - https://www.youtube.com/watch?v=ykFj582AoDY **

**GitHub sample - https://github.com/jamesqquick/Win10Universal/tree/master/HamburgerButton **

**Blog Post http://jamesqquick.com/windows-10-splitview-creating-a-hamburger-button/**

** To run this sample, simply clone on your local PC running Windows 10 and open with Visual Studio 2015! **

Although we have added the SplitView control to XAML with the ability to create a hamburger menu, we lack documentation on how to actually create the hamburger button.  Honestly, I have searched and found very few things that provide insight and no documentation that shows exactly how to do so.  Because of this, I figured it would be nice to go ahead and document that here.

The idea is pretty simple, basically we are just creating a button and styling it as a hamburger button.  But where do we find the Hamburger Icon?  For this we are going to use the Segoe MDL2 Assets font.  You can find a list of the different icons available in this font here, http://modernicons.io/segoe-mdl2/cheatsheet/.  This site provides all the codes for the different icons.  So, where exactly is the Hamburger Button?  There it is!  I just did a Control+F to find it.

Alright, so we know where our icon is, let’s go ahead and create one in XAMl.  Again, we are going to create a simple button and set the FontFamily to the Segoe MDL2 Assets font and the content to the code that references the specific hamburger button icon, “&#E700;”.  The XAML looks like.

<Button x:Name="HamburgerButton" FontFamily="Segoe MDL2 Assets" Content="&#xE700;"/>

We have not yet create our actual menu, but since there was so little documentation on creating the actual button, i figured we would start there!  That’s it.  It’s that simple!  Comment or find me on twitter @jamesqquick with any questions, comments, or concerns!

