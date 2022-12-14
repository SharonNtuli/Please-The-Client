using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickEvents : MonoBehaviour
{
    public GameObject optionOne;
    public GameObject optionTwo;

    public GameObject checkMark;
    public GameObject checkMark1;

    public GameObject backToOption;

    public GameObject firstResponse;
    public GameObject secondResponse;
    public GameObject customersButton;
    public GameObject bluePanel;

    private int resumeIndex;

    public bool isLevelOne = false;
    public bool isLevelTwo = false;
    public bool isLevelThree = false;
    public bool isLevelFour = false;
    public bool isLevelFive = false;

    public bool firstOption = false;
    public bool selectFirst = false;
    public bool secondOption = false;
    public bool selectSecond = false;

    public bool isCustomerMessage = true;

    // Start is called before the first frame update
    void Start()
    {
        // Get Player's current level
        resumeIndex = GameManager.currentLevelIndex;
        
    }

    public void NewGame()
    {
        // Load progress panel scene
        SceneManager.LoadScene("ProgressScene");
    }

    public void Resume()
    {
        // Load current level
        SceneManager.LoadScene(resumeIndex);
        Debug.Log("Resume");
    }

    public void LevelOne()
    {
        SceneManager.LoadScene("Level 1");
        Debug.Log("isLevelOne = true");
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene("Level 2");
        isLevelTwo = true;
    }

    public void LevelThree()
    {
        // proceed to level 3

        isLevelThree = true;
        Debug.Log("Level_3");
    }

    public void LevelFour()
    {
        // proceed to level 4

        isLevelFour = true;
        Debug.Log("Level_4");
    }

    public void LevelFive()
    {
        // proceed to level 5

        isLevelFive = true;
        Debug.Log("Level_5");
    }

    public void SelectFirst()
    {
        selectSecond = false;
        selectFirst = true;
        //prevent more than one selection
    }

    public void SelectSecond()
    {
        selectFirst = false;
        selectSecond = true;
        //prevent more than one selection
    }

    public void FirstOption()
    {
        secondOption = false;
        firstOption = true;
        isCustomerMessage = false;
        //UI panel to display response so player can choose from
        checkMark.SetActive(false);
        checkMark1.SetActive(false);
        backToOption.SetActive(true);

        optionOne.SetActive(false);
        optionTwo.SetActive(false);

        customersButton.SetActive(false);
        // Set answer panel active for player to read
        firstResponse.SetActive(true);
    }

    public void SecondOption()
    {
        firstOption = false;
        secondOption = true;
        isCustomerMessage = false;
        //UI panel to display response so player can choose from
        checkMark.SetActive(false);
        checkMark1.SetActive(false);
        backToOption.SetActive(true);

        optionOne.SetActive(false);
        optionTwo.SetActive(false);

        customersButton.SetActive(false);
        // Set answer panel active for player to read
        secondResponse.SetActive(true);
    }

    public void CustomerButton()
    {
        GameObject.FindObjectOfType<PlayerInteraction>().Interaction(SceneManager.GetActiveScene().name, 0);
        StartCoroutine(DelayOptions(10.0f));
    }

    IEnumerator DelayOptions(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        optionOne.SetActive(true);
        optionTwo.SetActive(true);

        checkMark.SetActive(true);
        checkMark1.SetActive(true);
        // How do you response panel
        bluePanel.SetActive(true);
    }

    public void BackToOption()
    {
        isCustomerMessage = true;

        //UI panel for player to choose an answer
        checkMark.SetActive(true);
        checkMark1.SetActive(true);
        customersButton.SetActive(true);
        backToOption.SetActive(false);
        //disable both answer panel
        firstResponse.SetActive(false);
        secondResponse.SetActive(false);

        optionOne.SetActive(true);
        optionTwo.SetActive(true);
    }

    public void BackButton()
    {
        // take back to Mainmenu
        SceneManager.LoadScene(0);
        Debug.Log("Back");
    }

    public void Cancel()
    {
        // returns to scene with levels
        SceneManager.LoadScene("ProgressScene");
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}