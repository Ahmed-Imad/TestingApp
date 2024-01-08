using TestingApp;

UserMessages.PrintHeader();
UserMessages.WelcomeUserName(CollectData.GetUserFullName());
//CollectData.ProcessUserChoice();

if (CollectData.ProcessUserChoice() != false)
{
    Console.WriteLine(CollectData.RatePerformance(CollectData.AskUserQuestions()));
    
}
    UserMessages.CopyWrite();


Console.ReadLine();


// CHAT GPT SUGGESTION >>>


//UserMessages.PrintHeader();
//string fullName = CollectData.GetUserFullName();
//bool userWantsToAnswerQuestions = CollectData.ProcessUserChoice();

//if (userWantsToAnswerQuestions)
//{
//    int totalScore = CollectData.AskUserQuestions();
//    Console.WriteLine(CollectData.RatePerformance(totalScore));
//}

//UserMessages.CopyWrite();
//Console.ReadLine();











