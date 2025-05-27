# WPF Basics

## Exercise-description
The window has a height of 300 pixels and a width of 500 pixels immediately after startup. The window has the title "M120 Pruefung 2022".  
The first line has a fixed height of 20 pixels and contains the text "Good luck", left-aligned, font size 12.  
On the second line, left side, there are two areas with buttons. On the second line, right side, there is a ListBox whose size
can be dynamically adjusted at runtime using a splitter.  

In the upper area, the buttons dynamically adjust their size in the same ratio. 
The buttons in the lower area move their size always maintained automatically to the upper or lower lines, depending on the space ratio. 
The ratio of upper buttons to lower buttons is 3:1. Immediately after the start, the ratio of the left area of the splitter to the right area of the splitter is 4:1. 
This means that after the start, the ListBox is four times smaller than the whole left area. 
There should be a distance of 5 pixels between the buttons. The distance from button 1 and 2 to the top is 0 pixels. 
The width of the splitter is also 5 pixels. Attention: On the left side of the splitter the distance from splitter to buttons 2, 4 and 6 is also 5 pixels. 
On the right column there is the listbox in the upper area. In the lower area you can see the background color lavender. 
The ratio of the upper area (list box) to the lower area is 1:2.  
