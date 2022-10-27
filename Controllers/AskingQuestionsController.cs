//Jeremy Lapham
//10-25-22
//Asking Questions- Endpoint
//This program will have the user put in their name and ask the user a question and they answer
//Peer review: Brandon Le - project works as intended I was able to input both my name and a time and it was printed back to me. Very good job! 
using Microsoft.AspNetCore.Mvc;

namespace LaphamJAskingQuestions_Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingQuestionsController : ControllerBase
{
   [HttpGet]
   [Route("Asking/{name}/{answerToQuestion}")]

   public string AskingQuestions(string name, string answerToQuestion)
   {
    return $"Hello {name}! \n What time did you wake up today? \n {answerToQuestion} WOW THATS CRAZY!";
   }
}
