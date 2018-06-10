# FAPlutoRover
Improvments to add:
- While test cases was enough to implement the main structure of the app, but It need to add many more test cases as unit test, this can be done by adding a data source for the test to start, somthing like a simple xml file contain more test cases data examples.
- Allow dynamic starting point for the rover on the surface
- Add validation while adding obstacles to the surface to make sure they are within the boundries of the surface grid
- Implement usage of undo in commands to undo the last command if obstacle is found
- Improvemnt on the obstacles implementation:
  - Landscape will have all obstacles inisitaised on creation
  - Command check for obstacle and undo last command
  - Command call a roverReporter class passing the found obstacle position or call the rover itself which will have a report method to stamp foudn obstacles
- Implement the simulator console app to view the api in action as a demo of the functionality.
