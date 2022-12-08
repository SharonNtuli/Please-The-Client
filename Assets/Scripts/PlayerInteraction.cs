using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private OnClickEvents onClickEvents;

    // Start is called before the first frame update
    void Start()
    {
        onClickEvents = GameObject.FindObjectOfType<OnClickEvents>();
    }

    // Update is called once per frame
    void Update()
    {
        // randomise the questions in each level
        Interaction(0 /*Random.Range(0, 4)*/);
    }

    public void Interaction(int levelIndex)
    {
        if (onClickEvents.isLevelOne)
        {
            // Each case should be a question for randomising
            switch (levelIndex)
            {
                // Questions, First scenario
                case 0:
                    //Why do you sell rotten fruits? Do you want to kill us?
                    break;

            }

            onClickEvents.isLevelOne = false;
        }

        if (onClickEvents.isLevelTwo)
        {
            // Each case should be a question for randomising
            switch (levelIndex)
            {
                // Questions
            }

            onClickEvents.isLevelTwo = false;
        }

        if (onClickEvents.isLevelThree)
        {
            // Each case should be a question for randomising
            switch (levelIndex)
            {
                // Questions
            }

            onClickEvents.isLevelThree = false;
        }

        if (onClickEvents.isLevelFour)
        {
            // Each case should be a question for randomising
            switch (levelIndex)
            {
                // Questions
            }

            onClickEvents.isLevelFour = false;
        }

        if (onClickEvents.isLevelFive)
        {
            // Each case should be a question for randomising
            switch (levelIndex)
            {
                // Questions
            }

            onClickEvents.isLevelFive = false;
        }

    }
}
