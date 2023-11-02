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
  The intial challenge was first understadning how the Swapi API worked and feeling comfortable in the documentation. There were a few hiccups making sure I had the right root url and the right path to get all of the planets. After I made sure I had the right root Url for the BaseAddress and the right path for all the planets I was good to go. The second challenge that spent most of my time on was Deserializeing the data from the request as swapi keeps track of more than just the name and population. My first thought was to more properties to the model to handel all the other data from the incoming response. However I decided agaist this because it would add bloat to the planet class as we don't need any other information besides the name and population of a planet. So my next approach was to do some googleing as I have not had a lot of experience desserilizing specfic parts of a Json response. My first stop was here https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/missing-members. But I was unable to succesfully implent the documentaion. I then spent some time browsing stack for related questions and lastly I spent some time on Youtube looking for a tutorial. Unfortunalty I came up just a bit short.
  
* Highlight one peice of code that you wrote that you are especially proud of.
  One piece of code I'm proud of is implenting an IstarwarApi interface that is inherited by the StarwarApi service. I have in previous projects where I've had to make requests to an API, that using an interfaces allows for easier implementaion of tests. It also allows me to use dependency injection in the planetsController
  
* What would you do next, if we gave you another hour?
I was successful in making a request for all the plants from swapi, (I know this because when I ran the debugger the `stringresponse` variable had all the plants stored). I was not able to deserialize them so they fit into the expected planet model of just a name & population. Given more time I would figure out a way to properly deserialize the response from swapi. 

## Rubric

This assessment has a total of 16 points.  Earning 10 or more points is a pass.

For the technical challenge, we are looking for:
* 2 Points - successful creation of a HTTPClient
* 2 Points - correct URL configuration
* 1 point - making a get request
* 2 points - turning the response into a list of planets
* 3 points - getting the requested planets showing up on a page

