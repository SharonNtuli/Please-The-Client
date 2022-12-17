using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    private Answers answers;
    private Questions questions;
    private ScrollingText customerText;
    private OnClickEvents onClickEvents;

    private int currentQuestion = 0;

    public TextMeshProUGUI responseOne;
    public TextMeshProUGUI responseTwo;

    // Start is called before the first frame update
    void Start()
    {
        onClickEvents = GameObject.FindObjectOfType<OnClickEvents>();
        customerText = GameObject.FindObjectOfType<ScrollingText>();
        answers = GameObject.FindObjectOfType<Answers>();
        questions = GameObject.FindObjectOfType<Questions>();
    }

    // Update is called once per frame
    void Update()
    {
        // randomise the questions in each level, each level will have it's own playerinteraction scripts
        //Interaction(SceneManager.GetActiveScene().name, 0 /*Random.Range(0, 4)*/);
    }

    public void Interaction(string levelName, int levelIndex)
    {
        if (levelName == "Level 1")
        {
            // Each case should be a question for randomising
             switch (levelIndex)
             {
                 // Questions, First scenario
                 case 0:
                    //currentQuestion++;
                    if (!onClickEvents.selectFirst && !onClickEvents.selectSecond && currentQuestion == 0)
                    {
                        customerText.itemInfo = new[] { questions.questions[0] };
                        responseOne.text = answers.answers[0, 0];//
                        responseTwo.text = answers.answers[0, 1];

                        currentQuestion++;
                    }
                    

                   
                    if (onClickEvents.selectFirst && !onClickEvents.selectSecond && currentQuestion == 1)
                     {
                        customerText.itemInfo = new[] { questions.questions[1] };
                        responseOne.text = answers.answers[1, 0];
                        responseTwo.text = answers.answers[1, 1];//

                        currentQuestion++;
                        Debug.Log("Select first");
                        onClickEvents.selectFirst = false;
                     }

                     if (onClickEvents.selectSecond && !onClickEvents.selectFirst && currentQuestion == 1)
                     {
                        customerText.itemInfo = new[] { questions.questions[2] };
                        responseOne.text = answers.answers[1, 0];
                        responseTwo.text = answers.answers[1, 1];//

                        currentQuestion++;
                        Debug.Log("Select second");
                        onClickEvents.selectSecond = false;
                     }

                    if (onClickEvents.selectSecond && !onClickEvents.selectFirst && currentQuestion == 2)//
                    {
                        customerText.itemInfo = new[] { questions.questions[3] };
                        responseOne.text = answers.answers[2, 1];//
                        responseTwo.text = answers.answers[2, 0];

                        currentQuestion++;
                        Debug.Log("Select second");
                        onClickEvents.selectSecond = false;
                    }

                    if (onClickEvents.selectFirst && !onClickEvents.selectSecond && currentQuestion == 2)
                    {
                        customerText.itemInfo = new[] { questions.questions[4] };
                        responseOne.text = answers.answers[2, 1];//
                        responseTwo.text = answers.answers[2, 0];

                        currentQuestion++;
                        Debug.Log("Select first");
                        onClickEvents.selectFirst = false;
                    }


                    if (onClickEvents.selectFirst && !onClickEvents.selectSecond && currentQuestion == 3)
                    {
                        customerText.itemInfo = new[] { questions.questions[4] };
                        responseOne.text = answers.answers[3, 0];//
                        responseTwo.text = answers.answers[3, 1];

                        currentQuestion++;
                        Debug.Log("Select first");
                        onClickEvents.selectFirst = false;
                    }

                    if (onClickEvents.selectSecond && !onClickEvents.selectFirst && currentQuestion == 3)
                    {
                        customerText.itemInfo = new[] { questions.questions[5] };
                        responseOne.text = answers.answers[4, 0];//
                        responseTwo.text = answers.answers[4, 1];

                        currentQuestion++;
                        Debug.Log("Select second");
                        onClickEvents.selectSecond = false;
                    }

                    if (onClickEvents.selectSecond && !onClickEvents.selectFirst && currentQuestion == 4)//
                    {
                        customerText.itemInfo = new[] { questions.questions[6] };
                        responseOne.text = answers.answers[4, 0];//
                        responseTwo.text = answers.answers[4, 1];

                        currentQuestion++;
                        Debug.Log("Select second");
                        onClickEvents.selectSecond = false;
                    }

                    if (onClickEvents.selectFirst && !onClickEvents.selectSecond && currentQuestion == 4)
                    {
                        customerText.itemInfo = new[] { questions.questions[7] };
                        responseOne.text = answers.answers[5, 0];
                        responseTwo.text = answers.answers[5, 1];//

                        currentQuestion++;
                        Debug.Log("Select first");
                        onClickEvents.selectFirst = false;
                    }


                    if (onClickEvents.selectSecond && !onClickEvents.selectFirst && currentQuestion == 5)
                    {
                        customerText.itemInfo = new[] { questions.questions[8] };
                        responseOne.text = "GAMEOVER!";
                        responseTwo.text = "GAMEOVER!";

                        Debug.Log("GAMEOVER!");
                        onClickEvents.selectSecond = false;
                    }

                    if (onClickEvents.selectSecond && !onClickEvents.selectFirst && currentQuestion == 5)
                    {
                        customerText.itemInfo = new[] { questions.questions[9] };
                        responseOne.text = answers.answers[6, 0];//
                        responseTwo.text = answers.answers[6, 1];

                        currentQuestion++;
                        Debug.Log("Select second");
                        onClickEvents.selectSecond = false;
                    }

                    if (!onClickEvents.selectSecond && onClickEvents.selectFirst && currentQuestion == 6)
                    {
                        customerText.itemInfo = new[] { "CONGRATULATIONS YOU WON" };
                        
                       
                        Debug.Log("WIN");
                        onClickEvents.selectSecond = false;
                    }

                    break;

             }

             onClickEvents.isLevelOne = false;
        }

        if (onClickEvents.isLevelTwo)
        {
          /*  // Each case should be a question for randomising
            switch (levelIndex)
            {
                // Questions
            }

            onClickEvents.isLevelTwo = false; */
        }
    }
}
