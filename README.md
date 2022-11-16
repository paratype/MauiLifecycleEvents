# MauiLifecycleEvents
The app demonstates that Maui lifecycle events are not being fired correctly under macOS

Debug mode:
 - Window.Stopped event (App.xaml.cs) fired when the app is minimized using Cmd+H and not fired when clicking on the yellow button
 
 Release mode:
  - Window.Stopped event (App.xaml.cs) not fired when using either metod to minimize the app window
  
