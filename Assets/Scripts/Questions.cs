using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
{
    public List<string> questions = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        questions.Add("Why do you sell rotten fruits? Do you want to kill us?");
        questions.Add("The fruits you sold to me yesterday were rotten");
        questions.Add("Who are you to tell me to calm down? The fruits you sold to me yesterday were rotten!");
        questions.Add("I threw them away when I realised that they were rotten");
        questions.Add("Are you saying that I am lying that the fruits were rotten?");
        questions.Add("Yes I Do, I was with my neighbour when I opened them");
        questions.Add("Were you expecting me to the carry rotten fruits all the way here? I've thrown them away already!");
        questions.Add("Ok, I will come with her tomorrow");
        questions.Add("What you sold rotten fruits to me, give me my money back! I'll never buy fruits from you again and I'll tell the whole community you sell rotten fruit!");
        questions.Add("No problem, Thank you for your help");
    }
}
