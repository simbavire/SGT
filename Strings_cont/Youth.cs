using System;
namespace Strings_cont
{
class Youth

{
    public int Age;
    public string  Interests;
    public string Social;

    public Youth (int AgeYears, string InterestsHobby, string SocialMedia = "Instagram")
    {
       Age = AgeYears;
       Interests =  InterestsHobby;
       Social = SocialMedia;
       Console.WriteLine(DateTime.Now);
    }

}}