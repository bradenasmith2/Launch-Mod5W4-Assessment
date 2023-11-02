# Week 4 Assessment

In this week's assessment, imagine you have been scheduled for a half-day interview.  The first part of the interview is a technical challenge!  You will have 90 minutes to complete a technical challenge and provide some reflection.

## Technical Challenge (10 points)

### Setup
* Fork and clone this repository.
* Click on 'Planets' in the navbar and make sure you see the 8 planets of our solar system.
* Checkout a new branch and complete the following task.

Your task is to add the explored planets of the galaxy 'Far Far Away' (all of the planets in the star wars films, as outlined in the SWAPI API).

We would like you to get the necessary data by consuming the [SWAPI](https://swapi.dev/) API.  A successful mission will:
* Use HttpClient to make an API call to SWAPI when a request comes in (to get the most up-to-date information!)
* Display the known planets of the Far Far Away Galaxy on a view.
  * Be sure to include the name and population of each planet.

Outside of those requirements, you may choose to add any additional functionality!

When finished, create a PR and include your answers to the reflection questions below in a PR comment.

## Reflection Questions (6 points)
* What about this challenge was most difficult for you?
   * By far the most challenging piece of this assessment was correctly converting the data from the API into my FarFarAwayPlanet object. At first, I was using the 'Planet' class to structure the incoming data, but then opted for creating a new class with what I belieced to be all incoming properties, however this still wasn't working for me.
* Highlight one peice of code that you wrote that you are especially proud of.
   * Since a vast majority of the code is near identical to other API implementations I have done, there is no specific code that I'm super proud of. However, one thing I would like to highlight instead is my organization of the files / chunks of code. In the [FarFarAwayGalaxy Service]() I've structured the blocks of code into the 'steps' of calling an API - this helps me and those who use this code after me decipher what is happening at a glance. Additionally, my folder structure is implemented in a way that could be easily expandable if I were to introduce more APIs, or even just interfaces.
* What would you do next, if we gave you another hour?
   * If I had another hour, I would definitely try to figure out why my JSON data won't convert. Specifically, I would introduce Serilog to the project so that I can get informative logs that would help me identify the area of concern. Also, I would do limited research to further determine if I need ALL properties from the JSON object - or just those I care about. Time permitting, I would also implement more sustainable error handling with Serilog to ensure that if my API call isn't successful, I know why, and my user will be alerted without the program crashing.

## Rubric

This assessment has a total of 16 points.  Earning 10 or more points is a pass.

For the technical challenge, we are looking for:
* 2 Points - successful creation of a HTTPClient
* 2 Points - correct URL configuration
* 1 point - making a get request
* 2 points - turning the response into a list of planets
* 3 points - getting the requested planets showing up on a page

