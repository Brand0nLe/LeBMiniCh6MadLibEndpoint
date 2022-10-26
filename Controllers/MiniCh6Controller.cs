//Brandon Le
//10-26-22
//Mini Challenge 6 - MAD LIB
//Web API project that will take users inputs from the URL and it will print out a MAD LIB with the users inputs. I included a instructions page to help the user and guide them to which input comes next ex: name1, number1, etc. I also provided a example to show how it would look as a finished URL or if they were lazy and wanted to use my story.
//Peer Review: Andrea Burr i really like the program it runs nice its a supre cute mad lib and it kinda has a play again which is nice!



using Microsoft.AspNetCore.Mvc;

namespace MiniCh6MadLibEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh6Controller : ControllerBase
{   public string Instructions(){
    return "Hello! Let's do a MAD LIB together! :) \n First you will need to collect the following information: \n\n Choose a name. \n Choose another name. \n Choose a yummy flavor. \n Choose a nasty flavor. \n Choose a number. \n Choose an animal. \n Choose a color. \n Choose another number. \n Choose an emotion. \n Choose one last number!\n\n Awesome you have everything chosen! Now you just have to input them into the URL!\n Enter the following URL with your chosen inputs:\n https://localhost:7242/MiniCh6/MadLib/name1/name2/yummyflavor/nastyflavor/number1/animal/Color/number2/emotion/number3 \n For example my madlib URL would be:\n https://localhost:7242/MiniCh6/MadLib/Brandon/Daniel/Chocolate/banana/4/giraffe/red/7/sad/100\n Copy and paste it to try it out or you can make your own mad lib! Have fun! :)\n\n\n **Double check your localhost to make sure that's correct before running your URL**";
}

    [HttpGet]
    [Route("MadLib/{nameOne}/{nameTwo}/{yummyFlavor}/{nastyFlavor}/{number1}/{animal}/{color}/{number2}/{emotion}/{number3}")]
    public string MadLib(string nameOne, string nameTwo, string yummyFlavor, string nastyFlavor, int number1, string animal, string color, int number2, string emotion, int number3)
    {
    return $"One day there were two friends named {nameOne} and {nameTwo}. {nameOne} decided they wanted to bake a {yummyFlavor} cake and asked {nameTwo} to come over and help. While they were mixing the ingredients {nameTwo} accidentally grabbed the wrong flavor and added in {nastyFlavor}! Neither of them realized and just continued baking. After {number1} hours they finally finished baking the cake and were ready to decorate. They shaped the cake into a {animal} and put {color} icing on it. After {number2} hours of decorating they finally finished and could taste it! They both took a bite and immediately spit out! Why did the cake taste like {nastyFlavor}?! They were feeling {emotion} after their huge failure and decided to door dash {number3} orders of french fries to make themselves feel better.\n\n\n\n How was it? Wasn't it a ton of fun?! If you'd like to start over copy and paste this url or click the link and then press send: https://localhost:7242/MiniCh6/ **Remember to verify the localhost number**";
    }
}
